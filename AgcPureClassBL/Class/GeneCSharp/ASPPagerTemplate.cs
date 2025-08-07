
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPPagerTemplate
 表名:ASPPagerTemplate(00050228)
 生成代码版本:2019.10.18.1
 生成日期:2019/10/18 10:34:58
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
 /// ASP分页模板(ASPPagerTemplate)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPPagerTemplate : ASPControlEx
{
protected const int mintAttributeCount = 2;
public static string[] AttributeName = new string[] {"ASPPagerTemplateId", "ASPPagerTemplateName"};
//以下是属性变量

/// <summary>
/// ASP分页模板Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string ASPPagerTemplateId
{
get
{
return mstrASPPagerTemplateId;
}
set
{
if (value  ==  "")
{
 mstrASPPagerTemplateId = value;
}
else
{
 mstrASPPagerTemplateId = value;
}
}
}
/// <summary>
/// ASP分页模板名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string ASPPagerTemplateName
{
get
{
return mstrASPPagerTemplateName;
}
set
{
if (value  ==  "")
{
 mstrASPPagerTemplateName = value;
}
else
{
 mstrASPPagerTemplateName = value;
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
if (strAttributeName  ==  con_ASPPagerTemplateId)
{
return mstrASPPagerTemplateId;
}
else if (strAttributeName  ==  con_ASPPagerTemplateName)
{
return mstrASPPagerTemplateName;
}
return null;
}
set
{
if (strAttributeName  ==  con_ASPPagerTemplateId)
{
mstrASPPagerTemplateId = value.ToString();
}
else if (strAttributeName  ==  con_ASPPagerTemplateName)
{
mstrASPPagerTemplateName = value.ToString();
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
if (con_ASPPagerTemplateId  ==  AttributeName[intIndex])
{
return mstrASPPagerTemplateId;
}
else if (con_ASPPagerTemplateName  ==  AttributeName[intIndex])
{
return mstrASPPagerTemplateName;
}
return null;
}
set
{
if (con_ASPPagerTemplateId  ==  AttributeName[intIndex])
{
mstrASPPagerTemplateId = value.ToString();
}
else if (con_ASPPagerTemplateName  ==  AttributeName[intIndex])
{
mstrASPPagerTemplateName = value.ToString();
}
}
}

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPPagerTemplate()
 {
 }


 /// <summary>
 /// 常量:"ASPPagerTemplateId"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ASPPagerTemplateId = "ASPPagerTemplateId";    //ASP分页模板Id

 /// <summary>
 /// 常量:"ASPPagerTemplateName"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ASPPagerTemplateName = "ASPPagerTemplateName";    //ASP分页模板名

protected string mstrASPPagerTemplateId;    //ASP分页模板Id
protected string mstrASPPagerTemplateName;    //ASP分页模板名
}
}