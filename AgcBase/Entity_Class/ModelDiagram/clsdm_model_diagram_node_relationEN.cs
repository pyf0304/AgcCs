
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsdm_model_diagram_node_relationEN
 表名:dm_model_diagram_node_relation(00050671)
 * 版本:2026.08.13(服务器:WIN-SRV103-116)
 日期:2026/08/18 05:24:12
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
 /// 表dm_model_diagram_node_relation的关键字(diagram_node_relation_id)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_diagram_node_relation_id_dm_model_diagram_node_relation
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngdiagram_node_relation_id">表关键字</param>
public K_diagram_node_relation_id_dm_model_diagram_node_relation(long lngdiagram_node_relation_id)
{
if (IsValid(lngdiagram_node_relation_id)) Value = lngdiagram_node_relation_id;
else
{
Value = 0;
}
}
private static bool IsValid(long lngdiagram_node_relation_id)
{
if (lngdiagram_node_relation_id == 0) return false;
if (lngdiagram_node_relation_id == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_diagram_node_relation_id_dm_model_diagram_node_relation]类型的对象</returns>
public static implicit operator K_diagram_node_relation_id_dm_model_diagram_node_relation(long value)
{
return new K_diagram_node_relation_id_dm_model_diagram_node_relation(value);
}
}
 /// <summary>
 /// 图结点关系(dm_model_diagram_node_relation)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsdm_model_diagram_node_relationEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "dm_model_diagram_node_relation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "diagram_node_relation_id"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 21;
public static string[] _AttributeName = new string[] {"diagram_node_relation_id", "PrjId", "diagram_id", "from_diagram_node_id", "to_diagram_node_id", "relation_type_code", "nature_code", "cardinality_code", "relation_label", "relation_desc", "route_manual", "line_style", "arrow_mode", "sort_no", "is_visible", "Status", "created_by", "created_time", "updated_by", "updated_time", "remark"};

protected long mlngdiagram_node_relation_id;    //图结点关系ID
protected string mstrPrjId;    //工程Id
protected string mstrdiagram_id;    //图ID
protected string mstrfrom_diagram_node_id;    //起点图结点ID
protected string mstrto_diagram_node_id;    //终点图结点ID
protected string mstrrelation_type_code;    //关系类型编码
protected string mstrnature_code;    //性质编码
protected string mstrcardinality_code;    //基数编码
protected string mstrrelation_label;    //关系语义
protected string mstrrelation_desc;    //关系说明
protected string mstrroute_manual;    //手工路由
protected string mstrline_style;    //线条样式
protected string mstrarrow_mode;    //箭头模式
protected int mintsort_no;    //排序号
protected bool mbolis_visible;    //是否可见
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
 public clsdm_model_diagram_node_relationEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("diagram_node_relation_id");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "lngdiagram_node_relation_id">关键字:图结点关系ID</param>
