
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPLinkButton
 表名:ASPLinkButton(00050230)
 生成代码版本:2019.10.18.1
 生成日期:2019/10/18 10:34:57
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:AGC
 工程ID:0005
 模块中文名:生成C#代码
 模块英文名:GeneCSharp
 框架-层名:纯粹类(PureClass)
 编程语言:CSharp
 注意:1、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
using System;
using System.Text; 
using System.Collections; 
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System.Runtime.Serialization;

namespace AGC.PureClass
{
 /// <summary>
 /// ASP链接按钮(ASPLinkButton)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPLinkButton : ASPControlEx
{
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"ASPLinkButtonId", "ASPLinkButtonName", "CommandName", "OnClick"};
//以下是属性变量

/// <summary>
/// ASP链接按钮Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string ASPLinkButtonId
{
get
{
return mstrASPLinkButtonId;
}
set
{
if (value  ==  "")
{
 mstrASPLinkButtonId = value;
}
else
{
 mstrASPLinkButtonId = value;
}
}
}
/// <summary>
/// ASP链接按钮名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string ASPLinkButtonName
{
get
{
return mstrASPLinkButtonName;
}
set
{
if (value  ==  "")
{
 mstrASPLinkButtonName = value;
}
else
{
 mstrASPLinkButtonName = value;
}
}
}
/// <summary>
/// 命令名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string CommandName
{
get
{
return mstrCommandName;
}
set
{
if (value  ==  "")
{
 mstrCommandName = value;
}
else
{
 mstrCommandName = value;
}
}
}
/// <summary>
/// 单击事件(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string OnClick
{
get
{
return mstrOnClick;
}
set
{
if (value  ==  "")
{
 mstrOnClick = value;
}
else
{
 mstrOnClick = value;
}
}
}

public static int AttributeCount
{
get
{
return mintAttributeCount;
}
}
/// <summary>
/// 类索引器(Indexer)函数,字符串参数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClsIndexer)
/// </summary>
public object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  con_ASPLinkButtonId)
{
return mstrASPLinkButtonId;
}
else if (strAttributeName  ==  con_ASPLinkButtonName)
{
return mstrASPLinkButtonName;
}
else if (strAttributeName  ==  con_CommandName)
{
return mstrCommandName;
}
else if (strAttributeName  ==  con_OnClick)
{
return mstrOnClick;
}
return null;
}
set
{
if (strAttributeName  ==  con_ASPLinkButtonId)
{
mstrASPLinkButtonId = value.ToString();
}
else if (strAttributeName  ==  con_ASPLinkButtonName)
{
mstrASPLinkButtonName = value.ToString();
}
else if (strAttributeName  ==  con_CommandName)
{
mstrCommandName = value.ToString();
}
else if (strAttributeName  ==  con_OnClick)
{
mstrOnClick = value.ToString();
}
}
}
/// <summary>
/// 类索引器(Indexer)函数, 整型(INT)序号参数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClsIndexer)
/// </summary>
public object this[int intIndex]
{
get
{
if (con_ASPLinkButtonId  ==  AttributeName[intIndex])
{
return mstrASPLinkButtonId;
}
else if (con_ASPLinkButtonName  ==  AttributeName[intIndex])
{
return mstrASPLinkButtonName;
}
else if (con_CommandName  ==  AttributeName[intIndex])
{
return mstrCommandName;
}
else if (con_OnClick  ==  AttributeName[intIndex])
{
return mstrOnClick;
}
return null;
}
set
{
if (con_ASPLinkButtonId  ==  AttributeName[intIndex])
{
mstrASPLinkButtonId = value.ToString();
}
else if (con_ASPLinkButtonName  ==  AttributeName[intIndex])
{
mstrASPLinkButtonName = value.ToString();
}
else if (con_CommandName  ==  AttributeName[intIndex])
{
mstrCommandName = value.ToString();
}
else if (con_OnClick  ==  AttributeName[intIndex])
{
mstrOnClick = value.ToString();
}
}
}

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPLinkButton()
 {
 }


 /// <summary>
 /// 常量:"ASPLinkButtonId"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ASPLinkButtonId = "ASPLinkButtonId";    //ASP链接按钮Id

 /// <summary>
 /// 常量:"ASPLinkButtonName"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ASPLinkButtonName = "ASPLinkButtonName";    //ASP链接按钮名

 /// <summary>
 /// 常量:"CommandName"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_CommandName = "CommandName";    //命令名

 /// <summary>
 /// 常量:"OnClick"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_OnClick = "OnClick";    //单击事件

protected string mstrASPLinkButtonId;    //ASP链接按钮Id
protected string mstrASPLinkButtonName;    //ASP链接按钮名
protected string mstrCommandName;    //命令名
protected string mstrOnClick;    //单击事件
}
}