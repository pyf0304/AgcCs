
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFunction4Code_SimEN
 表名:vFunction4Code_Sim(00050602)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:03:25
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
 /// 表vFunction4Code_Sim的关键字(FuncId4Code)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_FuncId4Code_vFunction4Code_Sim
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strFuncId4Code">表关键字</param>
public K_FuncId4Code_vFunction4Code_Sim(string strFuncId4Code)
{
if (IsValid(strFuncId4Code)) Value = strFuncId4Code;
else
{
Value = null;
}
}
private static bool IsValid(string strFuncId4Code)
{
if (string.IsNullOrEmpty(strFuncId4Code) == true) return false;
if (strFuncId4Code.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_FuncId4Code_vFunction4Code_Sim]类型的对象</returns>
public static implicit operator K_FuncId4Code_vFunction4Code_Sim(string value)
{
return new K_FuncId4Code_vFunction4Code_Sim(value);
}
}
 /// <summary>
 /// v函数4Code_Sim(vFunction4Code_Sim)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvFunction4Code_SimEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vFunction4Code_Sim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "FuncId4Code"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = "UsedTimes>0"; //前台条件格式串
protected const int _AttributeCount = 8;
public static string[] _AttributeName = new string[] {"FuncId4Code", "FuncName4Code", "FuncCHName4Code", "FuncGCTypeId", "ApplicationTypeId", "FuncPurposeId", "FuncTypeId", "UsedTimes"};

