
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFunctionTemplateEN
 表名:FunctionTemplate(00050312)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:34:04
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
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
 /// 表FunctionTemplate的关键字(FunctionTemplateId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_FunctionTemplateId_FunctionTemplate
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strFunctionTemplateId">表关键字</param>
public K_FunctionTemplateId_FunctionTemplate(string strFunctionTemplateId)
{
if (IsValid(strFunctionTemplateId)) Value = strFunctionTemplateId;
else
{
Value = null;
}
}
private static bool IsValid(string strFunctionTemplateId)
{
if (string.IsNullOrEmpty(strFunctionTemplateId) == true) return false;
if (strFunctionTemplateId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_FunctionTemplateId_FunctionTemplate]类型的对象</returns>
public static implicit operator K_FunctionTemplateId_FunctionTemplate(string value)
{
return new K_FunctionTemplateId_FunctionTemplate(value);
}
}
 /// <summary>
 /// 函数模板(FunctionTemplate)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsFunctionTemplateEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "FunctionTemplate"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "FunctionTemplateId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 8;
public static string[] _AttributeName = new string[] {"FunctionTemplateId", "FunctionTemplateName", "FunctionTemplateENName", "ProgLangTypeId", "CreateUserId", "UpdDate", "UpdUser", "Memo"};

protected string mstrFunctionTemplateId;    //函数模板Id
protected string mstrFunctionTemplateName;    //函数模板名
protected string mstrFunctionTemplateENName;    //函数模板英文名
protected string mstrProgLangTypeId;    //编程语言类型Id
protected string mstrCreateUserId;    //建立用户Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsFunctionTemplateEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FunctionTemplateId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strFunctionTemplateId">关键字:函数模板Id</param>
public clsFunctionTemplateEN(string strFunctionTemplateId)
 {
strFunctionTemplateId = strFunctionTemplateId.Replace("'", "''");
if (strFunctionTemplateId.Length > 4)
{
throw new Exception("在表:FunctionTemplate中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strFunctionTemplateId)  ==  true)
{
throw new Exception("在表:FunctionTemplate中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFunctionTemplateId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrFunctionTemplateId = strFunctionTemplateId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FunctionTemplateId");
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
if (strAttributeName  ==  conFunctionTemplate.FunctionTemplateId)
{
return mstrFunctionTemplateId;
}
else if (strAttributeName  ==  conFunctionTemplate.FunctionTemplateName)
{
return mstrFunctionTemplateName;
}
else if (strAttributeName  ==  conFunctionTemplate.FunctionTemplateENName)
{
return mstrFunctionTemplateENName;
}
else if (strAttributeName  ==  conFunctionTemplate.ProgLangTypeId)
{
return mstrProgLangTypeId;
}
else if (strAttributeName  ==  conFunctionTemplate.CreateUserId)
{
return mstrCreateUserId;
}
else if (strAttributeName  ==  conFunctionTemplate.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conFunctionTemplate.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conFunctionTemplate.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conFunctionTemplate.FunctionTemplateId)
{
mstrFunctionTemplateId = value.ToString();
 AddUpdatedFld(conFunctionTemplate.FunctionTemplateId);
}
else if (strAttributeName  ==  conFunctionTemplate.FunctionTemplateName)
{
mstrFunctionTemplateName = value.ToString();
 AddUpdatedFld(conFunctionTemplate.FunctionTemplateName);
}
else if (strAttributeName  ==  conFunctionTemplate.FunctionTemplateENName)
{
mstrFunctionTemplateENName = value.ToString();
 AddUpdatedFld(conFunctionTemplate.FunctionTemplateENName);
}
else if (strAttributeName  ==  conFunctionTemplate.ProgLangTypeId)
{
mstrProgLangTypeId = value.ToString();
 AddUpdatedFld(conFunctionTemplate.ProgLangTypeId);
}
else if (strAttributeName  ==  conFunctionTemplate.CreateUserId)
{
mstrCreateUserId = value.ToString();
 AddUpdatedFld(conFunctionTemplate.CreateUserId);
}
else if (strAttributeName  ==  conFunctionTemplate.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFunctionTemplate.UpdDate);
}
else if (strAttributeName  ==  conFunctionTemplate.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conFunctionTemplate.UpdUser);
}
else if (strAttributeName  ==  conFunctionTemplate.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFunctionTemplate.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conFunctionTemplate.FunctionTemplateId  ==  _AttributeName[intIndex])
{
return mstrFunctionTemplateId;
}
else if (conFunctionTemplate.FunctionTemplateName  ==  _AttributeName[intIndex])
{
return mstrFunctionTemplateName;
}
else if (conFunctionTemplate.FunctionTemplateENName  ==  _AttributeName[intIndex])
{
return mstrFunctionTemplateENName;
}
else if (conFunctionTemplate.ProgLangTypeId  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeId;
}
else if (conFunctionTemplate.CreateUserId  ==  _AttributeName[intIndex])
{
return mstrCreateUserId;
}
else if (conFunctionTemplate.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conFunctionTemplate.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conFunctionTemplate.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conFunctionTemplate.FunctionTemplateId  ==  _AttributeName[intIndex])
{
mstrFunctionTemplateId = value.ToString();
 AddUpdatedFld(conFunctionTemplate.FunctionTemplateId);
}
else if (conFunctionTemplate.FunctionTemplateName  ==  _AttributeName[intIndex])
{
mstrFunctionTemplateName = value.ToString();
 AddUpdatedFld(conFunctionTemplate.FunctionTemplateName);
}
else if (conFunctionTemplate.FunctionTemplateENName  ==  _AttributeName[intIndex])
{
mstrFunctionTemplateENName = value.ToString();
 AddUpdatedFld(conFunctionTemplate.FunctionTemplateENName);
}
else if (conFunctionTemplate.ProgLangTypeId  ==  _AttributeName[intIndex])
{
mstrProgLangTypeId = value.ToString();
 AddUpdatedFld(conFunctionTemplate.ProgLangTypeId);
}
else if (conFunctionTemplate.CreateUserId  ==  _AttributeName[intIndex])
{
mstrCreateUserId = value.ToString();
 AddUpdatedFld(conFunctionTemplate.CreateUserId);
}
else if (conFunctionTemplate.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFunctionTemplate.UpdDate);
}
else if (conFunctionTemplate.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conFunctionTemplate.UpdUser);
}
else if (conFunctionTemplate.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFunctionTemplate.Memo);
}
}
}

