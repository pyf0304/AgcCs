
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsAssociationTypeEN
 表名:AssociationType(00050277)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:33:18
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
 /// 表AssociationType的关键字(AssociationTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_AssociationTypeId_AssociationType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strAssociationTypeId">表关键字</param>
public K_AssociationTypeId_AssociationType(string strAssociationTypeId)
{
if (IsValid(strAssociationTypeId)) Value = strAssociationTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strAssociationTypeId)
{
if (string.IsNullOrEmpty(strAssociationTypeId) == true) return false;
if (strAssociationTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_AssociationTypeId_AssociationType]类型的对象</returns>
public static implicit operator K_AssociationTypeId_AssociationType(string value)
{
return new K_AssociationTypeId_AssociationType(value);
}
}
 /// <summary>
 /// 关联表类型(AssociationType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsAssociationTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "AssociationType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "AssociationTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 3;
public static string[] _AttributeName = new string[] {"AssociationTypeId", "AssociationTypeName", "Memo"};

protected string mstrAssociationTypeId;    //关联类型Id
protected string mstrAssociationTypeName;    //关联类型名称
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsAssociationTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("AssociationTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strAssociationTypeId">关键字:关联类型Id</param>
public clsAssociationTypeEN(string strAssociationTypeId)
 {
strAssociationTypeId = strAssociationTypeId.Replace("'", "''");
if (strAssociationTypeId.Length > 2)
{
throw new Exception("在表:AssociationType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strAssociationTypeId)  ==  true)
{
throw new Exception("在表:AssociationType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strAssociationTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrAssociationTypeId = strAssociationTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("AssociationTypeId");
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
if (strAttributeName  ==  conAssociationType.AssociationTypeId)
{
return mstrAssociationTypeId;
}
else if (strAttributeName  ==  conAssociationType.AssociationTypeName)
{
return mstrAssociationTypeName;
}
else if (strAttributeName  ==  conAssociationType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conAssociationType.AssociationTypeId)
{
mstrAssociationTypeId = value.ToString();
 AddUpdatedFld(conAssociationType.AssociationTypeId);
}
else if (strAttributeName  ==  conAssociationType.AssociationTypeName)
{
mstrAssociationTypeName = value.ToString();
 AddUpdatedFld(conAssociationType.AssociationTypeName);
}
else if (strAttributeName  ==  conAssociationType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conAssociationType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conAssociationType.AssociationTypeId  ==  _AttributeName[intIndex])
{
return mstrAssociationTypeId;
}
else if (conAssociationType.AssociationTypeName  ==  _AttributeName[intIndex])
{
return mstrAssociationTypeName;
}
else if (conAssociationType.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conAssociationType.AssociationTypeId  ==  _AttributeName[intIndex])
{
mstrAssociationTypeId = value.ToString();
 AddUpdatedFld(conAssociationType.AssociationTypeId);
}
else if (conAssociationType.AssociationTypeName  ==  _AttributeName[intIndex])
{
mstrAssociationTypeName = value.ToString();
 AddUpdatedFld(conAssociationType.AssociationTypeName);
}
else if (conAssociationType.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conAssociationType.Memo);
}
}
}

/// <summary>
/// 关联类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AssociationTypeId
{
get
{
return mstrAssociationTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAssociationTypeId = value;
}
else
{
 mstrAssociationTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conAssociationType.AssociationTypeId);
}
}
/// <summary>
/// 关联类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AssociationTypeName
{
get
{
return mstrAssociationTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAssociationTypeName = value;
}
else
{
 mstrAssociationTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conAssociationType.AssociationTypeName);
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
 AddUpdatedFld(conAssociationType.Memo);
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
  return mstrAssociationTypeId;
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
  return mstrAssociationTypeName;
 }
 }
}
 /// <summary>
 /// 关联表类型(AssociationType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conAssociationType
{
public const string _CurrTabName = "AssociationType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "AssociationTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"AssociationTypeId", "AssociationTypeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"AssociationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AssociationTypeId = "AssociationTypeId";    //关联类型Id

 /// <summary>
 /// 常量:"AssociationTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AssociationTypeName = "AssociationTypeName";    //关联类型名称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}