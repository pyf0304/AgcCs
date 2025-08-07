
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsErrorLevelEN
 表名:ErrorLevel(00050189)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:34:09
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:日志管理(LogManage)
 框架-层名:实体层(CS)(EntityLayer,0001)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Text; 
using System.Collections; 

using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace AGC.Entity
{
 /// <summary>
 /// 表ErrorLevel的关键字(ErrorLevelId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ErrorLevelId_ErrorLevel
{
private int _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public int Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="intErrorLevelId">表关键字</param>
public K_ErrorLevelId_ErrorLevel(int intErrorLevelId)
{
if (IsValid(intErrorLevelId)) Value = intErrorLevelId;
else
{
Value = 0;
}
}
private static bool IsValid(int intErrorLevelId)
{
if (intErrorLevelId == 0) return false;
if (intErrorLevelId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ErrorLevelId_ErrorLevel]类型的对象</returns>
public static implicit operator K_ErrorLevelId_ErrorLevel(int value)
{
return new K_ErrorLevelId_ErrorLevel(value);
}
}
 /// <summary>
 /// 错误等级(ErrorLevel)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsErrorLevelEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ErrorLevel"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ErrorLevelId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 4;
public static string[] _AttributeName = new string[] {"ErrorLevelId", "ErrorLevelName", "ErrorLevelENName", "Memo"};

protected int mintErrorLevelId;    //错误等级Id
protected string mstrErrorLevelName;    //错误等级名
protected string mstrErrorLevelENName;    //错误等级名
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsErrorLevelEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ErrorLevelId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "intErrorLevelId">关键字:错误等级Id</param>
public clsErrorLevelEN(int intErrorLevelId)
 {
 if (intErrorLevelId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mintErrorLevelId = intErrorLevelId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ErrorLevelId");
 }

public static int AttributeCount
{
get
{
return _AttributeCount;
}
}
public override object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  conErrorLevel.ErrorLevelId)
{
return mintErrorLevelId;
}
else if (strAttributeName  ==  conErrorLevel.ErrorLevelName)
{
return mstrErrorLevelName;
}
else if (strAttributeName  ==  conErrorLevel.ErrorLevelENName)
{
return mstrErrorLevelENName;
}
else if (strAttributeName  ==  conErrorLevel.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conErrorLevel.ErrorLevelId)
{
mintErrorLevelId = TransNullToInt(value.ToString());
 AddUpdatedFld(conErrorLevel.ErrorLevelId);
}
else if (strAttributeName  ==  conErrorLevel.ErrorLevelName)
{
mstrErrorLevelName = value.ToString();
 AddUpdatedFld(conErrorLevel.ErrorLevelName);
}
else if (strAttributeName  ==  conErrorLevel.ErrorLevelENName)
{
mstrErrorLevelENName = value.ToString();
 AddUpdatedFld(conErrorLevel.ErrorLevelENName);
}
else if (strAttributeName  ==  conErrorLevel.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conErrorLevel.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conErrorLevel.ErrorLevelId  ==  _AttributeName[intIndex])
{
return mintErrorLevelId;
}
else if (conErrorLevel.ErrorLevelName  ==  _AttributeName[intIndex])
{
return mstrErrorLevelName;
}
else if (conErrorLevel.ErrorLevelENName  ==  _AttributeName[intIndex])
{
return mstrErrorLevelENName;
}
else if (conErrorLevel.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conErrorLevel.ErrorLevelId  ==  _AttributeName[intIndex])
{
mintErrorLevelId = TransNullToInt(value.ToString());
 AddUpdatedFld(conErrorLevel.ErrorLevelId);
}
else if (conErrorLevel.ErrorLevelName  ==  _AttributeName[intIndex])
{
mstrErrorLevelName = value.ToString();
 AddUpdatedFld(conErrorLevel.ErrorLevelName);
}
else if (conErrorLevel.ErrorLevelENName  ==  _AttributeName[intIndex])
{
mstrErrorLevelENName = value.ToString();
 AddUpdatedFld(conErrorLevel.ErrorLevelENName);
}
else if (conErrorLevel.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conErrorLevel.Memo);
}
}
}

/// <summary>
/// 错误等级Id(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int ErrorLevelId
{
get
{
return mintErrorLevelId;
}
set
{
 mintErrorLevelId = value;
//记录修改过的字段
 AddUpdatedFld(conErrorLevel.ErrorLevelId);
}
}
/// <summary>
/// 错误等级名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ErrorLevelName
{
get
{
return mstrErrorLevelName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrErrorLevelName = value;
}
else
{
 mstrErrorLevelName = value;
}
//记录修改过的字段
 AddUpdatedFld(conErrorLevel.ErrorLevelName);
}
}
/// <summary>
/// 错误等级名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ErrorLevelENName
{
get
{
return mstrErrorLevelENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrErrorLevelENName = value;
}
else
{
 mstrErrorLevelENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conErrorLevel.ErrorLevelENName);
}
}
/// <summary>
/// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Memo
{
get
{
return mstrMemo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMemo = value;
}
else
{
 mstrMemo = value;
}
//记录修改过的字段
 AddUpdatedFld(conErrorLevel.Memo);
}
}

/// <summary>
/// 获取关键字Id(keyId)
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetKeyId)
/// </summary>
 public override string _KeyId
 {
 get
 {
  return mintErrorLevelId.ToString();
 }
 }

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrErrorLevelName;
 }
 }
}
 /// <summary>
 /// 错误等级(ErrorLevel)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conErrorLevel
{
public const string _CurrTabName = "ErrorLevel"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ErrorLevelId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"ErrorLevelId", "ErrorLevelName", "ErrorLevelENName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"ErrorLevelId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ErrorLevelId = "ErrorLevelId";    //错误等级Id

 /// <summary>
 /// 常量:"ErrorLevelName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ErrorLevelName = "ErrorLevelName";    //错误等级名

 /// <summary>
 /// 常量:"ErrorLevelENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ErrorLevelENName = "ErrorLevelENName";    //错误等级名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}