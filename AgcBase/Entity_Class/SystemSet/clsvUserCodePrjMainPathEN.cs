
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvUserCodePrjMainPathEN
 表名:vUserCodePrjMainPath(00050339)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:03:32
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统设置(SystemSet)
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
 /// 表vUserCodePrjMainPath的关键字(UserCodePrjMainPathId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_UserCodePrjMainPathId_vUserCodePrjMainPath
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strUserCodePrjMainPathId">表关键字</param>
public K_UserCodePrjMainPathId_vUserCodePrjMainPath(string strUserCodePrjMainPathId)
{
if (IsValid(strUserCodePrjMainPathId)) Value = strUserCodePrjMainPathId;
else
{
Value = null;
}
}
private static bool IsValid(string strUserCodePrjMainPathId)
{
if (string.IsNullOrEmpty(strUserCodePrjMainPathId) == true) return false;
if (strUserCodePrjMainPathId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_UserCodePrjMainPathId_vUserCodePrjMainPath]类型的对象</returns>
public static implicit operator K_UserCodePrjMainPathId_vUserCodePrjMainPath(string value)
{
return new K_UserCodePrjMainPathId_vUserCodePrjMainPath(value);
}
}
 /// <summary>
 /// v用户生成项目主路径(vUserCodePrjMainPath)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvUserCodePrjMainPathEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vUserCodePrjMainPath"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "UserCodePrjMainPathId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 26;
public static string[] _AttributeName = new string[] {"ApplicationTypeENName", "UserCodePrjMainPathId", "CMProjectAppRelaId", "PrjId", "PrjName", "ProgLangTypeId", "UserId", "UserName", "DepartmentId", "DepartmentName", "UserStateId", "UserStateName", "IsUsePrjMainPath", "IncludeXmlPath", "IsTemplate", "InUse", "UpdDate", "UpdUserId", "Memo", "ApplicationTypeSimName", "CmPrjName", "ApplicationTypeName", "ApplicationTypeId", "CmPrjId", "AppOrderNum", "AppIsVisible"};

