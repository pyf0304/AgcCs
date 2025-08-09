
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCMFeatureEN
 表名:vCMFeature(00050519)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:11:29
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:代码管理(CodeMan)
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
 /// 表vCMFeature的关键字(CmFeatureId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CmFeatureId_vCMFeature
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strCmFeatureId">表关键字</param>
public K_CmFeatureId_vCMFeature(string strCmFeatureId)
{
if (IsValid(strCmFeatureId)) Value = strCmFeatureId;
else
{
Value = null;
}
}
private static bool IsValid(string strCmFeatureId)
{
if (string.IsNullOrEmpty(strCmFeatureId) == true) return false;
if (strCmFeatureId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_CmFeatureId_vCMFeature]类型的对象</returns>
public static implicit operator K_CmFeatureId_vCMFeature(string value)
{
return new K_CmFeatureId_vCMFeature(value);
}
}
 /// <summary>
 /// vCM功能(vCMFeature)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvCMFeatureEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vCMFeature"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "CmFeatureId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 27;
public static string[] _AttributeName = new string[] {"CmFeatureId", "FeatureName", "FeatureENName", "KeyWords", "FeatureDescription", "CmParentFeatureId", "ParentFeatureName", "CmFeatureTypeId", "FeatureTypeName", "CreateUserId", "InUse", "OrderNum", "FuncModuleAgcId", "FuncModuleName", "FuncModuleEnName", "FuncModuleNameSim", "CmPrjId", "CmPrjName", "PrjId", "PrjName", "ApplicationTypeId", "ApplicationTypeSimName", "UpdDate", "UpdUser", "Memo", "FeatureName2", "CmReqCount"};

