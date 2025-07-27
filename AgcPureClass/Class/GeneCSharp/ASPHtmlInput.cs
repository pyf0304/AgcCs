
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPHtmlInput
 表名:ASPHtmlInput(00050449)
 生成代码版本:2021.11.17.1
 生成日期:2021/11/18 02:09:31
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
 /// ASPHtmlInput(ASPHtmlInput)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPHtmlInput : ASPControlEx
{
protected new const int mintAttributeCount = 2;
public new static string[] AttributeName = new string[] {"AspHtmlInputId", "AspHtmlInputName"};
//以下是属性变量

protected string mstrAspHtmlInputId;    //AspHtmlInputId
protected string mstrAspHtmlInputName;    //AspHtmlInputName


 /// <summary>
 /// 常量:"AspHtmlInputId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspHtmlInputId = "AspHtmlInputId";    //AspHtmlInputId

 /// <summary>
 /// 常量:"AspHtmlInputName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspHtmlInputName = "AspHtmlInputName";    //AspHtmlInputName

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPHtmlInput()
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
if (strAttributeName  ==  con_AspHtmlInputId)
{
return mstrAspHtmlInputId;
}
else if (strAttributeName  ==  con_AspHtmlInputName)
{
return mstrAspHtmlInputName;
}
return null;
}
set
{
if (strAttributeName  ==  con_AspHtmlInputId)
{
mstrAspHtmlInputId = value.ToString();
}
else if (strAttributeName  ==  con_AspHtmlInputName)
{
mstrAspHtmlInputName = value.ToString();
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
if (con_AspHtmlInputId  ==  AttributeName[intIndex])
{
return mstrAspHtmlInputId;
}
else if (con_AspHtmlInputName  ==  AttributeName[intIndex])
{
return mstrAspHtmlInputName;
}
return null;
}
set
{
if (con_AspHtmlInputId  ==  AttributeName[intIndex])
{
mstrAspHtmlInputId = value.ToString();
}
else if (con_AspHtmlInputName  ==  AttributeName[intIndex])
{
mstrAspHtmlInputName = value.ToString();
}
}
}

/// <summary>
/// AspHtmlInputId(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspHtmlInputId
{
get
{
return mstrAspHtmlInputId;
}
set
{
if (value  ==  "")
{
 mstrAspHtmlInputId = value;
}
else
{
 mstrAspHtmlInputId = value;
}
}
}
/// <summary>
/// AspHtmlInputName(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspHtmlInputName
{
get
{
return mstrAspHtmlInputName;
}
set
{
if (value  ==  "")
{
 mstrAspHtmlInputName = value;
}
else
{
 mstrAspHtmlInputName = value;
}
}
}
}
}