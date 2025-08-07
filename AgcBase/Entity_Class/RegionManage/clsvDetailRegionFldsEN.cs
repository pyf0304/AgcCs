
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvDetailRegionFldsEN
 表名:vDetailRegionFlds(00050546)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:48:06
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
 /// 表vDetailRegionFlds的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vDetailRegionFlds
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
public K_mId_vDetailRegionFlds(long lngmId)
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
 /// <returns>返回:[K_mId_vDetailRegionFlds]类型的对象</returns>
public static implicit operator K_mId_vDetailRegionFlds(long value)
{
return new K_mId_vDetailRegionFlds(value);
}
}
 /// <summary>
 /// v详细区域字段(vDetailRegionFlds)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvDetailRegionFldsEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vDetailRegionFlds"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 30;
public static string[] _AttributeName = new string[] {"mId", "RegionId", "RegionTypeId", "TabId", "TabName", "FldId", "FldName", "OutDataNodeId", "DataNodeName", "IsUseFunc", "DataPropertyName", "LabelCaption", "CtlTypeId", "CtlTypeName", "CtlCnName", "CtlTypeAbbr", "ColSpan", "ColIndex", "Width", "IsMultiRow", "SeqNum", "InOutTypeId", "InOutTypeName", "InUse", "ChangeEvent", "ClickEvent", "UpdUser", "UpdDate", "Memo", "PrjId"};

