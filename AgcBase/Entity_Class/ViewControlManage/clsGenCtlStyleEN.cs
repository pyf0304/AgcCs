
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsGenCtlStyleEN
 表名:GenCtlStyle(00050064)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:10:06
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:界面控件管理(ViewControlManage)
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
 /// 表GenCtlStyle的关键字(GenCtlStyleId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_GenCtlStyleId_GenCtlStyle
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strGenCtlStyleId">表关键字</param>
public K_GenCtlStyleId_GenCtlStyle(string strGenCtlStyleId)
{
if (IsValid(strGenCtlStyleId)) Value = strGenCtlStyleId;
else
{
Value = null;
}
}
private static bool IsValid(string strGenCtlStyleId)
{
if (string.IsNullOrEmpty(strGenCtlStyleId) == true) return false;
if (strGenCtlStyleId.Length > 4) return false;
if (strGenCtlStyleId.IndexOf(' ') >= 0) return false;
if (strGenCtlStyleId.IndexOf(')') >= 0) return false;
if (strGenCtlStyleId.IndexOf('(') >= 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_GenCtlStyleId_GenCtlStyle]类型的对象</returns>
public static implicit operator K_GenCtlStyleId_GenCtlStyle(string value)
{
return new K_GenCtlStyleId_GenCtlStyle(value);
}
}
 /// <summary>
 /// 一般控件样式(GenCtlStyle)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsGenCtlStyleEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "GenCtlStyle"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "GenCtlStyleId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 13;
public static string[] _AttributeName = new string[] {"GenCtlStyleId", "GenCtlStyleName", "Style", "Runat", "FontSize", "FontName", "Width", "Height", "TextMode", "StyleZindex", "StyleLeft", "StylePosition", "StyleTop"};

