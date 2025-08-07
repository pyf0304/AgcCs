
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFunctionGroupEN
 表名:FunctionGroup(00050325)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:36:22
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
 /// 表FunctionGroup的关键字(FunctionGroupId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_FunctionGroupId_FunctionGroup
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strFunctionGroupId">表关键字</param>
public K_FunctionGroupId_FunctionGroup(string strFunctionGroupId)
{
if (IsValid(strFunctionGroupId)) Value = strFunctionGroupId;
else
{
Value = null;
}
}
private static bool IsValid(string strFunctionGroupId)
{
if (string.IsNullOrEmpty(strFunctionGroupId) == true) return false;
if (strFunctionGroupId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_FunctionGroupId_FunctionGroup]类型的对象</returns>
public static implicit operator K_FunctionGroupId_FunctionGroup(string value)
{
return new K_FunctionGroupId_FunctionGroup(value);
}
}
 /// <summary>
 /// 功能函数组(FunctionGroup)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsFunctionGroupEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "FunctionGroup"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "FunctionGroupId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 7;
public static string[] _AttributeName = new string[] {"FunctionGroupId", "FunctionGroupName", "ProgLangTypeId", "CreateUserId", "UpdDate", "UpdUser", "Memo"};

protected string mstrFunctionGroupId;    //函数组Id
protected string mstrFunctionGroupName;    //函数组名称
protected string mstrProgLangTypeId;    //编程语言类型Id
protected string mstrCreateUserId;    //建立用户Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsFunctionGroupEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FunctionGroupId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strFunctionGroupId">关键字:函数组Id</param>
public clsFunctionGroupEN(string strFunctionGroupId)
 {
strFunctionGroupId = strFunctionGroupId.Replace("'", "''");
if (strFunctionGroupId.Length > 4)
{
throw new Exception("在表:FunctionGroup中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strFunctionGroupId)  ==  true)
{
throw new Exception("在表:FunctionGroup中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFunctionGroupId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrFunctionGroupId = strFunctionGroupId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FunctionGroupId");
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
if (strAttributeName  ==  conFunctionGroup.FunctionGroupId)
{
return mstrFunctionGroupId;
}
else if (strAttributeName  ==  conFunctionGroup.FunctionGroupName)
{
return mstrFunctionGroupName;
}
else if (strAttributeName  ==  conFunctionGroup.ProgLangTypeId)
{
return mstrProgLangTypeId;
}
else if (strAttributeName  ==  conFunctionGroup.CreateUserId)
{
return mstrCreateUserId;
}
else if (strAttributeName  ==  conFunctionGroup.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conFunctionGroup.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conFunctionGroup.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conFunctionGroup.FunctionGroupId)
{
mstrFunctionGroupId = value.ToString();
 AddUpdatedFld(conFunctionGroup.FunctionGroupId);
}
else if (strAttributeName  ==  conFunctionGroup.FunctionGroupName)
{
mstrFunctionGroupName = value.ToString();
 AddUpdatedFld(conFunctionGroup.FunctionGroupName);
}
else if (strAttributeName  ==  conFunctionGroup.ProgLangTypeId)
{
mstrProgLangTypeId = value.ToString();
 AddUpdatedFld(conFunctionGroup.ProgLangTypeId);
}
else if (strAttributeName  ==  conFunctionGroup.CreateUserId)
{
mstrCreateUserId = value.ToString();
 AddUpdatedFld(conFunctionGroup.CreateUserId);
}
else if (strAttributeName  ==  conFunctionGroup.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFunctionGroup.UpdDate);
}
else if (strAttributeName  ==  conFunctionGroup.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conFunctionGroup.UpdUser);
}
else if (strAttributeName  ==  conFunctionGroup.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFunctionGroup.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conFunctionGroup.FunctionGroupId  ==  _AttributeName[intIndex])
{
return mstrFunctionGroupId;
}
else if (conFunctionGroup.FunctionGroupName  ==  _AttributeName[intIndex])
{
return mstrFunctionGroupName;
}
else if (conFunctionGroup.ProgLangTypeId  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeId;
}
else if (conFunctionGroup.CreateUserId  ==  _AttributeName[intIndex])
{
return mstrCreateUserId;
}
else if (conFunctionGroup.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conFunctionGroup.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conFunctionGroup.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conFunctionGroup.FunctionGroupId  ==  _AttributeName[intIndex])
{
mstrFunctionGroupId = value.ToString();
 AddUpdatedFld(conFunctionGroup.FunctionGroupId);
}
else if (conFunctionGroup.FunctionGroupName  ==  _AttributeName[intIndex])
{
mstrFunctionGroupName = value.ToString();
 AddUpdatedFld(conFunctionGroup.FunctionGroupName);
}
else if (conFunctionGroup.ProgLangTypeId  ==  _AttributeName[intIndex])
{
mstrProgLangTypeId = value.ToString();
 AddUpdatedFld(conFunctionGroup.ProgLangTypeId);
}
else if (conFunctionGroup.CreateUserId  ==  _AttributeName[intIndex])
{
mstrCreateUserId = value.ToString();
 AddUpdatedFld(conFunctionGroup.CreateUserId);
}
else if (conFunctionGroup.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFunctionGroup.UpdDate);
}
else if (conFunctionGroup.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conFunctionGroup.UpdUser);
}
else if (conFunctionGroup.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFunctionGroup.Memo);
}
}
}

/// <summary>
/// 函数组Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FunctionGroupId
{
get
{
return mstrFunctionGroupId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFunctionGroupId = value;
}
else
{
 mstrFunctionGroupId = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunctionGroup.FunctionGroupId);
}
}
/// <summary>
/// 函数组名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FunctionGroupName
{
get
{
return mstrFunctionGroupName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFunctionGroupName = value;
}
else
{
 mstrFunctionGroupName = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunctionGroup.FunctionGroupName);
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
 AddUpdatedFld(conFunctionGroup.ProgLangTypeId);
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
 AddUpdatedFld(conFunctionGroup.CreateUserId);
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
 AddUpdatedFld(conFunctionGroup.UpdDate);
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
 AddUpdatedFld(conFunctionGroup.UpdUser);
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
 AddUpdatedFld(conFunctionGroup.Memo);
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
  return mstrFunctionGroupId;
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
  return mstrFunctionGroupName;
 }
 }
}
 /// <summary>
 /// 功能函数组(FunctionGroup)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conFunctionGroup
{
public const string _CurrTabName = "FunctionGroup"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FunctionGroupId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"FunctionGroupId", "FunctionGroupName", "ProgLangTypeId", "CreateUserId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"FunctionGroupId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FunctionGroupId = "FunctionGroupId";    //函数组Id

 /// <summary>
 /// 常量:"FunctionGroupName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FunctionGroupName = "FunctionGroupName";    //函数组名称

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