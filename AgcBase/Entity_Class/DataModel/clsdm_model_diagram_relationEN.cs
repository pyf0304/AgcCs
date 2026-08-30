
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsdm_model_diagram_relationEN
 表名:dm_model_diagram_relation(00050666)
 * 版本:2026.08.01(服务器:WIN-SRV103-116)
 日期:2026/08/05 16:02:19
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
 /// 表dm_model_diagram_relation的关键字(diagram_relation_id)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_diagram_relation_id_dm_model_diagram_relation
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strdiagram_relation_id">表关键字</param>
public K_diagram_relation_id_dm_model_diagram_relation(string strdiagram_relation_id)
{
if (IsValid(strdiagram_relation_id)) Value = strdiagram_relation_id;
else
{
Value = null;
}
}
private static bool IsValid(string strdiagram_relation_id)
{
if (string.IsNullOrEmpty(strdiagram_relation_id) == true) return false;
if (strdiagram_relation_id.Length > 32) return false;
if (strdiagram_relation_id.IndexOf(' ') >= 0) return false;
if (strdiagram_relation_id.IndexOf(')') >= 0) return false;
if (strdiagram_relation_id.IndexOf('(') >= 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_diagram_relation_id_dm_model_diagram_relation]类型的对象</returns>
public static implicit operator K_diagram_relation_id_dm_model_diagram_relation(string value)
{
return new K_diagram_relation_id_dm_model_diagram_relation(value);
}
}
 /// <summary>
 /// 数据模型图关系映射(dm_model_diagram_relation)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsdm_model_diagram_relationEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "dm_model_diagram_relation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "diagram_relation_id"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 21;
public static string[] _AttributeName = new string[] {"diagram_relation_id", "prj_id", "diagram_id", "relation_id", "relation_view_type", "line_style", "arrow_mode", "sort_no", "is_visible", "route_points_json", "source_port_side", "target_port_side", "source_port_slot", "target_port_slot", "route_algo", "Status", "created_by", "created_time", "updated_by", "updated_time", "remark"};

protected string mstrdiagram_relation_id;    //图关系映射ID
protected string mstrprj_id;    //项目ID
protected string mstrdiagram_id;    //图ID
protected string mstrrelation_id;    //关系ID
protected string mstrrelation_view_type;    //关系视图类型
protected string mstrline_style;    //线条样式
protected string mstrarrow_mode;    //箭头模式
protected int mintsort_no;    //排序号
protected bool mbolis_visible;    //是否可见
protected string mstrroute_points_json;    //连线路径点JSON
protected string mstrsource_port_side;    //起点端口边
protected string mstrtarget_port_side;    //终点端口边
protected int? mintsource_port_slot;    //起点端口槽位
protected int? minttarget_port_slot;    //终点端口槽位
protected string mstrroute_algo;    //路线算法版本
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
 public clsdm_model_diagram_relationEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("diagram_relation_id");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strdiagram_relation_id">关键字:图关系映射ID</param>
