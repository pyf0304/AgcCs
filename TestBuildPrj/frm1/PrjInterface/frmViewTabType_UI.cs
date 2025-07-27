
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:
 表名:ViewTabType
 生成代码版本:2018.04.05.1
 生成日期:2018/04/06 03:51:13
 生成者:
 工程名称:AGC
 工程ID:0005
 模块中文名:界面管理
 模块英文名:PrjInterface
 框架-层名:Win界面层
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2017.11.28.01
      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
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
using com.taishsoft.common;
using com.taishsoft.datetime;
using CommonTable.Entity;
using AGC.Entity;
using AGC.BusinessLogic;
using com.taishsoft.util;
using CommFunc4Win;

namespace AGC
{
 /// <summary>
 ///		frmViewTabType_UI 的摘要说明。
 /// (AutoGCLib.AutoGC6Cs_VWin:A_GenUpdInsRecCode_NoContral_Net2005)
 /// </summary>
public partial class frmViewTabType_UI : System.Windows.Forms.Form
{
clsViewTabTypeEN objViewTabTypeEN = null;
private string mstrViewTabTypeId;		//用于传递关键字值的变量
public string OperateType;
public IBindListView iBindListView = null;
public frmViewTabType_UI()
{
// 该调用是 Windows.Forms 窗体设计器所必需的。
InitializeComponent();

// TODO: 在 InitializeComponent 调用后添加任何初始化

}
private void frmViewTabType_UI_Load(object sender, System.EventArgs e)
{
// 在此处放置用户代码以初始化页面
//1、为下拉框设置数据源,绑定列表数据
this.SetAllComboBox();
if (OperateType == "Update")
{
ShowData(mstrViewTabTypeId);
btnOKUpd.Text = "确认修改";
}
else
{
AddViewTabTypeRecord();
}

}
 /// <summary>
 /// 下拉框的绑定函数
 /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:Genfun_SetAllComboBox4Edit)
 /// </summary>
private void SetAllComboBox()
{
}
 /// <summary>
 /// 界面表类型码
 /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:Genfun_ViewCtrlProperty4Edit)
 /// </summary>
public string ViewTabTypeId
{
get
{
return txtViewTabTypeId.Text.Trim();
}
set
{
txtViewTabTypeId.Text = value.ToString();
}
}

 /// <summary>
 /// ViewTabTypeName
 /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:Genfun_ViewCtrlProperty4Edit)
 /// </summary>
public string ViewTabTypeName
{
get
{
return txtViewTabTypeName.Text.Trim();
}
set
{
txtViewTabTypeName.Text = value.ToString();
}
}

 /// <summary>
 /// TabTypeFunction
 /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:Genfun_ViewCtrlProperty4Edit)
 /// </summary>
public string TabTypeFunction
{
get
{
return txtTabTypeFunction.Text.Trim();
}
set
{
txtTabTypeFunction.Text = value.ToString();
}
}


/// <summary>
/// 在用户自定义控件中，设置关键字的值，是否只读
 /// (AutoGCLib.AutoGC6Cs_VWin:A_GenUpdInsRecCode_NoContral_Net2005)
/// </summary>
/// <param name = "bolReadonly">是否只读</param>
public void SetKeyReadOnly(bool bolReadonly)
{
txtViewTabTypeId.ReadOnly = bolReadonly;
}
/// <summary>
/// 清除用户自定义控件中，所有控件的值
 /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:Genfun_Clear4EditResion)
/// </summary>	
public void Clear()
{
txtViewTabTypeId.Text = "";
txtViewTabTypeName.Text = "";
txtTabTypeFunction.Text = "";
}
 /// <summary>
 /// 设置该控件在插入状态下的缺省值
 /// 一般规则:
 ///		1、如果是整型就默认为0；
 ///		2、如果是浮点型不默认为0.0；
 ///		3、如果是日期型就默认为当前的日期；
 ///		4、如果是位(bit)型就默认为false;
 ///		这些默认值可以再行修改
 /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:Genfun_SetDefaultValue4EditRegion)
 /// </summary>
public void SetDefaultValue()
{
txtViewTabTypeId.Text = "";
txtViewTabTypeName.Text = "";
txtTabTypeFunction.Text = "";
}
 /// <summary>
 /// 校验自定义控件中自子控件的类型数值是否是合法正确的。
 /// 一般规则:
 ///		1、首先校验类型:整型、浮点型、日期型等,
 ///			这些代码由自动生成代码帮助生成
 ///		2、校验最值,即最大值和最小值等
 ///			这些代码由自动生成代码帮助生成
 ///		这些生成内容可以修改
 /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:Genfun_IsValid)
 /// </summary>
 /// <returns></returns>
