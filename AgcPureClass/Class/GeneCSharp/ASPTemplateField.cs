
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPTemplateField
 表名:ASPTemplateField(00050227)
 生成代码版本:2021.11.17.1
 生成日期:2021/11/18 02:09:27
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(变量首字母不限定)
 模块中文名:生成C#代码(GeneCSharp)
 框架-层名:纯粹类(PureClass)
 编程语言:CSharp
 注意:1、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Text; 
using System.Collections; 
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System.Runtime.Serialization;

namespace AGC.PureClass
{
 /// <summary>
 /// ASP模板字段(ASPTemplateField)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPTemplateField : ASPControlEx
{
protected new const int mintAttributeCount = 3;
public new static string[] AttributeName = new string[] {"AspTemplateFieldId", "AspTemplateFieldName", "HeaderText"};
//以下是属性变量

protected string mstrAspTemplateFieldId;    //ASP模板字段Id
protected string mstrAspTemplateFieldName;    //ASP模板字段名
protected string mstrHeaderText;    //列头


 /// <summary>
 /// 常量:"AspTemplateFieldId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspTemplateFieldId = "AspTemplateFieldId";    //ASP模板字段Id

 /// <summary>
 /// 常量:"AspTemplateFieldName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspTemplateFieldName = "AspTemplateFieldName";    //ASP模板字段名

 /// <summary>
 /// 常量:"HeaderText"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_HeaderText = "HeaderText";    //列头

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPTemplateField()
 {
 }

public new static int AttributeCount
{
get
{
return mintAttributeCount;
}
}
/// <summary>
/// 类索引器(Indexer)函数,字符串参数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClsIndexer)
/// </summary>
public new object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  con_AspTemplateFieldId)
{
return mstrAspTemplateFieldId;
}
else if (strAttributeName  ==  con_AspTemplateFieldName)
{
return mstrAspTemplateFieldName;
}
else if (strAttributeName  ==  con_HeaderText)
{
return mstrHeaderText;
}
return null;
}
set
{
if (strAttributeName  ==  con_AspTemplateFieldId)
{
mstrAspTemplateFieldId = value.ToString();
}
else if (strAttributeName  ==  con_AspTemplateFieldName)
{
mstrAspTemplateFieldName = value.ToString();
}
else if (strAttributeName  ==  con_HeaderText)
{
mstrHeaderText = value.ToString();
}
}
}
/// <summary>
/// 类索引器(Indexer)函数, 整型(INT)序号参数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClsIndexer)
/// </summary>
public new object this[int intIndex]
{
get
{
if (con_AspTemplateFieldId  ==  AttributeName[intIndex])
{
return mstrAspTemplateFieldId;
}
else if (con_AspTemplateFieldName  ==  AttributeName[intIndex])
{
return mstrAspTemplateFieldName;
}
else if (con_HeaderText  ==  AttributeName[intIndex])
{
return mstrHeaderText;
}
return null;
}
set
{
if (con_AspTemplateFieldId  ==  AttributeName[intIndex])
{
mstrAspTemplateFieldId = value.ToString();
}
else if (con_AspTemplateFieldName  ==  AttributeName[intIndex])
{
mstrAspTemplateFieldName = value.ToString();
}
else if (con_HeaderText  ==  AttributeName[intIndex])
{
mstrHeaderText = value.ToString();
}
}
}

/// <summary>
/// ASP模板字段Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspTemplateFieldId
{
get
{
return mstrAspTemplateFieldId;
}
set
{
if (value  ==  "")
{
 mstrAspTemplateFieldId = value;
}
else
{
 mstrAspTemplateFieldId = value;
}
}
}
/// <summary>
/// ASP模板字段名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspTemplateFieldName
{
get
{
return mstrAspTemplateFieldName;
}
set
{
if (value  ==  "")
{
 mstrAspTemplateFieldName = value;
}
else
{
 mstrAspTemplateFieldName = value;
}
}
}
/// <summary>
/// 列头(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string HeaderText
{
get
{
return mstrHeaderText;
}
set
{
if (value  ==  "")
{
 mstrHeaderText = value;
}
else
{
 mstrHeaderText = value;
}
}
}
}
}