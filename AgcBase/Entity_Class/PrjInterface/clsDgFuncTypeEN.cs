
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDgFuncTypeEN
 表名:DgFuncType(00050114)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:04:19
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:界面管理(PrjInterface)
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
 /// 表DgFuncType的关键字(DgFuncTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_DgFuncTypeId_DgFuncType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strDgFuncTypeId">表关键字</param>
public K_DgFuncTypeId_DgFuncType(string strDgFuncTypeId)
{
if (IsValid(strDgFuncTypeId)) Value = strDgFuncTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strDgFuncTypeId)
{
if (string.IsNullOrEmpty(strDgFuncTypeId) == true) return false;
if (strDgFuncTypeId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_DgFuncTypeId_DgFuncType]类型的对象</returns>
public static implicit operator K_DgFuncTypeId_DgFuncType(string value)
{
return new K_DgFuncTypeId_DgFuncType(value);
}
}
 /// <summary>
 /// DG功能类型(DgFuncType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsDgFuncTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "DgFuncType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "DgFuncTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 4;
public static string[] _AttributeName = new string[] {"DgFuncTypeId", "DgFuncTypeName", "DgFuncTypeENName", "Memo"};

protected string mstrDgFuncTypeId;    //Dg功能类型Id
protected string mstrDgFuncTypeName;    //Dg功能类型名
protected string mstrDgFuncTypeENName;    //Dg功能类型名
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsDgFuncTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("DgFuncTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strDgFuncTypeId">关键字:Dg功能类型Id</param>
public clsDgFuncTypeEN(string strDgFuncTypeId)
 {
strDgFuncTypeId = strDgFuncTypeId.Replace("'", "''");
if (strDgFuncTypeId.Length > 4)
{
throw new Exception("在表:DgFuncType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strDgFuncTypeId)  ==  true)
{
throw new Exception("在表:DgFuncType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strDgFuncTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrDgFuncTypeId = strDgFuncTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("DgFuncTypeId");
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
if (strAttributeName  ==  conDgFuncType.DgFuncTypeId)
{
return mstrDgFuncTypeId;
}
else if (strAttributeName  ==  conDgFuncType.DgFuncTypeName)
{
return mstrDgFuncTypeName;
}
else if (strAttributeName  ==  conDgFuncType.DgFuncTypeENName)
{
return mstrDgFuncTypeENName;
}
else if (strAttributeName  ==  conDgFuncType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conDgFuncType.DgFuncTypeId)
{
mstrDgFuncTypeId = value.ToString();
 AddUpdatedFld(conDgFuncType.DgFuncTypeId);
}
else if (strAttributeName  ==  conDgFuncType.DgFuncTypeName)
{
mstrDgFuncTypeName = value.ToString();
 AddUpdatedFld(conDgFuncType.DgFuncTypeName);
}
else if (strAttributeName  ==  conDgFuncType.DgFuncTypeENName)
{
mstrDgFuncTypeENName = value.ToString();
 AddUpdatedFld(conDgFuncType.DgFuncTypeENName);
}
else if (strAttributeName  ==  conDgFuncType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDgFuncType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conDgFuncType.DgFuncTypeId  ==  _AttributeName[intIndex])
{
return mstrDgFuncTypeId;
}
else if (conDgFuncType.DgFuncTypeName  ==  _AttributeName[intIndex])
{
return mstrDgFuncTypeName;
}
else if (conDgFuncType.DgFuncTypeENName  ==  _AttributeName[intIndex])
{
return mstrDgFuncTypeENName;
}
else if (conDgFuncType.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conDgFuncType.DgFuncTypeId  ==  _AttributeName[intIndex])
{
mstrDgFuncTypeId = value.ToString();
 AddUpdatedFld(conDgFuncType.DgFuncTypeId);
}
else if (conDgFuncType.DgFuncTypeName  ==  _AttributeName[intIndex])
{
mstrDgFuncTypeName = value.ToString();
 AddUpdatedFld(conDgFuncType.DgFuncTypeName);
}
else if (conDgFuncType.DgFuncTypeENName  ==  _AttributeName[intIndex])
{
mstrDgFuncTypeENName = value.ToString();
 AddUpdatedFld(conDgFuncType.DgFuncTypeENName);
}
else if (conDgFuncType.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDgFuncType.Memo);
}
}
}

/// <summary>
/// Dg功能类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DgFuncTypeId
{
get
{
return mstrDgFuncTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDgFuncTypeId = value;
}
else
{
 mstrDgFuncTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conDgFuncType.DgFuncTypeId);
}
}
/// <summary>
/// Dg功能类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DgFuncTypeName
{
get
{
return mstrDgFuncTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDgFuncTypeName = value;
}
else
{
 mstrDgFuncTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conDgFuncType.DgFuncTypeName);
}
}
/// <summary>
/// Dg功能类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DgFuncTypeENName
{
get
{
return mstrDgFuncTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDgFuncTypeENName = value;
}
else
{
 mstrDgFuncTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conDgFuncType.DgFuncTypeENName);
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
 AddUpdatedFld(conDgFuncType.Memo);
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
  return mstrDgFuncTypeId;
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
  return mstrDgFuncTypeName;
 }
 }
}
 /// <summary>
 /// DG功能类型(DgFuncType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conDgFuncType
{
public const string _CurrTabName = "DgFuncType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "DgFuncTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"DgFuncTypeId", "DgFuncTypeName", "DgFuncTypeENName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"DgFuncTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DgFuncTypeId = "DgFuncTypeId";    //Dg功能类型Id

 /// <summary>
 /// 常量:"DgFuncTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DgFuncTypeName = "DgFuncTypeName";    //Dg功能类型名

 /// <summary>
 /// 常量:"DgFuncTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DgFuncTypeENName = "DgFuncTypeENName";    //Dg功能类型名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}