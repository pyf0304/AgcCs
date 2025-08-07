
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTabFieldRelaEN
 表名:TabFieldRela(00050266)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:34:26
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:数据同步(DataSynch)
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
 /// 表TabFieldRela的关键字(IdFieldTabRela)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdFieldTabRela_TabFieldRela
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdFieldTabRela">表关键字</param>
public K_IdFieldTabRela_TabFieldRela(long lngIdFieldTabRela)
{
if (IsValid(lngIdFieldTabRela)) Value = lngIdFieldTabRela;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdFieldTabRela)
{
if (lngIdFieldTabRela == 0) return false;
if (lngIdFieldTabRela == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdFieldTabRela_TabFieldRela]类型的对象</returns>
public static implicit operator K_IdFieldTabRela_TabFieldRela(long value)
{
return new K_IdFieldTabRela_TabFieldRela(value);
}
}
 /// <summary>
 /// 表字段关系(TabFieldRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsTabFieldRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "TabFieldRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdFieldTabRela"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 35;
public static string[] _AttributeName = new string[] {"IdFieldTabRela", "FldId", "TabId", "SqlFldName", "ExcelFieldName", "DefaultValue", "IsNeedTrans", "TransWayId", "TransTabName", "TransInFldName", "TransOutFldName", "IsTabPrimary", "IsTabForeignKey", "PrimaryTypeId", "IsIdentity", "IsTabUnique", "IsTabNullable", "FieldTypeId", "IsNeedCheckPriForeignKey", "PrimaryKeyTabName", "PrimaryKeyFieldName", "TransMissingValue", "TransNullValue", "PrjId", "IsVisible", "SequenceNumber", "Memo", "FieldTypeIdS", "FldLengthS", "ForeignKeyTabId", "HashIndex", "IsUseHash", "Prefix", "PrefixFldId", "vFieldCnName"};

