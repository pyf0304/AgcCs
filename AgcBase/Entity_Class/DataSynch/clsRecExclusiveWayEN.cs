
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsRecExclusiveWayEN
 表名:RecExclusiveWay(00050273)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:15:40
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
 /// 表RecExclusiveWay的关键字(RecExclusiveWayId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_RecExclusiveWayId_RecExclusiveWay
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strRecExclusiveWayId">表关键字</param>
public K_RecExclusiveWayId_RecExclusiveWay(string strRecExclusiveWayId)
{
if (IsValid(strRecExclusiveWayId)) Value = strRecExclusiveWayId;
else
{
Value = null;
}
}
private static bool IsValid(string strRecExclusiveWayId)
{
if (string.IsNullOrEmpty(strRecExclusiveWayId) == true) return false;
if (strRecExclusiveWayId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_RecExclusiveWayId_RecExclusiveWay]类型的对象</returns>
public static implicit operator K_RecExclusiveWayId_RecExclusiveWay(string value)
{
return new K_RecExclusiveWayId_RecExclusiveWay(value);
}
}
 /// <summary>
 /// RecExclusiveWay(RecExclusiveWay)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsRecExclusiveWayEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接，如果为空就使用系统默认的连接
public new const string _CurrTabName = "RecExclusiveWay"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "RecExclusiveWayId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string WhereFormat = ""; //条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"RecExclusiveWayId", "RecExclusiveWayName", "Memo"};

protected string mstrRecExclusiveWayId;    //记录排他方式Id
protected string mstrRecExclusiveWayName;    //记录排他方式名称
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsRecExclusiveWayEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "RecExclusiveWay";
 lstKeyFldNames.Add("RecExclusiveWayId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strRecExclusiveWayId">关键字:记录排他方式Id</param>
public clsRecExclusiveWayEN(string strRecExclusiveWayId)
 {
strRecExclusiveWayId = strRecExclusiveWayId.Replace("'", "''");
if (strRecExclusiveWayId.Length > 4)
{
throw new Exception("在表:RecExclusiveWay中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strRecExclusiveWayId)  ==  true)
{
throw new Exception("在表:RecExclusiveWay中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strRecExclusiveWayId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrRecExclusiveWayId = strRecExclusiveWayId;
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "RecExclusiveWay";
 lstKeyFldNames.Add("RecExclusiveWayId");
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
if (strAttributeName  ==  conRecExclusiveWay.RecExclusiveWayId)
{
return mstrRecExclusiveWayId;
}
else if (strAttributeName  ==  conRecExclusiveWay.RecExclusiveWayName)
{
return mstrRecExclusiveWayName;
}
else if (strAttributeName  ==  conRecExclusiveWay.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conRecExclusiveWay.RecExclusiveWayId)
{
mstrRecExclusiveWayId = value.ToString();
 AddUpdatedFld(conRecExclusiveWay.RecExclusiveWayId);
}
else if (strAttributeName  ==  conRecExclusiveWay.RecExclusiveWayName)
{
mstrRecExclusiveWayName = value.ToString();
 AddUpdatedFld(conRecExclusiveWay.RecExclusiveWayName);
}
else if (strAttributeName  ==  conRecExclusiveWay.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conRecExclusiveWay.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conRecExclusiveWay.RecExclusiveWayId  ==  AttributeName[intIndex])
{
return mstrRecExclusiveWayId;
}
else if (conRecExclusiveWay.RecExclusiveWayName  ==  AttributeName[intIndex])
{
return mstrRecExclusiveWayName;
}
else if (conRecExclusiveWay.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conRecExclusiveWay.RecExclusiveWayId  ==  AttributeName[intIndex])
{
mstrRecExclusiveWayId = value.ToString();
 AddUpdatedFld(conRecExclusiveWay.RecExclusiveWayId);
}
else if (conRecExclusiveWay.RecExclusiveWayName  ==  AttributeName[intIndex])
{
mstrRecExclusiveWayName = value.ToString();
 AddUpdatedFld(conRecExclusiveWay.RecExclusiveWayName);
}
else if (conRecExclusiveWay.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conRecExclusiveWay.Memo);
}
}
}

/// <summary>
/// 记录排他方式Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RecExclusiveWayId
{
get
{
return mstrRecExclusiveWayId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRecExclusiveWayId = value;
}
else
{
 mstrRecExclusiveWayId = value;
}
//记录修改过的字段
 AddUpdatedFld(conRecExclusiveWay.RecExclusiveWayId);
}
}
/// <summary>
/// 记录排他方式名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RecExclusiveWayName
{
get
{
return mstrRecExclusiveWayName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRecExclusiveWayName = value;
}
else
{
 mstrRecExclusiveWayName = value;
}
//记录修改过的字段
 AddUpdatedFld(conRecExclusiveWay.RecExclusiveWayName);
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
 AddUpdatedFld(conRecExclusiveWay.Memo);
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
  return mstrRecExclusiveWayId;
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
  return mstrRecExclusiveWayName;
 }
 }
}
 /// <summary>
 /// RecExclusiveWay(RecExclusiveWay)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conRecExclusiveWay
{
public new const string _CurrTabName = "RecExclusiveWay"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "RecExclusiveWayId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"RecExclusiveWayId", "RecExclusiveWayName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"RecExclusiveWayId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RecExclusiveWayId = "RecExclusiveWayId";    //记录排他方式Id

 /// <summary>
 /// 常量:"RecExclusiveWayName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RecExclusiveWayName = "RecExclusiveWayName";    //记录排他方式名称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}