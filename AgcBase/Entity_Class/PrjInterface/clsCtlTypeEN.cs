
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCtlTypeEN
 表名:CtlType(00050058)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:01:57
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
 /// 表CtlType的关键字(CtlTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CtlTypeId_CtlType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strCtlTypeId">表关键字</param>
public K_CtlTypeId_CtlType(string strCtlTypeId)
{
if (IsValid(strCtlTypeId)) Value = strCtlTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strCtlTypeId)
{
if (string.IsNullOrEmpty(strCtlTypeId) == true) return false;
if (strCtlTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_CtlTypeId_CtlType]类型的对象</returns>
public static implicit operator K_CtlTypeId_CtlType(string value)
{
return new K_CtlTypeId_CtlType(value);
}
}
 /// <summary>
 /// 控件类型缩写(CtlType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCtlTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CtlType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "CtlTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 13;
public static string[] _AttributeName = new string[] {"CtlTypeId", "CtlTypeName", "CtlTypeENName", "CtlCnName", "CtlTypeAbbr", "HtmlCtrlTypeName", "IsForApple", "InUse", "IsVisible", "OrderNum", "UpdDate", "UpdUser", "Memo"};

protected string mstrCtlTypeId;    //控件类型号
protected string mstrCtlTypeName;    //控件类型名
protected string mstrCtlTypeENName;    //控件类型英文名
protected string mstrCtlCnName;    //控件类型中文名
protected string mstrCtlTypeAbbr;    //控件类型缩写
protected string mstrHtmlCtrlTypeName;    //HtmlCtrlTypeName
protected bool mbolIsForApple;    //IsForApple
protected bool mbolInUse;    //是否在用
protected bool mbolIsVisible;    //是否显示
protected int? mintOrderNum;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsCtlTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CtlTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strCtlTypeId">关键字:控件类型号</param>
public clsCtlTypeEN(string strCtlTypeId)
 {
strCtlTypeId = strCtlTypeId.Replace("'", "''");
if (strCtlTypeId.Length > 2)
{
throw new Exception("在表:CtlType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strCtlTypeId)  ==  true)
{
throw new Exception("在表:CtlType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCtlTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrCtlTypeId = strCtlTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CtlTypeId");
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
if (strAttributeName  ==  conCtlType.CtlTypeId)
{
return mstrCtlTypeId;
}
else if (strAttributeName  ==  conCtlType.CtlTypeName)
{
return mstrCtlTypeName;
}
else if (strAttributeName  ==  conCtlType.CtlTypeENName)
{
return mstrCtlTypeENName;
}
else if (strAttributeName  ==  conCtlType.CtlCnName)
{
return mstrCtlCnName;
}
else if (strAttributeName  ==  conCtlType.CtlTypeAbbr)
{
return mstrCtlTypeAbbr;
}
else if (strAttributeName  ==  conCtlType.HtmlCtrlTypeName)
{
return mstrHtmlCtrlTypeName;
}
else if (strAttributeName  ==  conCtlType.IsForApple)
{
return mbolIsForApple;
}
else if (strAttributeName  ==  conCtlType.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  conCtlType.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  conCtlType.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conCtlType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conCtlType.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conCtlType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conCtlType.CtlTypeId)
{
mstrCtlTypeId = value.ToString();
 AddUpdatedFld(conCtlType.CtlTypeId);
}
else if (strAttributeName  ==  conCtlType.CtlTypeName)
{
mstrCtlTypeName = value.ToString();
 AddUpdatedFld(conCtlType.CtlTypeName);
}
else if (strAttributeName  ==  conCtlType.CtlTypeENName)
{
mstrCtlTypeENName = value.ToString();
 AddUpdatedFld(conCtlType.CtlTypeENName);
}
else if (strAttributeName  ==  conCtlType.CtlCnName)
{
mstrCtlCnName = value.ToString();
 AddUpdatedFld(conCtlType.CtlCnName);
}
else if (strAttributeName  ==  conCtlType.CtlTypeAbbr)
{
mstrCtlTypeAbbr = value.ToString();
 AddUpdatedFld(conCtlType.CtlTypeAbbr);
}
else if (strAttributeName  ==  conCtlType.HtmlCtrlTypeName)
{
mstrHtmlCtrlTypeName = value.ToString();
 AddUpdatedFld(conCtlType.HtmlCtrlTypeName);
}
else if (strAttributeName  ==  conCtlType.IsForApple)
{
mbolIsForApple = TransNullToBool(value.ToString());
 AddUpdatedFld(conCtlType.IsForApple);
}
else if (strAttributeName  ==  conCtlType.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conCtlType.InUse);
}
else if (strAttributeName  ==  conCtlType.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conCtlType.IsVisible);
}
else if (strAttributeName  ==  conCtlType.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conCtlType.OrderNum);
}
else if (strAttributeName  ==  conCtlType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCtlType.UpdDate);
}
else if (strAttributeName  ==  conCtlType.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conCtlType.UpdUser);
}
else if (strAttributeName  ==  conCtlType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCtlType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conCtlType.CtlTypeId  ==  _AttributeName[intIndex])
{
return mstrCtlTypeId;
}
else if (conCtlType.CtlTypeName  ==  _AttributeName[intIndex])
{
return mstrCtlTypeName;
}
else if (conCtlType.CtlTypeENName  ==  _AttributeName[intIndex])
{
return mstrCtlTypeENName;
}
else if (conCtlType.CtlCnName  ==  _AttributeName[intIndex])
{
return mstrCtlCnName;
}
else if (conCtlType.CtlTypeAbbr  ==  _AttributeName[intIndex])
{
return mstrCtlTypeAbbr;
}
else if (conCtlType.HtmlCtrlTypeName  ==  _AttributeName[intIndex])
{
return mstrHtmlCtrlTypeName;
}
else if (conCtlType.IsForApple  ==  _AttributeName[intIndex])
{
return mbolIsForApple;
}
else if (conCtlType.InUse  ==  _AttributeName[intIndex])
{
return mbolInUse;
}
else if (conCtlType.IsVisible  ==  _AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (conCtlType.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conCtlType.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conCtlType.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conCtlType.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conCtlType.CtlTypeId  ==  _AttributeName[intIndex])
{
mstrCtlTypeId = value.ToString();
 AddUpdatedFld(conCtlType.CtlTypeId);
}
else if (conCtlType.CtlTypeName  ==  _AttributeName[intIndex])
{
mstrCtlTypeName = value.ToString();
 AddUpdatedFld(conCtlType.CtlTypeName);
}
else if (conCtlType.CtlTypeENName  ==  _AttributeName[intIndex])
{
mstrCtlTypeENName = value.ToString();
 AddUpdatedFld(conCtlType.CtlTypeENName);
}
else if (conCtlType.CtlCnName  ==  _AttributeName[intIndex])
{
mstrCtlCnName = value.ToString();
 AddUpdatedFld(conCtlType.CtlCnName);
}
else if (conCtlType.CtlTypeAbbr  ==  _AttributeName[intIndex])
{
mstrCtlTypeAbbr = value.ToString();
 AddUpdatedFld(conCtlType.CtlTypeAbbr);
}
else if (conCtlType.HtmlCtrlTypeName  ==  _AttributeName[intIndex])
{
mstrHtmlCtrlTypeName = value.ToString();
 AddUpdatedFld(conCtlType.HtmlCtrlTypeName);
}
else if (conCtlType.IsForApple  ==  _AttributeName[intIndex])
{
mbolIsForApple = TransNullToBool(value.ToString());
 AddUpdatedFld(conCtlType.IsForApple);
}
else if (conCtlType.InUse  ==  _AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conCtlType.InUse);
}
else if (conCtlType.IsVisible  ==  _AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conCtlType.IsVisible);
}
else if (conCtlType.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conCtlType.OrderNum);
}
else if (conCtlType.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCtlType.UpdDate);
}
else if (conCtlType.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conCtlType.UpdUser);
}
else if (conCtlType.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCtlType.Memo);
}
}
}

