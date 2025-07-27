
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPHiddenField
 表名:ASPHiddenField(00050417)
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
 /// ASP隐藏字段(ASPHiddenField)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPHiddenField : ASPControlEx
{
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"AspHiddenFieldId", "AspHiddenFieldName", "Value"};
//以下是属性变量

/// <summary>
/// AspHiddenFieldId(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
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
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
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
/// <summary>
/// 值(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string Value
{
get
{
return mstrValue;
}
set
{
if (value  ==  "")
{
 mstrValue = value;
}
else
{
 mstrValue = value;
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
if (strAttributeName  ==  con_AspHiddenFieldId)
{
return mstrAspHiddenFieldId;
}
else if (strAttributeName  ==  con_AspHiddenFieldName)
{
return mstrAspHiddenFieldName;
}
else if (strAttributeName  ==  con_Value)
{
return mstrValue;
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
else if (strAttributeName  ==  con_Value)
{
mstrValue = value.ToString();
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
if (con_AspHiddenFieldId  ==  AttributeName[intIndex])
{
return mstrAspHiddenFieldId;
}
else if (con_AspHiddenFieldName  ==  AttributeName[intIndex])
{
return mstrAspHiddenFieldName;
}
else if (con_Value  ==  AttributeName[intIndex])
{
return mstrValue;
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
else if (con_Value  ==  AttributeName[intIndex])
{
mstrValue = value.ToString();
}
}
}

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPHiddenField()
 {
 }


 /// <summary>
 /// 常量:"AspHiddenFieldId"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspHiddenFieldId = "AspHiddenFieldId";    //AspHiddenFieldId

 /// <summary>
 /// 常量:"AspHiddenFieldName"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspHiddenFieldName = "AspHiddenFieldName";    //AspHiddenFieldName

 /// <summary>
 /// 常量:"Value"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Value = "Value";    //值

protected string mstrAspHiddenFieldId;    //AspHiddenFieldId
protected string mstrAspHiddenFieldName;    //AspHiddenFieldName
protected string mstrValue;    //值
}
}