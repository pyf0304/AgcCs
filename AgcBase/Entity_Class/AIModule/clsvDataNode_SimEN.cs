
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvDataNode_SimEN
 表名:vDataNode_Sim(00050592)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:26:50
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
 /// 表vDataNode_Sim的关键字(DataNodeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_DataNodeId_vDataNode_Sim
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
public K_DataNodeId_vDataNode_Sim(long lngDataNodeId)
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
 /// <returns>返回:[K_DataNodeId_vDataNode_Sim]类型的对象</returns>
public static implicit operator K_DataNodeId_vDataNode_Sim(long value)
{
return new K_DataNodeId_vDataNode_Sim(value);
}
}
 /// <summary>
 /// vDataNode_Sim(vDataNode_Sim)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvDataNode_SimEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vDataNode_Sim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "DataNodeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = "UsedTimes>0 and PrjId='{0}'"; //前台条件格式串
protected const int _AttributeCount = 11;
public static string[] _AttributeName = new string[] {"DataNodeId", "DataNodeName", "TabId", "FldId", "KeyFldLst", "DataNodeTypeId", "VersionNo", "PrjId", "PosX", "PosY", "UsedTimes"};

protected long mlngDataNodeId;    //数据结点Id
protected string mstrDataNodeName;    //数据结点名
protected string mstrTabId;    //表ID
protected string mstrFldId;    //字段Id
protected string mstrKeyFldLst;    //关键字段Id列表
protected string mstrDataNodeTypeId;    //数据结点类型Id
protected int? mintVersionNo;    //版本号
protected string mstrPrjId;    //工程Id
protected double? mdblPosX;    //位置X
protected double? mdblPosY;    //位置Y
protected int? mintUsedTimes;    //使用次数

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvDataNode_SimEN()
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
public clsvDataNode_SimEN(long lngDataNodeId)
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
if (strAttributeName  ==  convDataNode_Sim.DataNodeId)
{
return mlngDataNodeId;
}
else if (strAttributeName  ==  convDataNode_Sim.DataNodeName)
{
return mstrDataNodeName;
}
else if (strAttributeName  ==  convDataNode_Sim.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  convDataNode_Sim.FldId)
{
return mstrFldId;
}
else if (strAttributeName  ==  convDataNode_Sim.KeyFldLst)
{
return mstrKeyFldLst;
}
else if (strAttributeName  ==  convDataNode_Sim.DataNodeTypeId)
{
return mstrDataNodeTypeId;
}
else if (strAttributeName  ==  convDataNode_Sim.VersionNo)
{
return mintVersionNo;
}
else if (strAttributeName  ==  convDataNode_Sim.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convDataNode_Sim.PosX)
{
return mdblPosX;
}
else if (strAttributeName  ==  convDataNode_Sim.PosY)
{
return mdblPosY;
}
else if (strAttributeName  ==  convDataNode_Sim.UsedTimes)
{
return mintUsedTimes;
}
return null;
}
set
{
if (strAttributeName  ==  convDataNode_Sim.DataNodeId)
{
mlngDataNodeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convDataNode_Sim.DataNodeId);
}
else if (strAttributeName  ==  convDataNode_Sim.DataNodeName)
{
mstrDataNodeName = value.ToString();
 AddUpdatedFld(convDataNode_Sim.DataNodeName);
}
else if (strAttributeName  ==  convDataNode_Sim.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(convDataNode_Sim.TabId);
}
else if (strAttributeName  ==  convDataNode_Sim.FldId)
{
mstrFldId = value.ToString();
 AddUpdatedFld(convDataNode_Sim.FldId);
}
else if (strAttributeName  ==  convDataNode_Sim.KeyFldLst)
{
mstrKeyFldLst = value.ToString();
 AddUpdatedFld(convDataNode_Sim.KeyFldLst);
}
else if (strAttributeName  ==  convDataNode_Sim.DataNodeTypeId)
{
mstrDataNodeTypeId = value.ToString();
 AddUpdatedFld(convDataNode_Sim.DataNodeTypeId);
}
else if (strAttributeName  ==  convDataNode_Sim.VersionNo)
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convDataNode_Sim.VersionNo);
}
else if (strAttributeName  ==  convDataNode_Sim.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convDataNode_Sim.PrjId);
}
else if (strAttributeName  ==  convDataNode_Sim.PosX)
{
mdblPosX = TransNullToDouble(value.ToString());
 AddUpdatedFld(convDataNode_Sim.PosX);
}
else if (strAttributeName  ==  convDataNode_Sim.PosY)
{
mdblPosY = TransNullToDouble(value.ToString());
 AddUpdatedFld(convDataNode_Sim.PosY);
}
else if (strAttributeName  ==  convDataNode_Sim.UsedTimes)
{
mintUsedTimes = TransNullToInt(value.ToString());
 AddUpdatedFld(convDataNode_Sim.UsedTimes);
}
}
}
public object this[int intIndex]
{
get
{
if (convDataNode_Sim.DataNodeId  ==  _AttributeName[intIndex])
{
return mlngDataNodeId;
}
else if (convDataNode_Sim.DataNodeName  ==  _AttributeName[intIndex])
{
return mstrDataNodeName;
}
else if (convDataNode_Sim.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (convDataNode_Sim.FldId  ==  _AttributeName[intIndex])
{
return mstrFldId;
}
else if (convDataNode_Sim.KeyFldLst  ==  _AttributeName[intIndex])
{
return mstrKeyFldLst;
}
else if (convDataNode_Sim.DataNodeTypeId  ==  _AttributeName[intIndex])
{
return mstrDataNodeTypeId;
}
else if (convDataNode_Sim.VersionNo  ==  _AttributeName[intIndex])
{
return mintVersionNo;
}
else if (convDataNode_Sim.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convDataNode_Sim.PosX  ==  _AttributeName[intIndex])
{
return mdblPosX;
}
else if (convDataNode_Sim.PosY  ==  _AttributeName[intIndex])
{
return mdblPosY;
}
else if (convDataNode_Sim.UsedTimes  ==  _AttributeName[intIndex])
{
return mintUsedTimes;
}
return null;
}
set
{
if (convDataNode_Sim.DataNodeId  ==  _AttributeName[intIndex])
{
mlngDataNodeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convDataNode_Sim.DataNodeId);
}
else if (convDataNode_Sim.DataNodeName  ==  _AttributeName[intIndex])
{
mstrDataNodeName = value.ToString();
 AddUpdatedFld(convDataNode_Sim.DataNodeName);
}
else if (convDataNode_Sim.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(convDataNode_Sim.TabId);
}
else if (convDataNode_Sim.FldId  ==  _AttributeName[intIndex])
{
mstrFldId = value.ToString();
 AddUpdatedFld(convDataNode_Sim.FldId);
}
else if (convDataNode_Sim.KeyFldLst  ==  _AttributeName[intIndex])
{
mstrKeyFldLst = value.ToString();
 AddUpdatedFld(convDataNode_Sim.KeyFldLst);
}
else if (convDataNode_Sim.DataNodeTypeId  ==  _AttributeName[intIndex])
{
mstrDataNodeTypeId = value.ToString();
 AddUpdatedFld(convDataNode_Sim.DataNodeTypeId);
}
else if (convDataNode_Sim.VersionNo  ==  _AttributeName[intIndex])
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convDataNode_Sim.VersionNo);
}
else if (convDataNode_Sim.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convDataNode_Sim.PrjId);
}
else if (convDataNode_Sim.PosX  ==  _AttributeName[intIndex])
{
mdblPosX = TransNullToDouble(value.ToString());
 AddUpdatedFld(convDataNode_Sim.PosX);
}
else if (convDataNode_Sim.PosY  ==  _AttributeName[intIndex])
{
mdblPosY = TransNullToDouble(value.ToString());
 AddUpdatedFld(convDataNode_Sim.PosY);
}
else if (convDataNode_Sim.UsedTimes  ==  _AttributeName[intIndex])
{
mintUsedTimes = TransNullToInt(value.ToString());
 AddUpdatedFld(convDataNode_Sim.UsedTimes);
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
 AddUpdatedFld(convDataNode_Sim.DataNodeId);
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
 AddUpdatedFld(convDataNode_Sim.DataNodeName);
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
 AddUpdatedFld(convDataNode_Sim.TabId);
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
 AddUpdatedFld(convDataNode_Sim.FldId);
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
 AddUpdatedFld(convDataNode_Sim.KeyFldLst);
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
 AddUpdatedFld(convDataNode_Sim.DataNodeTypeId);
}
}
/// <summary>
/// 版本号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? VersionNo
{
get
{
return mintVersionNo;
}
set
{
 mintVersionNo = value;
//记录修改过的字段
 AddUpdatedFld(convDataNode_Sim.VersionNo);
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
 AddUpdatedFld(convDataNode_Sim.PrjId);
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
 AddUpdatedFld(convDataNode_Sim.PosX);
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
 AddUpdatedFld(convDataNode_Sim.PosY);
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
 AddUpdatedFld(convDataNode_Sim.UsedTimes);
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
 /// vDataNode_Sim(vDataNode_Sim)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convDataNode_Sim
{
public const string _CurrTabName = "vDataNode_Sim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "DataNodeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"DataNodeId", "DataNodeName", "TabId", "FldId", "KeyFldLst", "DataNodeTypeId", "VersionNo", "PrjId", "PosX", "PosY", "UsedTimes"};
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
 /// 常量:"DataNodeTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataNodeTypeId = "DataNodeTypeId";    //数据结点类型Id

 /// <summary>
 /// 常量:"VersionNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VersionNo = "VersionNo";    //版本号

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
}

}