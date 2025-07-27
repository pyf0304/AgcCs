
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPUl
 表名:ASPUl(00050434)
 生成代码版本:2021.11.17.1
 生成日期:2021/11/18 02:09:30
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
 /// ASP无序列表(ASPUl)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPUl : ASPControlEx
{
protected new const int mintAttributeCount = 2;
public new static string[] AttributeName = new string[] {"AspUlId", "AspUlName"};
//以下是属性变量

protected string mstrAspUlId;    //ASP无序列表Id
protected string mstrAspUlName;    //ASP无序列表名


 /// <summary>
 /// 常量:"AspUlId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspUlId = "AspUlId";    //ASP无序列表Id

 /// <summary>
 /// 常量:"AspUlName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspUlName = "AspUlName";    //ASP无序列表名

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPUl()
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
if (strAttributeName  ==  con_AspUlId)
{
return mstrAspUlId;
}
else if (strAttributeName  ==  con_AspUlName)
{
return mstrAspUlName;
}
return null;
}
set
{
if (strAttributeName  ==  con_AspUlId)
{
mstrAspUlId = value.ToString();
}
else if (strAttributeName  ==  con_AspUlName)
{
mstrAspUlName = value.ToString();
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
if (con_AspUlId  ==  AttributeName[intIndex])
{
return mstrAspUlId;
}
else if (con_AspUlName  ==  AttributeName[intIndex])
{
return mstrAspUlName;
}
return null;
}
set
{
if (con_AspUlId  ==  AttributeName[intIndex])
{
mstrAspUlId = value.ToString();
}
else if (con_AspUlName  ==  AttributeName[intIndex])
{
mstrAspUlName = value.ToString();
}
}
}

/// <summary>
/// ASP无序列表Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspUlId
{
get
{
return mstrAspUlId;
}
set
{
if (value  ==  "")
{
 mstrAspUlId = value;
}
else
{
 mstrAspUlId = value;
}
}
}
/// <summary>
/// ASP无序列表名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspUlName
{
get
{
return mstrAspUlName;
}
set
{
if (value  ==  "")
{
 mstrAspUlName = value;
}
else
{
 mstrAspUlName = value;
}
}
}
}
}