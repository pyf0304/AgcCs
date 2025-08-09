
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDetailRegionFldsEN
 表名:DetailRegionFlds(00050544)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:00:07
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
 /// 表DetailRegionFlds的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_DetailRegionFlds
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
public K_mId_DetailRegionFlds(long lngmId)
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
 /// <returns>返回:[K_mId_DetailRegionFlds]类型的对象</returns>
public static implicit operator K_mId_DetailRegionFlds(long value)
{
return new K_mId_DetailRegionFlds(value);
}
}
 /// <summary>
 /// 详细区域字段(DetailRegionFlds)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsDetailRegionFldsEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "DetailRegionFlds"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 21;
public static string[] _AttributeName = new string[] {"mId", "RegionId", "FldId", "OutFldId", "LabelCaption", "CtlTypeId", "ColSpan", "ColIndex", "Width", "IsMultiRow", "SeqNum", "InOutTypeId", "InUse", "ChangeEvent", "ClickEvent", "VarId", "ErrMsg", "PrjId", "UpdUser", "UpdDate", "Memo"};

protected long mlngmId;    //mId
protected string mstrRegionId;    //区域Id
protected string mstrFldId;    //字段Id
protected string mstrOutFldId;    //OutFldId
protected string mstrLabelCaption;    //标签标题
protected string mstrCtlTypeId;    //控件类型号
protected int? mintColSpan;    //跨列数
protected int? mintColIndex;    //列序号
protected int? mintWidth;    //宽
protected bool mbolIsMultiRow;    //是否多行
protected int? mintSeqNum;    //字段序号
protected string mstrInOutTypeId;    //INOUT类型ID
protected bool mbolInUse;    //是否在用
protected string mstrChangeEvent;    //Change事件
protected string mstrClickEvent;    //Click事件
protected string mstrVarId;    //变量Id
protected string mstrErrMsg;    //错误信息
protected string mstrPrjId;    //工程Id
protected string mstrUpdUser;    //修改者
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsDetailRegionFldsEN()
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
public clsDetailRegionFldsEN(long lngmId)
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
if (strAttributeName  ==  conDetailRegionFlds.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conDetailRegionFlds.RegionId)
{
return mstrRegionId;
}
else if (strAttributeName  ==  conDetailRegionFlds.FldId)
{
return mstrFldId;
}
else if (strAttributeName  ==  conDetailRegionFlds.OutFldId)
{
return mstrOutFldId;
}
else if (strAttributeName  ==  conDetailRegionFlds.LabelCaption)
{
return mstrLabelCaption;
}
else if (strAttributeName  ==  conDetailRegionFlds.CtlTypeId)
{
return mstrCtlTypeId;
}
else if (strAttributeName  ==  conDetailRegionFlds.ColSpan)
{
return mintColSpan;
}
else if (strAttributeName  ==  conDetailRegionFlds.ColIndex)
{
return mintColIndex;
}
else if (strAttributeName  ==  conDetailRegionFlds.Width)
{
return mintWidth;
}
else if (strAttributeName  ==  conDetailRegionFlds.IsMultiRow)
{
return mbolIsMultiRow;
}
else if (strAttributeName  ==  conDetailRegionFlds.SeqNum)
{
return mintSeqNum;
}
else if (strAttributeName  ==  conDetailRegionFlds.InOutTypeId)
{
return mstrInOutTypeId;
}
else if (strAttributeName  ==  conDetailRegionFlds.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  conDetailRegionFlds.ChangeEvent)
{
return mstrChangeEvent;
}
else if (strAttributeName  ==  conDetailRegionFlds.ClickEvent)
{
return mstrClickEvent;
}
else if (strAttributeName  ==  conDetailRegionFlds.VarId)
{
return mstrVarId;
}
else if (strAttributeName  ==  conDetailRegionFlds.ErrMsg)
{
return mstrErrMsg;
}
else if (strAttributeName  ==  conDetailRegionFlds.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conDetailRegionFlds.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conDetailRegionFlds.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conDetailRegionFlds.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conDetailRegionFlds.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conDetailRegionFlds.mId);
}
else if (strAttributeName  ==  conDetailRegionFlds.RegionId)
{
mstrRegionId = value.ToString();
 AddUpdatedFld(conDetailRegionFlds.RegionId);
}
else if (strAttributeName  ==  conDetailRegionFlds.FldId)
{
mstrFldId = value.ToString();
 AddUpdatedFld(conDetailRegionFlds.FldId);
}
else if (strAttributeName  ==  conDetailRegionFlds.OutFldId)
{
mstrOutFldId = value.ToString();
 AddUpdatedFld(conDetailRegionFlds.OutFldId);
}
else if (strAttributeName  ==  conDetailRegionFlds.LabelCaption)
{
mstrLabelCaption = value.ToString();
 AddUpdatedFld(conDetailRegionFlds.LabelCaption);
}
else if (strAttributeName  ==  conDetailRegionFlds.CtlTypeId)
{
mstrCtlTypeId = value.ToString();
 AddUpdatedFld(conDetailRegionFlds.CtlTypeId);
}
else if (strAttributeName  ==  conDetailRegionFlds.ColSpan)
{
mintColSpan = TransNullToInt(value.ToString());
 AddUpdatedFld(conDetailRegionFlds.ColSpan);
}
else if (strAttributeName  ==  conDetailRegionFlds.ColIndex)
{
mintColIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(conDetailRegionFlds.ColIndex);
}
else if (strAttributeName  ==  conDetailRegionFlds.Width)
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(conDetailRegionFlds.Width);
}
else if (strAttributeName  ==  conDetailRegionFlds.IsMultiRow)
{
mbolIsMultiRow = TransNullToBool(value.ToString());
 AddUpdatedFld(conDetailRegionFlds.IsMultiRow);
}
else if (strAttributeName  ==  conDetailRegionFlds.SeqNum)
{
mintSeqNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conDetailRegionFlds.SeqNum);
}
else if (strAttributeName  ==  conDetailRegionFlds.InOutTypeId)
{
mstrInOutTypeId = value.ToString();
 AddUpdatedFld(conDetailRegionFlds.InOutTypeId);
}
else if (strAttributeName  ==  conDetailRegionFlds.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conDetailRegionFlds.InUse);
}
else if (strAttributeName  ==  conDetailRegionFlds.ChangeEvent)
{
mstrChangeEvent = value.ToString();
 AddUpdatedFld(conDetailRegionFlds.ChangeEvent);
}
else if (strAttributeName  ==  conDetailRegionFlds.ClickEvent)
{
mstrClickEvent = value.ToString();
 AddUpdatedFld(conDetailRegionFlds.ClickEvent);
}
else if (strAttributeName  ==  conDetailRegionFlds.VarId)
{
mstrVarId = value.ToString();
 AddUpdatedFld(conDetailRegionFlds.VarId);
}
else if (strAttributeName  ==  conDetailRegionFlds.ErrMsg)
{
mstrErrMsg = value.ToString();
 AddUpdatedFld(conDetailRegionFlds.ErrMsg);
}
else if (strAttributeName  ==  conDetailRegionFlds.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conDetailRegionFlds.PrjId);
}
else if (strAttributeName  ==  conDetailRegionFlds.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conDetailRegionFlds.UpdUser);
}
else if (strAttributeName  ==  conDetailRegionFlds.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conDetailRegionFlds.UpdDate);
}
else if (strAttributeName  ==  conDetailRegionFlds.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDetailRegionFlds.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conDetailRegionFlds.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (conDetailRegionFlds.RegionId  ==  _AttributeName[intIndex])
{
return mstrRegionId;
}
else if (conDetailRegionFlds.FldId  ==  _AttributeName[intIndex])
{
return mstrFldId;
}
else if (conDetailRegionFlds.OutFldId  ==  _AttributeName[intIndex])
{
return mstrOutFldId;
}
else if (conDetailRegionFlds.LabelCaption  ==  _AttributeName[intIndex])
{
return mstrLabelCaption;
}
else if (conDetailRegionFlds.CtlTypeId  ==  _AttributeName[intIndex])
{
return mstrCtlTypeId;
}
else if (conDetailRegionFlds.ColSpan  ==  _AttributeName[intIndex])
{
return mintColSpan;
}
else if (conDetailRegionFlds.ColIndex  ==  _AttributeName[intIndex])
{
return mintColIndex;
}
else if (conDetailRegionFlds.Width  ==  _AttributeName[intIndex])
{
return mintWidth;
}
else if (conDetailRegionFlds.IsMultiRow  ==  _AttributeName[intIndex])
{
return mbolIsMultiRow;
}
else if (conDetailRegionFlds.SeqNum  ==  _AttributeName[intIndex])
{
return mintSeqNum;
}
else if (conDetailRegionFlds.InOutTypeId  ==  _AttributeName[intIndex])
{
return mstrInOutTypeId;
}
else if (conDetailRegionFlds.InUse  ==  _AttributeName[intIndex])
{
return mbolInUse;
}
else if (conDetailRegionFlds.ChangeEvent  ==  _AttributeName[intIndex])
{
return mstrChangeEvent;
}
else if (conDetailRegionFlds.ClickEvent  ==  _AttributeName[intIndex])
{
return mstrClickEvent;
}
else if (conDetailRegionFlds.VarId  ==  _AttributeName[intIndex])
{
return mstrVarId;
}
else if (conDetailRegionFlds.ErrMsg  ==  _AttributeName[intIndex])
{
return mstrErrMsg;
}
else if (conDetailRegionFlds.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conDetailRegionFlds.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conDetailRegionFlds.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conDetailRegionFlds.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conDetailRegionFlds.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conDetailRegionFlds.mId);
}
else if (conDetailRegionFlds.RegionId  ==  _AttributeName[intIndex])
{
mstrRegionId = value.ToString();
 AddUpdatedFld(conDetailRegionFlds.RegionId);
}
else if (conDetailRegionFlds.FldId  ==  _AttributeName[intIndex])
{
mstrFldId = value.ToString();
 AddUpdatedFld(conDetailRegionFlds.FldId);
}
else if (conDetailRegionFlds.OutFldId  ==  _AttributeName[intIndex])
{
mstrOutFldId = value.ToString();
 AddUpdatedFld(conDetailRegionFlds.OutFldId);
}
else if (conDetailRegionFlds.LabelCaption  ==  _AttributeName[intIndex])
{
mstrLabelCaption = value.ToString();
 AddUpdatedFld(conDetailRegionFlds.LabelCaption);
}
else if (conDetailRegionFlds.CtlTypeId  ==  _AttributeName[intIndex])
{
mstrCtlTypeId = value.ToString();
 AddUpdatedFld(conDetailRegionFlds.CtlTypeId);
}
else if (conDetailRegionFlds.ColSpan  ==  _AttributeName[intIndex])
{
mintColSpan = TransNullToInt(value.ToString());
 AddUpdatedFld(conDetailRegionFlds.ColSpan);
}
else if (conDetailRegionFlds.ColIndex  ==  _AttributeName[intIndex])
{
mintColIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(conDetailRegionFlds.ColIndex);
}
else if (conDetailRegionFlds.Width  ==  _AttributeName[intIndex])
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(conDetailRegionFlds.Width);
}
else if (conDetailRegionFlds.IsMultiRow  ==  _AttributeName[intIndex])
{
mbolIsMultiRow = TransNullToBool(value.ToString());
 AddUpdatedFld(conDetailRegionFlds.IsMultiRow);
}
else if (conDetailRegionFlds.SeqNum  ==  _AttributeName[intIndex])
{
mintSeqNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conDetailRegionFlds.SeqNum);
}
else if (conDetailRegionFlds.InOutTypeId  ==  _AttributeName[intIndex])
{
mstrInOutTypeId = value.ToString();
 AddUpdatedFld(conDetailRegionFlds.InOutTypeId);
}
else if (conDetailRegionFlds.InUse  ==  _AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conDetailRegionFlds.InUse);
}
else if (conDetailRegionFlds.ChangeEvent  ==  _AttributeName[intIndex])
{
mstrChangeEvent = value.ToString();
 AddUpdatedFld(conDetailRegionFlds.ChangeEvent);
}
else if (conDetailRegionFlds.ClickEvent  ==  _AttributeName[intIndex])
{
mstrClickEvent = value.ToString();
 AddUpdatedFld(conDetailRegionFlds.ClickEvent);
}
else if (conDetailRegionFlds.VarId  ==  _AttributeName[intIndex])
{
mstrVarId = value.ToString();
 AddUpdatedFld(conDetailRegionFlds.VarId);
}
else if (conDetailRegionFlds.ErrMsg  ==  _AttributeName[intIndex])
{
mstrErrMsg = value.ToString();
 AddUpdatedFld(conDetailRegionFlds.ErrMsg);
}
else if (conDetailRegionFlds.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conDetailRegionFlds.PrjId);
}
else if (conDetailRegionFlds.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conDetailRegionFlds.UpdUser);
}
else if (conDetailRegionFlds.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conDetailRegionFlds.UpdDate);
}
else if (conDetailRegionFlds.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDetailRegionFlds.Memo);
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
 AddUpdatedFld(conDetailRegionFlds.mId);
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
 AddUpdatedFld(conDetailRegionFlds.RegionId);
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
 AddUpdatedFld(conDetailRegionFlds.FldId);
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
 AddUpdatedFld(conDetailRegionFlds.OutFldId);
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
 AddUpdatedFld(conDetailRegionFlds.LabelCaption);
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
 AddUpdatedFld(conDetailRegionFlds.CtlTypeId);
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
 AddUpdatedFld(conDetailRegionFlds.ColSpan);
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
 AddUpdatedFld(conDetailRegionFlds.ColIndex);
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
 AddUpdatedFld(conDetailRegionFlds.Width);
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
 AddUpdatedFld(conDetailRegionFlds.IsMultiRow);
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
 AddUpdatedFld(conDetailRegionFlds.SeqNum);
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
 AddUpdatedFld(conDetailRegionFlds.InOutTypeId);
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
 AddUpdatedFld(conDetailRegionFlds.InUse);
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
 AddUpdatedFld(conDetailRegionFlds.ChangeEvent);
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
 AddUpdatedFld(conDetailRegionFlds.ClickEvent);
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
 AddUpdatedFld(conDetailRegionFlds.VarId);
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
 AddUpdatedFld(conDetailRegionFlds.ErrMsg);
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
 AddUpdatedFld(conDetailRegionFlds.PrjId);
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
 AddUpdatedFld(conDetailRegionFlds.UpdUser);
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
 AddUpdatedFld(conDetailRegionFlds.UpdDate);
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
 AddUpdatedFld(conDetailRegionFlds.Memo);
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
 /// 详细区域字段(DetailRegionFlds)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conDetailRegionFlds
{
public const string _CurrTabName = "DetailRegionFlds"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "RegionId", "FldId", "OutFldId", "LabelCaption", "CtlTypeId", "ColSpan", "ColIndex", "Width", "IsMultiRow", "SeqNum", "InOutTypeId", "InUse", "ChangeEvent", "ClickEvent", "VarId", "ErrMsg", "PrjId", "UpdUser", "UpdDate", "Memo"};
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
 /// 常量:"VarId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VarId = "VarId";    //变量Id

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