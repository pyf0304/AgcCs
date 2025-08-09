
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCMFuncParaRelaEN
 表名:vCMFuncParaRela(00050509)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:11:36
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
 /// 表vCMFuncParaRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vCMFuncParaRela
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
public K_mId_vCMFuncParaRela(long lngmId)
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
 /// <returns>返回:[K_mId_vCMFuncParaRela]类型的对象</returns>
public static implicit operator K_mId_vCMFuncParaRela(long value)
{
return new K_mId_vCMFuncParaRela(value);
}
}
 /// <summary>
 /// vCM函数参数关系(vCMFuncParaRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvCMFuncParaRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vCMFuncParaRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 21;
public static string[] _AttributeName = new string[] {"mId", "CmFuncParaId", "ParaName", "ParaComments", "ParameterType", "DataTypeId", "DataTypeName", "CsType", "JavaType", "IsNeedQuote", "ParameterTypeFullName", "IsByRef", "ParaCnName", "CmFunctionId", "FunctionName", "FunctionSignature", "OrderNum", "PrjId", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrCmFuncParaId;    //函数参数Id
protected string mstrParaName;    //参数名
protected string mstrParaComments;    //参数注释
protected string mstrParameterType;    //参数类型
protected string mstrDataTypeId;    //数据类型Id
protected string mstrDataTypeName;    //数据类型名称
protected string mstrCsType;    //CS类型
protected string mstrJavaType;    //JAVA类型
protected bool mbolIsNeedQuote;    //是否需要引号
protected string mstrParameterTypeFullName;    //参数类型全名
protected bool mbolIsByRef;    //是否引用型参数
protected string mstrParaCnName;    //参数中文名
protected string mstrCmFunctionId;    //函数Id
protected string mstrFunctionName;    //功能名称
protected string mstrFunctionSignature;    //函数签名
protected int mintOrderNum;    //序号
protected string mstrPrjId;    //工程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvCMFuncParaRelaEN()
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
public clsvCMFuncParaRelaEN(long lngmId)
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
if (strAttributeName  ==  convCMFuncParaRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convCMFuncParaRela.CmFuncParaId)
{
return mstrCmFuncParaId;
}
else if (strAttributeName  ==  convCMFuncParaRela.ParaName)
{
return mstrParaName;
}
else if (strAttributeName  ==  convCMFuncParaRela.ParaComments)
{
return mstrParaComments;
}
else if (strAttributeName  ==  convCMFuncParaRela.ParameterType)
{
return mstrParameterType;
}
else if (strAttributeName  ==  convCMFuncParaRela.DataTypeId)
{
return mstrDataTypeId;
}
else if (strAttributeName  ==  convCMFuncParaRela.DataTypeName)
{
return mstrDataTypeName;
}
else if (strAttributeName  ==  convCMFuncParaRela.CsType)
{
return mstrCsType;
}
else if (strAttributeName  ==  convCMFuncParaRela.JavaType)
{
return mstrJavaType;
}
else if (strAttributeName  ==  convCMFuncParaRela.IsNeedQuote)
{
return mbolIsNeedQuote;
}
else if (strAttributeName  ==  convCMFuncParaRela.ParameterTypeFullName)
{
return mstrParameterTypeFullName;
}
else if (strAttributeName  ==  convCMFuncParaRela.IsByRef)
{
return mbolIsByRef;
}
else if (strAttributeName  ==  convCMFuncParaRela.ParaCnName)
{
return mstrParaCnName;
}
else if (strAttributeName  ==  convCMFuncParaRela.CmFunctionId)
{
return mstrCmFunctionId;
}
else if (strAttributeName  ==  convCMFuncParaRela.FunctionName)
{
return mstrFunctionName;
}
else if (strAttributeName  ==  convCMFuncParaRela.FunctionSignature)
{
return mstrFunctionSignature;
}
else if (strAttributeName  ==  convCMFuncParaRela.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convCMFuncParaRela.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convCMFuncParaRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convCMFuncParaRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convCMFuncParaRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convCMFuncParaRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMFuncParaRela.mId);
}
else if (strAttributeName  ==  convCMFuncParaRela.CmFuncParaId)
{
mstrCmFuncParaId = value.ToString();
 AddUpdatedFld(convCMFuncParaRela.CmFuncParaId);
}
else if (strAttributeName  ==  convCMFuncParaRela.ParaName)
{
mstrParaName = value.ToString();
 AddUpdatedFld(convCMFuncParaRela.ParaName);
}
else if (strAttributeName  ==  convCMFuncParaRela.ParaComments)
{
mstrParaComments = value.ToString();
 AddUpdatedFld(convCMFuncParaRela.ParaComments);
}
else if (strAttributeName  ==  convCMFuncParaRela.ParameterType)
{
mstrParameterType = value.ToString();
 AddUpdatedFld(convCMFuncParaRela.ParameterType);
}
else if (strAttributeName  ==  convCMFuncParaRela.DataTypeId)
{
mstrDataTypeId = value.ToString();
 AddUpdatedFld(convCMFuncParaRela.DataTypeId);
}
else if (strAttributeName  ==  convCMFuncParaRela.DataTypeName)
{
mstrDataTypeName = value.ToString();
 AddUpdatedFld(convCMFuncParaRela.DataTypeName);
}
else if (strAttributeName  ==  convCMFuncParaRela.CsType)
{
mstrCsType = value.ToString();
 AddUpdatedFld(convCMFuncParaRela.CsType);
}
else if (strAttributeName  ==  convCMFuncParaRela.JavaType)
{
mstrJavaType = value.ToString();
 AddUpdatedFld(convCMFuncParaRela.JavaType);
}
else if (strAttributeName  ==  convCMFuncParaRela.IsNeedQuote)
{
mbolIsNeedQuote = TransNullToBool(value.ToString());
 AddUpdatedFld(convCMFuncParaRela.IsNeedQuote);
}
else if (strAttributeName  ==  convCMFuncParaRela.ParameterTypeFullName)
{
mstrParameterTypeFullName = value.ToString();
 AddUpdatedFld(convCMFuncParaRela.ParameterTypeFullName);
}
else if (strAttributeName  ==  convCMFuncParaRela.IsByRef)
{
mbolIsByRef = TransNullToBool(value.ToString());
 AddUpdatedFld(convCMFuncParaRela.IsByRef);
}
else if (strAttributeName  ==  convCMFuncParaRela.ParaCnName)
{
mstrParaCnName = value.ToString();
 AddUpdatedFld(convCMFuncParaRela.ParaCnName);
}
else if (strAttributeName  ==  convCMFuncParaRela.CmFunctionId)
{
mstrCmFunctionId = value.ToString();
 AddUpdatedFld(convCMFuncParaRela.CmFunctionId);
}
else if (strAttributeName  ==  convCMFuncParaRela.FunctionName)
{
mstrFunctionName = value.ToString();
 AddUpdatedFld(convCMFuncParaRela.FunctionName);
}
else if (strAttributeName  ==  convCMFuncParaRela.FunctionSignature)
{
mstrFunctionSignature = value.ToString();
 AddUpdatedFld(convCMFuncParaRela.FunctionSignature);
}
else if (strAttributeName  ==  convCMFuncParaRela.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMFuncParaRela.OrderNum);
}
else if (strAttributeName  ==  convCMFuncParaRela.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convCMFuncParaRela.PrjId);
}
else if (strAttributeName  ==  convCMFuncParaRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convCMFuncParaRela.UpdDate);
}
else if (strAttributeName  ==  convCMFuncParaRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convCMFuncParaRela.UpdUser);
}
else if (strAttributeName  ==  convCMFuncParaRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCMFuncParaRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convCMFuncParaRela.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (convCMFuncParaRela.CmFuncParaId  ==  _AttributeName[intIndex])
{
return mstrCmFuncParaId;
}
else if (convCMFuncParaRela.ParaName  ==  _AttributeName[intIndex])
{
return mstrParaName;
}
else if (convCMFuncParaRela.ParaComments  ==  _AttributeName[intIndex])
{
return mstrParaComments;
}
else if (convCMFuncParaRela.ParameterType  ==  _AttributeName[intIndex])
{
return mstrParameterType;
}
else if (convCMFuncParaRela.DataTypeId  ==  _AttributeName[intIndex])
{
return mstrDataTypeId;
}
else if (convCMFuncParaRela.DataTypeName  ==  _AttributeName[intIndex])
{
return mstrDataTypeName;
}
else if (convCMFuncParaRela.CsType  ==  _AttributeName[intIndex])
{
return mstrCsType;
}
else if (convCMFuncParaRela.JavaType  ==  _AttributeName[intIndex])
{
return mstrJavaType;
}
else if (convCMFuncParaRela.IsNeedQuote  ==  _AttributeName[intIndex])
{
return mbolIsNeedQuote;
}
else if (convCMFuncParaRela.ParameterTypeFullName  ==  _AttributeName[intIndex])
{
return mstrParameterTypeFullName;
}
else if (convCMFuncParaRela.IsByRef  ==  _AttributeName[intIndex])
{
return mbolIsByRef;
}
else if (convCMFuncParaRela.ParaCnName  ==  _AttributeName[intIndex])
{
return mstrParaCnName;
}
else if (convCMFuncParaRela.CmFunctionId  ==  _AttributeName[intIndex])
{
return mstrCmFunctionId;
}
else if (convCMFuncParaRela.FunctionName  ==  _AttributeName[intIndex])
{
return mstrFunctionName;
}
else if (convCMFuncParaRela.FunctionSignature  ==  _AttributeName[intIndex])
{
return mstrFunctionSignature;
}
else if (convCMFuncParaRela.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convCMFuncParaRela.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convCMFuncParaRela.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convCMFuncParaRela.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convCMFuncParaRela.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convCMFuncParaRela.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMFuncParaRela.mId);
}
else if (convCMFuncParaRela.CmFuncParaId  ==  _AttributeName[intIndex])
{
mstrCmFuncParaId = value.ToString();
 AddUpdatedFld(convCMFuncParaRela.CmFuncParaId);
}
else if (convCMFuncParaRela.ParaName  ==  _AttributeName[intIndex])
{
mstrParaName = value.ToString();
 AddUpdatedFld(convCMFuncParaRela.ParaName);
}
else if (convCMFuncParaRela.ParaComments  ==  _AttributeName[intIndex])
{
mstrParaComments = value.ToString();
 AddUpdatedFld(convCMFuncParaRela.ParaComments);
}
else if (convCMFuncParaRela.ParameterType  ==  _AttributeName[intIndex])
{
mstrParameterType = value.ToString();
 AddUpdatedFld(convCMFuncParaRela.ParameterType);
}
else if (convCMFuncParaRela.DataTypeId  ==  _AttributeName[intIndex])
{
mstrDataTypeId = value.ToString();
 AddUpdatedFld(convCMFuncParaRela.DataTypeId);
}
else if (convCMFuncParaRela.DataTypeName  ==  _AttributeName[intIndex])
{
mstrDataTypeName = value.ToString();
 AddUpdatedFld(convCMFuncParaRela.DataTypeName);
}
else if (convCMFuncParaRela.CsType  ==  _AttributeName[intIndex])
{
mstrCsType = value.ToString();
 AddUpdatedFld(convCMFuncParaRela.CsType);
}
else if (convCMFuncParaRela.JavaType  ==  _AttributeName[intIndex])
{
mstrJavaType = value.ToString();
 AddUpdatedFld(convCMFuncParaRela.JavaType);
}
else if (convCMFuncParaRela.IsNeedQuote  ==  _AttributeName[intIndex])
{
mbolIsNeedQuote = TransNullToBool(value.ToString());
 AddUpdatedFld(convCMFuncParaRela.IsNeedQuote);
}
else if (convCMFuncParaRela.ParameterTypeFullName  ==  _AttributeName[intIndex])
{
mstrParameterTypeFullName = value.ToString();
 AddUpdatedFld(convCMFuncParaRela.ParameterTypeFullName);
}
else if (convCMFuncParaRela.IsByRef  ==  _AttributeName[intIndex])
{
mbolIsByRef = TransNullToBool(value.ToString());
 AddUpdatedFld(convCMFuncParaRela.IsByRef);
}
else if (convCMFuncParaRela.ParaCnName  ==  _AttributeName[intIndex])
{
mstrParaCnName = value.ToString();
 AddUpdatedFld(convCMFuncParaRela.ParaCnName);
}
else if (convCMFuncParaRela.CmFunctionId  ==  _AttributeName[intIndex])
{
mstrCmFunctionId = value.ToString();
 AddUpdatedFld(convCMFuncParaRela.CmFunctionId);
}
else if (convCMFuncParaRela.FunctionName  ==  _AttributeName[intIndex])
{
mstrFunctionName = value.ToString();
 AddUpdatedFld(convCMFuncParaRela.FunctionName);
}
else if (convCMFuncParaRela.FunctionSignature  ==  _AttributeName[intIndex])
{
mstrFunctionSignature = value.ToString();
 AddUpdatedFld(convCMFuncParaRela.FunctionSignature);
}
else if (convCMFuncParaRela.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMFuncParaRela.OrderNum);
}
else if (convCMFuncParaRela.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convCMFuncParaRela.PrjId);
}
else if (convCMFuncParaRela.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convCMFuncParaRela.UpdDate);
}
else if (convCMFuncParaRela.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convCMFuncParaRela.UpdUser);
}
else if (convCMFuncParaRela.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCMFuncParaRela.Memo);
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
 AddUpdatedFld(convCMFuncParaRela.mId);
}
}
/// <summary>
/// 函数参数Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CmFuncParaId
{
get
{
return mstrCmFuncParaId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCmFuncParaId = value;
}
else
{
 mstrCmFuncParaId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMFuncParaRela.CmFuncParaId);
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
 AddUpdatedFld(convCMFuncParaRela.ParaName);
}
}
/// <summary>
/// 参数注释(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParaComments
{
get
{
return mstrParaComments;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParaComments = value;
}
else
{
 mstrParaComments = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMFuncParaRela.ParaComments);
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
 AddUpdatedFld(convCMFuncParaRela.ParameterType);
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
 AddUpdatedFld(convCMFuncParaRela.DataTypeId);
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
 AddUpdatedFld(convCMFuncParaRela.DataTypeName);
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
 AddUpdatedFld(convCMFuncParaRela.CsType);
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
 AddUpdatedFld(convCMFuncParaRela.JavaType);
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
 AddUpdatedFld(convCMFuncParaRela.IsNeedQuote);
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
 AddUpdatedFld(convCMFuncParaRela.ParameterTypeFullName);
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
 AddUpdatedFld(convCMFuncParaRela.IsByRef);
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
 AddUpdatedFld(convCMFuncParaRela.ParaCnName);
}
}
/// <summary>
/// 函数Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CmFunctionId
{
get
{
return mstrCmFunctionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCmFunctionId = value;
}
else
{
 mstrCmFunctionId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMFuncParaRela.CmFunctionId);
}
}
/// <summary>
/// 功能名称(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FunctionName
{
get
{
return mstrFunctionName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFunctionName = value;
}
else
{
 mstrFunctionName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMFuncParaRela.FunctionName);
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
 AddUpdatedFld(convCMFuncParaRela.FunctionSignature);
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
 AddUpdatedFld(convCMFuncParaRela.OrderNum);
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
 AddUpdatedFld(convCMFuncParaRela.PrjId);
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
 AddUpdatedFld(convCMFuncParaRela.UpdDate);
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
 AddUpdatedFld(convCMFuncParaRela.UpdUser);
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
 AddUpdatedFld(convCMFuncParaRela.Memo);
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
 /// vCM函数参数关系(vCMFuncParaRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convCMFuncParaRela
{
public const string _CurrTabName = "vCMFuncParaRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "CmFuncParaId", "ParaName", "ParaComments", "ParameterType", "DataTypeId", "DataTypeName", "CsType", "JavaType", "IsNeedQuote", "ParameterTypeFullName", "IsByRef", "ParaCnName", "CmFunctionId", "FunctionName", "FunctionSignature", "OrderNum", "PrjId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"CmFuncParaId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CmFuncParaId = "CmFuncParaId";    //函数参数Id

 /// <summary>
 /// 常量:"ParaName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParaName = "ParaName";    //参数名

 /// <summary>
 /// 常量:"ParaComments"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParaComments = "ParaComments";    //参数注释

 /// <summary>
 /// 常量:"ParameterType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParameterType = "ParameterType";    //参数类型

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
 /// 常量:"IsNeedQuote"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsNeedQuote = "IsNeedQuote";    //是否需要引号

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
 /// 常量:"ParaCnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParaCnName = "ParaCnName";    //参数中文名

 /// <summary>
 /// 常量:"CmFunctionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CmFunctionId = "CmFunctionId";    //函数Id

 /// <summary>
 /// 常量:"FunctionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FunctionName = "FunctionName";    //功能名称

 /// <summary>
 /// 常量:"FunctionSignature"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FunctionSignature = "FunctionSignature";    //函数签名

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

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