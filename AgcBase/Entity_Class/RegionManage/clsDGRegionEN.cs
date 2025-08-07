
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDGRegionEN
 表名:DGRegion(00050112)
 * 版本:2023.05.26.1(服务器:PYF-THINKPAD)
 日期:2023/05/27 06:46:08
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcMvc(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:区域管理(RegionManage)
 框架-层名:实体层(CS)(EntityLayer)
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

namespace AGC.Entity
{
 /// <summary>
 /// 表DGRegion的关键字(RegionId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_RegionId_DGRegion
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strRegionId">表关键字</param>
public K_RegionId_DGRegion(string strRegionId)
{
if (IsValid(strRegionId)) Value = strRegionId;
else
{
Value = null;
}
}
private static bool IsValid(string strRegionId)
{
if (string.IsNullOrEmpty(strRegionId) == true) return false;
if (strRegionId.Length != 10) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_RegionId_DGRegion]类型的对象</returns>
public static implicit operator K_RegionId_DGRegion(string value)
{
return new K_RegionId_DGRegion(value);
}
}
 /// <summary>
 /// DG区域(DGRegion)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsDGRegionEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接，如果为空就使用系统默认的连接
public const string _CurrTabName_S = "DGRegion"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "RegionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string WhereFormat = ""; //条件格式串
protected const int mintAttributeCount = 29;
public static string[] AttributeName = new string[] {"RegionId", "DgStyleId", "AllowPaging", "AutoGenerateColumns", "AllowSorting", "IsRadio", "IsCheck", "IsJumpPage", "IsHaveUpdBtn", "IsHaveDelBtn", "IsHaveDetailBtn", "IsInTab", "Width", "Height", "ViewDgName", "FontSize", "PageSize", "Runat", "Style_Top", "Style_Position", "Style_Left", "Style_Zindex", "Style", "ColNum", "FontName", "PrjId", "UpdDate", "UpdUser", "Memo"};

protected string mstrRegionId;    //区域Id
protected string mstrDgStyleId;    //DG模式ID
protected bool mbolAllowPaging;    //允许分页
protected bool mbolAutoGenerateColumns;    //自动生成列
protected bool mbolAllowSorting;    //允许排序
protected bool mbolIsRadio;    //是否单选框
protected bool mbolIsCheck;    //是否复选框
protected bool mbolIsJumpPage;    //是否跳页
protected bool mbolIsHaveUpdBtn;    //是否有修改按钮
protected bool mbolIsHaveDelBtn;    //是否有删除按钮
protected bool mbolIsHaveDetailBtn;    //是否有详细按钮
protected bool mbolIsInTab;    //是否生成DG在表中
protected int? mintWidth;    //宽
protected int? mintHeight;    //高度
protected string mstrViewDgName;    //界面Dg名称
protected string mstrFontSize;    //字号
protected int? mintPageSize;    //页大小
protected string mstrRunat;    //运行在
protected int? mintStyle_Top;    //Style_Top
protected string mstrStyle_Position;    //Style_Position
protected int? mintStyle_Left;    //Style_Left
protected int? mintStyle_Zindex;    //Style_Zindex
protected string mstrStyle;    //类型
protected int mintColNum;    //列数
protected string mstrFontName;    //字体
protected string mstrPrjId;    //工程ID
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsDGRegionEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "DGRegion";
 lstKeyFldNames.Add("RegionId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strRegionId">关键字:区域Id</param>
public clsDGRegionEN(string strRegionId)
 {
strRegionId = strRegionId.Replace("'", "''");
if (strRegionId.Length > 10)
{
throw new Exception("在表:DGRegion中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strRegionId)  ==  true)
{
throw new Exception("在表:DGRegion中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strRegionId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrRegionId = strRegionId;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "DGRegion";
 lstKeyFldNames.Add("RegionId");
 }

public static int AttributeCount
{
get
{
return mintAttributeCount;
}
}
public override object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  conDGRegion.RegionId)
{
return mstrRegionId;
}
else if (strAttributeName  ==  conDGRegion.DgStyleId)
{
return mstrDgStyleId;
}
else if (strAttributeName  ==  conDGRegion.AllowPaging)
{
return mbolAllowPaging;
}
else if (strAttributeName  ==  conDGRegion.AutoGenerateColumns)
{
return mbolAutoGenerateColumns;
}
else if (strAttributeName  ==  conDGRegion.AllowSorting)
{
return mbolAllowSorting;
}
else if (strAttributeName  ==  conDGRegion.IsRadio)
{
return mbolIsRadio;
}
else if (strAttributeName  ==  conDGRegion.IsCheck)
{
return mbolIsCheck;
}
else if (strAttributeName  ==  conDGRegion.IsJumpPage)
{
return mbolIsJumpPage;
}
else if (strAttributeName  ==  conDGRegion.IsHaveUpdBtn)
{
return mbolIsHaveUpdBtn;
}
else if (strAttributeName  ==  conDGRegion.IsHaveDelBtn)
{
return mbolIsHaveDelBtn;
}
else if (strAttributeName  ==  conDGRegion.IsHaveDetailBtn)
{
return mbolIsHaveDetailBtn;
}
else if (strAttributeName  ==  conDGRegion.IsInTab)
{
return mbolIsInTab;
}
else if (strAttributeName  ==  conDGRegion.Width)
{
return mintWidth;
}
else if (strAttributeName  ==  conDGRegion.Height)
{
return mintHeight;
}
else if (strAttributeName  ==  conDGRegion.ViewDgName)
{
return mstrViewDgName;
}
else if (strAttributeName  ==  conDGRegion.FontSize)
{
return mstrFontSize;
}
else if (strAttributeName  ==  conDGRegion.PageSize)
{
return mintPageSize;
}
else if (strAttributeName  ==  conDGRegion.Runat)
{
return mstrRunat;
}
else if (strAttributeName  ==  conDGRegion.Style_Top)
{
return mintStyle_Top;
}
else if (strAttributeName  ==  conDGRegion.Style_Position)
{
return mstrStyle_Position;
}
else if (strAttributeName  ==  conDGRegion.Style_Left)
{
return mintStyle_Left;
}
else if (strAttributeName  ==  conDGRegion.Style_Zindex)
{
return mintStyle_Zindex;
}
else if (strAttributeName  ==  conDGRegion.Style)
{
return mstrStyle;
}
else if (strAttributeName  ==  conDGRegion.ColNum)
{
return mintColNum;
}
else if (strAttributeName  ==  conDGRegion.FontName)
{
return mstrFontName;
}
else if (strAttributeName  ==  conDGRegion.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conDGRegion.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conDGRegion.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conDGRegion.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conDGRegion.RegionId)
{
mstrRegionId = value.ToString();
 AddUpdatedFld(conDGRegion.RegionId);
}
else if (strAttributeName  ==  conDGRegion.DgStyleId)
{
mstrDgStyleId = value.ToString();
 AddUpdatedFld(conDGRegion.DgStyleId);
}
else if (strAttributeName  ==  conDGRegion.AllowPaging)
{
mbolAllowPaging = TransNullToBool(value.ToString());
 AddUpdatedFld(conDGRegion.AllowPaging);
}
else if (strAttributeName  ==  conDGRegion.AutoGenerateColumns)
{
mbolAutoGenerateColumns = TransNullToBool(value.ToString());
 AddUpdatedFld(conDGRegion.AutoGenerateColumns);
}
else if (strAttributeName  ==  conDGRegion.AllowSorting)
{
mbolAllowSorting = TransNullToBool(value.ToString());
 AddUpdatedFld(conDGRegion.AllowSorting);
}
else if (strAttributeName  ==  conDGRegion.IsRadio)
{
mbolIsRadio = TransNullToBool(value.ToString());
 AddUpdatedFld(conDGRegion.IsRadio);
}
else if (strAttributeName  ==  conDGRegion.IsCheck)
{
mbolIsCheck = TransNullToBool(value.ToString());
 AddUpdatedFld(conDGRegion.IsCheck);
}
else if (strAttributeName  ==  conDGRegion.IsJumpPage)
{
mbolIsJumpPage = TransNullToBool(value.ToString());
 AddUpdatedFld(conDGRegion.IsJumpPage);
}
else if (strAttributeName  ==  conDGRegion.IsHaveUpdBtn)
{
mbolIsHaveUpdBtn = TransNullToBool(value.ToString());
 AddUpdatedFld(conDGRegion.IsHaveUpdBtn);
}
else if (strAttributeName  ==  conDGRegion.IsHaveDelBtn)
{
mbolIsHaveDelBtn = TransNullToBool(value.ToString());
 AddUpdatedFld(conDGRegion.IsHaveDelBtn);
}
else if (strAttributeName  ==  conDGRegion.IsHaveDetailBtn)
{
mbolIsHaveDetailBtn = TransNullToBool(value.ToString());
 AddUpdatedFld(conDGRegion.IsHaveDetailBtn);
}
else if (strAttributeName  ==  conDGRegion.IsInTab)
{
mbolIsInTab = TransNullToBool(value.ToString());
 AddUpdatedFld(conDGRegion.IsInTab);
}
else if (strAttributeName  ==  conDGRegion.Width)
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(conDGRegion.Width);
}
else if (strAttributeName  ==  conDGRegion.Height)
{
mintHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(conDGRegion.Height);
}
else if (strAttributeName  ==  conDGRegion.ViewDgName)
{
mstrViewDgName = value.ToString();
 AddUpdatedFld(conDGRegion.ViewDgName);
}
else if (strAttributeName  ==  conDGRegion.FontSize)
{
mstrFontSize = value.ToString();
 AddUpdatedFld(conDGRegion.FontSize);
}
else if (strAttributeName  ==  conDGRegion.PageSize)
{
mintPageSize = TransNullToInt(value.ToString());
 AddUpdatedFld(conDGRegion.PageSize);
}
else if (strAttributeName  ==  conDGRegion.Runat)
{
mstrRunat = value.ToString();
 AddUpdatedFld(conDGRegion.Runat);
}
else if (strAttributeName  ==  conDGRegion.Style_Top)
{
mintStyle_Top = TransNullToInt(value.ToString());
 AddUpdatedFld(conDGRegion.Style_Top);
}
else if (strAttributeName  ==  conDGRegion.Style_Position)
{
mstrStyle_Position = value.ToString();
 AddUpdatedFld(conDGRegion.Style_Position);
}
else if (strAttributeName  ==  conDGRegion.Style_Left)
{
mintStyle_Left = TransNullToInt(value.ToString());
 AddUpdatedFld(conDGRegion.Style_Left);
}
else if (strAttributeName  ==  conDGRegion.Style_Zindex)
{
mintStyle_Zindex = TransNullToInt(value.ToString());
 AddUpdatedFld(conDGRegion.Style_Zindex);
}
else if (strAttributeName  ==  conDGRegion.Style)
{
mstrStyle = value.ToString();
 AddUpdatedFld(conDGRegion.Style);
}
else if (strAttributeName  ==  conDGRegion.ColNum)
{
mintColNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conDGRegion.ColNum);
}
else if (strAttributeName  ==  conDGRegion.FontName)
{
mstrFontName = value.ToString();
 AddUpdatedFld(conDGRegion.FontName);
}
else if (strAttributeName  ==  conDGRegion.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conDGRegion.PrjId);
}
else if (strAttributeName  ==  conDGRegion.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conDGRegion.UpdDate);
}
else if (strAttributeName  ==  conDGRegion.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conDGRegion.UpdUser);
}
else if (strAttributeName  ==  conDGRegion.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDGRegion.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conDGRegion.RegionId  ==  AttributeName[intIndex])
{
return mstrRegionId;
}
else if (conDGRegion.DgStyleId  ==  AttributeName[intIndex])
{
return mstrDgStyleId;
}
else if (conDGRegion.AllowPaging  ==  AttributeName[intIndex])
{
return mbolAllowPaging;
}
else if (conDGRegion.AutoGenerateColumns  ==  AttributeName[intIndex])
{
return mbolAutoGenerateColumns;
}
else if (conDGRegion.AllowSorting  ==  AttributeName[intIndex])
{
return mbolAllowSorting;
}
else if (conDGRegion.IsRadio  ==  AttributeName[intIndex])
{
return mbolIsRadio;
}
else if (conDGRegion.IsCheck  ==  AttributeName[intIndex])
{
return mbolIsCheck;
}
else if (conDGRegion.IsJumpPage  ==  AttributeName[intIndex])
{
return mbolIsJumpPage;
}
else if (conDGRegion.IsHaveUpdBtn  ==  AttributeName[intIndex])
{
return mbolIsHaveUpdBtn;
}
else if (conDGRegion.IsHaveDelBtn  ==  AttributeName[intIndex])
{
return mbolIsHaveDelBtn;
}
else if (conDGRegion.IsHaveDetailBtn  ==  AttributeName[intIndex])
{
return mbolIsHaveDetailBtn;
}
else if (conDGRegion.IsInTab  ==  AttributeName[intIndex])
{
return mbolIsInTab;
}
else if (conDGRegion.Width  ==  AttributeName[intIndex])
{
return mintWidth;
}
else if (conDGRegion.Height  ==  AttributeName[intIndex])
{
return mintHeight;
}
else if (conDGRegion.ViewDgName  ==  AttributeName[intIndex])
{
return mstrViewDgName;
}
else if (conDGRegion.FontSize  ==  AttributeName[intIndex])
{
return mstrFontSize;
}
else if (conDGRegion.PageSize  ==  AttributeName[intIndex])
{
return mintPageSize;
}
else if (conDGRegion.Runat  ==  AttributeName[intIndex])
{
return mstrRunat;
}
else if (conDGRegion.Style_Top  ==  AttributeName[intIndex])
{
return mintStyle_Top;
}
else if (conDGRegion.Style_Position  ==  AttributeName[intIndex])
{
return mstrStyle_Position;
}
else if (conDGRegion.Style_Left  ==  AttributeName[intIndex])
{
return mintStyle_Left;
}
else if (conDGRegion.Style_Zindex  ==  AttributeName[intIndex])
{
return mintStyle_Zindex;
}
else if (conDGRegion.Style  ==  AttributeName[intIndex])
{
return mstrStyle;
}
else if (conDGRegion.ColNum  ==  AttributeName[intIndex])
{
return mintColNum;
}
else if (conDGRegion.FontName  ==  AttributeName[intIndex])
{
return mstrFontName;
}
else if (conDGRegion.PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conDGRegion.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conDGRegion.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conDGRegion.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conDGRegion.RegionId  ==  AttributeName[intIndex])
{
mstrRegionId = value.ToString();
 AddUpdatedFld(conDGRegion.RegionId);
}
else if (conDGRegion.DgStyleId  ==  AttributeName[intIndex])
{
mstrDgStyleId = value.ToString();
 AddUpdatedFld(conDGRegion.DgStyleId);
}
else if (conDGRegion.AllowPaging  ==  AttributeName[intIndex])
{
mbolAllowPaging = TransNullToBool(value.ToString());
 AddUpdatedFld(conDGRegion.AllowPaging);
}
else if (conDGRegion.AutoGenerateColumns  ==  AttributeName[intIndex])
{
mbolAutoGenerateColumns = TransNullToBool(value.ToString());
 AddUpdatedFld(conDGRegion.AutoGenerateColumns);
}
else if (conDGRegion.AllowSorting  ==  AttributeName[intIndex])
{
mbolAllowSorting = TransNullToBool(value.ToString());
 AddUpdatedFld(conDGRegion.AllowSorting);
}
else if (conDGRegion.IsRadio  ==  AttributeName[intIndex])
{
mbolIsRadio = TransNullToBool(value.ToString());
 AddUpdatedFld(conDGRegion.IsRadio);
}
else if (conDGRegion.IsCheck  ==  AttributeName[intIndex])
{
mbolIsCheck = TransNullToBool(value.ToString());
 AddUpdatedFld(conDGRegion.IsCheck);
}
else if (conDGRegion.IsJumpPage  ==  AttributeName[intIndex])
{
mbolIsJumpPage = TransNullToBool(value.ToString());
 AddUpdatedFld(conDGRegion.IsJumpPage);
}
else if (conDGRegion.IsHaveUpdBtn  ==  AttributeName[intIndex])
{
mbolIsHaveUpdBtn = TransNullToBool(value.ToString());
 AddUpdatedFld(conDGRegion.IsHaveUpdBtn);
}
else if (conDGRegion.IsHaveDelBtn  ==  AttributeName[intIndex])
{
mbolIsHaveDelBtn = TransNullToBool(value.ToString());
 AddUpdatedFld(conDGRegion.IsHaveDelBtn);
}
else if (conDGRegion.IsHaveDetailBtn  ==  AttributeName[intIndex])
{
mbolIsHaveDetailBtn = TransNullToBool(value.ToString());
 AddUpdatedFld(conDGRegion.IsHaveDetailBtn);
}
else if (conDGRegion.IsInTab  ==  AttributeName[intIndex])
{
mbolIsInTab = TransNullToBool(value.ToString());
 AddUpdatedFld(conDGRegion.IsInTab);
}
else if (conDGRegion.Width  ==  AttributeName[intIndex])
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(conDGRegion.Width);
}
else if (conDGRegion.Height  ==  AttributeName[intIndex])
{
mintHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(conDGRegion.Height);
}
else if (conDGRegion.ViewDgName  ==  AttributeName[intIndex])
{
mstrViewDgName = value.ToString();
 AddUpdatedFld(conDGRegion.ViewDgName);
}
else if (conDGRegion.FontSize  ==  AttributeName[intIndex])
{
mstrFontSize = value.ToString();
 AddUpdatedFld(conDGRegion.FontSize);
}
else if (conDGRegion.PageSize  ==  AttributeName[intIndex])
{
mintPageSize = TransNullToInt(value.ToString());
 AddUpdatedFld(conDGRegion.PageSize);
}
else if (conDGRegion.Runat  ==  AttributeName[intIndex])
{
mstrRunat = value.ToString();
 AddUpdatedFld(conDGRegion.Runat);
}
else if (conDGRegion.Style_Top  ==  AttributeName[intIndex])
{
mintStyle_Top = TransNullToInt(value.ToString());
 AddUpdatedFld(conDGRegion.Style_Top);
}
else if (conDGRegion.Style_Position  ==  AttributeName[intIndex])
{
mstrStyle_Position = value.ToString();
 AddUpdatedFld(conDGRegion.Style_Position);
}
else if (conDGRegion.Style_Left  ==  AttributeName[intIndex])
{
mintStyle_Left = TransNullToInt(value.ToString());
 AddUpdatedFld(conDGRegion.Style_Left);
}
else if (conDGRegion.Style_Zindex  ==  AttributeName[intIndex])
{
mintStyle_Zindex = TransNullToInt(value.ToString());
 AddUpdatedFld(conDGRegion.Style_Zindex);
}
else if (conDGRegion.Style  ==  AttributeName[intIndex])
{
mstrStyle = value.ToString();
 AddUpdatedFld(conDGRegion.Style);
}
else if (conDGRegion.ColNum  ==  AttributeName[intIndex])
{
mintColNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conDGRegion.ColNum);
}
else if (conDGRegion.FontName  ==  AttributeName[intIndex])
{
mstrFontName = value.ToString();
 AddUpdatedFld(conDGRegion.FontName);
}
else if (conDGRegion.PrjId  ==  AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conDGRegion.PrjId);
}
else if (conDGRegion.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conDGRegion.UpdDate);
}
else if (conDGRegion.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conDGRegion.UpdUser);
}
else if (conDGRegion.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDGRegion.Memo);
}
}
}

