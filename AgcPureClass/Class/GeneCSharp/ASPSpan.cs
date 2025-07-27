
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPSpan
 表名:ASPSpan(00050425)
 生成代码版本:2021.11.17.1
 生成日期:2021/11/18 02:09:29
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
 /// ASPSpan标签(ASPSpan)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPSpan : ASPControlEx
{
protected new const int mintAttributeCount = 2;
public new static string[] AttributeName = new string[] {"AspSpanId", "AspSpanName"};
//以下是属性变量

protected string mstrAspSpanId;    //Asp标签Id
protected string mstrAspSpanName;    //Asp标签名


 /// <summary>
 /// 常量:"AspSpanId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspSpanId = "AspSpanId";    //Asp标签Id

 /// <summary>
 /// 常量:"AspSpanName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspSpanName = "AspSpanName";    //Asp标签名

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPSpan()
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
if (strAttributeName  ==  con_AspSpanId)
{
return mstrAspSpanId;
}
else if (strAttributeName  ==  con_AspSpanName)
{
return mstrAspSpanName;
}
return null;
}
set
{
if (strAttributeName  ==  con_AspSpanId)
{
mstrAspSpanId = value.ToString();
}
else if (strAttributeName  ==  con_AspSpanName)
{
mstrAspSpanName = value.ToString();
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
if (con_AspSpanId  ==  AttributeName[intIndex])
{
return mstrAspSpanId;
}
else if (con_AspSpanName  ==  AttributeName[intIndex])
{
return mstrAspSpanName;
}
return null;
}
set
{
if (con_AspSpanId  ==  AttributeName[intIndex])
{
mstrAspSpanId = value.ToString();
}
else if (con_AspSpanName  ==  AttributeName[intIndex])
{
mstrAspSpanName = value.ToString();
}
}
}

/// <summary>
/// Asp标签Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspSpanId
{
get
{
return mstrAspSpanId;
}
set
{
if (value  ==  "")
{
 mstrAspSpanId = value;
}
else
{
 mstrAspSpanId = value;
}
}
}
/// <summary>
/// Asp标签名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspSpanName
{
get
{
return mstrAspSpanName;
}
set
{
if (value  ==  "")
{
 mstrAspSpanName = value;
}
else
{
 mstrAspSpanName = value;
}
}
}
}
}