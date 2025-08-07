
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjTabFldEN
 表名:vPrjTabFld(00050122)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:49:14
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
 /// 表vPrjTabFld的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vPrjTabFld
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngmId">表关键字</param>
public K_mId_vPrjTabFld(long lngmId)
{
if (IsValid(lngmId)) Value = lngmId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngmId)
{
if (lngmId == 0) return false;
if (lngmId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_mId_vPrjTabFld]类型的对象</returns>
public static implicit operator K_mId_vPrjTabFld(long value)
{
return new K_mId_vPrjTabFld(value);
}
}
 /// <summary>
 /// v工程表字段(vPrjTabFld)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvPrjTabFldEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vPrjTabFld"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 42;
public static string[] _AttributeName = new string[] {"mId", "TabId", "TabName", "TabCnName", "PrjName", "SqlDsTypeName", "FuncModuleAgcId", "FuncModuleName", "OrderNum4Refer", "FldId", "OraDbType", "IsNeedTransCode", "FldName", "FldCnName", "Caption", "DataTypeId", "DataTypeName", "FldLength", "FldPrecision", "MaxValue", "MinValue", "DefaultValue", "HomologousFldId", "PrjId", "FieldTypeId", "FieldTypeName", "IsTabNullable", "IsTabUnique", "IsTabForeignKey", "IsSortFld", "IsForExtendClass", "IsParentObj", "PrimaryTypeId", "PrimaryTypeName", "ForeignKeyTabId", "FldOpTypeId", "FldOpTypeName", "SequenceNumber", "MemoInTab", "PrjId4Fld", "PrjName4Fld", "ForeignTabName"};

