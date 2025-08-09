
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjConstraintEN
 表名:vPrjConstraint(00050333)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:00:40
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
 /// 表vPrjConstraint的关键字(PrjConstraintId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PrjConstraintId_vPrjConstraint
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strPrjConstraintId">表关键字</param>
public K_PrjConstraintId_vPrjConstraint(string strPrjConstraintId)
{
if (IsValid(strPrjConstraintId)) Value = strPrjConstraintId;
else
{
Value = null;
}
}
private static bool IsValid(string strPrjConstraintId)
{
if (string.IsNullOrEmpty(strPrjConstraintId) == true) return false;
if (strPrjConstraintId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PrjConstraintId_vPrjConstraint]类型的对象</returns>
public static implicit operator K_PrjConstraintId_vPrjConstraint(string value)
{
return new K_PrjConstraintId_vPrjConstraint(value);
}
}
 /// <summary>
 /// v约束(vPrjConstraint)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvPrjConstraintEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vPrjConstraint"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PrjConstraintId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 16;
public static string[] _AttributeName = new string[] {"PrjConstraintId", "ConstraintName", "PrjId", "PrjName", "TabId", "TabName", "TabCnName", "ConstraintTypeId", "ConstraintTypeName", "ConstraintTypeNameEN", "ConstraintDescription", "CreateUserId", "InUse", "UpdDate", "UpdUser", "Memo"};

