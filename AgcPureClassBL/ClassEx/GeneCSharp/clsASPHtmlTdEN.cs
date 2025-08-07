
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsASPHtmlTdEN
 表名:ASPHtmlTd(00050442)
 生成代码版本:2019.08.27.1
 生成日期:2019/08/27 12:07:50
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:AGC
 工程ID:0005
 相关数据库:101.251.68.133,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成C#代码
 模块英文名:GeneCSharp
 框架-层名:实体层(EntityLayer)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
using System;
using System.Text; 
using System.Collections; 
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System.Runtime.Serialization;

namespace AGC.Entity
{
 /// <summary>
 /// 表ASPHtmlTd的关键字(AspHtmlTdId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public struct K_AspHtmlTdId_ASPHtmlTd
{
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get; }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strAspHtmlTdId">表关键字</param>
public K_AspHtmlTdId_ASPHtmlTd(string strAspHtmlTdId)
{
if (IsValid(strAspHtmlTdId)) Value = strAspHtmlTdId;
else
{
Value = null;
}
}
private static bool IsValid(string strAspHtmlTdId)
{
if (string.IsNullOrEmpty(strAspHtmlTdId) == true) return false;
if (strAspHtmlTdId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_AspHtmlTdId_ASPHtmlTd]类型的对象</returns>
public static implicit operator K_AspHtmlTdId_ASPHtmlTd(string value)
{
return new K_AspHtmlTdId_ASPHtmlTd(value);
}
}
 /// <summary>
 /// ASPHtml表单元格(ASPHtmlTd)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsASPHtmlTdEN : clsASPControlENEx
{
public const string _CurrTabName_S = "ASPHtmlTd"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "AspHtmlTdId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 2;
public static string[] AttributeName = new string[] {"AspHtmlTdId", "AspHtmlTdName"};
//以下是属性变量

protected string mstrAspHtmlTdId;    //AspHtml表单元格Id
protected string mstrAspHtmlTdName;    //AspHtml表单元格名


 /// <summary>
 /// 常量:"AspHtmlTdId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspHtmlTdId = "AspHtmlTdId";    //AspHtml表单元格Id

 /// <summary>
 /// 常量:"AspHtmlTdName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspHtmlTdName = "AspHtmlTdName";    //AspHtml表单元格名

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsASPHtmlTdEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "ASPHtmlTd";
 lstKeyFldNames.Add("AspHtmlTdId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strAspHtmlTdId">关键字:AspHtml表单元格Id</param>
public clsASPHtmlTdEN(string strAspHtmlTdId)
 {
strAspHtmlTdId = strAspHtmlTdId.Replace("'", "''");
if (strAspHtmlTdId.Length > 8)
{
throw new Exception("在表:ASPHtmlTd中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strAspHtmlTdId)  ==  true)
{
throw new Exception("在表:ASPHtmlTd中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strAspHtmlTdId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrAspHtmlTdId = strAspHtmlTdId;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "ASPHtmlTd";
 lstKeyFldNames.Add("AspHtmlTdId");
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
if (strAttributeName  ==  con_AspHtmlTdId)
{
return mstrAspHtmlTdId;
}
else if (strAttributeName  ==  con_AspHtmlTdName)
{
return mstrAspHtmlTdName;
}
return null;
}
set
{
if (strAttributeName  ==  con_AspHtmlTdId)
{
mstrAspHtmlTdId = value.ToString();
 AddUpdatedFld(con_AspHtmlTdId);
}
else if (strAttributeName  ==  con_AspHtmlTdName)
{
mstrAspHtmlTdName = value.ToString();
 AddUpdatedFld(con_AspHtmlTdName);
}
}
}
public object this[int intIndex]
{
get
{
if (con_AspHtmlTdId  ==  AttributeName[intIndex])
{
return mstrAspHtmlTdId;
}
else if (con_AspHtmlTdName  ==  AttributeName[intIndex])
{
return mstrAspHtmlTdName;
}
return null;
}
set
{
if (con_AspHtmlTdId  ==  AttributeName[intIndex])
{
mstrAspHtmlTdId = value.ToString();
 AddUpdatedFld(con_AspHtmlTdId);
}
else if (con_AspHtmlTdName  ==  AttributeName[intIndex])
{
mstrAspHtmlTdName = value.ToString();
 AddUpdatedFld(con_AspHtmlTdName);
}
}
}

/// <summary>
/// AspHtml表单元格Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AspHtmlTdId
{
get
{
return mstrAspHtmlTdId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAspHtmlTdId = value;
}
else
{
 mstrAspHtmlTdId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_AspHtmlTdId);
}
}
/// <summary>
/// AspHtml表单元格名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AspHtmlTdName
{
get
{
return mstrAspHtmlTdName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAspHtmlTdName = value;
}
else
{
 mstrAspHtmlTdName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_AspHtmlTdName);
}
}

/// <summary>
/// 获取关键字Id(KeyId)
 /// (AutoGCLib.clsGeneCodeBase:GenGetKeyId)
/// </summary>
 public override string _KeyId
 {
 get
 {
  return mstrAspHtmlTdId;
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
  return mstrAspHtmlTdName;
 }
 }
}
}