
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFunctionTemplateRela_SimEN
 表名:vFunctionTemplateRela_Sim(00050604)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:00:33
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
 /// 表vFunctionTemplateRela_Sim的关键字(FunctionTemplateId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_FunctionTemplateId_vFunctionTemplateRela_Sim
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strFunctionTemplateId">表关键字</param>
public K_FunctionTemplateId_vFunctionTemplateRela_Sim(string strFunctionTemplateId)
{
if (IsValid(strFunctionTemplateId)) Value = strFunctionTemplateId;
else
{
Value = null;
}
}
private static bool IsValid(string strFunctionTemplateId)
{
if (string.IsNullOrEmpty(strFunctionTemplateId) == true) return false;
if (strFunctionTemplateId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_FunctionTemplateId_vFunctionTemplateRela_Sim]类型的对象</returns>
public static implicit operator K_FunctionTemplateId_vFunctionTemplateRela_Sim(string value)
{
return new K_FunctionTemplateId_vFunctionTemplateRela_Sim(value);
}
}
 /// <summary>
 /// v函数模板关系_Sim(vFunctionTemplateRela_Sim)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvFunctionTemplateRela_SimEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vFunctionTemplateRela_Sim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "FunctionTemplateId,FuncId4GC"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 6;
public static string[] _AttributeName = new string[] {"FunctionTemplateId", "FuncId4GC", "CodeTypeId", "RegionTypeId", "SqlDsTypeId", "IsGeneCode"};

protected string mstrFunctionTemplateId;    //函数模板Id
protected string mstrFuncId4GC;    //函数ID
protected string mstrCodeTypeId;    //代码类型Id
protected string mstrRegionTypeId;    //区域类型Id
protected string mstrSqlDsTypeId;    //数据源类型Id
protected bool mbolIsGeneCode;    //是否生成代码

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvFunctionTemplateRela_SimEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FunctionTemplateId");
 lstKeyFldNames.Add("FuncId4GC");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strFunctionTemplateId">关键字:函数模板Id</param>
public clsvFunctionTemplateRela_SimEN(string strFunctionTemplateId , string strFuncId4GC)
 {
strFunctionTemplateId = strFunctionTemplateId.Replace("'", "''");
if (strFunctionTemplateId.Length > 4)
{
throw new Exception("在表:vFunctionTemplateRela_Sim中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strFunctionTemplateId)  ==  true)
{
throw new Exception("在表:vFunctionTemplateRela_Sim中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFunctionTemplateId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrFunctionTemplateId = strFunctionTemplateId;
this.mstrFuncId4GC = strFuncId4GC;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FunctionTemplateId");
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
if (strAttributeName  ==  convFunctionTemplateRela_Sim.FunctionTemplateId)
{
return mstrFunctionTemplateId;
}
else if (strAttributeName  ==  convFunctionTemplateRela_Sim.FuncId4GC)
{
return mstrFuncId4GC;
}
else if (strAttributeName  ==  convFunctionTemplateRela_Sim.CodeTypeId)
{
return mstrCodeTypeId;
}
else if (strAttributeName  ==  convFunctionTemplateRela_Sim.RegionTypeId)
{
return mstrRegionTypeId;
}
else if (strAttributeName  ==  convFunctionTemplateRela_Sim.SqlDsTypeId)
{
return mstrSqlDsTypeId;
}
else if (strAttributeName  ==  convFunctionTemplateRela_Sim.IsGeneCode)
{
return mbolIsGeneCode;
}
return null;
}
set
{
if (strAttributeName  ==  convFunctionTemplateRela_Sim.FunctionTemplateId)
{
mstrFunctionTemplateId = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela_Sim.FunctionTemplateId);
}
else if (strAttributeName  ==  convFunctionTemplateRela_Sim.FuncId4GC)
{
mstrFuncId4GC = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela_Sim.FuncId4GC);
}
else if (strAttributeName  ==  convFunctionTemplateRela_Sim.CodeTypeId)
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela_Sim.CodeTypeId);
}
else if (strAttributeName  ==  convFunctionTemplateRela_Sim.RegionTypeId)
{
mstrRegionTypeId = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela_Sim.RegionTypeId);
}
else if (strAttributeName  ==  convFunctionTemplateRela_Sim.SqlDsTypeId)
{
mstrSqlDsTypeId = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela_Sim.SqlDsTypeId);
}
else if (strAttributeName  ==  convFunctionTemplateRela_Sim.IsGeneCode)
{
mbolIsGeneCode = TransNullToBool(value.ToString());
 AddUpdatedFld(convFunctionTemplateRela_Sim.IsGeneCode);
}
}
}
public object this[int intIndex]
{
get
{
if (convFunctionTemplateRela_Sim.FunctionTemplateId  ==  _AttributeName[intIndex])
{
return mstrFunctionTemplateId;
}
else if (convFunctionTemplateRela_Sim.FuncId4GC  ==  _AttributeName[intIndex])
{
return mstrFuncId4GC;
}
else if (convFunctionTemplateRela_Sim.CodeTypeId  ==  _AttributeName[intIndex])
{
return mstrCodeTypeId;
}
else if (convFunctionTemplateRela_Sim.RegionTypeId  ==  _AttributeName[intIndex])
{
return mstrRegionTypeId;
}
else if (convFunctionTemplateRela_Sim.SqlDsTypeId  ==  _AttributeName[intIndex])
{
return mstrSqlDsTypeId;
}
else if (convFunctionTemplateRela_Sim.IsGeneCode  ==  _AttributeName[intIndex])
{
return mbolIsGeneCode;
}
return null;
}
set
{
if (convFunctionTemplateRela_Sim.FunctionTemplateId  ==  _AttributeName[intIndex])
{
mstrFunctionTemplateId = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela_Sim.FunctionTemplateId);
}
else if (convFunctionTemplateRela_Sim.FuncId4GC  ==  _AttributeName[intIndex])
{
mstrFuncId4GC = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela_Sim.FuncId4GC);
}
else if (convFunctionTemplateRela_Sim.CodeTypeId  ==  _AttributeName[intIndex])
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela_Sim.CodeTypeId);
}
else if (convFunctionTemplateRela_Sim.RegionTypeId  ==  _AttributeName[intIndex])
{
mstrRegionTypeId = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela_Sim.RegionTypeId);
}
else if (convFunctionTemplateRela_Sim.SqlDsTypeId  ==  _AttributeName[intIndex])
{
mstrSqlDsTypeId = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela_Sim.SqlDsTypeId);
}
else if (convFunctionTemplateRela_Sim.IsGeneCode  ==  _AttributeName[intIndex])
{
mbolIsGeneCode = TransNullToBool(value.ToString());
 AddUpdatedFld(convFunctionTemplateRela_Sim.IsGeneCode);
}
}
}

