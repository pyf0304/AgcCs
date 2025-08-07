
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPBoundField
 表名:ASPBoundField(00050226)
 生成代码版本:2021.11.17.1
 生成日期:2021/11/18 02:09:27
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
 /// ASP绑定字段(ASPBoundField)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPBoundField : ASPControlEx
{
protected new const int mintAttributeCount = 5;
public new static string[] AttributeName = new string[] {"AspBoundFieldId", "AspBoundFieldName", "DataField", "SortExpression", "HeaderText"};
//以下是属性变量

protected string mstrAspBoundFieldId;    //Asp绑定字段Id
protected string mstrAspBoundFieldName;    //Asp绑定字段名
protected string mstrDataField;    //DataField
protected string mstrSortExpression;    //排序表达式
protected string mstrHeaderText;    //列头


 /// <summary>
 /// 常量:"AspBoundFieldId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspBoundFieldId = "AspBoundFieldId";    //Asp绑定字段Id

 /// <summary>
 /// 常量:"AspBoundFieldName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspBoundFieldName = "AspBoundFieldName";    //Asp绑定字段名

 /// <summary>
 /// 常量:"DataField"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_DataField = "DataField";    //DataField

 /// <summary>
 /// 常量:"SortExpression"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_SortExpression = "SortExpression";    //排序表达式

 /// <summary>
 /// 常量:"HeaderText"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_HeaderText = "HeaderText";    //列头

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPBoundField()
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
if (strAttributeName  ==  con_AspBoundFieldId)
{
return mstrAspBoundFieldId;
}
else if (strAttributeName  ==  con_AspBoundFieldName)
{
return mstrAspBoundFieldName;
}
else if (strAttributeName  ==  con_DataField)
{
return mstrDataField;
}
else if (strAttributeName  ==  con_SortExpression)
{
return mstrSortExpression;
}
else if (strAttributeName  ==  con_HeaderText)
{
return mstrHeaderText;
}
return null;
}
set
{
if (strAttributeName  ==  con_AspBoundFieldId)
{
mstrAspBoundFieldId = value.ToString();
}
else if (strAttributeName  ==  con_AspBoundFieldName)
{
mstrAspBoundFieldName = value.ToString();
}
else if (strAttributeName  ==  con_DataField)
{
mstrDataField = value.ToString();
}
else if (strAttributeName  ==  con_SortExpression)
{
mstrSortExpression = value.ToString();
}
else if (strAttributeName  ==  con_HeaderText)
{
mstrHeaderText = value.ToString();
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
if (con_AspBoundFieldId  ==  AttributeName[intIndex])
{
return mstrAspBoundFieldId;
}
else if (con_AspBoundFieldName  ==  AttributeName[intIndex])
{
return mstrAspBoundFieldName;
}
else if (con_DataField  ==  AttributeName[intIndex])
{
return mstrDataField;
}
else if (con_SortExpression  ==  AttributeName[intIndex])
{
return mstrSortExpression;
}
else if (con_HeaderText  ==  AttributeName[intIndex])
{
return mstrHeaderText;
}
return null;
}
set
{
if (con_AspBoundFieldId  ==  AttributeName[intIndex])
{
mstrAspBoundFieldId = value.ToString();
}
else if (con_AspBoundFieldName  ==  AttributeName[intIndex])
{
mstrAspBoundFieldName = value.ToString();
}
else if (con_DataField  ==  AttributeName[intIndex])
{
mstrDataField = value.ToString();
}
else if (con_SortExpression  ==  AttributeName[intIndex])
{
mstrSortExpression = value.ToString();
}
else if (con_HeaderText  ==  AttributeName[intIndex])
{
mstrHeaderText = value.ToString();
}
}
}

/// <summary>
/// Asp绑定字段Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspBoundFieldId
{
get
{
return mstrAspBoundFieldId;
}
set
{
if (value  ==  "")
{
 mstrAspBoundFieldId = value;
}
else
{
 mstrAspBoundFieldId = value;
}
}
}
/// <summary>
/// Asp绑定字段名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspBoundFieldName
{
get
{
return mstrAspBoundFieldName;
}
set
{
if (value  ==  "")
{
 mstrAspBoundFieldName = value;
}
else
{
 mstrAspBoundFieldName = value;
}
}
}
/// <summary>
/// DataField(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string DataField
{
get
{
return mstrDataField;
}
set
{
if (value  ==  "")
{
 mstrDataField = value;
}
else
{
 mstrDataField = value;
}
}
}
/// <summary>
/// 排序表达式(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string SortExpression
{
get
{
return mstrSortExpression;
}
set
{
if (value  ==  "")
{
 mstrSortExpression = value;
}
else
{
 mstrSortExpression = value;
}
}
}
/// <summary>
/// 列头(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string HeaderText
{
get
{
return mstrHeaderText;
}
set
{
if (value  ==  "")
{
 mstrHeaderText = value;
}
else
{
 mstrHeaderText = value;
}
}
}
}
}