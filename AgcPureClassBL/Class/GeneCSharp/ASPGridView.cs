
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPGridView
 表名:ASPGridView(00050225)
 生成代码版本:2019.10.18.1
 生成日期:2019/10/18 10:34:50
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
 /// ASP表格视图(ASPGridView)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPGridView : ASPControlEx
{
protected const int mintAttributeCount = 17;
public static string[] AttributeName = new string[] {"ASPGVId", "ASPGVName", "CssClass", "Style", "AllowPaging", "AllowSorting", "AutoGenerateColumns", "IsInTab", "IsJumpPage", "PageSize", "IsRadio", "Runat", "Width", "IsCheck", "FontSize", "FontName", "Height"};
//以下是属性变量

/// <summary>
/// Asp表格视图Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string ASPGVId
{
get
{
return mstrASPGVId;
}
set
{
if (value  ==  "")
{
 mstrASPGVId = value;
}
else
{
 mstrASPGVId = value;
}
}
}
/// <summary>
/// Asp表格视图名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string ASPGVName
{
get
{
return mstrASPGVName;
}
set
{
if (value  ==  "")
{
 mstrASPGVName = value;
}
else
{
 mstrASPGVName = value;
}
}
}
/// <summary>
/// 样式表(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string CssClass
{
get
{
return mstrCssClass;
}
set
{
if (value  ==  "")
{
 mstrCssClass = value;
}
else
{
 mstrCssClass = value;
}
}
}
/// <summary>
/// 类型(说明:;字段类型:varchar;字段长度:800;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string Style
{
get
{
return mstrStyle;
}
set
{
if (value  ==  "")
{
 mstrStyle = value;
}
else
{
 mstrStyle = value;
}
}
}
/// <summary>
/// 允许分页(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public bool AllowPaging
{
get
{
return mbolAllowPaging;
}
set
{
 mbolAllowPaging = value;
}
}
/// <summary>
/// 允许排序(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public bool AllowSorting
{
get
{
return mbolAllowSorting;
}
set
{
 mbolAllowSorting = value;
}
}
/// <summary>
/// 自动生成列(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public bool AutoGenerateColumns
{
get
{
return mbolAutoGenerateColumns;
}
set
{
 mbolAutoGenerateColumns = value;
}
}
/// <summary>
/// 是否生成DG在表中(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public bool IsInTab
{
get
{
return mbolIsInTab;
}
set
{
 mbolIsInTab = value;
}
}
/// <summary>
/// 是否跳页(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public bool IsJumpPage
{
get
{
return mbolIsJumpPage;
}
set
{
 mbolIsJumpPage = value;
}
}
/// <summary>
/// 页大小(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public int PageSize
{
get
{
return mintPageSize;
}
set
{
 mintPageSize = value;
}
}
/// <summary>
/// 是否单选框(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public bool IsRadio
{
get
{
return mbolIsRadio;
}
set
{
 mbolIsRadio = value;
}
}
/// <summary>
/// 运行在(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string Runat
{
get
{
return mstrRunat;
}
set
{
if (value  ==  "")
{
 mstrRunat = value;
}
else
{
 mstrRunat = value;
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
/// <summary>
/// 是否复选框(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public bool IsCheck
{
get
{
return mbolIsCheck;
}
set
{
 mbolIsCheck = value;
}
}
/// <summary>
/// 字号(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string FontSize
{
get
{
return mstrFontSize;
}
set
{
if (value  ==  "")
{
 mstrFontSize = value;
}
else
{
 mstrFontSize = value;
}
}
}
/// <summary>
/// 字体(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string FontName
{
get
{
return mstrFontName;
}
set
{
if (value  ==  "")
{
 mstrFontName = value;
}
else
{
 mstrFontName = value;
}
}
}
/// <summary>
/// 高度(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public int Height
{
get
{
return mintHeight;
}
set
{
 mintHeight = value;
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
if (strAttributeName  ==  con_ASPGVId)
{
return mstrASPGVId;
}
else if (strAttributeName  ==  con_ASPGVName)
{
return mstrASPGVName;
}
else if (strAttributeName  ==  con_CssClass)
{
return mstrCssClass;
}
else if (strAttributeName  ==  con_Style)
{
return mstrStyle;
}
else if (strAttributeName  ==  con_AllowPaging)
{
return mbolAllowPaging;
}
else if (strAttributeName  ==  con_AllowSorting)
{
return mbolAllowSorting;
}
else if (strAttributeName  ==  con_AutoGenerateColumns)
{
return mbolAutoGenerateColumns;
}
else if (strAttributeName  ==  con_IsInTab)
{
return mbolIsInTab;
}
else if (strAttributeName  ==  con_IsJumpPage)
{
return mbolIsJumpPage;
}
else if (strAttributeName  ==  con_PageSize)
{
return mintPageSize;
}
else if (strAttributeName  ==  con_IsRadio)
{
return mbolIsRadio;
}
else if (strAttributeName  ==  con_Runat)
{
return mstrRunat;
}
else if (strAttributeName  ==  con_Width)
{
return mintWidth;
}
else if (strAttributeName  ==  con_IsCheck)
{
return mbolIsCheck;
}
else if (strAttributeName  ==  con_FontSize)
{
return mstrFontSize;
}
else if (strAttributeName  ==  con_FontName)
{
return mstrFontName;
}
else if (strAttributeName  ==  con_Height)
{
return mintHeight;
}
return null;
}
set
{
if (strAttributeName  ==  con_ASPGVId)
{
mstrASPGVId = value.ToString();
}
else if (strAttributeName  ==  con_ASPGVName)
{
mstrASPGVName = value.ToString();
}
else if (strAttributeName  ==  con_CssClass)
{
mstrCssClass = value.ToString();
}
else if (strAttributeName  ==  con_Style)
{
mstrStyle = value.ToString();
}
else if (strAttributeName  ==  con_AllowPaging)
{
mbolAllowPaging = clsEntityBase2.TransNullToBool_S(value.ToString());
}
else if (strAttributeName  ==  con_AllowSorting)
{
mbolAllowSorting = clsEntityBase2.TransNullToBool_S(value.ToString());
}
else if (strAttributeName  ==  con_AutoGenerateColumns)
{
mbolAutoGenerateColumns = clsEntityBase2.TransNullToBool_S(value.ToString());
}
else if (strAttributeName  ==  con_IsInTab)
{
mbolIsInTab = clsEntityBase2.TransNullToBool_S(value.ToString());
}
else if (strAttributeName  ==  con_IsJumpPage)
{
mbolIsJumpPage = clsEntityBase2.TransNullToBool_S(value.ToString());
}
else if (strAttributeName  ==  con_PageSize)
{
mintPageSize = clsEntityBase2.TransNullToInt_S(value.ToString());
}
else if (strAttributeName  ==  con_IsRadio)
{
mbolIsRadio = clsEntityBase2.TransNullToBool_S(value.ToString());
}
else if (strAttributeName  ==  con_Runat)
{
mstrRunat = value.ToString();
}
else if (strAttributeName  ==  con_Width)
{
mintWidth = clsEntityBase2.TransNullToInt_S(value.ToString());
}
else if (strAttributeName  ==  con_IsCheck)
{
mbolIsCheck = clsEntityBase2.TransNullToBool_S(value.ToString());
}
else if (strAttributeName  ==  con_FontSize)
{
mstrFontSize = value.ToString();
}
else if (strAttributeName  ==  con_FontName)
{
mstrFontName = value.ToString();
}
else if (strAttributeName  ==  con_Height)
{
mintHeight = clsEntityBase2.TransNullToInt_S(value.ToString());
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
if (con_ASPGVId  ==  AttributeName[intIndex])
{
return mstrASPGVId;
}
else if (con_ASPGVName  ==  AttributeName[intIndex])
{
return mstrASPGVName;
}
else if (con_CssClass  ==  AttributeName[intIndex])
{
return mstrCssClass;
}
else if (con_Style  ==  AttributeName[intIndex])
{
return mstrStyle;
}
else if (con_AllowPaging  ==  AttributeName[intIndex])
{
return mbolAllowPaging;
}
else if (con_AllowSorting  ==  AttributeName[intIndex])
{
return mbolAllowSorting;
}
else if (con_AutoGenerateColumns  ==  AttributeName[intIndex])
{
return mbolAutoGenerateColumns;
}
else if (con_IsInTab  ==  AttributeName[intIndex])
{
return mbolIsInTab;
}
else if (con_IsJumpPage  ==  AttributeName[intIndex])
{
return mbolIsJumpPage;
}
else if (con_PageSize  ==  AttributeName[intIndex])
{
return mintPageSize;
}
else if (con_IsRadio  ==  AttributeName[intIndex])
{
return mbolIsRadio;
}
else if (con_Runat  ==  AttributeName[intIndex])
{
return mstrRunat;
}
else if (con_Width  ==  AttributeName[intIndex])
{
return mintWidth;
}
else if (con_IsCheck  ==  AttributeName[intIndex])
{
return mbolIsCheck;
}
else if (con_FontSize  ==  AttributeName[intIndex])
{
return mstrFontSize;
}
else if (con_FontName  ==  AttributeName[intIndex])
{
return mstrFontName;
}
else if (con_Height  ==  AttributeName[intIndex])
{
return mintHeight;
}
return null;
}
set
{
if (con_ASPGVId  ==  AttributeName[intIndex])
{
mstrASPGVId = value.ToString();
}
else if (con_ASPGVName  ==  AttributeName[intIndex])
{
mstrASPGVName = value.ToString();
}
else if (con_CssClass  ==  AttributeName[intIndex])
{
mstrCssClass = value.ToString();
}
else if (con_Style  ==  AttributeName[intIndex])
{
mstrStyle = value.ToString();
}
else if (con_AllowPaging  ==  AttributeName[intIndex])
{
mbolAllowPaging = clsEntityBase2.TransNullToBool_S(value.ToString());
}
else if (con_AllowSorting  ==  AttributeName[intIndex])
{
mbolAllowSorting = clsEntityBase2.TransNullToBool_S(value.ToString());
}
else if (con_AutoGenerateColumns  ==  AttributeName[intIndex])
{
mbolAutoGenerateColumns = clsEntityBase2.TransNullToBool_S(value.ToString());
}
else if (con_IsInTab  ==  AttributeName[intIndex])
{
mbolIsInTab = clsEntityBase2.TransNullToBool_S(value.ToString());
}
else if (con_IsJumpPage  ==  AttributeName[intIndex])
{
mbolIsJumpPage = clsEntityBase2.TransNullToBool_S(value.ToString());
}
else if (con_PageSize  ==  AttributeName[intIndex])
{
mintPageSize = clsEntityBase2.TransNullToInt_S(value.ToString());
}
else if (con_IsRadio  ==  AttributeName[intIndex])
{
mbolIsRadio = clsEntityBase2.TransNullToBool_S(value.ToString());
}
else if (con_Runat  ==  AttributeName[intIndex])
{
mstrRunat = value.ToString();
}
else if (con_Width  ==  AttributeName[intIndex])
{
mintWidth = clsEntityBase2.TransNullToInt_S(value.ToString());
}
else if (con_IsCheck  ==  AttributeName[intIndex])
{
mbolIsCheck = clsEntityBase2.TransNullToBool_S(value.ToString());
}
else if (con_FontSize  ==  AttributeName[intIndex])
{
mstrFontSize = value.ToString();
}
else if (con_FontName  ==  AttributeName[intIndex])
{
mstrFontName = value.ToString();
}
else if (con_Height  ==  AttributeName[intIndex])
{
mintHeight = clsEntityBase2.TransNullToInt_S(value.ToString());
}
}
}

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPGridView()
 {
 }


 /// <summary>
 /// 常量:"ASPGVId"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ASPGVId = "ASPGVId";    //Asp表格视图Id

 /// <summary>
 /// 常量:"ASPGVName"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ASPGVName = "ASPGVName";    //Asp表格视图名

 /// <summary>
 /// 常量:"CssClass"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_CssClass = "CssClass";    //样式表

 /// <summary>
 /// 常量:"Style"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Style = "Style";    //类型

 /// <summary>
 /// 常量:"AllowPaging"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AllowPaging = "AllowPaging";    //允许分页

 /// <summary>
 /// 常量:"AllowSorting"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AllowSorting = "AllowSorting";    //允许排序

 /// <summary>
 /// 常量:"AutoGenerateColumns"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AutoGenerateColumns = "AutoGenerateColumns";    //自动生成列

 /// <summary>
 /// 常量:"IsInTab"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsInTab = "IsInTab";    //是否生成DG在表中

 /// <summary>
 /// 常量:"IsJumpPage"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsJumpPage = "IsJumpPage";    //是否跳页

 /// <summary>
 /// 常量:"PageSize"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PageSize = "PageSize";    //页大小

 /// <summary>
 /// 常量:"IsRadio"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsRadio = "IsRadio";    //是否单选框

 /// <summary>
 /// 常量:"Runat"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Runat = "Runat";    //运行在

 /// <summary>
 /// 常量:"Width"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Width = "Width";    //宽

 /// <summary>
 /// 常量:"IsCheck"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsCheck = "IsCheck";    //是否复选框

 /// <summary>
 /// 常量:"FontSize"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_FontSize = "FontSize";    //字号

 /// <summary>
 /// 常量:"FontName"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_FontName = "FontName";    //字体

 /// <summary>
 /// 常量:"Height"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Height = "Height";    //高度

protected string mstrASPGVId;    //Asp表格视图Id
protected string mstrASPGVName;    //Asp表格视图名
protected string mstrCssClass;    //样式表
protected string mstrStyle;    //类型
protected bool mbolAllowPaging;    //允许分页
protected bool mbolAllowSorting;    //允许排序
protected bool mbolAutoGenerateColumns;    //自动生成列
protected bool mbolIsInTab;    //是否生成DG在表中
protected bool mbolIsJumpPage;    //是否跳页
protected int mintPageSize;    //页大小
protected bool mbolIsRadio;    //是否单选框
protected string mstrRunat;    //运行在
protected int mintWidth;    //宽
protected bool mbolIsCheck;    //是否复选框
protected string mstrFontSize;    //字号
protected string mstrFontName;    //字体
protected int mintHeight;    //高度
}
}