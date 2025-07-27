
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPHtmlTable
 表名:ASPHtmlTable(00050218)
 生成代码版本:2019.10.18.1
 生成日期:2019/10/18 10:34:53
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
 /// ASPHtml表(ASPHtmlTable)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPHtmlTable : ASPControlEx
{
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"AspHtmlTableId", "AspHtmlTableName", "ColNum", "RowNum"};
//以下是属性变量

/// <summary>
/// AspHtml表Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspHtmlTableId
{
get
{
return mstrAspHtmlTableId;
}
set
{
if (value  ==  "")
{
 mstrAspHtmlTableId = value;
}
else
{
 mstrAspHtmlTableId = value;
}
}
}
/// <summary>
/// AspHtml表名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspHtmlTableName
{
get
{
return mstrAspHtmlTableName;
}
set
{
if (value  ==  "")
{
 mstrAspHtmlTableName = value;
}
else
{
 mstrAspHtmlTableName = value;
}
}
}
/// <summary>
/// 列数(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public int ColNum
{
get
{
return mintColNum;
}
set
{
 mintColNum = value;
}
}
/// <summary>
/// 行数(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public int RowNum
{
get
{
return mintRowNum;
}
set
{
 mintRowNum = value;
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
if (strAttributeName  ==  con_AspHtmlTableId)
{
return mstrAspHtmlTableId;
}
else if (strAttributeName  ==  con_AspHtmlTableName)
{
return mstrAspHtmlTableName;
}
else if (strAttributeName  ==  con_ColNum)
{
return mintColNum;
}
else if (strAttributeName  ==  con_RowNum)
{
return mintRowNum;
}
return null;
}
set
{
if (strAttributeName  ==  con_AspHtmlTableId)
{
mstrAspHtmlTableId = value.ToString();
}
else if (strAttributeName  ==  con_AspHtmlTableName)
{
mstrAspHtmlTableName = value.ToString();
}
else if (strAttributeName  ==  con_ColNum)
{
mintColNum = clsEntityBase2.TransNullToInt_S(value.ToString());
}
else if (strAttributeName  ==  con_RowNum)
{
mintRowNum = clsEntityBase2.TransNullToInt_S(value.ToString());
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
if (con_AspHtmlTableId  ==  AttributeName[intIndex])
{
return mstrAspHtmlTableId;
}
else if (con_AspHtmlTableName  ==  AttributeName[intIndex])
{
return mstrAspHtmlTableName;
}
else if (con_ColNum  ==  AttributeName[intIndex])
{
return mintColNum;
}
else if (con_RowNum  ==  AttributeName[intIndex])
{
return mintRowNum;
}
return null;
}
set
{
if (con_AspHtmlTableId  ==  AttributeName[intIndex])
{
mstrAspHtmlTableId = value.ToString();
}
else if (con_AspHtmlTableName  ==  AttributeName[intIndex])
{
mstrAspHtmlTableName = value.ToString();
}
else if (con_ColNum  ==  AttributeName[intIndex])
{
mintColNum = clsEntityBase2.TransNullToInt_S(value.ToString());
}
else if (con_RowNum  ==  AttributeName[intIndex])
{
mintRowNum = clsEntityBase2.TransNullToInt_S(value.ToString());
}
}
}

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPHtmlTable()
 {
 }


 /// <summary>
 /// 常量:"AspHtmlTableId"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspHtmlTableId = "AspHtmlTableId";    //AspHtml表Id

 /// <summary>
 /// 常量:"AspHtmlTableName"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspHtmlTableName = "AspHtmlTableName";    //AspHtml表名

 /// <summary>
 /// 常量:"ColNum"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ColNum = "ColNum";    //列数

 /// <summary>
 /// 常量:"RowNum"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_RowNum = "RowNum";    //行数

protected string mstrAspHtmlTableId;    //AspHtml表Id
protected string mstrAspHtmlTableName;    //AspHtml表名
protected int mintColNum;    //列数
protected int mintRowNum;    //行数
}
}