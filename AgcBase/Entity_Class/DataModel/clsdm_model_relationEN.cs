
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsdm_model_relationEN
 表名:dm_model_relation(00050662)
 * 版本:2026.08.01(服务器:WIN-SRV103-116)
 日期:2026/08/04 10:58:05
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
 /// 表dm_model_relation的关键字(relation_id)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_relation_id_dm_model_relation
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strrelation_id">表关键字</param>
public K_relation_id_dm_model_relation(string strrelation_id)
{
if (IsValid(strrelation_id)) Value = strrelation_id;
else
{
Value = null;
}
}
private static bool IsValid(string strrelation_id)
{
if (string.IsNullOrEmpty(strrelation_id) == true) return false;
if (strrelation_id.Length > 32) return false;
if (strrelation_id.IndexOf(' ') >= 0) return false;
if (strrelation_id.IndexOf(')') >= 0) return false;
if (strrelation_id.IndexOf('(') >= 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_relation_id_dm_model_relation]类型的对象</returns>
public static implicit operator K_relation_id_dm_model_relation(string value)
{
return new K_relation_id_dm_model_relation(value);
}
}
 /// <summary>
 /// 关系定义表(dm_model_relation)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsdm_model_relationEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "dm_model_relation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "relation_id"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 22;
public static string[] _AttributeName = new string[] {"relation_id", "source_table", "source_table_cn", "target_table", "target_table_cn", "relation_nature", "cardinality_type", "source_fk_field", "target_pk_field", "bridge_table", "is_required", "enforcement_level", "relation_label", "relation_desc", "Status", "sort_no", "version_no", "created_by", "created_time", "updated_by", "updated_time", "remark"};

