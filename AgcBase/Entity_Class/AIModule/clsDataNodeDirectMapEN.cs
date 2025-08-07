
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDataNodeDirectMapEN
 表名:DataNodeDirectMap(00050570)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:32:25
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
 /// 表DataNodeDirectMap的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_DataNodeDirectMap
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngmId">表关键字</param>
public K_mId_DataNodeDirectMap(long lngmId)
{
if (IsValid(lngmId)) Value = lngmId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngmId)
{
if (lngmId == 0) return false;
if (lngmId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_mId_DataNodeDirectMap]类型的对象</returns>
public static implicit operator K_mId_DataNodeDirectMap(long value)
{
return new K_mId_DataNodeDirectMap(value);
}
}
 /// <summary>
 /// 数据结点直接映射(DataNodeDirectMap)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsDataNodeDirectMapEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "DataNodeDirectMap"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 11;
public static string[] _AttributeName = new string[] {"mId", "InDataNodeId", "OutDataNodeId", "AssociationMappingId", "FuncMapModeId", "TabId", "DnFunctionId", "PrjId", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected long mlngInDataNodeId;    //In数据结点Id
protected long mlngOutDataNodeId;    //Out数据结点Id
protected string mstrAssociationMappingId;    //关联关系映射Id
protected string mstrFuncMapModeId;    //函数映射模式Id
protected string mstrTabId;    //表ID
protected string mstrDnFunctionId;    //DN函数Id
protected string mstrPrjId;    //工程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsDataNodeDirectMapEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:mId</param>
public clsDataNodeDirectMapEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
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
if (strAttributeName  ==  conDataNodeDirectMap.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conDataNodeDirectMap.InDataNodeId)
{
return mlngInDataNodeId;
}
else if (strAttributeName  ==  conDataNodeDirectMap.OutDataNodeId)
{
return mlngOutDataNodeId;
}
else if (strAttributeName  ==  conDataNodeDirectMap.AssociationMappingId)
{
return mstrAssociationMappingId;
}
else if (strAttributeName  ==  conDataNodeDirectMap.FuncMapModeId)
{
return mstrFuncMapModeId;
}
else if (strAttributeName  ==  conDataNodeDirectMap.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  conDataNodeDirectMap.DnFunctionId)
{
return mstrDnFunctionId;
}
else if (strAttributeName  ==  conDataNodeDirectMap.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conDataNodeDirectMap.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conDataNodeDirectMap.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conDataNodeDirectMap.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conDataNodeDirectMap.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conDataNodeDirectMap.mId);
}
else if (strAttributeName  ==  conDataNodeDirectMap.InDataNodeId)
{
mlngInDataNodeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conDataNodeDirectMap.InDataNodeId);
}
else if (strAttributeName  ==  conDataNodeDirectMap.OutDataNodeId)
{
mlngOutDataNodeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conDataNodeDirectMap.OutDataNodeId);
}
else if (strAttributeName  ==  conDataNodeDirectMap.AssociationMappingId)
{
mstrAssociationMappingId = value.ToString();
 AddUpdatedFld(conDataNodeDirectMap.AssociationMappingId);
}
else if (strAttributeName  ==  conDataNodeDirectMap.FuncMapModeId)
{
mstrFuncMapModeId = value.ToString();
 AddUpdatedFld(conDataNodeDirectMap.FuncMapModeId);
}
else if (strAttributeName  ==  conDataNodeDirectMap.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(conDataNodeDirectMap.TabId);
}
else if (strAttributeName  ==  conDataNodeDirectMap.DnFunctionId)
{
mstrDnFunctionId = value.ToString();
 AddUpdatedFld(conDataNodeDirectMap.DnFunctionId);
}
else if (strAttributeName  ==  conDataNodeDirectMap.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conDataNodeDirectMap.PrjId);
}
else if (strAttributeName  ==  conDataNodeDirectMap.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conDataNodeDirectMap.UpdDate);
}
else if (strAttributeName  ==  conDataNodeDirectMap.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conDataNodeDirectMap.UpdUser);
}
else if (strAttributeName  ==  conDataNodeDirectMap.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDataNodeDirectMap.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conDataNodeDirectMap.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (conDataNodeDirectMap.InDataNodeId  ==  _AttributeName[intIndex])
{
return mlngInDataNodeId;
}
else if (conDataNodeDirectMap.OutDataNodeId  ==  _AttributeName[intIndex])
{
return mlngOutDataNodeId;
}
else if (conDataNodeDirectMap.AssociationMappingId  ==  _AttributeName[intIndex])
{
return mstrAssociationMappingId;
}
else if (conDataNodeDirectMap.FuncMapModeId  ==  _AttributeName[intIndex])
{
return mstrFuncMapModeId;
}
else if (conDataNodeDirectMap.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (conDataNodeDirectMap.DnFunctionId  ==  _AttributeName[intIndex])
{
return mstrDnFunctionId;
}
else if (conDataNodeDirectMap.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conDataNodeDirectMap.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conDataNodeDirectMap.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conDataNodeDirectMap.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conDataNodeDirectMap.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conDataNodeDirectMap.mId);
}
else if (conDataNodeDirectMap.InDataNodeId  ==  _AttributeName[intIndex])
{
mlngInDataNodeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conDataNodeDirectMap.InDataNodeId);
}
else if (conDataNodeDirectMap.OutDataNodeId  ==  _AttributeName[intIndex])
{
mlngOutDataNodeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conDataNodeDirectMap.OutDataNodeId);
}
else if (conDataNodeDirectMap.AssociationMappingId  ==  _AttributeName[intIndex])
{
mstrAssociationMappingId = value.ToString();
 AddUpdatedFld(conDataNodeDirectMap.AssociationMappingId);
}
else if (conDataNodeDirectMap.FuncMapModeId  ==  _AttributeName[intIndex])
{
mstrFuncMapModeId = value.ToString();
 AddUpdatedFld(conDataNodeDirectMap.FuncMapModeId);
}
else if (conDataNodeDirectMap.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(conDataNodeDirectMap.TabId);
}
else if (conDataNodeDirectMap.DnFunctionId  ==  _AttributeName[intIndex])
{
mstrDnFunctionId = value.ToString();
 AddUpdatedFld(conDataNodeDirectMap.DnFunctionId);
}
else if (conDataNodeDirectMap.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conDataNodeDirectMap.PrjId);
}
else if (conDataNodeDirectMap.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conDataNodeDirectMap.UpdDate);
}
else if (conDataNodeDirectMap.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conDataNodeDirectMap.UpdUser);
}
else if (conDataNodeDirectMap.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDataNodeDirectMap.Memo);
}
}
}

