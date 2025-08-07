
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDataNodeEN
 表名:DataNode(00050547)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:27:53
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:AI模块(AIModule)
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
 /// 表DataNode的关键字(DataNodeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_DataNodeId_DataNode
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngDataNodeId">表关键字</param>
public K_DataNodeId_DataNode(long lngDataNodeId)
{
if (IsValid(lngDataNodeId)) Value = lngDataNodeId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngDataNodeId)
{
if (lngDataNodeId == 0) return false;
if (lngDataNodeId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_DataNodeId_DataNode]类型的对象</returns>
public static implicit operator K_DataNodeId_DataNode(long value)
{
return new K_DataNodeId_DataNode(value);
}
}
 /// <summary>
 /// 数据结点(DataNode)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsDataNodeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "DataNode"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "DataNodeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = "datanodeid in (select DataNodeId from DataNodeCmPrjIdRela where CmPrjId='{0}')"; //前台条件格式串
protected const int _AttributeCount = 19;
public static string[] _AttributeName = new string[] {"DataNodeId", "DataNodeName", "TabId", "FldId", "KeyFldLst", "VersionNo", "DataNodeTypeId", "Depth", "PrevDataNodeId", "NextDataNodeId", "SubGraphName", "ErrMsg", "PrjId", "PosX", "PosY", "UsedTimes", "UpdDate", "UpdUser", "Memo"};

