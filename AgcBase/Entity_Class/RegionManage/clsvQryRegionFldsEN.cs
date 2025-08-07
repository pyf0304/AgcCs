
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQryRegionFldsEN
 表名:vQryRegionFlds(00050151)
 * 版本:2024.01.24.1(服务器:WIN-SRV103-116)
 日期:2024/01/26 14:38:57
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
 /// 表vQryRegionFlds的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vQryRegionFlds
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
public K_mId_vQryRegionFlds(long lngmId)
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
 /// <returns>返回:[K_mId_vQryRegionFlds]类型的对象</returns>
public static implicit operator K_mId_vQryRegionFlds(long value)
{
return new K_mId_vQryRegionFlds(value);
}
}
 /// <summary>
 /// v查询区域字段(vQryRegionFlds)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvQryRegionFldsEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vQryRegionFlds"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 31;
public static string[] AttributeName = new string[] {"mId", "RegionId", "RegionName", "TabId", "TabName", "FldId", "FldName", "LabelCaption", "CtlTypeId", "CtlTypeName", "CtlCnName", "CtlTypeAbbr", "VarId", "DsTabId", "QueryOptionId", "QueryOptionName", "DdlItemsOptionId", "DdlItemsOptionName", "DsSqlStr", "ItemsString", "DsCondStr", "ColSpan", "Width", "SeqNum", "ChangeEvent", "ClickEvent", "InUse", "UpdUser", "UpdDate", "Memo", "PrjId"};