public clsdm_model_diagram_node_relationEN(long lngdiagram_node_relation_id)
 {
 if (lngdiagram_node_relation_id  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngdiagram_node_relation_id = lngdiagram_node_relation_id;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("diagram_node_relation_id");
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
if (strAttributeName  ==  condm_model_diagram_node_relation.diagram_node_relation_id)
{
return mlngdiagram_node_relation_id;
}
else if (strAttributeName  ==  condm_model_diagram_node_relation.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  condm_model_diagram_node_relation.diagram_id)
{
return mstrdiagram_id;
}
else if (strAttributeName  ==  condm_model_diagram_node_relation.from_diagram_node_id)
{
return mstrfrom_diagram_node_id;
}
else if (strAttributeName  ==  condm_model_diagram_node_relation.to_diagram_node_id)
{
return mstrto_diagram_node_id;
}
else if (strAttributeName  ==  condm_model_diagram_node_relation.relation_type_code)
{
return mstrrelation_type_code;
}
else if (strAttributeName  ==  condm_model_diagram_node_relation.nature_code)
{
return mstrnature_code;
}
else if (strAttributeName  ==  condm_model_diagram_node_relation.cardinality_code)
{
return mstrcardinality_code;
}
else if (strAttributeName  ==  condm_model_diagram_node_relation.relation_label)
{
return mstrrelation_label;
}
else if (strAttributeName  ==  condm_model_diagram_node_relation.relation_desc)
{
return mstrrelation_desc;
}
else if (strAttributeName  ==  condm_model_diagram_node_relation.route_manual)
{
return mstrroute_manual;
}
else if (strAttributeName  ==  condm_model_diagram_node_relation.line_style)
{
return mstrline_style;
}
else if (strAttributeName  ==  condm_model_diagram_node_relation.arrow_mode)
{
return mstrarrow_mode;
}
else if (strAttributeName  ==  condm_model_diagram_node_relation.sort_no)
{
return mintsort_no;
}
else if (strAttributeName  ==  condm_model_diagram_node_relation.is_visible)
{
return mbolis_visible;
}
else if (strAttributeName  ==  condm_model_diagram_node_relation.Status)
{
return mstrStatus;
}
else if (strAttributeName  ==  condm_model_diagram_node_relation.created_by)
{
return mstrcreated_by;
}
else if (strAttributeName  ==  condm_model_diagram_node_relation.created_time)
{
return mdtecreated_time;
}
else if (strAttributeName  ==  condm_model_diagram_node_relation.updated_by)
{
return mstrupdated_by;
}
else if (strAttributeName  ==  condm_model_diagram_node_relation.updated_time)
{
return mdteupdated_time;
}
else if (strAttributeName  ==  condm_model_diagram_node_relation.remark)
{
return mstrremark;
}
return null;
}
set
{
if (strAttributeName  ==  condm_model_diagram_node_relation.diagram_node_relation_id)
{
mlngdiagram_node_relation_id = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_diagram_node_relation.diagram_node_relation_id);
}
else if (strAttributeName  ==  condm_model_diagram_node_relation.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(condm_model_diagram_node_relation.PrjId);
}
else if (strAttributeName  ==  condm_model_diagram_node_relation.diagram_id)
{
mstrdiagram_id = value.ToString();
 AddUpdatedFld(condm_model_diagram_node_relation.diagram_id);
}
else if (strAttributeName  ==  condm_model_diagram_node_relation.from_diagram_node_id)
{
mstrfrom_diagram_node_id = value.ToString();
 AddUpdatedFld(condm_model_diagram_node_relation.from_diagram_node_id);
}
else if (strAttributeName  ==  condm_model_diagram_node_relation.to_diagram_node_id)
{
mstrto_diagram_node_id = value.ToString();
 AddUpdatedFld(condm_model_diagram_node_relation.to_diagram_node_id);
}
else if (strAttributeName  ==  condm_model_diagram_node_relation.relation_type_code)
{
mstrrelation_type_code = value.ToString();
 AddUpdatedFld(condm_model_diagram_node_relation.relation_type_code);
}
else if (strAttributeName  ==  condm_model_diagram_node_relation.nature_code)
{
mstrnature_code = value.ToString();
 AddUpdatedFld(condm_model_diagram_node_relation.nature_code);
}
else if (strAttributeName  ==  condm_model_diagram_node_relation.cardinality_code)
{
mstrcardinality_code = value.ToString();
 AddUpdatedFld(condm_model_diagram_node_relation.cardinality_code);
}
else if (strAttributeName  ==  condm_model_diagram_node_relation.relation_label)
{
mstrrelation_label = value.ToString();
 AddUpdatedFld(condm_model_diagram_node_relation.relation_label);
}
else if (strAttributeName  ==  condm_model_diagram_node_relation.relation_desc)
{
mstrrelation_desc = value.ToString();
 AddUpdatedFld(condm_model_diagram_node_relation.relation_desc);
}
else if (strAttributeName  ==  condm_model_diagram_node_relation.route_manual)
{
mstrroute_manual = value.ToString();
 AddUpdatedFld(condm_model_diagram_node_relation.route_manual);
}
else if (strAttributeName  ==  condm_model_diagram_node_relation.line_style)
{
mstrline_style = value.ToString();
 AddUpdatedFld(condm_model_diagram_node_relation.line_style);
}
else if (strAttributeName  ==  condm_model_diagram_node_relation.arrow_mode)
{
mstrarrow_mode = value.ToString();
 AddUpdatedFld(condm_model_diagram_node_relation.arrow_mode);
}
else if (strAttributeName  ==  condm_model_diagram_node_relation.sort_no)
{
mintsort_no = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_diagram_node_relation.sort_no);
}
else if (strAttributeName  ==  condm_model_diagram_node_relation.is_visible)
{
mbolis_visible = TransNullToBool(value.ToString());
 AddUpdatedFld(condm_model_diagram_node_relation.is_visible);
}
else if (strAttributeName  ==  condm_model_diagram_node_relation.Status)
{
mstrStatus = value.ToString();
 AddUpdatedFld(condm_model_diagram_node_relation.Status);
}
else if (strAttributeName  ==  condm_model_diagram_node_relation.created_by)
{
mstrcreated_by = value.ToString();
 AddUpdatedFld(condm_model_diagram_node_relation.created_by);
}
else if (strAttributeName  ==  condm_model_diagram_node_relation.created_time)
{
mdtecreated_time = TransNullToDate(value.ToString());
 AddUpdatedFld(condm_model_diagram_node_relation.created_time);
}
else if (strAttributeName  ==  condm_model_diagram_node_relation.updated_by)
{
mstrupdated_by = value.ToString();
 AddUpdatedFld(condm_model_diagram_node_relation.updated_by);
}
else if (strAttributeName  ==  condm_model_diagram_node_relation.updated_time)
{
mdteupdated_time = TransNullToDate(value.ToString());
 AddUpdatedFld(condm_model_diagram_node_relation.updated_time);
}
else if (strAttributeName  ==  condm_model_diagram_node_relation.remark)
{
mstrremark = value.ToString();
 AddUpdatedFld(condm_model_diagram_node_relation.remark);
}
}
}
public object this[int intIndex]
{
get
{
if (condm_model_diagram_node_relation.diagram_node_relation_id  ==  _AttributeName[intIndex])
{
return mlngdiagram_node_relation_id;
}
else if (condm_model_diagram_node_relation.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (condm_model_diagram_node_relation.diagram_id  ==  _AttributeName[intIndex])
{
return mstrdiagram_id;
}
else if (condm_model_diagram_node_relation.from_diagram_node_id  ==  _AttributeName[intIndex])
{
return mstrfrom_diagram_node_id;
}
else if (condm_model_diagram_node_relation.to_diagram_node_id  ==  _AttributeName[intIndex])
{
return mstrto_diagram_node_id;
}
else if (condm_model_diagram_node_relation.relation_type_code  ==  _AttributeName[intIndex])
{
return mstrrelation_type_code;
}
else if (condm_model_diagram_node_relation.nature_code  ==  _AttributeName[intIndex])
{
return mstrnature_code;
}
else if (condm_model_diagram_node_relation.cardinality_code  ==  _AttributeName[intIndex])
{
return mstrcardinality_code;
}
else if (condm_model_diagram_node_relation.relation_label  ==  _AttributeName[intIndex])
{
return mstrrelation_label;
}
else if (condm_model_diagram_node_relation.relation_desc  ==  _AttributeName[intIndex])
{
return mstrrelation_desc;
}
else if (condm_model_diagram_node_relation.route_manual  ==  _AttributeName[intIndex])
{
return mstrroute_manual;
}
else if (condm_model_diagram_node_relation.line_style  ==  _AttributeName[intIndex])
{
return mstrline_style;
}
else if (condm_model_diagram_node_relation.arrow_mode  ==  _AttributeName[intIndex])
{
return mstrarrow_mode;
}
else if (condm_model_diagram_node_relation.sort_no  ==  _AttributeName[intIndex])
{
return mintsort_no;
}
else if (condm_model_diagram_node_relation.is_visible  ==  _AttributeName[intIndex])
{
return mbolis_visible;
}
else if (condm_model_diagram_node_relation.Status  ==  _AttributeName[intIndex])
{
return mstrStatus;
}
else if (condm_model_diagram_node_relation.created_by  ==  _AttributeName[intIndex])
{
return mstrcreated_by;
}
else if (condm_model_diagram_node_relation.created_time  ==  _AttributeName[intIndex])
{
return mdtecreated_time;
}
else if (condm_model_diagram_node_relation.updated_by  ==  _AttributeName[intIndex])
{
return mstrupdated_by;
}
else if (condm_model_diagram_node_relation.updated_time  ==  _AttributeName[intIndex])
{
return mdteupdated_time;
}
else if (condm_model_diagram_node_relation.remark  ==  _AttributeName[intIndex])
{
return mstrremark;
}
return null;
}
set
{
if (condm_model_diagram_node_relation.diagram_node_relation_id  ==  _AttributeName[intIndex])
{
mlngdiagram_node_relation_id = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_diagram_node_relation.diagram_node_relation_id);
}
else if (condm_model_diagram_node_relation.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(condm_model_diagram_node_relation.PrjId);
}
else if (condm_model_diagram_node_relation.diagram_id  ==  _AttributeName[intIndex])
{
mstrdiagram_id = value.ToString();
 AddUpdatedFld(condm_model_diagram_node_relation.diagram_id);
}
else if (condm_model_diagram_node_relation.from_diagram_node_id  ==  _AttributeName[intIndex])
{
mstrfrom_diagram_node_id = value.ToString();
 AddUpdatedFld(condm_model_diagram_node_relation.from_diagram_node_id);
}
else if (condm_model_diagram_node_relation.to_diagram_node_id  ==  _AttributeName[intIndex])
{
mstrto_diagram_node_id = value.ToString();
 AddUpdatedFld(condm_model_diagram_node_relation.to_diagram_node_id);
}
else if (condm_model_diagram_node_relation.relation_type_code  ==  _AttributeName[intIndex])
{
mstrrelation_type_code = value.ToString();
 AddUpdatedFld(condm_model_diagram_node_relation.relation_type_code);
}
else if (condm_model_diagram_node_relation.nature_code  ==  _AttributeName[intIndex])
{
mstrnature_code = value.ToString();
 AddUpdatedFld(condm_model_diagram_node_relation.nature_code);
}
else if (condm_model_diagram_node_relation.cardinality_code  ==  _AttributeName[intIndex])
{
mstrcardinality_code = value.ToString();
 AddUpdatedFld(condm_model_diagram_node_relation.cardinality_code);
}
else if (condm_model_diagram_node_relation.relation_label  ==  _AttributeName[intIndex])
{
mstrrelation_label = value.ToString();
 AddUpdatedFld(condm_model_diagram_node_relation.relation_label);
}
else if (condm_model_diagram_node_relation.relation_desc  ==  _AttributeName[intIndex])
{
mstrrelation_desc = value.ToString();
 AddUpdatedFld(condm_model_diagram_node_relation.relation_desc);
}
else if (condm_model_diagram_node_relation.route_manual  ==  _AttributeName[intIndex])
{
mstrroute_manual = value.ToString();
 AddUpdatedFld(condm_model_diagram_node_relation.route_manual);
}
else if (condm_model_diagram_node_relation.line_style  ==  _AttributeName[intIndex])
{
mstrline_style = value.ToString();
 AddUpdatedFld(condm_model_diagram_node_relation.line_style);
}
else if (condm_model_diagram_node_relation.arrow_mode  ==  _AttributeName[intIndex])
{
mstrarrow_mode = value.ToString();
 AddUpdatedFld(condm_model_diagram_node_relation.arrow_mode);
}
else if (condm_model_diagram_node_relation.sort_no  ==  _AttributeName[intIndex])
{
mintsort_no = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_diagram_node_relation.sort_no);
}
else if (condm_model_diagram_node_relation.is_visible  ==  _AttributeName[intIndex])
{
mbolis_visible = TransNullToBool(value.ToString());
 AddUpdatedFld(condm_model_diagram_node_relation.is_visible);
}
else if (condm_model_diagram_node_relation.Status  ==  _AttributeName[intIndex])
{
mstrStatus = value.ToString();
 AddUpdatedFld(condm_model_diagram_node_relation.Status);
}
else if (condm_model_diagram_node_relation.created_by  ==  _AttributeName[intIndex])
{
mstrcreated_by = value.ToString();
 AddUpdatedFld(condm_model_diagram_node_relation.created_by);
}
else if (condm_model_diagram_node_relation.created_time  ==  _AttributeName[intIndex])
{
mdtecreated_time = TransNullToDate(value.ToString());
 AddUpdatedFld(condm_model_diagram_node_relation.created_time);
}
else if (condm_model_diagram_node_relation.updated_by  ==  _AttributeName[intIndex])
{
mstrupdated_by = value.ToString();
 AddUpdatedFld(condm_model_diagram_node_relation.updated_by);
}
else if (condm_model_diagram_node_relation.updated_time  ==  _AttributeName[intIndex])
{
mdteupdated_time = TransNullToDate(value.ToString());
 AddUpdatedFld(condm_model_diagram_node_relation.updated_time);
}
else if (condm_model_diagram_node_relation.remark  ==  _AttributeName[intIndex])
{
mstrremark = value.ToString();
 AddUpdatedFld(condm_model_diagram_node_relation.remark);
}
}
}

