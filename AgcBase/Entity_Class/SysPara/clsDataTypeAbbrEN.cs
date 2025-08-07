
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDataTypeAbbrEN
 表名:DataTypeAbbr(00050023)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:35:16
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统参数(SysPara)
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
 /// 表DataTypeAbbr的关键字(DataTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_DataTypeId_DataTypeAbbr
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strDataTypeId">表关键字</param>
public K_DataTypeId_DataTypeAbbr(string strDataTypeId)
{
if (IsValid(strDataTypeId)) Value = strDataTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strDataTypeId)
{
if (string.IsNullOrEmpty(strDataTypeId) == true) return false;
if (strDataTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_DataTypeId_DataTypeAbbr]类型的对象</returns>
public static implicit operator K_DataTypeId_DataTypeAbbr(string value)
{
return new K_DataTypeId_DataTypeAbbr(value);
}
}
 /// <summary>
 /// 数据类型(DataTypeAbbr)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsDataTypeAbbrEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "DataTypeAbbr"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "DataTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 20;
public static string[] _AttributeName = new string[] {"DataTypeId", "DataTypeName", "DataTypeENName", "DataCnName", "DataTypeAbbr", "NetSysType", "VbNetType", "CsType", "JavaType", "TypeScriptType", "JavaObjType", "SwiftType", "IsNeedQuote", "OraDbType", "IsReturnType", "SqlParaType", "MySqlType", "DefaFldLength", "DefaFldPrecision", "Memo"};