protected long mlngmId;    //mId
protected string mstrRegionId;    //区域Id
protected string mstrRegionName;    //区域名称
protected string mstrTabId;    //表ID
protected string mstrTabName;    //表名
protected string mstrFldId;    //字段Id
protected string mstrFldName;    //字段名
protected string mstrLabelCaption;    //标签标题
protected string mstrCtlTypeId;    //控件类型号
protected string mstrCtlTypeName;    //控件类型名
protected string mstrCtlCnName;    //控件类型中文名
protected string mstrCtlTypeAbbr;    //控件类型缩写
protected string mstrVarId;    //变量Id
protected string mstrDsTabId;    //数据源表ID
protected string mstrQueryOptionId;    //查询方式Id
protected string mstrQueryOptionName;    //查询方式名称
protected string mstrDdlItemsOptionId;    //下拉框列表选项ID
protected string mstrDdlItemsOptionName;    //下拉选项名
protected string mstrDsSqlStr;    //数据源SQL串
protected string mstrItemsString;    //列表项串
protected string mstrDsCondStr;    //数据源条件串
protected int? mintColSpan;    //跨列数
protected int? mintWidth;    //宽
protected int? mintSeqNum;    //字段序号
protected string mstrChangeEvent;    //Change事件
protected string mstrClickEvent;    //Click事件
protected bool mbolInUse;    //是否在用
protected string mstrUpdUser;    //修改者
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //说明
protected string mstrPrjId;    //工程ID

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvQryRegionFldsEN()
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
public clsvQryRegionFldsEN(long lngmId)
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
if (strAttributeName  ==  convQryRegionFlds.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convQryRegionFlds.RegionId)
{
return mstrRegionId;
}
else if (strAttributeName  ==  convQryRegionFlds.RegionName)
{
return mstrRegionName;
}
else if (strAttributeName  ==  convQryRegionFlds.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  convQryRegionFlds.TabName)
{
return mstrTabName;
}
else if (strAttributeName  ==  convQryRegionFlds.FldId)
{
return mstrFldId;
}
else if (strAttributeName  ==  convQryRegionFlds.FldName)
{
return mstrFldName;
}
else if (strAttributeName  ==  convQryRegionFlds.LabelCaption)
{
return mstrLabelCaption;
}
else if (strAttributeName  ==  convQryRegionFlds.CtlTypeId)
{
return mstrCtlTypeId;
}
else if (strAttributeName  ==  convQryRegionFlds.CtlTypeName)
{
return mstrCtlTypeName;
}
else if (strAttributeName  ==  convQryRegionFlds.CtlCnName)
{
return mstrCtlCnName;
}
else if (strAttributeName  ==  convQryRegionFlds.CtlTypeAbbr)
{
return mstrCtlTypeAbbr;
}
else if (strAttributeName  ==  convQryRegionFlds.VarId)
{
return mstrVarId;
}
else if (strAttributeName  ==  convQryRegionFlds.DsTabId)
{
return mstrDsTabId;
}
else if (strAttributeName  ==  convQryRegionFlds.QueryOptionId)
{
return mstrQueryOptionId;
}
else if (strAttributeName  ==  convQryRegionFlds.QueryOptionName)
{
return mstrQueryOptionName;
}
else if (strAttributeName  ==  convQryRegionFlds.DdlItemsOptionId)
{
return mstrDdlItemsOptionId;
}
else if (strAttributeName  ==  convQryRegionFlds.DdlItemsOptionName)
{
return mstrDdlItemsOptionName;
}
else if (strAttributeName  ==  convQryRegionFlds.DsSqlStr)
{
return mstrDsSqlStr;
}
else if (strAttributeName  ==  convQryRegionFlds.ItemsString)
{
return mstrItemsString;
}
else if (strAttributeName  ==  convQryRegionFlds.DsCondStr)
{
return mstrDsCondStr;
}
else if (strAttributeName  ==  convQryRegionFlds.ColSpan)
{
return mintColSpan;
}
else if (strAttributeName  ==  convQryRegionFlds.Width)
{
return mintWidth;
}
else if (strAttributeName  ==  convQryRegionFlds.SeqNum)
{
return mintSeqNum;
}
else if (strAttributeName  ==  convQryRegionFlds.ChangeEvent)
{
return mstrChangeEvent;
}
else if (strAttributeName  ==  convQryRegionFlds.ClickEvent)
{
return mstrClickEvent;
}
else if (strAttributeName  ==  convQryRegionFlds.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  convQryRegionFlds.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convQryRegionFlds.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convQryRegionFlds.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convQryRegionFlds.PrjId)
{
return mstrPrjId;
}
return null;
}
set
{
if (strAttributeName  ==  convQryRegionFlds.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convQryRegionFlds.mId);
}
else if (strAttributeName  ==  convQryRegionFlds.RegionId)
{
mstrRegionId = value.ToString();
 AddUpdatedFld(convQryRegionFlds.RegionId);
}
else if (strAttributeName  ==  convQryRegionFlds.RegionName)
{
mstrRegionName = value.ToString();
 AddUpdatedFld(convQryRegionFlds.RegionName);
}
else if (strAttributeName  ==  convQryRegionFlds.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(convQryRegionFlds.TabId);
}
else if (strAttributeName  ==  convQryRegionFlds.TabName)
{
mstrTabName = value.ToString();
 AddUpdatedFld(convQryRegionFlds.TabName);
}
else if (strAttributeName  ==  convQryRegionFlds.FldId)
{
mstrFldId = value.ToString();
 AddUpdatedFld(convQryRegionFlds.FldId);
}
else if (strAttributeName  ==  convQryRegionFlds.FldName)
{
mstrFldName = value.ToString();
 AddUpdatedFld(convQryRegionFlds.FldName);
}
else if (strAttributeName  ==  convQryRegionFlds.LabelCaption)
{
mstrLabelCaption = value.ToString();
 AddUpdatedFld(convQryRegionFlds.LabelCaption);
}
else if (strAttributeName  ==  convQryRegionFlds.CtlTypeId)
{
mstrCtlTypeId = value.ToString();
 AddUpdatedFld(convQryRegionFlds.CtlTypeId);
}
else if (strAttributeName  ==  convQryRegionFlds.CtlTypeName)
{
mstrCtlTypeName = value.ToString();
 AddUpdatedFld(convQryRegionFlds.CtlTypeName);
}
else if (strAttributeName  ==  convQryRegionFlds.CtlCnName)
{
mstrCtlCnName = value.ToString();
 AddUpdatedFld(convQryRegionFlds.CtlCnName);
}
else if (strAttributeName  ==  convQryRegionFlds.CtlTypeAbbr)
{
mstrCtlTypeAbbr = value.ToString();
 AddUpdatedFld(convQryRegionFlds.CtlTypeAbbr);
}
else if (strAttributeName  ==  convQryRegionFlds.VarId)
{
mstrVarId = value.ToString();
 AddUpdatedFld(convQryRegionFlds.VarId);
}
else if (strAttributeName  ==  convQryRegionFlds.DsTabId)
{
mstrDsTabId = value.ToString();
 AddUpdatedFld(convQryRegionFlds.DsTabId);
}
else if (strAttributeName  ==  convQryRegionFlds.QueryOptionId)
{
mstrQueryOptionId = value.ToString();
 AddUpdatedFld(convQryRegionFlds.QueryOptionId);
}
else if (strAttributeName  ==  convQryRegionFlds.QueryOptionName)
{
mstrQueryOptionName = value.ToString();
 AddUpdatedFld(convQryRegionFlds.QueryOptionName);
}
else if (strAttributeName  ==  convQryRegionFlds.DdlItemsOptionId)
{
mstrDdlItemsOptionId = value.ToString();
 AddUpdatedFld(convQryRegionFlds.DdlItemsOptionId);
}
else if (strAttributeName  ==  convQryRegionFlds.DdlItemsOptionName)
{
mstrDdlItemsOptionName = value.ToString();
 AddUpdatedFld(convQryRegionFlds.DdlItemsOptionName);
}
else if (strAttributeName  ==  convQryRegionFlds.DsSqlStr)
{
mstrDsSqlStr = value.ToString();
 AddUpdatedFld(convQryRegionFlds.DsSqlStr);
}
else if (strAttributeName  ==  convQryRegionFlds.ItemsString)
{
mstrItemsString = value.ToString();
 AddUpdatedFld(convQryRegionFlds.ItemsString);
}
else if (strAttributeName  ==  convQryRegionFlds.DsCondStr)
{
mstrDsCondStr = value.ToString();
 AddUpdatedFld(convQryRegionFlds.DsCondStr);
}
else if (strAttributeName  ==  convQryRegionFlds.ColSpan)
{
mintColSpan = TransNullToInt(value.ToString());
 AddUpdatedFld(convQryRegionFlds.ColSpan);
}
else if (strAttributeName  ==  convQryRegionFlds.Width)
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(convQryRegionFlds.Width);
}
else if (strAttributeName  ==  convQryRegionFlds.SeqNum)
{
mintSeqNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQryRegionFlds.SeqNum);
}
else if (strAttributeName  ==  convQryRegionFlds.ChangeEvent)
{
mstrChangeEvent = value.ToString();
 AddUpdatedFld(convQryRegionFlds.ChangeEvent);
}
else if (strAttributeName  ==  convQryRegionFlds.ClickEvent)
{
mstrClickEvent = value.ToString();
 AddUpdatedFld(convQryRegionFlds.ClickEvent);
}
else if (strAttributeName  ==  convQryRegionFlds.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convQryRegionFlds.InUse);
}
else if (strAttributeName  ==  convQryRegionFlds.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convQryRegionFlds.UpdUser);
}
else if (strAttributeName  ==  convQryRegionFlds.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convQryRegionFlds.UpdDate);
}
else if (strAttributeName  ==  convQryRegionFlds.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQryRegionFlds.Memo);
}
else if (strAttributeName  ==  convQryRegionFlds.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convQryRegionFlds.PrjId);
}
}
}
public object this[int intIndex]
{
get
{
if (convQryRegionFlds.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convQryRegionFlds.RegionId  ==  AttributeName[intIndex])
{
return mstrRegionId;
}
else if (convQryRegionFlds.RegionName  ==  AttributeName[intIndex])
{
return mstrRegionName;
}
else if (convQryRegionFlds.TabId  ==  AttributeName[intIndex])
{
return mstrTabId;
}
else if (convQryRegionFlds.TabName  ==  AttributeName[intIndex])
{
return mstrTabName;
}
else if (convQryRegionFlds.FldId  ==  AttributeName[intIndex])
{
return mstrFldId;
}
else if (convQryRegionFlds.FldName  ==  AttributeName[intIndex])
{
return mstrFldName;
}
else if (convQryRegionFlds.LabelCaption  ==  AttributeName[intIndex])
{
return mstrLabelCaption;
}
else if (convQryRegionFlds.CtlTypeId  ==  AttributeName[intIndex])
{
return mstrCtlTypeId;
}
else if (convQryRegionFlds.CtlTypeName  ==  AttributeName[intIndex])
{
return mstrCtlTypeName;
}
else if (convQryRegionFlds.CtlCnName  ==  AttributeName[intIndex])
{
return mstrCtlCnName;
}
else if (convQryRegionFlds.CtlTypeAbbr  ==  AttributeName[intIndex])
{
return mstrCtlTypeAbbr;
}
else if (convQryRegionFlds.VarId  ==  AttributeName[intIndex])
{
return mstrVarId;
}
else if (convQryRegionFlds.DsTabId  ==  AttributeName[intIndex])
{
return mstrDsTabId;
}
else if (convQryRegionFlds.QueryOptionId  ==  AttributeName[intIndex])
{
return mstrQueryOptionId;
}
else if (convQryRegionFlds.QueryOptionName  ==  AttributeName[intIndex])
{
return mstrQueryOptionName;
}
else if (convQryRegionFlds.DdlItemsOptionId  ==  AttributeName[intIndex])
{
return mstrDdlItemsOptionId;
}
else if (convQryRegionFlds.DdlItemsOptionName  ==  AttributeName[intIndex])
{
return mstrDdlItemsOptionName;
}
else if (convQryRegionFlds.DsSqlStr  ==  AttributeName[intIndex])
{
return mstrDsSqlStr;
}
else if (convQryRegionFlds.ItemsString  ==  AttributeName[intIndex])
{
return mstrItemsString;
}
else if (convQryRegionFlds.DsCondStr  ==  AttributeName[intIndex])
{
return mstrDsCondStr;
}
else if (convQryRegionFlds.ColSpan  ==  AttributeName[intIndex])
{
return mintColSpan;
}
else if (convQryRegionFlds.Width  ==  AttributeName[intIndex])
{
return mintWidth;
}
else if (convQryRegionFlds.SeqNum  ==  AttributeName[intIndex])
{
return mintSeqNum;
}
else if (convQryRegionFlds.ChangeEvent  ==  AttributeName[intIndex])
{
return mstrChangeEvent;
}
else if (convQryRegionFlds.ClickEvent  ==  AttributeName[intIndex])
{
return mstrClickEvent;
}
else if (convQryRegionFlds.InUse  ==  AttributeName[intIndex])
{
return mbolInUse;
}
else if (convQryRegionFlds.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convQryRegionFlds.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convQryRegionFlds.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convQryRegionFlds.PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
return null;
}
set
{
if (convQryRegionFlds.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convQryRegionFlds.mId);
}
else if (convQryRegionFlds.RegionId  ==  AttributeName[intIndex])
{
mstrRegionId = value.ToString();
 AddUpdatedFld(convQryRegionFlds.RegionId);
}
else if (convQryRegionFlds.RegionName  ==  AttributeName[intIndex])
{
mstrRegionName = value.ToString();
 AddUpdatedFld(convQryRegionFlds.RegionName);
}
else if (convQryRegionFlds.TabId  ==  AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(convQryRegionFlds.TabId);
}
else if (convQryRegionFlds.TabName  ==  AttributeName[intIndex])
{
mstrTabName = value.ToString();
 AddUpdatedFld(convQryRegionFlds.TabName);
}
else if (convQryRegionFlds.FldId  ==  AttributeName[intIndex])
{
mstrFldId = value.ToString();
 AddUpdatedFld(convQryRegionFlds.FldId);
}
else if (convQryRegionFlds.FldName  ==  AttributeName[intIndex])
{
mstrFldName = value.ToString();
 AddUpdatedFld(convQryRegionFlds.FldName);
}
else if (convQryRegionFlds.LabelCaption  ==  AttributeName[intIndex])
{
mstrLabelCaption = value.ToString();
 AddUpdatedFld(convQryRegionFlds.LabelCaption);
}
else if (convQryRegionFlds.CtlTypeId  ==  AttributeName[intIndex])
{
mstrCtlTypeId = value.ToString();
 AddUpdatedFld(convQryRegionFlds.CtlTypeId);
}
else if (convQryRegionFlds.CtlTypeName  ==  AttributeName[intIndex])
{
mstrCtlTypeName = value.ToString();
 AddUpdatedFld(convQryRegionFlds.CtlTypeName);
}
else if (convQryRegionFlds.CtlCnName  ==  AttributeName[intIndex])
{
mstrCtlCnName = value.ToString();
 AddUpdatedFld(convQryRegionFlds.CtlCnName);
}
else if (convQryRegionFlds.CtlTypeAbbr  ==  AttributeName[intIndex])
{
mstrCtlTypeAbbr = value.ToString();
 AddUpdatedFld(convQryRegionFlds.CtlTypeAbbr);
}
else if (convQryRegionFlds.VarId  ==  AttributeName[intIndex])
{
mstrVarId = value.ToString();
 AddUpdatedFld(convQryRegionFlds.VarId);
}
else if (convQryRegionFlds.DsTabId  ==  AttributeName[intIndex])
{
mstrDsTabId = value.ToString();
 AddUpdatedFld(convQryRegionFlds.DsTabId);
}
else if (convQryRegionFlds.QueryOptionId  ==  AttributeName[intIndex])
{
mstrQueryOptionId = value.ToString();
 AddUpdatedFld(convQryRegionFlds.QueryOptionId);
}
else if (convQryRegionFlds.QueryOptionName  ==  AttributeName[intIndex])
{
mstrQueryOptionName = value.ToString();
 AddUpdatedFld(convQryRegionFlds.QueryOptionName);
}
else if (convQryRegionFlds.DdlItemsOptionId  ==  AttributeName[intIndex])
{
mstrDdlItemsOptionId = value.ToString();
 AddUpdatedFld(convQryRegionFlds.DdlItemsOptionId);
}
else if (convQryRegionFlds.DdlItemsOptionName  ==  AttributeName[intIndex])
{
mstrDdlItemsOptionName = value.ToString();
 AddUpdatedFld(convQryRegionFlds.DdlItemsOptionName);
}
else if (convQryRegionFlds.DsSqlStr  ==  AttributeName[intIndex])
{
mstrDsSqlStr = value.ToString();
 AddUpdatedFld(convQryRegionFlds.DsSqlStr);
}
else if (convQryRegionFlds.ItemsString  ==  AttributeName[intIndex])
{
mstrItemsString = value.ToString();
 AddUpdatedFld(convQryRegionFlds.ItemsString);
}
else if (convQryRegionFlds.DsCondStr  ==  AttributeName[intIndex])
{
mstrDsCondStr = value.ToString();
 AddUpdatedFld(convQryRegionFlds.DsCondStr);
}
else if (convQryRegionFlds.ColSpan  ==  AttributeName[intIndex])
{
mintColSpan = TransNullToInt(value.ToString());
 AddUpdatedFld(convQryRegionFlds.ColSpan);
}
else if (convQryRegionFlds.Width  ==  AttributeName[intIndex])
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(convQryRegionFlds.Width);
}
else if (convQryRegionFlds.SeqNum  ==  AttributeName[intIndex])
{
mintSeqNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQryRegionFlds.SeqNum);
}
else if (convQryRegionFlds.ChangeEvent  ==  AttributeName[intIndex])
{
mstrChangeEvent = value.ToString();
 AddUpdatedFld(convQryRegionFlds.ChangeEvent);
}
else if (convQryRegionFlds.ClickEvent  ==  AttributeName[intIndex])
{
mstrClickEvent = value.ToString();
 AddUpdatedFld(convQryRegionFlds.ClickEvent);
}
else if (convQryRegionFlds.InUse  ==  AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convQryRegionFlds.InUse);
}
else if (convQryRegionFlds.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convQryRegionFlds.UpdUser);
}
else if (convQryRegionFlds.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convQryRegionFlds.UpdDate);
}
else if (convQryRegionFlds.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQryRegionFlds.Memo);
}
else if (convQryRegionFlds.PrjId  ==  AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convQryRegionFlds.PrjId);
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
 AddUpdatedFld(convQryRegionFlds.mId);
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
 AddUpdatedFld(convQryRegionFlds.RegionId);
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
 AddUpdatedFld(convQryRegionFlds.RegionName);
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
 AddUpdatedFld(convQryRegionFlds.TabId);
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
 AddUpdatedFld(convQryRegionFlds.TabName);
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
 AddUpdatedFld(convQryRegionFlds.FldId);
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
 AddUpdatedFld(convQryRegionFlds.FldName);
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
 AddUpdatedFld(convQryRegionFlds.LabelCaption);
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
 AddUpdatedFld(convQryRegionFlds.CtlTypeId);
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
 AddUpdatedFld(convQryRegionFlds.CtlTypeName);
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
 AddUpdatedFld(convQryRegionFlds.CtlCnName);
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
 AddUpdatedFld(convQryRegionFlds.CtlTypeAbbr);
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
 AddUpdatedFld(convQryRegionFlds.VarId);
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
 AddUpdatedFld(convQryRegionFlds.DsTabId);
}
}
/// <summary>
/// 查询方式Id(说明:;字段类型:varchar;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QueryOptionId
{
get
{
return mstrQueryOptionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQueryOptionId = value;
}
else
{
 mstrQueryOptionId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQryRegionFlds.QueryOptionId);
}
}
/// <summary>
/// 查询方式名称(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QueryOptionName
{
get
{
return mstrQueryOptionName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQueryOptionName = value;
}
else
{
 mstrQueryOptionName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQryRegionFlds.QueryOptionName);
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
 AddUpdatedFld(convQryRegionFlds.DdlItemsOptionId);
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
 AddUpdatedFld(convQryRegionFlds.DdlItemsOptionName);
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
 AddUpdatedFld(convQryRegionFlds.DsSqlStr);
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
 AddUpdatedFld(convQryRegionFlds.ItemsString);
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
 AddUpdatedFld(convQryRegionFlds.DsCondStr);
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
 AddUpdatedFld(convQryRegionFlds.ColSpan);
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
 AddUpdatedFld(convQryRegionFlds.Width);
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
 AddUpdatedFld(convQryRegionFlds.SeqNum);
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
 AddUpdatedFld(convQryRegionFlds.ChangeEvent);
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
 AddUpdatedFld(convQryRegionFlds.ClickEvent);
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
 AddUpdatedFld(convQryRegionFlds.InUse);
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
 AddUpdatedFld(convQryRegionFlds.UpdUser);
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
 AddUpdatedFld(convQryRegionFlds.UpdDate);
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
 AddUpdatedFld(convQryRegionFlds.Memo);
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
 AddUpdatedFld(convQryRegionFlds.PrjId);
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
 /// v查询区域字段(vQryRegionFlds)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convQryRegionFlds
{
public const string _CurrTabName = "vQryRegionFlds"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "RegionId", "RegionName", "TabId", "TabName", "FldId", "FldName", "LabelCaption", "CtlTypeId", "CtlTypeName", "CtlCnName", "CtlTypeAbbr", "VarId", "DsTabId", "QueryOptionId", "QueryOptionName", "DdlItemsOptionId", "DdlItemsOptionName", "DsSqlStr", "ItemsString", "DsCondStr", "ColSpan", "Width", "SeqNum", "ChangeEvent", "ClickEvent", "InUse", "UpdUser", "UpdDate", "Memo", "PrjId"};
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
 /// 常量:"RegionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RegionName = "RegionName";    //区域名称

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
 /// 常量:"VarId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VarId = "VarId";    //变量Id

 /// <summary>
 /// 常量:"DsTabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DsTabId = "DsTabId";    //数据源表ID

 /// <summary>
 /// 常量:"QueryOptionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QueryOptionId = "QueryOptionId";    //查询方式Id

 /// <summary>
 /// 常量:"QueryOptionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QueryOptionName = "QueryOptionName";    //查询方式名称

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
 /// 常量:"DsCondStr"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DsCondStr = "DsCondStr";    //数据源条件串

 /// <summary>
 /// 常量:"ColSpan"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ColSpan = "ColSpan";    //跨列数

 /// <summary>
 /// 常量:"Width"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Width = "Width";    //宽

 /// <summary>
 /// 常量:"SeqNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SeqNum = "SeqNum";    //字段序号

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
 public const string PrjId = "PrjId";    //工程ID
}

}