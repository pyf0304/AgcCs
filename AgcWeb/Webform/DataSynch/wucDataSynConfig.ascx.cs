
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:wucDataSynConfig
 界面名:wfmDataSynConfig_QUDI(00050194)
 生成代码版本:2019.12.06.1
 生成日期:2019/12/16 07:40:31
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.ddns.net,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:数据同步
 模块英文名:DataSynch
 框架-层名:Web用户控件后台(WebCtlControlCode)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
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
using System.Collections.Generic;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.commdb;
using CommFunc4WebForm;

using AGC.Entity;
using AGC.BusinessLogic;
using AGC.BusinessLogicEx;

 /// <summary>
 ///		wucDataSynConfig 的摘要说明。
 /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
 /// </summary>
public partial class wucDataSynConfig : System.Web.UI.UserControl
{

 /// <summary>
 /// 函数功能:页面导入,当页面开始运行时所发生的事件
 /// (AutoGCLib.WebCtlControlCode4CSharp:Gen_Wuc_CS_Page_Load)
 /// </summary>
 /// <param name = "sender"></param>
 /// <param name = "e"></param>
protected void Page_Load(object sender, System.EventArgs e)
{
// 在此处放置用户代码以初始化页面

}


 /// <summary>
 /// 表名
 /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
 /// </summary>
public string TabName
{
get
{
return txtTabName.Text.Trim();
}
set
{
txtTabName.Text = value.ToString();
}
}

 /// <summary>
 /// 是否同步
 /// (AGC.BusinessLogicEx.clsASPCheckBoxBLEx_Static:GC_DefFldProperty)
 /// </summary>
public bool IsSynch
{
get
{
return chkIsSynch.Checked;
}
set
{
chkIsSynch.Checked = value;
}
}

 /// <summary>
 /// 同步条件
 /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
 /// </summary>
public string SynCondition
{
get
{
return txtSynCondition.Text.Trim();
}
set
{
txtSynCondition.Text = value.ToString();
}
}

 /// <summary>
 /// 同步条件4Web
 /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
 /// </summary>
public string SynCondition4Web
{
get
{
return txtSynCondition4Web.Text.Trim();
}
set
{
txtSynCondition4Web.Text = value.ToString();
}
}

 /// <summary>
 /// 同步周期
 /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
 /// </summary>
public string SynchCycle
{
get
{
return txtSynchCycle.Text.Trim();
}
set
{
txtSynchCycle.Text = value.ToString();
}
}

 /// <summary>
 /// 同步日期
 /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
 /// </summary>
public string SynchDate
{
get
{
return txtSynchDate.Text.Trim();
}
set
{
txtSynchDate.Text = value.ToString();
}
}

 /// <summary>
 /// 同步时间
 /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
 /// </summary>
public string SynchTime
{
get
{
return txtSynchTime.Text.Trim();
}
set
{
txtSynchTime.Text = value.ToString();
}
}

 /// <summary>
 /// 发送邮件用户
 /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
 /// </summary>
public string SenderUser
{
get
{
return txtSenderUser.Text.Trim();
}
set
{
txtSenderUser.Text = value.ToString();
}
}

 /// <summary>
 /// 发送邮件口令
 /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
 /// </summary>
public string SenderPwd
{
get
{
return txtSenderPwd.Text.Trim();
}
set
{
txtSenderPwd.Text = value.ToString();
}
}

 /// <summary>
 /// 发送邮件服务器
 /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
 /// </summary>
public string smtp
{
get
{
return txtsmtp.Text.Trim();
}
set
{
txtsmtp.Text = value.ToString();
}
}

 /// <summary>
 /// 接收者
 /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
 /// </summary>
public string Receiver
{
get
{
return txtReceiver.Text.Trim();
}
set
{
txtReceiver.Text = value.ToString();
}
}

 /// <summary>
 /// 最后发邮件日期
 /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
 /// </summary>
public string lastMailDate
{
get
{
return txtlastMailDate.Text.Trim();
}
set
{
txtlastMailDate.Text = value.ToString();
}
}

 /// <summary>
 /// 最后执行日期
 /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
 /// </summary>
public string lastExecuteDate
{
get
{
return txtlastExecuteDate.Text.Trim();
}
set
{
txtlastExecuteDate.Text = value.ToString();
}
}

 /// <summary>
 /// 同步开始时间
 /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
 /// </summary>
public string SynchStartTime
{
get
{
return txtSynchStartTime.Text.Trim();
}
set
{
txtSynchStartTime.Text = value.ToString();
}
}

 /// <summary>
 /// 同步结束时间
 /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
 /// </summary>
public string SynchEndTime
{
get
{
return txtSynchEndTime.Text.Trim();
}
set
{
txtSynchEndTime.Text = value.ToString();
}
}

 /// <summary>
 /// 说明
 /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
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
/// 清除用户自定义控件中，所有控件的值
 /// (AutoGCLib.WebCtlControlCode4CSharp:Gen_Wuc_CS_Clear)
/// </summary>	
public void Clear()
{
txtTabName.Text = "";
chkIsSynch.Checked = false;
txtSynCondition.Text = "";
txtSynCondition4Web.Text = "";
txtSynchCycle.Text = "";
txtSynchDate.Text = "";
txtSynchTime.Text = "";
txtSenderUser.Text = "";
txtSenderPwd.Text = "";
txtsmtp.Text = "";
txtReceiver.Text = "";
txtlastMailDate.Text = "";
txtlastExecuteDate.Text = "";
txtSynchStartTime.Text = "";
txtSynchEndTime.Text = "";
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
 /// (AutoGCLib.WebCtlControlCode4CSharp:Gen_Wuc_CS_IsValid)
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
 /// (AutoGCLib.WebCtlControlCode4CSharp:Gen_Wuc_CS_SetDefaultValue)
 /// </summary>
public void SetDefaultValue()
{
txtTabName.Text = "";
chkIsSynch.Checked = false;
txtSynCondition.Text = "";
txtSynCondition4Web.Text = "";
txtSynchCycle.Text = "";
txtSynchDate.Text = "";
txtSynchTime.Text = "";
txtSenderUser.Text = "";
txtSenderPwd.Text = "";
txtsmtp.Text = "";
txtReceiver.Text = "";
txtlastMailDate.Text = "";
txtlastExecuteDate.Text = "";
txtSynchStartTime.Text = "";
txtSynchEndTime.Text = "";
txtMemo.Text = "";
}

}
}