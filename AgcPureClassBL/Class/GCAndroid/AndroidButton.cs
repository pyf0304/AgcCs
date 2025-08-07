
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:AndroidButton
 表名:AndroidButton(00050373)
 生成代码版本:2019.10.18.1
 生成日期:2019/10/18 10:34:36
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
 /// Android按钮(AndroidButton)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class AndroidButton : AndroidControlEx
{
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"AndroidButtonId", "AndroidButtonName", "Text", "CssClass", "OnClick"};
//以下是属性变量

/// <summary>
/// AndroidButtonId(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AndroidButtonId
{
get
{
return mstrAndroidButtonId;
}
set
{
if (value  ==  "")
{
 mstrAndroidButtonId = value;
}
else
{
 mstrAndroidButtonId = value;
}
}
}
/// <summary>
/// AndroidButtonName(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AndroidButtonName
{
get
{
return mstrAndroidButtonName;
}
set
{
if (value  ==  "")
{
 mstrAndroidButtonName = value;
}
else
{
 mstrAndroidButtonName = value;
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
if (strAttributeName  ==  con_AndroidButtonId)
{
return mstrAndroidButtonId;
}
else if (strAttributeName  ==  con_AndroidButtonName)
{
return mstrAndroidButtonName;
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
return null;
}
set
{
if (strAttributeName  ==  con_AndroidButtonId)
{
mstrAndroidButtonId = value.ToString();
}
else if (strAttributeName  ==  con_AndroidButtonName)
{
mstrAndroidButtonName = value.ToString();
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
if (con_AndroidButtonId  ==  AttributeName[intIndex])
{
return mstrAndroidButtonId;
}
else if (con_AndroidButtonName  ==  AttributeName[intIndex])
{
return mstrAndroidButtonName;
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
return null;
}
set
{
if (con_AndroidButtonId  ==  AttributeName[intIndex])
{
mstrAndroidButtonId = value.ToString();
}
else if (con_AndroidButtonName  ==  AttributeName[intIndex])
{
mstrAndroidButtonName = value.ToString();
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
}
}

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public AndroidButton()
 {
 }


 /// <summary>
 /// 常量:"AndroidButtonId"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AndroidButtonId = "AndroidButtonId";    //AndroidButtonId

 /// <summary>
 /// 常量:"AndroidButtonName"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AndroidButtonName = "AndroidButtonName";    //AndroidButtonName

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

protected string mstrAndroidButtonId;    //AndroidButtonId
protected string mstrAndroidButtonName;    //AndroidButtonName
protected string mstrText;    //文本
protected string mstrCssClass;    //样式表
protected string mstrOnClick;    //单击事件
}
}