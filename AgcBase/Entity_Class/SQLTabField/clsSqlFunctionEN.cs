
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSqlFunctionEN
 表名:SqlFunction(00050299)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:16:06
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:SQL表字段管理(SQLTabField)
 框架-层名:实体层(CS)(EntityLayer)
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

namespace AGC.Entity
{
 /// <summary>
 /// 表SqlFunction的关键字(SqlFunctionId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_SqlFunctionId_SqlFunction
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strSqlFunctionId">表关键字</param>
public K_SqlFunctionId_SqlFunction(string strSqlFunctionId)
{
if (IsValid(strSqlFunctionId)) Value = strSqlFunctionId;
else
{
Value = null;
}
}
private static bool IsValid(string strSqlFunctionId)
{
if (string.IsNullOrEmpty(strSqlFunctionId) == true) return false;
if (strSqlFunctionId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_SqlFunctionId_SqlFunction]类型的对象</returns>
public static implicit operator K_SqlFunctionId_SqlFunction(string value)
{
return new K_SqlFunctionId_SqlFunction(value);
}
}
 /// <summary>
 /// Sql函数(SqlFunction)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsSqlFunctionEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接，如果为空就使用系统默认的连接
public new const string _CurrTabName = "SqlFunction"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "SqlFunctionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string WhereFormat = ""; //条件格式串
protected const int mintAttributeCount = 2;
public static string[] AttributeName = new string[] {"SqlFunctionId", "SqlFunctionName"};

protected string mstrSqlFunctionId;    //Sql函数Id
protected string mstrSqlFunctionName;    //Sql函数名

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsSqlFunctionEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "SqlFunction";
 lstKeyFldNames.Add("SqlFunctionId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strSqlFunctionId">关键字:Sql函数Id</param>
public clsSqlFunctionEN(string strSqlFunctionId)
 {
strSqlFunctionId = strSqlFunctionId.Replace("'", "''");
if (strSqlFunctionId.Length > 8)
{
throw new Exception("在表:SqlFunction中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strSqlFunctionId)  ==  true)
{
throw new Exception("在表:SqlFunction中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strSqlFunctionId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrSqlFunctionId = strSqlFunctionId;
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "SqlFunction";
 lstKeyFldNames.Add("SqlFunctionId");
 }

public static int AttributeCount
{
get
{
return mintAttributeCount;
}
}
public override object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  conSqlFunction.SqlFunctionId)
{
return mstrSqlFunctionId;
}
else if (strAttributeName  ==  conSqlFunction.SqlFunctionName)
{
return mstrSqlFunctionName;
}
return null;
}
set
{
if (strAttributeName  ==  conSqlFunction.SqlFunctionId)
{
mstrSqlFunctionId = value.ToString();
 AddUpdatedFld(conSqlFunction.SqlFunctionId);
}
else if (strAttributeName  ==  conSqlFunction.SqlFunctionName)
{
mstrSqlFunctionName = value.ToString();
 AddUpdatedFld(conSqlFunction.SqlFunctionName);
}
}
}
public object this[int intIndex]
{
get
{
if (conSqlFunction.SqlFunctionId  ==  AttributeName[intIndex])
{
return mstrSqlFunctionId;
}
else if (conSqlFunction.SqlFunctionName  ==  AttributeName[intIndex])
{
return mstrSqlFunctionName;
}
return null;
}
set
{
if (conSqlFunction.SqlFunctionId  ==  AttributeName[intIndex])
{
mstrSqlFunctionId = value.ToString();
 AddUpdatedFld(conSqlFunction.SqlFunctionId);
}
else if (conSqlFunction.SqlFunctionName  ==  AttributeName[intIndex])
{
mstrSqlFunctionName = value.ToString();
 AddUpdatedFld(conSqlFunction.SqlFunctionName);
}
}
}

/// <summary>
/// Sql函数Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SqlFunctionId
{
get
{
return mstrSqlFunctionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSqlFunctionId = value;
}
else
{
 mstrSqlFunctionId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSqlFunction.SqlFunctionId);
}
}
/// <summary>
/// Sql函数名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SqlFunctionName
{
get
{
return mstrSqlFunctionName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSqlFunctionName = value;
}
else
{
 mstrSqlFunctionName = value;
}
//记录修改过的字段
 AddUpdatedFld(conSqlFunction.SqlFunctionName);
}
}

/// <summary>
/// 获取关键字Id(keyId)
 /// (AutoGCLib.clsGeneCodeBase:GenGetKeyId)
/// </summary>
 public override string _KeyId
 {
 get
 {
  return mstrSqlFunctionId;
 }
 }
}
 /// <summary>
 /// Sql函数(SqlFunction)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conSqlFunction
{
public new const string _CurrTabName = "SqlFunction"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "SqlFunctionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"SqlFunctionId", "SqlFunctionName"};
//以下是属性变量


 /// <summary>
 /// 常量:"SqlFunctionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SqlFunctionId = "SqlFunctionId";    //Sql函数Id

 /// <summary>
 /// 常量:"SqlFunctionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SqlFunctionName = "SqlFunctionName";    //Sql函数名
}

}