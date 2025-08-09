
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjFeatureSimEN
 表名:vPrjFeatureSim(00050637)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:02:58
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
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
 /// 表vPrjFeatureSim的关键字(FeatureId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_FeatureId_vPrjFeatureSim
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strFeatureId">表关键字</param>
public K_FeatureId_vPrjFeatureSim(string strFeatureId)
{
if (IsValid(strFeatureId)) Value = strFeatureId;
else
{
Value = null;
}
}
private static bool IsValid(string strFeatureId)
{
if (string.IsNullOrEmpty(strFeatureId) == true) return false;
if (strFeatureId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_FeatureId_vPrjFeatureSim]类型的对象</returns>
public static implicit operator K_FeatureId_vPrjFeatureSim(string value)
{
return new K_FeatureId_vPrjFeatureSim(value);
}
}
 /// <summary>
 /// vPrjFeatureSim(vPrjFeatureSim)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvPrjFeatureSimEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vPrjFeatureSim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "FeatureId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 7;
public static string[] _AttributeName = new string[] {"FeatureId", "FeatureName", "FeatureTypeId", "RegionTypeId", "InUse", "ParentFeatureName", "ParentFeatureId"};

protected string mstrFeatureId;    //功能Id
protected string mstrFeatureName;    //功能名称
protected string mstrFeatureTypeId;    //功能类型Id
protected string mstrRegionTypeId;    //区域类型Id
protected bool mbolInUse;    //是否在用
protected string mstrParentFeatureName;    //父功能名
protected string mstrParentFeatureId;    //父功能Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvPrjFeatureSimEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FeatureId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strFeatureId">关键字:功能Id</param>
public clsvPrjFeatureSimEN(string strFeatureId)
 {
strFeatureId = strFeatureId.Replace("'", "''");
if (strFeatureId.Length > 4)
{
throw new Exception("在表:vPrjFeatureSim中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strFeatureId)  ==  true)
{
throw new Exception("在表:vPrjFeatureSim中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFeatureId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrFeatureId = strFeatureId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FeatureId");
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
if (strAttributeName  ==  convPrjFeatureSim.FeatureId)
{
return mstrFeatureId;
}
else if (strAttributeName  ==  convPrjFeatureSim.FeatureName)
{
return mstrFeatureName;
}
else if (strAttributeName  ==  convPrjFeatureSim.FeatureTypeId)
{
return mstrFeatureTypeId;
}
else if (strAttributeName  ==  convPrjFeatureSim.RegionTypeId)
{
return mstrRegionTypeId;
}
else if (strAttributeName  ==  convPrjFeatureSim.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  convPrjFeatureSim.ParentFeatureName)
{
return mstrParentFeatureName;
}
else if (strAttributeName  ==  convPrjFeatureSim.ParentFeatureId)
{
return mstrParentFeatureId;
}
return null;
}
set
{
if (strAttributeName  ==  convPrjFeatureSim.FeatureId)
{
mstrFeatureId = value.ToString();
 AddUpdatedFld(convPrjFeatureSim.FeatureId);
}
else if (strAttributeName  ==  convPrjFeatureSim.FeatureName)
{
mstrFeatureName = value.ToString();
 AddUpdatedFld(convPrjFeatureSim.FeatureName);
}
else if (strAttributeName  ==  convPrjFeatureSim.FeatureTypeId)
{
mstrFeatureTypeId = value.ToString();
 AddUpdatedFld(convPrjFeatureSim.FeatureTypeId);
}
else if (strAttributeName  ==  convPrjFeatureSim.RegionTypeId)
{
mstrRegionTypeId = value.ToString();
 AddUpdatedFld(convPrjFeatureSim.RegionTypeId);
}
else if (strAttributeName  ==  convPrjFeatureSim.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjFeatureSim.InUse);
}
else if (strAttributeName  ==  convPrjFeatureSim.ParentFeatureName)
{
mstrParentFeatureName = value.ToString();
 AddUpdatedFld(convPrjFeatureSim.ParentFeatureName);
}
else if (strAttributeName  ==  convPrjFeatureSim.ParentFeatureId)
{
mstrParentFeatureId = value.ToString();
 AddUpdatedFld(convPrjFeatureSim.ParentFeatureId);
}
}
}
public object this[int intIndex]
{
get
{
if (convPrjFeatureSim.FeatureId  ==  _AttributeName[intIndex])
{
return mstrFeatureId;
}
else if (convPrjFeatureSim.FeatureName  ==  _AttributeName[intIndex])
{
return mstrFeatureName;
}
else if (convPrjFeatureSim.FeatureTypeId  ==  _AttributeName[intIndex])
{
return mstrFeatureTypeId;
}
else if (convPrjFeatureSim.RegionTypeId  ==  _AttributeName[intIndex])
{
return mstrRegionTypeId;
}
else if (convPrjFeatureSim.InUse  ==  _AttributeName[intIndex])
{
return mbolInUse;
}
else if (convPrjFeatureSim.ParentFeatureName  ==  _AttributeName[intIndex])
{
return mstrParentFeatureName;
}
else if (convPrjFeatureSim.ParentFeatureId  ==  _AttributeName[intIndex])
{
return mstrParentFeatureId;
}
return null;
}
set
{
if (convPrjFeatureSim.FeatureId  ==  _AttributeName[intIndex])
{
mstrFeatureId = value.ToString();
 AddUpdatedFld(convPrjFeatureSim.FeatureId);
}
else if (convPrjFeatureSim.FeatureName  ==  _AttributeName[intIndex])
{
mstrFeatureName = value.ToString();
 AddUpdatedFld(convPrjFeatureSim.FeatureName);
}
else if (convPrjFeatureSim.FeatureTypeId  ==  _AttributeName[intIndex])
{
mstrFeatureTypeId = value.ToString();
 AddUpdatedFld(convPrjFeatureSim.FeatureTypeId);
}
else if (convPrjFeatureSim.RegionTypeId  ==  _AttributeName[intIndex])
{
mstrRegionTypeId = value.ToString();
 AddUpdatedFld(convPrjFeatureSim.RegionTypeId);
}
else if (convPrjFeatureSim.InUse  ==  _AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjFeatureSim.InUse);
}
else if (convPrjFeatureSim.ParentFeatureName  ==  _AttributeName[intIndex])
{
mstrParentFeatureName = value.ToString();
 AddUpdatedFld(convPrjFeatureSim.ParentFeatureName);
}
else if (convPrjFeatureSim.ParentFeatureId  ==  _AttributeName[intIndex])
{
mstrParentFeatureId = value.ToString();
 AddUpdatedFld(convPrjFeatureSim.ParentFeatureId);
}
}
}

