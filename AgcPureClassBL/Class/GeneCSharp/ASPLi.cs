
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPLi
 表名:ASPLi(00050435)
 生成代码版本:2019.10.18.1
 生成日期:2019/10/18 10:34:56
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
 /// ASP列表项目(ASPLi)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPLi : ASPControlEx
{
protected const int mintAttributeCount = 2;
public static string[] AttributeName = new string[] {"AspLiId", "AspLiName"};
//以下是属性变量

/// <summary>
/// ASP列表项目Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspLiId
{
get
{
return mstrAspLiId;
}
set
{
if (value  ==  "")
{
 mstrAspLiId = value;
}
else
{
 mstrAspLiId = value;
}
}
}
/// <summary>
/// ASP列表项目名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspLiName
{
get
{
return mstrAspLiName;
}
set
{
if (value  ==  "")
{
 mstrAspLiName = value;
}
else
{
 mstrAspLiName = value;
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
if (strAttributeName  ==  con_AspLiId)
{
return mstrAspLiId;
}
else if (strAttributeName  ==  con_AspLiName)
{
return mstrAspLiName;
}
return null;
}
set
{
if (strAttributeName  ==  con_AspLiId)
{
mstrAspLiId = value.ToString();
}
else if (strAttributeName  ==  con_AspLiName)
{
mstrAspLiName = value.ToString();
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
if (con_AspLiId  ==  AttributeName[intIndex])
{
return mstrAspLiId;
}
else if (con_AspLiName  ==  AttributeName[intIndex])
{
return mstrAspLiName;
}
return null;
}
set
{
if (con_AspLiId  ==  AttributeName[intIndex])
{
mstrAspLiId = value.ToString();
}
else if (con_AspLiName  ==  AttributeName[intIndex])
{
mstrAspLiName = value.ToString();
}
}
}

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPLi()
 {
 }


 /// <summary>
 /// 常量:"AspLiId"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspLiId = "AspLiId";    //ASP列表项目Id

 /// <summary>
 /// 常量:"AspLiName"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspLiName = "AspLiName";    //ASP列表项目名

protected string mstrAspLiId;    //ASP列表项目Id
protected string mstrAspLiName;    //ASP列表项目名
}
}