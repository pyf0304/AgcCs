
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCMClassEN
 表名:vCMClass(00050506)
 * 版本:2024.01.24.1(服务器:WIN-SRV103-116)
 日期:2024/01/26 16:18:02
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:代码管理(CodeMan)
 框架-层名:实体层(CS)(EntityLayer)
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

namespace AGC.Entity
{
 /// <summary>
 /// 表vCMClass的关键字(CmClassId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CmClassId_vCMClass
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strCmClassId">表关键字</param>
public K_CmClassId_vCMClass(string strCmClassId)
{
if (IsValid(strCmClassId)) Value = strCmClassId;
else
{
Value = null;
}
}
private static bool IsValid(string strCmClassId)
{
if (string.IsNullOrEmpty(strCmClassId) == true) return false;
if (strCmClassId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_CmClassId_vCMClass]类型的对象</returns>
public static implicit operator K_CmClassId_vCMClass(string value)
{
return new K_CmClassId_vCMClass(value);
}
}
 /// <summary>
 /// vCM类(vCMClass)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvCMClassEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vCMClass"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "CmClassId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 28;
public static string[] AttributeName = new string[] {"CmClassId", "ApplicationTypeId", "ApplicationTypeName", "ApplicationTypeSimName", "ProgLangTypeId", "ProgLangTypeName", "ProgLangTypeSimName", "TabName", "NameSpace", "ProjectPath", "FilePath", "FileName", "FileText", "FuncModuleAgcId", "FuncModuleName", "FuncModuleNameSim", "CodeTypeId", "CodeTypeName", "CodeTypeSimName", "UserId", "PrjId", "PrjName", "IsOpen", "UpdDate", "UpdUser", "Memo", "FuncNum", "ClsName"};

protected string mstrCmClassId;    //类Id
protected int mintApplicationTypeId;    //应用程序类型ID
protected string mstrApplicationTypeName;    //应用程序类型名称
protected string mstrApplicationTypeSimName;    //应用程序类型简称
protected string mstrProgLangTypeId;    //编程语言类型Id
protected string mstrProgLangTypeName;    //编程语言类型名
protected string mstrProgLangTypeSimName;    //编程语言类型简称
protected string mstrTabName;    //表名
protected string mstrNameSpace;    //域名
protected string mstrProjectPath;    //工程路径
protected string mstrFilePath;    //文件路径
protected string mstrFileName;    //文件名
protected string mstrFileText;    //文件内容
protected string mstrFuncModuleAgcId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrFuncModuleNameSim;    //功能模块简称
protected string mstrCodeTypeId;    //代码类型Id
protected string mstrCodeTypeName;    //代码类型名
protected string mstrCodeTypeSimName;    //简称
protected string mstrUserId;    //用户Id
protected string mstrPrjId;    //工程ID
protected string mstrPrjName;    //工程名称
protected bool mbolIsOpen;    //是否开放
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明
protected int? mintFuncNum;    //函数个数
protected string mstrClsName;    //类名

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvCMClassEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CmClassId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strCmClassId">关键字:类Id</param>
public clsvCMClassEN(string strCmClassId)
 {
strCmClassId = strCmClassId.Replace("'", "''");
if (strCmClassId.Length > 8)
{
throw new Exception("在表:vCMClass中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strCmClassId)  ==  true)
{
throw new Exception("在表:vCMClass中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCmClassId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrCmClassId = strCmClassId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CmClassId");
 }

public static int AttributeCount
{
get
{
return mintAttributeCount;
}
}
public override object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  convCMClass.CmClassId)
{
return mstrCmClassId;
}
else if (strAttributeName  ==  convCMClass.ApplicationTypeId)
{
return mintApplicationTypeId;
}
else if (strAttributeName  ==  convCMClass.ApplicationTypeName)
{
return mstrApplicationTypeName;
}
else if (strAttributeName  ==  convCMClass.ApplicationTypeSimName)
{
return mstrApplicationTypeSimName;
}
else if (strAttributeName  ==  convCMClass.ProgLangTypeId)
{
return mstrProgLangTypeId;
}
else if (strAttributeName  ==  convCMClass.ProgLangTypeName)
{
return mstrProgLangTypeName;
}
else if (strAttributeName  ==  convCMClass.ProgLangTypeSimName)
{
return mstrProgLangTypeSimName;
}
else if (strAttributeName  ==  convCMClass.TabName)
{
return mstrTabName;
}
else if (strAttributeName  ==  convCMClass.NameSpace)
{
return mstrNameSpace;
}
else if (strAttributeName  ==  convCMClass.ProjectPath)
{
return mstrProjectPath;
}
else if (strAttributeName  ==  convCMClass.FilePath)
{
return mstrFilePath;
}
else if (strAttributeName  ==  convCMClass.FileName)
{
return mstrFileName;
}
else if (strAttributeName  ==  convCMClass.FileText)
{
return mstrFileText;
}
else if (strAttributeName  ==  convCMClass.FuncModuleAgcId)
{
return mstrFuncModuleAgcId;
}
else if (strAttributeName  ==  convCMClass.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convCMClass.FuncModuleNameSim)
{
return mstrFuncModuleNameSim;
}
else if (strAttributeName  ==  convCMClass.CodeTypeId)
{
return mstrCodeTypeId;
}
else if (strAttributeName  ==  convCMClass.CodeTypeName)
{
return mstrCodeTypeName;
}
else if (strAttributeName  ==  convCMClass.CodeTypeSimName)
{
return mstrCodeTypeSimName;
}
else if (strAttributeName  ==  convCMClass.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convCMClass.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convCMClass.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convCMClass.IsOpen)
{
return mbolIsOpen;
}
else if (strAttributeName  ==  convCMClass.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convCMClass.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convCMClass.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convCMClass.FuncNum)
{
return mintFuncNum;
}
else if (strAttributeName  ==  convCMClass.ClsName)
{
return mstrClsName;
}
return null;
}
set
{
if (strAttributeName  ==  convCMClass.CmClassId)
{
mstrCmClassId = value.ToString();
 AddUpdatedFld(convCMClass.CmClassId);
}
else if (strAttributeName  ==  convCMClass.ApplicationTypeId)
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMClass.ApplicationTypeId);
}
else if (strAttributeName  ==  convCMClass.ApplicationTypeName)
{
mstrApplicationTypeName = value.ToString();
 AddUpdatedFld(convCMClass.ApplicationTypeName);
}
else if (strAttributeName  ==  convCMClass.ApplicationTypeSimName)
{
mstrApplicationTypeSimName = value.ToString();
 AddUpdatedFld(convCMClass.ApplicationTypeSimName);
}
else if (strAttributeName  ==  convCMClass.ProgLangTypeId)
{
mstrProgLangTypeId = value.ToString();
 AddUpdatedFld(convCMClass.ProgLangTypeId);
}
else if (strAttributeName  ==  convCMClass.ProgLangTypeName)
{
mstrProgLangTypeName = value.ToString();
 AddUpdatedFld(convCMClass.ProgLangTypeName);
}
else if (strAttributeName  ==  convCMClass.ProgLangTypeSimName)
{
mstrProgLangTypeSimName = value.ToString();
 AddUpdatedFld(convCMClass.ProgLangTypeSimName);
}
else if (strAttributeName  ==  convCMClass.TabName)
{
mstrTabName = value.ToString();
 AddUpdatedFld(convCMClass.TabName);
}
else if (strAttributeName  ==  convCMClass.NameSpace)
{
mstrNameSpace = value.ToString();
 AddUpdatedFld(convCMClass.NameSpace);
}
else if (strAttributeName  ==  convCMClass.ProjectPath)
{
mstrProjectPath = value.ToString();
 AddUpdatedFld(convCMClass.ProjectPath);
}
else if (strAttributeName  ==  convCMClass.FilePath)
{
mstrFilePath = value.ToString();
 AddUpdatedFld(convCMClass.FilePath);
}
else if (strAttributeName  ==  convCMClass.FileName)
{
mstrFileName = value.ToString();
 AddUpdatedFld(convCMClass.FileName);
}
else if (strAttributeName  ==  convCMClass.FileText)
{
mstrFileText = value.ToString();
 AddUpdatedFld(convCMClass.FileText);
}
else if (strAttributeName  ==  convCMClass.FuncModuleAgcId)
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convCMClass.FuncModuleAgcId);
}
else if (strAttributeName  ==  convCMClass.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convCMClass.FuncModuleName);
}
else if (strAttributeName  ==  convCMClass.FuncModuleNameSim)
{
mstrFuncModuleNameSim = value.ToString();
 AddUpdatedFld(convCMClass.FuncModuleNameSim);
}
else if (strAttributeName  ==  convCMClass.CodeTypeId)
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(convCMClass.CodeTypeId);
}
else if (strAttributeName  ==  convCMClass.CodeTypeName)
{
mstrCodeTypeName = value.ToString();
 AddUpdatedFld(convCMClass.CodeTypeName);
}
else if (strAttributeName  ==  convCMClass.CodeTypeSimName)
{
mstrCodeTypeSimName = value.ToString();
 AddUpdatedFld(convCMClass.CodeTypeSimName);
}
else if (strAttributeName  ==  convCMClass.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convCMClass.UserId);
}
else if (strAttributeName  ==  convCMClass.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convCMClass.PrjId);
}
else if (strAttributeName  ==  convCMClass.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convCMClass.PrjName);
}
else if (strAttributeName  ==  convCMClass.IsOpen)
{
mbolIsOpen = TransNullToBool(value.ToString());
 AddUpdatedFld(convCMClass.IsOpen);
}
else if (strAttributeName  ==  convCMClass.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convCMClass.UpdDate);
}
else if (strAttributeName  ==  convCMClass.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convCMClass.UpdUser);
}
else if (strAttributeName  ==  convCMClass.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCMClass.Memo);
}
else if (strAttributeName  ==  convCMClass.FuncNum)
{
mintFuncNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMClass.FuncNum);
}
else if (strAttributeName  ==  convCMClass.ClsName)
{
mstrClsName = value.ToString();
 AddUpdatedFld(convCMClass.ClsName);
}
}
}
public object this[int intIndex]
{
get
{
if (convCMClass.CmClassId  ==  AttributeName[intIndex])
{
return mstrCmClassId;
}
else if (convCMClass.ApplicationTypeId  ==  AttributeName[intIndex])
{
return mintApplicationTypeId;
}
else if (convCMClass.ApplicationTypeName  ==  AttributeName[intIndex])
{
return mstrApplicationTypeName;
}
else if (convCMClass.ApplicationTypeSimName  ==  AttributeName[intIndex])
{
return mstrApplicationTypeSimName;
}
else if (convCMClass.ProgLangTypeId  ==  AttributeName[intIndex])
{
return mstrProgLangTypeId;
}
else if (convCMClass.ProgLangTypeName  ==  AttributeName[intIndex])
{
return mstrProgLangTypeName;
}
else if (convCMClass.ProgLangTypeSimName  ==  AttributeName[intIndex])
{
return mstrProgLangTypeSimName;
}
else if (convCMClass.TabName  ==  AttributeName[intIndex])
{
return mstrTabName;
}
else if (convCMClass.NameSpace  ==  AttributeName[intIndex])
{
return mstrNameSpace;
}
else if (convCMClass.ProjectPath  ==  AttributeName[intIndex])
{
return mstrProjectPath;
}
else if (convCMClass.FilePath  ==  AttributeName[intIndex])
{
return mstrFilePath;
}
else if (convCMClass.FileName  ==  AttributeName[intIndex])
{
return mstrFileName;
}
else if (convCMClass.FileText  ==  AttributeName[intIndex])
{
return mstrFileText;
}
else if (convCMClass.FuncModuleAgcId  ==  AttributeName[intIndex])
{
return mstrFuncModuleAgcId;
}
else if (convCMClass.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convCMClass.FuncModuleNameSim  ==  AttributeName[intIndex])
{
return mstrFuncModuleNameSim;
}
else if (convCMClass.CodeTypeId  ==  AttributeName[intIndex])
{
return mstrCodeTypeId;
}
else if (convCMClass.CodeTypeName  ==  AttributeName[intIndex])
{
return mstrCodeTypeName;
}
else if (convCMClass.CodeTypeSimName  ==  AttributeName[intIndex])
{
return mstrCodeTypeSimName;
}
else if (convCMClass.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convCMClass.PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convCMClass.PrjName  ==  AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convCMClass.IsOpen  ==  AttributeName[intIndex])
{
return mbolIsOpen;
}
else if (convCMClass.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convCMClass.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convCMClass.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convCMClass.FuncNum  ==  AttributeName[intIndex])
{
return mintFuncNum;
}
else if (convCMClass.ClsName  ==  AttributeName[intIndex])
{
return mstrClsName;
}
return null;
}
set
{
if (convCMClass.CmClassId  ==  AttributeName[intIndex])
{
mstrCmClassId = value.ToString();
 AddUpdatedFld(convCMClass.CmClassId);
}
else if (convCMClass.ApplicationTypeId  ==  AttributeName[intIndex])
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMClass.ApplicationTypeId);
}
else if (convCMClass.ApplicationTypeName  ==  AttributeName[intIndex])
{
mstrApplicationTypeName = value.ToString();
 AddUpdatedFld(convCMClass.ApplicationTypeName);
}
else if (convCMClass.ApplicationTypeSimName  ==  AttributeName[intIndex])
{
mstrApplicationTypeSimName = value.ToString();
 AddUpdatedFld(convCMClass.ApplicationTypeSimName);
}
else if (convCMClass.ProgLangTypeId  ==  AttributeName[intIndex])
{
mstrProgLangTypeId = value.ToString();
 AddUpdatedFld(convCMClass.ProgLangTypeId);
}
else if (convCMClass.ProgLangTypeName  ==  AttributeName[intIndex])
{
mstrProgLangTypeName = value.ToString();
 AddUpdatedFld(convCMClass.ProgLangTypeName);
}
else if (convCMClass.ProgLangTypeSimName  ==  AttributeName[intIndex])
{
mstrProgLangTypeSimName = value.ToString();
 AddUpdatedFld(convCMClass.ProgLangTypeSimName);
}
else if (convCMClass.TabName  ==  AttributeName[intIndex])
{
mstrTabName = value.ToString();
 AddUpdatedFld(convCMClass.TabName);
}
else if (convCMClass.NameSpace  ==  AttributeName[intIndex])
{
mstrNameSpace = value.ToString();
 AddUpdatedFld(convCMClass.NameSpace);
}
else if (convCMClass.ProjectPath  ==  AttributeName[intIndex])
{
mstrProjectPath = value.ToString();
 AddUpdatedFld(convCMClass.ProjectPath);
}
else if (convCMClass.FilePath  ==  AttributeName[intIndex])
{
mstrFilePath = value.ToString();
 AddUpdatedFld(convCMClass.FilePath);
}
else if (convCMClass.FileName  ==  AttributeName[intIndex])
{
mstrFileName = value.ToString();
 AddUpdatedFld(convCMClass.FileName);
}
else if (convCMClass.FileText  ==  AttributeName[intIndex])
{
mstrFileText = value.ToString();
 AddUpdatedFld(convCMClass.FileText);
}
else if (convCMClass.FuncModuleAgcId  ==  AttributeName[intIndex])
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convCMClass.FuncModuleAgcId);
}
else if (convCMClass.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convCMClass.FuncModuleName);
}
else if (convCMClass.FuncModuleNameSim  ==  AttributeName[intIndex])
{
mstrFuncModuleNameSim = value.ToString();
 AddUpdatedFld(convCMClass.FuncModuleNameSim);
}
else if (convCMClass.CodeTypeId  ==  AttributeName[intIndex])
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(convCMClass.CodeTypeId);
}
else if (convCMClass.CodeTypeName  ==  AttributeName[intIndex])
{
mstrCodeTypeName = value.ToString();
 AddUpdatedFld(convCMClass.CodeTypeName);
}
else if (convCMClass.CodeTypeSimName  ==  AttributeName[intIndex])
{
mstrCodeTypeSimName = value.ToString();
 AddUpdatedFld(convCMClass.CodeTypeSimName);
}
else if (convCMClass.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convCMClass.UserId);
}
else if (convCMClass.PrjId  ==  AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convCMClass.PrjId);
}
else if (convCMClass.PrjName  ==  AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convCMClass.PrjName);
}
else if (convCMClass.IsOpen  ==  AttributeName[intIndex])
{
mbolIsOpen = TransNullToBool(value.ToString());
 AddUpdatedFld(convCMClass.IsOpen);
}
else if (convCMClass.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convCMClass.UpdDate);
}
else if (convCMClass.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convCMClass.UpdUser);
}
else if (convCMClass.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCMClass.Memo);
}
else if (convCMClass.FuncNum  ==  AttributeName[intIndex])
{
mintFuncNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMClass.FuncNum);
}
else if (convCMClass.ClsName  ==  AttributeName[intIndex])
{
mstrClsName = value.ToString();
 AddUpdatedFld(convCMClass.ClsName);
}
}
}

