
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDropDownLstStyleEN
 表名:DropDownLstStyle(00050060)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:34:51
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
 /// 表DropDownLstStyle的关键字(DropDownLstStyleId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_DropDownLstStyleId_DropDownLstStyle
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strDropDownLstStyleId">表关键字</param>
public K_DropDownLstStyleId_DropDownLstStyle(string strDropDownLstStyleId)
{
if (IsValid(strDropDownLstStyleId)) Value = strDropDownLstStyleId;
else
{
Value = null;
}
}
private static bool IsValid(string strDropDownLstStyleId)
{
if (string.IsNullOrEmpty(strDropDownLstStyleId) == true) return false;
if (strDropDownLstStyleId.Length > 4) return false;
if (strDropDownLstStyleId.IndexOf(' ') >= 0) return false;
if (strDropDownLstStyleId.IndexOf(')') >= 0) return false;
if (strDropDownLstStyleId.IndexOf('(') >= 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_DropDownLstStyleId_DropDownLstStyle]类型的对象</returns>
public static implicit operator K_DropDownLstStyleId_DropDownLstStyle(string value)
{
return new K_DropDownLstStyleId_DropDownLstStyle(value);
}
}
 /// <summary>
 /// 下拉框样式(DropDownLstStyle)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsDropDownLstStyleEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "DropDownLstStyle"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "DropDownLstStyleId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 22;
public static string[] _AttributeName = new string[] {"DropDownLstStyleId", "DropDownLstStyleName", "Style", "Runat", "FontSize", "FontName", "Width", "Height", "TextMode", "ReadOnly", "BackColor", "ForeColor", "DataTextField", "DataValueField", "DataTextFormatString", "AccessKey", "AutoPostBack", "Visible", "StyleZindex", "StyleLeft", "StylePosition", "StyleTop"};

