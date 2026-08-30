
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsdm_model_diagram_stage_mapEN
 表名:dm_model_diagram_stage_map(00050672)
 * 版本:2026.08.13(服务器:WIN-SRV103-116)
 日期:2026/08/15 13:11:30
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
 /// 表dm_model_diagram_stage_map的关键字(diagram_stage_map_id)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_diagram_stage_map_id_dm_model_diagram_stage_map
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngdiagram_stage_map_id">表关键字</param>
public K_diagram_stage_map_id_dm_model_diagram_stage_map(long lngdiagram_stage_map_id)
{
if (IsValid(lngdiagram_stage_map_id)) Value = lngdiagram_stage_map_id;
else
{
Value = 0;
}
}
private static bool IsValid(long lngdiagram_stage_map_id)
{
if (lngdiagram_stage_map_id == 0) return false;
if (lngdiagram_stage_map_id == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_diagram_stage_map_id_dm_model_diagram_stage_map]类型的对象</returns>
public static implicit operator K_diagram_stage_map_id_dm_model_diagram_stage_map(long value)
{
return new K_diagram_stage_map_id_dm_model_diagram_stage_map(value);
}
}
 /// <summary>
 /// 图阶段布局映射(dm_model_diagram_stage_map)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsdm_model_diagram_stage_mapEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "dm_model_diagram_stage_map"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "diagram_stage_map_id"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 16;
public static string[] _AttributeName = new string[] {"diagram_stage_map_id", "PrjId", "diagram_id", "stage_id", "x_pos", "y_pos", "Width", "Height", "sort_no", "is_visible", "Status", "created_by", "created_time", "updated_by", "updated_time", "remark"};

protected long mlngdiagram_stage_map_id;    //图阶段映射ID
protected string mstrPrjId;    //工程Id
protected string mstrdiagram_id;    //图ID
protected string mstrstage_id;    //阶段ID
protected int mintx_pos;    //X坐标
protected int minty_pos;    //Y坐标
protected int mintWidth;    //宽
protected int mintHeight;    //高度
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
 public clsdm_model_diagram_stage_mapEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("diagram_stage_map_id");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "lngdiagram_stage_map_id">关键字:图阶段映射ID</param>