/// <summary>
/// 类Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CmClassId
{
get
{
return mstrCmClassId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCmClassId = value;
}
else
{
 mstrCmClassId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMClass.CmClassId);
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
 AddUpdatedFld(convCMClass.ApplicationTypeId);
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
 AddUpdatedFld(convCMClass.ApplicationTypeName);
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
 AddUpdatedFld(convCMClass.ApplicationTypeSimName);
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
 AddUpdatedFld(convCMClass.ProgLangTypeId);
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
 AddUpdatedFld(convCMClass.ProgLangTypeName);
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
 AddUpdatedFld(convCMClass.ProgLangTypeSimName);
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
 AddUpdatedFld(convCMClass.TabName);
}
}
/// <summary>
/// 域名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string NameSpace
{
get
{
return mstrNameSpace;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrNameSpace = value;
}
else
{
 mstrNameSpace = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMClass.NameSpace);
}
}
/// <summary>
/// 工程路径(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProjectPath
{
get
{
return mstrProjectPath;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProjectPath = value;
}
else
{
 mstrProjectPath = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMClass.ProjectPath);
}
}
/// <summary>
/// 文件路径(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FilePath
{
get
{
return mstrFilePath;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFilePath = value;
}
else
{
 mstrFilePath = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMClass.FilePath);
}
}
/// <summary>
/// 文件名(说明:;字段类型:varchar;字段长度:150;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FileName
{
get
{
return mstrFileName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFileName = value;
}
else
{
 mstrFileName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMClass.FileName);
}
}
/// <summary>
/// 文件内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FileText
{
get
{
return mstrFileText;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFileText = value;
}
else
{
 mstrFileText = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMClass.FileText);
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
 AddUpdatedFld(convCMClass.FuncModuleAgcId);
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
 AddUpdatedFld(convCMClass.FuncModuleName);
}
}
/// <summary>
/// 功能模块简称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleNameSim
{
get
{
return mstrFuncModuleNameSim;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleNameSim = value;
}
else
{
 mstrFuncModuleNameSim = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMClass.FuncModuleNameSim);
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
 AddUpdatedFld(convCMClass.CodeTypeId);
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
 AddUpdatedFld(convCMClass.CodeTypeName);
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
 AddUpdatedFld(convCMClass.CodeTypeSimName);
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
 AddUpdatedFld(convCMClass.UserId);
}
}
/// <summary>
/// 工程ID(说明:;字段类型:char;字段长度:4;是否可空:False)
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
 AddUpdatedFld(convCMClass.PrjId);
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
 AddUpdatedFld(convCMClass.PrjName);
}
}
/// <summary>
/// 是否开放(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsOpen
{
get
{
return mbolIsOpen;
}
set
{
 mbolIsOpen = value;
//记录修改过的字段
 AddUpdatedFld(convCMClass.IsOpen);
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
 AddUpdatedFld(convCMClass.UpdDate);
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
 AddUpdatedFld(convCMClass.UpdUser);
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
 AddUpdatedFld(convCMClass.Memo);
}
}
/// <summary>
/// 函数个数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? FuncNum
{
get
{
return mintFuncNum;
}
set
{
 mintFuncNum = value;
//记录修改过的字段
 AddUpdatedFld(convCMClass.FuncNum);
}
}
/// <summary>
/// 类名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClsName
{
get
{
return mstrClsName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClsName = value;
}
else
{
 mstrClsName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMClass.ClsName);
}
}

