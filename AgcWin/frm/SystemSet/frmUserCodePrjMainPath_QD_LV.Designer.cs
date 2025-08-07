
namespace AGC
{
    /// <summary>
    ///		frmUserCodePrjMainPath_QD_LV 的摘要说明。
    /// </summary>
    partial class frmUserCodePrjMainPath_QD_LV
    {

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
            this.components = new System.ComponentModel.Container();
            this.lblUserId = new System.Windows.Forms.Label();
            this.cboUserId = new System.Windows.Forms.ComboBox();
            this.lblPrjId = new System.Windows.Forms.Label();
            this.cboPrjId = new System.Windows.Forms.ComboBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelRec = new System.Windows.Forms.Button();
            this.btnExportExcel4Dg = new System.Windows.Forms.Button();
            this.lblRecNum = new System.Windows.Forms.Label();
            this.gbQueryCondition = new System.Windows.Forms.GroupBox();
            this.chkDIskAllCmPrjApp = new System.Windows.Forms.CheckBox();
            this.lblMachineName = new System.Windows.Forms.Label();
            this.btnCopyFromOtherPC = new System.Windows.Forms.Button();
            this.chkDIskBackup = new System.Windows.Forms.CheckBox();
            this.btnCopyTemplateSet = new System.Windows.Forms.Button();
            this.btnCopyRec = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cboCmPrjId = new System.Windows.Forms.ComboBox();
            this.cboApplicationTypeId = new System.Windows.Forms.ComboBox();
            this.chkEditTemplate = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboProgLangTypeId = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvUserCodePrjMainPath = new System.Windows.Forms.DataGridView();
            this.dgvcUserCodePrjMainPathId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcAppOrderNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcCMPrjName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcApplicationTypeSimName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcInUse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcCodePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcIsExistCodePathEx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcLogPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcIsTemplate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcUpdDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcUpdUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcMemo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcCMProjectAppRelaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcIncludeXmlPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.使用ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.不使用ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbQueryCondition.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserCodePrjMainPath)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUserId
            // 
            this.lblUserId.Location = new System.Drawing.Point(605, 0);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(51, 18);
            this.lblUserId.TabIndex = 1;
            this.lblUserId.Text = "用户";
            // 
            // cboUserId
            // 
            this.cboUserId.Location = new System.Drawing.Point(662, 3);
            this.cboUserId.Name = "cboUserId";
            this.cboUserId.Size = new System.Drawing.Size(104, 22);
            this.cboUserId.TabIndex = 2;
            // 
            // lblPrjId
            // 
            this.lblPrjId.Location = new System.Drawing.Point(772, 0);
            this.lblPrjId.Name = "lblPrjId";
            this.lblPrjId.Size = new System.Drawing.Size(36, 18);
            this.lblPrjId.TabIndex = 3;
            this.lblPrjId.Text = "工程ID";
            // 
            // cboPrjId
            // 
            this.cboPrjId.Location = new System.Drawing.Point(814, 3);
            this.cboPrjId.Name = "cboPrjId";
            this.cboPrjId.Size = new System.Drawing.Size(78, 22);
            this.cboPrjId.TabIndex = 4;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(898, 3);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(49, 26);
            this.btnQuery.TabIndex = 12;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.Location = new System.Drawing.Point(166, 72);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(128, 16);
            this.lblMsg.TabIndex = 7;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(518, 65);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(58, 26);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(306, 66);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(51, 26);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "添加";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelRec
            // 
            this.btnDelRec.Location = new System.Drawing.Point(576, 65);
            this.btnDelRec.Name = "btnDelRec";
            this.btnDelRec.Size = new System.Drawing.Size(80, 26);
            this.btnDelRec.TabIndex = 10;
            this.btnDelRec.Text = "删除记录";
            this.btnDelRec.Click += new System.EventHandler(this.btnDelRec_Click);
            // 
            // btnExportExcel4Dg
            // 
            this.btnExportExcel4Dg.Location = new System.Drawing.Point(664, 65);
            this.btnExportExcel4Dg.Name = "btnExportExcel4Dg";
            this.btnExportExcel4Dg.Size = new System.Drawing.Size(80, 26);
            this.btnExportExcel4Dg.TabIndex = 11;
            this.btnExportExcel4Dg.Text = "导出Excel";
            this.btnExportExcel4Dg.Click += new System.EventHandler(this.btnExportExcel4Dg_Click);
            // 
            // lblRecNum
            // 
            this.lblRecNum.Location = new System.Drawing.Point(752, 72);
            this.lblRecNum.Name = "lblRecNum";
            this.lblRecNum.Size = new System.Drawing.Size(112, 16);
            this.lblRecNum.TabIndex = 13;
            this.lblRecNum.Text = "记录数：";
            // 
            // gbQueryCondition
            // 
            this.gbQueryCondition.Controls.Add(this.chkDIskAllCmPrjApp);
            this.gbQueryCondition.Controls.Add(this.lblMachineName);
            this.gbQueryCondition.Controls.Add(this.btnCopyFromOtherPC);
            this.gbQueryCondition.Controls.Add(this.chkDIskBackup);
            this.gbQueryCondition.Controls.Add(this.btnCopyTemplateSet);
            this.gbQueryCondition.Controls.Add(this.btnCopyRec);
            this.gbQueryCondition.Controls.Add(this.tableLayoutPanel1);
            this.gbQueryCondition.Controls.Add(this.btnExportExcel4Dg);
            this.gbQueryCondition.Controls.Add(this.btnUpdate);
            this.gbQueryCondition.Controls.Add(this.btnAdd);
            this.gbQueryCondition.Controls.Add(this.btnDelRec);
            this.gbQueryCondition.Controls.Add(this.lblMsg);
            this.gbQueryCondition.Controls.Add(this.lblRecNum);
            this.gbQueryCondition.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbQueryCondition.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbQueryCondition.Location = new System.Drawing.Point(0, 0);
            this.gbQueryCondition.Name = "gbQueryCondition";
            this.gbQueryCondition.Size = new System.Drawing.Size(1463, 114);
            this.gbQueryCondition.TabIndex = 15;
            this.gbQueryCondition.TabStop = false;
            this.gbQueryCondition.Text = "查询条件";
            // 
            // chkDIskAllCmPrjApp
            // 
            this.chkDIskAllCmPrjApp.AutoSize = true;
            this.chkDIskAllCmPrjApp.Location = new System.Drawing.Point(1121, 65);
            this.chkDIskAllCmPrjApp.Name = "chkDIskAllCmPrjApp";
            this.chkDIskAllCmPrjApp.Size = new System.Drawing.Size(152, 18);
            this.chkDIskAllCmPrjApp.TabIndex = 22;
            this.chkDIskAllCmPrjApp.Text = "显示所有Cm工程应用";
            this.chkDIskAllCmPrjApp.UseVisualStyleBackColor = true;
            // 
            // lblMachineName
            // 
            this.lblMachineName.Location = new System.Drawing.Point(15, 74);
            this.lblMachineName.Name = "lblMachineName";
            this.lblMachineName.Size = new System.Drawing.Size(285, 18);
            this.lblMachineName.TabIndex = 21;
            this.lblMachineName.Text = "机器名";
            // 
            // btnCopyFromOtherPC
            // 
            this.btnCopyFromOtherPC.Location = new System.Drawing.Point(410, 66);
            this.btnCopyFromOtherPC.Name = "btnCopyFromOtherPC";
            this.btnCopyFromOtherPC.Size = new System.Drawing.Size(102, 26);
            this.btnCopyFromOtherPC.TabIndex = 20;
            this.btnCopyFromOtherPC.Text = "从其他PC复制";
            this.btnCopyFromOtherPC.Click += new System.EventHandler(this.btnCopyFromOtherPC_Click);
            // 
            // chkDIskBackup
            // 
            this.chkDIskBackup.AutoSize = true;
            this.chkDIskBackup.Location = new System.Drawing.Point(1005, 65);
            this.chkDIskBackup.Name = "chkDIskBackup";
            this.chkDIskBackup.Size = new System.Drawing.Size(110, 18);
            this.chkDIskBackup.TabIndex = 19;
            this.chkDIskBackup.Text = "显示备份信息";
            this.chkDIskBackup.UseVisualStyleBackColor = true;
            // 
            // btnCopyTemplateSet
            // 
            this.btnCopyTemplateSet.Enabled = false;
            this.btnCopyTemplateSet.Location = new System.Drawing.Point(881, 65);
            this.btnCopyTemplateSet.Name = "btnCopyTemplateSet";
            this.btnCopyTemplateSet.Size = new System.Drawing.Size(118, 26);
            this.btnCopyTemplateSet.TabIndex = 16;
            this.btnCopyTemplateSet.Text = "复制模板设置";
            this.btnCopyTemplateSet.Click += new System.EventHandler(this.btnCopyTemplateSet_Click);
            // 
            // btnCopyRec
            // 
            this.btnCopyRec.Location = new System.Drawing.Point(359, 66);
            this.btnCopyRec.Name = "btnCopyRec";
            this.btnCopyRec.Size = new System.Drawing.Size(47, 26);
            this.btnCopyRec.TabIndex = 15;
            this.btnCopyRec.Text = "复制";
            this.btnCopyRec.Click += new System.EventHandler(this.btnCopyRec_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 12;
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
            this.tableLayoutPanel1.Controls.Add(this.cboCmPrjId, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboApplicationTypeId, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.chkEditTemplate, 11, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnQuery, 10, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboPrjId, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPrjId, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboUserId, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblUserId, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboProgLangTypeId, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1141, 32);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // cboCmPrjId
            // 
            this.cboCmPrjId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCmPrjId.Location = new System.Drawing.Point(65, 3);
            this.cboCmPrjId.Name = "cboCmPrjId";
            this.cboCmPrjId.Size = new System.Drawing.Size(138, 22);
            this.cboCmPrjId.TabIndex = 30;
            // 
            // cboApplicationTypeId
            // 
            this.cboApplicationTypeId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboApplicationTypeId.Location = new System.Drawing.Point(470, 3);
            this.cboApplicationTypeId.Name = "cboApplicationTypeId";
            this.cboApplicationTypeId.Size = new System.Drawing.Size(129, 22);
            this.cboApplicationTypeId.TabIndex = 23;
            // 
            // chkEditTemplate
            // 
            this.chkEditTemplate.AutoSize = true;
            this.chkEditTemplate.Location = new System.Drawing.Point(953, 3);
            this.chkEditTemplate.Name = "chkEditTemplate";
            this.chkEditTemplate.Size = new System.Drawing.Size(82, 18);
            this.chkEditTemplate.TabIndex = 18;
            this.chkEditTemplate.Text = "编辑模板";
            this.chkEditTemplate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(209, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "语言";
            // 
            // cboProgLangTypeId
            // 
            this.cboProgLangTypeId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProgLangTypeId.Location = new System.Drawing.Point(259, 3);
            this.cboProgLangTypeId.Name = "cboProgLangTypeId";
            this.cboProgLangTypeId.Size = new System.Drawing.Size(130, 22);
            this.cboProgLangTypeId.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(395, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "应用类型";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 18);
            this.label5.TabIndex = 29;
            this.label5.Text = "CM工程";
            // 
            // dgvUserCodePrjMainPath
            // 
            this.dgvUserCodePrjMainPath.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUserCodePrjMainPath.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUserCodePrjMainPath.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserCodePrjMainPath.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcUserCodePrjMainPathId,
            this.dgvcAppOrderNum,
            this.dgvcCMPrjName,
            this.dgvcApplicationTypeSimName,
            this.dgvcInUse,
            this.dgvcCodePath,
            this.dgvcIsExistCodePathEx,
            this.dgvcLogPath,
            this.dgvcIsTemplate,
            this.dgvcUpdDate,
            this.dgvcUpdUserId,
            this.dgvcMemo,
            this.dgvcCMProjectAppRelaId,
            this.dgvcIncludeXmlPath});
            this.dgvUserCodePrjMainPath.Location = new System.Drawing.Point(0, 129);
            this.dgvUserCodePrjMainPath.Name = "dgvUserCodePrjMainPath";
            this.dgvUserCodePrjMainPath.Size = new System.Drawing.Size(1463, 624);
            this.dgvUserCodePrjMainPath.TabIndex = 19;
            this.dgvUserCodePrjMainPath.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserCodePrjMainPath_CellClick);
            this.dgvUserCodePrjMainPath.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUserCodePrjMainPath_CellMouseClick);
            this.dgvUserCodePrjMainPath.Click += new System.EventHandler(this.dgvUserCodePrjMainPath_Click);
            // 
            // dgvcUserCodePrjMainPathId
            // 
            this.dgvcUserCodePrjMainPathId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvcUserCodePrjMainPathId.DataPropertyName = "UserCodePrjMainPathId";
            this.dgvcUserCodePrjMainPathId.FillWeight = 1.828378F;
            this.dgvcUserCodePrjMainPathId.Frozen = true;
            this.dgvcUserCodePrjMainPathId.HeaderText = "Id";
            this.dgvcUserCodePrjMainPathId.Name = "dgvcUserCodePrjMainPathId";
            this.dgvcUserCodePrjMainPathId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcUserCodePrjMainPathId.Width = 5;
            // 
            // dgvcAppOrderNum
            // 
            this.dgvcAppOrderNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvcAppOrderNum.DataPropertyName = "AppOrderNum";
            this.dgvcAppOrderNum.FillWeight = 6.382701F;
            this.dgvcAppOrderNum.Frozen = true;
            this.dgvcAppOrderNum.HeaderText = "序号";
            this.dgvcAppOrderNum.Name = "dgvcAppOrderNum";
            this.dgvcAppOrderNum.Width = 40;
            // 
            // dgvcCMPrjName
            // 
            this.dgvcCMPrjName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvcCMPrjName.DataPropertyName = "CMPrjName";
            this.dgvcCMPrjName.FillWeight = 6.382701F;
            this.dgvcCMPrjName.Frozen = true;
            this.dgvcCMPrjName.HeaderText = "CM工程";
            this.dgvcCMPrjName.Name = "dgvcCMPrjName";
            // 
            // dgvcApplicationTypeSimName
            // 
            this.dgvcApplicationTypeSimName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvcApplicationTypeSimName.DataPropertyName = "ApplicationTypeSimName";
            this.dgvcApplicationTypeSimName.FillWeight = 6.382701F;
            this.dgvcApplicationTypeSimName.Frozen = true;
            this.dgvcApplicationTypeSimName.HeaderText = "应用类型";
            this.dgvcApplicationTypeSimName.Name = "dgvcApplicationTypeSimName";
            // 
            // dgvcInUse
            // 
            this.dgvcInUse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvcInUse.DataPropertyName = "InUseEx";
            this.dgvcInUse.FillWeight = 6.382701F;
            this.dgvcInUse.Frozen = true;
            this.dgvcInUse.HeaderText = "在用?";
            this.dgvcInUse.Name = "dgvcInUse";
            this.dgvcInUse.Width = 50;
            // 
            // dgvcCodePath
            // 
            this.dgvcCodePath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvcCodePath.DataPropertyName = "CodePathEx";
            this.dgvcCodePath.FillWeight = 663.1076F;
            this.dgvcCodePath.Frozen = true;
            this.dgvcCodePath.HeaderText = "代码路径";
            this.dgvcCodePath.Name = "dgvcCodePath";
            this.dgvcCodePath.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcCodePath.Width = 400;
            // 
            // dgvcIsExistCodePathEx
            // 
            this.dgvcIsExistCodePathEx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvcIsExistCodePathEx.DataPropertyName = "IsExistCodePathEx";
            this.dgvcIsExistCodePathEx.FillWeight = 66.75708F;
            this.dgvcIsExistCodePathEx.Frozen = true;
            this.dgvcIsExistCodePathEx.HeaderText = "存在?";
            this.dgvcIsExistCodePathEx.Name = "dgvcIsExistCodePathEx";
            this.dgvcIsExistCodePathEx.Width = 50;
            // 
            // dgvcLogPath
            // 
            this.dgvcLogPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvcLogPath.DataPropertyName = "LogPathEx";
            this.dgvcLogPath.FillWeight = 517.1848F;
            this.dgvcLogPath.Frozen = true;
            this.dgvcLogPath.HeaderText = "日志路径";
            this.dgvcLogPath.Name = "dgvcLogPath";
            this.dgvcLogPath.Width = 350;
            // 
            // dgvcIsTemplate
            // 
            this.dgvcIsTemplate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvcIsTemplate.DataPropertyName = "IsTemplate";
            this.dgvcIsTemplate.FillWeight = 6.382701F;
            this.dgvcIsTemplate.Frozen = true;
            this.dgvcIsTemplate.HeaderText = "模板?";
            this.dgvcIsTemplate.Name = "dgvcIsTemplate";
            this.dgvcIsTemplate.Width = 50;
            // 
            // dgvcUpdDate
            // 
            this.dgvcUpdDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvcUpdDate.DataPropertyName = "UpdDate";
            this.dgvcUpdDate.FillWeight = 6.382701F;
            this.dgvcUpdDate.Frozen = true;
            this.dgvcUpdDate.HeaderText = "修改日期";
            this.dgvcUpdDate.Name = "dgvcUpdDate";
            this.dgvcUpdDate.Width = 70;
            // 
            // dgvcUpdUserId
            // 
            this.dgvcUpdUserId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvcUpdUserId.DataPropertyName = "UpdUserId";
            this.dgvcUpdUserId.FillWeight = 6.382701F;
            this.dgvcUpdUserId.Frozen = true;
            this.dgvcUpdUserId.HeaderText = "修改用户";
            this.dgvcUpdUserId.Name = "dgvcUpdUserId";
            this.dgvcUpdUserId.Width = 60;
            // 
            // dgvcMemo
            // 
            this.dgvcMemo.DataPropertyName = "Memo";
            this.dgvcMemo.FillWeight = 6.382701F;
            this.dgvcMemo.HeaderText = "说明";
            this.dgvcMemo.Name = "dgvcMemo";
            // 
            // dgvcCMProjectAppRelaId
            // 
            this.dgvcCMProjectAppRelaId.DataPropertyName = "CMProjectAppRelaId";
            this.dgvcCMProjectAppRelaId.FillWeight = 6.382701F;
            this.dgvcCMProjectAppRelaId.HeaderText = "关系Id";
            this.dgvcCMProjectAppRelaId.Name = "dgvcCMProjectAppRelaId";
            // 
            // dgvcIncludeXmlPath
            // 
            this.dgvcIncludeXmlPath.DataPropertyName = "IncludeXmlPath";
            this.dgvcIncludeXmlPath.FillWeight = 6.382701F;
            this.dgvcIncludeXmlPath.HeaderText = "包含表Xml文件路径";
            this.dgvcIncludeXmlPath.Name = "dgvcIncludeXmlPath";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.使用ToolStripMenuItem,
            this.不使用ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 48);
            // 
            // 使用ToolStripMenuItem
            // 
            this.使用ToolStripMenuItem.Name = "使用ToolStripMenuItem";
            this.使用ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.使用ToolStripMenuItem.Text = "使用";
            this.使用ToolStripMenuItem.Click += new System.EventHandler(this.使用ToolStripMenuItem_Click);
            // 
            // 不使用ToolStripMenuItem
            // 
            this.不使用ToolStripMenuItem.Name = "不使用ToolStripMenuItem";
            this.不使用ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.不使用ToolStripMenuItem.Text = "不使用";
            // 
            // frmUserCodePrjMainPath_QD_LV
            // 
            this.ClientSize = new System.Drawing.Size(1463, 751);
            this.Controls.Add(this.dgvUserCodePrjMainPath);
            this.Controls.Add(this.gbQueryCondition);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "frmUserCodePrjMainPath_QD_LV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户代码生成主路径设置";
            this.Load += new System.EventHandler(this.frmUserCodePrjMainPath_QD_Load);
            this.gbQueryCondition.ResumeLayout(false);
            this.gbQueryCondition.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserCodePrjMainPath)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.ComboBox cboUserId;
        private System.Windows.Forms.Label lblPrjId;
        private System.Windows.Forms.ComboBox cboPrjId;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelRec;
        private System.Windows.Forms.Button btnExportExcel4Dg;
        private System.Windows.Forms.Label lblRecNum;
        private System.Windows.Forms.GroupBox gbQueryCondition;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCopyRec;
        private System.Windows.Forms.ComboBox cboProgLangTypeId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCopyTemplateSet;
        private System.Windows.Forms.CheckBox chkEditTemplate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboApplicationTypeId;
        private System.Windows.Forms.CheckBox chkDIskBackup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboCmPrjId;
        private System.Windows.Forms.Button btnCopyFromOtherPC;
        private System.Windows.Forms.Label lblMachineName;
        private System.Windows.Forms.DataGridView dgvUserCodePrjMainPath;
        private System.Windows.Forms.CheckBox chkDIskAllCmPrjApp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcUserCodePrjMainPathId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcAppOrderNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcCMPrjName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcApplicationTypeSimName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcInUse;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcCodePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcIsExistCodePathEx;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcLogPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcIsTemplate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcUpdDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcUpdUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcMemo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcCMProjectAppRelaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcIncludeXmlPath;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 使用ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 不使用ToolStripMenuItem;
        private System.ComponentModel.IContainer components;
    }
}