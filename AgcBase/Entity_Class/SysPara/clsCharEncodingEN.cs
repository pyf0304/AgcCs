
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCharEncodingEN
 表名:CharEncoding(00050263)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:06:33
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统参数(SysPara)
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
 /// 表CharEncoding的关键字(CharEncodingId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CharEncodingId_CharEncoding
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strCharEncodingId">表关键字</param>
public K_CharEncodingId_CharEncoding(string strCharEncodingId)
{
if (IsValid(strCharEncodingId)) Value = strCharEncodingId;
else
{
Value = null;
}
}
private static bool IsValid(string strCharEncodingId)
{
if (string.IsNullOrEmpty(strCharEncodingId) == true) return false;
if (strCharEncodingId.Length > 20) return false;
if (strCharEncodingId.IndexOf(' ') >= 0) return false;
if (strCharEncodingId.IndexOf(')') >= 0) return false;
if (strCharEncodingId.IndexOf('(') >= 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_CharEncodingId_CharEncoding]类型的对象</returns>
public static implicit operator K_CharEncodingId_CharEncoding(string value)
{
return new K_CharEncodingId_CharEncoding(value);
}
}
 /// <summary>
 /// 字符编码(CharEncoding)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCharEncodingEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CharEncoding"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "CharEncodingId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 4;
public static string[] _AttributeName = new string[] {"CharEncodingId", "CharEncodingName", "IsDefault", "Memo"};

protected string mstrCharEncodingId;    //字符编码
protected string mstrCharEncodingName;    //字符编码名称
protected bool mbolIsDefault;    //是否默认
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsCharEncodingEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CharEncodingId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strCharEncodingId">关键字:字符编码</param>
public clsCharEncodingEN(string strCharEncodingId)
 {
strCharEncodingId = strCharEncodingId.Replace("'", "''");
if (strCharEncodingId.Length > 20)
{
throw new Exception("在表:CharEncoding中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strCharEncodingId)  ==  true)
{
throw new Exception("在表:CharEncoding中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCharEncodingId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrCharEncodingId = strCharEncodingId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CharEncodingId");
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
if (strAttributeName  ==  conCharEncoding.CharEncodingId)
{
return mstrCharEncodingId;
}
else if (strAttributeName  ==  conCharEncoding.CharEncodingName)
{
return mstrCharEncodingName;
}
else if (strAttributeName  ==  conCharEncoding.IsDefault)
{
return mbolIsDefault;
}
else if (strAttributeName  ==  conCharEncoding.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conCharEncoding.CharEncodingId)
{
mstrCharEncodingId = value.ToString();
 AddUpdatedFld(conCharEncoding.CharEncodingId);
}
else if (strAttributeName  ==  conCharEncoding.CharEncodingName)
{
mstrCharEncodingName = value.ToString();
 AddUpdatedFld(conCharEncoding.CharEncodingName);
}
else if (strAttributeName  ==  conCharEncoding.IsDefault)
{
mbolIsDefault = TransNullToBool(value.ToString());
 AddUpdatedFld(conCharEncoding.IsDefault);
}
else if (strAttributeName  ==  conCharEncoding.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCharEncoding.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conCharEncoding.CharEncodingId  ==  _AttributeName[intIndex])
{
return mstrCharEncodingId;
}
else if (conCharEncoding.CharEncodingName  ==  _AttributeName[intIndex])
{
return mstrCharEncodingName;
}
else if (conCharEncoding.IsDefault  ==  _AttributeName[intIndex])
{
return mbolIsDefault;
}
else if (conCharEncoding.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conCharEncoding.CharEncodingId  ==  _AttributeName[intIndex])
{
mstrCharEncodingId = value.ToString();
 AddUpdatedFld(conCharEncoding.CharEncodingId);
}
else if (conCharEncoding.CharEncodingName  ==  _AttributeName[intIndex])
{
mstrCharEncodingName = value.ToString();
 AddUpdatedFld(conCharEncoding.CharEncodingName);
}
else if (conCharEncoding.IsDefault  ==  _AttributeName[intIndex])
{
mbolIsDefault = TransNullToBool(value.ToString());
 AddUpdatedFld(conCharEncoding.IsDefault);
}
else if (conCharEncoding.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCharEncoding.Memo);
}
}
}

/// <summary>
/// 字符编码(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CharEncodingId
{
get
{
return mstrCharEncodingId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCharEncodingId = value;
}
else
{
 mstrCharEncodingId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCharEncoding.CharEncodingId);
}
}
/// <summary>
/// 字符编码名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CharEncodingName
{
get
{
return mstrCharEncodingName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCharEncodingName = value;
}
else
{
 mstrCharEncodingName = value;
}
//记录修改过的字段
 AddUpdatedFld(conCharEncoding.CharEncodingName);
}
}
/// <summary>
/// 是否默认(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsDefault
{
get
{
return mbolIsDefault;
}
set
{
 mbolIsDefault = value;
//记录修改过的字段
 AddUpdatedFld(conCharEncoding.IsDefault);
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
 AddUpdatedFld(conCharEncoding.Memo);
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
  return mstrCharEncodingId;
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
  return mstrCharEncodingName;
 }
 }
}
 /// <summary>
 /// 字符编码(CharEncoding)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCharEncoding
{
public const string _CurrTabName = "CharEncoding"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CharEncodingId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"CharEncodingId", "CharEncodingName", "IsDefault", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"CharEncodingId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CharEncodingId = "CharEncodingId";    //字符编码

 /// <summary>
 /// 常量:"CharEncodingName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CharEncodingName = "CharEncodingName";    //字符编码名称

 /// <summary>
 /// 常量:"IsDefault"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDefault = "IsDefault";    //是否默认

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}