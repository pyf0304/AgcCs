
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFunction4GeneCode_SimEN
 表名:vFunction4GeneCode_Sim(00050605)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:03:22
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
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
 /// 表vFunction4GeneCode_Sim的关键字(FuncId4GC)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_FuncId4GC_vFunction4GeneCode_Sim
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strFuncId4GC">表关键字</param>
public K_FuncId4GC_vFunction4GeneCode_Sim(string strFuncId4GC)
{
if (IsValid(strFuncId4GC)) Value = strFuncId4GC;
else
{
Value = null;
}
}
private static bool IsValid(string strFuncId4GC)
{
if (string.IsNullOrEmpty(strFuncId4GC) == true) return false;
if (strFuncId4GC.Length != 10) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_FuncId4GC_vFunction4GeneCode_Sim]类型的对象</returns>
public static implicit operator K_FuncId4GC_vFunction4GeneCode_Sim(string value)
{
return new K_FuncId4GC_vFunction4GeneCode_Sim(value);
}
}
 /// <summary>
 /// v函数4GC_Sim(vFunction4GeneCode_Sim)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvFunction4GeneCode_SimEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vFunction4GeneCode_Sim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "FuncId4GC"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = "UsedTimes>0"; //前台条件格式串
protected const int _AttributeCount = 11;
public static string[] _AttributeName = new string[] {"FuncId4GC", "FuncName", "FuncId4Code", "SqlDsTypeId", "FeatureId", "InUse", "FuncGCTypeId", "TemplateNum", "ProgLangTypeId", "FuncCodeTypeId", "UsedTimes"};

