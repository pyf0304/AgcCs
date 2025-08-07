
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvProjectDatabaseRelEN
 表名:vProjectDatabaseRel(00050193)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:47:29
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
 /// 表vProjectDatabaseRel的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vProjectDatabaseRel
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
public K_mId_vProjectDatabaseRel(long lngmId)
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
 /// <returns>返回:[K_mId_vProjectDatabaseRel]类型的对象</returns>
public static implicit operator K_mId_vProjectDatabaseRel(long value)
{
return new K_mId_vProjectDatabaseRel(value);
}
}
 /// <summary>
 /// v工程数据库关系(vProjectDatabaseRel)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvProjectDatabaseRelEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vProjectDatabaseRel"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 16;
public static string[] _AttributeName = new string[] {"mId", "PrjId", "PrjName", "IpAddress", "PrjDataBaseId", "PrjDataBaseName", "DataBaseName", "DataBasePwd", "DataBaseUserId", "DatabaseOwner", "DataBaseTypeId", "DataBaseTypeName", "Sid", "TableSpace", "UseStateId", "UseStateName"};

protected long mlngmId;    //mId
protected string mstrPrjId;    //工程Id
protected string mstrPrjName;    //工程名称
protected string mstrIpAddress;    //服务器
protected string mstrPrjDataBaseId;    //项目数据库Id
protected string mstrPrjDataBaseName;    //项目数据库名
protected string mstrDataBaseName;    //数据库名
protected string mstrDataBasePwd;    //数据库的用户口令
protected string mstrDataBaseUserId;    //数据库的用户ID
protected string mstrDatabaseOwner;    //数据库拥有者
protected string mstrDataBaseTypeId;    //数据库类型ID
protected string mstrDataBaseTypeName;    //数据库类型名
protected string mstrSid;    //SID
protected string mstrTableSpace;    //表空间
protected string mstrUseStateId;    //使用状态Id
protected string mstrUseStateName;    //使用状态名称

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvProjectDatabaseRelEN()
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
public clsvProjectDatabaseRelEN(long lngmId)
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
if (strAttributeName  ==  convProjectDatabaseRel.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convProjectDatabaseRel.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convProjectDatabaseRel.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convProjectDatabaseRel.IpAddress)
{
return mstrIpAddress;
}
else if (strAttributeName  ==  convProjectDatabaseRel.PrjDataBaseId)
{
return mstrPrjDataBaseId;
}
else if (strAttributeName  ==  convProjectDatabaseRel.PrjDataBaseName)
{
return mstrPrjDataBaseName;
}
else if (strAttributeName  ==  convProjectDatabaseRel.DataBaseName)
{
return mstrDataBaseName;
}
else if (strAttributeName  ==  convProjectDatabaseRel.DataBasePwd)
{
return mstrDataBasePwd;
}
else if (strAttributeName  ==  convProjectDatabaseRel.DataBaseUserId)
{
return mstrDataBaseUserId;
}
else if (strAttributeName  ==  convProjectDatabaseRel.DatabaseOwner)
{
return mstrDatabaseOwner;
}
else if (strAttributeName  ==  convProjectDatabaseRel.DataBaseTypeId)
{
return mstrDataBaseTypeId;
}
else if (strAttributeName  ==  convProjectDatabaseRel.DataBaseTypeName)
{
return mstrDataBaseTypeName;
}
else if (strAttributeName  ==  convProjectDatabaseRel.Sid)
{
return mstrSid;
}
else if (strAttributeName  ==  convProjectDatabaseRel.TableSpace)
{
return mstrTableSpace;
}
else if (strAttributeName  ==  convProjectDatabaseRel.UseStateId)
{
return mstrUseStateId;
}
else if (strAttributeName  ==  convProjectDatabaseRel.UseStateName)
{
return mstrUseStateName;
}
return null;
}
set
{
if (strAttributeName  ==  convProjectDatabaseRel.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convProjectDatabaseRel.mId);
}
else if (strAttributeName  ==  convProjectDatabaseRel.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convProjectDatabaseRel.PrjId);
}
else if (strAttributeName  ==  convProjectDatabaseRel.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convProjectDatabaseRel.PrjName);
}
else if (strAttributeName  ==  convProjectDatabaseRel.IpAddress)
{
mstrIpAddress = value.ToString();
 AddUpdatedFld(convProjectDatabaseRel.IpAddress);
}
else if (strAttributeName  ==  convProjectDatabaseRel.PrjDataBaseId)
{
mstrPrjDataBaseId = value.ToString();
 AddUpdatedFld(convProjectDatabaseRel.PrjDataBaseId);
}
else if (strAttributeName  ==  convProjectDatabaseRel.PrjDataBaseName)
{
mstrPrjDataBaseName = value.ToString();
 AddUpdatedFld(convProjectDatabaseRel.PrjDataBaseName);
}
else if (strAttributeName  ==  convProjectDatabaseRel.DataBaseName)
{
mstrDataBaseName = value.ToString();
 AddUpdatedFld(convProjectDatabaseRel.DataBaseName);
}
else if (strAttributeName  ==  convProjectDatabaseRel.DataBasePwd)
{
mstrDataBasePwd = value.ToString();
 AddUpdatedFld(convProjectDatabaseRel.DataBasePwd);
}
else if (strAttributeName  ==  convProjectDatabaseRel.DataBaseUserId)
{
mstrDataBaseUserId = value.ToString();
 AddUpdatedFld(convProjectDatabaseRel.DataBaseUserId);
}
else if (strAttributeName  ==  convProjectDatabaseRel.DatabaseOwner)
{
mstrDatabaseOwner = value.ToString();
 AddUpdatedFld(convProjectDatabaseRel.DatabaseOwner);
}
else if (strAttributeName  ==  convProjectDatabaseRel.DataBaseTypeId)
{
mstrDataBaseTypeId = value.ToString();
 AddUpdatedFld(convProjectDatabaseRel.DataBaseTypeId);
}
else if (strAttributeName  ==  convProjectDatabaseRel.DataBaseTypeName)
{
mstrDataBaseTypeName = value.ToString();
 AddUpdatedFld(convProjectDatabaseRel.DataBaseTypeName);
}
else if (strAttributeName  ==  convProjectDatabaseRel.Sid)
{
mstrSid = value.ToString();
 AddUpdatedFld(convProjectDatabaseRel.Sid);
}
else if (strAttributeName  ==  convProjectDatabaseRel.TableSpace)
{
mstrTableSpace = value.ToString();
 AddUpdatedFld(convProjectDatabaseRel.TableSpace);
}
else if (strAttributeName  ==  convProjectDatabaseRel.UseStateId)
{
mstrUseStateId = value.ToString();
 AddUpdatedFld(convProjectDatabaseRel.UseStateId);
}
else if (strAttributeName  ==  convProjectDatabaseRel.UseStateName)
{
mstrUseStateName = value.ToString();
 AddUpdatedFld(convProjectDatabaseRel.UseStateName);
}
}
}
public object this[int intIndex]
{
get
{
if (convProjectDatabaseRel.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (convProjectDatabaseRel.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convProjectDatabaseRel.PrjName  ==  _AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convProjectDatabaseRel.IpAddress  ==  _AttributeName[intIndex])
{
return mstrIpAddress;
}
else if (convProjectDatabaseRel.PrjDataBaseId  ==  _AttributeName[intIndex])
{
return mstrPrjDataBaseId;
}
else if (convProjectDatabaseRel.PrjDataBaseName  ==  _AttributeName[intIndex])
{
return mstrPrjDataBaseName;
}
else if (convProjectDatabaseRel.DataBaseName  ==  _AttributeName[intIndex])
{
return mstrDataBaseName;
}
else if (convProjectDatabaseRel.DataBasePwd  ==  _AttributeName[intIndex])
{
return mstrDataBasePwd;
}
else if (convProjectDatabaseRel.DataBaseUserId  ==  _AttributeName[intIndex])
{
return mstrDataBaseUserId;
}
else if (convProjectDatabaseRel.DatabaseOwner  ==  _AttributeName[intIndex])
{
return mstrDatabaseOwner;
}
else if (convProjectDatabaseRel.DataBaseTypeId  ==  _AttributeName[intIndex])
{
return mstrDataBaseTypeId;
}
else if (convProjectDatabaseRel.DataBaseTypeName  ==  _AttributeName[intIndex])
{
return mstrDataBaseTypeName;
}
else if (convProjectDatabaseRel.Sid  ==  _AttributeName[intIndex])
{
return mstrSid;
}
else if (convProjectDatabaseRel.TableSpace  ==  _AttributeName[intIndex])
{
return mstrTableSpace;
}
else if (convProjectDatabaseRel.UseStateId  ==  _AttributeName[intIndex])
{
return mstrUseStateId;
}
else if (convProjectDatabaseRel.UseStateName  ==  _AttributeName[intIndex])
{
return mstrUseStateName;
}
return null;
}
set
{
if (convProjectDatabaseRel.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convProjectDatabaseRel.mId);
}
else if (convProjectDatabaseRel.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convProjectDatabaseRel.PrjId);
}
else if (convProjectDatabaseRel.PrjName  ==  _AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convProjectDatabaseRel.PrjName);
}
else if (convProjectDatabaseRel.IpAddress  ==  _AttributeName[intIndex])
{
mstrIpAddress = value.ToString();
 AddUpdatedFld(convProjectDatabaseRel.IpAddress);
}
else if (convProjectDatabaseRel.PrjDataBaseId  ==  _AttributeName[intIndex])
{
mstrPrjDataBaseId = value.ToString();
 AddUpdatedFld(convProjectDatabaseRel.PrjDataBaseId);
}
else if (convProjectDatabaseRel.PrjDataBaseName  ==  _AttributeName[intIndex])
{
mstrPrjDataBaseName = value.ToString();
 AddUpdatedFld(convProjectDatabaseRel.PrjDataBaseName);
}
else if (convProjectDatabaseRel.DataBaseName  ==  _AttributeName[intIndex])
{
mstrDataBaseName = value.ToString();
 AddUpdatedFld(convProjectDatabaseRel.DataBaseName);
}
else if (convProjectDatabaseRel.DataBasePwd  ==  _AttributeName[intIndex])
{
mstrDataBasePwd = value.ToString();
 AddUpdatedFld(convProjectDatabaseRel.DataBasePwd);
}
else if (convProjectDatabaseRel.DataBaseUserId  ==  _AttributeName[intIndex])
{
mstrDataBaseUserId = value.ToString();
 AddUpdatedFld(convProjectDatabaseRel.DataBaseUserId);
}
else if (convProjectDatabaseRel.DatabaseOwner  ==  _AttributeName[intIndex])
{
mstrDatabaseOwner = value.ToString();
 AddUpdatedFld(convProjectDatabaseRel.DatabaseOwner);
}
else if (convProjectDatabaseRel.DataBaseTypeId  ==  _AttributeName[intIndex])
{
mstrDataBaseTypeId = value.ToString();
 AddUpdatedFld(convProjectDatabaseRel.DataBaseTypeId);
}
else if (convProjectDatabaseRel.DataBaseTypeName  ==  _AttributeName[intIndex])
{
mstrDataBaseTypeName = value.ToString();
 AddUpdatedFld(convProjectDatabaseRel.DataBaseTypeName);
}
else if (convProjectDatabaseRel.Sid  ==  _AttributeName[intIndex])
{
mstrSid = value.ToString();
 AddUpdatedFld(convProjectDatabaseRel.Sid);
}
else if (convProjectDatabaseRel.TableSpace  ==  _AttributeName[intIndex])
{
mstrTableSpace = value.ToString();
 AddUpdatedFld(convProjectDatabaseRel.TableSpace);
}
else if (convProjectDatabaseRel.UseStateId  ==  _AttributeName[intIndex])
{
mstrUseStateId = value.ToString();
 AddUpdatedFld(convProjectDatabaseRel.UseStateId);
}
else if (convProjectDatabaseRel.UseStateName  ==  _AttributeName[intIndex])
{
mstrUseStateName = value.ToString();
 AddUpdatedFld(convProjectDatabaseRel.UseStateName);
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
 AddUpdatedFld(convProjectDatabaseRel.mId);
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
 AddUpdatedFld(convProjectDatabaseRel.PrjId);
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
 AddUpdatedFld(convProjectDatabaseRel.PrjName);
}
}
/// <summary>
/// 服务器(说明:;字段类型:varchar;字段长度:25;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IpAddress
{
get
{
return mstrIpAddress;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIpAddress = value;
}
else
{
 mstrIpAddress = value;
}
//记录修改过的字段
 AddUpdatedFld(convProjectDatabaseRel.IpAddress);
}
}
/// <summary>
/// 项目数据库Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjDataBaseId
{
get
{
return mstrPrjDataBaseId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjDataBaseId = value;
}
else
{
 mstrPrjDataBaseId = value;
}
//记录修改过的字段
 AddUpdatedFld(convProjectDatabaseRel.PrjDataBaseId);
}
}
/// <summary>
/// 项目数据库名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjDataBaseName
{
get
{
return mstrPrjDataBaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjDataBaseName = value;
}
else
{
 mstrPrjDataBaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convProjectDatabaseRel.PrjDataBaseName);
}
}
/// <summary>
/// 数据库名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataBaseName
{
get
{
return mstrDataBaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataBaseName = value;
}
else
{
 mstrDataBaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convProjectDatabaseRel.DataBaseName);
}
}
/// <summary>
/// 数据库的用户口令(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataBasePwd
{
get
{
return mstrDataBasePwd;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataBasePwd = value;
}
else
{
 mstrDataBasePwd = value;
}
//记录修改过的字段
 AddUpdatedFld(convProjectDatabaseRel.DataBasePwd);
}
}
/// <summary>
/// 数据库的用户ID(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataBaseUserId
{
get
{
return mstrDataBaseUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataBaseUserId = value;
}
else
{
 mstrDataBaseUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(convProjectDatabaseRel.DataBaseUserId);
}
}
/// <summary>
/// 数据库拥有者(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DatabaseOwner
{
get
{
return mstrDatabaseOwner;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDatabaseOwner = value;
}
else
{
 mstrDatabaseOwner = value;
}
//记录修改过的字段
 AddUpdatedFld(convProjectDatabaseRel.DatabaseOwner);
}
}
/// <summary>
/// 数据库类型ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataBaseTypeId
{
get
{
return mstrDataBaseTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataBaseTypeId = value;
}
else
{
 mstrDataBaseTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convProjectDatabaseRel.DataBaseTypeId);
}
}
/// <summary>
/// 数据库类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataBaseTypeName
{
get
{
return mstrDataBaseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataBaseTypeName = value;
}
else
{
 mstrDataBaseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convProjectDatabaseRel.DataBaseTypeName);
}
}
/// <summary>
/// SID(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Sid
{
get
{
return mstrSid;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSid = value;
}
else
{
 mstrSid = value;
}
//记录修改过的字段
 AddUpdatedFld(convProjectDatabaseRel.Sid);
}
}
/// <summary>
/// 表空间(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TableSpace
{
get
{
return mstrTableSpace;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTableSpace = value;
}
else
{
 mstrTableSpace = value;
}
//记录修改过的字段
 AddUpdatedFld(convProjectDatabaseRel.TableSpace);
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
 AddUpdatedFld(convProjectDatabaseRel.UseStateId);
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
 AddUpdatedFld(convProjectDatabaseRel.UseStateName);
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
 /// v工程数据库关系(vProjectDatabaseRel)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convProjectDatabaseRel
{
public const string _CurrTabName = "vProjectDatabaseRel"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "PrjId", "PrjName", "IpAddress", "PrjDataBaseId", "PrjDataBaseName", "DataBaseName", "DataBasePwd", "DataBaseUserId", "DatabaseOwner", "DataBaseTypeId", "DataBaseTypeName", "Sid", "TableSpace", "UseStateId", "UseStateName"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

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
 /// 常量:"IpAddress"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IpAddress = "IpAddress";    //服务器

 /// <summary>
 /// 常量:"PrjDataBaseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjDataBaseId = "PrjDataBaseId";    //项目数据库Id

 /// <summary>
 /// 常量:"PrjDataBaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjDataBaseName = "PrjDataBaseName";    //项目数据库名

 /// <summary>
 /// 常量:"DataBaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataBaseName = "DataBaseName";    //数据库名

 /// <summary>
 /// 常量:"DataBasePwd"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataBasePwd = "DataBasePwd";    //数据库的用户口令

 /// <summary>
 /// 常量:"DataBaseUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataBaseUserId = "DataBaseUserId";    //数据库的用户ID

 /// <summary>
 /// 常量:"DatabaseOwner"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DatabaseOwner = "DatabaseOwner";    //数据库拥有者

 /// <summary>
 /// 常量:"DataBaseTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataBaseTypeId = "DataBaseTypeId";    //数据库类型ID

 /// <summary>
 /// 常量:"DataBaseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataBaseTypeName = "DataBaseTypeName";    //数据库类型名

 /// <summary>
 /// 常量:"Sid"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Sid = "Sid";    //SID

 /// <summary>
 /// 常量:"TableSpace"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TableSpace = "TableSpace";    //表空间

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
}

}