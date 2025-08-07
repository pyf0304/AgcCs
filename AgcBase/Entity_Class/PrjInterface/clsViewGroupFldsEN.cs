
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewGroupFldsEN
 表名:ViewGroupFlds(00050136)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:17:47
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:界面管理(PrjInterface)
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
 /// 表ViewGroupFlds的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_ViewGroupFlds
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
public K_mId_ViewGroupFlds(long lngmId)
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
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_mId_ViewGroupFlds]类型的对象</returns>
public static implicit operator K_mId_ViewGroupFlds(long value)
{
return new K_mId_ViewGroupFlds(value);
}
}
 /// <summary>
 /// 界面组字段集合(ViewGroupFlds)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsViewGroupFldsEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接，如果为空就使用系统默认的连接
public new const string _CurrTabName = "ViewGroupFlds"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string WhereFormat = ""; //条件格式串
protected const int mintAttributeCount = 15;
public static string[] AttributeName = new string[] {"mId", "CtlTypeId", "DdlItemsOptionId", "DsCondStr", "Ds_DataTextFieldId", "DsDataValueFieldId", "DsSqlStr", "DsTabId", "ItemsString", "SeqNum", "TabFldId", "UpdDate", "UserId", "ViewGroupId", "Memo"};

protected long mlngmId;    //mId
protected string mstrCtlTypeId;    //控件类型号
protected string mstrDdlItemsOptionId;    //下拉框列表选项ID
protected string mstrDsCondStr;    //数据源条件串
protected string mstrDs_DataTextFieldId;    //数据源文本字段Id
protected string mstrDsDataValueFieldId;    //数据源值字段Id
protected string mstrDsSqlStr;    //数据源SQL串
protected string mstrDsTabId;    //数据源表ID
protected string mstrItemsString;    //列表项串
protected int? mintSeqNum;    //字段序号
protected long mlngTabFldId;    //表字段ID
protected string mstrUpdDate;    //修改日期
protected string mstrUserId;    //用户Id
protected string mstrViewGroupId;    //界面组ID
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsViewGroupFldsEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "ViewGroupFlds";
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:mId</param>
public clsViewGroupFldsEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "ViewGroupFlds";
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
if (strAttributeName  ==  conViewGroupFlds.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conViewGroupFlds.CtlTypeId)
{
return mstrCtlTypeId;
}
else if (strAttributeName  ==  conViewGroupFlds.DdlItemsOptionId)
{
return mstrDdlItemsOptionId;
}
else if (strAttributeName  ==  conViewGroupFlds.DsCondStr)
{
return mstrDsCondStr;
}
else if (strAttributeName  ==  conViewGroupFlds.Ds_DataTextFieldId)
{
return mstrDs_DataTextFieldId;
}
else if (strAttributeName  ==  conViewGroupFlds.DsDataValueFieldId)
{
return mstrDsDataValueFieldId;
}
else if (strAttributeName  ==  conViewGroupFlds.DsSqlStr)
{
return mstrDsSqlStr;
}
else if (strAttributeName  ==  conViewGroupFlds.DsTabId)
{
return mstrDsTabId;
}
else if (strAttributeName  ==  conViewGroupFlds.ItemsString)
{
return mstrItemsString;
}
else if (strAttributeName  ==  conViewGroupFlds.SeqNum)
{
return mintSeqNum;
}
else if (strAttributeName  ==  conViewGroupFlds.TabFldId)
{
return mlngTabFldId;
}
else if (strAttributeName  ==  conViewGroupFlds.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conViewGroupFlds.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conViewGroupFlds.ViewGroupId)
{
return mstrViewGroupId;
}
else if (strAttributeName  ==  conViewGroupFlds.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conViewGroupFlds.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewGroupFlds.mId);
}
else if (strAttributeName  ==  conViewGroupFlds.CtlTypeId)
{
mstrCtlTypeId = value.ToString();
 AddUpdatedFld(conViewGroupFlds.CtlTypeId);
}
else if (strAttributeName  ==  conViewGroupFlds.DdlItemsOptionId)
{
mstrDdlItemsOptionId = value.ToString();
 AddUpdatedFld(conViewGroupFlds.DdlItemsOptionId);
}
else if (strAttributeName  ==  conViewGroupFlds.DsCondStr)
{
mstrDsCondStr = value.ToString();
 AddUpdatedFld(conViewGroupFlds.DsCondStr);
}
else if (strAttributeName  ==  conViewGroupFlds.Ds_DataTextFieldId)
{
mstrDs_DataTextFieldId = value.ToString();
 AddUpdatedFld(conViewGroupFlds.Ds_DataTextFieldId);
}
else if (strAttributeName  ==  conViewGroupFlds.DsDataValueFieldId)
{
mstrDsDataValueFieldId = value.ToString();
 AddUpdatedFld(conViewGroupFlds.DsDataValueFieldId);
}
else if (strAttributeName  ==  conViewGroupFlds.DsSqlStr)
{
mstrDsSqlStr = value.ToString();
 AddUpdatedFld(conViewGroupFlds.DsSqlStr);
}
else if (strAttributeName  ==  conViewGroupFlds.DsTabId)
{
mstrDsTabId = value.ToString();
 AddUpdatedFld(conViewGroupFlds.DsTabId);
}
else if (strAttributeName  ==  conViewGroupFlds.ItemsString)
{
mstrItemsString = value.ToString();
 AddUpdatedFld(conViewGroupFlds.ItemsString);
}
else if (strAttributeName  ==  conViewGroupFlds.SeqNum)
{
mintSeqNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewGroupFlds.SeqNum);
}
else if (strAttributeName  ==  conViewGroupFlds.TabFldId)
{
mlngTabFldId = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewGroupFlds.TabFldId);
}
else if (strAttributeName  ==  conViewGroupFlds.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conViewGroupFlds.UpdDate);
}
else if (strAttributeName  ==  conViewGroupFlds.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conViewGroupFlds.UserId);
}
else if (strAttributeName  ==  conViewGroupFlds.ViewGroupId)
{
mstrViewGroupId = value.ToString();
 AddUpdatedFld(conViewGroupFlds.ViewGroupId);
}
else if (strAttributeName  ==  conViewGroupFlds.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conViewGroupFlds.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conViewGroupFlds.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conViewGroupFlds.CtlTypeId  ==  AttributeName[intIndex])
{
return mstrCtlTypeId;
}
else if (conViewGroupFlds.DdlItemsOptionId  ==  AttributeName[intIndex])
{
return mstrDdlItemsOptionId;
}
else if (conViewGroupFlds.DsCondStr  ==  AttributeName[intIndex])
{
return mstrDsCondStr;
}
else if (conViewGroupFlds.Ds_DataTextFieldId  ==  AttributeName[intIndex])
{
return mstrDs_DataTextFieldId;
}
else if (conViewGroupFlds.DsDataValueFieldId  ==  AttributeName[intIndex])
{
return mstrDsDataValueFieldId;
}
else if (conViewGroupFlds.DsSqlStr  ==  AttributeName[intIndex])
{
return mstrDsSqlStr;
}
else if (conViewGroupFlds.DsTabId  ==  AttributeName[intIndex])
{
return mstrDsTabId;
}
else if (conViewGroupFlds.ItemsString  ==  AttributeName[intIndex])
{
return mstrItemsString;
}
else if (conViewGroupFlds.SeqNum  ==  AttributeName[intIndex])
{
return mintSeqNum;
}
else if (conViewGroupFlds.TabFldId  ==  AttributeName[intIndex])
{
return mlngTabFldId;
}
else if (conViewGroupFlds.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conViewGroupFlds.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conViewGroupFlds.ViewGroupId  ==  AttributeName[intIndex])
{
return mstrViewGroupId;
}
else if (conViewGroupFlds.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conViewGroupFlds.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewGroupFlds.mId);
}
else if (conViewGroupFlds.CtlTypeId  ==  AttributeName[intIndex])
{
mstrCtlTypeId = value.ToString();
 AddUpdatedFld(conViewGroupFlds.CtlTypeId);
}
else if (conViewGroupFlds.DdlItemsOptionId  ==  AttributeName[intIndex])
{
mstrDdlItemsOptionId = value.ToString();
 AddUpdatedFld(conViewGroupFlds.DdlItemsOptionId);
}
else if (conViewGroupFlds.DsCondStr  ==  AttributeName[intIndex])
{
mstrDsCondStr = value.ToString();
 AddUpdatedFld(conViewGroupFlds.DsCondStr);
}
else if (conViewGroupFlds.Ds_DataTextFieldId  ==  AttributeName[intIndex])
{
mstrDs_DataTextFieldId = value.ToString();
 AddUpdatedFld(conViewGroupFlds.Ds_DataTextFieldId);
}
else if (conViewGroupFlds.DsDataValueFieldId  ==  AttributeName[intIndex])
{
mstrDsDataValueFieldId = value.ToString();
 AddUpdatedFld(conViewGroupFlds.DsDataValueFieldId);
}
else if (conViewGroupFlds.DsSqlStr  ==  AttributeName[intIndex])
{
mstrDsSqlStr = value.ToString();
 AddUpdatedFld(conViewGroupFlds.DsSqlStr);
}
else if (conViewGroupFlds.DsTabId  ==  AttributeName[intIndex])
{
mstrDsTabId = value.ToString();
 AddUpdatedFld(conViewGroupFlds.DsTabId);
}
else if (conViewGroupFlds.ItemsString  ==  AttributeName[intIndex])
{
mstrItemsString = value.ToString();
 AddUpdatedFld(conViewGroupFlds.ItemsString);
}
else if (conViewGroupFlds.SeqNum  ==  AttributeName[intIndex])
{
mintSeqNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewGroupFlds.SeqNum);
}
else if (conViewGroupFlds.TabFldId  ==  AttributeName[intIndex])
{
mlngTabFldId = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewGroupFlds.TabFldId);
}
else if (conViewGroupFlds.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conViewGroupFlds.UpdDate);
}
else if (conViewGroupFlds.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conViewGroupFlds.UserId);
}
else if (conViewGroupFlds.ViewGroupId  ==  AttributeName[intIndex])
{
mstrViewGroupId = value.ToString();
 AddUpdatedFld(conViewGroupFlds.ViewGroupId);
}
else if (conViewGroupFlds.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conViewGroupFlds.Memo);
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
 AddUpdatedFld(conViewGroupFlds.mId);
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
 AddUpdatedFld(conViewGroupFlds.CtlTypeId);
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
 AddUpdatedFld(conViewGroupFlds.DdlItemsOptionId);
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
 AddUpdatedFld(conViewGroupFlds.DsCondStr);
}
}
/// <summary>
/// 数据源文本字段Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Ds_DataTextFieldId
{
get
{
return mstrDs_DataTextFieldId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDs_DataTextFieldId = value;
}
else
{
 mstrDs_DataTextFieldId = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewGroupFlds.Ds_DataTextFieldId);
}
}
/// <summary>
/// 数据源值字段Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DsDataValueFieldId
{
get
{
return mstrDsDataValueFieldId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDsDataValueFieldId = value;
}
else
{
 mstrDsDataValueFieldId = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewGroupFlds.DsDataValueFieldId);
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
 AddUpdatedFld(conViewGroupFlds.DsSqlStr);
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
 AddUpdatedFld(conViewGroupFlds.DsTabId);
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
 AddUpdatedFld(conViewGroupFlds.ItemsString);
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
 AddUpdatedFld(conViewGroupFlds.SeqNum);
}
}
/// <summary>
/// 表字段ID(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long TabFldId
{
get
{
return mlngTabFldId;
}
set
{
 mlngTabFldId = value;
//记录修改过的字段
 AddUpdatedFld(conViewGroupFlds.TabFldId);
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
 AddUpdatedFld(conViewGroupFlds.UpdDate);
}
}
/// <summary>
/// 用户Id(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserId
{
get
{
return mstrUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserId = value;
}
else
{
 mstrUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewGroupFlds.UserId);
}
}
/// <summary>
/// 界面组ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewGroupId
{
get
{
return mstrViewGroupId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewGroupId = value;
}
else
{
 mstrViewGroupId = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewGroupFlds.ViewGroupId);
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
 AddUpdatedFld(conViewGroupFlds.Memo);
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
 /// 界面组字段集合(ViewGroupFlds)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conViewGroupFlds
{
public new const string _CurrTabName = "ViewGroupFlds"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "CtlTypeId", "DdlItemsOptionId", "DsCondStr", "Ds_DataTextFieldId", "DsDataValueFieldId", "DsSqlStr", "DsTabId", "ItemsString", "SeqNum", "TabFldId", "UpdDate", "UserId", "ViewGroupId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"CtlTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CtlTypeId = "CtlTypeId";    //控件类型号

 /// <summary>
 /// 常量:"DdlItemsOptionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DdlItemsOptionId = "DdlItemsOptionId";    //下拉框列表选项ID

 /// <summary>
 /// 常量:"DsCondStr"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DsCondStr = "DsCondStr";    //数据源条件串

 /// <summary>
 /// 常量:"Ds_DataTextFieldId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Ds_DataTextFieldId = "Ds_DataTextFieldId";    //数据源文本字段Id

 /// <summary>
 /// 常量:"DsDataValueFieldId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DsDataValueFieldId = "DsDataValueFieldId";    //数据源值字段Id

 /// <summary>
 /// 常量:"DsSqlStr"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DsSqlStr = "DsSqlStr";    //数据源SQL串

 /// <summary>
 /// 常量:"DsTabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DsTabId = "DsTabId";    //数据源表ID

 /// <summary>
 /// 常量:"ItemsString"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ItemsString = "ItemsString";    //列表项串

 /// <summary>
 /// 常量:"SeqNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SeqNum = "SeqNum";    //字段序号

 /// <summary>
 /// 常量:"TabFldId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabFldId = "TabFldId";    //表字段ID

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户Id

 /// <summary>
 /// 常量:"ViewGroupId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewGroupId = "ViewGroupId";    //界面组ID

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}