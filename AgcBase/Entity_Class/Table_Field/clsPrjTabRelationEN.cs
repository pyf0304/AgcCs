
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjTabRelationEN
 表名:PrjTabRelation(00050606)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:27:55
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
 /// 表PrjTabRelation的关键字(PrjRelationId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PrjRelationId_PrjTabRelation
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strPrjRelationId">表关键字</param>
public K_PrjRelationId_PrjTabRelation(string strPrjRelationId)
{
if (IsValid(strPrjRelationId)) Value = strPrjRelationId;
else
{
Value = null;
}
}
private static bool IsValid(string strPrjRelationId)
{
if (string.IsNullOrEmpty(strPrjRelationId) == true) return false;
if (strPrjRelationId.Length > 8) return false;
if (strPrjRelationId.IndexOf(' ') >= 0) return false;
if (strPrjRelationId.IndexOf(')') >= 0) return false;
if (strPrjRelationId.IndexOf('(') >= 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PrjRelationId_PrjTabRelation]类型的对象</returns>
public static implicit operator K_PrjRelationId_PrjTabRelation(string value)
{
return new K_PrjRelationId_PrjTabRelation(value);
}
}
 /// <summary>
 /// 工程表关系(PrjTabRelation)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsPrjTabRelationEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "PrjTabRelation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PrjRelationId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 20;
public static string[] _AttributeName = new string[] {"PrjRelationId", "RelationName", "TabId", "PrjTabRelaTypeId", "DnPathId", "RelationTabId", "FldId4TabId", "FldId4RelaTabId", "ForeignKeyTabId", "ForeignKeyFldId", "IsCheckCurrData", "IsCopyForceRela", "IsUpdRelateFld", "IsUpdMainTabDate", "IsRefreshMainTabCache", "IsDelRelateRec", "PrjId", "Memo", "PrimaryKeyTabId", "PrimaryKeyFldId"};

