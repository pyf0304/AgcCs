
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQueryRegionEN
 表名:QueryRegion(00050117)
 * 版本:2023.05.26.1(服务器:PYF-THINKPAD)
 日期:2023/05/27 06:46:07
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcMvc(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:区域管理(RegionManage)
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
 /// 表QueryRegion的关键字(RegionId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_RegionId_QueryRegion
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strRegionId">表关键字</param>
public K_RegionId_QueryRegion(string strRegionId)
{
if (IsValid(strRegionId)) Value = strRegionId;
else
{
Value = null;
}
}
private static bool IsValid(string strRegionId)
{
if (string.IsNullOrEmpty(strRegionId) == true) return false;
if (strRegionId.Length != 10) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_RegionId_QueryRegion]类型的对象</returns>
public static implicit operator K_RegionId_QueryRegion(string value)
{
return new K_RegionId_QueryRegion(value);
}
}
 /// <summary>
 /// 查询区域(QueryRegion)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQueryRegionEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接，如果为空就使用系统默认的连接
public const string _CurrTabName_S = "QueryRegion"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "RegionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string WhereFormat = ""; //条件格式串
protected const int mintAttributeCount = 13;
public static string[] AttributeName = new string[] {"RegionId", "IsUseCtrl", "PrjId", "Memo", "IsSynchToServer", "SynchToServerDate", "SynchToServerUser", "IsSynchToClient", "SynchToClientDate", "SynchToClientUser", "SynSource", "UpdUser", "UpdDate"};