/// <summary>
/// 函数模板Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FunctionTemplateId
{
get
{
return mstrFunctionTemplateId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFunctionTemplateId = value;
}
else
{
 mstrFunctionTemplateId = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunctionTemplate.FunctionTemplateId);
}
}
/// <summary>
/// 函数模板名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FunctionTemplateName
{
get
{
return mstrFunctionTemplateName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFunctionTemplateName = value;
}
else
{
 mstrFunctionTemplateName = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunctionTemplate.FunctionTemplateName);
}
}
/// <summary>
/// 函数模板英文名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FunctionTemplateENName
{
get
{
return mstrFunctionTemplateENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFunctionTemplateENName = value;
}
else
{
 mstrFunctionTemplateENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunctionTemplate.FunctionTemplateENName);
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
 AddUpdatedFld(conFunctionTemplate.ProgLangTypeId);
}
}
/// <summary>
/// 建立用户Id(说明:;字段类型:varchar;字段长度:18;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CreateUserId
{
get
{
return mstrCreateUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCreateUserId = value;
}
else
{
 mstrCreateUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunctionTemplate.CreateUserId);
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
 AddUpdatedFld(conFunctionTemplate.UpdDate);
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
 AddUpdatedFld(conFunctionTemplate.UpdUser);
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
 AddUpdatedFld(conFunctionTemplate.Memo);
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
  return mstrFunctionTemplateId;
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
  return mstrFunctionTemplateName;
 }
 }
}
 /// <summary>
 /// 函数模板(FunctionTemplate)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conFunctionTemplate
{
public const string _CurrTabName = "FunctionTemplate"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FunctionTemplateId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"FunctionTemplateId", "FunctionTemplateName", "FunctionTemplateENName", "ProgLangTypeId", "CreateUserId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"FunctionTemplateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FunctionTemplateId = "FunctionTemplateId";    //函数模板Id

 /// <summary>
 /// 常量:"FunctionTemplateName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FunctionTemplateName = "FunctionTemplateName";    //函数模板名

 /// <summary>
 /// 常量:"FunctionTemplateENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FunctionTemplateENName = "FunctionTemplateENName";    //函数模板英文名

 /// <summary>
 /// 常量:"ProgLangTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeId = "ProgLangTypeId";    //编程语言类型Id

 /// <summary>
 /// 常量:"CreateUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreateUserId = "CreateUserId";    //建立用户Id

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