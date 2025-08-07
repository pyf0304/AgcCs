
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjCasesEN
 表名:vPrjCases(00050258)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:36:50
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:用例管理(CaseManage)
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
 /// 表vPrjCases的关键字(CaseId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CaseId_vPrjCases
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strCaseId">表关键字</param>
public K_CaseId_vPrjCases(string strCaseId)
{
if (IsValid(strCaseId)) Value = strCaseId;
else
{
Value = null;
}
}
private static bool IsValid(string strCaseId)
{
if (string.IsNullOrEmpty(strCaseId) == true) return false;
if (strCaseId.Length > 8) return false;
if (strCaseId.IndexOf(' ') >= 0) return false;
if (strCaseId.IndexOf(')') >= 0) return false;
if (strCaseId.IndexOf('(') >= 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_CaseId_vPrjCases]类型的对象</returns>
public static implicit operator K_CaseId_vPrjCases(string value)
{
return new K_CaseId_vPrjCases(value);
}
}
 /// <summary>
 /// v工程用例(vPrjCases)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvPrjCasesEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vPrjCases"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "CaseId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 12;
public static string[] _AttributeName = new string[] {"CaseId", "CaseName", "PrjId", "PrjName", "CaseContent", "CaseTypeId", "CaseTypeName", "ImportLevelId", "UserId", "UpdDate", "ImportLevelName", "Memo"};

protected string mstrCaseId;    //CaseId
protected string mstrCaseName;    //CaseName
protected string mstrPrjId;    //工程Id
protected string mstrPrjName;    //工程名称
protected string mstrCaseContent;    //CaseContent
protected string mstrCaseTypeId;    //CaseTypeId
protected string mstrCaseTypeName;    //案例类型名
protected string mstrImportLevelId;    //重要程度Id
protected string mstrUserId;    //用户Id
protected string mstrUpdDate;    //修改日期
protected string mstrImportLevelName;    //重要程度名称
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvPrjCasesEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CaseId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strCaseId">关键字:CaseId</param>
public clsvPrjCasesEN(string strCaseId)
 {
strCaseId = strCaseId.Replace("'", "''");
if (strCaseId.Length > 8)
{
throw new Exception("在表:vPrjCases中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strCaseId)  ==  true)
{
throw new Exception("在表:vPrjCases中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCaseId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrCaseId = strCaseId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CaseId");
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
if (strAttributeName  ==  convPrjCases.CaseId)
{
return mstrCaseId;
}
else if (strAttributeName  ==  convPrjCases.CaseName)
{
return mstrCaseName;
}
else if (strAttributeName  ==  convPrjCases.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convPrjCases.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convPrjCases.CaseContent)
{
return mstrCaseContent;
}
else if (strAttributeName  ==  convPrjCases.CaseTypeId)
{
return mstrCaseTypeId;
}
else if (strAttributeName  ==  convPrjCases.CaseTypeName)
{
return mstrCaseTypeName;
}
else if (strAttributeName  ==  convPrjCases.ImportLevelId)
{
return mstrImportLevelId;
}
else if (strAttributeName  ==  convPrjCases.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convPrjCases.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convPrjCases.ImportLevelName)
{
return mstrImportLevelName;
}
else if (strAttributeName  ==  convPrjCases.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convPrjCases.CaseId)
{
mstrCaseId = value.ToString();
 AddUpdatedFld(convPrjCases.CaseId);
}
else if (strAttributeName  ==  convPrjCases.CaseName)
{
mstrCaseName = value.ToString();
 AddUpdatedFld(convPrjCases.CaseName);
}
else if (strAttributeName  ==  convPrjCases.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convPrjCases.PrjId);
}
else if (strAttributeName  ==  convPrjCases.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convPrjCases.PrjName);
}
else if (strAttributeName  ==  convPrjCases.CaseContent)
{
mstrCaseContent = value.ToString();
 AddUpdatedFld(convPrjCases.CaseContent);
}
else if (strAttributeName  ==  convPrjCases.CaseTypeId)
{
mstrCaseTypeId = value.ToString();
 AddUpdatedFld(convPrjCases.CaseTypeId);
}
else if (strAttributeName  ==  convPrjCases.CaseTypeName)
{
mstrCaseTypeName = value.ToString();
 AddUpdatedFld(convPrjCases.CaseTypeName);
}
else if (strAttributeName  ==  convPrjCases.ImportLevelId)
{
mstrImportLevelId = value.ToString();
 AddUpdatedFld(convPrjCases.ImportLevelId);
}
else if (strAttributeName  ==  convPrjCases.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convPrjCases.UserId);
}
else if (strAttributeName  ==  convPrjCases.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convPrjCases.UpdDate);
}
else if (strAttributeName  ==  convPrjCases.ImportLevelName)
{
mstrImportLevelName = value.ToString();
 AddUpdatedFld(convPrjCases.ImportLevelName);
}
else if (strAttributeName  ==  convPrjCases.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convPrjCases.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convPrjCases.CaseId  ==  _AttributeName[intIndex])
{
return mstrCaseId;
}
else if (convPrjCases.CaseName  ==  _AttributeName[intIndex])
{
return mstrCaseName;
}
else if (convPrjCases.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convPrjCases.PrjName  ==  _AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convPrjCases.CaseContent  ==  _AttributeName[intIndex])
{
return mstrCaseContent;
}
else if (convPrjCases.CaseTypeId  ==  _AttributeName[intIndex])
{
return mstrCaseTypeId;
}
else if (convPrjCases.CaseTypeName  ==  _AttributeName[intIndex])
{
return mstrCaseTypeName;
}
else if (convPrjCases.ImportLevelId  ==  _AttributeName[intIndex])
{
return mstrImportLevelId;
}
else if (convPrjCases.UserId  ==  _AttributeName[intIndex])
{
return mstrUserId;
}
else if (convPrjCases.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convPrjCases.ImportLevelName  ==  _AttributeName[intIndex])
{
return mstrImportLevelName;
}
else if (convPrjCases.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convPrjCases.CaseId  ==  _AttributeName[intIndex])
{
mstrCaseId = value.ToString();
 AddUpdatedFld(convPrjCases.CaseId);
}
else if (convPrjCases.CaseName  ==  _AttributeName[intIndex])
{
mstrCaseName = value.ToString();
 AddUpdatedFld(convPrjCases.CaseName);
}
else if (convPrjCases.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convPrjCases.PrjId);
}
else if (convPrjCases.PrjName  ==  _AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convPrjCases.PrjName);
}
else if (convPrjCases.CaseContent  ==  _AttributeName[intIndex])
{
mstrCaseContent = value.ToString();
 AddUpdatedFld(convPrjCases.CaseContent);
}
else if (convPrjCases.CaseTypeId  ==  _AttributeName[intIndex])
{
mstrCaseTypeId = value.ToString();
 AddUpdatedFld(convPrjCases.CaseTypeId);
}
else if (convPrjCases.CaseTypeName  ==  _AttributeName[intIndex])
{
mstrCaseTypeName = value.ToString();
 AddUpdatedFld(convPrjCases.CaseTypeName);
}
else if (convPrjCases.ImportLevelId  ==  _AttributeName[intIndex])
{
mstrImportLevelId = value.ToString();
 AddUpdatedFld(convPrjCases.ImportLevelId);
}
else if (convPrjCases.UserId  ==  _AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convPrjCases.UserId);
}
else if (convPrjCases.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convPrjCases.UpdDate);
}
else if (convPrjCases.ImportLevelName  ==  _AttributeName[intIndex])
{
mstrImportLevelName = value.ToString();
 AddUpdatedFld(convPrjCases.ImportLevelName);
}
else if (convPrjCases.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convPrjCases.Memo);
}
}
}

