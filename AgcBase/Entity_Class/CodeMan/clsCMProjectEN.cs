
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCMProjectEN
 表名:CMProject(00050512)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:31:44
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
 /// 表CMProject的关键字(CmPrjId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CmPrjId_CMProject
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strCmPrjId">表关键字</param>
public K_CmPrjId_CMProject(string strCmPrjId)
{
if (IsValid(strCmPrjId)) Value = strCmPrjId;
else
{
Value = null;
}
}
private static bool IsValid(string strCmPrjId)
{
if (string.IsNullOrEmpty(strCmPrjId) == true) return false;
if (strCmPrjId.Length != 6) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_CmPrjId_CMProject]类型的对象</returns>
public static implicit operator K_CmPrjId_CMProject(string value)
{
return new K_CmPrjId_CMProject(value);
}
}
 /// <summary>
 /// CM项目(CMProject)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCMProjectEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CMProject"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "CmPrjId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 14;
public static string[] _AttributeName = new string[] {"CmPrjId", "CmPrjName", "PrjId", "ApplicationTypeId", "FunctionTemplateId", "VueDesignSysId", "IsFstLcase", "IsCamelCase", "ProjectFileName", "UseStateId", "IsRefresh4RelaView", "UpdDate", "UpdUserId", "Memo"};