protected string mstrRegionId;    //区域Id
protected bool mbolIsUseCtrl;    //是否使用控件
protected string mstrPrjId;    //工程ID
protected string mstrMemo;    //说明
protected bool mbolIsSynchToServer;    //是否同步到Server
protected string mstrSynchToServerDate;    //同步到Server日期
protected string mstrSynchToServerUser;    //同步到Server用户
protected bool mbolIsSynchToClient;    //是否同步到Client
protected string mstrSynchToClientDate;    //同步到Client库日期
protected string mstrSynchToClientUser;    //同步到Client库用户
protected string mstrSynSource;    //同步来源
protected string mstrUpdUser;    //修改者
protected string mstrUpdDate;    //修改日期

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQueryRegionEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "QueryRegion";
 lstKeyFldNames.Add("RegionId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strRegionId">关键字:区域Id</param>
public clsQueryRegionEN(string strRegionId)
 {
strRegionId = strRegionId.Replace("'", "''");
if (strRegionId.Length > 10)
{
throw new Exception("在表:QueryRegion中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strRegionId)  ==  true)
{
throw new Exception("在表:QueryRegion中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strRegionId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrRegionId = strRegionId;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "QueryRegion";
 lstKeyFldNames.Add("RegionId");
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
if (strAttributeName  ==  conQueryRegion.RegionId)
{
return mstrRegionId;
}
else if (strAttributeName  ==  conQueryRegion.IsUseCtrl)
{
return mbolIsUseCtrl;
}
else if (strAttributeName  ==  conQueryRegion.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conQueryRegion.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conQueryRegion.IsSynchToServer)
{
return mbolIsSynchToServer;
}
else if (strAttributeName  ==  conQueryRegion.SynchToServerDate)
{
return mstrSynchToServerDate;
}
else if (strAttributeName  ==  conQueryRegion.SynchToServerUser)
{
return mstrSynchToServerUser;
}
else if (strAttributeName  ==  conQueryRegion.IsSynchToClient)
{
return mbolIsSynchToClient;
}
else if (strAttributeName  ==  conQueryRegion.SynchToClientDate)
{
return mstrSynchToClientDate;
}
else if (strAttributeName  ==  conQueryRegion.SynchToClientUser)
{
return mstrSynchToClientUser;
}
else if (strAttributeName  ==  conQueryRegion.SynSource)
{
return mstrSynSource;
}
else if (strAttributeName  ==  conQueryRegion.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conQueryRegion.UpdDate)
{
return mstrUpdDate;
}
return null;
}
set
{
if (strAttributeName  ==  conQueryRegion.RegionId)
{
mstrRegionId = value.ToString();
 AddUpdatedFld(conQueryRegion.RegionId);
}
else if (strAttributeName  ==  conQueryRegion.IsUseCtrl)
{
mbolIsUseCtrl = TransNullToBool(value.ToString());
 AddUpdatedFld(conQueryRegion.IsUseCtrl);
}
else if (strAttributeName  ==  conQueryRegion.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conQueryRegion.PrjId);
}
else if (strAttributeName  ==  conQueryRegion.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQueryRegion.Memo);
}
else if (strAttributeName  ==  conQueryRegion.IsSynchToServer)
{
mbolIsSynchToServer = TransNullToBool(value.ToString());
 AddUpdatedFld(conQueryRegion.IsSynchToServer);
}
else if (strAttributeName  ==  conQueryRegion.SynchToServerDate)
{
mstrSynchToServerDate = value.ToString();
 AddUpdatedFld(conQueryRegion.SynchToServerDate);
}
else if (strAttributeName  ==  conQueryRegion.SynchToServerUser)
{
mstrSynchToServerUser = value.ToString();
 AddUpdatedFld(conQueryRegion.SynchToServerUser);
}
else if (strAttributeName  ==  conQueryRegion.IsSynchToClient)
{
mbolIsSynchToClient = TransNullToBool(value.ToString());
 AddUpdatedFld(conQueryRegion.IsSynchToClient);
}
else if (strAttributeName  ==  conQueryRegion.SynchToClientDate)
{
mstrSynchToClientDate = value.ToString();
 AddUpdatedFld(conQueryRegion.SynchToClientDate);
}
else if (strAttributeName  ==  conQueryRegion.SynchToClientUser)
{
mstrSynchToClientUser = value.ToString();
 AddUpdatedFld(conQueryRegion.SynchToClientUser);
}
else if (strAttributeName  ==  conQueryRegion.SynSource)
{
mstrSynSource = value.ToString();
 AddUpdatedFld(conQueryRegion.SynSource);
}
else if (strAttributeName  ==  conQueryRegion.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conQueryRegion.UpdUser);
}
else if (strAttributeName  ==  conQueryRegion.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQueryRegion.UpdDate);
}
}
}
public object this[int intIndex]
{
get
{
if (conQueryRegion.RegionId  ==  AttributeName[intIndex])
{
return mstrRegionId;
}
else if (conQueryRegion.IsUseCtrl  ==  AttributeName[intIndex])
{
return mbolIsUseCtrl;
}
else if (conQueryRegion.PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conQueryRegion.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conQueryRegion.IsSynchToServer  ==  AttributeName[intIndex])
{
return mbolIsSynchToServer;
}
else if (conQueryRegion.SynchToServerDate  ==  AttributeName[intIndex])
{
return mstrSynchToServerDate;
}
else if (conQueryRegion.SynchToServerUser  ==  AttributeName[intIndex])
{
return mstrSynchToServerUser;
}
else if (conQueryRegion.IsSynchToClient  ==  AttributeName[intIndex])
{
return mbolIsSynchToClient;
}
else if (conQueryRegion.SynchToClientDate  ==  AttributeName[intIndex])
{
return mstrSynchToClientDate;
}
else if (conQueryRegion.SynchToClientUser  ==  AttributeName[intIndex])
{
return mstrSynchToClientUser;
}
else if (conQueryRegion.SynSource  ==  AttributeName[intIndex])
{
return mstrSynSource;
}
else if (conQueryRegion.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conQueryRegion.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
return null;
}
set
{
if (conQueryRegion.RegionId  ==  AttributeName[intIndex])
{
mstrRegionId = value.ToString();
 AddUpdatedFld(conQueryRegion.RegionId);
}
else if (conQueryRegion.IsUseCtrl  ==  AttributeName[intIndex])
{
mbolIsUseCtrl = TransNullToBool(value.ToString());
 AddUpdatedFld(conQueryRegion.IsUseCtrl);
}
else if (conQueryRegion.PrjId  ==  AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conQueryRegion.PrjId);
}
else if (conQueryRegion.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQueryRegion.Memo);
}
else if (conQueryRegion.IsSynchToServer  ==  AttributeName[intIndex])
{
mbolIsSynchToServer = TransNullToBool(value.ToString());
 AddUpdatedFld(conQueryRegion.IsSynchToServer);
}
else if (conQueryRegion.SynchToServerDate  ==  AttributeName[intIndex])
{
mstrSynchToServerDate = value.ToString();
 AddUpdatedFld(conQueryRegion.SynchToServerDate);
}
else if (conQueryRegion.SynchToServerUser  ==  AttributeName[intIndex])
{
mstrSynchToServerUser = value.ToString();
 AddUpdatedFld(conQueryRegion.SynchToServerUser);
}
else if (conQueryRegion.IsSynchToClient  ==  AttributeName[intIndex])
{
mbolIsSynchToClient = TransNullToBool(value.ToString());
 AddUpdatedFld(conQueryRegion.IsSynchToClient);
}
else if (conQueryRegion.SynchToClientDate  ==  AttributeName[intIndex])
{
mstrSynchToClientDate = value.ToString();
 AddUpdatedFld(conQueryRegion.SynchToClientDate);
}
else if (conQueryRegion.SynchToClientUser  ==  AttributeName[intIndex])
{
mstrSynchToClientUser = value.ToString();
 AddUpdatedFld(conQueryRegion.SynchToClientUser);
}
else if (conQueryRegion.SynSource  ==  AttributeName[intIndex])
{
mstrSynSource = value.ToString();
 AddUpdatedFld(conQueryRegion.SynSource);
}
else if (conQueryRegion.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conQueryRegion.UpdUser);
}
else if (conQueryRegion.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQueryRegion.UpdDate);
}
}
}

