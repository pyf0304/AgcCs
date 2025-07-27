
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:wucProgLangTypeB
 表名:ProgLangType
 生成代码版本:2018.04.29.1
 生成日期:2018/04/29 11:48:04
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:101.251.68.133,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统参数
 模块英文名:SysPara
 框架-层名:Web界面层
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2017.11.28.01
      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
//生成与表相关的控件控制层代码
namespace AGC.Webform
{
using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.commdb;

using AGC.Entity;
using AGC.BusinessLogic;using AGC.FunClass;

 /// <summary>
 ///		wucProgLangTypeB 的摘要说明。
 /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
 /// </summary>
public partial class wucProgLangTypeB : System.Web.UI.UserControl
{
 /// <summary>
 /// 函数功能:页面导入,当页面开始运行时所发生的事件
 /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
 /// </summary>
 /// <param name = "sender"></param>
 /// <param name = "e"></param>
protected void Page_Load(object sender, System.EventArgs e)
{
// 在此处放置用户代码以初始化页面

}
 /// <summary>
 /// 编程语言类型Id
 /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
 /// </summary>
public string ProgLangTypeId
{
get
{
return txtProgLangTypeId.Text.Trim();
}
set
{
txtProgLangTypeId.Text = value.ToString();
}
}

 /// <summary>
 /// 编程语言类型名
 /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
 /// </summary>
public string ProgLangTypeName
{
get
{
return txtProgLangTypeName.Text.Trim();
}
set
{
txtProgLangTypeName.Text = value.ToString();
}
}

 /// <summary>
 /// 编程语言类型英文名
 /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
 /// </summary>
public string ProgLangTypeENName
{
get
{
return txtProgLangTypeENName.Text.Trim();
}
set
{
txtProgLangTypeENName.Text = value.ToString();
}
}

 /// <summary>
 /// 字符编码
 /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
 /// </summary>
public string CharEncodingId
{
get
{
if (ddlCharEncodingId.SelectedValue  ==  "0")
return "";
return ddlCharEncodingId.SelectedValue;
}
set
{
if (ddlCharEncodingId.Items.Count>0)
{
if (value  ==  "")
{
ddlCharEncodingId.SelectedValue = "0";
}
else
{
ddlCharEncodingId.SelectedValue = value;
}
}
}
}

 /// <summary>
 /// 是否显示
 /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
 /// </summary>
public bool IsVisible
{
get
{
return chkIsVisible.Checked;
}
set
{
chkIsVisible.Checked = value;
}
}

 /// <summary>
 /// 序号
 /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
 /// </summary>
public int OrderNum
{
get
{
return int.Parse(txtOrderNum.Text.Trim());
}
set
{
txtOrderNum.Text = value.ToString();
}
}

 /// <summary>
 /// 修改日期
 /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
 /// </summary>
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

 /// <summary>
 /// 修改用户Id
 /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
 /// </summary>
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

 /// <summary>
 /// 说明
 /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
 /// </summary>
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


/// <summary>
/// 在用户自定义控件中，设置关键字的值，是否只读
 /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
/// </summary>
/// <param name = "bolReadonly">是否只读</param>
public void SetKeyReadOnly(bool bolReadonly)
{
txtProgLangTypeId.ReadOnly = bolReadonly;
}
/// <summary>
/// 清除用户自定义控件中，所有控件的值
 /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
/// </summary>	
public void Clear()
{
txtProgLangTypeId.Text = "";
txtProgLangTypeName.Text = "";
txtProgLangTypeENName.Text = "";
ddlCharEncodingId.SelectedIndex = 0;
chkIsVisible.Checked = false;
txtOrderNum.Text = "0";
txtUpdDate.Text = "";
txtUpdUserId.Text = "";
txtMemo.Text = "";
}
 /// <summary>
 /// 校验自定义控件中自子控件的类型数值是否是合法正确的。
 /// 一般规则:
 ///		1、首先校验类型:整型、浮点型、日期型等,
 ///			这些代码由自动生成代码帮助生成
 ///		2、校验最值,即最大值和最小值等
 ///			这些代码由自动生成代码帮助生成
 ///		这些生成内容可以修改
 /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
 /// </summary>
 /// <returns></returns>
public bool IsValid(ref string strResult)
{
ComValid_OrderNum.Validate();
if (!ComValid_OrderNum.IsValid) return false;
if (clsString.IsNumeric(txtOrderNum.Text)  ==  false)
{
strResult = "请输入正确的整型!";
return false;
}
return true;
}
 /// <summary>
 /// 设置该控件在插入状态下的缺省值
 /// 一般规则:
 ///		1、如果是整型就默认为0；
 ///		2、如果是浮点型不默认为0.0；
 ///		3、如果是日期型就默认为当前的日期；
 ///		4、如果是位(bit)型就默认为false;
 ///		这些默认值可以再行修改
 /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
 /// </summary>
public void SetDefaultValue()
{
txtProgLangTypeId.Text = "";
txtProgLangTypeName.Text = "";
txtProgLangTypeENName.Text = "";
ddlCharEncodingId.SelectedIndex = 0;
chkIsVisible.Checked = false;
txtOrderNum.Text = "0";
txtUpdDate.Text = "";
txtUpdUserId.Text = "";
txtMemo.Text = "";
}
/// <summary>
/// 为下拉框获取数据,从表:[CharEncoding]中获取
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDdlBindFunction)
/// </summary>
/// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
public System.Data.DataTable GetCharEncodingId()
{
//获取某学院所有专业信息
string strSQL = "select CharEncodingId, CharEncodingName from CharEncoding ";
 clsSpecSQLforSql mySql = clsProgLangTypeBL.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public void BindDdl_CharEncodingId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
ListItem li = new ListItem("请选择...","0");
System.Data.DataTable objDT = GetCharEncodingId();
objDDL.DataValueField = conCharEncoding.CharEncodingId;
objDDL.DataTextField = conCharEncoding.CharEncodingName;
objDDL.DataSource = objDT;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}
public void SetDdl_CharEncodingId()
{
clsCharEncodingBL.BindDdl_CharEncodingId(ddlCharEncodingId);
}
}
}