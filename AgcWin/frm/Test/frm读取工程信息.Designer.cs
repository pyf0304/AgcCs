
namespace AGC_CSWin
{
    partial class frm读取工程信息
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
            this.btnReadPrjInfo = new System.Windows.Forms.Button();
            this.tn = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddCompileFile = new System.Windows.Forms.Button();
            this.btnRemoveCompileFile = new System.Windows.Forms.Button();
            this.btnGetCompileTabLst = new System.Windows.Forms.Button();
            this.btnReadPrjFileInfo = new System.Windows.Forms.Button();
            this.cboCmPrjId = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnReadPrjInfo
            // 
            this.btnReadPrjInfo.Location = new System.Drawing.Point(273, 131);
            this.btnReadPrjInfo.Name = "btnReadPrjInfo";
            this.btnReadPrjInfo.Size = new System.Drawing.Size(212, 23);
            this.btnReadPrjInfo.TabIndex = 0;
            this.btnReadPrjInfo.Text = "读取工程信息";
            this.btnReadPrjInfo.UseVisualStyleBackColor = true;
            this.btnReadPrjInfo.Click += new System.EventHandler(this.btnReadPrjInfo_Click);
            // 
            // tn
            // 
            this.tn.Location = new System.Drawing.Point(91, 132);
            this.tn.Name = "tn";
            this.tn.Size = new System.Drawing.Size(100, 21);
            this.tn.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddCompileFile
            // 
            this.btnAddCompileFile.Location = new System.Drawing.Point(363, 214);
            this.btnAddCompileFile.Name = "btnAddCompileFile";
            this.btnAddCompileFile.Size = new System.Drawing.Size(75, 23);
            this.btnAddCompileFile.TabIndex = 3;
            this.btnAddCompileFile.Text = "添加项";
            this.btnAddCompileFile.UseVisualStyleBackColor = true;
            this.btnAddCompileFile.Click += new System.EventHandler(this.btnAddCompileFile_Click);
            // 
            // btnRemoveCompileFile
            // 
            this.btnRemoveCompileFile.Location = new System.Drawing.Point(363, 266);
            this.btnRemoveCompileFile.Name = "btnRemoveCompileFile";
            this.btnRemoveCompileFile.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveCompileFile.TabIndex = 4;
            this.btnRemoveCompileFile.Text = "移除项";
            this.btnRemoveCompileFile.UseVisualStyleBackColor = true;
            this.btnRemoveCompileFile.Click += new System.EventHandler(this.btnRemoveCompileFile_Click);
            // 
            // btnGetCompileTabLst
            // 
            this.btnGetCompileTabLst.Location = new System.Drawing.Point(363, 316);
            this.btnGetCompileTabLst.Name = "btnGetCompileTabLst";
            this.btnGetCompileTabLst.Size = new System.Drawing.Size(107, 23);
            this.btnGetCompileTabLst.TabIndex = 5;
            this.btnGetCompileTabLst.Text = "获取编译表项";
            this.btnGetCompileTabLst.UseVisualStyleBackColor = true;
            this.btnGetCompileTabLst.Click += new System.EventHandler(this.btnGetCompileTabLst_Click);
            // 
            // btnReadPrjFileInfo
            // 
            this.btnReadPrjFileInfo.Location = new System.Drawing.Point(491, 132);
            this.btnReadPrjFileInfo.Name = "btnReadPrjFileInfo";
            this.btnReadPrjFileInfo.Size = new System.Drawing.Size(212, 23);
            this.btnReadPrjFileInfo.TabIndex = 6;
            this.btnReadPrjFileInfo.Text = "读取工程文件信息";
            this.btnReadPrjFileInfo.UseVisualStyleBackColor = true;
            this.btnReadPrjFileInfo.Click += new System.EventHandler(this.btnReadPrjFileInfo_Click);
            // 
            // cboCmPrjId
            // 
            this.cboCmPrjId.FormattingEnabled = true;
            this.cboCmPrjId.Location = new System.Drawing.Point(553, 58);
            this.cboCmPrjId.Name = "cboCmPrjId";
            this.cboCmPrjId.Size = new System.Drawing.Size(121, 20);
            this.cboCmPrjId.TabIndex = 7;
            // 
            // frm读取工程信息
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboCmPrjId);
            this.Controls.Add(this.btnReadPrjFileInfo);
            this.Controls.Add(this.btnGetCompileTabLst);
            this.Controls.Add(this.btnRemoveCompileFile);
            this.Controls.Add(this.btnAddCompileFile);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tn);
            this.Controls.Add(this.btnReadPrjInfo);
            this.Name = "frm读取工程信息";
            this.Text = "frm读取工程信息";
            this.Load += new System.EventHandler(this.frm读取工程信息_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadPrjInfo;
        private System.Windows.Forms.TextBox tn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddCompileFile;
        private System.Windows.Forms.Button btnRemoveCompileFile;
        private System.Windows.Forms.Button btnGetCompileTabLst;
        private System.Windows.Forms.Button btnReadPrjFileInfo;
        private System.Windows.Forms.ComboBox cboCmPrjId;
    }
}