
namespace AGC
{
 /// <summary>
 ///		frmFileResource_QD_DGV 的摘要说明。
 /// </summary>
partial class frmFileResource_QD_DGV
{
 /// <summary> 
 /// 必需的设计器变量。
 /// </summary>
private System.ComponentModel.Container components = null;

 /// <summary> 
 /// 清理所有正在使用的资源。
 /// </summary>
protected override void Dispose( bool disposing)
{
if( disposing)
{
if(components != null)
{
components.Dispose();
}
}
base.Dispose( disposing);
}
#region 组件设计器生成的代码
 /// <summary> 
 /// 设计器支持所需的方法 - 不要使用代码编辑器 
 /// 修改此方法的内容。
 /// </summary>
private void InitializeComponent()
{
            this.lblFileDirName = new System.Windows.Forms.Label();
            this.txtFileDirName = new System.Windows.Forms.TextBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblExtension = new System.Windows.Forms.Label();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.lblCmPrjId = new System.Windows.Forms.Label();
            this.cboCmPrjIdApp = new System.Windows.Forms.ComboBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelRec = new System.Windows.Forms.Button();
            this.btnExportExcel4Dg = new System.Windows.Forms.Button();
            this.lblRecNum = new System.Windows.Forms.Label();
            this.dgvvFileResource = new System.Windows.Forms.DataGridView();
            this.dgvcFileResourceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcFileDirName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrjTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcExtension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcFileLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcFileType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcCreationTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcLastWriteTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcInUse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcCmPrjName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcUpdDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcUpdUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbQueryCondition = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cboIsCanDel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDelFile4Prj = new System.Windows.Forms.Button();
            this.btnReadPrjFileInfo = new System.Windows.Forms.Button();
            this.lblFilePath = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvFileResource)).BeginInit();
            this.gbQueryCondition.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFileDirName
            // 
            this.lblFileDirName.Location = new System.Drawing.Point(3, 0);
            this.lblFileDirName.Name = "lblFileDirName";
            this.lblFileDirName.Size = new System.Drawing.Size(70, 18);
            this.lblFileDirName.TabIndex = 1;
            this.lblFileDirName.Text = "文件目录名";
            // 
            // txtFileDirName
            // 
            this.txtFileDirName.Location = new System.Drawing.Point(79, 3);
            this.txtFileDirName.Name = "txtFileDirName";
            this.txtFileDirName.Size = new System.Drawing.Size(164, 23);
            this.txtFileDirName.TabIndex = 2;
            // 
            // lblFileName
            // 
            this.lblFileName.Location = new System.Drawing.Point(249, 0);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(51, 18);
            this.lblFileName.TabIndex = 3;
            this.lblFileName.Text = "文件名";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(306, 3);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(146, 23);
            this.txtFileName.TabIndex = 4;
            // 
            // lblExtension
            // 
            this.lblExtension.Location = new System.Drawing.Point(458, 0);
            this.lblExtension.Name = "lblExtension";
            this.lblExtension.Size = new System.Drawing.Size(52, 18);
            this.lblExtension.TabIndex = 5;
            this.lblExtension.Text = "扩展名";
            // 
            // txtExtension
            // 
            this.txtExtension.Location = new System.Drawing.Point(516, 3);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(58, 23);
            this.txtExtension.TabIndex = 6;
            // 
            // lblCmPrjId
            // 
            this.lblCmPrjId.Location = new System.Drawing.Point(580, 0);
            this.lblCmPrjId.Name = "lblCmPrjId";
            this.lblCmPrjId.Size = new System.Drawing.Size(81, 18);
            this.lblCmPrjId.TabIndex = 7;
            this.lblCmPrjId.Text = "CM工程应用";
            // 
            // cboCmPrjIdApp
            // 
            this.cboCmPrjIdApp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCmPrjIdApp.Location = new System.Drawing.Point(667, 3);
            this.cboCmPrjIdApp.Name = "cboCmPrjIdApp";
            this.cboCmPrjIdApp.Size = new System.Drawing.Size(179, 22);
            this.cboCmPrjIdApp.TabIndex = 8;
            this.cboCmPrjIdApp.SelectedIndexChanged += new System.EventHandler(this.cboCmPrjId_SelectedIndexChanged);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(1015, 3);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(61, 26);
            this.btnQuery.TabIndex = 16;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.Location = new System.Drawing.Point(3, 0);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(428, 26);
            this.lblMsg.TabIndex = 11;
            this.lblMsg.Text = "系统信息";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(502, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(55, 26);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(437, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(59, 26);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "添加";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelRec
            // 
            this.btnDelRec.Location = new System.Drawing.Point(563, 3);
            this.btnDelRec.Name = "btnDelRec";
            this.btnDelRec.Size = new System.Drawing.Size(53, 26);
            this.btnDelRec.TabIndex = 14;
            this.btnDelRec.Text = "删除";
            this.btnDelRec.Visible = false;
            this.btnDelRec.Click += new System.EventHandler(this.btnDelRec_Click);
            // 
            // btnExportExcel4Dg
            // 
            this.btnExportExcel4Dg.Location = new System.Drawing.Point(1082, 3);
            this.btnExportExcel4Dg.Name = "btnExportExcel4Dg";
            this.btnExportExcel4Dg.Size = new System.Drawing.Size(80, 26);
            this.btnExportExcel4Dg.TabIndex = 15;
            this.btnExportExcel4Dg.Text = "导出Excel";
            this.btnExportExcel4Dg.Click += new System.EventHandler(this.btnExportExcel4Dg_Click);
            // 
            // lblRecNum
            // 
            this.lblRecNum.Location = new System.Drawing.Point(1168, 0);
            this.lblRecNum.Name = "lblRecNum";
            this.lblRecNum.Size = new System.Drawing.Size(112, 16);
            this.lblRecNum.TabIndex = 17;
            this.lblRecNum.Text = "记录数:";
            // 
            // dgvvFileResource
            // 
            this.dgvvFileResource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvvFileResource.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcFileResourceID,
            this.dgvcFileDirName,
            this.dgvcFileName,
            this.dgvPrjTab,
            this.dgvcExtension,
            this.dgvcFileLength,
            this.dgvcFileType,
            this.dgvcCreationTime,
            this.dgvcLastWriteTime,
            this.dgvcInUse,
            this.dgvcCmPrjName,
            this.dgvcUpdDate,
            this.dgvcUpdUser});
            this.dgvvFileResource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvvFileResource.Location = new System.Drawing.Point(0, 142);
            this.dgvvFileResource.Name = "dgvvFileResource";
            this.dgvvFileResource.Size = new System.Drawing.Size(1332, 558);
            this.dgvvFileResource.TabIndex = 18;
            this.dgvvFileResource.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvvFileResource_CellClick);
            this.dgvvFileResource.Click += new System.EventHandler(this.dgvvFileResource_Click);
            // 
            // dgvcFileResourceID
            // 
            this.dgvcFileResourceID.DataPropertyName = "FileResourceID";
            this.dgvcFileResourceID.HeaderText = "流水";
            this.dgvcFileResourceID.Name = "dgvcFileResourceID";
            this.dgvcFileResourceID.Width = 40;
            // 
            // dgvcFileDirName
            // 
            this.dgvcFileDirName.DataPropertyName = "FileDirName";
            this.dgvcFileDirName.HeaderText = "文件目录名";
            this.dgvcFileDirName.Name = "dgvcFileDirName";
            this.dgvcFileDirName.Width = 200;
            // 
            // dgvcFileName
            // 
            this.dgvcFileName.DataPropertyName = "FileName";
            this.dgvcFileName.HeaderText = "文件名";
            this.dgvcFileName.Name = "dgvcFileName";
            this.dgvcFileName.Width = 200;
            // 
            // dgvPrjTab
            // 
            this.dgvPrjTab.HeaderText = "生成表名";
            this.dgvPrjTab.Name = "dgvPrjTab";
            // 
            // dgvcExtension
            // 
            this.dgvcExtension.DataPropertyName = "Extension";
            this.dgvcExtension.HeaderText = "扩展名";
            this.dgvcExtension.Name = "dgvcExtension";
            this.dgvcExtension.Width = 60;
            // 
            // dgvcFileLength
            // 
            this.dgvcFileLength.DataPropertyName = "FileLength";
            this.dgvcFileLength.HeaderText = "长度";
            this.dgvcFileLength.Name = "dgvcFileLength";
            this.dgvcFileLength.Width = 50;
            // 
            // dgvcFileType
            // 
            this.dgvcFileType.DataPropertyName = "FileType";
            this.dgvcFileType.HeaderText = "文件类型";
            this.dgvcFileType.Name = "dgvcFileType";
            this.dgvcFileType.Visible = false;
            // 
            // dgvcCreationTime
            // 
            this.dgvcCreationTime.DataPropertyName = "CreationTime";
            this.dgvcCreationTime.HeaderText = "建立时间";
            this.dgvcCreationTime.Name = "dgvcCreationTime";
            // 
            // dgvcLastWriteTime
            // 
            this.dgvcLastWriteTime.DataPropertyName = "LastWriteTime";
            this.dgvcLastWriteTime.HeaderText = "修改日期";
            this.dgvcLastWriteTime.Name = "dgvcLastWriteTime";
            // 
            // dgvcInUse
            // 
            this.dgvcInUse.DataPropertyName = "InUse";
            this.dgvcInUse.HeaderText = "是否在用";
            this.dgvcInUse.Name = "dgvcInUse";
            // 
            // dgvcCmPrjName
            // 
            this.dgvcCmPrjName.DataPropertyName = "CmPrjName";
            this.dgvcCmPrjName.HeaderText = "CM工程名";
            this.dgvcCmPrjName.Name = "dgvcCmPrjName";
            // 
            // dgvcUpdDate
            // 
            this.dgvcUpdDate.DataPropertyName = "UpdDate";
            this.dgvcUpdDate.HeaderText = "修改日期";
            this.dgvcUpdDate.Name = "dgvcUpdDate";
            // 
            // dgvcUpdUser
            // 
            this.dgvcUpdUser.DataPropertyName = "UpdUser";
            this.dgvcUpdUser.HeaderText = "修改者";
            this.dgvcUpdUser.Name = "dgvcUpdUser";
            // 
            // gbQueryCondition
            // 
            this.gbQueryCondition.Controls.Add(this.label2);
            this.gbQueryCondition.Controls.Add(this.tableLayoutPanel1);
            this.gbQueryCondition.Controls.Add(this.flowLayoutPanel1);
            this.gbQueryCondition.Controls.Add(this.lblFilePath);
            this.gbQueryCondition.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbQueryCondition.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbQueryCondition.Location = new System.Drawing.Point(0, 0);
            this.gbQueryCondition.Name = "gbQueryCondition";
            this.gbQueryCondition.Size = new System.Drawing.Size(1332, 142);
            this.gbQueryCondition.TabIndex = 19;
            this.gbQueryCondition.TabStop = false;
            this.gbQueryCondition.Text = "查询条件";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(561, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "工程主路径";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 15;
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.cboIsCanDel, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFileDirName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtFileDirName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblRecNum, 14, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnExportExcel4Dg, 13, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboCmPrjIdApp, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnQuery, 12, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtFileName, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFileName, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblExtension, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtExtension, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCmPrjId, 6, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1293, 35);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // cboIsCanDel
            // 
            this.cboIsCanDel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIsCanDel.Location = new System.Drawing.Point(918, 3);
            this.cboIsCanDel.Name = "cboIsCanDel";
            this.cboIsCanDel.Size = new System.Drawing.Size(51, 22);
            this.cboIsCanDel.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(852, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "可删除?";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblMsg);
            this.flowLayoutPanel1.Controls.Add(this.btnAdd);
            this.flowLayoutPanel1.Controls.Add(this.btnUpdate);
            this.flowLayoutPanel1.Controls.Add(this.btnDelRec);
            this.flowLayoutPanel1.Controls.Add(this.btnDelFile4Prj);
            this.flowLayoutPanel1.Controls.Add(this.btnReadPrjFileInfo);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(150, 98);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1063, 34);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // btnDelFile4Prj
            // 
            this.btnDelFile4Prj.Location = new System.Drawing.Point(622, 3);
            this.btnDelFile4Prj.Name = "btnDelFile4Prj";
            this.btnDelFile4Prj.Size = new System.Drawing.Size(163, 26);
            this.btnDelFile4Prj.TabIndex = 15;
            this.btnDelFile4Prj.Text = "在工程中删除无效文件";
            this.btnDelFile4Prj.Click += new System.EventHandler(this.btnDelFile4Prj_Click);
            // 
            // btnReadPrjFileInfo
            // 
            this.btnReadPrjFileInfo.Location = new System.Drawing.Point(791, 3);
            this.btnReadPrjFileInfo.Name = "btnReadPrjFileInfo";
            this.btnReadPrjFileInfo.Size = new System.Drawing.Size(137, 23);
            this.btnReadPrjFileInfo.TabIndex = 20;
            this.btnReadPrjFileInfo.Text = "读取工程文件信息";
            this.btnReadPrjFileInfo.UseVisualStyleBackColor = true;
            this.btnReadPrjFileInfo.Click += new System.EventHandler(this.btnReadPrjFileInfo_Click);
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(650, 69);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(63, 14);
            this.lblFilePath.TabIndex = 21;
            this.lblFilePath.Text = "FilePath";
            // 
            // frmFileResource_QD_DGV
            // 
            this.ClientSize = new System.Drawing.Size(1332, 700);
            this.Controls.Add(this.dgvvFileResource);
            this.Controls.Add(this.gbQueryCondition);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "frmFileResource_QD_DGV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFileResource_QD_LV";
            this.Load += new System.EventHandler(this.frmFileResource_QD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvvFileResource)).EndInit();
            this.gbQueryCondition.ResumeLayout(false);
            this.gbQueryCondition.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

}
#endregion
private System.Windows.Forms.Label lblFileDirName;
private System.Windows.Forms.TextBox txtFileDirName;
private System.Windows.Forms.Label lblFileName;
private System.Windows.Forms.TextBox txtFileName;
private System.Windows.Forms.Label lblExtension;
private System.Windows.Forms.TextBox txtExtension;
private System.Windows.Forms.Label lblCmPrjId;
private System.Windows.Forms.ComboBox cboCmPrjIdApp;
private System.Windows.Forms.Button btnQuery;
private System.Windows.Forms.Label lblMsg; 
private System.Windows.Forms.Button btnUpdate;
private System.Windows.Forms.Button btnAdd;
private System.Windows.Forms.Button btnDelRec;
private System.Windows.Forms.Button btnExportExcel4Dg;
private System.Windows.Forms.Label lblRecNum;
private System.Windows.Forms.GroupBox gbQueryCondition;
private System.Windows.Forms.DataGridView dgvvFileResource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcFileResourceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcFileDirName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrjTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcExtension;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcFileLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcFileType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcCreationTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcLastWriteTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcInUse;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcCmPrjName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcUpdDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcUpdUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox cboIsCanDel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelFile4Prj;
        private System.Windows.Forms.Button btnReadPrjFileInfo;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Label label2;
    }
}