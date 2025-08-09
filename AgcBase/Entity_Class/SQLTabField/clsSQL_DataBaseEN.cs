
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSQL_DataBaseEN
 表名:SQL_DataBase(00050172)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:05:21
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:SQL表字段管理(SQLTabField)
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
 /// 表SQL_DataBase的关键字(DataBaseName)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_DataBaseName_SQL_DataBase
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strDataBaseName">表关键字</param>
public K_DataBaseName_SQL_DataBase(string strDataBaseName)
{
if (IsValid(strDataBaseName)) Value = strDataBaseName;
else
{
Value = null;
}
}
private static bool IsValid(string strDataBaseName)
{
if (string.IsNullOrEmpty(strDataBaseName) == true) return false;
if (strDataBaseName.Length > 50) return false;
if (strDataBaseName.IndexOf(' ') >= 0) return false;
if (strDataBaseName.IndexOf(')') >= 0) return false;
if (strDataBaseName.IndexOf('(') >= 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_DataBaseName_SQL_DataBase]类型的对象</returns>
public static implicit operator K_DataBaseName_SQL_DataBase(string value)
{
return new K_DataBaseName_SQL_DataBase(value);
}
}
 /// <summary>
 /// SQL数据库(SQL_DataBase)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsSQL_DataBaseEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "SQL_DataBase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "DataBaseName"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 8;
public static string[] _AttributeName = new string[] {"Server", "UserId", "Password", "UserIdForMaster", "PasswordForMaster", "PrjId", "DatabaseOwner", "DataBaseName"};

protected string mstrServer;    //服务器
protected string mstrUserId;    //用户Id
protected string mstrPassword;    //口令
protected string mstrUserIdForMaster;    //用户ID4Master
protected string mstrPasswordForMaster;    //口令4Master
protected string mstrPrjId;    //工程Id
protected string mstrDatabaseOwner;    //数据库拥有者
protected string mstrDataBaseName;    //数据库名

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsSQL_DataBaseEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("DataBaseName");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strDataBaseName">关键字:数据库名</param>
public clsSQL_DataBaseEN(string strDataBaseName)
 {
strDataBaseName = strDataBaseName.Replace("'", "''");
if (strDataBaseName.Length > 50)
{
throw new Exception("在表:SQL_DataBase中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strDataBaseName)  ==  true)
{
throw new Exception("在表:SQL_DataBase中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strDataBaseName);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrDataBaseName = strDataBaseName;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("DataBaseName");
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
if (strAttributeName  ==  conSQL_DataBase.Server)
{
return mstrServer;
}
else if (strAttributeName  ==  conSQL_DataBase.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conSQL_DataBase.Password)
{
return mstrPassword;
}
else if (strAttributeName  ==  conSQL_DataBase.UserIdForMaster)
{
return mstrUserIdForMaster;
}
else if (strAttributeName  ==  conSQL_DataBase.PasswordForMaster)
{
return mstrPasswordForMaster;
}
else if (strAttributeName  ==  conSQL_DataBase.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conSQL_DataBase.DatabaseOwner)
{
return mstrDatabaseOwner;
}
else if (strAttributeName  ==  conSQL_DataBase.DataBaseName)
{
return mstrDataBaseName;
}
return null;
}
set
{
if (strAttributeName  ==  conSQL_DataBase.Server)
{
mstrServer = value.ToString();
 AddUpdatedFld(conSQL_DataBase.Server);
}
else if (strAttributeName  ==  conSQL_DataBase.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conSQL_DataBase.UserId);
}
else if (strAttributeName  ==  conSQL_DataBase.Password)
{
mstrPassword = value.ToString();
 AddUpdatedFld(conSQL_DataBase.Password);
}
else if (strAttributeName  ==  conSQL_DataBase.UserIdForMaster)
{
mstrUserIdForMaster = value.ToString();
 AddUpdatedFld(conSQL_DataBase.UserIdForMaster);
}
else if (strAttributeName  ==  conSQL_DataBase.PasswordForMaster)
{
mstrPasswordForMaster = value.ToString();
 AddUpdatedFld(conSQL_DataBase.PasswordForMaster);
}
else if (strAttributeName  ==  conSQL_DataBase.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conSQL_DataBase.PrjId);
}
else if (strAttributeName  ==  conSQL_DataBase.DatabaseOwner)
{
mstrDatabaseOwner = value.ToString();
 AddUpdatedFld(conSQL_DataBase.DatabaseOwner);
}
else if (strAttributeName  ==  conSQL_DataBase.DataBaseName)
{
mstrDataBaseName = value.ToString();
 AddUpdatedFld(conSQL_DataBase.DataBaseName);
}
}
}
public object this[int intIndex]
{
get
{
if (conSQL_DataBase.Server  ==  _AttributeName[intIndex])
{
return mstrServer;
}
else if (conSQL_DataBase.UserId  ==  _AttributeName[intIndex])
{
return mstrUserId;
}
else if (conSQL_DataBase.Password  ==  _AttributeName[intIndex])
{
return mstrPassword;
}
else if (conSQL_DataBase.UserIdForMaster  ==  _AttributeName[intIndex])
{
return mstrUserIdForMaster;
}
else if (conSQL_DataBase.PasswordForMaster  ==  _AttributeName[intIndex])
{
return mstrPasswordForMaster;
}
else if (conSQL_DataBase.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conSQL_DataBase.DatabaseOwner  ==  _AttributeName[intIndex])
{
return mstrDatabaseOwner;
}
else if (conSQL_DataBase.DataBaseName  ==  _AttributeName[intIndex])
{
return mstrDataBaseName;
}
return null;
}
set
{
if (conSQL_DataBase.Server  ==  _AttributeName[intIndex])
{
mstrServer = value.ToString();
 AddUpdatedFld(conSQL_DataBase.Server);
}
else if (conSQL_DataBase.UserId  ==  _AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conSQL_DataBase.UserId);
}
else if (conSQL_DataBase.Password  ==  _AttributeName[intIndex])
{
mstrPassword = value.ToString();
 AddUpdatedFld(conSQL_DataBase.Password);
}
else if (conSQL_DataBase.UserIdForMaster  ==  _AttributeName[intIndex])
{
mstrUserIdForMaster = value.ToString();
 AddUpdatedFld(conSQL_DataBase.UserIdForMaster);
}
else if (conSQL_DataBase.PasswordForMaster  ==  _AttributeName[intIndex])
{
mstrPasswordForMaster = value.ToString();
 AddUpdatedFld(conSQL_DataBase.PasswordForMaster);
}
else if (conSQL_DataBase.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conSQL_DataBase.PrjId);
}
else if (conSQL_DataBase.DatabaseOwner  ==  _AttributeName[intIndex])
{
mstrDatabaseOwner = value.ToString();
 AddUpdatedFld(conSQL_DataBase.DatabaseOwner);
}
else if (conSQL_DataBase.DataBaseName  ==  _AttributeName[intIndex])
{
mstrDataBaseName = value.ToString();
 AddUpdatedFld(conSQL_DataBase.DataBaseName);
}
}
}

