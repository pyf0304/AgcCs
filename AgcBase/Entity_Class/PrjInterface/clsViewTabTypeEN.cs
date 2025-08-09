
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewTabTypeEN
 表名:ViewTabType(00050103)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:09:21
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
 /// 表ViewTabType的关键字(ViewTabTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ViewTabTypeId_ViewTabType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strViewTabTypeId">表关键字</param>
public K_ViewTabTypeId_ViewTabType(string strViewTabTypeId)
{
if (IsValid(strViewTabTypeId)) Value = strViewTabTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strViewTabTypeId)
{
if (string.IsNullOrEmpty(strViewTabTypeId) == true) return false;
if (strViewTabTypeId.Length > 4) return false;
if (strViewTabTypeId.IndexOf(' ') >= 0) return false;
if (strViewTabTypeId.IndexOf(')') >= 0) return false;
if (strViewTabTypeId.IndexOf('(') >= 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ViewTabTypeId_ViewTabType]类型的对象</returns>
public static implicit operator K_ViewTabTypeId_ViewTabType(string value)
{
return new K_ViewTabTypeId_ViewTabType(value);
}
}
 /// <summary>
 /// 界面表类型(ViewTabType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsViewTabTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ViewTabType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ViewTabTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 3;
public static string[] _AttributeName = new string[] {"ViewTabTypeId", "ViewTabTypeName", "TabTypeFunction"};

protected string mstrViewTabTypeId;    //界面表类型码
protected string mstrViewTabTypeName;    //ViewTabTypeName
protected string mstrTabTypeFunction;    //TabTypeFunction

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsViewTabTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ViewTabTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strViewTabTypeId">关键字:界面表类型码</param>
public clsViewTabTypeEN(string strViewTabTypeId)
 {
strViewTabTypeId = strViewTabTypeId.Replace("'", "''");
if (strViewTabTypeId.Length > 4)
{
throw new Exception("在表:ViewTabType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strViewTabTypeId)  ==  true)
{
throw new Exception("在表:ViewTabType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strViewTabTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrViewTabTypeId = strViewTabTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ViewTabTypeId");
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
if (strAttributeName  ==  conViewTabType.ViewTabTypeId)
{
return mstrViewTabTypeId;
}
else if (strAttributeName  ==  conViewTabType.ViewTabTypeName)
{
return mstrViewTabTypeName;
}
else if (strAttributeName  ==  conViewTabType.TabTypeFunction)
{
return mstrTabTypeFunction;
}
return null;
}
set
{
if (strAttributeName  ==  conViewTabType.ViewTabTypeId)
{
mstrViewTabTypeId = value.ToString();
 AddUpdatedFld(conViewTabType.ViewTabTypeId);
}
else if (strAttributeName  ==  conViewTabType.ViewTabTypeName)
{
mstrViewTabTypeName = value.ToString();
 AddUpdatedFld(conViewTabType.ViewTabTypeName);
}
else if (strAttributeName  ==  conViewTabType.TabTypeFunction)
{
mstrTabTypeFunction = value.ToString();
 AddUpdatedFld(conViewTabType.TabTypeFunction);
}
}
}
public object this[int intIndex]
{
get
{
if (conViewTabType.ViewTabTypeId  ==  _AttributeName[intIndex])
{
return mstrViewTabTypeId;
}
else if (conViewTabType.ViewTabTypeName  ==  _AttributeName[intIndex])
{
return mstrViewTabTypeName;
}
else if (conViewTabType.TabTypeFunction  ==  _AttributeName[intIndex])
{
return mstrTabTypeFunction;
}
return null;
}
set
{
if (conViewTabType.ViewTabTypeId  ==  _AttributeName[intIndex])
{
mstrViewTabTypeId = value.ToString();
 AddUpdatedFld(conViewTabType.ViewTabTypeId);
}
else if (conViewTabType.ViewTabTypeName  ==  _AttributeName[intIndex])
{
mstrViewTabTypeName = value.ToString();
 AddUpdatedFld(conViewTabType.ViewTabTypeName);
}
else if (conViewTabType.TabTypeFunction  ==  _AttributeName[intIndex])
{
mstrTabTypeFunction = value.ToString();
 AddUpdatedFld(conViewTabType.TabTypeFunction);
}
}
}

/// <summary>
/// 界面表类型码(说明:;字段类型:varchar;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewTabTypeId
{
get
{
return mstrViewTabTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewTabTypeId = value;
}
else
{
 mstrViewTabTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewTabType.ViewTabTypeId);
}
}
/// <summary>
/// ViewTabTypeName(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewTabTypeName
{
get
{
return mstrViewTabTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewTabTypeName = value;
}
else
{
 mstrViewTabTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewTabType.ViewTabTypeName);
}
}
/// <summary>
/// TabTypeFunction(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabTypeFunction
{
get
{
return mstrTabTypeFunction;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabTypeFunction = value;
}
else
{
 mstrTabTypeFunction = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewTabType.TabTypeFunction);
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
  return mstrViewTabTypeId;
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
  return mstrViewTabTypeName;
 }
 }
}
 /// <summary>
 /// 界面表类型(ViewTabType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conViewTabType
{
public const string _CurrTabName = "ViewTabType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ViewTabTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"ViewTabTypeId", "ViewTabTypeName", "TabTypeFunction"};
//以下是属性变量


 /// <summary>
 /// 常量:"ViewTabTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewTabTypeId = "ViewTabTypeId";    //界面表类型码

 /// <summary>
 /// 常量:"ViewTabTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewTabTypeName = "ViewTabTypeName";    //ViewTabTypeName

 /// <summary>
 /// 常量:"TabTypeFunction"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabTypeFunction = "TabTypeFunction";    //TabTypeFunction
}

}