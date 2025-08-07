
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsLabelStyleEN
 表名:LabelStyle(00050066)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:35:29
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统参数(SysPara)
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
 /// 表LabelStyle的关键字(LabelStyleId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_LabelStyleId_LabelStyle
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strLabelStyleId">表关键字</param>
public K_LabelStyleId_LabelStyle(string strLabelStyleId)
{
if (IsValid(strLabelStyleId)) Value = strLabelStyleId;
else
{
Value = null;
}
}
private static bool IsValid(string strLabelStyleId)
{
if (string.IsNullOrEmpty(strLabelStyleId) == true) return false;
if (strLabelStyleId.Length > 4) return false;
if (strLabelStyleId.IndexOf(' ') >= 0) return false;
if (strLabelStyleId.IndexOf(')') >= 0) return false;
if (strLabelStyleId.IndexOf('(') >= 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_LabelStyleId_LabelStyle]类型的对象</returns>
public static implicit operator K_LabelStyleId_LabelStyle(string value)
{
return new K_LabelStyleId_LabelStyle(value);
}
}
 /// <summary>
 /// 标签样式(LabelStyle)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsLabelStyleEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "LabelStyle"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "LabelStyleId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 12;
public static string[] _AttributeName = new string[] {"LabelStyleId", "LabelStyleName", "Style", "Runat", "FontSize", "FontName", "Width", "Height", "StyleZindex", "StyleLeft", "StylePosition", "StyleTop"};

