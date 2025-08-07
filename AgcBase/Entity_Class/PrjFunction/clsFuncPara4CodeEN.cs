
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFuncPara4CodeEN
 表名:FuncPara4Code(00050384)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:31:34
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
 /// 表FuncPara4Code的关键字(FuncParaId4Code)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_FuncParaId4Code_FuncPara4Code
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strFuncParaId4Code">表关键字</param>
public K_FuncParaId4Code_FuncPara4Code(string strFuncParaId4Code)
{
if (IsValid(strFuncParaId4Code)) Value = strFuncParaId4Code;
else
{
Value = null;
}
}
private static bool IsValid(string strFuncParaId4Code)
{
if (string.IsNullOrEmpty(strFuncParaId4Code) == true) return false;
if (strFuncParaId4Code.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_FuncParaId4Code_FuncPara4Code]类型的对象</returns>
public static implicit operator K_FuncParaId4Code_FuncPara4Code(string value)
{
return new K_FuncParaId4Code_FuncPara4Code(value);
}
}
 /// <summary>
 /// 函数参数4Code(FuncPara4Code)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsFuncPara4CodeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "FuncPara4Code"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "FuncParaId4Code"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 13;
public static string[] _AttributeName = new string[] {"FuncParaId4Code", "ParaName", "ParaCnName", "DataTypeId", "ParameterType", "ParameterTypeFullName", "IsByRef", "PrjId", "IsTemplate", "FuncPurposeId", "UpdDate", "UpdUser", "Memo"};

