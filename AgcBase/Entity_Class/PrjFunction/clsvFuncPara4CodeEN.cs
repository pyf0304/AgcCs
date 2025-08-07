
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFuncPara4CodeEN
 表名:vFuncPara4Code(00050385)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:36:47
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
 /// 表vFuncPara4Code的关键字(FuncParaId4Code)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_FuncParaId4Code_vFuncPara4Code
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
public K_FuncParaId4Code_vFuncPara4Code(string strFuncParaId4Code)
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
 /// <returns>返回:[K_FuncParaId4Code_vFuncPara4Code]类型的对象</returns>
public static implicit operator K_FuncParaId4Code_vFuncPara4Code(string value)
{
return new K_FuncParaId4Code_vFuncPara4Code(value);
}
}
 /// <summary>
 /// v函数参数4Code(vFuncPara4Code)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvFuncPara4CodeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vFuncPara4Code"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "FuncParaId4Code"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 22;
public static string[] _AttributeName = new string[] {"FuncParaId4Code", "ParaName", "ParaCnName", "DataTypeId", "DataTypeName", "DataCnName", "CsType", "JavaType", "JavaObjType", "SwiftType", "IsNeedQuote", "OraDbType", "MySqlType", "ParameterType", "ParameterTypeFullName", "IsByRef", "PrjId", "FuncPurposeId", "UpdDate", "UpdUser", "Memo", "FuncCount"};

