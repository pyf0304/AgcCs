
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUiFileRelationNodeEN
 表名:UiFileRelationNode(00050654)
 * 版本:2026.07.20(服务器:WIN-SRV103-116)
 日期:2026/07/21 01:50:18
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
 /// 表UiFileRelationNode的关键字(NodeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_NodeId_UiFileRelationNode
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngNodeId">表关键字</param>
public K_NodeId_UiFileRelationNode(long lngNodeId)
{
if (IsValid(lngNodeId)) Value = lngNodeId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngNodeId)
{
if (lngNodeId == 0) return false;
if (lngNodeId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_NodeId_UiFileRelationNode]类型的对象</returns>
public static implicit operator K_NodeId_UiFileRelationNode(long value)
{
return new K_NodeId_UiFileRelationNode(value);
}
}
 /// <summary>
 /// UiFileRelationNode(UiFileRelationNode)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsUiFileRelationNodeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "UiFileRelationNode"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "NodeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 13;
public static string[] _AttributeName = new string[] {"NodeId", "TaskId", "FileId", "NodeType", "SymbolName", "SymbolKey", "SourcePath", "LineNo", "ColumnNo", "LevelNo", "ParentNodeId", "ExtraJson", "CreatedAt"};

protected long mlngNodeId;    //NodeId
protected long mlngTaskId;    //TaskId
protected long? mlngFileId;    //FileId
protected string mstrNodeType;    //NodeType
protected string mstrSymbolName;    //SymbolName
protected string mstrSymbolKey;    //SymbolKey
protected string mstrSourcePath;    //SourcePath
protected int? mintLineNo;    //LineNo
protected int? mintColumnNo;    //ColumnNo
protected int mintLevelNo;    //层序号
protected long? mlngParentNodeId;    //ParentNodeId
protected string mstrExtraJson;    //ExtraJson
protected DateTime mdteCreatedAt;    //CreatedAt

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsUiFileRelationNodeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("NodeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "lngNodeId">关键字:NodeId</param>
public clsUiFileRelationNodeEN(long lngNodeId)
 {
 if (lngNodeId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngNodeId = lngNodeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("NodeId");
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
if (strAttributeName  ==  conUiFileRelationNode.NodeId)
{
return mlngNodeId;
}
else if (strAttributeName  ==  conUiFileRelationNode.TaskId)
{
return mlngTaskId;
}
else if (strAttributeName  ==  conUiFileRelationNode.FileId)
{
return mlngFileId;
}
else if (strAttributeName  ==  conUiFileRelationNode.NodeType)
{
return mstrNodeType;
}
else if (strAttributeName  ==  conUiFileRelationNode.SymbolName)
{
return mstrSymbolName;
}
else if (strAttributeName  ==  conUiFileRelationNode.SymbolKey)
{
return mstrSymbolKey;
}
else if (strAttributeName  ==  conUiFileRelationNode.SourcePath)
{
return mstrSourcePath;
}
else if (strAttributeName  ==  conUiFileRelationNode.LineNo)
{
return mintLineNo;
}
else if (strAttributeName  ==  conUiFileRelationNode.ColumnNo)
{
return mintColumnNo;
}
else if (strAttributeName  ==  conUiFileRelationNode.LevelNo)
{
return mintLevelNo;
}
else if (strAttributeName  ==  conUiFileRelationNode.ParentNodeId)
{
return mlngParentNodeId;
}
else if (strAttributeName  ==  conUiFileRelationNode.ExtraJson)
{
return mstrExtraJson;
}
else if (strAttributeName  ==  conUiFileRelationNode.CreatedAt)
{
return mdteCreatedAt;
}
return null;
}
set
{
if (strAttributeName  ==  conUiFileRelationNode.NodeId)
{
mlngNodeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUiFileRelationNode.NodeId);
}
else if (strAttributeName  ==  conUiFileRelationNode.TaskId)
{
mlngTaskId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUiFileRelationNode.TaskId);
}
else if (strAttributeName  ==  conUiFileRelationNode.FileId)
{
mlngFileId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUiFileRelationNode.FileId);
}
else if (strAttributeName  ==  conUiFileRelationNode.NodeType)
{
mstrNodeType = value.ToString();
 AddUpdatedFld(conUiFileRelationNode.NodeType);
}
else if (strAttributeName  ==  conUiFileRelationNode.SymbolName)
{
mstrSymbolName = value.ToString();
 AddUpdatedFld(conUiFileRelationNode.SymbolName);
}
else if (strAttributeName  ==  conUiFileRelationNode.SymbolKey)
{
mstrSymbolKey = value.ToString();
 AddUpdatedFld(conUiFileRelationNode.SymbolKey);
}
else if (strAttributeName  ==  conUiFileRelationNode.SourcePath)
{
mstrSourcePath = value.ToString();
 AddUpdatedFld(conUiFileRelationNode.SourcePath);
}
else if (strAttributeName  ==  conUiFileRelationNode.LineNo)
{
mintLineNo = TransNullToInt(value.ToString());
 AddUpdatedFld(conUiFileRelationNode.LineNo);
}
else if (strAttributeName  ==  conUiFileRelationNode.ColumnNo)
{
mintColumnNo = TransNullToInt(value.ToString());
 AddUpdatedFld(conUiFileRelationNode.ColumnNo);
}
else if (strAttributeName  ==  conUiFileRelationNode.LevelNo)
{
mintLevelNo = TransNullToInt(value.ToString());
 AddUpdatedFld(conUiFileRelationNode.LevelNo);
}
else if (strAttributeName  ==  conUiFileRelationNode.ParentNodeId)
{
mlngParentNodeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUiFileRelationNode.ParentNodeId);
}
else if (strAttributeName  ==  conUiFileRelationNode.ExtraJson)
{
mstrExtraJson = value.ToString();
 AddUpdatedFld(conUiFileRelationNode.ExtraJson);
}
else if (strAttributeName  ==  conUiFileRelationNode.CreatedAt)
{
mdteCreatedAt = TransNullToDate(value.ToString());
 AddUpdatedFld(conUiFileRelationNode.CreatedAt);
}
}
}
public object this[int intIndex]
{
get
{
if (conUiFileRelationNode.NodeId  ==  _AttributeName[intIndex])
{
return mlngNodeId;
}
else if (conUiFileRelationNode.TaskId  ==  _AttributeName[intIndex])
{
return mlngTaskId;
}
else if (conUiFileRelationNode.FileId  ==  _AttributeName[intIndex])
{
return mlngFileId;
}
else if (conUiFileRelationNode.NodeType  ==  _AttributeName[intIndex])
{
return mstrNodeType;
}
else if (conUiFileRelationNode.SymbolName  ==  _AttributeName[intIndex])
{
return mstrSymbolName;
}
else if (conUiFileRelationNode.SymbolKey  ==  _AttributeName[intIndex])
{
return mstrSymbolKey;
}
else if (conUiFileRelationNode.SourcePath  ==  _AttributeName[intIndex])
{
return mstrSourcePath;
}
else if (conUiFileRelationNode.LineNo  ==  _AttributeName[intIndex])
{
return mintLineNo;
}
else if (conUiFileRelationNode.ColumnNo  ==  _AttributeName[intIndex])
{
return mintColumnNo;
}
else if (conUiFileRelationNode.LevelNo  ==  _AttributeName[intIndex])
{
return mintLevelNo;
}
else if (conUiFileRelationNode.ParentNodeId  ==  _AttributeName[intIndex])
{
return mlngParentNodeId;
}
else if (conUiFileRelationNode.ExtraJson  ==  _AttributeName[intIndex])
{
return mstrExtraJson;
}
else if (conUiFileRelationNode.CreatedAt  ==  _AttributeName[intIndex])
{
return mdteCreatedAt;
}
return null;
}
set
{
if (conUiFileRelationNode.NodeId  ==  _AttributeName[intIndex])
{
mlngNodeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUiFileRelationNode.NodeId);
}
else if (conUiFileRelationNode.TaskId  ==  _AttributeName[intIndex])
{
mlngTaskId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUiFileRelationNode.TaskId);
}
else if (conUiFileRelationNode.FileId  ==  _AttributeName[intIndex])
{
mlngFileId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUiFileRelationNode.FileId);
}
else if (conUiFileRelationNode.NodeType  ==  _AttributeName[intIndex])
{
mstrNodeType = value.ToString();
 AddUpdatedFld(conUiFileRelationNode.NodeType);
}
else if (conUiFileRelationNode.SymbolName  ==  _AttributeName[intIndex])
{
mstrSymbolName = value.ToString();
 AddUpdatedFld(conUiFileRelationNode.SymbolName);
}
else if (conUiFileRelationNode.SymbolKey  ==  _AttributeName[intIndex])
{
mstrSymbolKey = value.ToString();
 AddUpdatedFld(conUiFileRelationNode.SymbolKey);
}
else if (conUiFileRelationNode.SourcePath  ==  _AttributeName[intIndex])
{
mstrSourcePath = value.ToString();
 AddUpdatedFld(conUiFileRelationNode.SourcePath);
}
else if (conUiFileRelationNode.LineNo  ==  _AttributeName[intIndex])
{
mintLineNo = TransNullToInt(value.ToString());
 AddUpdatedFld(conUiFileRelationNode.LineNo);
}
else if (conUiFileRelationNode.ColumnNo  ==  _AttributeName[intIndex])
{
mintColumnNo = TransNullToInt(value.ToString());
 AddUpdatedFld(conUiFileRelationNode.ColumnNo);
}
else if (conUiFileRelationNode.LevelNo  ==  _AttributeName[intIndex])
{
mintLevelNo = TransNullToInt(value.ToString());
 AddUpdatedFld(conUiFileRelationNode.LevelNo);
}
else if (conUiFileRelationNode.ParentNodeId  ==  _AttributeName[intIndex])
{
mlngParentNodeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUiFileRelationNode.ParentNodeId);
}
else if (conUiFileRelationNode.ExtraJson  ==  _AttributeName[intIndex])
{
mstrExtraJson = value.ToString();
 AddUpdatedFld(conUiFileRelationNode.ExtraJson);
}
else if (conUiFileRelationNode.CreatedAt  ==  _AttributeName[intIndex])
{
mdteCreatedAt = TransNullToDate(value.ToString());
 AddUpdatedFld(conUiFileRelationNode.CreatedAt);
}
}
}