/// <summary>
/// 区域Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RegionId
{
get
{
return mstrRegionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRegionId = value;
}
else
{
 mstrRegionId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQueryRegion.RegionId);
}
}
/// <summary>
/// 是否使用控件(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsUseCtrl
{
get
{
return mbolIsUseCtrl;
}
set
{
 mbolIsUseCtrl = value;
//记录修改过的字段
 AddUpdatedFld(conQueryRegion.IsUseCtrl);
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
 AddUpdatedFld(conQueryRegion.PrjId);
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
 AddUpdatedFld(conQueryRegion.Memo);
}
}
/// <summary>
/// 是否同步到Server(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsSynchToServer
{
get
{
return mbolIsSynchToServer;
}
set
{
 mbolIsSynchToServer = value;
//记录修改过的字段
 AddUpdatedFld(conQueryRegion.IsSynchToServer);
}
}
/// <summary>
/// 同步到Server日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SynchToServerDate
{
get
{
return mstrSynchToServerDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSynchToServerDate = value;
}
else
{
 mstrSynchToServerDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conQueryRegion.SynchToServerDate);
}
}
/// <summary>
/// 同步到Server用户(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SynchToServerUser
{
get
{
return mstrSynchToServerUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSynchToServerUser = value;
}
else
{
 mstrSynchToServerUser = value;
}
//记录修改过的字段
 AddUpdatedFld(conQueryRegion.SynchToServerUser);
}
}
/// <summary>
/// 是否同步到Client(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsSynchToClient
{
get
{
return mbolIsSynchToClient;
}
set
{
 mbolIsSynchToClient = value;
//记录修改过的字段
 AddUpdatedFld(conQueryRegion.IsSynchToClient);
}
}
/// <summary>
/// 同步到Client库日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SynchToClientDate
{
get
{
return mstrSynchToClientDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSynchToClientDate = value;
}
else
{
 mstrSynchToClientDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conQueryRegion.SynchToClientDate);
}
}
/// <summary>
/// 同步到Client库用户(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SynchToClientUser
{
get
{
return mstrSynchToClientUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSynchToClientUser = value;
}
else
{
 mstrSynchToClientUser = value;
}
//记录修改过的字段
 AddUpdatedFld(conQueryRegion.SynchToClientUser);
}
}
/// <summary>
/// 同步来源(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SynSource
{
get
{
return mstrSynSource;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSynSource = value;
}
else
{
 mstrSynSource = value;
}
//记录修改过的字段
 AddUpdatedFld(conQueryRegion.SynSource);
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
 AddUpdatedFld(conQueryRegion.UpdUser);
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
 AddUpdatedFld(conQueryRegion.UpdDate);
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
  return mstrRegionId;
 }
 }
}
 /// <summary>
 /// 查询区域(QueryRegion)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conQueryRegion
{
public const string _CurrTabName_S = "QueryRegion"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "RegionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"RegionId", "IsUseCtrl", "PrjId", "Memo", "IsSynchToServer", "SynchToServerDate", "SynchToServerUser", "IsSynchToClient", "SynchToClientDate", "SynchToClientUser", "SynSource", "UpdUser", "UpdDate"};
//以下是属性变量


 /// <summary>
 /// 常量:"RegionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RegionId = "RegionId";    //区域Id

 /// <summary>
 /// 常量:"IsUseCtrl"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsUseCtrl = "IsUseCtrl";    //是否使用控件

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程ID

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明

 /// <summary>
 /// 常量:"IsSynchToServer"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSynchToServer = "IsSynchToServer";    //是否同步到Server

 /// <summary>
 /// 常量:"SynchToServerDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SynchToServerDate = "SynchToServerDate";    //同步到Server日期

 /// <summary>
 /// 常量:"SynchToServerUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SynchToServerUser = "SynchToServerUser";    //同步到Server用户

 /// <summary>
 /// 常量:"IsSynchToClient"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSynchToClient = "IsSynchToClient";    //是否同步到Client

 /// <summary>
 /// 常量:"SynchToClientDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SynchToClientDate = "SynchToClientDate";    //同步到Client库日期

 /// <summary>
 /// 常量:"SynchToClientUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SynchToClientUser = "SynchToClientUser";    //同步到Client库用户

 /// <summary>
 /// 常量:"SynSource"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SynSource = "SynSource";    //同步来源

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改者

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期
}

}