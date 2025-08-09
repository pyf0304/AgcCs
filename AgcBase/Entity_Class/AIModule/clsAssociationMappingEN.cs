
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsAssociationMappingEN
 表名:AssociationMapping(00050550)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:09:08
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
 /// 表AssociationMapping的关键字(AssociationMappingId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_AssociationMappingId_AssociationMapping
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strAssociationMappingId">表关键字</param>
public K_AssociationMappingId_AssociationMapping(string strAssociationMappingId)
{
if (IsValid(strAssociationMappingId)) Value = strAssociationMappingId;
else
{
Value = null;
}
}
private static bool IsValid(string strAssociationMappingId)
{
if (string.IsNullOrEmpty(strAssociationMappingId) == true) return false;
if (strAssociationMappingId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_AssociationMappingId_AssociationMapping]类型的对象</returns>
public static implicit operator K_AssociationMappingId_AssociationMapping(string value)
{
return new K_AssociationMappingId_AssociationMapping(value);
}
}
 /// <summary>
 /// 关联关系映射(AssociationMapping)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsAssociationMappingEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "AssociationMapping"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "AssociationMappingId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 6;
public static string[] _AttributeName = new string[] {"AssociationMappingId", "AssociationMappingName", "AssociationMappingENName", "UpdDate", "UpdUser", "Memo"};

protected string mstrAssociationMappingId;    //关联关系映射Id
protected string mstrAssociationMappingName;    //关联关系映射名
protected string mstrAssociationMappingENName;    //关联关系映射英文名
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsAssociationMappingEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("AssociationMappingId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strAssociationMappingId">关键字:关联关系映射Id</param>
public clsAssociationMappingEN(string strAssociationMappingId)
 {
strAssociationMappingId = strAssociationMappingId.Replace("'", "''");
if (strAssociationMappingId.Length > 2)
{
throw new Exception("在表:AssociationMapping中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strAssociationMappingId)  ==  true)
{
throw new Exception("在表:AssociationMapping中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strAssociationMappingId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrAssociationMappingId = strAssociationMappingId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("AssociationMappingId");
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
if (strAttributeName  ==  conAssociationMapping.AssociationMappingId)
{
return mstrAssociationMappingId;
}
else if (strAttributeName  ==  conAssociationMapping.AssociationMappingName)
{
return mstrAssociationMappingName;
}
else if (strAttributeName  ==  conAssociationMapping.AssociationMappingENName)
{
return mstrAssociationMappingENName;
}
else if (strAttributeName  ==  conAssociationMapping.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conAssociationMapping.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conAssociationMapping.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conAssociationMapping.AssociationMappingId)
{
mstrAssociationMappingId = value.ToString();
 AddUpdatedFld(conAssociationMapping.AssociationMappingId);
}
else if (strAttributeName  ==  conAssociationMapping.AssociationMappingName)
{
mstrAssociationMappingName = value.ToString();
 AddUpdatedFld(conAssociationMapping.AssociationMappingName);
}
else if (strAttributeName  ==  conAssociationMapping.AssociationMappingENName)
{
mstrAssociationMappingENName = value.ToString();
 AddUpdatedFld(conAssociationMapping.AssociationMappingENName);
}
else if (strAttributeName  ==  conAssociationMapping.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conAssociationMapping.UpdDate);
}
else if (strAttributeName  ==  conAssociationMapping.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conAssociationMapping.UpdUser);
}
else if (strAttributeName  ==  conAssociationMapping.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conAssociationMapping.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conAssociationMapping.AssociationMappingId  ==  _AttributeName[intIndex])
{
return mstrAssociationMappingId;
}
else if (conAssociationMapping.AssociationMappingName  ==  _AttributeName[intIndex])
{
return mstrAssociationMappingName;
}
else if (conAssociationMapping.AssociationMappingENName  ==  _AttributeName[intIndex])
{
return mstrAssociationMappingENName;
}
else if (conAssociationMapping.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conAssociationMapping.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conAssociationMapping.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conAssociationMapping.AssociationMappingId  ==  _AttributeName[intIndex])
{
mstrAssociationMappingId = value.ToString();
 AddUpdatedFld(conAssociationMapping.AssociationMappingId);
}
else if (conAssociationMapping.AssociationMappingName  ==  _AttributeName[intIndex])
{
mstrAssociationMappingName = value.ToString();
 AddUpdatedFld(conAssociationMapping.AssociationMappingName);
}
else if (conAssociationMapping.AssociationMappingENName  ==  _AttributeName[intIndex])
{
mstrAssociationMappingENName = value.ToString();
 AddUpdatedFld(conAssociationMapping.AssociationMappingENName);
}
else if (conAssociationMapping.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conAssociationMapping.UpdDate);
}
else if (conAssociationMapping.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conAssociationMapping.UpdUser);
}
else if (conAssociationMapping.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conAssociationMapping.Memo);
}
}
}

/// <summary>
/// 关联关系映射Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AssociationMappingId
{
get
{
return mstrAssociationMappingId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAssociationMappingId = value;
}
else
{
 mstrAssociationMappingId = value;
}
//记录修改过的字段
 AddUpdatedFld(conAssociationMapping.AssociationMappingId);
}
}
/// <summary>
/// 关联关系映射名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AssociationMappingName
{
get
{
return mstrAssociationMappingName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAssociationMappingName = value;
}
else
{
 mstrAssociationMappingName = value;
}
//记录修改过的字段
 AddUpdatedFld(conAssociationMapping.AssociationMappingName);
}
}
/// <summary>
/// 关联关系映射英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AssociationMappingENName
{
get
{
return mstrAssociationMappingENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAssociationMappingENName = value;
}
else
{
 mstrAssociationMappingENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conAssociationMapping.AssociationMappingENName);
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
 AddUpdatedFld(conAssociationMapping.UpdDate);
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
 AddUpdatedFld(conAssociationMapping.UpdUser);
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
 AddUpdatedFld(conAssociationMapping.Memo);
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
  return mstrAssociationMappingId;
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
  return mstrAssociationMappingName;
 }
 }
}
 /// <summary>
 /// 关联关系映射(AssociationMapping)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conAssociationMapping
{
public const string _CurrTabName = "AssociationMapping"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "AssociationMappingId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"AssociationMappingId", "AssociationMappingName", "AssociationMappingENName", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"AssociationMappingId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AssociationMappingId = "AssociationMappingId";    //关联关系映射Id

 /// <summary>
 /// 常量:"AssociationMappingName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AssociationMappingName = "AssociationMappingName";    //关联关系映射名

 /// <summary>
 /// 常量:"AssociationMappingENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AssociationMappingENName = "AssociationMappingENName";    //关联关系映射英文名

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