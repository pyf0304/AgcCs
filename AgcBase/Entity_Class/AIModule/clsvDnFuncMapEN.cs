
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvDnFuncMapEN
 表名:vDnFuncMap(00050554)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:03:14
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
 /// 表vDnFuncMap的关键字(DnFuncMapId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_DnFuncMapId_vDnFuncMap
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
public K_DnFuncMapId_vDnFuncMap(string strDnFuncMapId)
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
 /// <returns>返回:[K_DnFuncMapId_vDnFuncMap]类型的对象</returns>
public static implicit operator K_DnFuncMapId_vDnFuncMap(string value)
{
return new K_DnFuncMapId_vDnFuncMap(value);
}
}
 /// <summary>
 /// v结点函数映射(vDnFuncMap)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvDnFuncMapEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vDnFuncMap"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "DnFuncMapId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 15;
public static string[] _AttributeName = new string[] {"DnFuncMapId", "InDataNodeId", "OutDataNodeId", "AssociationMappingId", "AssociationMappingName", "FuncMapModeId", "FuncMapModeName", "TabId", "DnFunctionId", "PrjId", "UpdDate", "UpdUser", "Memo", "InDataNodeName", "OutDataNodeName"};

protected string mstrDnFuncMapId;    //函数映射Id
protected long? mlngInDataNodeId;    //In数据结点Id
protected long? mlngOutDataNodeId;    //Out数据结点Id
protected string mstrAssociationMappingId;    //关联关系映射Id
protected string mstrAssociationMappingName;    //关联关系映射名
protected string mstrFuncMapModeId;    //函数映射模式Id
protected string mstrFuncMapModeName;    //函数映射模式名
protected string mstrTabId;    //表ID
protected string mstrDnFunctionId;    //DN函数Id
protected string mstrPrjId;    //工程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明
protected string mstrInDataNodeName;    //In数据结点名
protected string mstrOutDataNodeName;    //Out数据结点名

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvDnFuncMapEN()
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
public clsvDnFuncMapEN(string strDnFuncMapId)
 {
strDnFuncMapId = strDnFuncMapId.Replace("'", "''");
if (strDnFuncMapId.Length > 8)
{
throw new Exception("在表:vDnFuncMap中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strDnFuncMapId)  ==  true)
{
throw new Exception("在表:vDnFuncMap中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convDnFuncMap.DnFuncMapId)
{
return mstrDnFuncMapId;
}
else if (strAttributeName  ==  convDnFuncMap.InDataNodeId)
{
return mlngInDataNodeId;
}
else if (strAttributeName  ==  convDnFuncMap.OutDataNodeId)
{
return mlngOutDataNodeId;
}
else if (strAttributeName  ==  convDnFuncMap.AssociationMappingId)
{
return mstrAssociationMappingId;
}
else if (strAttributeName  ==  convDnFuncMap.AssociationMappingName)
{
return mstrAssociationMappingName;
}
else if (strAttributeName  ==  convDnFuncMap.FuncMapModeId)
{
return mstrFuncMapModeId;
}
else if (strAttributeName  ==  convDnFuncMap.FuncMapModeName)
{
return mstrFuncMapModeName;
}
else if (strAttributeName  ==  convDnFuncMap.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  convDnFuncMap.DnFunctionId)
{
return mstrDnFunctionId;
}
else if (strAttributeName  ==  convDnFuncMap.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convDnFuncMap.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convDnFuncMap.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convDnFuncMap.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convDnFuncMap.InDataNodeName)
{
return mstrInDataNodeName;
}
else if (strAttributeName  ==  convDnFuncMap.OutDataNodeName)
{
return mstrOutDataNodeName;
}
return null;
}
set
{
if (strAttributeName  ==  convDnFuncMap.DnFuncMapId)
{
mstrDnFuncMapId = value.ToString();
 AddUpdatedFld(convDnFuncMap.DnFuncMapId);
}
else if (strAttributeName  ==  convDnFuncMap.InDataNodeId)
{
mlngInDataNodeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convDnFuncMap.InDataNodeId);
}
else if (strAttributeName  ==  convDnFuncMap.OutDataNodeId)
{
mlngOutDataNodeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convDnFuncMap.OutDataNodeId);
}
else if (strAttributeName  ==  convDnFuncMap.AssociationMappingId)
{
mstrAssociationMappingId = value.ToString();
 AddUpdatedFld(convDnFuncMap.AssociationMappingId);
}
else if (strAttributeName  ==  convDnFuncMap.AssociationMappingName)
{
mstrAssociationMappingName = value.ToString();
 AddUpdatedFld(convDnFuncMap.AssociationMappingName);
}
else if (strAttributeName  ==  convDnFuncMap.FuncMapModeId)
{
mstrFuncMapModeId = value.ToString();
 AddUpdatedFld(convDnFuncMap.FuncMapModeId);
}
else if (strAttributeName  ==  convDnFuncMap.FuncMapModeName)
{
mstrFuncMapModeName = value.ToString();
 AddUpdatedFld(convDnFuncMap.FuncMapModeName);
}
else if (strAttributeName  ==  convDnFuncMap.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(convDnFuncMap.TabId);
}
else if (strAttributeName  ==  convDnFuncMap.DnFunctionId)
{
mstrDnFunctionId = value.ToString();
 AddUpdatedFld(convDnFuncMap.DnFunctionId);
}
else if (strAttributeName  ==  convDnFuncMap.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convDnFuncMap.PrjId);
}
else if (strAttributeName  ==  convDnFuncMap.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convDnFuncMap.UpdDate);
}
else if (strAttributeName  ==  convDnFuncMap.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convDnFuncMap.UpdUser);
}
else if (strAttributeName  ==  convDnFuncMap.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convDnFuncMap.Memo);
}
else if (strAttributeName  ==  convDnFuncMap.InDataNodeName)
{
mstrInDataNodeName = value.ToString();
 AddUpdatedFld(convDnFuncMap.InDataNodeName);
}
else if (strAttributeName  ==  convDnFuncMap.OutDataNodeName)
{
mstrOutDataNodeName = value.ToString();
 AddUpdatedFld(convDnFuncMap.OutDataNodeName);
}
}
}
public object this[int intIndex]
{
get
{
if (convDnFuncMap.DnFuncMapId  ==  _AttributeName[intIndex])
{
return mstrDnFuncMapId;
}
else if (convDnFuncMap.InDataNodeId  ==  _AttributeName[intIndex])
{
return mlngInDataNodeId;
}
else if (convDnFuncMap.OutDataNodeId  ==  _AttributeName[intIndex])
{
return mlngOutDataNodeId;
}
else if (convDnFuncMap.AssociationMappingId  ==  _AttributeName[intIndex])
{
return mstrAssociationMappingId;
}
else if (convDnFuncMap.AssociationMappingName  ==  _AttributeName[intIndex])
{
return mstrAssociationMappingName;
}
else if (convDnFuncMap.FuncMapModeId  ==  _AttributeName[intIndex])
{
return mstrFuncMapModeId;
}
else if (convDnFuncMap.FuncMapModeName  ==  _AttributeName[intIndex])
{
return mstrFuncMapModeName;
}
else if (convDnFuncMap.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (convDnFuncMap.DnFunctionId  ==  _AttributeName[intIndex])
{
return mstrDnFunctionId;
}
else if (convDnFuncMap.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convDnFuncMap.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convDnFuncMap.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convDnFuncMap.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (convDnFuncMap.InDataNodeName  ==  _AttributeName[intIndex])
{
return mstrInDataNodeName;
}
else if (convDnFuncMap.OutDataNodeName  ==  _AttributeName[intIndex])
{
return mstrOutDataNodeName;
}
return null;
}
set
{
if (convDnFuncMap.DnFuncMapId  ==  _AttributeName[intIndex])
{
mstrDnFuncMapId = value.ToString();
 AddUpdatedFld(convDnFuncMap.DnFuncMapId);
}
else if (convDnFuncMap.InDataNodeId  ==  _AttributeName[intIndex])
{
mlngInDataNodeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convDnFuncMap.InDataNodeId);
}
else if (convDnFuncMap.OutDataNodeId  ==  _AttributeName[intIndex])
{
mlngOutDataNodeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convDnFuncMap.OutDataNodeId);
}
else if (convDnFuncMap.AssociationMappingId  ==  _AttributeName[intIndex])
{
mstrAssociationMappingId = value.ToString();
 AddUpdatedFld(convDnFuncMap.AssociationMappingId);
}
else if (convDnFuncMap.AssociationMappingName  ==  _AttributeName[intIndex])
{
mstrAssociationMappingName = value.ToString();
 AddUpdatedFld(convDnFuncMap.AssociationMappingName);
}
else if (convDnFuncMap.FuncMapModeId  ==  _AttributeName[intIndex])
{
mstrFuncMapModeId = value.ToString();
 AddUpdatedFld(convDnFuncMap.FuncMapModeId);
}
else if (convDnFuncMap.FuncMapModeName  ==  _AttributeName[intIndex])
{
mstrFuncMapModeName = value.ToString();
 AddUpdatedFld(convDnFuncMap.FuncMapModeName);
}
else if (convDnFuncMap.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(convDnFuncMap.TabId);
}
else if (convDnFuncMap.DnFunctionId  ==  _AttributeName[intIndex])
{
mstrDnFunctionId = value.ToString();
 AddUpdatedFld(convDnFuncMap.DnFunctionId);
}
else if (convDnFuncMap.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convDnFuncMap.PrjId);
}
else if (convDnFuncMap.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convDnFuncMap.UpdDate);
}
else if (convDnFuncMap.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convDnFuncMap.UpdUser);
}
else if (convDnFuncMap.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convDnFuncMap.Memo);
}
else if (convDnFuncMap.InDataNodeName  ==  _AttributeName[intIndex])
{
mstrInDataNodeName = value.ToString();
 AddUpdatedFld(convDnFuncMap.InDataNodeName);
}
else if (convDnFuncMap.OutDataNodeName  ==  _AttributeName[intIndex])
{
mstrOutDataNodeName = value.ToString();
 AddUpdatedFld(convDnFuncMap.OutDataNodeName);
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
 AddUpdatedFld(convDnFuncMap.DnFuncMapId);
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
 AddUpdatedFld(convDnFuncMap.InDataNodeId);
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
 AddUpdatedFld(convDnFuncMap.OutDataNodeId);
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
 AddUpdatedFld(convDnFuncMap.AssociationMappingId);
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
 AddUpdatedFld(convDnFuncMap.AssociationMappingName);
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
 AddUpdatedFld(convDnFuncMap.FuncMapModeId);
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
 AddUpdatedFld(convDnFuncMap.FuncMapModeName);
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
 AddUpdatedFld(convDnFuncMap.TabId);
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
 AddUpdatedFld(convDnFuncMap.DnFunctionId);
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
 AddUpdatedFld(convDnFuncMap.PrjId);
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
 AddUpdatedFld(convDnFuncMap.UpdDate);
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
 AddUpdatedFld(convDnFuncMap.UpdUser);
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
 AddUpdatedFld(convDnFuncMap.Memo);
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
 AddUpdatedFld(convDnFuncMap.InDataNodeName);
}
}
/// <summary>
/// Out数据结点名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
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
 AddUpdatedFld(convDnFuncMap.OutDataNodeName);
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
 /// v结点函数映射(vDnFuncMap)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convDnFuncMap
{
public const string _CurrTabName = "vDnFuncMap"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "DnFuncMapId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"DnFuncMapId", "InDataNodeId", "OutDataNodeId", "AssociationMappingId", "AssociationMappingName", "FuncMapModeId", "FuncMapModeName", "TabId", "DnFunctionId", "PrjId", "UpdDate", "UpdUser", "Memo", "InDataNodeName", "OutDataNodeName"};
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