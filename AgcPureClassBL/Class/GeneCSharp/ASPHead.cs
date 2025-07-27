
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPHead
 表名:ASPHead(00050214)
 生成代码版本:2019.10.18.1
 生成日期:2019/10/18 10:34:51
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
 /// ASP头(ASPHead)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPHead : ASPControlEx
{
protected const int mintAttributeCount = 2;
public static string[] AttributeName = new string[] {"AspHeadId", "AspHeadName"};
//以下是属性变量

/// <summary>
/// Asp头Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspHeadId
{
get
{
return mstrAspHeadId;
}
set
{
if (value  ==  "")
{
 mstrAspHeadId = value;
}
else
{
 mstrAspHeadId = value;
}
}
}
/// <summary>
/// Asp头名(说明:;字段类型:varchar;字段长度:8;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspHeadName
{
get
{
return mstrAspHeadName;
}
set
{
if (value  ==  "")
{
 mstrAspHeadName = value;
}
else
{
 mstrAspHeadName = value;
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
if (strAttributeName  ==  con_AspHeadId)
{
return mstrAspHeadId;
}
else if (strAttributeName  ==  con_AspHeadName)
{
return mstrAspHeadName;
}
return null;
}
set
{
if (strAttributeName  ==  con_AspHeadId)
{
mstrAspHeadId = value.ToString();
}
else if (strAttributeName  ==  con_AspHeadName)
{
mstrAspHeadName = value.ToString();
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
if (con_AspHeadId  ==  AttributeName[intIndex])
{
return mstrAspHeadId;
}
else if (con_AspHeadName  ==  AttributeName[intIndex])
{
return mstrAspHeadName;
}
return null;
}
set
{
if (con_AspHeadId  ==  AttributeName[intIndex])
{
mstrAspHeadId = value.ToString();
}
else if (con_AspHeadName  ==  AttributeName[intIndex])
{
mstrAspHeadName = value.ToString();
}
}
}

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPHead()
 {
 }


 /// <summary>
 /// 常量:"AspHeadId"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspHeadId = "AspHeadId";    //Asp头Id

 /// <summary>
 /// 常量:"AspHeadName"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspHeadName = "AspHeadName";    //Asp头名

protected string mstrAspHeadId;    //Asp头Id
protected string mstrAspHeadName;    //Asp头名
}
}