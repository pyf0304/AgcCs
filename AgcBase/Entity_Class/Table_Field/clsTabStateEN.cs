
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTabStateEN
 表名:TabState(00050108)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:07:26
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
 /// 表TabState的关键字(TabStateId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TabStateId_TabState
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strTabStateId">表关键字</param>
public K_TabStateId_TabState(string strTabStateId)
{
if (IsValid(strTabStateId)) Value = strTabStateId;
else
{
Value = null;
}
}
private static bool IsValid(string strTabStateId)
{
if (string.IsNullOrEmpty(strTabStateId) == true) return false;
if (strTabStateId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_TabStateId_TabState]类型的对象</returns>
public static implicit operator K_TabStateId_TabState(string value)
{
return new K_TabStateId_TabState(value);
}
}
 /// <summary>
 /// 表状态(TabState)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsTabStateEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "TabState"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TabStateId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 4;
public static string[] _AttributeName = new string[] {"TabStateId", "TabStateName", "TabStateENName", "Memo"};

protected string mstrTabStateId;    //表状态ID
protected string mstrTabStateName;    //表状态名称
protected string mstrTabStateENName;    //表状态英文名
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsTabStateEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TabStateId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strTabStateId">关键字:表状态ID</param>
public clsTabStateEN(string strTabStateId)
 {
strTabStateId = strTabStateId.Replace("'", "''");
if (strTabStateId.Length > 2)
{
throw new Exception("在表:TabState中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTabStateId)  ==  true)
{
throw new Exception("在表:TabState中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTabStateId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrTabStateId = strTabStateId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TabStateId");
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
if (strAttributeName  ==  conTabState.TabStateId)
{
return mstrTabStateId;
}
else if (strAttributeName  ==  conTabState.TabStateName)
{
return mstrTabStateName;
}
else if (strAttributeName  ==  conTabState.TabStateENName)
{
return mstrTabStateENName;
}
else if (strAttributeName  ==  conTabState.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conTabState.TabStateId)
{
mstrTabStateId = value.ToString();
 AddUpdatedFld(conTabState.TabStateId);
}
else if (strAttributeName  ==  conTabState.TabStateName)
{
mstrTabStateName = value.ToString();
 AddUpdatedFld(conTabState.TabStateName);
}
else if (strAttributeName  ==  conTabState.TabStateENName)
{
mstrTabStateENName = value.ToString();
 AddUpdatedFld(conTabState.TabStateENName);
}
else if (strAttributeName  ==  conTabState.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTabState.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conTabState.TabStateId  ==  _AttributeName[intIndex])
{
return mstrTabStateId;
}
else if (conTabState.TabStateName  ==  _AttributeName[intIndex])
{
return mstrTabStateName;
}
else if (conTabState.TabStateENName  ==  _AttributeName[intIndex])
{
return mstrTabStateENName;
}
else if (conTabState.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conTabState.TabStateId  ==  _AttributeName[intIndex])
{
mstrTabStateId = value.ToString();
 AddUpdatedFld(conTabState.TabStateId);
}
else if (conTabState.TabStateName  ==  _AttributeName[intIndex])
{
mstrTabStateName = value.ToString();
 AddUpdatedFld(conTabState.TabStateName);
}
else if (conTabState.TabStateENName  ==  _AttributeName[intIndex])
{
mstrTabStateENName = value.ToString();
 AddUpdatedFld(conTabState.TabStateENName);
}
else if (conTabState.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTabState.Memo);
}
}
}

/// <summary>
/// 表状态ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabStateId
{
get
{
return mstrTabStateId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabStateId = value;
}
else
{
 mstrTabStateId = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabState.TabStateId);
}
}
/// <summary>
/// 表状态名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabStateName
{
get
{
return mstrTabStateName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabStateName = value;
}
else
{
 mstrTabStateName = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabState.TabStateName);
}
}
/// <summary>
/// 表状态英文名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabStateENName
{
get
{
return mstrTabStateENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabStateENName = value;
}
else
{
 mstrTabStateENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabState.TabStateENName);
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
 AddUpdatedFld(conTabState.Memo);
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
  return mstrTabStateId;
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
  return mstrTabStateName;
 }
 }
}
 /// <summary>
 /// 表状态(TabState)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conTabState
{
public const string _CurrTabName = "TabState"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TabStateId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"TabStateId", "TabStateName", "TabStateENName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"TabStateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabStateId = "TabStateId";    //表状态ID

 /// <summary>
 /// 常量:"TabStateName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabStateName = "TabStateName";    //表状态名称

 /// <summary>
 /// 常量:"TabStateENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabStateENName = "TabStateENName";    //表状态英文名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}