
///----------------------
///生成代码版本：2012.10.19.1
///生成日期：2012/10/21
///生成者：潘以锋
///工程名称：AGC
///工程ID：0005
///模块中文名：日志管理
///模块英文名：LogManage
///注意：1、需要数据底层（PubDataBase.dll）的版本：2012.10.20.1
///       2、需要公共函数层（TzPubFunction.dll）的版本：2012.10.20.1
///========================
namespace AGC
{
    /// <summary>
    ///		frmTabCheckResult_UI 的摘要说明。
    /// </summary>
    partial class frmTabCheckResult_UI
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
            this.lblTabId = new System.Windows.Forms.Label();
            this.cboTabId = new System.Windows.Forms.ComboBox();
            this.lblFldID = new System.Windows.Forms.Label();
            this.txtFldID = new System.Windows.Forms.TextBox();
            this.lblErrorLevelId = new System.Windows.Forms.Label();
            this.cboErrorLevelId = new System.Windows.Forms.ComboBox();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.txtErrorMsg = new System.Windows.Forms.TextBox();
            this.lblCheckDate = new System.Windows.Forms.Label();
            this.txtCheckDate = new System.Windows.Forms.TextBox();
            this.lblCheckUser = new System.Windows.Forms.Label();
            this.txtCheckUser = new System.Windows.Forms.TextBox();
            this.lblMemo = new System.Windows.Forms.Label();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnOKUpd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lblPrjId
            //
            this.lblPrjId.Location = new System.Drawing.Point(10, 10);
            this.lblPrjId.Name = "lblPrjId";
            this.lblPrjId.Size = new System.Drawing.Size(70, 18);
            this.lblPrjId.TabIndex = 1;
            this.lblPrjId.Text = "工程ID";
            //
            // cboPrjId
            //
            this.cboPrjId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPrjId.Location = new System.Drawing.Point(90, 10);
            this.cboPrjId.Name = "cboPrjId";
            this.cboPrjId.Size = new System.Drawing.Size(100, 20);
            this.cboPrjId.TabIndex = 2;
            this.cboPrjId.Text = "";
            //
            // lblTabId
            //
            this.lblTabId.Location = new System.Drawing.Point(260, 10);
            this.lblTabId.Name = "lblTabId";
            this.lblTabId.Size = new System.Drawing.Size(70, 18);
            this.lblTabId.TabIndex = 3;
            this.lblTabId.Text = "表ID";
            //
            // cboTabId
            //
            this.cboTabId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTabId.Location = new System.Drawing.Point(340, 10);
            this.cboTabId.Name = "cboTabId";
            this.cboTabId.Size = new System.Drawing.Size(100, 20);
            this.cboTabId.TabIndex = 4;
            this.cboTabId.Text = "";
            //
            // lblFldID
            //
            this.lblFldID.Location = new System.Drawing.Point(10, 40);
            this.lblFldID.Name = "lblFldID";
            this.lblFldID.Size = new System.Drawing.Size(70, 18);
            this.lblFldID.TabIndex = 5;
            this.lblFldID.Text = "字段ID";
            //
            // txtFldID
            //
            this.txtFldID.Location = new System.Drawing.Point(90, 40);
            this.txtFldID.Name = "txtFldID";
            this.txtFldID.Size = new System.Drawing.Size(100, 20);
            this.txtFldID.TabIndex = 6;
            this.txtFldID.Text = "";
            //
            // lblErrorLevelId
            //
            this.lblErrorLevelId.Location = new System.Drawing.Point(260, 40);
            this.lblErrorLevelId.Name = "lblErrorLevelId";
            this.lblErrorLevelId.Size = new System.Drawing.Size(70, 18);
            this.lblErrorLevelId.TabIndex = 7;
            this.lblErrorLevelId.Text = "错误等级Id";
            //
            // cboErrorLevelId
            //
            this.cboErrorLevelId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboErrorLevelId.Location = new System.Drawing.Point(340, 40);
            this.cboErrorLevelId.Name = "cboErrorLevelId";
            this.cboErrorLevelId.Size = new System.Drawing.Size(100, 20);
            this.cboErrorLevelId.TabIndex = 8;
            this.cboErrorLevelId.Text = "";
            //
            // lblErrorMsg
            //
            this.lblErrorMsg.Location = new System.Drawing.Point(10, 70);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(70, 18);
            this.lblErrorMsg.TabIndex = 9;
            this.lblErrorMsg.Text = "错误信息";
            //
            // txtErrorMsg
            //
            this.txtErrorMsg.Location = new System.Drawing.Point(90, 70);
            this.txtErrorMsg.Name = "txtErrorMsg";
            this.txtErrorMsg.Size = new System.Drawing.Size(100, 20);
            this.txtErrorMsg.TabIndex = 10;
            this.txtErrorMsg.Text = "";
            //
            // lblCheckDate
            //
            this.lblCheckDate.Location = new System.Drawing.Point(260, 70);
            this.lblCheckDate.Name = "lblCheckDate";
            this.lblCheckDate.Size = new System.Drawing.Size(70, 18);
            this.lblCheckDate.TabIndex = 11;
            this.lblCheckDate.Text = "检查日期";
            //
            // txtCheckDate
            //
            this.txtCheckDate.Location = new System.Drawing.Point(340, 70);
            this.txtCheckDate.Name = "txtCheckDate";
            this.txtCheckDate.Size = new System.Drawing.Size(100, 20);
            this.txtCheckDate.TabIndex = 12;
            this.txtCheckDate.Text = "";
            //
            // lblCheckUser
            //
            this.lblCheckUser.Location = new System.Drawing.Point(10, 100);
            this.lblCheckUser.Name = "lblCheckUser";
            this.lblCheckUser.Size = new System.Drawing.Size(70, 18);
            this.lblCheckUser.TabIndex = 13;
            this.lblCheckUser.Text = "检查人";
            //
            // txtCheckUser
            //
            this.txtCheckUser.Location = new System.Drawing.Point(90, 100);
            this.txtCheckUser.Name = "txtCheckUser";
            this.txtCheckUser.Size = new System.Drawing.Size(100, 20);
            this.txtCheckUser.TabIndex = 14;
            this.txtCheckUser.Text = "";
            //
            // lblMemo
            //
            this.lblMemo.Location = new System.Drawing.Point(260, 100);
            this.lblMemo.Name = "lblMemo";
            this.lblMemo.Size = new System.Drawing.Size(70, 18);
            this.lblMemo.TabIndex = 15;
            this.lblMemo.Text = "说明";
            //
            // txtMemo
            //
            this.txtMemo.Location = new System.Drawing.Point(340, 100);
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(100, 20);
            this.txtMemo.TabIndex = 16;
            this.txtMemo.Text = "";
            // 
            // btnOKUpd
            // 
            this.btnOKUpd.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
            this.btnOKUpd.Location = new System.Drawing.Point(125, 65);
            this.btnOKUpd.Name = "btnOKUpd";
            this.btnOKUpd.Size = new System.Drawing.Size(80, 30);
            this.btnOKUpd.TabIndex = 17;
            this.btnOKUpd.Text = "添加";
            this.btnOKUpd.Click += new System.EventHandler(this.btnOKUpd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
            this.btnClose.Location = new System.Drawing.Point(245, 65);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 30);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.Location = new System.Drawing.Point(125, 95);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(128, 16);
            this.lblMsg.TabIndex = 19;
            // 
            // frmTabCheckResult_UI
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(530, 135);
            this.Controls.Add(this.lblPrjId);
            this.Controls.Add(this.cboPrjId);
            this.Controls.Add(this.lblTabId);
            this.Controls.Add(this.cboTabId);
            this.Controls.Add(this.lblFldID);
            this.Controls.Add(this.txtFldID);
            this.Controls.Add(this.lblErrorLevelId);
            this.Controls.Add(this.cboErrorLevelId);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.txtErrorMsg);
            this.Controls.Add(this.lblCheckDate);
            this.Controls.Add(this.txtCheckDate);
            this.Controls.Add(this.lblCheckUser);
            this.Controls.Add(this.txtCheckUser);
            this.Controls.Add(this.lblMemo);
            this.Controls.Add(this.txtMemo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOKUpd);
            this.Controls.Add(this.lblMsg);
            this.Name = "frmTabCheckResult_UI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
            this.Text = "frmTabCheckResult_UI";
            this.Load += new System.EventHandler(this.frmTabCheckResult_UI_Load);
            this.ResumeLayout(false);
        }
        #endregion
        private System.Windows.Forms.Label lblPrjId;
        private System.Windows.Forms.ComboBox cboPrjId;
        private System.Windows.Forms.Label lblTabId;
        private System.Windows.Forms.ComboBox cboTabId;
        private System.Windows.Forms.Label lblFldID;
        private System.Windows.Forms.TextBox txtFldID;
        private System.Windows.Forms.Label lblErrorLevelId;
        private System.Windows.Forms.ComboBox cboErrorLevelId;
        private System.Windows.Forms.Label lblErrorMsg;
        private System.Windows.Forms.TextBox txtErrorMsg;
        private System.Windows.Forms.Label lblCheckDate;
        private System.Windows.Forms.TextBox txtCheckDate;
        private System.Windows.Forms.Label lblCheckUser;
        private System.Windows.Forms.TextBox txtCheckUser;
        private System.Windows.Forms.Label lblMemo;
        private System.Windows.Forms.TextBox txtMemo;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnOKUpd;
        private System.Windows.Forms.Button btnClose;
    }
}