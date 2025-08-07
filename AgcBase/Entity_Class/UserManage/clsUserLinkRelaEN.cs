
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUserLinkRelaEN
 表名:UserLinkRela(00050162)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:35:01
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:用户管理(UserManage)
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
 /// 表UserLinkRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_UserLinkRela
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
public K_mId_UserLinkRela(long lngmId)
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
 /// <returns>返回:[K_mId_UserLinkRela]类型的对象</returns>
public static implicit operator K_mId_UserLinkRela(long value)
{
return new K_mId_UserLinkRela(value);
}
}
 /// <summary>
 /// 用户链接关系(UserLinkRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsUserLinkRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "UserLinkRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 11;
public static string[] _AttributeName = new string[] {"mId", "UserId", "LinkName", "DataBaseTypeId", "IpAddress", "DataBaseName", "Sid", "DataBaseUserId", "DataBasePwd", "ConnectionString", "Memo"};

protected long mlngmId;    //mId
protected string mstrUserId;    //用户Id
protected string mstrLinkName;    //链接名称
protected string mstrDataBaseTypeId;    //数据库类型ID
protected string mstrIpAddress;    //服务器
protected string mstrDataBaseName;    //数据库名
protected string mstrSid;    //SID
protected string mstrDataBaseUserId;    //数据库的用户ID
protected string mstrDataBasePwd;    //数据库的用户口令
protected string mstrConnectionString;    //连接串
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsUserLinkRelaEN()
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
public clsUserLinkRelaEN(long lngmId)
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
if (strAttributeName  ==  conUserLinkRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conUserLinkRela.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conUserLinkRela.LinkName)
{
return mstrLinkName;
}
else if (strAttributeName  ==  conUserLinkRela.DataBaseTypeId)
{
return mstrDataBaseTypeId;
}
else if (strAttributeName  ==  conUserLinkRela.IpAddress)
{
return mstrIpAddress;
}
else if (strAttributeName  ==  conUserLinkRela.DataBaseName)
{
return mstrDataBaseName;
}
else if (strAttributeName  ==  conUserLinkRela.Sid)
{
return mstrSid;
}
else if (strAttributeName  ==  conUserLinkRela.DataBaseUserId)
{
return mstrDataBaseUserId;
}
else if (strAttributeName  ==  conUserLinkRela.DataBasePwd)
{
return mstrDataBasePwd;
}
else if (strAttributeName  ==  conUserLinkRela.ConnectionString)
{
return mstrConnectionString;
}
else if (strAttributeName  ==  conUserLinkRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conUserLinkRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUserLinkRela.mId);
}
else if (strAttributeName  ==  conUserLinkRela.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conUserLinkRela.UserId);
}
else if (strAttributeName  ==  conUserLinkRela.LinkName)
{
mstrLinkName = value.ToString();
 AddUpdatedFld(conUserLinkRela.LinkName);
}
else if (strAttributeName  ==  conUserLinkRela.DataBaseTypeId)
{
mstrDataBaseTypeId = value.ToString();
 AddUpdatedFld(conUserLinkRela.DataBaseTypeId);
}
else if (strAttributeName  ==  conUserLinkRela.IpAddress)
{
mstrIpAddress = value.ToString();
 AddUpdatedFld(conUserLinkRela.IpAddress);
}
else if (strAttributeName  ==  conUserLinkRela.DataBaseName)
{
mstrDataBaseName = value.ToString();
 AddUpdatedFld(conUserLinkRela.DataBaseName);
}
else if (strAttributeName  ==  conUserLinkRela.Sid)
{
mstrSid = value.ToString();
 AddUpdatedFld(conUserLinkRela.Sid);
}
else if (strAttributeName  ==  conUserLinkRela.DataBaseUserId)
{
mstrDataBaseUserId = value.ToString();
 AddUpdatedFld(conUserLinkRela.DataBaseUserId);
}
else if (strAttributeName  ==  conUserLinkRela.DataBasePwd)
{
mstrDataBasePwd = value.ToString();
 AddUpdatedFld(conUserLinkRela.DataBasePwd);
}
else if (strAttributeName  ==  conUserLinkRela.ConnectionString)
{
mstrConnectionString = value.ToString();
 AddUpdatedFld(conUserLinkRela.ConnectionString);
}
else if (strAttributeName  ==  conUserLinkRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conUserLinkRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conUserLinkRela.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (conUserLinkRela.UserId  ==  _AttributeName[intIndex])
{
return mstrUserId;
}
else if (conUserLinkRela.LinkName  ==  _AttributeName[intIndex])
{
return mstrLinkName;
}
else if (conUserLinkRela.DataBaseTypeId  ==  _AttributeName[intIndex])
{
return mstrDataBaseTypeId;
}
else if (conUserLinkRela.IpAddress  ==  _AttributeName[intIndex])
{
return mstrIpAddress;
}
else if (conUserLinkRela.DataBaseName  ==  _AttributeName[intIndex])
{
return mstrDataBaseName;
}
else if (conUserLinkRela.Sid  ==  _AttributeName[intIndex])
{
return mstrSid;
}
else if (conUserLinkRela.DataBaseUserId  ==  _AttributeName[intIndex])
{
return mstrDataBaseUserId;
}
else if (conUserLinkRela.DataBasePwd  ==  _AttributeName[intIndex])
{
return mstrDataBasePwd;
}
else if (conUserLinkRela.ConnectionString  ==  _AttributeName[intIndex])
{
return mstrConnectionString;
}
else if (conUserLinkRela.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conUserLinkRela.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUserLinkRela.mId);
}
else if (conUserLinkRela.UserId  ==  _AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conUserLinkRela.UserId);
}
else if (conUserLinkRela.LinkName  ==  _AttributeName[intIndex])
{
mstrLinkName = value.ToString();
 AddUpdatedFld(conUserLinkRela.LinkName);
}
else if (conUserLinkRela.DataBaseTypeId  ==  _AttributeName[intIndex])
{
mstrDataBaseTypeId = value.ToString();
 AddUpdatedFld(conUserLinkRela.DataBaseTypeId);
}
else if (conUserLinkRela.IpAddress  ==  _AttributeName[intIndex])
{
mstrIpAddress = value.ToString();
 AddUpdatedFld(conUserLinkRela.IpAddress);
}
else if (conUserLinkRela.DataBaseName  ==  _AttributeName[intIndex])
{
mstrDataBaseName = value.ToString();
 AddUpdatedFld(conUserLinkRela.DataBaseName);
}
else if (conUserLinkRela.Sid  ==  _AttributeName[intIndex])
{
mstrSid = value.ToString();
 AddUpdatedFld(conUserLinkRela.Sid);
}
else if (conUserLinkRela.DataBaseUserId  ==  _AttributeName[intIndex])
{
mstrDataBaseUserId = value.ToString();
 AddUpdatedFld(conUserLinkRela.DataBaseUserId);
}
else if (conUserLinkRela.DataBasePwd  ==  _AttributeName[intIndex])
{
mstrDataBasePwd = value.ToString();
 AddUpdatedFld(conUserLinkRela.DataBasePwd);
}
else if (conUserLinkRela.ConnectionString  ==  _AttributeName[intIndex])
{
mstrConnectionString = value.ToString();
 AddUpdatedFld(conUserLinkRela.ConnectionString);
}
else if (conUserLinkRela.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conUserLinkRela.Memo);
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
 AddUpdatedFld(conUserLinkRela.mId);
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
 AddUpdatedFld(conUserLinkRela.UserId);
}
}
/// <summary>
/// 链接名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LinkName
{
get
{
return mstrLinkName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLinkName = value;
}
else
{
 mstrLinkName = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserLinkRela.LinkName);
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
 AddUpdatedFld(conUserLinkRela.DataBaseTypeId);
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
 AddUpdatedFld(conUserLinkRela.IpAddress);
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
 AddUpdatedFld(conUserLinkRela.DataBaseName);
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
 AddUpdatedFld(conUserLinkRela.Sid);
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
 AddUpdatedFld(conUserLinkRela.DataBaseUserId);
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
 AddUpdatedFld(conUserLinkRela.DataBasePwd);
}
}
/// <summary>
/// 连接串(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ConnectionString
{
get
{
return mstrConnectionString;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrConnectionString = value;
}
else
{
 mstrConnectionString = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserLinkRela.ConnectionString);
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
 AddUpdatedFld(conUserLinkRela.Memo);
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
 /// 用户链接关系(UserLinkRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conUserLinkRela
{
public const string _CurrTabName = "UserLinkRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "UserId", "LinkName", "DataBaseTypeId", "IpAddress", "DataBaseName", "Sid", "DataBaseUserId", "DataBasePwd", "ConnectionString", "Memo"};
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
 /// 常量:"LinkName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LinkName = "LinkName";    //链接名称

 /// <summary>
 /// 常量:"DataBaseTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataBaseTypeId = "DataBaseTypeId";    //数据库类型ID

 /// <summary>
 /// 常量:"IpAddress"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IpAddress = "IpAddress";    //服务器

 /// <summary>
 /// 常量:"DataBaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataBaseName = "DataBaseName";    //数据库名

 /// <summary>
 /// 常量:"Sid"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Sid = "Sid";    //SID

 /// <summary>
 /// 常量:"DataBaseUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataBaseUserId = "DataBaseUserId";    //数据库的用户ID

 /// <summary>
 /// 常量:"DataBasePwd"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataBasePwd = "DataBasePwd";    //数据库的用户口令

 /// <summary>
 /// 常量:"ConnectionString"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConnectionString = "ConnectionString";    //连接串

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}