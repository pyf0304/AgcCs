
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ISOviewControllerLayoutGuide
 表名:ISOviewControllerLayoutGuide(00050361)
 生成代码版本:2021.07.29.1
 生成日期:2021/07/29 18:18:40
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
 /// ISO视图控制器布局(ISOviewControllerLayoutGuide)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ISOviewControllerLayoutGuide : ISOControlEx
{
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"IsoviewControllerLayoutGuideId", "IsoviewControllerLayoutGuideName", "Text", "CssClass", "OnClick"};
//以下是属性变量

protected string mstrIsoviewControllerLayoutGuideId;    //Iso视图控制器布局Id
protected string mstrIsoviewControllerLayoutGuideName;    //Iso视图控制器布局名
protected string mstrText;    //文本
protected string mstrCssClass;    //样式表
protected string mstrOnClick;    //单击事件


 /// <summary>
 /// 常量:"IsoviewControllerLayoutGuideId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsoviewControllerLayoutGuideId = "IsoviewControllerLayoutGuideId";    //Iso视图控制器布局Id

 /// <summary>
 /// 常量:"IsoviewControllerLayoutGuideName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsoviewControllerLayoutGuideName = "IsoviewControllerLayoutGuideName";    //Iso视图控制器布局名

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
 public ISOviewControllerLayoutGuide()
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
if (strAttributeName  ==  con_IsoviewControllerLayoutGuideId)
{
return mstrIsoviewControllerLayoutGuideId;
}
else if (strAttributeName  ==  con_IsoviewControllerLayoutGuideName)
{
return mstrIsoviewControllerLayoutGuideName;
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
if (strAttributeName  ==  con_IsoviewControllerLayoutGuideId)
{
mstrIsoviewControllerLayoutGuideId = value.ToString();
}
else if (strAttributeName  ==  con_IsoviewControllerLayoutGuideName)
{
mstrIsoviewControllerLayoutGuideName = value.ToString();
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
if (con_IsoviewControllerLayoutGuideId  ==  AttributeName[intIndex])
{
return mstrIsoviewControllerLayoutGuideId;
}
else if (con_IsoviewControllerLayoutGuideName  ==  AttributeName[intIndex])
{
return mstrIsoviewControllerLayoutGuideName;
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
if (con_IsoviewControllerLayoutGuideId  ==  AttributeName[intIndex])
{
mstrIsoviewControllerLayoutGuideId = value.ToString();
}
else if (con_IsoviewControllerLayoutGuideName  ==  AttributeName[intIndex])
{
mstrIsoviewControllerLayoutGuideName = value.ToString();
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
/// Iso视图控制器布局Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string IsoviewControllerLayoutGuideId
{
get
{
return mstrIsoviewControllerLayoutGuideId;
}
set
{
if (value  ==  "")
{
 mstrIsoviewControllerLayoutGuideId = value;
}
else
{
 mstrIsoviewControllerLayoutGuideId = value;
}
}
}
/// <summary>
/// Iso视图控制器布局名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string IsoviewControllerLayoutGuideName
{
get
{
return mstrIsoviewControllerLayoutGuideName;
}
set
{
if (value  ==  "")
{
 mstrIsoviewControllerLayoutGuideName = value;
}
else
{
 mstrIsoviewControllerLayoutGuideName = value;
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