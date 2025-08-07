
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscss_ControlEN
 表名:css_Control(00050467)
 * 版本:2023.05.26.1(服务器:PYF-THINKPAD)
 日期:2023/05/27 06:47:39
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcMvc(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:样式表管理(CssManage)
 框架-层名:实体层(CS)(EntityLayer)
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

namespace AGC.Entity
{
 /// <summary>
 /// 表css_Control的关键字(ControlId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ControlId_css_Control
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strControlId">表关键字</param>
public K_ControlId_css_Control(string strControlId)
{
if (IsValid(strControlId)) Value = strControlId;
else
{
Value = null;
}
}
private static bool IsValid(string strControlId)
{
if (string.IsNullOrEmpty(strControlId) == true) return false;
if (strControlId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ControlId_css_Control]类型的对象</returns>
public static implicit operator K_ControlId_css_Control(string value)
{
return new K_ControlId_css_Control(value);
}
}
 /// <summary>
 /// 控件(css_Control)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clscss_ControlEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接，如果为空就使用系统默认的连接
public new const string _CurrTabName = "css_Control"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ControlId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string WhereFormat = ""; //条件格式串
protected const int mintAttributeCount = 8;
public static string[] AttributeName = new string[] {"ControlId", "ControlName", "ControlENName", "IsDeleted", "DeletedDate", "UpdDate", "UpdUser", "Memo"};

protected string mstrControlId;    //控件ID
protected string mstrControlName;    //控件名称
protected string mstrControlENName;    //控件英文名
protected bool mbolIsDeleted;    //是否删除
protected string mstrDeletedDate;    //删除日期
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clscss_ControlEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "css_Control";
 lstKeyFldNames.Add("ControlId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strControlId">关键字:控件ID</param>
public clscss_ControlEN(string strControlId)
 {
strControlId = strControlId.Replace("'", "''");
if (strControlId.Length > 8)
{
throw new Exception("在表:css_Control中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strControlId)  ==  true)
{
throw new Exception("在表:css_Control中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strControlId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrControlId = strControlId;
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "css_Control";
 lstKeyFldNames.Add("ControlId");
 }

public static int AttributeCount
{
get
{
return mintAttributeCount;
}
}
public override object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  concss_Control.ControlId)
{
return mstrControlId;
}
else if (strAttributeName  ==  concss_Control.ControlName)
{
return mstrControlName;
}
else if (strAttributeName  ==  concss_Control.ControlENName)
{
return mstrControlENName;
}
else if (strAttributeName  ==  concss_Control.IsDeleted)
{
return mbolIsDeleted;
}
else if (strAttributeName  ==  concss_Control.DeletedDate)
{
return mstrDeletedDate;
}
else if (strAttributeName  ==  concss_Control.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  concss_Control.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  concss_Control.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  concss_Control.ControlId)
{
mstrControlId = value.ToString();
 AddUpdatedFld(concss_Control.ControlId);
}
else if (strAttributeName  ==  concss_Control.ControlName)
{
mstrControlName = value.ToString();
 AddUpdatedFld(concss_Control.ControlName);
}
else if (strAttributeName  ==  concss_Control.ControlENName)
{
mstrControlENName = value.ToString();
 AddUpdatedFld(concss_Control.ControlENName);
}
else if (strAttributeName  ==  concss_Control.IsDeleted)
{
mbolIsDeleted = TransNullToBool(value.ToString());
 AddUpdatedFld(concss_Control.IsDeleted);
}
else if (strAttributeName  ==  concss_Control.DeletedDate)
{
mstrDeletedDate = value.ToString();
 AddUpdatedFld(concss_Control.DeletedDate);
}
else if (strAttributeName  ==  concss_Control.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concss_Control.UpdDate);
}
else if (strAttributeName  ==  concss_Control.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(concss_Control.UpdUser);
}
else if (strAttributeName  ==  concss_Control.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(concss_Control.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (concss_Control.ControlId  ==  AttributeName[intIndex])
{
return mstrControlId;
}
else if (concss_Control.ControlName  ==  AttributeName[intIndex])
{
return mstrControlName;
}
else if (concss_Control.ControlENName  ==  AttributeName[intIndex])
{
return mstrControlENName;
}
else if (concss_Control.IsDeleted  ==  AttributeName[intIndex])
{
return mbolIsDeleted;
}
else if (concss_Control.DeletedDate  ==  AttributeName[intIndex])
{
return mstrDeletedDate;
}
else if (concss_Control.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (concss_Control.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (concss_Control.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (concss_Control.ControlId  ==  AttributeName[intIndex])
{
mstrControlId = value.ToString();
 AddUpdatedFld(concss_Control.ControlId);
}
else if (concss_Control.ControlName  ==  AttributeName[intIndex])
{
mstrControlName = value.ToString();
 AddUpdatedFld(concss_Control.ControlName);
}
else if (concss_Control.ControlENName  ==  AttributeName[intIndex])
{
mstrControlENName = value.ToString();
 AddUpdatedFld(concss_Control.ControlENName);
}
else if (concss_Control.IsDeleted  ==  AttributeName[intIndex])
{
mbolIsDeleted = TransNullToBool(value.ToString());
 AddUpdatedFld(concss_Control.IsDeleted);
}
else if (concss_Control.DeletedDate  ==  AttributeName[intIndex])
{
mstrDeletedDate = value.ToString();
 AddUpdatedFld(concss_Control.DeletedDate);
}
else if (concss_Control.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concss_Control.UpdDate);
}
else if (concss_Control.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(concss_Control.UpdUser);
}
else if (concss_Control.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(concss_Control.Memo);
}
}
}

/// <summary>
/// 控件ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ControlId
{
get
{
return mstrControlId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrControlId = value;
}
else
{
 mstrControlId = value;
}
//记录修改过的字段
 AddUpdatedFld(concss_Control.ControlId);
}
}
/// <summary>
/// 控件名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ControlName
{
get
{
return mstrControlName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrControlName = value;
}
else
{
 mstrControlName = value;
}
//记录修改过的字段
 AddUpdatedFld(concss_Control.ControlName);
}
}
/// <summary>
/// 控件英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ControlENName
{
get
{
return mstrControlENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrControlENName = value;
}
else
{
 mstrControlENName = value;
}
//记录修改过的字段
 AddUpdatedFld(concss_Control.ControlENName);
}
}
/// <summary>
/// 是否删除(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsDeleted
{
get
{
return mbolIsDeleted;
}
set
{
 mbolIsDeleted = value;
//记录修改过的字段
 AddUpdatedFld(concss_Control.IsDeleted);
}
}
/// <summary>
/// 删除日期(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DeletedDate
{
get
{
return mstrDeletedDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDeletedDate = value;
}
else
{
 mstrDeletedDate = value;
}
//记录修改过的字段
 AddUpdatedFld(concss_Control.DeletedDate);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdDate
{
get
{
return mstrUpdDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdDate = value;
}
else
{
 mstrUpdDate = value;
}
//记录修改过的字段
 AddUpdatedFld(concss_Control.UpdDate);
}
}
/// <summary>
/// 修改者(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUser
{
get
{
return mstrUpdUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUser = value;
}
else
{
 mstrUpdUser = value;
}
//记录修改过的字段
 AddUpdatedFld(concss_Control.UpdUser);
}
}
/// <summary>
/// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Memo
{
get
{
return mstrMemo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMemo = value;
}
else
{
 mstrMemo = value;
}
//记录修改过的字段
 AddUpdatedFld(concss_Control.Memo);
}
}

/// <summary>
/// 获取关键字Id(keyId)
 /// (AutoGCLib.clsGeneCodeBase:GenGetKeyId)
/// </summary>
 public override string _KeyId
 {
 get
 {
  return mstrControlId;
 }
 }

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrControlName;
 }
 }
}
 /// <summary>
 /// 控件(css_Control)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class concss_Control
{
public new const string _CurrTabName = "css_Control"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ControlId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ControlId", "ControlName", "ControlENName", "IsDeleted", "DeletedDate", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"ControlId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ControlId = "ControlId";    //控件ID

 /// <summary>
 /// 常量:"ControlName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ControlName = "ControlName";    //控件名称

 /// <summary>
 /// 常量:"ControlENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ControlENName = "ControlENName";    //控件英文名

 /// <summary>
 /// 常量:"IsDeleted"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDeleted = "IsDeleted";    //是否删除

 /// <summary>
 /// 常量:"DeletedDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DeletedDate = "DeletedDate";    //删除日期

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改者

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}