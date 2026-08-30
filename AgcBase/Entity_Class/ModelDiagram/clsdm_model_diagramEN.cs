
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsdm_model_diagramEN
 表名:dm_model_diagram(00050665)
 * 版本:2026.08.13(服务器:WIN-SRV103-116)
 日期:2026/08/18 04:24:49
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
 /// 表dm_model_diagram的关键字(diagram_id)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_diagram_id_dm_model_diagram
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strdiagram_id">表关键字</param>
public K_diagram_id_dm_model_diagram(string strdiagram_id)
{
if (IsValid(strdiagram_id)) Value = strdiagram_id;
else
{
Value = null;
}
}
private static bool IsValid(string strdiagram_id)
{
if (string.IsNullOrEmpty(strdiagram_id) == true) return false;
if (strdiagram_id.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_diagram_id_dm_model_diagram]类型的对象</returns>
public static implicit operator K_diagram_id_dm_model_diagram(string value)
{
return new K_diagram_id_dm_model_diagram(value);
}
}
 /// <summary>
 /// 数据模型图定义(dm_model_diagram)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsdm_model_diagramEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "dm_model_diagram"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "diagram_id"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 17;
public static string[] _AttributeName = new string[] {"diagram_id", "diagram_name", "PrjId", "view_type_id", "subject_scope", "version_no", "zoom_level", "pan_x", "pan_y", "canvas_width", "canvas_height", "Status", "created_by", "created_time", "updated_by", "updated_time", "remark"};

protected string mstrdiagram_id;    //图ID
protected string mstrdiagram_name;    //图名称
protected string mstrPrjId;    //工程Id
protected string mstrview_type_id;    //视图类型ID
protected string mstrsubject_scope;    //主题范围
protected string mstrversion_no;    //版本号
protected double mdblzoom_level;    //缩放级别
protected double mdblpan_x;    //水平偏移
protected double mdblpan_y;    //垂直偏移
protected int mintcanvas_width;    //画布宽
protected int mintcanvas_height;    //画布高
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
 public clsdm_model_diagramEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("diagram_id");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strdiagram_id">关键字:图ID</param>
