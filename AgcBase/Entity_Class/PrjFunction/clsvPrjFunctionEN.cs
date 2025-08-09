
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjFunctionEN
 表名:vPrjFunction(00050259)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:04:37
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
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
 /// 表vPrjFunction的关键字(FuncId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_FuncId_vPrjFunction
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strFuncId">表关键字</param>
public K_FuncId_vPrjFunction(string strFuncId)
{
if (IsValid(strFuncId)) Value = strFuncId;
else
{
Value = null;
}
}
private static bool IsValid(string strFuncId)
{
if (string.IsNullOrEmpty(strFuncId) == true) return false;
if (strFuncId.Length > 10) return false;
if (strFuncId.IndexOf(' ') >= 0) return false;
if (strFuncId.IndexOf(')') >= 0) return false;
if (strFuncId.IndexOf('(') >= 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_FuncId_vPrjFunction]类型的对象</returns>
public static implicit operator K_FuncId_vPrjFunction(string value)
{
return new K_FuncId_vPrjFunction(value);
}
}
 /// <summary>
 /// v工程函数(vPrjFunction)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvPrjFunctionEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vPrjFunction"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "FuncId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 15;
public static string[] _AttributeName = new string[] {"FuncId", "FuncName", "PrjId", "ReturnTypeId", "DataTypeName", "DataCnName", "CsType", "FuncTypeId", "FuncTypeName", "IsTemplate", "FuncCode", "UserId", "UpdDate", "UpdUser", "Memo"};

