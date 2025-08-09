
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFieldTabEN
 表名:vFieldTab(00050119)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:06:03
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
 /// 表vFieldTab的关键字(FldId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_FldId_vFieldTab
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
public K_FldId_vFieldTab(string strFldId)
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
 /// <returns>返回:[K_FldId_vFieldTab]类型的对象</returns>
public static implicit operator K_FldId_vFieldTab(string value)
{
return new K_FldId_vFieldTab(value);
}
}
 /// <summary>
 /// v工程字段(vFieldTab)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvFieldTabEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vFieldTab"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "FldId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 31;
public static string[] _AttributeName = new string[] {"TabNum", "FieldTypeName", "FieldTypeENName", "OraDbType", "IsNeedTransCode", "FldId", "FldName", "FldCnName", "Caption", "FieldTypeId", "DataTypeId", "DataTypeName", "FldLength", "FldPrecision", "FldInfo", "IsNull", "IsPrimaryKey", "IsIdentity", "IsChecked", "IsArchive", "IsOnlyOne", "MaxValue", "MinValue", "DefaultValue", "FldStateId", "HomologousFldId", "PrjId", "PrjName", "UpdDate", "UpdUser", "Memo"};

protected int? mintTabNum;    //表数
protected string mstrFieldTypeName;    //字段类型名
protected string mstrFieldTypeENName;    //字段类型英文名
protected string mstrOraDbType;    //Ora数据类型
protected bool mbolIsNeedTransCode;    //是否需要转换代码
protected string mstrFldId;    //字段Id
protected string mstrFldName;    //字段名
protected string mstrFldCnName;    //字段中文详名
protected string mstrCaption;    //标题
protected string mstrFieldTypeId;    //字段类型Id
protected string mstrDataTypeId;    //数据类型Id
protected string mstrDataTypeName;    //数据类型名称
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
protected string mstrPrjId;    //工程Id
protected string mstrPrjName;    //工程名称
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvFieldTabEN()
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
public clsvFieldTabEN(string strFldId)
 {
strFldId = strFldId.Replace("'", "''");
if (strFldId.Length > 8)
{
throw new Exception("在表:vFieldTab中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strFldId)  ==  true)
{
throw new Exception("在表:vFieldTab中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convFieldTab.TabNum)
{
return mintTabNum;
}
else if (strAttributeName  ==  convFieldTab.FieldTypeName)
{
return mstrFieldTypeName;
}
else if (strAttributeName  ==  convFieldTab.FieldTypeENName)
{
return mstrFieldTypeENName;
}
else if (strAttributeName  ==  convFieldTab.OraDbType)
{
return mstrOraDbType;
}
else if (strAttributeName  ==  convFieldTab.IsNeedTransCode)
{
return mbolIsNeedTransCode;
}
else if (strAttributeName  ==  convFieldTab.FldId)
{
return mstrFldId;
}
else if (strAttributeName  ==  convFieldTab.FldName)
{
return mstrFldName;
}
else if (strAttributeName  ==  convFieldTab.FldCnName)
{
return mstrFldCnName;
}
else if (strAttributeName  ==  convFieldTab.Caption)
{
return mstrCaption;
}
else if (strAttributeName  ==  convFieldTab.FieldTypeId)
{
return mstrFieldTypeId;
}
else if (strAttributeName  ==  convFieldTab.DataTypeId)
{
return mstrDataTypeId;
}
else if (strAttributeName  ==  convFieldTab.DataTypeName)
{
return mstrDataTypeName;
}
else if (strAttributeName  ==  convFieldTab.FldLength)
{
return mintFldLength;
}
else if (strAttributeName  ==  convFieldTab.FldPrecision)
{
return mintFldPrecision;
}
else if (strAttributeName  ==  convFieldTab.FldInfo)
{
return mstrFldInfo;
}
else if (strAttributeName  ==  convFieldTab.IsNull)
{
return mbolIsNull;
}
else if (strAttributeName  ==  convFieldTab.IsPrimaryKey)
{
return mbolIsPrimaryKey;
}
else if (strAttributeName  ==  convFieldTab.IsIdentity)
{
return mbolIsIdentity;
}
else if (strAttributeName  ==  convFieldTab.IsChecked)
{
return mbolIsChecked;
}
else if (strAttributeName  ==  convFieldTab.IsArchive)
{
return mbolIsArchive;
}
else if (strAttributeName  ==  convFieldTab.IsOnlyOne)
{
return mbolIsOnlyOne;
}
else if (strAttributeName  ==  convFieldTab.MaxValue)
{
return mstrMaxValue;
}
else if (strAttributeName  ==  convFieldTab.MinValue)
{
return mstrMinValue;
}
else if (strAttributeName  ==  convFieldTab.DefaultValue)
{
return mstrDefaultValue;
}
else if (strAttributeName  ==  convFieldTab.FldStateId)
{
return mstrFldStateId;
}
else if (strAttributeName  ==  convFieldTab.HomologousFldId)
{
return mstrHomologousFldId;
}
else if (strAttributeName  ==  convFieldTab.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convFieldTab.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convFieldTab.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convFieldTab.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convFieldTab.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convFieldTab.TabNum)
{
mintTabNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFieldTab.TabNum);
}
else if (strAttributeName  ==  convFieldTab.FieldTypeName)
{
mstrFieldTypeName = value.ToString();
 AddUpdatedFld(convFieldTab.FieldTypeName);
}
else if (strAttributeName  ==  convFieldTab.FieldTypeENName)
{
mstrFieldTypeENName = value.ToString();
 AddUpdatedFld(convFieldTab.FieldTypeENName);
}
else if (strAttributeName  ==  convFieldTab.OraDbType)
{
mstrOraDbType = value.ToString();
 AddUpdatedFld(convFieldTab.OraDbType);
}
else if (strAttributeName  ==  convFieldTab.IsNeedTransCode)
{
mbolIsNeedTransCode = TransNullToBool(value.ToString());
 AddUpdatedFld(convFieldTab.IsNeedTransCode);
}
else if (strAttributeName  ==  convFieldTab.FldId)
{
mstrFldId = value.ToString();
 AddUpdatedFld(convFieldTab.FldId);
}
else if (strAttributeName  ==  convFieldTab.FldName)
{
mstrFldName = value.ToString();
 AddUpdatedFld(convFieldTab.FldName);
}
else if (strAttributeName  ==  convFieldTab.FldCnName)
{
mstrFldCnName = value.ToString();
 AddUpdatedFld(convFieldTab.FldCnName);
}
else if (strAttributeName  ==  convFieldTab.Caption)
{
mstrCaption = value.ToString();
 AddUpdatedFld(convFieldTab.Caption);
}
else if (strAttributeName  ==  convFieldTab.FieldTypeId)
{
mstrFieldTypeId = value.ToString();
 AddUpdatedFld(convFieldTab.FieldTypeId);
}
else if (strAttributeName  ==  convFieldTab.DataTypeId)
{
mstrDataTypeId = value.ToString();
 AddUpdatedFld(convFieldTab.DataTypeId);
}
else if (strAttributeName  ==  convFieldTab.DataTypeName)
{
mstrDataTypeName = value.ToString();
 AddUpdatedFld(convFieldTab.DataTypeName);
}
else if (strAttributeName  ==  convFieldTab.FldLength)
{
mintFldLength = TransNullToInt(value.ToString());
 AddUpdatedFld(convFieldTab.FldLength);
}
else if (strAttributeName  ==  convFieldTab.FldPrecision)
{
mintFldPrecision = TransNullToInt(value.ToString());
 AddUpdatedFld(convFieldTab.FldPrecision);
}
else if (strAttributeName  ==  convFieldTab.FldInfo)
{
mstrFldInfo = value.ToString();
 AddUpdatedFld(convFieldTab.FldInfo);
}
else if (strAttributeName  ==  convFieldTab.IsNull)
{
mbolIsNull = TransNullToBool(value.ToString());
 AddUpdatedFld(convFieldTab.IsNull);
}
else if (strAttributeName  ==  convFieldTab.IsPrimaryKey)
{
mbolIsPrimaryKey = TransNullToBool(value.ToString());
 AddUpdatedFld(convFieldTab.IsPrimaryKey);
}
else if (strAttributeName  ==  convFieldTab.IsIdentity)
{
mbolIsIdentity = TransNullToBool(value.ToString());
 AddUpdatedFld(convFieldTab.IsIdentity);
}
else if (strAttributeName  ==  convFieldTab.IsChecked)
{
mbolIsChecked = TransNullToBool(value.ToString());
 AddUpdatedFld(convFieldTab.IsChecked);
}
else if (strAttributeName  ==  convFieldTab.IsArchive)
{
mbolIsArchive = TransNullToBool(value.ToString());
 AddUpdatedFld(convFieldTab.IsArchive);
}
else if (strAttributeName  ==  convFieldTab.IsOnlyOne)
{
mbolIsOnlyOne = TransNullToBool(value.ToString());
 AddUpdatedFld(convFieldTab.IsOnlyOne);
}
else if (strAttributeName  ==  convFieldTab.MaxValue)
{
mstrMaxValue = value.ToString();
 AddUpdatedFld(convFieldTab.MaxValue);
}
else if (strAttributeName  ==  convFieldTab.MinValue)
{
mstrMinValue = value.ToString();
 AddUpdatedFld(convFieldTab.MinValue);
}
else if (strAttributeName  ==  convFieldTab.DefaultValue)
{
mstrDefaultValue = value.ToString();
 AddUpdatedFld(convFieldTab.DefaultValue);
}
else if (strAttributeName  ==  convFieldTab.FldStateId)
{
mstrFldStateId = value.ToString();
 AddUpdatedFld(convFieldTab.FldStateId);
}
else if (strAttributeName  ==  convFieldTab.HomologousFldId)
{
mstrHomologousFldId = value.ToString();
 AddUpdatedFld(convFieldTab.HomologousFldId);
}
else if (strAttributeName  ==  convFieldTab.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convFieldTab.PrjId);
}
else if (strAttributeName  ==  convFieldTab.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convFieldTab.PrjName);
}
else if (strAttributeName  ==  convFieldTab.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFieldTab.UpdDate);
}
else if (strAttributeName  ==  convFieldTab.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFieldTab.UpdUser);
}
else if (strAttributeName  ==  convFieldTab.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFieldTab.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convFieldTab.TabNum  ==  _AttributeName[intIndex])
{
return mintTabNum;
}
else if (convFieldTab.FieldTypeName  ==  _AttributeName[intIndex])
{
return mstrFieldTypeName;
}
else if (convFieldTab.FieldTypeENName  ==  _AttributeName[intIndex])
{
return mstrFieldTypeENName;
}
else if (convFieldTab.OraDbType  ==  _AttributeName[intIndex])
{
return mstrOraDbType;
}
else if (convFieldTab.IsNeedTransCode  ==  _AttributeName[intIndex])
{
return mbolIsNeedTransCode;
}
else if (convFieldTab.FldId  ==  _AttributeName[intIndex])
{
return mstrFldId;
}
else if (convFieldTab.FldName  ==  _AttributeName[intIndex])
{
return mstrFldName;
}
else if (convFieldTab.FldCnName  ==  _AttributeName[intIndex])
{
return mstrFldCnName;
}
else if (convFieldTab.Caption  ==  _AttributeName[intIndex])
{
return mstrCaption;
}
else if (convFieldTab.FieldTypeId  ==  _AttributeName[intIndex])
{
return mstrFieldTypeId;
}
else if (convFieldTab.DataTypeId  ==  _AttributeName[intIndex])
{
return mstrDataTypeId;
}
else if (convFieldTab.DataTypeName  ==  _AttributeName[intIndex])
{
return mstrDataTypeName;
}
else if (convFieldTab.FldLength  ==  _AttributeName[intIndex])
{
return mintFldLength;
}
else if (convFieldTab.FldPrecision  ==  _AttributeName[intIndex])
{
return mintFldPrecision;
}
else if (convFieldTab.FldInfo  ==  _AttributeName[intIndex])
{
return mstrFldInfo;
}
else if (convFieldTab.IsNull  ==  _AttributeName[intIndex])
{
return mbolIsNull;
}
else if (convFieldTab.IsPrimaryKey  ==  _AttributeName[intIndex])
{
return mbolIsPrimaryKey;
}
else if (convFieldTab.IsIdentity  ==  _AttributeName[intIndex])
{
return mbolIsIdentity;
}
else if (convFieldTab.IsChecked  ==  _AttributeName[intIndex])
{
return mbolIsChecked;
}
else if (convFieldTab.IsArchive  ==  _AttributeName[intIndex])
{
return mbolIsArchive;
}
else if (convFieldTab.IsOnlyOne  ==  _AttributeName[intIndex])
{
return mbolIsOnlyOne;
}
else if (convFieldTab.MaxValue  ==  _AttributeName[intIndex])
{
return mstrMaxValue;
}
else if (convFieldTab.MinValue  ==  _AttributeName[intIndex])
{
return mstrMinValue;
}
else if (convFieldTab.DefaultValue  ==  _AttributeName[intIndex])
{
return mstrDefaultValue;
}
else if (convFieldTab.FldStateId  ==  _AttributeName[intIndex])
{
return mstrFldStateId;
}
else if (convFieldTab.HomologousFldId  ==  _AttributeName[intIndex])
{
return mstrHomologousFldId;
}
else if (convFieldTab.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convFieldTab.PrjName  ==  _AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convFieldTab.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convFieldTab.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convFieldTab.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convFieldTab.TabNum  ==  _AttributeName[intIndex])
{
mintTabNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFieldTab.TabNum);
}
else if (convFieldTab.FieldTypeName  ==  _AttributeName[intIndex])
{
mstrFieldTypeName = value.ToString();
 AddUpdatedFld(convFieldTab.FieldTypeName);
}
else if (convFieldTab.FieldTypeENName  ==  _AttributeName[intIndex])
{
mstrFieldTypeENName = value.ToString();
 AddUpdatedFld(convFieldTab.FieldTypeENName);
}
else if (convFieldTab.OraDbType  ==  _AttributeName[intIndex])
{
mstrOraDbType = value.ToString();
 AddUpdatedFld(convFieldTab.OraDbType);
}
else if (convFieldTab.IsNeedTransCode  ==  _AttributeName[intIndex])
{
mbolIsNeedTransCode = TransNullToBool(value.ToString());
 AddUpdatedFld(convFieldTab.IsNeedTransCode);
}
else if (convFieldTab.FldId  ==  _AttributeName[intIndex])
{
mstrFldId = value.ToString();
 AddUpdatedFld(convFieldTab.FldId);
}
else if (convFieldTab.FldName  ==  _AttributeName[intIndex])
{
mstrFldName = value.ToString();
 AddUpdatedFld(convFieldTab.FldName);
}
else if (convFieldTab.FldCnName  ==  _AttributeName[intIndex])
{
mstrFldCnName = value.ToString();
 AddUpdatedFld(convFieldTab.FldCnName);
}
else if (convFieldTab.Caption  ==  _AttributeName[intIndex])
{
mstrCaption = value.ToString();
 AddUpdatedFld(convFieldTab.Caption);
}
else if (convFieldTab.FieldTypeId  ==  _AttributeName[intIndex])
{
mstrFieldTypeId = value.ToString();
 AddUpdatedFld(convFieldTab.FieldTypeId);
}
else if (convFieldTab.DataTypeId  ==  _AttributeName[intIndex])
{
mstrDataTypeId = value.ToString();
 AddUpdatedFld(convFieldTab.DataTypeId);
}
else if (convFieldTab.DataTypeName  ==  _AttributeName[intIndex])
{
mstrDataTypeName = value.ToString();
 AddUpdatedFld(convFieldTab.DataTypeName);
}
else if (convFieldTab.FldLength  ==  _AttributeName[intIndex])
{
mintFldLength = TransNullToInt(value.ToString());
 AddUpdatedFld(convFieldTab.FldLength);
}
else if (convFieldTab.FldPrecision  ==  _AttributeName[intIndex])
{
mintFldPrecision = TransNullToInt(value.ToString());
 AddUpdatedFld(convFieldTab.FldPrecision);
}
else if (convFieldTab.FldInfo  ==  _AttributeName[intIndex])
{
mstrFldInfo = value.ToString();
 AddUpdatedFld(convFieldTab.FldInfo);
}
else if (convFieldTab.IsNull  ==  _AttributeName[intIndex])
{
mbolIsNull = TransNullToBool(value.ToString());
 AddUpdatedFld(convFieldTab.IsNull);
}
else if (convFieldTab.IsPrimaryKey  ==  _AttributeName[intIndex])
{
mbolIsPrimaryKey = TransNullToBool(value.ToString());
 AddUpdatedFld(convFieldTab.IsPrimaryKey);
}
else if (convFieldTab.IsIdentity  ==  _AttributeName[intIndex])
{
mbolIsIdentity = TransNullToBool(value.ToString());
 AddUpdatedFld(convFieldTab.IsIdentity);
}
else if (convFieldTab.IsChecked  ==  _AttributeName[intIndex])
{
mbolIsChecked = TransNullToBool(value.ToString());
 AddUpdatedFld(convFieldTab.IsChecked);
}
else if (convFieldTab.IsArchive  ==  _AttributeName[intIndex])
{
mbolIsArchive = TransNullToBool(value.ToString());
 AddUpdatedFld(convFieldTab.IsArchive);
}
else if (convFieldTab.IsOnlyOne  ==  _AttributeName[intIndex])
{
mbolIsOnlyOne = TransNullToBool(value.ToString());
 AddUpdatedFld(convFieldTab.IsOnlyOne);
}
else if (convFieldTab.MaxValue  ==  _AttributeName[intIndex])
{
mstrMaxValue = value.ToString();
 AddUpdatedFld(convFieldTab.MaxValue);
}
else if (convFieldTab.MinValue  ==  _AttributeName[intIndex])
{
mstrMinValue = value.ToString();
 AddUpdatedFld(convFieldTab.MinValue);
}
else if (convFieldTab.DefaultValue  ==  _AttributeName[intIndex])
{
mstrDefaultValue = value.ToString();
 AddUpdatedFld(convFieldTab.DefaultValue);
}
else if (convFieldTab.FldStateId  ==  _AttributeName[intIndex])
{
mstrFldStateId = value.ToString();
 AddUpdatedFld(convFieldTab.FldStateId);
}
else if (convFieldTab.HomologousFldId  ==  _AttributeName[intIndex])
{
mstrHomologousFldId = value.ToString();
 AddUpdatedFld(convFieldTab.HomologousFldId);
}
else if (convFieldTab.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convFieldTab.PrjId);
}
else if (convFieldTab.PrjName  ==  _AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convFieldTab.PrjName);
}
else if (convFieldTab.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFieldTab.UpdDate);
}
else if (convFieldTab.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFieldTab.UpdUser);
}
else if (convFieldTab.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFieldTab.Memo);
}
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
 AddUpdatedFld(convFieldTab.TabNum);
}
}
/// <summary>
/// 字段类型名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FieldTypeName
{
get
{
return mstrFieldTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFieldTypeName = value;
}
else
{
 mstrFieldTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFieldTab.FieldTypeName);
}
}
/// <summary>
/// 字段类型英文名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FieldTypeENName
{
get
{
return mstrFieldTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFieldTypeENName = value;
}
else
{
 mstrFieldTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFieldTab.FieldTypeENName);
}
}
/// <summary>
/// Ora数据类型(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OraDbType
{
get
{
return mstrOraDbType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOraDbType = value;
}
else
{
 mstrOraDbType = value;
}
//记录修改过的字段
 AddUpdatedFld(convFieldTab.OraDbType);
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
 AddUpdatedFld(convFieldTab.IsNeedTransCode);
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
 AddUpdatedFld(convFieldTab.FldId);
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
 AddUpdatedFld(convFieldTab.FldName);
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
 AddUpdatedFld(convFieldTab.FldCnName);
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
 AddUpdatedFld(convFieldTab.Caption);
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
 AddUpdatedFld(convFieldTab.FieldTypeId);
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
 AddUpdatedFld(convFieldTab.DataTypeId);
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
 AddUpdatedFld(convFieldTab.DataTypeName);
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
 AddUpdatedFld(convFieldTab.FldLength);
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
 AddUpdatedFld(convFieldTab.FldPrecision);
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
 AddUpdatedFld(convFieldTab.FldInfo);
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
 AddUpdatedFld(convFieldTab.IsNull);
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
 AddUpdatedFld(convFieldTab.IsPrimaryKey);
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
 AddUpdatedFld(convFieldTab.IsIdentity);
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
 AddUpdatedFld(convFieldTab.IsChecked);
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
 AddUpdatedFld(convFieldTab.IsArchive);
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
 AddUpdatedFld(convFieldTab.IsOnlyOne);
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
 AddUpdatedFld(convFieldTab.MaxValue);
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
 AddUpdatedFld(convFieldTab.MinValue);
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
 AddUpdatedFld(convFieldTab.DefaultValue);
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
 AddUpdatedFld(convFieldTab.FldStateId);
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
 AddUpdatedFld(convFieldTab.HomologousFldId);
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
 AddUpdatedFld(convFieldTab.PrjId);
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
 AddUpdatedFld(convFieldTab.PrjName);
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
 AddUpdatedFld(convFieldTab.UpdDate);
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
 AddUpdatedFld(convFieldTab.UpdUser);
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
 AddUpdatedFld(convFieldTab.Memo);
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
 /// v工程字段(vFieldTab)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convFieldTab
{
public const string _CurrTabName = "vFieldTab"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FldId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"TabNum", "FieldTypeName", "FieldTypeENName", "OraDbType", "IsNeedTransCode", "FldId", "FldName", "FldCnName", "Caption", "FieldTypeId", "DataTypeId", "DataTypeName", "FldLength", "FldPrecision", "FldInfo", "IsNull", "IsPrimaryKey", "IsIdentity", "IsChecked", "IsArchive", "IsOnlyOne", "MaxValue", "MinValue", "DefaultValue", "FldStateId", "HomologousFldId", "PrjId", "PrjName", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"TabNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabNum = "TabNum";    //表数

 /// <summary>
 /// 常量:"FieldTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FieldTypeName = "FieldTypeName";    //字段类型名

 /// <summary>
 /// 常量:"FieldTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FieldTypeENName = "FieldTypeENName";    //字段类型英文名

 /// <summary>
 /// 常量:"OraDbType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OraDbType = "OraDbType";    //Ora数据类型

 /// <summary>
 /// 常量:"IsNeedTransCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsNeedTransCode = "IsNeedTransCode";    //是否需要转换代码

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
 /// 常量:"DataTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataTypeName = "DataTypeName";    //数据类型名称

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