
///----------------------
///生成代码版本：2012.01.02.1
///生成日期：2012/08/27
///生成者：pyf
///工程名称：AGC
///工程ID：0005
///模块中文名：任务管理
///模块英文名：TaskManage
///注意：1、需要数据底层（PubDataBase.dll）的版本：2011.05.08.1
///       2、需要公共函数层（TzPubFunction.dll）的版本：2011.05.08.1
///========================
using System;
using System.Text; 
using System.Collections; 
using com.taishsoft.comm_db_obj;

namespace AGC.Entity
{
/// <summary>
/// 项目任务(PrjTask)
/// </summary>
[Serializable]
public class clsPrjTaskEN : clsEntityBase2
{
public const string CurrTabName_S = "PrjTask"; //当前表名，与该类相关的表名
public const string CurrTabKeyFldName_S = "PrjTaskId"; //当前表中的关键字名称，与该类相关的表中关键字名
protected const int mintAttributeCount = 29;
public static string[] AttributeName = new string[] {"PrjTaskId", "TaskName", "TaskContent", "PrjId", "ViewId", "TaskStateId", "TaskTypeId", "PlanBeginDate", "PlanEndDate", "PlanNeedHours", "IsAssigned", "TaskAssignDate", "PermiterId", "TaskPermitDate", "IsFinished", "Executor", "DepartMentId", "ActualBeginDate", "ActualEndDate", "ActualCostHours", "SubmitDate", "TaskExcuteSum", "IsChecked", "CheckerId", "TaskCheckDate", "CheckDesc", "InspectTimes", "FinishedPercent", "CumulatePoints"};
 //以下是属性变量


 /// <summary> 
 /// 工程任务ID(字段类型:varchar,字段长度:8,是否可空:False)
 /// </summary>
 protected string mstrPrjTaskId;

 /// <summary> 
 /// 任务名称(字段类型:varchar,字段长度:30,是否可空:False)
 /// </summary>
 protected string mstrTaskName;

 /// <summary> 
 /// 内容(字段类型:varchar,字段长度:1000,是否可空:True)
 /// </summary>
 protected string mstrTaskContent;

 /// <summary> 
 /// 工程ID(字段类型:char,字段长度:4,是否可空:False)
 /// </summary>
 protected string mstrPrjId;

 /// <summary> 
 /// 界面ID(字段类型:varchar,字段长度:8,是否可空:True)
 /// </summary>
 protected string mstrViewId;

 /// <summary> 
 /// 任务状态ID(字段类型:char,字段长度:2,是否可空:True)
 /// </summary>
 protected string mstrTaskStateId;

 /// <summary> 
 /// 任务类别ID(字段类型:varchar,字段长度:4,是否可空:True)
 /// </summary>
 protected string mstrTaskTypeId;

 /// <summary> 
 /// 计划开始日期(字段类型:char,字段长度:8,是否可空:True)
 /// </summary>
 protected string mstrPlanBeginDate;

 /// <summary> 
 /// 计划结束日期(字段类型:char,字段长度:8,是否可空:True)
 /// </summary>
 protected string mstrPlanEndDate;

 /// <summary> 
 /// 计划需要时间(字段类型:int,字段长度:4,是否可空:True)
 /// </summary>
 protected int mintPlanNeedHours;

 /// <summary> 
 /// 是否指派(字段类型:bit,字段长度:1,是否可空:True)
 /// </summary>
 protected bool mbolIsAssigned;

 /// <summary> 
 /// 任务指派日期(字段类型:varchar,字段长度:8,是否可空:True)
 /// </summary>
 protected string mstrTaskAssignDate;

 /// <summary> 
 /// 确认人ID(字段类型:varchar,字段长度:18,是否可空:True)
 /// </summary>
 protected string mstrPermiterId;

 /// <summary> 
 /// 任务确认日期(字段类型:varchar,字段长度:8,是否可空:True)
 /// </summary>
 protected string mstrTaskPermitDate;

 /// <summary> 
 /// 是否完成(字段类型:bit,字段长度:1,是否可空:True)
 /// </summary>
 protected bool mbolIsFinished;

