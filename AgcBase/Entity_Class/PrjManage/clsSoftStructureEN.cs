
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSoftStructureEN
 表名:SoftStructure(00050187)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:07:57
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:工程管理(PrjManage)
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
 /// 表SoftStructure的关键字(SoftStructureId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_SoftStructureId_SoftStructure
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strSoftStructureId">表关键字</param>
public K_SoftStructureId_SoftStructure(string strSoftStructureId)
{
if (IsValid(strSoftStructureId)) Value = strSoftStructureId;
else
{
Value = null;
}
}
private static bool IsValid(string strSoftStructureId)
{
if (string.IsNullOrEmpty(strSoftStructureId) == true) return false;
if (strSoftStructureId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_SoftStructureId_SoftStructure]类型的对象</returns>
public static implicit operator K_SoftStructureId_SoftStructure(string value)
{
return new K_SoftStructureId_SoftStructure(value);
}
}
 /// <summary>
 /// 软件架构(SoftStructure)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsSoftStructureEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "SoftStructure"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "SoftStructureId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 4;
public static string[] _AttributeName = new string[] {"SoftStructureId", "SoftStructureName", "SoftStructureDesc", "Memo"};

protected string mstrSoftStructureId;    //架构ID
protected string mstrSoftStructureName;    //架构名称
protected string mstrSoftStructureDesc;    //架构描述
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsSoftStructureEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("SoftStructureId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strSoftStructureId">关键字:架构ID</param>
public clsSoftStructureEN(string strSoftStructureId)
 {
strSoftStructureId = strSoftStructureId.Replace("'", "''");
if (strSoftStructureId.Length > 4)
{
throw new Exception("在表:SoftStructure中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strSoftStructureId)  ==  true)
{
throw new Exception("在表:SoftStructure中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strSoftStructureId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrSoftStructureId = strSoftStructureId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("SoftStructureId");
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
if (strAttributeName  ==  conSoftStructure.SoftStructureId)
{
return mstrSoftStructureId;
}
else if (strAttributeName  ==  conSoftStructure.SoftStructureName)
{
return mstrSoftStructureName;
}
else if (strAttributeName  ==  conSoftStructure.SoftStructureDesc)
{
return mstrSoftStructureDesc;
}
else if (strAttributeName  ==  conSoftStructure.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conSoftStructure.SoftStructureId)
{
mstrSoftStructureId = value.ToString();
 AddUpdatedFld(conSoftStructure.SoftStructureId);
}
else if (strAttributeName  ==  conSoftStructure.SoftStructureName)
{
mstrSoftStructureName = value.ToString();
 AddUpdatedFld(conSoftStructure.SoftStructureName);
}
else if (strAttributeName  ==  conSoftStructure.SoftStructureDesc)
{
mstrSoftStructureDesc = value.ToString();
 AddUpdatedFld(conSoftStructure.SoftStructureDesc);
}
else if (strAttributeName  ==  conSoftStructure.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSoftStructure.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conSoftStructure.SoftStructureId  ==  _AttributeName[intIndex])
{
return mstrSoftStructureId;
}
else if (conSoftStructure.SoftStructureName  ==  _AttributeName[intIndex])
{
return mstrSoftStructureName;
}
else if (conSoftStructure.SoftStructureDesc  ==  _AttributeName[intIndex])
{
return mstrSoftStructureDesc;
}
else if (conSoftStructure.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conSoftStructure.SoftStructureId  ==  _AttributeName[intIndex])
{
mstrSoftStructureId = value.ToString();
 AddUpdatedFld(conSoftStructure.SoftStructureId);
}
else if (conSoftStructure.SoftStructureName  ==  _AttributeName[intIndex])
{
mstrSoftStructureName = value.ToString();
 AddUpdatedFld(conSoftStructure.SoftStructureName);
}
else if (conSoftStructure.SoftStructureDesc  ==  _AttributeName[intIndex])
{
mstrSoftStructureDesc = value.ToString();
 AddUpdatedFld(conSoftStructure.SoftStructureDesc);
}
else if (conSoftStructure.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSoftStructure.Memo);
}
}
}

/// <summary>
/// 架构ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SoftStructureId
{
get
{
return mstrSoftStructureId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSoftStructureId = value;
}
else
{
 mstrSoftStructureId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSoftStructure.SoftStructureId);
}
}
/// <summary>
/// 架构名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SoftStructureName
{
get
{
return mstrSoftStructureName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSoftStructureName = value;
}
else
{
 mstrSoftStructureName = value;
}
//记录修改过的字段
 AddUpdatedFld(conSoftStructure.SoftStructureName);
}
}
/// <summary>
/// 架构描述(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SoftStructureDesc
{
get
{
return mstrSoftStructureDesc;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSoftStructureDesc = value;
}
else
{
 mstrSoftStructureDesc = value;
}
//记录修改过的字段
 AddUpdatedFld(conSoftStructure.SoftStructureDesc);
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
 AddUpdatedFld(conSoftStructure.Memo);
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
  return mstrSoftStructureId;
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
  return mstrSoftStructureName;
 }
 }
}
 /// <summary>
 /// 软件架构(SoftStructure)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conSoftStructure
{
public const string _CurrTabName = "SoftStructure"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "SoftStructureId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"SoftStructureId", "SoftStructureName", "SoftStructureDesc", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"SoftStructureId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SoftStructureId = "SoftStructureId";    //架构ID

 /// <summary>
 /// 常量:"SoftStructureName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SoftStructureName = "SoftStructureName";    //架构名称

 /// <summary>
 /// 常量:"SoftStructureDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SoftStructureDesc = "SoftStructureDesc";    //架构描述

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}