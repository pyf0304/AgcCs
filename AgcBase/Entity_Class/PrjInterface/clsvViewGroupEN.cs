
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewGroupEN
 表名:vViewGroup(00050158)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:11:57
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
 /// 表vViewGroup的关键字(ViewGroupId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ViewGroupId_vViewGroup
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strViewGroupId">表关键字</param>
public K_ViewGroupId_vViewGroup(string strViewGroupId)
{
if (IsValid(strViewGroupId)) Value = strViewGroupId;
else
{
Value = null;
}
}
private static bool IsValid(string strViewGroupId)
{
if (string.IsNullOrEmpty(strViewGroupId) == true) return false;
if (strViewGroupId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ViewGroupId_vViewGroup]类型的对象</returns>
public static implicit operator K_ViewGroupId_vViewGroup(string value)
{
return new K_ViewGroupId_vViewGroup(value);
}
}
 /// <summary>
 /// v界面组(vViewGroup)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvViewGroupEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vViewGroup"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ViewGroupId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 17;
public static string[] _AttributeName = new string[] {"UserId", "PrjId", "Memo", "PrjDomain", "UpdDate", "OutRelaTabId", "InSqlDsTypeId", "InRelaTabId", "ViewGroupId", "ViewGroupName", "ActionPath", "OutSqlDsTypeId", "OutSqlDsTypeName", "OutTabName", "InSqlDsTypeName", "InTabName", "TableNameForProg"};

