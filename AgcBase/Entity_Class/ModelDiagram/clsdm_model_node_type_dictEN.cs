
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsdm_model_node_type_dictEN
 表名:dm_model_node_type_dict(00050673)
 * 版本:2026.08.13(服务器:WIN-SRV103-116)
 日期:2026/08/15 13:11:00
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
 /// 表dm_model_node_type_dict的关键字(node_type_code)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_node_type_code_dm_model_node_type_dict
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strnode_type_code">表关键字</param>
public K_node_type_code_dm_model_node_type_dict(string strnode_type_code)
{
if (IsValid(strnode_type_code)) Value = strnode_type_code;
else
{
Value = null;
}
}
private static bool IsValid(string strnode_type_code)
{
if (string.IsNullOrEmpty(strnode_type_code) == true) return false;
if (strnode_type_code.Length > 30) return false;
if (strnode_type_code.IndexOf(' ') >= 0) return false;
if (strnode_type_code.IndexOf(')') >= 0) return false;
if (strnode_type_code.IndexOf('(') >= 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_node_type_code_dm_model_node_type_dict]类型的对象</returns>
public static implicit operator K_node_type_code_dm_model_node_type_dict(string value)
{
return new K_node_type_code_dm_model_node_type_dict(value);
}
}
 /// <summary>
 /// 模型结点类型字典(dm_model_node_type_dict)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsdm_model_node_type_dictEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "dm_model_node_type_dict"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "node_type_code"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 14;
public static string[] _AttributeName = new string[] {"node_type_code", "node_type_name", "border_shape", "border_color", "fill_color", "icon_name", "sort_no", "is_active", "Status", "created_by", "created_time", "updated_by", "updated_time", "remark"};

protected string mstrnode_type_code;    //结点类型编码
protected string mstrnode_type_name;    //结点类型名称
protected string mstrborder_shape;    //外框形状
protected string mstrborder_color;    //边框颜色
protected string mstrfill_color;    //填充颜色
protected string mstricon_name;    //图标名
protected int mintsort_no;    //排序号
protected bool mbolis_active;    //是否启用
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
 public clsdm_model_node_type_dictEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("node_type_code");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strnode_type_code">关键字:结点类型编码</param>
