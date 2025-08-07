
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPHtmlButton
 表名:ASPHtmlButton(00050416)
 生成代码版本:2021.11.17.1
 生成日期:2021/11/18 02:09:29
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
 /// ASPHtml按钮(ASPHtmlButton)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPHtmlButton : ASPControlEx
{
protected new const int mintAttributeCount = 2;
public new static string[] AttributeName = new string[] {"AspHtmlButtonId", "AspHtmlButtonName"};
//以下是属性变量

protected string mstrAspHtmlButtonId;    //AspHtmlButtonId
protected string mstrAspHtmlButtonName;    //AspHtmlButtonName


 /// <summary>
 /// 常量:"AspHtmlButtonId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspHtmlButtonId = "AspHtmlButtonId";    //AspHtmlButtonId

 /// <summary>
 /// 常量:"AspHtmlButtonName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspHtmlButtonName = "AspHtmlButtonName";    //AspHtmlButtonName

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPHtmlButton()
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
if (strAttributeName  ==  con_AspHtmlButtonId)
{
return mstrAspHtmlButtonId;
}
else if (strAttributeName  ==  con_AspHtmlButtonName)
{
return mstrAspHtmlButtonName;
}
return null;
}
set
{
if (strAttributeName  ==  con_AspHtmlButtonId)
{
mstrAspHtmlButtonId = value.ToString();
}
else if (strAttributeName  ==  con_AspHtmlButtonName)
{
mstrAspHtmlButtonName = value.ToString();
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
if (con_AspHtmlButtonId  ==  AttributeName[intIndex])
{
return mstrAspHtmlButtonId;
}
else if (con_AspHtmlButtonName  ==  AttributeName[intIndex])
{
return mstrAspHtmlButtonName;
}
return null;
}
set
{
if (con_AspHtmlButtonId  ==  AttributeName[intIndex])
{
mstrAspHtmlButtonId = value.ToString();
}
else if (con_AspHtmlButtonName  ==  AttributeName[intIndex])
{
mstrAspHtmlButtonName = value.ToString();
}
}
}

/// <summary>
/// AspHtmlButtonId(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspHtmlButtonId
{
get
{
return mstrAspHtmlButtonId;
}
set
{
if (value  ==  "")
{
 mstrAspHtmlButtonId = value;
}
else
{
 mstrAspHtmlButtonId = value;
}
}
}
/// <summary>
/// AspHtmlButtonName(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspHtmlButtonName
{
get
{
return mstrAspHtmlButtonName;
}
set
{
if (value  ==  "")
{
 mstrAspHtmlButtonName = value;
}
else
{
 mstrAspHtmlButtonName = value;
}
}
}
}
}