/// <summary>
/// 服务器(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Server
{
get
{
return mstrServer;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrServer = value;
}
else
{
 mstrServer = value;
}
//记录修改过的字段
 AddUpdatedFld(conSQL_DataBase.Server);
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
 AddUpdatedFld(conSQL_DataBase.UserId);
}
}
/// <summary>
/// 口令(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Password
{
get
{
return mstrPassword;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPassword = value;
}
else
{
 mstrPassword = value;
}
//记录修改过的字段
 AddUpdatedFld(conSQL_DataBase.Password);
}
}
/// <summary>
/// 用户ID4Master(说明:;字段类型:varchar;字段长度:18;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserIdForMaster
{
get
{
return mstrUserIdForMaster;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserIdForMaster = value;
}
else
{
 mstrUserIdForMaster = value;
}
//记录修改过的字段
 AddUpdatedFld(conSQL_DataBase.UserIdForMaster);
}
}
/// <summary>
/// 口令4Master(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PasswordForMaster
{
get
{
return mstrPasswordForMaster;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPasswordForMaster = value;
}
else
{
 mstrPasswordForMaster = value;
}
//记录修改过的字段
 AddUpdatedFld(conSQL_DataBase.PasswordForMaster);
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
 AddUpdatedFld(conSQL_DataBase.PrjId);
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
 AddUpdatedFld(conSQL_DataBase.DatabaseOwner);
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
 AddUpdatedFld(conSQL_DataBase.DataBaseName);
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
  return mstrDataBaseName;
 }
 }
}
 /// <summary>
 /// SQL数据库(SQL_DataBase)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conSQL_DataBase
{
public const string _CurrTabName = "SQL_DataBase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "DataBaseName"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"Server", "UserId", "Password", "UserIdForMaster", "PasswordForMaster", "PrjId", "DatabaseOwner", "DataBaseName"};
//以下是属性变量


 /// <summary>
 /// 常量:"Server"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Server = "Server";    //服务器

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户Id

 /// <summary>
 /// 常量:"Password"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Password = "Password";    //口令

 /// <summary>
 /// 常量:"UserIdForMaster"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserIdForMaster = "UserIdForMaster";    //用户ID4Master

 /// <summary>
 /// 常量:"PasswordForMaster"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PasswordForMaster = "PasswordForMaster";    //口令4Master

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"DatabaseOwner"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DatabaseOwner = "DatabaseOwner";    //数据库拥有者

 /// <summary>
 /// 常量:"DataBaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataBaseName = "DataBaseName";    //数据库名
}

}