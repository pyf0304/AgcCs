
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvConstraintFieldsEN
 表名:vConstraintFields(00050413)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:12:11
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
 /// 表vConstraintFields的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vConstraintFields
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
public K_mId_vConstraintFields(long lngmId)
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
 /// <returns>返回:[K_mId_vConstraintFields]类型的对象</returns>
public static implicit operator K_mId_vConstraintFields(long value)
{
return new K_mId_vConstraintFields(value);
}
}
 /// <summary>
 /// v约束字段(vConstraintFields)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvConstraintFieldsEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vConstraintFields"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 21;
public static string[] _AttributeName = new string[] {"mId", "PrjConstraintId", "ConstraintName", "ConstraintTypeId", "ConstraintTypeName", "TabId", "TabName", "TabCnName", "FldId", "FldName", "FldCnName", "MaxValue", "MinValue", "SortTypeId", "SortTypeName", "InUse", "OrderNum", "PrjId", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrPrjConstraintId;    //约束表Id
protected string mstrConstraintName;    //约束名
protected string mstrConstraintTypeId;    //约束类型Id
protected string mstrConstraintTypeName;    //约束类型名
protected string mstrTabId;    //表ID
protected string mstrTabName;    //表名
protected string mstrTabCnName;    //表中文名
protected string mstrFldId;    //字段Id
protected string mstrFldName;    //字段名
protected string mstrFldCnName;    //字段中文详名
protected string mstrMaxValue;    //最大值
protected string mstrMinValue;    //最小值
protected string mstrSortTypeId;    //排序类型Id
protected string mstrSortTypeName;    //排序类型名称
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
 public clsvConstraintFieldsEN()
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
public clsvConstraintFieldsEN(long lngmId)
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
if (strAttributeName  ==  convConstraintFields.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convConstraintFields.PrjConstraintId)
{
return mstrPrjConstraintId;
}
else if (strAttributeName  ==  convConstraintFields.ConstraintName)
{
return mstrConstraintName;
}
else if (strAttributeName  ==  convConstraintFields.ConstraintTypeId)
{
return mstrConstraintTypeId;
}
else if (strAttributeName  ==  convConstraintFields.ConstraintTypeName)
{
return mstrConstraintTypeName;
}
else if (strAttributeName  ==  convConstraintFields.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  convConstraintFields.TabName)
{
return mstrTabName;
}
else if (strAttributeName  ==  convConstraintFields.TabCnName)
{
return mstrTabCnName;
}
else if (strAttributeName  ==  convConstraintFields.FldId)
{
return mstrFldId;
}
else if (strAttributeName  ==  convConstraintFields.FldName)
{
return mstrFldName;
}
else if (strAttributeName  ==  convConstraintFields.FldCnName)
{
return mstrFldCnName;
}
else if (strAttributeName  ==  convConstraintFields.MaxValue)
{
return mstrMaxValue;
}
else if (strAttributeName  ==  convConstraintFields.MinValue)
{
return mstrMinValue;
}
else if (strAttributeName  ==  convConstraintFields.SortTypeId)
{
return mstrSortTypeId;
}
else if (strAttributeName  ==  convConstraintFields.SortTypeName)
{
return mstrSortTypeName;
}
else if (strAttributeName  ==  convConstraintFields.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  convConstraintFields.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convConstraintFields.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convConstraintFields.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convConstraintFields.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convConstraintFields.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convConstraintFields.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convConstraintFields.mId);
}
else if (strAttributeName  ==  convConstraintFields.PrjConstraintId)
{
mstrPrjConstraintId = value.ToString();
 AddUpdatedFld(convConstraintFields.PrjConstraintId);
}
else if (strAttributeName  ==  convConstraintFields.ConstraintName)
{
mstrConstraintName = value.ToString();
 AddUpdatedFld(convConstraintFields.ConstraintName);
}
else if (strAttributeName  ==  convConstraintFields.ConstraintTypeId)
{
mstrConstraintTypeId = value.ToString();
 AddUpdatedFld(convConstraintFields.ConstraintTypeId);
}
else if (strAttributeName  ==  convConstraintFields.ConstraintTypeName)
{
mstrConstraintTypeName = value.ToString();
 AddUpdatedFld(convConstraintFields.ConstraintTypeName);
}
else if (strAttributeName  ==  convConstraintFields.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(convConstraintFields.TabId);
}
else if (strAttributeName  ==  convConstraintFields.TabName)
{
mstrTabName = value.ToString();
 AddUpdatedFld(convConstraintFields.TabName);
}
else if (strAttributeName  ==  convConstraintFields.TabCnName)
{
mstrTabCnName = value.ToString();
 AddUpdatedFld(convConstraintFields.TabCnName);
}
else if (strAttributeName  ==  convConstraintFields.FldId)
{
mstrFldId = value.ToString();
 AddUpdatedFld(convConstraintFields.FldId);
}
else if (strAttributeName  ==  convConstraintFields.FldName)
{
mstrFldName = value.ToString();
 AddUpdatedFld(convConstraintFields.FldName);
}
else if (strAttributeName  ==  convConstraintFields.FldCnName)
{
mstrFldCnName = value.ToString();
 AddUpdatedFld(convConstraintFields.FldCnName);
}
else if (strAttributeName  ==  convConstraintFields.MaxValue)
{
mstrMaxValue = value.ToString();
 AddUpdatedFld(convConstraintFields.MaxValue);
}
else if (strAttributeName  ==  convConstraintFields.MinValue)
{
mstrMinValue = value.ToString();
 AddUpdatedFld(convConstraintFields.MinValue);
}
else if (strAttributeName  ==  convConstraintFields.SortTypeId)
{
mstrSortTypeId = value.ToString();
 AddUpdatedFld(convConstraintFields.SortTypeId);
}
else if (strAttributeName  ==  convConstraintFields.SortTypeName)
{
mstrSortTypeName = value.ToString();
 AddUpdatedFld(convConstraintFields.SortTypeName);
}
else if (strAttributeName  ==  convConstraintFields.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convConstraintFields.InUse);
}
else if (strAttributeName  ==  convConstraintFields.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convConstraintFields.OrderNum);
}
else if (strAttributeName  ==  convConstraintFields.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convConstraintFields.PrjId);
}
else if (strAttributeName  ==  convConstraintFields.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convConstraintFields.UpdDate);
}
else if (strAttributeName  ==  convConstraintFields.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convConstraintFields.UpdUser);
}
else if (strAttributeName  ==  convConstraintFields.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convConstraintFields.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convConstraintFields.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (convConstraintFields.PrjConstraintId  ==  _AttributeName[intIndex])
{
return mstrPrjConstraintId;
}
else if (convConstraintFields.ConstraintName  ==  _AttributeName[intIndex])
{
return mstrConstraintName;
}
else if (convConstraintFields.ConstraintTypeId  ==  _AttributeName[intIndex])
{
return mstrConstraintTypeId;
}
else if (convConstraintFields.ConstraintTypeName  ==  _AttributeName[intIndex])
{
return mstrConstraintTypeName;
}
else if (convConstraintFields.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (convConstraintFields.TabName  ==  _AttributeName[intIndex])
{
return mstrTabName;
}
else if (convConstraintFields.TabCnName  ==  _AttributeName[intIndex])
{
return mstrTabCnName;
}
else if (convConstraintFields.FldId  ==  _AttributeName[intIndex])
{
return mstrFldId;
}
else if (convConstraintFields.FldName  ==  _AttributeName[intIndex])
{
return mstrFldName;
}
else if (convConstraintFields.FldCnName  ==  _AttributeName[intIndex])
{
return mstrFldCnName;
}
else if (convConstraintFields.MaxValue  ==  _AttributeName[intIndex])
{
return mstrMaxValue;
}
else if (convConstraintFields.MinValue  ==  _AttributeName[intIndex])
{
return mstrMinValue;
}
else if (convConstraintFields.SortTypeId  ==  _AttributeName[intIndex])
{
return mstrSortTypeId;
}
else if (convConstraintFields.SortTypeName  ==  _AttributeName[intIndex])
{
return mstrSortTypeName;
}
else if (convConstraintFields.InUse  ==  _AttributeName[intIndex])
{
return mbolInUse;
}
else if (convConstraintFields.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convConstraintFields.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convConstraintFields.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convConstraintFields.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convConstraintFields.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convConstraintFields.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convConstraintFields.mId);
}
else if (convConstraintFields.PrjConstraintId  ==  _AttributeName[intIndex])
{
mstrPrjConstraintId = value.ToString();
 AddUpdatedFld(convConstraintFields.PrjConstraintId);
}
else if (convConstraintFields.ConstraintName  ==  _AttributeName[intIndex])
{
mstrConstraintName = value.ToString();
 AddUpdatedFld(convConstraintFields.ConstraintName);
}
else if (convConstraintFields.ConstraintTypeId  ==  _AttributeName[intIndex])
{
mstrConstraintTypeId = value.ToString();
 AddUpdatedFld(convConstraintFields.ConstraintTypeId);
}
else if (convConstraintFields.ConstraintTypeName  ==  _AttributeName[intIndex])
{
mstrConstraintTypeName = value.ToString();
 AddUpdatedFld(convConstraintFields.ConstraintTypeName);
}
else if (convConstraintFields.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(convConstraintFields.TabId);
}
else if (convConstraintFields.TabName  ==  _AttributeName[intIndex])
{
mstrTabName = value.ToString();
 AddUpdatedFld(convConstraintFields.TabName);
}
else if (convConstraintFields.TabCnName  ==  _AttributeName[intIndex])
{
mstrTabCnName = value.ToString();
 AddUpdatedFld(convConstraintFields.TabCnName);
}
else if (convConstraintFields.FldId  ==  _AttributeName[intIndex])
{
mstrFldId = value.ToString();
 AddUpdatedFld(convConstraintFields.FldId);
}
else if (convConstraintFields.FldName  ==  _AttributeName[intIndex])
{
mstrFldName = value.ToString();
 AddUpdatedFld(convConstraintFields.FldName);
}
else if (convConstraintFields.FldCnName  ==  _AttributeName[intIndex])
{
mstrFldCnName = value.ToString();
 AddUpdatedFld(convConstraintFields.FldCnName);
}
else if (convConstraintFields.MaxValue  ==  _AttributeName[intIndex])
{
mstrMaxValue = value.ToString();
 AddUpdatedFld(convConstraintFields.MaxValue);
}
else if (convConstraintFields.MinValue  ==  _AttributeName[intIndex])
{
mstrMinValue = value.ToString();
 AddUpdatedFld(convConstraintFields.MinValue);
}
else if (convConstraintFields.SortTypeId  ==  _AttributeName[intIndex])
{
mstrSortTypeId = value.ToString();
 AddUpdatedFld(convConstraintFields.SortTypeId);
}
else if (convConstraintFields.SortTypeName  ==  _AttributeName[intIndex])
{
mstrSortTypeName = value.ToString();
 AddUpdatedFld(convConstraintFields.SortTypeName);
}
else if (convConstraintFields.InUse  ==  _AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convConstraintFields.InUse);
}
else if (convConstraintFields.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convConstraintFields.OrderNum);
}
else if (convConstraintFields.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convConstraintFields.PrjId);
}
else if (convConstraintFields.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convConstraintFields.UpdDate);
}
else if (convConstraintFields.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convConstraintFields.UpdUser);
}
else if (convConstraintFields.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convConstraintFields.Memo);
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
 AddUpdatedFld(convConstraintFields.mId);
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
 AddUpdatedFld(convConstraintFields.PrjConstraintId);
}
}
/// <summary>
/// 约束名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ConstraintName
{
get
{
return mstrConstraintName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrConstraintName = value;
}
else
{
 mstrConstraintName = value;
}
//记录修改过的字段
 AddUpdatedFld(convConstraintFields.ConstraintName);
}
}
/// <summary>
/// 约束类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ConstraintTypeId
{
get
{
return mstrConstraintTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrConstraintTypeId = value;
}
else
{
 mstrConstraintTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convConstraintFields.ConstraintTypeId);
}
}
/// <summary>
/// 约束类型名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ConstraintTypeName
{
get
{
return mstrConstraintTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrConstraintTypeName = value;
}
else
{
 mstrConstraintTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convConstraintFields.ConstraintTypeName);
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
 AddUpdatedFld(convConstraintFields.TabId);
}
}
/// <summary>
/// 表名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabName
{
get
{
return mstrTabName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabName = value;
}
else
{
 mstrTabName = value;
}
//记录修改过的字段
 AddUpdatedFld(convConstraintFields.TabName);
}
}
/// <summary>
/// 表中文名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabCnName
{
get
{
return mstrTabCnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabCnName = value;
}
else
{
 mstrTabCnName = value;
}
//记录修改过的字段
 AddUpdatedFld(convConstraintFields.TabCnName);
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
 AddUpdatedFld(convConstraintFields.FldId);
}
}
/// <summary>
/// 字段名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FldName
{
get
{
return mstrFldName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldName = value;
}
else
{
 mstrFldName = value;
}
//记录修改过的字段
 AddUpdatedFld(convConstraintFields.FldName);
}
}
/// <summary>
/// 字段中文详名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FldCnName
{
get
{
return mstrFldCnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldCnName = value;
}
else
{
 mstrFldCnName = value;
}
//记录修改过的字段
 AddUpdatedFld(convConstraintFields.FldCnName);
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
 AddUpdatedFld(convConstraintFields.MaxValue);
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
 AddUpdatedFld(convConstraintFields.MinValue);
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
 AddUpdatedFld(convConstraintFields.SortTypeId);
}
}
/// <summary>
/// 排序类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SortTypeName
{
get
{
return mstrSortTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSortTypeName = value;
}
else
{
 mstrSortTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convConstraintFields.SortTypeName);
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
 AddUpdatedFld(convConstraintFields.InUse);
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
 AddUpdatedFld(convConstraintFields.OrderNum);
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
 AddUpdatedFld(convConstraintFields.PrjId);
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
 AddUpdatedFld(convConstraintFields.UpdDate);
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
 AddUpdatedFld(convConstraintFields.UpdUser);
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
 AddUpdatedFld(convConstraintFields.Memo);
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

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrConstraintName;
 }
 }
}
 /// <summary>
 /// v约束字段(vConstraintFields)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convConstraintFields
{
public const string _CurrTabName = "vConstraintFields"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "PrjConstraintId", "ConstraintName", "ConstraintTypeId", "ConstraintTypeName", "TabId", "TabName", "TabCnName", "FldId", "FldName", "FldCnName", "MaxValue", "MinValue", "SortTypeId", "SortTypeName", "InUse", "OrderNum", "PrjId", "UpdDate", "UpdUser", "Memo"};
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
 /// 常量:"ConstraintName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConstraintName = "ConstraintName";    //约束名

 /// <summary>
 /// 常量:"ConstraintTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConstraintTypeId = "ConstraintTypeId";    //约束类型Id

 /// <summary>
 /// 常量:"ConstraintTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConstraintTypeName = "ConstraintTypeName";    //约束类型名

 /// <summary>
 /// 常量:"TabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabId = "TabId";    //表ID

 /// <summary>
 /// 常量:"TabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabName = "TabName";    //表名

 /// <summary>
 /// 常量:"TabCnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabCnName = "TabCnName";    //表中文名

 /// <summary>
 /// 常量:"FldId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldId = "FldId";    //字段Id

 /// <summary>
 /// 常量:"FldName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldName = "FldName";    //字段名

 /// <summary>
 /// 常量:"FldCnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldCnName = "FldCnName";    //字段中文详名

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
 /// 常量:"SortTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SortTypeName = "SortTypeName";    //排序类型名称

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