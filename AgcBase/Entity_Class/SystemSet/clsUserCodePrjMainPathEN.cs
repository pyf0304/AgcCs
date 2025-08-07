
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUserCodePrjMainPathEN
 表名:UserCodePrjMainPath(00050338)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:27:18
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统设置(SystemSet)
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
 /// 表UserCodePrjMainPath的关键字(UserCodePrjMainPathId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_UserCodePrjMainPathId_UserCodePrjMainPath
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strUserCodePrjMainPathId">表关键字</param>
public K_UserCodePrjMainPathId_UserCodePrjMainPath(string strUserCodePrjMainPathId)
{
if (IsValid(strUserCodePrjMainPathId)) Value = strUserCodePrjMainPathId;
else
{
Value = null;
}
}
private static bool IsValid(string strUserCodePrjMainPathId)
{
if (string.IsNullOrEmpty(strUserCodePrjMainPathId) == true) return false;
if (strUserCodePrjMainPathId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_UserCodePrjMainPathId_UserCodePrjMainPath]类型的对象</returns>
public static implicit operator K_UserCodePrjMainPathId_UserCodePrjMainPath(string value)
{
return new K_UserCodePrjMainPathId_UserCodePrjMainPath(value);
}
}
 /// <summary>
 /// 用户生成项目主路径(UserCodePrjMainPath)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsUserCodePrjMainPathEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "UserCodePrjMainPath"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "UserCodePrjMainPathId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 12;
public static string[] _AttributeName = new string[] {"UserCodePrjMainPathId", "CMProjectAppRelaId", "PrjId", "ProgLangTypeId", "UserId", "IsUsePrjMainPath", "IncludeXmlPath", "IsTemplate", "InUse", "UpdDate", "UpdUserId", "Memo"};

