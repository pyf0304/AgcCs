
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsConstraintTypeEN
 表名:ConstraintType(00050332)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:35:47
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
 /// 表ConstraintType的关键字(ConstraintTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ConstraintTypeId_ConstraintType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strConstraintTypeId">表关键字</param>
public K_ConstraintTypeId_ConstraintType(string strConstraintTypeId)
{
if (IsValid(strConstraintTypeId)) Value = strConstraintTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strConstraintTypeId)
{
if (string.IsNullOrEmpty(strConstraintTypeId) == true) return false;
if (strConstraintTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ConstraintTypeId_ConstraintType]类型的对象</returns>
public static implicit operator K_ConstraintTypeId_ConstraintType(string value)
{
return new K_ConstraintTypeId_ConstraintType(value);
}
}
 /// <summary>
 /// 约束类型(ConstraintType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsConstraintTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ConstraintType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ConstraintTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 7;
public static string[] _AttributeName = new string[] {"ConstraintTypeId", "ConstraintTypeName", "ConstraintTypeNameEN", "InUse", "UpdDate", "UpdUser", "Memo"};

protected string mstrConstraintTypeId;    //约束类型Id
protected string mstrConstraintTypeName;    //约束类型名
protected string mstrConstraintTypeNameEN;    //约束类型英文名
protected bool mbolInUse;    //是否在用
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsConstraintTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ConstraintTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strConstraintTypeId">关键字:约束类型Id</param>
public clsConstraintTypeEN(string strConstraintTypeId)
 {
strConstraintTypeId = strConstraintTypeId.Replace("'", "''");
if (strConstraintTypeId.Length > 2)
{
throw new Exception("在表:ConstraintType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strConstraintTypeId)  ==  true)
{
throw new Exception("在表:ConstraintType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strConstraintTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrConstraintTypeId = strConstraintTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ConstraintTypeId");
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
if (strAttributeName  ==  conConstraintType.ConstraintTypeId)
{
return mstrConstraintTypeId;
}
else if (strAttributeName  ==  conConstraintType.ConstraintTypeName)
{
return mstrConstraintTypeName;
}
else if (strAttributeName  ==  conConstraintType.ConstraintTypeNameEN)
{
return mstrConstraintTypeNameEN;
}
else if (strAttributeName  ==  conConstraintType.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  conConstraintType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conConstraintType.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conConstraintType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conConstraintType.ConstraintTypeId)
{
mstrConstraintTypeId = value.ToString();
 AddUpdatedFld(conConstraintType.ConstraintTypeId);
}
else if (strAttributeName  ==  conConstraintType.ConstraintTypeName)
{
mstrConstraintTypeName = value.ToString();
 AddUpdatedFld(conConstraintType.ConstraintTypeName);
}
else if (strAttributeName  ==  conConstraintType.ConstraintTypeNameEN)
{
mstrConstraintTypeNameEN = value.ToString();
 AddUpdatedFld(conConstraintType.ConstraintTypeNameEN);
}
else if (strAttributeName  ==  conConstraintType.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conConstraintType.InUse);
}
else if (strAttributeName  ==  conConstraintType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conConstraintType.UpdDate);
}
else if (strAttributeName  ==  conConstraintType.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conConstraintType.UpdUser);
}
else if (strAttributeName  ==  conConstraintType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conConstraintType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conConstraintType.ConstraintTypeId  ==  _AttributeName[intIndex])
{
return mstrConstraintTypeId;
}
else if (conConstraintType.ConstraintTypeName  ==  _AttributeName[intIndex])
{
return mstrConstraintTypeName;
}
else if (conConstraintType.ConstraintTypeNameEN  ==  _AttributeName[intIndex])
{
return mstrConstraintTypeNameEN;
}
else if (conConstraintType.InUse  ==  _AttributeName[intIndex])
{
return mbolInUse;
}
else if (conConstraintType.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conConstraintType.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conConstraintType.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conConstraintType.ConstraintTypeId  ==  _AttributeName[intIndex])
{
mstrConstraintTypeId = value.ToString();
 AddUpdatedFld(conConstraintType.ConstraintTypeId);
}
else if (conConstraintType.ConstraintTypeName  ==  _AttributeName[intIndex])
{
mstrConstraintTypeName = value.ToString();
 AddUpdatedFld(conConstraintType.ConstraintTypeName);
}
else if (conConstraintType.ConstraintTypeNameEN  ==  _AttributeName[intIndex])
{
mstrConstraintTypeNameEN = value.ToString();
 AddUpdatedFld(conConstraintType.ConstraintTypeNameEN);
}
else if (conConstraintType.InUse  ==  _AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conConstraintType.InUse);
}
else if (conConstraintType.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conConstraintType.UpdDate);
}
else if (conConstraintType.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conConstraintType.UpdUser);
}
else if (conConstraintType.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conConstraintType.Memo);
}
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
 AddUpdatedFld(conConstraintType.ConstraintTypeId);
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
 AddUpdatedFld(conConstraintType.ConstraintTypeName);
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
 AddUpdatedFld(conConstraintType.ConstraintTypeNameEN);
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
 AddUpdatedFld(conConstraintType.InUse);
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
 AddUpdatedFld(conConstraintType.UpdDate);
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
 AddUpdatedFld(conConstraintType.UpdUser);
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
 AddUpdatedFld(conConstraintType.Memo);
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
  return mstrConstraintTypeId;
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
  return mstrConstraintTypeName;
 }
 }
}
 /// <summary>
 /// 约束类型(ConstraintType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conConstraintType
{
public const string _CurrTabName = "ConstraintType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ConstraintTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"ConstraintTypeId", "ConstraintTypeName", "ConstraintTypeNameEN", "InUse", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


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