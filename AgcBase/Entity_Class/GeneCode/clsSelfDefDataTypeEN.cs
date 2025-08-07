
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSelfDefDataTypeEN
 表名:SelfDefDataType(00050350)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:35:35
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
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
 /// 表SelfDefDataType的关键字(SdDataTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_SdDataTypeId_SelfDefDataType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strSdDataTypeId">表关键字</param>
public K_SdDataTypeId_SelfDefDataType(string strSdDataTypeId)
{
if (IsValid(strSdDataTypeId)) Value = strSdDataTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strSdDataTypeId)
{
if (string.IsNullOrEmpty(strSdDataTypeId) == true) return false;
if (strSdDataTypeId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_SdDataTypeId_SelfDefDataType]类型的对象</returns>
public static implicit operator K_SdDataTypeId_SelfDefDataType(string value)
{
return new K_SdDataTypeId_SelfDefDataType(value);
}
}
 /// <summary>
 /// 自定义数据类型(SelfDefDataType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsSelfDefDataTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "SelfDefDataType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "SdDataTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 22;
public static string[] _AttributeName = new string[] {"SdDataTypeId", "DataTypeName", "IsObject", "DefaVarName", "DataCnName", "DataTypeAbbr", "VbNetType", "CsType", "JavaType", "JavaObjType", "SwiftType", "IsNeedQuote", "OraDbType", "IsReturnType", "SqlParaType", "MySqlType", "DefaFldLength", "DefaFldPrecision", "PrjId", "UpdDate", "UpdUser", "Memo"};

