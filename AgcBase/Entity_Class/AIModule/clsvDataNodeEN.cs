
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvDataNodeEN
 表名:vDataNode(00050569)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:03:16
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
 /// 表vDataNode的关键字(DataNodeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_DataNodeId_vDataNode
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
public K_DataNodeId_vDataNode(long lngDataNodeId)
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
 /// <returns>返回:[K_DataNodeId_vDataNode]类型的对象</returns>
public static implicit operator K_DataNodeId_vDataNode(long value)
{
return new K_DataNodeId_vDataNode(value);
}
}
 /// <summary>
 /// vDataNode(vDataNode)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvDataNodeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vDataNode"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "DataNodeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 14;
public static string[] _AttributeName = new string[] {"DataNodeId", "DataNodeName", "TabId", "TabName", "FldId", "FldName", "VersionNo", "DataNodeTypeId", "DataNodeTypeName", "SubGraphName", "PrjId", "UpdDate", "UpdUser", "Memo"};

protected long mlngDataNodeId;    //数据结点Id
protected string mstrDataNodeName;    //数据结点名
protected string mstrTabId;    //表ID
protected string mstrTabName;    //表名
protected string mstrFldId;    //字段Id
protected string mstrFldName;    //字段名
protected int mintVersionNo;    //版本号
protected string mstrDataNodeTypeId;    //数据结点类型Id
protected string mstrDataNodeTypeName;    //数据结点类型名
protected string mstrSubGraphName;    //子图名
protected string mstrPrjId;    //工程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvDataNodeEN()
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
public clsvDataNodeEN(long lngDataNodeId)
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
if (strAttributeName  ==  convDataNode.DataNodeId)
{
return mlngDataNodeId;
}
else if (strAttributeName  ==  convDataNode.DataNodeName)
{
return mstrDataNodeName;
}
else if (strAttributeName  ==  convDataNode.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  convDataNode.TabName)
{
return mstrTabName;
}
else if (strAttributeName  ==  convDataNode.FldId)
{
return mstrFldId;
}
else if (strAttributeName  ==  convDataNode.FldName)
{
return mstrFldName;
}
else if (strAttributeName  ==  convDataNode.VersionNo)
{
return mintVersionNo;
}
else if (strAttributeName  ==  convDataNode.DataNodeTypeId)
{
return mstrDataNodeTypeId;
}
else if (strAttributeName  ==  convDataNode.DataNodeTypeName)
{
return mstrDataNodeTypeName;
}
else if (strAttributeName  ==  convDataNode.SubGraphName)
{
return mstrSubGraphName;
}
else if (strAttributeName  ==  convDataNode.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convDataNode.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convDataNode.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convDataNode.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convDataNode.DataNodeId)
{
mlngDataNodeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convDataNode.DataNodeId);
}
else if (strAttributeName  ==  convDataNode.DataNodeName)
{
mstrDataNodeName = value.ToString();
 AddUpdatedFld(convDataNode.DataNodeName);
}
else if (strAttributeName  ==  convDataNode.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(convDataNode.TabId);
}
else if (strAttributeName  ==  convDataNode.TabName)
{
mstrTabName = value.ToString();
 AddUpdatedFld(convDataNode.TabName);
}
else if (strAttributeName  ==  convDataNode.FldId)
{
mstrFldId = value.ToString();
 AddUpdatedFld(convDataNode.FldId);
}
else if (strAttributeName  ==  convDataNode.FldName)
{
mstrFldName = value.ToString();
 AddUpdatedFld(convDataNode.FldName);
}
else if (strAttributeName  ==  convDataNode.VersionNo)
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convDataNode.VersionNo);
}
else if (strAttributeName  ==  convDataNode.DataNodeTypeId)
{
mstrDataNodeTypeId = value.ToString();
 AddUpdatedFld(convDataNode.DataNodeTypeId);
}
else if (strAttributeName  ==  convDataNode.DataNodeTypeName)
{
mstrDataNodeTypeName = value.ToString();
 AddUpdatedFld(convDataNode.DataNodeTypeName);
}
else if (strAttributeName  ==  convDataNode.SubGraphName)
{
mstrSubGraphName = value.ToString();
 AddUpdatedFld(convDataNode.SubGraphName);
}
else if (strAttributeName  ==  convDataNode.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convDataNode.PrjId);
}
else if (strAttributeName  ==  convDataNode.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convDataNode.UpdDate);
}
else if (strAttributeName  ==  convDataNode.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convDataNode.UpdUser);
}
else if (strAttributeName  ==  convDataNode.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convDataNode.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convDataNode.DataNodeId  ==  _AttributeName[intIndex])
{
return mlngDataNodeId;
}
else if (convDataNode.DataNodeName  ==  _AttributeName[intIndex])
{
return mstrDataNodeName;
}
else if (convDataNode.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (convDataNode.TabName  ==  _AttributeName[intIndex])
{
return mstrTabName;
}
else if (convDataNode.FldId  ==  _AttributeName[intIndex])
{
return mstrFldId;
}
else if (convDataNode.FldName  ==  _AttributeName[intIndex])
{
return mstrFldName;
}
else if (convDataNode.VersionNo  ==  _AttributeName[intIndex])
{
return mintVersionNo;
}
else if (convDataNode.DataNodeTypeId  ==  _AttributeName[intIndex])
{
return mstrDataNodeTypeId;
}
else if (convDataNode.DataNodeTypeName  ==  _AttributeName[intIndex])
{
return mstrDataNodeTypeName;
}
else if (convDataNode.SubGraphName  ==  _AttributeName[intIndex])
{
return mstrSubGraphName;
}
else if (convDataNode.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convDataNode.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convDataNode.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convDataNode.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convDataNode.DataNodeId  ==  _AttributeName[intIndex])
{
mlngDataNodeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convDataNode.DataNodeId);
}
else if (convDataNode.DataNodeName  ==  _AttributeName[intIndex])
{
mstrDataNodeName = value.ToString();
 AddUpdatedFld(convDataNode.DataNodeName);
}
else if (convDataNode.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(convDataNode.TabId);
}
else if (convDataNode.TabName  ==  _AttributeName[intIndex])
{
mstrTabName = value.ToString();
 AddUpdatedFld(convDataNode.TabName);
}
else if (convDataNode.FldId  ==  _AttributeName[intIndex])
{
mstrFldId = value.ToString();
 AddUpdatedFld(convDataNode.FldId);
}
else if (convDataNode.FldName  ==  _AttributeName[intIndex])
{
mstrFldName = value.ToString();
 AddUpdatedFld(convDataNode.FldName);
}
else if (convDataNode.VersionNo  ==  _AttributeName[intIndex])
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convDataNode.VersionNo);
}
else if (convDataNode.DataNodeTypeId  ==  _AttributeName[intIndex])
{
mstrDataNodeTypeId = value.ToString();
 AddUpdatedFld(convDataNode.DataNodeTypeId);
}
else if (convDataNode.DataNodeTypeName  ==  _AttributeName[intIndex])
{
mstrDataNodeTypeName = value.ToString();
 AddUpdatedFld(convDataNode.DataNodeTypeName);
}
else if (convDataNode.SubGraphName  ==  _AttributeName[intIndex])
{
mstrSubGraphName = value.ToString();
 AddUpdatedFld(convDataNode.SubGraphName);
}
else if (convDataNode.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convDataNode.PrjId);
}
else if (convDataNode.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convDataNode.UpdDate);
}
else if (convDataNode.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convDataNode.UpdUser);
}
else if (convDataNode.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convDataNode.Memo);
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
 AddUpdatedFld(convDataNode.DataNodeId);
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
 AddUpdatedFld(convDataNode.DataNodeName);
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
 AddUpdatedFld(convDataNode.TabId);
}
}
/// <summary>
/// 表名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabName
{
get
{
return mstrTabName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabName = value;
}
else
{
 mstrTabName = value;
}
//记录修改过的字段
 AddUpdatedFld(convDataNode.TabName);
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
 AddUpdatedFld(convDataNode.FldId);
}
}
/// <summary>
/// 字段名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FldName
{
get
{
return mstrFldName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldName = value;
}
else
{
 mstrFldName = value;
}
//记录修改过的字段
 AddUpdatedFld(convDataNode.FldName);
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
 AddUpdatedFld(convDataNode.VersionNo);
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
 AddUpdatedFld(convDataNode.DataNodeTypeId);
}
}
/// <summary>
/// 数据结点类型名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataNodeTypeName
{
get
{
return mstrDataNodeTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataNodeTypeName = value;
}
else
{
 mstrDataNodeTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convDataNode.DataNodeTypeName);
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
 AddUpdatedFld(convDataNode.SubGraphName);
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
 AddUpdatedFld(convDataNode.PrjId);
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
 AddUpdatedFld(convDataNode.UpdDate);
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
 AddUpdatedFld(convDataNode.UpdUser);
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
 AddUpdatedFld(convDataNode.Memo);
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
 /// vDataNode(vDataNode)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convDataNode
{
public const string _CurrTabName = "vDataNode"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "DataNodeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"DataNodeId", "DataNodeName", "TabId", "TabName", "FldId", "FldName", "VersionNo", "DataNodeTypeId", "DataNodeTypeName", "SubGraphName", "PrjId", "UpdDate", "UpdUser", "Memo"};
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
 /// 常量:"TabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabName = "TabName";    //表名

 /// <summary>
 /// 常量:"FldId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldId = "FldId";    //字段Id

 /// <summary>
 /// 常量:"FldName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldName = "FldName";    //字段名

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
 /// 常量:"DataNodeTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataNodeTypeName = "DataNodeTypeName";    //数据结点类型名

 /// <summary>
 /// 常量:"SubGraphName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SubGraphName = "SubGraphName";    //子图名

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

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