
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDGRegionFldsEN
 表名:DGRegionFlds(00050113)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 19:59:54
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
 /// 表DGRegionFlds的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_DGRegionFlds
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
public K_mId_DGRegionFlds(long lngmId)
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
 /// <returns>返回:[K_mId_DGRegionFlds]类型的对象</returns>
public static implicit operator K_mId_DGRegionFlds(long value)
{
return new K_mId_DGRegionFlds(value);
}
}
 /// <summary>
 /// DG区域字段(DGRegionFlds)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsDGRegionFldsEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "DGRegionFlds"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 21;
public static string[] _AttributeName = new string[] {"mId", "RegionId", "FldId", "OutFldId", "SortExpression", "SeqNum", "HeaderText", "ToolTipText", "CtlTypeId", "DgFuncTypeId", "IsNeedSort", "IsDefaultSort", "IsTransToChkBox", "IsVisible", "IsFuncFld", "InUse", "ErrMsg", "PrjId", "UpdUser", "UpdDate", "Memo"};

protected long mlngmId;    //mId
protected string mstrRegionId;    //区域Id
protected string mstrFldId;    //字段Id
protected string mstrOutFldId;    //OutFldId
protected string mstrSortExpression;    //排序表达式
protected int mintSeqNum;    //字段序号
protected string mstrHeaderText;    //列头
protected string mstrToolTipText;    //提示文字
protected string mstrCtlTypeId;    //控件类型号
protected string mstrDgFuncTypeId;    //Dg功能类型Id
protected bool mbolIsNeedSort;    //是否需要排序
protected bool mbolIsDefaultSort;    //是否默认排序
protected bool mbolIsTransToChkBox;    //是否转换成CheckBox
protected bool mbolIsVisible;    //是否显示
protected bool mbolIsFuncFld;    //是否功能字段
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
 public clsDGRegionFldsEN()
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
public clsDGRegionFldsEN(long lngmId)
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
if (strAttributeName  ==  conDGRegionFlds.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conDGRegionFlds.RegionId)
{
return mstrRegionId;
}
else if (strAttributeName  ==  conDGRegionFlds.FldId)
{
return mstrFldId;
}
else if (strAttributeName  ==  conDGRegionFlds.OutFldId)
{
return mstrOutFldId;
}
else if (strAttributeName  ==  conDGRegionFlds.SortExpression)
{
return mstrSortExpression;
}
else if (strAttributeName  ==  conDGRegionFlds.SeqNum)
{
return mintSeqNum;
}
else if (strAttributeName  ==  conDGRegionFlds.HeaderText)
{
return mstrHeaderText;
}
else if (strAttributeName  ==  conDGRegionFlds.ToolTipText)
{
return mstrToolTipText;
}
else if (strAttributeName  ==  conDGRegionFlds.CtlTypeId)
{
return mstrCtlTypeId;
}
else if (strAttributeName  ==  conDGRegionFlds.DgFuncTypeId)
{
return mstrDgFuncTypeId;
}
else if (strAttributeName  ==  conDGRegionFlds.IsNeedSort)
{
return mbolIsNeedSort;
}
else if (strAttributeName  ==  conDGRegionFlds.IsDefaultSort)
{
return mbolIsDefaultSort;
}
else if (strAttributeName  ==  conDGRegionFlds.IsTransToChkBox)
{
return mbolIsTransToChkBox;
}
else if (strAttributeName  ==  conDGRegionFlds.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  conDGRegionFlds.IsFuncFld)
{
return mbolIsFuncFld;
}
else if (strAttributeName  ==  conDGRegionFlds.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  conDGRegionFlds.ErrMsg)
{
return mstrErrMsg;
}
else if (strAttributeName  ==  conDGRegionFlds.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conDGRegionFlds.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conDGRegionFlds.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conDGRegionFlds.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conDGRegionFlds.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conDGRegionFlds.mId);
}
else if (strAttributeName  ==  conDGRegionFlds.RegionId)
{
mstrRegionId = value.ToString();
 AddUpdatedFld(conDGRegionFlds.RegionId);
}
else if (strAttributeName  ==  conDGRegionFlds.FldId)
{
mstrFldId = value.ToString();
 AddUpdatedFld(conDGRegionFlds.FldId);
}
else if (strAttributeName  ==  conDGRegionFlds.OutFldId)
{
mstrOutFldId = value.ToString();
 AddUpdatedFld(conDGRegionFlds.OutFldId);
}
else if (strAttributeName  ==  conDGRegionFlds.SortExpression)
{
mstrSortExpression = value.ToString();
 AddUpdatedFld(conDGRegionFlds.SortExpression);
}
else if (strAttributeName  ==  conDGRegionFlds.SeqNum)
{
mintSeqNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conDGRegionFlds.SeqNum);
}
else if (strAttributeName  ==  conDGRegionFlds.HeaderText)
{
mstrHeaderText = value.ToString();
 AddUpdatedFld(conDGRegionFlds.HeaderText);
}
else if (strAttributeName  ==  conDGRegionFlds.ToolTipText)
{
mstrToolTipText = value.ToString();
 AddUpdatedFld(conDGRegionFlds.ToolTipText);
}
else if (strAttributeName  ==  conDGRegionFlds.CtlTypeId)
{
mstrCtlTypeId = value.ToString();
 AddUpdatedFld(conDGRegionFlds.CtlTypeId);
}
else if (strAttributeName  ==  conDGRegionFlds.DgFuncTypeId)
{
mstrDgFuncTypeId = value.ToString();
 AddUpdatedFld(conDGRegionFlds.DgFuncTypeId);
}
else if (strAttributeName  ==  conDGRegionFlds.IsNeedSort)
{
mbolIsNeedSort = TransNullToBool(value.ToString());
 AddUpdatedFld(conDGRegionFlds.IsNeedSort);
}
else if (strAttributeName  ==  conDGRegionFlds.IsDefaultSort)
{
mbolIsDefaultSort = TransNullToBool(value.ToString());
 AddUpdatedFld(conDGRegionFlds.IsDefaultSort);
}
else if (strAttributeName  ==  conDGRegionFlds.IsTransToChkBox)
{
mbolIsTransToChkBox = TransNullToBool(value.ToString());
 AddUpdatedFld(conDGRegionFlds.IsTransToChkBox);
}
else if (strAttributeName  ==  conDGRegionFlds.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conDGRegionFlds.IsVisible);
}
else if (strAttributeName  ==  conDGRegionFlds.IsFuncFld)
{
mbolIsFuncFld = TransNullToBool(value.ToString());
 AddUpdatedFld(conDGRegionFlds.IsFuncFld);
}
else if (strAttributeName  ==  conDGRegionFlds.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conDGRegionFlds.InUse);
}
else if (strAttributeName  ==  conDGRegionFlds.ErrMsg)
{
mstrErrMsg = value.ToString();
 AddUpdatedFld(conDGRegionFlds.ErrMsg);
}
else if (strAttributeName  ==  conDGRegionFlds.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conDGRegionFlds.PrjId);
}
else if (strAttributeName  ==  conDGRegionFlds.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conDGRegionFlds.UpdUser);
}
else if (strAttributeName  ==  conDGRegionFlds.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conDGRegionFlds.UpdDate);
}
else if (strAttributeName  ==  conDGRegionFlds.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDGRegionFlds.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conDGRegionFlds.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (conDGRegionFlds.RegionId  ==  _AttributeName[intIndex])
{
return mstrRegionId;
}
else if (conDGRegionFlds.FldId  ==  _AttributeName[intIndex])
{
return mstrFldId;
}
else if (conDGRegionFlds.OutFldId  ==  _AttributeName[intIndex])
{
return mstrOutFldId;
}
else if (conDGRegionFlds.SortExpression  ==  _AttributeName[intIndex])
{
return mstrSortExpression;
}
else if (conDGRegionFlds.SeqNum  ==  _AttributeName[intIndex])
{
return mintSeqNum;
}
else if (conDGRegionFlds.HeaderText  ==  _AttributeName[intIndex])
{
return mstrHeaderText;
}
else if (conDGRegionFlds.ToolTipText  ==  _AttributeName[intIndex])
{
return mstrToolTipText;
}
else if (conDGRegionFlds.CtlTypeId  ==  _AttributeName[intIndex])
{
return mstrCtlTypeId;
}
else if (conDGRegionFlds.DgFuncTypeId  ==  _AttributeName[intIndex])
{
return mstrDgFuncTypeId;
}
else if (conDGRegionFlds.IsNeedSort  ==  _AttributeName[intIndex])
{
return mbolIsNeedSort;
}
else if (conDGRegionFlds.IsDefaultSort  ==  _AttributeName[intIndex])
{
return mbolIsDefaultSort;
}
else if (conDGRegionFlds.IsTransToChkBox  ==  _AttributeName[intIndex])
{
return mbolIsTransToChkBox;
}
else if (conDGRegionFlds.IsVisible  ==  _AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (conDGRegionFlds.IsFuncFld  ==  _AttributeName[intIndex])
{
return mbolIsFuncFld;
}
else if (conDGRegionFlds.InUse  ==  _AttributeName[intIndex])
{
return mbolInUse;
}
else if (conDGRegionFlds.ErrMsg  ==  _AttributeName[intIndex])
{
return mstrErrMsg;
}
else if (conDGRegionFlds.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conDGRegionFlds.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conDGRegionFlds.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conDGRegionFlds.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conDGRegionFlds.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conDGRegionFlds.mId);
}
else if (conDGRegionFlds.RegionId  ==  _AttributeName[intIndex])
{
mstrRegionId = value.ToString();
 AddUpdatedFld(conDGRegionFlds.RegionId);
}
else if (conDGRegionFlds.FldId  ==  _AttributeName[intIndex])
{
mstrFldId = value.ToString();
 AddUpdatedFld(conDGRegionFlds.FldId);
}
else if (conDGRegionFlds.OutFldId  ==  _AttributeName[intIndex])
{
mstrOutFldId = value.ToString();
 AddUpdatedFld(conDGRegionFlds.OutFldId);
}
else if (conDGRegionFlds.SortExpression  ==  _AttributeName[intIndex])
{
mstrSortExpression = value.ToString();
 AddUpdatedFld(conDGRegionFlds.SortExpression);
}
else if (conDGRegionFlds.SeqNum  ==  _AttributeName[intIndex])
{
mintSeqNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conDGRegionFlds.SeqNum);
}
else if (conDGRegionFlds.HeaderText  ==  _AttributeName[intIndex])
{
mstrHeaderText = value.ToString();
 AddUpdatedFld(conDGRegionFlds.HeaderText);
}
else if (conDGRegionFlds.ToolTipText  ==  _AttributeName[intIndex])
{
mstrToolTipText = value.ToString();
 AddUpdatedFld(conDGRegionFlds.ToolTipText);
}
else if (conDGRegionFlds.CtlTypeId  ==  _AttributeName[intIndex])
{
mstrCtlTypeId = value.ToString();
 AddUpdatedFld(conDGRegionFlds.CtlTypeId);
}
else if (conDGRegionFlds.DgFuncTypeId  ==  _AttributeName[intIndex])
{
mstrDgFuncTypeId = value.ToString();
 AddUpdatedFld(conDGRegionFlds.DgFuncTypeId);
}
else if (conDGRegionFlds.IsNeedSort  ==  _AttributeName[intIndex])
{
mbolIsNeedSort = TransNullToBool(value.ToString());
 AddUpdatedFld(conDGRegionFlds.IsNeedSort);
}
else if (conDGRegionFlds.IsDefaultSort  ==  _AttributeName[intIndex])
{
mbolIsDefaultSort = TransNullToBool(value.ToString());
 AddUpdatedFld(conDGRegionFlds.IsDefaultSort);
}
else if (conDGRegionFlds.IsTransToChkBox  ==  _AttributeName[intIndex])
{
mbolIsTransToChkBox = TransNullToBool(value.ToString());
 AddUpdatedFld(conDGRegionFlds.IsTransToChkBox);
}
else if (conDGRegionFlds.IsVisible  ==  _AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conDGRegionFlds.IsVisible);
}
else if (conDGRegionFlds.IsFuncFld  ==  _AttributeName[intIndex])
{
mbolIsFuncFld = TransNullToBool(value.ToString());
 AddUpdatedFld(conDGRegionFlds.IsFuncFld);
}
else if (conDGRegionFlds.InUse  ==  _AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conDGRegionFlds.InUse);
}
else if (conDGRegionFlds.ErrMsg  ==  _AttributeName[intIndex])
{
mstrErrMsg = value.ToString();
 AddUpdatedFld(conDGRegionFlds.ErrMsg);
}
else if (conDGRegionFlds.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conDGRegionFlds.PrjId);
}
else if (conDGRegionFlds.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conDGRegionFlds.UpdUser);
}
else if (conDGRegionFlds.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conDGRegionFlds.UpdDate);
}
else if (conDGRegionFlds.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDGRegionFlds.Memo);
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
 AddUpdatedFld(conDGRegionFlds.mId);
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
 AddUpdatedFld(conDGRegionFlds.RegionId);
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
 AddUpdatedFld(conDGRegionFlds.FldId);
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
 AddUpdatedFld(conDGRegionFlds.OutFldId);
}
}
/// <summary>
/// 排序表达式(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SortExpression
{
get
{
return mstrSortExpression;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSortExpression = value;
}
else
{
 mstrSortExpression = value;
}
//记录修改过的字段
 AddUpdatedFld(conDGRegionFlds.SortExpression);
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
 AddUpdatedFld(conDGRegionFlds.SeqNum);
}
}
/// <summary>
/// 列头(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string HeaderText
{
get
{
return mstrHeaderText;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrHeaderText = value;
}
else
{
 mstrHeaderText = value;
}
//记录修改过的字段
 AddUpdatedFld(conDGRegionFlds.HeaderText);
}
}
/// <summary>
/// 提示文字(说明:;字段类型:varchar;字段长度:150;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ToolTipText
{
get
{
return mstrToolTipText;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrToolTipText = value;
}
else
{
 mstrToolTipText = value;
}
//记录修改过的字段
 AddUpdatedFld(conDGRegionFlds.ToolTipText);
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
 AddUpdatedFld(conDGRegionFlds.CtlTypeId);
}
}
/// <summary>
/// Dg功能类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DgFuncTypeId
{
get
{
return mstrDgFuncTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDgFuncTypeId = value;
}
else
{
 mstrDgFuncTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conDGRegionFlds.DgFuncTypeId);
}
}
/// <summary>
/// 是否需要排序(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsNeedSort
{
get
{
return mbolIsNeedSort;
}
set
{
 mbolIsNeedSort = value;
//记录修改过的字段
 AddUpdatedFld(conDGRegionFlds.IsNeedSort);
}
}
/// <summary>
/// 是否默认排序(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsDefaultSort
{
get
{
return mbolIsDefaultSort;
}
set
{
 mbolIsDefaultSort = value;
//记录修改过的字段
 AddUpdatedFld(conDGRegionFlds.IsDefaultSort);
}
}
/// <summary>
/// 是否转换成CheckBox(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsTransToChkBox
{
get
{
return mbolIsTransToChkBox;
}
set
{
 mbolIsTransToChkBox = value;
//记录修改过的字段
 AddUpdatedFld(conDGRegionFlds.IsTransToChkBox);
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
 AddUpdatedFld(conDGRegionFlds.IsVisible);
}
}
/// <summary>
/// 是否功能字段(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsFuncFld
{
get
{
return mbolIsFuncFld;
}
set
{
 mbolIsFuncFld = value;
//记录修改过的字段
 AddUpdatedFld(conDGRegionFlds.IsFuncFld);
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
 AddUpdatedFld(conDGRegionFlds.InUse);
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
 AddUpdatedFld(conDGRegionFlds.ErrMsg);
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
 AddUpdatedFld(conDGRegionFlds.PrjId);
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
 AddUpdatedFld(conDGRegionFlds.UpdUser);
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
 AddUpdatedFld(conDGRegionFlds.UpdDate);
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
 AddUpdatedFld(conDGRegionFlds.Memo);
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
 /// DG区域字段(DGRegionFlds)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conDGRegionFlds
{
public const string _CurrTabName = "DGRegionFlds"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "RegionId", "FldId", "OutFldId", "SortExpression", "SeqNum", "HeaderText", "ToolTipText", "CtlTypeId", "DgFuncTypeId", "IsNeedSort", "IsDefaultSort", "IsTransToChkBox", "IsVisible", "IsFuncFld", "InUse", "ErrMsg", "PrjId", "UpdUser", "UpdDate", "Memo"};
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
 /// 常量:"SortExpression"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SortExpression = "SortExpression";    //排序表达式

 /// <summary>
 /// 常量:"SeqNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SeqNum = "SeqNum";    //字段序号

 /// <summary>
 /// 常量:"HeaderText"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string HeaderText = "HeaderText";    //列头

 /// <summary>
 /// 常量:"ToolTipText"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ToolTipText = "ToolTipText";    //提示文字

 /// <summary>
 /// 常量:"CtlTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CtlTypeId = "CtlTypeId";    //控件类型号

 /// <summary>
 /// 常量:"DgFuncTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DgFuncTypeId = "DgFuncTypeId";    //Dg功能类型Id

 /// <summary>
 /// 常量:"IsNeedSort"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsNeedSort = "IsNeedSort";    //是否需要排序

 /// <summary>
 /// 常量:"IsDefaultSort"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDefaultSort = "IsDefaultSort";    //是否默认排序

 /// <summary>
 /// 常量:"IsTransToChkBox"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsTransToChkBox = "IsTransToChkBox";    //是否转换成CheckBox

 /// <summary>
 /// 常量:"IsVisible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVisible = "IsVisible";    //是否显示

 /// <summary>
 /// 常量:"IsFuncFld"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsFuncFld = "IsFuncFld";    //是否功能字段

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