
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFieldTab2EN
 表名:vFieldTab2(00050120)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:12:14
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
 /// 表vFieldTab2的关键字(FldId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_FldId_vFieldTab2
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strFldId">表关键字</param>
public K_FldId_vFieldTab2(string strFldId)
{
if (IsValid(strFldId)) Value = strFldId;
else
{
Value = null;
}
}
private static bool IsValid(string strFldId)
{
if (string.IsNullOrEmpty(strFldId) == true) return false;
if (strFldId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_FldId_vFieldTab2]类型的对象</returns>
public static implicit operator K_FldId_vFieldTab2(string value)
{
return new K_FldId_vFieldTab2(value);
}
}
 /// <summary>
 /// vFieldTab2(vFieldTab2)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvFieldTab2EN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vFieldTab2"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "FldId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 24;
public static string[] _AttributeName = new string[] {"DataTypeName", "FldId", "PrjId", "PrjName", "FldName", "Caption", "FldLength", "FldInfo", "IsNull", "IsPrimaryKey", "IsIdentity", "IsChecked", "IsOnlyOne", "MaxValue", "MinValue", "DefaultValue", "IsNeedTransCode", "AppliedScope", "CodeTabId", "CodeTabNameId", "CodeTabCodeId", "UpdDate", "UpdUser", "UserName"};

