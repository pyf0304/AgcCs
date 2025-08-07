
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjOptStepsEN
 表名:PrjOptSteps(00050074)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:33:28
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:操作步骤管理(OpStepManage)
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
 /// 表PrjOptSteps的关键字(StepId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_StepId_PrjOptSteps
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strStepId">表关键字</param>
public K_StepId_PrjOptSteps(string strStepId)
{
if (IsValid(strStepId)) Value = strStepId;
else
{
Value = null;
}
}
private static bool IsValid(string strStepId)
{
if (string.IsNullOrEmpty(strStepId) == true) return false;
if (strStepId.Length > 8) return false;
if (strStepId.IndexOf(' ') >= 0) return false;
if (strStepId.IndexOf(')') >= 0) return false;
if (strStepId.IndexOf('(') >= 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_StepId_PrjOptSteps]类型的对象</returns>
public static implicit operator K_StepId_PrjOptSteps(string value)
{
return new K_StepId_PrjOptSteps(value);
}
}
 /// <summary>
 /// PrjOptSteps(PrjOptSteps)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsPrjOptStepsEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "PrjOptSteps"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "StepId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 5;
public static string[] _AttributeName = new string[] {"StepId", "PrjId", "StepName", "StepTypeId", "StepDetail"};

protected string mstrStepId;    //StepId
protected string mstrPrjId;    //工程Id
protected string mstrStepName;    //StepName
protected string mstrStepTypeId;    //StepTypeId
protected string mstrStepDetail;    //StepDetail

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsPrjOptStepsEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("StepId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strStepId">关键字:StepId</param>
public clsPrjOptStepsEN(string strStepId)
 {
strStepId = strStepId.Replace("'", "''");
if (strStepId.Length > 8)
{
throw new Exception("在表:PrjOptSteps中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strStepId)  ==  true)
{
throw new Exception("在表:PrjOptSteps中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strStepId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrStepId = strStepId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("StepId");
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
if (strAttributeName  ==  conPrjOptSteps.StepId)
{
return mstrStepId;
}
else if (strAttributeName  ==  conPrjOptSteps.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conPrjOptSteps.StepName)
{
return mstrStepName;
}
else if (strAttributeName  ==  conPrjOptSteps.StepTypeId)
{
return mstrStepTypeId;
}
else if (strAttributeName  ==  conPrjOptSteps.StepDetail)
{
return mstrStepDetail;
}
return null;
}
set
{
if (strAttributeName  ==  conPrjOptSteps.StepId)
{
mstrStepId = value.ToString();
 AddUpdatedFld(conPrjOptSteps.StepId);
}
else if (strAttributeName  ==  conPrjOptSteps.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conPrjOptSteps.PrjId);
}
else if (strAttributeName  ==  conPrjOptSteps.StepName)
{
mstrStepName = value.ToString();
 AddUpdatedFld(conPrjOptSteps.StepName);
}
else if (strAttributeName  ==  conPrjOptSteps.StepTypeId)
{
mstrStepTypeId = value.ToString();
 AddUpdatedFld(conPrjOptSteps.StepTypeId);
}
else if (strAttributeName  ==  conPrjOptSteps.StepDetail)
{
mstrStepDetail = value.ToString();
 AddUpdatedFld(conPrjOptSteps.StepDetail);
}
}
}
public object this[int intIndex]
{
get
{
if (conPrjOptSteps.StepId  ==  _AttributeName[intIndex])
{
return mstrStepId;
}
else if (conPrjOptSteps.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conPrjOptSteps.StepName  ==  _AttributeName[intIndex])
{
return mstrStepName;
}
else if (conPrjOptSteps.StepTypeId  ==  _AttributeName[intIndex])
{
return mstrStepTypeId;
}
else if (conPrjOptSteps.StepDetail  ==  _AttributeName[intIndex])
{
return mstrStepDetail;
}
return null;
}
set
{
if (conPrjOptSteps.StepId  ==  _AttributeName[intIndex])
{
mstrStepId = value.ToString();
 AddUpdatedFld(conPrjOptSteps.StepId);
}
else if (conPrjOptSteps.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conPrjOptSteps.PrjId);
}
else if (conPrjOptSteps.StepName  ==  _AttributeName[intIndex])
{
mstrStepName = value.ToString();
 AddUpdatedFld(conPrjOptSteps.StepName);
}
else if (conPrjOptSteps.StepTypeId  ==  _AttributeName[intIndex])
{
mstrStepTypeId = value.ToString();
 AddUpdatedFld(conPrjOptSteps.StepTypeId);
}
else if (conPrjOptSteps.StepDetail  ==  _AttributeName[intIndex])
{
mstrStepDetail = value.ToString();
 AddUpdatedFld(conPrjOptSteps.StepDetail);
}
}
}

/// <summary>
/// StepId(说明:;字段类型:varchar;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StepId
{
get
{
return mstrStepId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStepId = value;
}
else
{
 mstrStepId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjOptSteps.StepId);
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
 AddUpdatedFld(conPrjOptSteps.PrjId);
}
}
/// <summary>
/// StepName(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StepName
{
get
{
return mstrStepName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStepName = value;
}
else
{
 mstrStepName = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjOptSteps.StepName);
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
 AddUpdatedFld(conPrjOptSteps.StepTypeId);
}
}
/// <summary>
/// StepDetail(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StepDetail
{
get
{
return mstrStepDetail;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStepDetail = value;
}
else
{
 mstrStepDetail = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjOptSteps.StepDetail);
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
  return mstrStepId;
 }
 }
}
 /// <summary>
 /// PrjOptSteps(PrjOptSteps)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conPrjOptSteps
{
public const string _CurrTabName = "PrjOptSteps"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "StepId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"StepId", "PrjId", "StepName", "StepTypeId", "StepDetail"};
//以下是属性变量


 /// <summary>
 /// 常量:"StepId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StepId = "StepId";    //StepId

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"StepName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StepName = "StepName";    //StepName

 /// <summary>
 /// 常量:"StepTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StepTypeId = "StepTypeId";    //StepTypeId

 /// <summary>
 /// 常量:"StepDetail"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StepDetail = "StepDetail";    //StepDetail
}

}