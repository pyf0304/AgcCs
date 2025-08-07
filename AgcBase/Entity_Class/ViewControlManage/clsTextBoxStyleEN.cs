
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTextBoxStyleEN
 表名:TextBoxStyle(00050088)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:16:36
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:界面控件管理(ViewControlManage)
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
 /// 表TextBoxStyle的关键字(TextBoxStyleId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TextBoxStyleId_TextBoxStyle
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strTextBoxStyleId">表关键字</param>
public K_TextBoxStyleId_TextBoxStyle(string strTextBoxStyleId)
{
if (IsValid(strTextBoxStyleId)) Value = strTextBoxStyleId;
else
{
Value = null;
}
}
private static bool IsValid(string strTextBoxStyleId)
{
if (string.IsNullOrEmpty(strTextBoxStyleId) == true) return false;
if (strTextBoxStyleId.Length > 4) return false;
if (strTextBoxStyleId.IndexOf(' ') >= 0) return false;
if (strTextBoxStyleId.IndexOf(')') >= 0) return false;
if (strTextBoxStyleId.IndexOf('(') >= 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_TextBoxStyleId_TextBoxStyle]类型的对象</returns>
public static implicit operator K_TextBoxStyleId_TextBoxStyle(string value)
{
return new K_TextBoxStyleId_TextBoxStyle(value);
}
}
 /// <summary>
 /// TextBoxStyle(TextBoxStyle)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsTextBoxStyleEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接，如果为空就使用系统默认的连接
public new const string _CurrTabName = "TextBoxStyle"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TextBoxStyleId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string WhereFormat = ""; //条件格式串
protected const int mintAttributeCount = 14;
public static string[] AttributeName = new string[] {"TextBoxStyleId", "TextBoxStyleName", "Style", "Runat", "FontSize", "FontName", "Width", "Height", "TextMode", "ReadOnly", "StyleZindex", "StyleLeft", "StylePosition", "StyleTop"};

