
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewDgInfoEN
 表名:ViewDgInfo(00050012)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:32:51
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:区域管理(RegionManage)
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
 /// 表ViewDgInfo的关键字(ViewDgID)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ViewDgID_ViewDgInfo
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strViewDgID">表关键字</param>
public K_ViewDgID_ViewDgInfo(string strViewDgID)
{
if (IsValid(strViewDgID)) Value = strViewDgID;
else
{
Value = null;
}
}
private static bool IsValid(string strViewDgID)
{
if (string.IsNullOrEmpty(strViewDgID) == true) return false;
if (strViewDgID.Length > 10) return false;
if (strViewDgID.IndexOf(' ') >= 0) return false;
if (strViewDgID.IndexOf(')') >= 0) return false;
if (strViewDgID.IndexOf('(') >= 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ViewDgID_ViewDgInfo]类型的对象</returns>
public static implicit operator K_ViewDgID_ViewDgInfo(string value)
{
return new K_ViewDgID_ViewDgInfo(value);
}
}
 /// <summary>
 /// 视图Dg(ViewDgInfo)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsViewDgInfoEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ViewDgInfo"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ViewDgID"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 27;
public static string[] _AttributeName = new string[] {"ViewDgID", "ViewDgName", "ViewId", "SqlDsId", "DgStyleId", "Style", "Runat", "FontSize", "FontName", "Width", "Height", "AllowPaging", "PageSize", "AutoGenerateColumns", "AllowSorting", "IsRadio", "IsCheck", "IsHaveUpdBtn", "IsHaveDelBtn", "IsHaveDetailBtn", "IsJumpPage", "IsInTab", "StyleZindex", "StyleLeft", "StylePosition", "StyleTop", "SqlDsTypeId"};