protected string mstrApplicationTypeENName;    //应用类型英文名
protected string mstrUserCodePrjMainPathId;    //生成主目录Id
protected long mlngCMProjectAppRelaId;    //Cm工程应用关系Id
protected string mstrPrjId;    //工程Id
protected string mstrPrjName;    //工程名称
protected string mstrProgLangTypeId;    //编程语言类型Id
protected string mstrUserId;    //用户Id
protected string mstrUserName;    //用户名
protected string mstrDepartmentId;    //部门ID
protected string mstrDepartmentName;    //部门名称
protected string mstrUserStateId;    //用户状态号
protected string mstrUserStateName;    //用户状态名
protected bool mbolIsUsePrjMainPath;    //是否使用主路径
protected string mstrIncludeXmlPath;    //包含表Xml路径
protected bool mbolIsTemplate;    //是否模板
protected bool mbolInUse;    //是否在用
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //说明
protected string mstrApplicationTypeSimName;    //应用程序类型简称
protected string mstrCmPrjName;    //CM工程名
protected string mstrApplicationTypeName;    //应用程序类型名称
protected int mintApplicationTypeId;    //应用程序类型ID
protected string mstrCmPrjId;    //Cm工程Id
protected int? mintAppOrderNum;    //AppOrderNum
protected bool mbolAppIsVisible;    //AppIsVisible

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvUserCodePrjMainPathEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("UserCodePrjMainPathId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strUserCodePrjMainPathId">关键字:生成主目录Id</param>
public clsvUserCodePrjMainPathEN(string strUserCodePrjMainPathId)
 {
strUserCodePrjMainPathId = strUserCodePrjMainPathId.Replace("'", "''");
if (strUserCodePrjMainPathId.Length > 8)
{
throw new Exception("在表:vUserCodePrjMainPath中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strUserCodePrjMainPathId)  ==  true)
{
throw new Exception("在表:vUserCodePrjMainPath中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strUserCodePrjMainPathId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrUserCodePrjMainPathId = strUserCodePrjMainPathId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("UserCodePrjMainPathId");
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
if (strAttributeName  ==  convUserCodePrjMainPath.ApplicationTypeENName)
{
return mstrApplicationTypeENName;
}
else if (strAttributeName  ==  convUserCodePrjMainPath.UserCodePrjMainPathId)
{
return mstrUserCodePrjMainPathId;
}
else if (strAttributeName  ==  convUserCodePrjMainPath.CMProjectAppRelaId)
{
return mlngCMProjectAppRelaId;
}
else if (strAttributeName  ==  convUserCodePrjMainPath.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convUserCodePrjMainPath.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convUserCodePrjMainPath.ProgLangTypeId)
{
return mstrProgLangTypeId;
}
else if (strAttributeName  ==  convUserCodePrjMainPath.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convUserCodePrjMainPath.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convUserCodePrjMainPath.DepartmentId)
{
return mstrDepartmentId;
}
else if (strAttributeName  ==  convUserCodePrjMainPath.DepartmentName)
{
return mstrDepartmentName;
}
else if (strAttributeName  ==  convUserCodePrjMainPath.UserStateId)
{
return mstrUserStateId;
}
else if (strAttributeName  ==  convUserCodePrjMainPath.UserStateName)
{
return mstrUserStateName;
}
else if (strAttributeName  ==  convUserCodePrjMainPath.IsUsePrjMainPath)
{
return mbolIsUsePrjMainPath;
}
else if (strAttributeName  ==  convUserCodePrjMainPath.IncludeXmlPath)
{
return mstrIncludeXmlPath;
}
else if (strAttributeName  ==  convUserCodePrjMainPath.IsTemplate)
{
return mbolIsTemplate;
}
else if (strAttributeName  ==  convUserCodePrjMainPath.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  convUserCodePrjMainPath.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convUserCodePrjMainPath.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convUserCodePrjMainPath.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convUserCodePrjMainPath.ApplicationTypeSimName)
{
return mstrApplicationTypeSimName;
}
else if (strAttributeName  ==  convUserCodePrjMainPath.CmPrjName)
{
return mstrCmPrjName;
}
else if (strAttributeName  ==  convUserCodePrjMainPath.ApplicationTypeName)
{
return mstrApplicationTypeName;
}
else if (strAttributeName  ==  convUserCodePrjMainPath.ApplicationTypeId)
{
return mintApplicationTypeId;
}
else if (strAttributeName  ==  convUserCodePrjMainPath.CmPrjId)
{
return mstrCmPrjId;
}
else if (strAttributeName  ==  convUserCodePrjMainPath.AppOrderNum)
{
return mintAppOrderNum;
}
else if (strAttributeName  ==  convUserCodePrjMainPath.AppIsVisible)
{
return mbolAppIsVisible;
}
return null;
}
set
{
if (strAttributeName  ==  convUserCodePrjMainPath.ApplicationTypeENName)
{
mstrApplicationTypeENName = value.ToString();
 AddUpdatedFld(convUserCodePrjMainPath.ApplicationTypeENName);
}
else if (strAttributeName  ==  convUserCodePrjMainPath.UserCodePrjMainPathId)
{
mstrUserCodePrjMainPathId = value.ToString();
 AddUpdatedFld(convUserCodePrjMainPath.UserCodePrjMainPathId);
}
else if (strAttributeName  ==  convUserCodePrjMainPath.CMProjectAppRelaId)
{
mlngCMProjectAppRelaId = TransNullToInt(value.ToString());
 AddUpdatedFld(convUserCodePrjMainPath.CMProjectAppRelaId);
}
else if (strAttributeName  ==  convUserCodePrjMainPath.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convUserCodePrjMainPath.PrjId);
}
else if (strAttributeName  ==  convUserCodePrjMainPath.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convUserCodePrjMainPath.PrjName);
}
else if (strAttributeName  ==  convUserCodePrjMainPath.ProgLangTypeId)
{
mstrProgLangTypeId = value.ToString();
 AddUpdatedFld(convUserCodePrjMainPath.ProgLangTypeId);
}
else if (strAttributeName  ==  convUserCodePrjMainPath.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convUserCodePrjMainPath.UserId);
}
else if (strAttributeName  ==  convUserCodePrjMainPath.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convUserCodePrjMainPath.UserName);
}
else if (strAttributeName  ==  convUserCodePrjMainPath.DepartmentId)
{
mstrDepartmentId = value.ToString();
 AddUpdatedFld(convUserCodePrjMainPath.DepartmentId);
}
else if (strAttributeName  ==  convUserCodePrjMainPath.DepartmentName)
{
mstrDepartmentName = value.ToString();
 AddUpdatedFld(convUserCodePrjMainPath.DepartmentName);
}
else if (strAttributeName  ==  convUserCodePrjMainPath.UserStateId)
{
mstrUserStateId = value.ToString();
 AddUpdatedFld(convUserCodePrjMainPath.UserStateId);
}
else if (strAttributeName  ==  convUserCodePrjMainPath.UserStateName)
{
mstrUserStateName = value.ToString();
 AddUpdatedFld(convUserCodePrjMainPath.UserStateName);
}
else if (strAttributeName  ==  convUserCodePrjMainPath.IsUsePrjMainPath)
{
mbolIsUsePrjMainPath = TransNullToBool(value.ToString());
 AddUpdatedFld(convUserCodePrjMainPath.IsUsePrjMainPath);
}
else if (strAttributeName  ==  convUserCodePrjMainPath.IncludeXmlPath)
{
mstrIncludeXmlPath = value.ToString();
 AddUpdatedFld(convUserCodePrjMainPath.IncludeXmlPath);
}
else if (strAttributeName  ==  convUserCodePrjMainPath.IsTemplate)
{
mbolIsTemplate = TransNullToBool(value.ToString());
 AddUpdatedFld(convUserCodePrjMainPath.IsTemplate);
}
else if (strAttributeName  ==  convUserCodePrjMainPath.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convUserCodePrjMainPath.InUse);
}
else if (strAttributeName  ==  convUserCodePrjMainPath.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convUserCodePrjMainPath.UpdDate);
}
else if (strAttributeName  ==  convUserCodePrjMainPath.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convUserCodePrjMainPath.UpdUserId);
}
else if (strAttributeName  ==  convUserCodePrjMainPath.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convUserCodePrjMainPath.Memo);
}
else if (strAttributeName  ==  convUserCodePrjMainPath.ApplicationTypeSimName)
{
mstrApplicationTypeSimName = value.ToString();
 AddUpdatedFld(convUserCodePrjMainPath.ApplicationTypeSimName);
}
else if (strAttributeName  ==  convUserCodePrjMainPath.CmPrjName)
{
mstrCmPrjName = value.ToString();
 AddUpdatedFld(convUserCodePrjMainPath.CmPrjName);
}
else if (strAttributeName  ==  convUserCodePrjMainPath.ApplicationTypeName)
{
mstrApplicationTypeName = value.ToString();
 AddUpdatedFld(convUserCodePrjMainPath.ApplicationTypeName);
}
else if (strAttributeName  ==  convUserCodePrjMainPath.ApplicationTypeId)
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convUserCodePrjMainPath.ApplicationTypeId);
}
else if (strAttributeName  ==  convUserCodePrjMainPath.CmPrjId)
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(convUserCodePrjMainPath.CmPrjId);
}
else if (strAttributeName  ==  convUserCodePrjMainPath.AppOrderNum)
{
mintAppOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convUserCodePrjMainPath.AppOrderNum);
}
else if (strAttributeName  ==  convUserCodePrjMainPath.AppIsVisible)
{
mbolAppIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convUserCodePrjMainPath.AppIsVisible);
}
}
}
public object this[int intIndex]
{
get
{
if (convUserCodePrjMainPath.ApplicationTypeENName  ==  _AttributeName[intIndex])
{
return mstrApplicationTypeENName;
}
else if (convUserCodePrjMainPath.UserCodePrjMainPathId  ==  _AttributeName[intIndex])
{
return mstrUserCodePrjMainPathId;
}
else if (convUserCodePrjMainPath.CMProjectAppRelaId  ==  _AttributeName[intIndex])
{
return mlngCMProjectAppRelaId;
}
else if (convUserCodePrjMainPath.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convUserCodePrjMainPath.PrjName  ==  _AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convUserCodePrjMainPath.ProgLangTypeId  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeId;
}
else if (convUserCodePrjMainPath.UserId  ==  _AttributeName[intIndex])
{
return mstrUserId;
}
else if (convUserCodePrjMainPath.UserName  ==  _AttributeName[intIndex])
{
return mstrUserName;
}
else if (convUserCodePrjMainPath.DepartmentId  ==  _AttributeName[intIndex])
{
return mstrDepartmentId;
}
else if (convUserCodePrjMainPath.DepartmentName  ==  _AttributeName[intIndex])
{
return mstrDepartmentName;
}
else if (convUserCodePrjMainPath.UserStateId  ==  _AttributeName[intIndex])
{
return mstrUserStateId;
}
else if (convUserCodePrjMainPath.UserStateName  ==  _AttributeName[intIndex])
{
return mstrUserStateName;
}
else if (convUserCodePrjMainPath.IsUsePrjMainPath  ==  _AttributeName[intIndex])
{
return mbolIsUsePrjMainPath;
}
else if (convUserCodePrjMainPath.IncludeXmlPath  ==  _AttributeName[intIndex])
{
return mstrIncludeXmlPath;
}
else if (convUserCodePrjMainPath.IsTemplate  ==  _AttributeName[intIndex])
{
return mbolIsTemplate;
}
else if (convUserCodePrjMainPath.InUse  ==  _AttributeName[intIndex])
{
return mbolInUse;
}
else if (convUserCodePrjMainPath.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convUserCodePrjMainPath.UpdUserId  ==  _AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convUserCodePrjMainPath.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (convUserCodePrjMainPath.ApplicationTypeSimName  ==  _AttributeName[intIndex])
{
return mstrApplicationTypeSimName;
}
else if (convUserCodePrjMainPath.CmPrjName  ==  _AttributeName[intIndex])
{
return mstrCmPrjName;
}
else if (convUserCodePrjMainPath.ApplicationTypeName  ==  _AttributeName[intIndex])
{
return mstrApplicationTypeName;
}
else if (convUserCodePrjMainPath.ApplicationTypeId  ==  _AttributeName[intIndex])
{
return mintApplicationTypeId;
}
else if (convUserCodePrjMainPath.CmPrjId  ==  _AttributeName[intIndex])
{
return mstrCmPrjId;
}
else if (convUserCodePrjMainPath.AppOrderNum  ==  _AttributeName[intIndex])
{
return mintAppOrderNum;
}
else if (convUserCodePrjMainPath.AppIsVisible  ==  _AttributeName[intIndex])
{
return mbolAppIsVisible;
}
return null;
}
set
{
if (convUserCodePrjMainPath.ApplicationTypeENName  ==  _AttributeName[intIndex])
{
mstrApplicationTypeENName = value.ToString();
 AddUpdatedFld(convUserCodePrjMainPath.ApplicationTypeENName);
}
else if (convUserCodePrjMainPath.UserCodePrjMainPathId  ==  _AttributeName[intIndex])
{
mstrUserCodePrjMainPathId = value.ToString();
 AddUpdatedFld(convUserCodePrjMainPath.UserCodePrjMainPathId);
}
else if (convUserCodePrjMainPath.CMProjectAppRelaId  ==  _AttributeName[intIndex])
{
mlngCMProjectAppRelaId = TransNullToInt(value.ToString());
 AddUpdatedFld(convUserCodePrjMainPath.CMProjectAppRelaId);
}
else if (convUserCodePrjMainPath.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convUserCodePrjMainPath.PrjId);
}
else if (convUserCodePrjMainPath.PrjName  ==  _AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convUserCodePrjMainPath.PrjName);
}
else if (convUserCodePrjMainPath.ProgLangTypeId  ==  _AttributeName[intIndex])
{
mstrProgLangTypeId = value.ToString();
 AddUpdatedFld(convUserCodePrjMainPath.ProgLangTypeId);
}
else if (convUserCodePrjMainPath.UserId  ==  _AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convUserCodePrjMainPath.UserId);
}
else if (convUserCodePrjMainPath.UserName  ==  _AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convUserCodePrjMainPath.UserName);
}
else if (convUserCodePrjMainPath.DepartmentId  ==  _AttributeName[intIndex])
{
mstrDepartmentId = value.ToString();
 AddUpdatedFld(convUserCodePrjMainPath.DepartmentId);
}
else if (convUserCodePrjMainPath.DepartmentName  ==  _AttributeName[intIndex])
{
mstrDepartmentName = value.ToString();
 AddUpdatedFld(convUserCodePrjMainPath.DepartmentName);
}
else if (convUserCodePrjMainPath.UserStateId  ==  _AttributeName[intIndex])
{
mstrUserStateId = value.ToString();
 AddUpdatedFld(convUserCodePrjMainPath.UserStateId);
}
else if (convUserCodePrjMainPath.UserStateName  ==  _AttributeName[intIndex])
{
mstrUserStateName = value.ToString();
 AddUpdatedFld(convUserCodePrjMainPath.UserStateName);
}
else if (convUserCodePrjMainPath.IsUsePrjMainPath  ==  _AttributeName[intIndex])
{
mbolIsUsePrjMainPath = TransNullToBool(value.ToString());
 AddUpdatedFld(convUserCodePrjMainPath.IsUsePrjMainPath);
}
else if (convUserCodePrjMainPath.IncludeXmlPath  ==  _AttributeName[intIndex])
{
mstrIncludeXmlPath = value.ToString();
 AddUpdatedFld(convUserCodePrjMainPath.IncludeXmlPath);
}
else if (convUserCodePrjMainPath.IsTemplate  ==  _AttributeName[intIndex])
{
mbolIsTemplate = TransNullToBool(value.ToString());
 AddUpdatedFld(convUserCodePrjMainPath.IsTemplate);
}
else if (convUserCodePrjMainPath.InUse  ==  _AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convUserCodePrjMainPath.InUse);
}
else if (convUserCodePrjMainPath.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convUserCodePrjMainPath.UpdDate);
}
else if (convUserCodePrjMainPath.UpdUserId  ==  _AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convUserCodePrjMainPath.UpdUserId);
}
else if (convUserCodePrjMainPath.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convUserCodePrjMainPath.Memo);
}
else if (convUserCodePrjMainPath.ApplicationTypeSimName  ==  _AttributeName[intIndex])
{
mstrApplicationTypeSimName = value.ToString();
 AddUpdatedFld(convUserCodePrjMainPath.ApplicationTypeSimName);
}
else if (convUserCodePrjMainPath.CmPrjName  ==  _AttributeName[intIndex])
{
mstrCmPrjName = value.ToString();
 AddUpdatedFld(convUserCodePrjMainPath.CmPrjName);
}
else if (convUserCodePrjMainPath.ApplicationTypeName  ==  _AttributeName[intIndex])
{
mstrApplicationTypeName = value.ToString();
 AddUpdatedFld(convUserCodePrjMainPath.ApplicationTypeName);
}
else if (convUserCodePrjMainPath.ApplicationTypeId  ==  _AttributeName[intIndex])
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convUserCodePrjMainPath.ApplicationTypeId);
}
else if (convUserCodePrjMainPath.CmPrjId  ==  _AttributeName[intIndex])
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(convUserCodePrjMainPath.CmPrjId);
}
else if (convUserCodePrjMainPath.AppOrderNum  ==  _AttributeName[intIndex])
{
mintAppOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convUserCodePrjMainPath.AppOrderNum);
}
else if (convUserCodePrjMainPath.AppIsVisible  ==  _AttributeName[intIndex])
{
mbolAppIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convUserCodePrjMainPath.AppIsVisible);
}
}
}

