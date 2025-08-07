
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:AndroidAppBarLayout
 表名:AndroidAppBarLayout(00050400)
 生成代码版本:2021.07.29.1
 生成日期:2021/07/29 17:41:06
 生成者:pyf
 生成服务器IP:103.116.76.183
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
 /// AndroidAppBar布局(AndroidAppBarLayout)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class AndroidAppBarLayout : AndroidControlEx
{
protected const int mintAttributeCount = 6;
public static string[] AttributeName = new string[] {"AndroidAppBarLayoutId", "AndroidAppBarLayoutName", "Text", "CssClass", "OnClick", "theme"};
//以下是属性变量

protected string mstrAndroidAppBarLayoutId;    //AndroidAppBarLayoutId
protected string mstrAndroidAppBarLayoutName;    //AndroidAppBarLayoutName
protected string mstrText;    //文本
protected string mstrCssClass;    //样式表
protected string mstrOnClick;    //单击事件
protected string mstrtheme;    //主题


 /// <summary>
 /// 常量:"AndroidAppBarLayoutId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AndroidAppBarLayoutId = "AndroidAppBarLayoutId";    //AndroidAppBarLayoutId

 /// <summary>
 /// 常量:"AndroidAppBarLayoutName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AndroidAppBarLayoutName = "AndroidAppBarLayoutName";    //AndroidAppBarLayoutName

 /// <summary>
 /// 常量:"Text"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Text = "Text";    //文本

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
 /// 常量:"theme"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_theme = "theme";    //主题

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public AndroidAppBarLayout()
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
if (strAttributeName  ==  con_AndroidAppBarLayoutId)
{
return mstrAndroidAppBarLayoutId;
}
else if (strAttributeName  ==  con_AndroidAppBarLayoutName)
{
return mstrAndroidAppBarLayoutName;
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
return null;
}
set
{
if (strAttributeName  ==  con_AndroidAppBarLayoutId)
{
mstrAndroidAppBarLayoutId = value.ToString();
}
else if (strAttributeName  ==  con_AndroidAppBarLayoutName)
{
mstrAndroidAppBarLayoutName = value.ToString();
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
if (con_AndroidAppBarLayoutId  ==  AttributeName[intIndex])
{
return mstrAndroidAppBarLayoutId;
}
else if (con_AndroidAppBarLayoutName  ==  AttributeName[intIndex])
{
return mstrAndroidAppBarLayoutName;
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
return null;
}
set
{
if (con_AndroidAppBarLayoutId  ==  AttributeName[intIndex])
{
mstrAndroidAppBarLayoutId = value.ToString();
}
else if (con_AndroidAppBarLayoutName  ==  AttributeName[intIndex])
{
mstrAndroidAppBarLayoutName = value.ToString();
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
}
}

/// <summary>
/// AndroidAppBarLayoutId(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AndroidAppBarLayoutId
{
get
{
return mstrAndroidAppBarLayoutId;
}
set
{
if (value  ==  "")
{
 mstrAndroidAppBarLayoutId = value;
}
else
{
 mstrAndroidAppBarLayoutId = value;
}
}
}
/// <summary>
/// AndroidAppBarLayoutName(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AndroidAppBarLayoutName
{
get
{
return mstrAndroidAppBarLayoutName;
}
set
{
if (value  ==  "")
{
 mstrAndroidAppBarLayoutName = value;
}
else
{
 mstrAndroidAppBarLayoutName = value;
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
/// <summary>
/// 主题(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
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
}
}