protected string mstrPrjRelationId;    //关系Id
protected string mstrRelationName;    //关系名
protected string mstrTabId;    //表ID
protected string mstrPrjTabRelaTypeId;    //表关系类型Id
protected string mstrDnPathId;    //DN路径Id
protected string mstrRelationTabId;    //相关表Id
protected string mstrFldId4TabId;    //当前表的关系字段Id
protected string mstrFldId4RelaTabId;    //关系表的关系字段Id
protected string mstrForeignKeyTabId;    //外键表ID
protected string mstrForeignKeyFldId;    //外键字段Id
protected bool mbolIsCheckCurrData;    //是否检查当前数据
protected bool mbolIsCopyForceRela;    //IsCopyForceRela
protected bool mbolIsUpdRelateFld;    //是否修改关系字段
protected bool mbolIsUpdMainTabDate;    //是否修改主表日期
protected bool mbolIsRefreshMainTabCache;    //是否刷新主表缓存
protected bool mbolIsDelRelateRec;    //是否删除相关记录
protected string mstrPrjId;    //工程Id
protected string mstrMemo;    //说明
protected string mstrPrimaryKeyTabId;    //PrimaryKeyTabId
protected string mstrPrimaryKeyFldId;    //PrimaryKeyFldId

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsPrjTabRelationEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PrjRelationId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strPrjRelationId">关键字:关系Id</param>
public clsPrjTabRelationEN(string strPrjRelationId)
 {
strPrjRelationId = strPrjRelationId.Replace("'", "''");
if (strPrjRelationId.Length > 8)
{
throw new Exception("在表:PrjTabRelation中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strPrjRelationId)  ==  true)
{
throw new Exception("在表:PrjTabRelation中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPrjRelationId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrPrjRelationId = strPrjRelationId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PrjRelationId");
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
if (strAttributeName  ==  conPrjTabRelation.PrjRelationId)
{
return mstrPrjRelationId;
}
else if (strAttributeName  ==  conPrjTabRelation.RelationName)
{
return mstrRelationName;
}
else if (strAttributeName  ==  conPrjTabRelation.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  conPrjTabRelation.PrjTabRelaTypeId)
{
return mstrPrjTabRelaTypeId;
}
else if (strAttributeName  ==  conPrjTabRelation.DnPathId)
{
return mstrDnPathId;
}
else if (strAttributeName  ==  conPrjTabRelation.RelationTabId)
{
return mstrRelationTabId;
}
else if (strAttributeName  ==  conPrjTabRelation.FldId4TabId)
{
return mstrFldId4TabId;
}
else if (strAttributeName  ==  conPrjTabRelation.FldId4RelaTabId)
{
return mstrFldId4RelaTabId;
}
else if (strAttributeName  ==  conPrjTabRelation.ForeignKeyTabId)
{
return mstrForeignKeyTabId;
}
else if (strAttributeName  ==  conPrjTabRelation.ForeignKeyFldId)
{
return mstrForeignKeyFldId;
}
else if (strAttributeName  ==  conPrjTabRelation.IsCheckCurrData)
{
return mbolIsCheckCurrData;
}
else if (strAttributeName  ==  conPrjTabRelation.IsCopyForceRela)
{
return mbolIsCopyForceRela;
}
else if (strAttributeName  ==  conPrjTabRelation.IsUpdRelateFld)
{
return mbolIsUpdRelateFld;
}
else if (strAttributeName  ==  conPrjTabRelation.IsUpdMainTabDate)
{
return mbolIsUpdMainTabDate;
}
else if (strAttributeName  ==  conPrjTabRelation.IsRefreshMainTabCache)
{
return mbolIsRefreshMainTabCache;
}
else if (strAttributeName  ==  conPrjTabRelation.IsDelRelateRec)
{
return mbolIsDelRelateRec;
}
else if (strAttributeName  ==  conPrjTabRelation.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conPrjTabRelation.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conPrjTabRelation.PrimaryKeyTabId)
{
return mstrPrimaryKeyTabId;
}
else if (strAttributeName  ==  conPrjTabRelation.PrimaryKeyFldId)
{
return mstrPrimaryKeyFldId;
}
return null;
}
set
{
if (strAttributeName  ==  conPrjTabRelation.PrjRelationId)
{
mstrPrjRelationId = value.ToString();
 AddUpdatedFld(conPrjTabRelation.PrjRelationId);
}
else if (strAttributeName  ==  conPrjTabRelation.RelationName)
{
mstrRelationName = value.ToString();
 AddUpdatedFld(conPrjTabRelation.RelationName);
}
else if (strAttributeName  ==  conPrjTabRelation.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(conPrjTabRelation.TabId);
}
else if (strAttributeName  ==  conPrjTabRelation.PrjTabRelaTypeId)
{
mstrPrjTabRelaTypeId = value.ToString();
 AddUpdatedFld(conPrjTabRelation.PrjTabRelaTypeId);
}
else if (strAttributeName  ==  conPrjTabRelation.DnPathId)
{
mstrDnPathId = value.ToString();
 AddUpdatedFld(conPrjTabRelation.DnPathId);
}
else if (strAttributeName  ==  conPrjTabRelation.RelationTabId)
{
mstrRelationTabId = value.ToString();
 AddUpdatedFld(conPrjTabRelation.RelationTabId);
}
else if (strAttributeName  ==  conPrjTabRelation.FldId4TabId)
{
mstrFldId4TabId = value.ToString();
 AddUpdatedFld(conPrjTabRelation.FldId4TabId);
}
else if (strAttributeName  ==  conPrjTabRelation.FldId4RelaTabId)
{
mstrFldId4RelaTabId = value.ToString();
 AddUpdatedFld(conPrjTabRelation.FldId4RelaTabId);
}
else if (strAttributeName  ==  conPrjTabRelation.ForeignKeyTabId)
{
mstrForeignKeyTabId = value.ToString();
 AddUpdatedFld(conPrjTabRelation.ForeignKeyTabId);
}
else if (strAttributeName  ==  conPrjTabRelation.ForeignKeyFldId)
{
mstrForeignKeyFldId = value.ToString();
 AddUpdatedFld(conPrjTabRelation.ForeignKeyFldId);
}
else if (strAttributeName  ==  conPrjTabRelation.IsCheckCurrData)
{
mbolIsCheckCurrData = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjTabRelation.IsCheckCurrData);
}
else if (strAttributeName  ==  conPrjTabRelation.IsCopyForceRela)
{
mbolIsCopyForceRela = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjTabRelation.IsCopyForceRela);
}
else if (strAttributeName  ==  conPrjTabRelation.IsUpdRelateFld)
{
mbolIsUpdRelateFld = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjTabRelation.IsUpdRelateFld);
}
else if (strAttributeName  ==  conPrjTabRelation.IsUpdMainTabDate)
{
mbolIsUpdMainTabDate = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjTabRelation.IsUpdMainTabDate);
}
else if (strAttributeName  ==  conPrjTabRelation.IsRefreshMainTabCache)
{
mbolIsRefreshMainTabCache = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjTabRelation.IsRefreshMainTabCache);
}
else if (strAttributeName  ==  conPrjTabRelation.IsDelRelateRec)
{
mbolIsDelRelateRec = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjTabRelation.IsDelRelateRec);
}
else if (strAttributeName  ==  conPrjTabRelation.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conPrjTabRelation.PrjId);
}
else if (strAttributeName  ==  conPrjTabRelation.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPrjTabRelation.Memo);
}
else if (strAttributeName  ==  conPrjTabRelation.PrimaryKeyTabId)
{
mstrPrimaryKeyTabId = value.ToString();
 AddUpdatedFld(conPrjTabRelation.PrimaryKeyTabId);
}
else if (strAttributeName  ==  conPrjTabRelation.PrimaryKeyFldId)
{
mstrPrimaryKeyFldId = value.ToString();
 AddUpdatedFld(conPrjTabRelation.PrimaryKeyFldId);
}
}
}
public object this[int intIndex]
{
get
{
if (conPrjTabRelation.PrjRelationId  ==  _AttributeName[intIndex])
{
return mstrPrjRelationId;
}
else if (conPrjTabRelation.RelationName  ==  _AttributeName[intIndex])
{
return mstrRelationName;
}
else if (conPrjTabRelation.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (conPrjTabRelation.PrjTabRelaTypeId  ==  _AttributeName[intIndex])
{
return mstrPrjTabRelaTypeId;
}
else if (conPrjTabRelation.DnPathId  ==  _AttributeName[intIndex])
{
return mstrDnPathId;
}
else if (conPrjTabRelation.RelationTabId  ==  _AttributeName[intIndex])
{
return mstrRelationTabId;
}
else if (conPrjTabRelation.FldId4TabId  ==  _AttributeName[intIndex])
{
return mstrFldId4TabId;
}
else if (conPrjTabRelation.FldId4RelaTabId  ==  _AttributeName[intIndex])
{
return mstrFldId4RelaTabId;
}
else if (conPrjTabRelation.ForeignKeyTabId  ==  _AttributeName[intIndex])
{
return mstrForeignKeyTabId;
}
else if (conPrjTabRelation.ForeignKeyFldId  ==  _AttributeName[intIndex])
{
return mstrForeignKeyFldId;
}
else if (conPrjTabRelation.IsCheckCurrData  ==  _AttributeName[intIndex])
{
return mbolIsCheckCurrData;
}
else if (conPrjTabRelation.IsCopyForceRela  ==  _AttributeName[intIndex])
{
return mbolIsCopyForceRela;
}
else if (conPrjTabRelation.IsUpdRelateFld  ==  _AttributeName[intIndex])
{
return mbolIsUpdRelateFld;
}
else if (conPrjTabRelation.IsUpdMainTabDate  ==  _AttributeName[intIndex])
{
return mbolIsUpdMainTabDate;
}
else if (conPrjTabRelation.IsRefreshMainTabCache  ==  _AttributeName[intIndex])
{
return mbolIsRefreshMainTabCache;
}
else if (conPrjTabRelation.IsDelRelateRec  ==  _AttributeName[intIndex])
{
return mbolIsDelRelateRec;
}
else if (conPrjTabRelation.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conPrjTabRelation.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (conPrjTabRelation.PrimaryKeyTabId  ==  _AttributeName[intIndex])
{
return mstrPrimaryKeyTabId;
}
else if (conPrjTabRelation.PrimaryKeyFldId  ==  _AttributeName[intIndex])
{
return mstrPrimaryKeyFldId;
}
return null;
}
set
{
if (conPrjTabRelation.PrjRelationId  ==  _AttributeName[intIndex])
{
mstrPrjRelationId = value.ToString();
 AddUpdatedFld(conPrjTabRelation.PrjRelationId);
}
else if (conPrjTabRelation.RelationName  ==  _AttributeName[intIndex])
{
mstrRelationName = value.ToString();
 AddUpdatedFld(conPrjTabRelation.RelationName);
}
else if (conPrjTabRelation.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(conPrjTabRelation.TabId);
}
else if (conPrjTabRelation.PrjTabRelaTypeId  ==  _AttributeName[intIndex])
{
mstrPrjTabRelaTypeId = value.ToString();
 AddUpdatedFld(conPrjTabRelation.PrjTabRelaTypeId);
}
else if (conPrjTabRelation.DnPathId  ==  _AttributeName[intIndex])
{
mstrDnPathId = value.ToString();
 AddUpdatedFld(conPrjTabRelation.DnPathId);
}
else if (conPrjTabRelation.RelationTabId  ==  _AttributeName[intIndex])
{
mstrRelationTabId = value.ToString();
 AddUpdatedFld(conPrjTabRelation.RelationTabId);
}
else if (conPrjTabRelation.FldId4TabId  ==  _AttributeName[intIndex])
{
mstrFldId4TabId = value.ToString();
 AddUpdatedFld(conPrjTabRelation.FldId4TabId);
}
else if (conPrjTabRelation.FldId4RelaTabId  ==  _AttributeName[intIndex])
{
mstrFldId4RelaTabId = value.ToString();
 AddUpdatedFld(conPrjTabRelation.FldId4RelaTabId);
}
else if (conPrjTabRelation.ForeignKeyTabId  ==  _AttributeName[intIndex])
{
mstrForeignKeyTabId = value.ToString();
 AddUpdatedFld(conPrjTabRelation.ForeignKeyTabId);
}
else if (conPrjTabRelation.ForeignKeyFldId  ==  _AttributeName[intIndex])
{
mstrForeignKeyFldId = value.ToString();
 AddUpdatedFld(conPrjTabRelation.ForeignKeyFldId);
}
else if (conPrjTabRelation.IsCheckCurrData  ==  _AttributeName[intIndex])
{
mbolIsCheckCurrData = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjTabRelation.IsCheckCurrData);
}
else if (conPrjTabRelation.IsCopyForceRela  ==  _AttributeName[intIndex])
{
mbolIsCopyForceRela = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjTabRelation.IsCopyForceRela);
}
else if (conPrjTabRelation.IsUpdRelateFld  ==  _AttributeName[intIndex])
{
mbolIsUpdRelateFld = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjTabRelation.IsUpdRelateFld);
}
else if (conPrjTabRelation.IsUpdMainTabDate  ==  _AttributeName[intIndex])
{
mbolIsUpdMainTabDate = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjTabRelation.IsUpdMainTabDate);
}
else if (conPrjTabRelation.IsRefreshMainTabCache  ==  _AttributeName[intIndex])
{
mbolIsRefreshMainTabCache = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjTabRelation.IsRefreshMainTabCache);
}
else if (conPrjTabRelation.IsDelRelateRec  ==  _AttributeName[intIndex])
{
mbolIsDelRelateRec = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjTabRelation.IsDelRelateRec);
}
else if (conPrjTabRelation.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conPrjTabRelation.PrjId);
}
else if (conPrjTabRelation.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPrjTabRelation.Memo);
}
else if (conPrjTabRelation.PrimaryKeyTabId  ==  _AttributeName[intIndex])
{
mstrPrimaryKeyTabId = value.ToString();
 AddUpdatedFld(conPrjTabRelation.PrimaryKeyTabId);
}
else if (conPrjTabRelation.PrimaryKeyFldId  ==  _AttributeName[intIndex])
{
mstrPrimaryKeyFldId = value.ToString();
 AddUpdatedFld(conPrjTabRelation.PrimaryKeyFldId);
}
}
}

