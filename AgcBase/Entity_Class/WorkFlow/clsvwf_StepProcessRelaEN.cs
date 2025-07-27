
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvwf_StepProcessRelaEN
 表名:vwf_StepProcessRela(00050494)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:18:31
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
 /// 表vwf_StepProcessRela的关键字(WorkFlowStepProcessRelaId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_WorkFlowStepProcessRelaId_vwf_StepProcessRela
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngWorkFlowStepProcessRelaId">表关键字</param>
public K_WorkFlowStepProcessRelaId_vwf_StepProcessRela(long lngWorkFlowStepProcessRelaId)
{
if (IsValid(lngWorkFlowStepProcessRelaId)) Value = lngWorkFlowStepProcessRelaId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngWorkFlowStepProcessRelaId)
{
if (lngWorkFlowStepProcessRelaId == 0) return false;
if (lngWorkFlowStepProcessRelaId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_WorkFlowStepProcessRelaId_vwf_StepProcessRela]类型的对象</returns>
public static implicit operator K_WorkFlowStepProcessRelaId_vwf_StepProcessRela(long value)
{
return new K_WorkFlowStepProcessRelaId_vwf_StepProcessRela(value);
}
}
 /// <summary>
 /// v工作流步骤过程关系(vwf_StepProcessRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvwf_StepProcessRelaEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接，如果为空就使用系统默认的连接
public new const string _CurrTabName = "vwf_StepProcessRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "WorkFlowStepProcessRelaId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string WhereFormat = ""; //条件格式串
protected const int mintAttributeCount = 19;
public static string[] AttributeName = new string[] {"WorkFlowStepProcessRelaId", "WorkFlowId", "WorkFlowName", "WorkFlowNameSim", "PrjId", "PrjName", "ProcessId", "ProcessName", "EndPoint", "StartPoint", "StartPointName", "EndPointName", "OrderNum", "RoleId", "PageName", "DepartmentId", "UpdDate", "UpdUser", "Memo"};

