namespace AGC_CSWin
{
    /// <summary>
    ///		frmUserPrjGrant_UI 的摘要说明。
    /// </summary>
    partial class frmUserPrjGrant_UI
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
            this.ddlUserId = new System.Windows.Forms.ComboBox();
            this.lblPrjId = new System.Windows.Forms.Label();
            this.ddlPrjId = new System.Windows.Forms.ComboBox();
            this.lblRoleId = new System.Windows.Forms.Label();
            this.ddlRoleId = new System.Windows.Forms.ComboBox();
            this.lblMemo = new System.Windows.Forms.Label();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnOKUpd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(12, 11);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(49, 14);
            this.lblUserId.TabIndex = 1;
            this.lblUserId.Text = "用户ID";
            // 
            // ddlUserId
            // 
            this.ddlUserId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlUserId.Location = new System.Drawing.Point(67, 7);
            this.ddlUserId.Name = "ddlUserId";
            this.ddlUserId.Size = new System.Drawing.Size(413, 22);
            this.ddlUserId.TabIndex = 2;
            // 
            // lblPrjId
            // 
            this.lblPrjId.AutoSize = true;
            this.lblPrjId.Location = new System.Drawing.Point(11, 51);
            this.lblPrjId.Name = "lblPrjId";
            this.lblPrjId.Size = new System.Drawing.Size(49, 14);
            this.lblPrjId.TabIndex = 3;
            this.lblPrjId.Text = "项目ID";
            // 
            // ddlPrjId
            // 
            this.ddlPrjId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlPrjId.Location = new System.Drawing.Point(67, 47);
            this.ddlPrjId.Name = "ddlPrjId";
            this.ddlPrjId.Size = new System.Drawing.Size(412, 22);
            this.ddlPrjId.TabIndex = 4;
            // 
            // lblRoleId
            // 
            this.lblRoleId.AutoSize = true;
            this.lblRoleId.Location = new System.Drawing.Point(12, 91);
            this.lblRoleId.Name = "lblRoleId";
            this.lblRoleId.Size = new System.Drawing.Size(49, 14);
            this.lblRoleId.TabIndex = 5;
            this.lblRoleId.Text = "角色ID";
            // 
            // ddlRoleId
            // 
            this.ddlRoleId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlRoleId.Location = new System.Drawing.Point(67, 87);
            this.ddlRoleId.Name = "ddlRoleId";
            this.ddlRoleId.Size = new System.Drawing.Size(413, 22);
            this.ddlRoleId.TabIndex = 6;
            // 
            // lblMemo
            // 
            this.lblMemo.AutoSize = true;
            this.lblMemo.Location = new System.Drawing.Point(12, 131);
            this.lblMemo.Name = "lblMemo";
            this.lblMemo.Size = new System.Drawing.Size(35, 14);
            this.lblMemo.TabIndex = 13;
            this.lblMemo.Text = "备注";
            // 
            // txtMemo
            // 
            this.txtMemo.Location = new System.Drawing.Point(67, 127);
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(413, 23);
            this.txtMemo.TabIndex = 14;
            // 
            // lblMsg
            // 
            this.lblMsg.Location = new System.Drawing.Point(142, 218);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(337, 68);
            this.lblMsg.TabIndex = 17;
            // 
            // btnOKUpd
            // 
            this.btnOKUpd.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOKUpd.Location = new System.Drawing.Point(142, 183);
            this.btnOKUpd.Name = "btnOKUpd";
            this.btnOKUpd.Size = new System.Drawing.Size(93, 35);
            this.btnOKUpd.TabIndex = 15;
            this.btnOKUpd.Text = "添加";
            this.btnOKUpd.Click += new System.EventHandler(this.btnOKUpd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.Location = new System.Drawing.Point(282, 183);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(93, 35);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmUserPrjGrant_UI
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
            this.ClientSize = new System.Drawing.Size(503, 295);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.ddlUserId);
            this.Controls.Add(this.lblPrjId);
            this.Controls.Add(this.ddlPrjId);
            this.Controls.Add(this.lblRoleId);
            this.Controls.Add(this.ddlRoleId);
            this.Controls.Add(this.lblMemo);
            this.Controls.Add(this.txtMemo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOKUpd);
            this.Controls.Add(this.lblMsg);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "frmUserPrjGrant_UI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUserPrjGrant_UI";
            this.Load += new System.EventHandler(this.frmUserPrjGrant_UI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.ComboBox ddlUserId;
        private System.Windows.Forms.Label lblPrjId;
        private System.Windows.Forms.ComboBox ddlPrjId;
        private System.Windows.Forms.Label lblRoleId;
        private System.Windows.Forms.ComboBox ddlRoleId;
        private System.Windows.Forms.Label lblMemo;
        private System.Windows.Forms.TextBox txtMemo;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnOKUpd;
        private System.Windows.Forms.Button btnClose;
    }
}