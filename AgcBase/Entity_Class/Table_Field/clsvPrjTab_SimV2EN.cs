
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjTab_SimV2EN
 表名:vPrjTab_SimV2(00050610)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:36:14
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
 /// 表vPrjTab_SimV2的关键字(TabId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TabId_vPrjTab_SimV2
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
public K_TabId_vPrjTab_SimV2(string strTabId)
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
 /// <returns>返回:[K_TabId_vPrjTab_SimV2]类型的对象</returns>
public static implicit operator K_TabId_vPrjTab_SimV2(string value)
{
return new K_TabId_vPrjTab_SimV2(value);
}
}
 /// <summary>
 /// v工程表_SimV2(vPrjTab_SimV2)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvPrjTab_SimV2EN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vPrjTab_SimV2"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TabId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = "TabId in (Select TabId from CMProjectPrjTab where CmPrjId='{0}'))"; //前台条件格式串
protected const int _AttributeCount = 8;
public static string[] _AttributeName = new string[] {"TabId", "TabName", "SqlDsTypeId", "FuncModuleAgcId", "TabTypeId", "CacheModeId", "TabStateId", "CmPrjId"};

protected string mstrTabId;    //表ID
protected string mstrTabName;    //表名
protected string mstrSqlDsTypeId;    //数据源类型Id
protected string mstrFuncModuleAgcId;    //功能模块Id
protected string mstrTabTypeId;    //表类型Id
protected string mstrCacheModeId;    //缓存方式Id
protected string mstrTabStateId;    //表状态ID
protected string mstrCmPrjId;    //Cm工程Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvPrjTab_SimV2EN()
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
public clsvPrjTab_SimV2EN(string strTabId)
 {
strTabId = strTabId.Replace("'", "''");
if (strTabId.Length > 8)
{
throw new Exception("在表:vPrjTab_SimV2中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTabId)  ==  true)
{
throw new Exception("在表:vPrjTab_SimV2中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convPrjTab_SimV2.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  convPrjTab_SimV2.TabName)
{
return mstrTabName;
}
else if (strAttributeName  ==  convPrjTab_SimV2.SqlDsTypeId)
{
return mstrSqlDsTypeId;
}
else if (strAttributeName  ==  convPrjTab_SimV2.FuncModuleAgcId)
{
return mstrFuncModuleAgcId;
}
else if (strAttributeName  ==  convPrjTab_SimV2.TabTypeId)
{
return mstrTabTypeId;
}
else if (strAttributeName  ==  convPrjTab_SimV2.CacheModeId)
{
return mstrCacheModeId;
}
else if (strAttributeName  ==  convPrjTab_SimV2.TabStateId)
{
return mstrTabStateId;
}
else if (strAttributeName  ==  convPrjTab_SimV2.CmPrjId)
{
return mstrCmPrjId;
}
return null;
}
set
{
if (strAttributeName  ==  convPrjTab_SimV2.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(convPrjTab_SimV2.TabId);
}
else if (strAttributeName  ==  convPrjTab_SimV2.TabName)
{
mstrTabName = value.ToString();
 AddUpdatedFld(convPrjTab_SimV2.TabName);
}
else if (strAttributeName  ==  convPrjTab_SimV2.SqlDsTypeId)
{
mstrSqlDsTypeId = value.ToString();
 AddUpdatedFld(convPrjTab_SimV2.SqlDsTypeId);
}
else if (strAttributeName  ==  convPrjTab_SimV2.FuncModuleAgcId)
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convPrjTab_SimV2.FuncModuleAgcId);
}
else if (strAttributeName  ==  convPrjTab_SimV2.TabTypeId)
{
mstrTabTypeId = value.ToString();
 AddUpdatedFld(convPrjTab_SimV2.TabTypeId);
}
else if (strAttributeName  ==  convPrjTab_SimV2.CacheModeId)
{
mstrCacheModeId = value.ToString();
 AddUpdatedFld(convPrjTab_SimV2.CacheModeId);
}
else if (strAttributeName  ==  convPrjTab_SimV2.TabStateId)
{
mstrTabStateId = value.ToString();
 AddUpdatedFld(convPrjTab_SimV2.TabStateId);
}
else if (strAttributeName  ==  convPrjTab_SimV2.CmPrjId)
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(convPrjTab_SimV2.CmPrjId);
}
}
}
public object this[int intIndex]
{
get
{
if (convPrjTab_SimV2.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (convPrjTab_SimV2.TabName  ==  _AttributeName[intIndex])
{
return mstrTabName;
}
else if (convPrjTab_SimV2.SqlDsTypeId  ==  _AttributeName[intIndex])
{
return mstrSqlDsTypeId;
}
else if (convPrjTab_SimV2.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
return mstrFuncModuleAgcId;
}
else if (convPrjTab_SimV2.TabTypeId  ==  _AttributeName[intIndex])
{
return mstrTabTypeId;
}
else if (convPrjTab_SimV2.CacheModeId  ==  _AttributeName[intIndex])
{
return mstrCacheModeId;
}
else if (convPrjTab_SimV2.TabStateId  ==  _AttributeName[intIndex])
{
return mstrTabStateId;
}
else if (convPrjTab_SimV2.CmPrjId  ==  _AttributeName[intIndex])
{
return mstrCmPrjId;
}
return null;
}
set
{
if (convPrjTab_SimV2.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(convPrjTab_SimV2.TabId);
}
else if (convPrjTab_SimV2.TabName  ==  _AttributeName[intIndex])
{
mstrTabName = value.ToString();
 AddUpdatedFld(convPrjTab_SimV2.TabName);
}
else if (convPrjTab_SimV2.SqlDsTypeId  ==  _AttributeName[intIndex])
{
mstrSqlDsTypeId = value.ToString();
 AddUpdatedFld(convPrjTab_SimV2.SqlDsTypeId);
}
else if (convPrjTab_SimV2.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convPrjTab_SimV2.FuncModuleAgcId);
}
else if (convPrjTab_SimV2.TabTypeId  ==  _AttributeName[intIndex])
{
mstrTabTypeId = value.ToString();
 AddUpdatedFld(convPrjTab_SimV2.TabTypeId);
}
else if (convPrjTab_SimV2.CacheModeId  ==  _AttributeName[intIndex])
{
mstrCacheModeId = value.ToString();
 AddUpdatedFld(convPrjTab_SimV2.CacheModeId);
}
else if (convPrjTab_SimV2.TabStateId  ==  _AttributeName[intIndex])
{
mstrTabStateId = value.ToString();
 AddUpdatedFld(convPrjTab_SimV2.TabStateId);
}
else if (convPrjTab_SimV2.CmPrjId  ==  _AttributeName[intIndex])
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(convPrjTab_SimV2.CmPrjId);
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
 AddUpdatedFld(convPrjTab_SimV2.TabId);
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
 AddUpdatedFld(convPrjTab_SimV2.TabName);
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
 AddUpdatedFld(convPrjTab_SimV2.SqlDsTypeId);
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
 AddUpdatedFld(convPrjTab_SimV2.FuncModuleAgcId);
}
}
/// <summary>
/// 表类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabTypeId
{
get
{
return mstrTabTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabTypeId = value;
}
else
{
 mstrTabTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjTab_SimV2.TabTypeId);
}
}
/// <summary>
/// 缓存方式Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CacheModeId
{
get
{
return mstrCacheModeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCacheModeId = value;
}
else
{
 mstrCacheModeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjTab_SimV2.CacheModeId);
}
}
/// <summary>
/// 表状态ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabStateId
{
get
{
return mstrTabStateId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabStateId = value;
}
else
{
 mstrTabStateId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjTab_SimV2.TabStateId);
}
}
/// <summary>
/// Cm工程Id(说明:;字段类型:char;字段长度:6;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CmPrjId
{
get
{
return mstrCmPrjId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCmPrjId = value;
}
else
{
 mstrCmPrjId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjTab_SimV2.CmPrjId);
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
 /// v工程表_SimV2(vPrjTab_SimV2)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convPrjTab_SimV2
{
public const string _CurrTabName = "vPrjTab_SimV2"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TabId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"TabId", "TabName", "SqlDsTypeId", "FuncModuleAgcId", "TabTypeId", "CacheModeId", "TabStateId", "CmPrjId"};
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
 /// 常量:"SqlDsTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SqlDsTypeId = "SqlDsTypeId";    //数据源类型Id

 /// <summary>
 /// 常量:"FuncModuleAgcId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleAgcId = "FuncModuleAgcId";    //功能模块Id

 /// <summary>
 /// 常量:"TabTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabTypeId = "TabTypeId";    //表类型Id

 /// <summary>
 /// 常量:"CacheModeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CacheModeId = "CacheModeId";    //缓存方式Id

 /// <summary>
 /// 常量:"TabStateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabStateId = "TabStateId";    //表状态ID

 /// <summary>
 /// 常量:"CmPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CmPrjId = "CmPrjId";    //Cm工程Id
}

}