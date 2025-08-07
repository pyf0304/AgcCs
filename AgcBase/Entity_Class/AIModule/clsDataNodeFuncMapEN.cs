
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDataNodeFuncMapEN
 表名:DataNodeFuncMap(00050549)
 * 版本:2023.01.12.1(服务器:WIN-SRV103-116)
 日期:2023/01/18 16:21:29
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
 /// 表DataNodeFuncMap的关键字(DnFuncMapId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_DnFuncMapId_DataNodeFuncMap
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
public K_DnFuncMapId_DataNodeFuncMap(string strDnFuncMapId)
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
 /// <returns>返回:[K_DnFuncMapId_DataNodeFuncMap]类型的对象</returns>
public static implicit operator K_DnFuncMapId_DataNodeFuncMap(string value)
{
return new K_DnFuncMapId_DataNodeFuncMap(value);
}
}
 /// <summary>
 /// 结点函数映射(DataNodeFuncMap)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsDataNodeFuncMapEN : clsEntityBase2
{
public new const string _CurrTabName = "DataNodeFuncMap"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "DnFuncMapId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 12;
public static string[] AttributeName = new string[] {"DnFuncMapId", "InDataNodeId", "OutDataNodeId", "AssociationMappingId", "FuncMapModeId", "TabId", "DnFunctionId", "PrjId", "CmPrjId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量

protected string mstrDnFuncMapId;    //函数映射Id
protected string mstrInDataNodeId;    //In数据结点Id
protected string mstrOutDataNodeId;    //Out数据结点Id
protected string mstrAssociationMappingId;    //关联关系映射Id
protected string mstrFuncMapModeId;    //函数映射模式Id
protected string mstrTabId;    //表ID
protected string mstrDnFunctionId;    //DN函数Id
protected string mstrPrjId;    //工程ID
protected string mstrCmPrjId;    //CM工程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsDataNodeFuncMapEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "DataNodeFuncMap";
 lstKeyFldNames.Add("DnFuncMapId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strDnFuncMapId">关键字:函数映射Id</param>
public clsDataNodeFuncMapEN(string strDnFuncMapId)
 {
strDnFuncMapId = strDnFuncMapId.Replace("'", "''");
if (strDnFuncMapId.Length > 8)
{
throw new Exception("在表:DataNodeFuncMap中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strDnFuncMapId)  ==  true)
{
throw new Exception("在表:DataNodeFuncMap中,关键字不能为空 或 null!");
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
 //_CurrTabName = "DataNodeFuncMap";
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
if (strAttributeName  ==  conDataNodeFuncMap.DnFuncMapId)
{
return mstrDnFuncMapId;
}
else if (strAttributeName  ==  conDataNodeFuncMap.InDataNodeId)
{
return mstrInDataNodeId;
}
else if (strAttributeName  ==  conDataNodeFuncMap.OutDataNodeId)
{
return mstrOutDataNodeId;
}
else if (strAttributeName  ==  conDataNodeFuncMap.AssociationMappingId)
{
return mstrAssociationMappingId;
}
else if (strAttributeName  ==  conDataNodeFuncMap.FuncMapModeId)
{
return mstrFuncMapModeId;
}
else if (strAttributeName  ==  conDataNodeFuncMap.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  conDataNodeFuncMap.DnFunctionId)
{
return mstrDnFunctionId;
}
else if (strAttributeName  ==  conDataNodeFuncMap.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conDataNodeFuncMap.CmPrjId)
{
return mstrCmPrjId;
}
else if (strAttributeName  ==  conDataNodeFuncMap.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conDataNodeFuncMap.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conDataNodeFuncMap.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conDataNodeFuncMap.DnFuncMapId)
{
mstrDnFuncMapId = value.ToString();
 AddUpdatedFld(conDataNodeFuncMap.DnFuncMapId);
}
else if (strAttributeName  ==  conDataNodeFuncMap.InDataNodeId)
{
mstrInDataNodeId = value.ToString();
 AddUpdatedFld(conDataNodeFuncMap.InDataNodeId);
}
else if (strAttributeName  ==  conDataNodeFuncMap.OutDataNodeId)
{
mstrOutDataNodeId = value.ToString();
 AddUpdatedFld(conDataNodeFuncMap.OutDataNodeId);
}
else if (strAttributeName  ==  conDataNodeFuncMap.AssociationMappingId)
{
mstrAssociationMappingId = value.ToString();
 AddUpdatedFld(conDataNodeFuncMap.AssociationMappingId);
}
else if (strAttributeName  ==  conDataNodeFuncMap.FuncMapModeId)
{
mstrFuncMapModeId = value.ToString();
 AddUpdatedFld(conDataNodeFuncMap.FuncMapModeId);
}
else if (strAttributeName  ==  conDataNodeFuncMap.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(conDataNodeFuncMap.TabId);
}
else if (strAttributeName  ==  conDataNodeFuncMap.DnFunctionId)
{
mstrDnFunctionId = value.ToString();
 AddUpdatedFld(conDataNodeFuncMap.DnFunctionId);
}
else if (strAttributeName  ==  conDataNodeFuncMap.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conDataNodeFuncMap.PrjId);
}
else if (strAttributeName  ==  conDataNodeFuncMap.CmPrjId)
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(conDataNodeFuncMap.CmPrjId);
}
else if (strAttributeName  ==  conDataNodeFuncMap.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conDataNodeFuncMap.UpdDate);
}
else if (strAttributeName  ==  conDataNodeFuncMap.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conDataNodeFuncMap.UpdUser);
}
else if (strAttributeName  ==  conDataNodeFuncMap.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDataNodeFuncMap.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conDataNodeFuncMap.DnFuncMapId  ==  AttributeName[intIndex])
{
return mstrDnFuncMapId;
}
else if (conDataNodeFuncMap.InDataNodeId  ==  AttributeName[intIndex])
{
return mstrInDataNodeId;
}
else if (conDataNodeFuncMap.OutDataNodeId  ==  AttributeName[intIndex])
{
return mstrOutDataNodeId;
}
else if (conDataNodeFuncMap.AssociationMappingId  ==  AttributeName[intIndex])
{
return mstrAssociationMappingId;
}
else if (conDataNodeFuncMap.FuncMapModeId  ==  AttributeName[intIndex])
{
return mstrFuncMapModeId;
}
else if (conDataNodeFuncMap.TabId  ==  AttributeName[intIndex])
{
return mstrTabId;
}
else if (conDataNodeFuncMap.DnFunctionId  ==  AttributeName[intIndex])
{
return mstrDnFunctionId;
}
else if (conDataNodeFuncMap.PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conDataNodeFuncMap.CmPrjId  ==  AttributeName[intIndex])
{
return mstrCmPrjId;
}
else if (conDataNodeFuncMap.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conDataNodeFuncMap.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conDataNodeFuncMap.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conDataNodeFuncMap.DnFuncMapId  ==  AttributeName[intIndex])
{
mstrDnFuncMapId = value.ToString();
 AddUpdatedFld(conDataNodeFuncMap.DnFuncMapId);
}
else if (conDataNodeFuncMap.InDataNodeId  ==  AttributeName[intIndex])
{
mstrInDataNodeId = value.ToString();
 AddUpdatedFld(conDataNodeFuncMap.InDataNodeId);
}
else if (conDataNodeFuncMap.OutDataNodeId  ==  AttributeName[intIndex])
{
mstrOutDataNodeId = value.ToString();
 AddUpdatedFld(conDataNodeFuncMap.OutDataNodeId);
}
else if (conDataNodeFuncMap.AssociationMappingId  ==  AttributeName[intIndex])
{
mstrAssociationMappingId = value.ToString();
 AddUpdatedFld(conDataNodeFuncMap.AssociationMappingId);
}
else if (conDataNodeFuncMap.FuncMapModeId  ==  AttributeName[intIndex])
{
mstrFuncMapModeId = value.ToString();
 AddUpdatedFld(conDataNodeFuncMap.FuncMapModeId);
}
else if (conDataNodeFuncMap.TabId  ==  AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(conDataNodeFuncMap.TabId);
}
else if (conDataNodeFuncMap.DnFunctionId  ==  AttributeName[intIndex])
{
mstrDnFunctionId = value.ToString();
 AddUpdatedFld(conDataNodeFuncMap.DnFunctionId);
}
else if (conDataNodeFuncMap.PrjId  ==  AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conDataNodeFuncMap.PrjId);
}
else if (conDataNodeFuncMap.CmPrjId  ==  AttributeName[intIndex])
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(conDataNodeFuncMap.CmPrjId);
}
else if (conDataNodeFuncMap.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conDataNodeFuncMap.UpdDate);
}
else if (conDataNodeFuncMap.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conDataNodeFuncMap.UpdUser);
}
else if (conDataNodeFuncMap.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDataNodeFuncMap.Memo);
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
 AddUpdatedFld(conDataNodeFuncMap.DnFuncMapId);
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
 AddUpdatedFld(conDataNodeFuncMap.InDataNodeId);
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
 AddUpdatedFld(conDataNodeFuncMap.OutDataNodeId);
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
 AddUpdatedFld(conDataNodeFuncMap.AssociationMappingId);
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
 AddUpdatedFld(conDataNodeFuncMap.FuncMapModeId);
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
 AddUpdatedFld(conDataNodeFuncMap.TabId);
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
 AddUpdatedFld(conDataNodeFuncMap.DnFunctionId);
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
 AddUpdatedFld(conDataNodeFuncMap.PrjId);
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
 AddUpdatedFld(conDataNodeFuncMap.CmPrjId);
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
 AddUpdatedFld(conDataNodeFuncMap.UpdDate);
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
 AddUpdatedFld(conDataNodeFuncMap.UpdUser);
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
 AddUpdatedFld(conDataNodeFuncMap.Memo);
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
 /// 结点函数映射(DataNodeFuncMap)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conDataNodeFuncMap
{
public new const string _CurrTabName = "DataNodeFuncMap"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "DnFuncMapId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"DnFuncMapId", "InDataNodeId", "OutDataNodeId", "AssociationMappingId", "FuncMapModeId", "TabId", "DnFunctionId", "PrjId", "CmPrjId", "UpdDate", "UpdUser", "Memo"};
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
 /// 常量:"FuncMapModeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncMapModeId = "FuncMapModeId";    //函数映射模式Id

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