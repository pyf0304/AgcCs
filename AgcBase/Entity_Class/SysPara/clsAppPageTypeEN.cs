
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsAppPageTypeEN
 表名:AppPageType(00050382)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:09:47
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
 /// 表AppPageType的关键字(AppPageTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_AppPageTypeId_AppPageType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strAppPageTypeId">表关键字</param>
public K_AppPageTypeId_AppPageType(string strAppPageTypeId)
{
if (IsValid(strAppPageTypeId)) Value = strAppPageTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strAppPageTypeId)
{
if (string.IsNullOrEmpty(strAppPageTypeId) == true) return false;
if (strAppPageTypeId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_AppPageTypeId_AppPageType]类型的对象</returns>
public static implicit operator K_AppPageTypeId_AppPageType(string value)
{
return new K_AppPageTypeId_AppPageType(value);
}
}
 /// <summary>
 /// App页面类型(AppPageType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsAppPageTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "AppPageType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "AppPageTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 6;
public static string[] _AttributeName = new string[] {"AppPageTypeId", "AppPageTypeName", "AppPageTypeENName", "UpdDate", "UpdUser", "Memo"};

protected string mstrAppPageTypeId;    //App页面类型Id
protected string mstrAppPageTypeName;    //App页面类型名
protected string mstrAppPageTypeENName;    //App页面类型英文名
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsAppPageTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("AppPageTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strAppPageTypeId">关键字:App页面类型Id</param>
public clsAppPageTypeEN(string strAppPageTypeId)
 {
strAppPageTypeId = strAppPageTypeId.Replace("'", "''");
if (strAppPageTypeId.Length > 4)
{
throw new Exception("在表:AppPageType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strAppPageTypeId)  ==  true)
{
throw new Exception("在表:AppPageType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strAppPageTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrAppPageTypeId = strAppPageTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("AppPageTypeId");
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
if (strAttributeName  ==  conAppPageType.AppPageTypeId)
{
return mstrAppPageTypeId;
}
else if (strAttributeName  ==  conAppPageType.AppPageTypeName)
{
return mstrAppPageTypeName;
}
else if (strAttributeName  ==  conAppPageType.AppPageTypeENName)
{
return mstrAppPageTypeENName;
}
else if (strAttributeName  ==  conAppPageType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conAppPageType.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conAppPageType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conAppPageType.AppPageTypeId)
{
mstrAppPageTypeId = value.ToString();
 AddUpdatedFld(conAppPageType.AppPageTypeId);
}
else if (strAttributeName  ==  conAppPageType.AppPageTypeName)
{
mstrAppPageTypeName = value.ToString();
 AddUpdatedFld(conAppPageType.AppPageTypeName);
}
else if (strAttributeName  ==  conAppPageType.AppPageTypeENName)
{
mstrAppPageTypeENName = value.ToString();
 AddUpdatedFld(conAppPageType.AppPageTypeENName);
}
else if (strAttributeName  ==  conAppPageType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conAppPageType.UpdDate);
}
else if (strAttributeName  ==  conAppPageType.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conAppPageType.UpdUser);
}
else if (strAttributeName  ==  conAppPageType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conAppPageType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conAppPageType.AppPageTypeId  ==  _AttributeName[intIndex])
{
return mstrAppPageTypeId;
}
else if (conAppPageType.AppPageTypeName  ==  _AttributeName[intIndex])
{
return mstrAppPageTypeName;
}
else if (conAppPageType.AppPageTypeENName  ==  _AttributeName[intIndex])
{
return mstrAppPageTypeENName;
}
else if (conAppPageType.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conAppPageType.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conAppPageType.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conAppPageType.AppPageTypeId  ==  _AttributeName[intIndex])
{
mstrAppPageTypeId = value.ToString();
 AddUpdatedFld(conAppPageType.AppPageTypeId);
}
else if (conAppPageType.AppPageTypeName  ==  _AttributeName[intIndex])
{
mstrAppPageTypeName = value.ToString();
 AddUpdatedFld(conAppPageType.AppPageTypeName);
}
else if (conAppPageType.AppPageTypeENName  ==  _AttributeName[intIndex])
{
mstrAppPageTypeENName = value.ToString();
 AddUpdatedFld(conAppPageType.AppPageTypeENName);
}
else if (conAppPageType.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conAppPageType.UpdDate);
}
else if (conAppPageType.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conAppPageType.UpdUser);
}
else if (conAppPageType.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conAppPageType.Memo);
}
}
}

/// <summary>
/// App页面类型Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AppPageTypeId
{
get
{
return mstrAppPageTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAppPageTypeId = value;
}
else
{
 mstrAppPageTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conAppPageType.AppPageTypeId);
}
}
/// <summary>
/// App页面类型名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AppPageTypeName
{
get
{
return mstrAppPageTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAppPageTypeName = value;
}
else
{
 mstrAppPageTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conAppPageType.AppPageTypeName);
}
}
/// <summary>
/// App页面类型英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AppPageTypeENName
{
get
{
return mstrAppPageTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAppPageTypeENName = value;
}
else
{
 mstrAppPageTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conAppPageType.AppPageTypeENName);
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
 AddUpdatedFld(conAppPageType.UpdDate);
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
 AddUpdatedFld(conAppPageType.UpdUser);
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
 AddUpdatedFld(conAppPageType.Memo);
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
  return mstrAppPageTypeId;
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
  return mstrAppPageTypeName;
 }
 }
}
 /// <summary>
 /// App页面类型(AppPageType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conAppPageType
{
public const string _CurrTabName = "AppPageType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "AppPageTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"AppPageTypeId", "AppPageTypeName", "AppPageTypeENName", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"AppPageTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppPageTypeId = "AppPageTypeId";    //App页面类型Id

 /// <summary>
 /// 常量:"AppPageTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppPageTypeName = "AppPageTypeName";    //App页面类型名

 /// <summary>
 /// 常量:"AppPageTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppPageTypeENName = "AppPageTypeENName";    //App页面类型英文名

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改者

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}