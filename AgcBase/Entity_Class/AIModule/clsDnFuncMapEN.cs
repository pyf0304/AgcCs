
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDnFuncMapEN
 表名:DnFuncMap(00050549)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:27:35
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
 /// 表DnFuncMap的关键字(DnFuncMapId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_DnFuncMapId_DnFuncMap
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
public K_DnFuncMapId_DnFuncMap(string strDnFuncMapId)
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
 /// <returns>返回:[K_DnFuncMapId_DnFuncMap]类型的对象</returns>
public static implicit operator K_DnFuncMapId_DnFuncMap(string value)
{
return new K_DnFuncMapId_DnFuncMap(value);
}
}
 /// <summary>
 /// 结点函数映射(DnFuncMap)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsDnFuncMapEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "DnFuncMap"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "DnFuncMapId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = "DnFuncMapId in (select DnFuncMapId from DnFuncMapCmPrjIdRela where CmPrjId='{0}')"; //前台条件格式串
protected const int _AttributeCount = 13;
public static string[] _AttributeName = new string[] {"DnFuncMapId", "InDataNodeId", "OutDataNodeId", "AssociationMappingId", "FuncMapModeId", "TabId", "DnFunctionId", "ErrMsg", "PrjId", "UsedTimes", "UpdDate", "UpdUser", "Memo"};

