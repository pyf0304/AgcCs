

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
using com.taishsoft.commdb;
using AGC.Entity;
using AGC.BusinessLogic;using AGC.FunClass;using AGC.BusinessLogicEx;

/// <summary>
///		wucSV_RelaTabTypeB 的摘要说明。
/// </summary>
public partial class wucSV_RelaTabTypeB : System.Web.UI.UserControl
{
protected void Page_Load(object sender, System.EventArgs e)
{
// 在此处放置用户代码以初始化页面

}
/// <summary>
/// Sql视图相关表类型Id
/// </summary>
public string SvRelaTabTypeId
{
get
{
return txtSvRelaTabTypeId.Text.Trim();
}
set
{
txtSvRelaTabTypeId.Text = value.ToString();
}
}

/// <summary>
/// Sql视图相关表类型名
/// </summary>
public string SvRelaTabTypeName
{
get
{
return txtSvRelaTabTypeName.Text.Trim();
}
set
{
txtSvRelaTabTypeName.Text = value.ToString();
}
}

/// <summary>
/// 说明
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


public void SetKeyReadOnly(bool bolReadonly)
{
txtSvRelaTabTypeId.ReadOnly = bolReadonly;
}
public void Clear()
{
txtSvRelaTabTypeId.Text = "";
txtSvRelaTabTypeName.Text = "";
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
txtSvRelaTabTypeId.Text = "";
txtSvRelaTabTypeName.Text = "";
txtMemo.Text = "";
}
}
}