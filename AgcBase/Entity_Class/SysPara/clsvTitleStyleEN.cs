
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTitleStyleEN
 表名:vTitleStyle(00050304)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:11:46
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
 /// 表vTitleStyle的关键字(TitleStyleId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TitleStyleId_vTitleStyle
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strTitleStyleId">表关键字</param>
public K_TitleStyleId_vTitleStyle(string strTitleStyleId)
{
if (IsValid(strTitleStyleId)) Value = strTitleStyleId;
else
{
Value = null;
}
}
private static bool IsValid(string strTitleStyleId)
{
if (string.IsNullOrEmpty(strTitleStyleId) == true) return false;
if (strTitleStyleId.Length > 8) return false;
if (strTitleStyleId.IndexOf(' ') >= 0) return false;
if (strTitleStyleId.IndexOf(')') >= 0) return false;
if (strTitleStyleId.IndexOf('(') >= 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_TitleStyleId_vTitleStyle]类型的对象</returns>
public static implicit operator K_TitleStyleId_vTitleStyle(string value)
{
return new K_TitleStyleId_vTitleStyle(value);
}
}
 /// <summary>
 /// v标题模式(vTitleStyle)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvTitleStyleEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vTitleStyle"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TitleStyleId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 14;
public static string[] _AttributeName = new string[] {"TitleStyleId", "TitleTypeName", "TitleStyleName", "PrjId", "TabHeight", "PrjName", "ImgFile", "BackColor", "TabWidth", "ForeColor", "FontSize", "FontName", "IsDefault", "TitleTypeId"};

