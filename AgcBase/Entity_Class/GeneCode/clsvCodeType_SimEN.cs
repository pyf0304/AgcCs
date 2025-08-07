
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCodeType_SimEN
 表名:vCodeType_Sim(00050623)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:41:31
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
 /// 表vCodeType_Sim的关键字(CodeTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CodeTypeId_vCodeType_Sim
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
public K_CodeTypeId_vCodeType_Sim(string strCodeTypeId)
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
 /// <returns>返回:[K_CodeTypeId_vCodeType_Sim]类型的对象</returns>
public static implicit operator K_CodeTypeId_vCodeType_Sim(string value)
{
return new K_CodeTypeId_vCodeType_Sim(value);
}
}
 /// <summary>
 /// vCodeType_Sim(vCodeType_Sim)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvCodeType_SimEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vCodeType_Sim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "CodeTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 20;
public static string[] _AttributeName = new string[] {"CodeTypeId", "CodeTypeName", "CodeTypeENName", "GroupName", "DependsOn", "FrontOrBack", "OrderNum", "ProgLangTypeId", "Prefix", "AppCount", "FuncCount", "ClassNameFormat", "CodeTypeSimName", "RegionTypeId", "InUse", "SqlDsTypeId", "IsDefaultOverride", "IsExtend", "IsAutoParseFile", "FileNameFormat"};