protected string mstrDataTypeName;    //数据类型名称
protected string mstrFldId;    //字段Id
protected string mstrPrjId;    //工程Id
protected string mstrPrjName;    //工程名称
protected string mstrFldName;    //字段名
protected string mstrCaption;    //标题
protected int mintFldLength;    //字段长度
protected string mstrFldInfo;    //字段信息
protected bool mbolIsNull;    //是否可空
protected bool mbolIsPrimaryKey;    //是否主键
protected bool mbolIsIdentity;    //是否Identity
protected bool mbolIsChecked;    //是否核实
protected bool mbolIsOnlyOne;    //是否唯一
protected string mstrMaxValue;    //最大值
protected string mstrMinValue;    //最小值
protected string mstrDefaultValue;    //缺省值
protected bool mbolIsNeedTransCode;    //是否需要转换代码
protected string mstrAppliedScope;    //应用范围
protected string mstrCodeTabId;    //代码表Id
protected string mstrCodeTabNameId;    //代码_名Id
protected string mstrCodeTabCodeId;    //代码Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrUserName;    //用户名

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvFieldTab2EN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FldId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strFldId">关键字:字段Id</param>
public clsvFieldTab2EN(string strFldId)
 {
strFldId = strFldId.Replace("'", "''");
if (strFldId.Length > 8)
{
throw new Exception("在表:vFieldTab2中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strFldId)  ==  true)
{
throw new Exception("在表:vFieldTab2中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFldId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrFldId = strFldId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FldId");
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
if (strAttributeName  ==  convFieldTab2.DataTypeName)
{
return mstrDataTypeName;
}
else if (strAttributeName  ==  convFieldTab2.FldId)
{
return mstrFldId;
}
else if (strAttributeName  ==  convFieldTab2.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convFieldTab2.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convFieldTab2.FldName)
{
return mstrFldName;
}
else if (strAttributeName  ==  convFieldTab2.Caption)
{
return mstrCaption;
}
else if (strAttributeName  ==  convFieldTab2.FldLength)
{
return mintFldLength;
}
else if (strAttributeName  ==  convFieldTab2.FldInfo)
{
return mstrFldInfo;
}
else if (strAttributeName  ==  convFieldTab2.IsNull)
{
return mbolIsNull;
}
else if (strAttributeName  ==  convFieldTab2.IsPrimaryKey)
{
return mbolIsPrimaryKey;
}
else if (strAttributeName  ==  convFieldTab2.IsIdentity)
{
return mbolIsIdentity;
}
else if (strAttributeName  ==  convFieldTab2.IsChecked)
{
return mbolIsChecked;
}
else if (strAttributeName  ==  convFieldTab2.IsOnlyOne)
{
return mbolIsOnlyOne;
}
else if (strAttributeName  ==  convFieldTab2.MaxValue)
{
return mstrMaxValue;
}
else if (strAttributeName  ==  convFieldTab2.MinValue)
{
return mstrMinValue;
}
else if (strAttributeName  ==  convFieldTab2.DefaultValue)
{
return mstrDefaultValue;
}
else if (strAttributeName  ==  convFieldTab2.IsNeedTransCode)
{
return mbolIsNeedTransCode;
}
else if (strAttributeName  ==  convFieldTab2.AppliedScope)
{
return mstrAppliedScope;
}
else if (strAttributeName  ==  convFieldTab2.CodeTabId)
{
return mstrCodeTabId;
}
else if (strAttributeName  ==  convFieldTab2.CodeTabNameId)
{
return mstrCodeTabNameId;
}
else if (strAttributeName  ==  convFieldTab2.CodeTabCodeId)
{
return mstrCodeTabCodeId;
}
else if (strAttributeName  ==  convFieldTab2.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convFieldTab2.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convFieldTab2.UserName)
{
return mstrUserName;
}
return null;
}
set
{
if (strAttributeName  ==  convFieldTab2.DataTypeName)
{
mstrDataTypeName = value.ToString();
 AddUpdatedFld(convFieldTab2.DataTypeName);
}
else if (strAttributeName  ==  convFieldTab2.FldId)
{
mstrFldId = value.ToString();
 AddUpdatedFld(convFieldTab2.FldId);
}
else if (strAttributeName  ==  convFieldTab2.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convFieldTab2.PrjId);
}
else if (strAttributeName  ==  convFieldTab2.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convFieldTab2.PrjName);
}
else if (strAttributeName  ==  convFieldTab2.FldName)
{
mstrFldName = value.ToString();
 AddUpdatedFld(convFieldTab2.FldName);
}
else if (strAttributeName  ==  convFieldTab2.Caption)
{
mstrCaption = value.ToString();
 AddUpdatedFld(convFieldTab2.Caption);
}
else if (strAttributeName  ==  convFieldTab2.FldLength)
{
mintFldLength = TransNullToInt(value.ToString());
 AddUpdatedFld(convFieldTab2.FldLength);
}
else if (strAttributeName  ==  convFieldTab2.FldInfo)
{
mstrFldInfo = value.ToString();
 AddUpdatedFld(convFieldTab2.FldInfo);
}
else if (strAttributeName  ==  convFieldTab2.IsNull)
{
mbolIsNull = TransNullToBool(value.ToString());
 AddUpdatedFld(convFieldTab2.IsNull);
}
else if (strAttributeName  ==  convFieldTab2.IsPrimaryKey)
{
mbolIsPrimaryKey = TransNullToBool(value.ToString());
 AddUpdatedFld(convFieldTab2.IsPrimaryKey);
}
else if (strAttributeName  ==  convFieldTab2.IsIdentity)
{
mbolIsIdentity = TransNullToBool(value.ToString());
 AddUpdatedFld(convFieldTab2.IsIdentity);
}
else if (strAttributeName  ==  convFieldTab2.IsChecked)
{
mbolIsChecked = TransNullToBool(value.ToString());
 AddUpdatedFld(convFieldTab2.IsChecked);
}
else if (strAttributeName  ==  convFieldTab2.IsOnlyOne)
{
mbolIsOnlyOne = TransNullToBool(value.ToString());
 AddUpdatedFld(convFieldTab2.IsOnlyOne);
}
else if (strAttributeName  ==  convFieldTab2.MaxValue)
{
mstrMaxValue = value.ToString();
 AddUpdatedFld(convFieldTab2.MaxValue);
}
else if (strAttributeName  ==  convFieldTab2.MinValue)
{
mstrMinValue = value.ToString();
 AddUpdatedFld(convFieldTab2.MinValue);
}
else if (strAttributeName  ==  convFieldTab2.DefaultValue)
{
mstrDefaultValue = value.ToString();
 AddUpdatedFld(convFieldTab2.DefaultValue);
}
else if (strAttributeName  ==  convFieldTab2.IsNeedTransCode)
{
mbolIsNeedTransCode = TransNullToBool(value.ToString());
 AddUpdatedFld(convFieldTab2.IsNeedTransCode);
}
else if (strAttributeName  ==  convFieldTab2.AppliedScope)
{
mstrAppliedScope = value.ToString();
 AddUpdatedFld(convFieldTab2.AppliedScope);
}
else if (strAttributeName  ==  convFieldTab2.CodeTabId)
{
mstrCodeTabId = value.ToString();
 AddUpdatedFld(convFieldTab2.CodeTabId);
}
else if (strAttributeName  ==  convFieldTab2.CodeTabNameId)
{
mstrCodeTabNameId = value.ToString();
 AddUpdatedFld(convFieldTab2.CodeTabNameId);
}
else if (strAttributeName  ==  convFieldTab2.CodeTabCodeId)
{
mstrCodeTabCodeId = value.ToString();
 AddUpdatedFld(convFieldTab2.CodeTabCodeId);
}
else if (strAttributeName  ==  convFieldTab2.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFieldTab2.UpdDate);
}
else if (strAttributeName  ==  convFieldTab2.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFieldTab2.UpdUser);
}
else if (strAttributeName  ==  convFieldTab2.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convFieldTab2.UserName);
}
}
}
public object this[int intIndex]
{
get
{
if (convFieldTab2.DataTypeName  ==  _AttributeName[intIndex])
{
return mstrDataTypeName;
}
else if (convFieldTab2.FldId  ==  _AttributeName[intIndex])
{
return mstrFldId;
}
else if (convFieldTab2.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convFieldTab2.PrjName  ==  _AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convFieldTab2.FldName  ==  _AttributeName[intIndex])
{
return mstrFldName;
}
else if (convFieldTab2.Caption  ==  _AttributeName[intIndex])
{
return mstrCaption;
}
else if (convFieldTab2.FldLength  ==  _AttributeName[intIndex])
{
return mintFldLength;
}
else if (convFieldTab2.FldInfo  ==  _AttributeName[intIndex])
{
return mstrFldInfo;
}
else if (convFieldTab2.IsNull  ==  _AttributeName[intIndex])
{
return mbolIsNull;
}
else if (convFieldTab2.IsPrimaryKey  ==  _AttributeName[intIndex])
{
return mbolIsPrimaryKey;
}
else if (convFieldTab2.IsIdentity  ==  _AttributeName[intIndex])
{
return mbolIsIdentity;
}
else if (convFieldTab2.IsChecked  ==  _AttributeName[intIndex])
{
return mbolIsChecked;
}
else if (convFieldTab2.IsOnlyOne  ==  _AttributeName[intIndex])
{
return mbolIsOnlyOne;
}
else if (convFieldTab2.MaxValue  ==  _AttributeName[intIndex])
{
return mstrMaxValue;
}
else if (convFieldTab2.MinValue  ==  _AttributeName[intIndex])
{
return mstrMinValue;
}
else if (convFieldTab2.DefaultValue  ==  _AttributeName[intIndex])
{
return mstrDefaultValue;
}
else if (convFieldTab2.IsNeedTransCode  ==  _AttributeName[intIndex])
{
return mbolIsNeedTransCode;
}
else if (convFieldTab2.AppliedScope  ==  _AttributeName[intIndex])
{
return mstrAppliedScope;
}
else if (convFieldTab2.CodeTabId  ==  _AttributeName[intIndex])
{
return mstrCodeTabId;
}
else if (convFieldTab2.CodeTabNameId  ==  _AttributeName[intIndex])
{
return mstrCodeTabNameId;
}
else if (convFieldTab2.CodeTabCodeId  ==  _AttributeName[intIndex])
{
return mstrCodeTabCodeId;
}
else if (convFieldTab2.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convFieldTab2.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convFieldTab2.UserName  ==  _AttributeName[intIndex])
{
return mstrUserName;
}
return null;
}
set
{
if (convFieldTab2.DataTypeName  ==  _AttributeName[intIndex])
{
mstrDataTypeName = value.ToString();
 AddUpdatedFld(convFieldTab2.DataTypeName);
}
else if (convFieldTab2.FldId  ==  _AttributeName[intIndex])
{
mstrFldId = value.ToString();
 AddUpdatedFld(convFieldTab2.FldId);
}
else if (convFieldTab2.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convFieldTab2.PrjId);
}
else if (convFieldTab2.PrjName  ==  _AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convFieldTab2.PrjName);
}
else if (convFieldTab2.FldName  ==  _AttributeName[intIndex])
{
mstrFldName = value.ToString();
 AddUpdatedFld(convFieldTab2.FldName);
}
else if (convFieldTab2.Caption  ==  _AttributeName[intIndex])
{
mstrCaption = value.ToString();
 AddUpdatedFld(convFieldTab2.Caption);
}
else if (convFieldTab2.FldLength  ==  _AttributeName[intIndex])
{
mintFldLength = TransNullToInt(value.ToString());
 AddUpdatedFld(convFieldTab2.FldLength);
}
else if (convFieldTab2.FldInfo  ==  _AttributeName[intIndex])
{
mstrFldInfo = value.ToString();
 AddUpdatedFld(convFieldTab2.FldInfo);
}
else if (convFieldTab2.IsNull  ==  _AttributeName[intIndex])
{
mbolIsNull = TransNullToBool(value.ToString());
 AddUpdatedFld(convFieldTab2.IsNull);
}
else if (convFieldTab2.IsPrimaryKey  ==  _AttributeName[intIndex])
{
mbolIsPrimaryKey = TransNullToBool(value.ToString());
 AddUpdatedFld(convFieldTab2.IsPrimaryKey);
}
else if (convFieldTab2.IsIdentity  ==  _AttributeName[intIndex])
{
mbolIsIdentity = TransNullToBool(value.ToString());
 AddUpdatedFld(convFieldTab2.IsIdentity);
}
else if (convFieldTab2.IsChecked  ==  _AttributeName[intIndex])
{
mbolIsChecked = TransNullToBool(value.ToString());
 AddUpdatedFld(convFieldTab2.IsChecked);
}
else if (convFieldTab2.IsOnlyOne  ==  _AttributeName[intIndex])
{
mbolIsOnlyOne = TransNullToBool(value.ToString());
 AddUpdatedFld(convFieldTab2.IsOnlyOne);
}
else if (convFieldTab2.MaxValue  ==  _AttributeName[intIndex])
{
mstrMaxValue = value.ToString();
 AddUpdatedFld(convFieldTab2.MaxValue);
}
else if (convFieldTab2.MinValue  ==  _AttributeName[intIndex])
{
mstrMinValue = value.ToString();
 AddUpdatedFld(convFieldTab2.MinValue);
}
else if (convFieldTab2.DefaultValue  ==  _AttributeName[intIndex])
{
mstrDefaultValue = value.ToString();
 AddUpdatedFld(convFieldTab2.DefaultValue);
}
else if (convFieldTab2.IsNeedTransCode  ==  _AttributeName[intIndex])
{
mbolIsNeedTransCode = TransNullToBool(value.ToString());
 AddUpdatedFld(convFieldTab2.IsNeedTransCode);
}
else if (convFieldTab2.AppliedScope  ==  _AttributeName[intIndex])
{
mstrAppliedScope = value.ToString();
 AddUpdatedFld(convFieldTab2.AppliedScope);
}
else if (convFieldTab2.CodeTabId  ==  _AttributeName[intIndex])
{
mstrCodeTabId = value.ToString();
 AddUpdatedFld(convFieldTab2.CodeTabId);
}
else if (convFieldTab2.CodeTabNameId  ==  _AttributeName[intIndex])
{
mstrCodeTabNameId = value.ToString();
 AddUpdatedFld(convFieldTab2.CodeTabNameId);
}
else if (convFieldTab2.CodeTabCodeId  ==  _AttributeName[intIndex])
{
mstrCodeTabCodeId = value.ToString();
 AddUpdatedFld(convFieldTab2.CodeTabCodeId);
}
else if (convFieldTab2.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFieldTab2.UpdDate);
}
else if (convFieldTab2.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFieldTab2.UpdUser);
}
else if (convFieldTab2.UserName  ==  _AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convFieldTab2.UserName);
}
}
}