protected string mstrTextBoxStyleId;    //TextBoxStyleId
protected string mstrTextBoxStyleName;    //TextBoxStyleName
protected string mstrStyle;    //类型
protected string mstrRunat;    //运行在
protected string mstrFontSize;    //字号
protected string mstrFontName;    //字体
protected int? mintWidth;    //宽
protected int? mintHeight;    //高度
protected string mstrTextMode;    //TextMode
protected bool mbolReadOnly;    //ReadOnly
protected int? mintStyleZindex;    //StyleZindex
protected int? mintStyleLeft;    //StyleLeft
protected string mstrStylePosition;    //StylePosition
protected int? mintStyleTop;    //StyleTop

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsTextBoxStyleEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "TextBoxStyle";
 lstKeyFldNames.Add("TextBoxStyleId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strTextBoxStyleId">关键字:TextBoxStyleId</param>
public clsTextBoxStyleEN(string strTextBoxStyleId)
 {
strTextBoxStyleId = strTextBoxStyleId.Replace("'", "''");
if (strTextBoxStyleId.Length > 4)
{
throw new Exception("在表:TextBoxStyle中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTextBoxStyleId)  ==  true)
{
throw new Exception("在表:TextBoxStyle中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTextBoxStyleId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrTextBoxStyleId = strTextBoxStyleId;
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "TextBoxStyle";
 lstKeyFldNames.Add("TextBoxStyleId");
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
if (strAttributeName  ==  conTextBoxStyle.TextBoxStyleId)
{
return mstrTextBoxStyleId;
}
else if (strAttributeName  ==  conTextBoxStyle.TextBoxStyleName)
{
return mstrTextBoxStyleName;
}
else if (strAttributeName  ==  conTextBoxStyle.Style)
{
return mstrStyle;
}
else if (strAttributeName  ==  conTextBoxStyle.Runat)
{
return mstrRunat;
}
else if (strAttributeName  ==  conTextBoxStyle.FontSize)
{
return mstrFontSize;
}
else if (strAttributeName  ==  conTextBoxStyle.FontName)
{
return mstrFontName;
}
else if (strAttributeName  ==  conTextBoxStyle.Width)
{
return mintWidth;
}
else if (strAttributeName  ==  conTextBoxStyle.Height)
{
return mintHeight;
}
else if (strAttributeName  ==  conTextBoxStyle.TextMode)
{
return mstrTextMode;
}
else if (strAttributeName  ==  conTextBoxStyle.ReadOnly)
{
return mbolReadOnly;
}
else if (strAttributeName  ==  conTextBoxStyle.StyleZindex)
{
return mintStyleZindex;
}
else if (strAttributeName  ==  conTextBoxStyle.StyleLeft)
{
return mintStyleLeft;
}
else if (strAttributeName  ==  conTextBoxStyle.StylePosition)
{
return mstrStylePosition;
}
else if (strAttributeName  ==  conTextBoxStyle.StyleTop)
{
return mintStyleTop;
}
return null;
}
set
{
if (strAttributeName  ==  conTextBoxStyle.TextBoxStyleId)
{
mstrTextBoxStyleId = value.ToString();
 AddUpdatedFld(conTextBoxStyle.TextBoxStyleId);
}
else if (strAttributeName  ==  conTextBoxStyle.TextBoxStyleName)
{
mstrTextBoxStyleName = value.ToString();
 AddUpdatedFld(conTextBoxStyle.TextBoxStyleName);
}
else if (strAttributeName  ==  conTextBoxStyle.Style)
{
mstrStyle = value.ToString();
 AddUpdatedFld(conTextBoxStyle.Style);
}
else if (strAttributeName  ==  conTextBoxStyle.Runat)
{
mstrRunat = value.ToString();
 AddUpdatedFld(conTextBoxStyle.Runat);
}
else if (strAttributeName  ==  conTextBoxStyle.FontSize)
{
mstrFontSize = value.ToString();
 AddUpdatedFld(conTextBoxStyle.FontSize);
}
else if (strAttributeName  ==  conTextBoxStyle.FontName)
{
mstrFontName = value.ToString();
 AddUpdatedFld(conTextBoxStyle.FontName);
}
else if (strAttributeName  ==  conTextBoxStyle.Width)
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(conTextBoxStyle.Width);
}
else if (strAttributeName  ==  conTextBoxStyle.Height)
{
mintHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(conTextBoxStyle.Height);
}
else if (strAttributeName  ==  conTextBoxStyle.TextMode)
{
mstrTextMode = value.ToString();
 AddUpdatedFld(conTextBoxStyle.TextMode);
}
else if (strAttributeName  ==  conTextBoxStyle.ReadOnly)
{
mbolReadOnly = TransNullToBool(value.ToString());
 AddUpdatedFld(conTextBoxStyle.ReadOnly);
}
else if (strAttributeName  ==  conTextBoxStyle.StyleZindex)
{
mintStyleZindex = TransNullToInt(value.ToString());
 AddUpdatedFld(conTextBoxStyle.StyleZindex);
}
else if (strAttributeName  ==  conTextBoxStyle.StyleLeft)
{
mintStyleLeft = TransNullToInt(value.ToString());
 AddUpdatedFld(conTextBoxStyle.StyleLeft);
}
else if (strAttributeName  ==  conTextBoxStyle.StylePosition)
{
mstrStylePosition = value.ToString();
 AddUpdatedFld(conTextBoxStyle.StylePosition);
}
else if (strAttributeName  ==  conTextBoxStyle.StyleTop)
{
mintStyleTop = TransNullToInt(value.ToString());
 AddUpdatedFld(conTextBoxStyle.StyleTop);
}
}
}
public object this[int intIndex]
{
get
{
if (conTextBoxStyle.TextBoxStyleId  ==  AttributeName[intIndex])
{
return mstrTextBoxStyleId;
}
else if (conTextBoxStyle.TextBoxStyleName  ==  AttributeName[intIndex])
{
return mstrTextBoxStyleName;
}
else if (conTextBoxStyle.Style  ==  AttributeName[intIndex])
{
return mstrStyle;
}
else if (conTextBoxStyle.Runat  ==  AttributeName[intIndex])
{
return mstrRunat;
}
else if (conTextBoxStyle.FontSize  ==  AttributeName[intIndex])
{
return mstrFontSize;
}
else if (conTextBoxStyle.FontName  ==  AttributeName[intIndex])
{
return mstrFontName;
}
else if (conTextBoxStyle.Width  ==  AttributeName[intIndex])
{
return mintWidth;
}
else if (conTextBoxStyle.Height  ==  AttributeName[intIndex])
{
return mintHeight;
}
else if (conTextBoxStyle.TextMode  ==  AttributeName[intIndex])
{
return mstrTextMode;
}
else if (conTextBoxStyle.ReadOnly  ==  AttributeName[intIndex])
{
return mbolReadOnly;
}
else if (conTextBoxStyle.StyleZindex  ==  AttributeName[intIndex])
{
return mintStyleZindex;
}
else if (conTextBoxStyle.StyleLeft  ==  AttributeName[intIndex])
{
return mintStyleLeft;
}
else if (conTextBoxStyle.StylePosition  ==  AttributeName[intIndex])
{
return mstrStylePosition;
}
else if (conTextBoxStyle.StyleTop  ==  AttributeName[intIndex])
{
return mintStyleTop;
}
return null;
}
set
{
if (conTextBoxStyle.TextBoxStyleId  ==  AttributeName[intIndex])
{
mstrTextBoxStyleId = value.ToString();
 AddUpdatedFld(conTextBoxStyle.TextBoxStyleId);
}
else if (conTextBoxStyle.TextBoxStyleName  ==  AttributeName[intIndex])
{
mstrTextBoxStyleName = value.ToString();
 AddUpdatedFld(conTextBoxStyle.TextBoxStyleName);
}
else if (conTextBoxStyle.Style  ==  AttributeName[intIndex])
{
mstrStyle = value.ToString();
 AddUpdatedFld(conTextBoxStyle.Style);
}
else if (conTextBoxStyle.Runat  ==  AttributeName[intIndex])
{
mstrRunat = value.ToString();
 AddUpdatedFld(conTextBoxStyle.Runat);
}
else if (conTextBoxStyle.FontSize  ==  AttributeName[intIndex])
{
mstrFontSize = value.ToString();
 AddUpdatedFld(conTextBoxStyle.FontSize);
}
else if (conTextBoxStyle.FontName  ==  AttributeName[intIndex])
{
mstrFontName = value.ToString();
 AddUpdatedFld(conTextBoxStyle.FontName);
}
else if (conTextBoxStyle.Width  ==  AttributeName[intIndex])
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(conTextBoxStyle.Width);
}
else if (conTextBoxStyle.Height  ==  AttributeName[intIndex])
{
mintHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(conTextBoxStyle.Height);
}
else if (conTextBoxStyle.TextMode  ==  AttributeName[intIndex])
{
mstrTextMode = value.ToString();
 AddUpdatedFld(conTextBoxStyle.TextMode);
}
else if (conTextBoxStyle.ReadOnly  ==  AttributeName[intIndex])
{
mbolReadOnly = TransNullToBool(value.ToString());
 AddUpdatedFld(conTextBoxStyle.ReadOnly);
}
else if (conTextBoxStyle.StyleZindex  ==  AttributeName[intIndex])
{
mintStyleZindex = TransNullToInt(value.ToString());
 AddUpdatedFld(conTextBoxStyle.StyleZindex);
}
else if (conTextBoxStyle.StyleLeft  ==  AttributeName[intIndex])
{
mintStyleLeft = TransNullToInt(value.ToString());
 AddUpdatedFld(conTextBoxStyle.StyleLeft);
}
else if (conTextBoxStyle.StylePosition  ==  AttributeName[intIndex])
{
mstrStylePosition = value.ToString();
 AddUpdatedFld(conTextBoxStyle.StylePosition);
}
else if (conTextBoxStyle.StyleTop  ==  AttributeName[intIndex])
{
mintStyleTop = TransNullToInt(value.ToString());
 AddUpdatedFld(conTextBoxStyle.StyleTop);
}
}
}

/// <summary>
/// TextBoxStyleId(说明:;字段类型:varchar;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TextBoxStyleId
{
get
{
return mstrTextBoxStyleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTextBoxStyleId = value;
}
else
{
 mstrTextBoxStyleId = value;
}
//记录修改过的字段
 AddUpdatedFld(conTextBoxStyle.TextBoxStyleId);
}
}
/// <summary>
/// TextBoxStyleName(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TextBoxStyleName
{
get
{
return mstrTextBoxStyleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTextBoxStyleName = value;
}
else
{
 mstrTextBoxStyleName = value;
}
//记录修改过的字段
 AddUpdatedFld(conTextBoxStyle.TextBoxStyleName);
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
 AddUpdatedFld(conTextBoxStyle.Style);
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
 AddUpdatedFld(conTextBoxStyle.Runat);
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
 AddUpdatedFld(conTextBoxStyle.FontSize);
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
 AddUpdatedFld(conTextBoxStyle.FontName);
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
 AddUpdatedFld(conTextBoxStyle.Width);
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
 AddUpdatedFld(conTextBoxStyle.Height);
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
 AddUpdatedFld(conTextBoxStyle.TextMode);
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
 AddUpdatedFld(conTextBoxStyle.ReadOnly);
}
}
/// <summary>
/// StyleZindex(说明:;字段类型:int;字段长度:4;是否可空:True)
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
 AddUpdatedFld(conTextBoxStyle.StyleZindex);
}
}
/// <summary>
/// StyleLeft(说明:;字段类型:int;字段长度:4;是否可空:True)
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
 AddUpdatedFld(conTextBoxStyle.StyleLeft);
}
}
/// <summary>
/// StylePosition(说明:;字段类型:varchar;字段长度:20;是否可空:True)
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
 AddUpdatedFld(conTextBoxStyle.StylePosition);
}
}
/// <summary>
/// StyleTop(说明:;字段类型:int;字段长度:4;是否可空:True)
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
 AddUpdatedFld(conTextBoxStyle.StyleTop);
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
  return mstrTextBoxStyleId;
 }
 }
}
 /// <summary>
 /// TextBoxStyle(TextBoxStyle)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conTextBoxStyle
{
public new const string _CurrTabName = "TextBoxStyle"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TextBoxStyleId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"TextBoxStyleId", "TextBoxStyleName", "Style", "Runat", "FontSize", "FontName", "Width", "Height", "TextMode", "ReadOnly", "StyleZindex", "StyleLeft", "StylePosition", "StyleTop"};
//以下是属性变量


 /// <summary>
 /// 常量:"TextBoxStyleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextBoxStyleId = "TextBoxStyleId";    //TextBoxStyleId

 /// <summary>
 /// 常量:"TextBoxStyleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextBoxStyleName = "TextBoxStyleName";    //TextBoxStyleName

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
 /// 常量:"StyleZindex"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StyleZindex = "StyleZindex";    //StyleZindex

 /// <summary>
 /// 常量:"StyleLeft"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StyleLeft = "StyleLeft";    //StyleLeft

 /// <summary>
 /// 常量:"StylePosition"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StylePosition = "StylePosition";    //StylePosition

 /// <summary>
 /// 常量:"StyleTop"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StyleTop = "StyleTop";    //StyleTop
}

}