protected string mstrGenCtlStyleId;    //GenCtlStyleId
protected string mstrGenCtlStyleName;    //GenCtlStyleName
protected string mstrStyle;    //类型
protected string mstrRunat;    //运行在
protected string mstrFontSize;    //字号
protected string mstrFontName;    //字体
protected int? mintWidth;    //宽
protected int? mintHeight;    //高度
protected string mstrTextMode;    //TextMode
protected int? mintStyleZindex;    //Style_Zindex
protected int? mintStyleLeft;    //Style_Left
protected string mstrStylePosition;    //Style_Position
protected int? mintStyleTop;    //Style_Top

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsGenCtlStyleEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("GenCtlStyleId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strGenCtlStyleId">关键字:GenCtlStyleId</param>
public clsGenCtlStyleEN(string strGenCtlStyleId)
 {
strGenCtlStyleId = strGenCtlStyleId.Replace("'", "''");
if (strGenCtlStyleId.Length > 4)
{
throw new Exception("在表:GenCtlStyle中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strGenCtlStyleId)  ==  true)
{
throw new Exception("在表:GenCtlStyle中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strGenCtlStyleId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrGenCtlStyleId = strGenCtlStyleId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("GenCtlStyleId");
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
if (strAttributeName  ==  conGenCtlStyle.GenCtlStyleId)
{
return mstrGenCtlStyleId;
}
else if (strAttributeName  ==  conGenCtlStyle.GenCtlStyleName)
{
return mstrGenCtlStyleName;
}
else if (strAttributeName  ==  conGenCtlStyle.Style)
{
return mstrStyle;
}
else if (strAttributeName  ==  conGenCtlStyle.Runat)
{
return mstrRunat;
}
else if (strAttributeName  ==  conGenCtlStyle.FontSize)
{
return mstrFontSize;
}
else if (strAttributeName  ==  conGenCtlStyle.FontName)
{
return mstrFontName;
}
else if (strAttributeName  ==  conGenCtlStyle.Width)
{
return mintWidth;
}
else if (strAttributeName  ==  conGenCtlStyle.Height)
{
return mintHeight;
}
else if (strAttributeName  ==  conGenCtlStyle.TextMode)
{
return mstrTextMode;
}
else if (strAttributeName  ==  conGenCtlStyle.StyleZindex)
{
return mintStyleZindex;
}
else if (strAttributeName  ==  conGenCtlStyle.StyleLeft)
{
return mintStyleLeft;
}
else if (strAttributeName  ==  conGenCtlStyle.StylePosition)
{
return mstrStylePosition;
}
else if (strAttributeName  ==  conGenCtlStyle.StyleTop)
{
return mintStyleTop;
}
return null;
}
set
{
if (strAttributeName  ==  conGenCtlStyle.GenCtlStyleId)
{
mstrGenCtlStyleId = value.ToString();
 AddUpdatedFld(conGenCtlStyle.GenCtlStyleId);
}
else if (strAttributeName  ==  conGenCtlStyle.GenCtlStyleName)
{
mstrGenCtlStyleName = value.ToString();
 AddUpdatedFld(conGenCtlStyle.GenCtlStyleName);
}
else if (strAttributeName  ==  conGenCtlStyle.Style)
{
mstrStyle = value.ToString();
 AddUpdatedFld(conGenCtlStyle.Style);
}
else if (strAttributeName  ==  conGenCtlStyle.Runat)
{
mstrRunat = value.ToString();
 AddUpdatedFld(conGenCtlStyle.Runat);
}
else if (strAttributeName  ==  conGenCtlStyle.FontSize)
{
mstrFontSize = value.ToString();
 AddUpdatedFld(conGenCtlStyle.FontSize);
}
else if (strAttributeName  ==  conGenCtlStyle.FontName)
{
mstrFontName = value.ToString();
 AddUpdatedFld(conGenCtlStyle.FontName);
}
else if (strAttributeName  ==  conGenCtlStyle.Width)
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(conGenCtlStyle.Width);
}
else if (strAttributeName  ==  conGenCtlStyle.Height)
{
mintHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(conGenCtlStyle.Height);
}
else if (strAttributeName  ==  conGenCtlStyle.TextMode)
{
mstrTextMode = value.ToString();
 AddUpdatedFld(conGenCtlStyle.TextMode);
}
else if (strAttributeName  ==  conGenCtlStyle.StyleZindex)
{
mintStyleZindex = TransNullToInt(value.ToString());
 AddUpdatedFld(conGenCtlStyle.StyleZindex);
}
else if (strAttributeName  ==  conGenCtlStyle.StyleLeft)
{
mintStyleLeft = TransNullToInt(value.ToString());
 AddUpdatedFld(conGenCtlStyle.StyleLeft);
}
else if (strAttributeName  ==  conGenCtlStyle.StylePosition)
{
mstrStylePosition = value.ToString();
 AddUpdatedFld(conGenCtlStyle.StylePosition);
}
else if (strAttributeName  ==  conGenCtlStyle.StyleTop)
{
mintStyleTop = TransNullToInt(value.ToString());
 AddUpdatedFld(conGenCtlStyle.StyleTop);
}
}
}
public object this[int intIndex]
{
get
{
if (conGenCtlStyle.GenCtlStyleId  ==  _AttributeName[intIndex])
{
return mstrGenCtlStyleId;
}
else if (conGenCtlStyle.GenCtlStyleName  ==  _AttributeName[intIndex])
{
return mstrGenCtlStyleName;
}
else if (conGenCtlStyle.Style  ==  _AttributeName[intIndex])
{
return mstrStyle;
}
else if (conGenCtlStyle.Runat  ==  _AttributeName[intIndex])
{
return mstrRunat;
}
else if (conGenCtlStyle.FontSize  ==  _AttributeName[intIndex])
{
return mstrFontSize;
}
else if (conGenCtlStyle.FontName  ==  _AttributeName[intIndex])
{
return mstrFontName;
}
else if (conGenCtlStyle.Width  ==  _AttributeName[intIndex])
{
return mintWidth;
}
else if (conGenCtlStyle.Height  ==  _AttributeName[intIndex])
{
return mintHeight;
}
else if (conGenCtlStyle.TextMode  ==  _AttributeName[intIndex])
{
return mstrTextMode;
}
else if (conGenCtlStyle.StyleZindex  ==  _AttributeName[intIndex])
{
return mintStyleZindex;
}
else if (conGenCtlStyle.StyleLeft  ==  _AttributeName[intIndex])
{
return mintStyleLeft;
}
else if (conGenCtlStyle.StylePosition  ==  _AttributeName[intIndex])
{
return mstrStylePosition;
}
else if (conGenCtlStyle.StyleTop  ==  _AttributeName[intIndex])
{
return mintStyleTop;
}
return null;
}
set
{
if (conGenCtlStyle.GenCtlStyleId  ==  _AttributeName[intIndex])
{
mstrGenCtlStyleId = value.ToString();
 AddUpdatedFld(conGenCtlStyle.GenCtlStyleId);
}
else if (conGenCtlStyle.GenCtlStyleName  ==  _AttributeName[intIndex])
{
mstrGenCtlStyleName = value.ToString();
 AddUpdatedFld(conGenCtlStyle.GenCtlStyleName);
}
else if (conGenCtlStyle.Style  ==  _AttributeName[intIndex])
{
mstrStyle = value.ToString();
 AddUpdatedFld(conGenCtlStyle.Style);
}
else if (conGenCtlStyle.Runat  ==  _AttributeName[intIndex])
{
mstrRunat = value.ToString();
 AddUpdatedFld(conGenCtlStyle.Runat);
}
else if (conGenCtlStyle.FontSize  ==  _AttributeName[intIndex])
{
mstrFontSize = value.ToString();
 AddUpdatedFld(conGenCtlStyle.FontSize);
}
else if (conGenCtlStyle.FontName  ==  _AttributeName[intIndex])
{
mstrFontName = value.ToString();
 AddUpdatedFld(conGenCtlStyle.FontName);
}
else if (conGenCtlStyle.Width  ==  _AttributeName[intIndex])
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(conGenCtlStyle.Width);
}
else if (conGenCtlStyle.Height  ==  _AttributeName[intIndex])
{
mintHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(conGenCtlStyle.Height);
}
else if (conGenCtlStyle.TextMode  ==  _AttributeName[intIndex])
{
mstrTextMode = value.ToString();
 AddUpdatedFld(conGenCtlStyle.TextMode);
}
else if (conGenCtlStyle.StyleZindex  ==  _AttributeName[intIndex])
{
mintStyleZindex = TransNullToInt(value.ToString());
 AddUpdatedFld(conGenCtlStyle.StyleZindex);
}
else if (conGenCtlStyle.StyleLeft  ==  _AttributeName[intIndex])
{
mintStyleLeft = TransNullToInt(value.ToString());
 AddUpdatedFld(conGenCtlStyle.StyleLeft);
}
else if (conGenCtlStyle.StylePosition  ==  _AttributeName[intIndex])
{
mstrStylePosition = value.ToString();
 AddUpdatedFld(conGenCtlStyle.StylePosition);
}
else if (conGenCtlStyle.StyleTop  ==  _AttributeName[intIndex])
{
mintStyleTop = TransNullToInt(value.ToString());
 AddUpdatedFld(conGenCtlStyle.StyleTop);
}
}
}

/// <summary>
/// GenCtlStyleId(说明:;字段类型:varchar;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GenCtlStyleId
{
get
{
return mstrGenCtlStyleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGenCtlStyleId = value;
}
else
{
 mstrGenCtlStyleId = value;
}
//记录修改过的字段
 AddUpdatedFld(conGenCtlStyle.GenCtlStyleId);
}
}
/// <summary>
/// GenCtlStyleName(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GenCtlStyleName
{
get
{
return mstrGenCtlStyleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGenCtlStyleName = value;
}
else
{
 mstrGenCtlStyleName = value;
}
//记录修改过的字段
 AddUpdatedFld(conGenCtlStyle.GenCtlStyleName);
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
 AddUpdatedFld(conGenCtlStyle.Style);
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
 AddUpdatedFld(conGenCtlStyle.Runat);
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
 AddUpdatedFld(conGenCtlStyle.FontSize);
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
 AddUpdatedFld(conGenCtlStyle.FontName);
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
 AddUpdatedFld(conGenCtlStyle.Width);
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
 AddUpdatedFld(conGenCtlStyle.Height);
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
 AddUpdatedFld(conGenCtlStyle.TextMode);
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
 AddUpdatedFld(conGenCtlStyle.StyleZindex);
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
 AddUpdatedFld(conGenCtlStyle.StyleLeft);
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
 AddUpdatedFld(conGenCtlStyle.StylePosition);
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
 AddUpdatedFld(conGenCtlStyle.StyleTop);
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
  return mstrGenCtlStyleId;
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
  return mstrGenCtlStyleName;
 }
 }
}
 /// <summary>
 /// 一般控件样式(GenCtlStyle)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conGenCtlStyle
{
public const string _CurrTabName = "GenCtlStyle"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "GenCtlStyleId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"GenCtlStyleId", "GenCtlStyleName", "Style", "Runat", "FontSize", "FontName", "Width", "Height", "TextMode", "StyleZindex", "StyleLeft", "StylePosition", "StyleTop"};
//以下是属性变量


 /// <summary>
 /// 常量:"GenCtlStyleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GenCtlStyleId = "GenCtlStyleId";    //GenCtlStyleId

 /// <summary>
 /// 常量:"GenCtlStyleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GenCtlStyleName = "GenCtlStyleName";    //GenCtlStyleName

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