/// <summary>
/// 区域Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RegionId
{
get
{
return mstrRegionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRegionId = value;
}
else
{
 mstrRegionId = value;
}
//记录修改过的字段
 AddUpdatedFld(conDGRegion.RegionId);
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
 AddUpdatedFld(conDGRegion.DgStyleId);
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
 AddUpdatedFld(conDGRegion.AllowPaging);
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
 AddUpdatedFld(conDGRegion.AutoGenerateColumns);
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
 AddUpdatedFld(conDGRegion.AllowSorting);
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
 AddUpdatedFld(conDGRegion.IsRadio);
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
 AddUpdatedFld(conDGRegion.IsCheck);
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
 AddUpdatedFld(conDGRegion.IsJumpPage);
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
 AddUpdatedFld(conDGRegion.IsHaveUpdBtn);
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
 AddUpdatedFld(conDGRegion.IsHaveDelBtn);
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
 AddUpdatedFld(conDGRegion.IsHaveDetailBtn);
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
 AddUpdatedFld(conDGRegion.IsInTab);
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
 AddUpdatedFld(conDGRegion.Width);
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
 AddUpdatedFld(conDGRegion.Height);
}
}
/// <summary>
/// 界面Dg名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewDgName
{
get
{
return mstrViewDgName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewDgName = value;
}
else
{
 mstrViewDgName = value;
}
//记录修改过的字段
 AddUpdatedFld(conDGRegion.ViewDgName);
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
 AddUpdatedFld(conDGRegion.FontSize);
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
 AddUpdatedFld(conDGRegion.PageSize);
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
 AddUpdatedFld(conDGRegion.Runat);
}
}
/// <summary>
/// Style_Top(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? Style_Top
{
get
{
return mintStyle_Top;
}
set
{
 mintStyle_Top = value;
//记录修改过的字段
 AddUpdatedFld(conDGRegion.Style_Top);
}
}
/// <summary>
/// Style_Position(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Style_Position
{
get
{
return mstrStyle_Position;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStyle_Position = value;
}
else
{
 mstrStyle_Position = value;
}
//记录修改过的字段
 AddUpdatedFld(conDGRegion.Style_Position);
}
}
/// <summary>
/// Style_Left(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? Style_Left
{
get
{
return mintStyle_Left;
}
set
{
 mintStyle_Left = value;
//记录修改过的字段
 AddUpdatedFld(conDGRegion.Style_Left);
}
}
/// <summary>
/// Style_Zindex(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? Style_Zindex
{
get
{
return mintStyle_Zindex;
}
set
{
 mintStyle_Zindex = value;
//记录修改过的字段
 AddUpdatedFld(conDGRegion.Style_Zindex);
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
 AddUpdatedFld(conDGRegion.Style);
}
}
/// <summary>
/// 列数(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
//记录修改过的字段
 AddUpdatedFld(conDGRegion.ColNum);
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
 AddUpdatedFld(conDGRegion.FontName);
}
}
/// <summary>
/// 工程ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjId
{
get
{
return mstrPrjId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjId = value;
}
else
{
 mstrPrjId = value;
}
//记录修改过的字段
 AddUpdatedFld(conDGRegion.PrjId);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdDate
{
get
{
return mstrUpdDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdDate = value;
}
else
{
 mstrUpdDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conDGRegion.UpdDate);
}
}
/// <summary>
/// 修改者(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUser
{
get
{
return mstrUpdUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUser = value;
}
else
{
 mstrUpdUser = value;
}
//记录修改过的字段
 AddUpdatedFld(conDGRegion.UpdUser);
}
}
/// <summary>
/// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Memo
{
get
{
return mstrMemo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMemo = value;
}
else
{
 mstrMemo = value;
}
//记录修改过的字段
 AddUpdatedFld(conDGRegion.Memo);
}
}

