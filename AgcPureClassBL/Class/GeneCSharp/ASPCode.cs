
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPCode
 表名:ASPCode(00050433)
 生成代码版本:2019.10.18.1
 生成日期:2019/10/18 10:34:47
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
 /// ASP代码(ASPCode)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPCode : ASPControlEx
{
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"AspCodeId", "AspCodeName", "CodeText", "UpdDate"};
//以下是属性变量

/// <summary>
/// ASP代码Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspCodeId
{
get
{
return mstrAspCodeId;
}
set
{
if (value  ==  "")
{
 mstrAspCodeId = value;
}
else
{
 mstrAspCodeId = value;
}
}
}
/// <summary>
/// ASP代码名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspCodeName
{
get
{
return mstrAspCodeName;
}
set
{
if (value  ==  "")
{
 mstrAspCodeName = value;
}
else
{
 mstrAspCodeName = value;
}
}
}
/// <summary>
/// 代码文本(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string CodeText
{
get
{
return mstrCodeText;
}
set
{
if (value  ==  "")
{
 mstrCodeText = value;
}
else
{
 mstrCodeText = value;
}
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string UpdDate
{
get
{
return mstrUpdDate;
}
set
{
if (value  ==  "")
{
 mstrUpdDate = value;
}
else
{
 mstrUpdDate = value;
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
if (strAttributeName  ==  con_AspCodeId)
{
return mstrAspCodeId;
}
else if (strAttributeName  ==  con_AspCodeName)
{
return mstrAspCodeName;
}
else if (strAttributeName  ==  con_CodeText)
{
return mstrCodeText;
}
else if (strAttributeName  ==  con_UpdDate)
{
return mstrUpdDate;
}
return null;
}
set
{
if (strAttributeName  ==  con_AspCodeId)
{
mstrAspCodeId = value.ToString();
}
else if (strAttributeName  ==  con_AspCodeName)
{
mstrAspCodeName = value.ToString();
}
else if (strAttributeName  ==  con_CodeText)
{
mstrCodeText = value.ToString();
}
else if (strAttributeName  ==  con_UpdDate)
{
mstrUpdDate = value.ToString();
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
if (con_AspCodeId  ==  AttributeName[intIndex])
{
return mstrAspCodeId;
}
else if (con_AspCodeName  ==  AttributeName[intIndex])
{
return mstrAspCodeName;
}
else if (con_CodeText  ==  AttributeName[intIndex])
{
return mstrCodeText;
}
else if (con_UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
return null;
}
set
{
if (con_AspCodeId  ==  AttributeName[intIndex])
{
mstrAspCodeId = value.ToString();
}
else if (con_AspCodeName  ==  AttributeName[intIndex])
{
mstrAspCodeName = value.ToString();
}
else if (con_CodeText  ==  AttributeName[intIndex])
{
mstrCodeText = value.ToString();
}
else if (con_UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
}
}
}

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPCode()
 {
 }


 /// <summary>
 /// 常量:"AspCodeId"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspCodeId = "AspCodeId";    //ASP代码Id

 /// <summary>
 /// 常量:"AspCodeName"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspCodeName = "AspCodeName";    //ASP代码名

 /// <summary>
 /// 常量:"CodeText"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_CodeText = "CodeText";    //代码文本

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpdDate = "UpdDate";    //修改日期

protected string mstrAspCodeId;    //ASP代码Id
protected string mstrAspCodeName;    //ASP代码名
protected string mstrCodeText;    //代码文本
protected string mstrUpdDate;    //修改日期
}
}