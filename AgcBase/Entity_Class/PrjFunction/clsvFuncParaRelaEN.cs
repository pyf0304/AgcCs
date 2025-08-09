
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFuncParaRelaEN
 表名:vFuncParaRela(00050499)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:02:31
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
 /// 表vFuncParaRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vFuncParaRela
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngmId">表关键字</param>
public K_mId_vFuncParaRela(long lngmId)
{
if (IsValid(lngmId)) Value = lngmId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngmId)
{
if (lngmId == 0) return false;
if (lngmId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_mId_vFuncParaRela]类型的对象</returns>
public static implicit operator K_mId_vFuncParaRela(long value)
{
return new K_mId_vFuncParaRela(value);
}
}
 /// <summary>
 /// vFuncParaRela(vFuncParaRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvFuncParaRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vFuncParaRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 27;
public static string[] _AttributeName = new string[] {"mId", "FuncParaId4Code", "ParaName", "ParaCnName", "DataTypeId", "DataTypeName", "DataCnName", "CsType", "JavaType", "JavaObjType", "SwiftType", "IsNeedQuote", "OraDbType", "MySqlType", "ParameterType", "ParameterTypeFullName", "IsByRef", "PrjId", "FuncId4Code", "FuncName4Code", "FunctionSignature", "IsAsyncFunc", "IsSysFunction", "OrderNum", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
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
protected string mstrFuncId4Code;    //函数Id4Code
protected string mstrFuncName4Code;    //函数名4Code
protected string mstrFunctionSignature;    //函数签名
protected bool mbolIsAsyncFunc;    //是否异步函数
protected bool mbolIsSysFunction;    //是否系统函数
protected int mintOrderNum;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvFuncParaRelaEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:mId</param>
public clsvFuncParaRelaEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
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
if (strAttributeName  ==  convFuncParaRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convFuncParaRela.FuncParaId4Code)
{
return mstrFuncParaId4Code;
}
else if (strAttributeName  ==  convFuncParaRela.ParaName)
{
return mstrParaName;
}
else if (strAttributeName  ==  convFuncParaRela.ParaCnName)
{
return mstrParaCnName;
}
else if (strAttributeName  ==  convFuncParaRela.DataTypeId)
{
return mstrDataTypeId;
}
else if (strAttributeName  ==  convFuncParaRela.DataTypeName)
{
return mstrDataTypeName;
}
else if (strAttributeName  ==  convFuncParaRela.DataCnName)
{
return mstrDataCnName;
}
else if (strAttributeName  ==  convFuncParaRela.CsType)
{
return mstrCsType;
}
else if (strAttributeName  ==  convFuncParaRela.JavaType)
{
return mstrJavaType;
}
else if (strAttributeName  ==  convFuncParaRela.JavaObjType)
{
return mstrJavaObjType;
}
else if (strAttributeName  ==  convFuncParaRela.SwiftType)
{
return mstrSwiftType;
}
else if (strAttributeName  ==  convFuncParaRela.IsNeedQuote)
{
return mbolIsNeedQuote;
}
else if (strAttributeName  ==  convFuncParaRela.OraDbType)
{
return mstrOraDbType;
}
else if (strAttributeName  ==  convFuncParaRela.MySqlType)
{
return mstrMySqlType;
}
else if (strAttributeName  ==  convFuncParaRela.ParameterType)
{
return mstrParameterType;
}
else if (strAttributeName  ==  convFuncParaRela.ParameterTypeFullName)
{
return mstrParameterTypeFullName;
}
else if (strAttributeName  ==  convFuncParaRela.IsByRef)
{
return mbolIsByRef;
}
else if (strAttributeName  ==  convFuncParaRela.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convFuncParaRela.FuncId4Code)
{
return mstrFuncId4Code;
}
else if (strAttributeName  ==  convFuncParaRela.FuncName4Code)
{
return mstrFuncName4Code;
}
else if (strAttributeName  ==  convFuncParaRela.FunctionSignature)
{
return mstrFunctionSignature;
}
else if (strAttributeName  ==  convFuncParaRela.IsAsyncFunc)
{
return mbolIsAsyncFunc;
}
else if (strAttributeName  ==  convFuncParaRela.IsSysFunction)
{
return mbolIsSysFunction;
}
else if (strAttributeName  ==  convFuncParaRela.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convFuncParaRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convFuncParaRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convFuncParaRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convFuncParaRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convFuncParaRela.mId);
}
else if (strAttributeName  ==  convFuncParaRela.FuncParaId4Code)
{
mstrFuncParaId4Code = value.ToString();
 AddUpdatedFld(convFuncParaRela.FuncParaId4Code);
}
else if (strAttributeName  ==  convFuncParaRela.ParaName)
{
mstrParaName = value.ToString();
 AddUpdatedFld(convFuncParaRela.ParaName);
}
else if (strAttributeName  ==  convFuncParaRela.ParaCnName)
{
mstrParaCnName = value.ToString();
 AddUpdatedFld(convFuncParaRela.ParaCnName);
}
else if (strAttributeName  ==  convFuncParaRela.DataTypeId)
{
mstrDataTypeId = value.ToString();
 AddUpdatedFld(convFuncParaRela.DataTypeId);
}
else if (strAttributeName  ==  convFuncParaRela.DataTypeName)
{
mstrDataTypeName = value.ToString();
 AddUpdatedFld(convFuncParaRela.DataTypeName);
}
else if (strAttributeName  ==  convFuncParaRela.DataCnName)
{
mstrDataCnName = value.ToString();
 AddUpdatedFld(convFuncParaRela.DataCnName);
}
else if (strAttributeName  ==  convFuncParaRela.CsType)
{
mstrCsType = value.ToString();
 AddUpdatedFld(convFuncParaRela.CsType);
}
else if (strAttributeName  ==  convFuncParaRela.JavaType)
{
mstrJavaType = value.ToString();
 AddUpdatedFld(convFuncParaRela.JavaType);
}
else if (strAttributeName  ==  convFuncParaRela.JavaObjType)
{
mstrJavaObjType = value.ToString();
 AddUpdatedFld(convFuncParaRela.JavaObjType);
}
else if (strAttributeName  ==  convFuncParaRela.SwiftType)
{
mstrSwiftType = value.ToString();
 AddUpdatedFld(convFuncParaRela.SwiftType);
}
else if (strAttributeName  ==  convFuncParaRela.IsNeedQuote)
{
mbolIsNeedQuote = TransNullToBool(value.ToString());
 AddUpdatedFld(convFuncParaRela.IsNeedQuote);
}
else if (strAttributeName  ==  convFuncParaRela.OraDbType)
{
mstrOraDbType = value.ToString();
 AddUpdatedFld(convFuncParaRela.OraDbType);
}
else if (strAttributeName  ==  convFuncParaRela.MySqlType)
{
mstrMySqlType = value.ToString();
 AddUpdatedFld(convFuncParaRela.MySqlType);
}
else if (strAttributeName  ==  convFuncParaRela.ParameterType)
{
mstrParameterType = value.ToString();
 AddUpdatedFld(convFuncParaRela.ParameterType);
}
else if (strAttributeName  ==  convFuncParaRela.ParameterTypeFullName)
{
mstrParameterTypeFullName = value.ToString();
 AddUpdatedFld(convFuncParaRela.ParameterTypeFullName);
}
else if (strAttributeName  ==  convFuncParaRela.IsByRef)
{
mbolIsByRef = TransNullToBool(value.ToString());
 AddUpdatedFld(convFuncParaRela.IsByRef);
}
else if (strAttributeName  ==  convFuncParaRela.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convFuncParaRela.PrjId);
}
else if (strAttributeName  ==  convFuncParaRela.FuncId4Code)
{
mstrFuncId4Code = value.ToString();
 AddUpdatedFld(convFuncParaRela.FuncId4Code);
}
else if (strAttributeName  ==  convFuncParaRela.FuncName4Code)
{
mstrFuncName4Code = value.ToString();
 AddUpdatedFld(convFuncParaRela.FuncName4Code);
}
else if (strAttributeName  ==  convFuncParaRela.FunctionSignature)
{
mstrFunctionSignature = value.ToString();
 AddUpdatedFld(convFuncParaRela.FunctionSignature);
}
else if (strAttributeName  ==  convFuncParaRela.IsAsyncFunc)
{
mbolIsAsyncFunc = TransNullToBool(value.ToString());
 AddUpdatedFld(convFuncParaRela.IsAsyncFunc);
}
else if (strAttributeName  ==  convFuncParaRela.IsSysFunction)
{
mbolIsSysFunction = TransNullToBool(value.ToString());
 AddUpdatedFld(convFuncParaRela.IsSysFunction);
}
else if (strAttributeName  ==  convFuncParaRela.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFuncParaRela.OrderNum);
}
else if (strAttributeName  ==  convFuncParaRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFuncParaRela.UpdDate);
}
else if (strAttributeName  ==  convFuncParaRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFuncParaRela.UpdUser);
}
else if (strAttributeName  ==  convFuncParaRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFuncParaRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convFuncParaRela.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (convFuncParaRela.FuncParaId4Code  ==  _AttributeName[intIndex])
{
return mstrFuncParaId4Code;
}
else if (convFuncParaRela.ParaName  ==  _AttributeName[intIndex])
{
return mstrParaName;
}
else if (convFuncParaRela.ParaCnName  ==  _AttributeName[intIndex])
{
return mstrParaCnName;
}
else if (convFuncParaRela.DataTypeId  ==  _AttributeName[intIndex])
{
return mstrDataTypeId;
}
else if (convFuncParaRela.DataTypeName  ==  _AttributeName[intIndex])
{
return mstrDataTypeName;
}
else if (convFuncParaRela.DataCnName  ==  _AttributeName[intIndex])
{
return mstrDataCnName;
}
else if (convFuncParaRela.CsType  ==  _AttributeName[intIndex])
{
return mstrCsType;
}
else if (convFuncParaRela.JavaType  ==  _AttributeName[intIndex])
{
return mstrJavaType;
}
else if (convFuncParaRela.JavaObjType  ==  _AttributeName[intIndex])
{
return mstrJavaObjType;
}
else if (convFuncParaRela.SwiftType  ==  _AttributeName[intIndex])
{
return mstrSwiftType;
}
else if (convFuncParaRela.IsNeedQuote  ==  _AttributeName[intIndex])
{
return mbolIsNeedQuote;
}
else if (convFuncParaRela.OraDbType  ==  _AttributeName[intIndex])
{
return mstrOraDbType;
}
else if (convFuncParaRela.MySqlType  ==  _AttributeName[intIndex])
{
return mstrMySqlType;
}
else if (convFuncParaRela.ParameterType  ==  _AttributeName[intIndex])
{
return mstrParameterType;
}
else if (convFuncParaRela.ParameterTypeFullName  ==  _AttributeName[intIndex])
{
return mstrParameterTypeFullName;
}
else if (convFuncParaRela.IsByRef  ==  _AttributeName[intIndex])
{
return mbolIsByRef;
}
else if (convFuncParaRela.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convFuncParaRela.FuncId4Code  ==  _AttributeName[intIndex])
{
return mstrFuncId4Code;
}
else if (convFuncParaRela.FuncName4Code  ==  _AttributeName[intIndex])
{
return mstrFuncName4Code;
}
else if (convFuncParaRela.FunctionSignature  ==  _AttributeName[intIndex])
{
return mstrFunctionSignature;
}
else if (convFuncParaRela.IsAsyncFunc  ==  _AttributeName[intIndex])
{
return mbolIsAsyncFunc;
}
else if (convFuncParaRela.IsSysFunction  ==  _AttributeName[intIndex])
{
return mbolIsSysFunction;
}
else if (convFuncParaRela.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convFuncParaRela.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convFuncParaRela.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convFuncParaRela.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convFuncParaRela.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convFuncParaRela.mId);
}
else if (convFuncParaRela.FuncParaId4Code  ==  _AttributeName[intIndex])
{
mstrFuncParaId4Code = value.ToString();
 AddUpdatedFld(convFuncParaRela.FuncParaId4Code);
}
else if (convFuncParaRela.ParaName  ==  _AttributeName[intIndex])
{
mstrParaName = value.ToString();
 AddUpdatedFld(convFuncParaRela.ParaName);
}
else if (convFuncParaRela.ParaCnName  ==  _AttributeName[intIndex])
{
mstrParaCnName = value.ToString();
 AddUpdatedFld(convFuncParaRela.ParaCnName);
}
else if (convFuncParaRela.DataTypeId  ==  _AttributeName[intIndex])
{
mstrDataTypeId = value.ToString();
 AddUpdatedFld(convFuncParaRela.DataTypeId);
}
else if (convFuncParaRela.DataTypeName  ==  _AttributeName[intIndex])
{
mstrDataTypeName = value.ToString();
 AddUpdatedFld(convFuncParaRela.DataTypeName);
}
else if (convFuncParaRela.DataCnName  ==  _AttributeName[intIndex])
{
mstrDataCnName = value.ToString();
 AddUpdatedFld(convFuncParaRela.DataCnName);
}
else if (convFuncParaRela.CsType  ==  _AttributeName[intIndex])
{
mstrCsType = value.ToString();
 AddUpdatedFld(convFuncParaRela.CsType);
}
else if (convFuncParaRela.JavaType  ==  _AttributeName[intIndex])
{
mstrJavaType = value.ToString();
 AddUpdatedFld(convFuncParaRela.JavaType);
}
else if (convFuncParaRela.JavaObjType  ==  _AttributeName[intIndex])
{
mstrJavaObjType = value.ToString();
 AddUpdatedFld(convFuncParaRela.JavaObjType);
}
else if (convFuncParaRela.SwiftType  ==  _AttributeName[intIndex])
{
mstrSwiftType = value.ToString();
 AddUpdatedFld(convFuncParaRela.SwiftType);
}
else if (convFuncParaRela.IsNeedQuote  ==  _AttributeName[intIndex])
{
mbolIsNeedQuote = TransNullToBool(value.ToString());
 AddUpdatedFld(convFuncParaRela.IsNeedQuote);
}
else if (convFuncParaRela.OraDbType  ==  _AttributeName[intIndex])
{
mstrOraDbType = value.ToString();
 AddUpdatedFld(convFuncParaRela.OraDbType);
}
else if (convFuncParaRela.MySqlType  ==  _AttributeName[intIndex])
{
mstrMySqlType = value.ToString();
 AddUpdatedFld(convFuncParaRela.MySqlType);
}
else if (convFuncParaRela.ParameterType  ==  _AttributeName[intIndex])
{
mstrParameterType = value.ToString();
 AddUpdatedFld(convFuncParaRela.ParameterType);
}
else if (convFuncParaRela.ParameterTypeFullName  ==  _AttributeName[intIndex])
{
mstrParameterTypeFullName = value.ToString();
 AddUpdatedFld(convFuncParaRela.ParameterTypeFullName);
}
else if (convFuncParaRela.IsByRef  ==  _AttributeName[intIndex])
{
mbolIsByRef = TransNullToBool(value.ToString());
 AddUpdatedFld(convFuncParaRela.IsByRef);
}
else if (convFuncParaRela.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convFuncParaRela.PrjId);
}
else if (convFuncParaRela.FuncId4Code  ==  _AttributeName[intIndex])
{
mstrFuncId4Code = value.ToString();
 AddUpdatedFld(convFuncParaRela.FuncId4Code);
}
else if (convFuncParaRela.FuncName4Code  ==  _AttributeName[intIndex])
{
mstrFuncName4Code = value.ToString();
 AddUpdatedFld(convFuncParaRela.FuncName4Code);
}
else if (convFuncParaRela.FunctionSignature  ==  _AttributeName[intIndex])
{
mstrFunctionSignature = value.ToString();
 AddUpdatedFld(convFuncParaRela.FunctionSignature);
}
else if (convFuncParaRela.IsAsyncFunc  ==  _AttributeName[intIndex])
{
mbolIsAsyncFunc = TransNullToBool(value.ToString());
 AddUpdatedFld(convFuncParaRela.IsAsyncFunc);
}
else if (convFuncParaRela.IsSysFunction  ==  _AttributeName[intIndex])
{
mbolIsSysFunction = TransNullToBool(value.ToString());
 AddUpdatedFld(convFuncParaRela.IsSysFunction);
}
else if (convFuncParaRela.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFuncParaRela.OrderNum);
}
else if (convFuncParaRela.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFuncParaRela.UpdDate);
}
else if (convFuncParaRela.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFuncParaRela.UpdUser);
}
else if (convFuncParaRela.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFuncParaRela.Memo);
}
}
}

