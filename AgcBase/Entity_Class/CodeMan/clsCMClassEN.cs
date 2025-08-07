
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCMClassEN
 表名:CMClass(00050501)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:32:41
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:代码管理(CodeMan)
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
 /// 表CMClass的关键字(CmClassId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CmClassId_CMClass
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
public K_CmClassId_CMClass(string strCmClassId)
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
 /// <returns>返回:[K_CmClassId_CMClass]类型的对象</returns>
public static implicit operator K_CmClassId_CMClass(string value)
{
return new K_CmClassId_CMClass(value);
}
}
 /// <summary>
 /// CM类(CMClass)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCMClassEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CMClass"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "CmClassId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 18;
public static string[] _AttributeName = new string[] {"CmClassId", "ApplicationTypeId", "ProgLangTypeId", "TabName", "NameSpace", "ProjectPath", "FilePath", "FileName", "FileText", "FuncModuleAgcId", "CodeTypeId", "UserId", "PrjId", "IsOpen", "UpdDate", "UpdUser", "Memo", "ClsName"};

protected string mstrCmClassId;    //类Id
protected int mintApplicationTypeId;    //应用程序类型ID
protected string mstrProgLangTypeId;    //编程语言类型Id
protected string mstrTabName;    //表名
protected string mstrNameSpace;    //域名
protected string mstrProjectPath;    //工程路径
protected string mstrFilePath;    //文件路径
protected string mstrFileName;    //文件名
protected string mstrFileText;    //文件内容
protected string mstrFuncModuleAgcId;    //功能模块Id
protected string mstrCodeTypeId;    //代码类型Id
protected string mstrUserId;    //用户Id
protected string mstrPrjId;    //工程Id
protected bool mbolIsOpen;    //是否开放
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明
protected string mstrClsName;    //类名

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsCMClassEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CmClassId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strCmClassId">关键字:类Id</param>
public clsCMClassEN(string strCmClassId)
 {
strCmClassId = strCmClassId.Replace("'", "''");
if (strCmClassId.Length > 8)
{
throw new Exception("在表:CMClass中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strCmClassId)  ==  true)
{
throw new Exception("在表:CMClass中,关键字不能为空 或 null!");
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
return _AttributeCount;
}
}
public override object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  conCMClass.CmClassId)
{
return mstrCmClassId;
}
else if (strAttributeName  ==  conCMClass.ApplicationTypeId)
{
return mintApplicationTypeId;
}
else if (strAttributeName  ==  conCMClass.ProgLangTypeId)
{
return mstrProgLangTypeId;
}
else if (strAttributeName  ==  conCMClass.TabName)
{
return mstrTabName;
}
else if (strAttributeName  ==  conCMClass.NameSpace)
{
return mstrNameSpace;
}
else if (strAttributeName  ==  conCMClass.ProjectPath)
{
return mstrProjectPath;
}
else if (strAttributeName  ==  conCMClass.FilePath)
{
return mstrFilePath;
}
else if (strAttributeName  ==  conCMClass.FileName)
{
return mstrFileName;
}
else if (strAttributeName  ==  conCMClass.FileText)
{
return mstrFileText;
}
else if (strAttributeName  ==  conCMClass.FuncModuleAgcId)
{
return mstrFuncModuleAgcId;
}
else if (strAttributeName  ==  conCMClass.CodeTypeId)
{
return mstrCodeTypeId;
}
else if (strAttributeName  ==  conCMClass.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conCMClass.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conCMClass.IsOpen)
{
return mbolIsOpen;
}
else if (strAttributeName  ==  conCMClass.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conCMClass.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conCMClass.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conCMClass.ClsName)
{
return mstrClsName;
}
return null;
}
set
{
if (strAttributeName  ==  conCMClass.CmClassId)
{
mstrCmClassId = value.ToString();
 AddUpdatedFld(conCMClass.CmClassId);
}
else if (strAttributeName  ==  conCMClass.ApplicationTypeId)
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conCMClass.ApplicationTypeId);
}
else if (strAttributeName  ==  conCMClass.ProgLangTypeId)
{
mstrProgLangTypeId = value.ToString();
 AddUpdatedFld(conCMClass.ProgLangTypeId);
}
else if (strAttributeName  ==  conCMClass.TabName)
{
mstrTabName = value.ToString();
 AddUpdatedFld(conCMClass.TabName);
}
else if (strAttributeName  ==  conCMClass.NameSpace)
{
mstrNameSpace = value.ToString();
 AddUpdatedFld(conCMClass.NameSpace);
}
else if (strAttributeName  ==  conCMClass.ProjectPath)
{
mstrProjectPath = value.ToString();
 AddUpdatedFld(conCMClass.ProjectPath);
}
else if (strAttributeName  ==  conCMClass.FilePath)
{
mstrFilePath = value.ToString();
 AddUpdatedFld(conCMClass.FilePath);
}
else if (strAttributeName  ==  conCMClass.FileName)
{
mstrFileName = value.ToString();
 AddUpdatedFld(conCMClass.FileName);
}
else if (strAttributeName  ==  conCMClass.FileText)
{
mstrFileText = value.ToString();
 AddUpdatedFld(conCMClass.FileText);
}
else if (strAttributeName  ==  conCMClass.FuncModuleAgcId)
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(conCMClass.FuncModuleAgcId);
}
else if (strAttributeName  ==  conCMClass.CodeTypeId)
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(conCMClass.CodeTypeId);
}
else if (strAttributeName  ==  conCMClass.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conCMClass.UserId);
}
else if (strAttributeName  ==  conCMClass.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conCMClass.PrjId);
}
else if (strAttributeName  ==  conCMClass.IsOpen)
{
mbolIsOpen = TransNullToBool(value.ToString());
 AddUpdatedFld(conCMClass.IsOpen);
}
else if (strAttributeName  ==  conCMClass.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCMClass.UpdDate);
}
else if (strAttributeName  ==  conCMClass.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conCMClass.UpdUser);
}
else if (strAttributeName  ==  conCMClass.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCMClass.Memo);
}
else if (strAttributeName  ==  conCMClass.ClsName)
{
mstrClsName = value.ToString();
 AddUpdatedFld(conCMClass.ClsName);
}
}
}
public object this[int intIndex]
{
get
{
if (conCMClass.CmClassId  ==  _AttributeName[intIndex])
{
return mstrCmClassId;
}
else if (conCMClass.ApplicationTypeId  ==  _AttributeName[intIndex])
{
return mintApplicationTypeId;
}
else if (conCMClass.ProgLangTypeId  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeId;
}
else if (conCMClass.TabName  ==  _AttributeName[intIndex])
{
return mstrTabName;
}
else if (conCMClass.NameSpace  ==  _AttributeName[intIndex])
{
return mstrNameSpace;
}
else if (conCMClass.ProjectPath  ==  _AttributeName[intIndex])
{
return mstrProjectPath;
}
else if (conCMClass.FilePath  ==  _AttributeName[intIndex])
{
return mstrFilePath;
}
else if (conCMClass.FileName  ==  _AttributeName[intIndex])
{
return mstrFileName;
}
else if (conCMClass.FileText  ==  _AttributeName[intIndex])
{
return mstrFileText;
}
else if (conCMClass.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
return mstrFuncModuleAgcId;
}
else if (conCMClass.CodeTypeId  ==  _AttributeName[intIndex])
{
return mstrCodeTypeId;
}
else if (conCMClass.UserId  ==  _AttributeName[intIndex])
{
return mstrUserId;
}
else if (conCMClass.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conCMClass.IsOpen  ==  _AttributeName[intIndex])
{
return mbolIsOpen;
}
else if (conCMClass.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conCMClass.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conCMClass.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (conCMClass.ClsName  ==  _AttributeName[intIndex])
{
return mstrClsName;
}
return null;
}
set
{
if (conCMClass.CmClassId  ==  _AttributeName[intIndex])
{
mstrCmClassId = value.ToString();
 AddUpdatedFld(conCMClass.CmClassId);
}
else if (conCMClass.ApplicationTypeId  ==  _AttributeName[intIndex])
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conCMClass.ApplicationTypeId);
}
else if (conCMClass.ProgLangTypeId  ==  _AttributeName[intIndex])
{
mstrProgLangTypeId = value.ToString();
 AddUpdatedFld(conCMClass.ProgLangTypeId);
}
else if (conCMClass.TabName  ==  _AttributeName[intIndex])
{
mstrTabName = value.ToString();
 AddUpdatedFld(conCMClass.TabName);
}
else if (conCMClass.NameSpace  ==  _AttributeName[intIndex])
{
mstrNameSpace = value.ToString();
 AddUpdatedFld(conCMClass.NameSpace);
}
else if (conCMClass.ProjectPath  ==  _AttributeName[intIndex])
{
mstrProjectPath = value.ToString();
 AddUpdatedFld(conCMClass.ProjectPath);
}
else if (conCMClass.FilePath  ==  _AttributeName[intIndex])
{
mstrFilePath = value.ToString();
 AddUpdatedFld(conCMClass.FilePath);
}
else if (conCMClass.FileName  ==  _AttributeName[intIndex])
{
mstrFileName = value.ToString();
 AddUpdatedFld(conCMClass.FileName);
}
else if (conCMClass.FileText  ==  _AttributeName[intIndex])
{
mstrFileText = value.ToString();
 AddUpdatedFld(conCMClass.FileText);
}
else if (conCMClass.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(conCMClass.FuncModuleAgcId);
}
else if (conCMClass.CodeTypeId  ==  _AttributeName[intIndex])
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(conCMClass.CodeTypeId);
}
else if (conCMClass.UserId  ==  _AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conCMClass.UserId);
}
else if (conCMClass.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conCMClass.PrjId);
}
else if (conCMClass.IsOpen  ==  _AttributeName[intIndex])
{
mbolIsOpen = TransNullToBool(value.ToString());
 AddUpdatedFld(conCMClass.IsOpen);
}
else if (conCMClass.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCMClass.UpdDate);
}
else if (conCMClass.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conCMClass.UpdUser);
}
else if (conCMClass.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCMClass.Memo);
}
else if (conCMClass.ClsName  ==  _AttributeName[intIndex])
{
mstrClsName = value.ToString();
 AddUpdatedFld(conCMClass.ClsName);
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
 AddUpdatedFld(conCMClass.CmClassId);
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
 AddUpdatedFld(conCMClass.ApplicationTypeId);
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
 AddUpdatedFld(conCMClass.ProgLangTypeId);
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
 AddUpdatedFld(conCMClass.TabName);
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
 AddUpdatedFld(conCMClass.NameSpace);
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
 AddUpdatedFld(conCMClass.ProjectPath);
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
 AddUpdatedFld(conCMClass.FilePath);
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
 AddUpdatedFld(conCMClass.FileName);
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
 AddUpdatedFld(conCMClass.FileText);
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
 AddUpdatedFld(conCMClass.FuncModuleAgcId);
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
 AddUpdatedFld(conCMClass.CodeTypeId);
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
 AddUpdatedFld(conCMClass.UserId);
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
 AddUpdatedFld(conCMClass.PrjId);
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
 AddUpdatedFld(conCMClass.IsOpen);
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
 AddUpdatedFld(conCMClass.UpdDate);
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
 AddUpdatedFld(conCMClass.UpdUser);
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
 AddUpdatedFld(conCMClass.Memo);
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
 AddUpdatedFld(conCMClass.ClsName);
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
  return mstrCmClassId;
 }
 }
}
 /// <summary>
 /// CM类(CMClass)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCMClass
{
public const string _CurrTabName = "CMClass"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CmClassId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"CmClassId", "ApplicationTypeId", "ProgLangTypeId", "TabName", "NameSpace", "ProjectPath", "FilePath", "FileName", "FileText", "FuncModuleAgcId", "CodeTypeId", "UserId", "PrjId", "IsOpen", "UpdDate", "UpdUser", "Memo", "ClsName"};
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
 /// 常量:"ProgLangTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeId = "ProgLangTypeId";    //编程语言类型Id

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
 /// 常量:"CodeTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTypeId = "CodeTypeId";    //代码类型Id

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户Id

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

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
 /// 常量:"ClsName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClsName = "ClsName";    //类名
}

}