
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjFunctionEN
 表名:PrjFunction(00050072)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:33:00
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
 /// 表PrjFunction的关键字(FuncId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_FuncId_PrjFunction
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
public K_FuncId_PrjFunction(string strFuncId)
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
 /// <returns>返回:[K_FuncId_PrjFunction]类型的对象</returns>
public static implicit operator K_FuncId_PrjFunction(string value)
{
return new K_FuncId_PrjFunction(value);
}
}
 /// <summary>
 /// 工程函数(PrjFunction)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsPrjFunctionEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "PrjFunction"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "FuncId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 11;
public static string[] _AttributeName = new string[] {"FuncId", "FuncName", "PrjId", "ReturnTypeId", "FuncTypeId", "IsTemplate", "FuncCode", "UserId", "UpdDate", "UpdUser", "Memo"};

protected string mstrFuncId;    //函数ID
protected string mstrFuncName;    //函数名
protected string mstrPrjId;    //工程Id
protected string mstrReturnTypeId;    //返回类型ID
protected string mstrFuncTypeId;    //函数类型Id
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
 public clsPrjFunctionEN()
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
public clsPrjFunctionEN(string strFuncId)
 {
strFuncId = strFuncId.Replace("'", "''");
if (strFuncId.Length > 10)
{
throw new Exception("在表:PrjFunction中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strFuncId)  ==  true)
{
throw new Exception("在表:PrjFunction中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  conPrjFunction.FuncId)
{
return mstrFuncId;
}
else if (strAttributeName  ==  conPrjFunction.FuncName)
{
return mstrFuncName;
}
else if (strAttributeName  ==  conPrjFunction.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conPrjFunction.ReturnTypeId)
{
return mstrReturnTypeId;
}
else if (strAttributeName  ==  conPrjFunction.FuncTypeId)
{
return mstrFuncTypeId;
}
else if (strAttributeName  ==  conPrjFunction.IsTemplate)
{
return mbolIsTemplate;
}
else if (strAttributeName  ==  conPrjFunction.FuncCode)
{
return mstrFuncCode;
}
else if (strAttributeName  ==  conPrjFunction.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conPrjFunction.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conPrjFunction.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conPrjFunction.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conPrjFunction.FuncId)
{
mstrFuncId = value.ToString();
 AddUpdatedFld(conPrjFunction.FuncId);
}
else if (strAttributeName  ==  conPrjFunction.FuncName)
{
mstrFuncName = value.ToString();
 AddUpdatedFld(conPrjFunction.FuncName);
}
else if (strAttributeName  ==  conPrjFunction.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conPrjFunction.PrjId);
}
else if (strAttributeName  ==  conPrjFunction.ReturnTypeId)
{
mstrReturnTypeId = value.ToString();
 AddUpdatedFld(conPrjFunction.ReturnTypeId);
}
else if (strAttributeName  ==  conPrjFunction.FuncTypeId)
{
mstrFuncTypeId = value.ToString();
 AddUpdatedFld(conPrjFunction.FuncTypeId);
}
else if (strAttributeName  ==  conPrjFunction.IsTemplate)
{
mbolIsTemplate = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjFunction.IsTemplate);
}
else if (strAttributeName  ==  conPrjFunction.FuncCode)
{
mstrFuncCode = value.ToString();
 AddUpdatedFld(conPrjFunction.FuncCode);
}
else if (strAttributeName  ==  conPrjFunction.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conPrjFunction.UserId);
}
else if (strAttributeName  ==  conPrjFunction.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conPrjFunction.UpdDate);
}
else if (strAttributeName  ==  conPrjFunction.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conPrjFunction.UpdUser);
}
else if (strAttributeName  ==  conPrjFunction.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPrjFunction.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conPrjFunction.FuncId  ==  _AttributeName[intIndex])
{
return mstrFuncId;
}
else if (conPrjFunction.FuncName  ==  _AttributeName[intIndex])
{
return mstrFuncName;
}
else if (conPrjFunction.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conPrjFunction.ReturnTypeId  ==  _AttributeName[intIndex])
{
return mstrReturnTypeId;
}
else if (conPrjFunction.FuncTypeId  ==  _AttributeName[intIndex])
{
return mstrFuncTypeId;
}
else if (conPrjFunction.IsTemplate  ==  _AttributeName[intIndex])
{
return mbolIsTemplate;
}
else if (conPrjFunction.FuncCode  ==  _AttributeName[intIndex])
{
return mstrFuncCode;
}
else if (conPrjFunction.UserId  ==  _AttributeName[intIndex])
{
return mstrUserId;
}
else if (conPrjFunction.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conPrjFunction.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conPrjFunction.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conPrjFunction.FuncId  ==  _AttributeName[intIndex])
{
mstrFuncId = value.ToString();
 AddUpdatedFld(conPrjFunction.FuncId);
}
else if (conPrjFunction.FuncName  ==  _AttributeName[intIndex])
{
mstrFuncName = value.ToString();
 AddUpdatedFld(conPrjFunction.FuncName);
}
else if (conPrjFunction.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conPrjFunction.PrjId);
}
else if (conPrjFunction.ReturnTypeId  ==  _AttributeName[intIndex])
{
mstrReturnTypeId = value.ToString();
 AddUpdatedFld(conPrjFunction.ReturnTypeId);
}
else if (conPrjFunction.FuncTypeId  ==  _AttributeName[intIndex])
{
mstrFuncTypeId = value.ToString();
 AddUpdatedFld(conPrjFunction.FuncTypeId);
}
else if (conPrjFunction.IsTemplate  ==  _AttributeName[intIndex])
{
mbolIsTemplate = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjFunction.IsTemplate);
}
else if (conPrjFunction.FuncCode  ==  _AttributeName[intIndex])
{
mstrFuncCode = value.ToString();
 AddUpdatedFld(conPrjFunction.FuncCode);
}
else if (conPrjFunction.UserId  ==  _AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conPrjFunction.UserId);
}
else if (conPrjFunction.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conPrjFunction.UpdDate);
}
else if (conPrjFunction.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conPrjFunction.UpdUser);
}
else if (conPrjFunction.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPrjFunction.Memo);
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
 AddUpdatedFld(conPrjFunction.FuncId);
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
 AddUpdatedFld(conPrjFunction.FuncName);
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
 AddUpdatedFld(conPrjFunction.PrjId);
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
 AddUpdatedFld(conPrjFunction.ReturnTypeId);
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
 AddUpdatedFld(conPrjFunction.FuncTypeId);
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
 AddUpdatedFld(conPrjFunction.IsTemplate);
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
 AddUpdatedFld(conPrjFunction.FuncCode);
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
 AddUpdatedFld(conPrjFunction.UserId);
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
 AddUpdatedFld(conPrjFunction.UpdDate);
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
 AddUpdatedFld(conPrjFunction.UpdUser);
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
 AddUpdatedFld(conPrjFunction.Memo);
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
 /// 工程函数(PrjFunction)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conPrjFunction
{
public const string _CurrTabName = "PrjFunction"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FuncId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"FuncId", "FuncName", "PrjId", "ReturnTypeId", "FuncTypeId", "IsTemplate", "FuncCode", "UserId", "UpdDate", "UpdUser", "Memo"};
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
 /// 常量:"FuncTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncTypeId = "FuncTypeId";    //函数类型Id

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