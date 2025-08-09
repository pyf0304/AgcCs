
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCodeTypeEN
 表名:CodeType(00050203)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:02:06
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
 /// 表CodeType的关键字(CodeTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CodeTypeId_CodeType
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
public K_CodeTypeId_CodeType(string strCodeTypeId)
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
 /// <returns>返回:[K_CodeTypeId_CodeType]类型的对象</returns>
public static implicit operator K_CodeTypeId_CodeType(string value)
{
return new K_CodeTypeId_CodeType(value);
}
}
 /// <summary>
 /// 代码类型(CodeType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCodeTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CodeType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "CodeTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 38;
public static string[] _AttributeName = new string[] {"CodeTypeId", "CodeTypeName", "CodeTypeSimName", "CodeTypeENName", "GroupName", "ProgLangTypeId", "RegionTypeId", "Prefix", "DependsOn", "FrontOrBack", "SqlDsTypeId", "ClassNameFormat", "FileNameFormat", "ClassNamePattern", "IsCSharp", "IsJava", "IsJavaScript", "IsTypeScript", "IsSilverLight", "IsSwift", "IsVB", "IsTableFldConst", "IsPubApp4WinWeb", "IsWeb", "IsAspMvc", "IsWebSrvAccess", "IsWin", "IsMobileApp", "IsExtend", "OrderNum", "WinOrWeb", "IsDirByTabName", "IsDefaultOverride", "InUse", "IsAutoParseFile", "UpdDate", "UpdUser", "Memo"};

