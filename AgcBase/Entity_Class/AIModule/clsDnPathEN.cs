
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDnPathEN
 表名:DnPath(00050591)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:00:51
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
 /// 表DnPath的关键字(DnPathId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_DnPathId_DnPath
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strDnPathId">表关键字</param>
public K_DnPathId_DnPath(string strDnPathId)
{
if (IsValid(strDnPathId)) Value = strDnPathId;
else
{
Value = null;
}
}
private static bool IsValid(string strDnPathId)
{
if (string.IsNullOrEmpty(strDnPathId) == true) return false;
if (strDnPathId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_DnPathId_DnPath]类型的对象</returns>
public static implicit operator K_DnPathId_DnPath(string value)
{
return new K_DnPathId_DnPath(value);
}
}
 /// <summary>
 /// 数据结点路径(DnPath)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsDnPathEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "DnPath"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "DnPathId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = "DnPathId in (select DnPathId from DnPathCmPrjIdRela where CmPrjId='{0}')"; //前台条件格式串
protected const int _AttributeCount = 16;
public static string[] _AttributeName = new string[] {"DnPathId", "DnPathName", "InDataNodeId", "OutDataNodeId", "DnPathNodeLst", "DnPathNodeLstV2", "AssociationMappingId", "IsHasErr", "EdgeNum", "ErrMsg", "InUse", "IsExistPath", "PrjId", "UpdDate", "UpdUser", "Memo"};

