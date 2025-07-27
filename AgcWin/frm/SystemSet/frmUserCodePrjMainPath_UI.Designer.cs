
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
    ///		frmUserCodePrjMainPath_UI 的摘要说明。
    /// </summary>
    partial class frmUserCodePrjMainPath_UI
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
            this.lblUserId = new System.Windows.Forms.Label();
            this.cboUserId = new System.Windows.Forms.ComboBox();
            this.lblPrjId = new System.Windows.Forms.Label();
            this.cboPrjId = new System.Windows.Forms.ComboBox();
            this.lblCodeTypeId = new System.Windows.Forms.Label();
            this.lblCodePath = new System.Windows.Forms.Label();
            this.txtCodePath = new System.Windows.Forms.TextBox();
            this.lblMemo = new System.Windows.Forms.Label();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnOKUpd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBrowser4Path = new System.Windows.Forms.TableLayoutPanel();
            this.txtIncludeXmlPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLogPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBrowserbackup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.txtCodePathBackup = new System.Windows.Forms.TextBox();
            this.chkIsUsePrjMainPath = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboCmPrjAppId = new System.Windows.Forms.ComboBox();
            this.chkInUse = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnBrowser4Path.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUserId
            // 
            this.lblUserId.Location = new System.Drawing.Point(3, 0);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(81, 21);
            this.lblUserId.TabIndex = 1;
            this.lblUserId.Text = "用户";
            // 
            // cboUserId
            // 
            this.cboUserId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUserId.Location = new System.Drawing.Point(95, 3);
            this.cboUserId.Name = "cboUserId";
            this.cboUserId.Size = new System.Drawing.Size(174, 22);
            this.cboUserId.TabIndex = 2;
            // 
            // lblPrjId
            // 
            this.lblPrjId.Location = new System.Drawing.Point(275, 0);
            this.lblPrjId.Name = "lblPrjId";
            this.lblPrjId.Size = new System.Drawing.Size(82, 21);
            this.lblPrjId.TabIndex = 3;
            this.lblPrjId.Text = "工程";
            // 
            // cboPrjId
            // 
            this.cboPrjId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPrjId.Location = new System.Drawing.Point(381, 3);
            this.cboPrjId.Name = "cboPrjId";
            this.cboPrjId.Size = new System.Drawing.Size(232, 22);
            this.cboPrjId.TabIndex = 4;
            // 
            // lblCodeTypeId
            // 
            this.lblCodeTypeId.Location = new System.Drawing.Point(3, 60);
            this.lblCodeTypeId.Name = "lblCodeTypeId";
            this.lblCodeTypeId.Size = new System.Drawing.Size(81, 20);
            this.lblCodeTypeId.TabIndex = 5;
            this.lblCodeTypeId.Text = "项目主路径";
            // 
            // lblCodePath
            // 
            this.lblCodePath.Location = new System.Drawing.Point(3, 90);
            this.lblCodePath.Name = "lblCodePath";
            this.lblCodePath.Size = new System.Drawing.Size(82, 20);
            this.lblCodePath.TabIndex = 7;
            this.lblCodePath.Text = "代码路径";
            // 
            // txtCodePath
            // 
            this.btnBrowser4Path.SetColumnSpan(this.txtCodePath, 3);
            this.txtCodePath.Location = new System.Drawing.Point(95, 93);
            this.txtCodePath.Multiline = true;
            this.txtCodePath.Name = "txtCodePath";
            this.txtCodePath.Size = new System.Drawing.Size(518, 52);
            this.txtCodePath.TabIndex = 8;
            // 
            // lblMemo
            // 
            this.lblMemo.Location = new System.Drawing.Point(3, 153);
            this.lblMemo.Name = "lblMemo";
            this.lblMemo.Size = new System.Drawing.Size(81, 21);
            this.lblMemo.TabIndex = 13;
            this.lblMemo.Text = "备份路径";
            // 
            // txtMemo
            // 
            this.btnBrowser4Path.SetColumnSpan(this.txtMemo, 3);
            this.txtMemo.Location = new System.Drawing.Point(95, 274);
            this.txtMemo.Multiline = true;
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(518, 52);
            this.txtMemo.TabIndex = 14;
            // 
            // lblMsg
            // 
            this.lblMsg.Location = new System.Drawing.Point(146, 383);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(424, 41);
            this.lblMsg.TabIndex = 17;
            // 
            // btnOKUpd
            // 
            this.btnOKUpd.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOKUpd.Location = new System.Drawing.Point(146, 348);
            this.btnOKUpd.Name = "btnOKUpd";
            this.btnOKUpd.Size = new System.Drawing.Size(93, 35);
            this.btnOKUpd.TabIndex = 15;
            this.btnOKUpd.Text = "添加";
            this.btnOKUpd.Click += new System.EventHandler(this.btnOKUpd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.Location = new System.Drawing.Point(286, 348);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(93, 35);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnBrowser4Path
            // 
            this.btnBrowser4Path.ColumnCount = 5;
            this.btnBrowser4Path.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.94834F));
            this.btnBrowser4Path.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.05166F));
            this.btnBrowser4Path.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.btnBrowser4Path.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 238F));
            this.btnBrowser4Path.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.btnBrowser4Path.Controls.Add(this.txtIncludeXmlPath, 1, 5);
            this.btnBrowser4Path.Controls.Add(this.label2, 0, 5);
            this.btnBrowser4Path.Controls.Add(this.txtLogPath, 1, 6);
            this.btnBrowser4Path.Controls.Add(this.label3, 0, 6);
            this.btnBrowser4Path.Controls.Add(this.btnBrowserbackup, 4, 4);
            this.btnBrowser4Path.Controls.Add(this.label1, 0, 7);
            this.btnBrowser4Path.Controls.Add(this.cboPrjId, 3, 0);
            this.btnBrowser4Path.Controls.Add(this.lblMemo, 0, 4);
            this.btnBrowser4Path.Controls.Add(this.txtCodePath, 1, 3);
            this.btnBrowser4Path.Controls.Add(this.lblCodePath, 0, 3);
            this.btnBrowser4Path.Controls.Add(this.lblCodeTypeId, 0, 2);
            this.btnBrowser4Path.Controls.Add(this.lblUserId, 0, 0);
            this.btnBrowser4Path.Controls.Add(this.lblPrjId, 2, 0);
            this.btnBrowser4Path.Controls.Add(this.cboUserId, 1, 0);
            this.btnBrowser4Path.Controls.Add(this.btnBrowser, 4, 3);
            this.btnBrowser4Path.Controls.Add(this.txtMemo, 1, 7);
            this.btnBrowser4Path.Controls.Add(this.txtCodePathBackup, 1, 4);
            this.btnBrowser4Path.Controls.Add(this.chkIsUsePrjMainPath, 1, 2);
            this.btnBrowser4Path.Controls.Add(this.label5, 0, 1);
            this.btnBrowser4Path.Controls.Add(this.cboCmPrjAppId, 1, 1);
            this.btnBrowser4Path.Controls.Add(this.chkInUse, 3, 2);
            this.btnBrowser4Path.Controls.Add(this.label6, 2, 2);
            this.btnBrowser4Path.Location = new System.Drawing.Point(12, 12);
            this.btnBrowser4Path.Name = "btnBrowser4Path";
            this.btnBrowser4Path.RowCount = 8;
            this.btnBrowser4Path.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.btnBrowser4Path.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.btnBrowser4Path.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.btnBrowser4Path.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.btnBrowser4Path.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.btnBrowser4Path.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.btnBrowser4Path.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.btnBrowser4Path.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.btnBrowser4Path.Size = new System.Drawing.Size(719, 330);
            this.btnBrowser4Path.TabIndex = 18;
            // 
            // txtIncludeXmlPath
            // 
            this.btnBrowser4Path.SetColumnSpan(this.txtIncludeXmlPath, 3);
            this.txtIncludeXmlPath.Location = new System.Drawing.Point(95, 213);
            this.txtIncludeXmlPath.Multiline = true;
            this.txtIncludeXmlPath.Name = "txtIncludeXmlPath";
            this.txtIncludeXmlPath.Size = new System.Drawing.Size(518, 24);
            this.txtIncludeXmlPath.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "包含表路径";
            // 
            // txtLogPath
            // 
            this.btnBrowser4Path.SetColumnSpan(this.txtLogPath, 3);
            this.txtLogPath.Location = new System.Drawing.Point(95, 243);
            this.txtLogPath.Multiline = true;
            this.txtLogPath.Name = "txtLogPath";
            this.txtLogPath.Size = new System.Drawing.Size(518, 25);
            this.txtLogPath.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "日志路径";
            // 
            // btnBrowserbackup
            // 
            this.btnBrowserbackup.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBrowserbackup.Location = new System.Drawing.Point(619, 156);
            this.btnBrowserbackup.Name = "btnBrowserbackup";
            this.btnBrowserbackup.Size = new System.Drawing.Size(77, 35);
            this.btnBrowserbackup.TabIndex = 19;
            this.btnBrowserbackup.Text = "浏览...";
            this.btnBrowserbackup.Click += new System.EventHandler(this.btnBrowserbackup_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "说明";
            // 
            // btnBrowser
            // 
            this.btnBrowser.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBrowser.Location = new System.Drawing.Point(619, 93);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(77, 35);
            this.btnBrowser.TabIndex = 17;
            this.btnBrowser.Text = "浏览...";
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // txtCodePathBackup
            // 
            this.btnBrowser4Path.SetColumnSpan(this.txtCodePathBackup, 3);
            this.txtCodePathBackup.Location = new System.Drawing.Point(95, 156);
            this.txtCodePathBackup.Multiline = true;
            this.txtCodePathBackup.Name = "txtCodePathBackup";
            this.txtCodePathBackup.Size = new System.Drawing.Size(518, 51);
            this.txtCodePathBackup.TabIndex = 19;
            // 
            // chkIsUsePrjMainPath
            // 
            this.chkIsUsePrjMainPath.AutoSize = true;
            this.chkIsUsePrjMainPath.Location = new System.Drawing.Point(95, 63);
            this.chkIsUsePrjMainPath.Name = "chkIsUsePrjMainPath";
            this.chkIsUsePrjMainPath.Size = new System.Drawing.Size(15, 14);
            this.chkIsUsePrjMainPath.TabIndex = 21;
            this.chkIsUsePrjMainPath.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "CM工程应用";
            // 
            // cboCmPrjAppId
            // 
            this.btnBrowser4Path.SetColumnSpan(this.cboCmPrjAppId, 3);
            this.cboCmPrjAppId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCmPrjAppId.Location = new System.Drawing.Point(95, 33);
            this.cboCmPrjAppId.Name = "cboCmPrjAppId";
            this.cboCmPrjAppId.Size = new System.Drawing.Size(388, 22);
            this.cboCmPrjAppId.TabIndex = 24;
            // 
            // chkInUse
            // 
            this.chkInUse.AutoSize = true;
            this.chkInUse.Location = new System.Drawing.Point(381, 63);
            this.chkInUse.Name = "chkInUse";
            this.chkInUse.Size = new System.Drawing.Size(15, 14);
            this.chkInUse.TabIndex = 25;
            this.chkInUse.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(275, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "在用";
            // 
            // frmUserCodePrjMainPath_UI
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
            this.ClientSize = new System.Drawing.Size(743, 442);
            this.Controls.Add(this.btnBrowser4Path);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOKUpd);
            this.Controls.Add(this.lblMsg);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "frmUserCodePrjMainPath_UI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUserCodePrjMainPath_UI";
            this.Load += new System.EventHandler(this.frmUserCodePrjMainPath_UI_Load);
            this.btnBrowser4Path.ResumeLayout(false);
            this.btnBrowser4Path.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.ComboBox cboUserId;
        private System.Windows.Forms.Label lblPrjId;
        private System.Windows.Forms.ComboBox cboPrjId;
        private System.Windows.Forms.Label lblCodeTypeId;
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
        private System.Windows.Forms.CheckBox chkIsUsePrjMainPath;
        private System.Windows.Forms.TextBox txtLogPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIncludeXmlPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboCmPrjAppId;
        private System.Windows.Forms.CheckBox chkInUse;
        private System.Windows.Forms.Label label6;
    }
}