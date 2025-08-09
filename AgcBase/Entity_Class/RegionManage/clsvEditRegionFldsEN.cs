
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvEditRegionFldsEN
 表名:vEditRegionFlds(00050126)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:07:10
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:区域管理(RegionManage)
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
 /// 表vEditRegionFlds的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vEditRegionFlds
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
public K_mId_vEditRegionFlds(long lngmId)
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
 /// <returns>返回:[K_mId_vEditRegionFlds]类型的对象</returns>
public static implicit operator K_mId_vEditRegionFlds(long value)
{
return new K_mId_vEditRegionFlds(value);
}
}
 /// <summary>
 /// v编辑区域字段(vEditRegionFlds)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvEditRegionFldsEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vEditRegionFlds"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 34;
public static string[] _AttributeName = new string[] {"mId", "RegionId", "RegionTypeId", "TabId", "TabName", "FldId", "FldName", "LabelCaption", "CtlTypeId", "CtlTypeName", "CtlCnName", "CtlTypeAbbr", "CallTabFeatureId", "VarId", "DdlItemsOptionId", "DdlItemsOptionName", "DsTabId", "DsCondStr", "DsSqlStr", "ItemsString", "ColSpan", "ColIndex", "Width", "IsMultiRow", "SeqNum", "InOutTypeId", "InOutTypeName", "ClickEvent", "ChangeEvent", "InUse", "UpdUser", "UpdDate", "Memo", "PrjId"};

