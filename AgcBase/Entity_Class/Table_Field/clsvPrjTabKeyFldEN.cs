
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjTabKeyFldEN
 表名:vPrjTabKeyFld(00050286)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:07:21
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
 /// 表vPrjTabKeyFld的关键字(TabId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TabId_vPrjTabKeyFld
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strTabId">表关键字</param>
public K_TabId_vPrjTabKeyFld(string strTabId)
{
if (IsValid(strTabId)) Value = strTabId;
else
{
Value = null;
}
}
private static bool IsValid(string strTabId)
{
if (string.IsNullOrEmpty(strTabId) == true) return false;
if (strTabId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_TabId_vPrjTabKeyFld]类型的对象</returns>
public static implicit operator K_TabId_vPrjTabKeyFld(string value)
{
return new K_TabId_vPrjTabKeyFld(value);
}
}
 /// <summary>
 /// vPrjTabKeyFld(vPrjTabKeyFld)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvPrjTabKeyFldEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vPrjTabKeyFld"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TabId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 7;
public static string[] _AttributeName = new string[] {"TabId", "FldId", "FieldTypeId", "PrimaryTypeId", "PrimaryTypeName", "KeyFldName", "PrjId"};

protected string mstrTabId;    //表ID
protected string mstrFldId;    //字段Id
protected string mstrFieldTypeId;    //字段类型Id
protected string mstrPrimaryTypeId;    //主键类型ID
protected string mstrPrimaryTypeName;    //主键类型名
protected string mstrKeyFldName;    //关键字段名
protected string mstrPrjId;    //工程Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvPrjTabKeyFldEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TabId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strTabId">关键字:表ID</param>
public clsvPrjTabKeyFldEN(string strTabId)
 {
strTabId = strTabId.Replace("'", "''");
if (strTabId.Length > 8)
{
throw new Exception("在表:vPrjTabKeyFld中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTabId)  ==  true)
{
throw new Exception("在表:vPrjTabKeyFld中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTabId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrTabId = strTabId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TabId");
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
if (strAttributeName  ==  convPrjTabKeyFld.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  convPrjTabKeyFld.FldId)
{
return mstrFldId;
}
else if (strAttributeName  ==  convPrjTabKeyFld.FieldTypeId)
{
return mstrFieldTypeId;
}
else if (strAttributeName  ==  convPrjTabKeyFld.PrimaryTypeId)
{
return mstrPrimaryTypeId;
}
else if (strAttributeName  ==  convPrjTabKeyFld.PrimaryTypeName)
{
return mstrPrimaryTypeName;
}
else if (strAttributeName  ==  convPrjTabKeyFld.KeyFldName)
{
return mstrKeyFldName;
}
else if (strAttributeName  ==  convPrjTabKeyFld.PrjId)
{
return mstrPrjId;
}
return null;
}
set
{
if (strAttributeName  ==  convPrjTabKeyFld.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(convPrjTabKeyFld.TabId);
}
else if (strAttributeName  ==  convPrjTabKeyFld.FldId)
{
mstrFldId = value.ToString();
 AddUpdatedFld(convPrjTabKeyFld.FldId);
}
else if (strAttributeName  ==  convPrjTabKeyFld.FieldTypeId)
{
mstrFieldTypeId = value.ToString();
 AddUpdatedFld(convPrjTabKeyFld.FieldTypeId);
}
else if (strAttributeName  ==  convPrjTabKeyFld.PrimaryTypeId)
{
mstrPrimaryTypeId = value.ToString();
 AddUpdatedFld(convPrjTabKeyFld.PrimaryTypeId);
}
else if (strAttributeName  ==  convPrjTabKeyFld.PrimaryTypeName)
{
mstrPrimaryTypeName = value.ToString();
 AddUpdatedFld(convPrjTabKeyFld.PrimaryTypeName);
}
else if (strAttributeName  ==  convPrjTabKeyFld.KeyFldName)
{
mstrKeyFldName = value.ToString();
 AddUpdatedFld(convPrjTabKeyFld.KeyFldName);
}
else if (strAttributeName  ==  convPrjTabKeyFld.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convPrjTabKeyFld.PrjId);
}
}
}
public object this[int intIndex]
{
get
{
if (convPrjTabKeyFld.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (convPrjTabKeyFld.FldId  ==  _AttributeName[intIndex])
{
return mstrFldId;
}
else if (convPrjTabKeyFld.FieldTypeId  ==  _AttributeName[intIndex])
{
return mstrFieldTypeId;
}
else if (convPrjTabKeyFld.PrimaryTypeId  ==  _AttributeName[intIndex])
{
return mstrPrimaryTypeId;
}
else if (convPrjTabKeyFld.PrimaryTypeName  ==  _AttributeName[intIndex])
{
return mstrPrimaryTypeName;
}
else if (convPrjTabKeyFld.KeyFldName  ==  _AttributeName[intIndex])
{
return mstrKeyFldName;
}
else if (convPrjTabKeyFld.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
return null;
}
set
{
if (convPrjTabKeyFld.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(convPrjTabKeyFld.TabId);
}
else if (convPrjTabKeyFld.FldId  ==  _AttributeName[intIndex])
{
mstrFldId = value.ToString();
 AddUpdatedFld(convPrjTabKeyFld.FldId);
}
else if (convPrjTabKeyFld.FieldTypeId  ==  _AttributeName[intIndex])
{
mstrFieldTypeId = value.ToString();
 AddUpdatedFld(convPrjTabKeyFld.FieldTypeId);
}
else if (convPrjTabKeyFld.PrimaryTypeId  ==  _AttributeName[intIndex])
{
mstrPrimaryTypeId = value.ToString();
 AddUpdatedFld(convPrjTabKeyFld.PrimaryTypeId);
}
else if (convPrjTabKeyFld.PrimaryTypeName  ==  _AttributeName[intIndex])
{
mstrPrimaryTypeName = value.ToString();
 AddUpdatedFld(convPrjTabKeyFld.PrimaryTypeName);
}
else if (convPrjTabKeyFld.KeyFldName  ==  _AttributeName[intIndex])
{
mstrKeyFldName = value.ToString();
 AddUpdatedFld(convPrjTabKeyFld.KeyFldName);
}
else if (convPrjTabKeyFld.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convPrjTabKeyFld.PrjId);
}
}
}

/// <summary>
/// 表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabId
{
get
{
return mstrTabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabId = value;
}
else
{
 mstrTabId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjTabKeyFld.TabId);
}
}
/// <summary>
/// 字段Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FldId
{
get
{
return mstrFldId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldId = value;
}
else
{
 mstrFldId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjTabKeyFld.FldId);
}
}
/// <summary>
/// 字段类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FieldTypeId
{
get
{
return mstrFieldTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFieldTypeId = value;
}
else
{
 mstrFieldTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjTabKeyFld.FieldTypeId);
}
}
/// <summary>
/// 主键类型ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrimaryTypeId
{
get
{
return mstrPrimaryTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrimaryTypeId = value;
}
else
{
 mstrPrimaryTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjTabKeyFld.PrimaryTypeId);
}
}
/// <summary>
/// 主键类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrimaryTypeName
{
get
{
return mstrPrimaryTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrimaryTypeName = value;
}
else
{
 mstrPrimaryTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjTabKeyFld.PrimaryTypeName);
}
}
/// <summary>
/// 关键字段名(说明:;字段类型:varchar;字段长度:300;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KeyFldName
{
get
{
return mstrKeyFldName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeyFldName = value;
}
else
{
 mstrKeyFldName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjTabKeyFld.KeyFldName);
}
}
/// <summary>
/// 工程Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjId
{
get
{
return mstrPrjId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjId = value;
}
else
{
 mstrPrjId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjTabKeyFld.PrjId);
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
  return mstrTabId;
 }
 }
}
 /// <summary>
 /// vPrjTabKeyFld(vPrjTabKeyFld)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convPrjTabKeyFld
{
public const string _CurrTabName = "vPrjTabKeyFld"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TabId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"TabId", "FldId", "FieldTypeId", "PrimaryTypeId", "PrimaryTypeName", "KeyFldName", "PrjId"};
//以下是属性变量


 /// <summary>
 /// 常量:"TabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabId = "TabId";    //表ID

 /// <summary>
 /// 常量:"FldId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldId = "FldId";    //字段Id

 /// <summary>
 /// 常量:"FieldTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FieldTypeId = "FieldTypeId";    //字段类型Id

 /// <summary>
 /// 常量:"PrimaryTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrimaryTypeId = "PrimaryTypeId";    //主键类型ID

 /// <summary>
 /// 常量:"PrimaryTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrimaryTypeName = "PrimaryTypeName";    //主键类型名

 /// <summary>
 /// 常量:"KeyFldName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KeyFldName = "KeyFldName";    //关键字段名

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id
}

}