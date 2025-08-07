
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPCheckBox
 表名:ASPCheckBox(00050233)
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
 /// ASP复选框(ASPCheckBox)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPCheckBox : ASPControlEx
{
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"ASPCheckBoxId", "ASPCheckBoxName", "OnClick"};
//以下是属性变量

/// <summary>
/// ASP复选框Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string ASPCheckBoxId
{
get
{
return mstrASPCheckBoxId;
}
set
{
if (value  ==  "")
{
 mstrASPCheckBoxId = value;
}
else
{
 mstrASPCheckBoxId = value;
}
}
}
/// <summary>
/// ASP复选框名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string ASPCheckBoxName
{
get
{
return mstrASPCheckBoxName;
}
set
{
if (value  ==  "")
{
 mstrASPCheckBoxName = value;
}
else
{
 mstrASPCheckBoxName = value;
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
if (strAttributeName  ==  con_ASPCheckBoxId)
{
return mstrASPCheckBoxId;
}
else if (strAttributeName  ==  con_ASPCheckBoxName)
{
return mstrASPCheckBoxName;
}
else if (strAttributeName  ==  con_OnClick)
{
return mstrOnClick;
}
return null;
}
set
{
if (strAttributeName  ==  con_ASPCheckBoxId)
{
mstrASPCheckBoxId = value.ToString();
}
else if (strAttributeName  ==  con_ASPCheckBoxName)
{
mstrASPCheckBoxName = value.ToString();
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
if (con_ASPCheckBoxId  ==  AttributeName[intIndex])
{
return mstrASPCheckBoxId;
}
else if (con_ASPCheckBoxName  ==  AttributeName[intIndex])
{
return mstrASPCheckBoxName;
}
else if (con_OnClick  ==  AttributeName[intIndex])
{
return mstrOnClick;
}
return null;
}
set
{
if (con_ASPCheckBoxId  ==  AttributeName[intIndex])
{
mstrASPCheckBoxId = value.ToString();
}
else if (con_ASPCheckBoxName  ==  AttributeName[intIndex])
{
mstrASPCheckBoxName = value.ToString();
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
 public ASPCheckBox()
 {
 }


 /// <summary>
 /// 常量:"ASPCheckBoxId"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ASPCheckBoxId = "ASPCheckBoxId";    //ASP复选框Id

 /// <summary>
 /// 常量:"ASPCheckBoxName"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ASPCheckBoxName = "ASPCheckBoxName";    //ASP复选框名

 /// <summary>
 /// 常量:"OnClick"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_OnClick = "OnClick";    //单击事件

protected string mstrASPCheckBoxId;    //ASP复选框Id
protected string mstrASPCheckBoxName;    //ASP复选框名
protected string mstrOnClick;    //单击事件
}
}