public clsdm_model_diagram_stage_mapEN(long lngdiagram_stage_map_id)
 {
 if (lngdiagram_stage_map_id  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngdiagram_stage_map_id = lngdiagram_stage_map_id;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("diagram_stage_map_id");
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
if (strAttributeName  ==  condm_model_diagram_stage_map.diagram_stage_map_id)
{
return mlngdiagram_stage_map_id;
}
else if (strAttributeName  ==  condm_model_diagram_stage_map.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  condm_model_diagram_stage_map.diagram_id)
{
return mstrdiagram_id;
}
else if (strAttributeName  ==  condm_model_diagram_stage_map.stage_id)
{
return mstrstage_id;
}
else if (strAttributeName  ==  condm_model_diagram_stage_map.x_pos)
{
return mintx_pos;
}
else if (strAttributeName  ==  condm_model_diagram_stage_map.y_pos)
{
return minty_pos;
}
else if (strAttributeName  ==  condm_model_diagram_stage_map.Width)
{
return mintWidth;
}
else if (strAttributeName  ==  condm_model_diagram_stage_map.Height)
{
return mintHeight;
}
else if (strAttributeName  ==  condm_model_diagram_stage_map.sort_no)
{
return mintsort_no;
}
else if (strAttributeName  ==  condm_model_diagram_stage_map.is_visible)
{
return mbolis_visible;
}
else if (strAttributeName  ==  condm_model_diagram_stage_map.Status)
{
return mstrStatus;
}
else if (strAttributeName  ==  condm_model_diagram_stage_map.created_by)
{
return mstrcreated_by;
}
else if (strAttributeName  ==  condm_model_diagram_stage_map.created_time)
{
return mdtecreated_time;
}
else if (strAttributeName  ==  condm_model_diagram_stage_map.updated_by)
{
return mstrupdated_by;
}
else if (strAttributeName  ==  condm_model_diagram_stage_map.updated_time)
{
return mdteupdated_time;
}
else if (strAttributeName  ==  condm_model_diagram_stage_map.remark)
{
return mstrremark;
}
return null;
}
set
{
if (strAttributeName  ==  condm_model_diagram_stage_map.diagram_stage_map_id)
{
mlngdiagram_stage_map_id = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_diagram_stage_map.diagram_stage_map_id);
}
else if (strAttributeName  ==  condm_model_diagram_stage_map.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(condm_model_diagram_stage_map.PrjId);
}
else if (strAttributeName  ==  condm_model_diagram_stage_map.diagram_id)
{
mstrdiagram_id = value.ToString();
 AddUpdatedFld(condm_model_diagram_stage_map.diagram_id);
}
else if (strAttributeName  ==  condm_model_diagram_stage_map.stage_id)
{
mstrstage_id = value.ToString();
 AddUpdatedFld(condm_model_diagram_stage_map.stage_id);
}
else if (strAttributeName  ==  condm_model_diagram_stage_map.x_pos)
{
mintx_pos = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_diagram_stage_map.x_pos);
}
else if (strAttributeName  ==  condm_model_diagram_stage_map.y_pos)
{
minty_pos = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_diagram_stage_map.y_pos);
}
else if (strAttributeName  ==  condm_model_diagram_stage_map.Width)
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_diagram_stage_map.Width);
}
else if (strAttributeName  ==  condm_model_diagram_stage_map.Height)
{
mintHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_diagram_stage_map.Height);
}
else if (strAttributeName  ==  condm_model_diagram_stage_map.sort_no)
{
mintsort_no = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_diagram_stage_map.sort_no);
}
else if (strAttributeName  ==  condm_model_diagram_stage_map.is_visible)
{
mbolis_visible = TransNullToBool(value.ToString());
 AddUpdatedFld(condm_model_diagram_stage_map.is_visible);
}
else if (strAttributeName  ==  condm_model_diagram_stage_map.Status)
{
mstrStatus = value.ToString();
 AddUpdatedFld(condm_model_diagram_stage_map.Status);
}
else if (strAttributeName  ==  condm_model_diagram_stage_map.created_by)
{
mstrcreated_by = value.ToString();
 AddUpdatedFld(condm_model_diagram_stage_map.created_by);
}
else if (strAttributeName  ==  condm_model_diagram_stage_map.created_time)
{
mdtecreated_time = TransNullToDate(value.ToString());
 AddUpdatedFld(condm_model_diagram_stage_map.created_time);
}
else if (strAttributeName  ==  condm_model_diagram_stage_map.updated_by)
{
mstrupdated_by = value.ToString();
 AddUpdatedFld(condm_model_diagram_stage_map.updated_by);
}
else if (strAttributeName  ==  condm_model_diagram_stage_map.updated_time)
{
mdteupdated_time = TransNullToDate(value.ToString());
 AddUpdatedFld(condm_model_diagram_stage_map.updated_time);
}
else if (strAttributeName  ==  condm_model_diagram_stage_map.remark)
{
mstrremark = value.ToString();
 AddUpdatedFld(condm_model_diagram_stage_map.remark);
}
}
}
public object this[int intIndex]
{
get
{
if (condm_model_diagram_stage_map.diagram_stage_map_id  ==  _AttributeName[intIndex])
{
return mlngdiagram_stage_map_id;
}
else if (condm_model_diagram_stage_map.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (condm_model_diagram_stage_map.diagram_id  ==  _AttributeName[intIndex])
{
return mstrdiagram_id;
}
else if (condm_model_diagram_stage_map.stage_id  ==  _AttributeName[intIndex])
{
return mstrstage_id;
}
else if (condm_model_diagram_stage_map.x_pos  ==  _AttributeName[intIndex])
{
return mintx_pos;
}
else if (condm_model_diagram_stage_map.y_pos  ==  _AttributeName[intIndex])
{
return minty_pos;
}
else if (condm_model_diagram_stage_map.Width  ==  _AttributeName[intIndex])
{
return mintWidth;
}
else if (condm_model_diagram_stage_map.Height  ==  _AttributeName[intIndex])
{
return mintHeight;
}
else if (condm_model_diagram_stage_map.sort_no  ==  _AttributeName[intIndex])
{
return mintsort_no;
}
else if (condm_model_diagram_stage_map.is_visible  ==  _AttributeName[intIndex])
{
return mbolis_visible;
}
else if (condm_model_diagram_stage_map.Status  ==  _AttributeName[intIndex])
{
return mstrStatus;
}
else if (condm_model_diagram_stage_map.created_by  ==  _AttributeName[intIndex])
{
return mstrcreated_by;
}
else if (condm_model_diagram_stage_map.created_time  ==  _AttributeName[intIndex])
{
return mdtecreated_time;
}
else if (condm_model_diagram_stage_map.updated_by  ==  _AttributeName[intIndex])
{
return mstrupdated_by;
}
else if (condm_model_diagram_stage_map.updated_time  ==  _AttributeName[intIndex])
{
return mdteupdated_time;
}
else if (condm_model_diagram_stage_map.remark  ==  _AttributeName[intIndex])
{
return mstrremark;
}
return null;
}
set
{
if (condm_model_diagram_stage_map.diagram_stage_map_id  ==  _AttributeName[intIndex])
{
mlngdiagram_stage_map_id = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_diagram_stage_map.diagram_stage_map_id);
}
else if (condm_model_diagram_stage_map.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(condm_model_diagram_stage_map.PrjId);
}
else if (condm_model_diagram_stage_map.diagram_id  ==  _AttributeName[intIndex])
{
mstrdiagram_id = value.ToString();
 AddUpdatedFld(condm_model_diagram_stage_map.diagram_id);
}
else if (condm_model_diagram_stage_map.stage_id  ==  _AttributeName[intIndex])
{
mstrstage_id = value.ToString();
 AddUpdatedFld(condm_model_diagram_stage_map.stage_id);
}
else if (condm_model_diagram_stage_map.x_pos  ==  _AttributeName[intIndex])
{
mintx_pos = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_diagram_stage_map.x_pos);
}
else if (condm_model_diagram_stage_map.y_pos  ==  _AttributeName[intIndex])
{
minty_pos = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_diagram_stage_map.y_pos);
}
else if (condm_model_diagram_stage_map.Width  ==  _AttributeName[intIndex])
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_diagram_stage_map.Width);
}
else if (condm_model_diagram_stage_map.Height  ==  _AttributeName[intIndex])
{
mintHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_diagram_stage_map.Height);
}
else if (condm_model_diagram_stage_map.sort_no  ==  _AttributeName[intIndex])
{
mintsort_no = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_diagram_stage_map.sort_no);
}
else if (condm_model_diagram_stage_map.is_visible  ==  _AttributeName[intIndex])
{
mbolis_visible = TransNullToBool(value.ToString());
 AddUpdatedFld(condm_model_diagram_stage_map.is_visible);
}
else if (condm_model_diagram_stage_map.Status  ==  _AttributeName[intIndex])
{
mstrStatus = value.ToString();
 AddUpdatedFld(condm_model_diagram_stage_map.Status);
}
else if (condm_model_diagram_stage_map.created_by  ==  _AttributeName[intIndex])
{
mstrcreated_by = value.ToString();
 AddUpdatedFld(condm_model_diagram_stage_map.created_by);
}
else if (condm_model_diagram_stage_map.created_time  ==  _AttributeName[intIndex])
{
mdtecreated_time = TransNullToDate(value.ToString());
 AddUpdatedFld(condm_model_diagram_stage_map.created_time);
}
else if (condm_model_diagram_stage_map.updated_by  ==  _AttributeName[intIndex])
{
mstrupdated_by = value.ToString();
 AddUpdatedFld(condm_model_diagram_stage_map.updated_by);
}
else if (condm_model_diagram_stage_map.updated_time  ==  _AttributeName[intIndex])
{
mdteupdated_time = TransNullToDate(value.ToString());
 AddUpdatedFld(condm_model_diagram_stage_map.updated_time);
}
else if (condm_model_diagram_stage_map.remark  ==  _AttributeName[intIndex])
{
mstrremark = value.ToString();
 AddUpdatedFld(condm_model_diagram_stage_map.remark);
}
}
}

