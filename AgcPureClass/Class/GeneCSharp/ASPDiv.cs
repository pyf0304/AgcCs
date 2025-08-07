
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPDiv
 表名:ASPDiv(00050221)
 生成代码版本:2021.11.17.1
 生成日期:2021/11/18 02:09:25
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
 /// ASP层(ASPDiv)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPDiv : ASPControlEx
{
protected new const int mintAttributeCount = 2;
public new static string[] AttributeName = new string[] {"AspDivId", "AspDivName"};
//以下是属性变量

protected string mstrAspDivId;    //ASP层Id
protected string mstrAspDivName;    //ASP层名


 /// <summary>
 /// 常量:"AspDivId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspDivId = "AspDivId";    //ASP层Id

 /// <summary>
 /// 常量:"AspDivName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspDivName = "AspDivName";    //ASP层名

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPDiv()
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
if (strAttributeName  ==  con_AspDivId)
{
return mstrAspDivId;
}
else if (strAttributeName  ==  con_AspDivName)
{
return mstrAspDivName;
}
return null;
}
set
{
if (strAttributeName  ==  con_AspDivId)
{
mstrAspDivId = value.ToString();
}
else if (strAttributeName  ==  con_AspDivName)
{
mstrAspDivName = value.ToString();
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
if (con_AspDivId  ==  AttributeName[intIndex])
{
return mstrAspDivId;
}
else if (con_AspDivName  ==  AttributeName[intIndex])
{
return mstrAspDivName;
}
return null;
}
set
{
if (con_AspDivId  ==  AttributeName[intIndex])
{
mstrAspDivId = value.ToString();
}
else if (con_AspDivName  ==  AttributeName[intIndex])
{
mstrAspDivName = value.ToString();
}
}
}

/// <summary>
/// ASP层Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspDivId
{
get
{
return mstrAspDivId;
}
set
{
if (value  ==  "")
{
 mstrAspDivId = value;
}
else
{
 mstrAspDivId = value;
}
}
}
/// <summary>
/// ASP层名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspDivName
{
get
{
return mstrAspDivName;
}
set
{
if (value  ==  "")
{
 mstrAspDivName = value;
}
else
{
 mstrAspDivName = value;
}
}
}
}
}