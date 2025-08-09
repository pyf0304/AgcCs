
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSQLDSTypeEN
 表名:SQLDSType(00050014)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:02:47
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:界面管理(PrjInterface)
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
 /// 表SQLDSType的关键字(SqlDsTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_SqlDsTypeId_SQLDSType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strSqlDsTypeId">表关键字</param>
public K_SqlDsTypeId_SQLDSType(string strSqlDsTypeId)
{
if (IsValid(strSqlDsTypeId)) Value = strSqlDsTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strSqlDsTypeId)
{
if (string.IsNullOrEmpty(strSqlDsTypeId) == true) return false;
if (strSqlDsTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_SqlDsTypeId_SQLDSType]类型的对象</returns>
public static implicit operator K_SqlDsTypeId_SQLDSType(string value)
{
return new K_SqlDsTypeId_SQLDSType(value);
}
}
 /// <summary>
 /// 数据源类型(SQLDSType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsSQLDSTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "SQLDSType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "SqlDsTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 4;
public static string[] _AttributeName = new string[] {"SqlDsTypeId", "SqlDsTypeName", "SqlDsTypeENName", "Memo"};

protected string mstrSqlDsTypeId;    //数据源类型Id
protected string mstrSqlDsTypeName;    //Sql数据源名
protected string mstrSqlDsTypeENName;    //Sql数据源英文名
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsSQLDSTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("SqlDsTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strSqlDsTypeId">关键字:数据源类型Id</param>
public clsSQLDSTypeEN(string strSqlDsTypeId)
 {
strSqlDsTypeId = strSqlDsTypeId.Replace("'", "''");
if (strSqlDsTypeId.Length > 2)
{
throw new Exception("在表:SQLDSType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strSqlDsTypeId)  ==  true)
{
throw new Exception("在表:SQLDSType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strSqlDsTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrSqlDsTypeId = strSqlDsTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("SqlDsTypeId");
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
if (strAttributeName  ==  conSQLDSType.SqlDsTypeId)
{
return mstrSqlDsTypeId;
}
else if (strAttributeName  ==  conSQLDSType.SqlDsTypeName)
{
return mstrSqlDsTypeName;
}
else if (strAttributeName  ==  conSQLDSType.SqlDsTypeENName)
{
return mstrSqlDsTypeENName;
}
else if (strAttributeName  ==  conSQLDSType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conSQLDSType.SqlDsTypeId)
{
mstrSqlDsTypeId = value.ToString();
 AddUpdatedFld(conSQLDSType.SqlDsTypeId);
}
else if (strAttributeName  ==  conSQLDSType.SqlDsTypeName)
{
mstrSqlDsTypeName = value.ToString();
 AddUpdatedFld(conSQLDSType.SqlDsTypeName);
}
else if (strAttributeName  ==  conSQLDSType.SqlDsTypeENName)
{
mstrSqlDsTypeENName = value.ToString();
 AddUpdatedFld(conSQLDSType.SqlDsTypeENName);
}
else if (strAttributeName  ==  conSQLDSType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSQLDSType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conSQLDSType.SqlDsTypeId  ==  _AttributeName[intIndex])
{
return mstrSqlDsTypeId;
}
else if (conSQLDSType.SqlDsTypeName  ==  _AttributeName[intIndex])
{
return mstrSqlDsTypeName;
}
else if (conSQLDSType.SqlDsTypeENName  ==  _AttributeName[intIndex])
{
return mstrSqlDsTypeENName;
}
else if (conSQLDSType.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conSQLDSType.SqlDsTypeId  ==  _AttributeName[intIndex])
{
mstrSqlDsTypeId = value.ToString();
 AddUpdatedFld(conSQLDSType.SqlDsTypeId);
}
else if (conSQLDSType.SqlDsTypeName  ==  _AttributeName[intIndex])
{
mstrSqlDsTypeName = value.ToString();
 AddUpdatedFld(conSQLDSType.SqlDsTypeName);
}
else if (conSQLDSType.SqlDsTypeENName  ==  _AttributeName[intIndex])
{
mstrSqlDsTypeENName = value.ToString();
 AddUpdatedFld(conSQLDSType.SqlDsTypeENName);
}
else if (conSQLDSType.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSQLDSType.Memo);
}
}
}

/// <summary>
/// 数据源类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SqlDsTypeId
{
get
{
return mstrSqlDsTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSqlDsTypeId = value;
}
else
{
 mstrSqlDsTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSQLDSType.SqlDsTypeId);
}
}
/// <summary>
/// Sql数据源名(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SqlDsTypeName
{
get
{
return mstrSqlDsTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSqlDsTypeName = value;
}
else
{
 mstrSqlDsTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conSQLDSType.SqlDsTypeName);
}
}
/// <summary>
/// Sql数据源英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SqlDsTypeENName
{
get
{
return mstrSqlDsTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSqlDsTypeENName = value;
}
else
{
 mstrSqlDsTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conSQLDSType.SqlDsTypeENName);
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
 AddUpdatedFld(conSQLDSType.Memo);
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
  return mstrSqlDsTypeId;
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
  return mstrSqlDsTypeName;
 }
 }
}
 /// <summary>
 /// 数据源类型(SQLDSType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conSQLDSType
{
public const string _CurrTabName = "SQLDSType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "SqlDsTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"SqlDsTypeId", "SqlDsTypeName", "SqlDsTypeENName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"SqlDsTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SqlDsTypeId = "SqlDsTypeId";    //数据源类型Id

 /// <summary>
 /// 常量:"SqlDsTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SqlDsTypeName = "SqlDsTypeName";    //Sql数据源名

 /// <summary>
 /// 常量:"SqlDsTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SqlDsTypeENName = "SqlDsTypeENName";    //Sql数据源英文名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}