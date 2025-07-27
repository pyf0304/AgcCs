
namespace AGC
{
    /// <summary>
    ///		frmWebSrvClass_QD_LV 的摘要说明。
    /// </summary>
    partial class frmWebSrvClass_GeneCode
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
            this.lblClassName = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.lblObjId = new System.Windows.Forms.Label();
            this.cboFuncModuleId = new System.Windows.Forms.ComboBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnExportExcel4Dg = new System.Windows.Forms.Button();
            this.lblRecNum = new System.Windows.Forms.Label();
            this.lvvWebSrvClass = new System.Windows.Forms.ListView();
            this.gbQueryCondition = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboAppPageTypeId = new System.Windows.Forms.ComboBox();
            this.rblProgLangTypeId = new TzWinCtrlLib.TzRadioButtonList();
            this.btnGeneAllCheckedTableThreeLayer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblErrNum = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.flpClassNameButtonList = new System.Windows.Forms.FlowLayoutPanel();
            this.btnWebServiceCode = new System.Windows.Forms.Button();
            this.btnWS_Access = new System.Windows.Forms.Button();
            this.btnWS_AccessHigh = new System.Windows.Forms.Button();
            this.btnAppController = new System.Windows.Forms.Button();
            this.btnAppViewUnitTest = new System.Windows.Forms.Button();
            this.btnAppViewUTScript = new System.Windows.Forms.Button();
            this.btnAppViewUTScriptCS = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.rbMsSql = new System.Windows.Forms.RadioButton();
            this.rbOracle = new System.Windows.Forms.RadioButton();
            this.rbMySql = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCharEncodingId = new System.Windows.Forms.ComboBox();
            this.btnClearCache = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtFileName4GenCode = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtCodePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbQueryCondition.SuspendLayout();
            this.flpClassNameButtonList.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClassName
            // 
            this.lblClassName.Location = new System.Drawing.Point(3, 0);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(36, 18);
            this.lblClassName.TabIndex = 1;
            this.lblClassName.Text = "类名";
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(45, 3);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(187, 23);
            this.txtClassName.TabIndex = 2;
            // 
            // lblObjId
            // 
            this.lblObjId.Location = new System.Drawing.Point(238, 0);
            this.lblObjId.Name = "lblObjId";
            this.lblObjId.Size = new System.Drawing.Size(36, 18);
            this.lblObjId.TabIndex = 5;
            this.lblObjId.Text = "模块";
            // 
            // cboFuncModuleId
            // 
            this.cboFuncModuleId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFuncModuleId.Location = new System.Drawing.Point(280, 3);
            this.cboFuncModuleId.Name = "cboFuncModuleId";
            this.cboFuncModuleId.Size = new System.Drawing.Size(215, 22);
            this.cboFuncModuleId.TabIndex = 6;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(501, 3);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(63, 26);
            this.btnQuery.TabIndex = 16;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.Location = new System.Drawing.Point(751, 0);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(373, 41);
            this.lblMsg.TabIndex = 11;
            // 
            // btnExportExcel4Dg
            // 
            this.btnExportExcel4Dg.Location = new System.Drawing.Point(570, 3);
            this.btnExportExcel4Dg.Name = "btnExportExcel4Dg";
            this.btnExportExcel4Dg.Size = new System.Drawing.Size(80, 25);
            this.btnExportExcel4Dg.TabIndex = 15;
            this.btnExportExcel4Dg.Text = "导出Excel";
            this.btnExportExcel4Dg.Click += new System.EventHandler(this.btnExportExcel4Dg_Click);
            // 
            // lblRecNum
            // 
            this.lblRecNum.Location = new System.Drawing.Point(656, 0);
            this.lblRecNum.Name = "lblRecNum";
            this.lblRecNum.Size = new System.Drawing.Size(89, 16);
            this.lblRecNum.TabIndex = 17;
            this.lblRecNum.Text = "记录数：";
            // 
            // lvvWebSrvClass
            // 
            this.lvvWebSrvClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvvWebSrvClass.FullRowSelect = true;
            this.lvvWebSrvClass.Location = new System.Drawing.Point(3, 3);
            this.lvvWebSrvClass.Name = "lvvWebSrvClass";
            this.lvvWebSrvClass.Size = new System.Drawing.Size(1174, 455);
            this.lvvWebSrvClass.TabIndex = 18;
            this.lvvWebSrvClass.UseCompatibleStateImageBehavior = false;
            this.lvvWebSrvClass.View = System.Windows.Forms.View.Details;
            this.lvvWebSrvClass.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvvWebSrvClass_ColumnClick);
            this.lvvWebSrvClass.SelectedIndexChanged += new System.EventHandler(this.lvvWebSrvClass_SelectedIndexChanged);
            this.lvvWebSrvClass.Click += new System.EventHandler(this.lvvWebSrvClass_Click);
            // 
            // gbQueryCondition
            // 
            this.gbQueryCondition.Controls.Add(this.label5);
            this.gbQueryCondition.Controls.Add(this.cboAppPageTypeId);
            this.gbQueryCondition.Controls.Add(this.rblProgLangTypeId);
            this.gbQueryCondition.Controls.Add(this.label4);
            this.gbQueryCondition.Controls.Add(this.lblStatus);
            this.gbQueryCondition.Controls.Add(this.lblErrNum);
            this.gbQueryCondition.Controls.Add(this.progressBar1);
            this.gbQueryCondition.Controls.Add(this.flpClassNameButtonList);
            this.gbQueryCondition.Controls.Add(this.flowLayoutPanel2);
            this.gbQueryCondition.Controls.Add(this.label3);
            this.gbQueryCondition.Controls.Add(this.cboCharEncodingId);
            this.gbQueryCondition.Controls.Add(this.btnClearCache);
            this.gbQueryCondition.Controls.Add(this.tableLayoutPanel1);
            this.gbQueryCondition.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbQueryCondition.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbQueryCondition.Location = new System.Drawing.Point(0, 0);
            this.gbQueryCondition.Name = "gbQueryCondition";
            this.gbQueryCondition.Size = new System.Drawing.Size(1200, 200);
            this.gbQueryCondition.TabIndex = 19;
            this.gbQueryCondition.TabStop = false;
            this.gbQueryCondition.Text = "查询条件";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(926, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 50;
            this.label5.Text = "界面类型:";
            // 
            // cboAppPageTypeId
            // 
            this.cboAppPageTypeId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAppPageTypeId.Location = new System.Drawing.Point(997, 157);
            this.cboAppPageTypeId.Name = "cboAppPageTypeId";
            this.cboAppPageTypeId.Size = new System.Drawing.Size(98, 22);
            this.cboAppPageTypeId.TabIndex = 49;
            // 
            // rblProgLangTypeId
            // 
            this.rblProgLangTypeId.DataSource = null;
            this.rblProgLangTypeId.DisplayMember = null;
            this.rblProgLangTypeId.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.rblProgLangTypeId.Location = new System.Drawing.Point(8, 65);
            this.rblProgLangTypeId.Name = "rblProgLangTypeId";
            this.rblProgLangTypeId.Size = new System.Drawing.Size(511, 25);
            this.rblProgLangTypeId.TabIndex = 47;
            this.rblProgLangTypeId.Value = null;
            this.rblProgLangTypeId.ValueMember = null;
            this.rblProgLangTypeId.RadioItemSeleted += new TzWinCtrlLib.TzRadioButtonList.RadioSelectedHandler(this.rblProgLangTypeId_RadioItemSeleted);
            // 
            // btnGeneAllCheckedTableThreeLayer
            // 
            this.btnGeneAllCheckedTableThreeLayer.Location = new System.Drawing.Point(899, 3);
            this.btnGeneAllCheckedTableThreeLayer.Name = "btnGeneAllCheckedTableThreeLayer";
            this.btnGeneAllCheckedTableThreeLayer.Size = new System.Drawing.Size(137, 26);
            this.btnGeneAllCheckedTableThreeLayer.TabIndex = 25;
            this.btnGeneAllCheckedTableThreeLayer.Text = "生成所选类相关层";
            this.btnGeneAllCheckedTableThreeLayer.Click += new System.EventHandler(this.btnGeneAllCheckedTableThreeLayer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 14);
            this.label4.TabIndex = 45;
            this.label4.Text = "生成进度：";
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(332, 159);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(321, 18);
            this.lblStatus.TabIndex = 44;
            this.lblStatus.Text = "生成状态";
            // 
            // lblErrNum
            // 
            this.lblErrNum.Location = new System.Drawing.Point(673, 159);
            this.lblErrNum.Name = "lblErrNum";
            this.lblErrNum.Size = new System.Drawing.Size(123, 18);
            this.lblErrNum.TabIndex = 43;
            this.lblErrNum.Text = "出错数";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(90, 157);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(233, 23);
            this.progressBar1.TabIndex = 41;
            // 
            // flpClassNameButtonList
            // 
            this.flpClassNameButtonList.Controls.Add(this.btnWebServiceCode);
            this.flpClassNameButtonList.Controls.Add(this.btnWS_Access);
            this.flpClassNameButtonList.Controls.Add(this.btnWS_AccessHigh);
            this.flpClassNameButtonList.Controls.Add(this.btnAppController);
            this.flpClassNameButtonList.Controls.Add(this.btnAppViewUnitTest);
            this.flpClassNameButtonList.Controls.Add(this.btnAppViewUTScript);
            this.flpClassNameButtonList.Controls.Add(this.btnAppViewUTScriptCS);
            this.flpClassNameButtonList.Controls.Add(this.btnGeneAllCheckedTableThreeLayer);
            this.flpClassNameButtonList.Location = new System.Drawing.Point(8, 121);
            this.flpClassNameButtonList.Name = "flpClassNameButtonList";
            this.flpClassNameButtonList.Size = new System.Drawing.Size(1160, 28);
            this.flpClassNameButtonList.TabIndex = 39;
            // 
            // btnWebServiceCode
            // 
            this.btnWebServiceCode.Location = new System.Drawing.Point(3, 3);
            this.btnWebServiceCode.Name = "btnWebServiceCode";
            this.btnWebServiceCode.Size = new System.Drawing.Size(64, 26);
            this.btnWebServiceCode.TabIndex = 30;
            this.btnWebServiceCode.Text = "WEB服务";
            this.btnWebServiceCode.Click += new System.EventHandler(this.btnGenWebServiceCode_Click);
            // 
            // btnWS_Access
            // 
            this.btnWS_Access.Location = new System.Drawing.Point(73, 3);
            this.btnWS_Access.Name = "btnWS_Access";
            this.btnWS_Access.Size = new System.Drawing.Size(98, 26);
            this.btnWS_Access.TabIndex = 31;
            this.btnWS_Access.Text = "WEB服务访问";
            this.btnWS_Access.Click += new System.EventHandler(this.btnGenWS_Access_Click);
            // 
            // btnWS_AccessHigh
            // 
            this.btnWS_AccessHigh.Location = new System.Drawing.Point(177, 3);
            this.btnWS_AccessHigh.Name = "btnWS_AccessHigh";
            this.btnWS_AccessHigh.Size = new System.Drawing.Size(126, 26);
            this.btnWS_AccessHigh.TabIndex = 32;
            this.btnWS_AccessHigh.Text = "Web服务访问高层";
            this.btnWS_AccessHigh.UseVisualStyleBackColor = true;
            this.btnWS_AccessHigh.Click += new System.EventHandler(this.btnGeneWS_AccessHigh_Click);
            // 
            // btnAppController
            // 
            this.btnAppController.Location = new System.Drawing.Point(309, 3);
            this.btnAppController.Name = "btnAppController";
            this.btnAppController.Size = new System.Drawing.Size(99, 26);
            this.btnAppController.TabIndex = 33;
            this.btnAppController.Text = "App控制层";
            this.btnAppController.UseVisualStyleBackColor = true;
            this.btnAppController.Click += new System.EventHandler(this.btnGeneAppController_Click);
            // 
            // btnAppViewUnitTest
            // 
            this.btnAppViewUnitTest.Location = new System.Drawing.Point(414, 3);
            this.btnAppViewUnitTest.Name = "btnAppViewUnitTest";
            this.btnAppViewUnitTest.Size = new System.Drawing.Size(131, 26);
            this.btnAppViewUnitTest.TabIndex = 42;
            this.btnAppViewUnitTest.Text = "App界面单元测试";
            this.btnAppViewUnitTest.UseVisualStyleBackColor = true;
            this.btnAppViewUnitTest.Click += new System.EventHandler(this.btnAppViewUnitTest_Click);
            // 
            // btnAppViewUTScript
            // 
            this.btnAppViewUTScript.Location = new System.Drawing.Point(551, 3);
            this.btnAppViewUTScript.Name = "btnAppViewUTScript";
            this.btnAppViewUTScript.Size = new System.Drawing.Size(152, 26);
            this.btnAppViewUTScript.TabIndex = 43;
            this.btnAppViewUTScript.Text = "App界面单元测试脚本";
            this.btnAppViewUTScript.UseVisualStyleBackColor = true;
            this.btnAppViewUTScript.Click += new System.EventHandler(this.btnAppViewUTScript_Click);
            // 
            // btnAppViewUTScriptCS
            // 
            this.btnAppViewUTScriptCS.Location = new System.Drawing.Point(709, 3);
            this.btnAppViewUTScriptCS.Name = "btnAppViewUTScriptCS";
            this.btnAppViewUTScriptCS.Size = new System.Drawing.Size(184, 26);
            this.btnAppViewUTScriptCS.TabIndex = 44;
            this.btnAppViewUTScriptCS.Text = "App界面单元测试脚本后台";
            this.btnAppViewUTScriptCS.UseVisualStyleBackColor = true;
            this.btnAppViewUTScriptCS.Click += new System.EventHandler(this.btnAppViewUTScriptCS_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.rbMsSql);
            this.flowLayoutPanel2.Controls.Add(this.rbOracle);
            this.flowLayoutPanel2.Controls.Add(this.rbMySql);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(537, 63);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(220, 26);
            this.flowLayoutPanel2.TabIndex = 38;
            // 
            // rbMsSql
            // 
            this.rbMsSql.AutoSize = true;
            this.rbMsSql.Checked = true;
            this.rbMsSql.Location = new System.Drawing.Point(3, 3);
            this.rbMsSql.Name = "rbMsSql";
            this.rbMsSql.Size = new System.Drawing.Size(67, 18);
            this.rbMsSql.TabIndex = 0;
            this.rbMsSql.TabStop = true;
            this.rbMsSql.Text = "Ms Sql";
            this.rbMsSql.UseVisualStyleBackColor = true;
            this.rbMsSql.CheckedChanged += new System.EventHandler(this.rbMsSql_CheckedChanged);
            // 
            // rbOracle
            // 
            this.rbOracle.AutoSize = true;
            this.rbOracle.Location = new System.Drawing.Point(76, 3);
            this.rbOracle.Name = "rbOracle";
            this.rbOracle.Size = new System.Drawing.Size(67, 18);
            this.rbOracle.TabIndex = 1;
            this.rbOracle.Text = "Oracle";
            this.rbOracle.UseVisualStyleBackColor = true;
            this.rbOracle.CheckedChanged += new System.EventHandler(this.rbOracle_CheckedChanged);
            // 
            // rbMySql
            // 
            this.rbMySql.AutoSize = true;
            this.rbMySql.Location = new System.Drawing.Point(149, 3);
            this.rbMySql.Name = "rbMySql";
            this.rbMySql.Size = new System.Drawing.Size(60, 18);
            this.rbMySql.TabIndex = 2;
            this.rbMySql.Text = "MySql";
            this.rbMySql.UseVisualStyleBackColor = true;
            this.rbMySql.CheckedChanged += new System.EventHandler(this.rbMySql_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(5, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 18);
            this.label3.TabIndex = 34;
            this.label3.Text = "生成文件字符编码";
            // 
            // cboCharEncodingId
            // 
            this.cboCharEncodingId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCharEncodingId.Location = new System.Drawing.Point(134, 93);
            this.cboCharEncodingId.Name = "cboCharEncodingId";
            this.cboCharEncodingId.Size = new System.Drawing.Size(623, 22);
            this.cboCharEncodingId.TabIndex = 33;
            // 
            // btnClearCache
            // 
            this.btnClearCache.Location = new System.Drawing.Point(802, 155);
            this.btnClearCache.Name = "btnClearCache";
            this.btnClearCache.Size = new System.Drawing.Size(103, 26);
            this.btnClearCache.TabIndex = 29;
            this.btnClearCache.Text = "清除缓存";
            this.btnClearCache.Click += new System.EventHandler(this.btnClearCache_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lblClassName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtClassName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnExportExcel4Dg, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblObjId, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnQuery, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblRecNum, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboFuncModuleId, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMsg, 7, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1013, 41);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // txtCode
            // 
            this.txtCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCode.Location = new System.Drawing.Point(0, 0);
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCode.Size = new System.Drawing.Size(1174, 453);
            this.txtCode.TabIndex = 20;
            this.txtCode.Click += new System.EventHandler(this.txtCode_Click);
            // 
            // txtFileName4GenCode
            // 
            this.txtFileName4GenCode.Location = new System.Drawing.Point(73, 3);
            this.txtFileName4GenCode.Name = "txtFileName4GenCode";
            this.txtFileName4GenCode.Size = new System.Drawing.Size(194, 23);
            this.txtFileName4GenCode.TabIndex = 21;
            this.txtFileName4GenCode.Click += new System.EventHandler(this.txtFileName4GenCode_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 206);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1188, 489);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lvvWebSrvClass);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1180, 461);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "WebSrv类列表";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1180, 492);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "代码生成区";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtCodePath);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtFileName4GenCode);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtCode);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(1174, 486);
            this.splitContainer1.SplitterDistance = 29;
            this.splitContainer1.TabIndex = 21;
            // 
            // txtCodePath
            // 
            this.txtCodePath.Location = new System.Drawing.Point(326, 6);
            this.txtCodePath.Name = "txtCodePath";
            this.txtCodePath.Size = new System.Drawing.Size(845, 23);
            this.txtCodePath.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(273, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "目录：";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "文件名：";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "提示信息：";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmWebSrvClass_GeneCode
            // 
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.gbQueryCondition);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "frmWebSrvClass_GeneCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "项目表－代码生成20250705";
            this.Load += new System.EventHandler(this.frmWebSrvClass_QD_Load);
            this.gbQueryCondition.ResumeLayout(false);
            this.gbQueryCondition.PerformLayout();
            this.flpClassNameButtonList.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label lblObjId;
        private System.Windows.Forms.ComboBox cboFuncModuleId;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label lblMsg;

        private System.Windows.Forms.Button btnExportExcel4Dg;
        private System.Windows.Forms.Label lblRecNum;
        private System.Windows.Forms.GroupBox gbQueryCondition;
        private System.Windows.Forms.ListView lvvWebSrvClass;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtFileName4GenCode;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGeneAllCheckedTableThreeLayer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtCodePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClearCache;
        private System.Windows.Forms.Button btnWebServiceCode;
        private System.Windows.Forms.Button btnWS_Access;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCharEncodingId;
        private System.Windows.Forms.RadioButton rbMsSql;
        private System.Windows.Forms.RadioButton rbOracle;
        private System.Windows.Forms.RadioButton rbMySql;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flpClassNameButtonList;
        private System.Windows.Forms.Button btnWS_AccessHigh;
        private System.Windows.Forms.Button btnAppController;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblErrNum;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAppViewUnitTest;
        private System.Windows.Forms.Button btnAppViewUTScript;
        private System.Windows.Forms.Button btnAppViewUTScriptCS;
        private TzWinCtrlLib.TzRadioButtonList rblProgLangTypeId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboAppPageTypeId;
    }
}