/// <summary>
/// NodeId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long NodeId
{
get
{
return mlngNodeId;
}
set
{
 mlngNodeId = value;
//记录修改过的字段
 AddUpdatedFld(conUiFileRelationNode.NodeId);
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
 AddUpdatedFld(conUiFileRelationNode.TaskId);
}
}
/// <summary>
/// FileId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long? FileId
{
get
{
return mlngFileId;
}
set
{
 mlngFileId = value;
//记录修改过的字段
 AddUpdatedFld(conUiFileRelationNode.FileId);
}
}
/// <summary>
/// NodeType(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string NodeType
{
get
{
return mstrNodeType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrNodeType = value;
}
else
{
 mstrNodeType = value;
}
//记录修改过的字段
 AddUpdatedFld(conUiFileRelationNode.NodeType);
}
}
/// <summary>
/// SymbolName(说明:;字段类型:nvarchar;字段长度:400;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SymbolName
{
get
{
return mstrSymbolName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSymbolName = value;
}
else
{
 mstrSymbolName = value;
}
//记录修改过的字段
 AddUpdatedFld(conUiFileRelationNode.SymbolName);
}
}
/// <summary>
/// SymbolKey(说明:;字段类型:nvarchar;字段长度:600;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SymbolKey
{
get
{
return mstrSymbolKey;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSymbolKey = value;
}
else
{
 mstrSymbolKey = value;
}
//记录修改过的字段
 AddUpdatedFld(conUiFileRelationNode.SymbolKey);
}
}
/// <summary>
/// SourcePath(说明:;字段类型:nvarchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SourcePath
{
get
{
return mstrSourcePath;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSourcePath = value;
}
else
{
 mstrSourcePath = value;
}
//记录修改过的字段
 AddUpdatedFld(conUiFileRelationNode.SourcePath);
}
}
/// <summary>
/// LineNo(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? LineNo
{
get
{
return mintLineNo;
}
set
{
 mintLineNo = value;
//记录修改过的字段
 AddUpdatedFld(conUiFileRelationNode.LineNo);
}
}
/// <summary>
/// ColumnNo(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? ColumnNo
{
get
{
return mintColumnNo;
}
set
{
 mintColumnNo = value;
//记录修改过的字段
 AddUpdatedFld(conUiFileRelationNode.ColumnNo);
}
}
/// <summary>
/// 层序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int LevelNo
{
get
{
return mintLevelNo;
}
set
{
 mintLevelNo = value;
//记录修改过的字段
 AddUpdatedFld(conUiFileRelationNode.LevelNo);
}
}
/// <summary>
/// ParentNodeId(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long? ParentNodeId
{
get
{
return mlngParentNodeId;
}
set
{
 mlngParentNodeId = value;
//记录修改过的字段
 AddUpdatedFld(conUiFileRelationNode.ParentNodeId);
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
 AddUpdatedFld(conUiFileRelationNode.ExtraJson);
}
}
/// <summary>
/// CreatedAt(说明:;字段类型:datetime;字段长度:16;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public DateTime CreatedAt
{
get
{
return mdteCreatedAt;
}
set
{
 mdteCreatedAt = value;
//记录修改过的字段
 AddUpdatedFld(conUiFileRelationNode.CreatedAt);
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
  return mlngNodeId.ToString();
 }
 }
}
 /// <summary>
 /// UiFileRelationNode(UiFileRelationNode)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conUiFileRelationNode
{
public const string _CurrTabName = "UiFileRelationNode"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "NodeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"NodeId", "TaskId", "FileId", "NodeType", "SymbolName", "SymbolKey", "SourcePath", "LineNo", "ColumnNo", "LevelNo", "ParentNodeId", "ExtraJson", "CreatedAt"};
//以下是属性变量


 /// <summary>
 /// 常量:"NodeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string NodeId = "NodeId";    //NodeId

 /// <summary>
 /// 常量:"TaskId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TaskId = "TaskId";    //TaskId

 /// <summary>
 /// 常量:"FileId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileId = "FileId";    //FileId

 /// <summary>
 /// 常量:"NodeType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string NodeType = "NodeType";    //NodeType

 /// <summary>
 /// 常量:"SymbolName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SymbolName = "SymbolName";    //SymbolName

 /// <summary>
 /// 常量:"SymbolKey"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SymbolKey = "SymbolKey";    //SymbolKey

 /// <summary>
 /// 常量:"SourcePath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SourcePath = "SourcePath";    //SourcePath

 /// <summary>
 /// 常量:"LineNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LineNo = "LineNo";    //LineNo

 /// <summary>
 /// 常量:"ColumnNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ColumnNo = "ColumnNo";    //ColumnNo

 /// <summary>
 /// 常量:"LevelNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LevelNo = "LevelNo";    //层序号

 /// <summary>
 /// 常量:"ParentNodeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParentNodeId = "ParentNodeId";    //ParentNodeId

 /// <summary>
 /// 常量:"ExtraJson"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExtraJson = "ExtraJson";    //ExtraJson

 /// <summary>
 /// 常量:"CreatedAt"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreatedAt = "CreatedAt";    //CreatedAt
}

}