protected long mlngmId;    //mId
protected string mstrRegionId;    //区域Id
protected string mstrRegionTypeId;    //区域类型Id
protected string mstrTabId;    //表ID
protected string mstrTabName;    //表名
protected string mstrFldId;    //字段Id
protected string mstrFldName;    //字段名
protected string mstrLabelCaption;    //标签标题
protected string mstrCtlTypeId;    //控件类型号
protected string mstrCtlTypeName;    //控件类型名
protected string mstrCtlCnName;    //控件类型中文名
protected string mstrCtlTypeAbbr;    //控件类型缩写
protected string mstrCallTabFeatureId;    //调用表功能Id
protected string mstrVarId;    //变量Id
protected string mstrDdlItemsOptionId;    //下拉框列表选项ID
protected string mstrDdlItemsOptionName;    //下拉选项名
protected string mstrDsTabId;    //数据源表ID
protected string mstrDsCondStr;    //数据源条件串
protected string mstrDsSqlStr;    //数据源SQL串
protected string mstrItemsString;    //列表项串
protected int? mintColSpan;    //跨列数
protected int? mintColIndex;    //列序号
protected int? mintWidth;    //宽
protected bool mbolIsMultiRow;    //是否多行
protected int mintSeqNum;    //字段序号
protected string mstrInOutTypeId;    //INOUT类型ID
protected string mstrInOutTypeName;    //INOUT类型名称
protected string mstrClickEvent;    //Click事件
protected string mstrChangeEvent;    //Change事件
protected bool mbolInUse;    //是否在用
protected string mstrUpdUser;    //修改者
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //说明
protected string mstrPrjId;    //工程Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvEditRegionFldsEN()
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
public clsvEditRegionFldsEN(long lngmId)
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
if (strAttributeName  ==  convEditRegionFlds.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convEditRegionFlds.RegionId)
{
return mstrRegionId;
}
else if (strAttributeName  ==  convEditRegionFlds.RegionTypeId)
{
return mstrRegionTypeId;
}
else if (strAttributeName  ==  convEditRegionFlds.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  convEditRegionFlds.TabName)
{
return mstrTabName;
}
else if (strAttributeName  ==  convEditRegionFlds.FldId)
{
return mstrFldId;
}
else if (strAttributeName  ==  convEditRegionFlds.FldName)
{
return mstrFldName;
}
else if (strAttributeName  ==  convEditRegionFlds.LabelCaption)
{
return mstrLabelCaption;
}
else if (strAttributeName  ==  convEditRegionFlds.CtlTypeId)
{
return mstrCtlTypeId;
}
else if (strAttributeName  ==  convEditRegionFlds.CtlTypeName)
{
return mstrCtlTypeName;
}
else if (strAttributeName  ==  convEditRegionFlds.CtlCnName)
{
return mstrCtlCnName;
}
else if (strAttributeName  ==  convEditRegionFlds.CtlTypeAbbr)
{
return mstrCtlTypeAbbr;
}
else if (strAttributeName  ==  convEditRegionFlds.CallTabFeatureId)
{
return mstrCallTabFeatureId;
}
else if (strAttributeName  ==  convEditRegionFlds.VarId)
{
return mstrVarId;
}
else if (strAttributeName  ==  convEditRegionFlds.DdlItemsOptionId)
{
return mstrDdlItemsOptionId;
}
else if (strAttributeName  ==  convEditRegionFlds.DdlItemsOptionName)
{
return mstrDdlItemsOptionName;
}
else if (strAttributeName  ==  convEditRegionFlds.DsTabId)
{
return mstrDsTabId;
}
else if (strAttributeName  ==  convEditRegionFlds.DsCondStr)
{
return mstrDsCondStr;
}
else if (strAttributeName  ==  convEditRegionFlds.DsSqlStr)
{
return mstrDsSqlStr;
}
else if (strAttributeName  ==  convEditRegionFlds.ItemsString)
{
return mstrItemsString;
}
else if (strAttributeName  ==  convEditRegionFlds.ColSpan)
{
return mintColSpan;
}
else if (strAttributeName  ==  convEditRegionFlds.ColIndex)
{
return mintColIndex;
}
else if (strAttributeName  ==  convEditRegionFlds.Width)
{
return mintWidth;
}
else if (strAttributeName  ==  convEditRegionFlds.IsMultiRow)
{
return mbolIsMultiRow;
}
else if (strAttributeName  ==  convEditRegionFlds.SeqNum)
{
return mintSeqNum;
}
else if (strAttributeName  ==  convEditRegionFlds.InOutTypeId)
{
return mstrInOutTypeId;
}
else if (strAttributeName  ==  convEditRegionFlds.InOutTypeName)
{
return mstrInOutTypeName;
}
else if (strAttributeName  ==  convEditRegionFlds.ClickEvent)
{
return mstrClickEvent;
}
else if (strAttributeName  ==  convEditRegionFlds.ChangeEvent)
{
return mstrChangeEvent;
}
else if (strAttributeName  ==  convEditRegionFlds.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  convEditRegionFlds.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convEditRegionFlds.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convEditRegionFlds.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convEditRegionFlds.PrjId)
{
return mstrPrjId;
}
return null;
}
set
{
if (strAttributeName  ==  convEditRegionFlds.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convEditRegionFlds.mId);
}
else if (strAttributeName  ==  convEditRegionFlds.RegionId)
{
mstrRegionId = value.ToString();
 AddUpdatedFld(convEditRegionFlds.RegionId);
}
else if (strAttributeName  ==  convEditRegionFlds.RegionTypeId)
{
mstrRegionTypeId = value.ToString();
 AddUpdatedFld(convEditRegionFlds.RegionTypeId);
}
else if (strAttributeName  ==  convEditRegionFlds.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(convEditRegionFlds.TabId);
}
else if (strAttributeName  ==  convEditRegionFlds.TabName)
{
mstrTabName = value.ToString();
 AddUpdatedFld(convEditRegionFlds.TabName);
}
else if (strAttributeName  ==  convEditRegionFlds.FldId)
{
mstrFldId = value.ToString();
 AddUpdatedFld(convEditRegionFlds.FldId);
}
else if (strAttributeName  ==  convEditRegionFlds.FldName)
{
mstrFldName = value.ToString();
 AddUpdatedFld(convEditRegionFlds.FldName);
}
else if (strAttributeName  ==  convEditRegionFlds.LabelCaption)
{
mstrLabelCaption = value.ToString();
 AddUpdatedFld(convEditRegionFlds.LabelCaption);
}
else if (strAttributeName  ==  convEditRegionFlds.CtlTypeId)
{
mstrCtlTypeId = value.ToString();
 AddUpdatedFld(convEditRegionFlds.CtlTypeId);
}
else if (strAttributeName  ==  convEditRegionFlds.CtlTypeName)
{
mstrCtlTypeName = value.ToString();
 AddUpdatedFld(convEditRegionFlds.CtlTypeName);
}
else if (strAttributeName  ==  convEditRegionFlds.CtlCnName)
{
mstrCtlCnName = value.ToString();
 AddUpdatedFld(convEditRegionFlds.CtlCnName);
}
else if (strAttributeName  ==  convEditRegionFlds.CtlTypeAbbr)
{
mstrCtlTypeAbbr = value.ToString();
 AddUpdatedFld(convEditRegionFlds.CtlTypeAbbr);
}
else if (strAttributeName  ==  convEditRegionFlds.CallTabFeatureId)
{
mstrCallTabFeatureId = value.ToString();
 AddUpdatedFld(convEditRegionFlds.CallTabFeatureId);
}
else if (strAttributeName  ==  convEditRegionFlds.VarId)
{
mstrVarId = value.ToString();
 AddUpdatedFld(convEditRegionFlds.VarId);
}
else if (strAttributeName  ==  convEditRegionFlds.DdlItemsOptionId)
{
mstrDdlItemsOptionId = value.ToString();
 AddUpdatedFld(convEditRegionFlds.DdlItemsOptionId);
}
else if (strAttributeName  ==  convEditRegionFlds.DdlItemsOptionName)
{
mstrDdlItemsOptionName = value.ToString();
 AddUpdatedFld(convEditRegionFlds.DdlItemsOptionName);
}
else if (strAttributeName  ==  convEditRegionFlds.DsTabId)
{
mstrDsTabId = value.ToString();
 AddUpdatedFld(convEditRegionFlds.DsTabId);
}
else if (strAttributeName  ==  convEditRegionFlds.DsCondStr)
{
mstrDsCondStr = value.ToString();
 AddUpdatedFld(convEditRegionFlds.DsCondStr);
}
else if (strAttributeName  ==  convEditRegionFlds.DsSqlStr)
{
mstrDsSqlStr = value.ToString();
 AddUpdatedFld(convEditRegionFlds.DsSqlStr);
}
else if (strAttributeName  ==  convEditRegionFlds.ItemsString)
{
mstrItemsString = value.ToString();
 AddUpdatedFld(convEditRegionFlds.ItemsString);
}
else if (strAttributeName  ==  convEditRegionFlds.ColSpan)
{
mintColSpan = TransNullToInt(value.ToString());
 AddUpdatedFld(convEditRegionFlds.ColSpan);
}
else if (strAttributeName  ==  convEditRegionFlds.ColIndex)
{
mintColIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convEditRegionFlds.ColIndex);
}
else if (strAttributeName  ==  convEditRegionFlds.Width)
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(convEditRegionFlds.Width);
}
else if (strAttributeName  ==  convEditRegionFlds.IsMultiRow)
{
mbolIsMultiRow = TransNullToBool(value.ToString());
 AddUpdatedFld(convEditRegionFlds.IsMultiRow);
}
else if (strAttributeName  ==  convEditRegionFlds.SeqNum)
{
mintSeqNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convEditRegionFlds.SeqNum);
}
else if (strAttributeName  ==  convEditRegionFlds.InOutTypeId)
{
mstrInOutTypeId = value.ToString();
 AddUpdatedFld(convEditRegionFlds.InOutTypeId);
}
else if (strAttributeName  ==  convEditRegionFlds.InOutTypeName)
{
mstrInOutTypeName = value.ToString();
 AddUpdatedFld(convEditRegionFlds.InOutTypeName);
}
else if (strAttributeName  ==  convEditRegionFlds.ClickEvent)
{
mstrClickEvent = value.ToString();
 AddUpdatedFld(convEditRegionFlds.ClickEvent);
}
else if (strAttributeName  ==  convEditRegionFlds.ChangeEvent)
{
mstrChangeEvent = value.ToString();
 AddUpdatedFld(convEditRegionFlds.ChangeEvent);
}
else if (strAttributeName  ==  convEditRegionFlds.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convEditRegionFlds.InUse);
}
else if (strAttributeName  ==  convEditRegionFlds.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convEditRegionFlds.UpdUser);
}
else if (strAttributeName  ==  convEditRegionFlds.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convEditRegionFlds.UpdDate);
}
else if (strAttributeName  ==  convEditRegionFlds.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convEditRegionFlds.Memo);
}
else if (strAttributeName  ==  convEditRegionFlds.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convEditRegionFlds.PrjId);
}
}
}
public object this[int intIndex]
{
get
{
if (convEditRegionFlds.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (convEditRegionFlds.RegionId  ==  _AttributeName[intIndex])
{
return mstrRegionId;
}
else if (convEditRegionFlds.RegionTypeId  ==  _AttributeName[intIndex])
{
return mstrRegionTypeId;
}
else if (convEditRegionFlds.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (convEditRegionFlds.TabName  ==  _AttributeName[intIndex])
{
return mstrTabName;
}
else if (convEditRegionFlds.FldId  ==  _AttributeName[intIndex])
{
return mstrFldId;
}
else if (convEditRegionFlds.FldName  ==  _AttributeName[intIndex])
{
return mstrFldName;
}
else if (convEditRegionFlds.LabelCaption  ==  _AttributeName[intIndex])
{
return mstrLabelCaption;
}
else if (convEditRegionFlds.CtlTypeId  ==  _AttributeName[intIndex])
{
return mstrCtlTypeId;
}
else if (convEditRegionFlds.CtlTypeName  ==  _AttributeName[intIndex])
{
return mstrCtlTypeName;
}
else if (convEditRegionFlds.CtlCnName  ==  _AttributeName[intIndex])
{
return mstrCtlCnName;
}
else if (convEditRegionFlds.CtlTypeAbbr  ==  _AttributeName[intIndex])
{
return mstrCtlTypeAbbr;
}
else if (convEditRegionFlds.CallTabFeatureId  ==  _AttributeName[intIndex])
{
return mstrCallTabFeatureId;
}
else if (convEditRegionFlds.VarId  ==  _AttributeName[intIndex])
{
return mstrVarId;
}
else if (convEditRegionFlds.DdlItemsOptionId  ==  _AttributeName[intIndex])
{
return mstrDdlItemsOptionId;
}
else if (convEditRegionFlds.DdlItemsOptionName  ==  _AttributeName[intIndex])
{
return mstrDdlItemsOptionName;
}
else if (convEditRegionFlds.DsTabId  ==  _AttributeName[intIndex])
{
return mstrDsTabId;
}
else if (convEditRegionFlds.DsCondStr  ==  _AttributeName[intIndex])
{
return mstrDsCondStr;
}
else if (convEditRegionFlds.DsSqlStr  ==  _AttributeName[intIndex])
{
return mstrDsSqlStr;
}
else if (convEditRegionFlds.ItemsString  ==  _AttributeName[intIndex])
{
return mstrItemsString;
}
else if (convEditRegionFlds.ColSpan  ==  _AttributeName[intIndex])
{
return mintColSpan;
}
else if (convEditRegionFlds.ColIndex  ==  _AttributeName[intIndex])
{
return mintColIndex;
}
else if (convEditRegionFlds.Width  ==  _AttributeName[intIndex])
{
return mintWidth;
}
else if (convEditRegionFlds.IsMultiRow  ==  _AttributeName[intIndex])
{
return mbolIsMultiRow;
}
else if (convEditRegionFlds.SeqNum  ==  _AttributeName[intIndex])
{
return mintSeqNum;
}
else if (convEditRegionFlds.InOutTypeId  ==  _AttributeName[intIndex])
{
return mstrInOutTypeId;
}
else if (convEditRegionFlds.InOutTypeName  ==  _AttributeName[intIndex])
{
return mstrInOutTypeName;
}
else if (convEditRegionFlds.ClickEvent  ==  _AttributeName[intIndex])
{
return mstrClickEvent;
}
else if (convEditRegionFlds.ChangeEvent  ==  _AttributeName[intIndex])
{
return mstrChangeEvent;
}
else if (convEditRegionFlds.InUse  ==  _AttributeName[intIndex])
{
return mbolInUse;
}
else if (convEditRegionFlds.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convEditRegionFlds.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convEditRegionFlds.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (convEditRegionFlds.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
return null;
}
set
{
if (convEditRegionFlds.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convEditRegionFlds.mId);
}
else if (convEditRegionFlds.RegionId  ==  _AttributeName[intIndex])
{
mstrRegionId = value.ToString();
 AddUpdatedFld(convEditRegionFlds.RegionId);
}
else if (convEditRegionFlds.RegionTypeId  ==  _AttributeName[intIndex])
{
mstrRegionTypeId = value.ToString();
 AddUpdatedFld(convEditRegionFlds.RegionTypeId);
}
else if (convEditRegionFlds.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(convEditRegionFlds.TabId);
}
else if (convEditRegionFlds.TabName  ==  _AttributeName[intIndex])
{
mstrTabName = value.ToString();
 AddUpdatedFld(convEditRegionFlds.TabName);
}
else if (convEditRegionFlds.FldId  ==  _AttributeName[intIndex])
{
mstrFldId = value.ToString();
 AddUpdatedFld(convEditRegionFlds.FldId);
}
else if (convEditRegionFlds.FldName  ==  _AttributeName[intIndex])
{
mstrFldName = value.ToString();
 AddUpdatedFld(convEditRegionFlds.FldName);
}
else if (convEditRegionFlds.LabelCaption  ==  _AttributeName[intIndex])
{
mstrLabelCaption = value.ToString();
 AddUpdatedFld(convEditRegionFlds.LabelCaption);
}
else if (convEditRegionFlds.CtlTypeId  ==  _AttributeName[intIndex])
{
mstrCtlTypeId = value.ToString();
 AddUpdatedFld(convEditRegionFlds.CtlTypeId);
}
else if (convEditRegionFlds.CtlTypeName  ==  _AttributeName[intIndex])
{
mstrCtlTypeName = value.ToString();
 AddUpdatedFld(convEditRegionFlds.CtlTypeName);
}
else if (convEditRegionFlds.CtlCnName  ==  _AttributeName[intIndex])
{
mstrCtlCnName = value.ToString();
 AddUpdatedFld(convEditRegionFlds.CtlCnName);
}
else if (convEditRegionFlds.CtlTypeAbbr  ==  _AttributeName[intIndex])
{
mstrCtlTypeAbbr = value.ToString();
 AddUpdatedFld(convEditRegionFlds.CtlTypeAbbr);
}
else if (convEditRegionFlds.CallTabFeatureId  ==  _AttributeName[intIndex])
{
mstrCallTabFeatureId = value.ToString();
 AddUpdatedFld(convEditRegionFlds.CallTabFeatureId);
}
else if (convEditRegionFlds.VarId  ==  _AttributeName[intIndex])
{
mstrVarId = value.ToString();
 AddUpdatedFld(convEditRegionFlds.VarId);
}
else if (convEditRegionFlds.DdlItemsOptionId  ==  _AttributeName[intIndex])
{
mstrDdlItemsOptionId = value.ToString();
 AddUpdatedFld(convEditRegionFlds.DdlItemsOptionId);
}
else if (convEditRegionFlds.DdlItemsOptionName  ==  _AttributeName[intIndex])
{
mstrDdlItemsOptionName = value.ToString();
 AddUpdatedFld(convEditRegionFlds.DdlItemsOptionName);
}
else if (convEditRegionFlds.DsTabId  ==  _AttributeName[intIndex])
{
mstrDsTabId = value.ToString();
 AddUpdatedFld(convEditRegionFlds.DsTabId);
}
else if (convEditRegionFlds.DsCondStr  ==  _AttributeName[intIndex])
{
mstrDsCondStr = value.ToString();
 AddUpdatedFld(convEditRegionFlds.DsCondStr);
}
else if (convEditRegionFlds.DsSqlStr  ==  _AttributeName[intIndex])
{
mstrDsSqlStr = value.ToString();
 AddUpdatedFld(convEditRegionFlds.DsSqlStr);
}
else if (convEditRegionFlds.ItemsString  ==  _AttributeName[intIndex])
{
mstrItemsString = value.ToString();
 AddUpdatedFld(convEditRegionFlds.ItemsString);
}
else if (convEditRegionFlds.ColSpan  ==  _AttributeName[intIndex])
{
mintColSpan = TransNullToInt(value.ToString());
 AddUpdatedFld(convEditRegionFlds.ColSpan);
}
else if (convEditRegionFlds.ColIndex  ==  _AttributeName[intIndex])
{
mintColIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convEditRegionFlds.ColIndex);
}
else if (convEditRegionFlds.Width  ==  _AttributeName[intIndex])
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(convEditRegionFlds.Width);
}
else if (convEditRegionFlds.IsMultiRow  ==  _AttributeName[intIndex])
{
mbolIsMultiRow = TransNullToBool(value.ToString());
 AddUpdatedFld(convEditRegionFlds.IsMultiRow);
}
else if (convEditRegionFlds.SeqNum  ==  _AttributeName[intIndex])
{
mintSeqNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convEditRegionFlds.SeqNum);
}
else if (convEditRegionFlds.InOutTypeId  ==  _AttributeName[intIndex])
{
mstrInOutTypeId = value.ToString();
 AddUpdatedFld(convEditRegionFlds.InOutTypeId);
}
else if (convEditRegionFlds.InOutTypeName  ==  _AttributeName[intIndex])
{
mstrInOutTypeName = value.ToString();
 AddUpdatedFld(convEditRegionFlds.InOutTypeName);
}
else if (convEditRegionFlds.ClickEvent  ==  _AttributeName[intIndex])
{
mstrClickEvent = value.ToString();
 AddUpdatedFld(convEditRegionFlds.ClickEvent);
}
else if (convEditRegionFlds.ChangeEvent  ==  _AttributeName[intIndex])
{
mstrChangeEvent = value.ToString();
 AddUpdatedFld(convEditRegionFlds.ChangeEvent);
}
else if (convEditRegionFlds.InUse  ==  _AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convEditRegionFlds.InUse);
}
else if (convEditRegionFlds.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convEditRegionFlds.UpdUser);
}
else if (convEditRegionFlds.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convEditRegionFlds.UpdDate);
}
else if (convEditRegionFlds.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convEditRegionFlds.Memo);
}
else if (convEditRegionFlds.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convEditRegionFlds.PrjId);
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
 AddUpdatedFld(convEditRegionFlds.mId);
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
 AddUpdatedFld(convEditRegionFlds.RegionId);
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
 AddUpdatedFld(convEditRegionFlds.RegionTypeId);
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
 AddUpdatedFld(convEditRegionFlds.TabId);
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
 AddUpdatedFld(convEditRegionFlds.TabName);
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
 AddUpdatedFld(convEditRegionFlds.FldId);
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
 AddUpdatedFld(convEditRegionFlds.FldName);
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
 AddUpdatedFld(convEditRegionFlds.LabelCaption);
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
 AddUpdatedFld(convEditRegionFlds.CtlTypeId);
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
 AddUpdatedFld(convEditRegionFlds.CtlTypeName);
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
 AddUpdatedFld(convEditRegionFlds.CtlCnName);
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
 AddUpdatedFld(convEditRegionFlds.CtlTypeAbbr);
}
}
/// <summary>
/// 调用表功能Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CallTabFeatureId
{
get
{
return mstrCallTabFeatureId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCallTabFeatureId = value;
}
else
{
 mstrCallTabFeatureId = value;
}
//记录修改过的字段
 AddUpdatedFld(convEditRegionFlds.CallTabFeatureId);
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
 AddUpdatedFld(convEditRegionFlds.VarId);
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
 AddUpdatedFld(convEditRegionFlds.DdlItemsOptionId);
}
}
/// <summary>
/// 下拉选项名(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DdlItemsOptionName
{
get
{
return mstrDdlItemsOptionName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDdlItemsOptionName = value;
}
else
{
 mstrDdlItemsOptionName = value;
}
//记录修改过的字段
 AddUpdatedFld(convEditRegionFlds.DdlItemsOptionName);
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
 AddUpdatedFld(convEditRegionFlds.DsTabId);
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
 AddUpdatedFld(convEditRegionFlds.DsCondStr);
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
 AddUpdatedFld(convEditRegionFlds.DsSqlStr);
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
 AddUpdatedFld(convEditRegionFlds.ItemsString);
}
}
/// <summary>
/// 跨列数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? ColSpan
{
get
{
return mintColSpan;
}
set
{
 mintColSpan = value;
//记录修改过的字段
 AddUpdatedFld(convEditRegionFlds.ColSpan);
}
}
/// <summary>
/// 列序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? ColIndex
{
get
{
return mintColIndex;
}
set
{
 mintColIndex = value;
//记录修改过的字段
 AddUpdatedFld(convEditRegionFlds.ColIndex);
}
}
/// <summary>
/// 宽(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? Width
{
get
{
return mintWidth;
}
set
{
 mintWidth = value;
//记录修改过的字段
 AddUpdatedFld(convEditRegionFlds.Width);
}
}
/// <summary>
/// 是否多行(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsMultiRow
{
get
{
return mbolIsMultiRow;
}
set
{
 mbolIsMultiRow = value;
//记录修改过的字段
 AddUpdatedFld(convEditRegionFlds.IsMultiRow);
}
}
/// <summary>
/// 字段序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int SeqNum
{
get
{
return mintSeqNum;
}
set
{
 mintSeqNum = value;
//记录修改过的字段
 AddUpdatedFld(convEditRegionFlds.SeqNum);
}
}
/// <summary>
/// INOUT类型ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string InOutTypeId
{
get
{
return mstrInOutTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrInOutTypeId = value;
}
else
{
 mstrInOutTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convEditRegionFlds.InOutTypeId);
}
}
/// <summary>
/// INOUT类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string InOutTypeName
{
get
{
return mstrInOutTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrInOutTypeName = value;
}
else
{
 mstrInOutTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convEditRegionFlds.InOutTypeName);
}
}
/// <summary>
/// Click事件(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClickEvent
{
get
{
return mstrClickEvent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClickEvent = value;
}
else
{
 mstrClickEvent = value;
}
//记录修改过的字段
 AddUpdatedFld(convEditRegionFlds.ClickEvent);
}
}
/// <summary>
/// Change事件(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ChangeEvent
{
get
{
return mstrChangeEvent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrChangeEvent = value;
}
else
{
 mstrChangeEvent = value;
}
//记录修改过的字段
 AddUpdatedFld(convEditRegionFlds.ChangeEvent);
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
 AddUpdatedFld(convEditRegionFlds.InUse);
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
 AddUpdatedFld(convEditRegionFlds.UpdUser);
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
 AddUpdatedFld(convEditRegionFlds.UpdDate);
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
 AddUpdatedFld(convEditRegionFlds.Memo);
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
 AddUpdatedFld(convEditRegionFlds.PrjId);
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
 /// v编辑区域字段(vEditRegionFlds)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convEditRegionFlds
{
public const string _CurrTabName = "vEditRegionFlds"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "RegionId", "RegionTypeId", "TabId", "TabName", "FldId", "FldName", "LabelCaption", "CtlTypeId", "CtlTypeName", "CtlCnName", "CtlTypeAbbr", "CallTabFeatureId", "VarId", "DdlItemsOptionId", "DdlItemsOptionName", "DsTabId", "DsCondStr", "DsSqlStr", "ItemsString", "ColSpan", "ColIndex", "Width", "IsMultiRow", "SeqNum", "InOutTypeId", "InOutTypeName", "ClickEvent", "ChangeEvent", "InUse", "UpdUser", "UpdDate", "Memo", "PrjId"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"RegionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RegionId = "RegionId";    //区域Id

 /// <summary>
 /// 常量:"RegionTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RegionTypeId = "RegionTypeId";    //区域类型Id

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
 /// 常量:"CallTabFeatureId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CallTabFeatureId = "CallTabFeatureId";    //调用表功能Id

 /// <summary>
 /// 常量:"VarId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VarId = "VarId";    //变量Id

 /// <summary>
 /// 常量:"DdlItemsOptionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DdlItemsOptionId = "DdlItemsOptionId";    //下拉框列表选项ID

 /// <summary>
 /// 常量:"DdlItemsOptionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DdlItemsOptionName = "DdlItemsOptionName";    //下拉选项名

 /// <summary>
 /// 常量:"DsTabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DsTabId = "DsTabId";    //数据源表ID

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
 /// 常量:"ColSpan"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ColSpan = "ColSpan";    //跨列数

 /// <summary>
 /// 常量:"ColIndex"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ColIndex = "ColIndex";    //列序号

 /// <summary>
 /// 常量:"Width"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Width = "Width";    //宽

 /// <summary>
 /// 常量:"IsMultiRow"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsMultiRow = "IsMultiRow";    //是否多行

 /// <summary>
 /// 常量:"SeqNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SeqNum = "SeqNum";    //字段序号

 /// <summary>
 /// 常量:"InOutTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InOutTypeId = "InOutTypeId";    //INOUT类型ID

 /// <summary>
 /// 常量:"InOutTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InOutTypeName = "InOutTypeName";    //INOUT类型名称

 /// <summary>
 /// 常量:"ClickEvent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClickEvent = "ClickEvent";    //Click事件

 /// <summary>
 /// 常量:"ChangeEvent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ChangeEvent = "ChangeEvent";    //Change事件

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

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id
}

}