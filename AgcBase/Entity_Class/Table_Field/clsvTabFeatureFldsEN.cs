
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTabFeatureFldsEN
 表名:vTabFeatureFlds(00050456)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:12:02
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
 /// 表vTabFeatureFlds的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vTabFeatureFlds
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
public K_mId_vTabFeatureFlds(long lngmId)
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
 /// <returns>返回:[K_mId_vTabFeatureFlds]类型的对象</returns>
public static implicit operator K_mId_vTabFeatureFlds(long value)
{
return new K_mId_vTabFeatureFlds(value);
}
}
 /// <summary>
 /// v表功能字段(vTabFeatureFlds)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvTabFeatureFldsEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vTabFeatureFlds"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 33;
public static string[] _AttributeName = new string[] {"mId", "TabFeatureId", "TabFeatureName", "TabId", "TabName", "TabCnName", "PrjName", "SqlDsTypeName", "FuncModuleAgcId", "FuncModuleName", "OrderNum4Refer", "FeatureId", "FeatureName", "ParentFeatureId", "ParentFeatureName", "FldId", "FldName", "Caption", "DataTypeId", "DataTypeName", "IsNull", "FieldTypeId", "FieldTypeName", "FuncName", "ValueGivingModeId", "ValueGivingModeName", "DefaultValue", "PrjId", "OrderNum", "InUse", "UpdUser", "UpdDate", "Memo"};

