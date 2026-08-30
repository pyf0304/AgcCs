
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsdm_model_stage_node_mapEN
 表名:dm_model_stage_node_map(00050670)
 * 版本:2026.08.13(服务器:WIN-SRV103-116)
 日期:2026/08/14 06:24:25
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
 /// 表dm_model_stage_node_map的关键字(stage_node_map_id)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_stage_node_map_id_dm_model_stage_node_map
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strstage_node_map_id">表关键字</param>
public K_stage_node_map_id_dm_model_stage_node_map(string strstage_node_map_id)
{
if (IsValid(strstage_node_map_id)) Value = strstage_node_map_id;
else
{
Value = null;
}
}
private static bool IsValid(string strstage_node_map_id)
{
if (string.IsNullOrEmpty(strstage_node_map_id) == true) return false;
if (strstage_node_map_id.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_stage_node_map_id_dm_model_stage_node_map]类型的对象</returns>
public static implicit operator K_stage_node_map_id_dm_model_stage_node_map(string value)
{
return new K_stage_node_map_id_dm_model_stage_node_map(value);
}
}
 /// <summary>
 /// 阶段结点映射(dm_model_stage_node_map)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsdm_model_stage_node_mapEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "dm_model_stage_node_map"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "stage_node_map_id"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 18;
public static string[] _AttributeName = new string[] {"stage_node_map_id", "PrjId", "stage_id", "diagram_id", "node_code", "node_name", "node_role", "TabId", "TabNameS", "table_role", "is_primary", "sort_no", "Status", "created_by", "created_time", "updated_by", "updated_time", "remark"};

protected string mstrstage_node_map_id;    //阶段结点映射ID
protected string mstrPrjId;    //工程Id
protected string mstrstage_id;    //阶段ID
protected string mstrdiagram_id;    //图ID
protected string mstrnode_code;    //结点编码
protected string mstrnode_name;    //结点名称
protected string mstrnode_role;    //结点角色
protected string mstrTabId;    //表ID
protected string mstrTabNameS;    //显示用表名
protected string mstrtable_role;    //表角色
protected bool mbolis_primary;    //是否主结点
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
 public clsdm_model_stage_node_mapEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("stage_node_map_id");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strstage_node_map_id">关键字:阶段结点映射ID</param>
