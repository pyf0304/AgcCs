
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSqlViewRelaTabEN
 表名:SqlViewRelaTab(00050247)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:34:42
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:Sql视图管理(SqlViewMan)
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
 /// 表SqlViewRelaTab的关键字(RelaTabId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_RelaTabId_SqlViewRelaTab
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strRelaTabId">表关键字</param>
public K_RelaTabId_SqlViewRelaTab(string strRelaTabId)
{
if (IsValid(strRelaTabId)) Value = strRelaTabId;
else
{
Value = null;
}
}
private static bool IsValid(string strRelaTabId)
{
if (string.IsNullOrEmpty(strRelaTabId) == true) return false;
if (strRelaTabId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_RelaTabId_SqlViewRelaTab]类型的对象</returns>
public static implicit operator K_RelaTabId_SqlViewRelaTab(string value)
{
return new K_RelaTabId_SqlViewRelaTab(value);
}
}
 /// <summary>
 /// Sql视图相关表(SqlViewRelaTab)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsSqlViewRelaTabEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "SqlViewRelaTab"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "RelaTabId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 15;
public static string[] _AttributeName = new string[] {"RelaTabId", "SqlViewId", "TabId", "TabAliases", "RelaFldId", "OtherFldId", "OtherTabId", "SvRelaTabTypeId", "TabRelationTypeId", "TabRelationText", "OrderNum", "PrjId", "UpdDate", "UpdUserId", "Memo"};