protected string mstrFuncParaId4Code;    //函数参数Id
protected string mstrParaName;    //参数名
protected string mstrParaCnName;    //参数中文名
protected string mstrDataTypeId;    //数据类型Id
protected string mstrDataTypeName;    //数据类型名称
protected string mstrDataCnName;    //数据类型中文名称
protected string mstrCsType;    //CS类型
protected string mstrJavaType;    //JAVA类型
protected string mstrJavaObjType;    //JAVA对象类型
protected string mstrSwiftType;    //SwiftType
protected bool mbolIsNeedQuote;    //是否需要引号
protected string mstrOraDbType;    //Ora数据类型
protected string mstrMySqlType;    //MySqlType
protected string mstrParameterType;    //参数类型
protected string mstrParameterTypeFullName;    //参数类型全名
protected bool mbolIsByRef;    //是否引用型参数
protected string mstrPrjId;    //工程Id
protected string mstrFuncPurposeId;    //函数用途Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明
protected int? mintFuncCount;    //函数数目

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvFuncPara4CodeEN()
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
public clsvFuncPara4CodeEN(string strFuncParaId4Code)
 {
strFuncParaId4Code = strFuncParaId4Code.Replace("'", "''");
if (strFuncParaId4Code.Length > 8)
{
throw new Exception("在表:vFuncPara4Code中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strFuncParaId4Code)  ==  true)
{
throw new Exception("在表:vFuncPara4Code中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convFuncPara4Code.FuncParaId4Code)
{
return mstrFuncParaId4Code;
}
else if (strAttributeName  ==  convFuncPara4Code.ParaName)
{
return mstrParaName;
}
else if (strAttributeName  ==  convFuncPara4Code.ParaCnName)
{
return mstrParaCnName;
}
else if (strAttributeName  ==  convFuncPara4Code.DataTypeId)
{
return mstrDataTypeId;
}
else if (strAttributeName  ==  convFuncPara4Code.DataTypeName)
{
return mstrDataTypeName;
}
else if (strAttributeName  ==  convFuncPara4Code.DataCnName)
{
return mstrDataCnName;
}
else if (strAttributeName  ==  convFuncPara4Code.CsType)
{
return mstrCsType;
}
else if (strAttributeName  ==  convFuncPara4Code.JavaType)
{
return mstrJavaType;
}
else if (strAttributeName  ==  convFuncPara4Code.JavaObjType)
{
return mstrJavaObjType;
}
else if (strAttributeName  ==  convFuncPara4Code.SwiftType)
{
return mstrSwiftType;
}
else if (strAttributeName  ==  convFuncPara4Code.IsNeedQuote)
{
return mbolIsNeedQuote;
}
else if (strAttributeName  ==  convFuncPara4Code.OraDbType)
{
return mstrOraDbType;
}
else if (strAttributeName  ==  convFuncPara4Code.MySqlType)
{
return mstrMySqlType;
}
else if (strAttributeName  ==  convFuncPara4Code.ParameterType)
{
return mstrParameterType;
}
else if (strAttributeName  ==  convFuncPara4Code.ParameterTypeFullName)
{
return mstrParameterTypeFullName;
}
else if (strAttributeName  ==  convFuncPara4Code.IsByRef)
{
return mbolIsByRef;
}
else if (strAttributeName  ==  convFuncPara4Code.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convFuncPara4Code.FuncPurposeId)
{
return mstrFuncPurposeId;
}
else if (strAttributeName  ==  convFuncPara4Code.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convFuncPara4Code.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convFuncPara4Code.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convFuncPara4Code.FuncCount)
{
return mintFuncCount;
}
return null;
}
set
{
if (strAttributeName  ==  convFuncPara4Code.FuncParaId4Code)
{
mstrFuncParaId4Code = value.ToString();
 AddUpdatedFld(convFuncPara4Code.FuncParaId4Code);
}
else if (strAttributeName  ==  convFuncPara4Code.ParaName)
{
mstrParaName = value.ToString();
 AddUpdatedFld(convFuncPara4Code.ParaName);
}
else if (strAttributeName  ==  convFuncPara4Code.ParaCnName)
{
mstrParaCnName = value.ToString();
 AddUpdatedFld(convFuncPara4Code.ParaCnName);
}
else if (strAttributeName  ==  convFuncPara4Code.DataTypeId)
{
mstrDataTypeId = value.ToString();
 AddUpdatedFld(convFuncPara4Code.DataTypeId);
}
else if (strAttributeName  ==  convFuncPara4Code.DataTypeName)
{
mstrDataTypeName = value.ToString();
 AddUpdatedFld(convFuncPara4Code.DataTypeName);
}
else if (strAttributeName  ==  convFuncPara4Code.DataCnName)
{
mstrDataCnName = value.ToString();
 AddUpdatedFld(convFuncPara4Code.DataCnName);
}
else if (strAttributeName  ==  convFuncPara4Code.CsType)
{
mstrCsType = value.ToString();
 AddUpdatedFld(convFuncPara4Code.CsType);
}
else if (strAttributeName  ==  convFuncPara4Code.JavaType)
{
mstrJavaType = value.ToString();
 AddUpdatedFld(convFuncPara4Code.JavaType);
}
else if (strAttributeName  ==  convFuncPara4Code.JavaObjType)
{
mstrJavaObjType = value.ToString();
 AddUpdatedFld(convFuncPara4Code.JavaObjType);
}
else if (strAttributeName  ==  convFuncPara4Code.SwiftType)
{
mstrSwiftType = value.ToString();
 AddUpdatedFld(convFuncPara4Code.SwiftType);
}
else if (strAttributeName  ==  convFuncPara4Code.IsNeedQuote)
{
mbolIsNeedQuote = TransNullToBool(value.ToString());
 AddUpdatedFld(convFuncPara4Code.IsNeedQuote);
}
else if (strAttributeName  ==  convFuncPara4Code.OraDbType)
{
mstrOraDbType = value.ToString();
 AddUpdatedFld(convFuncPara4Code.OraDbType);
}
else if (strAttributeName  ==  convFuncPara4Code.MySqlType)
{
mstrMySqlType = value.ToString();
 AddUpdatedFld(convFuncPara4Code.MySqlType);
}
else if (strAttributeName  ==  convFuncPara4Code.ParameterType)
{
mstrParameterType = value.ToString();
 AddUpdatedFld(convFuncPara4Code.ParameterType);
}
else if (strAttributeName  ==  convFuncPara4Code.ParameterTypeFullName)
{
mstrParameterTypeFullName = value.ToString();
 AddUpdatedFld(convFuncPara4Code.ParameterTypeFullName);
}
else if (strAttributeName  ==  convFuncPara4Code.IsByRef)
{
mbolIsByRef = TransNullToBool(value.ToString());
 AddUpdatedFld(convFuncPara4Code.IsByRef);
}
else if (strAttributeName  ==  convFuncPara4Code.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convFuncPara4Code.PrjId);
}
else if (strAttributeName  ==  convFuncPara4Code.FuncPurposeId)
{
mstrFuncPurposeId = value.ToString();
 AddUpdatedFld(convFuncPara4Code.FuncPurposeId);
}
else if (strAttributeName  ==  convFuncPara4Code.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFuncPara4Code.UpdDate);
}
else if (strAttributeName  ==  convFuncPara4Code.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFuncPara4Code.UpdUser);
}
else if (strAttributeName  ==  convFuncPara4Code.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFuncPara4Code.Memo);
}
else if (strAttributeName  ==  convFuncPara4Code.FuncCount)
{
mintFuncCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convFuncPara4Code.FuncCount);
}
}
}
public object this[int intIndex]
{
get
{
if (convFuncPara4Code.FuncParaId4Code  ==  _AttributeName[intIndex])
{
return mstrFuncParaId4Code;
}
else if (convFuncPara4Code.ParaName  ==  _AttributeName[intIndex])
{
return mstrParaName;
}
else if (convFuncPara4Code.ParaCnName  ==  _AttributeName[intIndex])
{
return mstrParaCnName;
}
else if (convFuncPara4Code.DataTypeId  ==  _AttributeName[intIndex])
{
return mstrDataTypeId;
}
else if (convFuncPara4Code.DataTypeName  ==  _AttributeName[intIndex])
{
return mstrDataTypeName;
}
else if (convFuncPara4Code.DataCnName  ==  _AttributeName[intIndex])
{
return mstrDataCnName;
}
else if (convFuncPara4Code.CsType  ==  _AttributeName[intIndex])
{
return mstrCsType;
}
else if (convFuncPara4Code.JavaType  ==  _AttributeName[intIndex])
{
return mstrJavaType;
}
else if (convFuncPara4Code.JavaObjType  ==  _AttributeName[intIndex])
{
return mstrJavaObjType;
}
else if (convFuncPara4Code.SwiftType  ==  _AttributeName[intIndex])
{
return mstrSwiftType;
}
else if (convFuncPara4Code.IsNeedQuote  ==  _AttributeName[intIndex])
{
return mbolIsNeedQuote;
}
else if (convFuncPara4Code.OraDbType  ==  _AttributeName[intIndex])
{
return mstrOraDbType;
}
else if (convFuncPara4Code.MySqlType  ==  _AttributeName[intIndex])
{
return mstrMySqlType;
}
else if (convFuncPara4Code.ParameterType  ==  _AttributeName[intIndex])
{
return mstrParameterType;
}
else if (convFuncPara4Code.ParameterTypeFullName  ==  _AttributeName[intIndex])
{
return mstrParameterTypeFullName;
}
else if (convFuncPara4Code.IsByRef  ==  _AttributeName[intIndex])
{
return mbolIsByRef;
}
else if (convFuncPara4Code.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convFuncPara4Code.FuncPurposeId  ==  _AttributeName[intIndex])
{
return mstrFuncPurposeId;
}
else if (convFuncPara4Code.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convFuncPara4Code.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convFuncPara4Code.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (convFuncPara4Code.FuncCount  ==  _AttributeName[intIndex])
{
return mintFuncCount;
}
return null;
}
set
{
if (convFuncPara4Code.FuncParaId4Code  ==  _AttributeName[intIndex])
{
mstrFuncParaId4Code = value.ToString();
 AddUpdatedFld(convFuncPara4Code.FuncParaId4Code);
}
else if (convFuncPara4Code.ParaName  ==  _AttributeName[intIndex])
{
mstrParaName = value.ToString();
 AddUpdatedFld(convFuncPara4Code.ParaName);
}
else if (convFuncPara4Code.ParaCnName  ==  _AttributeName[intIndex])
{
mstrParaCnName = value.ToString();
 AddUpdatedFld(convFuncPara4Code.ParaCnName);
}
else if (convFuncPara4Code.DataTypeId  ==  _AttributeName[intIndex])
{
mstrDataTypeId = value.ToString();
 AddUpdatedFld(convFuncPara4Code.DataTypeId);
}
else if (convFuncPara4Code.DataTypeName  ==  _AttributeName[intIndex])
{
mstrDataTypeName = value.ToString();
 AddUpdatedFld(convFuncPara4Code.DataTypeName);
}
else if (convFuncPara4Code.DataCnName  ==  _AttributeName[intIndex])
{
mstrDataCnName = value.ToString();
 AddUpdatedFld(convFuncPara4Code.DataCnName);
}
else if (convFuncPara4Code.CsType  ==  _AttributeName[intIndex])
{
mstrCsType = value.ToString();
 AddUpdatedFld(convFuncPara4Code.CsType);
}
else if (convFuncPara4Code.JavaType  ==  _AttributeName[intIndex])
{
mstrJavaType = value.ToString();
 AddUpdatedFld(convFuncPara4Code.JavaType);
}
else if (convFuncPara4Code.JavaObjType  ==  _AttributeName[intIndex])
{
mstrJavaObjType = value.ToString();
 AddUpdatedFld(convFuncPara4Code.JavaObjType);
}
else if (convFuncPara4Code.SwiftType  ==  _AttributeName[intIndex])
{
mstrSwiftType = value.ToString();
 AddUpdatedFld(convFuncPara4Code.SwiftType);
}
else if (convFuncPara4Code.IsNeedQuote  ==  _AttributeName[intIndex])
{
mbolIsNeedQuote = TransNullToBool(value.ToString());
 AddUpdatedFld(convFuncPara4Code.IsNeedQuote);
}
else if (convFuncPara4Code.OraDbType  ==  _AttributeName[intIndex])
{
mstrOraDbType = value.ToString();
 AddUpdatedFld(convFuncPara4Code.OraDbType);
}
else if (convFuncPara4Code.MySqlType  ==  _AttributeName[intIndex])
{
mstrMySqlType = value.ToString();
 AddUpdatedFld(convFuncPara4Code.MySqlType);
}
else if (convFuncPara4Code.ParameterType  ==  _AttributeName[intIndex])
{
mstrParameterType = value.ToString();
 AddUpdatedFld(convFuncPara4Code.ParameterType);
}
else if (convFuncPara4Code.ParameterTypeFullName  ==  _AttributeName[intIndex])
{
mstrParameterTypeFullName = value.ToString();
 AddUpdatedFld(convFuncPara4Code.ParameterTypeFullName);
}
else if (convFuncPara4Code.IsByRef  ==  _AttributeName[intIndex])
{
mbolIsByRef = TransNullToBool(value.ToString());
 AddUpdatedFld(convFuncPara4Code.IsByRef);
}
else if (convFuncPara4Code.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convFuncPara4Code.PrjId);
}
else if (convFuncPara4Code.FuncPurposeId  ==  _AttributeName[intIndex])
{
mstrFuncPurposeId = value.ToString();
 AddUpdatedFld(convFuncPara4Code.FuncPurposeId);
}
else if (convFuncPara4Code.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFuncPara4Code.UpdDate);
}
else if (convFuncPara4Code.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFuncPara4Code.UpdUser);
}
else if (convFuncPara4Code.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFuncPara4Code.Memo);
}
else if (convFuncPara4Code.FuncCount  ==  _AttributeName[intIndex])
{
mintFuncCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convFuncPara4Code.FuncCount);
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
 AddUpdatedFld(convFuncPara4Code.FuncParaId4Code);
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
 AddUpdatedFld(convFuncPara4Code.ParaName);
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
 AddUpdatedFld(convFuncPara4Code.ParaCnName);
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
 AddUpdatedFld(convFuncPara4Code.DataTypeId);
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
 AddUpdatedFld(convFuncPara4Code.DataTypeName);
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
 AddUpdatedFld(convFuncPara4Code.DataCnName);
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
 AddUpdatedFld(convFuncPara4Code.CsType);
}
}
/// <summary>
/// JAVA类型(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string JavaType
{
get
{
return mstrJavaType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrJavaType = value;
}
else
{
 mstrJavaType = value;
}
//记录修改过的字段
 AddUpdatedFld(convFuncPara4Code.JavaType);
}
}
/// <summary>
/// JAVA对象类型(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string JavaObjType
{
get
{
return mstrJavaObjType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrJavaObjType = value;
}
else
{
 mstrJavaObjType = value;
}
//记录修改过的字段
 AddUpdatedFld(convFuncPara4Code.JavaObjType);
}
}
/// <summary>
/// SwiftType(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SwiftType
{
get
{
return mstrSwiftType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSwiftType = value;
}
else
{
 mstrSwiftType = value;
}
//记录修改过的字段
 AddUpdatedFld(convFuncPara4Code.SwiftType);
}
}
/// <summary>
/// 是否需要引号(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsNeedQuote
{
get
{
return mbolIsNeedQuote;
}
set
{
 mbolIsNeedQuote = value;
//记录修改过的字段
 AddUpdatedFld(convFuncPara4Code.IsNeedQuote);
}
}
/// <summary>
/// Ora数据类型(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OraDbType
{
get
{
return mstrOraDbType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOraDbType = value;
}
else
{
 mstrOraDbType = value;
}
//记录修改过的字段
 AddUpdatedFld(convFuncPara4Code.OraDbType);
}
}
/// <summary>
/// MySqlType(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MySqlType
{
get
{
return mstrMySqlType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMySqlType = value;
}
else
{
 mstrMySqlType = value;
}
//记录修改过的字段
 AddUpdatedFld(convFuncPara4Code.MySqlType);
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
 AddUpdatedFld(convFuncPara4Code.ParameterType);
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
 AddUpdatedFld(convFuncPara4Code.ParameterTypeFullName);
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
 AddUpdatedFld(convFuncPara4Code.IsByRef);
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
 AddUpdatedFld(convFuncPara4Code.PrjId);
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
 AddUpdatedFld(convFuncPara4Code.FuncPurposeId);
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
 AddUpdatedFld(convFuncPara4Code.UpdDate);
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
 AddUpdatedFld(convFuncPara4Code.UpdUser);
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
 AddUpdatedFld(convFuncPara4Code.Memo);
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
 AddUpdatedFld(convFuncPara4Code.FuncCount);
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
}
 /// <summary>
 /// v函数参数4Code(vFuncPara4Code)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convFuncPara4Code
{
public const string _CurrTabName = "vFuncPara4Code"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FuncParaId4Code"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"FuncParaId4Code", "ParaName", "ParaCnName", "DataTypeId", "DataTypeName", "DataCnName", "CsType", "JavaType", "JavaObjType", "SwiftType", "IsNeedQuote", "OraDbType", "MySqlType", "ParameterType", "ParameterTypeFullName", "IsByRef", "PrjId", "FuncPurposeId", "UpdDate", "UpdUser", "Memo", "FuncCount"};
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
 /// 常量:"JavaType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string JavaType = "JavaType";    //JAVA类型

 /// <summary>
 /// 常量:"JavaObjType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string JavaObjType = "JavaObjType";    //JAVA对象类型

 /// <summary>
 /// 常量:"SwiftType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SwiftType = "SwiftType";    //SwiftType

 /// <summary>
 /// 常量:"IsNeedQuote"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsNeedQuote = "IsNeedQuote";    //是否需要引号

 /// <summary>
 /// 常量:"OraDbType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OraDbType = "OraDbType";    //Ora数据类型

 /// <summary>
 /// 常量:"MySqlType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MySqlType = "MySqlType";    //MySqlType

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

 /// <summary>
 /// 常量:"FuncCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncCount = "FuncCount";    //函数数目
}

}