protected string mstrrelation_id;    //关系ID
protected string mstrsource_table;    //源表名
protected string mstrsource_table_cn;    //源表中文名
protected string mstrtarget_table;    //目标表名
protected string mstrtarget_table_cn;    //目标表中文名
protected string mstrrelation_nature;    //关系性质
protected string mstrcardinality_type;    //关系类型
protected string mstrsource_fk_field;    //源外键字段
protected string mstrtarget_pk_field;    //目标主键字段
protected string mstrbridge_table;    //中间桥表
protected bool mbolis_required;    //是否必选
protected string mstrenforcement_level;    //约束层级
protected string mstrrelation_label;    //关系语义
protected string mstrrelation_desc;    //关系说明
protected string mstrStatus;    //Status
protected int? mintsort_no;    //排序号
protected string mstrversion_no;    //版本号
protected string mstrcreated_by;    //创建人
protected DateTime mdtecreated_time;    //创建时间
protected string mstrupdated_by;    //更新人
protected DateTime mdteupdated_time;    //更新时间
protected string mstrremark;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsdm_model_relationEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("relation_id");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strrelation_id">关键字:关系ID</param>
public clsdm_model_relationEN(string strrelation_id)
 {
strrelation_id = strrelation_id.Replace("'", "''");
if (strrelation_id.Length > 32)
{
throw new Exception("在表:dm_model_relation中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strrelation_id)  ==  true)
{
throw new Exception("在表:dm_model_relation中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strrelation_id);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrrelation_id = strrelation_id;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("relation_id");
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
if (strAttributeName  ==  condm_model_relation.relation_id)
{
return mstrrelation_id;
}
else if (strAttributeName  ==  condm_model_relation.source_table)
{
return mstrsource_table;
}
else if (strAttributeName  ==  condm_model_relation.source_table_cn)
{
return mstrsource_table_cn;
}
else if (strAttributeName  ==  condm_model_relation.target_table)
{
return mstrtarget_table;
}
else if (strAttributeName  ==  condm_model_relation.target_table_cn)
{
return mstrtarget_table_cn;
}
else if (strAttributeName  ==  condm_model_relation.relation_nature)
{
return mstrrelation_nature;
}
else if (strAttributeName  ==  condm_model_relation.cardinality_type)
{
return mstrcardinality_type;
}
else if (strAttributeName  ==  condm_model_relation.source_fk_field)
{
return mstrsource_fk_field;
}
else if (strAttributeName  ==  condm_model_relation.target_pk_field)
{
return mstrtarget_pk_field;
}
else if (strAttributeName  ==  condm_model_relation.bridge_table)
{
return mstrbridge_table;
}
else if (strAttributeName  ==  condm_model_relation.is_required)
{
return mbolis_required;
}
else if (strAttributeName  ==  condm_model_relation.enforcement_level)
{
return mstrenforcement_level;
}
else if (strAttributeName  ==  condm_model_relation.relation_label)
{
return mstrrelation_label;
}
else if (strAttributeName  ==  condm_model_relation.relation_desc)
{
return mstrrelation_desc;
}
else if (strAttributeName  ==  condm_model_relation.Status)
{
return mstrStatus;
}
else if (strAttributeName  ==  condm_model_relation.sort_no)
{
return mintsort_no;
}
else if (strAttributeName  ==  condm_model_relation.version_no)
{
return mstrversion_no;
}
else if (strAttributeName  ==  condm_model_relation.created_by)
{
return mstrcreated_by;
}
else if (strAttributeName  ==  condm_model_relation.created_time)
{
return mdtecreated_time;
}
else if (strAttributeName  ==  condm_model_relation.updated_by)
{
return mstrupdated_by;
}
else if (strAttributeName  ==  condm_model_relation.updated_time)
{
return mdteupdated_time;
}
else if (strAttributeName  ==  condm_model_relation.remark)
{
return mstrremark;
}
return null;
}
set
{
if (strAttributeName  ==  condm_model_relation.relation_id)
{
mstrrelation_id = value.ToString();
 AddUpdatedFld(condm_model_relation.relation_id);
}
else if (strAttributeName  ==  condm_model_relation.source_table)
{
mstrsource_table = value.ToString();
 AddUpdatedFld(condm_model_relation.source_table);
}
else if (strAttributeName  ==  condm_model_relation.source_table_cn)
{
mstrsource_table_cn = value.ToString();
 AddUpdatedFld(condm_model_relation.source_table_cn);
}
else if (strAttributeName  ==  condm_model_relation.target_table)
{
mstrtarget_table = value.ToString();
 AddUpdatedFld(condm_model_relation.target_table);
}
else if (strAttributeName  ==  condm_model_relation.target_table_cn)
{
mstrtarget_table_cn = value.ToString();
 AddUpdatedFld(condm_model_relation.target_table_cn);
}
else if (strAttributeName  ==  condm_model_relation.relation_nature)
{
mstrrelation_nature = value.ToString();
 AddUpdatedFld(condm_model_relation.relation_nature);
}
else if (strAttributeName  ==  condm_model_relation.cardinality_type)
{
mstrcardinality_type = value.ToString();
 AddUpdatedFld(condm_model_relation.cardinality_type);
}
else if (strAttributeName  ==  condm_model_relation.source_fk_field)
{
mstrsource_fk_field = value.ToString();
 AddUpdatedFld(condm_model_relation.source_fk_field);
}
else if (strAttributeName  ==  condm_model_relation.target_pk_field)
{
mstrtarget_pk_field = value.ToString();
 AddUpdatedFld(condm_model_relation.target_pk_field);
}
else if (strAttributeName  ==  condm_model_relation.bridge_table)
{
mstrbridge_table = value.ToString();
 AddUpdatedFld(condm_model_relation.bridge_table);
}
else if (strAttributeName  ==  condm_model_relation.is_required)
{
mbolis_required = TransNullToBool(value.ToString());
 AddUpdatedFld(condm_model_relation.is_required);
}
else if (strAttributeName  ==  condm_model_relation.enforcement_level)
{
mstrenforcement_level = value.ToString();
 AddUpdatedFld(condm_model_relation.enforcement_level);
}
else if (strAttributeName  ==  condm_model_relation.relation_label)
{
mstrrelation_label = value.ToString();
 AddUpdatedFld(condm_model_relation.relation_label);
}
else if (strAttributeName  ==  condm_model_relation.relation_desc)
{
mstrrelation_desc = value.ToString();
 AddUpdatedFld(condm_model_relation.relation_desc);
}
else if (strAttributeName  ==  condm_model_relation.Status)
{
mstrStatus = value.ToString();
 AddUpdatedFld(condm_model_relation.Status);
}
else if (strAttributeName  ==  condm_model_relation.sort_no)
{
mintsort_no = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_relation.sort_no);
}
else if (strAttributeName  ==  condm_model_relation.version_no)
{
mstrversion_no = value.ToString();
 AddUpdatedFld(condm_model_relation.version_no);
}
else if (strAttributeName  ==  condm_model_relation.created_by)
{
mstrcreated_by = value.ToString();
 AddUpdatedFld(condm_model_relation.created_by);
}
else if (strAttributeName  ==  condm_model_relation.created_time)
{
mdtecreated_time = TransNullToDate(value.ToString());
 AddUpdatedFld(condm_model_relation.created_time);
}
else if (strAttributeName  ==  condm_model_relation.updated_by)
{
mstrupdated_by = value.ToString();
 AddUpdatedFld(condm_model_relation.updated_by);
}
else if (strAttributeName  ==  condm_model_relation.updated_time)
{
mdteupdated_time = TransNullToDate(value.ToString());
 AddUpdatedFld(condm_model_relation.updated_time);
}
else if (strAttributeName  ==  condm_model_relation.remark)
{
mstrremark = value.ToString();
 AddUpdatedFld(condm_model_relation.remark);
}
}
}
public object this[int intIndex]
{
get
{
if (condm_model_relation.relation_id  ==  _AttributeName[intIndex])
{
return mstrrelation_id;
}
else if (condm_model_relation.source_table  ==  _AttributeName[intIndex])
{
return mstrsource_table;
}
else if (condm_model_relation.source_table_cn  ==  _AttributeName[intIndex])
{
return mstrsource_table_cn;
}
else if (condm_model_relation.target_table  ==  _AttributeName[intIndex])
{
return mstrtarget_table;
}
else if (condm_model_relation.target_table_cn  ==  _AttributeName[intIndex])
{
return mstrtarget_table_cn;
}
else if (condm_model_relation.relation_nature  ==  _AttributeName[intIndex])
{
return mstrrelation_nature;
}
else if (condm_model_relation.cardinality_type  ==  _AttributeName[intIndex])
{
return mstrcardinality_type;
}
else if (condm_model_relation.source_fk_field  ==  _AttributeName[intIndex])
{
return mstrsource_fk_field;
}
else if (condm_model_relation.target_pk_field  ==  _AttributeName[intIndex])
{
return mstrtarget_pk_field;
}
else if (condm_model_relation.bridge_table  ==  _AttributeName[intIndex])
{
return mstrbridge_table;
}
else if (condm_model_relation.is_required  ==  _AttributeName[intIndex])
{
return mbolis_required;
}
else if (condm_model_relation.enforcement_level  ==  _AttributeName[intIndex])
{
return mstrenforcement_level;
}
else if (condm_model_relation.relation_label  ==  _AttributeName[intIndex])
{
return mstrrelation_label;
}
else if (condm_model_relation.relation_desc  ==  _AttributeName[intIndex])
{
return mstrrelation_desc;
}
else if (condm_model_relation.Status  ==  _AttributeName[intIndex])
{
return mstrStatus;
}
else if (condm_model_relation.sort_no  ==  _AttributeName[intIndex])
{
return mintsort_no;
}
else if (condm_model_relation.version_no  ==  _AttributeName[intIndex])
{
return mstrversion_no;
}
else if (condm_model_relation.created_by  ==  _AttributeName[intIndex])
{
return mstrcreated_by;
}
else if (condm_model_relation.created_time  ==  _AttributeName[intIndex])
{
return mdtecreated_time;
}
else if (condm_model_relation.updated_by  ==  _AttributeName[intIndex])
{
return mstrupdated_by;
}
else if (condm_model_relation.updated_time  ==  _AttributeName[intIndex])
{
return mdteupdated_time;
}
else if (condm_model_relation.remark  ==  _AttributeName[intIndex])
{
return mstrremark;
}
return null;
}
set
{
if (condm_model_relation.relation_id  ==  _AttributeName[intIndex])
{
mstrrelation_id = value.ToString();
 AddUpdatedFld(condm_model_relation.relation_id);
}
else if (condm_model_relation.source_table  ==  _AttributeName[intIndex])
{
mstrsource_table = value.ToString();
 AddUpdatedFld(condm_model_relation.source_table);
}
else if (condm_model_relation.source_table_cn  ==  _AttributeName[intIndex])
{
mstrsource_table_cn = value.ToString();
 AddUpdatedFld(condm_model_relation.source_table_cn);
}
else if (condm_model_relation.target_table  ==  _AttributeName[intIndex])
{
mstrtarget_table = value.ToString();
 AddUpdatedFld(condm_model_relation.target_table);
}
else if (condm_model_relation.target_table_cn  ==  _AttributeName[intIndex])
{
mstrtarget_table_cn = value.ToString();
 AddUpdatedFld(condm_model_relation.target_table_cn);
}
else if (condm_model_relation.relation_nature  ==  _AttributeName[intIndex])
{
mstrrelation_nature = value.ToString();
 AddUpdatedFld(condm_model_relation.relation_nature);
}
else if (condm_model_relation.cardinality_type  ==  _AttributeName[intIndex])
{
mstrcardinality_type = value.ToString();
 AddUpdatedFld(condm_model_relation.cardinality_type);
}
else if (condm_model_relation.source_fk_field  ==  _AttributeName[intIndex])
{
mstrsource_fk_field = value.ToString();
 AddUpdatedFld(condm_model_relation.source_fk_field);
}
else if (condm_model_relation.target_pk_field  ==  _AttributeName[intIndex])
{
mstrtarget_pk_field = value.ToString();
 AddUpdatedFld(condm_model_relation.target_pk_field);
}
else if (condm_model_relation.bridge_table  ==  _AttributeName[intIndex])
{
mstrbridge_table = value.ToString();
 AddUpdatedFld(condm_model_relation.bridge_table);
}
else if (condm_model_relation.is_required  ==  _AttributeName[intIndex])
{
mbolis_required = TransNullToBool(value.ToString());
 AddUpdatedFld(condm_model_relation.is_required);
}
else if (condm_model_relation.enforcement_level  ==  _AttributeName[intIndex])
{
mstrenforcement_level = value.ToString();
 AddUpdatedFld(condm_model_relation.enforcement_level);
}
else if (condm_model_relation.relation_label  ==  _AttributeName[intIndex])
{
mstrrelation_label = value.ToString();
 AddUpdatedFld(condm_model_relation.relation_label);
}
else if (condm_model_relation.relation_desc  ==  _AttributeName[intIndex])
{
mstrrelation_desc = value.ToString();
 AddUpdatedFld(condm_model_relation.relation_desc);
}
else if (condm_model_relation.Status  ==  _AttributeName[intIndex])
{
mstrStatus = value.ToString();
 AddUpdatedFld(condm_model_relation.Status);
}
else if (condm_model_relation.sort_no  ==  _AttributeName[intIndex])
{
mintsort_no = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_relation.sort_no);
}
else if (condm_model_relation.version_no  ==  _AttributeName[intIndex])
{
mstrversion_no = value.ToString();
 AddUpdatedFld(condm_model_relation.version_no);
}
else if (condm_model_relation.created_by  ==  _AttributeName[intIndex])
{
mstrcreated_by = value.ToString();
 AddUpdatedFld(condm_model_relation.created_by);
}
else if (condm_model_relation.created_time  ==  _AttributeName[intIndex])
{
mdtecreated_time = TransNullToDate(value.ToString());
 AddUpdatedFld(condm_model_relation.created_time);
}
else if (condm_model_relation.updated_by  ==  _AttributeName[intIndex])
{
mstrupdated_by = value.ToString();
 AddUpdatedFld(condm_model_relation.updated_by);
}
else if (condm_model_relation.updated_time  ==  _AttributeName[intIndex])
{
mdteupdated_time = TransNullToDate(value.ToString());
 AddUpdatedFld(condm_model_relation.updated_time);
}
else if (condm_model_relation.remark  ==  _AttributeName[intIndex])
{
mstrremark = value.ToString();
 AddUpdatedFld(condm_model_relation.remark);
}
}
}

/// <summary>
/// 关系ID(说明:;字段类型:varchar;字段长度:32;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string relation_id
{
get
{
return mstrrelation_id;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrrelation_id = value;
}
else
{
 mstrrelation_id = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_relation.relation_id);
}
}
/// <summary>
/// 源表名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string source_table
{
get
{
return mstrsource_table;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrsource_table = value;
}
else
{
 mstrsource_table = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_relation.source_table);
}
}
/// <summary>
/// 源表中文名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string source_table_cn
{
get
{
return mstrsource_table_cn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrsource_table_cn = value;
}
else
{
 mstrsource_table_cn = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_relation.source_table_cn);
}
}
/// <summary>
/// 目标表名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string target_table
{
get
{
return mstrtarget_table;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrtarget_table = value;
}
else
{
 mstrtarget_table = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_relation.target_table);
}
}
/// <summary>
/// 目标表中文名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string target_table_cn
{
get
{
return mstrtarget_table_cn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrtarget_table_cn = value;
}
else
{
 mstrtarget_table_cn = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_relation.target_table_cn);
}
}
/// <summary>
/// 关系性质(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string relation_nature
{
get
{
return mstrrelation_nature;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrrelation_nature = value;
}
else
{
 mstrrelation_nature = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_relation.relation_nature);
}
}
/// <summary>
/// 关系类型(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string cardinality_type
{
get
{
return mstrcardinality_type;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrcardinality_type = value;
}
else
{
 mstrcardinality_type = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_relation.cardinality_type);
}
}
/// <summary>
/// 源外键字段(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string source_fk_field
{
get
{
return mstrsource_fk_field;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrsource_fk_field = value;
}
else
{
 mstrsource_fk_field = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_relation.source_fk_field);
}
}
/// <summary>
/// 目标主键字段(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string target_pk_field
{
get
{
return mstrtarget_pk_field;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrtarget_pk_field = value;
}
else
{
 mstrtarget_pk_field = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_relation.target_pk_field);
}
}
/// <summary>
/// 中间桥表(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string bridge_table
{
get
{
return mstrbridge_table;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrbridge_table = value;
}
else
{
 mstrbridge_table = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_relation.bridge_table);
}
}
/// <summary>
/// 是否必选(说明:;字段类型:bit;字段长度:0;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool is_required
{
get
{
return mbolis_required;
}
set
{
 mbolis_required = value;
//记录修改过的字段
 AddUpdatedFld(condm_model_relation.is_required);
}
}
/// <summary>
/// 约束层级(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string enforcement_level
{
get
{
return mstrenforcement_level;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrenforcement_level = value;
}
else
{
 mstrenforcement_level = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_relation.enforcement_level);
}
}
/// <summary>
/// 关系语义(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string relation_label
{
get
{
return mstrrelation_label;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrrelation_label = value;
}
else
{
 mstrrelation_label = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_relation.relation_label);
}
}
/// <summary>
/// 关系说明(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string relation_desc
{
get
{
return mstrrelation_desc;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrrelation_desc = value;
}
else
{
 mstrrelation_desc = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_relation.relation_desc);
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
 AddUpdatedFld(condm_model_relation.Status);
}
}
/// <summary>
/// 排序号(说明:;字段类型:int;字段长度:0;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? sort_no
{
get
{
return mintsort_no;
}
set
{
 mintsort_no = value;
//记录修改过的字段
 AddUpdatedFld(condm_model_relation.sort_no);
}
}
/// <summary>
/// 版本号(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string version_no
{
get
{
return mstrversion_no;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrversion_no = value;
}
else
{
 mstrversion_no = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_relation.version_no);
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
 AddUpdatedFld(condm_model_relation.created_by);
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
 AddUpdatedFld(condm_model_relation.created_time);
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
 AddUpdatedFld(condm_model_relation.updated_by);
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
 AddUpdatedFld(condm_model_relation.updated_time);
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
 AddUpdatedFld(condm_model_relation.remark);
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
  return mstrrelation_id;
 }
 }
}
 /// <summary>
 /// 关系定义表(dm_model_relation)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class condm_model_relation
{
public const string _CurrTabName = "dm_model_relation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "relation_id"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"relation_id", "source_table", "source_table_cn", "target_table", "target_table_cn", "relation_nature", "cardinality_type", "source_fk_field", "target_pk_field", "bridge_table", "is_required", "enforcement_level", "relation_label", "relation_desc", "Status", "sort_no", "version_no", "created_by", "created_time", "updated_by", "updated_time", "remark"};
//以下是属性变量


 /// <summary>
 /// 常量:"relation_id"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string relation_id = "relation_id";    //关系ID

 /// <summary>
 /// 常量:"source_table"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string source_table = "source_table";    //源表名

 /// <summary>
 /// 常量:"source_table_cn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string source_table_cn = "source_table_cn";    //源表中文名

 /// <summary>
 /// 常量:"target_table"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string target_table = "target_table";    //目标表名

 /// <summary>
 /// 常量:"target_table_cn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string target_table_cn = "target_table_cn";    //目标表中文名

 /// <summary>
 /// 常量:"relation_nature"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string relation_nature = "relation_nature";    //关系性质

 /// <summary>
 /// 常量:"cardinality_type"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string cardinality_type = "cardinality_type";    //关系类型

 /// <summary>
 /// 常量:"source_fk_field"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string source_fk_field = "source_fk_field";    //源外键字段

 /// <summary>
 /// 常量:"target_pk_field"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string target_pk_field = "target_pk_field";    //目标主键字段

 /// <summary>
 /// 常量:"bridge_table"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string bridge_table = "bridge_table";    //中间桥表

 /// <summary>
 /// 常量:"is_required"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string is_required = "is_required";    //是否必选

 /// <summary>
 /// 常量:"enforcement_level"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string enforcement_level = "enforcement_level";    //约束层级

 /// <summary>
 /// 常量:"relation_label"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string relation_label = "relation_label";    //关系语义

 /// <summary>
 /// 常量:"relation_desc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string relation_desc = "relation_desc";    //关系说明

 /// <summary>
 /// 常量:"Status"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Status = "Status";    //Status

 /// <summary>
 /// 常量:"sort_no"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string sort_no = "sort_no";    //排序号

 /// <summary>
 /// 常量:"version_no"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string version_no = "version_no";    //版本号

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