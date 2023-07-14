using Notebook.Global;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Notebook
{
    public partial class FrmMain : Form
    {
        #region property

        /// <summary>
        /// 저장 여부를 나타냄
        /// </summary>
        private bool _isSaved = true;
        public bool IsSaved
        {
            get
            {
                return _isSaved;
            }

            set
            {
                if (_isSaved != value)
                {
                    _isSaved = value;
                    OnPropertyChanged(nameof(IsSaved));
                }
            }
        }

        /// <summary>
        /// Load된 file의 string
        /// </summary>
        private string loadedString = string.Empty;

        /// <summary>
        /// 현재 파일의 경로를 나타냄
        /// </summary>
        private string _fileName = string.Empty;

        /// <summary>
        /// 키보드 후킹 클래스
        /// </summary>
        KeyboardHooking _kbdHook = new KeyboardHooking();

        /// <summary>
        /// 찾기&바꾸기 Form
        /// </summary>
        FrmFindReplace frmFindReplace = new FrmFindReplace();

        private bool _isSusikOpen = false;

        FrmFont frmFont;

        #endregion

        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.PropertyChanged += Form1_PropertyChanged;
            frmFindReplace.eBtnFind += FrmFindReplace_eBtnFind;
            frmFindReplace.eBtnReplace += FrmFindReplace_eBtnReplace;
            _kbdHook.hook();
            _kbdHook.KeyDown += _kbdHook_KeyDown;
            frmFont = new FrmFont(rtxtMemo.Font.Name, rtxtMemo.Font.Style, rtxtMemo.Font.Size);
            frmFont.eFontChange += FrmFont_eFontChange;
            //인코딩, OS, 배율, 로케이션
            
            AddZoomFactor();
        }        
        
        private void AddZoomFactor()
        {
            stripMagnification.Text = $@"{rtxtMemo.ZoomFactor * 100}%";
        }

        #region property changed

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void Form1_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (!_isSaved)
            {
                this.Text = "RTFViewer *";
                SwitchMenuStripBtn(menuStrip, "파일", "저장", true);
            }
            else
            {
                this.Text = "RTFViewer";
                SwitchMenuStripBtn(menuStrip, "파일", "저장", false);
            }
        }

        #endregion

        #region function

        /// <summary>
        /// MenuStrip의 Dropdouwn 버튼 활성화 여부 변경
        /// </summary>
        /// <param name="strip"></param>
        /// <param name="menuName"></param>
        /// <param name="dropdownName"></param>
        /// <param name="switchValue"></param>
        private void SwitchMenuStripBtn(MenuStrip strip, string menuName, string dropdownName, bool switchValue)
        {
            foreach (ToolStripMenuItem menuItem in strip.Items)
            {
                if (menuItem.Text == menuName)
                {
                    foreach (ToolStripItem item in menuItem.DropDownItems)
                    {
                        if (item.Text == dropdownName)
                        {
                            item.Enabled = switchValue;
                            break;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 저장하기
        /// </summary>
        private bool SaveFile()
        {
            //이미 파일이 존재한다면 해당 파일에 바로 저장할 수 있는 방식이어야함
            //새로 저장한다면 해당 저장 경로 추가
            if (!string.IsNullOrEmpty(_fileName))
            {
                //불러온 파일이라면
                rtxtMemo.SaveFile(_fileName);
                return true;
            }
            else
            {
                SaveFileDialog sfd = new SaveFileDialog();

                sfd.Filter = "rtf files(*.rtf)|*.rtf";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    rtxtMemo.SaveFile(sfd.FileName);
                    _fileName = sfd.FileName;   // 경로 저장
                    sfd.Dispose();
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 불러오기
        /// </summary>
        private void LoadFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "rtf files(*.rtf)|*.rtf";
            ofd.Title = "열기";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                rtxtMemo.LoadFile(ofd.FileName);
                _fileName = ofd.FileName;
                loadedString = rtxtMemo.Rtf;
                IsSaved = true;
            }
        }

        /// <summary>
        /// 내용 변경
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MemoChanged(object sender, EventArgs e)
        {
            if (rtxtMemo.Rtf != loadedString)
            {
                IsSaved = false;
            }
            else
            {
                IsSaved = true;
            }
        }

        /// <summary>
        /// 파일 닫을 시 저장
        /// </summary>
        /// <returns></returns>
        private bool FileClosing()
        {
            if (!IsSaved)
            {
                if (!string.IsNullOrEmpty(_fileName))
                {
                    DialogResult result = MessageBox.Show("변경내용을 저장하시겠습니까?", "RTFViewer", MessageBoxButtons.YesNoCancel);

                    if (result == DialogResult.Yes)
                    {
                        SaveFile();
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        return false;
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("저장하시겠습니까?", "RTFViewer", MessageBoxButtons.YesNoCancel);

                    if (result == DialogResult.Yes)
                    {
                        if (!SaveFile())
                        {
                            return false;
                        }
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private Image ResizeImage(Image image, int width, int height)
        {
            Bitmap resizedImage = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(resizedImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(image, 0, 0, width, height);
            }

            return resizedImage;
        }

        private string GetRtfFromImage(byte[] imageBytes, int width, int height)
        {
            string hexImage = BitConverter.ToString(imageBytes).Replace("-", string.Empty);
            string rtf = $"{{\\rtf1\\ansi\\deff0{{\\pict\\pngblip\\picw{width}\\pich{height}\\picwgoal{width}\\pichgoal{height}\n{hexImage}}}}}";
            return rtf;
        }

        #endregion

        #region event   

        /// <summary>
        /// 폼 클로징 이벤트 입니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!FileClosing())
            {
                e.Cancel = true;
            }
        }        

        #endregion

        #region keyboard hooking

        /// <summary>
        /// 키 다운 이벤트 입니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _kbdHook_KeyDown(object sender, KeyEventArgs e)
        {
            if (_isSusikOpen)
            {
                if (e.KeyCode == Keys.W)
                {
                    //자동 줄바꿈                    
                    자동줄바꿈ToolStripMenuItem_Click(null, null);
                }
                else if (e.KeyCode == Keys.F)
                {
                    //글꼴

                }
            }
            else if (e.Control && e.KeyCode == Keys.V)
            {
                
            }
        }

        #endregion

        #region 파일

        /// <summary>
        /// 새로 만들기 이벤트 입니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNew_Click(object sender, EventArgs e)
        {
            if (!FileClosing())
            {
                return;
            }

            rtxtMemo.Clear();
            IsSaved = true;
        }

        /// <summary>
        /// 열기 이벤트 입니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadFile();
        }

        /// <summary>
        /// 저장 이벤트 입니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsSaved)
            {
                if (SaveFile())
                {
                    IsSaved = true;
                }              
            }
        }

        /// <summary>
        /// 다른 이름으로 저장 이벤트 입니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnotherSave_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        /// <summary>
        /// 종료 이벤트 입니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region 편집

        /// <summary>
        /// 실행 취소 이벤트 입니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (rtxtMemo.CanUndo)
            {
                rtxtMemo.Undo();
            }
        }

        /// <summary>
        /// 잘라내기 버튼 클릭 이벤트 입니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCut_Click(object sender, EventArgs e)
        {
            rtxtMemo.Cut();
        }

        /// <summary>
        /// 복사 버튼 클릭 이벤트 입니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCopy_Click(object sender, EventArgs e)
        {
            rtxtMemo.Copy();
        }

        /// <summary>
        /// 붙여넣기 버튼 클릭 이벤트 입니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPaiste_Click(object sender, EventArgs e)
        {
            //if (Clipboard.ContainsImage())
            //{
            //    Image image = Clipboard.GetImage();

            //    int maxWidth = rtxtMemo.Width;
            //    int maxHeight = rtxtMemo.Height;

            //    Image resizedImage = ResizeImage(image, maxWidth, maxHeight);

            //    using (MemoryStream ms = new MemoryStream())
            //    {
            //        resizedImage.Save(ms, ImageFormat.Png);
            //        string rtf = GetRtfFromImage(ms.ToArray(), maxWidth, maxHeight);
            //        rtxtMemo.SelectedRtf = rtf;
            //    }

            //}
            //else
            //{
            IDataObject clipboardData = Clipboard.GetDataObject();
            string[] formats = clipboardData.GetFormats();

            foreach (var format in clipboardData.GetFormats())
            {
                if (format == DataFormats.Text)
                {
                    rtxtMemo.Paste();
                    return;
                }
                else if(format == DataFormats.Bitmap)
                {

                }
            }

                MessageBox.Show($@"지원되는 형식이 아닙니다.{Environment.NewLine}형식을 확인해주세요.", "Info", MessageBoxButtons.OK);
            //}
        }

        /// <summary>
        /// 삭제 버튼 클릭 이벤트 입니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            int idx = rtxtMemo.SelectionStart;
            if (rtxtMemo.SelectedText.Length > 0)
            {
                rtxtMemo.Text = rtxtMemo.Text?.Remove(rtxtMemo.SelectionStart, rtxtMemo.SelectedText.Length);
            }

            rtxtMemo.SelectionStart = idx;
            rtxtMemo.ScrollToCaret();
        }

        /// <summary>
        /// 구글로 검색하기 버튼 클릭 이벤트 입니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string url = "https://www.google.com/search?q=" + rtxtMemo.SelectedText;
            Process.Start(url);
        }

        /// <summary>
        /// 찾기 버튼 클릭 이벤트 입니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFind_Click(object sender, EventArgs e)
        {
            TabControl tab = frmFindReplace.Controls.Find("tabControl", true)[0] as TabControl;
            TabPage tabFind = frmFindReplace.Controls.Find("tabFind", true)[0] as TabPage;
            tab.SelectedTab = tabFind;

            TextBox txt = tabFind.Controls.Find("txtFindStr", true)[0] as TextBox;
            txt.Text = IsSelectText();

            frmFindReplace.Show();
        }

        /// <summary>
        /// 찾기 대리자
        /// </summary>
        /// <param name="find"></param>
        /// <returns></returns>
        private void FrmFindReplace_eBtnFind(cFindReplace find)
        {
            FindText(find.str, rtxtMemo.SelectionStart, find.isDevied, find.isDown);
        }

        /// <summary>
        /// 문자열 찾기 함수
        /// </summary>
        /// <param name="searchText"></param>
        /// <param name="startIdx"></param>
        /// <param name="matchCase"></param>
        /// <param name="searchDown"></param>
        /// <returns></returns>
        private int FindText(string searchText, int startIdx, bool matchCase, bool searchDown)
        {
            // 검색 시작 위치 지정
            if (startIdx > 0 && startIdx < rtxtMemo.TextLength)
            {
                rtxtMemo.SelectionStart = startIdx;
            }

            // 검색 조건 설정
            var options = RichTextBoxFinds.None;
            if (matchCase)
            {
                options |= RichTextBoxFinds.MatchCase;
            }
            if (!searchDown)
            {
                options |= RichTextBoxFinds.Reverse;
            }

            int idx = 0;
            int lengthIdx = 0;
            int findingIdx = 0;
            if (searchDown)
            {
                int TotalLength = rtxtMemo.Text.Length;
                findingIdx = rtxtMemo.SelectionStart + searchText.Length;

                lengthIdx = findingIdx > TotalLength - 1 ? TotalLength : findingIdx;
                idx = rtxtMemo.Find(searchText, lengthIdx, options);
            }
            else
            {
                findingIdx = rtxtMemo.SelectionStart - searchText.Length;

                lengthIdx = findingIdx < 0 ? 0 : findingIdx;
                idx = rtxtMemo.Find(searchText, 0, lengthIdx, options);
            }

            if (idx == -1)
            {
                idx = rtxtMemo.Find(searchText, options);
            }

            if (idx != -1)
            {
                rtxtMemo.Select(idx, searchText.Length);
            }

            return idx;
        }

        /// <summary>
        /// 바꾸기 버튼 클릭 이벤트 입니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReplace_Click(object sender, EventArgs e)
        {
            TabControl tab = frmFindReplace.Controls.Find("tabControl", true)[0] as TabControl;
            TabPage tabReplace = frmFindReplace.Controls.Find("tabReplace", true)[0] as TabPage;
            tab.SelectedTab = tabReplace;

            TextBox txt = tabReplace.Controls.Find("txtFindToReplace", true)[0] as TextBox;
            txt.Text = IsSelectText();

            frmFindReplace.Show();
        }

        /// <summary>
        /// 선택된 문자열 반환 함수
        /// </summary>
        /// <returns></returns>
        private string IsSelectText()
        {
            if (rtxtMemo.SelectedText.Length > 0)
            {
                return rtxtMemo.SelectedText;
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// 바꾸기 대리자
        /// </summary>
        /// <param name="replaceText"></param>
        /// <param name="isAll"></param>
        /// <param name="isDevide"></param>
        private void FrmFindReplace_eBtnReplace(string findText, string replaceText, bool isAll, bool isDevide)
        {
            if (!isAll)
            {
                //선택된 것만 Replace
                Replace(findText, replaceText, isAll, isDevide);
            }
            else
            {
                //검색되는 모든 문자열 Replace
                int idx = 0;
                int count = 0;
                while (idx != -1)
                {
                    idx = Replace(findText, replaceText, isAll, isDevide);
                    count++;
                }

                MessageBox.Show($@"총 {count}개를 바꿨습니다.", "Info", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// 바꾸기 함수
        /// </summary>
        /// <param name="findText"></param>
        /// <param name="replaceText"></param>
        /// <param name="isAll"></param>
        /// <param name="isDevide"></param>
        /// <returns></returns>
        private int Replace(string findText, string replaceText, bool isAll, bool isDevide)
        {
            int idx = 0;
            if (rtxtMemo.SelectedText != findText)
            {
                idx = FindText(findText, rtxtMemo.SelectionStart, isDevide, true);

                if (idx != -1)
                {
                    rtxtMemo.SelectedText = replaceText;
                    rtxtMemo.Select(idx, replaceText.Length);
                }
            }
            else
            {
                idx = rtxtMemo.SelectionStart;
                rtxtMemo.SelectedText = replaceText;
                rtxtMemo.Select(idx, replaceText.Length);                
            }

            return idx;
        }

        /// <summary>
        /// 모두 선택 버튼 클릭 이벤트 입니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            rtxtMemo.SelectAll();
        }

        /// <summary>
        /// 시간/날짜 버튼 클릭 이벤트 입니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTimeDate_Click(object sender, EventArgs e)
        {
            string now = DateTime.Now.ToString();
            int idx = rtxtMemo.SelectionStart;
            rtxtMemo.Text = rtxtMemo.Text.Insert(idx, now);

            rtxtMemo.SelectionStart = idx + now.Length;
            rtxtMemo.SelectionLength = 0;
            rtxtMemo.ScrollToCaret();
        }

        #endregion

        #region 서식

        /// <summary>
        /// 선택한 부분이 변경되었을 경우 이벤트 입니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rtxtMemo_SelectionChanged(object sender, EventArgs e)
        {
            string selectedText = rtxtMemo.SelectedText;
            if (selectedText.Length < 1)
            {
                btnSearch.Enabled = false;
                btnCut.Enabled = false;
                btnCopy.Enabled = false;
                btnRemove.Enabled = false;
            }
            else
            {
                btnSearch.Enabled = true;
                btnCut.Enabled = true;
                btnCopy.Enabled = true;
                btnRemove.Enabled = true;
            }
        }

        /// <summary>
        /// 서식 탭 비활성화 이벤트 입니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 서식ToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            _isSusikOpen = false;
        }

        /// <summary>
        /// 서식 탭 활성화 이벤트 입니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 서식ToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            _isSusikOpen = true;
        }

        /// <summary>
        /// 자동 줄바꿈 버튼 클릭 이벤트 입니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 자동줄바꿈ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtxtMemo.WordWrap)
            {
                rtxtMemo.WordWrap = false;
                자동줄바꿈ToolStripMenuItem.Checked = false;
            }
            else
            {
                rtxtMemo.WordWrap = true;
                자동줄바꿈ToolStripMenuItem.Checked = true;
            }
        }

        /// <summary>
        /// 글꼴 버튼 클릭 이벤트 입니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 글꼴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFont.Show();
        }

        /// <summary>
        /// 글꼴 변경 이벤트 입니다.
        /// </summary>
        /// <param name="fontFamily"></param>
        /// <param name="fontStyle"></param>
        /// <param name="fontSize"></param>
        private void FrmFont_eFontChange(FontFamily fontFamily, FontStyle fontStyle, float fontSize)
        {
            using (Font font = new Font(fontFamily, fontSize, fontStyle))
            {
                rtxtMemo.Font = font;
            }
        }



        #endregion

        
    }
}
