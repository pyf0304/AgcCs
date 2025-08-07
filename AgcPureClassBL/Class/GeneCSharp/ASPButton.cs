
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPButton
 表名:ASPButton(00050223)
 生成代码版本:2019.10.18.1
 生成日期:2019/10/18 10:34:47
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
 /// ASP按钮(ASPButton)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPButton : ASPControlEx
{
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"AspButtonId", "AspButtonName", "OnClick"};
//以下是属性变量

/// <summary>
/// Asp按钮Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspButtonId
{
get
{
return mstrAspButtonId;
}
set
{
if (value  ==  "")
{
 mstrAspButtonId = value;
}
else
{
 mstrAspButtonId = value;
}
}
}
/// <summary>
/// Asp按钮名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspButtonName
{
get
{
return mstrAspButtonName;
}
set
{
if (value  ==  "")
{
 mstrAspButtonName = value;
}
else
{
 mstrAspButtonName = value;
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
if (strAttributeName  ==  con_AspButtonId)
{
return mstrAspButtonId;
}
else if (strAttributeName  ==  con_AspButtonName)
{
return mstrAspButtonName;
}
else if (strAttributeName  ==  con_OnClick)
{
return mstrOnClick;
}
return null;
}
set
{
if (strAttributeName  ==  con_AspButtonId)
{
mstrAspButtonId = value.ToString();
}
else if (strAttributeName  ==  con_AspButtonName)
{
mstrAspButtonName = value.ToString();
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
if (con_AspButtonId  ==  AttributeName[intIndex])
{
return mstrAspButtonId;
}
else if (con_AspButtonName  ==  AttributeName[intIndex])
{
return mstrAspButtonName;
}
else if (con_OnClick  ==  AttributeName[intIndex])
{
return mstrOnClick;
}
return null;
}
set
{
if (con_AspButtonId  ==  AttributeName[intIndex])
{
mstrAspButtonId = value.ToString();
}
else if (con_AspButtonName  ==  AttributeName[intIndex])
{
mstrAspButtonName = value.ToString();
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
 public ASPButton()
 {
 }


 /// <summary>
 /// 常量:"AspButtonId"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspButtonId = "AspButtonId";    //Asp按钮Id

 /// <summary>
 /// 常量:"AspButtonName"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspButtonName = "AspButtonName";    //Asp按钮名称

 /// <summary>
 /// 常量:"OnClick"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_OnClick = "OnClick";    //单击事件

protected string mstrAspButtonId;    //Asp按钮Id
protected string mstrAspButtonName;    //Asp按钮名称
protected string mstrOnClick;    //单击事件
}
}