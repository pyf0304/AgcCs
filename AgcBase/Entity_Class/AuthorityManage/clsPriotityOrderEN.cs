
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPriotityOrderEN
 表名:PriotityOrder(00050036)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:13:24
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:权限管理(AuthorityManage)
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
 /// 表PriotityOrder的关键字(PriOrderId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PriOrderId_PriotityOrder
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strPriOrderId">表关键字</param>
public K_PriOrderId_PriotityOrder(string strPriOrderId)
{
if (IsValid(strPriOrderId)) Value = strPriOrderId;
else
{
Value = null;
}
}
private static bool IsValid(string strPriOrderId)
{
if (string.IsNullOrEmpty(strPriOrderId) == true) return false;
if (strPriOrderId.Length > 2) return false;
if (strPriOrderId.IndexOf(' ') >= 0) return false;
if (strPriOrderId.IndexOf(')') >= 0) return false;
if (strPriOrderId.IndexOf('(') >= 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PriOrderId_PriotityOrder]类型的对象</returns>
public static implicit operator K_PriOrderId_PriotityOrder(string value)
{
return new K_PriOrderId_PriotityOrder(value);
}
}
 /// <summary>
 /// PriotityOrder(PriotityOrder)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsPriotityOrderEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "PriotityOrder"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PriOrderId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 2;
public static string[] _AttributeName = new string[] {"PriOrderId", "PriOrderName"};

protected string mstrPriOrderId;    //PriOrderId
protected string mstrPriOrderName;    //PriOrderName

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsPriotityOrderEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PriOrderId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strPriOrderId">关键字:PriOrderId</param>
public clsPriotityOrderEN(string strPriOrderId)
 {
strPriOrderId = strPriOrderId.Replace("'", "''");
if (strPriOrderId.Length > 2)
{
throw new Exception("在表:PriotityOrder中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strPriOrderId)  ==  true)
{
throw new Exception("在表:PriotityOrder中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPriOrderId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrPriOrderId = strPriOrderId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PriOrderId");
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
if (strAttributeName  ==  conPriotityOrder.PriOrderId)
{
return mstrPriOrderId;
}
else if (strAttributeName  ==  conPriotityOrder.PriOrderName)
{
return mstrPriOrderName;
}
return null;
}
set
{
if (strAttributeName  ==  conPriotityOrder.PriOrderId)
{
mstrPriOrderId = value.ToString();
 AddUpdatedFld(conPriotityOrder.PriOrderId);
}
else if (strAttributeName  ==  conPriotityOrder.PriOrderName)
{
mstrPriOrderName = value.ToString();
 AddUpdatedFld(conPriotityOrder.PriOrderName);
}
}
}
public object this[int intIndex]
{
get
{
if (conPriotityOrder.PriOrderId  ==  _AttributeName[intIndex])
{
return mstrPriOrderId;
}
else if (conPriotityOrder.PriOrderName  ==  _AttributeName[intIndex])
{
return mstrPriOrderName;
}
return null;
}
set
{
if (conPriotityOrder.PriOrderId  ==  _AttributeName[intIndex])
{
mstrPriOrderId = value.ToString();
 AddUpdatedFld(conPriotityOrder.PriOrderId);
}
else if (conPriotityOrder.PriOrderName  ==  _AttributeName[intIndex])
{
mstrPriOrderName = value.ToString();
 AddUpdatedFld(conPriotityOrder.PriOrderName);
}
}
}

/// <summary>
/// PriOrderId(说明:;字段类型:varchar;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PriOrderId
{
get
{
return mstrPriOrderId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPriOrderId = value;
}
else
{
 mstrPriOrderId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPriotityOrder.PriOrderId);
}
}
/// <summary>
/// PriOrderName(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PriOrderName
{
get
{
return mstrPriOrderName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPriOrderName = value;
}
else
{
 mstrPriOrderName = value;
}
//记录修改过的字段
 AddUpdatedFld(conPriotityOrder.PriOrderName);
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
  return mstrPriOrderId;
 }
 }
}
 /// <summary>
 /// PriotityOrder(PriotityOrder)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conPriotityOrder
{
public const string _CurrTabName = "PriotityOrder"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PriOrderId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"PriOrderId", "PriOrderName"};
//以下是属性变量


 /// <summary>
 /// 常量:"PriOrderId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PriOrderId = "PriOrderId";    //PriOrderId

 /// <summary>
 /// 常量:"PriOrderName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PriOrderName = "PriOrderName";    //PriOrderName
}

}