protected long mlngmId;    //mId
protected string mstrRegionId;    //区域Id
protected string mstrRegionTypeId;    //区域类型Id
protected string mstrTabId;    //表ID
protected string mstrTabName;    //表名
protected string mstrFldId;    //字段Id
protected string mstrFldName;    //字段名
protected long? mlngOutDataNodeId;    //Out数据结点Id
protected string mstrDataNodeName;    //数据结点名
protected bool mbolIsUseFunc;    //使用函数映射
protected string mstrDataPropertyName;    //数据属性名
protected string mstrLabelCaption;    //标签标题
protected string mstrCtlTypeId;    //控件类型号
protected string mstrCtlTypeName;    //控件类型名
protected string mstrCtlCnName;    //控件类型中文名
protected string mstrCtlTypeAbbr;    //控件类型缩写
protected int? mintColSpan;    //跨列数
protected int? mintColIndex;    //列序号
protected int? mintWidth;    //宽
protected bool mbolIsMultiRow;    //是否多行
protected int mintSeqNum;    //字段序号
protected string mstrInOutTypeId;    //INOUT类型ID
protected string mstrInOutTypeName;    //INOUT类型名称
protected bool mbolInUse;    //是否在用
protected string mstrChangeEvent;    //Change事件
protected string mstrClickEvent;    //Click事件
protected string mstrUpdUser;    //修改者
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //说明
protected string mstrPrjId;    //工程Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvDetailRegionFldsEN()
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
public clsvDetailRegionFldsEN(long lngmId)
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
if (strAttributeName  ==  convDetailRegionFlds.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convDetailRegionFlds.RegionId)
{
return mstrRegionId;
}
else if (strAttributeName  ==  convDetailRegionFlds.RegionTypeId)
{
return mstrRegionTypeId;
}
else if (strAttributeName  ==  convDetailRegionFlds.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  convDetailRegionFlds.TabName)
{
return mstrTabName;
}
else if (strAttributeName  ==  convDetailRegionFlds.FldId)
{
return mstrFldId;
}
else if (strAttributeName  ==  convDetailRegionFlds.FldName)
{
return mstrFldName;
}
else if (strAttributeName  ==  convDetailRegionFlds.OutDataNodeId)
{
return mlngOutDataNodeId;
}
else if (strAttributeName  ==  convDetailRegionFlds.DataNodeName)
{
return mstrDataNodeName;
}
else if (strAttributeName  ==  convDetailRegionFlds.IsUseFunc)
{
return mbolIsUseFunc;
}
else if (strAttributeName  ==  convDetailRegionFlds.DataPropertyName)
{
return mstrDataPropertyName;
}
else if (strAttributeName  ==  convDetailRegionFlds.LabelCaption)
{
return mstrLabelCaption;
}
else if (strAttributeName  ==  convDetailRegionFlds.CtlTypeId)
{
return mstrCtlTypeId;
}
else if (strAttributeName  ==  convDetailRegionFlds.CtlTypeName)
{
return mstrCtlTypeName;
}
else if (strAttributeName  ==  convDetailRegionFlds.CtlCnName)
{
return mstrCtlCnName;
}
else if (strAttributeName  ==  convDetailRegionFlds.CtlTypeAbbr)
{
return mstrCtlTypeAbbr;
}
else if (strAttributeName  ==  convDetailRegionFlds.ColSpan)
{
return mintColSpan;
}
else if (strAttributeName  ==  convDetailRegionFlds.ColIndex)
{
return mintColIndex;
}
else if (strAttributeName  ==  convDetailRegionFlds.Width)
{
return mintWidth;
}
else if (strAttributeName  ==  convDetailRegionFlds.IsMultiRow)
{
return mbolIsMultiRow;
}
else if (strAttributeName  ==  convDetailRegionFlds.SeqNum)
{
return mintSeqNum;
}
else if (strAttributeName  ==  convDetailRegionFlds.InOutTypeId)
{
return mstrInOutTypeId;
}
else if (strAttributeName  ==  convDetailRegionFlds.InOutTypeName)
{
return mstrInOutTypeName;
}
else if (strAttributeName  ==  convDetailRegionFlds.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  convDetailRegionFlds.ChangeEvent)
{
return mstrChangeEvent;
}
else if (strAttributeName  ==  convDetailRegionFlds.ClickEvent)
{
return mstrClickEvent;
}
else if (strAttributeName  ==  convDetailRegionFlds.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convDetailRegionFlds.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convDetailRegionFlds.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convDetailRegionFlds.PrjId)
{
return mstrPrjId;
}
return null;
}
set
{
if (strAttributeName  ==  convDetailRegionFlds.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convDetailRegionFlds.mId);
}
else if (strAttributeName  ==  convDetailRegionFlds.RegionId)
{
mstrRegionId = value.ToString();
 AddUpdatedFld(convDetailRegionFlds.RegionId);
}
else if (strAttributeName  ==  convDetailRegionFlds.RegionTypeId)
{
mstrRegionTypeId = value.ToString();
 AddUpdatedFld(convDetailRegionFlds.RegionTypeId);
}
else if (strAttributeName  ==  convDetailRegionFlds.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(convDetailRegionFlds.TabId);
}
else if (strAttributeName  ==  convDetailRegionFlds.TabName)
{
mstrTabName = value.ToString();
 AddUpdatedFld(convDetailRegionFlds.TabName);
}
else if (strAttributeName  ==  convDetailRegionFlds.FldId)
{
mstrFldId = value.ToString();
 AddUpdatedFld(convDetailRegionFlds.FldId);
}
else if (strAttributeName  ==  convDetailRegionFlds.FldName)
{
mstrFldName = value.ToString();
 AddUpdatedFld(convDetailRegionFlds.FldName);
}
else if (strAttributeName  ==  convDetailRegionFlds.OutDataNodeId)
{
mlngOutDataNodeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convDetailRegionFlds.OutDataNodeId);
}
else if (strAttributeName  ==  convDetailRegionFlds.DataNodeName)
{
mstrDataNodeName = value.ToString();
 AddUpdatedFld(convDetailRegionFlds.DataNodeName);
}
else if (strAttributeName  ==  convDetailRegionFlds.IsUseFunc)
{
mbolIsUseFunc = TransNullToBool(value.ToString());
 AddUpdatedFld(convDetailRegionFlds.IsUseFunc);
}
else if (strAttributeName  ==  convDetailRegionFlds.DataPropertyName)
{
mstrDataPropertyName = value.ToString();
 AddUpdatedFld(convDetailRegionFlds.DataPropertyName);
}
else if (strAttributeName  ==  convDetailRegionFlds.LabelCaption)
{
mstrLabelCaption = value.ToString();
 AddUpdatedFld(convDetailRegionFlds.LabelCaption);
}
else if (strAttributeName  ==  convDetailRegionFlds.CtlTypeId)
{
mstrCtlTypeId = value.ToString();
 AddUpdatedFld(convDetailRegionFlds.CtlTypeId);
}
else if (strAttributeName  ==  convDetailRegionFlds.CtlTypeName)
{
mstrCtlTypeName = value.ToString();
 AddUpdatedFld(convDetailRegionFlds.CtlTypeName);
}
else if (strAttributeName  ==  convDetailRegionFlds.CtlCnName)
{
mstrCtlCnName = value.ToString();
 AddUpdatedFld(convDetailRegionFlds.CtlCnName);
}
else if (strAttributeName  ==  convDetailRegionFlds.CtlTypeAbbr)
{
mstrCtlTypeAbbr = value.ToString();
 AddUpdatedFld(convDetailRegionFlds.CtlTypeAbbr);
}
else if (strAttributeName  ==  convDetailRegionFlds.ColSpan)
{
mintColSpan = TransNullToInt(value.ToString());
 AddUpdatedFld(convDetailRegionFlds.ColSpan);
}
else if (strAttributeName  ==  convDetailRegionFlds.ColIndex)
{
mintColIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convDetailRegionFlds.ColIndex);
}
else if (strAttributeName  ==  convDetailRegionFlds.Width)
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(convDetailRegionFlds.Width);
}
else if (strAttributeName  ==  convDetailRegionFlds.IsMultiRow)
{
mbolIsMultiRow = TransNullToBool(value.ToString());
 AddUpdatedFld(convDetailRegionFlds.IsMultiRow);
}
else if (strAttributeName  ==  convDetailRegionFlds.SeqNum)
{
mintSeqNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convDetailRegionFlds.SeqNum);
}
else if (strAttributeName  ==  convDetailRegionFlds.InOutTypeId)
{
mstrInOutTypeId = value.ToString();
 AddUpdatedFld(convDetailRegionFlds.InOutTypeId);
}
else if (strAttributeName  ==  convDetailRegionFlds.InOutTypeName)
{
mstrInOutTypeName = value.ToString();
 AddUpdatedFld(convDetailRegionFlds.InOutTypeName);
}
else if (strAttributeName  ==  convDetailRegionFlds.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convDetailRegionFlds.InUse);
}
else if (strAttributeName  ==  convDetailRegionFlds.ChangeEvent)
{
mstrChangeEvent = value.ToString();
 AddUpdatedFld(convDetailRegionFlds.ChangeEvent);
}
else if (strAttributeName  ==  convDetailRegionFlds.ClickEvent)
{
mstrClickEvent = value.ToString();
 AddUpdatedFld(convDetailRegionFlds.ClickEvent);
}
else if (strAttributeName  ==  convDetailRegionFlds.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convDetailRegionFlds.UpdUser);
}
else if (strAttributeName  ==  convDetailRegionFlds.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convDetailRegionFlds.UpdDate);
}
else if (strAttributeName  ==  convDetailRegionFlds.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convDetailRegionFlds.Memo);
}
else if (strAttributeName  ==  convDetailRegionFlds.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convDetailRegionFlds.PrjId);
}
}
}
public object this[int intIndex]
{
get
{
if (convDetailRegionFlds.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (convDetailRegionFlds.RegionId  ==  _AttributeName[intIndex])
{
return mstrRegionId;
}
else if (convDetailRegionFlds.RegionTypeId  ==  _AttributeName[intIndex])
{
return mstrRegionTypeId;
}
else if (convDetailRegionFlds.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (convDetailRegionFlds.TabName  ==  _AttributeName[intIndex])
{
return mstrTabName;
}
else if (convDetailRegionFlds.FldId  ==  _AttributeName[intIndex])
{
return mstrFldId;
}
else if (convDetailRegionFlds.FldName  ==  _AttributeName[intIndex])
{
return mstrFldName;
}
else if (convDetailRegionFlds.OutDataNodeId  ==  _AttributeName[intIndex])
{
return mlngOutDataNodeId;
}
else if (convDetailRegionFlds.DataNodeName  ==  _AttributeName[intIndex])
{
return mstrDataNodeName;
}
else if (convDetailRegionFlds.IsUseFunc  ==  _AttributeName[intIndex])
{
return mbolIsUseFunc;
}
else if (convDetailRegionFlds.DataPropertyName  ==  _AttributeName[intIndex])
{
return mstrDataPropertyName;
}
else if (convDetailRegionFlds.LabelCaption  ==  _AttributeName[intIndex])
{
return mstrLabelCaption;
}
else if (convDetailRegionFlds.CtlTypeId  ==  _AttributeName[intIndex])
{
return mstrCtlTypeId;
}
else if (convDetailRegionFlds.CtlTypeName  ==  _AttributeName[intIndex])
{
return mstrCtlTypeName;
}
else if (convDetailRegionFlds.CtlCnName  ==  _AttributeName[intIndex])
{
return mstrCtlCnName;
}
else if (convDetailRegionFlds.CtlTypeAbbr  ==  _AttributeName[intIndex])
{
return mstrCtlTypeAbbr;
}
else if (convDetailRegionFlds.ColSpan  ==  _AttributeName[intIndex])
{
return mintColSpan;
}
else if (convDetailRegionFlds.ColIndex  ==  _AttributeName[intIndex])
{
return mintColIndex;
}
else if (convDetailRegionFlds.Width  ==  _AttributeName[intIndex])
{
return mintWidth;
}
else if (convDetailRegionFlds.IsMultiRow  ==  _AttributeName[intIndex])
{
return mbolIsMultiRow;
}
else if (convDetailRegionFlds.SeqNum  ==  _AttributeName[intIndex])
{
return mintSeqNum;
}
else if (convDetailRegionFlds.InOutTypeId  ==  _AttributeName[intIndex])
{
return mstrInOutTypeId;
}
else if (convDetailRegionFlds.InOutTypeName  ==  _AttributeName[intIndex])
{
return mstrInOutTypeName;
}
else if (convDetailRegionFlds.InUse  ==  _AttributeName[intIndex])
{
return mbolInUse;
}
else if (convDetailRegionFlds.ChangeEvent  ==  _AttributeName[intIndex])
{
return mstrChangeEvent;
}
else if (convDetailRegionFlds.ClickEvent  ==  _AttributeName[intIndex])
{
return mstrClickEvent;
}
else if (convDetailRegionFlds.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convDetailRegionFlds.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convDetailRegionFlds.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (convDetailRegionFlds.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
return null;
}
set
{
if (convDetailRegionFlds.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convDetailRegionFlds.mId);
}
else if (convDetailRegionFlds.RegionId  ==  _AttributeName[intIndex])
{
mstrRegionId = value.ToString();
 AddUpdatedFld(convDetailRegionFlds.RegionId);
}
else if (convDetailRegionFlds.RegionTypeId  ==  _AttributeName[intIndex])
{
mstrRegionTypeId = value.ToString();
 AddUpdatedFld(convDetailRegionFlds.RegionTypeId);
}
else if (convDetailRegionFlds.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(convDetailRegionFlds.TabId);
}
else if (convDetailRegionFlds.TabName  ==  _AttributeName[intIndex])
{
mstrTabName = value.ToString();
 AddUpdatedFld(convDetailRegionFlds.TabName);
}
else if (convDetailRegionFlds.FldId  ==  _AttributeName[intIndex])
{
mstrFldId = value.ToString();
 AddUpdatedFld(convDetailRegionFlds.FldId);
}
else if (convDetailRegionFlds.FldName  ==  _AttributeName[intIndex])
{
mstrFldName = value.ToString();
 AddUpdatedFld(convDetailRegionFlds.FldName);
}
else if (convDetailRegionFlds.OutDataNodeId  ==  _AttributeName[intIndex])
{
mlngOutDataNodeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convDetailRegionFlds.OutDataNodeId);
}
else if (convDetailRegionFlds.DataNodeName  ==  _AttributeName[intIndex])
{
mstrDataNodeName = value.ToString();
 AddUpdatedFld(convDetailRegionFlds.DataNodeName);
}
else if (convDetailRegionFlds.IsUseFunc  ==  _AttributeName[intIndex])
{
mbolIsUseFunc = TransNullToBool(value.ToString());
 AddUpdatedFld(convDetailRegionFlds.IsUseFunc);
}
else if (convDetailRegionFlds.DataPropertyName  ==  _AttributeName[intIndex])
{
mstrDataPropertyName = value.ToString();
 AddUpdatedFld(convDetailRegionFlds.DataPropertyName);
}
else if (convDetailRegionFlds.LabelCaption  ==  _AttributeName[intIndex])
{
mstrLabelCaption = value.ToString();
 AddUpdatedFld(convDetailRegionFlds.LabelCaption);
}
else if (convDetailRegionFlds.CtlTypeId  ==  _AttributeName[intIndex])
{
mstrCtlTypeId = value.ToString();
 AddUpdatedFld(convDetailRegionFlds.CtlTypeId);
}
else if (convDetailRegionFlds.CtlTypeName  ==  _AttributeName[intIndex])
{
mstrCtlTypeName = value.ToString();
 AddUpdatedFld(convDetailRegionFlds.CtlTypeName);
}
else if (convDetailRegionFlds.CtlCnName  ==  _AttributeName[intIndex])
{
mstrCtlCnName = value.ToString();
 AddUpdatedFld(convDetailRegionFlds.CtlCnName);
}
else if (convDetailRegionFlds.CtlTypeAbbr  ==  _AttributeName[intIndex])
{
mstrCtlTypeAbbr = value.ToString();
 AddUpdatedFld(convDetailRegionFlds.CtlTypeAbbr);
}
else if (convDetailRegionFlds.ColSpan  ==  _AttributeName[intIndex])
{
mintColSpan = TransNullToInt(value.ToString());
 AddUpdatedFld(convDetailRegionFlds.ColSpan);
}
else if (convDetailRegionFlds.ColIndex  ==  _AttributeName[intIndex])
{
mintColIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convDetailRegionFlds.ColIndex);
}
else if (convDetailRegionFlds.Width  ==  _AttributeName[intIndex])
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(convDetailRegionFlds.Width);
}
else if (convDetailRegionFlds.IsMultiRow  ==  _AttributeName[intIndex])
{
mbolIsMultiRow = TransNullToBool(value.ToString());
 AddUpdatedFld(convDetailRegionFlds.IsMultiRow);
}
else if (convDetailRegionFlds.SeqNum  ==  _AttributeName[intIndex])
{
mintSeqNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convDetailRegionFlds.SeqNum);
}
else if (convDetailRegionFlds.InOutTypeId  ==  _AttributeName[intIndex])
{
mstrInOutTypeId = value.ToString();
 AddUpdatedFld(convDetailRegionFlds.InOutTypeId);
}
else if (convDetailRegionFlds.InOutTypeName  ==  _AttributeName[intIndex])
{
mstrInOutTypeName = value.ToString();
 AddUpdatedFld(convDetailRegionFlds.InOutTypeName);
}
else if (convDetailRegionFlds.InUse  ==  _AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convDetailRegionFlds.InUse);
}
else if (convDetailRegionFlds.ChangeEvent  ==  _AttributeName[intIndex])
{
mstrChangeEvent = value.ToString();
 AddUpdatedFld(convDetailRegionFlds.ChangeEvent);
}
else if (convDetailRegionFlds.ClickEvent  ==  _AttributeName[intIndex])
{
mstrClickEvent = value.ToString();
 AddUpdatedFld(convDetailRegionFlds.ClickEvent);
}
else if (convDetailRegionFlds.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convDetailRegionFlds.UpdUser);
}
else if (convDetailRegionFlds.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convDetailRegionFlds.UpdDate);
}
else if (convDetailRegionFlds.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convDetailRegionFlds.Memo);
}
else if (convDetailRegionFlds.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convDetailRegionFlds.PrjId);
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
 AddUpdatedFld(convDetailRegionFlds.mId);
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
 AddUpdatedFld(convDetailRegionFlds.RegionId);
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
 AddUpdatedFld(convDetailRegionFlds.RegionTypeId);
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
 AddUpdatedFld(convDetailRegionFlds.TabId);
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
 AddUpdatedFld(convDetailRegionFlds.TabName);
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
 AddUpdatedFld(convDetailRegionFlds.FldId);
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
 AddUpdatedFld(convDetailRegionFlds.FldName);
}
}
/// <summary>
/// Out数据结点Id(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long? OutDataNodeId
{
get
{
return mlngOutDataNodeId;
}
set
{
 mlngOutDataNodeId = value;
//记录修改过的字段
 AddUpdatedFld(convDetailRegionFlds.OutDataNodeId);
}
}
/// <summary>
/// 数据结点名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataNodeName
{
get
{
return mstrDataNodeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataNodeName = value;
}
else
{
 mstrDataNodeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convDetailRegionFlds.DataNodeName);
}
}
/// <summary>
/// 使用函数映射(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsUseFunc
{
get
{
return mbolIsUseFunc;
}
set
{
 mbolIsUseFunc = value;
//记录修改过的字段
 AddUpdatedFld(convDetailRegionFlds.IsUseFunc);
}
}
/// <summary>
/// 数据属性名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataPropertyName
{
get
{
return mstrDataPropertyName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataPropertyName = value;
}
else
{
 mstrDataPropertyName = value;
}
//记录修改过的字段
 AddUpdatedFld(convDetailRegionFlds.DataPropertyName);
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
 AddUpdatedFld(convDetailRegionFlds.LabelCaption);
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
 AddUpdatedFld(convDetailRegionFlds.CtlTypeId);
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
 AddUpdatedFld(convDetailRegionFlds.CtlTypeName);
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
 AddUpdatedFld(convDetailRegionFlds.CtlCnName);
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
 AddUpdatedFld(convDetailRegionFlds.CtlTypeAbbr);
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
 AddUpdatedFld(convDetailRegionFlds.ColSpan);
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
 AddUpdatedFld(convDetailRegionFlds.ColIndex);
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
 AddUpdatedFld(convDetailRegionFlds.Width);
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
 AddUpdatedFld(convDetailRegionFlds.IsMultiRow);
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
 AddUpdatedFld(convDetailRegionFlds.SeqNum);
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
 AddUpdatedFld(convDetailRegionFlds.InOutTypeId);
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
 AddUpdatedFld(convDetailRegionFlds.InOutTypeName);
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
 AddUpdatedFld(convDetailRegionFlds.InUse);
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
 AddUpdatedFld(convDetailRegionFlds.ChangeEvent);
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
 AddUpdatedFld(convDetailRegionFlds.ClickEvent);
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
 AddUpdatedFld(convDetailRegionFlds.UpdUser);
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
 AddUpdatedFld(convDetailRegionFlds.UpdDate);
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
 AddUpdatedFld(convDetailRegionFlds.Memo);
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
 AddUpdatedFld(convDetailRegionFlds.PrjId);
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
 /// v详细区域字段(vDetailRegionFlds)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convDetailRegionFlds
{
public const string _CurrTabName = "vDetailRegionFlds"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "RegionId", "RegionTypeId", "TabId", "TabName", "FldId", "FldName", "OutDataNodeId", "DataNodeName", "IsUseFunc", "DataPropertyName", "LabelCaption", "CtlTypeId", "CtlTypeName", "CtlCnName", "CtlTypeAbbr", "ColSpan", "ColIndex", "Width", "IsMultiRow", "SeqNum", "InOutTypeId", "InOutTypeName", "InUse", "ChangeEvent", "ClickEvent", "UpdUser", "UpdDate", "Memo", "PrjId"};
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
 /// 常量:"OutDataNodeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OutDataNodeId = "OutDataNodeId";    //Out数据结点Id

 /// <summary>
 /// 常量:"DataNodeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataNodeName = "DataNodeName";    //数据结点名

 /// <summary>
 /// 常量:"IsUseFunc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsUseFunc = "IsUseFunc";    //使用函数映射

 /// <summary>
 /// 常量:"DataPropertyName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataPropertyName = "DataPropertyName";    //数据属性名

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
 /// 常量:"InUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InUse = "InUse";    //是否在用

 /// <summary>
 /// 常量:"ChangeEvent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ChangeEvent = "ChangeEvent";    //Change事件

 /// <summary>
 /// 常量:"ClickEvent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClickEvent = "ClickEvent";    //Click事件

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