protected long mlngmId;    //mId
protected string mstrTabFeatureId;    //表功能Id
protected string mstrTabFeatureName;    //表功能名
protected string mstrTabId;    //表ID
protected string mstrTabName;    //表名
protected string mstrTabCnName;    //表中文名
protected string mstrPrjName;    //工程名称
protected string mstrSqlDsTypeName;    //Sql数据源名
protected string mstrFuncModuleAgcId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
protected int? mintOrderNum4Refer;    //引用序号
protected string mstrFeatureId;    //功能Id
protected string mstrFeatureName;    //功能名称
protected string mstrParentFeatureId;    //父功能Id
protected string mstrParentFeatureName;    //父功能名
protected string mstrFldId;    //字段Id
protected string mstrFldName;    //字段名
protected string mstrCaption;    //标题
protected string mstrDataTypeId;    //数据类型Id
protected string mstrDataTypeName;    //数据类型名称
protected bool mbolIsNull;    //是否可空
protected string mstrFieldTypeId;    //字段类型Id
protected string mstrFieldTypeName;    //字段类型名
protected string mstrFuncName;    //函数名
protected string mstrValueGivingModeId;    //给值方式Id
protected string mstrValueGivingModeName;    //给值方式名
protected string mstrDefaultValue;    //缺省值
protected string mstrPrjId;    //工程Id
protected int mintOrderNum;    //序号
protected bool mbolInUse;    //是否在用
protected string mstrUpdUser;    //修改者
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvTabFeatureFldsEN()
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
public clsvTabFeatureFldsEN(long lngmId)
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
if (strAttributeName  ==  convTabFeatureFlds.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convTabFeatureFlds.TabFeatureId)
{
return mstrTabFeatureId;
}
else if (strAttributeName  ==  convTabFeatureFlds.TabFeatureName)
{
return mstrTabFeatureName;
}
else if (strAttributeName  ==  convTabFeatureFlds.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  convTabFeatureFlds.TabName)
{
return mstrTabName;
}
else if (strAttributeName  ==  convTabFeatureFlds.TabCnName)
{
return mstrTabCnName;
}
else if (strAttributeName  ==  convTabFeatureFlds.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convTabFeatureFlds.SqlDsTypeName)
{
return mstrSqlDsTypeName;
}
else if (strAttributeName  ==  convTabFeatureFlds.FuncModuleAgcId)
{
return mstrFuncModuleAgcId;
}
else if (strAttributeName  ==  convTabFeatureFlds.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convTabFeatureFlds.OrderNum4Refer)
{
return mintOrderNum4Refer;
}
else if (strAttributeName  ==  convTabFeatureFlds.FeatureId)
{
return mstrFeatureId;
}
else if (strAttributeName  ==  convTabFeatureFlds.FeatureName)
{
return mstrFeatureName;
}
else if (strAttributeName  ==  convTabFeatureFlds.ParentFeatureId)
{
return mstrParentFeatureId;
}
else if (strAttributeName  ==  convTabFeatureFlds.ParentFeatureName)
{
return mstrParentFeatureName;
}
else if (strAttributeName  ==  convTabFeatureFlds.FldId)
{
return mstrFldId;
}
else if (strAttributeName  ==  convTabFeatureFlds.FldName)
{
return mstrFldName;
}
else if (strAttributeName  ==  convTabFeatureFlds.Caption)
{
return mstrCaption;
}
else if (strAttributeName  ==  convTabFeatureFlds.DataTypeId)
{
return mstrDataTypeId;
}
else if (strAttributeName  ==  convTabFeatureFlds.DataTypeName)
{
return mstrDataTypeName;
}
else if (strAttributeName  ==  convTabFeatureFlds.IsNull)
{
return mbolIsNull;
}
else if (strAttributeName  ==  convTabFeatureFlds.FieldTypeId)
{
return mstrFieldTypeId;
}
else if (strAttributeName  ==  convTabFeatureFlds.FieldTypeName)
{
return mstrFieldTypeName;
}
else if (strAttributeName  ==  convTabFeatureFlds.FuncName)
{
return mstrFuncName;
}
else if (strAttributeName  ==  convTabFeatureFlds.ValueGivingModeId)
{
return mstrValueGivingModeId;
}
else if (strAttributeName  ==  convTabFeatureFlds.ValueGivingModeName)
{
return mstrValueGivingModeName;
}
else if (strAttributeName  ==  convTabFeatureFlds.DefaultValue)
{
return mstrDefaultValue;
}
else if (strAttributeName  ==  convTabFeatureFlds.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convTabFeatureFlds.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convTabFeatureFlds.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  convTabFeatureFlds.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convTabFeatureFlds.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convTabFeatureFlds.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convTabFeatureFlds.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convTabFeatureFlds.mId);
}
else if (strAttributeName  ==  convTabFeatureFlds.TabFeatureId)
{
mstrTabFeatureId = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.TabFeatureId);
}
else if (strAttributeName  ==  convTabFeatureFlds.TabFeatureName)
{
mstrTabFeatureName = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.TabFeatureName);
}
else if (strAttributeName  ==  convTabFeatureFlds.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.TabId);
}
else if (strAttributeName  ==  convTabFeatureFlds.TabName)
{
mstrTabName = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.TabName);
}
else if (strAttributeName  ==  convTabFeatureFlds.TabCnName)
{
mstrTabCnName = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.TabCnName);
}
else if (strAttributeName  ==  convTabFeatureFlds.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.PrjName);
}
else if (strAttributeName  ==  convTabFeatureFlds.SqlDsTypeName)
{
mstrSqlDsTypeName = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.SqlDsTypeName);
}
else if (strAttributeName  ==  convTabFeatureFlds.FuncModuleAgcId)
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.FuncModuleAgcId);
}
else if (strAttributeName  ==  convTabFeatureFlds.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.FuncModuleName);
}
else if (strAttributeName  ==  convTabFeatureFlds.OrderNum4Refer)
{
mintOrderNum4Refer = TransNullToInt(value.ToString());
 AddUpdatedFld(convTabFeatureFlds.OrderNum4Refer);
}
else if (strAttributeName  ==  convTabFeatureFlds.FeatureId)
{
mstrFeatureId = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.FeatureId);
}
else if (strAttributeName  ==  convTabFeatureFlds.FeatureName)
{
mstrFeatureName = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.FeatureName);
}
else if (strAttributeName  ==  convTabFeatureFlds.ParentFeatureId)
{
mstrParentFeatureId = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.ParentFeatureId);
}
else if (strAttributeName  ==  convTabFeatureFlds.ParentFeatureName)
{
mstrParentFeatureName = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.ParentFeatureName);
}
else if (strAttributeName  ==  convTabFeatureFlds.FldId)
{
mstrFldId = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.FldId);
}
else if (strAttributeName  ==  convTabFeatureFlds.FldName)
{
mstrFldName = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.FldName);
}
else if (strAttributeName  ==  convTabFeatureFlds.Caption)
{
mstrCaption = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.Caption);
}
else if (strAttributeName  ==  convTabFeatureFlds.DataTypeId)
{
mstrDataTypeId = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.DataTypeId);
}
else if (strAttributeName  ==  convTabFeatureFlds.DataTypeName)
{
mstrDataTypeName = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.DataTypeName);
}
else if (strAttributeName  ==  convTabFeatureFlds.IsNull)
{
mbolIsNull = TransNullToBool(value.ToString());
 AddUpdatedFld(convTabFeatureFlds.IsNull);
}
else if (strAttributeName  ==  convTabFeatureFlds.FieldTypeId)
{
mstrFieldTypeId = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.FieldTypeId);
}
else if (strAttributeName  ==  convTabFeatureFlds.FieldTypeName)
{
mstrFieldTypeName = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.FieldTypeName);
}
else if (strAttributeName  ==  convTabFeatureFlds.FuncName)
{
mstrFuncName = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.FuncName);
}
else if (strAttributeName  ==  convTabFeatureFlds.ValueGivingModeId)
{
mstrValueGivingModeId = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.ValueGivingModeId);
}
else if (strAttributeName  ==  convTabFeatureFlds.ValueGivingModeName)
{
mstrValueGivingModeName = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.ValueGivingModeName);
}
else if (strAttributeName  ==  convTabFeatureFlds.DefaultValue)
{
mstrDefaultValue = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.DefaultValue);
}
else if (strAttributeName  ==  convTabFeatureFlds.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.PrjId);
}
else if (strAttributeName  ==  convTabFeatureFlds.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convTabFeatureFlds.OrderNum);
}
else if (strAttributeName  ==  convTabFeatureFlds.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convTabFeatureFlds.InUse);
}
else if (strAttributeName  ==  convTabFeatureFlds.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.UpdUser);
}
else if (strAttributeName  ==  convTabFeatureFlds.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.UpdDate);
}
else if (strAttributeName  ==  convTabFeatureFlds.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convTabFeatureFlds.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (convTabFeatureFlds.TabFeatureId  ==  _AttributeName[intIndex])
{
return mstrTabFeatureId;
}
else if (convTabFeatureFlds.TabFeatureName  ==  _AttributeName[intIndex])
{
return mstrTabFeatureName;
}
else if (convTabFeatureFlds.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (convTabFeatureFlds.TabName  ==  _AttributeName[intIndex])
{
return mstrTabName;
}
else if (convTabFeatureFlds.TabCnName  ==  _AttributeName[intIndex])
{
return mstrTabCnName;
}
else if (convTabFeatureFlds.PrjName  ==  _AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convTabFeatureFlds.SqlDsTypeName  ==  _AttributeName[intIndex])
{
return mstrSqlDsTypeName;
}
else if (convTabFeatureFlds.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
return mstrFuncModuleAgcId;
}
else if (convTabFeatureFlds.FuncModuleName  ==  _AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convTabFeatureFlds.OrderNum4Refer  ==  _AttributeName[intIndex])
{
return mintOrderNum4Refer;
}
else if (convTabFeatureFlds.FeatureId  ==  _AttributeName[intIndex])
{
return mstrFeatureId;
}
else if (convTabFeatureFlds.FeatureName  ==  _AttributeName[intIndex])
{
return mstrFeatureName;
}
else if (convTabFeatureFlds.ParentFeatureId  ==  _AttributeName[intIndex])
{
return mstrParentFeatureId;
}
else if (convTabFeatureFlds.ParentFeatureName  ==  _AttributeName[intIndex])
{
return mstrParentFeatureName;
}
else if (convTabFeatureFlds.FldId  ==  _AttributeName[intIndex])
{
return mstrFldId;
}
else if (convTabFeatureFlds.FldName  ==  _AttributeName[intIndex])
{
return mstrFldName;
}
else if (convTabFeatureFlds.Caption  ==  _AttributeName[intIndex])
{
return mstrCaption;
}
else if (convTabFeatureFlds.DataTypeId  ==  _AttributeName[intIndex])
{
return mstrDataTypeId;
}
else if (convTabFeatureFlds.DataTypeName  ==  _AttributeName[intIndex])
{
return mstrDataTypeName;
}
else if (convTabFeatureFlds.IsNull  ==  _AttributeName[intIndex])
{
return mbolIsNull;
}
else if (convTabFeatureFlds.FieldTypeId  ==  _AttributeName[intIndex])
{
return mstrFieldTypeId;
}
else if (convTabFeatureFlds.FieldTypeName  ==  _AttributeName[intIndex])
{
return mstrFieldTypeName;
}
else if (convTabFeatureFlds.FuncName  ==  _AttributeName[intIndex])
{
return mstrFuncName;
}
else if (convTabFeatureFlds.ValueGivingModeId  ==  _AttributeName[intIndex])
{
return mstrValueGivingModeId;
}
else if (convTabFeatureFlds.ValueGivingModeName  ==  _AttributeName[intIndex])
{
return mstrValueGivingModeName;
}
else if (convTabFeatureFlds.DefaultValue  ==  _AttributeName[intIndex])
{
return mstrDefaultValue;
}
else if (convTabFeatureFlds.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convTabFeatureFlds.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convTabFeatureFlds.InUse  ==  _AttributeName[intIndex])
{
return mbolInUse;
}
else if (convTabFeatureFlds.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convTabFeatureFlds.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convTabFeatureFlds.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convTabFeatureFlds.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convTabFeatureFlds.mId);
}
else if (convTabFeatureFlds.TabFeatureId  ==  _AttributeName[intIndex])
{
mstrTabFeatureId = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.TabFeatureId);
}
else if (convTabFeatureFlds.TabFeatureName  ==  _AttributeName[intIndex])
{
mstrTabFeatureName = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.TabFeatureName);
}
else if (convTabFeatureFlds.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.TabId);
}
else if (convTabFeatureFlds.TabName  ==  _AttributeName[intIndex])
{
mstrTabName = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.TabName);
}
else if (convTabFeatureFlds.TabCnName  ==  _AttributeName[intIndex])
{
mstrTabCnName = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.TabCnName);
}
else if (convTabFeatureFlds.PrjName  ==  _AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.PrjName);
}
else if (convTabFeatureFlds.SqlDsTypeName  ==  _AttributeName[intIndex])
{
mstrSqlDsTypeName = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.SqlDsTypeName);
}
else if (convTabFeatureFlds.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.FuncModuleAgcId);
}
else if (convTabFeatureFlds.FuncModuleName  ==  _AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.FuncModuleName);
}
else if (convTabFeatureFlds.OrderNum4Refer  ==  _AttributeName[intIndex])
{
mintOrderNum4Refer = TransNullToInt(value.ToString());
 AddUpdatedFld(convTabFeatureFlds.OrderNum4Refer);
}
else if (convTabFeatureFlds.FeatureId  ==  _AttributeName[intIndex])
{
mstrFeatureId = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.FeatureId);
}
else if (convTabFeatureFlds.FeatureName  ==  _AttributeName[intIndex])
{
mstrFeatureName = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.FeatureName);
}
else if (convTabFeatureFlds.ParentFeatureId  ==  _AttributeName[intIndex])
{
mstrParentFeatureId = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.ParentFeatureId);
}
else if (convTabFeatureFlds.ParentFeatureName  ==  _AttributeName[intIndex])
{
mstrParentFeatureName = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.ParentFeatureName);
}
else if (convTabFeatureFlds.FldId  ==  _AttributeName[intIndex])
{
mstrFldId = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.FldId);
}
else if (convTabFeatureFlds.FldName  ==  _AttributeName[intIndex])
{
mstrFldName = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.FldName);
}
else if (convTabFeatureFlds.Caption  ==  _AttributeName[intIndex])
{
mstrCaption = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.Caption);
}
else if (convTabFeatureFlds.DataTypeId  ==  _AttributeName[intIndex])
{
mstrDataTypeId = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.DataTypeId);
}
else if (convTabFeatureFlds.DataTypeName  ==  _AttributeName[intIndex])
{
mstrDataTypeName = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.DataTypeName);
}
else if (convTabFeatureFlds.IsNull  ==  _AttributeName[intIndex])
{
mbolIsNull = TransNullToBool(value.ToString());
 AddUpdatedFld(convTabFeatureFlds.IsNull);
}
else if (convTabFeatureFlds.FieldTypeId  ==  _AttributeName[intIndex])
{
mstrFieldTypeId = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.FieldTypeId);
}
else if (convTabFeatureFlds.FieldTypeName  ==  _AttributeName[intIndex])
{
mstrFieldTypeName = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.FieldTypeName);
}
else if (convTabFeatureFlds.FuncName  ==  _AttributeName[intIndex])
{
mstrFuncName = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.FuncName);
}
else if (convTabFeatureFlds.ValueGivingModeId  ==  _AttributeName[intIndex])
{
mstrValueGivingModeId = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.ValueGivingModeId);
}
else if (convTabFeatureFlds.ValueGivingModeName  ==  _AttributeName[intIndex])
{
mstrValueGivingModeName = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.ValueGivingModeName);
}
else if (convTabFeatureFlds.DefaultValue  ==  _AttributeName[intIndex])
{
mstrDefaultValue = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.DefaultValue);
}
else if (convTabFeatureFlds.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.PrjId);
}
else if (convTabFeatureFlds.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convTabFeatureFlds.OrderNum);
}
else if (convTabFeatureFlds.InUse  ==  _AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convTabFeatureFlds.InUse);
}
else if (convTabFeatureFlds.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.UpdUser);
}
else if (convTabFeatureFlds.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.UpdDate);
}
else if (convTabFeatureFlds.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convTabFeatureFlds.Memo);
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
 AddUpdatedFld(convTabFeatureFlds.mId);
}
}
/// <summary>
/// 表功能Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabFeatureId
{
get
{
return mstrTabFeatureId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabFeatureId = value;
}
else
{
 mstrTabFeatureId = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabFeatureFlds.TabFeatureId);
}
}
/// <summary>
/// 表功能名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabFeatureName
{
get
{
return mstrTabFeatureName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabFeatureName = value;
}
else
{
 mstrTabFeatureName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabFeatureFlds.TabFeatureName);
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
 AddUpdatedFld(convTabFeatureFlds.TabId);
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
 AddUpdatedFld(convTabFeatureFlds.TabName);
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
 AddUpdatedFld(convTabFeatureFlds.TabCnName);
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
 AddUpdatedFld(convTabFeatureFlds.PrjName);
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
 AddUpdatedFld(convTabFeatureFlds.SqlDsTypeName);
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
 AddUpdatedFld(convTabFeatureFlds.FuncModuleAgcId);
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
 AddUpdatedFld(convTabFeatureFlds.FuncModuleName);
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
 AddUpdatedFld(convTabFeatureFlds.OrderNum4Refer);
}
}
/// <summary>
/// 功能Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FeatureId
{
get
{
return mstrFeatureId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFeatureId = value;
}
else
{
 mstrFeatureId = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabFeatureFlds.FeatureId);
}
}
/// <summary>
/// 功能名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FeatureName
{
get
{
return mstrFeatureName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFeatureName = value;
}
else
{
 mstrFeatureName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabFeatureFlds.FeatureName);
}
}
/// <summary>
/// 父功能Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParentFeatureId
{
get
{
return mstrParentFeatureId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParentFeatureId = value;
}
else
{
 mstrParentFeatureId = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabFeatureFlds.ParentFeatureId);
}
}
/// <summary>
/// 父功能名(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParentFeatureName
{
get
{
return mstrParentFeatureName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParentFeatureName = value;
}
else
{
 mstrParentFeatureName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabFeatureFlds.ParentFeatureName);
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
 AddUpdatedFld(convTabFeatureFlds.FldId);
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
 AddUpdatedFld(convTabFeatureFlds.FldName);
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
 AddUpdatedFld(convTabFeatureFlds.Caption);
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
 AddUpdatedFld(convTabFeatureFlds.DataTypeId);
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
 AddUpdatedFld(convTabFeatureFlds.DataTypeName);
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
 AddUpdatedFld(convTabFeatureFlds.IsNull);
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
 AddUpdatedFld(convTabFeatureFlds.FieldTypeId);
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
 AddUpdatedFld(convTabFeatureFlds.FieldTypeName);
}
}
/// <summary>
/// 函数名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncName
{
get
{
return mstrFuncName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncName = value;
}
else
{
 mstrFuncName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabFeatureFlds.FuncName);
}
}
/// <summary>
/// 给值方式Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ValueGivingModeId
{
get
{
return mstrValueGivingModeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrValueGivingModeId = value;
}
else
{
 mstrValueGivingModeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabFeatureFlds.ValueGivingModeId);
}
}
/// <summary>
/// 给值方式名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ValueGivingModeName
{
get
{
return mstrValueGivingModeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrValueGivingModeName = value;
}
else
{
 mstrValueGivingModeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabFeatureFlds.ValueGivingModeName);
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
 AddUpdatedFld(convTabFeatureFlds.DefaultValue);
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
 AddUpdatedFld(convTabFeatureFlds.PrjId);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(convTabFeatureFlds.OrderNum);
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
 AddUpdatedFld(convTabFeatureFlds.InUse);
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
 AddUpdatedFld(convTabFeatureFlds.UpdUser);
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
 AddUpdatedFld(convTabFeatureFlds.UpdDate);
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
 AddUpdatedFld(convTabFeatureFlds.Memo);
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
 /// v表功能字段(vTabFeatureFlds)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convTabFeatureFlds
{
public const string _CurrTabName = "vTabFeatureFlds"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "TabFeatureId", "TabFeatureName", "TabId", "TabName", "TabCnName", "PrjName", "SqlDsTypeName", "FuncModuleAgcId", "FuncModuleName", "OrderNum4Refer", "FeatureId", "FeatureName", "ParentFeatureId", "ParentFeatureName", "FldId", "FldName", "Caption", "DataTypeId", "DataTypeName", "IsNull", "FieldTypeId", "FieldTypeName", "FuncName", "ValueGivingModeId", "ValueGivingModeName", "DefaultValue", "PrjId", "OrderNum", "InUse", "UpdUser", "UpdDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"TabFeatureId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabFeatureId = "TabFeatureId";    //表功能Id

 /// <summary>
 /// 常量:"TabFeatureName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabFeatureName = "TabFeatureName";    //表功能名

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
 /// 常量:"FeatureId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeatureId = "FeatureId";    //功能Id

 /// <summary>
 /// 常量:"FeatureName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeatureName = "FeatureName";    //功能名称

 /// <summary>
 /// 常量:"ParentFeatureId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParentFeatureId = "ParentFeatureId";    //父功能Id

 /// <summary>
 /// 常量:"ParentFeatureName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParentFeatureName = "ParentFeatureName";    //父功能名

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
 /// 常量:"IsNull"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsNull = "IsNull";    //是否可空

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
 /// 常量:"FuncName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncName = "FuncName";    //函数名

 /// <summary>
 /// 常量:"ValueGivingModeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ValueGivingModeId = "ValueGivingModeId";    //给值方式Id

 /// <summary>
 /// 常量:"ValueGivingModeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ValueGivingModeName = "ValueGivingModeName";    //给值方式名

 /// <summary>
 /// 常量:"DefaultValue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DefaultValue = "DefaultValue";    //缺省值

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"InUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InUse = "InUse";    //是否在用

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改者

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}