public bool IsValid(ref string strResult)
{
return true;
}

 /// <summary>
 /// 函数功能:把以该关键字的记录内容显示在界面上,
 ///　　　   在这里是把值传到表控件中
 /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:GenShowDataCode_Win)
 /// </summary>
 /// <param name = "strViewTabTypeId">表记录的关键字,显示该表关键字的内容</param>
private void ShowData(string strViewTabTypeId)
{
//操作步骤:
//1、检查关键字是否为空；
//2、检查该关键字的记录是否存在,如果不存在就返回不显示；
//3、用提供的关键字初始化一个类对象；
//4、获取类对象的所有属性；
//5、把该对象的所有属性显示在界面上,在这里显示在表控件中

//1、检查关键字是否为空；
if (strViewTabTypeId == "") return ;		//如果关键字为空就返回退出
//2、检查该关键字的记录是否存在,如果不存在就返回不显示；
if (clsViewTabTypeBL.IsExist(strViewTabTypeId) == false)		//检查该关键字的记录是否存在
{
string strMsg = "(errid:WinI000003)在表[ViewTabType]中,关键字为:[strViewTabTypeId]的记录不存在!";
MessageBox.Show(strMsg);
return ;
}
//3、用提供的关键字初始化一个类对象；
objViewTabTypeEN = new clsViewTabTypeEN(strViewTabTypeId);
//4、获取类对象的所有属性；
clsViewTabTypeBL.GetViewTabType(ref objViewTabTypeEN);
//5、把该对象的所有属性显示在界面上,在这里显示在表控件中
GetDataFromViewTabTypeClass(objViewTabTypeEN);
}
 /// <summary>
 /// 函数功能:把类对象的属性内容显示到界面上
 ///注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
 ///   如果在设置数据库时,就应该一级字段在前,二级字段在后
 /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:GenGetDataFromClass)
 /// </summary>
 /// <param name = "pobjViewTabTypeEN">表实体类对象</param>
private void GetDataFromViewTabTypeClass(clsViewTabTypeEN pobjViewTabTypeEN)
{
 ///注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
 ///   如果在设置数据库时,就应该一级字段在前,二级字段在后
this.ViewTabTypeId = pobjViewTabTypeEN.ViewTabTypeId;
this.ViewTabTypeName = pobjViewTabTypeEN.ViewTabTypeName;
this.TabTypeFunction = pobjViewTabTypeEN.TabTypeFunction;
}
 /// <summary>
 /// 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
 ///      具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
 /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:GenbtnOKUpd_Click)
 /// </summary>
 /// <param name = "sender"></param>
 /// <param name = "e"></param>
private void btnOKUpd_Click(object sender, System.EventArgs e)
{
string strCommandText;
Button btnTemp = (Button) sender;
strCommandText = btnTemp.Text;
switch(strCommandText)
{
case "添加":
AddViewTabTypeRecord();
break;				
case "确认添加":
//这是一个单表的插入的代码,由于逻辑层太简单,
//就把逻辑层合并到控制层,
AddViewTabTypeRecordSave();
break;
case "确认修改":
//这是一个单表的修改的代码,由于逻辑层太简单,
//就把逻辑层合并到控制层,
UpdateViewTabTypeRecordSave(objViewTabTypeEN);
break;
}
}
private void PutDataToViewTabTypeClass(clsViewTabTypeEN pobjViewTabTypeEN)
{
pobjViewTabTypeEN.ViewTabTypeId = this.ViewTabTypeId;
pobjViewTabTypeEN.ViewTabTypeName = this.ViewTabTypeName;
pobjViewTabTypeEN.TabTypeFunction = this.TabTypeFunction;
}
private void btnClose_Click(object sender, System.EventArgs e)
{
this.Close();
}
public string ViewTabTypeId_key
{
get
{
return mstrViewTabTypeId;
}
set
{
mstrViewTabTypeId = value;
}
}
 /// <summary>
 /// 为插入记录做准备工作
 /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:GenAddRecordCode)
 /// </summary>