protected string mstrFuncId4GC;    //函数ID
protected string mstrFuncName;    //函数名
protected string mstrFuncId4Code;    //函数Id4Code
protected string mstrSqlDsTypeId;    //数据源类型Id
protected string mstrFeatureId;    //功能Id
protected bool mbolInUse;    //是否在用
protected string mstrFuncGCTypeId;    //函数生成代码类型Id
protected int? mintTemplateNum;    //TemplateNum
protected string mstrProgLangTypeId;    //编程语言类型Id
protected string mstrFuncCodeTypeId;    //函数代码类型Id
protected int? mintUsedTimes;    //使用次数

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvFunction4GeneCode_SimEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FuncId4GC");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strFuncId4GC">关键字:函数ID</param>
public clsvFunction4GeneCode_SimEN(string strFuncId4GC)
 {
strFuncId4GC = strFuncId4GC.Replace("'", "''");
if (strFuncId4GC.Length > 10)
{
throw new Exception("在表:vFunction4GeneCode_Sim中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strFuncId4GC)  ==  true)
{
throw new Exception("在表:vFunction4GeneCode_Sim中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFuncId4GC);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrFuncId4GC = strFuncId4GC;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FuncId4GC");
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
if (strAttributeName  ==  convFunction4GeneCode_Sim.FuncId4GC)
{
return mstrFuncId4GC;
}
else if (strAttributeName  ==  convFunction4GeneCode_Sim.FuncName)
{
return mstrFuncName;
}
else if (strAttributeName  ==  convFunction4GeneCode_Sim.FuncId4Code)
{
return mstrFuncId4Code;
}
else if (strAttributeName  ==  convFunction4GeneCode_Sim.SqlDsTypeId)
{
return mstrSqlDsTypeId;
}
else if (strAttributeName  ==  convFunction4GeneCode_Sim.FeatureId)
{
return mstrFeatureId;
}
else if (strAttributeName  ==  convFunction4GeneCode_Sim.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  convFunction4GeneCode_Sim.FuncGCTypeId)
{
return mstrFuncGCTypeId;
}
else if (strAttributeName  ==  convFunction4GeneCode_Sim.TemplateNum)
{
return mintTemplateNum;
}
else if (strAttributeName  ==  convFunction4GeneCode_Sim.ProgLangTypeId)
{
return mstrProgLangTypeId;
}
else if (strAttributeName  ==  convFunction4GeneCode_Sim.FuncCodeTypeId)
{
return mstrFuncCodeTypeId;
}
else if (strAttributeName  ==  convFunction4GeneCode_Sim.UsedTimes)
{
return mintUsedTimes;
}
return null;
}
set
{
if (strAttributeName  ==  convFunction4GeneCode_Sim.FuncId4GC)
{
mstrFuncId4GC = value.ToString();
 AddUpdatedFld(convFunction4GeneCode_Sim.FuncId4GC);
}
else if (strAttributeName  ==  convFunction4GeneCode_Sim.FuncName)
{
mstrFuncName = value.ToString();
 AddUpdatedFld(convFunction4GeneCode_Sim.FuncName);
}
else if (strAttributeName  ==  convFunction4GeneCode_Sim.FuncId4Code)
{
mstrFuncId4Code = value.ToString();
 AddUpdatedFld(convFunction4GeneCode_Sim.FuncId4Code);
}
else if (strAttributeName  ==  convFunction4GeneCode_Sim.SqlDsTypeId)
{
mstrSqlDsTypeId = value.ToString();
 AddUpdatedFld(convFunction4GeneCode_Sim.SqlDsTypeId);
}
else if (strAttributeName  ==  convFunction4GeneCode_Sim.FeatureId)
{
mstrFeatureId = value.ToString();
 AddUpdatedFld(convFunction4GeneCode_Sim.FeatureId);
}
else if (strAttributeName  ==  convFunction4GeneCode_Sim.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convFunction4GeneCode_Sim.InUse);
}
else if (strAttributeName  ==  convFunction4GeneCode_Sim.FuncGCTypeId)
{
mstrFuncGCTypeId = value.ToString();
 AddUpdatedFld(convFunction4GeneCode_Sim.FuncGCTypeId);
}
else if (strAttributeName  ==  convFunction4GeneCode_Sim.TemplateNum)
{
mintTemplateNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFunction4GeneCode_Sim.TemplateNum);
}
else if (strAttributeName  ==  convFunction4GeneCode_Sim.ProgLangTypeId)
{
mstrProgLangTypeId = value.ToString();
 AddUpdatedFld(convFunction4GeneCode_Sim.ProgLangTypeId);
}
else if (strAttributeName  ==  convFunction4GeneCode_Sim.FuncCodeTypeId)
{
mstrFuncCodeTypeId = value.ToString();
 AddUpdatedFld(convFunction4GeneCode_Sim.FuncCodeTypeId);
}
else if (strAttributeName  ==  convFunction4GeneCode_Sim.UsedTimes)
{
mintUsedTimes = TransNullToInt(value.ToString());
 AddUpdatedFld(convFunction4GeneCode_Sim.UsedTimes);
}
}
}
public object this[int intIndex]
{
get
{
if (convFunction4GeneCode_Sim.FuncId4GC  ==  _AttributeName[intIndex])
{
return mstrFuncId4GC;
}
else if (convFunction4GeneCode_Sim.FuncName  ==  _AttributeName[intIndex])
{
return mstrFuncName;
}
else if (convFunction4GeneCode_Sim.FuncId4Code  ==  _AttributeName[intIndex])
{
return mstrFuncId4Code;
}
else if (convFunction4GeneCode_Sim.SqlDsTypeId  ==  _AttributeName[intIndex])
{
return mstrSqlDsTypeId;
}
else if (convFunction4GeneCode_Sim.FeatureId  ==  _AttributeName[intIndex])
{
return mstrFeatureId;
}
else if (convFunction4GeneCode_Sim.InUse  ==  _AttributeName[intIndex])
{
return mbolInUse;
}
else if (convFunction4GeneCode_Sim.FuncGCTypeId  ==  _AttributeName[intIndex])
{
return mstrFuncGCTypeId;
}
else if (convFunction4GeneCode_Sim.TemplateNum  ==  _AttributeName[intIndex])
{
return mintTemplateNum;
}
else if (convFunction4GeneCode_Sim.ProgLangTypeId  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeId;
}
else if (convFunction4GeneCode_Sim.FuncCodeTypeId  ==  _AttributeName[intIndex])
{
return mstrFuncCodeTypeId;
}
else if (convFunction4GeneCode_Sim.UsedTimes  ==  _AttributeName[intIndex])
{
return mintUsedTimes;
}
return null;
}
set
{
if (convFunction4GeneCode_Sim.FuncId4GC  ==  _AttributeName[intIndex])
{
mstrFuncId4GC = value.ToString();
 AddUpdatedFld(convFunction4GeneCode_Sim.FuncId4GC);
}
else if (convFunction4GeneCode_Sim.FuncName  ==  _AttributeName[intIndex])
{
mstrFuncName = value.ToString();
 AddUpdatedFld(convFunction4GeneCode_Sim.FuncName);
}
else if (convFunction4GeneCode_Sim.FuncId4Code  ==  _AttributeName[intIndex])
{
mstrFuncId4Code = value.ToString();
 AddUpdatedFld(convFunction4GeneCode_Sim.FuncId4Code);
}
else if (convFunction4GeneCode_Sim.SqlDsTypeId  ==  _AttributeName[intIndex])
{
mstrSqlDsTypeId = value.ToString();
 AddUpdatedFld(convFunction4GeneCode_Sim.SqlDsTypeId);
}
else if (convFunction4GeneCode_Sim.FeatureId  ==  _AttributeName[intIndex])
{
mstrFeatureId = value.ToString();
 AddUpdatedFld(convFunction4GeneCode_Sim.FeatureId);
}
else if (convFunction4GeneCode_Sim.InUse  ==  _AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convFunction4GeneCode_Sim.InUse);
}
else if (convFunction4GeneCode_Sim.FuncGCTypeId  ==  _AttributeName[intIndex])
{
mstrFuncGCTypeId = value.ToString();
 AddUpdatedFld(convFunction4GeneCode_Sim.FuncGCTypeId);
}
else if (convFunction4GeneCode_Sim.TemplateNum  ==  _AttributeName[intIndex])
{
mintTemplateNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFunction4GeneCode_Sim.TemplateNum);
}
else if (convFunction4GeneCode_Sim.ProgLangTypeId  ==  _AttributeName[intIndex])
{
mstrProgLangTypeId = value.ToString();
 AddUpdatedFld(convFunction4GeneCode_Sim.ProgLangTypeId);
}
else if (convFunction4GeneCode_Sim.FuncCodeTypeId  ==  _AttributeName[intIndex])
{
mstrFuncCodeTypeId = value.ToString();
 AddUpdatedFld(convFunction4GeneCode_Sim.FuncCodeTypeId);
}
else if (convFunction4GeneCode_Sim.UsedTimes  ==  _AttributeName[intIndex])
{
mintUsedTimes = TransNullToInt(value.ToString());
 AddUpdatedFld(convFunction4GeneCode_Sim.UsedTimes);
}
}
}

