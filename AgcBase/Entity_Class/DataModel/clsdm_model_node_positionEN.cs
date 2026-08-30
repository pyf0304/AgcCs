
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsdm_model_node_positionEN
 表名:dm_model_node_position(00050664)
 * 版本:2026.08.01(服务器:WIN-SRV103-116)
 日期:2026/08/05 11:15:57
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
 /// 表dm_model_node_position的关键字(id)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_id_dm_model_node_position
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strid">表关键字</param>
public K_id_dm_model_node_position(string strid)
{
if (IsValid(strid)) Value = strid;
else
{
Value = null;
}
}
private static bool IsValid(string strid)
{
if (string.IsNullOrEmpty(strid) == true) return false;
if (strid.Length > 32) return false;
if (strid.IndexOf(' ') >= 0) return false;
if (strid.IndexOf(')') >= 0) return false;
if (strid.IndexOf('(') >= 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_id_dm_model_node_position]类型的对象</returns>
public static implicit operator K_id_dm_model_node_position(string value)
{
return new K_id_dm_model_node_position(value);
}
}
 /// <summary>
 /// 模型节点位置表(dm_model_node_position)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsdm_model_node_positionEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "dm_model_node_position"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "id"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 12;
public static string[] _AttributeName = new string[] {"id", "diagram_id", "view_type_code", "model_id", "node_id", "node_label", "x_pos", "y_pos", "created_by", "created_time", "updated_by", "updated_time"};

