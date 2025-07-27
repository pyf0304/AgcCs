
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPH4
 表名:ASPH4(00050450)
 生成代码版本:2021.11.17.1
 生成日期:2021/11/18 02:09:31
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
 /// ASPH4(ASPH4)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPH4 : ASPControlEx
{
protected new const int mintAttributeCount = 2;
public new static string[] AttributeName = new string[] {"AspH4Id", "AspH4Name"};
//以下是属性变量

protected string mstrAspH4Id;    //AspH4Id
protected string mstrAspH4Name;    //AspH4Name


 /// <summary>
 /// 常量:"AspH4Id"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspH4Id = "AspH4Id";    //AspH4Id

 /// <summary>
 /// 常量:"AspH4Name"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspH4Name = "AspH4Name";    //AspH4Name

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPH4()
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
if (strAttributeName  ==  con_AspH4Id)
{
return mstrAspH4Id;
}
else if (strAttributeName  ==  con_AspH4Name)
{
return mstrAspH4Name;
}
return null;
}
set
{
if (strAttributeName  ==  con_AspH4Id)
{
mstrAspH4Id = value.ToString();
}
else if (strAttributeName  ==  con_AspH4Name)
{
mstrAspH4Name = value.ToString();
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
if (con_AspH4Id  ==  AttributeName[intIndex])
{
return mstrAspH4Id;
}
else if (con_AspH4Name  ==  AttributeName[intIndex])
{
return mstrAspH4Name;
}
return null;
}
set
{
if (con_AspH4Id  ==  AttributeName[intIndex])
{
mstrAspH4Id = value.ToString();
}
else if (con_AspH4Name  ==  AttributeName[intIndex])
{
mstrAspH4Name = value.ToString();
}
}
}

/// <summary>
/// AspH4Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspH4Id
{
get
{
return mstrAspH4Id;
}
set
{
if (value  ==  "")
{
 mstrAspH4Id = value;
}
else
{
 mstrAspH4Id = value;
}
}
}
/// <summary>
/// AspH4Name(说明:;字段类型:varchar;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspH4Name
{
get
{
return mstrAspH4Name;
}
set
{
if (value  ==  "")
{
 mstrAspH4Name = value;
}
else
{
 mstrAspH4Name = value;
}
}
}
}
}