protected string mstrSdDataTypeId;    //自定义数据类型Id
protected string mstrDataTypeName;    //数据类型名称
protected bool mbolIsObject;    //是否对象
protected string mstrDefaVarName;    //默认变量名
protected string mstrDataCnName;    //数据类型中文名称
protected string mstrDataTypeAbbr;    //数据类型缩写
protected string mstrVbNetType;    //VBNET类型
protected string mstrCsType;    //CS类型
protected string mstrJavaType;    //JAVA类型
protected string mstrJavaObjType;    //JAVA对象类型
protected string mstrSwiftType;    //SwiftType
protected bool mbolIsNeedQuote;    //是否需要引号
protected string mstrOraDbType;    //Ora数据类型
protected bool mbolIsReturnType;    //是否可作返回类型
protected string mstrSqlParaType;    //SQL参数类型
protected string mstrMySqlType;    //MySqlType
protected int? mintDefaFldLength;    //默认长度
protected int mintDefaFldPrecision;    //默认小数位数
protected string mstrPrjId;    //工程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsSelfDefDataTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("SdDataTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strSdDataTypeId">关键字:自定义数据类型Id</param>
public clsSelfDefDataTypeEN(string strSdDataTypeId)
 {
strSdDataTypeId = strSdDataTypeId.Replace("'", "''");
if (strSdDataTypeId.Length > 4)
{
throw new Exception("在表:SelfDefDataType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strSdDataTypeId)  ==  true)
{
throw new Exception("在表:SelfDefDataType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strSdDataTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrSdDataTypeId = strSdDataTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("SdDataTypeId");
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
if (strAttributeName  ==  conSelfDefDataType.SdDataTypeId)
{
return mstrSdDataTypeId;
}
else if (strAttributeName  ==  conSelfDefDataType.DataTypeName)
{
return mstrDataTypeName;
}
else if (strAttributeName  ==  conSelfDefDataType.IsObject)
{
return mbolIsObject;
}
else if (strAttributeName  ==  conSelfDefDataType.DefaVarName)
{
return mstrDefaVarName;
}
else if (strAttributeName  ==  conSelfDefDataType.DataCnName)
{
return mstrDataCnName;
}
else if (strAttributeName  ==  conSelfDefDataType.DataTypeAbbr)
{
return mstrDataTypeAbbr;
}
else if (strAttributeName  ==  conSelfDefDataType.VbNetType)
{
return mstrVbNetType;
}
else if (strAttributeName  ==  conSelfDefDataType.CsType)
{
return mstrCsType;
}
else if (strAttributeName  ==  conSelfDefDataType.JavaType)
{
return mstrJavaType;
}
else if (strAttributeName  ==  conSelfDefDataType.JavaObjType)
{
return mstrJavaObjType;
}
else if (strAttributeName  ==  conSelfDefDataType.SwiftType)
{
return mstrSwiftType;
}
else if (strAttributeName  ==  conSelfDefDataType.IsNeedQuote)
{
return mbolIsNeedQuote;
}
else if (strAttributeName  ==  conSelfDefDataType.OraDbType)
{
return mstrOraDbType;
}
else if (strAttributeName  ==  conSelfDefDataType.IsReturnType)
{
return mbolIsReturnType;
}
else if (strAttributeName  ==  conSelfDefDataType.SqlParaType)
{
return mstrSqlParaType;
}
else if (strAttributeName  ==  conSelfDefDataType.MySqlType)
{
return mstrMySqlType;
}
else if (strAttributeName  ==  conSelfDefDataType.DefaFldLength)
{
return mintDefaFldLength;
}
else if (strAttributeName  ==  conSelfDefDataType.DefaFldPrecision)
{
return mintDefaFldPrecision;
}
else if (strAttributeName  ==  conSelfDefDataType.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conSelfDefDataType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conSelfDefDataType.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conSelfDefDataType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conSelfDefDataType.SdDataTypeId)
{
mstrSdDataTypeId = value.ToString();
 AddUpdatedFld(conSelfDefDataType.SdDataTypeId);
}
else if (strAttributeName  ==  conSelfDefDataType.DataTypeName)
{
mstrDataTypeName = value.ToString();
 AddUpdatedFld(conSelfDefDataType.DataTypeName);
}
else if (strAttributeName  ==  conSelfDefDataType.IsObject)
{
mbolIsObject = TransNullToBool(value.ToString());
 AddUpdatedFld(conSelfDefDataType.IsObject);
}
else if (strAttributeName  ==  conSelfDefDataType.DefaVarName)
{
mstrDefaVarName = value.ToString();
 AddUpdatedFld(conSelfDefDataType.DefaVarName);
}
else if (strAttributeName  ==  conSelfDefDataType.DataCnName)
{
mstrDataCnName = value.ToString();
 AddUpdatedFld(conSelfDefDataType.DataCnName);
}
else if (strAttributeName  ==  conSelfDefDataType.DataTypeAbbr)
{
mstrDataTypeAbbr = value.ToString();
 AddUpdatedFld(conSelfDefDataType.DataTypeAbbr);
}
else if (strAttributeName  ==  conSelfDefDataType.VbNetType)
{
mstrVbNetType = value.ToString();
 AddUpdatedFld(conSelfDefDataType.VbNetType);
}
else if (strAttributeName  ==  conSelfDefDataType.CsType)
{
mstrCsType = value.ToString();
 AddUpdatedFld(conSelfDefDataType.CsType);
}
else if (strAttributeName  ==  conSelfDefDataType.JavaType)
{
mstrJavaType = value.ToString();
 AddUpdatedFld(conSelfDefDataType.JavaType);
}
else if (strAttributeName  ==  conSelfDefDataType.JavaObjType)
{
mstrJavaObjType = value.ToString();
 AddUpdatedFld(conSelfDefDataType.JavaObjType);
}
else if (strAttributeName  ==  conSelfDefDataType.SwiftType)
{
mstrSwiftType = value.ToString();
 AddUpdatedFld(conSelfDefDataType.SwiftType);
}
else if (strAttributeName  ==  conSelfDefDataType.IsNeedQuote)
{
mbolIsNeedQuote = TransNullToBool(value.ToString());
 AddUpdatedFld(conSelfDefDataType.IsNeedQuote);
}
else if (strAttributeName  ==  conSelfDefDataType.OraDbType)
{
mstrOraDbType = value.ToString();
 AddUpdatedFld(conSelfDefDataType.OraDbType);
}
else if (strAttributeName  ==  conSelfDefDataType.IsReturnType)
{
mbolIsReturnType = TransNullToBool(value.ToString());
 AddUpdatedFld(conSelfDefDataType.IsReturnType);
}
else if (strAttributeName  ==  conSelfDefDataType.SqlParaType)
{
mstrSqlParaType = value.ToString();
 AddUpdatedFld(conSelfDefDataType.SqlParaType);
}
else if (strAttributeName  ==  conSelfDefDataType.MySqlType)
{
mstrMySqlType = value.ToString();
 AddUpdatedFld(conSelfDefDataType.MySqlType);
}
else if (strAttributeName  ==  conSelfDefDataType.DefaFldLength)
{
mintDefaFldLength = TransNullToInt(value.ToString());
 AddUpdatedFld(conSelfDefDataType.DefaFldLength);
}
else if (strAttributeName  ==  conSelfDefDataType.DefaFldPrecision)
{
mintDefaFldPrecision = TransNullToInt(value.ToString());
 AddUpdatedFld(conSelfDefDataType.DefaFldPrecision);
}
else if (strAttributeName  ==  conSelfDefDataType.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conSelfDefDataType.PrjId);
}
else if (strAttributeName  ==  conSelfDefDataType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conSelfDefDataType.UpdDate);
}
else if (strAttributeName  ==  conSelfDefDataType.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conSelfDefDataType.UpdUser);
}
else if (strAttributeName  ==  conSelfDefDataType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSelfDefDataType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conSelfDefDataType.SdDataTypeId  ==  _AttributeName[intIndex])
{
return mstrSdDataTypeId;
}
else if (conSelfDefDataType.DataTypeName  ==  _AttributeName[intIndex])
{
return mstrDataTypeName;
}
else if (conSelfDefDataType.IsObject  ==  _AttributeName[intIndex])
{
return mbolIsObject;
}
else if (conSelfDefDataType.DefaVarName  ==  _AttributeName[intIndex])
{
return mstrDefaVarName;
}
else if (conSelfDefDataType.DataCnName  ==  _AttributeName[intIndex])
{
return mstrDataCnName;
}
else if (conSelfDefDataType.DataTypeAbbr  ==  _AttributeName[intIndex])
{
return mstrDataTypeAbbr;
}
else if (conSelfDefDataType.VbNetType  ==  _AttributeName[intIndex])
{
return mstrVbNetType;
}
else if (conSelfDefDataType.CsType  ==  _AttributeName[intIndex])
{
return mstrCsType;
}
else if (conSelfDefDataType.JavaType  ==  _AttributeName[intIndex])
{
return mstrJavaType;
}
else if (conSelfDefDataType.JavaObjType  ==  _AttributeName[intIndex])
{
return mstrJavaObjType;
}
else if (conSelfDefDataType.SwiftType  ==  _AttributeName[intIndex])
{
return mstrSwiftType;
}
else if (conSelfDefDataType.IsNeedQuote  ==  _AttributeName[intIndex])
{
return mbolIsNeedQuote;
}
else if (conSelfDefDataType.OraDbType  ==  _AttributeName[intIndex])
{
return mstrOraDbType;
}
else if (conSelfDefDataType.IsReturnType  ==  _AttributeName[intIndex])
{
return mbolIsReturnType;
}
else if (conSelfDefDataType.SqlParaType  ==  _AttributeName[intIndex])
{
return mstrSqlParaType;
}
else if (conSelfDefDataType.MySqlType  ==  _AttributeName[intIndex])
{
return mstrMySqlType;
}
else if (conSelfDefDataType.DefaFldLength  ==  _AttributeName[intIndex])
{
return mintDefaFldLength;
}
else if (conSelfDefDataType.DefaFldPrecision  ==  _AttributeName[intIndex])
{
return mintDefaFldPrecision;
}
else if (conSelfDefDataType.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conSelfDefDataType.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conSelfDefDataType.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conSelfDefDataType.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conSelfDefDataType.SdDataTypeId  ==  _AttributeName[intIndex])
{
mstrSdDataTypeId = value.ToString();
 AddUpdatedFld(conSelfDefDataType.SdDataTypeId);
}
else if (conSelfDefDataType.DataTypeName  ==  _AttributeName[intIndex])
{
mstrDataTypeName = value.ToString();
 AddUpdatedFld(conSelfDefDataType.DataTypeName);
}
else if (conSelfDefDataType.IsObject  ==  _AttributeName[intIndex])
{
mbolIsObject = TransNullToBool(value.ToString());
 AddUpdatedFld(conSelfDefDataType.IsObject);
}
else if (conSelfDefDataType.DefaVarName  ==  _AttributeName[intIndex])
{
mstrDefaVarName = value.ToString();
 AddUpdatedFld(conSelfDefDataType.DefaVarName);
}
else if (conSelfDefDataType.DataCnName  ==  _AttributeName[intIndex])
{
mstrDataCnName = value.ToString();
 AddUpdatedFld(conSelfDefDataType.DataCnName);
}
else if (conSelfDefDataType.DataTypeAbbr  ==  _AttributeName[intIndex])
{
mstrDataTypeAbbr = value.ToString();
 AddUpdatedFld(conSelfDefDataType.DataTypeAbbr);
}
else if (conSelfDefDataType.VbNetType  ==  _AttributeName[intIndex])
{
mstrVbNetType = value.ToString();
 AddUpdatedFld(conSelfDefDataType.VbNetType);
}
else if (conSelfDefDataType.CsType  ==  _AttributeName[intIndex])
{
mstrCsType = value.ToString();
 AddUpdatedFld(conSelfDefDataType.CsType);
}
else if (conSelfDefDataType.JavaType  ==  _AttributeName[intIndex])
{
mstrJavaType = value.ToString();
 AddUpdatedFld(conSelfDefDataType.JavaType);
}
else if (conSelfDefDataType.JavaObjType  ==  _AttributeName[intIndex])
{
mstrJavaObjType = value.ToString();
 AddUpdatedFld(conSelfDefDataType.JavaObjType);
}
else if (conSelfDefDataType.SwiftType  ==  _AttributeName[intIndex])
{
mstrSwiftType = value.ToString();
 AddUpdatedFld(conSelfDefDataType.SwiftType);
}
else if (conSelfDefDataType.IsNeedQuote  ==  _AttributeName[intIndex])
{
mbolIsNeedQuote = TransNullToBool(value.ToString());
 AddUpdatedFld(conSelfDefDataType.IsNeedQuote);
}
else if (conSelfDefDataType.OraDbType  ==  _AttributeName[intIndex])
{
mstrOraDbType = value.ToString();
 AddUpdatedFld(conSelfDefDataType.OraDbType);
}
else if (conSelfDefDataType.IsReturnType  ==  _AttributeName[intIndex])
{
mbolIsReturnType = TransNullToBool(value.ToString());
 AddUpdatedFld(conSelfDefDataType.IsReturnType);
}
else if (conSelfDefDataType.SqlParaType  ==  _AttributeName[intIndex])
{
mstrSqlParaType = value.ToString();
 AddUpdatedFld(conSelfDefDataType.SqlParaType);
}
else if (conSelfDefDataType.MySqlType  ==  _AttributeName[intIndex])
{
mstrMySqlType = value.ToString();
 AddUpdatedFld(conSelfDefDataType.MySqlType);
}
else if (conSelfDefDataType.DefaFldLength  ==  _AttributeName[intIndex])
{
mintDefaFldLength = TransNullToInt(value.ToString());
 AddUpdatedFld(conSelfDefDataType.DefaFldLength);
}
else if (conSelfDefDataType.DefaFldPrecision  ==  _AttributeName[intIndex])
{
mintDefaFldPrecision = TransNullToInt(value.ToString());
 AddUpdatedFld(conSelfDefDataType.DefaFldPrecision);
}
else if (conSelfDefDataType.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conSelfDefDataType.PrjId);
}
else if (conSelfDefDataType.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conSelfDefDataType.UpdDate);
}
else if (conSelfDefDataType.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conSelfDefDataType.UpdUser);
}
else if (conSelfDefDataType.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSelfDefDataType.Memo);
}
}
}

