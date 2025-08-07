
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPageDispModeEN
 表名:PageDispMode(00050253)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:34:12
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:菜单管理(PrjMenu)
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
 /// 表PageDispMode的关键字(PageDispModeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PageDispModeId_PageDispMode
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strPageDispModeId">表关键字</param>
public K_PageDispModeId_PageDispMode(string strPageDispModeId)
{
if (IsValid(strPageDispModeId)) Value = strPageDispModeId;
else
{
Value = null;
}
}
private static bool IsValid(string strPageDispModeId)
{
if (string.IsNullOrEmpty(strPageDispModeId) == true) return false;
if (strPageDispModeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PageDispModeId_PageDispMode]类型的对象</returns>
public static implicit operator K_PageDispModeId_PageDispMode(string value)
{
return new K_PageDispModeId_PageDispMode(value);
}
}
 /// <summary>
 /// 页面显示模式(PageDispMode)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsPageDispModeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "PageDispMode"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PageDispModeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 4;
public static string[] _AttributeName = new string[] {"PageDispModeId", "PageDispModeName", "PageDispModeENName", "Memo"};

protected string mstrPageDispModeId;    //页面显示模式Id
protected string mstrPageDispModeName;    //页面显示模式名称
protected string mstrPageDispModeENName;    //页面显示模式英文名
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsPageDispModeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PageDispModeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strPageDispModeId">关键字:页面显示模式Id</param>
public clsPageDispModeEN(string strPageDispModeId)
 {
strPageDispModeId = strPageDispModeId.Replace("'", "''");
if (strPageDispModeId.Length > 2)
{
throw new Exception("在表:PageDispMode中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strPageDispModeId)  ==  true)
{
throw new Exception("在表:PageDispMode中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPageDispModeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrPageDispModeId = strPageDispModeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PageDispModeId");
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
if (strAttributeName  ==  conPageDispMode.PageDispModeId)
{
return mstrPageDispModeId;
}
else if (strAttributeName  ==  conPageDispMode.PageDispModeName)
{
return mstrPageDispModeName;
}
else if (strAttributeName  ==  conPageDispMode.PageDispModeENName)
{
return mstrPageDispModeENName;
}
else if (strAttributeName  ==  conPageDispMode.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conPageDispMode.PageDispModeId)
{
mstrPageDispModeId = value.ToString();
 AddUpdatedFld(conPageDispMode.PageDispModeId);
}
else if (strAttributeName  ==  conPageDispMode.PageDispModeName)
{
mstrPageDispModeName = value.ToString();
 AddUpdatedFld(conPageDispMode.PageDispModeName);
}
else if (strAttributeName  ==  conPageDispMode.PageDispModeENName)
{
mstrPageDispModeENName = value.ToString();
 AddUpdatedFld(conPageDispMode.PageDispModeENName);
}
else if (strAttributeName  ==  conPageDispMode.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPageDispMode.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conPageDispMode.PageDispModeId  ==  _AttributeName[intIndex])
{
return mstrPageDispModeId;
}
else if (conPageDispMode.PageDispModeName  ==  _AttributeName[intIndex])
{
return mstrPageDispModeName;
}
else if (conPageDispMode.PageDispModeENName  ==  _AttributeName[intIndex])
{
return mstrPageDispModeENName;
}
else if (conPageDispMode.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conPageDispMode.PageDispModeId  ==  _AttributeName[intIndex])
{
mstrPageDispModeId = value.ToString();
 AddUpdatedFld(conPageDispMode.PageDispModeId);
}
else if (conPageDispMode.PageDispModeName  ==  _AttributeName[intIndex])
{
mstrPageDispModeName = value.ToString();
 AddUpdatedFld(conPageDispMode.PageDispModeName);
}
else if (conPageDispMode.PageDispModeENName  ==  _AttributeName[intIndex])
{
mstrPageDispModeENName = value.ToString();
 AddUpdatedFld(conPageDispMode.PageDispModeENName);
}
else if (conPageDispMode.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPageDispMode.Memo);
}
}
}

/// <summary>
/// 页面显示模式Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PageDispModeId
{
get
{
return mstrPageDispModeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPageDispModeId = value;
}
else
{
 mstrPageDispModeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPageDispMode.PageDispModeId);
}
}
/// <summary>
/// 页面显示模式名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PageDispModeName
{
get
{
return mstrPageDispModeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPageDispModeName = value;
}
else
{
 mstrPageDispModeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conPageDispMode.PageDispModeName);
}
}
/// <summary>
/// 页面显示模式英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PageDispModeENName
{
get
{
return mstrPageDispModeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPageDispModeENName = value;
}
else
{
 mstrPageDispModeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conPageDispMode.PageDispModeENName);
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
 AddUpdatedFld(conPageDispMode.Memo);
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
  return mstrPageDispModeId;
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
  return mstrPageDispModeName;
 }
 }
}
 /// <summary>
 /// 页面显示模式(PageDispMode)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conPageDispMode
{
public const string _CurrTabName = "PageDispMode"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PageDispModeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"PageDispModeId", "PageDispModeName", "PageDispModeENName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"PageDispModeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PageDispModeId = "PageDispModeId";    //页面显示模式Id

 /// <summary>
 /// 常量:"PageDispModeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PageDispModeName = "PageDispModeName";    //页面显示模式名称

 /// <summary>
 /// 常量:"PageDispModeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PageDispModeENName = "PageDispModeENName";    //页面显示模式英文名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}