
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPDiv
 表名:ASPDiv(00050221)
 生成代码版本:2019.10.18.1
 生成日期:2019/10/18 10:34:48
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
 /// ASP层(ASPDiv)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPDiv : ASPControlEx
{
protected const int mintAttributeCount = 2;
public static string[] AttributeName = new string[] {"AspDivId", "AspDivName"};
//以下是属性变量

/// <summary>
/// ASP层Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
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
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
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
public object this[int intIndex]
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
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPDiv()
 {
 }


 /// <summary>
 /// 常量:"AspDivId"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspDivId = "AspDivId";    //ASP层Id

 /// <summary>
 /// 常量:"AspDivName"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspDivName = "AspDivName";    //ASP层名

protected string mstrAspDivId;    //ASP层Id
protected string mstrAspDivName;    //ASP层名
}
}