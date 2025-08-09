
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUserDefaValue_LocalEN
 表名:UserDefaValue_Local(00050089)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:10:04
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
 /// 表UserDefaValue_Local的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_UserDefaValue_Local
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
public K_mId_UserDefaValue_Local(long lngmId)
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
 /// <returns>返回:[K_mId_UserDefaValue_Local]类型的对象</returns>
public static implicit operator K_mId_UserDefaValue_Local(long value)
{
return new K_mId_UserDefaValue_Local(value);
}
}
 /// <summary>
 /// 用户缺省值(UserDefaValue_Local)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsUserDefaValue_LocalEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "UserDefaValue_Local"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 8;
public static string[] _AttributeName = new string[] {"mId", "DefaValNameId", "UserId", "UserDefaValue", "PrjId", "UpdDate", "UpdUserId", "Memo"};

protected long mlngmId;    //mId
protected string mstrDefaValNameId;    //DefaValNameId
protected string mstrUserId;    //用户Id
protected string mstrUserDefaValue;    //UserDefaValue
protected string mstrPrjId;    //工程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsUserDefaValue_LocalEN()
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
public clsUserDefaValue_LocalEN(long lngmId)
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
if (strAttributeName  ==  conUserDefaValue_Local.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conUserDefaValue_Local.DefaValNameId)
{
return mstrDefaValNameId;
}
else if (strAttributeName  ==  conUserDefaValue_Local.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conUserDefaValue_Local.UserDefaValue)
{
return mstrUserDefaValue;
}
else if (strAttributeName  ==  conUserDefaValue_Local.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conUserDefaValue_Local.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conUserDefaValue_Local.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conUserDefaValue_Local.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conUserDefaValue_Local.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUserDefaValue_Local.mId);
}
else if (strAttributeName  ==  conUserDefaValue_Local.DefaValNameId)
{
mstrDefaValNameId = value.ToString();
 AddUpdatedFld(conUserDefaValue_Local.DefaValNameId);
}
else if (strAttributeName  ==  conUserDefaValue_Local.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conUserDefaValue_Local.UserId);
}
else if (strAttributeName  ==  conUserDefaValue_Local.UserDefaValue)
{
mstrUserDefaValue = value.ToString();
 AddUpdatedFld(conUserDefaValue_Local.UserDefaValue);
}
else if (strAttributeName  ==  conUserDefaValue_Local.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conUserDefaValue_Local.PrjId);
}
else if (strAttributeName  ==  conUserDefaValue_Local.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conUserDefaValue_Local.UpdDate);
}
else if (strAttributeName  ==  conUserDefaValue_Local.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conUserDefaValue_Local.UpdUserId);
}
else if (strAttributeName  ==  conUserDefaValue_Local.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conUserDefaValue_Local.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conUserDefaValue_Local.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (conUserDefaValue_Local.DefaValNameId  ==  _AttributeName[intIndex])
{
return mstrDefaValNameId;
}
else if (conUserDefaValue_Local.UserId  ==  _AttributeName[intIndex])
{
return mstrUserId;
}
else if (conUserDefaValue_Local.UserDefaValue  ==  _AttributeName[intIndex])
{
return mstrUserDefaValue;
}
else if (conUserDefaValue_Local.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conUserDefaValue_Local.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conUserDefaValue_Local.UpdUserId  ==  _AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conUserDefaValue_Local.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conUserDefaValue_Local.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUserDefaValue_Local.mId);
}
else if (conUserDefaValue_Local.DefaValNameId  ==  _AttributeName[intIndex])
{
mstrDefaValNameId = value.ToString();
 AddUpdatedFld(conUserDefaValue_Local.DefaValNameId);
}
else if (conUserDefaValue_Local.UserId  ==  _AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conUserDefaValue_Local.UserId);
}
else if (conUserDefaValue_Local.UserDefaValue  ==  _AttributeName[intIndex])
{
mstrUserDefaValue = value.ToString();
 AddUpdatedFld(conUserDefaValue_Local.UserDefaValue);
}
else if (conUserDefaValue_Local.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conUserDefaValue_Local.PrjId);
}
else if (conUserDefaValue_Local.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conUserDefaValue_Local.UpdDate);
}
else if (conUserDefaValue_Local.UpdUserId  ==  _AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conUserDefaValue_Local.UpdUserId);
}
else if (conUserDefaValue_Local.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conUserDefaValue_Local.Memo);
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
 AddUpdatedFld(conUserDefaValue_Local.mId);
}
}
/// <summary>
/// DefaValNameId(说明:;字段类型:varchar;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DefaValNameId
{
get
{
return mstrDefaValNameId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDefaValNameId = value;
}
else
{
 mstrDefaValNameId = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserDefaValue_Local.DefaValNameId);
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
 AddUpdatedFld(conUserDefaValue_Local.UserId);
}
}
/// <summary>
/// UserDefaValue(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserDefaValue
{
get
{
return mstrUserDefaValue;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserDefaValue = value;
}
else
{
 mstrUserDefaValue = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserDefaValue_Local.UserDefaValue);
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
 AddUpdatedFld(conUserDefaValue_Local.PrjId);
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
 AddUpdatedFld(conUserDefaValue_Local.UpdDate);
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
 AddUpdatedFld(conUserDefaValue_Local.UpdUserId);
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
 AddUpdatedFld(conUserDefaValue_Local.Memo);
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
 /// 用户缺省值(UserDefaValue_Local)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conUserDefaValue_Local
{
public const string _CurrTabName = "UserDefaValue_Local"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "DefaValNameId", "UserId", "UserDefaValue", "PrjId", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"DefaValNameId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DefaValNameId = "DefaValNameId";    //DefaValNameId

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户Id

 /// <summary>
 /// 常量:"UserDefaValue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserDefaValue = "UserDefaValue";    //UserDefaValue

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}