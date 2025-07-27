
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPHr
 表名:ASPHr(00050415)
 生成代码版本:2019.10.18.1
 生成日期:2019/10/18 10:34:52
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
 /// ASP水平线(ASPHr)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPHr : ASPControlEx
{
protected const int mintAttributeCount = 2;
public static string[] AttributeName = new string[] {"AspHrId", "AspHrName"};
//以下是属性变量

/// <summary>
/// Asp水平线Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspHrId
{
get
{
return mstrAspHrId;
}
set
{
if (value  ==  "")
{
 mstrAspHrId = value;
}
else
{
 mstrAspHrId = value;
}
}
}
/// <summary>
/// Asp水平线名(说明:;字段类型:varchar;字段长度:8;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspHrName
{
get
{
return mstrAspHrName;
}
set
{
if (value  ==  "")
{
 mstrAspHrName = value;
}
else
{
 mstrAspHrName = value;
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
if (strAttributeName  ==  con_AspHrId)
{
return mstrAspHrId;
}
else if (strAttributeName  ==  con_AspHrName)
{
return mstrAspHrName;
}
return null;
}
set
{
if (strAttributeName  ==  con_AspHrId)
{
mstrAspHrId = value.ToString();
}
else if (strAttributeName  ==  con_AspHrName)
{
mstrAspHrName = value.ToString();
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
if (con_AspHrId  ==  AttributeName[intIndex])
{
return mstrAspHrId;
}
else if (con_AspHrName  ==  AttributeName[intIndex])
{
return mstrAspHrName;
}
return null;
}
set
{
if (con_AspHrId  ==  AttributeName[intIndex])
{
mstrAspHrId = value.ToString();
}
else if (con_AspHrName  ==  AttributeName[intIndex])
{
mstrAspHrName = value.ToString();
}
}
}

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPHr()
 {
 }


 /// <summary>
 /// 常量:"AspHrId"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspHrId = "AspHrId";    //Asp水平线Id

 /// <summary>
 /// 常量:"AspHrName"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspHrName = "AspHrName";    //Asp水平线名

protected string mstrAspHrId;    //Asp水平线Id
protected string mstrAspHrName;    //Asp水平线名
}
}