protected string mstrCmFeatureId;    //功能Id
protected string mstrFeatureName;    //功能名称
protected string mstrFeatureENName;    //功能英文名
protected string mstrKeyWords;    //关键字
protected string mstrFeatureDescription;    //功能说明
protected string mstrCmParentFeatureId;    //父功能Id
protected string mstrParentFeatureName;    //父功能名
protected string mstrCmFeatureTypeId;    //功能类型Id
protected string mstrFeatureTypeName;    //功能类型名称
protected string mstrCreateUserId;    //建立用户Id
protected bool mbolInUse;    //是否在用
protected int mintOrderNum;    //序号
protected string mstrFuncModuleAgcId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrFuncModuleEnName;    //功能模块英文名称
protected string mstrFuncModuleNameSim;    //功能模块简称
protected string mstrCmPrjId;    //Cm工程Id
protected string mstrCmPrjName;    //CM工程名
protected string mstrPrjId;    //工程Id
protected string mstrPrjName;    //工程名称
protected int? mintApplicationTypeId;    //应用程序类型ID
protected string mstrApplicationTypeSimName;    //应用程序类型简称
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明
protected string mstrFeatureName2;    //功能名-FuncCount
protected int? mintCmReqCount;    //CMReqCount

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvCMFeatureEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CmFeatureId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strCmFeatureId">关键字:功能Id</param>
public clsvCMFeatureEN(string strCmFeatureId)
 {
strCmFeatureId = strCmFeatureId.Replace("'", "''");
if (strCmFeatureId.Length > 8)
{
throw new Exception("在表:vCMFeature中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strCmFeatureId)  ==  true)
{
throw new Exception("在表:vCMFeature中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCmFeatureId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrCmFeatureId = strCmFeatureId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CmFeatureId");
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
if (strAttributeName  ==  convCMFeature.CmFeatureId)
{
return mstrCmFeatureId;
}
else if (strAttributeName  ==  convCMFeature.FeatureName)
{
return mstrFeatureName;
}
else if (strAttributeName  ==  convCMFeature.FeatureENName)
{
return mstrFeatureENName;
}
else if (strAttributeName  ==  convCMFeature.KeyWords)
{
return mstrKeyWords;
}
else if (strAttributeName  ==  convCMFeature.FeatureDescription)
{
return mstrFeatureDescription;
}
else if (strAttributeName  ==  convCMFeature.CmParentFeatureId)
{
return mstrCmParentFeatureId;
}
else if (strAttributeName  ==  convCMFeature.ParentFeatureName)
{
return mstrParentFeatureName;
}
else if (strAttributeName  ==  convCMFeature.CmFeatureTypeId)
{
return mstrCmFeatureTypeId;
}
else if (strAttributeName  ==  convCMFeature.FeatureTypeName)
{
return mstrFeatureTypeName;
}
else if (strAttributeName  ==  convCMFeature.CreateUserId)
{
return mstrCreateUserId;
}
else if (strAttributeName  ==  convCMFeature.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  convCMFeature.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convCMFeature.FuncModuleAgcId)
{
return mstrFuncModuleAgcId;
}
else if (strAttributeName  ==  convCMFeature.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convCMFeature.FuncModuleEnName)
{
return mstrFuncModuleEnName;
}
else if (strAttributeName  ==  convCMFeature.FuncModuleNameSim)
{
return mstrFuncModuleNameSim;
}
else if (strAttributeName  ==  convCMFeature.CmPrjId)
{
return mstrCmPrjId;
}
else if (strAttributeName  ==  convCMFeature.CmPrjName)
{
return mstrCmPrjName;
}
else if (strAttributeName  ==  convCMFeature.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convCMFeature.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convCMFeature.ApplicationTypeId)
{
return mintApplicationTypeId;
}
else if (strAttributeName  ==  convCMFeature.ApplicationTypeSimName)
{
return mstrApplicationTypeSimName;
}
else if (strAttributeName  ==  convCMFeature.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convCMFeature.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convCMFeature.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convCMFeature.FeatureName2)
{
return mstrFeatureName2;
}
else if (strAttributeName  ==  convCMFeature.CmReqCount)
{
return mintCmReqCount;
}
return null;
}
set
{
if (strAttributeName  ==  convCMFeature.CmFeatureId)
{
mstrCmFeatureId = value.ToString();
 AddUpdatedFld(convCMFeature.CmFeatureId);
}
else if (strAttributeName  ==  convCMFeature.FeatureName)
{
mstrFeatureName = value.ToString();
 AddUpdatedFld(convCMFeature.FeatureName);
}
else if (strAttributeName  ==  convCMFeature.FeatureENName)
{
mstrFeatureENName = value.ToString();
 AddUpdatedFld(convCMFeature.FeatureENName);
}
else if (strAttributeName  ==  convCMFeature.KeyWords)
{
mstrKeyWords = value.ToString();
 AddUpdatedFld(convCMFeature.KeyWords);
}
else if (strAttributeName  ==  convCMFeature.FeatureDescription)
{
mstrFeatureDescription = value.ToString();
 AddUpdatedFld(convCMFeature.FeatureDescription);
}
else if (strAttributeName  ==  convCMFeature.CmParentFeatureId)
{
mstrCmParentFeatureId = value.ToString();
 AddUpdatedFld(convCMFeature.CmParentFeatureId);
}
else if (strAttributeName  ==  convCMFeature.ParentFeatureName)
{
mstrParentFeatureName = value.ToString();
 AddUpdatedFld(convCMFeature.ParentFeatureName);
}
else if (strAttributeName  ==  convCMFeature.CmFeatureTypeId)
{
mstrCmFeatureTypeId = value.ToString();
 AddUpdatedFld(convCMFeature.CmFeatureTypeId);
}
else if (strAttributeName  ==  convCMFeature.FeatureTypeName)
{
mstrFeatureTypeName = value.ToString();
 AddUpdatedFld(convCMFeature.FeatureTypeName);
}
else if (strAttributeName  ==  convCMFeature.CreateUserId)
{
mstrCreateUserId = value.ToString();
 AddUpdatedFld(convCMFeature.CreateUserId);
}
else if (strAttributeName  ==  convCMFeature.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convCMFeature.InUse);
}
else if (strAttributeName  ==  convCMFeature.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMFeature.OrderNum);
}
else if (strAttributeName  ==  convCMFeature.FuncModuleAgcId)
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convCMFeature.FuncModuleAgcId);
}
else if (strAttributeName  ==  convCMFeature.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convCMFeature.FuncModuleName);
}
else if (strAttributeName  ==  convCMFeature.FuncModuleEnName)
{
mstrFuncModuleEnName = value.ToString();
 AddUpdatedFld(convCMFeature.FuncModuleEnName);
}
else if (strAttributeName  ==  convCMFeature.FuncModuleNameSim)
{
mstrFuncModuleNameSim = value.ToString();
 AddUpdatedFld(convCMFeature.FuncModuleNameSim);
}
else if (strAttributeName  ==  convCMFeature.CmPrjId)
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(convCMFeature.CmPrjId);
}
else if (strAttributeName  ==  convCMFeature.CmPrjName)
{
mstrCmPrjName = value.ToString();
 AddUpdatedFld(convCMFeature.CmPrjName);
}
else if (strAttributeName  ==  convCMFeature.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convCMFeature.PrjId);
}
else if (strAttributeName  ==  convCMFeature.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convCMFeature.PrjName);
}
else if (strAttributeName  ==  convCMFeature.ApplicationTypeId)
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMFeature.ApplicationTypeId);
}
else if (strAttributeName  ==  convCMFeature.ApplicationTypeSimName)
{
mstrApplicationTypeSimName = value.ToString();
 AddUpdatedFld(convCMFeature.ApplicationTypeSimName);
}
else if (strAttributeName  ==  convCMFeature.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convCMFeature.UpdDate);
}
else if (strAttributeName  ==  convCMFeature.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convCMFeature.UpdUser);
}
else if (strAttributeName  ==  convCMFeature.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCMFeature.Memo);
}
else if (strAttributeName  ==  convCMFeature.FeatureName2)
{
mstrFeatureName2 = value.ToString();
 AddUpdatedFld(convCMFeature.FeatureName2);
}
else if (strAttributeName  ==  convCMFeature.CmReqCount)
{
mintCmReqCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMFeature.CmReqCount);
}
}
}
public object this[int intIndex]
{
get
{
if (convCMFeature.CmFeatureId  ==  _AttributeName[intIndex])
{
return mstrCmFeatureId;
}
else if (convCMFeature.FeatureName  ==  _AttributeName[intIndex])
{
return mstrFeatureName;
}
else if (convCMFeature.FeatureENName  ==  _AttributeName[intIndex])
{
return mstrFeatureENName;
}
else if (convCMFeature.KeyWords  ==  _AttributeName[intIndex])
{
return mstrKeyWords;
}
else if (convCMFeature.FeatureDescription  ==  _AttributeName[intIndex])
{
return mstrFeatureDescription;
}
else if (convCMFeature.CmParentFeatureId  ==  _AttributeName[intIndex])
{
return mstrCmParentFeatureId;
}
else if (convCMFeature.ParentFeatureName  ==  _AttributeName[intIndex])
{
return mstrParentFeatureName;
}
else if (convCMFeature.CmFeatureTypeId  ==  _AttributeName[intIndex])
{
return mstrCmFeatureTypeId;
}
else if (convCMFeature.FeatureTypeName  ==  _AttributeName[intIndex])
{
return mstrFeatureTypeName;
}
else if (convCMFeature.CreateUserId  ==  _AttributeName[intIndex])
{
return mstrCreateUserId;
}
else if (convCMFeature.InUse  ==  _AttributeName[intIndex])
{
return mbolInUse;
}
else if (convCMFeature.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convCMFeature.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
return mstrFuncModuleAgcId;
}
else if (convCMFeature.FuncModuleName  ==  _AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convCMFeature.FuncModuleEnName  ==  _AttributeName[intIndex])
{
return mstrFuncModuleEnName;
}
else if (convCMFeature.FuncModuleNameSim  ==  _AttributeName[intIndex])
{
return mstrFuncModuleNameSim;
}
else if (convCMFeature.CmPrjId  ==  _AttributeName[intIndex])
{
return mstrCmPrjId;
}
else if (convCMFeature.CmPrjName  ==  _AttributeName[intIndex])
{
return mstrCmPrjName;
}
else if (convCMFeature.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convCMFeature.PrjName  ==  _AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convCMFeature.ApplicationTypeId  ==  _AttributeName[intIndex])
{
return mintApplicationTypeId;
}
else if (convCMFeature.ApplicationTypeSimName  ==  _AttributeName[intIndex])
{
return mstrApplicationTypeSimName;
}
else if (convCMFeature.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convCMFeature.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convCMFeature.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (convCMFeature.FeatureName2  ==  _AttributeName[intIndex])
{
return mstrFeatureName2;
}
else if (convCMFeature.CmReqCount  ==  _AttributeName[intIndex])
{
return mintCmReqCount;
}
return null;
}
set
{
if (convCMFeature.CmFeatureId  ==  _AttributeName[intIndex])
{
mstrCmFeatureId = value.ToString();
 AddUpdatedFld(convCMFeature.CmFeatureId);
}
else if (convCMFeature.FeatureName  ==  _AttributeName[intIndex])
{
mstrFeatureName = value.ToString();
 AddUpdatedFld(convCMFeature.FeatureName);
}
else if (convCMFeature.FeatureENName  ==  _AttributeName[intIndex])
{
mstrFeatureENName = value.ToString();
 AddUpdatedFld(convCMFeature.FeatureENName);
}
else if (convCMFeature.KeyWords  ==  _AttributeName[intIndex])
{
mstrKeyWords = value.ToString();
 AddUpdatedFld(convCMFeature.KeyWords);
}
else if (convCMFeature.FeatureDescription  ==  _AttributeName[intIndex])
{
mstrFeatureDescription = value.ToString();
 AddUpdatedFld(convCMFeature.FeatureDescription);
}
else if (convCMFeature.CmParentFeatureId  ==  _AttributeName[intIndex])
{
mstrCmParentFeatureId = value.ToString();
 AddUpdatedFld(convCMFeature.CmParentFeatureId);
}
else if (convCMFeature.ParentFeatureName  ==  _AttributeName[intIndex])
{
mstrParentFeatureName = value.ToString();
 AddUpdatedFld(convCMFeature.ParentFeatureName);
}
else if (convCMFeature.CmFeatureTypeId  ==  _AttributeName[intIndex])
{
mstrCmFeatureTypeId = value.ToString();
 AddUpdatedFld(convCMFeature.CmFeatureTypeId);
}
else if (convCMFeature.FeatureTypeName  ==  _AttributeName[intIndex])
{
mstrFeatureTypeName = value.ToString();
 AddUpdatedFld(convCMFeature.FeatureTypeName);
}
else if (convCMFeature.CreateUserId  ==  _AttributeName[intIndex])
{
mstrCreateUserId = value.ToString();
 AddUpdatedFld(convCMFeature.CreateUserId);
}
else if (convCMFeature.InUse  ==  _AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convCMFeature.InUse);
}
else if (convCMFeature.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMFeature.OrderNum);
}
else if (convCMFeature.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convCMFeature.FuncModuleAgcId);
}
else if (convCMFeature.FuncModuleName  ==  _AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convCMFeature.FuncModuleName);
}
else if (convCMFeature.FuncModuleEnName  ==  _AttributeName[intIndex])
{
mstrFuncModuleEnName = value.ToString();
 AddUpdatedFld(convCMFeature.FuncModuleEnName);
}
else if (convCMFeature.FuncModuleNameSim  ==  _AttributeName[intIndex])
{
mstrFuncModuleNameSim = value.ToString();
 AddUpdatedFld(convCMFeature.FuncModuleNameSim);
}
else if (convCMFeature.CmPrjId  ==  _AttributeName[intIndex])
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(convCMFeature.CmPrjId);
}
else if (convCMFeature.CmPrjName  ==  _AttributeName[intIndex])
{
mstrCmPrjName = value.ToString();
 AddUpdatedFld(convCMFeature.CmPrjName);
}
else if (convCMFeature.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convCMFeature.PrjId);
}
else if (convCMFeature.PrjName  ==  _AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convCMFeature.PrjName);
}
else if (convCMFeature.ApplicationTypeId  ==  _AttributeName[intIndex])
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMFeature.ApplicationTypeId);
}
else if (convCMFeature.ApplicationTypeSimName  ==  _AttributeName[intIndex])
{
mstrApplicationTypeSimName = value.ToString();
 AddUpdatedFld(convCMFeature.ApplicationTypeSimName);
}
else if (convCMFeature.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convCMFeature.UpdDate);
}
else if (convCMFeature.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convCMFeature.UpdUser);
}
else if (convCMFeature.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCMFeature.Memo);
}
else if (convCMFeature.FeatureName2  ==  _AttributeName[intIndex])
{
mstrFeatureName2 = value.ToString();
 AddUpdatedFld(convCMFeature.FeatureName2);
}
else if (convCMFeature.CmReqCount  ==  _AttributeName[intIndex])
{
mintCmReqCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMFeature.CmReqCount);
}
}
}

