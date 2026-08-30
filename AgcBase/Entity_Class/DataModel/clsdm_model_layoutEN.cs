
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsdm_model_layoutEN
 表名:dm_model_layout(00050663)
 * 版本:2026.08.01(服务器:WIN-SRV103-116)
 日期:2026/08/04 15:30:36
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
 /// 表dm_model_layout的关键字(model_id)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_model_id_dm_model_layout
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strmodel_id">表关键字</param>
public K_model_id_dm_model_layout(string strmodel_id)
{
if (IsValid(strmodel_id)) Value = strmodel_id;
else
{
Value = null;
}
}
private static bool IsValid(string strmodel_id)
{
if (string.IsNullOrEmpty(strmodel_id) == true) return false;
if (strmodel_id.Length > 32) return false;
if (strmodel_id.IndexOf(' ') >= 0) return false;
if (strmodel_id.IndexOf(')') >= 0) return false;
if (strmodel_id.IndexOf('(') >= 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_model_id_dm_model_layout]类型的对象</returns>
public static implicit operator K_model_id_dm_model_layout(string value)
{
return new K_model_id_dm_model_layout(value);
}
}
 /// <summary>
 /// 模型布局表(dm_model_layout)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsdm_model_layoutEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "dm_model_layout"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "model_id"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 14;
public static string[] _AttributeName = new string[] {"model_id", "model_name", "prj_id", "model_desc", "layout_data", "canvas_height", "canvas_width", "Status", "sort_no", "created_by", "created_time", "updated_by", "updated_time", "remark"};

