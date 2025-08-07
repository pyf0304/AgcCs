
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCheckStyleEN
 表名:CheckStyle(00050056)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:33:49
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
 /// 表CheckStyle的关键字(CheckStyleId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CheckStyleId_CheckStyle
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strCheckStyleId">表关键字</param>
public K_CheckStyleId_CheckStyle(string strCheckStyleId)
{
if (IsValid(strCheckStyleId)) Value = strCheckStyleId;
else
{
Value = null;
}
}
private static bool IsValid(string strCheckStyleId)
{
if (string.IsNullOrEmpty(strCheckStyleId) == true) return false;
if (strCheckStyleId.Length > 4) return false;
if (strCheckStyleId.IndexOf(' ') >= 0) return false;
if (strCheckStyleId.IndexOf(')') >= 0) return false;
if (strCheckStyleId.IndexOf('(') >= 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_CheckStyleId_CheckStyle]类型的对象</returns>
public static implicit operator K_CheckStyleId_CheckStyle(string value)
{
return new K_CheckStyleId_CheckStyle(value);
}
}
 /// <summary>
 /// 复选框样式(CheckStyle)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCheckStyleEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CheckStyle"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "CheckStyleId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 12;
public static string[] _AttributeName = new string[] {"CheckStyleId", "CheckStyleName", "Style", "Runat", "FontSize", "FontName", "Width", "Height", "StyleZindex", "StyleLeft", "StylePosition", "StyleTop"};