 /// <summary> 
 /// 实施者(字段类型:varchar,字段长度:18,是否可空:True)
 /// </summary>
 protected string mstrExecutor;

 /// <summary> 
 /// 部门ID(字段类型:varchar,字段长度:8,是否可空:True)
 /// </summary>
 protected string mstrDepartMentId;

 /// <summary> 
 /// 实际开始日期(字段类型:char,字段长度:8,是否可空:True)
 /// </summary>
 protected string mstrActualBeginDate;

 /// <summary> 
 /// 实际结束日期(字段类型:char,字段长度:8,是否可空:True)
 /// </summary>
 protected string mstrActualEndDate;

 /// <summary> 
 /// 实际花费时间(字段类型:int,字段长度:4,是否可空:True)
 /// </summary>
 protected int mintActualCostHours;

 /// <summary> 
 /// 提交日期(字段类型:char,字段长度:8,是否可空:True)
 /// </summary>
 protected string mstrSubmitDate;

 /// <summary> 
 /// 任务实施总结(字段类型:varchar,字段长度:1000,是否可空:True)
 /// </summary>
 protected string mstrTaskExcuteSum;

 /// <summary> 
 /// 是否核实(字段类型:bit,字段长度:1,是否可空:True)
 /// </summary>
 protected bool mbolIsChecked;

 /// <summary> 
 /// 核实人ID(字段类型:varchar,字段长度:18,是否可空:True)
 /// </summary>
 protected string mstrCheckerId;

 /// <summary> 
 /// 任务核实日期(字段类型:varchar,字段长度:8,是否可空:True)
 /// </summary>
 protected string mstrTaskCheckDate;

 /// <summary> 
 /// 核实情况(字段类型:varchar,字段长度:1000,是否可空:True)
 /// </summary>
 protected string mstrCheckDesc;

 /// <summary> 
 /// 检查次数(字段类型:int,字段长度:4,是否可空:True)
 /// </summary>
 protected int mintInspectTimes;

 /// <summary> 
 /// 当前完成百分比(字段类型:float,字段长度:8,是否可空:True)
 /// </summary>
 protected float mfltFinishedPercent;

 /// <summary> 
 /// 积点(字段类型:int,字段长度:4,是否可空:True)
 /// </summary>
 protected int mintCumulatePoints;

//用户指定的连接串,如果用户不指定该连接串,就用PUBDATABASE中所指定的连接串
private static string m_strConnectString;
public static string ConnectString
{
get { return m_strConnectString; }
set { m_strConnectString = value; }
}

