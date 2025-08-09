
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDictType4GCEN
 表名:DictType4GC(00050352)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:09:58
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
 /// 表DictType4GC的关键字(DictTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_DictTypeId_DictType4GC
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strDictTypeId">表关键字</param>
public K_DictTypeId_DictType4GC(string strDictTypeId)
{
if (IsValid(strDictTypeId)) Value = strDictTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strDictTypeId)
{
if (string.IsNullOrEmpty(strDictTypeId) == true) return false;
if (strDictTypeId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_DictTypeId_DictType4GC]类型的对象</returns>
public static implicit operator K_DictTypeId_DictType4GC(string value)
{
return new K_DictTypeId_DictType4GC(value);
}
}
 /// <summary>
 /// 生成代码字典类型(DictType4GC)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsDictType4GCEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "DictType4GC"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "DictTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 5;
public static string[] _AttributeName = new string[] {"DictTypeId", "DictTypeName", "UpdDate", "UpdUser", "Memo"};

protected string mstrDictTypeId;    //字典类型Id
protected string mstrDictTypeName;    //字典类型名
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsDictType4GCEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("DictTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strDictTypeId">关键字:字典类型Id</param>
public clsDictType4GCEN(string strDictTypeId)
 {
strDictTypeId = strDictTypeId.Replace("'", "''");
if (strDictTypeId.Length > 4)
{
throw new Exception("在表:DictType4GC中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strDictTypeId)  ==  true)
{
throw new Exception("在表:DictType4GC中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strDictTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrDictTypeId = strDictTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("DictTypeId");
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
if (strAttributeName  ==  conDictType4GC.DictTypeId)
{
return mstrDictTypeId;
}
else if (strAttributeName  ==  conDictType4GC.DictTypeName)
{
return mstrDictTypeName;
}
else if (strAttributeName  ==  conDictType4GC.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conDictType4GC.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conDictType4GC.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conDictType4GC.DictTypeId)
{
mstrDictTypeId = value.ToString();
 AddUpdatedFld(conDictType4GC.DictTypeId);
}
else if (strAttributeName  ==  conDictType4GC.DictTypeName)
{
mstrDictTypeName = value.ToString();
 AddUpdatedFld(conDictType4GC.DictTypeName);
}
else if (strAttributeName  ==  conDictType4GC.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conDictType4GC.UpdDate);
}
else if (strAttributeName  ==  conDictType4GC.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conDictType4GC.UpdUser);
}
else if (strAttributeName  ==  conDictType4GC.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDictType4GC.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conDictType4GC.DictTypeId  ==  _AttributeName[intIndex])
{
return mstrDictTypeId;
}
else if (conDictType4GC.DictTypeName  ==  _AttributeName[intIndex])
{
return mstrDictTypeName;
}
else if (conDictType4GC.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conDictType4GC.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conDictType4GC.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conDictType4GC.DictTypeId  ==  _AttributeName[intIndex])
{
mstrDictTypeId = value.ToString();
 AddUpdatedFld(conDictType4GC.DictTypeId);
}
else if (conDictType4GC.DictTypeName  ==  _AttributeName[intIndex])
{
mstrDictTypeName = value.ToString();
 AddUpdatedFld(conDictType4GC.DictTypeName);
}
else if (conDictType4GC.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conDictType4GC.UpdDate);
}
else if (conDictType4GC.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conDictType4GC.UpdUser);
}
else if (conDictType4GC.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDictType4GC.Memo);
}
}
}

/// <summary>
/// 字典类型Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DictTypeId
{
get
{
return mstrDictTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDictTypeId = value;
}
else
{
 mstrDictTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conDictType4GC.DictTypeId);
}
}
/// <summary>
/// 字典类型名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DictTypeName
{
get
{
return mstrDictTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDictTypeName = value;
}
else
{
 mstrDictTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conDictType4GC.DictTypeName);
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
 AddUpdatedFld(conDictType4GC.UpdDate);
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
 AddUpdatedFld(conDictType4GC.UpdUser);
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
 AddUpdatedFld(conDictType4GC.Memo);
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
  return mstrDictTypeId;
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
  return mstrDictTypeName;
 }
 }
}
 /// <summary>
 /// 生成代码字典类型(DictType4GC)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conDictType4GC
{
public const string _CurrTabName = "DictType4GC"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "DictTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"DictTypeId", "DictTypeName", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"DictTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DictTypeId = "DictTypeId";    //字典类型Id

 /// <summary>
 /// 常量:"DictTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DictTypeName = "DictTypeName";    //字典类型名

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