protected string mstrRelaTabId;    //相关表Id
protected string mstrSqlViewId;    //Sql视图Id
protected string mstrTabId;    //表ID
protected string mstrTabAliases;    //表别名
protected string mstrRelaFldId;    //关系字段
protected string mstrOtherFldId;    //其他表字段
protected string mstrOtherTabId;    //其他表Id
protected string mstrSvRelaTabTypeId;    //Sql视图相关表类型Id
protected string mstrTabRelationTypeId;    //表关系类型Id
protected string mstrTabRelationText;    //表关系文本
protected int mintOrderNum;    //序号
protected string mstrPrjId;    //工程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsSqlViewRelaTabEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("RelaTabId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strRelaTabId">关键字:相关表Id</param>
public clsSqlViewRelaTabEN(string strRelaTabId)
 {
strRelaTabId = strRelaTabId.Replace("'", "''");
if (strRelaTabId.Length > 8)
{
throw new Exception("在表:SqlViewRelaTab中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strRelaTabId)  ==  true)
{
throw new Exception("在表:SqlViewRelaTab中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strRelaTabId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrRelaTabId = strRelaTabId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("RelaTabId");
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
if (strAttributeName  ==  conSqlViewRelaTab.RelaTabId)
{
return mstrRelaTabId;
}
else if (strAttributeName  ==  conSqlViewRelaTab.SqlViewId)
{
return mstrSqlViewId;
}
else if (strAttributeName  ==  conSqlViewRelaTab.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  conSqlViewRelaTab.TabAliases)
{
return mstrTabAliases;
}
else if (strAttributeName  ==  conSqlViewRelaTab.RelaFldId)
{
return mstrRelaFldId;
}
else if (strAttributeName  ==  conSqlViewRelaTab.OtherFldId)
{
return mstrOtherFldId;
}
else if (strAttributeName  ==  conSqlViewRelaTab.OtherTabId)
{
return mstrOtherTabId;
}
else if (strAttributeName  ==  conSqlViewRelaTab.SvRelaTabTypeId)
{
return mstrSvRelaTabTypeId;
}
else if (strAttributeName  ==  conSqlViewRelaTab.TabRelationTypeId)
{
return mstrTabRelationTypeId;
}
else if (strAttributeName  ==  conSqlViewRelaTab.TabRelationText)
{
return mstrTabRelationText;
}
else if (strAttributeName  ==  conSqlViewRelaTab.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conSqlViewRelaTab.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conSqlViewRelaTab.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conSqlViewRelaTab.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conSqlViewRelaTab.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conSqlViewRelaTab.RelaTabId)
{
mstrRelaTabId = value.ToString();
 AddUpdatedFld(conSqlViewRelaTab.RelaTabId);
}
else if (strAttributeName  ==  conSqlViewRelaTab.SqlViewId)
{
mstrSqlViewId = value.ToString();
 AddUpdatedFld(conSqlViewRelaTab.SqlViewId);
}
else if (strAttributeName  ==  conSqlViewRelaTab.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(conSqlViewRelaTab.TabId);
}
else if (strAttributeName  ==  conSqlViewRelaTab.TabAliases)
{
mstrTabAliases = value.ToString();
 AddUpdatedFld(conSqlViewRelaTab.TabAliases);
}
else if (strAttributeName  ==  conSqlViewRelaTab.RelaFldId)
{
mstrRelaFldId = value.ToString();
 AddUpdatedFld(conSqlViewRelaTab.RelaFldId);
}
else if (strAttributeName  ==  conSqlViewRelaTab.OtherFldId)
{
mstrOtherFldId = value.ToString();
 AddUpdatedFld(conSqlViewRelaTab.OtherFldId);
}
else if (strAttributeName  ==  conSqlViewRelaTab.OtherTabId)
{
mstrOtherTabId = value.ToString();
 AddUpdatedFld(conSqlViewRelaTab.OtherTabId);
}
else if (strAttributeName  ==  conSqlViewRelaTab.SvRelaTabTypeId)
{
mstrSvRelaTabTypeId = value.ToString();
 AddUpdatedFld(conSqlViewRelaTab.SvRelaTabTypeId);
}
else if (strAttributeName  ==  conSqlViewRelaTab.TabRelationTypeId)
{
mstrTabRelationTypeId = value.ToString();
 AddUpdatedFld(conSqlViewRelaTab.TabRelationTypeId);
}
else if (strAttributeName  ==  conSqlViewRelaTab.TabRelationText)
{
mstrTabRelationText = value.ToString();
 AddUpdatedFld(conSqlViewRelaTab.TabRelationText);
}
else if (strAttributeName  ==  conSqlViewRelaTab.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conSqlViewRelaTab.OrderNum);
}
else if (strAttributeName  ==  conSqlViewRelaTab.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conSqlViewRelaTab.PrjId);
}
else if (strAttributeName  ==  conSqlViewRelaTab.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conSqlViewRelaTab.UpdDate);
}
else if (strAttributeName  ==  conSqlViewRelaTab.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conSqlViewRelaTab.UpdUserId);
}
else if (strAttributeName  ==  conSqlViewRelaTab.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSqlViewRelaTab.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conSqlViewRelaTab.RelaTabId  ==  _AttributeName[intIndex])
{
return mstrRelaTabId;
}
else if (conSqlViewRelaTab.SqlViewId  ==  _AttributeName[intIndex])
{
return mstrSqlViewId;
}
else if (conSqlViewRelaTab.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (conSqlViewRelaTab.TabAliases  ==  _AttributeName[intIndex])
{
return mstrTabAliases;
}
else if (conSqlViewRelaTab.RelaFldId  ==  _AttributeName[intIndex])
{
return mstrRelaFldId;
}
else if (conSqlViewRelaTab.OtherFldId  ==  _AttributeName[intIndex])
{
return mstrOtherFldId;
}
else if (conSqlViewRelaTab.OtherTabId  ==  _AttributeName[intIndex])
{
return mstrOtherTabId;
}
else if (conSqlViewRelaTab.SvRelaTabTypeId  ==  _AttributeName[intIndex])
{
return mstrSvRelaTabTypeId;
}
else if (conSqlViewRelaTab.TabRelationTypeId  ==  _AttributeName[intIndex])
{
return mstrTabRelationTypeId;
}
else if (conSqlViewRelaTab.TabRelationText  ==  _AttributeName[intIndex])
{
return mstrTabRelationText;
}
else if (conSqlViewRelaTab.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conSqlViewRelaTab.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conSqlViewRelaTab.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conSqlViewRelaTab.UpdUserId  ==  _AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conSqlViewRelaTab.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conSqlViewRelaTab.RelaTabId  ==  _AttributeName[intIndex])
{
mstrRelaTabId = value.ToString();
 AddUpdatedFld(conSqlViewRelaTab.RelaTabId);
}
else if (conSqlViewRelaTab.SqlViewId  ==  _AttributeName[intIndex])
{
mstrSqlViewId = value.ToString();
 AddUpdatedFld(conSqlViewRelaTab.SqlViewId);
}
else if (conSqlViewRelaTab.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(conSqlViewRelaTab.TabId);
}
else if (conSqlViewRelaTab.TabAliases  ==  _AttributeName[intIndex])
{
mstrTabAliases = value.ToString();
 AddUpdatedFld(conSqlViewRelaTab.TabAliases);
}
else if (conSqlViewRelaTab.RelaFldId  ==  _AttributeName[intIndex])
{
mstrRelaFldId = value.ToString();
 AddUpdatedFld(conSqlViewRelaTab.RelaFldId);
}
else if (conSqlViewRelaTab.OtherFldId  ==  _AttributeName[intIndex])
{
mstrOtherFldId = value.ToString();
 AddUpdatedFld(conSqlViewRelaTab.OtherFldId);
}
else if (conSqlViewRelaTab.OtherTabId  ==  _AttributeName[intIndex])
{
mstrOtherTabId = value.ToString();
 AddUpdatedFld(conSqlViewRelaTab.OtherTabId);
}
else if (conSqlViewRelaTab.SvRelaTabTypeId  ==  _AttributeName[intIndex])
{
mstrSvRelaTabTypeId = value.ToString();
 AddUpdatedFld(conSqlViewRelaTab.SvRelaTabTypeId);
}
else if (conSqlViewRelaTab.TabRelationTypeId  ==  _AttributeName[intIndex])
{
mstrTabRelationTypeId = value.ToString();
 AddUpdatedFld(conSqlViewRelaTab.TabRelationTypeId);
}
else if (conSqlViewRelaTab.TabRelationText  ==  _AttributeName[intIndex])
{
mstrTabRelationText = value.ToString();
 AddUpdatedFld(conSqlViewRelaTab.TabRelationText);
}
else if (conSqlViewRelaTab.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conSqlViewRelaTab.OrderNum);
}
else if (conSqlViewRelaTab.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conSqlViewRelaTab.PrjId);
}
else if (conSqlViewRelaTab.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conSqlViewRelaTab.UpdDate);
}
else if (conSqlViewRelaTab.UpdUserId  ==  _AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conSqlViewRelaTab.UpdUserId);
}
else if (conSqlViewRelaTab.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSqlViewRelaTab.Memo);
}
}
}

