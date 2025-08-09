
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjDataBaseEN
 表名:vPrjDataBase(00050175)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:13:33
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
 /// 表vPrjDataBase的关键字(PrjDataBaseId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PrjDataBaseId_vPrjDataBase
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strPrjDataBaseId">表关键字</param>
public K_PrjDataBaseId_vPrjDataBase(string strPrjDataBaseId)
{
if (IsValid(strPrjDataBaseId)) Value = strPrjDataBaseId;
else
{
Value = null;
}
}
private static bool IsValid(string strPrjDataBaseId)
{
if (string.IsNullOrEmpty(strPrjDataBaseId) == true) return false;
if (strPrjDataBaseId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PrjDataBaseId_vPrjDataBase]类型的对象</returns>
public static implicit operator K_PrjDataBaseId_vPrjDataBase(string value)
{
return new K_PrjDataBaseId_vPrjDataBase(value);
}
}
 /// <summary>
 /// v数据库对象(vPrjDataBase)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvPrjDataBaseEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vPrjDataBase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PrjDataBaseId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 16;
public static string[] _AttributeName = new string[] {"PrjDataBaseId", "PrjDataBaseName", "DataBaseTypeName", "DataBaseTypeId", "DataBaseName", "DatabaseOwner", "DataBasePwd", "DataBaseUserId", "IpAddress", "TableSpace", "UpdDate", "Sid", "UserId", "Memo", "UseStateName", "UseStateId"};

