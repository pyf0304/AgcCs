
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrimaryTypeEN
 表名:PrimaryType(00050020)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:31:58
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
 /// 表PrimaryType的关键字(PrimaryTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PrimaryTypeId_PrimaryType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strPrimaryTypeId">表关键字</param>
public K_PrimaryTypeId_PrimaryType(string strPrimaryTypeId)
{
if (IsValid(strPrimaryTypeId)) Value = strPrimaryTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strPrimaryTypeId)
{
if (string.IsNullOrEmpty(strPrimaryTypeId) == true) return false;
if (strPrimaryTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PrimaryTypeId_PrimaryType]类型的对象</returns>
public static implicit operator K_PrimaryTypeId_PrimaryType(string value)
{
return new K_PrimaryTypeId_PrimaryType(value);
}
}
 /// <summary>
 /// 主键类型(PrimaryType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsPrimaryTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "PrimaryType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PrimaryTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 5;
public static string[] _AttributeName = new string[] {"PrimaryTypeId", "PrimaryTypeName", "PrimaryTypeENName", "OrderNum", "Memo"};

protected string mstrPrimaryTypeId;    //主键类型ID
protected string mstrPrimaryTypeName;    //主键类型名
protected string mstrPrimaryTypeENName;    //主键类型英文名
protected int? mintOrderNum;    //序号
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsPrimaryTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PrimaryTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strPrimaryTypeId">关键字:主键类型ID</param>
public clsPrimaryTypeEN(string strPrimaryTypeId)
 {
strPrimaryTypeId = strPrimaryTypeId.Replace("'", "''");
if (strPrimaryTypeId.Length > 2)
{
throw new Exception("在表:PrimaryType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strPrimaryTypeId)  ==  true)
{
throw new Exception("在表:PrimaryType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPrimaryTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrPrimaryTypeId = strPrimaryTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PrimaryTypeId");
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
if (strAttributeName  ==  conPrimaryType.PrimaryTypeId)
{
return mstrPrimaryTypeId;
}
else if (strAttributeName  ==  conPrimaryType.PrimaryTypeName)
{
return mstrPrimaryTypeName;
}
else if (strAttributeName  ==  conPrimaryType.PrimaryTypeENName)
{
return mstrPrimaryTypeENName;
}
else if (strAttributeName  ==  conPrimaryType.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conPrimaryType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conPrimaryType.PrimaryTypeId)
{
mstrPrimaryTypeId = value.ToString();
 AddUpdatedFld(conPrimaryType.PrimaryTypeId);
}
else if (strAttributeName  ==  conPrimaryType.PrimaryTypeName)
{
mstrPrimaryTypeName = value.ToString();
 AddUpdatedFld(conPrimaryType.PrimaryTypeName);
}
else if (strAttributeName  ==  conPrimaryType.PrimaryTypeENName)
{
mstrPrimaryTypeENName = value.ToString();
 AddUpdatedFld(conPrimaryType.PrimaryTypeENName);
}
else if (strAttributeName  ==  conPrimaryType.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conPrimaryType.OrderNum);
}
else if (strAttributeName  ==  conPrimaryType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPrimaryType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conPrimaryType.PrimaryTypeId  ==  _AttributeName[intIndex])
{
return mstrPrimaryTypeId;
}
else if (conPrimaryType.PrimaryTypeName  ==  _AttributeName[intIndex])
{
return mstrPrimaryTypeName;
}
else if (conPrimaryType.PrimaryTypeENName  ==  _AttributeName[intIndex])
{
return mstrPrimaryTypeENName;
}
else if (conPrimaryType.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conPrimaryType.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conPrimaryType.PrimaryTypeId  ==  _AttributeName[intIndex])
{
mstrPrimaryTypeId = value.ToString();
 AddUpdatedFld(conPrimaryType.PrimaryTypeId);
}
else if (conPrimaryType.PrimaryTypeName  ==  _AttributeName[intIndex])
{
mstrPrimaryTypeName = value.ToString();
 AddUpdatedFld(conPrimaryType.PrimaryTypeName);
}
else if (conPrimaryType.PrimaryTypeENName  ==  _AttributeName[intIndex])
{
mstrPrimaryTypeENName = value.ToString();
 AddUpdatedFld(conPrimaryType.PrimaryTypeENName);
}
else if (conPrimaryType.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conPrimaryType.OrderNum);
}
else if (conPrimaryType.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPrimaryType.Memo);
}
}
}

/// <summary>
/// 主键类型ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrimaryTypeId
{
get
{
return mstrPrimaryTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrimaryTypeId = value;
}
else
{
 mstrPrimaryTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrimaryType.PrimaryTypeId);
}
}
/// <summary>
/// 主键类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrimaryTypeName
{
get
{
return mstrPrimaryTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrimaryTypeName = value;
}
else
{
 mstrPrimaryTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrimaryType.PrimaryTypeName);
}
}
/// <summary>
/// 主键类型英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrimaryTypeENName
{
get
{
return mstrPrimaryTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrimaryTypeENName = value;
}
else
{
 mstrPrimaryTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrimaryType.PrimaryTypeENName);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(conPrimaryType.OrderNum);
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
 AddUpdatedFld(conPrimaryType.Memo);
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
  return mstrPrimaryTypeId;
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
  return mstrPrimaryTypeName;
 }
 }
}
 /// <summary>
 /// 主键类型(PrimaryType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conPrimaryType
{
public const string _CurrTabName = "PrimaryType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PrimaryTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"PrimaryTypeId", "PrimaryTypeName", "PrimaryTypeENName", "OrderNum", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"PrimaryTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrimaryTypeId = "PrimaryTypeId";    //主键类型ID

 /// <summary>
 /// 常量:"PrimaryTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrimaryTypeName = "PrimaryTypeName";    //主键类型名

 /// <summary>
 /// 常量:"PrimaryTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrimaryTypeENName = "PrimaryTypeENName";    //主键类型英文名

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}