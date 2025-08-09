
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCMFuncParaEN
 表名:vCMFuncPara(00050508)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:11:34
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
 /// 表vCMFuncPara的关键字(CmFuncParaId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CmFuncParaId_vCMFuncPara
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strCmFuncParaId">表关键字</param>
public K_CmFuncParaId_vCMFuncPara(string strCmFuncParaId)
{
if (IsValid(strCmFuncParaId)) Value = strCmFuncParaId;
else
{
Value = null;
}
}
private static bool IsValid(string strCmFuncParaId)
{
if (string.IsNullOrEmpty(strCmFuncParaId) == true) return false;
if (strCmFuncParaId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_CmFuncParaId_vCMFuncPara]类型的对象</returns>
public static implicit operator K_CmFuncParaId_vCMFuncPara(string value)
{
return new K_CmFuncParaId_vCMFuncPara(value);
}
}
 /// <summary>
 /// vCM函数参数(vCMFuncPara)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvCMFuncParaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vCMFuncPara"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "CmFuncParaId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 22;
public static string[] _AttributeName = new string[] {"CmFuncParaId", "ParaName", "ParaComments", "ParameterType", "DataTypeId", "DataTypeName", "DataCnName", "CsType", "JavaType", "JavaObjType", "SwiftType", "IsNeedQuote", "OraDbType", "MySqlType", "ParameterTypeFullName", "IsByRef", "ParaCnName", "PrjId", "UpdDate", "UpdUser", "Memo", "FuncCount"};

