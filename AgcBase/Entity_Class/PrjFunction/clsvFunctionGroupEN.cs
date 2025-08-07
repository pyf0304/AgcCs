
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFunctionGroupEN
 表名:vFunctionGroup(00050326)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:45:35
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
 /// 表vFunctionGroup的关键字(FunctionGroupId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_FunctionGroupId_vFunctionGroup
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
public K_FunctionGroupId_vFunctionGroup(string strFunctionGroupId)
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
 /// <returns>返回:[K_FunctionGroupId_vFunctionGroup]类型的对象</returns>
public static implicit operator K_FunctionGroupId_vFunctionGroup(string value)
{
return new K_FunctionGroupId_vFunctionGroup(value);
}
}
 /// <summary>
 /// v函数组(vFunctionGroup)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvFunctionGroupEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vFunctionGroup"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "FunctionGroupId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 8;
public static string[] _AttributeName = new string[] {"FunctionGroupId", "FunctionGroupName", "ProgLangTypeId", "ProgLangTypeName", "CreateUserId", "UpdDate", "UpdUser", "Memo"};

protected string mstrFunctionGroupId;    //函数组Id
protected string mstrFunctionGroupName;    //函数组名称
protected string mstrProgLangTypeId;    //编程语言类型Id
protected string mstrProgLangTypeName;    //编程语言类型名
protected string mstrCreateUserId;    //建立用户Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvFunctionGroupEN()
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
public clsvFunctionGroupEN(string strFunctionGroupId)
 {
strFunctionGroupId = strFunctionGroupId.Replace("'", "''");
if (strFunctionGroupId.Length > 4)
{
throw new Exception("在表:vFunctionGroup中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strFunctionGroupId)  ==  true)
{
throw new Exception("在表:vFunctionGroup中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convFunctionGroup.FunctionGroupId)
{
return mstrFunctionGroupId;
}
else if (strAttributeName  ==  convFunctionGroup.FunctionGroupName)
{
return mstrFunctionGroupName;
}
else if (strAttributeName  ==  convFunctionGroup.ProgLangTypeId)
{
return mstrProgLangTypeId;
}
else if (strAttributeName  ==  convFunctionGroup.ProgLangTypeName)
{
return mstrProgLangTypeName;
}
else if (strAttributeName  ==  convFunctionGroup.CreateUserId)
{
return mstrCreateUserId;
}
else if (strAttributeName  ==  convFunctionGroup.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convFunctionGroup.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convFunctionGroup.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convFunctionGroup.FunctionGroupId)
{
mstrFunctionGroupId = value.ToString();
 AddUpdatedFld(convFunctionGroup.FunctionGroupId);
}
else if (strAttributeName  ==  convFunctionGroup.FunctionGroupName)
{
mstrFunctionGroupName = value.ToString();
 AddUpdatedFld(convFunctionGroup.FunctionGroupName);
}
else if (strAttributeName  ==  convFunctionGroup.ProgLangTypeId)
{
mstrProgLangTypeId = value.ToString();
 AddUpdatedFld(convFunctionGroup.ProgLangTypeId);
}
else if (strAttributeName  ==  convFunctionGroup.ProgLangTypeName)
{
mstrProgLangTypeName = value.ToString();
 AddUpdatedFld(convFunctionGroup.ProgLangTypeName);
}
else if (strAttributeName  ==  convFunctionGroup.CreateUserId)
{
mstrCreateUserId = value.ToString();
 AddUpdatedFld(convFunctionGroup.CreateUserId);
}
else if (strAttributeName  ==  convFunctionGroup.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFunctionGroup.UpdDate);
}
else if (strAttributeName  ==  convFunctionGroup.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFunctionGroup.UpdUser);
}
else if (strAttributeName  ==  convFunctionGroup.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFunctionGroup.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convFunctionGroup.FunctionGroupId  ==  _AttributeName[intIndex])
{
return mstrFunctionGroupId;
}
else if (convFunctionGroup.FunctionGroupName  ==  _AttributeName[intIndex])
{
return mstrFunctionGroupName;
}
else if (convFunctionGroup.ProgLangTypeId  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeId;
}
else if (convFunctionGroup.ProgLangTypeName  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeName;
}
else if (convFunctionGroup.CreateUserId  ==  _AttributeName[intIndex])
{
return mstrCreateUserId;
}
else if (convFunctionGroup.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convFunctionGroup.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convFunctionGroup.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convFunctionGroup.FunctionGroupId  ==  _AttributeName[intIndex])
{
mstrFunctionGroupId = value.ToString();
 AddUpdatedFld(convFunctionGroup.FunctionGroupId);
}
else if (convFunctionGroup.FunctionGroupName  ==  _AttributeName[intIndex])
{
mstrFunctionGroupName = value.ToString();
 AddUpdatedFld(convFunctionGroup.FunctionGroupName);
}
else if (convFunctionGroup.ProgLangTypeId  ==  _AttributeName[intIndex])
{
mstrProgLangTypeId = value.ToString();
 AddUpdatedFld(convFunctionGroup.ProgLangTypeId);
}
else if (convFunctionGroup.ProgLangTypeName  ==  _AttributeName[intIndex])
{
mstrProgLangTypeName = value.ToString();
 AddUpdatedFld(convFunctionGroup.ProgLangTypeName);
}
else if (convFunctionGroup.CreateUserId  ==  _AttributeName[intIndex])
{
mstrCreateUserId = value.ToString();
 AddUpdatedFld(convFunctionGroup.CreateUserId);
}
else if (convFunctionGroup.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFunctionGroup.UpdDate);
}
else if (convFunctionGroup.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFunctionGroup.UpdUser);
}
else if (convFunctionGroup.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFunctionGroup.Memo);
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
 AddUpdatedFld(convFunctionGroup.FunctionGroupId);
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
 AddUpdatedFld(convFunctionGroup.FunctionGroupName);
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
 AddUpdatedFld(convFunctionGroup.ProgLangTypeId);
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
 AddUpdatedFld(convFunctionGroup.ProgLangTypeName);
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
 AddUpdatedFld(convFunctionGroup.CreateUserId);
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
 AddUpdatedFld(convFunctionGroup.UpdDate);
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
 AddUpdatedFld(convFunctionGroup.UpdUser);
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
 AddUpdatedFld(convFunctionGroup.Memo);
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
 /// v函数组(vFunctionGroup)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convFunctionGroup
{
public const string _CurrTabName = "vFunctionGroup"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FunctionGroupId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"FunctionGroupId", "FunctionGroupName", "ProgLangTypeId", "ProgLangTypeName", "CreateUserId", "UpdDate", "UpdUser", "Memo"};
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
}

}