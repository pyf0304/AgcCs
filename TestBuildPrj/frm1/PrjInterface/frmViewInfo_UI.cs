
///----------------------
///生成代码版本：2012.01.02.1
///生成日期：2012/10/17
///生成者：潘以锋
///工程名称：AGC_CSV7
///工程ID：0005
///模块中文名：项目界面管理
///模块英文名：PrjInterface
///注意：1、需要数据底层（PubDataBase.dll）的版本：2011.05.08.1
///       2、需要公共函数层（TzPubFunction.dll）的版本：2011.05.08.1
///========================
//生成与表相关的控件控制层代码
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using com.taishsoft.commdb;
using AGC_CSV7.Entity;
using AGC_CSV7.BusinessLogic;
using com.taishsoft.util;
using CommFunc4Win;

namespace AGC_CSV7
{
/// <summary>
///		frmViewInfo_UI 的摘要说明。
/// </summary>
public partial class frmViewInfo_UI : System.Windows.Forms.Form
{
clsViewInfoEN objViewInfoEN = null;
private string mstrViewId;		//用于传递关键字值的变量
public string OperateType;
public IBindListView iBindListView = null;
public frmViewInfo_UI()
{
// 该调用是 Windows.Forms 窗体设计器所必需的。
InitializeComponent();

// TODO: 在 InitializeComponent 调用后添加任何初始化

}
private void frmViewInfo_UI_Load(object sender, System.EventArgs e)
{
// 在此处放置用户代码以初始化页面
//1、为下拉框设置数据源，绑定列表数据
this.SetAllComboBox();
if (OperateType == "Update")
{
ShowData(mstrViewId);
btnOKUpd.Text = "确认修改";
}
else
{
AddViewInfoRecord();
}

}
/// <summary>
/// 下拉框的绑定函数
/// </summary>
private void SetAllComboBox()
{
this.BindCbo_ViewTypeCode(this.cboViewTypeCode);
this.BindCbo_ApplicationTypeId(this.cboApplicationTypeId);
this.BindCbo_FuncModuleId(this.cboFuncModuleId);
this.BindCbo_UserId(this.cboUserId);
this.BindCbo_PrjId(this.cboPrjId);
this.BindCbo_DetailTabId(this.cboDetailTabId);
this.BindCbo_ViewGroupId(this.cboViewGroupId);
this.BindCbo_INRelaTabId(this.cboINRelaTabId);
this.BindCbo_INSQLDSTypeId(this.cboINSQLDSTypeId);
this.BindCbo_OUTRelaTabId(this.cboOUTRelaTabId);
this.BindCbo_OUTSQLDSTypeId(this.cboOUTSQLDSTypeId);
}
public string ViewId
{
get
{
return txtViewId.Text.Trim();
}
set
{
txtViewId.Text = value.ToString();
}
}

public string ViewName
{
get
{
return txtViewName.Text.Trim();
}
set
{
txtViewName.Text = value.ToString();
}
}

public string ViewTypeCode
{
get
{
if (cboViewTypeCode.SelectedValue.ToString() == "0")
return "";
return cboViewTypeCode.SelectedValue.ToString();
}
set
{
if (value == "")
{
cboViewTypeCode.SelectedValue = "0";
}
else
{
cboViewTypeCode.SelectedValue = value;
}
}
}

public string ApplicationTypeId
{
get
{
if (cboApplicationTypeId.SelectedValue.ToString() == "0")
return "";
return cboApplicationTypeId.SelectedValue.ToString();
}
set
{
if (value == "")
{
cboApplicationTypeId.SelectedValue = "0";
}
else
{
cboApplicationTypeId.SelectedValue = value;
}
}
}

public string FuncModuleId
{
get
{
if (cboFuncModuleId.SelectedValue.ToString() == "0")
return "";
return cboFuncModuleId.SelectedValue.ToString();
}
set
{
if (value == "")
{
cboFuncModuleId.SelectedValue = "0";
}
else
{
cboFuncModuleId.SelectedValue = value;
}
}
}

public string DataBaseName
{
get
{
return txtDataBaseName.Text.Trim();
}
set
{
txtDataBaseName.Text = value.ToString();
}
}

public string KeyForMainTab
{
get
{
return txtKeyForMainTab.Text.Trim();
}
set
{
txtKeyForMainTab.Text = value.ToString();
}
}

public string KeyForDetailTab
{
get
{
return txtKeyForDetailTab.Text.Trim();
}
set
{
txtKeyForDetailTab.Text = value.ToString();
}
}

public bool IsNeedSort
{
get
{
return chkIsNeedSort.Checked;
}
set
{
chkIsNeedSort.Checked = value;
}
}

public bool IsNeedTransCode
{
get
{
return chkIsNeedTransCode.Checked;
}
set
{
chkIsNeedTransCode.Checked = value;
}
}

public string UserId
{
get
{
if (cboUserId.SelectedValue.ToString() == "0")
return "";
return cboUserId.SelectedValue.ToString();
}
set
{
if (value == "")
{
cboUserId.SelectedValue = "0";
}
else
{
cboUserId.SelectedValue = value;
}
}
}

public string PrjId
{
get
{
if (cboPrjId.SelectedValue.ToString() == "0")
return "";
return cboPrjId.SelectedValue.ToString();
}
set
{
if (value == "")
{
cboPrjId.SelectedValue = "0";
}
else
{
cboPrjId.SelectedValue = value;
}
}
}

public string ViewFunction
{
get
{
return txtViewFunction.Text.Trim();
}
set
{
txtViewFunction.Text = value.ToString();
}
}

public string ViewDetail
{
get
{
return txtViewDetail.Text.Trim();
}
set
{
txtViewDetail.Text = value.ToString();
}
}

public string DefaMenuName
{
get
{
return txtDefaMenuName.Text.Trim();
}
set
{
txtDefaMenuName.Text = value.ToString();
}
}

public string DetailTabId
{
get
{
if (cboDetailTabId.SelectedValue.ToString() == "0")
return "";
return cboDetailTabId.SelectedValue.ToString();
}
set
{
if (value == "")
{
cboDetailTabId.SelectedValue = "0";
}
else
{
cboDetailTabId.SelectedValue = value;
}
}
}

public string FileName
{
get
{
return txtFileName.Text.Trim();
}
set
{
txtFileName.Text = value.ToString();
}
}

public string FilePath
{
get
{
return txtFilePath.Text.Trim();
}
set
{
txtFilePath.Text = value.ToString();
}
}

public string MainTabId
{
get
{
return txtMainTabId.Text.Trim();
}
set
{
txtMainTabId.Text = value.ToString();
}
}

public string ViewCnName
{
get
{
return txtViewCnName.Text.Trim();
}
set
{
txtViewCnName.Text = value.ToString();
}
}

public string ViewGroupId
{
get
{
if (cboViewGroupId.SelectedValue.ToString() == "0")
return "";
return cboViewGroupId.SelectedValue.ToString();
}
set
{
if (value == "")
{
cboViewGroupId.SelectedValue = "0";
}
else
{
cboViewGroupId.SelectedValue = value;
}
}
}

public string INRelaTabId
{
get
{
if (cboINRelaTabId.SelectedValue.ToString() == "0")
return "";
return cboINRelaTabId.SelectedValue.ToString();
}
set
{
if (value == "")
{
cboINRelaTabId.SelectedValue = "0";
}
else
{
cboINRelaTabId.SelectedValue = value;
}
}
}

public string INSQLDSTypeId
{
get
{
if (cboINSQLDSTypeId.SelectedValue.ToString() == "0")
return "";
return cboINSQLDSTypeId.SelectedValue.ToString();
}
set
{
if (value == "")
{
cboINSQLDSTypeId.SelectedValue = "0";
}
else
{
cboINSQLDSTypeId.SelectedValue = value;
}
}
}

public string OUTRelaTabId
{
get
{
if (cboOUTRelaTabId.SelectedValue.ToString() == "0")
return "";
return cboOUTRelaTabId.SelectedValue.ToString();
}
set
{
if (value == "")
{
cboOUTRelaTabId.SelectedValue = "0";
}
else
{
cboOUTRelaTabId.SelectedValue = value;
}
}
}

public string OUTSQLDSTypeId
{
get
{
if (cboOUTSQLDSTypeId.SelectedValue.ToString() == "0")
return "";
return cboOUTSQLDSTypeId.SelectedValue.ToString();
}
set
{
if (value == "")
{
cboOUTSQLDSTypeId.SelectedValue = "0";
}
else
{
cboOUTSQLDSTypeId.SelectedValue = value;
}
}
}

public string DetailTabType
{
get
{
return txtDetailTabType.Text.Trim();
}
set
{
txtDetailTabType.Text = value.ToString();
}
}

public string DetailViewId
{
get
{
return txtDetailViewId.Text.Trim();
}
set
{
txtDetailViewId.Text = value.ToString();
}
}

public string MainTabType
{
get
{
return txtMainTabType.Text.Trim();
}
set
{
txtMainTabType.Text = value.ToString();
}
}

public string MainViewId
{
get
{
return txtMainViewId.Text.Trim();
}
set
{
txtMainViewId.Text = value.ToString();
}
}

public string UpdDate
{
get
{
return txtUpdDate.Text.Trim();
}
set
{
txtUpdDate.Text = value.ToString();
}
}


public void SetKeyReadOnly(bool bolReadonly)
{
txtViewId.ReadOnly = bolReadonly;
}
public void Clear()
{
txtViewId.Text = "";
txtViewName.Text = "";
cboViewTypeCode.SelectedIndex = 0;
cboApplicationTypeId.SelectedIndex = 0;
cboFuncModuleId.SelectedIndex = 0;
txtDataBaseName.Text = "";
txtKeyForMainTab.Text = "";
txtKeyForDetailTab.Text = "";
chkIsNeedSort.Checked = false;
chkIsNeedTransCode.Checked = false;
cboUserId.SelectedIndex = 0;
cboPrjId.SelectedIndex = 0;
txtViewFunction.Text = "";
txtViewDetail.Text = "";
txtDefaMenuName.Text = "";
cboDetailTabId.SelectedIndex = 0;
txtFileName.Text = "";
txtFilePath.Text = "";
txtMainTabId.Text = "";
txtViewCnName.Text = "";
cboViewGroupId.SelectedIndex = 0;
cboINRelaTabId.SelectedIndex = 0;
cboINSQLDSTypeId.SelectedIndex = 0;
cboOUTRelaTabId.SelectedIndex = 0;
cboOUTSQLDSTypeId.SelectedIndex = 0;
txtDetailTabType.Text = "";
txtDetailViewId.Text = "";
txtMainTabType.Text = "";
txtMainViewId.Text = "";
txtUpdDate.Text = "";
}
/// <summary>
/// 设置该控件在插入状态下的缺省值
/// 一般规则：
///		1、如果是整型就默认为0；
///		2、如果是浮点型不默认为0.0；
///		3、如果是日期型就默认为当前的日期；
///		4、如果是位(bit)型就默认为false;
///		这些默认值可以再行修改
/// </summary>
public void SetDefaultValue()
{
txtViewId.Text = "";
txtViewName.Text = "";
cboViewTypeCode.SelectedIndex = 0;
cboApplicationTypeId.SelectedIndex = 0;
cboFuncModuleId.SelectedIndex = 0;
txtDataBaseName.Text = "";
txtKeyForMainTab.Text = "";
txtKeyForDetailTab.Text = "";
chkIsNeedSort.Checked = false;
chkIsNeedTransCode.Checked = false;
cboUserId.SelectedIndex = 0;
cboPrjId.SelectedIndex = 0;
txtViewFunction.Text = "";
txtViewDetail.Text = "";
txtDefaMenuName.Text = "";
cboDetailTabId.SelectedIndex = 0;
txtFileName.Text = "";
txtFilePath.Text = "";
txtMainTabId.Text = "";
txtViewCnName.Text = "";
cboViewGroupId.SelectedIndex = 0;
cboINRelaTabId.SelectedIndex = 0;
cboINSQLDSTypeId.SelectedIndex = 0;
cboOUTRelaTabId.SelectedIndex = 0;
cboOUTSQLDSTypeId.SelectedIndex = 0;
txtDetailTabType.Text = "";
txtDetailViewId.Text = "";
txtMainTabType.Text = "";
txtMainViewId.Text = "";
txtUpdDate.Text = "";
}
/// <summary>
/// 校验自定义控件中自子控件的类型数值是否是合法正确的。
/// 一般规则：
///		1、首先校验类型：整型、浮点型、日期型等，
///			这些代码由自动生成代码帮助生成
///		2、校验最值，即最大值和最小值等
///			这些代码由自动生成代码帮助生成
///		这些生成内容可以修改
/// </summary>
/// <returns></returns>
public bool IsValid(ref string strResult)
{
return true;
}
/// <summary>
/// 功能：获取当前月的字符串
/// 月的格式：
///    月的字符串的格式有三种：
///		1、YYYYMM。	例如200501
///		2、YYYY-MM-DD	例如2005-01
///		3、YYYY/MM/DD	例如2005/01
/// </summary>
/// <param name="intFormat">月的格式，共有3种，传入参数0,1，2
///							参数不同，函数返回值就不同，
///							参见上面的月的格式
///	</param>
/// <returns>返回当前月的字符串</returns>
public string getCurrMonth(int intFormat)
{
string strCurrMonth;
string strYear, strMonth;
int intYear, intMonth;
intYear = System.DateTime.Today.Year;
intMonth = System.DateTime.Today.Month;
strYear = intYear.ToString().Trim();
if (intMonth>9) strMonth = intMonth.ToString().Trim();
else strMonth = "0" + intMonth.ToString().Trim();
strCurrMonth = strYear + strMonth;
switch(intFormat)
{
case 0:
strCurrMonth = strYear + strMonth;
break;
case 1:
strCurrMonth =strYear + "-" + strMonth;
break;
case 2:
strCurrMonth =strYear + "/" + strMonth;
break;
}
return strCurrMonth;
}
/// <summary>
/// 功能：获取当前日期的字符串
/// 日期格式：
///    日期的字符串的格式有三种：
///		1、YYYYMMDD。	例如20050120
///		2、YYYY-MM-DD	例如2005-01-20
///		3、YYYY/MM/DD	例如2005/01/20
/// </summary>
/// <param name="intFormat">日期格式，共有3种，传入参数0,1，2
///							参数不同，函数返回值就不同，
///							参见上面的日期格式
///	</param>
/// <returns>返回当前日期的字符串</returns>
public string getTodayStr(int intFormat)
{
string strToday;
string strYear, strMonth, strDay;
int intYear, intMonth, intDay;
intYear = System.DateTime.Today.Year;
intMonth = System.DateTime.Today.Month;
intDay = System.DateTime.Today.Day;
strYear = intYear.ToString().Trim();
if (intMonth>9) strMonth = intMonth.ToString().Trim();
else strMonth = "0" + intMonth.ToString().Trim();
if (intDay>9) strDay = intDay.ToString().Trim();
else strDay = "0" + intDay.ToString().Trim();
strToday = strYear + strMonth + strDay;
switch(intFormat)
{
case 0:
strToday = strYear + strMonth + strDay;
break;
case 1:
strToday =strYear + "-" + strMonth + "-" + strDay;
break;
case 2:
strToday =strYear + "/" + strMonth + "/" + strDay;
break;
}
return strToday;
}
public System.Data.DataTable GetViewTypeCode()
{
//获取某学院所有专业信息
string strSQL = "select ViewTypeCode, ViewTypeName from ViewTypeCodeTab ";
clsSpecSQLforSql mySql=new clsSpecSQLforSql();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}
public void BindCbo_ViewTypeCode(System.Windows.Forms.ComboBox objComboBox)
{
//为数据源为表的下拉框设置内容
System.Data.DataTable objDT = GetViewTypeCode();
clsViewTypeCodeTabEN objViewTypeCodeTabEN;
//初始化一个对象列表
ArrayList ViewTypeCodeTabList = new ArrayList();
//插入第0项。在第0项中插入"请选择..."，为了方便用户，与WEB方式类似。
objViewTypeCodeTabEN = new clsViewTypeCodeTabEN();
objViewTypeCodeTabEN.ViewTypeCode = "0";
objViewTypeCodeTabEN.ViewTypeName = "请选择...";
ViewTypeCodeTabList.Add(objViewTypeCodeTabEN);
//把DataTable中的所有项均加到对象列表中
foreach(DataRow objRow in objDT.Rows)
{
objViewTypeCodeTabEN = new clsViewTypeCodeTabEN();
objViewTypeCodeTabEN.ViewTypeCode = objRow["ViewTypeCode"].ToString();
objViewTypeCodeTabEN.ViewTypeName = objRow["ViewTypeName"].ToString();
ViewTypeCodeTabList.Add(objViewTypeCodeTabEN);
}
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.DataSource = ViewTypeCodeTabList;
objComboBox.ValueMember="ViewTypeCode";
objComboBox.DisplayMember="ViewTypeName";
objComboBox.SelectedIndex = 0;
}
public System.Data.DataTable GetApplicationTypeId()
{
//获取某学院所有专业信息
string strSQL = "select ApplicationTypeId, ApplicationTypeName from ApplicationType ";
clsSpecSQLforSql mySql=new clsSpecSQLforSql();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}
public void BindCbo_ApplicationTypeId(System.Windows.Forms.ComboBox objComboBox)
{
//为数据源为表的下拉框设置内容
System.Data.DataTable objDT = GetApplicationTypeId();
clsApplicationTypeEN objApplicationTypeEN;
//初始化一个对象列表
ArrayList ApplicationTypeList = new ArrayList();
//插入第0项。在第0项中插入"请选择..."，为了方便用户，与WEB方式类似。
objApplicationTypeEN = new clsApplicationTypeEN();
objApplicationTypeEN.ApplicationTypeId = "0";
objApplicationTypeEN.ApplicationTypeName = "请选择...";
ApplicationTypeList.Add(objApplicationTypeEN);
//把DataTable中的所有项均加到对象列表中
foreach(DataRow objRow in objDT.Rows)
{
objApplicationTypeEN = new clsApplicationTypeEN();
objApplicationTypeEN.ApplicationTypeId = objRow["ApplicationTypeId"].ToString();
objApplicationTypeEN.ApplicationTypeName = objRow["ApplicationTypeName"].ToString();
ApplicationTypeList.Add(objApplicationTypeEN);
}
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.DataSource = ApplicationTypeList;
objComboBox.ValueMember="ApplicationTypeId";
objComboBox.DisplayMember="ApplicationTypeName";
objComboBox.SelectedIndex = 0;
}
public System.Data.DataTable GetFuncModuleId()
{
//获取某学院所有专业信息
string strSQL = "select FuncModuleId, FuncModuleName from FuncModule ";
clsSpecSQLforSql mySql=new clsSpecSQLforSql();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}
public void BindCbo_FuncModuleId(System.Windows.Forms.ComboBox objComboBox)
{
//为数据源为表的下拉框设置内容
System.Data.DataTable objDT = GetFuncModuleId();
clsFuncModuleEN objFuncModuleEN;
//初始化一个对象列表
ArrayList FuncModuleList = new ArrayList();
//插入第0项。在第0项中插入"请选择..."，为了方便用户，与WEB方式类似。
objFuncModuleEN = new clsFuncModuleEN();
objFuncModuleEN.FuncModuleId = "0";
objFuncModuleEN.FuncModuleName = "请选择...";
FuncModuleList.Add(objFuncModuleEN);
//把DataTable中的所有项均加到对象列表中
foreach(DataRow objRow in objDT.Rows)
{
objFuncModuleEN = new clsFuncModuleEN();
objFuncModuleEN.FuncModuleId = objRow["FuncModuleId"].ToString();
objFuncModuleEN.FuncModuleName = objRow["FuncModuleName"].ToString();
FuncModuleList.Add(objFuncModuleEN);
}
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.DataSource = FuncModuleList;
objComboBox.ValueMember="FuncModuleId";
objComboBox.DisplayMember="FuncModuleName";
objComboBox.SelectedIndex = 0;
}
public System.Data.DataTable GetUserId()
{
//获取某学院所有专业信息
string strSQL = "select UserId, UserName from Users ";
clsSpecSQLforSql mySql=new clsSpecSQLforSql();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}
public void BindCbo_UserId(System.Windows.Forms.ComboBox objComboBox)
{
//为数据源为表的下拉框设置内容
System.Data.DataTable objDT = GetUserId();
clsUsersEN objUsersEN;
//初始化一个对象列表
ArrayList UsersList = new ArrayList();
//插入第0项。在第0项中插入"请选择..."，为了方便用户，与WEB方式类似。
objUsersEN = new clsUsersEN();
objUsersEN.UserId = "0";
objUsersEN.UserName = "请选择...";
UsersList.Add(objUsersEN);
//把DataTable中的所有项均加到对象列表中
foreach(DataRow objRow in objDT.Rows)
{
objUsersEN = new clsUsersEN();
objUsersEN.UserId = objRow["UserId"].ToString();
objUsersEN.UserName = objRow["UserName"].ToString();
UsersList.Add(objUsersEN);
}
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.DataSource = UsersList;
objComboBox.ValueMember="UserId";
objComboBox.DisplayMember="UserName";
objComboBox.SelectedIndex = 0;
}
public System.Data.DataTable GetPrjId()
{
//获取某学院所有专业信息
string strSQL = "select PrjId, PrjName from Projects ";
clsSpecSQLforSql mySql=new clsSpecSQLforSql();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}
public void BindCbo_PrjId(System.Windows.Forms.ComboBox objComboBox)
{
//为数据源为表的下拉框设置内容
System.Data.DataTable objDT = GetPrjId();
clsProjectsEN objProjectsEN;
//初始化一个对象列表
ArrayList ProjectsList = new ArrayList();
//插入第0项。在第0项中插入"请选择..."，为了方便用户，与WEB方式类似。
objProjectsEN = new clsProjectsEN();
objProjectsEN.PrjId = "0";
objProjectsEN.PrjName = "请选择...";
ProjectsList.Add(objProjectsEN);
//把DataTable中的所有项均加到对象列表中
foreach(DataRow objRow in objDT.Rows)
{
objProjectsEN = new clsProjectsEN();
objProjectsEN.PrjId = objRow["PrjId"].ToString();
objProjectsEN.PrjName = objRow["PrjName"].ToString();
ProjectsList.Add(objProjectsEN);
}
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.DataSource = ProjectsList;
objComboBox.ValueMember="PrjId";
objComboBox.DisplayMember="PrjName";
objComboBox.SelectedIndex = 0;
}
public System.Data.DataTable GetDetailTabId()
{
//获取某学院所有专业信息
string strSQL = "select TabId, TabName from PrjTab ";
clsSpecSQLforSql mySql=new clsSpecSQLforSql();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}
public void BindCbo_DetailTabId(System.Windows.Forms.ComboBox objComboBox)
{
//为数据源为表的下拉框设置内容
System.Data.DataTable objDT = GetDetailTabId();
clsPrjTabEN objPrjTabEN;
//初始化一个对象列表
ArrayList PrjTabList = new ArrayList();
//插入第0项。在第0项中插入"请选择..."，为了方便用户，与WEB方式类似。
objPrjTabEN = new clsPrjTabEN();
objPrjTabEN.TabId = "0";
objPrjTabEN.TabName = "请选择...";
PrjTabList.Add(objPrjTabEN);
//把DataTable中的所有项均加到对象列表中
foreach(DataRow objRow in objDT.Rows)
{
objPrjTabEN = new clsPrjTabEN();
objPrjTabEN.TabId = objRow["TabId"].ToString();
objPrjTabEN.TabName = objRow["TabName"].ToString();
PrjTabList.Add(objPrjTabEN);
}
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.DataSource = PrjTabList;
objComboBox.ValueMember="TabId";
objComboBox.DisplayMember="TabName";
objComboBox.SelectedIndex = 0;
}
public System.Data.DataTable GetViewGroupId()
{
//获取某学院所有专业信息
string strSQL = "select ViewGroupId, ViewGroupName from ViewGroup ";
clsSpecSQLforSql mySql=new clsSpecSQLforSql();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}
public void BindCbo_ViewGroupId(System.Windows.Forms.ComboBox objComboBox)
{
//为数据源为表的下拉框设置内容
System.Data.DataTable objDT = GetViewGroupId();
clsViewGroupEN objViewGroupEN;
//初始化一个对象列表
ArrayList ViewGroupList = new ArrayList();
//插入第0项。在第0项中插入"请选择..."，为了方便用户，与WEB方式类似。
objViewGroupEN = new clsViewGroupEN();
objViewGroupEN.ViewGroupId = "0";
objViewGroupEN.ViewGroupName = "请选择...";
ViewGroupList.Add(objViewGroupEN);
//把DataTable中的所有项均加到对象列表中
foreach(DataRow objRow in objDT.Rows)
{
objViewGroupEN = new clsViewGroupEN();
objViewGroupEN.ViewGroupId = objRow["ViewGroupId"].ToString();
objViewGroupEN.ViewGroupName = objRow["ViewGroupName"].ToString();
ViewGroupList.Add(objViewGroupEN);
}
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.DataSource = ViewGroupList;
objComboBox.ValueMember="ViewGroupId";
objComboBox.DisplayMember="ViewGroupName";
objComboBox.SelectedIndex = 0;
}
public System.Data.DataTable GetINRelaTabId()
{
//获取某学院所有专业信息
string strSQL = "select TabId, TabName from PrjTab ";
clsSpecSQLforSql mySql=new clsSpecSQLforSql();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}
public void BindCbo_INRelaTabId(System.Windows.Forms.ComboBox objComboBox)
{
//为数据源为表的下拉框设置内容
System.Data.DataTable objDT = GetINRelaTabId();
clsPrjTabEN objPrjTabEN;
//初始化一个对象列表
ArrayList PrjTabList = new ArrayList();
//插入第0项。在第0项中插入"请选择..."，为了方便用户，与WEB方式类似。
objPrjTabEN = new clsPrjTabEN();
objPrjTabEN.TabId = "0";
objPrjTabEN.TabName = "请选择...";
PrjTabList.Add(objPrjTabEN);
//把DataTable中的所有项均加到对象列表中
foreach(DataRow objRow in objDT.Rows)
{
objPrjTabEN = new clsPrjTabEN();
objPrjTabEN.TabId = objRow["TabId"].ToString();
objPrjTabEN.TabName = objRow["TabName"].ToString();
PrjTabList.Add(objPrjTabEN);
}
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.DataSource = PrjTabList;
objComboBox.ValueMember="TabId";
objComboBox.DisplayMember="TabName";
objComboBox.SelectedIndex = 0;
}
public System.Data.DataTable GetINSQLDSTypeId()
{
//获取某学院所有专业信息
string strSQL = "select OUTSQLDSTypeId, SqlDsTypeName from SQLDSType ";
clsSpecSQLforSql mySql=new clsSpecSQLforSql();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}
public void BindCbo_INSQLDSTypeId(System.Windows.Forms.ComboBox objComboBox)
{
//为数据源为表的下拉框设置内容
System.Data.DataTable objDT = GetINSQLDSTypeId();
clsSQLDSTypeEN objSQLDSTypeEN;
//初始化一个对象列表
ArrayList SQLDSTypeList = new ArrayList();
//插入第0项。在第0项中插入"请选择..."，为了方便用户，与WEB方式类似。
objSQLDSTypeEN = new clsSQLDSTypeEN();
objSQLDSTypeEN.OUTSQLDSTypeId = "0";
objSQLDSTypeEN.SqlDsTypeName = "请选择...";
SQLDSTypeList.Add(objSQLDSTypeEN);
//把DataTable中的所有项均加到对象列表中
foreach(DataRow objRow in objDT.Rows)
{
objSQLDSTypeEN = new clsSQLDSTypeEN();
objSQLDSTypeEN.OUTSQLDSTypeId = objRow["OUTSQLDSTypeId"].ToString();
objSQLDSTypeEN.SqlDsTypeName = objRow["SqlDsTypeName"].ToString();
SQLDSTypeList.Add(objSQLDSTypeEN);
}
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.DataSource = SQLDSTypeList;
objComboBox.ValueMember="OUTSQLDSTypeId";
objComboBox.DisplayMember="SqlDsTypeName";
objComboBox.SelectedIndex = 0;
}
public System.Data.DataTable GetOUTRelaTabId()
{
//获取某学院所有专业信息
string strSQL = "select TabId, TabName from PrjTab ";
clsSpecSQLforSql mySql=new clsSpecSQLforSql();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}
public void BindCbo_OUTRelaTabId(System.Windows.Forms.ComboBox objComboBox)
{
//为数据源为表的下拉框设置内容
System.Data.DataTable objDT = GetOUTRelaTabId();
clsPrjTabEN objPrjTabEN;
//初始化一个对象列表
ArrayList PrjTabList = new ArrayList();
//插入第0项。在第0项中插入"请选择..."，为了方便用户，与WEB方式类似。
objPrjTabEN = new clsPrjTabEN();
objPrjTabEN.TabId = "0";
objPrjTabEN.TabName = "请选择...";
PrjTabList.Add(objPrjTabEN);
//把DataTable中的所有项均加到对象列表中
foreach(DataRow objRow in objDT.Rows)
{
objPrjTabEN = new clsPrjTabEN();
objPrjTabEN.TabId = objRow["TabId"].ToString();
objPrjTabEN.TabName = objRow["TabName"].ToString();
PrjTabList.Add(objPrjTabEN);
}
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.DataSource = PrjTabList;
objComboBox.ValueMember="TabId";
objComboBox.DisplayMember="TabName";
objComboBox.SelectedIndex = 0;
}
public System.Data.DataTable GetOUTSQLDSTypeId()
{
//获取某学院所有专业信息
string strSQL = "select SQLDSTypeId, SqlDsTypeName from SQLDSType ";
clsSpecSQLforSql mySql=new clsSpecSQLforSql();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}
public void BindCbo_OUTSQLDSTypeId(System.Windows.Forms.ComboBox objComboBox)
{
//为数据源为表的下拉框设置内容
System.Data.DataTable objDT = GetOUTSQLDSTypeId();
clsSQLDSTypeEN objSQLDSTypeEN;
//初始化一个对象列表
ArrayList SQLDSTypeList = new ArrayList();
//插入第0项。在第0项中插入"请选择..."，为了方便用户，与WEB方式类似。
objSQLDSTypeEN = new clsSQLDSTypeEN();
objSQLDSTypeEN.SQLDSTypeId = "0";
objSQLDSTypeEN.SqlDsTypeName = "请选择...";
SQLDSTypeList.Add(objSQLDSTypeEN);
//把DataTable中的所有项均加到对象列表中
foreach(DataRow objRow in objDT.Rows)
{
objSQLDSTypeEN = new clsSQLDSTypeEN();
objSQLDSTypeEN.SQLDSTypeId = objRow["SQLDSTypeId"].ToString();
objSQLDSTypeEN.SqlDsTypeName = objRow["SqlDsTypeName"].ToString();
SQLDSTypeList.Add(objSQLDSTypeEN);
}
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.DataSource = SQLDSTypeList;
objComboBox.ValueMember="SQLDSTypeId";
objComboBox.DisplayMember="SqlDsTypeName";
objComboBox.SelectedIndex = 0;
}
public void SetCbo_ViewTypeCode()
{
clsViewTypeCodeTabBL.BindCbo_ViewTypeCode(cboViewTypeCode);
}
public void SetCbo_ApplicationTypeId()
{
clsApplicationTypeBL.BindCbo_ApplicationTypeId(cboApplicationTypeId);
}
public void SetCbo_FuncModuleId()
{
clsFuncModuleBL.BindCbo_FuncModuleId(cboFuncModuleId);
}
public void SetCbo_UserId()
{
clsUsersBL.BindCbo_UserId(cboUserId);
}
public void SetCbo_PrjId()
{
clsProjectsBL.BindCbo_PrjId(cboPrjId);
}
public void SetCbo_DetailTabId()
{
clsPrjTabBL.BindCbo_DetailTabId(cboDetailTabId);
}
public void SetCbo_ViewGroupId()
{
clsViewGroupBL.BindCbo_ViewGroupId(cboViewGroupId);
}
public void SetCbo_INRelaTabId()
{
clsPrjTabBL.BindCbo_INRelaTabId(cboINRelaTabId);
}
public void SetCbo_INSQLDSTypeId()
{
clsSQLDSTypeBL.BindCbo_INSQLDSTypeId(cboINSQLDSTypeId);
}
public void SetCbo_OUTRelaTabId()
{
clsPrjTabBL.BindCbo_OUTRelaTabId(cboOUTRelaTabId);
}
public void SetCbo_OUTSQLDSTypeId()
{
clsSQLDSTypeBL.BindCbo_OUTSQLDSTypeId(cboOUTSQLDSTypeId);
}
/// <summary>
/// 判断是否是数字
/// </summary>
/// <param name="strValue">需要判断的字符串</param>
/// <returns>True/False</returns>
public bool IsDigit(string strValue)
{
int intLen = strValue.Length;
for(int i = 0; i<intLen; i++)
{
if (char.IsDigit(strValue, i) == false)
{
return false;
}
}
return true;
}
/// <summary>
/// 判断是否是浮点型数值
/// </summary>
/// <param name="strValue">需要判断的字符串</param>
/// <returns>True/False</returns>
public bool IsFloat(string strValue)
{
int intPointNum = 0;
char [] arrChar = strValue.ToCharArray();
int intLen = strValue.Length;
for(int i = 0; i<intLen; i++)
{
if (char.IsDigit(strValue, i) == true || arrChar[i] == '.')
{
}
else
{
return false;
}
if (arrChar[i] == '.') intPointNum++;
}
//检查总共有几个小数点，如果有多于1个小数点，就不正确
if (intPointNum>1) return false;
return true;
}
/// <summary>
/// 判断是否是整型数值
/// </summary>
/// <param name="strValue">需要判断的字符串</param>
/// <returns>True/False</returns>
public bool IsNumeric(string strValue)
{
int intLen = strValue.Length;
for(int i = 0; i<intLen; i++)
{
if (char.IsDigit(strValue, i) == false)
{
return false;
}
}
return true;
}
/// <summary>
/// 函数功能：把以该关键字的记录内容显示在界面上，
///　　　     在这里是把值传到表控件中
/// </summary>
/// <param name="strViewId">表记录的关键字，显示该表关键字的内容</param>
private void ShowData(string strViewId)
{
//操作步骤：
//1、检查关键字是否为空；
//2、检查该关键字的记录是否存在，如果不存在就返回不显示；
//3、用提供的关键字初始化一个类对象；
//4、获取类对象的所有属性；
//5、把该对象的所有属性显示在界面上，在这里显示在表控件中

//1、检查关键字是否为空；
if (strViewId == "") return ;		//如果关键字为空就返回退出
//2、检查该关键字的记录是否存在，如果不存在就返回不显示；
if (clsViewInfoBL.IsExist(strViewId) == false)		//检查该关键字的记录是否存在
{
string ss = "关键字为：" + strViewId + "的不存在!";
MessageBox.Show(ss);
return ;
}
//3、用提供的关键字初始化一个类对象；
objViewInfoEN = new clsViewInfoEN(strViewId);
//4、获取类对象的所有属性；
clsViewInfoBL.GetViewInfo(ref objViewInfoEN);
//5、把该对象的所有属性显示在界面上，在这里显示在表控件中
GetDataFromViewInfoClass(objViewInfoEN);
}
///生成从逻辑层的数据传输到界面层的函数代码
private void GetDataFromViewInfoClass(clsViewInfoEN pobjViewInfoEN)
{
///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
///      如果在设置数据库时，就应该一级字段在前，二级字段在后
this.ViewId = pobjViewInfoEN.ViewId;
this.ViewName = pobjViewInfoEN.ViewName;
this.ViewTypeCode = pobjViewInfoEN.ViewTypeCode;
this.ApplicationTypeId = pobjViewInfoEN.ApplicationTypeId;
this.FuncModuleId = pobjViewInfoEN.FuncModuleId;
this.DataBaseName = pobjViewInfoEN.DataBaseName;
this.KeyForMainTab = pobjViewInfoEN.KeyForMainTab;
this.KeyForDetailTab = pobjViewInfoEN.KeyForDetailTab;
this.IsNeedSort = pobjViewInfoEN.IsNeedSort;
this.IsNeedTransCode = pobjViewInfoEN.IsNeedTransCode;
this.UserId = pobjViewInfoEN.UserId;
this.PrjId = pobjViewInfoEN.PrjId;
this.ViewFunction = pobjViewInfoEN.ViewFunction;
this.ViewDetail = pobjViewInfoEN.ViewDetail;
this.DefaMenuName = pobjViewInfoEN.DefaMenuName;
this.DetailTabId = pobjViewInfoEN.DetailTabId;
this.FileName = pobjViewInfoEN.FileName;
this.FilePath = pobjViewInfoEN.FilePath;
this.MainTabId = pobjViewInfoEN.MainTabId;
this.ViewCnName = pobjViewInfoEN.ViewCnName;
this.ViewGroupId = pobjViewInfoEN.ViewGroupId;
this.INRelaTabId = pobjViewInfoEN.INRelaTabId;
this.INSQLDSTypeId = pobjViewInfoEN.INSQLDSTypeId;
this.OUTRelaTabId = pobjViewInfoEN.OUTRelaTabId;
this.OUTSQLDSTypeId = pobjViewInfoEN.OUTSQLDSTypeId;
this.DetailTabType = pobjViewInfoEN.DetailTabType;
this.DetailViewId = pobjViewInfoEN.DetailViewId;
this.MainTabType = pobjViewInfoEN.MainTabType;
this.MainViewId = pobjViewInfoEN.MainViewId;
this.UpdDate = pobjViewInfoEN.UpdDate;
}
/// <summary>
/// 函数功能：事件函数，当单击<确定修改>时发生的事件函数，
///           具体功能为把界面内容同步数据库中，把界面内容保存到数据库中
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void btnOKUpd_Click(object sender, System.EventArgs e)
{
string strCommandText;
Button btnTemp = (Button) sender;
strCommandText = btnTemp.Text;
switch(strCommandText)
{
case "添加":
AddViewInfoRecord();
break;				
case "确认添加":
//这是一个单表的插入的代码，由于逻辑层太简单，
//就把逻辑层合并到控制层,
AddViewInfoRecordSave();
break;
case "确认修改":
//这是一个单表的修改的代码，由于逻辑层太简单，
//就把逻辑层合并到控制层,
UpdateViewInfoRecordSave(objViewInfoEN);
break;
}
}
private void PutDataToViewInfoClass(clsViewInfoEN pobjViewInfoEN)
{
pobjViewInfoEN.ViewId = this.ViewId;
pobjViewInfoEN.ViewName = this.ViewName;
pobjViewInfoEN.ViewTypeCode = this.ViewTypeCode;
pobjViewInfoEN.ApplicationTypeId = this.ApplicationTypeId;
pobjViewInfoEN.FuncModuleId = this.FuncModuleId;
pobjViewInfoEN.DataBaseName = this.DataBaseName;
pobjViewInfoEN.KeyForMainTab = this.KeyForMainTab;
pobjViewInfoEN.KeyForDetailTab = this.KeyForDetailTab;
pobjViewInfoEN.IsNeedSort = this.IsNeedSort;
pobjViewInfoEN.IsNeedTransCode = this.IsNeedTransCode;
pobjViewInfoEN.UserId = this.UserId;
pobjViewInfoEN.PrjId = this.PrjId;
pobjViewInfoEN.ViewFunction = this.ViewFunction;
pobjViewInfoEN.ViewDetail = this.ViewDetail;
pobjViewInfoEN.DefaMenuName = this.DefaMenuName;
pobjViewInfoEN.DetailTabId = this.DetailTabId;
pobjViewInfoEN.FileName = this.FileName;
pobjViewInfoEN.FilePath = this.FilePath;
pobjViewInfoEN.MainTabId = this.MainTabId;
pobjViewInfoEN.ViewCnName = this.ViewCnName;
pobjViewInfoEN.ViewGroupId = this.ViewGroupId;
pobjViewInfoEN.INRelaTabId = this.INRelaTabId;
pobjViewInfoEN.INSQLDSTypeId = this.INSQLDSTypeId;
pobjViewInfoEN.OUTRelaTabId = this.OUTRelaTabId;
pobjViewInfoEN.OUTSQLDSTypeId = this.OUTSQLDSTypeId;
pobjViewInfoEN.DetailTabType = this.DetailTabType;
pobjViewInfoEN.DetailViewId = this.DetailViewId;
pobjViewInfoEN.MainTabType = this.MainTabType;
pobjViewInfoEN.MainViewId = this.MainViewId;
pobjViewInfoEN.UpdDate = this.UpdDate;
}
private void btnClose_Click(object sender, System.EventArgs e)
{
this.Close();
}
public string ViewId_key
{
get
{
return mstrViewId;
}
set
{
mstrViewId = value;
}
}
///生成的插入记录准备过程代码for C#
protected void AddViewInfoRecord()
{
this.SetKeyReadOnly(false);
btnOKUpd.Text = "确认添加";
//this.ViewId = clsCommForWin.GetMaxStrId("ViewInfo","ViewId", 8, "");
//DispEditViewInfoRegion();
}
///插入记录存盘过程代码for C#
private void AddViewInfoRecordSave()
{
//操作步骤：
//1、检查控件中输入数据类型是否正确
//2、定义对象并初始化对象
//3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//4、把值从界面层传到逻辑层或数据实体层
//5、检查传进去的对象属性是否合法
//6、把数据实体层的数据存贮到数据库中
//7、把新添的记录内容显示在DATAGRID中
string strMsg;	//专门用于传递信息的变量
string strResult=" ";	//用于传递在检验对象属性时结果值的变量
clsViewInfoEN objViewInfo;
//1、检查控件中输入数据类型是否正确
if (!this.IsValid(ref strResult))
{
lblMsg.Text = "控件中输入数据类型不正确请检查!";
return ;
}
//2、初始化相关类对象
objViewInfoEN = new clsViewInfoEN(this.ViewId);	//初始化新对象
//3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsViewInfoBL.IsExist(ViewId))	//判断是否有相同的关键字
{
strMsg = "关键字字段已有相同的值";
MessageBox.Show(strMsg);
return;
}
//4、把值从界面层传到逻辑层或数据实体层
PutDataToViewInfoClass(objViewInfoEN);		//把界面的值传到
//5、检查传进去的对象属性是否合法
try
{
clsViewInfoBL.CheckPropertyNew(objViewInfoEN);
//6、把数据实体层的数据存贮到数据库中
clsViewInfoBL.AddNewRecordBySql2(objViewInfoEN);
}
catch(Exception objException)
{
strMsg = "添加记录不成功!" + objException.Message;
MessageBox.Show(strMsg );
lblMsg.Text = strMsg;
return;
}
strMsg = "添加记录成功!";
MessageBox.Show(strMsg);
lblMsg.Text = "添加记录成功!";
//7、恢复<确认添加>变成<添加>
btnOKUpd.Text = "添加";
//8、调用父窗体中函数BINDLISTVIEW()把父窗体中的LISTVIEW内容重新显示一下。
iBindListView.BindListView();
}
    ///修改存盘准备过程代码 for C#
private void UpdateViewInfoRecordSave(clsViewInfoEN objViewInfoEN)
{
//操作步骤：
//1、检查控件中输入数据类型是否正确
//2、把值从界面层传到逻辑层或数据实体层
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
//5、把修改后的内容显示在DATAGRID中
string strMsg;	//专门用于传递信息的变量
string strResult=" ";	//用于传递在检验对象属性时结果值的变量
//1、检查控件中输入数据类型是否正确
if (!this.IsValid(ref strResult))
{
lblMsg.Text = "控件中输入数据类型不正确请检查!";
return ;
}
//2、把值从界面层传到逻辑层或数据实体层
PutDataToViewInfoClass(objViewInfoEN);		//把界面的值传到
//3、检查传进去的对象属性是否合法
try
{
clsViewInfoBL.CheckPropertyNew(objViewInfoEN);
//6、把数据实体层的数据存贮到数据库中
clsViewInfoBL.UpdateBySql2(objViewInfoEN);
}
catch(Exception objException)
{
strMsg = "修改记录不成功!" + objException.Message;
MessageBox.Show(strMsg);
lblMsg.Text = strMsg;
return ; 
}
strMsg = "修改记录成功!";
MessageBox.Show(strMsg);
lblMsg.Text = "修改记录成功!";
this.Close();
//5、恢复<确认修改>变成<添加>
btnOKUpd.Text = "添加";
//6、调用父窗体中函数BINDLISTVIEW()把父窗体中的LISTVIEW内容重新显示一下。
iBindListView.BindListView();
}
}
}