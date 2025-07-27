
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewFeatureFldsEN
 表名:vViewFeatureFlds(00050454)
 * 版本:2024.01.24.1(服务器:WIN-SRV103-116)
 日期:2024/01/26 14:38:38
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:区域管理(RegionManage)
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
 /// 表vViewFeatureFlds的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vViewFeatureFlds
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
public K_mId_vViewFeatureFlds(long lngmId)
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
 /// <returns>返回:[K_mId_vViewFeatureFlds]类型的对象</returns>
public static implicit operator K_mId_vViewFeatureFlds(long value)
{
return new K_mId_vViewFeatureFlds(value);
}
}
 /// <summary>
 /// v界面功能字段(vViewFeatureFlds)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvViewFeatureFldsEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vViewFeatureFlds"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 47;
public static string[] AttributeName = new string[] {"mId", "ViewFeatureId", "RegionId", "RegionName", "RegionTypeId", "RegionTypeName", "FeatureId", "FeatureName", "ButtonName", "ValueGivingModeId", "GroupName", "ReleTabId", "SeqNum", "RelaTabName", "ReleFldId", "FieldTypeId", "FieldTypeName", "FuncName", "LabelCaption", "CtlTypeId", "CtlTypeName", "CtlCnName", "CtlTypeAbbr", "VarId", "VarName", "CtrlId", "DefaultValue", "OrderNum", "DdlItemsOptionId", "DsTabId", "FldName", "DsCondStr", "DsSqlStr", "ItemsString", "InUse", "PrjId", "UpdUser", "UpdDate", "Memo", "DsTabName", "FldIdCond1", "FldIdCond2", "TabFeatureId4Ddl", "VarIdCond1", "VarIdCond2", "VarTypeIdCond1", "VarTypeIdCond2"};

