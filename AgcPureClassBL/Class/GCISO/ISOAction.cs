
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ISOAction
 表名:ISOAction(00050368)
 生成代码版本:2019.10.18.1
 生成日期:2019/10/18 10:35:01
 生成者:
 生成服务器IP:101.251.68.133
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
 /// ISO行动(ISOAction)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ISOAction : ISOControlEx
{
protected const int mintAttributeCount = 11;
public static string[] AttributeName = new string[] {"IsoActionId", "IsoActionName", "Text", "property", "destination", "EventFuncName", "CssClass", "OnClick", "Style", "Width", "Height"};
//以下是属性变量

/// <summary>
/// Iso行动Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string IsoActionId
{
get
{
return mstrIsoActionId;
}
set
{
if (value  ==  "")
{
 mstrIsoActionId = value;
}
else
{
 mstrIsoActionId = value;
}
}
}
/// <summary>
/// Iso行动名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string IsoActionName
{
get
{
return mstrIsoActionName;
}
set
{
if (value  ==  "")
{
 mstrIsoActionName = value;
}
else
{
 mstrIsoActionName = value;
}
}
}
/// <summary>
/// 文本(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
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
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
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
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
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
/// 事件函数名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string EventFuncName
{
get
{
return mstrEventFuncName;
}
set
{
if (value  ==  "")
{
 mstrEventFuncName = value;
}
else
{
 mstrEventFuncName = value;
}
}
}
/// <summary>
/// 样式表(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
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
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
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
/// <summary>
/// 类型(说明:;字段类型:varchar;字段长度:800;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string Style
{
get
{
return mstrStyle;
}
set
{
if (value  ==  "")
{
 mstrStyle = value;
}
else
{
 mstrStyle = value;
}
}
}
/// <summary>
/// 宽(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public int Width
{
get
{
return mintWidth;
}
set
{
 mintWidth = value;
}
}
/// <summary>
/// 高度(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public int Height
{
get
{
return mintHeight;
}
set
{
 mintHeight = value;
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
if (strAttributeName  ==  con_IsoActionId)
{
return mstrIsoActionId;
}
else if (strAttributeName  ==  con_IsoActionName)
{
return mstrIsoActionName;
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
else if (strAttributeName  ==  con_EventFuncName)
{
return mstrEventFuncName;
}
else if (strAttributeName  ==  con_CssClass)
{
return mstrCssClass;
}
else if (strAttributeName  ==  con_OnClick)
{
return mstrOnClick;
}
else if (strAttributeName  ==  con_Style)
{
return mstrStyle;
}
else if (strAttributeName  ==  con_Width)
{
return mintWidth;
}
else if (strAttributeName  ==  con_Height)
{
return mintHeight;
}
return null;
}
set
{
if (strAttributeName  ==  con_IsoActionId)
{
mstrIsoActionId = value.ToString();
}
else if (strAttributeName  ==  con_IsoActionName)
{
mstrIsoActionName = value.ToString();
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
else if (strAttributeName  ==  con_EventFuncName)
{
mstrEventFuncName = value.ToString();
}
else if (strAttributeName  ==  con_CssClass)
{
mstrCssClass = value.ToString();
}
else if (strAttributeName  ==  con_OnClick)
{
mstrOnClick = value.ToString();
}
else if (strAttributeName  ==  con_Style)
{
mstrStyle = value.ToString();
}
else if (strAttributeName  ==  con_Width)
{
mintWidth = clsEntityBase2.TransNullToInt_S(value.ToString());
}
else if (strAttributeName  ==  con_Height)
{
mintHeight = clsEntityBase2.TransNullToInt_S(value.ToString());
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
if (con_IsoActionId  ==  AttributeName[intIndex])
{
return mstrIsoActionId;
}
else if (con_IsoActionName  ==  AttributeName[intIndex])
{
return mstrIsoActionName;
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
else if (con_EventFuncName  ==  AttributeName[intIndex])
{
return mstrEventFuncName;
}
else if (con_CssClass  ==  AttributeName[intIndex])
{
return mstrCssClass;
}
else if (con_OnClick  ==  AttributeName[intIndex])
{
return mstrOnClick;
}
else if (con_Style  ==  AttributeName[intIndex])
{
return mstrStyle;
}
else if (con_Width  ==  AttributeName[intIndex])
{
return mintWidth;
}
else if (con_Height  ==  AttributeName[intIndex])
{
return mintHeight;
}
return null;
}
set
{
if (con_IsoActionId  ==  AttributeName[intIndex])
{
mstrIsoActionId = value.ToString();
}
else if (con_IsoActionName  ==  AttributeName[intIndex])
{
mstrIsoActionName = value.ToString();
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
else if (con_EventFuncName  ==  AttributeName[intIndex])
{
mstrEventFuncName = value.ToString();
}
else if (con_CssClass  ==  AttributeName[intIndex])
{
mstrCssClass = value.ToString();
}
else if (con_OnClick  ==  AttributeName[intIndex])
{
mstrOnClick = value.ToString();
}
else if (con_Style  ==  AttributeName[intIndex])
{
mstrStyle = value.ToString();
}
else if (con_Width  ==  AttributeName[intIndex])
{
mintWidth = clsEntityBase2.TransNullToInt_S(value.ToString());
}
else if (con_Height  ==  AttributeName[intIndex])
{
mintHeight = clsEntityBase2.TransNullToInt_S(value.ToString());
}
}
}

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ISOAction()
 {
 }


 /// <summary>
 /// 常量:"IsoActionId"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsoActionId = "IsoActionId";    //Iso行动Id

 /// <summary>
 /// 常量:"IsoActionName"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsoActionName = "IsoActionName";    //Iso行动名

 /// <summary>
 /// 常量:"Text"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Text = "Text";    //文本

 /// <summary>
 /// 常量:"property"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_property = "property";    //属性

 /// <summary>
 /// 常量:"destination"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_destination = "destination";    //目标

 /// <summary>
 /// 常量:"EventFuncName"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_EventFuncName = "EventFuncName";    //事件函数名

 /// <summary>
 /// 常量:"CssClass"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_CssClass = "CssClass";    //样式表

 /// <summary>
 /// 常量:"OnClick"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_OnClick = "OnClick";    //单击事件

 /// <summary>
 /// 常量:"Style"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Style = "Style";    //类型

 /// <summary>
 /// 常量:"Width"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Width = "Width";    //宽

 /// <summary>
 /// 常量:"Height"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Height = "Height";    //高度

protected string mstrIsoActionId;    //Iso行动Id
protected string mstrIsoActionName;    //Iso行动名
protected string mstrText;    //文本
protected string mstrproperty;    //属性
protected string mstrdestination;    //目标
protected string mstrEventFuncName;    //事件函数名
protected string mstrCssClass;    //样式表
protected string mstrOnClick;    //单击事件
protected string mstrStyle;    //类型
protected int mintWidth;    //宽
protected int mintHeight;    //高度
}
}