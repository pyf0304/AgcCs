
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCMRequirementTypeEN
 表名:CMRequirementType(00050082)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:10:11
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:代码管理(CodeMan)
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
 /// 表CMRequirementType的关键字(RequirementTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_RequirementTypeId_CMRequirementType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strRequirementTypeId">表关键字</param>
public K_RequirementTypeId_CMRequirementType(string strRequirementTypeId)
{
if (IsValid(strRequirementTypeId)) Value = strRequirementTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strRequirementTypeId)
{
if (string.IsNullOrEmpty(strRequirementTypeId) == true) return false;
if (strRequirementTypeId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_RequirementTypeId_CMRequirementType]类型的对象</returns>
public static implicit operator K_RequirementTypeId_CMRequirementType(string value)
{
return new K_RequirementTypeId_CMRequirementType(value);
}
}
 /// <summary>
 /// 需求类型(CMRequirementType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCMRequirementTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CMRequirementType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "RequirementTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 4;
public static string[] _AttributeName = new string[] {"RequirementTypeId", "RequirementTypeName", "RequirementTypeENName", "Memo"};

protected string mstrRequirementTypeId;    //需求类型Id
protected string mstrRequirementTypeName;    //需求类型名
protected string mstrRequirementTypeENName;    //需求类型英文名
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsCMRequirementTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("RequirementTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strRequirementTypeId">关键字:需求类型Id</param>
public clsCMRequirementTypeEN(string strRequirementTypeId)
 {
strRequirementTypeId = strRequirementTypeId.Replace("'", "''");
if (strRequirementTypeId.Length > 4)
{
throw new Exception("在表:CMRequirementType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strRequirementTypeId)  ==  true)
{
throw new Exception("在表:CMRequirementType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strRequirementTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrRequirementTypeId = strRequirementTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("RequirementTypeId");
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
if (strAttributeName  ==  conCMRequirementType.RequirementTypeId)
{
return mstrRequirementTypeId;
}
else if (strAttributeName  ==  conCMRequirementType.RequirementTypeName)
{
return mstrRequirementTypeName;
}
else if (strAttributeName  ==  conCMRequirementType.RequirementTypeENName)
{
return mstrRequirementTypeENName;
}
else if (strAttributeName  ==  conCMRequirementType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conCMRequirementType.RequirementTypeId)
{
mstrRequirementTypeId = value.ToString();
 AddUpdatedFld(conCMRequirementType.RequirementTypeId);
}
else if (strAttributeName  ==  conCMRequirementType.RequirementTypeName)
{
mstrRequirementTypeName = value.ToString();
 AddUpdatedFld(conCMRequirementType.RequirementTypeName);
}
else if (strAttributeName  ==  conCMRequirementType.RequirementTypeENName)
{
mstrRequirementTypeENName = value.ToString();
 AddUpdatedFld(conCMRequirementType.RequirementTypeENName);
}
else if (strAttributeName  ==  conCMRequirementType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCMRequirementType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conCMRequirementType.RequirementTypeId  ==  _AttributeName[intIndex])
{
return mstrRequirementTypeId;
}
else if (conCMRequirementType.RequirementTypeName  ==  _AttributeName[intIndex])
{
return mstrRequirementTypeName;
}
else if (conCMRequirementType.RequirementTypeENName  ==  _AttributeName[intIndex])
{
return mstrRequirementTypeENName;
}
else if (conCMRequirementType.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conCMRequirementType.RequirementTypeId  ==  _AttributeName[intIndex])
{
mstrRequirementTypeId = value.ToString();
 AddUpdatedFld(conCMRequirementType.RequirementTypeId);
}
else if (conCMRequirementType.RequirementTypeName  ==  _AttributeName[intIndex])
{
mstrRequirementTypeName = value.ToString();
 AddUpdatedFld(conCMRequirementType.RequirementTypeName);
}
else if (conCMRequirementType.RequirementTypeENName  ==  _AttributeName[intIndex])
{
mstrRequirementTypeENName = value.ToString();
 AddUpdatedFld(conCMRequirementType.RequirementTypeENName);
}
else if (conCMRequirementType.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCMRequirementType.Memo);
}
}
}

/// <summary>
/// 需求类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RequirementTypeId
{
get
{
return mstrRequirementTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRequirementTypeId = value;
}
else
{
 mstrRequirementTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCMRequirementType.RequirementTypeId);
}
}
/// <summary>
/// 需求类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RequirementTypeName
{
get
{
return mstrRequirementTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRequirementTypeName = value;
}
else
{
 mstrRequirementTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conCMRequirementType.RequirementTypeName);
}
}
/// <summary>
/// 需求类型英文名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RequirementTypeENName
{
get
{
return mstrRequirementTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRequirementTypeENName = value;
}
else
{
 mstrRequirementTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conCMRequirementType.RequirementTypeENName);
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
 AddUpdatedFld(conCMRequirementType.Memo);
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
  return mstrRequirementTypeId;
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
  return mstrRequirementTypeName;
 }
 }
}
 /// <summary>
 /// 需求类型(CMRequirementType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCMRequirementType
{
public const string _CurrTabName = "CMRequirementType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "RequirementTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"RequirementTypeId", "RequirementTypeName", "RequirementTypeENName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"RequirementTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RequirementTypeId = "RequirementTypeId";    //需求类型Id

 /// <summary>
 /// 常量:"RequirementTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RequirementTypeName = "RequirementTypeName";    //需求类型名

 /// <summary>
 /// 常量:"RequirementTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RequirementTypeENName = "RequirementTypeENName";    //需求类型英文名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}