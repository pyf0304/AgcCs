
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDataBaseTypeEN
 表名:DataBaseType(00050159)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:13:41
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
 /// 表DataBaseType的关键字(DataBaseTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_DataBaseTypeId_DataBaseType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strDataBaseTypeId">表关键字</param>
public K_DataBaseTypeId_DataBaseType(string strDataBaseTypeId)
{
if (IsValid(strDataBaseTypeId)) Value = strDataBaseTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strDataBaseTypeId)
{
if (string.IsNullOrEmpty(strDataBaseTypeId) == true) return false;
if (strDataBaseTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_DataBaseTypeId_DataBaseType]类型的对象</returns>
public static implicit operator K_DataBaseTypeId_DataBaseType(string value)
{
return new K_DataBaseTypeId_DataBaseType(value);
}
}
 /// <summary>
 /// 数据库类型(DataBaseType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsDataBaseTypeEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接，如果为空就使用系统默认的连接
public new const string _CurrTabName = "DataBaseType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "DataBaseTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string WhereFormat = ""; //条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"DataBaseTypeId", "DataBaseTypeName", "DataBaseTypeENName", "DataBaseTypeSimName", "Memo"};

protected string mstrDataBaseTypeId;    //数据库类型ID
protected string mstrDataBaseTypeName;    //数据库类型名
protected string mstrDataBaseTypeENName;    //数据库类型英文名
protected string mstrDataBaseTypeSimName;    //数据库类型简名
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsDataBaseTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "DataBaseType";
 lstKeyFldNames.Add("DataBaseTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strDataBaseTypeId">关键字:数据库类型ID</param>
public clsDataBaseTypeEN(string strDataBaseTypeId)
 {
strDataBaseTypeId = strDataBaseTypeId.Replace("'", "''");
if (strDataBaseTypeId.Length > 2)
{
throw new Exception("在表:DataBaseType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strDataBaseTypeId)  ==  true)
{
throw new Exception("在表:DataBaseType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strDataBaseTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrDataBaseTypeId = strDataBaseTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "DataBaseType";
 lstKeyFldNames.Add("DataBaseTypeId");
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
if (strAttributeName  ==  conDataBaseType.DataBaseTypeId)
{
return mstrDataBaseTypeId;
}
else if (strAttributeName  ==  conDataBaseType.DataBaseTypeName)
{
return mstrDataBaseTypeName;
}
else if (strAttributeName  ==  conDataBaseType.DataBaseTypeENName)
{
return mstrDataBaseTypeENName;
}
else if (strAttributeName  ==  conDataBaseType.DataBaseTypeSimName)
{
return mstrDataBaseTypeSimName;
}
else if (strAttributeName  ==  conDataBaseType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conDataBaseType.DataBaseTypeId)
{
mstrDataBaseTypeId = value.ToString();
 AddUpdatedFld(conDataBaseType.DataBaseTypeId);
}
else if (strAttributeName  ==  conDataBaseType.DataBaseTypeName)
{
mstrDataBaseTypeName = value.ToString();
 AddUpdatedFld(conDataBaseType.DataBaseTypeName);
}
else if (strAttributeName  ==  conDataBaseType.DataBaseTypeENName)
{
mstrDataBaseTypeENName = value.ToString();
 AddUpdatedFld(conDataBaseType.DataBaseTypeENName);
}
else if (strAttributeName  ==  conDataBaseType.DataBaseTypeSimName)
{
mstrDataBaseTypeSimName = value.ToString();
 AddUpdatedFld(conDataBaseType.DataBaseTypeSimName);
}
else if (strAttributeName  ==  conDataBaseType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDataBaseType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conDataBaseType.DataBaseTypeId  ==  AttributeName[intIndex])
{
return mstrDataBaseTypeId;
}
else if (conDataBaseType.DataBaseTypeName  ==  AttributeName[intIndex])
{
return mstrDataBaseTypeName;
}
else if (conDataBaseType.DataBaseTypeENName  ==  AttributeName[intIndex])
{
return mstrDataBaseTypeENName;
}
else if (conDataBaseType.DataBaseTypeSimName  ==  AttributeName[intIndex])
{
return mstrDataBaseTypeSimName;
}
else if (conDataBaseType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conDataBaseType.DataBaseTypeId  ==  AttributeName[intIndex])
{
mstrDataBaseTypeId = value.ToString();
 AddUpdatedFld(conDataBaseType.DataBaseTypeId);
}
else if (conDataBaseType.DataBaseTypeName  ==  AttributeName[intIndex])
{
mstrDataBaseTypeName = value.ToString();
 AddUpdatedFld(conDataBaseType.DataBaseTypeName);
}
else if (conDataBaseType.DataBaseTypeENName  ==  AttributeName[intIndex])
{
mstrDataBaseTypeENName = value.ToString();
 AddUpdatedFld(conDataBaseType.DataBaseTypeENName);
}
else if (conDataBaseType.DataBaseTypeSimName  ==  AttributeName[intIndex])
{
mstrDataBaseTypeSimName = value.ToString();
 AddUpdatedFld(conDataBaseType.DataBaseTypeSimName);
}
else if (conDataBaseType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDataBaseType.Memo);
}
}
}

/// <summary>
/// 数据库类型ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataBaseTypeId
{
get
{
return mstrDataBaseTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataBaseTypeId = value;
}
else
{
 mstrDataBaseTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conDataBaseType.DataBaseTypeId);
}
}
/// <summary>
/// 数据库类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataBaseTypeName
{
get
{
return mstrDataBaseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataBaseTypeName = value;
}
else
{
 mstrDataBaseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conDataBaseType.DataBaseTypeName);
}
}
/// <summary>
/// 数据库类型英文名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataBaseTypeENName
{
get
{
return mstrDataBaseTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataBaseTypeENName = value;
}
else
{
 mstrDataBaseTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conDataBaseType.DataBaseTypeENName);
}
}
/// <summary>
/// 数据库类型简名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataBaseTypeSimName
{
get
{
return mstrDataBaseTypeSimName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataBaseTypeSimName = value;
}
else
{
 mstrDataBaseTypeSimName = value;
}
//记录修改过的字段
 AddUpdatedFld(conDataBaseType.DataBaseTypeSimName);
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
 AddUpdatedFld(conDataBaseType.Memo);
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
  return mstrDataBaseTypeId;
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
  return mstrDataBaseTypeName;
 }
 }
}
 /// <summary>
 /// 数据库类型(DataBaseType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conDataBaseType
{
public new const string _CurrTabName = "DataBaseType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "DataBaseTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"DataBaseTypeId", "DataBaseTypeName", "DataBaseTypeENName", "DataBaseTypeSimName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"DataBaseTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataBaseTypeId = "DataBaseTypeId";    //数据库类型ID

 /// <summary>
 /// 常量:"DataBaseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataBaseTypeName = "DataBaseTypeName";    //数据库类型名

 /// <summary>
 /// 常量:"DataBaseTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataBaseTypeENName = "DataBaseTypeENName";    //数据库类型英文名

 /// <summary>
 /// 常量:"DataBaseTypeSimName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataBaseTypeSimName = "DataBaseTypeSimName";    //数据库类型简名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}