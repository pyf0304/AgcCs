
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjFeatureTypeEN
 表名:PrjFeatureType(00050323)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:34:14
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
 /// 表PrjFeatureType的关键字(FeatureTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_FeatureTypeId_PrjFeatureType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strFeatureTypeId">表关键字</param>
public K_FeatureTypeId_PrjFeatureType(string strFeatureTypeId)
{
if (IsValid(strFeatureTypeId)) Value = strFeatureTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strFeatureTypeId)
{
if (string.IsNullOrEmpty(strFeatureTypeId) == true) return false;
if (strFeatureTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_FeatureTypeId_PrjFeatureType]类型的对象</returns>
public static implicit operator K_FeatureTypeId_PrjFeatureType(string value)
{
return new K_FeatureTypeId_PrjFeatureType(value);
}
}
 /// <summary>
 /// 功能类型(PrjFeatureType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsPrjFeatureTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "PrjFeatureType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "FeatureTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 7;
public static string[] _AttributeName = new string[] {"FeatureTypeId", "FeatureTypeName", "FeatureTypeENName", "OrderNum", "UpdDate", "UpdUser", "Memo"};

protected string mstrFeatureTypeId;    //功能类型Id
protected string mstrFeatureTypeName;    //功能类型名称
protected string mstrFeatureTypeENName;    //功能类型英文名
protected int mintOrderNum;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsPrjFeatureTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FeatureTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strFeatureTypeId">关键字:功能类型Id</param>
public clsPrjFeatureTypeEN(string strFeatureTypeId)
 {
strFeatureTypeId = strFeatureTypeId.Replace("'", "''");
if (strFeatureTypeId.Length > 2)
{
throw new Exception("在表:PrjFeatureType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strFeatureTypeId)  ==  true)
{
throw new Exception("在表:PrjFeatureType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFeatureTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrFeatureTypeId = strFeatureTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FeatureTypeId");
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
if (strAttributeName  ==  conPrjFeatureType.FeatureTypeId)
{
return mstrFeatureTypeId;
}
else if (strAttributeName  ==  conPrjFeatureType.FeatureTypeName)
{
return mstrFeatureTypeName;
}
else if (strAttributeName  ==  conPrjFeatureType.FeatureTypeENName)
{
return mstrFeatureTypeENName;
}
else if (strAttributeName  ==  conPrjFeatureType.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conPrjFeatureType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conPrjFeatureType.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conPrjFeatureType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conPrjFeatureType.FeatureTypeId)
{
mstrFeatureTypeId = value.ToString();
 AddUpdatedFld(conPrjFeatureType.FeatureTypeId);
}
else if (strAttributeName  ==  conPrjFeatureType.FeatureTypeName)
{
mstrFeatureTypeName = value.ToString();
 AddUpdatedFld(conPrjFeatureType.FeatureTypeName);
}
else if (strAttributeName  ==  conPrjFeatureType.FeatureTypeENName)
{
mstrFeatureTypeENName = value.ToString();
 AddUpdatedFld(conPrjFeatureType.FeatureTypeENName);
}
else if (strAttributeName  ==  conPrjFeatureType.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conPrjFeatureType.OrderNum);
}
else if (strAttributeName  ==  conPrjFeatureType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conPrjFeatureType.UpdDate);
}
else if (strAttributeName  ==  conPrjFeatureType.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conPrjFeatureType.UpdUser);
}
else if (strAttributeName  ==  conPrjFeatureType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPrjFeatureType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conPrjFeatureType.FeatureTypeId  ==  _AttributeName[intIndex])
{
return mstrFeatureTypeId;
}
else if (conPrjFeatureType.FeatureTypeName  ==  _AttributeName[intIndex])
{
return mstrFeatureTypeName;
}
else if (conPrjFeatureType.FeatureTypeENName  ==  _AttributeName[intIndex])
{
return mstrFeatureTypeENName;
}
else if (conPrjFeatureType.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conPrjFeatureType.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conPrjFeatureType.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conPrjFeatureType.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conPrjFeatureType.FeatureTypeId  ==  _AttributeName[intIndex])
{
mstrFeatureTypeId = value.ToString();
 AddUpdatedFld(conPrjFeatureType.FeatureTypeId);
}
else if (conPrjFeatureType.FeatureTypeName  ==  _AttributeName[intIndex])
{
mstrFeatureTypeName = value.ToString();
 AddUpdatedFld(conPrjFeatureType.FeatureTypeName);
}
else if (conPrjFeatureType.FeatureTypeENName  ==  _AttributeName[intIndex])
{
mstrFeatureTypeENName = value.ToString();
 AddUpdatedFld(conPrjFeatureType.FeatureTypeENName);
}
else if (conPrjFeatureType.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conPrjFeatureType.OrderNum);
}
else if (conPrjFeatureType.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conPrjFeatureType.UpdDate);
}
else if (conPrjFeatureType.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conPrjFeatureType.UpdUser);
}
else if (conPrjFeatureType.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPrjFeatureType.Memo);
}
}
}

/// <summary>
/// 功能类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FeatureTypeId
{
get
{
return mstrFeatureTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFeatureTypeId = value;
}
else
{
 mstrFeatureTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjFeatureType.FeatureTypeId);
}
}
/// <summary>
/// 功能类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FeatureTypeName
{
get
{
return mstrFeatureTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFeatureTypeName = value;
}
else
{
 mstrFeatureTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjFeatureType.FeatureTypeName);
}
}
/// <summary>
/// 功能类型英文名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FeatureTypeENName
{
get
{
return mstrFeatureTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFeatureTypeENName = value;
}
else
{
 mstrFeatureTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjFeatureType.FeatureTypeENName);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(conPrjFeatureType.OrderNum);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdDate
{
get
{
return mstrUpdDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdDate = value;
}
else
{
 mstrUpdDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjFeatureType.UpdDate);
}
}
/// <summary>
/// 修改者(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUser
{
get
{
return mstrUpdUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUser = value;
}
else
{
 mstrUpdUser = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjFeatureType.UpdUser);
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
 AddUpdatedFld(conPrjFeatureType.Memo);
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
  return mstrFeatureTypeId;
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
  return mstrFeatureTypeName;
 }
 }
}
 /// <summary>
 /// 功能类型(PrjFeatureType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conPrjFeatureType
{
public const string _CurrTabName = "PrjFeatureType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FeatureTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"FeatureTypeId", "FeatureTypeName", "FeatureTypeENName", "OrderNum", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"FeatureTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeatureTypeId = "FeatureTypeId";    //功能类型Id

 /// <summary>
 /// 常量:"FeatureTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeatureTypeName = "FeatureTypeName";    //功能类型名称

 /// <summary>
 /// 常量:"FeatureTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeatureTypeENName = "FeatureTypeENName";    //功能类型英文名

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改者

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}