public clsdm_model_diagramEN(string strdiagram_id)
 {
strdiagram_id = strdiagram_id.Replace("'", "''");
if (strdiagram_id.Length > 8)
{
throw new Exception("在表:dm_model_diagram中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strdiagram_id)  ==  true)
{
throw new Exception("在表:dm_model_diagram中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strdiagram_id);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrdiagram_id = strdiagram_id;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("diagram_id");
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
if (strAttributeName  ==  condm_model_diagram.diagram_id)
{
return mstrdiagram_id;
}
else if (strAttributeName  ==  condm_model_diagram.diagram_name)
{
return mstrdiagram_name;
}
else if (strAttributeName  ==  condm_model_diagram.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  condm_model_diagram.view_type_id)
{
return mstrview_type_id;
}
else if (strAttributeName  ==  condm_model_diagram.subject_scope)
{
return mstrsubject_scope;
}
else if (strAttributeName  ==  condm_model_diagram.version_no)
{
return mstrversion_no;
}
else if (strAttributeName  ==  condm_model_diagram.zoom_level)
{
return mdblzoom_level;
}
else if (strAttributeName  ==  condm_model_diagram.pan_x)
{
return mdblpan_x;
}
else if (strAttributeName  ==  condm_model_diagram.pan_y)
{
return mdblpan_y;
}
else if (strAttributeName  ==  condm_model_diagram.canvas_width)
{
return mintcanvas_width;
}
else if (strAttributeName  ==  condm_model_diagram.canvas_height)
{
return mintcanvas_height;
}
else if (strAttributeName  ==  condm_model_diagram.Status)
{
return mstrStatus;
}
else if (strAttributeName  ==  condm_model_diagram.created_by)
{
return mstrcreated_by;
}
else if (strAttributeName  ==  condm_model_diagram.created_time)
{
return mdtecreated_time;
}
else if (strAttributeName  ==  condm_model_diagram.updated_by)
{
return mstrupdated_by;
}
else if (strAttributeName  ==  condm_model_diagram.updated_time)
{
return mdteupdated_time;
}
else if (strAttributeName  ==  condm_model_diagram.remark)
{
return mstrremark;
}
return null;
}
set
{
if (strAttributeName  ==  condm_model_diagram.diagram_id)
{
mstrdiagram_id = value.ToString();
 AddUpdatedFld(condm_model_diagram.diagram_id);
}
else if (strAttributeName  ==  condm_model_diagram.diagram_name)
{
mstrdiagram_name = value.ToString();
 AddUpdatedFld(condm_model_diagram.diagram_name);
}
else if (strAttributeName  ==  condm_model_diagram.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(condm_model_diagram.PrjId);
}
else if (strAttributeName  ==  condm_model_diagram.view_type_id)
{
mstrview_type_id = value.ToString();
 AddUpdatedFld(condm_model_diagram.view_type_id);
}
else if (strAttributeName  ==  condm_model_diagram.subject_scope)
{
mstrsubject_scope = value.ToString();
 AddUpdatedFld(condm_model_diagram.subject_scope);
}
else if (strAttributeName  ==  condm_model_diagram.version_no)
{
mstrversion_no = value.ToString();
 AddUpdatedFld(condm_model_diagram.version_no);
}
else if (strAttributeName  ==  condm_model_diagram.zoom_level)
{
mdblzoom_level = TransNullToDouble(value.ToString());
 AddUpdatedFld(condm_model_diagram.zoom_level);
}
else if (strAttributeName  ==  condm_model_diagram.pan_x)
{
mdblpan_x = TransNullToDouble(value.ToString());
 AddUpdatedFld(condm_model_diagram.pan_x);
}
else if (strAttributeName  ==  condm_model_diagram.pan_y)
{
mdblpan_y = TransNullToDouble(value.ToString());
 AddUpdatedFld(condm_model_diagram.pan_y);
}
else if (strAttributeName  ==  condm_model_diagram.canvas_width)
{
mintcanvas_width = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_diagram.canvas_width);
}
else if (strAttributeName  ==  condm_model_diagram.canvas_height)
{
mintcanvas_height = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_diagram.canvas_height);
}
else if (strAttributeName  ==  condm_model_diagram.Status)
{
mstrStatus = value.ToString();
 AddUpdatedFld(condm_model_diagram.Status);
}
else if (strAttributeName  ==  condm_model_diagram.created_by)
{
mstrcreated_by = value.ToString();
 AddUpdatedFld(condm_model_diagram.created_by);
}
else if (strAttributeName  ==  condm_model_diagram.created_time)
{
mdtecreated_time = TransNullToDate(value.ToString());
 AddUpdatedFld(condm_model_diagram.created_time);
}
else if (strAttributeName  ==  condm_model_diagram.updated_by)
{
mstrupdated_by = value.ToString();
 AddUpdatedFld(condm_model_diagram.updated_by);
}
else if (strAttributeName  ==  condm_model_diagram.updated_time)
{
mdteupdated_time = TransNullToDate(value.ToString());
 AddUpdatedFld(condm_model_diagram.updated_time);
}
else if (strAttributeName  ==  condm_model_diagram.remark)
{
mstrremark = value.ToString();
 AddUpdatedFld(condm_model_diagram.remark);
}
}
}
public object this[int intIndex]
{
get
{
if (condm_model_diagram.diagram_id  ==  _AttributeName[intIndex])
{
return mstrdiagram_id;
}
else if (condm_model_diagram.diagram_name  ==  _AttributeName[intIndex])
{
return mstrdiagram_name;
}
else if (condm_model_diagram.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (condm_model_diagram.view_type_id  ==  _AttributeName[intIndex])
{
return mstrview_type_id;
}
else if (condm_model_diagram.subject_scope  ==  _AttributeName[intIndex])
{
return mstrsubject_scope;
}
else if (condm_model_diagram.version_no  ==  _AttributeName[intIndex])
{
return mstrversion_no;
}
else if (condm_model_diagram.zoom_level  ==  _AttributeName[intIndex])
{
return mdblzoom_level;
}
else if (condm_model_diagram.pan_x  ==  _AttributeName[intIndex])
{
return mdblpan_x;
}
else if (condm_model_diagram.pan_y  ==  _AttributeName[intIndex])
{
return mdblpan_y;
}
else if (condm_model_diagram.canvas_width  ==  _AttributeName[intIndex])
{
return mintcanvas_width;
}
else if (condm_model_diagram.canvas_height  ==  _AttributeName[intIndex])
{
return mintcanvas_height;
}
else if (condm_model_diagram.Status  ==  _AttributeName[intIndex])
{
return mstrStatus;
}
else if (condm_model_diagram.created_by  ==  _AttributeName[intIndex])
{
return mstrcreated_by;
}
else if (condm_model_diagram.created_time  ==  _AttributeName[intIndex])
{
return mdtecreated_time;
}
else if (condm_model_diagram.updated_by  ==  _AttributeName[intIndex])
{
return mstrupdated_by;
}
else if (condm_model_diagram.updated_time  ==  _AttributeName[intIndex])
{
return mdteupdated_time;
}
else if (condm_model_diagram.remark  ==  _AttributeName[intIndex])
{
return mstrremark;
}
return null;
}
set
{
if (condm_model_diagram.diagram_id  ==  _AttributeName[intIndex])
{
mstrdiagram_id = value.ToString();
 AddUpdatedFld(condm_model_diagram.diagram_id);
}
else if (condm_model_diagram.diagram_name  ==  _AttributeName[intIndex])
{
mstrdiagram_name = value.ToString();
 AddUpdatedFld(condm_model_diagram.diagram_name);
}
else if (condm_model_diagram.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(condm_model_diagram.PrjId);
}
else if (condm_model_diagram.view_type_id  ==  _AttributeName[intIndex])
{
mstrview_type_id = value.ToString();
 AddUpdatedFld(condm_model_diagram.view_type_id);
}
else if (condm_model_diagram.subject_scope  ==  _AttributeName[intIndex])
{
mstrsubject_scope = value.ToString();
 AddUpdatedFld(condm_model_diagram.subject_scope);
}
else if (condm_model_diagram.version_no  ==  _AttributeName[intIndex])
{
mstrversion_no = value.ToString();
 AddUpdatedFld(condm_model_diagram.version_no);
}
else if (condm_model_diagram.zoom_level  ==  _AttributeName[intIndex])
{
mdblzoom_level = TransNullToDouble(value.ToString());
 AddUpdatedFld(condm_model_diagram.zoom_level);
}
else if (condm_model_diagram.pan_x  ==  _AttributeName[intIndex])
{
mdblpan_x = TransNullToDouble(value.ToString());
 AddUpdatedFld(condm_model_diagram.pan_x);
}
else if (condm_model_diagram.pan_y  ==  _AttributeName[intIndex])
{
mdblpan_y = TransNullToDouble(value.ToString());
 AddUpdatedFld(condm_model_diagram.pan_y);
}
else if (condm_model_diagram.canvas_width  ==  _AttributeName[intIndex])
{
mintcanvas_width = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_diagram.canvas_width);
}
else if (condm_model_diagram.canvas_height  ==  _AttributeName[intIndex])
{
mintcanvas_height = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_diagram.canvas_height);
}
else if (condm_model_diagram.Status  ==  _AttributeName[intIndex])
{
mstrStatus = value.ToString();
 AddUpdatedFld(condm_model_diagram.Status);
}
else if (condm_model_diagram.created_by  ==  _AttributeName[intIndex])
{
mstrcreated_by = value.ToString();
 AddUpdatedFld(condm_model_diagram.created_by);
}
else if (condm_model_diagram.created_time  ==  _AttributeName[intIndex])
{
mdtecreated_time = TransNullToDate(value.ToString());
 AddUpdatedFld(condm_model_diagram.created_time);
}
else if (condm_model_diagram.updated_by  ==  _AttributeName[intIndex])
{
mstrupdated_by = value.ToString();
 AddUpdatedFld(condm_model_diagram.updated_by);
}
else if (condm_model_diagram.updated_time  ==  _AttributeName[intIndex])
{
mdteupdated_time = TransNullToDate(value.ToString());
 AddUpdatedFld(condm_model_diagram.updated_time);
}
else if (condm_model_diagram.remark  ==  _AttributeName[intIndex])
{
mstrremark = value.ToString();
 AddUpdatedFld(condm_model_diagram.remark);
}
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
 AddUpdatedFld(condm_model_diagram.diagram_id);
}
}
/// <summary>
/// 图名称(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string diagram_name
{
get
{
return mstrdiagram_name;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrdiagram_name = value;
}
else
{
 mstrdiagram_name = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_diagram.diagram_name);
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
 AddUpdatedFld(condm_model_diagram.PrjId);
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
 AddUpdatedFld(condm_model_diagram.view_type_id);
}
}
/// <summary>
/// 主题范围(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string subject_scope
{
get
{
return mstrsubject_scope;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrsubject_scope = value;
}
else
{
 mstrsubject_scope = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_diagram.subject_scope);
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
 AddUpdatedFld(condm_model_diagram.version_no);
}
}
/// <summary>
/// 缩放级别(说明:;字段类型:decimal;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double zoom_level
{
get
{
return mdblzoom_level;
}
set
{
 mdblzoom_level = value;
//记录修改过的字段
 AddUpdatedFld(condm_model_diagram.zoom_level);
}
}
/// <summary>
/// 水平偏移(说明:;字段类型:decimal;字段长度:12;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double pan_x
{
get
{
return mdblpan_x;
}
set
{
 mdblpan_x = value;
//记录修改过的字段
 AddUpdatedFld(condm_model_diagram.pan_x);
}
}
/// <summary>
/// 垂直偏移(说明:;字段类型:decimal;字段长度:12;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double pan_y
{
get
{
return mdblpan_y;
}
set
{
 mdblpan_y = value;
//记录修改过的字段
 AddUpdatedFld(condm_model_diagram.pan_y);
}
}
/// <summary>
/// 画布宽(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int canvas_width
{
get
{
return mintcanvas_width;
}
set
{
 mintcanvas_width = value;
//记录修改过的字段
 AddUpdatedFld(condm_model_diagram.canvas_width);
}
}
/// <summary>
/// 画布高(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int canvas_height
{
get
{
return mintcanvas_height;
}
set
{
 mintcanvas_height = value;
//记录修改过的字段
 AddUpdatedFld(condm_model_diagram.canvas_height);
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
 AddUpdatedFld(condm_model_diagram.Status);
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
 AddUpdatedFld(condm_model_diagram.created_by);
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
 AddUpdatedFld(condm_model_diagram.created_time);
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
 AddUpdatedFld(condm_model_diagram.updated_by);
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
 AddUpdatedFld(condm_model_diagram.updated_time);
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
 AddUpdatedFld(condm_model_diagram.remark);
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
  return mstrdiagram_id;
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
  return mstrdiagram_name;
 }
 }
}
 /// <summary>
 /// 数据模型图定义(dm_model_diagram)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class condm_model_diagram
{
public const string _CurrTabName = "dm_model_diagram"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "diagram_id"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"diagram_id", "diagram_name", "PrjId", "view_type_id", "subject_scope", "version_no", "zoom_level", "pan_x", "pan_y", "canvas_width", "canvas_height", "Status", "created_by", "created_time", "updated_by", "updated_time", "remark"};
//以下是属性变量


 /// <summary>
 /// 常量:"diagram_id"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string diagram_id = "diagram_id";    //图ID

 /// <summary>
 /// 常量:"diagram_name"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string diagram_name = "diagram_name";    //图名称

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"view_type_id"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string view_type_id = "view_type_id";    //视图类型ID

 /// <summary>
 /// 常量:"subject_scope"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string subject_scope = "subject_scope";    //主题范围

 /// <summary>
 /// 常量:"version_no"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string version_no = "version_no";    //版本号

 /// <summary>
 /// 常量:"zoom_level"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zoom_level = "zoom_level";    //缩放级别

 /// <summary>
 /// 常量:"pan_x"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string pan_x = "pan_x";    //水平偏移

 /// <summary>
 /// 常量:"pan_y"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string pan_y = "pan_y";    //垂直偏移

 /// <summary>
 /// 常量:"canvas_width"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string canvas_width = "canvas_width";    //画布宽

 /// <summary>
 /// 常量:"canvas_height"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string canvas_height = "canvas_height";    //画布高

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