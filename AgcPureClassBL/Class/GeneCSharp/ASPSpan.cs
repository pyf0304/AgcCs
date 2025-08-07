
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPSpan
 表名:ASPSpan(00050425)
 生成代码版本:2019.10.18.1
 生成日期:2019/10/18 10:34:59
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
 /// ASPSpan标签(ASPSpan)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPSpan : ASPControlEx
{
protected const int mintAttributeCount = 2;
public static string[] AttributeName = new string[] {"ASPSpanId", "ASPSpanName"};
//以下是属性变量

/// <summary>
/// Asp标签Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string ASPSpanId
{
get
{
return mstrASPSpanId;
}
set
{
if (value  ==  "")
{
 mstrASPSpanId = value;
}
else
{
 mstrASPSpanId = value;
}
}
}
/// <summary>
/// Asp标签名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string ASPSpanName
{
get
{
return mstrASPSpanName;
}
set
{
if (value  ==  "")
{
 mstrASPSpanName = value;
}
else
{
 mstrASPSpanName = value;
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
if (strAttributeName  ==  con_ASPSpanId)
{
return mstrASPSpanId;
}
else if (strAttributeName  ==  con_ASPSpanName)
{
return mstrASPSpanName;
}
return null;
}
set
{
if (strAttributeName  ==  con_ASPSpanId)
{
mstrASPSpanId = value.ToString();
}
else if (strAttributeName  ==  con_ASPSpanName)
{
mstrASPSpanName = value.ToString();
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
if (con_ASPSpanId  ==  AttributeName[intIndex])
{
return mstrASPSpanId;
}
else if (con_ASPSpanName  ==  AttributeName[intIndex])
{
return mstrASPSpanName;
}
return null;
}
set
{
if (con_ASPSpanId  ==  AttributeName[intIndex])
{
mstrASPSpanId = value.ToString();
}
else if (con_ASPSpanName  ==  AttributeName[intIndex])
{
mstrASPSpanName = value.ToString();
}
}
}

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPSpan()
 {
 }


 /// <summary>
 /// 常量:"ASPSpanId"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ASPSpanId = "ASPSpanId";    //Asp标签Id

 /// <summary>
 /// 常量:"ASPSpanName"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ASPSpanName = "ASPSpanName";    //Asp标签名

protected string mstrASPSpanId;    //Asp标签Id
protected string mstrASPSpanName;    //Asp标签名
}
}