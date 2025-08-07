
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPRow
 表名:ASPRow(00050219)
 生成代码版本:2019.10.18.1
 生成日期:2019/10/18 10:34:59
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
 /// ASP行(ASPRow)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPRow : ASPControlEx
{
protected const int mintAttributeCount = 2;
public static string[] AttributeName = new string[] {"AspRowId", "AspRowName"};
//以下是属性变量

/// <summary>
/// Asp行Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspRowId
{
get
{
return mstrAspRowId;
}
set
{
if (value  ==  "")
{
 mstrAspRowId = value;
}
else
{
 mstrAspRowId = value;
}
}
}
/// <summary>
/// Asp行名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspRowName
{
get
{
return mstrAspRowName;
}
set
{
if (value  ==  "")
{
 mstrAspRowName = value;
}
else
{
 mstrAspRowName = value;
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
if (strAttributeName  ==  con_AspRowId)
{
return mstrAspRowId;
}
else if (strAttributeName  ==  con_AspRowName)
{
return mstrAspRowName;
}
return null;
}
set
{
if (strAttributeName  ==  con_AspRowId)
{
mstrAspRowId = value.ToString();
}
else if (strAttributeName  ==  con_AspRowName)
{
mstrAspRowName = value.ToString();
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
if (con_AspRowId  ==  AttributeName[intIndex])
{
return mstrAspRowId;
}
else if (con_AspRowName  ==  AttributeName[intIndex])
{
return mstrAspRowName;
}
return null;
}
set
{
if (con_AspRowId  ==  AttributeName[intIndex])
{
mstrAspRowId = value.ToString();
}
else if (con_AspRowName  ==  AttributeName[intIndex])
{
mstrAspRowName = value.ToString();
}
}
}

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPRow()
 {
 }


 /// <summary>
 /// 常量:"AspRowId"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspRowId = "AspRowId";    //Asp行Id

 /// <summary>
 /// 常量:"AspRowName"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspRowName = "AspRowName";    //Asp行名

protected string mstrAspRowId;    //Asp行Id
protected string mstrAspRowName;    //Asp行名
}
}