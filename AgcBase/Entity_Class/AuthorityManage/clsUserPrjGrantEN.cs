
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUserPrjGrantEN
 表名:UserPrjGrant(00050092)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:29:14
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
 /// 表UserPrjGrant的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_UserPrjGrant
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
public K_mId_UserPrjGrant(long lngmId)
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
 /// <returns>返回:[K_mId_UserPrjGrant]类型的对象</returns>
public static implicit operator K_mId_UserPrjGrant(long value)
{
return new K_mId_UserPrjGrant(value);
}
}
 /// <summary>
 /// UserPrjGrant(UserPrjGrant)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsUserPrjGrantEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "UserPrjGrant"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 9;
public static string[] _AttributeName = new string[] {"mId", "UserId", "PrjId", "RoleId", "VisitedNum", "LastVisitedDate", "OptId", "OptDate", "Memo"};

protected long mlngmId;    //mId
protected string mstrUserId;    //用户Id
protected string mstrPrjId;    //工程Id
protected string mstrRoleId;    //角色ID
protected int? mintVisitedNum;    //访问数
protected string mstrLastVisitedDate;    //最后访问时间
protected string mstrOptId;    //操作者Id
protected string mstrOptDate;    //操作日期
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsUserPrjGrantEN()
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
public clsUserPrjGrantEN(long lngmId)
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
if (strAttributeName  ==  conUserPrjGrant.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conUserPrjGrant.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conUserPrjGrant.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conUserPrjGrant.RoleId)
{
return mstrRoleId;
}
else if (strAttributeName  ==  conUserPrjGrant.VisitedNum)
{
return mintVisitedNum;
}
else if (strAttributeName  ==  conUserPrjGrant.LastVisitedDate)
{
return mstrLastVisitedDate;
}
else if (strAttributeName  ==  conUserPrjGrant.OptId)
{
return mstrOptId;
}
else if (strAttributeName  ==  conUserPrjGrant.OptDate)
{
return mstrOptDate;
}
else if (strAttributeName  ==  conUserPrjGrant.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conUserPrjGrant.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUserPrjGrant.mId);
}
else if (strAttributeName  ==  conUserPrjGrant.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conUserPrjGrant.UserId);
}
else if (strAttributeName  ==  conUserPrjGrant.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conUserPrjGrant.PrjId);
}
else if (strAttributeName  ==  conUserPrjGrant.RoleId)
{
mstrRoleId = value.ToString();
 AddUpdatedFld(conUserPrjGrant.RoleId);
}
else if (strAttributeName  ==  conUserPrjGrant.VisitedNum)
{
mintVisitedNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conUserPrjGrant.VisitedNum);
}
else if (strAttributeName  ==  conUserPrjGrant.LastVisitedDate)
{
mstrLastVisitedDate = value.ToString();
 AddUpdatedFld(conUserPrjGrant.LastVisitedDate);
}
else if (strAttributeName  ==  conUserPrjGrant.OptId)
{
mstrOptId = value.ToString();
 AddUpdatedFld(conUserPrjGrant.OptId);
}
else if (strAttributeName  ==  conUserPrjGrant.OptDate)
{
mstrOptDate = value.ToString();
 AddUpdatedFld(conUserPrjGrant.OptDate);
}
else if (strAttributeName  ==  conUserPrjGrant.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conUserPrjGrant.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conUserPrjGrant.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (conUserPrjGrant.UserId  ==  _AttributeName[intIndex])
{
return mstrUserId;
}
else if (conUserPrjGrant.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conUserPrjGrant.RoleId  ==  _AttributeName[intIndex])
{
return mstrRoleId;
}
else if (conUserPrjGrant.VisitedNum  ==  _AttributeName[intIndex])
{
return mintVisitedNum;
}
else if (conUserPrjGrant.LastVisitedDate  ==  _AttributeName[intIndex])
{
return mstrLastVisitedDate;
}
else if (conUserPrjGrant.OptId  ==  _AttributeName[intIndex])
{
return mstrOptId;
}
else if (conUserPrjGrant.OptDate  ==  _AttributeName[intIndex])
{
return mstrOptDate;
}
else if (conUserPrjGrant.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conUserPrjGrant.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUserPrjGrant.mId);
}
else if (conUserPrjGrant.UserId  ==  _AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conUserPrjGrant.UserId);
}
else if (conUserPrjGrant.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conUserPrjGrant.PrjId);
}
else if (conUserPrjGrant.RoleId  ==  _AttributeName[intIndex])
{
mstrRoleId = value.ToString();
 AddUpdatedFld(conUserPrjGrant.RoleId);
}
else if (conUserPrjGrant.VisitedNum  ==  _AttributeName[intIndex])
{
mintVisitedNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conUserPrjGrant.VisitedNum);
}
else if (conUserPrjGrant.LastVisitedDate  ==  _AttributeName[intIndex])
{
mstrLastVisitedDate = value.ToString();
 AddUpdatedFld(conUserPrjGrant.LastVisitedDate);
}
else if (conUserPrjGrant.OptId  ==  _AttributeName[intIndex])
{
mstrOptId = value.ToString();
 AddUpdatedFld(conUserPrjGrant.OptId);
}
else if (conUserPrjGrant.OptDate  ==  _AttributeName[intIndex])
{
mstrOptDate = value.ToString();
 AddUpdatedFld(conUserPrjGrant.OptDate);
}
else if (conUserPrjGrant.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conUserPrjGrant.Memo);
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
 AddUpdatedFld(conUserPrjGrant.mId);
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
 AddUpdatedFld(conUserPrjGrant.UserId);
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
 AddUpdatedFld(conUserPrjGrant.PrjId);
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
 AddUpdatedFld(conUserPrjGrant.RoleId);
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
 AddUpdatedFld(conUserPrjGrant.VisitedNum);
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
 AddUpdatedFld(conUserPrjGrant.LastVisitedDate);
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
 AddUpdatedFld(conUserPrjGrant.OptId);
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
 AddUpdatedFld(conUserPrjGrant.OptDate);
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
 AddUpdatedFld(conUserPrjGrant.Memo);
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
 /// UserPrjGrant(UserPrjGrant)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conUserPrjGrant
{
public const string _CurrTabName = "UserPrjGrant"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "UserId", "PrjId", "RoleId", "VisitedNum", "LastVisitedDate", "OptId", "OptDate", "Memo"};
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
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"RoleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RoleId = "RoleId";    //角色ID

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
}

}