protected long mlngmId;    //mId
protected string mstrViewFeatureId;    //界面功能Id
protected string mstrRegionId;    //区域Id
protected string mstrRegionName;    //区域名称
protected string mstrRegionTypeId;    //区域类型Id
protected string mstrRegionTypeName;    //区域类型名称
protected string mstrFeatureId;    //功能Id
protected string mstrFeatureName;    //功能名称
protected string mstrButtonName;    //按钮名称
protected string mstrValueGivingModeId;    //给值方式Id
protected string mstrGroupName;    //组名
protected string mstrReleTabId;    //相关表Id
protected int? mintSeqNum;    //字段序号
protected string mstrRelaTabName;    //相关表名
protected string mstrReleFldId;    //相关字段Id
protected string mstrFieldTypeId;    //字段类型Id
protected string mstrFieldTypeName;    //字段类型名
protected string mstrFuncName;    //函数名
protected string mstrLabelCaption;    //标签标题
protected string mstrCtlTypeId;    //控件类型号
protected string mstrCtlTypeName;    //控件类型名
protected string mstrCtlCnName;    //控件类型中文名
protected string mstrCtlTypeAbbr;    //控件类型缩写
protected string mstrVarId;    //变量Id
protected string mstrVarName;    //变量名
protected string mstrCtrlId;    //控件Id
protected string mstrDefaultValue;    //缺省值
protected int? mintOrderNum;    //序号
protected string mstrDdlItemsOptionId;    //下拉框列表选项ID
protected string mstrDsTabId;    //数据源表ID
protected string mstrFldName;    //字段名
protected string mstrDsCondStr;    //数据源条件串
protected string mstrDsSqlStr;    //数据源SQL串
protected string mstrItemsString;    //列表项串
protected bool mbolInUse;    //是否在用
protected string mstrPrjId;    //工程ID
protected string mstrUpdUser;    //修改者
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //说明
protected string mstrDsTabName;    //数据源表
protected string mstrFldIdCond1;    //字段Id_条件1
protected string mstrFldIdCond2;    //字段Id_条件2
protected string mstrTabFeatureId4Ddl;    //下拉框表功能Id
protected string mstrVarIdCond1;    //变量Id_条件1
protected string mstrVarIdCond2;    //数据源字段_条件1
protected string mstrVarTypeIdCond1;    //变量类型Id_条件1
protected string mstrVarTypeIdCond2;    //变量类型Id_条件2

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvViewFeatureFldsEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:mId</param>
public clsvViewFeatureFldsEN(long lngmId)
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
return mintAttributeCount;
}
}
public override object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  convViewFeatureFlds.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convViewFeatureFlds.ViewFeatureId)
{
return mstrViewFeatureId;
}
else if (strAttributeName  ==  convViewFeatureFlds.RegionId)
{
return mstrRegionId;
}
else if (strAttributeName  ==  convViewFeatureFlds.RegionName)
{
return mstrRegionName;
}
else if (strAttributeName  ==  convViewFeatureFlds.RegionTypeId)
{
return mstrRegionTypeId;
}
else if (strAttributeName  ==  convViewFeatureFlds.RegionTypeName)
{
return mstrRegionTypeName;
}
else if (strAttributeName  ==  convViewFeatureFlds.FeatureId)
{
return mstrFeatureId;
}
else if (strAttributeName  ==  convViewFeatureFlds.FeatureName)
{
return mstrFeatureName;
}
else if (strAttributeName  ==  convViewFeatureFlds.ButtonName)
{
return mstrButtonName;
}
else if (strAttributeName  ==  convViewFeatureFlds.ValueGivingModeId)
{
return mstrValueGivingModeId;
}
else if (strAttributeName  ==  convViewFeatureFlds.GroupName)
{
return mstrGroupName;
}
else if (strAttributeName  ==  convViewFeatureFlds.ReleTabId)
{
return mstrReleTabId;
}
else if (strAttributeName  ==  convViewFeatureFlds.SeqNum)
{
return mintSeqNum;
}
else if (strAttributeName  ==  convViewFeatureFlds.RelaTabName)
{
return mstrRelaTabName;
}
else if (strAttributeName  ==  convViewFeatureFlds.ReleFldId)
{
return mstrReleFldId;
}
else if (strAttributeName  ==  convViewFeatureFlds.FieldTypeId)
{
return mstrFieldTypeId;
}
else if (strAttributeName  ==  convViewFeatureFlds.FieldTypeName)
{
return mstrFieldTypeName;
}
else if (strAttributeName  ==  convViewFeatureFlds.FuncName)
{
return mstrFuncName;
}
else if (strAttributeName  ==  convViewFeatureFlds.LabelCaption)
{
return mstrLabelCaption;
}
else if (strAttributeName  ==  convViewFeatureFlds.CtlTypeId)
{
return mstrCtlTypeId;
}
else if (strAttributeName  ==  convViewFeatureFlds.CtlTypeName)
{
return mstrCtlTypeName;
}
else if (strAttributeName  ==  convViewFeatureFlds.CtlCnName)
{
return mstrCtlCnName;
}
else if (strAttributeName  ==  convViewFeatureFlds.CtlTypeAbbr)
{
return mstrCtlTypeAbbr;
}
else if (strAttributeName  ==  convViewFeatureFlds.VarId)
{
return mstrVarId;
}
else if (strAttributeName  ==  convViewFeatureFlds.VarName)
{
return mstrVarName;
}
else if (strAttributeName  ==  convViewFeatureFlds.CtrlId)
{
return mstrCtrlId;
}
else if (strAttributeName  ==  convViewFeatureFlds.DefaultValue)
{
return mstrDefaultValue;
}
else if (strAttributeName  ==  convViewFeatureFlds.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convViewFeatureFlds.DdlItemsOptionId)
{
return mstrDdlItemsOptionId;
}
else if (strAttributeName  ==  convViewFeatureFlds.DsTabId)
{
return mstrDsTabId;
}
else if (strAttributeName  ==  convViewFeatureFlds.FldName)
{
return mstrFldName;
}
else if (strAttributeName  ==  convViewFeatureFlds.DsCondStr)
{
return mstrDsCondStr;
}
else if (strAttributeName  ==  convViewFeatureFlds.DsSqlStr)
{
return mstrDsSqlStr;
}
else if (strAttributeName  ==  convViewFeatureFlds.ItemsString)
{
return mstrItemsString;
}
else if (strAttributeName  ==  convViewFeatureFlds.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  convViewFeatureFlds.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convViewFeatureFlds.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convViewFeatureFlds.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convViewFeatureFlds.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convViewFeatureFlds.DsTabName)
{
return mstrDsTabName;
}
else if (strAttributeName  ==  convViewFeatureFlds.FldIdCond1)
{
return mstrFldIdCond1;
}
else if (strAttributeName  ==  convViewFeatureFlds.FldIdCond2)
{
return mstrFldIdCond2;
}
else if (strAttributeName  ==  convViewFeatureFlds.TabFeatureId4Ddl)
{
return mstrTabFeatureId4Ddl;
}
else if (strAttributeName  ==  convViewFeatureFlds.VarIdCond1)
{
return mstrVarIdCond1;
}
else if (strAttributeName  ==  convViewFeatureFlds.VarIdCond2)
{
return mstrVarIdCond2;
}
else if (strAttributeName  ==  convViewFeatureFlds.VarTypeIdCond1)
{
return mstrVarTypeIdCond1;
}
else if (strAttributeName  ==  convViewFeatureFlds.VarTypeIdCond2)
{
return mstrVarTypeIdCond2;
}
return null;
}
set
{
if (strAttributeName  ==  convViewFeatureFlds.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewFeatureFlds.mId);
}
else if (strAttributeName  ==  convViewFeatureFlds.ViewFeatureId)
{
mstrViewFeatureId = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.ViewFeatureId);
}
else if (strAttributeName  ==  convViewFeatureFlds.RegionId)
{
mstrRegionId = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.RegionId);
}
else if (strAttributeName  ==  convViewFeatureFlds.RegionName)
{
mstrRegionName = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.RegionName);
}
else if (strAttributeName  ==  convViewFeatureFlds.RegionTypeId)
{
mstrRegionTypeId = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.RegionTypeId);
}
else if (strAttributeName  ==  convViewFeatureFlds.RegionTypeName)
{
mstrRegionTypeName = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.RegionTypeName);
}
else if (strAttributeName  ==  convViewFeatureFlds.FeatureId)
{
mstrFeatureId = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.FeatureId);
}
else if (strAttributeName  ==  convViewFeatureFlds.FeatureName)
{
mstrFeatureName = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.FeatureName);
}
else if (strAttributeName  ==  convViewFeatureFlds.ButtonName)
{
mstrButtonName = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.ButtonName);
}
else if (strAttributeName  ==  convViewFeatureFlds.ValueGivingModeId)
{
mstrValueGivingModeId = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.ValueGivingModeId);
}
else if (strAttributeName  ==  convViewFeatureFlds.GroupName)
{
mstrGroupName = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.GroupName);
}
else if (strAttributeName  ==  convViewFeatureFlds.ReleTabId)
{
mstrReleTabId = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.ReleTabId);
}
else if (strAttributeName  ==  convViewFeatureFlds.SeqNum)
{
mintSeqNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewFeatureFlds.SeqNum);
}
else if (strAttributeName  ==  convViewFeatureFlds.RelaTabName)
{
mstrRelaTabName = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.RelaTabName);
}
else if (strAttributeName  ==  convViewFeatureFlds.ReleFldId)
{
mstrReleFldId = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.ReleFldId);
}
else if (strAttributeName  ==  convViewFeatureFlds.FieldTypeId)
{
mstrFieldTypeId = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.FieldTypeId);
}
else if (strAttributeName  ==  convViewFeatureFlds.FieldTypeName)
{
mstrFieldTypeName = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.FieldTypeName);
}
else if (strAttributeName  ==  convViewFeatureFlds.FuncName)
{
mstrFuncName = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.FuncName);
}
else if (strAttributeName  ==  convViewFeatureFlds.LabelCaption)
{
mstrLabelCaption = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.LabelCaption);
}
else if (strAttributeName  ==  convViewFeatureFlds.CtlTypeId)
{
mstrCtlTypeId = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.CtlTypeId);
}
else if (strAttributeName  ==  convViewFeatureFlds.CtlTypeName)
{
mstrCtlTypeName = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.CtlTypeName);
}
else if (strAttributeName  ==  convViewFeatureFlds.CtlCnName)
{
mstrCtlCnName = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.CtlCnName);
}
else if (strAttributeName  ==  convViewFeatureFlds.CtlTypeAbbr)
{
mstrCtlTypeAbbr = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.CtlTypeAbbr);
}
else if (strAttributeName  ==  convViewFeatureFlds.VarId)
{
mstrVarId = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.VarId);
}
else if (strAttributeName  ==  convViewFeatureFlds.VarName)
{
mstrVarName = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.VarName);
}
else if (strAttributeName  ==  convViewFeatureFlds.CtrlId)
{
mstrCtrlId = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.CtrlId);
}
else if (strAttributeName  ==  convViewFeatureFlds.DefaultValue)
{
mstrDefaultValue = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.DefaultValue);
}
else if (strAttributeName  ==  convViewFeatureFlds.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewFeatureFlds.OrderNum);
}
else if (strAttributeName  ==  convViewFeatureFlds.DdlItemsOptionId)
{
mstrDdlItemsOptionId = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.DdlItemsOptionId);
}
else if (strAttributeName  ==  convViewFeatureFlds.DsTabId)
{
mstrDsTabId = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.DsTabId);
}
else if (strAttributeName  ==  convViewFeatureFlds.FldName)
{
mstrFldName = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.FldName);
}
else if (strAttributeName  ==  convViewFeatureFlds.DsCondStr)
{
mstrDsCondStr = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.DsCondStr);
}
else if (strAttributeName  ==  convViewFeatureFlds.DsSqlStr)
{
mstrDsSqlStr = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.DsSqlStr);
}
else if (strAttributeName  ==  convViewFeatureFlds.ItemsString)
{
mstrItemsString = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.ItemsString);
}
else if (strAttributeName  ==  convViewFeatureFlds.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convViewFeatureFlds.InUse);
}
else if (strAttributeName  ==  convViewFeatureFlds.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.PrjId);
}
else if (strAttributeName  ==  convViewFeatureFlds.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.UpdUser);
}
else if (strAttributeName  ==  convViewFeatureFlds.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.UpdDate);
}
else if (strAttributeName  ==  convViewFeatureFlds.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.Memo);
}
else if (strAttributeName  ==  convViewFeatureFlds.DsTabName)
{
mstrDsTabName = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.DsTabName);
}
else if (strAttributeName  ==  convViewFeatureFlds.FldIdCond1)
{
mstrFldIdCond1 = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.FldIdCond1);
}
else if (strAttributeName  ==  convViewFeatureFlds.FldIdCond2)
{
mstrFldIdCond2 = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.FldIdCond2);
}
else if (strAttributeName  ==  convViewFeatureFlds.TabFeatureId4Ddl)
{
mstrTabFeatureId4Ddl = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.TabFeatureId4Ddl);
}
else if (strAttributeName  ==  convViewFeatureFlds.VarIdCond1)
{
mstrVarIdCond1 = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.VarIdCond1);
}
else if (strAttributeName  ==  convViewFeatureFlds.VarIdCond2)
{
mstrVarIdCond2 = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.VarIdCond2);
}
else if (strAttributeName  ==  convViewFeatureFlds.VarTypeIdCond1)
{
mstrVarTypeIdCond1 = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.VarTypeIdCond1);
}
else if (strAttributeName  ==  convViewFeatureFlds.VarTypeIdCond2)
{
mstrVarTypeIdCond2 = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.VarTypeIdCond2);
}
}
}
public object this[int intIndex]
{
get
{
if (convViewFeatureFlds.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convViewFeatureFlds.ViewFeatureId  ==  AttributeName[intIndex])
{
return mstrViewFeatureId;
}
else if (convViewFeatureFlds.RegionId  ==  AttributeName[intIndex])
{
return mstrRegionId;
}
else if (convViewFeatureFlds.RegionName  ==  AttributeName[intIndex])
{
return mstrRegionName;
}
else if (convViewFeatureFlds.RegionTypeId  ==  AttributeName[intIndex])
{
return mstrRegionTypeId;
}
else if (convViewFeatureFlds.RegionTypeName  ==  AttributeName[intIndex])
{
return mstrRegionTypeName;
}
else if (convViewFeatureFlds.FeatureId  ==  AttributeName[intIndex])
{
return mstrFeatureId;
}
else if (convViewFeatureFlds.FeatureName  ==  AttributeName[intIndex])
{
return mstrFeatureName;
}
else if (convViewFeatureFlds.ButtonName  ==  AttributeName[intIndex])
{
return mstrButtonName;
}
else if (convViewFeatureFlds.ValueGivingModeId  ==  AttributeName[intIndex])
{
return mstrValueGivingModeId;
}
else if (convViewFeatureFlds.GroupName  ==  AttributeName[intIndex])
{
return mstrGroupName;
}
else if (convViewFeatureFlds.ReleTabId  ==  AttributeName[intIndex])
{
return mstrReleTabId;
}
else if (convViewFeatureFlds.SeqNum  ==  AttributeName[intIndex])
{
return mintSeqNum;
}
else if (convViewFeatureFlds.RelaTabName  ==  AttributeName[intIndex])
{
return mstrRelaTabName;
}
else if (convViewFeatureFlds.ReleFldId  ==  AttributeName[intIndex])
{
return mstrReleFldId;
}
else if (convViewFeatureFlds.FieldTypeId  ==  AttributeName[intIndex])
{
return mstrFieldTypeId;
}
else if (convViewFeatureFlds.FieldTypeName  ==  AttributeName[intIndex])
{
return mstrFieldTypeName;
}
else if (convViewFeatureFlds.FuncName  ==  AttributeName[intIndex])
{
return mstrFuncName;
}
else if (convViewFeatureFlds.LabelCaption  ==  AttributeName[intIndex])
{
return mstrLabelCaption;
}
else if (convViewFeatureFlds.CtlTypeId  ==  AttributeName[intIndex])
{
return mstrCtlTypeId;
}
else if (convViewFeatureFlds.CtlTypeName  ==  AttributeName[intIndex])
{
return mstrCtlTypeName;
}
else if (convViewFeatureFlds.CtlCnName  ==  AttributeName[intIndex])
{
return mstrCtlCnName;
}
else if (convViewFeatureFlds.CtlTypeAbbr  ==  AttributeName[intIndex])
{
return mstrCtlTypeAbbr;
}
else if (convViewFeatureFlds.VarId  ==  AttributeName[intIndex])
{
return mstrVarId;
}
else if (convViewFeatureFlds.VarName  ==  AttributeName[intIndex])
{
return mstrVarName;
}
else if (convViewFeatureFlds.CtrlId  ==  AttributeName[intIndex])
{
return mstrCtrlId;
}
else if (convViewFeatureFlds.DefaultValue  ==  AttributeName[intIndex])
{
return mstrDefaultValue;
}
else if (convViewFeatureFlds.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convViewFeatureFlds.DdlItemsOptionId  ==  AttributeName[intIndex])
{
return mstrDdlItemsOptionId;
}
else if (convViewFeatureFlds.DsTabId  ==  AttributeName[intIndex])
{
return mstrDsTabId;
}
else if (convViewFeatureFlds.FldName  ==  AttributeName[intIndex])
{
return mstrFldName;
}
else if (convViewFeatureFlds.DsCondStr  ==  AttributeName[intIndex])
{
return mstrDsCondStr;
}
else if (convViewFeatureFlds.DsSqlStr  ==  AttributeName[intIndex])
{
return mstrDsSqlStr;
}
else if (convViewFeatureFlds.ItemsString  ==  AttributeName[intIndex])
{
return mstrItemsString;
}
else if (convViewFeatureFlds.InUse  ==  AttributeName[intIndex])
{
return mbolInUse;
}
else if (convViewFeatureFlds.PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convViewFeatureFlds.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convViewFeatureFlds.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convViewFeatureFlds.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convViewFeatureFlds.DsTabName  ==  AttributeName[intIndex])
{
return mstrDsTabName;
}
else if (convViewFeatureFlds.FldIdCond1  ==  AttributeName[intIndex])
{
return mstrFldIdCond1;
}
else if (convViewFeatureFlds.FldIdCond2  ==  AttributeName[intIndex])
{
return mstrFldIdCond2;
}
else if (convViewFeatureFlds.TabFeatureId4Ddl  ==  AttributeName[intIndex])
{
return mstrTabFeatureId4Ddl;
}
else if (convViewFeatureFlds.VarIdCond1  ==  AttributeName[intIndex])
{
return mstrVarIdCond1;
}
else if (convViewFeatureFlds.VarIdCond2  ==  AttributeName[intIndex])
{
return mstrVarIdCond2;
}
else if (convViewFeatureFlds.VarTypeIdCond1  ==  AttributeName[intIndex])
{
return mstrVarTypeIdCond1;
}
else if (convViewFeatureFlds.VarTypeIdCond2  ==  AttributeName[intIndex])
{
return mstrVarTypeIdCond2;
}
return null;
}
set
{
if (convViewFeatureFlds.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewFeatureFlds.mId);
}
else if (convViewFeatureFlds.ViewFeatureId  ==  AttributeName[intIndex])
{
mstrViewFeatureId = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.ViewFeatureId);
}
else if (convViewFeatureFlds.RegionId  ==  AttributeName[intIndex])
{
mstrRegionId = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.RegionId);
}
else if (convViewFeatureFlds.RegionName  ==  AttributeName[intIndex])
{
mstrRegionName = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.RegionName);
}
else if (convViewFeatureFlds.RegionTypeId  ==  AttributeName[intIndex])
{
mstrRegionTypeId = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.RegionTypeId);
}
else if (convViewFeatureFlds.RegionTypeName  ==  AttributeName[intIndex])
{
mstrRegionTypeName = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.RegionTypeName);
}
else if (convViewFeatureFlds.FeatureId  ==  AttributeName[intIndex])
{
mstrFeatureId = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.FeatureId);
}
else if (convViewFeatureFlds.FeatureName  ==  AttributeName[intIndex])
{
mstrFeatureName = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.FeatureName);
}
else if (convViewFeatureFlds.ButtonName  ==  AttributeName[intIndex])
{
mstrButtonName = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.ButtonName);
}
else if (convViewFeatureFlds.ValueGivingModeId  ==  AttributeName[intIndex])
{
mstrValueGivingModeId = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.ValueGivingModeId);
}
else if (convViewFeatureFlds.GroupName  ==  AttributeName[intIndex])
{
mstrGroupName = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.GroupName);
}
else if (convViewFeatureFlds.ReleTabId  ==  AttributeName[intIndex])
{
mstrReleTabId = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.ReleTabId);
}
else if (convViewFeatureFlds.SeqNum  ==  AttributeName[intIndex])
{
mintSeqNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewFeatureFlds.SeqNum);
}
else if (convViewFeatureFlds.RelaTabName  ==  AttributeName[intIndex])
{
mstrRelaTabName = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.RelaTabName);
}
else if (convViewFeatureFlds.ReleFldId  ==  AttributeName[intIndex])
{
mstrReleFldId = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.ReleFldId);
}
else if (convViewFeatureFlds.FieldTypeId  ==  AttributeName[intIndex])
{
mstrFieldTypeId = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.FieldTypeId);
}
else if (convViewFeatureFlds.FieldTypeName  ==  AttributeName[intIndex])
{
mstrFieldTypeName = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.FieldTypeName);
}
else if (convViewFeatureFlds.FuncName  ==  AttributeName[intIndex])
{
mstrFuncName = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.FuncName);
}
else if (convViewFeatureFlds.LabelCaption  ==  AttributeName[intIndex])
{
mstrLabelCaption = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.LabelCaption);
}
else if (convViewFeatureFlds.CtlTypeId  ==  AttributeName[intIndex])
{
mstrCtlTypeId = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.CtlTypeId);
}
else if (convViewFeatureFlds.CtlTypeName  ==  AttributeName[intIndex])
{
mstrCtlTypeName = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.CtlTypeName);
}
else if (convViewFeatureFlds.CtlCnName  ==  AttributeName[intIndex])
{
mstrCtlCnName = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.CtlCnName);
}
else if (convViewFeatureFlds.CtlTypeAbbr  ==  AttributeName[intIndex])
{
mstrCtlTypeAbbr = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.CtlTypeAbbr);
}
else if (convViewFeatureFlds.VarId  ==  AttributeName[intIndex])
{
mstrVarId = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.VarId);
}
else if (convViewFeatureFlds.VarName  ==  AttributeName[intIndex])
{
mstrVarName = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.VarName);
}
else if (convViewFeatureFlds.CtrlId  ==  AttributeName[intIndex])
{
mstrCtrlId = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.CtrlId);
}
else if (convViewFeatureFlds.DefaultValue  ==  AttributeName[intIndex])
{
mstrDefaultValue = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.DefaultValue);
}
else if (convViewFeatureFlds.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewFeatureFlds.OrderNum);
}
else if (convViewFeatureFlds.DdlItemsOptionId  ==  AttributeName[intIndex])
{
mstrDdlItemsOptionId = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.DdlItemsOptionId);
}
else if (convViewFeatureFlds.DsTabId  ==  AttributeName[intIndex])
{
mstrDsTabId = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.DsTabId);
}
else if (convViewFeatureFlds.FldName  ==  AttributeName[intIndex])
{
mstrFldName = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.FldName);
}
else if (convViewFeatureFlds.DsCondStr  ==  AttributeName[intIndex])
{
mstrDsCondStr = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.DsCondStr);
}
else if (convViewFeatureFlds.DsSqlStr  ==  AttributeName[intIndex])
{
mstrDsSqlStr = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.DsSqlStr);
}
else if (convViewFeatureFlds.ItemsString  ==  AttributeName[intIndex])
{
mstrItemsString = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.ItemsString);
}
else if (convViewFeatureFlds.InUse  ==  AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convViewFeatureFlds.InUse);
}
else if (convViewFeatureFlds.PrjId  ==  AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.PrjId);
}
else if (convViewFeatureFlds.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.UpdUser);
}
else if (convViewFeatureFlds.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.UpdDate);
}
else if (convViewFeatureFlds.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.Memo);
}
else if (convViewFeatureFlds.DsTabName  ==  AttributeName[intIndex])
{
mstrDsTabName = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.DsTabName);
}
else if (convViewFeatureFlds.FldIdCond1  ==  AttributeName[intIndex])
{
mstrFldIdCond1 = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.FldIdCond1);
}
else if (convViewFeatureFlds.FldIdCond2  ==  AttributeName[intIndex])
{
mstrFldIdCond2 = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.FldIdCond2);
}
else if (convViewFeatureFlds.TabFeatureId4Ddl  ==  AttributeName[intIndex])
{
mstrTabFeatureId4Ddl = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.TabFeatureId4Ddl);
}
else if (convViewFeatureFlds.VarIdCond1  ==  AttributeName[intIndex])
{
mstrVarIdCond1 = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.VarIdCond1);
}
else if (convViewFeatureFlds.VarIdCond2  ==  AttributeName[intIndex])
{
mstrVarIdCond2 = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.VarIdCond2);
}
else if (convViewFeatureFlds.VarTypeIdCond1  ==  AttributeName[intIndex])
{
mstrVarTypeIdCond1 = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.VarTypeIdCond1);
}
else if (convViewFeatureFlds.VarTypeIdCond2  ==  AttributeName[intIndex])
{
mstrVarTypeIdCond2 = value.ToString();
 AddUpdatedFld(convViewFeatureFlds.VarTypeIdCond2);
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
 AddUpdatedFld(convViewFeatureFlds.mId);
}
}
/// <summary>
/// 界面功能Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewFeatureId
{
get
{
return mstrViewFeatureId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewFeatureId = value;
}
else
{
 mstrViewFeatureId = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewFeatureFlds.ViewFeatureId);
}
}
/// <summary>
/// 区域Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RegionId
{
get
{
return mstrRegionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRegionId = value;
}
else
{
 mstrRegionId = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewFeatureFlds.RegionId);
}
}
/// <summary>
/// 区域名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RegionName
{
get
{
return mstrRegionName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRegionName = value;
}
else
{
 mstrRegionName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewFeatureFlds.RegionName);
}
}
/// <summary>
/// 区域类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RegionTypeId
{
get
{
return mstrRegionTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRegionTypeId = value;
}
else
{
 mstrRegionTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewFeatureFlds.RegionTypeId);
}
}
/// <summary>
/// 区域类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RegionTypeName
{
get
{
return mstrRegionTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRegionTypeName = value;
}
else
{
 mstrRegionTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewFeatureFlds.RegionTypeName);
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
 AddUpdatedFld(convViewFeatureFlds.FeatureId);
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
 AddUpdatedFld(convViewFeatureFlds.FeatureName);
}
}
/// <summary>
/// 按钮名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ButtonName
{
get
{
return mstrButtonName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrButtonName = value;
}
else
{
 mstrButtonName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewFeatureFlds.ButtonName);
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
 AddUpdatedFld(convViewFeatureFlds.ValueGivingModeId);
}
}
/// <summary>
/// 组名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GroupName
{
get
{
return mstrGroupName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGroupName = value;
}
else
{
 mstrGroupName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewFeatureFlds.GroupName);
}
}
/// <summary>
/// 相关表Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ReleTabId
{
get
{
return mstrReleTabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrReleTabId = value;
}
else
{
 mstrReleTabId = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewFeatureFlds.ReleTabId);
}
}
/// <summary>
/// 字段序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? SeqNum
{
get
{
return mintSeqNum;
}
set
{
 mintSeqNum = value;
//记录修改过的字段
 AddUpdatedFld(convViewFeatureFlds.SeqNum);
}
}
/// <summary>
/// 相关表名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RelaTabName
{
get
{
return mstrRelaTabName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRelaTabName = value;
}
else
{
 mstrRelaTabName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewFeatureFlds.RelaTabName);
}
}
/// <summary>
/// 相关字段Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ReleFldId
{
get
{
return mstrReleFldId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrReleFldId = value;
}
else
{
 mstrReleFldId = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewFeatureFlds.ReleFldId);
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
 AddUpdatedFld(convViewFeatureFlds.FieldTypeId);
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
 AddUpdatedFld(convViewFeatureFlds.FieldTypeName);
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
 AddUpdatedFld(convViewFeatureFlds.FuncName);
}
}
/// <summary>
/// 标签标题(说明:;字段类型:varchar;字段长度:150;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LabelCaption
{
get
{
return mstrLabelCaption;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLabelCaption = value;
}
else
{
 mstrLabelCaption = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewFeatureFlds.LabelCaption);
}
}
/// <summary>
/// 控件类型号(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CtlTypeId
{
get
{
return mstrCtlTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCtlTypeId = value;
}
else
{
 mstrCtlTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewFeatureFlds.CtlTypeId);
}
}
/// <summary>
/// 控件类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CtlTypeName
{
get
{
return mstrCtlTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCtlTypeName = value;
}
else
{
 mstrCtlTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewFeatureFlds.CtlTypeName);
}
}
/// <summary>
/// 控件类型中文名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CtlCnName
{
get
{
return mstrCtlCnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCtlCnName = value;
}
else
{
 mstrCtlCnName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewFeatureFlds.CtlCnName);
}
}
/// <summary>
/// 控件类型缩写(说明:;字段类型:varchar;字段长度:5;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CtlTypeAbbr
{
get
{
return mstrCtlTypeAbbr;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCtlTypeAbbr = value;
}
else
{
 mstrCtlTypeAbbr = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewFeatureFlds.CtlTypeAbbr);
}
}
/// <summary>
/// 变量Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VarId
{
get
{
return mstrVarId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVarId = value;
}
else
{
 mstrVarId = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewFeatureFlds.VarId);
}
}
/// <summary>
/// 变量名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VarName
{
get
{
return mstrVarName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVarName = value;
}
else
{
 mstrVarName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewFeatureFlds.VarName);
}
}
/// <summary>
/// 控件Id(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CtrlId
{
get
{
return mstrCtrlId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCtrlId = value;
}
else
{
 mstrCtrlId = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewFeatureFlds.CtrlId);
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
 AddUpdatedFld(convViewFeatureFlds.DefaultValue);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(convViewFeatureFlds.OrderNum);
}
}
/// <summary>
/// 下拉框列表选项ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DdlItemsOptionId
{
get
{
return mstrDdlItemsOptionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDdlItemsOptionId = value;
}
else
{
 mstrDdlItemsOptionId = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewFeatureFlds.DdlItemsOptionId);
}
}
/// <summary>
/// 数据源表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DsTabId
{
get
{
return mstrDsTabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDsTabId = value;
}
else
{
 mstrDsTabId = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewFeatureFlds.DsTabId);
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
 AddUpdatedFld(convViewFeatureFlds.FldName);
}
}
/// <summary>
/// 数据源条件串(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DsCondStr
{
get
{
return mstrDsCondStr;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDsCondStr = value;
}
else
{
 mstrDsCondStr = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewFeatureFlds.DsCondStr);
}
}
/// <summary>
/// 数据源SQL串(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DsSqlStr
{
get
{
return mstrDsSqlStr;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDsSqlStr = value;
}
else
{
 mstrDsSqlStr = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewFeatureFlds.DsSqlStr);
}
}
/// <summary>
/// 列表项串(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ItemsString
{
get
{
return mstrItemsString;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrItemsString = value;
}
else
{
 mstrItemsString = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewFeatureFlds.ItemsString);
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
 AddUpdatedFld(convViewFeatureFlds.InUse);
}
}
/// <summary>
/// 工程ID(说明:;字段类型:char;字段长度:4;是否可空:False)
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
 AddUpdatedFld(convViewFeatureFlds.PrjId);
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
 AddUpdatedFld(convViewFeatureFlds.UpdUser);
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
 AddUpdatedFld(convViewFeatureFlds.UpdDate);
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
 AddUpdatedFld(convViewFeatureFlds.Memo);
}
}
/// <summary>
/// 数据源表(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DsTabName
{
get
{
return mstrDsTabName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDsTabName = value;
}
else
{
 mstrDsTabName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewFeatureFlds.DsTabName);
}
}
/// <summary>
/// 字段Id_条件1(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FldIdCond1
{
get
{
return mstrFldIdCond1;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldIdCond1 = value;
}
else
{
 mstrFldIdCond1 = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewFeatureFlds.FldIdCond1);
}
}
/// <summary>
/// 字段Id_条件2(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FldIdCond2
{
get
{
return mstrFldIdCond2;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldIdCond2 = value;
}
else
{
 mstrFldIdCond2 = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewFeatureFlds.FldIdCond2);
}
}
/// <summary>
/// 下拉框表功能Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabFeatureId4Ddl
{
get
{
return mstrTabFeatureId4Ddl;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabFeatureId4Ddl = value;
}
else
{
 mstrTabFeatureId4Ddl = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewFeatureFlds.TabFeatureId4Ddl);
}
}
/// <summary>
/// 变量Id_条件1(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VarIdCond1
{
get
{
return mstrVarIdCond1;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVarIdCond1 = value;
}
else
{
 mstrVarIdCond1 = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewFeatureFlds.VarIdCond1);
}
}
/// <summary>
/// 数据源字段_条件1(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VarIdCond2
{
get
{
return mstrVarIdCond2;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVarIdCond2 = value;
}
else
{
 mstrVarIdCond2 = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewFeatureFlds.VarIdCond2);
}
}
/// <summary>
/// 变量类型Id_条件1(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VarTypeIdCond1
{
get
{
return mstrVarTypeIdCond1;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVarTypeIdCond1 = value;
}
else
{
 mstrVarTypeIdCond1 = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewFeatureFlds.VarTypeIdCond1);
}
}
/// <summary>
/// 变量类型Id_条件2(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VarTypeIdCond2
{
get
{
return mstrVarTypeIdCond2;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVarTypeIdCond2 = value;
}
else
{
 mstrVarTypeIdCond2 = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewFeatureFlds.VarTypeIdCond2);
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
  return mlngmId.ToString();
 }
 }
}
 /// <summary>
 /// v界面功能字段(vViewFeatureFlds)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convViewFeatureFlds
{
public const string _CurrTabName = "vViewFeatureFlds"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "ViewFeatureId", "RegionId", "RegionName", "RegionTypeId", "RegionTypeName", "FeatureId", "FeatureName", "ButtonName", "ValueGivingModeId", "GroupName", "ReleTabId", "SeqNum", "RelaTabName", "ReleFldId", "FieldTypeId", "FieldTypeName", "FuncName", "LabelCaption", "CtlTypeId", "CtlTypeName", "CtlCnName", "CtlTypeAbbr", "VarId", "VarName", "CtrlId", "DefaultValue", "OrderNum", "DdlItemsOptionId", "DsTabId", "FldName", "DsCondStr", "DsSqlStr", "ItemsString", "InUse", "PrjId", "UpdUser", "UpdDate", "Memo", "DsTabName", "FldIdCond1", "FldIdCond2", "TabFeatureId4Ddl", "VarIdCond1", "VarIdCond2", "VarTypeIdCond1", "VarTypeIdCond2"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"ViewFeatureId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewFeatureId = "ViewFeatureId";    //界面功能Id

 /// <summary>
 /// 常量:"RegionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RegionId = "RegionId";    //区域Id

 /// <summary>
 /// 常量:"RegionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RegionName = "RegionName";    //区域名称

 /// <summary>
 /// 常量:"RegionTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RegionTypeId = "RegionTypeId";    //区域类型Id

 /// <summary>
 /// 常量:"RegionTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RegionTypeName = "RegionTypeName";    //区域类型名称

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
 /// 常量:"ButtonName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ButtonName = "ButtonName";    //按钮名称

 /// <summary>
 /// 常量:"ValueGivingModeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ValueGivingModeId = "ValueGivingModeId";    //给值方式Id

 /// <summary>
 /// 常量:"GroupName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GroupName = "GroupName";    //组名

 /// <summary>
 /// 常量:"ReleTabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReleTabId = "ReleTabId";    //相关表Id

 /// <summary>
 /// 常量:"SeqNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SeqNum = "SeqNum";    //字段序号

 /// <summary>
 /// 常量:"RelaTabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RelaTabName = "RelaTabName";    //相关表名

 /// <summary>
 /// 常量:"ReleFldId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReleFldId = "ReleFldId";    //相关字段Id

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
 /// 常量:"LabelCaption"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LabelCaption = "LabelCaption";    //标签标题

 /// <summary>
 /// 常量:"CtlTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CtlTypeId = "CtlTypeId";    //控件类型号

 /// <summary>
 /// 常量:"CtlTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CtlTypeName = "CtlTypeName";    //控件类型名

 /// <summary>
 /// 常量:"CtlCnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CtlCnName = "CtlCnName";    //控件类型中文名

 /// <summary>
 /// 常量:"CtlTypeAbbr"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CtlTypeAbbr = "CtlTypeAbbr";    //控件类型缩写

 /// <summary>
 /// 常量:"VarId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VarId = "VarId";    //变量Id

 /// <summary>
 /// 常量:"VarName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VarName = "VarName";    //变量名

 /// <summary>
 /// 常量:"CtrlId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CtrlId = "CtrlId";    //控件Id

 /// <summary>
 /// 常量:"DefaultValue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DefaultValue = "DefaultValue";    //缺省值

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"DdlItemsOptionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DdlItemsOptionId = "DdlItemsOptionId";    //下拉框列表选项ID

 /// <summary>
 /// 常量:"DsTabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DsTabId = "DsTabId";    //数据源表ID

 /// <summary>
 /// 常量:"FldName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldName = "FldName";    //字段名

 /// <summary>
 /// 常量:"DsCondStr"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DsCondStr = "DsCondStr";    //数据源条件串

 /// <summary>
 /// 常量:"DsSqlStr"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DsSqlStr = "DsSqlStr";    //数据源SQL串

 /// <summary>
 /// 常量:"ItemsString"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ItemsString = "ItemsString";    //列表项串

 /// <summary>
 /// 常量:"InUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InUse = "InUse";    //是否在用

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程ID

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

 /// <summary>
 /// 常量:"DsTabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DsTabName = "DsTabName";    //数据源表

 /// <summary>
 /// 常量:"FldIdCond1"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldIdCond1 = "FldIdCond1";    //字段Id_条件1

 /// <summary>
 /// 常量:"FldIdCond2"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldIdCond2 = "FldIdCond2";    //字段Id_条件2

 /// <summary>
 /// 常量:"TabFeatureId4Ddl"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabFeatureId4Ddl = "TabFeatureId4Ddl";    //下拉框表功能Id

 /// <summary>
 /// 常量:"VarIdCond1"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VarIdCond1 = "VarIdCond1";    //变量Id_条件1

 /// <summary>
 /// 常量:"VarIdCond2"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VarIdCond2 = "VarIdCond2";    //数据源字段_条件1

 /// <summary>
 /// 常量:"VarTypeIdCond1"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VarTypeIdCond1 = "VarTypeIdCond1";    //变量类型Id_条件1

 /// <summary>
 /// 常量:"VarTypeIdCond2"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VarTypeIdCond2 = "VarTypeIdCond2";    //变量类型Id_条件2
}

}