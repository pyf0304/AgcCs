
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:AndroidInclude
 表名:AndroidInclude(00050388)
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
 /// Android包含(AndroidInclude)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class AndroidInclude : AndroidControlEx
{
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"AndroidIncludeId", "AndroidIncludeName", "Text", "CssClass", "layout"};
//以下是属性变量

protected string mstrAndroidIncludeId;    //AndroidIncludeId
protected string mstrAndroidIncludeName;    //AndroidIncludeName
protected string mstrText;    //文本
protected string mstrCssClass;    //样式表
protected string mstrlayout;    //布局


 /// <summary>
 /// 常量:"AndroidIncludeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AndroidIncludeId = "AndroidIncludeId";    //AndroidIncludeId

 /// <summary>
 /// 常量:"AndroidIncludeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AndroidIncludeName = "AndroidIncludeName";    //AndroidIncludeName

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
 /// 常量:"layout"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_layout = "layout";    //布局

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public AndroidInclude()
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
if (strAttributeName  ==  con_AndroidIncludeId)
{
return mstrAndroidIncludeId;
}
else if (strAttributeName  ==  con_AndroidIncludeName)
{
return mstrAndroidIncludeName;
}
else if (strAttributeName  ==  con_Text)
{
return mstrText;
}
else if (strAttributeName  ==  con_CssClass)
{
return mstrCssClass;
}
else if (strAttributeName  ==  con_layout)
{
return mstrlayout;
}
return null;
}
set
{
if (strAttributeName  ==  con_AndroidIncludeId)
{
mstrAndroidIncludeId = value.ToString();
}
else if (strAttributeName  ==  con_AndroidIncludeName)
{
mstrAndroidIncludeName = value.ToString();
}
else if (strAttributeName  ==  con_Text)
{
mstrText = value.ToString();
}
else if (strAttributeName  ==  con_CssClass)
{
mstrCssClass = value.ToString();
}
else if (strAttributeName  ==  con_layout)
{
mstrlayout = value.ToString();
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
if (con_AndroidIncludeId  ==  AttributeName[intIndex])
{
return mstrAndroidIncludeId;
}
else if (con_AndroidIncludeName  ==  AttributeName[intIndex])
{
return mstrAndroidIncludeName;
}
else if (con_Text  ==  AttributeName[intIndex])
{
return mstrText;
}
else if (con_CssClass  ==  AttributeName[intIndex])
{
return mstrCssClass;
}
else if (con_layout  ==  AttributeName[intIndex])
{
return mstrlayout;
}
return null;
}
set
{
if (con_AndroidIncludeId  ==  AttributeName[intIndex])
{
mstrAndroidIncludeId = value.ToString();
}
else if (con_AndroidIncludeName  ==  AttributeName[intIndex])
{
mstrAndroidIncludeName = value.ToString();
}
else if (con_Text  ==  AttributeName[intIndex])
{
mstrText = value.ToString();
}
else if (con_CssClass  ==  AttributeName[intIndex])
{
mstrCssClass = value.ToString();
}
else if (con_layout  ==  AttributeName[intIndex])
{
mstrlayout = value.ToString();
}
}
}

/// <summary>
/// AndroidIncludeId(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AndroidIncludeId
{
get
{
return mstrAndroidIncludeId;
}
set
{
if (value  ==  "")
{
 mstrAndroidIncludeId = value;
}
else
{
 mstrAndroidIncludeId = value;
}
}
}
/// <summary>
/// AndroidIncludeName(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AndroidIncludeName
{
get
{
return mstrAndroidIncludeName;
}
set
{
if (value  ==  "")
{
 mstrAndroidIncludeName = value;
}
else
{
 mstrAndroidIncludeName = value;
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
/// 布局(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
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
 mstrlayout = value;
}
else
{
 mstrlayout = value;
}
}
}
}
}