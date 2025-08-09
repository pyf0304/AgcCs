
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsReferFileTypeEN
 表名:ReferFileType(00050473)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:08:28
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
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
 /// 表ReferFileType的关键字(ReferFileTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ReferFileTypeId_ReferFileType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strReferFileTypeId">表关键字</param>
public K_ReferFileTypeId_ReferFileType(string strReferFileTypeId)
{
if (IsValid(strReferFileTypeId)) Value = strReferFileTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strReferFileTypeId)
{
if (string.IsNullOrEmpty(strReferFileTypeId) == true) return false;
if (strReferFileTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ReferFileTypeId_ReferFileType]类型的对象</returns>
public static implicit operator K_ReferFileTypeId_ReferFileType(string value)
{
return new K_ReferFileTypeId_ReferFileType(value);
}
}
 /// <summary>
 /// 引用文件类型(ReferFileType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsReferFileTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ReferFileType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ReferFileTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 8;
public static string[] _AttributeName = new string[] {"ReferFileTypeId", "ReferFileTypeName", "ReferFileTypeENName", "InUse", "OrderNum", "UpdDate", "UpdUserId", "Memo"};

protected string mstrReferFileTypeId;    //引用文件类型Id
protected string mstrReferFileTypeName;    //引用文件类型名
protected string mstrReferFileTypeENName;    //引用文件类型英文名
protected bool mbolInUse;    //是否在用
protected int mintOrderNum;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsReferFileTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ReferFileTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strReferFileTypeId">关键字:引用文件类型Id</param>
public clsReferFileTypeEN(string strReferFileTypeId)
 {
strReferFileTypeId = strReferFileTypeId.Replace("'", "''");
if (strReferFileTypeId.Length > 2)
{
throw new Exception("在表:ReferFileType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strReferFileTypeId)  ==  true)
{
throw new Exception("在表:ReferFileType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strReferFileTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrReferFileTypeId = strReferFileTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ReferFileTypeId");
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
if (strAttributeName  ==  conReferFileType.ReferFileTypeId)
{
return mstrReferFileTypeId;
}
else if (strAttributeName  ==  conReferFileType.ReferFileTypeName)
{
return mstrReferFileTypeName;
}
else if (strAttributeName  ==  conReferFileType.ReferFileTypeENName)
{
return mstrReferFileTypeENName;
}
else if (strAttributeName  ==  conReferFileType.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  conReferFileType.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conReferFileType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conReferFileType.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conReferFileType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conReferFileType.ReferFileTypeId)
{
mstrReferFileTypeId = value.ToString();
 AddUpdatedFld(conReferFileType.ReferFileTypeId);
}
else if (strAttributeName  ==  conReferFileType.ReferFileTypeName)
{
mstrReferFileTypeName = value.ToString();
 AddUpdatedFld(conReferFileType.ReferFileTypeName);
}
else if (strAttributeName  ==  conReferFileType.ReferFileTypeENName)
{
mstrReferFileTypeENName = value.ToString();
 AddUpdatedFld(conReferFileType.ReferFileTypeENName);
}
else if (strAttributeName  ==  conReferFileType.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conReferFileType.InUse);
}
else if (strAttributeName  ==  conReferFileType.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conReferFileType.OrderNum);
}
else if (strAttributeName  ==  conReferFileType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conReferFileType.UpdDate);
}
else if (strAttributeName  ==  conReferFileType.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conReferFileType.UpdUserId);
}
else if (strAttributeName  ==  conReferFileType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conReferFileType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conReferFileType.ReferFileTypeId  ==  _AttributeName[intIndex])
{
return mstrReferFileTypeId;
}
else if (conReferFileType.ReferFileTypeName  ==  _AttributeName[intIndex])
{
return mstrReferFileTypeName;
}
else if (conReferFileType.ReferFileTypeENName  ==  _AttributeName[intIndex])
{
return mstrReferFileTypeENName;
}
else if (conReferFileType.InUse  ==  _AttributeName[intIndex])
{
return mbolInUse;
}
else if (conReferFileType.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conReferFileType.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conReferFileType.UpdUserId  ==  _AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conReferFileType.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conReferFileType.ReferFileTypeId  ==  _AttributeName[intIndex])
{
mstrReferFileTypeId = value.ToString();
 AddUpdatedFld(conReferFileType.ReferFileTypeId);
}
else if (conReferFileType.ReferFileTypeName  ==  _AttributeName[intIndex])
{
mstrReferFileTypeName = value.ToString();
 AddUpdatedFld(conReferFileType.ReferFileTypeName);
}
else if (conReferFileType.ReferFileTypeENName  ==  _AttributeName[intIndex])
{
mstrReferFileTypeENName = value.ToString();
 AddUpdatedFld(conReferFileType.ReferFileTypeENName);
}
else if (conReferFileType.InUse  ==  _AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conReferFileType.InUse);
}
else if (conReferFileType.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conReferFileType.OrderNum);
}
else if (conReferFileType.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conReferFileType.UpdDate);
}
else if (conReferFileType.UpdUserId  ==  _AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conReferFileType.UpdUserId);
}
else if (conReferFileType.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conReferFileType.Memo);
}
}
}

/// <summary>
/// 引用文件类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ReferFileTypeId
{
get
{
return mstrReferFileTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrReferFileTypeId = value;
}
else
{
 mstrReferFileTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conReferFileType.ReferFileTypeId);
}
}
/// <summary>
/// 引用文件类型名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ReferFileTypeName
{
get
{
return mstrReferFileTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrReferFileTypeName = value;
}
else
{
 mstrReferFileTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conReferFileType.ReferFileTypeName);
}
}
/// <summary>
/// 引用文件类型英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ReferFileTypeENName
{
get
{
return mstrReferFileTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrReferFileTypeENName = value;
}
else
{
 mstrReferFileTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conReferFileType.ReferFileTypeENName);
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
 AddUpdatedFld(conReferFileType.InUse);
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
 AddUpdatedFld(conReferFileType.OrderNum);
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
 AddUpdatedFld(conReferFileType.UpdDate);
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
 AddUpdatedFld(conReferFileType.UpdUserId);
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
 AddUpdatedFld(conReferFileType.Memo);
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
  return mstrReferFileTypeId;
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
  return mstrReferFileTypeName;
 }
 }
}
 /// <summary>
 /// 引用文件类型(ReferFileType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conReferFileType
{
public const string _CurrTabName = "ReferFileType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ReferFileTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"ReferFileTypeId", "ReferFileTypeName", "ReferFileTypeENName", "InUse", "OrderNum", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"ReferFileTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReferFileTypeId = "ReferFileTypeId";    //引用文件类型Id

 /// <summary>
 /// 常量:"ReferFileTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReferFileTypeName = "ReferFileTypeName";    //引用文件类型名

 /// <summary>
 /// 常量:"ReferFileTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReferFileTypeENName = "ReferFileTypeENName";    //引用文件类型英文名

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