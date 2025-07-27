
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:AndroidToolbar
 表名:AndroidToolbar(00050401)
 生成代码版本:2019.10.18.1
 生成日期:2019/10/18 10:34:45
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:AGC
 工程ID:0005
 模块中文名:生成Android
 模块英文名:GCAndroid
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
 /// Android工具栏(AndroidToolbar)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class AndroidToolbar : AndroidControlEx
{
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"AndroidToolbarId", "AndroidToolbarName", "Text", "CssClass", "OnClick", "background", "popupTheme"};
//以下是属性变量

/// <summary>
/// AndroidToolbarId(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AndroidToolbarId
{
get
{
return mstrAndroidToolbarId;
}
set
{
if (value  ==  "")
{
 mstrAndroidToolbarId = value;
}
else
{
 mstrAndroidToolbarId = value;
}
}
}
/// <summary>
/// AndroidToolbarName(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AndroidToolbarName
{
get
{
return mstrAndroidToolbarName;
}
set
{
if (value  ==  "")
{
 mstrAndroidToolbarName = value;
}
else
{
 mstrAndroidToolbarName = value;
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
/// 背景(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string background
{
get
{
return mstrbackground;
}
set
{
if (value  ==  "")
{
 mstrbackground = value;
}
else
{
 mstrbackground = value;
}
}
}
/// <summary>
/// 弹出主题(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string popupTheme
{
get
{
return mstrpopupTheme;
}
set
{
if (value  ==  "")
{
 mstrpopupTheme = value;
}
else
{
 mstrpopupTheme = value;
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
if (strAttributeName  ==  con_AndroidToolbarId)
{
return mstrAndroidToolbarId;
}
else if (strAttributeName  ==  con_AndroidToolbarName)
{
return mstrAndroidToolbarName;
}
else if (strAttributeName  ==  con_Text)
{
return mstrText;
}
else if (strAttributeName  ==  con_CssClass)
{
return mstrCssClass;
}
else if (strAttributeName  ==  con_OnClick)
{
return mstrOnClick;
}
else if (strAttributeName  ==  con_background)
{
return mstrbackground;
}
else if (strAttributeName  ==  con_popupTheme)
{
return mstrpopupTheme;
}
return null;
}
set
{
if (strAttributeName  ==  con_AndroidToolbarId)
{
mstrAndroidToolbarId = value.ToString();
}
else if (strAttributeName  ==  con_AndroidToolbarName)
{
mstrAndroidToolbarName = value.ToString();
}
else if (strAttributeName  ==  con_Text)
{
mstrText = value.ToString();
}
else if (strAttributeName  ==  con_CssClass)
{
mstrCssClass = value.ToString();
}
else if (strAttributeName  ==  con_OnClick)
{
mstrOnClick = value.ToString();
}
else if (strAttributeName  ==  con_background)
{
mstrbackground = value.ToString();
}
else if (strAttributeName  ==  con_popupTheme)
{
mstrpopupTheme = value.ToString();
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
if (con_AndroidToolbarId  ==  AttributeName[intIndex])
{
return mstrAndroidToolbarId;
}
else if (con_AndroidToolbarName  ==  AttributeName[intIndex])
{
return mstrAndroidToolbarName;
}
else if (con_Text  ==  AttributeName[intIndex])
{
return mstrText;
}
else if (con_CssClass  ==  AttributeName[intIndex])
{
return mstrCssClass;
}
else if (con_OnClick  ==  AttributeName[intIndex])
{
return mstrOnClick;
}
else if (con_background  ==  AttributeName[intIndex])
{
return mstrbackground;
}
else if (con_popupTheme  ==  AttributeName[intIndex])
{
return mstrpopupTheme;
}
return null;
}
set
{
if (con_AndroidToolbarId  ==  AttributeName[intIndex])
{
mstrAndroidToolbarId = value.ToString();
}
else if (con_AndroidToolbarName  ==  AttributeName[intIndex])
{
mstrAndroidToolbarName = value.ToString();
}
else if (con_Text  ==  AttributeName[intIndex])
{
mstrText = value.ToString();
}
else if (con_CssClass  ==  AttributeName[intIndex])
{
mstrCssClass = value.ToString();
}
else if (con_OnClick  ==  AttributeName[intIndex])
{
mstrOnClick = value.ToString();
}
else if (con_background  ==  AttributeName[intIndex])
{
mstrbackground = value.ToString();
}
else if (con_popupTheme  ==  AttributeName[intIndex])
{
mstrpopupTheme = value.ToString();
}
}
}

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public AndroidToolbar()
 {
 }


 /// <summary>
 /// 常量:"AndroidToolbarId"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AndroidToolbarId = "AndroidToolbarId";    //AndroidToolbarId

 /// <summary>
 /// 常量:"AndroidToolbarName"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AndroidToolbarName = "AndroidToolbarName";    //AndroidToolbarName

 /// <summary>
 /// 常量:"Text"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Text = "Text";    //文本

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
 /// 常量:"background"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_background = "background";    //背景

 /// <summary>
 /// 常量:"popupTheme"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_popupTheme = "popupTheme";    //弹出主题

protected string mstrAndroidToolbarId;    //AndroidToolbarId
protected string mstrAndroidToolbarName;    //AndroidToolbarName
protected string mstrText;    //文本
protected string mstrCssClass;    //样式表
protected string mstrOnClick;    //单击事件
protected string mstrbackground;    //背景
protected string mstrpopupTheme;    //弹出主题
}
}