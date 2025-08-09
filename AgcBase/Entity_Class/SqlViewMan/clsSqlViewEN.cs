
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSqlViewEN
 表名:SqlView(00050245)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:06:54
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
 /// 表SqlView的关键字(SqlViewId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_SqlViewId_SqlView
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strSqlViewId">表关键字</param>
public K_SqlViewId_SqlView(string strSqlViewId)
{
if (IsValid(strSqlViewId)) Value = strSqlViewId;
else
{
Value = null;
}
}
private static bool IsValid(string strSqlViewId)
{
if (string.IsNullOrEmpty(strSqlViewId) == true) return false;
if (strSqlViewId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_SqlViewId_SqlView]类型的对象</returns>
public static implicit operator K_SqlViewId_SqlView(string value)
{
return new K_SqlViewId_SqlView(value);
}
}
 /// <summary>
 /// Sql视图(SqlView)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsSqlViewEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "SqlView"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "SqlViewId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 20;
public static string[] _AttributeName = new string[] {"SqlViewId", "SqlViewText", "SqlViewText4Gene", "TextResouce", "TextResourceTypeId", "RelaTabId", "AnalysisDate", "GeneCodeDate", "CreateDate", "TopPercent", "DistinctFlag", "WhereCondition", "GroupBy", "HavingStr", "OrderBy", "ErrMsg", "PrjId", "UpdDate", "UpdUserId", "Memo"};