protected string mstrFuncId;    //函数ID
protected string mstrFuncName;    //函数名
protected string mstrPrjId;    //工程Id
protected string mstrReturnTypeId;    //返回类型ID
protected string mstrDataTypeName;    //数据类型名称
protected string mstrDataCnName;    //数据类型中文名称
protected string mstrCsType;    //CS类型
protected string mstrFuncTypeId;    //函数类型Id
protected string mstrFuncTypeName;    //函数类型名
protected bool mbolIsTemplate;    //是否模板
protected string mstrFuncCode;    //函数代码
protected string mstrUserId;    //用户Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvPrjFunctionEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FuncId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strFuncId">关键字:函数ID</param>
public clsvPrjFunctionEN(string strFuncId)
 {
strFuncId = strFuncId.Replace("'", "''");
if (strFuncId.Length > 10)
{
throw new Exception("在表:vPrjFunction中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strFuncId)  ==  true)
{
throw new Exception("在表:vPrjFunction中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFuncId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrFuncId = strFuncId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FuncId");
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
if (strAttributeName  ==  convPrjFunction.FuncId)
{
return mstrFuncId;
}
else if (strAttributeName  ==  convPrjFunction.FuncName)
{
return mstrFuncName;
}
else if (strAttributeName  ==  convPrjFunction.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convPrjFunction.ReturnTypeId)
{
return mstrReturnTypeId;
}
else if (strAttributeName  ==  convPrjFunction.DataTypeName)
{
return mstrDataTypeName;
}
else if (strAttributeName  ==  convPrjFunction.DataCnName)
{
return mstrDataCnName;
}
else if (strAttributeName  ==  convPrjFunction.CsType)
{
return mstrCsType;
}
else if (strAttributeName  ==  convPrjFunction.FuncTypeId)
{
return mstrFuncTypeId;
}
else if (strAttributeName  ==  convPrjFunction.FuncTypeName)
{
return mstrFuncTypeName;
}
else if (strAttributeName  ==  convPrjFunction.IsTemplate)
{
return mbolIsTemplate;
}
else if (strAttributeName  ==  convPrjFunction.FuncCode)
{
return mstrFuncCode;
}
else if (strAttributeName  ==  convPrjFunction.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convPrjFunction.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convPrjFunction.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convPrjFunction.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convPrjFunction.FuncId)
{
mstrFuncId = value.ToString();
 AddUpdatedFld(convPrjFunction.FuncId);
}
else if (strAttributeName  ==  convPrjFunction.FuncName)
{
mstrFuncName = value.ToString();
 AddUpdatedFld(convPrjFunction.FuncName);
}
else if (strAttributeName  ==  convPrjFunction.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convPrjFunction.PrjId);
}
else if (strAttributeName  ==  convPrjFunction.ReturnTypeId)
{
mstrReturnTypeId = value.ToString();
 AddUpdatedFld(convPrjFunction.ReturnTypeId);
}
else if (strAttributeName  ==  convPrjFunction.DataTypeName)
{
mstrDataTypeName = value.ToString();
 AddUpdatedFld(convPrjFunction.DataTypeName);
}
else if (strAttributeName  ==  convPrjFunction.DataCnName)
{
mstrDataCnName = value.ToString();
 AddUpdatedFld(convPrjFunction.DataCnName);
}
else if (strAttributeName  ==  convPrjFunction.CsType)
{
mstrCsType = value.ToString();
 AddUpdatedFld(convPrjFunction.CsType);
}
else if (strAttributeName  ==  convPrjFunction.FuncTypeId)
{
mstrFuncTypeId = value.ToString();
 AddUpdatedFld(convPrjFunction.FuncTypeId);
}
else if (strAttributeName  ==  convPrjFunction.FuncTypeName)
{
mstrFuncTypeName = value.ToString();
 AddUpdatedFld(convPrjFunction.FuncTypeName);
}
else if (strAttributeName  ==  convPrjFunction.IsTemplate)
{
mbolIsTemplate = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjFunction.IsTemplate);
}
else if (strAttributeName  ==  convPrjFunction.FuncCode)
{
mstrFuncCode = value.ToString();
 AddUpdatedFld(convPrjFunction.FuncCode);
}
else if (strAttributeName  ==  convPrjFunction.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convPrjFunction.UserId);
}
else if (strAttributeName  ==  convPrjFunction.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convPrjFunction.UpdDate);
}
else if (strAttributeName  ==  convPrjFunction.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convPrjFunction.UpdUser);
}
else if (strAttributeName  ==  convPrjFunction.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convPrjFunction.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convPrjFunction.FuncId  ==  _AttributeName[intIndex])
{
return mstrFuncId;
}
else if (convPrjFunction.FuncName  ==  _AttributeName[intIndex])
{
return mstrFuncName;
}
else if (convPrjFunction.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convPrjFunction.ReturnTypeId  ==  _AttributeName[intIndex])
{
return mstrReturnTypeId;
}
else if (convPrjFunction.DataTypeName  ==  _AttributeName[intIndex])
{
return mstrDataTypeName;
}
else if (convPrjFunction.DataCnName  ==  _AttributeName[intIndex])
{
return mstrDataCnName;
}
else if (convPrjFunction.CsType  ==  _AttributeName[intIndex])
{
return mstrCsType;
}
else if (convPrjFunction.FuncTypeId  ==  _AttributeName[intIndex])
{
return mstrFuncTypeId;
}
else if (convPrjFunction.FuncTypeName  ==  _AttributeName[intIndex])
{
return mstrFuncTypeName;
}
else if (convPrjFunction.IsTemplate  ==  _AttributeName[intIndex])
{
return mbolIsTemplate;
}
else if (convPrjFunction.FuncCode  ==  _AttributeName[intIndex])
{
return mstrFuncCode;
}
else if (convPrjFunction.UserId  ==  _AttributeName[intIndex])
{
return mstrUserId;
}
else if (convPrjFunction.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convPrjFunction.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convPrjFunction.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convPrjFunction.FuncId  ==  _AttributeName[intIndex])
{
mstrFuncId = value.ToString();
 AddUpdatedFld(convPrjFunction.FuncId);
}
else if (convPrjFunction.FuncName  ==  _AttributeName[intIndex])
{
mstrFuncName = value.ToString();
 AddUpdatedFld(convPrjFunction.FuncName);
}
else if (convPrjFunction.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convPrjFunction.PrjId);
}
else if (convPrjFunction.ReturnTypeId  ==  _AttributeName[intIndex])
{
mstrReturnTypeId = value.ToString();
 AddUpdatedFld(convPrjFunction.ReturnTypeId);
}
else if (convPrjFunction.DataTypeName  ==  _AttributeName[intIndex])
{
mstrDataTypeName = value.ToString();
 AddUpdatedFld(convPrjFunction.DataTypeName);
}
else if (convPrjFunction.DataCnName  ==  _AttributeName[intIndex])
{
mstrDataCnName = value.ToString();
 AddUpdatedFld(convPrjFunction.DataCnName);
}
else if (convPrjFunction.CsType  ==  _AttributeName[intIndex])
{
mstrCsType = value.ToString();
 AddUpdatedFld(convPrjFunction.CsType);
}
else if (convPrjFunction.FuncTypeId  ==  _AttributeName[intIndex])
{
mstrFuncTypeId = value.ToString();
 AddUpdatedFld(convPrjFunction.FuncTypeId);
}
else if (convPrjFunction.FuncTypeName  ==  _AttributeName[intIndex])
{
mstrFuncTypeName = value.ToString();
 AddUpdatedFld(convPrjFunction.FuncTypeName);
}
else if (convPrjFunction.IsTemplate  ==  _AttributeName[intIndex])
{
mbolIsTemplate = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjFunction.IsTemplate);
}
else if (convPrjFunction.FuncCode  ==  _AttributeName[intIndex])
{
mstrFuncCode = value.ToString();
 AddUpdatedFld(convPrjFunction.FuncCode);
}
else if (convPrjFunction.UserId  ==  _AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convPrjFunction.UserId);
}
else if (convPrjFunction.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convPrjFunction.UpdDate);
}
else if (convPrjFunction.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convPrjFunction.UpdUser);
}
else if (convPrjFunction.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convPrjFunction.Memo);
}
}
}

