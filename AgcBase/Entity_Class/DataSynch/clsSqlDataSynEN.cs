
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSqlDataSynEN
 表名:SqlDataSyn(00050269)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:36:28
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:数据同步(DataSynch)
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
 /// 表SqlDataSyn的关键字(TabId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TabId_SqlDataSyn
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strTabId">表关键字</param>
public K_TabId_SqlDataSyn(string strTabId)
{
if (IsValid(strTabId)) Value = strTabId;
else
{
Value = null;
}
}
private static bool IsValid(string strTabId)
{
if (string.IsNullOrEmpty(strTabId) == true) return false;
if (strTabId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_TabId_SqlDataSyn]类型的对象</returns>
public static implicit operator K_TabId_SqlDataSyn(string value)
{
return new K_TabId_SqlDataSyn(value);
}
}
 /// <summary>
 /// Sql数据同步(SqlDataSyn)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsSqlDataSynEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "SqlDataSyn"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TabId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 21;
public static string[] _AttributeName = new string[] {"TabId", "TabName", "TabCnName", "TabEnName", "SqlData", "SqlCommandTypeId", "SqlCommandText", "SqlDataRecNum", "TargetTabCondition", "TargetTabRecNum", "DataSynDate", "PrimaryTypeId", "RecExclusiveWayId", "TextResouce", "TextResourceTypeId", "AnalysisDate", "PrjId", "ErrMsg", "UpdDate", "UpdUserId", "Memo"};