/// <summary>
/// 图结点关系ID(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long diagram_node_relation_id
{
get
{
return mlngdiagram_node_relation_id;
}
set
{
 mlngdiagram_node_relation_id = value;
//记录修改过的字段
 AddUpdatedFld(condm_model_diagram_node_relation.diagram_node_relation_id);
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
 AddUpdatedFld(condm_model_diagram_node_relation.PrjId);
}
}
/// <summary>
/// 图ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string diagram_id
{
get
{
return mstrdiagram_id;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrdiagram_id = value;
}
else
{
 mstrdiagram_id = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_diagram_node_relation.diagram_id);
}
}
/// <summary>
/// 起点图结点ID(说明:;字段类型:varchar;字段长度:32;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string from_diagram_node_id
{
get
{
return mstrfrom_diagram_node_id;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrfrom_diagram_node_id = value;
}
else
{
 mstrfrom_diagram_node_id = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_diagram_node_relation.from_diagram_node_id);
}
}
/// <summary>
/// 终点图结点ID(说明:;字段类型:varchar;字段长度:32;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string to_diagram_node_id
{
get
{
return mstrto_diagram_node_id;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrto_diagram_node_id = value;
}
else
{
 mstrto_diagram_node_id = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_diagram_node_relation.to_diagram_node_id);
}
}
/// <summary>
/// 关系类型编码(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string relation_type_code
{
get
{
return mstrrelation_type_code;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrrelation_type_code = value;
}
else
{
 mstrrelation_type_code = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_diagram_node_relation.relation_type_code);
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
 AddUpdatedFld(condm_model_diagram_node_relation.nature_code);
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
 AddUpdatedFld(condm_model_diagram_node_relation.cardinality_code);
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
 AddUpdatedFld(condm_model_diagram_node_relation.relation_label);
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
 AddUpdatedFld(condm_model_diagram_node_relation.relation_desc);
}
}
/// <summary>
/// 手工路由(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string route_manual
{
get
{
return mstrroute_manual;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrroute_manual = value;
}
else
{
 mstrroute_manual = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_diagram_node_relation.route_manual);
}
}
/// <summary>
/// 线条样式(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string line_style
{
get
{
return mstrline_style;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrline_style = value;
}
else
{
 mstrline_style = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_diagram_node_relation.line_style);
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
 AddUpdatedFld(condm_model_diagram_node_relation.arrow_mode);
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
 AddUpdatedFld(condm_model_diagram_node_relation.sort_no);
}
}
/// <summary>
/// 是否可见(说明:;字段类型:bit;字段长度:0;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool is_visible
{
get
{
return mbolis_visible;
}
set
{
 mbolis_visible = value;
//记录修改过的字段
 AddUpdatedFld(condm_model_diagram_node_relation.is_visible);
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
 AddUpdatedFld(condm_model_diagram_node_relation.Status);
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
 AddUpdatedFld(condm_model_diagram_node_relation.created_by);
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
 AddUpdatedFld(condm_model_diagram_node_relation.created_time);
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
 AddUpdatedFld(condm_model_diagram_node_relation.updated_by);
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
 AddUpdatedFld(condm_model_diagram_node_relation.updated_time);
}
}
/// <summary>
/// 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
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
 AddUpdatedFld(condm_model_diagram_node_relation.remark);
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
  return mlngdiagram_node_relation_id.ToString();
 }
 }
}
 /// <summary>
 /// 图结点关系(dm_model_diagram_node_relation)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class condm_model_diagram_node_relation
{
public const string _CurrTabName = "dm_model_diagram_node_relation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "diagram_node_relation_id"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"diagram_node_relation_id", "PrjId", "diagram_id", "from_diagram_node_id", "to_diagram_node_id", "relation_type_code", "nature_code", "cardinality_code", "relation_label", "relation_desc", "route_manual", "line_style", "arrow_mode", "sort_no", "is_visible", "Status", "created_by", "created_time", "updated_by", "updated_time", "remark"};
//以下是属性变量


 /// <summary>
 /// 常量:"diagram_node_relation_id"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string diagram_node_relation_id = "diagram_node_relation_id";    //图结点关系ID

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"diagram_id"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string diagram_id = "diagram_id";    //图ID

 /// <summary>
 /// 常量:"from_diagram_node_id"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string from_diagram_node_id = "from_diagram_node_id";    //起点图结点ID

 /// <summary>
 /// 常量:"to_diagram_node_id"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string to_diagram_node_id = "to_diagram_node_id";    //终点图结点ID

 /// <summary>
 /// 常量:"relation_type_code"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string relation_type_code = "relation_type_code";    //关系类型编码

 /// <summary>
 /// 常量:"nature_code"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string nature_code = "nature_code";    //性质编码

 /// <summary>
 /// 常量:"cardinality_code"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string cardinality_code = "cardinality_code";    //基数编码

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
 /// 常量:"route_manual"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string route_manual = "route_manual";    //手工路由

 /// <summary>
 /// 常量:"line_style"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string line_style = "line_style";    //线条样式

 /// <summary>
 /// 常量:"arrow_mode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string arrow_mode = "arrow_mode";    //箭头模式

 /// <summary>
 /// 常量:"sort_no"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string sort_no = "sort_no";    //排序号

 /// <summary>
 /// 常量:"is_visible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string is_visible = "is_visible";    //是否可见

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