/// <summary>
/// 应用类型英文名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ApplicationTypeENName
{
get
{
return mstrApplicationTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrApplicationTypeENName = value;
}
else
{
 mstrApplicationTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(convUserCodePrjMainPath.ApplicationTypeENName);
}
}
/// <summary>
/// 生成主目录Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserCodePrjMainPathId
{
get
{
return mstrUserCodePrjMainPathId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserCodePrjMainPathId = value;
}
else
{
 mstrUserCodePrjMainPathId = value;
}
//记录修改过的字段
 AddUpdatedFld(convUserCodePrjMainPath.UserCodePrjMainPathId);
}
}
/// <summary>
/// Cm工程应用关系Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long CMProjectAppRelaId
{
get
{
return mlngCMProjectAppRelaId;
}
set
{
 mlngCMProjectAppRelaId = value;
//记录修改过的字段
 AddUpdatedFld(convUserCodePrjMainPath.CMProjectAppRelaId);
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
 AddUpdatedFld(convUserCodePrjMainPath.PrjId);
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
 AddUpdatedFld(convUserCodePrjMainPath.PrjName);
}
}
/// <summary>
/// 编程语言类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLangTypeId
{
get
{
return mstrProgLangTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLangTypeId = value;
}
else
{
 mstrProgLangTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convUserCodePrjMainPath.ProgLangTypeId);
}
}
/// <summary>
/// 用户Id(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserId
{
get
{
return mstrUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserId = value;
}
else
{
 mstrUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(convUserCodePrjMainPath.UserId);
}
}
/// <summary>
/// 用户名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserName
{
get
{
return mstrUserName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserName = value;
}
else
{
 mstrUserName = value;
}
//记录修改过的字段
 AddUpdatedFld(convUserCodePrjMainPath.UserName);
}
}
/// <summary>
/// 部门ID(说明:;字段类型:varchar;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DepartmentId
{
get
{
return mstrDepartmentId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDepartmentId = value;
}
else
{
 mstrDepartmentId = value;
}
//记录修改过的字段
 AddUpdatedFld(convUserCodePrjMainPath.DepartmentId);
}
}
/// <summary>
/// 部门名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DepartmentName
{
get
{
return mstrDepartmentName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDepartmentName = value;
}
else
{
 mstrDepartmentName = value;
}
//记录修改过的字段
 AddUpdatedFld(convUserCodePrjMainPath.DepartmentName);
}
}
/// <summary>
/// 用户状态号(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserStateId
{
get
{
return mstrUserStateId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserStateId = value;
}
else
{
 mstrUserStateId = value;
}
//记录修改过的字段
 AddUpdatedFld(convUserCodePrjMainPath.UserStateId);
}
}
/// <summary>
/// 用户状态名(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserStateName
{
get
{
return mstrUserStateName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserStateName = value;
}
else
{
 mstrUserStateName = value;
}
//记录修改过的字段
 AddUpdatedFld(convUserCodePrjMainPath.UserStateName);
}
}
/// <summary>
/// 是否使用主路径(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsUsePrjMainPath
{
get
{
return mbolIsUsePrjMainPath;
}
set
{
 mbolIsUsePrjMainPath = value;
//记录修改过的字段
 AddUpdatedFld(convUserCodePrjMainPath.IsUsePrjMainPath);
}
}
/// <summary>
/// 包含表Xml路径(说明:;字段类型:varchar;字段长度:150;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IncludeXmlPath
{
get
{
return mstrIncludeXmlPath;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIncludeXmlPath = value;
}
else
{
 mstrIncludeXmlPath = value;
}
//记录修改过的字段
 AddUpdatedFld(convUserCodePrjMainPath.IncludeXmlPath);
}
}
/// <summary>
/// 是否模板(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsTemplate
{
get
{
return mbolIsTemplate;
}
set
{
 mbolIsTemplate = value;
//记录修改过的字段
 AddUpdatedFld(convUserCodePrjMainPath.IsTemplate);
}
}
/// <summary>
/// 是否在用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool InUse
{
get
{
return mbolInUse;
}
set
{
 mbolInUse = value;
//记录修改过的字段
 AddUpdatedFld(convUserCodePrjMainPath.InUse);
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
 AddUpdatedFld(convUserCodePrjMainPath.UpdDate);
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
 AddUpdatedFld(convUserCodePrjMainPath.UpdUserId);
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
 AddUpdatedFld(convUserCodePrjMainPath.Memo);
}
}
/// <summary>
/// 应用程序类型简称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ApplicationTypeSimName
{
get
{
return mstrApplicationTypeSimName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrApplicationTypeSimName = value;
}
else
{
 mstrApplicationTypeSimName = value;
}
//记录修改过的字段
 AddUpdatedFld(convUserCodePrjMainPath.ApplicationTypeSimName);
}
}
/// <summary>
/// CM工程名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CmPrjName
{
get
{
return mstrCmPrjName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCmPrjName = value;
}
else
{
 mstrCmPrjName = value;
}
//记录修改过的字段
 AddUpdatedFld(convUserCodePrjMainPath.CmPrjName);
}
}
/// <summary>
/// 应用程序类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ApplicationTypeName
{
get
{
return mstrApplicationTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrApplicationTypeName = value;
}
else
{
 mstrApplicationTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convUserCodePrjMainPath.ApplicationTypeName);
}
}
/// <summary>
/// 应用程序类型ID(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int ApplicationTypeId
{
get
{
return mintApplicationTypeId;
}
set
{
 mintApplicationTypeId = value;
//记录修改过的字段
 AddUpdatedFld(convUserCodePrjMainPath.ApplicationTypeId);
}
}
/// <summary>
/// Cm工程Id(说明:;字段类型:char;字段长度:6;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CmPrjId
{
get
{
return mstrCmPrjId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCmPrjId = value;
}
else
{
 mstrCmPrjId = value;
}
//记录修改过的字段
 AddUpdatedFld(convUserCodePrjMainPath.CmPrjId);
}
}
/// <summary>
/// AppOrderNum(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? AppOrderNum
{
get
{
return mintAppOrderNum;
}
set
{
 mintAppOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(convUserCodePrjMainPath.AppOrderNum);
}
}
/// <summary>
/// AppIsVisible(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool AppIsVisible
{
get
{
return mbolAppIsVisible;
}
set
{
 mbolAppIsVisible = value;
//记录修改过的字段
 AddUpdatedFld(convUserCodePrjMainPath.AppIsVisible);
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
  return mstrUserCodePrjMainPathId;
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
  return mstrApplicationTypeName;
 }
 }
}
 /// <summary>
 /// v用户生成项目主路径(vUserCodePrjMainPath)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convUserCodePrjMainPath
{
public const string _CurrTabName = "vUserCodePrjMainPath"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "UserCodePrjMainPathId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"ApplicationTypeENName", "UserCodePrjMainPathId", "CMProjectAppRelaId", "PrjId", "PrjName", "ProgLangTypeId", "UserId", "UserName", "DepartmentId", "DepartmentName", "UserStateId", "UserStateName", "IsUsePrjMainPath", "IncludeXmlPath", "IsTemplate", "InUse", "UpdDate", "UpdUserId", "Memo", "ApplicationTypeSimName", "CmPrjName", "ApplicationTypeName", "ApplicationTypeId", "CmPrjId", "AppOrderNum", "AppIsVisible"};
//以下是属性变量


 /// <summary>
 /// 常量:"ApplicationTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeENName = "ApplicationTypeENName";    //应用类型英文名

 /// <summary>
 /// 常量:"UserCodePrjMainPathId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserCodePrjMainPathId = "UserCodePrjMainPathId";    //生成主目录Id

 /// <summary>
 /// 常量:"CMProjectAppRelaId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CMProjectAppRelaId = "CMProjectAppRelaId";    //Cm工程应用关系Id

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"PrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjName = "PrjName";    //工程名称

 /// <summary>
 /// 常量:"ProgLangTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeId = "ProgLangTypeId";    //编程语言类型Id

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户Id

 /// <summary>
 /// 常量:"UserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserName = "UserName";    //用户名

 /// <summary>
 /// 常量:"DepartmentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DepartmentId = "DepartmentId";    //部门ID

 /// <summary>
 /// 常量:"DepartmentName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DepartmentName = "DepartmentName";    //部门名称

 /// <summary>
 /// 常量:"UserStateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserStateId = "UserStateId";    //用户状态号

 /// <summary>
 /// 常量:"UserStateName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserStateName = "UserStateName";    //用户状态名

 /// <summary>
 /// 常量:"IsUsePrjMainPath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsUsePrjMainPath = "IsUsePrjMainPath";    //是否使用主路径

 /// <summary>
 /// 常量:"IncludeXmlPath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IncludeXmlPath = "IncludeXmlPath";    //包含表Xml路径

 /// <summary>
 /// 常量:"IsTemplate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsTemplate = "IsTemplate";    //是否模板

 /// <summary>
 /// 常量:"InUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InUse = "InUse";    //是否在用

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
 /// 常量:"ApplicationTypeSimName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeSimName = "ApplicationTypeSimName";    //应用程序类型简称

 /// <summary>
 /// 常量:"CmPrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CmPrjName = "CmPrjName";    //CM工程名

 /// <summary>
 /// 常量:"ApplicationTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeName = "ApplicationTypeName";    //应用程序类型名称

 /// <summary>
 /// 常量:"ApplicationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeId = "ApplicationTypeId";    //应用程序类型ID

 /// <summary>
 /// 常量:"CmPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CmPrjId = "CmPrjId";    //Cm工程Id

 /// <summary>
 /// 常量:"AppOrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppOrderNum = "AppOrderNum";    //AppOrderNum

 /// <summary>
 /// 常量:"AppIsVisible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppIsVisible = "AppIsVisible";    //AppIsVisible
}

}