/// <summary>
/// 关系Id(说明:;字段类型:varchar;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjRelationId
{
get
{
return mstrPrjRelationId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjRelationId = value;
}
else
{
 mstrPrjRelationId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjTabRelation.PrjRelationId);
}
}
/// <summary>
/// 关系名(说明:;字段类型:varchar;字段长度:40;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RelationName
{
get
{
return mstrRelationName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRelationName = value;
}
else
{
 mstrRelationName = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjTabRelation.RelationName);
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
 AddUpdatedFld(conPrjTabRelation.TabId);
}
}
/// <summary>
/// 表关系类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjTabRelaTypeId
{
get
{
return mstrPrjTabRelaTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjTabRelaTypeId = value;
}
else
{
 mstrPrjTabRelaTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjTabRelation.PrjTabRelaTypeId);
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
 AddUpdatedFld(conPrjTabRelation.DnPathId);
}
}
/// <summary>
/// 相关表Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RelationTabId
{
get
{
return mstrRelationTabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRelationTabId = value;
}
else
{
 mstrRelationTabId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjTabRelation.RelationTabId);
}
}
/// <summary>
/// 当前表的关系字段Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FldId4TabId
{
get
{
return mstrFldId4TabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldId4TabId = value;
}
else
{
 mstrFldId4TabId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjTabRelation.FldId4TabId);
}
}
/// <summary>
/// 关系表的关系字段Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FldId4RelaTabId
{
get
{
return mstrFldId4RelaTabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldId4RelaTabId = value;
}
else
{
 mstrFldId4RelaTabId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjTabRelation.FldId4RelaTabId);
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
 AddUpdatedFld(conPrjTabRelation.ForeignKeyTabId);
}
}
/// <summary>
/// 外键字段Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ForeignKeyFldId
{
get
{
return mstrForeignKeyFldId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrForeignKeyFldId = value;
}
else
{
 mstrForeignKeyFldId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjTabRelation.ForeignKeyFldId);
}
}
/// <summary>
/// 是否检查当前数据(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsCheckCurrData
{
get
{
return mbolIsCheckCurrData;
}
set
{
 mbolIsCheckCurrData = value;
//记录修改过的字段
 AddUpdatedFld(conPrjTabRelation.IsCheckCurrData);
}
}
/// <summary>
/// IsCopyForceRela(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsCopyForceRela
{
get
{
return mbolIsCopyForceRela;
}
set
{
 mbolIsCopyForceRela = value;
//记录修改过的字段
 AddUpdatedFld(conPrjTabRelation.IsCopyForceRela);
}
}
/// <summary>
/// 是否修改关系字段(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsUpdRelateFld
{
get
{
return mbolIsUpdRelateFld;
}
set
{
 mbolIsUpdRelateFld = value;
//记录修改过的字段
 AddUpdatedFld(conPrjTabRelation.IsUpdRelateFld);
}
}
/// <summary>
/// 是否修改主表日期(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsUpdMainTabDate
{
get
{
return mbolIsUpdMainTabDate;
}
set
{
 mbolIsUpdMainTabDate = value;
//记录修改过的字段
 AddUpdatedFld(conPrjTabRelation.IsUpdMainTabDate);
}
}
/// <summary>
/// 是否刷新主表缓存(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsRefreshMainTabCache
{
get
{
return mbolIsRefreshMainTabCache;
}
set
{
 mbolIsRefreshMainTabCache = value;
//记录修改过的字段
 AddUpdatedFld(conPrjTabRelation.IsRefreshMainTabCache);
}
}
/// <summary>
/// 是否删除相关记录(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsDelRelateRec
{
get
{
return mbolIsDelRelateRec;
}
set
{
 mbolIsDelRelateRec = value;
//记录修改过的字段
 AddUpdatedFld(conPrjTabRelation.IsDelRelateRec);
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
 AddUpdatedFld(conPrjTabRelation.PrjId);
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
 AddUpdatedFld(conPrjTabRelation.Memo);
}
}
/// <summary>
/// PrimaryKeyTabId(说明:;字段类型:varchar;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrimaryKeyTabId
{
get
{
return mstrPrimaryKeyTabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrimaryKeyTabId = value;
}
else
{
 mstrPrimaryKeyTabId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjTabRelation.PrimaryKeyTabId);
}
}
/// <summary>
/// PrimaryKeyFldId(说明:;字段类型:varchar;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrimaryKeyFldId
{
get
{
return mstrPrimaryKeyFldId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrimaryKeyFldId = value;
}
else
{
 mstrPrimaryKeyFldId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjTabRelation.PrimaryKeyFldId);
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
  return mstrPrjRelationId;
 }
 }

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrRelationName;
 }
 }
}
 /// <summary>
 /// 工程表关系(PrjTabRelation)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conPrjTabRelation
{
public const string _CurrTabName = "PrjTabRelation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PrjRelationId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"PrjRelationId", "RelationName", "TabId", "PrjTabRelaTypeId", "DnPathId", "RelationTabId", "FldId4TabId", "FldId4RelaTabId", "ForeignKeyTabId", "ForeignKeyFldId", "IsCheckCurrData", "IsCopyForceRela", "IsUpdRelateFld", "IsUpdMainTabDate", "IsRefreshMainTabCache", "IsDelRelateRec", "PrjId", "Memo", "PrimaryKeyTabId", "PrimaryKeyFldId"};
//以下是属性变量


 /// <summary>
 /// 常量:"PrjRelationId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjRelationId = "PrjRelationId";    //关系Id

 /// <summary>
 /// 常量:"RelationName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RelationName = "RelationName";    //关系名

 /// <summary>
 /// 常量:"TabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabId = "TabId";    //表ID

 /// <summary>
 /// 常量:"PrjTabRelaTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjTabRelaTypeId = "PrjTabRelaTypeId";    //表关系类型Id

 /// <summary>
 /// 常量:"DnPathId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DnPathId = "DnPathId";    //DN路径Id

 /// <summary>
 /// 常量:"RelationTabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RelationTabId = "RelationTabId";    //相关表Id

 /// <summary>
 /// 常量:"FldId4TabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldId4TabId = "FldId4TabId";    //当前表的关系字段Id

 /// <summary>
 /// 常量:"FldId4RelaTabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldId4RelaTabId = "FldId4RelaTabId";    //关系表的关系字段Id

 /// <summary>
 /// 常量:"ForeignKeyTabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ForeignKeyTabId = "ForeignKeyTabId";    //外键表ID

 /// <summary>
 /// 常量:"ForeignKeyFldId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ForeignKeyFldId = "ForeignKeyFldId";    //外键字段Id

 /// <summary>
 /// 常量:"IsCheckCurrData"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsCheckCurrData = "IsCheckCurrData";    //是否检查当前数据

 /// <summary>
 /// 常量:"IsCopyForceRela"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsCopyForceRela = "IsCopyForceRela";    //IsCopyForceRela

 /// <summary>
 /// 常量:"IsUpdRelateFld"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsUpdRelateFld = "IsUpdRelateFld";    //是否修改关系字段

 /// <summary>
 /// 常量:"IsUpdMainTabDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsUpdMainTabDate = "IsUpdMainTabDate";    //是否修改主表日期

 /// <summary>
 /// 常量:"IsRefreshMainTabCache"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsRefreshMainTabCache = "IsRefreshMainTabCache";    //是否刷新主表缓存

 /// <summary>
 /// 常量:"IsDelRelateRec"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDelRelateRec = "IsDelRelateRec";    //是否删除相关记录

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明

 /// <summary>
 /// 常量:"PrimaryKeyTabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrimaryKeyTabId = "PrimaryKeyTabId";    //PrimaryKeyTabId

 /// <summary>
 /// 常量:"PrimaryKeyFldId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrimaryKeyFldId = "PrimaryKeyFldId";    //PrimaryKeyFldId
}

}