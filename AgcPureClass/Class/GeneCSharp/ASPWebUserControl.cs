
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPWebUserControl
 表名:ASPWebUserControl(00050234)
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
 /// ASPWeb用户控件(ASPWebUserControl)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPWebUserControl : ASPControlEx
{
protected new const int mintAttributeCount = 4;
public new static string[] AttributeName = new string[] {"AspWebUserControlId", "AspWebUserControlName", "TagPrefix", "wucClassName"};
//以下是属性变量

protected string mstrAspWebUserControlId;    //ASPWeb用户控件Id
protected string mstrAspWebUserControlName;    //ASPWeb用户控件名
protected string mstrTagPrefix;    //标签前缀
protected string mstrwucClassName;    //Web用户控件类名


 /// <summary>
 /// 常量:"AspWebUserControlId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspWebUserControlId = "AspWebUserControlId";    //ASPWeb用户控件Id

 /// <summary>
 /// 常量:"AspWebUserControlName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspWebUserControlName = "AspWebUserControlName";    //ASPWeb用户控件名

 /// <summary>
 /// 常量:"TagPrefix"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_TagPrefix = "TagPrefix";    //标签前缀

 /// <summary>
 /// 常量:"wucClassName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_wucClassName = "wucClassName";    //Web用户控件类名

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPWebUserControl()
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
if (strAttributeName  ==  con_AspWebUserControlId)
{
return mstrAspWebUserControlId;
}
else if (strAttributeName  ==  con_AspWebUserControlName)
{
return mstrAspWebUserControlName;
}
else if (strAttributeName  ==  con_TagPrefix)
{
return mstrTagPrefix;
}
else if (strAttributeName  ==  con_wucClassName)
{
return mstrwucClassName;
}
return null;
}
set
{
if (strAttributeName  ==  con_AspWebUserControlId)
{
mstrAspWebUserControlId = value.ToString();
}
else if (strAttributeName  ==  con_AspWebUserControlName)
{
mstrAspWebUserControlName = value.ToString();
}
else if (strAttributeName  ==  con_TagPrefix)
{
mstrTagPrefix = value.ToString();
}
else if (strAttributeName  ==  con_wucClassName)
{
mstrwucClassName = value.ToString();
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
if (con_AspWebUserControlId  ==  AttributeName[intIndex])
{
return mstrAspWebUserControlId;
}
else if (con_AspWebUserControlName  ==  AttributeName[intIndex])
{
return mstrAspWebUserControlName;
}
else if (con_TagPrefix  ==  AttributeName[intIndex])
{
return mstrTagPrefix;
}
else if (con_wucClassName  ==  AttributeName[intIndex])
{
return mstrwucClassName;
}
return null;
}
set
{
if (con_AspWebUserControlId  ==  AttributeName[intIndex])
{
mstrAspWebUserControlId = value.ToString();
}
else if (con_AspWebUserControlName  ==  AttributeName[intIndex])
{
mstrAspWebUserControlName = value.ToString();
}
else if (con_TagPrefix  ==  AttributeName[intIndex])
{
mstrTagPrefix = value.ToString();
}
else if (con_wucClassName  ==  AttributeName[intIndex])
{
mstrwucClassName = value.ToString();
}
}
}

/// <summary>
/// ASPWeb用户控件Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspWebUserControlId
{
get
{
return mstrAspWebUserControlId;
}
set
{
if (value  ==  "")
{
 mstrAspWebUserControlId = value;
}
else
{
 mstrAspWebUserControlId = value;
}
}
}
/// <summary>
/// ASPWeb用户控件名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspWebUserControlName
{
get
{
return mstrAspWebUserControlName;
}
set
{
if (value  ==  "")
{
 mstrAspWebUserControlName = value;
}
else
{
 mstrAspWebUserControlName = value;
}
}
}
/// <summary>
/// 标签前缀(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string TagPrefix
{
get
{
return mstrTagPrefix;
}
set
{
if (value  ==  "")
{
 mstrTagPrefix = value;
}
else
{
 mstrTagPrefix = value;
}
}
}
/// <summary>
/// Web用户控件类名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string wucClassName
{
get
{
return mstrwucClassName;
}
set
{
if (value  ==  "")
{
 mstrwucClassName = value;
}
else
{
 mstrwucClassName = value;
}
}
}
}
}