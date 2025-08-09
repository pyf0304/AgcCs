
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjProcessTypeEN
 表名:PrjProcessType(00050026)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:10:09
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:需求管理(ProjectRequirementManage)
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
 /// 表PrjProcessType的关键字(PrjProcessTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PrjProcessTypeId_PrjProcessType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strPrjProcessTypeId">表关键字</param>
public K_PrjProcessTypeId_PrjProcessType(string strPrjProcessTypeId)
{
if (IsValid(strPrjProcessTypeId)) Value = strPrjProcessTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strPrjProcessTypeId)
{
if (string.IsNullOrEmpty(strPrjProcessTypeId) == true) return false;
if (strPrjProcessTypeId.Length > 2) return false;
if (strPrjProcessTypeId.IndexOf(' ') >= 0) return false;
if (strPrjProcessTypeId.IndexOf(')') >= 0) return false;
if (strPrjProcessTypeId.IndexOf('(') >= 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PrjProcessTypeId_PrjProcessType]类型的对象</returns>
public static implicit operator K_PrjProcessTypeId_PrjProcessType(string value)
{
return new K_PrjProcessTypeId_PrjProcessType(value);
}
}
 /// <summary>
 /// 项目过程分类(PrjProcessType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsPrjProcessTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "PrjProcessType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PrjProcessTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 3;
public static string[] _AttributeName = new string[] {"PrjProcessTypeId", "PrjProcessTypeName", "Memo"};

protected string mstrPrjProcessTypeId;    //项目过程分类ID
protected string mstrPrjProcessTypeName;    //项目过程分类名
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsPrjProcessTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PrjProcessTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strPrjProcessTypeId">关键字:项目过程分类ID</param>
public clsPrjProcessTypeEN(string strPrjProcessTypeId)
 {
strPrjProcessTypeId = strPrjProcessTypeId.Replace("'", "''");
if (strPrjProcessTypeId.Length > 2)
{
throw new Exception("在表:PrjProcessType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strPrjProcessTypeId)  ==  true)
{
throw new Exception("在表:PrjProcessType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPrjProcessTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrPrjProcessTypeId = strPrjProcessTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PrjProcessTypeId");
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
if (strAttributeName  ==  conPrjProcessType.PrjProcessTypeId)
{
return mstrPrjProcessTypeId;
}
else if (strAttributeName  ==  conPrjProcessType.PrjProcessTypeName)
{
return mstrPrjProcessTypeName;
}
else if (strAttributeName  ==  conPrjProcessType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conPrjProcessType.PrjProcessTypeId)
{
mstrPrjProcessTypeId = value.ToString();
 AddUpdatedFld(conPrjProcessType.PrjProcessTypeId);
}
else if (strAttributeName  ==  conPrjProcessType.PrjProcessTypeName)
{
mstrPrjProcessTypeName = value.ToString();
 AddUpdatedFld(conPrjProcessType.PrjProcessTypeName);
}
else if (strAttributeName  ==  conPrjProcessType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPrjProcessType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conPrjProcessType.PrjProcessTypeId  ==  _AttributeName[intIndex])
{
return mstrPrjProcessTypeId;
}
else if (conPrjProcessType.PrjProcessTypeName  ==  _AttributeName[intIndex])
{
return mstrPrjProcessTypeName;
}
else if (conPrjProcessType.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conPrjProcessType.PrjProcessTypeId  ==  _AttributeName[intIndex])
{
mstrPrjProcessTypeId = value.ToString();
 AddUpdatedFld(conPrjProcessType.PrjProcessTypeId);
}
else if (conPrjProcessType.PrjProcessTypeName  ==  _AttributeName[intIndex])
{
mstrPrjProcessTypeName = value.ToString();
 AddUpdatedFld(conPrjProcessType.PrjProcessTypeName);
}
else if (conPrjProcessType.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPrjProcessType.Memo);
}
}
}

/// <summary>
/// 项目过程分类ID(说明:;字段类型:varchar;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjProcessTypeId
{
get
{
return mstrPrjProcessTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjProcessTypeId = value;
}
else
{
 mstrPrjProcessTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjProcessType.PrjProcessTypeId);
}
}
/// <summary>
/// 项目过程分类名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjProcessTypeName
{
get
{
return mstrPrjProcessTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjProcessTypeName = value;
}
else
{
 mstrPrjProcessTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjProcessType.PrjProcessTypeName);
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
 AddUpdatedFld(conPrjProcessType.Memo);
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
  return mstrPrjProcessTypeId;
 }
 }
}
 /// <summary>
 /// 项目过程分类(PrjProcessType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conPrjProcessType
{
public const string _CurrTabName = "PrjProcessType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PrjProcessTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"PrjProcessTypeId", "PrjProcessTypeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"PrjProcessTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjProcessTypeId = "PrjProcessTypeId";    //项目过程分类ID

 /// <summary>
 /// 常量:"PrjProcessTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjProcessTypeName = "PrjProcessTypeName";    //项目过程分类名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}