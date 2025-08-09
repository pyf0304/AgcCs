
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSqlViewRelaTabEN
 表名:vSqlViewRelaTab(00050251)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:11:22
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
 /// 表vSqlViewRelaTab的关键字(RelaTabId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_RelaTabId_vSqlViewRelaTab
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
public K_RelaTabId_vSqlViewRelaTab(string strRelaTabId)
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
 /// <returns>返回:[K_RelaTabId_vSqlViewRelaTab]类型的对象</returns>
public static implicit operator K_RelaTabId_vSqlViewRelaTab(string value)
{
return new K_RelaTabId_vSqlViewRelaTab(value);
}
}
 /// <summary>
 /// vSql视图相关(vSqlViewRelaTab)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvSqlViewRelaTabEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vSqlViewRelaTab"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "RelaTabId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 27;
public static string[] _AttributeName = new string[] {"RelaTabId", "SqlViewId", "SqlViewCNName", "SqlViewName", "TabId", "TabName", "TabCnName", "TabAliases", "SvRelaTabTypeName", "SvRelaTabTypeId", "TabRelationTypeId", "TabRelationTypeName", "TabRelationText", "OrderNum", "OtherFldCnName", "OtherFldName", "OtherTabName", "RelaFldCnName", "RelaFldName", "RelaFldId", "OtherFldId", "OtherTabId", "PrjId", "UpdDate", "UpdUserId", "Memo", "RelaTabId4SqlView"};

