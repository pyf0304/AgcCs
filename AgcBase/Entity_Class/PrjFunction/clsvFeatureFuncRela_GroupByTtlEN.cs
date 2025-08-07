
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFeatureFuncRela_GroupByTtlEN
 表名:vFeatureFuncRela_GroupByTtl(00050537)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:34:57
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
 /// 表vFeatureFuncRela_GroupByTtl的关键字(FeatureId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_FeatureId_vFeatureFuncRela_GroupByTtl
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strFeatureId">表关键字</param>
public K_FeatureId_vFeatureFuncRela_GroupByTtl(string strFeatureId)
{
if (IsValid(strFeatureId)) Value = strFeatureId;
else
{
Value = null;
}
}
private static bool IsValid(string strFeatureId)
{
if (string.IsNullOrEmpty(strFeatureId) == true) return false;
if (strFeatureId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_FeatureId_vFeatureFuncRela_GroupByTtl]类型的对象</returns>
public static implicit operator K_FeatureId_vFeatureFuncRela_GroupByTtl(string value)
{
return new K_FeatureId_vFeatureFuncRela_GroupByTtl(value);
}
}
 /// <summary>
 /// v功能函数关系_分类汇总(vFeatureFuncRela_GroupByTtl)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvFeatureFuncRela_GroupByTtlEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vFeatureFuncRela_GroupByTtl"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "FeatureId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 3;
public static string[] _AttributeName = new string[] {"FeatureId", "ApplicationTypeId", "FuncCount"};

protected string mstrFeatureId;    //功能Id
protected int mintApplicationTypeId;    //应用程序类型ID
protected int? mintFuncCount;    //函数数目

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvFeatureFuncRela_GroupByTtlEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FeatureId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strFeatureId">关键字:功能Id</param>
public clsvFeatureFuncRela_GroupByTtlEN(string strFeatureId)
 {
strFeatureId = strFeatureId.Replace("'", "''");
if (strFeatureId.Length > 4)
{
throw new Exception("在表:vFeatureFuncRela_GroupByTtl中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strFeatureId)  ==  true)
{
throw new Exception("在表:vFeatureFuncRela_GroupByTtl中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFeatureId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrFeatureId = strFeatureId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FeatureId");
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
if (strAttributeName  ==  convFeatureFuncRela_GroupByTtl.FeatureId)
{
return mstrFeatureId;
}
else if (strAttributeName  ==  convFeatureFuncRela_GroupByTtl.ApplicationTypeId)
{
return mintApplicationTypeId;
}
else if (strAttributeName  ==  convFeatureFuncRela_GroupByTtl.FuncCount)
{
return mintFuncCount;
}
return null;
}
set
{
if (strAttributeName  ==  convFeatureFuncRela_GroupByTtl.FeatureId)
{
mstrFeatureId = value.ToString();
 AddUpdatedFld(convFeatureFuncRela_GroupByTtl.FeatureId);
}
else if (strAttributeName  ==  convFeatureFuncRela_GroupByTtl.ApplicationTypeId)
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convFeatureFuncRela_GroupByTtl.ApplicationTypeId);
}
else if (strAttributeName  ==  convFeatureFuncRela_GroupByTtl.FuncCount)
{
mintFuncCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convFeatureFuncRela_GroupByTtl.FuncCount);
}
}
}
public object this[int intIndex]
{
get
{
if (convFeatureFuncRela_GroupByTtl.FeatureId  ==  _AttributeName[intIndex])
{
return mstrFeatureId;
}
else if (convFeatureFuncRela_GroupByTtl.ApplicationTypeId  ==  _AttributeName[intIndex])
{
return mintApplicationTypeId;
}
else if (convFeatureFuncRela_GroupByTtl.FuncCount  ==  _AttributeName[intIndex])
{
return mintFuncCount;
}
return null;
}
set
{
if (convFeatureFuncRela_GroupByTtl.FeatureId  ==  _AttributeName[intIndex])
{
mstrFeatureId = value.ToString();
 AddUpdatedFld(convFeatureFuncRela_GroupByTtl.FeatureId);
}
else if (convFeatureFuncRela_GroupByTtl.ApplicationTypeId  ==  _AttributeName[intIndex])
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convFeatureFuncRela_GroupByTtl.ApplicationTypeId);
}
else if (convFeatureFuncRela_GroupByTtl.FuncCount  ==  _AttributeName[intIndex])
{
mintFuncCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convFeatureFuncRela_GroupByTtl.FuncCount);
}
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
 AddUpdatedFld(convFeatureFuncRela_GroupByTtl.FeatureId);
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
 AddUpdatedFld(convFeatureFuncRela_GroupByTtl.ApplicationTypeId);
}
}
/// <summary>
/// 函数数目(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? FuncCount
{
get
{
return mintFuncCount;
}
set
{
 mintFuncCount = value;
//记录修改过的字段
 AddUpdatedFld(convFeatureFuncRela_GroupByTtl.FuncCount);
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
  return mstrFeatureId;
 }
 }
}
 /// <summary>
 /// v功能函数关系_分类汇总(vFeatureFuncRela_GroupByTtl)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convFeatureFuncRela_GroupByTtl
{
public const string _CurrTabName = "vFeatureFuncRela_GroupByTtl"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FeatureId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"FeatureId", "ApplicationTypeId", "FuncCount"};
//以下是属性变量


 /// <summary>
 /// 常量:"FeatureId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeatureId = "FeatureId";    //功能Id

 /// <summary>
 /// 常量:"ApplicationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeId = "ApplicationTypeId";    //应用程序类型ID

 /// <summary>
 /// 常量:"FuncCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncCount = "FuncCount";    //函数数目
}

}