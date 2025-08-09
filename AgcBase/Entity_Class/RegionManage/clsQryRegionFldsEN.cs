
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQryRegionFldsEN
 表名:QryRegionFlds(00050115)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 19:59:57
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
 /// 表QryRegionFlds的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_QryRegionFlds
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
public K_mId_QryRegionFlds(long lngmId)
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
 /// <returns>返回:[K_mId_QryRegionFlds]类型的对象</returns>
public static implicit operator K_mId_QryRegionFlds(long value)
{
return new K_mId_QryRegionFlds(value);
}
}
 /// <summary>
 /// 查询区域字段(QryRegionFlds)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQryRegionFldsEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "QryRegionFlds"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 29;
public static string[] _AttributeName = new string[] {"mId", "RegionId", "FldId", "OutFldId", "LabelCaption", "CtlTypeId", "VarId", "DsTabId", "TabFeatureId4Ddl", "FldIdCond1", "VarIdCond1", "FldIdCond2", "VarIdCond2", "QueryOptionId", "DdlItemsOptionId", "DsSqlStr", "ItemsString", "DsCondStr", "ColSpan", "Width", "SeqNum", "ChangeEvent", "ClickEvent", "InUse", "ErrMsg", "PrjId", "UpdUser", "UpdDate", "Memo"};

