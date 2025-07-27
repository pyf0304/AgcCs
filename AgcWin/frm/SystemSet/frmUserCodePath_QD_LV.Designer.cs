
namespace AGC
{
    /// <summary>
    ///		frmUserCodePath_QD_LV 的摘要说明。
    /// </summary>
    partial class frmUserCodePath_QD_LV
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
            this.btnQuery = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelRec = new System.Windows.Forms.Button();
            this.btnExportExcel4Dg = new System.Windows.Forms.Button();
            this.lblRecNum = new System.Windows.Forms.Label();
            this.lvvUserCodePath = new System.Windows.Forms.ListView();
            this.gbQueryCondition = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCopyRec = new System.Windows.Forms.Button();
            this.btnSetIsGeneCode = new System.Windows.Forms.Button();
            this.btnSetIsNotGeneCode = new System.Windows.Forms.Button();
            this.btnCheckPrjFileState = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCodePrjMainPath = new System.Windows.Forms.RichTextBox();
            this.lblCodePath = new System.Windows.Forms.Label();
            this.lblCodePathBackup = new System.Windows.Forms.Label();
            this.btnCreateBakDir = new System.Windows.Forms.Button();
            this.btnCreateDir = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chkDIskBackup = new System.Windows.Forms.CheckBox();
            this.btnSetMainPath = new System.Windows.Forms.Button();
            this.cboUserCodePrjMainPathId = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkEditTemplate = new System.Windows.Forms.CheckBox();
            this.btnCopyTemplateSet = new System.Windows.Forms.Button();
            this.cboIsGeneCode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCmPrjAppId = new System.Windows.Forms.ComboBox();
            this.cboProgLangTypeId = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbQueryCondition.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPrjId
            // 
            this.lblPrjId.Location = new System.Drawing.Point(816, 0);
            this.lblPrjId.Name = "lblPrjId";
            this.lblPrjId.Size = new System.Drawing.Size(56, 18);
            this.lblPrjId.TabIndex = 3;
            this.lblPrjId.Text = "工程";
            // 
            // cboPrjId
            // 
            this.cboPrjId.Location = new System.Drawing.Point(878, 3);
            this.cboPrjId.Name = "cboPrjId";
            this.cboPrjId.Size = new System.Drawing.Size(79, 22);
            this.cboPrjId.TabIndex = 4;
            // 
            // lblCodeTypeId
            // 
            this.lblCodeTypeId.Location = new System.Drawing.Point(181, 32);
            this.lblCodeTypeId.Name = "lblCodeTypeId";
            this.lblCodeTypeId.Size = new System.Drawing.Size(67, 18);
            this.lblCodeTypeId.TabIndex = 5;
            this.lblCodeTypeId.Text = "代码类型";
            // 
            // cboCodeTypeId
            // 
            this.cboCodeTypeId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodeTypeId.Location = new System.Drawing.Point(254, 35);
            this.cboCodeTypeId.Name = "cboCodeTypeId";
            this.cboCodeTypeId.Size = new System.Drawing.Size(138, 22);
            this.cboCodeTypeId.TabIndex = 6;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(963, 3);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(51, 26);
            this.btnQuery.TabIndex = 12;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.Location = new System.Drawing.Point(3, 0);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(128, 16);
            this.lblMsg.TabIndex = 7;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(255, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(50, 26);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(137, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(55, 26);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "添加";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelRec
            // 
            this.btnDelRec.Location = new System.Drawing.Point(311, 3);
            this.btnDelRec.Name = "btnDelRec";
            this.btnDelRec.Size = new System.Drawing.Size(50, 26);
            this.btnDelRec.TabIndex = 10;
            this.btnDelRec.Text = "删除";
            this.btnDelRec.Click += new System.EventHandler(this.btnDelRec_Click);
            // 
            // btnExportExcel4Dg
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnExportExcel4Dg, 2);
            this.btnExportExcel4Dg.Location = new System.Drawing.Point(878, 35);
            this.btnExportExcel4Dg.Name = "btnExportExcel4Dg";
            this.btnExportExcel4Dg.Size = new System.Drawing.Size(80, 26);
            this.btnExportExcel4Dg.TabIndex = 11;
            this.btnExportExcel4Dg.Text = "导出Excel";
            this.btnExportExcel4Dg.Click += new System.EventHandler(this.btnExportExcel4Dg_Click);
            // 
            // lblRecNum
            // 
            this.lblRecNum.Location = new System.Drawing.Point(743, 0);
            this.lblRecNum.Name = "lblRecNum";
            this.lblRecNum.Size = new System.Drawing.Size(112, 16);
            this.lblRecNum.TabIndex = 13;
            this.lblRecNum.Text = "记录数：";
            // 
            // lvvUserCodePath
            // 
            this.lvvUserCodePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvvUserCodePath.FullRowSelect = true;
            this.lvvUserCodePath.HideSelection = false;
            this.lvvUserCodePath.Location = new System.Drawing.Point(0, 323);
            this.lvvUserCodePath.Name = "lvvUserCodePath";
            this.lvvUserCodePath.Size = new System.Drawing.Size(1344, 493);
            this.lvvUserCodePath.TabIndex = 14;
            this.lvvUserCodePath.UseCompatibleStateImageBehavior = false;
            this.lvvUserCodePath.View = System.Windows.Forms.View.Details;
            this.lvvUserCodePath.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvvUserCodePath_ColumnClick);
            this.lvvUserCodePath.SelectedIndexChanged += new System.EventHandler(this.lvvUserCodePath_SelectedIndexChanged);
            this.lvvUserCodePath.Click += new System.EventHandler(this.lvvUserCodePath_Click);
            // 
            // gbQueryCondition
            // 
            this.gbQueryCondition.Controls.Add(this.flowLayoutPanel2);
            this.gbQueryCondition.Controls.Add(this.flowLayoutPanel1);
            this.gbQueryCondition.Controls.Add(this.btnCreateBakDir);
            this.gbQueryCondition.Controls.Add(this.btnCreateDir);
            this.gbQueryCondition.Controls.Add(this.tableLayoutPanel1);
            this.gbQueryCondition.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbQueryCondition.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbQueryCondition.Location = new System.Drawing.Point(0, 0);
            this.gbQueryCondition.Name = "gbQueryCondition";
            this.gbQueryCondition.Size = new System.Drawing.Size(1344, 323);
            this.gbQueryCondition.TabIndex = 15;
            this.gbQueryCondition.TabStop = false;
            this.gbQueryCondition.Text = "查询条件";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.lblMsg);
            this.flowLayoutPanel2.Controls.Add(this.btnAdd);
            this.flowLayoutPanel2.Controls.Add(this.btnCopyRec);
            this.flowLayoutPanel2.Controls.Add(this.btnUpdate);
            this.flowLayoutPanel2.Controls.Add(this.btnDelRec);
            this.flowLayoutPanel2.Controls.Add(this.btnSetIsGeneCode);
            this.flowLayoutPanel2.Controls.Add(this.btnSetIsNotGeneCode);
            this.flowLayoutPanel2.Controls.Add(this.btnCheckPrjFileState);
            this.flowLayoutPanel2.Controls.Add(this.lblRecNum);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(116, 94);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(910, 33);
            this.flowLayoutPanel2.TabIndex = 26;
            // 
            // btnCopyRec
            // 
            this.btnCopyRec.Location = new System.Drawing.Point(198, 3);
            this.btnCopyRec.Name = "btnCopyRec";
            this.btnCopyRec.Size = new System.Drawing.Size(51, 26);
            this.btnCopyRec.TabIndex = 15;
            this.btnCopyRec.Text = "复制";
            this.btnCopyRec.Click += new System.EventHandler(this.btnCopyRec_Click);
            // 
            // btnSetIsGeneCode
            // 
            this.btnSetIsGeneCode.Location = new System.Drawing.Point(367, 3);
            this.btnSetIsGeneCode.Name = "btnSetIsGeneCode";
            this.btnSetIsGeneCode.Size = new System.Drawing.Size(107, 26);
            this.btnSetIsGeneCode.TabIndex = 24;
            this.btnSetIsGeneCode.Text = "设置生成代码";
            this.btnSetIsGeneCode.Click += new System.EventHandler(this.btnSetIsGeneCode_Click);
            // 
            // btnSetIsNotGeneCode
            // 
            this.btnSetIsNotGeneCode.Location = new System.Drawing.Point(480, 3);
            this.btnSetIsNotGeneCode.Name = "btnSetIsNotGeneCode";
            this.btnSetIsNotGeneCode.Size = new System.Drawing.Size(121, 26);
            this.btnSetIsNotGeneCode.TabIndex = 25;
            this.btnSetIsNotGeneCode.Text = "设置不生成代码";
            this.btnSetIsNotGeneCode.Click += new System.EventHandler(this.btnSetIsNotGeneCode_Click);
            // 
            // btnCheckPrjFileState
            // 
            this.btnCheckPrjFileState.Location = new System.Drawing.Point(607, 3);
            this.btnCheckPrjFileState.Name = "btnCheckPrjFileState";
            this.btnCheckPrjFileState.Size = new System.Drawing.Size(130, 26);
            this.btnCheckPrjFileState.TabIndex = 26;
            this.btnCheckPrjFileState.Text = "检查工程文件状态";
            this.btnCheckPrjFileState.Click += new System.EventHandler(this.btnCheckPrjFileState_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblCodePrjMainPath);
            this.flowLayoutPanel1.Controls.Add(this.lblCodePath);
            this.flowLayoutPanel1.Controls.Add(this.lblCodePathBackup);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 130);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1096, 184);
            this.flowLayoutPanel1.TabIndex = 23;
            // 
            // lblCodePrjMainPath
            // 
            this.lblCodePrjMainPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCodePrjMainPath.Location = new System.Drawing.Point(3, 3);
            this.lblCodePrjMainPath.Name = "lblCodePrjMainPath";
            this.lblCodePrjMainPath.Size = new System.Drawing.Size(1088, 122);
            this.lblCodePrjMainPath.TabIndex = 23;
            this.lblCodePrjMainPath.Text = "";
            // 
            // lblCodePath
            // 
            this.lblCodePath.Location = new System.Drawing.Point(3, 131);
            this.lblCodePath.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblCodePath.Name = "lblCodePath";
            this.lblCodePath.Size = new System.Drawing.Size(1081, 23);
            this.lblCodePath.TabIndex = 19;
            this.lblCodePath.Text = "当前目录";
            // 
            // lblCodePathBackup
            // 
            this.lblCodePathBackup.Location = new System.Drawing.Point(3, 157);
            this.lblCodePathBackup.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblCodePathBackup.Name = "lblCodePathBackup";
            this.lblCodePathBackup.Size = new System.Drawing.Size(1081, 23);
            this.lblCodePathBackup.TabIndex = 22;
            this.lblCodePathBackup.Text = "备份目录";
            // 
            // btnCreateBakDir
            // 
            this.btnCreateBakDir.Location = new System.Drawing.Point(1108, 289);
            this.btnCreateBakDir.Name = "btnCreateBakDir";
            this.btnCreateBakDir.Size = new System.Drawing.Size(130, 26);
            this.btnCreateBakDir.TabIndex = 21;
            this.btnCreateBakDir.Text = "建立备份目录";
            this.btnCreateBakDir.Click += new System.EventHandler(this.btnCreateBakDir_Click);
            // 
            // btnCreateDir
            // 
            this.btnCreateDir.Location = new System.Drawing.Point(1108, 257);
            this.btnCreateDir.Name = "btnCreateDir";
            this.btnCreateDir.Size = new System.Drawing.Size(130, 26);
            this.btnCreateDir.TabIndex = 20;
            this.btnCreateDir.Text = "建立生成目录";
            this.btnCreateDir.Click += new System.EventHandler(this.btnCreateDir_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 13;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.chkDIskBackup, 12, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnExportExcel4Dg, 10, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSetMainPath, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboUserCodePrjMainPathId, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnQuery, 11, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboPrjId, 10, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPrjId, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.chkEditTemplate, 12, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCopyTemplateSet, 8, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboIsGeneCode, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboCodeTypeId, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCodeTypeId, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboCmPrjAppId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboProgLangTypeId, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1220, 65);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // chkDIskBackup
            // 
            this.chkDIskBackup.AutoSize = true;
            this.chkDIskBackup.Location = new System.Drawing.Point(1020, 35);
            this.chkDIskBackup.Name = "chkDIskBackup";
            this.chkDIskBackup.Size = new System.Drawing.Size(110, 18);
            this.chkDIskBackup.TabIndex = 18;
            this.chkDIskBackup.Text = "显示备份信息";
            this.chkDIskBackup.UseVisualStyleBackColor = true;
            // 
            // btnSetMainPath
            // 
            this.btnSetMainPath.Location = new System.Drawing.Point(652, 3);
            this.btnSetMainPath.Name = "btnSetMainPath";
            this.btnSetMainPath.Size = new System.Drawing.Size(96, 26);
            this.btnSetMainPath.TabIndex = 18;
            this.btnSetMainPath.Text = "设置主目录";
            this.btnSetMainPath.Click += new System.EventHandler(this.btnSetMainPath_Click);
            // 
            // cboUserCodePrjMainPathId
            // 
            this.cboUserCodePrjMainPathId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUserCodePrjMainPathId.Location = new System.Drawing.Point(485, 3);
            this.cboUserCodePrjMainPathId.Name = "cboUserCodePrjMainPathId";
            this.cboUserCodePrjMainPathId.Size = new System.Drawing.Size(161, 22);
            this.cboUserCodePrjMainPathId.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(398, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "主应用目录";
            // 
            // chkEditTemplate
            // 
            this.chkEditTemplate.AutoSize = true;
            this.chkEditTemplate.Location = new System.Drawing.Point(1020, 3);
            this.chkEditTemplate.Name = "chkEditTemplate";
            this.chkEditTemplate.Size = new System.Drawing.Size(82, 18);
            this.chkEditTemplate.TabIndex = 17;
            this.chkEditTemplate.Text = "编辑模板";
            this.chkEditTemplate.UseVisualStyleBackColor = true;
            this.chkEditTemplate.CheckedChanged += new System.EventHandler(this.chkEditTemplate_CheckedChanged);
            // 
            // btnCopyTemplateSet
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnCopyTemplateSet, 2);
            this.btnCopyTemplateSet.Location = new System.Drawing.Point(754, 35);
            this.btnCopyTemplateSet.Name = "btnCopyTemplateSet";
            this.btnCopyTemplateSet.Size = new System.Drawing.Size(118, 26);
            this.btnCopyTemplateSet.TabIndex = 17;
            this.btnCopyTemplateSet.Text = "复制模板设置";
            this.btnCopyTemplateSet.Click += new System.EventHandler(this.btnCopyTemplateSet_Click);
            // 
            // cboIsGeneCode
            // 
            this.cboIsGeneCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIsGeneCode.Location = new System.Drawing.Point(485, 35);
            this.cboIsGeneCode.Name = "cboIsGeneCode";
            this.cboIsGeneCode.Size = new System.Drawing.Size(130, 22);
            this.cboIsGeneCode.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(398, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "生成代码?";
            // 
            // cboCmPrjAppId
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cboCmPrjAppId, 3);
            this.cboCmPrjAppId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCmPrjAppId.Location = new System.Drawing.Point(92, 3);
            this.cboCmPrjAppId.Name = "cboCmPrjAppId";
            this.cboCmPrjAppId.Size = new System.Drawing.Size(300, 22);
            this.cboCmPrjAppId.TabIndex = 29;
            // 
            // cboProgLangTypeId
            // 
            this.cboProgLangTypeId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProgLangTypeId.Location = new System.Drawing.Point(92, 35);
            this.cboProgLangTypeId.Name = "cboProgLangTypeId";
            this.cboProgLangTypeId.Size = new System.Drawing.Size(83, 22);
            this.cboProgLangTypeId.TabIndex = 18;
            this.cboProgLangTypeId.SelectedIndexChanged += new System.EventHandler(this.cboProgLangTypeId_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 28;
            this.label5.Text = "CM工程应用";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "语言";
            // 
            // frmUserCodePath_QD_LV
            // 
            this.ClientSize = new System.Drawing.Size(1344, 816);
            this.Controls.Add(this.lvvUserCodePath);
            this.Controls.Add(this.gbQueryCondition);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "frmUserCodePath_QD_LV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUserCodePath_QD_LV";
            this.Load += new System.EventHandler(this.frmUserCodePath_QD_Load);
            this.gbQueryCondition.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Label lblPrjId;
        private System.Windows.Forms.ComboBox cboPrjId;
        private System.Windows.Forms.Label lblCodeTypeId;
        private System.Windows.Forms.ComboBox cboCodeTypeId;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelRec;
        private System.Windows.Forms.Button btnExportExcel4Dg;
        private System.Windows.Forms.Label lblRecNum;
        private System.Windows.Forms.GroupBox gbQueryCondition;
        private System.Windows.Forms.ListView lvvUserCodePath;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCopyRec;
        private System.Windows.Forms.ComboBox cboUserCodePrjMainPathId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkEditTemplate;
        private System.Windows.Forms.Button btnCopyTemplateSet;
        private System.Windows.Forms.Button btnSetMainPath;
        private System.Windows.Forms.ComboBox cboProgLangTypeId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkDIskBackup;
        private System.Windows.Forms.Label lblCodePath;
        private System.Windows.Forms.Button btnCreateBakDir;
        private System.Windows.Forms.Button btnCreateDir;
        private System.Windows.Forms.Label lblCodePathBackup;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RichTextBox lblCodePrjMainPath;
        public System.Windows.Forms.ComboBox cboIsGeneCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSetIsGeneCode;
        private System.Windows.Forms.Button btnSetIsNotGeneCode;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnCheckPrjFileState;
        private System.Windows.Forms.ComboBox cboCmPrjAppId;
        private System.Windows.Forms.Label label5;
    }
}