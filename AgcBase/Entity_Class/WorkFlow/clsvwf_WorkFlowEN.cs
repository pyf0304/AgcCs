
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvwf_WorkFlowEN
 表名:vwf_WorkFlow(00050490)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:18:35
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:工作流管理(WorkFlow)
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
 /// 表vwf_WorkFlow的关键字(WorkFlowId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_WorkFlowId_vwf_WorkFlow
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strWorkFlowId">表关键字</param>
public K_WorkFlowId_vwf_WorkFlow(string strWorkFlowId)
{
if (IsValid(strWorkFlowId)) Value = strWorkFlowId;
else
{
Value = null;
}
}
private static bool IsValid(string strWorkFlowId)
{
if (string.IsNullOrEmpty(strWorkFlowId) == true) return false;
if (strWorkFlowId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_WorkFlowId_vwf_WorkFlow]类型的对象</returns>
public static implicit operator K_WorkFlowId_vwf_WorkFlow(string value)
{
return new K_WorkFlowId_vwf_WorkFlow(value);
}
}
 /// <summary>
 /// v工作流(vwf_WorkFlow)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvwf_WorkFlowEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接，如果为空就使用系统默认的连接
public new const string _CurrTabName = "vwf_WorkFlow"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "WorkFlowId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string WhereFormat = ""; //条件格式串
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"WorkFlowId", "WorkFlowName", "WorkFlowNameSim", "PrjId", "PrjName", "UpdDate", "UpdUser", "Memo", "IsCurrentUse"};

protected string mstrWorkFlowId;    //工作流Id
protected string mstrWorkFlowName;    //工作流名称
protected string mstrWorkFlowNameSim;    //工作流简称
protected string mstrPrjId;    //工程ID
protected string mstrPrjName;    //工程名称
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明
protected bool mbolIsCurrentUse;    //是否当前使用

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvwf_WorkFlowEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "vwf_WorkFlow";
 lstKeyFldNames.Add("WorkFlowId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strWorkFlowId">关键字:工作流Id</param>
public clsvwf_WorkFlowEN(string strWorkFlowId)
 {
strWorkFlowId = strWorkFlowId.Replace("'", "''");
if (strWorkFlowId.Length > 4)
{
throw new Exception("在表:vwf_WorkFlow中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strWorkFlowId)  ==  true)
{
throw new Exception("在表:vwf_WorkFlow中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strWorkFlowId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrWorkFlowId = strWorkFlowId;
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "vwf_WorkFlow";
 lstKeyFldNames.Add("WorkFlowId");
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
if (strAttributeName  ==  convwf_WorkFlow.WorkFlowId)
{
return mstrWorkFlowId;
}
else if (strAttributeName  ==  convwf_WorkFlow.WorkFlowName)
{
return mstrWorkFlowName;
}
else if (strAttributeName  ==  convwf_WorkFlow.WorkFlowNameSim)
{
return mstrWorkFlowNameSim;
}
else if (strAttributeName  ==  convwf_WorkFlow.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convwf_WorkFlow.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convwf_WorkFlow.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convwf_WorkFlow.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convwf_WorkFlow.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convwf_WorkFlow.IsCurrentUse)
{
return mbolIsCurrentUse;
}
return null;
}
set
{
if (strAttributeName  ==  convwf_WorkFlow.WorkFlowId)
{
mstrWorkFlowId = value.ToString();
 AddUpdatedFld(convwf_WorkFlow.WorkFlowId);
}
else if (strAttributeName  ==  convwf_WorkFlow.WorkFlowName)
{
mstrWorkFlowName = value.ToString();
 AddUpdatedFld(convwf_WorkFlow.WorkFlowName);
}
else if (strAttributeName  ==  convwf_WorkFlow.WorkFlowNameSim)
{
mstrWorkFlowNameSim = value.ToString();
 AddUpdatedFld(convwf_WorkFlow.WorkFlowNameSim);
}
else if (strAttributeName  ==  convwf_WorkFlow.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convwf_WorkFlow.PrjId);
}
else if (strAttributeName  ==  convwf_WorkFlow.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convwf_WorkFlow.PrjName);
}
else if (strAttributeName  ==  convwf_WorkFlow.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convwf_WorkFlow.UpdDate);
}
else if (strAttributeName  ==  convwf_WorkFlow.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convwf_WorkFlow.UpdUser);
}
else if (strAttributeName  ==  convwf_WorkFlow.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convwf_WorkFlow.Memo);
}
else if (strAttributeName  ==  convwf_WorkFlow.IsCurrentUse)
{
mbolIsCurrentUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convwf_WorkFlow.IsCurrentUse);
}
}
}
public object this[int intIndex]
{
get
{
if (convwf_WorkFlow.WorkFlowId  ==  AttributeName[intIndex])
{
return mstrWorkFlowId;
}
else if (convwf_WorkFlow.WorkFlowName  ==  AttributeName[intIndex])
{
return mstrWorkFlowName;
}
else if (convwf_WorkFlow.WorkFlowNameSim  ==  AttributeName[intIndex])
{
return mstrWorkFlowNameSim;
}
else if (convwf_WorkFlow.PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convwf_WorkFlow.PrjName  ==  AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convwf_WorkFlow.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convwf_WorkFlow.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convwf_WorkFlow.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convwf_WorkFlow.IsCurrentUse  ==  AttributeName[intIndex])
{
return mbolIsCurrentUse;
}
return null;
}
set
{
if (convwf_WorkFlow.WorkFlowId  ==  AttributeName[intIndex])
{
mstrWorkFlowId = value.ToString();
 AddUpdatedFld(convwf_WorkFlow.WorkFlowId);
}
else if (convwf_WorkFlow.WorkFlowName  ==  AttributeName[intIndex])
{
mstrWorkFlowName = value.ToString();
 AddUpdatedFld(convwf_WorkFlow.WorkFlowName);
}
else if (convwf_WorkFlow.WorkFlowNameSim  ==  AttributeName[intIndex])
{
mstrWorkFlowNameSim = value.ToString();
 AddUpdatedFld(convwf_WorkFlow.WorkFlowNameSim);
}
else if (convwf_WorkFlow.PrjId  ==  AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convwf_WorkFlow.PrjId);
}
else if (convwf_WorkFlow.PrjName  ==  AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convwf_WorkFlow.PrjName);
}
else if (convwf_WorkFlow.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convwf_WorkFlow.UpdDate);
}
else if (convwf_WorkFlow.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convwf_WorkFlow.UpdUser);
}
else if (convwf_WorkFlow.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convwf_WorkFlow.Memo);
}
else if (convwf_WorkFlow.IsCurrentUse  ==  AttributeName[intIndex])
{
mbolIsCurrentUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convwf_WorkFlow.IsCurrentUse);
}
}
}

