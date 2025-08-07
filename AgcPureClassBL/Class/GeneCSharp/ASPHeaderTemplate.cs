
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPHeaderTemplate
 表名:ASPHeaderTemplate(00050231)
 生成代码版本:2019.10.18.1
 生成日期:2019/10/18 10:34:52
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:AGC
 工程ID:0005
 模块中文名:生成C#代码
 模块英文名:GeneCSharp
 框架-层名:纯粹类(PureClass)
 编程语言:CSharp
 注意:1、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
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
protected const int mintAttributeCount = 2;
public static string[] AttributeName = new string[] {"ASPHeaderTemplateId", "ASPHeaderTemplateName"};
//以下是属性变量

/// <summary>
/// ASP头模板Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string ASPHeaderTemplateId
{
get
{
return mstrASPHeaderTemplateId;
}
set
{
if (value  ==  "")
{
 mstrASPHeaderTemplateId = value;
}
else
{
 mstrASPHeaderTemplateId = value;
}
}
}
/// <summary>
/// ASP头模板名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string ASPHeaderTemplateName
{
get
{
return mstrASPHeaderTemplateName;
}
set
{
if (value  ==  "")
{
 mstrASPHeaderTemplateName = value;
}
else
{
 mstrASPHeaderTemplateName = value;
}
}
}

public static int AttributeCount
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
public object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  con_ASPHeaderTemplateId)
{
return mstrASPHeaderTemplateId;
}
else if (strAttributeName  ==  con_ASPHeaderTemplateName)
{
return mstrASPHeaderTemplateName;
}
return null;
}
set
{
if (strAttributeName  ==  con_ASPHeaderTemplateId)
{
mstrASPHeaderTemplateId = value.ToString();
}
else if (strAttributeName  ==  con_ASPHeaderTemplateName)
{
mstrASPHeaderTemplateName = value.ToString();
}
}
}
/// <summary>
/// 类索引器(Indexer)函数, 整型(INT)序号参数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClsIndexer)
/// </summary>
public object this[int intIndex]
{
get
{
if (con_ASPHeaderTemplateId  ==  AttributeName[intIndex])
{
return mstrASPHeaderTemplateId;
}
else if (con_ASPHeaderTemplateName  ==  AttributeName[intIndex])
{
return mstrASPHeaderTemplateName;
}
return null;
}
set
{
if (con_ASPHeaderTemplateId  ==  AttributeName[intIndex])
{
mstrASPHeaderTemplateId = value.ToString();
}
else if (con_ASPHeaderTemplateName  ==  AttributeName[intIndex])
{
mstrASPHeaderTemplateName = value.ToString();
}
}
}

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPHeaderTemplate()
 {
 }


 /// <summary>
 /// 常量:"ASPHeaderTemplateId"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ASPHeaderTemplateId = "ASPHeaderTemplateId";    //ASP头模板Id

 /// <summary>
 /// 常量:"ASPHeaderTemplateName"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ASPHeaderTemplateName = "ASPHeaderTemplateName";    //ASP头模板名

protected string mstrASPHeaderTemplateId;    //ASP头模板Id
protected string mstrASPHeaderTemplateName;    //ASP头模板名
}
}