protected string mstrFuncParaId4Code;    //函数参数Id
protected string mstrParaName;    //参数名
protected string mstrParaCnName;    //参数中文名
protected string mstrDataTypeId;    //数据类型Id
protected string mstrParameterType;    //参数类型
protected string mstrParameterTypeFullName;    //参数类型全名
protected bool mbolIsByRef;    //是否引用型参数
protected string mstrPrjId;    //工程Id
protected bool mbolIsTemplate;    //是否模板
protected string mstrFuncPurposeId;    //函数用途Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsFuncPara4CodeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FuncParaId4Code");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strFuncParaId4Code">关键字:函数参数Id</param>
public clsFuncPara4CodeEN(string strFuncParaId4Code)
 {
strFuncParaId4Code = strFuncParaId4Code.Replace("'", "''");
if (strFuncParaId4Code.Length > 8)
{
throw new Exception("在表:FuncPara4Code中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strFuncParaId4Code)  ==  true)
{
throw new Exception("在表:FuncPara4Code中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFuncParaId4Code);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrFuncParaId4Code = strFuncParaId4Code;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FuncParaId4Code");
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
if (strAttributeName  ==  conFuncPara4Code.FuncParaId4Code)
{
return mstrFuncParaId4Code;
}
else if (strAttributeName  ==  conFuncPara4Code.ParaName)
{
return mstrParaName;
}
else if (strAttributeName  ==  conFuncPara4Code.ParaCnName)
{
return mstrParaCnName;
}
else if (strAttributeName  ==  conFuncPara4Code.DataTypeId)
{
return mstrDataTypeId;
}
else if (strAttributeName  ==  conFuncPara4Code.ParameterType)
{
return mstrParameterType;
}
else if (strAttributeName  ==  conFuncPara4Code.ParameterTypeFullName)
{
return mstrParameterTypeFullName;
}
else if (strAttributeName  ==  conFuncPara4Code.IsByRef)
{
return mbolIsByRef;
}
else if (strAttributeName  ==  conFuncPara4Code.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conFuncPara4Code.IsTemplate)
{
return mbolIsTemplate;
}
else if (strAttributeName  ==  conFuncPara4Code.FuncPurposeId)
{
return mstrFuncPurposeId;
}
else if (strAttributeName  ==  conFuncPara4Code.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conFuncPara4Code.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conFuncPara4Code.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conFuncPara4Code.FuncParaId4Code)
{
mstrFuncParaId4Code = value.ToString();
 AddUpdatedFld(conFuncPara4Code.FuncParaId4Code);
}
else if (strAttributeName  ==  conFuncPara4Code.ParaName)
{
mstrParaName = value.ToString();
 AddUpdatedFld(conFuncPara4Code.ParaName);
}
else if (strAttributeName  ==  conFuncPara4Code.ParaCnName)
{
mstrParaCnName = value.ToString();
 AddUpdatedFld(conFuncPara4Code.ParaCnName);
}
else if (strAttributeName  ==  conFuncPara4Code.DataTypeId)
{
mstrDataTypeId = value.ToString();
 AddUpdatedFld(conFuncPara4Code.DataTypeId);
}
else if (strAttributeName  ==  conFuncPara4Code.ParameterType)
{
mstrParameterType = value.ToString();
 AddUpdatedFld(conFuncPara4Code.ParameterType);
}
else if (strAttributeName  ==  conFuncPara4Code.ParameterTypeFullName)
{
mstrParameterTypeFullName = value.ToString();
 AddUpdatedFld(conFuncPara4Code.ParameterTypeFullName);
}
else if (strAttributeName  ==  conFuncPara4Code.IsByRef)
{
mbolIsByRef = TransNullToBool(value.ToString());
 AddUpdatedFld(conFuncPara4Code.IsByRef);
}
else if (strAttributeName  ==  conFuncPara4Code.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conFuncPara4Code.PrjId);
}
else if (strAttributeName  ==  conFuncPara4Code.IsTemplate)
{
mbolIsTemplate = TransNullToBool(value.ToString());
 AddUpdatedFld(conFuncPara4Code.IsTemplate);
}
else if (strAttributeName  ==  conFuncPara4Code.FuncPurposeId)
{
mstrFuncPurposeId = value.ToString();
 AddUpdatedFld(conFuncPara4Code.FuncPurposeId);
}
else if (strAttributeName  ==  conFuncPara4Code.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFuncPara4Code.UpdDate);
}
else if (strAttributeName  ==  conFuncPara4Code.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conFuncPara4Code.UpdUser);
}
else if (strAttributeName  ==  conFuncPara4Code.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFuncPara4Code.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conFuncPara4Code.FuncParaId4Code  ==  _AttributeName[intIndex])
{
return mstrFuncParaId4Code;
}
else if (conFuncPara4Code.ParaName  ==  _AttributeName[intIndex])
{
return mstrParaName;
}
else if (conFuncPara4Code.ParaCnName  ==  _AttributeName[intIndex])
{
return mstrParaCnName;
}
else if (conFuncPara4Code.DataTypeId  ==  _AttributeName[intIndex])
{
return mstrDataTypeId;
}
else if (conFuncPara4Code.ParameterType  ==  _AttributeName[intIndex])
{
return mstrParameterType;
}
else if (conFuncPara4Code.ParameterTypeFullName  ==  _AttributeName[intIndex])
{
return mstrParameterTypeFullName;
}
else if (conFuncPara4Code.IsByRef  ==  _AttributeName[intIndex])
{
return mbolIsByRef;
}
else if (conFuncPara4Code.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conFuncPara4Code.IsTemplate  ==  _AttributeName[intIndex])
{
return mbolIsTemplate;
}
else if (conFuncPara4Code.FuncPurposeId  ==  _AttributeName[intIndex])
{
return mstrFuncPurposeId;
}
else if (conFuncPara4Code.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conFuncPara4Code.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conFuncPara4Code.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conFuncPara4Code.FuncParaId4Code  ==  _AttributeName[intIndex])
{
mstrFuncParaId4Code = value.ToString();
 AddUpdatedFld(conFuncPara4Code.FuncParaId4Code);
}
else if (conFuncPara4Code.ParaName  ==  _AttributeName[intIndex])
{
mstrParaName = value.ToString();
 AddUpdatedFld(conFuncPara4Code.ParaName);
}
else if (conFuncPara4Code.ParaCnName  ==  _AttributeName[intIndex])
{
mstrParaCnName = value.ToString();
 AddUpdatedFld(conFuncPara4Code.ParaCnName);
}
else if (conFuncPara4Code.DataTypeId  ==  _AttributeName[intIndex])
{
mstrDataTypeId = value.ToString();
 AddUpdatedFld(conFuncPara4Code.DataTypeId);
}
else if (conFuncPara4Code.ParameterType  ==  _AttributeName[intIndex])
{
mstrParameterType = value.ToString();
 AddUpdatedFld(conFuncPara4Code.ParameterType);
}
else if (conFuncPara4Code.ParameterTypeFullName  ==  _AttributeName[intIndex])
{
mstrParameterTypeFullName = value.ToString();
 AddUpdatedFld(conFuncPara4Code.ParameterTypeFullName);
}
else if (conFuncPara4Code.IsByRef  ==  _AttributeName[intIndex])
{
mbolIsByRef = TransNullToBool(value.ToString());
 AddUpdatedFld(conFuncPara4Code.IsByRef);
}
else if (conFuncPara4Code.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conFuncPara4Code.PrjId);
}
else if (conFuncPara4Code.IsTemplate  ==  _AttributeName[intIndex])
{
mbolIsTemplate = TransNullToBool(value.ToString());
 AddUpdatedFld(conFuncPara4Code.IsTemplate);
}
else if (conFuncPara4Code.FuncPurposeId  ==  _AttributeName[intIndex])
{
mstrFuncPurposeId = value.ToString();
 AddUpdatedFld(conFuncPara4Code.FuncPurposeId);
}
else if (conFuncPara4Code.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFuncPara4Code.UpdDate);
}
else if (conFuncPara4Code.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conFuncPara4Code.UpdUser);
}
else if (conFuncPara4Code.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFuncPara4Code.Memo);
}
}
}

