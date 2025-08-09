
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTabCheckErrorTypeEN
 表名:TabCheckErrorType(00050207)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:08:20
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:日志管理(LogManage)
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
 /// 表TabCheckErrorType的关键字(TabCheckErrorTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TabCheckErrorTypeId_TabCheckErrorType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strTabCheckErrorTypeId">表关键字</param>
public K_TabCheckErrorTypeId_TabCheckErrorType(string strTabCheckErrorTypeId)
{
if (IsValid(strTabCheckErrorTypeId)) Value = strTabCheckErrorTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strTabCheckErrorTypeId)
{
if (string.IsNullOrEmpty(strTabCheckErrorTypeId) == true) return false;
if (strTabCheckErrorTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_TabCheckErrorTypeId_TabCheckErrorType]类型的对象</returns>
public static implicit operator K_TabCheckErrorTypeId_TabCheckErrorType(string value)
{
return new K_TabCheckErrorTypeId_TabCheckErrorType(value);
}
}
 /// <summary>
 /// 表检查错误类型(TabCheckErrorType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsTabCheckErrorTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "TabCheckErrorType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TabCheckErrorTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 3;
public static string[] _AttributeName = new string[] {"TabCheckErrorTypeId", "TabCheckErrorTypeName", "Memo"};

protected string mstrTabCheckErrorTypeId;    //表检查错误类型Id
protected string mstrTabCheckErrorTypeName;    //表检查错误类型名
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsTabCheckErrorTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TabCheckErrorTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strTabCheckErrorTypeId">关键字:表检查错误类型Id</param>
public clsTabCheckErrorTypeEN(string strTabCheckErrorTypeId)
 {
strTabCheckErrorTypeId = strTabCheckErrorTypeId.Replace("'", "''");
if (strTabCheckErrorTypeId.Length > 2)
{
throw new Exception("在表:TabCheckErrorType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTabCheckErrorTypeId)  ==  true)
{
throw new Exception("在表:TabCheckErrorType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTabCheckErrorTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrTabCheckErrorTypeId = strTabCheckErrorTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TabCheckErrorTypeId");
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
if (strAttributeName  ==  conTabCheckErrorType.TabCheckErrorTypeId)
{
return mstrTabCheckErrorTypeId;
}
else if (strAttributeName  ==  conTabCheckErrorType.TabCheckErrorTypeName)
{
return mstrTabCheckErrorTypeName;
}
else if (strAttributeName  ==  conTabCheckErrorType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conTabCheckErrorType.TabCheckErrorTypeId)
{
mstrTabCheckErrorTypeId = value.ToString();
 AddUpdatedFld(conTabCheckErrorType.TabCheckErrorTypeId);
}
else if (strAttributeName  ==  conTabCheckErrorType.TabCheckErrorTypeName)
{
mstrTabCheckErrorTypeName = value.ToString();
 AddUpdatedFld(conTabCheckErrorType.TabCheckErrorTypeName);
}
else if (strAttributeName  ==  conTabCheckErrorType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTabCheckErrorType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conTabCheckErrorType.TabCheckErrorTypeId  ==  _AttributeName[intIndex])
{
return mstrTabCheckErrorTypeId;
}
else if (conTabCheckErrorType.TabCheckErrorTypeName  ==  _AttributeName[intIndex])
{
return mstrTabCheckErrorTypeName;
}
else if (conTabCheckErrorType.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conTabCheckErrorType.TabCheckErrorTypeId  ==  _AttributeName[intIndex])
{
mstrTabCheckErrorTypeId = value.ToString();
 AddUpdatedFld(conTabCheckErrorType.TabCheckErrorTypeId);
}
else if (conTabCheckErrorType.TabCheckErrorTypeName  ==  _AttributeName[intIndex])
{
mstrTabCheckErrorTypeName = value.ToString();
 AddUpdatedFld(conTabCheckErrorType.TabCheckErrorTypeName);
}
else if (conTabCheckErrorType.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTabCheckErrorType.Memo);
}
}
}

/// <summary>
/// 表检查错误类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabCheckErrorTypeId
{
get
{
return mstrTabCheckErrorTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabCheckErrorTypeId = value;
}
else
{
 mstrTabCheckErrorTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabCheckErrorType.TabCheckErrorTypeId);
}
}
/// <summary>
/// 表检查错误类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabCheckErrorTypeName
{
get
{
return mstrTabCheckErrorTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabCheckErrorTypeName = value;
}
else
{
 mstrTabCheckErrorTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabCheckErrorType.TabCheckErrorTypeName);
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
 AddUpdatedFld(conTabCheckErrorType.Memo);
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
  return mstrTabCheckErrorTypeId;
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
  return mstrTabCheckErrorTypeName;
 }
 }
}
 /// <summary>
 /// 表检查错误类型(TabCheckErrorType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conTabCheckErrorType
{
public const string _CurrTabName = "TabCheckErrorType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TabCheckErrorTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"TabCheckErrorTypeId", "TabCheckErrorTypeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"TabCheckErrorTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabCheckErrorTypeId = "TabCheckErrorTypeId";    //表检查错误类型Id

 /// <summary>
 /// 常量:"TabCheckErrorTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabCheckErrorTypeName = "TabCheckErrorTypeName";    //表检查错误类型名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}