protected string mstrLabelStyleId;    //LabelStyleId
protected string mstrLabelStyleName;    //LabelStyleName
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
 public clsLabelStyleEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("LabelStyleId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strLabelStyleId">关键字:LabelStyleId</param>
public clsLabelStyleEN(string strLabelStyleId)
 {
strLabelStyleId = strLabelStyleId.Replace("'", "''");
if (strLabelStyleId.Length > 4)
{
throw new Exception("在表:LabelStyle中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strLabelStyleId)  ==  true)
{
throw new Exception("在表:LabelStyle中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strLabelStyleId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrLabelStyleId = strLabelStyleId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("LabelStyleId");
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
if (strAttributeName  ==  conLabelStyle.LabelStyleId)
{
return mstrLabelStyleId;
}
else if (strAttributeName  ==  conLabelStyle.LabelStyleName)
{
return mstrLabelStyleName;
}
else if (strAttributeName  ==  conLabelStyle.Style)
{
return mstrStyle;
}
else if (strAttributeName  ==  conLabelStyle.Runat)
{
return mstrRunat;
}
else if (strAttributeName  ==  conLabelStyle.FontSize)
{
return mstrFontSize;
}
else if (strAttributeName  ==  conLabelStyle.FontName)
{
return mstrFontName;
}
else if (strAttributeName  ==  conLabelStyle.Width)
{
return mintWidth;
}
else if (strAttributeName  ==  conLabelStyle.Height)
{
return mintHeight;
}
else if (strAttributeName  ==  conLabelStyle.StyleZindex)
{
return mintStyleZindex;
}
else if (strAttributeName  ==  conLabelStyle.StyleLeft)
{
return mintStyleLeft;
}
else if (strAttributeName  ==  conLabelStyle.StylePosition)
{
return mstrStylePosition;
}
else if (strAttributeName  ==  conLabelStyle.StyleTop)
{
return mintStyleTop;
}
return null;
}
set
{
if (strAttributeName  ==  conLabelStyle.LabelStyleId)
{
mstrLabelStyleId = value.ToString();
 AddUpdatedFld(conLabelStyle.LabelStyleId);
}
else if (strAttributeName  ==  conLabelStyle.LabelStyleName)
{
mstrLabelStyleName = value.ToString();
 AddUpdatedFld(conLabelStyle.LabelStyleName);
}
else if (strAttributeName  ==  conLabelStyle.Style)
{
mstrStyle = value.ToString();
 AddUpdatedFld(conLabelStyle.Style);
}
else if (strAttributeName  ==  conLabelStyle.Runat)
{
mstrRunat = value.ToString();
 AddUpdatedFld(conLabelStyle.Runat);
}
else if (strAttributeName  ==  conLabelStyle.FontSize)
{
mstrFontSize = value.ToString();
 AddUpdatedFld(conLabelStyle.FontSize);
}
else if (strAttributeName  ==  conLabelStyle.FontName)
{
mstrFontName = value.ToString();
 AddUpdatedFld(conLabelStyle.FontName);
}
else if (strAttributeName  ==  conLabelStyle.Width)
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(conLabelStyle.Width);
}
else if (strAttributeName  ==  conLabelStyle.Height)
{
mintHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(conLabelStyle.Height);
}
else if (strAttributeName  ==  conLabelStyle.StyleZindex)
{
mintStyleZindex = TransNullToInt(value.ToString());
 AddUpdatedFld(conLabelStyle.StyleZindex);
}
else if (strAttributeName  ==  conLabelStyle.StyleLeft)
{
mintStyleLeft = TransNullToInt(value.ToString());
 AddUpdatedFld(conLabelStyle.StyleLeft);
}
else if (strAttributeName  ==  conLabelStyle.StylePosition)
{
mstrStylePosition = value.ToString();
 AddUpdatedFld(conLabelStyle.StylePosition);
}
else if (strAttributeName  ==  conLabelStyle.StyleTop)
{
mintStyleTop = TransNullToInt(value.ToString());
 AddUpdatedFld(conLabelStyle.StyleTop);
}
}
}
public object this[int intIndex]
{
get
{
if (conLabelStyle.LabelStyleId  ==  _AttributeName[intIndex])
{
return mstrLabelStyleId;
}
else if (conLabelStyle.LabelStyleName  ==  _AttributeName[intIndex])
{
return mstrLabelStyleName;
}
else if (conLabelStyle.Style  ==  _AttributeName[intIndex])
{
return mstrStyle;
}
else if (conLabelStyle.Runat  ==  _AttributeName[intIndex])
{
return mstrRunat;
}
else if (conLabelStyle.FontSize  ==  _AttributeName[intIndex])
{
return mstrFontSize;
}
else if (conLabelStyle.FontName  ==  _AttributeName[intIndex])
{
return mstrFontName;
}
else if (conLabelStyle.Width  ==  _AttributeName[intIndex])
{
return mintWidth;
}
else if (conLabelStyle.Height  ==  _AttributeName[intIndex])
{
return mintHeight;
}
else if (conLabelStyle.StyleZindex  ==  _AttributeName[intIndex])
{
return mintStyleZindex;
}
else if (conLabelStyle.StyleLeft  ==  _AttributeName[intIndex])
{
return mintStyleLeft;
}
else if (conLabelStyle.StylePosition  ==  _AttributeName[intIndex])
{
return mstrStylePosition;
}
else if (conLabelStyle.StyleTop  ==  _AttributeName[intIndex])
{
return mintStyleTop;
}
return null;
}
set
{
if (conLabelStyle.LabelStyleId  ==  _AttributeName[intIndex])
{
mstrLabelStyleId = value.ToString();
 AddUpdatedFld(conLabelStyle.LabelStyleId);
}
else if (conLabelStyle.LabelStyleName  ==  _AttributeName[intIndex])
{
mstrLabelStyleName = value.ToString();
 AddUpdatedFld(conLabelStyle.LabelStyleName);
}
else if (conLabelStyle.Style  ==  _AttributeName[intIndex])
{
mstrStyle = value.ToString();
 AddUpdatedFld(conLabelStyle.Style);
}
else if (conLabelStyle.Runat  ==  _AttributeName[intIndex])
{
mstrRunat = value.ToString();
 AddUpdatedFld(conLabelStyle.Runat);
}
else if (conLabelStyle.FontSize  ==  _AttributeName[intIndex])
{
mstrFontSize = value.ToString();
 AddUpdatedFld(conLabelStyle.FontSize);
}
else if (conLabelStyle.FontName  ==  _AttributeName[intIndex])
{
mstrFontName = value.ToString();
 AddUpdatedFld(conLabelStyle.FontName);
}
else if (conLabelStyle.Width  ==  _AttributeName[intIndex])
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(conLabelStyle.Width);
}
else if (conLabelStyle.Height  ==  _AttributeName[intIndex])
{
mintHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(conLabelStyle.Height);
}
else if (conLabelStyle.StyleZindex  ==  _AttributeName[intIndex])
{
mintStyleZindex = TransNullToInt(value.ToString());
 AddUpdatedFld(conLabelStyle.StyleZindex);
}
else if (conLabelStyle.StyleLeft  ==  _AttributeName[intIndex])
{
mintStyleLeft = TransNullToInt(value.ToString());
 AddUpdatedFld(conLabelStyle.StyleLeft);
}
else if (conLabelStyle.StylePosition  ==  _AttributeName[intIndex])
{
mstrStylePosition = value.ToString();
 AddUpdatedFld(conLabelStyle.StylePosition);
}
else if (conLabelStyle.StyleTop  ==  _AttributeName[intIndex])
{
mintStyleTop = TransNullToInt(value.ToString());
 AddUpdatedFld(conLabelStyle.StyleTop);
}
}
}

/// <summary>
/// LabelStyleId(说明:;字段类型:varchar;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LabelStyleId
{
get
{
return mstrLabelStyleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLabelStyleId = value;
}
else
{
 mstrLabelStyleId = value;
}
//记录修改过的字段
 AddUpdatedFld(conLabelStyle.LabelStyleId);
}
}
/// <summary>
/// LabelStyleName(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LabelStyleName
{
get
{
return mstrLabelStyleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLabelStyleName = value;
}
else
{
 mstrLabelStyleName = value;
}
//记录修改过的字段
 AddUpdatedFld(conLabelStyle.LabelStyleName);
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
 AddUpdatedFld(conLabelStyle.Style);
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
 AddUpdatedFld(conLabelStyle.Runat);
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
 AddUpdatedFld(conLabelStyle.FontSize);
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
 AddUpdatedFld(conLabelStyle.FontName);
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
 AddUpdatedFld(conLabelStyle.Width);
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
 AddUpdatedFld(conLabelStyle.Height);
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
 AddUpdatedFld(conLabelStyle.StyleZindex);
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
 AddUpdatedFld(conLabelStyle.StyleLeft);
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
 AddUpdatedFld(conLabelStyle.StylePosition);
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
 AddUpdatedFld(conLabelStyle.StyleTop);
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
  return mstrLabelStyleId;
 }
 }
}
 /// <summary>
 /// 标签样式(LabelStyle)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conLabelStyle
{
public const string _CurrTabName = "LabelStyle"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "LabelStyleId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"LabelStyleId", "LabelStyleName", "Style", "Runat", "FontSize", "FontName", "Width", "Height", "StyleZindex", "StyleLeft", "StylePosition", "StyleTop"};
//以下是属性变量


 /// <summary>
 /// 常量:"LabelStyleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LabelStyleId = "LabelStyleId";    //LabelStyleId

 /// <summary>
 /// 常量:"LabelStyleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LabelStyleName = "LabelStyleName";    //LabelStyleName

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