protected string mstrCheckStyleId;    //CheckStyleId
protected string mstrCheckStyleName;    //CheckStyleName
protected string mstrStyle;    //类型
protected string mstrRunat;    //运行在
protected string mstrFontSize;    //字号
protected string mstrFontName;    //字体
protected int? mintWidth;    //宽
protected int? mintHeight;    //高度
protected int? mintStyleZindex;    //Style_Zindex
protected int? mintStyleLeft;    //Style_Left
protected string mstrStylePosition;    //Style_Position
protected int? mintStyleTop;    //Style_Top

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsCheckStyleEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CheckStyleId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strCheckStyleId">关键字:CheckStyleId</param>
public clsCheckStyleEN(string strCheckStyleId)
 {
strCheckStyleId = strCheckStyleId.Replace("'", "''");
if (strCheckStyleId.Length > 4)
{
throw new Exception("在表:CheckStyle中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strCheckStyleId)  ==  true)
{
throw new Exception("在表:CheckStyle中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCheckStyleId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrCheckStyleId = strCheckStyleId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CheckStyleId");
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
if (strAttributeName  ==  conCheckStyle.CheckStyleId)
{
return mstrCheckStyleId;
}
else if (strAttributeName  ==  conCheckStyle.CheckStyleName)
{
return mstrCheckStyleName;
}
else if (strAttributeName  ==  conCheckStyle.Style)
{
return mstrStyle;
}
else if (strAttributeName  ==  conCheckStyle.Runat)
{
return mstrRunat;
}
else if (strAttributeName  ==  conCheckStyle.FontSize)
{
return mstrFontSize;
}
else if (strAttributeName  ==  conCheckStyle.FontName)
{
return mstrFontName;
}
else if (strAttributeName  ==  conCheckStyle.Width)
{
return mintWidth;
}
else if (strAttributeName  ==  conCheckStyle.Height)
{
return mintHeight;
}
else if (strAttributeName  ==  conCheckStyle.StyleZindex)
{
return mintStyleZindex;
}
else if (strAttributeName  ==  conCheckStyle.StyleLeft)
{
return mintStyleLeft;
}
else if (strAttributeName  ==  conCheckStyle.StylePosition)
{
return mstrStylePosition;
}
else if (strAttributeName  ==  conCheckStyle.StyleTop)
{
return mintStyleTop;
}
return null;
}
set
{
if (strAttributeName  ==  conCheckStyle.CheckStyleId)
{
mstrCheckStyleId = value.ToString();
 AddUpdatedFld(conCheckStyle.CheckStyleId);
}
else if (strAttributeName  ==  conCheckStyle.CheckStyleName)
{
mstrCheckStyleName = value.ToString();
 AddUpdatedFld(conCheckStyle.CheckStyleName);
}
else if (strAttributeName  ==  conCheckStyle.Style)
{
mstrStyle = value.ToString();
 AddUpdatedFld(conCheckStyle.Style);
}
else if (strAttributeName  ==  conCheckStyle.Runat)
{
mstrRunat = value.ToString();
 AddUpdatedFld(conCheckStyle.Runat);
}
else if (strAttributeName  ==  conCheckStyle.FontSize)
{
mstrFontSize = value.ToString();
 AddUpdatedFld(conCheckStyle.FontSize);
}
else if (strAttributeName  ==  conCheckStyle.FontName)
{
mstrFontName = value.ToString();
 AddUpdatedFld(conCheckStyle.FontName);
}
else if (strAttributeName  ==  conCheckStyle.Width)
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(conCheckStyle.Width);
}
else if (strAttributeName  ==  conCheckStyle.Height)
{
mintHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(conCheckStyle.Height);
}
else if (strAttributeName  ==  conCheckStyle.StyleZindex)
{
mintStyleZindex = TransNullToInt(value.ToString());
 AddUpdatedFld(conCheckStyle.StyleZindex);
}
else if (strAttributeName  ==  conCheckStyle.StyleLeft)
{
mintStyleLeft = TransNullToInt(value.ToString());
 AddUpdatedFld(conCheckStyle.StyleLeft);
}
else if (strAttributeName  ==  conCheckStyle.StylePosition)
{
mstrStylePosition = value.ToString();
 AddUpdatedFld(conCheckStyle.StylePosition);
}
else if (strAttributeName  ==  conCheckStyle.StyleTop)
{
mintStyleTop = TransNullToInt(value.ToString());
 AddUpdatedFld(conCheckStyle.StyleTop);
}
}
}
public object this[int intIndex]
{
get
{
if (conCheckStyle.CheckStyleId  ==  _AttributeName[intIndex])
{
return mstrCheckStyleId;
}
else if (conCheckStyle.CheckStyleName  ==  _AttributeName[intIndex])
{
return mstrCheckStyleName;
}
else if (conCheckStyle.Style  ==  _AttributeName[intIndex])
{
return mstrStyle;
}
else if (conCheckStyle.Runat  ==  _AttributeName[intIndex])
{
return mstrRunat;
}
else if (conCheckStyle.FontSize  ==  _AttributeName[intIndex])
{
return mstrFontSize;
}
else if (conCheckStyle.FontName  ==  _AttributeName[intIndex])
{
return mstrFontName;
}
else if (conCheckStyle.Width  ==  _AttributeName[intIndex])
{
return mintWidth;
}
else if (conCheckStyle.Height  ==  _AttributeName[intIndex])
{
return mintHeight;
}
else if (conCheckStyle.StyleZindex  ==  _AttributeName[intIndex])
{
return mintStyleZindex;
}
else if (conCheckStyle.StyleLeft  ==  _AttributeName[intIndex])
{
return mintStyleLeft;
}
else if (conCheckStyle.StylePosition  ==  _AttributeName[intIndex])
{
return mstrStylePosition;
}
else if (conCheckStyle.StyleTop  ==  _AttributeName[intIndex])
{
return mintStyleTop;
}
return null;
}
set
{
if (conCheckStyle.CheckStyleId  ==  _AttributeName[intIndex])
{
mstrCheckStyleId = value.ToString();
 AddUpdatedFld(conCheckStyle.CheckStyleId);
}
else if (conCheckStyle.CheckStyleName  ==  _AttributeName[intIndex])
{
mstrCheckStyleName = value.ToString();
 AddUpdatedFld(conCheckStyle.CheckStyleName);
}
else if (conCheckStyle.Style  ==  _AttributeName[intIndex])
{
mstrStyle = value.ToString();
 AddUpdatedFld(conCheckStyle.Style);
}
else if (conCheckStyle.Runat  ==  _AttributeName[intIndex])
{
mstrRunat = value.ToString();
 AddUpdatedFld(conCheckStyle.Runat);
}
else if (conCheckStyle.FontSize  ==  _AttributeName[intIndex])
{
mstrFontSize = value.ToString();
 AddUpdatedFld(conCheckStyle.FontSize);
}
else if (conCheckStyle.FontName  ==  _AttributeName[intIndex])
{
mstrFontName = value.ToString();
 AddUpdatedFld(conCheckStyle.FontName);
}
else if (conCheckStyle.Width  ==  _AttributeName[intIndex])
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(conCheckStyle.Width);
}
else if (conCheckStyle.Height  ==  _AttributeName[intIndex])
{
mintHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(conCheckStyle.Height);
}
else if (conCheckStyle.StyleZindex  ==  _AttributeName[intIndex])
{
mintStyleZindex = TransNullToInt(value.ToString());
 AddUpdatedFld(conCheckStyle.StyleZindex);
}
else if (conCheckStyle.StyleLeft  ==  _AttributeName[intIndex])
{
mintStyleLeft = TransNullToInt(value.ToString());
 AddUpdatedFld(conCheckStyle.StyleLeft);
}
else if (conCheckStyle.StylePosition  ==  _AttributeName[intIndex])
{
mstrStylePosition = value.ToString();
 AddUpdatedFld(conCheckStyle.StylePosition);
}
else if (conCheckStyle.StyleTop  ==  _AttributeName[intIndex])
{
mintStyleTop = TransNullToInt(value.ToString());
 AddUpdatedFld(conCheckStyle.StyleTop);
}
}
}