protected long mlngDataNodeId;    //数据结点Id
protected string mstrDataNodeName;    //数据结点名
protected string mstrTabId;    //表ID
protected string mstrFldId;    //字段Id
protected string mstrKeyFldLst;    //关键字段Id列表
protected int mintVersionNo;    //版本号
protected string mstrDataNodeTypeId;    //数据结点类型Id
protected int? mintDepth;    //深度
protected long? mlngPrevDataNodeId;    //前置数据结点Id
protected long? mlngNextDataNodeId;    //后继数据结点Id
protected string mstrSubGraphName;    //子图名
protected string mstrErrMsg;    //错误信息
protected string mstrPrjId;    //工程Id
protected double? mdblPosX;    //位置X
protected double? mdblPosY;    //位置Y
protected int? mintUsedTimes;    //使用次数
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsDataNodeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("DataNodeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "lngDataNodeId">关键字:数据结点Id</param>
public clsDataNodeEN(long lngDataNodeId)
 {
 if (lngDataNodeId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngDataNodeId = lngDataNodeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("DataNodeId");
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
if (strAttributeName  ==  conDataNode.DataNodeId)
{
return mlngDataNodeId;
}
else if (strAttributeName  ==  conDataNode.DataNodeName)
{
return mstrDataNodeName;
}
else if (strAttributeName  ==  conDataNode.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  conDataNode.FldId)
{
return mstrFldId;
}
else if (strAttributeName  ==  conDataNode.KeyFldLst)
{
return mstrKeyFldLst;
}
else if (strAttributeName  ==  conDataNode.VersionNo)
{
return mintVersionNo;
}
else if (strAttributeName  ==  conDataNode.DataNodeTypeId)
{
return mstrDataNodeTypeId;
}
else if (strAttributeName  ==  conDataNode.Depth)
{
return mintDepth;
}
else if (strAttributeName  ==  conDataNode.PrevDataNodeId)
{
return mlngPrevDataNodeId;
}
else if (strAttributeName  ==  conDataNode.NextDataNodeId)
{
return mlngNextDataNodeId;
}
else if (strAttributeName  ==  conDataNode.SubGraphName)
{
return mstrSubGraphName;
}
else if (strAttributeName  ==  conDataNode.ErrMsg)
{
return mstrErrMsg;
}
else if (strAttributeName  ==  conDataNode.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conDataNode.PosX)
{
return mdblPosX;
}
else if (strAttributeName  ==  conDataNode.PosY)
{
return mdblPosY;
}
else if (strAttributeName  ==  conDataNode.UsedTimes)
{
return mintUsedTimes;
}
else if (strAttributeName  ==  conDataNode.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conDataNode.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conDataNode.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conDataNode.DataNodeId)
{
mlngDataNodeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conDataNode.DataNodeId);
}
else if (strAttributeName  ==  conDataNode.DataNodeName)
{
mstrDataNodeName = value.ToString();
 AddUpdatedFld(conDataNode.DataNodeName);
}
else if (strAttributeName  ==  conDataNode.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(conDataNode.TabId);
}
else if (strAttributeName  ==  conDataNode.FldId)
{
mstrFldId = value.ToString();
 AddUpdatedFld(conDataNode.FldId);
}
else if (strAttributeName  ==  conDataNode.KeyFldLst)
{
mstrKeyFldLst = value.ToString();
 AddUpdatedFld(conDataNode.KeyFldLst);
}
else if (strAttributeName  ==  conDataNode.VersionNo)
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(conDataNode.VersionNo);
}
else if (strAttributeName  ==  conDataNode.DataNodeTypeId)
{
mstrDataNodeTypeId = value.ToString();
 AddUpdatedFld(conDataNode.DataNodeTypeId);
}
else if (strAttributeName  ==  conDataNode.Depth)
{
mintDepth = TransNullToInt(value.ToString());
 AddUpdatedFld(conDataNode.Depth);
}
else if (strAttributeName  ==  conDataNode.PrevDataNodeId)
{
mlngPrevDataNodeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conDataNode.PrevDataNodeId);
}
else if (strAttributeName  ==  conDataNode.NextDataNodeId)
{
mlngNextDataNodeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conDataNode.NextDataNodeId);
}
else if (strAttributeName  ==  conDataNode.SubGraphName)
{
mstrSubGraphName = value.ToString();
 AddUpdatedFld(conDataNode.SubGraphName);
}
else if (strAttributeName  ==  conDataNode.ErrMsg)
{
mstrErrMsg = value.ToString();
 AddUpdatedFld(conDataNode.ErrMsg);
}
else if (strAttributeName  ==  conDataNode.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conDataNode.PrjId);
}
else if (strAttributeName  ==  conDataNode.PosX)
{
mdblPosX = TransNullToDouble(value.ToString());
 AddUpdatedFld(conDataNode.PosX);
}
else if (strAttributeName  ==  conDataNode.PosY)
{
mdblPosY = TransNullToDouble(value.ToString());
 AddUpdatedFld(conDataNode.PosY);
}
else if (strAttributeName  ==  conDataNode.UsedTimes)
{
mintUsedTimes = TransNullToInt(value.ToString());
 AddUpdatedFld(conDataNode.UsedTimes);
}
else if (strAttributeName  ==  conDataNode.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conDataNode.UpdDate);
}
else if (strAttributeName  ==  conDataNode.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conDataNode.UpdUser);
}
else if (strAttributeName  ==  conDataNode.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDataNode.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conDataNode.DataNodeId  ==  _AttributeName[intIndex])
{
return mlngDataNodeId;
}
else if (conDataNode.DataNodeName  ==  _AttributeName[intIndex])
{
return mstrDataNodeName;
}
else if (conDataNode.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (conDataNode.FldId  ==  _AttributeName[intIndex])
{
return mstrFldId;
}
else if (conDataNode.KeyFldLst  ==  _AttributeName[intIndex])
{
return mstrKeyFldLst;
}
else if (conDataNode.VersionNo  ==  _AttributeName[intIndex])
{
return mintVersionNo;
}
else if (conDataNode.DataNodeTypeId  ==  _AttributeName[intIndex])
{
return mstrDataNodeTypeId;
}
else if (conDataNode.Depth  ==  _AttributeName[intIndex])
{
return mintDepth;
}
else if (conDataNode.PrevDataNodeId  ==  _AttributeName[intIndex])
{
return mlngPrevDataNodeId;
}
else if (conDataNode.NextDataNodeId  ==  _AttributeName[intIndex])
{
return mlngNextDataNodeId;
}
else if (conDataNode.SubGraphName  ==  _AttributeName[intIndex])
{
return mstrSubGraphName;
}
else if (conDataNode.ErrMsg  ==  _AttributeName[intIndex])
{
return mstrErrMsg;
}
else if (conDataNode.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conDataNode.PosX  ==  _AttributeName[intIndex])
{
return mdblPosX;
}
else if (conDataNode.PosY  ==  _AttributeName[intIndex])
{
return mdblPosY;
}
else if (conDataNode.UsedTimes  ==  _AttributeName[intIndex])
{
return mintUsedTimes;
}
else if (conDataNode.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conDataNode.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conDataNode.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conDataNode.DataNodeId  ==  _AttributeName[intIndex])
{
mlngDataNodeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conDataNode.DataNodeId);
}
else if (conDataNode.DataNodeName  ==  _AttributeName[intIndex])
{
mstrDataNodeName = value.ToString();
 AddUpdatedFld(conDataNode.DataNodeName);
}
else if (conDataNode.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(conDataNode.TabId);
}
else if (conDataNode.FldId  ==  _AttributeName[intIndex])
{
mstrFldId = value.ToString();
 AddUpdatedFld(conDataNode.FldId);
}
else if (conDataNode.KeyFldLst  ==  _AttributeName[intIndex])
{
mstrKeyFldLst = value.ToString();
 AddUpdatedFld(conDataNode.KeyFldLst);
}
else if (conDataNode.VersionNo  ==  _AttributeName[intIndex])
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(conDataNode.VersionNo);
}
else if (conDataNode.DataNodeTypeId  ==  _AttributeName[intIndex])
{
mstrDataNodeTypeId = value.ToString();
 AddUpdatedFld(conDataNode.DataNodeTypeId);
}
else if (conDataNode.Depth  ==  _AttributeName[intIndex])
{
mintDepth = TransNullToInt(value.ToString());
 AddUpdatedFld(conDataNode.Depth);
}
else if (conDataNode.PrevDataNodeId  ==  _AttributeName[intIndex])
{
mlngPrevDataNodeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conDataNode.PrevDataNodeId);
}
else if (conDataNode.NextDataNodeId  ==  _AttributeName[intIndex])
{
mlngNextDataNodeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conDataNode.NextDataNodeId);
}
else if (conDataNode.SubGraphName  ==  _AttributeName[intIndex])
{
mstrSubGraphName = value.ToString();
 AddUpdatedFld(conDataNode.SubGraphName);
}
else if (conDataNode.ErrMsg  ==  _AttributeName[intIndex])
{
mstrErrMsg = value.ToString();
 AddUpdatedFld(conDataNode.ErrMsg);
}
else if (conDataNode.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conDataNode.PrjId);
}
else if (conDataNode.PosX  ==  _AttributeName[intIndex])
{
mdblPosX = TransNullToDouble(value.ToString());
 AddUpdatedFld(conDataNode.PosX);
}
else if (conDataNode.PosY  ==  _AttributeName[intIndex])
{
mdblPosY = TransNullToDouble(value.ToString());
 AddUpdatedFld(conDataNode.PosY);
}
else if (conDataNode.UsedTimes  ==  _AttributeName[intIndex])
{
mintUsedTimes = TransNullToInt(value.ToString());
 AddUpdatedFld(conDataNode.UsedTimes);
}
else if (conDataNode.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conDataNode.UpdDate);
}
else if (conDataNode.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conDataNode.UpdUser);
}
else if (conDataNode.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDataNode.Memo);
}
}
}

