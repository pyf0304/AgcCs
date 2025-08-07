
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsValueGivingModeEN
 表名:ValueGivingMode(00050462)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:34:55
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
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
 /// 表ValueGivingMode的关键字(ValueGivingModeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ValueGivingModeId_ValueGivingMode
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strValueGivingModeId">表关键字</param>
public K_ValueGivingModeId_ValueGivingMode(string strValueGivingModeId)
{
if (IsValid(strValueGivingModeId)) Value = strValueGivingModeId;
else
{
Value = null;
}
}
private static bool IsValid(string strValueGivingModeId)
{
if (string.IsNullOrEmpty(strValueGivingModeId) == true) return false;
if (strValueGivingModeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ValueGivingModeId_ValueGivingMode]类型的对象</returns>
public static implicit operator K_ValueGivingModeId_ValueGivingMode(string value)
{
return new K_ValueGivingModeId_ValueGivingMode(value);
}
}
 /// <summary>
 /// 给值方式(ValueGivingMode)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsValueGivingModeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ValueGivingMode"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ValueGivingModeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 4;
public static string[] _AttributeName = new string[] {"ValueGivingModeId", "ValueGivingModeName", "ValueGivingModeENName", "Memo"};

protected string mstrValueGivingModeId;    //给值方式Id
protected string mstrValueGivingModeName;    //给值方式名
protected string mstrValueGivingModeENName;    //给值方式英文名
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsValueGivingModeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ValueGivingModeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strValueGivingModeId">关键字:给值方式Id</param>
public clsValueGivingModeEN(string strValueGivingModeId)
 {
strValueGivingModeId = strValueGivingModeId.Replace("'", "''");
if (strValueGivingModeId.Length > 2)
{
throw new Exception("在表:ValueGivingMode中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strValueGivingModeId)  ==  true)
{
throw new Exception("在表:ValueGivingMode中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strValueGivingModeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrValueGivingModeId = strValueGivingModeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ValueGivingModeId");
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
if (strAttributeName  ==  conValueGivingMode.ValueGivingModeId)
{
return mstrValueGivingModeId;
}
else if (strAttributeName  ==  conValueGivingMode.ValueGivingModeName)
{
return mstrValueGivingModeName;
}
else if (strAttributeName  ==  conValueGivingMode.ValueGivingModeENName)
{
return mstrValueGivingModeENName;
}
else if (strAttributeName  ==  conValueGivingMode.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conValueGivingMode.ValueGivingModeId)
{
mstrValueGivingModeId = value.ToString();
 AddUpdatedFld(conValueGivingMode.ValueGivingModeId);
}
else if (strAttributeName  ==  conValueGivingMode.ValueGivingModeName)
{
mstrValueGivingModeName = value.ToString();
 AddUpdatedFld(conValueGivingMode.ValueGivingModeName);
}
else if (strAttributeName  ==  conValueGivingMode.ValueGivingModeENName)
{
mstrValueGivingModeENName = value.ToString();
 AddUpdatedFld(conValueGivingMode.ValueGivingModeENName);
}
else if (strAttributeName  ==  conValueGivingMode.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conValueGivingMode.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conValueGivingMode.ValueGivingModeId  ==  _AttributeName[intIndex])
{
return mstrValueGivingModeId;
}
else if (conValueGivingMode.ValueGivingModeName  ==  _AttributeName[intIndex])
{
return mstrValueGivingModeName;
}
else if (conValueGivingMode.ValueGivingModeENName  ==  _AttributeName[intIndex])
{
return mstrValueGivingModeENName;
}
else if (conValueGivingMode.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conValueGivingMode.ValueGivingModeId  ==  _AttributeName[intIndex])
{
mstrValueGivingModeId = value.ToString();
 AddUpdatedFld(conValueGivingMode.ValueGivingModeId);
}
else if (conValueGivingMode.ValueGivingModeName  ==  _AttributeName[intIndex])
{
mstrValueGivingModeName = value.ToString();
 AddUpdatedFld(conValueGivingMode.ValueGivingModeName);
}
else if (conValueGivingMode.ValueGivingModeENName  ==  _AttributeName[intIndex])
{
mstrValueGivingModeENName = value.ToString();
 AddUpdatedFld(conValueGivingMode.ValueGivingModeENName);
}
else if (conValueGivingMode.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conValueGivingMode.Memo);
}
}
}

/// <summary>
/// 给值方式Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ValueGivingModeId
{
get
{
return mstrValueGivingModeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrValueGivingModeId = value;
}
else
{
 mstrValueGivingModeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conValueGivingMode.ValueGivingModeId);
}
}
/// <summary>
/// 给值方式名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ValueGivingModeName
{
get
{
return mstrValueGivingModeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrValueGivingModeName = value;
}
else
{
 mstrValueGivingModeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conValueGivingMode.ValueGivingModeName);
}
}
/// <summary>
/// 给值方式英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ValueGivingModeENName
{
get
{
return mstrValueGivingModeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrValueGivingModeENName = value;
}
else
{
 mstrValueGivingModeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conValueGivingMode.ValueGivingModeENName);
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
 AddUpdatedFld(conValueGivingMode.Memo);
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
  return mstrValueGivingModeId;
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
  return mstrValueGivingModeName;
 }
 }
}
 /// <summary>
 /// 给值方式(ValueGivingMode)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conValueGivingMode
{
public const string _CurrTabName = "ValueGivingMode"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ValueGivingModeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"ValueGivingModeId", "ValueGivingModeName", "ValueGivingModeENName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"ValueGivingModeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ValueGivingModeId = "ValueGivingModeId";    //给值方式Id

 /// <summary>
 /// 常量:"ValueGivingModeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ValueGivingModeName = "ValueGivingModeName";    //给值方式名

 /// <summary>
 /// 常量:"ValueGivingModeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ValueGivingModeENName = "ValueGivingModeENName";    //给值方式英文名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}