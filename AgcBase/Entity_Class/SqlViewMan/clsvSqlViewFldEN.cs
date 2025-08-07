
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSqlViewFldEN
 表名:vSqlViewFld(00050252)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:48:01
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
 /// 表vSqlViewFld的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vSqlViewFld
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
public K_mId_vSqlViewFld(long lngmId)
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
 /// <returns>返回:[K_mId_vSqlViewFld]类型的对象</returns>
public static implicit operator K_mId_vSqlViewFld(long value)
{
return new K_mId_vSqlViewFld(value);
}
}
 /// <summary>
 /// vSql视图字段(vSqlViewFld)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvSqlViewFldEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vSqlViewFld"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 22;
public static string[] _AttributeName = new string[] {"mId", "SqlViewId", "SqlViewName", "SqlViewCNName", "RelaTabId", "TabId", "TabName", "TabCnName", "TabAliases", "TabRelationText", "FldId", "FldName", "FldCnName", "FldExpression", "FieldAliases", "Filters", "OrderNum", "PrjId", "UpdDate", "UpdUserId", "Memo", "RelaTabId4SqlView"};

protected long mlngmId;    //mId
protected string mstrSqlViewId;    //Sql视图Id
protected string mstrSqlViewName;    //数据视图名称
protected string mstrSqlViewCNName;    //Sql视图中文名
protected string mstrRelaTabId;    //相关表Id
protected string mstrTabId;    //表ID
protected string mstrTabName;    //表名
protected string mstrTabCnName;    //表中文名
protected string mstrTabAliases;    //表别名
protected string mstrTabRelationText;    //表关系文本
protected string mstrFldId;    //字段Id
protected string mstrFldName;    //字段名
protected string mstrFldCnName;    //字段中文详名
protected string mstrFldExpression;    //字段表达式
protected string mstrFieldAliases;    //字段别名
protected string mstrFilters;    //筛选器
protected int mintOrderNum;    //序号
protected string mstrPrjId;    //工程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //说明
protected string mstrRelaTabId4SqlView;    //RelaTabId4SqlView

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvSqlViewFldEN()
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
public clsvSqlViewFldEN(long lngmId)
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
if (strAttributeName  ==  convSqlViewFld.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convSqlViewFld.SqlViewId)
{
return mstrSqlViewId;
}
else if (strAttributeName  ==  convSqlViewFld.SqlViewName)
{
return mstrSqlViewName;
}
else if (strAttributeName  ==  convSqlViewFld.SqlViewCNName)
{
return mstrSqlViewCNName;
}
else if (strAttributeName  ==  convSqlViewFld.RelaTabId)
{
return mstrRelaTabId;
}
else if (strAttributeName  ==  convSqlViewFld.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  convSqlViewFld.TabName)
{
return mstrTabName;
}
else if (strAttributeName  ==  convSqlViewFld.TabCnName)
{
return mstrTabCnName;
}
else if (strAttributeName  ==  convSqlViewFld.TabAliases)
{
return mstrTabAliases;
}
else if (strAttributeName  ==  convSqlViewFld.TabRelationText)
{
return mstrTabRelationText;
}
else if (strAttributeName  ==  convSqlViewFld.FldId)
{
return mstrFldId;
}
else if (strAttributeName  ==  convSqlViewFld.FldName)
{
return mstrFldName;
}
else if (strAttributeName  ==  convSqlViewFld.FldCnName)
{
return mstrFldCnName;
}
else if (strAttributeName  ==  convSqlViewFld.FldExpression)
{
return mstrFldExpression;
}
else if (strAttributeName  ==  convSqlViewFld.FieldAliases)
{
return mstrFieldAliases;
}
else if (strAttributeName  ==  convSqlViewFld.Filters)
{
return mstrFilters;
}
else if (strAttributeName  ==  convSqlViewFld.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convSqlViewFld.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convSqlViewFld.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convSqlViewFld.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convSqlViewFld.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convSqlViewFld.RelaTabId4SqlView)
{
return mstrRelaTabId4SqlView;
}
return null;
}
set
{
if (strAttributeName  ==  convSqlViewFld.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convSqlViewFld.mId);
}
else if (strAttributeName  ==  convSqlViewFld.SqlViewId)
{
mstrSqlViewId = value.ToString();
 AddUpdatedFld(convSqlViewFld.SqlViewId);
}
else if (strAttributeName  ==  convSqlViewFld.SqlViewName)
{
mstrSqlViewName = value.ToString();
 AddUpdatedFld(convSqlViewFld.SqlViewName);
}
else if (strAttributeName  ==  convSqlViewFld.SqlViewCNName)
{
mstrSqlViewCNName = value.ToString();
 AddUpdatedFld(convSqlViewFld.SqlViewCNName);
}
else if (strAttributeName  ==  convSqlViewFld.RelaTabId)
{
mstrRelaTabId = value.ToString();
 AddUpdatedFld(convSqlViewFld.RelaTabId);
}
else if (strAttributeName  ==  convSqlViewFld.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(convSqlViewFld.TabId);
}
else if (strAttributeName  ==  convSqlViewFld.TabName)
{
mstrTabName = value.ToString();
 AddUpdatedFld(convSqlViewFld.TabName);
}
else if (strAttributeName  ==  convSqlViewFld.TabCnName)
{
mstrTabCnName = value.ToString();
 AddUpdatedFld(convSqlViewFld.TabCnName);
}
else if (strAttributeName  ==  convSqlViewFld.TabAliases)
{
mstrTabAliases = value.ToString();
 AddUpdatedFld(convSqlViewFld.TabAliases);
}
else if (strAttributeName  ==  convSqlViewFld.TabRelationText)
{
mstrTabRelationText = value.ToString();
 AddUpdatedFld(convSqlViewFld.TabRelationText);
}
else if (strAttributeName  ==  convSqlViewFld.FldId)
{
mstrFldId = value.ToString();
 AddUpdatedFld(convSqlViewFld.FldId);
}
else if (strAttributeName  ==  convSqlViewFld.FldName)
{
mstrFldName = value.ToString();
 AddUpdatedFld(convSqlViewFld.FldName);
}
else if (strAttributeName  ==  convSqlViewFld.FldCnName)
{
mstrFldCnName = value.ToString();
 AddUpdatedFld(convSqlViewFld.FldCnName);
}
else if (strAttributeName  ==  convSqlViewFld.FldExpression)
{
mstrFldExpression = value.ToString();
 AddUpdatedFld(convSqlViewFld.FldExpression);
}
else if (strAttributeName  ==  convSqlViewFld.FieldAliases)
{
mstrFieldAliases = value.ToString();
 AddUpdatedFld(convSqlViewFld.FieldAliases);
}
else if (strAttributeName  ==  convSqlViewFld.Filters)
{
mstrFilters = value.ToString();
 AddUpdatedFld(convSqlViewFld.Filters);
}
else if (strAttributeName  ==  convSqlViewFld.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convSqlViewFld.OrderNum);
}
else if (strAttributeName  ==  convSqlViewFld.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convSqlViewFld.PrjId);
}
else if (strAttributeName  ==  convSqlViewFld.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convSqlViewFld.UpdDate);
}
else if (strAttributeName  ==  convSqlViewFld.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convSqlViewFld.UpdUserId);
}
else if (strAttributeName  ==  convSqlViewFld.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convSqlViewFld.Memo);
}
else if (strAttributeName  ==  convSqlViewFld.RelaTabId4SqlView)
{
mstrRelaTabId4SqlView = value.ToString();
 AddUpdatedFld(convSqlViewFld.RelaTabId4SqlView);
}
}
}
public object this[int intIndex]
{
get
{
if (convSqlViewFld.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (convSqlViewFld.SqlViewId  ==  _AttributeName[intIndex])
{
return mstrSqlViewId;
}
else if (convSqlViewFld.SqlViewName  ==  _AttributeName[intIndex])
{
return mstrSqlViewName;
}
else if (convSqlViewFld.SqlViewCNName  ==  _AttributeName[intIndex])
{
return mstrSqlViewCNName;
}
else if (convSqlViewFld.RelaTabId  ==  _AttributeName[intIndex])
{
return mstrRelaTabId;
}
else if (convSqlViewFld.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (convSqlViewFld.TabName  ==  _AttributeName[intIndex])
{
return mstrTabName;
}
else if (convSqlViewFld.TabCnName  ==  _AttributeName[intIndex])
{
return mstrTabCnName;
}
else if (convSqlViewFld.TabAliases  ==  _AttributeName[intIndex])
{
return mstrTabAliases;
}
else if (convSqlViewFld.TabRelationText  ==  _AttributeName[intIndex])
{
return mstrTabRelationText;
}
else if (convSqlViewFld.FldId  ==  _AttributeName[intIndex])
{
return mstrFldId;
}
else if (convSqlViewFld.FldName  ==  _AttributeName[intIndex])
{
return mstrFldName;
}
else if (convSqlViewFld.FldCnName  ==  _AttributeName[intIndex])
{
return mstrFldCnName;
}
else if (convSqlViewFld.FldExpression  ==  _AttributeName[intIndex])
{
return mstrFldExpression;
}
else if (convSqlViewFld.FieldAliases  ==  _AttributeName[intIndex])
{
return mstrFieldAliases;
}
else if (convSqlViewFld.Filters  ==  _AttributeName[intIndex])
{
return mstrFilters;
}
else if (convSqlViewFld.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convSqlViewFld.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convSqlViewFld.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convSqlViewFld.UpdUserId  ==  _AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convSqlViewFld.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (convSqlViewFld.RelaTabId4SqlView  ==  _AttributeName[intIndex])
{
return mstrRelaTabId4SqlView;
}
return null;
}
set
{
if (convSqlViewFld.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convSqlViewFld.mId);
}
else if (convSqlViewFld.SqlViewId  ==  _AttributeName[intIndex])
{
mstrSqlViewId = value.ToString();
 AddUpdatedFld(convSqlViewFld.SqlViewId);
}
else if (convSqlViewFld.SqlViewName  ==  _AttributeName[intIndex])
{
mstrSqlViewName = value.ToString();
 AddUpdatedFld(convSqlViewFld.SqlViewName);
}
else if (convSqlViewFld.SqlViewCNName  ==  _AttributeName[intIndex])
{
mstrSqlViewCNName = value.ToString();
 AddUpdatedFld(convSqlViewFld.SqlViewCNName);
}
else if (convSqlViewFld.RelaTabId  ==  _AttributeName[intIndex])
{
mstrRelaTabId = value.ToString();
 AddUpdatedFld(convSqlViewFld.RelaTabId);
}
else if (convSqlViewFld.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(convSqlViewFld.TabId);
}
else if (convSqlViewFld.TabName  ==  _AttributeName[intIndex])
{
mstrTabName = value.ToString();
 AddUpdatedFld(convSqlViewFld.TabName);
}
else if (convSqlViewFld.TabCnName  ==  _AttributeName[intIndex])
{
mstrTabCnName = value.ToString();
 AddUpdatedFld(convSqlViewFld.TabCnName);
}
else if (convSqlViewFld.TabAliases  ==  _AttributeName[intIndex])
{
mstrTabAliases = value.ToString();
 AddUpdatedFld(convSqlViewFld.TabAliases);
}
else if (convSqlViewFld.TabRelationText  ==  _AttributeName[intIndex])
{
mstrTabRelationText = value.ToString();
 AddUpdatedFld(convSqlViewFld.TabRelationText);
}
else if (convSqlViewFld.FldId  ==  _AttributeName[intIndex])
{
mstrFldId = value.ToString();
 AddUpdatedFld(convSqlViewFld.FldId);
}
else if (convSqlViewFld.FldName  ==  _AttributeName[intIndex])
{
mstrFldName = value.ToString();
 AddUpdatedFld(convSqlViewFld.FldName);
}
else if (convSqlViewFld.FldCnName  ==  _AttributeName[intIndex])
{
mstrFldCnName = value.ToString();
 AddUpdatedFld(convSqlViewFld.FldCnName);
}
else if (convSqlViewFld.FldExpression  ==  _AttributeName[intIndex])
{
mstrFldExpression = value.ToString();
 AddUpdatedFld(convSqlViewFld.FldExpression);
}
else if (convSqlViewFld.FieldAliases  ==  _AttributeName[intIndex])
{
mstrFieldAliases = value.ToString();
 AddUpdatedFld(convSqlViewFld.FieldAliases);
}
else if (convSqlViewFld.Filters  ==  _AttributeName[intIndex])
{
mstrFilters = value.ToString();
 AddUpdatedFld(convSqlViewFld.Filters);
}
else if (convSqlViewFld.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convSqlViewFld.OrderNum);
}
else if (convSqlViewFld.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convSqlViewFld.PrjId);
}
else if (convSqlViewFld.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convSqlViewFld.UpdDate);
}
else if (convSqlViewFld.UpdUserId  ==  _AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convSqlViewFld.UpdUserId);
}
else if (convSqlViewFld.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convSqlViewFld.Memo);
}
else if (convSqlViewFld.RelaTabId4SqlView  ==  _AttributeName[intIndex])
{
mstrRelaTabId4SqlView = value.ToString();
 AddUpdatedFld(convSqlViewFld.RelaTabId4SqlView);
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
 AddUpdatedFld(convSqlViewFld.mId);
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
 AddUpdatedFld(convSqlViewFld.SqlViewId);
}
}
/// <summary>
/// 数据视图名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SqlViewName
{
get
{
return mstrSqlViewName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSqlViewName = value;
}
else
{
 mstrSqlViewName = value;
}
//记录修改过的字段
 AddUpdatedFld(convSqlViewFld.SqlViewName);
}
}
/// <summary>
/// Sql视图中文名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SqlViewCNName
{
get
{
return mstrSqlViewCNName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSqlViewCNName = value;
}
else
{
 mstrSqlViewCNName = value;
}
//记录修改过的字段
 AddUpdatedFld(convSqlViewFld.SqlViewCNName);
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
 AddUpdatedFld(convSqlViewFld.RelaTabId);
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
 AddUpdatedFld(convSqlViewFld.TabId);
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
 AddUpdatedFld(convSqlViewFld.TabName);
}
}
/// <summary>
/// 表中文名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabCnName
{
get
{
return mstrTabCnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabCnName = value;
}
else
{
 mstrTabCnName = value;
}
//记录修改过的字段
 AddUpdatedFld(convSqlViewFld.TabCnName);
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
 AddUpdatedFld(convSqlViewFld.TabAliases);
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
 AddUpdatedFld(convSqlViewFld.TabRelationText);
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
 AddUpdatedFld(convSqlViewFld.FldId);
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
 AddUpdatedFld(convSqlViewFld.FldName);
}
}
/// <summary>
/// 字段中文详名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FldCnName
{
get
{
return mstrFldCnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldCnName = value;
}
else
{
 mstrFldCnName = value;
}
//记录修改过的字段
 AddUpdatedFld(convSqlViewFld.FldCnName);
}
}
/// <summary>
/// 字段表达式(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FldExpression
{
get
{
return mstrFldExpression;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldExpression = value;
}
else
{
 mstrFldExpression = value;
}
//记录修改过的字段
 AddUpdatedFld(convSqlViewFld.FldExpression);
}
}
/// <summary>
/// 字段别名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FieldAliases
{
get
{
return mstrFieldAliases;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFieldAliases = value;
}
else
{
 mstrFieldAliases = value;
}
//记录修改过的字段
 AddUpdatedFld(convSqlViewFld.FieldAliases);
}
}
/// <summary>
/// 筛选器(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Filters
{
get
{
return mstrFilters;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFilters = value;
}
else
{
 mstrFilters = value;
}
//记录修改过的字段
 AddUpdatedFld(convSqlViewFld.Filters);
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
 AddUpdatedFld(convSqlViewFld.OrderNum);
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
 AddUpdatedFld(convSqlViewFld.PrjId);
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
 AddUpdatedFld(convSqlViewFld.UpdDate);
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
 AddUpdatedFld(convSqlViewFld.UpdUserId);
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
 AddUpdatedFld(convSqlViewFld.Memo);
}
}
/// <summary>
/// RelaTabId4SqlView(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RelaTabId4SqlView
{
get
{
return mstrRelaTabId4SqlView;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRelaTabId4SqlView = value;
}
else
{
 mstrRelaTabId4SqlView = value;
}
//记录修改过的字段
 AddUpdatedFld(convSqlViewFld.RelaTabId4SqlView);
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
 /// vSql视图字段(vSqlViewFld)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convSqlViewFld
{
public const string _CurrTabName = "vSqlViewFld"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "SqlViewId", "SqlViewName", "SqlViewCNName", "RelaTabId", "TabId", "TabName", "TabCnName", "TabAliases", "TabRelationText", "FldId", "FldName", "FldCnName", "FldExpression", "FieldAliases", "Filters", "OrderNum", "PrjId", "UpdDate", "UpdUserId", "Memo", "RelaTabId4SqlView"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"SqlViewId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SqlViewId = "SqlViewId";    //Sql视图Id

 /// <summary>
 /// 常量:"SqlViewName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SqlViewName = "SqlViewName";    //数据视图名称

 /// <summary>
 /// 常量:"SqlViewCNName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SqlViewCNName = "SqlViewCNName";    //Sql视图中文名

 /// <summary>
 /// 常量:"RelaTabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RelaTabId = "RelaTabId";    //相关表Id

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
 /// 常量:"TabCnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabCnName = "TabCnName";    //表中文名

 /// <summary>
 /// 常量:"TabAliases"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabAliases = "TabAliases";    //表别名

 /// <summary>
 /// 常量:"TabRelationText"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabRelationText = "TabRelationText";    //表关系文本

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
 /// 常量:"FldCnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldCnName = "FldCnName";    //字段中文详名

 /// <summary>
 /// 常量:"FldExpression"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldExpression = "FldExpression";    //字段表达式

 /// <summary>
 /// 常量:"FieldAliases"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FieldAliases = "FieldAliases";    //字段别名

 /// <summary>
 /// 常量:"Filters"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Filters = "Filters";    //筛选器

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

 /// <summary>
 /// 常量:"RelaTabId4SqlView"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RelaTabId4SqlView = "RelaTabId4SqlView";    //RelaTabId4SqlView
}

}