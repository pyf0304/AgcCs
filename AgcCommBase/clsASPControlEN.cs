
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsASPControlEN
 表名:ASPControl(00050217)
 生成代码版本:2019.10.08.1
 生成日期:2019/10/15 11:02:02
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:AGC
 工程ID:0005
 相关数据库:101.251.68.133,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成C#代码
 模块英文名:GeneCSharp
 框架-层名:实体层(EntityLayer)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
using System;
using System.Text; 
using System.Collections; 
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System.Runtime.Serialization;

namespace AGC.Entity
{
 /// <summary>
 /// 表ASPControl的关键字(AspControlId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_AspControlId_ASPControl
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strAspControlId">表关键字</param>
public K_AspControlId_ASPControl(string strAspControlId)
{
if (IsValid(strAspControlId)) Value = strAspControlId;
else
{
Value = null;
}
}
private static bool IsValid(string strAspControlId)
{
if (string.IsNullOrEmpty(strAspControlId) == true) return false;
if (strAspControlId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_AspControlId_ASPControl]类型的对象</returns>
public static implicit operator K_AspControlId_ASPControl(string value)
{
return new K_AspControlId_ASPControl(value);
}
}
 /// <summary>
 /// ASP控件(ASPControl)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsASPControlEN : clsEntityBase2
{
public const string _CurrTabName_S = "ASPControl"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "AspControlId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 53;
public static string[] AttributeName = new string[] {"AspControlId", "AspControlName", "CtrlId", "CtrlName", "CtlTypeId", "Style", "Height", "Width", "Text", "Runat", "CssClass", "Class", "IsHaveChildCtl", "OrderNum", "mKey", "tools", "app", "android", "layout", "inputType", "ems", "popupTheme", "background", "layout_gravity", "srcCompat", "theme", "showIn", "layout_behavior", "context", "layout_margin", "layout_marginTop", "Tag", "layout_constraintTop_toTopOf", "layout_constraintTop_toBottomOf", "layout_constraintStart_toStartOf", "layout_constraintLeft_toLeftOf", "layout_constraintLeft_toRightOf", "scaleY", "scaleX", "layout_marginLeft", "mTextSize", "minHeight", "orientation", "scrollbars", "Value", "type", "tabindex", "role", "aria_labelledby", "aria_hidden", "data_dismiss", "aria_label", "GroupName"};
//以下是属性变量

protected string mstrAspControlId;    //Asp控件Id
protected string mstrAspControlName;    //Asp控件名
protected string mstrCtrlId;    //控件Id
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
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsASPControlEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "ASPControl";
 lstKeyFldNames.Add("AspControlId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strAspControlId">关键字:Asp控件Id</param>
public clsASPControlEN(string strAspControlId)
 {
strAspControlId = strAspControlId.Replace("'", "''");
if (strAspControlId.Length > 8)
{
throw new Exception("在表:ASPControl中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strAspControlId)  ==  true)
{
throw new Exception("在表:ASPControl中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strAspControlId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrAspControlId = strAspControlId;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "ASPControl";
 lstKeyFldNames.Add("AspControlId");
 }

public static int AttributeCount
{
get
{
return mintAttributeCount;
}
}
public override object this[string strAttributeName]
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
return null;
}
set
{
if (strAttributeName  ==  con_AspControlId)
{
mstrAspControlId = value.ToString();
 AddUpdatedFld(con_AspControlId);
}
else if (strAttributeName  ==  con_AspControlName)
{
mstrAspControlName = value.ToString();
 AddUpdatedFld(con_AspControlName);
}
else if (strAttributeName  ==  con_CtrlId)
{
mstrCtrlId = value.ToString();
 AddUpdatedFld(con_CtrlId);
}
else if (strAttributeName  ==  con_CtrlName)
{
mstrCtrlName = value.ToString();
 AddUpdatedFld(con_CtrlName);
}
else if (strAttributeName  ==  con_CtlTypeId)
{
mstrCtlTypeId = value.ToString();
 AddUpdatedFld(con_CtlTypeId);
}
else if (strAttributeName  ==  con_Style)
{
mstrStyle = value.ToString();
 AddUpdatedFld(con_Style);
}
else if (strAttributeName  ==  con_Height)
{
mintHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(con_Height);
}
else if (strAttributeName  ==  con_Width)
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(con_Width);
}
else if (strAttributeName  ==  con_Text)
{
mstrText = value.ToString();
 AddUpdatedFld(con_Text);
}
else if (strAttributeName  ==  con_Runat)
{
mstrRunat = value.ToString();
 AddUpdatedFld(con_Runat);
}
else if (strAttributeName  ==  con_CssClass)
{
mstrCssClass = value.ToString();
 AddUpdatedFld(con_CssClass);
}
else if (strAttributeName  ==  con_Class)
{
mstrClass = value.ToString();
 AddUpdatedFld(con_Class);
}
else if (strAttributeName  ==  con_IsHaveChildCtl)
{
mbolIsHaveChildCtl = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsHaveChildCtl);
}
else if (strAttributeName  ==  con_OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(con_OrderNum);
}
else if (strAttributeName  ==  con_mKey)
{
mstrmKey = value.ToString();
 AddUpdatedFld(con_mKey);
}
else if (strAttributeName  ==  con_tools)
{
mstrtools = value.ToString();
 AddUpdatedFld(con_tools);
}
else if (strAttributeName  ==  con_app)
{
mstrapp = value.ToString();
 AddUpdatedFld(con_app);
}
else if (strAttributeName  ==  con_android)
{
mstrandroid = value.ToString();
 AddUpdatedFld(con_android);
}
else if (strAttributeName  ==  con_layout)
{
mstrlayout = value.ToString();
 AddUpdatedFld(con_layout);
}
else if (strAttributeName  ==  con_inputType)
{
mstrinputType = value.ToString();
 AddUpdatedFld(con_inputType);
}
else if (strAttributeName  ==  con_ems)
{
mintems = TransNullToInt(value.ToString());
 AddUpdatedFld(con_ems);
}
else if (strAttributeName  ==  con_popupTheme)
{
mstrpopupTheme = value.ToString();
 AddUpdatedFld(con_popupTheme);
}
else if (strAttributeName  ==  con_background)
{
mstrbackground = value.ToString();
 AddUpdatedFld(con_background);
}
else if (strAttributeName  ==  con_layout_gravity)
{
mstrlayout_gravity = value.ToString();
 AddUpdatedFld(con_layout_gravity);
}
else if (strAttributeName  ==  con_srcCompat)
{
mstrsrcCompat = value.ToString();
 AddUpdatedFld(con_srcCompat);
}
else if (strAttributeName  ==  con_theme)
{
mstrtheme = value.ToString();
 AddUpdatedFld(con_theme);
}
else if (strAttributeName  ==  con_showIn)
{
mstrshowIn = value.ToString();
 AddUpdatedFld(con_showIn);
}
else if (strAttributeName  ==  con_layout_behavior)
{
mstrlayout_behavior = value.ToString();
 AddUpdatedFld(con_layout_behavior);
}
else if (strAttributeName  ==  con_context)
{
mstrcontext = value.ToString();
 AddUpdatedFld(con_context);
}
else if (strAttributeName  ==  con_layout_margin)
{
mstrlayout_margin = value.ToString();
 AddUpdatedFld(con_layout_margin);
}
else if (strAttributeName  ==  con_layout_marginTop)
{
mintlayout_marginTop = TransNullToInt(value.ToString());
 AddUpdatedFld(con_layout_marginTop);
}
else if (strAttributeName  ==  con_Tag)
{
mstrTag = value.ToString();
 AddUpdatedFld(con_Tag);
}
else if (strAttributeName  ==  con_layout_constraintTop_toTopOf)
{
mstrlayout_constraintTop_toTopOf = value.ToString();
 AddUpdatedFld(con_layout_constraintTop_toTopOf);
}
else if (strAttributeName  ==  con_layout_constraintTop_toBottomOf)
{
mstrlayout_constraintTop_toBottomOf = value.ToString();
 AddUpdatedFld(con_layout_constraintTop_toBottomOf);
}
else if (strAttributeName  ==  con_layout_constraintStart_toStartOf)
{
mstrlayout_constraintStart_toStartOf = value.ToString();
 AddUpdatedFld(con_layout_constraintStart_toStartOf);
}
else if (strAttributeName  ==  con_layout_constraintLeft_toLeftOf)
{
mstrlayout_constraintLeft_toLeftOf = value.ToString();
 AddUpdatedFld(con_layout_constraintLeft_toLeftOf);
}
else if (strAttributeName  ==  con_layout_constraintLeft_toRightOf)
{
mstrlayout_constraintLeft_toRightOf = value.ToString();
 AddUpdatedFld(con_layout_constraintLeft_toRightOf);
}
else if (strAttributeName  ==  con_scaleY)
{
mstrscaleY = value.ToString();
 AddUpdatedFld(con_scaleY);
}
else if (strAttributeName  ==  con_scaleX)
{
mstrscaleX = value.ToString();
 AddUpdatedFld(con_scaleX);
}
else if (strAttributeName  ==  con_layout_marginLeft)
{
mintlayout_marginLeft = TransNullToInt(value.ToString());
 AddUpdatedFld(con_layout_marginLeft);
}
else if (strAttributeName  ==  con_mTextSize)
{
mstrmTextSize = value.ToString();
 AddUpdatedFld(con_mTextSize);
}
else if (strAttributeName  ==  con_minHeight)
{
mstrminHeight = value.ToString();
 AddUpdatedFld(con_minHeight);
}
else if (strAttributeName  ==  con_orientation)
{
mstrorientation = value.ToString();
 AddUpdatedFld(con_orientation);
}
else if (strAttributeName  ==  con_scrollbars)
{
mstrscrollbars = value.ToString();
 AddUpdatedFld(con_scrollbars);
}
else if (strAttributeName  ==  con_Value)
{
mstrValue = value.ToString();
 AddUpdatedFld(con_Value);
}
else if (strAttributeName  ==  con_type)
{
mstrtype = value.ToString();
 AddUpdatedFld(con_type);
}
else if (strAttributeName  ==  con_tabindex)
{
mstrtabindex = value.ToString();
 AddUpdatedFld(con_tabindex);
}
else if (strAttributeName  ==  con_role)
{
mstrrole = value.ToString();
 AddUpdatedFld(con_role);
}
else if (strAttributeName  ==  con_aria_labelledby)
{
mstraria_labelledby = value.ToString();
 AddUpdatedFld(con_aria_labelledby);
}
else if (strAttributeName  ==  con_aria_hidden)
{
mstraria_hidden = value.ToString();
 AddUpdatedFld(con_aria_hidden);
}
else if (strAttributeName  ==  con_data_dismiss)
{
mstrdata_dismiss = value.ToString();
 AddUpdatedFld(con_data_dismiss);
}
else if (strAttributeName  ==  con_aria_label)
{
mstraria_label = value.ToString();
 AddUpdatedFld(con_aria_label);
}
else if (strAttributeName  ==  con_GroupName)
{
mstrGroupName = value.ToString();
 AddUpdatedFld(con_GroupName);
}
}
}
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
return null;
}
set
{
if (con_AspControlId  ==  AttributeName[intIndex])
{
mstrAspControlId = value.ToString();
 AddUpdatedFld(con_AspControlId);
}
else if (con_AspControlName  ==  AttributeName[intIndex])
{
mstrAspControlName = value.ToString();
 AddUpdatedFld(con_AspControlName);
}
else if (con_CtrlId  ==  AttributeName[intIndex])
{
mstrCtrlId = value.ToString();
 AddUpdatedFld(con_CtrlId);
}
else if (con_CtrlName  ==  AttributeName[intIndex])
{
mstrCtrlName = value.ToString();
 AddUpdatedFld(con_CtrlName);
}
else if (con_CtlTypeId  ==  AttributeName[intIndex])
{
mstrCtlTypeId = value.ToString();
 AddUpdatedFld(con_CtlTypeId);
}
else if (con_Style  ==  AttributeName[intIndex])
{
mstrStyle = value.ToString();
 AddUpdatedFld(con_Style);
}
else if (con_Height  ==  AttributeName[intIndex])
{
mintHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(con_Height);
}
else if (con_Width  ==  AttributeName[intIndex])
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(con_Width);
}
else if (con_Text  ==  AttributeName[intIndex])
{
mstrText = value.ToString();
 AddUpdatedFld(con_Text);
}
else if (con_Runat  ==  AttributeName[intIndex])
{
mstrRunat = value.ToString();
 AddUpdatedFld(con_Runat);
}
else if (con_CssClass  ==  AttributeName[intIndex])
{
mstrCssClass = value.ToString();
 AddUpdatedFld(con_CssClass);
}
else if (con_Class  ==  AttributeName[intIndex])
{
mstrClass = value.ToString();
 AddUpdatedFld(con_Class);
}
else if (con_IsHaveChildCtl  ==  AttributeName[intIndex])
{
mbolIsHaveChildCtl = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsHaveChildCtl);
}
else if (con_OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(con_OrderNum);
}
else if (con_mKey  ==  AttributeName[intIndex])
{
mstrmKey = value.ToString();
 AddUpdatedFld(con_mKey);
}
else if (con_tools  ==  AttributeName[intIndex])
{
mstrtools = value.ToString();
 AddUpdatedFld(con_tools);
}
else if (con_app  ==  AttributeName[intIndex])
{
mstrapp = value.ToString();
 AddUpdatedFld(con_app);
}
else if (con_android  ==  AttributeName[intIndex])
{
mstrandroid = value.ToString();
 AddUpdatedFld(con_android);
}
else if (con_layout  ==  AttributeName[intIndex])
{
mstrlayout = value.ToString();
 AddUpdatedFld(con_layout);
}
else if (con_inputType  ==  AttributeName[intIndex])
{
mstrinputType = value.ToString();
 AddUpdatedFld(con_inputType);
}
else if (con_ems  ==  AttributeName[intIndex])
{
mintems = TransNullToInt(value.ToString());
 AddUpdatedFld(con_ems);
}
else if (con_popupTheme  ==  AttributeName[intIndex])
{
mstrpopupTheme = value.ToString();
 AddUpdatedFld(con_popupTheme);
}
else if (con_background  ==  AttributeName[intIndex])
{
mstrbackground = value.ToString();
 AddUpdatedFld(con_background);
}
else if (con_layout_gravity  ==  AttributeName[intIndex])
{
mstrlayout_gravity = value.ToString();
 AddUpdatedFld(con_layout_gravity);
}
else if (con_srcCompat  ==  AttributeName[intIndex])
{
mstrsrcCompat = value.ToString();
 AddUpdatedFld(con_srcCompat);
}
else if (con_theme  ==  AttributeName[intIndex])
{
mstrtheme = value.ToString();
 AddUpdatedFld(con_theme);
}
else if (con_showIn  ==  AttributeName[intIndex])
{
mstrshowIn = value.ToString();
 AddUpdatedFld(con_showIn);
}
else if (con_layout_behavior  ==  AttributeName[intIndex])
{
mstrlayout_behavior = value.ToString();
 AddUpdatedFld(con_layout_behavior);
}
else if (con_context  ==  AttributeName[intIndex])
{
mstrcontext = value.ToString();
 AddUpdatedFld(con_context);
}
else if (con_layout_margin  ==  AttributeName[intIndex])
{
mstrlayout_margin = value.ToString();
 AddUpdatedFld(con_layout_margin);
}
else if (con_layout_marginTop  ==  AttributeName[intIndex])
{
mintlayout_marginTop = TransNullToInt(value.ToString());
 AddUpdatedFld(con_layout_marginTop);
}
else if (con_Tag  ==  AttributeName[intIndex])
{
mstrTag = value.ToString();
 AddUpdatedFld(con_Tag);
}
else if (con_layout_constraintTop_toTopOf  ==  AttributeName[intIndex])
{
mstrlayout_constraintTop_toTopOf = value.ToString();
 AddUpdatedFld(con_layout_constraintTop_toTopOf);
}
else if (con_layout_constraintTop_toBottomOf  ==  AttributeName[intIndex])
{
mstrlayout_constraintTop_toBottomOf = value.ToString();
 AddUpdatedFld(con_layout_constraintTop_toBottomOf);
}
else if (con_layout_constraintStart_toStartOf  ==  AttributeName[intIndex])
{
mstrlayout_constraintStart_toStartOf = value.ToString();
 AddUpdatedFld(con_layout_constraintStart_toStartOf);
}
else if (con_layout_constraintLeft_toLeftOf  ==  AttributeName[intIndex])
{
mstrlayout_constraintLeft_toLeftOf = value.ToString();
 AddUpdatedFld(con_layout_constraintLeft_toLeftOf);
}
else if (con_layout_constraintLeft_toRightOf  ==  AttributeName[intIndex])
{
mstrlayout_constraintLeft_toRightOf = value.ToString();
 AddUpdatedFld(con_layout_constraintLeft_toRightOf);
}
else if (con_scaleY  ==  AttributeName[intIndex])
{
mstrscaleY = value.ToString();
 AddUpdatedFld(con_scaleY);
}
else if (con_scaleX  ==  AttributeName[intIndex])
{
mstrscaleX = value.ToString();
 AddUpdatedFld(con_scaleX);
}
else if (con_layout_marginLeft  ==  AttributeName[intIndex])
{
mintlayout_marginLeft = TransNullToInt(value.ToString());
 AddUpdatedFld(con_layout_marginLeft);
}
else if (con_mTextSize  ==  AttributeName[intIndex])
{
mstrmTextSize = value.ToString();
 AddUpdatedFld(con_mTextSize);
}
else if (con_minHeight  ==  AttributeName[intIndex])
{
mstrminHeight = value.ToString();
 AddUpdatedFld(con_minHeight);
}
else if (con_orientation  ==  AttributeName[intIndex])
{
mstrorientation = value.ToString();
 AddUpdatedFld(con_orientation);
}
else if (con_scrollbars  ==  AttributeName[intIndex])
{
mstrscrollbars = value.ToString();
 AddUpdatedFld(con_scrollbars);
}
else if (con_Value  ==  AttributeName[intIndex])
{
mstrValue = value.ToString();
 AddUpdatedFld(con_Value);
}
else if (con_type  ==  AttributeName[intIndex])
{
mstrtype = value.ToString();
 AddUpdatedFld(con_type);
}
else if (con_tabindex  ==  AttributeName[intIndex])
{
mstrtabindex = value.ToString();
 AddUpdatedFld(con_tabindex);
}
else if (con_role  ==  AttributeName[intIndex])
{
mstrrole = value.ToString();
 AddUpdatedFld(con_role);
}
else if (con_aria_labelledby  ==  AttributeName[intIndex])
{
mstraria_labelledby = value.ToString();
 AddUpdatedFld(con_aria_labelledby);
}
else if (con_aria_hidden  ==  AttributeName[intIndex])
{
mstraria_hidden = value.ToString();
 AddUpdatedFld(con_aria_hidden);
}
else if (con_data_dismiss  ==  AttributeName[intIndex])
{
mstrdata_dismiss = value.ToString();
 AddUpdatedFld(con_data_dismiss);
}
else if (con_aria_label  ==  AttributeName[intIndex])
{
mstraria_label = value.ToString();
 AddUpdatedFld(con_aria_label);
}
else if (con_GroupName  ==  AttributeName[intIndex])
{
mstrGroupName = value.ToString();
 AddUpdatedFld(con_GroupName);
}
}
}