/// <summary>
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long mId
{
get
{
return mlngmId;
}
set
{
 mlngmId = value;
//记录修改过的字段
 AddUpdatedFld(conDataNodeDirectMap.mId);
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
 AddUpdatedFld(conDataNodeDirectMap.InDataNodeId);
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
 AddUpdatedFld(conDataNodeDirectMap.OutDataNodeId);
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
 AddUpdatedFld(conDataNodeDirectMap.AssociationMappingId);
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
 AddUpdatedFld(conDataNodeDirectMap.FuncMapModeId);
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
 AddUpdatedFld(conDataNodeDirectMap.TabId);
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
 AddUpdatedFld(conDataNodeDirectMap.DnFunctionId);
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
 AddUpdatedFld(conDataNodeDirectMap.PrjId);
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
 AddUpdatedFld(conDataNodeDirectMap.UpdDate);
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
 AddUpdatedFld(conDataNodeDirectMap.UpdUser);
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
 AddUpdatedFld(conDataNodeDirectMap.Memo);
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
  return mlngmId.ToString();
 }
 }
}
 /// <summary>
 /// 数据结点直接映射(DataNodeDirectMap)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conDataNodeDirectMap
{
public const string _CurrTabName = "DataNodeDirectMap"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "InDataNodeId", "OutDataNodeId", "AssociationMappingId", "FuncMapModeId", "TabId", "DnFunctionId", "PrjId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

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