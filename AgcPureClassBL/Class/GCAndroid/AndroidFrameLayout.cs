
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:AndroidFrameLayout
 表名:AndroidFrameLayout(00050381)
 生成代码版本:2019.10.18.1
 生成日期:2019/10/18 10:34:40
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
 /// Android框架布局(AndroidFrameLayout)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class AndroidFrameLayout : AndroidControlEx
{
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"AndroidFrameLayoutId", "AndroidFrameLayoutName", "Text", "CssClass", "OnClick", "layout_behavior", "context", "showIn", "orientation"};
//以下是属性变量

/// <summary>
/// AndroidFrameLayoutId(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AndroidFrameLayoutId
{
get
{
return mstrAndroidFrameLayoutId;
}
set
{
if (value  ==  "")
{
 mstrAndroidFrameLayoutId = value;
}
else
{
 mstrAndroidFrameLayoutId = value;
}
}
}
/// <summary>
/// AndroidFrameLayoutName(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AndroidFrameLayoutName
{
get
{
return mstrAndroidFrameLayoutName;
}
set
{
if (value  ==  "")
{
 mstrAndroidFrameLayoutName = value;
}
else
{
 mstrAndroidFrameLayoutName = value;
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
/// 方向(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string orientation
{
get
{
return mstrorientation;
}
set
{
if (value  ==  "")
{
 mstrorientation = value;
}
else
{
 mstrorientation = value;
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
if (strAttributeName  ==  con_AndroidFrameLayoutId)
{
return mstrAndroidFrameLayoutId;
}
else if (strAttributeName  ==  con_AndroidFrameLayoutName)
{
return mstrAndroidFrameLayoutName;
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
else if (strAttributeName  ==  con_orientation)
{
return mstrorientation;
}
return null;
}
set
{
if (strAttributeName  ==  con_AndroidFrameLayoutId)
{
mstrAndroidFrameLayoutId = value.ToString();
}
else if (strAttributeName  ==  con_AndroidFrameLayoutName)
{
mstrAndroidFrameLayoutName = value.ToString();
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
else if (strAttributeName  ==  con_orientation)
{
mstrorientation = value.ToString();
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
if (con_AndroidFrameLayoutId  ==  AttributeName[intIndex])
{
return mstrAndroidFrameLayoutId;
}
else if (con_AndroidFrameLayoutName  ==  AttributeName[intIndex])
{
return mstrAndroidFrameLayoutName;
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
else if (con_orientation  ==  AttributeName[intIndex])
{
return mstrorientation;
}
return null;
}
set
{
if (con_AndroidFrameLayoutId  ==  AttributeName[intIndex])
{
mstrAndroidFrameLayoutId = value.ToString();
}
else if (con_AndroidFrameLayoutName  ==  AttributeName[intIndex])
{
mstrAndroidFrameLayoutName = value.ToString();
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
else if (con_orientation  ==  AttributeName[intIndex])
{
mstrorientation = value.ToString();
}
}
}

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public AndroidFrameLayout()
 {
 }


 /// <summary>
 /// 常量:"AndroidFrameLayoutId"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AndroidFrameLayoutId = "AndroidFrameLayoutId";    //AndroidFrameLayoutId

 /// <summary>
 /// 常量:"AndroidFrameLayoutName"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AndroidFrameLayoutName = "AndroidFrameLayoutName";    //AndroidFrameLayoutName

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
 /// 常量:"orientation"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_orientation = "orientation";    //方向

protected string mstrAndroidFrameLayoutId;    //AndroidFrameLayoutId
protected string mstrAndroidFrameLayoutName;    //AndroidFrameLayoutName
protected string mstrText;    //文本
protected string mstrCssClass;    //样式表
protected string mstrOnClick;    //单击事件
protected string mstrlayout_behavior;    //布局行为
protected string mstrcontext;    //上下文
protected string mstrshowIn;    //显示在
protected string mstrorientation;    //方向
}
}