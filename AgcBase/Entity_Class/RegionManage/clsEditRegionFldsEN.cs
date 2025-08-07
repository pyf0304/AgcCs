
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsEditRegionFldsEN
 表名:EditRegionFlds(00050116)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:27:01
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
 /// 表EditRegionFlds的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_EditRegionFlds
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
public K_mId_EditRegionFlds(long lngmId)
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
 /// <returns>返回:[K_mId_EditRegionFlds]类型的对象</returns>
public static implicit operator K_mId_EditRegionFlds(long value)
{
return new K_mId_EditRegionFlds(value);
}
}
 /// <summary>
 /// 编辑区域字段(EditRegionFlds)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsEditRegionFldsEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "EditRegionFlds"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 32;
public static string[] _AttributeName = new string[] {"mId", "RegionId", "FldId", "LabelCaption", "CtlTypeId", "CallTabFeatureId", "VarId", "DefaultValue", "DdlItemsOptionId", "DsTabId", "TabFeatureId4Ddl", "FldIdCond1", "VarIdCond1", "FldIdCond2", "VarIdCond2", "DsCondStr", "DsSqlStr", "ItemsString", "ColSpan", "ColIndex", "Width", "IsMultiRow", "SeqNum", "InOutTypeId", "ClickEvent", "ChangeEvent", "InUse", "ErrMsg", "PrjId", "UpdUser", "UpdDate", "Memo"};