/// <summary>
/// 功能Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CmFeatureId
{
get
{
return mstrCmFeatureId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCmFeatureId = value;
}
else
{
 mstrCmFeatureId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMFeature.CmFeatureId);
}
}
/// <summary>
/// 功能名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FeatureName
{
get
{
return mstrFeatureName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFeatureName = value;
}
else
{
 mstrFeatureName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMFeature.FeatureName);
}
}
/// <summary>
/// 功能英文名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FeatureENName
{
get
{
return mstrFeatureENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFeatureENName = value;
}
else
{
 mstrFeatureENName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMFeature.FeatureENName);
}
}
/// <summary>
/// 关键字(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KeyWords
{
get
{
return mstrKeyWords;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeyWords = value;
}
else
{
 mstrKeyWords = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMFeature.KeyWords);
}
}
/// <summary>
/// 功能说明(说明:;字段类型:varchar;字段长度:4000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FeatureDescription
{
get
{
return mstrFeatureDescription;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFeatureDescription = value;
}
else
{
 mstrFeatureDescription = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMFeature.FeatureDescription);
}
}
/// <summary>
/// 父功能Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CmParentFeatureId
{
get
{
return mstrCmParentFeatureId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCmParentFeatureId = value;
}
else
{
 mstrCmParentFeatureId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMFeature.CmParentFeatureId);
}
}
/// <summary>
/// 父功能名(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParentFeatureName
{
get
{
return mstrParentFeatureName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParentFeatureName = value;
}
else
{
 mstrParentFeatureName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMFeature.ParentFeatureName);
}
}
/// <summary>
/// 功能类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CmFeatureTypeId
{
get
{
return mstrCmFeatureTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCmFeatureTypeId = value;
}
else
{
 mstrCmFeatureTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMFeature.CmFeatureTypeId);
}
}
/// <summary>
/// 功能类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FeatureTypeName
{
get
{
return mstrFeatureTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFeatureTypeName = value;
}
else
{
 mstrFeatureTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMFeature.FeatureTypeName);
}
}
/// <summary>
/// 建立用户Id(说明:;字段类型:varchar;字段长度:18;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CreateUserId
{
get
{
return mstrCreateUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCreateUserId = value;
}
else
{
 mstrCreateUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMFeature.CreateUserId);
}
}
/// <summary>
/// 是否在用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool InUse
{
get
{
return mbolInUse;
}
set
{
 mbolInUse = value;
//记录修改过的字段
 AddUpdatedFld(convCMFeature.InUse);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(convCMFeature.OrderNum);
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
 AddUpdatedFld(convCMFeature.FuncModuleAgcId);
}
}
/// <summary>
/// 功能模块名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleName
{
get
{
return mstrFuncModuleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleName = value;
}
else
{
 mstrFuncModuleName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMFeature.FuncModuleName);
}
}
/// <summary>
/// 功能模块英文名称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleEnName
{
get
{
return mstrFuncModuleEnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleEnName = value;
}
else
{
 mstrFuncModuleEnName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMFeature.FuncModuleEnName);
}
}
/// <summary>
/// 功能模块简称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleNameSim
{
get
{
return mstrFuncModuleNameSim;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleNameSim = value;
}
else
{
 mstrFuncModuleNameSim = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMFeature.FuncModuleNameSim);
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
 AddUpdatedFld(convCMFeature.CmPrjId);
}
}
/// <summary>
/// CM工程名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CmPrjName
{
get
{
return mstrCmPrjName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCmPrjName = value;
}
else
{
 mstrCmPrjName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMFeature.CmPrjName);
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
 AddUpdatedFld(convCMFeature.PrjId);
}
}
/// <summary>
/// 工程名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjName
{
get
{
return mstrPrjName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjName = value;
}
else
{
 mstrPrjName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMFeature.PrjName);
}
}
/// <summary>
/// 应用程序类型ID(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? ApplicationTypeId
{
get
{
return mintApplicationTypeId;
}
set
{
 mintApplicationTypeId = value;
//记录修改过的字段
 AddUpdatedFld(convCMFeature.ApplicationTypeId);
}
}
/// <summary>
/// 应用程序类型简称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ApplicationTypeSimName
{
get
{
return mstrApplicationTypeSimName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrApplicationTypeSimName = value;
}
else
{
 mstrApplicationTypeSimName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMFeature.ApplicationTypeSimName);
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
 AddUpdatedFld(convCMFeature.UpdDate);
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
 AddUpdatedFld(convCMFeature.UpdUser);
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
 AddUpdatedFld(convCMFeature.Memo);
}
}
/// <summary>
/// 功能名-FuncCount(说明:;字段类型:varchar;字段长度:112;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FeatureName2
{
get
{
return mstrFeatureName2;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFeatureName2 = value;
}
else
{
 mstrFeatureName2 = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMFeature.FeatureName2);
}
}
/// <summary>
/// CMReqCount(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? CmReqCount
{
get
{
return mintCmReqCount;
}
set
{
 mintCmReqCount = value;
//记录修改过的字段
 AddUpdatedFld(convCMFeature.CmReqCount);
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
  return mstrCmFeatureId;
 }
 }
}
 /// <summary>
 /// vCM功能(vCMFeature)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convCMFeature
{
public const string _CurrTabName = "vCMFeature"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CmFeatureId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"CmFeatureId", "FeatureName", "FeatureENName", "KeyWords", "FeatureDescription", "CmParentFeatureId", "ParentFeatureName", "CmFeatureTypeId", "FeatureTypeName", "CreateUserId", "InUse", "OrderNum", "FuncModuleAgcId", "FuncModuleName", "FuncModuleEnName", "FuncModuleNameSim", "CmPrjId", "CmPrjName", "PrjId", "PrjName", "ApplicationTypeId", "ApplicationTypeSimName", "UpdDate", "UpdUser", "Memo", "FeatureName2", "CmReqCount"};
//以下是属性变量


 /// <summary>
 /// 常量:"CmFeatureId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CmFeatureId = "CmFeatureId";    //功能Id

 /// <summary>
 /// 常量:"FeatureName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeatureName = "FeatureName";    //功能名称

 /// <summary>
 /// 常量:"FeatureENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeatureENName = "FeatureENName";    //功能英文名

 /// <summary>
 /// 常量:"KeyWords"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KeyWords = "KeyWords";    //关键字

 /// <summary>
 /// 常量:"FeatureDescription"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeatureDescription = "FeatureDescription";    //功能说明

 /// <summary>
 /// 常量:"CmParentFeatureId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CmParentFeatureId = "CmParentFeatureId";    //父功能Id

 /// <summary>
 /// 常量:"ParentFeatureName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParentFeatureName = "ParentFeatureName";    //父功能名

 /// <summary>
 /// 常量:"CmFeatureTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CmFeatureTypeId = "CmFeatureTypeId";    //功能类型Id

 /// <summary>
 /// 常量:"FeatureTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeatureTypeName = "FeatureTypeName";    //功能类型名称

 /// <summary>
 /// 常量:"CreateUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreateUserId = "CreateUserId";    //建立用户Id

 /// <summary>
 /// 常量:"InUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InUse = "InUse";    //是否在用

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"FuncModuleAgcId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleAgcId = "FuncModuleAgcId";    //功能模块Id

 /// <summary>
 /// 常量:"FuncModuleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleName = "FuncModuleName";    //功能模块名称

 /// <summary>
 /// 常量:"FuncModuleEnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleEnName = "FuncModuleEnName";    //功能模块英文名称

 /// <summary>
 /// 常量:"FuncModuleNameSim"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleNameSim = "FuncModuleNameSim";    //功能模块简称

 /// <summary>
 /// 常量:"CmPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CmPrjId = "CmPrjId";    //Cm工程Id

 /// <summary>
 /// 常量:"CmPrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CmPrjName = "CmPrjName";    //CM工程名

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"PrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjName = "PrjName";    //工程名称

 /// <summary>
 /// 常量:"ApplicationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeId = "ApplicationTypeId";    //应用程序类型ID

 /// <summary>
 /// 常量:"ApplicationTypeSimName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeSimName = "ApplicationTypeSimName";    //应用程序类型简称

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

 /// <summary>
 /// 常量:"FeatureName2"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeatureName2 = "FeatureName2";    //功能名-FuncCount

 /// <summary>
 /// 常量:"CmReqCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CmReqCount = "CmReqCount";    //CMReqCount
}

}