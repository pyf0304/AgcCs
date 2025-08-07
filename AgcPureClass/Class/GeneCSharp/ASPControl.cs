
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPControl
 表名:ASPControl(00050217)
 生成代码版本:2022.11.19.1
 生成日期:2022/11/19 17:47:25
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 模块中文名:生成C#代码(GeneCSharp)
 框架-层名:纯粹类(CS)(PureClass)
 编程语言:CSharp
 注意:1、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
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
 /// ASP控件(ASPControl)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPControl 
{
protected const int mintAttributeCount = 58;
public static string[] AttributeName = new string[] {"AspControlId", "AspControlName", "CtrlId", "CtrlName", "CtlTypeId", "Style", "Height", "Width", "Text", "Runat", "CssClass", "Class", "IsHaveChildCtl", "OrderNum", "mKey", "tools", "app", "android", "layout", "inputType", "ems", "popupTheme", "background", "layout_gravity", "srcCompat", "theme", "showIn", "layout_behavior", "context", "layout_margin", "layout_marginTop", "Tag", "layout_constraintTop_toTopOf", "layout_constraintTop_toBottomOf", "layout_constraintStart_toStartOf", "layout_constraintLeft_toLeftOf", "layout_constraintLeft_toRightOf", "scaleY", "scaleX", "layout_marginLeft", "mTextSize", "minHeight", "orientation", "scrollbars", "Value", "type", "tabindex", "role", "aria_labelledby", "aria_hidden", "data_dismiss", "aria_label", "GroupName", "OnClick", "CommandName", "Comment", "Cols", "Rows"};
//以下是属性变量

protected string mstrAspControlId;    //Asp控件Id
protected string mstrAspControlName;    //Asp控件名
protected string mstrCtrlId;    //控件Id
        protected string mstrRef;    //控件Id
        protected string mstrCtrlName;    //控件Name
protected string mstrCtlTypeId;    //控件类型号
protected string mstrStyle;    //类型
protected int mintHeight;    //高度
protected int mintWidth;    //宽
protected string mstrText;    //文本
protected string mstrRunat;    //运行在
protected string mstrCssClass;    //样式表
protected string mstrClass;    //样式表类
protected bool mbolIsHaveChildCtl;    //是否有子控件
protected int mintOrderNum;    //序号
protected string mstrmKey;    //关键字
protected string mstrtools;    //tools
protected string mstrapp;    //app
protected string mstrandroid;    //android
protected string mstrlayout;    //布局
protected string mstrinputType;    //输入类型
protected int mintems;    //字符宽度
protected string mstrpopupTheme;    //弹出主题
protected string mstrbackground;    //背景
protected string mstrlayout_gravity;    //layout_gravity
protected string mstrsrcCompat;    //srcCompat
protected string mstrtheme;    //主题
protected string mstrshowIn;    //显示在
protected string mstrlayout_behavior;    //布局行为
protected string mstrcontext;    //上下文
protected string mstrlayout_margin;    //页边距
protected int mintlayout_marginTop;    //顶空
protected string mstrTag;    //Tag
protected string mstrlayout_constraintTop_toTopOf;    //约束顶相对于顶
protected string mstrlayout_constraintTop_toBottomOf;    //约束顶相对于底
protected string mstrlayout_constraintStart_toStartOf;    //约束开始相对于开始
protected string mstrlayout_constraintLeft_toLeftOf;    //约束左相对于左
protected string mstrlayout_constraintLeft_toRightOf;    //约束左相对于右
protected string mstrscaleY;    //缩放Y
protected string mstrscaleX;    //缩放X
protected int mintlayout_marginLeft;    //左边空
protected string mstrmTextSize;    //文本尺寸
protected string mstrminHeight;    //最小高度
protected string mstrorientation;    //方向
protected string mstrscrollbars;    //滚动条
protected string mstrValue;    //值
protected string mstrtype;    //类型
protected string mstrtabindex;    //tabindex
protected string mstrrole;    //role
protected string mstraria_labelledby;    //aria-labelledby
protected string mstraria_hidden;    //aria-hidden
protected string mstrdata_dismiss;    //data-dismiss
protected string mstraria_label;    //aria-label
protected string mstrGroupName;    //组名
protected string mstrOnClick;    //单击事件
protected string mstrCommandName;    //命令名
protected string mstrComment;    //注释
protected int mintCols;    //列数
protected int mintRows;    //行数


 /// <summary>
 /// 常量:"AspControlId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspControlId = "AspControlId";    //Asp控件Id

 /// <summary>
 /// 常量:"AspControlName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspControlName = "AspControlName";    //Asp控件名

 /// <summary>
 /// 常量:"CtrlId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_CtrlId = "CtrlId";    //控件Id

 /// <summary>
 /// 常量:"CtrlName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_CtrlName = "CtrlName";    //控件Name

 /// <summary>
 /// 常量:"CtlTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_CtlTypeId = "CtlTypeId";    //控件类型号

 /// <summary>
 /// 常量:"Style"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Style = "Style";    //类型

 /// <summary>
 /// 常量:"Height"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Height = "Height";    //高度

 /// <summary>
 /// 常量:"Width"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Width = "Width";    //宽

 /// <summary>
 /// 常量:"Text"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Text = "Text";    //文本

 /// <summary>
 /// 常量:"Runat"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Runat = "Runat";    //运行在

 /// <summary>
 /// 常量:"CssClass"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_CssClass = "CssClass";    //样式表

 /// <summary>
 /// 常量:"Class"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Class = "Class";    //样式表类

 /// <summary>
 /// 常量:"IsHaveChildCtl"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsHaveChildCtl = "IsHaveChildCtl";    //是否有子控件

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"mKey"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_mKey = "mKey";    //关键字

 /// <summary>
 /// 常量:"tools"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_tools = "tools";    //tools

 /// <summary>
 /// 常量:"app"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_app = "app";    //app

 /// <summary>
 /// 常量:"android"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_android = "android";    //android

 /// <summary>
 /// 常量:"layout"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_layout = "layout";    //布局

 /// <summary>
 /// 常量:"inputType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_inputType = "inputType";    //输入类型

 /// <summary>
 /// 常量:"ems"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ems = "ems";    //字符宽度

 /// <summary>
 /// 常量:"popupTheme"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_popupTheme = "popupTheme";    //弹出主题

 /// <summary>
 /// 常量:"background"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_background = "background";    //背景

 /// <summary>
 /// 常量:"layout_gravity"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_layout_gravity = "layout_gravity";    //layout_gravity

 /// <summary>
 /// 常量:"srcCompat"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_srcCompat = "srcCompat";    //srcCompat

 /// <summary>
 /// 常量:"theme"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_theme = "theme";    //主题

 /// <summary>
 /// 常量:"showIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_showIn = "showIn";    //显示在

 /// <summary>
 /// 常量:"layout_behavior"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_layout_behavior = "layout_behavior";    //布局行为

 /// <summary>
 /// 常量:"context"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_context = "context";    //上下文

 /// <summary>
 /// 常量:"layout_margin"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_layout_margin = "layout_margin";    //页边距

 /// <summary>
 /// 常量:"layout_marginTop"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_layout_marginTop = "layout_marginTop";    //顶空

 /// <summary>
 /// 常量:"Tag"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Tag = "Tag";    //Tag

 /// <summary>
 /// 常量:"layout_constraintTop_toTopOf"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_layout_constraintTop_toTopOf = "layout_constraintTop_toTopOf";    //约束顶相对于顶

 /// <summary>
 /// 常量:"layout_constraintTop_toBottomOf"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_layout_constraintTop_toBottomOf = "layout_constraintTop_toBottomOf";    //约束顶相对于底

 /// <summary>
 /// 常量:"layout_constraintStart_toStartOf"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_layout_constraintStart_toStartOf = "layout_constraintStart_toStartOf";    //约束开始相对于开始

 /// <summary>
 /// 常量:"layout_constraintLeft_toLeftOf"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_layout_constraintLeft_toLeftOf = "layout_constraintLeft_toLeftOf";    //约束左相对于左

 /// <summary>
 /// 常量:"layout_constraintLeft_toRightOf"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_layout_constraintLeft_toRightOf = "layout_constraintLeft_toRightOf";    //约束左相对于右

 /// <summary>
 /// 常量:"scaleY"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_scaleY = "scaleY";    //缩放Y

 /// <summary>
 /// 常量:"scaleX"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_scaleX = "scaleX";    //缩放X

 /// <summary>
 /// 常量:"layout_marginLeft"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_layout_marginLeft = "layout_marginLeft";    //左边空

 /// <summary>
 /// 常量:"mTextSize"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_mTextSize = "mTextSize";    //文本尺寸

 /// <summary>
 /// 常量:"minHeight"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_minHeight = "minHeight";    //最小高度

 /// <summary>
 /// 常量:"orientation"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_orientation = "orientation";    //方向

 /// <summary>
 /// 常量:"scrollbars"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_scrollbars = "scrollbars";    //滚动条

 /// <summary>
 /// 常量:"Value"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Value = "Value";    //值

 /// <summary>
 /// 常量:"type"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_type = "type";    //类型

 /// <summary>
 /// 常量:"tabindex"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_tabindex = "tabindex";    //tabindex

 /// <summary>
 /// 常量:"role"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_role = "role";    //role

 /// <summary>
 /// 常量:"aria_labelledby"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_aria_labelledby = "aria_labelledby";    //aria-labelledby

 /// <summary>
 /// 常量:"aria_hidden"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_aria_hidden = "aria_hidden";    //aria-hidden

 /// <summary>
 /// 常量:"data_dismiss"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_data_dismiss = "data_dismiss";    //data-dismiss

 /// <summary>
 /// 常量:"aria_label"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_aria_label = "aria_label";    //aria-label

 /// <summary>
 /// 常量:"GroupName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_GroupName = "GroupName";    //组名

 /// <summary>
 /// 常量:"OnClick"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_OnClick = "OnClick";    //单击事件

 /// <summary>
 /// 常量:"CommandName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_CommandName = "CommandName";    //命令名

 /// <summary>
 /// 常量:"Comment"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Comment = "Comment";    //注释

 /// <summary>
 /// 常量:"Cols"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Cols = "Cols";    //列数

 /// <summary>
 /// 常量:"Rows"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Rows = "Rows";    //行数

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPControl()
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
if (strAttributeName  ==  con_AspControlId)
{
return mstrAspControlId;
}
else if (strAttributeName  ==  con_AspControlName)
{
return mstrAspControlName;
}
else if (strAttributeName  ==  con_CtrlId)
{
return mstrCtrlId;
}
else if (strAttributeName  ==  con_CtrlName)
{
return mstrCtrlName;
}
else if (strAttributeName  ==  con_CtlTypeId)
{
return mstrCtlTypeId;
}
else if (strAttributeName  ==  con_Style)
{
return mstrStyle;
}
else if (strAttributeName  ==  con_Height)
{
return mintHeight;
}
else if (strAttributeName  ==  con_Width)
{
return mintWidth;
}
else if (strAttributeName  ==  con_Text)
{
return mstrText;
}
else if (strAttributeName  ==  con_Runat)
{
return mstrRunat;
}
else if (strAttributeName  ==  con_CssClass)
{
return mstrCssClass;
}
else if (strAttributeName  ==  con_Class)
{
return mstrClass;
}
else if (strAttributeName  ==  con_IsHaveChildCtl)
{
return mbolIsHaveChildCtl;
}
else if (strAttributeName  ==  con_OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  con_mKey)
{
return mstrmKey;
}
else if (strAttributeName  ==  con_tools)
{
return mstrtools;
}
else if (strAttributeName  ==  con_app)
{
return mstrapp;
}
else if (strAttributeName  ==  con_android)
{
return mstrandroid;
}
else if (strAttributeName  ==  con_layout)
{
return mstrlayout;
}
else if (strAttributeName  ==  con_inputType)
{
return mstrinputType;
}
else if (strAttributeName  ==  con_ems)
{
return mintems;
}
else if (strAttributeName  ==  con_popupTheme)
{
return mstrpopupTheme;
}
else if (strAttributeName  ==  con_background)
{
return mstrbackground;
}
else if (strAttributeName  ==  con_layout_gravity)
{
return mstrlayout_gravity;
}
else if (strAttributeName  ==  con_srcCompat)
{
return mstrsrcCompat;
}
else if (strAttributeName  ==  con_theme)
{
return mstrtheme;
}
else if (strAttributeName  ==  con_showIn)
{
return mstrshowIn;
}
else if (strAttributeName  ==  con_layout_behavior)
{
return mstrlayout_behavior;
}
else if (strAttributeName  ==  con_context)
{
return mstrcontext;
}
else if (strAttributeName  ==  con_layout_margin)
{
return mstrlayout_margin;
}
else if (strAttributeName  ==  con_layout_marginTop)
{
return mintlayout_marginTop;
}
else if (strAttributeName  ==  con_Tag)
{
return mstrTag;
}
else if (strAttributeName  ==  con_layout_constraintTop_toTopOf)
{
return mstrlayout_constraintTop_toTopOf;
}
else if (strAttributeName  ==  con_layout_constraintTop_toBottomOf)
{
return mstrlayout_constraintTop_toBottomOf;
}
else if (strAttributeName  ==  con_layout_constraintStart_toStartOf)
{
return mstrlayout_constraintStart_toStartOf;
}
else if (strAttributeName  ==  con_layout_constraintLeft_toLeftOf)
{
return mstrlayout_constraintLeft_toLeftOf;
}
else if (strAttributeName  ==  con_layout_constraintLeft_toRightOf)
{
return mstrlayout_constraintLeft_toRightOf;
}
else if (strAttributeName  ==  con_scaleY)
{
return mstrscaleY;
}
else if (strAttributeName  ==  con_scaleX)
{
return mstrscaleX;
}
else if (strAttributeName  ==  con_layout_marginLeft)
{
return mintlayout_marginLeft;
}
else if (strAttributeName  ==  con_mTextSize)
{
return mstrmTextSize;
}
else if (strAttributeName  ==  con_minHeight)
{
return mstrminHeight;
}
else if (strAttributeName  ==  con_orientation)
{
return mstrorientation;
}
else if (strAttributeName  ==  con_scrollbars)
{
return mstrscrollbars;
}
else if (strAttributeName  ==  con_Value)
{
return mstrValue;
}
else if (strAttributeName  ==  con_type)
{
return mstrtype;
}
else if (strAttributeName  ==  con_tabindex)
{
return mstrtabindex;
}
else if (strAttributeName  ==  con_role)
{
return mstrrole;
}
else if (strAttributeName  ==  con_aria_labelledby)
{
return mstraria_labelledby;
}
else if (strAttributeName  ==  con_aria_hidden)
{
return mstraria_hidden;
}
else if (strAttributeName  ==  con_data_dismiss)
{
return mstrdata_dismiss;
}
else if (strAttributeName  ==  con_aria_label)
{
return mstraria_label;
}
else if (strAttributeName  ==  con_GroupName)
{
return mstrGroupName;
}
else if (strAttributeName  ==  con_OnClick)
{
return mstrOnClick;
}
else if (strAttributeName  ==  con_CommandName)
{
return mstrCommandName;
}
else if (strAttributeName  ==  con_Comment)
{
return mstrComment;
}
else if (strAttributeName  ==  con_Cols)
{
return mintCols;
}
else if (strAttributeName  ==  con_Rows)
{
return mintRows;
}
return null;
}
set
{
if (strAttributeName  ==  con_AspControlId)
{
mstrAspControlId = value.ToString();
}
else if (strAttributeName  ==  con_AspControlName)
{
mstrAspControlName = value.ToString();
}
else if (strAttributeName  ==  con_CtrlId)
{
mstrCtrlId = value.ToString();
}
else if (strAttributeName  ==  con_CtrlName)
{
mstrCtrlName = value.ToString();
}
else if (strAttributeName  ==  con_CtlTypeId)
{
mstrCtlTypeId = value.ToString();
}
else if (strAttributeName  ==  con_Style)
{
mstrStyle = value.ToString();
}
else if (strAttributeName  ==  con_Height)
{
mintHeight = clsEntityBase2.TransNullToInt_S(value.ToString());
}
else if (strAttributeName  ==  con_Width)
{
mintWidth = clsEntityBase2.TransNullToInt_S(value.ToString());
}
else if (strAttributeName  ==  con_Text)
{
mstrText = value.ToString();
}
else if (strAttributeName  ==  con_Runat)
{
mstrRunat = value.ToString();
}
else if (strAttributeName  ==  con_CssClass)
{
mstrCssClass = value.ToString();
}
else if (strAttributeName  ==  con_Class)
{
mstrClass = value.ToString();
}
else if (strAttributeName  ==  con_IsHaveChildCtl)
{
mbolIsHaveChildCtl = clsEntityBase2.TransNullToBool_S(value.ToString());
}
else if (strAttributeName  ==  con_OrderNum)
{
mintOrderNum = clsEntityBase2.TransNullToInt_S(value.ToString());
}
else if (strAttributeName  ==  con_mKey)
{
mstrmKey = value.ToString();
}
else if (strAttributeName  ==  con_tools)
{
mstrtools = value.ToString();
}
else if (strAttributeName  ==  con_app)
{
mstrapp = value.ToString();
}
else if (strAttributeName  ==  con_android)
{
mstrandroid = value.ToString();
}
else if (strAttributeName  ==  con_layout)
{
mstrlayout = value.ToString();
}
else if (strAttributeName  ==  con_inputType)
{
mstrinputType = value.ToString();
}
else if (strAttributeName  ==  con_ems)
{
mintems = clsEntityBase2.TransNullToInt_S(value.ToString());
}
else if (strAttributeName  ==  con_popupTheme)
{
mstrpopupTheme = value.ToString();
}
else if (strAttributeName  ==  con_background)
{
mstrbackground = value.ToString();
}
else if (strAttributeName  ==  con_layout_gravity)
{
mstrlayout_gravity = value.ToString();
}
else if (strAttributeName  ==  con_srcCompat)
{
mstrsrcCompat = value.ToString();
}
else if (strAttributeName  ==  con_theme)
{
mstrtheme = value.ToString();
}
else if (strAttributeName  ==  con_showIn)
{
mstrshowIn = value.ToString();
}
else if (strAttributeName  ==  con_layout_behavior)
{
mstrlayout_behavior = value.ToString();
}
else if (strAttributeName  ==  con_context)
{
mstrcontext = value.ToString();
}
else if (strAttributeName  ==  con_layout_margin)
{
mstrlayout_margin = value.ToString();
}
else if (strAttributeName  ==  con_layout_marginTop)
{
mintlayout_marginTop = clsEntityBase2.TransNullToInt_S(value.ToString());
}
else if (strAttributeName  ==  con_Tag)
{
mstrTag = value.ToString();
}
else if (strAttributeName  ==  con_layout_constraintTop_toTopOf)
{
mstrlayout_constraintTop_toTopOf = value.ToString();
}
else if (strAttributeName  ==  con_layout_constraintTop_toBottomOf)
{
mstrlayout_constraintTop_toBottomOf = value.ToString();
}
else if (strAttributeName  ==  con_layout_constraintStart_toStartOf)
{
mstrlayout_constraintStart_toStartOf = value.ToString();
}
else if (strAttributeName  ==  con_layout_constraintLeft_toLeftOf)
{
mstrlayout_constraintLeft_toLeftOf = value.ToString();
}
else if (strAttributeName  ==  con_layout_constraintLeft_toRightOf)
{
mstrlayout_constraintLeft_toRightOf = value.ToString();
}
else if (strAttributeName  ==  con_scaleY)
{
mstrscaleY = value.ToString();
}
else if (strAttributeName  ==  con_scaleX)
{
mstrscaleX = value.ToString();
}
else if (strAttributeName  ==  con_layout_marginLeft)
{
mintlayout_marginLeft = clsEntityBase2.TransNullToInt_S(value.ToString());
}
else if (strAttributeName  ==  con_mTextSize)
{
mstrmTextSize = value.ToString();
}
else if (strAttributeName  ==  con_minHeight)
{
mstrminHeight = value.ToString();
}
else if (strAttributeName  ==  con_orientation)
{
mstrorientation = value.ToString();
}
else if (strAttributeName  ==  con_scrollbars)
{
mstrscrollbars = value.ToString();
}
else if (strAttributeName  ==  con_Value)
{
mstrValue = value.ToString();
}
else if (strAttributeName  ==  con_type)
{
mstrtype = value.ToString();
}
else if (strAttributeName  ==  con_tabindex)
{
mstrtabindex = value.ToString();
}
else if (strAttributeName  ==  con_role)
{
mstrrole = value.ToString();
}
else if (strAttributeName  ==  con_aria_labelledby)
{
mstraria_labelledby = value.ToString();
}
else if (strAttributeName  ==  con_aria_hidden)
{
mstraria_hidden = value.ToString();
}
else if (strAttributeName  ==  con_data_dismiss)
{
mstrdata_dismiss = value.ToString();
}
else if (strAttributeName  ==  con_aria_label)
{
mstraria_label = value.ToString();
}
else if (strAttributeName  ==  con_GroupName)
{
mstrGroupName = value.ToString();
}
else if (strAttributeName  ==  con_OnClick)
{
mstrOnClick = value.ToString();
}
else if (strAttributeName  ==  con_CommandName)
{
mstrCommandName = value.ToString();
}
else if (strAttributeName  ==  con_Comment)
{
mstrComment = value.ToString();
}
else if (strAttributeName  ==  con_Cols)
{
mintCols = clsEntityBase2.TransNullToInt_S(value.ToString());
}
else if (strAttributeName  ==  con_Rows)
{
mintRows = clsEntityBase2.TransNullToInt_S(value.ToString());
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
if (con_AspControlId  ==  AttributeName[intIndex])
{
return mstrAspControlId;
}
else if (con_AspControlName  ==  AttributeName[intIndex])
{
return mstrAspControlName;
}
else if (con_CtrlId  ==  AttributeName[intIndex])
{
return mstrCtrlId;
}
else if (con_CtrlName  ==  AttributeName[intIndex])
{
return mstrCtrlName;
}
else if (con_CtlTypeId  ==  AttributeName[intIndex])
{
return mstrCtlTypeId;
}
else if (con_Style  ==  AttributeName[intIndex])
{
return mstrStyle;
}
else if (con_Height  ==  AttributeName[intIndex])
{
return mintHeight;
}
else if (con_Width  ==  AttributeName[intIndex])
{
return mintWidth;
}
else if (con_Text  ==  AttributeName[intIndex])
{
return mstrText;
}
else if (con_Runat  ==  AttributeName[intIndex])
{
return mstrRunat;
}
else if (con_CssClass  ==  AttributeName[intIndex])
{
return mstrCssClass;
}
else if (con_Class  ==  AttributeName[intIndex])
{
return mstrClass;
}
else if (con_IsHaveChildCtl  ==  AttributeName[intIndex])
{
return mbolIsHaveChildCtl;
}
else if (con_OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (con_mKey  ==  AttributeName[intIndex])
{
return mstrmKey;
}
else if (con_tools  ==  AttributeName[intIndex])
{
return mstrtools;
}
else if (con_app  ==  AttributeName[intIndex])
{
return mstrapp;
}
else if (con_android  ==  AttributeName[intIndex])
{
return mstrandroid;
}
else if (con_layout  ==  AttributeName[intIndex])
{
return mstrlayout;
}
else if (con_inputType  ==  AttributeName[intIndex])
{
return mstrinputType;
}
else if (con_ems  ==  AttributeName[intIndex])
{
return mintems;
}
else if (con_popupTheme  ==  AttributeName[intIndex])
{
return mstrpopupTheme;
}
else if (con_background  ==  AttributeName[intIndex])
{
return mstrbackground;
}
else if (con_layout_gravity  ==  AttributeName[intIndex])
{
return mstrlayout_gravity;
}
else if (con_srcCompat  ==  AttributeName[intIndex])
{
return mstrsrcCompat;
}
else if (con_theme  ==  AttributeName[intIndex])
{
return mstrtheme;
}
else if (con_showIn  ==  AttributeName[intIndex])
{
return mstrshowIn;
}
else if (con_layout_behavior  ==  AttributeName[intIndex])
{
return mstrlayout_behavior;
}
else if (con_context  ==  AttributeName[intIndex])
{
return mstrcontext;
}
else if (con_layout_margin  ==  AttributeName[intIndex])
{
return mstrlayout_margin;
}
else if (con_layout_marginTop  ==  AttributeName[intIndex])
{
return mintlayout_marginTop;
}
else if (con_Tag  ==  AttributeName[intIndex])
{
return mstrTag;
}
else if (con_layout_constraintTop_toTopOf  ==  AttributeName[intIndex])
{
return mstrlayout_constraintTop_toTopOf;
}
else if (con_layout_constraintTop_toBottomOf  ==  AttributeName[intIndex])
{
return mstrlayout_constraintTop_toBottomOf;
}
else if (con_layout_constraintStart_toStartOf  ==  AttributeName[intIndex])
{
return mstrlayout_constraintStart_toStartOf;
}
else if (con_layout_constraintLeft_toLeftOf  ==  AttributeName[intIndex])
{
return mstrlayout_constraintLeft_toLeftOf;
}
else if (con_layout_constraintLeft_toRightOf  ==  AttributeName[intIndex])
{
return mstrlayout_constraintLeft_toRightOf;
}
else if (con_scaleY  ==  AttributeName[intIndex])
{
return mstrscaleY;
}
else if (con_scaleX  ==  AttributeName[intIndex])
{
return mstrscaleX;
}
else if (con_layout_marginLeft  ==  AttributeName[intIndex])
{
return mintlayout_marginLeft;
}
else if (con_mTextSize  ==  AttributeName[intIndex])
{
return mstrmTextSize;
}
else if (con_minHeight  ==  AttributeName[intIndex])
{
return mstrminHeight;
}
else if (con_orientation  ==  AttributeName[intIndex])
{
return mstrorientation;
}
else if (con_scrollbars  ==  AttributeName[intIndex])
{
return mstrscrollbars;
}
else if (con_Value  ==  AttributeName[intIndex])
{
return mstrValue;
}
else if (con_type  ==  AttributeName[intIndex])
{
return mstrtype;
}
else if (con_tabindex  ==  AttributeName[intIndex])
{
return mstrtabindex;
}
else if (con_role  ==  AttributeName[intIndex])
{
return mstrrole;
}
else if (con_aria_labelledby  ==  AttributeName[intIndex])
{
return mstraria_labelledby;
}
else if (con_aria_hidden  ==  AttributeName[intIndex])
{
return mstraria_hidden;
}
else if (con_data_dismiss  ==  AttributeName[intIndex])
{
return mstrdata_dismiss;
}
else if (con_aria_label  ==  AttributeName[intIndex])
{
return mstraria_label;
}
else if (con_GroupName  ==  AttributeName[intIndex])
{
return mstrGroupName;
}
else if (con_OnClick  ==  AttributeName[intIndex])
{
return mstrOnClick;
}
else if (con_CommandName  ==  AttributeName[intIndex])
{
return mstrCommandName;
}
else if (con_Comment  ==  AttributeName[intIndex])
{
return mstrComment;
}
else if (con_Cols  ==  AttributeName[intIndex])
{
return mintCols;
}
else if (con_Rows  ==  AttributeName[intIndex])
{
return mintRows;
}
return null;
}
set
{
if (con_AspControlId  ==  AttributeName[intIndex])
{
mstrAspControlId = value.ToString();
}
else if (con_AspControlName  ==  AttributeName[intIndex])
{
mstrAspControlName = value.ToString();
}
else if (con_CtrlId  ==  AttributeName[intIndex])
{
mstrCtrlId = value.ToString();
}
else if (con_CtrlName  ==  AttributeName[intIndex])
{
mstrCtrlName = value.ToString();
}
else if (con_CtlTypeId  ==  AttributeName[intIndex])
{
mstrCtlTypeId = value.ToString();
}
else if (con_Style  ==  AttributeName[intIndex])
{
mstrStyle = value.ToString();
}
else if (con_Height  ==  AttributeName[intIndex])
{
mintHeight = clsEntityBase2.TransNullToInt_S(value.ToString());
}
else if (con_Width  ==  AttributeName[intIndex])
{
mintWidth = clsEntityBase2.TransNullToInt_S(value.ToString());
}
else if (con_Text  ==  AttributeName[intIndex])
{
mstrText = value.ToString();
}
else if (con_Runat  ==  AttributeName[intIndex])
{
mstrRunat = value.ToString();
}
else if (con_CssClass  ==  AttributeName[intIndex])
{
mstrCssClass = value.ToString();
}
else if (con_Class  ==  AttributeName[intIndex])
{
mstrClass = value.ToString();
}
else if (con_IsHaveChildCtl  ==  AttributeName[intIndex])
{
mbolIsHaveChildCtl = clsEntityBase2.TransNullToBool_S(value.ToString());
}
else if (con_OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = clsEntityBase2.TransNullToInt_S(value.ToString());
}
else if (con_mKey  ==  AttributeName[intIndex])
{
mstrmKey = value.ToString();
}
else if (con_tools  ==  AttributeName[intIndex])
{
mstrtools = value.ToString();
}
else if (con_app  ==  AttributeName[intIndex])
{
mstrapp = value.ToString();
}
else if (con_android  ==  AttributeName[intIndex])
{
mstrandroid = value.ToString();
}
else if (con_layout  ==  AttributeName[intIndex])
{
mstrlayout = value.ToString();
}
else if (con_inputType  ==  AttributeName[intIndex])
{
mstrinputType = value.ToString();
}
else if (con_ems  ==  AttributeName[intIndex])
{
mintems = clsEntityBase2.TransNullToInt_S(value.ToString());
}
else if (con_popupTheme  ==  AttributeName[intIndex])
{
mstrpopupTheme = value.ToString();
}
else if (con_background  ==  AttributeName[intIndex])
{
mstrbackground = value.ToString();
}
else if (con_layout_gravity  ==  AttributeName[intIndex])
{
mstrlayout_gravity = value.ToString();
}
else if (con_srcCompat  ==  AttributeName[intIndex])
{
mstrsrcCompat = value.ToString();
}
else if (con_theme  ==  AttributeName[intIndex])
{
mstrtheme = value.ToString();
}
else if (con_showIn  ==  AttributeName[intIndex])
{
mstrshowIn = value.ToString();
}
else if (con_layout_behavior  ==  AttributeName[intIndex])
{
mstrlayout_behavior = value.ToString();
}
else if (con_context  ==  AttributeName[intIndex])
{
mstrcontext = value.ToString();
}
else if (con_layout_margin  ==  AttributeName[intIndex])
{
mstrlayout_margin = value.ToString();
}
else if (con_layout_marginTop  ==  AttributeName[intIndex])
{
mintlayout_marginTop = clsEntityBase2.TransNullToInt_S(value.ToString());
}
else if (con_Tag  ==  AttributeName[intIndex])
{
mstrTag = value.ToString();
}
else if (con_layout_constraintTop_toTopOf  ==  AttributeName[intIndex])
{
mstrlayout_constraintTop_toTopOf = value.ToString();
}
else if (con_layout_constraintTop_toBottomOf  ==  AttributeName[intIndex])
{
mstrlayout_constraintTop_toBottomOf = value.ToString();
}
else if (con_layout_constraintStart_toStartOf  ==  AttributeName[intIndex])
{
mstrlayout_constraintStart_toStartOf = value.ToString();
}
else if (con_layout_constraintLeft_toLeftOf  ==  AttributeName[intIndex])
{
mstrlayout_constraintLeft_toLeftOf = value.ToString();
}
else if (con_layout_constraintLeft_toRightOf  ==  AttributeName[intIndex])
{
mstrlayout_constraintLeft_toRightOf = value.ToString();
}
else if (con_scaleY  ==  AttributeName[intIndex])
{
mstrscaleY = value.ToString();
}
else if (con_scaleX  ==  AttributeName[intIndex])
{
mstrscaleX = value.ToString();
}
else if (con_layout_marginLeft  ==  AttributeName[intIndex])
{
mintlayout_marginLeft = clsEntityBase2.TransNullToInt_S(value.ToString());
}
else if (con_mTextSize  ==  AttributeName[intIndex])
{
mstrmTextSize = value.ToString();
}
else if (con_minHeight  ==  AttributeName[intIndex])
{
mstrminHeight = value.ToString();
}
else if (con_orientation  ==  AttributeName[intIndex])
{
mstrorientation = value.ToString();
}
else if (con_scrollbars  ==  AttributeName[intIndex])
{
mstrscrollbars = value.ToString();
}
else if (con_Value  ==  AttributeName[intIndex])
{
mstrValue = value.ToString();
}
else if (con_type  ==  AttributeName[intIndex])
{
mstrtype = value.ToString();
}
else if (con_tabindex  ==  AttributeName[intIndex])
{
mstrtabindex = value.ToString();
}
else if (con_role  ==  AttributeName[intIndex])
{
mstrrole = value.ToString();
}
else if (con_aria_labelledby  ==  AttributeName[intIndex])
{
mstraria_labelledby = value.ToString();
}
else if (con_aria_hidden  ==  AttributeName[intIndex])
{
mstraria_hidden = value.ToString();
}
else if (con_data_dismiss  ==  AttributeName[intIndex])
{
mstrdata_dismiss = value.ToString();
}
else if (con_aria_label  ==  AttributeName[intIndex])
{
mstraria_label = value.ToString();
}
else if (con_GroupName  ==  AttributeName[intIndex])
{
mstrGroupName = value.ToString();
}
else if (con_OnClick  ==  AttributeName[intIndex])
{
mstrOnClick = value.ToString();
}
else if (con_CommandName  ==  AttributeName[intIndex])
{
mstrCommandName = value.ToString();
}
else if (con_Comment  ==  AttributeName[intIndex])
{
mstrComment = value.ToString();
}
else if (con_Cols  ==  AttributeName[intIndex])
{
mintCols = clsEntityBase2.TransNullToInt_S(value.ToString());
}
else if (con_Rows  ==  AttributeName[intIndex])
{
mintRows = clsEntityBase2.TransNullToInt_S(value.ToString());
}
}
}

/// <summary>
/// Asp控件Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspControlId
{
get
{
return mstrAspControlId;
}
set
{
if (value  ==  "")
{
 mstrAspControlId = value;
}
else
{
 mstrAspControlId = value;
}
}
}
/// <summary>
/// Asp控件名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspControlName
{
get
{
return mstrAspControlName;
}
set
{
if (value  ==  "")
{
 mstrAspControlName = value;
}
else
{
 mstrAspControlName = value;
}
}
}
/// <summary>
/// 控件Id(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string CtrlId
{
get
{
return mstrCtrlId;
}
set
{
if (value  ==  "")
{
 mstrCtrlId = value;
}
else
{
 mstrCtrlId = value;
}
}
}



        [DataMember]//非常重要
        public string Ref
        {
            get
            {
                return mstrRef;
            }
            set
            {
                if (value == "")
                {
                    mstrRef = value;
                }
                else
                {
                    mstrRef = value;
                }
            }
        }
        /// <summary>
        /// 控件Name(说明:;字段类型:varchar;字段长度:50;是否可空:False)
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
        /// </summary>
        [DataMember]//非常重要
 public string CtrlName
{
get
{
return mstrCtrlName;
}
set
{
if (value  ==  "")
{
 mstrCtrlName = value;
}
else
{
 mstrCtrlName = value;
}
}
}
/// <summary>
/// 控件类型号(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string CtlTypeId
{
get
{
return mstrCtlTypeId;
}
set
{
if (value  ==  "")
{
 mstrCtlTypeId = value;
}
else
{
 mstrCtlTypeId = value;
}
}
}
/// <summary>
/// 类型(说明:;字段类型:varchar;字段长度:800;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
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
/// 高度(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
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
/// <summary>
/// 宽(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
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
/// 运行在(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string Runat
{
get
{
return mstrRunat;
}
set
{
if (value  ==  "")
{
 mstrRunat = value;
}
else
{
 mstrRunat = value;
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
/// 样式表类(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string Class
{
get
{
return mstrClass;
}
set
{
if (value  ==  "")
{
 mstrClass = value;
}
else
{
 mstrClass = value;
}
}
}
/// <summary>
/// 是否有子控件(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public bool IsHaveChildCtl
{
get
{
return mbolIsHaveChildCtl;
}
set
{
 mbolIsHaveChildCtl = value;
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public int OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
}
}
/// <summary>
/// 关键字(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string mKey
{
get
{
return mstrmKey;
}
set
{
if (value  ==  "")
{
 mstrmKey = value;
}
else
{
 mstrmKey = value;
}
}
}
/// <summary>
/// tools(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
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
/// <summary>
/// app(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
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
/// android(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
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
/// 布局(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string layout
{
get
{
return mstrlayout;
}
set
{
if (value  ==  "")
{
 mstrlayout = value;
}
else
{
 mstrlayout = value;
}
}
}
/// <summary>
/// 输入类型(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string inputType
{
get
{
return mstrinputType;
}
set
{
if (value  ==  "")
{
 mstrinputType = value;
}
else
{
 mstrinputType = value;
}
}
}
/// <summary>
/// 字符宽度(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public int ems
{
get
{
return mintems;
}
set
{
 mintems = value;
}
}
/// <summary>
/// 弹出主题(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
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
/// <summary>
/// 背景(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
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
/// layout_gravity(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
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
/// <summary>
/// srcCompat(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
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
/// <summary>
/// 显示在(说明:;字段类型:varchar;字段长度:300;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
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
/// 布局行为(说明:;字段类型:varchar;字段长度:300;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
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
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
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
/// 页边距(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string layout_margin
{
get
{
return mstrlayout_margin;
}
set
{
if (value  ==  "")
{
 mstrlayout_margin = value;
}
else
{
 mstrlayout_margin = value;
}
}
}
/// <summary>
/// 顶空(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public int layout_marginTop
{
get
{
return mintlayout_marginTop;
}
set
{
 mintlayout_marginTop = value;
}
}
/// <summary>
/// Tag(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string Tag
{
get
{
return mstrTag;
}
set
{
if (value  ==  "")
{
 mstrTag = value;
}
else
{
 mstrTag = value;
}
}
}
/// <summary>
/// 约束顶相对于顶(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string layout_constraintTop_toTopOf
{
get
{
return mstrlayout_constraintTop_toTopOf;
}
set
{
if (value  ==  "")
{
 mstrlayout_constraintTop_toTopOf = value;
}
else
{
 mstrlayout_constraintTop_toTopOf = value;
}
}
}
/// <summary>
/// 约束顶相对于底(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string layout_constraintTop_toBottomOf
{
get
{
return mstrlayout_constraintTop_toBottomOf;
}
set
{
if (value  ==  "")
{
 mstrlayout_constraintTop_toBottomOf = value;
}
else
{
 mstrlayout_constraintTop_toBottomOf = value;
}
}
}
/// <summary>
/// 约束开始相对于开始(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string layout_constraintStart_toStartOf
{
get
{
return mstrlayout_constraintStart_toStartOf;
}
set
{
if (value  ==  "")
{
 mstrlayout_constraintStart_toStartOf = value;
}
else
{
 mstrlayout_constraintStart_toStartOf = value;
}
}
}
/// <summary>
/// 约束左相对于左(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string layout_constraintLeft_toLeftOf
{
get
{
return mstrlayout_constraintLeft_toLeftOf;
}
set
{
if (value  ==  "")
{
 mstrlayout_constraintLeft_toLeftOf = value;
}
else
{
 mstrlayout_constraintLeft_toLeftOf = value;
}
}
}
/// <summary>
/// 约束左相对于右(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string layout_constraintLeft_toRightOf
{
get
{
return mstrlayout_constraintLeft_toRightOf;
}
set
{
if (value  ==  "")
{
 mstrlayout_constraintLeft_toRightOf = value;
}
else
{
 mstrlayout_constraintLeft_toRightOf = value;
}
}
}
/// <summary>
/// 缩放Y(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string scaleY
{
get
{
return mstrscaleY;
}
set
{
if (value  ==  "")
{
 mstrscaleY = value;
}
else
{
 mstrscaleY = value;
}
}
}
/// <summary>
/// 缩放X(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string scaleX
{
get
{
return mstrscaleX;
}
set
{
if (value  ==  "")
{
 mstrscaleX = value;
}
else
{
 mstrscaleX = value;
}
}
}
/// <summary>
/// 左边空(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public int layout_marginLeft
{
get
{
return mintlayout_marginLeft;
}
set
{
 mintlayout_marginLeft = value;
}
}
/// <summary>
/// 文本尺寸(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string mTextSize
{
get
{
return mstrmTextSize;
}
set
{
if (value  ==  "")
{
 mstrmTextSize = value;
}
else
{
 mstrmTextSize = value;
}
}
}
/// <summary>
/// 最小高度(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string minHeight
{
get
{
return mstrminHeight;
}
set
{
if (value  ==  "")
{
 mstrminHeight = value;
}
else
{
 mstrminHeight = value;
}
}
}
/// <summary>
/// 方向(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
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
/// <summary>
/// 滚动条(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string scrollbars
{
get
{
return mstrscrollbars;
}
set
{
if (value  ==  "")
{
 mstrscrollbars = value;
}
else
{
 mstrscrollbars = value;
}
}
}
/// <summary>
/// 值(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string Value
{
get
{
return mstrValue;
}
set
{
if (value  ==  "")
{
 mstrValue = value;
}
else
{
 mstrValue = value;
}
}
}
/// <summary>
/// 类型(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string type
{
get
{
return mstrtype;
}
set
{
if (value  ==  "")
{
 mstrtype = value;
}
else
{
 mstrtype = value;
}
}
}
/// <summary>
/// tabindex(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string tabindex
{
get
{
return mstrtabindex;
}
set
{
if (value  ==  "")
{
 mstrtabindex = value;
}
else
{
 mstrtabindex = value;
}
}
}
/// <summary>
/// role(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string role
{
get
{
return mstrrole;
}
set
{
if (value  ==  "")
{
 mstrrole = value;
}
else
{
 mstrrole = value;
}
}
}
/// <summary>
/// aria-labelledby(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string aria_labelledby
{
get
{
return mstraria_labelledby;
}
set
{
if (value  ==  "")
{
 mstraria_labelledby = value;
}
else
{
 mstraria_labelledby = value;
}
}
}
/// <summary>
/// aria-hidden(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string aria_hidden
{
get
{
return mstraria_hidden;
}
set
{
if (value  ==  "")
{
 mstraria_hidden = value;
}
else
{
 mstraria_hidden = value;
}
}
}
/// <summary>
/// data-dismiss(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string data_dismiss
{
get
{
return mstrdata_dismiss;
}
set
{
if (value  ==  "")
{
 mstrdata_dismiss = value;
}
else
{
 mstrdata_dismiss = value;
}
}
}
/// <summary>
/// aria-label(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string aria_label
{
get
{
return mstraria_label;
}
set
{
if (value  ==  "")
{
 mstraria_label = value;
}
else
{
 mstraria_label = value;
}
}
}
/// <summary>
/// 组名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string GroupName
{
get
{
return mstrGroupName;
}
set
{
if (value  ==  "")
{
 mstrGroupName = value;
}
else
{
 mstrGroupName = value;
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
/// 命令名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string CommandName
{
get
{
return mstrCommandName;
}
set
{
if (value  ==  "")
{
 mstrCommandName = value;
}
else
{
 mstrCommandName = value;
}
}
}
/// <summary>
/// 注释(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string Comment
{
get
{
return mstrComment;
}
set
{
if (value  ==  "")
{
 mstrComment = value;
}
else
{
 mstrComment = value;
}
}
}
/// <summary>
/// 列数(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public int Cols
{
get
{
return mintCols;
}
set
{
 mintCols = value;
}
}
/// <summary>
/// 行数(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public int Rows
{
get
{
return mintRows;
}
set
{
 mintRows = value;
}
}
}
}