
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPCol
 表名:ASPCol(00050220)
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
 /// ASP列(ASPCol)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPCol : ASPControlEx
{
protected new const int mintAttributeCount = 3;
public new static string[] AttributeName = new string[] {"AspColId", "AspColName", "ColSpan"};
//以下是属性变量

protected string mstrAspColId;    //Asp列Id
protected string mstrAspColName;    //Asp列名
protected int mintColSpan;    //跨列数


 /// <summary>
 /// 常量:"AspColId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspColId = "AspColId";    //Asp列Id

 /// <summary>
 /// 常量:"AspColName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspColName = "AspColName";    //Asp列名

 /// <summary>
 /// 常量:"ColSpan"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ColSpan = "ColSpan";    //跨列数

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPCol()
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
if (strAttributeName  ==  con_AspColId)
{
return mstrAspColId;
}
else if (strAttributeName  ==  con_AspColName)
{
return mstrAspColName;
}
else if (strAttributeName  ==  con_ColSpan)
{
return mintColSpan;
}
return null;
}
set
{
if (strAttributeName  ==  con_AspColId)
{
mstrAspColId = value.ToString();
}
else if (strAttributeName  ==  con_AspColName)
{
mstrAspColName = value.ToString();
}
else if (strAttributeName  ==  con_ColSpan)
{
mintColSpan = clsEntityBase2.TransNullToInt_S(value.ToString());
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
if (con_AspColId  ==  AttributeName[intIndex])
{
return mstrAspColId;
}
else if (con_AspColName  ==  AttributeName[intIndex])
{
return mstrAspColName;
}
else if (con_ColSpan  ==  AttributeName[intIndex])
{
return mintColSpan;
}
return null;
}
set
{
if (con_AspColId  ==  AttributeName[intIndex])
{
mstrAspColId = value.ToString();
}
else if (con_AspColName  ==  AttributeName[intIndex])
{
mstrAspColName = value.ToString();
}
else if (con_ColSpan  ==  AttributeName[intIndex])
{
mintColSpan = clsEntityBase2.TransNullToInt_S(value.ToString());
}
}
}

/// <summary>
/// Asp列Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspColId
{
get
{
return mstrAspColId;
}
set
{
if (value  ==  "")
{
 mstrAspColId = value;
}
else
{
 mstrAspColId = value;
}
}
}
/// <summary>
/// Asp列名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspColName
{
get
{
return mstrAspColName;
}
set
{
if (value  ==  "")
{
 mstrAspColName = value;
}
else
{
 mstrAspColName = value;
}
}
}
/// <summary>
/// 跨列数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public int ColSpan
{
get
{
return mintColSpan;
}
set
{
 mintColSpan = value;
}
}
}
}