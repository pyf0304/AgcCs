
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPTemplateField
 表名:ASPTemplateField(00050227)
 生成代码版本:2019.10.18.1
 生成日期:2019/10/18 10:35:00
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
 /// ASP模板字段(ASPTemplateField)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPTemplateField : ASPControlEx
{
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"ASPTemplateFieldId", "ASPTemplateFieldName", "HeaderText"};
//以下是属性变量

/// <summary>
/// ASP模板字段Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string ASPTemplateFieldId
{
get
{
return mstrASPTemplateFieldId;
}
set
{
if (value  ==  "")
{
 mstrASPTemplateFieldId = value;
}
else
{
 mstrASPTemplateFieldId = value;
}
}
}
/// <summary>
/// ASP模板字段名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string ASPTemplateFieldName
{
get
{
return mstrASPTemplateFieldName;
}
set
{
if (value  ==  "")
{
 mstrASPTemplateFieldName = value;
}
else
{
 mstrASPTemplateFieldName = value;
}
}
}
/// <summary>
/// HeaderText(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
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
if (strAttributeName  ==  con_ASPTemplateFieldId)
{
return mstrASPTemplateFieldId;
}
else if (strAttributeName  ==  con_ASPTemplateFieldName)
{
return mstrASPTemplateFieldName;
}
else if (strAttributeName  ==  con_HeaderText)
{
return mstrHeaderText;
}
return null;
}
set
{
if (strAttributeName  ==  con_ASPTemplateFieldId)
{
mstrASPTemplateFieldId = value.ToString();
}
else if (strAttributeName  ==  con_ASPTemplateFieldName)
{
mstrASPTemplateFieldName = value.ToString();
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
public object this[int intIndex]
{
get
{
if (con_ASPTemplateFieldId  ==  AttributeName[intIndex])
{
return mstrASPTemplateFieldId;
}
else if (con_ASPTemplateFieldName  ==  AttributeName[intIndex])
{
return mstrASPTemplateFieldName;
}
else if (con_HeaderText  ==  AttributeName[intIndex])
{
return mstrHeaderText;
}
return null;
}
set
{
if (con_ASPTemplateFieldId  ==  AttributeName[intIndex])
{
mstrASPTemplateFieldId = value.ToString();
}
else if (con_ASPTemplateFieldName  ==  AttributeName[intIndex])
{
mstrASPTemplateFieldName = value.ToString();
}
else if (con_HeaderText  ==  AttributeName[intIndex])
{
mstrHeaderText = value.ToString();
}
}
}

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPTemplateField()
 {
 }


 /// <summary>
 /// 常量:"ASPTemplateFieldId"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ASPTemplateFieldId = "ASPTemplateFieldId";    //ASP模板字段Id

 /// <summary>
 /// 常量:"ASPTemplateFieldName"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ASPTemplateFieldName = "ASPTemplateFieldName";    //ASP模板字段名

 /// <summary>
 /// 常量:"HeaderText"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_HeaderText = "HeaderText";    //HeaderText

protected string mstrASPTemplateFieldId;    //ASP模板字段Id
protected string mstrASPTemplateFieldName;    //ASP模板字段名
protected string mstrHeaderText;    //HeaderText
}
}