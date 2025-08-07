
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
using com.taishsoft.util;
using CommFunc4Win;
using com.taishsoft.commdb;
using AGC_CSV7.Entity;
using AGC_CSV7.BusinessLogic;

namespace AGC_CSV7
{
/// <summary>
///		frmUserCodePath_QD_LV 的摘要说明。
/// </summary>
public partial class frmUserCodePath_QD_LV : System.Windows.Forms.Form, IBindListView
{
clsUserCodePathEN objUserCodePathEN = null;
private System.Data.DataTable objDTUserCodePath = null;
private clsListViewSorter objvUserCodePathSorter;
private int intLastSelectedvUserCodePathColumIndex ;
public frmUserCodePath_QD_LV()
{
// 该调用是 Windows.Forms 窗体设计器所必需的。
InitializeComponent();

// TODO: 在 InitializeComponent 调用后添加任何初始化
objvUserCodePathSorter = new clsListViewSorter();
//为ListViewItemSorter指定排序类
this.lvvUserCodePath.ListViewItemSorter = objvUserCodePathSorter;
objvUserCodePathSorter.SortOrder=SortOrder.Ascending;

}
private void frmUserCodePath_QD_Load(object sender, System.EventArgs e)
{
// 在此处放置用户代码以初始化页面
//1、为下拉框设置数据源，绑定列表数据
this.SetAllComboBox();
BindLv_vUserCodePath();
this.JudgebtnDelRec(); //用来判断删除按钮是否可用
this.JudgebtnUpdate(); //用来判断修改按钮是否可用

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


public void Clear()
{
cboUserId.SelectedIndex = 0;
cboPrjId.SelectedIndex = 0;
cboCodeTypeId.SelectedIndex = 0;
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
/// 把所有的查询控件内容组合成一个条件串
/// </summary>
/// <returns>条件串(strWhereCond)</returns>
public string CombineUserCodePathCondion()
{
//使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
//例如 1=1 && UserName = '张三'
string strWhereCond=" 1=1 ";
//如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
if (this.cboUserId.SelectedValue.ToString()!="" && this.cboUserId.SelectedValue.ToString()!="0")
{
strWhereCond += " And UserCodePath.UserId='" + this.cboUserId.SelectedValue+"'";
}
if (this.cboPrjId.SelectedValue.ToString()!="" && this.cboPrjId.SelectedValue.ToString()!="0")
{
strWhereCond += " And UserCodePath.PrjId='" + this.cboPrjId.SelectedValue+"'";
}
if (this.cboCodeTypeId.SelectedValue.ToString()!="" && this.cboCodeTypeId.SelectedValue.ToString()!="0")
{
strWhereCond += " And UserCodePath.CodeTypeId='" + this.cboCodeTypeId.SelectedValue+"'";
}
return strWhereCond;
}
/// <summary>
/// 把所有的查询控件内容组合成一个条件串
/// </summary>
/// <returns>条件串(strWhereCond)</returns>
public string CombineUserCodePathCondion(bool bolIsWithTabName)
{
//使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
//例如 1=1 && UserName = '张三'
string strWhereCond=" 1=1 ";
//如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
if (bolIsWithTabName == true)
{
if (this.cboUserId.SelectedValue.ToString()!="" && this.cboUserId.SelectedValue.ToString()!="0")
{
strWhereCond += " And UserCodePath.UserId='" + this.cboUserId.SelectedValue+"'";
}
if (this.cboPrjId.SelectedValue.ToString()!="" && this.cboPrjId.SelectedValue.ToString()!="0")
{
strWhereCond += " And UserCodePath.PrjId='" + this.cboPrjId.SelectedValue+"'";
}
if (this.cboCodeTypeId.SelectedValue.ToString()!="" && this.cboCodeTypeId.SelectedValue.ToString()!="0")
{
strWhereCond += " And UserCodePath.CodeTypeId='" + this.cboCodeTypeId.SelectedValue+"'";
}
}
else
{
if (this.cboUserId.SelectedValue.ToString()!="" && this.cboUserId.SelectedValue.ToString()!="0")
{
strWhereCond += " And UserId='" + this.cboUserId.SelectedValue+"'";
}
if (this.cboPrjId.SelectedValue.ToString()!="" && this.cboPrjId.SelectedValue.ToString()!="0")
{
strWhereCond += " And PrjId='" + this.cboPrjId.SelectedValue+"'";
}
if (this.cboCodeTypeId.SelectedValue.ToString()!="" && this.cboCodeTypeId.SelectedValue.ToString()!="0")
{
strWhereCond += " And CodeTypeId='" + this.cboCodeTypeId.SelectedValue+"'";
}
}
return strWhereCond;
}
/// <summary>
/// 把所有的查询控件内容组合成一个条件串
/// </summary>
/// <returns>条件串(strWhereCond)</returns>
public string CombineUserCodePathCondion(string strTabName)
{
//使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
//例如 1=1 && UserName = '张三'
string strWhereCond=" 1=1 ";
//如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
if (this.cboUserId.SelectedValue.ToString()!="" && this.cboUserId.SelectedValue.ToString()!="0")
{
strWhereCond += " And " + strTabName + ".UserId='" + this.cboUserId.SelectedValue+"'";
}
if (this.cboPrjId.SelectedValue.ToString()!="" && this.cboPrjId.SelectedValue.ToString()!="0")
{
strWhereCond += " And " + strTabName + ".PrjId='" + this.cboPrjId.SelectedValue+"'";
}
if (this.cboCodeTypeId.SelectedValue.ToString()!="" && this.cboCodeTypeId.SelectedValue.ToString()!="0")
{
strWhereCond += " And " + strTabName + ".CodeTypeId='" + this.cboCodeTypeId.SelectedValue+"'";
}
return strWhereCond;
}
/// <summary>
/// 函数功能：用来判断删除按钮是否可用。
///			 如果在LISTVIEW中选中记录就显示删除按钮，否则就不显示
/// </summary>
private void JudgebtnDelRec()
{
if (this.lvvUserCodePath.SelectedItems.Count >= 1)
{
this.btnDelRec.Enabled = true;
}
else
{             
this.btnDelRec.Enabled = false;
}
}
/// <summary>
/// 函数功能：用来判断删除按钮是否可用。
///			 如果在LISTVIEW中选中记录就显示删除按钮，否则就不显示
/// </summary>
private void JudgebtnUpdate()
{
if (this.lvvUserCodePath.SelectedItems.Count >= 1)
{
this.btnUpdate.Enabled = true;
}
else
{             
this.btnUpdate.Enabled = false;
}
}
///生成绑定ListView的代码
/// <summary>
/// 函数功能：根据界面上查询控件中所设置内容查询表记录，
///			 并显示在ListView中。
/// </summary>
private void BindLv_vUserCodePath()
{
//操作步骤：(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

ListViewItem lvivUserCodePath; 
List<clsvUserCodePathEN> arrvUserCodePathObjList;
//	1、组合界面条件串；
string strWhereCond = this.CombineUserCodePathCondion(false);	//  CombineUserCodePathCondion();
//	2、根据条件串获取该表满足条件的DataTable；
arrvUserCodePathObjList = clsvUserCodePathBL.GetvUserCodePathObjList(strWhereCond);
//	3、设置ListView的列头信息
this.lvvUserCodePath.Items.Clear();//清除原来所有Item
this.lvvUserCodePath.Columns.Clear();//清除原来所有列头信息
this.lvvUserCodePath.Columns.Add("mId", 100, HorizontalAlignment.Left);
this.lvvUserCodePath.Columns.Add("用户ID", 100, HorizontalAlignment.Left);
this.lvvUserCodePath.Columns.Add("用户名", 100, HorizontalAlignment.Left);
this.lvvUserCodePath.Columns.Add("工程ID", 100, HorizontalAlignment.Left);
this.lvvUserCodePath.Columns.Add("工程名称", 100, HorizontalAlignment.Left);
this.lvvUserCodePath.Columns.Add("代码类型名", 100, HorizontalAlignment.Left);
this.lvvUserCodePath.Columns.Add("代码路径", 100, HorizontalAlignment.Left);
this.lvvUserCodePath.Columns.Add("用户状态名", 100, HorizontalAlignment.Left);
this.lvvUserCodePath.Columns.Add("部门ID", 100, HorizontalAlignment.Left);
this.lvvUserCodePath.Columns.Add("部门名称", 100, HorizontalAlignment.Left);
this.lvvUserCodePath.Columns.Add("修改日期", 100, HorizontalAlignment.Left);
this.lvvUserCodePath.Columns.Add("修改用户Id", 100, HorizontalAlignment.Left);
this.lvvUserCodePath.Columns.Add("说明", 100, HorizontalAlignment.Left);
this.lvvUserCodePath.View = View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsvUserCodePathEN objvUserCodePathEN in arrvUserCodePathObjList)
{
lvivUserCodePath = new ListViewItem();
lvivUserCodePath.Tag = objvUserCodePathEN.mId;
lvivUserCodePath.Text = objvUserCodePathEN.mId.ToString();
lvivUserCodePath.SubItems.Add(objvUserCodePathEN.UserId);
lvivUserCodePath.SubItems.Add(objvUserCodePathEN.UserName);
lvivUserCodePath.SubItems.Add(objvUserCodePathEN.PrjId);
lvivUserCodePath.SubItems.Add(objvUserCodePathEN.PrjName);
lvivUserCodePath.SubItems.Add(objvUserCodePathEN.CodeTypeName);
lvivUserCodePath.SubItems.Add(objvUserCodePathEN.CodePath);
lvivUserCodePath.SubItems.Add(objvUserCodePathEN.UserStateName);
lvivUserCodePath.SubItems.Add(objvUserCodePathEN.DepartmentId);
lvivUserCodePath.SubItems.Add(objvUserCodePathEN.DepartmentName);
lvivUserCodePath.SubItems.Add(objvUserCodePathEN.UpdDate);
lvivUserCodePath.SubItems.Add(objvUserCodePathEN.UpdUserId);
lvivUserCodePath.SubItems.Add(objvUserCodePathEN.Memo);
this.lvvUserCodePath.Items.Add(lvivUserCodePath);
}
//	4、设置记录数的状态，
//		在本界面中是把状态显示在控件txtRecCount中。
this.lblRecNum.Text = "记录数：" + arrvUserCodePathObjList.Count.ToString();
}
private void btnQuery_Click(object sender, System.EventArgs e)
{
//把表记录的内容显示在ListView中
BindLv_vUserCodePath();
}
/// <summary>
/// 获取DataGrid中当前行的主键值
/// </summary>
/// <param name="objDataGrid">所单击的DataGrid</param>
/// <returns>当前行的主键值</returns>
private long GetCurrKey(DataGrid objDataGrid)
{
int intCurrRow = objDataGrid.CurrentRowIndex;
string strmId = objDTUserCodePath.Rows[intCurrRow]["mId"].ToString();
long lngmId = long.Parse(strmId);
return lngmId;
}
/// <summary>
/// 获取ListView中当前行的主键值
/// </summary>
/// <param name="objListView">所单击的ListView</param>
/// <returns>当前行的主键值</returns>
private long GetCurrKey(ListView objListView)
{
if (objListView.SelectedItems.Count == 0)
{
return 0;
}
ListViewItem lviUserCodePath;
lviUserCodePath = objListView.SelectedItems[0];
string strUserCodePathId = lviUserCodePath.Tag.ToString();
long lngmId = long.Parse(strUserCodePathId);
return lngmId;
}
/// <summary>
/// 获取ListView所给项的主键值
/// </summary>
/// <param name="objListView">所单击的ListView项</param>
/// <returns>当前行的主键值</returns>
private long GetCurrKey(ListViewItem objListViewItem)
{
string strUserCodePathId = objListViewItem.Tag.ToString();
long lngmId = long.Parse(strUserCodePathId);
return lngmId;
}
private void lvvUserCodePath_Click(object sender, System.EventArgs e)
{
this.JudgebtnDelRec(); //用来判断删除按钮是否可用
this.JudgebtnUpdate(); //用来判断修改按钮是否可用
}
/// <summary>
/// 函数功能：事件函数，当单击<确定修改>时发生的事件函数，
///           具体功能为把界面内容同步数据库中，把界面内容保存到数据库中
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void btnUpdate_Click(object sender, System.EventArgs e)
{
UpdateUserCodePathRecord();
}
/// <summary>
/// 函数功能：事件函数，当单击<确定修改>时发生的事件函数，
///           具体功能为把界面内容同步数据库中，把界面内容保存到数据库中
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void btnAdd_Click(object sender, System.EventArgs e)
{
frmUserCodePath_UI frm = new frmUserCodePath_UI();
frm.iBindListView = this;
frm.OperateType = "Add";
frm.ShowDialog();
}
private void btnDelRec_Click(object sender, System.EventArgs e)
{
DeleteUserCodePathRecord();
}
private void btnExportExcel4Dg_Click(object sender, System.EventArgs e)
{
ExportExcel_SelColumns();	//新的导出EXCEL方式，用户可以选择导出字段列
//ExportExcel();	//原来的方式导出EXCEL，用户不能选择导出字段列
}
/// <summary>
/// 导出EXCEL的函数
/// </summary>
private void ExportExcel()
{
//	1、组合界面条件串；
string strWhereCond = this.CombineUserCodePathCondion(true);
//	2、根据条件串获取该表满足条件的DataTable；
System.Data.DataTable objDT = clsUserCodePathBL.GetDataTable_UserCodePath(strWhereCond);
ArrayList arrCnName = new ArrayList();
ArrayList arrColName = new ArrayList();
//string strFileName = "UserCodePath信息导出.xls";
//string strFolderName;
string strDownLoadFileName;
arrColName.Add("UserId"); arrCnName.Add("用户ID");
arrColName.Add("UserName"); arrCnName.Add("用户名");
arrColName.Add("PrjId"); arrCnName.Add("工程ID");
arrColName.Add("PrjName"); arrCnName.Add("工程名称");
arrColName.Add("CodeTypeId"); arrCnName.Add("代码类型Id");
arrColName.Add("CodeTypeName"); arrCnName.Add("代码类型名");
arrColName.Add("CodePath"); arrCnName.Add("代码路径");
arrColName.Add("UserStateId"); arrCnName.Add("用户状态号");
arrColName.Add("UserStateName"); arrCnName.Add("用户状态名");
arrColName.Add("DepartmentId"); arrCnName.Add("部门ID");
arrColName.Add("DepartmentName"); arrCnName.Add("部门名称");
arrColName.Add("UpdDate"); arrCnName.Add("修改日期");
arrColName.Add("UpdUserId"); arrCnName.Add("修改用户Id");
arrColName.Add("Memo"); arrCnName.Add("说明");
//strFolderName = Application.StartupPath + "\\TempFiles";
//if (Directory.Exists(strFolderName) == false)
//{
//Directory.CreateDirectory(strFolderName);
//}
//strDownLoadFileName = strFolderName + "\\" + strFileName;
System.Windows.Forms.SaveFileDialog objSaveFileDialog = new SaveFileDialog();
objSaveFileDialog.DefaultExt = "xls";
objSaveFileDialog.Filter = "Excle文件(*.xls)|*.xls|所有文件(*.*)|*.*";
objSaveFileDialog.ShowDialog();
strDownLoadFileName = objSaveFileDialog.FileName;
if (strDownLoadFileName=="")
{
return ;
}
GetExcelFromDataTable.clsGetExcelFromDataTable objExcel = new GetExcelFromDataTable.clsGetExcelFromDataTable();
objExcel.GetExcelFromDataTableByArrAndArray(objDT, arrColName, arrCnName, strDownLoadFileName);
MessageBox.Show("导出Excel成功!，文件存放在：" + strDownLoadFileName);
}
/// <summary>
/// 导出EXCEL的函数, 导出EXCEL时可以选择列
/// </summary>
private void ExportExcel_SelColumns()
{
//	1、组合界面条件串；
string strWhereCond = this.CombineUserCodePathCondion(true);
//	2、设置表列数据字段名，以及表列标题
ArrayList arrCnName = new ArrayList();
ArrayList arrColName = new ArrayList();
arrColName.Add("UserId"); arrCnName.Add("用户ID");
arrColName.Add("UserName"); arrCnName.Add("用户名");
arrColName.Add("PrjId"); arrCnName.Add("工程ID");
arrColName.Add("PrjName"); arrCnName.Add("工程名称");
arrColName.Add("CodeTypeId"); arrCnName.Add("代码类型Id");
arrColName.Add("CodeTypeName"); arrCnName.Add("代码类型名");
arrColName.Add("CodePath"); arrCnName.Add("代码路径");
arrColName.Add("UserStateId"); arrCnName.Add("用户状态号");
arrColName.Add("UserStateName"); arrCnName.Add("用户状态名");
arrColName.Add("DepartmentId"); arrCnName.Add("部门ID");
arrColName.Add("DepartmentName"); arrCnName.Add("部门名称");
arrColName.Add("UpdDate"); arrCnName.Add("修改日期");
arrColName.Add("UpdUserId"); arrCnName.Add("修改用户Id");
arrColName.Add("Memo"); arrCnName.Add("说明");
ArrayList arrExportExcelList = new ArrayList();
clsExportField objExportField = null;
int intColNum = arrColName.Count;
for(int i = 0; i<intColNum; i++)
{
objExportField = new clsExportField();
objExportField.FieldEnglishName = arrColName[i].ToString();
objExportField.FieldChineseName = arrCnName[i].ToString();
arrExportExcelList.Add(objExportField);
}
/// 3、调用公用的导出EXCEL的界面，选择列后再导出
frmExportExcel frm1 = new frmExportExcel();
frm1.arrExportExcelList = arrExportExcelList;
frm1.strTableName = "vUserCodePath";
frm1.strTableChineseName = "vUserCodePath";
frm1.strViewName = "用户生成路径维护";
frm1.strWhereCondition = strWhereCond;
frm1.Show();
}

/// <summary>
/// 函数功能：LISTVIEW的列单击事件函数
/// </summary>
private void lvvUserCodePath_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
{
if (e.Column == this.objvUserCodePathSorter.SortColumn)
{

}
else
{
this.objvUserCodePathSorter.SortColumn=e.Column;
}

if (this.objvUserCodePathSorter.SortOrder==SortOrder.Ascending)
{
this.objvUserCodePathSorter.SortOrder=SortOrder.Descending;
if(intLastSelectedvUserCodePathColumIndex == e.Column) //看是否重复点击一列
{
this.lvvUserCodePath.Columns[e.Column].Text = this.lvvUserCodePath.Columns[e.Column].Text.Trim('▲','▼') + "▼";
intLastSelectedvUserCodePathColumIndex = e.Column;
}
else //如果点击另外一列了，那么前面点击的一列三角去掉
{
this.lvvUserCodePath.Columns[e.Column].Text = this.lvvUserCodePath.Columns[e.Column].Text.Trim('▲','▼') + "▼";
this.lvvUserCodePath.Columns[intLastSelectedvUserCodePathColumIndex].Text = this.lvvUserCodePath.Columns[intLastSelectedvUserCodePathColumIndex].Text.Trim('▼','▲');
intLastSelectedvUserCodePathColumIndex = e.Column;
}
}
else if (this.objvUserCodePathSorter.SortOrder==SortOrder.Descending) // ▲ ▼
{
this.objvUserCodePathSorter.SortOrder=SortOrder.Ascending;
if(intLastSelectedvUserCodePathColumIndex == e.Column)
{
this.lvvUserCodePath.Columns[e.Column].Text = this.lvvUserCodePath.Columns[e.Column].Text.Trim('▲','▼') + "▲";
intLastSelectedvUserCodePathColumIndex = e.Column;
}
else
{
this.lvvUserCodePath.Columns[e.Column].Text = this.lvvUserCodePath.Columns[e.Column].Text.Trim('▲','▼') + "▲";
this.lvvUserCodePath.Columns[intLastSelectedvUserCodePathColumIndex].Text = this.lvvUserCodePath.Columns[intLastSelectedvUserCodePathColumIndex].Text.Trim('▲','▼');
intLastSelectedvUserCodePathColumIndex = e.Column;
}
}
else
{
return ;
}
this.lvvUserCodePath.Sort();
}

/// <summary>
/// 实现接口函数，通过子窗体调用，来实现本窗体(父窗体)的LISTVIEW重新绑定功能
/// </summary>
void IBindListView.BindListView()
{
BindLv_vUserCodePath();
}
///生成修改记录准备过程代码 for C#
private void UpdateUserCodePathRecord()
{
if(this.lvvUserCodePath.SelectedItems.Count!=1)
{
DialogResult result;
result = MessageBox.Show("请选择一条记录！");
return;
}
frmUserCodePath_UI frm = new frmUserCodePath_UI();
string strKeyId = this.lvvUserCodePath.SelectedItems[0].Tag.ToString();
frm.mId_key = long.Parse(strKeyId);
frm.iBindListView = this;
frm.OperateType = "Update";
frm.ShowDialog();
}
 ///删除记录过程代码for C#
private void DeleteUserCodePathRecord()
{
DialogResult result;
result = MessageBox.Show("你真的要删除该记录吗？", "确认删除", MessageBoxButtons.YesNo);
if (result == DialogResult.Yes)
{
foreach(ListViewItem lvi in this.lvvUserCodePath.SelectedItems)
{
long lngmId = GetCurrKey(lvi);
if(clsUserCodePathBL.DelRecord(lngmId)== false)
{
MessageBox.Show("删除记录失败！");
BindLv_vUserCodePath();
return ;
}
}
MessageBox.Show("删除记录成功！");
BindLv_vUserCodePath();
}
}
}
}