protected string mstrUserId;    //用户Id
protected string mstrPrjId;    //工程Id
protected string mstrMemo;    //说明
protected string mstrPrjDomain;    //域/包名
protected string mstrUpdDate;    //修改日期
protected string mstrOutRelaTabId;    //输出数据源表ID
protected string mstrInSqlDsTypeId;    //输入数据源类型
protected string mstrInRelaTabId;    //输入数据源表ID
protected string mstrViewGroupId;    //界面组ID
protected string mstrViewGroupName;    //界面组名称
protected string mstrActionPath;    //Action路径
protected string mstrOutSqlDsTypeId;    //输出数据源类型
protected string mstrOutSqlDsTypeName;    //OUT数据源类型
protected string mstrOutTabName;    //OUT表
protected string mstrInSqlDsTypeName;    //IN数据源类型
protected string mstrInTabName;    //IN表
protected string mstrTableNameForProg;    //编程用表名

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvViewGroupEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ViewGroupId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strViewGroupId">关键字:界面组ID</param>
public clsvViewGroupEN(string strViewGroupId)
 {
strViewGroupId = strViewGroupId.Replace("'", "''");
if (strViewGroupId.Length > 8)
{
throw new Exception("在表:vViewGroup中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strViewGroupId)  ==  true)
{
throw new Exception("在表:vViewGroup中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strViewGroupId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrViewGroupId = strViewGroupId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ViewGroupId");
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
if (strAttributeName  ==  convViewGroup.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convViewGroup.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convViewGroup.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convViewGroup.PrjDomain)
{
return mstrPrjDomain;
}
else if (strAttributeName  ==  convViewGroup.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convViewGroup.OutRelaTabId)
{
return mstrOutRelaTabId;
}
else if (strAttributeName  ==  convViewGroup.InSqlDsTypeId)
{
return mstrInSqlDsTypeId;
}
else if (strAttributeName  ==  convViewGroup.InRelaTabId)
{
return mstrInRelaTabId;
}
else if (strAttributeName  ==  convViewGroup.ViewGroupId)
{
return mstrViewGroupId;
}
else if (strAttributeName  ==  convViewGroup.ViewGroupName)
{
return mstrViewGroupName;
}
else if (strAttributeName  ==  convViewGroup.ActionPath)
{
return mstrActionPath;
}
else if (strAttributeName  ==  convViewGroup.OutSqlDsTypeId)
{
return mstrOutSqlDsTypeId;
}
else if (strAttributeName  ==  convViewGroup.OutSqlDsTypeName)
{
return mstrOutSqlDsTypeName;
}
else if (strAttributeName  ==  convViewGroup.OutTabName)
{
return mstrOutTabName;
}
else if (strAttributeName  ==  convViewGroup.InSqlDsTypeName)
{
return mstrInSqlDsTypeName;
}
else if (strAttributeName  ==  convViewGroup.InTabName)
{
return mstrInTabName;
}
else if (strAttributeName  ==  convViewGroup.TableNameForProg)
{
return mstrTableNameForProg;
}
return null;
}
set
{
if (strAttributeName  ==  convViewGroup.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convViewGroup.UserId);
}
else if (strAttributeName  ==  convViewGroup.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convViewGroup.PrjId);
}
else if (strAttributeName  ==  convViewGroup.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convViewGroup.Memo);
}
else if (strAttributeName  ==  convViewGroup.PrjDomain)
{
mstrPrjDomain = value.ToString();
 AddUpdatedFld(convViewGroup.PrjDomain);
}
else if (strAttributeName  ==  convViewGroup.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convViewGroup.UpdDate);
}
else if (strAttributeName  ==  convViewGroup.OutRelaTabId)
{
mstrOutRelaTabId = value.ToString();
 AddUpdatedFld(convViewGroup.OutRelaTabId);
}
else if (strAttributeName  ==  convViewGroup.InSqlDsTypeId)
{
mstrInSqlDsTypeId = value.ToString();
 AddUpdatedFld(convViewGroup.InSqlDsTypeId);
}
else if (strAttributeName  ==  convViewGroup.InRelaTabId)
{
mstrInRelaTabId = value.ToString();
 AddUpdatedFld(convViewGroup.InRelaTabId);
}
else if (strAttributeName  ==  convViewGroup.ViewGroupId)
{
mstrViewGroupId = value.ToString();
 AddUpdatedFld(convViewGroup.ViewGroupId);
}
else if (strAttributeName  ==  convViewGroup.ViewGroupName)
{
mstrViewGroupName = value.ToString();
 AddUpdatedFld(convViewGroup.ViewGroupName);
}
else if (strAttributeName  ==  convViewGroup.ActionPath)
{
mstrActionPath = value.ToString();
 AddUpdatedFld(convViewGroup.ActionPath);
}
else if (strAttributeName  ==  convViewGroup.OutSqlDsTypeId)
{
mstrOutSqlDsTypeId = value.ToString();
 AddUpdatedFld(convViewGroup.OutSqlDsTypeId);
}
else if (strAttributeName  ==  convViewGroup.OutSqlDsTypeName)
{
mstrOutSqlDsTypeName = value.ToString();
 AddUpdatedFld(convViewGroup.OutSqlDsTypeName);
}
else if (strAttributeName  ==  convViewGroup.OutTabName)
{
mstrOutTabName = value.ToString();
 AddUpdatedFld(convViewGroup.OutTabName);
}
else if (strAttributeName  ==  convViewGroup.InSqlDsTypeName)
{
mstrInSqlDsTypeName = value.ToString();
 AddUpdatedFld(convViewGroup.InSqlDsTypeName);
}
else if (strAttributeName  ==  convViewGroup.InTabName)
{
mstrInTabName = value.ToString();
 AddUpdatedFld(convViewGroup.InTabName);
}
else if (strAttributeName  ==  convViewGroup.TableNameForProg)
{
mstrTableNameForProg = value.ToString();
 AddUpdatedFld(convViewGroup.TableNameForProg);
}
}
}
public object this[int intIndex]
{
get
{
if (convViewGroup.UserId  ==  _AttributeName[intIndex])
{
return mstrUserId;
}
else if (convViewGroup.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convViewGroup.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (convViewGroup.PrjDomain  ==  _AttributeName[intIndex])
{
return mstrPrjDomain;
}
else if (convViewGroup.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convViewGroup.OutRelaTabId  ==  _AttributeName[intIndex])
{
return mstrOutRelaTabId;
}
else if (convViewGroup.InSqlDsTypeId  ==  _AttributeName[intIndex])
{
return mstrInSqlDsTypeId;
}
else if (convViewGroup.InRelaTabId  ==  _AttributeName[intIndex])
{
return mstrInRelaTabId;
}
else if (convViewGroup.ViewGroupId  ==  _AttributeName[intIndex])
{
return mstrViewGroupId;
}
else if (convViewGroup.ViewGroupName  ==  _AttributeName[intIndex])
{
return mstrViewGroupName;
}
else if (convViewGroup.ActionPath  ==  _AttributeName[intIndex])
{
return mstrActionPath;
}
else if (convViewGroup.OutSqlDsTypeId  ==  _AttributeName[intIndex])
{
return mstrOutSqlDsTypeId;
}
else if (convViewGroup.OutSqlDsTypeName  ==  _AttributeName[intIndex])
{
return mstrOutSqlDsTypeName;
}
else if (convViewGroup.OutTabName  ==  _AttributeName[intIndex])
{
return mstrOutTabName;
}
else if (convViewGroup.InSqlDsTypeName  ==  _AttributeName[intIndex])
{
return mstrInSqlDsTypeName;
}
else if (convViewGroup.InTabName  ==  _AttributeName[intIndex])
{
return mstrInTabName;
}
else if (convViewGroup.TableNameForProg  ==  _AttributeName[intIndex])
{
return mstrTableNameForProg;
}
return null;
}
set
{
if (convViewGroup.UserId  ==  _AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convViewGroup.UserId);
}
else if (convViewGroup.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convViewGroup.PrjId);
}
else if (convViewGroup.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convViewGroup.Memo);
}
else if (convViewGroup.PrjDomain  ==  _AttributeName[intIndex])
{
mstrPrjDomain = value.ToString();
 AddUpdatedFld(convViewGroup.PrjDomain);
}
else if (convViewGroup.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convViewGroup.UpdDate);
}
else if (convViewGroup.OutRelaTabId  ==  _AttributeName[intIndex])
{
mstrOutRelaTabId = value.ToString();
 AddUpdatedFld(convViewGroup.OutRelaTabId);
}
else if (convViewGroup.InSqlDsTypeId  ==  _AttributeName[intIndex])
{
mstrInSqlDsTypeId = value.ToString();
 AddUpdatedFld(convViewGroup.InSqlDsTypeId);
}
else if (convViewGroup.InRelaTabId  ==  _AttributeName[intIndex])
{
mstrInRelaTabId = value.ToString();
 AddUpdatedFld(convViewGroup.InRelaTabId);
}
else if (convViewGroup.ViewGroupId  ==  _AttributeName[intIndex])
{
mstrViewGroupId = value.ToString();
 AddUpdatedFld(convViewGroup.ViewGroupId);
}
else if (convViewGroup.ViewGroupName  ==  _AttributeName[intIndex])
{
mstrViewGroupName = value.ToString();
 AddUpdatedFld(convViewGroup.ViewGroupName);
}
else if (convViewGroup.ActionPath  ==  _AttributeName[intIndex])
{
mstrActionPath = value.ToString();
 AddUpdatedFld(convViewGroup.ActionPath);
}
else if (convViewGroup.OutSqlDsTypeId  ==  _AttributeName[intIndex])
{
mstrOutSqlDsTypeId = value.ToString();
 AddUpdatedFld(convViewGroup.OutSqlDsTypeId);
}
else if (convViewGroup.OutSqlDsTypeName  ==  _AttributeName[intIndex])
{
mstrOutSqlDsTypeName = value.ToString();
 AddUpdatedFld(convViewGroup.OutSqlDsTypeName);
}
else if (convViewGroup.OutTabName  ==  _AttributeName[intIndex])
{
mstrOutTabName = value.ToString();
 AddUpdatedFld(convViewGroup.OutTabName);
}
else if (convViewGroup.InSqlDsTypeName  ==  _AttributeName[intIndex])
{
mstrInSqlDsTypeName = value.ToString();
 AddUpdatedFld(convViewGroup.InSqlDsTypeName);
}
else if (convViewGroup.InTabName  ==  _AttributeName[intIndex])
{
mstrInTabName = value.ToString();
 AddUpdatedFld(convViewGroup.InTabName);
}
else if (convViewGroup.TableNameForProg  ==  _AttributeName[intIndex])
{
mstrTableNameForProg = value.ToString();
 AddUpdatedFld(convViewGroup.TableNameForProg);
}
}
}

