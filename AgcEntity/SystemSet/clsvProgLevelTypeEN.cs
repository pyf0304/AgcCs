
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvProgLevelTypeEN
 表名:vProgLevelType(00050411)
 生成代码版本:2018.08.21.1
 生成日期:2018/08/26 15:16:42
 生成者:潘以锋
 生成服务器IP:202.121.63.42
 工程名称:AGC
 工程ID:0005
 相关数据库:101.251.68.133,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统设置
 模块英文名:SystemSet
 框架-层名:实体层(EntityLayer)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2018.07.27.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
using System;
using System.Text; 
using System.Collections; 
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System.Runtime.Serialization;

namespace AGC.Entity
{
 /// <summary>
 /// vProgLevelType(vProgLevelType)
 /// (AutoGCLib.AutoGC6Cs_M:A_GenEntityLayerCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvProgLevelTypeEN : clsEntityBase2
{
public const string CurrTabName_S = "vProgLevelType"; //当前表名,与该类相关的表名
public const string CurrTabKeyFldName_S = "ProgLevelTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 28;
public static string[] AttributeName = new string[] {"ProgLevelTypeId", "ProgLevelTypeName", "CodeTypeId", "CodeTypeName", "CodeTypeENName", "DependsOn", "IsCSharp", "IsJava", "IsJavaScript", "IsTypeScript", "IsSilverLight", "IsSwift", "IsVB", "IsTableFldConst", "IsPubApp4WinWeb", "IsWeb", "IsWebSrvAccess", "IsWin", "IsMobileApp", "WinOrWeb", "IsDefaultOverride", "ProgLevelTypeENName", "Prefix", "OrderNum", "UpdDate", "UpdUserId", "Memo", "OrderNum4CodeType"};
//以下是属性变量

protected string mstrProgLevelTypeId;    //程序分层类型Id
protected string mstrProgLevelTypeName;    //程序分层类型名称
protected string mstrCodeTypeId;    //代码类型Id
protected string mstrCodeTypeName;    //代码类型名
protected string mstrCodeTypeENName;    //代码类型英文名
protected string mstrDependsOn;    //依赖于
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
protected bool mbolIsWebSrvAccess;    //IsWebSrvAccess
protected bool mbolIsWin;    //是否Win应用
protected bool mbolIsMobileApp;    //是否移动终端应用
protected string mstrWinOrWeb;    //WinOrWeb
protected bool mbolIsDefaultOverride;    //是否默认覆盖
protected string mstrProgLevelTypeENName;    //程序分层类型英文名称
protected string mstrPrefix;    //前缀
protected int mintOrderNum;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //说明
protected int mintOrderNum4CodeType;    //OrderNum4CodeType


 /// <summary>
 /// 常量:"ProgLevelTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ProgLevelTypeId = "ProgLevelTypeId";    //程序分层类型Id

 /// <summary>
 /// 常量:"ProgLevelTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ProgLevelTypeName = "ProgLevelTypeName";    //程序分层类型名称

 /// <summary>
 /// 常量:"CodeTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_CodeTypeId = "CodeTypeId";    //代码类型Id

 /// <summary>
 /// 常量:"CodeTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_CodeTypeName = "CodeTypeName";    //代码类型名

 /// <summary>
 /// 常量:"CodeTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_CodeTypeENName = "CodeTypeENName";    //代码类型英文名

 /// <summary>
 /// 常量:"DependsOn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_DependsOn = "DependsOn";    //依赖于

 /// <summary>
 /// 常量:"IsCSharp"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsCSharp = "IsCSharp";    //是否CSharp语言

 /// <summary>
 /// 常量:"IsJava"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsJava = "IsJava";    //是否Java语言

 /// <summary>
 /// 常量:"IsJavaScript"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsJavaScript = "IsJavaScript";    //是否JavaScript语言

 /// <summary>
 /// 常量:"IsTypeScript"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsTypeScript = "IsTypeScript";    //是否TypeScript语言

 /// <summary>
 /// 常量:"IsSilverLight"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsSilverLight = "IsSilverLight";    //是否SilverLight语言

 /// <summary>
 /// 常量:"IsSwift"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsSwift = "IsSwift";    //是否Swift语言

 /// <summary>
 /// 常量:"IsVB"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsVB = "IsVB";    //IsVB语言

 /// <summary>
 /// 常量:"IsTableFldConst"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsTableFldConst = "IsTableFldConst";    //IsTableFldConst

 /// <summary>
 /// 常量:"IsPubApp4WinWeb"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsPubApp4WinWeb = "IsPubApp4WinWeb";    //IsPubApp4WinWeb

 /// <summary>
 /// 常量:"IsWeb"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsWeb = "IsWeb";    //是否Web应用

 /// <summary>
 /// 常量:"IsWebSrvAccess"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsWebSrvAccess = "IsWebSrvAccess";    //IsWebSrvAccess

 /// <summary>
 /// 常量:"IsWin"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsWin = "IsWin";    //是否Win应用

 /// <summary>
 /// 常量:"IsMobileApp"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsMobileApp = "IsMobileApp";    //是否移动终端应用

 /// <summary>
 /// 常量:"WinOrWeb"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_WinOrWeb = "WinOrWeb";    //WinOrWeb

 /// <summary>
 /// 常量:"IsDefaultOverride"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsDefaultOverride = "IsDefaultOverride";    //是否默认覆盖

 /// <summary>
 /// 常量:"ProgLevelTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ProgLevelTypeENName = "ProgLevelTypeENName";    //程序分层类型英文名称

 /// <summary>
 /// 常量:"Prefix"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Prefix = "Prefix";    //前缀

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_OrderNum = "OrderNum";    //序号

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
 /// 常量:"OrderNum4CodeType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_OrderNum4CodeType = "OrderNum4CodeType";    //OrderNum4CodeType

/// <summary>
/// 构造函数
 /// (AutoGCLib.AutoGCPubFuncV6:GenClassConstructor1)
/// </summary>
 public clsvProgLevelTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "vProgLevelType";
 lstKeyFldNames.Add("ProgLevelTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.AutoGCPubFuncV6:GenClassConstructor2)
/// </summary>
/// <param name = "mstrProgLevelTypeId">关键字:程序分层类型Id</param>
public clsvProgLevelTypeEN(string strProgLevelTypeId)
 {
strProgLevelTypeId = strProgLevelTypeId.Replace("'", "''");
if (strProgLevelTypeId.Length > 2)
{
throw new Exception("在表:vProgLevelType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strProgLevelTypeId)  ==  true)
{
throw new Exception("在表:vProgLevelType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strProgLevelTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

mstrProgLevelTypeId = strProgLevelTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "vProgLevelType";
 lstKeyFldNames.Add("ProgLevelTypeId");
 }

public static int AttributeCount
{
get
{
return mintAttributeCount;
}
}
public object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  con_ProgLevelTypeId)
{
return mstrProgLevelTypeId;
}
else if (strAttributeName  ==  con_ProgLevelTypeName)
{
return mstrProgLevelTypeName;
}
else if (strAttributeName  ==  con_CodeTypeId)
{
return mstrCodeTypeId;
}
else if (strAttributeName  ==  con_CodeTypeName)
{
return mstrCodeTypeName;
}
else if (strAttributeName  ==  con_CodeTypeENName)
{
return mstrCodeTypeENName;
}
else if (strAttributeName  ==  con_DependsOn)
{
return mstrDependsOn;
}
else if (strAttributeName  ==  con_IsCSharp)
{
return mbolIsCSharp;
}
else if (strAttributeName  ==  con_IsJava)
{
return mbolIsJava;
}
else if (strAttributeName  ==  con_IsJavaScript)
{
return mbolIsJavaScript;
}
else if (strAttributeName  ==  con_IsTypeScript)
{
return mbolIsTypeScript;
}
else if (strAttributeName  ==  con_IsSilverLight)
{
return mbolIsSilverLight;
}
else if (strAttributeName  ==  con_IsSwift)
{
return mbolIsSwift;
}
else if (strAttributeName  ==  con_IsVB)
{
return mbolIsVB;
}
else if (strAttributeName  ==  con_IsTableFldConst)
{
return mbolIsTableFldConst;
}
else if (strAttributeName  ==  con_IsPubApp4WinWeb)
{
return mbolIsPubApp4WinWeb;
}
else if (strAttributeName  ==  con_IsWeb)
{
return mbolIsWeb;
}
else if (strAttributeName  ==  con_IsWebSrvAccess)
{
return mbolIsWebSrvAccess;
}
else if (strAttributeName  ==  con_IsWin)
{
return mbolIsWin;
}
else if (strAttributeName  ==  con_IsMobileApp)
{
return mbolIsMobileApp;
}
else if (strAttributeName  ==  con_WinOrWeb)
{
return mstrWinOrWeb;
}
else if (strAttributeName  ==  con_IsDefaultOverride)
{
return mbolIsDefaultOverride;
}
else if (strAttributeName  ==  con_ProgLevelTypeENName)
{
return mstrProgLevelTypeENName;
}
else if (strAttributeName  ==  con_Prefix)
{
return mstrPrefix;
}
else if (strAttributeName  ==  con_OrderNum)
{
return mintOrderNum;
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
else if (strAttributeName  ==  con_OrderNum4CodeType)
{
return mintOrderNum4CodeType;
}
return null;
}
set
{
if (strAttributeName  ==  con_ProgLevelTypeId)
{
mstrProgLevelTypeId = value.ToString();
 AddUpdatedFld(con_ProgLevelTypeId);
}
else if (strAttributeName  ==  con_ProgLevelTypeName)
{
mstrProgLevelTypeName = value.ToString();
 AddUpdatedFld(con_ProgLevelTypeName);
}
else if (strAttributeName  ==  con_CodeTypeId)
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(con_CodeTypeId);
}
else if (strAttributeName  ==  con_CodeTypeName)
{
mstrCodeTypeName = value.ToString();
 AddUpdatedFld(con_CodeTypeName);
}
else if (strAttributeName  ==  con_CodeTypeENName)
{
mstrCodeTypeENName = value.ToString();
 AddUpdatedFld(con_CodeTypeENName);
}
else if (strAttributeName  ==  con_DependsOn)
{
mstrDependsOn = value.ToString();
 AddUpdatedFld(con_DependsOn);
}
else if (strAttributeName  ==  con_IsCSharp)
{
mbolIsCSharp = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsCSharp);
}
else if (strAttributeName  ==  con_IsJava)
{
mbolIsJava = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsJava);
}
else if (strAttributeName  ==  con_IsJavaScript)
{
mbolIsJavaScript = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsJavaScript);
}
else if (strAttributeName  ==  con_IsTypeScript)
{
mbolIsTypeScript = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsTypeScript);
}
else if (strAttributeName  ==  con_IsSilverLight)
{
mbolIsSilverLight = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsSilverLight);
}
else if (strAttributeName  ==  con_IsSwift)
{
mbolIsSwift = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsSwift);
}
else if (strAttributeName  ==  con_IsVB)
{
mbolIsVB = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsVB);
}
else if (strAttributeName  ==  con_IsTableFldConst)
{
mbolIsTableFldConst = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsTableFldConst);
}
else if (strAttributeName  ==  con_IsPubApp4WinWeb)
{
mbolIsPubApp4WinWeb = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsPubApp4WinWeb);
}
else if (strAttributeName  ==  con_IsWeb)
{
mbolIsWeb = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsWeb);
}
else if (strAttributeName  ==  con_IsWebSrvAccess)
{
mbolIsWebSrvAccess = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsWebSrvAccess);
}
else if (strAttributeName  ==  con_IsWin)
{
mbolIsWin = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsWin);
}
else if (strAttributeName  ==  con_IsMobileApp)
{
mbolIsMobileApp = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsMobileApp);
}
else if (strAttributeName  ==  con_WinOrWeb)
{
mstrWinOrWeb = value.ToString();
 AddUpdatedFld(con_WinOrWeb);
}
else if (strAttributeName  ==  con_IsDefaultOverride)
{
mbolIsDefaultOverride = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsDefaultOverride);
}
else if (strAttributeName  ==  con_ProgLevelTypeENName)
{
mstrProgLevelTypeENName = value.ToString();
 AddUpdatedFld(con_ProgLevelTypeENName);
}
else if (strAttributeName  ==  con_Prefix)
{
mstrPrefix = value.ToString();
 AddUpdatedFld(con_Prefix);
}
else if (strAttributeName  ==  con_OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(con_OrderNum);
}
else if (strAttributeName  ==  con_UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(con_UpdDate);
}
else if (strAttributeName  ==  con_UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(con_UpdUserId);
}
else if (strAttributeName  ==  con_Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
}
else if (strAttributeName  ==  con_OrderNum4CodeType)
{
mintOrderNum4CodeType = TransNullToInt(value.ToString());
 AddUpdatedFld(con_OrderNum4CodeType);
}
}
}
public object this[int intIndex]
{
get
{
if (con_ProgLevelTypeId  ==  AttributeName[intIndex])
{
return mstrProgLevelTypeId;
}
else if (con_ProgLevelTypeName  ==  AttributeName[intIndex])
{
return mstrProgLevelTypeName;
}
else if (con_CodeTypeId  ==  AttributeName[intIndex])
{
return mstrCodeTypeId;
}
else if (con_CodeTypeName  ==  AttributeName[intIndex])
{
return mstrCodeTypeName;
}
else if (con_CodeTypeENName  ==  AttributeName[intIndex])
{
return mstrCodeTypeENName;
}
else if (con_DependsOn  ==  AttributeName[intIndex])
{
return mstrDependsOn;
}
else if (con_IsCSharp  ==  AttributeName[intIndex])
{
return mbolIsCSharp;
}
else if (con_IsJava  ==  AttributeName[intIndex])
{
return mbolIsJava;
}
else if (con_IsJavaScript  ==  AttributeName[intIndex])
{
return mbolIsJavaScript;
}
else if (con_IsTypeScript  ==  AttributeName[intIndex])
{
return mbolIsTypeScript;
}
else if (con_IsSilverLight  ==  AttributeName[intIndex])
{
return mbolIsSilverLight;
}
else if (con_IsSwift  ==  AttributeName[intIndex])
{
return mbolIsSwift;
}
else if (con_IsVB  ==  AttributeName[intIndex])
{
return mbolIsVB;
}
else if (con_IsTableFldConst  ==  AttributeName[intIndex])
{
return mbolIsTableFldConst;
}
else if (con_IsPubApp4WinWeb  ==  AttributeName[intIndex])
{
return mbolIsPubApp4WinWeb;
}
else if (con_IsWeb  ==  AttributeName[intIndex])
{
return mbolIsWeb;
}
else if (con_IsWebSrvAccess  ==  AttributeName[intIndex])
{
return mbolIsWebSrvAccess;
}
else if (con_IsWin  ==  AttributeName[intIndex])
{
return mbolIsWin;
}
else if (con_IsMobileApp  ==  AttributeName[intIndex])
{
return mbolIsMobileApp;
}
else if (con_WinOrWeb  ==  AttributeName[intIndex])
{
return mstrWinOrWeb;
}
else if (con_IsDefaultOverride  ==  AttributeName[intIndex])
{
return mbolIsDefaultOverride;
}
else if (con_ProgLevelTypeENName  ==  AttributeName[intIndex])
{
return mstrProgLevelTypeENName;
}
else if (con_Prefix  ==  AttributeName[intIndex])
{
return mstrPrefix;
}
else if (con_OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
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
else if (con_OrderNum4CodeType  ==  AttributeName[intIndex])
{
return mintOrderNum4CodeType;
}
return null;
}
set
{
if (con_ProgLevelTypeId  ==  AttributeName[intIndex])
{
mstrProgLevelTypeId = value.ToString();
 AddUpdatedFld(con_ProgLevelTypeId);
}
else if (con_ProgLevelTypeName  ==  AttributeName[intIndex])
{
mstrProgLevelTypeName = value.ToString();
 AddUpdatedFld(con_ProgLevelTypeName);
}
else if (con_CodeTypeId  ==  AttributeName[intIndex])
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(con_CodeTypeId);
}
else if (con_CodeTypeName  ==  AttributeName[intIndex])
{
mstrCodeTypeName = value.ToString();
 AddUpdatedFld(con_CodeTypeName);
}
else if (con_CodeTypeENName  ==  AttributeName[intIndex])
{
mstrCodeTypeENName = value.ToString();
 AddUpdatedFld(con_CodeTypeENName);
}
else if (con_DependsOn  ==  AttributeName[intIndex])
{
mstrDependsOn = value.ToString();
 AddUpdatedFld(con_DependsOn);
}
else if (con_IsCSharp  ==  AttributeName[intIndex])
{
mbolIsCSharp = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsCSharp);
}
else if (con_IsJava  ==  AttributeName[intIndex])
{
mbolIsJava = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsJava);
}
else if (con_IsJavaScript  ==  AttributeName[intIndex])
{
mbolIsJavaScript = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsJavaScript);
}
else if (con_IsTypeScript  ==  AttributeName[intIndex])
{
mbolIsTypeScript = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsTypeScript);
}
else if (con_IsSilverLight  ==  AttributeName[intIndex])
{
mbolIsSilverLight = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsSilverLight);
}
else if (con_IsSwift  ==  AttributeName[intIndex])
{
mbolIsSwift = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsSwift);
}
else if (con_IsVB  ==  AttributeName[intIndex])
{
mbolIsVB = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsVB);
}
else if (con_IsTableFldConst  ==  AttributeName[intIndex])
{
mbolIsTableFldConst = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsTableFldConst);
}
else if (con_IsPubApp4WinWeb  ==  AttributeName[intIndex])
{
mbolIsPubApp4WinWeb = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsPubApp4WinWeb);
}
else if (con_IsWeb  ==  AttributeName[intIndex])
{
mbolIsWeb = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsWeb);
}
else if (con_IsWebSrvAccess  ==  AttributeName[intIndex])
{
mbolIsWebSrvAccess = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsWebSrvAccess);
}
else if (con_IsWin  ==  AttributeName[intIndex])
{
mbolIsWin = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsWin);
}
else if (con_IsMobileApp  ==  AttributeName[intIndex])
{
mbolIsMobileApp = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsMobileApp);
}
else if (con_WinOrWeb  ==  AttributeName[intIndex])
{
mstrWinOrWeb = value.ToString();
 AddUpdatedFld(con_WinOrWeb);
}
else if (con_IsDefaultOverride  ==  AttributeName[intIndex])
{
mbolIsDefaultOverride = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsDefaultOverride);
}
else if (con_ProgLevelTypeENName  ==  AttributeName[intIndex])
{
mstrProgLevelTypeENName = value.ToString();
 AddUpdatedFld(con_ProgLevelTypeENName);
}
else if (con_Prefix  ==  AttributeName[intIndex])
{
mstrPrefix = value.ToString();
 AddUpdatedFld(con_Prefix);
}
else if (con_OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(con_OrderNum);
}
else if (con_UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(con_UpdDate);
}
else if (con_UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(con_UpdUserId);
}
else if (con_Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
}
else if (con_OrderNum4CodeType  ==  AttributeName[intIndex])
{
mintOrderNum4CodeType = TransNullToInt(value.ToString());
 AddUpdatedFld(con_OrderNum4CodeType);
}
}
}

