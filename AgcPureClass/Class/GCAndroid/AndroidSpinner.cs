
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:AndroidSpinner
 表名:AndroidSpinner(00050391)
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
 /// Android下拉框(AndroidSpinner)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class AndroidSpinner : AndroidControlEx
{
protected const int mintAttributeCount = 6;
public static string[] AttributeName = new string[] {"AndroidSpinnerId", "AndroidSpinnerName", "Text", "CssClass", "OnClick", "entries"};
//以下是属性变量

protected string mstrAndroidSpinnerId;    //AndroidSpinnerId
protected string mstrAndroidSpinnerName;    //AndroidSpinnerName
protected string mstrText;    //文本
protected string mstrCssClass;    //样式表
protected string mstrOnClick;    //单击事件
protected string mstrentries;    //下拉项


 /// <summary>
 /// 常量:"AndroidSpinnerId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AndroidSpinnerId = "AndroidSpinnerId";    //AndroidSpinnerId

 /// <summary>
 /// 常量:"AndroidSpinnerName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AndroidSpinnerName = "AndroidSpinnerName";    //AndroidSpinnerName

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
 /// 常量:"entries"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_entries = "entries";    //下拉项

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public AndroidSpinner()
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
if (strAttributeName  ==  con_AndroidSpinnerId)
{
return mstrAndroidSpinnerId;
}
else if (strAttributeName  ==  con_AndroidSpinnerName)
{
return mstrAndroidSpinnerName;
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
else if (strAttributeName  ==  con_entries)
{
return mstrentries;
}
return null;
}
set
{
if (strAttributeName  ==  con_AndroidSpinnerId)
{
mstrAndroidSpinnerId = value.ToString();
}
else if (strAttributeName  ==  con_AndroidSpinnerName)
{
mstrAndroidSpinnerName = value.ToString();
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
else if (strAttributeName  ==  con_entries)
{
mstrentries = value.ToString();
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
if (con_AndroidSpinnerId  ==  AttributeName[intIndex])
{
return mstrAndroidSpinnerId;
}
else if (con_AndroidSpinnerName  ==  AttributeName[intIndex])
{
return mstrAndroidSpinnerName;
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
else if (con_entries  ==  AttributeName[intIndex])
{
return mstrentries;
}
return null;
}
set
{
if (con_AndroidSpinnerId  ==  AttributeName[intIndex])
{
mstrAndroidSpinnerId = value.ToString();
}
else if (con_AndroidSpinnerName  ==  AttributeName[intIndex])
{
mstrAndroidSpinnerName = value.ToString();
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
else if (con_entries  ==  AttributeName[intIndex])
{
mstrentries = value.ToString();
}
}
}

/// <summary>
/// AndroidSpinnerId(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AndroidSpinnerId
{
get
{
return mstrAndroidSpinnerId;
}
set
{
if (value  ==  "")
{
 mstrAndroidSpinnerId = value;
}
else
{
 mstrAndroidSpinnerId = value;
}
}
}
/// <summary>
/// AndroidSpinnerName(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AndroidSpinnerName
{
get
{
return mstrAndroidSpinnerName;
}
set
{
if (value  ==  "")
{
 mstrAndroidSpinnerName = value;
}
else
{
 mstrAndroidSpinnerName = value;
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
/// 下拉项(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string entries
{
get
{
return mstrentries;
}
set
{
if (value  ==  "")
{
 mstrentries = value;
}
else
{
 mstrentries = value;
}
}
}
}
}