protected string mstrViewDgID;    //界面DgId
protected string mstrViewDgName;    //界面Dg名称
protected string mstrViewId;    //界面Id
protected string mstrSqlDsId;    //数据源表/视图Id
protected string mstrDgStyleId;    //DG模式ID
protected string mstrStyle;    //类型
protected string mstrRunat;    //运行在
protected string mstrFontSize;    //字号
protected string mstrFontName;    //字体
protected int? mintWidth;    //宽
protected int? mintHeight;    //高度
protected bool mbolAllowPaging;    //允许分页
protected int? mintPageSize;    //页大小
protected bool mbolAutoGenerateColumns;    //自动生成列
protected bool mbolAllowSorting;    //允许排序
protected bool mbolIsRadio;    //是否单选框
protected bool mbolIsCheck;    //是否复选框
protected bool mbolIsHaveUpdBtn;    //是否有修改按钮
protected bool mbolIsHaveDelBtn;    //是否有删除按钮
protected bool mbolIsHaveDetailBtn;    //是否有详细按钮
protected bool mbolIsJumpPage;    //是否跳页
protected bool mbolIsInTab;    //是否生成DG在表中
protected int? mintStyleZindex;    //Style_Zindex
protected int? mintStyleLeft;    //Style_Left
protected string mstrStylePosition;    //Style_Position
protected int? mintStyleTop;    //Style_Top
protected string mstrSqlDsTypeId;    //数据源类型Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsViewDgInfoEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ViewDgID");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strViewDgID">关键字:界面DgId</param>
public clsViewDgInfoEN(string strViewDgID)
 {
strViewDgID = strViewDgID.Replace("'", "''");
if (strViewDgID.Length > 10)
{
throw new Exception("在表:ViewDgInfo中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strViewDgID)  ==  true)
{
throw new Exception("在表:ViewDgInfo中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strViewDgID);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrViewDgID = strViewDgID;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ViewDgID");
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
if (strAttributeName  ==  conViewDgInfo.ViewDgID)
{
return mstrViewDgID;
}
else if (strAttributeName  ==  conViewDgInfo.ViewDgName)
{
return mstrViewDgName;
}
else if (strAttributeName  ==  conViewDgInfo.ViewId)
{
return mstrViewId;
}
else if (strAttributeName  ==  conViewDgInfo.SqlDsId)
{
return mstrSqlDsId;
}
else if (strAttributeName  ==  conViewDgInfo.DgStyleId)
{
return mstrDgStyleId;
}
else if (strAttributeName  ==  conViewDgInfo.Style)
{
return mstrStyle;
}
else if (strAttributeName  ==  conViewDgInfo.Runat)
{
return mstrRunat;
}
else if (strAttributeName  ==  conViewDgInfo.FontSize)
{
return mstrFontSize;
}
else if (strAttributeName  ==  conViewDgInfo.FontName)
{
return mstrFontName;
}
else if (strAttributeName  ==  conViewDgInfo.Width)
{
return mintWidth;
}
else if (strAttributeName  ==  conViewDgInfo.Height)
{
return mintHeight;
}
else if (strAttributeName  ==  conViewDgInfo.AllowPaging)
{
return mbolAllowPaging;
}
else if (strAttributeName  ==  conViewDgInfo.PageSize)
{
return mintPageSize;
}
else if (strAttributeName  ==  conViewDgInfo.AutoGenerateColumns)
{
return mbolAutoGenerateColumns;
}
else if (strAttributeName  ==  conViewDgInfo.AllowSorting)
{
return mbolAllowSorting;
}
else if (strAttributeName  ==  conViewDgInfo.IsRadio)
{
return mbolIsRadio;
}
else if (strAttributeName  ==  conViewDgInfo.IsCheck)
{
return mbolIsCheck;
}
else if (strAttributeName  ==  conViewDgInfo.IsHaveUpdBtn)
{
return mbolIsHaveUpdBtn;
}
else if (strAttributeName  ==  conViewDgInfo.IsHaveDelBtn)
{
return mbolIsHaveDelBtn;
}
else if (strAttributeName  ==  conViewDgInfo.IsHaveDetailBtn)
{
return mbolIsHaveDetailBtn;
}
else if (strAttributeName  ==  conViewDgInfo.IsJumpPage)
{
return mbolIsJumpPage;
}
else if (strAttributeName  ==  conViewDgInfo.IsInTab)
{
return mbolIsInTab;
}
else if (strAttributeName  ==  conViewDgInfo.StyleZindex)
{
return mintStyleZindex;
}
else if (strAttributeName  ==  conViewDgInfo.StyleLeft)
{
return mintStyleLeft;
}
else if (strAttributeName  ==  conViewDgInfo.StylePosition)
{
return mstrStylePosition;
}
else if (strAttributeName  ==  conViewDgInfo.StyleTop)
{
return mintStyleTop;
}
else if (strAttributeName  ==  conViewDgInfo.SqlDsTypeId)
{
return mstrSqlDsTypeId;
}
return null;
}
set
{
if (strAttributeName  ==  conViewDgInfo.ViewDgID)
{
mstrViewDgID = value.ToString();
 AddUpdatedFld(conViewDgInfo.ViewDgID);
}
else if (strAttributeName  ==  conViewDgInfo.ViewDgName)
{
mstrViewDgName = value.ToString();
 AddUpdatedFld(conViewDgInfo.ViewDgName);
}
else if (strAttributeName  ==  conViewDgInfo.ViewId)
{
mstrViewId = value.ToString();
 AddUpdatedFld(conViewDgInfo.ViewId);
}
else if (strAttributeName  ==  conViewDgInfo.SqlDsId)
{
mstrSqlDsId = value.ToString();
 AddUpdatedFld(conViewDgInfo.SqlDsId);
}
else if (strAttributeName  ==  conViewDgInfo.DgStyleId)
{
mstrDgStyleId = value.ToString();
 AddUpdatedFld(conViewDgInfo.DgStyleId);
}
else if (strAttributeName  ==  conViewDgInfo.Style)
{
mstrStyle = value.ToString();
 AddUpdatedFld(conViewDgInfo.Style);
}
else if (strAttributeName  ==  conViewDgInfo.Runat)
{
mstrRunat = value.ToString();
 AddUpdatedFld(conViewDgInfo.Runat);
}
else if (strAttributeName  ==  conViewDgInfo.FontSize)
{
mstrFontSize = value.ToString();
 AddUpdatedFld(conViewDgInfo.FontSize);
}
else if (strAttributeName  ==  conViewDgInfo.FontName)
{
mstrFontName = value.ToString();
 AddUpdatedFld(conViewDgInfo.FontName);
}
else if (strAttributeName  ==  conViewDgInfo.Width)
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewDgInfo.Width);
}
else if (strAttributeName  ==  conViewDgInfo.Height)
{
mintHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewDgInfo.Height);
}
else if (strAttributeName  ==  conViewDgInfo.AllowPaging)
{
mbolAllowPaging = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewDgInfo.AllowPaging);
}
else if (strAttributeName  ==  conViewDgInfo.PageSize)
{
mintPageSize = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewDgInfo.PageSize);
}
else if (strAttributeName  ==  conViewDgInfo.AutoGenerateColumns)
{
mbolAutoGenerateColumns = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewDgInfo.AutoGenerateColumns);
}
else if (strAttributeName  ==  conViewDgInfo.AllowSorting)
{
mbolAllowSorting = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewDgInfo.AllowSorting);
}
else if (strAttributeName  ==  conViewDgInfo.IsRadio)
{
mbolIsRadio = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewDgInfo.IsRadio);
}
else if (strAttributeName  ==  conViewDgInfo.IsCheck)
{
mbolIsCheck = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewDgInfo.IsCheck);
}
else if (strAttributeName  ==  conViewDgInfo.IsHaveUpdBtn)
{
mbolIsHaveUpdBtn = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewDgInfo.IsHaveUpdBtn);
}
else if (strAttributeName  ==  conViewDgInfo.IsHaveDelBtn)
{
mbolIsHaveDelBtn = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewDgInfo.IsHaveDelBtn);
}
else if (strAttributeName  ==  conViewDgInfo.IsHaveDetailBtn)
{
mbolIsHaveDetailBtn = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewDgInfo.IsHaveDetailBtn);
}
else if (strAttributeName  ==  conViewDgInfo.IsJumpPage)
{
mbolIsJumpPage = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewDgInfo.IsJumpPage);
}
else if (strAttributeName  ==  conViewDgInfo.IsInTab)
{
mbolIsInTab = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewDgInfo.IsInTab);
}
else if (strAttributeName  ==  conViewDgInfo.StyleZindex)
{
mintStyleZindex = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewDgInfo.StyleZindex);
}
else if (strAttributeName  ==  conViewDgInfo.StyleLeft)
{
mintStyleLeft = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewDgInfo.StyleLeft);
}
else if (strAttributeName  ==  conViewDgInfo.StylePosition)
{
mstrStylePosition = value.ToString();
 AddUpdatedFld(conViewDgInfo.StylePosition);
}
else if (strAttributeName  ==  conViewDgInfo.StyleTop)
{
mintStyleTop = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewDgInfo.StyleTop);
}
else if (strAttributeName  ==  conViewDgInfo.SqlDsTypeId)
{
mstrSqlDsTypeId = value.ToString();
 AddUpdatedFld(conViewDgInfo.SqlDsTypeId);
}
}
}
public object this[int intIndex]
{
get
{
if (conViewDgInfo.ViewDgID  ==  _AttributeName[intIndex])
{
return mstrViewDgID;
}
else if (conViewDgInfo.ViewDgName  ==  _AttributeName[intIndex])
{
return mstrViewDgName;
}
else if (conViewDgInfo.ViewId  ==  _AttributeName[intIndex])
{
return mstrViewId;
}
else if (conViewDgInfo.SqlDsId  ==  _AttributeName[intIndex])
{
return mstrSqlDsId;
}
else if (conViewDgInfo.DgStyleId  ==  _AttributeName[intIndex])
{
return mstrDgStyleId;
}
else if (conViewDgInfo.Style  ==  _AttributeName[intIndex])
{
return mstrStyle;
}
else if (conViewDgInfo.Runat  ==  _AttributeName[intIndex])
{
return mstrRunat;
}
else if (conViewDgInfo.FontSize  ==  _AttributeName[intIndex])
{
return mstrFontSize;
}
else if (conViewDgInfo.FontName  ==  _AttributeName[intIndex])
{
return mstrFontName;
}
else if (conViewDgInfo.Width  ==  _AttributeName[intIndex])
{
return mintWidth;
}
else if (conViewDgInfo.Height  ==  _AttributeName[intIndex])
{
return mintHeight;
}
else if (conViewDgInfo.AllowPaging  ==  _AttributeName[intIndex])
{
return mbolAllowPaging;
}
else if (conViewDgInfo.PageSize  ==  _AttributeName[intIndex])
{
return mintPageSize;
}
else if (conViewDgInfo.AutoGenerateColumns  ==  _AttributeName[intIndex])
{
return mbolAutoGenerateColumns;
}
else if (conViewDgInfo.AllowSorting  ==  _AttributeName[intIndex])
{
return mbolAllowSorting;
}
else if (conViewDgInfo.IsRadio  ==  _AttributeName[intIndex])
{
return mbolIsRadio;
}
else if (conViewDgInfo.IsCheck  ==  _AttributeName[intIndex])
{
return mbolIsCheck;
}
else if (conViewDgInfo.IsHaveUpdBtn  ==  _AttributeName[intIndex])
{
return mbolIsHaveUpdBtn;
}
else if (conViewDgInfo.IsHaveDelBtn  ==  _AttributeName[intIndex])
{
return mbolIsHaveDelBtn;
}
else if (conViewDgInfo.IsHaveDetailBtn  ==  _AttributeName[intIndex])
{
return mbolIsHaveDetailBtn;
}
else if (conViewDgInfo.IsJumpPage  ==  _AttributeName[intIndex])
{
return mbolIsJumpPage;
}
else if (conViewDgInfo.IsInTab  ==  _AttributeName[intIndex])
{
return mbolIsInTab;
}
else if (conViewDgInfo.StyleZindex  ==  _AttributeName[intIndex])
{
return mintStyleZindex;
}
else if (conViewDgInfo.StyleLeft  ==  _AttributeName[intIndex])
{
return mintStyleLeft;
}
else if (conViewDgInfo.StylePosition  ==  _AttributeName[intIndex])
{
return mstrStylePosition;
}
else if (conViewDgInfo.StyleTop  ==  _AttributeName[intIndex])
{
return mintStyleTop;
}
else if (conViewDgInfo.SqlDsTypeId  ==  _AttributeName[intIndex])
{
return mstrSqlDsTypeId;
}
return null;
}
set
{
if (conViewDgInfo.ViewDgID  ==  _AttributeName[intIndex])
{
mstrViewDgID = value.ToString();
 AddUpdatedFld(conViewDgInfo.ViewDgID);
}
else if (conViewDgInfo.ViewDgName  ==  _AttributeName[intIndex])
{
mstrViewDgName = value.ToString();
 AddUpdatedFld(conViewDgInfo.ViewDgName);
}
else if (conViewDgInfo.ViewId  ==  _AttributeName[intIndex])
{
mstrViewId = value.ToString();
 AddUpdatedFld(conViewDgInfo.ViewId);
}
else if (conViewDgInfo.SqlDsId  ==  _AttributeName[intIndex])
{
mstrSqlDsId = value.ToString();
 AddUpdatedFld(conViewDgInfo.SqlDsId);
}
else if (conViewDgInfo.DgStyleId  ==  _AttributeName[intIndex])
{
mstrDgStyleId = value.ToString();
 AddUpdatedFld(conViewDgInfo.DgStyleId);
}
else if (conViewDgInfo.Style  ==  _AttributeName[intIndex])
{
mstrStyle = value.ToString();
 AddUpdatedFld(conViewDgInfo.Style);
}
else if (conViewDgInfo.Runat  ==  _AttributeName[intIndex])
{
mstrRunat = value.ToString();
 AddUpdatedFld(conViewDgInfo.Runat);
}
else if (conViewDgInfo.FontSize  ==  _AttributeName[intIndex])
{
mstrFontSize = value.ToString();
 AddUpdatedFld(conViewDgInfo.FontSize);
}
else if (conViewDgInfo.FontName  ==  _AttributeName[intIndex])
{
mstrFontName = value.ToString();
 AddUpdatedFld(conViewDgInfo.FontName);
}
else if (conViewDgInfo.Width  ==  _AttributeName[intIndex])
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewDgInfo.Width);
}
else if (conViewDgInfo.Height  ==  _AttributeName[intIndex])
{
mintHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewDgInfo.Height);
}
else if (conViewDgInfo.AllowPaging  ==  _AttributeName[intIndex])
{
mbolAllowPaging = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewDgInfo.AllowPaging);
}
else if (conViewDgInfo.PageSize  ==  _AttributeName[intIndex])
{
mintPageSize = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewDgInfo.PageSize);
}
else if (conViewDgInfo.AutoGenerateColumns  ==  _AttributeName[intIndex])
{
mbolAutoGenerateColumns = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewDgInfo.AutoGenerateColumns);
}
else if (conViewDgInfo.AllowSorting  ==  _AttributeName[intIndex])
{
mbolAllowSorting = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewDgInfo.AllowSorting);
}
else if (conViewDgInfo.IsRadio  ==  _AttributeName[intIndex])
{
mbolIsRadio = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewDgInfo.IsRadio);
}
else if (conViewDgInfo.IsCheck  ==  _AttributeName[intIndex])
{
mbolIsCheck = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewDgInfo.IsCheck);
}
else if (conViewDgInfo.IsHaveUpdBtn  ==  _AttributeName[intIndex])
{
mbolIsHaveUpdBtn = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewDgInfo.IsHaveUpdBtn);
}
else if (conViewDgInfo.IsHaveDelBtn  ==  _AttributeName[intIndex])
{
mbolIsHaveDelBtn = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewDgInfo.IsHaveDelBtn);
}
else if (conViewDgInfo.IsHaveDetailBtn  ==  _AttributeName[intIndex])
{
mbolIsHaveDetailBtn = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewDgInfo.IsHaveDetailBtn);
}
else if (conViewDgInfo.IsJumpPage  ==  _AttributeName[intIndex])
{
mbolIsJumpPage = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewDgInfo.IsJumpPage);
}
else if (conViewDgInfo.IsInTab  ==  _AttributeName[intIndex])
{
mbolIsInTab = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewDgInfo.IsInTab);
}
else if (conViewDgInfo.StyleZindex  ==  _AttributeName[intIndex])
{
mintStyleZindex = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewDgInfo.StyleZindex);
}
else if (conViewDgInfo.StyleLeft  ==  _AttributeName[intIndex])
{
mintStyleLeft = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewDgInfo.StyleLeft);
}
else if (conViewDgInfo.StylePosition  ==  _AttributeName[intIndex])
{
mstrStylePosition = value.ToString();
 AddUpdatedFld(conViewDgInfo.StylePosition);
}
else if (conViewDgInfo.StyleTop  ==  _AttributeName[intIndex])
{
mintStyleTop = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewDgInfo.StyleTop);
}
else if (conViewDgInfo.SqlDsTypeId  ==  _AttributeName[intIndex])
{
mstrSqlDsTypeId = value.ToString();
 AddUpdatedFld(conViewDgInfo.SqlDsTypeId);
}
}
}