/// <summary>
/// 相关表Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RelaTabId
{
get
{
return mstrRelaTabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRelaTabId = value;
}
else
{
 mstrRelaTabId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSqlViewRelaTab.RelaTabId);
}
}
/// <summary>
/// Sql视图Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SqlViewId
{
get
{
return mstrSqlViewId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSqlViewId = value;
}
else
{
 mstrSqlViewId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSqlViewRelaTab.SqlViewId);
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
 AddUpdatedFld(conSqlViewRelaTab.TabId);
}
}
/// <summary>
/// 表别名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabAliases
{
get
{
return mstrTabAliases;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabAliases = value;
}
else
{
 mstrTabAliases = value;
}
//记录修改过的字段
 AddUpdatedFld(conSqlViewRelaTab.TabAliases);
}
}
/// <summary>
/// 关系字段(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RelaFldId
{
get
{
return mstrRelaFldId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRelaFldId = value;
}
else
{
 mstrRelaFldId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSqlViewRelaTab.RelaFldId);
}
}
/// <summary>
/// 其他表字段(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OtherFldId
{
get
{
return mstrOtherFldId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOtherFldId = value;
}
else
{
 mstrOtherFldId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSqlViewRelaTab.OtherFldId);
}
}
/// <summary>
/// 其他表Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OtherTabId
{
get
{
return mstrOtherTabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOtherTabId = value;
}
else
{
 mstrOtherTabId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSqlViewRelaTab.OtherTabId);
}
}
/// <summary>
/// Sql视图相关表类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SvRelaTabTypeId
{
get
{
return mstrSvRelaTabTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSvRelaTabTypeId = value;
}
else
{
 mstrSvRelaTabTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSqlViewRelaTab.SvRelaTabTypeId);
}
}
/// <summary>
/// 表关系类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabRelationTypeId
{
get
{
return mstrTabRelationTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabRelationTypeId = value;
}
else
{
 mstrTabRelationTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSqlViewRelaTab.TabRelationTypeId);
}
}
/// <summary>
/// 表关系文本(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabRelationText
{
get
{
return mstrTabRelationText;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabRelationText = value;
}
else
{
 mstrTabRelationText = value;
}
//记录修改过的字段
 AddUpdatedFld(conSqlViewRelaTab.TabRelationText);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(conSqlViewRelaTab.OrderNum);
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
 AddUpdatedFld(conSqlViewRelaTab.PrjId);
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
 AddUpdatedFld(conSqlViewRelaTab.UpdDate);
}
}
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUserId
{
get
{
return mstrUpdUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUserId = value;
}
else
{
 mstrUpdUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSqlViewRelaTab.UpdUserId);
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
 AddUpdatedFld(conSqlViewRelaTab.Memo);
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
  return mstrRelaTabId;
 }
 }
}
 /// <summary>
 /// Sql视图相关表(SqlViewRelaTab)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conSqlViewRelaTab
{
public const string _CurrTabName = "SqlViewRelaTab"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "RelaTabId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"RelaTabId", "SqlViewId", "TabId", "TabAliases", "RelaFldId", "OtherFldId", "OtherTabId", "SvRelaTabTypeId", "TabRelationTypeId", "TabRelationText", "OrderNum", "PrjId", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"RelaTabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RelaTabId = "RelaTabId";    //相关表Id

 /// <summary>
 /// 常量:"SqlViewId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SqlViewId = "SqlViewId";    //Sql视图Id

 /// <summary>
 /// 常量:"TabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabId = "TabId";    //表ID

 /// <summary>
 /// 常量:"TabAliases"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabAliases = "TabAliases";    //表别名

 /// <summary>
 /// 常量:"RelaFldId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RelaFldId = "RelaFldId";    //关系字段

 /// <summary>
 /// 常量:"OtherFldId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OtherFldId = "OtherFldId";    //其他表字段

 /// <summary>
 /// 常量:"OtherTabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OtherTabId = "OtherTabId";    //其他表Id

 /// <summary>
 /// 常量:"SvRelaTabTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SvRelaTabTypeId = "SvRelaTabTypeId";    //Sql视图相关表类型Id

 /// <summary>
 /// 常量:"TabRelationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabRelationTypeId = "TabRelationTypeId";    //表关系类型Id

 /// <summary>
 /// 常量:"TabRelationText"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabRelationText = "TabRelationText";    //表关系文本

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

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
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}