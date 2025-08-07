
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsWordTypeEN
 表名:WordType(00050017)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:37:11
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:电子字典(ElecDict)
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
 /// 表WordType的关键字(WordTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_WordTypeId_WordType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strWordTypeId">表关键字</param>
public K_WordTypeId_WordType(string strWordTypeId)
{
if (IsValid(strWordTypeId)) Value = strWordTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strWordTypeId)
{
if (string.IsNullOrEmpty(strWordTypeId) == true) return false;
if (strWordTypeId.Length > 2) return false;
if (strWordTypeId.IndexOf(' ') >= 0) return false;
if (strWordTypeId.IndexOf(')') >= 0) return false;
if (strWordTypeId.IndexOf('(') >= 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_WordTypeId_WordType]类型的对象</returns>
public static implicit operator K_WordTypeId_WordType(string value)
{
return new K_WordTypeId_WordType(value);
}
}
 /// <summary>
 /// 单词分类(WordType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsWordTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "WordType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "WordTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 3;
public static string[] _AttributeName = new string[] {"WordTypeId", "WordTypeName", "Memo"};

protected string mstrWordTypeId;    //单词分类ID
protected string mstrWordTypeName;    //单词分类名
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsWordTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("WordTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strWordTypeId">关键字:单词分类ID</param>
public clsWordTypeEN(string strWordTypeId)
 {
strWordTypeId = strWordTypeId.Replace("'", "''");
if (strWordTypeId.Length > 2)
{
throw new Exception("在表:WordType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strWordTypeId)  ==  true)
{
throw new Exception("在表:WordType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strWordTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrWordTypeId = strWordTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("WordTypeId");
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
if (strAttributeName  ==  conWordType.WordTypeId)
{
return mstrWordTypeId;
}
else if (strAttributeName  ==  conWordType.WordTypeName)
{
return mstrWordTypeName;
}
else if (strAttributeName  ==  conWordType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conWordType.WordTypeId)
{
mstrWordTypeId = value.ToString();
 AddUpdatedFld(conWordType.WordTypeId);
}
else if (strAttributeName  ==  conWordType.WordTypeName)
{
mstrWordTypeName = value.ToString();
 AddUpdatedFld(conWordType.WordTypeName);
}
else if (strAttributeName  ==  conWordType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conWordType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conWordType.WordTypeId  ==  _AttributeName[intIndex])
{
return mstrWordTypeId;
}
else if (conWordType.WordTypeName  ==  _AttributeName[intIndex])
{
return mstrWordTypeName;
}
else if (conWordType.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conWordType.WordTypeId  ==  _AttributeName[intIndex])
{
mstrWordTypeId = value.ToString();
 AddUpdatedFld(conWordType.WordTypeId);
}
else if (conWordType.WordTypeName  ==  _AttributeName[intIndex])
{
mstrWordTypeName = value.ToString();
 AddUpdatedFld(conWordType.WordTypeName);
}
else if (conWordType.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conWordType.Memo);
}
}
}

/// <summary>
/// 单词分类ID(说明:;字段类型:varchar;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WordTypeId
{
get
{
return mstrWordTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWordTypeId = value;
}
else
{
 mstrWordTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conWordType.WordTypeId);
}
}
/// <summary>
/// 单词分类名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WordTypeName
{
get
{
return mstrWordTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWordTypeName = value;
}
else
{
 mstrWordTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conWordType.WordTypeName);
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
 AddUpdatedFld(conWordType.Memo);
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
  return mstrWordTypeId;
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
  return mstrWordTypeName;
 }
 }
}
 /// <summary>
 /// 单词分类(WordType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conWordType
{
public const string _CurrTabName = "WordType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "WordTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"WordTypeId", "WordTypeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"WordTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WordTypeId = "WordTypeId";    //单词分类ID

 /// <summary>
 /// 常量:"WordTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WordTypeName = "WordTypeName";    //单词分类名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}