public clsdm_model_node_type_dictEN(string strnode_type_code)
 {
strnode_type_code = strnode_type_code.Replace("'", "''");
if (strnode_type_code.Length > 30)
{
throw new Exception("在表:dm_model_node_type_dict中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strnode_type_code)  ==  true)
{
throw new Exception("在表:dm_model_node_type_dict中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strnode_type_code);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrnode_type_code = strnode_type_code;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("node_type_code");
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
if (strAttributeName  ==  condm_model_node_type_dict.node_type_code)
{
return mstrnode_type_code;
}
else if (strAttributeName  ==  condm_model_node_type_dict.node_type_name)
{
return mstrnode_type_name;
}
else if (strAttributeName  ==  condm_model_node_type_dict.border_shape)
{
return mstrborder_shape;
}
else if (strAttributeName  ==  condm_model_node_type_dict.border_color)
{
return mstrborder_color;
}
else if (strAttributeName  ==  condm_model_node_type_dict.fill_color)
{
return mstrfill_color;
}
else if (strAttributeName  ==  condm_model_node_type_dict.icon_name)
{
return mstricon_name;
}
else if (strAttributeName  ==  condm_model_node_type_dict.sort_no)
{
return mintsort_no;
}
else if (strAttributeName  ==  condm_model_node_type_dict.is_active)
{
return mbolis_active;
}
else if (strAttributeName  ==  condm_model_node_type_dict.Status)
{
return mstrStatus;
}
else if (strAttributeName  ==  condm_model_node_type_dict.created_by)
{
return mstrcreated_by;
}
else if (strAttributeName  ==  condm_model_node_type_dict.created_time)
{
return mdtecreated_time;
}
else if (strAttributeName  ==  condm_model_node_type_dict.updated_by)
{
return mstrupdated_by;
}
else if (strAttributeName  ==  condm_model_node_type_dict.updated_time)
{
return mdteupdated_time;
}
else if (strAttributeName  ==  condm_model_node_type_dict.remark)
{
return mstrremark;
}
return null;
}
set
{
if (strAttributeName  ==  condm_model_node_type_dict.node_type_code)
{
mstrnode_type_code = value.ToString();
 AddUpdatedFld(condm_model_node_type_dict.node_type_code);
}
else if (strAttributeName  ==  condm_model_node_type_dict.node_type_name)
{
mstrnode_type_name = value.ToString();
 AddUpdatedFld(condm_model_node_type_dict.node_type_name);
}
else if (strAttributeName  ==  condm_model_node_type_dict.border_shape)
{
mstrborder_shape = value.ToString();
 AddUpdatedFld(condm_model_node_type_dict.border_shape);
}
else if (strAttributeName  ==  condm_model_node_type_dict.border_color)
{
mstrborder_color = value.ToString();
 AddUpdatedFld(condm_model_node_type_dict.border_color);
}
else if (strAttributeName  ==  condm_model_node_type_dict.fill_color)
{
mstrfill_color = value.ToString();
 AddUpdatedFld(condm_model_node_type_dict.fill_color);
}
else if (strAttributeName  ==  condm_model_node_type_dict.icon_name)
{
mstricon_name = value.ToString();
 AddUpdatedFld(condm_model_node_type_dict.icon_name);
}
else if (strAttributeName  ==  condm_model_node_type_dict.sort_no)
{
mintsort_no = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_node_type_dict.sort_no);
}
else if (strAttributeName  ==  condm_model_node_type_dict.is_active)
{
mbolis_active = TransNullToBool(value.ToString());
 AddUpdatedFld(condm_model_node_type_dict.is_active);
}
else if (strAttributeName  ==  condm_model_node_type_dict.Status)
{
mstrStatus = value.ToString();
 AddUpdatedFld(condm_model_node_type_dict.Status);
}
else if (strAttributeName  ==  condm_model_node_type_dict.created_by)
{
mstrcreated_by = value.ToString();
 AddUpdatedFld(condm_model_node_type_dict.created_by);
}
else if (strAttributeName  ==  condm_model_node_type_dict.created_time)
{
mdtecreated_time = TransNullToDate(value.ToString());
 AddUpdatedFld(condm_model_node_type_dict.created_time);
}
else if (strAttributeName  ==  condm_model_node_type_dict.updated_by)
{
mstrupdated_by = value.ToString();
 AddUpdatedFld(condm_model_node_type_dict.updated_by);
}
else if (strAttributeName  ==  condm_model_node_type_dict.updated_time)
{
mdteupdated_time = TransNullToDate(value.ToString());
 AddUpdatedFld(condm_model_node_type_dict.updated_time);
}
else if (strAttributeName  ==  condm_model_node_type_dict.remark)
{
mstrremark = value.ToString();
 AddUpdatedFld(condm_model_node_type_dict.remark);
}
}
}
public object this[int intIndex]
{
get
{
if (condm_model_node_type_dict.node_type_code  ==  _AttributeName[intIndex])
{
return mstrnode_type_code;
}
else if (condm_model_node_type_dict.node_type_name  ==  _AttributeName[intIndex])
{
return mstrnode_type_name;
}
else if (condm_model_node_type_dict.border_shape  ==  _AttributeName[intIndex])
{
return mstrborder_shape;
}
else if (condm_model_node_type_dict.border_color  ==  _AttributeName[intIndex])
{
return mstrborder_color;
}
else if (condm_model_node_type_dict.fill_color  ==  _AttributeName[intIndex])
{
return mstrfill_color;
}
else if (condm_model_node_type_dict.icon_name  ==  _AttributeName[intIndex])
{
return mstricon_name;
}
else if (condm_model_node_type_dict.sort_no  ==  _AttributeName[intIndex])
{
return mintsort_no;
}
else if (condm_model_node_type_dict.is_active  ==  _AttributeName[intIndex])
{
return mbolis_active;
}
else if (condm_model_node_type_dict.Status  ==  _AttributeName[intIndex])
{
return mstrStatus;
}
else if (condm_model_node_type_dict.created_by  ==  _AttributeName[intIndex])
{
return mstrcreated_by;
}
else if (condm_model_node_type_dict.created_time  ==  _AttributeName[intIndex])
{
return mdtecreated_time;
}
else if (condm_model_node_type_dict.updated_by  ==  _AttributeName[intIndex])
{
return mstrupdated_by;
}
else if (condm_model_node_type_dict.updated_time  ==  _AttributeName[intIndex])
{
return mdteupdated_time;
}
else if (condm_model_node_type_dict.remark  ==  _AttributeName[intIndex])
{
return mstrremark;
}
return null;
}
set
{
if (condm_model_node_type_dict.node_type_code  ==  _AttributeName[intIndex])
{
mstrnode_type_code = value.ToString();
 AddUpdatedFld(condm_model_node_type_dict.node_type_code);
}
else if (condm_model_node_type_dict.node_type_name  ==  _AttributeName[intIndex])
{
mstrnode_type_name = value.ToString();
 AddUpdatedFld(condm_model_node_type_dict.node_type_name);
}
else if (condm_model_node_type_dict.border_shape  ==  _AttributeName[intIndex])
{
mstrborder_shape = value.ToString();
 AddUpdatedFld(condm_model_node_type_dict.border_shape);
}
else if (condm_model_node_type_dict.border_color  ==  _AttributeName[intIndex])
{
mstrborder_color = value.ToString();
 AddUpdatedFld(condm_model_node_type_dict.border_color);
}
else if (condm_model_node_type_dict.fill_color  ==  _AttributeName[intIndex])
{
mstrfill_color = value.ToString();
 AddUpdatedFld(condm_model_node_type_dict.fill_color);
}
else if (condm_model_node_type_dict.icon_name  ==  _AttributeName[intIndex])
{
mstricon_name = value.ToString();
 AddUpdatedFld(condm_model_node_type_dict.icon_name);
}
else if (condm_model_node_type_dict.sort_no  ==  _AttributeName[intIndex])
{
mintsort_no = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_node_type_dict.sort_no);
}
else if (condm_model_node_type_dict.is_active  ==  _AttributeName[intIndex])
{
mbolis_active = TransNullToBool(value.ToString());
 AddUpdatedFld(condm_model_node_type_dict.is_active);
}
else if (condm_model_node_type_dict.Status  ==  _AttributeName[intIndex])
{
mstrStatus = value.ToString();
 AddUpdatedFld(condm_model_node_type_dict.Status);
}
else if (condm_model_node_type_dict.created_by  ==  _AttributeName[intIndex])
{
mstrcreated_by = value.ToString();
 AddUpdatedFld(condm_model_node_type_dict.created_by);
}
else if (condm_model_node_type_dict.created_time  ==  _AttributeName[intIndex])
{
mdtecreated_time = TransNullToDate(value.ToString());
 AddUpdatedFld(condm_model_node_type_dict.created_time);
}
else if (condm_model_node_type_dict.updated_by  ==  _AttributeName[intIndex])
{
mstrupdated_by = value.ToString();
 AddUpdatedFld(condm_model_node_type_dict.updated_by);
}
else if (condm_model_node_type_dict.updated_time  ==  _AttributeName[intIndex])
{
mdteupdated_time = TransNullToDate(value.ToString());
 AddUpdatedFld(condm_model_node_type_dict.updated_time);
}
else if (condm_model_node_type_dict.remark  ==  _AttributeName[intIndex])
{
mstrremark = value.ToString();
 AddUpdatedFld(condm_model_node_type_dict.remark);
}
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
 AddUpdatedFld(condm_model_node_type_dict.node_type_code);
}
}
/// <summary>
/// 结点类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string node_type_name
{
get
{
return mstrnode_type_name;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrnode_type_name = value;
}
else
{
 mstrnode_type_name = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_node_type_dict.node_type_name);
}
}
/// <summary>
/// 外框形状(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string border_shape
{
get
{
return mstrborder_shape;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrborder_shape = value;
}
else
{
 mstrborder_shape = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_node_type_dict.border_shape);
}
}
/// <summary>
/// 边框颜色(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string border_color
{
get
{
return mstrborder_color;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrborder_color = value;
}
else
{
 mstrborder_color = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_node_type_dict.border_color);
}
}
/// <summary>
/// 填充颜色(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string fill_color
{
get
{
return mstrfill_color;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrfill_color = value;
}
else
{
 mstrfill_color = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_node_type_dict.fill_color);
}
}
/// <summary>
/// 图标名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string icon_name
{
get
{
return mstricon_name;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstricon_name = value;
}
else
{
 mstricon_name = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_node_type_dict.icon_name);
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
 AddUpdatedFld(condm_model_node_type_dict.sort_no);
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
 AddUpdatedFld(condm_model_node_type_dict.is_active);
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
 AddUpdatedFld(condm_model_node_type_dict.Status);
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
 AddUpdatedFld(condm_model_node_type_dict.created_by);
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
 AddUpdatedFld(condm_model_node_type_dict.created_time);
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
 AddUpdatedFld(condm_model_node_type_dict.updated_by);
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
 AddUpdatedFld(condm_model_node_type_dict.updated_time);
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
 AddUpdatedFld(condm_model_node_type_dict.remark);
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
  return mstrnode_type_code;
 }
 }
}
 /// <summary>
 /// 模型结点类型字典(dm_model_node_type_dict)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class condm_model_node_type_dict
{
public const string _CurrTabName = "dm_model_node_type_dict"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "node_type_code"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"node_type_code", "node_type_name", "border_shape", "border_color", "fill_color", "icon_name", "sort_no", "is_active", "Status", "created_by", "created_time", "updated_by", "updated_time", "remark"};
//以下是属性变量


 /// <summary>
 /// 常量:"node_type_code"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string node_type_code = "node_type_code";    //结点类型编码

 /// <summary>
 /// 常量:"node_type_name"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string node_type_name = "node_type_name";    //结点类型名称

 /// <summary>
 /// 常量:"border_shape"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string border_shape = "border_shape";    //外框形状

 /// <summary>
 /// 常量:"border_color"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string border_color = "border_color";    //边框颜色

 /// <summary>
 /// 常量:"fill_color"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string fill_color = "fill_color";    //填充颜色

 /// <summary>
 /// 常量:"icon_name"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string icon_name = "icon_name";    //图标名

 /// <summary>
 /// 常量:"sort_no"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string sort_no = "sort_no";    //排序号

 /// <summary>
 /// 常量:"is_active"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string is_active = "is_active";    //是否启用

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