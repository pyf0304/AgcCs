
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsdm_cardinality_type_dictEN
 表名:dm_cardinality_type_dict(00050661)
 * 版本:2026.08.13(服务器:WIN-SRV103-116)
 日期:2026/08/14 16:37:19
 生成者:pyf_agc
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:数据模型图(ModelDiagram)
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
 /// 表dm_cardinality_type_dict的关键字(cardinality_code)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_cardinality_code_dm_cardinality_type_dict
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strcardinality_code">表关键字</param>
public K_cardinality_code_dm_cardinality_type_dict(string strcardinality_code)
{
if (IsValid(strcardinality_code)) Value = strcardinality_code;
else
{
Value = null;
}
}
private static bool IsValid(string strcardinality_code)
{
if (string.IsNullOrEmpty(strcardinality_code) == true) return false;
if (strcardinality_code.Length > 30) return false;
if (strcardinality_code.IndexOf(' ') >= 0) return false;
if (strcardinality_code.IndexOf(')') >= 0) return false;
if (strcardinality_code.IndexOf('(') >= 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_cardinality_code_dm_cardinality_type_dict]类型的对象</returns>
public static implicit operator K_cardinality_code_dm_cardinality_type_dict(string value)
{
return new K_cardinality_code_dm_cardinality_type_dict(value);
}
}
 /// <summary>
 /// 关系类型字典表(dm_cardinality_type_dict)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsdm_cardinality_type_dictEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "dm_cardinality_type_dict"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "cardinality_code"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 5;
public static string[] _AttributeName = new string[] {"cardinality_code", "cardinality_name", "cardinality_desc", "is_active", "arrow_mode"};

