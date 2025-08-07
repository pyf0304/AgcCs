
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsASPHtmlTrEN
 表名:ASPHtmlTr(00050441)
 生成代码版本:2019.08.27.1
 生成日期:2019/08/27 12:07:52
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
 /// 表ASPHtmlTr的关键字(AspHtmlTrId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public struct K_AspHtmlTrId_ASPHtmlTr
{
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get; }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strAspHtmlTrId">表关键字</param>
public K_AspHtmlTrId_ASPHtmlTr(string strAspHtmlTrId)
{
if (IsValid(strAspHtmlTrId)) Value = strAspHtmlTrId;
else
{
Value = null;
}
}
private static bool IsValid(string strAspHtmlTrId)
{
if (string.IsNullOrEmpty(strAspHtmlTrId) == true) return false;
if (strAspHtmlTrId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_AspHtmlTrId_ASPHtmlTr]类型的对象</returns>
public static implicit operator K_AspHtmlTrId_ASPHtmlTr(string value)
{
return new K_AspHtmlTrId_ASPHtmlTr(value);
}
}
 /// <summary>
 /// ASPHtml表行(ASPHtmlTr)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsASPHtmlTrEN : clsASPControlENEx
{
public const string _CurrTabName_S = "ASPHtmlTr"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "AspHtmlTrId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"AspHtmlTrId", "AspHtmlTrName", "ColNum"};
//以下是属性变量

protected string mstrAspHtmlTrId;    //AspHtml表行Id
protected string mstrAspHtmlTrName;    //AspHtml表行名
protected int mintColNum;    //列数


 /// <summary>
 /// 常量:"AspHtmlTrId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspHtmlTrId = "AspHtmlTrId";    //AspHtml表行Id

 /// <summary>
 /// 常量:"AspHtmlTrName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspHtmlTrName = "AspHtmlTrName";    //AspHtml表行名

 /// <summary>
 /// 常量:"ColNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ColNum = "ColNum";    //列数

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsASPHtmlTrEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "ASPHtmlTr";
 lstKeyFldNames.Add("AspHtmlTrId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strAspHtmlTrId">关键字:AspHtml表行Id</param>
public clsASPHtmlTrEN(string strAspHtmlTrId)
 {
strAspHtmlTrId = strAspHtmlTrId.Replace("'", "''");
if (strAspHtmlTrId.Length > 8)
{
throw new Exception("在表:ASPHtmlTr中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strAspHtmlTrId)  ==  true)
{
throw new Exception("在表:ASPHtmlTr中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strAspHtmlTrId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrAspHtmlTrId = strAspHtmlTrId;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "ASPHtmlTr";
 lstKeyFldNames.Add("AspHtmlTrId");
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
if (strAttributeName  ==  con_AspHtmlTrId)
{
return mstrAspHtmlTrId;
}
else if (strAttributeName  ==  con_AspHtmlTrName)
{
return mstrAspHtmlTrName;
}
else if (strAttributeName  ==  con_ColNum)
{
return mintColNum;
}
return null;
}
set
{
if (strAttributeName  ==  con_AspHtmlTrId)
{
mstrAspHtmlTrId = value.ToString();
 AddUpdatedFld(con_AspHtmlTrId);
}
else if (strAttributeName  ==  con_AspHtmlTrName)
{
mstrAspHtmlTrName = value.ToString();
 AddUpdatedFld(con_AspHtmlTrName);
}
else if (strAttributeName  ==  con_ColNum)
{
mintColNum = TransNullToInt(value.ToString());
 AddUpdatedFld(con_ColNum);
}
}
}
public object this[int intIndex]
{
get
{
if (con_AspHtmlTrId  ==  AttributeName[intIndex])
{
return mstrAspHtmlTrId;
}
else if (con_AspHtmlTrName  ==  AttributeName[intIndex])
{
return mstrAspHtmlTrName;
}
else if (con_ColNum  ==  AttributeName[intIndex])
{
return mintColNum;
}
return null;
}
set
{
if (con_AspHtmlTrId  ==  AttributeName[intIndex])
{
mstrAspHtmlTrId = value.ToString();
 AddUpdatedFld(con_AspHtmlTrId);
}
else if (con_AspHtmlTrName  ==  AttributeName[intIndex])
{
mstrAspHtmlTrName = value.ToString();
 AddUpdatedFld(con_AspHtmlTrName);
}
else if (con_ColNum  ==  AttributeName[intIndex])
{
mintColNum = TransNullToInt(value.ToString());
 AddUpdatedFld(con_ColNum);
}
}
}

/// <summary>
/// AspHtml表行Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AspHtmlTrId
{
get
{
return mstrAspHtmlTrId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAspHtmlTrId = value;
}
else
{
 mstrAspHtmlTrId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_AspHtmlTrId);
}
}
/// <summary>
/// AspHtml表行名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AspHtmlTrName
{
get
{
return mstrAspHtmlTrName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAspHtmlTrName = value;
}
else
{
 mstrAspHtmlTrName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_AspHtmlTrName);
}
}
/// <summary>
/// 列数(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int ColNum
{
get
{
return mintColNum;
}
set
{
 mintColNum = value;
//记录修改过的字段
 AddUpdatedFld(con_ColNum);
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
  return mstrAspHtmlTrId;
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
  return mstrAspHtmlTrName;
 }
 }
}
}