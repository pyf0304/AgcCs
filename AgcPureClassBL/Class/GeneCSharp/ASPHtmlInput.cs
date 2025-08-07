
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPHtmlInput
 表名:ASPHtmlInput(00050449)
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
 /// ASPHtmlInput(ASPHtmlInput)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPHtmlInput : ASPControlEx
{
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"AspHtmlInputId", "AspHtmlInputName", "OnClick", "Value"};
//以下是属性变量

/// <summary>
/// AspHtmlInputId(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspHtmlInputId
{
get
{
return mstrAspHtmlInputId;
}
set
{
if (value  ==  "")
{
 mstrAspHtmlInputId = value;
}
else
{
 mstrAspHtmlInputId = value;
}
}
}
/// <summary>
/// AspHtmlInputName(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspHtmlInputName
{
get
{
return mstrAspHtmlInputName;
}
set
{
if (value  ==  "")
{
 mstrAspHtmlInputName = value;
}
else
{
 mstrAspHtmlInputName = value;
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
if (strAttributeName  ==  con_AspHtmlInputId)
{
return mstrAspHtmlInputId;
}
else if (strAttributeName  ==  con_AspHtmlInputName)
{
return mstrAspHtmlInputName;
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
if (strAttributeName  ==  con_AspHtmlInputId)
{
mstrAspHtmlInputId = value.ToString();
}
else if (strAttributeName  ==  con_AspHtmlInputName)
{
mstrAspHtmlInputName = value.ToString();
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
if (con_AspHtmlInputId  ==  AttributeName[intIndex])
{
return mstrAspHtmlInputId;
}
else if (con_AspHtmlInputName  ==  AttributeName[intIndex])
{
return mstrAspHtmlInputName;
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
if (con_AspHtmlInputId  ==  AttributeName[intIndex])
{
mstrAspHtmlInputId = value.ToString();
}
else if (con_AspHtmlInputName  ==  AttributeName[intIndex])
{
mstrAspHtmlInputName = value.ToString();
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
 public ASPHtmlInput()
 {
 }


 /// <summary>
 /// 常量:"AspHtmlInputId"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspHtmlInputId = "AspHtmlInputId";    //AspHtmlInputId

 /// <summary>
 /// 常量:"AspHtmlInputName"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspHtmlInputName = "AspHtmlInputName";    //AspHtmlInputName

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

protected string mstrAspHtmlInputId;    //AspHtmlInputId
protected string mstrAspHtmlInputName;    //AspHtmlInputName
protected string mstrOnClick;    //单击事件
protected string mstrValue;    //值
}
}