
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPCompareValidator
 表名:ASPCompareValidator(00050459)
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
 /// ASP校验(ASPCompareValidator)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPCompareValidator : ASPControlEx
{
protected new const int mintAttributeCount = 6;
public new static string[] AttributeName = new string[] {"AspCompareValidatorId", "AspCompareValidatorName", "ControlToValidate", "ErrorMessage", "EnableClientScript", "Operator"};
//以下是属性变量

protected string mstrAspCompareValidatorId;    //Asp校验Id
protected string mstrAspCompareValidatorName;    //Asp校验名称
protected string mstrControlToValidate;    //校验控件
protected string mstrErrorMessage;    //错误信息
protected string mstrEnableClientScript;    //可以使用客户端脚本
protected string mstrOperator;    //操作


 /// <summary>
 /// 常量:"AspCompareValidatorId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspCompareValidatorId = "AspCompareValidatorId";    //Asp校验Id

 /// <summary>
 /// 常量:"AspCompareValidatorName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspCompareValidatorName = "AspCompareValidatorName";    //Asp校验名称

 /// <summary>
 /// 常量:"ControlToValidate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ControlToValidate = "ControlToValidate";    //校验控件

 /// <summary>
 /// 常量:"ErrorMessage"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ErrorMessage = "ErrorMessage";    //错误信息

 /// <summary>
 /// 常量:"EnableClientScript"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_EnableClientScript = "EnableClientScript";    //可以使用客户端脚本

 /// <summary>
 /// 常量:"Operator"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Operator = "Operator";    //操作

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPCompareValidator()
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
if (strAttributeName  ==  con_AspCompareValidatorId)
{
return mstrAspCompareValidatorId;
}
else if (strAttributeName  ==  con_AspCompareValidatorName)
{
return mstrAspCompareValidatorName;
}
else if (strAttributeName  ==  con_ControlToValidate)
{
return mstrControlToValidate;
}
else if (strAttributeName  ==  con_ErrorMessage)
{
return mstrErrorMessage;
}
else if (strAttributeName  ==  con_EnableClientScript)
{
return mstrEnableClientScript;
}
else if (strAttributeName  ==  con_Operator)
{
return mstrOperator;
}
return null;
}
set
{
if (strAttributeName  ==  con_AspCompareValidatorId)
{
mstrAspCompareValidatorId = value.ToString();
}
else if (strAttributeName  ==  con_AspCompareValidatorName)
{
mstrAspCompareValidatorName = value.ToString();
}
else if (strAttributeName  ==  con_ControlToValidate)
{
mstrControlToValidate = value.ToString();
}
else if (strAttributeName  ==  con_ErrorMessage)
{
mstrErrorMessage = value.ToString();
}
else if (strAttributeName  ==  con_EnableClientScript)
{
mstrEnableClientScript = value.ToString();
}
else if (strAttributeName  ==  con_Operator)
{
mstrOperator = value.ToString();
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
if (con_AspCompareValidatorId  ==  AttributeName[intIndex])
{
return mstrAspCompareValidatorId;
}
else if (con_AspCompareValidatorName  ==  AttributeName[intIndex])
{
return mstrAspCompareValidatorName;
}
else if (con_ControlToValidate  ==  AttributeName[intIndex])
{
return mstrControlToValidate;
}
else if (con_ErrorMessage  ==  AttributeName[intIndex])
{
return mstrErrorMessage;
}
else if (con_EnableClientScript  ==  AttributeName[intIndex])
{
return mstrEnableClientScript;
}
else if (con_Operator  ==  AttributeName[intIndex])
{
return mstrOperator;
}
return null;
}
set
{
if (con_AspCompareValidatorId  ==  AttributeName[intIndex])
{
mstrAspCompareValidatorId = value.ToString();
}
else if (con_AspCompareValidatorName  ==  AttributeName[intIndex])
{
mstrAspCompareValidatorName = value.ToString();
}
else if (con_ControlToValidate  ==  AttributeName[intIndex])
{
mstrControlToValidate = value.ToString();
}
else if (con_ErrorMessage  ==  AttributeName[intIndex])
{
mstrErrorMessage = value.ToString();
}
else if (con_EnableClientScript  ==  AttributeName[intIndex])
{
mstrEnableClientScript = value.ToString();
}
else if (con_Operator  ==  AttributeName[intIndex])
{
mstrOperator = value.ToString();
}
}
}

/// <summary>
/// Asp校验Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspCompareValidatorId
{
get
{
return mstrAspCompareValidatorId;
}
set
{
if (value  ==  "")
{
 mstrAspCompareValidatorId = value;
}
else
{
 mstrAspCompareValidatorId = value;
}
}
}
/// <summary>
/// Asp校验名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspCompareValidatorName
{
get
{
return mstrAspCompareValidatorName;
}
set
{
if (value  ==  "")
{
 mstrAspCompareValidatorName = value;
}
else
{
 mstrAspCompareValidatorName = value;
}
}
}
/// <summary>
/// 校验控件(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string ControlToValidate
{
get
{
return mstrControlToValidate;
}
set
{
if (value  ==  "")
{
 mstrControlToValidate = value;
}
else
{
 mstrControlToValidate = value;
}
}
}
/// <summary>
/// 错误信息(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string ErrorMessage
{
get
{
return mstrErrorMessage;
}
set
{
if (value  ==  "")
{
 mstrErrorMessage = value;
}
else
{
 mstrErrorMessage = value;
}
}
}
/// <summary>
/// 可以使用客户端脚本(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string EnableClientScript
{
get
{
return mstrEnableClientScript;
}
set
{
if (value  ==  "")
{
 mstrEnableClientScript = value;
}
else
{
 mstrEnableClientScript = value;
}
}
}
/// <summary>
/// 操作(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string Operator
{
get
{
return mstrOperator;
}
set
{
if (value  ==  "")
{
 mstrOperator = value;
}
else
{
 mstrOperator = value;
}
}
}
}
}