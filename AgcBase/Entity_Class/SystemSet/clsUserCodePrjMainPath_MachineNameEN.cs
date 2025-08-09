
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUserCodePrjMainPath_MachineNameEN
 表名:UserCodePrjMainPath_MachineName(00050614)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:03:29
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
 /// 表UserCodePrjMainPath_MachineName的关键字(UserCodePrjMainPathId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_UserCodePrjMainPathId_UserCodePrjMainPath_MachineName
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
public K_UserCodePrjMainPathId_UserCodePrjMainPath_MachineName(string strUserCodePrjMainPathId)
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
 /// <returns>返回:[K_UserCodePrjMainPathId_UserCodePrjMainPath_MachineName]类型的对象</returns>
public static implicit operator K_UserCodePrjMainPathId_UserCodePrjMainPath_MachineName(string value)
{
return new K_UserCodePrjMainPathId_UserCodePrjMainPath_MachineName(value);
}
}
 /// <summary>
 /// 用户生成项目主路径_PC(UserCodePrjMainPath_MachineName)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsUserCodePrjMainPath_MachineNameEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "UserCodePrjMainPath_MachineName"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "UserCodePrjMainPathId,MachineName"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 11;
public static string[] _AttributeName = new string[] {"UserCodePrjMainPathId", "MachineName", "CodePath", "GcPathId", "CodePathBackup", "LogPath", "IncludeXmlPath", "PrjId", "UpdDate", "UpdUserId", "Memo"};

protected string mstrUserCodePrjMainPathId;    //生成主目录Id
protected string mstrMachineName;    //机器名
protected string mstrCodePath;    //代码路径
protected string mstrGcPathId;    //GC路径Id
protected string mstrCodePathBackup;    //备份代码路径
protected string mstrLogPath;    //日志路径
protected string mstrIncludeXmlPath;    //包含表Xml路径
protected string mstrPrjId;    //工程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsUserCodePrjMainPath_MachineNameEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("UserCodePrjMainPathId");
 lstKeyFldNames.Add("MachineName");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strUserCodePrjMainPathId">关键字:生成主目录Id</param>
