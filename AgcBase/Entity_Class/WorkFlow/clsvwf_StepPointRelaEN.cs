
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvwf_StepPointRelaEN
 表名:vwf_StepPointRela(00050487)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:47:56
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:工作流管理(WorkFlow)
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
 /// 表vwf_StepPointRela的关键字(WorkFlowStepPointRelaId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_WorkFlowStepPointRelaId_vwf_StepPointRela
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngWorkFlowStepPointRelaId">表关键字</param>
public K_WorkFlowStepPointRelaId_vwf_StepPointRela(long lngWorkFlowStepPointRelaId)
{
if (IsValid(lngWorkFlowStepPointRelaId)) Value = lngWorkFlowStepPointRelaId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngWorkFlowStepPointRelaId)
{
if (lngWorkFlowStepPointRelaId == 0) return false;
if (lngWorkFlowStepPointRelaId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_WorkFlowStepPointRelaId_vwf_StepPointRela]类型的对象</returns>
public static implicit operator K_WorkFlowStepPointRelaId_vwf_StepPointRela(long value)
{
return new K_WorkFlowStepPointRelaId_vwf_StepPointRela(value);
}
}
 /// <summary>
 /// v工作流与结点关系(vwf_StepPointRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvwf_StepPointRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vwf_StepPointRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "WorkFlowStepPointRelaId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 18;
public static string[] _AttributeName = new string[] {"WorkFlowStepPointRelaId", "WorkFlowId", "WorkFlowName", "WorkFlowNameSim", "PrjId", "PrjName", "PointId", "PointName", "TabKeyId", "PointTypeId", "PointTypeName", "LevelNo", "InDegree", "OutDegree", "OrderNum", "UpdDate", "UpdUser", "Memo"};

