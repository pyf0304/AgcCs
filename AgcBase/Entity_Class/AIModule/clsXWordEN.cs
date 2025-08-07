
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsXWordEN
 表名:XWord(00050533)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:34:49
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
 /// 表XWord的关键字(XWordId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_XWordId_XWord
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strXWordId">表关键字</param>
public K_XWordId_XWord(string strXWordId)
{
if (IsValid(strXWordId)) Value = strXWordId;
else
{
Value = null;
}
}
private static bool IsValid(string strXWordId)
{
if (string.IsNullOrEmpty(strXWordId) == true) return false;
if (strXWordId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_XWordId_XWord]类型的对象</returns>
public static implicit operator K_XWordId_XWord(string value)
{
return new K_XWordId_XWord(value);
}
}
 /// <summary>
 /// X词(XWord)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsXWordEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "XWord"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "XWordId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 2;
public static string[] _AttributeName = new string[] {"XWordId", "XWordName"};

protected string mstrXWordId;    //X词Id
protected string mstrXWordName;    //X词名

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsXWordEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("XWordId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strXWordId">关键字:X词Id</param>
public clsXWordEN(string strXWordId)
 {
strXWordId = strXWordId.Replace("'", "''");
if (strXWordId.Length > 8)
{
throw new Exception("在表:XWord中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strXWordId)  ==  true)
{
throw new Exception("在表:XWord中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strXWordId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrXWordId = strXWordId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("XWordId");
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
if (strAttributeName  ==  conXWord.XWordId)
{
return mstrXWordId;
}
else if (strAttributeName  ==  conXWord.XWordName)
{
return mstrXWordName;
}
return null;
}
set
{
if (strAttributeName  ==  conXWord.XWordId)
{
mstrXWordId = value.ToString();
 AddUpdatedFld(conXWord.XWordId);
}
else if (strAttributeName  ==  conXWord.XWordName)
{
mstrXWordName = value.ToString();
 AddUpdatedFld(conXWord.XWordName);
}
}
}
public object this[int intIndex]
{
get
{
if (conXWord.XWordId  ==  _AttributeName[intIndex])
{
return mstrXWordId;
}
else if (conXWord.XWordName  ==  _AttributeName[intIndex])
{
return mstrXWordName;
}
return null;
}
set
{
if (conXWord.XWordId  ==  _AttributeName[intIndex])
{
mstrXWordId = value.ToString();
 AddUpdatedFld(conXWord.XWordId);
}
else if (conXWord.XWordName  ==  _AttributeName[intIndex])
{
mstrXWordName = value.ToString();
 AddUpdatedFld(conXWord.XWordName);
}
}
}

/// <summary>
/// X词Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string XWordId
{
get
{
return mstrXWordId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrXWordId = value;
}
else
{
 mstrXWordId = value;
}
//记录修改过的字段
 AddUpdatedFld(conXWord.XWordId);
}
}
/// <summary>
/// X词名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string XWordName
{
get
{
return mstrXWordName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrXWordName = value;
}
else
{
 mstrXWordName = value;
}
//记录修改过的字段
 AddUpdatedFld(conXWord.XWordName);
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
  return mstrXWordId;
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
  return mstrXWordName;
 }
 }
}
 /// <summary>
 /// X词(XWord)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conXWord
{
public const string _CurrTabName = "XWord"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "XWordId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"XWordId", "XWordName"};
//以下是属性变量


 /// <summary>
 /// 常量:"XWordId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string XWordId = "XWordId";    //X词Id

 /// <summary>
 /// 常量:"XWordName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string XWordName = "XWordName";    //X词名
}

}