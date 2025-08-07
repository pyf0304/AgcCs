
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFuncAccessModeEN
 表名:FuncAccessMode(00050497)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:34:33
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
 /// 表FuncAccessMode的关键字(FuncAccessModeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_FuncAccessModeId_FuncAccessMode
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strFuncAccessModeId">表关键字</param>
public K_FuncAccessModeId_FuncAccessMode(string strFuncAccessModeId)
{
if (IsValid(strFuncAccessModeId)) Value = strFuncAccessModeId;
else
{
Value = null;
}
}
private static bool IsValid(string strFuncAccessModeId)
{
if (string.IsNullOrEmpty(strFuncAccessModeId) == true) return false;
if (strFuncAccessModeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_FuncAccessModeId_FuncAccessMode]类型的对象</returns>
public static implicit operator K_FuncAccessModeId_FuncAccessMode(string value)
{
return new K_FuncAccessModeId_FuncAccessMode(value);
}
}
 /// <summary>
 /// 函数操作模式(FuncAccessMode)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsFuncAccessModeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "FuncAccessMode"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "FuncAccessModeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 6;
public static string[] _AttributeName = new string[] {"FuncAccessModeId", "FuncAccessModeName", "FuncAccessModeENName", "UpdDate", "UpdUser", "Memo"};

protected string mstrFuncAccessModeId;    //函数操作模式Id
protected string mstrFuncAccessModeName;    //函数操作模式名
protected string mstrFuncAccessModeENName;    //函数操作模式英文名
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsFuncAccessModeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FuncAccessModeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strFuncAccessModeId">关键字:函数操作模式Id</param>
public clsFuncAccessModeEN(string strFuncAccessModeId)
 {
strFuncAccessModeId = strFuncAccessModeId.Replace("'", "''");
if (strFuncAccessModeId.Length > 2)
{
throw new Exception("在表:FuncAccessMode中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strFuncAccessModeId)  ==  true)
{
throw new Exception("在表:FuncAccessMode中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFuncAccessModeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrFuncAccessModeId = strFuncAccessModeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FuncAccessModeId");
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
if (strAttributeName  ==  conFuncAccessMode.FuncAccessModeId)
{
return mstrFuncAccessModeId;
}
else if (strAttributeName  ==  conFuncAccessMode.FuncAccessModeName)
{
return mstrFuncAccessModeName;
}
else if (strAttributeName  ==  conFuncAccessMode.FuncAccessModeENName)
{
return mstrFuncAccessModeENName;
}
else if (strAttributeName  ==  conFuncAccessMode.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conFuncAccessMode.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conFuncAccessMode.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conFuncAccessMode.FuncAccessModeId)
{
mstrFuncAccessModeId = value.ToString();
 AddUpdatedFld(conFuncAccessMode.FuncAccessModeId);
}
else if (strAttributeName  ==  conFuncAccessMode.FuncAccessModeName)
{
mstrFuncAccessModeName = value.ToString();
 AddUpdatedFld(conFuncAccessMode.FuncAccessModeName);
}
else if (strAttributeName  ==  conFuncAccessMode.FuncAccessModeENName)
{
mstrFuncAccessModeENName = value.ToString();
 AddUpdatedFld(conFuncAccessMode.FuncAccessModeENName);
}
else if (strAttributeName  ==  conFuncAccessMode.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFuncAccessMode.UpdDate);
}
else if (strAttributeName  ==  conFuncAccessMode.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conFuncAccessMode.UpdUser);
}
else if (strAttributeName  ==  conFuncAccessMode.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFuncAccessMode.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conFuncAccessMode.FuncAccessModeId  ==  _AttributeName[intIndex])
{
return mstrFuncAccessModeId;
}
else if (conFuncAccessMode.FuncAccessModeName  ==  _AttributeName[intIndex])
{
return mstrFuncAccessModeName;
}
else if (conFuncAccessMode.FuncAccessModeENName  ==  _AttributeName[intIndex])
{
return mstrFuncAccessModeENName;
}
else if (conFuncAccessMode.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conFuncAccessMode.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conFuncAccessMode.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conFuncAccessMode.FuncAccessModeId  ==  _AttributeName[intIndex])
{
mstrFuncAccessModeId = value.ToString();
 AddUpdatedFld(conFuncAccessMode.FuncAccessModeId);
}
else if (conFuncAccessMode.FuncAccessModeName  ==  _AttributeName[intIndex])
{
mstrFuncAccessModeName = value.ToString();
 AddUpdatedFld(conFuncAccessMode.FuncAccessModeName);
}
else if (conFuncAccessMode.FuncAccessModeENName  ==  _AttributeName[intIndex])
{
mstrFuncAccessModeENName = value.ToString();
 AddUpdatedFld(conFuncAccessMode.FuncAccessModeENName);
}
else if (conFuncAccessMode.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFuncAccessMode.UpdDate);
}
else if (conFuncAccessMode.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conFuncAccessMode.UpdUser);
}
else if (conFuncAccessMode.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFuncAccessMode.Memo);
}
}
}

/// <summary>
/// 函数操作模式Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncAccessModeId
{
get
{
return mstrFuncAccessModeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncAccessModeId = value;
}
else
{
 mstrFuncAccessModeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conFuncAccessMode.FuncAccessModeId);
}
}
/// <summary>
/// 函数操作模式名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncAccessModeName
{
get
{
return mstrFuncAccessModeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncAccessModeName = value;
}
else
{
 mstrFuncAccessModeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conFuncAccessMode.FuncAccessModeName);
}
}
/// <summary>
/// 函数操作模式英文名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncAccessModeENName
{
get
{
return mstrFuncAccessModeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncAccessModeENName = value;
}
else
{
 mstrFuncAccessModeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conFuncAccessMode.FuncAccessModeENName);
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
 AddUpdatedFld(conFuncAccessMode.UpdDate);
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
 AddUpdatedFld(conFuncAccessMode.UpdUser);
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
 AddUpdatedFld(conFuncAccessMode.Memo);
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
  return mstrFuncAccessModeId;
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
  return mstrFuncAccessModeName;
 }
 }
}
 /// <summary>
 /// 函数操作模式(FuncAccessMode)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conFuncAccessMode
{
public const string _CurrTabName = "FuncAccessMode"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FuncAccessModeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"FuncAccessModeId", "FuncAccessModeName", "FuncAccessModeENName", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"FuncAccessModeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncAccessModeId = "FuncAccessModeId";    //函数操作模式Id

 /// <summary>
 /// 常量:"FuncAccessModeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncAccessModeName = "FuncAccessModeName";    //函数操作模式名

 /// <summary>
 /// 常量:"FuncAccessModeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncAccessModeENName = "FuncAccessModeENName";    //函数操作模式英文名

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