/// <summary>
/// 获取关键字Id(keyId)
 /// (AutoGCLib.clsGeneCodeBase:GenGetKeyId)
/// </summary>
 public override string _KeyId
 {
 get
 {
  return mstrRegionId;
 }
 }
}
 /// <summary>
 /// DG区域(DGRegion)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conDGRegion
{
public const string _CurrTabName_S = "DGRegion"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "RegionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"RegionId", "DgStyleId", "AllowPaging", "AutoGenerateColumns", "AllowSorting", "IsRadio", "IsCheck", "IsJumpPage", "IsHaveUpdBtn", "IsHaveDelBtn", "IsHaveDetailBtn", "IsInTab", "Width", "Height", "ViewDgName", "FontSize", "PageSize", "Runat", "Style_Top", "Style_Position", "Style_Left", "Style_Zindex", "Style", "ColNum", "FontName", "PrjId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"RegionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RegionId = "RegionId";    //区域Id

 /// <summary>
 /// 常量:"DgStyleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DgStyleId = "DgStyleId";    //DG模式ID

 /// <summary>
 /// 常量:"AllowPaging"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AllowPaging = "AllowPaging";    //允许分页

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
 /// 常量:"ViewDgName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewDgName = "ViewDgName";    //界面Dg名称

 /// <summary>
 /// 常量:"FontSize"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FontSize = "FontSize";    //字号

 /// <summary>
 /// 常量:"PageSize"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PageSize = "PageSize";    //页大小

 /// <summary>
 /// 常量:"Runat"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Runat = "Runat";    //运行在

 /// <summary>
 /// 常量:"Style_Top"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Style_Top = "Style_Top";    //Style_Top

 /// <summary>
 /// 常量:"Style_Position"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Style_Position = "Style_Position";    //Style_Position

 /// <summary>
 /// 常量:"Style_Left"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Style_Left = "Style_Left";    //Style_Left

 /// <summary>
 /// 常量:"Style_Zindex"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Style_Zindex = "Style_Zindex";    //Style_Zindex

 /// <summary>
 /// 常量:"Style"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Style = "Style";    //类型

 /// <summary>
 /// 常量:"ColNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ColNum = "ColNum";    //列数

 /// <summary>
 /// 常量:"FontName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FontName = "FontName";    //字体

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程ID

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改者

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}