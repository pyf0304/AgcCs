
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTitleStyleEN
 表名:TitleStyle(00050004)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:36:29
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
 /// 表TitleStyle的关键字(TitleStyleId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TitleStyleId_TitleStyle
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
public K_TitleStyleId_TitleStyle(string strTitleStyleId)
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
 /// <returns>返回:[K_TitleStyleId_TitleStyle]类型的对象</returns>
public static implicit operator K_TitleStyleId_TitleStyle(string value)
{
return new K_TitleStyleId_TitleStyle(value);
}
}
 /// <summary>
 /// 标题模式(TitleStyle)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsTitleStyleEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "TitleStyle"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TitleStyleId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 15;
public static string[] _AttributeName = new string[] {"TitleStyleId", "TitleStyleName", "PrjId", "TabHeight", "ImgFile", "BackColor", "TabWidth", "ForeColor", "FontSize", "FontName", "IsDefault", "TitleTypeId", "UpdDate", "UpdUserId", "Memo"};

protected string mstrTitleStyleId;    //标题类型Id
protected string mstrTitleStyleName;    //标题类型名
protected string mstrPrjId;    //工程Id
protected int mintTabHeight;    //表格高度
protected string mstrImgFile;    //图像文件
protected string mstrBackColor;    //背景颜色
protected int mintTabWidth;    //表格宽度
protected string mstrForeColor;    //前景颜色
protected string mstrFontSize;    //字号
protected string mstrFontName;    //字体
protected bool mbolIsDefault;    //是否默认
protected string mstrTitleTypeId;    //标题类型ID
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsTitleStyleEN()
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
public clsTitleStyleEN(string strTitleStyleId)
 {
strTitleStyleId = strTitleStyleId.Replace("'", "''");
if (strTitleStyleId.Length > 8)
{
throw new Exception("在表:TitleStyle中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTitleStyleId)  ==  true)
{
throw new Exception("在表:TitleStyle中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  conTitleStyle.TitleStyleId)
{
return mstrTitleStyleId;
}
else if (strAttributeName  ==  conTitleStyle.TitleStyleName)
{
return mstrTitleStyleName;
}
else if (strAttributeName  ==  conTitleStyle.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conTitleStyle.TabHeight)
{
return mintTabHeight;
}
else if (strAttributeName  ==  conTitleStyle.ImgFile)
{
return mstrImgFile;
}
else if (strAttributeName  ==  conTitleStyle.BackColor)
{
return mstrBackColor;
}
else if (strAttributeName  ==  conTitleStyle.TabWidth)
{
return mintTabWidth;
}
else if (strAttributeName  ==  conTitleStyle.ForeColor)
{
return mstrForeColor;
}
else if (strAttributeName  ==  conTitleStyle.FontSize)
{
return mstrFontSize;
}
else if (strAttributeName  ==  conTitleStyle.FontName)
{
return mstrFontName;
}
else if (strAttributeName  ==  conTitleStyle.IsDefault)
{
return mbolIsDefault;
}
else if (strAttributeName  ==  conTitleStyle.TitleTypeId)
{
return mstrTitleTypeId;
}
else if (strAttributeName  ==  conTitleStyle.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conTitleStyle.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conTitleStyle.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conTitleStyle.TitleStyleId)
{
mstrTitleStyleId = value.ToString();
 AddUpdatedFld(conTitleStyle.TitleStyleId);
}
else if (strAttributeName  ==  conTitleStyle.TitleStyleName)
{
mstrTitleStyleName = value.ToString();
 AddUpdatedFld(conTitleStyle.TitleStyleName);
}
else if (strAttributeName  ==  conTitleStyle.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conTitleStyle.PrjId);
}
else if (strAttributeName  ==  conTitleStyle.TabHeight)
{
mintTabHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(conTitleStyle.TabHeight);
}
else if (strAttributeName  ==  conTitleStyle.ImgFile)
{
mstrImgFile = value.ToString();
 AddUpdatedFld(conTitleStyle.ImgFile);
}
else if (strAttributeName  ==  conTitleStyle.BackColor)
{
mstrBackColor = value.ToString();
 AddUpdatedFld(conTitleStyle.BackColor);
}
else if (strAttributeName  ==  conTitleStyle.TabWidth)
{
mintTabWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(conTitleStyle.TabWidth);
}
else if (strAttributeName  ==  conTitleStyle.ForeColor)
{
mstrForeColor = value.ToString();
 AddUpdatedFld(conTitleStyle.ForeColor);
}
else if (strAttributeName  ==  conTitleStyle.FontSize)
{
mstrFontSize = value.ToString();
 AddUpdatedFld(conTitleStyle.FontSize);
}
else if (strAttributeName  ==  conTitleStyle.FontName)
{
mstrFontName = value.ToString();
 AddUpdatedFld(conTitleStyle.FontName);
}
else if (strAttributeName  ==  conTitleStyle.IsDefault)
{
mbolIsDefault = TransNullToBool(value.ToString());
 AddUpdatedFld(conTitleStyle.IsDefault);
}
else if (strAttributeName  ==  conTitleStyle.TitleTypeId)
{
mstrTitleTypeId = value.ToString();
 AddUpdatedFld(conTitleStyle.TitleTypeId);
}
else if (strAttributeName  ==  conTitleStyle.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conTitleStyle.UpdDate);
}
else if (strAttributeName  ==  conTitleStyle.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conTitleStyle.UpdUserId);
}
else if (strAttributeName  ==  conTitleStyle.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTitleStyle.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conTitleStyle.TitleStyleId  ==  _AttributeName[intIndex])
{
return mstrTitleStyleId;
}
else if (conTitleStyle.TitleStyleName  ==  _AttributeName[intIndex])
{
return mstrTitleStyleName;
}
else if (conTitleStyle.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conTitleStyle.TabHeight  ==  _AttributeName[intIndex])
{
return mintTabHeight;
}
else if (conTitleStyle.ImgFile  ==  _AttributeName[intIndex])
{
return mstrImgFile;
}
else if (conTitleStyle.BackColor  ==  _AttributeName[intIndex])
{
return mstrBackColor;
}
else if (conTitleStyle.TabWidth  ==  _AttributeName[intIndex])
{
return mintTabWidth;
}
else if (conTitleStyle.ForeColor  ==  _AttributeName[intIndex])
{
return mstrForeColor;
}
else if (conTitleStyle.FontSize  ==  _AttributeName[intIndex])
{
return mstrFontSize;
}
else if (conTitleStyle.FontName  ==  _AttributeName[intIndex])
{
return mstrFontName;
}
else if (conTitleStyle.IsDefault  ==  _AttributeName[intIndex])
{
return mbolIsDefault;
}
else if (conTitleStyle.TitleTypeId  ==  _AttributeName[intIndex])
{
return mstrTitleTypeId;
}
else if (conTitleStyle.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conTitleStyle.UpdUserId  ==  _AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conTitleStyle.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conTitleStyle.TitleStyleId  ==  _AttributeName[intIndex])
{
mstrTitleStyleId = value.ToString();
 AddUpdatedFld(conTitleStyle.TitleStyleId);
}
else if (conTitleStyle.TitleStyleName  ==  _AttributeName[intIndex])
{
mstrTitleStyleName = value.ToString();
 AddUpdatedFld(conTitleStyle.TitleStyleName);
}
else if (conTitleStyle.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conTitleStyle.PrjId);
}
else if (conTitleStyle.TabHeight  ==  _AttributeName[intIndex])
{
mintTabHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(conTitleStyle.TabHeight);
}
else if (conTitleStyle.ImgFile  ==  _AttributeName[intIndex])
{
mstrImgFile = value.ToString();
 AddUpdatedFld(conTitleStyle.ImgFile);
}
else if (conTitleStyle.BackColor  ==  _AttributeName[intIndex])
{
mstrBackColor = value.ToString();
 AddUpdatedFld(conTitleStyle.BackColor);
}
else if (conTitleStyle.TabWidth  ==  _AttributeName[intIndex])
{
mintTabWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(conTitleStyle.TabWidth);
}
else if (conTitleStyle.ForeColor  ==  _AttributeName[intIndex])
{
mstrForeColor = value.ToString();
 AddUpdatedFld(conTitleStyle.ForeColor);
}
else if (conTitleStyle.FontSize  ==  _AttributeName[intIndex])
{
mstrFontSize = value.ToString();
 AddUpdatedFld(conTitleStyle.FontSize);
}
else if (conTitleStyle.FontName  ==  _AttributeName[intIndex])
{
mstrFontName = value.ToString();
 AddUpdatedFld(conTitleStyle.FontName);
}
else if (conTitleStyle.IsDefault  ==  _AttributeName[intIndex])
{
mbolIsDefault = TransNullToBool(value.ToString());
 AddUpdatedFld(conTitleStyle.IsDefault);
}
else if (conTitleStyle.TitleTypeId  ==  _AttributeName[intIndex])
{
mstrTitleTypeId = value.ToString();
 AddUpdatedFld(conTitleStyle.TitleTypeId);
}
else if (conTitleStyle.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conTitleStyle.UpdDate);
}
else if (conTitleStyle.UpdUserId  ==  _AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conTitleStyle.UpdUserId);
}
else if (conTitleStyle.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTitleStyle.Memo);
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
 AddUpdatedFld(conTitleStyle.TitleStyleId);
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
 AddUpdatedFld(conTitleStyle.TitleStyleName);
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
 AddUpdatedFld(conTitleStyle.PrjId);
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
 AddUpdatedFld(conTitleStyle.TabHeight);
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
 AddUpdatedFld(conTitleStyle.ImgFile);
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
 AddUpdatedFld(conTitleStyle.BackColor);
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
 AddUpdatedFld(conTitleStyle.TabWidth);
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
 AddUpdatedFld(conTitleStyle.ForeColor);
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
 AddUpdatedFld(conTitleStyle.FontSize);
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
 AddUpdatedFld(conTitleStyle.FontName);
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
 AddUpdatedFld(conTitleStyle.IsDefault);
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
 AddUpdatedFld(conTitleStyle.TitleTypeId);
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
 AddUpdatedFld(conTitleStyle.UpdDate);
}
}
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUserId
{
get
{
return mstrUpdUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUserId = value;
}
else
{
 mstrUpdUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conTitleStyle.UpdUserId);
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
 AddUpdatedFld(conTitleStyle.Memo);
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

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrTitleStyleName;
 }
 }
}
 /// <summary>
 /// 标题模式(TitleStyle)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conTitleStyle
{
public const string _CurrTabName = "TitleStyle"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TitleStyleId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"TitleStyleId", "TitleStyleName", "PrjId", "TabHeight", "ImgFile", "BackColor", "TabWidth", "ForeColor", "FontSize", "FontName", "IsDefault", "TitleTypeId", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"TitleStyleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TitleStyleId = "TitleStyleId";    //标题类型Id

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

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}