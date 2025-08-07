
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsImportLevelEN
 表名:ImportLevel(00050065)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:15:10
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统参数(SysPara)
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
 /// 表ImportLevel的关键字(ImportLevelId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ImportLevelId_ImportLevel
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strImportLevelId">表关键字</param>
public K_ImportLevelId_ImportLevel(string strImportLevelId)
{
if (IsValid(strImportLevelId)) Value = strImportLevelId;
else
{
Value = null;
}
}
private static bool IsValid(string strImportLevelId)
{
if (string.IsNullOrEmpty(strImportLevelId) == true) return false;
if (strImportLevelId.Length > 4) return false;
if (strImportLevelId.IndexOf(' ') >= 0) return false;
if (strImportLevelId.IndexOf(')') >= 0) return false;
if (strImportLevelId.IndexOf('(') >= 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ImportLevelId_ImportLevel]类型的对象</returns>
public static implicit operator K_ImportLevelId_ImportLevel(string value)
{
return new K_ImportLevelId_ImportLevel(value);
}
}
 /// <summary>
 /// 重要程度(ImportLevel)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsImportLevelEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接，如果为空就使用系统默认的连接
public new const string _CurrTabName = "ImportLevel"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ImportLevelId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string WhereFormat = ""; //条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"ImportLevelId", "ImportLevelName", "Memo"};

protected string mstrImportLevelId;    //重要程度Id
protected string mstrImportLevelName;    //重要程度名称
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsImportLevelEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "ImportLevel";
 lstKeyFldNames.Add("ImportLevelId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strImportLevelId">关键字:重要程度Id</param>
public clsImportLevelEN(string strImportLevelId)
 {
strImportLevelId = strImportLevelId.Replace("'", "''");
if (strImportLevelId.Length > 4)
{
throw new Exception("在表:ImportLevel中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strImportLevelId)  ==  true)
{
throw new Exception("在表:ImportLevel中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strImportLevelId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrImportLevelId = strImportLevelId;
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "ImportLevel";
 lstKeyFldNames.Add("ImportLevelId");
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
if (strAttributeName  ==  conImportLevel.ImportLevelId)
{
return mstrImportLevelId;
}
else if (strAttributeName  ==  conImportLevel.ImportLevelName)
{
return mstrImportLevelName;
}
else if (strAttributeName  ==  conImportLevel.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conImportLevel.ImportLevelId)
{
mstrImportLevelId = value.ToString();
 AddUpdatedFld(conImportLevel.ImportLevelId);
}
else if (strAttributeName  ==  conImportLevel.ImportLevelName)
{
mstrImportLevelName = value.ToString();
 AddUpdatedFld(conImportLevel.ImportLevelName);
}
else if (strAttributeName  ==  conImportLevel.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conImportLevel.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conImportLevel.ImportLevelId  ==  AttributeName[intIndex])
{
return mstrImportLevelId;
}
else if (conImportLevel.ImportLevelName  ==  AttributeName[intIndex])
{
return mstrImportLevelName;
}
else if (conImportLevel.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conImportLevel.ImportLevelId  ==  AttributeName[intIndex])
{
mstrImportLevelId = value.ToString();
 AddUpdatedFld(conImportLevel.ImportLevelId);
}
else if (conImportLevel.ImportLevelName  ==  AttributeName[intIndex])
{
mstrImportLevelName = value.ToString();
 AddUpdatedFld(conImportLevel.ImportLevelName);
}
else if (conImportLevel.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conImportLevel.Memo);
}
}
}

/// <summary>
/// 重要程度Id(说明:;字段类型:varchar;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ImportLevelId
{
get
{
return mstrImportLevelId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrImportLevelId = value;
}
else
{
 mstrImportLevelId = value;
}
//记录修改过的字段
 AddUpdatedFld(conImportLevel.ImportLevelId);
}
}
/// <summary>
/// 重要程度名称(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ImportLevelName
{
get
{
return mstrImportLevelName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrImportLevelName = value;
}
else
{
 mstrImportLevelName = value;
}
//记录修改过的字段
 AddUpdatedFld(conImportLevel.ImportLevelName);
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
 AddUpdatedFld(conImportLevel.Memo);
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
  return mstrImportLevelId;
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
  return mstrImportLevelName;
 }
 }
}
 /// <summary>
 /// 重要程度(ImportLevel)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conImportLevel
{
public new const string _CurrTabName = "ImportLevel"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ImportLevelId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ImportLevelId", "ImportLevelName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"ImportLevelId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ImportLevelId = "ImportLevelId";    //重要程度Id

 /// <summary>
 /// 常量:"ImportLevelName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ImportLevelName = "ImportLevelName";    //重要程度名称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}