protected string mstrDropDownLstStyleId;    //DropDownLstStyleId
protected string mstrDropDownLstStyleName;    //DropDownLstStyleName
protected string mstrStyle;    //类型
protected string mstrRunat;    //运行在
protected string mstrFontSize;    //字号
protected string mstrFontName;    //字体
protected int? mintWidth;    //宽
protected int? mintHeight;    //高度
protected string mstrTextMode;    //TextMode
protected bool mbolReadOnly;    //ReadOnly
protected string mstrBackColor;    //背景颜色
protected string mstrForeColor;    //前景颜色
protected string mstrDataTextField;    //DataTextField
protected string mstrDataValueField;    //DataValueField
protected string mstrDataTextFormatString;    //DataTextFormatString
protected string mstrAccessKey;    //AccessKey
protected bool mbolAutoPostBack;    //AutoPostBack
protected bool mbolVisible;    //Visible
protected int? mintStyleZindex;    //Style_Zindex
protected int? mintStyleLeft;    //Style_Left
protected string mstrStylePosition;    //Style_Position
protected int? mintStyleTop;    //Style_Top

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsDropDownLstStyleEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("DropDownLstStyleId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strDropDownLstStyleId">关键字:DropDownLstStyleId</param>
public clsDropDownLstStyleEN(string strDropDownLstStyleId)
 {
strDropDownLstStyleId = strDropDownLstStyleId.Replace("'", "''");
if (strDropDownLstStyleId.Length > 4)
{
throw new Exception("在表:DropDownLstStyle中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strDropDownLstStyleId)  ==  true)
{
throw new Exception("在表:DropDownLstStyle中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strDropDownLstStyleId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrDropDownLstStyleId = strDropDownLstStyleId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("DropDownLstStyleId");
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
if (strAttributeName  ==  conDropDownLstStyle.DropDownLstStyleId)
{
return mstrDropDownLstStyleId;
}
else if (strAttributeName  ==  conDropDownLstStyle.DropDownLstStyleName)
{
return mstrDropDownLstStyleName;
}
else if (strAttributeName  ==  conDropDownLstStyle.Style)
{
return mstrStyle;
}
else if (strAttributeName  ==  conDropDownLstStyle.Runat)
{
return mstrRunat;
}
else if (strAttributeName  ==  conDropDownLstStyle.FontSize)
{
return mstrFontSize;
}
else if (strAttributeName  ==  conDropDownLstStyle.FontName)
{
return mstrFontName;
}
else if (strAttributeName  ==  conDropDownLstStyle.Width)
{
return mintWidth;
}
else if (strAttributeName  ==  conDropDownLstStyle.Height)
{
return mintHeight;
}
else if (strAttributeName  ==  conDropDownLstStyle.TextMode)
{
return mstrTextMode;
}
else if (strAttributeName  ==  conDropDownLstStyle.ReadOnly)
{
return mbolReadOnly;
}
else if (strAttributeName  ==  conDropDownLstStyle.BackColor)
{
return mstrBackColor;
}
else if (strAttributeName  ==  conDropDownLstStyle.ForeColor)
{
return mstrForeColor;
}
else if (strAttributeName  ==  conDropDownLstStyle.DataTextField)
{
return mstrDataTextField;
}
else if (strAttributeName  ==  conDropDownLstStyle.DataValueField)
{
return mstrDataValueField;
}
else if (strAttributeName  ==  conDropDownLstStyle.DataTextFormatString)
{
return mstrDataTextFormatString;
}
else if (strAttributeName  ==  conDropDownLstStyle.AccessKey)
{
return mstrAccessKey;
}
else if (strAttributeName  ==  conDropDownLstStyle.AutoPostBack)
{
return mbolAutoPostBack;
}
else if (strAttributeName  ==  conDropDownLstStyle.Visible)
{
return mbolVisible;
}
else if (strAttributeName  ==  conDropDownLstStyle.StyleZindex)
{
return mintStyleZindex;
}
else if (strAttributeName  ==  conDropDownLstStyle.StyleLeft)
{
return mintStyleLeft;
}
else if (strAttributeName  ==  conDropDownLstStyle.StylePosition)
{
return mstrStylePosition;
}
else if (strAttributeName  ==  conDropDownLstStyle.StyleTop)
{
return mintStyleTop;
}
return null;
}
set
{
if (strAttributeName  ==  conDropDownLstStyle.DropDownLstStyleId)
{
mstrDropDownLstStyleId = value.ToString();
 AddUpdatedFld(conDropDownLstStyle.DropDownLstStyleId);
}
else if (strAttributeName  ==  conDropDownLstStyle.DropDownLstStyleName)
{
mstrDropDownLstStyleName = value.ToString();
 AddUpdatedFld(conDropDownLstStyle.DropDownLstStyleName);
}
else if (strAttributeName  ==  conDropDownLstStyle.Style)
{
mstrStyle = value.ToString();
 AddUpdatedFld(conDropDownLstStyle.Style);
}
else if (strAttributeName  ==  conDropDownLstStyle.Runat)
{
mstrRunat = value.ToString();
 AddUpdatedFld(conDropDownLstStyle.Runat);
}
else if (strAttributeName  ==  conDropDownLstStyle.FontSize)
{
mstrFontSize = value.ToString();
 AddUpdatedFld(conDropDownLstStyle.FontSize);
}
else if (strAttributeName  ==  conDropDownLstStyle.FontName)
{
mstrFontName = value.ToString();
 AddUpdatedFld(conDropDownLstStyle.FontName);
}
else if (strAttributeName  ==  conDropDownLstStyle.Width)
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(conDropDownLstStyle.Width);
}
else if (strAttributeName  ==  conDropDownLstStyle.Height)
{
mintHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(conDropDownLstStyle.Height);
}
else if (strAttributeName  ==  conDropDownLstStyle.TextMode)
{
mstrTextMode = value.ToString();
 AddUpdatedFld(conDropDownLstStyle.TextMode);
}
else if (strAttributeName  ==  conDropDownLstStyle.ReadOnly)
{
mbolReadOnly = TransNullToBool(value.ToString());
 AddUpdatedFld(conDropDownLstStyle.ReadOnly);
}
else if (strAttributeName  ==  conDropDownLstStyle.BackColor)
{
mstrBackColor = value.ToString();
 AddUpdatedFld(conDropDownLstStyle.BackColor);
}
else if (strAttributeName  ==  conDropDownLstStyle.ForeColor)
{
mstrForeColor = value.ToString();
 AddUpdatedFld(conDropDownLstStyle.ForeColor);
}
else if (strAttributeName  ==  conDropDownLstStyle.DataTextField)
{
mstrDataTextField = value.ToString();
 AddUpdatedFld(conDropDownLstStyle.DataTextField);
}
else if (strAttributeName  ==  conDropDownLstStyle.DataValueField)
{
mstrDataValueField = value.ToString();
 AddUpdatedFld(conDropDownLstStyle.DataValueField);
}
else if (strAttributeName  ==  conDropDownLstStyle.DataTextFormatString)
{
mstrDataTextFormatString = value.ToString();
 AddUpdatedFld(conDropDownLstStyle.DataTextFormatString);
}
else if (strAttributeName  ==  conDropDownLstStyle.AccessKey)
{
mstrAccessKey = value.ToString();
 AddUpdatedFld(conDropDownLstStyle.AccessKey);
}
else if (strAttributeName  ==  conDropDownLstStyle.AutoPostBack)
{
mbolAutoPostBack = TransNullToBool(value.ToString());
 AddUpdatedFld(conDropDownLstStyle.AutoPostBack);
}
else if (strAttributeName  ==  conDropDownLstStyle.Visible)
{
mbolVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conDropDownLstStyle.Visible);
}
else if (strAttributeName  ==  conDropDownLstStyle.StyleZindex)
{
mintStyleZindex = TransNullToInt(value.ToString());
 AddUpdatedFld(conDropDownLstStyle.StyleZindex);
}
else if (strAttributeName  ==  conDropDownLstStyle.StyleLeft)
{
mintStyleLeft = TransNullToInt(value.ToString());
 AddUpdatedFld(conDropDownLstStyle.StyleLeft);
}
else if (strAttributeName  ==  conDropDownLstStyle.StylePosition)
{
mstrStylePosition = value.ToString();
 AddUpdatedFld(conDropDownLstStyle.StylePosition);
}
else if (strAttributeName  ==  conDropDownLstStyle.StyleTop)
{
mintStyleTop = TransNullToInt(value.ToString());
 AddUpdatedFld(conDropDownLstStyle.StyleTop);
}
}
}
public object this[int intIndex]
{
get
{
if (conDropDownLstStyle.DropDownLstStyleId  ==  _AttributeName[intIndex])
{
return mstrDropDownLstStyleId;
}
else if (conDropDownLstStyle.DropDownLstStyleName  ==  _AttributeName[intIndex])
{
return mstrDropDownLstStyleName;
}
else if (conDropDownLstStyle.Style  ==  _AttributeName[intIndex])
{
return mstrStyle;
}
else if (conDropDownLstStyle.Runat  ==  _AttributeName[intIndex])
{
return mstrRunat;
}
else if (conDropDownLstStyle.FontSize  ==  _AttributeName[intIndex])
{
return mstrFontSize;
}
else if (conDropDownLstStyle.FontName  ==  _AttributeName[intIndex])
{
return mstrFontName;
}
else if (conDropDownLstStyle.Width  ==  _AttributeName[intIndex])
{
return mintWidth;
}
else if (conDropDownLstStyle.Height  ==  _AttributeName[intIndex])
{
return mintHeight;
}
else if (conDropDownLstStyle.TextMode  ==  _AttributeName[intIndex])
{
return mstrTextMode;
}
else if (conDropDownLstStyle.ReadOnly  ==  _AttributeName[intIndex])
{
return mbolReadOnly;
}
else if (conDropDownLstStyle.BackColor  ==  _AttributeName[intIndex])
{
return mstrBackColor;
}
else if (conDropDownLstStyle.ForeColor  ==  _AttributeName[intIndex])
{
return mstrForeColor;
}
else if (conDropDownLstStyle.DataTextField  ==  _AttributeName[intIndex])
{
return mstrDataTextField;
}
else if (conDropDownLstStyle.DataValueField  ==  _AttributeName[intIndex])
{
return mstrDataValueField;
}
else if (conDropDownLstStyle.DataTextFormatString  ==  _AttributeName[intIndex])
{
return mstrDataTextFormatString;
}
else if (conDropDownLstStyle.AccessKey  ==  _AttributeName[intIndex])
{
return mstrAccessKey;
}
else if (conDropDownLstStyle.AutoPostBack  ==  _AttributeName[intIndex])
{
return mbolAutoPostBack;
}
else if (conDropDownLstStyle.Visible  ==  _AttributeName[intIndex])
{
return mbolVisible;
}
else if (conDropDownLstStyle.StyleZindex  ==  _AttributeName[intIndex])
{
return mintStyleZindex;
}
else if (conDropDownLstStyle.StyleLeft  ==  _AttributeName[intIndex])
{
return mintStyleLeft;
}
else if (conDropDownLstStyle.StylePosition  ==  _AttributeName[intIndex])
{
return mstrStylePosition;
}
else if (conDropDownLstStyle.StyleTop  ==  _AttributeName[intIndex])
{
return mintStyleTop;
}
return null;
}
set
{
if (conDropDownLstStyle.DropDownLstStyleId  ==  _AttributeName[intIndex])
{
mstrDropDownLstStyleId = value.ToString();
 AddUpdatedFld(conDropDownLstStyle.DropDownLstStyleId);
}
else if (conDropDownLstStyle.DropDownLstStyleName  ==  _AttributeName[intIndex])
{
mstrDropDownLstStyleName = value.ToString();
 AddUpdatedFld(conDropDownLstStyle.DropDownLstStyleName);
}
else if (conDropDownLstStyle.Style  ==  _AttributeName[intIndex])
{
mstrStyle = value.ToString();
 AddUpdatedFld(conDropDownLstStyle.Style);
}
else if (conDropDownLstStyle.Runat  ==  _AttributeName[intIndex])
{
mstrRunat = value.ToString();
 AddUpdatedFld(conDropDownLstStyle.Runat);
}
else if (conDropDownLstStyle.FontSize  ==  _AttributeName[intIndex])
{
mstrFontSize = value.ToString();
 AddUpdatedFld(conDropDownLstStyle.FontSize);
}
else if (conDropDownLstStyle.FontName  ==  _AttributeName[intIndex])
{
mstrFontName = value.ToString();
 AddUpdatedFld(conDropDownLstStyle.FontName);
}
else if (conDropDownLstStyle.Width  ==  _AttributeName[intIndex])
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(conDropDownLstStyle.Width);
}
else if (conDropDownLstStyle.Height  ==  _AttributeName[intIndex])
{
mintHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(conDropDownLstStyle.Height);
}
else if (conDropDownLstStyle.TextMode  ==  _AttributeName[intIndex])
{
mstrTextMode = value.ToString();
 AddUpdatedFld(conDropDownLstStyle.TextMode);
}
else if (conDropDownLstStyle.ReadOnly  ==  _AttributeName[intIndex])
{
mbolReadOnly = TransNullToBool(value.ToString());
 AddUpdatedFld(conDropDownLstStyle.ReadOnly);
}
else if (conDropDownLstStyle.BackColor  ==  _AttributeName[intIndex])
{
mstrBackColor = value.ToString();
 AddUpdatedFld(conDropDownLstStyle.BackColor);
}
else if (conDropDownLstStyle.ForeColor  ==  _AttributeName[intIndex])
{
mstrForeColor = value.ToString();
 AddUpdatedFld(conDropDownLstStyle.ForeColor);
}
else if (conDropDownLstStyle.DataTextField  ==  _AttributeName[intIndex])
{
mstrDataTextField = value.ToString();
 AddUpdatedFld(conDropDownLstStyle.DataTextField);
}
else if (conDropDownLstStyle.DataValueField  ==  _AttributeName[intIndex])
{
mstrDataValueField = value.ToString();
 AddUpdatedFld(conDropDownLstStyle.DataValueField);
}
else if (conDropDownLstStyle.DataTextFormatString  ==  _AttributeName[intIndex])
{
mstrDataTextFormatString = value.ToString();
 AddUpdatedFld(conDropDownLstStyle.DataTextFormatString);
}
else if (conDropDownLstStyle.AccessKey  ==  _AttributeName[intIndex])
{
mstrAccessKey = value.ToString();
 AddUpdatedFld(conDropDownLstStyle.AccessKey);
}
else if (conDropDownLstStyle.AutoPostBack  ==  _AttributeName[intIndex])
{
mbolAutoPostBack = TransNullToBool(value.ToString());
 AddUpdatedFld(conDropDownLstStyle.AutoPostBack);
}
else if (conDropDownLstStyle.Visible  ==  _AttributeName[intIndex])
{
mbolVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conDropDownLstStyle.Visible);
}
else if (conDropDownLstStyle.StyleZindex  ==  _AttributeName[intIndex])
{
mintStyleZindex = TransNullToInt(value.ToString());
 AddUpdatedFld(conDropDownLstStyle.StyleZindex);
}
else if (conDropDownLstStyle.StyleLeft  ==  _AttributeName[intIndex])
{
mintStyleLeft = TransNullToInt(value.ToString());
 AddUpdatedFld(conDropDownLstStyle.StyleLeft);
}
else if (conDropDownLstStyle.StylePosition  ==  _AttributeName[intIndex])
{
mstrStylePosition = value.ToString();
 AddUpdatedFld(conDropDownLstStyle.StylePosition);
}
else if (conDropDownLstStyle.StyleTop  ==  _AttributeName[intIndex])
{
mintStyleTop = TransNullToInt(value.ToString());
 AddUpdatedFld(conDropDownLstStyle.StyleTop);
}
}
}

