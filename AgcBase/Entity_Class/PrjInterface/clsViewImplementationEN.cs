
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewImplementationEN
 表名:ViewImplementation(00050396)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:09:35
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
 /// 表ViewImplementation的关键字(ViewImplId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ViewImplId_ViewImplementation
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strViewImplId">表关键字</param>
public K_ViewImplId_ViewImplementation(string strViewImplId)
{
if (IsValid(strViewImplId)) Value = strViewImplId;
else
{
Value = null;
}
}
private static bool IsValid(string strViewImplId)
{
if (string.IsNullOrEmpty(strViewImplId) == true) return false;
if (strViewImplId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ViewImplId_ViewImplementation]类型的对象</returns>
public static implicit operator K_ViewImplId_ViewImplementation(string value)
{
return new K_ViewImplId_ViewImplementation(value);
}
}
 /// <summary>
 /// 界面实现方式(ViewImplementation)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsViewImplementationEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ViewImplementation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ViewImplId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 6;
public static string[] _AttributeName = new string[] {"ViewImplId", "ViewImplName", "ViewImplENName", "UpdDate", "UpdUser", "Memo"};

protected string mstrViewImplId;    //界面实现Id
protected string mstrViewImplName;    //界面实现名
protected string mstrViewImplENName;    //界面实现英文名
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsViewImplementationEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ViewImplId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strViewImplId">关键字:界面实现Id</param>
public clsViewImplementationEN(string strViewImplId)
 {
strViewImplId = strViewImplId.Replace("'", "''");
if (strViewImplId.Length > 4)
{
throw new Exception("在表:ViewImplementation中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strViewImplId)  ==  true)
{
throw new Exception("在表:ViewImplementation中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strViewImplId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrViewImplId = strViewImplId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ViewImplId");
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
if (strAttributeName  ==  conViewImplementation.ViewImplId)
{
return mstrViewImplId;
}
else if (strAttributeName  ==  conViewImplementation.ViewImplName)
{
return mstrViewImplName;
}
else if (strAttributeName  ==  conViewImplementation.ViewImplENName)
{
return mstrViewImplENName;
}
else if (strAttributeName  ==  conViewImplementation.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conViewImplementation.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conViewImplementation.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conViewImplementation.ViewImplId)
{
mstrViewImplId = value.ToString();
 AddUpdatedFld(conViewImplementation.ViewImplId);
}
else if (strAttributeName  ==  conViewImplementation.ViewImplName)
{
mstrViewImplName = value.ToString();
 AddUpdatedFld(conViewImplementation.ViewImplName);
}
else if (strAttributeName  ==  conViewImplementation.ViewImplENName)
{
mstrViewImplENName = value.ToString();
 AddUpdatedFld(conViewImplementation.ViewImplENName);
}
else if (strAttributeName  ==  conViewImplementation.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conViewImplementation.UpdDate);
}
else if (strAttributeName  ==  conViewImplementation.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conViewImplementation.UpdUser);
}
else if (strAttributeName  ==  conViewImplementation.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conViewImplementation.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conViewImplementation.ViewImplId  ==  _AttributeName[intIndex])
{
return mstrViewImplId;
}
else if (conViewImplementation.ViewImplName  ==  _AttributeName[intIndex])
{
return mstrViewImplName;
}
else if (conViewImplementation.ViewImplENName  ==  _AttributeName[intIndex])
{
return mstrViewImplENName;
}
else if (conViewImplementation.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conViewImplementation.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conViewImplementation.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conViewImplementation.ViewImplId  ==  _AttributeName[intIndex])
{
mstrViewImplId = value.ToString();
 AddUpdatedFld(conViewImplementation.ViewImplId);
}
else if (conViewImplementation.ViewImplName  ==  _AttributeName[intIndex])
{
mstrViewImplName = value.ToString();
 AddUpdatedFld(conViewImplementation.ViewImplName);
}
else if (conViewImplementation.ViewImplENName  ==  _AttributeName[intIndex])
{
mstrViewImplENName = value.ToString();
 AddUpdatedFld(conViewImplementation.ViewImplENName);
}
else if (conViewImplementation.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conViewImplementation.UpdDate);
}
else if (conViewImplementation.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conViewImplementation.UpdUser);
}
else if (conViewImplementation.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conViewImplementation.Memo);
}
}
}

/// <summary>
/// 界面实现Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewImplId
{
get
{
return mstrViewImplId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewImplId = value;
}
else
{
 mstrViewImplId = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewImplementation.ViewImplId);
}
}
/// <summary>
/// 界面实现名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewImplName
{
get
{
return mstrViewImplName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewImplName = value;
}
else
{
 mstrViewImplName = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewImplementation.ViewImplName);
}
}
/// <summary>
/// 界面实现英文名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewImplENName
{
get
{
return mstrViewImplENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewImplENName = value;
}
else
{
 mstrViewImplENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewImplementation.ViewImplENName);
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
 AddUpdatedFld(conViewImplementation.UpdDate);
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
 AddUpdatedFld(conViewImplementation.UpdUser);
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
 AddUpdatedFld(conViewImplementation.Memo);
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
  return mstrViewImplId;
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
  return mstrViewImplName;
 }
 }
}
 /// <summary>
 /// 界面实现方式(ViewImplementation)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conViewImplementation
{
public const string _CurrTabName = "ViewImplementation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ViewImplId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"ViewImplId", "ViewImplName", "ViewImplENName", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"ViewImplId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewImplId = "ViewImplId";    //界面实现Id

 /// <summary>
 /// 常量:"ViewImplName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewImplName = "ViewImplName";    //界面实现名

 /// <summary>
 /// 常量:"ViewImplENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewImplENName = "ViewImplENName";    //界面实现英文名

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