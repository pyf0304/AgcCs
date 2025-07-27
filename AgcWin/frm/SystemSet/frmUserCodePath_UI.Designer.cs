
///----------------------
///生成代码版本：2012.01.02.1
///生成日期：2012/10/13
///生成者：潘以锋
///工程名称：AGC
///工程ID：0005
///模块中文名：系统设置
///模块英文名：SystemSet
///注意：1、需要数据底层（PubDataBase.dll）的版本：2011.05.08.1
///       2、需要公共函数层（TzPubFunction.dll）的版本：2011.05.08.1
///========================
namespace AGC
{
    /// <summary>
    ///		frmUserCodePath_UI 的摘要说明。
    /// </summary>
    partial class frmUserCodePath_UI
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.Container components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        #region 组件设计器生成的代码
        /// <summary> 
        /// 设计器支持所需的方法 - 不要使用代码编辑器 
        /// 修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPrjId = new System.Windows.Forms.Label();
            this.cboPrjId = new System.Windows.Forms.ComboBox();
            this.lblCodeTypeId = new System.Windows.Forms.Label();
            this.cboCodeTypeId = new System.Windows.Forms.ComboBox();
            this.lblCodePath = new System.Windows.Forms.Label();
            this.txtCodePath = new System.Windows.Forms.TextBox();
            this.lblMemo = new System.Windows.Forms.Label();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnOKUpd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBrowser4Path = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProjectPath = new System.Windows.Forms.TextBox();
            this.chkIsGeneCode = new System.Windows.Forms.CheckBox();
            this.btnBrowserbackup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.txtCodePathBackup = new System.Windows.Forms.TextBox();
            this.btnCopyCodePath = new System.Windows.Forms.Button();
            this.btnCopyCodePathBackup = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSuffixPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProjectFileName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboTabMainTypeId = new System.Windows.Forms.ComboBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnBrowser4Path.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPrjId
            // 
            this.lblPrjId.Location = new System.Drawing.Point(3, 0);
            this.lblPrjId.Name = "lblPrjId";
            this.lblPrjId.Size = new System.Drawing.Size(82, 21);
            this.lblPrjId.TabIndex = 3;
            this.lblPrjId.Text = "工程";
            // 
            // cboPrjId
            // 
            this.cboPrjId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPrjId.Location = new System.Drawing.Point(101, 3);
            this.cboPrjId.Name = "cboPrjId";
            this.cboPrjId.Size = new System.Drawing.Size(185, 22);
            this.cboPrjId.TabIndex = 4;
            // 
            // lblCodeTypeId
            // 
            this.lblCodeTypeId.Location = new System.Drawing.Point(3, 40);
            this.lblCodeTypeId.Name = "lblCodeTypeId";
            this.lblCodeTypeId.Size = new System.Drawing.Size(81, 20);
            this.lblCodeTypeId.TabIndex = 5;
            this.lblCodeTypeId.Text = "代码类型";
            // 
            // cboCodeTypeId
            // 
            this.btnBrowser4Path.SetColumnSpan(this.cboCodeTypeId, 3);
            this.cboCodeTypeId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodeTypeId.Location = new System.Drawing.Point(101, 43);
            this.cboCodeTypeId.Name = "cboCodeTypeId";
            this.cboCodeTypeId.Size = new System.Drawing.Size(527, 22);
            this.cboCodeTypeId.TabIndex = 6;
            // 
            // lblCodePath
            // 
            this.lblCodePath.Location = new System.Drawing.Point(3, 200);
            this.lblCodePath.Name = "lblCodePath";
            this.lblCodePath.Size = new System.Drawing.Size(82, 20);
            this.lblCodePath.TabIndex = 7;
            this.lblCodePath.Text = "代码路径";
            // 
            // txtCodePath
            // 
            this.btnBrowser4Path.SetColumnSpan(this.txtCodePath, 3);
            this.txtCodePath.Location = new System.Drawing.Point(101, 203);
            this.txtCodePath.Multiline = true;
            this.txtCodePath.Name = "txtCodePath";
            this.txtCodePath.Size = new System.Drawing.Size(527, 52);
            this.txtCodePath.TabIndex = 8;
            // 
            // lblMemo
            // 
            this.lblMemo.Location = new System.Drawing.Point(3, 263);
            this.lblMemo.Name = "lblMemo";
            this.lblMemo.Size = new System.Drawing.Size(81, 21);
            this.lblMemo.TabIndex = 13;
            this.lblMemo.Text = "备份路径";
            // 
            // txtMemo
            // 
            this.btnBrowser4Path.SetColumnSpan(this.txtMemo, 3);
            this.txtMemo.Location = new System.Drawing.Point(101, 363);
            this.txtMemo.Multiline = true;
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(527, 52);
            this.txtMemo.TabIndex = 14;
            // 
            // lblMsg
            // 
            this.lblMsg.Location = new System.Drawing.Point(146, 475);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(424, 41);
            this.lblMsg.TabIndex = 17;
            // 
            // btnOKUpd
            // 
            this.btnOKUpd.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOKUpd.Location = new System.Drawing.Point(146, 440);
            this.btnOKUpd.Name = "btnOKUpd";
            this.btnOKUpd.Size = new System.Drawing.Size(93, 35);
            this.btnOKUpd.TabIndex = 15;
            this.btnOKUpd.Text = "添加";
            this.btnOKUpd.Click += new System.EventHandler(this.btnOKUpd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.Location = new System.Drawing.Point(286, 440);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(93, 35);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnBrowser4Path
            // 
            this.btnBrowser4Path.ColumnCount = 7;
            this.btnBrowser4Path.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.94834F));
            this.btnBrowser4Path.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.05166F));
            this.btnBrowser4Path.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.btnBrowser4Path.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 238F));
            this.btnBrowser4Path.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.btnBrowser4Path.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.btnBrowser4Path.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.btnBrowser4Path.Controls.Add(this.label5, 0, 3);
            this.btnBrowser4Path.Controls.Add(this.txtProjectPath, 1, 4);
            this.btnBrowser4Path.Controls.Add(this.chkIsGeneCode, 0, 2);
            this.btnBrowser4Path.Controls.Add(this.btnBrowserbackup, 4, 6);
            this.btnBrowser4Path.Controls.Add(this.label1, 0, 8);
            this.btnBrowser4Path.Controls.Add(this.lblMemo, 0, 6);
            this.btnBrowser4Path.Controls.Add(this.txtCodePath, 1, 5);
            this.btnBrowser4Path.Controls.Add(this.lblCodePath, 0, 5);
            this.btnBrowser4Path.Controls.Add(this.lblCodeTypeId, 0, 1);
            this.btnBrowser4Path.Controls.Add(this.cboCodeTypeId, 1, 1);
            this.btnBrowser4Path.Controls.Add(this.btnBrowser, 4, 5);
            this.btnBrowser4Path.Controls.Add(this.txtMemo, 1, 8);
            this.btnBrowser4Path.Controls.Add(this.txtCodePathBackup, 1, 6);
            this.btnBrowser4Path.Controls.Add(this.btnCopyCodePath, 5, 5);
            this.btnBrowser4Path.Controls.Add(this.btnCopyCodePathBackup, 5, 6);
            this.btnBrowser4Path.Controls.Add(this.label3, 0, 7);
            this.btnBrowser4Path.Controls.Add(this.txtSuffixPath, 1, 7);
            this.btnBrowser4Path.Controls.Add(this.label4, 0, 4);
            this.btnBrowser4Path.Controls.Add(this.txtProjectFileName, 1, 3);
            this.btnBrowser4Path.Controls.Add(this.lblPrjId, 0, 0);
            this.btnBrowser4Path.Controls.Add(this.cboPrjId, 1, 0);
            this.btnBrowser4Path.Controls.Add(this.label6, 2, 0);
            this.btnBrowser4Path.Controls.Add(this.cboTabMainTypeId, 3, 0);
            this.btnBrowser4Path.Location = new System.Drawing.Point(12, 12);
            this.btnBrowser4Path.Name = "btnBrowser4Path";
            this.btnBrowser4Path.RowCount = 9;
            this.btnBrowser4Path.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28566F));
            this.btnBrowser4Path.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28566F));
            this.btnBrowser4Path.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28424F));
            this.btnBrowser4Path.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.btnBrowser4Path.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28816F));
            this.btnBrowser4Path.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.btnBrowser4Path.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.btnBrowser4Path.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.btnBrowser4Path.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.btnBrowser4Path.Size = new System.Drawing.Size(895, 422);
            this.btnBrowser4Path.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "工程文件名";
            // 
            // txtProjectPath
            // 
            this.btnBrowser4Path.SetColumnSpan(this.txtProjectPath, 3);
            this.txtProjectPath.Location = new System.Drawing.Point(101, 163);
            this.txtProjectPath.Multiline = true;
            this.txtProjectPath.Name = "txtProjectPath";
            this.txtProjectPath.Size = new System.Drawing.Size(527, 26);
            this.txtProjectPath.TabIndex = 25;
            // 
            // chkIsGeneCode
            // 
            this.chkIsGeneCode.AutoSize = true;
            this.btnBrowser4Path.SetColumnSpan(this.chkIsGeneCode, 2);
            this.chkIsGeneCode.Location = new System.Drawing.Point(3, 83);
            this.chkIsGeneCode.Name = "chkIsGeneCode";
            this.chkIsGeneCode.Size = new System.Drawing.Size(110, 18);
            this.chkIsGeneCode.TabIndex = 19;
            this.chkIsGeneCode.Text = "是否生成代码";
            this.chkIsGeneCode.UseVisualStyleBackColor = true;
            this.chkIsGeneCode.CheckedChanged += new System.EventHandler(this.chkIsUsePrjMainPath_CheckedChanged);
            // 
            // btnBrowserbackup
            // 
            this.btnBrowserbackup.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBrowserbackup.Location = new System.Drawing.Point(636, 266);
            this.btnBrowserbackup.Name = "btnBrowserbackup";
            this.btnBrowserbackup.Size = new System.Drawing.Size(77, 35);
            this.btnBrowserbackup.TabIndex = 19;
            this.btnBrowserbackup.Text = "浏览...";
            this.btnBrowserbackup.Click += new System.EventHandler(this.btnBrowserbackup_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "说明";
            // 
            // btnBrowser
            // 
            this.btnBrowser.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBrowser.Location = new System.Drawing.Point(636, 203);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(77, 35);
            this.btnBrowser.TabIndex = 17;
            this.btnBrowser.Text = "浏览...";
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // txtCodePathBackup
            // 
            this.btnBrowser4Path.SetColumnSpan(this.txtCodePathBackup, 3);
            this.txtCodePathBackup.Location = new System.Drawing.Point(101, 266);
            this.txtCodePathBackup.Multiline = true;
            this.txtCodePathBackup.Name = "txtCodePathBackup";
            this.txtCodePathBackup.Size = new System.Drawing.Size(527, 51);
            this.txtCodePathBackup.TabIndex = 19;
            // 
            // btnCopyCodePath
            // 
            this.btnCopyCodePath.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCopyCodePath.Location = new System.Drawing.Point(725, 203);
            this.btnCopyCodePath.Name = "btnCopyCodePath";
            this.btnCopyCodePath.Size = new System.Drawing.Size(74, 35);
            this.btnCopyCodePath.TabIndex = 21;
            this.btnCopyCodePath.Text = "复制...";
            this.btnCopyCodePath.Click += new System.EventHandler(this.btnCopyCodePath_Click);
            // 
            // btnCopyCodePathBackup
            // 
            this.btnCopyCodePathBackup.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCopyCodePathBackup.Location = new System.Drawing.Point(725, 266);
            this.btnCopyCodePathBackup.Name = "btnCopyCodePathBackup";
            this.btnCopyCodePathBackup.Size = new System.Drawing.Size(74, 35);
            this.btnCopyCodePathBackup.TabIndex = 22;
            this.btnCopyCodePathBackup.Text = "复制...";
            this.btnCopyCodePathBackup.Click += new System.EventHandler(this.btnCopyCodePathBackup_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "后缀路径";
            // 
            // txtSuffixPath
            // 
            this.btnBrowser4Path.SetColumnSpan(this.txtSuffixPath, 3);
            this.txtSuffixPath.Location = new System.Drawing.Point(101, 323);
            this.txtSuffixPath.Multiline = true;
            this.txtSuffixPath.Name = "txtSuffixPath";
            this.txtSuffixPath.Size = new System.Drawing.Size(527, 28);
            this.txtSuffixPath.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "工程路径";
            // 
            // txtProjectFileName
            // 
            this.btnBrowser4Path.SetColumnSpan(this.txtProjectFileName, 3);
            this.txtProjectFileName.Location = new System.Drawing.Point(101, 123);
            this.txtProjectFileName.Multiline = true;
            this.txtProjectFileName.Name = "txtProjectFileName";
            this.txtProjectFileName.Size = new System.Drawing.Size(527, 26);
            this.txtProjectFileName.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(292, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 21);
            this.label6.TabIndex = 27;
            this.label6.Text = "表主类型";
            // 
            // cboTabMainTypeId
            // 
            this.cboTabMainTypeId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTabMainTypeId.Location = new System.Drawing.Point(398, 3);
            this.cboTabMainTypeId.Name = "cboTabMainTypeId";
            this.cboTabMainTypeId.Size = new System.Drawing.Size(229, 22);
            this.cboTabMainTypeId.TabIndex = 28;
            // 
            // frmUserCodePath_UI
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
            this.ClientSize = new System.Drawing.Size(919, 569);
            this.Controls.Add(this.btnBrowser4Path);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOKUpd);
            this.Controls.Add(this.lblMsg);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "frmUserCodePath_UI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUserCodePath_UI";
            this.Load += new System.EventHandler(this.frmUserCodePath_UI_Load);
            this.btnBrowser4Path.ResumeLayout(false);
            this.btnBrowser4Path.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Label lblPrjId;
        private System.Windows.Forms.ComboBox cboPrjId;
        private System.Windows.Forms.Label lblCodeTypeId;
        private System.Windows.Forms.ComboBox cboCodeTypeId;
        private System.Windows.Forms.Label lblCodePath;
        private System.Windows.Forms.TextBox txtCodePath;
        private System.Windows.Forms.Label lblMemo;
        private System.Windows.Forms.TextBox txtMemo;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnOKUpd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TableLayoutPanel btnBrowser4Path;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnBrowserbackup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodePathBackup;
        private System.Windows.Forms.CheckBox chkIsGeneCode;
        private System.Windows.Forms.Button btnCopyCodePath;
        private System.Windows.Forms.Button btnCopyCodePathBackup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSuffixPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProjectPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProjectFileName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboTabMainTypeId;
    }
}