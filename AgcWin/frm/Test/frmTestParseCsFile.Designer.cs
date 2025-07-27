namespace Agc_CsWin.frm.Test
{
    partial class frmTestParseCsFile
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
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnParseFile = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtResult2 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtResult3 = new System.Windows.Forms.TextBox();
            this.btnCodeFileMan = new System.Windows.Forms.Button();
            this.btnTestRegex = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProjectPath = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(50, 3);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(829, 21);
            this.txtFileName.TabIndex = 0;
            this.txtFileName.Text = "E:\\ASPNETJX\\SamplePrj2017\\SamplePrj_BLL\\ClassEx\\BaseInfo\\clsCollegeExWApi.cs";
            // 
            // btnParseFile
            // 
            this.btnParseFile.Location = new System.Drawing.Point(885, 3);
            this.btnParseFile.Name = "btnParseFile";
            this.btnParseFile.Size = new System.Drawing.Size(75, 23);
            this.btnParseFile.TabIndex = 1;
            this.btnParseFile.Text = "分析文件";
            this.btnParseFile.UseVisualStyleBackColor = true;
            this.btnParseFile.Click += new System.EventHandler(this.btnParseFile_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(6, 0);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(1162, 501);
            this.txtResult.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 105);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1182, 533);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtResult);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1174, 507);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Token";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtResult2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1174, 507);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "函数分析";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtResult2
            // 
            this.txtResult2.Location = new System.Drawing.Point(3, 3);
            this.txtResult2.Multiline = true;
            this.txtResult2.Name = "txtResult2";
            this.txtResult2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult2.Size = new System.Drawing.Size(1168, 501);
            this.txtResult2.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtResult3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1174, 507);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "生成的类文件";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtResult3
            // 
            this.txtResult3.Location = new System.Drawing.Point(3, 3);
            this.txtResult3.Multiline = true;
            this.txtResult3.Name = "txtResult3";
            this.txtResult3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult3.Size = new System.Drawing.Size(1168, 501);
            this.txtResult3.TabIndex = 5;
            // 
            // btnCodeFileMan
            // 
            this.btnCodeFileMan.Location = new System.Drawing.Point(966, 3);
            this.btnCodeFileMan.Name = "btnCodeFileMan";
            this.btnCodeFileMan.Size = new System.Drawing.Size(102, 23);
            this.btnCodeFileMan.TabIndex = 4;
            this.btnCodeFileMan.Text = "代码文件管理";
            this.btnCodeFileMan.UseVisualStyleBackColor = true;
            this.btnCodeFileMan.Click += new System.EventHandler(this.btnCodeFileMan_Click);
            // 
            // btnTestRegex
            // 
            this.btnTestRegex.Location = new System.Drawing.Point(1074, 3);
            this.btnTestRegex.Name = "btnTestRegex";
            this.btnTestRegex.Size = new System.Drawing.Size(102, 23);
            this.btnTestRegex.TabIndex = 5;
            this.btnTestRegex.Text = "测试正则表达式";
            this.btnTestRegex.UseVisualStyleBackColor = true;
            this.btnTestRegex.Click += new System.EventHandler(this.btnTestRegex_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.txtFileName);
            this.flowLayoutPanel1.Controls.Add(this.btnParseFile);
            this.flowLayoutPanel1.Controls.Add(this.btnCodeFileMan);
            this.flowLayoutPanel1.Controls.Add(this.btnTestRegex);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.txtProjectPath);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1192, 87);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "文件名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "工程路径";
            // 
            // txtProjectPath
            // 
            this.txtProjectPath.Location = new System.Drawing.Point(62, 32);
            this.txtProjectPath.Name = "txtProjectPath";
            this.txtProjectPath.Size = new System.Drawing.Size(817, 21);
            this.txtProjectPath.TabIndex = 6;
            this.txtProjectPath.Text = "E:\\ASPNETJX\\SamplePrj2017\\SamplePrj_BLL\\";
            // 
            // frmTestParseCsFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 643);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmTestParseCsFile";
            this.Text = "frmTestParseCsFile";
            this.Load += new System.EventHandler(this.frmTestParseCsFile_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnParseFile;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtResult2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtResult3;
        private System.Windows.Forms.Button btnCodeFileMan;
        private System.Windows.Forms.Button btnTestRegex;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProjectPath;
    }
}