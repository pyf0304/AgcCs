
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPModalDialog
 表名:ASPModalDialog(00050443)
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
 /// ASP模态对话框(ASPModalDialog)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPModalDialog : ASPControlEx
{
protected new const int mintAttributeCount = 3;
public new static string[] AttributeName = new string[] {"AspModalDialogId", "AspModalDialogName", "modal_title"};
//以下是属性变量

protected string mstrAspModalDialogId;    //Asp对话框Id
protected string mstrAspModalDialogName;    //Asp对话框名
protected string mstrmodal_title;    //对话框标题


 /// <summary>
 /// 常量:"AspModalDialogId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspModalDialogId = "AspModalDialogId";    //Asp对话框Id

 /// <summary>
 /// 常量:"AspModalDialogName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspModalDialogName = "AspModalDialogName";    //Asp对话框名

 /// <summary>
 /// 常量:"modal_title"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_modal_title = "modal_title";    //对话框标题

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPModalDialog()
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
if (strAttributeName  ==  con_AspModalDialogId)
{
return mstrAspModalDialogId;
}
else if (strAttributeName  ==  con_AspModalDialogName)
{
return mstrAspModalDialogName;
}
else if (strAttributeName  ==  con_modal_title)
{
return mstrmodal_title;
}
return null;
}
set
{
if (strAttributeName  ==  con_AspModalDialogId)
{
mstrAspModalDialogId = value.ToString();
}
else if (strAttributeName  ==  con_AspModalDialogName)
{
mstrAspModalDialogName = value.ToString();
}
else if (strAttributeName  ==  con_modal_title)
{
mstrmodal_title = value.ToString();
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
if (con_AspModalDialogId  ==  AttributeName[intIndex])
{
return mstrAspModalDialogId;
}
else if (con_AspModalDialogName  ==  AttributeName[intIndex])
{
return mstrAspModalDialogName;
}
else if (con_modal_title  ==  AttributeName[intIndex])
{
return mstrmodal_title;
}
return null;
}
set
{
if (con_AspModalDialogId  ==  AttributeName[intIndex])
{
mstrAspModalDialogId = value.ToString();
}
else if (con_AspModalDialogName  ==  AttributeName[intIndex])
{
mstrAspModalDialogName = value.ToString();
}
else if (con_modal_title  ==  AttributeName[intIndex])
{
mstrmodal_title = value.ToString();
}
}
}

/// <summary>
/// Asp对话框Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspModalDialogId
{
get
{
return mstrAspModalDialogId;
}
set
{
if (value  ==  "")
{
 mstrAspModalDialogId = value;
}
else
{
 mstrAspModalDialogId = value;
}
}
}
/// <summary>
/// Asp对话框名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspModalDialogName
{
get
{
return mstrAspModalDialogName;
}
set
{
if (value  ==  "")
{
 mstrAspModalDialogName = value;
}
else
{
 mstrAspModalDialogName = value;
}
}
}
/// <summary>
/// 对话框标题(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string modal_title
{
get
{
return mstrmodal_title;
}
set
{
if (value  ==  "")
{
 mstrmodal_title = value;
}
else
{
 mstrmodal_title = value;
}
}
}
}
}