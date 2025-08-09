
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjConstraint_SimEN
 表名:vPrjConstraint_Sim(00050638)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:02:37
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
 /// 表vPrjConstraint_Sim的关键字(PrjConstraintId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PrjConstraintId_vPrjConstraint_Sim
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strPrjConstraintId">表关键字</param>
public K_PrjConstraintId_vPrjConstraint_Sim(string strPrjConstraintId)
{
if (IsValid(strPrjConstraintId)) Value = strPrjConstraintId;
else
{
Value = null;
}
}
private static bool IsValid(string strPrjConstraintId)
{
if (string.IsNullOrEmpty(strPrjConstraintId) == true) return false;
if (strPrjConstraintId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PrjConstraintId_vPrjConstraint_Sim]类型的对象</returns>
public static implicit operator K_PrjConstraintId_vPrjConstraint_Sim(string value)
{
return new K_PrjConstraintId_vPrjConstraint_Sim(value);
}
}
 /// <summary>
 /// vPrjConstraint_Sim(vPrjConstraint_Sim)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvPrjConstraint_SimEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vPrjConstraint_Sim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PrjConstraintId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 6;
public static string[] _AttributeName = new string[] {"PrjConstraintId", "ConstraintName", "PrjId", "TabId", "ConstraintTypeId", "InUse"};

protected string mstrPrjConstraintId;    //约束表Id
protected string mstrConstraintName;    //约束名
protected string mstrPrjId;    //工程Id
protected string mstrTabId;    //表ID
protected string mstrConstraintTypeId;    //约束类型Id
protected bool mbolInUse;    //是否在用

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvPrjConstraint_SimEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PrjConstraintId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strPrjConstraintId">关键字:约束表Id</param>
public clsvPrjConstraint_SimEN(string strPrjConstraintId)
 {
strPrjConstraintId = strPrjConstraintId.Replace("'", "''");
if (strPrjConstraintId.Length > 8)
{
throw new Exception("在表:vPrjConstraint_Sim中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strPrjConstraintId)  ==  true)
{
throw new Exception("在表:vPrjConstraint_Sim中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPrjConstraintId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrPrjConstraintId = strPrjConstraintId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PrjConstraintId");
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
if (strAttributeName  ==  convPrjConstraint_Sim.PrjConstraintId)
{
return mstrPrjConstraintId;
}
else if (strAttributeName  ==  convPrjConstraint_Sim.ConstraintName)
{
return mstrConstraintName;
}
else if (strAttributeName  ==  convPrjConstraint_Sim.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convPrjConstraint_Sim.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  convPrjConstraint_Sim.ConstraintTypeId)
{
return mstrConstraintTypeId;
}
else if (strAttributeName  ==  convPrjConstraint_Sim.InUse)
{
return mbolInUse;
}
return null;
}
set
{
if (strAttributeName  ==  convPrjConstraint_Sim.PrjConstraintId)
{
mstrPrjConstraintId = value.ToString();
 AddUpdatedFld(convPrjConstraint_Sim.PrjConstraintId);
}
else if (strAttributeName  ==  convPrjConstraint_Sim.ConstraintName)
{
mstrConstraintName = value.ToString();
 AddUpdatedFld(convPrjConstraint_Sim.ConstraintName);
}
else if (strAttributeName  ==  convPrjConstraint_Sim.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convPrjConstraint_Sim.PrjId);
}
else if (strAttributeName  ==  convPrjConstraint_Sim.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(convPrjConstraint_Sim.TabId);
}
else if (strAttributeName  ==  convPrjConstraint_Sim.ConstraintTypeId)
{
mstrConstraintTypeId = value.ToString();
 AddUpdatedFld(convPrjConstraint_Sim.ConstraintTypeId);
}
else if (strAttributeName  ==  convPrjConstraint_Sim.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjConstraint_Sim.InUse);
}
}
}
public object this[int intIndex]
{
get
{
if (convPrjConstraint_Sim.PrjConstraintId  ==  _AttributeName[intIndex])
{
return mstrPrjConstraintId;
}
else if (convPrjConstraint_Sim.ConstraintName  ==  _AttributeName[intIndex])
{
return mstrConstraintName;
}
else if (convPrjConstraint_Sim.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convPrjConstraint_Sim.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (convPrjConstraint_Sim.ConstraintTypeId  ==  _AttributeName[intIndex])
{
return mstrConstraintTypeId;
}
else if (convPrjConstraint_Sim.InUse  ==  _AttributeName[intIndex])
{
return mbolInUse;
}
return null;
}
set
{
if (convPrjConstraint_Sim.PrjConstraintId  ==  _AttributeName[intIndex])
{
mstrPrjConstraintId = value.ToString();
 AddUpdatedFld(convPrjConstraint_Sim.PrjConstraintId);
}
else if (convPrjConstraint_Sim.ConstraintName  ==  _AttributeName[intIndex])
{
mstrConstraintName = value.ToString();
 AddUpdatedFld(convPrjConstraint_Sim.ConstraintName);
}
else if (convPrjConstraint_Sim.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convPrjConstraint_Sim.PrjId);
}
else if (convPrjConstraint_Sim.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(convPrjConstraint_Sim.TabId);
}
else if (convPrjConstraint_Sim.ConstraintTypeId  ==  _AttributeName[intIndex])
{
mstrConstraintTypeId = value.ToString();
 AddUpdatedFld(convPrjConstraint_Sim.ConstraintTypeId);
}
else if (convPrjConstraint_Sim.InUse  ==  _AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjConstraint_Sim.InUse);
}
}
}

/// <summary>
/// 约束表Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjConstraintId
{
get
{
return mstrPrjConstraintId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjConstraintId = value;
}
else
{
 mstrPrjConstraintId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjConstraint_Sim.PrjConstraintId);
}
}
/// <summary>
/// 约束名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ConstraintName
{
get
{
return mstrConstraintName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrConstraintName = value;
}
else
{
 mstrConstraintName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjConstraint_Sim.ConstraintName);
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
 AddUpdatedFld(convPrjConstraint_Sim.PrjId);
}
}
/// <summary>
/// 表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabId
{
get
{
return mstrTabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabId = value;
}
else
{
 mstrTabId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjConstraint_Sim.TabId);
}
}
/// <summary>
/// 约束类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ConstraintTypeId
{
get
{
return mstrConstraintTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrConstraintTypeId = value;
}
else
{
 mstrConstraintTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjConstraint_Sim.ConstraintTypeId);
}
}
/// <summary>
/// 是否在用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool InUse
{
get
{
return mbolInUse;
}
set
{
 mbolInUse = value;
//记录修改过的字段
 AddUpdatedFld(convPrjConstraint_Sim.InUse);
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
  return mstrPrjConstraintId;
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
  return mstrConstraintName;
 }
 }
}
 /// <summary>
 /// vPrjConstraint_Sim(vPrjConstraint_Sim)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convPrjConstraint_Sim
{
public const string _CurrTabName = "vPrjConstraint_Sim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PrjConstraintId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"PrjConstraintId", "ConstraintName", "PrjId", "TabId", "ConstraintTypeId", "InUse"};
//以下是属性变量


 /// <summary>
 /// 常量:"PrjConstraintId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjConstraintId = "PrjConstraintId";    //约束表Id

 /// <summary>
 /// 常量:"ConstraintName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConstraintName = "ConstraintName";    //约束名

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"TabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabId = "TabId";    //表ID

 /// <summary>
 /// 常量:"ConstraintTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConstraintTypeId = "ConstraintTypeId";    //约束类型Id

 /// <summary>
 /// 常量:"InUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InUse = "InUse";    //是否在用
}

}