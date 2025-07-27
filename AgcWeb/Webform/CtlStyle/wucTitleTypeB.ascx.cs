
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:wucTitleTypeB
 表名:TitleType
 生成代码版本:2018.04.19.1
 生成日期:2018/04/29 01:25:44
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
 ///		wucTitleTypeB 的摘要说明。
 /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
 /// </summary>
public partial class wucTitleTypeB : System.Web.UI.UserControl
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
 /// 标题类型ID
 /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
 /// </summary>
public string TitleTypeId
{
get
{
return txtTitleTypeId.Text.Trim();
}
set
{
txtTitleTypeId.Text = value.ToString();
}
}

 /// <summary>
 /// 标题类型
 /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
 /// </summary>
public string TitleTypeName
{
get
{
return txtTitleTypeName.Text.Trim();
}
set
{
txtTitleTypeName.Text = value.ToString();
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
txtTitleTypeId.ReadOnly = bolReadonly;
}
/// <summary>
/// 清除用户自定义控件中，所有控件的值
 /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
/// </summary>	
public void Clear()
{
txtTitleTypeId.Text = "";
txtTitleTypeName.Text = "";
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
txtTitleTypeId.Text = "";
txtTitleTypeName.Text = "";
txtMemo.Text = "";
}
}
}