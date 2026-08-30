
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsdm_relation_nature_dictEN
 表名:dm_relation_nature_dict(00050660)
 * 版本:2026.08.01(服务器:WIN-SRV103-116)
 日期:2026/08/04 10:53:16
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:数据模型(DataModel)
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
 /// 表dm_relation_nature_dict的关键字(nature_code)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_nature_code_dm_relation_nature_dict
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strnature_code">表关键字</param>
public K_nature_code_dm_relation_nature_dict(string strnature_code)
{
if (IsValid(strnature_code)) Value = strnature_code;
else
{
Value = null;
}
}
private static bool IsValid(string strnature_code)
{
if (string.IsNullOrEmpty(strnature_code) == true) return false;
if (strnature_code.Length > 30) return false;
if (strnature_code.IndexOf(' ') >= 0) return false;
if (strnature_code.IndexOf(')') >= 0) return false;
if (strnature_code.IndexOf('(') >= 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_nature_code_dm_relation_nature_dict]类型的对象</returns>
public static implicit operator K_nature_code_dm_relation_nature_dict(string value)
{
return new K_nature_code_dm_relation_nature_dict(value);
}
}
 /// <summary>
 /// 关系性质字典表(dm_relation_nature_dict)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsdm_relation_nature_dictEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "dm_relation_nature_dict"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "nature_code"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 4;
public static string[] _AttributeName = new string[] {"nature_code", "nature_name", "nature_desc", "is_active"};

protected string mstrnature_code;    //性质编码
protected string mstrnature_name;    //性质名称
protected string mstrnature_desc;    //性质说明
protected bool mbolis_active;    //是否启用

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsdm_relation_nature_dictEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("nature_code");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strnature_code">关键字:性质编码</param>
public clsdm_relation_nature_dictEN(string strnature_code)
 {
strnature_code = strnature_code.Replace("'", "''");
if (strnature_code.Length > 30)
{
throw new Exception("在表:dm_relation_nature_dict中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strnature_code)  ==  true)
{
throw new Exception("在表:dm_relation_nature_dict中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strnature_code);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrnature_code = strnature_code;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("nature_code");
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
if (strAttributeName  ==  condm_relation_nature_dict.nature_code)
{
return mstrnature_code;
}
else if (strAttributeName  ==  condm_relation_nature_dict.nature_name)
{
return mstrnature_name;
}
else if (strAttributeName  ==  condm_relation_nature_dict.nature_desc)
{
return mstrnature_desc;
}
else if (strAttributeName  ==  condm_relation_nature_dict.is_active)
{
return mbolis_active;
}
return null;
}
set
{
if (strAttributeName  ==  condm_relation_nature_dict.nature_code)
{
mstrnature_code = value.ToString();
 AddUpdatedFld(condm_relation_nature_dict.nature_code);
}
else if (strAttributeName  ==  condm_relation_nature_dict.nature_name)
{
mstrnature_name = value.ToString();
 AddUpdatedFld(condm_relation_nature_dict.nature_name);
}
else if (strAttributeName  ==  condm_relation_nature_dict.nature_desc)
{
mstrnature_desc = value.ToString();
 AddUpdatedFld(condm_relation_nature_dict.nature_desc);
}
else if (strAttributeName  ==  condm_relation_nature_dict.is_active)
{
mbolis_active = TransNullToBool(value.ToString());
 AddUpdatedFld(condm_relation_nature_dict.is_active);
}
}
}
public object this[int intIndex]
{
get
{
if (condm_relation_nature_dict.nature_code  ==  _AttributeName[intIndex])
{
return mstrnature_code;
}
else if (condm_relation_nature_dict.nature_name  ==  _AttributeName[intIndex])
{
return mstrnature_name;
}
else if (condm_relation_nature_dict.nature_desc  ==  _AttributeName[intIndex])
{
return mstrnature_desc;
}
else if (condm_relation_nature_dict.is_active  ==  _AttributeName[intIndex])
{
return mbolis_active;
}
return null;
}
set
{
if (condm_relation_nature_dict.nature_code  ==  _AttributeName[intIndex])
{
mstrnature_code = value.ToString();
 AddUpdatedFld(condm_relation_nature_dict.nature_code);
}
else if (condm_relation_nature_dict.nature_name  ==  _AttributeName[intIndex])
{
mstrnature_name = value.ToString();
 AddUpdatedFld(condm_relation_nature_dict.nature_name);
}
else if (condm_relation_nature_dict.nature_desc  ==  _AttributeName[intIndex])
{
mstrnature_desc = value.ToString();
 AddUpdatedFld(condm_relation_nature_dict.nature_desc);
}
else if (condm_relation_nature_dict.is_active  ==  _AttributeName[intIndex])
{
mbolis_active = TransNullToBool(value.ToString());
 AddUpdatedFld(condm_relation_nature_dict.is_active);
}
}
}

/// <summary>
/// 性质编码(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string nature_code
{
get
{
return mstrnature_code;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrnature_code = value;
}
else
{
 mstrnature_code = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_relation_nature_dict.nature_code);
}
}
/// <summary>
/// 性质名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string nature_name
{
get
{
return mstrnature_name;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrnature_name = value;
}
else
{
 mstrnature_name = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_relation_nature_dict.nature_name);
}
}
/// <summary>
/// 性质说明(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string nature_desc
{
get
{
return mstrnature_desc;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrnature_desc = value;
}
else
{
 mstrnature_desc = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_relation_nature_dict.nature_desc);
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
 AddUpdatedFld(condm_relation_nature_dict.is_active);
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
  return mstrnature_code;
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
  return mstrnature_name;
 }
 }
}
 /// <summary>
 /// 关系性质字典表(dm_relation_nature_dict)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class condm_relation_nature_dict
{
public const string _CurrTabName = "dm_relation_nature_dict"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "nature_code"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"nature_code", "nature_name", "nature_desc", "is_active"};
//以下是属性变量


 /// <summary>
 /// 常量:"nature_code"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string nature_code = "nature_code";    //性质编码

 /// <summary>
 /// 常量:"nature_name"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string nature_name = "nature_name";    //性质名称

 /// <summary>
 /// 常量:"nature_desc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string nature_desc = "nature_desc";    //性质说明

 /// <summary>
 /// 常量:"is_active"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string is_active = "is_active";    //是否启用
}

}