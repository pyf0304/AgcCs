
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPHtmlTd
 表名:ASPHtmlTd(00050442)
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
 /// ASPHtml表单元格(ASPHtmlTd)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPHtmlTd : ASPControlEx
{
protected const int mintAttributeCount = 2;
public static string[] AttributeName = new string[] {"AspHtmlTdId", "AspHtmlTdName"};
//以下是属性变量

/// <summary>
/// AspHtml表单元格Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspHtmlTdId
{
get
{
return mstrAspHtmlTdId;
}
set
{
if (value  ==  "")
{
 mstrAspHtmlTdId = value;
}
else
{
 mstrAspHtmlTdId = value;
}
}
}
/// <summary>
/// AspHtml表单元格名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspHtmlTdName
{
get
{
return mstrAspHtmlTdName;
}
set
{
if (value  ==  "")
{
 mstrAspHtmlTdName = value;
}
else
{
 mstrAspHtmlTdName = value;
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
if (strAttributeName  ==  con_AspHtmlTdId)
{
return mstrAspHtmlTdId;
}
else if (strAttributeName  ==  con_AspHtmlTdName)
{
return mstrAspHtmlTdName;
}
return null;
}
set
{
if (strAttributeName  ==  con_AspHtmlTdId)
{
mstrAspHtmlTdId = value.ToString();
}
else if (strAttributeName  ==  con_AspHtmlTdName)
{
mstrAspHtmlTdName = value.ToString();
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
if (con_AspHtmlTdId  ==  AttributeName[intIndex])
{
return mstrAspHtmlTdId;
}
else if (con_AspHtmlTdName  ==  AttributeName[intIndex])
{
return mstrAspHtmlTdName;
}
return null;
}
set
{
if (con_AspHtmlTdId  ==  AttributeName[intIndex])
{
mstrAspHtmlTdId = value.ToString();
}
else if (con_AspHtmlTdName  ==  AttributeName[intIndex])
{
mstrAspHtmlTdName = value.ToString();
}
}
}

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPHtmlTd()
 {
 }


 /// <summary>
 /// 常量:"AspHtmlTdId"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspHtmlTdId = "AspHtmlTdId";    //AspHtml表单元格Id

 /// <summary>
 /// 常量:"AspHtmlTdName"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspHtmlTdName = "AspHtmlTdName";    //AspHtml表单元格名

protected string mstrAspHtmlTdId;    //AspHtml表单元格Id
protected string mstrAspHtmlTdName;    //AspHtml表单元格名
}
}