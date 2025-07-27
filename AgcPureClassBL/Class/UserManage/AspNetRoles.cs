
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:AspNetRoles
 表名:AspNetRoles(00050421)
 生成代码版本:2019.10.18.1
 生成日期:2019/10/18 10:34:57
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:AGC
 工程ID:0005
 模块中文名:用户管理
 模块英文名:UserManage
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
 /// AspNetRoles(AspNetRoles)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class AspNetRoles 
{
protected const int mintAttributeCount = 2;
public static string[] AttributeName = new string[] {"Id", "Name"};
//以下是属性变量

/// <summary>
/// Id(说明:;字段类型:nvarchar;字段长度:256;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string Id
{
get
{
return mstrId;
}
set
{
if (value  ==  "")
{
 mstrId = value;
}
else
{
 mstrId = value;
}
}
}
/// <summary>
/// Name(说明:;字段类型:nvarchar;字段长度:512;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string Name
{
get
{
return mstrName;
}
set
{
if (value  ==  "")
{
 mstrName = value;
}
else
{
 mstrName = value;
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
if (strAttributeName  ==  con_Id)
{
return mstrId;
}
else if (strAttributeName  ==  con_Name)
{
return mstrName;
}
return null;
}
set
{
if (strAttributeName  ==  con_Id)
{
mstrId = value.ToString();
}
else if (strAttributeName  ==  con_Name)
{
mstrName = value.ToString();
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
if (con_Id  ==  AttributeName[intIndex])
{
return mstrId;
}
else if (con_Name  ==  AttributeName[intIndex])
{
return mstrName;
}
return null;
}
set
{
if (con_Id  ==  AttributeName[intIndex])
{
mstrId = value.ToString();
}
else if (con_Name  ==  AttributeName[intIndex])
{
mstrName = value.ToString();
}
}
}

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public AspNetRoles()
 {
 }


 /// <summary>
 /// 常量:"Id"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Id = "Id";    //Id

 /// <summary>
 /// 常量:"Name"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Name = "Name";    //Name

protected string mstrId;    //Id
protected string mstrName;    //Name
}
}