protected string mstrUserCodePrjMainPathId;    //生成主目录Id
protected long mlngCMProjectAppRelaId;    //Cm工程应用关系Id
protected string mstrPrjId;    //工程Id
protected string mstrProgLangTypeId;    //编程语言类型Id
protected string mstrUserId;    //用户Id
protected bool mbolIsUsePrjMainPath;    //是否使用主路径
protected string mstrIncludeXmlPath;    //包含表Xml路径
protected bool mbolIsTemplate;    //是否模板
protected bool mbolInUse;    //是否在用
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsUserCodePrjMainPathEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("UserCodePrjMainPathId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strUserCodePrjMainPathId">关键字:生成主目录Id</param>
public clsUserCodePrjMainPathEN(string strUserCodePrjMainPathId)
 {
strUserCodePrjMainPathId = strUserCodePrjMainPathId.Replace("'", "''");
if (strUserCodePrjMainPathId.Length > 8)
{
throw new Exception("在表:UserCodePrjMainPath中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strUserCodePrjMainPathId)  ==  true)
{
throw new Exception("在表:UserCodePrjMainPath中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strUserCodePrjMainPathId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrUserCodePrjMainPathId = strUserCodePrjMainPathId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("UserCodePrjMainPathId");
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
if (strAttributeName  ==  conUserCodePrjMainPath.UserCodePrjMainPathId)
{
return mstrUserCodePrjMainPathId;
}
else if (strAttributeName  ==  conUserCodePrjMainPath.CMProjectAppRelaId)
{
return mlngCMProjectAppRelaId;
}
else if (strAttributeName  ==  conUserCodePrjMainPath.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conUserCodePrjMainPath.ProgLangTypeId)
{
return mstrProgLangTypeId;
}
else if (strAttributeName  ==  conUserCodePrjMainPath.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conUserCodePrjMainPath.IsUsePrjMainPath)
{
return mbolIsUsePrjMainPath;
}
else if (strAttributeName  ==  conUserCodePrjMainPath.IncludeXmlPath)
{
return mstrIncludeXmlPath;
}
else if (strAttributeName  ==  conUserCodePrjMainPath.IsTemplate)
{
return mbolIsTemplate;
}
else if (strAttributeName  ==  conUserCodePrjMainPath.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  conUserCodePrjMainPath.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conUserCodePrjMainPath.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conUserCodePrjMainPath.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conUserCodePrjMainPath.UserCodePrjMainPathId)
{
mstrUserCodePrjMainPathId = value.ToString();
 AddUpdatedFld(conUserCodePrjMainPath.UserCodePrjMainPathId);
}
else if (strAttributeName  ==  conUserCodePrjMainPath.CMProjectAppRelaId)
{
mlngCMProjectAppRelaId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUserCodePrjMainPath.CMProjectAppRelaId);
}
else if (strAttributeName  ==  conUserCodePrjMainPath.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conUserCodePrjMainPath.PrjId);
}
else if (strAttributeName  ==  conUserCodePrjMainPath.ProgLangTypeId)
{
mstrProgLangTypeId = value.ToString();
 AddUpdatedFld(conUserCodePrjMainPath.ProgLangTypeId);
}
else if (strAttributeName  ==  conUserCodePrjMainPath.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conUserCodePrjMainPath.UserId);
}
else if (strAttributeName  ==  conUserCodePrjMainPath.IsUsePrjMainPath)
{
mbolIsUsePrjMainPath = TransNullToBool(value.ToString());
 AddUpdatedFld(conUserCodePrjMainPath.IsUsePrjMainPath);
}
else if (strAttributeName  ==  conUserCodePrjMainPath.IncludeXmlPath)
{
mstrIncludeXmlPath = value.ToString();
 AddUpdatedFld(conUserCodePrjMainPath.IncludeXmlPath);
}
else if (strAttributeName  ==  conUserCodePrjMainPath.IsTemplate)
{
mbolIsTemplate = TransNullToBool(value.ToString());
 AddUpdatedFld(conUserCodePrjMainPath.IsTemplate);
}
else if (strAttributeName  ==  conUserCodePrjMainPath.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conUserCodePrjMainPath.InUse);
}
else if (strAttributeName  ==  conUserCodePrjMainPath.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conUserCodePrjMainPath.UpdDate);
}
else if (strAttributeName  ==  conUserCodePrjMainPath.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conUserCodePrjMainPath.UpdUserId);
}
else if (strAttributeName  ==  conUserCodePrjMainPath.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conUserCodePrjMainPath.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conUserCodePrjMainPath.UserCodePrjMainPathId  ==  _AttributeName[intIndex])
{
return mstrUserCodePrjMainPathId;
}
else if (conUserCodePrjMainPath.CMProjectAppRelaId  ==  _AttributeName[intIndex])
{
return mlngCMProjectAppRelaId;
}
else if (conUserCodePrjMainPath.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conUserCodePrjMainPath.ProgLangTypeId  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeId;
}
else if (conUserCodePrjMainPath.UserId  ==  _AttributeName[intIndex])
{
return mstrUserId;
}
else if (conUserCodePrjMainPath.IsUsePrjMainPath  ==  _AttributeName[intIndex])
{
return mbolIsUsePrjMainPath;
}
else if (conUserCodePrjMainPath.IncludeXmlPath  ==  _AttributeName[intIndex])
{
return mstrIncludeXmlPath;
}
else if (conUserCodePrjMainPath.IsTemplate  ==  _AttributeName[intIndex])
{
return mbolIsTemplate;
}
else if (conUserCodePrjMainPath.InUse  ==  _AttributeName[intIndex])
{
return mbolInUse;
}
else if (conUserCodePrjMainPath.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conUserCodePrjMainPath.UpdUserId  ==  _AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conUserCodePrjMainPath.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conUserCodePrjMainPath.UserCodePrjMainPathId  ==  _AttributeName[intIndex])
{
mstrUserCodePrjMainPathId = value.ToString();
 AddUpdatedFld(conUserCodePrjMainPath.UserCodePrjMainPathId);
}
else if (conUserCodePrjMainPath.CMProjectAppRelaId  ==  _AttributeName[intIndex])
{
mlngCMProjectAppRelaId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUserCodePrjMainPath.CMProjectAppRelaId);
}
else if (conUserCodePrjMainPath.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conUserCodePrjMainPath.PrjId);
}
else if (conUserCodePrjMainPath.ProgLangTypeId  ==  _AttributeName[intIndex])
{
mstrProgLangTypeId = value.ToString();
 AddUpdatedFld(conUserCodePrjMainPath.ProgLangTypeId);
}
else if (conUserCodePrjMainPath.UserId  ==  _AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conUserCodePrjMainPath.UserId);
}
else if (conUserCodePrjMainPath.IsUsePrjMainPath  ==  _AttributeName[intIndex])
{
mbolIsUsePrjMainPath = TransNullToBool(value.ToString());
 AddUpdatedFld(conUserCodePrjMainPath.IsUsePrjMainPath);
}
else if (conUserCodePrjMainPath.IncludeXmlPath  ==  _AttributeName[intIndex])
{
mstrIncludeXmlPath = value.ToString();
 AddUpdatedFld(conUserCodePrjMainPath.IncludeXmlPath);
}
else if (conUserCodePrjMainPath.IsTemplate  ==  _AttributeName[intIndex])
{
mbolIsTemplate = TransNullToBool(value.ToString());
 AddUpdatedFld(conUserCodePrjMainPath.IsTemplate);
}
else if (conUserCodePrjMainPath.InUse  ==  _AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conUserCodePrjMainPath.InUse);
}
else if (conUserCodePrjMainPath.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conUserCodePrjMainPath.UpdDate);
}
else if (conUserCodePrjMainPath.UpdUserId  ==  _AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conUserCodePrjMainPath.UpdUserId);
}
else if (conUserCodePrjMainPath.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conUserCodePrjMainPath.Memo);
}
}
}