protected string mstrCodeTypeId;    //代码类型Id
protected string mstrCodeTypeName;    //代码类型名
protected string mstrCodeTypeSimName;    //简称
protected string mstrCodeTypeENName;    //代码类型英文名
protected string mstrGroupName;    //组名
protected string mstrProgLangTypeId;    //编程语言类型Id
protected string mstrRegionTypeId;    //区域类型Id
protected string mstrPrefix;    //前缀
protected string mstrDependsOn;    //依赖于
protected string mstrFrontOrBack;    //前台Or后台
protected string mstrSqlDsTypeId;    //数据源类型Id
protected string mstrClassNameFormat;    //类名格式
protected string mstrFileNameFormat;    //文件名格式
protected string mstrClassNamePattern;    //类名模式
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
protected bool mbolIsExtend;    //是否扩展类
protected int? mintOrderNum;    //序号
protected string mstrWinOrWeb;    //WinOrWeb
protected bool mbolIsDirByTabName;    //是否用表名作为路径
protected bool mbolIsDefaultOverride;    //是否默认覆盖
protected bool mbolInUse;    //是否在用
protected bool mbolIsAutoParseFile;    //是否自动分析文件
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsCodeTypeEN()
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
public clsCodeTypeEN(string strCodeTypeId)
 {
strCodeTypeId = strCodeTypeId.Replace("'", "''");
if (strCodeTypeId.Length > 4)
{
throw new Exception("在表:CodeType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strCodeTypeId)  ==  true)
{
throw new Exception("在表:CodeType中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  conCodeType.CodeTypeId)
{
return mstrCodeTypeId;
}
else if (strAttributeName  ==  conCodeType.CodeTypeName)
{
return mstrCodeTypeName;
}
else if (strAttributeName  ==  conCodeType.CodeTypeSimName)
{
return mstrCodeTypeSimName;
}
else if (strAttributeName  ==  conCodeType.CodeTypeENName)
{
return mstrCodeTypeENName;
}
else if (strAttributeName  ==  conCodeType.GroupName)
{
return mstrGroupName;
}
else if (strAttributeName  ==  conCodeType.ProgLangTypeId)
{
return mstrProgLangTypeId;
}
else if (strAttributeName  ==  conCodeType.RegionTypeId)
{
return mstrRegionTypeId;
}
else if (strAttributeName  ==  conCodeType.Prefix)
{
return mstrPrefix;
}
else if (strAttributeName  ==  conCodeType.DependsOn)
{
return mstrDependsOn;
}
else if (strAttributeName  ==  conCodeType.FrontOrBack)
{
return mstrFrontOrBack;
}
else if (strAttributeName  ==  conCodeType.SqlDsTypeId)
{
return mstrSqlDsTypeId;
}
else if (strAttributeName  ==  conCodeType.ClassNameFormat)
{
return mstrClassNameFormat;
}
else if (strAttributeName  ==  conCodeType.FileNameFormat)
{
return mstrFileNameFormat;
}
else if (strAttributeName  ==  conCodeType.ClassNamePattern)
{
return mstrClassNamePattern;
}
else if (strAttributeName  ==  conCodeType.IsCSharp)
{
return mbolIsCSharp;
}
else if (strAttributeName  ==  conCodeType.IsJava)
{
return mbolIsJava;
}
else if (strAttributeName  ==  conCodeType.IsJavaScript)
{
return mbolIsJavaScript;
}
else if (strAttributeName  ==  conCodeType.IsTypeScript)
{
return mbolIsTypeScript;
}
else if (strAttributeName  ==  conCodeType.IsSilverLight)
{
return mbolIsSilverLight;
}
else if (strAttributeName  ==  conCodeType.IsSwift)
{
return mbolIsSwift;
}
else if (strAttributeName  ==  conCodeType.IsVB)
{
return mbolIsVB;
}
else if (strAttributeName  ==  conCodeType.IsTableFldConst)
{
return mbolIsTableFldConst;
}
else if (strAttributeName  ==  conCodeType.IsPubApp4WinWeb)
{
return mbolIsPubApp4WinWeb;
}
else if (strAttributeName  ==  conCodeType.IsWeb)
{
return mbolIsWeb;
}
else if (strAttributeName  ==  conCodeType.IsAspMvc)
{
return mbolIsAspMvc;
}
else if (strAttributeName  ==  conCodeType.IsWebSrvAccess)
{
return mbolIsWebSrvAccess;
}
else if (strAttributeName  ==  conCodeType.IsWin)
{
return mbolIsWin;
}
else if (strAttributeName  ==  conCodeType.IsMobileApp)
{
return mbolIsMobileApp;
}
else if (strAttributeName  ==  conCodeType.IsExtend)
{
return mbolIsExtend;
}
else if (strAttributeName  ==  conCodeType.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conCodeType.WinOrWeb)
{
return mstrWinOrWeb;
}
else if (strAttributeName  ==  conCodeType.IsDirByTabName)
{
return mbolIsDirByTabName;
}
else if (strAttributeName  ==  conCodeType.IsDefaultOverride)
{
return mbolIsDefaultOverride;
}
else if (strAttributeName  ==  conCodeType.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  conCodeType.IsAutoParseFile)
{
return mbolIsAutoParseFile;
}
else if (strAttributeName  ==  conCodeType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conCodeType.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conCodeType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conCodeType.CodeTypeId)
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(conCodeType.CodeTypeId);
}
else if (strAttributeName  ==  conCodeType.CodeTypeName)
{
mstrCodeTypeName = value.ToString();
 AddUpdatedFld(conCodeType.CodeTypeName);
}
else if (strAttributeName  ==  conCodeType.CodeTypeSimName)
{
mstrCodeTypeSimName = value.ToString();
 AddUpdatedFld(conCodeType.CodeTypeSimName);
}
else if (strAttributeName  ==  conCodeType.CodeTypeENName)
{
mstrCodeTypeENName = value.ToString();
 AddUpdatedFld(conCodeType.CodeTypeENName);
}
else if (strAttributeName  ==  conCodeType.GroupName)
{
mstrGroupName = value.ToString();
 AddUpdatedFld(conCodeType.GroupName);
}
else if (strAttributeName  ==  conCodeType.ProgLangTypeId)
{
mstrProgLangTypeId = value.ToString();
 AddUpdatedFld(conCodeType.ProgLangTypeId);
}
else if (strAttributeName  ==  conCodeType.RegionTypeId)
{
mstrRegionTypeId = value.ToString();
 AddUpdatedFld(conCodeType.RegionTypeId);
}
else if (strAttributeName  ==  conCodeType.Prefix)
{
mstrPrefix = value.ToString();
 AddUpdatedFld(conCodeType.Prefix);
}
else if (strAttributeName  ==  conCodeType.DependsOn)
{
mstrDependsOn = value.ToString();
 AddUpdatedFld(conCodeType.DependsOn);
}
else if (strAttributeName  ==  conCodeType.FrontOrBack)
{
mstrFrontOrBack = value.ToString();
 AddUpdatedFld(conCodeType.FrontOrBack);
}
else if (strAttributeName  ==  conCodeType.SqlDsTypeId)
{
mstrSqlDsTypeId = value.ToString();
 AddUpdatedFld(conCodeType.SqlDsTypeId);
}
else if (strAttributeName  ==  conCodeType.ClassNameFormat)
{
mstrClassNameFormat = value.ToString();
 AddUpdatedFld(conCodeType.ClassNameFormat);
}
else if (strAttributeName  ==  conCodeType.FileNameFormat)
{
mstrFileNameFormat = value.ToString();
 AddUpdatedFld(conCodeType.FileNameFormat);
}
else if (strAttributeName  ==  conCodeType.ClassNamePattern)
{
mstrClassNamePattern = value.ToString();
 AddUpdatedFld(conCodeType.ClassNamePattern);
}
else if (strAttributeName  ==  conCodeType.IsCSharp)
{
mbolIsCSharp = TransNullToBool(value.ToString());
 AddUpdatedFld(conCodeType.IsCSharp);
}
else if (strAttributeName  ==  conCodeType.IsJava)
{
mbolIsJava = TransNullToBool(value.ToString());
 AddUpdatedFld(conCodeType.IsJava);
}
else if (strAttributeName  ==  conCodeType.IsJavaScript)
{
mbolIsJavaScript = TransNullToBool(value.ToString());
 AddUpdatedFld(conCodeType.IsJavaScript);
}
else if (strAttributeName  ==  conCodeType.IsTypeScript)
{
mbolIsTypeScript = TransNullToBool(value.ToString());
 AddUpdatedFld(conCodeType.IsTypeScript);
}
else if (strAttributeName  ==  conCodeType.IsSilverLight)
{
mbolIsSilverLight = TransNullToBool(value.ToString());
 AddUpdatedFld(conCodeType.IsSilverLight);
}
else if (strAttributeName  ==  conCodeType.IsSwift)
{
mbolIsSwift = TransNullToBool(value.ToString());
 AddUpdatedFld(conCodeType.IsSwift);
}
else if (strAttributeName  ==  conCodeType.IsVB)
{
mbolIsVB = TransNullToBool(value.ToString());
 AddUpdatedFld(conCodeType.IsVB);
}
else if (strAttributeName  ==  conCodeType.IsTableFldConst)
{
mbolIsTableFldConst = TransNullToBool(value.ToString());
 AddUpdatedFld(conCodeType.IsTableFldConst);
}
else if (strAttributeName  ==  conCodeType.IsPubApp4WinWeb)
{
mbolIsPubApp4WinWeb = TransNullToBool(value.ToString());
 AddUpdatedFld(conCodeType.IsPubApp4WinWeb);
}
else if (strAttributeName  ==  conCodeType.IsWeb)
{
mbolIsWeb = TransNullToBool(value.ToString());
 AddUpdatedFld(conCodeType.IsWeb);
}
else if (strAttributeName  ==  conCodeType.IsAspMvc)
{
mbolIsAspMvc = TransNullToBool(value.ToString());
 AddUpdatedFld(conCodeType.IsAspMvc);
}
else if (strAttributeName  ==  conCodeType.IsWebSrvAccess)
{
mbolIsWebSrvAccess = TransNullToBool(value.ToString());
 AddUpdatedFld(conCodeType.IsWebSrvAccess);
}
else if (strAttributeName  ==  conCodeType.IsWin)
{
mbolIsWin = TransNullToBool(value.ToString());
 AddUpdatedFld(conCodeType.IsWin);
}
else if (strAttributeName  ==  conCodeType.IsMobileApp)
{
mbolIsMobileApp = TransNullToBool(value.ToString());
 AddUpdatedFld(conCodeType.IsMobileApp);
}
else if (strAttributeName  ==  conCodeType.IsExtend)
{
mbolIsExtend = TransNullToBool(value.ToString());
 AddUpdatedFld(conCodeType.IsExtend);
}
else if (strAttributeName  ==  conCodeType.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conCodeType.OrderNum);
}
else if (strAttributeName  ==  conCodeType.WinOrWeb)
{
mstrWinOrWeb = value.ToString();
 AddUpdatedFld(conCodeType.WinOrWeb);
}
else if (strAttributeName  ==  conCodeType.IsDirByTabName)
{
mbolIsDirByTabName = TransNullToBool(value.ToString());
 AddUpdatedFld(conCodeType.IsDirByTabName);
}
else if (strAttributeName  ==  conCodeType.IsDefaultOverride)
{
mbolIsDefaultOverride = TransNullToBool(value.ToString());
 AddUpdatedFld(conCodeType.IsDefaultOverride);
}
else if (strAttributeName  ==  conCodeType.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conCodeType.InUse);
}
else if (strAttributeName  ==  conCodeType.IsAutoParseFile)
{
mbolIsAutoParseFile = TransNullToBool(value.ToString());
 AddUpdatedFld(conCodeType.IsAutoParseFile);
}
else if (strAttributeName  ==  conCodeType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCodeType.UpdDate);
}
else if (strAttributeName  ==  conCodeType.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conCodeType.UpdUser);
}
else if (strAttributeName  ==  conCodeType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCodeType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conCodeType.CodeTypeId  ==  _AttributeName[intIndex])
{
return mstrCodeTypeId;
}
else if (conCodeType.CodeTypeName  ==  _AttributeName[intIndex])
{
return mstrCodeTypeName;
}
else if (conCodeType.CodeTypeSimName  ==  _AttributeName[intIndex])
{
return mstrCodeTypeSimName;
}
else if (conCodeType.CodeTypeENName  ==  _AttributeName[intIndex])
{
return mstrCodeTypeENName;
}
else if (conCodeType.GroupName  ==  _AttributeName[intIndex])
{
return mstrGroupName;
}
else if (conCodeType.ProgLangTypeId  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeId;
}
else if (conCodeType.RegionTypeId  ==  _AttributeName[intIndex])
{
return mstrRegionTypeId;
}
else if (conCodeType.Prefix  ==  _AttributeName[intIndex])
{
return mstrPrefix;
}
else if (conCodeType.DependsOn  ==  _AttributeName[intIndex])
{
return mstrDependsOn;
}
else if (conCodeType.FrontOrBack  ==  _AttributeName[intIndex])
{
return mstrFrontOrBack;
}
else if (conCodeType.SqlDsTypeId  ==  _AttributeName[intIndex])
{
return mstrSqlDsTypeId;
}
else if (conCodeType.ClassNameFormat  ==  _AttributeName[intIndex])
{
return mstrClassNameFormat;
}
else if (conCodeType.FileNameFormat  ==  _AttributeName[intIndex])
{
return mstrFileNameFormat;
}
else if (conCodeType.ClassNamePattern  ==  _AttributeName[intIndex])
{
return mstrClassNamePattern;
}
else if (conCodeType.IsCSharp  ==  _AttributeName[intIndex])
{
return mbolIsCSharp;
}
else if (conCodeType.IsJava  ==  _AttributeName[intIndex])
{
return mbolIsJava;
}
else if (conCodeType.IsJavaScript  ==  _AttributeName[intIndex])
{
return mbolIsJavaScript;
}
else if (conCodeType.IsTypeScript  ==  _AttributeName[intIndex])
{
return mbolIsTypeScript;
}
else if (conCodeType.IsSilverLight  ==  _AttributeName[intIndex])
{
return mbolIsSilverLight;
}
else if (conCodeType.IsSwift  ==  _AttributeName[intIndex])
{
return mbolIsSwift;
}
else if (conCodeType.IsVB  ==  _AttributeName[intIndex])
{
return mbolIsVB;
}
else if (conCodeType.IsTableFldConst  ==  _AttributeName[intIndex])
{
return mbolIsTableFldConst;
}
else if (conCodeType.IsPubApp4WinWeb  ==  _AttributeName[intIndex])
{
return mbolIsPubApp4WinWeb;
}
else if (conCodeType.IsWeb  ==  _AttributeName[intIndex])
{
return mbolIsWeb;
}
else if (conCodeType.IsAspMvc  ==  _AttributeName[intIndex])
{
return mbolIsAspMvc;
}
else if (conCodeType.IsWebSrvAccess  ==  _AttributeName[intIndex])
{
return mbolIsWebSrvAccess;
}
else if (conCodeType.IsWin  ==  _AttributeName[intIndex])
{
return mbolIsWin;
}
else if (conCodeType.IsMobileApp  ==  _AttributeName[intIndex])
{
return mbolIsMobileApp;
}
else if (conCodeType.IsExtend  ==  _AttributeName[intIndex])
{
return mbolIsExtend;
}
else if (conCodeType.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conCodeType.WinOrWeb  ==  _AttributeName[intIndex])
{
return mstrWinOrWeb;
}
else if (conCodeType.IsDirByTabName  ==  _AttributeName[intIndex])
{
return mbolIsDirByTabName;
}
else if (conCodeType.IsDefaultOverride  ==  _AttributeName[intIndex])
{
return mbolIsDefaultOverride;
}
else if (conCodeType.InUse  ==  _AttributeName[intIndex])
{
return mbolInUse;
}
else if (conCodeType.IsAutoParseFile  ==  _AttributeName[intIndex])
{
return mbolIsAutoParseFile;
}
else if (conCodeType.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conCodeType.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conCodeType.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conCodeType.CodeTypeId  ==  _AttributeName[intIndex])
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(conCodeType.CodeTypeId);
}
else if (conCodeType.CodeTypeName  ==  _AttributeName[intIndex])
{
mstrCodeTypeName = value.ToString();
 AddUpdatedFld(conCodeType.CodeTypeName);
}
else if (conCodeType.CodeTypeSimName  ==  _AttributeName[intIndex])
{
mstrCodeTypeSimName = value.ToString();
 AddUpdatedFld(conCodeType.CodeTypeSimName);
}
else if (conCodeType.CodeTypeENName  ==  _AttributeName[intIndex])
{
mstrCodeTypeENName = value.ToString();
 AddUpdatedFld(conCodeType.CodeTypeENName);
}
else if (conCodeType.GroupName  ==  _AttributeName[intIndex])
{
mstrGroupName = value.ToString();
 AddUpdatedFld(conCodeType.GroupName);
}
else if (conCodeType.ProgLangTypeId  ==  _AttributeName[intIndex])
{
mstrProgLangTypeId = value.ToString();
 AddUpdatedFld(conCodeType.ProgLangTypeId);
}
else if (conCodeType.RegionTypeId  ==  _AttributeName[intIndex])
{
mstrRegionTypeId = value.ToString();
 AddUpdatedFld(conCodeType.RegionTypeId);
}
else if (conCodeType.Prefix  ==  _AttributeName[intIndex])
{
mstrPrefix = value.ToString();
 AddUpdatedFld(conCodeType.Prefix);
}
else if (conCodeType.DependsOn  ==  _AttributeName[intIndex])
{
mstrDependsOn = value.ToString();
 AddUpdatedFld(conCodeType.DependsOn);
}
else if (conCodeType.FrontOrBack  ==  _AttributeName[intIndex])
{
mstrFrontOrBack = value.ToString();
 AddUpdatedFld(conCodeType.FrontOrBack);
}
else if (conCodeType.SqlDsTypeId  ==  _AttributeName[intIndex])
{
mstrSqlDsTypeId = value.ToString();
 AddUpdatedFld(conCodeType.SqlDsTypeId);
}
else if (conCodeType.ClassNameFormat  ==  _AttributeName[intIndex])
{
mstrClassNameFormat = value.ToString();
 AddUpdatedFld(conCodeType.ClassNameFormat);
}
else if (conCodeType.FileNameFormat  ==  _AttributeName[intIndex])
{
mstrFileNameFormat = value.ToString();
 AddUpdatedFld(conCodeType.FileNameFormat);
}
else if (conCodeType.ClassNamePattern  ==  _AttributeName[intIndex])
{
mstrClassNamePattern = value.ToString();
 AddUpdatedFld(conCodeType.ClassNamePattern);
}
else if (conCodeType.IsCSharp  ==  _AttributeName[intIndex])
{
mbolIsCSharp = TransNullToBool(value.ToString());
 AddUpdatedFld(conCodeType.IsCSharp);
}
else if (conCodeType.IsJava  ==  _AttributeName[intIndex])
{
mbolIsJava = TransNullToBool(value.ToString());
 AddUpdatedFld(conCodeType.IsJava);
}
else if (conCodeType.IsJavaScript  ==  _AttributeName[intIndex])
{
mbolIsJavaScript = TransNullToBool(value.ToString());
 AddUpdatedFld(conCodeType.IsJavaScript);
}
else if (conCodeType.IsTypeScript  ==  _AttributeName[intIndex])
{
mbolIsTypeScript = TransNullToBool(value.ToString());
 AddUpdatedFld(conCodeType.IsTypeScript);
}
else if (conCodeType.IsSilverLight  ==  _AttributeName[intIndex])
{
mbolIsSilverLight = TransNullToBool(value.ToString());
 AddUpdatedFld(conCodeType.IsSilverLight);
}
else if (conCodeType.IsSwift  ==  _AttributeName[intIndex])
{
mbolIsSwift = TransNullToBool(value.ToString());
 AddUpdatedFld(conCodeType.IsSwift);
}
else if (conCodeType.IsVB  ==  _AttributeName[intIndex])
{
mbolIsVB = TransNullToBool(value.ToString());
 AddUpdatedFld(conCodeType.IsVB);
}
else if (conCodeType.IsTableFldConst  ==  _AttributeName[intIndex])
{
mbolIsTableFldConst = TransNullToBool(value.ToString());
 AddUpdatedFld(conCodeType.IsTableFldConst);
}
else if (conCodeType.IsPubApp4WinWeb  ==  _AttributeName[intIndex])
{
mbolIsPubApp4WinWeb = TransNullToBool(value.ToString());
 AddUpdatedFld(conCodeType.IsPubApp4WinWeb);
}
else if (conCodeType.IsWeb  ==  _AttributeName[intIndex])
{
mbolIsWeb = TransNullToBool(value.ToString());
 AddUpdatedFld(conCodeType.IsWeb);
}
else if (conCodeType.IsAspMvc  ==  _AttributeName[intIndex])
{
mbolIsAspMvc = TransNullToBool(value.ToString());
 AddUpdatedFld(conCodeType.IsAspMvc);
}
else if (conCodeType.IsWebSrvAccess  ==  _AttributeName[intIndex])
{
mbolIsWebSrvAccess = TransNullToBool(value.ToString());
 AddUpdatedFld(conCodeType.IsWebSrvAccess);
}
else if (conCodeType.IsWin  ==  _AttributeName[intIndex])
{
mbolIsWin = TransNullToBool(value.ToString());
 AddUpdatedFld(conCodeType.IsWin);
}
else if (conCodeType.IsMobileApp  ==  _AttributeName[intIndex])
{
mbolIsMobileApp = TransNullToBool(value.ToString());
 AddUpdatedFld(conCodeType.IsMobileApp);
}
else if (conCodeType.IsExtend  ==  _AttributeName[intIndex])
{
mbolIsExtend = TransNullToBool(value.ToString());
 AddUpdatedFld(conCodeType.IsExtend);
}
else if (conCodeType.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conCodeType.OrderNum);
}
else if (conCodeType.WinOrWeb  ==  _AttributeName[intIndex])
{
mstrWinOrWeb = value.ToString();
 AddUpdatedFld(conCodeType.WinOrWeb);
}
else if (conCodeType.IsDirByTabName  ==  _AttributeName[intIndex])
{
mbolIsDirByTabName = TransNullToBool(value.ToString());
 AddUpdatedFld(conCodeType.IsDirByTabName);
}
else if (conCodeType.IsDefaultOverride  ==  _AttributeName[intIndex])
{
mbolIsDefaultOverride = TransNullToBool(value.ToString());
 AddUpdatedFld(conCodeType.IsDefaultOverride);
}
else if (conCodeType.InUse  ==  _AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conCodeType.InUse);
}
else if (conCodeType.IsAutoParseFile  ==  _AttributeName[intIndex])
{
mbolIsAutoParseFile = TransNullToBool(value.ToString());
 AddUpdatedFld(conCodeType.IsAutoParseFile);
}
else if (conCodeType.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCodeType.UpdDate);
}
else if (conCodeType.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conCodeType.UpdUser);
}
else if (conCodeType.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCodeType.Memo);
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
 AddUpdatedFld(conCodeType.CodeTypeId);
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
 AddUpdatedFld(conCodeType.CodeTypeName);
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
 AddUpdatedFld(conCodeType.CodeTypeSimName);
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
 AddUpdatedFld(conCodeType.CodeTypeENName);
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
 AddUpdatedFld(conCodeType.GroupName);
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
 AddUpdatedFld(conCodeType.ProgLangTypeId);
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
 AddUpdatedFld(conCodeType.RegionTypeId);
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
 AddUpdatedFld(conCodeType.Prefix);
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
 AddUpdatedFld(conCodeType.DependsOn);
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
 AddUpdatedFld(conCodeType.FrontOrBack);
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
 AddUpdatedFld(conCodeType.SqlDsTypeId);
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
 AddUpdatedFld(conCodeType.ClassNameFormat);
}
}
/// <summary>
/// 文件名格式(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FileNameFormat
{
get
{
return mstrFileNameFormat;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFileNameFormat = value;
}
else
{
 mstrFileNameFormat = value;
}
//记录修改过的字段
 AddUpdatedFld(conCodeType.FileNameFormat);
}
}
/// <summary>
/// 类名模式(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClassNamePattern
{
get
{
return mstrClassNamePattern;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClassNamePattern = value;
}
else
{
 mstrClassNamePattern = value;
}
//记录修改过的字段
 AddUpdatedFld(conCodeType.ClassNamePattern);
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
 AddUpdatedFld(conCodeType.IsCSharp);
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
 AddUpdatedFld(conCodeType.IsJava);
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
 AddUpdatedFld(conCodeType.IsJavaScript);
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
 AddUpdatedFld(conCodeType.IsTypeScript);
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
 AddUpdatedFld(conCodeType.IsSilverLight);
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
 AddUpdatedFld(conCodeType.IsSwift);
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
 AddUpdatedFld(conCodeType.IsVB);
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
 AddUpdatedFld(conCodeType.IsTableFldConst);
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
 AddUpdatedFld(conCodeType.IsPubApp4WinWeb);
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
 AddUpdatedFld(conCodeType.IsWeb);
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
 AddUpdatedFld(conCodeType.IsAspMvc);
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
 AddUpdatedFld(conCodeType.IsWebSrvAccess);
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
 AddUpdatedFld(conCodeType.IsWin);
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
 AddUpdatedFld(conCodeType.IsMobileApp);
}
}
/// <summary>
/// 是否扩展类(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsExtend
{
get
{
return mbolIsExtend;
}
set
{
 mbolIsExtend = value;
//记录修改过的字段
 AddUpdatedFld(conCodeType.IsExtend);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(conCodeType.OrderNum);
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
 AddUpdatedFld(conCodeType.WinOrWeb);
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
 AddUpdatedFld(conCodeType.IsDirByTabName);
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
 AddUpdatedFld(conCodeType.IsDefaultOverride);
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
 AddUpdatedFld(conCodeType.InUse);
}
}
/// <summary>
/// 是否自动分析文件(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsAutoParseFile
{
get
{
return mbolIsAutoParseFile;
}
set
{
 mbolIsAutoParseFile = value;
//记录修改过的字段
 AddUpdatedFld(conCodeType.IsAutoParseFile);
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
 AddUpdatedFld(conCodeType.UpdDate);
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
 AddUpdatedFld(conCodeType.UpdUser);
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
 AddUpdatedFld(conCodeType.Memo);
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

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrCodeTypeName;
 }
 }
}
 /// <summary>
 /// 代码类型(CodeType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCodeType
{
public const string _CurrTabName = "CodeType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CodeTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"CodeTypeId", "CodeTypeName", "CodeTypeSimName", "CodeTypeENName", "GroupName", "ProgLangTypeId", "RegionTypeId", "Prefix", "DependsOn", "FrontOrBack", "SqlDsTypeId", "ClassNameFormat", "FileNameFormat", "ClassNamePattern", "IsCSharp", "IsJava", "IsJavaScript", "IsTypeScript", "IsSilverLight", "IsSwift", "IsVB", "IsTableFldConst", "IsPubApp4WinWeb", "IsWeb", "IsAspMvc", "IsWebSrvAccess", "IsWin", "IsMobileApp", "IsExtend", "OrderNum", "WinOrWeb", "IsDirByTabName", "IsDefaultOverride", "InUse", "IsAutoParseFile", "UpdDate", "UpdUser", "Memo"};
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
 /// 常量:"RegionTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RegionTypeId = "RegionTypeId";    //区域类型Id

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
 /// 常量:"ClassNameFormat"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClassNameFormat = "ClassNameFormat";    //类名格式

 /// <summary>
 /// 常量:"FileNameFormat"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileNameFormat = "FileNameFormat";    //文件名格式

 /// <summary>
 /// 常量:"ClassNamePattern"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClassNamePattern = "ClassNamePattern";    //类名模式

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
 /// 常量:"IsExtend"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsExtend = "IsExtend";    //是否扩展类

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
 /// 常量:"IsDefaultOverride"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDefaultOverride = "IsDefaultOverride";    //是否默认覆盖

 /// <summary>
 /// 常量:"InUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InUse = "InUse";    //是否在用

 /// <summary>
 /// 常量:"IsAutoParseFile"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsAutoParseFile = "IsAutoParseFile";    //是否自动分析文件

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
}

}