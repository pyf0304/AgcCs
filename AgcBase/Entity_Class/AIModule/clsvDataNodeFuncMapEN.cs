
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvDataNodeFuncMapEN
 表名:vDataNodeFuncMap(00050554)
 * 版本:2023.01.12.1(服务器:WIN-SRV103-116)
 日期:2023/01/18 16:25:23
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:AI模块(AIModule)
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
 /// 表vDataNodeFuncMap的关键字(DnFuncMapId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_DnFuncMapId_vDataNodeFuncMap
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strDnFuncMapId">表关键字</param>
public K_DnFuncMapId_vDataNodeFuncMap(string strDnFuncMapId)
{
if (IsValid(strDnFuncMapId)) Value = strDnFuncMapId;
else
{
Value = null;
}
}
private static bool IsValid(string strDnFuncMapId)
{
if (string.IsNullOrEmpty(strDnFuncMapId) == true) return false;
if (strDnFuncMapId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_DnFuncMapId_vDataNodeFuncMap]类型的对象</returns>
public static implicit operator K_DnFuncMapId_vDataNodeFuncMap(string value)
{
return new K_DnFuncMapId_vDataNodeFuncMap(value);
}
}
 /// <summary>
 /// v结点函数映射(vDataNodeFuncMap)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvDataNodeFuncMapEN : clsEntityBase2
{
public new const string _CurrTabName = "vDataNodeFuncMap"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "DnFuncMapId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 17;
public static string[] AttributeName = new string[] {"DnFuncMapId", "InDataNodeId", "OutDataNodeId", "AssociationMappingId", "AssociationMappingName", "FuncMapModeId", "FuncMapModeName", "TabId", "DnFunctionId", "PrjId", "CmPrjId", "CmPrjName", "UpdDate", "UpdUser", "Memo", "InDataNodeName", "OutDataNodeName"};
//以下是属性变量

protected string mstrDnFuncMapId;    //函数映射Id
protected string mstrInDataNodeId;    //In数据结点Id
protected string mstrOutDataNodeId;    //Out数据结点Id
protected string mstrAssociationMappingId;    //关联关系映射Id
protected string mstrAssociationMappingName;    //关联关系映射名
protected string mstrFuncMapModeId;    //函数映射模式Id
protected string mstrFuncMapModeName;    //函数映射模式名
protected string mstrTabId;    //表ID
protected string mstrDnFunctionId;    //DN函数Id
protected string mstrPrjId;    //工程ID
protected string mstrCmPrjId;    //CM工程Id
protected string mstrCmPrjName;    //CM工程名
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明
protected string mstrInDataNodeName;    //In数据结点名
protected string mstrOutDataNodeName;    //Out数据结点名

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvDataNodeFuncMapEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "vDataNodeFuncMap";
 lstKeyFldNames.Add("DnFuncMapId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strDnFuncMapId">关键字:函数映射Id</param>
public clsvDataNodeFuncMapEN(string strDnFuncMapId)
 {
strDnFuncMapId = strDnFuncMapId.Replace("'", "''");
if (strDnFuncMapId.Length > 8)
{
throw new Exception("在表:vDataNodeFuncMap中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strDnFuncMapId)  ==  true)
{
throw new Exception("在表:vDataNodeFuncMap中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strDnFuncMapId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrDnFuncMapId = strDnFuncMapId;
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "vDataNodeFuncMap";
 lstKeyFldNames.Add("DnFuncMapId");
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
if (strAttributeName  ==  convDataNodeFuncMap.DnFuncMapId)
{
return mstrDnFuncMapId;
}
else if (strAttributeName  ==  convDataNodeFuncMap.InDataNodeId)
{
return mstrInDataNodeId;
}
else if (strAttributeName  ==  convDataNodeFuncMap.OutDataNodeId)
{
return mstrOutDataNodeId;
}
else if (strAttributeName  ==  convDataNodeFuncMap.AssociationMappingId)
{
return mstrAssociationMappingId;
}
else if (strAttributeName  ==  convDataNodeFuncMap.AssociationMappingName)
{
return mstrAssociationMappingName;
}
else if (strAttributeName  ==  convDataNodeFuncMap.FuncMapModeId)
{
return mstrFuncMapModeId;
}
else if (strAttributeName  ==  convDataNodeFuncMap.FuncMapModeName)
{
return mstrFuncMapModeName;
}
else if (strAttributeName  ==  convDataNodeFuncMap.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  convDataNodeFuncMap.DnFunctionId)
{
return mstrDnFunctionId;
}
else if (strAttributeName  ==  convDataNodeFuncMap.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convDataNodeFuncMap.CmPrjId)
{
return mstrCmPrjId;
}
else if (strAttributeName  ==  convDataNodeFuncMap.CmPrjName)
{
return mstrCmPrjName;
}
else if (strAttributeName  ==  convDataNodeFuncMap.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convDataNodeFuncMap.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convDataNodeFuncMap.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convDataNodeFuncMap.InDataNodeName)
{
return mstrInDataNodeName;
}
else if (strAttributeName  ==  convDataNodeFuncMap.OutDataNodeName)
{
return mstrOutDataNodeName;
}
return null;
}
set
{
if (strAttributeName  ==  convDataNodeFuncMap.DnFuncMapId)
{
mstrDnFuncMapId = value.ToString();
 AddUpdatedFld(convDataNodeFuncMap.DnFuncMapId);
}
else if (strAttributeName  ==  convDataNodeFuncMap.InDataNodeId)
{
mstrInDataNodeId = value.ToString();
 AddUpdatedFld(convDataNodeFuncMap.InDataNodeId);
}
else if (strAttributeName  ==  convDataNodeFuncMap.OutDataNodeId)
{
mstrOutDataNodeId = value.ToString();
 AddUpdatedFld(convDataNodeFuncMap.OutDataNodeId);
}
else if (strAttributeName  ==  convDataNodeFuncMap.AssociationMappingId)
{
mstrAssociationMappingId = value.ToString();
 AddUpdatedFld(convDataNodeFuncMap.AssociationMappingId);
}
else if (strAttributeName  ==  convDataNodeFuncMap.AssociationMappingName)
{
mstrAssociationMappingName = value.ToString();
 AddUpdatedFld(convDataNodeFuncMap.AssociationMappingName);
}
else if (strAttributeName  ==  convDataNodeFuncMap.FuncMapModeId)
{
mstrFuncMapModeId = value.ToString();
 AddUpdatedFld(convDataNodeFuncMap.FuncMapModeId);
}
else if (strAttributeName  ==  convDataNodeFuncMap.FuncMapModeName)
{
mstrFuncMapModeName = value.ToString();
 AddUpdatedFld(convDataNodeFuncMap.FuncMapModeName);
}
else if (strAttributeName  ==  convDataNodeFuncMap.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(convDataNodeFuncMap.TabId);
}
else if (strAttributeName  ==  convDataNodeFuncMap.DnFunctionId)
{
mstrDnFunctionId = value.ToString();
 AddUpdatedFld(convDataNodeFuncMap.DnFunctionId);
}
else if (strAttributeName  ==  convDataNodeFuncMap.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convDataNodeFuncMap.PrjId);
}
else if (strAttributeName  ==  convDataNodeFuncMap.CmPrjId)
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(convDataNodeFuncMap.CmPrjId);
}
else if (strAttributeName  ==  convDataNodeFuncMap.CmPrjName)
{
mstrCmPrjName = value.ToString();
 AddUpdatedFld(convDataNodeFuncMap.CmPrjName);
}
else if (strAttributeName  ==  convDataNodeFuncMap.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convDataNodeFuncMap.UpdDate);
}
else if (strAttributeName  ==  convDataNodeFuncMap.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convDataNodeFuncMap.UpdUser);
}
else if (strAttributeName  ==  convDataNodeFuncMap.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convDataNodeFuncMap.Memo);
}
else if (strAttributeName  ==  convDataNodeFuncMap.InDataNodeName)
{
mstrInDataNodeName = value.ToString();
 AddUpdatedFld(convDataNodeFuncMap.InDataNodeName);
}
else if (strAttributeName  ==  convDataNodeFuncMap.OutDataNodeName)
{
mstrOutDataNodeName = value.ToString();
 AddUpdatedFld(convDataNodeFuncMap.OutDataNodeName);
}
}
}
public object this[int intIndex]
{
get
{
if (convDataNodeFuncMap.DnFuncMapId  ==  AttributeName[intIndex])
{
return mstrDnFuncMapId;
}
else if (convDataNodeFuncMap.InDataNodeId  ==  AttributeName[intIndex])
{
return mstrInDataNodeId;
}
else if (convDataNodeFuncMap.OutDataNodeId  ==  AttributeName[intIndex])
{
return mstrOutDataNodeId;
}
else if (convDataNodeFuncMap.AssociationMappingId  ==  AttributeName[intIndex])
{
return mstrAssociationMappingId;
}
else if (convDataNodeFuncMap.AssociationMappingName  ==  AttributeName[intIndex])
{
return mstrAssociationMappingName;
}
else if (convDataNodeFuncMap.FuncMapModeId  ==  AttributeName[intIndex])
{
return mstrFuncMapModeId;
}
else if (convDataNodeFuncMap.FuncMapModeName  ==  AttributeName[intIndex])
{
return mstrFuncMapModeName;
}
else if (convDataNodeFuncMap.TabId  ==  AttributeName[intIndex])
{
return mstrTabId;
}
else if (convDataNodeFuncMap.DnFunctionId  ==  AttributeName[intIndex])
{
return mstrDnFunctionId;
}
else if (convDataNodeFuncMap.PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convDataNodeFuncMap.CmPrjId  ==  AttributeName[intIndex])
{
return mstrCmPrjId;
}
else if (convDataNodeFuncMap.CmPrjName  ==  AttributeName[intIndex])
{
return mstrCmPrjName;
}
else if (convDataNodeFuncMap.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convDataNodeFuncMap.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convDataNodeFuncMap.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convDataNodeFuncMap.InDataNodeName  ==  AttributeName[intIndex])
{
return mstrInDataNodeName;
}
else if (convDataNodeFuncMap.OutDataNodeName  ==  AttributeName[intIndex])
{
return mstrOutDataNodeName;
}
return null;
}
set
{
if (convDataNodeFuncMap.DnFuncMapId  ==  AttributeName[intIndex])
{
mstrDnFuncMapId = value.ToString();
 AddUpdatedFld(convDataNodeFuncMap.DnFuncMapId);
}
else if (convDataNodeFuncMap.InDataNodeId  ==  AttributeName[intIndex])
{
mstrInDataNodeId = value.ToString();
 AddUpdatedFld(convDataNodeFuncMap.InDataNodeId);
}
else if (convDataNodeFuncMap.OutDataNodeId  ==  AttributeName[intIndex])
{
mstrOutDataNodeId = value.ToString();
 AddUpdatedFld(convDataNodeFuncMap.OutDataNodeId);
}
else if (convDataNodeFuncMap.AssociationMappingId  ==  AttributeName[intIndex])
{
mstrAssociationMappingId = value.ToString();
 AddUpdatedFld(convDataNodeFuncMap.AssociationMappingId);
}
else if (convDataNodeFuncMap.AssociationMappingName  ==  AttributeName[intIndex])
{
mstrAssociationMappingName = value.ToString();
 AddUpdatedFld(convDataNodeFuncMap.AssociationMappingName);
}
else if (convDataNodeFuncMap.FuncMapModeId  ==  AttributeName[intIndex])
{
mstrFuncMapModeId = value.ToString();
 AddUpdatedFld(convDataNodeFuncMap.FuncMapModeId);
}
else if (convDataNodeFuncMap.FuncMapModeName  ==  AttributeName[intIndex])
{
mstrFuncMapModeName = value.ToString();
 AddUpdatedFld(convDataNodeFuncMap.FuncMapModeName);
}
else if (convDataNodeFuncMap.TabId  ==  AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(convDataNodeFuncMap.TabId);
}
else if (convDataNodeFuncMap.DnFunctionId  ==  AttributeName[intIndex])
{
mstrDnFunctionId = value.ToString();
 AddUpdatedFld(convDataNodeFuncMap.DnFunctionId);
}
else if (convDataNodeFuncMap.PrjId  ==  AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convDataNodeFuncMap.PrjId);
}
else if (convDataNodeFuncMap.CmPrjId  ==  AttributeName[intIndex])
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(convDataNodeFuncMap.CmPrjId);
}
else if (convDataNodeFuncMap.CmPrjName  ==  AttributeName[intIndex])
{
mstrCmPrjName = value.ToString();
 AddUpdatedFld(convDataNodeFuncMap.CmPrjName);
}
else if (convDataNodeFuncMap.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convDataNodeFuncMap.UpdDate);
}
else if (convDataNodeFuncMap.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convDataNodeFuncMap.UpdUser);
}
else if (convDataNodeFuncMap.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convDataNodeFuncMap.Memo);
}
else if (convDataNodeFuncMap.InDataNodeName  ==  AttributeName[intIndex])
{
mstrInDataNodeName = value.ToString();
 AddUpdatedFld(convDataNodeFuncMap.InDataNodeName);
}
else if (convDataNodeFuncMap.OutDataNodeName  ==  AttributeName[intIndex])
{
mstrOutDataNodeName = value.ToString();
 AddUpdatedFld(convDataNodeFuncMap.OutDataNodeName);
}
}
}

