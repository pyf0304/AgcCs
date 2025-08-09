
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clstz_CommKeyWordsEN
 表名:tz_CommKeyWords(00050330)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:10:21
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统设置(SystemSet)
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
 /// 表tz_CommKeyWords的关键字(KeyId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_KeyId_tz_CommKeyWords
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strKeyId">表关键字</param>
public K_KeyId_tz_CommKeyWords(string strKeyId)
{
if (IsValid(strKeyId)) Value = strKeyId;
else
{
Value = null;
}
}
private static bool IsValid(string strKeyId)
{
if (string.IsNullOrEmpty(strKeyId) == true) return false;
if (strKeyId.Length > 8) return false;
if (strKeyId.IndexOf(' ') >= 0) return false;
if (strKeyId.IndexOf(')') >= 0) return false;
if (strKeyId.IndexOf('(') >= 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_KeyId_tz_CommKeyWords]类型的对象</returns>
public static implicit operator K_KeyId_tz_CommKeyWords(string value)
{
return new K_KeyId_tz_CommKeyWords(value);
}
}
 /// <summary>
 /// tz_通用关键字(tz_CommKeyWords)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clstz_CommKeyWordsEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "tz_CommKeyWords"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "KeyId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 7;
public static string[] _AttributeName = new string[] {"KeyId", "Keyword", "TableName", "TableKey", "UpdUser", "UpdDate", "Memo"};

protected string mstrKeyId;    //关键字Id
protected string mstrKeyword;    //关键字
protected string mstrTableName;    //表名
protected string mstrTableKey;    //数据表关键字值
protected string mstrUpdUser;    //修改者
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clstz_CommKeyWordsEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("KeyId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strKeyId">关键字:关键字Id</param>
public clstz_CommKeyWordsEN(string strKeyId)
 {
strKeyId = strKeyId.Replace("'", "''");
if (strKeyId.Length > 8)
{
throw new Exception("在表:tz_CommKeyWords中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strKeyId)  ==  true)
{
throw new Exception("在表:tz_CommKeyWords中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strKeyId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrKeyId = strKeyId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("KeyId");
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
if (strAttributeName  ==  contz_CommKeyWords.KeyId)
{
return mstrKeyId;
}
else if (strAttributeName  ==  contz_CommKeyWords.Keyword)
{
return mstrKeyword;
}
else if (strAttributeName  ==  contz_CommKeyWords.TableName)
{
return mstrTableName;
}
else if (strAttributeName  ==  contz_CommKeyWords.TableKey)
{
return mstrTableKey;
}
else if (strAttributeName  ==  contz_CommKeyWords.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  contz_CommKeyWords.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  contz_CommKeyWords.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  contz_CommKeyWords.KeyId)
{
mstrKeyId = value.ToString();
 AddUpdatedFld(contz_CommKeyWords.KeyId);
}
else if (strAttributeName  ==  contz_CommKeyWords.Keyword)
{
mstrKeyword = value.ToString();
 AddUpdatedFld(contz_CommKeyWords.Keyword);
}
else if (strAttributeName  ==  contz_CommKeyWords.TableName)
{
mstrTableName = value.ToString();
 AddUpdatedFld(contz_CommKeyWords.TableName);
}
else if (strAttributeName  ==  contz_CommKeyWords.TableKey)
{
mstrTableKey = value.ToString();
 AddUpdatedFld(contz_CommKeyWords.TableKey);
}
else if (strAttributeName  ==  contz_CommKeyWords.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(contz_CommKeyWords.UpdUser);
}
else if (strAttributeName  ==  contz_CommKeyWords.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(contz_CommKeyWords.UpdDate);
}
else if (strAttributeName  ==  contz_CommKeyWords.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(contz_CommKeyWords.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (contz_CommKeyWords.KeyId  ==  _AttributeName[intIndex])
{
return mstrKeyId;
}
else if (contz_CommKeyWords.Keyword  ==  _AttributeName[intIndex])
{
return mstrKeyword;
}
else if (contz_CommKeyWords.TableName  ==  _AttributeName[intIndex])
{
return mstrTableName;
}
else if (contz_CommKeyWords.TableKey  ==  _AttributeName[intIndex])
{
return mstrTableKey;
}
else if (contz_CommKeyWords.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (contz_CommKeyWords.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (contz_CommKeyWords.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (contz_CommKeyWords.KeyId  ==  _AttributeName[intIndex])
{
mstrKeyId = value.ToString();
 AddUpdatedFld(contz_CommKeyWords.KeyId);
}
else if (contz_CommKeyWords.Keyword  ==  _AttributeName[intIndex])
{
mstrKeyword = value.ToString();
 AddUpdatedFld(contz_CommKeyWords.Keyword);
}
else if (contz_CommKeyWords.TableName  ==  _AttributeName[intIndex])
{
mstrTableName = value.ToString();
 AddUpdatedFld(contz_CommKeyWords.TableName);
}
else if (contz_CommKeyWords.TableKey  ==  _AttributeName[intIndex])
{
mstrTableKey = value.ToString();
 AddUpdatedFld(contz_CommKeyWords.TableKey);
}
else if (contz_CommKeyWords.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(contz_CommKeyWords.UpdUser);
}
else if (contz_CommKeyWords.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(contz_CommKeyWords.UpdDate);
}
else if (contz_CommKeyWords.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(contz_CommKeyWords.Memo);
}
}
}

/// <summary>
/// 关键字Id(说明:;字段类型:varchar;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KeyId
{
get
{
return mstrKeyId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeyId = value;
}
else
{
 mstrKeyId = value;
}
//记录修改过的字段
 AddUpdatedFld(contz_CommKeyWords.KeyId);
}
}
/// <summary>
/// 关键字(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Keyword
{
get
{
return mstrKeyword;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeyword = value;
}
else
{
 mstrKeyword = value;
}
//记录修改过的字段
 AddUpdatedFld(contz_CommKeyWords.Keyword);
}
}
/// <summary>
/// 表名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TableName
{
get
{
return mstrTableName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTableName = value;
}
else
{
 mstrTableName = value;
}
//记录修改过的字段
 AddUpdatedFld(contz_CommKeyWords.TableName);
}
}
/// <summary>
/// 数据表关键字值(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TableKey
{
get
{
return mstrTableKey;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTableKey = value;
}
else
{
 mstrTableKey = value;
}
//记录修改过的字段
 AddUpdatedFld(contz_CommKeyWords.TableKey);
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
 AddUpdatedFld(contz_CommKeyWords.UpdUser);
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
 AddUpdatedFld(contz_CommKeyWords.UpdDate);
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
 AddUpdatedFld(contz_CommKeyWords.Memo);
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
  return mstrKeyId;
 }
 }
}
 /// <summary>
 /// tz_通用关键字(tz_CommKeyWords)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class contz_CommKeyWords
{
public const string _CurrTabName = "tz_CommKeyWords"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "KeyId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"KeyId", "Keyword", "TableName", "TableKey", "UpdUser", "UpdDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"KeyId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KeyId = "KeyId";    //关键字Id

 /// <summary>
 /// 常量:"Keyword"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Keyword = "Keyword";    //关键字

 /// <summary>
 /// 常量:"TableName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TableName = "TableName";    //表名

 /// <summary>
 /// 常量:"TableKey"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TableKey = "TableKey";    //数据表关键字值

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改者

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}