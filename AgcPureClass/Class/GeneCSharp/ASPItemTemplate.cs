
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPItemTemplate
 表名:ASPItemTemplate(00050229)
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
 /// ASP项模板(ASPItemTemplate)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPItemTemplate : ASPControlEx
{
protected new const int mintAttributeCount = 2;
public new static string[] AttributeName = new string[] {"AspItemTemplateId", "AspItemTemplateName"};
//以下是属性变量

protected string mstrAspItemTemplateId;    //ASP项模板Id
protected string mstrAspItemTemplateName;    //ASP项模板名


 /// <summary>
 /// 常量:"AspItemTemplateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspItemTemplateId = "AspItemTemplateId";    //ASP项模板Id

 /// <summary>
 /// 常量:"AspItemTemplateName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspItemTemplateName = "AspItemTemplateName";    //ASP项模板名

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPItemTemplate()
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
if (strAttributeName  ==  con_AspItemTemplateId)
{
return mstrAspItemTemplateId;
}
else if (strAttributeName  ==  con_AspItemTemplateName)
{
return mstrAspItemTemplateName;
}
return null;
}
set
{
if (strAttributeName  ==  con_AspItemTemplateId)
{
mstrAspItemTemplateId = value.ToString();
}
else if (strAttributeName  ==  con_AspItemTemplateName)
{
mstrAspItemTemplateName = value.ToString();
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
if (con_AspItemTemplateId  ==  AttributeName[intIndex])
{
return mstrAspItemTemplateId;
}
else if (con_AspItemTemplateName  ==  AttributeName[intIndex])
{
return mstrAspItemTemplateName;
}
return null;
}
set
{
if (con_AspItemTemplateId  ==  AttributeName[intIndex])
{
mstrAspItemTemplateId = value.ToString();
}
else if (con_AspItemTemplateName  ==  AttributeName[intIndex])
{
mstrAspItemTemplateName = value.ToString();
}
}
}

/// <summary>
/// ASP项模板Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspItemTemplateId
{
get
{
return mstrAspItemTemplateId;
}
set
{
if (value  ==  "")
{
 mstrAspItemTemplateId = value;
}
else
{
 mstrAspItemTemplateId = value;
}
}
}
/// <summary>
/// ASP项模板名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspItemTemplateName
{
get
{
return mstrAspItemTemplateName;
}
set
{
if (value  ==  "")
{
 mstrAspItemTemplateName = value;
}
else
{
 mstrAspItemTemplateName = value;
}
}
}
}
}