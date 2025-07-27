
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:AndroidConstraintLayout
 表名:AndroidConstraintLayout(00050377)
 生成代码版本:2019.10.18.1
 生成日期:2019/10/18 10:34:37
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
 /// Android约束布局(AndroidConstraintLayout)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class AndroidConstraintLayout : AndroidControlEx
{
protected const int mintAttributeCount = 11;
public static string[] AttributeName = new string[] {"AndroidConstraintLayoutId", "AndroidConstraintLayoutName", "Text", "CssClass", "OnClick", "layout_behavior", "context", "showIn", "android", "app", "tools"};
//以下是属性变量

/// <summary>
/// AndroidConstraintLayoutId(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AndroidConstraintLayoutId
{
get
{
return mstrAndroidConstraintLayoutId;
}
set
{
if (value  ==  "")
{
 mstrAndroidConstraintLayoutId = value;
}
else
{
 mstrAndroidConstraintLayoutId = value;
}
}
}
/// <summary>
/// AndroidConstraintLayoutName(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AndroidConstraintLayoutName
{
get
{
return mstrAndroidConstraintLayoutName;
}
set
{
if (value  ==  "")
{
 mstrAndroidConstraintLayoutName = value;
}
else
{
 mstrAndroidConstraintLayoutName = value;
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
/// 布局行为(说明:;字段类型:varchar;字段长度:300;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string layout_behavior
{
get
{
return mstrlayout_behavior;
}
set
{
if (value  ==  "")
{
 mstrlayout_behavior = value;
}
else
{
 mstrlayout_behavior = value;
}
}
}
/// <summary>
/// 上下文(说明:;字段类型:varchar;字段长度:300;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string context
{
get
{
return mstrcontext;
}
set
{
if (value  ==  "")
{
 mstrcontext = value;
}
else
{
 mstrcontext = value;
}
}
}
/// <summary>
/// 显示在(说明:;字段类型:varchar;字段长度:300;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string showIn
{
get
{
return mstrshowIn;
}
set
{
if (value  ==  "")
{
 mstrshowIn = value;
}
else
{
 mstrshowIn = value;
}
}
}
/// <summary>
/// android(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string android
{
get
{
return mstrandroid;
}
set
{
if (value  ==  "")
{
 mstrandroid = value;
}
else
{
 mstrandroid = value;
}
}
}
/// <summary>
/// app(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string app
{
get
{
return mstrapp;
}
set
{
if (value  ==  "")
{
 mstrapp = value;
}
else
{
 mstrapp = value;
}
}
}
/// <summary>
/// tools(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string tools
{
get
{
return mstrtools;
}
set
{
if (value  ==  "")
{
 mstrtools = value;
}
else
{
 mstrtools = value;
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
if (strAttributeName  ==  con_AndroidConstraintLayoutId)
{
return mstrAndroidConstraintLayoutId;
}
else if (strAttributeName  ==  con_AndroidConstraintLayoutName)
{
return mstrAndroidConstraintLayoutName;
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
else if (strAttributeName  ==  con_layout_behavior)
{
return mstrlayout_behavior;
}
else if (strAttributeName  ==  con_context)
{
return mstrcontext;
}
else if (strAttributeName  ==  con_showIn)
{
return mstrshowIn;
}
else if (strAttributeName  ==  con_android)
{
return mstrandroid;
}
else if (strAttributeName  ==  con_app)
{
return mstrapp;
}
else if (strAttributeName  ==  con_tools)
{
return mstrtools;
}
return null;
}
set
{
if (strAttributeName  ==  con_AndroidConstraintLayoutId)
{
mstrAndroidConstraintLayoutId = value.ToString();
}
else if (strAttributeName  ==  con_AndroidConstraintLayoutName)
{
mstrAndroidConstraintLayoutName = value.ToString();
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
else if (strAttributeName  ==  con_layout_behavior)
{
mstrlayout_behavior = value.ToString();
}
else if (strAttributeName  ==  con_context)
{
mstrcontext = value.ToString();
}
else if (strAttributeName  ==  con_showIn)
{
mstrshowIn = value.ToString();
}
else if (strAttributeName  ==  con_android)
{
mstrandroid = value.ToString();
}
else if (strAttributeName  ==  con_app)
{
mstrapp = value.ToString();
}
else if (strAttributeName  ==  con_tools)
{
mstrtools = value.ToString();
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
if (con_AndroidConstraintLayoutId  ==  AttributeName[intIndex])
{
return mstrAndroidConstraintLayoutId;
}
else if (con_AndroidConstraintLayoutName  ==  AttributeName[intIndex])
{
return mstrAndroidConstraintLayoutName;
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
else if (con_layout_behavior  ==  AttributeName[intIndex])
{
return mstrlayout_behavior;
}
else if (con_context  ==  AttributeName[intIndex])
{
return mstrcontext;
}
else if (con_showIn  ==  AttributeName[intIndex])
{
return mstrshowIn;
}
else if (con_android  ==  AttributeName[intIndex])
{
return mstrandroid;
}
else if (con_app  ==  AttributeName[intIndex])
{
return mstrapp;
}
else if (con_tools  ==  AttributeName[intIndex])
{
return mstrtools;
}
return null;
}
set
{
if (con_AndroidConstraintLayoutId  ==  AttributeName[intIndex])
{
mstrAndroidConstraintLayoutId = value.ToString();
}
else if (con_AndroidConstraintLayoutName  ==  AttributeName[intIndex])
{
mstrAndroidConstraintLayoutName = value.ToString();
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
else if (con_layout_behavior  ==  AttributeName[intIndex])
{
mstrlayout_behavior = value.ToString();
}
else if (con_context  ==  AttributeName[intIndex])
{
mstrcontext = value.ToString();
}
else if (con_showIn  ==  AttributeName[intIndex])
{
mstrshowIn = value.ToString();
}
else if (con_android  ==  AttributeName[intIndex])
{
mstrandroid = value.ToString();
}
else if (con_app  ==  AttributeName[intIndex])
{
mstrapp = value.ToString();
}
else if (con_tools  ==  AttributeName[intIndex])
{
mstrtools = value.ToString();
}
}
}

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public AndroidConstraintLayout()
 {
 }


 /// <summary>
 /// 常量:"AndroidConstraintLayoutId"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AndroidConstraintLayoutId = "AndroidConstraintLayoutId";    //AndroidConstraintLayoutId

 /// <summary>
 /// 常量:"AndroidConstraintLayoutName"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AndroidConstraintLayoutName = "AndroidConstraintLayoutName";    //AndroidConstraintLayoutName

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
 /// 常量:"layout_behavior"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_layout_behavior = "layout_behavior";    //布局行为

 /// <summary>
 /// 常量:"context"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_context = "context";    //上下文

 /// <summary>
 /// 常量:"showIn"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_showIn = "showIn";    //显示在

 /// <summary>
 /// 常量:"android"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_android = "android";    //android

 /// <summary>
 /// 常量:"app"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_app = "app";    //app

 /// <summary>
 /// 常量:"tools"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_tools = "tools";    //tools

protected string mstrAndroidConstraintLayoutId;    //AndroidConstraintLayoutId
protected string mstrAndroidConstraintLayoutName;    //AndroidConstraintLayoutName
protected string mstrText;    //文本
protected string mstrCssClass;    //样式表
protected string mstrOnClick;    //单击事件
protected string mstrlayout_behavior;    //布局行为
protected string mstrcontext;    //上下文
protected string mstrshowIn;    //显示在
protected string mstrandroid;    //android
protected string mstrapp;    //app
protected string mstrtools;    //tools
}
}