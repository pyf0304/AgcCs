
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjFileTypeEN
 表名:PrjFileType(00050649)
 * 版本:2026.05.30(服务器:WIN-SRV103-116)
 日期:2026/06/16 16:24:50
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:资源管理(ResourceMan)
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
 /// 表PrjFileType的关键字(PrjFileTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PrjFileTypeId_PrjFileType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strPrjFileTypeId">表关键字</param>
public K_PrjFileTypeId_PrjFileType(string strPrjFileTypeId)
{
if (IsValid(strPrjFileTypeId)) Value = strPrjFileTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strPrjFileTypeId)
{
if (string.IsNullOrEmpty(strPrjFileTypeId) == true) return false;
if (strPrjFileTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PrjFileTypeId_PrjFileType]类型的对象</returns>
public static implicit operator K_PrjFileTypeId_PrjFileType(string value)
{
return new K_PrjFileTypeId_PrjFileType(value);
}
}
 /// <summary>
 /// 工程文件类型(PrjFileType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsPrjFileTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "PrjFileType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PrjFileTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 8;
public static string[] _AttributeName = new string[] {"PrjFileTypeId", "PrjFileTypeName", "PrjFileTypeENName", "InUse", "OrderNum", "UpdDate", "UpdUserId", "Memo"};

protected string mstrPrjFileTypeId;    //项目文件类型Id
protected string mstrPrjFileTypeName;    //工程文件类型名
protected string mstrPrjFileTypeENName;    //工程文件类型英文名
protected bool mbolInUse;    //是否在用
protected int mintOrderNum;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsPrjFileTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PrjFileTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strPrjFileTypeId">关键字:项目文件类型Id</param>
public clsPrjFileTypeEN(string strPrjFileTypeId)
 {
strPrjFileTypeId = strPrjFileTypeId.Replace("'", "''");
if (strPrjFileTypeId.Length > 2)
{
throw new Exception("在表:PrjFileType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strPrjFileTypeId)  ==  true)
{
throw new Exception("在表:PrjFileType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPrjFileTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrPrjFileTypeId = strPrjFileTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PrjFileTypeId");
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
if (strAttributeName  ==  conPrjFileType.PrjFileTypeId)
{
return mstrPrjFileTypeId;
}
else if (strAttributeName  ==  conPrjFileType.PrjFileTypeName)
{
return mstrPrjFileTypeName;
}
else if (strAttributeName  ==  conPrjFileType.PrjFileTypeENName)
{
return mstrPrjFileTypeENName;
}
else if (strAttributeName  ==  conPrjFileType.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  conPrjFileType.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conPrjFileType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conPrjFileType.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conPrjFileType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conPrjFileType.PrjFileTypeId)
{
mstrPrjFileTypeId = value.ToString();
 AddUpdatedFld(conPrjFileType.PrjFileTypeId);
}
else if (strAttributeName  ==  conPrjFileType.PrjFileTypeName)
{
mstrPrjFileTypeName = value.ToString();
 AddUpdatedFld(conPrjFileType.PrjFileTypeName);
}
else if (strAttributeName  ==  conPrjFileType.PrjFileTypeENName)
{
mstrPrjFileTypeENName = value.ToString();
 AddUpdatedFld(conPrjFileType.PrjFileTypeENName);
}
else if (strAttributeName  ==  conPrjFileType.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjFileType.InUse);
}
else if (strAttributeName  ==  conPrjFileType.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conPrjFileType.OrderNum);
}
else if (strAttributeName  ==  conPrjFileType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conPrjFileType.UpdDate);
}
else if (strAttributeName  ==  conPrjFileType.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conPrjFileType.UpdUserId);
}
else if (strAttributeName  ==  conPrjFileType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPrjFileType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conPrjFileType.PrjFileTypeId  ==  _AttributeName[intIndex])
{
return mstrPrjFileTypeId;
}
else if (conPrjFileType.PrjFileTypeName  ==  _AttributeName[intIndex])
{
return mstrPrjFileTypeName;
}
else if (conPrjFileType.PrjFileTypeENName  ==  _AttributeName[intIndex])
{
return mstrPrjFileTypeENName;
}
else if (conPrjFileType.InUse  ==  _AttributeName[intIndex])
{
return mbolInUse;
}
else if (conPrjFileType.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conPrjFileType.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conPrjFileType.UpdUserId  ==  _AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conPrjFileType.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conPrjFileType.PrjFileTypeId  ==  _AttributeName[intIndex])
{
mstrPrjFileTypeId = value.ToString();
 AddUpdatedFld(conPrjFileType.PrjFileTypeId);
}
else if (conPrjFileType.PrjFileTypeName  ==  _AttributeName[intIndex])
{
mstrPrjFileTypeName = value.ToString();
 AddUpdatedFld(conPrjFileType.PrjFileTypeName);
}
else if (conPrjFileType.PrjFileTypeENName  ==  _AttributeName[intIndex])
{
mstrPrjFileTypeENName = value.ToString();
 AddUpdatedFld(conPrjFileType.PrjFileTypeENName);
}
else if (conPrjFileType.InUse  ==  _AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjFileType.InUse);
}
else if (conPrjFileType.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conPrjFileType.OrderNum);
}
else if (conPrjFileType.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conPrjFileType.UpdDate);
}
else if (conPrjFileType.UpdUserId  ==  _AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conPrjFileType.UpdUserId);
}
else if (conPrjFileType.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPrjFileType.Memo);
}
}
}

/// <summary>
/// 项目文件类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjFileTypeId
{
get
{
return mstrPrjFileTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjFileTypeId = value;
}
else
{
 mstrPrjFileTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjFileType.PrjFileTypeId);
}
}
/// <summary>
/// 工程文件类型名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjFileTypeName
{
get
{
return mstrPrjFileTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjFileTypeName = value;
}
else
{
 mstrPrjFileTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjFileType.PrjFileTypeName);
}
}
/// <summary>
/// 工程文件类型英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjFileTypeENName
{
get
{
return mstrPrjFileTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjFileTypeENName = value;
}
else
{
 mstrPrjFileTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjFileType.PrjFileTypeENName);
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
 AddUpdatedFld(conPrjFileType.InUse);
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
 AddUpdatedFld(conPrjFileType.OrderNum);
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
 AddUpdatedFld(conPrjFileType.UpdDate);
}
}
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUserId
{
get
{
return mstrUpdUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUserId = value;
}
else
{
 mstrUpdUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjFileType.UpdUserId);
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
 AddUpdatedFld(conPrjFileType.Memo);
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
  return mstrPrjFileTypeId;
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
  return mstrPrjFileTypeName;
 }
 }
}
 /// <summary>
 /// 工程文件类型(PrjFileType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conPrjFileType
{
public const string _CurrTabName = "PrjFileType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PrjFileTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"PrjFileTypeId", "PrjFileTypeName", "PrjFileTypeENName", "InUse", "OrderNum", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"PrjFileTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjFileTypeId = "PrjFileTypeId";    //项目文件类型Id

 /// <summary>
 /// 常量:"PrjFileTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjFileTypeName = "PrjFileTypeName";    //工程文件类型名

 /// <summary>
 /// 常量:"PrjFileTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjFileTypeENName = "PrjFileTypeENName";    //工程文件类型英文名

 /// <summary>
 /// 常量:"InUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InUse = "InUse";    //是否在用

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
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}