public clsdm_model_stage_node_mapEN(string strstage_node_map_id)
 {
strstage_node_map_id = strstage_node_map_id.Replace("'", "''");
if (strstage_node_map_id.Length > 8)
{
throw new Exception("在表:dm_model_stage_node_map中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strstage_node_map_id)  ==  true)
{
throw new Exception("在表:dm_model_stage_node_map中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strstage_node_map_id);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrstage_node_map_id = strstage_node_map_id;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("stage_node_map_id");
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
if (strAttributeName  ==  condm_model_stage_node_map.stage_node_map_id)
{
return mstrstage_node_map_id;
}
else if (strAttributeName  ==  condm_model_stage_node_map.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  condm_model_stage_node_map.stage_id)
{
return mstrstage_id;
}
else if (strAttributeName  ==  condm_model_stage_node_map.diagram_id)
{
return mstrdiagram_id;
}
else if (strAttributeName  ==  condm_model_stage_node_map.node_code)
{
return mstrnode_code;
}
else if (strAttributeName  ==  condm_model_stage_node_map.node_name)
{
return mstrnode_name;
}
else if (strAttributeName  ==  condm_model_stage_node_map.node_role)
{
return mstrnode_role;
}
else if (strAttributeName  ==  condm_model_stage_node_map.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  condm_model_stage_node_map.TabNameS)
{
return mstrTabNameS;
}
else if (strAttributeName  ==  condm_model_stage_node_map.table_role)
{
return mstrtable_role;
}
else if (strAttributeName  ==  condm_model_stage_node_map.is_primary)
{
return mbolis_primary;
}
else if (strAttributeName  ==  condm_model_stage_node_map.sort_no)
{
return mintsort_no;
}
else if (strAttributeName  ==  condm_model_stage_node_map.Status)
{
return mstrStatus;
}
else if (strAttributeName  ==  condm_model_stage_node_map.created_by)
{
return mstrcreated_by;
}
else if (strAttributeName  ==  condm_model_stage_node_map.created_time)
{
return mdtecreated_time;
}
else if (strAttributeName  ==  condm_model_stage_node_map.updated_by)
{
return mstrupdated_by;
}
else if (strAttributeName  ==  condm_model_stage_node_map.updated_time)
{
return mdteupdated_time;
}
else if (strAttributeName  ==  condm_model_stage_node_map.remark)
{
return mstrremark;
}
return null;
}
set
{
if (strAttributeName  ==  condm_model_stage_node_map.stage_node_map_id)
{
mstrstage_node_map_id = value.ToString();
 AddUpdatedFld(condm_model_stage_node_map.stage_node_map_id);
}
else if (strAttributeName  ==  condm_model_stage_node_map.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(condm_model_stage_node_map.PrjId);
}
else if (strAttributeName  ==  condm_model_stage_node_map.stage_id)
{
mstrstage_id = value.ToString();
 AddUpdatedFld(condm_model_stage_node_map.stage_id);
}
else if (strAttributeName  ==  condm_model_stage_node_map.diagram_id)
{
mstrdiagram_id = value.ToString();
 AddUpdatedFld(condm_model_stage_node_map.diagram_id);
}
else if (strAttributeName  ==  condm_model_stage_node_map.node_code)
{
mstrnode_code = value.ToString();
 AddUpdatedFld(condm_model_stage_node_map.node_code);
}
else if (strAttributeName  ==  condm_model_stage_node_map.node_name)
{
mstrnode_name = value.ToString();
 AddUpdatedFld(condm_model_stage_node_map.node_name);
}
else if (strAttributeName  ==  condm_model_stage_node_map.node_role)
{
mstrnode_role = value.ToString();
 AddUpdatedFld(condm_model_stage_node_map.node_role);
}
else if (strAttributeName  ==  condm_model_stage_node_map.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(condm_model_stage_node_map.TabId);
}
else if (strAttributeName  ==  condm_model_stage_node_map.TabNameS)
{
mstrTabNameS = value.ToString();
 AddUpdatedFld(condm_model_stage_node_map.TabNameS);
}
else if (strAttributeName  ==  condm_model_stage_node_map.table_role)
{
mstrtable_role = value.ToString();
 AddUpdatedFld(condm_model_stage_node_map.table_role);
}
else if (strAttributeName  ==  condm_model_stage_node_map.is_primary)
{
mbolis_primary = TransNullToBool(value.ToString());
 AddUpdatedFld(condm_model_stage_node_map.is_primary);
}
else if (strAttributeName  ==  condm_model_stage_node_map.sort_no)
{
mintsort_no = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_stage_node_map.sort_no);
}
else if (strAttributeName  ==  condm_model_stage_node_map.Status)
{
mstrStatus = value.ToString();
 AddUpdatedFld(condm_model_stage_node_map.Status);
}
else if (strAttributeName  ==  condm_model_stage_node_map.created_by)
{
mstrcreated_by = value.ToString();
 AddUpdatedFld(condm_model_stage_node_map.created_by);
}
else if (strAttributeName  ==  condm_model_stage_node_map.created_time)
{
mdtecreated_time = TransNullToDate(value.ToString());
 AddUpdatedFld(condm_model_stage_node_map.created_time);
}
else if (strAttributeName  ==  condm_model_stage_node_map.updated_by)
{
mstrupdated_by = value.ToString();
 AddUpdatedFld(condm_model_stage_node_map.updated_by);
}
else if (strAttributeName  ==  condm_model_stage_node_map.updated_time)
{
mdteupdated_time = TransNullToDate(value.ToString());
 AddUpdatedFld(condm_model_stage_node_map.updated_time);
}
else if (strAttributeName  ==  condm_model_stage_node_map.remark)
{
mstrremark = value.ToString();
 AddUpdatedFld(condm_model_stage_node_map.remark);
}
}
}
public object this[int intIndex]
{
get
{
if (condm_model_stage_node_map.stage_node_map_id  ==  _AttributeName[intIndex])
{
return mstrstage_node_map_id;
}
else if (condm_model_stage_node_map.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (condm_model_stage_node_map.stage_id  ==  _AttributeName[intIndex])
{
return mstrstage_id;
}
else if (condm_model_stage_node_map.diagram_id  ==  _AttributeName[intIndex])
{
return mstrdiagram_id;
}
else if (condm_model_stage_node_map.node_code  ==  _AttributeName[intIndex])
{
return mstrnode_code;
}
else if (condm_model_stage_node_map.node_name  ==  _AttributeName[intIndex])
{
return mstrnode_name;
}
else if (condm_model_stage_node_map.node_role  ==  _AttributeName[intIndex])
{
return mstrnode_role;
}
else if (condm_model_stage_node_map.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (condm_model_stage_node_map.TabNameS  ==  _AttributeName[intIndex])
{
return mstrTabNameS;
}
else if (condm_model_stage_node_map.table_role  ==  _AttributeName[intIndex])
{
return mstrtable_role;
}
else if (condm_model_stage_node_map.is_primary  ==  _AttributeName[intIndex])
{
return mbolis_primary;
}
else if (condm_model_stage_node_map.sort_no  ==  _AttributeName[intIndex])
{
return mintsort_no;
}
else if (condm_model_stage_node_map.Status  ==  _AttributeName[intIndex])
{
return mstrStatus;
}
else if (condm_model_stage_node_map.created_by  ==  _AttributeName[intIndex])
{
return mstrcreated_by;
}
else if (condm_model_stage_node_map.created_time  ==  _AttributeName[intIndex])
{
return mdtecreated_time;
}
else if (condm_model_stage_node_map.updated_by  ==  _AttributeName[intIndex])
{
return mstrupdated_by;
}
else if (condm_model_stage_node_map.updated_time  ==  _AttributeName[intIndex])
{
return mdteupdated_time;
}
else if (condm_model_stage_node_map.remark  ==  _AttributeName[intIndex])
{
return mstrremark;
}
return null;
}
set
{
if (condm_model_stage_node_map.stage_node_map_id  ==  _AttributeName[intIndex])
{
mstrstage_node_map_id = value.ToString();
 AddUpdatedFld(condm_model_stage_node_map.stage_node_map_id);
}
else if (condm_model_stage_node_map.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(condm_model_stage_node_map.PrjId);
}
else if (condm_model_stage_node_map.stage_id  ==  _AttributeName[intIndex])
{
mstrstage_id = value.ToString();
 AddUpdatedFld(condm_model_stage_node_map.stage_id);
}
else if (condm_model_stage_node_map.diagram_id  ==  _AttributeName[intIndex])
{
mstrdiagram_id = value.ToString();
 AddUpdatedFld(condm_model_stage_node_map.diagram_id);
}
else if (condm_model_stage_node_map.node_code  ==  _AttributeName[intIndex])
{
mstrnode_code = value.ToString();
 AddUpdatedFld(condm_model_stage_node_map.node_code);
}
else if (condm_model_stage_node_map.node_name  ==  _AttributeName[intIndex])
{
mstrnode_name = value.ToString();
 AddUpdatedFld(condm_model_stage_node_map.node_name);
}
else if (condm_model_stage_node_map.node_role  ==  _AttributeName[intIndex])
{
mstrnode_role = value.ToString();
 AddUpdatedFld(condm_model_stage_node_map.node_role);
}
else if (condm_model_stage_node_map.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(condm_model_stage_node_map.TabId);
}
else if (condm_model_stage_node_map.TabNameS  ==  _AttributeName[intIndex])
{
mstrTabNameS = value.ToString();
 AddUpdatedFld(condm_model_stage_node_map.TabNameS);
}
else if (condm_model_stage_node_map.table_role  ==  _AttributeName[intIndex])
{
mstrtable_role = value.ToString();
 AddUpdatedFld(condm_model_stage_node_map.table_role);
}
else if (condm_model_stage_node_map.is_primary  ==  _AttributeName[intIndex])
{
mbolis_primary = TransNullToBool(value.ToString());
 AddUpdatedFld(condm_model_stage_node_map.is_primary);
}
else if (condm_model_stage_node_map.sort_no  ==  _AttributeName[intIndex])
{
mintsort_no = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_stage_node_map.sort_no);
}
else if (condm_model_stage_node_map.Status  ==  _AttributeName[intIndex])
{
mstrStatus = value.ToString();
 AddUpdatedFld(condm_model_stage_node_map.Status);
}
else if (condm_model_stage_node_map.created_by  ==  _AttributeName[intIndex])
{
mstrcreated_by = value.ToString();
 AddUpdatedFld(condm_model_stage_node_map.created_by);
}
else if (condm_model_stage_node_map.created_time  ==  _AttributeName[intIndex])
{
mdtecreated_time = TransNullToDate(value.ToString());
 AddUpdatedFld(condm_model_stage_node_map.created_time);
}
else if (condm_model_stage_node_map.updated_by  ==  _AttributeName[intIndex])
{
mstrupdated_by = value.ToString();
 AddUpdatedFld(condm_model_stage_node_map.updated_by);
}
else if (condm_model_stage_node_map.updated_time  ==  _AttributeName[intIndex])
{
mdteupdated_time = TransNullToDate(value.ToString());
 AddUpdatedFld(condm_model_stage_node_map.updated_time);
}
else if (condm_model_stage_node_map.remark  ==  _AttributeName[intIndex])
{
mstrremark = value.ToString();
 AddUpdatedFld(condm_model_stage_node_map.remark);
}
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
 AddUpdatedFld(condm_model_stage_node_map.stage_node_map_id);
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
 AddUpdatedFld(condm_model_stage_node_map.PrjId);
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
 AddUpdatedFld(condm_model_stage_node_map.stage_id);
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
 AddUpdatedFld(condm_model_stage_node_map.diagram_id);
}
}
/// <summary>
/// 结点编码(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string node_code
{
get
{
return mstrnode_code;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrnode_code = value;
}
else
{
 mstrnode_code = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_stage_node_map.node_code);
}
}
/// <summary>
/// 结点名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string node_name
{
get
{
return mstrnode_name;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrnode_name = value;
}
else
{
 mstrnode_name = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_stage_node_map.node_name);
}
}
/// <summary>
/// 结点角色(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string node_role
{
get
{
return mstrnode_role;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrnode_role = value;
}
else
{
 mstrnode_role = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_stage_node_map.node_role);
}
}
/// <summary>
/// 表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabId
{
get
{
return mstrTabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabId = value;
}
else
{
 mstrTabId = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_stage_node_map.TabId);
}
}
/// <summary>
/// 显示用表名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabNameS
{
get
{
return mstrTabNameS;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabNameS = value;
}
else
{
 mstrTabNameS = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_stage_node_map.TabNameS);
}
}
/// <summary>
/// 表角色(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string table_role
{
get
{
return mstrtable_role;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrtable_role = value;
}
else
{
 mstrtable_role = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_stage_node_map.table_role);
}
}
/// <summary>
/// 是否主结点(说明:;字段类型:bit;字段长度:0;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool is_primary
{
get
{
return mbolis_primary;
}
set
{
 mbolis_primary = value;
//记录修改过的字段
 AddUpdatedFld(condm_model_stage_node_map.is_primary);
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
 AddUpdatedFld(condm_model_stage_node_map.sort_no);
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
 AddUpdatedFld(condm_model_stage_node_map.Status);
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
 AddUpdatedFld(condm_model_stage_node_map.created_by);
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
 AddUpdatedFld(condm_model_stage_node_map.created_time);
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
 AddUpdatedFld(condm_model_stage_node_map.updated_by);
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
 AddUpdatedFld(condm_model_stage_node_map.updated_time);
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
 AddUpdatedFld(condm_model_stage_node_map.remark);
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
  return mstrstage_node_map_id;
 }
 }
}
 /// <summary>
 /// 阶段结点映射(dm_model_stage_node_map)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class condm_model_stage_node_map
{
public const string _CurrTabName = "dm_model_stage_node_map"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "stage_node_map_id"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"stage_node_map_id", "PrjId", "stage_id", "diagram_id", "node_code", "node_name", "node_role", "TabId", "TabNameS", "table_role", "is_primary", "sort_no", "Status", "created_by", "created_time", "updated_by", "updated_time", "remark"};
//以下是属性变量


 /// <summary>
 /// 常量:"stage_node_map_id"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string stage_node_map_id = "stage_node_map_id";    //阶段结点映射ID

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"stage_id"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string stage_id = "stage_id";    //阶段ID

 /// <summary>
 /// 常量:"diagram_id"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string diagram_id = "diagram_id";    //图ID

 /// <summary>
 /// 常量:"node_code"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string node_code = "node_code";    //结点编码

 /// <summary>
 /// 常量:"node_name"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string node_name = "node_name";    //结点名称

 /// <summary>
 /// 常量:"node_role"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string node_role = "node_role";    //结点角色

 /// <summary>
 /// 常量:"TabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabId = "TabId";    //表ID

 /// <summary>
 /// 常量:"TabNameS"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabNameS = "TabNameS";    //显示用表名

 /// <summary>
 /// 常量:"table_role"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string table_role = "table_role";    //表角色

 /// <summary>
 /// 常量:"is_primary"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string is_primary = "is_primary";    //是否主结点

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