
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSV_RelaTabTypeEN
 表名:SV_RelaTabType(00050248)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:16:15
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:Sql视图管理(SqlViewMan)
 框架-层名:实体层(CS)(EntityLayer)
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

namespace AGC.Entity
{
 /// <summary>
 /// 表SV_RelaTabType的关键字(SvRelaTabTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_SvRelaTabTypeId_SV_RelaTabType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strSvRelaTabTypeId">表关键字</param>
public K_SvRelaTabTypeId_SV_RelaTabType(string strSvRelaTabTypeId)
{
if (IsValid(strSvRelaTabTypeId)) Value = strSvRelaTabTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strSvRelaTabTypeId)
{
if (string.IsNullOrEmpty(strSvRelaTabTypeId) == true) return false;
if (strSvRelaTabTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_SvRelaTabTypeId_SV_RelaTabType]类型的对象</returns>
public static implicit operator K_SvRelaTabTypeId_SV_RelaTabType(string value)
{
return new K_SvRelaTabTypeId_SV_RelaTabType(value);
}
}
 /// <summary>
 /// Sql视图相关表类型(SV_RelaTabType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsSV_RelaTabTypeEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接，如果为空就使用系统默认的连接
public new const string _CurrTabName = "SV_RelaTabType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "SvRelaTabTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string WhereFormat = ""; //条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"SvRelaTabTypeId", "SvRelaTabTypeName", "Memo"};

protected string mstrSvRelaTabTypeId;    //Sql视图相关表类型Id
protected string mstrSvRelaTabTypeName;    //Sql视图相关表类型名
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsSV_RelaTabTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "SV_RelaTabType";
 lstKeyFldNames.Add("SvRelaTabTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strSvRelaTabTypeId">关键字:Sql视图相关表类型Id</param>
public clsSV_RelaTabTypeEN(string strSvRelaTabTypeId)
 {
strSvRelaTabTypeId = strSvRelaTabTypeId.Replace("'", "''");
if (strSvRelaTabTypeId.Length > 2)
{
throw new Exception("在表:SV_RelaTabType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strSvRelaTabTypeId)  ==  true)
{
throw new Exception("在表:SV_RelaTabType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strSvRelaTabTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrSvRelaTabTypeId = strSvRelaTabTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "SV_RelaTabType";
 lstKeyFldNames.Add("SvRelaTabTypeId");
 }

public static int AttributeCount
{
get
{
return mintAttributeCount;
}
}
public override object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  conSV_RelaTabType.SvRelaTabTypeId)
{
return mstrSvRelaTabTypeId;
}
else if (strAttributeName  ==  conSV_RelaTabType.SvRelaTabTypeName)
{
return mstrSvRelaTabTypeName;
}
else if (strAttributeName  ==  conSV_RelaTabType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conSV_RelaTabType.SvRelaTabTypeId)
{
mstrSvRelaTabTypeId = value.ToString();
 AddUpdatedFld(conSV_RelaTabType.SvRelaTabTypeId);
}
else if (strAttributeName  ==  conSV_RelaTabType.SvRelaTabTypeName)
{
mstrSvRelaTabTypeName = value.ToString();
 AddUpdatedFld(conSV_RelaTabType.SvRelaTabTypeName);
}
else if (strAttributeName  ==  conSV_RelaTabType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSV_RelaTabType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conSV_RelaTabType.SvRelaTabTypeId  ==  AttributeName[intIndex])
{
return mstrSvRelaTabTypeId;
}
else if (conSV_RelaTabType.SvRelaTabTypeName  ==  AttributeName[intIndex])
{
return mstrSvRelaTabTypeName;
}
else if (conSV_RelaTabType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conSV_RelaTabType.SvRelaTabTypeId  ==  AttributeName[intIndex])
{
mstrSvRelaTabTypeId = value.ToString();
 AddUpdatedFld(conSV_RelaTabType.SvRelaTabTypeId);
}
else if (conSV_RelaTabType.SvRelaTabTypeName  ==  AttributeName[intIndex])
{
mstrSvRelaTabTypeName = value.ToString();
 AddUpdatedFld(conSV_RelaTabType.SvRelaTabTypeName);
}
else if (conSV_RelaTabType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSV_RelaTabType.Memo);
}
}
}

/// <summary>
/// Sql视图相关表类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SvRelaTabTypeId
{
get
{
return mstrSvRelaTabTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSvRelaTabTypeId = value;
}
else
{
 mstrSvRelaTabTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSV_RelaTabType.SvRelaTabTypeId);
}
}
/// <summary>
/// Sql视图相关表类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SvRelaTabTypeName
{
get
{
return mstrSvRelaTabTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSvRelaTabTypeName = value;
}
else
{
 mstrSvRelaTabTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conSV_RelaTabType.SvRelaTabTypeName);
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
 AddUpdatedFld(conSV_RelaTabType.Memo);
}
}

/// <summary>
/// 获取关键字Id(keyId)
 /// (AutoGCLib.clsGeneCodeBase:GenGetKeyId)
/// </summary>
 public override string _KeyId
 {
 get
 {
  return mstrSvRelaTabTypeId;
 }
 }

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrSvRelaTabTypeName;
 }
 }
}
 /// <summary>
 /// Sql视图相关表类型(SV_RelaTabType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conSV_RelaTabType
{
public new const string _CurrTabName = "SV_RelaTabType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "SvRelaTabTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"SvRelaTabTypeId", "SvRelaTabTypeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"SvRelaTabTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SvRelaTabTypeId = "SvRelaTabTypeId";    //Sql视图相关表类型Id

 /// <summary>
 /// 常量:"SvRelaTabTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SvRelaTabTypeName = "SvRelaTabTypeName";    //Sql视图相关表类型名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}