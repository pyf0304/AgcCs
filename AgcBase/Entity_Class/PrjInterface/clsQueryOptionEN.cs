
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQueryOptionEN
 表名:QueryOption(00050080)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:35:33
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:界面管理(PrjInterface)
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
 /// 表QueryOption的关键字(QueryOptionId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_QueryOptionId_QueryOption
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strQueryOptionId">表关键字</param>
public K_QueryOptionId_QueryOption(string strQueryOptionId)
{
if (IsValid(strQueryOptionId)) Value = strQueryOptionId;
else
{
Value = null;
}
}
private static bool IsValid(string strQueryOptionId)
{
if (string.IsNullOrEmpty(strQueryOptionId) == true) return false;
if (strQueryOptionId.Length > 2) return false;
if (strQueryOptionId.IndexOf(' ') >= 0) return false;
if (strQueryOptionId.IndexOf(')') >= 0) return false;
if (strQueryOptionId.IndexOf('(') >= 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_QueryOptionId_QueryOption]类型的对象</returns>
public static implicit operator K_QueryOptionId_QueryOption(string value)
{
return new K_QueryOptionId_QueryOption(value);
}
}
 /// <summary>
 /// 查询选项(QueryOption)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQueryOptionEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "QueryOption"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "QueryOptionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 4;
public static string[] _AttributeName = new string[] {"QueryOptionId", "QueryOptionName", "QueryOptionENName", "Memo"};

protected string mstrQueryOptionId;    //查询方式Id
protected string mstrQueryOptionName;    //查询方式名称
protected string mstrQueryOptionENName;    //查询方式英文名
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsQueryOptionEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("QueryOptionId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strQueryOptionId">关键字:查询方式Id</param>
public clsQueryOptionEN(string strQueryOptionId)
 {
strQueryOptionId = strQueryOptionId.Replace("'", "''");
if (strQueryOptionId.Length > 2)
{
throw new Exception("在表:QueryOption中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strQueryOptionId)  ==  true)
{
throw new Exception("在表:QueryOption中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strQueryOptionId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrQueryOptionId = strQueryOptionId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("QueryOptionId");
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
if (strAttributeName  ==  conQueryOption.QueryOptionId)
{
return mstrQueryOptionId;
}
else if (strAttributeName  ==  conQueryOption.QueryOptionName)
{
return mstrQueryOptionName;
}
else if (strAttributeName  ==  conQueryOption.QueryOptionENName)
{
return mstrQueryOptionENName;
}
else if (strAttributeName  ==  conQueryOption.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conQueryOption.QueryOptionId)
{
mstrQueryOptionId = value.ToString();
 AddUpdatedFld(conQueryOption.QueryOptionId);
}
else if (strAttributeName  ==  conQueryOption.QueryOptionName)
{
mstrQueryOptionName = value.ToString();
 AddUpdatedFld(conQueryOption.QueryOptionName);
}
else if (strAttributeName  ==  conQueryOption.QueryOptionENName)
{
mstrQueryOptionENName = value.ToString();
 AddUpdatedFld(conQueryOption.QueryOptionENName);
}
else if (strAttributeName  ==  conQueryOption.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQueryOption.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conQueryOption.QueryOptionId  ==  _AttributeName[intIndex])
{
return mstrQueryOptionId;
}
else if (conQueryOption.QueryOptionName  ==  _AttributeName[intIndex])
{
return mstrQueryOptionName;
}
else if (conQueryOption.QueryOptionENName  ==  _AttributeName[intIndex])
{
return mstrQueryOptionENName;
}
else if (conQueryOption.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conQueryOption.QueryOptionId  ==  _AttributeName[intIndex])
{
mstrQueryOptionId = value.ToString();
 AddUpdatedFld(conQueryOption.QueryOptionId);
}
else if (conQueryOption.QueryOptionName  ==  _AttributeName[intIndex])
{
mstrQueryOptionName = value.ToString();
 AddUpdatedFld(conQueryOption.QueryOptionName);
}
else if (conQueryOption.QueryOptionENName  ==  _AttributeName[intIndex])
{
mstrQueryOptionENName = value.ToString();
 AddUpdatedFld(conQueryOption.QueryOptionENName);
}
else if (conQueryOption.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQueryOption.Memo);
}
}
}

/// <summary>
/// 查询方式Id(说明:;字段类型:varchar;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QueryOptionId
{
get
{
return mstrQueryOptionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQueryOptionId = value;
}
else
{
 mstrQueryOptionId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQueryOption.QueryOptionId);
}
}
/// <summary>
/// 查询方式名称(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QueryOptionName
{
get
{
return mstrQueryOptionName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQueryOptionName = value;
}
else
{
 mstrQueryOptionName = value;
}
//记录修改过的字段
 AddUpdatedFld(conQueryOption.QueryOptionName);
}
}
/// <summary>
/// 查询方式英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QueryOptionENName
{
get
{
return mstrQueryOptionENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQueryOptionENName = value;
}
else
{
 mstrQueryOptionENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conQueryOption.QueryOptionENName);
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
 AddUpdatedFld(conQueryOption.Memo);
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
  return mstrQueryOptionId;
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
  return mstrQueryOptionName;
 }
 }
}
 /// <summary>
 /// 查询选项(QueryOption)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conQueryOption
{
public const string _CurrTabName = "QueryOption"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "QueryOptionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"QueryOptionId", "QueryOptionName", "QueryOptionENName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"QueryOptionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QueryOptionId = "QueryOptionId";    //查询方式Id

 /// <summary>
 /// 常量:"QueryOptionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QueryOptionName = "QueryOptionName";    //查询方式名称

 /// <summary>
 /// 常量:"QueryOptionENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QueryOptionENName = "QueryOptionENName";    //查询方式英文名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}