using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notebook
{
    public partial class FrmFont : Form
    {   
        /// <summary>
        /// 글꼴 이름 정보
        /// </summary>
        public string _FontName { get; set; }

        /// <summary>
        /// 글꼴 스타일 정보
        /// </summary>
        public FontStyle _FontStyle { get; set; }

        /// <summary>
        /// 글꼴 크기 정보
        /// </summary>
        public float _FontSize { get; set; }

        /// <summary>
        /// 설치된 글꼴 목록
        /// </summary>
        FontFamily[] fontFamilies;

        /// <summary>
        /// 설치된 글꼴들의 스타일 목록
        /// </summary>
        List<FontStyle> fontStyles = new List<FontStyle>();

        /// <summary>
        /// 글꼴 크기 목록
        /// </summary>
        float[] sizes = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };

        /// <summary>
        /// 설치된 글꼴 모음 객체
        /// </summary>
        InstalledFontCollection installedFontCollection = new InstalledFontCollection();

        /// <summary>
        /// 글꼴 적용 대리자/이벤트
        /// </summary>
        /// <param name="fontFamily"></param>
        /// <param name="fontStyle"></param>
        /// <param name="fontSize"></param>
        public delegate void delFontChange(FontFamily fontFamily, FontStyle fontStyle, float fontSize);
        public event delFontChange eFontChange;

        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="fontName"></param>
        /// <param name="fontStyle"></param>
        /// <param name="fontSize"></param>
        public FrmFont(string fontName, FontStyle fontStyle, float fontSize)
        {
            InitializeComponent();

            _FontName = fontName;
            _FontStyle = fontStyle;
            _FontSize = fontSize;
            
            fontFamilies = installedFontCollection.Families;

            foreach (FontFamily fontFamily in FontFamily.Families)
            {
                foreach (FontStyle style in Enum.GetValues(typeof(FontStyle)))
                {
                    if (fontFamily.IsStyleAvailable(style))
                    {
                        fontStyles.Add(style);
                    }
                }
            }
            
            fontStyles = fontStyles.Distinct().ToList();

            foreach (var fontFamily in fontFamilies)
            {
                cboxFont.Items.Add(fontFamily.Name);
            }

            foreach (var style in fontStyles)
            {
                cboxStyle.Items.Add(style.ToString());
            }

            foreach (var size in sizes)
            {
                cboxSize.Items.Add(size);
            }

            ChangeSelectedIdx(_FontName, cboxFont);
            ChangeSelectedIdx(_FontStyle, cboxStyle);
            ChangeSelectedIdx(_FontSize, cboxSize);
        }
        
        /// <summary>
        /// 콤보박스의 선택된 인덱스 변경
        /// </summary>
        /// <param name="value"></param>
        /// <param name="cbox"></param>
        private void ChangeSelectedIdx(object value, ComboBox cbox)
        {
            int idx = cbox.Items.IndexOf(value);
            if (idx >= 0)
            {
                cbox.SelectedIndex = idx;
            }
        }

        /// <summary>
        /// 글꼴 폼 닫힘 이벤트 입니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmFont_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        /// <summary>
        /// 글꼴 콤보박스 그리기 이벤트 입니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboxFont_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                // ComboBox의 항목 텍스트 가져오기
                string text = cboxFont.GetItemText(cboxFont.Items[e.Index]);

                // ComboBox의 항목에 적용할 글꼴 생성
                Font font = new Font(text, 12.0f);

                DrawSelected(text, font, e);
            }
        }

        /// <summary>
        /// 스타일 콤보박스 그리기 이벤트 입니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboxStyle_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                string text = cboxStyle.GetItemText(cboxStyle.Items[e.Index]);
                Font font = new Font(text, 12.0f, (FontStyle) Enum.Parse(typeof(FontStyle), text));

                DrawSelected(text, font, e);
            }
        }

        /// <summary>
        /// 콤보박스 선택/비선택 그리기 함수
        /// </summary>
        /// <param name="text"></param>
        /// <param name="font"></param>
        /// <param name="e"></param>
        private void DrawSelected(string text, Font font, DrawItemEventArgs e)
        {
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                Color highlight = Color.FromArgb(0, 122, 204);
                Brush highlightBrush = new SolidBrush(highlight);

                e.Graphics.FillRectangle(highlightBrush, e.Bounds);
                e.Graphics.DrawString(text, font, Brushes.White, e.Bounds);
            }
            else
            {
                e.Graphics.FillRectangle(Brushes.White, e.Bounds);
                e.Graphics.DrawString(text, font, Brushes.Black, e.Bounds);
            }
        }

        /// <summary>
        /// 글꼴 콤보박스 선택 변경 이벤트 입니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboxFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxFont.SelectedIndex >= 0)
            {
                cboxStyle.Items.Clear();

                FontFamily selectedFont = FontFamily.Families.First(x => x.Name == (string) cboxFont.SelectedItem);

                foreach (FontStyle style in Enum.GetValues(typeof(FontStyle)))
                {
                    if (selectedFont.IsStyleAvailable(style))
                    {
                        cboxStyle.Items.Add(style);
                    }
                }

                _FontName = cboxFont.GetItemText(cboxFont.Items[cboxFont.SelectedIndex]);
                ChangeLabel();
                GetLanguage(selectedFont);
            }            
        }

        private void GetLanguage(FontFamily selectedFont)
        {
            HashSet<string> languages = new HashSet<string>();

            // TextRenderingHint 가져오기
            TextRenderingHint textRenderingHint = (TextRenderingHint) selectedFont.GetCellAscent(_FontStyle);
            // 언어 코드 가져오기
            switch (textRenderingHint)
            {
                case TextRenderingHint.ClearTypeGridFit:
                    languages.Add("zh-Hans");
                    languages.Add("zh-Hant");
                    break;
                case TextRenderingHint.AntiAlias:
                case TextRenderingHint.AntiAliasGridFit:
                    languages.Add("en");
                    break;
                case TextRenderingHint.SingleBitPerPixel:
                case TextRenderingHint.SingleBitPerPixelGridFit:
                    languages.Add("ja");
                    languages.Add("ko");
                    break;
            }

            // 출력
            foreach (string language in languages)
            {
                Console.WriteLine(language);
            }
        }

        /// <summary라벨
        /// > 변경 함수
        /// </summary>
        private void ChangeLabel()
        {
            foreach (var fontfamily in fontFamilies)
            {
                if (fontfamily.Name == _FontName)
                {
                    using (Font font = new Font(fontfamily, _FontSize, _FontStyle))
                    {
                        lblTest.Font = font;
                    }
                    break;
                }
            }
        }

        /// <summary>
        /// 스타일 콤보 박스 선택 변경 이벤트 입니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboxStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FontStyle = (FontStyle) cboxStyle.SelectedItem;
            ChangeLabel();
        }

        /// <summary>
        /// 사이즈 콤보 박스 선택 변경 이벤트 입니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxSize.SelectedItem != null)
            {
                _FontSize = (float) cboxSize.SelectedItem;
                ChangeLabel();
            }
        }

        /// <summary>
        /// 확인 버튼 클릭 이벤트 입니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            FontFamily ff = null;

            foreach (var fontfamily in fontFamilies)
            {
                if (fontfamily.Name == _FontName)
                {
                    ff = fontfamily;
                    break;
                }
            }

            eFontChange(ff, _FontStyle, _FontSize);
            this.Hide();
        }

        /// <summary>
        /// 취소 버튼 클릭 이벤트 입니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
