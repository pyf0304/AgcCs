
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDict4GCEN
 表名:Dict4GC(00050351)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:09:56
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
 /// 表Dict4GC的关键字(DictId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_DictId_Dict4GC
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strDictId">表关键字</param>
public K_DictId_Dict4GC(string strDictId)
{
if (IsValid(strDictId)) Value = strDictId;
else
{
Value = null;
}
}
private static bool IsValid(string strDictId)
{
if (string.IsNullOrEmpty(strDictId) == true) return false;
if (strDictId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_DictId_Dict4GC]类型的对象</returns>
public static implicit operator K_DictId_Dict4GC(string value)
{
return new K_DictId_Dict4GC(value);
}
}
 /// <summary>
 /// 生成代码字典(Dict4GC)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsDict4GCEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "Dict4GC"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "DictId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 8;
public static string[] _AttributeName = new string[] {"DictId", "DictValue", "DictTypeId", "DictKey1", "DictKey2", "UpdDate", "UpdUser", "Memo"};

protected string mstrDictId;    //字典Id
protected string mstrDictValue;    //字典值
protected string mstrDictTypeId;    //字典类型Id
protected string mstrDictKey1;    //字典关键字1
protected string mstrDictKey2;    //字典关键字2
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsDict4GCEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("DictId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strDictId">关键字:字典Id</param>
public clsDict4GCEN(string strDictId)
 {
strDictId = strDictId.Replace("'", "''");
if (strDictId.Length > 8)
{
throw new Exception("在表:Dict4GC中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strDictId)  ==  true)
{
throw new Exception("在表:Dict4GC中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strDictId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrDictId = strDictId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("DictId");
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
if (strAttributeName  ==  conDict4GC.DictId)
{
return mstrDictId;
}
else if (strAttributeName  ==  conDict4GC.DictValue)
{
return mstrDictValue;
}
else if (strAttributeName  ==  conDict4GC.DictTypeId)
{
return mstrDictTypeId;
}
else if (strAttributeName  ==  conDict4GC.DictKey1)
{
return mstrDictKey1;
}
else if (strAttributeName  ==  conDict4GC.DictKey2)
{
return mstrDictKey2;
}
else if (strAttributeName  ==  conDict4GC.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conDict4GC.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conDict4GC.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conDict4GC.DictId)
{
mstrDictId = value.ToString();
 AddUpdatedFld(conDict4GC.DictId);
}
else if (strAttributeName  ==  conDict4GC.DictValue)
{
mstrDictValue = value.ToString();
 AddUpdatedFld(conDict4GC.DictValue);
}
else if (strAttributeName  ==  conDict4GC.DictTypeId)
{
mstrDictTypeId = value.ToString();
 AddUpdatedFld(conDict4GC.DictTypeId);
}
else if (strAttributeName  ==  conDict4GC.DictKey1)
{
mstrDictKey1 = value.ToString();
 AddUpdatedFld(conDict4GC.DictKey1);
}
else if (strAttributeName  ==  conDict4GC.DictKey2)
{
mstrDictKey2 = value.ToString();
 AddUpdatedFld(conDict4GC.DictKey2);
}
else if (strAttributeName  ==  conDict4GC.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conDict4GC.UpdDate);
}
else if (strAttributeName  ==  conDict4GC.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conDict4GC.UpdUser);
}
else if (strAttributeName  ==  conDict4GC.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDict4GC.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conDict4GC.DictId  ==  _AttributeName[intIndex])
{
return mstrDictId;
}
else if (conDict4GC.DictValue  ==  _AttributeName[intIndex])
{
return mstrDictValue;
}
else if (conDict4GC.DictTypeId  ==  _AttributeName[intIndex])
{
return mstrDictTypeId;
}
else if (conDict4GC.DictKey1  ==  _AttributeName[intIndex])
{
return mstrDictKey1;
}
else if (conDict4GC.DictKey2  ==  _AttributeName[intIndex])
{
return mstrDictKey2;
}
else if (conDict4GC.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conDict4GC.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conDict4GC.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conDict4GC.DictId  ==  _AttributeName[intIndex])
{
mstrDictId = value.ToString();
 AddUpdatedFld(conDict4GC.DictId);
}
else if (conDict4GC.DictValue  ==  _AttributeName[intIndex])
{
mstrDictValue = value.ToString();
 AddUpdatedFld(conDict4GC.DictValue);
}
else if (conDict4GC.DictTypeId  ==  _AttributeName[intIndex])
{
mstrDictTypeId = value.ToString();
 AddUpdatedFld(conDict4GC.DictTypeId);
}
else if (conDict4GC.DictKey1  ==  _AttributeName[intIndex])
{
mstrDictKey1 = value.ToString();
 AddUpdatedFld(conDict4GC.DictKey1);
}
else if (conDict4GC.DictKey2  ==  _AttributeName[intIndex])
{
mstrDictKey2 = value.ToString();
 AddUpdatedFld(conDict4GC.DictKey2);
}
else if (conDict4GC.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conDict4GC.UpdDate);
}
else if (conDict4GC.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conDict4GC.UpdUser);
}
else if (conDict4GC.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDict4GC.Memo);
}
}
}

/// <summary>
/// 字典Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DictId
{
get
{
return mstrDictId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDictId = value;
}
else
{
 mstrDictId = value;
}
//记录修改过的字段
 AddUpdatedFld(conDict4GC.DictId);
}
}
/// <summary>
/// 字典值(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DictValue
{
get
{
return mstrDictValue;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDictValue = value;
}
else
{
 mstrDictValue = value;
}
//记录修改过的字段
 AddUpdatedFld(conDict4GC.DictValue);
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
 AddUpdatedFld(conDict4GC.DictTypeId);
}
}
/// <summary>
/// 字典关键字1(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DictKey1
{
get
{
return mstrDictKey1;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDictKey1 = value;
}
else
{
 mstrDictKey1 = value;
}
//记录修改过的字段
 AddUpdatedFld(conDict4GC.DictKey1);
}
}
/// <summary>
/// 字典关键字2(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DictKey2
{
get
{
return mstrDictKey2;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDictKey2 = value;
}
else
{
 mstrDictKey2 = value;
}
//记录修改过的字段
 AddUpdatedFld(conDict4GC.DictKey2);
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
 AddUpdatedFld(conDict4GC.UpdDate);
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
 AddUpdatedFld(conDict4GC.UpdUser);
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
 AddUpdatedFld(conDict4GC.Memo);
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
  return mstrDictId;
 }
 }
}
 /// <summary>
 /// 生成代码字典(Dict4GC)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conDict4GC
{
public const string _CurrTabName = "Dict4GC"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "DictId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"DictId", "DictValue", "DictTypeId", "DictKey1", "DictKey2", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"DictId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DictId = "DictId";    //字典Id

 /// <summary>
 /// 常量:"DictValue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DictValue = "DictValue";    //字典值

 /// <summary>
 /// 常量:"DictTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DictTypeId = "DictTypeId";    //字典类型Id

 /// <summary>
 /// 常量:"DictKey1"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DictKey1 = "DictKey1";    //字典关键字1

 /// <summary>
 /// 常量:"DictKey2"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DictKey2 = "DictKey2";    //字典关键字2

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