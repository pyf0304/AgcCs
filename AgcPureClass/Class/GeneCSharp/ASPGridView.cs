
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPGridView
 表名:ASPGridView(00050225)
 生成代码版本:2021.11.17.1
 生成日期:2021/11/18 02:09:26
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
 /// ASP表格视图(ASPGridView)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPGridView : ASPControlEx
{
protected new const int mintAttributeCount = 12;
public new static string[] AttributeName = new string[] {"AspGVId", "AspGvName", "AllowPaging", "AllowSorting", "AutoGenerateColumns", "IsInTab", "IsJumpPage", "PageSize", "IsRadio", "IsCheck", "FontSize", "FontName"};
//以下是属性变量

protected string mstrAspGVId;    //Asp表格视图Id
protected string mstrAspGvName;    //Asp表格视图名
protected bool mbolAllowPaging;    //允许分页
protected bool mbolAllowSorting;    //允许排序
protected bool mbolAutoGenerateColumns;    //自动生成列
protected bool mbolIsInTab;    //是否生成DG在表中
protected bool mbolIsJumpPage;    //是否跳页
protected int mintPageSize;    //页大小
protected bool mbolIsRadio;    //是否单选框
protected bool mbolIsCheck;    //是否复选框
protected string mstrFontSize;    //字号
protected string mstrFontName;    //字体


 /// <summary>
 /// 常量:"AspGVId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspGVId = "AspGVId";    //Asp表格视图Id

 /// <summary>
 /// 常量:"AspGvName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspGvName = "AspGvName";    //Asp表格视图名

 /// <summary>
 /// 常量:"AllowPaging"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AllowPaging = "AllowPaging";    //允许分页

 /// <summary>
 /// 常量:"AllowSorting"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AllowSorting = "AllowSorting";    //允许排序

 /// <summary>
 /// 常量:"AutoGenerateColumns"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AutoGenerateColumns = "AutoGenerateColumns";    //自动生成列

 /// <summary>
 /// 常量:"IsInTab"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsInTab = "IsInTab";    //是否生成DG在表中

 /// <summary>
 /// 常量:"IsJumpPage"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsJumpPage = "IsJumpPage";    //是否跳页

 /// <summary>
 /// 常量:"PageSize"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PageSize = "PageSize";    //页大小

 /// <summary>
 /// 常量:"IsRadio"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsRadio = "IsRadio";    //是否单选框

 /// <summary>
 /// 常量:"IsCheck"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsCheck = "IsCheck";    //是否复选框

 /// <summary>
 /// 常量:"FontSize"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_FontSize = "FontSize";    //字号

 /// <summary>
 /// 常量:"FontName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_FontName = "FontName";    //字体

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPGridView()
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
if (strAttributeName  ==  con_AspGVId)
{
return mstrAspGVId;
}
else if (strAttributeName  ==  con_AspGvName)
{
return mstrAspGvName;
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
return null;
}
set
{
if (strAttributeName  ==  con_AspGVId)
{
mstrAspGVId = value.ToString();
}
else if (strAttributeName  ==  con_AspGvName)
{
mstrAspGvName = value.ToString();
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
if (con_AspGVId  ==  AttributeName[intIndex])
{
return mstrAspGVId;
}
else if (con_AspGvName  ==  AttributeName[intIndex])
{
return mstrAspGvName;
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
return null;
}
set
{
if (con_AspGVId  ==  AttributeName[intIndex])
{
mstrAspGVId = value.ToString();
}
else if (con_AspGvName  ==  AttributeName[intIndex])
{
mstrAspGvName = value.ToString();
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
}
}

/// <summary>
/// Asp表格视图Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspGVId
{
get
{
return mstrAspGVId;
}
set
{
if (value  ==  "")
{
 mstrAspGVId = value;
}
else
{
 mstrAspGVId = value;
}
}
}
/// <summary>
/// Asp表格视图名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspGvName
{
get
{
return mstrAspGvName;
}
set
{
if (value  ==  "")
{
 mstrAspGvName = value;
}
else
{
 mstrAspGvName = value;
}
}
}
/// <summary>
/// 允许分页(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
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
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
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
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
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
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
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
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
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
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
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
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
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
/// 是否复选框(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
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
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
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
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
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
}
}