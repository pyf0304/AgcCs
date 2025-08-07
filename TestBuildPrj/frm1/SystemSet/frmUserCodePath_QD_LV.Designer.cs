
namespace AGC_CSV7
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
this.lblUserId = new System.Windows.Forms.Label();
this.cboUserId = new System.Windows.Forms.ComboBox();
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
// cboUserId
//
this.cboUserId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
this.cboUserId.Location = new System.Drawing.Point(90, 18);
this.cboUserId.Name = "cboUserId";
this.cboUserId.Size = new System.Drawing.Size(100, 20);
this.cboUserId.TabIndex = 2;
this.cboUserId.Text = "";
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
// lblCodeTypeId
//
this.lblCodeTypeId.Location = new System.Drawing.Point(10, 48);
this.lblCodeTypeId.Name = "lblCodeTypeId";
this.lblCodeTypeId.Size = new System.Drawing.Size(70, 18);
this.lblCodeTypeId.TabIndex = 5;
this.lblCodeTypeId.Text = "代码类型Id";
//
// cboCodeTypeId
//
this.cboCodeTypeId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
this.cboCodeTypeId.Location = new System.Drawing.Point(90, 48);
this.cboCodeTypeId.Name = "cboCodeTypeId";
this.cboCodeTypeId.Size = new System.Drawing.Size(100, 20);
this.cboCodeTypeId.TabIndex = 6;
this.cboCodeTypeId.Text = "";
// 
// lblMsg
// 
this.lblMsg.Location = new System.Drawing.Point(192, 144);
this.lblMsg.Name = "lblMsg";
this.lblMsg.Size = new System.Drawing.Size(128, 16);
this.lblMsg.TabIndex = 7;
// 
// btnAdd
// 
this.btnAdd.Location = new System.Drawing.Point(408, 137);
this.btnAdd.Name = "btnAdd";
this.btnAdd.Size = new System.Drawing.Size(80, 26);
this.btnAdd.TabIndex = 8;
this.btnAdd.Text = "添加";
this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
// 
// btnUpdate
// 
this.btnUpdate.Location = new System.Drawing.Point(496, 137);
this.btnUpdate.Name = "btnUpdate";
this.btnUpdate.Size = new System.Drawing.Size(80, 26);
this.btnUpdate.TabIndex = 9;
this.btnUpdate.Text = "修改";
this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
// 
// btnDelRec
// 
this.btnDelRec.Location = new System.Drawing.Point(576, 137);
this.btnDelRec.Name = "btnDelRec";
this.btnDelRec.Size = new System.Drawing.Size(80, 26);
this.btnDelRec.TabIndex = 10;
this.btnDelRec.Text = "删除记录";
this.btnDelRec.Click += new System.EventHandler(this.btnDelRec_Click);
// 
// btnExportExcel4Dg
// 
this.btnExportExcel4Dg.Location = new System.Drawing.Point(664, 137);
this.btnExportExcel4Dg.Name = "btnExportExcel4Dg";
this.btnExportExcel4Dg.Size = new System.Drawing.Size(80, 26);
this.btnExportExcel4Dg.TabIndex = 11;
this.btnExportExcel4Dg.Text = "导出Excel";
this.btnExportExcel4Dg.Click += new System.EventHandler(this.btnExportExcel4Dg_Click);
// 
// btnQuery
// 
this.btnQuery.Location = new System.Drawing.Point(328, 137);
this.btnQuery.Name = "btnQuery";
this.btnQuery.Size = new System.Drawing.Size(80, 26);
this.btnQuery.TabIndex = 12;
this.btnQuery.Text = "查询";
this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
// 
// lblRecNum
// 
this.lblRecNum.Location = new System.Drawing.Point(752, 144);
this.lblRecNum.Name = "lblRecNum";
this.lblRecNum.Size = new System.Drawing.Size(112, 16);
this.lblRecNum.TabIndex = 13 ;
this.lblRecNum.Text = "记录数：";
// 
// lvUserCodePath
// 
this.lvvUserCodePath.Dock = System.Windows.Forms.DockStyle.Fill;
this.lvvUserCodePath.Location = new System.Drawing.Point(0, 176);
this.lvvUserCodePath.Name = "lvvUserCodePath";
this.lvvUserCodePath.Size = new System.Drawing.Size(1000, 524);
this.lvvUserCodePath.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvvUserCodePath_ColumnClick);
this.lvvUserCodePath.TabIndex = 14;
this.lvvUserCodePath.View = System.Windows.Forms.View.Details;
this.lvvUserCodePath.Click += new System.EventHandler(this.lvvUserCodePath_Click);
this.gbQueryCondition.Controls.Add(this.lblUserId);
this.gbQueryCondition.Controls.Add(this.cboUserId);
this.gbQueryCondition.Controls.Add(this.lblPrjId);
this.gbQueryCondition.Controls.Add(this.cboPrjId);
this.gbQueryCondition.Controls.Add(this.lblCodeTypeId);
this.gbQueryCondition.Controls.Add(this.cboCodeTypeId);
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
this.gbQueryCondition.TabIndex = 15;
this.gbQueryCondition.TabStop = false;
this.gbQueryCondition.Text = "查询条件";
// 
// frmUserCodePath_QD_LV
// 
this.ClientSize = new System.Drawing.Size(1000, 700);
this.Controls.Add(this.lvvUserCodePath);
this.Controls.Add(this.gbQueryCondition);
this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
this.Name = "frmUserCodePath_QD_LV";
this.Text = "frmUserCodePath_QD_LV";
this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
this.Load += new System.EventHandler(this.frmUserCodePath_QD_Load);
this.ResumeLayout(false);
}
#endregion
private System.Windows.Forms.Label lblUserId;
private System.Windows.Forms.ComboBox cboUserId;
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
}
}