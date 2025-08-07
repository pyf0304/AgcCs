
///----------------------
///生成代码版本：2012.01.02.1
///生成日期：2012/10/17
///生成者：潘以锋
///工程名称：AGC_CSV7
///工程ID：0005
///模块中文名：字段、表维护
///模块英文名：Table_Field
///注意：1、需要数据底层（PubDataBase.dll）的版本：2011.05.08.1
///       2、需要公共函数层（TzPubFunction.dll）的版本：2011.05.08.1
///========================
namespace AGC_CSV7
{
/// <summary>
///		frmPrjTab_UI 的摘要说明。
/// </summary>
partial class frmPrjTab_UI
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
this.lblTabId = new System.Windows.Forms.Label();
this.txtTabId = new System.Windows.Forms.TextBox();
this.lblTabName = new System.Windows.Forms.Label();
this.txtTabName = new System.Windows.Forms.TextBox();
this.lblTabCnName = new System.Windows.Forms.Label();
this.txtTabCnName = new System.Windows.Forms.TextBox();
this.lblPrjId = new System.Windows.Forms.Label();
this.cboPrjId = new System.Windows.Forms.ComboBox();
this.lblObjId = new System.Windows.Forms.Label();
this.cboObjId = new System.Windows.Forms.ComboBox();
this.lblIsNeedTransCode = new System.Windows.Forms.Label();
this.chkIsNeedTransCode = new System.Windows.Forms.CheckBox();
this.lblSQLDSTypeId = new System.Windows.Forms.Label();
this.cboSQLDSTypeId = new System.Windows.Forms.ComboBox();
this.lblTabStateId = new System.Windows.Forms.Label();
this.cboTabStateId = new System.Windows.Forms.ComboBox();
this.lblTabName_B = new System.Windows.Forms.Label();
this.txtTabName_B = new System.Windows.Forms.TextBox();
this.lblIsParaTab = new System.Windows.Forms.Label();
this.chkIsParaTab = new System.Windows.Forms.CheckBox();
this.lblIsNationStandard = new System.Windows.Forms.Label();
this.chkIsNationStandard = new System.Windows.Forms.CheckBox();
this.lblIsArchive = new System.Windows.Forms.Label();
this.chkIsArchive = new System.Windows.Forms.CheckBox();
this.lblIsChecked = new System.Windows.Forms.Label();
this.chkIsChecked = new System.Windows.Forms.CheckBox();
this.lblErrMsg = new System.Windows.Forms.Label();
this.txtErrMsg = new System.Windows.Forms.TextBox();
this.lblFuncModuleId = new System.Windows.Forms.Label();
this.cboFuncModuleId = new System.Windows.Forms.ComboBox();
this.lblDataBaseName = new System.Windows.Forms.Label();
this.txtDataBaseName = new System.Windows.Forms.TextBox();
this.lblOwner = new System.Windows.Forms.Label();
this.txtOwner = new System.Windows.Forms.TextBox();
this.lblMemo = new System.Windows.Forms.Label();
this.txtMemo = new System.Windows.Forms.TextBox();
this.lblMsg = new System.Windows.Forms.Label();
this.btnOKUpd = new System.Windows.Forms.Button();
this.btnClose = new System.Windows.Forms.Button();
this.SuspendLayout();
//
// lblTabId
//
this.lblTabId.Location = new System.Drawing.Point(10, 10);
this.lblTabId.Name = "lblTabId";
this.lblTabId.Size = new System.Drawing.Size(70, 18);
this.lblTabId.TabIndex = 1;
this.lblTabId.Text = "表ID";
//
// txtTabId
//
this.txtTabId.Location = new System.Drawing.Point(90, 10);
this.txtTabId.Name = "txtTabId";
this.txtTabId.Size = new System.Drawing.Size(100, 20);
this.txtTabId.TabIndex = 2;
this.txtTabId.Text = "";
//
// lblTabName
//
this.lblTabName.Location = new System.Drawing.Point(260, 10);
this.lblTabName.Name = "lblTabName";
this.lblTabName.Size = new System.Drawing.Size(70, 18);
this.lblTabName.TabIndex = 3;
this.lblTabName.Text = "表名";
//
// txtTabName
//
this.txtTabName.Location = new System.Drawing.Point(340, 10);
this.txtTabName.Name = "txtTabName";
this.txtTabName.Size = new System.Drawing.Size(100, 20);
this.txtTabName.TabIndex = 4;
this.txtTabName.Text = "";
//
// lblTabCnName
//
this.lblTabCnName.Location = new System.Drawing.Point(10, 40);
this.lblTabCnName.Name = "lblTabCnName";
this.lblTabCnName.Size = new System.Drawing.Size(70, 18);
this.lblTabCnName.TabIndex = 5;
this.lblTabCnName.Text = "表中文名";
//
// txtTabCnName
//
this.txtTabCnName.Location = new System.Drawing.Point(90, 40);
this.txtTabCnName.Name = "txtTabCnName";
this.txtTabCnName.Size = new System.Drawing.Size(100, 20);
this.txtTabCnName.TabIndex = 6;
this.txtTabCnName.Text = "";
//
// lblPrjId
//
this.lblPrjId.Location = new System.Drawing.Point(260, 40);
this.lblPrjId.Name = "lblPrjId";
this.lblPrjId.Size = new System.Drawing.Size(70, 18);
this.lblPrjId.TabIndex = 7;
this.lblPrjId.Text = "工程ID";
//
// cboPrjId
//
this.cboPrjId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
this.cboPrjId.Location = new System.Drawing.Point(340, 40);
this.cboPrjId.Name = "cboPrjId";
this.cboPrjId.Size = new System.Drawing.Size(100, 20);
this.cboPrjId.TabIndex = 8;
this.cboPrjId.Text = "";
//
// lblObjId
//
this.lblObjId.Location = new System.Drawing.Point(10, 70);
this.lblObjId.Name = "lblObjId";
this.lblObjId.Size = new System.Drawing.Size(70, 18);
this.lblObjId.TabIndex = 9;
this.lblObjId.Text = "所属对象";
//
// cboObjId
//
this.cboObjId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
this.cboObjId.Location = new System.Drawing.Point(90, 70);
this.cboObjId.Name = "cboObjId";
this.cboObjId.Size = new System.Drawing.Size(100, 20);
this.cboObjId.TabIndex = 10;
this.cboObjId.Text = "";
//
// chkIsNeedTransCode
//
this.chkIsNeedTransCode.Location = new System.Drawing.Point(260, 70);
this.chkIsNeedTransCode.Name = "chkIsNeedTransCode";
this.chkIsNeedTransCode.Size = new System.Drawing.Size(100, 20);
this.chkIsNeedTransCode.TabIndex = 11;
this.chkIsNeedTransCode.Text = "是否需要转换代码";
//
// lblSQLDSTypeId
//
this.lblSQLDSTypeId.Location = new System.Drawing.Point(10, 100);
this.lblSQLDSTypeId.Name = "lblSQLDSTypeId";
this.lblSQLDSTypeId.Size = new System.Drawing.Size(70, 18);
this.lblSQLDSTypeId.TabIndex = 12;
this.lblSQLDSTypeId.Text = "数据源类型";
//
// cboSQLDSTypeId
//
this.cboSQLDSTypeId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
this.cboSQLDSTypeId.Location = new System.Drawing.Point(90, 100);
this.cboSQLDSTypeId.Name = "cboSQLDSTypeId";
this.cboSQLDSTypeId.Size = new System.Drawing.Size(100, 20);
this.cboSQLDSTypeId.TabIndex = 13;
this.cboSQLDSTypeId.Text = "";
//
// lblTabStateId
//
this.lblTabStateId.Location = new System.Drawing.Point(260, 100);
this.lblTabStateId.Name = "lblTabStateId";
this.lblTabStateId.Size = new System.Drawing.Size(70, 18);
this.lblTabStateId.TabIndex = 14;
this.lblTabStateId.Text = "表状态ID";
//
// cboTabStateId
//
this.cboTabStateId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
this.cboTabStateId.Location = new System.Drawing.Point(340, 100);
this.cboTabStateId.Name = "cboTabStateId";
this.cboTabStateId.Size = new System.Drawing.Size(100, 20);
this.cboTabStateId.TabIndex = 15;
this.cboTabStateId.Text = "";
//
// lblTabName_B
//
this.lblTabName_B.Location = new System.Drawing.Point(10, 130);
this.lblTabName_B.Name = "lblTabName_B";
this.lblTabName_B.Size = new System.Drawing.Size(70, 18);
this.lblTabName_B.TabIndex = 16;
this.lblTabName_B.Text = "表名_后备";
//
// txtTabName_B
//
this.txtTabName_B.Location = new System.Drawing.Point(90, 130);
this.txtTabName_B.Name = "txtTabName_B";
this.txtTabName_B.Size = new System.Drawing.Size(100, 20);
this.txtTabName_B.TabIndex = 17;
this.txtTabName_B.Text = "";
//
// chkIsParaTab
//
this.chkIsParaTab.Location = new System.Drawing.Point(260, 130);
this.chkIsParaTab.Name = "chkIsParaTab";
this.chkIsParaTab.Size = new System.Drawing.Size(100, 20);
this.chkIsParaTab.TabIndex = 18;
this.chkIsParaTab.Text = "是否参数表";
//
// chkIsNationStandard
//
this.chkIsNationStandard.Location = new System.Drawing.Point(10, 160);
this.chkIsNationStandard.Name = "chkIsNationStandard";
this.chkIsNationStandard.Size = new System.Drawing.Size(100, 20);
this.chkIsNationStandard.TabIndex = 19;
this.chkIsNationStandard.Text = "是否国标";
//
// chkIsArchive
//
this.chkIsArchive.Location = new System.Drawing.Point(260, 160);
this.chkIsArchive.Name = "chkIsArchive";
this.chkIsArchive.Size = new System.Drawing.Size(100, 20);
this.chkIsArchive.TabIndex = 20;
this.chkIsArchive.Text = "是否存档";
//
// chkIsChecked
//
this.chkIsChecked.Location = new System.Drawing.Point(10, 190);
this.chkIsChecked.Name = "chkIsChecked";
this.chkIsChecked.Size = new System.Drawing.Size(100, 20);
this.chkIsChecked.TabIndex = 21;
this.chkIsChecked.Text = "是否核实";
//
// lblErrMsg
//
this.lblErrMsg.Location = new System.Drawing.Point(260, 190);
this.lblErrMsg.Name = "lblErrMsg";
this.lblErrMsg.Size = new System.Drawing.Size(70, 18);
this.lblErrMsg.TabIndex = 22;
this.lblErrMsg.Text = "错误信息";
//
// txtErrMsg
//
this.txtErrMsg.Location = new System.Drawing.Point(340, 190);
this.txtErrMsg.Name = "txtErrMsg";
this.txtErrMsg.Size = new System.Drawing.Size(100, 20);
this.txtErrMsg.TabIndex = 23;
this.txtErrMsg.Text = "";
//
// lblFuncModuleId
//
this.lblFuncModuleId.Location = new System.Drawing.Point(10, 220);
this.lblFuncModuleId.Name = "lblFuncModuleId";
this.lblFuncModuleId.Size = new System.Drawing.Size(70, 18);
this.lblFuncModuleId.TabIndex = 24;
this.lblFuncModuleId.Text = "功能模块Id";
//
// cboFuncModuleId
//
this.cboFuncModuleId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
this.cboFuncModuleId.Location = new System.Drawing.Point(90, 220);
this.cboFuncModuleId.Name = "cboFuncModuleId";
this.cboFuncModuleId.Size = new System.Drawing.Size(100, 20);
this.cboFuncModuleId.TabIndex = 25;
this.cboFuncModuleId.Text = "";
//
// lblDataBaseName
//
this.lblDataBaseName.Location = new System.Drawing.Point(260, 220);
this.lblDataBaseName.Name = "lblDataBaseName";
this.lblDataBaseName.Size = new System.Drawing.Size(70, 18);
this.lblDataBaseName.TabIndex = 26;
this.lblDataBaseName.Text = "数据库名";
//
// txtDataBaseName
//
this.txtDataBaseName.Location = new System.Drawing.Point(340, 220);
this.txtDataBaseName.Name = "txtDataBaseName";
this.txtDataBaseName.Size = new System.Drawing.Size(100, 20);
this.txtDataBaseName.TabIndex = 27;
this.txtDataBaseName.Text = "";
//
// lblOwner
//
this.lblOwner.Location = new System.Drawing.Point(10, 250);
this.lblOwner.Name = "lblOwner";
this.lblOwner.Size = new System.Drawing.Size(70, 18);
this.lblOwner.TabIndex = 28;
this.lblOwner.Text = "拥有者";
//
// txtOwner
//
this.txtOwner.Location = new System.Drawing.Point(90, 250);
this.txtOwner.Name = "txtOwner";
this.txtOwner.Size = new System.Drawing.Size(100, 20);
this.txtOwner.TabIndex = 29;
this.txtOwner.Text = "";
//
// lblMemo
//
this.lblMemo.Location = new System.Drawing.Point(260, 250);
this.lblMemo.Name = "lblMemo";
this.lblMemo.Size = new System.Drawing.Size(70, 18);
this.lblMemo.TabIndex = 30;
this.lblMemo.Text = "说明";
//
// txtMemo
//
this.txtMemo.Location = new System.Drawing.Point(340, 250);
this.txtMemo.Name = "txtMemo";
this.txtMemo.Size = new System.Drawing.Size(100, 20);
this.txtMemo.TabIndex = 31;
this.txtMemo.Text = "";
// 
// btnOKUpd
// 
this.btnOKUpd.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
this.btnOKUpd.Location = new System.Drawing.Point(125, 65);
this.btnOKUpd.Name = "btnOKUpd";
this.btnOKUpd.Size = new System.Drawing.Size(80, 30);
this.btnOKUpd.TabIndex = 32;
this.btnOKUpd.Text = "添加";
this.btnOKUpd.Click += new System.EventHandler(this.btnOKUpd_Click);
// 
// btnClose
// 
this.btnClose.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
this.btnClose.Location = new System.Drawing.Point(245, 65);
this.btnClose.Name = "btnClose";
this.btnClose.Size = new System.Drawing.Size(80, 30);
this.btnClose.TabIndex = 33;
this.btnClose.Text = "关闭";
this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
// 
// lblMsg
// 
this.lblMsg.Location = new System.Drawing.Point(125, 95);
this.lblMsg.Name = "lblMsg";
this.lblMsg.Size = new System.Drawing.Size(128, 16);
this.lblMsg.TabIndex = 34;
// 
// frmPrjTab_UI
// 
this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
this.ClientSize = new System.Drawing.Size(530, 135);
this.Controls.Add(this.lblTabId);
this.Controls.Add(this.txtTabId);
this.Controls.Add(this.lblTabName);
this.Controls.Add(this.txtTabName);
this.Controls.Add(this.lblTabCnName);
this.Controls.Add(this.txtTabCnName);
this.Controls.Add(this.lblPrjId);
this.Controls.Add(this.cboPrjId);
this.Controls.Add(this.lblObjId);
this.Controls.Add(this.cboObjId);
this.Controls.Add(this.chkIsNeedTransCode);
this.Controls.Add(this.lblSQLDSTypeId);
this.Controls.Add(this.cboSQLDSTypeId);
this.Controls.Add(this.lblTabStateId);
this.Controls.Add(this.cboTabStateId);
this.Controls.Add(this.lblTabName_B);
this.Controls.Add(this.txtTabName_B);
this.Controls.Add(this.chkIsParaTab);
this.Controls.Add(this.chkIsNationStandard);
this.Controls.Add(this.chkIsArchive);
this.Controls.Add(this.chkIsChecked);
this.Controls.Add(this.lblErrMsg);
this.Controls.Add(this.txtErrMsg);
this.Controls.Add(this.lblFuncModuleId);
this.Controls.Add(this.cboFuncModuleId);
this.Controls.Add(this.lblDataBaseName);
this.Controls.Add(this.txtDataBaseName);
this.Controls.Add(this.lblOwner);
this.Controls.Add(this.txtOwner);
this.Controls.Add(this.lblMemo);
this.Controls.Add(this.txtMemo);
this.Controls.Add(this.btnClose);
this.Controls.Add(this.btnOKUpd);
this.Controls.Add(this.lblMsg);
this.Name = "frmPrjTab_UI";
this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
this.Text = "frmPrjTab_UI";
this.Load += new System.EventHandler(this.frmPrjTab_UI_Load);
this.ResumeLayout(false);
}
#endregion
private System.Windows.Forms.Label lblTabId;
private System.Windows.Forms.TextBox txtTabId;
private System.Windows.Forms.Label lblTabName;
private System.Windows.Forms.TextBox txtTabName;
private System.Windows.Forms.Label lblTabCnName;
private System.Windows.Forms.TextBox txtTabCnName;
private System.Windows.Forms.Label lblPrjId;
private System.Windows.Forms.ComboBox cboPrjId;
private System.Windows.Forms.Label lblObjId;
private System.Windows.Forms.ComboBox cboObjId;
private System.Windows.Forms.Label lblIsNeedTransCode;
private System.Windows.Forms.CheckBox chkIsNeedTransCode;
private System.Windows.Forms.Label lblSQLDSTypeId;
private System.Windows.Forms.ComboBox cboSQLDSTypeId;
private System.Windows.Forms.Label lblTabStateId;
private System.Windows.Forms.ComboBox cboTabStateId;
private System.Windows.Forms.Label lblTabName_B;
private System.Windows.Forms.TextBox txtTabName_B;
private System.Windows.Forms.Label lblIsParaTab;
private System.Windows.Forms.CheckBox chkIsParaTab;
private System.Windows.Forms.Label lblIsNationStandard;
private System.Windows.Forms.CheckBox chkIsNationStandard;
private System.Windows.Forms.Label lblIsArchive;
private System.Windows.Forms.CheckBox chkIsArchive;
private System.Windows.Forms.Label lblIsChecked;
private System.Windows.Forms.CheckBox chkIsChecked;
private System.Windows.Forms.Label lblErrMsg;
private System.Windows.Forms.TextBox txtErrMsg;
private System.Windows.Forms.Label lblFuncModuleId;
private System.Windows.Forms.ComboBox cboFuncModuleId;
private System.Windows.Forms.Label lblDataBaseName;
private System.Windows.Forms.TextBox txtDataBaseName;
private System.Windows.Forms.Label lblOwner;
private System.Windows.Forms.TextBox txtOwner;
private System.Windows.Forms.Label lblMemo;
private System.Windows.Forms.TextBox txtMemo;
private System.Windows.Forms.Label lblMsg; 
private System.Windows.Forms.Button btnOKUpd;
private System.Windows.Forms.Button btnClose;
}
}