
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPTextBox
 表名:ASPTextBox(00050224)
 生成代码版本:2019.10.18.1
 生成日期:2019/10/18 10:35:00
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
 /// ASP文本框(ASPTextBox)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPTextBox : ASPControlEx
{
protected const int mintAttributeCount = 2;
public static string[] AttributeName = new string[] {"AspTextBoxId", "AspTextBoxName"};
//以下是属性变量

/// <summary>
/// ASP文本框Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspTextBoxId
{
get
{
return mstrAspTextBoxId;
}
set
{
if (value  ==  "")
{
 mstrAspTextBoxId = value;
}
else
{
 mstrAspTextBoxId = value;
}
}
}
/// <summary>
/// ASP文本框名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspTextBoxName
{
get
{
return mstrAspTextBoxName;
}
set
{
if (value  ==  "")
{
 mstrAspTextBoxName = value;
}
else
{
 mstrAspTextBoxName = value;
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
if (strAttributeName  ==  con_AspTextBoxId)
{
return mstrAspTextBoxId;
}
else if (strAttributeName  ==  con_AspTextBoxName)
{
return mstrAspTextBoxName;
}
return null;
}
set
{
if (strAttributeName  ==  con_AspTextBoxId)
{
mstrAspTextBoxId = value.ToString();
}
else if (strAttributeName  ==  con_AspTextBoxName)
{
mstrAspTextBoxName = value.ToString();
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
if (con_AspTextBoxId  ==  AttributeName[intIndex])
{
return mstrAspTextBoxId;
}
else if (con_AspTextBoxName  ==  AttributeName[intIndex])
{
return mstrAspTextBoxName;
}
return null;
}
set
{
if (con_AspTextBoxId  ==  AttributeName[intIndex])
{
mstrAspTextBoxId = value.ToString();
}
else if (con_AspTextBoxName  ==  AttributeName[intIndex])
{
mstrAspTextBoxName = value.ToString();
}
}
}

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPTextBox()
 {
 }


 /// <summary>
 /// 常量:"AspTextBoxId"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspTextBoxId = "AspTextBoxId";    //ASP文本框Id

 /// <summary>
 /// 常量:"AspTextBoxName"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspTextBoxName = "AspTextBoxName";    //ASP文本框名称

protected string mstrAspTextBoxId;    //ASP文本框Id
protected string mstrAspTextBoxName;    //ASP文本框名称
}
}