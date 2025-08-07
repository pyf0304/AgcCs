
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clswf_ProcessEN
 表名:wf_Process(00050484)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:18:52
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
 /// 表wf_Process的关键字(ProcessId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ProcessId_wf_Process
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strProcessId">表关键字</param>
public K_ProcessId_wf_Process(string strProcessId)
{
if (IsValid(strProcessId)) Value = strProcessId;
else
{
Value = null;
}
}
private static bool IsValid(string strProcessId)
{
if (string.IsNullOrEmpty(strProcessId) == true) return false;
if (strProcessId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ProcessId_wf_Process]类型的对象</returns>
public static implicit operator K_ProcessId_wf_Process(string value)
{
return new K_ProcessId_wf_Process(value);
}
}
 /// <summary>
 /// 工作流过程(wf_Process)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clswf_ProcessEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接，如果为空就使用系统默认的连接
public new const string _CurrTabName = "wf_Process"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ProcessId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string WhereFormat = ""; //条件格式串
protected const int mintAttributeCount = 12;
public static string[] AttributeName = new string[] {"ProcessId", "ProcessName", "PrjId", "EndPoint", "StartPoint", "WorkPage", "ExamPhaseId", "DefaExamDepId", "OrderNum", "UpdDate", "UpdUser", "Memo"};

