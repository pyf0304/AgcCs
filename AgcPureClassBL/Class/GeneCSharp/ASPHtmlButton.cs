
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPHtmlButton
 表名:ASPHtmlButton(00050416)
 生成代码版本:2019.10.18.1
 生成日期:2019/10/18 10:34:53
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:AGC
 工程ID:0005
 模块中文名:生成C#代码
 模块英文名:GeneCSharp
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
 /// ASPHtml按钮(ASPHtmlButton)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPHtmlButton : ASPControlEx
{
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"AspHtmlButtonId", "AspHtmlButtonName", "OnClick", "Value"};
//以下是属性变量

/// <summary>
/// AspHtmlButtonId(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspHtmlButtonId
{
get
{
return mstrAspHtmlButtonId;
}
set
{
if (value  ==  "")
{
 mstrAspHtmlButtonId = value;
}
else
{
 mstrAspHtmlButtonId = value;
}
}
}
/// <summary>
/// AspHtmlButtonName(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspHtmlButtonName
{
get
{
return mstrAspHtmlButtonName;
}
set
{
if (value  ==  "")
{
 mstrAspHtmlButtonName = value;
}
else
{
 mstrAspHtmlButtonName = value;
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
/// 值(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
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
if (strAttributeName  ==  con_AspHtmlButtonId)
{
return mstrAspHtmlButtonId;
}
else if (strAttributeName  ==  con_AspHtmlButtonName)
{
return mstrAspHtmlButtonName;
}
else if (strAttributeName  ==  con_OnClick)
{
return mstrOnClick;
}
else if (strAttributeName  ==  con_Value)
{
return mstrValue;
}
return null;
}
set
{
if (strAttributeName  ==  con_AspHtmlButtonId)
{
mstrAspHtmlButtonId = value.ToString();
}
else if (strAttributeName  ==  con_AspHtmlButtonName)
{
mstrAspHtmlButtonName = value.ToString();
}
else if (strAttributeName  ==  con_OnClick)
{
mstrOnClick = value.ToString();
}
else if (strAttributeName  ==  con_Value)
{
mstrValue = value.ToString();
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
if (con_AspHtmlButtonId  ==  AttributeName[intIndex])
{
return mstrAspHtmlButtonId;
}
else if (con_AspHtmlButtonName  ==  AttributeName[intIndex])
{
return mstrAspHtmlButtonName;
}
else if (con_OnClick  ==  AttributeName[intIndex])
{
return mstrOnClick;
}
else if (con_Value  ==  AttributeName[intIndex])
{
return mstrValue;
}
return null;
}
set
{
if (con_AspHtmlButtonId  ==  AttributeName[intIndex])
{
mstrAspHtmlButtonId = value.ToString();
}
else if (con_AspHtmlButtonName  ==  AttributeName[intIndex])
{
mstrAspHtmlButtonName = value.ToString();
}
else if (con_OnClick  ==  AttributeName[intIndex])
{
mstrOnClick = value.ToString();
}
else if (con_Value  ==  AttributeName[intIndex])
{
mstrValue = value.ToString();
}
}
}

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPHtmlButton()
 {
 }


 /// <summary>
 /// 常量:"AspHtmlButtonId"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspHtmlButtonId = "AspHtmlButtonId";    //AspHtmlButtonId

 /// <summary>
 /// 常量:"AspHtmlButtonName"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspHtmlButtonName = "AspHtmlButtonName";    //AspHtmlButtonName

 /// <summary>
 /// 常量:"OnClick"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_OnClick = "OnClick";    //单击事件

 /// <summary>
 /// 常量:"Value"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Value = "Value";    //值

protected string mstrAspHtmlButtonId;    //AspHtmlButtonId
protected string mstrAspHtmlButtonName;    //AspHtmlButtonName
protected string mstrOnClick;    //单击事件
protected string mstrValue;    //值
}
}