/// <summary>
/// 获取关键字Id(keyId)
 /// (AutoGCLib.clsGeneCodeBase:GenGetKeyId)
/// </summary>
 public override string _KeyId
 {
 get
 {
  return mstrCmClassId;
 }
 }

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrUserId;
 }
 }
}
 /// <summary>
 /// vCM类(vCMClass)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convCMClass
{
public const string _CurrTabName = "vCMClass"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CmClassId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"CmClassId", "ApplicationTypeId", "ApplicationTypeName", "ApplicationTypeSimName", "ProgLangTypeId", "ProgLangTypeName", "ProgLangTypeSimName", "TabName", "NameSpace", "ProjectPath", "FilePath", "FileName", "FileText", "FuncModuleAgcId", "FuncModuleName", "FuncModuleNameSim", "CodeTypeId", "CodeTypeName", "CodeTypeSimName", "UserId", "PrjId", "PrjName", "IsOpen", "UpdDate", "UpdUser", "Memo", "FuncNum", "ClsName"};
//以下是属性变量


 /// <summary>
 /// 常量:"CmClassId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CmClassId = "CmClassId";    //类Id

 /// <summary>
 /// 常量:"ApplicationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeId = "ApplicationTypeId";    //应用程序类型ID

 /// <summary>
 /// 常量:"ApplicationTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeName = "ApplicationTypeName";    //应用程序类型名称

 /// <summary>
 /// 常量:"ApplicationTypeSimName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeSimName = "ApplicationTypeSimName";    //应用程序类型简称

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
 /// 常量:"TabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabName = "TabName";    //表名

 /// <summary>
 /// 常量:"NameSpace"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string NameSpace = "NameSpace";    //域名

 /// <summary>
 /// 常量:"ProjectPath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProjectPath = "ProjectPath";    //工程路径

 /// <summary>
 /// 常量:"FilePath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FilePath = "FilePath";    //文件路径

 /// <summary>
 /// 常量:"FileName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileName = "FileName";    //文件名

 /// <summary>
 /// 常量:"FileText"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileText = "FileText";    //文件内容

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
 /// 常量:"FuncModuleNameSim"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleNameSim = "FuncModuleNameSim";    //功能模块简称

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
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户Id

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程ID

 /// <summary>
 /// 常量:"PrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjName = "PrjName";    //工程名称

 /// <summary>
 /// 常量:"IsOpen"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsOpen = "IsOpen";    //是否开放

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
 /// 常量:"FuncNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncNum = "FuncNum";    //函数个数

 /// <summary>
 /// 常量:"ClsName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClsName = "ClsName";    //类名
}

}