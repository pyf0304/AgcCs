
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsOperationTypeEN
 表名:OperationType(00050128)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:15:31
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:操作步骤管理(OpStepManage)
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
 /// 表OperationType的关键字(OpTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_OpTypeId_OperationType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strOpTypeId">表关键字</param>
public K_OpTypeId_OperationType(string strOpTypeId)
{
if (IsValid(strOpTypeId)) Value = strOpTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strOpTypeId)
{
if (string.IsNullOrEmpty(strOpTypeId) == true) return false;
if (strOpTypeId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_OpTypeId_OperationType]类型的对象</returns>
public static implicit operator K_OpTypeId_OperationType(string value)
{
return new K_OpTypeId_OperationType(value);
}
}
 /// <summary>
 /// 操作类型(OperationType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsOperationTypeEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接，如果为空就使用系统默认的连接
public new const string _CurrTabName = "OperationType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "OpTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string WhereFormat = ""; //条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"OpTypeId", "OpTypeName", "Memo"};

protected string mstrOpTypeId;    //操作类型Id
protected string mstrOpTypeName;    //操作类型名称
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsOperationTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "OperationType";
 lstKeyFldNames.Add("OpTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strOpTypeId">关键字:操作类型Id</param>
public clsOperationTypeEN(string strOpTypeId)
 {
strOpTypeId = strOpTypeId.Replace("'", "''");
if (strOpTypeId.Length > 4)
{
throw new Exception("在表:OperationType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strOpTypeId)  ==  true)
{
throw new Exception("在表:OperationType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strOpTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrOpTypeId = strOpTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "OperationType";
 lstKeyFldNames.Add("OpTypeId");
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
if (strAttributeName  ==  conOperationType.OpTypeId)
{
return mstrOpTypeId;
}
else if (strAttributeName  ==  conOperationType.OpTypeName)
{
return mstrOpTypeName;
}
else if (strAttributeName  ==  conOperationType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conOperationType.OpTypeId)
{
mstrOpTypeId = value.ToString();
 AddUpdatedFld(conOperationType.OpTypeId);
}
else if (strAttributeName  ==  conOperationType.OpTypeName)
{
mstrOpTypeName = value.ToString();
 AddUpdatedFld(conOperationType.OpTypeName);
}
else if (strAttributeName  ==  conOperationType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conOperationType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conOperationType.OpTypeId  ==  AttributeName[intIndex])
{
return mstrOpTypeId;
}
else if (conOperationType.OpTypeName  ==  AttributeName[intIndex])
{
return mstrOpTypeName;
}
else if (conOperationType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conOperationType.OpTypeId  ==  AttributeName[intIndex])
{
mstrOpTypeId = value.ToString();
 AddUpdatedFld(conOperationType.OpTypeId);
}
else if (conOperationType.OpTypeName  ==  AttributeName[intIndex])
{
mstrOpTypeName = value.ToString();
 AddUpdatedFld(conOperationType.OpTypeName);
}
else if (conOperationType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conOperationType.Memo);
}
}
}

/// <summary>
/// 操作类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OpTypeId
{
get
{
return mstrOpTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOpTypeId = value;
}
else
{
 mstrOpTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conOperationType.OpTypeId);
}
}
/// <summary>
/// 操作类型名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OpTypeName
{
get
{
return mstrOpTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOpTypeName = value;
}
else
{
 mstrOpTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conOperationType.OpTypeName);
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
 AddUpdatedFld(conOperationType.Memo);
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
  return mstrOpTypeId;
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
  return mstrOpTypeName;
 }
 }
}
 /// <summary>
 /// 操作类型(OperationType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conOperationType
{
public new const string _CurrTabName = "OperationType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "OpTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"OpTypeId", "OpTypeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"OpTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OpTypeId = "OpTypeId";    //操作类型Id

 /// <summary>
 /// 常量:"OpTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OpTypeName = "OpTypeName";    //操作类型名称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}