protected string mstrDataTypeId;    //数据类型Id
protected string mstrDataTypeName;    //数据类型名称
protected string mstrDataTypeENName;    //DataTypeENName
protected string mstrDataCnName;    //数据类型中文名称
protected string mstrDataTypeAbbr;    //数据类型缩写
protected string mstrNetSysType;    //NET系统类型
protected string mstrVbNetType;    //VBNET类型
protected string mstrCsType;    //CS类型
protected string mstrJavaType;    //JAVA类型
protected string mstrTypeScriptType;    //TypeScript类型
protected string mstrJavaObjType;    //JAVA对象类型
protected string mstrSwiftType;    //SwiftType
protected bool mbolIsNeedQuote;    //是否需要引号
protected string mstrOraDbType;    //Ora数据类型
protected bool mbolIsReturnType;    //是否可作返回类型
protected string mstrSqlParaType;    //SQL参数类型
protected string mstrMySqlType;    //MySqlType
protected int? mintDefaFldLength;    //默认长度
protected int? mintDefaFldPrecision;    //默认小数位数
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsDataTypeAbbrEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("DataTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strDataTypeId">关键字:数据类型Id</param>
public clsDataTypeAbbrEN(string strDataTypeId)
 {
strDataTypeId = strDataTypeId.Replace("'", "''");
if (strDataTypeId.Length > 2)
{
throw new Exception("在表:DataTypeAbbr中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strDataTypeId)  ==  true)
{
throw new Exception("在表:DataTypeAbbr中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strDataTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrDataTypeId = strDataTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("DataTypeId");
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
if (strAttributeName  ==  conDataTypeAbbr.DataTypeId)
{
return mstrDataTypeId;
}
else if (strAttributeName  ==  conDataTypeAbbr.DataTypeName)
{
return mstrDataTypeName;
}
else if (strAttributeName  ==  conDataTypeAbbr.DataTypeENName)
{
return mstrDataTypeENName;
}
else if (strAttributeName  ==  conDataTypeAbbr.DataCnName)
{
return mstrDataCnName;
}
else if (strAttributeName  ==  conDataTypeAbbr.DataTypeAbbr)
{
return mstrDataTypeAbbr;
}
else if (strAttributeName  ==  conDataTypeAbbr.NetSysType)
{
return mstrNetSysType;
}
else if (strAttributeName  ==  conDataTypeAbbr.VbNetType)
{
return mstrVbNetType;
}
else if (strAttributeName  ==  conDataTypeAbbr.CsType)
{
return mstrCsType;
}
else if (strAttributeName  ==  conDataTypeAbbr.JavaType)
{
return mstrJavaType;
}
else if (strAttributeName  ==  conDataTypeAbbr.TypeScriptType)
{
return mstrTypeScriptType;
}
else if (strAttributeName  ==  conDataTypeAbbr.JavaObjType)
{
return mstrJavaObjType;
}
else if (strAttributeName  ==  conDataTypeAbbr.SwiftType)
{
return mstrSwiftType;
}
else if (strAttributeName  ==  conDataTypeAbbr.IsNeedQuote)
{
return mbolIsNeedQuote;
}
else if (strAttributeName  ==  conDataTypeAbbr.OraDbType)
{
return mstrOraDbType;
}
else if (strAttributeName  ==  conDataTypeAbbr.IsReturnType)
{
return mbolIsReturnType;
}
else if (strAttributeName  ==  conDataTypeAbbr.SqlParaType)
{
return mstrSqlParaType;
}
else if (strAttributeName  ==  conDataTypeAbbr.MySqlType)
{
return mstrMySqlType;
}
else if (strAttributeName  ==  conDataTypeAbbr.DefaFldLength)
{
return mintDefaFldLength;
}
else if (strAttributeName  ==  conDataTypeAbbr.DefaFldPrecision)
{
return mintDefaFldPrecision;
}
else if (strAttributeName  ==  conDataTypeAbbr.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conDataTypeAbbr.DataTypeId)
{
mstrDataTypeId = value.ToString();
 AddUpdatedFld(conDataTypeAbbr.DataTypeId);
}
else if (strAttributeName  ==  conDataTypeAbbr.DataTypeName)
{
mstrDataTypeName = value.ToString();
 AddUpdatedFld(conDataTypeAbbr.DataTypeName);
}
else if (strAttributeName  ==  conDataTypeAbbr.DataTypeENName)
{
mstrDataTypeENName = value.ToString();
 AddUpdatedFld(conDataTypeAbbr.DataTypeENName);
}
else if (strAttributeName  ==  conDataTypeAbbr.DataCnName)
{
mstrDataCnName = value.ToString();
 AddUpdatedFld(conDataTypeAbbr.DataCnName);
}
else if (strAttributeName  ==  conDataTypeAbbr.DataTypeAbbr)
{
mstrDataTypeAbbr = value.ToString();
 AddUpdatedFld(conDataTypeAbbr.DataTypeAbbr);
}
else if (strAttributeName  ==  conDataTypeAbbr.NetSysType)
{
mstrNetSysType = value.ToString();
 AddUpdatedFld(conDataTypeAbbr.NetSysType);
}
else if (strAttributeName  ==  conDataTypeAbbr.VbNetType)
{
mstrVbNetType = value.ToString();
 AddUpdatedFld(conDataTypeAbbr.VbNetType);
}
else if (strAttributeName  ==  conDataTypeAbbr.CsType)
{
mstrCsType = value.ToString();
 AddUpdatedFld(conDataTypeAbbr.CsType);
}
else if (strAttributeName  ==  conDataTypeAbbr.JavaType)
{
mstrJavaType = value.ToString();
 AddUpdatedFld(conDataTypeAbbr.JavaType);
}
else if (strAttributeName  ==  conDataTypeAbbr.TypeScriptType)
{
mstrTypeScriptType = value.ToString();
 AddUpdatedFld(conDataTypeAbbr.TypeScriptType);
}
else if (strAttributeName  ==  conDataTypeAbbr.JavaObjType)
{
mstrJavaObjType = value.ToString();
 AddUpdatedFld(conDataTypeAbbr.JavaObjType);
}
else if (strAttributeName  ==  conDataTypeAbbr.SwiftType)
{
mstrSwiftType = value.ToString();
 AddUpdatedFld(conDataTypeAbbr.SwiftType);
}
else if (strAttributeName  ==  conDataTypeAbbr.IsNeedQuote)
{
mbolIsNeedQuote = TransNullToBool(value.ToString());
 AddUpdatedFld(conDataTypeAbbr.IsNeedQuote);
}
else if (strAttributeName  ==  conDataTypeAbbr.OraDbType)
{
mstrOraDbType = value.ToString();
 AddUpdatedFld(conDataTypeAbbr.OraDbType);
}
else if (strAttributeName  ==  conDataTypeAbbr.IsReturnType)
{
mbolIsReturnType = TransNullToBool(value.ToString());
 AddUpdatedFld(conDataTypeAbbr.IsReturnType);
}
else if (strAttributeName  ==  conDataTypeAbbr.SqlParaType)
{
mstrSqlParaType = value.ToString();
 AddUpdatedFld(conDataTypeAbbr.SqlParaType);
}
else if (strAttributeName  ==  conDataTypeAbbr.MySqlType)
{
mstrMySqlType = value.ToString();
 AddUpdatedFld(conDataTypeAbbr.MySqlType);
}
else if (strAttributeName  ==  conDataTypeAbbr.DefaFldLength)
{
mintDefaFldLength = TransNullToInt(value.ToString());
 AddUpdatedFld(conDataTypeAbbr.DefaFldLength);
}
else if (strAttributeName  ==  conDataTypeAbbr.DefaFldPrecision)
{
mintDefaFldPrecision = TransNullToInt(value.ToString());
 AddUpdatedFld(conDataTypeAbbr.DefaFldPrecision);
}
else if (strAttributeName  ==  conDataTypeAbbr.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDataTypeAbbr.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conDataTypeAbbr.DataTypeId  ==  _AttributeName[intIndex])
{
return mstrDataTypeId;
}
else if (conDataTypeAbbr.DataTypeName  ==  _AttributeName[intIndex])
{
return mstrDataTypeName;
}
else if (conDataTypeAbbr.DataTypeENName  ==  _AttributeName[intIndex])
{
return mstrDataTypeENName;
}
else if (conDataTypeAbbr.DataCnName  ==  _AttributeName[intIndex])
{
return mstrDataCnName;
}
else if (conDataTypeAbbr.DataTypeAbbr  ==  _AttributeName[intIndex])
{
return mstrDataTypeAbbr;
}
else if (conDataTypeAbbr.NetSysType  ==  _AttributeName[intIndex])
{
return mstrNetSysType;
}
else if (conDataTypeAbbr.VbNetType  ==  _AttributeName[intIndex])
{
return mstrVbNetType;
}
else if (conDataTypeAbbr.CsType  ==  _AttributeName[intIndex])
{
return mstrCsType;
}
else if (conDataTypeAbbr.JavaType  ==  _AttributeName[intIndex])
{
return mstrJavaType;
}
else if (conDataTypeAbbr.TypeScriptType  ==  _AttributeName[intIndex])
{
return mstrTypeScriptType;
}
else if (conDataTypeAbbr.JavaObjType  ==  _AttributeName[intIndex])
{
return mstrJavaObjType;
}
else if (conDataTypeAbbr.SwiftType  ==  _AttributeName[intIndex])
{
return mstrSwiftType;
}
else if (conDataTypeAbbr.IsNeedQuote  ==  _AttributeName[intIndex])
{
return mbolIsNeedQuote;
}
else if (conDataTypeAbbr.OraDbType  ==  _AttributeName[intIndex])
{
return mstrOraDbType;
}
else if (conDataTypeAbbr.IsReturnType  ==  _AttributeName[intIndex])
{
return mbolIsReturnType;
}
else if (conDataTypeAbbr.SqlParaType  ==  _AttributeName[intIndex])
{
return mstrSqlParaType;
}
else if (conDataTypeAbbr.MySqlType  ==  _AttributeName[intIndex])
{
return mstrMySqlType;
}
else if (conDataTypeAbbr.DefaFldLength  ==  _AttributeName[intIndex])
{
return mintDefaFldLength;
}
else if (conDataTypeAbbr.DefaFldPrecision  ==  _AttributeName[intIndex])
{
return mintDefaFldPrecision;
}
else if (conDataTypeAbbr.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conDataTypeAbbr.DataTypeId  ==  _AttributeName[intIndex])
{
mstrDataTypeId = value.ToString();
 AddUpdatedFld(conDataTypeAbbr.DataTypeId);
}
else if (conDataTypeAbbr.DataTypeName  ==  _AttributeName[intIndex])
{
mstrDataTypeName = value.ToString();
 AddUpdatedFld(conDataTypeAbbr.DataTypeName);
}
else if (conDataTypeAbbr.DataTypeENName  ==  _AttributeName[intIndex])
{
mstrDataTypeENName = value.ToString();
 AddUpdatedFld(conDataTypeAbbr.DataTypeENName);
}
else if (conDataTypeAbbr.DataCnName  ==  _AttributeName[intIndex])
{
mstrDataCnName = value.ToString();
 AddUpdatedFld(conDataTypeAbbr.DataCnName);
}
else if (conDataTypeAbbr.DataTypeAbbr  ==  _AttributeName[intIndex])
{
mstrDataTypeAbbr = value.ToString();
 AddUpdatedFld(conDataTypeAbbr.DataTypeAbbr);
}
else if (conDataTypeAbbr.NetSysType  ==  _AttributeName[intIndex])
{
mstrNetSysType = value.ToString();
 AddUpdatedFld(conDataTypeAbbr.NetSysType);
}
else if (conDataTypeAbbr.VbNetType  ==  _AttributeName[intIndex])
{
mstrVbNetType = value.ToString();
 AddUpdatedFld(conDataTypeAbbr.VbNetType);
}
else if (conDataTypeAbbr.CsType  ==  _AttributeName[intIndex])
{
mstrCsType = value.ToString();
 AddUpdatedFld(conDataTypeAbbr.CsType);
}
else if (conDataTypeAbbr.JavaType  ==  _AttributeName[intIndex])
{
mstrJavaType = value.ToString();
 AddUpdatedFld(conDataTypeAbbr.JavaType);
}
else if (conDataTypeAbbr.TypeScriptType  ==  _AttributeName[intIndex])
{
mstrTypeScriptType = value.ToString();
 AddUpdatedFld(conDataTypeAbbr.TypeScriptType);
}
else if (conDataTypeAbbr.JavaObjType  ==  _AttributeName[intIndex])
{
mstrJavaObjType = value.ToString();
 AddUpdatedFld(conDataTypeAbbr.JavaObjType);
}
else if (conDataTypeAbbr.SwiftType  ==  _AttributeName[intIndex])
{
mstrSwiftType = value.ToString();
 AddUpdatedFld(conDataTypeAbbr.SwiftType);
}
else if (conDataTypeAbbr.IsNeedQuote  ==  _AttributeName[intIndex])
{
mbolIsNeedQuote = TransNullToBool(value.ToString());
 AddUpdatedFld(conDataTypeAbbr.IsNeedQuote);
}
else if (conDataTypeAbbr.OraDbType  ==  _AttributeName[intIndex])
{
mstrOraDbType = value.ToString();
 AddUpdatedFld(conDataTypeAbbr.OraDbType);
}
else if (conDataTypeAbbr.IsReturnType  ==  _AttributeName[intIndex])
{
mbolIsReturnType = TransNullToBool(value.ToString());
 AddUpdatedFld(conDataTypeAbbr.IsReturnType);
}
else if (conDataTypeAbbr.SqlParaType  ==  _AttributeName[intIndex])
{
mstrSqlParaType = value.ToString();
 AddUpdatedFld(conDataTypeAbbr.SqlParaType);
}
else if (conDataTypeAbbr.MySqlType  ==  _AttributeName[intIndex])
{
mstrMySqlType = value.ToString();
 AddUpdatedFld(conDataTypeAbbr.MySqlType);
}
else if (conDataTypeAbbr.DefaFldLength  ==  _AttributeName[intIndex])
{
mintDefaFldLength = TransNullToInt(value.ToString());
 AddUpdatedFld(conDataTypeAbbr.DefaFldLength);
}
else if (conDataTypeAbbr.DefaFldPrecision  ==  _AttributeName[intIndex])
{
mintDefaFldPrecision = TransNullToInt(value.ToString());
 AddUpdatedFld(conDataTypeAbbr.DefaFldPrecision);
}
else if (conDataTypeAbbr.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDataTypeAbbr.Memo);
}
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
 AddUpdatedFld(conDataTypeAbbr.DataTypeId);
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
 AddUpdatedFld(conDataTypeAbbr.DataTypeName);
}
}
/// <summary>
/// DataTypeENName(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataTypeENName
{
get
{
return mstrDataTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataTypeENName = value;
}
else
{
 mstrDataTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conDataTypeAbbr.DataTypeENName);
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
 AddUpdatedFld(conDataTypeAbbr.DataCnName);
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
 AddUpdatedFld(conDataTypeAbbr.DataTypeAbbr);
}
}
/// <summary>
/// NET系统类型(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string NetSysType
{
get
{
return mstrNetSysType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrNetSysType = value;
}
else
{
 mstrNetSysType = value;
}
//记录修改过的字段
 AddUpdatedFld(conDataTypeAbbr.NetSysType);
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
 AddUpdatedFld(conDataTypeAbbr.VbNetType);
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
 AddUpdatedFld(conDataTypeAbbr.CsType);
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
 AddUpdatedFld(conDataTypeAbbr.JavaType);
}
}
/// <summary>
/// TypeScript类型(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TypeScriptType
{
get
{
return mstrTypeScriptType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTypeScriptType = value;
}
else
{
 mstrTypeScriptType = value;
}
//记录修改过的字段
 AddUpdatedFld(conDataTypeAbbr.TypeScriptType);
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
 AddUpdatedFld(conDataTypeAbbr.JavaObjType);
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
 AddUpdatedFld(conDataTypeAbbr.SwiftType);
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
 AddUpdatedFld(conDataTypeAbbr.IsNeedQuote);
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
 AddUpdatedFld(conDataTypeAbbr.OraDbType);
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
 AddUpdatedFld(conDataTypeAbbr.IsReturnType);
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
 AddUpdatedFld(conDataTypeAbbr.SqlParaType);
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
 AddUpdatedFld(conDataTypeAbbr.MySqlType);
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
 AddUpdatedFld(conDataTypeAbbr.DefaFldLength);
}
}
/// <summary>
/// 默认小数位数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? DefaFldPrecision
{
get
{
return mintDefaFldPrecision;
}
set
{
 mintDefaFldPrecision = value;
//记录修改过的字段
 AddUpdatedFld(conDataTypeAbbr.DefaFldPrecision);
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
 AddUpdatedFld(conDataTypeAbbr.Memo);
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
  return mstrDataTypeId;
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
 /// 数据类型(DataTypeAbbr)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conDataTypeAbbr
{
public const string _CurrTabName = "DataTypeAbbr"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "DataTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"DataTypeId", "DataTypeName", "DataTypeENName", "DataCnName", "DataTypeAbbr", "NetSysType", "VbNetType", "CsType", "JavaType", "TypeScriptType", "JavaObjType", "SwiftType", "IsNeedQuote", "OraDbType", "IsReturnType", "SqlParaType", "MySqlType", "DefaFldLength", "DefaFldPrecision", "Memo"};
//以下是属性变量


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
 /// 常量:"DataTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataTypeENName = "DataTypeENName";    //DataTypeENName

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
 /// 常量:"NetSysType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string NetSysType = "NetSysType";    //NET系统类型

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
 /// 常量:"TypeScriptType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TypeScriptType = "TypeScriptType";    //TypeScript类型

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
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}