/// <summary>
/// Asp控件Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrAspControlId = value;
}
else
{
 mstrAspControlId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_AspControlId);
}
}
/// <summary>
/// Asp控件名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrAspControlName = value;
}
else
{
 mstrAspControlName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_AspControlName);
}
}
/// <summary>
/// 控件Id(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrCtrlId = value;
}
else
{
 mstrCtrlId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_CtrlId);
}
}
/// <summary>
/// 控件Name(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrCtrlName = value;
}
else
{
 mstrCtrlName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_CtrlName);
}
}
/// <summary>
/// 控件类型号(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrCtlTypeId = value;
}
else
{
 mstrCtlTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_CtlTypeId);
}
}
/// <summary>
/// 类型(说明:;字段类型:varchar;字段长度:800;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrStyle = value;
}
else
{
 mstrStyle = value;
}
//记录修改过的字段
 AddUpdatedFld(con_Style);
}
}
/// <summary>
/// 高度(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
//记录修改过的字段
 AddUpdatedFld(con_Height);
}
}
/// <summary>
/// 宽(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
//记录修改过的字段
 AddUpdatedFld(con_Width);
}
}
/// <summary>
/// 文本(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrText = value;
}
else
{
 mstrText = value;
}
//记录修改过的字段
 AddUpdatedFld(con_Text);
}
}
/// <summary>
/// 运行在(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrRunat = value;
}
else
{
 mstrRunat = value;
}
//记录修改过的字段
 AddUpdatedFld(con_Runat);
}
}
/// <summary>
/// 样式表(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrCssClass = value;
}
else
{
 mstrCssClass = value;
}
//记录修改过的字段
 AddUpdatedFld(con_CssClass);
}
}
/// <summary>
/// 样式表类(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrClass = value;
}
else
{
 mstrClass = value;
}
//记录修改过的字段
 AddUpdatedFld(con_Class);
}
}
/// <summary>
/// 是否有子控件(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
//记录修改过的字段
 AddUpdatedFld(con_IsHaveChildCtl);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
