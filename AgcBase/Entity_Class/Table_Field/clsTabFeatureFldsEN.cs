
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTabFeatureFldsEN
 表名:TabFeatureFlds(00050455)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:00:43
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
 /// 表TabFeatureFlds的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_TabFeatureFlds
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngmId">表关键字</param>
public K_mId_TabFeatureFlds(long lngmId)
{
if (IsValid(lngmId)) Value = lngmId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngmId)
{
if (lngmId == 0) return false;
if (lngmId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_mId_TabFeatureFlds]类型的对象</returns>
public static implicit operator K_mId_TabFeatureFlds(long value)
{
return new K_mId_TabFeatureFlds(value);
}
}
 /// <summary>
 /// 表功能字段(TabFeatureFlds)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsTabFeatureFldsEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "TabFeatureFlds"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 14;
public static string[] _AttributeName = new string[] {"mId", "TabFeatureId", "FldId", "IsCurrTab", "FieldTypeId", "FuncName", "ValueGivingModeId", "DefaultValue", "PrjId", "OrderNum", "InUse", "UpdUser", "UpdDate", "Memo"};

protected long mlngmId;    //mId
protected string mstrTabFeatureId;    //表功能Id
protected string mstrFldId;    //字段Id
protected bool mbolIsCurrTab;    //是否当前表
protected string mstrFieldTypeId;    //字段类型Id
protected string mstrFuncName;    //函数名
protected string mstrValueGivingModeId;    //给值方式Id
protected string mstrDefaultValue;    //缺省值
protected string mstrPrjId;    //工程Id
protected int? mintOrderNum;    //序号
protected bool mbolInUse;    //是否在用
protected string mstrUpdUser;    //修改者
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsTabFeatureFldsEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:mId</param>
public clsTabFeatureFldsEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
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
if (strAttributeName  ==  conTabFeatureFlds.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conTabFeatureFlds.TabFeatureId)
{
return mstrTabFeatureId;
}
else if (strAttributeName  ==  conTabFeatureFlds.FldId)
{
return mstrFldId;
}
else if (strAttributeName  ==  conTabFeatureFlds.IsCurrTab)
{
return mbolIsCurrTab;
}
else if (strAttributeName  ==  conTabFeatureFlds.FieldTypeId)
{
return mstrFieldTypeId;
}
else if (strAttributeName  ==  conTabFeatureFlds.FuncName)
{
return mstrFuncName;
}
else if (strAttributeName  ==  conTabFeatureFlds.ValueGivingModeId)
{
return mstrValueGivingModeId;
}
else if (strAttributeName  ==  conTabFeatureFlds.DefaultValue)
{
return mstrDefaultValue;
}
else if (strAttributeName  ==  conTabFeatureFlds.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conTabFeatureFlds.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conTabFeatureFlds.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  conTabFeatureFlds.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conTabFeatureFlds.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conTabFeatureFlds.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conTabFeatureFlds.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conTabFeatureFlds.mId);
}
else if (strAttributeName  ==  conTabFeatureFlds.TabFeatureId)
{
mstrTabFeatureId = value.ToString();
 AddUpdatedFld(conTabFeatureFlds.TabFeatureId);
}
else if (strAttributeName  ==  conTabFeatureFlds.FldId)
{
mstrFldId = value.ToString();
 AddUpdatedFld(conTabFeatureFlds.FldId);
}
else if (strAttributeName  ==  conTabFeatureFlds.IsCurrTab)
{
mbolIsCurrTab = TransNullToBool(value.ToString());
 AddUpdatedFld(conTabFeatureFlds.IsCurrTab);
}
else if (strAttributeName  ==  conTabFeatureFlds.FieldTypeId)
{
mstrFieldTypeId = value.ToString();
 AddUpdatedFld(conTabFeatureFlds.FieldTypeId);
}
else if (strAttributeName  ==  conTabFeatureFlds.FuncName)
{
mstrFuncName = value.ToString();
 AddUpdatedFld(conTabFeatureFlds.FuncName);
}
else if (strAttributeName  ==  conTabFeatureFlds.ValueGivingModeId)
{
mstrValueGivingModeId = value.ToString();
 AddUpdatedFld(conTabFeatureFlds.ValueGivingModeId);
}
else if (strAttributeName  ==  conTabFeatureFlds.DefaultValue)
{
mstrDefaultValue = value.ToString();
 AddUpdatedFld(conTabFeatureFlds.DefaultValue);
}
else if (strAttributeName  ==  conTabFeatureFlds.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conTabFeatureFlds.PrjId);
}
else if (strAttributeName  ==  conTabFeatureFlds.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conTabFeatureFlds.OrderNum);
}
else if (strAttributeName  ==  conTabFeatureFlds.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conTabFeatureFlds.InUse);
}
else if (strAttributeName  ==  conTabFeatureFlds.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conTabFeatureFlds.UpdUser);
}
else if (strAttributeName  ==  conTabFeatureFlds.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conTabFeatureFlds.UpdDate);
}
else if (strAttributeName  ==  conTabFeatureFlds.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTabFeatureFlds.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conTabFeatureFlds.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (conTabFeatureFlds.TabFeatureId  ==  _AttributeName[intIndex])
{
return mstrTabFeatureId;
}
else if (conTabFeatureFlds.FldId  ==  _AttributeName[intIndex])
{
return mstrFldId;
}
else if (conTabFeatureFlds.IsCurrTab  ==  _AttributeName[intIndex])
{
return mbolIsCurrTab;
}
else if (conTabFeatureFlds.FieldTypeId  ==  _AttributeName[intIndex])
{
return mstrFieldTypeId;
}
else if (conTabFeatureFlds.FuncName  ==  _AttributeName[intIndex])
{
return mstrFuncName;
}
else if (conTabFeatureFlds.ValueGivingModeId  ==  _AttributeName[intIndex])
{
return mstrValueGivingModeId;
}
else if (conTabFeatureFlds.DefaultValue  ==  _AttributeName[intIndex])
{
return mstrDefaultValue;
}
else if (conTabFeatureFlds.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conTabFeatureFlds.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conTabFeatureFlds.InUse  ==  _AttributeName[intIndex])
{
return mbolInUse;
}
else if (conTabFeatureFlds.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conTabFeatureFlds.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conTabFeatureFlds.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conTabFeatureFlds.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conTabFeatureFlds.mId);
}
else if (conTabFeatureFlds.TabFeatureId  ==  _AttributeName[intIndex])
{
mstrTabFeatureId = value.ToString();
 AddUpdatedFld(conTabFeatureFlds.TabFeatureId);
}
else if (conTabFeatureFlds.FldId  ==  _AttributeName[intIndex])
{
mstrFldId = value.ToString();
 AddUpdatedFld(conTabFeatureFlds.FldId);
}
else if (conTabFeatureFlds.IsCurrTab  ==  _AttributeName[intIndex])
{
mbolIsCurrTab = TransNullToBool(value.ToString());
 AddUpdatedFld(conTabFeatureFlds.IsCurrTab);
}
else if (conTabFeatureFlds.FieldTypeId  ==  _AttributeName[intIndex])
{
mstrFieldTypeId = value.ToString();
 AddUpdatedFld(conTabFeatureFlds.FieldTypeId);
}
else if (conTabFeatureFlds.FuncName  ==  _AttributeName[intIndex])
{
mstrFuncName = value.ToString();
 AddUpdatedFld(conTabFeatureFlds.FuncName);
}
else if (conTabFeatureFlds.ValueGivingModeId  ==  _AttributeName[intIndex])
{
mstrValueGivingModeId = value.ToString();
 AddUpdatedFld(conTabFeatureFlds.ValueGivingModeId);
}
else if (conTabFeatureFlds.DefaultValue  ==  _AttributeName[intIndex])
{
mstrDefaultValue = value.ToString();
 AddUpdatedFld(conTabFeatureFlds.DefaultValue);
}
else if (conTabFeatureFlds.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conTabFeatureFlds.PrjId);
}
else if (conTabFeatureFlds.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conTabFeatureFlds.OrderNum);
}
else if (conTabFeatureFlds.InUse  ==  _AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conTabFeatureFlds.InUse);
}
else if (conTabFeatureFlds.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conTabFeatureFlds.UpdUser);
}
else if (conTabFeatureFlds.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conTabFeatureFlds.UpdDate);
}
else if (conTabFeatureFlds.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTabFeatureFlds.Memo);
}
}
}

