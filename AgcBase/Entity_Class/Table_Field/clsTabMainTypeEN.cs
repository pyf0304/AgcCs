
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTabMainTypeEN
 表名:TabMainType(00050534)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:32:21
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
 /// 表TabMainType的关键字(TabMainTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TabMainTypeId_TabMainType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strTabMainTypeId">表关键字</param>
public K_TabMainTypeId_TabMainType(string strTabMainTypeId)
{
if (IsValid(strTabMainTypeId)) Value = strTabMainTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strTabMainTypeId)
{
if (string.IsNullOrEmpty(strTabMainTypeId) == true) return false;
if (strTabMainTypeId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_TabMainTypeId_TabMainType]类型的对象</returns>
public static implicit operator K_TabMainTypeId_TabMainType(string value)
{
return new K_TabMainTypeId_TabMainType(value);
}
}
 /// <summary>
 /// 表主类型(TabMainType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsTabMainTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "TabMainType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TabMainTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 4;
public static string[] _AttributeName = new string[] {"TabMainTypeId", "TabMainTypeName", "TabMainTypeENName", "Memo"};

protected string mstrTabMainTypeId;    //表主类型Id
protected string mstrTabMainTypeName;    //表主类型名
protected string mstrTabMainTypeENName;    //表主类型英文名
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsTabMainTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TabMainTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strTabMainTypeId">关键字:表主类型Id</param>
public clsTabMainTypeEN(string strTabMainTypeId)
 {
strTabMainTypeId = strTabMainTypeId.Replace("'", "''");
if (strTabMainTypeId.Length > 4)
{
throw new Exception("在表:TabMainType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTabMainTypeId)  ==  true)
{
throw new Exception("在表:TabMainType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTabMainTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrTabMainTypeId = strTabMainTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TabMainTypeId");
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
if (strAttributeName  ==  conTabMainType.TabMainTypeId)
{
return mstrTabMainTypeId;
}
else if (strAttributeName  ==  conTabMainType.TabMainTypeName)
{
return mstrTabMainTypeName;
}
else if (strAttributeName  ==  conTabMainType.TabMainTypeENName)
{
return mstrTabMainTypeENName;
}
else if (strAttributeName  ==  conTabMainType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conTabMainType.TabMainTypeId)
{
mstrTabMainTypeId = value.ToString();
 AddUpdatedFld(conTabMainType.TabMainTypeId);
}
else if (strAttributeName  ==  conTabMainType.TabMainTypeName)
{
mstrTabMainTypeName = value.ToString();
 AddUpdatedFld(conTabMainType.TabMainTypeName);
}
else if (strAttributeName  ==  conTabMainType.TabMainTypeENName)
{
mstrTabMainTypeENName = value.ToString();
 AddUpdatedFld(conTabMainType.TabMainTypeENName);
}
else if (strAttributeName  ==  conTabMainType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTabMainType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conTabMainType.TabMainTypeId  ==  _AttributeName[intIndex])
{
return mstrTabMainTypeId;
}
else if (conTabMainType.TabMainTypeName  ==  _AttributeName[intIndex])
{
return mstrTabMainTypeName;
}
else if (conTabMainType.TabMainTypeENName  ==  _AttributeName[intIndex])
{
return mstrTabMainTypeENName;
}
else if (conTabMainType.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conTabMainType.TabMainTypeId  ==  _AttributeName[intIndex])
{
mstrTabMainTypeId = value.ToString();
 AddUpdatedFld(conTabMainType.TabMainTypeId);
}
else if (conTabMainType.TabMainTypeName  ==  _AttributeName[intIndex])
{
mstrTabMainTypeName = value.ToString();
 AddUpdatedFld(conTabMainType.TabMainTypeName);
}
else if (conTabMainType.TabMainTypeENName  ==  _AttributeName[intIndex])
{
mstrTabMainTypeENName = value.ToString();
 AddUpdatedFld(conTabMainType.TabMainTypeENName);
}
else if (conTabMainType.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTabMainType.Memo);
}
}
}

/// <summary>
/// 表主类型Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabMainTypeId
{
get
{
return mstrTabMainTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabMainTypeId = value;
}
else
{
 mstrTabMainTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabMainType.TabMainTypeId);
}
}
/// <summary>
/// 表主类型名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabMainTypeName
{
get
{
return mstrTabMainTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabMainTypeName = value;
}
else
{
 mstrTabMainTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabMainType.TabMainTypeName);
}
}
/// <summary>
/// 表主类型英文名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabMainTypeENName
{
get
{
return mstrTabMainTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabMainTypeENName = value;
}
else
{
 mstrTabMainTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabMainType.TabMainTypeENName);
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
 AddUpdatedFld(conTabMainType.Memo);
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
  return mstrTabMainTypeId;
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
  return mstrTabMainTypeName;
 }
 }
}
 /// <summary>
 /// 表主类型(TabMainType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conTabMainType
{
public const string _CurrTabName = "TabMainType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TabMainTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"TabMainTypeId", "TabMainTypeName", "TabMainTypeENName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"TabMainTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabMainTypeId = "TabMainTypeId";    //表主类型Id

 /// <summary>
 /// 常量:"TabMainTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabMainTypeName = "TabMainTypeName";    //表主类型名

 /// <summary>
 /// 常量:"TabMainTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabMainTypeENName = "TabMainTypeENName";    //表主类型英文名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}