/// <summary>
/// 界面DgId(说明:;字段类型:varchar;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewDgID
{
get
{
return mstrViewDgID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewDgID = value;
}
else
{
 mstrViewDgID = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewDgInfo.ViewDgID);
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
 AddUpdatedFld(conViewDgInfo.ViewDgName);
}
}
/// <summary>
/// 界面Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewId
{
get
{
return mstrViewId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewId = value;
}
else
{
 mstrViewId = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewDgInfo.ViewId);
}
}
/// <summary>
/// 数据源表/视图Id(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SqlDsId
{
get
{
return mstrSqlDsId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSqlDsId = value;
}
else
{
 mstrSqlDsId = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewDgInfo.SqlDsId);
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
 AddUpdatedFld(conViewDgInfo.DgStyleId);
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
 AddUpdatedFld(conViewDgInfo.Style);
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
 AddUpdatedFld(conViewDgInfo.Runat);
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
 AddUpdatedFld(conViewDgInfo.FontSize);
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
 AddUpdatedFld(conViewDgInfo.FontName);
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
 AddUpdatedFld(conViewDgInfo.Width);
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
 AddUpdatedFld(conViewDgInfo.Height);
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
 AddUpdatedFld(conViewDgInfo.AllowPaging);
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
 AddUpdatedFld(conViewDgInfo.PageSize);
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
 AddUpdatedFld(conViewDgInfo.AutoGenerateColumns);
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
 AddUpdatedFld(conViewDgInfo.AllowSorting);
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
 AddUpdatedFld(conViewDgInfo.IsRadio);
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
 AddUpdatedFld(conViewDgInfo.IsCheck);
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
 AddUpdatedFld(conViewDgInfo.IsHaveUpdBtn);
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
 AddUpdatedFld(conViewDgInfo.IsHaveDelBtn);
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
 AddUpdatedFld(conViewDgInfo.IsHaveDetailBtn);
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
 AddUpdatedFld(conViewDgInfo.IsJumpPage);
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
 AddUpdatedFld(conViewDgInfo.IsInTab);
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
 AddUpdatedFld(conViewDgInfo.StyleZindex);
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
 AddUpdatedFld(conViewDgInfo.StyleLeft);
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
 AddUpdatedFld(conViewDgInfo.StylePosition);
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
 AddUpdatedFld(conViewDgInfo.StyleTop);
}
}
/// <summary>
/// 数据源类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SqlDsTypeId
{
get
{
return mstrSqlDsTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSqlDsTypeId = value;
}
else
{
 mstrSqlDsTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewDgInfo.SqlDsTypeId);
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
  return mstrViewDgID;
 }
 }
}
 /// <summary>
 /// 视图Dg(ViewDgInfo)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conViewDgInfo
{
public const string _CurrTabName = "ViewDgInfo"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ViewDgID"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"ViewDgID", "ViewDgName", "ViewId", "SqlDsId", "DgStyleId", "Style", "Runat", "FontSize", "FontName", "Width", "Height", "AllowPaging", "PageSize", "AutoGenerateColumns", "AllowSorting", "IsRadio", "IsCheck", "IsHaveUpdBtn", "IsHaveDelBtn", "IsHaveDetailBtn", "IsJumpPage", "IsInTab", "StyleZindex", "StyleLeft", "StylePosition", "StyleTop", "SqlDsTypeId"};
//以下是属性变量


 /// <summary>
 /// 常量:"ViewDgID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewDgID = "ViewDgID";    //界面DgId

 /// <summary>
 /// 常量:"ViewDgName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewDgName = "ViewDgName";    //界面Dg名称

 /// <summary>
 /// 常量:"ViewId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewId = "ViewId";    //界面Id

 /// <summary>
 /// 常量:"SqlDsId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SqlDsId = "SqlDsId";    //数据源表/视图Id

 /// <summary>
 /// 常量:"DgStyleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DgStyleId = "DgStyleId";    //DG模式ID

 /// <summary>
 /// 常量:"Style"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Style = "Style";    //类型

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
 /// 常量:"IsJumpPage"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsJumpPage = "IsJumpPage";    //是否跳页

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
 /// 常量:"StyleTop"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StyleTop = "StyleTop";    //Style_Top

 /// <summary>
 /// 常量:"SqlDsTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SqlDsTypeId = "SqlDsTypeId";    //数据源类型Id
}

}