/// <summary>
/// 工作流Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WorkFlowId
{
get
{
return mstrWorkFlowId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWorkFlowId = value;
}
else
{
 mstrWorkFlowId = value;
}
//记录修改过的字段
 AddUpdatedFld(convwf_WorkFlow.WorkFlowId);
}
}
/// <summary>
/// 工作流名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WorkFlowName
{
get
{
return mstrWorkFlowName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWorkFlowName = value;
}
else
{
 mstrWorkFlowName = value;
}
//记录修改过的字段
 AddUpdatedFld(convwf_WorkFlow.WorkFlowName);
}
}
/// <summary>
/// 工作流简称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WorkFlowNameSim
{
get
{
return mstrWorkFlowNameSim;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWorkFlowNameSim = value;
}
else
{
 mstrWorkFlowNameSim = value;
}
//记录修改过的字段
 AddUpdatedFld(convwf_WorkFlow.WorkFlowNameSim);
}
}
/// <summary>
/// 工程ID(说明:;字段类型:char;字段长度:4;是否可空:False)
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
 AddUpdatedFld(convwf_WorkFlow.PrjId);
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
 AddUpdatedFld(convwf_WorkFlow.PrjName);
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
 AddUpdatedFld(convwf_WorkFlow.UpdDate);
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
 AddUpdatedFld(convwf_WorkFlow.UpdUser);
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
 AddUpdatedFld(convwf_WorkFlow.Memo);
}
}
/// <summary>
/// 是否当前使用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsCurrentUse
{
get
{
return mbolIsCurrentUse;
}
set
{
 mbolIsCurrentUse = value;
//记录修改过的字段
 AddUpdatedFld(convwf_WorkFlow.IsCurrentUse);
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
  return mstrWorkFlowId;
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
  return mstrWorkFlowName;
 }
 }
}
 /// <summary>
 /// v工作流(vwf_WorkFlow)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convwf_WorkFlow
{
public new const string _CurrTabName = "vwf_WorkFlow"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "WorkFlowId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"WorkFlowId", "WorkFlowName", "WorkFlowNameSim", "PrjId", "PrjName", "UpdDate", "UpdUser", "Memo", "IsCurrentUse"};
//以下是属性变量


 /// <summary>
 /// 常量:"WorkFlowId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WorkFlowId = "WorkFlowId";    //工作流Id

 /// <summary>
 /// 常量:"WorkFlowName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WorkFlowName = "WorkFlowName";    //工作流名称

 /// <summary>
 /// 常量:"WorkFlowNameSim"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WorkFlowNameSim = "WorkFlowNameSim";    //工作流简称

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程ID

 /// <summary>
 /// 常量:"PrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjName = "PrjName";    //工程名称

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
 /// 常量:"IsCurrentUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsCurrentUse = "IsCurrentUse";    //是否当前使用
}

}