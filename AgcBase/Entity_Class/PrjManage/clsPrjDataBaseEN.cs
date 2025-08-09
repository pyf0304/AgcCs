
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjDataBaseEN
 表名:PrjDataBase(00050176)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:08:07
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
 /// 表PrjDataBase的关键字(PrjDataBaseId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PrjDataBaseId_PrjDataBase
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
public K_PrjDataBaseId_PrjDataBase(string strPrjDataBaseId)
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
 /// <returns>返回:[K_PrjDataBaseId_PrjDataBase]类型的对象</returns>
public static implicit operator K_PrjDataBaseId_PrjDataBase(string value)
{
return new K_PrjDataBaseId_PrjDataBase(value);
}
}
 /// <summary>
 /// 数据库对象(PrjDataBase)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsPrjDataBaseEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "PrjDataBase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PrjDataBaseId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 14;
public static string[] _AttributeName = new string[] {"PrjDataBaseId", "PrjDataBaseName", "DataBaseName", "DatabaseOwner", "DataBasePwd", "DataBaseTypeId", "DataBaseUserId", "IpAddress", "Sid", "TableSpace", "UseStateId", "UserId", "UpdDate", "Memo"};

protected string mstrPrjDataBaseId;    //项目数据库Id
protected string mstrPrjDataBaseName;    //项目数据库名
protected string mstrDataBaseName;    //数据库名
protected string mstrDatabaseOwner;    //数据库拥有者
protected string mstrDataBasePwd;    //数据库的用户口令
protected string mstrDataBaseTypeId;    //数据库类型ID
protected string mstrDataBaseUserId;    //数据库的用户ID
protected string mstrIpAddress;    //服务器
protected string mstrSid;    //SID
protected string mstrTableSpace;    //表空间
protected string mstrUseStateId;    //使用状态Id
protected string mstrUserId;    //用户Id
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsPrjDataBaseEN()
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
public clsPrjDataBaseEN(string strPrjDataBaseId)
 {
strPrjDataBaseId = strPrjDataBaseId.Replace("'", "''");
if (strPrjDataBaseId.Length > 4)
{
throw new Exception("在表:PrjDataBase中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strPrjDataBaseId)  ==  true)
{
throw new Exception("在表:PrjDataBase中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  conPrjDataBase.PrjDataBaseId)
{
return mstrPrjDataBaseId;
}
else if (strAttributeName  ==  conPrjDataBase.PrjDataBaseName)
{
return mstrPrjDataBaseName;
}
else if (strAttributeName  ==  conPrjDataBase.DataBaseName)
{
return mstrDataBaseName;
}
else if (strAttributeName  ==  conPrjDataBase.DatabaseOwner)
{
return mstrDatabaseOwner;
}
else if (strAttributeName  ==  conPrjDataBase.DataBasePwd)
{
return mstrDataBasePwd;
}
else if (strAttributeName  ==  conPrjDataBase.DataBaseTypeId)
{
return mstrDataBaseTypeId;
}
else if (strAttributeName  ==  conPrjDataBase.DataBaseUserId)
{
return mstrDataBaseUserId;
}
else if (strAttributeName  ==  conPrjDataBase.IpAddress)
{
return mstrIpAddress;
}
else if (strAttributeName  ==  conPrjDataBase.Sid)
{
return mstrSid;
}
else if (strAttributeName  ==  conPrjDataBase.TableSpace)
{
return mstrTableSpace;
}
else if (strAttributeName  ==  conPrjDataBase.UseStateId)
{
return mstrUseStateId;
}
else if (strAttributeName  ==  conPrjDataBase.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conPrjDataBase.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conPrjDataBase.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conPrjDataBase.PrjDataBaseId)
{
mstrPrjDataBaseId = value.ToString();
 AddUpdatedFld(conPrjDataBase.PrjDataBaseId);
}
else if (strAttributeName  ==  conPrjDataBase.PrjDataBaseName)
{
mstrPrjDataBaseName = value.ToString();
 AddUpdatedFld(conPrjDataBase.PrjDataBaseName);
}
else if (strAttributeName  ==  conPrjDataBase.DataBaseName)
{
mstrDataBaseName = value.ToString();
 AddUpdatedFld(conPrjDataBase.DataBaseName);
}
else if (strAttributeName  ==  conPrjDataBase.DatabaseOwner)
{
mstrDatabaseOwner = value.ToString();
 AddUpdatedFld(conPrjDataBase.DatabaseOwner);
}
else if (strAttributeName  ==  conPrjDataBase.DataBasePwd)
{
mstrDataBasePwd = value.ToString();
 AddUpdatedFld(conPrjDataBase.DataBasePwd);
}
else if (strAttributeName  ==  conPrjDataBase.DataBaseTypeId)
{
mstrDataBaseTypeId = value.ToString();
 AddUpdatedFld(conPrjDataBase.DataBaseTypeId);
}
else if (strAttributeName  ==  conPrjDataBase.DataBaseUserId)
{
mstrDataBaseUserId = value.ToString();
 AddUpdatedFld(conPrjDataBase.DataBaseUserId);
}
else if (strAttributeName  ==  conPrjDataBase.IpAddress)
{
mstrIpAddress = value.ToString();
 AddUpdatedFld(conPrjDataBase.IpAddress);
}
else if (strAttributeName  ==  conPrjDataBase.Sid)
{
mstrSid = value.ToString();
 AddUpdatedFld(conPrjDataBase.Sid);
}
else if (strAttributeName  ==  conPrjDataBase.TableSpace)
{
mstrTableSpace = value.ToString();
 AddUpdatedFld(conPrjDataBase.TableSpace);
}
else if (strAttributeName  ==  conPrjDataBase.UseStateId)
{
mstrUseStateId = value.ToString();
 AddUpdatedFld(conPrjDataBase.UseStateId);
}
else if (strAttributeName  ==  conPrjDataBase.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conPrjDataBase.UserId);
}
else if (strAttributeName  ==  conPrjDataBase.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conPrjDataBase.UpdDate);
}
else if (strAttributeName  ==  conPrjDataBase.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPrjDataBase.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conPrjDataBase.PrjDataBaseId  ==  _AttributeName[intIndex])
{
return mstrPrjDataBaseId;
}
else if (conPrjDataBase.PrjDataBaseName  ==  _AttributeName[intIndex])
{
return mstrPrjDataBaseName;
}
else if (conPrjDataBase.DataBaseName  ==  _AttributeName[intIndex])
{
return mstrDataBaseName;
}
else if (conPrjDataBase.DatabaseOwner  ==  _AttributeName[intIndex])
{
return mstrDatabaseOwner;
}
else if (conPrjDataBase.DataBasePwd  ==  _AttributeName[intIndex])
{
return mstrDataBasePwd;
}
else if (conPrjDataBase.DataBaseTypeId  ==  _AttributeName[intIndex])
{
return mstrDataBaseTypeId;
}
else if (conPrjDataBase.DataBaseUserId  ==  _AttributeName[intIndex])
{
return mstrDataBaseUserId;
}
else if (conPrjDataBase.IpAddress  ==  _AttributeName[intIndex])
{
return mstrIpAddress;
}
else if (conPrjDataBase.Sid  ==  _AttributeName[intIndex])
{
return mstrSid;
}
else if (conPrjDataBase.TableSpace  ==  _AttributeName[intIndex])
{
return mstrTableSpace;
}
else if (conPrjDataBase.UseStateId  ==  _AttributeName[intIndex])
{
return mstrUseStateId;
}
else if (conPrjDataBase.UserId  ==  _AttributeName[intIndex])
{
return mstrUserId;
}
else if (conPrjDataBase.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conPrjDataBase.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conPrjDataBase.PrjDataBaseId  ==  _AttributeName[intIndex])
{
mstrPrjDataBaseId = value.ToString();
 AddUpdatedFld(conPrjDataBase.PrjDataBaseId);
}
else if (conPrjDataBase.PrjDataBaseName  ==  _AttributeName[intIndex])
{
mstrPrjDataBaseName = value.ToString();
 AddUpdatedFld(conPrjDataBase.PrjDataBaseName);
}
else if (conPrjDataBase.DataBaseName  ==  _AttributeName[intIndex])
{
mstrDataBaseName = value.ToString();
 AddUpdatedFld(conPrjDataBase.DataBaseName);
}
else if (conPrjDataBase.DatabaseOwner  ==  _AttributeName[intIndex])
{
mstrDatabaseOwner = value.ToString();
 AddUpdatedFld(conPrjDataBase.DatabaseOwner);
}
else if (conPrjDataBase.DataBasePwd  ==  _AttributeName[intIndex])
{
mstrDataBasePwd = value.ToString();
 AddUpdatedFld(conPrjDataBase.DataBasePwd);
}
else if (conPrjDataBase.DataBaseTypeId  ==  _AttributeName[intIndex])
{
mstrDataBaseTypeId = value.ToString();
 AddUpdatedFld(conPrjDataBase.DataBaseTypeId);
}
else if (conPrjDataBase.DataBaseUserId  ==  _AttributeName[intIndex])
{
mstrDataBaseUserId = value.ToString();
 AddUpdatedFld(conPrjDataBase.DataBaseUserId);
}
else if (conPrjDataBase.IpAddress  ==  _AttributeName[intIndex])
{
mstrIpAddress = value.ToString();
 AddUpdatedFld(conPrjDataBase.IpAddress);
}
else if (conPrjDataBase.Sid  ==  _AttributeName[intIndex])
{
mstrSid = value.ToString();
 AddUpdatedFld(conPrjDataBase.Sid);
}
else if (conPrjDataBase.TableSpace  ==  _AttributeName[intIndex])
{
mstrTableSpace = value.ToString();
 AddUpdatedFld(conPrjDataBase.TableSpace);
}
else if (conPrjDataBase.UseStateId  ==  _AttributeName[intIndex])
{
mstrUseStateId = value.ToString();
 AddUpdatedFld(conPrjDataBase.UseStateId);
}
else if (conPrjDataBase.UserId  ==  _AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conPrjDataBase.UserId);
}
else if (conPrjDataBase.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conPrjDataBase.UpdDate);
}
else if (conPrjDataBase.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPrjDataBase.Memo);
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
 AddUpdatedFld(conPrjDataBase.PrjDataBaseId);
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
 AddUpdatedFld(conPrjDataBase.PrjDataBaseName);
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
 AddUpdatedFld(conPrjDataBase.DataBaseName);
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
 AddUpdatedFld(conPrjDataBase.DatabaseOwner);
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
 AddUpdatedFld(conPrjDataBase.DataBasePwd);
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
 AddUpdatedFld(conPrjDataBase.DataBaseTypeId);
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
 AddUpdatedFld(conPrjDataBase.DataBaseUserId);
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
 AddUpdatedFld(conPrjDataBase.IpAddress);
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
 AddUpdatedFld(conPrjDataBase.Sid);
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
 AddUpdatedFld(conPrjDataBase.TableSpace);
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
 AddUpdatedFld(conPrjDataBase.UseStateId);
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
 AddUpdatedFld(conPrjDataBase.UserId);
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
 AddUpdatedFld(conPrjDataBase.UpdDate);
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
 AddUpdatedFld(conPrjDataBase.Memo);
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

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrPrjDataBaseName;
 }
 }
}
 /// <summary>
 /// 数据库对象(PrjDataBase)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conPrjDataBase
{
public const string _CurrTabName = "PrjDataBase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PrjDataBaseId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"PrjDataBaseId", "PrjDataBaseName", "DataBaseName", "DatabaseOwner", "DataBasePwd", "DataBaseTypeId", "DataBaseUserId", "IpAddress", "Sid", "TableSpace", "UseStateId", "UserId", "UpdDate", "Memo"};
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
 /// 常量:"DataBaseTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataBaseTypeId = "DataBaseTypeId";    //数据库类型ID

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