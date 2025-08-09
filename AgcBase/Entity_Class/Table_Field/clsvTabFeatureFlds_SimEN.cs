
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTabFeatureFlds_SimEN
 表名:vTabFeatureFlds_Sim(00050611)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:05:55
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
 /// 表vTabFeatureFlds_Sim的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vTabFeatureFlds_Sim
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
public K_mId_vTabFeatureFlds_Sim(long lngmId)
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
 /// <returns>返回:[K_mId_vTabFeatureFlds_Sim]类型的对象</returns>
public static implicit operator K_mId_vTabFeatureFlds_Sim(long value)
{
return new K_mId_vTabFeatureFlds_Sim(value);
}
}
 /// <summary>
 /// v表功能字段_Sim(vTabFeatureFlds_Sim)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvTabFeatureFlds_SimEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vTabFeatureFlds_Sim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 10;
public static string[] _AttributeName = new string[] {"mId", "TabFeatureId", "FldId", "IsCurrTab", "FieldTypeId", "ValueGivingModeId", "DefaultValue", "OrderNum", "InUse", "PrjId"};

protected long mlngmId;    //mId
protected string mstrTabFeatureId;    //表功能Id
protected string mstrFldId;    //字段Id
protected bool mbolIsCurrTab;    //是否当前表
protected string mstrFieldTypeId;    //字段类型Id
protected string mstrValueGivingModeId;    //给值方式Id
protected string mstrDefaultValue;    //缺省值
protected int mintOrderNum;    //序号
protected bool mbolInUse;    //是否在用
protected string mstrPrjId;    //工程Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvTabFeatureFlds_SimEN()
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
public clsvTabFeatureFlds_SimEN(long lngmId)
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
if (strAttributeName  ==  convTabFeatureFlds_Sim.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convTabFeatureFlds_Sim.TabFeatureId)
{
return mstrTabFeatureId;
}
else if (strAttributeName  ==  convTabFeatureFlds_Sim.FldId)
{
return mstrFldId;
}
else if (strAttributeName  ==  convTabFeatureFlds_Sim.IsCurrTab)
{
return mbolIsCurrTab;
}
else if (strAttributeName  ==  convTabFeatureFlds_Sim.FieldTypeId)
{
return mstrFieldTypeId;
}
else if (strAttributeName  ==  convTabFeatureFlds_Sim.ValueGivingModeId)
{
return mstrValueGivingModeId;
}
else if (strAttributeName  ==  convTabFeatureFlds_Sim.DefaultValue)
{
return mstrDefaultValue;
}
else if (strAttributeName  ==  convTabFeatureFlds_Sim.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convTabFeatureFlds_Sim.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  convTabFeatureFlds_Sim.PrjId)
{
return mstrPrjId;
}
return null;
}
set
{
if (strAttributeName  ==  convTabFeatureFlds_Sim.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convTabFeatureFlds_Sim.mId);
}
else if (strAttributeName  ==  convTabFeatureFlds_Sim.TabFeatureId)
{
mstrTabFeatureId = value.ToString();
 AddUpdatedFld(convTabFeatureFlds_Sim.TabFeatureId);
}
else if (strAttributeName  ==  convTabFeatureFlds_Sim.FldId)
{
mstrFldId = value.ToString();
 AddUpdatedFld(convTabFeatureFlds_Sim.FldId);
}
else if (strAttributeName  ==  convTabFeatureFlds_Sim.IsCurrTab)
{
mbolIsCurrTab = TransNullToBool(value.ToString());
 AddUpdatedFld(convTabFeatureFlds_Sim.IsCurrTab);
}
else if (strAttributeName  ==  convTabFeatureFlds_Sim.FieldTypeId)
{
mstrFieldTypeId = value.ToString();
 AddUpdatedFld(convTabFeatureFlds_Sim.FieldTypeId);
}
else if (strAttributeName  ==  convTabFeatureFlds_Sim.ValueGivingModeId)
{
mstrValueGivingModeId = value.ToString();
 AddUpdatedFld(convTabFeatureFlds_Sim.ValueGivingModeId);
}
else if (strAttributeName  ==  convTabFeatureFlds_Sim.DefaultValue)
{
mstrDefaultValue = value.ToString();
 AddUpdatedFld(convTabFeatureFlds_Sim.DefaultValue);
}
else if (strAttributeName  ==  convTabFeatureFlds_Sim.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convTabFeatureFlds_Sim.OrderNum);
}
else if (strAttributeName  ==  convTabFeatureFlds_Sim.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convTabFeatureFlds_Sim.InUse);
}
else if (strAttributeName  ==  convTabFeatureFlds_Sim.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convTabFeatureFlds_Sim.PrjId);
}
}
}
public object this[int intIndex]
{
get
{
if (convTabFeatureFlds_Sim.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (convTabFeatureFlds_Sim.TabFeatureId  ==  _AttributeName[intIndex])
{
return mstrTabFeatureId;
}
else if (convTabFeatureFlds_Sim.FldId  ==  _AttributeName[intIndex])
{
return mstrFldId;
}
else if (convTabFeatureFlds_Sim.IsCurrTab  ==  _AttributeName[intIndex])
{
return mbolIsCurrTab;
}
else if (convTabFeatureFlds_Sim.FieldTypeId  ==  _AttributeName[intIndex])
{
return mstrFieldTypeId;
}
else if (convTabFeatureFlds_Sim.ValueGivingModeId  ==  _AttributeName[intIndex])
{
return mstrValueGivingModeId;
}
else if (convTabFeatureFlds_Sim.DefaultValue  ==  _AttributeName[intIndex])
{
return mstrDefaultValue;
}
else if (convTabFeatureFlds_Sim.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convTabFeatureFlds_Sim.InUse  ==  _AttributeName[intIndex])
{
return mbolInUse;
}
else if (convTabFeatureFlds_Sim.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
return null;
}
set
{
if (convTabFeatureFlds_Sim.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convTabFeatureFlds_Sim.mId);
}
else if (convTabFeatureFlds_Sim.TabFeatureId  ==  _AttributeName[intIndex])
{
mstrTabFeatureId = value.ToString();
 AddUpdatedFld(convTabFeatureFlds_Sim.TabFeatureId);
}
else if (convTabFeatureFlds_Sim.FldId  ==  _AttributeName[intIndex])
{
mstrFldId = value.ToString();
 AddUpdatedFld(convTabFeatureFlds_Sim.FldId);
}
else if (convTabFeatureFlds_Sim.IsCurrTab  ==  _AttributeName[intIndex])
{
mbolIsCurrTab = TransNullToBool(value.ToString());
 AddUpdatedFld(convTabFeatureFlds_Sim.IsCurrTab);
}
else if (convTabFeatureFlds_Sim.FieldTypeId  ==  _AttributeName[intIndex])
{
mstrFieldTypeId = value.ToString();
 AddUpdatedFld(convTabFeatureFlds_Sim.FieldTypeId);
}
else if (convTabFeatureFlds_Sim.ValueGivingModeId  ==  _AttributeName[intIndex])
{
mstrValueGivingModeId = value.ToString();
 AddUpdatedFld(convTabFeatureFlds_Sim.ValueGivingModeId);
}
else if (convTabFeatureFlds_Sim.DefaultValue  ==  _AttributeName[intIndex])
{
mstrDefaultValue = value.ToString();
 AddUpdatedFld(convTabFeatureFlds_Sim.DefaultValue);
}
else if (convTabFeatureFlds_Sim.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convTabFeatureFlds_Sim.OrderNum);
}
else if (convTabFeatureFlds_Sim.InUse  ==  _AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convTabFeatureFlds_Sim.InUse);
}
else if (convTabFeatureFlds_Sim.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convTabFeatureFlds_Sim.PrjId);
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
 AddUpdatedFld(convTabFeatureFlds_Sim.mId);
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
 AddUpdatedFld(convTabFeatureFlds_Sim.TabFeatureId);
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
 AddUpdatedFld(convTabFeatureFlds_Sim.FldId);
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
 AddUpdatedFld(convTabFeatureFlds_Sim.IsCurrTab);
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
 AddUpdatedFld(convTabFeatureFlds_Sim.FieldTypeId);
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
 AddUpdatedFld(convTabFeatureFlds_Sim.ValueGivingModeId);
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
 AddUpdatedFld(convTabFeatureFlds_Sim.DefaultValue);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(convTabFeatureFlds_Sim.OrderNum);
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
 AddUpdatedFld(convTabFeatureFlds_Sim.InUse);
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
 AddUpdatedFld(convTabFeatureFlds_Sim.PrjId);
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
 /// v表功能字段_Sim(vTabFeatureFlds_Sim)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convTabFeatureFlds_Sim
{
public const string _CurrTabName = "vTabFeatureFlds_Sim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "TabFeatureId", "FldId", "IsCurrTab", "FieldTypeId", "ValueGivingModeId", "DefaultValue", "OrderNum", "InUse", "PrjId"};
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
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id
}

}