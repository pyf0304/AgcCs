
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSynCodeTypeEN
 表名:SynCodeType(00050412)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:16:21
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:数据同步(DataSynch)
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
 /// 表SynCodeType的关键字(SynCodeTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_SynCodeTypeId_SynCodeType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strSynCodeTypeId">表关键字</param>
public K_SynCodeTypeId_SynCodeType(string strSynCodeTypeId)
{
if (IsValid(strSynCodeTypeId)) Value = strSynCodeTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strSynCodeTypeId)
{
if (string.IsNullOrEmpty(strSynCodeTypeId) == true) return false;
if (strSynCodeTypeId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_SynCodeTypeId_SynCodeType]类型的对象</returns>
public static implicit operator K_SynCodeTypeId_SynCodeType(string value)
{
return new K_SynCodeTypeId_SynCodeType(value);
}
}
 /// <summary>
 /// 代码类型(SynCodeType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsSynCodeTypeEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接，如果为空就使用系统默认的连接
public new const string _CurrTabName = "SynCodeType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "SynCodeTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string WhereFormat = ""; //条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"Memo", "SynCodeTypeId", "SynCodeTypeName"};

protected string mstrMemo;    //说明
protected string mstrSynCodeTypeId;    //SynCodeTypeId
protected string mstrSynCodeTypeName;    //SynCodeTypeName

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsSynCodeTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "SynCodeType";
 lstKeyFldNames.Add("SynCodeTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strSynCodeTypeId">关键字:SynCodeTypeId</param>
public clsSynCodeTypeEN(string strSynCodeTypeId)
 {
strSynCodeTypeId = strSynCodeTypeId.Replace("'", "''");
if (strSynCodeTypeId.Length > 4)
{
throw new Exception("在表:SynCodeType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strSynCodeTypeId)  ==  true)
{
throw new Exception("在表:SynCodeType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strSynCodeTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrSynCodeTypeId = strSynCodeTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "SynCodeType";
 lstKeyFldNames.Add("SynCodeTypeId");
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
if (strAttributeName  ==  conSynCodeType.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conSynCodeType.SynCodeTypeId)
{
return mstrSynCodeTypeId;
}
else if (strAttributeName  ==  conSynCodeType.SynCodeTypeName)
{
return mstrSynCodeTypeName;
}
return null;
}
set
{
if (strAttributeName  ==  conSynCodeType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSynCodeType.Memo);
}
else if (strAttributeName  ==  conSynCodeType.SynCodeTypeId)
{
mstrSynCodeTypeId = value.ToString();
 AddUpdatedFld(conSynCodeType.SynCodeTypeId);
}
else if (strAttributeName  ==  conSynCodeType.SynCodeTypeName)
{
mstrSynCodeTypeName = value.ToString();
 AddUpdatedFld(conSynCodeType.SynCodeTypeName);
}
}
}
public object this[int intIndex]
{
get
{
if (conSynCodeType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conSynCodeType.SynCodeTypeId  ==  AttributeName[intIndex])
{
return mstrSynCodeTypeId;
}
else if (conSynCodeType.SynCodeTypeName  ==  AttributeName[intIndex])
{
return mstrSynCodeTypeName;
}
return null;
}
set
{
if (conSynCodeType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSynCodeType.Memo);
}
else if (conSynCodeType.SynCodeTypeId  ==  AttributeName[intIndex])
{
mstrSynCodeTypeId = value.ToString();
 AddUpdatedFld(conSynCodeType.SynCodeTypeId);
}
else if (conSynCodeType.SynCodeTypeName  ==  AttributeName[intIndex])
{
mstrSynCodeTypeName = value.ToString();
 AddUpdatedFld(conSynCodeType.SynCodeTypeName);
}
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
 AddUpdatedFld(conSynCodeType.Memo);
}
}
/// <summary>
/// SynCodeTypeId(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SynCodeTypeId
{
get
{
return mstrSynCodeTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSynCodeTypeId = value;
}
else
{
 mstrSynCodeTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSynCodeType.SynCodeTypeId);
}
}
/// <summary>
/// SynCodeTypeName(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SynCodeTypeName
{
get
{
return mstrSynCodeTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSynCodeTypeName = value;
}
else
{
 mstrSynCodeTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conSynCodeType.SynCodeTypeName);
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
  return mstrSynCodeTypeId;
 }
 }
}
 /// <summary>
 /// 代码类型(SynCodeType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conSynCodeType
{
public new const string _CurrTabName = "SynCodeType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "SynCodeTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"Memo", "SynCodeTypeId", "SynCodeTypeName"};
//以下是属性变量


 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明

 /// <summary>
 /// 常量:"SynCodeTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SynCodeTypeId = "SynCodeTypeId";    //SynCodeTypeId

 /// <summary>
 /// 常量:"SynCodeTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SynCodeTypeName = "SynCodeTypeName";    //SynCodeTypeName
}

}