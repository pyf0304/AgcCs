
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCacheUseStateEN
 表名:vCacheUseState(00050567)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:12:59
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
 /// 表vCacheUseState的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vCacheUseState
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
public K_mId_vCacheUseState(long lngmId)
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
 /// <returns>返回:[K_mId_vCacheUseState]类型的对象</returns>
public static implicit operator K_mId_vCacheUseState(long value)
{
return new K_mId_vCacheUseState(value);
}
}
 /// <summary>
 /// vCacheUseState(vCacheUseState)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvCacheUseStateEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vCacheUseState"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 9;
public static string[] _AttributeName = new string[] {"mId", "UserId", "CacheModeId", "CacheModeName", "CacheModeENName", "CacheKey", "CacheSize", "UseDate", "Memo"};

protected long mlngmId;    //mId
protected string mstrUserId;    //用户Id
protected string mstrCacheModeId;    //缓存方式Id
protected string mstrCacheModeName;    //缓存方式名
protected string mstrCacheModeENName;    //缓存方式英文名
protected string mstrCacheKey;    //缓存关键字
protected int? mintCacheSize;    //缓存大小
protected string mstrUseDate;    //使用日期
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvCacheUseStateEN()
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
public clsvCacheUseStateEN(long lngmId)
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
if (strAttributeName  ==  convCacheUseState.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convCacheUseState.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convCacheUseState.CacheModeId)
{
return mstrCacheModeId;
}
else if (strAttributeName  ==  convCacheUseState.CacheModeName)
{
return mstrCacheModeName;
}
else if (strAttributeName  ==  convCacheUseState.CacheModeENName)
{
return mstrCacheModeENName;
}
else if (strAttributeName  ==  convCacheUseState.CacheKey)
{
return mstrCacheKey;
}
else if (strAttributeName  ==  convCacheUseState.CacheSize)
{
return mintCacheSize;
}
else if (strAttributeName  ==  convCacheUseState.UseDate)
{
return mstrUseDate;
}
else if (strAttributeName  ==  convCacheUseState.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convCacheUseState.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convCacheUseState.mId);
}
else if (strAttributeName  ==  convCacheUseState.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convCacheUseState.UserId);
}
else if (strAttributeName  ==  convCacheUseState.CacheModeId)
{
mstrCacheModeId = value.ToString();
 AddUpdatedFld(convCacheUseState.CacheModeId);
}
else if (strAttributeName  ==  convCacheUseState.CacheModeName)
{
mstrCacheModeName = value.ToString();
 AddUpdatedFld(convCacheUseState.CacheModeName);
}
else if (strAttributeName  ==  convCacheUseState.CacheModeENName)
{
mstrCacheModeENName = value.ToString();
 AddUpdatedFld(convCacheUseState.CacheModeENName);
}
else if (strAttributeName  ==  convCacheUseState.CacheKey)
{
mstrCacheKey = value.ToString();
 AddUpdatedFld(convCacheUseState.CacheKey);
}
else if (strAttributeName  ==  convCacheUseState.CacheSize)
{
mintCacheSize = TransNullToInt(value.ToString());
 AddUpdatedFld(convCacheUseState.CacheSize);
}
else if (strAttributeName  ==  convCacheUseState.UseDate)
{
mstrUseDate = value.ToString();
 AddUpdatedFld(convCacheUseState.UseDate);
}
else if (strAttributeName  ==  convCacheUseState.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCacheUseState.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convCacheUseState.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (convCacheUseState.UserId  ==  _AttributeName[intIndex])
{
return mstrUserId;
}
else if (convCacheUseState.CacheModeId  ==  _AttributeName[intIndex])
{
return mstrCacheModeId;
}
else if (convCacheUseState.CacheModeName  ==  _AttributeName[intIndex])
{
return mstrCacheModeName;
}
else if (convCacheUseState.CacheModeENName  ==  _AttributeName[intIndex])
{
return mstrCacheModeENName;
}
else if (convCacheUseState.CacheKey  ==  _AttributeName[intIndex])
{
return mstrCacheKey;
}
else if (convCacheUseState.CacheSize  ==  _AttributeName[intIndex])
{
return mintCacheSize;
}
else if (convCacheUseState.UseDate  ==  _AttributeName[intIndex])
{
return mstrUseDate;
}
else if (convCacheUseState.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convCacheUseState.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convCacheUseState.mId);
}
else if (convCacheUseState.UserId  ==  _AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convCacheUseState.UserId);
}
else if (convCacheUseState.CacheModeId  ==  _AttributeName[intIndex])
{
mstrCacheModeId = value.ToString();
 AddUpdatedFld(convCacheUseState.CacheModeId);
}
else if (convCacheUseState.CacheModeName  ==  _AttributeName[intIndex])
{
mstrCacheModeName = value.ToString();
 AddUpdatedFld(convCacheUseState.CacheModeName);
}
else if (convCacheUseState.CacheModeENName  ==  _AttributeName[intIndex])
{
mstrCacheModeENName = value.ToString();
 AddUpdatedFld(convCacheUseState.CacheModeENName);
}
else if (convCacheUseState.CacheKey  ==  _AttributeName[intIndex])
{
mstrCacheKey = value.ToString();
 AddUpdatedFld(convCacheUseState.CacheKey);
}
else if (convCacheUseState.CacheSize  ==  _AttributeName[intIndex])
{
mintCacheSize = TransNullToInt(value.ToString());
 AddUpdatedFld(convCacheUseState.CacheSize);
}
else if (convCacheUseState.UseDate  ==  _AttributeName[intIndex])
{
mstrUseDate = value.ToString();
 AddUpdatedFld(convCacheUseState.UseDate);
}
else if (convCacheUseState.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCacheUseState.Memo);
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
 AddUpdatedFld(convCacheUseState.mId);
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
 AddUpdatedFld(convCacheUseState.UserId);
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
 AddUpdatedFld(convCacheUseState.CacheModeId);
}
}
/// <summary>
/// 缓存方式名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CacheModeName
{
get
{
return mstrCacheModeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCacheModeName = value;
}
else
{
 mstrCacheModeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCacheUseState.CacheModeName);
}
}
/// <summary>
/// 缓存方式英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CacheModeENName
{
get
{
return mstrCacheModeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCacheModeENName = value;
}
else
{
 mstrCacheModeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCacheUseState.CacheModeENName);
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
 AddUpdatedFld(convCacheUseState.CacheKey);
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
 AddUpdatedFld(convCacheUseState.CacheSize);
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
 AddUpdatedFld(convCacheUseState.UseDate);
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
 AddUpdatedFld(convCacheUseState.Memo);
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
 /// vCacheUseState(vCacheUseState)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convCacheUseState
{
public const string _CurrTabName = "vCacheUseState"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "UserId", "CacheModeId", "CacheModeName", "CacheModeENName", "CacheKey", "CacheSize", "UseDate", "Memo"};
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
 /// 常量:"CacheModeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CacheModeName = "CacheModeName";    //缓存方式名

 /// <summary>
 /// 常量:"CacheModeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CacheModeENName = "CacheModeENName";    //缓存方式英文名

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