protected string mstrid;    //主键ID
protected string mstrdiagram_id;    //图ID
protected string mstrview_type_code;    //视图类型编码
protected string mstrmodel_id;    //模型ID
protected string mstrnode_id;    //节点ID
protected string mstrnode_label;    //节点名称
protected double? mdblx_pos;    //X坐标
protected double? mdbly_pos;    //Y坐标
protected string mstrcreated_by;    //创建人
protected DateTime mdtecreated_time;    //创建时间
protected string mstrupdated_by;    //更新人
protected DateTime mdteupdated_time;    //更新时间

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsdm_model_node_positionEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("id");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strid">关键字:主键ID</param>
public clsdm_model_node_positionEN(string strid)
 {
strid = strid.Replace("'", "''");
if (strid.Length > 32)
{
throw new Exception("在表:dm_model_node_position中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strid)  ==  true)
{
throw new Exception("在表:dm_model_node_position中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strid);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrid = strid;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("id");
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
if (strAttributeName  ==  condm_model_node_position.id)
{
return mstrid;
}
else if (strAttributeName  ==  condm_model_node_position.diagram_id)
{
return mstrdiagram_id;
}
else if (strAttributeName  ==  condm_model_node_position.view_type_code)
{
return mstrview_type_code;
}
else if (strAttributeName  ==  condm_model_node_position.model_id)
{
return mstrmodel_id;
}
else if (strAttributeName  ==  condm_model_node_position.node_id)
{
return mstrnode_id;
}
else if (strAttributeName  ==  condm_model_node_position.node_label)
{
return mstrnode_label;
}
else if (strAttributeName  ==  condm_model_node_position.x_pos)
{
return mdblx_pos;
}
else if (strAttributeName  ==  condm_model_node_position.y_pos)
{
return mdbly_pos;
}
else if (strAttributeName  ==  condm_model_node_position.created_by)
{
return mstrcreated_by;
}
else if (strAttributeName  ==  condm_model_node_position.created_time)
{
return mdtecreated_time;
}
else if (strAttributeName  ==  condm_model_node_position.updated_by)
{
return mstrupdated_by;
}
else if (strAttributeName  ==  condm_model_node_position.updated_time)
{
return mdteupdated_time;
}
return null;
}
set
{
if (strAttributeName  ==  condm_model_node_position.id)
{
mstrid = value.ToString();
 AddUpdatedFld(condm_model_node_position.id);
}
else if (strAttributeName  ==  condm_model_node_position.diagram_id)
{
mstrdiagram_id = value.ToString();
 AddUpdatedFld(condm_model_node_position.diagram_id);
}
else if (strAttributeName  ==  condm_model_node_position.view_type_code)
{
mstrview_type_code = value.ToString();
 AddUpdatedFld(condm_model_node_position.view_type_code);
}
else if (strAttributeName  ==  condm_model_node_position.model_id)
{
mstrmodel_id = value.ToString();
 AddUpdatedFld(condm_model_node_position.model_id);
}
else if (strAttributeName  ==  condm_model_node_position.node_id)
{
mstrnode_id = value.ToString();
 AddUpdatedFld(condm_model_node_position.node_id);
}
else if (strAttributeName  ==  condm_model_node_position.node_label)
{
mstrnode_label = value.ToString();
 AddUpdatedFld(condm_model_node_position.node_label);
}
else if (strAttributeName  ==  condm_model_node_position.x_pos)
{
mdblx_pos = TransNullToDouble(value.ToString());
 AddUpdatedFld(condm_model_node_position.x_pos);
}
else if (strAttributeName  ==  condm_model_node_position.y_pos)
{
mdbly_pos = TransNullToDouble(value.ToString());
 AddUpdatedFld(condm_model_node_position.y_pos);
}
else if (strAttributeName  ==  condm_model_node_position.created_by)
{
mstrcreated_by = value.ToString();
 AddUpdatedFld(condm_model_node_position.created_by);
}
else if (strAttributeName  ==  condm_model_node_position.created_time)
{
mdtecreated_time = TransNullToDate(value.ToString());
 AddUpdatedFld(condm_model_node_position.created_time);
}
else if (strAttributeName  ==  condm_model_node_position.updated_by)
{
mstrupdated_by = value.ToString();
 AddUpdatedFld(condm_model_node_position.updated_by);
}
else if (strAttributeName  ==  condm_model_node_position.updated_time)
{
mdteupdated_time = TransNullToDate(value.ToString());
 AddUpdatedFld(condm_model_node_position.updated_time);
}
}
}
public object this[int intIndex]
{
get
{
if (condm_model_node_position.id  ==  _AttributeName[intIndex])
{
return mstrid;
}
else if (condm_model_node_position.diagram_id  ==  _AttributeName[intIndex])
{
return mstrdiagram_id;
}
else if (condm_model_node_position.view_type_code  ==  _AttributeName[intIndex])
{
return mstrview_type_code;
}
else if (condm_model_node_position.model_id  ==  _AttributeName[intIndex])
{
return mstrmodel_id;
}
else if (condm_model_node_position.node_id  ==  _AttributeName[intIndex])
{
return mstrnode_id;
}
else if (condm_model_node_position.node_label  ==  _AttributeName[intIndex])
{
return mstrnode_label;
}
else if (condm_model_node_position.x_pos  ==  _AttributeName[intIndex])
{
return mdblx_pos;
}
else if (condm_model_node_position.y_pos  ==  _AttributeName[intIndex])
{
return mdbly_pos;
}
else if (condm_model_node_position.created_by  ==  _AttributeName[intIndex])
{
return mstrcreated_by;
}
else if (condm_model_node_position.created_time  ==  _AttributeName[intIndex])
{
return mdtecreated_time;
}
else if (condm_model_node_position.updated_by  ==  _AttributeName[intIndex])
{
return mstrupdated_by;
}
else if (condm_model_node_position.updated_time  ==  _AttributeName[intIndex])
{
return mdteupdated_time;
}
return null;
}
set
{
if (condm_model_node_position.id  ==  _AttributeName[intIndex])
{
mstrid = value.ToString();
 AddUpdatedFld(condm_model_node_position.id);
}
else if (condm_model_node_position.diagram_id  ==  _AttributeName[intIndex])
{
mstrdiagram_id = value.ToString();
 AddUpdatedFld(condm_model_node_position.diagram_id);
}
else if (condm_model_node_position.view_type_code  ==  _AttributeName[intIndex])
{
mstrview_type_code = value.ToString();
 AddUpdatedFld(condm_model_node_position.view_type_code);
}
else if (condm_model_node_position.model_id  ==  _AttributeName[intIndex])
{
mstrmodel_id = value.ToString();
 AddUpdatedFld(condm_model_node_position.model_id);
}
else if (condm_model_node_position.node_id  ==  _AttributeName[intIndex])
{
mstrnode_id = value.ToString();
 AddUpdatedFld(condm_model_node_position.node_id);
}
else if (condm_model_node_position.node_label  ==  _AttributeName[intIndex])
{
mstrnode_label = value.ToString();
 AddUpdatedFld(condm_model_node_position.node_label);
}
else if (condm_model_node_position.x_pos  ==  _AttributeName[intIndex])
{
mdblx_pos = TransNullToDouble(value.ToString());
 AddUpdatedFld(condm_model_node_position.x_pos);
}
else if (condm_model_node_position.y_pos  ==  _AttributeName[intIndex])
{
mdbly_pos = TransNullToDouble(value.ToString());
 AddUpdatedFld(condm_model_node_position.y_pos);
}
else if (condm_model_node_position.created_by  ==  _AttributeName[intIndex])
{
mstrcreated_by = value.ToString();
 AddUpdatedFld(condm_model_node_position.created_by);
}
else if (condm_model_node_position.created_time  ==  _AttributeName[intIndex])
{
mdtecreated_time = TransNullToDate(value.ToString());
 AddUpdatedFld(condm_model_node_position.created_time);
}
else if (condm_model_node_position.updated_by  ==  _AttributeName[intIndex])
{
mstrupdated_by = value.ToString();
 AddUpdatedFld(condm_model_node_position.updated_by);
}
else if (condm_model_node_position.updated_time  ==  _AttributeName[intIndex])
{
mdteupdated_time = TransNullToDate(value.ToString());
 AddUpdatedFld(condm_model_node_position.updated_time);
}
}
}

/// <summary>
/// 主键ID(说明:;字段类型:varchar;字段长度:32;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string id
{
get
{
return mstrid;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrid = value;
}
else
{
 mstrid = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_node_position.id);
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
 AddUpdatedFld(condm_model_node_position.diagram_id);
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
 AddUpdatedFld(condm_model_node_position.view_type_code);
}
}
/// <summary>
/// 模型ID(说明:;字段类型:varchar;字段长度:32;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string model_id
{
get
{
return mstrmodel_id;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrmodel_id = value;
}
else
{
 mstrmodel_id = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_node_position.model_id);
}
}
/// <summary>
/// 节点ID(说明:;字段类型:varchar;字段长度:64;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string node_id
{
get
{
return mstrnode_id;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrnode_id = value;
}
else
{
 mstrnode_id = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_node_position.node_id);
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
 AddUpdatedFld(condm_model_node_position.node_label);
}
}
/// <summary>
/// X坐标(说明:;字段类型:decimal;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double? x_pos
{
get
{
return mdblx_pos;
}
set
{
 mdblx_pos = value;
//记录修改过的字段
 AddUpdatedFld(condm_model_node_position.x_pos);
}
}
/// <summary>
/// Y坐标(说明:;字段类型:decimal;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double? y_pos
{
get
{
return mdbly_pos;
}
set
{
 mdbly_pos = value;
//记录修改过的字段
 AddUpdatedFld(condm_model_node_position.y_pos);
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
 AddUpdatedFld(condm_model_node_position.created_by);
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
 AddUpdatedFld(condm_model_node_position.created_time);
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
 AddUpdatedFld(condm_model_node_position.updated_by);
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
 AddUpdatedFld(condm_model_node_position.updated_time);
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
  return mstrid;
 }
 }
}
 /// <summary>
 /// 模型节点位置表(dm_model_node_position)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class condm_model_node_position
{
public const string _CurrTabName = "dm_model_node_position"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "id"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"id", "diagram_id", "view_type_code", "model_id", "node_id", "node_label", "x_pos", "y_pos", "created_by", "created_time", "updated_by", "updated_time"};
//以下是属性变量


 /// <summary>
 /// 常量:"id"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string id = "id";    //主键ID

 /// <summary>
 /// 常量:"diagram_id"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string diagram_id = "diagram_id";    //图ID

 /// <summary>
 /// 常量:"view_type_code"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string view_type_code = "view_type_code";    //视图类型编码

 /// <summary>
 /// 常量:"model_id"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string model_id = "model_id";    //模型ID

 /// <summary>
 /// 常量:"node_id"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string node_id = "node_id";    //节点ID

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
}

}