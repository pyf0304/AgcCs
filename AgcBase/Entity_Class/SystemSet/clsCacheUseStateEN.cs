
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCacheUseStateEN
 表名:CacheUseState(00050566)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:00:58
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
 /// 表CacheUseState的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_CacheUseState
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
public K_mId_CacheUseState(long lngmId)
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
 /// <returns>返回:[K_mId_CacheUseState]类型的对象</returns>
public static implicit operator K_mId_CacheUseState(long value)
{
return new K_mId_CacheUseState(value);
}
}
 /// <summary>
 /// 缓存使用状态(CacheUseState)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCacheUseStateEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CacheUseState"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 7;
public static string[] _AttributeName = new string[] {"mId", "UserId", "CacheModeId", "CacheKey", "CacheSize", "UseDate", "Memo"};

protected long mlngmId;    //mId
protected string mstrUserId;    //用户Id
protected string mstrCacheModeId;    //缓存方式Id
protected string mstrCacheKey;    //缓存关键字
protected int? mintCacheSize;    //缓存大小
protected string mstrUseDate;    //使用日期
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsCacheUseStateEN()
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
public clsCacheUseStateEN(long lngmId)
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
if (strAttributeName  ==  conCacheUseState.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conCacheUseState.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conCacheUseState.CacheModeId)
{
return mstrCacheModeId;
}
else if (strAttributeName  ==  conCacheUseState.CacheKey)
{
return mstrCacheKey;
}
else if (strAttributeName  ==  conCacheUseState.CacheSize)
{
return mintCacheSize;
}
else if (strAttributeName  ==  conCacheUseState.UseDate)
{
return mstrUseDate;
}
else if (strAttributeName  ==  conCacheUseState.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conCacheUseState.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conCacheUseState.mId);
}
else if (strAttributeName  ==  conCacheUseState.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conCacheUseState.UserId);
}
else if (strAttributeName  ==  conCacheUseState.CacheModeId)
{
mstrCacheModeId = value.ToString();
 AddUpdatedFld(conCacheUseState.CacheModeId);
}
else if (strAttributeName  ==  conCacheUseState.CacheKey)
{
mstrCacheKey = value.ToString();
 AddUpdatedFld(conCacheUseState.CacheKey);
}
else if (strAttributeName  ==  conCacheUseState.CacheSize)
{
mintCacheSize = TransNullToInt(value.ToString());
 AddUpdatedFld(conCacheUseState.CacheSize);
}
else if (strAttributeName  ==  conCacheUseState.UseDate)
{
mstrUseDate = value.ToString();
 AddUpdatedFld(conCacheUseState.UseDate);
}
else if (strAttributeName  ==  conCacheUseState.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCacheUseState.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conCacheUseState.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (conCacheUseState.UserId  ==  _AttributeName[intIndex])
{
return mstrUserId;
}
else if (conCacheUseState.CacheModeId  ==  _AttributeName[intIndex])
{
return mstrCacheModeId;
}
else if (conCacheUseState.CacheKey  ==  _AttributeName[intIndex])
{
return mstrCacheKey;
}
else if (conCacheUseState.CacheSize  ==  _AttributeName[intIndex])
{
return mintCacheSize;
}
else if (conCacheUseState.UseDate  ==  _AttributeName[intIndex])
{
return mstrUseDate;
}
else if (conCacheUseState.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conCacheUseState.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conCacheUseState.mId);
}
else if (conCacheUseState.UserId  ==  _AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conCacheUseState.UserId);
}
else if (conCacheUseState.CacheModeId  ==  _AttributeName[intIndex])
{
mstrCacheModeId = value.ToString();
 AddUpdatedFld(conCacheUseState.CacheModeId);
}
else if (conCacheUseState.CacheKey  ==  _AttributeName[intIndex])
{
mstrCacheKey = value.ToString();
 AddUpdatedFld(conCacheUseState.CacheKey);
}
else if (conCacheUseState.CacheSize  ==  _AttributeName[intIndex])
{
mintCacheSize = TransNullToInt(value.ToString());
 AddUpdatedFld(conCacheUseState.CacheSize);
}
else if (conCacheUseState.UseDate  ==  _AttributeName[intIndex])
{
mstrUseDate = value.ToString();
 AddUpdatedFld(conCacheUseState.UseDate);
}
else if (conCacheUseState.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCacheUseState.Memo);
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
 AddUpdatedFld(conCacheUseState.mId);
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
 AddUpdatedFld(conCacheUseState.UserId);
}
}
/// <summary>
/// 缓存方式Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CacheModeId
{
get
{
return mstrCacheModeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCacheModeId = value;
}
else
{
 mstrCacheModeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCacheUseState.CacheModeId);
}
}
/// <summary>
/// 缓存关键字(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CacheKey
{
get
{
return mstrCacheKey;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCacheKey = value;
}
else
{
 mstrCacheKey = value;
}
//记录修改过的字段
 AddUpdatedFld(conCacheUseState.CacheKey);
}
}
/// <summary>
/// 缓存大小(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? CacheSize
{
get
{
return mintCacheSize;
}
set
{
 mintCacheSize = value;
//记录修改过的字段
 AddUpdatedFld(conCacheUseState.CacheSize);
}
}
/// <summary>
/// 使用日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UseDate
{
get
{
return mstrUseDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUseDate = value;
}
else
{
 mstrUseDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conCacheUseState.UseDate);
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
 AddUpdatedFld(conCacheUseState.Memo);
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

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrUserId;
 }
 }
}
 /// <summary>
 /// 缓存使用状态(CacheUseState)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCacheUseState
{
public const string _CurrTabName = "CacheUseState"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "UserId", "CacheModeId", "CacheKey", "CacheSize", "UseDate", "Memo"};
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
 /// 常量:"CacheModeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CacheModeId = "CacheModeId";    //缓存方式Id

 /// <summary>
 /// 常量:"CacheKey"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CacheKey = "CacheKey";    //缓存关键字

 /// <summary>
 /// 常量:"CacheSize"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CacheSize = "CacheSize";    //缓存大小

 /// <summary>
 /// 常量:"UseDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UseDate = "UseDate";    //使用日期

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}