/// <summary>
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long mId
{
get
{
return mlngmId;
}
set
{
 mlngmId = value;
//记录修改过的字段
 AddUpdatedFld(conTabFeatureFlds.mId);
}
}
/// <summary>
/// 表功能Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabFeatureId
{
get
{
return mstrTabFeatureId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabFeatureId = value;
}
else
{
 mstrTabFeatureId = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabFeatureFlds.TabFeatureId);
}
}
/// <summary>
/// 字段Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FldId
{
get
{
return mstrFldId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldId = value;
}
else
{
 mstrFldId = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabFeatureFlds.FldId);
}
}
/// <summary>
/// 是否当前表(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsCurrTab
{
get
{
return mbolIsCurrTab;
}
set
{
 mbolIsCurrTab = value;
//记录修改过的字段
 AddUpdatedFld(conTabFeatureFlds.IsCurrTab);
}
}
/// <summary>
/// 字段类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FieldTypeId
{
get
{
return mstrFieldTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFieldTypeId = value;
}
else
{
 mstrFieldTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabFeatureFlds.FieldTypeId);
}
}
/// <summary>
/// 函数名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncName
{
get
{
return mstrFuncName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncName = value;
}
else
{
 mstrFuncName = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabFeatureFlds.FuncName);
}
}
/// <summary>
/// 给值方式Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ValueGivingModeId
{
get
{
return mstrValueGivingModeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrValueGivingModeId = value;
}
else
{
 mstrValueGivingModeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabFeatureFlds.ValueGivingModeId);
}
}
/// <summary>
/// 缺省值(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DefaultValue
{
get
{
return mstrDefaultValue;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDefaultValue = value;
}
else
{
 mstrDefaultValue = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabFeatureFlds.DefaultValue);
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
 AddUpdatedFld(conTabFeatureFlds.PrjId);
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
 AddUpdatedFld(conTabFeatureFlds.OrderNum);
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
 AddUpdatedFld(conTabFeatureFlds.InUse);
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
 AddUpdatedFld(conTabFeatureFlds.UpdUser);
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
 AddUpdatedFld(conTabFeatureFlds.UpdDate);
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
 AddUpdatedFld(conTabFeatureFlds.Memo);
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
  return mlngmId.ToString();
 }
 }
}
 /// <summary>
 /// 表功能字段(TabFeatureFlds)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conTabFeatureFlds
{
public const string _CurrTabName = "TabFeatureFlds"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "TabFeatureId", "FldId", "IsCurrTab", "FieldTypeId", "FuncName", "ValueGivingModeId", "DefaultValue", "PrjId", "OrderNum", "InUse", "UpdUser", "UpdDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"TabFeatureId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabFeatureId = "TabFeatureId";    //表功能Id

 /// <summary>
 /// 常量:"FldId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldId = "FldId";    //字段Id

 /// <summary>
 /// 常量:"IsCurrTab"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsCurrTab = "IsCurrTab";    //是否当前表

 /// <summary>
 /// 常量:"FieldTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FieldTypeId = "FieldTypeId";    //字段类型Id

 /// <summary>
 /// 常量:"FuncName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncName = "FuncName";    //函数名

 /// <summary>
 /// 常量:"ValueGivingModeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ValueGivingModeId = "ValueGivingModeId";    //给值方式Id

 /// <summary>
 /// 常量:"DefaultValue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DefaultValue = "DefaultValue";    //缺省值

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"InUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InUse = "InUse";    //是否在用

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改者

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}