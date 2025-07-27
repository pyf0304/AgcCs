
///----------------------
///生成代码版本：2012.01.02.1
///生成日期：2012/10/17
///生成者：潘以锋
///工程名称：AGC_CSV7
///工程ID：0005
///模块中文名：系统设置
///模块英文名：SystemSet
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
///		frmUserCodePath_UI 的摘要说明。
/// </summary>
public partial class frmUserCodePath_UI : System.Windows.Forms.Form
{
clsUserCodePathEN objUserCodePathEN = null;
private long mlngmId;		//用于传递关键字值的变量
public string OperateType;
public IBindListView iBindListView = null;
public frmUserCodePath_UI()
{
// 该调用是 Windows.Forms 窗体设计器所必需的。
InitializeComponent();

// TODO: 在 InitializeComponent 调用后添加任何初始化

}
private void frmUserCodePath_UI_Load(object sender, System.EventArgs e)
{
// 在此处放置用户代码以初始化页面
//1、为下拉框设置数据源，绑定列表数据
this.SetAllComboBox();
if (OperateType == "Update")
{
ShowData(mlngmId);
btnOKUpd.Text = "确认修改";
}
else
{
AddUserCodePathRecord();
}

}
/// <summary>
/// 下拉框的绑定函数
/// </summary>
private void SetAllComboBox()
{
this.BindCbo_UserId(this.cboUserId);
this.BindCbo_PrjId(this.cboPrjId);
this.BindCbo_CodeTypeId(this.cboCodeTypeId);
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

public string CodeTypeId
{
get
{
if (cboCodeTypeId.SelectedValue.ToString() == "0")
return "";
return cboCodeTypeId.SelectedValue.ToString();
}
set
{
if (value == "")
{
cboCodeTypeId.SelectedValue = "0";
}
else
{
cboCodeTypeId.SelectedValue = value;
}
}
}

public string CodePath
{
get
{
return txtCodePath.Text.Trim();
}
set
{
txtCodePath.Text = value.ToString();
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

public string UpdUserId
{
get
{
return txtUpdUserId.Text.Trim();
}
set
{
txtUpdUserId.Text = value.ToString();
}
}

public string Memo
{
get
{
return txtMemo.Text.Trim();
}
set
{
txtMemo.Text = value.ToString();
}
}


public void Clear()
{
cboUserId.SelectedIndex = 0;
cboPrjId.SelectedIndex = 0;
cboCodeTypeId.SelectedIndex = 0;
txtCodePath.Text = "";
txtUpdDate.Text = "";
txtUpdUserId.Text = "";
txtMemo.Text = "";
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
cboUserId.SelectedIndex = 0;
cboPrjId.SelectedIndex = 0;
cboCodeTypeId.SelectedIndex = 0;
txtCodePath.Text = "";
txtUpdDate.Text = "";
txtUpdUserId.Text = "";
txtMemo.Text = "";
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
public System.Data.DataTable GetCodeTypeId()
{
//获取某学院所有专业信息
string strSQL = "select CodeTypeId, CodeTypeName from CodeType ";
clsSpecSQLforSql mySql=new clsSpecSQLforSql();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}
public void BindCbo_CodeTypeId(System.Windows.Forms.ComboBox objComboBox)
{
//为数据源为表的下拉框设置内容
System.Data.DataTable objDT = GetCodeTypeId();
clsCodeTypeEN objCodeTypeEN;
//初始化一个对象列表
ArrayList CodeTypeList = new ArrayList();
//插入第0项。在第0项中插入"请选择..."，为了方便用户，与WEB方式类似。
objCodeTypeEN = new clsCodeTypeEN();
objCodeTypeEN.CodeTypeId = "0";
objCodeTypeEN.CodeTypeName = "请选择...";
CodeTypeList.Add(objCodeTypeEN);
//把DataTable中的所有项均加到对象列表中
foreach(DataRow objRow in objDT.Rows)
{
objCodeTypeEN = new clsCodeTypeEN();
objCodeTypeEN.CodeTypeId = objRow["CodeTypeId"].ToString();
objCodeTypeEN.CodeTypeName = objRow["CodeTypeName"].ToString();
CodeTypeList.Add(objCodeTypeEN);
}
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.DataSource = CodeTypeList;
objComboBox.ValueMember="CodeTypeId";
objComboBox.DisplayMember="CodeTypeName";
objComboBox.SelectedIndex = 0;
}
public void SetCbo_UserId()
{
clsUsersBL.BindCbo_UserId(cboUserId);
}
public void SetCbo_PrjId()
{
clsProjectsBL.BindCbo_PrjId(cboPrjId);
}
public void SetCbo_CodeTypeId()
{
clsCodeTypeBL.BindCbo_CodeTypeId(cboCodeTypeId);
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
/// <param name="lngmId">表记录的关键字，显示该表关键字的内容</param>
private void ShowData(long lngmId)
{
//操作步骤：
//1、检查关键字是否为空；
//2、检查该关键字的记录是否存在，如果不存在就返回不显示；
//3、用提供的关键字初始化一个类对象；
//4、获取类对象的所有属性；
//5、把该对象的所有属性显示在界面上，在这里显示在表控件中

//1、检查关键字是否为空；
if (lngmId == 0) return ;		//如果关键字为空就返回退出
//2、检查该关键字的记录是否存在，如果不存在就返回不显示；
if (clsUserCodePathBL.IsExist(lngmId) == false)		//检查该关键字的记录是否存在
{
string ss = "关键字为：" + lngmId + "的不存在!";
MessageBox.Show(ss);
return ;
}
//3、用提供的关键字初始化一个类对象；
objUserCodePathEN = new clsUserCodePathEN(lngmId);
//4、获取类对象的所有属性；
clsUserCodePathBL.GetUserCodePath(ref objUserCodePathEN);
//5、把该对象的所有属性显示在界面上，在这里显示在表控件中
GetDataFromUserCodePathClass(objUserCodePathEN);
}
///生成从逻辑层的数据传输到界面层的函数代码
private void GetDataFromUserCodePathClass(clsUserCodePathEN pobjUserCodePathEN)
{
///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
///      如果在设置数据库时，就应该一级字段在前，二级字段在后
this.UserId = pobjUserCodePathEN.UserId;
this.PrjId = pobjUserCodePathEN.PrjId;
this.CodeTypeId = pobjUserCodePathEN.CodeTypeId;
this.CodePath = pobjUserCodePathEN.CodePath;
this.UpdDate = pobjUserCodePathEN.UpdDate;
this.UpdUserId = pobjUserCodePathEN.UpdUserId;
this.Memo = pobjUserCodePathEN.Memo;
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
AddUserCodePathRecord();
break;				
case "确认添加":
//这是一个单表的插入的代码，由于逻辑层太简单，
//就把逻辑层合并到控制层,
AddUserCodePathRecordSave();
break;
case "确认修改":
//这是一个单表的修改的代码，由于逻辑层太简单，
//就把逻辑层合并到控制层,
UpdateUserCodePathRecordSave(objUserCodePathEN);
break;
}
}
private void PutDataToUserCodePathClass(clsUserCodePathEN pobjUserCodePathEN)
{
pobjUserCodePathEN.UserId = this.UserId;
pobjUserCodePathEN.PrjId = this.PrjId;
pobjUserCodePathEN.CodeTypeId = this.CodeTypeId;
pobjUserCodePathEN.CodePath = this.CodePath;
pobjUserCodePathEN.UpdDate = this.UpdDate;
pobjUserCodePathEN.UpdUserId = this.UpdUserId;
pobjUserCodePathEN.Memo = this.Memo;
}
private void btnClose_Click(object sender, System.EventArgs e)
{
this.Close();
}
public long mId_key
{
get
{
return mlngmId;
}
set
{
mlngmId = value;
}
}
///生成的插入记录准备过程代码for C#
protected void AddUserCodePathRecord()
{
btnOKUpd.Text = "确认添加";
//this.mId = clsCommForWin.GetMaxStrId("UserCodePath","mId", 8, "");
//DispEditUserCodePathRegion();
}
///插入记录存盘过程代码for C#
private void AddUserCodePathRecordSave()
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
clsUserCodePathEN objUserCodePath;
//1、检查控件中输入数据类型是否正确
if (!this.IsValid(ref strResult))
{
lblMsg.Text = "控件中输入数据类型不正确请检查!";
return ;
}
//2、初始化相关类对象
objUserCodePathEN = new clsUserCodePathEN();	//初始化新对象
//3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//4、把值从界面层传到逻辑层或数据实体层
PutDataToUserCodePathClass(objUserCodePathEN);		//把界面的值传到
//5、检查传进去的对象属性是否合法
try
{
clsUserCodePathBL.CheckPropertyNew(objUserCodePathEN);
//6、把数据实体层的数据存贮到数据库中
clsUserCodePathBL.AddNewRecordBySql2(objUserCodePathEN);
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
private void UpdateUserCodePathRecordSave(clsUserCodePathEN objUserCodePathEN)
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
PutDataToUserCodePathClass(objUserCodePathEN);		//把界面的值传到
//3、检查传进去的对象属性是否合法
try
{
clsUserCodePathBL.CheckPropertyNew(objUserCodePathEN);
//6、把数据实体层的数据存贮到数据库中
clsUserCodePathBL.UpdateBySql2(objUserCodePathEN);
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