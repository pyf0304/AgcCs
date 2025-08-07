
///----------------------
///生成代码版本：2012.01.02.1
///生成日期：2012/08/27
///生成者：pyf
///工程名称：AGC
///工程ID：0005
///模块中文名：字段、表维护
///模块英文名：Table_Field
///注意：1、需要数据底层（PubDataBase.dll）的版本：2011.05.08.1
///       2、需要公共函数层（TzPubFunction.dll）的版本：2011.05.08.1
///========================
using System;
using System.Text; 
using System.Collections; 
using com.taishsoft.comm_db_obj;

namespace AGC.Entity
{
/// <summary>
/// 字段列(Column)
/// </summary>
[Serializable]
public class clsColumnEN : clsEntityBase2
{
public const string CurrTabName_S = "Column"; //当前表名，与该类相关的表名
public const string CurrTabKeyFldName_S = "id"; //当前表中的关键字名称，与该类相关的表中关键字名
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"id", "DataField", "HeaderText", "SortExpression"};
 //以下是属性变量


 /// <summary> 
 /// id(字段类型:int identity,字段长度:4,是否可空:False)
 /// </summary>
 protected int mintid;

 /// <summary> 
 /// DataField(字段类型:varchar,字段长度:50,是否可空:False)
 /// </summary>
 protected string mstrDataField;

 /// <summary> 
 /// HeaderText(字段类型:varchar,字段长度:30,是否可空:False)
 /// </summary>
 protected string mstrHeaderText;

 /// <summary> 
 /// SortExpression(字段类型:varchar,字段长度:50,是否可空:False)
 /// </summary>
 protected string mstrSortExpression;


 public clsColumnEN()
 {
 SetInit();
 _CurrTabName = "Column";
 lstKeyFldNames.Add("id");
 }

public clsColumnEN(int intid)
 {

mintid=intid;
 SetInit();
 _CurrTabName = "Column";
 lstKeyFldNames.Add("id");
 }

public static int AttributeCount
{
get
{
return mintAttributeCount;
}
}
public new object this[string strAttributeName]
{
get
{
if (strAttributeName == "id")
{
return mintid;
}
else if (strAttributeName == "DataField")
{
return mstrDataField;
}
else if (strAttributeName == "HeaderText")
{
return mstrHeaderText;
}
else if (strAttributeName == "SortExpression")
{
return mstrSortExpression;
}
return null;
}
set
{
if (strAttributeName == "id")
{
mintid = TransNullToInt(value.ToString());
}
else if (strAttributeName == "DataField")
{
mstrDataField = value.ToString();
}
else if (strAttributeName == "HeaderText")
{
mstrHeaderText = value.ToString();
}
else if (strAttributeName == "SortExpression")
{
mstrSortExpression = value.ToString();
}
}
}
public object this[int intIndex]
{
get
{
if ("id" == AttributeName[intIndex])
{
return mintid;
}
else if ("DataField" == AttributeName[intIndex])
{
return mstrDataField;
}
else if ("HeaderText" == AttributeName[intIndex])
{
return mstrHeaderText;
}
else if ("SortExpression" == AttributeName[intIndex])
{
return mstrSortExpression;
}
return null;
}
set
{
if ("id" == AttributeName[intIndex])
{
mintid = TransNullToInt(value.ToString());
}
else if ("DataField" == AttributeName[intIndex])
{
mstrDataField = value.ToString();
}
else if ("HeaderText" == AttributeName[intIndex])
{
mstrHeaderText = value.ToString();
}
else if ("SortExpression" == AttributeName[intIndex])
{
mstrSortExpression = value.ToString();
}
}
}

/// <summary>
/// id(说明:;字段类型:int identity;字段长度:4;是否可空:False)
/// </summary>
public int id
{
get
{
return mintid;
}
set
{
mintid = value;
//记录修改过的字段
AddUpdatedFld("id");
}
}
/// <summary>
/// DataField(说明:;字段类型:varchar;字段长度:50;是否可空:False)
/// </summary>
public string DataField
{
get
{
return mstrDataField;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrDataField = value;
}
else
{
mstrDataField = value;
}
//记录修改过的字段
AddUpdatedFld("DataField");
}
}
/// <summary>
/// HeaderText(说明:;字段类型:varchar;字段长度:30;是否可空:False)
/// </summary>
public string HeaderText
{
get
{
return mstrHeaderText;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrHeaderText = value;
}
else
{
mstrHeaderText = value;
}
//记录修改过的字段
AddUpdatedFld("HeaderText");
}
}
/// <summary>
/// SortExpression(说明:;字段类型:varchar;字段长度:50;是否可空:False)
/// </summary>
public string SortExpression
{
get
{
return mstrSortExpression;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrSortExpression = value;
}
else
{
mstrSortExpression = value;
}
//记录修改过的字段
AddUpdatedFld("SortExpression");
}
}
}
}