
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDnMappingModeEN
 表名:DnMappingMode(00050571)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:37:23
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:AI模块(AIModule)
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
 /// 表DnMappingMode的关键字(MappingModeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_MappingModeId_DnMappingMode
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strMappingModeId">表关键字</param>
public K_MappingModeId_DnMappingMode(string strMappingModeId)
{
if (IsValid(strMappingModeId)) Value = strMappingModeId;
else
{
Value = null;
}
}
private static bool IsValid(string strMappingModeId)
{
if (string.IsNullOrEmpty(strMappingModeId) == true) return false;
if (strMappingModeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_MappingModeId_DnMappingMode]类型的对象</returns>
public static implicit operator K_MappingModeId_DnMappingMode(string value)
{
return new K_MappingModeId_DnMappingMode(value);
}
}
 /// <summary>
 /// 结点映射模式(DnMappingMode)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsDnMappingModeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "DnMappingMode"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "MappingModeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 6;
public static string[] _AttributeName = new string[] {"MappingModeId", "MappingModeName", "MappingModeENName", "UpdDate", "UpdUser", "Memo"};

protected string mstrMappingModeId;    //映射模式Id
protected string mstrMappingModeName;    //映射模式名
protected string mstrMappingModeENName;    //映射模式英文名
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsDnMappingModeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("MappingModeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strMappingModeId">关键字:映射模式Id</param>
public clsDnMappingModeEN(string strMappingModeId)
 {
strMappingModeId = strMappingModeId.Replace("'", "''");
if (strMappingModeId.Length > 2)
{
throw new Exception("在表:DnMappingMode中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strMappingModeId)  ==  true)
{
throw new Exception("在表:DnMappingMode中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strMappingModeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrMappingModeId = strMappingModeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("MappingModeId");
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
if (strAttributeName  ==  conDnMappingMode.MappingModeId)
{
return mstrMappingModeId;
}
else if (strAttributeName  ==  conDnMappingMode.MappingModeName)
{
return mstrMappingModeName;
}
else if (strAttributeName  ==  conDnMappingMode.MappingModeENName)
{
return mstrMappingModeENName;
}
else if (strAttributeName  ==  conDnMappingMode.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conDnMappingMode.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conDnMappingMode.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conDnMappingMode.MappingModeId)
{
mstrMappingModeId = value.ToString();
 AddUpdatedFld(conDnMappingMode.MappingModeId);
}
else if (strAttributeName  ==  conDnMappingMode.MappingModeName)
{
mstrMappingModeName = value.ToString();
 AddUpdatedFld(conDnMappingMode.MappingModeName);
}
else if (strAttributeName  ==  conDnMappingMode.MappingModeENName)
{
mstrMappingModeENName = value.ToString();
 AddUpdatedFld(conDnMappingMode.MappingModeENName);
}
else if (strAttributeName  ==  conDnMappingMode.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conDnMappingMode.UpdDate);
}
else if (strAttributeName  ==  conDnMappingMode.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conDnMappingMode.UpdUser);
}
else if (strAttributeName  ==  conDnMappingMode.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDnMappingMode.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conDnMappingMode.MappingModeId  ==  _AttributeName[intIndex])
{
return mstrMappingModeId;
}
else if (conDnMappingMode.MappingModeName  ==  _AttributeName[intIndex])
{
return mstrMappingModeName;
}
else if (conDnMappingMode.MappingModeENName  ==  _AttributeName[intIndex])
{
return mstrMappingModeENName;
}
else if (conDnMappingMode.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conDnMappingMode.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conDnMappingMode.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conDnMappingMode.MappingModeId  ==  _AttributeName[intIndex])
{
mstrMappingModeId = value.ToString();
 AddUpdatedFld(conDnMappingMode.MappingModeId);
}
else if (conDnMappingMode.MappingModeName  ==  _AttributeName[intIndex])
{
mstrMappingModeName = value.ToString();
 AddUpdatedFld(conDnMappingMode.MappingModeName);
}
else if (conDnMappingMode.MappingModeENName  ==  _AttributeName[intIndex])
{
mstrMappingModeENName = value.ToString();
 AddUpdatedFld(conDnMappingMode.MappingModeENName);
}
else if (conDnMappingMode.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conDnMappingMode.UpdDate);
}
else if (conDnMappingMode.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conDnMappingMode.UpdUser);
}
else if (conDnMappingMode.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDnMappingMode.Memo);
}
}
}

/// <summary>
/// 映射模式Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MappingModeId
{
get
{
return mstrMappingModeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMappingModeId = value;
}
else
{
 mstrMappingModeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conDnMappingMode.MappingModeId);
}
}
/// <summary>
/// 映射模式名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MappingModeName
{
get
{
return mstrMappingModeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMappingModeName = value;
}
else
{
 mstrMappingModeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conDnMappingMode.MappingModeName);
}
}
/// <summary>
/// 映射模式英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MappingModeENName
{
get
{
return mstrMappingModeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMappingModeENName = value;
}
else
{
 mstrMappingModeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conDnMappingMode.MappingModeENName);
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
 AddUpdatedFld(conDnMappingMode.UpdDate);
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
 AddUpdatedFld(conDnMappingMode.UpdUser);
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
 AddUpdatedFld(conDnMappingMode.Memo);
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
  return mstrMappingModeId;
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
  return mstrMappingModeName;
 }
 }
}
 /// <summary>
 /// 结点映射模式(DnMappingMode)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conDnMappingMode
{
public const string _CurrTabName = "DnMappingMode"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "MappingModeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"MappingModeId", "MappingModeName", "MappingModeENName", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"MappingModeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MappingModeId = "MappingModeId";    //映射模式Id

 /// <summary>
 /// 常量:"MappingModeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MappingModeName = "MappingModeName";    //映射模式名

 /// <summary>
 /// 常量:"MappingModeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MappingModeENName = "MappingModeENName";    //映射模式英文名

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