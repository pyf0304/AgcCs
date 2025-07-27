
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPBoundField
 表名:ASPBoundField(00050226)
 生成代码版本:2019.10.18.1
 生成日期:2019/10/18 10:34:46
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
 /// ASP绑定字段(ASPBoundField)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPBoundField : ASPControlEx
{
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"AspBoundFieldId", "AspBoundFieldName", "DataField", "SortExpression", "HeaderText"};
//以下是属性变量

/// <summary>
/// Asp绑定字段Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
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
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
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
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
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
/// SortExpression(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
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
/// HeaderText(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
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
public object this[int intIndex]
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
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPBoundField()
 {
 }


 /// <summary>
 /// 常量:"AspBoundFieldId"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspBoundFieldId = "AspBoundFieldId";    //Asp绑定字段Id

 /// <summary>
 /// 常量:"AspBoundFieldName"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspBoundFieldName = "AspBoundFieldName";    //Asp绑定字段名

 /// <summary>
 /// 常量:"DataField"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_DataField = "DataField";    //DataField

 /// <summary>
 /// 常量:"SortExpression"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_SortExpression = "SortExpression";    //SortExpression

 /// <summary>
 /// 常量:"HeaderText"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_HeaderText = "HeaderText";    //HeaderText

protected string mstrAspBoundFieldId;    //Asp绑定字段Id
protected string mstrAspBoundFieldName;    //Asp绑定字段名
protected string mstrDataField;    //DataField
protected string mstrSortExpression;    //SortExpression
protected string mstrHeaderText;    //HeaderText
}
}