
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvUserLinkRelaEN
 表名:vUserLinkRela(00050166)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:48:10
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
 /// 表vUserLinkRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vUserLinkRela
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
public K_mId_vUserLinkRela(long lngmId)
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
 /// <returns>返回:[K_mId_vUserLinkRela]类型的对象</returns>
public static implicit operator K_mId_vUserLinkRela(long value)
{
return new K_mId_vUserLinkRela(value);
}
}
 /// <summary>
 /// v用户链接关系(vUserLinkRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvUserLinkRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vUserLinkRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 12;
public static string[] _AttributeName = new string[] {"mId", "UserId", "LinkName", "DataBaseTypeName", "DataBaseTypeId", "IpAddress", "DataBasePwd", "DataBaseUserId", "DataBaseName", "Sid", "ConnectionString", "Memo"};

protected long mlngmId;    //mId
protected string mstrUserId;    //用户Id
protected string mstrLinkName;    //链接名称
protected string mstrDataBaseTypeName;    //数据库类型名
protected string mstrDataBaseTypeId;    //数据库类型ID
protected string mstrIpAddress;    //服务器
protected string mstrDataBasePwd;    //数据库的用户口令
protected string mstrDataBaseUserId;    //数据库的用户ID
protected string mstrDataBaseName;    //数据库名
protected string mstrSid;    //SID
protected string mstrConnectionString;    //连接串
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvUserLinkRelaEN()
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
public clsvUserLinkRelaEN(long lngmId)
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
if (strAttributeName  ==  convUserLinkRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convUserLinkRela.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convUserLinkRela.LinkName)
{
return mstrLinkName;
}
else if (strAttributeName  ==  convUserLinkRela.DataBaseTypeName)
{
return mstrDataBaseTypeName;
}
else if (strAttributeName  ==  convUserLinkRela.DataBaseTypeId)
{
return mstrDataBaseTypeId;
}
else if (strAttributeName  ==  convUserLinkRela.IpAddress)
{
return mstrIpAddress;
}
else if (strAttributeName  ==  convUserLinkRela.DataBasePwd)
{
return mstrDataBasePwd;
}
else if (strAttributeName  ==  convUserLinkRela.DataBaseUserId)
{
return mstrDataBaseUserId;
}
else if (strAttributeName  ==  convUserLinkRela.DataBaseName)
{
return mstrDataBaseName;
}
else if (strAttributeName  ==  convUserLinkRela.Sid)
{
return mstrSid;
}
else if (strAttributeName  ==  convUserLinkRela.ConnectionString)
{
return mstrConnectionString;
}
else if (strAttributeName  ==  convUserLinkRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convUserLinkRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convUserLinkRela.mId);
}
else if (strAttributeName  ==  convUserLinkRela.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convUserLinkRela.UserId);
}
else if (strAttributeName  ==  convUserLinkRela.LinkName)
{
mstrLinkName = value.ToString();
 AddUpdatedFld(convUserLinkRela.LinkName);
}
else if (strAttributeName  ==  convUserLinkRela.DataBaseTypeName)
{
mstrDataBaseTypeName = value.ToString();
 AddUpdatedFld(convUserLinkRela.DataBaseTypeName);
}
else if (strAttributeName  ==  convUserLinkRela.DataBaseTypeId)
{
mstrDataBaseTypeId = value.ToString();
 AddUpdatedFld(convUserLinkRela.DataBaseTypeId);
}
else if (strAttributeName  ==  convUserLinkRela.IpAddress)
{
mstrIpAddress = value.ToString();
 AddUpdatedFld(convUserLinkRela.IpAddress);
}
else if (strAttributeName  ==  convUserLinkRela.DataBasePwd)
{
mstrDataBasePwd = value.ToString();
 AddUpdatedFld(convUserLinkRela.DataBasePwd);
}
else if (strAttributeName  ==  convUserLinkRela.DataBaseUserId)
{
mstrDataBaseUserId = value.ToString();
 AddUpdatedFld(convUserLinkRela.DataBaseUserId);
}
else if (strAttributeName  ==  convUserLinkRela.DataBaseName)
{
mstrDataBaseName = value.ToString();
 AddUpdatedFld(convUserLinkRela.DataBaseName);
}
else if (strAttributeName  ==  convUserLinkRela.Sid)
{
mstrSid = value.ToString();
 AddUpdatedFld(convUserLinkRela.Sid);
}
else if (strAttributeName  ==  convUserLinkRela.ConnectionString)
{
mstrConnectionString = value.ToString();
 AddUpdatedFld(convUserLinkRela.ConnectionString);
}
else if (strAttributeName  ==  convUserLinkRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convUserLinkRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convUserLinkRela.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (convUserLinkRela.UserId  ==  _AttributeName[intIndex])
{
return mstrUserId;
}
else if (convUserLinkRela.LinkName  ==  _AttributeName[intIndex])
{
return mstrLinkName;
}
else if (convUserLinkRela.DataBaseTypeName  ==  _AttributeName[intIndex])
{
return mstrDataBaseTypeName;
}
else if (convUserLinkRela.DataBaseTypeId  ==  _AttributeName[intIndex])
{
return mstrDataBaseTypeId;
}
else if (convUserLinkRela.IpAddress  ==  _AttributeName[intIndex])
{
return mstrIpAddress;
}
else if (convUserLinkRela.DataBasePwd  ==  _AttributeName[intIndex])
{
return mstrDataBasePwd;
}
else if (convUserLinkRela.DataBaseUserId  ==  _AttributeName[intIndex])
{
return mstrDataBaseUserId;
}
else if (convUserLinkRela.DataBaseName  ==  _AttributeName[intIndex])
{
return mstrDataBaseName;
}
else if (convUserLinkRela.Sid  ==  _AttributeName[intIndex])
{
return mstrSid;
}
else if (convUserLinkRela.ConnectionString  ==  _AttributeName[intIndex])
{
return mstrConnectionString;
}
else if (convUserLinkRela.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convUserLinkRela.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convUserLinkRela.mId);
}
else if (convUserLinkRela.UserId  ==  _AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convUserLinkRela.UserId);
}
else if (convUserLinkRela.LinkName  ==  _AttributeName[intIndex])
{
mstrLinkName = value.ToString();
 AddUpdatedFld(convUserLinkRela.LinkName);
}
else if (convUserLinkRela.DataBaseTypeName  ==  _AttributeName[intIndex])
{
mstrDataBaseTypeName = value.ToString();
 AddUpdatedFld(convUserLinkRela.DataBaseTypeName);
}
else if (convUserLinkRela.DataBaseTypeId  ==  _AttributeName[intIndex])
{
mstrDataBaseTypeId = value.ToString();
 AddUpdatedFld(convUserLinkRela.DataBaseTypeId);
}
else if (convUserLinkRela.IpAddress  ==  _AttributeName[intIndex])
{
mstrIpAddress = value.ToString();
 AddUpdatedFld(convUserLinkRela.IpAddress);
}
else if (convUserLinkRela.DataBasePwd  ==  _AttributeName[intIndex])
{
mstrDataBasePwd = value.ToString();
 AddUpdatedFld(convUserLinkRela.DataBasePwd);
}
else if (convUserLinkRela.DataBaseUserId  ==  _AttributeName[intIndex])
{
mstrDataBaseUserId = value.ToString();
 AddUpdatedFld(convUserLinkRela.DataBaseUserId);
}
else if (convUserLinkRela.DataBaseName  ==  _AttributeName[intIndex])
{
mstrDataBaseName = value.ToString();
 AddUpdatedFld(convUserLinkRela.DataBaseName);
}
else if (convUserLinkRela.Sid  ==  _AttributeName[intIndex])
{
mstrSid = value.ToString();
 AddUpdatedFld(convUserLinkRela.Sid);
}
else if (convUserLinkRela.ConnectionString  ==  _AttributeName[intIndex])
{
mstrConnectionString = value.ToString();
 AddUpdatedFld(convUserLinkRela.ConnectionString);
}
else if (convUserLinkRela.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convUserLinkRela.Memo);
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
 AddUpdatedFld(convUserLinkRela.mId);
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
 AddUpdatedFld(convUserLinkRela.UserId);
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
 AddUpdatedFld(convUserLinkRela.LinkName);
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
 AddUpdatedFld(convUserLinkRela.DataBaseTypeName);
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
 AddUpdatedFld(convUserLinkRela.DataBaseTypeId);
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
 AddUpdatedFld(convUserLinkRela.IpAddress);
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
 AddUpdatedFld(convUserLinkRela.DataBasePwd);
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
 AddUpdatedFld(convUserLinkRela.DataBaseUserId);
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
 AddUpdatedFld(convUserLinkRela.DataBaseName);
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
 AddUpdatedFld(convUserLinkRela.Sid);
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
 AddUpdatedFld(convUserLinkRela.ConnectionString);
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
 AddUpdatedFld(convUserLinkRela.Memo);
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
 /// v用户链接关系(vUserLinkRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convUserLinkRela
{
public const string _CurrTabName = "vUserLinkRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "UserId", "LinkName", "DataBaseTypeName", "DataBaseTypeId", "IpAddress", "DataBasePwd", "DataBaseUserId", "DataBaseName", "Sid", "ConnectionString", "Memo"};
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
 /// 常量:"IpAddress"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IpAddress = "IpAddress";    //服务器

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