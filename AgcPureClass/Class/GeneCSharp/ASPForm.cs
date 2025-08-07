
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPForm
 表名:ASPForm(00050216)
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
 /// ASP窗体(ASPForm)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPForm : ASPControlEx
{
protected new const int mintAttributeCount = 2;
public new static string[] AttributeName = new string[] {"AspFormId", "AspFormName"};
//以下是属性变量

protected string mstrAspFormId;    //Asp窗体Id
protected string mstrAspFormName;    //Asp窗体名称


 /// <summary>
 /// 常量:"AspFormId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspFormId = "AspFormId";    //Asp窗体Id

 /// <summary>
 /// 常量:"AspFormName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspFormName = "AspFormName";    //Asp窗体名称

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPForm()
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
if (strAttributeName  ==  con_AspFormId)
{
return mstrAspFormId;
}
else if (strAttributeName  ==  con_AspFormName)
{
return mstrAspFormName;
}
return null;
}
set
{
if (strAttributeName  ==  con_AspFormId)
{
mstrAspFormId = value.ToString();
}
else if (strAttributeName  ==  con_AspFormName)
{
mstrAspFormName = value.ToString();
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
if (con_AspFormId  ==  AttributeName[intIndex])
{
return mstrAspFormId;
}
else if (con_AspFormName  ==  AttributeName[intIndex])
{
return mstrAspFormName;
}
return null;
}
set
{
if (con_AspFormId  ==  AttributeName[intIndex])
{
mstrAspFormId = value.ToString();
}
else if (con_AspFormName  ==  AttributeName[intIndex])
{
mstrAspFormName = value.ToString();
}
}
}

/// <summary>
/// Asp窗体Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspFormId
{
get
{
return mstrAspFormId;
}
set
{
if (value  ==  "")
{
 mstrAspFormId = value;
}
else
{
 mstrAspFormId = value;
}
}
}
/// <summary>
/// Asp窗体名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspFormName
{
get
{
return mstrAspFormName;
}
set
{
if (value  ==  "")
{
 mstrAspFormName = value;
}
else
{
 mstrAspFormName = value;
}
}
}
}
}