protected long mlngmId;    //mId
protected string mstrTabId;    //表ID
protected string mstrTabName;    //表名
protected string mstrTabCnName;    //表中文名
protected string mstrPrjName;    //工程名称
protected string mstrSqlDsTypeName;    //Sql数据源名
protected string mstrFuncModuleAgcId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
protected int? mintOrderNum4Refer;    //引用序号
protected string mstrFldId;    //字段Id
protected string mstrOraDbType;    //Ora数据类型
protected bool mbolIsNeedTransCode;    //是否需要转换代码
protected string mstrFldName;    //字段名
protected string mstrFldCnName;    //字段中文详名
protected string mstrCaption;    //标题
protected string mstrDataTypeId;    //数据类型Id
protected string mstrDataTypeName;    //数据类型名称
protected int mintFldLength;    //字段长度
protected int? mintFldPrecision;    //精确度
protected string mstrMaxValue;    //最大值
protected string mstrMinValue;    //最小值
protected string mstrDefaultValue;    //缺省值
protected string mstrHomologousFldId;    //同源字段Id
protected string mstrPrjId;    //工程Id
protected string mstrFieldTypeId;    //字段类型Id
protected string mstrFieldTypeName;    //字段类型名
protected bool mbolIsTabNullable;    //是否表中可空
protected bool mbolIsTabUnique;    //是否表中唯一
protected bool mbolIsTabForeignKey;    //是否表外键
protected bool mbolIsSortFld;    //是否排序字段
protected bool mbolIsForExtendClass;    //用于扩展类
protected bool mbolIsParentObj;    //是否父对象
protected string mstrPrimaryTypeId;    //主键类型ID
protected string mstrPrimaryTypeName;    //主键类型名
protected string mstrForeignKeyTabId;    //外键表ID
protected string mstrFldOpTypeId;    //字段操作类型Id
protected string mstrFldOpTypeName;    //字段操作类型名称
protected int mintSequenceNumber;    //顺序号
protected string mstrMemoInTab;    //表中说明
protected string mstrPrjId4Fld;    //PrjId4Fld
protected string mstrPrjName4Fld;    //PrjName4Fld
protected string mstrForeignTabName;    //外键表

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvPrjTabFldEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:mId</param>
public clsvPrjTabFldEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
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
if (strAttributeName  ==  convPrjTabFld.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convPrjTabFld.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  convPrjTabFld.TabName)
{
return mstrTabName;
}
else if (strAttributeName  ==  convPrjTabFld.TabCnName)
{
return mstrTabCnName;
}
else if (strAttributeName  ==  convPrjTabFld.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convPrjTabFld.SqlDsTypeName)
{
return mstrSqlDsTypeName;
}
else if (strAttributeName  ==  convPrjTabFld.FuncModuleAgcId)
{
return mstrFuncModuleAgcId;
}
else if (strAttributeName  ==  convPrjTabFld.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convPrjTabFld.OrderNum4Refer)
{
return mintOrderNum4Refer;
}
else if (strAttributeName  ==  convPrjTabFld.FldId)
{
return mstrFldId;
}
else if (strAttributeName  ==  convPrjTabFld.OraDbType)
{
return mstrOraDbType;
}
else if (strAttributeName  ==  convPrjTabFld.IsNeedTransCode)
{
return mbolIsNeedTransCode;
}
else if (strAttributeName  ==  convPrjTabFld.FldName)
{
return mstrFldName;
}
else if (strAttributeName  ==  convPrjTabFld.FldCnName)
{
return mstrFldCnName;
}
else if (strAttributeName  ==  convPrjTabFld.Caption)
{
return mstrCaption;
}
else if (strAttributeName  ==  convPrjTabFld.DataTypeId)
{
return mstrDataTypeId;
}
else if (strAttributeName  ==  convPrjTabFld.DataTypeName)
{
return mstrDataTypeName;
}
else if (strAttributeName  ==  convPrjTabFld.FldLength)
{
return mintFldLength;
}
else if (strAttributeName  ==  convPrjTabFld.FldPrecision)
{
return mintFldPrecision;
}
else if (strAttributeName  ==  convPrjTabFld.MaxValue)
{
return mstrMaxValue;
}
else if (strAttributeName  ==  convPrjTabFld.MinValue)
{
return mstrMinValue;
}
else if (strAttributeName  ==  convPrjTabFld.DefaultValue)
{
return mstrDefaultValue;
}
else if (strAttributeName  ==  convPrjTabFld.HomologousFldId)
{
return mstrHomologousFldId;
}
else if (strAttributeName  ==  convPrjTabFld.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convPrjTabFld.FieldTypeId)
{
return mstrFieldTypeId;
}
else if (strAttributeName  ==  convPrjTabFld.FieldTypeName)
{
return mstrFieldTypeName;
}
else if (strAttributeName  ==  convPrjTabFld.IsTabNullable)
{
return mbolIsTabNullable;
}
else if (strAttributeName  ==  convPrjTabFld.IsTabUnique)
{
return mbolIsTabUnique;
}
else if (strAttributeName  ==  convPrjTabFld.IsTabForeignKey)
{
return mbolIsTabForeignKey;
}
else if (strAttributeName  ==  convPrjTabFld.IsSortFld)
{
return mbolIsSortFld;
}
else if (strAttributeName  ==  convPrjTabFld.IsForExtendClass)
{
return mbolIsForExtendClass;
}
else if (strAttributeName  ==  convPrjTabFld.IsParentObj)
{
return mbolIsParentObj;
}
else if (strAttributeName  ==  convPrjTabFld.PrimaryTypeId)
{
return mstrPrimaryTypeId;
}
else if (strAttributeName  ==  convPrjTabFld.PrimaryTypeName)
{
return mstrPrimaryTypeName;
}
else if (strAttributeName  ==  convPrjTabFld.ForeignKeyTabId)
{
return mstrForeignKeyTabId;
}
else if (strAttributeName  ==  convPrjTabFld.FldOpTypeId)
{
return mstrFldOpTypeId;
}
else if (strAttributeName  ==  convPrjTabFld.FldOpTypeName)
{
return mstrFldOpTypeName;
}
else if (strAttributeName  ==  convPrjTabFld.SequenceNumber)
{
return mintSequenceNumber;
}
else if (strAttributeName  ==  convPrjTabFld.MemoInTab)
{
return mstrMemoInTab;
}
else if (strAttributeName  ==  convPrjTabFld.PrjId4Fld)
{
return mstrPrjId4Fld;
}
else if (strAttributeName  ==  convPrjTabFld.PrjName4Fld)
{
return mstrPrjName4Fld;
}
else if (strAttributeName  ==  convPrjTabFld.ForeignTabName)
{
return mstrForeignTabName;
}
return null;
}
set
{
if (strAttributeName  ==  convPrjTabFld.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convPrjTabFld.mId);
}
else if (strAttributeName  ==  convPrjTabFld.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(convPrjTabFld.TabId);
}
else if (strAttributeName  ==  convPrjTabFld.TabName)
{
mstrTabName = value.ToString();
 AddUpdatedFld(convPrjTabFld.TabName);
}
else if (strAttributeName  ==  convPrjTabFld.TabCnName)
{
mstrTabCnName = value.ToString();
 AddUpdatedFld(convPrjTabFld.TabCnName);
}
else if (strAttributeName  ==  convPrjTabFld.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convPrjTabFld.PrjName);
}
else if (strAttributeName  ==  convPrjTabFld.SqlDsTypeName)
{
mstrSqlDsTypeName = value.ToString();
 AddUpdatedFld(convPrjTabFld.SqlDsTypeName);
}
else if (strAttributeName  ==  convPrjTabFld.FuncModuleAgcId)
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convPrjTabFld.FuncModuleAgcId);
}
else if (strAttributeName  ==  convPrjTabFld.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convPrjTabFld.FuncModuleName);
}
else if (strAttributeName  ==  convPrjTabFld.OrderNum4Refer)
{
mintOrderNum4Refer = TransNullToInt(value.ToString());
 AddUpdatedFld(convPrjTabFld.OrderNum4Refer);
}
else if (strAttributeName  ==  convPrjTabFld.FldId)
{
mstrFldId = value.ToString();
 AddUpdatedFld(convPrjTabFld.FldId);
}
else if (strAttributeName  ==  convPrjTabFld.OraDbType)
{
mstrOraDbType = value.ToString();
 AddUpdatedFld(convPrjTabFld.OraDbType);
}
else if (strAttributeName  ==  convPrjTabFld.IsNeedTransCode)
{
mbolIsNeedTransCode = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTabFld.IsNeedTransCode);
}
else if (strAttributeName  ==  convPrjTabFld.FldName)
{
mstrFldName = value.ToString();
 AddUpdatedFld(convPrjTabFld.FldName);
}
else if (strAttributeName  ==  convPrjTabFld.FldCnName)
{
mstrFldCnName = value.ToString();
 AddUpdatedFld(convPrjTabFld.FldCnName);
}
else if (strAttributeName  ==  convPrjTabFld.Caption)
{
mstrCaption = value.ToString();
 AddUpdatedFld(convPrjTabFld.Caption);
}
else if (strAttributeName  ==  convPrjTabFld.DataTypeId)
{
mstrDataTypeId = value.ToString();
 AddUpdatedFld(convPrjTabFld.DataTypeId);
}
else if (strAttributeName  ==  convPrjTabFld.DataTypeName)
{
mstrDataTypeName = value.ToString();
 AddUpdatedFld(convPrjTabFld.DataTypeName);
}
else if (strAttributeName  ==  convPrjTabFld.FldLength)
{
mintFldLength = TransNullToInt(value.ToString());
 AddUpdatedFld(convPrjTabFld.FldLength);
}
else if (strAttributeName  ==  convPrjTabFld.FldPrecision)
{
mintFldPrecision = TransNullToInt(value.ToString());
 AddUpdatedFld(convPrjTabFld.FldPrecision);
}
else if (strAttributeName  ==  convPrjTabFld.MaxValue)
{
mstrMaxValue = value.ToString();
 AddUpdatedFld(convPrjTabFld.MaxValue);
}
else if (strAttributeName  ==  convPrjTabFld.MinValue)
{
mstrMinValue = value.ToString();
 AddUpdatedFld(convPrjTabFld.MinValue);
}
else if (strAttributeName  ==  convPrjTabFld.DefaultValue)
{
mstrDefaultValue = value.ToString();
 AddUpdatedFld(convPrjTabFld.DefaultValue);
}
else if (strAttributeName  ==  convPrjTabFld.HomologousFldId)
{
mstrHomologousFldId = value.ToString();
 AddUpdatedFld(convPrjTabFld.HomologousFldId);
}
else if (strAttributeName  ==  convPrjTabFld.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convPrjTabFld.PrjId);
}
else if (strAttributeName  ==  convPrjTabFld.FieldTypeId)
{
mstrFieldTypeId = value.ToString();
 AddUpdatedFld(convPrjTabFld.FieldTypeId);
}
else if (strAttributeName  ==  convPrjTabFld.FieldTypeName)
{
mstrFieldTypeName = value.ToString();
 AddUpdatedFld(convPrjTabFld.FieldTypeName);
}
else if (strAttributeName  ==  convPrjTabFld.IsTabNullable)
{
mbolIsTabNullable = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTabFld.IsTabNullable);
}
else if (strAttributeName  ==  convPrjTabFld.IsTabUnique)
{
mbolIsTabUnique = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTabFld.IsTabUnique);
}
else if (strAttributeName  ==  convPrjTabFld.IsTabForeignKey)
{
mbolIsTabForeignKey = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTabFld.IsTabForeignKey);
}
else if (strAttributeName  ==  convPrjTabFld.IsSortFld)
{
mbolIsSortFld = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTabFld.IsSortFld);
}
else if (strAttributeName  ==  convPrjTabFld.IsForExtendClass)
{
mbolIsForExtendClass = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTabFld.IsForExtendClass);
}
else if (strAttributeName  ==  convPrjTabFld.IsParentObj)
{
mbolIsParentObj = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTabFld.IsParentObj);
}
else if (strAttributeName  ==  convPrjTabFld.PrimaryTypeId)
{
mstrPrimaryTypeId = value.ToString();
 AddUpdatedFld(convPrjTabFld.PrimaryTypeId);
}
else if (strAttributeName  ==  convPrjTabFld.PrimaryTypeName)
{
mstrPrimaryTypeName = value.ToString();
 AddUpdatedFld(convPrjTabFld.PrimaryTypeName);
}
else if (strAttributeName  ==  convPrjTabFld.ForeignKeyTabId)
{
mstrForeignKeyTabId = value.ToString();
 AddUpdatedFld(convPrjTabFld.ForeignKeyTabId);
}
else if (strAttributeName  ==  convPrjTabFld.FldOpTypeId)
{
mstrFldOpTypeId = value.ToString();
 AddUpdatedFld(convPrjTabFld.FldOpTypeId);
}
else if (strAttributeName  ==  convPrjTabFld.FldOpTypeName)
{
mstrFldOpTypeName = value.ToString();
 AddUpdatedFld(convPrjTabFld.FldOpTypeName);
}
else if (strAttributeName  ==  convPrjTabFld.SequenceNumber)
{
mintSequenceNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convPrjTabFld.SequenceNumber);
}
else if (strAttributeName  ==  convPrjTabFld.MemoInTab)
{
mstrMemoInTab = value.ToString();
 AddUpdatedFld(convPrjTabFld.MemoInTab);
}
else if (strAttributeName  ==  convPrjTabFld.PrjId4Fld)
{
mstrPrjId4Fld = value.ToString();
 AddUpdatedFld(convPrjTabFld.PrjId4Fld);
}
else if (strAttributeName  ==  convPrjTabFld.PrjName4Fld)
{
mstrPrjName4Fld = value.ToString();
 AddUpdatedFld(convPrjTabFld.PrjName4Fld);
}
else if (strAttributeName  ==  convPrjTabFld.ForeignTabName)
{
mstrForeignTabName = value.ToString();
 AddUpdatedFld(convPrjTabFld.ForeignTabName);
}
}
}
public object this[int intIndex]
{
get
{
if (convPrjTabFld.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (convPrjTabFld.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (convPrjTabFld.TabName  ==  _AttributeName[intIndex])
{
return mstrTabName;
}
else if (convPrjTabFld.TabCnName  ==  _AttributeName[intIndex])
{
return mstrTabCnName;
}
else if (convPrjTabFld.PrjName  ==  _AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convPrjTabFld.SqlDsTypeName  ==  _AttributeName[intIndex])
{
return mstrSqlDsTypeName;
}
else if (convPrjTabFld.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
return mstrFuncModuleAgcId;
}
else if (convPrjTabFld.FuncModuleName  ==  _AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convPrjTabFld.OrderNum4Refer  ==  _AttributeName[intIndex])
{
return mintOrderNum4Refer;
}
else if (convPrjTabFld.FldId  ==  _AttributeName[intIndex])
{
return mstrFldId;
}
else if (convPrjTabFld.OraDbType  ==  _AttributeName[intIndex])
{
return mstrOraDbType;
}
else if (convPrjTabFld.IsNeedTransCode  ==  _AttributeName[intIndex])
{
return mbolIsNeedTransCode;
}
else if (convPrjTabFld.FldName  ==  _AttributeName[intIndex])
{
return mstrFldName;
}
else if (convPrjTabFld.FldCnName  ==  _AttributeName[intIndex])
{
return mstrFldCnName;
}
else if (convPrjTabFld.Caption  ==  _AttributeName[intIndex])
{
return mstrCaption;
}
else if (convPrjTabFld.DataTypeId  ==  _AttributeName[intIndex])
{
return mstrDataTypeId;
}
else if (convPrjTabFld.DataTypeName  ==  _AttributeName[intIndex])
{
return mstrDataTypeName;
}
else if (convPrjTabFld.FldLength  ==  _AttributeName[intIndex])
{
return mintFldLength;
}
else if (convPrjTabFld.FldPrecision  ==  _AttributeName[intIndex])
{
return mintFldPrecision;
}
else if (convPrjTabFld.MaxValue  ==  _AttributeName[intIndex])
{
return mstrMaxValue;
}
else if (convPrjTabFld.MinValue  ==  _AttributeName[intIndex])
{
return mstrMinValue;
}
else if (convPrjTabFld.DefaultValue  ==  _AttributeName[intIndex])
{
return mstrDefaultValue;
}
else if (convPrjTabFld.HomologousFldId  ==  _AttributeName[intIndex])
{
return mstrHomologousFldId;
}
else if (convPrjTabFld.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convPrjTabFld.FieldTypeId  ==  _AttributeName[intIndex])
{
return mstrFieldTypeId;
}
else if (convPrjTabFld.FieldTypeName  ==  _AttributeName[intIndex])
{
return mstrFieldTypeName;
}
else if (convPrjTabFld.IsTabNullable  ==  _AttributeName[intIndex])
{
return mbolIsTabNullable;
}
else if (convPrjTabFld.IsTabUnique  ==  _AttributeName[intIndex])
{
return mbolIsTabUnique;
}
else if (convPrjTabFld.IsTabForeignKey  ==  _AttributeName[intIndex])
{
return mbolIsTabForeignKey;
}
else if (convPrjTabFld.IsSortFld  ==  _AttributeName[intIndex])
{
return mbolIsSortFld;
}
else if (convPrjTabFld.IsForExtendClass  ==  _AttributeName[intIndex])
{
return mbolIsForExtendClass;
}
else if (convPrjTabFld.IsParentObj  ==  _AttributeName[intIndex])
{
return mbolIsParentObj;
}
else if (convPrjTabFld.PrimaryTypeId  ==  _AttributeName[intIndex])
{
return mstrPrimaryTypeId;
}
else if (convPrjTabFld.PrimaryTypeName  ==  _AttributeName[intIndex])
{
return mstrPrimaryTypeName;
}
else if (convPrjTabFld.ForeignKeyTabId  ==  _AttributeName[intIndex])
{
return mstrForeignKeyTabId;
}
else if (convPrjTabFld.FldOpTypeId  ==  _AttributeName[intIndex])
{
return mstrFldOpTypeId;
}
else if (convPrjTabFld.FldOpTypeName  ==  _AttributeName[intIndex])
{
return mstrFldOpTypeName;
}
else if (convPrjTabFld.SequenceNumber  ==  _AttributeName[intIndex])
{
return mintSequenceNumber;
}
else if (convPrjTabFld.MemoInTab  ==  _AttributeName[intIndex])
{
return mstrMemoInTab;
}
else if (convPrjTabFld.PrjId4Fld  ==  _AttributeName[intIndex])
{
return mstrPrjId4Fld;
}
else if (convPrjTabFld.PrjName4Fld  ==  _AttributeName[intIndex])
{
return mstrPrjName4Fld;
}
else if (convPrjTabFld.ForeignTabName  ==  _AttributeName[intIndex])
{
return mstrForeignTabName;
}
return null;
}
set
{
if (convPrjTabFld.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convPrjTabFld.mId);
}
else if (convPrjTabFld.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(convPrjTabFld.TabId);
}
else if (convPrjTabFld.TabName  ==  _AttributeName[intIndex])
{
mstrTabName = value.ToString();
 AddUpdatedFld(convPrjTabFld.TabName);
}
else if (convPrjTabFld.TabCnName  ==  _AttributeName[intIndex])
{
mstrTabCnName = value.ToString();
 AddUpdatedFld(convPrjTabFld.TabCnName);
}
else if (convPrjTabFld.PrjName  ==  _AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convPrjTabFld.PrjName);
}
else if (convPrjTabFld.SqlDsTypeName  ==  _AttributeName[intIndex])
{
mstrSqlDsTypeName = value.ToString();
 AddUpdatedFld(convPrjTabFld.SqlDsTypeName);
}
else if (convPrjTabFld.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convPrjTabFld.FuncModuleAgcId);
}
else if (convPrjTabFld.FuncModuleName  ==  _AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convPrjTabFld.FuncModuleName);
}
else if (convPrjTabFld.OrderNum4Refer  ==  _AttributeName[intIndex])
{
mintOrderNum4Refer = TransNullToInt(value.ToString());
 AddUpdatedFld(convPrjTabFld.OrderNum4Refer);
}
else if (convPrjTabFld.FldId  ==  _AttributeName[intIndex])
{
mstrFldId = value.ToString();
 AddUpdatedFld(convPrjTabFld.FldId);
}
else if (convPrjTabFld.OraDbType  ==  _AttributeName[intIndex])
{
mstrOraDbType = value.ToString();
 AddUpdatedFld(convPrjTabFld.OraDbType);
}
else if (convPrjTabFld.IsNeedTransCode  ==  _AttributeName[intIndex])
{
mbolIsNeedTransCode = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTabFld.IsNeedTransCode);
}
else if (convPrjTabFld.FldName  ==  _AttributeName[intIndex])
{
mstrFldName = value.ToString();
 AddUpdatedFld(convPrjTabFld.FldName);
}
else if (convPrjTabFld.FldCnName  ==  _AttributeName[intIndex])
{
mstrFldCnName = value.ToString();
 AddUpdatedFld(convPrjTabFld.FldCnName);
}
else if (convPrjTabFld.Caption  ==  _AttributeName[intIndex])
{
mstrCaption = value.ToString();
 AddUpdatedFld(convPrjTabFld.Caption);
}
else if (convPrjTabFld.DataTypeId  ==  _AttributeName[intIndex])
{
mstrDataTypeId = value.ToString();
 AddUpdatedFld(convPrjTabFld.DataTypeId);
}
else if (convPrjTabFld.DataTypeName  ==  _AttributeName[intIndex])
{
mstrDataTypeName = value.ToString();
 AddUpdatedFld(convPrjTabFld.DataTypeName);
}
else if (convPrjTabFld.FldLength  ==  _AttributeName[intIndex])
{
mintFldLength = TransNullToInt(value.ToString());
 AddUpdatedFld(convPrjTabFld.FldLength);
}
else if (convPrjTabFld.FldPrecision  ==  _AttributeName[intIndex])
{
mintFldPrecision = TransNullToInt(value.ToString());
 AddUpdatedFld(convPrjTabFld.FldPrecision);
}
else if (convPrjTabFld.MaxValue  ==  _AttributeName[intIndex])
{
mstrMaxValue = value.ToString();
 AddUpdatedFld(convPrjTabFld.MaxValue);
}
else if (convPrjTabFld.MinValue  ==  _AttributeName[intIndex])
{
mstrMinValue = value.ToString();
 AddUpdatedFld(convPrjTabFld.MinValue);
}
else if (convPrjTabFld.DefaultValue  ==  _AttributeName[intIndex])
{
mstrDefaultValue = value.ToString();
 AddUpdatedFld(convPrjTabFld.DefaultValue);
}
else if (convPrjTabFld.HomologousFldId  ==  _AttributeName[intIndex])
{
mstrHomologousFldId = value.ToString();
 AddUpdatedFld(convPrjTabFld.HomologousFldId);
}
else if (convPrjTabFld.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convPrjTabFld.PrjId);
}
else if (convPrjTabFld.FieldTypeId  ==  _AttributeName[intIndex])
{
mstrFieldTypeId = value.ToString();
 AddUpdatedFld(convPrjTabFld.FieldTypeId);
}
else if (convPrjTabFld.FieldTypeName  ==  _AttributeName[intIndex])
{
mstrFieldTypeName = value.ToString();
 AddUpdatedFld(convPrjTabFld.FieldTypeName);
}
else if (convPrjTabFld.IsTabNullable  ==  _AttributeName[intIndex])
{
mbolIsTabNullable = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTabFld.IsTabNullable);
}
else if (convPrjTabFld.IsTabUnique  ==  _AttributeName[intIndex])
{
mbolIsTabUnique = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTabFld.IsTabUnique);
}
else if (convPrjTabFld.IsTabForeignKey  ==  _AttributeName[intIndex])
{
mbolIsTabForeignKey = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTabFld.IsTabForeignKey);
}
else if (convPrjTabFld.IsSortFld  ==  _AttributeName[intIndex])
{
mbolIsSortFld = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTabFld.IsSortFld);
}
else if (convPrjTabFld.IsForExtendClass  ==  _AttributeName[intIndex])
{
mbolIsForExtendClass = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTabFld.IsForExtendClass);
}
else if (convPrjTabFld.IsParentObj  ==  _AttributeName[intIndex])
{
mbolIsParentObj = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTabFld.IsParentObj);
}
else if (convPrjTabFld.PrimaryTypeId  ==  _AttributeName[intIndex])
{
mstrPrimaryTypeId = value.ToString();
 AddUpdatedFld(convPrjTabFld.PrimaryTypeId);
}
else if (convPrjTabFld.PrimaryTypeName  ==  _AttributeName[intIndex])
{
mstrPrimaryTypeName = value.ToString();
 AddUpdatedFld(convPrjTabFld.PrimaryTypeName);
}
else if (convPrjTabFld.ForeignKeyTabId  ==  _AttributeName[intIndex])
{
mstrForeignKeyTabId = value.ToString();
 AddUpdatedFld(convPrjTabFld.ForeignKeyTabId);
}
else if (convPrjTabFld.FldOpTypeId  ==  _AttributeName[intIndex])
{
mstrFldOpTypeId = value.ToString();
 AddUpdatedFld(convPrjTabFld.FldOpTypeId);
}
else if (convPrjTabFld.FldOpTypeName  ==  _AttributeName[intIndex])
{
mstrFldOpTypeName = value.ToString();
 AddUpdatedFld(convPrjTabFld.FldOpTypeName);
}
else if (convPrjTabFld.SequenceNumber  ==  _AttributeName[intIndex])
{
mintSequenceNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convPrjTabFld.SequenceNumber);
}
else if (convPrjTabFld.MemoInTab  ==  _AttributeName[intIndex])
{
mstrMemoInTab = value.ToString();
 AddUpdatedFld(convPrjTabFld.MemoInTab);
}
else if (convPrjTabFld.PrjId4Fld  ==  _AttributeName[intIndex])
{
mstrPrjId4Fld = value.ToString();
 AddUpdatedFld(convPrjTabFld.PrjId4Fld);
}
else if (convPrjTabFld.PrjName4Fld  ==  _AttributeName[intIndex])
{
mstrPrjName4Fld = value.ToString();
 AddUpdatedFld(convPrjTabFld.PrjName4Fld);
}
else if (convPrjTabFld.ForeignTabName  ==  _AttributeName[intIndex])
{
mstrForeignTabName = value.ToString();
 AddUpdatedFld(convPrjTabFld.ForeignTabName);
}
}
}