public clsUserCodePrjMainPath_MachineNameEN(string strUserCodePrjMainPathId , string strMachineName)
 {
strUserCodePrjMainPathId = strUserCodePrjMainPathId.Replace("'", "''");
if (strUserCodePrjMainPathId.Length > 8)
{
throw new Exception("在表:UserCodePrjMainPath_MachineName中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strUserCodePrjMainPathId)  ==  true)
{
throw new Exception("在表:UserCodePrjMainPath_MachineName中,关键字不能为空 或 null!");
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
this.mstrMachineName = strMachineName;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("UserCodePrjMainPathId");
 lstKeyFldNames.Add("MachineName");
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
if (strAttributeName  ==  conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId)
{
return mstrUserCodePrjMainPathId;
}
else if (strAttributeName  ==  conUserCodePrjMainPath_MachineName.MachineName)
{
return mstrMachineName;
}
else if (strAttributeName  ==  conUserCodePrjMainPath_MachineName.CodePath)
{
return mstrCodePath;
}
else if (strAttributeName  ==  conUserCodePrjMainPath_MachineName.GcPathId)
{
return mstrGcPathId;
}
else if (strAttributeName  ==  conUserCodePrjMainPath_MachineName.CodePathBackup)
{
return mstrCodePathBackup;
}
else if (strAttributeName  ==  conUserCodePrjMainPath_MachineName.LogPath)
{
return mstrLogPath;
}
else if (strAttributeName  ==  conUserCodePrjMainPath_MachineName.IncludeXmlPath)
{
return mstrIncludeXmlPath;
}
else if (strAttributeName  ==  conUserCodePrjMainPath_MachineName.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conUserCodePrjMainPath_MachineName.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conUserCodePrjMainPath_MachineName.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conUserCodePrjMainPath_MachineName.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId)
{
mstrUserCodePrjMainPathId = value.ToString();
 AddUpdatedFld(conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId);
}
else if (strAttributeName  ==  conUserCodePrjMainPath_MachineName.MachineName)
{
mstrMachineName = value.ToString();
 AddUpdatedFld(conUserCodePrjMainPath_MachineName.MachineName);
}
else if (strAttributeName  ==  conUserCodePrjMainPath_MachineName.CodePath)
{
mstrCodePath = value.ToString();
 AddUpdatedFld(conUserCodePrjMainPath_MachineName.CodePath);
}
else if (strAttributeName  ==  conUserCodePrjMainPath_MachineName.GcPathId)
{
mstrGcPathId = value.ToString();
 AddUpdatedFld(conUserCodePrjMainPath_MachineName.GcPathId);
}
else if (strAttributeName  ==  conUserCodePrjMainPath_MachineName.CodePathBackup)
{
mstrCodePathBackup = value.ToString();
 AddUpdatedFld(conUserCodePrjMainPath_MachineName.CodePathBackup);
}
else if (strAttributeName  ==  conUserCodePrjMainPath_MachineName.LogPath)
{
mstrLogPath = value.ToString();
 AddUpdatedFld(conUserCodePrjMainPath_MachineName.LogPath);
}
else if (strAttributeName  ==  conUserCodePrjMainPath_MachineName.IncludeXmlPath)
{
mstrIncludeXmlPath = value.ToString();
 AddUpdatedFld(conUserCodePrjMainPath_MachineName.IncludeXmlPath);
}
else if (strAttributeName  ==  conUserCodePrjMainPath_MachineName.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conUserCodePrjMainPath_MachineName.PrjId);
}
else if (strAttributeName  ==  conUserCodePrjMainPath_MachineName.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conUserCodePrjMainPath_MachineName.UpdDate);
}
else if (strAttributeName  ==  conUserCodePrjMainPath_MachineName.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conUserCodePrjMainPath_MachineName.UpdUserId);
}
else if (strAttributeName  ==  conUserCodePrjMainPath_MachineName.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conUserCodePrjMainPath_MachineName.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId  ==  _AttributeName[intIndex])
{
return mstrUserCodePrjMainPathId;
}
else if (conUserCodePrjMainPath_MachineName.MachineName  ==  _AttributeName[intIndex])
{
return mstrMachineName;
}
else if (conUserCodePrjMainPath_MachineName.CodePath  ==  _AttributeName[intIndex])
{
return mstrCodePath;
}
else if (conUserCodePrjMainPath_MachineName.GcPathId  ==  _AttributeName[intIndex])
{
return mstrGcPathId;
}
else if (conUserCodePrjMainPath_MachineName.CodePathBackup  ==  _AttributeName[intIndex])
{
return mstrCodePathBackup;
}
else if (conUserCodePrjMainPath_MachineName.LogPath  ==  _AttributeName[intIndex])
{
return mstrLogPath;
}
else if (conUserCodePrjMainPath_MachineName.IncludeXmlPath  ==  _AttributeName[intIndex])
{
return mstrIncludeXmlPath;
}
else if (conUserCodePrjMainPath_MachineName.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conUserCodePrjMainPath_MachineName.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conUserCodePrjMainPath_MachineName.UpdUserId  ==  _AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conUserCodePrjMainPath_MachineName.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId  ==  _AttributeName[intIndex])
{
mstrUserCodePrjMainPathId = value.ToString();
 AddUpdatedFld(conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId);
}
else if (conUserCodePrjMainPath_MachineName.MachineName  ==  _AttributeName[intIndex])
{
mstrMachineName = value.ToString();
 AddUpdatedFld(conUserCodePrjMainPath_MachineName.MachineName);
}
else if (conUserCodePrjMainPath_MachineName.CodePath  ==  _AttributeName[intIndex])
{
mstrCodePath = value.ToString();
 AddUpdatedFld(conUserCodePrjMainPath_MachineName.CodePath);
}
else if (conUserCodePrjMainPath_MachineName.GcPathId  ==  _AttributeName[intIndex])
{
mstrGcPathId = value.ToString();
 AddUpdatedFld(conUserCodePrjMainPath_MachineName.GcPathId);
}
else if (conUserCodePrjMainPath_MachineName.CodePathBackup  ==  _AttributeName[intIndex])
{
mstrCodePathBackup = value.ToString();
 AddUpdatedFld(conUserCodePrjMainPath_MachineName.CodePathBackup);
}
else if (conUserCodePrjMainPath_MachineName.LogPath  ==  _AttributeName[intIndex])
{
mstrLogPath = value.ToString();
 AddUpdatedFld(conUserCodePrjMainPath_MachineName.LogPath);
}
else if (conUserCodePrjMainPath_MachineName.IncludeXmlPath  ==  _AttributeName[intIndex])
{
mstrIncludeXmlPath = value.ToString();
 AddUpdatedFld(conUserCodePrjMainPath_MachineName.IncludeXmlPath);
}
else if (conUserCodePrjMainPath_MachineName.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conUserCodePrjMainPath_MachineName.PrjId);
}
else if (conUserCodePrjMainPath_MachineName.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conUserCodePrjMainPath_MachineName.UpdDate);
}
else if (conUserCodePrjMainPath_MachineName.UpdUserId  ==  _AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conUserCodePrjMainPath_MachineName.UpdUserId);
}
else if (conUserCodePrjMainPath_MachineName.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conUserCodePrjMainPath_MachineName.Memo);
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
 AddUpdatedFld(conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId);
}
}
/// <summary>
/// 机器名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MachineName
{
get
{
return mstrMachineName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMachineName = value;
}
else
{
 mstrMachineName = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserCodePrjMainPath_MachineName.MachineName);
}
}
/// <summary>
/// 代码路径(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodePath
{
get
{
return mstrCodePath;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodePath = value;
}
else
{
 mstrCodePath = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserCodePrjMainPath_MachineName.CodePath);
}
}
/// <summary>
/// GC路径Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GcPathId
{
get
{
return mstrGcPathId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGcPathId = value;
}
else
{
 mstrGcPathId = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserCodePrjMainPath_MachineName.GcPathId);
}
}
/// <summary>
/// 备份代码路径(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodePathBackup
{
get
{
return mstrCodePathBackup;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodePathBackup = value;
}
else
{
 mstrCodePathBackup = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserCodePrjMainPath_MachineName.CodePathBackup);
}
}
/// <summary>
/// 日志路径(说明:;字段类型:varchar;字段长度:150;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LogPath
{
get
{
return mstrLogPath;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLogPath = value;
}
else
{
 mstrLogPath = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserCodePrjMainPath_MachineName.LogPath);
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
 AddUpdatedFld(conUserCodePrjMainPath_MachineName.IncludeXmlPath);
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
 AddUpdatedFld(conUserCodePrjMainPath_MachineName.PrjId);
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
 AddUpdatedFld(conUserCodePrjMainPath_MachineName.UpdDate);
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
 AddUpdatedFld(conUserCodePrjMainPath_MachineName.UpdUserId);
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
 AddUpdatedFld(conUserCodePrjMainPath_MachineName.Memo);
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
 /// 用户生成项目主路径_PC(UserCodePrjMainPath_MachineName)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conUserCodePrjMainPath_MachineName
{
public const string _CurrTabName = "UserCodePrjMainPath_MachineName"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "UserCodePrjMainPathId,MachineName"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"UserCodePrjMainPathId", "MachineName", "CodePath", "GcPathId", "CodePathBackup", "LogPath", "IncludeXmlPath", "PrjId", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"UserCodePrjMainPathId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserCodePrjMainPathId = "UserCodePrjMainPathId";    //生成主目录Id

 /// <summary>
 /// 常量:"MachineName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MachineName = "MachineName";    //机器名

 /// <summary>
 /// 常量:"CodePath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodePath = "CodePath";    //代码路径

 /// <summary>
 /// 常量:"GcPathId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GcPathId = "GcPathId";    //GC路径Id

 /// <summary>
 /// 常量:"CodePathBackup"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodePathBackup = "CodePathBackup";    //备份代码路径

 /// <summary>
 /// 常量:"LogPath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LogPath = "LogPath";    //日志路径

 /// <summary>
 /// 常量:"IncludeXmlPath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IncludeXmlPath = "IncludeXmlPath";    //包含表Xml路径

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