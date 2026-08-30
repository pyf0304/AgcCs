
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUiFileRelationEdgeEN
 表名:UiFileRelationEdge(00050652)
 * 版本:2026.07.20(服务器:WIN-SRV103-116)
 日期:2026/07/21 01:50:34
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:界面管理(PrjInterface)
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
 /// 表UiFileRelationEdge的关键字(EdgeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_EdgeId_UiFileRelationEdge
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngEdgeId">表关键字</param>
public K_EdgeId_UiFileRelationEdge(long lngEdgeId)
{
if (IsValid(lngEdgeId)) Value = lngEdgeId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngEdgeId)
{
if (lngEdgeId == 0) return false;
if (lngEdgeId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_EdgeId_UiFileRelationEdge]类型的对象</returns>
public static implicit operator K_EdgeId_UiFileRelationEdge(long value)
{
return new K_EdgeId_UiFileRelationEdge(value);
}
}
 /// <summary>
 /// UiFileRelationEdge(UiFileRelationEdge)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsUiFileRelationEdgeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "UiFileRelationEdge"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "EdgeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 9;
public static string[] _AttributeName = new string[] {"EdgeId", "TaskId", "FromNodeId", "ToNodeId", "EdgeType", "Depth", "RelationText", "IsRecursive", "ExtraJson"};

protected long mlngEdgeId;    //EdgeId
protected long mlngTaskId;    //TaskId
protected long mlngFromNodeId;    //FromNodeId
protected long mlngToNodeId;    //ToNodeId
protected string mstrEdgeType;    //EdgeType
protected int? mintDepth;    //深度
protected string mstrRelationText;    //RelationText
protected bool mbolIsRecursive;    //IsRecursive
protected string mstrExtraJson;    //ExtraJson

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsUiFileRelationEdgeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("EdgeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "lngEdgeId">关键字:EdgeId</param>
public clsUiFileRelationEdgeEN(long lngEdgeId)
 {
 if (lngEdgeId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngEdgeId = lngEdgeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("EdgeId");
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
if (strAttributeName  ==  conUiFileRelationEdge.EdgeId)
{
return mlngEdgeId;
}
else if (strAttributeName  ==  conUiFileRelationEdge.TaskId)
{
return mlngTaskId;
}
else if (strAttributeName  ==  conUiFileRelationEdge.FromNodeId)
{
return mlngFromNodeId;
}
else if (strAttributeName  ==  conUiFileRelationEdge.ToNodeId)
{
return mlngToNodeId;
}
else if (strAttributeName  ==  conUiFileRelationEdge.EdgeType)
{
return mstrEdgeType;
}
else if (strAttributeName  ==  conUiFileRelationEdge.Depth)
{
return mintDepth;
}
else if (strAttributeName  ==  conUiFileRelationEdge.RelationText)
{
return mstrRelationText;
}
else if (strAttributeName  ==  conUiFileRelationEdge.IsRecursive)
{
return mbolIsRecursive;
}
else if (strAttributeName  ==  conUiFileRelationEdge.ExtraJson)
{
return mstrExtraJson;
}
return null;
}
set
{
if (strAttributeName  ==  conUiFileRelationEdge.EdgeId)
{
mlngEdgeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUiFileRelationEdge.EdgeId);
}
else if (strAttributeName  ==  conUiFileRelationEdge.TaskId)
{
mlngTaskId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUiFileRelationEdge.TaskId);
}
else if (strAttributeName  ==  conUiFileRelationEdge.FromNodeId)
{
mlngFromNodeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUiFileRelationEdge.FromNodeId);
}
else if (strAttributeName  ==  conUiFileRelationEdge.ToNodeId)
{
mlngToNodeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUiFileRelationEdge.ToNodeId);
}
else if (strAttributeName  ==  conUiFileRelationEdge.EdgeType)
{
mstrEdgeType = value.ToString();
 AddUpdatedFld(conUiFileRelationEdge.EdgeType);
}
else if (strAttributeName  ==  conUiFileRelationEdge.Depth)
{
mintDepth = TransNullToInt(value.ToString());
 AddUpdatedFld(conUiFileRelationEdge.Depth);
}
else if (strAttributeName  ==  conUiFileRelationEdge.RelationText)
{
mstrRelationText = value.ToString();
 AddUpdatedFld(conUiFileRelationEdge.RelationText);
}
else if (strAttributeName  ==  conUiFileRelationEdge.IsRecursive)
{
mbolIsRecursive = TransNullToBool(value.ToString());
 AddUpdatedFld(conUiFileRelationEdge.IsRecursive);
}
else if (strAttributeName  ==  conUiFileRelationEdge.ExtraJson)
{
mstrExtraJson = value.ToString();
 AddUpdatedFld(conUiFileRelationEdge.ExtraJson);
}
}
}
public object this[int intIndex]
{
get
{
if (conUiFileRelationEdge.EdgeId  ==  _AttributeName[intIndex])
{
return mlngEdgeId;
}
else if (conUiFileRelationEdge.TaskId  ==  _AttributeName[intIndex])
{
return mlngTaskId;
}
else if (conUiFileRelationEdge.FromNodeId  ==  _AttributeName[intIndex])
{
return mlngFromNodeId;
}
else if (conUiFileRelationEdge.ToNodeId  ==  _AttributeName[intIndex])
{
return mlngToNodeId;
}
else if (conUiFileRelationEdge.EdgeType  ==  _AttributeName[intIndex])
{
return mstrEdgeType;
}
else if (conUiFileRelationEdge.Depth  ==  _AttributeName[intIndex])
{
return mintDepth;
}
else if (conUiFileRelationEdge.RelationText  ==  _AttributeName[intIndex])
{
return mstrRelationText;
}
else if (conUiFileRelationEdge.IsRecursive  ==  _AttributeName[intIndex])
{
return mbolIsRecursive;
}
else if (conUiFileRelationEdge.ExtraJson  ==  _AttributeName[intIndex])
{
return mstrExtraJson;
}
return null;
}
set
{
if (conUiFileRelationEdge.EdgeId  ==  _AttributeName[intIndex])
{
mlngEdgeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUiFileRelationEdge.EdgeId);
}
else if (conUiFileRelationEdge.TaskId  ==  _AttributeName[intIndex])
{
mlngTaskId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUiFileRelationEdge.TaskId);
}
else if (conUiFileRelationEdge.FromNodeId  ==  _AttributeName[intIndex])
{
mlngFromNodeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUiFileRelationEdge.FromNodeId);
}
else if (conUiFileRelationEdge.ToNodeId  ==  _AttributeName[intIndex])
{
mlngToNodeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUiFileRelationEdge.ToNodeId);
}
else if (conUiFileRelationEdge.EdgeType  ==  _AttributeName[intIndex])
{
mstrEdgeType = value.ToString();
 AddUpdatedFld(conUiFileRelationEdge.EdgeType);
}
else if (conUiFileRelationEdge.Depth  ==  _AttributeName[intIndex])
{
mintDepth = TransNullToInt(value.ToString());
 AddUpdatedFld(conUiFileRelationEdge.Depth);
}
else if (conUiFileRelationEdge.RelationText  ==  _AttributeName[intIndex])
{
mstrRelationText = value.ToString();
 AddUpdatedFld(conUiFileRelationEdge.RelationText);
}
else if (conUiFileRelationEdge.IsRecursive  ==  _AttributeName[intIndex])
{
mbolIsRecursive = TransNullToBool(value.ToString());
 AddUpdatedFld(conUiFileRelationEdge.IsRecursive);
}
else if (conUiFileRelationEdge.ExtraJson  ==  _AttributeName[intIndex])
{
mstrExtraJson = value.ToString();
 AddUpdatedFld(conUiFileRelationEdge.ExtraJson);
}
}
}