protected long mlngWorkFlowStepProcessRelaId;    //工作流与过程关系Id
protected string mstrWorkFlowId;    //工作流Id
protected string mstrWorkFlowName;    //工作流名称
protected string mstrWorkFlowNameSim;    //工作流简称
protected string mstrPrjId;    //工程ID
protected string mstrPrjName;    //工程名称
protected string mstrProcessId;    //过程ID
protected string mstrProcessName;    //过程名称
protected string mstrEndPoint;    //终点
protected string mstrStartPoint;    //起点
protected string mstrStartPointName;    //起点名
protected string mstrEndPointName;    //终点名
protected int? mintOrderNum;    //序号
protected string mstrRoleId;    //角色ID
protected string mstrPageName;    //页面名称
protected string mstrDepartmentId;    //部门ID
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvwf_StepProcessRelaEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "vwf_StepProcessRela";
 lstKeyFldNames.Add("WorkFlowStepProcessRelaId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngWorkFlowStepProcessRelaId">关键字:工作流与过程关系Id</param>
public clsvwf_StepProcessRelaEN(long lngWorkFlowStepProcessRelaId)
 {
 if (lngWorkFlowStepProcessRelaId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngWorkFlowStepProcessRelaId = lngWorkFlowStepProcessRelaId;
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "vwf_StepProcessRela";
 lstKeyFldNames.Add("WorkFlowStepProcessRelaId");
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
if (strAttributeName  ==  convwf_StepProcessRela.WorkFlowStepProcessRelaId)
{
return mlngWorkFlowStepProcessRelaId;
}
else if (strAttributeName  ==  convwf_StepProcessRela.WorkFlowId)
{
return mstrWorkFlowId;
}
else if (strAttributeName  ==  convwf_StepProcessRela.WorkFlowName)
{
return mstrWorkFlowName;
}
else if (strAttributeName  ==  convwf_StepProcessRela.WorkFlowNameSim)
{
return mstrWorkFlowNameSim;
}
else if (strAttributeName  ==  convwf_StepProcessRela.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convwf_StepProcessRela.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convwf_StepProcessRela.ProcessId)
{
return mstrProcessId;
}
else if (strAttributeName  ==  convwf_StepProcessRela.ProcessName)
{
return mstrProcessName;
}
else if (strAttributeName  ==  convwf_StepProcessRela.EndPoint)
{
return mstrEndPoint;
}
else if (strAttributeName  ==  convwf_StepProcessRela.StartPoint)
{
return mstrStartPoint;
}
else if (strAttributeName  ==  convwf_StepProcessRela.StartPointName)
{
return mstrStartPointName;
}
else if (strAttributeName  ==  convwf_StepProcessRela.EndPointName)
{
return mstrEndPointName;
}
else if (strAttributeName  ==  convwf_StepProcessRela.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convwf_StepProcessRela.RoleId)
{
return mstrRoleId;
}
else if (strAttributeName  ==  convwf_StepProcessRela.PageName)
{
return mstrPageName;
}
else if (strAttributeName  ==  convwf_StepProcessRela.DepartmentId)
{
return mstrDepartmentId;
}
else if (strAttributeName  ==  convwf_StepProcessRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convwf_StepProcessRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convwf_StepProcessRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convwf_StepProcessRela.WorkFlowStepProcessRelaId)
{
mlngWorkFlowStepProcessRelaId = TransNullToInt(value.ToString());
 AddUpdatedFld(convwf_StepProcessRela.WorkFlowStepProcessRelaId);
}
else if (strAttributeName  ==  convwf_StepProcessRela.WorkFlowId)
{
mstrWorkFlowId = value.ToString();
 AddUpdatedFld(convwf_StepProcessRela.WorkFlowId);
}
else if (strAttributeName  ==  convwf_StepProcessRela.WorkFlowName)
{
mstrWorkFlowName = value.ToString();
 AddUpdatedFld(convwf_StepProcessRela.WorkFlowName);
}
else if (strAttributeName  ==  convwf_StepProcessRela.WorkFlowNameSim)
{
mstrWorkFlowNameSim = value.ToString();
 AddUpdatedFld(convwf_StepProcessRela.WorkFlowNameSim);
}
else if (strAttributeName  ==  convwf_StepProcessRela.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convwf_StepProcessRela.PrjId);
}
else if (strAttributeName  ==  convwf_StepProcessRela.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convwf_StepProcessRela.PrjName);
}
else if (strAttributeName  ==  convwf_StepProcessRela.ProcessId)
{
mstrProcessId = value.ToString();
 AddUpdatedFld(convwf_StepProcessRela.ProcessId);
}
else if (strAttributeName  ==  convwf_StepProcessRela.ProcessName)
{
mstrProcessName = value.ToString();
 AddUpdatedFld(convwf_StepProcessRela.ProcessName);
}
else if (strAttributeName  ==  convwf_StepProcessRela.EndPoint)
{
mstrEndPoint = value.ToString();
 AddUpdatedFld(convwf_StepProcessRela.EndPoint);
}
else if (strAttributeName  ==  convwf_StepProcessRela.StartPoint)
{
mstrStartPoint = value.ToString();
 AddUpdatedFld(convwf_StepProcessRela.StartPoint);
}
else if (strAttributeName  ==  convwf_StepProcessRela.StartPointName)
{
mstrStartPointName = value.ToString();
 AddUpdatedFld(convwf_StepProcessRela.StartPointName);
}
else if (strAttributeName  ==  convwf_StepProcessRela.EndPointName)
{
mstrEndPointName = value.ToString();
 AddUpdatedFld(convwf_StepProcessRela.EndPointName);
}
else if (strAttributeName  ==  convwf_StepProcessRela.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convwf_StepProcessRela.OrderNum);
}
else if (strAttributeName  ==  convwf_StepProcessRela.RoleId)
{
mstrRoleId = value.ToString();
 AddUpdatedFld(convwf_StepProcessRela.RoleId);
}
else if (strAttributeName  ==  convwf_StepProcessRela.PageName)
{
mstrPageName = value.ToString();
 AddUpdatedFld(convwf_StepProcessRela.PageName);
}
else if (strAttributeName  ==  convwf_StepProcessRela.DepartmentId)
{
mstrDepartmentId = value.ToString();
 AddUpdatedFld(convwf_StepProcessRela.DepartmentId);
}
else if (strAttributeName  ==  convwf_StepProcessRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convwf_StepProcessRela.UpdDate);
}
else if (strAttributeName  ==  convwf_StepProcessRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convwf_StepProcessRela.UpdUser);
}
else if (strAttributeName  ==  convwf_StepProcessRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convwf_StepProcessRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convwf_StepProcessRela.WorkFlowStepProcessRelaId  ==  AttributeName[intIndex])
{
return mlngWorkFlowStepProcessRelaId;
}
else if (convwf_StepProcessRela.WorkFlowId  ==  AttributeName[intIndex])
{
return mstrWorkFlowId;
}
else if (convwf_StepProcessRela.WorkFlowName  ==  AttributeName[intIndex])
{
return mstrWorkFlowName;
}
else if (convwf_StepProcessRela.WorkFlowNameSim  ==  AttributeName[intIndex])
{
return mstrWorkFlowNameSim;
}
else if (convwf_StepProcessRela.PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convwf_StepProcessRela.PrjName  ==  AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convwf_StepProcessRela.ProcessId  ==  AttributeName[intIndex])
{
return mstrProcessId;
}
else if (convwf_StepProcessRela.ProcessName  ==  AttributeName[intIndex])
{
return mstrProcessName;
}
else if (convwf_StepProcessRela.EndPoint  ==  AttributeName[intIndex])
{
return mstrEndPoint;
}
else if (convwf_StepProcessRela.StartPoint  ==  AttributeName[intIndex])
{
return mstrStartPoint;
}
else if (convwf_StepProcessRela.StartPointName  ==  AttributeName[intIndex])
{
return mstrStartPointName;
}
else if (convwf_StepProcessRela.EndPointName  ==  AttributeName[intIndex])
{
return mstrEndPointName;
}
else if (convwf_StepProcessRela.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convwf_StepProcessRela.RoleId  ==  AttributeName[intIndex])
{
return mstrRoleId;
}
else if (convwf_StepProcessRela.PageName  ==  AttributeName[intIndex])
{
return mstrPageName;
}
else if (convwf_StepProcessRela.DepartmentId  ==  AttributeName[intIndex])
{
return mstrDepartmentId;
}
else if (convwf_StepProcessRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convwf_StepProcessRela.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convwf_StepProcessRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convwf_StepProcessRela.WorkFlowStepProcessRelaId  ==  AttributeName[intIndex])
{
mlngWorkFlowStepProcessRelaId = TransNullToInt(value.ToString());
 AddUpdatedFld(convwf_StepProcessRela.WorkFlowStepProcessRelaId);
}
else if (convwf_StepProcessRela.WorkFlowId  ==  AttributeName[intIndex])
{
mstrWorkFlowId = value.ToString();
 AddUpdatedFld(convwf_StepProcessRela.WorkFlowId);
}
else if (convwf_StepProcessRela.WorkFlowName  ==  AttributeName[intIndex])
{
mstrWorkFlowName = value.ToString();
 AddUpdatedFld(convwf_StepProcessRela.WorkFlowName);
}
else if (convwf_StepProcessRela.WorkFlowNameSim  ==  AttributeName[intIndex])
{
mstrWorkFlowNameSim = value.ToString();
 AddUpdatedFld(convwf_StepProcessRela.WorkFlowNameSim);
}
else if (convwf_StepProcessRela.PrjId  ==  AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convwf_StepProcessRela.PrjId);
}
else if (convwf_StepProcessRela.PrjName  ==  AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convwf_StepProcessRela.PrjName);
}
else if (convwf_StepProcessRela.ProcessId  ==  AttributeName[intIndex])
{
mstrProcessId = value.ToString();
 AddUpdatedFld(convwf_StepProcessRela.ProcessId);
}
else if (convwf_StepProcessRela.ProcessName  ==  AttributeName[intIndex])
{
mstrProcessName = value.ToString();
 AddUpdatedFld(convwf_StepProcessRela.ProcessName);
}
else if (convwf_StepProcessRela.EndPoint  ==  AttributeName[intIndex])
{
mstrEndPoint = value.ToString();
 AddUpdatedFld(convwf_StepProcessRela.EndPoint);
}
else if (convwf_StepProcessRela.StartPoint  ==  AttributeName[intIndex])
{
mstrStartPoint = value.ToString();
 AddUpdatedFld(convwf_StepProcessRela.StartPoint);
}
else if (convwf_StepProcessRela.StartPointName  ==  AttributeName[intIndex])
{
mstrStartPointName = value.ToString();
 AddUpdatedFld(convwf_StepProcessRela.StartPointName);
}
else if (convwf_StepProcessRela.EndPointName  ==  AttributeName[intIndex])
{
mstrEndPointName = value.ToString();
 AddUpdatedFld(convwf_StepProcessRela.EndPointName);
}
else if (convwf_StepProcessRela.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convwf_StepProcessRela.OrderNum);
}
else if (convwf_StepProcessRela.RoleId  ==  AttributeName[intIndex])
{
mstrRoleId = value.ToString();
 AddUpdatedFld(convwf_StepProcessRela.RoleId);
}
else if (convwf_StepProcessRela.PageName  ==  AttributeName[intIndex])
{
mstrPageName = value.ToString();
 AddUpdatedFld(convwf_StepProcessRela.PageName);
}
else if (convwf_StepProcessRela.DepartmentId  ==  AttributeName[intIndex])
{
mstrDepartmentId = value.ToString();
 AddUpdatedFld(convwf_StepProcessRela.DepartmentId);
}
else if (convwf_StepProcessRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convwf_StepProcessRela.UpdDate);
}
else if (convwf_StepProcessRela.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convwf_StepProcessRela.UpdUser);
}
else if (convwf_StepProcessRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convwf_StepProcessRela.Memo);
}
}
}

