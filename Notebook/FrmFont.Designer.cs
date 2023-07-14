namespace Notebook
{
    partial class FrmFont
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTest = new System.Windows.Forms.Label();
            this.cboxFont = new System.Windows.Forms.ComboBox();
            this.cboxStyle = new System.Windows.Forms.ComboBox();
            this.cboxSize = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "글꼴(F):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "글꼴 스타일(Y):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "크기(S):";
            // 
            // lblTest
            // 
            this.lblTest.Location = new System.Drawing.Point(6, 17);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(210, 56);
            this.lblTest.TabIndex = 3;
            this.lblTest.Text = "AaBbCcDdFf";
            this.lblTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboxFont
            // 
            this.cboxFont.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboxFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboxFont.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboxFont.FormattingEnabled = true;
            this.cboxFont.IntegralHeight = false;
            this.cboxFont.ItemHeight = 20;
            this.cboxFont.Location = new System.Drawing.Point(12, 26);
            this.cboxFont.MaxDropDownItems = 4;
            this.cboxFont.Name = "cboxFont";
            this.cboxFont.Size = new System.Drawing.Size(178, 142);
            this.cboxFont.TabIndex = 6;
            this.cboxFont.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cboxFont_DrawItem);
            this.cboxFont.SelectedIndexChanged += new System.EventHandler(this.cboxFont_SelectedIndexChanged);
            // 
            // cboxStyle
            // 
            this.cboxStyle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboxStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboxStyle.Font = new System.Drawing.Font("바탕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboxStyle.ForeColor = System.Drawing.Color.Black;
            this.cboxStyle.FormattingEnabled = true;
            this.cboxStyle.IntegralHeight = false;
            this.cboxStyle.Location = new System.Drawing.Point(210, 26);
            this.cboxStyle.MaxDropDownItems = 6;
            this.cboxStyle.Name = "cboxStyle";
            this.cboxStyle.Size = new System.Drawing.Size(133, 142);
            this.cboxStyle.TabIndex = 7;
            this.cboxStyle.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cboxStyle_DrawItem);
            this.cboxStyle.SelectedIndexChanged += new System.EventHandler(this.cboxStyle_SelectedIndexChanged);
            // 
            // cboxSize
            // 
            this.cboxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboxSize.Font = new System.Drawing.Font("바탕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboxSize.FormattingEnabled = true;
            this.cboxSize.IntegralHeight = false;
            this.cboxSize.Location = new System.Drawing.Point(361, 26);
            this.cboxSize.MaxDropDownItems = 6;
            this.cboxSize.Name = "cboxSize";
            this.cboxSize.Size = new System.Drawing.Size(71, 142);
            this.cboxSize.TabIndex = 8;
            this.cboxSize.SelectedIndexChanged += new System.EventHandler(this.cboxSize_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTest);
            this.groupBox1.Location = new System.Drawing.Point(210, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 76);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "보기";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(276, 268);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "확인";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(357, 268);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmFont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 303);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboxSize);
            this.Controls.Add(this.cboxStyle);
            this.Controls.Add(this.cboxFont);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmFont";
            this.Text = "글꼴";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmFont_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.ComboBox cboxFont;
        private System.Windows.Forms.ComboBox cboxStyle;
        private System.Windows.Forms.ComboBox cboxSize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}