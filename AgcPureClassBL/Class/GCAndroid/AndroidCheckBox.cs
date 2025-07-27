
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:AndroidCheckBox
 表名:AndroidCheckBox(00050390)
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
 /// Android复选框(AndroidCheckBox)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class AndroidCheckBox : AndroidControlEx
{
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"AndroidCheckBoxId", "AndroidCheckBoxName", "Text", "CssClass", "OnClick", "scaleX", "scaleY"};
//以下是属性变量

/// <summary>
/// AndroidCheckBoxId(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AndroidCheckBoxId
{
get
{
return mstrAndroidCheckBoxId;
}
set
{
if (value  ==  "")
{
 mstrAndroidCheckBoxId = value;
}
else
{
 mstrAndroidCheckBoxId = value;
}
}
}
/// <summary>
/// AndroidCheckBoxName(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AndroidCheckBoxName
{
get
{
return mstrAndroidCheckBoxName;
}
set
{
if (value  ==  "")
{
 mstrAndroidCheckBoxName = value;
}
else
{
 mstrAndroidCheckBoxName = value;
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
/// 缩放X(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
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
/// 缩放Y(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
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
if (strAttributeName  ==  con_AndroidCheckBoxId)
{
return mstrAndroidCheckBoxId;
}
else if (strAttributeName  ==  con_AndroidCheckBoxName)
{
return mstrAndroidCheckBoxName;
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
else if (strAttributeName  ==  con_scaleX)
{
return mstrscaleX;
}
else if (strAttributeName  ==  con_scaleY)
{
return mstrscaleY;
}
return null;
}
set
{
if (strAttributeName  ==  con_AndroidCheckBoxId)
{
mstrAndroidCheckBoxId = value.ToString();
}
else if (strAttributeName  ==  con_AndroidCheckBoxName)
{
mstrAndroidCheckBoxName = value.ToString();
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
else if (strAttributeName  ==  con_scaleX)
{
mstrscaleX = value.ToString();
}
else if (strAttributeName  ==  con_scaleY)
{
mstrscaleY = value.ToString();
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
if (con_AndroidCheckBoxId  ==  AttributeName[intIndex])
{
return mstrAndroidCheckBoxId;
}
else if (con_AndroidCheckBoxName  ==  AttributeName[intIndex])
{
return mstrAndroidCheckBoxName;
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
else if (con_scaleX  ==  AttributeName[intIndex])
{
return mstrscaleX;
}
else if (con_scaleY  ==  AttributeName[intIndex])
{
return mstrscaleY;
}
return null;
}
set
{
if (con_AndroidCheckBoxId  ==  AttributeName[intIndex])
{
mstrAndroidCheckBoxId = value.ToString();
}
else if (con_AndroidCheckBoxName  ==  AttributeName[intIndex])
{
mstrAndroidCheckBoxName = value.ToString();
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
else if (con_scaleX  ==  AttributeName[intIndex])
{
mstrscaleX = value.ToString();
}
else if (con_scaleY  ==  AttributeName[intIndex])
{
mstrscaleY = value.ToString();
}
}
}

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public AndroidCheckBox()
 {
 }


 /// <summary>
 /// 常量:"AndroidCheckBoxId"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AndroidCheckBoxId = "AndroidCheckBoxId";    //AndroidCheckBoxId

 /// <summary>
 /// 常量:"AndroidCheckBoxName"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AndroidCheckBoxName = "AndroidCheckBoxName";    //AndroidCheckBoxName

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
 /// 常量:"scaleX"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_scaleX = "scaleX";    //缩放X

 /// <summary>
 /// 常量:"scaleY"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_scaleY = "scaleY";    //缩放Y

protected string mstrAndroidCheckBoxId;    //AndroidCheckBoxId
protected string mstrAndroidCheckBoxName;    //AndroidCheckBoxName
protected string mstrText;    //文本
protected string mstrCssClass;    //样式表
protected string mstrOnClick;    //单击事件
protected string mstrscaleX;    //缩放X
protected string mstrscaleY;    //缩放Y
}
}