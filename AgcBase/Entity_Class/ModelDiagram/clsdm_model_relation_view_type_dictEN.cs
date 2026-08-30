
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsdm_model_relation_view_type_dictEN
 表名:dm_model_relation_view_type_dict(00050667)
 * 版本:2026.08.13(服务器:WIN-SRV103-116)
 日期:2026/08/13 18:21:44
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
 /// 表dm_model_relation_view_type_dict的关键字(view_type_id)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_view_type_id_dm_model_relation_view_type_dict
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strview_type_id">表关键字</param>
public K_view_type_id_dm_model_relation_view_type_dict(string strview_type_id)
{
if (IsValid(strview_type_id)) Value = strview_type_id;
else
{
Value = null;
}
}
private static bool IsValid(string strview_type_id)
{
if (string.IsNullOrEmpty(strview_type_id) == true) return false;
if (strview_type_id.Length > 32) return false;
if (strview_type_id.IndexOf(' ') >= 0) return false;
if (strview_type_id.IndexOf(')') >= 0) return false;
if (strview_type_id.IndexOf('(') >= 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_view_type_id_dm_model_relation_view_type_dict]类型的对象</returns>
public static implicit operator K_view_type_id_dm_model_relation_view_type_dict(string value)
{
return new K_view_type_id_dm_model_relation_view_type_dict(value);
}
}
 /// <summary>
 /// 关系视图类型字典(dm_model_relation_view_type_dict)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsdm_model_relation_view_type_dictEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "dm_model_relation_view_type_dict"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "view_type_id"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 12;
public static string[] _AttributeName = new string[] {"view_type_id", "view_type_code", "view_type_name", "view_type_desc", "is_active", "sort_no", "Status", "created_by", "created_time", "updated_by", "updated_time", "remark"};

