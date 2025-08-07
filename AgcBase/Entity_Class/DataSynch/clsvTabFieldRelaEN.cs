
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTabFieldRelaEN
 表名:vTabFieldRela(00050267)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:33:39
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
 /// 表vTabFieldRela的关键字(IdFieldTabRela)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdFieldTabRela_vTabFieldRela
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
public K_IdFieldTabRela_vTabFieldRela(long lngIdFieldTabRela)
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
 /// <returns>返回:[K_IdFieldTabRela_vTabFieldRela]类型的对象</returns>
public static implicit operator K_IdFieldTabRela_vTabFieldRela(long value)
{
return new K_IdFieldTabRela_vTabFieldRela(value);
}
}
 /// <summary>
 /// v表字段关系(vTabFieldRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvTabFieldRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vTabFieldRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdFieldTabRela"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 37;
public static string[] _AttributeName = new string[] {"IdFieldTabRela", "TabId", "FldId", "FldName", "Caption", "SqlFldName", "ExcelFieldName", "IsNeedTrans", "TransOutFldName", "TransInFldName", "PrimaryTypeId", "PrimaryTypeName", "TransTabName", "IsIdentity", "IsVisible", "IsTabPrimary", "IsTabNullable", "IsTabUnique", "DataTypeName", "SequenceNumber", "IsNeedCheckPriForeignKey", "IsTabForeignKey", "PrimaryKeyFieldName", "PrimaryKeyTabName", "DefaultValue", "TransWayId", "TransWayName", "FldLength", "TransMissingValue", "TransNullValue", "PrjName", "PrjId", "PrefixFldName", "Keyword", "TabCnName", "TabEnName", "Memo"};

