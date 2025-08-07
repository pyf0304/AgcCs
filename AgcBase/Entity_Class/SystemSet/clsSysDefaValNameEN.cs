
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSysDefaValNameEN
 表名:SysDefaValName(00050085)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:35:39
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
 /// 表SysDefaValName的关键字(DefaValNameId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_DefaValNameId_SysDefaValName
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strDefaValNameId">表关键字</param>
public K_DefaValNameId_SysDefaValName(string strDefaValNameId)
{
if (IsValid(strDefaValNameId)) Value = strDefaValNameId;
else
{
Value = null;
}
}
private static bool IsValid(string strDefaValNameId)
{
if (string.IsNullOrEmpty(strDefaValNameId) == true) return false;
if (strDefaValNameId.Length > 8) return false;
if (strDefaValNameId.IndexOf(' ') >= 0) return false;
if (strDefaValNameId.IndexOf(')') >= 0) return false;
if (strDefaValNameId.IndexOf('(') >= 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_DefaValNameId_SysDefaValName]类型的对象</returns>
public static implicit operator K_DefaValNameId_SysDefaValName(string value)
{
return new K_DefaValNameId_SysDefaValName(value);
}
}
 /// <summary>
 /// SysDefaValName(SysDefaValName)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsSysDefaValNameEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "SysDefaValName"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "DefaValNameId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 4;
public static string[] _AttributeName = new string[] {"DefaValNameId", "PrjId", "DefaValName", "SysDefaValue"};

protected string mstrDefaValNameId;    //DefaValNameId
protected string mstrPrjId;    //工程Id
protected string mstrDefaValName;    //DefaValName
protected string mstrSysDefaValue;    //SysDefaValue

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsSysDefaValNameEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("DefaValNameId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strDefaValNameId">关键字:DefaValNameId</param>
public clsSysDefaValNameEN(string strDefaValNameId)
 {
strDefaValNameId = strDefaValNameId.Replace("'", "''");
if (strDefaValNameId.Length > 8)
{
throw new Exception("在表:SysDefaValName中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strDefaValNameId)  ==  true)
{
throw new Exception("在表:SysDefaValName中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strDefaValNameId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrDefaValNameId = strDefaValNameId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("DefaValNameId");
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
if (strAttributeName  ==  conSysDefaValName.DefaValNameId)
{
return mstrDefaValNameId;
}
else if (strAttributeName  ==  conSysDefaValName.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conSysDefaValName.DefaValName)
{
return mstrDefaValName;
}
else if (strAttributeName  ==  conSysDefaValName.SysDefaValue)
{
return mstrSysDefaValue;
}
return null;
}
set
{
if (strAttributeName  ==  conSysDefaValName.DefaValNameId)
{
mstrDefaValNameId = value.ToString();
 AddUpdatedFld(conSysDefaValName.DefaValNameId);
}
else if (strAttributeName  ==  conSysDefaValName.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conSysDefaValName.PrjId);
}
else if (strAttributeName  ==  conSysDefaValName.DefaValName)
{
mstrDefaValName = value.ToString();
 AddUpdatedFld(conSysDefaValName.DefaValName);
}
else if (strAttributeName  ==  conSysDefaValName.SysDefaValue)
{
mstrSysDefaValue = value.ToString();
 AddUpdatedFld(conSysDefaValName.SysDefaValue);
}
}
}
public object this[int intIndex]
{
get
{
if (conSysDefaValName.DefaValNameId  ==  _AttributeName[intIndex])
{
return mstrDefaValNameId;
}
else if (conSysDefaValName.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conSysDefaValName.DefaValName  ==  _AttributeName[intIndex])
{
return mstrDefaValName;
}
else if (conSysDefaValName.SysDefaValue  ==  _AttributeName[intIndex])
{
return mstrSysDefaValue;
}
return null;
}
set
{
if (conSysDefaValName.DefaValNameId  ==  _AttributeName[intIndex])
{
mstrDefaValNameId = value.ToString();
 AddUpdatedFld(conSysDefaValName.DefaValNameId);
}
else if (conSysDefaValName.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conSysDefaValName.PrjId);
}
else if (conSysDefaValName.DefaValName  ==  _AttributeName[intIndex])
{
mstrDefaValName = value.ToString();
 AddUpdatedFld(conSysDefaValName.DefaValName);
}
else if (conSysDefaValName.SysDefaValue  ==  _AttributeName[intIndex])
{
mstrSysDefaValue = value.ToString();
 AddUpdatedFld(conSysDefaValName.SysDefaValue);
}
}
}

/// <summary>
/// DefaValNameId(说明:;字段类型:varchar;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DefaValNameId
{
get
{
return mstrDefaValNameId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDefaValNameId = value;
}
else
{
 mstrDefaValNameId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSysDefaValName.DefaValNameId);
}
}
/// <summary>
/// 工程Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjId
{
get
{
return mstrPrjId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjId = value;
}
else
{
 mstrPrjId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSysDefaValName.PrjId);
}
}
/// <summary>
/// DefaValName(说明:;字段类型:varchar;字段长度:40;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DefaValName
{
get
{
return mstrDefaValName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDefaValName = value;
}
else
{
 mstrDefaValName = value;
}
//记录修改过的字段
 AddUpdatedFld(conSysDefaValName.DefaValName);
}
}
/// <summary>
/// SysDefaValue(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SysDefaValue
{
get
{
return mstrSysDefaValue;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSysDefaValue = value;
}
else
{
 mstrSysDefaValue = value;
}
//记录修改过的字段
 AddUpdatedFld(conSysDefaValName.SysDefaValue);
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
  return mstrDefaValNameId;
 }
 }
}
 /// <summary>
 /// SysDefaValName(SysDefaValName)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conSysDefaValName
{
public const string _CurrTabName = "SysDefaValName"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "DefaValNameId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"DefaValNameId", "PrjId", "DefaValName", "SysDefaValue"};
//以下是属性变量


 /// <summary>
 /// 常量:"DefaValNameId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DefaValNameId = "DefaValNameId";    //DefaValNameId

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"DefaValName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DefaValName = "DefaValName";    //DefaValName

 /// <summary>
 /// 常量:"SysDefaValue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SysDefaValue = "SysDefaValue";    //SysDefaValue
}

}