/// <summary>
/// DropDownLstStyleId(说明:;字段类型:varchar;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DropDownLstStyleId
{
get
{
return mstrDropDownLstStyleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDropDownLstStyleId = value;
}
else
{
 mstrDropDownLstStyleId = value;
}
//记录修改过的字段
 AddUpdatedFld(conDropDownLstStyle.DropDownLstStyleId);
}
}
/// <summary>
/// DropDownLstStyleName(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DropDownLstStyleName
{
get
{
return mstrDropDownLstStyleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDropDownLstStyleName = value;
}
else
{
 mstrDropDownLstStyleName = value;
}
//记录修改过的字段
 AddUpdatedFld(conDropDownLstStyle.DropDownLstStyleName);
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
 AddUpdatedFld(conDropDownLstStyle.Style);
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
 AddUpdatedFld(conDropDownLstStyle.Runat);
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
 AddUpdatedFld(conDropDownLstStyle.FontSize);
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
 AddUpdatedFld(conDropDownLstStyle.FontName);
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
 AddUpdatedFld(conDropDownLstStyle.Width);
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
 AddUpdatedFld(conDropDownLstStyle.Height);
}
}
/// <summary>
/// TextMode(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TextMode
{
get
{
return mstrTextMode;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTextMode = value;
}
else
{
 mstrTextMode = value;
}
//记录修改过的字段
 AddUpdatedFld(conDropDownLstStyle.TextMode);
}
}
/// <summary>
/// ReadOnly(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool ReadOnly
{
get
{
return mbolReadOnly;
}
set
{
 mbolReadOnly = value;
//记录修改过的字段
 AddUpdatedFld(conDropDownLstStyle.ReadOnly);
}
}
/// <summary>
/// 背景颜色(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string BackColor
{
get
{
return mstrBackColor;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrBackColor = value;
}
else
{
 mstrBackColor = value;
}
//记录修改过的字段
 AddUpdatedFld(conDropDownLstStyle.BackColor);
}
}
/// <summary>
/// 前景颜色(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ForeColor
{
get
{
return mstrForeColor;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrForeColor = value;
}
else
{
 mstrForeColor = value;
}
//记录修改过的字段
 AddUpdatedFld(conDropDownLstStyle.ForeColor);
}
}
/// <summary>
/// DataTextField(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataTextField
{
get
{
return mstrDataTextField;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataTextField = value;
}
else
{
 mstrDataTextField = value;
}
//记录修改过的字段
 AddUpdatedFld(conDropDownLstStyle.DataTextField);
}
}
/// <summary>
/// DataValueField(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataValueField
{
get
{
return mstrDataValueField;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataValueField = value;
}
else
{
 mstrDataValueField = value;
}
//记录修改过的字段
 AddUpdatedFld(conDropDownLstStyle.DataValueField);
}
}
/// <summary>
/// DataTextFormatString(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataTextFormatString
{
get
{
return mstrDataTextFormatString;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataTextFormatString = value;
}
else
{
 mstrDataTextFormatString = value;
}
//记录修改过的字段
 AddUpdatedFld(conDropDownLstStyle.DataTextFormatString);
}
}
/// <summary>
/// AccessKey(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AccessKey
{
get
{
return mstrAccessKey;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAccessKey = value;
}
else
{
 mstrAccessKey = value;
}
//记录修改过的字段
 AddUpdatedFld(conDropDownLstStyle.AccessKey);
}
}
/// <summary>
/// AutoPostBack(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool AutoPostBack
{
get
{
return mbolAutoPostBack;
}
set
{
 mbolAutoPostBack = value;
//记录修改过的字段
 AddUpdatedFld(conDropDownLstStyle.AutoPostBack);
}
}
/// <summary>
/// Visible(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool Visible
{
get
{
return mbolVisible;
}
set
{
 mbolVisible = value;
//记录修改过的字段
 AddUpdatedFld(conDropDownLstStyle.Visible);
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
 AddUpdatedFld(conDropDownLstStyle.StyleZindex);
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
 AddUpdatedFld(conDropDownLstStyle.StyleLeft);
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
 AddUpdatedFld(conDropDownLstStyle.StylePosition);
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
 AddUpdatedFld(conDropDownLstStyle.StyleTop);
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
  return mstrDropDownLstStyleId;
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
  return mstrDropDownLstStyleName;
 }
 }
}
 /// <summary>
 /// 下拉框样式(DropDownLstStyle)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conDropDownLstStyle
{
public const string _CurrTabName = "DropDownLstStyle"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "DropDownLstStyleId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"DropDownLstStyleId", "DropDownLstStyleName", "Style", "Runat", "FontSize", "FontName", "Width", "Height", "TextMode", "ReadOnly", "BackColor", "ForeColor", "DataTextField", "DataValueField", "DataTextFormatString", "AccessKey", "AutoPostBack", "Visible", "StyleZindex", "StyleLeft", "StylePosition", "StyleTop"};
//以下是属性变量


 /// <summary>
 /// 常量:"DropDownLstStyleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DropDownLstStyleId = "DropDownLstStyleId";    //DropDownLstStyleId

 /// <summary>
 /// 常量:"DropDownLstStyleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DropDownLstStyleName = "DropDownLstStyleName";    //DropDownLstStyleName

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
 /// 常量:"TextMode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextMode = "TextMode";    //TextMode

 /// <summary>
 /// 常量:"ReadOnly"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReadOnly = "ReadOnly";    //ReadOnly

 /// <summary>
 /// 常量:"BackColor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BackColor = "BackColor";    //背景颜色

 /// <summary>
 /// 常量:"ForeColor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ForeColor = "ForeColor";    //前景颜色

 /// <summary>
 /// 常量:"DataTextField"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataTextField = "DataTextField";    //DataTextField

 /// <summary>
 /// 常量:"DataValueField"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataValueField = "DataValueField";    //DataValueField

 /// <summary>
 /// 常量:"DataTextFormatString"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataTextFormatString = "DataTextFormatString";    //DataTextFormatString

 /// <summary>
 /// 常量:"AccessKey"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AccessKey = "AccessKey";    //AccessKey

 /// <summary>
 /// 常量:"AutoPostBack"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AutoPostBack = "AutoPostBack";    //AutoPostBack

 /// <summary>
 /// 常量:"Visible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Visible = "Visible";    //Visible

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
}

}