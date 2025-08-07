
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewDesignEN
 表名:ViewDesign(00050429)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:37:19
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
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
 /// 表ViewDesign的关键字(ViewDesignId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ViewDesignId_ViewDesign
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strViewDesignId">表关键字</param>
public K_ViewDesignId_ViewDesign(string strViewDesignId)
{
if (IsValid(strViewDesignId)) Value = strViewDesignId;
else
{
Value = null;
}
}
private static bool IsValid(string strViewDesignId)
{
if (string.IsNullOrEmpty(strViewDesignId) == true) return false;
if (strViewDesignId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ViewDesignId_ViewDesign]类型的对象</returns>
public static implicit operator K_ViewDesignId_ViewDesign(string value)
{
return new K_ViewDesignId_ViewDesign(value);
}
}
 /// <summary>
 /// 界面设计(ViewDesign)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsViewDesignEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ViewDesign"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ViewDesignId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 3;
public static string[] _AttributeName = new string[] {"ViewDesignId", "ViewDesignName", "Memo"};

protected string mstrViewDesignId;    //界面设计Id
protected string mstrViewDesignName;    //界面设计名
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsViewDesignEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ViewDesignId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strViewDesignId">关键字:界面设计Id</param>
public clsViewDesignEN(string strViewDesignId)
 {
strViewDesignId = strViewDesignId.Replace("'", "''");
if (strViewDesignId.Length > 4)
{
throw new Exception("在表:ViewDesign中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strViewDesignId)  ==  true)
{
throw new Exception("在表:ViewDesign中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strViewDesignId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrViewDesignId = strViewDesignId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ViewDesignId");
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
if (strAttributeName  ==  conViewDesign.ViewDesignId)
{
return mstrViewDesignId;
}
else if (strAttributeName  ==  conViewDesign.ViewDesignName)
{
return mstrViewDesignName;
}
else if (strAttributeName  ==  conViewDesign.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conViewDesign.ViewDesignId)
{
mstrViewDesignId = value.ToString();
 AddUpdatedFld(conViewDesign.ViewDesignId);
}
else if (strAttributeName  ==  conViewDesign.ViewDesignName)
{
mstrViewDesignName = value.ToString();
 AddUpdatedFld(conViewDesign.ViewDesignName);
}
else if (strAttributeName  ==  conViewDesign.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conViewDesign.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conViewDesign.ViewDesignId  ==  _AttributeName[intIndex])
{
return mstrViewDesignId;
}
else if (conViewDesign.ViewDesignName  ==  _AttributeName[intIndex])
{
return mstrViewDesignName;
}
else if (conViewDesign.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conViewDesign.ViewDesignId  ==  _AttributeName[intIndex])
{
mstrViewDesignId = value.ToString();
 AddUpdatedFld(conViewDesign.ViewDesignId);
}
else if (conViewDesign.ViewDesignName  ==  _AttributeName[intIndex])
{
mstrViewDesignName = value.ToString();
 AddUpdatedFld(conViewDesign.ViewDesignName);
}
else if (conViewDesign.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conViewDesign.Memo);
}
}
}

/// <summary>
/// 界面设计Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewDesignId
{
get
{
return mstrViewDesignId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewDesignId = value;
}
else
{
 mstrViewDesignId = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewDesign.ViewDesignId);
}
}
/// <summary>
/// 界面设计名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewDesignName
{
get
{
return mstrViewDesignName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewDesignName = value;
}
else
{
 mstrViewDesignName = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewDesign.ViewDesignName);
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
 AddUpdatedFld(conViewDesign.Memo);
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
  return mstrViewDesignId;
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
  return mstrViewDesignName;
 }
 }
}
 /// <summary>
 /// 界面设计(ViewDesign)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conViewDesign
{
public const string _CurrTabName = "ViewDesign"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ViewDesignId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"ViewDesignId", "ViewDesignName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"ViewDesignId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewDesignId = "ViewDesignId";    //界面设计Id

 /// <summary>
 /// 常量:"ViewDesignName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewDesignName = "ViewDesignName";    //界面设计名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}