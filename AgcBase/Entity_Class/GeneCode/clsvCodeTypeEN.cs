
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCodeTypeEN
 表名:vCodeType(00050410)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:12:38
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
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
 /// 表vCodeType的关键字(CodeTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CodeTypeId_vCodeType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strCodeTypeId">表关键字</param>
public K_CodeTypeId_vCodeType(string strCodeTypeId)
{
if (IsValid(strCodeTypeId)) Value = strCodeTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strCodeTypeId)
{
if (string.IsNullOrEmpty(strCodeTypeId) == true) return false;
if (strCodeTypeId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_CodeTypeId_vCodeType]类型的对象</returns>
public static implicit operator K_CodeTypeId_vCodeType(string value)
{
return new K_CodeTypeId_vCodeType(value);
}
}
 /// <summary>
 /// v代码类型(vCodeType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvCodeTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vCodeType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "CodeTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 40;
public static string[] _AttributeName = new string[] {"CodeTypeId", "CodeTypeName", "CodeTypeSimName", "CodeTypeENName", "GroupName", "ProgLangTypeId", "ProgLangTypeName", "ProgLangTypeSimName", "RegionTypeId", "RegionTypeName", "Prefix", "DependsOn", "FrontOrBack", "SqlDsTypeId", "SqlDsTypeName", "ClassNameFormat", "IsCSharp", "IsJava", "IsJavaScript", "IsTypeScript", "IsSilverLight", "IsSwift", "IsVB", "IsTableFldConst", "IsPubApp4WinWeb", "IsWeb", "IsAspMvc", "IsWebSrvAccess", "IsWin", "IsMobileApp", "OrderNum", "WinOrWeb", "IsDirByTabName", "InUse", "IsDefaultOverride", "UpdDate", "UpdUser", "Memo", "FuncCount", "AppCount"};

