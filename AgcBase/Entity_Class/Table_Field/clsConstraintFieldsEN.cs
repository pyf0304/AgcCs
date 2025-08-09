
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsConstraintFieldsEN
 表名:ConstraintFields(00050334)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:00:37
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
 /// 表ConstraintFields的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_ConstraintFields
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
public K_mId_ConstraintFields(long lngmId)
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
 /// <returns>返回:[K_mId_ConstraintFields]类型的对象</returns>
public static implicit operator K_mId_ConstraintFields(long value)
{
return new K_mId_ConstraintFields(value);
}
}
 /// <summary>
 /// 约束字段(ConstraintFields)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsConstraintFieldsEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ConstraintFields"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 13;
public static string[] _AttributeName = new string[] {"mId", "PrjConstraintId", "TabId", "FldId", "MaxValue", "MinValue", "SortTypeId", "InUse", "OrderNum", "PrjId", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrPrjConstraintId;    //约束表Id
protected string mstrTabId;    //表ID
protected string mstrFldId;    //字段Id
protected string mstrMaxValue;    //最大值
protected string mstrMinValue;    //最小值
protected string mstrSortTypeId;    //排序类型Id
protected bool mbolInUse;    //是否在用
protected int mintOrderNum;    //序号
protected string mstrPrjId;    //工程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsConstraintFieldsEN()
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
public clsConstraintFieldsEN(long lngmId)
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
if (strAttributeName  ==  conConstraintFields.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conConstraintFields.PrjConstraintId)
{
return mstrPrjConstraintId;
}
else if (strAttributeName  ==  conConstraintFields.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  conConstraintFields.FldId)
{
return mstrFldId;
}
else if (strAttributeName  ==  conConstraintFields.MaxValue)
{
return mstrMaxValue;
}
else if (strAttributeName  ==  conConstraintFields.MinValue)
{
return mstrMinValue;
}
else if (strAttributeName  ==  conConstraintFields.SortTypeId)
{
return mstrSortTypeId;
}
else if (strAttributeName  ==  conConstraintFields.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  conConstraintFields.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conConstraintFields.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conConstraintFields.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conConstraintFields.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conConstraintFields.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conConstraintFields.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conConstraintFields.mId);
}
else if (strAttributeName  ==  conConstraintFields.PrjConstraintId)
{
mstrPrjConstraintId = value.ToString();
 AddUpdatedFld(conConstraintFields.PrjConstraintId);
}
else if (strAttributeName  ==  conConstraintFields.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(conConstraintFields.TabId);
}
else if (strAttributeName  ==  conConstraintFields.FldId)
{
mstrFldId = value.ToString();
 AddUpdatedFld(conConstraintFields.FldId);
}
else if (strAttributeName  ==  conConstraintFields.MaxValue)
{
mstrMaxValue = value.ToString();
 AddUpdatedFld(conConstraintFields.MaxValue);
}
else if (strAttributeName  ==  conConstraintFields.MinValue)
{
mstrMinValue = value.ToString();
 AddUpdatedFld(conConstraintFields.MinValue);
}
else if (strAttributeName  ==  conConstraintFields.SortTypeId)
{
mstrSortTypeId = value.ToString();
 AddUpdatedFld(conConstraintFields.SortTypeId);
}
else if (strAttributeName  ==  conConstraintFields.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conConstraintFields.InUse);
}
else if (strAttributeName  ==  conConstraintFields.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conConstraintFields.OrderNum);
}
else if (strAttributeName  ==  conConstraintFields.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conConstraintFields.PrjId);
}
else if (strAttributeName  ==  conConstraintFields.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conConstraintFields.UpdDate);
}
else if (strAttributeName  ==  conConstraintFields.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conConstraintFields.UpdUser);
}
else if (strAttributeName  ==  conConstraintFields.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conConstraintFields.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conConstraintFields.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (conConstraintFields.PrjConstraintId  ==  _AttributeName[intIndex])
{
return mstrPrjConstraintId;
}
else if (conConstraintFields.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (conConstraintFields.FldId  ==  _AttributeName[intIndex])
{
return mstrFldId;
}
else if (conConstraintFields.MaxValue  ==  _AttributeName[intIndex])
{
return mstrMaxValue;
}
else if (conConstraintFields.MinValue  ==  _AttributeName[intIndex])
{
return mstrMinValue;
}
else if (conConstraintFields.SortTypeId  ==  _AttributeName[intIndex])
{
return mstrSortTypeId;
}
else if (conConstraintFields.InUse  ==  _AttributeName[intIndex])
{
return mbolInUse;
}
else if (conConstraintFields.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conConstraintFields.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conConstraintFields.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conConstraintFields.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conConstraintFields.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conConstraintFields.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conConstraintFields.mId);
}
else if (conConstraintFields.PrjConstraintId  ==  _AttributeName[intIndex])
{
mstrPrjConstraintId = value.ToString();
 AddUpdatedFld(conConstraintFields.PrjConstraintId);
}
else if (conConstraintFields.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(conConstraintFields.TabId);
}
else if (conConstraintFields.FldId  ==  _AttributeName[intIndex])
{
mstrFldId = value.ToString();
 AddUpdatedFld(conConstraintFields.FldId);
}
else if (conConstraintFields.MaxValue  ==  _AttributeName[intIndex])
{
mstrMaxValue = value.ToString();
 AddUpdatedFld(conConstraintFields.MaxValue);
}
else if (conConstraintFields.MinValue  ==  _AttributeName[intIndex])
{
mstrMinValue = value.ToString();
 AddUpdatedFld(conConstraintFields.MinValue);
}
else if (conConstraintFields.SortTypeId  ==  _AttributeName[intIndex])
{
mstrSortTypeId = value.ToString();
 AddUpdatedFld(conConstraintFields.SortTypeId);
}
else if (conConstraintFields.InUse  ==  _AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conConstraintFields.InUse);
}
else if (conConstraintFields.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conConstraintFields.OrderNum);
}
else if (conConstraintFields.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conConstraintFields.PrjId);
}
else if (conConstraintFields.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conConstraintFields.UpdDate);
}
else if (conConstraintFields.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conConstraintFields.UpdUser);
}
else if (conConstraintFields.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conConstraintFields.Memo);
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
 AddUpdatedFld(conConstraintFields.mId);
}
}
/// <summary>
/// 约束表Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjConstraintId
{
get
{
return mstrPrjConstraintId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjConstraintId = value;
}
else
{
 mstrPrjConstraintId = value;
}
//记录修改过的字段
 AddUpdatedFld(conConstraintFields.PrjConstraintId);
}
}
/// <summary>
/// 表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabId
{
get
{
return mstrTabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabId = value;
}
else
{
 mstrTabId = value;
}
//记录修改过的字段
 AddUpdatedFld(conConstraintFields.TabId);
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
 AddUpdatedFld(conConstraintFields.FldId);
}
}
/// <summary>
/// 最大值(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MaxValue
{
get
{
return mstrMaxValue;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMaxValue = value;
}
else
{
 mstrMaxValue = value;
}
//记录修改过的字段
 AddUpdatedFld(conConstraintFields.MaxValue);
}
}
/// <summary>
/// 最小值(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MinValue
{
get
{
return mstrMinValue;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMinValue = value;
}
else
{
 mstrMinValue = value;
}
//记录修改过的字段
 AddUpdatedFld(conConstraintFields.MinValue);
}
}
/// <summary>
/// 排序类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SortTypeId
{
get
{
return mstrSortTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSortTypeId = value;
}
else
{
 mstrSortTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conConstraintFields.SortTypeId);
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
 AddUpdatedFld(conConstraintFields.InUse);
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
 AddUpdatedFld(conConstraintFields.OrderNum);
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
 AddUpdatedFld(conConstraintFields.PrjId);
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
 AddUpdatedFld(conConstraintFields.UpdDate);
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
 AddUpdatedFld(conConstraintFields.UpdUser);
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
 AddUpdatedFld(conConstraintFields.Memo);
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
 /// 约束字段(ConstraintFields)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conConstraintFields
{
public const string _CurrTabName = "ConstraintFields"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "PrjConstraintId", "TabId", "FldId", "MaxValue", "MinValue", "SortTypeId", "InUse", "OrderNum", "PrjId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"PrjConstraintId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjConstraintId = "PrjConstraintId";    //约束表Id

 /// <summary>
 /// 常量:"TabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabId = "TabId";    //表ID

 /// <summary>
 /// 常量:"FldId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldId = "FldId";    //字段Id

 /// <summary>
 /// 常量:"MaxValue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MaxValue = "MaxValue";    //最大值

 /// <summary>
 /// 常量:"MinValue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MinValue = "MinValue";    //最小值

 /// <summary>
 /// 常量:"SortTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SortTypeId = "SortTypeId";    //排序类型Id

 /// <summary>
 /// 常量:"InUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InUse = "InUse";    //是否在用

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

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