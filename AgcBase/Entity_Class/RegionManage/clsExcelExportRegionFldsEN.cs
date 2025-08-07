
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsExcelExportRegionFldsEN
 表名:ExcelExportRegionFlds(00050149)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:26:55
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
 /// 表ExcelExportRegionFlds的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_ExcelExportRegionFlds
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
public K_mId_ExcelExportRegionFlds(long lngmId)
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
 /// <returns>返回:[K_mId_ExcelExportRegionFlds]类型的对象</returns>
public static implicit operator K_mId_ExcelExportRegionFlds(long value)
{
return new K_mId_ExcelExportRegionFlds(value);
}
}
 /// <summary>
 /// Excel导出区域字段(ExcelExportRegionFlds)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsExcelExportRegionFldsEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ExcelExportRegionFlds"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 14;
public static string[] _AttributeName = new string[] {"mId", "RegionId", "FldId", "OutFldId", "SeqNum", "ColCaption", "InUse", "ErrMsg", "PrjId", "UpdDate", "UpdUser", "Memo", "IsDefaultSort", "IsNeedSort"};

protected long mlngmId;    //mId
protected string mstrRegionId;    //区域Id
protected string mstrFldId;    //字段Id
protected string mstrOutFldId;    //OutFldId
protected int mintSeqNum;    //字段序号
protected string mstrColCaption;    //列标题
protected bool mbolInUse;    //是否在用
protected string mstrErrMsg;    //错误信息
protected string mstrPrjId;    //工程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明
protected bool mbolIsDefaultSort;    //是否默认排序
protected bool mbolIsNeedSort;    //是否需要排序

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsExcelExportRegionFldsEN()
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
public clsExcelExportRegionFldsEN(long lngmId)
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
if (strAttributeName  ==  conExcelExportRegionFlds.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conExcelExportRegionFlds.RegionId)
{
return mstrRegionId;
}
else if (strAttributeName  ==  conExcelExportRegionFlds.FldId)
{
return mstrFldId;
}
else if (strAttributeName  ==  conExcelExportRegionFlds.OutFldId)
{
return mstrOutFldId;
}
else if (strAttributeName  ==  conExcelExportRegionFlds.SeqNum)
{
return mintSeqNum;
}
else if (strAttributeName  ==  conExcelExportRegionFlds.ColCaption)
{
return mstrColCaption;
}
else if (strAttributeName  ==  conExcelExportRegionFlds.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  conExcelExportRegionFlds.ErrMsg)
{
return mstrErrMsg;
}
else if (strAttributeName  ==  conExcelExportRegionFlds.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conExcelExportRegionFlds.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conExcelExportRegionFlds.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conExcelExportRegionFlds.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conExcelExportRegionFlds.IsDefaultSort)
{
return mbolIsDefaultSort;
}
else if (strAttributeName  ==  conExcelExportRegionFlds.IsNeedSort)
{
return mbolIsNeedSort;
}
return null;
}
set
{
if (strAttributeName  ==  conExcelExportRegionFlds.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conExcelExportRegionFlds.mId);
}
else if (strAttributeName  ==  conExcelExportRegionFlds.RegionId)
{
mstrRegionId = value.ToString();
 AddUpdatedFld(conExcelExportRegionFlds.RegionId);
}
else if (strAttributeName  ==  conExcelExportRegionFlds.FldId)
{
mstrFldId = value.ToString();
 AddUpdatedFld(conExcelExportRegionFlds.FldId);
}
else if (strAttributeName  ==  conExcelExportRegionFlds.OutFldId)
{
mstrOutFldId = value.ToString();
 AddUpdatedFld(conExcelExportRegionFlds.OutFldId);
}
else if (strAttributeName  ==  conExcelExportRegionFlds.SeqNum)
{
mintSeqNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conExcelExportRegionFlds.SeqNum);
}
else if (strAttributeName  ==  conExcelExportRegionFlds.ColCaption)
{
mstrColCaption = value.ToString();
 AddUpdatedFld(conExcelExportRegionFlds.ColCaption);
}
else if (strAttributeName  ==  conExcelExportRegionFlds.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conExcelExportRegionFlds.InUse);
}
else if (strAttributeName  ==  conExcelExportRegionFlds.ErrMsg)
{
mstrErrMsg = value.ToString();
 AddUpdatedFld(conExcelExportRegionFlds.ErrMsg);
}
else if (strAttributeName  ==  conExcelExportRegionFlds.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conExcelExportRegionFlds.PrjId);
}
else if (strAttributeName  ==  conExcelExportRegionFlds.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conExcelExportRegionFlds.UpdDate);
}
else if (strAttributeName  ==  conExcelExportRegionFlds.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conExcelExportRegionFlds.UpdUser);
}
else if (strAttributeName  ==  conExcelExportRegionFlds.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conExcelExportRegionFlds.Memo);
}
else if (strAttributeName  ==  conExcelExportRegionFlds.IsDefaultSort)
{
mbolIsDefaultSort = TransNullToBool(value.ToString());
 AddUpdatedFld(conExcelExportRegionFlds.IsDefaultSort);
}
else if (strAttributeName  ==  conExcelExportRegionFlds.IsNeedSort)
{
mbolIsNeedSort = TransNullToBool(value.ToString());
 AddUpdatedFld(conExcelExportRegionFlds.IsNeedSort);
}
}
}
public object this[int intIndex]
{
get
{
if (conExcelExportRegionFlds.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (conExcelExportRegionFlds.RegionId  ==  _AttributeName[intIndex])
{
return mstrRegionId;
}
else if (conExcelExportRegionFlds.FldId  ==  _AttributeName[intIndex])
{
return mstrFldId;
}
else if (conExcelExportRegionFlds.OutFldId  ==  _AttributeName[intIndex])
{
return mstrOutFldId;
}
else if (conExcelExportRegionFlds.SeqNum  ==  _AttributeName[intIndex])
{
return mintSeqNum;
}
else if (conExcelExportRegionFlds.ColCaption  ==  _AttributeName[intIndex])
{
return mstrColCaption;
}
else if (conExcelExportRegionFlds.InUse  ==  _AttributeName[intIndex])
{
return mbolInUse;
}
else if (conExcelExportRegionFlds.ErrMsg  ==  _AttributeName[intIndex])
{
return mstrErrMsg;
}
else if (conExcelExportRegionFlds.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conExcelExportRegionFlds.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conExcelExportRegionFlds.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conExcelExportRegionFlds.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (conExcelExportRegionFlds.IsDefaultSort  ==  _AttributeName[intIndex])
{
return mbolIsDefaultSort;
}
else if (conExcelExportRegionFlds.IsNeedSort  ==  _AttributeName[intIndex])
{
return mbolIsNeedSort;
}
return null;
}
set
{
if (conExcelExportRegionFlds.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conExcelExportRegionFlds.mId);
}
else if (conExcelExportRegionFlds.RegionId  ==  _AttributeName[intIndex])
{
mstrRegionId = value.ToString();
 AddUpdatedFld(conExcelExportRegionFlds.RegionId);
}
else if (conExcelExportRegionFlds.FldId  ==  _AttributeName[intIndex])
{
mstrFldId = value.ToString();
 AddUpdatedFld(conExcelExportRegionFlds.FldId);
}
else if (conExcelExportRegionFlds.OutFldId  ==  _AttributeName[intIndex])
{
mstrOutFldId = value.ToString();
 AddUpdatedFld(conExcelExportRegionFlds.OutFldId);
}
else if (conExcelExportRegionFlds.SeqNum  ==  _AttributeName[intIndex])
{
mintSeqNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conExcelExportRegionFlds.SeqNum);
}
else if (conExcelExportRegionFlds.ColCaption  ==  _AttributeName[intIndex])
{
mstrColCaption = value.ToString();
 AddUpdatedFld(conExcelExportRegionFlds.ColCaption);
}
else if (conExcelExportRegionFlds.InUse  ==  _AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conExcelExportRegionFlds.InUse);
}
else if (conExcelExportRegionFlds.ErrMsg  ==  _AttributeName[intIndex])
{
mstrErrMsg = value.ToString();
 AddUpdatedFld(conExcelExportRegionFlds.ErrMsg);
}
else if (conExcelExportRegionFlds.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conExcelExportRegionFlds.PrjId);
}
else if (conExcelExportRegionFlds.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conExcelExportRegionFlds.UpdDate);
}
else if (conExcelExportRegionFlds.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conExcelExportRegionFlds.UpdUser);
}
else if (conExcelExportRegionFlds.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conExcelExportRegionFlds.Memo);
}
else if (conExcelExportRegionFlds.IsDefaultSort  ==  _AttributeName[intIndex])
{
mbolIsDefaultSort = TransNullToBool(value.ToString());
 AddUpdatedFld(conExcelExportRegionFlds.IsDefaultSort);
}
else if (conExcelExportRegionFlds.IsNeedSort  ==  _AttributeName[intIndex])
{
mbolIsNeedSort = TransNullToBool(value.ToString());
 AddUpdatedFld(conExcelExportRegionFlds.IsNeedSort);
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
 AddUpdatedFld(conExcelExportRegionFlds.mId);
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
 AddUpdatedFld(conExcelExportRegionFlds.RegionId);
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
 AddUpdatedFld(conExcelExportRegionFlds.FldId);
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
 AddUpdatedFld(conExcelExportRegionFlds.OutFldId);
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
 AddUpdatedFld(conExcelExportRegionFlds.SeqNum);
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
 AddUpdatedFld(conExcelExportRegionFlds.ColCaption);
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
 AddUpdatedFld(conExcelExportRegionFlds.InUse);
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
 AddUpdatedFld(conExcelExportRegionFlds.ErrMsg);
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
 AddUpdatedFld(conExcelExportRegionFlds.PrjId);
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
 AddUpdatedFld(conExcelExportRegionFlds.UpdDate);
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
 AddUpdatedFld(conExcelExportRegionFlds.UpdUser);
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
 AddUpdatedFld(conExcelExportRegionFlds.Memo);
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
 AddUpdatedFld(conExcelExportRegionFlds.IsDefaultSort);
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
 AddUpdatedFld(conExcelExportRegionFlds.IsNeedSort);
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
 /// Excel导出区域字段(ExcelExportRegionFlds)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conExcelExportRegionFlds
{
public const string _CurrTabName = "ExcelExportRegionFlds"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "RegionId", "FldId", "OutFldId", "SeqNum", "ColCaption", "InUse", "ErrMsg", "PrjId", "UpdDate", "UpdUser", "Memo", "IsDefaultSort", "IsNeedSort"};
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
}

}