namespace Notebook
{
    partial class FrmFindReplace
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFindReplace));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabFind = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnDown = new System.Windows.Forms.RadioButton();
            this.rbtnUp = new System.Windows.Forms.RadioButton();
            this.cboxDivde = new System.Windows.Forms.CheckBox();
            this.txtFindStr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabReplace = new System.Windows.Forms.TabPage();
            this.cboxReplaceDevide = new System.Windows.Forms.CheckBox();
            this.btnReplaceAll = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReplaceCancel = new System.Windows.Forms.Button();
            this.btnFindToReplace = new System.Windows.Forms.Button();
            this.txtFindToReplace = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabFind.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabReplace.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabFind);
            this.tabControl.Controls.Add(this.tabReplace);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(472, 200);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabFind
            // 
            this.tabFind.Controls.Add(this.btnCancel);
            this.tabFind.Controls.Add(this.btnFind);
            this.tabFind.Controls.Add(this.groupBox1);
            this.tabFind.Controls.Add(this.cboxDivde);
            this.tabFind.Controls.Add(this.txtFindStr);
            this.tabFind.Controls.Add(this.label1);
            this.tabFind.Location = new System.Drawing.Point(4, 22);
            this.tabFind.Name = "tabFind";
            this.tabFind.Padding = new System.Windows.Forms.Padding(3);
            this.tabFind.Size = new System.Drawing.Size(464, 174);
            this.tabFind.TabIndex = 0;
            this.tabFind.Text = "찾기";
            this.tabFind.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(360, 40);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 27);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(360, 7);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(96, 27);
            this.btnFind.TabIndex = 5;
            this.btnFind.Text = "다음 찾기(F)";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnDown);
            this.groupBox1.Controls.Add(this.rbtnUp);
            this.groupBox1.Location = new System.Drawing.Point(141, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 46);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "방향";
            // 
            // rbtnDown
            // 
            this.rbtnDown.AutoSize = true;
            this.rbtnDown.Checked = true;
            this.rbtnDown.Location = new System.Drawing.Point(104, 20);
            this.rbtnDown.Name = "rbtnDown";
            this.rbtnDown.Size = new System.Drawing.Size(77, 16);
            this.rbtnDown.TabIndex = 1;
            this.rbtnDown.TabStop = true;
            this.rbtnDown.Text = "아래로(D)";
            this.rbtnDown.UseVisualStyleBackColor = true;
            // 
            // rbtnUp
            // 
            this.rbtnUp.AutoSize = true;
            this.rbtnUp.Location = new System.Drawing.Point(17, 20);
            this.rbtnUp.Name = "rbtnUp";
            this.rbtnUp.Size = new System.Drawing.Size(65, 16);
            this.rbtnUp.TabIndex = 0;
            this.rbtnUp.Text = "위로(U)";
            this.rbtnUp.UseVisualStyleBackColor = true;
            // 
            // cboxDivde
            // 
            this.cboxDivde.AutoSize = true;
            this.cboxDivde.Location = new System.Drawing.Point(10, 56);
            this.cboxDivde.Name = "cboxDivde";
            this.cboxDivde.Size = new System.Drawing.Size(125, 16);
            this.cboxDivde.TabIndex = 2;
            this.cboxDivde.Text = "대/소문자 구분(C)";
            this.cboxDivde.UseVisualStyleBackColor = true;
            // 
            // txtFindStr
            // 
            this.txtFindStr.Location = new System.Drawing.Point(95, 9);
            this.txtFindStr.Name = "txtFindStr";
            this.txtFindStr.Size = new System.Drawing.Size(259, 21);
            this.txtFindStr.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "찾을 내용(N):";
            // 
            // tabReplace
            // 
            this.tabReplace.Controls.Add(this.cboxReplaceDevide);
            this.tabReplace.Controls.Add(this.btnReplaceAll);
            this.tabReplace.Controls.Add(this.btnReplace);
            this.tabReplace.Controls.Add(this.txtReplace);
            this.tabReplace.Controls.Add(this.label4);
            this.tabReplace.Controls.Add(this.btnReplaceCancel);
            this.tabReplace.Controls.Add(this.btnFindToReplace);
            this.tabReplace.Controls.Add(this.txtFindToReplace);
            this.tabReplace.Controls.Add(this.label3);
            this.tabReplace.Location = new System.Drawing.Point(4, 22);
            this.tabReplace.Name = "tabReplace";
            this.tabReplace.Padding = new System.Windows.Forms.Padding(3);
            this.tabReplace.Size = new System.Drawing.Size(464, 174);
            this.tabReplace.TabIndex = 1;
            this.tabReplace.Text = "바꾸기";
            this.tabReplace.UseVisualStyleBackColor = true;
            // 
            // cboxReplaceDevide
            // 
            this.cboxReplaceDevide.AutoSize = true;
            this.cboxReplaceDevide.Location = new System.Drawing.Point(12, 83);
            this.cboxReplaceDevide.Name = "cboxReplaceDevide";
            this.cboxReplaceDevide.Size = new System.Drawing.Size(125, 16);
            this.cboxReplaceDevide.TabIndex = 15;
            this.cboxReplaceDevide.Text = "대/소문자 구분(C)";
            this.cboxReplaceDevide.UseVisualStyleBackColor = true;
            // 
            // btnReplaceAll
            // 
            this.btnReplaceAll.Location = new System.Drawing.Point(362, 72);
            this.btnReplaceAll.Name = "btnReplaceAll";
            this.btnReplaceAll.Size = new System.Drawing.Size(96, 27);
            this.btnReplaceAll.TabIndex = 14;
            this.btnReplaceAll.Text = "모두 바꾸기(A)";
            this.btnReplaceAll.UseVisualStyleBackColor = true;
            this.btnReplaceAll.Click += new System.EventHandler(this.fReplace);
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(362, 39);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(96, 27);
            this.btnReplace.TabIndex = 13;
            this.btnReplace.Text = "바꾸기(R)";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.fReplace);
            // 
            // txtReplace
            // 
            this.txtReplace.Location = new System.Drawing.Point(96, 35);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(259, 21);
            this.txtReplace.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "바꿀 내용(P):";
            // 
            // btnReplaceCancel
            // 
            this.btnReplaceCancel.Location = new System.Drawing.Point(362, 105);
            this.btnReplaceCancel.Name = "btnReplaceCancel";
            this.btnReplaceCancel.Size = new System.Drawing.Size(96, 27);
            this.btnReplaceCancel.TabIndex = 10;
            this.btnReplaceCancel.Text = "취소";
            this.btnReplaceCancel.UseVisualStyleBackColor = true;
            this.btnReplaceCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnFindToReplace
            // 
            this.btnFindToReplace.Location = new System.Drawing.Point(362, 6);
            this.btnFindToReplace.Name = "btnFindToReplace";
            this.btnFindToReplace.Size = new System.Drawing.Size(96, 27);
            this.btnFindToReplace.TabIndex = 9;
            this.btnFindToReplace.Text = "다음 찾기(F)";
            this.btnFindToReplace.UseVisualStyleBackColor = true;
            this.btnFindToReplace.Click += new System.EventHandler(this.btnFindToReplace_Click);
            // 
            // txtFindToReplace
            // 
            this.txtFindToReplace.Location = new System.Drawing.Point(96, 8);
            this.txtFindToReplace.Name = "txtFindToReplace";
            this.txtFindToReplace.Size = new System.Drawing.Size(259, 21);
            this.txtFindToReplace.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "찾을 내용(N):";
            // 
            // FrmFindReplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 200);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFindReplace";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "찾기";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.FrmFindReplace_Activated);
            this.Deactivate += new System.EventHandler(this.FrmFindReplace_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmFindReplace_FormClosing);
            this.Load += new System.EventHandler(this.FrmFindReplace_Load);
            this.tabControl.ResumeLayout(false);
            this.tabFind.ResumeLayout(false);
            this.tabFind.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabReplace.ResumeLayout(false);
            this.tabReplace.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cboxDivde;
        private System.Windows.Forms.TextBox txtFindStr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnUp;
        private System.Windows.Forms.RadioButton rbtnDown;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabPage tabFind;
        private System.Windows.Forms.TabPage tabReplace;
        private System.Windows.Forms.Button btnReplaceCancel;
        private System.Windows.Forms.Button btnFindToReplace;
        private System.Windows.Forms.TextBox txtFindToReplace;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtReplace;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReplaceAll;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.CheckBox cboxReplaceDevide;
    }
}