protected string mstrFuncId4Code;    //函数Id4Code
protected string mstrFuncName4Code;    //函数名4Code
protected string mstrFuncCHName4Code;    //函数中文名4Code
protected string mstrFuncGCTypeId;    //函数生成代码类型Id
protected int mintApplicationTypeId;    //应用程序类型ID
protected string mstrFuncPurposeId;    //函数用途Id
protected string mstrFuncTypeId;    //函数类型Id
protected int? mintUsedTimes;    //使用次数

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvFunction4Code_SimEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FuncId4Code");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strFuncId4Code">关键字:函数Id4Code</param>
public clsvFunction4Code_SimEN(string strFuncId4Code)
 {
strFuncId4Code = strFuncId4Code.Replace("'", "''");
if (strFuncId4Code.Length > 8)
{
throw new Exception("在表:vFunction4Code_Sim中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strFuncId4Code)  ==  true)
{
throw new Exception("在表:vFunction4Code_Sim中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFuncId4Code);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrFuncId4Code = strFuncId4Code;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FuncId4Code");
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
if (strAttributeName  ==  convFunction4Code_Sim.FuncId4Code)
{
return mstrFuncId4Code;
}
else if (strAttributeName  ==  convFunction4Code_Sim.FuncName4Code)
{
return mstrFuncName4Code;
}
else if (strAttributeName  ==  convFunction4Code_Sim.FuncCHName4Code)
{
return mstrFuncCHName4Code;
}
else if (strAttributeName  ==  convFunction4Code_Sim.FuncGCTypeId)
{
return mstrFuncGCTypeId;
}
else if (strAttributeName  ==  convFunction4Code_Sim.ApplicationTypeId)
{
return mintApplicationTypeId;
}
else if (strAttributeName  ==  convFunction4Code_Sim.FuncPurposeId)
{
return mstrFuncPurposeId;
}
else if (strAttributeName  ==  convFunction4Code_Sim.FuncTypeId)
{
return mstrFuncTypeId;
}
else if (strAttributeName  ==  convFunction4Code_Sim.UsedTimes)
{
return mintUsedTimes;
}
return null;
}
set
{
if (strAttributeName  ==  convFunction4Code_Sim.FuncId4Code)
{
mstrFuncId4Code = value.ToString();
 AddUpdatedFld(convFunction4Code_Sim.FuncId4Code);
}
else if (strAttributeName  ==  convFunction4Code_Sim.FuncName4Code)
{
mstrFuncName4Code = value.ToString();
 AddUpdatedFld(convFunction4Code_Sim.FuncName4Code);
}
else if (strAttributeName  ==  convFunction4Code_Sim.FuncCHName4Code)
{
mstrFuncCHName4Code = value.ToString();
 AddUpdatedFld(convFunction4Code_Sim.FuncCHName4Code);
}
else if (strAttributeName  ==  convFunction4Code_Sim.FuncGCTypeId)
{
mstrFuncGCTypeId = value.ToString();
 AddUpdatedFld(convFunction4Code_Sim.FuncGCTypeId);
}
else if (strAttributeName  ==  convFunction4Code_Sim.ApplicationTypeId)
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convFunction4Code_Sim.ApplicationTypeId);
}
else if (strAttributeName  ==  convFunction4Code_Sim.FuncPurposeId)
{
mstrFuncPurposeId = value.ToString();
 AddUpdatedFld(convFunction4Code_Sim.FuncPurposeId);
}
else if (strAttributeName  ==  convFunction4Code_Sim.FuncTypeId)
{
mstrFuncTypeId = value.ToString();
 AddUpdatedFld(convFunction4Code_Sim.FuncTypeId);
}
else if (strAttributeName  ==  convFunction4Code_Sim.UsedTimes)
{
mintUsedTimes = TransNullToInt(value.ToString());
 AddUpdatedFld(convFunction4Code_Sim.UsedTimes);
}
}
}
public object this[int intIndex]
{
get
{
if (convFunction4Code_Sim.FuncId4Code  ==  _AttributeName[intIndex])
{
return mstrFuncId4Code;
}
else if (convFunction4Code_Sim.FuncName4Code  ==  _AttributeName[intIndex])
{
return mstrFuncName4Code;
}
else if (convFunction4Code_Sim.FuncCHName4Code  ==  _AttributeName[intIndex])
{
return mstrFuncCHName4Code;
}
else if (convFunction4Code_Sim.FuncGCTypeId  ==  _AttributeName[intIndex])
{
return mstrFuncGCTypeId;
}
else if (convFunction4Code_Sim.ApplicationTypeId  ==  _AttributeName[intIndex])
{
return mintApplicationTypeId;
}
else if (convFunction4Code_Sim.FuncPurposeId  ==  _AttributeName[intIndex])
{
return mstrFuncPurposeId;
}
else if (convFunction4Code_Sim.FuncTypeId  ==  _AttributeName[intIndex])
{
return mstrFuncTypeId;
}
else if (convFunction4Code_Sim.UsedTimes  ==  _AttributeName[intIndex])
{
return mintUsedTimes;
}
return null;
}
set
{
if (convFunction4Code_Sim.FuncId4Code  ==  _AttributeName[intIndex])
{
mstrFuncId4Code = value.ToString();
 AddUpdatedFld(convFunction4Code_Sim.FuncId4Code);
}
else if (convFunction4Code_Sim.FuncName4Code  ==  _AttributeName[intIndex])
{
mstrFuncName4Code = value.ToString();
 AddUpdatedFld(convFunction4Code_Sim.FuncName4Code);
}
else if (convFunction4Code_Sim.FuncCHName4Code  ==  _AttributeName[intIndex])
{
mstrFuncCHName4Code = value.ToString();
 AddUpdatedFld(convFunction4Code_Sim.FuncCHName4Code);
}
else if (convFunction4Code_Sim.FuncGCTypeId  ==  _AttributeName[intIndex])
{
mstrFuncGCTypeId = value.ToString();
 AddUpdatedFld(convFunction4Code_Sim.FuncGCTypeId);
}
else if (convFunction4Code_Sim.ApplicationTypeId  ==  _AttributeName[intIndex])
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convFunction4Code_Sim.ApplicationTypeId);
}
else if (convFunction4Code_Sim.FuncPurposeId  ==  _AttributeName[intIndex])
{
mstrFuncPurposeId = value.ToString();
 AddUpdatedFld(convFunction4Code_Sim.FuncPurposeId);
}
else if (convFunction4Code_Sim.FuncTypeId  ==  _AttributeName[intIndex])
{
mstrFuncTypeId = value.ToString();
 AddUpdatedFld(convFunction4Code_Sim.FuncTypeId);
}
else if (convFunction4Code_Sim.UsedTimes  ==  _AttributeName[intIndex])
{
mintUsedTimes = TransNullToInt(value.ToString());
 AddUpdatedFld(convFunction4Code_Sim.UsedTimes);
}
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
 AddUpdatedFld(convFunction4Code_Sim.FuncId4Code);
}
}
/// <summary>
/// 函数名4Code(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncName4Code
{
get
{
return mstrFuncName4Code;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncName4Code = value;
}
else
{
 mstrFuncName4Code = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunction4Code_Sim.FuncName4Code);
}
}
/// <summary>
/// 函数中文名4Code(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncCHName4Code
{
get
{
return mstrFuncCHName4Code;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncCHName4Code = value;
}
else
{
 mstrFuncCHName4Code = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunction4Code_Sim.FuncCHName4Code);
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
 AddUpdatedFld(convFunction4Code_Sim.FuncGCTypeId);
}
}
/// <summary>
/// 应用程序类型ID(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int ApplicationTypeId
{
get
{
return mintApplicationTypeId;
}
set
{
 mintApplicationTypeId = value;
//记录修改过的字段
 AddUpdatedFld(convFunction4Code_Sim.ApplicationTypeId);
}
}
/// <summary>
/// 函数用途Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncPurposeId
{
get
{
return mstrFuncPurposeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncPurposeId = value;
}
else
{
 mstrFuncPurposeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunction4Code_Sim.FuncPurposeId);
}
}
/// <summary>
/// 函数类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncTypeId
{
get
{
return mstrFuncTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncTypeId = value;
}
else
{
 mstrFuncTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunction4Code_Sim.FuncTypeId);
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
 AddUpdatedFld(convFunction4Code_Sim.UsedTimes);
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
  return mstrFuncId4Code;
 }
 }
}
 /// <summary>
 /// v函数4Code_Sim(vFunction4Code_Sim)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convFunction4Code_Sim
{
public const string _CurrTabName = "vFunction4Code_Sim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FuncId4Code"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"FuncId4Code", "FuncName4Code", "FuncCHName4Code", "FuncGCTypeId", "ApplicationTypeId", "FuncPurposeId", "FuncTypeId", "UsedTimes"};
//以下是属性变量


 /// <summary>
 /// 常量:"FuncId4Code"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncId4Code = "FuncId4Code";    //函数Id4Code

 /// <summary>
 /// 常量:"FuncName4Code"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncName4Code = "FuncName4Code";    //函数名4Code

 /// <summary>
 /// 常量:"FuncCHName4Code"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncCHName4Code = "FuncCHName4Code";    //函数中文名4Code

 /// <summary>
 /// 常量:"FuncGCTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncGCTypeId = "FuncGCTypeId";    //函数生成代码类型Id

 /// <summary>
 /// 常量:"ApplicationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeId = "ApplicationTypeId";    //应用程序类型ID

 /// <summary>
 /// 常量:"FuncPurposeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncPurposeId = "FuncPurposeId";    //函数用途Id

 /// <summary>
 /// 常量:"FuncTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncTypeId = "FuncTypeId";    //函数类型Id

 /// <summary>
 /// 常量:"UsedTimes"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UsedTimes = "UsedTimes";    //使用次数
}

}