/// <summary>
/// 函数ID(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncId4GC
{
get
{
return mstrFuncId4GC;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncId4GC = value;
}
else
{
 mstrFuncId4GC = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunction4GeneCode_Sim.FuncId4GC);
}
}
/// <summary>
/// 函数名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncName
{
get
{
return mstrFuncName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncName = value;
}
else
{
 mstrFuncName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunction4GeneCode_Sim.FuncName);
}
}
/// <summary>
/// 函数Id4Code(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncId4Code
{
get
{
return mstrFuncId4Code;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncId4Code = value;
}
else
{
 mstrFuncId4Code = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunction4GeneCode_Sim.FuncId4Code);
}
}
/// <summary>
/// 数据源类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SqlDsTypeId
{
get
{
return mstrSqlDsTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSqlDsTypeId = value;
}
else
{
 mstrSqlDsTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunction4GeneCode_Sim.SqlDsTypeId);
}
}
/// <summary>
/// 功能Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FeatureId
{
get
{
return mstrFeatureId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFeatureId = value;
}
else
{
 mstrFeatureId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunction4GeneCode_Sim.FeatureId);
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
 AddUpdatedFld(convFunction4GeneCode_Sim.InUse);
}
}
/// <summary>
/// 函数生成代码类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncGCTypeId
{
get
{
return mstrFuncGCTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncGCTypeId = value;
}
else
{
 mstrFuncGCTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunction4GeneCode_Sim.FuncGCTypeId);
}
}
/// <summary>
/// TemplateNum(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? TemplateNum
{
get
{
return mintTemplateNum;
}
set
{
 mintTemplateNum = value;
//记录修改过的字段
 AddUpdatedFld(convFunction4GeneCode_Sim.TemplateNum);
}
}
/// <summary>
/// 编程语言类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLangTypeId
{
get
{
return mstrProgLangTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLangTypeId = value;
}
else
{
 mstrProgLangTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunction4GeneCode_Sim.ProgLangTypeId);
}
}
/// <summary>
/// 函数代码类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncCodeTypeId
{
get
{
return mstrFuncCodeTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncCodeTypeId = value;
}
else
{
 mstrFuncCodeTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunction4GeneCode_Sim.FuncCodeTypeId);
}
}
/// <summary>
/// 使用次数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? UsedTimes
{
get
{
return mintUsedTimes;
}
set
{
 mintUsedTimes = value;
//记录修改过的字段
 AddUpdatedFld(convFunction4GeneCode_Sim.UsedTimes);
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
  return mstrFuncId4GC;
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
  return mstrFuncName;
 }
 }
}
 /// <summary>
 /// v函数4GC_Sim(vFunction4GeneCode_Sim)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convFunction4GeneCode_Sim
{
public const string _CurrTabName = "vFunction4GeneCode_Sim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FuncId4GC"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"FuncId4GC", "FuncName", "FuncId4Code", "SqlDsTypeId", "FeatureId", "InUse", "FuncGCTypeId", "TemplateNum", "ProgLangTypeId", "FuncCodeTypeId", "UsedTimes"};
//以下是属性变量


 /// <summary>
 /// 常量:"FuncId4GC"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncId4GC = "FuncId4GC";    //函数ID

 /// <summary>
 /// 常量:"FuncName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncName = "FuncName";    //函数名

 /// <summary>
 /// 常量:"FuncId4Code"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncId4Code = "FuncId4Code";    //函数Id4Code

 /// <summary>
 /// 常量:"SqlDsTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SqlDsTypeId = "SqlDsTypeId";    //数据源类型Id

 /// <summary>
 /// 常量:"FeatureId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeatureId = "FeatureId";    //功能Id

 /// <summary>
 /// 常量:"InUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InUse = "InUse";    //是否在用

 /// <summary>
 /// 常量:"FuncGCTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncGCTypeId = "FuncGCTypeId";    //函数生成代码类型Id

 /// <summary>
 /// 常量:"TemplateNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TemplateNum = "TemplateNum";    //TemplateNum

 /// <summary>
 /// 常量:"ProgLangTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeId = "ProgLangTypeId";    //编程语言类型Id

 /// <summary>
 /// 常量:"FuncCodeTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncCodeTypeId = "FuncCodeTypeId";    //函数代码类型Id

 /// <summary>
 /// 常量:"UsedTimes"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UsedTimes = "UsedTimes";    //使用次数
}

}