/// <summary>
/// 生成主目录Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserCodePrjMainPathId
{
get
{
return mstrUserCodePrjMainPathId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserCodePrjMainPathId = value;
}
else
{
 mstrUserCodePrjMainPathId = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserCodePrjMainPath.UserCodePrjMainPathId);
}
}
/// <summary>
/// Cm工程应用关系Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long CMProjectAppRelaId
{
get
{
return mlngCMProjectAppRelaId;
}
set
{
 mlngCMProjectAppRelaId = value;
//记录修改过的字段
 AddUpdatedFld(conUserCodePrjMainPath.CMProjectAppRelaId);
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
 AddUpdatedFld(conUserCodePrjMainPath.PrjId);
}
}
/// <summary>
/// 编程语言类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLangTypeId
{
get
{
return mstrProgLangTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLangTypeId = value;
}
else
{
 mstrProgLangTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserCodePrjMainPath.ProgLangTypeId);
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
 AddUpdatedFld(conUserCodePrjMainPath.UserId);
}
}
/// <summary>
/// 是否使用主路径(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsUsePrjMainPath
{
get
{
return mbolIsUsePrjMainPath;
}
set
{
 mbolIsUsePrjMainPath = value;
//记录修改过的字段
 AddUpdatedFld(conUserCodePrjMainPath.IsUsePrjMainPath);
}
}
/// <summary>
/// 包含表Xml路径(说明:;字段类型:varchar;字段长度:150;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IncludeXmlPath
{
get
{
return mstrIncludeXmlPath;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIncludeXmlPath = value;
}
else
{
 mstrIncludeXmlPath = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserCodePrjMainPath.IncludeXmlPath);
}
}
/// <summary>
/// 是否模板(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsTemplate
{
get
{
return mbolIsTemplate;
}
set
{
 mbolIsTemplate = value;
//记录修改过的字段
 AddUpdatedFld(conUserCodePrjMainPath.IsTemplate);
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
 AddUpdatedFld(conUserCodePrjMainPath.InUse);
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
 AddUpdatedFld(conUserCodePrjMainPath.UpdDate);
}
}
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUserId
{
get
{
return mstrUpdUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUserId = value;
}
else
{
 mstrUpdUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserCodePrjMainPath.UpdUserId);
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
 AddUpdatedFld(conUserCodePrjMainPath.Memo);
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
  return mstrUserCodePrjMainPathId;
 }
 }
}
 /// <summary>
 /// 用户生成项目主路径(UserCodePrjMainPath)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conUserCodePrjMainPath
{
public const string _CurrTabName = "UserCodePrjMainPath"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "UserCodePrjMainPathId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"UserCodePrjMainPathId", "CMProjectAppRelaId", "PrjId", "ProgLangTypeId", "UserId", "IsUsePrjMainPath", "IncludeXmlPath", "IsTemplate", "InUse", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"UserCodePrjMainPathId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserCodePrjMainPathId = "UserCodePrjMainPathId";    //生成主目录Id

 /// <summary>
 /// 常量:"CMProjectAppRelaId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CMProjectAppRelaId = "CMProjectAppRelaId";    //Cm工程应用关系Id

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"ProgLangTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeId = "ProgLangTypeId";    //编程语言类型Id

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户Id

 /// <summary>
 /// 常量:"IsUsePrjMainPath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsUsePrjMainPath = "IsUsePrjMainPath";    //是否使用主路径

 /// <summary>
 /// 常量:"IncludeXmlPath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IncludeXmlPath = "IncludeXmlPath";    //包含表Xml路径

 /// <summary>
 /// 常量:"IsTemplate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsTemplate = "IsTemplate";    //是否模板

 /// <summary>
 /// 常量:"InUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InUse = "InUse";    //是否在用

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}