protected long mlngmId;    //mId
protected string mstrRegionId;    //区域Id
protected string mstrFldId;    //字段Id
protected string mstrLabelCaption;    //标签标题
protected string mstrCtlTypeId;    //控件类型号
protected string mstrCallTabFeatureId;    //调用表功能Id
protected string mstrVarId;    //变量Id
protected string mstrDefaultValue;    //缺省值
protected string mstrDdlItemsOptionId;    //下拉框列表选项ID
protected string mstrDsTabId;    //数据源表ID
protected string mstrTabFeatureId4Ddl;    //下拉框表功能Id
protected string mstrFldIdCond1;    //字段Id_条件1
protected string mstrVarIdCond1;    //变量Id_条件1
protected string mstrFldIdCond2;    //字段Id_条件2
protected string mstrVarIdCond2;    //数据源字段_条件1
protected string mstrDsCondStr;    //数据源条件串
protected string mstrDsSqlStr;    //数据源SQL串
protected string mstrItemsString;    //列表项串
protected int? mintColSpan;    //跨列数
protected int? mintColIndex;    //列序号
protected int? mintWidth;    //宽
protected bool mbolIsMultiRow;    //是否多行
protected int? mintSeqNum;    //字段序号
protected string mstrInOutTypeId;    //INOUT类型ID
protected string mstrClickEvent;    //Click事件
protected string mstrChangeEvent;    //Change事件
protected bool mbolInUse;    //是否在用
protected string mstrErrMsg;    //错误信息
protected string mstrPrjId;    //工程Id
protected string mstrUpdUser;    //修改者
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsEditRegionFldsEN()
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
public clsEditRegionFldsEN(long lngmId)
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
if (strAttributeName  ==  conEditRegionFlds.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conEditRegionFlds.RegionId)
{
return mstrRegionId;
}
else if (strAttributeName  ==  conEditRegionFlds.FldId)
{
return mstrFldId;
}
else if (strAttributeName  ==  conEditRegionFlds.LabelCaption)
{
return mstrLabelCaption;
}
else if (strAttributeName  ==  conEditRegionFlds.CtlTypeId)
{
return mstrCtlTypeId;
}
else if (strAttributeName  ==  conEditRegionFlds.CallTabFeatureId)
{
return mstrCallTabFeatureId;
}
else if (strAttributeName  ==  conEditRegionFlds.VarId)
{
return mstrVarId;
}
else if (strAttributeName  ==  conEditRegionFlds.DefaultValue)
{
return mstrDefaultValue;
}
else if (strAttributeName  ==  conEditRegionFlds.DdlItemsOptionId)
{
return mstrDdlItemsOptionId;
}
else if (strAttributeName  ==  conEditRegionFlds.DsTabId)
{
return mstrDsTabId;
}
else if (strAttributeName  ==  conEditRegionFlds.TabFeatureId4Ddl)
{
return mstrTabFeatureId4Ddl;
}
else if (strAttributeName  ==  conEditRegionFlds.FldIdCond1)
{
return mstrFldIdCond1;
}
else if (strAttributeName  ==  conEditRegionFlds.VarIdCond1)
{
return mstrVarIdCond1;
}
else if (strAttributeName  ==  conEditRegionFlds.FldIdCond2)
{
return mstrFldIdCond2;
}
else if (strAttributeName  ==  conEditRegionFlds.VarIdCond2)
{
return mstrVarIdCond2;
}
else if (strAttributeName  ==  conEditRegionFlds.DsCondStr)
{
return mstrDsCondStr;
}
else if (strAttributeName  ==  conEditRegionFlds.DsSqlStr)
{
return mstrDsSqlStr;
}
else if (strAttributeName  ==  conEditRegionFlds.ItemsString)
{
return mstrItemsString;
}
else if (strAttributeName  ==  conEditRegionFlds.ColSpan)
{
return mintColSpan;
}
else if (strAttributeName  ==  conEditRegionFlds.ColIndex)
{
return mintColIndex;
}
else if (strAttributeName  ==  conEditRegionFlds.Width)
{
return mintWidth;
}
else if (strAttributeName  ==  conEditRegionFlds.IsMultiRow)
{
return mbolIsMultiRow;
}
else if (strAttributeName  ==  conEditRegionFlds.SeqNum)
{
return mintSeqNum;
}
else if (strAttributeName  ==  conEditRegionFlds.InOutTypeId)
{
return mstrInOutTypeId;
}
else if (strAttributeName  ==  conEditRegionFlds.ClickEvent)
{
return mstrClickEvent;
}
else if (strAttributeName  ==  conEditRegionFlds.ChangeEvent)
{
return mstrChangeEvent;
}
else if (strAttributeName  ==  conEditRegionFlds.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  conEditRegionFlds.ErrMsg)
{
return mstrErrMsg;
}
else if (strAttributeName  ==  conEditRegionFlds.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conEditRegionFlds.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conEditRegionFlds.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conEditRegionFlds.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conEditRegionFlds.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conEditRegionFlds.mId);
}
else if (strAttributeName  ==  conEditRegionFlds.RegionId)
{
mstrRegionId = value.ToString();
 AddUpdatedFld(conEditRegionFlds.RegionId);
}
else if (strAttributeName  ==  conEditRegionFlds.FldId)
{
mstrFldId = value.ToString();
 AddUpdatedFld(conEditRegionFlds.FldId);
}
else if (strAttributeName  ==  conEditRegionFlds.LabelCaption)
{
mstrLabelCaption = value.ToString();
 AddUpdatedFld(conEditRegionFlds.LabelCaption);
}
else if (strAttributeName  ==  conEditRegionFlds.CtlTypeId)
{
mstrCtlTypeId = value.ToString();
 AddUpdatedFld(conEditRegionFlds.CtlTypeId);
}
else if (strAttributeName  ==  conEditRegionFlds.CallTabFeatureId)
{
mstrCallTabFeatureId = value.ToString();
 AddUpdatedFld(conEditRegionFlds.CallTabFeatureId);
}
else if (strAttributeName  ==  conEditRegionFlds.VarId)
{
mstrVarId = value.ToString();
 AddUpdatedFld(conEditRegionFlds.VarId);
}
else if (strAttributeName  ==  conEditRegionFlds.DefaultValue)
{
mstrDefaultValue = value.ToString();
 AddUpdatedFld(conEditRegionFlds.DefaultValue);
}
else if (strAttributeName  ==  conEditRegionFlds.DdlItemsOptionId)
{
mstrDdlItemsOptionId = value.ToString();
 AddUpdatedFld(conEditRegionFlds.DdlItemsOptionId);
}
else if (strAttributeName  ==  conEditRegionFlds.DsTabId)
{
mstrDsTabId = value.ToString();
 AddUpdatedFld(conEditRegionFlds.DsTabId);
}
else if (strAttributeName  ==  conEditRegionFlds.TabFeatureId4Ddl)
{
mstrTabFeatureId4Ddl = value.ToString();
 AddUpdatedFld(conEditRegionFlds.TabFeatureId4Ddl);
}
else if (strAttributeName  ==  conEditRegionFlds.FldIdCond1)
{
mstrFldIdCond1 = value.ToString();
 AddUpdatedFld(conEditRegionFlds.FldIdCond1);
}
else if (strAttributeName  ==  conEditRegionFlds.VarIdCond1)
{
mstrVarIdCond1 = value.ToString();
 AddUpdatedFld(conEditRegionFlds.VarIdCond1);
}
else if (strAttributeName  ==  conEditRegionFlds.FldIdCond2)
{
mstrFldIdCond2 = value.ToString();
 AddUpdatedFld(conEditRegionFlds.FldIdCond2);
}
else if (strAttributeName  ==  conEditRegionFlds.VarIdCond2)
{
mstrVarIdCond2 = value.ToString();
 AddUpdatedFld(conEditRegionFlds.VarIdCond2);
}
else if (strAttributeName  ==  conEditRegionFlds.DsCondStr)
{
mstrDsCondStr = value.ToString();
 AddUpdatedFld(conEditRegionFlds.DsCondStr);
}
else if (strAttributeName  ==  conEditRegionFlds.DsSqlStr)
{
mstrDsSqlStr = value.ToString();
 AddUpdatedFld(conEditRegionFlds.DsSqlStr);
}
else if (strAttributeName  ==  conEditRegionFlds.ItemsString)
{
mstrItemsString = value.ToString();
 AddUpdatedFld(conEditRegionFlds.ItemsString);
}
else if (strAttributeName  ==  conEditRegionFlds.ColSpan)
{
mintColSpan = TransNullToInt(value.ToString());
 AddUpdatedFld(conEditRegionFlds.ColSpan);
}
else if (strAttributeName  ==  conEditRegionFlds.ColIndex)
{
mintColIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(conEditRegionFlds.ColIndex);
}
else if (strAttributeName  ==  conEditRegionFlds.Width)
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(conEditRegionFlds.Width);
}
else if (strAttributeName  ==  conEditRegionFlds.IsMultiRow)
{
mbolIsMultiRow = TransNullToBool(value.ToString());
 AddUpdatedFld(conEditRegionFlds.IsMultiRow);
}
else if (strAttributeName  ==  conEditRegionFlds.SeqNum)
{
mintSeqNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conEditRegionFlds.SeqNum);
}
else if (strAttributeName  ==  conEditRegionFlds.InOutTypeId)
{
mstrInOutTypeId = value.ToString();
 AddUpdatedFld(conEditRegionFlds.InOutTypeId);
}
else if (strAttributeName  ==  conEditRegionFlds.ClickEvent)
{
mstrClickEvent = value.ToString();
 AddUpdatedFld(conEditRegionFlds.ClickEvent);
}
else if (strAttributeName  ==  conEditRegionFlds.ChangeEvent)
{
mstrChangeEvent = value.ToString();
 AddUpdatedFld(conEditRegionFlds.ChangeEvent);
}
else if (strAttributeName  ==  conEditRegionFlds.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conEditRegionFlds.InUse);
}
else if (strAttributeName  ==  conEditRegionFlds.ErrMsg)
{
mstrErrMsg = value.ToString();
 AddUpdatedFld(conEditRegionFlds.ErrMsg);
}
else if (strAttributeName  ==  conEditRegionFlds.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conEditRegionFlds.PrjId);
}
else if (strAttributeName  ==  conEditRegionFlds.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conEditRegionFlds.UpdUser);
}
else if (strAttributeName  ==  conEditRegionFlds.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conEditRegionFlds.UpdDate);
}
else if (strAttributeName  ==  conEditRegionFlds.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conEditRegionFlds.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conEditRegionFlds.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (conEditRegionFlds.RegionId  ==  _AttributeName[intIndex])
{
return mstrRegionId;
}
else if (conEditRegionFlds.FldId  ==  _AttributeName[intIndex])
{
return mstrFldId;
}
else if (conEditRegionFlds.LabelCaption  ==  _AttributeName[intIndex])
{
return mstrLabelCaption;
}
else if (conEditRegionFlds.CtlTypeId  ==  _AttributeName[intIndex])
{
return mstrCtlTypeId;
}
else if (conEditRegionFlds.CallTabFeatureId  ==  _AttributeName[intIndex])
{
return mstrCallTabFeatureId;
}
else if (conEditRegionFlds.VarId  ==  _AttributeName[intIndex])
{
return mstrVarId;
}
else if (conEditRegionFlds.DefaultValue  ==  _AttributeName[intIndex])
{
return mstrDefaultValue;
}
else if (conEditRegionFlds.DdlItemsOptionId  ==  _AttributeName[intIndex])
{
return mstrDdlItemsOptionId;
}
else if (conEditRegionFlds.DsTabId  ==  _AttributeName[intIndex])
{
return mstrDsTabId;
}
else if (conEditRegionFlds.TabFeatureId4Ddl  ==  _AttributeName[intIndex])
{
return mstrTabFeatureId4Ddl;
}
else if (conEditRegionFlds.FldIdCond1  ==  _AttributeName[intIndex])
{
return mstrFldIdCond1;
}
else if (conEditRegionFlds.VarIdCond1  ==  _AttributeName[intIndex])
{
return mstrVarIdCond1;
}
else if (conEditRegionFlds.FldIdCond2  ==  _AttributeName[intIndex])
{
return mstrFldIdCond2;
}
else if (conEditRegionFlds.VarIdCond2  ==  _AttributeName[intIndex])
{
return mstrVarIdCond2;
}
else if (conEditRegionFlds.DsCondStr  ==  _AttributeName[intIndex])
{
return mstrDsCondStr;
}
else if (conEditRegionFlds.DsSqlStr  ==  _AttributeName[intIndex])
{
return mstrDsSqlStr;
}
else if (conEditRegionFlds.ItemsString  ==  _AttributeName[intIndex])
{
return mstrItemsString;
}
else if (conEditRegionFlds.ColSpan  ==  _AttributeName[intIndex])
{
return mintColSpan;
}
else if (conEditRegionFlds.ColIndex  ==  _AttributeName[intIndex])
{
return mintColIndex;
}
else if (conEditRegionFlds.Width  ==  _AttributeName[intIndex])
{
return mintWidth;
}
else if (conEditRegionFlds.IsMultiRow  ==  _AttributeName[intIndex])
{
return mbolIsMultiRow;
}
else if (conEditRegionFlds.SeqNum  ==  _AttributeName[intIndex])
{
return mintSeqNum;
}
else if (conEditRegionFlds.InOutTypeId  ==  _AttributeName[intIndex])
{
return mstrInOutTypeId;
}
else if (conEditRegionFlds.ClickEvent  ==  _AttributeName[intIndex])
{
return mstrClickEvent;
}
else if (conEditRegionFlds.ChangeEvent  ==  _AttributeName[intIndex])
{
return mstrChangeEvent;
}
else if (conEditRegionFlds.InUse  ==  _AttributeName[intIndex])
{
return mbolInUse;
}
else if (conEditRegionFlds.ErrMsg  ==  _AttributeName[intIndex])
{
return mstrErrMsg;
}
else if (conEditRegionFlds.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conEditRegionFlds.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conEditRegionFlds.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conEditRegionFlds.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conEditRegionFlds.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conEditRegionFlds.mId);
}
else if (conEditRegionFlds.RegionId  ==  _AttributeName[intIndex])
{
mstrRegionId = value.ToString();
 AddUpdatedFld(conEditRegionFlds.RegionId);
}
else if (conEditRegionFlds.FldId  ==  _AttributeName[intIndex])
{
mstrFldId = value.ToString();
 AddUpdatedFld(conEditRegionFlds.FldId);
}
else if (conEditRegionFlds.LabelCaption  ==  _AttributeName[intIndex])
{
mstrLabelCaption = value.ToString();
 AddUpdatedFld(conEditRegionFlds.LabelCaption);
}
else if (conEditRegionFlds.CtlTypeId  ==  _AttributeName[intIndex])
{
mstrCtlTypeId = value.ToString();
 AddUpdatedFld(conEditRegionFlds.CtlTypeId);
}
else if (conEditRegionFlds.CallTabFeatureId  ==  _AttributeName[intIndex])
{
mstrCallTabFeatureId = value.ToString();
 AddUpdatedFld(conEditRegionFlds.CallTabFeatureId);
}
else if (conEditRegionFlds.VarId  ==  _AttributeName[intIndex])
{
mstrVarId = value.ToString();
 AddUpdatedFld(conEditRegionFlds.VarId);
}
else if (conEditRegionFlds.DefaultValue  ==  _AttributeName[intIndex])
{
mstrDefaultValue = value.ToString();
 AddUpdatedFld(conEditRegionFlds.DefaultValue);
}
else if (conEditRegionFlds.DdlItemsOptionId  ==  _AttributeName[intIndex])
{
mstrDdlItemsOptionId = value.ToString();
 AddUpdatedFld(conEditRegionFlds.DdlItemsOptionId);
}
else if (conEditRegionFlds.DsTabId  ==  _AttributeName[intIndex])
{
mstrDsTabId = value.ToString();
 AddUpdatedFld(conEditRegionFlds.DsTabId);
}
else if (conEditRegionFlds.TabFeatureId4Ddl  ==  _AttributeName[intIndex])
{
mstrTabFeatureId4Ddl = value.ToString();
 AddUpdatedFld(conEditRegionFlds.TabFeatureId4Ddl);
}
else if (conEditRegionFlds.FldIdCond1  ==  _AttributeName[intIndex])
{
mstrFldIdCond1 = value.ToString();
 AddUpdatedFld(conEditRegionFlds.FldIdCond1);
}
else if (conEditRegionFlds.VarIdCond1  ==  _AttributeName[intIndex])
{
mstrVarIdCond1 = value.ToString();
 AddUpdatedFld(conEditRegionFlds.VarIdCond1);
}
else if (conEditRegionFlds.FldIdCond2  ==  _AttributeName[intIndex])
{
mstrFldIdCond2 = value.ToString();
 AddUpdatedFld(conEditRegionFlds.FldIdCond2);
}
else if (conEditRegionFlds.VarIdCond2  ==  _AttributeName[intIndex])
{
mstrVarIdCond2 = value.ToString();
 AddUpdatedFld(conEditRegionFlds.VarIdCond2);
}
else if (conEditRegionFlds.DsCondStr  ==  _AttributeName[intIndex])
{
mstrDsCondStr = value.ToString();
 AddUpdatedFld(conEditRegionFlds.DsCondStr);
}
else if (conEditRegionFlds.DsSqlStr  ==  _AttributeName[intIndex])
{
mstrDsSqlStr = value.ToString();
 AddUpdatedFld(conEditRegionFlds.DsSqlStr);
}
else if (conEditRegionFlds.ItemsString  ==  _AttributeName[intIndex])
{
mstrItemsString = value.ToString();
 AddUpdatedFld(conEditRegionFlds.ItemsString);
}
else if (conEditRegionFlds.ColSpan  ==  _AttributeName[intIndex])
{
mintColSpan = TransNullToInt(value.ToString());
 AddUpdatedFld(conEditRegionFlds.ColSpan);
}
else if (conEditRegionFlds.ColIndex  ==  _AttributeName[intIndex])
{
mintColIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(conEditRegionFlds.ColIndex);
}
else if (conEditRegionFlds.Width  ==  _AttributeName[intIndex])
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(conEditRegionFlds.Width);
}
else if (conEditRegionFlds.IsMultiRow  ==  _AttributeName[intIndex])
{
mbolIsMultiRow = TransNullToBool(value.ToString());
 AddUpdatedFld(conEditRegionFlds.IsMultiRow);
}
else if (conEditRegionFlds.SeqNum  ==  _AttributeName[intIndex])
{
mintSeqNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conEditRegionFlds.SeqNum);
}
else if (conEditRegionFlds.InOutTypeId  ==  _AttributeName[intIndex])
{
mstrInOutTypeId = value.ToString();
 AddUpdatedFld(conEditRegionFlds.InOutTypeId);
}
else if (conEditRegionFlds.ClickEvent  ==  _AttributeName[intIndex])
{
mstrClickEvent = value.ToString();
 AddUpdatedFld(conEditRegionFlds.ClickEvent);
}
else if (conEditRegionFlds.ChangeEvent  ==  _AttributeName[intIndex])
{
mstrChangeEvent = value.ToString();
 AddUpdatedFld(conEditRegionFlds.ChangeEvent);
}
else if (conEditRegionFlds.InUse  ==  _AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conEditRegionFlds.InUse);
}
else if (conEditRegionFlds.ErrMsg  ==  _AttributeName[intIndex])
{
mstrErrMsg = value.ToString();
 AddUpdatedFld(conEditRegionFlds.ErrMsg);
}
else if (conEditRegionFlds.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conEditRegionFlds.PrjId);
}
else if (conEditRegionFlds.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conEditRegionFlds.UpdUser);
}
else if (conEditRegionFlds.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conEditRegionFlds.UpdDate);
}
else if (conEditRegionFlds.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conEditRegionFlds.Memo);
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
 AddUpdatedFld(conEditRegionFlds.mId);
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
 AddUpdatedFld(conEditRegionFlds.RegionId);
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
 AddUpdatedFld(conEditRegionFlds.FldId);
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
 AddUpdatedFld(conEditRegionFlds.LabelCaption);
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
 AddUpdatedFld(conEditRegionFlds.CtlTypeId);
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
 AddUpdatedFld(conEditRegionFlds.CallTabFeatureId);
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
 AddUpdatedFld(conEditRegionFlds.VarId);
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
 AddUpdatedFld(conEditRegionFlds.DefaultValue);
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
 AddUpdatedFld(conEditRegionFlds.DdlItemsOptionId);
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
 AddUpdatedFld(conEditRegionFlds.DsTabId);
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
 AddUpdatedFld(conEditRegionFlds.TabFeatureId4Ddl);
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
 AddUpdatedFld(conEditRegionFlds.FldIdCond1);
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
 AddUpdatedFld(conEditRegionFlds.VarIdCond1);
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
 AddUpdatedFld(conEditRegionFlds.FldIdCond2);
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
 AddUpdatedFld(conEditRegionFlds.VarIdCond2);
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
 AddUpdatedFld(conEditRegionFlds.DsCondStr);
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
 AddUpdatedFld(conEditRegionFlds.DsSqlStr);
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
 AddUpdatedFld(conEditRegionFlds.ItemsString);
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
 AddUpdatedFld(conEditRegionFlds.ColSpan);
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
 AddUpdatedFld(conEditRegionFlds.ColIndex);
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
 AddUpdatedFld(conEditRegionFlds.Width);
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
 AddUpdatedFld(conEditRegionFlds.IsMultiRow);
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
 AddUpdatedFld(conEditRegionFlds.SeqNum);
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
 AddUpdatedFld(conEditRegionFlds.InOutTypeId);
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
 AddUpdatedFld(conEditRegionFlds.ClickEvent);
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
 AddUpdatedFld(conEditRegionFlds.ChangeEvent);
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
 AddUpdatedFld(conEditRegionFlds.InUse);
}
}
/// <summary>
/// 错误信息(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ErrMsg
{
get
{
return mstrErrMsg;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrErrMsg = value;
}
else
{
 mstrErrMsg = value;
}
//记录修改过的字段
 AddUpdatedFld(conEditRegionFlds.ErrMsg);
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
 AddUpdatedFld(conEditRegionFlds.PrjId);
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
 AddUpdatedFld(conEditRegionFlds.UpdUser);
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
 AddUpdatedFld(conEditRegionFlds.UpdDate);
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
 AddUpdatedFld(conEditRegionFlds.Memo);
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
 /// 编辑区域字段(EditRegionFlds)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conEditRegionFlds
{
public const string _CurrTabName = "EditRegionFlds"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "RegionId", "FldId", "LabelCaption", "CtlTypeId", "CallTabFeatureId", "VarId", "DefaultValue", "DdlItemsOptionId", "DsTabId", "TabFeatureId4Ddl", "FldIdCond1", "VarIdCond1", "FldIdCond2", "VarIdCond2", "DsCondStr", "DsSqlStr", "ItemsString", "ColSpan", "ColIndex", "Width", "IsMultiRow", "SeqNum", "InOutTypeId", "ClickEvent", "ChangeEvent", "InUse", "ErrMsg", "PrjId", "UpdUser", "UpdDate", "Memo"};
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
 /// 常量:"FldId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldId = "FldId";    //字段Id

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
 /// 常量:"DefaultValue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DefaultValue = "DefaultValue";    //缺省值

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
 /// 常量:"TabFeatureId4Ddl"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabFeatureId4Ddl = "TabFeatureId4Ddl";    //下拉框表功能Id

 /// <summary>
 /// 常量:"FldIdCond1"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldIdCond1 = "FldIdCond1";    //字段Id_条件1

 /// <summary>
 /// 常量:"VarIdCond1"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VarIdCond1 = "VarIdCond1";    //变量Id_条件1

 /// <summary>
 /// 常量:"FldIdCond2"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldIdCond2 = "FldIdCond2";    //字段Id_条件2

 /// <summary>
 /// 常量:"VarIdCond2"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VarIdCond2 = "VarIdCond2";    //数据源字段_条件1

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
 /// 常量:"ErrMsg"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ErrMsg = "ErrMsg";    //错误信息

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

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