/// <summary>
/// 数据结点Id(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long DataNodeId
{
get
{
return mlngDataNodeId;
}
set
{
 mlngDataNodeId = value;
//记录修改过的字段
 AddUpdatedFld(conDataNode.DataNodeId);
}
}
/// <summary>
/// 数据结点名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataNodeName
{
get
{
return mstrDataNodeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataNodeName = value;
}
else
{
 mstrDataNodeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conDataNode.DataNodeName);
}
}
/// <summary>
/// 表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabId
{
get
{
return mstrTabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabId = value;
}
else
{
 mstrTabId = value;
}
//记录修改过的字段
 AddUpdatedFld(conDataNode.TabId);
}
}
/// <summary>
/// 字段Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FldId
{
get
{
return mstrFldId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldId = value;
}
else
{
 mstrFldId = value;
}
//记录修改过的字段
 AddUpdatedFld(conDataNode.FldId);
}
}
/// <summary>
/// 关键字段Id列表(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KeyFldLst
{
get
{
return mstrKeyFldLst;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeyFldLst = value;
}
else
{
 mstrKeyFldLst = value;
}
//记录修改过的字段
 AddUpdatedFld(conDataNode.KeyFldLst);
}
}
/// <summary>
/// 版本号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int VersionNo
{
get
{
return mintVersionNo;
}
set
{
 mintVersionNo = value;
//记录修改过的字段
 AddUpdatedFld(conDataNode.VersionNo);
}
}
/// <summary>
/// 数据结点类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataNodeTypeId
{
get
{
return mstrDataNodeTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataNodeTypeId = value;
}
else
{
 mstrDataNodeTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conDataNode.DataNodeTypeId);
}
}
/// <summary>
/// 深度(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? Depth
{
get
{
return mintDepth;
}
set
{
 mintDepth = value;
//记录修改过的字段
 AddUpdatedFld(conDataNode.Depth);
}
}
/// <summary>
/// 前置数据结点Id(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long? PrevDataNodeId
{
get
{
return mlngPrevDataNodeId;
}
set
{
 mlngPrevDataNodeId = value;
//记录修改过的字段
 AddUpdatedFld(conDataNode.PrevDataNodeId);
}
}
/// <summary>
/// 后继数据结点Id(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long? NextDataNodeId
{
get
{
return mlngNextDataNodeId;
}
set
{
 mlngNextDataNodeId = value;
//记录修改过的字段
 AddUpdatedFld(conDataNode.NextDataNodeId);
}
}
/// <summary>
/// 子图名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SubGraphName
{
get
{
return mstrSubGraphName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSubGraphName = value;
}
else
{
 mstrSubGraphName = value;
}
//记录修改过的字段
 AddUpdatedFld(conDataNode.SubGraphName);
}
}
/// <summary>
/// 错误信息(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ErrMsg
{
get
{
return mstrErrMsg;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrErrMsg = value;
}
else
{
 mstrErrMsg = value;
}
//记录修改过的字段
 AddUpdatedFld(conDataNode.ErrMsg);
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
 AddUpdatedFld(conDataNode.PrjId);
}
}
/// <summary>
/// 位置X(说明:;字段类型:decimal;字段长度:7;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double? PosX
{
get
{
return mdblPosX;
}
set
{
 mdblPosX = value;
//记录修改过的字段
 AddUpdatedFld(conDataNode.PosX);
}
}
/// <summary>
/// 位置Y(说明:;字段类型:decimal;字段长度:7;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double? PosY
{
get
{
return mdblPosY;
}
set
{
 mdblPosY = value;
//记录修改过的字段
 AddUpdatedFld(conDataNode.PosY);
}
}
/// <summary>
/// 使用次数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? UsedTimes
{
get
{
return mintUsedTimes;
}
set
{
 mintUsedTimes = value;
//记录修改过的字段
 AddUpdatedFld(conDataNode.UsedTimes);
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
 AddUpdatedFld(conDataNode.UpdDate);
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
 AddUpdatedFld(conDataNode.UpdUser);
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
 AddUpdatedFld(conDataNode.Memo);
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
  return mlngDataNodeId.ToString();
 }
 }

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrDataNodeName;
 }
 }
}
 /// <summary>
 /// 数据结点(DataNode)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conDataNode
{
public const string _CurrTabName = "DataNode"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "DataNodeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"DataNodeId", "DataNodeName", "TabId", "FldId", "KeyFldLst", "VersionNo", "DataNodeTypeId", "Depth", "PrevDataNodeId", "NextDataNodeId", "SubGraphName", "ErrMsg", "PrjId", "PosX", "PosY", "UsedTimes", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"DataNodeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataNodeId = "DataNodeId";    //数据结点Id

 /// <summary>
 /// 常量:"DataNodeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataNodeName = "DataNodeName";    //数据结点名

 /// <summary>
 /// 常量:"TabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabId = "TabId";    //表ID

 /// <summary>
 /// 常量:"FldId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldId = "FldId";    //字段Id

 /// <summary>
 /// 常量:"KeyFldLst"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KeyFldLst = "KeyFldLst";    //关键字段Id列表

 /// <summary>
 /// 常量:"VersionNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VersionNo = "VersionNo";    //版本号

 /// <summary>
 /// 常量:"DataNodeTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataNodeTypeId = "DataNodeTypeId";    //数据结点类型Id

 /// <summary>
 /// 常量:"Depth"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Depth = "Depth";    //深度

 /// <summary>
 /// 常量:"PrevDataNodeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrevDataNodeId = "PrevDataNodeId";    //前置数据结点Id

 /// <summary>
 /// 常量:"NextDataNodeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string NextDataNodeId = "NextDataNodeId";    //后继数据结点Id

 /// <summary>
 /// 常量:"SubGraphName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SubGraphName = "SubGraphName";    //子图名

 /// <summary>
 /// 常量:"ErrMsg"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ErrMsg = "ErrMsg";    //错误信息

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"PosX"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PosX = "PosX";    //位置X

 /// <summary>
 /// 常量:"PosY"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PosY = "PosY";    //位置Y

 /// <summary>
 /// 常量:"UsedTimes"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UsedTimes = "UsedTimes";    //使用次数

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