protected string mstrview_type_id;    //视图类型ID
protected string mstrview_type_code;    //视图类型编码
protected string mstrview_type_name;    //视图类型名称
protected string mstrview_type_desc;    //视图类型说明
protected bool mbolis_active;    //是否启用
protected int mintsort_no;    //排序号
protected string mstrStatus;    //Status
protected string mstrcreated_by;    //创建人
protected DateTime mdtecreated_time;    //创建时间
protected string mstrupdated_by;    //更新人
protected DateTime mdteupdated_time;    //更新时间
protected string mstrremark;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsdm_model_relation_view_type_dictEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("view_type_id");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strview_type_id">关键字:视图类型ID</param>
public clsdm_model_relation_view_type_dictEN(string strview_type_id)
 {
strview_type_id = strview_type_id.Replace("'", "''");
if (strview_type_id.Length > 32)
{
throw new Exception("在表:dm_model_relation_view_type_dict中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strview_type_id)  ==  true)
{
throw new Exception("在表:dm_model_relation_view_type_dict中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strview_type_id);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrview_type_id = strview_type_id;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("view_type_id");
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
if (strAttributeName  ==  condm_model_relation_view_type_dict.view_type_id)
{
return mstrview_type_id;
}
else if (strAttributeName  ==  condm_model_relation_view_type_dict.view_type_code)
{
return mstrview_type_code;
}
else if (strAttributeName  ==  condm_model_relation_view_type_dict.view_type_name)
{
return mstrview_type_name;
}
else if (strAttributeName  ==  condm_model_relation_view_type_dict.view_type_desc)
{
return mstrview_type_desc;
}
else if (strAttributeName  ==  condm_model_relation_view_type_dict.is_active)
{
return mbolis_active;
}
else if (strAttributeName  ==  condm_model_relation_view_type_dict.sort_no)
{
return mintsort_no;
}
else if (strAttributeName  ==  condm_model_relation_view_type_dict.Status)
{
return mstrStatus;
}
else if (strAttributeName  ==  condm_model_relation_view_type_dict.created_by)
{
return mstrcreated_by;
}
else if (strAttributeName  ==  condm_model_relation_view_type_dict.created_time)
{
return mdtecreated_time;
}
else if (strAttributeName  ==  condm_model_relation_view_type_dict.updated_by)
{
return mstrupdated_by;
}
else if (strAttributeName  ==  condm_model_relation_view_type_dict.updated_time)
{
return mdteupdated_time;
}
else if (strAttributeName  ==  condm_model_relation_view_type_dict.remark)
{
return mstrremark;
}
return null;
}
set
{
if (strAttributeName  ==  condm_model_relation_view_type_dict.view_type_id)
{
mstrview_type_id = value.ToString();
 AddUpdatedFld(condm_model_relation_view_type_dict.view_type_id);
}
else if (strAttributeName  ==  condm_model_relation_view_type_dict.view_type_code)
{
mstrview_type_code = value.ToString();
 AddUpdatedFld(condm_model_relation_view_type_dict.view_type_code);
}
else if (strAttributeName  ==  condm_model_relation_view_type_dict.view_type_name)
{
mstrview_type_name = value.ToString();
 AddUpdatedFld(condm_model_relation_view_type_dict.view_type_name);
}
else if (strAttributeName  ==  condm_model_relation_view_type_dict.view_type_desc)
{
mstrview_type_desc = value.ToString();
 AddUpdatedFld(condm_model_relation_view_type_dict.view_type_desc);
}
else if (strAttributeName  ==  condm_model_relation_view_type_dict.is_active)
{
mbolis_active = TransNullToBool(value.ToString());
 AddUpdatedFld(condm_model_relation_view_type_dict.is_active);
}
else if (strAttributeName  ==  condm_model_relation_view_type_dict.sort_no)
{
mintsort_no = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_relation_view_type_dict.sort_no);
}
else if (strAttributeName  ==  condm_model_relation_view_type_dict.Status)
{
mstrStatus = value.ToString();
 AddUpdatedFld(condm_model_relation_view_type_dict.Status);
}
else if (strAttributeName  ==  condm_model_relation_view_type_dict.created_by)
{
mstrcreated_by = value.ToString();
 AddUpdatedFld(condm_model_relation_view_type_dict.created_by);
}
else if (strAttributeName  ==  condm_model_relation_view_type_dict.created_time)
{
mdtecreated_time = TransNullToDate(value.ToString());
 AddUpdatedFld(condm_model_relation_view_type_dict.created_time);
}
else if (strAttributeName  ==  condm_model_relation_view_type_dict.updated_by)
{
mstrupdated_by = value.ToString();
 AddUpdatedFld(condm_model_relation_view_type_dict.updated_by);
}
else if (strAttributeName  ==  condm_model_relation_view_type_dict.updated_time)
{
mdteupdated_time = TransNullToDate(value.ToString());
 AddUpdatedFld(condm_model_relation_view_type_dict.updated_time);
}
else if (strAttributeName  ==  condm_model_relation_view_type_dict.remark)
{
mstrremark = value.ToString();
 AddUpdatedFld(condm_model_relation_view_type_dict.remark);
}
}
}
public object this[int intIndex]
{
get
{
if (condm_model_relation_view_type_dict.view_type_id  ==  _AttributeName[intIndex])
{
return mstrview_type_id;
}
else if (condm_model_relation_view_type_dict.view_type_code  ==  _AttributeName[intIndex])
{
return mstrview_type_code;
}
else if (condm_model_relation_view_type_dict.view_type_name  ==  _AttributeName[intIndex])
{
return mstrview_type_name;
}
else if (condm_model_relation_view_type_dict.view_type_desc  ==  _AttributeName[intIndex])
{
return mstrview_type_desc;
}
else if (condm_model_relation_view_type_dict.is_active  ==  _AttributeName[intIndex])
{
return mbolis_active;
}
else if (condm_model_relation_view_type_dict.sort_no  ==  _AttributeName[intIndex])
{
return mintsort_no;
}
else if (condm_model_relation_view_type_dict.Status  ==  _AttributeName[intIndex])
{
return mstrStatus;
}
else if (condm_model_relation_view_type_dict.created_by  ==  _AttributeName[intIndex])
{
return mstrcreated_by;
}
else if (condm_model_relation_view_type_dict.created_time  ==  _AttributeName[intIndex])
{
return mdtecreated_time;
}
else if (condm_model_relation_view_type_dict.updated_by  ==  _AttributeName[intIndex])
{
return mstrupdated_by;
}
else if (condm_model_relation_view_type_dict.updated_time  ==  _AttributeName[intIndex])
{
return mdteupdated_time;
}
else if (condm_model_relation_view_type_dict.remark  ==  _AttributeName[intIndex])
{
return mstrremark;
}
return null;
}
set
{
if (condm_model_relation_view_type_dict.view_type_id  ==  _AttributeName[intIndex])
{
mstrview_type_id = value.ToString();
 AddUpdatedFld(condm_model_relation_view_type_dict.view_type_id);
}
else if (condm_model_relation_view_type_dict.view_type_code  ==  _AttributeName[intIndex])
{
mstrview_type_code = value.ToString();
 AddUpdatedFld(condm_model_relation_view_type_dict.view_type_code);
}
else if (condm_model_relation_view_type_dict.view_type_name  ==  _AttributeName[intIndex])
{
mstrview_type_name = value.ToString();
 AddUpdatedFld(condm_model_relation_view_type_dict.view_type_name);
}
else if (condm_model_relation_view_type_dict.view_type_desc  ==  _AttributeName[intIndex])
{
mstrview_type_desc = value.ToString();
 AddUpdatedFld(condm_model_relation_view_type_dict.view_type_desc);
}
else if (condm_model_relation_view_type_dict.is_active  ==  _AttributeName[intIndex])
{
mbolis_active = TransNullToBool(value.ToString());
 AddUpdatedFld(condm_model_relation_view_type_dict.is_active);
}
else if (condm_model_relation_view_type_dict.sort_no  ==  _AttributeName[intIndex])
{
mintsort_no = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_relation_view_type_dict.sort_no);
}
else if (condm_model_relation_view_type_dict.Status  ==  _AttributeName[intIndex])
{
mstrStatus = value.ToString();
 AddUpdatedFld(condm_model_relation_view_type_dict.Status);
}
else if (condm_model_relation_view_type_dict.created_by  ==  _AttributeName[intIndex])
{
mstrcreated_by = value.ToString();
 AddUpdatedFld(condm_model_relation_view_type_dict.created_by);
}
else if (condm_model_relation_view_type_dict.created_time  ==  _AttributeName[intIndex])
{
mdtecreated_time = TransNullToDate(value.ToString());
 AddUpdatedFld(condm_model_relation_view_type_dict.created_time);
}
else if (condm_model_relation_view_type_dict.updated_by  ==  _AttributeName[intIndex])
{
mstrupdated_by = value.ToString();
 AddUpdatedFld(condm_model_relation_view_type_dict.updated_by);
}
else if (condm_model_relation_view_type_dict.updated_time  ==  _AttributeName[intIndex])
{
mdteupdated_time = TransNullToDate(value.ToString());
 AddUpdatedFld(condm_model_relation_view_type_dict.updated_time);
}
else if (condm_model_relation_view_type_dict.remark  ==  _AttributeName[intIndex])
{
mstrremark = value.ToString();
 AddUpdatedFld(condm_model_relation_view_type_dict.remark);
}
}
}

/// <summary>
/// 视图类型ID(说明:;字段类型:varchar;字段长度:32;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string view_type_id
{
get
{
return mstrview_type_id;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrview_type_id = value;
}
else
{
 mstrview_type_id = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_relation_view_type_dict.view_type_id);
}
}
/// <summary>
/// 视图类型编码(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string view_type_code
{
get
{
return mstrview_type_code;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrview_type_code = value;
}
else
{
 mstrview_type_code = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_relation_view_type_dict.view_type_code);
}
}
/// <summary>
/// 视图类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string view_type_name
{
get
{
return mstrview_type_name;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrview_type_name = value;
}
else
{
 mstrview_type_name = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_relation_view_type_dict.view_type_name);
}
}
/// <summary>
/// 视图类型说明(说明:;字段类型:varchar;字段长度:300;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string view_type_desc
{
get
{
return mstrview_type_desc;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrview_type_desc = value;
}
else
{
 mstrview_type_desc = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_relation_view_type_dict.view_type_desc);
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
 AddUpdatedFld(condm_model_relation_view_type_dict.is_active);
}
}
/// <summary>
/// 排序号(说明:;字段类型:int;字段长度:0;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int sort_no
{
get
{
return mintsort_no;
}
set
{
 mintsort_no = value;
//记录修改过的字段
 AddUpdatedFld(condm_model_relation_view_type_dict.sort_no);
}
}
/// <summary>
/// Status(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Status
{
get
{
return mstrStatus;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStatus = value;
}
else
{
 mstrStatus = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_relation_view_type_dict.Status);
}
}
/// <summary>
/// 创建人(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string created_by
{
get
{
return mstrcreated_by;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrcreated_by = value;
}
else
{
 mstrcreated_by = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_relation_view_type_dict.created_by);
}
}
/// <summary>
/// 创建时间(说明:;字段类型:datetime;字段长度:0;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public DateTime created_time
{
get
{
return mdtecreated_time;
}
set
{
 mdtecreated_time = value;
//记录修改过的字段
 AddUpdatedFld(condm_model_relation_view_type_dict.created_time);
}
}
/// <summary>
/// 更新人(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string updated_by
{
get
{
return mstrupdated_by;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrupdated_by = value;
}
else
{
 mstrupdated_by = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_relation_view_type_dict.updated_by);
}
}
/// <summary>
/// 更新时间(说明:;字段类型:datetime;字段长度:0;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public DateTime updated_time
{
get
{
return mdteupdated_time;
}
set
{
 mdteupdated_time = value;
//记录修改过的字段
 AddUpdatedFld(condm_model_relation_view_type_dict.updated_time);
}
}
/// <summary>
/// 备注(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string remark
{
get
{
return mstrremark;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrremark = value;
}
else
{
 mstrremark = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_relation_view_type_dict.remark);
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
  return mstrview_type_id;
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
  return mstrview_type_name;
 }
 }
}
 /// <summary>
 /// 关系视图类型字典(dm_model_relation_view_type_dict)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class condm_model_relation_view_type_dict
{
public const string _CurrTabName = "dm_model_relation_view_type_dict"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "view_type_id"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"view_type_id", "view_type_code", "view_type_name", "view_type_desc", "is_active", "sort_no", "Status", "created_by", "created_time", "updated_by", "updated_time", "remark"};
//以下是属性变量


 /// <summary>
 /// 常量:"view_type_id"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string view_type_id = "view_type_id";    //视图类型ID

 /// <summary>
 /// 常量:"view_type_code"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string view_type_code = "view_type_code";    //视图类型编码

 /// <summary>
 /// 常量:"view_type_name"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string view_type_name = "view_type_name";    //视图类型名称

 /// <summary>
 /// 常量:"view_type_desc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string view_type_desc = "view_type_desc";    //视图类型说明

 /// <summary>
 /// 常量:"is_active"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string is_active = "is_active";    //是否启用

 /// <summary>
 /// 常量:"sort_no"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string sort_no = "sort_no";    //排序号

 /// <summary>
 /// 常量:"Status"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Status = "Status";    //Status

 /// <summary>
 /// 常量:"created_by"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string created_by = "created_by";    //创建人

 /// <summary>
 /// 常量:"created_time"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string created_time = "created_time";    //创建时间

 /// <summary>
 /// 常量:"updated_by"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string updated_by = "updated_by";    //更新人

 /// <summary>
 /// 常量:"updated_time"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string updated_time = "updated_time";    //更新时间

 /// <summary>
 /// 常量:"remark"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string remark = "remark";    //备注
}

}