protected void AddViewTabTypeRecord()
{
this.SetKeyReadOnly(false);
btnOKUpd.Text = "确认添加";
//this.ViewTabTypeId = clsViewTabTypeBL.GetMaxStrId_S();
//DispEditViewTabTypeRegion();
}
 /// <summary>
 /// 插入记录存盘到数据表中
 /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:GenAddRecordSaveCode)
 /// </summary>
 /// <returns>插入记录是否成功？</returns>
private void AddViewTabTypeRecordSave()
{
//操作步骤:
//1、检查控件中输入数据类型是否正确
//2、定义对象并初始化对象
//3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//4、把值从界面层传到逻辑层或数据实体层
//5、检查传进去的对象属性是否合法
//6、把数据实体层的数据存贮到数据库中
//7、把新添的记录内容显示在GridView中
string strMsg;	//专门用于传递信息的变量
string strResult = " ";	//用于传递在检验对象属性时结果值的变量
clsViewTabTypeEN objViewTabType;
//1、检查控件中输入数据类型是否正确
if (!this.IsValid(ref strResult))
{
lblMsg.Text = "(errid:WinI000004)控件中输入数据类型不正确请检查!";
return ;
}
//2、初始化相关类对象
objViewTabTypeEN = new clsViewTabTypeEN(this.ViewTabTypeId);	//初始化新对象
//3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsViewTabTypeBL.IsExist(ViewTabTypeId))	//判断是否有相同的关键字
{
strMsg = string.Format("(errid:WinI000005)关键字字段已有相同的值!(frmViewTabType_UI: AddViewTabTypeRecordSave).");
MessageBox.Show(strMsg);
return;
}
//4、把值从界面层传到逻辑层或数据实体层
PutDataToViewTabTypeClass(objViewTabTypeEN);		//把界面的值传到
//5、检查传进去的对象属性是否合法
try
{
clsViewTabTypeBL.CheckPropertyNew(objViewTabTypeEN);
//6、把数据实体层的数据存贮到数据库中
clsViewTabTypeBL.AddNewRecordBySql2(objViewTabTypeEN);
}
catch(Exception objException)
{
strMsg = string.Format("(errid:WinI000006)添加记录不成功!(frmViewTabType_UI: AddViewTabTypeRecordSave)错误信息:{0}.", objException.Message);
MessageBox.Show(strMsg);
lblMsg.Text = strMsg;
return;
}
strMsg = "添加记录成功!";
MessageBox.Show(strMsg);
lblMsg.Text = strMsg;
//7、恢复<确认添加>变成<添加>
btnOKUpd.Text = "添加";
//8、调用父窗体中函数BINDLISTVIEW()把父窗体中的LISTVIEW内容重新显示一下。
iBindListView.BindListView();
}
 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.AutoGC_Cs_VWin_PubFun:GenUpdateRecordSaveCode)
 /// </summary>
 /// <param name = "objViewTabTypeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
private void UpdateViewTabTypeRecordSave(clsViewTabTypeEN objViewTabTypeEN)
{
//操作步骤:
//1、检查控件中输入数据类型是否正确
//2、把值从界面层传到逻辑层或数据实体层
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
//5、把修改后的内容显示在GridView中
string strMsg;	//专门用于传递信息的变量
string strResult = " ";	//用于传递在检验对象属性时结果值的变量
//1、检查控件中输入数据类型是否正确
if (!this.IsValid(ref strResult))
{
lblMsg.Text = "(errid:WinI000007)控件中输入数据类型不正确请检查!";
return ;
}
//2、把值从界面层传到逻辑层或数据实体层
PutDataToViewTabTypeClass(objViewTabTypeEN);		//把界面的值传到
//3、检查传进去的对象属性是否合法
try
{
clsViewTabTypeBL.CheckPropertyNew(objViewTabTypeEN);
//6、把数据实体层的数据存贮到数据库中
clsViewTabTypeBL.UpdateBySql2(objViewTabTypeEN);
}
catch(Exception objException)
{
strMsg = string.Format("(errid:WinI000008)修改记录不成功!(frmViewTabType_UI: UpdateViewTabTypeRecordSave)错误信息:{0}.", objException.Message);
MessageBox.Show(strMsg);
lblMsg.Text = strMsg;
return ; 
}
strMsg = "修改记录成功!";
MessageBox.Show(strMsg);
lblMsg.Text = strMsg;
this.Close();
//5、恢复<确认修改>变成<添加>
btnOKUpd.Text = "添加";
//6、调用父窗体中函数BINDLISTVIEW()把父窗体中的LISTVIEW内容重新显示一下。
iBindListView.BindListView();
}
}
}