 public clsPrjTaskEN()
 {
 SetInit();
 _CurrTabName = "PrjTask";
 lstKeyFldNames.Add("PrjTaskId");
 }

public clsPrjTaskEN(string strPrjTaskId)
 {

mstrPrjTaskId=strPrjTaskId;
 SetInit();
 _CurrTabName = "PrjTask";
 lstKeyFldNames.Add("PrjTaskId");
 }

public static int AttributeCount
{
get
{
return mintAttributeCount;
}
}
public object this[string strAttributeName]
{
get
{
if (strAttributeName == "PrjTaskId")
{
return mstrPrjTaskId;
}
else if (strAttributeName == "TaskName")
{
return mstrTaskName;
}
else if (strAttributeName == "TaskContent")
{
return mstrTaskContent;
}
else if (strAttributeName == "PrjId")
{
return mstrPrjId;
}
else if (strAttributeName == "ViewId")
{
return mstrViewId;
}
else if (strAttributeName == "TaskStateId")
{
return mstrTaskStateId;
}
else if (strAttributeName == "TaskTypeId")
{
return mstrTaskTypeId;
}
else if (strAttributeName == "PlanBeginDate")
{
return mstrPlanBeginDate;
}
else if (strAttributeName == "PlanEndDate")
{
return mstrPlanEndDate;
}
else if (strAttributeName == "PlanNeedHours")
{
return mintPlanNeedHours;
}
else if (strAttributeName == "IsAssigned")
{
return mbolIsAssigned;
}
else if (strAttributeName == "TaskAssignDate")
{
return mstrTaskAssignDate;
}
else if (strAttributeName == "PermiterId")
{
return mstrPermiterId;
}
else if (strAttributeName == "TaskPermitDate")
{
return mstrTaskPermitDate;
}
else if (strAttributeName == "IsFinished")
{
return mbolIsFinished;
}
else if (strAttributeName == "Executor")
{
return mstrExecutor;
}
else if (strAttributeName == "DepartMentId")
{
return mstrDepartMentId;
}
else if (strAttributeName == "ActualBeginDate")
{
return mstrActualBeginDate;
}
else if (strAttributeName == "ActualEndDate")
{
return mstrActualEndDate;
}
else if (strAttributeName == "ActualCostHours")
{
return mintActualCostHours;
}
else if (strAttributeName == "SubmitDate")
{
return mstrSubmitDate;
}
else if (strAttributeName == "TaskExcuteSum")
{
return mstrTaskExcuteSum;
}
else if (strAttributeName == "IsChecked")
{
return mbolIsChecked;
}
else if (strAttributeName == "CheckerId")
{
return mstrCheckerId;
}
else if (strAttributeName == "TaskCheckDate")
{
return mstrTaskCheckDate;
}
else if (strAttributeName == "CheckDesc")
{
return mstrCheckDesc;
}
else if (strAttributeName == "InspectTimes")
{
return mintInspectTimes;
}
else if (strAttributeName == "FinishedPercent")
{
return mfltFinishedPercent;
}
else if (strAttributeName == "CumulatePoints")
{
return mintCumulatePoints;
}
return null;
}
set
{
if (strAttributeName == "PrjTaskId")
{
mstrPrjTaskId = value.ToString();
}
else if (strAttributeName == "TaskName")
{
mstrTaskName = value.ToString();
}
else if (strAttributeName == "TaskContent")
{
mstrTaskContent = value.ToString();
}
else if (strAttributeName == "PrjId")
{
mstrPrjId = value.ToString();
}
else if (strAttributeName == "ViewId")
{
mstrViewId = value.ToString();
}
else if (strAttributeName == "TaskStateId")
{
mstrTaskStateId = value.ToString();
}
else if (strAttributeName == "TaskTypeId")
{
mstrTaskTypeId = value.ToString();
}
else if (strAttributeName == "PlanBeginDate")
{
mstrPlanBeginDate = value.ToString();
}
else if (strAttributeName == "PlanEndDate")
{
mstrPlanEndDate = value.ToString();
}
else if (strAttributeName == "PlanNeedHours")
{
mintPlanNeedHours = TransNullToInt(value.ToString());
}
else if (strAttributeName == "IsAssigned")
{
mbolIsAssigned = TransNullToBool(value.ToString());
}
else if (strAttributeName == "TaskAssignDate")
{
mstrTaskAssignDate = value.ToString();
}
else if (strAttributeName == "PermiterId")
{
mstrPermiterId = value.ToString();
}
else if (strAttributeName == "TaskPermitDate")
{
mstrTaskPermitDate = value.ToString();
}
else if (strAttributeName == "IsFinished")
{
mbolIsFinished = TransNullToBool(value.ToString());
}
else if (strAttributeName == "Executor")
{
mstrExecutor = value.ToString();
}
else if (strAttributeName == "DepartMentId")
{
mstrDepartMentId = value.ToString();
}
else if (strAttributeName == "ActualBeginDate")
{
mstrActualBeginDate = value.ToString();
}
else if (strAttributeName == "ActualEndDate")
{
mstrActualEndDate = value.ToString();
}
else if (strAttributeName == "ActualCostHours")
{
mintActualCostHours = TransNullToInt(value.ToString());
}
else if (strAttributeName == "SubmitDate")
{
mstrSubmitDate = value.ToString();
}
else if (strAttributeName == "TaskExcuteSum")
{
mstrTaskExcuteSum = value.ToString();
}
else if (strAttributeName == "IsChecked")
{
mbolIsChecked = TransNullToBool(value.ToString());
}
else if (strAttributeName == "CheckerId")
{
mstrCheckerId = value.ToString();
}
else if (strAttributeName == "TaskCheckDate")
{
mstrTaskCheckDate = value.ToString();
}
else if (strAttributeName == "CheckDesc")
{
mstrCheckDesc = value.ToString();
}
else if (strAttributeName == "InspectTimes")
{
mintInspectTimes = TransNullToInt(value.ToString());
}
else if (strAttributeName == "FinishedPercent")
{
mfltFinishedPercent = TransNullToFloat(value.ToString());
}
else if (strAttributeName == "CumulatePoints")
{
mintCumulatePoints = TransNullToInt(value.ToString());
}
}
}
public object this[int intIndex]
{
get
{
if ("PrjTaskId" == AttributeName[intIndex])
{
return mstrPrjTaskId;
}
else if ("TaskName" == AttributeName[intIndex])
{
return mstrTaskName;
}
else if ("TaskContent" == AttributeName[intIndex])
{
return mstrTaskContent;
}
else if ("PrjId" == AttributeName[intIndex])
{
return mstrPrjId;
}
else if ("ViewId" == AttributeName[intIndex])
{
return mstrViewId;
}
else if ("TaskStateId" == AttributeName[intIndex])
{
return mstrTaskStateId;
}
else if ("TaskTypeId" == AttributeName[intIndex])
{
return mstrTaskTypeId;
}
else if ("PlanBeginDate" == AttributeName[intIndex])
{
return mstrPlanBeginDate;
}
else if ("PlanEndDate" == AttributeName[intIndex])
{
return mstrPlanEndDate;
}
else if ("PlanNeedHours" == AttributeName[intIndex])
{
return mintPlanNeedHours;
}
else if ("IsAssigned" == AttributeName[intIndex])
{
return mbolIsAssigned;
}
else if ("TaskAssignDate" == AttributeName[intIndex])
{
return mstrTaskAssignDate;
}
else if ("PermiterId" == AttributeName[intIndex])
{
return mstrPermiterId;
}
else if ("TaskPermitDate" == AttributeName[intIndex])
{
return mstrTaskPermitDate;
}
else if ("IsFinished" == AttributeName[intIndex])
{
return mbolIsFinished;
}
else if ("Executor" == AttributeName[intIndex])
{
return mstrExecutor;
}
else if ("DepartMentId" == AttributeName[intIndex])
{
return mstrDepartMentId;
}
else if ("ActualBeginDate" == AttributeName[intIndex])
{
return mstrActualBeginDate;
}
else if ("ActualEndDate" == AttributeName[intIndex])
{
return mstrActualEndDate;
}
else if ("ActualCostHours" == AttributeName[intIndex])
{
return mintActualCostHours;
}
else if ("SubmitDate" == AttributeName[intIndex])
{
return mstrSubmitDate;
}
else if ("TaskExcuteSum" == AttributeName[intIndex])
{
return mstrTaskExcuteSum;
}
else if ("IsChecked" == AttributeName[intIndex])
{
return mbolIsChecked;
}
else if ("CheckerId" == AttributeName[intIndex])
{
return mstrCheckerId;
}
else if ("TaskCheckDate" == AttributeName[intIndex])
{
return mstrTaskCheckDate;
}
else if ("CheckDesc" == AttributeName[intIndex])
{
return mstrCheckDesc;
}
else if ("InspectTimes" == AttributeName[intIndex])
{
return mintInspectTimes;
}
else if ("FinishedPercent" == AttributeName[intIndex])
{
return mfltFinishedPercent;
}
else if ("CumulatePoints" == AttributeName[intIndex])
{
return mintCumulatePoints;
}
return null;
}
set
{
if ("PrjTaskId" == AttributeName[intIndex])
{
mstrPrjTaskId = value.ToString();
}
else if ("TaskName" == AttributeName[intIndex])
{
mstrTaskName = value.ToString();
}
else if ("TaskContent" == AttributeName[intIndex])
{
mstrTaskContent = value.ToString();
}
else if ("PrjId" == AttributeName[intIndex])
{
mstrPrjId = value.ToString();
}
else if ("ViewId" == AttributeName[intIndex])
{
mstrViewId = value.ToString();
}
else if ("TaskStateId" == AttributeName[intIndex])
{
mstrTaskStateId = value.ToString();
}
else if ("TaskTypeId" == AttributeName[intIndex])
{
mstrTaskTypeId = value.ToString();
}
else if ("PlanBeginDate" == AttributeName[intIndex])
{
mstrPlanBeginDate = value.ToString();
}
else if ("PlanEndDate" == AttributeName[intIndex])
{
mstrPlanEndDate = value.ToString();
}
else if ("PlanNeedHours" == AttributeName[intIndex])
{
mintPlanNeedHours = TransNullToInt(value.ToString());
}
else if ("IsAssigned" == AttributeName[intIndex])
{
mbolIsAssigned = TransNullToBool(value.ToString());
}
else if ("TaskAssignDate" == AttributeName[intIndex])
{
mstrTaskAssignDate = value.ToString();
}
else if ("PermiterId" == AttributeName[intIndex])
{
mstrPermiterId = value.ToString();
}
else if ("TaskPermitDate" == AttributeName[intIndex])
{
mstrTaskPermitDate = value.ToString();
}
else if ("IsFinished" == AttributeName[intIndex])
{
mbolIsFinished = TransNullToBool(value.ToString());
}
else if ("Executor" == AttributeName[intIndex])
{
mstrExecutor = value.ToString();
}
else if ("DepartMentId" == AttributeName[intIndex])
{
mstrDepartMentId = value.ToString();
}
else if ("ActualBeginDate" == AttributeName[intIndex])
{
mstrActualBeginDate = value.ToString();
}
else if ("ActualEndDate" == AttributeName[intIndex])
{
mstrActualEndDate = value.ToString();
}
else if ("ActualCostHours" == AttributeName[intIndex])
{
mintActualCostHours = TransNullToInt(value.ToString());
}
else if ("SubmitDate" == AttributeName[intIndex])
{
mstrSubmitDate = value.ToString();
}
else if ("TaskExcuteSum" == AttributeName[intIndex])
{
mstrTaskExcuteSum = value.ToString();
}
else if ("IsChecked" == AttributeName[intIndex])
{
mbolIsChecked = TransNullToBool(value.ToString());
}
else if ("CheckerId" == AttributeName[intIndex])
{
mstrCheckerId = value.ToString();
}
else if ("TaskCheckDate" == AttributeName[intIndex])
{
mstrTaskCheckDate = value.ToString();
}
else if ("CheckDesc" == AttributeName[intIndex])
{
mstrCheckDesc = value.ToString();
}
else if ("InspectTimes" == AttributeName[intIndex])
{
mintInspectTimes = TransNullToInt(value.ToString());
}
else if ("FinishedPercent" == AttributeName[intIndex])
{
mfltFinishedPercent = TransNullToFloat(value.ToString());
}
else if ("CumulatePoints" == AttributeName[intIndex])
{
mintCumulatePoints = TransNullToInt(value.ToString());
}
}
}

/// <summary>
/// 工程任务ID(说明:;字段类型:varchar;字段长度:8;是否可空:False)
/// </summary>
public string PrjTaskId
{
get
{
return mstrPrjTaskId;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrPrjTaskId = value;
}
else
{
mstrPrjTaskId = value;
}
//记录修改过的字段
AddUpdatedFld("PrjTaskId");
}
}
/// <summary>
/// 任务名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
/// </summary>
public string TaskName
{
get
{
return mstrTaskName;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrTaskName = value;
}
else
{
mstrTaskName = value;
}
//记录修改过的字段
AddUpdatedFld("TaskName");
}
}
/// <summary>
/// 内容(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
/// </summary>
public string TaskContent
{
get
{
return mstrTaskContent;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrTaskContent = value;
}
else
{
mstrTaskContent = value;
}
//记录修改过的字段
AddUpdatedFld("TaskContent");
}
}
/// <summary>
/// 工程ID(说明:;字段类型:char;字段长度:4;是否可空:False)
/// </summary>
public string PrjId
{
get
{
return mstrPrjId;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrPrjId = value;
}
else
{
mstrPrjId = value;
}
//记录修改过的字段
AddUpdatedFld("PrjId");
}
}
/// <summary>
/// 界面ID(说明:;字段类型:varchar;字段长度:8;是否可空:True)
/// </summary>
public string ViewId
{
get
{
return mstrViewId;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrViewId = value;
}
else
{
mstrViewId = value;
}
//记录修改过的字段
AddUpdatedFld("ViewId");
}
}
/// <summary>
/// 任务状态ID(说明:;字段类型:char;字段长度:2;是否可空:True)
/// </summary>
public string TaskStateId
{
get
{
return mstrTaskStateId;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrTaskStateId = value;
}
else
{
mstrTaskStateId = value;
}
//记录修改过的字段
AddUpdatedFld("TaskStateId");
}
}
/// <summary>
/// 任务类别ID(说明:;字段类型:varchar;字段长度:4;是否可空:True)
/// </summary>
public string TaskTypeId
{
get
{
return mstrTaskTypeId;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrTaskTypeId = value;
}
else
{
mstrTaskTypeId = value;
}
//记录修改过的字段
AddUpdatedFld("TaskTypeId");
}
}
/// <summary>
/// 计划开始日期(说明:;字段类型:char;字段长度:8;是否可空:True)
/// </summary>
public string PlanBeginDate
{
get
{
return mstrPlanBeginDate;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrPlanBeginDate = value;
}
else
{
mstrPlanBeginDate = value;
}
//记录修改过的字段
AddUpdatedFld("PlanBeginDate");
}
}
/// <summary>
/// 计划结束日期(说明:;字段类型:char;字段长度:8;是否可空:True)
/// </summary>
public string PlanEndDate
{
get
{
return mstrPlanEndDate;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrPlanEndDate = value;
}
else
{
mstrPlanEndDate = value;
}
//记录修改过的字段
AddUpdatedFld("PlanEndDate");
}
}
/// <summary>
/// 计划需要时间(说明:;字段类型:int;字段长度:4;是否可空:True)
/// </summary>
public int PlanNeedHours
{
get
{
return mintPlanNeedHours;
}
set
{
mintPlanNeedHours = value;
//记录修改过的字段
AddUpdatedFld("PlanNeedHours");
}
}
/// <summary>
/// 是否指派(说明:;字段类型:bit;字段长度:1;是否可空:True)
/// </summary>
public bool IsAssigned
{
get
{
return mbolIsAssigned;
}
set
{
mbolIsAssigned = value;
//记录修改过的字段
AddUpdatedFld("IsAssigned");
}
}
/// <summary>
/// 任务指派日期(说明:;字段类型:varchar;字段长度:8;是否可空:True)
/// </summary>
public string TaskAssignDate
{
get
{
return mstrTaskAssignDate;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrTaskAssignDate = value;
}
else
{
mstrTaskAssignDate = value;
}
//记录修改过的字段
AddUpdatedFld("TaskAssignDate");
}
}
/// <summary>
/// 确认人ID(说明:;字段类型:varchar;字段长度:18;是否可空:True)
/// </summary>
public string PermiterId
{
get
{
return mstrPermiterId;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrPermiterId = value;
}
else
{
mstrPermiterId = value;
}
//记录修改过的字段
AddUpdatedFld("PermiterId");
}
}
/// <summary>
/// 任务确认日期(说明:;字段类型:varchar;字段长度:8;是否可空:True)
/// </summary>
public string TaskPermitDate
{
get
{
return mstrTaskPermitDate;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrTaskPermitDate = value;
}
else
{
mstrTaskPermitDate = value;
}
//记录修改过的字段
AddUpdatedFld("TaskPermitDate");
}
}
/// <summary>
/// 是否完成(说明:;字段类型:bit;字段长度:1;是否可空:True)
/// </summary>
public bool IsFinished
{
get
{
return mbolIsFinished;
}
set
{
mbolIsFinished = value;
//记录修改过的字段
AddUpdatedFld("IsFinished");
}
}
/// <summary>
/// 实施者(说明:;字段类型:varchar;字段长度:18;是否可空:True)
/// </summary>
public string Executor
{
get
{
return mstrExecutor;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrExecutor = value;
}
else
{
mstrExecutor = value;
}
//记录修改过的字段
AddUpdatedFld("Executor");
}
}
/// <summary>
/// 部门ID(说明:;字段类型:varchar;字段长度:8;是否可空:True)
/// </summary>
public string DepartMentId
{
get
{
return mstrDepartMentId;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrDepartMentId = value;
}
else
{
mstrDepartMentId = value;
}
//记录修改过的字段
AddUpdatedFld("DepartMentId");
}
}
/// <summary>
/// 实际开始日期(说明:;字段类型:char;字段长度:8;是否可空:True)
/// </summary>
public string ActualBeginDate
{
get
{
return mstrActualBeginDate;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrActualBeginDate = value;
}
else
{
mstrActualBeginDate = value;
}
//记录修改过的字段
AddUpdatedFld("ActualBeginDate");
}
}
/// <summary>
/// 实际结束日期(说明:;字段类型:char;字段长度:8;是否可空:True)
/// </summary>
public string ActualEndDate
{
get
{
return mstrActualEndDate;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrActualEndDate = value;
}
else
{
mstrActualEndDate = value;
}
//记录修改过的字段
AddUpdatedFld("ActualEndDate");
}
}
/// <summary>
/// 实际花费时间(说明:;字段类型:int;字段长度:4;是否可空:True)
/// </summary>
public int ActualCostHours
{
get
{
return mintActualCostHours;
}
set
{
mintActualCostHours = value;
//记录修改过的字段
AddUpdatedFld("ActualCostHours");
}
}
/// <summary>
/// 提交日期(说明:;字段类型:char;字段长度:8;是否可空:True)
/// </summary>
public string SubmitDate
{
get
{
return mstrSubmitDate;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrSubmitDate = value;
}
else
{
mstrSubmitDate = value;
}
//记录修改过的字段
AddUpdatedFld("SubmitDate");
}
}
/// <summary>
/// 任务实施总结(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
/// </summary>
public string TaskExcuteSum
{
get
{
return mstrTaskExcuteSum;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrTaskExcuteSum = value;
}
else
{
mstrTaskExcuteSum = value;
}
//记录修改过的字段
AddUpdatedFld("TaskExcuteSum");
}
}
/// <summary>
/// 是否核实(说明:;字段类型:bit;字段长度:1;是否可空:True)
/// </summary>
public bool IsChecked
{
get
{
return mbolIsChecked;
}
set
{
mbolIsChecked = value;
//记录修改过的字段
AddUpdatedFld("IsChecked");
}
}
/// <summary>
/// 核实人ID(说明:;字段类型:varchar;字段长度:18;是否可空:True)
/// </summary>
public string CheckerId
{
get
{
return mstrCheckerId;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrCheckerId = value;
}
else
{
mstrCheckerId = value;
}
//记录修改过的字段
AddUpdatedFld("CheckerId");
}
}
/// <summary>
/// 任务核实日期(说明:;字段类型:varchar;字段长度:8;是否可空:True)
/// </summary>
public string TaskCheckDate
{
get
{
return mstrTaskCheckDate;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrTaskCheckDate = value;
}
else
{
mstrTaskCheckDate = value;
}
//记录修改过的字段
AddUpdatedFld("TaskCheckDate");
}
}
/// <summary>
/// 核实情况(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
/// </summary>
public string CheckDesc
{
get
{
return mstrCheckDesc;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrCheckDesc = value;
}
else
{
mstrCheckDesc = value;
}
//记录修改过的字段
AddUpdatedFld("CheckDesc");
}
}
/// <summary>
/// 检查次数(说明:;字段类型:int;字段长度:4;是否可空:True)
/// </summary>
public int InspectTimes
{
get
{
return mintInspectTimes;
}
set
{
mintInspectTimes = value;
//记录修改过的字段
AddUpdatedFld("InspectTimes");
}
}
/// <summary>
/// 当前完成百分比(说明:;字段类型:float;字段长度:8;是否可空:True)
/// </summary>
public float FinishedPercent
{
get
{
return mfltFinishedPercent;
}
set
{
mfltFinishedPercent = value;
//记录修改过的字段
AddUpdatedFld("FinishedPercent");
}
}
/// <summary>
/// 积点(说明:;字段类型:int;字段长度:4;是否可空:True)
/// </summary>
public int CumulatePoints
{
get
{
return mintCumulatePoints;
}
set
{
mintCumulatePoints = value;
//记录修改过的字段
AddUpdatedFld("CumulatePoints");
}
}
}
}