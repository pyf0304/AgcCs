
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPDropDownList
 表名:ASPDropDownList(00050414)
 生成代码版本:2021.11.17.1
 生成日期:2021/11/18 02:09:28
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(变量首字母不限定)
 模块中文名:生成C#代码(GeneCSharp)
 框架-层名:纯粹类(PureClass)
 编程语言:CSharp
 注意:1、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
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
 /// ASP下拉框(ASPDropDownList)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPDropDownList : ASPControlEx
{
protected new const int mintAttributeCount = 3;
public new static string[] AttributeName = new string[] {"AspNetDropDownListId", "AspNetDropDownListName", "entries"};
//以下是属性变量

protected string mstrAspNetDropDownListId;    //ASPNETDropDownListId
protected string mstrAspNetDropDownListName;    //ASPNETDropDownListName
protected string mstrentries;    //下拉项


 /// <summary>
 /// 常量:"AspNetDropDownListId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspNetDropDownListId = "AspNetDropDownListId";    //ASPNETDropDownListId

 /// <summary>
 /// 常量:"AspNetDropDownListName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspNetDropDownListName = "AspNetDropDownListName";    //ASPNETDropDownListName

 /// <summary>
 /// 常量:"entries"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_entries = "entries";    //下拉项

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPDropDownList()
 {
 }

public new static int AttributeCount
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
public new object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  con_AspNetDropDownListId)
{
return mstrAspNetDropDownListId;
}
else if (strAttributeName  ==  con_AspNetDropDownListName)
{
return mstrAspNetDropDownListName;
}
else if (strAttributeName  ==  con_entries)
{
return mstrentries;
}
return null;
}
set
{
if (strAttributeName  ==  con_AspNetDropDownListId)
{
mstrAspNetDropDownListId = value.ToString();
}
else if (strAttributeName  ==  con_AspNetDropDownListName)
{
mstrAspNetDropDownListName = value.ToString();
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
public new object this[int intIndex]
{
get
{
if (con_AspNetDropDownListId  ==  AttributeName[intIndex])
{
return mstrAspNetDropDownListId;
}
else if (con_AspNetDropDownListName  ==  AttributeName[intIndex])
{
return mstrAspNetDropDownListName;
}
else if (con_entries  ==  AttributeName[intIndex])
{
return mstrentries;
}
return null;
}
set
{
if (con_AspNetDropDownListId  ==  AttributeName[intIndex])
{
mstrAspNetDropDownListId = value.ToString();
}
else if (con_AspNetDropDownListName  ==  AttributeName[intIndex])
{
mstrAspNetDropDownListName = value.ToString();
}
else if (con_entries  ==  AttributeName[intIndex])
{
mstrentries = value.ToString();
}
}
}

/// <summary>
/// ASPNETDropDownListId(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspNetDropDownListId
{
get
{
return mstrAspNetDropDownListId;
}
set
{
if (value  ==  "")
{
 mstrAspNetDropDownListId = value;
}
else
{
 mstrAspNetDropDownListId = value;
}
}
}
/// <summary>
/// ASPNETDropDownListName(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspNetDropDownListName
{
get
{
return mstrAspNetDropDownListName;
}
set
{
if (value  ==  "")
{
 mstrAspNetDropDownListName = value;
}
else
{
 mstrAspNetDropDownListName = value;
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