protected string mstrTitleStyleId;    //标题类型Id
protected string mstrTitleTypeName;    //标题类型
protected string mstrTitleStyleName;    //标题类型名
protected string mstrPrjId;    //工程Id
protected int mintTabHeight;    //表格高度
protected string mstrPrjName;    //工程名称
protected string mstrImgFile;    //图像文件
protected string mstrBackColor;    //背景颜色
protected int mintTabWidth;    //表格宽度
protected string mstrForeColor;    //前景颜色
protected string mstrFontSize;    //字号
protected string mstrFontName;    //字体
protected bool mbolIsDefault;    //是否默认
protected string mstrTitleTypeId;    //标题类型ID

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvTitleStyleEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TitleStyleId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strTitleStyleId">关键字:标题类型Id</param>
public clsvTitleStyleEN(string strTitleStyleId)
 {
strTitleStyleId = strTitleStyleId.Replace("'", "''");
if (strTitleStyleId.Length > 8)
{
throw new Exception("在表:vTitleStyle中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTitleStyleId)  ==  true)
{
throw new Exception("在表:vTitleStyle中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTitleStyleId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrTitleStyleId = strTitleStyleId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TitleStyleId");
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
if (strAttributeName  ==  convTitleStyle.TitleStyleId)
{
return mstrTitleStyleId;
}
else if (strAttributeName  ==  convTitleStyle.TitleTypeName)
{
return mstrTitleTypeName;
}
else if (strAttributeName  ==  convTitleStyle.TitleStyleName)
{
return mstrTitleStyleName;
}
else if (strAttributeName  ==  convTitleStyle.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convTitleStyle.TabHeight)
{
return mintTabHeight;
}
else if (strAttributeName  ==  convTitleStyle.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convTitleStyle.ImgFile)
{
return mstrImgFile;
}
else if (strAttributeName  ==  convTitleStyle.BackColor)
{
return mstrBackColor;
}
else if (strAttributeName  ==  convTitleStyle.TabWidth)
{
return mintTabWidth;
}
else if (strAttributeName  ==  convTitleStyle.ForeColor)
{
return mstrForeColor;
}
else if (strAttributeName  ==  convTitleStyle.FontSize)
{
return mstrFontSize;
}
else if (strAttributeName  ==  convTitleStyle.FontName)
{
return mstrFontName;
}
else if (strAttributeName  ==  convTitleStyle.IsDefault)
{
return mbolIsDefault;
}
else if (strAttributeName  ==  convTitleStyle.TitleTypeId)
{
return mstrTitleTypeId;
}
return null;
}
set
{
if (strAttributeName  ==  convTitleStyle.TitleStyleId)
{
mstrTitleStyleId = value.ToString();
 AddUpdatedFld(convTitleStyle.TitleStyleId);
}
else if (strAttributeName  ==  convTitleStyle.TitleTypeName)
{
mstrTitleTypeName = value.ToString();
 AddUpdatedFld(convTitleStyle.TitleTypeName);
}
else if (strAttributeName  ==  convTitleStyle.TitleStyleName)
{
mstrTitleStyleName = value.ToString();
 AddUpdatedFld(convTitleStyle.TitleStyleName);
}
else if (strAttributeName  ==  convTitleStyle.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convTitleStyle.PrjId);
}
else if (strAttributeName  ==  convTitleStyle.TabHeight)
{
mintTabHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(convTitleStyle.TabHeight);
}
else if (strAttributeName  ==  convTitleStyle.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convTitleStyle.PrjName);
}
else if (strAttributeName  ==  convTitleStyle.ImgFile)
{
mstrImgFile = value.ToString();
 AddUpdatedFld(convTitleStyle.ImgFile);
}
else if (strAttributeName  ==  convTitleStyle.BackColor)
{
mstrBackColor = value.ToString();
 AddUpdatedFld(convTitleStyle.BackColor);
}
else if (strAttributeName  ==  convTitleStyle.TabWidth)
{
mintTabWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(convTitleStyle.TabWidth);
}
else if (strAttributeName  ==  convTitleStyle.ForeColor)
{
mstrForeColor = value.ToString();
 AddUpdatedFld(convTitleStyle.ForeColor);
}
else if (strAttributeName  ==  convTitleStyle.FontSize)
{
mstrFontSize = value.ToString();
 AddUpdatedFld(convTitleStyle.FontSize);
}
else if (strAttributeName  ==  convTitleStyle.FontName)
{
mstrFontName = value.ToString();
 AddUpdatedFld(convTitleStyle.FontName);
}
else if (strAttributeName  ==  convTitleStyle.IsDefault)
{
mbolIsDefault = TransNullToBool(value.ToString());
 AddUpdatedFld(convTitleStyle.IsDefault);
}
else if (strAttributeName  ==  convTitleStyle.TitleTypeId)
{
mstrTitleTypeId = value.ToString();
 AddUpdatedFld(convTitleStyle.TitleTypeId);
}
}
}
public object this[int intIndex]
{
get
{
if (convTitleStyle.TitleStyleId  ==  _AttributeName[intIndex])
{
return mstrTitleStyleId;
}
else if (convTitleStyle.TitleTypeName  ==  _AttributeName[intIndex])
{
return mstrTitleTypeName;
}
else if (convTitleStyle.TitleStyleName  ==  _AttributeName[intIndex])
{
return mstrTitleStyleName;
}
else if (convTitleStyle.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convTitleStyle.TabHeight  ==  _AttributeName[intIndex])
{
return mintTabHeight;
}
else if (convTitleStyle.PrjName  ==  _AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convTitleStyle.ImgFile  ==  _AttributeName[intIndex])
{
return mstrImgFile;
}
else if (convTitleStyle.BackColor  ==  _AttributeName[intIndex])
{
return mstrBackColor;
}
else if (convTitleStyle.TabWidth  ==  _AttributeName[intIndex])
{
return mintTabWidth;
}
else if (convTitleStyle.ForeColor  ==  _AttributeName[intIndex])
{
return mstrForeColor;
}
else if (convTitleStyle.FontSize  ==  _AttributeName[intIndex])
{
return mstrFontSize;
}
else if (convTitleStyle.FontName  ==  _AttributeName[intIndex])
{
return mstrFontName;
}
else if (convTitleStyle.IsDefault  ==  _AttributeName[intIndex])
{
return mbolIsDefault;
}
else if (convTitleStyle.TitleTypeId  ==  _AttributeName[intIndex])
{
return mstrTitleTypeId;
}
return null;
}
set
{
if (convTitleStyle.TitleStyleId  ==  _AttributeName[intIndex])
{
mstrTitleStyleId = value.ToString();
 AddUpdatedFld(convTitleStyle.TitleStyleId);
}
else if (convTitleStyle.TitleTypeName  ==  _AttributeName[intIndex])
{
mstrTitleTypeName = value.ToString();
 AddUpdatedFld(convTitleStyle.TitleTypeName);
}
else if (convTitleStyle.TitleStyleName  ==  _AttributeName[intIndex])
{
mstrTitleStyleName = value.ToString();
 AddUpdatedFld(convTitleStyle.TitleStyleName);
}
else if (convTitleStyle.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convTitleStyle.PrjId);
}
else if (convTitleStyle.TabHeight  ==  _AttributeName[intIndex])
{
mintTabHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(convTitleStyle.TabHeight);
}
else if (convTitleStyle.PrjName  ==  _AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convTitleStyle.PrjName);
}
else if (convTitleStyle.ImgFile  ==  _AttributeName[intIndex])
{
mstrImgFile = value.ToString();
 AddUpdatedFld(convTitleStyle.ImgFile);
}
else if (convTitleStyle.BackColor  ==  _AttributeName[intIndex])
{
mstrBackColor = value.ToString();
 AddUpdatedFld(convTitleStyle.BackColor);
}
else if (convTitleStyle.TabWidth  ==  _AttributeName[intIndex])
{
mintTabWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(convTitleStyle.TabWidth);
}
else if (convTitleStyle.ForeColor  ==  _AttributeName[intIndex])
{
mstrForeColor = value.ToString();
 AddUpdatedFld(convTitleStyle.ForeColor);
}
else if (convTitleStyle.FontSize  ==  _AttributeName[intIndex])
{
mstrFontSize = value.ToString();
 AddUpdatedFld(convTitleStyle.FontSize);
}
else if (convTitleStyle.FontName  ==  _AttributeName[intIndex])
{
mstrFontName = value.ToString();
 AddUpdatedFld(convTitleStyle.FontName);
}
else if (convTitleStyle.IsDefault  ==  _AttributeName[intIndex])
{
mbolIsDefault = TransNullToBool(value.ToString());
 AddUpdatedFld(convTitleStyle.IsDefault);
}
else if (convTitleStyle.TitleTypeId  ==  _AttributeName[intIndex])
{
mstrTitleTypeId = value.ToString();
 AddUpdatedFld(convTitleStyle.TitleTypeId);
}
}
}