/// <summary>
/// 函数映射Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DnFuncMapId
{
get
{
return mstrDnFuncMapId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDnFuncMapId = value;
}
else
{
 mstrDnFuncMapId = value;
}
//记录修改过的字段
 AddUpdatedFld(convDataNodeFuncMap.DnFuncMapId);
}
}
/// <summary>
/// In数据结点Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string InDataNodeId
{
get
{
return mstrInDataNodeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrInDataNodeId = value;
}
else
{
 mstrInDataNodeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convDataNodeFuncMap.InDataNodeId);
}
}
/// <summary>
/// Out数据结点Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OutDataNodeId
{
get
{
return mstrOutDataNodeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOutDataNodeId = value;
}
else
{
 mstrOutDataNodeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convDataNodeFuncMap.OutDataNodeId);
}
}
/// <summary>
/// 关联关系映射Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AssociationMappingId
{
get
{
return mstrAssociationMappingId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAssociationMappingId = value;
}
else
{
 mstrAssociationMappingId = value;
}
//记录修改过的字段
 AddUpdatedFld(convDataNodeFuncMap.AssociationMappingId);
}
}
/// <summary>
/// 关联关系映射名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AssociationMappingName
{
get
{
return mstrAssociationMappingName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAssociationMappingName = value;
}
else
{
 mstrAssociationMappingName = value;
}
//记录修改过的字段
 AddUpdatedFld(convDataNodeFuncMap.AssociationMappingName);
}
}
/// <summary>
/// 函数映射模式Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncMapModeId
{
get
{
return mstrFuncMapModeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncMapModeId = value;
}
else
{
 mstrFuncMapModeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convDataNodeFuncMap.FuncMapModeId);
}
}
/// <summary>
/// 函数映射模式名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncMapModeName
{
get
{
return mstrFuncMapModeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncMapModeName = value;
}
else
{
 mstrFuncMapModeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convDataNodeFuncMap.FuncMapModeName);
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
 AddUpdatedFld(convDataNodeFuncMap.TabId);
}
}
/// <summary>
/// DN函数Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DnFunctionId
{
get
{
return mstrDnFunctionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDnFunctionId = value;
}
else
{
 mstrDnFunctionId = value;
}
//记录修改过的字段
 AddUpdatedFld(convDataNodeFuncMap.DnFunctionId);
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
 AddUpdatedFld(convDataNodeFuncMap.PrjId);
}
}
/// <summary>
/// CM工程Id(说明:;字段类型:char;字段长度:6;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CmPrjId
{
get
{
return mstrCmPrjId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCmPrjId = value;
}
else
{
 mstrCmPrjId = value;
}
//记录修改过的字段
 AddUpdatedFld(convDataNodeFuncMap.CmPrjId);
}
}
/// <summary>
/// CM工程名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CmPrjName
{
get
{
return mstrCmPrjName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCmPrjName = value;
}
else
{
 mstrCmPrjName = value;
}
//记录修改过的字段
 AddUpdatedFld(convDataNodeFuncMap.CmPrjName);
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
 AddUpdatedFld(convDataNodeFuncMap.UpdDate);
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
 AddUpdatedFld(convDataNodeFuncMap.UpdUser);
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
 AddUpdatedFld(convDataNodeFuncMap.Memo);
}
}
/// <summary>
/// In数据结点名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string InDataNodeName
{
get
{
return mstrInDataNodeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrInDataNodeName = value;
}
else
{
 mstrInDataNodeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convDataNodeFuncMap.InDataNodeName);
}
}
/// <summary>
/// Out数据结点名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OutDataNodeName
{
get
{
return mstrOutDataNodeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOutDataNodeName = value;
}
else
{
 mstrOutDataNodeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convDataNodeFuncMap.OutDataNodeName);
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
  return mstrDnFuncMapId;
 }
 }
}
 /// <summary>
 /// v结点函数映射(vDataNodeFuncMap)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convDataNodeFuncMap
{
public new const string _CurrTabName = "vDataNodeFuncMap"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "DnFuncMapId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"DnFuncMapId", "InDataNodeId", "OutDataNodeId", "AssociationMappingId", "AssociationMappingName", "FuncMapModeId", "FuncMapModeName", "TabId", "DnFunctionId", "PrjId", "CmPrjId", "CmPrjName", "UpdDate", "UpdUser", "Memo", "InDataNodeName", "OutDataNodeName"};
//以下是属性变量


 /// <summary>
 /// 常量:"DnFuncMapId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DnFuncMapId = "DnFuncMapId";    //函数映射Id

 /// <summary>
 /// 常量:"InDataNodeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InDataNodeId = "InDataNodeId";    //In数据结点Id

 /// <summary>
 /// 常量:"OutDataNodeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OutDataNodeId = "OutDataNodeId";    //Out数据结点Id

 /// <summary>
 /// 常量:"AssociationMappingId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AssociationMappingId = "AssociationMappingId";    //关联关系映射Id

 /// <summary>
 /// 常量:"AssociationMappingName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AssociationMappingName = "AssociationMappingName";    //关联关系映射名

 /// <summary>
 /// 常量:"FuncMapModeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncMapModeId = "FuncMapModeId";    //函数映射模式Id

 /// <summary>
 /// 常量:"FuncMapModeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncMapModeName = "FuncMapModeName";    //函数映射模式名

 /// <summary>
 /// 常量:"TabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabId = "TabId";    //表ID

 /// <summary>
 /// 常量:"DnFunctionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DnFunctionId = "DnFunctionId";    //DN函数Id

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程ID

 /// <summary>
 /// 常量:"CmPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CmPrjId = "CmPrjId";    //CM工程Id

 /// <summary>
 /// 常量:"CmPrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CmPrjName = "CmPrjName";    //CM工程名

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
 /// 常量:"InDataNodeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InDataNodeName = "InDataNodeName";    //In数据结点名

 /// <summary>
 /// 常量:"OutDataNodeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OutDataNodeName = "OutDataNodeName";    //Out数据结点名
}

}