
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFuncOptStepsEN
 表名:FuncOptSteps(00050062)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:14:31
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
 /// 表FuncOptSteps的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_FuncOptSteps
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngmId">表关键字</param>
public K_mId_FuncOptSteps(long lngmId)
{
if (IsValid(lngmId)) Value = lngmId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngmId)
{
if (lngmId == 0) return false;
if (lngmId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_mId_FuncOptSteps]类型的对象</returns>
public static implicit operator K_mId_FuncOptSteps(long value)
{
return new K_mId_FuncOptSteps(value);
}
}
 /// <summary>
 /// 函数操作步骤(FuncOptSteps)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsFuncOptStepsEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接，如果为空就使用系统默认的连接
public new const string _CurrTabName = "FuncOptSteps"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string WhereFormat = ""; //条件格式串
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"mId", "FuncId", "StepIndex", "StepName", "StepCode", "StepDetail", "IsTemplate"};

protected long mlngmId;    //mId
protected string mstrFuncId;    //函数ID
protected int mintStepIndex;    //StepIndex
protected string mstrStepName;    //StepName
protected string mstrStepCode;    //StepCode
protected string mstrStepDetail;    //StepDetail
protected bool mbolIsTemplate;    //是否模板

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsFuncOptStepsEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "FuncOptSteps";
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:mId</param>
public clsFuncOptStepsEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "FuncOptSteps";
 lstKeyFldNames.Add("mId");
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
if (strAttributeName  ==  conFuncOptSteps.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conFuncOptSteps.FuncId)
{
return mstrFuncId;
}
else if (strAttributeName  ==  conFuncOptSteps.StepIndex)
{
return mintStepIndex;
}
else if (strAttributeName  ==  conFuncOptSteps.StepName)
{
return mstrStepName;
}
else if (strAttributeName  ==  conFuncOptSteps.StepCode)
{
return mstrStepCode;
}
else if (strAttributeName  ==  conFuncOptSteps.StepDetail)
{
return mstrStepDetail;
}
else if (strAttributeName  ==  conFuncOptSteps.IsTemplate)
{
return mbolIsTemplate;
}
return null;
}
set
{
if (strAttributeName  ==  conFuncOptSteps.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conFuncOptSteps.mId);
}
else if (strAttributeName  ==  conFuncOptSteps.FuncId)
{
mstrFuncId = value.ToString();
 AddUpdatedFld(conFuncOptSteps.FuncId);
}
else if (strAttributeName  ==  conFuncOptSteps.StepIndex)
{
mintStepIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(conFuncOptSteps.StepIndex);
}
else if (strAttributeName  ==  conFuncOptSteps.StepName)
{
mstrStepName = value.ToString();
 AddUpdatedFld(conFuncOptSteps.StepName);
}
else if (strAttributeName  ==  conFuncOptSteps.StepCode)
{
mstrStepCode = value.ToString();
 AddUpdatedFld(conFuncOptSteps.StepCode);
}
else if (strAttributeName  ==  conFuncOptSteps.StepDetail)
{
mstrStepDetail = value.ToString();
 AddUpdatedFld(conFuncOptSteps.StepDetail);
}
else if (strAttributeName  ==  conFuncOptSteps.IsTemplate)
{
mbolIsTemplate = TransNullToBool(value.ToString());
 AddUpdatedFld(conFuncOptSteps.IsTemplate);
}
}
}
public object this[int intIndex]
{
get
{
if (conFuncOptSteps.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conFuncOptSteps.FuncId  ==  AttributeName[intIndex])
{
return mstrFuncId;
}
else if (conFuncOptSteps.StepIndex  ==  AttributeName[intIndex])
{
return mintStepIndex;
}
else if (conFuncOptSteps.StepName  ==  AttributeName[intIndex])
{
return mstrStepName;
}
else if (conFuncOptSteps.StepCode  ==  AttributeName[intIndex])
{
return mstrStepCode;
}
else if (conFuncOptSteps.StepDetail  ==  AttributeName[intIndex])
{
return mstrStepDetail;
}
else if (conFuncOptSteps.IsTemplate  ==  AttributeName[intIndex])
{
return mbolIsTemplate;
}
return null;
}
set
{
if (conFuncOptSteps.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conFuncOptSteps.mId);
}
else if (conFuncOptSteps.FuncId  ==  AttributeName[intIndex])
{
mstrFuncId = value.ToString();
 AddUpdatedFld(conFuncOptSteps.FuncId);
}
else if (conFuncOptSteps.StepIndex  ==  AttributeName[intIndex])
{
mintStepIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(conFuncOptSteps.StepIndex);
}
else if (conFuncOptSteps.StepName  ==  AttributeName[intIndex])
{
mstrStepName = value.ToString();
 AddUpdatedFld(conFuncOptSteps.StepName);
}
else if (conFuncOptSteps.StepCode  ==  AttributeName[intIndex])
{
mstrStepCode = value.ToString();
 AddUpdatedFld(conFuncOptSteps.StepCode);
}
else if (conFuncOptSteps.StepDetail  ==  AttributeName[intIndex])
{
mstrStepDetail = value.ToString();
 AddUpdatedFld(conFuncOptSteps.StepDetail);
}
else if (conFuncOptSteps.IsTemplate  ==  AttributeName[intIndex])
{
mbolIsTemplate = TransNullToBool(value.ToString());
 AddUpdatedFld(conFuncOptSteps.IsTemplate);
}
}
}

