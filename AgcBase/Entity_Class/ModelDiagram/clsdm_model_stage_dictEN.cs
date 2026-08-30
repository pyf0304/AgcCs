
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsdm_model_stage_dictEN
 表名:dm_model_stage_dict(00050669)
 * 版本:2026.08.13(服务器:WIN-SRV103-116)
 日期:2026/08/17 22:03:26
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
 /// 表dm_model_stage_dict的关键字(stage_id)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_stage_id_dm_model_stage_dict
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strstage_id">表关键字</param>
public K_stage_id_dm_model_stage_dict(string strstage_id)
{
if (IsValid(strstage_id)) Value = strstage_id;
else
{
Value = null;
}
}
private static bool IsValid(string strstage_id)
{
if (string.IsNullOrEmpty(strstage_id) == true) return false;
if (strstage_id.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_stage_id_dm_model_stage_dict]类型的对象</returns>
public static implicit operator K_stage_id_dm_model_stage_dict(string value)
{
return new K_stage_id_dm_model_stage_dict(value);
}
}
 /// <summary>
 /// 阶段字典(dm_model_stage_dict)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsdm_model_stage_dictEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "dm_model_stage_dict"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "stage_id"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 17;
public static string[] _AttributeName = new string[] {"stage_id", "PrjId", "stage_code", "stage_name", "node_role", "stage_desc", "sort_no", "offset_x", "offset_y", "Height", "Width", "Status", "created_by", "created_time", "updated_by", "updated_time", "remark"};

protected string mstrstage_id;    //阶段ID
protected string mstrPrjId;    //工程Id
protected string mstrstage_code;    //阶段编码
protected string mstrstage_name;    //阶段名称
protected string mstrnode_role;    //结点角色
protected string mstrstage_desc;    //阶段说明
protected int mintsort_no;    //排序号
protected int? mintoffset_x;    //左上角x
protected int? mintoffset_y;    //左上角y
protected int? mintHeight;    //高度
protected int? mintWidth;    //宽
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
 public clsdm_model_stage_dictEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("stage_id");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strstage_id">关键字:阶段ID</param>
