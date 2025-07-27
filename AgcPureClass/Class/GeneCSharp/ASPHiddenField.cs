
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPHiddenField
 表名:ASPHiddenField(00050417)
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
 /// ASP隐藏字段(ASPHiddenField)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPHiddenField : ASPControlEx
{
protected new const int mintAttributeCount = 2;
public new static string[] AttributeName = new string[] {"AspHiddenFieldId", "AspHiddenFieldName"};
//以下是属性变量

protected string mstrAspHiddenFieldId;    //AspHiddenFieldId
protected string mstrAspHiddenFieldName;    //AspHiddenFieldName


 /// <summary>
 /// 常量:"AspHiddenFieldId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspHiddenFieldId = "AspHiddenFieldId";    //AspHiddenFieldId

 /// <summary>
 /// 常量:"AspHiddenFieldName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspHiddenFieldName = "AspHiddenFieldName";    //AspHiddenFieldName

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPHiddenField()
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
if (strAttributeName  ==  con_AspHiddenFieldId)
{
return mstrAspHiddenFieldId;
}
else if (strAttributeName  ==  con_AspHiddenFieldName)
{
return mstrAspHiddenFieldName;
}
return null;
}
set
{
if (strAttributeName  ==  con_AspHiddenFieldId)
{
mstrAspHiddenFieldId = value.ToString();
}
else if (strAttributeName  ==  con_AspHiddenFieldName)
{
mstrAspHiddenFieldName = value.ToString();
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
if (con_AspHiddenFieldId  ==  AttributeName[intIndex])
{
return mstrAspHiddenFieldId;
}
else if (con_AspHiddenFieldName  ==  AttributeName[intIndex])
{
return mstrAspHiddenFieldName;
}
return null;
}
set
{
if (con_AspHiddenFieldId  ==  AttributeName[intIndex])
{
mstrAspHiddenFieldId = value.ToString();
}
else if (con_AspHiddenFieldName  ==  AttributeName[intIndex])
{
mstrAspHiddenFieldName = value.ToString();
}
}
}

/// <summary>
/// AspHiddenFieldId(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspHiddenFieldId
{
get
{
return mstrAspHiddenFieldId;
}
set
{
if (value  ==  "")
{
 mstrAspHiddenFieldId = value;
}
else
{
 mstrAspHiddenFieldId = value;
}
}
}
/// <summary>
/// AspHiddenFieldName(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspHiddenFieldName
{
get
{
return mstrAspHiddenFieldName;
}
set
{
if (value  ==  "")
{
 mstrAspHiddenFieldName = value;
}
else
{
 mstrAspHiddenFieldName = value;
}
}
}
}
}