/// <summary>
/// 程序分层类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLevelTypeId
{
get
{
return mstrProgLevelTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLevelTypeId = value;
}
else
{
 mstrProgLevelTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_ProgLevelTypeId);
}
}
/// <summary>
/// 程序分层类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLevelTypeName
{
get
{
return mstrProgLevelTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLevelTypeName = value;
}
else
{
 mstrProgLevelTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_ProgLevelTypeName);
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
 AddUpdatedFld(con_CodeTypeId);
}
}
/// <summary>
/// 代码类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
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
 AddUpdatedFld(con_CodeTypeName);
}
}
/// <summary>
/// 代码类型英文名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
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
 AddUpdatedFld(con_CodeTypeENName);
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
 AddUpdatedFld(con_DependsOn);
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
 AddUpdatedFld(con_IsCSharp);
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
 AddUpdatedFld(con_IsJava);
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
 AddUpdatedFld(con_IsJavaScript);
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
 AddUpdatedFld(con_IsTypeScript);
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
 AddUpdatedFld(con_IsSilverLight);
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
 AddUpdatedFld(con_IsSwift);
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
 AddUpdatedFld(con_IsVB);
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
 AddUpdatedFld(con_IsTableFldConst);
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
 AddUpdatedFld(con_IsPubApp4WinWeb);
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
 AddUpdatedFld(con_IsWeb);
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
 AddUpdatedFld(con_IsWebSrvAccess);
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
 AddUpdatedFld(con_IsWin);
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
 AddUpdatedFld(con_IsMobileApp);
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
 AddUpdatedFld(con_WinOrWeb);
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
 AddUpdatedFld(con_IsDefaultOverride);
}
}
/// <summary>
/// 程序分层类型英文名称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLevelTypeENName
{
get
{
return mstrProgLevelTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLevelTypeENName = value;
}
else
{
 mstrProgLevelTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_ProgLevelTypeENName);
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
 AddUpdatedFld(con_Prefix);
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
 AddUpdatedFld(con_OrderNum);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:14;是否可空:True)
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
 AddUpdatedFld(con_UpdDate);
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
 AddUpdatedFld(con_UpdUserId);
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
 AddUpdatedFld(con_Memo);
}
}
/// <summary>
/// OrderNum4CodeType(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int OrderNum4CodeType
{
get
{
return mintOrderNum4CodeType;
}
set
{
 mintOrderNum4CodeType = value;
//记录修改过的字段
 AddUpdatedFld(con_OrderNum4CodeType);
}
}

/// <summary>
/// 获取关键字Id(KeyId)
 /// (AutoGCLib.AutoGCPubFuncV6:GenGetKeyId)
/// </summary>
 public override string _KeyId
 {
 get
 {
  return mstrProgLevelTypeId;
 }
 }
}
}