protected string mstrPrjConstraintId;    //约束表Id
protected string mstrConstraintName;    //约束名
protected string mstrPrjId;    //工程Id
protected string mstrPrjName;    //工程名称
protected string mstrTabId;    //表ID
protected string mstrTabName;    //表名
protected string mstrTabCnName;    //表中文名
protected string mstrConstraintTypeId;    //约束类型Id
protected string mstrConstraintTypeName;    //约束类型名
protected string mstrConstraintTypeNameEN;    //约束类型英文名
protected string mstrConstraintDescription;    //约束说明
protected string mstrCreateUserId;    //建立用户Id
protected bool mbolInUse;    //是否在用
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvPrjConstraintEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PrjConstraintId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strPrjConstraintId">关键字:约束表Id</param>
public clsvPrjConstraintEN(string strPrjConstraintId)
 {
strPrjConstraintId = strPrjConstraintId.Replace("'", "''");
if (strPrjConstraintId.Length > 8)
{
throw new Exception("在表:vPrjConstraint中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strPrjConstraintId)  ==  true)
{
throw new Exception("在表:vPrjConstraint中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPrjConstraintId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrPrjConstraintId = strPrjConstraintId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PrjConstraintId");
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
if (strAttributeName  ==  convPrjConstraint.PrjConstraintId)
{
return mstrPrjConstraintId;
}
else if (strAttributeName  ==  convPrjConstraint.ConstraintName)
{
return mstrConstraintName;
}
else if (strAttributeName  ==  convPrjConstraint.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convPrjConstraint.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convPrjConstraint.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  convPrjConstraint.TabName)
{
return mstrTabName;
}
else if (strAttributeName  ==  convPrjConstraint.TabCnName)
{
return mstrTabCnName;
}
else if (strAttributeName  ==  convPrjConstraint.ConstraintTypeId)
{
return mstrConstraintTypeId;
}
else if (strAttributeName  ==  convPrjConstraint.ConstraintTypeName)
{
return mstrConstraintTypeName;
}
else if (strAttributeName  ==  convPrjConstraint.ConstraintTypeNameEN)
{
return mstrConstraintTypeNameEN;
}
else if (strAttributeName  ==  convPrjConstraint.ConstraintDescription)
{
return mstrConstraintDescription;
}
else if (strAttributeName  ==  convPrjConstraint.CreateUserId)
{
return mstrCreateUserId;
}
else if (strAttributeName  ==  convPrjConstraint.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  convPrjConstraint.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convPrjConstraint.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convPrjConstraint.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convPrjConstraint.PrjConstraintId)
{
mstrPrjConstraintId = value.ToString();
 AddUpdatedFld(convPrjConstraint.PrjConstraintId);
}
else if (strAttributeName  ==  convPrjConstraint.ConstraintName)
{
mstrConstraintName = value.ToString();
 AddUpdatedFld(convPrjConstraint.ConstraintName);
}
else if (strAttributeName  ==  convPrjConstraint.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convPrjConstraint.PrjId);
}
else if (strAttributeName  ==  convPrjConstraint.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convPrjConstraint.PrjName);
}
else if (strAttributeName  ==  convPrjConstraint.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(convPrjConstraint.TabId);
}
else if (strAttributeName  ==  convPrjConstraint.TabName)
{
mstrTabName = value.ToString();
 AddUpdatedFld(convPrjConstraint.TabName);
}
else if (strAttributeName  ==  convPrjConstraint.TabCnName)
{
mstrTabCnName = value.ToString();
 AddUpdatedFld(convPrjConstraint.TabCnName);
}
else if (strAttributeName  ==  convPrjConstraint.ConstraintTypeId)
{
mstrConstraintTypeId = value.ToString();
 AddUpdatedFld(convPrjConstraint.ConstraintTypeId);
}
else if (strAttributeName  ==  convPrjConstraint.ConstraintTypeName)
{
mstrConstraintTypeName = value.ToString();
 AddUpdatedFld(convPrjConstraint.ConstraintTypeName);
}
else if (strAttributeName  ==  convPrjConstraint.ConstraintTypeNameEN)
{
mstrConstraintTypeNameEN = value.ToString();
 AddUpdatedFld(convPrjConstraint.ConstraintTypeNameEN);
}
else if (strAttributeName  ==  convPrjConstraint.ConstraintDescription)
{
mstrConstraintDescription = value.ToString();
 AddUpdatedFld(convPrjConstraint.ConstraintDescription);
}
else if (strAttributeName  ==  convPrjConstraint.CreateUserId)
{
mstrCreateUserId = value.ToString();
 AddUpdatedFld(convPrjConstraint.CreateUserId);
}
else if (strAttributeName  ==  convPrjConstraint.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjConstraint.InUse);
}
else if (strAttributeName  ==  convPrjConstraint.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convPrjConstraint.UpdDate);
}
else if (strAttributeName  ==  convPrjConstraint.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convPrjConstraint.UpdUser);
}
else if (strAttributeName  ==  convPrjConstraint.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convPrjConstraint.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convPrjConstraint.PrjConstraintId  ==  _AttributeName[intIndex])
{
return mstrPrjConstraintId;
}
else if (convPrjConstraint.ConstraintName  ==  _AttributeName[intIndex])
{
return mstrConstraintName;
}
else if (convPrjConstraint.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convPrjConstraint.PrjName  ==  _AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convPrjConstraint.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (convPrjConstraint.TabName  ==  _AttributeName[intIndex])
{
return mstrTabName;
}
else if (convPrjConstraint.TabCnName  ==  _AttributeName[intIndex])
{
return mstrTabCnName;
}
else if (convPrjConstraint.ConstraintTypeId  ==  _AttributeName[intIndex])
{
return mstrConstraintTypeId;
}
else if (convPrjConstraint.ConstraintTypeName  ==  _AttributeName[intIndex])
{
return mstrConstraintTypeName;
}
else if (convPrjConstraint.ConstraintTypeNameEN  ==  _AttributeName[intIndex])
{
return mstrConstraintTypeNameEN;
}
else if (convPrjConstraint.ConstraintDescription  ==  _AttributeName[intIndex])
{
return mstrConstraintDescription;
}
else if (convPrjConstraint.CreateUserId  ==  _AttributeName[intIndex])
{
return mstrCreateUserId;
}
else if (convPrjConstraint.InUse  ==  _AttributeName[intIndex])
{
return mbolInUse;
}
else if (convPrjConstraint.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convPrjConstraint.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convPrjConstraint.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convPrjConstraint.PrjConstraintId  ==  _AttributeName[intIndex])
{
mstrPrjConstraintId = value.ToString();
 AddUpdatedFld(convPrjConstraint.PrjConstraintId);
}
else if (convPrjConstraint.ConstraintName  ==  _AttributeName[intIndex])
{
mstrConstraintName = value.ToString();
 AddUpdatedFld(convPrjConstraint.ConstraintName);
}
else if (convPrjConstraint.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convPrjConstraint.PrjId);
}
else if (convPrjConstraint.PrjName  ==  _AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convPrjConstraint.PrjName);
}
else if (convPrjConstraint.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(convPrjConstraint.TabId);
}
else if (convPrjConstraint.TabName  ==  _AttributeName[intIndex])
{
mstrTabName = value.ToString();
 AddUpdatedFld(convPrjConstraint.TabName);
}
else if (convPrjConstraint.TabCnName  ==  _AttributeName[intIndex])
{
mstrTabCnName = value.ToString();
 AddUpdatedFld(convPrjConstraint.TabCnName);
}
else if (convPrjConstraint.ConstraintTypeId  ==  _AttributeName[intIndex])
{
mstrConstraintTypeId = value.ToString();
 AddUpdatedFld(convPrjConstraint.ConstraintTypeId);
}
else if (convPrjConstraint.ConstraintTypeName  ==  _AttributeName[intIndex])
{
mstrConstraintTypeName = value.ToString();
 AddUpdatedFld(convPrjConstraint.ConstraintTypeName);
}
else if (convPrjConstraint.ConstraintTypeNameEN  ==  _AttributeName[intIndex])
{
mstrConstraintTypeNameEN = value.ToString();
 AddUpdatedFld(convPrjConstraint.ConstraintTypeNameEN);
}
else if (convPrjConstraint.ConstraintDescription  ==  _AttributeName[intIndex])
{
mstrConstraintDescription = value.ToString();
 AddUpdatedFld(convPrjConstraint.ConstraintDescription);
}
else if (convPrjConstraint.CreateUserId  ==  _AttributeName[intIndex])
{
mstrCreateUserId = value.ToString();
 AddUpdatedFld(convPrjConstraint.CreateUserId);
}
else if (convPrjConstraint.InUse  ==  _AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjConstraint.InUse);
}
else if (convPrjConstraint.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convPrjConstraint.UpdDate);
}
else if (convPrjConstraint.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convPrjConstraint.UpdUser);
}
else if (convPrjConstraint.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convPrjConstraint.Memo);
}
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
 AddUpdatedFld(convPrjConstraint.PrjConstraintId);
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
 AddUpdatedFld(convPrjConstraint.ConstraintName);
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
 AddUpdatedFld(convPrjConstraint.PrjId);
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
 AddUpdatedFld(convPrjConstraint.PrjName);
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
 AddUpdatedFld(convPrjConstraint.TabId);
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
 AddUpdatedFld(convPrjConstraint.TabName);
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
 AddUpdatedFld(convPrjConstraint.TabCnName);
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
 AddUpdatedFld(convPrjConstraint.ConstraintTypeId);
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
 AddUpdatedFld(convPrjConstraint.ConstraintTypeName);
}
}
/// <summary>
/// 约束类型英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ConstraintTypeNameEN
{
get
{
return mstrConstraintTypeNameEN;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrConstraintTypeNameEN = value;
}
else
{
 mstrConstraintTypeNameEN = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjConstraint.ConstraintTypeNameEN);
}
}
/// <summary>
/// 约束说明(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ConstraintDescription
{
get
{
return mstrConstraintDescription;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrConstraintDescription = value;
}
else
{
 mstrConstraintDescription = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjConstraint.ConstraintDescription);
}
}
/// <summary>
/// 建立用户Id(说明:;字段类型:varchar;字段长度:18;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CreateUserId
{
get
{
return mstrCreateUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCreateUserId = value;
}
else
{
 mstrCreateUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjConstraint.CreateUserId);
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
 AddUpdatedFld(convPrjConstraint.InUse);
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
 AddUpdatedFld(convPrjConstraint.UpdDate);
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
 AddUpdatedFld(convPrjConstraint.UpdUser);
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
 AddUpdatedFld(convPrjConstraint.Memo);
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
  return mstrPrjConstraintId;
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
 /// v约束(vPrjConstraint)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convPrjConstraint
{
public const string _CurrTabName = "vPrjConstraint"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PrjConstraintId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"PrjConstraintId", "ConstraintName", "PrjId", "PrjName", "TabId", "TabName", "TabCnName", "ConstraintTypeId", "ConstraintTypeName", "ConstraintTypeNameEN", "ConstraintDescription", "CreateUserId", "InUse", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


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
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"PrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjName = "PrjName";    //工程名称

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
 /// 常量:"ConstraintTypeNameEN"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConstraintTypeNameEN = "ConstraintTypeNameEN";    //约束类型英文名

 /// <summary>
 /// 常量:"ConstraintDescription"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConstraintDescription = "ConstraintDescription";    //约束说明

 /// <summary>
 /// 常量:"CreateUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreateUserId = "CreateUserId";    //建立用户Id

 /// <summary>
 /// 常量:"InUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InUse = "InUse";    //是否在用

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