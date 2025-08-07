
namespace AGC_CSV7
{
/// <summary>
///		frmViewInfo_QD_LV 的摘要说明。
/// </summary>
partial class frmViewInfo_QD_LV
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
this.lblViewName = new System.Windows.Forms.Label();
this.txtViewName = new System.Windows.Forms.TextBox();
this.lblViewTypeCode = new System.Windows.Forms.Label();
this.cboViewTypeCode = new System.Windows.Forms.ComboBox();
this.lblApplicationTypeId = new System.Windows.Forms.Label();
this.cboApplicationTypeId = new System.Windows.Forms.ComboBox();
this.lblFuncModuleId = new System.Windows.Forms.Label();
this.cboFuncModuleId = new System.Windows.Forms.ComboBox();
this.lblPrjId = new System.Windows.Forms.Label();
this.cboPrjId = new System.Windows.Forms.ComboBox();
this.lblMainTabId = new System.Windows.Forms.Label();
this.cboMainTabId = new System.Windows.Forms.ComboBox();
this.btnQuery = new System.Windows.Forms.Button();
this.lblMsg = new System.Windows.Forms.Label();
this.btnUpdate = new System.Windows.Forms.Button();
this.btnAdd = new System.Windows.Forms.Button();
this.btnDelRec = new System.Windows.Forms.Button();
this.btnExportExcel4Dg = new System.Windows.Forms.Button();
this.lblRecNum = new System.Windows.Forms.Label();
this.lvvViewInfo = new System.Windows.Forms.ListView();
this.gbQueryCondition = new System.Windows.Forms.GroupBox();
this.gbQueryCondition.SuspendLayout();
this.SuspendLayout();
//
// lblViewName
//
this.lblViewName.Location = new System.Drawing.Point(10, 18);
this.lblViewName.Name = "lblViewName";
this.lblViewName.Size = new System.Drawing.Size(70, 18);
this.lblViewName.TabIndex = 1;
this.lblViewName.Text = "界面名称";
//
// txtViewName
//
this.txtViewName.Location = new System.Drawing.Point(90, 18);
this.txtViewName.Name = "txtViewName";
this.txtViewName.Size = new System.Drawing.Size(100, 20);
this.txtViewName.TabIndex = 2;
this.txtViewName.Text = "";
//
// lblViewTypeCode
//
this.lblViewTypeCode.Location = new System.Drawing.Point(260, 18);
this.lblViewTypeCode.Name = "lblViewTypeCode";
this.lblViewTypeCode.Size = new System.Drawing.Size(70, 18);
this.lblViewTypeCode.TabIndex = 3;
this.lblViewTypeCode.Text = "界面类型码";
//
// cboViewTypeCode
//
this.cboViewTypeCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
this.cboViewTypeCode.Location = new System.Drawing.Point(340, 18);
this.cboViewTypeCode.Name = "cboViewTypeCode";
this.cboViewTypeCode.Size = new System.Drawing.Size(100, 20);
this.cboViewTypeCode.TabIndex = 4;
this.cboViewTypeCode.Text = "";
//
// lblApplicationTypeId
//
this.lblApplicationTypeId.Location = new System.Drawing.Point(10, 48);
this.lblApplicationTypeId.Name = "lblApplicationTypeId";
this.lblApplicationTypeId.Size = new System.Drawing.Size(70, 18);
this.lblApplicationTypeId.TabIndex = 5;
this.lblApplicationTypeId.Text = "应用程序类型ID";
//
// cboApplicationTypeId
//
this.cboApplicationTypeId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
this.cboApplicationTypeId.Location = new System.Drawing.Point(90, 48);
this.cboApplicationTypeId.Name = "cboApplicationTypeId";
this.cboApplicationTypeId.Size = new System.Drawing.Size(100, 20);
this.cboApplicationTypeId.TabIndex = 6;
this.cboApplicationTypeId.Text = "";
//
// lblFuncModuleId
//
this.lblFuncModuleId.Location = new System.Drawing.Point(260, 48);
this.lblFuncModuleId.Name = "lblFuncModuleId";
this.lblFuncModuleId.Size = new System.Drawing.Size(70, 18);
this.lblFuncModuleId.TabIndex = 7;
this.lblFuncModuleId.Text = "功能模块Id";
//
// cboFuncModuleId
//
this.cboFuncModuleId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
this.cboFuncModuleId.Location = new System.Drawing.Point(340, 48);
this.cboFuncModuleId.Name = "cboFuncModuleId";
this.cboFuncModuleId.Size = new System.Drawing.Size(100, 20);
this.cboFuncModuleId.TabIndex = 8;
this.cboFuncModuleId.Text = "";
//
// lblPrjId
//
this.lblPrjId.Location = new System.Drawing.Point(10, 78);
this.lblPrjId.Name = "lblPrjId";
this.lblPrjId.Size = new System.Drawing.Size(70, 18);
this.lblPrjId.TabIndex = 9;
this.lblPrjId.Text = "工程ID";
//
// cboPrjId
//
this.cboPrjId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
this.cboPrjId.Location = new System.Drawing.Point(90, 78);
this.cboPrjId.Name = "cboPrjId";
this.cboPrjId.Size = new System.Drawing.Size(100, 20);
this.cboPrjId.TabIndex = 10;
this.cboPrjId.Text = "";
//
// lblMainTabId
//
this.lblMainTabId.Location = new System.Drawing.Point(260, 78);
this.lblMainTabId.Name = "lblMainTabId";
this.lblMainTabId.Size = new System.Drawing.Size(70, 18);
this.lblMainTabId.TabIndex = 11;
this.lblMainTabId.Text = "主表ID";
//
// cboMainTabId
//
this.cboMainTabId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
this.cboMainTabId.Location = new System.Drawing.Point(340, 78);
this.cboMainTabId.Name = "cboMainTabId";
this.cboMainTabId.Size = new System.Drawing.Size(100, 20);
this.cboMainTabId.TabIndex = 12;
this.cboMainTabId.Text = "";
// 
// lblMsg
// 
this.lblMsg.Location = new System.Drawing.Point(192, 144);
this.lblMsg.Name = "lblMsg";
this.lblMsg.Size = new System.Drawing.Size(128, 16);
this.lblMsg.TabIndex = 13;
// 
// btnAdd
// 
this.btnAdd.Location = new System.Drawing.Point(408, 137);
this.btnAdd.Name = "btnAdd";
this.btnAdd.Size = new System.Drawing.Size(80, 26);
this.btnAdd.TabIndex = 14;
this.btnAdd.Text = "添加";
this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
// 
// btnUpdate
// 
this.btnUpdate.Location = new System.Drawing.Point(496, 137);
this.btnUpdate.Name = "btnUpdate";
this.btnUpdate.Size = new System.Drawing.Size(80, 26);
this.btnUpdate.TabIndex = 15;
this.btnUpdate.Text = "修改";
this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
// 
// btnDelRec
// 
this.btnDelRec.Location = new System.Drawing.Point(576, 137);
this.btnDelRec.Name = "btnDelRec";
this.btnDelRec.Size = new System.Drawing.Size(80, 26);
this.btnDelRec.TabIndex = 16;
this.btnDelRec.Text = "删除记录";
this.btnDelRec.Click += new System.EventHandler(this.btnDelRec_Click);
// 
// btnExportExcel4Dg
// 
this.btnExportExcel4Dg.Location = new System.Drawing.Point(664, 137);
this.btnExportExcel4Dg.Name = "btnExportExcel4Dg";
this.btnExportExcel4Dg.Size = new System.Drawing.Size(80, 26);
this.btnExportExcel4Dg.TabIndex = 17;
this.btnExportExcel4Dg.Text = "导出Excel";
this.btnExportExcel4Dg.Click += new System.EventHandler(this.btnExportExcel4Dg_Click);
// 
// btnQuery
// 
this.btnQuery.Location = new System.Drawing.Point(328, 137);
this.btnQuery.Name = "btnQuery";
this.btnQuery.Size = new System.Drawing.Size(80, 26);
this.btnQuery.TabIndex = 18;
this.btnQuery.Text = "查询";
this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
// 
// lblRecNum
// 
this.lblRecNum.Location = new System.Drawing.Point(752, 144);
this.lblRecNum.Name = "lblRecNum";
this.lblRecNum.Size = new System.Drawing.Size(112, 16);
this.lblRecNum.TabIndex = 19 ;
this.lblRecNum.Text = "记录数：";
// 
// lvViewInfo
// 
this.lvvViewInfo.Dock = System.Windows.Forms.DockStyle.Fill;
this.lvvViewInfo.Location = new System.Drawing.Point(0, 176);
this.lvvViewInfo.Name = "lvvViewInfo";
this.lvvViewInfo.Size = new System.Drawing.Size(1000, 524);
this.lvvViewInfo.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvvViewInfo_ColumnClick);
this.lvvViewInfo.TabIndex = 20;
this.lvvViewInfo.View = System.Windows.Forms.View.Details;
this.lvvViewInfo.Click += new System.EventHandler(this.lvvViewInfo_Click);
this.gbQueryCondition.Controls.Add(this.lblViewName);
this.gbQueryCondition.Controls.Add(this.txtViewName);
this.gbQueryCondition.Controls.Add(this.lblViewTypeCode);
this.gbQueryCondition.Controls.Add(this.cboViewTypeCode);
this.gbQueryCondition.Controls.Add(this.lblApplicationTypeId);
this.gbQueryCondition.Controls.Add(this.cboApplicationTypeId);
this.gbQueryCondition.Controls.Add(this.lblFuncModuleId);
this.gbQueryCondition.Controls.Add(this.cboFuncModuleId);
this.gbQueryCondition.Controls.Add(this.lblPrjId);
this.gbQueryCondition.Controls.Add(this.cboPrjId);
this.gbQueryCondition.Controls.Add(this.lblMainTabId);
this.gbQueryCondition.Controls.Add(this.cboMainTabId);
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
this.gbQueryCondition.TabIndex = 21;
this.gbQueryCondition.TabStop = false;
this.gbQueryCondition.Text = "查询条件";
// 
// frmViewInfo_QD_LV
// 
this.ClientSize = new System.Drawing.Size(1000, 700);
this.Controls.Add(this.lvvViewInfo);
this.Controls.Add(this.gbQueryCondition);
this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
this.Name = "frmViewInfo_QD_LV";
this.Text = "frmViewInfo_QD_LV";
this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
this.Load += new System.EventHandler(this.frmViewInfo_QD_Load);
this.ResumeLayout(false);
}
#endregion
private System.Windows.Forms.Label lblViewName;
private System.Windows.Forms.TextBox txtViewName;
private System.Windows.Forms.Label lblViewTypeCode;
private System.Windows.Forms.ComboBox cboViewTypeCode;
private System.Windows.Forms.Label lblApplicationTypeId;
private System.Windows.Forms.ComboBox cboApplicationTypeId;
private System.Windows.Forms.Label lblFuncModuleId;
private System.Windows.Forms.ComboBox cboFuncModuleId;
private System.Windows.Forms.Label lblPrjId;
private System.Windows.Forms.ComboBox cboPrjId;
private System.Windows.Forms.Label lblMainTabId;
private System.Windows.Forms.ComboBox cboMainTabId;
private System.Windows.Forms.Button btnQuery;
private System.Windows.Forms.Label lblMsg; 
private System.Windows.Forms.Button btnUpdate;
private System.Windows.Forms.Button btnAdd;
private System.Windows.Forms.Button btnDelRec;
private System.Windows.Forms.Button btnExportExcel4Dg;
private System.Windows.Forms.Label lblRecNum;
private System.Windows.Forms.GroupBox gbQueryCondition;
private System.Windows.Forms.ListView lvvViewInfo;
}
}