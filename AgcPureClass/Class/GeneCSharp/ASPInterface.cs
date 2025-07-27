
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPInterface
 表名:ASPInterface(00050213)
 生成代码版本:2021.11.17.1
 生成日期:2021/11/18 02:09:23
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
 /// ASP界面(ASPInterface)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPInterface : ASPControlEx
{
protected new const int mintAttributeCount = 6;
public new static string[] AttributeName = new string[] {"AspInterfaceId", "AspInterfaceName", "ClassName", "FileName", "UserId", "FuncModuleName"};
//以下是属性变量

protected string mstrAspInterfaceId;    //Asp界面Id
protected string mstrAspInterfaceName;    //Asp界面名称
protected string mstrClassName;    //类名
protected string mstrFileName;    //文件名
protected string mstrUserId;    //用户Id
protected string mstrFuncModuleName;    //功能模块名称


 /// <summary>
 /// 常量:"AspInterfaceId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspInterfaceId = "AspInterfaceId";    //Asp界面Id

 /// <summary>
 /// 常量:"AspInterfaceName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspInterfaceName = "AspInterfaceName";    //Asp界面名称

 /// <summary>
 /// 常量:"ClassName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ClassName = "ClassName";    //类名

 /// <summary>
 /// 常量:"FileName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_FileName = "FileName";    //文件名

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UserId = "UserId";    //用户Id

 /// <summary>
 /// 常量:"FuncModuleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_FuncModuleName = "FuncModuleName";    //功能模块名称

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPInterface()
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
if (strAttributeName  ==  con_AspInterfaceId)
{
return mstrAspInterfaceId;
}
else if (strAttributeName  ==  con_AspInterfaceName)
{
return mstrAspInterfaceName;
}
else if (strAttributeName  ==  con_ClassName)
{
return mstrClassName;
}
else if (strAttributeName  ==  con_FileName)
{
return mstrFileName;
}
else if (strAttributeName  ==  con_UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  con_FuncModuleName)
{
return mstrFuncModuleName;
}
return null;
}
set
{
if (strAttributeName  ==  con_AspInterfaceId)
{
mstrAspInterfaceId = value.ToString();
}
else if (strAttributeName  ==  con_AspInterfaceName)
{
mstrAspInterfaceName = value.ToString();
}
else if (strAttributeName  ==  con_ClassName)
{
mstrClassName = value.ToString();
}
else if (strAttributeName  ==  con_FileName)
{
mstrFileName = value.ToString();
}
else if (strAttributeName  ==  con_UserId)
{
mstrUserId = value.ToString();
}
else if (strAttributeName  ==  con_FuncModuleName)
{
mstrFuncModuleName = value.ToString();
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
if (con_AspInterfaceId  ==  AttributeName[intIndex])
{
return mstrAspInterfaceId;
}
else if (con_AspInterfaceName  ==  AttributeName[intIndex])
{
return mstrAspInterfaceName;
}
else if (con_ClassName  ==  AttributeName[intIndex])
{
return mstrClassName;
}
else if (con_FileName  ==  AttributeName[intIndex])
{
return mstrFileName;
}
else if (con_UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (con_FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
return null;
}
set
{
if (con_AspInterfaceId  ==  AttributeName[intIndex])
{
mstrAspInterfaceId = value.ToString();
}
else if (con_AspInterfaceName  ==  AttributeName[intIndex])
{
mstrAspInterfaceName = value.ToString();
}
else if (con_ClassName  ==  AttributeName[intIndex])
{
mstrClassName = value.ToString();
}
else if (con_FileName  ==  AttributeName[intIndex])
{
mstrFileName = value.ToString();
}
else if (con_UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
}
else if (con_FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
}
}
}

/// <summary>
/// Asp界面Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspInterfaceId
{
get
{
return mstrAspInterfaceId;
}
set
{
if (value  ==  "")
{
 mstrAspInterfaceId = value;
}
else
{
 mstrAspInterfaceId = value;
}
}
}
/// <summary>
/// Asp界面名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspInterfaceName
{
get
{
return mstrAspInterfaceName;
}
set
{
if (value  ==  "")
{
 mstrAspInterfaceName = value;
}
else
{
 mstrAspInterfaceName = value;
}
}
}
/// <summary>
/// 类名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string ClassName
{
get
{
return mstrClassName;
}
set
{
if (value  ==  "")
{
 mstrClassName = value;
}
else
{
 mstrClassName = value;
}
}
}
/// <summary>
/// 文件名(说明:;字段类型:varchar;字段长度:150;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string FileName
{
get
{
return mstrFileName;
}
set
{
if (value  ==  "")
{
 mstrFileName = value;
}
else
{
 mstrFileName = value;
}
}
}
/// <summary>
/// 用户Id(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string UserId
{
get
{
return mstrUserId;
}
set
{
if (value  ==  "")
{
 mstrUserId = value;
}
else
{
 mstrUserId = value;
}
}
}
/// <summary>
/// 功能模块名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleName
{
get
{
return mstrFuncModuleName;
}
set
{
if (value  ==  "")
{
 mstrFuncModuleName = value;
}
else
{
 mstrFuncModuleName = value;
}
}
}
}
}