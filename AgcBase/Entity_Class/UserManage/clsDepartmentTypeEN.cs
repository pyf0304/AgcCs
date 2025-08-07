
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDepartmentTypeEN
 表名:DepartmentType(00050306)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:13:59
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:用户管理(UserManage)
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
 /// 表DepartmentType的关键字(DepartmentTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_DepartmentTypeId_DepartmentType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strDepartmentTypeId">表关键字</param>
public K_DepartmentTypeId_DepartmentType(string strDepartmentTypeId)
{
if (IsValid(strDepartmentTypeId)) Value = strDepartmentTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strDepartmentTypeId)
{
if (strDepartmentTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_DepartmentTypeId_DepartmentType]类型的对象</returns>
public static implicit operator K_DepartmentTypeId_DepartmentType(string value)
{
return new K_DepartmentTypeId_DepartmentType(value);
}
}
 /// <summary>
 /// 部门类型(DepartmentType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsDepartmentTypeEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接，如果为空就使用系统默认的连接
public new const string _CurrTabName = "DepartmentType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "DepartmentTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string WhereFormat = ""; //条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"DepartmentTypeId", "DepartmentTypeName", "Memo"};

protected string mstrDepartmentTypeId;    //部门类型Id
protected string mstrDepartmentTypeName;    //部门类型
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsDepartmentTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "DepartmentType";
 lstKeyFldNames.Add("DepartmentTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strDepartmentTypeId">关键字:部门类型Id</param>
public clsDepartmentTypeEN(string strDepartmentTypeId)
 {
strDepartmentTypeId = strDepartmentTypeId.Replace("'", "''");
if (strDepartmentTypeId.Length > 2)
{
throw new Exception("在表:DepartmentType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strDepartmentTypeId)  ==  true)
{
throw new Exception("在表:DepartmentType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strDepartmentTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrDepartmentTypeId = strDepartmentTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "DepartmentType";
 lstKeyFldNames.Add("DepartmentTypeId");
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
if (strAttributeName  ==  conDepartmentType.DepartmentTypeId)
{
return mstrDepartmentTypeId;
}
else if (strAttributeName  ==  conDepartmentType.DepartmentTypeName)
{
return mstrDepartmentTypeName;
}
else if (strAttributeName  ==  conDepartmentType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conDepartmentType.DepartmentTypeId)
{
mstrDepartmentTypeId = value.ToString();
 AddUpdatedFld(conDepartmentType.DepartmentTypeId);
}
else if (strAttributeName  ==  conDepartmentType.DepartmentTypeName)
{
mstrDepartmentTypeName = value.ToString();
 AddUpdatedFld(conDepartmentType.DepartmentTypeName);
}
else if (strAttributeName  ==  conDepartmentType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDepartmentType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conDepartmentType.DepartmentTypeId  ==  AttributeName[intIndex])
{
return mstrDepartmentTypeId;
}
else if (conDepartmentType.DepartmentTypeName  ==  AttributeName[intIndex])
{
return mstrDepartmentTypeName;
}
else if (conDepartmentType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conDepartmentType.DepartmentTypeId  ==  AttributeName[intIndex])
{
mstrDepartmentTypeId = value.ToString();
 AddUpdatedFld(conDepartmentType.DepartmentTypeId);
}
else if (conDepartmentType.DepartmentTypeName  ==  AttributeName[intIndex])
{
mstrDepartmentTypeName = value.ToString();
 AddUpdatedFld(conDepartmentType.DepartmentTypeName);
}
else if (conDepartmentType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDepartmentType.Memo);
}
}
}

/// <summary>
/// 部门类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DepartmentTypeId
{
get
{
return mstrDepartmentTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDepartmentTypeId = value;
}
else
{
 mstrDepartmentTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conDepartmentType.DepartmentTypeId);
}
}
/// <summary>
/// 部门类型(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DepartmentTypeName
{
get
{
return mstrDepartmentTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDepartmentTypeName = value;
}
else
{
 mstrDepartmentTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conDepartmentType.DepartmentTypeName);
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
 AddUpdatedFld(conDepartmentType.Memo);
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
  return mstrDepartmentTypeId;
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
  return mstrDepartmentTypeName;
 }
 }
}
 /// <summary>
 /// 部门类型(DepartmentType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conDepartmentType
{
public new const string _CurrTabName = "DepartmentType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "DepartmentTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"DepartmentTypeId", "DepartmentTypeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"DepartmentTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DepartmentTypeId = "DepartmentTypeId";    //部门类型Id

 /// <summary>
 /// 常量:"DepartmentTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DepartmentTypeName = "DepartmentTypeName";    //部门类型

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}