/// <summary>
/// EdgeId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long EdgeId
{
get
{
return mlngEdgeId;
}
set
{
 mlngEdgeId = value;
//记录修改过的字段
 AddUpdatedFld(conUiFileRelationEdge.EdgeId);
}
}
/// <summary>
/// TaskId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long TaskId
{
get
{
return mlngTaskId;
}
set
{
 mlngTaskId = value;
//记录修改过的字段
 AddUpdatedFld(conUiFileRelationEdge.TaskId);
}
}
/// <summary>
/// FromNodeId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long FromNodeId
{
get
{
return mlngFromNodeId;
}
set
{
 mlngFromNodeId = value;
//记录修改过的字段
 AddUpdatedFld(conUiFileRelationEdge.FromNodeId);
}
}
/// <summary>
/// ToNodeId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long ToNodeId
{
get
{
return mlngToNodeId;
}
set
{
 mlngToNodeId = value;
//记录修改过的字段
 AddUpdatedFld(conUiFileRelationEdge.ToNodeId);
}
}
/// <summary>
/// EdgeType(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EdgeType
{
get
{
return mstrEdgeType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEdgeType = value;
}
else
{
 mstrEdgeType = value;
}
//记录修改过的字段
 AddUpdatedFld(conUiFileRelationEdge.EdgeType);
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
 AddUpdatedFld(conUiFileRelationEdge.Depth);
}
}
/// <summary>
/// RelationText(说明:;字段类型:nvarchar;字段长度:400;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RelationText
{
get
{
return mstrRelationText;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRelationText = value;
}
else
{
 mstrRelationText = value;
}
//记录修改过的字段
 AddUpdatedFld(conUiFileRelationEdge.RelationText);
}
}
/// <summary>
/// IsRecursive(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsRecursive
{
get
{
return mbolIsRecursive;
}
set
{
 mbolIsRecursive = value;
//记录修改过的字段
 AddUpdatedFld(conUiFileRelationEdge.IsRecursive);
}
}
/// <summary>
/// ExtraJson(说明:;字段类型:ntext;字段长度:2147483646;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExtraJson
{
get
{
return mstrExtraJson;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExtraJson = value;
}
else
{
 mstrExtraJson = value;
}
//记录修改过的字段
 AddUpdatedFld(conUiFileRelationEdge.ExtraJson);
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
  return mlngEdgeId.ToString();
 }
 }
}
 /// <summary>
 /// UiFileRelationEdge(UiFileRelationEdge)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conUiFileRelationEdge
{
public const string _CurrTabName = "UiFileRelationEdge"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "EdgeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"EdgeId", "TaskId", "FromNodeId", "ToNodeId", "EdgeType", "Depth", "RelationText", "IsRecursive", "ExtraJson"};
//以下是属性变量


 /// <summary>
 /// 常量:"EdgeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EdgeId = "EdgeId";    //EdgeId

 /// <summary>
 /// 常量:"TaskId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TaskId = "TaskId";    //TaskId

 /// <summary>
 /// 常量:"FromNodeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FromNodeId = "FromNodeId";    //FromNodeId

 /// <summary>
 /// 常量:"ToNodeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ToNodeId = "ToNodeId";    //ToNodeId

 /// <summary>
 /// 常量:"EdgeType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EdgeType = "EdgeType";    //EdgeType

 /// <summary>
 /// 常量:"Depth"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Depth = "Depth";    //深度

 /// <summary>
 /// 常量:"RelationText"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RelationText = "RelationText";    //RelationText

 /// <summary>
 /// 常量:"IsRecursive"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsRecursive = "IsRecursive";    //IsRecursive

 /// <summary>
 /// 常量:"ExtraJson"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExtraJson = "ExtraJson";    //ExtraJson
}

}