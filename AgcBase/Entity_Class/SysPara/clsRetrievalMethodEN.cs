
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsRetrievalMethodEN
 表名:RetrievalMethod(00050632)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:03:40
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统参数(SysPara)
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
 /// 表RetrievalMethod的关键字(RetrievalMethodId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_RetrievalMethodId_RetrievalMethod
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strRetrievalMethodId">表关键字</param>
public K_RetrievalMethodId_RetrievalMethod(string strRetrievalMethodId)
{
if (IsValid(strRetrievalMethodId)) Value = strRetrievalMethodId;
else
{
Value = null;
}
}
private static bool IsValid(string strRetrievalMethodId)
{
if (string.IsNullOrEmpty(strRetrievalMethodId) == true) return false;
if (strRetrievalMethodId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_RetrievalMethodId_RetrievalMethod]类型的对象</returns>
public static implicit operator K_RetrievalMethodId_RetrievalMethod(string value)
{
return new K_RetrievalMethodId_RetrievalMethod(value);
}
}
 /// <summary>
 /// 获取方式(RetrievalMethod)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsRetrievalMethodEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "RetrievalMethod"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "RetrievalMethodId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 6;
public static string[] _AttributeName = new string[] {"RetrievalMethodId", "RetrievalMethodName", "RetrievalMethodEnName", "UpdDate", "UpdUser", "Memo"};

protected string mstrRetrievalMethodId;    //获取方式Id
protected string mstrRetrievalMethodName;    //获取方式名
protected string mstrRetrievalMethodEnName;    //获取方式英文名
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsRetrievalMethodEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("RetrievalMethodId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strRetrievalMethodId">关键字:获取方式Id</param>
public clsRetrievalMethodEN(string strRetrievalMethodId)
 {
strRetrievalMethodId = strRetrievalMethodId.Replace("'", "''");
if (strRetrievalMethodId.Length > 2)
{
throw new Exception("在表:RetrievalMethod中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strRetrievalMethodId)  ==  true)
{
throw new Exception("在表:RetrievalMethod中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strRetrievalMethodId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrRetrievalMethodId = strRetrievalMethodId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("RetrievalMethodId");
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
if (strAttributeName  ==  conRetrievalMethod.RetrievalMethodId)
{
return mstrRetrievalMethodId;
}
else if (strAttributeName  ==  conRetrievalMethod.RetrievalMethodName)
{
return mstrRetrievalMethodName;
}
else if (strAttributeName  ==  conRetrievalMethod.RetrievalMethodEnName)
{
return mstrRetrievalMethodEnName;
}
else if (strAttributeName  ==  conRetrievalMethod.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conRetrievalMethod.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conRetrievalMethod.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conRetrievalMethod.RetrievalMethodId)
{
mstrRetrievalMethodId = value.ToString();
 AddUpdatedFld(conRetrievalMethod.RetrievalMethodId);
}
else if (strAttributeName  ==  conRetrievalMethod.RetrievalMethodName)
{
mstrRetrievalMethodName = value.ToString();
 AddUpdatedFld(conRetrievalMethod.RetrievalMethodName);
}
else if (strAttributeName  ==  conRetrievalMethod.RetrievalMethodEnName)
{
mstrRetrievalMethodEnName = value.ToString();
 AddUpdatedFld(conRetrievalMethod.RetrievalMethodEnName);
}
else if (strAttributeName  ==  conRetrievalMethod.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conRetrievalMethod.UpdDate);
}
else if (strAttributeName  ==  conRetrievalMethod.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conRetrievalMethod.UpdUser);
}
else if (strAttributeName  ==  conRetrievalMethod.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conRetrievalMethod.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conRetrievalMethod.RetrievalMethodId  ==  _AttributeName[intIndex])
{
return mstrRetrievalMethodId;
}
else if (conRetrievalMethod.RetrievalMethodName  ==  _AttributeName[intIndex])
{
return mstrRetrievalMethodName;
}
else if (conRetrievalMethod.RetrievalMethodEnName  ==  _AttributeName[intIndex])
{
return mstrRetrievalMethodEnName;
}
else if (conRetrievalMethod.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conRetrievalMethod.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conRetrievalMethod.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conRetrievalMethod.RetrievalMethodId  ==  _AttributeName[intIndex])
{
mstrRetrievalMethodId = value.ToString();
 AddUpdatedFld(conRetrievalMethod.RetrievalMethodId);
}
else if (conRetrievalMethod.RetrievalMethodName  ==  _AttributeName[intIndex])
{
mstrRetrievalMethodName = value.ToString();
 AddUpdatedFld(conRetrievalMethod.RetrievalMethodName);
}
else if (conRetrievalMethod.RetrievalMethodEnName  ==  _AttributeName[intIndex])
{
mstrRetrievalMethodEnName = value.ToString();
 AddUpdatedFld(conRetrievalMethod.RetrievalMethodEnName);
}
else if (conRetrievalMethod.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conRetrievalMethod.UpdDate);
}
else if (conRetrievalMethod.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conRetrievalMethod.UpdUser);
}
else if (conRetrievalMethod.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conRetrievalMethod.Memo);
}
}
}

/// <summary>
/// 获取方式Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RetrievalMethodId
{
get
{
return mstrRetrievalMethodId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRetrievalMethodId = value;
}
else
{
 mstrRetrievalMethodId = value;
}
//记录修改过的字段
 AddUpdatedFld(conRetrievalMethod.RetrievalMethodId);
}
}
/// <summary>
/// 获取方式名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RetrievalMethodName
{
get
{
return mstrRetrievalMethodName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRetrievalMethodName = value;
}
else
{
 mstrRetrievalMethodName = value;
}
//记录修改过的字段
 AddUpdatedFld(conRetrievalMethod.RetrievalMethodName);
}
}
/// <summary>
/// 获取方式英文名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RetrievalMethodEnName
{
get
{
return mstrRetrievalMethodEnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRetrievalMethodEnName = value;
}
else
{
 mstrRetrievalMethodEnName = value;
}
//记录修改过的字段
 AddUpdatedFld(conRetrievalMethod.RetrievalMethodEnName);
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
 AddUpdatedFld(conRetrievalMethod.UpdDate);
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
 AddUpdatedFld(conRetrievalMethod.UpdUser);
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
 AddUpdatedFld(conRetrievalMethod.Memo);
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
  return mstrRetrievalMethodId;
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
  return mstrRetrievalMethodName;
 }
 }
}
 /// <summary>
 /// 获取方式(RetrievalMethod)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conRetrievalMethod
{
public const string _CurrTabName = "RetrievalMethod"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "RetrievalMethodId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"RetrievalMethodId", "RetrievalMethodName", "RetrievalMethodEnName", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"RetrievalMethodId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RetrievalMethodId = "RetrievalMethodId";    //获取方式Id

 /// <summary>
 /// 常量:"RetrievalMethodName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RetrievalMethodName = "RetrievalMethodName";    //获取方式名

 /// <summary>
 /// 常量:"RetrievalMethodEnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RetrievalMethodEnName = "RetrievalMethodEnName";    //获取方式英文名

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