/// <summary>
/// 标题类型Id(说明:;字段类型:varchar;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TitleStyleId
{
get
{
return mstrTitleStyleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTitleStyleId = value;
}
else
{
 mstrTitleStyleId = value;
}
//记录修改过的字段
 AddUpdatedFld(convTitleStyle.TitleStyleId);
}
}
/// <summary>
/// 标题类型(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TitleTypeName
{
get
{
return mstrTitleTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTitleTypeName = value;
}
else
{
 mstrTitleTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTitleStyle.TitleTypeName);
}
}
/// <summary>
/// 标题类型名(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TitleStyleName
{
get
{
return mstrTitleStyleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTitleStyleName = value;
}
else
{
 mstrTitleStyleName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTitleStyle.TitleStyleName);
}
}
/// <summary>
/// 工程Id(说明:;字段类型:char;字段长度:4;是否可空:False)
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
 AddUpdatedFld(convTitleStyle.PrjId);
}
}
/// <summary>
/// 表格高度(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int TabHeight
{
get
{
return mintTabHeight;
}
set
{
 mintTabHeight = value;
//记录修改过的字段
 AddUpdatedFld(convTitleStyle.TabHeight);
}
}
/// <summary>
/// 工程名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjName
{
get
{
return mstrPrjName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjName = value;
}
else
{
 mstrPrjName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTitleStyle.PrjName);
}
}
/// <summary>
/// 图像文件(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ImgFile
{
get
{
return mstrImgFile;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrImgFile = value;
}
else
{
 mstrImgFile = value;
}
//记录修改过的字段
 AddUpdatedFld(convTitleStyle.ImgFile);
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
 AddUpdatedFld(convTitleStyle.BackColor);
}
}
/// <summary>
/// 表格宽度(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int TabWidth
{
get
{
return mintTabWidth;
}
set
{
 mintTabWidth = value;
//记录修改过的字段
 AddUpdatedFld(convTitleStyle.TabWidth);
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
 AddUpdatedFld(convTitleStyle.ForeColor);
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
 AddUpdatedFld(convTitleStyle.FontSize);
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
 AddUpdatedFld(convTitleStyle.FontName);
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
 AddUpdatedFld(convTitleStyle.IsDefault);
}
}
/// <summary>
/// 标题类型ID(说明:;字段类型:varchar;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TitleTypeId
{
get
{
return mstrTitleTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTitleTypeId = value;
}
else
{
 mstrTitleTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convTitleStyle.TitleTypeId);
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
  return mstrTitleStyleId;
 }
 }
}
 /// <summary>
 /// v标题模式(vTitleStyle)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convTitleStyle
{
public const string _CurrTabName = "vTitleStyle"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TitleStyleId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"TitleStyleId", "TitleTypeName", "TitleStyleName", "PrjId", "TabHeight", "PrjName", "ImgFile", "BackColor", "TabWidth", "ForeColor", "FontSize", "FontName", "IsDefault", "TitleTypeId"};
//以下是属性变量


 /// <summary>
 /// 常量:"TitleStyleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TitleStyleId = "TitleStyleId";    //标题类型Id

 /// <summary>
 /// 常量:"TitleTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TitleTypeName = "TitleTypeName";    //标题类型

 /// <summary>
 /// 常量:"TitleStyleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TitleStyleName = "TitleStyleName";    //标题类型名

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"TabHeight"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabHeight = "TabHeight";    //表格高度

 /// <summary>
 /// 常量:"PrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjName = "PrjName";    //工程名称

 /// <summary>
 /// 常量:"ImgFile"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ImgFile = "ImgFile";    //图像文件

 /// <summary>
 /// 常量:"BackColor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BackColor = "BackColor";    //背景颜色

 /// <summary>
 /// 常量:"TabWidth"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabWidth = "TabWidth";    //表格宽度

 /// <summary>
 /// 常量:"ForeColor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ForeColor = "ForeColor";    //前景颜色

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
 /// 常量:"IsDefault"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDefault = "IsDefault";    //是否默认

 /// <summary>
 /// 常量:"TitleTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TitleTypeId = "TitleTypeId";    //标题类型ID
}

}