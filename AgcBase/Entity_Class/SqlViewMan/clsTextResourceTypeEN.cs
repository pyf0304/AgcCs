
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTextResourceTypeEN
 表名:TextResourceType(00050246)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:16:43
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:Sql视图管理(SqlViewMan)
 框架-层名:实体层(CS)(EntityLayer)
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

namespace AGC.Entity
{
 /// <summary>
 /// 表TextResourceType的关键字(TextResourceTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TextResourceTypeId_TextResourceType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strTextResourceTypeId">表关键字</param>
public K_TextResourceTypeId_TextResourceType(string strTextResourceTypeId)
{
if (IsValid(strTextResourceTypeId)) Value = strTextResourceTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strTextResourceTypeId)
{
if (string.IsNullOrEmpty(strTextResourceTypeId) == true) return false;
if (strTextResourceTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_TextResourceTypeId_TextResourceType]类型的对象</returns>
public static implicit operator K_TextResourceTypeId_TextResourceType(string value)
{
return new K_TextResourceTypeId_TextResourceType(value);
}
}
 /// <summary>
 /// 文本来源类型(TextResourceType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsTextResourceTypeEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接，如果为空就使用系统默认的连接
public new const string _CurrTabName = "TextResourceType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TextResourceTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string WhereFormat = ""; //条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"TextResourceTypeId", "TextResourceTypeName", "Memo"};

protected string mstrTextResourceTypeId;    //文本来源类型Id
protected string mstrTextResourceTypeName;    //文本来源类型名
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsTextResourceTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "TextResourceType";
 lstKeyFldNames.Add("TextResourceTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strTextResourceTypeId">关键字:文本来源类型Id</param>
public clsTextResourceTypeEN(string strTextResourceTypeId)
 {
strTextResourceTypeId = strTextResourceTypeId.Replace("'", "''");
if (strTextResourceTypeId.Length > 2)
{
throw new Exception("在表:TextResourceType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTextResourceTypeId)  ==  true)
{
throw new Exception("在表:TextResourceType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTextResourceTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrTextResourceTypeId = strTextResourceTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "TextResourceType";
 lstKeyFldNames.Add("TextResourceTypeId");
 }

public static int AttributeCount
{
get
{
return mintAttributeCount;
}
}
public override object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  conTextResourceType.TextResourceTypeId)
{
return mstrTextResourceTypeId;
}
else if (strAttributeName  ==  conTextResourceType.TextResourceTypeName)
{
return mstrTextResourceTypeName;
}
else if (strAttributeName  ==  conTextResourceType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conTextResourceType.TextResourceTypeId)
{
mstrTextResourceTypeId = value.ToString();
 AddUpdatedFld(conTextResourceType.TextResourceTypeId);
}
else if (strAttributeName  ==  conTextResourceType.TextResourceTypeName)
{
mstrTextResourceTypeName = value.ToString();
 AddUpdatedFld(conTextResourceType.TextResourceTypeName);
}
else if (strAttributeName  ==  conTextResourceType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTextResourceType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conTextResourceType.TextResourceTypeId  ==  AttributeName[intIndex])
{
return mstrTextResourceTypeId;
}
else if (conTextResourceType.TextResourceTypeName  ==  AttributeName[intIndex])
{
return mstrTextResourceTypeName;
}
else if (conTextResourceType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conTextResourceType.TextResourceTypeId  ==  AttributeName[intIndex])
{
mstrTextResourceTypeId = value.ToString();
 AddUpdatedFld(conTextResourceType.TextResourceTypeId);
}
else if (conTextResourceType.TextResourceTypeName  ==  AttributeName[intIndex])
{
mstrTextResourceTypeName = value.ToString();
 AddUpdatedFld(conTextResourceType.TextResourceTypeName);
}
else if (conTextResourceType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTextResourceType.Memo);
}
}
}

/// <summary>
/// 文本来源类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TextResourceTypeId
{
get
{
return mstrTextResourceTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTextResourceTypeId = value;
}
else
{
 mstrTextResourceTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conTextResourceType.TextResourceTypeId);
}
}
/// <summary>
/// 文本来源类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TextResourceTypeName
{
get
{
return mstrTextResourceTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTextResourceTypeName = value;
}
else
{
 mstrTextResourceTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conTextResourceType.TextResourceTypeName);
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
 AddUpdatedFld(conTextResourceType.Memo);
}
}

/// <summary>
/// 获取关键字Id(keyId)
 /// (AutoGCLib.clsGeneCodeBase:GenGetKeyId)
/// </summary>
 public override string _KeyId
 {
 get
 {
  return mstrTextResourceTypeId;
 }
 }

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrTextResourceTypeName;
 }
 }
}
 /// <summary>
 /// 文本来源类型(TextResourceType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conTextResourceType
{
public new const string _CurrTabName = "TextResourceType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TextResourceTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"TextResourceTypeId", "TextResourceTypeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"TextResourceTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextResourceTypeId = "TextResourceTypeId";    //文本来源类型Id

 /// <summary>
 /// 常量:"TextResourceTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextResourceTypeName = "TextResourceTypeName";    //文本来源类型名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}