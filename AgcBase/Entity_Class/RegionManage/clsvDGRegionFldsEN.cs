
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvDGRegionFldsEN
 表名:vDGRegionFlds(00050201)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:07:08
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
 /// 表vDGRegionFlds的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vDGRegionFlds
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
public K_mId_vDGRegionFlds(long lngmId)
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
 /// <returns>返回:[K_mId_vDGRegionFlds]类型的对象</returns>
public static implicit operator K_mId_vDGRegionFlds(long value)
{
return new K_mId_vDGRegionFlds(value);
}
}
 /// <summary>
 /// vDG区域字段(vDGRegionFlds)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvDGRegionFldsEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vDGRegionFlds"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 25;
public static string[] _AttributeName = new string[] {"mId", "RegionId", "RegionName", "TabId", "FldId", "FldName", "SortExpression", "SeqNum", "HeaderText", "ToolTipText", "CtlTypeId", "CtlTypeName", "CtlCnName", "DgFuncTypeId", "DgFuncTypeName", "IsNeedSort", "IsDefaultSort", "IsTransToChkBox", "IsVisible", "IsFuncFld", "InUse", "UpdUser", "UpdDate", "Memo", "PrjId"};

protected long mlngmId;    //mId
protected string mstrRegionId;    //区域Id
protected string mstrRegionName;    //区域名称
protected string mstrTabId;    //表ID
protected string mstrFldId;    //字段Id
protected string mstrFldName;    //字段名
protected string mstrSortExpression;    //排序表达式
protected int mintSeqNum;    //字段序号
protected string mstrHeaderText;    //列头
protected string mstrToolTipText;    //提示文字
protected string mstrCtlTypeId;    //控件类型号
protected string mstrCtlTypeName;    //控件类型名
protected string mstrCtlCnName;    //控件类型中文名
protected string mstrDgFuncTypeId;    //Dg功能类型Id
protected string mstrDgFuncTypeName;    //Dg功能类型名
protected bool mbolIsNeedSort;    //是否需要排序
protected bool mbolIsDefaultSort;    //是否默认排序
protected bool mbolIsTransToChkBox;    //是否转换成CheckBox
protected bool mbolIsVisible;    //是否显示
protected bool mbolIsFuncFld;    //是否功能字段
protected bool mbolInUse;    //是否在用
protected string mstrUpdUser;    //修改者
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //说明
protected string mstrPrjId;    //工程Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvDGRegionFldsEN()
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
public clsvDGRegionFldsEN(long lngmId)
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
if (strAttributeName  ==  convDGRegionFlds.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convDGRegionFlds.RegionId)
{
return mstrRegionId;
}
else if (strAttributeName  ==  convDGRegionFlds.RegionName)
{
return mstrRegionName;
}
else if (strAttributeName  ==  convDGRegionFlds.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  convDGRegionFlds.FldId)
{
return mstrFldId;
}
else if (strAttributeName  ==  convDGRegionFlds.FldName)
{
return mstrFldName;
}
else if (strAttributeName  ==  convDGRegionFlds.SortExpression)
{
return mstrSortExpression;
}
else if (strAttributeName  ==  convDGRegionFlds.SeqNum)
{
return mintSeqNum;
}
else if (strAttributeName  ==  convDGRegionFlds.HeaderText)
{
return mstrHeaderText;
}
else if (strAttributeName  ==  convDGRegionFlds.ToolTipText)
{
return mstrToolTipText;
}
else if (strAttributeName  ==  convDGRegionFlds.CtlTypeId)
{
return mstrCtlTypeId;
}
else if (strAttributeName  ==  convDGRegionFlds.CtlTypeName)
{
return mstrCtlTypeName;
}
else if (strAttributeName  ==  convDGRegionFlds.CtlCnName)
{
return mstrCtlCnName;
}
else if (strAttributeName  ==  convDGRegionFlds.DgFuncTypeId)
{
return mstrDgFuncTypeId;
}
else if (strAttributeName  ==  convDGRegionFlds.DgFuncTypeName)
{
return mstrDgFuncTypeName;
}
else if (strAttributeName  ==  convDGRegionFlds.IsNeedSort)
{
return mbolIsNeedSort;
}
else if (strAttributeName  ==  convDGRegionFlds.IsDefaultSort)
{
return mbolIsDefaultSort;
}
else if (strAttributeName  ==  convDGRegionFlds.IsTransToChkBox)
{
return mbolIsTransToChkBox;
}
else if (strAttributeName  ==  convDGRegionFlds.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  convDGRegionFlds.IsFuncFld)
{
return mbolIsFuncFld;
}
else if (strAttributeName  ==  convDGRegionFlds.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  convDGRegionFlds.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convDGRegionFlds.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convDGRegionFlds.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convDGRegionFlds.PrjId)
{
return mstrPrjId;
}
return null;
}
set
{
if (strAttributeName  ==  convDGRegionFlds.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convDGRegionFlds.mId);
}
else if (strAttributeName  ==  convDGRegionFlds.RegionId)
{
mstrRegionId = value.ToString();
 AddUpdatedFld(convDGRegionFlds.RegionId);
}
else if (strAttributeName  ==  convDGRegionFlds.RegionName)
{
mstrRegionName = value.ToString();
 AddUpdatedFld(convDGRegionFlds.RegionName);
}
else if (strAttributeName  ==  convDGRegionFlds.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(convDGRegionFlds.TabId);
}
else if (strAttributeName  ==  convDGRegionFlds.FldId)
{
mstrFldId = value.ToString();
 AddUpdatedFld(convDGRegionFlds.FldId);
}
else if (strAttributeName  ==  convDGRegionFlds.FldName)
{
mstrFldName = value.ToString();
 AddUpdatedFld(convDGRegionFlds.FldName);
}
else if (strAttributeName  ==  convDGRegionFlds.SortExpression)
{
mstrSortExpression = value.ToString();
 AddUpdatedFld(convDGRegionFlds.SortExpression);
}
else if (strAttributeName  ==  convDGRegionFlds.SeqNum)
{
mintSeqNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convDGRegionFlds.SeqNum);
}
else if (strAttributeName  ==  convDGRegionFlds.HeaderText)
{
mstrHeaderText = value.ToString();
 AddUpdatedFld(convDGRegionFlds.HeaderText);
}
else if (strAttributeName  ==  convDGRegionFlds.ToolTipText)
{
mstrToolTipText = value.ToString();
 AddUpdatedFld(convDGRegionFlds.ToolTipText);
}
else if (strAttributeName  ==  convDGRegionFlds.CtlTypeId)
{
mstrCtlTypeId = value.ToString();
 AddUpdatedFld(convDGRegionFlds.CtlTypeId);
}
else if (strAttributeName  ==  convDGRegionFlds.CtlTypeName)
{
mstrCtlTypeName = value.ToString();
 AddUpdatedFld(convDGRegionFlds.CtlTypeName);
}
else if (strAttributeName  ==  convDGRegionFlds.CtlCnName)
{
mstrCtlCnName = value.ToString();
 AddUpdatedFld(convDGRegionFlds.CtlCnName);
}
else if (strAttributeName  ==  convDGRegionFlds.DgFuncTypeId)
{
mstrDgFuncTypeId = value.ToString();
 AddUpdatedFld(convDGRegionFlds.DgFuncTypeId);
}
else if (strAttributeName  ==  convDGRegionFlds.DgFuncTypeName)
{
mstrDgFuncTypeName = value.ToString();
 AddUpdatedFld(convDGRegionFlds.DgFuncTypeName);
}
else if (strAttributeName  ==  convDGRegionFlds.IsNeedSort)
{
mbolIsNeedSort = TransNullToBool(value.ToString());
 AddUpdatedFld(convDGRegionFlds.IsNeedSort);
}
else if (strAttributeName  ==  convDGRegionFlds.IsDefaultSort)
{
mbolIsDefaultSort = TransNullToBool(value.ToString());
 AddUpdatedFld(convDGRegionFlds.IsDefaultSort);
}
else if (strAttributeName  ==  convDGRegionFlds.IsTransToChkBox)
{
mbolIsTransToChkBox = TransNullToBool(value.ToString());
 AddUpdatedFld(convDGRegionFlds.IsTransToChkBox);
}
else if (strAttributeName  ==  convDGRegionFlds.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convDGRegionFlds.IsVisible);
}
else if (strAttributeName  ==  convDGRegionFlds.IsFuncFld)
{
mbolIsFuncFld = TransNullToBool(value.ToString());
 AddUpdatedFld(convDGRegionFlds.IsFuncFld);
}
else if (strAttributeName  ==  convDGRegionFlds.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convDGRegionFlds.InUse);
}
else if (strAttributeName  ==  convDGRegionFlds.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convDGRegionFlds.UpdUser);
}
else if (strAttributeName  ==  convDGRegionFlds.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convDGRegionFlds.UpdDate);
}
else if (strAttributeName  ==  convDGRegionFlds.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convDGRegionFlds.Memo);
}
else if (strAttributeName  ==  convDGRegionFlds.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convDGRegionFlds.PrjId);
}
}
}
public object this[int intIndex]
{
get
{
if (convDGRegionFlds.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (convDGRegionFlds.RegionId  ==  _AttributeName[intIndex])
{
return mstrRegionId;
}
else if (convDGRegionFlds.RegionName  ==  _AttributeName[intIndex])
{
return mstrRegionName;
}
else if (convDGRegionFlds.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (convDGRegionFlds.FldId  ==  _AttributeName[intIndex])
{
return mstrFldId;
}
else if (convDGRegionFlds.FldName  ==  _AttributeName[intIndex])
{
return mstrFldName;
}
else if (convDGRegionFlds.SortExpression  ==  _AttributeName[intIndex])
{
return mstrSortExpression;
}
else if (convDGRegionFlds.SeqNum  ==  _AttributeName[intIndex])
{
return mintSeqNum;
}
else if (convDGRegionFlds.HeaderText  ==  _AttributeName[intIndex])
{
return mstrHeaderText;
}
else if (convDGRegionFlds.ToolTipText  ==  _AttributeName[intIndex])
{
return mstrToolTipText;
}
else if (convDGRegionFlds.CtlTypeId  ==  _AttributeName[intIndex])
{
return mstrCtlTypeId;
}
else if (convDGRegionFlds.CtlTypeName  ==  _AttributeName[intIndex])
{
return mstrCtlTypeName;
}
else if (convDGRegionFlds.CtlCnName  ==  _AttributeName[intIndex])
{
return mstrCtlCnName;
}
else if (convDGRegionFlds.DgFuncTypeId  ==  _AttributeName[intIndex])
{
return mstrDgFuncTypeId;
}
else if (convDGRegionFlds.DgFuncTypeName  ==  _AttributeName[intIndex])
{
return mstrDgFuncTypeName;
}
else if (convDGRegionFlds.IsNeedSort  ==  _AttributeName[intIndex])
{
return mbolIsNeedSort;
}
else if (convDGRegionFlds.IsDefaultSort  ==  _AttributeName[intIndex])
{
return mbolIsDefaultSort;
}
else if (convDGRegionFlds.IsTransToChkBox  ==  _AttributeName[intIndex])
{
return mbolIsTransToChkBox;
}
else if (convDGRegionFlds.IsVisible  ==  _AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (convDGRegionFlds.IsFuncFld  ==  _AttributeName[intIndex])
{
return mbolIsFuncFld;
}
else if (convDGRegionFlds.InUse  ==  _AttributeName[intIndex])
{
return mbolInUse;
}
else if (convDGRegionFlds.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convDGRegionFlds.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convDGRegionFlds.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (convDGRegionFlds.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
return null;
}
set
{
if (convDGRegionFlds.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convDGRegionFlds.mId);
}
else if (convDGRegionFlds.RegionId  ==  _AttributeName[intIndex])
{
mstrRegionId = value.ToString();
 AddUpdatedFld(convDGRegionFlds.RegionId);
}
else if (convDGRegionFlds.RegionName  ==  _AttributeName[intIndex])
{
mstrRegionName = value.ToString();
 AddUpdatedFld(convDGRegionFlds.RegionName);
}
else if (convDGRegionFlds.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(convDGRegionFlds.TabId);
}
else if (convDGRegionFlds.FldId  ==  _AttributeName[intIndex])
{
mstrFldId = value.ToString();
 AddUpdatedFld(convDGRegionFlds.FldId);
}
else if (convDGRegionFlds.FldName  ==  _AttributeName[intIndex])
{
mstrFldName = value.ToString();
 AddUpdatedFld(convDGRegionFlds.FldName);
}
else if (convDGRegionFlds.SortExpression  ==  _AttributeName[intIndex])
{
mstrSortExpression = value.ToString();
 AddUpdatedFld(convDGRegionFlds.SortExpression);
}
else if (convDGRegionFlds.SeqNum  ==  _AttributeName[intIndex])
{
mintSeqNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convDGRegionFlds.SeqNum);
}
else if (convDGRegionFlds.HeaderText  ==  _AttributeName[intIndex])
{
mstrHeaderText = value.ToString();
 AddUpdatedFld(convDGRegionFlds.HeaderText);
}
else if (convDGRegionFlds.ToolTipText  ==  _AttributeName[intIndex])
{
mstrToolTipText = value.ToString();
 AddUpdatedFld(convDGRegionFlds.ToolTipText);
}
else if (convDGRegionFlds.CtlTypeId  ==  _AttributeName[intIndex])
{
mstrCtlTypeId = value.ToString();
 AddUpdatedFld(convDGRegionFlds.CtlTypeId);
}
else if (convDGRegionFlds.CtlTypeName  ==  _AttributeName[intIndex])
{
mstrCtlTypeName = value.ToString();
 AddUpdatedFld(convDGRegionFlds.CtlTypeName);
}
else if (convDGRegionFlds.CtlCnName  ==  _AttributeName[intIndex])
{
mstrCtlCnName = value.ToString();
 AddUpdatedFld(convDGRegionFlds.CtlCnName);
}
else if (convDGRegionFlds.DgFuncTypeId  ==  _AttributeName[intIndex])
{
mstrDgFuncTypeId = value.ToString();
 AddUpdatedFld(convDGRegionFlds.DgFuncTypeId);
}
else if (convDGRegionFlds.DgFuncTypeName  ==  _AttributeName[intIndex])
{
mstrDgFuncTypeName = value.ToString();
 AddUpdatedFld(convDGRegionFlds.DgFuncTypeName);
}
else if (convDGRegionFlds.IsNeedSort  ==  _AttributeName[intIndex])
{
mbolIsNeedSort = TransNullToBool(value.ToString());
 AddUpdatedFld(convDGRegionFlds.IsNeedSort);
}
else if (convDGRegionFlds.IsDefaultSort  ==  _AttributeName[intIndex])
{
mbolIsDefaultSort = TransNullToBool(value.ToString());
 AddUpdatedFld(convDGRegionFlds.IsDefaultSort);
}
else if (convDGRegionFlds.IsTransToChkBox  ==  _AttributeName[intIndex])
{
mbolIsTransToChkBox = TransNullToBool(value.ToString());
 AddUpdatedFld(convDGRegionFlds.IsTransToChkBox);
}
else if (convDGRegionFlds.IsVisible  ==  _AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convDGRegionFlds.IsVisible);
}
else if (convDGRegionFlds.IsFuncFld  ==  _AttributeName[intIndex])
{
mbolIsFuncFld = TransNullToBool(value.ToString());
 AddUpdatedFld(convDGRegionFlds.IsFuncFld);
}
else if (convDGRegionFlds.InUse  ==  _AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convDGRegionFlds.InUse);
}
else if (convDGRegionFlds.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convDGRegionFlds.UpdUser);
}
else if (convDGRegionFlds.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convDGRegionFlds.UpdDate);
}
else if (convDGRegionFlds.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convDGRegionFlds.Memo);
}
else if (convDGRegionFlds.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convDGRegionFlds.PrjId);
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
 AddUpdatedFld(convDGRegionFlds.mId);
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
 AddUpdatedFld(convDGRegionFlds.RegionId);
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
 AddUpdatedFld(convDGRegionFlds.RegionName);
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
 AddUpdatedFld(convDGRegionFlds.TabId);
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
 AddUpdatedFld(convDGRegionFlds.FldId);
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
 AddUpdatedFld(convDGRegionFlds.FldName);
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
 AddUpdatedFld(convDGRegionFlds.SortExpression);
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
 AddUpdatedFld(convDGRegionFlds.SeqNum);
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
 AddUpdatedFld(convDGRegionFlds.HeaderText);
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
 AddUpdatedFld(convDGRegionFlds.ToolTipText);
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
 AddUpdatedFld(convDGRegionFlds.CtlTypeId);
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
 AddUpdatedFld(convDGRegionFlds.CtlTypeName);
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
 AddUpdatedFld(convDGRegionFlds.CtlCnName);
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
 AddUpdatedFld(convDGRegionFlds.DgFuncTypeId);
}
}
/// <summary>
/// Dg功能类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DgFuncTypeName
{
get
{
return mstrDgFuncTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDgFuncTypeName = value;
}
else
{
 mstrDgFuncTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convDGRegionFlds.DgFuncTypeName);
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
 AddUpdatedFld(convDGRegionFlds.IsNeedSort);
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
 AddUpdatedFld(convDGRegionFlds.IsDefaultSort);
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
 AddUpdatedFld(convDGRegionFlds.IsTransToChkBox);
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
 AddUpdatedFld(convDGRegionFlds.IsVisible);
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
 AddUpdatedFld(convDGRegionFlds.IsFuncFld);
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
 AddUpdatedFld(convDGRegionFlds.InUse);
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
 AddUpdatedFld(convDGRegionFlds.UpdUser);
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
 AddUpdatedFld(convDGRegionFlds.UpdDate);
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
 AddUpdatedFld(convDGRegionFlds.Memo);
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
 AddUpdatedFld(convDGRegionFlds.PrjId);
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
 /// vDG区域字段(vDGRegionFlds)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convDGRegionFlds
{
public const string _CurrTabName = "vDGRegionFlds"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "RegionId", "RegionName", "TabId", "FldId", "FldName", "SortExpression", "SeqNum", "HeaderText", "ToolTipText", "CtlTypeId", "CtlTypeName", "CtlCnName", "DgFuncTypeId", "DgFuncTypeName", "IsNeedSort", "IsDefaultSort", "IsTransToChkBox", "IsVisible", "IsFuncFld", "InUse", "UpdUser", "UpdDate", "Memo", "PrjId"};
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
 /// 常量:"DgFuncTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DgFuncTypeId = "DgFuncTypeId";    //Dg功能类型Id

 /// <summary>
 /// 常量:"DgFuncTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DgFuncTypeName = "DgFuncTypeName";    //Dg功能类型名

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