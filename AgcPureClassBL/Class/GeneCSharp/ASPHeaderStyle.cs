
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPHeaderStyle
 表名:ASPHeaderStyle(00050232)
 生成代码版本:2019.10.18.1
 生成日期:2019/10/18 10:34:51
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
 /// ASPHeaderStyle(ASPHeaderStyle)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPHeaderStyle : ASPControlEx
{
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"ASPHeaderStyleId", "ASPHeaderStyleName", "Width"};
//以下是属性变量

/// <summary>
/// ASPHeaderStyleId(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string ASPHeaderStyleId
{
get
{
return mstrASPHeaderStyleId;
}
set
{
if (value  ==  "")
{
 mstrASPHeaderStyleId = value;
}
else
{
 mstrASPHeaderStyleId = value;
}
}
}
/// <summary>
/// ASPHeaderStyleName(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string ASPHeaderStyleName
{
get
{
return mstrASPHeaderStyleName;
}
set
{
if (value  ==  "")
{
 mstrASPHeaderStyleName = value;
}
else
{
 mstrASPHeaderStyleName = value;
}
}
}
/// <summary>
/// 宽(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public int Width
{
get
{
return mintWidth;
}
set
{
 mintWidth = value;
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
if (strAttributeName  ==  con_ASPHeaderStyleId)
{
return mstrASPHeaderStyleId;
}
else if (strAttributeName  ==  con_ASPHeaderStyleName)
{
return mstrASPHeaderStyleName;
}
else if (strAttributeName  ==  con_Width)
{
return mintWidth;
}
return null;
}
set
{
if (strAttributeName  ==  con_ASPHeaderStyleId)
{
mstrASPHeaderStyleId = value.ToString();
}
else if (strAttributeName  ==  con_ASPHeaderStyleName)
{
mstrASPHeaderStyleName = value.ToString();
}
else if (strAttributeName  ==  con_Width)
{
mintWidth = clsEntityBase2.TransNullToInt_S(value.ToString());
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
if (con_ASPHeaderStyleId  ==  AttributeName[intIndex])
{
return mstrASPHeaderStyleId;
}
else if (con_ASPHeaderStyleName  ==  AttributeName[intIndex])
{
return mstrASPHeaderStyleName;
}
else if (con_Width  ==  AttributeName[intIndex])
{
return mintWidth;
}
return null;
}
set
{
if (con_ASPHeaderStyleId  ==  AttributeName[intIndex])
{
mstrASPHeaderStyleId = value.ToString();
}
else if (con_ASPHeaderStyleName  ==  AttributeName[intIndex])
{
mstrASPHeaderStyleName = value.ToString();
}
else if (con_Width  ==  AttributeName[intIndex])
{
mintWidth = clsEntityBase2.TransNullToInt_S(value.ToString());
}
}
}

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPHeaderStyle()
 {
 }


 /// <summary>
 /// 常量:"ASPHeaderStyleId"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ASPHeaderStyleId = "ASPHeaderStyleId";    //ASPHeaderStyleId

 /// <summary>
 /// 常量:"ASPHeaderStyleName"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ASPHeaderStyleName = "ASPHeaderStyleName";    //ASPHeaderStyleName

 /// <summary>
 /// 常量:"Width"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Width = "Width";    //宽

protected string mstrASPHeaderStyleId;    //ASPHeaderStyleId
protected string mstrASPHeaderStyleName;    //ASPHeaderStyleName
protected int mintWidth;    //宽
}
}