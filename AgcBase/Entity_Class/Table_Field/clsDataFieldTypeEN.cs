
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDataFieldTypeEN
 表名:DataFieldType(00050596)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:13:47
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
 /// 表DataFieldType的关键字(DataFieldTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_DataFieldTypeId_DataFieldType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strDataFieldTypeId">表关键字</param>
public K_DataFieldTypeId_DataFieldType(string strDataFieldTypeId)
{
if (IsValid(strDataFieldTypeId)) Value = strDataFieldTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strDataFieldTypeId)
{
if (string.IsNullOrEmpty(strDataFieldTypeId) == true) return false;
if (strDataFieldTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_DataFieldTypeId_DataFieldType]类型的对象</returns>
public static implicit operator K_DataFieldTypeId_DataFieldType(string value)
{
return new K_DataFieldTypeId_DataFieldType(value);
}
}
 /// <summary>
 /// 数据字段类型(DataFieldType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsDataFieldTypeEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接，如果为空就使用系统默认的连接
public new const string _CurrTabName = "DataFieldType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "DataFieldTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string WhereFormat = ""; //条件格式串
protected const int mintAttributeCount = 6;
public static string[] AttributeName = new string[] {"DataFieldTypeId", "DataFieldTypeName", "DataFieldTypeENName", "UpdDate", "UpdUser", "Memo"};

protected string mstrDataFieldTypeId;    //数据字段类型Id
protected string mstrDataFieldTypeName;    //数据字段类型名
protected string mstrDataFieldTypeENName;    //数据字段类型英文名
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsDataFieldTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "DataFieldType";
 lstKeyFldNames.Add("DataFieldTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strDataFieldTypeId">关键字:数据字段类型Id</param>
public clsDataFieldTypeEN(string strDataFieldTypeId)
 {
strDataFieldTypeId = strDataFieldTypeId.Replace("'", "''");
if (strDataFieldTypeId.Length > 2)
{
throw new Exception("在表:DataFieldType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strDataFieldTypeId)  ==  true)
{
throw new Exception("在表:DataFieldType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strDataFieldTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrDataFieldTypeId = strDataFieldTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "DataFieldType";
 lstKeyFldNames.Add("DataFieldTypeId");
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
if (strAttributeName  ==  conDataFieldType.DataFieldTypeId)
{
return mstrDataFieldTypeId;
}
else if (strAttributeName  ==  conDataFieldType.DataFieldTypeName)
{
return mstrDataFieldTypeName;
}
else if (strAttributeName  ==  conDataFieldType.DataFieldTypeENName)
{
return mstrDataFieldTypeENName;
}
else if (strAttributeName  ==  conDataFieldType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conDataFieldType.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conDataFieldType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conDataFieldType.DataFieldTypeId)
{
mstrDataFieldTypeId = value.ToString();
 AddUpdatedFld(conDataFieldType.DataFieldTypeId);
}
else if (strAttributeName  ==  conDataFieldType.DataFieldTypeName)
{
mstrDataFieldTypeName = value.ToString();
 AddUpdatedFld(conDataFieldType.DataFieldTypeName);
}
else if (strAttributeName  ==  conDataFieldType.DataFieldTypeENName)
{
mstrDataFieldTypeENName = value.ToString();
 AddUpdatedFld(conDataFieldType.DataFieldTypeENName);
}
else if (strAttributeName  ==  conDataFieldType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conDataFieldType.UpdDate);
}
else if (strAttributeName  ==  conDataFieldType.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conDataFieldType.UpdUser);
}
else if (strAttributeName  ==  conDataFieldType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDataFieldType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conDataFieldType.DataFieldTypeId  ==  AttributeName[intIndex])
{
return mstrDataFieldTypeId;
}
else if (conDataFieldType.DataFieldTypeName  ==  AttributeName[intIndex])
{
return mstrDataFieldTypeName;
}
else if (conDataFieldType.DataFieldTypeENName  ==  AttributeName[intIndex])
{
return mstrDataFieldTypeENName;
}
else if (conDataFieldType.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conDataFieldType.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conDataFieldType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conDataFieldType.DataFieldTypeId  ==  AttributeName[intIndex])
{
mstrDataFieldTypeId = value.ToString();
 AddUpdatedFld(conDataFieldType.DataFieldTypeId);
}
else if (conDataFieldType.DataFieldTypeName  ==  AttributeName[intIndex])
{
mstrDataFieldTypeName = value.ToString();
 AddUpdatedFld(conDataFieldType.DataFieldTypeName);
}
else if (conDataFieldType.DataFieldTypeENName  ==  AttributeName[intIndex])
{
mstrDataFieldTypeENName = value.ToString();
 AddUpdatedFld(conDataFieldType.DataFieldTypeENName);
}
else if (conDataFieldType.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conDataFieldType.UpdDate);
}
else if (conDataFieldType.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conDataFieldType.UpdUser);
}
else if (conDataFieldType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDataFieldType.Memo);
}
}
}

/// <summary>
/// 数据字段类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataFieldTypeId
{
get
{
return mstrDataFieldTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataFieldTypeId = value;
}
else
{
 mstrDataFieldTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conDataFieldType.DataFieldTypeId);
}
}
/// <summary>
/// 数据字段类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataFieldTypeName
{
get
{
return mstrDataFieldTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataFieldTypeName = value;
}
else
{
 mstrDataFieldTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conDataFieldType.DataFieldTypeName);
}
}
/// <summary>
/// 数据字段类型英文名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataFieldTypeENName
{
get
{
return mstrDataFieldTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataFieldTypeENName = value;
}
else
{
 mstrDataFieldTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conDataFieldType.DataFieldTypeENName);
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
 AddUpdatedFld(conDataFieldType.UpdDate);
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
 AddUpdatedFld(conDataFieldType.UpdUser);
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
 AddUpdatedFld(conDataFieldType.Memo);
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
  return mstrDataFieldTypeId;
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
  return mstrDataFieldTypeName;
 }
 }
}
 /// <summary>
 /// 数据字段类型(DataFieldType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conDataFieldType
{
public new const string _CurrTabName = "DataFieldType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "DataFieldTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"DataFieldTypeId", "DataFieldTypeName", "DataFieldTypeENName", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"DataFieldTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataFieldTypeId = "DataFieldTypeId";    //数据字段类型Id

 /// <summary>
 /// 常量:"DataFieldTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataFieldTypeName = "DataFieldTypeName";    //数据字段类型名

 /// <summary>
 /// 常量:"DataFieldTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataFieldTypeENName = "DataFieldTypeENName";    //数据字段类型英文名

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