/// <summary>
/// 函数模板Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FunctionTemplateId
{
get
{
return mstrFunctionTemplateId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFunctionTemplateId = value;
}
else
{
 mstrFunctionTemplateId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunctionTemplateRela_Sim.FunctionTemplateId);
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
 AddUpdatedFld(convFunctionTemplateRela_Sim.FuncId4GC);
}
}
/// <summary>
/// 代码类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTypeId
{
get
{
return mstrCodeTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTypeId = value;
}
else
{
 mstrCodeTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunctionTemplateRela_Sim.CodeTypeId);
}
}
/// <summary>
/// 区域类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RegionTypeId
{
get
{
return mstrRegionTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRegionTypeId = value;
}
else
{
 mstrRegionTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunctionTemplateRela_Sim.RegionTypeId);
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
 AddUpdatedFld(convFunctionTemplateRela_Sim.SqlDsTypeId);
}
}
/// <summary>
/// 是否生成代码(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsGeneCode
{
get
{
return mbolIsGeneCode;
}
set
{
 mbolIsGeneCode = value;
//记录修改过的字段
 AddUpdatedFld(convFunctionTemplateRela_Sim.IsGeneCode);
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
  return mstrFunctionTemplateId;
 }
 }
}
 /// <summary>
 /// v函数模板关系_Sim(vFunctionTemplateRela_Sim)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convFunctionTemplateRela_Sim
{
public const string _CurrTabName = "vFunctionTemplateRela_Sim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FunctionTemplateId,FuncId4GC"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"FunctionTemplateId", "FuncId4GC", "CodeTypeId", "RegionTypeId", "SqlDsTypeId", "IsGeneCode"};
//以下是属性变量


 /// <summary>
 /// 常量:"FunctionTemplateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FunctionTemplateId = "FunctionTemplateId";    //函数模板Id

 /// <summary>
 /// 常量:"FuncId4GC"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncId4GC = "FuncId4GC";    //函数ID

 /// <summary>
 /// 常量:"CodeTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTypeId = "CodeTypeId";    //代码类型Id

 /// <summary>
 /// 常量:"RegionTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RegionTypeId = "RegionTypeId";    //区域类型Id

 /// <summary>
 /// 常量:"SqlDsTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SqlDsTypeId = "SqlDsTypeId";    //数据源类型Id

 /// <summary>
 /// 常量:"IsGeneCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsGeneCode = "IsGeneCode";    //是否生成代码
}

}