/// <summary>
/// 数据类型名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataTypeName
{
get
{
return mstrDataTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataTypeName = value;
}
else
{
 mstrDataTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFieldTab2.DataTypeName);
}
}
/// <summary>
/// 字段Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FldId
{
get
{
return mstrFldId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldId = value;
}
else
{
 mstrFldId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFieldTab2.FldId);
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
 AddUpdatedFld(convFieldTab2.PrjId);
}
}
/// <summary>
/// 工程名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjName
{
get
{
return mstrPrjName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjName = value;
}
else
{
 mstrPrjName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFieldTab2.PrjName);
}
}
/// <summary>
/// 字段名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FldName
{
get
{
return mstrFldName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldName = value;
}
else
{
 mstrFldName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFieldTab2.FldName);
}
}
/// <summary>
/// 标题(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Caption
{
get
{
return mstrCaption;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaption = value;
}
else
{
 mstrCaption = value;
}
//记录修改过的字段
 AddUpdatedFld(convFieldTab2.Caption);
}
}
/// <summary>
/// 字段长度(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int FldLength
{
get
{
return mintFldLength;
}
set
{
 mintFldLength = value;
//记录修改过的字段
 AddUpdatedFld(convFieldTab2.FldLength);
}
}
/// <summary>
/// 字段信息(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FldInfo
{
get
{
return mstrFldInfo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldInfo = value;
}
else
{
 mstrFldInfo = value;
}
//记录修改过的字段
 AddUpdatedFld(convFieldTab2.FldInfo);
}
}
/// <summary>
/// 是否可空(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsNull
{
get
{
return mbolIsNull;
}
set
{
 mbolIsNull = value;
//记录修改过的字段
 AddUpdatedFld(convFieldTab2.IsNull);
}
}
/// <summary>
/// 是否主键(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsPrimaryKey
{
get
{
return mbolIsPrimaryKey;
}
set
{
 mbolIsPrimaryKey = value;
//记录修改过的字段
 AddUpdatedFld(convFieldTab2.IsPrimaryKey);
}
}
/// <summary>
/// 是否Identity(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsIdentity
{
get
{
return mbolIsIdentity;
}
set
{
 mbolIsIdentity = value;
//记录修改过的字段
 AddUpdatedFld(convFieldTab2.IsIdentity);
}
}
/// <summary>
/// 是否核实(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsChecked
{
get
{
return mbolIsChecked;
}
set
{
 mbolIsChecked = value;
//记录修改过的字段
 AddUpdatedFld(convFieldTab2.IsChecked);
}
}
/// <summary>
/// 是否唯一(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsOnlyOne
{
get
{
return mbolIsOnlyOne;
}
set
{
 mbolIsOnlyOne = value;
//记录修改过的字段
 AddUpdatedFld(convFieldTab2.IsOnlyOne);
}
}
/// <summary>
/// 最大值(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MaxValue
{
get
{
return mstrMaxValue;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMaxValue = value;
}
else
{
 mstrMaxValue = value;
}
//记录修改过的字段
 AddUpdatedFld(convFieldTab2.MaxValue);
}
}
/// <summary>
/// 最小值(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MinValue
{
get
{
return mstrMinValue;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMinValue = value;
}
else
{
 mstrMinValue = value;
}
//记录修改过的字段
 AddUpdatedFld(convFieldTab2.MinValue);
}
}
/// <summary>
/// 缺省值(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DefaultValue
{
get
{
return mstrDefaultValue;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDefaultValue = value;
}
else
{
 mstrDefaultValue = value;
}
//记录修改过的字段
 AddUpdatedFld(convFieldTab2.DefaultValue);
}
}
/// <summary>
/// 是否需要转换代码(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsNeedTransCode
{
get
{
return mbolIsNeedTransCode;
}
set
{
 mbolIsNeedTransCode = value;
//记录修改过的字段
 AddUpdatedFld(convFieldTab2.IsNeedTransCode);
}
}
/// <summary>
/// 应用范围(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AppliedScope
{
get
{
return mstrAppliedScope;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAppliedScope = value;
}
else
{
 mstrAppliedScope = value;
}
//记录修改过的字段
 AddUpdatedFld(convFieldTab2.AppliedScope);
}
}
/// <summary>
/// 代码表Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTabId
{
get
{
return mstrCodeTabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTabId = value;
}
else
{
 mstrCodeTabId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFieldTab2.CodeTabId);
}
}
/// <summary>
/// 代码_名Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTabNameId
{
get
{
return mstrCodeTabNameId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTabNameId = value;
}
else
{
 mstrCodeTabNameId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFieldTab2.CodeTabNameId);
}
}
/// <summary>
/// 代码Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTabCodeId
{
get
{
return mstrCodeTabCodeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTabCodeId = value;
}
else
{
 mstrCodeTabCodeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFieldTab2.CodeTabCodeId);
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
 AddUpdatedFld(convFieldTab2.UpdDate);
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
 AddUpdatedFld(convFieldTab2.UpdUser);
}
}
/// <summary>
/// 用户名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserName
{
get
{
return mstrUserName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserName = value;
}
else
{
 mstrUserName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFieldTab2.UserName);
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
  return mstrFldId;
 }
 }
}
 /// <summary>
 /// vFieldTab2(vFieldTab2)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convFieldTab2
{
public const string _CurrTabName = "vFieldTab2"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FldId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"DataTypeName", "FldId", "PrjId", "PrjName", "FldName", "Caption", "FldLength", "FldInfo", "IsNull", "IsPrimaryKey", "IsIdentity", "IsChecked", "IsOnlyOne", "MaxValue", "MinValue", "DefaultValue", "IsNeedTransCode", "AppliedScope", "CodeTabId", "CodeTabNameId", "CodeTabCodeId", "UpdDate", "UpdUser", "UserName"};
//以下是属性变量


 /// <summary>
 /// 常量:"DataTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataTypeName = "DataTypeName";    //数据类型名称

 /// <summary>
 /// 常量:"FldId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldId = "FldId";    //字段Id

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"PrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjName = "PrjName";    //工程名称

 /// <summary>
 /// 常量:"FldName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldName = "FldName";    //字段名

 /// <summary>
 /// 常量:"Caption"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Caption = "Caption";    //标题

 /// <summary>
 /// 常量:"FldLength"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldLength = "FldLength";    //字段长度

 /// <summary>
 /// 常量:"FldInfo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldInfo = "FldInfo";    //字段信息

 /// <summary>
 /// 常量:"IsNull"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsNull = "IsNull";    //是否可空

 /// <summary>
 /// 常量:"IsPrimaryKey"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsPrimaryKey = "IsPrimaryKey";    //是否主键

 /// <summary>
 /// 常量:"IsIdentity"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsIdentity = "IsIdentity";    //是否Identity

 /// <summary>
 /// 常量:"IsChecked"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsChecked = "IsChecked";    //是否核实

 /// <summary>
 /// 常量:"IsOnlyOne"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsOnlyOne = "IsOnlyOne";    //是否唯一

 /// <summary>
 /// 常量:"MaxValue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MaxValue = "MaxValue";    //最大值

 /// <summary>
 /// 常量:"MinValue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MinValue = "MinValue";    //最小值

 /// <summary>
 /// 常量:"DefaultValue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DefaultValue = "DefaultValue";    //缺省值

 /// <summary>
 /// 常量:"IsNeedTransCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsNeedTransCode = "IsNeedTransCode";    //是否需要转换代码

 /// <summary>
 /// 常量:"AppliedScope"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppliedScope = "AppliedScope";    //应用范围

 /// <summary>
 /// 常量:"CodeTabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTabId = "CodeTabId";    //代码表Id

 /// <summary>
 /// 常量:"CodeTabNameId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTabNameId = "CodeTabNameId";    //代码_名Id

 /// <summary>
 /// 常量:"CodeTabCodeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTabCodeId = "CodeTabCodeId";    //代码Id

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
 /// 常量:"UserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserName = "UserName";    //用户名
}

}