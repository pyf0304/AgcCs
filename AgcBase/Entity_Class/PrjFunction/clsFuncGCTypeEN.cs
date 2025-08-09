
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFuncGCTypeEN
 表名:FuncGCType(00050409)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:07:44
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
 /// 表FuncGCType的关键字(FuncGCTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_FuncGCTypeId_FuncGCType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strFuncGCTypeId">表关键字</param>
public K_FuncGCTypeId_FuncGCType(string strFuncGCTypeId)
{
if (IsValid(strFuncGCTypeId)) Value = strFuncGCTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strFuncGCTypeId)
{
if (string.IsNullOrEmpty(strFuncGCTypeId) == true) return false;
if (strFuncGCTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_FuncGCTypeId_FuncGCType]类型的对象</returns>
public static implicit operator K_FuncGCTypeId_FuncGCType(string value)
{
return new K_FuncGCTypeId_FuncGCType(value);
}
}
 /// <summary>
 /// 函数生成代码类型(FuncGCType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsFuncGCTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "FuncGCType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "FuncGCTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 6;
public static string[] _AttributeName = new string[] {"FuncGCTypeId", "FuncGCTypeName", "FuncGCTypeENName", "UpdDate", "UpdUser", "Memo"};

protected string mstrFuncGCTypeId;    //函数生成代码类型Id
protected string mstrFuncGCTypeName;    //函数生成代码类型名
protected string mstrFuncGCTypeENName;    //函数生成代码类型英文名
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsFuncGCTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FuncGCTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strFuncGCTypeId">关键字:函数生成代码类型Id</param>
public clsFuncGCTypeEN(string strFuncGCTypeId)
 {
strFuncGCTypeId = strFuncGCTypeId.Replace("'", "''");
if (strFuncGCTypeId.Length > 2)
{
throw new Exception("在表:FuncGCType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strFuncGCTypeId)  ==  true)
{
throw new Exception("在表:FuncGCType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFuncGCTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrFuncGCTypeId = strFuncGCTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FuncGCTypeId");
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
if (strAttributeName  ==  conFuncGCType.FuncGCTypeId)
{
return mstrFuncGCTypeId;
}
else if (strAttributeName  ==  conFuncGCType.FuncGCTypeName)
{
return mstrFuncGCTypeName;
}
else if (strAttributeName  ==  conFuncGCType.FuncGCTypeENName)
{
return mstrFuncGCTypeENName;
}
else if (strAttributeName  ==  conFuncGCType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conFuncGCType.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conFuncGCType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conFuncGCType.FuncGCTypeId)
{
mstrFuncGCTypeId = value.ToString();
 AddUpdatedFld(conFuncGCType.FuncGCTypeId);
}
else if (strAttributeName  ==  conFuncGCType.FuncGCTypeName)
{
mstrFuncGCTypeName = value.ToString();
 AddUpdatedFld(conFuncGCType.FuncGCTypeName);
}
else if (strAttributeName  ==  conFuncGCType.FuncGCTypeENName)
{
mstrFuncGCTypeENName = value.ToString();
 AddUpdatedFld(conFuncGCType.FuncGCTypeENName);
}
else if (strAttributeName  ==  conFuncGCType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFuncGCType.UpdDate);
}
else if (strAttributeName  ==  conFuncGCType.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conFuncGCType.UpdUser);
}
else if (strAttributeName  ==  conFuncGCType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFuncGCType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conFuncGCType.FuncGCTypeId  ==  _AttributeName[intIndex])
{
return mstrFuncGCTypeId;
}
else if (conFuncGCType.FuncGCTypeName  ==  _AttributeName[intIndex])
{
return mstrFuncGCTypeName;
}
else if (conFuncGCType.FuncGCTypeENName  ==  _AttributeName[intIndex])
{
return mstrFuncGCTypeENName;
}
else if (conFuncGCType.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conFuncGCType.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conFuncGCType.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conFuncGCType.FuncGCTypeId  ==  _AttributeName[intIndex])
{
mstrFuncGCTypeId = value.ToString();
 AddUpdatedFld(conFuncGCType.FuncGCTypeId);
}
else if (conFuncGCType.FuncGCTypeName  ==  _AttributeName[intIndex])
{
mstrFuncGCTypeName = value.ToString();
 AddUpdatedFld(conFuncGCType.FuncGCTypeName);
}
else if (conFuncGCType.FuncGCTypeENName  ==  _AttributeName[intIndex])
{
mstrFuncGCTypeENName = value.ToString();
 AddUpdatedFld(conFuncGCType.FuncGCTypeENName);
}
else if (conFuncGCType.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFuncGCType.UpdDate);
}
else if (conFuncGCType.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conFuncGCType.UpdUser);
}
else if (conFuncGCType.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFuncGCType.Memo);
}
}
}

/// <summary>
/// 函数生成代码类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncGCTypeId
{
get
{
return mstrFuncGCTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncGCTypeId = value;
}
else
{
 mstrFuncGCTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conFuncGCType.FuncGCTypeId);
}
}
/// <summary>
/// 函数生成代码类型名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncGCTypeName
{
get
{
return mstrFuncGCTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncGCTypeName = value;
}
else
{
 mstrFuncGCTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conFuncGCType.FuncGCTypeName);
}
}
/// <summary>
/// 函数生成代码类型英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncGCTypeENName
{
get
{
return mstrFuncGCTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncGCTypeENName = value;
}
else
{
 mstrFuncGCTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conFuncGCType.FuncGCTypeENName);
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
 AddUpdatedFld(conFuncGCType.UpdDate);
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
 AddUpdatedFld(conFuncGCType.UpdUser);
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
 AddUpdatedFld(conFuncGCType.Memo);
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
  return mstrFuncGCTypeId;
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
  return mstrFuncGCTypeName;
 }
 }
}
 /// <summary>
 /// 函数生成代码类型(FuncGCType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conFuncGCType
{
public const string _CurrTabName = "FuncGCType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FuncGCTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"FuncGCTypeId", "FuncGCTypeName", "FuncGCTypeENName", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"FuncGCTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncGCTypeId = "FuncGCTypeId";    //函数生成代码类型Id

 /// <summary>
 /// 常量:"FuncGCTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncGCTypeName = "FuncGCTypeName";    //函数生成代码类型名

 /// <summary>
 /// 常量:"FuncGCTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncGCTypeENName = "FuncGCTypeENName";    //函数生成代码类型英文名

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