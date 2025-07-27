
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPCheckBox
 表名:ASPCheckBox(00050233)
 生成代码版本:2021.11.17.1
 生成日期:2021/11/18 02:09:28
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
 /// ASP复选框(ASPCheckBox)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPCheckBox : ASPControlEx
{
protected new const int mintAttributeCount = 2;
public new static string[] AttributeName = new string[] {"AspCheckBoxId", "AspCheckBoxName"};
//以下是属性变量

protected string mstrAspCheckBoxId;    //ASP复选框Id
protected string mstrAspCheckBoxName;    //ASP复选框名


 /// <summary>
 /// 常量:"AspCheckBoxId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspCheckBoxId = "AspCheckBoxId";    //ASP复选框Id

 /// <summary>
 /// 常量:"AspCheckBoxName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspCheckBoxName = "AspCheckBoxName";    //ASP复选框名

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPCheckBox()
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
if (strAttributeName  ==  con_AspCheckBoxId)
{
return mstrAspCheckBoxId;
}
else if (strAttributeName  ==  con_AspCheckBoxName)
{
return mstrAspCheckBoxName;
}
return null;
}
set
{
if (strAttributeName  ==  con_AspCheckBoxId)
{
mstrAspCheckBoxId = value.ToString();
}
else if (strAttributeName  ==  con_AspCheckBoxName)
{
mstrAspCheckBoxName = value.ToString();
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
if (con_AspCheckBoxId  ==  AttributeName[intIndex])
{
return mstrAspCheckBoxId;
}
else if (con_AspCheckBoxName  ==  AttributeName[intIndex])
{
return mstrAspCheckBoxName;
}
return null;
}
set
{
if (con_AspCheckBoxId  ==  AttributeName[intIndex])
{
mstrAspCheckBoxId = value.ToString();
}
else if (con_AspCheckBoxName  ==  AttributeName[intIndex])
{
mstrAspCheckBoxName = value.ToString();
}
}
}

/// <summary>
/// ASP复选框Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspCheckBoxId
{
get
{
return mstrAspCheckBoxId;
}
set
{
if (value  ==  "")
{
 mstrAspCheckBoxId = value;
}
else
{
 mstrAspCheckBoxId = value;
}
}
}
/// <summary>
/// ASP复选框名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspCheckBoxName
{
get
{
return mstrAspCheckBoxName;
}
set
{
if (value  ==  "")
{
 mstrAspCheckBoxName = value;
}
else
{
 mstrAspCheckBoxName = value;
}
}
}
}
}