/// <summary>
/// 函数参数Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncParaId4Code
{
get
{
return mstrFuncParaId4Code;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncParaId4Code = value;
}
else
{
 mstrFuncParaId4Code = value;
}
//记录修改过的字段
 AddUpdatedFld(conFuncPara4Code.FuncParaId4Code);
}
}
/// <summary>
/// 参数名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParaName
{
get
{
return mstrParaName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParaName = value;
}
else
{
 mstrParaName = value;
}
//记录修改过的字段
 AddUpdatedFld(conFuncPara4Code.ParaName);
}
}
/// <summary>
/// 参数中文名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParaCnName
{
get
{
return mstrParaCnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParaCnName = value;
}
else
{
 mstrParaCnName = value;
}
//记录修改过的字段
 AddUpdatedFld(conFuncPara4Code.ParaCnName);
}
}
/// <summary>
/// 数据类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataTypeId
{
get
{
return mstrDataTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataTypeId = value;
}
else
{
 mstrDataTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conFuncPara4Code.DataTypeId);
}
}
/// <summary>
/// 参数类型(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParameterType
{
get
{
return mstrParameterType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParameterType = value;
}
else
{
 mstrParameterType = value;
}
//记录修改过的字段
 AddUpdatedFld(conFuncPara4Code.ParameterType);
}
}
/// <summary>
/// 参数类型全名(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParameterTypeFullName
{
get
{
return mstrParameterTypeFullName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParameterTypeFullName = value;
}
else
{
 mstrParameterTypeFullName = value;
}
//记录修改过的字段
 AddUpdatedFld(conFuncPara4Code.ParameterTypeFullName);
}
}
/// <summary>
/// 是否引用型参数(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsByRef
{
get
{
return mbolIsByRef;
}
set
{
 mbolIsByRef = value;
//记录修改过的字段
 AddUpdatedFld(conFuncPara4Code.IsByRef);
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
 AddUpdatedFld(conFuncPara4Code.PrjId);
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
 AddUpdatedFld(conFuncPara4Code.IsTemplate);
}
}
/// <summary>
/// 函数用途Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncPurposeId
{
get
{
return mstrFuncPurposeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncPurposeId = value;
}
else
{
 mstrFuncPurposeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conFuncPara4Code.FuncPurposeId);
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
 AddUpdatedFld(conFuncPara4Code.UpdDate);
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
 AddUpdatedFld(conFuncPara4Code.UpdUser);
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
 AddUpdatedFld(conFuncPara4Code.Memo);
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
  return mstrFuncParaId4Code;
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
  return mstrParaName;
 }
 }
}
 /// <summary>
 /// 函数参数4Code(FuncPara4Code)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conFuncPara4Code
{
public const string _CurrTabName = "FuncPara4Code"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FuncParaId4Code"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"FuncParaId4Code", "ParaName", "ParaCnName", "DataTypeId", "ParameterType", "ParameterTypeFullName", "IsByRef", "PrjId", "IsTemplate", "FuncPurposeId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"FuncParaId4Code"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncParaId4Code = "FuncParaId4Code";    //函数参数Id

 /// <summary>
 /// 常量:"ParaName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParaName = "ParaName";    //参数名

 /// <summary>
 /// 常量:"ParaCnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParaCnName = "ParaCnName";    //参数中文名

 /// <summary>
 /// 常量:"DataTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataTypeId = "DataTypeId";    //数据类型Id

 /// <summary>
 /// 常量:"ParameterType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParameterType = "ParameterType";    //参数类型

 /// <summary>
 /// 常量:"ParameterTypeFullName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParameterTypeFullName = "ParameterTypeFullName";    //参数类型全名

 /// <summary>
 /// 常量:"IsByRef"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsByRef = "IsByRef";    //是否引用型参数

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"IsTemplate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsTemplate = "IsTemplate";    //是否模板

 /// <summary>
 /// 常量:"FuncPurposeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncPurposeId = "FuncPurposeId";    //函数用途Id

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