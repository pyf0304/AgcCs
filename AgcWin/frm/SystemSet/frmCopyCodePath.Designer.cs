
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
    ///		frmCopyCodePath 的摘要说明。
    /// </summary>
    partial class frmCopyCodePath
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
            this.lblPrjId = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnOKUpd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBrowser4Path = new System.Windows.Forms.TableLayoutPanel();
            this.cboCodePath = new System.Windows.Forms.ComboBox();
            this.lblCodePath = new System.Windows.Forms.Label();
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
            // lblPrjId
            // 
            this.lblPrjId.Location = new System.Drawing.Point(103, 0);
            this.lblPrjId.Name = "lblPrjId";
            this.lblPrjId.Size = new System.Drawing.Size(82, 21);
            this.lblPrjId.TabIndex = 3;
            this.lblPrjId.Text = "工程";
            // 
            // lblMsg
            // 
            this.lblMsg.Location = new System.Drawing.Point(110, 198);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(424, 41);
            this.lblMsg.TabIndex = 17;
            // 
            // btnOKUpd
            // 
            this.btnOKUpd.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOKUpd.Location = new System.Drawing.Point(110, 163);
            this.btnOKUpd.Name = "btnOKUpd";
            this.btnOKUpd.Size = new System.Drawing.Size(93, 35);
            this.btnOKUpd.TabIndex = 15;
            this.btnOKUpd.Text = "确定";
            this.btnOKUpd.Click += new System.EventHandler(this.btnOKUpd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.Location = new System.Drawing.Point(250, 163);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(93, 35);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnBrowser4Path
            // 
            this.btnBrowser4Path.ColumnCount = 3;
            this.btnBrowser4Path.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.btnBrowser4Path.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.btnBrowser4Path.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.btnBrowser4Path.Controls.Add(this.lblUserId, 0, 0);
            this.btnBrowser4Path.Controls.Add(this.cboCodePath, 1, 1);
            this.btnBrowser4Path.Controls.Add(this.lblCodePath, 0, 1);
            this.btnBrowser4Path.Controls.Add(this.lblPrjId, 1, 0);
            this.btnBrowser4Path.Location = new System.Drawing.Point(12, 12);
            this.btnBrowser4Path.Name = "btnBrowser4Path";
            this.btnBrowser4Path.RowCount = 3;
            this.btnBrowser4Path.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.btnBrowser4Path.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.btnBrowser4Path.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.btnBrowser4Path.Size = new System.Drawing.Size(691, 134);
            this.btnBrowser4Path.TabIndex = 18;
            // 
            // cboCodePath
            // 
            this.cboCodePath.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodePath.Location = new System.Drawing.Point(103, 47);
            this.cboCodePath.Name = "cboCodePath";
            this.cboCodePath.Size = new System.Drawing.Size(562, 22);
            this.cboCodePath.TabIndex = 19;
            // 
            // lblCodePath
            // 
            this.lblCodePath.Location = new System.Drawing.Point(3, 44);
            this.lblCodePath.Name = "lblCodePath";
            this.lblCodePath.Size = new System.Drawing.Size(82, 20);
            this.lblCodePath.TabIndex = 7;
            this.lblCodePath.Text = "代码路径";
            // 
            // frmCopyCodePath
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
            this.ClientSize = new System.Drawing.Size(715, 234);
            this.Controls.Add(this.btnBrowser4Path);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOKUpd);
            this.Controls.Add(this.lblMsg);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "frmCopyCodePath";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCopyCodePath";
            this.Load += new System.EventHandler(this.frmCopyCodePath_Load);
            this.btnBrowser4Path.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label lblPrjId;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnOKUpd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TableLayoutPanel btnBrowser4Path;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ComboBox cboCodePath;
        private System.Windows.Forms.Label lblCodePath;
    }
}