public clsdm_model_diagram_relationEN(string strdiagram_relation_id)
 {
strdiagram_relation_id = strdiagram_relation_id.Replace("'", "''");
if (strdiagram_relation_id.Length > 32)
{
throw new Exception("在表:dm_model_diagram_relation中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strdiagram_relation_id)  ==  true)
{
throw new Exception("在表:dm_model_diagram_relation中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strdiagram_relation_id);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrdiagram_relation_id = strdiagram_relation_id;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("diagram_relation_id");
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
if (strAttributeName  ==  condm_model_diagram_relation.diagram_relation_id)
{
return mstrdiagram_relation_id;
}
else if (strAttributeName  ==  condm_model_diagram_relation.prj_id)
{
return mstrprj_id;
}
else if (strAttributeName  ==  condm_model_diagram_relation.diagram_id)
{
return mstrdiagram_id;
}
else if (strAttributeName  ==  condm_model_diagram_relation.relation_id)
{
return mstrrelation_id;
}
else if (strAttributeName  ==  condm_model_diagram_relation.relation_view_type)
{
return mstrrelation_view_type;
}
else if (strAttributeName  ==  condm_model_diagram_relation.line_style)
{
return mstrline_style;
}
else if (strAttributeName  ==  condm_model_diagram_relation.arrow_mode)
{
return mstrarrow_mode;
}
else if (strAttributeName  ==  condm_model_diagram_relation.sort_no)
{
return mintsort_no;
}
else if (strAttributeName  ==  condm_model_diagram_relation.is_visible)
{
return mbolis_visible;
}
else if (strAttributeName  ==  condm_model_diagram_relation.route_points_json)
{
return mstrroute_points_json;
}
else if (strAttributeName  ==  condm_model_diagram_relation.source_port_side)
{
return mstrsource_port_side;
}
else if (strAttributeName  ==  condm_model_diagram_relation.target_port_side)
{
return mstrtarget_port_side;
}
else if (strAttributeName  ==  condm_model_diagram_relation.source_port_slot)
{
return mintsource_port_slot;
}
else if (strAttributeName  ==  condm_model_diagram_relation.target_port_slot)
{
return minttarget_port_slot;
}
else if (strAttributeName  ==  condm_model_diagram_relation.route_algo)
{
return mstrroute_algo;
}
else if (strAttributeName  ==  condm_model_diagram_relation.Status)
{
return mstrStatus;
}
else if (strAttributeName  ==  condm_model_diagram_relation.created_by)
{
return mstrcreated_by;
}
else if (strAttributeName  ==  condm_model_diagram_relation.created_time)
{
return mdtecreated_time;
}
else if (strAttributeName  ==  condm_model_diagram_relation.updated_by)
{
return mstrupdated_by;
}
else if (strAttributeName  ==  condm_model_diagram_relation.updated_time)
{
return mdteupdated_time;
}
else if (strAttributeName  ==  condm_model_diagram_relation.remark)
{
return mstrremark;
}
return null;
}
set
{
if (strAttributeName  ==  condm_model_diagram_relation.diagram_relation_id)
{
mstrdiagram_relation_id = value.ToString();
 AddUpdatedFld(condm_model_diagram_relation.diagram_relation_id);
}
else if (strAttributeName  ==  condm_model_diagram_relation.prj_id)
{
mstrprj_id = value.ToString();
 AddUpdatedFld(condm_model_diagram_relation.prj_id);
}
else if (strAttributeName  ==  condm_model_diagram_relation.diagram_id)
{
mstrdiagram_id = value.ToString();
 AddUpdatedFld(condm_model_diagram_relation.diagram_id);
}
else if (strAttributeName  ==  condm_model_diagram_relation.relation_id)
{
mstrrelation_id = value.ToString();
 AddUpdatedFld(condm_model_diagram_relation.relation_id);
}
else if (strAttributeName  ==  condm_model_diagram_relation.relation_view_type)
{
mstrrelation_view_type = value.ToString();
 AddUpdatedFld(condm_model_diagram_relation.relation_view_type);
}
else if (strAttributeName  ==  condm_model_diagram_relation.line_style)
{
mstrline_style = value.ToString();
 AddUpdatedFld(condm_model_diagram_relation.line_style);
}
else if (strAttributeName  ==  condm_model_diagram_relation.arrow_mode)
{
mstrarrow_mode = value.ToString();
 AddUpdatedFld(condm_model_diagram_relation.arrow_mode);
}
else if (strAttributeName  ==  condm_model_diagram_relation.sort_no)
{
mintsort_no = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_diagram_relation.sort_no);
}
else if (strAttributeName  ==  condm_model_diagram_relation.is_visible)
{
mbolis_visible = TransNullToBool(value.ToString());
 AddUpdatedFld(condm_model_diagram_relation.is_visible);
}
else if (strAttributeName  ==  condm_model_diagram_relation.route_points_json)
{
mstrroute_points_json = value.ToString();
 AddUpdatedFld(condm_model_diagram_relation.route_points_json);
}
else if (strAttributeName  ==  condm_model_diagram_relation.source_port_side)
{
mstrsource_port_side = value.ToString();
 AddUpdatedFld(condm_model_diagram_relation.source_port_side);
}
else if (strAttributeName  ==  condm_model_diagram_relation.target_port_side)
{
mstrtarget_port_side = value.ToString();
 AddUpdatedFld(condm_model_diagram_relation.target_port_side);
}
else if (strAttributeName  ==  condm_model_diagram_relation.source_port_slot)
{
mintsource_port_slot = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_diagram_relation.source_port_slot);
}
else if (strAttributeName  ==  condm_model_diagram_relation.target_port_slot)
{
minttarget_port_slot = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_diagram_relation.target_port_slot);
}
else if (strAttributeName  ==  condm_model_diagram_relation.route_algo)
{
mstrroute_algo = value.ToString();
 AddUpdatedFld(condm_model_diagram_relation.route_algo);
}
else if (strAttributeName  ==  condm_model_diagram_relation.Status)
{
mstrStatus = value.ToString();
 AddUpdatedFld(condm_model_diagram_relation.Status);
}
else if (strAttributeName  ==  condm_model_diagram_relation.created_by)
{
mstrcreated_by = value.ToString();
 AddUpdatedFld(condm_model_diagram_relation.created_by);
}
else if (strAttributeName  ==  condm_model_diagram_relation.created_time)
{
mdtecreated_time = TransNullToDate(value.ToString());
 AddUpdatedFld(condm_model_diagram_relation.created_time);
}
else if (strAttributeName  ==  condm_model_diagram_relation.updated_by)
{
mstrupdated_by = value.ToString();
 AddUpdatedFld(condm_model_diagram_relation.updated_by);
}
else if (strAttributeName  ==  condm_model_diagram_relation.updated_time)
{
mdteupdated_time = TransNullToDate(value.ToString());
 AddUpdatedFld(condm_model_diagram_relation.updated_time);
}
else if (strAttributeName  ==  condm_model_diagram_relation.remark)
{
mstrremark = value.ToString();
 AddUpdatedFld(condm_model_diagram_relation.remark);
}
}
}
public object this[int intIndex]
{
get
{
if (condm_model_diagram_relation.diagram_relation_id  ==  _AttributeName[intIndex])
{
return mstrdiagram_relation_id;
}
else if (condm_model_diagram_relation.prj_id  ==  _AttributeName[intIndex])
{
return mstrprj_id;
}
else if (condm_model_diagram_relation.diagram_id  ==  _AttributeName[intIndex])
{
return mstrdiagram_id;
}
else if (condm_model_diagram_relation.relation_id  ==  _AttributeName[intIndex])
{
return mstrrelation_id;
}
else if (condm_model_diagram_relation.relation_view_type  ==  _AttributeName[intIndex])
{
return mstrrelation_view_type;
}
else if (condm_model_diagram_relation.line_style  ==  _AttributeName[intIndex])
{
return mstrline_style;
}
else if (condm_model_diagram_relation.arrow_mode  ==  _AttributeName[intIndex])
{
return mstrarrow_mode;
}
else if (condm_model_diagram_relation.sort_no  ==  _AttributeName[intIndex])
{
return mintsort_no;
}
else if (condm_model_diagram_relation.is_visible  ==  _AttributeName[intIndex])
{
return mbolis_visible;
}
else if (condm_model_diagram_relation.route_points_json  ==  _AttributeName[intIndex])
{
return mstrroute_points_json;
}
else if (condm_model_diagram_relation.source_port_side  ==  _AttributeName[intIndex])
{
return mstrsource_port_side;
}
else if (condm_model_diagram_relation.target_port_side  ==  _AttributeName[intIndex])
{
return mstrtarget_port_side;
}
else if (condm_model_diagram_relation.source_port_slot  ==  _AttributeName[intIndex])
{
return mintsource_port_slot;
}
else if (condm_model_diagram_relation.target_port_slot  ==  _AttributeName[intIndex])
{
return minttarget_port_slot;
}
else if (condm_model_diagram_relation.route_algo  ==  _AttributeName[intIndex])
{
return mstrroute_algo;
}
else if (condm_model_diagram_relation.Status  ==  _AttributeName[intIndex])
{
return mstrStatus;
}
else if (condm_model_diagram_relation.created_by  ==  _AttributeName[intIndex])
{
return mstrcreated_by;
}
else if (condm_model_diagram_relation.created_time  ==  _AttributeName[intIndex])
{
return mdtecreated_time;
}
else if (condm_model_diagram_relation.updated_by  ==  _AttributeName[intIndex])
{
return mstrupdated_by;
}
else if (condm_model_diagram_relation.updated_time  ==  _AttributeName[intIndex])
{
return mdteupdated_time;
}
else if (condm_model_diagram_relation.remark  ==  _AttributeName[intIndex])
{
return mstrremark;
}
return null;
}
set
{
if (condm_model_diagram_relation.diagram_relation_id  ==  _AttributeName[intIndex])
{
mstrdiagram_relation_id = value.ToString();
 AddUpdatedFld(condm_model_diagram_relation.diagram_relation_id);
}
else if (condm_model_diagram_relation.prj_id  ==  _AttributeName[intIndex])
{
mstrprj_id = value.ToString();
 AddUpdatedFld(condm_model_diagram_relation.prj_id);
}
else if (condm_model_diagram_relation.diagram_id  ==  _AttributeName[intIndex])
{
mstrdiagram_id = value.ToString();
 AddUpdatedFld(condm_model_diagram_relation.diagram_id);
}
else if (condm_model_diagram_relation.relation_id  ==  _AttributeName[intIndex])
{
mstrrelation_id = value.ToString();
 AddUpdatedFld(condm_model_diagram_relation.relation_id);
}
else if (condm_model_diagram_relation.relation_view_type  ==  _AttributeName[intIndex])
{
mstrrelation_view_type = value.ToString();
 AddUpdatedFld(condm_model_diagram_relation.relation_view_type);
}
else if (condm_model_diagram_relation.line_style  ==  _AttributeName[intIndex])
{
mstrline_style = value.ToString();
 AddUpdatedFld(condm_model_diagram_relation.line_style);
}
else if (condm_model_diagram_relation.arrow_mode  ==  _AttributeName[intIndex])
{
mstrarrow_mode = value.ToString();
 AddUpdatedFld(condm_model_diagram_relation.arrow_mode);
}
else if (condm_model_diagram_relation.sort_no  ==  _AttributeName[intIndex])
{
mintsort_no = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_diagram_relation.sort_no);
}
else if (condm_model_diagram_relation.is_visible  ==  _AttributeName[intIndex])
{
mbolis_visible = TransNullToBool(value.ToString());
 AddUpdatedFld(condm_model_diagram_relation.is_visible);
}
else if (condm_model_diagram_relation.route_points_json  ==  _AttributeName[intIndex])
{
mstrroute_points_json = value.ToString();
 AddUpdatedFld(condm_model_diagram_relation.route_points_json);
}
else if (condm_model_diagram_relation.source_port_side  ==  _AttributeName[intIndex])
{
mstrsource_port_side = value.ToString();
 AddUpdatedFld(condm_model_diagram_relation.source_port_side);
}
else if (condm_model_diagram_relation.target_port_side  ==  _AttributeName[intIndex])
{
mstrtarget_port_side = value.ToString();
 AddUpdatedFld(condm_model_diagram_relation.target_port_side);
}
else if (condm_model_diagram_relation.source_port_slot  ==  _AttributeName[intIndex])
{
mintsource_port_slot = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_diagram_relation.source_port_slot);
}
else if (condm_model_diagram_relation.target_port_slot  ==  _AttributeName[intIndex])
{
minttarget_port_slot = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_diagram_relation.target_port_slot);
}
else if (condm_model_diagram_relation.route_algo  ==  _AttributeName[intIndex])
{
mstrroute_algo = value.ToString();
 AddUpdatedFld(condm_model_diagram_relation.route_algo);
}
else if (condm_model_diagram_relation.Status  ==  _AttributeName[intIndex])
{
mstrStatus = value.ToString();
 AddUpdatedFld(condm_model_diagram_relation.Status);
}
else if (condm_model_diagram_relation.created_by  ==  _AttributeName[intIndex])
{
mstrcreated_by = value.ToString();
 AddUpdatedFld(condm_model_diagram_relation.created_by);
}
else if (condm_model_diagram_relation.created_time  ==  _AttributeName[intIndex])
{
mdtecreated_time = TransNullToDate(value.ToString());
 AddUpdatedFld(condm_model_diagram_relation.created_time);
}
else if (condm_model_diagram_relation.updated_by  ==  _AttributeName[intIndex])
{
mstrupdated_by = value.ToString();
 AddUpdatedFld(condm_model_diagram_relation.updated_by);
}
else if (condm_model_diagram_relation.updated_time  ==  _AttributeName[intIndex])
{
mdteupdated_time = TransNullToDate(value.ToString());
 AddUpdatedFld(condm_model_diagram_relation.updated_time);
}
else if (condm_model_diagram_relation.remark  ==  _AttributeName[intIndex])
{
mstrremark = value.ToString();
 AddUpdatedFld(condm_model_diagram_relation.remark);
}
}
}