//记录修改过的字段
 AddUpdatedFld(con_OrderNum);
}
}
/// <summary>
/// 关键字(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrmKey = value;
}
else
{
 mstrmKey = value;
}
//记录修改过的字段
 AddUpdatedFld(con_mKey);
}
}
/// <summary>
/// tools(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrtools = value;
}
else
{
 mstrtools = value;
}
//记录修改过的字段
 AddUpdatedFld(con_tools);
}
}
/// <summary>
/// app(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrapp = value;
}
else
{
 mstrapp = value;
}
//记录修改过的字段
 AddUpdatedFld(con_app);
}
}
/// <summary>
/// android(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrandroid = value;
}
else
{
 mstrandroid = value;
}
//记录修改过的字段
 AddUpdatedFld(con_android);
}
}
/// <summary>
/// 布局(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrlayout = value;
}
else
{
 mstrlayout = value;
}
//记录修改过的字段
 AddUpdatedFld(con_layout);
}
}
/// <summary>
/// 输入类型(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrinputType = value;
}
else
{
 mstrinputType = value;
}
//记录修改过的字段
 AddUpdatedFld(con_inputType);
}
}
/// <summary>
/// 字符宽度(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
//记录修改过的字段
 AddUpdatedFld(con_ems);
}
}
/// <summary>
/// 弹出主题(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrpopupTheme = value;
}
else
{
 mstrpopupTheme = value;
}
//记录修改过的字段
 AddUpdatedFld(con_popupTheme);
}
}
/// <summary>
/// 背景(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrbackground = value;
}
else
{
 mstrbackground = value;
}
//记录修改过的字段
 AddUpdatedFld(con_background);
}
}
/// <summary>
/// layout_gravity(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrlayout_gravity = value;
}
else
{
 mstrlayout_gravity = value;
}
//记录修改过的字段
 AddUpdatedFld(con_layout_gravity);
}
}
/// <summary>
/// srcCompat(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrsrcCompat = value;
}
else
{
 mstrsrcCompat = value;
}
//记录修改过的字段
 AddUpdatedFld(con_srcCompat);
}
}
/// <summary>
/// 主题(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrtheme = value;
}
else
{
 mstrtheme = value;
}
//记录修改过的字段
 AddUpdatedFld(con_theme);
}
}
/// <summary>
/// 显示在(说明:;字段类型:varchar;字段长度:300;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrshowIn = value;
}
else
{
 mstrshowIn = value;
}
//记录修改过的字段
 AddUpdatedFld(con_showIn);
}
}
/// <summary>
/// 布局行为(说明:;字段类型:varchar;字段长度:300;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrlayout_behavior = value;
}
else
{
 mstrlayout_behavior = value;
}
//记录修改过的字段
 AddUpdatedFld(con_layout_behavior);
}
}
/// <summary>
/// 上下文(说明:;字段类型:varchar;字段长度:300;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrcontext = value;
}
else
{
 mstrcontext = value;
}
//记录修改过的字段
 AddUpdatedFld(con_context);
}
}
/// <summary>
/// 页边距(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrlayout_margin = value;
}
else
{
 mstrlayout_margin = value;
}
//记录修改过的字段
 AddUpdatedFld(con_layout_margin);
}
}
/// <summary>
/// 顶空(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
//记录修改过的字段
 AddUpdatedFld(con_layout_marginTop);
}
}
/// <summary>
/// Tag(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrTag = value;
}
else
{
 mstrTag = value;
}
//记录修改过的字段
 AddUpdatedFld(con_Tag);
}
}
/// <summary>
/// 约束顶相对于顶(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrlayout_constraintTop_toTopOf = value;
}
else
{
 mstrlayout_constraintTop_toTopOf = value;
}
//记录修改过的字段
 AddUpdatedFld(con_layout_constraintTop_toTopOf);
}
}
/// <summary>
/// 约束顶相对于底(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrlayout_constraintTop_toBottomOf = value;
}
else
{
 mstrlayout_constraintTop_toBottomOf = value;
}
//记录修改过的字段
 AddUpdatedFld(con_layout_constraintTop_toBottomOf);
}
}
/// <summary>
/// 约束开始相对于开始(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrlayout_constraintStart_toStartOf = value;
}
else
{
 mstrlayout_constraintStart_toStartOf = value;
}
//记录修改过的字段
 AddUpdatedFld(con_layout_constraintStart_toStartOf);
}
}
/// <summary>
/// 约束左相对于左(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrlayout_constraintLeft_toLeftOf = value;
}
else
{
 mstrlayout_constraintLeft_toLeftOf = value;
}
//记录修改过的字段
 AddUpdatedFld(con_layout_constraintLeft_toLeftOf);
}
}
/// <summary>
/// 约束左相对于右(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrlayout_constraintLeft_toRightOf = value;
}
else
{
 mstrlayout_constraintLeft_toRightOf = value;
}
//记录修改过的字段
 AddUpdatedFld(con_layout_constraintLeft_toRightOf);
}
}
/// <summary>
/// 缩放Y(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrscaleY = value;
}
else
{
 mstrscaleY = value;
}
//记录修改过的字段
 AddUpdatedFld(con_scaleY);
}
}
/// <summary>
/// 缩放X(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrscaleX = value;
}
else
{
 mstrscaleX = value;
}
//记录修改过的字段
 AddUpdatedFld(con_scaleX);
}
}
/// <summary>
/// 左边空(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
//记录修改过的字段
 AddUpdatedFld(con_layout_marginLeft);
}
}
/// <summary>
/// 文本尺寸(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrmTextSize = value;
}
else
{
 mstrmTextSize = value;
}
//记录修改过的字段
 AddUpdatedFld(con_mTextSize);
}
}
/// <summary>
/// 最小高度(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrminHeight = value;
}
else
{
 mstrminHeight = value;
}
//记录修改过的字段
 AddUpdatedFld(con_minHeight);
}
}
/// <summary>
/// 方向(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrorientation = value;
}
else
{
 mstrorientation = value;
}
//记录修改过的字段
 AddUpdatedFld(con_orientation);
}
}
/// <summary>
/// 滚动条(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrscrollbars = value;
}
else
{
 mstrscrollbars = value;
}
//记录修改过的字段
 AddUpdatedFld(con_scrollbars);
}
}
/// <summary>
/// 值(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrValue = value;
}
else
{
 mstrValue = value;
}
//记录修改过的字段
 AddUpdatedFld(con_Value);
}
}
/// <summary>
/// 类型(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrtype = value;
}
else
{
 mstrtype = value;
}
//记录修改过的字段
 AddUpdatedFld(con_type);
}
}
/// <summary>
/// tabindex(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrtabindex = value;
}
else
{
 mstrtabindex = value;
}
//记录修改过的字段
 AddUpdatedFld(con_tabindex);
}
}
/// <summary>
/// role(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrrole = value;
}
else
{
 mstrrole = value;
}
//记录修改过的字段
 AddUpdatedFld(con_role);
}
}
/// <summary>
/// aria-labelledby(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstraria_labelledby = value;
}
else
{
 mstraria_labelledby = value;
}
//记录修改过的字段
 AddUpdatedFld(con_aria_labelledby);
}
}
/// <summary>
/// aria-hidden(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstraria_hidden = value;
}
else
{
 mstraria_hidden = value;
}
//记录修改过的字段
 AddUpdatedFld(con_aria_hidden);
}
}
/// <summary>
/// data-dismiss(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrdata_dismiss = value;
}
else
{
 mstrdata_dismiss = value;
}
//记录修改过的字段
 AddUpdatedFld(con_data_dismiss);
}
}
/// <summary>
/// aria-label(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstraria_label = value;
}
else
{
 mstraria_label = value;
}
//记录修改过的字段
 AddUpdatedFld(con_aria_label);
}
}
/// <summary>
/// 组名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrGroupName = value;
}
else
{
 mstrGroupName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_GroupName);
}
}

/// <summary>
/// 获取关键字Id(KeyId)
 /// (AutoGCLib.clsGeneCodeBase:GenGetKeyId)
/// </summary>
 public override string _KeyId
 {
 get
 {
  return mstrAspControlId;
 }
 }

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrAspControlName;
 }
 }
}
}