/// <summary>
/// 工作流与过程关系Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long WorkFlowStepProcessRelaId
{
get
{
return mlngWorkFlowStepProcessRelaId;
}
set
{
 mlngWorkFlowStepProcessRelaId = value;
//记录修改过的字段
 AddUpdatedFld(convwf_StepProcessRela.WorkFlowStepProcessRelaId);
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
 AddUpdatedFld(convwf_StepProcessRela.WorkFlowId);
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
 AddUpdatedFld(convwf_StepProcessRela.WorkFlowName);
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
 AddUpdatedFld(convwf_StepProcessRela.WorkFlowNameSim);
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
 AddUpdatedFld(convwf_StepProcessRela.PrjId);
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
 AddUpdatedFld(convwf_StepProcessRela.PrjName);
}
}
/// <summary>
/// 过程ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProcessId
{
get
{
return mstrProcessId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProcessId = value;
}
else
{
 mstrProcessId = value;
}
//记录修改过的字段
 AddUpdatedFld(convwf_StepProcessRela.ProcessId);
}
}
/// <summary>
/// 过程名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProcessName
{
get
{
return mstrProcessName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProcessName = value;
}
else
{
 mstrProcessName = value;
}
//记录修改过的字段
 AddUpdatedFld(convwf_StepProcessRela.ProcessName);
}
}
/// <summary>
/// 终点(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EndPoint
{
get
{
return mstrEndPoint;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEndPoint = value;
}
else
{
 mstrEndPoint = value;
}
//记录修改过的字段
 AddUpdatedFld(convwf_StepProcessRela.EndPoint);
}
}
/// <summary>
/// 起点(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StartPoint
{
get
{
return mstrStartPoint;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStartPoint = value;
}
else
{
 mstrStartPoint = value;
}
//记录修改过的字段
 AddUpdatedFld(convwf_StepProcessRela.StartPoint);
}
}
/// <summary>
/// 起点名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StartPointName
{
get
{
return mstrStartPointName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStartPointName = value;
}
else
{
 mstrStartPointName = value;
}
//记录修改过的字段
 AddUpdatedFld(convwf_StepProcessRela.StartPointName);
}
}
/// <summary>
/// 终点名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EndPointName
{
get
{
return mstrEndPointName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEndPointName = value;
}
else
{
 mstrEndPointName = value;
}
//记录修改过的字段
 AddUpdatedFld(convwf_StepProcessRela.EndPointName);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(convwf_StepProcessRela.OrderNum);
}
}
/// <summary>
/// 角色ID(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RoleId
{
get
{
return mstrRoleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRoleId = value;
}
else
{
 mstrRoleId = value;
}
//记录修改过的字段
 AddUpdatedFld(convwf_StepProcessRela.RoleId);
}
}
/// <summary>
/// 页面名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PageName
{
get
{
return mstrPageName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPageName = value;
}
else
{
 mstrPageName = value;
}
//记录修改过的字段
 AddUpdatedFld(convwf_StepProcessRela.PageName);
}
}
/// <summary>
/// 部门ID(说明:;字段类型:varchar;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DepartmentId
{
get
{
return mstrDepartmentId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDepartmentId = value;
}
else
{
 mstrDepartmentId = value;
}
//记录修改过的字段
 AddUpdatedFld(convwf_StepProcessRela.DepartmentId);
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
 AddUpdatedFld(convwf_StepProcessRela.UpdDate);
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
 AddUpdatedFld(convwf_StepProcessRela.UpdUser);
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
 AddUpdatedFld(convwf_StepProcessRela.Memo);
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
  return mlngWorkFlowStepProcessRelaId.ToString();
 }
 }
}
 /// <summary>
 /// v工作流步骤过程关系(vwf_StepProcessRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convwf_StepProcessRela
{
public new const string _CurrTabName = "vwf_StepProcessRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "WorkFlowStepProcessRelaId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"WorkFlowStepProcessRelaId", "WorkFlowId", "WorkFlowName", "WorkFlowNameSim", "PrjId", "PrjName", "ProcessId", "ProcessName", "EndPoint", "StartPoint", "StartPointName", "EndPointName", "OrderNum", "RoleId", "PageName", "DepartmentId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"WorkFlowStepProcessRelaId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WorkFlowStepProcessRelaId = "WorkFlowStepProcessRelaId";    //工作流与过程关系Id

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
 /// 常量:"ProcessId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProcessId = "ProcessId";    //过程ID

 /// <summary>
 /// 常量:"ProcessName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProcessName = "ProcessName";    //过程名称

 /// <summary>
 /// 常量:"EndPoint"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EndPoint = "EndPoint";    //终点

 /// <summary>
 /// 常量:"StartPoint"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StartPoint = "StartPoint";    //起点

 /// <summary>
 /// 常量:"StartPointName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StartPointName = "StartPointName";    //起点名

 /// <summary>
 /// 常量:"EndPointName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EndPointName = "EndPointName";    //终点名

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"RoleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RoleId = "RoleId";    //角色ID

 /// <summary>
 /// 常量:"PageName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PageName = "PageName";    //页面名称

 /// <summary>
 /// 常量:"DepartmentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DepartmentId = "DepartmentId";    //部门ID

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