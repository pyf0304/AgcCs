
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSqlCommandTypeEN
 表名:SqlCommandType(00050272)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:15:57
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:数据同步(DataSynch)
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
 /// 表SqlCommandType的关键字(SqlCommandTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_SqlCommandTypeId_SqlCommandType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strSqlCommandTypeId">表关键字</param>
public K_SqlCommandTypeId_SqlCommandType(string strSqlCommandTypeId)
{
if (IsValid(strSqlCommandTypeId)) Value = strSqlCommandTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strSqlCommandTypeId)
{
if (string.IsNullOrEmpty(strSqlCommandTypeId) == true) return false;
if (strSqlCommandTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_SqlCommandTypeId_SqlCommandType]类型的对象</returns>
public static implicit operator K_SqlCommandTypeId_SqlCommandType(string value)
{
return new K_SqlCommandTypeId_SqlCommandType(value);
}
}
 /// <summary>
 /// Sql命令类型(SqlCommandType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsSqlCommandTypeEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接，如果为空就使用系统默认的连接
public new const string _CurrTabName = "SqlCommandType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "SqlCommandTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string WhereFormat = ""; //条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"SqlCommandTypeId", "SqlCommandTypeName", "Memo"};

protected string mstrSqlCommandTypeId;    //Sql命令类型Id
protected string mstrSqlCommandTypeName;    //Sql命令类型名称
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsSqlCommandTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "SqlCommandType";
 lstKeyFldNames.Add("SqlCommandTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strSqlCommandTypeId">关键字:Sql命令类型Id</param>
public clsSqlCommandTypeEN(string strSqlCommandTypeId)
 {
strSqlCommandTypeId = strSqlCommandTypeId.Replace("'", "''");
if (strSqlCommandTypeId.Length > 2)
{
throw new Exception("在表:SqlCommandType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strSqlCommandTypeId)  ==  true)
{
throw new Exception("在表:SqlCommandType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strSqlCommandTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrSqlCommandTypeId = strSqlCommandTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "SqlCommandType";
 lstKeyFldNames.Add("SqlCommandTypeId");
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
if (strAttributeName  ==  conSqlCommandType.SqlCommandTypeId)
{
return mstrSqlCommandTypeId;
}
else if (strAttributeName  ==  conSqlCommandType.SqlCommandTypeName)
{
return mstrSqlCommandTypeName;
}
else if (strAttributeName  ==  conSqlCommandType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conSqlCommandType.SqlCommandTypeId)
{
mstrSqlCommandTypeId = value.ToString();
 AddUpdatedFld(conSqlCommandType.SqlCommandTypeId);
}
else if (strAttributeName  ==  conSqlCommandType.SqlCommandTypeName)
{
mstrSqlCommandTypeName = value.ToString();
 AddUpdatedFld(conSqlCommandType.SqlCommandTypeName);
}
else if (strAttributeName  ==  conSqlCommandType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSqlCommandType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conSqlCommandType.SqlCommandTypeId  ==  AttributeName[intIndex])
{
return mstrSqlCommandTypeId;
}
else if (conSqlCommandType.SqlCommandTypeName  ==  AttributeName[intIndex])
{
return mstrSqlCommandTypeName;
}
else if (conSqlCommandType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conSqlCommandType.SqlCommandTypeId  ==  AttributeName[intIndex])
{
mstrSqlCommandTypeId = value.ToString();
 AddUpdatedFld(conSqlCommandType.SqlCommandTypeId);
}
else if (conSqlCommandType.SqlCommandTypeName  ==  AttributeName[intIndex])
{
mstrSqlCommandTypeName = value.ToString();
 AddUpdatedFld(conSqlCommandType.SqlCommandTypeName);
}
else if (conSqlCommandType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSqlCommandType.Memo);
}
}
}

/// <summary>
/// Sql命令类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SqlCommandTypeId
{
get
{
return mstrSqlCommandTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSqlCommandTypeId = value;
}
else
{
 mstrSqlCommandTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSqlCommandType.SqlCommandTypeId);
}
}
/// <summary>
/// Sql命令类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SqlCommandTypeName
{
get
{
return mstrSqlCommandTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSqlCommandTypeName = value;
}
else
{
 mstrSqlCommandTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conSqlCommandType.SqlCommandTypeName);
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
 AddUpdatedFld(conSqlCommandType.Memo);
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
  return mstrSqlCommandTypeId;
 }
 }

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrSqlCommandTypeName;
 }
 }
}
 /// <summary>
 /// Sql命令类型(SqlCommandType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conSqlCommandType
{
public new const string _CurrTabName = "SqlCommandType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "SqlCommandTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"SqlCommandTypeId", "SqlCommandTypeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"SqlCommandTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SqlCommandTypeId = "SqlCommandTypeId";    //Sql命令类型Id

 /// <summary>
 /// 常量:"SqlCommandTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SqlCommandTypeName = "SqlCommandTypeName";    //Sql命令类型名称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}