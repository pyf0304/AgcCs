
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPLi
 表名:ASPLi(00050435)
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
 /// ASP列表项目(ASPLi)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPLi : ASPControlEx
{
protected new const int mintAttributeCount = 2;
public new static string[] AttributeName = new string[] {"AspLiId", "AspLiName"};
//以下是属性变量

protected string mstrAspLiId;    //ASP列表项目Id
protected string mstrAspLiName;    //ASP列表项目名


 /// <summary>
 /// 常量:"AspLiId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspLiId = "AspLiId";    //ASP列表项目Id

 /// <summary>
 /// 常量:"AspLiName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspLiName = "AspLiName";    //ASP列表项目名

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPLi()
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
if (strAttributeName  ==  con_AspLiId)
{
return mstrAspLiId;
}
else if (strAttributeName  ==  con_AspLiName)
{
return mstrAspLiName;
}
return null;
}
set
{
if (strAttributeName  ==  con_AspLiId)
{
mstrAspLiId = value.ToString();
}
else if (strAttributeName  ==  con_AspLiName)
{
mstrAspLiName = value.ToString();
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
if (con_AspLiId  ==  AttributeName[intIndex])
{
return mstrAspLiId;
}
else if (con_AspLiName  ==  AttributeName[intIndex])
{
return mstrAspLiName;
}
return null;
}
set
{
if (con_AspLiId  ==  AttributeName[intIndex])
{
mstrAspLiId = value.ToString();
}
else if (con_AspLiName  ==  AttributeName[intIndex])
{
mstrAspLiName = value.ToString();
}
}
}

/// <summary>
/// ASP列表项目Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspLiId
{
get
{
return mstrAspLiId;
}
set
{
if (value  ==  "")
{
 mstrAspLiId = value;
}
else
{
 mstrAspLiId = value;
}
}
}
/// <summary>
/// ASP列表项目名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspLiName
{
get
{
return mstrAspLiName;
}
set
{
if (value  ==  "")
{
 mstrAspLiName = value;
}
else
{
 mstrAspLiName = value;
}
}
}
}
}