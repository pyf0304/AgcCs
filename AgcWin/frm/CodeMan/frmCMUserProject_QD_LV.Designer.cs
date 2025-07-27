
namespace AGC
{
 /// <summary>
 ///		frmCMUserProject_QD_LV 的摘要说明。
 /// </summary>
partial class frmCMUserProject_QD_LV
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
            this.lblCmPrjId = new System.Windows.Forms.Label();
            this.cboCmPrjId = new System.Windows.Forms.ComboBox();
            this.lblCmPrjName = new System.Windows.Forms.Label();
            this.txtCmPrjName = new System.Windows.Forms.TextBox();
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
            this.lvvCMUserProject = new System.Windows.Forms.ListView();
            this.gbQueryCondition = new System.Windows.Forms.GroupBox();
            this.btnCodeMan = new System.Windows.Forms.Button();
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
            // lblCmPrjId
            // 
            this.lblCmPrjId.Location = new System.Drawing.Point(260, 18);
            this.lblCmPrjId.Name = "lblCmPrjId";
            this.lblCmPrjId.Size = new System.Drawing.Size(70, 18);
            this.lblCmPrjId.TabIndex = 3;
            this.lblCmPrjId.Text = "CM工程Id";
            // 
            // cboCmPrjId
            // 
            this.cboCmPrjId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCmPrjId.Location = new System.Drawing.Point(340, 18);
            this.cboCmPrjId.Name = "cboCmPrjId";
            this.cboCmPrjId.Size = new System.Drawing.Size(100, 22);
            this.cboCmPrjId.TabIndex = 4;
            // 
            // lblCmPrjName
            // 
            this.lblCmPrjName.Location = new System.Drawing.Point(510, 18);
            this.lblCmPrjName.Name = "lblCmPrjName";
            this.lblCmPrjName.Size = new System.Drawing.Size(70, 18);
            this.lblCmPrjName.TabIndex = 5;
            this.lblCmPrjName.Text = "CM工程名";
            // 
            // txtCmPrjName
            // 
            this.txtCmPrjName.Location = new System.Drawing.Point(590, 18);
            this.txtCmPrjName.Name = "txtCmPrjName";
            this.txtCmPrjName.Size = new System.Drawing.Size(100, 23);
            this.txtCmPrjName.TabIndex = 6;
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
            this.btnQuery.Location = new System.Drawing.Point(504, 58);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(80, 26);
            this.btnQuery.TabIndex = 16;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.Location = new System.Drawing.Point(192, 113);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(128, 16);
            this.lblMsg.TabIndex = 11;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(496, 106);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 26);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(408, 106);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 26);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "添加";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelRec
            // 
            this.btnDelRec.Location = new System.Drawing.Point(576, 106);
            this.btnDelRec.Name = "btnDelRec";
            this.btnDelRec.Size = new System.Drawing.Size(80, 26);
            this.btnDelRec.TabIndex = 14;
            this.btnDelRec.Text = "删除记录";
            this.btnDelRec.Click += new System.EventHandler(this.btnDelRec_Click);
            // 
            // btnExportExcel4Dg
            // 
            this.btnExportExcel4Dg.Location = new System.Drawing.Point(590, 58);
            this.btnExportExcel4Dg.Name = "btnExportExcel4Dg";
            this.btnExportExcel4Dg.Size = new System.Drawing.Size(80, 26);
            this.btnExportExcel4Dg.TabIndex = 15;
            this.btnExportExcel4Dg.Text = "导出Excel";
            this.btnExportExcel4Dg.Click += new System.EventHandler(this.btnExportExcel4Dg_Click);
            // 
            // lblRecNum
            // 
            this.lblRecNum.Location = new System.Drawing.Point(685, 64);
            this.lblRecNum.Name = "lblRecNum";
            this.lblRecNum.Size = new System.Drawing.Size(112, 16);
            this.lblRecNum.TabIndex = 17;
            this.lblRecNum.Text = "记录数:";
            // 
            // lvvCMUserProject
            // 
            this.lvvCMUserProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvvCMUserProject.FullRowSelect = true;
            this.lvvCMUserProject.HideSelection = false;
            this.lvvCMUserProject.Location = new System.Drawing.Point(0, 147);
            this.lvvCMUserProject.Name = "lvvCMUserProject";
            this.lvvCMUserProject.Size = new System.Drawing.Size(1000, 553);
            this.lvvCMUserProject.TabIndex = 18;
            this.lvvCMUserProject.UseCompatibleStateImageBehavior = false;
            this.lvvCMUserProject.View = System.Windows.Forms.View.Details;
            this.lvvCMUserProject.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvvCMUserProject_ColumnClick);
            this.lvvCMUserProject.Click += new System.EventHandler(this.lvvCMUserProject_Click);
            // 
            // gbQueryCondition
            // 
            this.gbQueryCondition.Controls.Add(this.btnCodeMan);
            this.gbQueryCondition.Controls.Add(this.lblUserId);
            this.gbQueryCondition.Controls.Add(this.cboUserId);
            this.gbQueryCondition.Controls.Add(this.lblCmPrjId);
            this.gbQueryCondition.Controls.Add(this.cboCmPrjId);
            this.gbQueryCondition.Controls.Add(this.lblCmPrjName);
            this.gbQueryCondition.Controls.Add(this.txtCmPrjName);
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
            this.gbQueryCondition.Size = new System.Drawing.Size(1000, 147);
            this.gbQueryCondition.TabIndex = 19;
            this.gbQueryCondition.TabStop = false;
            this.gbQueryCondition.Text = "查询条件";
            // 
            // btnCodeMan
            // 
            this.btnCodeMan.Location = new System.Drawing.Point(662, 106);
            this.btnCodeMan.Name = "btnCodeMan";
            this.btnCodeMan.Size = new System.Drawing.Size(80, 26);
            this.btnCodeMan.TabIndex = 18;
            this.btnCodeMan.Text = "代码管理";
            this.btnCodeMan.Click += new System.EventHandler(this.btnCodeMan_Click);
            // 
            // frmCMUserProject_QD_LV
            // 
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.lvvCMUserProject);
            this.Controls.Add(this.gbQueryCondition);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "frmCMUserProject_QD_LV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCMUserProject_QD_LV";
            this.Load += new System.EventHandler(this.frmCMUserProject_QD_Load);
            this.gbQueryCondition.ResumeLayout(false);
            this.gbQueryCondition.PerformLayout();
            this.ResumeLayout(false);

}
#endregion
private System.Windows.Forms.Label lblUserId;
private System.Windows.Forms.ComboBox cboUserId;
private System.Windows.Forms.Label lblCmPrjId;
private System.Windows.Forms.ComboBox cboCmPrjId;
private System.Windows.Forms.Label lblCmPrjName;
private System.Windows.Forms.TextBox txtCmPrjName;
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
private System.Windows.Forms.ListView lvvCMUserProject;
        private System.Windows.Forms.Button btnCodeMan;
    }
}