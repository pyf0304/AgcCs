
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCaseTypeEN
 表名:CaseType(00050055)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:34:36
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
 /// 表CaseType的关键字(CaseTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CaseTypeId_CaseType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strCaseTypeId">表关键字</param>
public K_CaseTypeId_CaseType(string strCaseTypeId)
{
if (IsValid(strCaseTypeId)) Value = strCaseTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strCaseTypeId)
{
if (string.IsNullOrEmpty(strCaseTypeId) == true) return false;
if (strCaseTypeId.Length > 4) return false;
if (strCaseTypeId.IndexOf(' ') >= 0) return false;
if (strCaseTypeId.IndexOf(')') >= 0) return false;
if (strCaseTypeId.IndexOf('(') >= 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_CaseTypeId_CaseType]类型的对象</returns>
public static implicit operator K_CaseTypeId_CaseType(string value)
{
return new K_CaseTypeId_CaseType(value);
}
}
 /// <summary>
 /// 案例类型(CaseType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCaseTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CaseType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "CaseTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 3;
public static string[] _AttributeName = new string[] {"CaseTypeId", "CaseTypeName", "Memo"};

protected string mstrCaseTypeId;    //CaseTypeId
protected string mstrCaseTypeName;    //案例类型名
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsCaseTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CaseTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strCaseTypeId">关键字:CaseTypeId</param>
public clsCaseTypeEN(string strCaseTypeId)
 {
strCaseTypeId = strCaseTypeId.Replace("'", "''");
if (strCaseTypeId.Length > 4)
{
throw new Exception("在表:CaseType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strCaseTypeId)  ==  true)
{
throw new Exception("在表:CaseType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCaseTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrCaseTypeId = strCaseTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CaseTypeId");
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
if (strAttributeName  ==  conCaseType.CaseTypeId)
{
return mstrCaseTypeId;
}
else if (strAttributeName  ==  conCaseType.CaseTypeName)
{
return mstrCaseTypeName;
}
else if (strAttributeName  ==  conCaseType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conCaseType.CaseTypeId)
{
mstrCaseTypeId = value.ToString();
 AddUpdatedFld(conCaseType.CaseTypeId);
}
else if (strAttributeName  ==  conCaseType.CaseTypeName)
{
mstrCaseTypeName = value.ToString();
 AddUpdatedFld(conCaseType.CaseTypeName);
}
else if (strAttributeName  ==  conCaseType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCaseType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conCaseType.CaseTypeId  ==  _AttributeName[intIndex])
{
return mstrCaseTypeId;
}
else if (conCaseType.CaseTypeName  ==  _AttributeName[intIndex])
{
return mstrCaseTypeName;
}
else if (conCaseType.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conCaseType.CaseTypeId  ==  _AttributeName[intIndex])
{
mstrCaseTypeId = value.ToString();
 AddUpdatedFld(conCaseType.CaseTypeId);
}
else if (conCaseType.CaseTypeName  ==  _AttributeName[intIndex])
{
mstrCaseTypeName = value.ToString();
 AddUpdatedFld(conCaseType.CaseTypeName);
}
else if (conCaseType.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCaseType.Memo);
}
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
 AddUpdatedFld(conCaseType.CaseTypeId);
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
 AddUpdatedFld(conCaseType.CaseTypeName);
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
 AddUpdatedFld(conCaseType.Memo);
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
  return mstrCaseTypeId;
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
  return mstrCaseTypeName;
 }
 }
}
 /// <summary>
 /// 案例类型(CaseType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCaseType
{
public const string _CurrTabName = "CaseType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CaseTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"CaseTypeId", "CaseTypeName", "Memo"};
//以下是属性变量


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
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}