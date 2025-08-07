
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:AndroidFloatingActionButton
 表名:AndroidFloatingActionButton(00050402)
 生成代码版本:2019.10.18.1
 生成日期:2019/10/18 10:34:39
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
 /// Android悬浮按钮(AndroidFloatingActionButton)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class AndroidFloatingActionButton : AndroidControlEx
{
protected const int mintAttributeCount = 8;
public static string[] AttributeName = new string[] {"AndroidFloatingActionButtonId", "AndroidFloatingActionButtonName", "Text", "CssClass", "OnClick", "theme", "srcCompat", "layout_gravity"};
//以下是属性变量

/// <summary>
/// AndroidFloatingActionButtonId(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AndroidFloatingActionButtonId
{
get
{
return mstrAndroidFloatingActionButtonId;
}
set
{
if (value  ==  "")
{
 mstrAndroidFloatingActionButtonId = value;
}
else
{
 mstrAndroidFloatingActionButtonId = value;
}
}
}
/// <summary>
/// AndroidFloatingActionButtonName(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AndroidFloatingActionButtonName
{
get
{
return mstrAndroidFloatingActionButtonName;
}
set
{
if (value  ==  "")
{
 mstrAndroidFloatingActionButtonName = value;
}
else
{
 mstrAndroidFloatingActionButtonName = value;
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
/// 主题(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string theme
{
get
{
return mstrtheme;
}
set
{
if (value  ==  "")
{
 mstrtheme = value;
}
else
{
 mstrtheme = value;
}
}
}
/// <summary>
/// srcCompat(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string srcCompat
{
get
{
return mstrsrcCompat;
}
set
{
if (value  ==  "")
{
 mstrsrcCompat = value;
}
else
{
 mstrsrcCompat = value;
}
}
}
/// <summary>
/// layout_gravity(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string layout_gravity
{
get
{
return mstrlayout_gravity;
}
set
{
if (value  ==  "")
{
 mstrlayout_gravity = value;
}
else
{
 mstrlayout_gravity = value;
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
if (strAttributeName  ==  con_AndroidFloatingActionButtonId)
{
return mstrAndroidFloatingActionButtonId;
}
else if (strAttributeName  ==  con_AndroidFloatingActionButtonName)
{
return mstrAndroidFloatingActionButtonName;
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
else if (strAttributeName  ==  con_theme)
{
return mstrtheme;
}
else if (strAttributeName  ==  con_srcCompat)
{
return mstrsrcCompat;
}
else if (strAttributeName  ==  con_layout_gravity)
{
return mstrlayout_gravity;
}
return null;
}
set
{
if (strAttributeName  ==  con_AndroidFloatingActionButtonId)
{
mstrAndroidFloatingActionButtonId = value.ToString();
}
else if (strAttributeName  ==  con_AndroidFloatingActionButtonName)
{
mstrAndroidFloatingActionButtonName = value.ToString();
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
else if (strAttributeName  ==  con_theme)
{
mstrtheme = value.ToString();
}
else if (strAttributeName  ==  con_srcCompat)
{
mstrsrcCompat = value.ToString();
}
else if (strAttributeName  ==  con_layout_gravity)
{
mstrlayout_gravity = value.ToString();
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
if (con_AndroidFloatingActionButtonId  ==  AttributeName[intIndex])
{
return mstrAndroidFloatingActionButtonId;
}
else if (con_AndroidFloatingActionButtonName  ==  AttributeName[intIndex])
{
return mstrAndroidFloatingActionButtonName;
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
else if (con_theme  ==  AttributeName[intIndex])
{
return mstrtheme;
}
else if (con_srcCompat  ==  AttributeName[intIndex])
{
return mstrsrcCompat;
}
else if (con_layout_gravity  ==  AttributeName[intIndex])
{
return mstrlayout_gravity;
}
return null;
}
set
{
if (con_AndroidFloatingActionButtonId  ==  AttributeName[intIndex])
{
mstrAndroidFloatingActionButtonId = value.ToString();
}
else if (con_AndroidFloatingActionButtonName  ==  AttributeName[intIndex])
{
mstrAndroidFloatingActionButtonName = value.ToString();
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
else if (con_theme  ==  AttributeName[intIndex])
{
mstrtheme = value.ToString();
}
else if (con_srcCompat  ==  AttributeName[intIndex])
{
mstrsrcCompat = value.ToString();
}
else if (con_layout_gravity  ==  AttributeName[intIndex])
{
mstrlayout_gravity = value.ToString();
}
}
}

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public AndroidFloatingActionButton()
 {
 }


 /// <summary>
 /// 常量:"AndroidFloatingActionButtonId"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AndroidFloatingActionButtonId = "AndroidFloatingActionButtonId";    //AndroidFloatingActionButtonId

 /// <summary>
 /// 常量:"AndroidFloatingActionButtonName"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AndroidFloatingActionButtonName = "AndroidFloatingActionButtonName";    //AndroidFloatingActionButtonName

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
 /// 常量:"theme"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_theme = "theme";    //主题

 /// <summary>
 /// 常量:"srcCompat"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_srcCompat = "srcCompat";    //srcCompat

 /// <summary>
 /// 常量:"layout_gravity"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_layout_gravity = "layout_gravity";    //layout_gravity

protected string mstrAndroidFloatingActionButtonId;    //AndroidFloatingActionButtonId
protected string mstrAndroidFloatingActionButtonName;    //AndroidFloatingActionButtonName
protected string mstrText;    //文本
protected string mstrCssClass;    //样式表
protected string mstrOnClick;    //单击事件
protected string mstrtheme;    //主题
protected string mstrsrcCompat;    //srcCompat
protected string mstrlayout_gravity;    //layout_gravity
}
}