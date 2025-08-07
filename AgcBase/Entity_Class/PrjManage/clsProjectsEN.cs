
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsProjectsEN
 表名:Projects(00050002)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:27:52
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:工程管理(PrjManage)
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
 /// 表Projects的关键字(PrjId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PrjId_Projects
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strPrjId">表关键字</param>
public K_PrjId_Projects(string strPrjId)
{
if (IsValid(strPrjId)) Value = strPrjId;
else
{
Value = null;
}
}
private static bool IsValid(string strPrjId)
{
if (string.IsNullOrEmpty(strPrjId) == true) return false;
if (strPrjId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PrjId_Projects]类型的对象</returns>
public static implicit operator K_PrjId_Projects(string value)
{
return new K_PrjId_Projects(value);
}
}
 /// <summary>
 /// 工程(Projects)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsProjectsEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "Projects"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PrjId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 13;
public static string[] _AttributeName = new string[] {"PrjId", "PrjName", "PrjDomain", "TableSpace", "GetWebApiFunc", "IsRelaDataBase", "UseStateId", "UserId", "UpdDate", "Memo", "JavaPackageName", "IsSupportMvc", "IsoPrjName"};

protected string mstrPrjId;    //工程Id
protected string mstrPrjName;    //工程名称
protected string mstrPrjDomain;    //域/包名
protected string mstrTableSpace;    //表空间
protected string mstrGetWebApiFunc;    //获取WebApiUrl函数
protected bool mbolIsRelaDataBase;    //是否关联数据库
protected string mstrUseStateId;    //使用状态Id
protected string mstrUserId;    //用户Id
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //说明
protected string mstrJavaPackageName;    //Java包名
protected bool mbolIsSupportMvc;    //是否支持Mvc
protected string mstrIsoPrjName;    //ISO工程名

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsProjectsEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PrjId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strPrjId">关键字:工程Id</param>
public clsProjectsEN(string strPrjId)
 {
strPrjId = strPrjId.Replace("'", "''");
if (strPrjId.Length > 4)
{
throw new Exception("在表:Projects中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strPrjId)  ==  true)
{
throw new Exception("在表:Projects中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPrjId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrPrjId = strPrjId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PrjId");
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
if (strAttributeName  ==  conProjects.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conProjects.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  conProjects.PrjDomain)
{
return mstrPrjDomain;
}
else if (strAttributeName  ==  conProjects.TableSpace)
{
return mstrTableSpace;
}
else if (strAttributeName  ==  conProjects.GetWebApiFunc)
{
return mstrGetWebApiFunc;
}
else if (strAttributeName  ==  conProjects.IsRelaDataBase)
{
return mbolIsRelaDataBase;
}
else if (strAttributeName  ==  conProjects.UseStateId)
{
return mstrUseStateId;
}
else if (strAttributeName  ==  conProjects.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conProjects.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conProjects.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conProjects.JavaPackageName)
{
return mstrJavaPackageName;
}
else if (strAttributeName  ==  conProjects.IsSupportMvc)
{
return mbolIsSupportMvc;
}
else if (strAttributeName  ==  conProjects.IsoPrjName)
{
return mstrIsoPrjName;
}
return null;
}
set
{
if (strAttributeName  ==  conProjects.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conProjects.PrjId);
}
else if (strAttributeName  ==  conProjects.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(conProjects.PrjName);
}
else if (strAttributeName  ==  conProjects.PrjDomain)
{
mstrPrjDomain = value.ToString();
 AddUpdatedFld(conProjects.PrjDomain);
}
else if (strAttributeName  ==  conProjects.TableSpace)
{
mstrTableSpace = value.ToString();
 AddUpdatedFld(conProjects.TableSpace);
}
else if (strAttributeName  ==  conProjects.GetWebApiFunc)
{
mstrGetWebApiFunc = value.ToString();
 AddUpdatedFld(conProjects.GetWebApiFunc);
}
else if (strAttributeName  ==  conProjects.IsRelaDataBase)
{
mbolIsRelaDataBase = TransNullToBool(value.ToString());
 AddUpdatedFld(conProjects.IsRelaDataBase);
}
else if (strAttributeName  ==  conProjects.UseStateId)
{
mstrUseStateId = value.ToString();
 AddUpdatedFld(conProjects.UseStateId);
}
else if (strAttributeName  ==  conProjects.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conProjects.UserId);
}
else if (strAttributeName  ==  conProjects.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conProjects.UpdDate);
}
else if (strAttributeName  ==  conProjects.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conProjects.Memo);
}
else if (strAttributeName  ==  conProjects.JavaPackageName)
{
mstrJavaPackageName = value.ToString();
 AddUpdatedFld(conProjects.JavaPackageName);
}
else if (strAttributeName  ==  conProjects.IsSupportMvc)
{
mbolIsSupportMvc = TransNullToBool(value.ToString());
 AddUpdatedFld(conProjects.IsSupportMvc);
}
else if (strAttributeName  ==  conProjects.IsoPrjName)
{
mstrIsoPrjName = value.ToString();
 AddUpdatedFld(conProjects.IsoPrjName);
}
}
}
public object this[int intIndex]
{
get
{
if (conProjects.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conProjects.PrjName  ==  _AttributeName[intIndex])
{
return mstrPrjName;
}
else if (conProjects.PrjDomain  ==  _AttributeName[intIndex])
{
return mstrPrjDomain;
}
else if (conProjects.TableSpace  ==  _AttributeName[intIndex])
{
return mstrTableSpace;
}
else if (conProjects.GetWebApiFunc  ==  _AttributeName[intIndex])
{
return mstrGetWebApiFunc;
}
else if (conProjects.IsRelaDataBase  ==  _AttributeName[intIndex])
{
return mbolIsRelaDataBase;
}
else if (conProjects.UseStateId  ==  _AttributeName[intIndex])
{
return mstrUseStateId;
}
else if (conProjects.UserId  ==  _AttributeName[intIndex])
{
return mstrUserId;
}
else if (conProjects.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conProjects.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (conProjects.JavaPackageName  ==  _AttributeName[intIndex])
{
return mstrJavaPackageName;
}
else if (conProjects.IsSupportMvc  ==  _AttributeName[intIndex])
{
return mbolIsSupportMvc;
}
else if (conProjects.IsoPrjName  ==  _AttributeName[intIndex])
{
return mstrIsoPrjName;
}
return null;
}
set
{
if (conProjects.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conProjects.PrjId);
}
else if (conProjects.PrjName  ==  _AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(conProjects.PrjName);
}
else if (conProjects.PrjDomain  ==  _AttributeName[intIndex])
{
mstrPrjDomain = value.ToString();
 AddUpdatedFld(conProjects.PrjDomain);
}
else if (conProjects.TableSpace  ==  _AttributeName[intIndex])
{
mstrTableSpace = value.ToString();
 AddUpdatedFld(conProjects.TableSpace);
}
else if (conProjects.GetWebApiFunc  ==  _AttributeName[intIndex])
{
mstrGetWebApiFunc = value.ToString();
 AddUpdatedFld(conProjects.GetWebApiFunc);
}
else if (conProjects.IsRelaDataBase  ==  _AttributeName[intIndex])
{
mbolIsRelaDataBase = TransNullToBool(value.ToString());
 AddUpdatedFld(conProjects.IsRelaDataBase);
}
else if (conProjects.UseStateId  ==  _AttributeName[intIndex])
{
mstrUseStateId = value.ToString();
 AddUpdatedFld(conProjects.UseStateId);
}
else if (conProjects.UserId  ==  _AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conProjects.UserId);
}
else if (conProjects.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conProjects.UpdDate);
}
else if (conProjects.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conProjects.Memo);
}
else if (conProjects.JavaPackageName  ==  _AttributeName[intIndex])
{
mstrJavaPackageName = value.ToString();
 AddUpdatedFld(conProjects.JavaPackageName);
}
else if (conProjects.IsSupportMvc  ==  _AttributeName[intIndex])
{
mbolIsSupportMvc = TransNullToBool(value.ToString());
 AddUpdatedFld(conProjects.IsSupportMvc);
}
else if (conProjects.IsoPrjName  ==  _AttributeName[intIndex])
{
mstrIsoPrjName = value.ToString();
 AddUpdatedFld(conProjects.IsoPrjName);
}
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
 AddUpdatedFld(conProjects.PrjId);
}
}
/// <summary>
/// 工程名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjName
{
get
{
return mstrPrjName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjName = value;
}
else
{
 mstrPrjName = value;
}
//记录修改过的字段
 AddUpdatedFld(conProjects.PrjName);
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
 AddUpdatedFld(conProjects.PrjDomain);
}
}
/// <summary>
/// 表空间(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TableSpace
{
get
{
return mstrTableSpace;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTableSpace = value;
}
else
{
 mstrTableSpace = value;
}
//记录修改过的字段
 AddUpdatedFld(conProjects.TableSpace);
}
}
/// <summary>
/// 获取WebApiUrl函数(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GetWebApiFunc
{
get
{
return mstrGetWebApiFunc;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGetWebApiFunc = value;
}
else
{
 mstrGetWebApiFunc = value;
}
//记录修改过的字段
 AddUpdatedFld(conProjects.GetWebApiFunc);
}
}
/// <summary>
/// 是否关联数据库(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsRelaDataBase
{
get
{
return mbolIsRelaDataBase;
}
set
{
 mbolIsRelaDataBase = value;
//记录修改过的字段
 AddUpdatedFld(conProjects.IsRelaDataBase);
}
}
/// <summary>
/// 使用状态Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UseStateId
{
get
{
return mstrUseStateId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUseStateId = value;
}
else
{
 mstrUseStateId = value;
}
//记录修改过的字段
 AddUpdatedFld(conProjects.UseStateId);
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
 AddUpdatedFld(conProjects.UserId);
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
 AddUpdatedFld(conProjects.UpdDate);
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
 AddUpdatedFld(conProjects.Memo);
}
}
/// <summary>
/// Java包名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string JavaPackageName
{
get
{
return mstrJavaPackageName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrJavaPackageName = value;
}
else
{
 mstrJavaPackageName = value;
}
//记录修改过的字段
 AddUpdatedFld(conProjects.JavaPackageName);
}
}
/// <summary>
/// 是否支持Mvc(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsSupportMvc
{
get
{
return mbolIsSupportMvc;
}
set
{
 mbolIsSupportMvc = value;
//记录修改过的字段
 AddUpdatedFld(conProjects.IsSupportMvc);
}
}
/// <summary>
/// ISO工程名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IsoPrjName
{
get
{
return mstrIsoPrjName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIsoPrjName = value;
}
else
{
 mstrIsoPrjName = value;
}
//记录修改过的字段
 AddUpdatedFld(conProjects.IsoPrjName);
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
  return mstrPrjId;
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
  return mstrPrjName;
 }
 }
}
 /// <summary>
 /// 工程(Projects)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conProjects
{
public const string _CurrTabName = "Projects"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PrjId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"PrjId", "PrjName", "PrjDomain", "TableSpace", "GetWebApiFunc", "IsRelaDataBase", "UseStateId", "UserId", "UpdDate", "Memo", "JavaPackageName", "IsSupportMvc", "IsoPrjName"};
//以下是属性变量


 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"PrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjName = "PrjName";    //工程名称

 /// <summary>
 /// 常量:"PrjDomain"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjDomain = "PrjDomain";    //域/包名

 /// <summary>
 /// 常量:"TableSpace"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TableSpace = "TableSpace";    //表空间

 /// <summary>
 /// 常量:"GetWebApiFunc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GetWebApiFunc = "GetWebApiFunc";    //获取WebApiUrl函数

 /// <summary>
 /// 常量:"IsRelaDataBase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsRelaDataBase = "IsRelaDataBase";    //是否关联数据库

 /// <summary>
 /// 常量:"UseStateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UseStateId = "UseStateId";    //使用状态Id

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
 /// 常量:"JavaPackageName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string JavaPackageName = "JavaPackageName";    //Java包名

 /// <summary>
 /// 常量:"IsSupportMvc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSupportMvc = "IsSupportMvc";    //是否支持Mvc

 /// <summary>
 /// 常量:"IsoPrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsoPrjName = "IsoPrjName";    //ISO工程名
}

}