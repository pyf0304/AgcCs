
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUseCacheModeEN
 表名:UseCacheMode(00050651)
 * 版本:2026.07.11(服务器:WIN-SRV103-116)
 日期:2026/07/19 11:29:59
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:区域管理(RegionManage)
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
 /// 表UseCacheMode的关键字(UseCacheModeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_UseCacheModeId_UseCacheMode
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strUseCacheModeId">表关键字</param>
public K_UseCacheModeId_UseCacheMode(string strUseCacheModeId)
{
if (IsValid(strUseCacheModeId)) Value = strUseCacheModeId;
else
{
Value = null;
}
}
private static bool IsValid(string strUseCacheModeId)
{
if (string.IsNullOrEmpty(strUseCacheModeId) == true) return false;
if (strUseCacheModeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_UseCacheModeId_UseCacheMode]类型的对象</returns>
public static implicit operator K_UseCacheModeId_UseCacheMode(string value)
{
return new K_UseCacheModeId_UseCacheMode(value);
}
}
 /// <summary>
 /// 使用缓存模式(UseCacheMode)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsUseCacheModeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "UseCacheMode"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "UseCacheModeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 6;
public static string[] _AttributeName = new string[] {"UseCacheModeId", "UseCacheModeName", "UseCacheModeEnName", "UpdUser", "UpdDate", "Memo"};

protected string mstrUseCacheModeId;    //使用缓存模式Id
protected string mstrUseCacheModeName;    //使用缓存模式名
protected string mstrUseCacheModeEnName;    //使用缓存模式英文名
protected string mstrUpdUser;    //修改者
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsUseCacheModeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("UseCacheModeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strUseCacheModeId">关键字:使用缓存模式Id</param>
public clsUseCacheModeEN(string strUseCacheModeId)
 {
strUseCacheModeId = strUseCacheModeId.Replace("'", "''");
if (strUseCacheModeId.Length > 2)
{
throw new Exception("在表:UseCacheMode中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strUseCacheModeId)  ==  true)
{
throw new Exception("在表:UseCacheMode中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strUseCacheModeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrUseCacheModeId = strUseCacheModeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("UseCacheModeId");
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
if (strAttributeName  ==  conUseCacheMode.UseCacheModeId)
{
return mstrUseCacheModeId;
}
else if (strAttributeName  ==  conUseCacheMode.UseCacheModeName)
{
return mstrUseCacheModeName;
}
else if (strAttributeName  ==  conUseCacheMode.UseCacheModeEnName)
{
return mstrUseCacheModeEnName;
}
else if (strAttributeName  ==  conUseCacheMode.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conUseCacheMode.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conUseCacheMode.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conUseCacheMode.UseCacheModeId)
{
mstrUseCacheModeId = value.ToString();
 AddUpdatedFld(conUseCacheMode.UseCacheModeId);
}
else if (strAttributeName  ==  conUseCacheMode.UseCacheModeName)
{
mstrUseCacheModeName = value.ToString();
 AddUpdatedFld(conUseCacheMode.UseCacheModeName);
}
else if (strAttributeName  ==  conUseCacheMode.UseCacheModeEnName)
{
mstrUseCacheModeEnName = value.ToString();
 AddUpdatedFld(conUseCacheMode.UseCacheModeEnName);
}
else if (strAttributeName  ==  conUseCacheMode.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conUseCacheMode.UpdUser);
}
else if (strAttributeName  ==  conUseCacheMode.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conUseCacheMode.UpdDate);
}
else if (strAttributeName  ==  conUseCacheMode.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conUseCacheMode.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conUseCacheMode.UseCacheModeId  ==  _AttributeName[intIndex])
{
return mstrUseCacheModeId;
}
else if (conUseCacheMode.UseCacheModeName  ==  _AttributeName[intIndex])
{
return mstrUseCacheModeName;
}
else if (conUseCacheMode.UseCacheModeEnName  ==  _AttributeName[intIndex])
{
return mstrUseCacheModeEnName;
}
else if (conUseCacheMode.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conUseCacheMode.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conUseCacheMode.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conUseCacheMode.UseCacheModeId  ==  _AttributeName[intIndex])
{
mstrUseCacheModeId = value.ToString();
 AddUpdatedFld(conUseCacheMode.UseCacheModeId);
}
else if (conUseCacheMode.UseCacheModeName  ==  _AttributeName[intIndex])
{
mstrUseCacheModeName = value.ToString();
 AddUpdatedFld(conUseCacheMode.UseCacheModeName);
}
else if (conUseCacheMode.UseCacheModeEnName  ==  _AttributeName[intIndex])
{
mstrUseCacheModeEnName = value.ToString();
 AddUpdatedFld(conUseCacheMode.UseCacheModeEnName);
}
else if (conUseCacheMode.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conUseCacheMode.UpdUser);
}
else if (conUseCacheMode.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conUseCacheMode.UpdDate);
}
else if (conUseCacheMode.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conUseCacheMode.Memo);
}
}
}

/// <summary>
/// 使用缓存模式Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UseCacheModeId
{
get
{
return mstrUseCacheModeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUseCacheModeId = value;
}
else
{
 mstrUseCacheModeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conUseCacheMode.UseCacheModeId);
}
}
/// <summary>
/// 使用缓存模式名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UseCacheModeName
{
get
{
return mstrUseCacheModeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUseCacheModeName = value;
}
else
{
 mstrUseCacheModeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conUseCacheMode.UseCacheModeName);
}
}
/// <summary>
/// 使用缓存模式英文名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UseCacheModeEnName
{
get
{
return mstrUseCacheModeEnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUseCacheModeEnName = value;
}
else
{
 mstrUseCacheModeEnName = value;
}
//记录修改过的字段
 AddUpdatedFld(conUseCacheMode.UseCacheModeEnName);
}
}
/// <summary>
/// 修改者(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUser
{
get
{
return mstrUpdUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUser = value;
}
else
{
 mstrUpdUser = value;
}
//记录修改过的字段
 AddUpdatedFld(conUseCacheMode.UpdUser);
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
 AddUpdatedFld(conUseCacheMode.UpdDate);
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
 AddUpdatedFld(conUseCacheMode.Memo);
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
  return mstrUseCacheModeId;
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
  return mstrUseCacheModeName;
 }
 }
}
 /// <summary>
 /// 使用缓存模式(UseCacheMode)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conUseCacheMode
{
public const string _CurrTabName = "UseCacheMode"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "UseCacheModeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"UseCacheModeId", "UseCacheModeName", "UseCacheModeEnName", "UpdUser", "UpdDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"UseCacheModeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UseCacheModeId = "UseCacheModeId";    //使用缓存模式Id

 /// <summary>
 /// 常量:"UseCacheModeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UseCacheModeName = "UseCacheModeName";    //使用缓存模式名

 /// <summary>
 /// 常量:"UseCacheModeEnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UseCacheModeEnName = "UseCacheModeEnName";    //使用缓存模式英文名

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改者

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