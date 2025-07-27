
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFunctionRelaTypeEN
 表名:FunctionRelaType(00050320)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:15:05
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
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
 /// 表FunctionRelaType的关键字(FunctionRelaTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_FunctionRelaTypeId_FunctionRelaType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strFunctionRelaTypeId">表关键字</param>
public K_FunctionRelaTypeId_FunctionRelaType(string strFunctionRelaTypeId)
{
if (IsValid(strFunctionRelaTypeId)) Value = strFunctionRelaTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strFunctionRelaTypeId)
{
if (string.IsNullOrEmpty(strFunctionRelaTypeId) == true) return false;
if (strFunctionRelaTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_FunctionRelaTypeId_FunctionRelaType]类型的对象</returns>
public static implicit operator K_FunctionRelaTypeId_FunctionRelaType(string value)
{
return new K_FunctionRelaTypeId_FunctionRelaType(value);
}
}
 /// <summary>
 /// 函数关系类型(FunctionRelaType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsFunctionRelaTypeEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接，如果为空就使用系统默认的连接
public new const string _CurrTabName = "FunctionRelaType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FunctionRelaTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string WhereFormat = ""; //条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"FunctionRelaTypeId", "FunctionRelaTypeName", "UpdDate", "UpdUser", "Memo"};

protected string mstrFunctionRelaTypeId;    //函数关系类型Id
protected string mstrFunctionRelaTypeName;    //函数关系类型名称
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsFunctionRelaTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "FunctionRelaType";
 lstKeyFldNames.Add("FunctionRelaTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strFunctionRelaTypeId">关键字:函数关系类型Id</param>
public clsFunctionRelaTypeEN(string strFunctionRelaTypeId)
 {
strFunctionRelaTypeId = strFunctionRelaTypeId.Replace("'", "''");
if (strFunctionRelaTypeId.Length > 2)
{
throw new Exception("在表:FunctionRelaType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strFunctionRelaTypeId)  ==  true)
{
throw new Exception("在表:FunctionRelaType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFunctionRelaTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrFunctionRelaTypeId = strFunctionRelaTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "FunctionRelaType";
 lstKeyFldNames.Add("FunctionRelaTypeId");
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
if (strAttributeName  ==  conFunctionRelaType.FunctionRelaTypeId)
{
return mstrFunctionRelaTypeId;
}
else if (strAttributeName  ==  conFunctionRelaType.FunctionRelaTypeName)
{
return mstrFunctionRelaTypeName;
}
else if (strAttributeName  ==  conFunctionRelaType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conFunctionRelaType.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conFunctionRelaType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conFunctionRelaType.FunctionRelaTypeId)
{
mstrFunctionRelaTypeId = value.ToString();
 AddUpdatedFld(conFunctionRelaType.FunctionRelaTypeId);
}
else if (strAttributeName  ==  conFunctionRelaType.FunctionRelaTypeName)
{
mstrFunctionRelaTypeName = value.ToString();
 AddUpdatedFld(conFunctionRelaType.FunctionRelaTypeName);
}
else if (strAttributeName  ==  conFunctionRelaType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFunctionRelaType.UpdDate);
}
else if (strAttributeName  ==  conFunctionRelaType.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conFunctionRelaType.UpdUser);
}
else if (strAttributeName  ==  conFunctionRelaType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFunctionRelaType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conFunctionRelaType.FunctionRelaTypeId  ==  AttributeName[intIndex])
{
return mstrFunctionRelaTypeId;
}
else if (conFunctionRelaType.FunctionRelaTypeName  ==  AttributeName[intIndex])
{
return mstrFunctionRelaTypeName;
}
else if (conFunctionRelaType.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conFunctionRelaType.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conFunctionRelaType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conFunctionRelaType.FunctionRelaTypeId  ==  AttributeName[intIndex])
{
mstrFunctionRelaTypeId = value.ToString();
 AddUpdatedFld(conFunctionRelaType.FunctionRelaTypeId);
}
else if (conFunctionRelaType.FunctionRelaTypeName  ==  AttributeName[intIndex])
{
mstrFunctionRelaTypeName = value.ToString();
 AddUpdatedFld(conFunctionRelaType.FunctionRelaTypeName);
}
else if (conFunctionRelaType.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFunctionRelaType.UpdDate);
}
else if (conFunctionRelaType.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conFunctionRelaType.UpdUser);
}
else if (conFunctionRelaType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFunctionRelaType.Memo);
}
}
}

/// <summary>
/// 函数关系类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FunctionRelaTypeId
{
get
{
return mstrFunctionRelaTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFunctionRelaTypeId = value;
}
else
{
 mstrFunctionRelaTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunctionRelaType.FunctionRelaTypeId);
}
}
/// <summary>
/// 函数关系类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FunctionRelaTypeName
{
get
{
return mstrFunctionRelaTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFunctionRelaTypeName = value;
}
else
{
 mstrFunctionRelaTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunctionRelaType.FunctionRelaTypeName);
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
 AddUpdatedFld(conFunctionRelaType.UpdDate);
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
 AddUpdatedFld(conFunctionRelaType.UpdUser);
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
 AddUpdatedFld(conFunctionRelaType.Memo);
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
  return mstrFunctionRelaTypeId;
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
  return mstrFunctionRelaTypeName;
 }
 }
}
 /// <summary>
 /// 函数关系类型(FunctionRelaType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conFunctionRelaType
{
public new const string _CurrTabName = "FunctionRelaType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FunctionRelaTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"FunctionRelaTypeId", "FunctionRelaTypeName", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"FunctionRelaTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FunctionRelaTypeId = "FunctionRelaTypeId";    //函数关系类型Id

 /// <summary>
 /// 常量:"FunctionRelaTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FunctionRelaTypeName = "FunctionRelaTypeName";    //函数关系类型名称

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