
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTitleTypeEN
 表名:TitleType(00050008)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:05:01
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
 /// 表TitleType的关键字(TitleTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TitleTypeId_TitleType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strTitleTypeId">表关键字</param>
public K_TitleTypeId_TitleType(string strTitleTypeId)
{
if (IsValid(strTitleTypeId)) Value = strTitleTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strTitleTypeId)
{
if (string.IsNullOrEmpty(strTitleTypeId) == true) return false;
if (strTitleTypeId.Length > 2) return false;
if (strTitleTypeId.IndexOf(' ') >= 0) return false;
if (strTitleTypeId.IndexOf(')') >= 0) return false;
if (strTitleTypeId.IndexOf('(') >= 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_TitleTypeId_TitleType]类型的对象</returns>
public static implicit operator K_TitleTypeId_TitleType(string value)
{
return new K_TitleTypeId_TitleType(value);
}
}
 /// <summary>
 /// 标题类型(TitleType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsTitleTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "TitleType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TitleTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 3;
public static string[] _AttributeName = new string[] {"TitleTypeId", "TitleTypeName", "Memo"};

protected string mstrTitleTypeId;    //标题类型ID
protected string mstrTitleTypeName;    //标题类型
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsTitleTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TitleTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strTitleTypeId">关键字:标题类型ID</param>
public clsTitleTypeEN(string strTitleTypeId)
 {
strTitleTypeId = strTitleTypeId.Replace("'", "''");
if (strTitleTypeId.Length > 2)
{
throw new Exception("在表:TitleType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTitleTypeId)  ==  true)
{
throw new Exception("在表:TitleType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTitleTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrTitleTypeId = strTitleTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TitleTypeId");
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
if (strAttributeName  ==  conTitleType.TitleTypeId)
{
return mstrTitleTypeId;
}
else if (strAttributeName  ==  conTitleType.TitleTypeName)
{
return mstrTitleTypeName;
}
else if (strAttributeName  ==  conTitleType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conTitleType.TitleTypeId)
{
mstrTitleTypeId = value.ToString();
 AddUpdatedFld(conTitleType.TitleTypeId);
}
else if (strAttributeName  ==  conTitleType.TitleTypeName)
{
mstrTitleTypeName = value.ToString();
 AddUpdatedFld(conTitleType.TitleTypeName);
}
else if (strAttributeName  ==  conTitleType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTitleType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conTitleType.TitleTypeId  ==  _AttributeName[intIndex])
{
return mstrTitleTypeId;
}
else if (conTitleType.TitleTypeName  ==  _AttributeName[intIndex])
{
return mstrTitleTypeName;
}
else if (conTitleType.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conTitleType.TitleTypeId  ==  _AttributeName[intIndex])
{
mstrTitleTypeId = value.ToString();
 AddUpdatedFld(conTitleType.TitleTypeId);
}
else if (conTitleType.TitleTypeName  ==  _AttributeName[intIndex])
{
mstrTitleTypeName = value.ToString();
 AddUpdatedFld(conTitleType.TitleTypeName);
}
else if (conTitleType.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTitleType.Memo);
}
}
}

/// <summary>
/// 标题类型ID(说明:;字段类型:varchar;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TitleTypeId
{
get
{
return mstrTitleTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTitleTypeId = value;
}
else
{
 mstrTitleTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conTitleType.TitleTypeId);
}
}
/// <summary>
/// 标题类型(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TitleTypeName
{
get
{
return mstrTitleTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTitleTypeName = value;
}
else
{
 mstrTitleTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conTitleType.TitleTypeName);
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
 AddUpdatedFld(conTitleType.Memo);
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
  return mstrTitleTypeId;
 }
 }
}
 /// <summary>
 /// 标题类型(TitleType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conTitleType
{
public const string _CurrTabName = "TitleType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TitleTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"TitleTypeId", "TitleTypeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"TitleTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TitleTypeId = "TitleTypeId";    //标题类型ID

 /// <summary>
 /// 常量:"TitleTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TitleTypeName = "TitleTypeName";    //标题类型

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}