protected string mstrCmPrjId;    //Cm工程Id
protected string mstrCmPrjName;    //CM工程名
protected string mstrPrjId;    //工程Id
protected int mintApplicationTypeId;    //应用程序类型ID
protected string mstrFunctionTemplateId;    //函数模板Id
protected string mstrVueDesignSysId;    //Vue控件设计体系Id
protected bool mbolIsFstLcase;    //是否首字母小写
protected bool mbolIsCamelCase;    //是否使用CamelCase
protected string mstrProjectFileName;    //工程文件名
protected string mstrUseStateId;    //使用状态Id
protected bool mbolIsRefresh4RelaView;    //是否刷新相关视图
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsCMProjectEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CmPrjId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strCmPrjId">关键字:Cm工程Id</param>
public clsCMProjectEN(string strCmPrjId)
 {
strCmPrjId = strCmPrjId.Replace("'", "''");
if (strCmPrjId.Length > 6)
{
throw new Exception("在表:CMProject中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strCmPrjId)  ==  true)
{
throw new Exception("在表:CMProject中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCmPrjId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrCmPrjId = strCmPrjId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CmPrjId");
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
if (strAttributeName  ==  conCMProject.CmPrjId)
{
return mstrCmPrjId;
}
else if (strAttributeName  ==  conCMProject.CmPrjName)
{
return mstrCmPrjName;
}
else if (strAttributeName  ==  conCMProject.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conCMProject.ApplicationTypeId)
{
return mintApplicationTypeId;
}
else if (strAttributeName  ==  conCMProject.FunctionTemplateId)
{
return mstrFunctionTemplateId;
}
else if (strAttributeName  ==  conCMProject.VueDesignSysId)
{
return mstrVueDesignSysId;
}
else if (strAttributeName  ==  conCMProject.IsFstLcase)
{
return mbolIsFstLcase;
}
else if (strAttributeName  ==  conCMProject.IsCamelCase)
{
return mbolIsCamelCase;
}
else if (strAttributeName  ==  conCMProject.ProjectFileName)
{
return mstrProjectFileName;
}
else if (strAttributeName  ==  conCMProject.UseStateId)
{
return mstrUseStateId;
}
else if (strAttributeName  ==  conCMProject.IsRefresh4RelaView)
{
return mbolIsRefresh4RelaView;
}
else if (strAttributeName  ==  conCMProject.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conCMProject.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conCMProject.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conCMProject.CmPrjId)
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(conCMProject.CmPrjId);
}
else if (strAttributeName  ==  conCMProject.CmPrjName)
{
mstrCmPrjName = value.ToString();
 AddUpdatedFld(conCMProject.CmPrjName);
}
else if (strAttributeName  ==  conCMProject.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conCMProject.PrjId);
}
else if (strAttributeName  ==  conCMProject.ApplicationTypeId)
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conCMProject.ApplicationTypeId);
}
else if (strAttributeName  ==  conCMProject.FunctionTemplateId)
{
mstrFunctionTemplateId = value.ToString();
 AddUpdatedFld(conCMProject.FunctionTemplateId);
}
else if (strAttributeName  ==  conCMProject.VueDesignSysId)
{
mstrVueDesignSysId = value.ToString();
 AddUpdatedFld(conCMProject.VueDesignSysId);
}
else if (strAttributeName  ==  conCMProject.IsFstLcase)
{
mbolIsFstLcase = TransNullToBool(value.ToString());
 AddUpdatedFld(conCMProject.IsFstLcase);
}
else if (strAttributeName  ==  conCMProject.IsCamelCase)
{
mbolIsCamelCase = TransNullToBool(value.ToString());
 AddUpdatedFld(conCMProject.IsCamelCase);
}
else if (strAttributeName  ==  conCMProject.ProjectFileName)
{
mstrProjectFileName = value.ToString();
 AddUpdatedFld(conCMProject.ProjectFileName);
}
else if (strAttributeName  ==  conCMProject.UseStateId)
{
mstrUseStateId = value.ToString();
 AddUpdatedFld(conCMProject.UseStateId);
}
else if (strAttributeName  ==  conCMProject.IsRefresh4RelaView)
{
mbolIsRefresh4RelaView = TransNullToBool(value.ToString());
 AddUpdatedFld(conCMProject.IsRefresh4RelaView);
}
else if (strAttributeName  ==  conCMProject.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCMProject.UpdDate);
}
else if (strAttributeName  ==  conCMProject.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conCMProject.UpdUserId);
}
else if (strAttributeName  ==  conCMProject.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCMProject.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conCMProject.CmPrjId  ==  _AttributeName[intIndex])
{
return mstrCmPrjId;
}
else if (conCMProject.CmPrjName  ==  _AttributeName[intIndex])
{
return mstrCmPrjName;
}
else if (conCMProject.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conCMProject.ApplicationTypeId  ==  _AttributeName[intIndex])
{
return mintApplicationTypeId;
}
else if (conCMProject.FunctionTemplateId  ==  _AttributeName[intIndex])
{
return mstrFunctionTemplateId;
}
else if (conCMProject.VueDesignSysId  ==  _AttributeName[intIndex])
{
return mstrVueDesignSysId;
}
else if (conCMProject.IsFstLcase  ==  _AttributeName[intIndex])
{
return mbolIsFstLcase;
}
else if (conCMProject.IsCamelCase  ==  _AttributeName[intIndex])
{
return mbolIsCamelCase;
}
else if (conCMProject.ProjectFileName  ==  _AttributeName[intIndex])
{
return mstrProjectFileName;
}
else if (conCMProject.UseStateId  ==  _AttributeName[intIndex])
{
return mstrUseStateId;
}
else if (conCMProject.IsRefresh4RelaView  ==  _AttributeName[intIndex])
{
return mbolIsRefresh4RelaView;
}
else if (conCMProject.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conCMProject.UpdUserId  ==  _AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conCMProject.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conCMProject.CmPrjId  ==  _AttributeName[intIndex])
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(conCMProject.CmPrjId);
}
else if (conCMProject.CmPrjName  ==  _AttributeName[intIndex])
{
mstrCmPrjName = value.ToString();
 AddUpdatedFld(conCMProject.CmPrjName);
}
else if (conCMProject.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conCMProject.PrjId);
}
else if (conCMProject.ApplicationTypeId  ==  _AttributeName[intIndex])
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conCMProject.ApplicationTypeId);
}
else if (conCMProject.FunctionTemplateId  ==  _AttributeName[intIndex])
{
mstrFunctionTemplateId = value.ToString();
 AddUpdatedFld(conCMProject.FunctionTemplateId);
}
else if (conCMProject.VueDesignSysId  ==  _AttributeName[intIndex])
{
mstrVueDesignSysId = value.ToString();
 AddUpdatedFld(conCMProject.VueDesignSysId);
}
else if (conCMProject.IsFstLcase  ==  _AttributeName[intIndex])
{
mbolIsFstLcase = TransNullToBool(value.ToString());
 AddUpdatedFld(conCMProject.IsFstLcase);
}
else if (conCMProject.IsCamelCase  ==  _AttributeName[intIndex])
{
mbolIsCamelCase = TransNullToBool(value.ToString());
 AddUpdatedFld(conCMProject.IsCamelCase);
}
else if (conCMProject.ProjectFileName  ==  _AttributeName[intIndex])
{
mstrProjectFileName = value.ToString();
 AddUpdatedFld(conCMProject.ProjectFileName);
}
else if (conCMProject.UseStateId  ==  _AttributeName[intIndex])
{
mstrUseStateId = value.ToString();
 AddUpdatedFld(conCMProject.UseStateId);
}
else if (conCMProject.IsRefresh4RelaView  ==  _AttributeName[intIndex])
{
mbolIsRefresh4RelaView = TransNullToBool(value.ToString());
 AddUpdatedFld(conCMProject.IsRefresh4RelaView);
}
else if (conCMProject.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCMProject.UpdDate);
}
else if (conCMProject.UpdUserId  ==  _AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conCMProject.UpdUserId);
}
else if (conCMProject.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCMProject.Memo);
}
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
 AddUpdatedFld(conCMProject.CmPrjId);
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
 AddUpdatedFld(conCMProject.CmPrjName);
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
 AddUpdatedFld(conCMProject.PrjId);
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
 AddUpdatedFld(conCMProject.ApplicationTypeId);
}
}
/// <summary>
/// 函数模板Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FunctionTemplateId
{
get
{
return mstrFunctionTemplateId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFunctionTemplateId = value;
}
else
{
 mstrFunctionTemplateId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCMProject.FunctionTemplateId);
}
}
/// <summary>
/// Vue控件设计体系Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VueDesignSysId
{
get
{
return mstrVueDesignSysId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVueDesignSysId = value;
}
else
{
 mstrVueDesignSysId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCMProject.VueDesignSysId);
}
}
/// <summary>
/// 是否首字母小写(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsFstLcase
{
get
{
return mbolIsFstLcase;
}
set
{
 mbolIsFstLcase = value;
//记录修改过的字段
 AddUpdatedFld(conCMProject.IsFstLcase);
}
}
/// <summary>
/// 是否使用CamelCase(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsCamelCase
{
get
{
return mbolIsCamelCase;
}
set
{
 mbolIsCamelCase = value;
//记录修改过的字段
 AddUpdatedFld(conCMProject.IsCamelCase);
}
}
/// <summary>
/// 工程文件名(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProjectFileName
{
get
{
return mstrProjectFileName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProjectFileName = value;
}
else
{
 mstrProjectFileName = value;
}
//记录修改过的字段
 AddUpdatedFld(conCMProject.ProjectFileName);
}
}
/// <summary>
/// 使用状态Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UseStateId
{
get
{
return mstrUseStateId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUseStateId = value;
}
else
{
 mstrUseStateId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCMProject.UseStateId);
}
}
/// <summary>
/// 是否刷新相关视图(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsRefresh4RelaView
{
get
{
return mbolIsRefresh4RelaView;
}
set
{
 mbolIsRefresh4RelaView = value;
//记录修改过的字段
 AddUpdatedFld(conCMProject.IsRefresh4RelaView);
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
 AddUpdatedFld(conCMProject.UpdDate);
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
 AddUpdatedFld(conCMProject.UpdUserId);
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
 AddUpdatedFld(conCMProject.Memo);
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
  return mstrCmPrjId;
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
  return mstrCmPrjName;
 }
 }
}
 /// <summary>
 /// CM项目(CMProject)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCMProject
{
public const string _CurrTabName = "CMProject"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CmPrjId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"CmPrjId", "CmPrjName", "PrjId", "ApplicationTypeId", "FunctionTemplateId", "VueDesignSysId", "IsFstLcase", "IsCamelCase", "ProjectFileName", "UseStateId", "IsRefresh4RelaView", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"CmPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CmPrjId = "CmPrjId";    //Cm工程Id

 /// <summary>
 /// 常量:"CmPrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CmPrjName = "CmPrjName";    //CM工程名

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"ApplicationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeId = "ApplicationTypeId";    //应用程序类型ID

 /// <summary>
 /// 常量:"FunctionTemplateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FunctionTemplateId = "FunctionTemplateId";    //函数模板Id

 /// <summary>
 /// 常量:"VueDesignSysId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VueDesignSysId = "VueDesignSysId";    //Vue控件设计体系Id

 /// <summary>
 /// 常量:"IsFstLcase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsFstLcase = "IsFstLcase";    //是否首字母小写

 /// <summary>
 /// 常量:"IsCamelCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsCamelCase = "IsCamelCase";    //是否使用CamelCase

 /// <summary>
 /// 常量:"ProjectFileName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProjectFileName = "ProjectFileName";    //工程文件名

 /// <summary>
 /// 常量:"UseStateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UseStateId = "UseStateId";    //使用状态Id

 /// <summary>
 /// 常量:"IsRefresh4RelaView"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsRefresh4RelaView = "IsRefresh4RelaView";    //是否刷新相关视图

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