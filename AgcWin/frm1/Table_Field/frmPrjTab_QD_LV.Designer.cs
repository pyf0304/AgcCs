
namespace AGC_CSV7
{
/// <summary>
///		frmPrjTab_QD_LV 的摘要说明。
/// </summary>
partial class frmPrjTab_QD_LV
{
/// <summary> 
/// 必需的设计器变量。
/// </summary>
private System.ComponentModel.Container components = null;

/// <summary> 
/// 清理所有正在使用的资源。
/// </summary>
protected override void Dispose( bool disposing )
{
if( disposing )
{
if(components != null)
{
components.Dispose();
}
}
base.Dispose( disposing );
}
#region 组件设计器生成的代码
/// <summary> 
/// 设计器支持所需的方法 - 不要使用代码编辑器 
/// 修改此方法的内容。
/// </summary>
private void InitializeComponent()
{
this.lblTabName = new System.Windows.Forms.Label();
this.txtTabName = new System.Windows.Forms.TextBox();
this.lblPrjId = new System.Windows.Forms.Label();
this.cboPrjId = new System.Windows.Forms.ComboBox();
this.lblObjId = new System.Windows.Forms.Label();
this.cboObjId = new System.Windows.Forms.ComboBox();
this.lblSQLDSTypeId = new System.Windows.Forms.Label();
this.cboSQLDSTypeId = new System.Windows.Forms.ComboBox();
this.lblTabStateId = new System.Windows.Forms.Label();
this.cboTabStateId = new System.Windows.Forms.ComboBox();
this.btnQuery = new System.Windows.Forms.Button();
this.lblMsg = new System.Windows.Forms.Label();
this.btnUpdate = new System.Windows.Forms.Button();
this.btnAdd = new System.Windows.Forms.Button();
this.btnDelRec = new System.Windows.Forms.Button();
this.btnExportExcel4Dg = new System.Windows.Forms.Button();
this.lblRecNum = new System.Windows.Forms.Label();
this.lvvPrjTab = new System.Windows.Forms.ListView();
this.gbQueryCondition = new System.Windows.Forms.GroupBox();
this.gbQueryCondition.SuspendLayout();
this.SuspendLayout();
//
// lblTabName
//
this.lblTabName.Location = new System.Drawing.Point(10, 18);
this.lblTabName.Name = "lblTabName";
this.lblTabName.Size = new System.Drawing.Size(70, 18);
this.lblTabName.TabIndex = 1;
this.lblTabName.Text = "表名";
//
// txtTabName
//
this.txtTabName.Location = new System.Drawing.Point(90, 18);
this.txtTabName.Name = "txtTabName";
this.txtTabName.Size = new System.Drawing.Size(100, 20);
this.txtTabName.TabIndex = 2;
this.txtTabName.Text = "";
//
// lblPrjId
//
this.lblPrjId.Location = new System.Drawing.Point(260, 18);
this.lblPrjId.Name = "lblPrjId";
this.lblPrjId.Size = new System.Drawing.Size(70, 18);
this.lblPrjId.TabIndex = 3;
this.lblPrjId.Text = "工程ID";
//
// cboPrjId
//
this.cboPrjId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
this.cboPrjId.Location = new System.Drawing.Point(340, 18);
this.cboPrjId.Name = "cboPrjId";
this.cboPrjId.Size = new System.Drawing.Size(100, 20);
this.cboPrjId.TabIndex = 4;
this.cboPrjId.Text = "";
//
// lblObjId
//
this.lblObjId.Location = new System.Drawing.Point(10, 48);
this.lblObjId.Name = "lblObjId";
this.lblObjId.Size = new System.Drawing.Size(70, 18);
this.lblObjId.TabIndex = 5;
this.lblObjId.Text = "所属对象";
//
// cboObjId
//
this.cboObjId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
this.cboObjId.Location = new System.Drawing.Point(90, 48);
this.cboObjId.Name = "cboObjId";
this.cboObjId.Size = new System.Drawing.Size(100, 20);
this.cboObjId.TabIndex = 6;
this.cboObjId.Text = "";
//
// lblSQLDSTypeId
//
this.lblSQLDSTypeId.Location = new System.Drawing.Point(260, 48);
this.lblSQLDSTypeId.Name = "lblSQLDSTypeId";
this.lblSQLDSTypeId.Size = new System.Drawing.Size(70, 18);
this.lblSQLDSTypeId.TabIndex = 7;
this.lblSQLDSTypeId.Text = "数据源类型";
//
// cboSQLDSTypeId
//
this.cboSQLDSTypeId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
this.cboSQLDSTypeId.Location = new System.Drawing.Point(340, 48);
this.cboSQLDSTypeId.Name = "cboSQLDSTypeId";
this.cboSQLDSTypeId.Size = new System.Drawing.Size(100, 20);
this.cboSQLDSTypeId.TabIndex = 8;
this.cboSQLDSTypeId.Text = "";
//
// lblTabStateId
//
this.lblTabStateId.Location = new System.Drawing.Point(10, 78);
this.lblTabStateId.Name = "lblTabStateId";
this.lblTabStateId.Size = new System.Drawing.Size(70, 18);
this.lblTabStateId.TabIndex = 9;
this.lblTabStateId.Text = "表状态ID";
//
// cboTabStateId
//
this.cboTabStateId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
this.cboTabStateId.Location = new System.Drawing.Point(90, 78);
this.cboTabStateId.Name = "cboTabStateId";
this.cboTabStateId.Size = new System.Drawing.Size(100, 20);
this.cboTabStateId.TabIndex = 10;
this.cboTabStateId.Text = "";
// 
// lblMsg
// 
this.lblMsg.Location = new System.Drawing.Point(192, 144);
this.lblMsg.Name = "lblMsg";
this.lblMsg.Size = new System.Drawing.Size(128, 16);
this.lblMsg.TabIndex = 11;
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
// btnUpdate
// 
this.btnUpdate.Location = new System.Drawing.Point(496, 137);
this.btnUpdate.Name = "btnUpdate";
this.btnUpdate.Size = new System.Drawing.Size(80, 26);
this.btnUpdate.TabIndex = 13;
this.btnUpdate.Text = "修改";
this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
// btnQuery
// 
this.btnQuery.Location = new System.Drawing.Point(328, 137);
this.btnQuery.Name = "btnQuery";
this.btnQuery.Size = new System.Drawing.Size(80, 26);
this.btnQuery.TabIndex = 16;
this.btnQuery.Text = "查询";
this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
// 
// lblRecNum
// 
this.lblRecNum.Location = new System.Drawing.Point(752, 144);
this.lblRecNum.Name = "lblRecNum";
this.lblRecNum.Size = new System.Drawing.Size(112, 16);
this.lblRecNum.TabIndex = 17 ;
this.lblRecNum.Text = "记录数：";
// 
// lvPrjTab
// 
this.lvvPrjTab.Dock = System.Windows.Forms.DockStyle.Fill;
this.lvvPrjTab.Location = new System.Drawing.Point(0, 176);
this.lvvPrjTab.Name = "lvvPrjTab";
this.lvvPrjTab.Size = new System.Drawing.Size(1000, 524);
this.lvvPrjTab.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvvPrjTab_ColumnClick);
this.lvvPrjTab.TabIndex = 18;
this.lvvPrjTab.View = System.Windows.Forms.View.Details;
this.lvvPrjTab.Click += new System.EventHandler(this.lvvPrjTab_Click);
this.gbQueryCondition.Controls.Add(this.lblTabName);
this.gbQueryCondition.Controls.Add(this.txtTabName);
this.gbQueryCondition.Controls.Add(this.lblPrjId);
this.gbQueryCondition.Controls.Add(this.cboPrjId);
this.gbQueryCondition.Controls.Add(this.lblObjId);
this.gbQueryCondition.Controls.Add(this.cboObjId);
this.gbQueryCondition.Controls.Add(this.lblSQLDSTypeId);
this.gbQueryCondition.Controls.Add(this.cboSQLDSTypeId);
this.gbQueryCondition.Controls.Add(this.lblTabStateId);
this.gbQueryCondition.Controls.Add(this.cboTabStateId);
this.gbQueryCondition.Controls.Add(this.btnExportExcel4Dg);
this.gbQueryCondition.Controls.Add(this.btnQuery);
this.gbQueryCondition.Controls.Add(this.btnUpdate);
this.gbQueryCondition.Controls.Add(this.btnAdd);
this.gbQueryCondition.Controls.Add(this.btnDelRec);
this.gbQueryCondition.Controls.Add(this.lblMsg);
this.gbQueryCondition.Controls.Add(this.lblRecNum);
this.gbQueryCondition.Dock = System.Windows.Forms.DockStyle.Top;
this.gbQueryCondition.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
this.gbQueryCondition.Location = new System.Drawing.Point(0, 0);
this.gbQueryCondition.Name = "gbQueryCondition";
this.gbQueryCondition.Size = new System.Drawing.Size(720, 176);
this.gbQueryCondition.TabIndex = 19;
this.gbQueryCondition.TabStop = false;
this.gbQueryCondition.Text = "查询条件";
// 
// frmPrjTab_QD_LV
// 
this.ClientSize = new System.Drawing.Size(1000, 700);
this.Controls.Add(this.lvvPrjTab);
this.Controls.Add(this.gbQueryCondition);
this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
this.Name = "frmPrjTab_QD_LV";
this.Text = "frmPrjTab_QD_LV";
this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
this.Load += new System.EventHandler(this.frmPrjTab_QD_Load);
this.ResumeLayout(false);
}
#endregion
private System.Windows.Forms.Label lblTabName;
private System.Windows.Forms.TextBox txtTabName;
private System.Windows.Forms.Label lblPrjId;
private System.Windows.Forms.ComboBox cboPrjId;
private System.Windows.Forms.Label lblObjId;
private System.Windows.Forms.ComboBox cboObjId;
private System.Windows.Forms.Label lblSQLDSTypeId;
private System.Windows.Forms.ComboBox cboSQLDSTypeId;
private System.Windows.Forms.Label lblTabStateId;
private System.Windows.Forms.ComboBox cboTabStateId;
private System.Windows.Forms.Button btnQuery;
private System.Windows.Forms.Label lblMsg; 
private System.Windows.Forms.Button btnUpdate;
private System.Windows.Forms.Button btnAdd;
private System.Windows.Forms.Button btnDelRec;
private System.Windows.Forms.Button btnExportExcel4Dg;
private System.Windows.Forms.Label lblRecNum;
private System.Windows.Forms.GroupBox gbQueryCondition;
private System.Windows.Forms.ListView lvvPrjTab;
}
}