protected string mstrTabId;    //表ID
protected string mstrTabName;    //表名
protected string mstrTabCnName;    //表中文名
protected string mstrTabEnName;    //表英文详细名
protected string mstrSqlData;    //Sql表数据
protected string mstrSqlCommandTypeId;    //Sql命令类型Id
protected string mstrSqlCommandText;    //Sql命令内容
protected int? mintSqlDataRecNum;    //Sql数据记录数
protected string mstrTargetTabCondition;    //目标表有效记录条件
protected int? mintTargetTabRecNum;    //目标表记录数
protected string mstrDataSynDate;    //数据同步日期
protected string mstrPrimaryTypeId;    //主键类型ID
protected string mstrRecExclusiveWayId;    //记录排他方式Id
protected string mstrTextResouce;    //文本来源
protected string mstrTextResourceTypeId;    //文本来源类型Id
protected string mstrAnalysisDate;    //分析日期
protected string mstrPrjId;    //工程Id
protected string mstrErrMsg;    //错误信息
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsSqlDataSynEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TabId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strTabId">关键字:表ID</param>
public clsSqlDataSynEN(string strTabId)
 {
strTabId = strTabId.Replace("'", "''");
if (strTabId.Length > 8)
{
throw new Exception("在表:SqlDataSyn中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTabId)  ==  true)
{
throw new Exception("在表:SqlDataSyn中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTabId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrTabId = strTabId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TabId");
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
if (strAttributeName  ==  conSqlDataSyn.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  conSqlDataSyn.TabName)
{
return mstrTabName;
}
else if (strAttributeName  ==  conSqlDataSyn.TabCnName)
{
return mstrTabCnName;
}
else if (strAttributeName  ==  conSqlDataSyn.TabEnName)
{
return mstrTabEnName;
}
else if (strAttributeName  ==  conSqlDataSyn.SqlData)
{
return mstrSqlData;
}
else if (strAttributeName  ==  conSqlDataSyn.SqlCommandTypeId)
{
return mstrSqlCommandTypeId;
}
else if (strAttributeName  ==  conSqlDataSyn.SqlCommandText)
{
return mstrSqlCommandText;
}
else if (strAttributeName  ==  conSqlDataSyn.SqlDataRecNum)
{
return mintSqlDataRecNum;
}
else if (strAttributeName  ==  conSqlDataSyn.TargetTabCondition)
{
return mstrTargetTabCondition;
}
else if (strAttributeName  ==  conSqlDataSyn.TargetTabRecNum)
{
return mintTargetTabRecNum;
}
else if (strAttributeName  ==  conSqlDataSyn.DataSynDate)
{
return mstrDataSynDate;
}
else if (strAttributeName  ==  conSqlDataSyn.PrimaryTypeId)
{
return mstrPrimaryTypeId;
}
else if (strAttributeName  ==  conSqlDataSyn.RecExclusiveWayId)
{
return mstrRecExclusiveWayId;
}
else if (strAttributeName  ==  conSqlDataSyn.TextResouce)
{
return mstrTextResouce;
}
else if (strAttributeName  ==  conSqlDataSyn.TextResourceTypeId)
{
return mstrTextResourceTypeId;
}
else if (strAttributeName  ==  conSqlDataSyn.AnalysisDate)
{
return mstrAnalysisDate;
}
else if (strAttributeName  ==  conSqlDataSyn.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conSqlDataSyn.ErrMsg)
{
return mstrErrMsg;
}
else if (strAttributeName  ==  conSqlDataSyn.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conSqlDataSyn.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conSqlDataSyn.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conSqlDataSyn.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(conSqlDataSyn.TabId);
}
else if (strAttributeName  ==  conSqlDataSyn.TabName)
{
mstrTabName = value.ToString();
 AddUpdatedFld(conSqlDataSyn.TabName);
}
else if (strAttributeName  ==  conSqlDataSyn.TabCnName)
{
mstrTabCnName = value.ToString();
 AddUpdatedFld(conSqlDataSyn.TabCnName);
}
else if (strAttributeName  ==  conSqlDataSyn.TabEnName)
{
mstrTabEnName = value.ToString();
 AddUpdatedFld(conSqlDataSyn.TabEnName);
}
else if (strAttributeName  ==  conSqlDataSyn.SqlData)
{
mstrSqlData = value.ToString();
 AddUpdatedFld(conSqlDataSyn.SqlData);
}
else if (strAttributeName  ==  conSqlDataSyn.SqlCommandTypeId)
{
mstrSqlCommandTypeId = value.ToString();
 AddUpdatedFld(conSqlDataSyn.SqlCommandTypeId);
}
else if (strAttributeName  ==  conSqlDataSyn.SqlCommandText)
{
mstrSqlCommandText = value.ToString();
 AddUpdatedFld(conSqlDataSyn.SqlCommandText);
}
else if (strAttributeName  ==  conSqlDataSyn.SqlDataRecNum)
{
mintSqlDataRecNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conSqlDataSyn.SqlDataRecNum);
}
else if (strAttributeName  ==  conSqlDataSyn.TargetTabCondition)
{
mstrTargetTabCondition = value.ToString();
 AddUpdatedFld(conSqlDataSyn.TargetTabCondition);
}
else if (strAttributeName  ==  conSqlDataSyn.TargetTabRecNum)
{
mintTargetTabRecNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conSqlDataSyn.TargetTabRecNum);
}
else if (strAttributeName  ==  conSqlDataSyn.DataSynDate)
{
mstrDataSynDate = value.ToString();
 AddUpdatedFld(conSqlDataSyn.DataSynDate);
}
else if (strAttributeName  ==  conSqlDataSyn.PrimaryTypeId)
{
mstrPrimaryTypeId = value.ToString();
 AddUpdatedFld(conSqlDataSyn.PrimaryTypeId);
}
else if (strAttributeName  ==  conSqlDataSyn.RecExclusiveWayId)
{
mstrRecExclusiveWayId = value.ToString();
 AddUpdatedFld(conSqlDataSyn.RecExclusiveWayId);
}
else if (strAttributeName  ==  conSqlDataSyn.TextResouce)
{
mstrTextResouce = value.ToString();
 AddUpdatedFld(conSqlDataSyn.TextResouce);
}
else if (strAttributeName  ==  conSqlDataSyn.TextResourceTypeId)
{
mstrTextResourceTypeId = value.ToString();
 AddUpdatedFld(conSqlDataSyn.TextResourceTypeId);
}
else if (strAttributeName  ==  conSqlDataSyn.AnalysisDate)
{
mstrAnalysisDate = value.ToString();
 AddUpdatedFld(conSqlDataSyn.AnalysisDate);
}
else if (strAttributeName  ==  conSqlDataSyn.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conSqlDataSyn.PrjId);
}
else if (strAttributeName  ==  conSqlDataSyn.ErrMsg)
{
mstrErrMsg = value.ToString();
 AddUpdatedFld(conSqlDataSyn.ErrMsg);
}
else if (strAttributeName  ==  conSqlDataSyn.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conSqlDataSyn.UpdDate);
}
else if (strAttributeName  ==  conSqlDataSyn.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conSqlDataSyn.UpdUserId);
}
else if (strAttributeName  ==  conSqlDataSyn.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSqlDataSyn.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conSqlDataSyn.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (conSqlDataSyn.TabName  ==  _AttributeName[intIndex])
{
return mstrTabName;
}
else if (conSqlDataSyn.TabCnName  ==  _AttributeName[intIndex])
{
return mstrTabCnName;
}
else if (conSqlDataSyn.TabEnName  ==  _AttributeName[intIndex])
{
return mstrTabEnName;
}
else if (conSqlDataSyn.SqlData  ==  _AttributeName[intIndex])
{
return mstrSqlData;
}
else if (conSqlDataSyn.SqlCommandTypeId  ==  _AttributeName[intIndex])
{
return mstrSqlCommandTypeId;
}
else if (conSqlDataSyn.SqlCommandText  ==  _AttributeName[intIndex])
{
return mstrSqlCommandText;
}
else if (conSqlDataSyn.SqlDataRecNum  ==  _AttributeName[intIndex])
{
return mintSqlDataRecNum;
}
else if (conSqlDataSyn.TargetTabCondition  ==  _AttributeName[intIndex])
{
return mstrTargetTabCondition;
}
else if (conSqlDataSyn.TargetTabRecNum  ==  _AttributeName[intIndex])
{
return mintTargetTabRecNum;
}
else if (conSqlDataSyn.DataSynDate  ==  _AttributeName[intIndex])
{
return mstrDataSynDate;
}
else if (conSqlDataSyn.PrimaryTypeId  ==  _AttributeName[intIndex])
{
return mstrPrimaryTypeId;
}
else if (conSqlDataSyn.RecExclusiveWayId  ==  _AttributeName[intIndex])
{
return mstrRecExclusiveWayId;
}
else if (conSqlDataSyn.TextResouce  ==  _AttributeName[intIndex])
{
return mstrTextResouce;
}
else if (conSqlDataSyn.TextResourceTypeId  ==  _AttributeName[intIndex])
{
return mstrTextResourceTypeId;
}
else if (conSqlDataSyn.AnalysisDate  ==  _AttributeName[intIndex])
{
return mstrAnalysisDate;
}
else if (conSqlDataSyn.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conSqlDataSyn.ErrMsg  ==  _AttributeName[intIndex])
{
return mstrErrMsg;
}
else if (conSqlDataSyn.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conSqlDataSyn.UpdUserId  ==  _AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conSqlDataSyn.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conSqlDataSyn.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(conSqlDataSyn.TabId);
}
else if (conSqlDataSyn.TabName  ==  _AttributeName[intIndex])
{
mstrTabName = value.ToString();
 AddUpdatedFld(conSqlDataSyn.TabName);
}
else if (conSqlDataSyn.TabCnName  ==  _AttributeName[intIndex])
{
mstrTabCnName = value.ToString();
 AddUpdatedFld(conSqlDataSyn.TabCnName);
}
else if (conSqlDataSyn.TabEnName  ==  _AttributeName[intIndex])
{
mstrTabEnName = value.ToString();
 AddUpdatedFld(conSqlDataSyn.TabEnName);
}
else if (conSqlDataSyn.SqlData  ==  _AttributeName[intIndex])
{
mstrSqlData = value.ToString();
 AddUpdatedFld(conSqlDataSyn.SqlData);
}
else if (conSqlDataSyn.SqlCommandTypeId  ==  _AttributeName[intIndex])
{
mstrSqlCommandTypeId = value.ToString();
 AddUpdatedFld(conSqlDataSyn.SqlCommandTypeId);
}
else if (conSqlDataSyn.SqlCommandText  ==  _AttributeName[intIndex])
{
mstrSqlCommandText = value.ToString();
 AddUpdatedFld(conSqlDataSyn.SqlCommandText);
}
else if (conSqlDataSyn.SqlDataRecNum  ==  _AttributeName[intIndex])
{
mintSqlDataRecNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conSqlDataSyn.SqlDataRecNum);
}
else if (conSqlDataSyn.TargetTabCondition  ==  _AttributeName[intIndex])
{
mstrTargetTabCondition = value.ToString();
 AddUpdatedFld(conSqlDataSyn.TargetTabCondition);
}
else if (conSqlDataSyn.TargetTabRecNum  ==  _AttributeName[intIndex])
{
mintTargetTabRecNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conSqlDataSyn.TargetTabRecNum);
}
else if (conSqlDataSyn.DataSynDate  ==  _AttributeName[intIndex])
{
mstrDataSynDate = value.ToString();
 AddUpdatedFld(conSqlDataSyn.DataSynDate);
}
else if (conSqlDataSyn.PrimaryTypeId  ==  _AttributeName[intIndex])
{
mstrPrimaryTypeId = value.ToString();
 AddUpdatedFld(conSqlDataSyn.PrimaryTypeId);
}
else if (conSqlDataSyn.RecExclusiveWayId  ==  _AttributeName[intIndex])
{
mstrRecExclusiveWayId = value.ToString();
 AddUpdatedFld(conSqlDataSyn.RecExclusiveWayId);
}
else if (conSqlDataSyn.TextResouce  ==  _AttributeName[intIndex])
{
mstrTextResouce = value.ToString();
 AddUpdatedFld(conSqlDataSyn.TextResouce);
}
else if (conSqlDataSyn.TextResourceTypeId  ==  _AttributeName[intIndex])
{
mstrTextResourceTypeId = value.ToString();
 AddUpdatedFld(conSqlDataSyn.TextResourceTypeId);
}
else if (conSqlDataSyn.AnalysisDate  ==  _AttributeName[intIndex])
{
mstrAnalysisDate = value.ToString();
 AddUpdatedFld(conSqlDataSyn.AnalysisDate);
}
else if (conSqlDataSyn.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conSqlDataSyn.PrjId);
}
else if (conSqlDataSyn.ErrMsg  ==  _AttributeName[intIndex])
{
mstrErrMsg = value.ToString();
 AddUpdatedFld(conSqlDataSyn.ErrMsg);
}
else if (conSqlDataSyn.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conSqlDataSyn.UpdDate);
}
else if (conSqlDataSyn.UpdUserId  ==  _AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conSqlDataSyn.UpdUserId);
}
else if (conSqlDataSyn.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSqlDataSyn.Memo);
}
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
 AddUpdatedFld(conSqlDataSyn.TabId);
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
 AddUpdatedFld(conSqlDataSyn.TabName);
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
 AddUpdatedFld(conSqlDataSyn.TabCnName);
}
}
/// <summary>
/// 表英文详细名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabEnName
{
get
{
return mstrTabEnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabEnName = value;
}
else
{
 mstrTabEnName = value;
}
//记录修改过的字段
 AddUpdatedFld(conSqlDataSyn.TabEnName);
}
}
/// <summary>
/// Sql表数据(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SqlData
{
get
{
return mstrSqlData;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSqlData = value;
}
else
{
 mstrSqlData = value;
}
//记录修改过的字段
 AddUpdatedFld(conSqlDataSyn.SqlData);
}
}
/// <summary>
/// Sql命令类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SqlCommandTypeId
{
get
{
return mstrSqlCommandTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSqlCommandTypeId = value;
}
else
{
 mstrSqlCommandTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSqlDataSyn.SqlCommandTypeId);
}
}
/// <summary>
/// Sql命令内容(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SqlCommandText
{
get
{
return mstrSqlCommandText;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSqlCommandText = value;
}
else
{
 mstrSqlCommandText = value;
}
//记录修改过的字段
 AddUpdatedFld(conSqlDataSyn.SqlCommandText);
}
}
/// <summary>
/// Sql数据记录数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? SqlDataRecNum
{
get
{
return mintSqlDataRecNum;
}
set
{
 mintSqlDataRecNum = value;
//记录修改过的字段
 AddUpdatedFld(conSqlDataSyn.SqlDataRecNum);
}
}
/// <summary>
/// 目标表有效记录条件(说明:;字段类型:varchar;字段长度:300;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TargetTabCondition
{
get
{
return mstrTargetTabCondition;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTargetTabCondition = value;
}
else
{
 mstrTargetTabCondition = value;
}
//记录修改过的字段
 AddUpdatedFld(conSqlDataSyn.TargetTabCondition);
}
}
/// <summary>
/// 目标表记录数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? TargetTabRecNum
{
get
{
return mintTargetTabRecNum;
}
set
{
 mintTargetTabRecNum = value;
//记录修改过的字段
 AddUpdatedFld(conSqlDataSyn.TargetTabRecNum);
}
}
/// <summary>
/// 数据同步日期(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataSynDate
{
get
{
return mstrDataSynDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataSynDate = value;
}
else
{
 mstrDataSynDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conSqlDataSyn.DataSynDate);
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
 AddUpdatedFld(conSqlDataSyn.PrimaryTypeId);
}
}
/// <summary>
/// 记录排他方式Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RecExclusiveWayId
{
get
{
return mstrRecExclusiveWayId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRecExclusiveWayId = value;
}
else
{
 mstrRecExclusiveWayId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSqlDataSyn.RecExclusiveWayId);
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
 AddUpdatedFld(conSqlDataSyn.TextResouce);
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
 AddUpdatedFld(conSqlDataSyn.TextResourceTypeId);
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
 AddUpdatedFld(conSqlDataSyn.AnalysisDate);
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
 AddUpdatedFld(conSqlDataSyn.PrjId);
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
 AddUpdatedFld(conSqlDataSyn.ErrMsg);
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
 AddUpdatedFld(conSqlDataSyn.UpdDate);
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
 AddUpdatedFld(conSqlDataSyn.UpdUserId);
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
 AddUpdatedFld(conSqlDataSyn.Memo);
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
  return mstrTabId;
 }
 }
}
 /// <summary>
 /// Sql数据同步(SqlDataSyn)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conSqlDataSyn
{
public const string _CurrTabName = "SqlDataSyn"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TabId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"TabId", "TabName", "TabCnName", "TabEnName", "SqlData", "SqlCommandTypeId", "SqlCommandText", "SqlDataRecNum", "TargetTabCondition", "TargetTabRecNum", "DataSynDate", "PrimaryTypeId", "RecExclusiveWayId", "TextResouce", "TextResourceTypeId", "AnalysisDate", "PrjId", "ErrMsg", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


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
 /// 常量:"TabEnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabEnName = "TabEnName";    //表英文详细名

 /// <summary>
 /// 常量:"SqlData"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SqlData = "SqlData";    //Sql表数据

 /// <summary>
 /// 常量:"SqlCommandTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SqlCommandTypeId = "SqlCommandTypeId";    //Sql命令类型Id

 /// <summary>
 /// 常量:"SqlCommandText"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SqlCommandText = "SqlCommandText";    //Sql命令内容

 /// <summary>
 /// 常量:"SqlDataRecNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SqlDataRecNum = "SqlDataRecNum";    //Sql数据记录数

 /// <summary>
 /// 常量:"TargetTabCondition"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TargetTabCondition = "TargetTabCondition";    //目标表有效记录条件

 /// <summary>
 /// 常量:"TargetTabRecNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TargetTabRecNum = "TargetTabRecNum";    //目标表记录数

 /// <summary>
 /// 常量:"DataSynDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataSynDate = "DataSynDate";    //数据同步日期

 /// <summary>
 /// 常量:"PrimaryTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrimaryTypeId = "PrimaryTypeId";    //主键类型ID

 /// <summary>
 /// 常量:"RecExclusiveWayId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RecExclusiveWayId = "RecExclusiveWayId";    //记录排他方式Id

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
 /// 常量:"AnalysisDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnalysisDate = "AnalysisDate";    //分析日期

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

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