public clsdm_model_stage_dictEN(string strstage_id)
 {
strstage_id = strstage_id.Replace("'", "''");
if (strstage_id.Length > 8)
{
throw new Exception("在表:dm_model_stage_dict中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strstage_id)  ==  true)
{
throw new Exception("在表:dm_model_stage_dict中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strstage_id);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrstage_id = strstage_id;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("stage_id");
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
if (strAttributeName  ==  condm_model_stage_dict.stage_id)
{
return mstrstage_id;
}
else if (strAttributeName  ==  condm_model_stage_dict.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  condm_model_stage_dict.stage_code)
{
return mstrstage_code;
}
else if (strAttributeName  ==  condm_model_stage_dict.stage_name)
{
return mstrstage_name;
}
else if (strAttributeName  ==  condm_model_stage_dict.node_role)
{
return mstrnode_role;
}
else if (strAttributeName  ==  condm_model_stage_dict.stage_desc)
{
return mstrstage_desc;
}
else if (strAttributeName  ==  condm_model_stage_dict.sort_no)
{
return mintsort_no;
}
else if (strAttributeName  ==  condm_model_stage_dict.offset_x)
{
return mintoffset_x;
}
else if (strAttributeName  ==  condm_model_stage_dict.offset_y)
{
return mintoffset_y;
}
else if (strAttributeName  ==  condm_model_stage_dict.Height)
{
return mintHeight;
}
else if (strAttributeName  ==  condm_model_stage_dict.Width)
{
return mintWidth;
}
else if (strAttributeName  ==  condm_model_stage_dict.Status)
{
return mstrStatus;
}
else if (strAttributeName  ==  condm_model_stage_dict.created_by)
{
return mstrcreated_by;
}
else if (strAttributeName  ==  condm_model_stage_dict.created_time)
{
return mdtecreated_time;
}
else if (strAttributeName  ==  condm_model_stage_dict.updated_by)
{
return mstrupdated_by;
}
else if (strAttributeName  ==  condm_model_stage_dict.updated_time)
{
return mdteupdated_time;
}
else if (strAttributeName  ==  condm_model_stage_dict.remark)
{
return mstrremark;
}
return null;
}
set
{
if (strAttributeName  ==  condm_model_stage_dict.stage_id)
{
mstrstage_id = value.ToString();
 AddUpdatedFld(condm_model_stage_dict.stage_id);
}
else if (strAttributeName  ==  condm_model_stage_dict.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(condm_model_stage_dict.PrjId);
}
else if (strAttributeName  ==  condm_model_stage_dict.stage_code)
{
mstrstage_code = value.ToString();
 AddUpdatedFld(condm_model_stage_dict.stage_code);
}
else if (strAttributeName  ==  condm_model_stage_dict.stage_name)
{
mstrstage_name = value.ToString();
 AddUpdatedFld(condm_model_stage_dict.stage_name);
}
else if (strAttributeName  ==  condm_model_stage_dict.node_role)
{
mstrnode_role = value.ToString();
 AddUpdatedFld(condm_model_stage_dict.node_role);
}
else if (strAttributeName  ==  condm_model_stage_dict.stage_desc)
{
mstrstage_desc = value.ToString();
 AddUpdatedFld(condm_model_stage_dict.stage_desc);
}
else if (strAttributeName  ==  condm_model_stage_dict.sort_no)
{
mintsort_no = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_stage_dict.sort_no);
}
else if (strAttributeName  ==  condm_model_stage_dict.offset_x)
{
mintoffset_x = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_stage_dict.offset_x);
}
else if (strAttributeName  ==  condm_model_stage_dict.offset_y)
{
mintoffset_y = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_stage_dict.offset_y);
}
else if (strAttributeName  ==  condm_model_stage_dict.Height)
{
mintHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_stage_dict.Height);
}
else if (strAttributeName  ==  condm_model_stage_dict.Width)
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_stage_dict.Width);
}
else if (strAttributeName  ==  condm_model_stage_dict.Status)
{
mstrStatus = value.ToString();
 AddUpdatedFld(condm_model_stage_dict.Status);
}
else if (strAttributeName  ==  condm_model_stage_dict.created_by)
{
mstrcreated_by = value.ToString();
 AddUpdatedFld(condm_model_stage_dict.created_by);
}
else if (strAttributeName  ==  condm_model_stage_dict.created_time)
{
mdtecreated_time = TransNullToDate(value.ToString());
 AddUpdatedFld(condm_model_stage_dict.created_time);
}
else if (strAttributeName  ==  condm_model_stage_dict.updated_by)
{
mstrupdated_by = value.ToString();
 AddUpdatedFld(condm_model_stage_dict.updated_by);
}
else if (strAttributeName  ==  condm_model_stage_dict.updated_time)
{
mdteupdated_time = TransNullToDate(value.ToString());
 AddUpdatedFld(condm_model_stage_dict.updated_time);
}
else if (strAttributeName  ==  condm_model_stage_dict.remark)
{
mstrremark = value.ToString();
 AddUpdatedFld(condm_model_stage_dict.remark);
}
}
}
public object this[int intIndex]
{
get
{
if (condm_model_stage_dict.stage_id  ==  _AttributeName[intIndex])
{
return mstrstage_id;
}
else if (condm_model_stage_dict.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (condm_model_stage_dict.stage_code  ==  _AttributeName[intIndex])
{
return mstrstage_code;
}
else if (condm_model_stage_dict.stage_name  ==  _AttributeName[intIndex])
{
return mstrstage_name;
}
else if (condm_model_stage_dict.node_role  ==  _AttributeName[intIndex])
{
return mstrnode_role;
}
else if (condm_model_stage_dict.stage_desc  ==  _AttributeName[intIndex])
{
return mstrstage_desc;
}
else if (condm_model_stage_dict.sort_no  ==  _AttributeName[intIndex])
{
return mintsort_no;
}
else if (condm_model_stage_dict.offset_x  ==  _AttributeName[intIndex])
{
return mintoffset_x;
}
else if (condm_model_stage_dict.offset_y  ==  _AttributeName[intIndex])
{
return mintoffset_y;
}
else if (condm_model_stage_dict.Height  ==  _AttributeName[intIndex])
{
return mintHeight;
}
else if (condm_model_stage_dict.Width  ==  _AttributeName[intIndex])
{
return mintWidth;
}
else if (condm_model_stage_dict.Status  ==  _AttributeName[intIndex])
{
return mstrStatus;
}
else if (condm_model_stage_dict.created_by  ==  _AttributeName[intIndex])
{
return mstrcreated_by;
}
else if (condm_model_stage_dict.created_time  ==  _AttributeName[intIndex])
{
return mdtecreated_time;
}
else if (condm_model_stage_dict.updated_by  ==  _AttributeName[intIndex])
{
return mstrupdated_by;
}
else if (condm_model_stage_dict.updated_time  ==  _AttributeName[intIndex])
{
return mdteupdated_time;
}
else if (condm_model_stage_dict.remark  ==  _AttributeName[intIndex])
{
return mstrremark;
}
return null;
}
set
{
if (condm_model_stage_dict.stage_id  ==  _AttributeName[intIndex])
{
mstrstage_id = value.ToString();
 AddUpdatedFld(condm_model_stage_dict.stage_id);
}
else if (condm_model_stage_dict.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(condm_model_stage_dict.PrjId);
}
else if (condm_model_stage_dict.stage_code  ==  _AttributeName[intIndex])
{
mstrstage_code = value.ToString();
 AddUpdatedFld(condm_model_stage_dict.stage_code);
}
else if (condm_model_stage_dict.stage_name  ==  _AttributeName[intIndex])
{
mstrstage_name = value.ToString();
 AddUpdatedFld(condm_model_stage_dict.stage_name);
}
else if (condm_model_stage_dict.node_role  ==  _AttributeName[intIndex])
{
mstrnode_role = value.ToString();
 AddUpdatedFld(condm_model_stage_dict.node_role);
}
else if (condm_model_stage_dict.stage_desc  ==  _AttributeName[intIndex])
{
mstrstage_desc = value.ToString();
 AddUpdatedFld(condm_model_stage_dict.stage_desc);
}
else if (condm_model_stage_dict.sort_no  ==  _AttributeName[intIndex])
{
mintsort_no = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_stage_dict.sort_no);
}
else if (condm_model_stage_dict.offset_x  ==  _AttributeName[intIndex])
{
mintoffset_x = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_stage_dict.offset_x);
}
else if (condm_model_stage_dict.offset_y  ==  _AttributeName[intIndex])
{
mintoffset_y = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_stage_dict.offset_y);
}
else if (condm_model_stage_dict.Height  ==  _AttributeName[intIndex])
{
mintHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_stage_dict.Height);
}
else if (condm_model_stage_dict.Width  ==  _AttributeName[intIndex])
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_stage_dict.Width);
}
else if (condm_model_stage_dict.Status  ==  _AttributeName[intIndex])
{
mstrStatus = value.ToString();
 AddUpdatedFld(condm_model_stage_dict.Status);
}
else if (condm_model_stage_dict.created_by  ==  _AttributeName[intIndex])
{
mstrcreated_by = value.ToString();
 AddUpdatedFld(condm_model_stage_dict.created_by);
}
else if (condm_model_stage_dict.created_time  ==  _AttributeName[intIndex])
{
mdtecreated_time = TransNullToDate(value.ToString());
 AddUpdatedFld(condm_model_stage_dict.created_time);
}
else if (condm_model_stage_dict.updated_by  ==  _AttributeName[intIndex])
{
mstrupdated_by = value.ToString();
 AddUpdatedFld(condm_model_stage_dict.updated_by);
}
else if (condm_model_stage_dict.updated_time  ==  _AttributeName[intIndex])
{
mdteupdated_time = TransNullToDate(value.ToString());
 AddUpdatedFld(condm_model_stage_dict.updated_time);
}
else if (condm_model_stage_dict.remark  ==  _AttributeName[intIndex])
{
mstrremark = value.ToString();
 AddUpdatedFld(condm_model_stage_dict.remark);
}
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
 AddUpdatedFld(condm_model_stage_dict.stage_id);
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
 AddUpdatedFld(condm_model_stage_dict.PrjId);
}
}
/// <summary>
/// 阶段编码(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string stage_code
{
get
{
return mstrstage_code;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrstage_code = value;
}
else
{
 mstrstage_code = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_stage_dict.stage_code);
}
}
/// <summary>
/// 阶段名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string stage_name
{
get
{
return mstrstage_name;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrstage_name = value;
}
else
{
 mstrstage_name = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_stage_dict.stage_name);
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
 AddUpdatedFld(condm_model_stage_dict.node_role);
}
}
/// <summary>
/// 阶段说明(说明:;字段类型:varchar;字段长度:300;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string stage_desc
{
get
{
return mstrstage_desc;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrstage_desc = value;
}
else
{
 mstrstage_desc = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_stage_dict.stage_desc);
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
 AddUpdatedFld(condm_model_stage_dict.sort_no);
}
}
/// <summary>
/// 左上角x(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? offset_x
{
get
{
return mintoffset_x;
}
set
{
 mintoffset_x = value;
//记录修改过的字段
 AddUpdatedFld(condm_model_stage_dict.offset_x);
}
}
/// <summary>
/// 左上角y(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? offset_y
{
get
{
return mintoffset_y;
}
set
{
 mintoffset_y = value;
//记录修改过的字段
 AddUpdatedFld(condm_model_stage_dict.offset_y);
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
 AddUpdatedFld(condm_model_stage_dict.Height);
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
 AddUpdatedFld(condm_model_stage_dict.Width);
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
 AddUpdatedFld(condm_model_stage_dict.Status);
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
 AddUpdatedFld(condm_model_stage_dict.created_by);
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
 AddUpdatedFld(condm_model_stage_dict.created_time);
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
 AddUpdatedFld(condm_model_stage_dict.updated_by);
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
 AddUpdatedFld(condm_model_stage_dict.updated_time);
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
 AddUpdatedFld(condm_model_stage_dict.remark);
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
  return mstrstage_id;
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
  return mstrstage_name;
 }
 }
}
 /// <summary>
 /// 阶段字典(dm_model_stage_dict)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class condm_model_stage_dict
{
public const string _CurrTabName = "dm_model_stage_dict"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "stage_id"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"stage_id", "PrjId", "stage_code", "stage_name", "node_role", "stage_desc", "sort_no", "offset_x", "offset_y", "Height", "Width", "Status", "created_by", "created_time", "updated_by", "updated_time", "remark"};
//以下是属性变量


 /// <summary>
 /// 常量:"stage_id"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string stage_id = "stage_id";    //阶段ID

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"stage_code"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string stage_code = "stage_code";    //阶段编码

 /// <summary>
 /// 常量:"stage_name"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string stage_name = "stage_name";    //阶段名称

 /// <summary>
 /// 常量:"node_role"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string node_role = "node_role";    //结点角色

 /// <summary>
 /// 常量:"stage_desc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string stage_desc = "stage_desc";    //阶段说明

 /// <summary>
 /// 常量:"sort_no"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string sort_no = "sort_no";    //排序号

 /// <summary>
 /// 常量:"offset_x"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string offset_x = "offset_x";    //左上角x

 /// <summary>
 /// 常量:"offset_y"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string offset_y = "offset_y";    //左上角y

 /// <summary>
 /// 常量:"Height"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Height = "Height";    //高度

 /// <summary>
 /// 常量:"Width"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Width = "Width";    //宽

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