/// <summary>
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long mId
{
get
{
return mlngmId;
}
set
{
 mlngmId = value;
//记录修改过的字段
 AddUpdatedFld(convFuncParaRela.mId);
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
 AddUpdatedFld(convFuncParaRela.FuncParaId4Code);
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
 AddUpdatedFld(convFuncParaRela.ParaName);
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
 AddUpdatedFld(convFuncParaRela.ParaCnName);
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
 AddUpdatedFld(convFuncParaRela.DataTypeId);
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
 AddUpdatedFld(convFuncParaRela.DataTypeName);
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
 AddUpdatedFld(convFuncParaRela.DataCnName);
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
 AddUpdatedFld(convFuncParaRela.CsType);
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
 AddUpdatedFld(convFuncParaRela.JavaType);
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
 AddUpdatedFld(convFuncParaRela.JavaObjType);
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
 AddUpdatedFld(convFuncParaRela.SwiftType);
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
 AddUpdatedFld(convFuncParaRela.IsNeedQuote);
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
 AddUpdatedFld(convFuncParaRela.OraDbType);
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
 AddUpdatedFld(convFuncParaRela.MySqlType);
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
 AddUpdatedFld(convFuncParaRela.ParameterType);
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
 AddUpdatedFld(convFuncParaRela.ParameterTypeFullName);
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
 AddUpdatedFld(convFuncParaRela.IsByRef);
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
 AddUpdatedFld(convFuncParaRela.PrjId);
}
}
/// <summary>
/// 函数Id4Code(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncId4Code
{
get
{
return mstrFuncId4Code;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncId4Code = value;
}
else
{
 mstrFuncId4Code = value;
}
//记录修改过的字段
 AddUpdatedFld(convFuncParaRela.FuncId4Code);
}
}
/// <summary>
/// 函数名4Code(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncName4Code
{
get
{
return mstrFuncName4Code;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncName4Code = value;
}
else
{
 mstrFuncName4Code = value;
}
//记录修改过的字段
 AddUpdatedFld(convFuncParaRela.FuncName4Code);
}
}
/// <summary>
/// 函数签名(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FunctionSignature
{
get
{
return mstrFunctionSignature;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFunctionSignature = value;
}
else
{
 mstrFunctionSignature = value;
}
//记录修改过的字段
 AddUpdatedFld(convFuncParaRela.FunctionSignature);
}
}
/// <summary>
/// 是否异步函数(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsAsyncFunc
{
get
{
return mbolIsAsyncFunc;
}
set
{
 mbolIsAsyncFunc = value;
//记录修改过的字段
 AddUpdatedFld(convFuncParaRela.IsAsyncFunc);
}
}
/// <summary>
/// 是否系统函数(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsSysFunction
{
get
{
return mbolIsSysFunction;
}
set
{
 mbolIsSysFunction = value;
//记录修改过的字段
 AddUpdatedFld(convFuncParaRela.IsSysFunction);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(convFuncParaRela.OrderNum);
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
 AddUpdatedFld(convFuncParaRela.UpdDate);
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
 AddUpdatedFld(convFuncParaRela.UpdUser);
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
 AddUpdatedFld(convFuncParaRela.Memo);
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
  return mlngmId.ToString();
 }
 }
}
 /// <summary>
 /// vFuncParaRela(vFuncParaRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convFuncParaRela
{
public const string _CurrTabName = "vFuncParaRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "FuncParaId4Code", "ParaName", "ParaCnName", "DataTypeId", "DataTypeName", "DataCnName", "CsType", "JavaType", "JavaObjType", "SwiftType", "IsNeedQuote", "OraDbType", "MySqlType", "ParameterType", "ParameterTypeFullName", "IsByRef", "PrjId", "FuncId4Code", "FuncName4Code", "FunctionSignature", "IsAsyncFunc", "IsSysFunction", "OrderNum", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

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
 /// 常量:"FuncId4Code"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncId4Code = "FuncId4Code";    //函数Id4Code

 /// <summary>
 /// 常量:"FuncName4Code"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncName4Code = "FuncName4Code";    //函数名4Code

 /// <summary>
 /// 常量:"FunctionSignature"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FunctionSignature = "FunctionSignature";    //函数签名

 /// <summary>
 /// 常量:"IsAsyncFunc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsAsyncFunc = "IsAsyncFunc";    //是否异步函数

 /// <summary>
 /// 常量:"IsSysFunction"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSysFunction = "IsSysFunction";    //是否系统函数

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

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