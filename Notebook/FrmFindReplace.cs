using Notebook.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notebook
{
    public partial class FrmFindReplace : Form
    {
        /// <summary>
        /// 키보드 후킹
        /// </summary>
        KeyboardHooking _kbd = new KeyboardHooking();

        /// <summary>
        /// 찾기 delegate 및 이벤트
        /// </summary>
        /// <param name="find"></param>
        public delegate void delBtnFind(cFindReplace find);
        public event delBtnFind eBtnFind;

        /// <summary>
        /// 바꾸기 delegate 및 이벤트
        /// </summary>
        /// <param name="replaceText"></param>
        /// <param name="isAll"></param>
        public delegate void delBtnReplace(string findText, string replaceText, bool isAll, bool isDevide);
        public event delBtnReplace eBtnReplace;

        public FrmFindReplace()
        {
            InitializeComponent();
        }

        private void FrmFindReplace_Load(object sender, EventArgs e)
        {
            _kbd.KeyDown += _kbd_KeyDown;
            _kbd.hook();
        }

        #region common

        /// <summary>
        /// 키보드 다운 이벤트 입니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _kbd_KeyDown(object sender, KeyEventArgs e)
        {
            //찾기 탭일 경우 Keyboard hook
            if (tabControl.SelectedTab == tabFind)
            {
                if (e.Alt)
                {
                    Keys press = e.KeyCode;
                    if (press == Keys.N)
                    {
                        txtFindStr.Focus();
                    }
                    else if (press == Keys.C)
                    {
                        cboxDivde.Checked = !cboxDivde.Checked;
                    }
                    else if (press == Keys.U)
                    {
                        rbtnUp.Checked = true;
                    }
                    else if (press == Keys.D)
                    {
                        rbtnDown.Checked = true;
                    }
                    else if (press == Keys.F)
                    {
                        btnFind_Click(sender, e);
                    }
                }
                else if (e.KeyCode == Keys.Enter && _kbd != null)
                {
                    btnFind_Click(null, null);
                }
            }
            else if (tabControl.SelectedTab == tabReplace)  //바꾸기 탭일 경우 Keyboard hook
            {

            }
        }

        /// <summary>
        /// 찾기/바꾸기 폼을 닫을 경우 이벤트 입니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmFindReplace_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
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

        /// <summary>
        /// 활성화 시 이벤트 입니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmFindReplace_Activated(object sender, EventArgs e)
        {
            _kbd = new KeyboardHooking();
            _kbd.hook();
        }

        /// <summary>
        /// 비활성화 시 이벤트 입니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmFindReplace_Deactivate(object sender, EventArgs e)
        {
            if (_kbd != null)
            {
                _kbd.unhook();
                _kbd = null;
            }
        }

        /// <summary>
        /// 탭 변경 시 이벤트 입니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabPage tab = tabControl.SelectedTab;
            if (tab == tabFind && !string.IsNullOrWhiteSpace(txtFindToReplace.Text))
            {
                txtFindStr.Text = txtFindToReplace.Text;
            }
            else if (tab == tabReplace && !string.IsNullOrWhiteSpace(txtFindStr.Text))
            {
                txtFindToReplace.Text = txtFindStr.Text;
            }
        }

        /// <summary>
        /// 다음 찾기 메서드
        /// </summary>
        /// <param name="searchText"></param>
        /// <param name="isDevide"></param>
        /// <param name="isDown"></param>
        private void FindText(string searchText, bool isDevide, bool isDown)
        {
            cFindReplace find = new cFindReplace();

            find.str = searchText;
            find.isDevied = isDevide;
            find.isDown = isDown;

            eBtnFind(find);
        }

        /// <summary>
        /// 찾기/바꾸기 검색어 검증
        /// </summary>
        /// <param name="txt"></param>
        /// <returns></returns>
        private bool isStrNull(TextBox txt)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                MessageBox.Show("찾을 문자열을 입력해주세요.", "Info", MessageBoxButtons.OK);
                txt.Focus();
                return true;
            }

            return false;
        }

        #endregion

        /// <summary>
        /// [찾기] - [다음 찾기] 클릭 이벤트 입니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFind_Click(object sender, EventArgs e)
        {
            if(isStrNull(txtFindStr)) return;

            FindText(txtFindStr.Text, cboxDivde.Checked, rbtnDown.Checked);
        }                

        /// <summary>
        /// [바꾸기] - [다음 찾기] 클릭 이벤트 입니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFindToReplace_Click(object sender, EventArgs e)
        {
            if (isStrNull(txtFindToReplace)) return;

            FindText(txtFindToReplace.Text, cboxReplaceDevide.Checked, true);
        }

        /// <summary>
        /// 바꾸기 & 모두 바꾸기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fReplace(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            string btnName = btn.Name;
            bool isAll = true;

            if (btnName == "btnReplace")
            {
                isAll = false;
            }

            eBtnReplace(txtFindToReplace.Text, txtReplace.Text, isAll, cboxReplaceDevide.Checked);
        }
    }
}
