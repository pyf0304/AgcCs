
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjTabFldEN
 表名:PrjTabFld(00050019)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:26:49
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
 /// 表PrjTabFld的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_PrjTabFld
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
public K_mId_PrjTabFld(long lngmId)
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
 /// <returns>返回:[K_mId_PrjTabFld]类型的对象</returns>
public static implicit operator K_mId_PrjTabFld(long value)
{
return new K_mId_PrjTabFld(value);
}
}
 /// <summary>
 /// 工程表字段(PrjTabFld)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsPrjTabFldEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "PrjTabFld"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 27;
public static string[] _AttributeName = new string[] {"mId", "TabId", "FldId", "PrjId", "FieldTypeId", "IsTabNullable", "IsTabUnique", "IsTabForeignKey", "IsSortFld", "IsGeneProp", "IsForExtendClass", "CtlTypeIdDu", "FldDispUnitStyleId", "InFldId", "DnPathId", "KeyId4Test", "DisplayFormat", "IsParentObj", "PrimaryTypeId", "ForeignKeyTabId", "FldOpTypeId", "SequenceNumber", "MemoInTab", "ErrMsg", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrTabId;    //表ID
protected string mstrFldId;    //字段Id
protected string mstrPrjId;    //工程Id
protected string mstrFieldTypeId;    //字段类型Id
protected bool mbolIsTabNullable;    //是否表中可空
protected bool mbolIsTabUnique;    //是否表中唯一
protected bool mbolIsTabForeignKey;    //是否表外键
protected bool mbolIsSortFld;    //是否排序字段
protected bool mbolIsGeneProp;    //是否生成属性
protected bool mbolIsForExtendClass;    //用于扩展类
protected string mstrCtlTypeIdDu;    //控件类型Id_du
protected string mstrFldDispUnitStyleId;    //字段显示单元样式Id
protected string mstrInFldId;    //In字段Id
protected string mstrDnPathId;    //DN路径Id
protected string mstrKeyId4Test;    //测试关键字Id
protected string mstrDisplayFormat;    //显示格式
protected bool mbolIsParentObj;    //是否父对象
protected string mstrPrimaryTypeId;    //主键类型ID
protected string mstrForeignKeyTabId;    //外键表ID
protected string mstrFldOpTypeId;    //字段操作类型Id
protected int? mintSequenceNumber;    //顺序号
protected string mstrMemoInTab;    //表中说明
protected string mstrErrMsg;    //错误信息
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsPrjTabFldEN()
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
public clsPrjTabFldEN(long lngmId)
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
if (strAttributeName  ==  conPrjTabFld.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conPrjTabFld.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  conPrjTabFld.FldId)
{
return mstrFldId;
}
else if (strAttributeName  ==  conPrjTabFld.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conPrjTabFld.FieldTypeId)
{
return mstrFieldTypeId;
}
else if (strAttributeName  ==  conPrjTabFld.IsTabNullable)
{
return mbolIsTabNullable;
}
else if (strAttributeName  ==  conPrjTabFld.IsTabUnique)
{
return mbolIsTabUnique;
}
else if (strAttributeName  ==  conPrjTabFld.IsTabForeignKey)
{
return mbolIsTabForeignKey;
}
else if (strAttributeName  ==  conPrjTabFld.IsSortFld)
{
return mbolIsSortFld;
}
else if (strAttributeName  ==  conPrjTabFld.IsGeneProp)
{
return mbolIsGeneProp;
}
else if (strAttributeName  ==  conPrjTabFld.IsForExtendClass)
{
return mbolIsForExtendClass;
}
else if (strAttributeName  ==  conPrjTabFld.CtlTypeIdDu)
{
return mstrCtlTypeIdDu;
}
else if (strAttributeName  ==  conPrjTabFld.FldDispUnitStyleId)
{
return mstrFldDispUnitStyleId;
}
else if (strAttributeName  ==  conPrjTabFld.InFldId)
{
return mstrInFldId;
}
else if (strAttributeName  ==  conPrjTabFld.DnPathId)
{
return mstrDnPathId;
}
else if (strAttributeName  ==  conPrjTabFld.KeyId4Test)
{
return mstrKeyId4Test;
}
else if (strAttributeName  ==  conPrjTabFld.DisplayFormat)
{
return mstrDisplayFormat;
}
else if (strAttributeName  ==  conPrjTabFld.IsParentObj)
{
return mbolIsParentObj;
}
else if (strAttributeName  ==  conPrjTabFld.PrimaryTypeId)
{
return mstrPrimaryTypeId;
}
else if (strAttributeName  ==  conPrjTabFld.ForeignKeyTabId)
{
return mstrForeignKeyTabId;
}
else if (strAttributeName  ==  conPrjTabFld.FldOpTypeId)
{
return mstrFldOpTypeId;
}
else if (strAttributeName  ==  conPrjTabFld.SequenceNumber)
{
return mintSequenceNumber;
}
else if (strAttributeName  ==  conPrjTabFld.MemoInTab)
{
return mstrMemoInTab;
}
else if (strAttributeName  ==  conPrjTabFld.ErrMsg)
{
return mstrErrMsg;
}
else if (strAttributeName  ==  conPrjTabFld.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conPrjTabFld.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conPrjTabFld.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conPrjTabFld.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conPrjTabFld.mId);
}
else if (strAttributeName  ==  conPrjTabFld.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(conPrjTabFld.TabId);
}
else if (strAttributeName  ==  conPrjTabFld.FldId)
{
mstrFldId = value.ToString();
 AddUpdatedFld(conPrjTabFld.FldId);
}
else if (strAttributeName  ==  conPrjTabFld.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conPrjTabFld.PrjId);
}
else if (strAttributeName  ==  conPrjTabFld.FieldTypeId)
{
mstrFieldTypeId = value.ToString();
 AddUpdatedFld(conPrjTabFld.FieldTypeId);
}
else if (strAttributeName  ==  conPrjTabFld.IsTabNullable)
{
mbolIsTabNullable = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjTabFld.IsTabNullable);
}
else if (strAttributeName  ==  conPrjTabFld.IsTabUnique)
{
mbolIsTabUnique = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjTabFld.IsTabUnique);
}
else if (strAttributeName  ==  conPrjTabFld.IsTabForeignKey)
{
mbolIsTabForeignKey = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjTabFld.IsTabForeignKey);
}
else if (strAttributeName  ==  conPrjTabFld.IsSortFld)
{
mbolIsSortFld = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjTabFld.IsSortFld);
}
else if (strAttributeName  ==  conPrjTabFld.IsGeneProp)
{
mbolIsGeneProp = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjTabFld.IsGeneProp);
}
else if (strAttributeName  ==  conPrjTabFld.IsForExtendClass)
{
mbolIsForExtendClass = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjTabFld.IsForExtendClass);
}
else if (strAttributeName  ==  conPrjTabFld.CtlTypeIdDu)
{
mstrCtlTypeIdDu = value.ToString();
 AddUpdatedFld(conPrjTabFld.CtlTypeIdDu);
}
else if (strAttributeName  ==  conPrjTabFld.FldDispUnitStyleId)
{
mstrFldDispUnitStyleId = value.ToString();
 AddUpdatedFld(conPrjTabFld.FldDispUnitStyleId);
}
else if (strAttributeName  ==  conPrjTabFld.InFldId)
{
mstrInFldId = value.ToString();
 AddUpdatedFld(conPrjTabFld.InFldId);
}
else if (strAttributeName  ==  conPrjTabFld.DnPathId)
{
mstrDnPathId = value.ToString();
 AddUpdatedFld(conPrjTabFld.DnPathId);
}
else if (strAttributeName  ==  conPrjTabFld.KeyId4Test)
{
mstrKeyId4Test = value.ToString();
 AddUpdatedFld(conPrjTabFld.KeyId4Test);
}
else if (strAttributeName  ==  conPrjTabFld.DisplayFormat)
{
mstrDisplayFormat = value.ToString();
 AddUpdatedFld(conPrjTabFld.DisplayFormat);
}
else if (strAttributeName  ==  conPrjTabFld.IsParentObj)
{
mbolIsParentObj = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjTabFld.IsParentObj);
}
else if (strAttributeName  ==  conPrjTabFld.PrimaryTypeId)
{
mstrPrimaryTypeId = value.ToString();
 AddUpdatedFld(conPrjTabFld.PrimaryTypeId);
}
else if (strAttributeName  ==  conPrjTabFld.ForeignKeyTabId)
{
mstrForeignKeyTabId = value.ToString();
 AddUpdatedFld(conPrjTabFld.ForeignKeyTabId);
}
else if (strAttributeName  ==  conPrjTabFld.FldOpTypeId)
{
mstrFldOpTypeId = value.ToString();
 AddUpdatedFld(conPrjTabFld.FldOpTypeId);
}
else if (strAttributeName  ==  conPrjTabFld.SequenceNumber)
{
mintSequenceNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(conPrjTabFld.SequenceNumber);
}
else if (strAttributeName  ==  conPrjTabFld.MemoInTab)
{
mstrMemoInTab = value.ToString();
 AddUpdatedFld(conPrjTabFld.MemoInTab);
}
else if (strAttributeName  ==  conPrjTabFld.ErrMsg)
{
mstrErrMsg = value.ToString();
 AddUpdatedFld(conPrjTabFld.ErrMsg);
}
else if (strAttributeName  ==  conPrjTabFld.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conPrjTabFld.UpdDate);
}
else if (strAttributeName  ==  conPrjTabFld.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conPrjTabFld.UpdUser);
}
else if (strAttributeName  ==  conPrjTabFld.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPrjTabFld.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conPrjTabFld.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (conPrjTabFld.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (conPrjTabFld.FldId  ==  _AttributeName[intIndex])
{
return mstrFldId;
}
else if (conPrjTabFld.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conPrjTabFld.FieldTypeId  ==  _AttributeName[intIndex])
{
return mstrFieldTypeId;
}
else if (conPrjTabFld.IsTabNullable  ==  _AttributeName[intIndex])
{
return mbolIsTabNullable;
}
else if (conPrjTabFld.IsTabUnique  ==  _AttributeName[intIndex])
{
return mbolIsTabUnique;
}
else if (conPrjTabFld.IsTabForeignKey  ==  _AttributeName[intIndex])
{
return mbolIsTabForeignKey;
}
else if (conPrjTabFld.IsSortFld  ==  _AttributeName[intIndex])
{
return mbolIsSortFld;
}
else if (conPrjTabFld.IsGeneProp  ==  _AttributeName[intIndex])
{
return mbolIsGeneProp;
}
else if (conPrjTabFld.IsForExtendClass  ==  _AttributeName[intIndex])
{
return mbolIsForExtendClass;
}
else if (conPrjTabFld.CtlTypeIdDu  ==  _AttributeName[intIndex])
{
return mstrCtlTypeIdDu;
}
else if (conPrjTabFld.FldDispUnitStyleId  ==  _AttributeName[intIndex])
{
return mstrFldDispUnitStyleId;
}
else if (conPrjTabFld.InFldId  ==  _AttributeName[intIndex])
{
return mstrInFldId;
}
else if (conPrjTabFld.DnPathId  ==  _AttributeName[intIndex])
{
return mstrDnPathId;
}
else if (conPrjTabFld.KeyId4Test  ==  _AttributeName[intIndex])
{
return mstrKeyId4Test;
}
else if (conPrjTabFld.DisplayFormat  ==  _AttributeName[intIndex])
{
return mstrDisplayFormat;
}
else if (conPrjTabFld.IsParentObj  ==  _AttributeName[intIndex])
{
return mbolIsParentObj;
}
else if (conPrjTabFld.PrimaryTypeId  ==  _AttributeName[intIndex])
{
return mstrPrimaryTypeId;
}
else if (conPrjTabFld.ForeignKeyTabId  ==  _AttributeName[intIndex])
{
return mstrForeignKeyTabId;
}
else if (conPrjTabFld.FldOpTypeId  ==  _AttributeName[intIndex])
{
return mstrFldOpTypeId;
}
else if (conPrjTabFld.SequenceNumber  ==  _AttributeName[intIndex])
{
return mintSequenceNumber;
}
else if (conPrjTabFld.MemoInTab  ==  _AttributeName[intIndex])
{
return mstrMemoInTab;
}
else if (conPrjTabFld.ErrMsg  ==  _AttributeName[intIndex])
{
return mstrErrMsg;
}
else if (conPrjTabFld.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conPrjTabFld.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conPrjTabFld.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conPrjTabFld.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conPrjTabFld.mId);
}
else if (conPrjTabFld.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(conPrjTabFld.TabId);
}
else if (conPrjTabFld.FldId  ==  _AttributeName[intIndex])
{
mstrFldId = value.ToString();
 AddUpdatedFld(conPrjTabFld.FldId);
}
else if (conPrjTabFld.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conPrjTabFld.PrjId);
}
else if (conPrjTabFld.FieldTypeId  ==  _AttributeName[intIndex])
{
mstrFieldTypeId = value.ToString();
 AddUpdatedFld(conPrjTabFld.FieldTypeId);
}
else if (conPrjTabFld.IsTabNullable  ==  _AttributeName[intIndex])
{
mbolIsTabNullable = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjTabFld.IsTabNullable);
}
else if (conPrjTabFld.IsTabUnique  ==  _AttributeName[intIndex])
{
mbolIsTabUnique = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjTabFld.IsTabUnique);
}
else if (conPrjTabFld.IsTabForeignKey  ==  _AttributeName[intIndex])
{
mbolIsTabForeignKey = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjTabFld.IsTabForeignKey);
}
else if (conPrjTabFld.IsSortFld  ==  _AttributeName[intIndex])
{
mbolIsSortFld = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjTabFld.IsSortFld);
}
else if (conPrjTabFld.IsGeneProp  ==  _AttributeName[intIndex])
{
mbolIsGeneProp = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjTabFld.IsGeneProp);
}
else if (conPrjTabFld.IsForExtendClass  ==  _AttributeName[intIndex])
{
mbolIsForExtendClass = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjTabFld.IsForExtendClass);
}
else if (conPrjTabFld.CtlTypeIdDu  ==  _AttributeName[intIndex])
{
mstrCtlTypeIdDu = value.ToString();
 AddUpdatedFld(conPrjTabFld.CtlTypeIdDu);
}
else if (conPrjTabFld.FldDispUnitStyleId  ==  _AttributeName[intIndex])
{
mstrFldDispUnitStyleId = value.ToString();
 AddUpdatedFld(conPrjTabFld.FldDispUnitStyleId);
}
else if (conPrjTabFld.InFldId  ==  _AttributeName[intIndex])
{
mstrInFldId = value.ToString();
 AddUpdatedFld(conPrjTabFld.InFldId);
}
else if (conPrjTabFld.DnPathId  ==  _AttributeName[intIndex])
{
mstrDnPathId = value.ToString();
 AddUpdatedFld(conPrjTabFld.DnPathId);
}
else if (conPrjTabFld.KeyId4Test  ==  _AttributeName[intIndex])
{
mstrKeyId4Test = value.ToString();
 AddUpdatedFld(conPrjTabFld.KeyId4Test);
}
else if (conPrjTabFld.DisplayFormat  ==  _AttributeName[intIndex])
{
mstrDisplayFormat = value.ToString();
 AddUpdatedFld(conPrjTabFld.DisplayFormat);
}
else if (conPrjTabFld.IsParentObj  ==  _AttributeName[intIndex])
{
mbolIsParentObj = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjTabFld.IsParentObj);
}
else if (conPrjTabFld.PrimaryTypeId  ==  _AttributeName[intIndex])
{
mstrPrimaryTypeId = value.ToString();
 AddUpdatedFld(conPrjTabFld.PrimaryTypeId);
}
else if (conPrjTabFld.ForeignKeyTabId  ==  _AttributeName[intIndex])
{
mstrForeignKeyTabId = value.ToString();
 AddUpdatedFld(conPrjTabFld.ForeignKeyTabId);
}
else if (conPrjTabFld.FldOpTypeId  ==  _AttributeName[intIndex])
{
mstrFldOpTypeId = value.ToString();
 AddUpdatedFld(conPrjTabFld.FldOpTypeId);
}
else if (conPrjTabFld.SequenceNumber  ==  _AttributeName[intIndex])
{
mintSequenceNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(conPrjTabFld.SequenceNumber);
}
else if (conPrjTabFld.MemoInTab  ==  _AttributeName[intIndex])
{
mstrMemoInTab = value.ToString();
 AddUpdatedFld(conPrjTabFld.MemoInTab);
}
else if (conPrjTabFld.ErrMsg  ==  _AttributeName[intIndex])
{
mstrErrMsg = value.ToString();
 AddUpdatedFld(conPrjTabFld.ErrMsg);
}
else if (conPrjTabFld.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conPrjTabFld.UpdDate);
}
else if (conPrjTabFld.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conPrjTabFld.UpdUser);
}
else if (conPrjTabFld.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPrjTabFld.Memo);
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
 AddUpdatedFld(conPrjTabFld.mId);
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
 AddUpdatedFld(conPrjTabFld.TabId);
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
 AddUpdatedFld(conPrjTabFld.FldId);
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
 AddUpdatedFld(conPrjTabFld.PrjId);
}
}
/// <summary>
/// 字段类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FieldTypeId
{
get
{
return mstrFieldTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFieldTypeId = value;
}
else
{
 mstrFieldTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjTabFld.FieldTypeId);
}
}
/// <summary>
/// 是否表中可空(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsTabNullable
{
get
{
return mbolIsTabNullable;
}
set
{
 mbolIsTabNullable = value;
//记录修改过的字段
 AddUpdatedFld(conPrjTabFld.IsTabNullable);
}
}
/// <summary>
/// 是否表中唯一(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsTabUnique
{
get
{
return mbolIsTabUnique;
}
set
{
 mbolIsTabUnique = value;
//记录修改过的字段
 AddUpdatedFld(conPrjTabFld.IsTabUnique);
}
}
/// <summary>
/// 是否表外键(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsTabForeignKey
{
get
{
return mbolIsTabForeignKey;
}
set
{
 mbolIsTabForeignKey = value;
//记录修改过的字段
 AddUpdatedFld(conPrjTabFld.IsTabForeignKey);
}
}
/// <summary>
/// 是否排序字段(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsSortFld
{
get
{
return mbolIsSortFld;
}
set
{
 mbolIsSortFld = value;
//记录修改过的字段
 AddUpdatedFld(conPrjTabFld.IsSortFld);
}
}
/// <summary>
/// 是否生成属性(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsGeneProp
{
get
{
return mbolIsGeneProp;
}
set
{
 mbolIsGeneProp = value;
//记录修改过的字段
 AddUpdatedFld(conPrjTabFld.IsGeneProp);
}
}
/// <summary>
/// 用于扩展类(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsForExtendClass
{
get
{
return mbolIsForExtendClass;
}
set
{
 mbolIsForExtendClass = value;
//记录修改过的字段
 AddUpdatedFld(conPrjTabFld.IsForExtendClass);
}
}
/// <summary>
/// 控件类型Id_du(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CtlTypeIdDu
{
get
{
return mstrCtlTypeIdDu;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCtlTypeIdDu = value;
}
else
{
 mstrCtlTypeIdDu = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjTabFld.CtlTypeIdDu);
}
}
/// <summary>
/// 字段显示单元样式Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FldDispUnitStyleId
{
get
{
return mstrFldDispUnitStyleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldDispUnitStyleId = value;
}
else
{
 mstrFldDispUnitStyleId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjTabFld.FldDispUnitStyleId);
}
}
/// <summary>
/// In字段Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string InFldId
{
get
{
return mstrInFldId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrInFldId = value;
}
else
{
 mstrInFldId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjTabFld.InFldId);
}
}
/// <summary>
/// DN路径Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DnPathId
{
get
{
return mstrDnPathId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDnPathId = value;
}
else
{
 mstrDnPathId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjTabFld.DnPathId);
}
}
/// <summary>
/// 测试关键字Id(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KeyId4Test
{
get
{
return mstrKeyId4Test;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeyId4Test = value;
}
else
{
 mstrKeyId4Test = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjTabFld.KeyId4Test);
}
}
/// <summary>
/// 显示格式(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DisplayFormat
{
get
{
return mstrDisplayFormat;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDisplayFormat = value;
}
else
{
 mstrDisplayFormat = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjTabFld.DisplayFormat);
}
}
/// <summary>
/// 是否父对象(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsParentObj
{
get
{
return mbolIsParentObj;
}
set
{
 mbolIsParentObj = value;
//记录修改过的字段
 AddUpdatedFld(conPrjTabFld.IsParentObj);
}
}
/// <summary>
/// 主键类型ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrimaryTypeId
{
get
{
return mstrPrimaryTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrimaryTypeId = value;
}
else
{
 mstrPrimaryTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjTabFld.PrimaryTypeId);
}
}
/// <summary>
/// 外键表ID(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ForeignKeyTabId
{
get
{
return mstrForeignKeyTabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrForeignKeyTabId = value;
}
else
{
 mstrForeignKeyTabId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjTabFld.ForeignKeyTabId);
}
}
/// <summary>
/// 字段操作类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FldOpTypeId
{
get
{
return mstrFldOpTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldOpTypeId = value;
}
else
{
 mstrFldOpTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjTabFld.FldOpTypeId);
}
}
/// <summary>
/// 顺序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? SequenceNumber
{
get
{
return mintSequenceNumber;
}
set
{
 mintSequenceNumber = value;
//记录修改过的字段
 AddUpdatedFld(conPrjTabFld.SequenceNumber);
}
}
/// <summary>
/// 表中说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MemoInTab
{
get
{
return mstrMemoInTab;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMemoInTab = value;
}
else
{
 mstrMemoInTab = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjTabFld.MemoInTab);
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
 AddUpdatedFld(conPrjTabFld.ErrMsg);
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
 AddUpdatedFld(conPrjTabFld.UpdDate);
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
 AddUpdatedFld(conPrjTabFld.UpdUser);
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
 AddUpdatedFld(conPrjTabFld.Memo);
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
 /// 工程表字段(PrjTabFld)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conPrjTabFld
{
public const string _CurrTabName = "PrjTabFld"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "TabId", "FldId", "PrjId", "FieldTypeId", "IsTabNullable", "IsTabUnique", "IsTabForeignKey", "IsSortFld", "IsGeneProp", "IsForExtendClass", "CtlTypeIdDu", "FldDispUnitStyleId", "InFldId", "DnPathId", "KeyId4Test", "DisplayFormat", "IsParentObj", "PrimaryTypeId", "ForeignKeyTabId", "FldOpTypeId", "SequenceNumber", "MemoInTab", "ErrMsg", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

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
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"FieldTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FieldTypeId = "FieldTypeId";    //字段类型Id

 /// <summary>
 /// 常量:"IsTabNullable"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsTabNullable = "IsTabNullable";    //是否表中可空

 /// <summary>
 /// 常量:"IsTabUnique"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsTabUnique = "IsTabUnique";    //是否表中唯一

 /// <summary>
 /// 常量:"IsTabForeignKey"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsTabForeignKey = "IsTabForeignKey";    //是否表外键

 /// <summary>
 /// 常量:"IsSortFld"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSortFld = "IsSortFld";    //是否排序字段

 /// <summary>
 /// 常量:"IsGeneProp"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsGeneProp = "IsGeneProp";    //是否生成属性

 /// <summary>
 /// 常量:"IsForExtendClass"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsForExtendClass = "IsForExtendClass";    //用于扩展类

 /// <summary>
 /// 常量:"CtlTypeIdDu"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CtlTypeIdDu = "CtlTypeIdDu";    //控件类型Id_du

 /// <summary>
 /// 常量:"FldDispUnitStyleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldDispUnitStyleId = "FldDispUnitStyleId";    //字段显示单元样式Id

 /// <summary>
 /// 常量:"InFldId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InFldId = "InFldId";    //In字段Id

 /// <summary>
 /// 常量:"DnPathId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DnPathId = "DnPathId";    //DN路径Id

 /// <summary>
 /// 常量:"KeyId4Test"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KeyId4Test = "KeyId4Test";    //测试关键字Id

 /// <summary>
 /// 常量:"DisplayFormat"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DisplayFormat = "DisplayFormat";    //显示格式

 /// <summary>
 /// 常量:"IsParentObj"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsParentObj = "IsParentObj";    //是否父对象

 /// <summary>
 /// 常量:"PrimaryTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrimaryTypeId = "PrimaryTypeId";    //主键类型ID

 /// <summary>
 /// 常量:"ForeignKeyTabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ForeignKeyTabId = "ForeignKeyTabId";    //外键表ID

 /// <summary>
 /// 常量:"FldOpTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldOpTypeId = "FldOpTypeId";    //字段操作类型Id

 /// <summary>
 /// 常量:"SequenceNumber"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SequenceNumber = "SequenceNumber";    //顺序号

 /// <summary>
 /// 常量:"MemoInTab"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MemoInTab = "MemoInTab";    //表中说明

 /// <summary>
 /// 常量:"ErrMsg"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ErrMsg = "ErrMsg";    //错误信息

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
}

}