protected string mstrSqlViewId;    //Sql视图Id
protected string mstrSqlViewText;    //Sql视图文本内容
protected string mstrSqlViewText4Gene;    //Sql视图文本4生成
protected string mstrTextResouce;    //文本来源
protected string mstrTextResourceTypeId;    //文本来源类型Id
protected string mstrRelaTabId;    //相关表Id
protected string mstrAnalysisDate;    //分析日期
protected string mstrGeneCodeDate;    //生成代码日期
protected string mstrCreateDate;    //建立日期
protected string mstrTopPercent;    //顶百分比
protected string mstrDistinctFlag;    //Distinct标志
protected string mstrWhereCondition;    //条件串
protected string mstrGroupBy;    //分组
protected string mstrHavingStr;    //分组过滤
protected string mstrOrderBy;    //排序
protected string mstrErrMsg;    //错误信息
protected string mstrPrjId;    //工程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsSqlViewEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("SqlViewId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strSqlViewId">关键字:Sql视图Id</param>
public clsSqlViewEN(string strSqlViewId)
 {
strSqlViewId = strSqlViewId.Replace("'", "''");
if (strSqlViewId.Length > 8)
{
throw new Exception("在表:SqlView中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strSqlViewId)  ==  true)
{
throw new Exception("在表:SqlView中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strSqlViewId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrSqlViewId = strSqlViewId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("SqlViewId");
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
if (strAttributeName  ==  conSqlView.SqlViewId)
{
return mstrSqlViewId;
}
else if (strAttributeName  ==  conSqlView.SqlViewText)
{
return mstrSqlViewText;
}
else if (strAttributeName  ==  conSqlView.SqlViewText4Gene)
{
return mstrSqlViewText4Gene;
}
else if (strAttributeName  ==  conSqlView.TextResouce)
{
return mstrTextResouce;
}
else if (strAttributeName  ==  conSqlView.TextResourceTypeId)
{
return mstrTextResourceTypeId;
}
else if (strAttributeName  ==  conSqlView.RelaTabId)
{
return mstrRelaTabId;
}
else if (strAttributeName  ==  conSqlView.AnalysisDate)
{
return mstrAnalysisDate;
}
else if (strAttributeName  ==  conSqlView.GeneCodeDate)
{
return mstrGeneCodeDate;
}
else if (strAttributeName  ==  conSqlView.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  conSqlView.TopPercent)
{
return mstrTopPercent;
}
else if (strAttributeName  ==  conSqlView.DistinctFlag)
{
return mstrDistinctFlag;
}
else if (strAttributeName  ==  conSqlView.WhereCondition)
{
return mstrWhereCondition;
}
else if (strAttributeName  ==  conSqlView.GroupBy)
{
return mstrGroupBy;
}
else if (strAttributeName  ==  conSqlView.HavingStr)
{
return mstrHavingStr;
}
else if (strAttributeName  ==  conSqlView.OrderBy)
{
return mstrOrderBy;
}
else if (strAttributeName  ==  conSqlView.ErrMsg)
{
return mstrErrMsg;
}
else if (strAttributeName  ==  conSqlView.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conSqlView.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conSqlView.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conSqlView.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conSqlView.SqlViewId)
{
mstrSqlViewId = value.ToString();
 AddUpdatedFld(conSqlView.SqlViewId);
}
else if (strAttributeName  ==  conSqlView.SqlViewText)
{
mstrSqlViewText = value.ToString();
 AddUpdatedFld(conSqlView.SqlViewText);
}
else if (strAttributeName  ==  conSqlView.SqlViewText4Gene)
{
mstrSqlViewText4Gene = value.ToString();
 AddUpdatedFld(conSqlView.SqlViewText4Gene);
}
else if (strAttributeName  ==  conSqlView.TextResouce)
{
mstrTextResouce = value.ToString();
 AddUpdatedFld(conSqlView.TextResouce);
}
else if (strAttributeName  ==  conSqlView.TextResourceTypeId)
{
mstrTextResourceTypeId = value.ToString();
 AddUpdatedFld(conSqlView.TextResourceTypeId);
}
else if (strAttributeName  ==  conSqlView.RelaTabId)
{
mstrRelaTabId = value.ToString();
 AddUpdatedFld(conSqlView.RelaTabId);
}
else if (strAttributeName  ==  conSqlView.AnalysisDate)
{
mstrAnalysisDate = value.ToString();
 AddUpdatedFld(conSqlView.AnalysisDate);
}
else if (strAttributeName  ==  conSqlView.GeneCodeDate)
{
mstrGeneCodeDate = value.ToString();
 AddUpdatedFld(conSqlView.GeneCodeDate);
}
else if (strAttributeName  ==  conSqlView.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(conSqlView.CreateDate);
}
else if (strAttributeName  ==  conSqlView.TopPercent)
{
mstrTopPercent = value.ToString();
 AddUpdatedFld(conSqlView.TopPercent);
}
else if (strAttributeName  ==  conSqlView.DistinctFlag)
{
mstrDistinctFlag = value.ToString();
 AddUpdatedFld(conSqlView.DistinctFlag);
}
else if (strAttributeName  ==  conSqlView.WhereCondition)
{
mstrWhereCondition = value.ToString();
 AddUpdatedFld(conSqlView.WhereCondition);
}
else if (strAttributeName  ==  conSqlView.GroupBy)
{
mstrGroupBy = value.ToString();
 AddUpdatedFld(conSqlView.GroupBy);
}
else if (strAttributeName  ==  conSqlView.HavingStr)
{
mstrHavingStr = value.ToString();
 AddUpdatedFld(conSqlView.HavingStr);
}
else if (strAttributeName  ==  conSqlView.OrderBy)
{
mstrOrderBy = value.ToString();
 AddUpdatedFld(conSqlView.OrderBy);
}
else if (strAttributeName  ==  conSqlView.ErrMsg)
{
mstrErrMsg = value.ToString();
 AddUpdatedFld(conSqlView.ErrMsg);
}
else if (strAttributeName  ==  conSqlView.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conSqlView.PrjId);
}
else if (strAttributeName  ==  conSqlView.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conSqlView.UpdDate);
}
else if (strAttributeName  ==  conSqlView.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conSqlView.UpdUserId);
}
else if (strAttributeName  ==  conSqlView.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSqlView.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conSqlView.SqlViewId  ==  _AttributeName[intIndex])
{
return mstrSqlViewId;
}
else if (conSqlView.SqlViewText  ==  _AttributeName[intIndex])
{
return mstrSqlViewText;
}
else if (conSqlView.SqlViewText4Gene  ==  _AttributeName[intIndex])
{
return mstrSqlViewText4Gene;
}
else if (conSqlView.TextResouce  ==  _AttributeName[intIndex])
{
return mstrTextResouce;
}
else if (conSqlView.TextResourceTypeId  ==  _AttributeName[intIndex])
{
return mstrTextResourceTypeId;
}
else if (conSqlView.RelaTabId  ==  _AttributeName[intIndex])
{
return mstrRelaTabId;
}
else if (conSqlView.AnalysisDate  ==  _AttributeName[intIndex])
{
return mstrAnalysisDate;
}
else if (conSqlView.GeneCodeDate  ==  _AttributeName[intIndex])
{
return mstrGeneCodeDate;
}
else if (conSqlView.CreateDate  ==  _AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (conSqlView.TopPercent  ==  _AttributeName[intIndex])
{
return mstrTopPercent;
}
else if (conSqlView.DistinctFlag  ==  _AttributeName[intIndex])
{
return mstrDistinctFlag;
}
else if (conSqlView.WhereCondition  ==  _AttributeName[intIndex])
{
return mstrWhereCondition;
}
else if (conSqlView.GroupBy  ==  _AttributeName[intIndex])
{
return mstrGroupBy;
}
else if (conSqlView.HavingStr  ==  _AttributeName[intIndex])
{
return mstrHavingStr;
}
else if (conSqlView.OrderBy  ==  _AttributeName[intIndex])
{
return mstrOrderBy;
}
else if (conSqlView.ErrMsg  ==  _AttributeName[intIndex])
{
return mstrErrMsg;
}
else if (conSqlView.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conSqlView.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conSqlView.UpdUserId  ==  _AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conSqlView.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conSqlView.SqlViewId  ==  _AttributeName[intIndex])
{
mstrSqlViewId = value.ToString();
 AddUpdatedFld(conSqlView.SqlViewId);
}
else if (conSqlView.SqlViewText  ==  _AttributeName[intIndex])
{
mstrSqlViewText = value.ToString();
 AddUpdatedFld(conSqlView.SqlViewText);
}
else if (conSqlView.SqlViewText4Gene  ==  _AttributeName[intIndex])
{
mstrSqlViewText4Gene = value.ToString();
 AddUpdatedFld(conSqlView.SqlViewText4Gene);
}
else if (conSqlView.TextResouce  ==  _AttributeName[intIndex])
{
mstrTextResouce = value.ToString();
 AddUpdatedFld(conSqlView.TextResouce);
}
else if (conSqlView.TextResourceTypeId  ==  _AttributeName[intIndex])
{
mstrTextResourceTypeId = value.ToString();
 AddUpdatedFld(conSqlView.TextResourceTypeId);
}
else if (conSqlView.RelaTabId  ==  _AttributeName[intIndex])
{
mstrRelaTabId = value.ToString();
 AddUpdatedFld(conSqlView.RelaTabId);
}
else if (conSqlView.AnalysisDate  ==  _AttributeName[intIndex])
{
mstrAnalysisDate = value.ToString();
 AddUpdatedFld(conSqlView.AnalysisDate);
}
else if (conSqlView.GeneCodeDate  ==  _AttributeName[intIndex])
{
mstrGeneCodeDate = value.ToString();
 AddUpdatedFld(conSqlView.GeneCodeDate);
}
else if (conSqlView.CreateDate  ==  _AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(conSqlView.CreateDate);
}
else if (conSqlView.TopPercent  ==  _AttributeName[intIndex])
{
mstrTopPercent = value.ToString();
 AddUpdatedFld(conSqlView.TopPercent);
}
else if (conSqlView.DistinctFlag  ==  _AttributeName[intIndex])
{
mstrDistinctFlag = value.ToString();
 AddUpdatedFld(conSqlView.DistinctFlag);
}
else if (conSqlView.WhereCondition  ==  _AttributeName[intIndex])
{
mstrWhereCondition = value.ToString();
 AddUpdatedFld(conSqlView.WhereCondition);
}
else if (conSqlView.GroupBy  ==  _AttributeName[intIndex])
{
mstrGroupBy = value.ToString();
 AddUpdatedFld(conSqlView.GroupBy);
}
else if (conSqlView.HavingStr  ==  _AttributeName[intIndex])
{
mstrHavingStr = value.ToString();
 AddUpdatedFld(conSqlView.HavingStr);
}
else if (conSqlView.OrderBy  ==  _AttributeName[intIndex])
{
mstrOrderBy = value.ToString();
 AddUpdatedFld(conSqlView.OrderBy);
}
else if (conSqlView.ErrMsg  ==  _AttributeName[intIndex])
{
mstrErrMsg = value.ToString();
 AddUpdatedFld(conSqlView.ErrMsg);
}
else if (conSqlView.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conSqlView.PrjId);
}
else if (conSqlView.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conSqlView.UpdDate);
}
else if (conSqlView.UpdUserId  ==  _AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conSqlView.UpdUserId);
}
else if (conSqlView.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSqlView.Memo);
}
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
 AddUpdatedFld(conSqlView.SqlViewId);
}
}
/// <summary>
/// Sql视图文本内容(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SqlViewText
{
get
{
return mstrSqlViewText;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSqlViewText = value;
}
else
{
 mstrSqlViewText = value;
}
//记录修改过的字段
 AddUpdatedFld(conSqlView.SqlViewText);
}
}
/// <summary>
/// Sql视图文本4生成(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SqlViewText4Gene
{
get
{
return mstrSqlViewText4Gene;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSqlViewText4Gene = value;
}
else
{
 mstrSqlViewText4Gene = value;
}
//记录修改过的字段
 AddUpdatedFld(conSqlView.SqlViewText4Gene);
}
}
/// <summary>
/// 文本来源(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TextResouce
{
get
{
return mstrTextResouce;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTextResouce = value;
}
else
{
 mstrTextResouce = value;
}
//记录修改过的字段
 AddUpdatedFld(conSqlView.TextResouce);
}
}
/// <summary>
/// 文本来源类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TextResourceTypeId
{
get
{
return mstrTextResourceTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTextResourceTypeId = value;
}
else
{
 mstrTextResourceTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSqlView.TextResourceTypeId);
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
 AddUpdatedFld(conSqlView.RelaTabId);
}
}
/// <summary>
/// 分析日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AnalysisDate
{
get
{
return mstrAnalysisDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAnalysisDate = value;
}
else
{
 mstrAnalysisDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conSqlView.AnalysisDate);
}
}
/// <summary>
/// 生成代码日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GeneCodeDate
{
get
{
return mstrGeneCodeDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGeneCodeDate = value;
}
else
{
 mstrGeneCodeDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conSqlView.GeneCodeDate);
}
}
/// <summary>
/// 建立日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CreateDate
{
get
{
return mstrCreateDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCreateDate = value;
}
else
{
 mstrCreateDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conSqlView.CreateDate);
}
}
/// <summary>
/// 顶百分比(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TopPercent
{
get
{
return mstrTopPercent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTopPercent = value;
}
else
{
 mstrTopPercent = value;
}
//记录修改过的字段
 AddUpdatedFld(conSqlView.TopPercent);
}
}
/// <summary>
/// Distinct标志(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DistinctFlag
{
get
{
return mstrDistinctFlag;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDistinctFlag = value;
}
else
{
 mstrDistinctFlag = value;
}
//记录修改过的字段
 AddUpdatedFld(conSqlView.DistinctFlag);
}
}
/// <summary>
/// 条件串(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WhereCondition
{
get
{
return mstrWhereCondition;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWhereCondition = value;
}
else
{
 mstrWhereCondition = value;
}
//记录修改过的字段
 AddUpdatedFld(conSqlView.WhereCondition);
}
}
/// <summary>
/// 分组(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GroupBy
{
get
{
return mstrGroupBy;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGroupBy = value;
}
else
{
 mstrGroupBy = value;
}
//记录修改过的字段
 AddUpdatedFld(conSqlView.GroupBy);
}
}
/// <summary>
/// 分组过滤(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string HavingStr
{
get
{
return mstrHavingStr;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrHavingStr = value;
}
else
{
 mstrHavingStr = value;
}
//记录修改过的字段
 AddUpdatedFld(conSqlView.HavingStr);
}
}
/// <summary>
/// 排序(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OrderBy
{
get
{
return mstrOrderBy;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOrderBy = value;
}
else
{
 mstrOrderBy = value;
}
//记录修改过的字段
 AddUpdatedFld(conSqlView.OrderBy);
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
 AddUpdatedFld(conSqlView.ErrMsg);
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
 AddUpdatedFld(conSqlView.PrjId);
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
 AddUpdatedFld(conSqlView.UpdDate);
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
 AddUpdatedFld(conSqlView.UpdUserId);
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
 AddUpdatedFld(conSqlView.Memo);
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
  return mstrSqlViewId;
 }
 }
}
 /// <summary>
 /// Sql视图(SqlView)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conSqlView
{
public const string _CurrTabName = "SqlView"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "SqlViewId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"SqlViewId", "SqlViewText", "SqlViewText4Gene", "TextResouce", "TextResourceTypeId", "RelaTabId", "AnalysisDate", "GeneCodeDate", "CreateDate", "TopPercent", "DistinctFlag", "WhereCondition", "GroupBy", "HavingStr", "OrderBy", "ErrMsg", "PrjId", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"SqlViewId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SqlViewId = "SqlViewId";    //Sql视图Id

 /// <summary>
 /// 常量:"SqlViewText"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SqlViewText = "SqlViewText";    //Sql视图文本内容

 /// <summary>
 /// 常量:"SqlViewText4Gene"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SqlViewText4Gene = "SqlViewText4Gene";    //Sql视图文本4生成

 /// <summary>
 /// 常量:"TextResouce"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextResouce = "TextResouce";    //文本来源

 /// <summary>
 /// 常量:"TextResourceTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextResourceTypeId = "TextResourceTypeId";    //文本来源类型Id

 /// <summary>
 /// 常量:"RelaTabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RelaTabId = "RelaTabId";    //相关表Id

 /// <summary>
 /// 常量:"AnalysisDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnalysisDate = "AnalysisDate";    //分析日期

 /// <summary>
 /// 常量:"GeneCodeDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GeneCodeDate = "GeneCodeDate";    //生成代码日期

 /// <summary>
 /// 常量:"CreateDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreateDate = "CreateDate";    //建立日期

 /// <summary>
 /// 常量:"TopPercent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopPercent = "TopPercent";    //顶百分比

 /// <summary>
 /// 常量:"DistinctFlag"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DistinctFlag = "DistinctFlag";    //Distinct标志

 /// <summary>
 /// 常量:"WhereCondition"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WhereCondition = "WhereCondition";    //条件串

 /// <summary>
 /// 常量:"GroupBy"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GroupBy = "GroupBy";    //分组

 /// <summary>
 /// 常量:"HavingStr"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string HavingStr = "HavingStr";    //分组过滤

 /// <summary>
 /// 常量:"OrderBy"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderBy = "OrderBy";    //排序

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