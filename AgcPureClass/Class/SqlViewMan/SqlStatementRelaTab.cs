
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:SqlStatementRelaTab
 表名:SqlStatementRelaTab(00050297)
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
 /// Sql语句相关表(SqlStatementRelaTab)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class SqlStatementRelaTab 
{
protected const int mintAttributeCount = 16;
public static string[] AttributeName = new string[] {"SqlStatementRelaTabId", "SqlStatementId", "TabId", "TabName", "TabAliases", "RelaFldId", "OtherFldId", "OtherTabId", "Sv_RelaTabTypeId", "TabRelationTypeId", "TabRelationText", "OrderNum", "PrjId", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量

protected string mstrSqlStatementRelaTabId;    //Sql语句相关表Id
protected string mstrSqlStatementId;    //Sql语句Id
protected string mstrTabId;    //表ID
protected string mstrTabName;    //表名
protected string mstrTabAliases;    //表别名
protected string mstrRelaFldId;    //关系字段
protected string mstrOtherFldId;    //其他表字段
protected string mstrOtherTabId;    //其他表Id
protected string mstrSv_RelaTabTypeId;    //Sql视图相关表类型Id
protected string mstrTabRelationTypeId;    //表关系类型Id
protected string mstrTabRelationText;    //表关系文本
protected int mintOrderNum;    //序号
protected string mstrPrjId;    //工程ID
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //说明


 /// <summary>
 /// 常量:"SqlStatementRelaTabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_SqlStatementRelaTabId = "SqlStatementRelaTabId";    //Sql语句相关表Id

 /// <summary>
 /// 常量:"SqlStatementId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_SqlStatementId = "SqlStatementId";    //Sql语句Id

 /// <summary>
 /// 常量:"TabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_TabId = "TabId";    //表ID

 /// <summary>
 /// 常量:"TabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_TabName = "TabName";    //表名

 /// <summary>
 /// 常量:"TabAliases"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_TabAliases = "TabAliases";    //表别名

 /// <summary>
 /// 常量:"RelaFldId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_RelaFldId = "RelaFldId";    //关系字段

 /// <summary>
 /// 常量:"OtherFldId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_OtherFldId = "OtherFldId";    //其他表字段

 /// <summary>
 /// 常量:"OtherTabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_OtherTabId = "OtherTabId";    //其他表Id

 /// <summary>
 /// 常量:"Sv_RelaTabTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Sv_RelaTabTypeId = "Sv_RelaTabTypeId";    //Sql视图相关表类型Id

 /// <summary>
 /// 常量:"TabRelationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_TabRelationTypeId = "TabRelationTypeId";    //表关系类型Id

 /// <summary>
 /// 常量:"TabRelationText"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_TabRelationText = "TabRelationText";    //表关系文本

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PrjId = "PrjId";    //工程ID

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
 public SqlStatementRelaTab()
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
if (strAttributeName  ==  con_SqlStatementRelaTabId)
{
return mstrSqlStatementRelaTabId;
}
else if (strAttributeName  ==  con_SqlStatementId)
{
return mstrSqlStatementId;
}
else if (strAttributeName  ==  con_TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  con_TabName)
{
return mstrTabName;
}
else if (strAttributeName  ==  con_TabAliases)
{
return mstrTabAliases;
}
else if (strAttributeName  ==  con_RelaFldId)
{
return mstrRelaFldId;
}
else if (strAttributeName  ==  con_OtherFldId)
{
return mstrOtherFldId;
}
else if (strAttributeName  ==  con_OtherTabId)
{
return mstrOtherTabId;
}
else if (strAttributeName  ==  con_Sv_RelaTabTypeId)
{
return mstrSv_RelaTabTypeId;
}
else if (strAttributeName  ==  con_TabRelationTypeId)
{
return mstrTabRelationTypeId;
}
else if (strAttributeName  ==  con_TabRelationText)
{
return mstrTabRelationText;
}
else if (strAttributeName  ==  con_OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  con_PrjId)
{
return mstrPrjId;
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
if (strAttributeName  ==  con_SqlStatementRelaTabId)
{
mstrSqlStatementRelaTabId = value.ToString();
}
else if (strAttributeName  ==  con_SqlStatementId)
{
mstrSqlStatementId = value.ToString();
}
else if (strAttributeName  ==  con_TabId)
{
mstrTabId = value.ToString();
}
else if (strAttributeName  ==  con_TabName)
{
mstrTabName = value.ToString();
}
else if (strAttributeName  ==  con_TabAliases)
{
mstrTabAliases = value.ToString();
}
else if (strAttributeName  ==  con_RelaFldId)
{
mstrRelaFldId = value.ToString();
}
else if (strAttributeName  ==  con_OtherFldId)
{
mstrOtherFldId = value.ToString();
}
else if (strAttributeName  ==  con_OtherTabId)
{
mstrOtherTabId = value.ToString();
}
else if (strAttributeName  ==  con_Sv_RelaTabTypeId)
{
mstrSv_RelaTabTypeId = value.ToString();
}
else if (strAttributeName  ==  con_TabRelationTypeId)
{
mstrTabRelationTypeId = value.ToString();
}
else if (strAttributeName  ==  con_TabRelationText)
{
mstrTabRelationText = value.ToString();
}
else if (strAttributeName  ==  con_OrderNum)
{
mintOrderNum = clsEntityBase2.TransNullToInt_S(value.ToString());
}
else if (strAttributeName  ==  con_PrjId)
{
mstrPrjId = value.ToString();
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
if (con_SqlStatementRelaTabId  ==  AttributeName[intIndex])
{
return mstrSqlStatementRelaTabId;
}
else if (con_SqlStatementId  ==  AttributeName[intIndex])
{
return mstrSqlStatementId;
}
else if (con_TabId  ==  AttributeName[intIndex])
{
return mstrTabId;
}
else if (con_TabName  ==  AttributeName[intIndex])
{
return mstrTabName;
}
else if (con_TabAliases  ==  AttributeName[intIndex])
{
return mstrTabAliases;
}
else if (con_RelaFldId  ==  AttributeName[intIndex])
{
return mstrRelaFldId;
}
else if (con_OtherFldId  ==  AttributeName[intIndex])
{
return mstrOtherFldId;
}
else if (con_OtherTabId  ==  AttributeName[intIndex])
{
return mstrOtherTabId;
}
else if (con_Sv_RelaTabTypeId  ==  AttributeName[intIndex])
{
return mstrSv_RelaTabTypeId;
}
else if (con_TabRelationTypeId  ==  AttributeName[intIndex])
{
return mstrTabRelationTypeId;
}
else if (con_TabRelationText  ==  AttributeName[intIndex])
{
return mstrTabRelationText;
}
else if (con_OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (con_PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
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
if (con_SqlStatementRelaTabId  ==  AttributeName[intIndex])
{
mstrSqlStatementRelaTabId = value.ToString();
}
else if (con_SqlStatementId  ==  AttributeName[intIndex])
{
mstrSqlStatementId = value.ToString();
}
else if (con_TabId  ==  AttributeName[intIndex])
{
mstrTabId = value.ToString();
}
else if (con_TabName  ==  AttributeName[intIndex])
{
mstrTabName = value.ToString();
}
else if (con_TabAliases  ==  AttributeName[intIndex])
{
mstrTabAliases = value.ToString();
}
else if (con_RelaFldId  ==  AttributeName[intIndex])
{
mstrRelaFldId = value.ToString();
}
else if (con_OtherFldId  ==  AttributeName[intIndex])
{
mstrOtherFldId = value.ToString();
}
else if (con_OtherTabId  ==  AttributeName[intIndex])
{
mstrOtherTabId = value.ToString();
}
else if (con_Sv_RelaTabTypeId  ==  AttributeName[intIndex])
{
mstrSv_RelaTabTypeId = value.ToString();
}
else if (con_TabRelationTypeId  ==  AttributeName[intIndex])
{
mstrTabRelationTypeId = value.ToString();
}
else if (con_TabRelationText  ==  AttributeName[intIndex])
{
mstrTabRelationText = value.ToString();
}
else if (con_OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = clsEntityBase2.TransNullToInt_S(value.ToString());
}
else if (con_PrjId  ==  AttributeName[intIndex])
{
mstrPrjId = value.ToString();
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
/// Sql语句相关表Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string SqlStatementRelaTabId
{
get
{
return mstrSqlStatementRelaTabId;
}
set
{
if (value  ==  "")
{
 mstrSqlStatementRelaTabId = value;
}
else
{
 mstrSqlStatementRelaTabId = value;
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
/// 表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
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
 mstrTabId = value;
}
else
{
 mstrTabId = value;
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
/// 表别名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
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
 mstrTabAliases = value;
}
else
{
 mstrTabAliases = value;
}
}
}
/// <summary>
/// 关系字段(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
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
 mstrRelaFldId = value;
}
else
{
 mstrRelaFldId = value;
}
}
}
/// <summary>
/// 其他表字段(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
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
 mstrOtherFldId = value;
}
else
{
 mstrOtherFldId = value;
}
}
}
/// <summary>
/// 其他表Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
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
 mstrOtherTabId = value;
}
else
{
 mstrOtherTabId = value;
}
}
}
/// <summary>
/// Sql视图相关表类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string Sv_RelaTabTypeId
{
get
{
return mstrSv_RelaTabTypeId;
}
set
{
if (value  ==  "")
{
 mstrSv_RelaTabTypeId = value;
}
else
{
 mstrSv_RelaTabTypeId = value;
}
}
}
/// <summary>
/// 表关系类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
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
 mstrTabRelationTypeId = value;
}
else
{
 mstrTabRelationTypeId = value;
}
}
}
/// <summary>
/// 表关系文本(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
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
 mstrTabRelationText = value;
}
else
{
 mstrTabRelationText = value;
}
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
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
}
}
/// <summary>
/// 工程ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
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
 mstrPrjId = value;
}
else
{
 mstrPrjId = value;
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