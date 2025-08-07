
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPLinkButton
 表名:ASPLinkButton(00050230)
 生成代码版本:2021.11.17.1
 生成日期:2021/11/18 02:09:27
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(变量首字母不限定)
 模块中文名:生成C#代码(GeneCSharp)
 框架-层名:纯粹类(PureClass)
 编程语言:CSharp
 注意:1、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
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
protected new const int mintAttributeCount = 2;
public new static string[] AttributeName = new string[] {"AspLinkButtonId", "AspLinkButtonName"};
//以下是属性变量

protected string mstrAspLinkButtonId;    //ASP链接按钮Id
protected string mstrAspLinkButtonName;    //ASP链接按钮名


 /// <summary>
 /// 常量:"AspLinkButtonId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspLinkButtonId = "AspLinkButtonId";    //ASP链接按钮Id

 /// <summary>
 /// 常量:"AspLinkButtonName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspLinkButtonName = "AspLinkButtonName";    //ASP链接按钮名

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPLinkButton()
 {
 }

public new static int AttributeCount
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
public new object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  con_AspLinkButtonId)
{
return mstrAspLinkButtonId;
}
else if (strAttributeName  ==  con_AspLinkButtonName)
{
return mstrAspLinkButtonName;
}
return null;
}
set
{
if (strAttributeName  ==  con_AspLinkButtonId)
{
mstrAspLinkButtonId = value.ToString();
}
else if (strAttributeName  ==  con_AspLinkButtonName)
{
mstrAspLinkButtonName = value.ToString();
}
}
}
/// <summary>
/// 类索引器(Indexer)函数, 整型(INT)序号参数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClsIndexer)
/// </summary>
public new object this[int intIndex]
{
get
{
if (con_AspLinkButtonId  ==  AttributeName[intIndex])
{
return mstrAspLinkButtonId;
}
else if (con_AspLinkButtonName  ==  AttributeName[intIndex])
{
return mstrAspLinkButtonName;
}
return null;
}
set
{
if (con_AspLinkButtonId  ==  AttributeName[intIndex])
{
mstrAspLinkButtonId = value.ToString();
}
else if (con_AspLinkButtonName  ==  AttributeName[intIndex])
{
mstrAspLinkButtonName = value.ToString();
}
}
}

/// <summary>
/// ASP链接按钮Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspLinkButtonId
{
get
{
return mstrAspLinkButtonId;
}
set
{
if (value  ==  "")
{
 mstrAspLinkButtonId = value;
}
else
{
 mstrAspLinkButtonId = value;
}
}
}
/// <summary>
/// ASP链接按钮名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspLinkButtonName
{
get
{
return mstrAspLinkButtonName;
}
set
{
if (value  ==  "")
{
 mstrAspLinkButtonName = value;
}
else
{
 mstrAspLinkButtonName = value;
}
}
}
}
}