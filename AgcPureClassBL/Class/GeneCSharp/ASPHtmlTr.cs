
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPHtmlTr
 表名:ASPHtmlTr(00050441)
 生成代码版本:2019.10.18.1
 生成日期:2019/10/18 10:34:54
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
 /// ASPHtml表行(ASPHtmlTr)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPHtmlTr : ASPControlEx
{
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"AspHtmlTrId", "AspHtmlTrName", "ColNum"};
//以下是属性变量

/// <summary>
/// AspHtml表行Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspHtmlTrId
{
get
{
return mstrAspHtmlTrId;
}
set
{
if (value  ==  "")
{
 mstrAspHtmlTrId = value;
}
else
{
 mstrAspHtmlTrId = value;
}
}
}
/// <summary>
/// AspHtml表行名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspHtmlTrName
{
get
{
return mstrAspHtmlTrName;
}
set
{
if (value  ==  "")
{
 mstrAspHtmlTrName = value;
}
else
{
 mstrAspHtmlTrName = value;
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
if (strAttributeName  ==  con_AspHtmlTrId)
{
return mstrAspHtmlTrId;
}
else if (strAttributeName  ==  con_AspHtmlTrName)
{
return mstrAspHtmlTrName;
}
else if (strAttributeName  ==  con_ColNum)
{
return mintColNum;
}
return null;
}
set
{
if (strAttributeName  ==  con_AspHtmlTrId)
{
mstrAspHtmlTrId = value.ToString();
}
else if (strAttributeName  ==  con_AspHtmlTrName)
{
mstrAspHtmlTrName = value.ToString();
}
else if (strAttributeName  ==  con_ColNum)
{
mintColNum = clsEntityBase2.TransNullToInt_S(value.ToString());
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
if (con_AspHtmlTrId  ==  AttributeName[intIndex])
{
return mstrAspHtmlTrId;
}
else if (con_AspHtmlTrName  ==  AttributeName[intIndex])
{
return mstrAspHtmlTrName;
}
else if (con_ColNum  ==  AttributeName[intIndex])
{
return mintColNum;
}
return null;
}
set
{
if (con_AspHtmlTrId  ==  AttributeName[intIndex])
{
mstrAspHtmlTrId = value.ToString();
}
else if (con_AspHtmlTrName  ==  AttributeName[intIndex])
{
mstrAspHtmlTrName = value.ToString();
}
else if (con_ColNum  ==  AttributeName[intIndex])
{
mintColNum = clsEntityBase2.TransNullToInt_S(value.ToString());
}
}
}

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPHtmlTr()
 {
 }


 /// <summary>
 /// 常量:"AspHtmlTrId"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspHtmlTrId = "AspHtmlTrId";    //AspHtml表行Id

 /// <summary>
 /// 常量:"AspHtmlTrName"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspHtmlTrName = "AspHtmlTrName";    //AspHtml表行名

 /// <summary>
 /// 常量:"ColNum"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ColNum = "ColNum";    //列数

protected string mstrAspHtmlTrId;    //AspHtml表行Id
protected string mstrAspHtmlTrName;    //AspHtml表行名
protected int mintColNum;    //列数
}
}