/// <summary>
/// 图阶段映射ID(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long diagram_stage_map_id
{
get
{
return mlngdiagram_stage_map_id;
}
set
{
 mlngdiagram_stage_map_id = value;
//记录修改过的字段
 AddUpdatedFld(condm_model_diagram_stage_map.diagram_stage_map_id);
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
 AddUpdatedFld(condm_model_diagram_stage_map.PrjId);
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
 AddUpdatedFld(condm_model_diagram_stage_map.diagram_id);
}
}
/// <summary>
/// 阶段ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string stage_id
{
get
{
return mstrstage_id;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrstage_id = value;
}
else
{
 mstrstage_id = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_diagram_stage_map.stage_id);
}
}
/// <summary>
/// X坐标(说明:;字段类型:int;字段长度:0;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int x_pos
{
get
{
return mintx_pos;
}
set
{
 mintx_pos = value;
//记录修改过的字段
 AddUpdatedFld(condm_model_diagram_stage_map.x_pos);
}
}
/// <summary>
/// Y坐标(说明:;字段类型:int;字段长度:0;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int y_pos
{
get
{
return minty_pos;
}
set
{
 minty_pos = value;
//记录修改过的字段
 AddUpdatedFld(condm_model_diagram_stage_map.y_pos);
}
}
/// <summary>
/// 宽(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int Width
{
get
{
return mintWidth;
}
set
{
 mintWidth = value;
//记录修改过的字段
 AddUpdatedFld(condm_model_diagram_stage_map.Width);
}
}
/// <summary>
/// 高度(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int Height
{
get
{
return mintHeight;
}
set
{
 mintHeight = value;
//记录修改过的字段
 AddUpdatedFld(condm_model_diagram_stage_map.Height);
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
 AddUpdatedFld(condm_model_diagram_stage_map.sort_no);
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
 AddUpdatedFld(condm_model_diagram_stage_map.is_visible);
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
 AddUpdatedFld(condm_model_diagram_stage_map.Status);
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
 AddUpdatedFld(condm_model_diagram_stage_map.created_by);
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
 AddUpdatedFld(condm_model_diagram_stage_map.created_time);
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
 AddUpdatedFld(condm_model_diagram_stage_map.updated_by);
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
 AddUpdatedFld(condm_model_diagram_stage_map.updated_time);
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
 AddUpdatedFld(condm_model_diagram_stage_map.remark);
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
  return mlngdiagram_stage_map_id.ToString();
 }
 }
}
 /// <summary>
 /// 图阶段布局映射(dm_model_diagram_stage_map)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class condm_model_diagram_stage_map
{
public const string _CurrTabName = "dm_model_diagram_stage_map"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "diagram_stage_map_id"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"diagram_stage_map_id", "PrjId", "diagram_id", "stage_id", "x_pos", "y_pos", "Width", "Height", "sort_no", "is_visible", "Status", "created_by", "created_time", "updated_by", "updated_time", "remark"};
//以下是属性变量


 /// <summary>
 /// 常量:"diagram_stage_map_id"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string diagram_stage_map_id = "diagram_stage_map_id";    //图阶段映射ID

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
 /// 常量:"stage_id"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string stage_id = "stage_id";    //阶段ID

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