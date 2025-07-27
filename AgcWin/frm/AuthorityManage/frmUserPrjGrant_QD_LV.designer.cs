namespace AGC_CSWin
{
    /// <summary>
    ///		frmUserPrjGrant_QD_LV 的摘要说明。
    /// </summary>
    partial class frmUserPrjGrant_QD_LV
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
            this.btnQuery = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelRec = new System.Windows.Forms.Button();
            this.btnExportExcel4Dg = new System.Windows.Forms.Button();
            this.lblRecNum = new System.Windows.Forms.Label();
            this.lvvUserPrjGrant = new System.Windows.Forms.ListView();
            this.gbQueryCondition = new System.Windows.Forms.GroupBox();
            this.gbQueryCondition.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUserId
            // 
            this.lblUserId.Location = new System.Drawing.Point(10, 18);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(70, 18);
            this.lblUserId.TabIndex = 1;
            this.lblUserId.Text = "用户ID";
            // 
            // ddlUserId
            // 
            this.ddlUserId.Location = new System.Drawing.Point(90, 18);
            this.ddlUserId.Name = "ddlUserId";
            this.ddlUserId.Size = new System.Drawing.Size(100, 22);
            this.ddlUserId.TabIndex = 2;
            // 
            // lblPrjId
            // 
            this.lblPrjId.Location = new System.Drawing.Point(260, 18);
            this.lblPrjId.Name = "lblPrjId";
            this.lblPrjId.Size = new System.Drawing.Size(70, 18);
            this.lblPrjId.TabIndex = 3;
            this.lblPrjId.Text = "项目ID";
            // 
            // ddlPrjId
            // 
            this.ddlPrjId.Location = new System.Drawing.Point(340, 18);
            this.ddlPrjId.Name = "ddlPrjId";
            this.ddlPrjId.Size = new System.Drawing.Size(100, 22);
            this.ddlPrjId.TabIndex = 4;
            // 
            // lblRoleId
            // 
            this.lblRoleId.Location = new System.Drawing.Point(459, 22);
            this.lblRoleId.Name = "lblRoleId";
            this.lblRoleId.Size = new System.Drawing.Size(70, 18);
            this.lblRoleId.TabIndex = 5;
            this.lblRoleId.Text = "角色ID";
            // 
            // ddlRoleId
            // 
            this.ddlRoleId.Location = new System.Drawing.Point(539, 22);
            this.ddlRoleId.Name = "ddlRoleId";
            this.ddlRoleId.Size = new System.Drawing.Size(100, 22);
            this.ddlRoleId.TabIndex = 6;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(323, 57);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(80, 26);
            this.btnQuery.TabIndex = 12;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.Location = new System.Drawing.Point(187, 64);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(128, 16);
            this.lblMsg.TabIndex = 7;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(491, 57);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 26);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(403, 57);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 26);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "添加";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelRec
            // 
            this.btnDelRec.Location = new System.Drawing.Point(571, 57);
            this.btnDelRec.Name = "btnDelRec";
            this.btnDelRec.Size = new System.Drawing.Size(80, 26);
            this.btnDelRec.TabIndex = 10;
            this.btnDelRec.Text = "删除记录";
            this.btnDelRec.Click += new System.EventHandler(this.btnDelRec_Click);
            // 
            // btnExportExcel4Dg
            // 
            this.btnExportExcel4Dg.Location = new System.Drawing.Point(659, 57);
            this.btnExportExcel4Dg.Name = "btnExportExcel4Dg";
            this.btnExportExcel4Dg.Size = new System.Drawing.Size(80, 26);
            this.btnExportExcel4Dg.TabIndex = 11;
            this.btnExportExcel4Dg.Text = "导出Excel";
            this.btnExportExcel4Dg.Click += new System.EventHandler(this.btnExportExcel4Dg_Click);
            // 
            // lblRecNum
            // 
            this.lblRecNum.Location = new System.Drawing.Point(747, 64);
            this.lblRecNum.Name = "lblRecNum";
            this.lblRecNum.Size = new System.Drawing.Size(112, 16);
            this.lblRecNum.TabIndex = 13;
            this.lblRecNum.Text = "记录数：";
            // 
            // lvvUserPrjGrant
            // 
            this.lvvUserPrjGrant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvvUserPrjGrant.FullRowSelect = true;
            this.lvvUserPrjGrant.Location = new System.Drawing.Point(0, 98);
            this.lvvUserPrjGrant.Name = "lvvUserPrjGrant";
            this.lvvUserPrjGrant.Size = new System.Drawing.Size(1000, 602);
            this.lvvUserPrjGrant.TabIndex = 14;
            this.lvvUserPrjGrant.UseCompatibleStateImageBehavior = false;
            this.lvvUserPrjGrant.View = System.Windows.Forms.View.Details;
            this.lvvUserPrjGrant.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvvUserPrjGrant_ColumnClick);
            this.lvvUserPrjGrant.Click += new System.EventHandler(this.lvvUserPrjGrant_Click);
            // 
            // gbQueryCondition
            // 
            this.gbQueryCondition.Controls.Add(this.lblUserId);
            this.gbQueryCondition.Controls.Add(this.ddlUserId);
            this.gbQueryCondition.Controls.Add(this.lblPrjId);
            this.gbQueryCondition.Controls.Add(this.ddlPrjId);
            this.gbQueryCondition.Controls.Add(this.lblRoleId);
            this.gbQueryCondition.Controls.Add(this.ddlRoleId);
            this.gbQueryCondition.Controls.Add(this.btnExportExcel4Dg);
            this.gbQueryCondition.Controls.Add(this.btnQuery);
            this.gbQueryCondition.Controls.Add(this.btnUpdate);
            this.gbQueryCondition.Controls.Add(this.btnAdd);
            this.gbQueryCondition.Controls.Add(this.btnDelRec);
            this.gbQueryCondition.Controls.Add(this.lblMsg);
            this.gbQueryCondition.Controls.Add(this.lblRecNum);
            this.gbQueryCondition.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbQueryCondition.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbQueryCondition.Location = new System.Drawing.Point(0, 0);
            this.gbQueryCondition.Name = "gbQueryCondition";
            this.gbQueryCondition.Size = new System.Drawing.Size(1000, 98);
            this.gbQueryCondition.TabIndex = 15;
            this.gbQueryCondition.TabStop = false;
            this.gbQueryCondition.Text = "查询条件";
            // 
            // frmUserPrjGrant_QD_LV
            // 
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.lvvUserPrjGrant);
            this.Controls.Add(this.gbQueryCondition);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "frmUserPrjGrant_QD_LV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUserPrjGrant_QD_LV";
            this.Load += new System.EventHandler(this.frmUserPrjGrant_QD_Load);
            this.gbQueryCondition.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.ComboBox ddlUserId;
        private System.Windows.Forms.Label lblPrjId;
        private System.Windows.Forms.ComboBox ddlPrjId;
        private System.Windows.Forms.Label lblRoleId;
        private System.Windows.Forms.ComboBox ddlRoleId;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelRec;
        private System.Windows.Forms.Button btnExportExcel4Dg;
        private System.Windows.Forms.Label lblRecNum;
        private System.Windows.Forms.GroupBox gbQueryCondition;
        private System.Windows.Forms.ListView lvvUserPrjGrant;
    }
}