protected long mlngIdFieldTabRela;    //字段表关系流水号
protected string mstrFldId;    //字段Id
protected string mstrTabId;    //表ID
protected string mstrSqlFldName;    //Sql字段名称
protected string mstrExcelFieldName;    //Excel字段名称
protected string mstrDefaultValue;    //缺省值
protected bool mbolIsNeedTrans;    //是否需要转换
protected string mstrTransWayId;    //转换方式ID
protected string mstrTransTabName;    //转换表名
protected string mstrTransInFldName;    //转换IN字段名
protected string mstrTransOutFldName;    //转换Out字段名
protected bool mbolIsTabPrimary;    //是否作为表中主键
protected bool mbolIsTabForeignKey;    //是否表外键
protected string mstrPrimaryTypeId;    //主键类型ID
protected bool mbolIsIdentity;    //是否Identity
protected bool mbolIsTabUnique;    //是否表中唯一
protected bool mbolIsTabNullable;    //是否表中可空
protected string mstrFieldTypeId;    //字段类型Id
protected bool mbolIsNeedCheckPriForeignKey;    //是否检查主外键
protected string mstrPrimaryKeyTabName;    //主键表
protected string mstrPrimaryKeyFieldName;    //主键字段名
protected string mstrTransMissingValue;    //转换失败值
protected string mstrTransNullValue;    //转换空值
protected string mstrPrjId;    //工程Id
protected bool mbolIsVisible;    //是否显示
protected int? mintSequenceNumber;    //顺序号
protected string mstrMemo;    //说明
protected string mstrFieldTypeIdS;    //FieldTypeId_S
protected int? mintFldLengthS;    //FldLength_S
protected string mstrForeignKeyTabId;    //外键表ID
protected int? mintHashIndex;    //HASH表序号
protected bool mbolIsUseHash;    //是否用HASH表
protected string mstrPrefix;    //前缀
protected string mstrPrefixFldId;    //前缀字段Id
protected string mstrvFieldCnName;    //视图字段中文名称

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsTabFieldRelaEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdFieldTabRela");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdFieldTabRela">关键字:字段表关系流水号</param>
public clsTabFieldRelaEN(long lngIdFieldTabRela)
 {
 if (lngIdFieldTabRela  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdFieldTabRela = lngIdFieldTabRela;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdFieldTabRela");
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
if (strAttributeName  ==  conTabFieldRela.IdFieldTabRela)
{
return mlngIdFieldTabRela;
}
else if (strAttributeName  ==  conTabFieldRela.FldId)
{
return mstrFldId;
}
else if (strAttributeName  ==  conTabFieldRela.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  conTabFieldRela.SqlFldName)
{
return mstrSqlFldName;
}
else if (strAttributeName  ==  conTabFieldRela.ExcelFieldName)
{
return mstrExcelFieldName;
}
else if (strAttributeName  ==  conTabFieldRela.DefaultValue)
{
return mstrDefaultValue;
}
else if (strAttributeName  ==  conTabFieldRela.IsNeedTrans)
{
return mbolIsNeedTrans;
}
else if (strAttributeName  ==  conTabFieldRela.TransWayId)
{
return mstrTransWayId;
}
else if (strAttributeName  ==  conTabFieldRela.TransTabName)
{
return mstrTransTabName;
}
else if (strAttributeName  ==  conTabFieldRela.TransInFldName)
{
return mstrTransInFldName;
}
else if (strAttributeName  ==  conTabFieldRela.TransOutFldName)
{
return mstrTransOutFldName;
}
else if (strAttributeName  ==  conTabFieldRela.IsTabPrimary)
{
return mbolIsTabPrimary;
}
else if (strAttributeName  ==  conTabFieldRela.IsTabForeignKey)
{
return mbolIsTabForeignKey;
}
else if (strAttributeName  ==  conTabFieldRela.PrimaryTypeId)
{
return mstrPrimaryTypeId;
}
else if (strAttributeName  ==  conTabFieldRela.IsIdentity)
{
return mbolIsIdentity;
}
else if (strAttributeName  ==  conTabFieldRela.IsTabUnique)
{
return mbolIsTabUnique;
}
else if (strAttributeName  ==  conTabFieldRela.IsTabNullable)
{
return mbolIsTabNullable;
}
else if (strAttributeName  ==  conTabFieldRela.FieldTypeId)
{
return mstrFieldTypeId;
}
else if (strAttributeName  ==  conTabFieldRela.IsNeedCheckPriForeignKey)
{
return mbolIsNeedCheckPriForeignKey;
}
else if (strAttributeName  ==  conTabFieldRela.PrimaryKeyTabName)
{
return mstrPrimaryKeyTabName;
}
else if (strAttributeName  ==  conTabFieldRela.PrimaryKeyFieldName)
{
return mstrPrimaryKeyFieldName;
}
else if (strAttributeName  ==  conTabFieldRela.TransMissingValue)
{
return mstrTransMissingValue;
}
else if (strAttributeName  ==  conTabFieldRela.TransNullValue)
{
return mstrTransNullValue;
}
else if (strAttributeName  ==  conTabFieldRela.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conTabFieldRela.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  conTabFieldRela.SequenceNumber)
{
return mintSequenceNumber;
}
else if (strAttributeName  ==  conTabFieldRela.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conTabFieldRela.FieldTypeIdS)
{
return mstrFieldTypeIdS;
}
else if (strAttributeName  ==  conTabFieldRela.FldLengthS)
{
return mintFldLengthS;
}
else if (strAttributeName  ==  conTabFieldRela.ForeignKeyTabId)
{
return mstrForeignKeyTabId;
}
else if (strAttributeName  ==  conTabFieldRela.HashIndex)
{
return mintHashIndex;
}
else if (strAttributeName  ==  conTabFieldRela.IsUseHash)
{
return mbolIsUseHash;
}
else if (strAttributeName  ==  conTabFieldRela.Prefix)
{
return mstrPrefix;
}
else if (strAttributeName  ==  conTabFieldRela.PrefixFldId)
{
return mstrPrefixFldId;
}
else if (strAttributeName  ==  conTabFieldRela.vFieldCnName)
{
return mstrvFieldCnName;
}
return null;
}
set
{
if (strAttributeName  ==  conTabFieldRela.IdFieldTabRela)
{
mlngIdFieldTabRela = TransNullToInt(value.ToString());
 AddUpdatedFld(conTabFieldRela.IdFieldTabRela);
}
else if (strAttributeName  ==  conTabFieldRela.FldId)
{
mstrFldId = value.ToString();
 AddUpdatedFld(conTabFieldRela.FldId);
}
else if (strAttributeName  ==  conTabFieldRela.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(conTabFieldRela.TabId);
}
else if (strAttributeName  ==  conTabFieldRela.SqlFldName)
{
mstrSqlFldName = value.ToString();
 AddUpdatedFld(conTabFieldRela.SqlFldName);
}
else if (strAttributeName  ==  conTabFieldRela.ExcelFieldName)
{
mstrExcelFieldName = value.ToString();
 AddUpdatedFld(conTabFieldRela.ExcelFieldName);
}
else if (strAttributeName  ==  conTabFieldRela.DefaultValue)
{
mstrDefaultValue = value.ToString();
 AddUpdatedFld(conTabFieldRela.DefaultValue);
}
else if (strAttributeName  ==  conTabFieldRela.IsNeedTrans)
{
mbolIsNeedTrans = TransNullToBool(value.ToString());
 AddUpdatedFld(conTabFieldRela.IsNeedTrans);
}
else if (strAttributeName  ==  conTabFieldRela.TransWayId)
{
mstrTransWayId = value.ToString();
 AddUpdatedFld(conTabFieldRela.TransWayId);
}
else if (strAttributeName  ==  conTabFieldRela.TransTabName)
{
mstrTransTabName = value.ToString();
 AddUpdatedFld(conTabFieldRela.TransTabName);
}
else if (strAttributeName  ==  conTabFieldRela.TransInFldName)
{
mstrTransInFldName = value.ToString();
 AddUpdatedFld(conTabFieldRela.TransInFldName);
}
else if (strAttributeName  ==  conTabFieldRela.TransOutFldName)
{
mstrTransOutFldName = value.ToString();
 AddUpdatedFld(conTabFieldRela.TransOutFldName);
}
else if (strAttributeName  ==  conTabFieldRela.IsTabPrimary)
{
mbolIsTabPrimary = TransNullToBool(value.ToString());
 AddUpdatedFld(conTabFieldRela.IsTabPrimary);
}
else if (strAttributeName  ==  conTabFieldRela.IsTabForeignKey)
{
mbolIsTabForeignKey = TransNullToBool(value.ToString());
 AddUpdatedFld(conTabFieldRela.IsTabForeignKey);
}
else if (strAttributeName  ==  conTabFieldRela.PrimaryTypeId)
{
mstrPrimaryTypeId = value.ToString();
 AddUpdatedFld(conTabFieldRela.PrimaryTypeId);
}
else if (strAttributeName  ==  conTabFieldRela.IsIdentity)
{
mbolIsIdentity = TransNullToBool(value.ToString());
 AddUpdatedFld(conTabFieldRela.IsIdentity);
}
else if (strAttributeName  ==  conTabFieldRela.IsTabUnique)
{
mbolIsTabUnique = TransNullToBool(value.ToString());
 AddUpdatedFld(conTabFieldRela.IsTabUnique);
}
else if (strAttributeName  ==  conTabFieldRela.IsTabNullable)
{
mbolIsTabNullable = TransNullToBool(value.ToString());
 AddUpdatedFld(conTabFieldRela.IsTabNullable);
}
else if (strAttributeName  ==  conTabFieldRela.FieldTypeId)
{
mstrFieldTypeId = value.ToString();
 AddUpdatedFld(conTabFieldRela.FieldTypeId);
}
else if (strAttributeName  ==  conTabFieldRela.IsNeedCheckPriForeignKey)
{
mbolIsNeedCheckPriForeignKey = TransNullToBool(value.ToString());
 AddUpdatedFld(conTabFieldRela.IsNeedCheckPriForeignKey);
}
else if (strAttributeName  ==  conTabFieldRela.PrimaryKeyTabName)
{
mstrPrimaryKeyTabName = value.ToString();
 AddUpdatedFld(conTabFieldRela.PrimaryKeyTabName);
}
else if (strAttributeName  ==  conTabFieldRela.PrimaryKeyFieldName)
{
mstrPrimaryKeyFieldName = value.ToString();
 AddUpdatedFld(conTabFieldRela.PrimaryKeyFieldName);
}
else if (strAttributeName  ==  conTabFieldRela.TransMissingValue)
{
mstrTransMissingValue = value.ToString();
 AddUpdatedFld(conTabFieldRela.TransMissingValue);
}
else if (strAttributeName  ==  conTabFieldRela.TransNullValue)
{
mstrTransNullValue = value.ToString();
 AddUpdatedFld(conTabFieldRela.TransNullValue);
}
else if (strAttributeName  ==  conTabFieldRela.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conTabFieldRela.PrjId);
}
else if (strAttributeName  ==  conTabFieldRela.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conTabFieldRela.IsVisible);
}
else if (strAttributeName  ==  conTabFieldRela.SequenceNumber)
{
mintSequenceNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(conTabFieldRela.SequenceNumber);
}
else if (strAttributeName  ==  conTabFieldRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTabFieldRela.Memo);
}
else if (strAttributeName  ==  conTabFieldRela.FieldTypeIdS)
{
mstrFieldTypeIdS = value.ToString();
 AddUpdatedFld(conTabFieldRela.FieldTypeIdS);
}
else if (strAttributeName  ==  conTabFieldRela.FldLengthS)
{
mintFldLengthS = TransNullToInt(value.ToString());
 AddUpdatedFld(conTabFieldRela.FldLengthS);
}
else if (strAttributeName  ==  conTabFieldRela.ForeignKeyTabId)
{
mstrForeignKeyTabId = value.ToString();
 AddUpdatedFld(conTabFieldRela.ForeignKeyTabId);
}
else if (strAttributeName  ==  conTabFieldRela.HashIndex)
{
mintHashIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(conTabFieldRela.HashIndex);
}
else if (strAttributeName  ==  conTabFieldRela.IsUseHash)
{
mbolIsUseHash = TransNullToBool(value.ToString());
 AddUpdatedFld(conTabFieldRela.IsUseHash);
}
else if (strAttributeName  ==  conTabFieldRela.Prefix)
{
mstrPrefix = value.ToString();
 AddUpdatedFld(conTabFieldRela.Prefix);
}
else if (strAttributeName  ==  conTabFieldRela.PrefixFldId)
{
mstrPrefixFldId = value.ToString();
 AddUpdatedFld(conTabFieldRela.PrefixFldId);
}
else if (strAttributeName  ==  conTabFieldRela.vFieldCnName)
{
mstrvFieldCnName = value.ToString();
 AddUpdatedFld(conTabFieldRela.vFieldCnName);
}
}
}
public object this[int intIndex]
{
get
{
if (conTabFieldRela.IdFieldTabRela  ==  _AttributeName[intIndex])
{
return mlngIdFieldTabRela;
}
else if (conTabFieldRela.FldId  ==  _AttributeName[intIndex])
{
return mstrFldId;
}
else if (conTabFieldRela.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (conTabFieldRela.SqlFldName  ==  _AttributeName[intIndex])
{
return mstrSqlFldName;
}
else if (conTabFieldRela.ExcelFieldName  ==  _AttributeName[intIndex])
{
return mstrExcelFieldName;
}
else if (conTabFieldRela.DefaultValue  ==  _AttributeName[intIndex])
{
return mstrDefaultValue;
}
else if (conTabFieldRela.IsNeedTrans  ==  _AttributeName[intIndex])
{
return mbolIsNeedTrans;
}
else if (conTabFieldRela.TransWayId  ==  _AttributeName[intIndex])
{
return mstrTransWayId;
}
else if (conTabFieldRela.TransTabName  ==  _AttributeName[intIndex])
{
return mstrTransTabName;
}
else if (conTabFieldRela.TransInFldName  ==  _AttributeName[intIndex])
{
return mstrTransInFldName;
}
else if (conTabFieldRela.TransOutFldName  ==  _AttributeName[intIndex])
{
return mstrTransOutFldName;
}
else if (conTabFieldRela.IsTabPrimary  ==  _AttributeName[intIndex])
{
return mbolIsTabPrimary;
}
else if (conTabFieldRela.IsTabForeignKey  ==  _AttributeName[intIndex])
{
return mbolIsTabForeignKey;
}
else if (conTabFieldRela.PrimaryTypeId  ==  _AttributeName[intIndex])
{
return mstrPrimaryTypeId;
}
else if (conTabFieldRela.IsIdentity  ==  _AttributeName[intIndex])
{
return mbolIsIdentity;
}
else if (conTabFieldRela.IsTabUnique  ==  _AttributeName[intIndex])
{
return mbolIsTabUnique;
}
else if (conTabFieldRela.IsTabNullable  ==  _AttributeName[intIndex])
{
return mbolIsTabNullable;
}
else if (conTabFieldRela.FieldTypeId  ==  _AttributeName[intIndex])
{
return mstrFieldTypeId;
}
else if (conTabFieldRela.IsNeedCheckPriForeignKey  ==  _AttributeName[intIndex])
{
return mbolIsNeedCheckPriForeignKey;
}
else if (conTabFieldRela.PrimaryKeyTabName  ==  _AttributeName[intIndex])
{
return mstrPrimaryKeyTabName;
}
else if (conTabFieldRela.PrimaryKeyFieldName  ==  _AttributeName[intIndex])
{
return mstrPrimaryKeyFieldName;
}
else if (conTabFieldRela.TransMissingValue  ==  _AttributeName[intIndex])
{
return mstrTransMissingValue;
}
else if (conTabFieldRela.TransNullValue  ==  _AttributeName[intIndex])
{
return mstrTransNullValue;
}
else if (conTabFieldRela.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conTabFieldRela.IsVisible  ==  _AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (conTabFieldRela.SequenceNumber  ==  _AttributeName[intIndex])
{
return mintSequenceNumber;
}
else if (conTabFieldRela.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (conTabFieldRela.FieldTypeIdS  ==  _AttributeName[intIndex])
{
return mstrFieldTypeIdS;
}
else if (conTabFieldRela.FldLengthS  ==  _AttributeName[intIndex])
{
return mintFldLengthS;
}
else if (conTabFieldRela.ForeignKeyTabId  ==  _AttributeName[intIndex])
{
return mstrForeignKeyTabId;
}
else if (conTabFieldRela.HashIndex  ==  _AttributeName[intIndex])
{
return mintHashIndex;
}
else if (conTabFieldRela.IsUseHash  ==  _AttributeName[intIndex])
{
return mbolIsUseHash;
}
else if (conTabFieldRela.Prefix  ==  _AttributeName[intIndex])
{
return mstrPrefix;
}
else if (conTabFieldRela.PrefixFldId  ==  _AttributeName[intIndex])
{
return mstrPrefixFldId;
}
else if (conTabFieldRela.vFieldCnName  ==  _AttributeName[intIndex])
{
return mstrvFieldCnName;
}
return null;
}
set
{
if (conTabFieldRela.IdFieldTabRela  ==  _AttributeName[intIndex])
{
mlngIdFieldTabRela = TransNullToInt(value.ToString());
 AddUpdatedFld(conTabFieldRela.IdFieldTabRela);
}
else if (conTabFieldRela.FldId  ==  _AttributeName[intIndex])
{
mstrFldId = value.ToString();
 AddUpdatedFld(conTabFieldRela.FldId);
}
else if (conTabFieldRela.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(conTabFieldRela.TabId);
}
else if (conTabFieldRela.SqlFldName  ==  _AttributeName[intIndex])
{
mstrSqlFldName = value.ToString();
 AddUpdatedFld(conTabFieldRela.SqlFldName);
}
else if (conTabFieldRela.ExcelFieldName  ==  _AttributeName[intIndex])
{
mstrExcelFieldName = value.ToString();
 AddUpdatedFld(conTabFieldRela.ExcelFieldName);
}
else if (conTabFieldRela.DefaultValue  ==  _AttributeName[intIndex])
{
mstrDefaultValue = value.ToString();
 AddUpdatedFld(conTabFieldRela.DefaultValue);
}
else if (conTabFieldRela.IsNeedTrans  ==  _AttributeName[intIndex])
{
mbolIsNeedTrans = TransNullToBool(value.ToString());
 AddUpdatedFld(conTabFieldRela.IsNeedTrans);
}
else if (conTabFieldRela.TransWayId  ==  _AttributeName[intIndex])
{
mstrTransWayId = value.ToString();
 AddUpdatedFld(conTabFieldRela.TransWayId);
}
else if (conTabFieldRela.TransTabName  ==  _AttributeName[intIndex])
{
mstrTransTabName = value.ToString();
 AddUpdatedFld(conTabFieldRela.TransTabName);
}
else if (conTabFieldRela.TransInFldName  ==  _AttributeName[intIndex])
{
mstrTransInFldName = value.ToString();
 AddUpdatedFld(conTabFieldRela.TransInFldName);
}
else if (conTabFieldRela.TransOutFldName  ==  _AttributeName[intIndex])
{
mstrTransOutFldName = value.ToString();
 AddUpdatedFld(conTabFieldRela.TransOutFldName);
}
else if (conTabFieldRela.IsTabPrimary  ==  _AttributeName[intIndex])
{
mbolIsTabPrimary = TransNullToBool(value.ToString());
 AddUpdatedFld(conTabFieldRela.IsTabPrimary);
}
else if (conTabFieldRela.IsTabForeignKey  ==  _AttributeName[intIndex])
{
mbolIsTabForeignKey = TransNullToBool(value.ToString());
 AddUpdatedFld(conTabFieldRela.IsTabForeignKey);
}
else if (conTabFieldRela.PrimaryTypeId  ==  _AttributeName[intIndex])
{
mstrPrimaryTypeId = value.ToString();
 AddUpdatedFld(conTabFieldRela.PrimaryTypeId);
}
else if (conTabFieldRela.IsIdentity  ==  _AttributeName[intIndex])
{
mbolIsIdentity = TransNullToBool(value.ToString());
 AddUpdatedFld(conTabFieldRela.IsIdentity);
}
else if (conTabFieldRela.IsTabUnique  ==  _AttributeName[intIndex])
{
mbolIsTabUnique = TransNullToBool(value.ToString());
 AddUpdatedFld(conTabFieldRela.IsTabUnique);
}
else if (conTabFieldRela.IsTabNullable  ==  _AttributeName[intIndex])
{
mbolIsTabNullable = TransNullToBool(value.ToString());
 AddUpdatedFld(conTabFieldRela.IsTabNullable);
}
else if (conTabFieldRela.FieldTypeId  ==  _AttributeName[intIndex])
{
mstrFieldTypeId = value.ToString();
 AddUpdatedFld(conTabFieldRela.FieldTypeId);
}
else if (conTabFieldRela.IsNeedCheckPriForeignKey  ==  _AttributeName[intIndex])
{
mbolIsNeedCheckPriForeignKey = TransNullToBool(value.ToString());
 AddUpdatedFld(conTabFieldRela.IsNeedCheckPriForeignKey);
}
else if (conTabFieldRela.PrimaryKeyTabName  ==  _AttributeName[intIndex])
{
mstrPrimaryKeyTabName = value.ToString();
 AddUpdatedFld(conTabFieldRela.PrimaryKeyTabName);
}
else if (conTabFieldRela.PrimaryKeyFieldName  ==  _AttributeName[intIndex])
{
mstrPrimaryKeyFieldName = value.ToString();
 AddUpdatedFld(conTabFieldRela.PrimaryKeyFieldName);
}
else if (conTabFieldRela.TransMissingValue  ==  _AttributeName[intIndex])
{
mstrTransMissingValue = value.ToString();
 AddUpdatedFld(conTabFieldRela.TransMissingValue);
}
else if (conTabFieldRela.TransNullValue  ==  _AttributeName[intIndex])
{
mstrTransNullValue = value.ToString();
 AddUpdatedFld(conTabFieldRela.TransNullValue);
}
else if (conTabFieldRela.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conTabFieldRela.PrjId);
}
else if (conTabFieldRela.IsVisible  ==  _AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conTabFieldRela.IsVisible);
}
else if (conTabFieldRela.SequenceNumber  ==  _AttributeName[intIndex])
{
mintSequenceNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(conTabFieldRela.SequenceNumber);
}
else if (conTabFieldRela.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTabFieldRela.Memo);
}
else if (conTabFieldRela.FieldTypeIdS  ==  _AttributeName[intIndex])
{
mstrFieldTypeIdS = value.ToString();
 AddUpdatedFld(conTabFieldRela.FieldTypeIdS);
}
else if (conTabFieldRela.FldLengthS  ==  _AttributeName[intIndex])
{
mintFldLengthS = TransNullToInt(value.ToString());
 AddUpdatedFld(conTabFieldRela.FldLengthS);
}
else if (conTabFieldRela.ForeignKeyTabId  ==  _AttributeName[intIndex])
{
mstrForeignKeyTabId = value.ToString();
 AddUpdatedFld(conTabFieldRela.ForeignKeyTabId);
}
else if (conTabFieldRela.HashIndex  ==  _AttributeName[intIndex])
{
mintHashIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(conTabFieldRela.HashIndex);
}
else if (conTabFieldRela.IsUseHash  ==  _AttributeName[intIndex])
{
mbolIsUseHash = TransNullToBool(value.ToString());
 AddUpdatedFld(conTabFieldRela.IsUseHash);
}
else if (conTabFieldRela.Prefix  ==  _AttributeName[intIndex])
{
mstrPrefix = value.ToString();
 AddUpdatedFld(conTabFieldRela.Prefix);
}
else if (conTabFieldRela.PrefixFldId  ==  _AttributeName[intIndex])
{
mstrPrefixFldId = value.ToString();
 AddUpdatedFld(conTabFieldRela.PrefixFldId);
}
else if (conTabFieldRela.vFieldCnName  ==  _AttributeName[intIndex])
{
mstrvFieldCnName = value.ToString();
 AddUpdatedFld(conTabFieldRela.vFieldCnName);
}
}
}

