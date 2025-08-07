
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:AndroidEditText
 表名:AndroidEditText(00050376)
 生成代码版本:2019.10.18.1
 生成日期:2019/10/18 10:34:38
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
 /// Android编辑文本框(AndroidEditText)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class AndroidEditText : AndroidControlEx
{
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"AndroidEditTextId", "AndroidEditTextName", "Text", "CssClass", "OnClick", "inputType", "ems"};
//以下是属性变量

/// <summary>
/// AndroidEditTextId(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AndroidEditTextId
{
get
{
return mstrAndroidEditTextId;
}
set
{
if (value  ==  "")
{
 mstrAndroidEditTextId = value;
}
else
{
 mstrAndroidEditTextId = value;
}
}
}
/// <summary>
/// AndroidEditTextName(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AndroidEditTextName
{
get
{
return mstrAndroidEditTextName;
}
set
{
if (value  ==  "")
{
 mstrAndroidEditTextName = value;
}
else
{
 mstrAndroidEditTextName = value;
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
/// 输入类型(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
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
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
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
if (strAttributeName  ==  con_AndroidEditTextId)
{
return mstrAndroidEditTextId;
}
else if (strAttributeName  ==  con_AndroidEditTextName)
{
return mstrAndroidEditTextName;
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
else if (strAttributeName  ==  con_inputType)
{
return mstrinputType;
}
else if (strAttributeName  ==  con_ems)
{
return mintems;
}
return null;
}
set
{
if (strAttributeName  ==  con_AndroidEditTextId)
{
mstrAndroidEditTextId = value.ToString();
}
else if (strAttributeName  ==  con_AndroidEditTextName)
{
mstrAndroidEditTextName = value.ToString();
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
else if (strAttributeName  ==  con_inputType)
{
mstrinputType = value.ToString();
}
else if (strAttributeName  ==  con_ems)
{
mintems = clsEntityBase2.TransNullToInt_S(value.ToString());
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
if (con_AndroidEditTextId  ==  AttributeName[intIndex])
{
return mstrAndroidEditTextId;
}
else if (con_AndroidEditTextName  ==  AttributeName[intIndex])
{
return mstrAndroidEditTextName;
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
else if (con_inputType  ==  AttributeName[intIndex])
{
return mstrinputType;
}
else if (con_ems  ==  AttributeName[intIndex])
{
return mintems;
}
return null;
}
set
{
if (con_AndroidEditTextId  ==  AttributeName[intIndex])
{
mstrAndroidEditTextId = value.ToString();
}
else if (con_AndroidEditTextName  ==  AttributeName[intIndex])
{
mstrAndroidEditTextName = value.ToString();
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
else if (con_inputType  ==  AttributeName[intIndex])
{
mstrinputType = value.ToString();
}
else if (con_ems  ==  AttributeName[intIndex])
{
mintems = clsEntityBase2.TransNullToInt_S(value.ToString());
}
}
}

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public AndroidEditText()
 {
 }


 /// <summary>
 /// 常量:"AndroidEditTextId"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AndroidEditTextId = "AndroidEditTextId";    //AndroidEditTextId

 /// <summary>
 /// 常量:"AndroidEditTextName"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AndroidEditTextName = "AndroidEditTextName";    //AndroidEditTextName

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
 /// 常量:"inputType"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_inputType = "inputType";    //输入类型

 /// <summary>
 /// 常量:"ems"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ems = "ems";    //字符宽度

protected string mstrAndroidEditTextId;    //AndroidEditTextId
protected string mstrAndroidEditTextName;    //AndroidEditTextName
protected string mstrText;    //文本
protected string mstrCssClass;    //样式表
protected string mstrOnClick;    //单击事件
protected string mstrinputType;    //输入类型
protected int mintems;    //字符宽度
}
}