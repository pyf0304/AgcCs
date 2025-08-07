
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ISOOutlet
 表名:ISOOutlet(00050367)
 生成代码版本:2021.07.29.1
 生成日期:2021/07/29 18:18:40
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:AGC
 工程ID:0005
 模块中文名:生成ISO代码
 模块英文名:GCISO
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
 /// ISO变量链接(ISOOutlet)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ISOOutlet : ISOControlEx
{
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"IsoOutletId", "IsoOutletName", "Text", "property", "destination", "CssClass", "OnClick"};
//以下是属性变量

protected string mstrIsoOutletId;    //Iso变量链接Id
protected string mstrIsoOutletName;    //Iso变量链接名
protected string mstrText;    //文本
protected string mstrproperty;    //属性
protected string mstrdestination;    //目标
protected string mstrCssClass;    //样式表
protected string mstrOnClick;    //单击事件


 /// <summary>
 /// 常量:"IsoOutletId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsoOutletId = "IsoOutletId";    //Iso变量链接Id

 /// <summary>
 /// 常量:"IsoOutletName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsoOutletName = "IsoOutletName";    //Iso变量链接名

 /// <summary>
 /// 常量:"Text"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Text = "Text";    //文本

 /// <summary>
 /// 常量:"property"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_property = "property";    //属性

 /// <summary>
 /// 常量:"destination"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_destination = "destination";    //目标

 /// <summary>
 /// 常量:"CssClass"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_CssClass = "CssClass";    //样式表

 /// <summary>
 /// 常量:"OnClick"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_OnClick = "OnClick";    //单击事件

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ISOOutlet()
 {
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
if (strAttributeName  ==  con_IsoOutletId)
{
return mstrIsoOutletId;
}
else if (strAttributeName  ==  con_IsoOutletName)
{
return mstrIsoOutletName;
}
else if (strAttributeName  ==  con_Text)
{
return mstrText;
}
else if (strAttributeName  ==  con_property)
{
return mstrproperty;
}
else if (strAttributeName  ==  con_destination)
{
return mstrdestination;
}
else if (strAttributeName  ==  con_CssClass)
{
return mstrCssClass;
}
else if (strAttributeName  ==  con_OnClick)
{
return mstrOnClick;
}
return null;
}
set
{
if (strAttributeName  ==  con_IsoOutletId)
{
mstrIsoOutletId = value.ToString();
}
else if (strAttributeName  ==  con_IsoOutletName)
{
mstrIsoOutletName = value.ToString();
}
else if (strAttributeName  ==  con_Text)
{
mstrText = value.ToString();
}
else if (strAttributeName  ==  con_property)
{
mstrproperty = value.ToString();
}
else if (strAttributeName  ==  con_destination)
{
mstrdestination = value.ToString();
}
else if (strAttributeName  ==  con_CssClass)
{
mstrCssClass = value.ToString();
}
else if (strAttributeName  ==  con_OnClick)
{
mstrOnClick = value.ToString();
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
if (con_IsoOutletId  ==  AttributeName[intIndex])
{
return mstrIsoOutletId;
}
else if (con_IsoOutletName  ==  AttributeName[intIndex])
{
return mstrIsoOutletName;
}
else if (con_Text  ==  AttributeName[intIndex])
{
return mstrText;
}
else if (con_property  ==  AttributeName[intIndex])
{
return mstrproperty;
}
else if (con_destination  ==  AttributeName[intIndex])
{
return mstrdestination;
}
else if (con_CssClass  ==  AttributeName[intIndex])
{
return mstrCssClass;
}
else if (con_OnClick  ==  AttributeName[intIndex])
{
return mstrOnClick;
}
return null;
}
set
{
if (con_IsoOutletId  ==  AttributeName[intIndex])
{
mstrIsoOutletId = value.ToString();
}
else if (con_IsoOutletName  ==  AttributeName[intIndex])
{
mstrIsoOutletName = value.ToString();
}
else if (con_Text  ==  AttributeName[intIndex])
{
mstrText = value.ToString();
}
else if (con_property  ==  AttributeName[intIndex])
{
mstrproperty = value.ToString();
}
else if (con_destination  ==  AttributeName[intIndex])
{
mstrdestination = value.ToString();
}
else if (con_CssClass  ==  AttributeName[intIndex])
{
mstrCssClass = value.ToString();
}
else if (con_OnClick  ==  AttributeName[intIndex])
{
mstrOnClick = value.ToString();
}
}
}

/// <summary>
/// Iso变量链接Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string IsoOutletId
{
get
{
return mstrIsoOutletId;
}
set
{
if (value  ==  "")
{
 mstrIsoOutletId = value;
}
else
{
 mstrIsoOutletId = value;
}
}
}
/// <summary>
/// Iso变量链接名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string IsoOutletName
{
get
{
return mstrIsoOutletName;
}
set
{
if (value  ==  "")
{
 mstrIsoOutletName = value;
}
else
{
 mstrIsoOutletName = value;
}
}
}
/// <summary>
/// 文本(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string Text
{
get
{
return mstrText;
}
set
{
if (value  ==  "")
{
 mstrText = value;
}
else
{
 mstrText = value;
}
}
}
/// <summary>
/// 属性(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string property
{
get
{
return mstrproperty;
}
set
{
if (value  ==  "")
{
 mstrproperty = value;
}
else
{
 mstrproperty = value;
}
}
}
/// <summary>
/// 目标(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string destination
{
get
{
return mstrdestination;
}
set
{
if (value  ==  "")
{
 mstrdestination = value;
}
else
{
 mstrdestination = value;
}
}
}
/// <summary>
/// 样式表(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string CssClass
{
get
{
return mstrCssClass;
}
set
{
if (value  ==  "")
{
 mstrCssClass = value;
}
else
{
 mstrCssClass = value;
}
}
}
/// <summary>
/// 单击事件(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string OnClick
{
get
{
return mstrOnClick;
}
set
{
if (value  ==  "")
{
 mstrOnClick = value;
}
else
{
 mstrOnClick = value;
}
}
}
}
}