protected string mstrDnFuncMapId;    //函数映射Id
protected long mlngInDataNodeId;    //In数据结点Id
protected long mlngOutDataNodeId;    //Out数据结点Id
protected string mstrAssociationMappingId;    //关联关系映射Id
protected string mstrFuncMapModeId;    //函数映射模式Id
protected string mstrTabId;    //表ID
protected string mstrDnFunctionId;    //DN函数Id
protected string mstrErrMsg;    //错误信息
protected string mstrPrjId;    //工程Id
protected int? mintUsedTimes;    //使用次数
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsDnFuncMapEN()
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
public clsDnFuncMapEN(string strDnFuncMapId)
 {
strDnFuncMapId = strDnFuncMapId.Replace("'", "''");
if (strDnFuncMapId.Length > 8)
{
throw new Exception("在表:DnFuncMap中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strDnFuncMapId)  ==  true)
{
throw new Exception("在表:DnFuncMap中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  conDnFuncMap.DnFuncMapId)
{
return mstrDnFuncMapId;
}
else if (strAttributeName  ==  conDnFuncMap.InDataNodeId)
{
return mlngInDataNodeId;
}
else if (strAttributeName  ==  conDnFuncMap.OutDataNodeId)
{
return mlngOutDataNodeId;
}
else if (strAttributeName  ==  conDnFuncMap.AssociationMappingId)
{
return mstrAssociationMappingId;
}
else if (strAttributeName  ==  conDnFuncMap.FuncMapModeId)
{
return mstrFuncMapModeId;
}
else if (strAttributeName  ==  conDnFuncMap.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  conDnFuncMap.DnFunctionId)
{
return mstrDnFunctionId;
}
else if (strAttributeName  ==  conDnFuncMap.ErrMsg)
{
return mstrErrMsg;
}
else if (strAttributeName  ==  conDnFuncMap.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conDnFuncMap.UsedTimes)
{
return mintUsedTimes;
}
else if (strAttributeName  ==  conDnFuncMap.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conDnFuncMap.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conDnFuncMap.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conDnFuncMap.DnFuncMapId)
{
mstrDnFuncMapId = value.ToString();
 AddUpdatedFld(conDnFuncMap.DnFuncMapId);
}
else if (strAttributeName  ==  conDnFuncMap.InDataNodeId)
{
mlngInDataNodeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conDnFuncMap.InDataNodeId);
}
else if (strAttributeName  ==  conDnFuncMap.OutDataNodeId)
{
mlngOutDataNodeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conDnFuncMap.OutDataNodeId);
}
else if (strAttributeName  ==  conDnFuncMap.AssociationMappingId)
{
mstrAssociationMappingId = value.ToString();
 AddUpdatedFld(conDnFuncMap.AssociationMappingId);
}
else if (strAttributeName  ==  conDnFuncMap.FuncMapModeId)
{
mstrFuncMapModeId = value.ToString();
 AddUpdatedFld(conDnFuncMap.FuncMapModeId);
}
else if (strAttributeName  ==  conDnFuncMap.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(conDnFuncMap.TabId);
}
else if (strAttributeName  ==  conDnFuncMap.DnFunctionId)
{
mstrDnFunctionId = value.ToString();
 AddUpdatedFld(conDnFuncMap.DnFunctionId);
}
else if (strAttributeName  ==  conDnFuncMap.ErrMsg)
{
mstrErrMsg = value.ToString();
 AddUpdatedFld(conDnFuncMap.ErrMsg);
}
else if (strAttributeName  ==  conDnFuncMap.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conDnFuncMap.PrjId);
}
else if (strAttributeName  ==  conDnFuncMap.UsedTimes)
{
mintUsedTimes = TransNullToInt(value.ToString());
 AddUpdatedFld(conDnFuncMap.UsedTimes);
}
else if (strAttributeName  ==  conDnFuncMap.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conDnFuncMap.UpdDate);
}
else if (strAttributeName  ==  conDnFuncMap.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conDnFuncMap.UpdUser);
}
else if (strAttributeName  ==  conDnFuncMap.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDnFuncMap.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conDnFuncMap.DnFuncMapId  ==  _AttributeName[intIndex])
{
return mstrDnFuncMapId;
}
else if (conDnFuncMap.InDataNodeId  ==  _AttributeName[intIndex])
{
return mlngInDataNodeId;
}
else if (conDnFuncMap.OutDataNodeId  ==  _AttributeName[intIndex])
{
return mlngOutDataNodeId;
}
else if (conDnFuncMap.AssociationMappingId  ==  _AttributeName[intIndex])
{
return mstrAssociationMappingId;
}
else if (conDnFuncMap.FuncMapModeId  ==  _AttributeName[intIndex])
{
return mstrFuncMapModeId;
}
else if (conDnFuncMap.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (conDnFuncMap.DnFunctionId  ==  _AttributeName[intIndex])
{
return mstrDnFunctionId;
}
else if (conDnFuncMap.ErrMsg  ==  _AttributeName[intIndex])
{
return mstrErrMsg;
}
else if (conDnFuncMap.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conDnFuncMap.UsedTimes  ==  _AttributeName[intIndex])
{
return mintUsedTimes;
}
else if (conDnFuncMap.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conDnFuncMap.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conDnFuncMap.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conDnFuncMap.DnFuncMapId  ==  _AttributeName[intIndex])
{
mstrDnFuncMapId = value.ToString();
 AddUpdatedFld(conDnFuncMap.DnFuncMapId);
}
else if (conDnFuncMap.InDataNodeId  ==  _AttributeName[intIndex])
{
mlngInDataNodeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conDnFuncMap.InDataNodeId);
}
else if (conDnFuncMap.OutDataNodeId  ==  _AttributeName[intIndex])
{
mlngOutDataNodeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conDnFuncMap.OutDataNodeId);
}
else if (conDnFuncMap.AssociationMappingId  ==  _AttributeName[intIndex])
{
mstrAssociationMappingId = value.ToString();
 AddUpdatedFld(conDnFuncMap.AssociationMappingId);
}
else if (conDnFuncMap.FuncMapModeId  ==  _AttributeName[intIndex])
{
mstrFuncMapModeId = value.ToString();
 AddUpdatedFld(conDnFuncMap.FuncMapModeId);
}
else if (conDnFuncMap.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(conDnFuncMap.TabId);
}
else if (conDnFuncMap.DnFunctionId  ==  _AttributeName[intIndex])
{
mstrDnFunctionId = value.ToString();
 AddUpdatedFld(conDnFuncMap.DnFunctionId);
}
else if (conDnFuncMap.ErrMsg  ==  _AttributeName[intIndex])
{
mstrErrMsg = value.ToString();
 AddUpdatedFld(conDnFuncMap.ErrMsg);
}
else if (conDnFuncMap.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conDnFuncMap.PrjId);
}
else if (conDnFuncMap.UsedTimes  ==  _AttributeName[intIndex])
{
mintUsedTimes = TransNullToInt(value.ToString());
 AddUpdatedFld(conDnFuncMap.UsedTimes);
}
else if (conDnFuncMap.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conDnFuncMap.UpdDate);
}
else if (conDnFuncMap.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conDnFuncMap.UpdUser);
}
else if (conDnFuncMap.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDnFuncMap.Memo);
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
 AddUpdatedFld(conDnFuncMap.DnFuncMapId);
}
}
/// <summary>
/// In数据结点Id(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long InDataNodeId
{
get
{
return mlngInDataNodeId;
}
set
{
 mlngInDataNodeId = value;
//记录修改过的字段
 AddUpdatedFld(conDnFuncMap.InDataNodeId);
}
}
/// <summary>
/// Out数据结点Id(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long OutDataNodeId
{
get
{
return mlngOutDataNodeId;
}
set
{
 mlngOutDataNodeId = value;
//记录修改过的字段
 AddUpdatedFld(conDnFuncMap.OutDataNodeId);
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
 AddUpdatedFld(conDnFuncMap.AssociationMappingId);
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
 AddUpdatedFld(conDnFuncMap.FuncMapModeId);
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
 AddUpdatedFld(conDnFuncMap.TabId);
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
 AddUpdatedFld(conDnFuncMap.DnFunctionId);
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
 AddUpdatedFld(conDnFuncMap.ErrMsg);
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
 AddUpdatedFld(conDnFuncMap.PrjId);
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
 AddUpdatedFld(conDnFuncMap.UsedTimes);
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
 AddUpdatedFld(conDnFuncMap.UpdDate);
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
 AddUpdatedFld(conDnFuncMap.UpdUser);
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
 AddUpdatedFld(conDnFuncMap.Memo);
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
 /// 结点函数映射(DnFuncMap)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conDnFuncMap
{
public const string _CurrTabName = "DnFuncMap"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "DnFuncMapId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"DnFuncMapId", "InDataNodeId", "OutDataNodeId", "AssociationMappingId", "FuncMapModeId", "TabId", "DnFunctionId", "ErrMsg", "PrjId", "UsedTimes", "UpdDate", "UpdUser", "Memo"};
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