protected string mstrRelaTabId;    //相关表Id
protected string mstrSqlViewId;    //Sql视图Id
protected string mstrSqlViewCNName;    //Sql视图中文名
protected string mstrSqlViewName;    //数据视图名称
protected string mstrTabId;    //表ID
protected string mstrTabName;    //表名
protected string mstrTabCnName;    //表中文名
protected string mstrTabAliases;    //表别名
protected string mstrSvRelaTabTypeName;    //Sql视图相关表类型名
protected string mstrSvRelaTabTypeId;    //Sql视图相关表类型Id
protected string mstrTabRelationTypeId;    //表关系类型Id
protected string mstrTabRelationTypeName;    //表关系类型名
protected string mstrTabRelationText;    //表关系文本
protected int mintOrderNum;    //序号
protected string mstrOtherFldCnName;    //他表字段中文名
protected string mstrOtherFldName;    //他表字段名
protected string mstrOtherTabName;    //他表名
protected string mstrRelaFldCnName;    //关系字段中文名
protected string mstrRelaFldName;    //关系字段名
protected string mstrRelaFldId;    //关系字段
protected string mstrOtherFldId;    //其他表字段
protected string mstrOtherTabId;    //其他表Id
protected string mstrPrjId;    //工程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //说明
protected string mstrRelaTabId4SqlView;    //RelaTabId4SqlView

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvSqlViewRelaTabEN()
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
public clsvSqlViewRelaTabEN(string strRelaTabId)
 {
strRelaTabId = strRelaTabId.Replace("'", "''");
if (strRelaTabId.Length > 8)
{
throw new Exception("在表:vSqlViewRelaTab中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strRelaTabId)  ==  true)
{
throw new Exception("在表:vSqlViewRelaTab中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convSqlViewRelaTab.RelaTabId)
{
return mstrRelaTabId;
}
else if (strAttributeName  ==  convSqlViewRelaTab.SqlViewId)
{
return mstrSqlViewId;
}
else if (strAttributeName  ==  convSqlViewRelaTab.SqlViewCNName)
{
return mstrSqlViewCNName;
}
else if (strAttributeName  ==  convSqlViewRelaTab.SqlViewName)
{
return mstrSqlViewName;
}
else if (strAttributeName  ==  convSqlViewRelaTab.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  convSqlViewRelaTab.TabName)
{
return mstrTabName;
}
else if (strAttributeName  ==  convSqlViewRelaTab.TabCnName)
{
return mstrTabCnName;
}
else if (strAttributeName  ==  convSqlViewRelaTab.TabAliases)
{
return mstrTabAliases;
}
else if (strAttributeName  ==  convSqlViewRelaTab.SvRelaTabTypeName)
{
return mstrSvRelaTabTypeName;
}
else if (strAttributeName  ==  convSqlViewRelaTab.SvRelaTabTypeId)
{
return mstrSvRelaTabTypeId;
}
else if (strAttributeName  ==  convSqlViewRelaTab.TabRelationTypeId)
{
return mstrTabRelationTypeId;
}
else if (strAttributeName  ==  convSqlViewRelaTab.TabRelationTypeName)
{
return mstrTabRelationTypeName;
}
else if (strAttributeName  ==  convSqlViewRelaTab.TabRelationText)
{
return mstrTabRelationText;
}
else if (strAttributeName  ==  convSqlViewRelaTab.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convSqlViewRelaTab.OtherFldCnName)
{
return mstrOtherFldCnName;
}
else if (strAttributeName  ==  convSqlViewRelaTab.OtherFldName)
{
return mstrOtherFldName;
}
else if (strAttributeName  ==  convSqlViewRelaTab.OtherTabName)
{
return mstrOtherTabName;
}
else if (strAttributeName  ==  convSqlViewRelaTab.RelaFldCnName)
{
return mstrRelaFldCnName;
}
else if (strAttributeName  ==  convSqlViewRelaTab.RelaFldName)
{
return mstrRelaFldName;
}
else if (strAttributeName  ==  convSqlViewRelaTab.RelaFldId)
{
return mstrRelaFldId;
}
else if (strAttributeName  ==  convSqlViewRelaTab.OtherFldId)
{
return mstrOtherFldId;
}
else if (strAttributeName  ==  convSqlViewRelaTab.OtherTabId)
{
return mstrOtherTabId;
}
else if (strAttributeName  ==  convSqlViewRelaTab.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convSqlViewRelaTab.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convSqlViewRelaTab.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convSqlViewRelaTab.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convSqlViewRelaTab.RelaTabId4SqlView)
{
return mstrRelaTabId4SqlView;
}
return null;
}
set
{
if (strAttributeName  ==  convSqlViewRelaTab.RelaTabId)
{
mstrRelaTabId = value.ToString();
 AddUpdatedFld(convSqlViewRelaTab.RelaTabId);
}
else if (strAttributeName  ==  convSqlViewRelaTab.SqlViewId)
{
mstrSqlViewId = value.ToString();
 AddUpdatedFld(convSqlViewRelaTab.SqlViewId);
}
else if (strAttributeName  ==  convSqlViewRelaTab.SqlViewCNName)
{
mstrSqlViewCNName = value.ToString();
 AddUpdatedFld(convSqlViewRelaTab.SqlViewCNName);
}
else if (strAttributeName  ==  convSqlViewRelaTab.SqlViewName)
{
mstrSqlViewName = value.ToString();
 AddUpdatedFld(convSqlViewRelaTab.SqlViewName);
}
else if (strAttributeName  ==  convSqlViewRelaTab.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(convSqlViewRelaTab.TabId);
}
else if (strAttributeName  ==  convSqlViewRelaTab.TabName)
{
mstrTabName = value.ToString();
 AddUpdatedFld(convSqlViewRelaTab.TabName);
}
else if (strAttributeName  ==  convSqlViewRelaTab.TabCnName)
{
mstrTabCnName = value.ToString();
 AddUpdatedFld(convSqlViewRelaTab.TabCnName);
}
else if (strAttributeName  ==  convSqlViewRelaTab.TabAliases)
{
mstrTabAliases = value.ToString();
 AddUpdatedFld(convSqlViewRelaTab.TabAliases);
}
else if (strAttributeName  ==  convSqlViewRelaTab.SvRelaTabTypeName)
{
mstrSvRelaTabTypeName = value.ToString();
 AddUpdatedFld(convSqlViewRelaTab.SvRelaTabTypeName);
}
else if (strAttributeName  ==  convSqlViewRelaTab.SvRelaTabTypeId)
{
mstrSvRelaTabTypeId = value.ToString();
 AddUpdatedFld(convSqlViewRelaTab.SvRelaTabTypeId);
}
else if (strAttributeName  ==  convSqlViewRelaTab.TabRelationTypeId)
{
mstrTabRelationTypeId = value.ToString();
 AddUpdatedFld(convSqlViewRelaTab.TabRelationTypeId);
}
else if (strAttributeName  ==  convSqlViewRelaTab.TabRelationTypeName)
{
mstrTabRelationTypeName = value.ToString();
 AddUpdatedFld(convSqlViewRelaTab.TabRelationTypeName);
}
else if (strAttributeName  ==  convSqlViewRelaTab.TabRelationText)
{
mstrTabRelationText = value.ToString();
 AddUpdatedFld(convSqlViewRelaTab.TabRelationText);
}
else if (strAttributeName  ==  convSqlViewRelaTab.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convSqlViewRelaTab.OrderNum);
}
else if (strAttributeName  ==  convSqlViewRelaTab.OtherFldCnName)
{
mstrOtherFldCnName = value.ToString();
 AddUpdatedFld(convSqlViewRelaTab.OtherFldCnName);
}
else if (strAttributeName  ==  convSqlViewRelaTab.OtherFldName)
{
mstrOtherFldName = value.ToString();
 AddUpdatedFld(convSqlViewRelaTab.OtherFldName);
}
else if (strAttributeName  ==  convSqlViewRelaTab.OtherTabName)
{
mstrOtherTabName = value.ToString();
 AddUpdatedFld(convSqlViewRelaTab.OtherTabName);
}
else if (strAttributeName  ==  convSqlViewRelaTab.RelaFldCnName)
{
mstrRelaFldCnName = value.ToString();
 AddUpdatedFld(convSqlViewRelaTab.RelaFldCnName);
}
else if (strAttributeName  ==  convSqlViewRelaTab.RelaFldName)
{
mstrRelaFldName = value.ToString();
 AddUpdatedFld(convSqlViewRelaTab.RelaFldName);
}
else if (strAttributeName  ==  convSqlViewRelaTab.RelaFldId)
{
mstrRelaFldId = value.ToString();
 AddUpdatedFld(convSqlViewRelaTab.RelaFldId);
}
else if (strAttributeName  ==  convSqlViewRelaTab.OtherFldId)
{
mstrOtherFldId = value.ToString();
 AddUpdatedFld(convSqlViewRelaTab.OtherFldId);
}
else if (strAttributeName  ==  convSqlViewRelaTab.OtherTabId)
{
mstrOtherTabId = value.ToString();
 AddUpdatedFld(convSqlViewRelaTab.OtherTabId);
}
else if (strAttributeName  ==  convSqlViewRelaTab.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convSqlViewRelaTab.PrjId);
}
else if (strAttributeName  ==  convSqlViewRelaTab.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convSqlViewRelaTab.UpdDate);
}
else if (strAttributeName  ==  convSqlViewRelaTab.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convSqlViewRelaTab.UpdUserId);
}
else if (strAttributeName  ==  convSqlViewRelaTab.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convSqlViewRelaTab.Memo);
}
else if (strAttributeName  ==  convSqlViewRelaTab.RelaTabId4SqlView)
{
mstrRelaTabId4SqlView = value.ToString();
 AddUpdatedFld(convSqlViewRelaTab.RelaTabId4SqlView);
}
}
}
public object this[int intIndex]
{
get
{
if (convSqlViewRelaTab.RelaTabId  ==  _AttributeName[intIndex])
{
return mstrRelaTabId;
}
else if (convSqlViewRelaTab.SqlViewId  ==  _AttributeName[intIndex])
{
return mstrSqlViewId;
}
else if (convSqlViewRelaTab.SqlViewCNName  ==  _AttributeName[intIndex])
{
return mstrSqlViewCNName;
}
else if (convSqlViewRelaTab.SqlViewName  ==  _AttributeName[intIndex])
{
return mstrSqlViewName;
}
else if (convSqlViewRelaTab.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (convSqlViewRelaTab.TabName  ==  _AttributeName[intIndex])
{
return mstrTabName;
}
else if (convSqlViewRelaTab.TabCnName  ==  _AttributeName[intIndex])
{
return mstrTabCnName;
}
else if (convSqlViewRelaTab.TabAliases  ==  _AttributeName[intIndex])
{
return mstrTabAliases;
}
else if (convSqlViewRelaTab.SvRelaTabTypeName  ==  _AttributeName[intIndex])
{
return mstrSvRelaTabTypeName;
}
else if (convSqlViewRelaTab.SvRelaTabTypeId  ==  _AttributeName[intIndex])
{
return mstrSvRelaTabTypeId;
}
else if (convSqlViewRelaTab.TabRelationTypeId  ==  _AttributeName[intIndex])
{
return mstrTabRelationTypeId;
}
else if (convSqlViewRelaTab.TabRelationTypeName  ==  _AttributeName[intIndex])
{
return mstrTabRelationTypeName;
}
else if (convSqlViewRelaTab.TabRelationText  ==  _AttributeName[intIndex])
{
return mstrTabRelationText;
}
else if (convSqlViewRelaTab.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convSqlViewRelaTab.OtherFldCnName  ==  _AttributeName[intIndex])
{
return mstrOtherFldCnName;
}
else if (convSqlViewRelaTab.OtherFldName  ==  _AttributeName[intIndex])
{
return mstrOtherFldName;
}
else if (convSqlViewRelaTab.OtherTabName  ==  _AttributeName[intIndex])
{
return mstrOtherTabName;
}
else if (convSqlViewRelaTab.RelaFldCnName  ==  _AttributeName[intIndex])
{
return mstrRelaFldCnName;
}
else if (convSqlViewRelaTab.RelaFldName  ==  _AttributeName[intIndex])
{
return mstrRelaFldName;
}
else if (convSqlViewRelaTab.RelaFldId  ==  _AttributeName[intIndex])
{
return mstrRelaFldId;
}
else if (convSqlViewRelaTab.OtherFldId  ==  _AttributeName[intIndex])
{
return mstrOtherFldId;
}
else if (convSqlViewRelaTab.OtherTabId  ==  _AttributeName[intIndex])
{
return mstrOtherTabId;
}
else if (convSqlViewRelaTab.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convSqlViewRelaTab.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convSqlViewRelaTab.UpdUserId  ==  _AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convSqlViewRelaTab.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (convSqlViewRelaTab.RelaTabId4SqlView  ==  _AttributeName[intIndex])
{
return mstrRelaTabId4SqlView;
}
return null;
}
set
{
if (convSqlViewRelaTab.RelaTabId  ==  _AttributeName[intIndex])
{
mstrRelaTabId = value.ToString();
 AddUpdatedFld(convSqlViewRelaTab.RelaTabId);
}
else if (convSqlViewRelaTab.SqlViewId  ==  _AttributeName[intIndex])
{
mstrSqlViewId = value.ToString();
 AddUpdatedFld(convSqlViewRelaTab.SqlViewId);
}
else if (convSqlViewRelaTab.SqlViewCNName  ==  _AttributeName[intIndex])
{
mstrSqlViewCNName = value.ToString();
 AddUpdatedFld(convSqlViewRelaTab.SqlViewCNName);
}
else if (convSqlViewRelaTab.SqlViewName  ==  _AttributeName[intIndex])
{
mstrSqlViewName = value.ToString();
 AddUpdatedFld(convSqlViewRelaTab.SqlViewName);
}
else if (convSqlViewRelaTab.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(convSqlViewRelaTab.TabId);
}
else if (convSqlViewRelaTab.TabName  ==  _AttributeName[intIndex])
{
mstrTabName = value.ToString();
 AddUpdatedFld(convSqlViewRelaTab.TabName);
}
else if (convSqlViewRelaTab.TabCnName  ==  _AttributeName[intIndex])
{
mstrTabCnName = value.ToString();
 AddUpdatedFld(convSqlViewRelaTab.TabCnName);
}
else if (convSqlViewRelaTab.TabAliases  ==  _AttributeName[intIndex])
{
mstrTabAliases = value.ToString();
 AddUpdatedFld(convSqlViewRelaTab.TabAliases);
}
else if (convSqlViewRelaTab.SvRelaTabTypeName  ==  _AttributeName[intIndex])
{
mstrSvRelaTabTypeName = value.ToString();
 AddUpdatedFld(convSqlViewRelaTab.SvRelaTabTypeName);
}
else if (convSqlViewRelaTab.SvRelaTabTypeId  ==  _AttributeName[intIndex])
{
mstrSvRelaTabTypeId = value.ToString();
 AddUpdatedFld(convSqlViewRelaTab.SvRelaTabTypeId);
}
else if (convSqlViewRelaTab.TabRelationTypeId  ==  _AttributeName[intIndex])
{
mstrTabRelationTypeId = value.ToString();
 AddUpdatedFld(convSqlViewRelaTab.TabRelationTypeId);
}
else if (convSqlViewRelaTab.TabRelationTypeName  ==  _AttributeName[intIndex])
{
mstrTabRelationTypeName = value.ToString();
 AddUpdatedFld(convSqlViewRelaTab.TabRelationTypeName);
}
else if (convSqlViewRelaTab.TabRelationText  ==  _AttributeName[intIndex])
{
mstrTabRelationText = value.ToString();
 AddUpdatedFld(convSqlViewRelaTab.TabRelationText);
}
else if (convSqlViewRelaTab.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convSqlViewRelaTab.OrderNum);
}
else if (convSqlViewRelaTab.OtherFldCnName  ==  _AttributeName[intIndex])
{
mstrOtherFldCnName = value.ToString();
 AddUpdatedFld(convSqlViewRelaTab.OtherFldCnName);
}
else if (convSqlViewRelaTab.OtherFldName  ==  _AttributeName[intIndex])
{
mstrOtherFldName = value.ToString();
 AddUpdatedFld(convSqlViewRelaTab.OtherFldName);
}
else if (convSqlViewRelaTab.OtherTabName  ==  _AttributeName[intIndex])
{
mstrOtherTabName = value.ToString();
 AddUpdatedFld(convSqlViewRelaTab.OtherTabName);
}
else if (convSqlViewRelaTab.RelaFldCnName  ==  _AttributeName[intIndex])
{
mstrRelaFldCnName = value.ToString();
 AddUpdatedFld(convSqlViewRelaTab.RelaFldCnName);
}
else if (convSqlViewRelaTab.RelaFldName  ==  _AttributeName[intIndex])
{
mstrRelaFldName = value.ToString();
 AddUpdatedFld(convSqlViewRelaTab.RelaFldName);
}
else if (convSqlViewRelaTab.RelaFldId  ==  _AttributeName[intIndex])
{
mstrRelaFldId = value.ToString();
 AddUpdatedFld(convSqlViewRelaTab.RelaFldId);
}
else if (convSqlViewRelaTab.OtherFldId  ==  _AttributeName[intIndex])
{
mstrOtherFldId = value.ToString();
 AddUpdatedFld(convSqlViewRelaTab.OtherFldId);
}
else if (convSqlViewRelaTab.OtherTabId  ==  _AttributeName[intIndex])
{
mstrOtherTabId = value.ToString();
 AddUpdatedFld(convSqlViewRelaTab.OtherTabId);
}
else if (convSqlViewRelaTab.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convSqlViewRelaTab.PrjId);
}
else if (convSqlViewRelaTab.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convSqlViewRelaTab.UpdDate);
}
else if (convSqlViewRelaTab.UpdUserId  ==  _AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convSqlViewRelaTab.UpdUserId);
}
else if (convSqlViewRelaTab.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convSqlViewRelaTab.Memo);
}
else if (convSqlViewRelaTab.RelaTabId4SqlView  ==  _AttributeName[intIndex])
{
mstrRelaTabId4SqlView = value.ToString();
 AddUpdatedFld(convSqlViewRelaTab.RelaTabId4SqlView);
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
 AddUpdatedFld(convSqlViewRelaTab.RelaTabId);
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
 AddUpdatedFld(convSqlViewRelaTab.SqlViewId);
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
 AddUpdatedFld(convSqlViewRelaTab.SqlViewCNName);
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
 AddUpdatedFld(convSqlViewRelaTab.SqlViewName);
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
 AddUpdatedFld(convSqlViewRelaTab.TabId);
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
 AddUpdatedFld(convSqlViewRelaTab.TabName);
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
 AddUpdatedFld(convSqlViewRelaTab.TabCnName);
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
 AddUpdatedFld(convSqlViewRelaTab.TabAliases);
}
}
/// <summary>
/// Sql视图相关表类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SvRelaTabTypeName
{
get
{
return mstrSvRelaTabTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSvRelaTabTypeName = value;
}
else
{
 mstrSvRelaTabTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convSqlViewRelaTab.SvRelaTabTypeName);
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
 AddUpdatedFld(convSqlViewRelaTab.SvRelaTabTypeId);
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
 AddUpdatedFld(convSqlViewRelaTab.TabRelationTypeId);
}
}
/// <summary>
/// 表关系类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabRelationTypeName
{
get
{
return mstrTabRelationTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabRelationTypeName = value;
}
else
{
 mstrTabRelationTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convSqlViewRelaTab.TabRelationTypeName);
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
 AddUpdatedFld(convSqlViewRelaTab.TabRelationText);
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
 AddUpdatedFld(convSqlViewRelaTab.OrderNum);
}
}
/// <summary>
/// 他表字段中文名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OtherFldCnName
{
get
{
return mstrOtherFldCnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOtherFldCnName = value;
}
else
{
 mstrOtherFldCnName = value;
}
//记录修改过的字段
 AddUpdatedFld(convSqlViewRelaTab.OtherFldCnName);
}
}
/// <summary>
/// 他表字段名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OtherFldName
{
get
{
return mstrOtherFldName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOtherFldName = value;
}
else
{
 mstrOtherFldName = value;
}
//记录修改过的字段
 AddUpdatedFld(convSqlViewRelaTab.OtherFldName);
}
}
/// <summary>
/// 他表名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OtherTabName
{
get
{
return mstrOtherTabName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOtherTabName = value;
}
else
{
 mstrOtherTabName = value;
}
//记录修改过的字段
 AddUpdatedFld(convSqlViewRelaTab.OtherTabName);
}
}
/// <summary>
/// 关系字段中文名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RelaFldCnName
{
get
{
return mstrRelaFldCnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRelaFldCnName = value;
}
else
{
 mstrRelaFldCnName = value;
}
//记录修改过的字段
 AddUpdatedFld(convSqlViewRelaTab.RelaFldCnName);
}
}
/// <summary>
/// 关系字段名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RelaFldName
{
get
{
return mstrRelaFldName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRelaFldName = value;
}
else
{
 mstrRelaFldName = value;
}
//记录修改过的字段
 AddUpdatedFld(convSqlViewRelaTab.RelaFldName);
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
 AddUpdatedFld(convSqlViewRelaTab.RelaFldId);
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
 AddUpdatedFld(convSqlViewRelaTab.OtherFldId);
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
 AddUpdatedFld(convSqlViewRelaTab.OtherTabId);
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
 AddUpdatedFld(convSqlViewRelaTab.PrjId);
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
 AddUpdatedFld(convSqlViewRelaTab.UpdDate);
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
 AddUpdatedFld(convSqlViewRelaTab.UpdUserId);
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
 AddUpdatedFld(convSqlViewRelaTab.Memo);
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
 AddUpdatedFld(convSqlViewRelaTab.RelaTabId4SqlView);
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
 /// vSql视图相关(vSqlViewRelaTab)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convSqlViewRelaTab
{
public const string _CurrTabName = "vSqlViewRelaTab"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "RelaTabId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"RelaTabId", "SqlViewId", "SqlViewCNName", "SqlViewName", "TabId", "TabName", "TabCnName", "TabAliases", "SvRelaTabTypeName", "SvRelaTabTypeId", "TabRelationTypeId", "TabRelationTypeName", "TabRelationText", "OrderNum", "OtherFldCnName", "OtherFldName", "OtherTabName", "RelaFldCnName", "RelaFldName", "RelaFldId", "OtherFldId", "OtherTabId", "PrjId", "UpdDate", "UpdUserId", "Memo", "RelaTabId4SqlView"};
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
 /// 常量:"SqlViewCNName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SqlViewCNName = "SqlViewCNName";    //Sql视图中文名

 /// <summary>
 /// 常量:"SqlViewName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SqlViewName = "SqlViewName";    //数据视图名称

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
 /// 常量:"SvRelaTabTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SvRelaTabTypeName = "SvRelaTabTypeName";    //Sql视图相关表类型名

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
 /// 常量:"TabRelationTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabRelationTypeName = "TabRelationTypeName";    //表关系类型名

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
 /// 常量:"OtherFldCnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OtherFldCnName = "OtherFldCnName";    //他表字段中文名

 /// <summary>
 /// 常量:"OtherFldName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OtherFldName = "OtherFldName";    //他表字段名

 /// <summary>
 /// 常量:"OtherTabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OtherTabName = "OtherTabName";    //他表名

 /// <summary>
 /// 常量:"RelaFldCnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RelaFldCnName = "RelaFldCnName";    //关系字段中文名

 /// <summary>
 /// 常量:"RelaFldName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RelaFldName = "RelaFldName";    //关系字段名

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