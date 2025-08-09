
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvUserDefaPrjDataBaseEN
 表名:vUserDefaPrjDataBase(00050275)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:11:48
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统设置(SystemSet)
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
 /// 表vUserDefaPrjDataBase的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vUserDefaPrjDataBase
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
public K_mId_vUserDefaPrjDataBase(long lngmId)
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
 /// <returns>返回:[K_mId_vUserDefaPrjDataBase]类型的对象</returns>
public static implicit operator K_mId_vUserDefaPrjDataBase(long value)
{
return new K_mId_vUserDefaPrjDataBase(value);
}
}
 /// <summary>
 /// v用户默认数据库(vUserDefaPrjDataBase)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvUserDefaPrjDataBaseEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vUserDefaPrjDataBase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 13;
public static string[] _AttributeName = new string[] {"mId", "PrjId", "PrjName", "UserId", "UserName", "PrjDataBaseId", "PrjDataBaseName", "DataBaseName", "IpAddress", "DataBaseUserId", "UpdUserId", "UpdDate", "Memo"};

protected long mlngmId;    //mId
protected string mstrPrjId;    //工程Id
protected string mstrPrjName;    //工程名称
protected string mstrUserId;    //用户Id
protected string mstrUserName;    //用户名
protected string mstrPrjDataBaseId;    //项目数据库Id
protected string mstrPrjDataBaseName;    //项目数据库名
protected string mstrDataBaseName;    //数据库名
protected string mstrIpAddress;    //服务器
protected string mstrDataBaseUserId;    //数据库的用户ID
protected string mstrUpdUserId;    //修改用户Id
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvUserDefaPrjDataBaseEN()
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
public clsvUserDefaPrjDataBaseEN(long lngmId)
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
if (strAttributeName  ==  convUserDefaPrjDataBase.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convUserDefaPrjDataBase.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convUserDefaPrjDataBase.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convUserDefaPrjDataBase.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convUserDefaPrjDataBase.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convUserDefaPrjDataBase.PrjDataBaseId)
{
return mstrPrjDataBaseId;
}
else if (strAttributeName  ==  convUserDefaPrjDataBase.PrjDataBaseName)
{
return mstrPrjDataBaseName;
}
else if (strAttributeName  ==  convUserDefaPrjDataBase.DataBaseName)
{
return mstrDataBaseName;
}
else if (strAttributeName  ==  convUserDefaPrjDataBase.IpAddress)
{
return mstrIpAddress;
}
else if (strAttributeName  ==  convUserDefaPrjDataBase.DataBaseUserId)
{
return mstrDataBaseUserId;
}
else if (strAttributeName  ==  convUserDefaPrjDataBase.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convUserDefaPrjDataBase.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convUserDefaPrjDataBase.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convUserDefaPrjDataBase.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convUserDefaPrjDataBase.mId);
}
else if (strAttributeName  ==  convUserDefaPrjDataBase.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convUserDefaPrjDataBase.PrjId);
}
else if (strAttributeName  ==  convUserDefaPrjDataBase.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convUserDefaPrjDataBase.PrjName);
}
else if (strAttributeName  ==  convUserDefaPrjDataBase.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convUserDefaPrjDataBase.UserId);
}
else if (strAttributeName  ==  convUserDefaPrjDataBase.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convUserDefaPrjDataBase.UserName);
}
else if (strAttributeName  ==  convUserDefaPrjDataBase.PrjDataBaseId)
{
mstrPrjDataBaseId = value.ToString();
 AddUpdatedFld(convUserDefaPrjDataBase.PrjDataBaseId);
}
else if (strAttributeName  ==  convUserDefaPrjDataBase.PrjDataBaseName)
{
mstrPrjDataBaseName = value.ToString();
 AddUpdatedFld(convUserDefaPrjDataBase.PrjDataBaseName);
}
else if (strAttributeName  ==  convUserDefaPrjDataBase.DataBaseName)
{
mstrDataBaseName = value.ToString();
 AddUpdatedFld(convUserDefaPrjDataBase.DataBaseName);
}
else if (strAttributeName  ==  convUserDefaPrjDataBase.IpAddress)
{
mstrIpAddress = value.ToString();
 AddUpdatedFld(convUserDefaPrjDataBase.IpAddress);
}
else if (strAttributeName  ==  convUserDefaPrjDataBase.DataBaseUserId)
{
mstrDataBaseUserId = value.ToString();
 AddUpdatedFld(convUserDefaPrjDataBase.DataBaseUserId);
}
else if (strAttributeName  ==  convUserDefaPrjDataBase.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convUserDefaPrjDataBase.UpdUserId);
}
else if (strAttributeName  ==  convUserDefaPrjDataBase.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convUserDefaPrjDataBase.UpdDate);
}
else if (strAttributeName  ==  convUserDefaPrjDataBase.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convUserDefaPrjDataBase.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convUserDefaPrjDataBase.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (convUserDefaPrjDataBase.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convUserDefaPrjDataBase.PrjName  ==  _AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convUserDefaPrjDataBase.UserId  ==  _AttributeName[intIndex])
{
return mstrUserId;
}
else if (convUserDefaPrjDataBase.UserName  ==  _AttributeName[intIndex])
{
return mstrUserName;
}
else if (convUserDefaPrjDataBase.PrjDataBaseId  ==  _AttributeName[intIndex])
{
return mstrPrjDataBaseId;
}
else if (convUserDefaPrjDataBase.PrjDataBaseName  ==  _AttributeName[intIndex])
{
return mstrPrjDataBaseName;
}
else if (convUserDefaPrjDataBase.DataBaseName  ==  _AttributeName[intIndex])
{
return mstrDataBaseName;
}
else if (convUserDefaPrjDataBase.IpAddress  ==  _AttributeName[intIndex])
{
return mstrIpAddress;
}
else if (convUserDefaPrjDataBase.DataBaseUserId  ==  _AttributeName[intIndex])
{
return mstrDataBaseUserId;
}
else if (convUserDefaPrjDataBase.UpdUserId  ==  _AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convUserDefaPrjDataBase.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convUserDefaPrjDataBase.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convUserDefaPrjDataBase.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convUserDefaPrjDataBase.mId);
}
else if (convUserDefaPrjDataBase.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convUserDefaPrjDataBase.PrjId);
}
else if (convUserDefaPrjDataBase.PrjName  ==  _AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convUserDefaPrjDataBase.PrjName);
}
else if (convUserDefaPrjDataBase.UserId  ==  _AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convUserDefaPrjDataBase.UserId);
}
else if (convUserDefaPrjDataBase.UserName  ==  _AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convUserDefaPrjDataBase.UserName);
}
else if (convUserDefaPrjDataBase.PrjDataBaseId  ==  _AttributeName[intIndex])
{
mstrPrjDataBaseId = value.ToString();
 AddUpdatedFld(convUserDefaPrjDataBase.PrjDataBaseId);
}
else if (convUserDefaPrjDataBase.PrjDataBaseName  ==  _AttributeName[intIndex])
{
mstrPrjDataBaseName = value.ToString();
 AddUpdatedFld(convUserDefaPrjDataBase.PrjDataBaseName);
}
else if (convUserDefaPrjDataBase.DataBaseName  ==  _AttributeName[intIndex])
{
mstrDataBaseName = value.ToString();
 AddUpdatedFld(convUserDefaPrjDataBase.DataBaseName);
}
else if (convUserDefaPrjDataBase.IpAddress  ==  _AttributeName[intIndex])
{
mstrIpAddress = value.ToString();
 AddUpdatedFld(convUserDefaPrjDataBase.IpAddress);
}
else if (convUserDefaPrjDataBase.DataBaseUserId  ==  _AttributeName[intIndex])
{
mstrDataBaseUserId = value.ToString();
 AddUpdatedFld(convUserDefaPrjDataBase.DataBaseUserId);
}
else if (convUserDefaPrjDataBase.UpdUserId  ==  _AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convUserDefaPrjDataBase.UpdUserId);
}
else if (convUserDefaPrjDataBase.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convUserDefaPrjDataBase.UpdDate);
}
else if (convUserDefaPrjDataBase.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convUserDefaPrjDataBase.Memo);
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
 AddUpdatedFld(convUserDefaPrjDataBase.mId);
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
 AddUpdatedFld(convUserDefaPrjDataBase.PrjId);
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
 AddUpdatedFld(convUserDefaPrjDataBase.PrjName);
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
 AddUpdatedFld(convUserDefaPrjDataBase.UserId);
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
 AddUpdatedFld(convUserDefaPrjDataBase.UserName);
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
 AddUpdatedFld(convUserDefaPrjDataBase.PrjDataBaseId);
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
 AddUpdatedFld(convUserDefaPrjDataBase.PrjDataBaseName);
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
 AddUpdatedFld(convUserDefaPrjDataBase.DataBaseName);
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
 AddUpdatedFld(convUserDefaPrjDataBase.IpAddress);
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
 AddUpdatedFld(convUserDefaPrjDataBase.DataBaseUserId);
}
}
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUserId
{
get
{
return mstrUpdUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUserId = value;
}
else
{
 mstrUpdUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(convUserDefaPrjDataBase.UpdUserId);
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
 AddUpdatedFld(convUserDefaPrjDataBase.UpdDate);
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
 AddUpdatedFld(convUserDefaPrjDataBase.Memo);
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
 /// v用户默认数据库(vUserDefaPrjDataBase)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convUserDefaPrjDataBase
{
public const string _CurrTabName = "vUserDefaPrjDataBase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "PrjId", "PrjName", "UserId", "UserName", "PrjDataBaseId", "PrjDataBaseName", "DataBaseName", "IpAddress", "DataBaseUserId", "UpdUserId", "UpdDate", "Memo"};
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
 /// 常量:"IpAddress"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IpAddress = "IpAddress";    //服务器

 /// <summary>
 /// 常量:"DataBaseUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataBaseUserId = "DataBaseUserId";    //数据库的用户ID

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

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