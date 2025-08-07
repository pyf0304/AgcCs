
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvDnFuncMap_SimEN
 表名:vDnFuncMap_Sim(00050625)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:27:31
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
 /// 表vDnFuncMap_Sim的关键字(DnFuncMapId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_DnFuncMapId_vDnFuncMap_Sim
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
public K_DnFuncMapId_vDnFuncMap_Sim(string strDnFuncMapId)
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
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_DnFuncMapId_vDnFuncMap_Sim]类型的对象</returns>
public static implicit operator K_DnFuncMapId_vDnFuncMap_Sim(string value)
{
return new K_DnFuncMapId_vDnFuncMap_Sim(value);
}
}
 /// <summary>
 /// v结点函数映射_Sim(vDnFuncMap_Sim)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvDnFuncMap_SimEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vDnFuncMap_Sim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "DnFuncMapId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = "UsedTimes>0 and PrjId='{0}'"; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 9;
public static string[] _AttributeName = new string[] {"DnFuncMapId", "InDataNodeId", "OutDataNodeId", "AssociationMappingId", "FuncMapModeId", "TabId", "DnFunctionId", "PrjId", "UsedTimes"};

protected string mstrDnFuncMapId;    //函数映射Id
protected long? mlngInDataNodeId;    //In数据结点Id
protected long? mlngOutDataNodeId;    //Out数据结点Id
protected string mstrAssociationMappingId;    //关联关系映射Id
protected string mstrFuncMapModeId;    //函数映射模式Id
protected string mstrTabId;    //表ID
protected string mstrDnFunctionId;    //DN函数Id
protected string mstrPrjId;    //工程Id
protected int? mintUsedTimes;    //使用次数

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvDnFuncMap_SimEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("DnFuncMapId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strDnFuncMapId">关键字:函数映射Id</param>
public clsvDnFuncMap_SimEN(string strDnFuncMapId)
 {
strDnFuncMapId = strDnFuncMapId.Replace("'", "''");
if (strDnFuncMapId.Length > 8)
{
throw new Exception("在表:vDnFuncMap_Sim中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strDnFuncMapId)  ==  true)
{
throw new Exception("在表:vDnFuncMap_Sim中,关键字不能为空 或 null!");
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
 lstKeyFldNames.Add("DnFuncMapId");
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
if (strAttributeName  ==  convDnFuncMap_Sim.DnFuncMapId)
{
return mstrDnFuncMapId;
}
else if (strAttributeName  ==  convDnFuncMap_Sim.InDataNodeId)
{
return mlngInDataNodeId;
}
else if (strAttributeName  ==  convDnFuncMap_Sim.OutDataNodeId)
{
return mlngOutDataNodeId;
}
else if (strAttributeName  ==  convDnFuncMap_Sim.AssociationMappingId)
{
return mstrAssociationMappingId;
}
else if (strAttributeName  ==  convDnFuncMap_Sim.FuncMapModeId)
{
return mstrFuncMapModeId;
}
else if (strAttributeName  ==  convDnFuncMap_Sim.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  convDnFuncMap_Sim.DnFunctionId)
{
return mstrDnFunctionId;
}
else if (strAttributeName  ==  convDnFuncMap_Sim.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convDnFuncMap_Sim.UsedTimes)
{
return mintUsedTimes;
}
return null;
}
set
{
if (strAttributeName  ==  convDnFuncMap_Sim.DnFuncMapId)
{
mstrDnFuncMapId = value.ToString();
 AddUpdatedFld(convDnFuncMap_Sim.DnFuncMapId);
}
else if (strAttributeName  ==  convDnFuncMap_Sim.InDataNodeId)
{
mlngInDataNodeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convDnFuncMap_Sim.InDataNodeId);
}
else if (strAttributeName  ==  convDnFuncMap_Sim.OutDataNodeId)
{
mlngOutDataNodeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convDnFuncMap_Sim.OutDataNodeId);
}
else if (strAttributeName  ==  convDnFuncMap_Sim.AssociationMappingId)
{
mstrAssociationMappingId = value.ToString();
 AddUpdatedFld(convDnFuncMap_Sim.AssociationMappingId);
}
else if (strAttributeName  ==  convDnFuncMap_Sim.FuncMapModeId)
{
mstrFuncMapModeId = value.ToString();
 AddUpdatedFld(convDnFuncMap_Sim.FuncMapModeId);
}
else if (strAttributeName  ==  convDnFuncMap_Sim.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(convDnFuncMap_Sim.TabId);
}
else if (strAttributeName  ==  convDnFuncMap_Sim.DnFunctionId)
{
mstrDnFunctionId = value.ToString();
 AddUpdatedFld(convDnFuncMap_Sim.DnFunctionId);
}
else if (strAttributeName  ==  convDnFuncMap_Sim.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convDnFuncMap_Sim.PrjId);
}
else if (strAttributeName  ==  convDnFuncMap_Sim.UsedTimes)
{
mintUsedTimes = TransNullToInt(value.ToString());
 AddUpdatedFld(convDnFuncMap_Sim.UsedTimes);
}
}
}
public object this[int intIndex]
{
get
{
if (convDnFuncMap_Sim.DnFuncMapId  ==  _AttributeName[intIndex])
{
return mstrDnFuncMapId;
}
else if (convDnFuncMap_Sim.InDataNodeId  ==  _AttributeName[intIndex])
{
return mlngInDataNodeId;
}
else if (convDnFuncMap_Sim.OutDataNodeId  ==  _AttributeName[intIndex])
{
return mlngOutDataNodeId;
}
else if (convDnFuncMap_Sim.AssociationMappingId  ==  _AttributeName[intIndex])
{
return mstrAssociationMappingId;
}
else if (convDnFuncMap_Sim.FuncMapModeId  ==  _AttributeName[intIndex])
{
return mstrFuncMapModeId;
}
else if (convDnFuncMap_Sim.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (convDnFuncMap_Sim.DnFunctionId  ==  _AttributeName[intIndex])
{
return mstrDnFunctionId;
}
else if (convDnFuncMap_Sim.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convDnFuncMap_Sim.UsedTimes  ==  _AttributeName[intIndex])
{
return mintUsedTimes;
}
return null;
}
set
{
if (convDnFuncMap_Sim.DnFuncMapId  ==  _AttributeName[intIndex])
{
mstrDnFuncMapId = value.ToString();
 AddUpdatedFld(convDnFuncMap_Sim.DnFuncMapId);
}
else if (convDnFuncMap_Sim.InDataNodeId  ==  _AttributeName[intIndex])
{
mlngInDataNodeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convDnFuncMap_Sim.InDataNodeId);
}
else if (convDnFuncMap_Sim.OutDataNodeId  ==  _AttributeName[intIndex])
{
mlngOutDataNodeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convDnFuncMap_Sim.OutDataNodeId);
}
else if (convDnFuncMap_Sim.AssociationMappingId  ==  _AttributeName[intIndex])
{
mstrAssociationMappingId = value.ToString();
 AddUpdatedFld(convDnFuncMap_Sim.AssociationMappingId);
}
else if (convDnFuncMap_Sim.FuncMapModeId  ==  _AttributeName[intIndex])
{
mstrFuncMapModeId = value.ToString();
 AddUpdatedFld(convDnFuncMap_Sim.FuncMapModeId);
}
else if (convDnFuncMap_Sim.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(convDnFuncMap_Sim.TabId);
}
else if (convDnFuncMap_Sim.DnFunctionId  ==  _AttributeName[intIndex])
{
mstrDnFunctionId = value.ToString();
 AddUpdatedFld(convDnFuncMap_Sim.DnFunctionId);
}
else if (convDnFuncMap_Sim.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convDnFuncMap_Sim.PrjId);
}
else if (convDnFuncMap_Sim.UsedTimes  ==  _AttributeName[intIndex])
{
mintUsedTimes = TransNullToInt(value.ToString());
 AddUpdatedFld(convDnFuncMap_Sim.UsedTimes);
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
 AddUpdatedFld(convDnFuncMap_Sim.DnFuncMapId);
}
}
/// <summary>
/// In数据结点Id(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long? InDataNodeId
{
get
{
return mlngInDataNodeId;
}
set
{
 mlngInDataNodeId = value;
//记录修改过的字段
 AddUpdatedFld(convDnFuncMap_Sim.InDataNodeId);
}
}
/// <summary>
/// Out数据结点Id(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long? OutDataNodeId
{
get
{
return mlngOutDataNodeId;
}
set
{
 mlngOutDataNodeId = value;
//记录修改过的字段
 AddUpdatedFld(convDnFuncMap_Sim.OutDataNodeId);
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
 AddUpdatedFld(convDnFuncMap_Sim.AssociationMappingId);
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
 AddUpdatedFld(convDnFuncMap_Sim.FuncMapModeId);
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
 AddUpdatedFld(convDnFuncMap_Sim.TabId);
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
 AddUpdatedFld(convDnFuncMap_Sim.DnFunctionId);
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
 AddUpdatedFld(convDnFuncMap_Sim.PrjId);
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
 AddUpdatedFld(convDnFuncMap_Sim.UsedTimes);
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
  return mstrDnFuncMapId;
 }
 }
}
 /// <summary>
 /// v结点函数映射_Sim(vDnFuncMap_Sim)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convDnFuncMap_Sim
{
public const string _CurrTabName = "vDnFuncMap_Sim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "DnFuncMapId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"DnFuncMapId", "InDataNodeId", "OutDataNodeId", "AssociationMappingId", "FuncMapModeId", "TabId", "DnFunctionId", "PrjId", "UsedTimes"};
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
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"UsedTimes"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UsedTimes = "UsedTimes";    //使用次数
}

}