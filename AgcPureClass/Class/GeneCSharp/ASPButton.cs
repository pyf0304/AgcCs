
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPButton
 表名:ASPButton(00050223)
 生成代码版本:2021.11.17.1
 生成日期:2021/11/18 02:09:26
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
 /// ASP按钮(ASPButton)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPButton : ASPControlEx
{
protected new const int mintAttributeCount = 2;
public new static string[] AttributeName = new string[] {"AspButtonId", "AspButtonName"};
//以下是属性变量

protected string mstrAspButtonId;    //Asp按钮Id
protected string mstrAspButtonName;    //Asp按钮名称


 /// <summary>
 /// 常量:"AspButtonId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspButtonId = "AspButtonId";    //Asp按钮Id

 /// <summary>
 /// 常量:"AspButtonName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspButtonName = "AspButtonName";    //Asp按钮名称

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPButton()
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
if (strAttributeName  ==  con_AspButtonId)
{
return mstrAspButtonId;
}
else if (strAttributeName  ==  con_AspButtonName)
{
return mstrAspButtonName;
}
return null;
}
set
{
if (strAttributeName  ==  con_AspButtonId)
{
mstrAspButtonId = value.ToString();
}
else if (strAttributeName  ==  con_AspButtonName)
{
mstrAspButtonName = value.ToString();
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
if (con_AspButtonId  ==  AttributeName[intIndex])
{
return mstrAspButtonId;
}
else if (con_AspButtonName  ==  AttributeName[intIndex])
{
return mstrAspButtonName;
}
return null;
}
set
{
if (con_AspButtonId  ==  AttributeName[intIndex])
{
mstrAspButtonId = value.ToString();
}
else if (con_AspButtonName  ==  AttributeName[intIndex])
{
mstrAspButtonName = value.ToString();
}
}
}

/// <summary>
/// Asp按钮Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspButtonId
{
get
{
return mstrAspButtonId;
}
set
{
if (value  ==  "")
{
 mstrAspButtonId = value;
}
else
{
 mstrAspButtonId = value;
}
}
}
/// <summary>
/// Asp按钮名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspButtonName
{
get
{
return mstrAspButtonName;
}
set
{
if (value  ==  "")
{
 mstrAspButtonName = value;
}
else
{
 mstrAspButtonName = value;
}
}
}
}
}