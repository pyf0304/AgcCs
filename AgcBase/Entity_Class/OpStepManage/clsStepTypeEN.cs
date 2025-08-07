
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsStepTypeEN
 表名:StepType(00050084)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:16:09
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
 /// 表StepType的关键字(StepTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_StepTypeId_StepType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strStepTypeId">表关键字</param>
public K_StepTypeId_StepType(string strStepTypeId)
{
if (IsValid(strStepTypeId)) Value = strStepTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strStepTypeId)
{
if (string.IsNullOrEmpty(strStepTypeId) == true) return false;
if (strStepTypeId.Length > 2) return false;
if (strStepTypeId.IndexOf(' ') >= 0) return false;
if (strStepTypeId.IndexOf(')') >= 0) return false;
if (strStepTypeId.IndexOf('(') >= 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_StepTypeId_StepType]类型的对象</returns>
public static implicit operator K_StepTypeId_StepType(string value)
{
return new K_StepTypeId_StepType(value);
}
}
 /// <summary>
 /// StepType(StepType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsStepTypeEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接，如果为空就使用系统默认的连接
public new const string _CurrTabName = "StepType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "StepTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string WhereFormat = ""; //条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"StepTypeId", "StepType", "Memo"};

protected string mstrStepTypeId;    //StepTypeId
protected string mstrStepType;    //StepType
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsStepTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "StepType";
 lstKeyFldNames.Add("StepTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strStepTypeId">关键字:StepTypeId</param>
public clsStepTypeEN(string strStepTypeId)
 {
strStepTypeId = strStepTypeId.Replace("'", "''");
if (strStepTypeId.Length > 2)
{
throw new Exception("在表:StepType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strStepTypeId)  ==  true)
{
throw new Exception("在表:StepType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strStepTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrStepTypeId = strStepTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "StepType";
 lstKeyFldNames.Add("StepTypeId");
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
if (strAttributeName  ==  conStepType.StepTypeId)
{
return mstrStepTypeId;
}
else if (strAttributeName  ==  conStepType.StepType)
{
return mstrStepType;
}
else if (strAttributeName  ==  conStepType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conStepType.StepTypeId)
{
mstrStepTypeId = value.ToString();
 AddUpdatedFld(conStepType.StepTypeId);
}
else if (strAttributeName  ==  conStepType.StepType)
{
mstrStepType = value.ToString();
 AddUpdatedFld(conStepType.StepType);
}
else if (strAttributeName  ==  conStepType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conStepType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conStepType.StepTypeId  ==  AttributeName[intIndex])
{
return mstrStepTypeId;
}
else if (conStepType.StepType  ==  AttributeName[intIndex])
{
return mstrStepType;
}
else if (conStepType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conStepType.StepTypeId  ==  AttributeName[intIndex])
{
mstrStepTypeId = value.ToString();
 AddUpdatedFld(conStepType.StepTypeId);
}
else if (conStepType.StepType  ==  AttributeName[intIndex])
{
mstrStepType = value.ToString();
 AddUpdatedFld(conStepType.StepType);
}
else if (conStepType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conStepType.Memo);
}
}
}

/// <summary>
/// StepTypeId(说明:;字段类型:varchar;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StepTypeId
{
get
{
return mstrStepTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStepTypeId = value;
}
else
{
 mstrStepTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conStepType.StepTypeId);
}
}
/// <summary>
/// StepType(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StepType
{
get
{
return mstrStepType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStepType = value;
}
else
{
 mstrStepType = value;
}
//记录修改过的字段
 AddUpdatedFld(conStepType.StepType);
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
 AddUpdatedFld(conStepType.Memo);
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
  return mstrStepTypeId;
 }
 }
}
 /// <summary>
 /// StepType(StepType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conStepType
{
public new const string _CurrTabName = "StepType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "StepTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"StepTypeId", "StepType", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"StepTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StepTypeId = "StepTypeId";    //StepTypeId

 /// <summary>
 /// 常量:"StepType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StepType = "StepType";    //StepType

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}