protected string mstrDnPathId;    //DN路径Id
protected string mstrDnPathName;    //DN路径名
protected long mlngInDataNodeId;    //In数据结点Id
protected long mlngOutDataNodeId;    //Out数据结点Id
protected string mstrDnPathNodeLst;    //路径结点列表
protected string mstrDnPathNodeLstV2;    //路径结点列表V2
protected string mstrAssociationMappingId;    //关联关系映射Id
protected bool mbolIsHasErr;    //是否有错
protected int? mintEdgeNum;    //边数
protected string mstrErrMsg;    //错误信息
protected bool mbolInUse;    //是否在用
protected bool mbolIsExistPath;    //是否存在路径
protected string mstrPrjId;    //工程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsDnPathEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("DnPathId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strDnPathId">关键字:DN路径Id</param>
public clsDnPathEN(string strDnPathId)
 {
strDnPathId = strDnPathId.Replace("'", "''");
if (strDnPathId.Length > 8)
{
throw new Exception("在表:DnPath中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strDnPathId)  ==  true)
{
throw new Exception("在表:DnPath中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strDnPathId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrDnPathId = strDnPathId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("DnPathId");
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
if (strAttributeName  ==  conDnPath.DnPathId)
{
return mstrDnPathId;
}
else if (strAttributeName  ==  conDnPath.DnPathName)
{
return mstrDnPathName;
}
else if (strAttributeName  ==  conDnPath.InDataNodeId)
{
return mlngInDataNodeId;
}
else if (strAttributeName  ==  conDnPath.OutDataNodeId)
{
return mlngOutDataNodeId;
}
else if (strAttributeName  ==  conDnPath.DnPathNodeLst)
{
return mstrDnPathNodeLst;
}
else if (strAttributeName  ==  conDnPath.DnPathNodeLstV2)
{
return mstrDnPathNodeLstV2;
}
else if (strAttributeName  ==  conDnPath.AssociationMappingId)
{
return mstrAssociationMappingId;
}
else if (strAttributeName  ==  conDnPath.IsHasErr)
{
return mbolIsHasErr;
}
else if (strAttributeName  ==  conDnPath.EdgeNum)
{
return mintEdgeNum;
}
else if (strAttributeName  ==  conDnPath.ErrMsg)
{
return mstrErrMsg;
}
else if (strAttributeName  ==  conDnPath.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  conDnPath.IsExistPath)
{
return mbolIsExistPath;
}
else if (strAttributeName  ==  conDnPath.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conDnPath.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conDnPath.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conDnPath.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conDnPath.DnPathId)
{
mstrDnPathId = value.ToString();
 AddUpdatedFld(conDnPath.DnPathId);
}
else if (strAttributeName  ==  conDnPath.DnPathName)
{
mstrDnPathName = value.ToString();
 AddUpdatedFld(conDnPath.DnPathName);
}
else if (strAttributeName  ==  conDnPath.InDataNodeId)
{
mlngInDataNodeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conDnPath.InDataNodeId);
}
else if (strAttributeName  ==  conDnPath.OutDataNodeId)
{
mlngOutDataNodeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conDnPath.OutDataNodeId);
}
else if (strAttributeName  ==  conDnPath.DnPathNodeLst)
{
mstrDnPathNodeLst = value.ToString();
 AddUpdatedFld(conDnPath.DnPathNodeLst);
}
else if (strAttributeName  ==  conDnPath.DnPathNodeLstV2)
{
mstrDnPathNodeLstV2 = value.ToString();
 AddUpdatedFld(conDnPath.DnPathNodeLstV2);
}
else if (strAttributeName  ==  conDnPath.AssociationMappingId)
{
mstrAssociationMappingId = value.ToString();
 AddUpdatedFld(conDnPath.AssociationMappingId);
}
else if (strAttributeName  ==  conDnPath.IsHasErr)
{
mbolIsHasErr = TransNullToBool(value.ToString());
 AddUpdatedFld(conDnPath.IsHasErr);
}
else if (strAttributeName  ==  conDnPath.EdgeNum)
{
mintEdgeNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conDnPath.EdgeNum);
}
else if (strAttributeName  ==  conDnPath.ErrMsg)
{
mstrErrMsg = value.ToString();
 AddUpdatedFld(conDnPath.ErrMsg);
}
else if (strAttributeName  ==  conDnPath.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conDnPath.InUse);
}
else if (strAttributeName  ==  conDnPath.IsExistPath)
{
mbolIsExistPath = TransNullToBool(value.ToString());
 AddUpdatedFld(conDnPath.IsExistPath);
}
else if (strAttributeName  ==  conDnPath.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conDnPath.PrjId);
}
else if (strAttributeName  ==  conDnPath.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conDnPath.UpdDate);
}
else if (strAttributeName  ==  conDnPath.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conDnPath.UpdUser);
}
else if (strAttributeName  ==  conDnPath.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDnPath.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conDnPath.DnPathId  ==  _AttributeName[intIndex])
{
return mstrDnPathId;
}
else if (conDnPath.DnPathName  ==  _AttributeName[intIndex])
{
return mstrDnPathName;
}
else if (conDnPath.InDataNodeId  ==  _AttributeName[intIndex])
{
return mlngInDataNodeId;
}
else if (conDnPath.OutDataNodeId  ==  _AttributeName[intIndex])
{
return mlngOutDataNodeId;
}
else if (conDnPath.DnPathNodeLst  ==  _AttributeName[intIndex])
{
return mstrDnPathNodeLst;
}
else if (conDnPath.DnPathNodeLstV2  ==  _AttributeName[intIndex])
{
return mstrDnPathNodeLstV2;
}
else if (conDnPath.AssociationMappingId  ==  _AttributeName[intIndex])
{
return mstrAssociationMappingId;
}
else if (conDnPath.IsHasErr  ==  _AttributeName[intIndex])
{
return mbolIsHasErr;
}
else if (conDnPath.EdgeNum  ==  _AttributeName[intIndex])
{
return mintEdgeNum;
}
else if (conDnPath.ErrMsg  ==  _AttributeName[intIndex])
{
return mstrErrMsg;
}
else if (conDnPath.InUse  ==  _AttributeName[intIndex])
{
return mbolInUse;
}
else if (conDnPath.IsExistPath  ==  _AttributeName[intIndex])
{
return mbolIsExistPath;
}
else if (conDnPath.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conDnPath.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conDnPath.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conDnPath.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conDnPath.DnPathId  ==  _AttributeName[intIndex])
{
mstrDnPathId = value.ToString();
 AddUpdatedFld(conDnPath.DnPathId);
}
else if (conDnPath.DnPathName  ==  _AttributeName[intIndex])
{
mstrDnPathName = value.ToString();
 AddUpdatedFld(conDnPath.DnPathName);
}
else if (conDnPath.InDataNodeId  ==  _AttributeName[intIndex])
{
mlngInDataNodeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conDnPath.InDataNodeId);
}
else if (conDnPath.OutDataNodeId  ==  _AttributeName[intIndex])
{
mlngOutDataNodeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conDnPath.OutDataNodeId);
}
else if (conDnPath.DnPathNodeLst  ==  _AttributeName[intIndex])
{
mstrDnPathNodeLst = value.ToString();
 AddUpdatedFld(conDnPath.DnPathNodeLst);
}
else if (conDnPath.DnPathNodeLstV2  ==  _AttributeName[intIndex])
{
mstrDnPathNodeLstV2 = value.ToString();
 AddUpdatedFld(conDnPath.DnPathNodeLstV2);
}
else if (conDnPath.AssociationMappingId  ==  _AttributeName[intIndex])
{
mstrAssociationMappingId = value.ToString();
 AddUpdatedFld(conDnPath.AssociationMappingId);
}
else if (conDnPath.IsHasErr  ==  _AttributeName[intIndex])
{
mbolIsHasErr = TransNullToBool(value.ToString());
 AddUpdatedFld(conDnPath.IsHasErr);
}
else if (conDnPath.EdgeNum  ==  _AttributeName[intIndex])
{
mintEdgeNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conDnPath.EdgeNum);
}
else if (conDnPath.ErrMsg  ==  _AttributeName[intIndex])
{
mstrErrMsg = value.ToString();
 AddUpdatedFld(conDnPath.ErrMsg);
}
else if (conDnPath.InUse  ==  _AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conDnPath.InUse);
}
else if (conDnPath.IsExistPath  ==  _AttributeName[intIndex])
{
mbolIsExistPath = TransNullToBool(value.ToString());
 AddUpdatedFld(conDnPath.IsExistPath);
}
else if (conDnPath.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conDnPath.PrjId);
}
else if (conDnPath.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conDnPath.UpdDate);
}
else if (conDnPath.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conDnPath.UpdUser);
}
else if (conDnPath.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDnPath.Memo);
}
}
}