/// <summary>
/// 自定义数据类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SdDataTypeId
{
get
{
return mstrSdDataTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSdDataTypeId = value;
}
else
{
 mstrSdDataTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSelfDefDataType.SdDataTypeId);
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
 AddUpdatedFld(conSelfDefDataType.DataTypeName);
}
}
/// <summary>
/// 是否对象(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsObject
{
get
{
return mbolIsObject;
}
set
{
 mbolIsObject = value;
//记录修改过的字段
 AddUpdatedFld(conSelfDefDataType.IsObject);
}
}
/// <summary>
/// 默认变量名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DefaVarName
{
get
{
return mstrDefaVarName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDefaVarName = value;
}
else
{
 mstrDefaVarName = value;
}
//记录修改过的字段
 AddUpdatedFld(conSelfDefDataType.DefaVarName);
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
 AddUpdatedFld(conSelfDefDataType.DataCnName);
}
}
/// <summary>
/// 数据类型缩写(说明:;字段类型:varchar;字段长度:5;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataTypeAbbr
{
get
{
return mstrDataTypeAbbr;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataTypeAbbr = value;
}
else
{
 mstrDataTypeAbbr = value;
}
//记录修改过的字段
 AddUpdatedFld(conSelfDefDataType.DataTypeAbbr);
}
}
/// <summary>
/// VBNET类型(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VbNetType
{
get
{
return mstrVbNetType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVbNetType = value;
}
else
{
 mstrVbNetType = value;
}
//记录修改过的字段
 AddUpdatedFld(conSelfDefDataType.VbNetType);
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
 AddUpdatedFld(conSelfDefDataType.CsType);
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
 AddUpdatedFld(conSelfDefDataType.JavaType);
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
 AddUpdatedFld(conSelfDefDataType.JavaObjType);
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
 AddUpdatedFld(conSelfDefDataType.SwiftType);
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
 AddUpdatedFld(conSelfDefDataType.IsNeedQuote);
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
 AddUpdatedFld(conSelfDefDataType.OraDbType);
}
}
/// <summary>
/// 是否可作返回类型(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsReturnType
{
get
{
return mbolIsReturnType;
}
set
{
 mbolIsReturnType = value;
//记录修改过的字段
 AddUpdatedFld(conSelfDefDataType.IsReturnType);
}
}
/// <summary>
/// SQL参数类型(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SqlParaType
{
get
{
return mstrSqlParaType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSqlParaType = value;
}
else
{
 mstrSqlParaType = value;
}
//记录修改过的字段
 AddUpdatedFld(conSelfDefDataType.SqlParaType);
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
 AddUpdatedFld(conSelfDefDataType.MySqlType);
}
}
/// <summary>
/// 默认长度(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? DefaFldLength
{
get
{
return mintDefaFldLength;
}
set
{
 mintDefaFldLength = value;
//记录修改过的字段
 AddUpdatedFld(conSelfDefDataType.DefaFldLength);
}
}
/// <summary>
/// 默认小数位数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int DefaFldPrecision
{
get
{
return mintDefaFldPrecision;
}
set
{
 mintDefaFldPrecision = value;
//记录修改过的字段
 AddUpdatedFld(conSelfDefDataType.DefaFldPrecision);
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
 AddUpdatedFld(conSelfDefDataType.PrjId);
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
 AddUpdatedFld(conSelfDefDataType.UpdDate);
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
 AddUpdatedFld(conSelfDefDataType.UpdUser);
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
 AddUpdatedFld(conSelfDefDataType.Memo);
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
  return mstrSdDataTypeId;
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
  return mstrDataTypeName;
 }
 }
}
 /// <summary>
 /// 自定义数据类型(SelfDefDataType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conSelfDefDataType
{
public const string _CurrTabName = "SelfDefDataType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "SdDataTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"SdDataTypeId", "DataTypeName", "IsObject", "DefaVarName", "DataCnName", "DataTypeAbbr", "VbNetType", "CsType", "JavaType", "JavaObjType", "SwiftType", "IsNeedQuote", "OraDbType", "IsReturnType", "SqlParaType", "MySqlType", "DefaFldLength", "DefaFldPrecision", "PrjId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"SdDataTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SdDataTypeId = "SdDataTypeId";    //自定义数据类型Id

 /// <summary>
 /// 常量:"DataTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataTypeName = "DataTypeName";    //数据类型名称

 /// <summary>
 /// 常量:"IsObject"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsObject = "IsObject";    //是否对象

 /// <summary>
 /// 常量:"DefaVarName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DefaVarName = "DefaVarName";    //默认变量名

 /// <summary>
 /// 常量:"DataCnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataCnName = "DataCnName";    //数据类型中文名称

 /// <summary>
 /// 常量:"DataTypeAbbr"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataTypeAbbr = "DataTypeAbbr";    //数据类型缩写

 /// <summary>
 /// 常量:"VbNetType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VbNetType = "VbNetType";    //VBNET类型

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
 /// 常量:"IsReturnType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsReturnType = "IsReturnType";    //是否可作返回类型

 /// <summary>
 /// 常量:"SqlParaType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SqlParaType = "SqlParaType";    //SQL参数类型

 /// <summary>
 /// 常量:"MySqlType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MySqlType = "MySqlType";    //MySqlType

 /// <summary>
 /// 常量:"DefaFldLength"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DefaFldLength = "DefaFldLength";    //默认长度

 /// <summary>
 /// 常量:"DefaFldPrecision"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DefaFldPrecision = "DefaFldPrecision";    //默认小数位数

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