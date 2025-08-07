
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDataGridStyleEN
 表名:DataGridStyle(00050005)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:35:15
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:界面管理(PrjInterface)
 框架-层名:实体层(CS)(EntityLayer,0001)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Text; 
using System.Collections; 

using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace AGC.Entity
{
 /// <summary>
 /// 表DataGridStyle的关键字(DgStyleId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_DgStyleId_DataGridStyle
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strDgStyleId">表关键字</param>
public K_DgStyleId_DataGridStyle(string strDgStyleId)
{
if (IsValid(strDgStyleId)) Value = strDgStyleId;
else
{
Value = null;
}
}
private static bool IsValid(string strDgStyleId)
{
if (string.IsNullOrEmpty(strDgStyleId) == true) return false;
if (strDgStyleId.Length > 4) return false;
if (strDgStyleId.IndexOf(' ') >= 0) return false;
if (strDgStyleId.IndexOf(')') >= 0) return false;
if (strDgStyleId.IndexOf('(') >= 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_DgStyleId_DataGridStyle]类型的对象</returns>
public static implicit operator K_DgStyleId_DataGridStyle(string value)
{
return new K_DgStyleId_DataGridStyle(value);
}
}
 /// <summary>
 /// DataGrid类型(DataGridStyle)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsDataGridStyleEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "DataGridStyle"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "DgStyleId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 24;
public static string[] _AttributeName = new string[] {"DgStyleId", "DgStyleName", "Runat", "FontSize", "FontName", "AllowPaging", "PageSize", "AutoGenerateColumns", "AllowSorting", "IsRadio", "IsCheck", "IsJumpPage", "IsHaveUpdBtn", "IsHaveDelBtn", "IsHaveDetailBtn", "IsInTab", "StyleZindex", "StyleLeft", "StylePosition", "Width", "Height", "StyleTop", "Style", "IsDefault"};

protected string mstrDgStyleId;    //DG模式ID
protected string mstrDgStyleName;    //DG模式名
protected string mstrRunat;    //运行在
protected string mstrFontSize;    //字号
protected string mstrFontName;    //字体
protected bool mbolAllowPaging;    //允许分页
protected int? mintPageSize;    //页大小
protected bool mbolAutoGenerateColumns;    //自动生成列
protected bool mbolAllowSorting;    //允许排序
protected bool mbolIsRadio;    //是否单选框
protected bool mbolIsCheck;    //是否复选框
protected bool mbolIsJumpPage;    //是否跳页
protected bool mbolIsHaveUpdBtn;    //是否有修改按钮
protected bool mbolIsHaveDelBtn;    //是否有删除按钮
protected bool mbolIsHaveDetailBtn;    //是否有详细按钮
protected bool mbolIsInTab;    //是否生成DG在表中
protected int? mintStyleZindex;    //Style_Zindex
protected int? mintStyleLeft;    //Style_Left
protected string mstrStylePosition;    //Style_Position
protected int? mintWidth;    //宽
protected int? mintHeight;    //高度
protected int? mintStyleTop;    //Style_Top
protected string mstrStyle;    //类型
protected bool mbolIsDefault;    //是否默认

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsDataGridStyleEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("DgStyleId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strDgStyleId">关键字:DG模式ID</param>
public clsDataGridStyleEN(string strDgStyleId)
 {
strDgStyleId = strDgStyleId.Replace("'", "''");
if (strDgStyleId.Length > 4)
{
throw new Exception("在表:DataGridStyle中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strDgStyleId)  ==  true)
{
throw new Exception("在表:DataGridStyle中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strDgStyleId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrDgStyleId = strDgStyleId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("DgStyleId");
 }

public static int AttributeCount
{
get
{
return _AttributeCount;
}
}
public override object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  conDataGridStyle.DgStyleId)
{
return mstrDgStyleId;
}
else if (strAttributeName  ==  conDataGridStyle.DgStyleName)
{
return mstrDgStyleName;
}
else if (strAttributeName  ==  conDataGridStyle.Runat)
{
return mstrRunat;
}
else if (strAttributeName  ==  conDataGridStyle.FontSize)
{
return mstrFontSize;
}
else if (strAttributeName  ==  conDataGridStyle.FontName)
{
return mstrFontName;
}
else if (strAttributeName  ==  conDataGridStyle.AllowPaging)
{
return mbolAllowPaging;
}
else if (strAttributeName  ==  conDataGridStyle.PageSize)
{
return mintPageSize;
}
else if (strAttributeName  ==  conDataGridStyle.AutoGenerateColumns)
{
return mbolAutoGenerateColumns;
}
else if (strAttributeName  ==  conDataGridStyle.AllowSorting)
{
return mbolAllowSorting;
}
else if (strAttributeName  ==  conDataGridStyle.IsRadio)
{
return mbolIsRadio;
}
else if (strAttributeName  ==  conDataGridStyle.IsCheck)
{
return mbolIsCheck;
}
else if (strAttributeName  ==  conDataGridStyle.IsJumpPage)
{
return mbolIsJumpPage;
}
else if (strAttributeName  ==  conDataGridStyle.IsHaveUpdBtn)
{
return mbolIsHaveUpdBtn;
}
else if (strAttributeName  ==  conDataGridStyle.IsHaveDelBtn)
{
return mbolIsHaveDelBtn;
}
else if (strAttributeName  ==  conDataGridStyle.IsHaveDetailBtn)
{
return mbolIsHaveDetailBtn;
}
else if (strAttributeName  ==  conDataGridStyle.IsInTab)
{
return mbolIsInTab;
}
else if (strAttributeName  ==  conDataGridStyle.StyleZindex)
{
return mintStyleZindex;
}
else if (strAttributeName  ==  conDataGridStyle.StyleLeft)
{
return mintStyleLeft;
}
else if (strAttributeName  ==  conDataGridStyle.StylePosition)
{
return mstrStylePosition;
}
else if (strAttributeName  ==  conDataGridStyle.Width)
{
return mintWidth;
}
else if (strAttributeName  ==  conDataGridStyle.Height)
{
return mintHeight;
}
else if (strAttributeName  ==  conDataGridStyle.StyleTop)
{
return mintStyleTop;
}
else if (strAttributeName  ==  conDataGridStyle.Style)
{
return mstrStyle;
}
else if (strAttributeName  ==  conDataGridStyle.IsDefault)
{
return mbolIsDefault;
}
return null;
}
set
{
if (strAttributeName  ==  conDataGridStyle.DgStyleId)
{
mstrDgStyleId = value.ToString();
 AddUpdatedFld(conDataGridStyle.DgStyleId);
}
else if (strAttributeName  ==  conDataGridStyle.DgStyleName)
{
mstrDgStyleName = value.ToString();
 AddUpdatedFld(conDataGridStyle.DgStyleName);
}
else if (strAttributeName  ==  conDataGridStyle.Runat)
{
mstrRunat = value.ToString();
 AddUpdatedFld(conDataGridStyle.Runat);
}
else if (strAttributeName  ==  conDataGridStyle.FontSize)
{
mstrFontSize = value.ToString();
 AddUpdatedFld(conDataGridStyle.FontSize);
}
else if (strAttributeName  ==  conDataGridStyle.FontName)
{
mstrFontName = value.ToString();
 AddUpdatedFld(conDataGridStyle.FontName);
}
else if (strAttributeName  ==  conDataGridStyle.AllowPaging)
{
mbolAllowPaging = TransNullToBool(value.ToString());
 AddUpdatedFld(conDataGridStyle.AllowPaging);
}
else if (strAttributeName  ==  conDataGridStyle.PageSize)
{
mintPageSize = TransNullToInt(value.ToString());
 AddUpdatedFld(conDataGridStyle.PageSize);
}
else if (strAttributeName  ==  conDataGridStyle.AutoGenerateColumns)
{
mbolAutoGenerateColumns = TransNullToBool(value.ToString());
 AddUpdatedFld(conDataGridStyle.AutoGenerateColumns);
}
else if (strAttributeName  ==  conDataGridStyle.AllowSorting)
{
mbolAllowSorting = TransNullToBool(value.ToString());
 AddUpdatedFld(conDataGridStyle.AllowSorting);
}
else if (strAttributeName  ==  conDataGridStyle.IsRadio)
{
mbolIsRadio = TransNullToBool(value.ToString());
 AddUpdatedFld(conDataGridStyle.IsRadio);
}
else if (strAttributeName  ==  conDataGridStyle.IsCheck)
{
mbolIsCheck = TransNullToBool(value.ToString());
 AddUpdatedFld(conDataGridStyle.IsCheck);
}
else if (strAttributeName  ==  conDataGridStyle.IsJumpPage)
{
mbolIsJumpPage = TransNullToBool(value.ToString());
 AddUpdatedFld(conDataGridStyle.IsJumpPage);
}
else if (strAttributeName  ==  conDataGridStyle.IsHaveUpdBtn)
{
mbolIsHaveUpdBtn = TransNullToBool(value.ToString());
 AddUpdatedFld(conDataGridStyle.IsHaveUpdBtn);
}
else if (strAttributeName  ==  conDataGridStyle.IsHaveDelBtn)
{
mbolIsHaveDelBtn = TransNullToBool(value.ToString());
 AddUpdatedFld(conDataGridStyle.IsHaveDelBtn);
}
else if (strAttributeName  ==  conDataGridStyle.IsHaveDetailBtn)
{
mbolIsHaveDetailBtn = TransNullToBool(value.ToString());
 AddUpdatedFld(conDataGridStyle.IsHaveDetailBtn);
}
else if (strAttributeName  ==  conDataGridStyle.IsInTab)
{
mbolIsInTab = TransNullToBool(value.ToString());
 AddUpdatedFld(conDataGridStyle.IsInTab);
}
else if (strAttributeName  ==  conDataGridStyle.StyleZindex)
{
mintStyleZindex = TransNullToInt(value.ToString());
 AddUpdatedFld(conDataGridStyle.StyleZindex);
}
else if (strAttributeName  ==  conDataGridStyle.StyleLeft)
{
mintStyleLeft = TransNullToInt(value.ToString());
 AddUpdatedFld(conDataGridStyle.StyleLeft);
}
else if (strAttributeName  ==  conDataGridStyle.StylePosition)
{
mstrStylePosition = value.ToString();
 AddUpdatedFld(conDataGridStyle.StylePosition);
}
else if (strAttributeName  ==  conDataGridStyle.Width)
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(conDataGridStyle.Width);
}
else if (strAttributeName  ==  conDataGridStyle.Height)
{
mintHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(conDataGridStyle.Height);
}
else if (strAttributeName  ==  conDataGridStyle.StyleTop)
{
mintStyleTop = TransNullToInt(value.ToString());
 AddUpdatedFld(conDataGridStyle.StyleTop);
}
else if (strAttributeName  ==  conDataGridStyle.Style)
{
mstrStyle = value.ToString();
 AddUpdatedFld(conDataGridStyle.Style);
}
else if (strAttributeName  ==  conDataGridStyle.IsDefault)
{
mbolIsDefault = TransNullToBool(value.ToString());
 AddUpdatedFld(conDataGridStyle.IsDefault);
}
}
}
public object this[int intIndex]
{
get
{
if (conDataGridStyle.DgStyleId  ==  _AttributeName[intIndex])
{
return mstrDgStyleId;
}
else if (conDataGridStyle.DgStyleName  ==  _AttributeName[intIndex])
{
return mstrDgStyleName;
}
else if (conDataGridStyle.Runat  ==  _AttributeName[intIndex])
{
return mstrRunat;
}
else if (conDataGridStyle.FontSize  ==  _AttributeName[intIndex])
{
return mstrFontSize;
}
else if (conDataGridStyle.FontName  ==  _AttributeName[intIndex])
{
return mstrFontName;
}
else if (conDataGridStyle.AllowPaging  ==  _AttributeName[intIndex])
{
return mbolAllowPaging;
}
else if (conDataGridStyle.PageSize  ==  _AttributeName[intIndex])
{
return mintPageSize;
}
else if (conDataGridStyle.AutoGenerateColumns  ==  _AttributeName[intIndex])
{
return mbolAutoGenerateColumns;
}
else if (conDataGridStyle.AllowSorting  ==  _AttributeName[intIndex])
{
return mbolAllowSorting;
}
else if (conDataGridStyle.IsRadio  ==  _AttributeName[intIndex])
{
return mbolIsRadio;
}
else if (conDataGridStyle.IsCheck  ==  _AttributeName[intIndex])
{
return mbolIsCheck;
}
else if (conDataGridStyle.IsJumpPage  ==  _AttributeName[intIndex])
{
return mbolIsJumpPage;
}
else if (conDataGridStyle.IsHaveUpdBtn  ==  _AttributeName[intIndex])
{
return mbolIsHaveUpdBtn;
}
else if (conDataGridStyle.IsHaveDelBtn  ==  _AttributeName[intIndex])
{
return mbolIsHaveDelBtn;
}
else if (conDataGridStyle.IsHaveDetailBtn  ==  _AttributeName[intIndex])
{
return mbolIsHaveDetailBtn;
}
else if (conDataGridStyle.IsInTab  ==  _AttributeName[intIndex])
{
return mbolIsInTab;
}
else if (conDataGridStyle.StyleZindex  ==  _AttributeName[intIndex])
{
return mintStyleZindex;
}
else if (conDataGridStyle.StyleLeft  ==  _AttributeName[intIndex])
{
return mintStyleLeft;
}
else if (conDataGridStyle.StylePosition  ==  _AttributeName[intIndex])
{
return mstrStylePosition;
}
else if (conDataGridStyle.Width  ==  _AttributeName[intIndex])
{
return mintWidth;
}
else if (conDataGridStyle.Height  ==  _AttributeName[intIndex])
{
return mintHeight;
}
else if (conDataGridStyle.StyleTop  ==  _AttributeName[intIndex])
{
return mintStyleTop;
}
else if (conDataGridStyle.Style  ==  _AttributeName[intIndex])
{
return mstrStyle;
}
else if (conDataGridStyle.IsDefault  ==  _AttributeName[intIndex])
{
return mbolIsDefault;
}
return null;
}
set
{
if (conDataGridStyle.DgStyleId  ==  _AttributeName[intIndex])
{
mstrDgStyleId = value.ToString();
 AddUpdatedFld(conDataGridStyle.DgStyleId);
}
else if (conDataGridStyle.DgStyleName  ==  _AttributeName[intIndex])
{
mstrDgStyleName = value.ToString();
 AddUpdatedFld(conDataGridStyle.DgStyleName);
}
else if (conDataGridStyle.Runat  ==  _AttributeName[intIndex])
{
mstrRunat = value.ToString();
 AddUpdatedFld(conDataGridStyle.Runat);
}
else if (conDataGridStyle.FontSize  ==  _AttributeName[intIndex])
{
mstrFontSize = value.ToString();
 AddUpdatedFld(conDataGridStyle.FontSize);
}
else if (conDataGridStyle.FontName  ==  _AttributeName[intIndex])
{
mstrFontName = value.ToString();
 AddUpdatedFld(conDataGridStyle.FontName);
}
else if (conDataGridStyle.AllowPaging  ==  _AttributeName[intIndex])
{
mbolAllowPaging = TransNullToBool(value.ToString());
 AddUpdatedFld(conDataGridStyle.AllowPaging);
}
else if (conDataGridStyle.PageSize  ==  _AttributeName[intIndex])
{
mintPageSize = TransNullToInt(value.ToString());
 AddUpdatedFld(conDataGridStyle.PageSize);
}
else if (conDataGridStyle.AutoGenerateColumns  ==  _AttributeName[intIndex])
{
mbolAutoGenerateColumns = TransNullToBool(value.ToString());
 AddUpdatedFld(conDataGridStyle.AutoGenerateColumns);
}
else if (conDataGridStyle.AllowSorting  ==  _AttributeName[intIndex])
{
mbolAllowSorting = TransNullToBool(value.ToString());
 AddUpdatedFld(conDataGridStyle.AllowSorting);
}
else if (conDataGridStyle.IsRadio  ==  _AttributeName[intIndex])
{
mbolIsRadio = TransNullToBool(value.ToString());
 AddUpdatedFld(conDataGridStyle.IsRadio);
}
else if (conDataGridStyle.IsCheck  ==  _AttributeName[intIndex])
{
mbolIsCheck = TransNullToBool(value.ToString());
 AddUpdatedFld(conDataGridStyle.IsCheck);
}
else if (conDataGridStyle.IsJumpPage  ==  _AttributeName[intIndex])
{
mbolIsJumpPage = TransNullToBool(value.ToString());
 AddUpdatedFld(conDataGridStyle.IsJumpPage);
}
else if (conDataGridStyle.IsHaveUpdBtn  ==  _AttributeName[intIndex])
{
mbolIsHaveUpdBtn = TransNullToBool(value.ToString());
 AddUpdatedFld(conDataGridStyle.IsHaveUpdBtn);
}
else if (conDataGridStyle.IsHaveDelBtn  ==  _AttributeName[intIndex])
{
mbolIsHaveDelBtn = TransNullToBool(value.ToString());
 AddUpdatedFld(conDataGridStyle.IsHaveDelBtn);
}
else if (conDataGridStyle.IsHaveDetailBtn  ==  _AttributeName[intIndex])
{
mbolIsHaveDetailBtn = TransNullToBool(value.ToString());
 AddUpdatedFld(conDataGridStyle.IsHaveDetailBtn);
}
else if (conDataGridStyle.IsInTab  ==  _AttributeName[intIndex])
{
mbolIsInTab = TransNullToBool(value.ToString());
 AddUpdatedFld(conDataGridStyle.IsInTab);
}
else if (conDataGridStyle.StyleZindex  ==  _AttributeName[intIndex])
{
mintStyleZindex = TransNullToInt(value.ToString());
 AddUpdatedFld(conDataGridStyle.StyleZindex);
}
else if (conDataGridStyle.StyleLeft  ==  _AttributeName[intIndex])
{
mintStyleLeft = TransNullToInt(value.ToString());
 AddUpdatedFld(conDataGridStyle.StyleLeft);
}
else if (conDataGridStyle.StylePosition  ==  _AttributeName[intIndex])
{
mstrStylePosition = value.ToString();
 AddUpdatedFld(conDataGridStyle.StylePosition);
}
else if (conDataGridStyle.Width  ==  _AttributeName[intIndex])
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(conDataGridStyle.Width);
}
else if (conDataGridStyle.Height  ==  _AttributeName[intIndex])
{
mintHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(conDataGridStyle.Height);
}
else if (conDataGridStyle.StyleTop  ==  _AttributeName[intIndex])
{
mintStyleTop = TransNullToInt(value.ToString());
 AddUpdatedFld(conDataGridStyle.StyleTop);
}
else if (conDataGridStyle.Style  ==  _AttributeName[intIndex])
{
mstrStyle = value.ToString();
 AddUpdatedFld(conDataGridStyle.Style);
}
else if (conDataGridStyle.IsDefault  ==  _AttributeName[intIndex])
{
mbolIsDefault = TransNullToBool(value.ToString());
 AddUpdatedFld(conDataGridStyle.IsDefault);
}
}
}

/// <summary>
/// DG模式ID(说明:;字段类型:varchar;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DgStyleId
{
get
{
return mstrDgStyleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDgStyleId = value;
}
else
{
 mstrDgStyleId = value;
}
//记录修改过的字段
 AddUpdatedFld(conDataGridStyle.DgStyleId);
}
}
/// <summary>
/// DG模式名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DgStyleName
{
get
{
return mstrDgStyleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDgStyleName = value;
}
else
{
 mstrDgStyleName = value;
}
//记录修改过的字段
 AddUpdatedFld(conDataGridStyle.DgStyleName);
}
}
/// <summary>
/// 运行在(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrRunat = value;
}
else
{
 mstrRunat = value;
}
//记录修改过的字段
 AddUpdatedFld(conDataGridStyle.Runat);
}
}
/// <summary>
/// 字号(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrFontSize = value;
}
else
{
 mstrFontSize = value;
}
//记录修改过的字段
 AddUpdatedFld(conDataGridStyle.FontSize);
}
}
/// <summary>
/// 字体(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrFontName = value;
}
else
{
 mstrFontName = value;
}
//记录修改过的字段
 AddUpdatedFld(conDataGridStyle.FontName);
}
}
/// <summary>
/// 允许分页(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
//记录修改过的字段
 AddUpdatedFld(conDataGridStyle.AllowPaging);
}
}
/// <summary>
/// 页大小(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? PageSize
{
get
{
return mintPageSize;
}
set
{
 mintPageSize = value;
//记录修改过的字段
 AddUpdatedFld(conDataGridStyle.PageSize);
}
}
/// <summary>
/// 自动生成列(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
//记录修改过的字段
 AddUpdatedFld(conDataGridStyle.AutoGenerateColumns);
}
}
/// <summary>
/// 允许排序(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
//记录修改过的字段
 AddUpdatedFld(conDataGridStyle.AllowSorting);
}
}
/// <summary>
/// 是否单选框(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
//记录修改过的字段
 AddUpdatedFld(conDataGridStyle.IsRadio);
}
}
/// <summary>
/// 是否复选框(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
//记录修改过的字段
 AddUpdatedFld(conDataGridStyle.IsCheck);
}
}
/// <summary>
/// 是否跳页(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
//记录修改过的字段
 AddUpdatedFld(conDataGridStyle.IsJumpPage);
}
}
/// <summary>
/// 是否有修改按钮(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsHaveUpdBtn
{
get
{
return mbolIsHaveUpdBtn;
}
set
{
 mbolIsHaveUpdBtn = value;
//记录修改过的字段
 AddUpdatedFld(conDataGridStyle.IsHaveUpdBtn);
}
}
/// <summary>
/// 是否有删除按钮(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsHaveDelBtn
{
get
{
return mbolIsHaveDelBtn;
}
set
{
 mbolIsHaveDelBtn = value;
//记录修改过的字段
 AddUpdatedFld(conDataGridStyle.IsHaveDelBtn);
}
}
/// <summary>
/// 是否有详细按钮(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsHaveDetailBtn
{
get
{
return mbolIsHaveDetailBtn;
}
set
{
 mbolIsHaveDetailBtn = value;
//记录修改过的字段
 AddUpdatedFld(conDataGridStyle.IsHaveDetailBtn);
}
}
/// <summary>
/// 是否生成DG在表中(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
//记录修改过的字段
 AddUpdatedFld(conDataGridStyle.IsInTab);
}
}
/// <summary>
/// Style_Zindex(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? StyleZindex
{
get
{
return mintStyleZindex;
}
set
{
 mintStyleZindex = value;
//记录修改过的字段
 AddUpdatedFld(conDataGridStyle.StyleZindex);
}
}
/// <summary>
/// Style_Left(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? StyleLeft
{
get
{
return mintStyleLeft;
}
set
{
 mintStyleLeft = value;
//记录修改过的字段
 AddUpdatedFld(conDataGridStyle.StyleLeft);
}
}
/// <summary>
/// Style_Position(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StylePosition
{
get
{
return mstrStylePosition;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStylePosition = value;
}
else
{
 mstrStylePosition = value;
}
//记录修改过的字段
 AddUpdatedFld(conDataGridStyle.StylePosition);
}
}
/// <summary>
/// 宽(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? Width
{
get
{
return mintWidth;
}
set
{
 mintWidth = value;
//记录修改过的字段
 AddUpdatedFld(conDataGridStyle.Width);
}
}
/// <summary>
/// 高度(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? Height
{
get
{
return mintHeight;
}
set
{
 mintHeight = value;
//记录修改过的字段
 AddUpdatedFld(conDataGridStyle.Height);
}
}
/// <summary>
/// Style_Top(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? StyleTop
{
get
{
return mintStyleTop;
}
set
{
 mintStyleTop = value;
//记录修改过的字段
 AddUpdatedFld(conDataGridStyle.StyleTop);
}
}
/// <summary>
/// 类型(说明:;字段类型:varchar;字段长度:800;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrStyle = value;
}
else
{
 mstrStyle = value;
}
//记录修改过的字段
 AddUpdatedFld(conDataGridStyle.Style);
}
}
/// <summary>
/// 是否默认(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsDefault
{
get
{
return mbolIsDefault;
}
set
{
 mbolIsDefault = value;
//记录修改过的字段
 AddUpdatedFld(conDataGridStyle.IsDefault);
}
}

