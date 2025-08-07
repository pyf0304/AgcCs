
namespace AGC
{
 /// <summary>
 ///		frmCMUserProject_QD_DGV 的摘要说明。
 /// </summary>
partial class frmCMUserProject_QD_DGV
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
            this.lblUserId = new System.Windows.Forms.Label();
            this.cboUserId = new System.Windows.Forms.ComboBox();
            this.lblCMPrjId = new System.Windows.Forms.Label();
            this.cboCMPrjId = new System.Windows.Forms.ComboBox();
            this.lblCMPrjName = new System.Windows.Forms.Label();
            this.txtCMPrjName = new System.Windows.Forms.TextBox();
            this.lblPrjId = new System.Windows.Forms.Label();
            this.cboPrjId = new System.Windows.Forms.ComboBox();
            this.lblApplicationTypeId = new System.Windows.Forms.Label();
            this.cboApplicationTypeId = new System.Windows.Forms.ComboBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelRec = new System.Windows.Forms.Button();
            this.btnExportExcel4Dg = new System.Windows.Forms.Button();
            this.lblRecNum = new System.Windows.Forms.Label();
            this.dgvvCMUserProject = new System.Windows.Forms.DataGridView();
            this.dgvcmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcCMPrjName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcPrjName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcApplicationTypeSimName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcProjectFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcProjectPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcUpdDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcMemo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbQueryCondition = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvCMUserProject)).BeginInit();
            this.gbQueryCondition.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUserId
            // 
            this.lblUserId.Location = new System.Drawing.Point(10, 18);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(70, 18);
            this.lblUserId.TabIndex = 1;
            this.lblUserId.Text = "用户Id";
            // 
            // cboUserId
            // 
            this.cboUserId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUserId.Location = new System.Drawing.Point(90, 18);
            this.cboUserId.Name = "cboUserId";
            this.cboUserId.Size = new System.Drawing.Size(100, 22);
            this.cboUserId.TabIndex = 2;
            // 
            // lblCMPrjId
            // 
            this.lblCMPrjId.Location = new System.Drawing.Point(260, 18);
            this.lblCMPrjId.Name = "lblCMPrjId";
            this.lblCMPrjId.Size = new System.Drawing.Size(70, 18);
            this.lblCMPrjId.TabIndex = 3;
            this.lblCMPrjId.Text = "CM工程Id";
            // 
            // cboCMPrjId
            // 
            this.cboCMPrjId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCMPrjId.Location = new System.Drawing.Point(340, 18);
            this.cboCMPrjId.Name = "cboCMPrjId";
            this.cboCMPrjId.Size = new System.Drawing.Size(100, 22);
            this.cboCMPrjId.TabIndex = 4;
            // 
            // lblCMPrjName
            // 
            this.lblCMPrjName.Location = new System.Drawing.Point(510, 18);
            this.lblCMPrjName.Name = "lblCMPrjName";
            this.lblCMPrjName.Size = new System.Drawing.Size(70, 18);
            this.lblCMPrjName.TabIndex = 5;
            this.lblCMPrjName.Text = "CM工程名";
            // 
            // txtCMPrjName
            // 
            this.txtCMPrjName.Location = new System.Drawing.Point(590, 18);
            this.txtCMPrjName.Name = "txtCMPrjName";
            this.txtCMPrjName.Size = new System.Drawing.Size(100, 23);
            this.txtCMPrjName.TabIndex = 6;
            // 
            // lblPrjId
            // 
            this.lblPrjId.Location = new System.Drawing.Point(760, 18);
            this.lblPrjId.Name = "lblPrjId";
            this.lblPrjId.Size = new System.Drawing.Size(70, 18);
            this.lblPrjId.TabIndex = 7;
            this.lblPrjId.Text = "工程";
            // 
            // cboPrjId
            // 
            this.cboPrjId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPrjId.Location = new System.Drawing.Point(840, 18);
            this.cboPrjId.Name = "cboPrjId";
            this.cboPrjId.Size = new System.Drawing.Size(100, 22);
            this.cboPrjId.TabIndex = 8;
            // 
            // lblApplicationTypeId
            // 
            this.lblApplicationTypeId.Location = new System.Drawing.Point(10, 48);
            this.lblApplicationTypeId.Name = "lblApplicationTypeId";
            this.lblApplicationTypeId.Size = new System.Drawing.Size(70, 18);
            this.lblApplicationTypeId.TabIndex = 9;
            this.lblApplicationTypeId.Text = "应用";
            // 
            // cboApplicationTypeId
            // 
            this.cboApplicationTypeId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboApplicationTypeId.Location = new System.Drawing.Point(90, 48);
            this.cboApplicationTypeId.Name = "cboApplicationTypeId";
            this.cboApplicationTypeId.Size = new System.Drawing.Size(100, 22);
            this.cboApplicationTypeId.TabIndex = 10;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(328, 137);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(80, 26);
            this.btnQuery.TabIndex = 16;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.Location = new System.Drawing.Point(192, 144);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(128, 16);
            this.lblMsg.TabIndex = 11;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(496, 137);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 26);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(408, 137);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 26);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "添加";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelRec
            // 
            this.btnDelRec.Location = new System.Drawing.Point(576, 137);
            this.btnDelRec.Name = "btnDelRec";
            this.btnDelRec.Size = new System.Drawing.Size(80, 26);
            this.btnDelRec.TabIndex = 14;
            this.btnDelRec.Text = "删除记录";
            this.btnDelRec.Click += new System.EventHandler(this.btnDelRec_Click);
            // 
            // btnExportExcel4Dg
            // 
            this.btnExportExcel4Dg.Location = new System.Drawing.Point(664, 137);
            this.btnExportExcel4Dg.Name = "btnExportExcel4Dg";
            this.btnExportExcel4Dg.Size = new System.Drawing.Size(80, 26);
            this.btnExportExcel4Dg.TabIndex = 15;
            this.btnExportExcel4Dg.Text = "导出Excel";
            this.btnExportExcel4Dg.Click += new System.EventHandler(this.btnExportExcel4Dg_Click);
            // 
            // lblRecNum
            // 
            this.lblRecNum.Location = new System.Drawing.Point(752, 144);
            this.lblRecNum.Name = "lblRecNum";
            this.lblRecNum.Size = new System.Drawing.Size(112, 16);
            this.lblRecNum.TabIndex = 17;
            this.lblRecNum.Text = "记录数:";
            // 
            // dgvvCMUserProject
            // 
            this.dgvvCMUserProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvvCMUserProject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcmId,
            this.dgvcUserId,
            this.dgvcUserName,
            this.dgvcCMPrjName,
            this.dgvcPrjName,
            this.dgvcApplicationTypeSimName,
            this.dgvcProjectFileName,
            this.dgvcProjectPath,
            this.dgvcUpdDate,
            this.dgvcMemo});
            this.dgvvCMUserProject.Location = new System.Drawing.Point(0, 176);
            this.dgvvCMUserProject.Name = "dgvvCMUserProject";
            this.dgvvCMUserProject.Size = new System.Drawing.Size(774, 524);
            this.dgvvCMUserProject.TabIndex = 18;
            this.dgvvCMUserProject.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvvCMUserProject_CellClick);
            this.dgvvCMUserProject.Click += new System.EventHandler(this.dgvvCMUserProject_Click);
            // 
            // dgvcmId
            // 
            this.dgvcmId.DataPropertyName = "mId";
            this.dgvcmId.HeaderText = "mId";
            this.dgvcmId.Name = "dgvcmId";
            // 
            // dgvcUserId
            // 
            this.dgvcUserId.DataPropertyName = "UserId";
            this.dgvcUserId.HeaderText = "用户Id";
            this.dgvcUserId.Name = "dgvcUserId";
            // 
            // dgvcUserName
            // 
            this.dgvcUserName.DataPropertyName = "UserName";
            this.dgvcUserName.HeaderText = "用户名";
            this.dgvcUserName.Name = "dgvcUserName";
            // 
            // dgvcCMPrjName
            // 
            this.dgvcCMPrjName.DataPropertyName = "CMPrjName";
            this.dgvcCMPrjName.HeaderText = "CM工程";
            this.dgvcCMPrjName.Name = "dgvcCMPrjName";
            // 
            // dgvcPrjName
            // 
            this.dgvcPrjName.DataPropertyName = "PrjName";
            this.dgvcPrjName.HeaderText = "工程";
            this.dgvcPrjName.Name = "dgvcPrjName";
            // 
            // dgvcApplicationTypeSimName
            // 
            this.dgvcApplicationTypeSimName.DataPropertyName = "ApplicationTypeSimName";
            this.dgvcApplicationTypeSimName.HeaderText = "应用";
            this.dgvcApplicationTypeSimName.Name = "dgvcApplicationTypeSimName";
            // 
            // dgvcProjectFileName
            // 
            this.dgvcProjectFileName.DataPropertyName = "ProjectFileName";
            this.dgvcProjectFileName.HeaderText = "工程文件名";
            this.dgvcProjectFileName.Name = "dgvcProjectFileName";
            // 
            // dgvcProjectPath
            // 
            this.dgvcProjectPath.DataPropertyName = "ProjectPath";
            this.dgvcProjectPath.HeaderText = "工程路径";
            this.dgvcProjectPath.Name = "dgvcProjectPath";
            // 
            // dgvcUpdDate
            // 
            this.dgvcUpdDate.DataPropertyName = "UpdDate";
            this.dgvcUpdDate.HeaderText = "修改日期";
            this.dgvcUpdDate.Name = "dgvcUpdDate";
            // 
            // dgvcMemo
            // 
            this.dgvcMemo.DataPropertyName = "Memo";
            this.dgvcMemo.HeaderText = "说明";
            this.dgvcMemo.Name = "dgvcMemo";
            // 
            // gbQueryCondition
            // 
            this.gbQueryCondition.Controls.Add(this.lblUserId);
            this.gbQueryCondition.Controls.Add(this.cboUserId);
            this.gbQueryCondition.Controls.Add(this.lblCMPrjId);
            this.gbQueryCondition.Controls.Add(this.cboCMPrjId);
            this.gbQueryCondition.Controls.Add(this.lblCMPrjName);
            this.gbQueryCondition.Controls.Add(this.txtCMPrjName);
            this.gbQueryCondition.Controls.Add(this.lblPrjId);
            this.gbQueryCondition.Controls.Add(this.cboPrjId);
            this.gbQueryCondition.Controls.Add(this.lblApplicationTypeId);
            this.gbQueryCondition.Controls.Add(this.cboApplicationTypeId);
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
            this.gbQueryCondition.Size = new System.Drawing.Size(1000, 176);
            this.gbQueryCondition.TabIndex = 19;
            this.gbQueryCondition.TabStop = false;
            this.gbQueryCondition.Text = "查询条件";
            // 
            // frmCMUserProject_QD_DGV
            // 
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.dgvvCMUserProject);
            this.Controls.Add(this.gbQueryCondition);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "frmCMUserProject_QD_DGV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCMUserProject_QD_LV";
            this.Load += new System.EventHandler(this.frmCMUserProject_QD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvvCMUserProject)).EndInit();
            this.gbQueryCondition.ResumeLayout(false);
            this.gbQueryCondition.PerformLayout();
            this.ResumeLayout(false);

}
#endregion
private System.Windows.Forms.Label lblUserId;
private System.Windows.Forms.ComboBox cboUserId;
private System.Windows.Forms.Label lblCMPrjId;
private System.Windows.Forms.ComboBox cboCMPrjId;
private System.Windows.Forms.Label lblCMPrjName;
private System.Windows.Forms.TextBox txtCMPrjName;
private System.Windows.Forms.Label lblPrjId;
private System.Windows.Forms.ComboBox cboPrjId;
private System.Windows.Forms.Label lblApplicationTypeId;
private System.Windows.Forms.ComboBox cboApplicationTypeId;
private System.Windows.Forms.Button btnQuery;
private System.Windows.Forms.Label lblMsg; 
private System.Windows.Forms.Button btnUpdate;
private System.Windows.Forms.Button btnAdd;
private System.Windows.Forms.Button btnDelRec;
private System.Windows.Forms.Button btnExportExcel4Dg;
private System.Windows.Forms.Label lblRecNum;
private System.Windows.Forms.GroupBox gbQueryCondition;
private System.Windows.Forms.DataGridView dgvvCMUserProject;
private System.Windows.Forms.DataGridViewTextBoxColumn dgvcmId;
private System.Windows.Forms.DataGridViewTextBoxColumn dgvcUserId;
private System.Windows.Forms.DataGridViewTextBoxColumn dgvcUserName;
private System.Windows.Forms.DataGridViewTextBoxColumn dgvcCMPrjName;
private System.Windows.Forms.DataGridViewTextBoxColumn dgvcPrjName;
private System.Windows.Forms.DataGridViewTextBoxColumn dgvcApplicationTypeSimName;
private System.Windows.Forms.DataGridViewTextBoxColumn dgvcProjectFileName;
private System.Windows.Forms.DataGridViewTextBoxColumn dgvcProjectPath;
private System.Windows.Forms.DataGridViewTextBoxColumn dgvcUpdDate;
private System.Windows.Forms.DataGridViewTextBoxColumn dgvcMemo;
}
}