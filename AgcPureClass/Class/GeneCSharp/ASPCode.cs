
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPCode
 表名:ASPCode(00050433)
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
 /// ASP代码(ASPCode)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPCode : ASPControlEx
{
protected new const int mintAttributeCount = 4;
public new static string[]  AttributeName = new string[] {"AspCodeId", "AspCodeName", "CodeText", "UpdDate"};
//以下是属性变量

protected string mstrAspCodeId;    //ASP代码Id
protected string mstrAspCodeName;    //ASP代码名
protected string mstrCodeText;    //代码文本
protected string mstrUpdDate;    //修改日期


 /// <summary>
 /// 常量:"AspCodeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspCodeId = "AspCodeId";    //ASP代码Id

 /// <summary>
 /// 常量:"AspCodeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspCodeName = "AspCodeName";    //ASP代码名

 /// <summary>
 /// 常量:"CodeText"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_CodeText = "CodeText";    //代码文本

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpdDate = "UpdDate";    //修改日期

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPCode()
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
public new object this[int intIndex]
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
/// ASP代码Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
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
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
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
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
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
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
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
}
}