
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFuncMapModeEN
 表名:FuncMapMode(00050551)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:09:10
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:AI模块(AIModule)
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
 /// 表FuncMapMode的关键字(FuncMapModeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_FuncMapModeId_FuncMapMode
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strFuncMapModeId">表关键字</param>
public K_FuncMapModeId_FuncMapMode(string strFuncMapModeId)
{
if (IsValid(strFuncMapModeId)) Value = strFuncMapModeId;
else
{
Value = null;
}
}
private static bool IsValid(string strFuncMapModeId)
{
if (string.IsNullOrEmpty(strFuncMapModeId) == true) return false;
if (strFuncMapModeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_FuncMapModeId_FuncMapMode]类型的对象</returns>
public static implicit operator K_FuncMapModeId_FuncMapMode(string value)
{
return new K_FuncMapModeId_FuncMapMode(value);
}
}
 /// <summary>
 /// 函数映射模式(FuncMapMode)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsFuncMapModeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "FuncMapMode"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "FuncMapModeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 6;
public static string[] _AttributeName = new string[] {"FuncMapModeId", "FuncMapModeName", "FuncMapModeENName", "UpdDate", "UpdUser", "Memo"};

protected string mstrFuncMapModeId;    //函数映射模式Id
protected string mstrFuncMapModeName;    //函数映射模式名
protected string mstrFuncMapModeENName;    //函数映射模式英文名
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsFuncMapModeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FuncMapModeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strFuncMapModeId">关键字:函数映射模式Id</param>
public clsFuncMapModeEN(string strFuncMapModeId)
 {
strFuncMapModeId = strFuncMapModeId.Replace("'", "''");
if (strFuncMapModeId.Length > 2)
{
throw new Exception("在表:FuncMapMode中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strFuncMapModeId)  ==  true)
{
throw new Exception("在表:FuncMapMode中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFuncMapModeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrFuncMapModeId = strFuncMapModeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FuncMapModeId");
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
if (strAttributeName  ==  conFuncMapMode.FuncMapModeId)
{
return mstrFuncMapModeId;
}
else if (strAttributeName  ==  conFuncMapMode.FuncMapModeName)
{
return mstrFuncMapModeName;
}
else if (strAttributeName  ==  conFuncMapMode.FuncMapModeENName)
{
return mstrFuncMapModeENName;
}
else if (strAttributeName  ==  conFuncMapMode.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conFuncMapMode.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conFuncMapMode.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conFuncMapMode.FuncMapModeId)
{
mstrFuncMapModeId = value.ToString();
 AddUpdatedFld(conFuncMapMode.FuncMapModeId);
}
else if (strAttributeName  ==  conFuncMapMode.FuncMapModeName)
{
mstrFuncMapModeName = value.ToString();
 AddUpdatedFld(conFuncMapMode.FuncMapModeName);
}
else if (strAttributeName  ==  conFuncMapMode.FuncMapModeENName)
{
mstrFuncMapModeENName = value.ToString();
 AddUpdatedFld(conFuncMapMode.FuncMapModeENName);
}
else if (strAttributeName  ==  conFuncMapMode.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFuncMapMode.UpdDate);
}
else if (strAttributeName  ==  conFuncMapMode.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conFuncMapMode.UpdUser);
}
else if (strAttributeName  ==  conFuncMapMode.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFuncMapMode.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conFuncMapMode.FuncMapModeId  ==  _AttributeName[intIndex])
{
return mstrFuncMapModeId;
}
else if (conFuncMapMode.FuncMapModeName  ==  _AttributeName[intIndex])
{
return mstrFuncMapModeName;
}
else if (conFuncMapMode.FuncMapModeENName  ==  _AttributeName[intIndex])
{
return mstrFuncMapModeENName;
}
else if (conFuncMapMode.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conFuncMapMode.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conFuncMapMode.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conFuncMapMode.FuncMapModeId  ==  _AttributeName[intIndex])
{
mstrFuncMapModeId = value.ToString();
 AddUpdatedFld(conFuncMapMode.FuncMapModeId);
}
else if (conFuncMapMode.FuncMapModeName  ==  _AttributeName[intIndex])
{
mstrFuncMapModeName = value.ToString();
 AddUpdatedFld(conFuncMapMode.FuncMapModeName);
}
else if (conFuncMapMode.FuncMapModeENName  ==  _AttributeName[intIndex])
{
mstrFuncMapModeENName = value.ToString();
 AddUpdatedFld(conFuncMapMode.FuncMapModeENName);
}
else if (conFuncMapMode.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFuncMapMode.UpdDate);
}
else if (conFuncMapMode.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conFuncMapMode.UpdUser);
}
else if (conFuncMapMode.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFuncMapMode.Memo);
}
}
}

/// <summary>
/// 函数映射模式Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncMapModeId
{
get
{
return mstrFuncMapModeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncMapModeId = value;
}
else
{
 mstrFuncMapModeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conFuncMapMode.FuncMapModeId);
}
}
/// <summary>
/// 函数映射模式名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncMapModeName
{
get
{
return mstrFuncMapModeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncMapModeName = value;
}
else
{
 mstrFuncMapModeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conFuncMapMode.FuncMapModeName);
}
}
/// <summary>
/// 函数映射模式英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncMapModeENName
{
get
{
return mstrFuncMapModeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncMapModeENName = value;
}
else
{
 mstrFuncMapModeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conFuncMapMode.FuncMapModeENName);
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
 AddUpdatedFld(conFuncMapMode.UpdDate);
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
 AddUpdatedFld(conFuncMapMode.UpdUser);
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
 AddUpdatedFld(conFuncMapMode.Memo);
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
  return mstrFuncMapModeId;
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
  return mstrFuncMapModeName;
 }
 }
}
 /// <summary>
 /// 函数映射模式(FuncMapMode)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conFuncMapMode
{
public const string _CurrTabName = "FuncMapMode"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FuncMapModeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"FuncMapModeId", "FuncMapModeName", "FuncMapModeENName", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"FuncMapModeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncMapModeId = "FuncMapModeId";    //函数映射模式Id

 /// <summary>
 /// 常量:"FuncMapModeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncMapModeName = "FuncMapModeName";    //函数映射模式名

 /// <summary>
 /// 常量:"FuncMapModeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncMapModeENName = "FuncMapModeENName";    //函数映射模式英文名

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