/// <summary>
/// 控件类型号(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CtlTypeId
{
get
{
return mstrCtlTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCtlTypeId = value;
}
else
{
 mstrCtlTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCtlType.CtlTypeId);
}
}
/// <summary>
/// 控件类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CtlTypeName
{
get
{
return mstrCtlTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCtlTypeName = value;
}
else
{
 mstrCtlTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conCtlType.CtlTypeName);
}
}
/// <summary>
/// 控件类型英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CtlTypeENName
{
get
{
return mstrCtlTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCtlTypeENName = value;
}
else
{
 mstrCtlTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conCtlType.CtlTypeENName);
}
}
/// <summary>
/// 控件类型中文名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CtlCnName
{
get
{
return mstrCtlCnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCtlCnName = value;
}
else
{
 mstrCtlCnName = value;
}
//记录修改过的字段
 AddUpdatedFld(conCtlType.CtlCnName);
}
}
/// <summary>
/// 控件类型缩写(说明:;字段类型:varchar;字段长度:5;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CtlTypeAbbr
{
get
{
return mstrCtlTypeAbbr;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCtlTypeAbbr = value;
}
else
{
 mstrCtlTypeAbbr = value;
}
//记录修改过的字段
 AddUpdatedFld(conCtlType.CtlTypeAbbr);
}
}
/// <summary>
/// HtmlCtrlTypeName(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string HtmlCtrlTypeName
{
get
{
return mstrHtmlCtrlTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrHtmlCtrlTypeName = value;
}
else
{
 mstrHtmlCtrlTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conCtlType.HtmlCtrlTypeName);
}
}
/// <summary>
/// IsForApple(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsForApple
{
get
{
return mbolIsForApple;
}
set
{
 mbolIsForApple = value;
//记录修改过的字段
 AddUpdatedFld(conCtlType.IsForApple);
}
}
/// <summary>
/// 是否在用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool InUse
{
get
{
return mbolInUse;
}
set
{
 mbolInUse = value;
//记录修改过的字段
 AddUpdatedFld(conCtlType.InUse);
}
}
/// <summary>
/// 是否显示(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsVisible
{
get
{
return mbolIsVisible;
}
set
{
 mbolIsVisible = value;
//记录修改过的字段
 AddUpdatedFld(conCtlType.IsVisible);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(conCtlType.OrderNum);
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
 AddUpdatedFld(conCtlType.UpdDate);
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
 AddUpdatedFld(conCtlType.UpdUser);
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
 AddUpdatedFld(conCtlType.Memo);
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
  return mstrCtlTypeId;
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
  return mstrCtlTypeName;
 }
 }
}
 /// <summary>
 /// 控件类型缩写(CtlType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCtlType
{
public const string _CurrTabName = "CtlType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CtlTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"CtlTypeId", "CtlTypeName", "CtlTypeENName", "CtlCnName", "CtlTypeAbbr", "HtmlCtrlTypeName", "IsForApple", "InUse", "IsVisible", "OrderNum", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"CtlTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CtlTypeId = "CtlTypeId";    //控件类型号

 /// <summary>
 /// 常量:"CtlTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CtlTypeName = "CtlTypeName";    //控件类型名

 /// <summary>
 /// 常量:"CtlTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CtlTypeENName = "CtlTypeENName";    //控件类型英文名

 /// <summary>
 /// 常量:"CtlCnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CtlCnName = "CtlCnName";    //控件类型中文名

 /// <summary>
 /// 常量:"CtlTypeAbbr"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CtlTypeAbbr = "CtlTypeAbbr";    //控件类型缩写

 /// <summary>
 /// 常量:"HtmlCtrlTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string HtmlCtrlTypeName = "HtmlCtrlTypeName";    //HtmlCtrlTypeName

 /// <summary>
 /// 常量:"IsForApple"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsForApple = "IsForApple";    //IsForApple

 /// <summary>
 /// 常量:"InUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InUse = "InUse";    //是否在用

 /// <summary>
 /// 常量:"IsVisible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVisible = "IsVisible";    //是否显示

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

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