protected long mlngWorkFlowStepPointRelaId;    //工作流与结点关系Id
protected string mstrWorkFlowId;    //工作流Id
protected string mstrWorkFlowName;    //工作流名称
protected string mstrWorkFlowNameSim;    //工作流简称
protected string mstrPrjId;    //工程Id
protected string mstrPrjName;    //工程名称
protected string mstrPointId;    //结点Id
protected string mstrPointName;    //结点名称
protected string mstrTabKeyId;    //表关键字Id
protected string mstrPointTypeId;    //工作流结点类型Id
protected string mstrPointTypeName;    //工作流结点类型名称
protected int? mintLevelNo;    //层序号
protected int? mintInDegree;    //入度
protected int? mintOutDegree;    //出度
protected int? mintOrderNum;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvwf_StepPointRelaEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("WorkFlowStepPointRelaId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "lngWorkFlowStepPointRelaId">关键字:工作流与结点关系Id</param>
public clsvwf_StepPointRelaEN(long lngWorkFlowStepPointRelaId)
 {
 if (lngWorkFlowStepPointRelaId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngWorkFlowStepPointRelaId = lngWorkFlowStepPointRelaId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("WorkFlowStepPointRelaId");
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
if (strAttributeName  ==  convwf_StepPointRela.WorkFlowStepPointRelaId)
{
return mlngWorkFlowStepPointRelaId;
}
else if (strAttributeName  ==  convwf_StepPointRela.WorkFlowId)
{
return mstrWorkFlowId;
}
else if (strAttributeName  ==  convwf_StepPointRela.WorkFlowName)
{
return mstrWorkFlowName;
}
else if (strAttributeName  ==  convwf_StepPointRela.WorkFlowNameSim)
{
return mstrWorkFlowNameSim;
}
else if (strAttributeName  ==  convwf_StepPointRela.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convwf_StepPointRela.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convwf_StepPointRela.PointId)
{
return mstrPointId;
}
else if (strAttributeName  ==  convwf_StepPointRela.PointName)
{
return mstrPointName;
}
else if (strAttributeName  ==  convwf_StepPointRela.TabKeyId)
{
return mstrTabKeyId;
}
else if (strAttributeName  ==  convwf_StepPointRela.PointTypeId)
{
return mstrPointTypeId;
}
else if (strAttributeName  ==  convwf_StepPointRela.PointTypeName)
{
return mstrPointTypeName;
}
else if (strAttributeName  ==  convwf_StepPointRela.LevelNo)
{
return mintLevelNo;
}
else if (strAttributeName  ==  convwf_StepPointRela.InDegree)
{
return mintInDegree;
}
else if (strAttributeName  ==  convwf_StepPointRela.OutDegree)
{
return mintOutDegree;
}
else if (strAttributeName  ==  convwf_StepPointRela.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convwf_StepPointRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convwf_StepPointRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convwf_StepPointRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convwf_StepPointRela.WorkFlowStepPointRelaId)
{
mlngWorkFlowStepPointRelaId = TransNullToInt(value.ToString());
 AddUpdatedFld(convwf_StepPointRela.WorkFlowStepPointRelaId);
}
else if (strAttributeName  ==  convwf_StepPointRela.WorkFlowId)
{
mstrWorkFlowId = value.ToString();
 AddUpdatedFld(convwf_StepPointRela.WorkFlowId);
}
else if (strAttributeName  ==  convwf_StepPointRela.WorkFlowName)
{
mstrWorkFlowName = value.ToString();
 AddUpdatedFld(convwf_StepPointRela.WorkFlowName);
}
else if (strAttributeName  ==  convwf_StepPointRela.WorkFlowNameSim)
{
mstrWorkFlowNameSim = value.ToString();
 AddUpdatedFld(convwf_StepPointRela.WorkFlowNameSim);
}
else if (strAttributeName  ==  convwf_StepPointRela.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convwf_StepPointRela.PrjId);
}
else if (strAttributeName  ==  convwf_StepPointRela.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convwf_StepPointRela.PrjName);
}
else if (strAttributeName  ==  convwf_StepPointRela.PointId)
{
mstrPointId = value.ToString();
 AddUpdatedFld(convwf_StepPointRela.PointId);
}
else if (strAttributeName  ==  convwf_StepPointRela.PointName)
{
mstrPointName = value.ToString();
 AddUpdatedFld(convwf_StepPointRela.PointName);
}
else if (strAttributeName  ==  convwf_StepPointRela.TabKeyId)
{
mstrTabKeyId = value.ToString();
 AddUpdatedFld(convwf_StepPointRela.TabKeyId);
}
else if (strAttributeName  ==  convwf_StepPointRela.PointTypeId)
{
mstrPointTypeId = value.ToString();
 AddUpdatedFld(convwf_StepPointRela.PointTypeId);
}
else if (strAttributeName  ==  convwf_StepPointRela.PointTypeName)
{
mstrPointTypeName = value.ToString();
 AddUpdatedFld(convwf_StepPointRela.PointTypeName);
}
else if (strAttributeName  ==  convwf_StepPointRela.LevelNo)
{
mintLevelNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convwf_StepPointRela.LevelNo);
}
else if (strAttributeName  ==  convwf_StepPointRela.InDegree)
{
mintInDegree = TransNullToInt(value.ToString());
 AddUpdatedFld(convwf_StepPointRela.InDegree);
}
else if (strAttributeName  ==  convwf_StepPointRela.OutDegree)
{
mintOutDegree = TransNullToInt(value.ToString());
 AddUpdatedFld(convwf_StepPointRela.OutDegree);
}
else if (strAttributeName  ==  convwf_StepPointRela.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convwf_StepPointRela.OrderNum);
}
else if (strAttributeName  ==  convwf_StepPointRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convwf_StepPointRela.UpdDate);
}
else if (strAttributeName  ==  convwf_StepPointRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convwf_StepPointRela.UpdUser);
}
else if (strAttributeName  ==  convwf_StepPointRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convwf_StepPointRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convwf_StepPointRela.WorkFlowStepPointRelaId  ==  _AttributeName[intIndex])
{
return mlngWorkFlowStepPointRelaId;
}
else if (convwf_StepPointRela.WorkFlowId  ==  _AttributeName[intIndex])
{
return mstrWorkFlowId;
}
else if (convwf_StepPointRela.WorkFlowName  ==  _AttributeName[intIndex])
{
return mstrWorkFlowName;
}
else if (convwf_StepPointRela.WorkFlowNameSim  ==  _AttributeName[intIndex])
{
return mstrWorkFlowNameSim;
}
else if (convwf_StepPointRela.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convwf_StepPointRela.PrjName  ==  _AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convwf_StepPointRela.PointId  ==  _AttributeName[intIndex])
{
return mstrPointId;
}
else if (convwf_StepPointRela.PointName  ==  _AttributeName[intIndex])
{
return mstrPointName;
}
else if (convwf_StepPointRela.TabKeyId  ==  _AttributeName[intIndex])
{
return mstrTabKeyId;
}
else if (convwf_StepPointRela.PointTypeId  ==  _AttributeName[intIndex])
{
return mstrPointTypeId;
}
else if (convwf_StepPointRela.PointTypeName  ==  _AttributeName[intIndex])
{
return mstrPointTypeName;
}
else if (convwf_StepPointRela.LevelNo  ==  _AttributeName[intIndex])
{
return mintLevelNo;
}
else if (convwf_StepPointRela.InDegree  ==  _AttributeName[intIndex])
{
return mintInDegree;
}
else if (convwf_StepPointRela.OutDegree  ==  _AttributeName[intIndex])
{
return mintOutDegree;
}
else if (convwf_StepPointRela.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convwf_StepPointRela.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convwf_StepPointRela.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convwf_StepPointRela.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convwf_StepPointRela.WorkFlowStepPointRelaId  ==  _AttributeName[intIndex])
{
mlngWorkFlowStepPointRelaId = TransNullToInt(value.ToString());
 AddUpdatedFld(convwf_StepPointRela.WorkFlowStepPointRelaId);
}
else if (convwf_StepPointRela.WorkFlowId  ==  _AttributeName[intIndex])
{
mstrWorkFlowId = value.ToString();
 AddUpdatedFld(convwf_StepPointRela.WorkFlowId);
}
else if (convwf_StepPointRela.WorkFlowName  ==  _AttributeName[intIndex])
{
mstrWorkFlowName = value.ToString();
 AddUpdatedFld(convwf_StepPointRela.WorkFlowName);
}
else if (convwf_StepPointRela.WorkFlowNameSim  ==  _AttributeName[intIndex])
{
mstrWorkFlowNameSim = value.ToString();
 AddUpdatedFld(convwf_StepPointRela.WorkFlowNameSim);
}
else if (convwf_StepPointRela.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convwf_StepPointRela.PrjId);
}
else if (convwf_StepPointRela.PrjName  ==  _AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convwf_StepPointRela.PrjName);
}
else if (convwf_StepPointRela.PointId  ==  _AttributeName[intIndex])
{
mstrPointId = value.ToString();
 AddUpdatedFld(convwf_StepPointRela.PointId);
}
else if (convwf_StepPointRela.PointName  ==  _AttributeName[intIndex])
{
mstrPointName = value.ToString();
 AddUpdatedFld(convwf_StepPointRela.PointName);
}
else if (convwf_StepPointRela.TabKeyId  ==  _AttributeName[intIndex])
{
mstrTabKeyId = value.ToString();
 AddUpdatedFld(convwf_StepPointRela.TabKeyId);
}
else if (convwf_StepPointRela.PointTypeId  ==  _AttributeName[intIndex])
{
mstrPointTypeId = value.ToString();
 AddUpdatedFld(convwf_StepPointRela.PointTypeId);
}
else if (convwf_StepPointRela.PointTypeName  ==  _AttributeName[intIndex])
{
mstrPointTypeName = value.ToString();
 AddUpdatedFld(convwf_StepPointRela.PointTypeName);
}
else if (convwf_StepPointRela.LevelNo  ==  _AttributeName[intIndex])
{
mintLevelNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convwf_StepPointRela.LevelNo);
}
else if (convwf_StepPointRela.InDegree  ==  _AttributeName[intIndex])
{
mintInDegree = TransNullToInt(value.ToString());
 AddUpdatedFld(convwf_StepPointRela.InDegree);
}
else if (convwf_StepPointRela.OutDegree  ==  _AttributeName[intIndex])
{
mintOutDegree = TransNullToInt(value.ToString());
 AddUpdatedFld(convwf_StepPointRela.OutDegree);
}
else if (convwf_StepPointRela.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convwf_StepPointRela.OrderNum);
}
else if (convwf_StepPointRela.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convwf_StepPointRela.UpdDate);
}
else if (convwf_StepPointRela.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convwf_StepPointRela.UpdUser);
}
else if (convwf_StepPointRela.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convwf_StepPointRela.Memo);
}
}
}