/// <summary>
/// 获取关键字Id(keyId)
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetKeyId)
/// </summary>
 public override string _KeyId
 {
 get
 {
  return mstrDgStyleId;
 }
 }

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrDgStyleName;
 }
 }
}
 /// <summary>
 /// DataGrid类型(DataGridStyle)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conDataGridStyle
{
public const string _CurrTabName = "DataGridStyle"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "DgStyleId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"DgStyleId", "DgStyleName", "Runat", "FontSize", "FontName", "AllowPaging", "PageSize", "AutoGenerateColumns", "AllowSorting", "IsRadio", "IsCheck", "IsJumpPage", "IsHaveUpdBtn", "IsHaveDelBtn", "IsHaveDetailBtn", "IsInTab", "StyleZindex", "StyleLeft", "StylePosition", "Width", "Height", "StyleTop", "Style", "IsDefault"};
//以下是属性变量


 /// <summary>
 /// 常量:"DgStyleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DgStyleId = "DgStyleId";    //DG模式ID

 /// <summary>
 /// 常量:"DgStyleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DgStyleName = "DgStyleName";    //DG模式名

 /// <summary>
 /// 常量:"Runat"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Runat = "Runat";    //运行在

 /// <summary>
 /// 常量:"FontSize"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FontSize = "FontSize";    //字号

 /// <summary>
 /// 常量:"FontName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FontName = "FontName";    //字体

 /// <summary>
 /// 常量:"AllowPaging"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AllowPaging = "AllowPaging";    //允许分页

 /// <summary>
 /// 常量:"PageSize"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PageSize = "PageSize";    //页大小

 /// <summary>
 /// 常量:"AutoGenerateColumns"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AutoGenerateColumns = "AutoGenerateColumns";    //自动生成列

 /// <summary>
 /// 常量:"AllowSorting"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AllowSorting = "AllowSorting";    //允许排序

 /// <summary>
 /// 常量:"IsRadio"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsRadio = "IsRadio";    //是否单选框

 /// <summary>
 /// 常量:"IsCheck"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsCheck = "IsCheck";    //是否复选框

 /// <summary>
 /// 常量:"IsJumpPage"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsJumpPage = "IsJumpPage";    //是否跳页

 /// <summary>
 /// 常量:"IsHaveUpdBtn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsHaveUpdBtn = "IsHaveUpdBtn";    //是否有修改按钮

 /// <summary>
 /// 常量:"IsHaveDelBtn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsHaveDelBtn = "IsHaveDelBtn";    //是否有删除按钮

 /// <summary>
 /// 常量:"IsHaveDetailBtn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsHaveDetailBtn = "IsHaveDetailBtn";    //是否有详细按钮

 /// <summary>
 /// 常量:"IsInTab"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsInTab = "IsInTab";    //是否生成DG在表中

 /// <summary>
 /// 常量:"StyleZindex"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StyleZindex = "StyleZindex";    //Style_Zindex

 /// <summary>
 /// 常量:"StyleLeft"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StyleLeft = "StyleLeft";    //Style_Left

 /// <summary>
 /// 常量:"StylePosition"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StylePosition = "StylePosition";    //Style_Position

 /// <summary>
 /// 常量:"Width"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Width = "Width";    //宽

 /// <summary>
 /// 常量:"Height"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Height = "Height";    //高度

 /// <summary>
 /// 常量:"StyleTop"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StyleTop = "StyleTop";    //Style_Top

 /// <summary>
 /// 常量:"Style"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Style = "Style";    //类型

 /// <summary>
 /// 常量:"IsDefault"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDefault = "IsDefault";    //是否默认
}

}