/// <summary>
/// CheckStyleId(说明:;字段类型:varchar;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CheckStyleId
{
get
{
return mstrCheckStyleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCheckStyleId = value;
}
else
{
 mstrCheckStyleId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCheckStyle.CheckStyleId);
}
}
/// <summary>
/// CheckStyleName(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CheckStyleName
{
get
{
return mstrCheckStyleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCheckStyleName = value;
}
else
{
 mstrCheckStyleName = value;
}
//记录修改过的字段
 AddUpdatedFld(conCheckStyle.CheckStyleName);
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
 AddUpdatedFld(conCheckStyle.Style);
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
 AddUpdatedFld(conCheckStyle.Runat);
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
 AddUpdatedFld(conCheckStyle.FontSize);
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
 AddUpdatedFld(conCheckStyle.FontName);
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
 AddUpdatedFld(conCheckStyle.Width);
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
 AddUpdatedFld(conCheckStyle.Height);
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
 AddUpdatedFld(conCheckStyle.StyleZindex);
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
 AddUpdatedFld(conCheckStyle.StyleLeft);
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
 AddUpdatedFld(conCheckStyle.StylePosition);
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
 AddUpdatedFld(conCheckStyle.StyleTop);
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
  return mstrCheckStyleId;
 }
 }
}
 /// <summary>
 /// 复选框样式(CheckStyle)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCheckStyle
{
public const string _CurrTabName = "CheckStyle"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CheckStyleId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"CheckStyleId", "CheckStyleName", "Style", "Runat", "FontSize", "FontName", "Width", "Height", "StyleZindex", "StyleLeft", "StylePosition", "StyleTop"};
//以下是属性变量


 /// <summary>
 /// 常量:"CheckStyleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CheckStyleId = "CheckStyleId";    //CheckStyleId

 /// <summary>
 /// 常量:"CheckStyleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CheckStyleName = "CheckStyleName";    //CheckStyleName

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