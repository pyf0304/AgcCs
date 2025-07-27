
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPHeaderStyle
 表名:ASPHeaderStyle(00050232)
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
 /// ASPHeaderStyle(ASPHeaderStyle)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPHeaderStyle : ASPControlEx
{
protected new const int mintAttributeCount = 2;
public new static string[] AttributeName = new string[] {"AspHeaderStyleId", "AspHeaderStyleName"};
//以下是属性变量

protected string mstrAspHeaderStyleId;    //ASPHeaderStyleId
protected string mstrAspHeaderStyleName;    //ASPHeaderStyleName


 /// <summary>
 /// 常量:"AspHeaderStyleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspHeaderStyleId = "AspHeaderStyleId";    //ASPHeaderStyleId

 /// <summary>
 /// 常量:"AspHeaderStyleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspHeaderStyleName = "AspHeaderStyleName";    //ASPHeaderStyleName

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPHeaderStyle()
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
if (strAttributeName  ==  con_AspHeaderStyleId)
{
return mstrAspHeaderStyleId;
}
else if (strAttributeName  ==  con_AspHeaderStyleName)
{
return mstrAspHeaderStyleName;
}
return null;
}
set
{
if (strAttributeName  ==  con_AspHeaderStyleId)
{
mstrAspHeaderStyleId = value.ToString();
}
else if (strAttributeName  ==  con_AspHeaderStyleName)
{
mstrAspHeaderStyleName = value.ToString();
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
if (con_AspHeaderStyleId  ==  AttributeName[intIndex])
{
return mstrAspHeaderStyleId;
}
else if (con_AspHeaderStyleName  ==  AttributeName[intIndex])
{
return mstrAspHeaderStyleName;
}
return null;
}
set
{
if (con_AspHeaderStyleId  ==  AttributeName[intIndex])
{
mstrAspHeaderStyleId = value.ToString();
}
else if (con_AspHeaderStyleName  ==  AttributeName[intIndex])
{
mstrAspHeaderStyleName = value.ToString();
}
}
}

/// <summary>
/// ASPHeaderStyleId(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspHeaderStyleId
{
get
{
return mstrAspHeaderStyleId;
}
set
{
if (value  ==  "")
{
 mstrAspHeaderStyleId = value;
}
else
{
 mstrAspHeaderStyleId = value;
}
}
}
/// <summary>
/// ASPHeaderStyleName(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspHeaderStyleName
{
get
{
return mstrAspHeaderStyleName;
}
set
{
if (value  ==  "")
{
 mstrAspHeaderStyleName = value;
}
else
{
 mstrAspHeaderStyleName = value;
}
}
}
}
}