/// <summary>
/// 函数ID(说明:;字段类型:varchar;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncId
{
get
{
return mstrFuncId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncId = value;
}
else
{
 mstrFuncId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjFunction.FuncId);
}
}
/// <summary>
/// 函数名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncName
{
get
{
return mstrFuncName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncName = value;
}
else
{
 mstrFuncName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjFunction.FuncName);
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
 AddUpdatedFld(convPrjFunction.PrjId);
}
}
/// <summary>
/// 返回类型ID(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ReturnTypeId
{
get
{
return mstrReturnTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrReturnTypeId = value;
}
else
{
 mstrReturnTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjFunction.ReturnTypeId);
}
}
/// <summary>
/// 数据类型名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataTypeName
{
get
{
return mstrDataTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataTypeName = value;
}
else
{
 mstrDataTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjFunction.DataTypeName);
}
}
/// <summary>
/// 数据类型中文名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataCnName
{
get
{
return mstrDataCnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataCnName = value;
}
else
{
 mstrDataCnName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjFunction.DataCnName);
}
}
/// <summary>
/// CS类型(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CsType
{
get
{
return mstrCsType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCsType = value;
}
else
{
 mstrCsType = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjFunction.CsType);
}
}
/// <summary>
/// 函数类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncTypeId
{
get
{
return mstrFuncTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncTypeId = value;
}
else
{
 mstrFuncTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjFunction.FuncTypeId);
}
}
/// <summary>
/// 函数类型名(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncTypeName
{
get
{
return mstrFuncTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncTypeName = value;
}
else
{
 mstrFuncTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjFunction.FuncTypeName);
}
}
/// <summary>
/// 是否模板(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsTemplate
{
get
{
return mbolIsTemplate;
}
set
{
 mbolIsTemplate = value;
//记录修改过的字段
 AddUpdatedFld(convPrjFunction.IsTemplate);
}
}
/// <summary>
/// 函数代码(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncCode
{
get
{
return mstrFuncCode;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncCode = value;
}
else
{
 mstrFuncCode = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjFunction.FuncCode);
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
 AddUpdatedFld(convPrjFunction.UserId);
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
 AddUpdatedFld(convPrjFunction.UpdDate);
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
 AddUpdatedFld(convPrjFunction.UpdUser);
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
 AddUpdatedFld(convPrjFunction.Memo);
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
  return mstrFuncId;
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
  return mstrFuncName;
 }
 }
}
 /// <summary>
 /// v工程函数(vPrjFunction)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convPrjFunction
{
public const string _CurrTabName = "vPrjFunction"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FuncId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"FuncId", "FuncName", "PrjId", "ReturnTypeId", "DataTypeName", "DataCnName", "CsType", "FuncTypeId", "FuncTypeName", "IsTemplate", "FuncCode", "UserId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"FuncId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncId = "FuncId";    //函数ID

 /// <summary>
 /// 常量:"FuncName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncName = "FuncName";    //函数名

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"ReturnTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReturnTypeId = "ReturnTypeId";    //返回类型ID

 /// <summary>
 /// 常量:"DataTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataTypeName = "DataTypeName";    //数据类型名称

 /// <summary>
 /// 常量:"DataCnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataCnName = "DataCnName";    //数据类型中文名称

 /// <summary>
 /// 常量:"CsType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CsType = "CsType";    //CS类型

 /// <summary>
 /// 常量:"FuncTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncTypeId = "FuncTypeId";    //函数类型Id

 /// <summary>
 /// 常量:"FuncTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncTypeName = "FuncTypeName";    //函数类型名

 /// <summary>
 /// 常量:"IsTemplate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsTemplate = "IsTemplate";    //是否模板

 /// <summary>
 /// 常量:"FuncCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncCode = "FuncCode";    //函数代码

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