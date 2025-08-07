
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPItemTemplate
 表名:ASPItemTemplate(00050229)
 生成代码版本:2019.10.18.1
 生成日期:2019/10/18 10:34:55
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
 /// ASP项模板(ASPItemTemplate)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPItemTemplate : ASPControlEx
{
protected const int mintAttributeCount = 2;
public static string[] AttributeName = new string[] {"ASPItemTemplateId", "ASPItemTemplateName"};
//以下是属性变量

/// <summary>
/// ASP项模板Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string ASPItemTemplateId
{
get
{
return mstrASPItemTemplateId;
}
set
{
if (value  ==  "")
{
 mstrASPItemTemplateId = value;
}
else
{
 mstrASPItemTemplateId = value;
}
}
}
/// <summary>
/// ASP项模板名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string ASPItemTemplateName
{
get
{
return mstrASPItemTemplateName;
}
set
{
if (value  ==  "")
{
 mstrASPItemTemplateName = value;
}
else
{
 mstrASPItemTemplateName = value;
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
if (strAttributeName  ==  con_ASPItemTemplateId)
{
return mstrASPItemTemplateId;
}
else if (strAttributeName  ==  con_ASPItemTemplateName)
{
return mstrASPItemTemplateName;
}
return null;
}
set
{
if (strAttributeName  ==  con_ASPItemTemplateId)
{
mstrASPItemTemplateId = value.ToString();
}
else if (strAttributeName  ==  con_ASPItemTemplateName)
{
mstrASPItemTemplateName = value.ToString();
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
if (con_ASPItemTemplateId  ==  AttributeName[intIndex])
{
return mstrASPItemTemplateId;
}
else if (con_ASPItemTemplateName  ==  AttributeName[intIndex])
{
return mstrASPItemTemplateName;
}
return null;
}
set
{
if (con_ASPItemTemplateId  ==  AttributeName[intIndex])
{
mstrASPItemTemplateId = value.ToString();
}
else if (con_ASPItemTemplateName  ==  AttributeName[intIndex])
{
mstrASPItemTemplateName = value.ToString();
}
}
}

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPItemTemplate()
 {
 }


 /// <summary>
 /// 常量:"ASPItemTemplateId"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ASPItemTemplateId = "ASPItemTemplateId";    //ASP项模板Id

 /// <summary>
 /// 常量:"ASPItemTemplateName"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ASPItemTemplateName = "ASPItemTemplateName";    //ASP项模板名

protected string mstrASPItemTemplateId;    //ASP项模板Id
protected string mstrASPItemTemplateName;    //ASP项模板名
}
}