protected long mlngmId;    //mId
protected string mstrRegionId;    //区域Id
protected string mstrFldId;    //字段Id
protected string mstrOutFldId;    //OutFldId
protected string mstrLabelCaption;    //标签标题
protected string mstrCtlTypeId;    //控件类型号
protected string mstrVarId;    //变量Id
protected string mstrDsTabId;    //数据源表ID
protected string mstrTabFeatureId4Ddl;    //下拉框表功能Id
protected string mstrFldIdCond1;    //字段Id_条件1
protected string mstrVarIdCond1;    //变量Id_条件1
protected string mstrFldIdCond2;    //字段Id_条件2
protected string mstrVarIdCond2;    //数据源字段_条件1
protected string mstrQueryOptionId;    //查询方式Id
protected string mstrDdlItemsOptionId;    //下拉框列表选项ID
protected string mstrDsSqlStr;    //数据源SQL串
protected string mstrItemsString;    //列表项串
protected string mstrDsCondStr;    //数据源条件串
protected int? mintColSpan;    //跨列数
protected int? mintWidth;    //宽
protected int? mintSeqNum;    //字段序号
protected string mstrChangeEvent;    //Change事件
protected string mstrClickEvent;    //Click事件
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
 public clsQryRegionFldsEN()
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
public clsQryRegionFldsEN(long lngmId)
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
if (strAttributeName  ==  conQryRegionFlds.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conQryRegionFlds.RegionId)
{
return mstrRegionId;
}
else if (strAttributeName  ==  conQryRegionFlds.FldId)
{
return mstrFldId;
}
else if (strAttributeName  ==  conQryRegionFlds.OutFldId)
{
return mstrOutFldId;
}
else if (strAttributeName  ==  conQryRegionFlds.LabelCaption)
{
return mstrLabelCaption;
}
else if (strAttributeName  ==  conQryRegionFlds.CtlTypeId)
{
return mstrCtlTypeId;
}
else if (strAttributeName  ==  conQryRegionFlds.VarId)
{
return mstrVarId;
}
else if (strAttributeName  ==  conQryRegionFlds.DsTabId)
{
return mstrDsTabId;
}
else if (strAttributeName  ==  conQryRegionFlds.TabFeatureId4Ddl)
{
return mstrTabFeatureId4Ddl;
}
else if (strAttributeName  ==  conQryRegionFlds.FldIdCond1)
{
return mstrFldIdCond1;
}
else if (strAttributeName  ==  conQryRegionFlds.VarIdCond1)
{
return mstrVarIdCond1;
}
else if (strAttributeName  ==  conQryRegionFlds.FldIdCond2)
{
return mstrFldIdCond2;
}
else if (strAttributeName  ==  conQryRegionFlds.VarIdCond2)
{
return mstrVarIdCond2;
}
else if (strAttributeName  ==  conQryRegionFlds.QueryOptionId)
{
return mstrQueryOptionId;
}
else if (strAttributeName  ==  conQryRegionFlds.DdlItemsOptionId)
{
return mstrDdlItemsOptionId;
}
else if (strAttributeName  ==  conQryRegionFlds.DsSqlStr)
{
return mstrDsSqlStr;
}
else if (strAttributeName  ==  conQryRegionFlds.ItemsString)
{
return mstrItemsString;
}
else if (strAttributeName  ==  conQryRegionFlds.DsCondStr)
{
return mstrDsCondStr;
}
else if (strAttributeName  ==  conQryRegionFlds.ColSpan)
{
return mintColSpan;
}
else if (strAttributeName  ==  conQryRegionFlds.Width)
{
return mintWidth;
}
else if (strAttributeName  ==  conQryRegionFlds.SeqNum)
{
return mintSeqNum;
}
else if (strAttributeName  ==  conQryRegionFlds.ChangeEvent)
{
return mstrChangeEvent;
}
else if (strAttributeName  ==  conQryRegionFlds.ClickEvent)
{
return mstrClickEvent;
}
else if (strAttributeName  ==  conQryRegionFlds.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  conQryRegionFlds.ErrMsg)
{
return mstrErrMsg;
}
else if (strAttributeName  ==  conQryRegionFlds.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conQryRegionFlds.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conQryRegionFlds.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conQryRegionFlds.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conQryRegionFlds.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQryRegionFlds.mId);
}
else if (strAttributeName  ==  conQryRegionFlds.RegionId)
{
mstrRegionId = value.ToString();
 AddUpdatedFld(conQryRegionFlds.RegionId);
}
else if (strAttributeName  ==  conQryRegionFlds.FldId)
{
mstrFldId = value.ToString();
 AddUpdatedFld(conQryRegionFlds.FldId);
}
else if (strAttributeName  ==  conQryRegionFlds.OutFldId)
{
mstrOutFldId = value.ToString();
 AddUpdatedFld(conQryRegionFlds.OutFldId);
}
else if (strAttributeName  ==  conQryRegionFlds.LabelCaption)
{
mstrLabelCaption = value.ToString();
 AddUpdatedFld(conQryRegionFlds.LabelCaption);
}
else if (strAttributeName  ==  conQryRegionFlds.CtlTypeId)
{
mstrCtlTypeId = value.ToString();
 AddUpdatedFld(conQryRegionFlds.CtlTypeId);
}
else if (strAttributeName  ==  conQryRegionFlds.VarId)
{
mstrVarId = value.ToString();
 AddUpdatedFld(conQryRegionFlds.VarId);
}
else if (strAttributeName  ==  conQryRegionFlds.DsTabId)
{
mstrDsTabId = value.ToString();
 AddUpdatedFld(conQryRegionFlds.DsTabId);
}
else if (strAttributeName  ==  conQryRegionFlds.TabFeatureId4Ddl)
{
mstrTabFeatureId4Ddl = value.ToString();
 AddUpdatedFld(conQryRegionFlds.TabFeatureId4Ddl);
}
else if (strAttributeName  ==  conQryRegionFlds.FldIdCond1)
{
mstrFldIdCond1 = value.ToString();
 AddUpdatedFld(conQryRegionFlds.FldIdCond1);
}
else if (strAttributeName  ==  conQryRegionFlds.VarIdCond1)
{
mstrVarIdCond1 = value.ToString();
 AddUpdatedFld(conQryRegionFlds.VarIdCond1);
}
else if (strAttributeName  ==  conQryRegionFlds.FldIdCond2)
{
mstrFldIdCond2 = value.ToString();
 AddUpdatedFld(conQryRegionFlds.FldIdCond2);
}
else if (strAttributeName  ==  conQryRegionFlds.VarIdCond2)
{
mstrVarIdCond2 = value.ToString();
 AddUpdatedFld(conQryRegionFlds.VarIdCond2);
}
else if (strAttributeName  ==  conQryRegionFlds.QueryOptionId)
{
mstrQueryOptionId = value.ToString();
 AddUpdatedFld(conQryRegionFlds.QueryOptionId);
}
else if (strAttributeName  ==  conQryRegionFlds.DdlItemsOptionId)
{
mstrDdlItemsOptionId = value.ToString();
 AddUpdatedFld(conQryRegionFlds.DdlItemsOptionId);
}
else if (strAttributeName  ==  conQryRegionFlds.DsSqlStr)
{
mstrDsSqlStr = value.ToString();
 AddUpdatedFld(conQryRegionFlds.DsSqlStr);
}
else if (strAttributeName  ==  conQryRegionFlds.ItemsString)
{
mstrItemsString = value.ToString();
 AddUpdatedFld(conQryRegionFlds.ItemsString);
}
else if (strAttributeName  ==  conQryRegionFlds.DsCondStr)
{
mstrDsCondStr = value.ToString();
 AddUpdatedFld(conQryRegionFlds.DsCondStr);
}
else if (strAttributeName  ==  conQryRegionFlds.ColSpan)
{
mintColSpan = TransNullToInt(value.ToString());
 AddUpdatedFld(conQryRegionFlds.ColSpan);
}
else if (strAttributeName  ==  conQryRegionFlds.Width)
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(conQryRegionFlds.Width);
}
else if (strAttributeName  ==  conQryRegionFlds.SeqNum)
{
mintSeqNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conQryRegionFlds.SeqNum);
}
else if (strAttributeName  ==  conQryRegionFlds.ChangeEvent)
{
mstrChangeEvent = value.ToString();
 AddUpdatedFld(conQryRegionFlds.ChangeEvent);
}
else if (strAttributeName  ==  conQryRegionFlds.ClickEvent)
{
mstrClickEvent = value.ToString();
 AddUpdatedFld(conQryRegionFlds.ClickEvent);
}
else if (strAttributeName  ==  conQryRegionFlds.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conQryRegionFlds.InUse);
}
else if (strAttributeName  ==  conQryRegionFlds.ErrMsg)
{
mstrErrMsg = value.ToString();
 AddUpdatedFld(conQryRegionFlds.ErrMsg);
}
else if (strAttributeName  ==  conQryRegionFlds.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conQryRegionFlds.PrjId);
}
else if (strAttributeName  ==  conQryRegionFlds.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conQryRegionFlds.UpdUser);
}
else if (strAttributeName  ==  conQryRegionFlds.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQryRegionFlds.UpdDate);
}
else if (strAttributeName  ==  conQryRegionFlds.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQryRegionFlds.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conQryRegionFlds.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (conQryRegionFlds.RegionId  ==  _AttributeName[intIndex])
{
return mstrRegionId;
}
else if (conQryRegionFlds.FldId  ==  _AttributeName[intIndex])
{
return mstrFldId;
}
else if (conQryRegionFlds.OutFldId  ==  _AttributeName[intIndex])
{
return mstrOutFldId;
}
else if (conQryRegionFlds.LabelCaption  ==  _AttributeName[intIndex])
{
return mstrLabelCaption;
}
else if (conQryRegionFlds.CtlTypeId  ==  _AttributeName[intIndex])
{
return mstrCtlTypeId;
}
else if (conQryRegionFlds.VarId  ==  _AttributeName[intIndex])
{
return mstrVarId;
}
else if (conQryRegionFlds.DsTabId  ==  _AttributeName[intIndex])
{
return mstrDsTabId;
}
else if (conQryRegionFlds.TabFeatureId4Ddl  ==  _AttributeName[intIndex])
{
return mstrTabFeatureId4Ddl;
}
else if (conQryRegionFlds.FldIdCond1  ==  _AttributeName[intIndex])
{
return mstrFldIdCond1;
}
else if (conQryRegionFlds.VarIdCond1  ==  _AttributeName[intIndex])
{
return mstrVarIdCond1;
}
else if (conQryRegionFlds.FldIdCond2  ==  _AttributeName[intIndex])
{
return mstrFldIdCond2;
}
else if (conQryRegionFlds.VarIdCond2  ==  _AttributeName[intIndex])
{
return mstrVarIdCond2;
}
else if (conQryRegionFlds.QueryOptionId  ==  _AttributeName[intIndex])
{
return mstrQueryOptionId;
}
else if (conQryRegionFlds.DdlItemsOptionId  ==  _AttributeName[intIndex])
{
return mstrDdlItemsOptionId;
}
else if (conQryRegionFlds.DsSqlStr  ==  _AttributeName[intIndex])
{
return mstrDsSqlStr;
}
else if (conQryRegionFlds.ItemsString  ==  _AttributeName[intIndex])
{
return mstrItemsString;
}
else if (conQryRegionFlds.DsCondStr  ==  _AttributeName[intIndex])
{
return mstrDsCondStr;
}
else if (conQryRegionFlds.ColSpan  ==  _AttributeName[intIndex])
{
return mintColSpan;
}
else if (conQryRegionFlds.Width  ==  _AttributeName[intIndex])
{
return mintWidth;
}
else if (conQryRegionFlds.SeqNum  ==  _AttributeName[intIndex])
{
return mintSeqNum;
}
else if (conQryRegionFlds.ChangeEvent  ==  _AttributeName[intIndex])
{
return mstrChangeEvent;
}
else if (conQryRegionFlds.ClickEvent  ==  _AttributeName[intIndex])
{
return mstrClickEvent;
}
else if (conQryRegionFlds.InUse  ==  _AttributeName[intIndex])
{
return mbolInUse;
}
else if (conQryRegionFlds.ErrMsg  ==  _AttributeName[intIndex])
{
return mstrErrMsg;
}
else if (conQryRegionFlds.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conQryRegionFlds.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conQryRegionFlds.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conQryRegionFlds.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conQryRegionFlds.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQryRegionFlds.mId);
}
else if (conQryRegionFlds.RegionId  ==  _AttributeName[intIndex])
{
mstrRegionId = value.ToString();
 AddUpdatedFld(conQryRegionFlds.RegionId);
}
else if (conQryRegionFlds.FldId  ==  _AttributeName[intIndex])
{
mstrFldId = value.ToString();
 AddUpdatedFld(conQryRegionFlds.FldId);
}
else if (conQryRegionFlds.OutFldId  ==  _AttributeName[intIndex])
{
mstrOutFldId = value.ToString();
 AddUpdatedFld(conQryRegionFlds.OutFldId);
}
else if (conQryRegionFlds.LabelCaption  ==  _AttributeName[intIndex])
{
mstrLabelCaption = value.ToString();
 AddUpdatedFld(conQryRegionFlds.LabelCaption);
}
else if (conQryRegionFlds.CtlTypeId  ==  _AttributeName[intIndex])
{
mstrCtlTypeId = value.ToString();
 AddUpdatedFld(conQryRegionFlds.CtlTypeId);
}
else if (conQryRegionFlds.VarId  ==  _AttributeName[intIndex])
{
mstrVarId = value.ToString();
 AddUpdatedFld(conQryRegionFlds.VarId);
}
else if (conQryRegionFlds.DsTabId  ==  _AttributeName[intIndex])
{
mstrDsTabId = value.ToString();
 AddUpdatedFld(conQryRegionFlds.DsTabId);
}
else if (conQryRegionFlds.TabFeatureId4Ddl  ==  _AttributeName[intIndex])
{
mstrTabFeatureId4Ddl = value.ToString();
 AddUpdatedFld(conQryRegionFlds.TabFeatureId4Ddl);
}
else if (conQryRegionFlds.FldIdCond1  ==  _AttributeName[intIndex])
{
mstrFldIdCond1 = value.ToString();
 AddUpdatedFld(conQryRegionFlds.FldIdCond1);
}
else if (conQryRegionFlds.VarIdCond1  ==  _AttributeName[intIndex])
{
mstrVarIdCond1 = value.ToString();
 AddUpdatedFld(conQryRegionFlds.VarIdCond1);
}
else if (conQryRegionFlds.FldIdCond2  ==  _AttributeName[intIndex])
{
mstrFldIdCond2 = value.ToString();
 AddUpdatedFld(conQryRegionFlds.FldIdCond2);
}
else if (conQryRegionFlds.VarIdCond2  ==  _AttributeName[intIndex])
{
mstrVarIdCond2 = value.ToString();
 AddUpdatedFld(conQryRegionFlds.VarIdCond2);
}
else if (conQryRegionFlds.QueryOptionId  ==  _AttributeName[intIndex])
{
mstrQueryOptionId = value.ToString();
 AddUpdatedFld(conQryRegionFlds.QueryOptionId);
}
else if (conQryRegionFlds.DdlItemsOptionId  ==  _AttributeName[intIndex])
{
mstrDdlItemsOptionId = value.ToString();
 AddUpdatedFld(conQryRegionFlds.DdlItemsOptionId);
}
else if (conQryRegionFlds.DsSqlStr  ==  _AttributeName[intIndex])
{
mstrDsSqlStr = value.ToString();
 AddUpdatedFld(conQryRegionFlds.DsSqlStr);
}
else if (conQryRegionFlds.ItemsString  ==  _AttributeName[intIndex])
{
mstrItemsString = value.ToString();
 AddUpdatedFld(conQryRegionFlds.ItemsString);
}
else if (conQryRegionFlds.DsCondStr  ==  _AttributeName[intIndex])
{
mstrDsCondStr = value.ToString();
 AddUpdatedFld(conQryRegionFlds.DsCondStr);
}
else if (conQryRegionFlds.ColSpan  ==  _AttributeName[intIndex])
{
mintColSpan = TransNullToInt(value.ToString());
 AddUpdatedFld(conQryRegionFlds.ColSpan);
}
else if (conQryRegionFlds.Width  ==  _AttributeName[intIndex])
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(conQryRegionFlds.Width);
}
else if (conQryRegionFlds.SeqNum  ==  _AttributeName[intIndex])
{
mintSeqNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conQryRegionFlds.SeqNum);
}
else if (conQryRegionFlds.ChangeEvent  ==  _AttributeName[intIndex])
{
mstrChangeEvent = value.ToString();
 AddUpdatedFld(conQryRegionFlds.ChangeEvent);
}
else if (conQryRegionFlds.ClickEvent  ==  _AttributeName[intIndex])
{
mstrClickEvent = value.ToString();
 AddUpdatedFld(conQryRegionFlds.ClickEvent);
}
else if (conQryRegionFlds.InUse  ==  _AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conQryRegionFlds.InUse);
}
else if (conQryRegionFlds.ErrMsg  ==  _AttributeName[intIndex])
{
mstrErrMsg = value.ToString();
 AddUpdatedFld(conQryRegionFlds.ErrMsg);
}
else if (conQryRegionFlds.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conQryRegionFlds.PrjId);
}
else if (conQryRegionFlds.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conQryRegionFlds.UpdUser);
}
else if (conQryRegionFlds.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQryRegionFlds.UpdDate);
}
else if (conQryRegionFlds.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQryRegionFlds.Memo);
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
 AddUpdatedFld(conQryRegionFlds.mId);
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
 AddUpdatedFld(conQryRegionFlds.RegionId);
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
 AddUpdatedFld(conQryRegionFlds.FldId);
}
}
/// <summary>
/// OutFldId(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OutFldId
{
get
{
return mstrOutFldId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOutFldId = value;
}
else
{
 mstrOutFldId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQryRegionFlds.OutFldId);
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
 AddUpdatedFld(conQryRegionFlds.LabelCaption);
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
 AddUpdatedFld(conQryRegionFlds.CtlTypeId);
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
 AddUpdatedFld(conQryRegionFlds.VarId);
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
 AddUpdatedFld(conQryRegionFlds.DsTabId);
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
 AddUpdatedFld(conQryRegionFlds.TabFeatureId4Ddl);
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
 AddUpdatedFld(conQryRegionFlds.FldIdCond1);
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
 AddUpdatedFld(conQryRegionFlds.VarIdCond1);
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
 AddUpdatedFld(conQryRegionFlds.FldIdCond2);
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
 AddUpdatedFld(conQryRegionFlds.VarIdCond2);
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
 AddUpdatedFld(conQryRegionFlds.QueryOptionId);
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
 AddUpdatedFld(conQryRegionFlds.DdlItemsOptionId);
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
 AddUpdatedFld(conQryRegionFlds.DsSqlStr);
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
 AddUpdatedFld(conQryRegionFlds.ItemsString);
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
 AddUpdatedFld(conQryRegionFlds.DsCondStr);
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
 AddUpdatedFld(conQryRegionFlds.ColSpan);
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
 AddUpdatedFld(conQryRegionFlds.Width);
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
 AddUpdatedFld(conQryRegionFlds.SeqNum);
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
 AddUpdatedFld(conQryRegionFlds.ChangeEvent);
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
 AddUpdatedFld(conQryRegionFlds.ClickEvent);
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
 AddUpdatedFld(conQryRegionFlds.InUse);
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
 AddUpdatedFld(conQryRegionFlds.ErrMsg);
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
 AddUpdatedFld(conQryRegionFlds.PrjId);
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
 AddUpdatedFld(conQryRegionFlds.UpdUser);
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
 AddUpdatedFld(conQryRegionFlds.UpdDate);
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
 AddUpdatedFld(conQryRegionFlds.Memo);
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
 /// 查询区域字段(QryRegionFlds)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conQryRegionFlds
{
public const string _CurrTabName = "QryRegionFlds"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "RegionId", "FldId", "OutFldId", "LabelCaption", "CtlTypeId", "VarId", "DsTabId", "TabFeatureId4Ddl", "FldIdCond1", "VarIdCond1", "FldIdCond2", "VarIdCond2", "QueryOptionId", "DdlItemsOptionId", "DsSqlStr", "ItemsString", "DsCondStr", "ColSpan", "Width", "SeqNum", "ChangeEvent", "ClickEvent", "InUse", "ErrMsg", "PrjId", "UpdUser", "UpdDate", "Memo"};
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
 /// 常量:"OutFldId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OutFldId = "OutFldId";    //OutFldId

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
 /// 常量:"QueryOptionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QueryOptionId = "QueryOptionId";    //查询方式Id

 /// <summary>
 /// 常量:"DdlItemsOptionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DdlItemsOptionId = "DdlItemsOptionId";    //下拉框列表选项ID

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