protected string mstrCmFuncParaId;    //函数参数Id
protected string mstrParaName;    //参数名
protected string mstrParaComments;    //参数注释
protected string mstrParameterType;    //参数类型
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
protected string mstrParameterTypeFullName;    //参数类型全名
protected bool mbolIsByRef;    //是否引用型参数
protected string mstrParaCnName;    //参数中文名
protected string mstrPrjId;    //工程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明
protected int? mintFuncCount;    //函数数目

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvCMFuncParaEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CmFuncParaId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strCmFuncParaId">关键字:函数参数Id</param>
public clsvCMFuncParaEN(string strCmFuncParaId)
 {
strCmFuncParaId = strCmFuncParaId.Replace("'", "''");
if (strCmFuncParaId.Length > 8)
{
throw new Exception("在表:vCMFuncPara中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strCmFuncParaId)  ==  true)
{
throw new Exception("在表:vCMFuncPara中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCmFuncParaId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrCmFuncParaId = strCmFuncParaId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CmFuncParaId");
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
if (strAttributeName  ==  convCMFuncPara.CmFuncParaId)
{
return mstrCmFuncParaId;
}
else if (strAttributeName  ==  convCMFuncPara.ParaName)
{
return mstrParaName;
}
else if (strAttributeName  ==  convCMFuncPara.ParaComments)
{
return mstrParaComments;
}
else if (strAttributeName  ==  convCMFuncPara.ParameterType)
{
return mstrParameterType;
}
else if (strAttributeName  ==  convCMFuncPara.DataTypeId)
{
return mstrDataTypeId;
}
else if (strAttributeName  ==  convCMFuncPara.DataTypeName)
{
return mstrDataTypeName;
}
else if (strAttributeName  ==  convCMFuncPara.DataCnName)
{
return mstrDataCnName;
}
else if (strAttributeName  ==  convCMFuncPara.CsType)
{
return mstrCsType;
}
else if (strAttributeName  ==  convCMFuncPara.JavaType)
{
return mstrJavaType;
}
else if (strAttributeName  ==  convCMFuncPara.JavaObjType)
{
return mstrJavaObjType;
}
else if (strAttributeName  ==  convCMFuncPara.SwiftType)
{
return mstrSwiftType;
}
else if (strAttributeName  ==  convCMFuncPara.IsNeedQuote)
{
return mbolIsNeedQuote;
}
else if (strAttributeName  ==  convCMFuncPara.OraDbType)
{
return mstrOraDbType;
}
else if (strAttributeName  ==  convCMFuncPara.MySqlType)
{
return mstrMySqlType;
}
else if (strAttributeName  ==  convCMFuncPara.ParameterTypeFullName)
{
return mstrParameterTypeFullName;
}
else if (strAttributeName  ==  convCMFuncPara.IsByRef)
{
return mbolIsByRef;
}
else if (strAttributeName  ==  convCMFuncPara.ParaCnName)
{
return mstrParaCnName;
}
else if (strAttributeName  ==  convCMFuncPara.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convCMFuncPara.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convCMFuncPara.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convCMFuncPara.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convCMFuncPara.FuncCount)
{
return mintFuncCount;
}
return null;
}
set
{
if (strAttributeName  ==  convCMFuncPara.CmFuncParaId)
{
mstrCmFuncParaId = value.ToString();
 AddUpdatedFld(convCMFuncPara.CmFuncParaId);
}
else if (strAttributeName  ==  convCMFuncPara.ParaName)
{
mstrParaName = value.ToString();
 AddUpdatedFld(convCMFuncPara.ParaName);
}
else if (strAttributeName  ==  convCMFuncPara.ParaComments)
{
mstrParaComments = value.ToString();
 AddUpdatedFld(convCMFuncPara.ParaComments);
}
else if (strAttributeName  ==  convCMFuncPara.ParameterType)
{
mstrParameterType = value.ToString();
 AddUpdatedFld(convCMFuncPara.ParameterType);
}
else if (strAttributeName  ==  convCMFuncPara.DataTypeId)
{
mstrDataTypeId = value.ToString();
 AddUpdatedFld(convCMFuncPara.DataTypeId);
}
else if (strAttributeName  ==  convCMFuncPara.DataTypeName)
{
mstrDataTypeName = value.ToString();
 AddUpdatedFld(convCMFuncPara.DataTypeName);
}
else if (strAttributeName  ==  convCMFuncPara.DataCnName)
{
mstrDataCnName = value.ToString();
 AddUpdatedFld(convCMFuncPara.DataCnName);
}
else if (strAttributeName  ==  convCMFuncPara.CsType)
{
mstrCsType = value.ToString();
 AddUpdatedFld(convCMFuncPara.CsType);
}
else if (strAttributeName  ==  convCMFuncPara.JavaType)
{
mstrJavaType = value.ToString();
 AddUpdatedFld(convCMFuncPara.JavaType);
}
else if (strAttributeName  ==  convCMFuncPara.JavaObjType)
{
mstrJavaObjType = value.ToString();
 AddUpdatedFld(convCMFuncPara.JavaObjType);
}
else if (strAttributeName  ==  convCMFuncPara.SwiftType)
{
mstrSwiftType = value.ToString();
 AddUpdatedFld(convCMFuncPara.SwiftType);
}
else if (strAttributeName  ==  convCMFuncPara.IsNeedQuote)
{
mbolIsNeedQuote = TransNullToBool(value.ToString());
 AddUpdatedFld(convCMFuncPara.IsNeedQuote);
}
else if (strAttributeName  ==  convCMFuncPara.OraDbType)
{
mstrOraDbType = value.ToString();
 AddUpdatedFld(convCMFuncPara.OraDbType);
}
else if (strAttributeName  ==  convCMFuncPara.MySqlType)
{
mstrMySqlType = value.ToString();
 AddUpdatedFld(convCMFuncPara.MySqlType);
}
else if (strAttributeName  ==  convCMFuncPara.ParameterTypeFullName)
{
mstrParameterTypeFullName = value.ToString();
 AddUpdatedFld(convCMFuncPara.ParameterTypeFullName);
}
else if (strAttributeName  ==  convCMFuncPara.IsByRef)
{
mbolIsByRef = TransNullToBool(value.ToString());
 AddUpdatedFld(convCMFuncPara.IsByRef);
}
else if (strAttributeName  ==  convCMFuncPara.ParaCnName)
{
mstrParaCnName = value.ToString();
 AddUpdatedFld(convCMFuncPara.ParaCnName);
}
else if (strAttributeName  ==  convCMFuncPara.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convCMFuncPara.PrjId);
}
else if (strAttributeName  ==  convCMFuncPara.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convCMFuncPara.UpdDate);
}
else if (strAttributeName  ==  convCMFuncPara.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convCMFuncPara.UpdUser);
}
else if (strAttributeName  ==  convCMFuncPara.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCMFuncPara.Memo);
}
else if (strAttributeName  ==  convCMFuncPara.FuncCount)
{
mintFuncCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMFuncPara.FuncCount);
}
}
}
public object this[int intIndex]
{
get
{
if (convCMFuncPara.CmFuncParaId  ==  _AttributeName[intIndex])
{
return mstrCmFuncParaId;
}
else if (convCMFuncPara.ParaName  ==  _AttributeName[intIndex])
{
return mstrParaName;
}
else if (convCMFuncPara.ParaComments  ==  _AttributeName[intIndex])
{
return mstrParaComments;
}
else if (convCMFuncPara.ParameterType  ==  _AttributeName[intIndex])
{
return mstrParameterType;
}
else if (convCMFuncPara.DataTypeId  ==  _AttributeName[intIndex])
{
return mstrDataTypeId;
}
else if (convCMFuncPara.DataTypeName  ==  _AttributeName[intIndex])
{
return mstrDataTypeName;
}
else if (convCMFuncPara.DataCnName  ==  _AttributeName[intIndex])
{
return mstrDataCnName;
}
else if (convCMFuncPara.CsType  ==  _AttributeName[intIndex])
{
return mstrCsType;
}
else if (convCMFuncPara.JavaType  ==  _AttributeName[intIndex])
{
return mstrJavaType;
}
else if (convCMFuncPara.JavaObjType  ==  _AttributeName[intIndex])
{
return mstrJavaObjType;
}
else if (convCMFuncPara.SwiftType  ==  _AttributeName[intIndex])
{
return mstrSwiftType;
}
else if (convCMFuncPara.IsNeedQuote  ==  _AttributeName[intIndex])
{
return mbolIsNeedQuote;
}
else if (convCMFuncPara.OraDbType  ==  _AttributeName[intIndex])
{
return mstrOraDbType;
}
else if (convCMFuncPara.MySqlType  ==  _AttributeName[intIndex])
{
return mstrMySqlType;
}
else if (convCMFuncPara.ParameterTypeFullName  ==  _AttributeName[intIndex])
{
return mstrParameterTypeFullName;
}
else if (convCMFuncPara.IsByRef  ==  _AttributeName[intIndex])
{
return mbolIsByRef;
}
else if (convCMFuncPara.ParaCnName  ==  _AttributeName[intIndex])
{
return mstrParaCnName;
}
else if (convCMFuncPara.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convCMFuncPara.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convCMFuncPara.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convCMFuncPara.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (convCMFuncPara.FuncCount  ==  _AttributeName[intIndex])
{
return mintFuncCount;
}
return null;
}
set
{
if (convCMFuncPara.CmFuncParaId  ==  _AttributeName[intIndex])
{
mstrCmFuncParaId = value.ToString();
 AddUpdatedFld(convCMFuncPara.CmFuncParaId);
}
else if (convCMFuncPara.ParaName  ==  _AttributeName[intIndex])
{
mstrParaName = value.ToString();
 AddUpdatedFld(convCMFuncPara.ParaName);
}
else if (convCMFuncPara.ParaComments  ==  _AttributeName[intIndex])
{
mstrParaComments = value.ToString();
 AddUpdatedFld(convCMFuncPara.ParaComments);
}
else if (convCMFuncPara.ParameterType  ==  _AttributeName[intIndex])
{
mstrParameterType = value.ToString();
 AddUpdatedFld(convCMFuncPara.ParameterType);
}
else if (convCMFuncPara.DataTypeId  ==  _AttributeName[intIndex])
{
mstrDataTypeId = value.ToString();
 AddUpdatedFld(convCMFuncPara.DataTypeId);
}
else if (convCMFuncPara.DataTypeName  ==  _AttributeName[intIndex])
{
mstrDataTypeName = value.ToString();
 AddUpdatedFld(convCMFuncPara.DataTypeName);
}
else if (convCMFuncPara.DataCnName  ==  _AttributeName[intIndex])
{
mstrDataCnName = value.ToString();
 AddUpdatedFld(convCMFuncPara.DataCnName);
}
else if (convCMFuncPara.CsType  ==  _AttributeName[intIndex])
{
mstrCsType = value.ToString();
 AddUpdatedFld(convCMFuncPara.CsType);
}
else if (convCMFuncPara.JavaType  ==  _AttributeName[intIndex])
{
mstrJavaType = value.ToString();
 AddUpdatedFld(convCMFuncPara.JavaType);
}
else if (convCMFuncPara.JavaObjType  ==  _AttributeName[intIndex])
{
mstrJavaObjType = value.ToString();
 AddUpdatedFld(convCMFuncPara.JavaObjType);
}
else if (convCMFuncPara.SwiftType  ==  _AttributeName[intIndex])
{
mstrSwiftType = value.ToString();
 AddUpdatedFld(convCMFuncPara.SwiftType);
}
else if (convCMFuncPara.IsNeedQuote  ==  _AttributeName[intIndex])
{
mbolIsNeedQuote = TransNullToBool(value.ToString());
 AddUpdatedFld(convCMFuncPara.IsNeedQuote);
}
else if (convCMFuncPara.OraDbType  ==  _AttributeName[intIndex])
{
mstrOraDbType = value.ToString();
 AddUpdatedFld(convCMFuncPara.OraDbType);
}
else if (convCMFuncPara.MySqlType  ==  _AttributeName[intIndex])
{
mstrMySqlType = value.ToString();
 AddUpdatedFld(convCMFuncPara.MySqlType);
}
else if (convCMFuncPara.ParameterTypeFullName  ==  _AttributeName[intIndex])
{
mstrParameterTypeFullName = value.ToString();
 AddUpdatedFld(convCMFuncPara.ParameterTypeFullName);
}
else if (convCMFuncPara.IsByRef  ==  _AttributeName[intIndex])
{
mbolIsByRef = TransNullToBool(value.ToString());
 AddUpdatedFld(convCMFuncPara.IsByRef);
}
else if (convCMFuncPara.ParaCnName  ==  _AttributeName[intIndex])
{
mstrParaCnName = value.ToString();
 AddUpdatedFld(convCMFuncPara.ParaCnName);
}
else if (convCMFuncPara.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convCMFuncPara.PrjId);
}
else if (convCMFuncPara.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convCMFuncPara.UpdDate);
}
else if (convCMFuncPara.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convCMFuncPara.UpdUser);
}
else if (convCMFuncPara.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCMFuncPara.Memo);
}
else if (convCMFuncPara.FuncCount  ==  _AttributeName[intIndex])
{
mintFuncCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMFuncPara.FuncCount);
}
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
 AddUpdatedFld(convCMFuncPara.CmFuncParaId);
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
 AddUpdatedFld(convCMFuncPara.ParaName);
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
 AddUpdatedFld(convCMFuncPara.ParaComments);
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
 AddUpdatedFld(convCMFuncPara.ParameterType);
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
 AddUpdatedFld(convCMFuncPara.DataTypeId);
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
 AddUpdatedFld(convCMFuncPara.DataTypeName);
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
 AddUpdatedFld(convCMFuncPara.DataCnName);
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
 AddUpdatedFld(convCMFuncPara.CsType);
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
 AddUpdatedFld(convCMFuncPara.JavaType);
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
 AddUpdatedFld(convCMFuncPara.JavaObjType);
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
 AddUpdatedFld(convCMFuncPara.SwiftType);
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
 AddUpdatedFld(convCMFuncPara.IsNeedQuote);
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
 AddUpdatedFld(convCMFuncPara.OraDbType);
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
 AddUpdatedFld(convCMFuncPara.MySqlType);
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
 AddUpdatedFld(convCMFuncPara.ParameterTypeFullName);
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
 AddUpdatedFld(convCMFuncPara.IsByRef);
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
 AddUpdatedFld(convCMFuncPara.ParaCnName);
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
 AddUpdatedFld(convCMFuncPara.PrjId);
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
 AddUpdatedFld(convCMFuncPara.UpdDate);
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
 AddUpdatedFld(convCMFuncPara.UpdUser);
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
 AddUpdatedFld(convCMFuncPara.Memo);
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
 AddUpdatedFld(convCMFuncPara.FuncCount);
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
  return mstrCmFuncParaId;
 }
 }
}
 /// <summary>
 /// vCM函数参数(vCMFuncPara)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convCMFuncPara
{
public const string _CurrTabName = "vCMFuncPara"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CmFuncParaId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"CmFuncParaId", "ParaName", "ParaComments", "ParameterType", "DataTypeId", "DataTypeName", "DataCnName", "CsType", "JavaType", "JavaObjType", "SwiftType", "IsNeedQuote", "OraDbType", "MySqlType", "ParameterTypeFullName", "IsByRef", "ParaCnName", "PrjId", "UpdDate", "UpdUser", "Memo", "FuncCount"};
//以下是属性变量


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

 /// <summary>
 /// 常量:"FuncCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncCount = "FuncCount";    //函数数目
}

}