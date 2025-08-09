
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjCasesEN
 表名:PrjCases(00050071)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:05:16
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
 /// 表PrjCases的关键字(CaseId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CaseId_PrjCases
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
public K_CaseId_PrjCases(string strCaseId)
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
 /// <returns>返回:[K_CaseId_PrjCases]类型的对象</returns>
public static implicit operator K_CaseId_PrjCases(string value)
{
return new K_CaseId_PrjCases(value);
}
}
 /// <summary>
 /// 工程用例(PrjCases)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsPrjCasesEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "PrjCases"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "CaseId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 9;
public static string[] _AttributeName = new string[] {"CaseId", "CaseName", "PrjId", "CaseContent", "CaseTypeId", "ImportLevelId", "UserId", "UpdDate", "Memo"};

protected string mstrCaseId;    //CaseId
protected string mstrCaseName;    //CaseName
protected string mstrPrjId;    //工程Id
protected string mstrCaseContent;    //CaseContent
protected string mstrCaseTypeId;    //CaseTypeId
protected string mstrImportLevelId;    //重要程度Id
protected string mstrUserId;    //用户Id
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsPrjCasesEN()
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
public clsPrjCasesEN(string strCaseId)
 {
strCaseId = strCaseId.Replace("'", "''");
if (strCaseId.Length > 8)
{
throw new Exception("在表:PrjCases中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strCaseId)  ==  true)
{
throw new Exception("在表:PrjCases中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  conPrjCases.CaseId)
{
return mstrCaseId;
}
else if (strAttributeName  ==  conPrjCases.CaseName)
{
return mstrCaseName;
}
else if (strAttributeName  ==  conPrjCases.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conPrjCases.CaseContent)
{
return mstrCaseContent;
}
else if (strAttributeName  ==  conPrjCases.CaseTypeId)
{
return mstrCaseTypeId;
}
else if (strAttributeName  ==  conPrjCases.ImportLevelId)
{
return mstrImportLevelId;
}
else if (strAttributeName  ==  conPrjCases.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conPrjCases.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conPrjCases.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conPrjCases.CaseId)
{
mstrCaseId = value.ToString();
 AddUpdatedFld(conPrjCases.CaseId);
}
else if (strAttributeName  ==  conPrjCases.CaseName)
{
mstrCaseName = value.ToString();
 AddUpdatedFld(conPrjCases.CaseName);
}
else if (strAttributeName  ==  conPrjCases.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conPrjCases.PrjId);
}
else if (strAttributeName  ==  conPrjCases.CaseContent)
{
mstrCaseContent = value.ToString();
 AddUpdatedFld(conPrjCases.CaseContent);
}
else if (strAttributeName  ==  conPrjCases.CaseTypeId)
{
mstrCaseTypeId = value.ToString();
 AddUpdatedFld(conPrjCases.CaseTypeId);
}
else if (strAttributeName  ==  conPrjCases.ImportLevelId)
{
mstrImportLevelId = value.ToString();
 AddUpdatedFld(conPrjCases.ImportLevelId);
}
else if (strAttributeName  ==  conPrjCases.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conPrjCases.UserId);
}
else if (strAttributeName  ==  conPrjCases.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conPrjCases.UpdDate);
}
else if (strAttributeName  ==  conPrjCases.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPrjCases.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conPrjCases.CaseId  ==  _AttributeName[intIndex])
{
return mstrCaseId;
}
else if (conPrjCases.CaseName  ==  _AttributeName[intIndex])
{
return mstrCaseName;
}
else if (conPrjCases.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conPrjCases.CaseContent  ==  _AttributeName[intIndex])
{
return mstrCaseContent;
}
else if (conPrjCases.CaseTypeId  ==  _AttributeName[intIndex])
{
return mstrCaseTypeId;
}
else if (conPrjCases.ImportLevelId  ==  _AttributeName[intIndex])
{
return mstrImportLevelId;
}
else if (conPrjCases.UserId  ==  _AttributeName[intIndex])
{
return mstrUserId;
}
else if (conPrjCases.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conPrjCases.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conPrjCases.CaseId  ==  _AttributeName[intIndex])
{
mstrCaseId = value.ToString();
 AddUpdatedFld(conPrjCases.CaseId);
}
else if (conPrjCases.CaseName  ==  _AttributeName[intIndex])
{
mstrCaseName = value.ToString();
 AddUpdatedFld(conPrjCases.CaseName);
}
else if (conPrjCases.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conPrjCases.PrjId);
}
else if (conPrjCases.CaseContent  ==  _AttributeName[intIndex])
{
mstrCaseContent = value.ToString();
 AddUpdatedFld(conPrjCases.CaseContent);
}
else if (conPrjCases.CaseTypeId  ==  _AttributeName[intIndex])
{
mstrCaseTypeId = value.ToString();
 AddUpdatedFld(conPrjCases.CaseTypeId);
}
else if (conPrjCases.ImportLevelId  ==  _AttributeName[intIndex])
{
mstrImportLevelId = value.ToString();
 AddUpdatedFld(conPrjCases.ImportLevelId);
}
else if (conPrjCases.UserId  ==  _AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conPrjCases.UserId);
}
else if (conPrjCases.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conPrjCases.UpdDate);
}
else if (conPrjCases.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPrjCases.Memo);
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
 AddUpdatedFld(conPrjCases.CaseId);
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
 AddUpdatedFld(conPrjCases.CaseName);
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
 AddUpdatedFld(conPrjCases.PrjId);
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
 AddUpdatedFld(conPrjCases.CaseContent);
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
 AddUpdatedFld(conPrjCases.CaseTypeId);
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
 AddUpdatedFld(conPrjCases.ImportLevelId);
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
 AddUpdatedFld(conPrjCases.UserId);
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
 AddUpdatedFld(conPrjCases.UpdDate);
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
 AddUpdatedFld(conPrjCases.Memo);
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

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrCaseName;
 }
 }
}
 /// <summary>
 /// 工程用例(PrjCases)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conPrjCases
{
public const string _CurrTabName = "PrjCases"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CaseId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"CaseId", "CaseName", "PrjId", "CaseContent", "CaseTypeId", "ImportLevelId", "UserId", "UpdDate", "Memo"};
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
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}