/// <summary>
/// 功能Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FeatureId
{
get
{
return mstrFeatureId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFeatureId = value;
}
else
{
 mstrFeatureId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjFeatureSim.FeatureId);
}
}
/// <summary>
/// 功能名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FeatureName
{
get
{
return mstrFeatureName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFeatureName = value;
}
else
{
 mstrFeatureName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjFeatureSim.FeatureName);
}
}
/// <summary>
/// 功能类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FeatureTypeId
{
get
{
return mstrFeatureTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFeatureTypeId = value;
}
else
{
 mstrFeatureTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjFeatureSim.FeatureTypeId);
}
}
/// <summary>
/// 区域类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RegionTypeId
{
get
{
return mstrRegionTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRegionTypeId = value;
}
else
{
 mstrRegionTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjFeatureSim.RegionTypeId);
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
 AddUpdatedFld(convPrjFeatureSim.InUse);
}
}
/// <summary>
/// 父功能名(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParentFeatureName
{
get
{
return mstrParentFeatureName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParentFeatureName = value;
}
else
{
 mstrParentFeatureName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjFeatureSim.ParentFeatureName);
}
}
/// <summary>
/// 父功能Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParentFeatureId
{
get
{
return mstrParentFeatureId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParentFeatureId = value;
}
else
{
 mstrParentFeatureId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjFeatureSim.ParentFeatureId);
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
  return mstrFeatureId;
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
  return mstrFeatureName;
 }
 }
}
 /// <summary>
 /// vPrjFeatureSim(vPrjFeatureSim)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convPrjFeatureSim
{
public const string _CurrTabName = "vPrjFeatureSim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FeatureId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"FeatureId", "FeatureName", "FeatureTypeId", "RegionTypeId", "InUse", "ParentFeatureName", "ParentFeatureId"};
//以下是属性变量


 /// <summary>
 /// 常量:"FeatureId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeatureId = "FeatureId";    //功能Id

 /// <summary>
 /// 常量:"FeatureName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeatureName = "FeatureName";    //功能名称

 /// <summary>
 /// 常量:"FeatureTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeatureTypeId = "FeatureTypeId";    //功能类型Id

 /// <summary>
 /// 常量:"RegionTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RegionTypeId = "RegionTypeId";    //区域类型Id

 /// <summary>
 /// 常量:"InUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InUse = "InUse";    //是否在用

 /// <summary>
 /// 常量:"ParentFeatureName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParentFeatureName = "ParentFeatureName";    //父功能名

 /// <summary>
 /// 常量:"ParentFeatureId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParentFeatureId = "ParentFeatureId";    //父功能Id
}

}