protected string mstrPrjDataBaseId;    //项目数据库Id
protected string mstrPrjDataBaseName;    //项目数据库名
protected string mstrDataBaseTypeName;    //数据库类型名
protected string mstrDataBaseTypeId;    //数据库类型ID
protected string mstrDataBaseName;    //数据库名
protected string mstrDatabaseOwner;    //数据库拥有者
protected string mstrDataBasePwd;    //数据库的用户口令
protected string mstrDataBaseUserId;    //数据库的用户ID
protected string mstrIpAddress;    //服务器
protected string mstrTableSpace;    //表空间
protected string mstrUpdDate;    //修改日期
protected string mstrSid;    //SID
protected string mstrUserId;    //用户Id
protected string mstrMemo;    //说明
protected string mstrUseStateName;    //使用状态名称
protected string mstrUseStateId;    //使用状态Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvPrjDataBaseEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PrjDataBaseId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strPrjDataBaseId">关键字:项目数据库Id</param>
public clsvPrjDataBaseEN(string strPrjDataBaseId)
 {
strPrjDataBaseId = strPrjDataBaseId.Replace("'", "''");
if (strPrjDataBaseId.Length > 4)
{
throw new Exception("在表:vPrjDataBase中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strPrjDataBaseId)  ==  true)
{
throw new Exception("在表:vPrjDataBase中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPrjDataBaseId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrPrjDataBaseId = strPrjDataBaseId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PrjDataBaseId");
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
if (strAttributeName  ==  convPrjDataBase.PrjDataBaseId)
{
return mstrPrjDataBaseId;
}
else if (strAttributeName  ==  convPrjDataBase.PrjDataBaseName)
{
return mstrPrjDataBaseName;
}
else if (strAttributeName  ==  convPrjDataBase.DataBaseTypeName)
{
return mstrDataBaseTypeName;
}
else if (strAttributeName  ==  convPrjDataBase.DataBaseTypeId)
{
return mstrDataBaseTypeId;
}
else if (strAttributeName  ==  convPrjDataBase.DataBaseName)
{
return mstrDataBaseName;
}
else if (strAttributeName  ==  convPrjDataBase.DatabaseOwner)
{
return mstrDatabaseOwner;
}
else if (strAttributeName  ==  convPrjDataBase.DataBasePwd)
{
return mstrDataBasePwd;
}
else if (strAttributeName  ==  convPrjDataBase.DataBaseUserId)
{
return mstrDataBaseUserId;
}
else if (strAttributeName  ==  convPrjDataBase.IpAddress)
{
return mstrIpAddress;
}
else if (strAttributeName  ==  convPrjDataBase.TableSpace)
{
return mstrTableSpace;
}
else if (strAttributeName  ==  convPrjDataBase.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convPrjDataBase.Sid)
{
return mstrSid;
}
else if (strAttributeName  ==  convPrjDataBase.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convPrjDataBase.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convPrjDataBase.UseStateName)
{
return mstrUseStateName;
}
else if (strAttributeName  ==  convPrjDataBase.UseStateId)
{
return mstrUseStateId;
}
return null;
}
set
{
if (strAttributeName  ==  convPrjDataBase.PrjDataBaseId)
{
mstrPrjDataBaseId = value.ToString();
 AddUpdatedFld(convPrjDataBase.PrjDataBaseId);
}
else if (strAttributeName  ==  convPrjDataBase.PrjDataBaseName)
{
mstrPrjDataBaseName = value.ToString();
 AddUpdatedFld(convPrjDataBase.PrjDataBaseName);
}
else if (strAttributeName  ==  convPrjDataBase.DataBaseTypeName)
{
mstrDataBaseTypeName = value.ToString();
 AddUpdatedFld(convPrjDataBase.DataBaseTypeName);
}
else if (strAttributeName  ==  convPrjDataBase.DataBaseTypeId)
{
mstrDataBaseTypeId = value.ToString();
 AddUpdatedFld(convPrjDataBase.DataBaseTypeId);
}
else if (strAttributeName  ==  convPrjDataBase.DataBaseName)
{
mstrDataBaseName = value.ToString();
 AddUpdatedFld(convPrjDataBase.DataBaseName);
}
else if (strAttributeName  ==  convPrjDataBase.DatabaseOwner)
{
mstrDatabaseOwner = value.ToString();
 AddUpdatedFld(convPrjDataBase.DatabaseOwner);
}
else if (strAttributeName  ==  convPrjDataBase.DataBasePwd)
{
mstrDataBasePwd = value.ToString();
 AddUpdatedFld(convPrjDataBase.DataBasePwd);
}
else if (strAttributeName  ==  convPrjDataBase.DataBaseUserId)
{
mstrDataBaseUserId = value.ToString();
 AddUpdatedFld(convPrjDataBase.DataBaseUserId);
}
else if (strAttributeName  ==  convPrjDataBase.IpAddress)
{
mstrIpAddress = value.ToString();
 AddUpdatedFld(convPrjDataBase.IpAddress);
}
else if (strAttributeName  ==  convPrjDataBase.TableSpace)
{
mstrTableSpace = value.ToString();
 AddUpdatedFld(convPrjDataBase.TableSpace);
}
else if (strAttributeName  ==  convPrjDataBase.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convPrjDataBase.UpdDate);
}
else if (strAttributeName  ==  convPrjDataBase.Sid)
{
mstrSid = value.ToString();
 AddUpdatedFld(convPrjDataBase.Sid);
}
else if (strAttributeName  ==  convPrjDataBase.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convPrjDataBase.UserId);
}
else if (strAttributeName  ==  convPrjDataBase.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convPrjDataBase.Memo);
}
else if (strAttributeName  ==  convPrjDataBase.UseStateName)
{
mstrUseStateName = value.ToString();
 AddUpdatedFld(convPrjDataBase.UseStateName);
}
else if (strAttributeName  ==  convPrjDataBase.UseStateId)
{
mstrUseStateId = value.ToString();
 AddUpdatedFld(convPrjDataBase.UseStateId);
}
}
}
public object this[int intIndex]
{
get
{
if (convPrjDataBase.PrjDataBaseId  ==  _AttributeName[intIndex])
{
return mstrPrjDataBaseId;
}
else if (convPrjDataBase.PrjDataBaseName  ==  _AttributeName[intIndex])
{
return mstrPrjDataBaseName;
}
else if (convPrjDataBase.DataBaseTypeName  ==  _AttributeName[intIndex])
{
return mstrDataBaseTypeName;
}
else if (convPrjDataBase.DataBaseTypeId  ==  _AttributeName[intIndex])
{
return mstrDataBaseTypeId;
}
else if (convPrjDataBase.DataBaseName  ==  _AttributeName[intIndex])
{
return mstrDataBaseName;
}
else if (convPrjDataBase.DatabaseOwner  ==  _AttributeName[intIndex])
{
return mstrDatabaseOwner;
}
else if (convPrjDataBase.DataBasePwd  ==  _AttributeName[intIndex])
{
return mstrDataBasePwd;
}
else if (convPrjDataBase.DataBaseUserId  ==  _AttributeName[intIndex])
{
return mstrDataBaseUserId;
}
else if (convPrjDataBase.IpAddress  ==  _AttributeName[intIndex])
{
return mstrIpAddress;
}
else if (convPrjDataBase.TableSpace  ==  _AttributeName[intIndex])
{
return mstrTableSpace;
}
else if (convPrjDataBase.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convPrjDataBase.Sid  ==  _AttributeName[intIndex])
{
return mstrSid;
}
else if (convPrjDataBase.UserId  ==  _AttributeName[intIndex])
{
return mstrUserId;
}
else if (convPrjDataBase.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (convPrjDataBase.UseStateName  ==  _AttributeName[intIndex])
{
return mstrUseStateName;
}
else if (convPrjDataBase.UseStateId  ==  _AttributeName[intIndex])
{
return mstrUseStateId;
}
return null;
}
set
{
if (convPrjDataBase.PrjDataBaseId  ==  _AttributeName[intIndex])
{
mstrPrjDataBaseId = value.ToString();
 AddUpdatedFld(convPrjDataBase.PrjDataBaseId);
}
else if (convPrjDataBase.PrjDataBaseName  ==  _AttributeName[intIndex])
{
mstrPrjDataBaseName = value.ToString();
 AddUpdatedFld(convPrjDataBase.PrjDataBaseName);
}
else if (convPrjDataBase.DataBaseTypeName  ==  _AttributeName[intIndex])
{
mstrDataBaseTypeName = value.ToString();
 AddUpdatedFld(convPrjDataBase.DataBaseTypeName);
}
else if (convPrjDataBase.DataBaseTypeId  ==  _AttributeName[intIndex])
{
mstrDataBaseTypeId = value.ToString();
 AddUpdatedFld(convPrjDataBase.DataBaseTypeId);
}
else if (convPrjDataBase.DataBaseName  ==  _AttributeName[intIndex])
{
mstrDataBaseName = value.ToString();
 AddUpdatedFld(convPrjDataBase.DataBaseName);
}
else if (convPrjDataBase.DatabaseOwner  ==  _AttributeName[intIndex])
{
mstrDatabaseOwner = value.ToString();
 AddUpdatedFld(convPrjDataBase.DatabaseOwner);
}
else if (convPrjDataBase.DataBasePwd  ==  _AttributeName[intIndex])
{
mstrDataBasePwd = value.ToString();
 AddUpdatedFld(convPrjDataBase.DataBasePwd);
}
else if (convPrjDataBase.DataBaseUserId  ==  _AttributeName[intIndex])
{
mstrDataBaseUserId = value.ToString();
 AddUpdatedFld(convPrjDataBase.DataBaseUserId);
}
else if (convPrjDataBase.IpAddress  ==  _AttributeName[intIndex])
{
mstrIpAddress = value.ToString();
 AddUpdatedFld(convPrjDataBase.IpAddress);
}
else if (convPrjDataBase.TableSpace  ==  _AttributeName[intIndex])
{
mstrTableSpace = value.ToString();
 AddUpdatedFld(convPrjDataBase.TableSpace);
}
else if (convPrjDataBase.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convPrjDataBase.UpdDate);
}
else if (convPrjDataBase.Sid  ==  _AttributeName[intIndex])
{
mstrSid = value.ToString();
 AddUpdatedFld(convPrjDataBase.Sid);
}
else if (convPrjDataBase.UserId  ==  _AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convPrjDataBase.UserId);
}
else if (convPrjDataBase.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convPrjDataBase.Memo);
}
else if (convPrjDataBase.UseStateName  ==  _AttributeName[intIndex])
{
mstrUseStateName = value.ToString();
 AddUpdatedFld(convPrjDataBase.UseStateName);
}
else if (convPrjDataBase.UseStateId  ==  _AttributeName[intIndex])
{
mstrUseStateId = value.ToString();
 AddUpdatedFld(convPrjDataBase.UseStateId);
}
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
 AddUpdatedFld(convPrjDataBase.PrjDataBaseId);
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
 AddUpdatedFld(convPrjDataBase.PrjDataBaseName);
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
 AddUpdatedFld(convPrjDataBase.DataBaseTypeName);
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
 AddUpdatedFld(convPrjDataBase.DataBaseTypeId);
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
 AddUpdatedFld(convPrjDataBase.DataBaseName);
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
 AddUpdatedFld(convPrjDataBase.DatabaseOwner);
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
 AddUpdatedFld(convPrjDataBase.DataBasePwd);
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
 AddUpdatedFld(convPrjDataBase.DataBaseUserId);
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
 AddUpdatedFld(convPrjDataBase.IpAddress);
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
 AddUpdatedFld(convPrjDataBase.TableSpace);
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
 AddUpdatedFld(convPrjDataBase.UpdDate);
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
 AddUpdatedFld(convPrjDataBase.Sid);
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
 AddUpdatedFld(convPrjDataBase.UserId);
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
 AddUpdatedFld(convPrjDataBase.Memo);
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
 AddUpdatedFld(convPrjDataBase.UseStateName);
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
 AddUpdatedFld(convPrjDataBase.UseStateId);
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
  return mstrPrjDataBaseId;
 }
 }
}
 /// <summary>
 /// v数据库对象(vPrjDataBase)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convPrjDataBase
{
public const string _CurrTabName = "vPrjDataBase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PrjDataBaseId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"PrjDataBaseId", "PrjDataBaseName", "DataBaseTypeName", "DataBaseTypeId", "DataBaseName", "DatabaseOwner", "DataBasePwd", "DataBaseUserId", "IpAddress", "TableSpace", "UpdDate", "Sid", "UserId", "Memo", "UseStateName", "UseStateId"};
//以下是属性变量


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
 /// 常量:"DataBaseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataBaseTypeName = "DataBaseTypeName";    //数据库类型名

 /// <summary>
 /// 常量:"DataBaseTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataBaseTypeId = "DataBaseTypeId";    //数据库类型ID

 /// <summary>
 /// 常量:"DataBaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataBaseName = "DataBaseName";    //数据库名

 /// <summary>
 /// 常量:"DatabaseOwner"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DatabaseOwner = "DatabaseOwner";    //数据库拥有者

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
 /// 常量:"IpAddress"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IpAddress = "IpAddress";    //服务器

 /// <summary>
 /// 常量:"TableSpace"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TableSpace = "TableSpace";    //表空间

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"Sid"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Sid = "Sid";    //SID

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明

 /// <summary>
 /// 常量:"UseStateName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UseStateName = "UseStateName";    //使用状态名称

 /// <summary>
 /// 常量:"UseStateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UseStateId = "UseStateId";    //使用状态Id
}

}