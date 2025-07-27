
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:SqlStatement
 表名:SqlStatement(00050296)
 生成代码版本:2021.11.17.1
 生成日期:2021/11/18 02:09:10
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:AGC(0005)
 CM工程:AgcMvc(变量首字母不限定)
 模块中文名:Sql视图管理(SqlViewMan)
 框架-层名:纯粹类(PureClass)
 编程语言:CSharp
 注意:1、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Text; 
using System.Collections; 
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System.Runtime.Serialization;

namespace AGC.PureClass
{
 /// <summary>
 /// Sql语句(SqlStatement)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class SqlStatement 
{
protected const int mintAttributeCount = 22;
public static string[] AttributeName = new string[] {"SqlStatementId", "OperateType", "TabName", "SelectText", "FromText", "WhereCondition", "GroupBy", "HavingStr", "OrderBy", "IntoText", "ValuesText", "UpdateText", "SetText", "DeleteText", "OrderNum4Refer", "SqlStatementText", "ErrMsg", "CreateDate", "AnalysisDate", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量

protected string mstrSqlStatementId;    //Sql语句Id
protected string mstrOperateType;    //操作类型
protected string mstrTabName;    //表名
protected string mstrSelectText;    //Select文本内容
protected string mstrFromText;    //From文本内容
protected string mstrWhereCondition;    //条件串
protected string mstrGroupBy;    //分组
protected string mstrHavingStr;    //分组过滤
protected string mstrOrderBy;    //排序
protected string mstrIntoText;    //Into文本
protected string mstrValuesText;    //Values文本
protected string mstrUpdateText;    //Update文本
protected string mstrSetText;    //Set文本
protected string mstrDeleteText;    //Delete文本
protected int mintOrderNum4Refer;    //引用序号
protected string mstrSqlStatementText;    //Sql语句文本内容
protected string mstrErrMsg;    //错误信息
protected string mstrCreateDate;    //建立日期
protected string mstrAnalysisDate;    //分析日期
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //说明


 /// <summary>
 /// 常量:"SqlStatementId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_SqlStatementId = "SqlStatementId";    //Sql语句Id

 /// <summary>
 /// 常量:"OperateType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_OperateType = "OperateType";    //操作类型

 /// <summary>
 /// 常量:"TabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_TabName = "TabName";    //表名

 /// <summary>
 /// 常量:"SelectText"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_SelectText = "SelectText";    //Select文本内容

 /// <summary>
 /// 常量:"FromText"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_FromText = "FromText";    //From文本内容

 /// <summary>
 /// 常量:"WhereCondition"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_WhereCondition = "WhereCondition";    //条件串

 /// <summary>
 /// 常量:"GroupBy"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_GroupBy = "GroupBy";    //分组

 /// <summary>
 /// 常量:"HavingStr"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_HavingStr = "HavingStr";    //分组过滤

 /// <summary>
 /// 常量:"OrderBy"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_OrderBy = "OrderBy";    //排序

 /// <summary>
 /// 常量:"IntoText"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IntoText = "IntoText";    //Into文本

 /// <summary>
 /// 常量:"ValuesText"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ValuesText = "ValuesText";    //Values文本

 /// <summary>
 /// 常量:"UpdateText"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpdateText = "UpdateText";    //Update文本

 /// <summary>
 /// 常量:"SetText"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_SetText = "SetText";    //Set文本

 /// <summary>
 /// 常量:"DeleteText"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_DeleteText = "DeleteText";    //Delete文本

 /// <summary>
 /// 常量:"OrderNum4Refer"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_OrderNum4Refer = "OrderNum4Refer";    //引用序号

 /// <summary>
 /// 常量:"SqlStatementText"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_SqlStatementText = "SqlStatementText";    //Sql语句文本内容

 /// <summary>
 /// 常量:"ErrMsg"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ErrMsg = "ErrMsg";    //错误信息

 /// <summary>
 /// 常量:"CreateDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_CreateDate = "CreateDate";    //建立日期

 /// <summary>
 /// 常量:"AnalysisDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AnalysisDate = "AnalysisDate";    //分析日期

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo = "Memo";    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public SqlStatement()
 {
 }

public static int AttributeCount
{
get
{
return mintAttributeCount;
}
}
/// <summary>
/// 类索引器(Indexer)函数,字符串参数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClsIndexer)
/// </summary>
public object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  con_SqlStatementId)
{
return mstrSqlStatementId;
}
else if (strAttributeName  ==  con_OperateType)
{
return mstrOperateType;
}
else if (strAttributeName  ==  con_TabName)
{
return mstrTabName;
}
else if (strAttributeName  ==  con_SelectText)
{
return mstrSelectText;
}
else if (strAttributeName  ==  con_FromText)
{
return mstrFromText;
}
else if (strAttributeName  ==  con_WhereCondition)
{
return mstrWhereCondition;
}
else if (strAttributeName  ==  con_GroupBy)
{
return mstrGroupBy;
}
else if (strAttributeName  ==  con_HavingStr)
{
return mstrHavingStr;
}
else if (strAttributeName  ==  con_OrderBy)
{
return mstrOrderBy;
}
else if (strAttributeName  ==  con_IntoText)
{
return mstrIntoText;
}
else if (strAttributeName  ==  con_ValuesText)
{
return mstrValuesText;
}
else if (strAttributeName  ==  con_UpdateText)
{
return mstrUpdateText;
}
else if (strAttributeName  ==  con_SetText)
{
return mstrSetText;
}
else if (strAttributeName  ==  con_DeleteText)
{
return mstrDeleteText;
}
else if (strAttributeName  ==  con_OrderNum4Refer)
{
return mintOrderNum4Refer;
}
else if (strAttributeName  ==  con_SqlStatementText)
{
return mstrSqlStatementText;
}
else if (strAttributeName  ==  con_ErrMsg)
{
return mstrErrMsg;
}
else if (strAttributeName  ==  con_CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  con_AnalysisDate)
{
return mstrAnalysisDate;
}
else if (strAttributeName  ==  con_UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  con_UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  con_Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  con_SqlStatementId)
{
mstrSqlStatementId = value.ToString();
}
else if (strAttributeName  ==  con_OperateType)
{
mstrOperateType = value.ToString();
}
else if (strAttributeName  ==  con_TabName)
{
mstrTabName = value.ToString();
}
else if (strAttributeName  ==  con_SelectText)
{
mstrSelectText = value.ToString();
}
else if (strAttributeName  ==  con_FromText)
{
mstrFromText = value.ToString();
}
else if (strAttributeName  ==  con_WhereCondition)
{
mstrWhereCondition = value.ToString();
}
else if (strAttributeName  ==  con_GroupBy)
{
mstrGroupBy = value.ToString();
}
else if (strAttributeName  ==  con_HavingStr)
{
mstrHavingStr = value.ToString();
}
else if (strAttributeName  ==  con_OrderBy)
{
mstrOrderBy = value.ToString();
}
else if (strAttributeName  ==  con_IntoText)
{
mstrIntoText = value.ToString();
}
else if (strAttributeName  ==  con_ValuesText)
{
mstrValuesText = value.ToString();
}
else if (strAttributeName  ==  con_UpdateText)
{
mstrUpdateText = value.ToString();
}
else if (strAttributeName  ==  con_SetText)
{
mstrSetText = value.ToString();
}
else if (strAttributeName  ==  con_DeleteText)
{
mstrDeleteText = value.ToString();
}
else if (strAttributeName  ==  con_OrderNum4Refer)
{
mintOrderNum4Refer = clsEntityBase2.TransNullToInt_S(value.ToString());
}
else if (strAttributeName  ==  con_SqlStatementText)
{
mstrSqlStatementText = value.ToString();
}
else if (strAttributeName  ==  con_ErrMsg)
{
mstrErrMsg = value.ToString();
}
else if (strAttributeName  ==  con_CreateDate)
{
mstrCreateDate = value.ToString();
}
else if (strAttributeName  ==  con_AnalysisDate)
{
mstrAnalysisDate = value.ToString();
}
else if (strAttributeName  ==  con_UpdDate)
{
mstrUpdDate = value.ToString();
}
else if (strAttributeName  ==  con_UpdUserId)
{
mstrUpdUserId = value.ToString();
}
else if (strAttributeName  ==  con_Memo)
{
mstrMemo = value.ToString();
}
}
}
/// <summary>
/// 类索引器(Indexer)函数, 整型(INT)序号参数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClsIndexer)
/// </summary>
public object this[int intIndex]
{
get
{
if (con_SqlStatementId  ==  AttributeName[intIndex])
{
return mstrSqlStatementId;
}
else if (con_OperateType  ==  AttributeName[intIndex])
{
return mstrOperateType;
}
else if (con_TabName  ==  AttributeName[intIndex])
{
return mstrTabName;
}
else if (con_SelectText  ==  AttributeName[intIndex])
{
return mstrSelectText;
}
else if (con_FromText  ==  AttributeName[intIndex])
{
return mstrFromText;
}
else if (con_WhereCondition  ==  AttributeName[intIndex])
{
return mstrWhereCondition;
}
else if (con_GroupBy  ==  AttributeName[intIndex])
{
return mstrGroupBy;
}
else if (con_HavingStr  ==  AttributeName[intIndex])
{
return mstrHavingStr;
}
else if (con_OrderBy  ==  AttributeName[intIndex])
{
return mstrOrderBy;
}
else if (con_IntoText  ==  AttributeName[intIndex])
{
return mstrIntoText;
}
else if (con_ValuesText  ==  AttributeName[intIndex])
{
return mstrValuesText;
}
else if (con_UpdateText  ==  AttributeName[intIndex])
{
return mstrUpdateText;
}
else if (con_SetText  ==  AttributeName[intIndex])
{
return mstrSetText;
}
else if (con_DeleteText  ==  AttributeName[intIndex])
{
return mstrDeleteText;
}
else if (con_OrderNum4Refer  ==  AttributeName[intIndex])
{
return mintOrderNum4Refer;
}
else if (con_SqlStatementText  ==  AttributeName[intIndex])
{
return mstrSqlStatementText;
}
else if (con_ErrMsg  ==  AttributeName[intIndex])
{
return mstrErrMsg;
}
else if (con_CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (con_AnalysisDate  ==  AttributeName[intIndex])
{
return mstrAnalysisDate;
}
else if (con_UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (con_UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (con_Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (con_SqlStatementId  ==  AttributeName[intIndex])
{
mstrSqlStatementId = value.ToString();
}
else if (con_OperateType  ==  AttributeName[intIndex])
{
mstrOperateType = value.ToString();
}
else if (con_TabName  ==  AttributeName[intIndex])
{
mstrTabName = value.ToString();
}
else if (con_SelectText  ==  AttributeName[intIndex])
{
mstrSelectText = value.ToString();
}
else if (con_FromText  ==  AttributeName[intIndex])
{
mstrFromText = value.ToString();
}
else if (con_WhereCondition  ==  AttributeName[intIndex])
{
mstrWhereCondition = value.ToString();
}
else if (con_GroupBy  ==  AttributeName[intIndex])
{
mstrGroupBy = value.ToString();
}
else if (con_HavingStr  ==  AttributeName[intIndex])
{
mstrHavingStr = value.ToString();
}
else if (con_OrderBy  ==  AttributeName[intIndex])
{
mstrOrderBy = value.ToString();
}
else if (con_IntoText  ==  AttributeName[intIndex])
{
mstrIntoText = value.ToString();
}
else if (con_ValuesText  ==  AttributeName[intIndex])
{
mstrValuesText = value.ToString();
}
else if (con_UpdateText  ==  AttributeName[intIndex])
{
mstrUpdateText = value.ToString();
}
else if (con_SetText  ==  AttributeName[intIndex])
{
mstrSetText = value.ToString();
}
else if (con_DeleteText  ==  AttributeName[intIndex])
{
mstrDeleteText = value.ToString();
}
else if (con_OrderNum4Refer  ==  AttributeName[intIndex])
{
mintOrderNum4Refer = clsEntityBase2.TransNullToInt_S(value.ToString());
}
else if (con_SqlStatementText  ==  AttributeName[intIndex])
{
mstrSqlStatementText = value.ToString();
}
else if (con_ErrMsg  ==  AttributeName[intIndex])
{
mstrErrMsg = value.ToString();
}
else if (con_CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
}
else if (con_AnalysisDate  ==  AttributeName[intIndex])
{
mstrAnalysisDate = value.ToString();
}
else if (con_UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
}
else if (con_UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
}
else if (con_Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
}
}
}

/// <summary>
/// Sql语句Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string SqlStatementId
{
get
{
return mstrSqlStatementId;
}
set
{
if (value  ==  "")
{
 mstrSqlStatementId = value;
}
else
{
 mstrSqlStatementId = value;
}
}
}
/// <summary>
/// 操作类型(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string OperateType
{
get
{
return mstrOperateType;
}
set
{
if (value  ==  "")
{
 mstrOperateType = value;
}
else
{
 mstrOperateType = value;
}
}
}
/// <summary>
/// 表名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
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
 mstrTabName = value;
}
else
{
 mstrTabName = value;
}
}
}
/// <summary>
/// Select文本内容(说明:;字段类型:varchar;字段长度:8000;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string SelectText
{
get
{
return mstrSelectText;
}
set
{
if (value  ==  "")
{
 mstrSelectText = value;
}
else
{
 mstrSelectText = value;
}
}
}
/// <summary>
/// From文本内容(说明:;字段类型:varchar;字段长度:8000;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string FromText
{
get
{
return mstrFromText;
}
set
{
if (value  ==  "")
{
 mstrFromText = value;
}
else
{
 mstrFromText = value;
}
}
}
/// <summary>
/// 条件串(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
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
 mstrWhereCondition = value;
}
else
{
 mstrWhereCondition = value;
}
}
}
/// <summary>
/// 分组(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
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
 mstrGroupBy = value;
}
else
{
 mstrGroupBy = value;
}
}
}
/// <summary>
/// 分组过滤(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
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
 mstrHavingStr = value;
}
else
{
 mstrHavingStr = value;
}
}
}
/// <summary>
/// 排序(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
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
 mstrOrderBy = value;
}
else
{
 mstrOrderBy = value;
}
}
}
/// <summary>
/// Into文本(说明:;字段类型:varchar;字段长度:300;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string IntoText
{
get
{
return mstrIntoText;
}
set
{
if (value  ==  "")
{
 mstrIntoText = value;
}
else
{
 mstrIntoText = value;
}
}
}
/// <summary>
/// Values文本(说明:;字段类型:varchar;字段长度:300;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string ValuesText
{
get
{
return mstrValuesText;
}
set
{
if (value  ==  "")
{
 mstrValuesText = value;
}
else
{
 mstrValuesText = value;
}
}
}
/// <summary>
/// Update文本(说明:;字段类型:varchar;字段长度:300;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string UpdateText
{
get
{
return mstrUpdateText;
}
set
{
if (value  ==  "")
{
 mstrUpdateText = value;
}
else
{
 mstrUpdateText = value;
}
}
}
/// <summary>
/// Set文本(说明:;字段类型:varchar;字段长度:300;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string SetText
{
get
{
return mstrSetText;
}
set
{
if (value  ==  "")
{
 mstrSetText = value;
}
else
{
 mstrSetText = value;
}
}
}
/// <summary>
/// Delete文本(说明:;字段类型:varchar;字段长度:300;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string DeleteText
{
get
{
return mstrDeleteText;
}
set
{
if (value  ==  "")
{
 mstrDeleteText = value;
}
else
{
 mstrDeleteText = value;
}
}
}
/// <summary>
/// 引用序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public int OrderNum4Refer
{
get
{
return mintOrderNum4Refer;
}
set
{
 mintOrderNum4Refer = value;
}
}
/// <summary>
/// Sql语句文本内容(说明:;字段类型:varchar;字段长度:8000;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string SqlStatementText
{
get
{
return mstrSqlStatementText;
}
set
{
if (value  ==  "")
{
 mstrSqlStatementText = value;
}
else
{
 mstrSqlStatementText = value;
}
}
}
/// <summary>
/// 错误信息(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
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
 mstrErrMsg = value;
}
else
{
 mstrErrMsg = value;
}
}
}
/// <summary>
/// 建立日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
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
 mstrCreateDate = value;
}
else
{
 mstrCreateDate = value;
}
}
}
/// <summary>
/// 分析日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
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
 mstrAnalysisDate = value;
}
else
{
 mstrAnalysisDate = value;
}
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
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
 mstrUpdDate = value;
}
else
{
 mstrUpdDate = value;
}
}
}
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
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
 mstrUpdUserId = value;
}
else
{
 mstrUpdUserId = value;
}
}
}
/// <summary>
/// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
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
 mstrMemo = value;
}
else
{
 mstrMemo = value;
}
}
}
}
}