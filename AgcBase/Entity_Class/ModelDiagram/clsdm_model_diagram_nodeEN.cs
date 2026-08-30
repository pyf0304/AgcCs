
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsdm_model_diagram_nodeEN
 表名:dm_model_diagram_node(00050668)
 * 版本:2026.08.13(服务器:WIN-SRV103-116)
 日期:2026/08/18 16:25:32
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
 /// 表dm_model_diagram_node的关键字(diagram_node_id)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_diagram_node_id_dm_model_diagram_node
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strdiagram_node_id">表关键字</param>
public K_diagram_node_id_dm_model_diagram_node(string strdiagram_node_id)
{
if (IsValid(strdiagram_node_id)) Value = strdiagram_node_id;
else
{
Value = null;
}
}
private static bool IsValid(string strdiagram_node_id)
{
if (string.IsNullOrEmpty(strdiagram_node_id) == true) return false;
if (strdiagram_node_id.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_diagram_node_id_dm_model_diagram_node]类型的对象</returns>
public static implicit operator K_diagram_node_id_dm_model_diagram_node(string value)
{
return new K_diagram_node_id_dm_model_diagram_node(value);
}
}
 /// <summary>
 /// 数据模型图节点映射(dm_model_diagram_node)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsdm_model_diagram_nodeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "dm_model_diagram_node"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "diagram_node_id"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 20;
public static string[] _AttributeName = new string[] {"diagram_node_id", "PrjId", "diagram_id", "stage_node_map_id", "node_type_code", "node_label", "x_pos", "y_pos", "Width", "Height", "node_style", "shape_type", "is_visible", "sort_no", "Status", "created_by", "created_time", "updated_by", "updated_time", "remark"};

protected string mstrdiagram_node_id;    //图节点映射ID
protected string mstrPrjId;    //工程Id
protected string mstrdiagram_id;    //图ID
protected string mstrstage_node_map_id;    //阶段结点映射ID
protected string mstrnode_type_code;    //结点类型编码
protected string mstrnode_label;    //节点名称
protected int? mintx_pos;    //X坐标
protected int? minty_pos;    //Y坐标
protected int? mintWidth;    //宽
protected int? mintHeight;    //高度
protected string mstrnode_style;    //结点样式
protected string mstrshape_type;    //外形
protected bool mbolis_visible;    //是否可见
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
 public clsdm_model_diagram_nodeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("diagram_node_id");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strdiagram_node_id">关键字:图节点映射ID</param>
