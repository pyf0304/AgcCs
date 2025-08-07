
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjTab4DdlEN
 表名:vPrjTab4Ddl(00050336)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:36:52
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
 /// 表vPrjTab4Ddl的关键字(TabId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TabId_vPrjTab4Ddl
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strTabId">表关键字</param>
public K_TabId_vPrjTab4Ddl(string strTabId)
{
if (IsValid(strTabId)) Value = strTabId;
else
{
Value = null;
}
}
private static bool IsValid(string strTabId)
{
if (string.IsNullOrEmpty(strTabId) == true) return false;
if (strTabId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_TabId_vPrjTab4Ddl]类型的对象</returns>
public static implicit operator K_TabId_vPrjTab4Ddl(string value)
{
return new K_TabId_vPrjTab4Ddl(value);
}
}
 /// <summary>
 /// v工程表4Ddl(vPrjTab4Ddl)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvPrjTab4DdlEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vPrjTab4Ddl"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TabId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 5;
public static string[] _AttributeName = new string[] {"TabId", "TabName", "PrjId", "SqlDsTypeId", "FuncModuleAgcId"};

protected string mstrTabId;    //表ID
protected string mstrTabName;    //表名
protected string mstrPrjId;    //工程Id
protected string mstrSqlDsTypeId;    //数据源类型Id
protected string mstrFuncModuleAgcId;    //功能模块Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvPrjTab4DdlEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TabId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strTabId">关键字:表ID</param>
public clsvPrjTab4DdlEN(string strTabId)
 {
strTabId = strTabId.Replace("'", "''");
if (strTabId.Length > 8)
{
throw new Exception("在表:vPrjTab4Ddl中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTabId)  ==  true)
{
throw new Exception("在表:vPrjTab4Ddl中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTabId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrTabId = strTabId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TabId");
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
if (strAttributeName  ==  convPrjTab4Ddl.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  convPrjTab4Ddl.TabName)
{
return mstrTabName;
}
else if (strAttributeName  ==  convPrjTab4Ddl.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convPrjTab4Ddl.SqlDsTypeId)
{
return mstrSqlDsTypeId;
}
else if (strAttributeName  ==  convPrjTab4Ddl.FuncModuleAgcId)
{
return mstrFuncModuleAgcId;
}
return null;
}
set
{
if (strAttributeName  ==  convPrjTab4Ddl.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(convPrjTab4Ddl.TabId);
}
else if (strAttributeName  ==  convPrjTab4Ddl.TabName)
{
mstrTabName = value.ToString();
 AddUpdatedFld(convPrjTab4Ddl.TabName);
}
else if (strAttributeName  ==  convPrjTab4Ddl.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convPrjTab4Ddl.PrjId);
}
else if (strAttributeName  ==  convPrjTab4Ddl.SqlDsTypeId)
{
mstrSqlDsTypeId = value.ToString();
 AddUpdatedFld(convPrjTab4Ddl.SqlDsTypeId);
}
else if (strAttributeName  ==  convPrjTab4Ddl.FuncModuleAgcId)
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convPrjTab4Ddl.FuncModuleAgcId);
}
}
}
public object this[int intIndex]
{
get
{
if (convPrjTab4Ddl.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (convPrjTab4Ddl.TabName  ==  _AttributeName[intIndex])
{
return mstrTabName;
}
else if (convPrjTab4Ddl.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convPrjTab4Ddl.SqlDsTypeId  ==  _AttributeName[intIndex])
{
return mstrSqlDsTypeId;
}
else if (convPrjTab4Ddl.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
return mstrFuncModuleAgcId;
}
return null;
}
set
{
if (convPrjTab4Ddl.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(convPrjTab4Ddl.TabId);
}
else if (convPrjTab4Ddl.TabName  ==  _AttributeName[intIndex])
{
mstrTabName = value.ToString();
 AddUpdatedFld(convPrjTab4Ddl.TabName);
}
else if (convPrjTab4Ddl.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convPrjTab4Ddl.PrjId);
}
else if (convPrjTab4Ddl.SqlDsTypeId  ==  _AttributeName[intIndex])
{
mstrSqlDsTypeId = value.ToString();
 AddUpdatedFld(convPrjTab4Ddl.SqlDsTypeId);
}
else if (convPrjTab4Ddl.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convPrjTab4Ddl.FuncModuleAgcId);
}
}
}

/// <summary>
/// 表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabId
{
get
{
return mstrTabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabId = value;
}
else
{
 mstrTabId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjTab4Ddl.TabId);
}
}
/// <summary>
/// 表名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabName
{
get
{
return mstrTabName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabName = value;
}
else
{
 mstrTabName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjTab4Ddl.TabName);
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
 AddUpdatedFld(convPrjTab4Ddl.PrjId);
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
 AddUpdatedFld(convPrjTab4Ddl.SqlDsTypeId);
}
}
/// <summary>
/// 功能模块Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleAgcId
{
get
{
return mstrFuncModuleAgcId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleAgcId = value;
}
else
{
 mstrFuncModuleAgcId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjTab4Ddl.FuncModuleAgcId);
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
  return mstrTabId;
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
  return mstrTabName;
 }
 }
}
 /// <summary>
 /// v工程表4Ddl(vPrjTab4Ddl)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convPrjTab4Ddl
{
public const string _CurrTabName = "vPrjTab4Ddl"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TabId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"TabId", "TabName", "PrjId", "SqlDsTypeId", "FuncModuleAgcId"};
//以下是属性变量


 /// <summary>
 /// 常量:"TabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabId = "TabId";    //表ID

 /// <summary>
 /// 常量:"TabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabName = "TabName";    //表名

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"SqlDsTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SqlDsTypeId = "SqlDsTypeId";    //数据源类型Id

 /// <summary>
 /// 常量:"FuncModuleAgcId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleAgcId = "FuncModuleAgcId";    //功能模块Id
}

}