
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTabCheckResultEN
 表名:vTabCheckResult(00050191)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:37:01
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:日志管理(LogManage)
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
 /// 表vTabCheckResult的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vTabCheckResult
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
public K_mId_vTabCheckResult(long lngmId)
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
 /// <returns>返回:[K_mId_vTabCheckResult]类型的对象</returns>
public static implicit operator K_mId_vTabCheckResult(long value)
{
return new K_mId_vTabCheckResult(value);
}
}
 /// <summary>
 /// v表检查结果(vTabCheckResult)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvTabCheckResultEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vTabCheckResult"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 25;
public static string[] _AttributeName = new string[] {"mId", "PrjId", "FldId", "PrjName", "PrjDataBaseName", "PrjDataBaseId", "TabId", "TabName", "TabCnName", "FldName", "ErrorLevelId", "ErrorLevelName", "ErrorMsg", "CheckDate", "CheckUser", "Memo", "SqlDsTypeId", "SqlDsTypeName", "DataBaseName", "FuncModuleAgcId", "FuncModuleName", "TabCheckErrorTypeId", "TabCheckErrorTypeName", "TabStateId", "OrderNum4Refer"};

protected long mlngmId;    //mId
protected string mstrPrjId;    //工程Id
protected string mstrFldId;    //字段Id
protected string mstrPrjName;    //工程名称
protected string mstrPrjDataBaseName;    //项目数据库名
protected string mstrPrjDataBaseId;    //项目数据库Id
protected string mstrTabId;    //表ID
protected string mstrTabName;    //表名
protected string mstrTabCnName;    //表中文名
protected string mstrFldName;    //字段名
protected int mintErrorLevelId;    //错误等级Id
protected string mstrErrorLevelName;    //错误等级名
protected string mstrErrorMsg;    //错误信息
protected string mstrCheckDate;    //检查日期
protected string mstrCheckUser;    //检查人
protected string mstrMemo;    //说明
protected string mstrSqlDsTypeId;    //数据源类型Id
protected string mstrSqlDsTypeName;    //Sql数据源名
protected string mstrDataBaseName;    //数据库名
protected string mstrFuncModuleAgcId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrTabCheckErrorTypeId;    //表检查错误类型Id
protected string mstrTabCheckErrorTypeName;    //表检查错误类型名
protected string mstrTabStateId;    //表状态ID
protected int? mintOrderNum4Refer;    //引用序号

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvTabCheckResultEN()
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
public clsvTabCheckResultEN(long lngmId)
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
if (strAttributeName  ==  convTabCheckResult.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convTabCheckResult.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convTabCheckResult.FldId)
{
return mstrFldId;
}
else if (strAttributeName  ==  convTabCheckResult.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convTabCheckResult.PrjDataBaseName)
{
return mstrPrjDataBaseName;
}
else if (strAttributeName  ==  convTabCheckResult.PrjDataBaseId)
{
return mstrPrjDataBaseId;
}
else if (strAttributeName  ==  convTabCheckResult.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  convTabCheckResult.TabName)
{
return mstrTabName;
}
else if (strAttributeName  ==  convTabCheckResult.TabCnName)
{
return mstrTabCnName;
}
else if (strAttributeName  ==  convTabCheckResult.FldName)
{
return mstrFldName;
}
else if (strAttributeName  ==  convTabCheckResult.ErrorLevelId)
{
return mintErrorLevelId;
}
else if (strAttributeName  ==  convTabCheckResult.ErrorLevelName)
{
return mstrErrorLevelName;
}
else if (strAttributeName  ==  convTabCheckResult.ErrorMsg)
{
return mstrErrorMsg;
}
else if (strAttributeName  ==  convTabCheckResult.CheckDate)
{
return mstrCheckDate;
}
else if (strAttributeName  ==  convTabCheckResult.CheckUser)
{
return mstrCheckUser;
}
else if (strAttributeName  ==  convTabCheckResult.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convTabCheckResult.SqlDsTypeId)
{
return mstrSqlDsTypeId;
}
else if (strAttributeName  ==  convTabCheckResult.SqlDsTypeName)
{
return mstrSqlDsTypeName;
}
else if (strAttributeName  ==  convTabCheckResult.DataBaseName)
{
return mstrDataBaseName;
}
else if (strAttributeName  ==  convTabCheckResult.FuncModuleAgcId)
{
return mstrFuncModuleAgcId;
}
else if (strAttributeName  ==  convTabCheckResult.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convTabCheckResult.TabCheckErrorTypeId)
{
return mstrTabCheckErrorTypeId;
}
else if (strAttributeName  ==  convTabCheckResult.TabCheckErrorTypeName)
{
return mstrTabCheckErrorTypeName;
}
else if (strAttributeName  ==  convTabCheckResult.TabStateId)
{
return mstrTabStateId;
}
else if (strAttributeName  ==  convTabCheckResult.OrderNum4Refer)
{
return mintOrderNum4Refer;
}
return null;
}
set
{
if (strAttributeName  ==  convTabCheckResult.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convTabCheckResult.mId);
}
else if (strAttributeName  ==  convTabCheckResult.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convTabCheckResult.PrjId);
}
else if (strAttributeName  ==  convTabCheckResult.FldId)
{
mstrFldId = value.ToString();
 AddUpdatedFld(convTabCheckResult.FldId);
}
else if (strAttributeName  ==  convTabCheckResult.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convTabCheckResult.PrjName);
}
else if (strAttributeName  ==  convTabCheckResult.PrjDataBaseName)
{
mstrPrjDataBaseName = value.ToString();
 AddUpdatedFld(convTabCheckResult.PrjDataBaseName);
}
else if (strAttributeName  ==  convTabCheckResult.PrjDataBaseId)
{
mstrPrjDataBaseId = value.ToString();
 AddUpdatedFld(convTabCheckResult.PrjDataBaseId);
}
else if (strAttributeName  ==  convTabCheckResult.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(convTabCheckResult.TabId);
}
else if (strAttributeName  ==  convTabCheckResult.TabName)
{
mstrTabName = value.ToString();
 AddUpdatedFld(convTabCheckResult.TabName);
}
else if (strAttributeName  ==  convTabCheckResult.TabCnName)
{
mstrTabCnName = value.ToString();
 AddUpdatedFld(convTabCheckResult.TabCnName);
}
else if (strAttributeName  ==  convTabCheckResult.FldName)
{
mstrFldName = value.ToString();
 AddUpdatedFld(convTabCheckResult.FldName);
}
else if (strAttributeName  ==  convTabCheckResult.ErrorLevelId)
{
mintErrorLevelId = TransNullToInt(value.ToString());
 AddUpdatedFld(convTabCheckResult.ErrorLevelId);
}
else if (strAttributeName  ==  convTabCheckResult.ErrorLevelName)
{
mstrErrorLevelName = value.ToString();
 AddUpdatedFld(convTabCheckResult.ErrorLevelName);
}
else if (strAttributeName  ==  convTabCheckResult.ErrorMsg)
{
mstrErrorMsg = value.ToString();
 AddUpdatedFld(convTabCheckResult.ErrorMsg);
}
else if (strAttributeName  ==  convTabCheckResult.CheckDate)
{
mstrCheckDate = value.ToString();
 AddUpdatedFld(convTabCheckResult.CheckDate);
}
else if (strAttributeName  ==  convTabCheckResult.CheckUser)
{
mstrCheckUser = value.ToString();
 AddUpdatedFld(convTabCheckResult.CheckUser);
}
else if (strAttributeName  ==  convTabCheckResult.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convTabCheckResult.Memo);
}
else if (strAttributeName  ==  convTabCheckResult.SqlDsTypeId)
{
mstrSqlDsTypeId = value.ToString();
 AddUpdatedFld(convTabCheckResult.SqlDsTypeId);
}
else if (strAttributeName  ==  convTabCheckResult.SqlDsTypeName)
{
mstrSqlDsTypeName = value.ToString();
 AddUpdatedFld(convTabCheckResult.SqlDsTypeName);
}
else if (strAttributeName  ==  convTabCheckResult.DataBaseName)
{
mstrDataBaseName = value.ToString();
 AddUpdatedFld(convTabCheckResult.DataBaseName);
}
else if (strAttributeName  ==  convTabCheckResult.FuncModuleAgcId)
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convTabCheckResult.FuncModuleAgcId);
}
else if (strAttributeName  ==  convTabCheckResult.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convTabCheckResult.FuncModuleName);
}
else if (strAttributeName  ==  convTabCheckResult.TabCheckErrorTypeId)
{
mstrTabCheckErrorTypeId = value.ToString();
 AddUpdatedFld(convTabCheckResult.TabCheckErrorTypeId);
}
else if (strAttributeName  ==  convTabCheckResult.TabCheckErrorTypeName)
{
mstrTabCheckErrorTypeName = value.ToString();
 AddUpdatedFld(convTabCheckResult.TabCheckErrorTypeName);
}
else if (strAttributeName  ==  convTabCheckResult.TabStateId)
{
mstrTabStateId = value.ToString();
 AddUpdatedFld(convTabCheckResult.TabStateId);
}
else if (strAttributeName  ==  convTabCheckResult.OrderNum4Refer)
{
mintOrderNum4Refer = TransNullToInt(value.ToString());
 AddUpdatedFld(convTabCheckResult.OrderNum4Refer);
}
}
}
public object this[int intIndex]
{
get
{
if (convTabCheckResult.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (convTabCheckResult.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convTabCheckResult.FldId  ==  _AttributeName[intIndex])
{
return mstrFldId;
}
else if (convTabCheckResult.PrjName  ==  _AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convTabCheckResult.PrjDataBaseName  ==  _AttributeName[intIndex])
{
return mstrPrjDataBaseName;
}
else if (convTabCheckResult.PrjDataBaseId  ==  _AttributeName[intIndex])
{
return mstrPrjDataBaseId;
}
else if (convTabCheckResult.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (convTabCheckResult.TabName  ==  _AttributeName[intIndex])
{
return mstrTabName;
}
else if (convTabCheckResult.TabCnName  ==  _AttributeName[intIndex])
{
return mstrTabCnName;
}
else if (convTabCheckResult.FldName  ==  _AttributeName[intIndex])
{
return mstrFldName;
}
else if (convTabCheckResult.ErrorLevelId  ==  _AttributeName[intIndex])
{
return mintErrorLevelId;
}
else if (convTabCheckResult.ErrorLevelName  ==  _AttributeName[intIndex])
{
return mstrErrorLevelName;
}
else if (convTabCheckResult.ErrorMsg  ==  _AttributeName[intIndex])
{
return mstrErrorMsg;
}
else if (convTabCheckResult.CheckDate  ==  _AttributeName[intIndex])
{
return mstrCheckDate;
}
else if (convTabCheckResult.CheckUser  ==  _AttributeName[intIndex])
{
return mstrCheckUser;
}
else if (convTabCheckResult.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (convTabCheckResult.SqlDsTypeId  ==  _AttributeName[intIndex])
{
return mstrSqlDsTypeId;
}
else if (convTabCheckResult.SqlDsTypeName  ==  _AttributeName[intIndex])
{
return mstrSqlDsTypeName;
}
else if (convTabCheckResult.DataBaseName  ==  _AttributeName[intIndex])
{
return mstrDataBaseName;
}
else if (convTabCheckResult.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
return mstrFuncModuleAgcId;
}
else if (convTabCheckResult.FuncModuleName  ==  _AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convTabCheckResult.TabCheckErrorTypeId  ==  _AttributeName[intIndex])
{
return mstrTabCheckErrorTypeId;
}
else if (convTabCheckResult.TabCheckErrorTypeName  ==  _AttributeName[intIndex])
{
return mstrTabCheckErrorTypeName;
}
else if (convTabCheckResult.TabStateId  ==  _AttributeName[intIndex])
{
return mstrTabStateId;
}
else if (convTabCheckResult.OrderNum4Refer  ==  _AttributeName[intIndex])
{
return mintOrderNum4Refer;
}
return null;
}
set
{
if (convTabCheckResult.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convTabCheckResult.mId);
}
else if (convTabCheckResult.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convTabCheckResult.PrjId);
}
else if (convTabCheckResult.FldId  ==  _AttributeName[intIndex])
{
mstrFldId = value.ToString();
 AddUpdatedFld(convTabCheckResult.FldId);
}
else if (convTabCheckResult.PrjName  ==  _AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convTabCheckResult.PrjName);
}
else if (convTabCheckResult.PrjDataBaseName  ==  _AttributeName[intIndex])
{
mstrPrjDataBaseName = value.ToString();
 AddUpdatedFld(convTabCheckResult.PrjDataBaseName);
}
else if (convTabCheckResult.PrjDataBaseId  ==  _AttributeName[intIndex])
{
mstrPrjDataBaseId = value.ToString();
 AddUpdatedFld(convTabCheckResult.PrjDataBaseId);
}
else if (convTabCheckResult.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(convTabCheckResult.TabId);
}
else if (convTabCheckResult.TabName  ==  _AttributeName[intIndex])
{
mstrTabName = value.ToString();
 AddUpdatedFld(convTabCheckResult.TabName);
}
else if (convTabCheckResult.TabCnName  ==  _AttributeName[intIndex])
{
mstrTabCnName = value.ToString();
 AddUpdatedFld(convTabCheckResult.TabCnName);
}
else if (convTabCheckResult.FldName  ==  _AttributeName[intIndex])
{
mstrFldName = value.ToString();
 AddUpdatedFld(convTabCheckResult.FldName);
}
else if (convTabCheckResult.ErrorLevelId  ==  _AttributeName[intIndex])
{
mintErrorLevelId = TransNullToInt(value.ToString());
 AddUpdatedFld(convTabCheckResult.ErrorLevelId);
}
else if (convTabCheckResult.ErrorLevelName  ==  _AttributeName[intIndex])
{
mstrErrorLevelName = value.ToString();
 AddUpdatedFld(convTabCheckResult.ErrorLevelName);
}
else if (convTabCheckResult.ErrorMsg  ==  _AttributeName[intIndex])
{
mstrErrorMsg = value.ToString();
 AddUpdatedFld(convTabCheckResult.ErrorMsg);
}
else if (convTabCheckResult.CheckDate  ==  _AttributeName[intIndex])
{
mstrCheckDate = value.ToString();
 AddUpdatedFld(convTabCheckResult.CheckDate);
}
else if (convTabCheckResult.CheckUser  ==  _AttributeName[intIndex])
{
mstrCheckUser = value.ToString();
 AddUpdatedFld(convTabCheckResult.CheckUser);
}
else if (convTabCheckResult.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convTabCheckResult.Memo);
}
else if (convTabCheckResult.SqlDsTypeId  ==  _AttributeName[intIndex])
{
mstrSqlDsTypeId = value.ToString();
 AddUpdatedFld(convTabCheckResult.SqlDsTypeId);
}
else if (convTabCheckResult.SqlDsTypeName  ==  _AttributeName[intIndex])
{
mstrSqlDsTypeName = value.ToString();
 AddUpdatedFld(convTabCheckResult.SqlDsTypeName);
}
else if (convTabCheckResult.DataBaseName  ==  _AttributeName[intIndex])
{
mstrDataBaseName = value.ToString();
 AddUpdatedFld(convTabCheckResult.DataBaseName);
}
else if (convTabCheckResult.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convTabCheckResult.FuncModuleAgcId);
}
else if (convTabCheckResult.FuncModuleName  ==  _AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convTabCheckResult.FuncModuleName);
}
else if (convTabCheckResult.TabCheckErrorTypeId  ==  _AttributeName[intIndex])
{
mstrTabCheckErrorTypeId = value.ToString();
 AddUpdatedFld(convTabCheckResult.TabCheckErrorTypeId);
}
else if (convTabCheckResult.TabCheckErrorTypeName  ==  _AttributeName[intIndex])
{
mstrTabCheckErrorTypeName = value.ToString();
 AddUpdatedFld(convTabCheckResult.TabCheckErrorTypeName);
}
else if (convTabCheckResult.TabStateId  ==  _AttributeName[intIndex])
{
mstrTabStateId = value.ToString();
 AddUpdatedFld(convTabCheckResult.TabStateId);
}
else if (convTabCheckResult.OrderNum4Refer  ==  _AttributeName[intIndex])
{
mintOrderNum4Refer = TransNullToInt(value.ToString());
 AddUpdatedFld(convTabCheckResult.OrderNum4Refer);
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
 AddUpdatedFld(convTabCheckResult.mId);
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
 AddUpdatedFld(convTabCheckResult.PrjId);
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
 AddUpdatedFld(convTabCheckResult.FldId);
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
 AddUpdatedFld(convTabCheckResult.PrjName);
}
}
/// <summary>
/// 项目数据库名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjDataBaseName
{
get
{
return mstrPrjDataBaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjDataBaseName = value;
}
else
{
 mstrPrjDataBaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabCheckResult.PrjDataBaseName);
}
}
/// <summary>
/// 项目数据库Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjDataBaseId
{
get
{
return mstrPrjDataBaseId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjDataBaseId = value;
}
else
{
 mstrPrjDataBaseId = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabCheckResult.PrjDataBaseId);
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
 AddUpdatedFld(convTabCheckResult.TabId);
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
 AddUpdatedFld(convTabCheckResult.TabName);
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
 AddUpdatedFld(convTabCheckResult.TabCnName);
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
 AddUpdatedFld(convTabCheckResult.FldName);
}
}
/// <summary>
/// 错误等级Id(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int ErrorLevelId
{
get
{
return mintErrorLevelId;
}
set
{
 mintErrorLevelId = value;
//记录修改过的字段
 AddUpdatedFld(convTabCheckResult.ErrorLevelId);
}
}
/// <summary>
/// 错误等级名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ErrorLevelName
{
get
{
return mstrErrorLevelName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrErrorLevelName = value;
}
else
{
 mstrErrorLevelName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabCheckResult.ErrorLevelName);
}
}
/// <summary>
/// 错误信息(说明:;字段类型:varchar;字段长度:5000;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ErrorMsg
{
get
{
return mstrErrorMsg;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrErrorMsg = value;
}
else
{
 mstrErrorMsg = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabCheckResult.ErrorMsg);
}
}
/// <summary>
/// 检查日期(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CheckDate
{
get
{
return mstrCheckDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCheckDate = value;
}
else
{
 mstrCheckDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabCheckResult.CheckDate);
}
}
/// <summary>
/// 检查人(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CheckUser
{
get
{
return mstrCheckUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCheckUser = value;
}
else
{
 mstrCheckUser = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabCheckResult.CheckUser);
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
 AddUpdatedFld(convTabCheckResult.Memo);
}
}
/// <summary>
/// 数据源类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SqlDsTypeId
{
get
{
return mstrSqlDsTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSqlDsTypeId = value;
}
else
{
 mstrSqlDsTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabCheckResult.SqlDsTypeId);
}
}
/// <summary>
/// Sql数据源名(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SqlDsTypeName
{
get
{
return mstrSqlDsTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSqlDsTypeName = value;
}
else
{
 mstrSqlDsTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabCheckResult.SqlDsTypeName);
}
}
/// <summary>
/// 数据库名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataBaseName
{
get
{
return mstrDataBaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataBaseName = value;
}
else
{
 mstrDataBaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabCheckResult.DataBaseName);
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
 AddUpdatedFld(convTabCheckResult.FuncModuleAgcId);
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
 AddUpdatedFld(convTabCheckResult.FuncModuleName);
}
}
/// <summary>
/// 表检查错误类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabCheckErrorTypeId
{
get
{
return mstrTabCheckErrorTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabCheckErrorTypeId = value;
}
else
{
 mstrTabCheckErrorTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabCheckResult.TabCheckErrorTypeId);
}
}
/// <summary>
/// 表检查错误类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabCheckErrorTypeName
{
get
{
return mstrTabCheckErrorTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabCheckErrorTypeName = value;
}
else
{
 mstrTabCheckErrorTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabCheckResult.TabCheckErrorTypeName);
}
}
/// <summary>
/// 表状态ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabStateId
{
get
{
return mstrTabStateId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabStateId = value;
}
else
{
 mstrTabStateId = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabCheckResult.TabStateId);
}
}
/// <summary>
/// 引用序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OrderNum4Refer
{
get
{
return mintOrderNum4Refer;
}
set
{
 mintOrderNum4Refer = value;
//记录修改过的字段
 AddUpdatedFld(convTabCheckResult.OrderNum4Refer);
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
 /// v表检查结果(vTabCheckResult)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convTabCheckResult
{
public const string _CurrTabName = "vTabCheckResult"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "PrjId", "FldId", "PrjName", "PrjDataBaseName", "PrjDataBaseId", "TabId", "TabName", "TabCnName", "FldName", "ErrorLevelId", "ErrorLevelName", "ErrorMsg", "CheckDate", "CheckUser", "Memo", "SqlDsTypeId", "SqlDsTypeName", "DataBaseName", "FuncModuleAgcId", "FuncModuleName", "TabCheckErrorTypeId", "TabCheckErrorTypeName", "TabStateId", "OrderNum4Refer"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"FldId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldId = "FldId";    //字段Id

 /// <summary>
 /// 常量:"PrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjName = "PrjName";    //工程名称

 /// <summary>
 /// 常量:"PrjDataBaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjDataBaseName = "PrjDataBaseName";    //项目数据库名

 /// <summary>
 /// 常量:"PrjDataBaseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjDataBaseId = "PrjDataBaseId";    //项目数据库Id

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
 /// 常量:"FldName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldName = "FldName";    //字段名

 /// <summary>
 /// 常量:"ErrorLevelId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ErrorLevelId = "ErrorLevelId";    //错误等级Id

 /// <summary>
 /// 常量:"ErrorLevelName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ErrorLevelName = "ErrorLevelName";    //错误等级名

 /// <summary>
 /// 常量:"ErrorMsg"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ErrorMsg = "ErrorMsg";    //错误信息

 /// <summary>
 /// 常量:"CheckDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CheckDate = "CheckDate";    //检查日期

 /// <summary>
 /// 常量:"CheckUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CheckUser = "CheckUser";    //检查人

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明

 /// <summary>
 /// 常量:"SqlDsTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SqlDsTypeId = "SqlDsTypeId";    //数据源类型Id

 /// <summary>
 /// 常量:"SqlDsTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SqlDsTypeName = "SqlDsTypeName";    //Sql数据源名

 /// <summary>
 /// 常量:"DataBaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataBaseName = "DataBaseName";    //数据库名

 /// <summary>
 /// 常量:"FuncModuleAgcId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleAgcId = "FuncModuleAgcId";    //功能模块Id

 /// <summary>
 /// 常量:"FuncModuleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleName = "FuncModuleName";    //功能模块名称

 /// <summary>
 /// 常量:"TabCheckErrorTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabCheckErrorTypeId = "TabCheckErrorTypeId";    //表检查错误类型Id

 /// <summary>
 /// 常量:"TabCheckErrorTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabCheckErrorTypeName = "TabCheckErrorTypeName";    //表检查错误类型名

 /// <summary>
 /// 常量:"TabStateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabStateId = "TabStateId";    //表状态ID

 /// <summary>
 /// 常量:"OrderNum4Refer"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum4Refer = "OrderNum4Refer";    //引用序号
}

}