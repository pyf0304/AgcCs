
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPLabel
 表名:ASPLabel(00050222)
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
 /// ASP标签(ASPLabel)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPLabel : ASPControlEx
{
protected new const int mintAttributeCount = 2;
public new static string[] AttributeName = new string[] {"AspLabelId", "AspLabelName"};
//以下是属性变量

protected string mstrAspLabelId;    //Asp标签Id
protected string mstrAspLabelName;    //Asp标签名


 /// <summary>
 /// 常量:"AspLabelId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspLabelId = "AspLabelId";    //Asp标签Id

 /// <summary>
 /// 常量:"AspLabelName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspLabelName = "AspLabelName";    //Asp标签名

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPLabel()
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
if (strAttributeName  ==  con_AspLabelId)
{
return mstrAspLabelId;
}
else if (strAttributeName  ==  con_AspLabelName)
{
return mstrAspLabelName;
}
return null;
}
set
{
if (strAttributeName  ==  con_AspLabelId)
{
mstrAspLabelId = value.ToString();
}
else if (strAttributeName  ==  con_AspLabelName)
{
mstrAspLabelName = value.ToString();
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
if (con_AspLabelId  ==  AttributeName[intIndex])
{
return mstrAspLabelId;
}
else if (con_AspLabelName  ==  AttributeName[intIndex])
{
return mstrAspLabelName;
}
return null;
}
set
{
if (con_AspLabelId  ==  AttributeName[intIndex])
{
mstrAspLabelId = value.ToString();
}
else if (con_AspLabelName  ==  AttributeName[intIndex])
{
mstrAspLabelName = value.ToString();
}
}
}

/// <summary>
/// Asp标签Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspLabelId
{
get
{
return mstrAspLabelId;
}
set
{
if (value  ==  "")
{
 mstrAspLabelId = value;
}
else
{
 mstrAspLabelId = value;
}
}
}
/// <summary>
/// Asp标签名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspLabelName
{
get
{
return mstrAspLabelName;
}
set
{
if (value  ==  "")
{
 mstrAspLabelName = value;
}
else
{
 mstrAspLabelName = value;
}
}
}
}
}