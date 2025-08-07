
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvProjectsEN
 表名:vProjects(00050167)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:47:30
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:工程管理(PrjManage)
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
 /// 表vProjects的关键字(PrjId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PrjId_vProjects
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strPrjId">表关键字</param>
public K_PrjId_vProjects(string strPrjId)
{
if (IsValid(strPrjId)) Value = strPrjId;
else
{
Value = null;
}
}
private static bool IsValid(string strPrjId)
{
if (string.IsNullOrEmpty(strPrjId) == true) return false;
if (strPrjId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PrjId_vProjects]类型的对象</returns>
public static implicit operator K_PrjId_vProjects(string value)
{
return new K_PrjId_vProjects(value);
}
}
 /// <summary>
 /// v工程(vProjects)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvProjectsEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vProjects"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PrjId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 16;
public static string[] _AttributeName = new string[] {"PrjId", "PrjName", "PrjDomain", "IsoPrjName", "JavaPackageName", "IsRelaDataBase", "SoftStructureId", "SoftStructureName", "ApplicationTypeId", "ApplicationTypeName", "UseStateId", "UseStateName", "IsSupportMvc", "UserId", "UpdDate", "Memo"};

protected string mstrPrjId;    //工程Id
protected string mstrPrjName;    //工程名称
protected string mstrPrjDomain;    //域/包名
protected string mstrIsoPrjName;    //ISO工程名
protected string mstrJavaPackageName;    //Java包名
protected bool mbolIsRelaDataBase;    //是否关联数据库
protected string mstrSoftStructureId;    //架构ID
protected string mstrSoftStructureName;    //架构名称
protected int mintApplicationTypeId;    //应用程序类型ID
protected string mstrApplicationTypeName;    //应用程序类型名称
protected string mstrUseStateId;    //使用状态Id
protected string mstrUseStateName;    //使用状态名称
protected bool mbolIsSupportMvc;    //是否支持Mvc
protected string mstrUserId;    //用户Id
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvProjectsEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PrjId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strPrjId">关键字:工程Id</param>
public clsvProjectsEN(string strPrjId)
 {
strPrjId = strPrjId.Replace("'", "''");
if (strPrjId.Length > 4)
{
throw new Exception("在表:vProjects中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strPrjId)  ==  true)
{
throw new Exception("在表:vProjects中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPrjId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrPrjId = strPrjId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PrjId");
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
if (strAttributeName  ==  convProjects.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convProjects.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convProjects.PrjDomain)
{
return mstrPrjDomain;
}
else if (strAttributeName  ==  convProjects.IsoPrjName)
{
return mstrIsoPrjName;
}
else if (strAttributeName  ==  convProjects.JavaPackageName)
{
return mstrJavaPackageName;
}
else if (strAttributeName  ==  convProjects.IsRelaDataBase)
{
return mbolIsRelaDataBase;
}
else if (strAttributeName  ==  convProjects.SoftStructureId)
{
return mstrSoftStructureId;
}
else if (strAttributeName  ==  convProjects.SoftStructureName)
{
return mstrSoftStructureName;
}
else if (strAttributeName  ==  convProjects.ApplicationTypeId)
{
return mintApplicationTypeId;
}
else if (strAttributeName  ==  convProjects.ApplicationTypeName)
{
return mstrApplicationTypeName;
}
else if (strAttributeName  ==  convProjects.UseStateId)
{
return mstrUseStateId;
}
else if (strAttributeName  ==  convProjects.UseStateName)
{
return mstrUseStateName;
}
else if (strAttributeName  ==  convProjects.IsSupportMvc)
{
return mbolIsSupportMvc;
}
else if (strAttributeName  ==  convProjects.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convProjects.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convProjects.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convProjects.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convProjects.PrjId);
}
else if (strAttributeName  ==  convProjects.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convProjects.PrjName);
}
else if (strAttributeName  ==  convProjects.PrjDomain)
{
mstrPrjDomain = value.ToString();
 AddUpdatedFld(convProjects.PrjDomain);
}
else if (strAttributeName  ==  convProjects.IsoPrjName)
{
mstrIsoPrjName = value.ToString();
 AddUpdatedFld(convProjects.IsoPrjName);
}
else if (strAttributeName  ==  convProjects.JavaPackageName)
{
mstrJavaPackageName = value.ToString();
 AddUpdatedFld(convProjects.JavaPackageName);
}
else if (strAttributeName  ==  convProjects.IsRelaDataBase)
{
mbolIsRelaDataBase = TransNullToBool(value.ToString());
 AddUpdatedFld(convProjects.IsRelaDataBase);
}
else if (strAttributeName  ==  convProjects.SoftStructureId)
{
mstrSoftStructureId = value.ToString();
 AddUpdatedFld(convProjects.SoftStructureId);
}
else if (strAttributeName  ==  convProjects.SoftStructureName)
{
mstrSoftStructureName = value.ToString();
 AddUpdatedFld(convProjects.SoftStructureName);
}
else if (strAttributeName  ==  convProjects.ApplicationTypeId)
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convProjects.ApplicationTypeId);
}
else if (strAttributeName  ==  convProjects.ApplicationTypeName)
{
mstrApplicationTypeName = value.ToString();
 AddUpdatedFld(convProjects.ApplicationTypeName);
}
else if (strAttributeName  ==  convProjects.UseStateId)
{
mstrUseStateId = value.ToString();
 AddUpdatedFld(convProjects.UseStateId);
}
else if (strAttributeName  ==  convProjects.UseStateName)
{
mstrUseStateName = value.ToString();
 AddUpdatedFld(convProjects.UseStateName);
}
else if (strAttributeName  ==  convProjects.IsSupportMvc)
{
mbolIsSupportMvc = TransNullToBool(value.ToString());
 AddUpdatedFld(convProjects.IsSupportMvc);
}
else if (strAttributeName  ==  convProjects.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convProjects.UserId);
}
else if (strAttributeName  ==  convProjects.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convProjects.UpdDate);
}
else if (strAttributeName  ==  convProjects.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convProjects.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convProjects.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convProjects.PrjName  ==  _AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convProjects.PrjDomain  ==  _AttributeName[intIndex])
{
return mstrPrjDomain;
}
else if (convProjects.IsoPrjName  ==  _AttributeName[intIndex])
{
return mstrIsoPrjName;
}
else if (convProjects.JavaPackageName  ==  _AttributeName[intIndex])
{
return mstrJavaPackageName;
}
else if (convProjects.IsRelaDataBase  ==  _AttributeName[intIndex])
{
return mbolIsRelaDataBase;
}
else if (convProjects.SoftStructureId  ==  _AttributeName[intIndex])
{
return mstrSoftStructureId;
}
else if (convProjects.SoftStructureName  ==  _AttributeName[intIndex])
{
return mstrSoftStructureName;
}
else if (convProjects.ApplicationTypeId  ==  _AttributeName[intIndex])
{
return mintApplicationTypeId;
}
else if (convProjects.ApplicationTypeName  ==  _AttributeName[intIndex])
{
return mstrApplicationTypeName;
}
else if (convProjects.UseStateId  ==  _AttributeName[intIndex])
{
return mstrUseStateId;
}
else if (convProjects.UseStateName  ==  _AttributeName[intIndex])
{
return mstrUseStateName;
}
else if (convProjects.IsSupportMvc  ==  _AttributeName[intIndex])
{
return mbolIsSupportMvc;
}
else if (convProjects.UserId  ==  _AttributeName[intIndex])
{
return mstrUserId;
}
else if (convProjects.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convProjects.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convProjects.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convProjects.PrjId);
}
else if (convProjects.PrjName  ==  _AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convProjects.PrjName);
}
else if (convProjects.PrjDomain  ==  _AttributeName[intIndex])
{
mstrPrjDomain = value.ToString();
 AddUpdatedFld(convProjects.PrjDomain);
}
else if (convProjects.IsoPrjName  ==  _AttributeName[intIndex])
{
mstrIsoPrjName = value.ToString();
 AddUpdatedFld(convProjects.IsoPrjName);
}
else if (convProjects.JavaPackageName  ==  _AttributeName[intIndex])
{
mstrJavaPackageName = value.ToString();
 AddUpdatedFld(convProjects.JavaPackageName);
}
else if (convProjects.IsRelaDataBase  ==  _AttributeName[intIndex])
{
mbolIsRelaDataBase = TransNullToBool(value.ToString());
 AddUpdatedFld(convProjects.IsRelaDataBase);
}
else if (convProjects.SoftStructureId  ==  _AttributeName[intIndex])
{
mstrSoftStructureId = value.ToString();
 AddUpdatedFld(convProjects.SoftStructureId);
}
else if (convProjects.SoftStructureName  ==  _AttributeName[intIndex])
{
mstrSoftStructureName = value.ToString();
 AddUpdatedFld(convProjects.SoftStructureName);
}
else if (convProjects.ApplicationTypeId  ==  _AttributeName[intIndex])
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convProjects.ApplicationTypeId);
}
else if (convProjects.ApplicationTypeName  ==  _AttributeName[intIndex])
{
mstrApplicationTypeName = value.ToString();
 AddUpdatedFld(convProjects.ApplicationTypeName);
}
else if (convProjects.UseStateId  ==  _AttributeName[intIndex])
{
mstrUseStateId = value.ToString();
 AddUpdatedFld(convProjects.UseStateId);
}
else if (convProjects.UseStateName  ==  _AttributeName[intIndex])
{
mstrUseStateName = value.ToString();
 AddUpdatedFld(convProjects.UseStateName);
}
else if (convProjects.IsSupportMvc  ==  _AttributeName[intIndex])
{
mbolIsSupportMvc = TransNullToBool(value.ToString());
 AddUpdatedFld(convProjects.IsSupportMvc);
}
else if (convProjects.UserId  ==  _AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convProjects.UserId);
}
else if (convProjects.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convProjects.UpdDate);
}
else if (convProjects.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convProjects.Memo);
}
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
 AddUpdatedFld(convProjects.PrjId);
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
 AddUpdatedFld(convProjects.PrjName);
}
}
/// <summary>
/// 域/包名(说明:;字段类型:varchar;字段长度:128;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjDomain
{
get
{
return mstrPrjDomain;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjDomain = value;
}
else
{
 mstrPrjDomain = value;
}
//记录修改过的字段
 AddUpdatedFld(convProjects.PrjDomain);
}
}
/// <summary>
/// ISO工程名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IsoPrjName
{
get
{
return mstrIsoPrjName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIsoPrjName = value;
}
else
{
 mstrIsoPrjName = value;
}
//记录修改过的字段
 AddUpdatedFld(convProjects.IsoPrjName);
}
}
/// <summary>
/// Java包名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string JavaPackageName
{
get
{
return mstrJavaPackageName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrJavaPackageName = value;
}
else
{
 mstrJavaPackageName = value;
}
//记录修改过的字段
 AddUpdatedFld(convProjects.JavaPackageName);
}
}
/// <summary>
/// 是否关联数据库(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsRelaDataBase
{
get
{
return mbolIsRelaDataBase;
}
set
{
 mbolIsRelaDataBase = value;
//记录修改过的字段
 AddUpdatedFld(convProjects.IsRelaDataBase);
}
}
/// <summary>
/// 架构ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SoftStructureId
{
get
{
return mstrSoftStructureId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSoftStructureId = value;
}
else
{
 mstrSoftStructureId = value;
}
//记录修改过的字段
 AddUpdatedFld(convProjects.SoftStructureId);
}
}
/// <summary>
/// 架构名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SoftStructureName
{
get
{
return mstrSoftStructureName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSoftStructureName = value;
}
else
{
 mstrSoftStructureName = value;
}
//记录修改过的字段
 AddUpdatedFld(convProjects.SoftStructureName);
}
}
/// <summary>
/// 应用程序类型ID(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int ApplicationTypeId
{
get
{
return mintApplicationTypeId;
}
set
{
 mintApplicationTypeId = value;
//记录修改过的字段
 AddUpdatedFld(convProjects.ApplicationTypeId);
}
}
/// <summary>
/// 应用程序类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ApplicationTypeName
{
get
{
return mstrApplicationTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrApplicationTypeName = value;
}
else
{
 mstrApplicationTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convProjects.ApplicationTypeName);
}
}
/// <summary>
/// 使用状态Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UseStateId
{
get
{
return mstrUseStateId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUseStateId = value;
}
else
{
 mstrUseStateId = value;
}
//记录修改过的字段
 AddUpdatedFld(convProjects.UseStateId);
}
}
/// <summary>
/// 使用状态名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UseStateName
{
get
{
return mstrUseStateName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUseStateName = value;
}
else
{
 mstrUseStateName = value;
}
//记录修改过的字段
 AddUpdatedFld(convProjects.UseStateName);
}
}
/// <summary>
/// 是否支持Mvc(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsSupportMvc
{
get
{
return mbolIsSupportMvc;
}
set
{
 mbolIsSupportMvc = value;
//记录修改过的字段
 AddUpdatedFld(convProjects.IsSupportMvc);
}
}
/// <summary>
/// 用户Id(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserId
{
get
{
return mstrUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserId = value;
}
else
{
 mstrUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(convProjects.UserId);
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
 AddUpdatedFld(convProjects.UpdDate);
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
 AddUpdatedFld(convProjects.Memo);
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
  return mstrPrjId;
 }
 }
}
 /// <summary>
 /// v工程(vProjects)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convProjects
{
public const string _CurrTabName = "vProjects"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PrjId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"PrjId", "PrjName", "PrjDomain", "IsoPrjName", "JavaPackageName", "IsRelaDataBase", "SoftStructureId", "SoftStructureName", "ApplicationTypeId", "ApplicationTypeName", "UseStateId", "UseStateName", "IsSupportMvc", "UserId", "UpdDate", "Memo"};
//以下是属性变量


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
 /// 常量:"PrjDomain"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjDomain = "PrjDomain";    //域/包名

 /// <summary>
 /// 常量:"IsoPrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsoPrjName = "IsoPrjName";    //ISO工程名

 /// <summary>
 /// 常量:"JavaPackageName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string JavaPackageName = "JavaPackageName";    //Java包名

 /// <summary>
 /// 常量:"IsRelaDataBase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsRelaDataBase = "IsRelaDataBase";    //是否关联数据库

 /// <summary>
 /// 常量:"SoftStructureId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SoftStructureId = "SoftStructureId";    //架构ID

 /// <summary>
 /// 常量:"SoftStructureName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SoftStructureName = "SoftStructureName";    //架构名称

 /// <summary>
 /// 常量:"ApplicationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeId = "ApplicationTypeId";    //应用程序类型ID

 /// <summary>
 /// 常量:"ApplicationTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeName = "ApplicationTypeName";    //应用程序类型名称

 /// <summary>
 /// 常量:"UseStateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UseStateId = "UseStateId";    //使用状态Id

 /// <summary>
 /// 常量:"UseStateName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UseStateName = "UseStateName";    //使用状态名称

 /// <summary>
 /// 常量:"IsSupportMvc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSupportMvc = "IsSupportMvc";    //是否支持Mvc

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户Id

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