/// <summary>
/// 字段表关系流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdFieldTabRela
{
get
{
return mlngIdFieldTabRela;
}
set
{
 mlngIdFieldTabRela = value;
//记录修改过的字段
 AddUpdatedFld(conTabFieldRela.IdFieldTabRela);
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
 AddUpdatedFld(conTabFieldRela.FldId);
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
 AddUpdatedFld(conTabFieldRela.TabId);
}
}
/// <summary>
/// Sql字段名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SqlFldName
{
get
{
return mstrSqlFldName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSqlFldName = value;
}
else
{
 mstrSqlFldName = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabFieldRela.SqlFldName);
}
}
/// <summary>
/// Excel字段名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExcelFieldName
{
get
{
return mstrExcelFieldName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExcelFieldName = value;
}
else
{
 mstrExcelFieldName = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabFieldRela.ExcelFieldName);
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
 AddUpdatedFld(conTabFieldRela.DefaultValue);
}
}
/// <summary>
/// 是否需要转换(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsNeedTrans
{
get
{
return mbolIsNeedTrans;
}
set
{
 mbolIsNeedTrans = value;
//记录修改过的字段
 AddUpdatedFld(conTabFieldRela.IsNeedTrans);
}
}
/// <summary>
/// 转换方式ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TransWayId
{
get
{
return mstrTransWayId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTransWayId = value;
}
else
{
 mstrTransWayId = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabFieldRela.TransWayId);
}
}
/// <summary>
/// 转换表名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TransTabName
{
get
{
return mstrTransTabName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTransTabName = value;
}
else
{
 mstrTransTabName = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabFieldRela.TransTabName);
}
}
/// <summary>
/// 转换IN字段名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TransInFldName
{
get
{
return mstrTransInFldName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTransInFldName = value;
}
else
{
 mstrTransInFldName = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabFieldRela.TransInFldName);
}
}
/// <summary>
/// 转换Out字段名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TransOutFldName
{
get
{
return mstrTransOutFldName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTransOutFldName = value;
}
else
{
 mstrTransOutFldName = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabFieldRela.TransOutFldName);
}
}
/// <summary>
/// 是否作为表中主键(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsTabPrimary
{
get
{
return mbolIsTabPrimary;
}
set
{
 mbolIsTabPrimary = value;
//记录修改过的字段
 AddUpdatedFld(conTabFieldRela.IsTabPrimary);
}
}
/// <summary>
/// 是否表外键(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsTabForeignKey
{
get
{
return mbolIsTabForeignKey;
}
set
{
 mbolIsTabForeignKey = value;
//记录修改过的字段
 AddUpdatedFld(conTabFieldRela.IsTabForeignKey);
}
}
/// <summary>
/// 主键类型ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrimaryTypeId
{
get
{
return mstrPrimaryTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrimaryTypeId = value;
}
else
{
 mstrPrimaryTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabFieldRela.PrimaryTypeId);
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
 AddUpdatedFld(conTabFieldRela.IsIdentity);
}
}
/// <summary>
/// 是否表中唯一(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsTabUnique
{
get
{
return mbolIsTabUnique;
}
set
{
 mbolIsTabUnique = value;
//记录修改过的字段
 AddUpdatedFld(conTabFieldRela.IsTabUnique);
}
}
/// <summary>
/// 是否表中可空(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsTabNullable
{
get
{
return mbolIsTabNullable;
}
set
{
 mbolIsTabNullable = value;
//记录修改过的字段
 AddUpdatedFld(conTabFieldRela.IsTabNullable);
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
 AddUpdatedFld(conTabFieldRela.FieldTypeId);
}
}
/// <summary>
/// 是否检查主外键(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsNeedCheckPriForeignKey
{
get
{
return mbolIsNeedCheckPriForeignKey;
}
set
{
 mbolIsNeedCheckPriForeignKey = value;
//记录修改过的字段
 AddUpdatedFld(conTabFieldRela.IsNeedCheckPriForeignKey);
}
}
/// <summary>
/// 主键表(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrimaryKeyTabName
{
get
{
return mstrPrimaryKeyTabName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrimaryKeyTabName = value;
}
else
{
 mstrPrimaryKeyTabName = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabFieldRela.PrimaryKeyTabName);
}
}
/// <summary>
/// 主键字段名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrimaryKeyFieldName
{
get
{
return mstrPrimaryKeyFieldName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrimaryKeyFieldName = value;
}
else
{
 mstrPrimaryKeyFieldName = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabFieldRela.PrimaryKeyFieldName);
}
}
/// <summary>
/// 转换失败值(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TransMissingValue
{
get
{
return mstrTransMissingValue;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTransMissingValue = value;
}
else
{
 mstrTransMissingValue = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabFieldRela.TransMissingValue);
}
}
/// <summary>
/// 转换空值(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TransNullValue
{
get
{
return mstrTransNullValue;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTransNullValue = value;
}
else
{
 mstrTransNullValue = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabFieldRela.TransNullValue);
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
 AddUpdatedFld(conTabFieldRela.PrjId);
}
}
/// <summary>
/// 是否显示(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsVisible
{
get
{
return mbolIsVisible;
}
set
{
 mbolIsVisible = value;
//记录修改过的字段
 AddUpdatedFld(conTabFieldRela.IsVisible);
}
}
/// <summary>
/// 顺序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? SequenceNumber
{
get
{
return mintSequenceNumber;
}
set
{
 mintSequenceNumber = value;
//记录修改过的字段
 AddUpdatedFld(conTabFieldRela.SequenceNumber);
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
 AddUpdatedFld(conTabFieldRela.Memo);
}
}
/// <summary>
/// FieldTypeId_S(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FieldTypeIdS
{
get
{
return mstrFieldTypeIdS;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFieldTypeIdS = value;
}
else
{
 mstrFieldTypeIdS = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabFieldRela.FieldTypeIdS);
}
}
/// <summary>
/// FldLength_S(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? FldLengthS
{
get
{
return mintFldLengthS;
}
set
{
 mintFldLengthS = value;
//记录修改过的字段
 AddUpdatedFld(conTabFieldRela.FldLengthS);
}
}
/// <summary>
/// 外键表ID(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ForeignKeyTabId
{
get
{
return mstrForeignKeyTabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrForeignKeyTabId = value;
}
else
{
 mstrForeignKeyTabId = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabFieldRela.ForeignKeyTabId);
}
}
/// <summary>
/// HASH表序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? HashIndex
{
get
{
return mintHashIndex;
}
set
{
 mintHashIndex = value;
//记录修改过的字段
 AddUpdatedFld(conTabFieldRela.HashIndex);
}
}
/// <summary>
/// 是否用HASH表(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsUseHash
{
get
{
return mbolIsUseHash;
}
set
{
 mbolIsUseHash = value;
//记录修改过的字段
 AddUpdatedFld(conTabFieldRela.IsUseHash);
}
}
/// <summary>
/// 前缀(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Prefix
{
get
{
return mstrPrefix;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrefix = value;
}
else
{
 mstrPrefix = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabFieldRela.Prefix);
}
}
/// <summary>
/// 前缀字段Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrefixFldId
{
get
{
return mstrPrefixFldId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrefixFldId = value;
}
else
{
 mstrPrefixFldId = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabFieldRela.PrefixFldId);
}
}
/// <summary>
/// 视图字段中文名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string vFieldCnName
{
get
{
return mstrvFieldCnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrvFieldCnName = value;
}
else
{
 mstrvFieldCnName = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabFieldRela.vFieldCnName);
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
  return mlngIdFieldTabRela.ToString();
 }
 }
}
 /// <summary>
 /// 表字段关系(TabFieldRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conTabFieldRela
{
public const string _CurrTabName = "TabFieldRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdFieldTabRela"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"IdFieldTabRela", "FldId", "TabId", "SqlFldName", "ExcelFieldName", "DefaultValue", "IsNeedTrans", "TransWayId", "TransTabName", "TransInFldName", "TransOutFldName", "IsTabPrimary", "IsTabForeignKey", "PrimaryTypeId", "IsIdentity", "IsTabUnique", "IsTabNullable", "FieldTypeId", "IsNeedCheckPriForeignKey", "PrimaryKeyTabName", "PrimaryKeyFieldName", "TransMissingValue", "TransNullValue", "PrjId", "IsVisible", "SequenceNumber", "Memo", "FieldTypeIdS", "FldLengthS", "ForeignKeyTabId", "HashIndex", "IsUseHash", "Prefix", "PrefixFldId", "vFieldCnName"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdFieldTabRela"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdFieldTabRela = "IdFieldTabRela";    //字段表关系流水号

 /// <summary>
 /// 常量:"FldId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldId = "FldId";    //字段Id

 /// <summary>
 /// 常量:"TabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabId = "TabId";    //表ID

 /// <summary>
 /// 常量:"SqlFldName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SqlFldName = "SqlFldName";    //Sql字段名称

 /// <summary>
 /// 常量:"ExcelFieldName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExcelFieldName = "ExcelFieldName";    //Excel字段名称

 /// <summary>
 /// 常量:"DefaultValue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DefaultValue = "DefaultValue";    //缺省值

 /// <summary>
 /// 常量:"IsNeedTrans"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsNeedTrans = "IsNeedTrans";    //是否需要转换

 /// <summary>
 /// 常量:"TransWayId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TransWayId = "TransWayId";    //转换方式ID

 /// <summary>
 /// 常量:"TransTabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TransTabName = "TransTabName";    //转换表名

 /// <summary>
 /// 常量:"TransInFldName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TransInFldName = "TransInFldName";    //转换IN字段名

 /// <summary>
 /// 常量:"TransOutFldName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TransOutFldName = "TransOutFldName";    //转换Out字段名

 /// <summary>
 /// 常量:"IsTabPrimary"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsTabPrimary = "IsTabPrimary";    //是否作为表中主键

 /// <summary>
 /// 常量:"IsTabForeignKey"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsTabForeignKey = "IsTabForeignKey";    //是否表外键

 /// <summary>
 /// 常量:"PrimaryTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrimaryTypeId = "PrimaryTypeId";    //主键类型ID

 /// <summary>
 /// 常量:"IsIdentity"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsIdentity = "IsIdentity";    //是否Identity

 /// <summary>
 /// 常量:"IsTabUnique"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsTabUnique = "IsTabUnique";    //是否表中唯一

 /// <summary>
 /// 常量:"IsTabNullable"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsTabNullable = "IsTabNullable";    //是否表中可空

 /// <summary>
 /// 常量:"FieldTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FieldTypeId = "FieldTypeId";    //字段类型Id

 /// <summary>
 /// 常量:"IsNeedCheckPriForeignKey"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsNeedCheckPriForeignKey = "IsNeedCheckPriForeignKey";    //是否检查主外键

 /// <summary>
 /// 常量:"PrimaryKeyTabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrimaryKeyTabName = "PrimaryKeyTabName";    //主键表

 /// <summary>
 /// 常量:"PrimaryKeyFieldName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrimaryKeyFieldName = "PrimaryKeyFieldName";    //主键字段名

 /// <summary>
 /// 常量:"TransMissingValue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TransMissingValue = "TransMissingValue";    //转换失败值

 /// <summary>
 /// 常量:"TransNullValue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TransNullValue = "TransNullValue";    //转换空值

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"IsVisible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVisible = "IsVisible";    //是否显示

 /// <summary>
 /// 常量:"SequenceNumber"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SequenceNumber = "SequenceNumber";    //顺序号

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明

 /// <summary>
 /// 常量:"FieldTypeIdS"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FieldTypeIdS = "FieldTypeIdS";    //FieldTypeId_S

 /// <summary>
 /// 常量:"FldLengthS"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldLengthS = "FldLengthS";    //FldLength_S

 /// <summary>
 /// 常量:"ForeignKeyTabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ForeignKeyTabId = "ForeignKeyTabId";    //外键表ID

 /// <summary>
 /// 常量:"HashIndex"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string HashIndex = "HashIndex";    //HASH表序号

 /// <summary>
 /// 常量:"IsUseHash"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsUseHash = "IsUseHash";    //是否用HASH表

 /// <summary>
 /// 常量:"Prefix"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Prefix = "Prefix";    //前缀

 /// <summary>
 /// 常量:"PrefixFldId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrefixFldId = "PrefixFldId";    //前缀字段Id

 /// <summary>
 /// 常量:"vFieldCnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string vFieldCnName = "vFieldCnName";    //视图字段中文名称
}

}