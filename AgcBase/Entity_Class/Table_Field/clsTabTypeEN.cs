
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTabTypeEN
 表名:TabType(00050270)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:32:13
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
 /// 表TabType的关键字(TabTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TabTypeId_TabType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strTabTypeId">表关键字</param>
public K_TabTypeId_TabType(string strTabTypeId)
{
if (IsValid(strTabTypeId)) Value = strTabTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strTabTypeId)
{
if (string.IsNullOrEmpty(strTabTypeId) == true) return false;
if (strTabTypeId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_TabTypeId_TabType]类型的对象</returns>
public static implicit operator K_TabTypeId_TabType(string value)
{
return new K_TabTypeId_TabType(value);
}
}
 /// <summary>
 /// 表类型(TabType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsTabTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "TabType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TabTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 4;
public static string[] _AttributeName = new string[] {"TabTypeId", "TabTypeName", "TabTypeENName", "Memo"};

protected string mstrTabTypeId;    //表类型Id
protected string mstrTabTypeName;    //表类型名
protected string mstrTabTypeENName;    //表类型英文名
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsTabTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TabTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strTabTypeId">关键字:表类型Id</param>
public clsTabTypeEN(string strTabTypeId)
 {
strTabTypeId = strTabTypeId.Replace("'", "''");
if (strTabTypeId.Length > 4)
{
throw new Exception("在表:TabType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTabTypeId)  ==  true)
{
throw new Exception("在表:TabType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTabTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrTabTypeId = strTabTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TabTypeId");
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
if (strAttributeName  ==  conTabType.TabTypeId)
{
return mstrTabTypeId;
}
else if (strAttributeName  ==  conTabType.TabTypeName)
{
return mstrTabTypeName;
}
else if (strAttributeName  ==  conTabType.TabTypeENName)
{
return mstrTabTypeENName;
}
else if (strAttributeName  ==  conTabType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conTabType.TabTypeId)
{
mstrTabTypeId = value.ToString();
 AddUpdatedFld(conTabType.TabTypeId);
}
else if (strAttributeName  ==  conTabType.TabTypeName)
{
mstrTabTypeName = value.ToString();
 AddUpdatedFld(conTabType.TabTypeName);
}
else if (strAttributeName  ==  conTabType.TabTypeENName)
{
mstrTabTypeENName = value.ToString();
 AddUpdatedFld(conTabType.TabTypeENName);
}
else if (strAttributeName  ==  conTabType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTabType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conTabType.TabTypeId  ==  _AttributeName[intIndex])
{
return mstrTabTypeId;
}
else if (conTabType.TabTypeName  ==  _AttributeName[intIndex])
{
return mstrTabTypeName;
}
else if (conTabType.TabTypeENName  ==  _AttributeName[intIndex])
{
return mstrTabTypeENName;
}
else if (conTabType.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conTabType.TabTypeId  ==  _AttributeName[intIndex])
{
mstrTabTypeId = value.ToString();
 AddUpdatedFld(conTabType.TabTypeId);
}
else if (conTabType.TabTypeName  ==  _AttributeName[intIndex])
{
mstrTabTypeName = value.ToString();
 AddUpdatedFld(conTabType.TabTypeName);
}
else if (conTabType.TabTypeENName  ==  _AttributeName[intIndex])
{
mstrTabTypeENName = value.ToString();
 AddUpdatedFld(conTabType.TabTypeENName);
}
else if (conTabType.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTabType.Memo);
}
}
}

/// <summary>
/// 表类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabTypeId
{
get
{
return mstrTabTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabTypeId = value;
}
else
{
 mstrTabTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabType.TabTypeId);
}
}
/// <summary>
/// 表类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabTypeName
{
get
{
return mstrTabTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabTypeName = value;
}
else
{
 mstrTabTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabType.TabTypeName);
}
}
/// <summary>
/// 表类型英文名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabTypeENName
{
get
{
return mstrTabTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabTypeENName = value;
}
else
{
 mstrTabTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabType.TabTypeENName);
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
 AddUpdatedFld(conTabType.Memo);
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
  return mstrTabTypeId;
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
  return mstrTabTypeName;
 }
 }
}
 /// <summary>
 /// 表类型(TabType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conTabType
{
public const string _CurrTabName = "TabType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TabTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"TabTypeId", "TabTypeName", "TabTypeENName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"TabTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabTypeId = "TabTypeId";    //表类型Id

 /// <summary>
 /// 常量:"TabTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabTypeName = "TabTypeName";    //表类型名

 /// <summary>
 /// 常量:"TabTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabTypeENName = "TabTypeENName";    //表类型英文名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}