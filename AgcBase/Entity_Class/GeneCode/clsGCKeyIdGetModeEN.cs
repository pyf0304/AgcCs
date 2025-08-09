
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsGCKeyIdGetModeEN
 表名:GCKeyIdGetMode(00050562)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:02:18
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
 /// 表GCKeyIdGetMode的关键字(KeyIdGetModeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_KeyIdGetModeId_GCKeyIdGetMode
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strKeyIdGetModeId">表关键字</param>
public K_KeyIdGetModeId_GCKeyIdGetMode(string strKeyIdGetModeId)
{
if (IsValid(strKeyIdGetModeId)) Value = strKeyIdGetModeId;
else
{
Value = null;
}
}
private static bool IsValid(string strKeyIdGetModeId)
{
if (string.IsNullOrEmpty(strKeyIdGetModeId) == true) return false;
if (strKeyIdGetModeId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_KeyIdGetModeId_GCKeyIdGetMode]类型的对象</returns>
public static implicit operator K_KeyIdGetModeId_GCKeyIdGetMode(string value)
{
return new K_KeyIdGetModeId_GCKeyIdGetMode(value);
}
}
 /// <summary>
 /// GC关键字获取方式(GCKeyIdGetMode)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsGCKeyIdGetModeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "GCKeyIdGetMode"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "KeyIdGetModeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 6;
public static string[] _AttributeName = new string[] {"KeyIdGetModeId", "KeyIdGetModeName", "KeyIdGetModeENName", "UpdDate", "UpdUser", "Memo"};

protected string mstrKeyIdGetModeId;    //GC关键字获取方式Id
protected string mstrKeyIdGetModeName;    //GC关键字获取方式名
protected string mstrKeyIdGetModeENName;    //GC关键字获取方式英文名
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsGCKeyIdGetModeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("KeyIdGetModeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strKeyIdGetModeId">关键字:GC关键字获取方式Id</param>
public clsGCKeyIdGetModeEN(string strKeyIdGetModeId)
 {
strKeyIdGetModeId = strKeyIdGetModeId.Replace("'", "''");
if (strKeyIdGetModeId.Length > 4)
{
throw new Exception("在表:GCKeyIdGetMode中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strKeyIdGetModeId)  ==  true)
{
throw new Exception("在表:GCKeyIdGetMode中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strKeyIdGetModeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrKeyIdGetModeId = strKeyIdGetModeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("KeyIdGetModeId");
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
if (strAttributeName  ==  conGCKeyIdGetMode.KeyIdGetModeId)
{
return mstrKeyIdGetModeId;
}
else if (strAttributeName  ==  conGCKeyIdGetMode.KeyIdGetModeName)
{
return mstrKeyIdGetModeName;
}
else if (strAttributeName  ==  conGCKeyIdGetMode.KeyIdGetModeENName)
{
return mstrKeyIdGetModeENName;
}
else if (strAttributeName  ==  conGCKeyIdGetMode.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conGCKeyIdGetMode.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conGCKeyIdGetMode.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conGCKeyIdGetMode.KeyIdGetModeId)
{
mstrKeyIdGetModeId = value.ToString();
 AddUpdatedFld(conGCKeyIdGetMode.KeyIdGetModeId);
}
else if (strAttributeName  ==  conGCKeyIdGetMode.KeyIdGetModeName)
{
mstrKeyIdGetModeName = value.ToString();
 AddUpdatedFld(conGCKeyIdGetMode.KeyIdGetModeName);
}
else if (strAttributeName  ==  conGCKeyIdGetMode.KeyIdGetModeENName)
{
mstrKeyIdGetModeENName = value.ToString();
 AddUpdatedFld(conGCKeyIdGetMode.KeyIdGetModeENName);
}
else if (strAttributeName  ==  conGCKeyIdGetMode.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conGCKeyIdGetMode.UpdDate);
}
else if (strAttributeName  ==  conGCKeyIdGetMode.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conGCKeyIdGetMode.UpdUser);
}
else if (strAttributeName  ==  conGCKeyIdGetMode.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conGCKeyIdGetMode.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conGCKeyIdGetMode.KeyIdGetModeId  ==  _AttributeName[intIndex])
{
return mstrKeyIdGetModeId;
}
else if (conGCKeyIdGetMode.KeyIdGetModeName  ==  _AttributeName[intIndex])
{
return mstrKeyIdGetModeName;
}
else if (conGCKeyIdGetMode.KeyIdGetModeENName  ==  _AttributeName[intIndex])
{
return mstrKeyIdGetModeENName;
}
else if (conGCKeyIdGetMode.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conGCKeyIdGetMode.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conGCKeyIdGetMode.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conGCKeyIdGetMode.KeyIdGetModeId  ==  _AttributeName[intIndex])
{
mstrKeyIdGetModeId = value.ToString();
 AddUpdatedFld(conGCKeyIdGetMode.KeyIdGetModeId);
}
else if (conGCKeyIdGetMode.KeyIdGetModeName  ==  _AttributeName[intIndex])
{
mstrKeyIdGetModeName = value.ToString();
 AddUpdatedFld(conGCKeyIdGetMode.KeyIdGetModeName);
}
else if (conGCKeyIdGetMode.KeyIdGetModeENName  ==  _AttributeName[intIndex])
{
mstrKeyIdGetModeENName = value.ToString();
 AddUpdatedFld(conGCKeyIdGetMode.KeyIdGetModeENName);
}
else if (conGCKeyIdGetMode.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conGCKeyIdGetMode.UpdDate);
}
else if (conGCKeyIdGetMode.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conGCKeyIdGetMode.UpdUser);
}
else if (conGCKeyIdGetMode.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conGCKeyIdGetMode.Memo);
}
}
}

/// <summary>
/// GC关键字获取方式Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KeyIdGetModeId
{
get
{
return mstrKeyIdGetModeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeyIdGetModeId = value;
}
else
{
 mstrKeyIdGetModeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conGCKeyIdGetMode.KeyIdGetModeId);
}
}
/// <summary>
/// GC关键字获取方式名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KeyIdGetModeName
{
get
{
return mstrKeyIdGetModeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeyIdGetModeName = value;
}
else
{
 mstrKeyIdGetModeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conGCKeyIdGetMode.KeyIdGetModeName);
}
}
/// <summary>
/// GC关键字获取方式英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KeyIdGetModeENName
{
get
{
return mstrKeyIdGetModeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeyIdGetModeENName = value;
}
else
{
 mstrKeyIdGetModeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conGCKeyIdGetMode.KeyIdGetModeENName);
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
 AddUpdatedFld(conGCKeyIdGetMode.UpdDate);
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
 AddUpdatedFld(conGCKeyIdGetMode.UpdUser);
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
 AddUpdatedFld(conGCKeyIdGetMode.Memo);
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
  return mstrKeyIdGetModeId;
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
  return mstrKeyIdGetModeName;
 }
 }
}
 /// <summary>
 /// GC关键字获取方式(GCKeyIdGetMode)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conGCKeyIdGetMode
{
public const string _CurrTabName = "GCKeyIdGetMode"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "KeyIdGetModeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"KeyIdGetModeId", "KeyIdGetModeName", "KeyIdGetModeENName", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"KeyIdGetModeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KeyIdGetModeId = "KeyIdGetModeId";    //GC关键字获取方式Id

 /// <summary>
 /// 常量:"KeyIdGetModeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KeyIdGetModeName = "KeyIdGetModeName";    //GC关键字获取方式名

 /// <summary>
 /// 常量:"KeyIdGetModeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KeyIdGetModeENName = "KeyIdGetModeENName";    //GC关键字获取方式英文名

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