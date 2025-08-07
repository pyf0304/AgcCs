
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ISOBarButtonItem
 表名:ISOBarButtonItem(00050365)
 生成代码版本:2021.07.29.1
 生成日期:2021/07/29 17:41:15
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:AGC
 工程ID:0005
 模块中文名:生成ISO代码
 模块英文名:GCISO
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
 /// ISO条按钮项(ISOBarButtonItem)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ISOBarButtonItem : ISOControlEx
{
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"IsoBarButtonItemId", "IsoBarButtonItemName", "Text", "CssClass", "OnClick"};
//以下是属性变量

protected string mstrIsoBarButtonItemId;    //Iso条按钮项Id
protected string mstrIsoBarButtonItemName;    //Iso条按钮项名
protected string mstrText;    //文本
protected string mstrCssClass;    //样式表
protected string mstrOnClick;    //单击事件


 /// <summary>
 /// 常量:"IsoBarButtonItemId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsoBarButtonItemId = "IsoBarButtonItemId";    //Iso条按钮项Id

 /// <summary>
 /// 常量:"IsoBarButtonItemName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsoBarButtonItemName = "IsoBarButtonItemName";    //Iso条按钮项名

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
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ISOBarButtonItem()
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
if (strAttributeName  ==  con_IsoBarButtonItemId)
{
return mstrIsoBarButtonItemId;
}
else if (strAttributeName  ==  con_IsoBarButtonItemName)
{
return mstrIsoBarButtonItemName;
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
if (strAttributeName  ==  con_IsoBarButtonItemId)
{
mstrIsoBarButtonItemId = value.ToString();
}
else if (strAttributeName  ==  con_IsoBarButtonItemName)
{
mstrIsoBarButtonItemName = value.ToString();
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
if (con_IsoBarButtonItemId  ==  AttributeName[intIndex])
{
return mstrIsoBarButtonItemId;
}
else if (con_IsoBarButtonItemName  ==  AttributeName[intIndex])
{
return mstrIsoBarButtonItemName;
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
if (con_IsoBarButtonItemId  ==  AttributeName[intIndex])
{
mstrIsoBarButtonItemId = value.ToString();
}
else if (con_IsoBarButtonItemName  ==  AttributeName[intIndex])
{
mstrIsoBarButtonItemName = value.ToString();
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
/// Iso条按钮项Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string IsoBarButtonItemId
{
get
{
return mstrIsoBarButtonItemId;
}
set
{
if (value  ==  "")
{
 mstrIsoBarButtonItemId = value;
}
else
{
 mstrIsoBarButtonItemId = value;
}
}
}
/// <summary>
/// Iso条按钮项名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string IsoBarButtonItemName
{
get
{
return mstrIsoBarButtonItemName;
}
set
{
if (value  ==  "")
{
 mstrIsoBarButtonItemName = value;
}
else
{
 mstrIsoBarButtonItemName = value;
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
}
}