/// <summary>
/// 用户Id(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserId
{
get
{
return mstrUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserId = value;
}
else
{
 mstrUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewGroup.UserId);
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
 AddUpdatedFld(convViewGroup.PrjId);
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
 AddUpdatedFld(convViewGroup.Memo);
}
}
/// <summary>
/// 域/包名(说明:;字段类型:varchar;字段长度:128;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjDomain
{
get
{
return mstrPrjDomain;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjDomain = value;
}
else
{
 mstrPrjDomain = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewGroup.PrjDomain);
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
 AddUpdatedFld(convViewGroup.UpdDate);
}
}
/// <summary>
/// 输出数据源表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OutRelaTabId
{
get
{
return mstrOutRelaTabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOutRelaTabId = value;
}
else
{
 mstrOutRelaTabId = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewGroup.OutRelaTabId);
}
}
/// <summary>
/// 输入数据源类型(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string InSqlDsTypeId
{
get
{
return mstrInSqlDsTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrInSqlDsTypeId = value;
}
else
{
 mstrInSqlDsTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewGroup.InSqlDsTypeId);
}
}
/// <summary>
/// 输入数据源表ID(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string InRelaTabId
{
get
{
return mstrInRelaTabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrInRelaTabId = value;
}
else
{
 mstrInRelaTabId = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewGroup.InRelaTabId);
}
}
/// <summary>
/// 界面组ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewGroupId
{
get
{
return mstrViewGroupId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewGroupId = value;
}
else
{
 mstrViewGroupId = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewGroup.ViewGroupId);
}
}
/// <summary>
/// 界面组名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewGroupName
{
get
{
return mstrViewGroupName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewGroupName = value;
}
else
{
 mstrViewGroupName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewGroup.ViewGroupName);
}
}
/// <summary>
/// Action路径(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ActionPath
{
get
{
return mstrActionPath;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrActionPath = value;
}
else
{
 mstrActionPath = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewGroup.ActionPath);
}
}
/// <summary>
/// 输出数据源类型(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OutSqlDsTypeId
{
get
{
return mstrOutSqlDsTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOutSqlDsTypeId = value;
}
else
{
 mstrOutSqlDsTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewGroup.OutSqlDsTypeId);
}
}
/// <summary>
/// OUT数据源类型(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OutSqlDsTypeName
{
get
{
return mstrOutSqlDsTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOutSqlDsTypeName = value;
}
else
{
 mstrOutSqlDsTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewGroup.OutSqlDsTypeName);
}
}
/// <summary>
/// OUT表(说明:;字段类型:varchar;字段长度:40;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OutTabName
{
get
{
return mstrOutTabName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOutTabName = value;
}
else
{
 mstrOutTabName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewGroup.OutTabName);
}
}
/// <summary>
/// IN数据源类型(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string InSqlDsTypeName
{
get
{
return mstrInSqlDsTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrInSqlDsTypeName = value;
}
else
{
 mstrInSqlDsTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewGroup.InSqlDsTypeName);
}
}
/// <summary>
/// IN表(说明:;字段类型:varchar;字段长度:40;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string InTabName
{
get
{
return mstrInTabName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrInTabName = value;
}
else
{
 mstrInTabName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewGroup.InTabName);
}
}
/// <summary>
/// 编程用表名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TableNameForProg
{
get
{
return mstrTableNameForProg;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTableNameForProg = value;
}
else
{
 mstrTableNameForProg = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewGroup.TableNameForProg);
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
  return mstrViewGroupId;
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
  return mstrViewGroupName;
 }
 }
}
 /// <summary>
 /// v界面组(vViewGroup)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convViewGroup
{
public const string _CurrTabName = "vViewGroup"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ViewGroupId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"UserId", "PrjId", "Memo", "PrjDomain", "UpdDate", "OutRelaTabId", "InSqlDsTypeId", "InRelaTabId", "ViewGroupId", "ViewGroupName", "ActionPath", "OutSqlDsTypeId", "OutSqlDsTypeName", "OutTabName", "InSqlDsTypeName", "InTabName", "TableNameForProg"};
//以下是属性变量


 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户Id

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明

 /// <summary>
 /// 常量:"PrjDomain"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjDomain = "PrjDomain";    //域/包名

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"OutRelaTabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OutRelaTabId = "OutRelaTabId";    //输出数据源表ID

 /// <summary>
 /// 常量:"InSqlDsTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InSqlDsTypeId = "InSqlDsTypeId";    //输入数据源类型

 /// <summary>
 /// 常量:"InRelaTabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InRelaTabId = "InRelaTabId";    //输入数据源表ID

 /// <summary>
 /// 常量:"ViewGroupId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewGroupId = "ViewGroupId";    //界面组ID

 /// <summary>
 /// 常量:"ViewGroupName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewGroupName = "ViewGroupName";    //界面组名称

 /// <summary>
 /// 常量:"ActionPath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ActionPath = "ActionPath";    //Action路径

 /// <summary>
 /// 常量:"OutSqlDsTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OutSqlDsTypeId = "OutSqlDsTypeId";    //输出数据源类型

 /// <summary>
 /// 常量:"OutSqlDsTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OutSqlDsTypeName = "OutSqlDsTypeName";    //OUT数据源类型

 /// <summary>
 /// 常量:"OutTabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OutTabName = "OutTabName";    //OUT表

 /// <summary>
 /// 常量:"InSqlDsTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InSqlDsTypeName = "InSqlDsTypeName";    //IN数据源类型

 /// <summary>
 /// 常量:"InTabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InTabName = "InTabName";    //IN表

 /// <summary>
 /// 常量:"TableNameForProg"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TableNameForProg = "TableNameForProg";    //编程用表名
}

}