protected string mstrProcessId;    //过程ID
protected string mstrProcessName;    //过程名称
protected string mstrPrjId;    //工程ID
protected string mstrEndPoint;    //终点
protected string mstrStartPoint;    //起点
protected string mstrWorkPage;    //工作页面
protected string mstrExamPhaseId;    //考核阶段Id
protected string mstrDefaExamDepId;    //默认考核部门Id
protected int? mintOrderNum;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clswf_ProcessEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "wf_Process";
 lstKeyFldNames.Add("ProcessId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strProcessId">关键字:过程ID</param>
public clswf_ProcessEN(string strProcessId)
 {
strProcessId = strProcessId.Replace("'", "''");
if (strProcessId.Length > 8)
{
throw new Exception("在表:wf_Process中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strProcessId)  ==  true)
{
throw new Exception("在表:wf_Process中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strProcessId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrProcessId = strProcessId;
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "wf_Process";
 lstKeyFldNames.Add("ProcessId");
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
if (strAttributeName  ==  conwf_Process.ProcessId)
{
return mstrProcessId;
}
else if (strAttributeName  ==  conwf_Process.ProcessName)
{
return mstrProcessName;
}
else if (strAttributeName  ==  conwf_Process.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conwf_Process.EndPoint)
{
return mstrEndPoint;
}
else if (strAttributeName  ==  conwf_Process.StartPoint)
{
return mstrStartPoint;
}
else if (strAttributeName  ==  conwf_Process.WorkPage)
{
return mstrWorkPage;
}
else if (strAttributeName  ==  conwf_Process.ExamPhaseId)
{
return mstrExamPhaseId;
}
else if (strAttributeName  ==  conwf_Process.DefaExamDepId)
{
return mstrDefaExamDepId;
}
else if (strAttributeName  ==  conwf_Process.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conwf_Process.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conwf_Process.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conwf_Process.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conwf_Process.ProcessId)
{
mstrProcessId = value.ToString();
 AddUpdatedFld(conwf_Process.ProcessId);
}
else if (strAttributeName  ==  conwf_Process.ProcessName)
{
mstrProcessName = value.ToString();
 AddUpdatedFld(conwf_Process.ProcessName);
}
else if (strAttributeName  ==  conwf_Process.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conwf_Process.PrjId);
}
else if (strAttributeName  ==  conwf_Process.EndPoint)
{
mstrEndPoint = value.ToString();
 AddUpdatedFld(conwf_Process.EndPoint);
}
else if (strAttributeName  ==  conwf_Process.StartPoint)
{
mstrStartPoint = value.ToString();
 AddUpdatedFld(conwf_Process.StartPoint);
}
else if (strAttributeName  ==  conwf_Process.WorkPage)
{
mstrWorkPage = value.ToString();
 AddUpdatedFld(conwf_Process.WorkPage);
}
else if (strAttributeName  ==  conwf_Process.ExamPhaseId)
{
mstrExamPhaseId = value.ToString();
 AddUpdatedFld(conwf_Process.ExamPhaseId);
}
else if (strAttributeName  ==  conwf_Process.DefaExamDepId)
{
mstrDefaExamDepId = value.ToString();
 AddUpdatedFld(conwf_Process.DefaExamDepId);
}
else if (strAttributeName  ==  conwf_Process.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conwf_Process.OrderNum);
}
else if (strAttributeName  ==  conwf_Process.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conwf_Process.UpdDate);
}
else if (strAttributeName  ==  conwf_Process.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conwf_Process.UpdUser);
}
else if (strAttributeName  ==  conwf_Process.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conwf_Process.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conwf_Process.ProcessId  ==  AttributeName[intIndex])
{
return mstrProcessId;
}
else if (conwf_Process.ProcessName  ==  AttributeName[intIndex])
{
return mstrProcessName;
}
else if (conwf_Process.PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conwf_Process.EndPoint  ==  AttributeName[intIndex])
{
return mstrEndPoint;
}
else if (conwf_Process.StartPoint  ==  AttributeName[intIndex])
{
return mstrStartPoint;
}
else if (conwf_Process.WorkPage  ==  AttributeName[intIndex])
{
return mstrWorkPage;
}
else if (conwf_Process.ExamPhaseId  ==  AttributeName[intIndex])
{
return mstrExamPhaseId;
}
else if (conwf_Process.DefaExamDepId  ==  AttributeName[intIndex])
{
return mstrDefaExamDepId;
}
else if (conwf_Process.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conwf_Process.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conwf_Process.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conwf_Process.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conwf_Process.ProcessId  ==  AttributeName[intIndex])
{
mstrProcessId = value.ToString();
 AddUpdatedFld(conwf_Process.ProcessId);
}
else if (conwf_Process.ProcessName  ==  AttributeName[intIndex])
{
mstrProcessName = value.ToString();
 AddUpdatedFld(conwf_Process.ProcessName);
}
else if (conwf_Process.PrjId  ==  AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conwf_Process.PrjId);
}
else if (conwf_Process.EndPoint  ==  AttributeName[intIndex])
{
mstrEndPoint = value.ToString();
 AddUpdatedFld(conwf_Process.EndPoint);
}
else if (conwf_Process.StartPoint  ==  AttributeName[intIndex])
{
mstrStartPoint = value.ToString();
 AddUpdatedFld(conwf_Process.StartPoint);
}
else if (conwf_Process.WorkPage  ==  AttributeName[intIndex])
{
mstrWorkPage = value.ToString();
 AddUpdatedFld(conwf_Process.WorkPage);
}
else if (conwf_Process.ExamPhaseId  ==  AttributeName[intIndex])
{
mstrExamPhaseId = value.ToString();
 AddUpdatedFld(conwf_Process.ExamPhaseId);
}
else if (conwf_Process.DefaExamDepId  ==  AttributeName[intIndex])
{
mstrDefaExamDepId = value.ToString();
 AddUpdatedFld(conwf_Process.DefaExamDepId);
}
else if (conwf_Process.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conwf_Process.OrderNum);
}
else if (conwf_Process.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conwf_Process.UpdDate);
}
else if (conwf_Process.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conwf_Process.UpdUser);
}
else if (conwf_Process.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conwf_Process.Memo);
}
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
 AddUpdatedFld(conwf_Process.ProcessId);
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
 AddUpdatedFld(conwf_Process.ProcessName);
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
 AddUpdatedFld(conwf_Process.PrjId);
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
 AddUpdatedFld(conwf_Process.EndPoint);
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
 AddUpdatedFld(conwf_Process.StartPoint);
}
}
/// <summary>
/// 工作页面(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WorkPage
{
get
{
return mstrWorkPage;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWorkPage = value;
}
else
{
 mstrWorkPage = value;
}
//记录修改过的字段
 AddUpdatedFld(conwf_Process.WorkPage);
}
}
/// <summary>
/// 考核阶段Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExamPhaseId
{
get
{
return mstrExamPhaseId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExamPhaseId = value;
}
else
{
 mstrExamPhaseId = value;
}
//记录修改过的字段
 AddUpdatedFld(conwf_Process.ExamPhaseId);
}
}
/// <summary>
/// 默认考核部门Id(说明:;字段类型:varchar;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DefaExamDepId
{
get
{
return mstrDefaExamDepId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDefaExamDepId = value;
}
else
{
 mstrDefaExamDepId = value;
}
//记录修改过的字段
 AddUpdatedFld(conwf_Process.DefaExamDepId);
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
 AddUpdatedFld(conwf_Process.OrderNum);
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
 AddUpdatedFld(conwf_Process.UpdDate);
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
 AddUpdatedFld(conwf_Process.UpdUser);
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
 AddUpdatedFld(conwf_Process.Memo);
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
  return mstrProcessId;
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
  return mstrProcessName;
 }
 }
}
 /// <summary>
 /// 工作流过程(wf_Process)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conwf_Process
{
public new const string _CurrTabName = "wf_Process"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ProcessId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ProcessId", "ProcessName", "PrjId", "EndPoint", "StartPoint", "WorkPage", "ExamPhaseId", "DefaExamDepId", "OrderNum", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


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
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程ID

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
 /// 常量:"WorkPage"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WorkPage = "WorkPage";    //工作页面

 /// <summary>
 /// 常量:"ExamPhaseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExamPhaseId = "ExamPhaseId";    //考核阶段Id

 /// <summary>
 /// 常量:"DefaExamDepId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DefaExamDepId = "DefaExamDepId";    //默认考核部门Id

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

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