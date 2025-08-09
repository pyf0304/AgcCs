
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFieldTabEN
 表名:FieldTab(00050021)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:00:12
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
 /// 表FieldTab的关键字(FldId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_FldId_FieldTab
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
public K_FldId_FieldTab(string strFldId)
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
 /// <returns>返回:[K_FldId_FieldTab]类型的对象</returns>
public static implicit operator K_FldId_FieldTab(string value)
{
return new K_FldId_FieldTab(value);
}
}
 /// <summary>
 /// 工程字段(FieldTab)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsFieldTabEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "FieldTab"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "FldId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 27;
public static string[] _AttributeName = new string[] {"FldId", "FldName", "FldCnName", "Caption", "FieldTypeId", "DataTypeId", "FldLength", "FldPrecision", "FldInfo", "IsNull", "IsPrimaryKey", "IsIdentity", "IsChecked", "IsArchive", "IsOnlyOne", "MaxValue", "MinValue", "DefaultValue", "FldStateId", "HomologousFldId", "TabNum", "InUse", "PrjId", "UpdDate", "UpdUser", "Memo", "IsNeedTransCode"};

protected string mstrFldId;    //字段Id
protected string mstrFldName;    //字段名
protected string mstrFldCnName;    //字段中文详名
protected string mstrCaption;    //标题
protected string mstrFieldTypeId;    //字段类型Id
protected string mstrDataTypeId;    //数据类型Id
protected int mintFldLength;    //字段长度
protected int? mintFldPrecision;    //精确度
protected string mstrFldInfo;    //字段信息
protected bool mbolIsNull;    //是否可空
protected bool mbolIsPrimaryKey;    //是否主键
protected bool mbolIsIdentity;    //是否Identity
protected bool mbolIsChecked;    //是否核实
protected bool mbolIsArchive;    //是否存档
protected bool mbolIsOnlyOne;    //是否唯一
protected string mstrMaxValue;    //最大值
protected string mstrMinValue;    //最小值
protected string mstrDefaultValue;    //缺省值
protected string mstrFldStateId;    //字段状态Id
protected string mstrHomologousFldId;    //同源字段Id
protected int? mintTabNum;    //表数
protected bool mbolInUse;    //是否在用
protected string mstrPrjId;    //工程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明
protected bool mbolIsNeedTransCode;    //是否需要转换代码

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsFieldTabEN()
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
public clsFieldTabEN(string strFldId)
 {
strFldId = strFldId.Replace("'", "''");
if (strFldId.Length > 8)
{
throw new Exception("在表:FieldTab中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strFldId)  ==  true)
{
throw new Exception("在表:FieldTab中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  conFieldTab.FldId)
{
return mstrFldId;
}
else if (strAttributeName  ==  conFieldTab.FldName)
{
return mstrFldName;
}
else if (strAttributeName  ==  conFieldTab.FldCnName)
{
return mstrFldCnName;
}
else if (strAttributeName  ==  conFieldTab.Caption)
{
return mstrCaption;
}
else if (strAttributeName  ==  conFieldTab.FieldTypeId)
{
return mstrFieldTypeId;
}
else if (strAttributeName  ==  conFieldTab.DataTypeId)
{
return mstrDataTypeId;
}
else if (strAttributeName  ==  conFieldTab.FldLength)
{
return mintFldLength;
}
else if (strAttributeName  ==  conFieldTab.FldPrecision)
{
return mintFldPrecision;
}
else if (strAttributeName  ==  conFieldTab.FldInfo)
{
return mstrFldInfo;
}
else if (strAttributeName  ==  conFieldTab.IsNull)
{
return mbolIsNull;
}
else if (strAttributeName  ==  conFieldTab.IsPrimaryKey)
{
return mbolIsPrimaryKey;
}
else if (strAttributeName  ==  conFieldTab.IsIdentity)
{
return mbolIsIdentity;
}
else if (strAttributeName  ==  conFieldTab.IsChecked)
{
return mbolIsChecked;
}
else if (strAttributeName  ==  conFieldTab.IsArchive)
{
return mbolIsArchive;
}
else if (strAttributeName  ==  conFieldTab.IsOnlyOne)
{
return mbolIsOnlyOne;
}
else if (strAttributeName  ==  conFieldTab.MaxValue)
{
return mstrMaxValue;
}
else if (strAttributeName  ==  conFieldTab.MinValue)
{
return mstrMinValue;
}
else if (strAttributeName  ==  conFieldTab.DefaultValue)
{
return mstrDefaultValue;
}
else if (strAttributeName  ==  conFieldTab.FldStateId)
{
return mstrFldStateId;
}
else if (strAttributeName  ==  conFieldTab.HomologousFldId)
{
return mstrHomologousFldId;
}
else if (strAttributeName  ==  conFieldTab.TabNum)
{
return mintTabNum;
}
else if (strAttributeName  ==  conFieldTab.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  conFieldTab.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conFieldTab.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conFieldTab.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conFieldTab.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conFieldTab.IsNeedTransCode)
{
return mbolIsNeedTransCode;
}
return null;
}
set
{
if (strAttributeName  ==  conFieldTab.FldId)
{
mstrFldId = value.ToString();
 AddUpdatedFld(conFieldTab.FldId);
}
else if (strAttributeName  ==  conFieldTab.FldName)
{
mstrFldName = value.ToString();
 AddUpdatedFld(conFieldTab.FldName);
}
else if (strAttributeName  ==  conFieldTab.FldCnName)
{
mstrFldCnName = value.ToString();
 AddUpdatedFld(conFieldTab.FldCnName);
}
else if (strAttributeName  ==  conFieldTab.Caption)
{
mstrCaption = value.ToString();
 AddUpdatedFld(conFieldTab.Caption);
}
else if (strAttributeName  ==  conFieldTab.FieldTypeId)
{
mstrFieldTypeId = value.ToString();
 AddUpdatedFld(conFieldTab.FieldTypeId);
}
else if (strAttributeName  ==  conFieldTab.DataTypeId)
{
mstrDataTypeId = value.ToString();
 AddUpdatedFld(conFieldTab.DataTypeId);
}
else if (strAttributeName  ==  conFieldTab.FldLength)
{
mintFldLength = TransNullToInt(value.ToString());
 AddUpdatedFld(conFieldTab.FldLength);
}
else if (strAttributeName  ==  conFieldTab.FldPrecision)
{
mintFldPrecision = TransNullToInt(value.ToString());
 AddUpdatedFld(conFieldTab.FldPrecision);
}
else if (strAttributeName  ==  conFieldTab.FldInfo)
{
mstrFldInfo = value.ToString();
 AddUpdatedFld(conFieldTab.FldInfo);
}
else if (strAttributeName  ==  conFieldTab.IsNull)
{
mbolIsNull = TransNullToBool(value.ToString());
 AddUpdatedFld(conFieldTab.IsNull);
}
else if (strAttributeName  ==  conFieldTab.IsPrimaryKey)
{
mbolIsPrimaryKey = TransNullToBool(value.ToString());
 AddUpdatedFld(conFieldTab.IsPrimaryKey);
}
else if (strAttributeName  ==  conFieldTab.IsIdentity)
{
mbolIsIdentity = TransNullToBool(value.ToString());
 AddUpdatedFld(conFieldTab.IsIdentity);
}
else if (strAttributeName  ==  conFieldTab.IsChecked)
{
mbolIsChecked = TransNullToBool(value.ToString());
 AddUpdatedFld(conFieldTab.IsChecked);
}
else if (strAttributeName  ==  conFieldTab.IsArchive)
{
mbolIsArchive = TransNullToBool(value.ToString());
 AddUpdatedFld(conFieldTab.IsArchive);
}
else if (strAttributeName  ==  conFieldTab.IsOnlyOne)
{
mbolIsOnlyOne = TransNullToBool(value.ToString());
 AddUpdatedFld(conFieldTab.IsOnlyOne);
}
else if (strAttributeName  ==  conFieldTab.MaxValue)
{
mstrMaxValue = value.ToString();
 AddUpdatedFld(conFieldTab.MaxValue);
}
else if (strAttributeName  ==  conFieldTab.MinValue)
{
mstrMinValue = value.ToString();
 AddUpdatedFld(conFieldTab.MinValue);
}
else if (strAttributeName  ==  conFieldTab.DefaultValue)
{
mstrDefaultValue = value.ToString();
 AddUpdatedFld(conFieldTab.DefaultValue);
}
else if (strAttributeName  ==  conFieldTab.FldStateId)
{
mstrFldStateId = value.ToString();
 AddUpdatedFld(conFieldTab.FldStateId);
}
else if (strAttributeName  ==  conFieldTab.HomologousFldId)
{
mstrHomologousFldId = value.ToString();
 AddUpdatedFld(conFieldTab.HomologousFldId);
}
else if (strAttributeName  ==  conFieldTab.TabNum)
{
mintTabNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conFieldTab.TabNum);
}
else if (strAttributeName  ==  conFieldTab.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conFieldTab.InUse);
}
else if (strAttributeName  ==  conFieldTab.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conFieldTab.PrjId);
}
else if (strAttributeName  ==  conFieldTab.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFieldTab.UpdDate);
}
else if (strAttributeName  ==  conFieldTab.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conFieldTab.UpdUser);
}
else if (strAttributeName  ==  conFieldTab.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFieldTab.Memo);
}
else if (strAttributeName  ==  conFieldTab.IsNeedTransCode)
{
mbolIsNeedTransCode = TransNullToBool(value.ToString());
 AddUpdatedFld(conFieldTab.IsNeedTransCode);
}
}
}
public object this[int intIndex]
{
get
{
if (conFieldTab.FldId  ==  _AttributeName[intIndex])
{
return mstrFldId;
}
else if (conFieldTab.FldName  ==  _AttributeName[intIndex])
{
return mstrFldName;
}
else if (conFieldTab.FldCnName  ==  _AttributeName[intIndex])
{
return mstrFldCnName;
}
else if (conFieldTab.Caption  ==  _AttributeName[intIndex])
{
return mstrCaption;
}
else if (conFieldTab.FieldTypeId  ==  _AttributeName[intIndex])
{
return mstrFieldTypeId;
}
else if (conFieldTab.DataTypeId  ==  _AttributeName[intIndex])
{
return mstrDataTypeId;
}
else if (conFieldTab.FldLength  ==  _AttributeName[intIndex])
{
return mintFldLength;
}
else if (conFieldTab.FldPrecision  ==  _AttributeName[intIndex])
{
return mintFldPrecision;
}
else if (conFieldTab.FldInfo  ==  _AttributeName[intIndex])
{
return mstrFldInfo;
}
else if (conFieldTab.IsNull  ==  _AttributeName[intIndex])
{
return mbolIsNull;
}
else if (conFieldTab.IsPrimaryKey  ==  _AttributeName[intIndex])
{
return mbolIsPrimaryKey;
}
else if (conFieldTab.IsIdentity  ==  _AttributeName[intIndex])
{
return mbolIsIdentity;
}
else if (conFieldTab.IsChecked  ==  _AttributeName[intIndex])
{
return mbolIsChecked;
}
else if (conFieldTab.IsArchive  ==  _AttributeName[intIndex])
{
return mbolIsArchive;
}
else if (conFieldTab.IsOnlyOne  ==  _AttributeName[intIndex])
{
return mbolIsOnlyOne;
}
else if (conFieldTab.MaxValue  ==  _AttributeName[intIndex])
{
return mstrMaxValue;
}
else if (conFieldTab.MinValue  ==  _AttributeName[intIndex])
{
return mstrMinValue;
}
else if (conFieldTab.DefaultValue  ==  _AttributeName[intIndex])
{
return mstrDefaultValue;
}
else if (conFieldTab.FldStateId  ==  _AttributeName[intIndex])
{
return mstrFldStateId;
}
else if (conFieldTab.HomologousFldId  ==  _AttributeName[intIndex])
{
return mstrHomologousFldId;
}
else if (conFieldTab.TabNum  ==  _AttributeName[intIndex])
{
return mintTabNum;
}
else if (conFieldTab.InUse  ==  _AttributeName[intIndex])
{
return mbolInUse;
}
else if (conFieldTab.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conFieldTab.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conFieldTab.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conFieldTab.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (conFieldTab.IsNeedTransCode  ==  _AttributeName[intIndex])
{
return mbolIsNeedTransCode;
}
return null;
}
set
{
if (conFieldTab.FldId  ==  _AttributeName[intIndex])
{
mstrFldId = value.ToString();
 AddUpdatedFld(conFieldTab.FldId);
}
else if (conFieldTab.FldName  ==  _AttributeName[intIndex])
{
mstrFldName = value.ToString();
 AddUpdatedFld(conFieldTab.FldName);
}
else if (conFieldTab.FldCnName  ==  _AttributeName[intIndex])
{
mstrFldCnName = value.ToString();
 AddUpdatedFld(conFieldTab.FldCnName);
}
else if (conFieldTab.Caption  ==  _AttributeName[intIndex])
{
mstrCaption = value.ToString();
 AddUpdatedFld(conFieldTab.Caption);
}
else if (conFieldTab.FieldTypeId  ==  _AttributeName[intIndex])
{
mstrFieldTypeId = value.ToString();
 AddUpdatedFld(conFieldTab.FieldTypeId);
}
else if (conFieldTab.DataTypeId  ==  _AttributeName[intIndex])
{
mstrDataTypeId = value.ToString();
 AddUpdatedFld(conFieldTab.DataTypeId);
}
else if (conFieldTab.FldLength  ==  _AttributeName[intIndex])
{
mintFldLength = TransNullToInt(value.ToString());
 AddUpdatedFld(conFieldTab.FldLength);
}
else if (conFieldTab.FldPrecision  ==  _AttributeName[intIndex])
{
mintFldPrecision = TransNullToInt(value.ToString());
 AddUpdatedFld(conFieldTab.FldPrecision);
}
else if (conFieldTab.FldInfo  ==  _AttributeName[intIndex])
{
mstrFldInfo = value.ToString();
 AddUpdatedFld(conFieldTab.FldInfo);
}
else if (conFieldTab.IsNull  ==  _AttributeName[intIndex])
{
mbolIsNull = TransNullToBool(value.ToString());
 AddUpdatedFld(conFieldTab.IsNull);
}
else if (conFieldTab.IsPrimaryKey  ==  _AttributeName[intIndex])
{
mbolIsPrimaryKey = TransNullToBool(value.ToString());
 AddUpdatedFld(conFieldTab.IsPrimaryKey);
}
else if (conFieldTab.IsIdentity  ==  _AttributeName[intIndex])
{
mbolIsIdentity = TransNullToBool(value.ToString());
 AddUpdatedFld(conFieldTab.IsIdentity);
}
else if (conFieldTab.IsChecked  ==  _AttributeName[intIndex])
{
mbolIsChecked = TransNullToBool(value.ToString());
 AddUpdatedFld(conFieldTab.IsChecked);
}
else if (conFieldTab.IsArchive  ==  _AttributeName[intIndex])
{
mbolIsArchive = TransNullToBool(value.ToString());
 AddUpdatedFld(conFieldTab.IsArchive);
}
else if (conFieldTab.IsOnlyOne  ==  _AttributeName[intIndex])
{
mbolIsOnlyOne = TransNullToBool(value.ToString());
 AddUpdatedFld(conFieldTab.IsOnlyOne);
}
else if (conFieldTab.MaxValue  ==  _AttributeName[intIndex])
{
mstrMaxValue = value.ToString();
 AddUpdatedFld(conFieldTab.MaxValue);
}
else if (conFieldTab.MinValue  ==  _AttributeName[intIndex])
{
mstrMinValue = value.ToString();
 AddUpdatedFld(conFieldTab.MinValue);
}
else if (conFieldTab.DefaultValue  ==  _AttributeName[intIndex])
{
mstrDefaultValue = value.ToString();
 AddUpdatedFld(conFieldTab.DefaultValue);
}
else if (conFieldTab.FldStateId  ==  _AttributeName[intIndex])
{
mstrFldStateId = value.ToString();
 AddUpdatedFld(conFieldTab.FldStateId);
}
else if (conFieldTab.HomologousFldId  ==  _AttributeName[intIndex])
{
mstrHomologousFldId = value.ToString();
 AddUpdatedFld(conFieldTab.HomologousFldId);
}
else if (conFieldTab.TabNum  ==  _AttributeName[intIndex])
{
mintTabNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conFieldTab.TabNum);
}
else if (conFieldTab.InUse  ==  _AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conFieldTab.InUse);
}
else if (conFieldTab.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conFieldTab.PrjId);
}
else if (conFieldTab.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFieldTab.UpdDate);
}
else if (conFieldTab.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conFieldTab.UpdUser);
}
else if (conFieldTab.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFieldTab.Memo);
}
else if (conFieldTab.IsNeedTransCode  ==  _AttributeName[intIndex])
{
mbolIsNeedTransCode = TransNullToBool(value.ToString());
 AddUpdatedFld(conFieldTab.IsNeedTransCode);
}
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
 AddUpdatedFld(conFieldTab.FldId);
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
 AddUpdatedFld(conFieldTab.FldName);
}
}
/// <summary>
/// 字段中文详名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FldCnName
{
get
{
return mstrFldCnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldCnName = value;
}
else
{
 mstrFldCnName = value;
}
//记录修改过的字段
 AddUpdatedFld(conFieldTab.FldCnName);
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
 AddUpdatedFld(conFieldTab.Caption);
}
}
/// <summary>
/// 字段类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FieldTypeId
{
get
{
return mstrFieldTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFieldTypeId = value;
}
else
{
 mstrFieldTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conFieldTab.FieldTypeId);
}
}
/// <summary>
/// 数据类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataTypeId
{
get
{
return mstrDataTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataTypeId = value;
}
else
{
 mstrDataTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conFieldTab.DataTypeId);
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
 AddUpdatedFld(conFieldTab.FldLength);
}
}
/// <summary>
/// 精确度(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? FldPrecision
{
get
{
return mintFldPrecision;
}
set
{
 mintFldPrecision = value;
//记录修改过的字段
 AddUpdatedFld(conFieldTab.FldPrecision);
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
 AddUpdatedFld(conFieldTab.FldInfo);
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
 AddUpdatedFld(conFieldTab.IsNull);
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
 AddUpdatedFld(conFieldTab.IsPrimaryKey);
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
 AddUpdatedFld(conFieldTab.IsIdentity);
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
 AddUpdatedFld(conFieldTab.IsChecked);
}
}
/// <summary>
/// 是否存档(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsArchive
{
get
{
return mbolIsArchive;
}
set
{
 mbolIsArchive = value;
//记录修改过的字段
 AddUpdatedFld(conFieldTab.IsArchive);
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
 AddUpdatedFld(conFieldTab.IsOnlyOne);
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
 AddUpdatedFld(conFieldTab.MaxValue);
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
 AddUpdatedFld(conFieldTab.MinValue);
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
 AddUpdatedFld(conFieldTab.DefaultValue);
}
}
/// <summary>
/// 字段状态Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FldStateId
{
get
{
return mstrFldStateId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldStateId = value;
}
else
{
 mstrFldStateId = value;
}
//记录修改过的字段
 AddUpdatedFld(conFieldTab.FldStateId);
}
}
/// <summary>
/// 同源字段Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string HomologousFldId
{
get
{
return mstrHomologousFldId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrHomologousFldId = value;
}
else
{
 mstrHomologousFldId = value;
}
//记录修改过的字段
 AddUpdatedFld(conFieldTab.HomologousFldId);
}
}
/// <summary>
/// 表数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? TabNum
{
get
{
return mintTabNum;
}
set
{
 mintTabNum = value;
//记录修改过的字段
 AddUpdatedFld(conFieldTab.TabNum);
}
}
/// <summary>
/// 是否在用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool InUse
{
get
{
return mbolInUse;
}
set
{
 mbolInUse = value;
//记录修改过的字段
 AddUpdatedFld(conFieldTab.InUse);
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
 AddUpdatedFld(conFieldTab.PrjId);
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
 AddUpdatedFld(conFieldTab.UpdDate);
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
 AddUpdatedFld(conFieldTab.UpdUser);
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
 AddUpdatedFld(conFieldTab.Memo);
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
 AddUpdatedFld(conFieldTab.IsNeedTransCode);
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

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrFldName;
 }
 }
}
 /// <summary>
 /// 工程字段(FieldTab)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conFieldTab
{
public const string _CurrTabName = "FieldTab"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FldId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"FldId", "FldName", "FldCnName", "Caption", "FieldTypeId", "DataTypeId", "FldLength", "FldPrecision", "FldInfo", "IsNull", "IsPrimaryKey", "IsIdentity", "IsChecked", "IsArchive", "IsOnlyOne", "MaxValue", "MinValue", "DefaultValue", "FldStateId", "HomologousFldId", "TabNum", "InUse", "PrjId", "UpdDate", "UpdUser", "Memo", "IsNeedTransCode"};
//以下是属性变量


 /// <summary>
 /// 常量:"FldId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldId = "FldId";    //字段Id

 /// <summary>
 /// 常量:"FldName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldName = "FldName";    //字段名

 /// <summary>
 /// 常量:"FldCnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldCnName = "FldCnName";    //字段中文详名

 /// <summary>
 /// 常量:"Caption"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Caption = "Caption";    //标题

 /// <summary>
 /// 常量:"FieldTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FieldTypeId = "FieldTypeId";    //字段类型Id

 /// <summary>
 /// 常量:"DataTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataTypeId = "DataTypeId";    //数据类型Id

 /// <summary>
 /// 常量:"FldLength"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldLength = "FldLength";    //字段长度

 /// <summary>
 /// 常量:"FldPrecision"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldPrecision = "FldPrecision";    //精确度

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
 /// 常量:"IsArchive"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsArchive = "IsArchive";    //是否存档

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
 /// 常量:"FldStateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldStateId = "FldStateId";    //字段状态Id

 /// <summary>
 /// 常量:"HomologousFldId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string HomologousFldId = "HomologousFldId";    //同源字段Id

 /// <summary>
 /// 常量:"TabNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabNum = "TabNum";    //表数

 /// <summary>
 /// 常量:"InUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InUse = "InUse";    //是否在用

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

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

 /// <summary>
 /// 常量:"IsNeedTransCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsNeedTransCode = "IsNeedTransCode";    //是否需要转换代码
}

}