public clsdm_model_diagram_nodeEN(string strdiagram_node_id)
 {
strdiagram_node_id = strdiagram_node_id.Replace("'", "''");
if (strdiagram_node_id.Length > 8)
{
throw new Exception("在表:dm_model_diagram_node中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strdiagram_node_id)  ==  true)
{
throw new Exception("在表:dm_model_diagram_node中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strdiagram_node_id);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrdiagram_node_id = strdiagram_node_id;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("diagram_node_id");
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
if (strAttributeName  ==  condm_model_diagram_node.diagram_node_id)
{
return mstrdiagram_node_id;
}
else if (strAttributeName  ==  condm_model_diagram_node.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  condm_model_diagram_node.diagram_id)
{
return mstrdiagram_id;
}
else if (strAttributeName  ==  condm_model_diagram_node.stage_node_map_id)
{
return mstrstage_node_map_id;
}
else if (strAttributeName  ==  condm_model_diagram_node.node_type_code)
{
return mstrnode_type_code;
}
else if (strAttributeName  ==  condm_model_diagram_node.node_label)
{
return mstrnode_label;
}
else if (strAttributeName  ==  condm_model_diagram_node.x_pos)
{
return mintx_pos;
}
else if (strAttributeName  ==  condm_model_diagram_node.y_pos)
{
return minty_pos;
}
else if (strAttributeName  ==  condm_model_diagram_node.Width)
{
return mintWidth;
}
else if (strAttributeName  ==  condm_model_diagram_node.Height)
{
return mintHeight;
}
else if (strAttributeName  ==  condm_model_diagram_node.node_style)
{
return mstrnode_style;
}
else if (strAttributeName  ==  condm_model_diagram_node.shape_type)
{
return mstrshape_type;
}
else if (strAttributeName  ==  condm_model_diagram_node.is_visible)
{
return mbolis_visible;
}
else if (strAttributeName  ==  condm_model_diagram_node.sort_no)
{
return mintsort_no;
}
else if (strAttributeName  ==  condm_model_diagram_node.Status)
{
return mstrStatus;
}
else if (strAttributeName  ==  condm_model_diagram_node.created_by)
{
return mstrcreated_by;
}
else if (strAttributeName  ==  condm_model_diagram_node.created_time)
{
return mdtecreated_time;
}
else if (strAttributeName  ==  condm_model_diagram_node.updated_by)
{
return mstrupdated_by;
}
else if (strAttributeName  ==  condm_model_diagram_node.updated_time)
{
return mdteupdated_time;
}
else if (strAttributeName  ==  condm_model_diagram_node.remark)
{
return mstrremark;
}
return null;
}
set
{
if (strAttributeName  ==  condm_model_diagram_node.diagram_node_id)
{
mstrdiagram_node_id = value.ToString();
 AddUpdatedFld(condm_model_diagram_node.diagram_node_id);
}
else if (strAttributeName  ==  condm_model_diagram_node.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(condm_model_diagram_node.PrjId);
}
else if (strAttributeName  ==  condm_model_diagram_node.diagram_id)
{
mstrdiagram_id = value.ToString();
 AddUpdatedFld(condm_model_diagram_node.diagram_id);
}
else if (strAttributeName  ==  condm_model_diagram_node.stage_node_map_id)
{
mstrstage_node_map_id = value.ToString();
 AddUpdatedFld(condm_model_diagram_node.stage_node_map_id);
}
else if (strAttributeName  ==  condm_model_diagram_node.node_type_code)
{
mstrnode_type_code = value.ToString();
 AddUpdatedFld(condm_model_diagram_node.node_type_code);
}
else if (strAttributeName  ==  condm_model_diagram_node.node_label)
{
mstrnode_label = value.ToString();
 AddUpdatedFld(condm_model_diagram_node.node_label);
}
else if (strAttributeName  ==  condm_model_diagram_node.x_pos)
{
mintx_pos = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_diagram_node.x_pos);
}
else if (strAttributeName  ==  condm_model_diagram_node.y_pos)
{
minty_pos = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_diagram_node.y_pos);
}
else if (strAttributeName  ==  condm_model_diagram_node.Width)
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_diagram_node.Width);
}
else if (strAttributeName  ==  condm_model_diagram_node.Height)
{
mintHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_diagram_node.Height);
}
else if (strAttributeName  ==  condm_model_diagram_node.node_style)
{
mstrnode_style = value.ToString();
 AddUpdatedFld(condm_model_diagram_node.node_style);
}
else if (strAttributeName  ==  condm_model_diagram_node.shape_type)
{
mstrshape_type = value.ToString();
 AddUpdatedFld(condm_model_diagram_node.shape_type);
}
else if (strAttributeName  ==  condm_model_diagram_node.is_visible)
{
mbolis_visible = TransNullToBool(value.ToString());
 AddUpdatedFld(condm_model_diagram_node.is_visible);
}
else if (strAttributeName  ==  condm_model_diagram_node.sort_no)
{
mintsort_no = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_diagram_node.sort_no);
}
else if (strAttributeName  ==  condm_model_diagram_node.Status)
{
mstrStatus = value.ToString();
 AddUpdatedFld(condm_model_diagram_node.Status);
}
else if (strAttributeName  ==  condm_model_diagram_node.created_by)
{
mstrcreated_by = value.ToString();
 AddUpdatedFld(condm_model_diagram_node.created_by);
}
else if (strAttributeName  ==  condm_model_diagram_node.created_time)
{
mdtecreated_time = TransNullToDate(value.ToString());
 AddUpdatedFld(condm_model_diagram_node.created_time);
}
else if (strAttributeName  ==  condm_model_diagram_node.updated_by)
{
mstrupdated_by = value.ToString();
 AddUpdatedFld(condm_model_diagram_node.updated_by);
}
else if (strAttributeName  ==  condm_model_diagram_node.updated_time)
{
mdteupdated_time = TransNullToDate(value.ToString());
 AddUpdatedFld(condm_model_diagram_node.updated_time);
}
else if (strAttributeName  ==  condm_model_diagram_node.remark)
{
mstrremark = value.ToString();
 AddUpdatedFld(condm_model_diagram_node.remark);
}
}
}
public object this[int intIndex]
{
get
{
if (condm_model_diagram_node.diagram_node_id  ==  _AttributeName[intIndex])
{
return mstrdiagram_node_id;
}
else if (condm_model_diagram_node.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (condm_model_diagram_node.diagram_id  ==  _AttributeName[intIndex])
{
return mstrdiagram_id;
}
else if (condm_model_diagram_node.stage_node_map_id  ==  _AttributeName[intIndex])
{
return mstrstage_node_map_id;
}
else if (condm_model_diagram_node.node_type_code  ==  _AttributeName[intIndex])
{
return mstrnode_type_code;
}
else if (condm_model_diagram_node.node_label  ==  _AttributeName[intIndex])
{
return mstrnode_label;
}
else if (condm_model_diagram_node.x_pos  ==  _AttributeName[intIndex])
{
return mintx_pos;
}
else if (condm_model_diagram_node.y_pos  ==  _AttributeName[intIndex])
{
return minty_pos;
}
else if (condm_model_diagram_node.Width  ==  _AttributeName[intIndex])
{
return mintWidth;
}
else if (condm_model_diagram_node.Height  ==  _AttributeName[intIndex])
{
return mintHeight;
}
else if (condm_model_diagram_node.node_style  ==  _AttributeName[intIndex])
{
return mstrnode_style;
}
else if (condm_model_diagram_node.shape_type  ==  _AttributeName[intIndex])
{
return mstrshape_type;
}
else if (condm_model_diagram_node.is_visible  ==  _AttributeName[intIndex])
{
return mbolis_visible;
}
else if (condm_model_diagram_node.sort_no  ==  _AttributeName[intIndex])
{
return mintsort_no;
}
else if (condm_model_diagram_node.Status  ==  _AttributeName[intIndex])
{
return mstrStatus;
}
else if (condm_model_diagram_node.created_by  ==  _AttributeName[intIndex])
{
return mstrcreated_by;
}
else if (condm_model_diagram_node.created_time  ==  _AttributeName[intIndex])
{
return mdtecreated_time;
}
else if (condm_model_diagram_node.updated_by  ==  _AttributeName[intIndex])
{
return mstrupdated_by;
}
else if (condm_model_diagram_node.updated_time  ==  _AttributeName[intIndex])
{
return mdteupdated_time;
}
else if (condm_model_diagram_node.remark  ==  _AttributeName[intIndex])
{
return mstrremark;
}
return null;
}
set
{
if (condm_model_diagram_node.diagram_node_id  ==  _AttributeName[intIndex])
{
mstrdiagram_node_id = value.ToString();
 AddUpdatedFld(condm_model_diagram_node.diagram_node_id);
}
else if (condm_model_diagram_node.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(condm_model_diagram_node.PrjId);
}
else if (condm_model_diagram_node.diagram_id  ==  _AttributeName[intIndex])
{
mstrdiagram_id = value.ToString();
 AddUpdatedFld(condm_model_diagram_node.diagram_id);
}
else if (condm_model_diagram_node.stage_node_map_id  ==  _AttributeName[intIndex])
{
mstrstage_node_map_id = value.ToString();
 AddUpdatedFld(condm_model_diagram_node.stage_node_map_id);
}
else if (condm_model_diagram_node.node_type_code  ==  _AttributeName[intIndex])
{
mstrnode_type_code = value.ToString();
 AddUpdatedFld(condm_model_diagram_node.node_type_code);
}
else if (condm_model_diagram_node.node_label  ==  _AttributeName[intIndex])
{
mstrnode_label = value.ToString();
 AddUpdatedFld(condm_model_diagram_node.node_label);
}
else if (condm_model_diagram_node.x_pos  ==  _AttributeName[intIndex])
{
mintx_pos = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_diagram_node.x_pos);
}
else if (condm_model_diagram_node.y_pos  ==  _AttributeName[intIndex])
{
minty_pos = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_diagram_node.y_pos);
}
else if (condm_model_diagram_node.Width  ==  _AttributeName[intIndex])
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_diagram_node.Width);
}
else if (condm_model_diagram_node.Height  ==  _AttributeName[intIndex])
{
mintHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_diagram_node.Height);
}
else if (condm_model_diagram_node.node_style  ==  _AttributeName[intIndex])
{
mstrnode_style = value.ToString();
 AddUpdatedFld(condm_model_diagram_node.node_style);
}
else if (condm_model_diagram_node.shape_type  ==  _AttributeName[intIndex])
{
mstrshape_type = value.ToString();
 AddUpdatedFld(condm_model_diagram_node.shape_type);
}
else if (condm_model_diagram_node.is_visible  ==  _AttributeName[intIndex])
{
mbolis_visible = TransNullToBool(value.ToString());
 AddUpdatedFld(condm_model_diagram_node.is_visible);
}
else if (condm_model_diagram_node.sort_no  ==  _AttributeName[intIndex])
{
mintsort_no = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_diagram_node.sort_no);
}
else if (condm_model_diagram_node.Status  ==  _AttributeName[intIndex])
{
mstrStatus = value.ToString();
 AddUpdatedFld(condm_model_diagram_node.Status);
}
else if (condm_model_diagram_node.created_by  ==  _AttributeName[intIndex])
{
mstrcreated_by = value.ToString();
 AddUpdatedFld(condm_model_diagram_node.created_by);
}
else if (condm_model_diagram_node.created_time  ==  _AttributeName[intIndex])
{
mdtecreated_time = TransNullToDate(value.ToString());
 AddUpdatedFld(condm_model_diagram_node.created_time);
}
else if (condm_model_diagram_node.updated_by  ==  _AttributeName[intIndex])
{
mstrupdated_by = value.ToString();
 AddUpdatedFld(condm_model_diagram_node.updated_by);
}
else if (condm_model_diagram_node.updated_time  ==  _AttributeName[intIndex])
{
mdteupdated_time = TransNullToDate(value.ToString());
 AddUpdatedFld(condm_model_diagram_node.updated_time);
}
else if (condm_model_diagram_node.remark  ==  _AttributeName[intIndex])
{
mstrremark = value.ToString();
 AddUpdatedFld(condm_model_diagram_node.remark);
}
}
}