/// <summary>
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long mId
{
get
{
return mlngmId;
}
set
{
 mlngmId = value;
//记录修改过的字段
 AddUpdatedFld(conFuncOptSteps.mId);
}
}
/// <summary>
/// 函数ID(说明:;字段类型:varchar;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncId
{
get
{
return mstrFuncId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncId = value;
}
else
{
 mstrFuncId = value;
}
//记录修改过的字段
 AddUpdatedFld(conFuncOptSteps.FuncId);
}
}
/// <summary>
/// StepIndex(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int StepIndex
{
get
{
return mintStepIndex;
}
set
{
 mintStepIndex = value;
//记录修改过的字段
 AddUpdatedFld(conFuncOptSteps.StepIndex);
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
 AddUpdatedFld(conFuncOptSteps.StepName);
}
}
/// <summary>
/// StepCode(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StepCode
{
get
{
return mstrStepCode;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStepCode = value;
}
else
{
 mstrStepCode = value;
}
//记录修改过的字段
 AddUpdatedFld(conFuncOptSteps.StepCode);
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
 AddUpdatedFld(conFuncOptSteps.StepDetail);
}
}
/// <summary>
/// 是否模板(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsTemplate
{
get
{
return mbolIsTemplate;
}
set
{
 mbolIsTemplate = value;
//记录修改过的字段
 AddUpdatedFld(conFuncOptSteps.IsTemplate);
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
  return mlngmId.ToString();
 }
 }
}
 /// <summary>
 /// 函数操作步骤(FuncOptSteps)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conFuncOptSteps
{
public new const string _CurrTabName = "FuncOptSteps"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "FuncId", "StepIndex", "StepName", "StepCode", "StepDetail", "IsTemplate"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"FuncId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncId = "FuncId";    //函数ID

 /// <summary>
 /// 常量:"StepIndex"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StepIndex = "StepIndex";    //StepIndex

 /// <summary>
 /// 常量:"StepName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StepName = "StepName";    //StepName

 /// <summary>
 /// 常量:"StepCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StepCode = "StepCode";    //StepCode

 /// <summary>
 /// 常量:"StepDetail"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StepDetail = "StepDetail";    //StepDetail

 /// <summary>
 /// 常量:"IsTemplate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsTemplate = "IsTemplate";    //是否模板
}

}