/// <summary>
/// 工作流与结点关系Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long WorkFlowStepPointRelaId
{
get
{
return mlngWorkFlowStepPointRelaId;
}
set
{
 mlngWorkFlowStepPointRelaId = value;
//记录修改过的字段
 AddUpdatedFld(convwf_StepPointRela.WorkFlowStepPointRelaId);
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
 AddUpdatedFld(convwf_StepPointRela.WorkFlowId);
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
 AddUpdatedFld(convwf_StepPointRela.WorkFlowName);
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
 AddUpdatedFld(convwf_StepPointRela.WorkFlowNameSim);
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
 AddUpdatedFld(convwf_StepPointRela.PrjId);
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
 AddUpdatedFld(convwf_StepPointRela.PrjName);
}
}
/// <summary>
/// 结点Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PointId
{
get
{
return mstrPointId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPointId = value;
}
else
{
 mstrPointId = value;
}
//记录修改过的字段
 AddUpdatedFld(convwf_StepPointRela.PointId);
}
}
/// <summary>
/// 结点名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PointName
{
get
{
return mstrPointName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPointName = value;
}
else
{
 mstrPointName = value;
}
//记录修改过的字段
 AddUpdatedFld(convwf_StepPointRela.PointName);
}
}
/// <summary>
/// 表关键字Id(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabKeyId
{
get
{
return mstrTabKeyId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabKeyId = value;
}
else
{
 mstrTabKeyId = value;
}
//记录修改过的字段
 AddUpdatedFld(convwf_StepPointRela.TabKeyId);
}
}
/// <summary>
/// 工作流结点类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PointTypeId
{
get
{
return mstrPointTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPointTypeId = value;
}
else
{
 mstrPointTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convwf_StepPointRela.PointTypeId);
}
}
/// <summary>
/// 工作流结点类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PointTypeName
{
get
{
return mstrPointTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPointTypeName = value;
}
else
{
 mstrPointTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convwf_StepPointRela.PointTypeName);
}
}
/// <summary>
/// 层序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? LevelNo
{
get
{
return mintLevelNo;
}
set
{
 mintLevelNo = value;
//记录修改过的字段
 AddUpdatedFld(convwf_StepPointRela.LevelNo);
}
}
/// <summary>
/// 入度(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? InDegree
{
get
{
return mintInDegree;
}
set
{
 mintInDegree = value;
//记录修改过的字段
 AddUpdatedFld(convwf_StepPointRela.InDegree);
}
}
/// <summary>
/// 出度(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OutDegree
{
get
{
return mintOutDegree;
}
set
{
 mintOutDegree = value;
//记录修改过的字段
 AddUpdatedFld(convwf_StepPointRela.OutDegree);
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
 AddUpdatedFld(convwf_StepPointRela.OrderNum);
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
 AddUpdatedFld(convwf_StepPointRela.UpdDate);
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
 AddUpdatedFld(convwf_StepPointRela.UpdUser);
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
 AddUpdatedFld(convwf_StepPointRela.Memo);
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
  return mlngWorkFlowStepPointRelaId.ToString();
 }
 }
}
 /// <summary>
 /// v工作流与结点关系(vwf_StepPointRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convwf_StepPointRela
{
public const string _CurrTabName = "vwf_StepPointRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "WorkFlowStepPointRelaId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"WorkFlowStepPointRelaId", "WorkFlowId", "WorkFlowName", "WorkFlowNameSim", "PrjId", "PrjName", "PointId", "PointName", "TabKeyId", "PointTypeId", "PointTypeName", "LevelNo", "InDegree", "OutDegree", "OrderNum", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"WorkFlowStepPointRelaId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WorkFlowStepPointRelaId = "WorkFlowStepPointRelaId";    //工作流与结点关系Id

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
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"PrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjName = "PrjName";    //工程名称

 /// <summary>
 /// 常量:"PointId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PointId = "PointId";    //结点Id

 /// <summary>
 /// 常量:"PointName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PointName = "PointName";    //结点名称

 /// <summary>
 /// 常量:"TabKeyId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabKeyId = "TabKeyId";    //表关键字Id

 /// <summary>
 /// 常量:"PointTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PointTypeId = "PointTypeId";    //工作流结点类型Id

 /// <summary>
 /// 常量:"PointTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PointTypeName = "PointTypeName";    //工作流结点类型名称

 /// <summary>
 /// 常量:"LevelNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LevelNo = "LevelNo";    //层序号

 /// <summary>
 /// 常量:"InDegree"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InDegree = "InDegree";    //入度

 /// <summary>
 /// 常量:"OutDegree"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OutDegree = "OutDegree";    //出度

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