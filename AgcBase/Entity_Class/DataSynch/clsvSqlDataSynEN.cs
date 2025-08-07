
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSqlDataSynEN
 表名:vSqlDataSyn(00050271)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:36:55
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
 /// 表vSqlDataSyn的关键字(TabId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TabId_vSqlDataSyn
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
public K_TabId_vSqlDataSyn(string strTabId)
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
 /// <returns>返回:[K_TabId_vSqlDataSyn]类型的对象</returns>
public static implicit operator K_TabId_vSqlDataSyn(string value)
{
return new K_TabId_vSqlDataSyn(value);
}
}
 /// <summary>
 /// vSql数据同步(vSqlDataSyn)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvSqlDataSynEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vSqlDataSyn"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TabId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 30;
public static string[] _AttributeName = new string[] {"PrimaryTypeId", "FieldNum", "TabId", "FuncModuleAgcId", "Keyword", "TabTypeId", "TabTypeName", "FuncModuleName", "TabName", "TabCnName", "SqlData", "SqlCommandTypeName", "RecExclusiveWayName", "PrjName", "PrimaryTypeName", "SqlCommandTypeId", "SqlCommandText", "SqlDataRecNum", "TargetTabCondition", "TargetTabRecNum", "DataSynDate", "RecExclusiveWayId", "TextResouce", "TextResourceTypeId", "AnalysisDate", "PrjId", "ErrMsg", "UpdDate", "UpdUserId", "Memo"};