protected string mstrCodeTypeId;    //代码类型Id
protected string mstrCodeTypeName;    //代码类型名
protected string mstrCodeTypeSimName;    //简称
protected string mstrCodeTypeENName;    //代码类型英文名
protected string mstrGroupName;    //组名
protected string mstrProgLangTypeId;    //编程语言类型Id
protected string mstrProgLangTypeName;    //编程语言类型名
protected string mstrProgLangTypeSimName;    //编程语言类型简称
protected string mstrRegionTypeId;    //区域类型Id
protected string mstrRegionTypeName;    //区域类型名称
protected string mstrPrefix;    //前缀
protected string mstrDependsOn;    //依赖于
protected string mstrFrontOrBack;    //前台Or后台
protected string mstrSqlDsTypeId;    //数据源类型Id
protected string mstrSqlDsTypeName;    //Sql数据源名
protected string mstrClassNameFormat;    //类名格式
protected bool mbolIsCSharp;    //是否CSharp语言
protected bool mbolIsJava;    //是否Java语言
protected bool mbolIsJavaScript;    //是否JavaScript语言
protected bool mbolIsTypeScript;    //是否TypeScript语言
protected bool mbolIsSilverLight;    //是否SilverLight语言
protected bool mbolIsSwift;    //是否Swift语言
protected bool mbolIsVB;    //IsVB语言
protected bool mbolIsTableFldConst;    //IsTableFldConst
protected bool mbolIsPubApp4WinWeb;    //IsPubApp4WinWeb
protected bool mbolIsWeb;    //是否Web应用
protected bool mbolIsAspMvc;    //是否AspMvc
protected bool mbolIsWebSrvAccess;    //IsWebSrvAccess
protected bool mbolIsWin;    //是否Win应用
protected bool mbolIsMobileApp;    //是否移动终端应用
protected int mintOrderNum;    //序号
protected string mstrWinOrWeb;    //WinOrWeb
protected bool mbolIsDirByTabName;    //是否用表名作为路径
protected bool mbolInUse;    //是否在用
protected bool mbolIsDefaultOverride;    //是否默认覆盖
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明
protected int? mintFuncCount;    //函数数目
protected int? mintAppCount;    //应用数

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvCodeTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CodeTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strCodeTypeId">关键字:代码类型Id</param>
public clsvCodeTypeEN(string strCodeTypeId)
 {
strCodeTypeId = strCodeTypeId.Replace("'", "''");
if (strCodeTypeId.Length > 4)
{
throw new Exception("在表:vCodeType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strCodeTypeId)  ==  true)
{
throw new Exception("在表:vCodeType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCodeTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrCodeTypeId = strCodeTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CodeTypeId");
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
if (strAttributeName  ==  convCodeType.CodeTypeId)
{
return mstrCodeTypeId;
}
else if (strAttributeName  ==  convCodeType.CodeTypeName)
{
return mstrCodeTypeName;
}
else if (strAttributeName  ==  convCodeType.CodeTypeSimName)
{
return mstrCodeTypeSimName;
}
else if (strAttributeName  ==  convCodeType.CodeTypeENName)
{
return mstrCodeTypeENName;
}
else if (strAttributeName  ==  convCodeType.GroupName)
{
return mstrGroupName;
}
else if (strAttributeName  ==  convCodeType.ProgLangTypeId)
{
return mstrProgLangTypeId;
}
else if (strAttributeName  ==  convCodeType.ProgLangTypeName)
{
return mstrProgLangTypeName;
}
else if (strAttributeName  ==  convCodeType.ProgLangTypeSimName)
{
return mstrProgLangTypeSimName;
}
else if (strAttributeName  ==  convCodeType.RegionTypeId)
{
return mstrRegionTypeId;
}
else if (strAttributeName  ==  convCodeType.RegionTypeName)
{
return mstrRegionTypeName;
}
else if (strAttributeName  ==  convCodeType.Prefix)
{
return mstrPrefix;
}
else if (strAttributeName  ==  convCodeType.DependsOn)
{
return mstrDependsOn;
}
else if (strAttributeName  ==  convCodeType.FrontOrBack)
{
return mstrFrontOrBack;
}
else if (strAttributeName  ==  convCodeType.SqlDsTypeId)
{
return mstrSqlDsTypeId;
}
else if (strAttributeName  ==  convCodeType.SqlDsTypeName)
{
return mstrSqlDsTypeName;
}
else if (strAttributeName  ==  convCodeType.ClassNameFormat)
{
return mstrClassNameFormat;
}
else if (strAttributeName  ==  convCodeType.IsCSharp)
{
return mbolIsCSharp;
}
else if (strAttributeName  ==  convCodeType.IsJava)
{
return mbolIsJava;
}
else if (strAttributeName  ==  convCodeType.IsJavaScript)
{
return mbolIsJavaScript;
}
else if (strAttributeName  ==  convCodeType.IsTypeScript)
{
return mbolIsTypeScript;
}
else if (strAttributeName  ==  convCodeType.IsSilverLight)
{
return mbolIsSilverLight;
}
else if (strAttributeName  ==  convCodeType.IsSwift)
{
return mbolIsSwift;
}
else if (strAttributeName  ==  convCodeType.IsVB)
{
return mbolIsVB;
}
else if (strAttributeName  ==  convCodeType.IsTableFldConst)
{
return mbolIsTableFldConst;
}
else if (strAttributeName  ==  convCodeType.IsPubApp4WinWeb)
{
return mbolIsPubApp4WinWeb;
}
else if (strAttributeName  ==  convCodeType.IsWeb)
{
return mbolIsWeb;
}
else if (strAttributeName  ==  convCodeType.IsAspMvc)
{
return mbolIsAspMvc;
}
else if (strAttributeName  ==  convCodeType.IsWebSrvAccess)
{
return mbolIsWebSrvAccess;
}
else if (strAttributeName  ==  convCodeType.IsWin)
{
return mbolIsWin;
}
else if (strAttributeName  ==  convCodeType.IsMobileApp)
{
return mbolIsMobileApp;
}
else if (strAttributeName  ==  convCodeType.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convCodeType.WinOrWeb)
{
return mstrWinOrWeb;
}
else if (strAttributeName  ==  convCodeType.IsDirByTabName)
{
return mbolIsDirByTabName;
}
else if (strAttributeName  ==  convCodeType.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  convCodeType.IsDefaultOverride)
{
return mbolIsDefaultOverride;
}
else if (strAttributeName  ==  convCodeType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convCodeType.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convCodeType.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convCodeType.FuncCount)
{
return mintFuncCount;
}
else if (strAttributeName  ==  convCodeType.AppCount)
{
return mintAppCount;
}
return null;
}
set
{
if (strAttributeName  ==  convCodeType.CodeTypeId)
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(convCodeType.CodeTypeId);
}
else if (strAttributeName  ==  convCodeType.CodeTypeName)
{
mstrCodeTypeName = value.ToString();
 AddUpdatedFld(convCodeType.CodeTypeName);
}
else if (strAttributeName  ==  convCodeType.CodeTypeSimName)
{
mstrCodeTypeSimName = value.ToString();
 AddUpdatedFld(convCodeType.CodeTypeSimName);
}
else if (strAttributeName  ==  convCodeType.CodeTypeENName)
{
mstrCodeTypeENName = value.ToString();
 AddUpdatedFld(convCodeType.CodeTypeENName);
}
else if (strAttributeName  ==  convCodeType.GroupName)
{
mstrGroupName = value.ToString();
 AddUpdatedFld(convCodeType.GroupName);
}
else if (strAttributeName  ==  convCodeType.ProgLangTypeId)
{
mstrProgLangTypeId = value.ToString();
 AddUpdatedFld(convCodeType.ProgLangTypeId);
}
else if (strAttributeName  ==  convCodeType.ProgLangTypeName)
{
mstrProgLangTypeName = value.ToString();
 AddUpdatedFld(convCodeType.ProgLangTypeName);
}
else if (strAttributeName  ==  convCodeType.ProgLangTypeSimName)
{
mstrProgLangTypeSimName = value.ToString();
 AddUpdatedFld(convCodeType.ProgLangTypeSimName);
}
else if (strAttributeName  ==  convCodeType.RegionTypeId)
{
mstrRegionTypeId = value.ToString();
 AddUpdatedFld(convCodeType.RegionTypeId);
}
else if (strAttributeName  ==  convCodeType.RegionTypeName)
{
mstrRegionTypeName = value.ToString();
 AddUpdatedFld(convCodeType.RegionTypeName);
}
else if (strAttributeName  ==  convCodeType.Prefix)
{
mstrPrefix = value.ToString();
 AddUpdatedFld(convCodeType.Prefix);
}
else if (strAttributeName  ==  convCodeType.DependsOn)
{
mstrDependsOn = value.ToString();
 AddUpdatedFld(convCodeType.DependsOn);
}
else if (strAttributeName  ==  convCodeType.FrontOrBack)
{
mstrFrontOrBack = value.ToString();
 AddUpdatedFld(convCodeType.FrontOrBack);
}
else if (strAttributeName  ==  convCodeType.SqlDsTypeId)
{
mstrSqlDsTypeId = value.ToString();
 AddUpdatedFld(convCodeType.SqlDsTypeId);
}
else if (strAttributeName  ==  convCodeType.SqlDsTypeName)
{
mstrSqlDsTypeName = value.ToString();
 AddUpdatedFld(convCodeType.SqlDsTypeName);
}
else if (strAttributeName  ==  convCodeType.ClassNameFormat)
{
mstrClassNameFormat = value.ToString();
 AddUpdatedFld(convCodeType.ClassNameFormat);
}
else if (strAttributeName  ==  convCodeType.IsCSharp)
{
mbolIsCSharp = TransNullToBool(value.ToString());
 AddUpdatedFld(convCodeType.IsCSharp);
}
else if (strAttributeName  ==  convCodeType.IsJava)
{
mbolIsJava = TransNullToBool(value.ToString());
 AddUpdatedFld(convCodeType.IsJava);
}
else if (strAttributeName  ==  convCodeType.IsJavaScript)
{
mbolIsJavaScript = TransNullToBool(value.ToString());
 AddUpdatedFld(convCodeType.IsJavaScript);
}
else if (strAttributeName  ==  convCodeType.IsTypeScript)
{
mbolIsTypeScript = TransNullToBool(value.ToString());
 AddUpdatedFld(convCodeType.IsTypeScript);
}
else if (strAttributeName  ==  convCodeType.IsSilverLight)
{
mbolIsSilverLight = TransNullToBool(value.ToString());
 AddUpdatedFld(convCodeType.IsSilverLight);
}
else if (strAttributeName  ==  convCodeType.IsSwift)
{
mbolIsSwift = TransNullToBool(value.ToString());
 AddUpdatedFld(convCodeType.IsSwift);
}
else if (strAttributeName  ==  convCodeType.IsVB)
{
mbolIsVB = TransNullToBool(value.ToString());
 AddUpdatedFld(convCodeType.IsVB);
}
else if (strAttributeName  ==  convCodeType.IsTableFldConst)
{
mbolIsTableFldConst = TransNullToBool(value.ToString());
 AddUpdatedFld(convCodeType.IsTableFldConst);
}
else if (strAttributeName  ==  convCodeType.IsPubApp4WinWeb)
{
mbolIsPubApp4WinWeb = TransNullToBool(value.ToString());
 AddUpdatedFld(convCodeType.IsPubApp4WinWeb);
}
else if (strAttributeName  ==  convCodeType.IsWeb)
{
mbolIsWeb = TransNullToBool(value.ToString());
 AddUpdatedFld(convCodeType.IsWeb);
}
else if (strAttributeName  ==  convCodeType.IsAspMvc)
{
mbolIsAspMvc = TransNullToBool(value.ToString());
 AddUpdatedFld(convCodeType.IsAspMvc);
}
else if (strAttributeName  ==  convCodeType.IsWebSrvAccess)
{
mbolIsWebSrvAccess = TransNullToBool(value.ToString());
 AddUpdatedFld(convCodeType.IsWebSrvAccess);
}
else if (strAttributeName  ==  convCodeType.IsWin)
{
mbolIsWin = TransNullToBool(value.ToString());
 AddUpdatedFld(convCodeType.IsWin);
}
else if (strAttributeName  ==  convCodeType.IsMobileApp)
{
mbolIsMobileApp = TransNullToBool(value.ToString());
 AddUpdatedFld(convCodeType.IsMobileApp);
}
else if (strAttributeName  ==  convCodeType.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convCodeType.OrderNum);
}
else if (strAttributeName  ==  convCodeType.WinOrWeb)
{
mstrWinOrWeb = value.ToString();
 AddUpdatedFld(convCodeType.WinOrWeb);
}
else if (strAttributeName  ==  convCodeType.IsDirByTabName)
{
mbolIsDirByTabName = TransNullToBool(value.ToString());
 AddUpdatedFld(convCodeType.IsDirByTabName);
}
else if (strAttributeName  ==  convCodeType.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convCodeType.InUse);
}
else if (strAttributeName  ==  convCodeType.IsDefaultOverride)
{
mbolIsDefaultOverride = TransNullToBool(value.ToString());
 AddUpdatedFld(convCodeType.IsDefaultOverride);
}
else if (strAttributeName  ==  convCodeType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convCodeType.UpdDate);
}
else if (strAttributeName  ==  convCodeType.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convCodeType.UpdUser);
}
else if (strAttributeName  ==  convCodeType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCodeType.Memo);
}
else if (strAttributeName  ==  convCodeType.FuncCount)
{
mintFuncCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCodeType.FuncCount);
}
else if (strAttributeName  ==  convCodeType.AppCount)
{
mintAppCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCodeType.AppCount);
}
}
}
public object this[int intIndex]
{
get
{
if (convCodeType.CodeTypeId  ==  _AttributeName[intIndex])
{
return mstrCodeTypeId;
}
else if (convCodeType.CodeTypeName  ==  _AttributeName[intIndex])
{
return mstrCodeTypeName;
}
else if (convCodeType.CodeTypeSimName  ==  _AttributeName[intIndex])
{
return mstrCodeTypeSimName;
}
else if (convCodeType.CodeTypeENName  ==  _AttributeName[intIndex])
{
return mstrCodeTypeENName;
}
else if (convCodeType.GroupName  ==  _AttributeName[intIndex])
{
return mstrGroupName;
}
else if (convCodeType.ProgLangTypeId  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeId;
}
else if (convCodeType.ProgLangTypeName  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeName;
}
else if (convCodeType.ProgLangTypeSimName  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeSimName;
}
else if (convCodeType.RegionTypeId  ==  _AttributeName[intIndex])
{
return mstrRegionTypeId;
}
else if (convCodeType.RegionTypeName  ==  _AttributeName[intIndex])
{
return mstrRegionTypeName;
}
else if (convCodeType.Prefix  ==  _AttributeName[intIndex])
{
return mstrPrefix;
}
else if (convCodeType.DependsOn  ==  _AttributeName[intIndex])
{
return mstrDependsOn;
}
else if (convCodeType.FrontOrBack  ==  _AttributeName[intIndex])
{
return mstrFrontOrBack;
}
else if (convCodeType.SqlDsTypeId  ==  _AttributeName[intIndex])
{
return mstrSqlDsTypeId;
}
else if (convCodeType.SqlDsTypeName  ==  _AttributeName[intIndex])
{
return mstrSqlDsTypeName;
}
else if (convCodeType.ClassNameFormat  ==  _AttributeName[intIndex])
{
return mstrClassNameFormat;
}
else if (convCodeType.IsCSharp  ==  _AttributeName[intIndex])
{
return mbolIsCSharp;
}
else if (convCodeType.IsJava  ==  _AttributeName[intIndex])
{
return mbolIsJava;
}
else if (convCodeType.IsJavaScript  ==  _AttributeName[intIndex])
{
return mbolIsJavaScript;
}
else if (convCodeType.IsTypeScript  ==  _AttributeName[intIndex])
{
return mbolIsTypeScript;
}
else if (convCodeType.IsSilverLight  ==  _AttributeName[intIndex])
{
return mbolIsSilverLight;
}
else if (convCodeType.IsSwift  ==  _AttributeName[intIndex])
{
return mbolIsSwift;
}
else if (convCodeType.IsVB  ==  _AttributeName[intIndex])
{
return mbolIsVB;
}
else if (convCodeType.IsTableFldConst  ==  _AttributeName[intIndex])
{
return mbolIsTableFldConst;
}
else if (convCodeType.IsPubApp4WinWeb  ==  _AttributeName[intIndex])
{
return mbolIsPubApp4WinWeb;
}
else if (convCodeType.IsWeb  ==  _AttributeName[intIndex])
{
return mbolIsWeb;
}
else if (convCodeType.IsAspMvc  ==  _AttributeName[intIndex])
{
return mbolIsAspMvc;
}
else if (convCodeType.IsWebSrvAccess  ==  _AttributeName[intIndex])
{
return mbolIsWebSrvAccess;
}
else if (convCodeType.IsWin  ==  _AttributeName[intIndex])
{
return mbolIsWin;
}
else if (convCodeType.IsMobileApp  ==  _AttributeName[intIndex])
{
return mbolIsMobileApp;
}
else if (convCodeType.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convCodeType.WinOrWeb  ==  _AttributeName[intIndex])
{
return mstrWinOrWeb;
}
else if (convCodeType.IsDirByTabName  ==  _AttributeName[intIndex])
{
return mbolIsDirByTabName;
}
else if (convCodeType.InUse  ==  _AttributeName[intIndex])
{
return mbolInUse;
}
else if (convCodeType.IsDefaultOverride  ==  _AttributeName[intIndex])
{
return mbolIsDefaultOverride;
}
else if (convCodeType.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convCodeType.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convCodeType.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (convCodeType.FuncCount  ==  _AttributeName[intIndex])
{
return mintFuncCount;
}
else if (convCodeType.AppCount  ==  _AttributeName[intIndex])
{
return mintAppCount;
}
return null;
}
set
{
if (convCodeType.CodeTypeId  ==  _AttributeName[intIndex])
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(convCodeType.CodeTypeId);
}
else if (convCodeType.CodeTypeName  ==  _AttributeName[intIndex])
{
mstrCodeTypeName = value.ToString();
 AddUpdatedFld(convCodeType.CodeTypeName);
}
else if (convCodeType.CodeTypeSimName  ==  _AttributeName[intIndex])
{
mstrCodeTypeSimName = value.ToString();
 AddUpdatedFld(convCodeType.CodeTypeSimName);
}
else if (convCodeType.CodeTypeENName  ==  _AttributeName[intIndex])
{
mstrCodeTypeENName = value.ToString();
 AddUpdatedFld(convCodeType.CodeTypeENName);
}
else if (convCodeType.GroupName  ==  _AttributeName[intIndex])
{
mstrGroupName = value.ToString();
 AddUpdatedFld(convCodeType.GroupName);
}
else if (convCodeType.ProgLangTypeId  ==  _AttributeName[intIndex])
{
mstrProgLangTypeId = value.ToString();
 AddUpdatedFld(convCodeType.ProgLangTypeId);
}
else if (convCodeType.ProgLangTypeName  ==  _AttributeName[intIndex])
{
mstrProgLangTypeName = value.ToString();
 AddUpdatedFld(convCodeType.ProgLangTypeName);
}
else if (convCodeType.ProgLangTypeSimName  ==  _AttributeName[intIndex])
{
mstrProgLangTypeSimName = value.ToString();
 AddUpdatedFld(convCodeType.ProgLangTypeSimName);
}
else if (convCodeType.RegionTypeId  ==  _AttributeName[intIndex])
{
mstrRegionTypeId = value.ToString();
 AddUpdatedFld(convCodeType.RegionTypeId);
}
else if (convCodeType.RegionTypeName  ==  _AttributeName[intIndex])
{
mstrRegionTypeName = value.ToString();
 AddUpdatedFld(convCodeType.RegionTypeName);
}
else if (convCodeType.Prefix  ==  _AttributeName[intIndex])
{
mstrPrefix = value.ToString();
 AddUpdatedFld(convCodeType.Prefix);
}
else if (convCodeType.DependsOn  ==  _AttributeName[intIndex])
{
mstrDependsOn = value.ToString();
 AddUpdatedFld(convCodeType.DependsOn);
}
else if (convCodeType.FrontOrBack  ==  _AttributeName[intIndex])
{
mstrFrontOrBack = value.ToString();
 AddUpdatedFld(convCodeType.FrontOrBack);
}
else if (convCodeType.SqlDsTypeId  ==  _AttributeName[intIndex])
{
mstrSqlDsTypeId = value.ToString();
 AddUpdatedFld(convCodeType.SqlDsTypeId);
}
else if (convCodeType.SqlDsTypeName  ==  _AttributeName[intIndex])
{
mstrSqlDsTypeName = value.ToString();
 AddUpdatedFld(convCodeType.SqlDsTypeName);
}
else if (convCodeType.ClassNameFormat  ==  _AttributeName[intIndex])
{
mstrClassNameFormat = value.ToString();
 AddUpdatedFld(convCodeType.ClassNameFormat);
}
else if (convCodeType.IsCSharp  ==  _AttributeName[intIndex])
{
mbolIsCSharp = TransNullToBool(value.ToString());
 AddUpdatedFld(convCodeType.IsCSharp);
}
else if (convCodeType.IsJava  ==  _AttributeName[intIndex])
{
mbolIsJava = TransNullToBool(value.ToString());
 AddUpdatedFld(convCodeType.IsJava);
}
else if (convCodeType.IsJavaScript  ==  _AttributeName[intIndex])
{
mbolIsJavaScript = TransNullToBool(value.ToString());
 AddUpdatedFld(convCodeType.IsJavaScript);
}
else if (convCodeType.IsTypeScript  ==  _AttributeName[intIndex])
{
mbolIsTypeScript = TransNullToBool(value.ToString());
 AddUpdatedFld(convCodeType.IsTypeScript);
}
else if (convCodeType.IsSilverLight  ==  _AttributeName[intIndex])
{
mbolIsSilverLight = TransNullToBool(value.ToString());
 AddUpdatedFld(convCodeType.IsSilverLight);
}
else if (convCodeType.IsSwift  ==  _AttributeName[intIndex])
{
mbolIsSwift = TransNullToBool(value.ToString());
 AddUpdatedFld(convCodeType.IsSwift);
}
else if (convCodeType.IsVB  ==  _AttributeName[intIndex])
{
mbolIsVB = TransNullToBool(value.ToString());
 AddUpdatedFld(convCodeType.IsVB);
}
else if (convCodeType.IsTableFldConst  ==  _AttributeName[intIndex])
{
mbolIsTableFldConst = TransNullToBool(value.ToString());
 AddUpdatedFld(convCodeType.IsTableFldConst);
}
else if (convCodeType.IsPubApp4WinWeb  ==  _AttributeName[intIndex])
{
mbolIsPubApp4WinWeb = TransNullToBool(value.ToString());
 AddUpdatedFld(convCodeType.IsPubApp4WinWeb);
}
else if (convCodeType.IsWeb  ==  _AttributeName[intIndex])
{
mbolIsWeb = TransNullToBool(value.ToString());
 AddUpdatedFld(convCodeType.IsWeb);
}
else if (convCodeType.IsAspMvc  ==  _AttributeName[intIndex])
{
mbolIsAspMvc = TransNullToBool(value.ToString());
 AddUpdatedFld(convCodeType.IsAspMvc);
}
else if (convCodeType.IsWebSrvAccess  ==  _AttributeName[intIndex])
{
mbolIsWebSrvAccess = TransNullToBool(value.ToString());
 AddUpdatedFld(convCodeType.IsWebSrvAccess);
}
else if (convCodeType.IsWin  ==  _AttributeName[intIndex])
{
mbolIsWin = TransNullToBool(value.ToString());
 AddUpdatedFld(convCodeType.IsWin);
}
else if (convCodeType.IsMobileApp  ==  _AttributeName[intIndex])
{
mbolIsMobileApp = TransNullToBool(value.ToString());
 AddUpdatedFld(convCodeType.IsMobileApp);
}
else if (convCodeType.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convCodeType.OrderNum);
}
else if (convCodeType.WinOrWeb  ==  _AttributeName[intIndex])
{
mstrWinOrWeb = value.ToString();
 AddUpdatedFld(convCodeType.WinOrWeb);
}
else if (convCodeType.IsDirByTabName  ==  _AttributeName[intIndex])
{
mbolIsDirByTabName = TransNullToBool(value.ToString());
 AddUpdatedFld(convCodeType.IsDirByTabName);
}
else if (convCodeType.InUse  ==  _AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convCodeType.InUse);
}
else if (convCodeType.IsDefaultOverride  ==  _AttributeName[intIndex])
{
mbolIsDefaultOverride = TransNullToBool(value.ToString());
 AddUpdatedFld(convCodeType.IsDefaultOverride);
}
else if (convCodeType.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convCodeType.UpdDate);
}
else if (convCodeType.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convCodeType.UpdUser);
}
else if (convCodeType.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCodeType.Memo);
}
else if (convCodeType.FuncCount  ==  _AttributeName[intIndex])
{
mintFuncCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCodeType.FuncCount);
}
else if (convCodeType.AppCount  ==  _AttributeName[intIndex])
{
mintAppCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCodeType.AppCount);
}
}
}

