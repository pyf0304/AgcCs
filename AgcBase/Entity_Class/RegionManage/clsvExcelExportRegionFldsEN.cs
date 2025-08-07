
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvExcelExportRegionFldsEN
 表名:vExcelExportRegionFlds(00050150)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:48:08
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
 /// 表vExcelExportRegionFlds的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vExcelExportRegionFlds
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
public K_mId_vExcelExportRegionFlds(long lngmId)
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
 /// <returns>返回:[K_mId_vExcelExportRegionFlds]类型的对象</returns>
public static implicit operator K_mId_vExcelExportRegionFlds(long value)
{
return new K_mId_vExcelExportRegionFlds(value);
}
}
 /// <summary>
 /// vExcel导出区域字段(vExcelExportRegionFlds)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvExcelExportRegionFldsEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vExcelExportRegionFlds"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 16;
public static string[] _AttributeName = new string[] {"mId", "RegionId", "RegionName", "TabId", "TabName", "FldId", "FldName", "SeqNum", "ColCaption", "InUse", "UpdDate", "UpdUser", "Memo", "IsDefaultSort", "IsNeedSort", "PrjId"};

protected long mlngmId;    //mId
protected string mstrRegionId;    //区域Id
protected string mstrRegionName;    //区域名称
protected string mstrTabId;    //表ID
protected string mstrTabName;    //表名
protected string mstrFldId;    //字段Id
protected string mstrFldName;    //字段名
protected int mintSeqNum;    //字段序号
protected string mstrColCaption;    //列标题
protected bool mbolInUse;    //是否在用
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明
protected bool mbolIsDefaultSort;    //是否默认排序
protected bool mbolIsNeedSort;    //是否需要排序
protected string mstrPrjId;    //工程Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvExcelExportRegionFldsEN()
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
public clsvExcelExportRegionFldsEN(long lngmId)
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
if (strAttributeName  ==  convExcelExportRegionFlds.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convExcelExportRegionFlds.RegionId)
{
return mstrRegionId;
}
else if (strAttributeName  ==  convExcelExportRegionFlds.RegionName)
{
return mstrRegionName;
}
else if (strAttributeName  ==  convExcelExportRegionFlds.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  convExcelExportRegionFlds.TabName)
{
return mstrTabName;
}
else if (strAttributeName  ==  convExcelExportRegionFlds.FldId)
{
return mstrFldId;
}
else if (strAttributeName  ==  convExcelExportRegionFlds.FldName)
{
return mstrFldName;
}
else if (strAttributeName  ==  convExcelExportRegionFlds.SeqNum)
{
return mintSeqNum;
}
else if (strAttributeName  ==  convExcelExportRegionFlds.ColCaption)
{
return mstrColCaption;
}
else if (strAttributeName  ==  convExcelExportRegionFlds.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  convExcelExportRegionFlds.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convExcelExportRegionFlds.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convExcelExportRegionFlds.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convExcelExportRegionFlds.IsDefaultSort)
{
return mbolIsDefaultSort;
}
else if (strAttributeName  ==  convExcelExportRegionFlds.IsNeedSort)
{
return mbolIsNeedSort;
}
else if (strAttributeName  ==  convExcelExportRegionFlds.PrjId)
{
return mstrPrjId;
}
return null;
}
set
{
if (strAttributeName  ==  convExcelExportRegionFlds.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convExcelExportRegionFlds.mId);
}
else if (strAttributeName  ==  convExcelExportRegionFlds.RegionId)
{
mstrRegionId = value.ToString();
 AddUpdatedFld(convExcelExportRegionFlds.RegionId);
}
else if (strAttributeName  ==  convExcelExportRegionFlds.RegionName)
{
mstrRegionName = value.ToString();
 AddUpdatedFld(convExcelExportRegionFlds.RegionName);
}
else if (strAttributeName  ==  convExcelExportRegionFlds.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(convExcelExportRegionFlds.TabId);
}
else if (strAttributeName  ==  convExcelExportRegionFlds.TabName)
{
mstrTabName = value.ToString();
 AddUpdatedFld(convExcelExportRegionFlds.TabName);
}
else if (strAttributeName  ==  convExcelExportRegionFlds.FldId)
{
mstrFldId = value.ToString();
 AddUpdatedFld(convExcelExportRegionFlds.FldId);
}
else if (strAttributeName  ==  convExcelExportRegionFlds.FldName)
{
mstrFldName = value.ToString();
 AddUpdatedFld(convExcelExportRegionFlds.FldName);
}
else if (strAttributeName  ==  convExcelExportRegionFlds.SeqNum)
{
mintSeqNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convExcelExportRegionFlds.SeqNum);
}
else if (strAttributeName  ==  convExcelExportRegionFlds.ColCaption)
{
mstrColCaption = value.ToString();
 AddUpdatedFld(convExcelExportRegionFlds.ColCaption);
}
else if (strAttributeName  ==  convExcelExportRegionFlds.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convExcelExportRegionFlds.InUse);
}
else if (strAttributeName  ==  convExcelExportRegionFlds.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convExcelExportRegionFlds.UpdDate);
}
else if (strAttributeName  ==  convExcelExportRegionFlds.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convExcelExportRegionFlds.UpdUser);
}
else if (strAttributeName  ==  convExcelExportRegionFlds.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convExcelExportRegionFlds.Memo);
}
else if (strAttributeName  ==  convExcelExportRegionFlds.IsDefaultSort)
{
mbolIsDefaultSort = TransNullToBool(value.ToString());
 AddUpdatedFld(convExcelExportRegionFlds.IsDefaultSort);
}
else if (strAttributeName  ==  convExcelExportRegionFlds.IsNeedSort)
{
mbolIsNeedSort = TransNullToBool(value.ToString());
 AddUpdatedFld(convExcelExportRegionFlds.IsNeedSort);
}
else if (strAttributeName  ==  convExcelExportRegionFlds.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convExcelExportRegionFlds.PrjId);
}
}
}
public object this[int intIndex]
{
get
{
if (convExcelExportRegionFlds.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (convExcelExportRegionFlds.RegionId  ==  _AttributeName[intIndex])
{
return mstrRegionId;
}
else if (convExcelExportRegionFlds.RegionName  ==  _AttributeName[intIndex])
{
return mstrRegionName;
}
else if (convExcelExportRegionFlds.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (convExcelExportRegionFlds.TabName  ==  _AttributeName[intIndex])
{
return mstrTabName;
}
else if (convExcelExportRegionFlds.FldId  ==  _AttributeName[intIndex])
{
return mstrFldId;
}
else if (convExcelExportRegionFlds.FldName  ==  _AttributeName[intIndex])
{
return mstrFldName;
}
else if (convExcelExportRegionFlds.SeqNum  ==  _AttributeName[intIndex])
{
return mintSeqNum;
}
else if (convExcelExportRegionFlds.ColCaption  ==  _AttributeName[intIndex])
{
return mstrColCaption;
}
else if (convExcelExportRegionFlds.InUse  ==  _AttributeName[intIndex])
{
return mbolInUse;
}
else if (convExcelExportRegionFlds.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convExcelExportRegionFlds.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convExcelExportRegionFlds.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (convExcelExportRegionFlds.IsDefaultSort  ==  _AttributeName[intIndex])
{
return mbolIsDefaultSort;
}
else if (convExcelExportRegionFlds.IsNeedSort  ==  _AttributeName[intIndex])
{
return mbolIsNeedSort;
}
else if (convExcelExportRegionFlds.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
return null;
}
set
{
if (convExcelExportRegionFlds.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convExcelExportRegionFlds.mId);
}
else if (convExcelExportRegionFlds.RegionId  ==  _AttributeName[intIndex])
{
mstrRegionId = value.ToString();
 AddUpdatedFld(convExcelExportRegionFlds.RegionId);
}
else if (convExcelExportRegionFlds.RegionName  ==  _AttributeName[intIndex])
{
mstrRegionName = value.ToString();
 AddUpdatedFld(convExcelExportRegionFlds.RegionName);
}
else if (convExcelExportRegionFlds.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(convExcelExportRegionFlds.TabId);
}
else if (convExcelExportRegionFlds.TabName  ==  _AttributeName[intIndex])
{
mstrTabName = value.ToString();
 AddUpdatedFld(convExcelExportRegionFlds.TabName);
}
else if (convExcelExportRegionFlds.FldId  ==  _AttributeName[intIndex])
{
mstrFldId = value.ToString();
 AddUpdatedFld(convExcelExportRegionFlds.FldId);
}
else if (convExcelExportRegionFlds.FldName  ==  _AttributeName[intIndex])
{
mstrFldName = value.ToString();
 AddUpdatedFld(convExcelExportRegionFlds.FldName);
}
else if (convExcelExportRegionFlds.SeqNum  ==  _AttributeName[intIndex])
{
mintSeqNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convExcelExportRegionFlds.SeqNum);
}
else if (convExcelExportRegionFlds.ColCaption  ==  _AttributeName[intIndex])
{
mstrColCaption = value.ToString();
 AddUpdatedFld(convExcelExportRegionFlds.ColCaption);
}
else if (convExcelExportRegionFlds.InUse  ==  _AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convExcelExportRegionFlds.InUse);
}
else if (convExcelExportRegionFlds.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convExcelExportRegionFlds.UpdDate);
}
else if (convExcelExportRegionFlds.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convExcelExportRegionFlds.UpdUser);
}
else if (convExcelExportRegionFlds.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convExcelExportRegionFlds.Memo);
}
else if (convExcelExportRegionFlds.IsDefaultSort  ==  _AttributeName[intIndex])
{
mbolIsDefaultSort = TransNullToBool(value.ToString());
 AddUpdatedFld(convExcelExportRegionFlds.IsDefaultSort);
}
else if (convExcelExportRegionFlds.IsNeedSort  ==  _AttributeName[intIndex])
{
mbolIsNeedSort = TransNullToBool(value.ToString());
 AddUpdatedFld(convExcelExportRegionFlds.IsNeedSort);
}
else if (convExcelExportRegionFlds.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convExcelExportRegionFlds.PrjId);
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
 AddUpdatedFld(convExcelExportRegionFlds.mId);
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
 AddUpdatedFld(convExcelExportRegionFlds.RegionId);
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
 AddUpdatedFld(convExcelExportRegionFlds.RegionName);
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
 AddUpdatedFld(convExcelExportRegionFlds.TabId);
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
 AddUpdatedFld(convExcelExportRegionFlds.TabName);
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
 AddUpdatedFld(convExcelExportRegionFlds.FldId);
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
 AddUpdatedFld(convExcelExportRegionFlds.FldName);
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
 AddUpdatedFld(convExcelExportRegionFlds.SeqNum);
}
}
/// <summary>
/// 列标题(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ColCaption
{
get
{
return mstrColCaption;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrColCaption = value;
}
else
{
 mstrColCaption = value;
}
//记录修改过的字段
 AddUpdatedFld(convExcelExportRegionFlds.ColCaption);
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
 AddUpdatedFld(convExcelExportRegionFlds.InUse);
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
 AddUpdatedFld(convExcelExportRegionFlds.UpdDate);
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
 AddUpdatedFld(convExcelExportRegionFlds.UpdUser);
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
 AddUpdatedFld(convExcelExportRegionFlds.Memo);
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
 AddUpdatedFld(convExcelExportRegionFlds.IsDefaultSort);
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
 AddUpdatedFld(convExcelExportRegionFlds.IsNeedSort);
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
 AddUpdatedFld(convExcelExportRegionFlds.PrjId);
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
 /// vExcel导出区域字段(vExcelExportRegionFlds)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convExcelExportRegionFlds
{
public const string _CurrTabName = "vExcelExportRegionFlds"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "RegionId", "RegionName", "TabId", "TabName", "FldId", "FldName", "SeqNum", "ColCaption", "InUse", "UpdDate", "UpdUser", "Memo", "IsDefaultSort", "IsNeedSort", "PrjId"};
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
 /// 常量:"SeqNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SeqNum = "SeqNum";    //字段序号

 /// <summary>
 /// 常量:"ColCaption"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ColCaption = "ColCaption";    //列标题

 /// <summary>
 /// 常量:"InUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InUse = "InUse";    //是否在用

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改者

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明

 /// <summary>
 /// 常量:"IsDefaultSort"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDefaultSort = "IsDefaultSort";    //是否默认排序

 /// <summary>
 /// 常量:"IsNeedSort"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsNeedSort = "IsNeedSort";    //是否需要排序

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id
}

}