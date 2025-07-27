
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTransWayEN
 表名:TransWay(00050268)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:16:59
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
 /// 表TransWay的关键字(TransWayId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TransWayId_TransWay
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strTransWayId">表关键字</param>
public K_TransWayId_TransWay(string strTransWayId)
{
if (IsValid(strTransWayId)) Value = strTransWayId;
else
{
Value = null;
}
}
private static bool IsValid(string strTransWayId)
{
if (string.IsNullOrEmpty(strTransWayId) == true) return false;
if (strTransWayId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_TransWayId_TransWay]类型的对象</returns>
public static implicit operator K_TransWayId_TransWay(string value)
{
return new K_TransWayId_TransWay(value);
}
}
 /// <summary>
 /// 转换方式(TransWay)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsTransWayEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接，如果为空就使用系统默认的连接
public new const string _CurrTabName = "TransWay"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TransWayId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string WhereFormat = ""; //条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"TransWayId", "TransWayName", "Memo"};

protected string mstrTransWayId;    //转换方式ID
protected string mstrTransWayName;    //转换方式名称
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsTransWayEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "TransWay";
 lstKeyFldNames.Add("TransWayId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strTransWayId">关键字:转换方式ID</param>
public clsTransWayEN(string strTransWayId)
 {
strTransWayId = strTransWayId.Replace("'", "''");
if (strTransWayId.Length > 2)
{
throw new Exception("在表:TransWay中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTransWayId)  ==  true)
{
throw new Exception("在表:TransWay中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTransWayId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrTransWayId = strTransWayId;
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "TransWay";
 lstKeyFldNames.Add("TransWayId");
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
if (strAttributeName  ==  conTransWay.TransWayId)
{
return mstrTransWayId;
}
else if (strAttributeName  ==  conTransWay.TransWayName)
{
return mstrTransWayName;
}
else if (strAttributeName  ==  conTransWay.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conTransWay.TransWayId)
{
mstrTransWayId = value.ToString();
 AddUpdatedFld(conTransWay.TransWayId);
}
else if (strAttributeName  ==  conTransWay.TransWayName)
{
mstrTransWayName = value.ToString();
 AddUpdatedFld(conTransWay.TransWayName);
}
else if (strAttributeName  ==  conTransWay.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTransWay.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conTransWay.TransWayId  ==  AttributeName[intIndex])
{
return mstrTransWayId;
}
else if (conTransWay.TransWayName  ==  AttributeName[intIndex])
{
return mstrTransWayName;
}
else if (conTransWay.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conTransWay.TransWayId  ==  AttributeName[intIndex])
{
mstrTransWayId = value.ToString();
 AddUpdatedFld(conTransWay.TransWayId);
}
else if (conTransWay.TransWayName  ==  AttributeName[intIndex])
{
mstrTransWayName = value.ToString();
 AddUpdatedFld(conTransWay.TransWayName);
}
else if (conTransWay.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTransWay.Memo);
}
}
}

/// <summary>
/// 转换方式ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TransWayId
{
get
{
return mstrTransWayId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTransWayId = value;
}
else
{
 mstrTransWayId = value;
}
//记录修改过的字段
 AddUpdatedFld(conTransWay.TransWayId);
}
}
/// <summary>
/// 转换方式名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TransWayName
{
get
{
return mstrTransWayName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTransWayName = value;
}
else
{
 mstrTransWayName = value;
}
//记录修改过的字段
 AddUpdatedFld(conTransWay.TransWayName);
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
 AddUpdatedFld(conTransWay.Memo);
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
  return mstrTransWayId;
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
  return mstrTransWayName;
 }
 }
}
 /// <summary>
 /// 转换方式(TransWay)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conTransWay
{
public new const string _CurrTabName = "TransWay"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TransWayId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"TransWayId", "TransWayName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"TransWayId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TransWayId = "TransWayId";    //转换方式ID

 /// <summary>
 /// 常量:"TransWayName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TransWayName = "TransWayName";    //转换方式名称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}