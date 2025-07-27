
namespace AGC
{
    /// <summary>
    ///		frmTabCheckResult_QD_LV 的摘要说明。
    /// </summary>
    partial class frmTabCheckResult_QD_LV
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
            this.lblErrorLevelId = new System.Windows.Forms.Label();
            this.cboErrorLevelId = new System.Windows.Forms.ComboBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnSetNullableBySQL = new System.Windows.Forms.Button();
            this.btnDelRec = new System.Windows.Forms.Button();
            this.btnExportExcel4Dg = new System.Windows.Forms.Button();
            this.lblRecNum = new System.Windows.Forms.Label();
            this.lvvTabCheckResult = new System.Windows.Forms.ListView();
            this.gbQueryCondition = new System.Windows.Forms.GroupBox();
            this.btnCheckAllTabField = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cboSqlDsTypeId = new System.Windows.Forms.ComboBox();
            this.lblSqlDsTypeId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboPrjDataBaseId = new System.Windows.Forms.ComboBox();
            this.gbQueryCondition.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPrjId
            // 
            this.lblPrjId.Location = new System.Drawing.Point(3, 0);
            this.lblPrjId.Name = "lblPrjId";
            this.lblPrjId.Size = new System.Drawing.Size(69, 18);
            this.lblPrjId.TabIndex = 1;
            this.lblPrjId.Text = "工程ID";
            // 
            // cboPrjId
            // 
            this.cboPrjId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPrjId.Location = new System.Drawing.Point(78, 3);
            this.cboPrjId.Name = "cboPrjId";
            this.cboPrjId.Size = new System.Drawing.Size(210, 22);
            this.cboPrjId.TabIndex = 2;
            // 
            // lblTabId
            // 
            this.lblTabId.Location = new System.Drawing.Point(294, 31);
            this.lblTabId.Name = "lblTabId";
            this.lblTabId.Size = new System.Drawing.Size(70, 18);
            this.lblTabId.TabIndex = 3;
            this.lblTabId.Text = "表ID";
            // 
            // cboTabId
            // 
            this.cboTabId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTabId.Location = new System.Drawing.Point(383, 34);
            this.cboTabId.Name = "cboTabId";
            this.cboTabId.Size = new System.Drawing.Size(180, 22);
            this.cboTabId.TabIndex = 4;
            // 
            // lblErrorLevelId
            // 
            this.lblErrorLevelId.Location = new System.Drawing.Point(3, 31);
            this.lblErrorLevelId.Name = "lblErrorLevelId";
            this.lblErrorLevelId.Size = new System.Drawing.Size(69, 18);
            this.lblErrorLevelId.TabIndex = 5;
            this.lblErrorLevelId.Text = "错误等级Id";
            // 
            // cboErrorLevelId
            // 
            this.cboErrorLevelId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboErrorLevelId.Location = new System.Drawing.Point(78, 34);
            this.cboErrorLevelId.Name = "cboErrorLevelId";
            this.cboErrorLevelId.Size = new System.Drawing.Size(210, 22);
            this.cboErrorLevelId.TabIndex = 6;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(600, 34);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(80, 26);
            this.btnQuery.TabIndex = 12;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.Location = new System.Drawing.Point(192, 108);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(128, 16);
            this.lblMsg.TabIndex = 7;
            // 
            // btnSetNullableBySQL
            // 
            this.btnSetNullableBySQL.Location = new System.Drawing.Point(298, 101);
            this.btnSetNullableBySQL.Name = "btnSetNullableBySQL";
            this.btnSetNullableBySQL.Size = new System.Drawing.Size(190, 26);
            this.btnSetNullableBySQL.TabIndex = 8;
            this.btnSetNullableBySQL.Text = "根据SQL设置表字段可空性 ";
            this.btnSetNullableBySQL.Click += new System.EventHandler(this.btnSetNullableBySQL_Click);
            // 
            // btnDelRec
            // 
            this.btnDelRec.Location = new System.Drawing.Point(655, 101);
            this.btnDelRec.Name = "btnDelRec";
            this.btnDelRec.Size = new System.Drawing.Size(80, 26);
            this.btnDelRec.TabIndex = 10;
            this.btnDelRec.Text = "删除记录";
            this.btnDelRec.Click += new System.EventHandler(this.btnDelRec_Click);
            // 
            // btnExportExcel4Dg
            // 
            this.btnExportExcel4Dg.Location = new System.Drawing.Point(707, 34);
            this.btnExportExcel4Dg.Name = "btnExportExcel4Dg";
            this.btnExportExcel4Dg.Size = new System.Drawing.Size(80, 26);
            this.btnExportExcel4Dg.TabIndex = 11;
            this.btnExportExcel4Dg.Text = "导出Excel";
            this.btnExportExcel4Dg.Click += new System.EventHandler(this.btnExportExcel4Dg_Click);
            // 
            // lblRecNum
            // 
            this.lblRecNum.Location = new System.Drawing.Point(752, 108);
            this.lblRecNum.Name = "lblRecNum";
            this.lblRecNum.Size = new System.Drawing.Size(112, 16);
            this.lblRecNum.TabIndex = 13;
            this.lblRecNum.Text = "记录数：";
            // 
            // lvvTabCheckResult
            // 
            this.lvvTabCheckResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvvTabCheckResult.FullRowSelect = true;
            this.lvvTabCheckResult.Location = new System.Drawing.Point(0, 140);
            this.lvvTabCheckResult.Name = "lvvTabCheckResult";
            this.lvvTabCheckResult.Size = new System.Drawing.Size(1000, 560);
            this.lvvTabCheckResult.TabIndex = 14;
            this.lvvTabCheckResult.UseCompatibleStateImageBehavior = false;
            this.lvvTabCheckResult.View = System.Windows.Forms.View.Details;
            this.lvvTabCheckResult.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvvTabCheckResult_ColumnClick);
            this.lvvTabCheckResult.Click += new System.EventHandler(this.lvvTabCheckResult_Click);
            // 
            // gbQueryCondition
            // 
            this.gbQueryCondition.Controls.Add(this.btnCheckAllTabField);
            this.gbQueryCondition.Controls.Add(this.tableLayoutPanel1);
            this.gbQueryCondition.Controls.Add(this.btnSetNullableBySQL);
            this.gbQueryCondition.Controls.Add(this.btnDelRec);
            this.gbQueryCondition.Controls.Add(this.lblMsg);
            this.gbQueryCondition.Controls.Add(this.lblRecNum);
            this.gbQueryCondition.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbQueryCondition.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbQueryCondition.Location = new System.Drawing.Point(0, 0);
            this.gbQueryCondition.Name = "gbQueryCondition";
            this.gbQueryCondition.Size = new System.Drawing.Size(1000, 140);
            this.gbQueryCondition.TabIndex = 15;
            this.gbQueryCondition.TabStop = false;
            this.gbQueryCondition.Text = "查询条件";
            // 
            // btnCheckAllTabField
            // 
            this.btnCheckAllTabField.Location = new System.Drawing.Point(494, 101);
            this.btnCheckAllTabField.Name = "btnCheckAllTabField";
            this.btnCheckAllTabField.Size = new System.Drawing.Size(119, 26);
            this.btnCheckAllTabField.TabIndex = 28;
            this.btnCheckAllTabField.Text = "检查所有表字段";
            this.btnCheckAllTabField.Click += new System.EventHandler(this.btnCheckAllTabField_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.85551F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.14449F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 217F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel1.Controls.Add(this.cboPrjDataBaseId, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnExportExcel4Dg, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTabId, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnQuery, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboTabId, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboPrjId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblErrorLevelId, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPrjId, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboErrorLevelId, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboSqlDsTypeId, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSqlDsTypeId, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(817, 67);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // cboSqlDsTypeId
            // 
            this.cboSqlDsTypeId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSqlDsTypeId.Location = new System.Drawing.Point(707, 3);
            this.cboSqlDsTypeId.Name = "cboSqlDsTypeId";
            this.cboSqlDsTypeId.Size = new System.Drawing.Size(107, 22);
            this.cboSqlDsTypeId.TabIndex = 9;
            // 
            // lblSqlDsTypeId
            // 
            this.lblSqlDsTypeId.Location = new System.Drawing.Point(600, 0);
            this.lblSqlDsTypeId.Name = "lblSqlDsTypeId";
            this.lblSqlDsTypeId.Size = new System.Drawing.Size(81, 18);
            this.lblSqlDsTypeId.TabIndex = 8;
            this.lblSqlDsTypeId.Text = "数据源类型";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(294, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "工程数据库";
            // 
            // cboPrjDataBaseId
            // 
            this.cboPrjDataBaseId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPrjDataBaseId.Location = new System.Drawing.Point(383, 3);
            this.cboPrjDataBaseId.Name = "cboPrjDataBaseId";
            this.cboPrjDataBaseId.Size = new System.Drawing.Size(180, 22);
            this.cboPrjDataBaseId.TabIndex = 29;
            // 
            // frmTabCheckResult_QD_LV
            // 
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.lvvTabCheckResult);
            this.Controls.Add(this.gbQueryCondition);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "frmTabCheckResult_QD_LV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTabCheckResult_QD_LV";
            this.Load += new System.EventHandler(this.frmTabCheckResult_QD_Load);
            this.gbQueryCondition.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Label lblPrjId;
        private System.Windows.Forms.ComboBox cboPrjId;
        private System.Windows.Forms.Label lblTabId;
        private System.Windows.Forms.ComboBox cboTabId;
        private System.Windows.Forms.Label lblErrorLevelId;
        private System.Windows.Forms.ComboBox cboErrorLevelId;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnSetNullableBySQL;
        private System.Windows.Forms.Button btnDelRec;
        private System.Windows.Forms.Button btnExportExcel4Dg;
        private System.Windows.Forms.Label lblRecNum;
        private System.Windows.Forms.GroupBox gbQueryCondition;
        private System.Windows.Forms.ListView lvvTabCheckResult;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblSqlDsTypeId;
        private System.Windows.Forms.ComboBox cboSqlDsTypeId;
        private System.Windows.Forms.Button btnCheckAllTabField;
        private System.Windows.Forms.ComboBox cboPrjDataBaseId;
        private System.Windows.Forms.Label label1;
    }
}