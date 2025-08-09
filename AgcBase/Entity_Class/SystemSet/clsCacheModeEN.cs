
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCacheModeEN
 表名:CacheMode(00050538)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:02:44
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
 /// 表CacheMode的关键字(CacheModeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CacheModeId_CacheMode
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strCacheModeId">表关键字</param>
public K_CacheModeId_CacheMode(string strCacheModeId)
{
if (IsValid(strCacheModeId)) Value = strCacheModeId;
else
{
Value = null;
}
}
private static bool IsValid(string strCacheModeId)
{
if (string.IsNullOrEmpty(strCacheModeId) == true) return false;
if (strCacheModeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_CacheModeId_CacheMode]类型的对象</returns>
public static implicit operator K_CacheModeId_CacheMode(string value)
{
return new K_CacheModeId_CacheMode(value);
}
}
 /// <summary>
 /// 缓存方式(CacheMode)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCacheModeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CacheMode"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "CacheModeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 5;
public static string[] _AttributeName = new string[] {"CacheModeId", "CacheModeName", "CacheModeENName", "InUse", "Memo"};

protected string mstrCacheModeId;    //缓存方式Id
protected string mstrCacheModeName;    //缓存方式名
protected string mstrCacheModeENName;    //缓存方式英文名
protected bool mbolInUse;    //是否在用
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsCacheModeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CacheModeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strCacheModeId">关键字:缓存方式Id</param>
public clsCacheModeEN(string strCacheModeId)
 {
strCacheModeId = strCacheModeId.Replace("'", "''");
if (strCacheModeId.Length > 2)
{
throw new Exception("在表:CacheMode中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strCacheModeId)  ==  true)
{
throw new Exception("在表:CacheMode中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCacheModeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrCacheModeId = strCacheModeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CacheModeId");
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
if (strAttributeName  ==  conCacheMode.CacheModeId)
{
return mstrCacheModeId;
}
else if (strAttributeName  ==  conCacheMode.CacheModeName)
{
return mstrCacheModeName;
}
else if (strAttributeName  ==  conCacheMode.CacheModeENName)
{
return mstrCacheModeENName;
}
else if (strAttributeName  ==  conCacheMode.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  conCacheMode.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conCacheMode.CacheModeId)
{
mstrCacheModeId = value.ToString();
 AddUpdatedFld(conCacheMode.CacheModeId);
}
else if (strAttributeName  ==  conCacheMode.CacheModeName)
{
mstrCacheModeName = value.ToString();
 AddUpdatedFld(conCacheMode.CacheModeName);
}
else if (strAttributeName  ==  conCacheMode.CacheModeENName)
{
mstrCacheModeENName = value.ToString();
 AddUpdatedFld(conCacheMode.CacheModeENName);
}
else if (strAttributeName  ==  conCacheMode.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conCacheMode.InUse);
}
else if (strAttributeName  ==  conCacheMode.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCacheMode.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conCacheMode.CacheModeId  ==  _AttributeName[intIndex])
{
return mstrCacheModeId;
}
else if (conCacheMode.CacheModeName  ==  _AttributeName[intIndex])
{
return mstrCacheModeName;
}
else if (conCacheMode.CacheModeENName  ==  _AttributeName[intIndex])
{
return mstrCacheModeENName;
}
else if (conCacheMode.InUse  ==  _AttributeName[intIndex])
{
return mbolInUse;
}
else if (conCacheMode.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conCacheMode.CacheModeId  ==  _AttributeName[intIndex])
{
mstrCacheModeId = value.ToString();
 AddUpdatedFld(conCacheMode.CacheModeId);
}
else if (conCacheMode.CacheModeName  ==  _AttributeName[intIndex])
{
mstrCacheModeName = value.ToString();
 AddUpdatedFld(conCacheMode.CacheModeName);
}
else if (conCacheMode.CacheModeENName  ==  _AttributeName[intIndex])
{
mstrCacheModeENName = value.ToString();
 AddUpdatedFld(conCacheMode.CacheModeENName);
}
else if (conCacheMode.InUse  ==  _AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conCacheMode.InUse);
}
else if (conCacheMode.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCacheMode.Memo);
}
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
 AddUpdatedFld(conCacheMode.CacheModeId);
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
 AddUpdatedFld(conCacheMode.CacheModeName);
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
 AddUpdatedFld(conCacheMode.CacheModeENName);
}
}
/// <summary>
/// 是否在用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool InUse
{
get
{
return mbolInUse;
}
set
{
 mbolInUse = value;
//记录修改过的字段
 AddUpdatedFld(conCacheMode.InUse);
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
 AddUpdatedFld(conCacheMode.Memo);
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
  return mstrCacheModeId;
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
  return mstrCacheModeName;
 }
 }
}
 /// <summary>
 /// 缓存方式(CacheMode)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCacheMode
{
public const string _CurrTabName = "CacheMode"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CacheModeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"CacheModeId", "CacheModeName", "CacheModeENName", "InUse", "Memo"};
//以下是属性变量


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
 /// 常量:"InUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InUse = "InUse";    //是否在用

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}