/// <summary>
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long mId
{
get
{
return mlngmId;
}
set
{
 mlngmId = value;
//记录修改过的字段
 AddUpdatedFld(convPrjTabFld.mId);
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
 AddUpdatedFld(convPrjTabFld.TabId);
}
}
/// <summary>
/// 表名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabName
{
get
{
return mstrTabName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabName = value;
}
else
{
 mstrTabName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjTabFld.TabName);
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
 AddUpdatedFld(convPrjTabFld.TabCnName);
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
 AddUpdatedFld(convPrjTabFld.PrjName);
}
}
/// <summary>
/// Sql数据源名(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SqlDsTypeName
{
get
{
return mstrSqlDsTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSqlDsTypeName = value;
}
else
{
 mstrSqlDsTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjTabFld.SqlDsTypeName);
}
}
/// <summary>
/// 功能模块Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleAgcId
{
get
{
return mstrFuncModuleAgcId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleAgcId = value;
}
else
{
 mstrFuncModuleAgcId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjTabFld.FuncModuleAgcId);
}
}
/// <summary>
/// 功能模块名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleName
{
get
{
return mstrFuncModuleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleName = value;
}
else
{
 mstrFuncModuleName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjTabFld.FuncModuleName);
}
}
/// <summary>
/// 引用序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OrderNum4Refer
{
get
{
return mintOrderNum4Refer;
}
set
{
 mintOrderNum4Refer = value;
//记录修改过的字段
 AddUpdatedFld(convPrjTabFld.OrderNum4Refer);
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
 AddUpdatedFld(convPrjTabFld.FldId);
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
 AddUpdatedFld(convPrjTabFld.OraDbType);
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
 AddUpdatedFld(convPrjTabFld.IsNeedTransCode);
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
 AddUpdatedFld(convPrjTabFld.FldName);
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
 AddUpdatedFld(convPrjTabFld.FldCnName);
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
 AddUpdatedFld(convPrjTabFld.Caption);
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
 AddUpdatedFld(convPrjTabFld.DataTypeId);
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
 AddUpdatedFld(convPrjTabFld.DataTypeName);
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
 AddUpdatedFld(convPrjTabFld.FldLength);
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
 AddUpdatedFld(convPrjTabFld.FldPrecision);
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
 AddUpdatedFld(convPrjTabFld.MaxValue);
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
 AddUpdatedFld(convPrjTabFld.MinValue);
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
 AddUpdatedFld(convPrjTabFld.DefaultValue);
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
 AddUpdatedFld(convPrjTabFld.HomologousFldId);
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
 AddUpdatedFld(convPrjTabFld.PrjId);
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
 AddUpdatedFld(convPrjTabFld.FieldTypeId);
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
 AddUpdatedFld(convPrjTabFld.FieldTypeName);
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
 AddUpdatedFld(convPrjTabFld.IsTabNullable);
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
 AddUpdatedFld(convPrjTabFld.IsTabUnique);
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
 AddUpdatedFld(convPrjTabFld.IsTabForeignKey);
}
}
/// <summary>
/// 是否排序字段(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsSortFld
{
get
{
return mbolIsSortFld;
}
set
{
 mbolIsSortFld = value;
//记录修改过的字段
 AddUpdatedFld(convPrjTabFld.IsSortFld);
}
}
/// <summary>
/// 用于扩展类(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsForExtendClass
{
get
{
return mbolIsForExtendClass;
}
set
{
 mbolIsForExtendClass = value;
//记录修改过的字段
 AddUpdatedFld(convPrjTabFld.IsForExtendClass);
}
}
/// <summary>
/// 是否父对象(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsParentObj
{
get
{
return mbolIsParentObj;
}
set
{
 mbolIsParentObj = value;
//记录修改过的字段
 AddUpdatedFld(convPrjTabFld.IsParentObj);
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
 AddUpdatedFld(convPrjTabFld.PrimaryTypeId);
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
 AddUpdatedFld(convPrjTabFld.PrimaryTypeName);
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
 AddUpdatedFld(convPrjTabFld.ForeignKeyTabId);
}
}
/// <summary>
/// 字段操作类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FldOpTypeId
{
get
{
return mstrFldOpTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldOpTypeId = value;
}
else
{
 mstrFldOpTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjTabFld.FldOpTypeId);
}
}
/// <summary>
/// 字段操作类型名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FldOpTypeName
{
get
{
return mstrFldOpTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldOpTypeName = value;
}
else
{
 mstrFldOpTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjTabFld.FldOpTypeName);
}
}
/// <summary>
/// 顺序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int SequenceNumber
{
get
{
return mintSequenceNumber;
}
set
{
 mintSequenceNumber = value;
//记录修改过的字段
 AddUpdatedFld(convPrjTabFld.SequenceNumber);
}
}
/// <summary>
/// 表中说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MemoInTab
{
get
{
return mstrMemoInTab;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMemoInTab = value;
}
else
{
 mstrMemoInTab = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjTabFld.MemoInTab);
}
}
/// <summary>
/// PrjId4Fld(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjId4Fld
{
get
{
return mstrPrjId4Fld;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjId4Fld = value;
}
else
{
 mstrPrjId4Fld = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjTabFld.PrjId4Fld);
}
}
/// <summary>
/// PrjName4Fld(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjName4Fld
{
get
{
return mstrPrjName4Fld;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjName4Fld = value;
}
else
{
 mstrPrjName4Fld = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjTabFld.PrjName4Fld);
}
}
/// <summary>
/// 外键表(说明:;字段类型:varchar;字段长度:40;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ForeignTabName
{
get
{
return mstrForeignTabName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrForeignTabName = value;
}
else
{
 mstrForeignTabName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjTabFld.ForeignTabName);
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
  return mlngmId.ToString();
 }
 }
}
 /// <summary>
 /// v工程表字段(vPrjTabFld)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convPrjTabFld
{
public const string _CurrTabName = "vPrjTabFld"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "TabId", "TabName", "TabCnName", "PrjName", "SqlDsTypeName", "FuncModuleAgcId", "FuncModuleName", "OrderNum4Refer", "FldId", "OraDbType", "IsNeedTransCode", "FldName", "FldCnName", "Caption", "DataTypeId", "DataTypeName", "FldLength", "FldPrecision", "MaxValue", "MinValue", "DefaultValue", "HomologousFldId", "PrjId", "FieldTypeId", "FieldTypeName", "IsTabNullable", "IsTabUnique", "IsTabForeignKey", "IsSortFld", "IsForExtendClass", "IsParentObj", "PrimaryTypeId", "PrimaryTypeName", "ForeignKeyTabId", "FldOpTypeId", "FldOpTypeName", "SequenceNumber", "MemoInTab", "PrjId4Fld", "PrjName4Fld", "ForeignTabName"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"TabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabId = "TabId";    //表ID

 /// <summary>
 /// 常量:"TabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabName = "TabName";    //表名

 /// <summary>
 /// 常量:"TabCnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabCnName = "TabCnName";    //表中文名

 /// <summary>
 /// 常量:"PrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjName = "PrjName";    //工程名称

 /// <summary>
 /// 常量:"SqlDsTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SqlDsTypeName = "SqlDsTypeName";    //Sql数据源名

 /// <summary>
 /// 常量:"FuncModuleAgcId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleAgcId = "FuncModuleAgcId";    //功能模块Id

 /// <summary>
 /// 常量:"FuncModuleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleName = "FuncModuleName";    //功能模块名称

 /// <summary>
 /// 常量:"OrderNum4Refer"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum4Refer = "OrderNum4Refer";    //引用序号

 /// <summary>
 /// 常量:"FldId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldId = "FldId";    //字段Id

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
 /// 常量:"FieldTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FieldTypeId = "FieldTypeId";    //字段类型Id

 /// <summary>
 /// 常量:"FieldTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FieldTypeName = "FieldTypeName";    //字段类型名

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
 /// 常量:"IsTabForeignKey"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsTabForeignKey = "IsTabForeignKey";    //是否表外键

 /// <summary>
 /// 常量:"IsSortFld"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSortFld = "IsSortFld";    //是否排序字段

 /// <summary>
 /// 常量:"IsForExtendClass"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsForExtendClass = "IsForExtendClass";    //用于扩展类

 /// <summary>
 /// 常量:"IsParentObj"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsParentObj = "IsParentObj";    //是否父对象

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
 /// 常量:"ForeignKeyTabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ForeignKeyTabId = "ForeignKeyTabId";    //外键表ID

 /// <summary>
 /// 常量:"FldOpTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldOpTypeId = "FldOpTypeId";    //字段操作类型Id

 /// <summary>
 /// 常量:"FldOpTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldOpTypeName = "FldOpTypeName";    //字段操作类型名称

 /// <summary>
 /// 常量:"SequenceNumber"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SequenceNumber = "SequenceNumber";    //顺序号

 /// <summary>
 /// 常量:"MemoInTab"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MemoInTab = "MemoInTab";    //表中说明

 /// <summary>
 /// 常量:"PrjId4Fld"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId4Fld = "PrjId4Fld";    //PrjId4Fld

 /// <summary>
 /// 常量:"PrjName4Fld"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjName4Fld = "PrjName4Fld";    //PrjName4Fld

 /// <summary>
 /// 常量:"ForeignTabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ForeignTabName = "ForeignTabName";    //外键表
}

}