/// <summary>
/// 图节点映射ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string diagram_node_id
{
get
{
return mstrdiagram_node_id;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrdiagram_node_id = value;
}
else
{
 mstrdiagram_node_id = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_diagram_node.diagram_node_id);
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
 AddUpdatedFld(condm_model_diagram_node.PrjId);
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
 AddUpdatedFld(condm_model_diagram_node.diagram_id);
}
}
/// <summary>
/// 阶段结点映射ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string stage_node_map_id
{
get
{
return mstrstage_node_map_id;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrstage_node_map_id = value;
}
else
{
 mstrstage_node_map_id = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_diagram_node.stage_node_map_id);
}
}
/// <summary>
/// 结点类型编码(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string node_type_code
{
get
{
return mstrnode_type_code;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrnode_type_code = value;
}
else
{
 mstrnode_type_code = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_diagram_node.node_type_code);
}
}
/// <summary>
/// 节点名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string node_label
{
get
{
return mstrnode_label;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrnode_label = value;
}
else
{
 mstrnode_label = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_diagram_node.node_label);
}
}
/// <summary>
/// X坐标(说明:;字段类型:int;字段长度:0;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? x_pos
{
get
{
return mintx_pos;
}
set
{
 mintx_pos = value;
//记录修改过的字段
 AddUpdatedFld(condm_model_diagram_node.x_pos);
}
}
/// <summary>
/// Y坐标(说明:;字段类型:int;字段长度:0;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? y_pos
{
get
{
return minty_pos;
}
set
{
 minty_pos = value;
//记录修改过的字段
 AddUpdatedFld(condm_model_diagram_node.y_pos);
}
}
/// <summary>
/// 宽(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? Width
{
get
{
return mintWidth;
}
set
{
 mintWidth = value;
//记录修改过的字段
 AddUpdatedFld(condm_model_diagram_node.Width);
}
}
/// <summary>
/// 高度(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? Height
{
get
{
return mintHeight;
}
set
{
 mintHeight = value;
//记录修改过的字段
 AddUpdatedFld(condm_model_diagram_node.Height);
}
}
/// <summary>
/// 结点样式(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string node_style
{
get
{
return mstrnode_style;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrnode_style = value;
}
else
{
 mstrnode_style = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_diagram_node.node_style);
}
}
/// <summary>
/// 外形(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string shape_type
{
get
{
return mstrshape_type;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrshape_type = value;
}
else
{
 mstrshape_type = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_diagram_node.shape_type);
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
 AddUpdatedFld(condm_model_diagram_node.is_visible);
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
 AddUpdatedFld(condm_model_diagram_node.sort_no);
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
 AddUpdatedFld(condm_model_diagram_node.Status);
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
 AddUpdatedFld(condm_model_diagram_node.created_by);
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
 AddUpdatedFld(condm_model_diagram_node.created_time);
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
 AddUpdatedFld(condm_model_diagram_node.updated_by);
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
 AddUpdatedFld(condm_model_diagram_node.updated_time);
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
 AddUpdatedFld(condm_model_diagram_node.remark);
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
  return mstrdiagram_node_id;
 }
 }
}
 /// <summary>
 /// 数据模型图节点映射(dm_model_diagram_node)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class condm_model_diagram_node
{
public const string _CurrTabName = "dm_model_diagram_node"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "diagram_node_id"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"diagram_node_id", "PrjId", "diagram_id", "stage_node_map_id", "node_type_code", "node_label", "x_pos", "y_pos", "Width", "Height", "node_style", "shape_type", "is_visible", "sort_no", "Status", "created_by", "created_time", "updated_by", "updated_time", "remark"};
//以下是属性变量


 /// <summary>
 /// 常量:"diagram_node_id"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string diagram_node_id = "diagram_node_id";    //图节点映射ID

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
 /// 常量:"stage_node_map_id"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string stage_node_map_id = "stage_node_map_id";    //阶段结点映射ID

 /// <summary>
 /// 常量:"node_type_code"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string node_type_code = "node_type_code";    //结点类型编码

 /// <summary>
 /// 常量:"node_label"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string node_label = "node_label";    //节点名称

 /// <summary>
 /// 常量:"x_pos"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string x_pos = "x_pos";    //X坐标

 /// <summary>
 /// 常量:"y_pos"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string y_pos = "y_pos";    //Y坐标

 /// <summary>
 /// 常量:"Width"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Width = "Width";    //宽

 /// <summary>
 /// 常量:"Height"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Height = "Height";    //高度

 /// <summary>
 /// 常量:"node_style"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string node_style = "node_style";    //结点样式

 /// <summary>
 /// 常量:"shape_type"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string shape_type = "shape_type";    //外形

 /// <summary>
 /// 常量:"is_visible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string is_visible = "is_visible";    //是否可见

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