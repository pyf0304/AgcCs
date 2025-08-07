

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


 /// <summary>
 ///		wucUserIdentityB 的摘要说明。
 /// (AGC.BusinessLogicEx.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
 /// </summary>
public partial class wucUserIdentityB : System.Web.UI.UserControl
{
protected void Page_Load(object sender, System.EventArgs e)
{
// 在此处放置用户代码以初始化页面

}
 /// <summary>
 /// 身份编号
 /// (AGC.BusinessLogicEx.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
 /// </summary>
public string IdentityID
{
get
{
return txtIdentityID.Text.Trim();
}
set
{
txtIdentityID.Text = value.ToString();
}
}

 /// <summary>
 /// 身份描述
 /// (AGC.BusinessLogicEx.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
 /// </summary>
public string IdentityDesc
{
get
{
return txtIdentityDesc.Text.Trim();
}
set
{
txtIdentityDesc.Text = value.ToString();
}
}

 /// <summary>
 /// 备注
 /// (AGC.BusinessLogicEx.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
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
 /// (AGC.BusinessLogicEx.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
/// </summary>
/// <param name = "bolReadonly">是否只读</param>
public void SetKeyReadOnly(bool bolReadonly)
{
txtIdentityID.ReadOnly = bolReadonly;
}
/// <summary>
/// 清除用户自定义控件中，所有控件的值
 /// (AGC.BusinessLogicEx.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
/// </summary>	
public void Clear()
{
txtIdentityID.Text = "";
txtIdentityDesc.Text = "";
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
 /// (AGC.BusinessLogicEx.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
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
 /// (AGC.BusinessLogicEx.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
 /// </summary>
public void SetDefaultValue()
{
txtIdentityID.Text = "";
txtIdentityDesc.Text = "";
txtMemo.Text = "";
}
}
}