protected string mstrcardinality_code;    //基数编码
protected string mstrcardinality_name;    //基数名称
protected string mstrcardinality_desc;    //基数说明
protected bool mbolis_active;    //是否启用
protected string mstrarrow_mode;    //箭头模式

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsdm_cardinality_type_dictEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("cardinality_code");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strcardinality_code">关键字:基数编码</param>
public clsdm_cardinality_type_dictEN(string strcardinality_code)
 {
strcardinality_code = strcardinality_code.Replace("'", "''");
if (strcardinality_code.Length > 30)
{
throw new Exception("在表:dm_cardinality_type_dict中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strcardinality_code)  ==  true)
{
throw new Exception("在表:dm_cardinality_type_dict中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strcardinality_code);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrcardinality_code = strcardinality_code;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("cardinality_code");
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
if (strAttributeName  ==  condm_cardinality_type_dict.cardinality_code)
{
return mstrcardinality_code;
}
else if (strAttributeName  ==  condm_cardinality_type_dict.cardinality_name)
{
return mstrcardinality_name;
}
else if (strAttributeName  ==  condm_cardinality_type_dict.cardinality_desc)
{
return mstrcardinality_desc;
}
else if (strAttributeName  ==  condm_cardinality_type_dict.is_active)
{
return mbolis_active;
}
else if (strAttributeName  ==  condm_cardinality_type_dict.arrow_mode)
{
return mstrarrow_mode;
}
return null;
}
set
{
if (strAttributeName  ==  condm_cardinality_type_dict.cardinality_code)
{
mstrcardinality_code = value.ToString();
 AddUpdatedFld(condm_cardinality_type_dict.cardinality_code);
}
else if (strAttributeName  ==  condm_cardinality_type_dict.cardinality_name)
{
mstrcardinality_name = value.ToString();
 AddUpdatedFld(condm_cardinality_type_dict.cardinality_name);
}
else if (strAttributeName  ==  condm_cardinality_type_dict.cardinality_desc)
{
mstrcardinality_desc = value.ToString();
 AddUpdatedFld(condm_cardinality_type_dict.cardinality_desc);
}
else if (strAttributeName  ==  condm_cardinality_type_dict.is_active)
{
mbolis_active = TransNullToBool(value.ToString());
 AddUpdatedFld(condm_cardinality_type_dict.is_active);
}
else if (strAttributeName  ==  condm_cardinality_type_dict.arrow_mode)
{
mstrarrow_mode = value.ToString();
 AddUpdatedFld(condm_cardinality_type_dict.arrow_mode);
}
}
}
public object this[int intIndex]
{
get
{
if (condm_cardinality_type_dict.cardinality_code  ==  _AttributeName[intIndex])
{
return mstrcardinality_code;
}
else if (condm_cardinality_type_dict.cardinality_name  ==  _AttributeName[intIndex])
{
return mstrcardinality_name;
}
else if (condm_cardinality_type_dict.cardinality_desc  ==  _AttributeName[intIndex])
{
return mstrcardinality_desc;
}
else if (condm_cardinality_type_dict.is_active  ==  _AttributeName[intIndex])
{
return mbolis_active;
}
else if (condm_cardinality_type_dict.arrow_mode  ==  _AttributeName[intIndex])
{
return mstrarrow_mode;
}
return null;
}
set
{
if (condm_cardinality_type_dict.cardinality_code  ==  _AttributeName[intIndex])
{
mstrcardinality_code = value.ToString();
 AddUpdatedFld(condm_cardinality_type_dict.cardinality_code);
}
else if (condm_cardinality_type_dict.cardinality_name  ==  _AttributeName[intIndex])
{
mstrcardinality_name = value.ToString();
 AddUpdatedFld(condm_cardinality_type_dict.cardinality_name);
}
else if (condm_cardinality_type_dict.cardinality_desc  ==  _AttributeName[intIndex])
{
mstrcardinality_desc = value.ToString();
 AddUpdatedFld(condm_cardinality_type_dict.cardinality_desc);
}
else if (condm_cardinality_type_dict.is_active  ==  _AttributeName[intIndex])
{
mbolis_active = TransNullToBool(value.ToString());
 AddUpdatedFld(condm_cardinality_type_dict.is_active);
}
else if (condm_cardinality_type_dict.arrow_mode  ==  _AttributeName[intIndex])
{
mstrarrow_mode = value.ToString();
 AddUpdatedFld(condm_cardinality_type_dict.arrow_mode);
}
}
}

/// <summary>
/// 基数编码(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string cardinality_code
{
get
{
return mstrcardinality_code;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrcardinality_code = value;
}
else
{
 mstrcardinality_code = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_cardinality_type_dict.cardinality_code);
}
}
/// <summary>
/// 基数名称(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string cardinality_name
{
get
{
return mstrcardinality_name;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrcardinality_name = value;
}
else
{
 mstrcardinality_name = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_cardinality_type_dict.cardinality_name);
}
}
/// <summary>
/// 基数说明(说明:;字段类型:varchar;字段长度:300;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string cardinality_desc
{
get
{
return mstrcardinality_desc;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrcardinality_desc = value;
}
else
{
 mstrcardinality_desc = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_cardinality_type_dict.cardinality_desc);
}
}
/// <summary>
/// 是否启用(说明:;字段类型:bit;字段长度:0;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool is_active
{
get
{
return mbolis_active;
}
set
{
 mbolis_active = value;
//记录修改过的字段
 AddUpdatedFld(condm_cardinality_type_dict.is_active);
}
}
/// <summary>
/// 箭头模式(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string arrow_mode
{
get
{
return mstrarrow_mode;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrarrow_mode = value;
}
else
{
 mstrarrow_mode = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_cardinality_type_dict.arrow_mode);
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
  return mstrcardinality_code;
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
  return mstrcardinality_name;
 }
 }
}
 /// <summary>
 /// 关系类型字典表(dm_cardinality_type_dict)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class condm_cardinality_type_dict
{
public const string _CurrTabName = "dm_cardinality_type_dict"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "cardinality_code"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"cardinality_code", "cardinality_name", "cardinality_desc", "is_active", "arrow_mode"};
//以下是属性变量


 /// <summary>
 /// 常量:"cardinality_code"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string cardinality_code = "cardinality_code";    //基数编码

 /// <summary>
 /// 常量:"cardinality_name"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string cardinality_name = "cardinality_name";    //基数名称

 /// <summary>
 /// 常量:"cardinality_desc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string cardinality_desc = "cardinality_desc";    //基数说明

 /// <summary>
 /// 常量:"is_active"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string is_active = "is_active";    //是否启用

 /// <summary>
 /// 常量:"arrow_mode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string arrow_mode = "arrow_mode";    //箭头模式
}

}