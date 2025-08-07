
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDDLItemsOptionEN
 表名:DDLItemsOption(00050059)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:35:18
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
 /// 表DDLItemsOption的关键字(DdlItemsOptionId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_DdlItemsOptionId_DDLItemsOption
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strDdlItemsOptionId">表关键字</param>
public K_DdlItemsOptionId_DDLItemsOption(string strDdlItemsOptionId)
{
if (IsValid(strDdlItemsOptionId)) Value = strDdlItemsOptionId;
else
{
Value = null;
}
}
private static bool IsValid(string strDdlItemsOptionId)
{
if (string.IsNullOrEmpty(strDdlItemsOptionId) == true) return false;
if (strDdlItemsOptionId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_DdlItemsOptionId_DDLItemsOption]类型的对象</returns>
public static implicit operator K_DdlItemsOptionId_DDLItemsOption(string value)
{
return new K_DdlItemsOptionId_DDLItemsOption(value);
}
}
 /// <summary>
 /// 下拉框列表选项(DDLItemsOption)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsDDLItemsOptionEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "DDLItemsOption"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "DdlItemsOptionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 4;
public static string[] _AttributeName = new string[] {"DdlItemsOptionId", "DdlItemsOptionName", "DdlItemsOptionENName", "Memo"};

protected string mstrDdlItemsOptionId;    //下拉框列表选项ID
protected string mstrDdlItemsOptionName;    //下拉选项名
protected string mstrDdlItemsOptionENName;    //下拉框列表选项英文名
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsDDLItemsOptionEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("DdlItemsOptionId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strDdlItemsOptionId">关键字:下拉框列表选项ID</param>
public clsDDLItemsOptionEN(string strDdlItemsOptionId)
 {
strDdlItemsOptionId = strDdlItemsOptionId.Replace("'", "''");
if (strDdlItemsOptionId.Length > 2)
{
throw new Exception("在表:DDLItemsOption中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strDdlItemsOptionId)  ==  true)
{
throw new Exception("在表:DDLItemsOption中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strDdlItemsOptionId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrDdlItemsOptionId = strDdlItemsOptionId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("DdlItemsOptionId");
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
if (strAttributeName  ==  conDDLItemsOption.DdlItemsOptionId)
{
return mstrDdlItemsOptionId;
}
else if (strAttributeName  ==  conDDLItemsOption.DdlItemsOptionName)
{
return mstrDdlItemsOptionName;
}
else if (strAttributeName  ==  conDDLItemsOption.DdlItemsOptionENName)
{
return mstrDdlItemsOptionENName;
}
else if (strAttributeName  ==  conDDLItemsOption.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conDDLItemsOption.DdlItemsOptionId)
{
mstrDdlItemsOptionId = value.ToString();
 AddUpdatedFld(conDDLItemsOption.DdlItemsOptionId);
}
else if (strAttributeName  ==  conDDLItemsOption.DdlItemsOptionName)
{
mstrDdlItemsOptionName = value.ToString();
 AddUpdatedFld(conDDLItemsOption.DdlItemsOptionName);
}
else if (strAttributeName  ==  conDDLItemsOption.DdlItemsOptionENName)
{
mstrDdlItemsOptionENName = value.ToString();
 AddUpdatedFld(conDDLItemsOption.DdlItemsOptionENName);
}
else if (strAttributeName  ==  conDDLItemsOption.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDDLItemsOption.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conDDLItemsOption.DdlItemsOptionId  ==  _AttributeName[intIndex])
{
return mstrDdlItemsOptionId;
}
else if (conDDLItemsOption.DdlItemsOptionName  ==  _AttributeName[intIndex])
{
return mstrDdlItemsOptionName;
}
else if (conDDLItemsOption.DdlItemsOptionENName  ==  _AttributeName[intIndex])
{
return mstrDdlItemsOptionENName;
}
else if (conDDLItemsOption.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conDDLItemsOption.DdlItemsOptionId  ==  _AttributeName[intIndex])
{
mstrDdlItemsOptionId = value.ToString();
 AddUpdatedFld(conDDLItemsOption.DdlItemsOptionId);
}
else if (conDDLItemsOption.DdlItemsOptionName  ==  _AttributeName[intIndex])
{
mstrDdlItemsOptionName = value.ToString();
 AddUpdatedFld(conDDLItemsOption.DdlItemsOptionName);
}
else if (conDDLItemsOption.DdlItemsOptionENName  ==  _AttributeName[intIndex])
{
mstrDdlItemsOptionENName = value.ToString();
 AddUpdatedFld(conDDLItemsOption.DdlItemsOptionENName);
}
else if (conDDLItemsOption.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDDLItemsOption.Memo);
}
}
}

/// <summary>
/// 下拉框列表选项ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DdlItemsOptionId
{
get
{
return mstrDdlItemsOptionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDdlItemsOptionId = value;
}
else
{
 mstrDdlItemsOptionId = value;
}
//记录修改过的字段
 AddUpdatedFld(conDDLItemsOption.DdlItemsOptionId);
}
}
/// <summary>
/// 下拉选项名(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DdlItemsOptionName
{
get
{
return mstrDdlItemsOptionName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDdlItemsOptionName = value;
}
else
{
 mstrDdlItemsOptionName = value;
}
//记录修改过的字段
 AddUpdatedFld(conDDLItemsOption.DdlItemsOptionName);
}
}
/// <summary>
/// 下拉框列表选项英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DdlItemsOptionENName
{
get
{
return mstrDdlItemsOptionENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDdlItemsOptionENName = value;
}
else
{
 mstrDdlItemsOptionENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conDDLItemsOption.DdlItemsOptionENName);
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
 AddUpdatedFld(conDDLItemsOption.Memo);
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
  return mstrDdlItemsOptionId;
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
  return mstrDdlItemsOptionName;
 }
 }
}
 /// <summary>
 /// 下拉框列表选项(DDLItemsOption)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conDDLItemsOption
{
public const string _CurrTabName = "DDLItemsOption"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "DdlItemsOptionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"DdlItemsOptionId", "DdlItemsOptionName", "DdlItemsOptionENName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"DdlItemsOptionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DdlItemsOptionId = "DdlItemsOptionId";    //下拉框列表选项ID

 /// <summary>
 /// 常量:"DdlItemsOptionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DdlItemsOptionName = "DdlItemsOptionName";    //下拉选项名

 /// <summary>
 /// 常量:"DdlItemsOptionENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DdlItemsOptionENName = "DdlItemsOptionENName";    //下拉框列表选项英文名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}