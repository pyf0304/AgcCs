
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFunctionTemplateEN
 表名:vFunctionTemplate(00050316)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:45:42
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
 /// 表vFunctionTemplate的关键字(FunctionTemplateId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_FunctionTemplateId_vFunctionTemplate
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
public K_FunctionTemplateId_vFunctionTemplate(string strFunctionTemplateId)
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
 /// <returns>返回:[K_FunctionTemplateId_vFunctionTemplate]类型的对象</returns>
public static implicit operator K_FunctionTemplateId_vFunctionTemplate(string value)
{
return new K_FunctionTemplateId_vFunctionTemplate(value);
}
}
 /// <summary>
 /// v函数模板(vFunctionTemplate)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvFunctionTemplateEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vFunctionTemplate"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "FunctionTemplateId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 9;
public static string[] _AttributeName = new string[] {"FunctionTemplateId", "FunctionTemplateName", "ProgLangTypeId", "ProgLangTypeName", "CreateUserId", "UpdDate", "UpdUser", "Memo", "FunctionCount"};

protected string mstrFunctionTemplateId;    //函数模板Id
protected string mstrFunctionTemplateName;    //函数模板名
protected string mstrProgLangTypeId;    //编程语言类型Id
protected string mstrProgLangTypeName;    //编程语言类型名
protected string mstrCreateUserId;    //建立用户Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明
protected int? mintFunctionCount;    //函数数目

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvFunctionTemplateEN()
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
public clsvFunctionTemplateEN(string strFunctionTemplateId)
 {
strFunctionTemplateId = strFunctionTemplateId.Replace("'", "''");
if (strFunctionTemplateId.Length > 4)
{
throw new Exception("在表:vFunctionTemplate中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strFunctionTemplateId)  ==  true)
{
throw new Exception("在表:vFunctionTemplate中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convFunctionTemplate.FunctionTemplateId)
{
return mstrFunctionTemplateId;
}
else if (strAttributeName  ==  convFunctionTemplate.FunctionTemplateName)
{
return mstrFunctionTemplateName;
}
else if (strAttributeName  ==  convFunctionTemplate.ProgLangTypeId)
{
return mstrProgLangTypeId;
}
else if (strAttributeName  ==  convFunctionTemplate.ProgLangTypeName)
{
return mstrProgLangTypeName;
}
else if (strAttributeName  ==  convFunctionTemplate.CreateUserId)
{
return mstrCreateUserId;
}
else if (strAttributeName  ==  convFunctionTemplate.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convFunctionTemplate.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convFunctionTemplate.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convFunctionTemplate.FunctionCount)
{
return mintFunctionCount;
}
return null;
}
set
{
if (strAttributeName  ==  convFunctionTemplate.FunctionTemplateId)
{
mstrFunctionTemplateId = value.ToString();
 AddUpdatedFld(convFunctionTemplate.FunctionTemplateId);
}
else if (strAttributeName  ==  convFunctionTemplate.FunctionTemplateName)
{
mstrFunctionTemplateName = value.ToString();
 AddUpdatedFld(convFunctionTemplate.FunctionTemplateName);
}
else if (strAttributeName  ==  convFunctionTemplate.ProgLangTypeId)
{
mstrProgLangTypeId = value.ToString();
 AddUpdatedFld(convFunctionTemplate.ProgLangTypeId);
}
else if (strAttributeName  ==  convFunctionTemplate.ProgLangTypeName)
{
mstrProgLangTypeName = value.ToString();
 AddUpdatedFld(convFunctionTemplate.ProgLangTypeName);
}
else if (strAttributeName  ==  convFunctionTemplate.CreateUserId)
{
mstrCreateUserId = value.ToString();
 AddUpdatedFld(convFunctionTemplate.CreateUserId);
}
else if (strAttributeName  ==  convFunctionTemplate.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFunctionTemplate.UpdDate);
}
else if (strAttributeName  ==  convFunctionTemplate.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFunctionTemplate.UpdUser);
}
else if (strAttributeName  ==  convFunctionTemplate.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFunctionTemplate.Memo);
}
else if (strAttributeName  ==  convFunctionTemplate.FunctionCount)
{
mintFunctionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convFunctionTemplate.FunctionCount);
}
}
}
public object this[int intIndex]
{
get
{
if (convFunctionTemplate.FunctionTemplateId  ==  _AttributeName[intIndex])
{
return mstrFunctionTemplateId;
}
else if (convFunctionTemplate.FunctionTemplateName  ==  _AttributeName[intIndex])
{
return mstrFunctionTemplateName;
}
else if (convFunctionTemplate.ProgLangTypeId  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeId;
}
else if (convFunctionTemplate.ProgLangTypeName  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeName;
}
else if (convFunctionTemplate.CreateUserId  ==  _AttributeName[intIndex])
{
return mstrCreateUserId;
}
else if (convFunctionTemplate.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convFunctionTemplate.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convFunctionTemplate.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (convFunctionTemplate.FunctionCount  ==  _AttributeName[intIndex])
{
return mintFunctionCount;
}
return null;
}
set
{
if (convFunctionTemplate.FunctionTemplateId  ==  _AttributeName[intIndex])
{
mstrFunctionTemplateId = value.ToString();
 AddUpdatedFld(convFunctionTemplate.FunctionTemplateId);
}
else if (convFunctionTemplate.FunctionTemplateName  ==  _AttributeName[intIndex])
{
mstrFunctionTemplateName = value.ToString();
 AddUpdatedFld(convFunctionTemplate.FunctionTemplateName);
}
else if (convFunctionTemplate.ProgLangTypeId  ==  _AttributeName[intIndex])
{
mstrProgLangTypeId = value.ToString();
 AddUpdatedFld(convFunctionTemplate.ProgLangTypeId);
}
else if (convFunctionTemplate.ProgLangTypeName  ==  _AttributeName[intIndex])
{
mstrProgLangTypeName = value.ToString();
 AddUpdatedFld(convFunctionTemplate.ProgLangTypeName);
}
else if (convFunctionTemplate.CreateUserId  ==  _AttributeName[intIndex])
{
mstrCreateUserId = value.ToString();
 AddUpdatedFld(convFunctionTemplate.CreateUserId);
}
else if (convFunctionTemplate.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFunctionTemplate.UpdDate);
}
else if (convFunctionTemplate.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFunctionTemplate.UpdUser);
}
else if (convFunctionTemplate.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFunctionTemplate.Memo);
}
else if (convFunctionTemplate.FunctionCount  ==  _AttributeName[intIndex])
{
mintFunctionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convFunctionTemplate.FunctionCount);
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
 AddUpdatedFld(convFunctionTemplate.FunctionTemplateId);
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
 AddUpdatedFld(convFunctionTemplate.FunctionTemplateName);
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
 AddUpdatedFld(convFunctionTemplate.ProgLangTypeId);
}
}
/// <summary>
/// 编程语言类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLangTypeName
{
get
{
return mstrProgLangTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLangTypeName = value;
}
else
{
 mstrProgLangTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunctionTemplate.ProgLangTypeName);
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
 AddUpdatedFld(convFunctionTemplate.CreateUserId);
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
 AddUpdatedFld(convFunctionTemplate.UpdDate);
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
 AddUpdatedFld(convFunctionTemplate.UpdUser);
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
 AddUpdatedFld(convFunctionTemplate.Memo);
}
}
/// <summary>
/// 函数数目(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? FunctionCount
{
get
{
return mintFunctionCount;
}
set
{
 mintFunctionCount = value;
//记录修改过的字段
 AddUpdatedFld(convFunctionTemplate.FunctionCount);
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
}
 /// <summary>
 /// v函数模板(vFunctionTemplate)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convFunctionTemplate
{
public const string _CurrTabName = "vFunctionTemplate"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FunctionTemplateId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"FunctionTemplateId", "FunctionTemplateName", "ProgLangTypeId", "ProgLangTypeName", "CreateUserId", "UpdDate", "UpdUser", "Memo", "FunctionCount"};
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
 /// 常量:"ProgLangTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeId = "ProgLangTypeId";    //编程语言类型Id

 /// <summary>
 /// 常量:"ProgLangTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeName = "ProgLangTypeName";    //编程语言类型名

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

 /// <summary>
 /// 常量:"FunctionCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FunctionCount = "FunctionCount";    //函数数目
}

}