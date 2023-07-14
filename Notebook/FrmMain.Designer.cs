namespace Notebook
{
    partial class FrmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNew = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAnotherSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClose = new System.Windows.Forms.ToolStripMenuItem();
            this.편집ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCut = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPaiste = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFind = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTimeDate = new System.Windows.Forms.ToolStripMenuItem();
            this.서식ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.자동줄바꿈ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.글꼴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.상태표시줄ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.stripOS = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripMagnification = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripLocation = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.rtxtMemo = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.편집ToolStripMenuItem,
            this.서식ToolStripMenuItem,
            this.보기ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(814, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnLoad,
            this.btnSave,
            this.btnAnotherSave,
            this.toolStripSeparator2,
            this.btnClose});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(43, 20);
            this.toolStripMenuItem1.Text = "파일";
            // 
            // btnNew
            // 
            this.btnNew.Name = "btnNew";
            this.btnNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.btnNew.Size = new System.Drawing.Size(252, 22);
            this.btnNew.Text = "새로 만들기";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.btnLoad.Size = new System.Drawing.Size(252, 22);
            this.btnLoad.Text = "열기";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Name = "btnSave";
            this.btnSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.btnSave.Size = new System.Drawing.Size(252, 22);
            this.btnSave.Text = "저장";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAnotherSave
            // 
            this.btnAnotherSave.Name = "btnAnotherSave";
            this.btnAnotherSave.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.btnAnotherSave.Size = new System.Drawing.Size(252, 22);
            this.btnAnotherSave.Text = "다른 이름으로 저장";
            this.btnAnotherSave.Click += new System.EventHandler(this.btnAnotherSave_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(249, 6);
            // 
            // btnClose
            // 
            this.btnClose.Name = "btnClose";
            this.btnClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.btnClose.Size = new System.Drawing.Size(252, 22);
            this.btnClose.Text = "종료";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // 편집ToolStripMenuItem
            // 
            this.편집ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUndo,
            this.toolStripSeparator1,
            this.btnCut,
            this.btnCopy,
            this.btnPaiste,
            this.btnRemove,
            this.toolStripSeparator3,
            this.btnSearch,
            this.btnFind,
            this.btnReplace,
            this.toolStripSeparator4,
            this.btnSelectAll,
            this.btnTimeDate});
            this.편집ToolStripMenuItem.Name = "편집ToolStripMenuItem";
            this.편집ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.편집ToolStripMenuItem.Text = "편집";
            // 
            // btnUndo
            // 
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.btnUndo.Size = new System.Drawing.Size(202, 22);
            this.btnUndo.Text = "실행 취소";
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(199, 6);
            // 
            // btnCut
            // 
            this.btnCut.Enabled = false;
            this.btnCut.Name = "btnCut";
            this.btnCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.btnCut.Size = new System.Drawing.Size(202, 22);
            this.btnCut.Text = "잘라내기";
            this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Enabled = false;
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.btnCopy.Size = new System.Drawing.Size(202, 22);
            this.btnCopy.Text = "복사";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnPaiste
            // 
            this.btnPaiste.Name = "btnPaiste";
            this.btnPaiste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.btnPaiste.Size = new System.Drawing.Size(202, 22);
            this.btnPaiste.Text = "붙여넣기";
            this.btnPaiste.Click += new System.EventHandler(this.btnPaiste_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.btnRemove.Size = new System.Drawing.Size(202, 22);
            this.btnRemove.Text = "삭제";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(199, 6);
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.btnSearch.Size = new System.Drawing.Size(202, 22);
            this.btnSearch.Text = "구글로 검색하기";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnFind
            // 
            this.btnFind.Name = "btnFind";
            this.btnFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.btnFind.Size = new System.Drawing.Size(202, 22);
            this.btnFind.Text = "찾기";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.btnReplace.Size = new System.Drawing.Size(202, 22);
            this.btnReplace.Text = "바꾸기";
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(199, 6);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.btnSelectAll.Size = new System.Drawing.Size(202, 22);
            this.btnSelectAll.Text = "모두 선택";
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnTimeDate
            // 
            this.btnTimeDate.Name = "btnTimeDate";
            this.btnTimeDate.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.btnTimeDate.Size = new System.Drawing.Size(202, 22);
            this.btnTimeDate.Text = "시간/날짜";
            this.btnTimeDate.Click += new System.EventHandler(this.btnTimeDate_Click);
            // 
            // 서식ToolStripMenuItem
            // 
            this.서식ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.자동줄바꿈ToolStripMenuItem,
            this.글꼴ToolStripMenuItem});
            this.서식ToolStripMenuItem.Name = "서식ToolStripMenuItem";
            this.서식ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.서식ToolStripMenuItem.Text = "서식";
            this.서식ToolStripMenuItem.DropDownClosed += new System.EventHandler(this.서식ToolStripMenuItem_DropDownClosed);
            this.서식ToolStripMenuItem.DropDownOpened += new System.EventHandler(this.서식ToolStripMenuItem_DropDownOpened);
            // 
            // 자동줄바꿈ToolStripMenuItem
            // 
            this.자동줄바꿈ToolStripMenuItem.Checked = true;
            this.자동줄바꿈ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.자동줄바꿈ToolStripMenuItem.Name = "자동줄바꿈ToolStripMenuItem";
            this.자동줄바꿈ToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.자동줄바꿈ToolStripMenuItem.Text = "자동 줄 바꿈(W)";
            this.자동줄바꿈ToolStripMenuItem.Click += new System.EventHandler(this.자동줄바꿈ToolStripMenuItem_Click);
            // 
            // 글꼴ToolStripMenuItem
            // 
            this.글꼴ToolStripMenuItem.Name = "글꼴ToolStripMenuItem";
            this.글꼴ToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.글꼴ToolStripMenuItem.Text = "글꼴(F)";
            this.글꼴ToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.글꼴ToolStripMenuItem.Click += new System.EventHandler(this.글꼴ToolStripMenuItem_Click);
            // 
            // 보기ToolStripMenuItem
            // 
            this.보기ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.상태표시줄ToolStripMenuItem});
            this.보기ToolStripMenuItem.Name = "보기ToolStripMenuItem";
            this.보기ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.보기ToolStripMenuItem.Text = "보기";
            // 
            // 상태표시줄ToolStripMenuItem
            // 
            this.상태표시줄ToolStripMenuItem.Checked = true;
            this.상태표시줄ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.상태표시줄ToolStripMenuItem.Name = "상태표시줄ToolStripMenuItem";
            this.상태표시줄ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.상태표시줄ToolStripMenuItem.Text = "상태 표시줄(S)";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripOS,
            this.stripMagnification,
            this.stripLocation,
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 552);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip.Size = new System.Drawing.Size(814, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            this.statusStrip.Visible = false;
            // 
            // stripOS
            // 
            this.stripOS.Name = "stripOS";
            this.stripOS.Size = new System.Drawing.Size(0, 0);
            // 
            // stripMagnification
            // 
            this.stripMagnification.Name = "stripMagnification";
            this.stripMagnification.Size = new System.Drawing.Size(0, 0);
            // 
            // stripLocation
            // 
            this.stripLocation.Name = "stripLocation";
            this.stripLocation.Size = new System.Drawing.Size(0, 0);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(121, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // rtxtMemo
            // 
            this.rtxtMemo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtMemo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtMemo.Font = new System.Drawing.Font("굴림", 10F);
            this.rtxtMemo.HideSelection = false;
            this.rtxtMemo.Location = new System.Drawing.Point(0, 24);
            this.rtxtMemo.Margin = new System.Windows.Forms.Padding(0);
            this.rtxtMemo.Name = "rtxtMemo";
            this.rtxtMemo.Size = new System.Drawing.Size(814, 550);
            this.rtxtMemo.TabIndex = 2;
            this.rtxtMemo.Text = "";
            this.rtxtMemo.SelectionChanged += new System.EventHandler(this.rtxtMemo_SelectionChanged);
            this.rtxtMemo.TextChanged += new System.EventHandler(this.MemoChanged);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 574);
            this.Controls.Add(this.rtxtMemo);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmMain";
            this.Text = "RTFViewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.RichTextBox rtxtMemo;
        private System.Windows.Forms.ToolStripMenuItem btnNew;
        private System.Windows.Forms.ToolStripMenuItem btnSave;
        private System.Windows.Forms.ToolStripMenuItem btnLoad;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem btnClose;
        private System.Windows.Forms.ToolStripMenuItem btnAnotherSave;
        private System.Windows.Forms.ToolStripMenuItem 편집ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnUndo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btnCut;
        private System.Windows.Forms.ToolStripMenuItem btnCopy;
        private System.Windows.Forms.ToolStripMenuItem btnPaiste;
        private System.Windows.Forms.ToolStripMenuItem btnRemove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem btnSearch;
        private System.Windows.Forms.ToolStripMenuItem btnFind;
        private System.Windows.Forms.ToolStripMenuItem btnReplace;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem btnSelectAll;
        private System.Windows.Forms.ToolStripMenuItem btnTimeDate;
        private System.Windows.Forms.ToolStripMenuItem 서식ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 글꼴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 보기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 자동줄바꿈ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 상태표시줄ToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel stripOS;
        private System.Windows.Forms.ToolStripStatusLabel stripMagnification;
        private System.Windows.Forms.ToolStripStatusLabel stripLocation;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
    }
}

