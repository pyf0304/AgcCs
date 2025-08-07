
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvUserPrjGrantEN
 表名:vUserPrjGrant(00050174)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:40:09
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:权限管理(AuthorityManage)
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
 /// 表vUserPrjGrant的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vUserPrjGrant
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
public K_mId_vUserPrjGrant(long lngmId)
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
 /// <returns>返回:[K_mId_vUserPrjGrant]类型的对象</returns>
public static implicit operator K_mId_vUserPrjGrant(long value)
{
return new K_mId_vUserPrjGrant(value);
}
}
 /// <summary>
 /// vUserPrjGrant(vUserPrjGrant)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvUserPrjGrantEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vUserPrjGrant"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 16;
public static string[] _AttributeName = new string[] {"mId", "UserId", "UserName", "UserStateName", "DepartmentId", "DepartmentName", "PrjId", "PrjName", "RoleId", "RoleName", "VisitedNum", "LastVisitedDate", "OptId", "OptDate", "Memo", "UseStateId"};

protected long mlngmId;    //mId
protected string mstrUserId;    //用户Id
protected string mstrUserName;    //用户名
protected string mstrUserStateName;    //用户状态名
protected string mstrDepartmentId;    //部门ID
protected string mstrDepartmentName;    //部门名称
protected string mstrPrjId;    //工程Id
protected string mstrPrjName;    //工程名称
protected string mstrRoleId;    //角色ID
protected string mstrRoleName;    //角色名称
protected int? mintVisitedNum;    //访问数
protected string mstrLastVisitedDate;    //最后访问时间
protected string mstrOptId;    //操作者Id
protected string mstrOptDate;    //操作日期
protected string mstrMemo;    //说明
protected string mstrUseStateId;    //使用状态Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvUserPrjGrantEN()
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
public clsvUserPrjGrantEN(long lngmId)
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
if (strAttributeName  ==  convUserPrjGrant.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convUserPrjGrant.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convUserPrjGrant.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convUserPrjGrant.UserStateName)
{
return mstrUserStateName;
}
else if (strAttributeName  ==  convUserPrjGrant.DepartmentId)
{
return mstrDepartmentId;
}
else if (strAttributeName  ==  convUserPrjGrant.DepartmentName)
{
return mstrDepartmentName;
}
else if (strAttributeName  ==  convUserPrjGrant.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convUserPrjGrant.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convUserPrjGrant.RoleId)
{
return mstrRoleId;
}
else if (strAttributeName  ==  convUserPrjGrant.RoleName)
{
return mstrRoleName;
}
else if (strAttributeName  ==  convUserPrjGrant.VisitedNum)
{
return mintVisitedNum;
}
else if (strAttributeName  ==  convUserPrjGrant.LastVisitedDate)
{
return mstrLastVisitedDate;
}
else if (strAttributeName  ==  convUserPrjGrant.OptId)
{
return mstrOptId;
}
else if (strAttributeName  ==  convUserPrjGrant.OptDate)
{
return mstrOptDate;
}
else if (strAttributeName  ==  convUserPrjGrant.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convUserPrjGrant.UseStateId)
{
return mstrUseStateId;
}
return null;
}
set
{
if (strAttributeName  ==  convUserPrjGrant.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convUserPrjGrant.mId);
}
else if (strAttributeName  ==  convUserPrjGrant.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convUserPrjGrant.UserId);
}
else if (strAttributeName  ==  convUserPrjGrant.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convUserPrjGrant.UserName);
}
else if (strAttributeName  ==  convUserPrjGrant.UserStateName)
{
mstrUserStateName = value.ToString();
 AddUpdatedFld(convUserPrjGrant.UserStateName);
}
else if (strAttributeName  ==  convUserPrjGrant.DepartmentId)
{
mstrDepartmentId = value.ToString();
 AddUpdatedFld(convUserPrjGrant.DepartmentId);
}
else if (strAttributeName  ==  convUserPrjGrant.DepartmentName)
{
mstrDepartmentName = value.ToString();
 AddUpdatedFld(convUserPrjGrant.DepartmentName);
}
else if (strAttributeName  ==  convUserPrjGrant.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convUserPrjGrant.PrjId);
}
else if (strAttributeName  ==  convUserPrjGrant.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convUserPrjGrant.PrjName);
}
else if (strAttributeName  ==  convUserPrjGrant.RoleId)
{
mstrRoleId = value.ToString();
 AddUpdatedFld(convUserPrjGrant.RoleId);
}
else if (strAttributeName  ==  convUserPrjGrant.RoleName)
{
mstrRoleName = value.ToString();
 AddUpdatedFld(convUserPrjGrant.RoleName);
}
else if (strAttributeName  ==  convUserPrjGrant.VisitedNum)
{
mintVisitedNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convUserPrjGrant.VisitedNum);
}
else if (strAttributeName  ==  convUserPrjGrant.LastVisitedDate)
{
mstrLastVisitedDate = value.ToString();
 AddUpdatedFld(convUserPrjGrant.LastVisitedDate);
}
else if (strAttributeName  ==  convUserPrjGrant.OptId)
{
mstrOptId = value.ToString();
 AddUpdatedFld(convUserPrjGrant.OptId);
}
else if (strAttributeName  ==  convUserPrjGrant.OptDate)
{
mstrOptDate = value.ToString();
 AddUpdatedFld(convUserPrjGrant.OptDate);
}
else if (strAttributeName  ==  convUserPrjGrant.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convUserPrjGrant.Memo);
}
else if (strAttributeName  ==  convUserPrjGrant.UseStateId)
{
mstrUseStateId = value.ToString();
 AddUpdatedFld(convUserPrjGrant.UseStateId);
}
}
}
public object this[int intIndex]
{
get
{
if (convUserPrjGrant.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (convUserPrjGrant.UserId  ==  _AttributeName[intIndex])
{
return mstrUserId;
}
else if (convUserPrjGrant.UserName  ==  _AttributeName[intIndex])
{
return mstrUserName;
}
else if (convUserPrjGrant.UserStateName  ==  _AttributeName[intIndex])
{
return mstrUserStateName;
}
else if (convUserPrjGrant.DepartmentId  ==  _AttributeName[intIndex])
{
return mstrDepartmentId;
}
else if (convUserPrjGrant.DepartmentName  ==  _AttributeName[intIndex])
{
return mstrDepartmentName;
}
else if (convUserPrjGrant.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convUserPrjGrant.PrjName  ==  _AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convUserPrjGrant.RoleId  ==  _AttributeName[intIndex])
{
return mstrRoleId;
}
else if (convUserPrjGrant.RoleName  ==  _AttributeName[intIndex])
{
return mstrRoleName;
}
else if (convUserPrjGrant.VisitedNum  ==  _AttributeName[intIndex])
{
return mintVisitedNum;
}
else if (convUserPrjGrant.LastVisitedDate  ==  _AttributeName[intIndex])
{
return mstrLastVisitedDate;
}
else if (convUserPrjGrant.OptId  ==  _AttributeName[intIndex])
{
return mstrOptId;
}
else if (convUserPrjGrant.OptDate  ==  _AttributeName[intIndex])
{
return mstrOptDate;
}
else if (convUserPrjGrant.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (convUserPrjGrant.UseStateId  ==  _AttributeName[intIndex])
{
return mstrUseStateId;
}
return null;
}
set
{
if (convUserPrjGrant.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convUserPrjGrant.mId);
}
else if (convUserPrjGrant.UserId  ==  _AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convUserPrjGrant.UserId);
}
else if (convUserPrjGrant.UserName  ==  _AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convUserPrjGrant.UserName);
}
else if (convUserPrjGrant.UserStateName  ==  _AttributeName[intIndex])
{
mstrUserStateName = value.ToString();
 AddUpdatedFld(convUserPrjGrant.UserStateName);
}
else if (convUserPrjGrant.DepartmentId  ==  _AttributeName[intIndex])
{
mstrDepartmentId = value.ToString();
 AddUpdatedFld(convUserPrjGrant.DepartmentId);
}
else if (convUserPrjGrant.DepartmentName  ==  _AttributeName[intIndex])
{
mstrDepartmentName = value.ToString();
 AddUpdatedFld(convUserPrjGrant.DepartmentName);
}
else if (convUserPrjGrant.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convUserPrjGrant.PrjId);
}
else if (convUserPrjGrant.PrjName  ==  _AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convUserPrjGrant.PrjName);
}
else if (convUserPrjGrant.RoleId  ==  _AttributeName[intIndex])
{
mstrRoleId = value.ToString();
 AddUpdatedFld(convUserPrjGrant.RoleId);
}
else if (convUserPrjGrant.RoleName  ==  _AttributeName[intIndex])
{
mstrRoleName = value.ToString();
 AddUpdatedFld(convUserPrjGrant.RoleName);
}
else if (convUserPrjGrant.VisitedNum  ==  _AttributeName[intIndex])
{
mintVisitedNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convUserPrjGrant.VisitedNum);
}
else if (convUserPrjGrant.LastVisitedDate  ==  _AttributeName[intIndex])
{
mstrLastVisitedDate = value.ToString();
 AddUpdatedFld(convUserPrjGrant.LastVisitedDate);
}
else if (convUserPrjGrant.OptId  ==  _AttributeName[intIndex])
{
mstrOptId = value.ToString();
 AddUpdatedFld(convUserPrjGrant.OptId);
}
else if (convUserPrjGrant.OptDate  ==  _AttributeName[intIndex])
{
mstrOptDate = value.ToString();
 AddUpdatedFld(convUserPrjGrant.OptDate);
}
else if (convUserPrjGrant.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convUserPrjGrant.Memo);
}
else if (convUserPrjGrant.UseStateId  ==  _AttributeName[intIndex])
{
mstrUseStateId = value.ToString();
 AddUpdatedFld(convUserPrjGrant.UseStateId);
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
 AddUpdatedFld(convUserPrjGrant.mId);
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
 AddUpdatedFld(convUserPrjGrant.UserId);
}
}
/// <summary>
/// 用户名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserName
{
get
{
return mstrUserName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserName = value;
}
else
{
 mstrUserName = value;
}
//记录修改过的字段
 AddUpdatedFld(convUserPrjGrant.UserName);
}
}
/// <summary>
/// 用户状态名(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserStateName
{
get
{
return mstrUserStateName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserStateName = value;
}
else
{
 mstrUserStateName = value;
}
//记录修改过的字段
 AddUpdatedFld(convUserPrjGrant.UserStateName);
}
}
/// <summary>
/// 部门ID(说明:;字段类型:varchar;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DepartmentId
{
get
{
return mstrDepartmentId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDepartmentId = value;
}
else
{
 mstrDepartmentId = value;
}
//记录修改过的字段
 AddUpdatedFld(convUserPrjGrant.DepartmentId);
}
}
/// <summary>
/// 部门名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DepartmentName
{
get
{
return mstrDepartmentName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDepartmentName = value;
}
else
{
 mstrDepartmentName = value;
}
//记录修改过的字段
 AddUpdatedFld(convUserPrjGrant.DepartmentName);
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
 AddUpdatedFld(convUserPrjGrant.PrjId);
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
 AddUpdatedFld(convUserPrjGrant.PrjName);
}
}
/// <summary>
/// 角色ID(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RoleId
{
get
{
return mstrRoleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRoleId = value;
}
else
{
 mstrRoleId = value;
}
//记录修改过的字段
 AddUpdatedFld(convUserPrjGrant.RoleId);
}
}
/// <summary>
/// 角色名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RoleName
{
get
{
return mstrRoleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRoleName = value;
}
else
{
 mstrRoleName = value;
}
//记录修改过的字段
 AddUpdatedFld(convUserPrjGrant.RoleName);
}
}
/// <summary>
/// 访问数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? VisitedNum
{
get
{
return mintVisitedNum;
}
set
{
 mintVisitedNum = value;
//记录修改过的字段
 AddUpdatedFld(convUserPrjGrant.VisitedNum);
}
}
/// <summary>
/// 最后访问时间(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LastVisitedDate
{
get
{
return mstrLastVisitedDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLastVisitedDate = value;
}
else
{
 mstrLastVisitedDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convUserPrjGrant.LastVisitedDate);
}
}
/// <summary>
/// 操作者Id(说明:;字段类型:varchar;字段长度:18;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OptId
{
get
{
return mstrOptId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOptId = value;
}
else
{
 mstrOptId = value;
}
//记录修改过的字段
 AddUpdatedFld(convUserPrjGrant.OptId);
}
}
/// <summary>
/// 操作日期(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OptDate
{
get
{
return mstrOptDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOptDate = value;
}
else
{
 mstrOptDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convUserPrjGrant.OptDate);
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
 AddUpdatedFld(convUserPrjGrant.Memo);
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
 AddUpdatedFld(convUserPrjGrant.UseStateId);
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
 /// vUserPrjGrant(vUserPrjGrant)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convUserPrjGrant
{
public const string _CurrTabName = "vUserPrjGrant"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "UserId", "UserName", "UserStateName", "DepartmentId", "DepartmentName", "PrjId", "PrjName", "RoleId", "RoleName", "VisitedNum", "LastVisitedDate", "OptId", "OptDate", "Memo", "UseStateId"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户Id

 /// <summary>
 /// 常量:"UserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserName = "UserName";    //用户名

 /// <summary>
 /// 常量:"UserStateName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserStateName = "UserStateName";    //用户状态名

 /// <summary>
 /// 常量:"DepartmentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DepartmentId = "DepartmentId";    //部门ID

 /// <summary>
 /// 常量:"DepartmentName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DepartmentName = "DepartmentName";    //部门名称

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
 /// 常量:"RoleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RoleId = "RoleId";    //角色ID

 /// <summary>
 /// 常量:"RoleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RoleName = "RoleName";    //角色名称

 /// <summary>
 /// 常量:"VisitedNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VisitedNum = "VisitedNum";    //访问数

 /// <summary>
 /// 常量:"LastVisitedDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LastVisitedDate = "LastVisitedDate";    //最后访问时间

 /// <summary>
 /// 常量:"OptId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OptId = "OptId";    //操作者Id

 /// <summary>
 /// 常量:"OptDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OptDate = "OptDate";    //操作日期

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明

 /// <summary>
 /// 常量:"UseStateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UseStateId = "UseStateId";    //使用状态Id
}

}