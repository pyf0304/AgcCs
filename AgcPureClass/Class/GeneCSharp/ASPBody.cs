
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPBody
 表名:ASPBody(00050215)
 生成代码版本:2021.11.17.1
 生成日期:2021/11/18 02:09:24
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
 /// ASP主体(ASPBody)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPBody : ASPControlEx
{
protected new const int mintAttributeCount = 2;
public new static string[] AttributeName = new string[] {"AspBodyId", "AspBodyName"};
//以下是属性变量

protected string mstrAspBodyId;    //Asp主体Id
protected string mstrAspBodyName;    //Asp主体名称


 /// <summary>
 /// 常量:"AspBodyId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspBodyId = "AspBodyId";    //Asp主体Id

 /// <summary>
 /// 常量:"AspBodyName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspBodyName = "AspBodyName";    //Asp主体名称

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPBody()
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
if (strAttributeName  ==  con_AspBodyId)
{
return mstrAspBodyId;
}
else if (strAttributeName  ==  con_AspBodyName)
{
return mstrAspBodyName;
}
return null;
}
set
{
if (strAttributeName  ==  con_AspBodyId)
{
mstrAspBodyId = value.ToString();
}
else if (strAttributeName  ==  con_AspBodyName)
{
mstrAspBodyName = value.ToString();
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
if (con_AspBodyId  ==  AttributeName[intIndex])
{
return mstrAspBodyId;
}
else if (con_AspBodyName  ==  AttributeName[intIndex])
{
return mstrAspBodyName;
}
return null;
}
set
{
if (con_AspBodyId  ==  AttributeName[intIndex])
{
mstrAspBodyId = value.ToString();
}
else if (con_AspBodyName  ==  AttributeName[intIndex])
{
mstrAspBodyName = value.ToString();
}
}
}

/// <summary>
/// Asp主体Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspBodyId
{
get
{
return mstrAspBodyId;
}
set
{
if (value  ==  "")
{
 mstrAspBodyId = value;
}
else
{
 mstrAspBodyId = value;
}
}
}
/// <summary>
/// Asp主体名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspBodyName
{
get
{
return mstrAspBodyName;
}
set
{
if (value  ==  "")
{
 mstrAspBodyName = value;
}
else
{
 mstrAspBodyName = value;
}
}
}
}
}