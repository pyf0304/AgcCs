
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjConstraintEN
 表名:PrjConstraint(00050331)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:00:19
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
 /// 表PrjConstraint的关键字(PrjConstraintId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PrjConstraintId_PrjConstraint
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
public K_PrjConstraintId_PrjConstraint(string strPrjConstraintId)
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
 /// <returns>返回:[K_PrjConstraintId_PrjConstraint]类型的对象</returns>
public static implicit operator K_PrjConstraintId_PrjConstraint(string value)
{
return new K_PrjConstraintId_PrjConstraint(value);
}
}
 /// <summary>
 /// 约束(PrjConstraint)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsPrjConstraintEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "PrjConstraint"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PrjConstraintId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 14;
public static string[] _AttributeName = new string[] {"PrjConstraintId", "ConstraintName", "PrjId", "TabId", "ConstraintTypeId", "ConstraintDescription", "CreateUserId", "IsNullable", "CheckDate", "ErrMsg", "InUse", "UpdDate", "UpdUser", "Memo"};

protected string mstrPrjConstraintId;    //约束表Id
protected string mstrConstraintName;    //约束名
protected string mstrPrjId;    //工程Id
protected string mstrTabId;    //表ID
protected string mstrConstraintTypeId;    //约束类型Id
protected string mstrConstraintDescription;    //约束说明
protected string mstrCreateUserId;    //建立用户Id
protected bool mbolIsNullable;    //是否可空
protected string mstrCheckDate;    //检查日期
protected string mstrErrMsg;    //错误信息
protected bool mbolInUse;    //是否在用
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsPrjConstraintEN()
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
public clsPrjConstraintEN(string strPrjConstraintId)
 {
strPrjConstraintId = strPrjConstraintId.Replace("'", "''");
if (strPrjConstraintId.Length > 8)
{
throw new Exception("在表:PrjConstraint中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strPrjConstraintId)  ==  true)
{
throw new Exception("在表:PrjConstraint中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  conPrjConstraint.PrjConstraintId)
{
return mstrPrjConstraintId;
}
else if (strAttributeName  ==  conPrjConstraint.ConstraintName)
{
return mstrConstraintName;
}
else if (strAttributeName  ==  conPrjConstraint.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conPrjConstraint.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  conPrjConstraint.ConstraintTypeId)
{
return mstrConstraintTypeId;
}
else if (strAttributeName  ==  conPrjConstraint.ConstraintDescription)
{
return mstrConstraintDescription;
}
else if (strAttributeName  ==  conPrjConstraint.CreateUserId)
{
return mstrCreateUserId;
}
else if (strAttributeName  ==  conPrjConstraint.IsNullable)
{
return mbolIsNullable;
}
else if (strAttributeName  ==  conPrjConstraint.CheckDate)
{
return mstrCheckDate;
}
else if (strAttributeName  ==  conPrjConstraint.ErrMsg)
{
return mstrErrMsg;
}
else if (strAttributeName  ==  conPrjConstraint.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  conPrjConstraint.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conPrjConstraint.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conPrjConstraint.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conPrjConstraint.PrjConstraintId)
{
mstrPrjConstraintId = value.ToString();
 AddUpdatedFld(conPrjConstraint.PrjConstraintId);
}
else if (strAttributeName  ==  conPrjConstraint.ConstraintName)
{
mstrConstraintName = value.ToString();
 AddUpdatedFld(conPrjConstraint.ConstraintName);
}
else if (strAttributeName  ==  conPrjConstraint.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conPrjConstraint.PrjId);
}
else if (strAttributeName  ==  conPrjConstraint.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(conPrjConstraint.TabId);
}
else if (strAttributeName  ==  conPrjConstraint.ConstraintTypeId)
{
mstrConstraintTypeId = value.ToString();
 AddUpdatedFld(conPrjConstraint.ConstraintTypeId);
}
else if (strAttributeName  ==  conPrjConstraint.ConstraintDescription)
{
mstrConstraintDescription = value.ToString();
 AddUpdatedFld(conPrjConstraint.ConstraintDescription);
}
else if (strAttributeName  ==  conPrjConstraint.CreateUserId)
{
mstrCreateUserId = value.ToString();
 AddUpdatedFld(conPrjConstraint.CreateUserId);
}
else if (strAttributeName  ==  conPrjConstraint.IsNullable)
{
mbolIsNullable = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjConstraint.IsNullable);
}
else if (strAttributeName  ==  conPrjConstraint.CheckDate)
{
mstrCheckDate = value.ToString();
 AddUpdatedFld(conPrjConstraint.CheckDate);
}
else if (strAttributeName  ==  conPrjConstraint.ErrMsg)
{
mstrErrMsg = value.ToString();
 AddUpdatedFld(conPrjConstraint.ErrMsg);
}
else if (strAttributeName  ==  conPrjConstraint.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjConstraint.InUse);
}
else if (strAttributeName  ==  conPrjConstraint.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conPrjConstraint.UpdDate);
}
else if (strAttributeName  ==  conPrjConstraint.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conPrjConstraint.UpdUser);
}
else if (strAttributeName  ==  conPrjConstraint.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPrjConstraint.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conPrjConstraint.PrjConstraintId  ==  _AttributeName[intIndex])
{
return mstrPrjConstraintId;
}
else if (conPrjConstraint.ConstraintName  ==  _AttributeName[intIndex])
{
return mstrConstraintName;
}
else if (conPrjConstraint.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conPrjConstraint.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (conPrjConstraint.ConstraintTypeId  ==  _AttributeName[intIndex])
{
return mstrConstraintTypeId;
}
else if (conPrjConstraint.ConstraintDescription  ==  _AttributeName[intIndex])
{
return mstrConstraintDescription;
}
else if (conPrjConstraint.CreateUserId  ==  _AttributeName[intIndex])
{
return mstrCreateUserId;
}
else if (conPrjConstraint.IsNullable  ==  _AttributeName[intIndex])
{
return mbolIsNullable;
}
else if (conPrjConstraint.CheckDate  ==  _AttributeName[intIndex])
{
return mstrCheckDate;
}
else if (conPrjConstraint.ErrMsg  ==  _AttributeName[intIndex])
{
return mstrErrMsg;
}
else if (conPrjConstraint.InUse  ==  _AttributeName[intIndex])
{
return mbolInUse;
}
else if (conPrjConstraint.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conPrjConstraint.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conPrjConstraint.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conPrjConstraint.PrjConstraintId  ==  _AttributeName[intIndex])
{
mstrPrjConstraintId = value.ToString();
 AddUpdatedFld(conPrjConstraint.PrjConstraintId);
}
else if (conPrjConstraint.ConstraintName  ==  _AttributeName[intIndex])
{
mstrConstraintName = value.ToString();
 AddUpdatedFld(conPrjConstraint.ConstraintName);
}
else if (conPrjConstraint.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conPrjConstraint.PrjId);
}
else if (conPrjConstraint.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(conPrjConstraint.TabId);
}
else if (conPrjConstraint.ConstraintTypeId  ==  _AttributeName[intIndex])
{
mstrConstraintTypeId = value.ToString();
 AddUpdatedFld(conPrjConstraint.ConstraintTypeId);
}
else if (conPrjConstraint.ConstraintDescription  ==  _AttributeName[intIndex])
{
mstrConstraintDescription = value.ToString();
 AddUpdatedFld(conPrjConstraint.ConstraintDescription);
}
else if (conPrjConstraint.CreateUserId  ==  _AttributeName[intIndex])
{
mstrCreateUserId = value.ToString();
 AddUpdatedFld(conPrjConstraint.CreateUserId);
}
else if (conPrjConstraint.IsNullable  ==  _AttributeName[intIndex])
{
mbolIsNullable = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjConstraint.IsNullable);
}
else if (conPrjConstraint.CheckDate  ==  _AttributeName[intIndex])
{
mstrCheckDate = value.ToString();
 AddUpdatedFld(conPrjConstraint.CheckDate);
}
else if (conPrjConstraint.ErrMsg  ==  _AttributeName[intIndex])
{
mstrErrMsg = value.ToString();
 AddUpdatedFld(conPrjConstraint.ErrMsg);
}
else if (conPrjConstraint.InUse  ==  _AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjConstraint.InUse);
}
else if (conPrjConstraint.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conPrjConstraint.UpdDate);
}
else if (conPrjConstraint.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conPrjConstraint.UpdUser);
}
else if (conPrjConstraint.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPrjConstraint.Memo);
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
 AddUpdatedFld(conPrjConstraint.PrjConstraintId);
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
 AddUpdatedFld(conPrjConstraint.ConstraintName);
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
 AddUpdatedFld(conPrjConstraint.PrjId);
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
 AddUpdatedFld(conPrjConstraint.TabId);
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
 AddUpdatedFld(conPrjConstraint.ConstraintTypeId);
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
 AddUpdatedFld(conPrjConstraint.ConstraintDescription);
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
 AddUpdatedFld(conPrjConstraint.CreateUserId);
}
}
/// <summary>
/// 是否可空(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsNullable
{
get
{
return mbolIsNullable;
}
set
{
 mbolIsNullable = value;
//记录修改过的字段
 AddUpdatedFld(conPrjConstraint.IsNullable);
}
}
/// <summary>
/// 检查日期(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CheckDate
{
get
{
return mstrCheckDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCheckDate = value;
}
else
{
 mstrCheckDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjConstraint.CheckDate);
}
}
/// <summary>
/// 错误信息(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ErrMsg
{
get
{
return mstrErrMsg;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrErrMsg = value;
}
else
{
 mstrErrMsg = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjConstraint.ErrMsg);
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
 AddUpdatedFld(conPrjConstraint.InUse);
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
 AddUpdatedFld(conPrjConstraint.UpdDate);
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
 AddUpdatedFld(conPrjConstraint.UpdUser);
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
 AddUpdatedFld(conPrjConstraint.Memo);
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
 /// 约束(PrjConstraint)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conPrjConstraint
{
public const string _CurrTabName = "PrjConstraint"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PrjConstraintId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"PrjConstraintId", "ConstraintName", "PrjId", "TabId", "ConstraintTypeId", "ConstraintDescription", "CreateUserId", "IsNullable", "CheckDate", "ErrMsg", "InUse", "UpdDate", "UpdUser", "Memo"};
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
 /// 常量:"TabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabId = "TabId";    //表ID

 /// <summary>
 /// 常量:"ConstraintTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConstraintTypeId = "ConstraintTypeId";    //约束类型Id

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
 /// 常量:"IsNullable"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsNullable = "IsNullable";    //是否可空

 /// <summary>
 /// 常量:"CheckDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CheckDate = "CheckDate";    //检查日期

 /// <summary>
 /// 常量:"ErrMsg"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ErrMsg = "ErrMsg";    //错误信息

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