/// <summary>
/// 图关系映射ID(说明:;字段类型:varchar;字段长度:32;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string diagram_relation_id
{
get
{
return mstrdiagram_relation_id;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrdiagram_relation_id = value;
}
else
{
 mstrdiagram_relation_id = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_diagram_relation.diagram_relation_id);
}
}
/// <summary>
/// 项目ID(说明:;字段类型:varchar;字段长度:32;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string prj_id
{
get
{
return mstrprj_id;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrprj_id = value;
}
else
{
 mstrprj_id = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_diagram_relation.prj_id);
}
}
/// <summary>
/// 图ID(说明:;字段类型:varchar;字段长度:32;是否可空:False)
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
 AddUpdatedFld(condm_model_diagram_relation.diagram_id);
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
 AddUpdatedFld(condm_model_diagram_relation.relation_id);
}
}
/// <summary>
/// 关系视图类型(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string relation_view_type
{
get
{
return mstrrelation_view_type;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrrelation_view_type = value;
}
else
{
 mstrrelation_view_type = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_diagram_relation.relation_view_type);
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
 AddUpdatedFld(condm_model_diagram_relation.line_style);
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
 AddUpdatedFld(condm_model_diagram_relation.arrow_mode);
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
 AddUpdatedFld(condm_model_diagram_relation.sort_no);
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
 AddUpdatedFld(condm_model_diagram_relation.is_visible);
}
}
/// <summary>
/// 连线路径点JSON(说明:;字段类型:varchar;字段长度:4000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string route_points_json
{
get
{
return mstrroute_points_json;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrroute_points_json = value;
}
else
{
 mstrroute_points_json = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_diagram_relation.route_points_json);
}
}
/// <summary>
/// 起点端口边(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string source_port_side
{
get
{
return mstrsource_port_side;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrsource_port_side = value;
}
else
{
 mstrsource_port_side = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_diagram_relation.source_port_side);
}
}
/// <summary>
/// 终点端口边(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string target_port_side
{
get
{
return mstrtarget_port_side;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrtarget_port_side = value;
}
else
{
 mstrtarget_port_side = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_diagram_relation.target_port_side);
}
}
/// <summary>
/// 起点端口槽位(说明:;字段类型:int;字段长度:0;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? source_port_slot
{
get
{
return mintsource_port_slot;
}
set
{
 mintsource_port_slot = value;
//记录修改过的字段
 AddUpdatedFld(condm_model_diagram_relation.source_port_slot);
}
}
/// <summary>
/// 终点端口槽位(说明:;字段类型:int;字段长度:0;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? target_port_slot
{
get
{
return minttarget_port_slot;
}
set
{
 minttarget_port_slot = value;
//记录修改过的字段
 AddUpdatedFld(condm_model_diagram_relation.target_port_slot);
}
}
/// <summary>
/// 路线算法版本(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string route_algo
{
get
{
return mstrroute_algo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrroute_algo = value;
}
else
{
 mstrroute_algo = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_diagram_relation.route_algo);
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
 AddUpdatedFld(condm_model_diagram_relation.Status);
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
 AddUpdatedFld(condm_model_diagram_relation.created_by);
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
 AddUpdatedFld(condm_model_diagram_relation.created_time);
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
 AddUpdatedFld(condm_model_diagram_relation.updated_by);
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
 AddUpdatedFld(condm_model_diagram_relation.updated_time);
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
 AddUpdatedFld(condm_model_diagram_relation.remark);
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
  return mstrdiagram_relation_id;
 }
 }
}
 /// <summary>
 /// 数据模型图关系映射(dm_model_diagram_relation)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class condm_model_diagram_relation
{
public const string _CurrTabName = "dm_model_diagram_relation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "diagram_relation_id"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"diagram_relation_id", "prj_id", "diagram_id", "relation_id", "relation_view_type", "line_style", "arrow_mode", "sort_no", "is_visible", "route_points_json", "source_port_side", "target_port_side", "source_port_slot", "target_port_slot", "route_algo", "Status", "created_by", "created_time", "updated_by", "updated_time", "remark"};
//以下是属性变量


 /// <summary>
 /// 常量:"diagram_relation_id"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string diagram_relation_id = "diagram_relation_id";    //图关系映射ID

 /// <summary>
 /// 常量:"prj_id"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string prj_id = "prj_id";    //项目ID

 /// <summary>
 /// 常量:"diagram_id"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string diagram_id = "diagram_id";    //图ID

 /// <summary>
 /// 常量:"relation_id"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string relation_id = "relation_id";    //关系ID

 /// <summary>
 /// 常量:"relation_view_type"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string relation_view_type = "relation_view_type";    //关系视图类型

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
 /// 常量:"route_points_json"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string route_points_json = "route_points_json";    //连线路径点JSON

 /// <summary>
 /// 常量:"source_port_side"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string source_port_side = "source_port_side";    //起点端口边

 /// <summary>
 /// 常量:"target_port_side"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string target_port_side = "target_port_side";    //终点端口边

 /// <summary>
 /// 常量:"source_port_slot"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string source_port_slot = "source_port_slot";    //起点端口槽位

 /// <summary>
 /// 常量:"target_port_slot"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string target_port_slot = "target_port_slot";    //终点端口槽位

 /// <summary>
 /// 常量:"route_algo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string route_algo = "route_algo";    //路线算法版本

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