/// <summary>
/// 代码类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTypeId
{
get
{
return mstrCodeTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTypeId = value;
}
else
{
 mstrCodeTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCodeType.CodeTypeId);
}
}
/// <summary>
/// 代码类型名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTypeName
{
get
{
return mstrCodeTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTypeName = value;
}
else
{
 mstrCodeTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCodeType.CodeTypeName);
}
}
/// <summary>
/// 简称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTypeSimName
{
get
{
return mstrCodeTypeSimName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTypeSimName = value;
}
else
{
 mstrCodeTypeSimName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCodeType.CodeTypeSimName);
}
}
/// <summary>
/// 代码类型英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTypeENName
{
get
{
return mstrCodeTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTypeENName = value;
}
else
{
 mstrCodeTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCodeType.CodeTypeENName);
}
}
/// <summary>
/// 组名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GroupName
{
get
{
return mstrGroupName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGroupName = value;
}
else
{
 mstrGroupName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCodeType.GroupName);
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
 AddUpdatedFld(convCodeType.ProgLangTypeId);
}
}
/// <summary>
/// 编程语言类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLangTypeName
{
get
{
return mstrProgLangTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLangTypeName = value;
}
else
{
 mstrProgLangTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCodeType.ProgLangTypeName);
}
}
/// <summary>
/// 编程语言类型简称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLangTypeSimName
{
get
{
return mstrProgLangTypeSimName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLangTypeSimName = value;
}
else
{
 mstrProgLangTypeSimName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCodeType.ProgLangTypeSimName);
}
}
/// <summary>
/// 区域类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RegionTypeId
{
get
{
return mstrRegionTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRegionTypeId = value;
}
else
{
 mstrRegionTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCodeType.RegionTypeId);
}
}
/// <summary>
/// 区域类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RegionTypeName
{
get
{
return mstrRegionTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRegionTypeName = value;
}
else
{
 mstrRegionTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCodeType.RegionTypeName);
}
}
/// <summary>
/// 前缀(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Prefix
{
get
{
return mstrPrefix;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrefix = value;
}
else
{
 mstrPrefix = value;
}
//记录修改过的字段
 AddUpdatedFld(convCodeType.Prefix);
}
}
/// <summary>
/// 依赖于(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DependsOn
{
get
{
return mstrDependsOn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDependsOn = value;
}
else
{
 mstrDependsOn = value;
}
//记录修改过的字段
 AddUpdatedFld(convCodeType.DependsOn);
}
}
/// <summary>
/// 前台Or后台(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FrontOrBack
{
get
{
return mstrFrontOrBack;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFrontOrBack = value;
}
else
{
 mstrFrontOrBack = value;
}
//记录修改过的字段
 AddUpdatedFld(convCodeType.FrontOrBack);
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
 AddUpdatedFld(convCodeType.SqlDsTypeId);
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
 AddUpdatedFld(convCodeType.SqlDsTypeName);
}
}
/// <summary>
/// 类名格式(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClassNameFormat
{
get
{
return mstrClassNameFormat;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClassNameFormat = value;
}
else
{
 mstrClassNameFormat = value;
}
//记录修改过的字段
 AddUpdatedFld(convCodeType.ClassNameFormat);
}
}
/// <summary>
/// 是否CSharp语言(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsCSharp
{
get
{
return mbolIsCSharp;
}
set
{
 mbolIsCSharp = value;
//记录修改过的字段
 AddUpdatedFld(convCodeType.IsCSharp);
}
}
/// <summary>
/// 是否Java语言(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsJava
{
get
{
return mbolIsJava;
}
set
{
 mbolIsJava = value;
//记录修改过的字段
 AddUpdatedFld(convCodeType.IsJava);
}
}
/// <summary>
/// 是否JavaScript语言(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsJavaScript
{
get
{
return mbolIsJavaScript;
}
set
{
 mbolIsJavaScript = value;
//记录修改过的字段
 AddUpdatedFld(convCodeType.IsJavaScript);
}
}
/// <summary>
/// 是否TypeScript语言(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsTypeScript
{
get
{
return mbolIsTypeScript;
}
set
{
 mbolIsTypeScript = value;
//记录修改过的字段
 AddUpdatedFld(convCodeType.IsTypeScript);
}
}
/// <summary>
/// 是否SilverLight语言(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsSilverLight
{
get
{
return mbolIsSilverLight;
}
set
{
 mbolIsSilverLight = value;
//记录修改过的字段
 AddUpdatedFld(convCodeType.IsSilverLight);
}
}
/// <summary>
/// 是否Swift语言(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsSwift
{
get
{
return mbolIsSwift;
}
set
{
 mbolIsSwift = value;
//记录修改过的字段
 AddUpdatedFld(convCodeType.IsSwift);
}
}
/// <summary>
/// IsVB语言(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsVB
{
get
{
return mbolIsVB;
}
set
{
 mbolIsVB = value;
//记录修改过的字段
 AddUpdatedFld(convCodeType.IsVB);
}
}
/// <summary>
/// IsTableFldConst(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsTableFldConst
{
get
{
return mbolIsTableFldConst;
}
set
{
 mbolIsTableFldConst = value;
//记录修改过的字段
 AddUpdatedFld(convCodeType.IsTableFldConst);
}
}
/// <summary>
/// IsPubApp4WinWeb(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsPubApp4WinWeb
{
get
{
return mbolIsPubApp4WinWeb;
}
set
{
 mbolIsPubApp4WinWeb = value;
//记录修改过的字段
 AddUpdatedFld(convCodeType.IsPubApp4WinWeb);
}
}
/// <summary>
/// 是否Web应用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsWeb
{
get
{
return mbolIsWeb;
}
set
{
 mbolIsWeb = value;
//记录修改过的字段
 AddUpdatedFld(convCodeType.IsWeb);
}
}
/// <summary>
/// 是否AspMvc(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsAspMvc
{
get
{
return mbolIsAspMvc;
}
set
{
 mbolIsAspMvc = value;
//记录修改过的字段
 AddUpdatedFld(convCodeType.IsAspMvc);
}
}
/// <summary>
/// IsWebSrvAccess(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsWebSrvAccess
{
get
{
return mbolIsWebSrvAccess;
}
set
{
 mbolIsWebSrvAccess = value;
//记录修改过的字段
 AddUpdatedFld(convCodeType.IsWebSrvAccess);
}
}
/// <summary>
/// 是否Win应用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsWin
{
get
{
return mbolIsWin;
}
set
{
 mbolIsWin = value;
//记录修改过的字段
 AddUpdatedFld(convCodeType.IsWin);
}
}
/// <summary>
/// 是否移动终端应用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsMobileApp
{
get
{
return mbolIsMobileApp;
}
set
{
 mbolIsMobileApp = value;
//记录修改过的字段
 AddUpdatedFld(convCodeType.IsMobileApp);
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
 AddUpdatedFld(convCodeType.OrderNum);
}
}
/// <summary>
/// WinOrWeb(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WinOrWeb
{
get
{
return mstrWinOrWeb;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWinOrWeb = value;
}
else
{
 mstrWinOrWeb = value;
}
//记录修改过的字段
 AddUpdatedFld(convCodeType.WinOrWeb);
}
}
/// <summary>
/// 是否用表名作为路径(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsDirByTabName
{
get
{
return mbolIsDirByTabName;
}
set
{
 mbolIsDirByTabName = value;
//记录修改过的字段
 AddUpdatedFld(convCodeType.IsDirByTabName);
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
 AddUpdatedFld(convCodeType.InUse);
}
}
/// <summary>
/// 是否默认覆盖(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsDefaultOverride
{
get
{
return mbolIsDefaultOverride;
}
set
{
 mbolIsDefaultOverride = value;
//记录修改过的字段
 AddUpdatedFld(convCodeType.IsDefaultOverride);
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
 AddUpdatedFld(convCodeType.UpdDate);
}
}
/// <summary>
/// 修改者(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUser
{
get
{
return mstrUpdUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUser = value;
}
else
{
 mstrUpdUser = value;
}
//记录修改过的字段
 AddUpdatedFld(convCodeType.UpdUser);
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
 AddUpdatedFld(convCodeType.Memo);
}
}
/// <summary>
/// 函数数目(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? FuncCount
{
get
{
return mintFuncCount;
}
set
{
 mintFuncCount = value;
//记录修改过的字段
 AddUpdatedFld(convCodeType.FuncCount);
}
}
/// <summary>
/// 应用数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? AppCount
{
get
{
return mintAppCount;
}
set
{
 mintAppCount = value;
//记录修改过的字段
 AddUpdatedFld(convCodeType.AppCount);
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
  return mstrCodeTypeId;
 }
 }
}
 /// <summary>
 /// v代码类型(vCodeType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convCodeType
{
public const string _CurrTabName = "vCodeType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CodeTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"CodeTypeId", "CodeTypeName", "CodeTypeSimName", "CodeTypeENName", "GroupName", "ProgLangTypeId", "ProgLangTypeName", "ProgLangTypeSimName", "RegionTypeId", "RegionTypeName", "Prefix", "DependsOn", "FrontOrBack", "SqlDsTypeId", "SqlDsTypeName", "ClassNameFormat", "IsCSharp", "IsJava", "IsJavaScript", "IsTypeScript", "IsSilverLight", "IsSwift", "IsVB", "IsTableFldConst", "IsPubApp4WinWeb", "IsWeb", "IsAspMvc", "IsWebSrvAccess", "IsWin", "IsMobileApp", "OrderNum", "WinOrWeb", "IsDirByTabName", "InUse", "IsDefaultOverride", "UpdDate", "UpdUser", "Memo", "FuncCount", "AppCount"};
//以下是属性变量


 /// <summary>
 /// 常量:"CodeTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTypeId = "CodeTypeId";    //代码类型Id

 /// <summary>
 /// 常量:"CodeTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTypeName = "CodeTypeName";    //代码类型名

 /// <summary>
 /// 常量:"CodeTypeSimName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTypeSimName = "CodeTypeSimName";    //简称

 /// <summary>
 /// 常量:"CodeTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTypeENName = "CodeTypeENName";    //代码类型英文名

 /// <summary>
 /// 常量:"GroupName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GroupName = "GroupName";    //组名

 /// <summary>
 /// 常量:"ProgLangTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeId = "ProgLangTypeId";    //编程语言类型Id

 /// <summary>
 /// 常量:"ProgLangTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeName = "ProgLangTypeName";    //编程语言类型名

 /// <summary>
 /// 常量:"ProgLangTypeSimName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeSimName = "ProgLangTypeSimName";    //编程语言类型简称

 /// <summary>
 /// 常量:"RegionTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RegionTypeId = "RegionTypeId";    //区域类型Id

 /// <summary>
 /// 常量:"RegionTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RegionTypeName = "RegionTypeName";    //区域类型名称

 /// <summary>
 /// 常量:"Prefix"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Prefix = "Prefix";    //前缀

 /// <summary>
 /// 常量:"DependsOn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DependsOn = "DependsOn";    //依赖于

 /// <summary>
 /// 常量:"FrontOrBack"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FrontOrBack = "FrontOrBack";    //前台Or后台

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
 /// 常量:"ClassNameFormat"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClassNameFormat = "ClassNameFormat";    //类名格式

 /// <summary>
 /// 常量:"IsCSharp"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsCSharp = "IsCSharp";    //是否CSharp语言

 /// <summary>
 /// 常量:"IsJava"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsJava = "IsJava";    //是否Java语言

 /// <summary>
 /// 常量:"IsJavaScript"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsJavaScript = "IsJavaScript";    //是否JavaScript语言

 /// <summary>
 /// 常量:"IsTypeScript"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsTypeScript = "IsTypeScript";    //是否TypeScript语言

 /// <summary>
 /// 常量:"IsSilverLight"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSilverLight = "IsSilverLight";    //是否SilverLight语言

 /// <summary>
 /// 常量:"IsSwift"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSwift = "IsSwift";    //是否Swift语言

 /// <summary>
 /// 常量:"IsVB"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVB = "IsVB";    //IsVB语言

 /// <summary>
 /// 常量:"IsTableFldConst"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsTableFldConst = "IsTableFldConst";    //IsTableFldConst

 /// <summary>
 /// 常量:"IsPubApp4WinWeb"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsPubApp4WinWeb = "IsPubApp4WinWeb";    //IsPubApp4WinWeb

 /// <summary>
 /// 常量:"IsWeb"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsWeb = "IsWeb";    //是否Web应用

 /// <summary>
 /// 常量:"IsAspMvc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsAspMvc = "IsAspMvc";    //是否AspMvc

 /// <summary>
 /// 常量:"IsWebSrvAccess"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsWebSrvAccess = "IsWebSrvAccess";    //IsWebSrvAccess

 /// <summary>
 /// 常量:"IsWin"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsWin = "IsWin";    //是否Win应用

 /// <summary>
 /// 常量:"IsMobileApp"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsMobileApp = "IsMobileApp";    //是否移动终端应用

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"WinOrWeb"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WinOrWeb = "WinOrWeb";    //WinOrWeb

 /// <summary>
 /// 常量:"IsDirByTabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDirByTabName = "IsDirByTabName";    //是否用表名作为路径

 /// <summary>
 /// 常量:"InUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InUse = "InUse";    //是否在用

 /// <summary>
 /// 常量:"IsDefaultOverride"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDefaultOverride = "IsDefaultOverride";    //是否默认覆盖

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改者

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明

 /// <summary>
 /// 常量:"FuncCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncCount = "FuncCount";    //函数数目

 /// <summary>
 /// 常量:"AppCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppCount = "AppCount";    //应用数
}

}