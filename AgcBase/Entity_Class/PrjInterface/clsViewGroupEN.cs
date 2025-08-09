
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewGroupEN
 表名:ViewGroup(00050134)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:07:36
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
 /// 表ViewGroup的关键字(ViewGroupId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ViewGroupId_ViewGroup
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
public K_ViewGroupId_ViewGroup(string strViewGroupId)
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
 /// <returns>返回:[K_ViewGroupId_ViewGroup]类型的对象</returns>
public static implicit operator K_ViewGroupId_ViewGroup(string value)
{
return new K_ViewGroupId_ViewGroup(value);
}
}
 /// <summary>
 /// 界面组(ViewGroup)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsViewGroupEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ViewGroup"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ViewGroupId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 13;
public static string[] _AttributeName = new string[] {"ViewGroupId", "ViewGroupName", "InSqlDsTypeId", "InRelaTabId", "OutSqlDsTypeId", "OutRelaTabId", "PrjDomain", "ActionPath", "PrjId", "UserId", "UpdDate", "Memo", "TableNameForProg"};

protected string mstrViewGroupId;    //界面组ID
protected string mstrViewGroupName;    //界面组名称
protected string mstrInSqlDsTypeId;    //输入数据源类型
protected string mstrInRelaTabId;    //输入数据源表ID
protected string mstrOutSqlDsTypeId;    //输出数据源类型
protected string mstrOutRelaTabId;    //输出数据源表ID
protected string mstrPrjDomain;    //域/包名
protected string mstrActionPath;    //Action路径
protected string mstrPrjId;    //工程Id
protected string mstrUserId;    //用户Id
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //说明
protected string mstrTableNameForProg;    //编程用表名

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsViewGroupEN()
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
public clsViewGroupEN(string strViewGroupId)
 {
strViewGroupId = strViewGroupId.Replace("'", "''");
if (strViewGroupId.Length > 8)
{
throw new Exception("在表:ViewGroup中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strViewGroupId)  ==  true)
{
throw new Exception("在表:ViewGroup中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  conViewGroup.ViewGroupId)
{
return mstrViewGroupId;
}
else if (strAttributeName  ==  conViewGroup.ViewGroupName)
{
return mstrViewGroupName;
}
else if (strAttributeName  ==  conViewGroup.InSqlDsTypeId)
{
return mstrInSqlDsTypeId;
}
else if (strAttributeName  ==  conViewGroup.InRelaTabId)
{
return mstrInRelaTabId;
}
else if (strAttributeName  ==  conViewGroup.OutSqlDsTypeId)
{
return mstrOutSqlDsTypeId;
}
else if (strAttributeName  ==  conViewGroup.OutRelaTabId)
{
return mstrOutRelaTabId;
}
else if (strAttributeName  ==  conViewGroup.PrjDomain)
{
return mstrPrjDomain;
}
else if (strAttributeName  ==  conViewGroup.ActionPath)
{
return mstrActionPath;
}
else if (strAttributeName  ==  conViewGroup.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conViewGroup.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conViewGroup.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conViewGroup.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conViewGroup.TableNameForProg)
{
return mstrTableNameForProg;
}
return null;
}
set
{
if (strAttributeName  ==  conViewGroup.ViewGroupId)
{
mstrViewGroupId = value.ToString();
 AddUpdatedFld(conViewGroup.ViewGroupId);
}
else if (strAttributeName  ==  conViewGroup.ViewGroupName)
{
mstrViewGroupName = value.ToString();
 AddUpdatedFld(conViewGroup.ViewGroupName);
}
else if (strAttributeName  ==  conViewGroup.InSqlDsTypeId)
{
mstrInSqlDsTypeId = value.ToString();
 AddUpdatedFld(conViewGroup.InSqlDsTypeId);
}
else if (strAttributeName  ==  conViewGroup.InRelaTabId)
{
mstrInRelaTabId = value.ToString();
 AddUpdatedFld(conViewGroup.InRelaTabId);
}
else if (strAttributeName  ==  conViewGroup.OutSqlDsTypeId)
{
mstrOutSqlDsTypeId = value.ToString();
 AddUpdatedFld(conViewGroup.OutSqlDsTypeId);
}
else if (strAttributeName  ==  conViewGroup.OutRelaTabId)
{
mstrOutRelaTabId = value.ToString();
 AddUpdatedFld(conViewGroup.OutRelaTabId);
}
else if (strAttributeName  ==  conViewGroup.PrjDomain)
{
mstrPrjDomain = value.ToString();
 AddUpdatedFld(conViewGroup.PrjDomain);
}
else if (strAttributeName  ==  conViewGroup.ActionPath)
{
mstrActionPath = value.ToString();
 AddUpdatedFld(conViewGroup.ActionPath);
}
else if (strAttributeName  ==  conViewGroup.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conViewGroup.PrjId);
}
else if (strAttributeName  ==  conViewGroup.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conViewGroup.UserId);
}
else if (strAttributeName  ==  conViewGroup.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conViewGroup.UpdDate);
}
else if (strAttributeName  ==  conViewGroup.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conViewGroup.Memo);
}
else if (strAttributeName  ==  conViewGroup.TableNameForProg)
{
mstrTableNameForProg = value.ToString();
 AddUpdatedFld(conViewGroup.TableNameForProg);
}
}
}
public object this[int intIndex]
{
get
{
if (conViewGroup.ViewGroupId  ==  _AttributeName[intIndex])
{
return mstrViewGroupId;
}
else if (conViewGroup.ViewGroupName  ==  _AttributeName[intIndex])
{
return mstrViewGroupName;
}
else if (conViewGroup.InSqlDsTypeId  ==  _AttributeName[intIndex])
{
return mstrInSqlDsTypeId;
}
else if (conViewGroup.InRelaTabId  ==  _AttributeName[intIndex])
{
return mstrInRelaTabId;
}
else if (conViewGroup.OutSqlDsTypeId  ==  _AttributeName[intIndex])
{
return mstrOutSqlDsTypeId;
}
else if (conViewGroup.OutRelaTabId  ==  _AttributeName[intIndex])
{
return mstrOutRelaTabId;
}
else if (conViewGroup.PrjDomain  ==  _AttributeName[intIndex])
{
return mstrPrjDomain;
}
else if (conViewGroup.ActionPath  ==  _AttributeName[intIndex])
{
return mstrActionPath;
}
else if (conViewGroup.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conViewGroup.UserId  ==  _AttributeName[intIndex])
{
return mstrUserId;
}
else if (conViewGroup.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conViewGroup.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (conViewGroup.TableNameForProg  ==  _AttributeName[intIndex])
{
return mstrTableNameForProg;
}
return null;
}
set
{
if (conViewGroup.ViewGroupId  ==  _AttributeName[intIndex])
{
mstrViewGroupId = value.ToString();
 AddUpdatedFld(conViewGroup.ViewGroupId);
}
else if (conViewGroup.ViewGroupName  ==  _AttributeName[intIndex])
{
mstrViewGroupName = value.ToString();
 AddUpdatedFld(conViewGroup.ViewGroupName);
}
else if (conViewGroup.InSqlDsTypeId  ==  _AttributeName[intIndex])
{
mstrInSqlDsTypeId = value.ToString();
 AddUpdatedFld(conViewGroup.InSqlDsTypeId);
}
else if (conViewGroup.InRelaTabId  ==  _AttributeName[intIndex])
{
mstrInRelaTabId = value.ToString();
 AddUpdatedFld(conViewGroup.InRelaTabId);
}
else if (conViewGroup.OutSqlDsTypeId  ==  _AttributeName[intIndex])
{
mstrOutSqlDsTypeId = value.ToString();
 AddUpdatedFld(conViewGroup.OutSqlDsTypeId);
}
else if (conViewGroup.OutRelaTabId  ==  _AttributeName[intIndex])
{
mstrOutRelaTabId = value.ToString();
 AddUpdatedFld(conViewGroup.OutRelaTabId);
}
else if (conViewGroup.PrjDomain  ==  _AttributeName[intIndex])
{
mstrPrjDomain = value.ToString();
 AddUpdatedFld(conViewGroup.PrjDomain);
}
else if (conViewGroup.ActionPath  ==  _AttributeName[intIndex])
{
mstrActionPath = value.ToString();
 AddUpdatedFld(conViewGroup.ActionPath);
}
else if (conViewGroup.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conViewGroup.PrjId);
}
else if (conViewGroup.UserId  ==  _AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conViewGroup.UserId);
}
else if (conViewGroup.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conViewGroup.UpdDate);
}
else if (conViewGroup.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conViewGroup.Memo);
}
else if (conViewGroup.TableNameForProg  ==  _AttributeName[intIndex])
{
mstrTableNameForProg = value.ToString();
 AddUpdatedFld(conViewGroup.TableNameForProg);
}
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
 AddUpdatedFld(conViewGroup.ViewGroupId);
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
 AddUpdatedFld(conViewGroup.ViewGroupName);
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
 AddUpdatedFld(conViewGroup.InSqlDsTypeId);
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
 AddUpdatedFld(conViewGroup.InRelaTabId);
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
 AddUpdatedFld(conViewGroup.OutSqlDsTypeId);
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
 AddUpdatedFld(conViewGroup.OutRelaTabId);
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
 AddUpdatedFld(conViewGroup.PrjDomain);
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
 AddUpdatedFld(conViewGroup.ActionPath);
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
 AddUpdatedFld(conViewGroup.PrjId);
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
 AddUpdatedFld(conViewGroup.UserId);
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
 AddUpdatedFld(conViewGroup.UpdDate);
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
 AddUpdatedFld(conViewGroup.Memo);
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
 AddUpdatedFld(conViewGroup.TableNameForProg);
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
 /// 界面组(ViewGroup)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conViewGroup
{
public const string _CurrTabName = "ViewGroup"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ViewGroupId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"ViewGroupId", "ViewGroupName", "InSqlDsTypeId", "InRelaTabId", "OutSqlDsTypeId", "OutRelaTabId", "PrjDomain", "ActionPath", "PrjId", "UserId", "UpdDate", "Memo", "TableNameForProg"};
//以下是属性变量


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
 /// 常量:"OutSqlDsTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OutSqlDsTypeId = "OutSqlDsTypeId";    //输出数据源类型

 /// <summary>
 /// 常量:"OutRelaTabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OutRelaTabId = "OutRelaTabId";    //输出数据源表ID

 /// <summary>
 /// 常量:"PrjDomain"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjDomain = "PrjDomain";    //域/包名

 /// <summary>
 /// 常量:"ActionPath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ActionPath = "ActionPath";    //Action路径

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户Id

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明

 /// <summary>
 /// 常量:"TableNameForProg"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TableNameForProg = "TableNameForProg";    //编程用表名
}

}