protected string mstrPrimaryTypeId;    //主键类型ID
protected int? mintFieldNum;    //FieldNum
protected string mstrTabId;    //表ID
protected string mstrFuncModuleAgcId;    //功能模块Id
protected string mstrKeyword;    //关键字
protected string mstrTabTypeId;    //表类型Id
protected string mstrTabTypeName;    //表类型名
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrTabName;    //表名
protected string mstrTabCnName;    //表中文名
protected string mstrSqlData;    //Sql表数据
protected string mstrSqlCommandTypeName;    //Sql命令类型名称
protected string mstrRecExclusiveWayName;    //记录排他方式名称
protected string mstrPrjName;    //工程名称
protected string mstrPrimaryTypeName;    //主键类型名
protected string mstrSqlCommandTypeId;    //Sql命令类型Id
protected string mstrSqlCommandText;    //Sql命令内容
protected int? mintSqlDataRecNum;    //Sql数据记录数
protected string mstrTargetTabCondition;    //目标表有效记录条件
protected int? mintTargetTabRecNum;    //目标表记录数
protected string mstrDataSynDate;    //数据同步日期
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
 public clsvSqlDataSynEN()
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
public clsvSqlDataSynEN(string strTabId)
 {
strTabId = strTabId.Replace("'", "''");
if (strTabId.Length > 8)
{
throw new Exception("在表:vSqlDataSyn中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTabId)  ==  true)
{
throw new Exception("在表:vSqlDataSyn中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convSqlDataSyn.PrimaryTypeId)
{
return mstrPrimaryTypeId;
}
else if (strAttributeName  ==  convSqlDataSyn.FieldNum)
{
return mintFieldNum;
}
else if (strAttributeName  ==  convSqlDataSyn.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  convSqlDataSyn.FuncModuleAgcId)
{
return mstrFuncModuleAgcId;
}
else if (strAttributeName  ==  convSqlDataSyn.Keyword)
{
return mstrKeyword;
}
else if (strAttributeName  ==  convSqlDataSyn.TabTypeId)
{
return mstrTabTypeId;
}
else if (strAttributeName  ==  convSqlDataSyn.TabTypeName)
{
return mstrTabTypeName;
}
else if (strAttributeName  ==  convSqlDataSyn.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convSqlDataSyn.TabName)
{
return mstrTabName;
}
else if (strAttributeName  ==  convSqlDataSyn.TabCnName)
{
return mstrTabCnName;
}
else if (strAttributeName  ==  convSqlDataSyn.SqlData)
{
return mstrSqlData;
}
else if (strAttributeName  ==  convSqlDataSyn.SqlCommandTypeName)
{
return mstrSqlCommandTypeName;
}
else if (strAttributeName  ==  convSqlDataSyn.RecExclusiveWayName)
{
return mstrRecExclusiveWayName;
}
else if (strAttributeName  ==  convSqlDataSyn.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convSqlDataSyn.PrimaryTypeName)
{
return mstrPrimaryTypeName;
}
else if (strAttributeName  ==  convSqlDataSyn.SqlCommandTypeId)
{
return mstrSqlCommandTypeId;
}
else if (strAttributeName  ==  convSqlDataSyn.SqlCommandText)
{
return mstrSqlCommandText;
}
else if (strAttributeName  ==  convSqlDataSyn.SqlDataRecNum)
{
return mintSqlDataRecNum;
}
else if (strAttributeName  ==  convSqlDataSyn.TargetTabCondition)
{
return mstrTargetTabCondition;
}
else if (strAttributeName  ==  convSqlDataSyn.TargetTabRecNum)
{
return mintTargetTabRecNum;
}
else if (strAttributeName  ==  convSqlDataSyn.DataSynDate)
{
return mstrDataSynDate;
}
else if (strAttributeName  ==  convSqlDataSyn.RecExclusiveWayId)
{
return mstrRecExclusiveWayId;
}
else if (strAttributeName  ==  convSqlDataSyn.TextResouce)
{
return mstrTextResouce;
}
else if (strAttributeName  ==  convSqlDataSyn.TextResourceTypeId)
{
return mstrTextResourceTypeId;
}
else if (strAttributeName  ==  convSqlDataSyn.AnalysisDate)
{
return mstrAnalysisDate;
}
else if (strAttributeName  ==  convSqlDataSyn.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convSqlDataSyn.ErrMsg)
{
return mstrErrMsg;
}
else if (strAttributeName  ==  convSqlDataSyn.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convSqlDataSyn.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convSqlDataSyn.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convSqlDataSyn.PrimaryTypeId)
{
mstrPrimaryTypeId = value.ToString();
 AddUpdatedFld(convSqlDataSyn.PrimaryTypeId);
}
else if (strAttributeName  ==  convSqlDataSyn.FieldNum)
{
mintFieldNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convSqlDataSyn.FieldNum);
}
else if (strAttributeName  ==  convSqlDataSyn.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(convSqlDataSyn.TabId);
}
else if (strAttributeName  ==  convSqlDataSyn.FuncModuleAgcId)
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convSqlDataSyn.FuncModuleAgcId);
}
else if (strAttributeName  ==  convSqlDataSyn.Keyword)
{
mstrKeyword = value.ToString();
 AddUpdatedFld(convSqlDataSyn.Keyword);
}
else if (strAttributeName  ==  convSqlDataSyn.TabTypeId)
{
mstrTabTypeId = value.ToString();
 AddUpdatedFld(convSqlDataSyn.TabTypeId);
}
else if (strAttributeName  ==  convSqlDataSyn.TabTypeName)
{
mstrTabTypeName = value.ToString();
 AddUpdatedFld(convSqlDataSyn.TabTypeName);
}
else if (strAttributeName  ==  convSqlDataSyn.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convSqlDataSyn.FuncModuleName);
}
else if (strAttributeName  ==  convSqlDataSyn.TabName)
{
mstrTabName = value.ToString();
 AddUpdatedFld(convSqlDataSyn.TabName);
}
else if (strAttributeName  ==  convSqlDataSyn.TabCnName)
{
mstrTabCnName = value.ToString();
 AddUpdatedFld(convSqlDataSyn.TabCnName);
}
else if (strAttributeName  ==  convSqlDataSyn.SqlData)
{
mstrSqlData = value.ToString();
 AddUpdatedFld(convSqlDataSyn.SqlData);
}
else if (strAttributeName  ==  convSqlDataSyn.SqlCommandTypeName)
{
mstrSqlCommandTypeName = value.ToString();
 AddUpdatedFld(convSqlDataSyn.SqlCommandTypeName);
}
else if (strAttributeName  ==  convSqlDataSyn.RecExclusiveWayName)
{
mstrRecExclusiveWayName = value.ToString();
 AddUpdatedFld(convSqlDataSyn.RecExclusiveWayName);
}
else if (strAttributeName  ==  convSqlDataSyn.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convSqlDataSyn.PrjName);
}
else if (strAttributeName  ==  convSqlDataSyn.PrimaryTypeName)
{
mstrPrimaryTypeName = value.ToString();
 AddUpdatedFld(convSqlDataSyn.PrimaryTypeName);
}
else if (strAttributeName  ==  convSqlDataSyn.SqlCommandTypeId)
{
mstrSqlCommandTypeId = value.ToString();
 AddUpdatedFld(convSqlDataSyn.SqlCommandTypeId);
}
else if (strAttributeName  ==  convSqlDataSyn.SqlCommandText)
{
mstrSqlCommandText = value.ToString();
 AddUpdatedFld(convSqlDataSyn.SqlCommandText);
}
else if (strAttributeName  ==  convSqlDataSyn.SqlDataRecNum)
{
mintSqlDataRecNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convSqlDataSyn.SqlDataRecNum);
}
else if (strAttributeName  ==  convSqlDataSyn.TargetTabCondition)
{
mstrTargetTabCondition = value.ToString();
 AddUpdatedFld(convSqlDataSyn.TargetTabCondition);
}
else if (strAttributeName  ==  convSqlDataSyn.TargetTabRecNum)
{
mintTargetTabRecNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convSqlDataSyn.TargetTabRecNum);
}
else if (strAttributeName  ==  convSqlDataSyn.DataSynDate)
{
mstrDataSynDate = value.ToString();
 AddUpdatedFld(convSqlDataSyn.DataSynDate);
}
else if (strAttributeName  ==  convSqlDataSyn.RecExclusiveWayId)
{
mstrRecExclusiveWayId = value.ToString();
 AddUpdatedFld(convSqlDataSyn.RecExclusiveWayId);
}
else if (strAttributeName  ==  convSqlDataSyn.TextResouce)
{
mstrTextResouce = value.ToString();
 AddUpdatedFld(convSqlDataSyn.TextResouce);
}
else if (strAttributeName  ==  convSqlDataSyn.TextResourceTypeId)
{
mstrTextResourceTypeId = value.ToString();
 AddUpdatedFld(convSqlDataSyn.TextResourceTypeId);
}
else if (strAttributeName  ==  convSqlDataSyn.AnalysisDate)
{
mstrAnalysisDate = value.ToString();
 AddUpdatedFld(convSqlDataSyn.AnalysisDate);
}
else if (strAttributeName  ==  convSqlDataSyn.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convSqlDataSyn.PrjId);
}
else if (strAttributeName  ==  convSqlDataSyn.ErrMsg)
{
mstrErrMsg = value.ToString();
 AddUpdatedFld(convSqlDataSyn.ErrMsg);
}
else if (strAttributeName  ==  convSqlDataSyn.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convSqlDataSyn.UpdDate);
}
else if (strAttributeName  ==  convSqlDataSyn.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convSqlDataSyn.UpdUserId);
}
else if (strAttributeName  ==  convSqlDataSyn.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convSqlDataSyn.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convSqlDataSyn.PrimaryTypeId  ==  _AttributeName[intIndex])
{
return mstrPrimaryTypeId;
}
else if (convSqlDataSyn.FieldNum  ==  _AttributeName[intIndex])
{
return mintFieldNum;
}
else if (convSqlDataSyn.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (convSqlDataSyn.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
return mstrFuncModuleAgcId;
}
else if (convSqlDataSyn.Keyword  ==  _AttributeName[intIndex])
{
return mstrKeyword;
}
else if (convSqlDataSyn.TabTypeId  ==  _AttributeName[intIndex])
{
return mstrTabTypeId;
}
else if (convSqlDataSyn.TabTypeName  ==  _AttributeName[intIndex])
{
return mstrTabTypeName;
}
else if (convSqlDataSyn.FuncModuleName  ==  _AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convSqlDataSyn.TabName  ==  _AttributeName[intIndex])
{
return mstrTabName;
}
else if (convSqlDataSyn.TabCnName  ==  _AttributeName[intIndex])
{
return mstrTabCnName;
}
else if (convSqlDataSyn.SqlData  ==  _AttributeName[intIndex])
{
return mstrSqlData;
}
else if (convSqlDataSyn.SqlCommandTypeName  ==  _AttributeName[intIndex])
{
return mstrSqlCommandTypeName;
}
else if (convSqlDataSyn.RecExclusiveWayName  ==  _AttributeName[intIndex])
{
return mstrRecExclusiveWayName;
}
else if (convSqlDataSyn.PrjName  ==  _AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convSqlDataSyn.PrimaryTypeName  ==  _AttributeName[intIndex])
{
return mstrPrimaryTypeName;
}
else if (convSqlDataSyn.SqlCommandTypeId  ==  _AttributeName[intIndex])
{
return mstrSqlCommandTypeId;
}
else if (convSqlDataSyn.SqlCommandText  ==  _AttributeName[intIndex])
{
return mstrSqlCommandText;
}
else if (convSqlDataSyn.SqlDataRecNum  ==  _AttributeName[intIndex])
{
return mintSqlDataRecNum;
}
else if (convSqlDataSyn.TargetTabCondition  ==  _AttributeName[intIndex])
{
return mstrTargetTabCondition;
}
else if (convSqlDataSyn.TargetTabRecNum  ==  _AttributeName[intIndex])
{
return mintTargetTabRecNum;
}
else if (convSqlDataSyn.DataSynDate  ==  _AttributeName[intIndex])
{
return mstrDataSynDate;
}
else if (convSqlDataSyn.RecExclusiveWayId  ==  _AttributeName[intIndex])
{
return mstrRecExclusiveWayId;
}
else if (convSqlDataSyn.TextResouce  ==  _AttributeName[intIndex])
{
return mstrTextResouce;
}
else if (convSqlDataSyn.TextResourceTypeId  ==  _AttributeName[intIndex])
{
return mstrTextResourceTypeId;
}
else if (convSqlDataSyn.AnalysisDate  ==  _AttributeName[intIndex])
{
return mstrAnalysisDate;
}
else if (convSqlDataSyn.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convSqlDataSyn.ErrMsg  ==  _AttributeName[intIndex])
{
return mstrErrMsg;
}
else if (convSqlDataSyn.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convSqlDataSyn.UpdUserId  ==  _AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convSqlDataSyn.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convSqlDataSyn.PrimaryTypeId  ==  _AttributeName[intIndex])
{
mstrPrimaryTypeId = value.ToString();
 AddUpdatedFld(convSqlDataSyn.PrimaryTypeId);
}
else if (convSqlDataSyn.FieldNum  ==  _AttributeName[intIndex])
{
mintFieldNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convSqlDataSyn.FieldNum);
}
else if (convSqlDataSyn.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(convSqlDataSyn.TabId);
}
else if (convSqlDataSyn.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convSqlDataSyn.FuncModuleAgcId);
}
else if (convSqlDataSyn.Keyword  ==  _AttributeName[intIndex])
{
mstrKeyword = value.ToString();
 AddUpdatedFld(convSqlDataSyn.Keyword);
}
else if (convSqlDataSyn.TabTypeId  ==  _AttributeName[intIndex])
{
mstrTabTypeId = value.ToString();
 AddUpdatedFld(convSqlDataSyn.TabTypeId);
}
else if (convSqlDataSyn.TabTypeName  ==  _AttributeName[intIndex])
{
mstrTabTypeName = value.ToString();
 AddUpdatedFld(convSqlDataSyn.TabTypeName);
}
else if (convSqlDataSyn.FuncModuleName  ==  _AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convSqlDataSyn.FuncModuleName);
}
else if (convSqlDataSyn.TabName  ==  _AttributeName[intIndex])
{
mstrTabName = value.ToString();
 AddUpdatedFld(convSqlDataSyn.TabName);
}
else if (convSqlDataSyn.TabCnName  ==  _AttributeName[intIndex])
{
mstrTabCnName = value.ToString();
 AddUpdatedFld(convSqlDataSyn.TabCnName);
}
else if (convSqlDataSyn.SqlData  ==  _AttributeName[intIndex])
{
mstrSqlData = value.ToString();
 AddUpdatedFld(convSqlDataSyn.SqlData);
}
else if (convSqlDataSyn.SqlCommandTypeName  ==  _AttributeName[intIndex])
{
mstrSqlCommandTypeName = value.ToString();
 AddUpdatedFld(convSqlDataSyn.SqlCommandTypeName);
}
else if (convSqlDataSyn.RecExclusiveWayName  ==  _AttributeName[intIndex])
{
mstrRecExclusiveWayName = value.ToString();
 AddUpdatedFld(convSqlDataSyn.RecExclusiveWayName);
}
else if (convSqlDataSyn.PrjName  ==  _AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convSqlDataSyn.PrjName);
}
else if (convSqlDataSyn.PrimaryTypeName  ==  _AttributeName[intIndex])
{
mstrPrimaryTypeName = value.ToString();
 AddUpdatedFld(convSqlDataSyn.PrimaryTypeName);
}
else if (convSqlDataSyn.SqlCommandTypeId  ==  _AttributeName[intIndex])
{
mstrSqlCommandTypeId = value.ToString();
 AddUpdatedFld(convSqlDataSyn.SqlCommandTypeId);
}
else if (convSqlDataSyn.SqlCommandText  ==  _AttributeName[intIndex])
{
mstrSqlCommandText = value.ToString();
 AddUpdatedFld(convSqlDataSyn.SqlCommandText);
}
else if (convSqlDataSyn.SqlDataRecNum  ==  _AttributeName[intIndex])
{
mintSqlDataRecNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convSqlDataSyn.SqlDataRecNum);
}
else if (convSqlDataSyn.TargetTabCondition  ==  _AttributeName[intIndex])
{
mstrTargetTabCondition = value.ToString();
 AddUpdatedFld(convSqlDataSyn.TargetTabCondition);
}
else if (convSqlDataSyn.TargetTabRecNum  ==  _AttributeName[intIndex])
{
mintTargetTabRecNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convSqlDataSyn.TargetTabRecNum);
}
else if (convSqlDataSyn.DataSynDate  ==  _AttributeName[intIndex])
{
mstrDataSynDate = value.ToString();
 AddUpdatedFld(convSqlDataSyn.DataSynDate);
}
else if (convSqlDataSyn.RecExclusiveWayId  ==  _AttributeName[intIndex])
{
mstrRecExclusiveWayId = value.ToString();
 AddUpdatedFld(convSqlDataSyn.RecExclusiveWayId);
}
else if (convSqlDataSyn.TextResouce  ==  _AttributeName[intIndex])
{
mstrTextResouce = value.ToString();
 AddUpdatedFld(convSqlDataSyn.TextResouce);
}
else if (convSqlDataSyn.TextResourceTypeId  ==  _AttributeName[intIndex])
{
mstrTextResourceTypeId = value.ToString();
 AddUpdatedFld(convSqlDataSyn.TextResourceTypeId);
}
else if (convSqlDataSyn.AnalysisDate  ==  _AttributeName[intIndex])
{
mstrAnalysisDate = value.ToString();
 AddUpdatedFld(convSqlDataSyn.AnalysisDate);
}
else if (convSqlDataSyn.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convSqlDataSyn.PrjId);
}
else if (convSqlDataSyn.ErrMsg  ==  _AttributeName[intIndex])
{
mstrErrMsg = value.ToString();
 AddUpdatedFld(convSqlDataSyn.ErrMsg);
}
else if (convSqlDataSyn.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convSqlDataSyn.UpdDate);
}
else if (convSqlDataSyn.UpdUserId  ==  _AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convSqlDataSyn.UpdUserId);
}
else if (convSqlDataSyn.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convSqlDataSyn.Memo);
}
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
 AddUpdatedFld(convSqlDataSyn.PrimaryTypeId);
}
}
/// <summary>
/// FieldNum(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? FieldNum
{
get
{
return mintFieldNum;
}
set
{
 mintFieldNum = value;
//记录修改过的字段
 AddUpdatedFld(convSqlDataSyn.FieldNum);
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
 AddUpdatedFld(convSqlDataSyn.TabId);
}
}
/// <summary>
/// 功能模块Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleAgcId
{
get
{
return mstrFuncModuleAgcId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleAgcId = value;
}
else
{
 mstrFuncModuleAgcId = value;
}
//记录修改过的字段
 AddUpdatedFld(convSqlDataSyn.FuncModuleAgcId);
}
}
/// <summary>
/// 关键字(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Keyword
{
get
{
return mstrKeyword;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeyword = value;
}
else
{
 mstrKeyword = value;
}
//记录修改过的字段
 AddUpdatedFld(convSqlDataSyn.Keyword);
}
}
/// <summary>
/// 表类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabTypeId
{
get
{
return mstrTabTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabTypeId = value;
}
else
{
 mstrTabTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convSqlDataSyn.TabTypeId);
}
}
/// <summary>
/// 表类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabTypeName
{
get
{
return mstrTabTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabTypeName = value;
}
else
{
 mstrTabTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convSqlDataSyn.TabTypeName);
}
}
/// <summary>
/// 功能模块名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleName
{
get
{
return mstrFuncModuleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleName = value;
}
else
{
 mstrFuncModuleName = value;
}
//记录修改过的字段
 AddUpdatedFld(convSqlDataSyn.FuncModuleName);
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
 AddUpdatedFld(convSqlDataSyn.TabName);
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
 AddUpdatedFld(convSqlDataSyn.TabCnName);
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
 AddUpdatedFld(convSqlDataSyn.SqlData);
}
}
/// <summary>
/// Sql命令类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SqlCommandTypeName
{
get
{
return mstrSqlCommandTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSqlCommandTypeName = value;
}
else
{
 mstrSqlCommandTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convSqlDataSyn.SqlCommandTypeName);
}
}
/// <summary>
/// 记录排他方式名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RecExclusiveWayName
{
get
{
return mstrRecExclusiveWayName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRecExclusiveWayName = value;
}
else
{
 mstrRecExclusiveWayName = value;
}
//记录修改过的字段
 AddUpdatedFld(convSqlDataSyn.RecExclusiveWayName);
}
}
/// <summary>
/// 工程名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjName
{
get
{
return mstrPrjName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjName = value;
}
else
{
 mstrPrjName = value;
}
//记录修改过的字段
 AddUpdatedFld(convSqlDataSyn.PrjName);
}
}
/// <summary>
/// 主键类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrimaryTypeName
{
get
{
return mstrPrimaryTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrimaryTypeName = value;
}
else
{
 mstrPrimaryTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convSqlDataSyn.PrimaryTypeName);
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
 AddUpdatedFld(convSqlDataSyn.SqlCommandTypeId);
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
 AddUpdatedFld(convSqlDataSyn.SqlCommandText);
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
 AddUpdatedFld(convSqlDataSyn.SqlDataRecNum);
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
 AddUpdatedFld(convSqlDataSyn.TargetTabCondition);
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
 AddUpdatedFld(convSqlDataSyn.TargetTabRecNum);
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
 AddUpdatedFld(convSqlDataSyn.DataSynDate);
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
 AddUpdatedFld(convSqlDataSyn.RecExclusiveWayId);
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
 AddUpdatedFld(convSqlDataSyn.TextResouce);
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
 AddUpdatedFld(convSqlDataSyn.TextResourceTypeId);
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
 AddUpdatedFld(convSqlDataSyn.AnalysisDate);
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
 AddUpdatedFld(convSqlDataSyn.PrjId);
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
 AddUpdatedFld(convSqlDataSyn.ErrMsg);
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
 AddUpdatedFld(convSqlDataSyn.UpdDate);
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
 AddUpdatedFld(convSqlDataSyn.UpdUserId);
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
 AddUpdatedFld(convSqlDataSyn.Memo);
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
 /// vSql数据同步(vSqlDataSyn)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convSqlDataSyn
{
public const string _CurrTabName = "vSqlDataSyn"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TabId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"PrimaryTypeId", "FieldNum", "TabId", "FuncModuleAgcId", "Keyword", "TabTypeId", "TabTypeName", "FuncModuleName", "TabName", "TabCnName", "SqlData", "SqlCommandTypeName", "RecExclusiveWayName", "PrjName", "PrimaryTypeName", "SqlCommandTypeId", "SqlCommandText", "SqlDataRecNum", "TargetTabCondition", "TargetTabRecNum", "DataSynDate", "RecExclusiveWayId", "TextResouce", "TextResourceTypeId", "AnalysisDate", "PrjId", "ErrMsg", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"PrimaryTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrimaryTypeId = "PrimaryTypeId";    //主键类型ID

 /// <summary>
 /// 常量:"FieldNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FieldNum = "FieldNum";    //FieldNum

 /// <summary>
 /// 常量:"TabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabId = "TabId";    //表ID

 /// <summary>
 /// 常量:"FuncModuleAgcId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleAgcId = "FuncModuleAgcId";    //功能模块Id

 /// <summary>
 /// 常量:"Keyword"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Keyword = "Keyword";    //关键字

 /// <summary>
 /// 常量:"TabTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabTypeId = "TabTypeId";    //表类型Id

 /// <summary>
 /// 常量:"TabTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabTypeName = "TabTypeName";    //表类型名

 /// <summary>
 /// 常量:"FuncModuleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleName = "FuncModuleName";    //功能模块名称

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
 /// 常量:"SqlData"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SqlData = "SqlData";    //Sql表数据

 /// <summary>
 /// 常量:"SqlCommandTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SqlCommandTypeName = "SqlCommandTypeName";    //Sql命令类型名称

 /// <summary>
 /// 常量:"RecExclusiveWayName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RecExclusiveWayName = "RecExclusiveWayName";    //记录排他方式名称

 /// <summary>
 /// 常量:"PrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjName = "PrjName";    //工程名称

 /// <summary>
 /// 常量:"PrimaryTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrimaryTypeName = "PrimaryTypeName";    //主键类型名

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