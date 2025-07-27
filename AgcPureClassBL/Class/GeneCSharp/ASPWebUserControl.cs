
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPWebUserControl
 表名:ASPWebUserControl(00050234)
 生成代码版本:2019.10.18.1
 生成日期:2019/10/18 10:35:01
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
 /// ASPWeb用户控件(ASPWebUserControl)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPWebUserControl : ASPControlEx
{
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"ASPWebUserControlId", "ASPWebUserControlName", "TagPrefix", "wucClassName"};
//以下是属性变量

/// <summary>
/// ASPWeb用户控件Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string ASPWebUserControlId
{
get
{
return mstrASPWebUserControlId;
}
set
{
if (value  ==  "")
{
 mstrASPWebUserControlId = value;
}
else
{
 mstrASPWebUserControlId = value;
}
}
}
/// <summary>
/// ASPWeb用户控件名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string ASPWebUserControlName
{
get
{
return mstrASPWebUserControlName;
}
set
{
if (value  ==  "")
{
 mstrASPWebUserControlName = value;
}
else
{
 mstrASPWebUserControlName = value;
}
}
}
/// <summary>
/// 标签前缀(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
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
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
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
if (strAttributeName  ==  con_ASPWebUserControlId)
{
return mstrASPWebUserControlId;
}
else if (strAttributeName  ==  con_ASPWebUserControlName)
{
return mstrASPWebUserControlName;
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
if (strAttributeName  ==  con_ASPWebUserControlId)
{
mstrASPWebUserControlId = value.ToString();
}
else if (strAttributeName  ==  con_ASPWebUserControlName)
{
mstrASPWebUserControlName = value.ToString();
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
public object this[int intIndex]
{
get
{
if (con_ASPWebUserControlId  ==  AttributeName[intIndex])
{
return mstrASPWebUserControlId;
}
else if (con_ASPWebUserControlName  ==  AttributeName[intIndex])
{
return mstrASPWebUserControlName;
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
if (con_ASPWebUserControlId  ==  AttributeName[intIndex])
{
mstrASPWebUserControlId = value.ToString();
}
else if (con_ASPWebUserControlName  ==  AttributeName[intIndex])
{
mstrASPWebUserControlName = value.ToString();
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
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPWebUserControl()
 {
 }


 /// <summary>
 /// 常量:"ASPWebUserControlId"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ASPWebUserControlId = "ASPWebUserControlId";    //ASPWeb用户控件Id

 /// <summary>
 /// 常量:"ASPWebUserControlName"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ASPWebUserControlName = "ASPWebUserControlName";    //ASPWeb用户控件名

 /// <summary>
 /// 常量:"TagPrefix"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_TagPrefix = "TagPrefix";    //标签前缀

 /// <summary>
 /// 常量:"wucClassName"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_wucClassName = "wucClassName";    //Web用户控件类名

protected string mstrASPWebUserControlId;    //ASPWeb用户控件Id
protected string mstrASPWebUserControlName;    //ASPWeb用户控件名
protected string mstrTagPrefix;    //标签前缀
protected string mstrwucClassName;    //Web用户控件类名
}
}