/// <summary>
/// CaseId(说明:;字段类型:varchar;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CaseId
{
get
{
return mstrCaseId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaseId = value;
}
else
{
 mstrCaseId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjCases.CaseId);
}
}
/// <summary>
/// CaseName(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CaseName
{
get
{
return mstrCaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaseName = value;
}
else
{
 mstrCaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjCases.CaseName);
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
 AddUpdatedFld(convPrjCases.PrjId);
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
 AddUpdatedFld(convPrjCases.PrjName);
}
}
/// <summary>
/// CaseContent(说明:;字段类型:varchar;字段长度:1000;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CaseContent
{
get
{
return mstrCaseContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaseContent = value;
}
else
{
 mstrCaseContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjCases.CaseContent);
}
}
/// <summary>
/// CaseTypeId(说明:;字段类型:varchar;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CaseTypeId
{
get
{
return mstrCaseTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaseTypeId = value;
}
else
{
 mstrCaseTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjCases.CaseTypeId);
}
}
/// <summary>
/// 案例类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CaseTypeName
{
get
{
return mstrCaseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaseTypeName = value;
}
else
{
 mstrCaseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjCases.CaseTypeName);
}
}
/// <summary>
/// 重要程度Id(说明:;字段类型:varchar;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ImportLevelId
{
get
{
return mstrImportLevelId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrImportLevelId = value;
}
else
{
 mstrImportLevelId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjCases.ImportLevelId);
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
 AddUpdatedFld(convPrjCases.UserId);
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
 AddUpdatedFld(convPrjCases.UpdDate);
}
}
/// <summary>
/// 重要程度名称(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ImportLevelName
{
get
{
return mstrImportLevelName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrImportLevelName = value;
}
else
{
 mstrImportLevelName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjCases.ImportLevelName);
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
 AddUpdatedFld(convPrjCases.Memo);
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
  return mstrCaseId;
 }
 }
}
 /// <summary>
 /// v工程用例(vPrjCases)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convPrjCases
{
public const string _CurrTabName = "vPrjCases"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CaseId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"CaseId", "CaseName", "PrjId", "PrjName", "CaseContent", "CaseTypeId", "CaseTypeName", "ImportLevelId", "UserId", "UpdDate", "ImportLevelName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"CaseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseId = "CaseId";    //CaseId

 /// <summary>
 /// 常量:"CaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseName = "CaseName";    //CaseName

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
 /// 常量:"CaseContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseContent = "CaseContent";    //CaseContent

 /// <summary>
 /// 常量:"CaseTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseTypeId = "CaseTypeId";    //CaseTypeId

 /// <summary>
 /// 常量:"CaseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseTypeName = "CaseTypeName";    //案例类型名

 /// <summary>
 /// 常量:"ImportLevelId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ImportLevelId = "ImportLevelId";    //重要程度Id

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户Id

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"ImportLevelName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ImportLevelName = "ImportLevelName";    //重要程度名称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}