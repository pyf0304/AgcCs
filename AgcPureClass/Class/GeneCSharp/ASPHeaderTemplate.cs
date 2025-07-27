
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPHeaderTemplate
 表名:ASPHeaderTemplate(00050231)
 生成代码版本:2021.11.17.1
 生成日期:2021/11/18 02:09:28
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
 /// ASP头模板(ASPHeaderTemplate)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPHeaderTemplate : ASPControlEx
{
protected new const int mintAttributeCount = 2;
public new static string[] AttributeName = new string[] {"AspHeaderTemplateId", "AspHeaderTemplateName"};
//以下是属性变量

protected string mstrAspHeaderTemplateId;    //ASP头模板Id
protected string mstrAspHeaderTemplateName;    //ASP头模板名


 /// <summary>
 /// 常量:"AspHeaderTemplateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspHeaderTemplateId = "AspHeaderTemplateId";    //ASP头模板Id

 /// <summary>
 /// 常量:"AspHeaderTemplateName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspHeaderTemplateName = "AspHeaderTemplateName";    //ASP头模板名

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPHeaderTemplate()
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
if (strAttributeName  ==  con_AspHeaderTemplateId)
{
return mstrAspHeaderTemplateId;
}
else if (strAttributeName  ==  con_AspHeaderTemplateName)
{
return mstrAspHeaderTemplateName;
}
return null;
}
set
{
if (strAttributeName  ==  con_AspHeaderTemplateId)
{
mstrAspHeaderTemplateId = value.ToString();
}
else if (strAttributeName  ==  con_AspHeaderTemplateName)
{
mstrAspHeaderTemplateName = value.ToString();
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
if (con_AspHeaderTemplateId  ==  AttributeName[intIndex])
{
return mstrAspHeaderTemplateId;
}
else if (con_AspHeaderTemplateName  ==  AttributeName[intIndex])
{
return mstrAspHeaderTemplateName;
}
return null;
}
set
{
if (con_AspHeaderTemplateId  ==  AttributeName[intIndex])
{
mstrAspHeaderTemplateId = value.ToString();
}
else if (con_AspHeaderTemplateName  ==  AttributeName[intIndex])
{
mstrAspHeaderTemplateName = value.ToString();
}
}
}

/// <summary>
/// ASP头模板Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspHeaderTemplateId
{
get
{
return mstrAspHeaderTemplateId;
}
set
{
if (value  ==  "")
{
 mstrAspHeaderTemplateId = value;
}
else
{
 mstrAspHeaderTemplateId = value;
}
}
}
/// <summary>
/// ASP头模板名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspHeaderTemplateName
{
get
{
return mstrAspHeaderTemplateName;
}
set
{
if (value  ==  "")
{
 mstrAspHeaderTemplateName = value;
}
else
{
 mstrAspHeaderTemplateName = value;
}
}
}
}
}