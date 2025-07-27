
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPPagerTemplate
 表名:ASPPagerTemplate(00050228)
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
 /// ASP分页模板(ASPPagerTemplate)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPPagerTemplate : ASPControlEx
{
protected new const int mintAttributeCount = 2;
public new static string[] AttributeName = new string[] {"AspPagerTemplateId", "AspPagerTemplateName"};
//以下是属性变量

protected string mstrAspPagerTemplateId;    //ASP分页模板Id
protected string mstrAspPagerTemplateName;    //ASP分页模板名


 /// <summary>
 /// 常量:"AspPagerTemplateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspPagerTemplateId = "AspPagerTemplateId";    //ASP分页模板Id

 /// <summary>
 /// 常量:"AspPagerTemplateName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspPagerTemplateName = "AspPagerTemplateName";    //ASP分页模板名

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPPagerTemplate()
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
if (strAttributeName  ==  con_AspPagerTemplateId)
{
return mstrAspPagerTemplateId;
}
else if (strAttributeName  ==  con_AspPagerTemplateName)
{
return mstrAspPagerTemplateName;
}
return null;
}
set
{
if (strAttributeName  ==  con_AspPagerTemplateId)
{
mstrAspPagerTemplateId = value.ToString();
}
else if (strAttributeName  ==  con_AspPagerTemplateName)
{
mstrAspPagerTemplateName = value.ToString();
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
if (con_AspPagerTemplateId  ==  AttributeName[intIndex])
{
return mstrAspPagerTemplateId;
}
else if (con_AspPagerTemplateName  ==  AttributeName[intIndex])
{
return mstrAspPagerTemplateName;
}
return null;
}
set
{
if (con_AspPagerTemplateId  ==  AttributeName[intIndex])
{
mstrAspPagerTemplateId = value.ToString();
}
else if (con_AspPagerTemplateName  ==  AttributeName[intIndex])
{
mstrAspPagerTemplateName = value.ToString();
}
}
}

/// <summary>
/// ASP分页模板Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspPagerTemplateId
{
get
{
return mstrAspPagerTemplateId;
}
set
{
if (value  ==  "")
{
 mstrAspPagerTemplateId = value;
}
else
{
 mstrAspPagerTemplateId = value;
}
}
}
/// <summary>
/// ASP分页模板名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspPagerTemplateName
{
get
{
return mstrAspPagerTemplateName;
}
set
{
if (value  ==  "")
{
 mstrAspPagerTemplateName = value;
}
else
{
 mstrAspPagerTemplateName = value;
}
}
}
}
}