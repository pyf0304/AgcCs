
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjFileBigTypeEN
 表名:PrjFileBigType(00050650)
 * 版本:2026.05.30(服务器:PYF-AI)
 日期:2026/06/19 11:13:09
 生成者:pyf2
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
 /// 表PrjFileBigType的关键字(PrjFileBigTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PrjFileBigTypeId_PrjFileBigType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strPrjFileBigTypeId">表关键字</param>
public K_PrjFileBigTypeId_PrjFileBigType(string strPrjFileBigTypeId)
{
if (IsValid(strPrjFileBigTypeId)) Value = strPrjFileBigTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strPrjFileBigTypeId)
{
if (string.IsNullOrEmpty(strPrjFileBigTypeId) == true) return false;
if (strPrjFileBigTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PrjFileBigTypeId_PrjFileBigType]类型的对象</returns>
public static implicit operator K_PrjFileBigTypeId_PrjFileBigType(string value)
{
return new K_PrjFileBigTypeId_PrjFileBigType(value);
}
}
 /// <summary>
 /// 工程文件主类型(PrjFileBigType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsPrjFileBigTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "PrjFileBigType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PrjFileBigTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 6;
public static string[] _AttributeName = new string[] {"PrjFileBigTypeId", "PrjFileBigTypeName", "InUse", "UpdDate", "UpdUserId", "Memo"};

protected string mstrPrjFileBigTypeId;    //项目文件大类Id
protected string mstrPrjFileBigTypeName;    //工程文件大类名
protected bool mbolInUse;    //是否在用
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsPrjFileBigTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PrjFileBigTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strPrjFileBigTypeId">关键字:项目文件大类Id</param>
public clsPrjFileBigTypeEN(string strPrjFileBigTypeId)
 {
strPrjFileBigTypeId = strPrjFileBigTypeId.Replace("'", "''");
if (strPrjFileBigTypeId.Length > 2)
{
throw new Exception("在表:PrjFileBigType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strPrjFileBigTypeId)  ==  true)
{
throw new Exception("在表:PrjFileBigType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPrjFileBigTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrPrjFileBigTypeId = strPrjFileBigTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PrjFileBigTypeId");
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
if (strAttributeName  ==  conPrjFileBigType.PrjFileBigTypeId)
{
return mstrPrjFileBigTypeId;
}
else if (strAttributeName  ==  conPrjFileBigType.PrjFileBigTypeName)
{
return mstrPrjFileBigTypeName;
}
else if (strAttributeName  ==  conPrjFileBigType.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  conPrjFileBigType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conPrjFileBigType.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conPrjFileBigType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conPrjFileBigType.PrjFileBigTypeId)
{
mstrPrjFileBigTypeId = value.ToString();
 AddUpdatedFld(conPrjFileBigType.PrjFileBigTypeId);
}
else if (strAttributeName  ==  conPrjFileBigType.PrjFileBigTypeName)
{
mstrPrjFileBigTypeName = value.ToString();
 AddUpdatedFld(conPrjFileBigType.PrjFileBigTypeName);
}
else if (strAttributeName  ==  conPrjFileBigType.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjFileBigType.InUse);
}
else if (strAttributeName  ==  conPrjFileBigType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conPrjFileBigType.UpdDate);
}
else if (strAttributeName  ==  conPrjFileBigType.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conPrjFileBigType.UpdUserId);
}
else if (strAttributeName  ==  conPrjFileBigType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPrjFileBigType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conPrjFileBigType.PrjFileBigTypeId  ==  _AttributeName[intIndex])
{
return mstrPrjFileBigTypeId;
}
else if (conPrjFileBigType.PrjFileBigTypeName  ==  _AttributeName[intIndex])
{
return mstrPrjFileBigTypeName;
}
else if (conPrjFileBigType.InUse  ==  _AttributeName[intIndex])
{
return mbolInUse;
}
else if (conPrjFileBigType.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conPrjFileBigType.UpdUserId  ==  _AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conPrjFileBigType.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conPrjFileBigType.PrjFileBigTypeId  ==  _AttributeName[intIndex])
{
mstrPrjFileBigTypeId = value.ToString();
 AddUpdatedFld(conPrjFileBigType.PrjFileBigTypeId);
}
else if (conPrjFileBigType.PrjFileBigTypeName  ==  _AttributeName[intIndex])
{
mstrPrjFileBigTypeName = value.ToString();
 AddUpdatedFld(conPrjFileBigType.PrjFileBigTypeName);
}
else if (conPrjFileBigType.InUse  ==  _AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjFileBigType.InUse);
}
else if (conPrjFileBigType.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conPrjFileBigType.UpdDate);
}
else if (conPrjFileBigType.UpdUserId  ==  _AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conPrjFileBigType.UpdUserId);
}
else if (conPrjFileBigType.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPrjFileBigType.Memo);
}
}
}

/// <summary>
/// 项目文件大类Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjFileBigTypeId
{
get
{
return mstrPrjFileBigTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjFileBigTypeId = value;
}
else
{
 mstrPrjFileBigTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjFileBigType.PrjFileBigTypeId);
}
}
/// <summary>
/// 工程文件大类名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjFileBigTypeName
{
get
{
return mstrPrjFileBigTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjFileBigTypeName = value;
}
else
{
 mstrPrjFileBigTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjFileBigType.PrjFileBigTypeName);
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
 AddUpdatedFld(conPrjFileBigType.InUse);
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
 AddUpdatedFld(conPrjFileBigType.UpdDate);
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
 AddUpdatedFld(conPrjFileBigType.UpdUserId);
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
 AddUpdatedFld(conPrjFileBigType.Memo);
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
  return mstrPrjFileBigTypeId;
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
  return mstrPrjFileBigTypeName;
 }
 }
}
 /// <summary>
 /// 工程文件主类型(PrjFileBigType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conPrjFileBigType
{
public const string _CurrTabName = "PrjFileBigType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PrjFileBigTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"PrjFileBigTypeId", "PrjFileBigTypeName", "InUse", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"PrjFileBigTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjFileBigTypeId = "PrjFileBigTypeId";    //项目文件大类Id

 /// <summary>
 /// 常量:"PrjFileBigTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjFileBigTypeName = "PrjFileBigTypeName";    //工程文件大类名

 /// <summary>
 /// 常量:"InUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InUse = "InUse";    //是否在用

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