protected string mstrmodel_id;    //模型ID
protected string mstrmodel_name;    //模型名称
protected string mstrprj_id;    //项目ID
protected string mstrmodel_desc;    //模型说明
protected string mstrlayout_data;    //布局数据
protected int? mintcanvas_height;    //画布高
protected int? mintcanvas_width;    //画布宽
protected string mstrStatus;    //Status
protected int? mintsort_no;    //排序号
protected string mstrcreated_by;    //创建人
protected DateTime mdtecreated_time;    //创建时间
protected string mstrupdated_by;    //更新人
protected DateTime mdteupdated_time;    //更新时间
protected string mstrremark;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsdm_model_layoutEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("model_id");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strmodel_id">关键字:模型ID</param>
public clsdm_model_layoutEN(string strmodel_id)
 {
strmodel_id = strmodel_id.Replace("'", "''");
if (strmodel_id.Length > 32)
{
throw new Exception("在表:dm_model_layout中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strmodel_id)  ==  true)
{
throw new Exception("在表:dm_model_layout中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strmodel_id);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrmodel_id = strmodel_id;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("model_id");
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
if (strAttributeName  ==  condm_model_layout.model_id)
{
return mstrmodel_id;
}
else if (strAttributeName  ==  condm_model_layout.model_name)
{
return mstrmodel_name;
}
else if (strAttributeName  ==  condm_model_layout.prj_id)
{
return mstrprj_id;
}
else if (strAttributeName  ==  condm_model_layout.model_desc)
{
return mstrmodel_desc;
}
else if (strAttributeName  ==  condm_model_layout.layout_data)
{
return mstrlayout_data;
}
else if (strAttributeName  ==  condm_model_layout.canvas_height)
{
return mintcanvas_height;
}
else if (strAttributeName  ==  condm_model_layout.canvas_width)
{
return mintcanvas_width;
}
else if (strAttributeName  ==  condm_model_layout.Status)
{
return mstrStatus;
}
else if (strAttributeName  ==  condm_model_layout.sort_no)
{
return mintsort_no;
}
else if (strAttributeName  ==  condm_model_layout.created_by)
{
return mstrcreated_by;
}
else if (strAttributeName  ==  condm_model_layout.created_time)
{
return mdtecreated_time;
}
else if (strAttributeName  ==  condm_model_layout.updated_by)
{
return mstrupdated_by;
}
else if (strAttributeName  ==  condm_model_layout.updated_time)
{
return mdteupdated_time;
}
else if (strAttributeName  ==  condm_model_layout.remark)
{
return mstrremark;
}
return null;
}
set
{
if (strAttributeName  ==  condm_model_layout.model_id)
{
mstrmodel_id = value.ToString();
 AddUpdatedFld(condm_model_layout.model_id);
}
else if (strAttributeName  ==  condm_model_layout.model_name)
{
mstrmodel_name = value.ToString();
 AddUpdatedFld(condm_model_layout.model_name);
}
else if (strAttributeName  ==  condm_model_layout.prj_id)
{
mstrprj_id = value.ToString();
 AddUpdatedFld(condm_model_layout.prj_id);
}
else if (strAttributeName  ==  condm_model_layout.model_desc)
{
mstrmodel_desc = value.ToString();
 AddUpdatedFld(condm_model_layout.model_desc);
}
else if (strAttributeName  ==  condm_model_layout.layout_data)
{
mstrlayout_data = value.ToString();
 AddUpdatedFld(condm_model_layout.layout_data);
}
else if (strAttributeName  ==  condm_model_layout.canvas_height)
{
mintcanvas_height = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_layout.canvas_height);
}
else if (strAttributeName  ==  condm_model_layout.canvas_width)
{
mintcanvas_width = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_layout.canvas_width);
}
else if (strAttributeName  ==  condm_model_layout.Status)
{
mstrStatus = value.ToString();
 AddUpdatedFld(condm_model_layout.Status);
}
else if (strAttributeName  ==  condm_model_layout.sort_no)
{
mintsort_no = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_layout.sort_no);
}
else if (strAttributeName  ==  condm_model_layout.created_by)
{
mstrcreated_by = value.ToString();
 AddUpdatedFld(condm_model_layout.created_by);
}
else if (strAttributeName  ==  condm_model_layout.created_time)
{
mdtecreated_time = TransNullToDate(value.ToString());
 AddUpdatedFld(condm_model_layout.created_time);
}
else if (strAttributeName  ==  condm_model_layout.updated_by)
{
mstrupdated_by = value.ToString();
 AddUpdatedFld(condm_model_layout.updated_by);
}
else if (strAttributeName  ==  condm_model_layout.updated_time)
{
mdteupdated_time = TransNullToDate(value.ToString());
 AddUpdatedFld(condm_model_layout.updated_time);
}
else if (strAttributeName  ==  condm_model_layout.remark)
{
mstrremark = value.ToString();
 AddUpdatedFld(condm_model_layout.remark);
}
}
}
public object this[int intIndex]
{
get
{
if (condm_model_layout.model_id  ==  _AttributeName[intIndex])
{
return mstrmodel_id;
}
else if (condm_model_layout.model_name  ==  _AttributeName[intIndex])
{
return mstrmodel_name;
}
else if (condm_model_layout.prj_id  ==  _AttributeName[intIndex])
{
return mstrprj_id;
}
else if (condm_model_layout.model_desc  ==  _AttributeName[intIndex])
{
return mstrmodel_desc;
}
else if (condm_model_layout.layout_data  ==  _AttributeName[intIndex])
{
return mstrlayout_data;
}
else if (condm_model_layout.canvas_height  ==  _AttributeName[intIndex])
{
return mintcanvas_height;
}
else if (condm_model_layout.canvas_width  ==  _AttributeName[intIndex])
{
return mintcanvas_width;
}
else if (condm_model_layout.Status  ==  _AttributeName[intIndex])
{
return mstrStatus;
}
else if (condm_model_layout.sort_no  ==  _AttributeName[intIndex])
{
return mintsort_no;
}
else if (condm_model_layout.created_by  ==  _AttributeName[intIndex])
{
return mstrcreated_by;
}
else if (condm_model_layout.created_time  ==  _AttributeName[intIndex])
{
return mdtecreated_time;
}
else if (condm_model_layout.updated_by  ==  _AttributeName[intIndex])
{
return mstrupdated_by;
}
else if (condm_model_layout.updated_time  ==  _AttributeName[intIndex])
{
return mdteupdated_time;
}
else if (condm_model_layout.remark  ==  _AttributeName[intIndex])
{
return mstrremark;
}
return null;
}
set
{
if (condm_model_layout.model_id  ==  _AttributeName[intIndex])
{
mstrmodel_id = value.ToString();
 AddUpdatedFld(condm_model_layout.model_id);
}
else if (condm_model_layout.model_name  ==  _AttributeName[intIndex])
{
mstrmodel_name = value.ToString();
 AddUpdatedFld(condm_model_layout.model_name);
}
else if (condm_model_layout.prj_id  ==  _AttributeName[intIndex])
{
mstrprj_id = value.ToString();
 AddUpdatedFld(condm_model_layout.prj_id);
}
else if (condm_model_layout.model_desc  ==  _AttributeName[intIndex])
{
mstrmodel_desc = value.ToString();
 AddUpdatedFld(condm_model_layout.model_desc);
}
else if (condm_model_layout.layout_data  ==  _AttributeName[intIndex])
{
mstrlayout_data = value.ToString();
 AddUpdatedFld(condm_model_layout.layout_data);
}
else if (condm_model_layout.canvas_height  ==  _AttributeName[intIndex])
{
mintcanvas_height = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_layout.canvas_height);
}
else if (condm_model_layout.canvas_width  ==  _AttributeName[intIndex])
{
mintcanvas_width = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_layout.canvas_width);
}
else if (condm_model_layout.Status  ==  _AttributeName[intIndex])
{
mstrStatus = value.ToString();
 AddUpdatedFld(condm_model_layout.Status);
}
else if (condm_model_layout.sort_no  ==  _AttributeName[intIndex])
{
mintsort_no = TransNullToInt(value.ToString());
 AddUpdatedFld(condm_model_layout.sort_no);
}
else if (condm_model_layout.created_by  ==  _AttributeName[intIndex])
{
mstrcreated_by = value.ToString();
 AddUpdatedFld(condm_model_layout.created_by);
}
else if (condm_model_layout.created_time  ==  _AttributeName[intIndex])
{
mdtecreated_time = TransNullToDate(value.ToString());
 AddUpdatedFld(condm_model_layout.created_time);
}
else if (condm_model_layout.updated_by  ==  _AttributeName[intIndex])
{
mstrupdated_by = value.ToString();
 AddUpdatedFld(condm_model_layout.updated_by);
}
else if (condm_model_layout.updated_time  ==  _AttributeName[intIndex])
{
mdteupdated_time = TransNullToDate(value.ToString());
 AddUpdatedFld(condm_model_layout.updated_time);
}
else if (condm_model_layout.remark  ==  _AttributeName[intIndex])
{
mstrremark = value.ToString();
 AddUpdatedFld(condm_model_layout.remark);
}
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
 AddUpdatedFld(condm_model_layout.model_id);
}
}
/// <summary>
/// 模型名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string model_name
{
get
{
return mstrmodel_name;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrmodel_name = value;
}
else
{
 mstrmodel_name = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_layout.model_name);
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
 AddUpdatedFld(condm_model_layout.prj_id);
}
}
/// <summary>
/// 模型说明(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string model_desc
{
get
{
return mstrmodel_desc;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrmodel_desc = value;
}
else
{
 mstrmodel_desc = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_layout.model_desc);
}
}
/// <summary>
/// 布局数据(说明:;字段类型:varchar;字段长度:4000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string layout_data
{
get
{
return mstrlayout_data;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrlayout_data = value;
}
else
{
 mstrlayout_data = value;
}
//记录修改过的字段
 AddUpdatedFld(condm_model_layout.layout_data);
}
}
/// <summary>
/// 画布高(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? canvas_height
{
get
{
return mintcanvas_height;
}
set
{
 mintcanvas_height = value;
//记录修改过的字段
 AddUpdatedFld(condm_model_layout.canvas_height);
}
}
/// <summary>
/// 画布宽(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? canvas_width
{
get
{
return mintcanvas_width;
}
set
{
 mintcanvas_width = value;
//记录修改过的字段
 AddUpdatedFld(condm_model_layout.canvas_width);
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
 AddUpdatedFld(condm_model_layout.Status);
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
 AddUpdatedFld(condm_model_layout.sort_no);
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
 AddUpdatedFld(condm_model_layout.created_by);
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
 AddUpdatedFld(condm_model_layout.created_time);
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
 AddUpdatedFld(condm_model_layout.updated_by);
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
 AddUpdatedFld(condm_model_layout.updated_time);
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
 AddUpdatedFld(condm_model_layout.remark);
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
  return mstrmodel_id;
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
  return mstrmodel_name;
 }
 }
}
 /// <summary>
 /// 模型布局表(dm_model_layout)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class condm_model_layout
{
public const string _CurrTabName = "dm_model_layout"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "model_id"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"model_id", "model_name", "prj_id", "model_desc", "layout_data", "canvas_height", "canvas_width", "Status", "sort_no", "created_by", "created_time", "updated_by", "updated_time", "remark"};
//以下是属性变量


 /// <summary>
 /// 常量:"model_id"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string model_id = "model_id";    //模型ID

 /// <summary>
 /// 常量:"model_name"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string model_name = "model_name";    //模型名称

 /// <summary>
 /// 常量:"prj_id"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string prj_id = "prj_id";    //项目ID

 /// <summary>
 /// 常量:"model_desc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string model_desc = "model_desc";    //模型说明

 /// <summary>
 /// 常量:"layout_data"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string layout_data = "layout_data";    //布局数据

 /// <summary>
 /// 常量:"canvas_height"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string canvas_height = "canvas_height";    //画布高

 /// <summary>
 /// 常量:"canvas_width"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string canvas_width = "canvas_width";    //画布宽

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