/// <summary>
/// DN路径Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DnPathId
{
get
{
return mstrDnPathId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDnPathId = value;
}
else
{
 mstrDnPathId = value;
}
//记录修改过的字段
 AddUpdatedFld(conDnPath.DnPathId);
}
}
/// <summary>
/// DN路径名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DnPathName
{
get
{
return mstrDnPathName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDnPathName = value;
}
else
{
 mstrDnPathName = value;
}
//记录修改过的字段
 AddUpdatedFld(conDnPath.DnPathName);
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
 AddUpdatedFld(conDnPath.InDataNodeId);
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
 AddUpdatedFld(conDnPath.OutDataNodeId);
}
}
/// <summary>
/// 路径结点列表(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DnPathNodeLst
{
get
{
return mstrDnPathNodeLst;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDnPathNodeLst = value;
}
else
{
 mstrDnPathNodeLst = value;
}
//记录修改过的字段
 AddUpdatedFld(conDnPath.DnPathNodeLst);
}
}
/// <summary>
/// 路径结点列表V2(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DnPathNodeLstV2
{
get
{
return mstrDnPathNodeLstV2;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDnPathNodeLstV2 = value;
}
else
{
 mstrDnPathNodeLstV2 = value;
}
//记录修改过的字段
 AddUpdatedFld(conDnPath.DnPathNodeLstV2);
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
 AddUpdatedFld(conDnPath.AssociationMappingId);
}
}
/// <summary>
/// 是否有错(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsHasErr
{
get
{
return mbolIsHasErr;
}
set
{
 mbolIsHasErr = value;
//记录修改过的字段
 AddUpdatedFld(conDnPath.IsHasErr);
}
}
/// <summary>
/// 边数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? EdgeNum
{
get
{
return mintEdgeNum;
}
set
{
 mintEdgeNum = value;
//记录修改过的字段
 AddUpdatedFld(conDnPath.EdgeNum);
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
 AddUpdatedFld(conDnPath.ErrMsg);
}
}
/// <summary>
/// 是否在用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool InUse
{
get
{
return mbolInUse;
}
set
{
 mbolInUse = value;
//记录修改过的字段
 AddUpdatedFld(conDnPath.InUse);
}
}
/// <summary>
/// 是否存在路径(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsExistPath
{
get
{
return mbolIsExistPath;
}
set
{
 mbolIsExistPath = value;
//记录修改过的字段
 AddUpdatedFld(conDnPath.IsExistPath);
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
 AddUpdatedFld(conDnPath.PrjId);
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
 AddUpdatedFld(conDnPath.UpdDate);
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
 AddUpdatedFld(conDnPath.UpdUser);
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
 AddUpdatedFld(conDnPath.Memo);
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
  return mstrDnPathId;
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
  return mstrDnPathName;
 }
 }
}
 /// <summary>
 /// 数据结点路径(DnPath)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conDnPath
{
public const string _CurrTabName = "DnPath"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "DnPathId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"DnPathId", "DnPathName", "InDataNodeId", "OutDataNodeId", "DnPathNodeLst", "DnPathNodeLstV2", "AssociationMappingId", "IsHasErr", "EdgeNum", "ErrMsg", "InUse", "IsExistPath", "PrjId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"DnPathId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DnPathId = "DnPathId";    //DN路径Id

 /// <summary>
 /// 常量:"DnPathName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DnPathName = "DnPathName";    //DN路径名

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
 /// 常量:"DnPathNodeLst"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DnPathNodeLst = "DnPathNodeLst";    //路径结点列表

 /// <summary>
 /// 常量:"DnPathNodeLstV2"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DnPathNodeLstV2 = "DnPathNodeLstV2";    //路径结点列表V2

 /// <summary>
 /// 常量:"AssociationMappingId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AssociationMappingId = "AssociationMappingId";    //关联关系映射Id

 /// <summary>
 /// 常量:"IsHasErr"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsHasErr = "IsHasErr";    //是否有错

 /// <summary>
 /// 常量:"EdgeNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EdgeNum = "EdgeNum";    //边数

 /// <summary>
 /// 常量:"ErrMsg"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ErrMsg = "ErrMsg";    //错误信息

 /// <summary>
 /// 常量:"InUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InUse = "InUse";    //是否在用

 /// <summary>
 /// 常量:"IsExistPath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsExistPath = "IsExistPath";    //是否存在路径

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