protected string mstrCodeTypeId;    //代码类型Id
protected string mstrCodeTypeName;    //代码类型名
protected string mstrCodeTypeENName;    //代码类型英文名
protected string mstrGroupName;    //组名
protected string mstrDependsOn;    //依赖于
protected string mstrFrontOrBack;    //前台Or后台
protected int? mintOrderNum;    //序号
protected string mstrProgLangTypeId;    //编程语言类型Id
protected string mstrPrefix;    //前缀
protected int? mintAppCount;    //应用数
protected int? mintFuncCount;    //函数数目
protected string mstrClassNameFormat;    //类名格式
protected string mstrCodeTypeSimName;    //简称
protected string mstrRegionTypeId;    //区域类型Id
protected bool mbolInUse;    //是否在用
protected string mstrSqlDsTypeId;    //数据源类型Id
protected bool mbolIsDefaultOverride;    //是否默认覆盖
protected bool mbolIsExtend;    //是否扩展类
protected bool mbolIsAutoParseFile;    //是否自动分析文件
protected string mstrFileNameFormat;    //文件名格式

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvCodeType_SimEN()
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
public clsvCodeType_SimEN(string strCodeTypeId)
 {
strCodeTypeId = strCodeTypeId.Replace("'", "''");
if (strCodeTypeId.Length > 4)
{
throw new Exception("在表:vCodeType_Sim中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strCodeTypeId)  ==  true)
{
throw new Exception("在表:vCodeType_Sim中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convCodeType_Sim.CodeTypeId)
{
return mstrCodeTypeId;
}
else if (strAttributeName  ==  convCodeType_Sim.CodeTypeName)
{
return mstrCodeTypeName;
}
else if (strAttributeName  ==  convCodeType_Sim.CodeTypeENName)
{
return mstrCodeTypeENName;
}
else if (strAttributeName  ==  convCodeType_Sim.GroupName)
{
return mstrGroupName;
}
else if (strAttributeName  ==  convCodeType_Sim.DependsOn)
{
return mstrDependsOn;
}
else if (strAttributeName  ==  convCodeType_Sim.FrontOrBack)
{
return mstrFrontOrBack;
}
else if (strAttributeName  ==  convCodeType_Sim.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convCodeType_Sim.ProgLangTypeId)
{
return mstrProgLangTypeId;
}
else if (strAttributeName  ==  convCodeType_Sim.Prefix)
{
return mstrPrefix;
}
else if (strAttributeName  ==  convCodeType_Sim.AppCount)
{
return mintAppCount;
}
else if (strAttributeName  ==  convCodeType_Sim.FuncCount)
{
return mintFuncCount;
}
else if (strAttributeName  ==  convCodeType_Sim.ClassNameFormat)
{
return mstrClassNameFormat;
}
else if (strAttributeName  ==  convCodeType_Sim.CodeTypeSimName)
{
return mstrCodeTypeSimName;
}
else if (strAttributeName  ==  convCodeType_Sim.RegionTypeId)
{
return mstrRegionTypeId;
}
else if (strAttributeName  ==  convCodeType_Sim.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  convCodeType_Sim.SqlDsTypeId)
{
return mstrSqlDsTypeId;
}
else if (strAttributeName  ==  convCodeType_Sim.IsDefaultOverride)
{
return mbolIsDefaultOverride;
}
else if (strAttributeName  ==  convCodeType_Sim.IsExtend)
{
return mbolIsExtend;
}
else if (strAttributeName  ==  convCodeType_Sim.IsAutoParseFile)
{
return mbolIsAutoParseFile;
}
else if (strAttributeName  ==  convCodeType_Sim.FileNameFormat)
{
return mstrFileNameFormat;
}
return null;
}
set
{
if (strAttributeName  ==  convCodeType_Sim.CodeTypeId)
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(convCodeType_Sim.CodeTypeId);
}
else if (strAttributeName  ==  convCodeType_Sim.CodeTypeName)
{
mstrCodeTypeName = value.ToString();
 AddUpdatedFld(convCodeType_Sim.CodeTypeName);
}
else if (strAttributeName  ==  convCodeType_Sim.CodeTypeENName)
{
mstrCodeTypeENName = value.ToString();
 AddUpdatedFld(convCodeType_Sim.CodeTypeENName);
}
else if (strAttributeName  ==  convCodeType_Sim.GroupName)
{
mstrGroupName = value.ToString();
 AddUpdatedFld(convCodeType_Sim.GroupName);
}
else if (strAttributeName  ==  convCodeType_Sim.DependsOn)
{
mstrDependsOn = value.ToString();
 AddUpdatedFld(convCodeType_Sim.DependsOn);
}
else if (strAttributeName  ==  convCodeType_Sim.FrontOrBack)
{
mstrFrontOrBack = value.ToString();
 AddUpdatedFld(convCodeType_Sim.FrontOrBack);
}
else if (strAttributeName  ==  convCodeType_Sim.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convCodeType_Sim.OrderNum);
}
else if (strAttributeName  ==  convCodeType_Sim.ProgLangTypeId)
{
mstrProgLangTypeId = value.ToString();
 AddUpdatedFld(convCodeType_Sim.ProgLangTypeId);
}
else if (strAttributeName  ==  convCodeType_Sim.Prefix)
{
mstrPrefix = value.ToString();
 AddUpdatedFld(convCodeType_Sim.Prefix);
}
else if (strAttributeName  ==  convCodeType_Sim.AppCount)
{
mintAppCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCodeType_Sim.AppCount);
}
else if (strAttributeName  ==  convCodeType_Sim.FuncCount)
{
mintFuncCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCodeType_Sim.FuncCount);
}
else if (strAttributeName  ==  convCodeType_Sim.ClassNameFormat)
{
mstrClassNameFormat = value.ToString();
 AddUpdatedFld(convCodeType_Sim.ClassNameFormat);
}
else if (strAttributeName  ==  convCodeType_Sim.CodeTypeSimName)
{
mstrCodeTypeSimName = value.ToString();
 AddUpdatedFld(convCodeType_Sim.CodeTypeSimName);
}
else if (strAttributeName  ==  convCodeType_Sim.RegionTypeId)
{
mstrRegionTypeId = value.ToString();
 AddUpdatedFld(convCodeType_Sim.RegionTypeId);
}
else if (strAttributeName  ==  convCodeType_Sim.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convCodeType_Sim.InUse);
}
else if (strAttributeName  ==  convCodeType_Sim.SqlDsTypeId)
{
mstrSqlDsTypeId = value.ToString();
 AddUpdatedFld(convCodeType_Sim.SqlDsTypeId);
}
else if (strAttributeName  ==  convCodeType_Sim.IsDefaultOverride)
{
mbolIsDefaultOverride = TransNullToBool(value.ToString());
 AddUpdatedFld(convCodeType_Sim.IsDefaultOverride);
}
else if (strAttributeName  ==  convCodeType_Sim.IsExtend)
{
mbolIsExtend = TransNullToBool(value.ToString());
 AddUpdatedFld(convCodeType_Sim.IsExtend);
}
else if (strAttributeName  ==  convCodeType_Sim.IsAutoParseFile)
{
mbolIsAutoParseFile = TransNullToBool(value.ToString());
 AddUpdatedFld(convCodeType_Sim.IsAutoParseFile);
}
else if (strAttributeName  ==  convCodeType_Sim.FileNameFormat)
{
mstrFileNameFormat = value.ToString();
 AddUpdatedFld(convCodeType_Sim.FileNameFormat);
}
}
}
public object this[int intIndex]
{
get
{
if (convCodeType_Sim.CodeTypeId  ==  _AttributeName[intIndex])
{
return mstrCodeTypeId;
}
else if (convCodeType_Sim.CodeTypeName  ==  _AttributeName[intIndex])
{
return mstrCodeTypeName;
}
else if (convCodeType_Sim.CodeTypeENName  ==  _AttributeName[intIndex])
{
return mstrCodeTypeENName;
}
else if (convCodeType_Sim.GroupName  ==  _AttributeName[intIndex])
{
return mstrGroupName;
}
else if (convCodeType_Sim.DependsOn  ==  _AttributeName[intIndex])
{
return mstrDependsOn;
}
else if (convCodeType_Sim.FrontOrBack  ==  _AttributeName[intIndex])
{
return mstrFrontOrBack;
}
else if (convCodeType_Sim.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convCodeType_Sim.ProgLangTypeId  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeId;
}
else if (convCodeType_Sim.Prefix  ==  _AttributeName[intIndex])
{
return mstrPrefix;
}
else if (convCodeType_Sim.AppCount  ==  _AttributeName[intIndex])
{
return mintAppCount;
}
else if (convCodeType_Sim.FuncCount  ==  _AttributeName[intIndex])
{
return mintFuncCount;
}
else if (convCodeType_Sim.ClassNameFormat  ==  _AttributeName[intIndex])
{
return mstrClassNameFormat;
}
else if (convCodeType_Sim.CodeTypeSimName  ==  _AttributeName[intIndex])
{
return mstrCodeTypeSimName;
}
else if (convCodeType_Sim.RegionTypeId  ==  _AttributeName[intIndex])
{
return mstrRegionTypeId;
}
else if (convCodeType_Sim.InUse  ==  _AttributeName[intIndex])
{
return mbolInUse;
}
else if (convCodeType_Sim.SqlDsTypeId  ==  _AttributeName[intIndex])
{
return mstrSqlDsTypeId;
}
else if (convCodeType_Sim.IsDefaultOverride  ==  _AttributeName[intIndex])
{
return mbolIsDefaultOverride;
}
else if (convCodeType_Sim.IsExtend  ==  _AttributeName[intIndex])
{
return mbolIsExtend;
}
else if (convCodeType_Sim.IsAutoParseFile  ==  _AttributeName[intIndex])
{
return mbolIsAutoParseFile;
}
else if (convCodeType_Sim.FileNameFormat  ==  _AttributeName[intIndex])
{
return mstrFileNameFormat;
}
return null;
}
set
{
if (convCodeType_Sim.CodeTypeId  ==  _AttributeName[intIndex])
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(convCodeType_Sim.CodeTypeId);
}
else if (convCodeType_Sim.CodeTypeName  ==  _AttributeName[intIndex])
{
mstrCodeTypeName = value.ToString();
 AddUpdatedFld(convCodeType_Sim.CodeTypeName);
}
else if (convCodeType_Sim.CodeTypeENName  ==  _AttributeName[intIndex])
{
mstrCodeTypeENName = value.ToString();
 AddUpdatedFld(convCodeType_Sim.CodeTypeENName);
}
else if (convCodeType_Sim.GroupName  ==  _AttributeName[intIndex])
{
mstrGroupName = value.ToString();
 AddUpdatedFld(convCodeType_Sim.GroupName);
}
else if (convCodeType_Sim.DependsOn  ==  _AttributeName[intIndex])
{
mstrDependsOn = value.ToString();
 AddUpdatedFld(convCodeType_Sim.DependsOn);
}
else if (convCodeType_Sim.FrontOrBack  ==  _AttributeName[intIndex])
{
mstrFrontOrBack = value.ToString();
 AddUpdatedFld(convCodeType_Sim.FrontOrBack);
}
else if (convCodeType_Sim.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convCodeType_Sim.OrderNum);
}
else if (convCodeType_Sim.ProgLangTypeId  ==  _AttributeName[intIndex])
{
mstrProgLangTypeId = value.ToString();
 AddUpdatedFld(convCodeType_Sim.ProgLangTypeId);
}
else if (convCodeType_Sim.Prefix  ==  _AttributeName[intIndex])
{
mstrPrefix = value.ToString();
 AddUpdatedFld(convCodeType_Sim.Prefix);
}
else if (convCodeType_Sim.AppCount  ==  _AttributeName[intIndex])
{
mintAppCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCodeType_Sim.AppCount);
}
else if (convCodeType_Sim.FuncCount  ==  _AttributeName[intIndex])
{
mintFuncCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCodeType_Sim.FuncCount);
}
else if (convCodeType_Sim.ClassNameFormat  ==  _AttributeName[intIndex])
{
mstrClassNameFormat = value.ToString();
 AddUpdatedFld(convCodeType_Sim.ClassNameFormat);
}
else if (convCodeType_Sim.CodeTypeSimName  ==  _AttributeName[intIndex])
{
mstrCodeTypeSimName = value.ToString();
 AddUpdatedFld(convCodeType_Sim.CodeTypeSimName);
}
else if (convCodeType_Sim.RegionTypeId  ==  _AttributeName[intIndex])
{
mstrRegionTypeId = value.ToString();
 AddUpdatedFld(convCodeType_Sim.RegionTypeId);
}
else if (convCodeType_Sim.InUse  ==  _AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convCodeType_Sim.InUse);
}
else if (convCodeType_Sim.SqlDsTypeId  ==  _AttributeName[intIndex])
{
mstrSqlDsTypeId = value.ToString();
 AddUpdatedFld(convCodeType_Sim.SqlDsTypeId);
}
else if (convCodeType_Sim.IsDefaultOverride  ==  _AttributeName[intIndex])
{
mbolIsDefaultOverride = TransNullToBool(value.ToString());
 AddUpdatedFld(convCodeType_Sim.IsDefaultOverride);
}
else if (convCodeType_Sim.IsExtend  ==  _AttributeName[intIndex])
{
mbolIsExtend = TransNullToBool(value.ToString());
 AddUpdatedFld(convCodeType_Sim.IsExtend);
}
else if (convCodeType_Sim.IsAutoParseFile  ==  _AttributeName[intIndex])
{
mbolIsAutoParseFile = TransNullToBool(value.ToString());
 AddUpdatedFld(convCodeType_Sim.IsAutoParseFile);
}
else if (convCodeType_Sim.FileNameFormat  ==  _AttributeName[intIndex])
{
mstrFileNameFormat = value.ToString();
 AddUpdatedFld(convCodeType_Sim.FileNameFormat);
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
 AddUpdatedFld(convCodeType_Sim.CodeTypeId);
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
 AddUpdatedFld(convCodeType_Sim.CodeTypeName);
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
 AddUpdatedFld(convCodeType_Sim.CodeTypeENName);
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
 AddUpdatedFld(convCodeType_Sim.GroupName);
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
 AddUpdatedFld(convCodeType_Sim.DependsOn);
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
 AddUpdatedFld(convCodeType_Sim.FrontOrBack);
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
 AddUpdatedFld(convCodeType_Sim.OrderNum);
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
 AddUpdatedFld(convCodeType_Sim.ProgLangTypeId);
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
 AddUpdatedFld(convCodeType_Sim.Prefix);
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
 AddUpdatedFld(convCodeType_Sim.AppCount);
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
 AddUpdatedFld(convCodeType_Sim.FuncCount);
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
 AddUpdatedFld(convCodeType_Sim.ClassNameFormat);
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
 AddUpdatedFld(convCodeType_Sim.CodeTypeSimName);
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
 AddUpdatedFld(convCodeType_Sim.RegionTypeId);
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
 AddUpdatedFld(convCodeType_Sim.InUse);
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
 AddUpdatedFld(convCodeType_Sim.SqlDsTypeId);
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
 AddUpdatedFld(convCodeType_Sim.IsDefaultOverride);
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
 AddUpdatedFld(convCodeType_Sim.IsExtend);
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
 AddUpdatedFld(convCodeType_Sim.IsAutoParseFile);
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
 AddUpdatedFld(convCodeType_Sim.FileNameFormat);
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
 /// vCodeType_Sim(vCodeType_Sim)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convCodeType_Sim
{
public const string _CurrTabName = "vCodeType_Sim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CodeTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"CodeTypeId", "CodeTypeName", "CodeTypeENName", "GroupName", "DependsOn", "FrontOrBack", "OrderNum", "ProgLangTypeId", "Prefix", "AppCount", "FuncCount", "ClassNameFormat", "CodeTypeSimName", "RegionTypeId", "InUse", "SqlDsTypeId", "IsDefaultOverride", "IsExtend", "IsAutoParseFile", "FileNameFormat"};
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
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"ProgLangTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeId = "ProgLangTypeId";    //编程语言类型Id

 /// <summary>
 /// 常量:"Prefix"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Prefix = "Prefix";    //前缀

 /// <summary>
 /// 常量:"AppCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppCount = "AppCount";    //应用数

 /// <summary>
 /// 常量:"FuncCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncCount = "FuncCount";    //函数数目

 /// <summary>
 /// 常量:"ClassNameFormat"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClassNameFormat = "ClassNameFormat";    //类名格式

 /// <summary>
 /// 常量:"CodeTypeSimName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTypeSimName = "CodeTypeSimName";    //简称

 /// <summary>
 /// 常量:"RegionTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RegionTypeId = "RegionTypeId";    //区域类型Id

 /// <summary>
 /// 常量:"InUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InUse = "InUse";    //是否在用

 /// <summary>
 /// 常量:"SqlDsTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SqlDsTypeId = "SqlDsTypeId";    //数据源类型Id

 /// <summary>
 /// 常量:"IsDefaultOverride"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDefaultOverride = "IsDefaultOverride";    //是否默认覆盖

 /// <summary>
 /// 常量:"IsExtend"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsExtend = "IsExtend";    //是否扩展类

 /// <summary>
 /// 常量:"IsAutoParseFile"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsAutoParseFile = "IsAutoParseFile";    //是否自动分析文件

 /// <summary>
 /// 常量:"FileNameFormat"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileNameFormat = "FileNameFormat";    //文件名格式
}

}