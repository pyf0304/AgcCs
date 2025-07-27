
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPDropDownList
 表名:ASPDropDownList(00050414)
 生成代码版本:2019.10.18.1
 生成日期:2019/10/18 10:34:49
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
 /// ASP下拉框(ASPDropDownList)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPDropDownList : ASPControlEx
{
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"ASPNETDropDownListId", "ASPNETDropDownListName", "entries"};
//以下是属性变量

/// <summary>
/// ASPNETDropDownListId(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string ASPNETDropDownListId
{
get
{
return mstrASPNETDropDownListId;
}
set
{
if (value  ==  "")
{
 mstrASPNETDropDownListId = value;
}
else
{
 mstrASPNETDropDownListId = value;
}
}
}
/// <summary>
/// ASPNETDropDownListName(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string ASPNETDropDownListName
{
get
{
return mstrASPNETDropDownListName;
}
set
{
if (value  ==  "")
{
 mstrASPNETDropDownListName = value;
}
else
{
 mstrASPNETDropDownListName = value;
}
}
}
/// <summary>
/// 下拉项(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
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
if (strAttributeName  ==  con_ASPNETDropDownListId)
{
return mstrASPNETDropDownListId;
}
else if (strAttributeName  ==  con_ASPNETDropDownListName)
{
return mstrASPNETDropDownListName;
}
else if (strAttributeName  ==  con_entries)
{
return mstrentries;
}
return null;
}
set
{
if (strAttributeName  ==  con_ASPNETDropDownListId)
{
mstrASPNETDropDownListId = value.ToString();
}
else if (strAttributeName  ==  con_ASPNETDropDownListName)
{
mstrASPNETDropDownListName = value.ToString();
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
if (con_ASPNETDropDownListId  ==  AttributeName[intIndex])
{
return mstrASPNETDropDownListId;
}
else if (con_ASPNETDropDownListName  ==  AttributeName[intIndex])
{
return mstrASPNETDropDownListName;
}
else if (con_entries  ==  AttributeName[intIndex])
{
return mstrentries;
}
return null;
}
set
{
if (con_ASPNETDropDownListId  ==  AttributeName[intIndex])
{
mstrASPNETDropDownListId = value.ToString();
}
else if (con_ASPNETDropDownListName  ==  AttributeName[intIndex])
{
mstrASPNETDropDownListName = value.ToString();
}
else if (con_entries  ==  AttributeName[intIndex])
{
mstrentries = value.ToString();
}
}
}

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPDropDownList()
 {
 }


 /// <summary>
 /// 常量:"ASPNETDropDownListId"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ASPNETDropDownListId = "ASPNETDropDownListId";    //ASPNETDropDownListId

 /// <summary>
 /// 常量:"ASPNETDropDownListName"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ASPNETDropDownListName = "ASPNETDropDownListName";    //ASPNETDropDownListName

 /// <summary>
 /// 常量:"entries"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_entries = "entries";    //下拉项

protected string mstrASPNETDropDownListId;    //ASPNETDropDownListId
protected string mstrASPNETDropDownListName;    //ASPNETDropDownListName
protected string mstrentries;    //下拉项
}
}