protected long mlngIdFieldTabRela;    //字段表关系流水号
protected string mstrTabId;    //表ID
protected string mstrFldId;    //字段Id
protected string mstrFldName;    //字段名
protected string mstrCaption;    //标题
protected string mstrSqlFldName;    //Sql字段名称
protected string mstrExcelFieldName;    //Excel字段名称
protected bool mbolIsNeedTrans;    //是否需要转换
protected string mstrTransOutFldName;    //转换Out字段名
protected string mstrTransInFldName;    //转换IN字段名
protected string mstrPrimaryTypeId;    //主键类型ID
protected string mstrPrimaryTypeName;    //主键类型名
protected string mstrTransTabName;    //转换表名
protected bool mbolIsIdentity;    //是否Identity
protected bool mbolIsVisible;    //是否显示
protected bool mbolIsTabPrimary;    //是否作为表中主键
protected bool mbolIsTabNullable;    //是否表中可空
protected bool mbolIsTabUnique;    //是否表中唯一
protected string mstrDataTypeName;    //数据类型名称
protected int? mintSequenceNumber;    //顺序号
protected bool mbolIsNeedCheckPriForeignKey;    //是否检查主外键
protected bool mbolIsTabForeignKey;    //是否表外键
protected string mstrPrimaryKeyFieldName;    //主键字段名
protected string mstrPrimaryKeyTabName;    //主键表
protected string mstrDefaultValue;    //缺省值
protected string mstrTransWayId;    //转换方式ID
protected string mstrTransWayName;    //转换方式名称
protected int? mintFldLength;    //字段长度
protected string mstrTransMissingValue;    //转换失败值
protected string mstrTransNullValue;    //转换空值
protected string mstrPrjName;    //工程名称
protected string mstrPrjId;    //工程Id
protected string mstrPrefixFldName;    //前缀字段名
protected string mstrKeyword;    //关键字
protected string mstrTabCnName;    //表中文名
protected string mstrTabEnName;    //表英文详细名
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvTabFieldRelaEN()
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
public clsvTabFieldRelaEN(long lngIdFieldTabRela)
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
if (strAttributeName  ==  convTabFieldRela.IdFieldTabRela)
{
return mlngIdFieldTabRela;
}
else if (strAttributeName  ==  convTabFieldRela.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  convTabFieldRela.FldId)
{
return mstrFldId;
}
else if (strAttributeName  ==  convTabFieldRela.FldName)
{
return mstrFldName;
}
else if (strAttributeName  ==  convTabFieldRela.Caption)
{
return mstrCaption;
}
else if (strAttributeName  ==  convTabFieldRela.SqlFldName)
{
return mstrSqlFldName;
}
else if (strAttributeName  ==  convTabFieldRela.ExcelFieldName)
{
return mstrExcelFieldName;
}
else if (strAttributeName  ==  convTabFieldRela.IsNeedTrans)
{
return mbolIsNeedTrans;
}
else if (strAttributeName  ==  convTabFieldRela.TransOutFldName)
{
return mstrTransOutFldName;
}
else if (strAttributeName  ==  convTabFieldRela.TransInFldName)
{
return mstrTransInFldName;
}
else if (strAttributeName  ==  convTabFieldRela.PrimaryTypeId)
{
return mstrPrimaryTypeId;
}
else if (strAttributeName  ==  convTabFieldRela.PrimaryTypeName)
{
return mstrPrimaryTypeName;
}
else if (strAttributeName  ==  convTabFieldRela.TransTabName)
{
return mstrTransTabName;
}
else if (strAttributeName  ==  convTabFieldRela.IsIdentity)
{
return mbolIsIdentity;
}
else if (strAttributeName  ==  convTabFieldRela.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  convTabFieldRela.IsTabPrimary)
{
return mbolIsTabPrimary;
}
else if (strAttributeName  ==  convTabFieldRela.IsTabNullable)
{
return mbolIsTabNullable;
}
else if (strAttributeName  ==  convTabFieldRela.IsTabUnique)
{
return mbolIsTabUnique;
}
else if (strAttributeName  ==  convTabFieldRela.DataTypeName)
{
return mstrDataTypeName;
}
else if (strAttributeName  ==  convTabFieldRela.SequenceNumber)
{
return mintSequenceNumber;
}
else if (strAttributeName  ==  convTabFieldRela.IsNeedCheckPriForeignKey)
{
return mbolIsNeedCheckPriForeignKey;
}
else if (strAttributeName  ==  convTabFieldRela.IsTabForeignKey)
{
return mbolIsTabForeignKey;
}
else if (strAttributeName  ==  convTabFieldRela.PrimaryKeyFieldName)
{
return mstrPrimaryKeyFieldName;
}
else if (strAttributeName  ==  convTabFieldRela.PrimaryKeyTabName)
{
return mstrPrimaryKeyTabName;
}
else if (strAttributeName  ==  convTabFieldRela.DefaultValue)
{
return mstrDefaultValue;
}
else if (strAttributeName  ==  convTabFieldRela.TransWayId)
{
return mstrTransWayId;
}
else if (strAttributeName  ==  convTabFieldRela.TransWayName)
{
return mstrTransWayName;
}
else if (strAttributeName  ==  convTabFieldRela.FldLength)
{
return mintFldLength;
}
else if (strAttributeName  ==  convTabFieldRela.TransMissingValue)
{
return mstrTransMissingValue;
}
else if (strAttributeName  ==  convTabFieldRela.TransNullValue)
{
return mstrTransNullValue;
}
else if (strAttributeName  ==  convTabFieldRela.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convTabFieldRela.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convTabFieldRela.PrefixFldName)
{
return mstrPrefixFldName;
}
else if (strAttributeName  ==  convTabFieldRela.Keyword)
{
return mstrKeyword;
}
else if (strAttributeName  ==  convTabFieldRela.TabCnName)
{
return mstrTabCnName;
}
else if (strAttributeName  ==  convTabFieldRela.TabEnName)
{
return mstrTabEnName;
}
else if (strAttributeName  ==  convTabFieldRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convTabFieldRela.IdFieldTabRela)
{
mlngIdFieldTabRela = TransNullToInt(value.ToString());
 AddUpdatedFld(convTabFieldRela.IdFieldTabRela);
}
else if (strAttributeName  ==  convTabFieldRela.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(convTabFieldRela.TabId);
}
else if (strAttributeName  ==  convTabFieldRela.FldId)
{
mstrFldId = value.ToString();
 AddUpdatedFld(convTabFieldRela.FldId);
}
else if (strAttributeName  ==  convTabFieldRela.FldName)
{
mstrFldName = value.ToString();
 AddUpdatedFld(convTabFieldRela.FldName);
}
else if (strAttributeName  ==  convTabFieldRela.Caption)
{
mstrCaption = value.ToString();
 AddUpdatedFld(convTabFieldRela.Caption);
}
else if (strAttributeName  ==  convTabFieldRela.SqlFldName)
{
mstrSqlFldName = value.ToString();
 AddUpdatedFld(convTabFieldRela.SqlFldName);
}
else if (strAttributeName  ==  convTabFieldRela.ExcelFieldName)
{
mstrExcelFieldName = value.ToString();
 AddUpdatedFld(convTabFieldRela.ExcelFieldName);
}
else if (strAttributeName  ==  convTabFieldRela.IsNeedTrans)
{
mbolIsNeedTrans = TransNullToBool(value.ToString());
 AddUpdatedFld(convTabFieldRela.IsNeedTrans);
}
else if (strAttributeName  ==  convTabFieldRela.TransOutFldName)
{
mstrTransOutFldName = value.ToString();
 AddUpdatedFld(convTabFieldRela.TransOutFldName);
}
else if (strAttributeName  ==  convTabFieldRela.TransInFldName)
{
mstrTransInFldName = value.ToString();
 AddUpdatedFld(convTabFieldRela.TransInFldName);
}
else if (strAttributeName  ==  convTabFieldRela.PrimaryTypeId)
{
mstrPrimaryTypeId = value.ToString();
 AddUpdatedFld(convTabFieldRela.PrimaryTypeId);
}
else if (strAttributeName  ==  convTabFieldRela.PrimaryTypeName)
{
mstrPrimaryTypeName = value.ToString();
 AddUpdatedFld(convTabFieldRela.PrimaryTypeName);
}
else if (strAttributeName  ==  convTabFieldRela.TransTabName)
{
mstrTransTabName = value.ToString();
 AddUpdatedFld(convTabFieldRela.TransTabName);
}
else if (strAttributeName  ==  convTabFieldRela.IsIdentity)
{
mbolIsIdentity = TransNullToBool(value.ToString());
 AddUpdatedFld(convTabFieldRela.IsIdentity);
}
else if (strAttributeName  ==  convTabFieldRela.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convTabFieldRela.IsVisible);
}
else if (strAttributeName  ==  convTabFieldRela.IsTabPrimary)
{
mbolIsTabPrimary = TransNullToBool(value.ToString());
 AddUpdatedFld(convTabFieldRela.IsTabPrimary);
}
else if (strAttributeName  ==  convTabFieldRela.IsTabNullable)
{
mbolIsTabNullable = TransNullToBool(value.ToString());
 AddUpdatedFld(convTabFieldRela.IsTabNullable);
}
else if (strAttributeName  ==  convTabFieldRela.IsTabUnique)
{
mbolIsTabUnique = TransNullToBool(value.ToString());
 AddUpdatedFld(convTabFieldRela.IsTabUnique);
}
else if (strAttributeName  ==  convTabFieldRela.DataTypeName)
{
mstrDataTypeName = value.ToString();
 AddUpdatedFld(convTabFieldRela.DataTypeName);
}
else if (strAttributeName  ==  convTabFieldRela.SequenceNumber)
{
mintSequenceNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convTabFieldRela.SequenceNumber);
}
else if (strAttributeName  ==  convTabFieldRela.IsNeedCheckPriForeignKey)
{
mbolIsNeedCheckPriForeignKey = TransNullToBool(value.ToString());
 AddUpdatedFld(convTabFieldRela.IsNeedCheckPriForeignKey);
}
else if (strAttributeName  ==  convTabFieldRela.IsTabForeignKey)
{
mbolIsTabForeignKey = TransNullToBool(value.ToString());
 AddUpdatedFld(convTabFieldRela.IsTabForeignKey);
}
else if (strAttributeName  ==  convTabFieldRela.PrimaryKeyFieldName)
{
mstrPrimaryKeyFieldName = value.ToString();
 AddUpdatedFld(convTabFieldRela.PrimaryKeyFieldName);
}
else if (strAttributeName  ==  convTabFieldRela.PrimaryKeyTabName)
{
mstrPrimaryKeyTabName = value.ToString();
 AddUpdatedFld(convTabFieldRela.PrimaryKeyTabName);
}
else if (strAttributeName  ==  convTabFieldRela.DefaultValue)
{
mstrDefaultValue = value.ToString();
 AddUpdatedFld(convTabFieldRela.DefaultValue);
}
else if (strAttributeName  ==  convTabFieldRela.TransWayId)
{
mstrTransWayId = value.ToString();
 AddUpdatedFld(convTabFieldRela.TransWayId);
}
else if (strAttributeName  ==  convTabFieldRela.TransWayName)
{
mstrTransWayName = value.ToString();
 AddUpdatedFld(convTabFieldRela.TransWayName);
}
else if (strAttributeName  ==  convTabFieldRela.FldLength)
{
mintFldLength = TransNullToInt(value.ToString());
 AddUpdatedFld(convTabFieldRela.FldLength);
}
else if (strAttributeName  ==  convTabFieldRela.TransMissingValue)
{
mstrTransMissingValue = value.ToString();
 AddUpdatedFld(convTabFieldRela.TransMissingValue);
}
else if (strAttributeName  ==  convTabFieldRela.TransNullValue)
{
mstrTransNullValue = value.ToString();
 AddUpdatedFld(convTabFieldRela.TransNullValue);
}
else if (strAttributeName  ==  convTabFieldRela.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convTabFieldRela.PrjName);
}
else if (strAttributeName  ==  convTabFieldRela.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convTabFieldRela.PrjId);
}
else if (strAttributeName  ==  convTabFieldRela.PrefixFldName)
{
mstrPrefixFldName = value.ToString();
 AddUpdatedFld(convTabFieldRela.PrefixFldName);
}
else if (strAttributeName  ==  convTabFieldRela.Keyword)
{
mstrKeyword = value.ToString();
 AddUpdatedFld(convTabFieldRela.Keyword);
}
else if (strAttributeName  ==  convTabFieldRela.TabCnName)
{
mstrTabCnName = value.ToString();
 AddUpdatedFld(convTabFieldRela.TabCnName);
}
else if (strAttributeName  ==  convTabFieldRela.TabEnName)
{
mstrTabEnName = value.ToString();
 AddUpdatedFld(convTabFieldRela.TabEnName);
}
else if (strAttributeName  ==  convTabFieldRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convTabFieldRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convTabFieldRela.IdFieldTabRela  ==  _AttributeName[intIndex])
{
return mlngIdFieldTabRela;
}
else if (convTabFieldRela.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (convTabFieldRela.FldId  ==  _AttributeName[intIndex])
{
return mstrFldId;
}
else if (convTabFieldRela.FldName  ==  _AttributeName[intIndex])
{
return mstrFldName;
}
else if (convTabFieldRela.Caption  ==  _AttributeName[intIndex])
{
return mstrCaption;
}
else if (convTabFieldRela.SqlFldName  ==  _AttributeName[intIndex])
{
return mstrSqlFldName;
}
else if (convTabFieldRela.ExcelFieldName  ==  _AttributeName[intIndex])
{
return mstrExcelFieldName;
}
else if (convTabFieldRela.IsNeedTrans  ==  _AttributeName[intIndex])
{
return mbolIsNeedTrans;
}
else if (convTabFieldRela.TransOutFldName  ==  _AttributeName[intIndex])
{
return mstrTransOutFldName;
}
else if (convTabFieldRela.TransInFldName  ==  _AttributeName[intIndex])
{
return mstrTransInFldName;
}
else if (convTabFieldRela.PrimaryTypeId  ==  _AttributeName[intIndex])
{
return mstrPrimaryTypeId;
}
else if (convTabFieldRela.PrimaryTypeName  ==  _AttributeName[intIndex])
{
return mstrPrimaryTypeName;
}
else if (convTabFieldRela.TransTabName  ==  _AttributeName[intIndex])
{
return mstrTransTabName;
}
else if (convTabFieldRela.IsIdentity  ==  _AttributeName[intIndex])
{
return mbolIsIdentity;
}
else if (convTabFieldRela.IsVisible  ==  _AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (convTabFieldRela.IsTabPrimary  ==  _AttributeName[intIndex])
{
return mbolIsTabPrimary;
}
else if (convTabFieldRela.IsTabNullable  ==  _AttributeName[intIndex])
{
return mbolIsTabNullable;
}
else if (convTabFieldRela.IsTabUnique  ==  _AttributeName[intIndex])
{
return mbolIsTabUnique;
}
else if (convTabFieldRela.DataTypeName  ==  _AttributeName[intIndex])
{
return mstrDataTypeName;
}
else if (convTabFieldRela.SequenceNumber  ==  _AttributeName[intIndex])
{
return mintSequenceNumber;
}
else if (convTabFieldRela.IsNeedCheckPriForeignKey  ==  _AttributeName[intIndex])
{
return mbolIsNeedCheckPriForeignKey;
}
else if (convTabFieldRela.IsTabForeignKey  ==  _AttributeName[intIndex])
{
return mbolIsTabForeignKey;
}
else if (convTabFieldRela.PrimaryKeyFieldName  ==  _AttributeName[intIndex])
{
return mstrPrimaryKeyFieldName;
}
else if (convTabFieldRela.PrimaryKeyTabName  ==  _AttributeName[intIndex])
{
return mstrPrimaryKeyTabName;
}
else if (convTabFieldRela.DefaultValue  ==  _AttributeName[intIndex])
{
return mstrDefaultValue;
}
else if (convTabFieldRela.TransWayId  ==  _AttributeName[intIndex])
{
return mstrTransWayId;
}
else if (convTabFieldRela.TransWayName  ==  _AttributeName[intIndex])
{
return mstrTransWayName;
}
else if (convTabFieldRela.FldLength  ==  _AttributeName[intIndex])
{
return mintFldLength;
}
else if (convTabFieldRela.TransMissingValue  ==  _AttributeName[intIndex])
{
return mstrTransMissingValue;
}
else if (convTabFieldRela.TransNullValue  ==  _AttributeName[intIndex])
{
return mstrTransNullValue;
}
else if (convTabFieldRela.PrjName  ==  _AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convTabFieldRela.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convTabFieldRela.PrefixFldName  ==  _AttributeName[intIndex])
{
return mstrPrefixFldName;
}
else if (convTabFieldRela.Keyword  ==  _AttributeName[intIndex])
{
return mstrKeyword;
}
else if (convTabFieldRela.TabCnName  ==  _AttributeName[intIndex])
{
return mstrTabCnName;
}
else if (convTabFieldRela.TabEnName  ==  _AttributeName[intIndex])
{
return mstrTabEnName;
}
else if (convTabFieldRela.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convTabFieldRela.IdFieldTabRela  ==  _AttributeName[intIndex])
{
mlngIdFieldTabRela = TransNullToInt(value.ToString());
 AddUpdatedFld(convTabFieldRela.IdFieldTabRela);
}
else if (convTabFieldRela.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(convTabFieldRela.TabId);
}
else if (convTabFieldRela.FldId  ==  _AttributeName[intIndex])
{
mstrFldId = value.ToString();
 AddUpdatedFld(convTabFieldRela.FldId);
}
else if (convTabFieldRela.FldName  ==  _AttributeName[intIndex])
{
mstrFldName = value.ToString();
 AddUpdatedFld(convTabFieldRela.FldName);
}
else if (convTabFieldRela.Caption  ==  _AttributeName[intIndex])
{
mstrCaption = value.ToString();
 AddUpdatedFld(convTabFieldRela.Caption);
}
else if (convTabFieldRela.SqlFldName  ==  _AttributeName[intIndex])
{
mstrSqlFldName = value.ToString();
 AddUpdatedFld(convTabFieldRela.SqlFldName);
}
else if (convTabFieldRela.ExcelFieldName  ==  _AttributeName[intIndex])
{
mstrExcelFieldName = value.ToString();
 AddUpdatedFld(convTabFieldRela.ExcelFieldName);
}
else if (convTabFieldRela.IsNeedTrans  ==  _AttributeName[intIndex])
{
mbolIsNeedTrans = TransNullToBool(value.ToString());
 AddUpdatedFld(convTabFieldRela.IsNeedTrans);
}
else if (convTabFieldRela.TransOutFldName  ==  _AttributeName[intIndex])
{
mstrTransOutFldName = value.ToString();
 AddUpdatedFld(convTabFieldRela.TransOutFldName);
}
else if (convTabFieldRela.TransInFldName  ==  _AttributeName[intIndex])
{
mstrTransInFldName = value.ToString();
 AddUpdatedFld(convTabFieldRela.TransInFldName);
}
else if (convTabFieldRela.PrimaryTypeId  ==  _AttributeName[intIndex])
{
mstrPrimaryTypeId = value.ToString();
 AddUpdatedFld(convTabFieldRela.PrimaryTypeId);
}
else if (convTabFieldRela.PrimaryTypeName  ==  _AttributeName[intIndex])
{
mstrPrimaryTypeName = value.ToString();
 AddUpdatedFld(convTabFieldRela.PrimaryTypeName);
}
else if (convTabFieldRela.TransTabName  ==  _AttributeName[intIndex])
{
mstrTransTabName = value.ToString();
 AddUpdatedFld(convTabFieldRela.TransTabName);
}
else if (convTabFieldRela.IsIdentity  ==  _AttributeName[intIndex])
{
mbolIsIdentity = TransNullToBool(value.ToString());
 AddUpdatedFld(convTabFieldRela.IsIdentity);
}
else if (convTabFieldRela.IsVisible  ==  _AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convTabFieldRela.IsVisible);
}
else if (convTabFieldRela.IsTabPrimary  ==  _AttributeName[intIndex])
{
mbolIsTabPrimary = TransNullToBool(value.ToString());
 AddUpdatedFld(convTabFieldRela.IsTabPrimary);
}
else if (convTabFieldRela.IsTabNullable  ==  _AttributeName[intIndex])
{
mbolIsTabNullable = TransNullToBool(value.ToString());
 AddUpdatedFld(convTabFieldRela.IsTabNullable);
}
else if (convTabFieldRela.IsTabUnique  ==  _AttributeName[intIndex])
{
mbolIsTabUnique = TransNullToBool(value.ToString());
 AddUpdatedFld(convTabFieldRela.IsTabUnique);
}
else if (convTabFieldRela.DataTypeName  ==  _AttributeName[intIndex])
{
mstrDataTypeName = value.ToString();
 AddUpdatedFld(convTabFieldRela.DataTypeName);
}
else if (convTabFieldRela.SequenceNumber  ==  _AttributeName[intIndex])
{
mintSequenceNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convTabFieldRela.SequenceNumber);
}
else if (convTabFieldRela.IsNeedCheckPriForeignKey  ==  _AttributeName[intIndex])
{
mbolIsNeedCheckPriForeignKey = TransNullToBool(value.ToString());
 AddUpdatedFld(convTabFieldRela.IsNeedCheckPriForeignKey);
}
else if (convTabFieldRela.IsTabForeignKey  ==  _AttributeName[intIndex])
{
mbolIsTabForeignKey = TransNullToBool(value.ToString());
 AddUpdatedFld(convTabFieldRela.IsTabForeignKey);
}
else if (convTabFieldRela.PrimaryKeyFieldName  ==  _AttributeName[intIndex])
{
mstrPrimaryKeyFieldName = value.ToString();
 AddUpdatedFld(convTabFieldRela.PrimaryKeyFieldName);
}
else if (convTabFieldRela.PrimaryKeyTabName  ==  _AttributeName[intIndex])
{
mstrPrimaryKeyTabName = value.ToString();
 AddUpdatedFld(convTabFieldRela.PrimaryKeyTabName);
}
else if (convTabFieldRela.DefaultValue  ==  _AttributeName[intIndex])
{
mstrDefaultValue = value.ToString();
 AddUpdatedFld(convTabFieldRela.DefaultValue);
}
else if (convTabFieldRela.TransWayId  ==  _AttributeName[intIndex])
{
mstrTransWayId = value.ToString();
 AddUpdatedFld(convTabFieldRela.TransWayId);
}
else if (convTabFieldRela.TransWayName  ==  _AttributeName[intIndex])
{
mstrTransWayName = value.ToString();
 AddUpdatedFld(convTabFieldRela.TransWayName);
}
else if (convTabFieldRela.FldLength  ==  _AttributeName[intIndex])
{
mintFldLength = TransNullToInt(value.ToString());
 AddUpdatedFld(convTabFieldRela.FldLength);
}
else if (convTabFieldRela.TransMissingValue  ==  _AttributeName[intIndex])
{
mstrTransMissingValue = value.ToString();
 AddUpdatedFld(convTabFieldRela.TransMissingValue);
}
else if (convTabFieldRela.TransNullValue  ==  _AttributeName[intIndex])
{
mstrTransNullValue = value.ToString();
 AddUpdatedFld(convTabFieldRela.TransNullValue);
}
else if (convTabFieldRela.PrjName  ==  _AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convTabFieldRela.PrjName);
}
else if (convTabFieldRela.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convTabFieldRela.PrjId);
}
else if (convTabFieldRela.PrefixFldName  ==  _AttributeName[intIndex])
{
mstrPrefixFldName = value.ToString();
 AddUpdatedFld(convTabFieldRela.PrefixFldName);
}
else if (convTabFieldRela.Keyword  ==  _AttributeName[intIndex])
{
mstrKeyword = value.ToString();
 AddUpdatedFld(convTabFieldRela.Keyword);
}
else if (convTabFieldRela.TabCnName  ==  _AttributeName[intIndex])
{
mstrTabCnName = value.ToString();
 AddUpdatedFld(convTabFieldRela.TabCnName);
}
else if (convTabFieldRela.TabEnName  ==  _AttributeName[intIndex])
{
mstrTabEnName = value.ToString();
 AddUpdatedFld(convTabFieldRela.TabEnName);
}
else if (convTabFieldRela.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convTabFieldRela.Memo);
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
 AddUpdatedFld(convTabFieldRela.IdFieldTabRela);
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
 AddUpdatedFld(convTabFieldRela.TabId);
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
 AddUpdatedFld(convTabFieldRela.FldId);
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
 AddUpdatedFld(convTabFieldRela.FldName);
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
 AddUpdatedFld(convTabFieldRela.Caption);
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
 AddUpdatedFld(convTabFieldRela.SqlFldName);
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
 AddUpdatedFld(convTabFieldRela.ExcelFieldName);
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
 AddUpdatedFld(convTabFieldRela.IsNeedTrans);
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
 AddUpdatedFld(convTabFieldRela.TransOutFldName);
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
 AddUpdatedFld(convTabFieldRela.TransInFldName);
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
 AddUpdatedFld(convTabFieldRela.PrimaryTypeId);
}
}
/// <summary>
/// 主键类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrimaryTypeName
{
get
{
return mstrPrimaryTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrimaryTypeName = value;
}
else
{
 mstrPrimaryTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabFieldRela.PrimaryTypeName);
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
 AddUpdatedFld(convTabFieldRela.TransTabName);
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
 AddUpdatedFld(convTabFieldRela.IsIdentity);
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
 AddUpdatedFld(convTabFieldRela.IsVisible);
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
 AddUpdatedFld(convTabFieldRela.IsTabPrimary);
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
 AddUpdatedFld(convTabFieldRela.IsTabNullable);
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
 AddUpdatedFld(convTabFieldRela.IsTabUnique);
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
 AddUpdatedFld(convTabFieldRela.DataTypeName);
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
 AddUpdatedFld(convTabFieldRela.SequenceNumber);
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
 AddUpdatedFld(convTabFieldRela.IsNeedCheckPriForeignKey);
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
 AddUpdatedFld(convTabFieldRela.IsTabForeignKey);
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
 AddUpdatedFld(convTabFieldRela.PrimaryKeyFieldName);
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
 AddUpdatedFld(convTabFieldRela.PrimaryKeyTabName);
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
 AddUpdatedFld(convTabFieldRela.DefaultValue);
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
 AddUpdatedFld(convTabFieldRela.TransWayId);
}
}
/// <summary>
/// 转换方式名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TransWayName
{
get
{
return mstrTransWayName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTransWayName = value;
}
else
{
 mstrTransWayName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabFieldRela.TransWayName);
}
}
/// <summary>
/// 字段长度(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? FldLength
{
get
{
return mintFldLength;
}
set
{
 mintFldLength = value;
//记录修改过的字段
 AddUpdatedFld(convTabFieldRela.FldLength);
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
 AddUpdatedFld(convTabFieldRela.TransMissingValue);
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
 AddUpdatedFld(convTabFieldRela.TransNullValue);
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
 AddUpdatedFld(convTabFieldRela.PrjName);
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
 AddUpdatedFld(convTabFieldRela.PrjId);
}
}
/// <summary>
/// 前缀字段名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrefixFldName
{
get
{
return mstrPrefixFldName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrefixFldName = value;
}
else
{
 mstrPrefixFldName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabFieldRela.PrefixFldName);
}
}
/// <summary>
/// 关键字(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Keyword
{
get
{
return mstrKeyword;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeyword = value;
}
else
{
 mstrKeyword = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabFieldRela.Keyword);
}
}
/// <summary>
/// 表中文名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabCnName
{
get
{
return mstrTabCnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabCnName = value;
}
else
{
 mstrTabCnName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabFieldRela.TabCnName);
}
}
/// <summary>
/// 表英文详细名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabEnName
{
get
{
return mstrTabEnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabEnName = value;
}
else
{
 mstrTabEnName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabFieldRela.TabEnName);
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
 AddUpdatedFld(convTabFieldRela.Memo);
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
 /// v表字段关系(vTabFieldRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convTabFieldRela
{
public const string _CurrTabName = "vTabFieldRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdFieldTabRela"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"IdFieldTabRela", "TabId", "FldId", "FldName", "Caption", "SqlFldName", "ExcelFieldName", "IsNeedTrans", "TransOutFldName", "TransInFldName", "PrimaryTypeId", "PrimaryTypeName", "TransTabName", "IsIdentity", "IsVisible", "IsTabPrimary", "IsTabNullable", "IsTabUnique", "DataTypeName", "SequenceNumber", "IsNeedCheckPriForeignKey", "IsTabForeignKey", "PrimaryKeyFieldName", "PrimaryKeyTabName", "DefaultValue", "TransWayId", "TransWayName", "FldLength", "TransMissingValue", "TransNullValue", "PrjName", "PrjId", "PrefixFldName", "Keyword", "TabCnName", "TabEnName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdFieldTabRela"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdFieldTabRela = "IdFieldTabRela";    //字段表关系流水号

 /// <summary>
 /// 常量:"TabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabId = "TabId";    //表ID

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
 /// 常量:"Caption"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Caption = "Caption";    //标题

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
 /// 常量:"IsNeedTrans"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsNeedTrans = "IsNeedTrans";    //是否需要转换

 /// <summary>
 /// 常量:"TransOutFldName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TransOutFldName = "TransOutFldName";    //转换Out字段名

 /// <summary>
 /// 常量:"TransInFldName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TransInFldName = "TransInFldName";    //转换IN字段名

 /// <summary>
 /// 常量:"PrimaryTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrimaryTypeId = "PrimaryTypeId";    //主键类型ID

 /// <summary>
 /// 常量:"PrimaryTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrimaryTypeName = "PrimaryTypeName";    //主键类型名

 /// <summary>
 /// 常量:"TransTabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TransTabName = "TransTabName";    //转换表名

 /// <summary>
 /// 常量:"IsIdentity"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsIdentity = "IsIdentity";    //是否Identity

 /// <summary>
 /// 常量:"IsVisible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVisible = "IsVisible";    //是否显示

 /// <summary>
 /// 常量:"IsTabPrimary"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsTabPrimary = "IsTabPrimary";    //是否作为表中主键

 /// <summary>
 /// 常量:"IsTabNullable"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsTabNullable = "IsTabNullable";    //是否表中可空

 /// <summary>
 /// 常量:"IsTabUnique"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsTabUnique = "IsTabUnique";    //是否表中唯一

 /// <summary>
 /// 常量:"DataTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataTypeName = "DataTypeName";    //数据类型名称

 /// <summary>
 /// 常量:"SequenceNumber"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SequenceNumber = "SequenceNumber";    //顺序号

 /// <summary>
 /// 常量:"IsNeedCheckPriForeignKey"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsNeedCheckPriForeignKey = "IsNeedCheckPriForeignKey";    //是否检查主外键

 /// <summary>
 /// 常量:"IsTabForeignKey"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsTabForeignKey = "IsTabForeignKey";    //是否表外键

 /// <summary>
 /// 常量:"PrimaryKeyFieldName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrimaryKeyFieldName = "PrimaryKeyFieldName";    //主键字段名

 /// <summary>
 /// 常量:"PrimaryKeyTabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrimaryKeyTabName = "PrimaryKeyTabName";    //主键表

 /// <summary>
 /// 常量:"DefaultValue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DefaultValue = "DefaultValue";    //缺省值

 /// <summary>
 /// 常量:"TransWayId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TransWayId = "TransWayId";    //转换方式ID

 /// <summary>
 /// 常量:"TransWayName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TransWayName = "TransWayName";    //转换方式名称

 /// <summary>
 /// 常量:"FldLength"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldLength = "FldLength";    //字段长度

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
 /// 常量:"PrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjName = "PrjName";    //工程名称

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"PrefixFldName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrefixFldName = "PrefixFldName";    //前缀字段名

 /// <summary>
 /// 常量:"Keyword"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Keyword = "Keyword";    //关键字

 /// <summary>
 /// 常量:"TabCnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabCnName = "TabCnName";    //表中文名

 /// <summary>
 /// 常量:"TabEnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabEnName = "TabEnName";    //表英文详细名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}