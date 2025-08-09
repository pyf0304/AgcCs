
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCodeFunctionEN
 表名:CodeFunction(00050439)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:04:52
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
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
 /// 表CodeFunction的关键字(CodeFuncId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CodeFuncId_CodeFunction
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strCodeFuncId">表关键字</param>
public K_CodeFuncId_CodeFunction(string strCodeFuncId)
{
if (IsValid(strCodeFuncId)) Value = strCodeFuncId;
else
{
Value = null;
}
}
private static bool IsValid(string strCodeFuncId)
{
if (string.IsNullOrEmpty(strCodeFuncId) == true) return false;
if (strCodeFuncId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_CodeFuncId_CodeFunction]类型的对象</returns>
public static implicit operator K_CodeFuncId_CodeFunction(string value)
{
return new K_CodeFuncId_CodeFunction(value);
}
}
 /// <summary>
 /// 代码函数(CodeFunction)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCodeFunctionEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CodeFunction"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "CodeFuncId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 6;
public static string[] _AttributeName = new string[] {"CodeFuncId", "CodeFuncName", "FuncSignature", "UpdDate", "UpdUser", "Memo"};

protected string mstrCodeFuncId;    //代码函数Id
protected string mstrCodeFuncName;    //代码函数名
protected string mstrFuncSignature;    //函数签名
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsCodeFunctionEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CodeFuncId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strCodeFuncId">关键字:代码函数Id</param>
public clsCodeFunctionEN(string strCodeFuncId)
 {
strCodeFuncId = strCodeFuncId.Replace("'", "''");
if (strCodeFuncId.Length > 4)
{
throw new Exception("在表:CodeFunction中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strCodeFuncId)  ==  true)
{
throw new Exception("在表:CodeFunction中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCodeFuncId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrCodeFuncId = strCodeFuncId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CodeFuncId");
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
if (strAttributeName  ==  conCodeFunction.CodeFuncId)
{
return mstrCodeFuncId;
}
else if (strAttributeName  ==  conCodeFunction.CodeFuncName)
{
return mstrCodeFuncName;
}
else if (strAttributeName  ==  conCodeFunction.FuncSignature)
{
return mstrFuncSignature;
}
else if (strAttributeName  ==  conCodeFunction.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conCodeFunction.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conCodeFunction.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conCodeFunction.CodeFuncId)
{
mstrCodeFuncId = value.ToString();
 AddUpdatedFld(conCodeFunction.CodeFuncId);
}
else if (strAttributeName  ==  conCodeFunction.CodeFuncName)
{
mstrCodeFuncName = value.ToString();
 AddUpdatedFld(conCodeFunction.CodeFuncName);
}
else if (strAttributeName  ==  conCodeFunction.FuncSignature)
{
mstrFuncSignature = value.ToString();
 AddUpdatedFld(conCodeFunction.FuncSignature);
}
else if (strAttributeName  ==  conCodeFunction.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCodeFunction.UpdDate);
}
else if (strAttributeName  ==  conCodeFunction.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conCodeFunction.UpdUser);
}
else if (strAttributeName  ==  conCodeFunction.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCodeFunction.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conCodeFunction.CodeFuncId  ==  _AttributeName[intIndex])
{
return mstrCodeFuncId;
}
else if (conCodeFunction.CodeFuncName  ==  _AttributeName[intIndex])
{
return mstrCodeFuncName;
}
else if (conCodeFunction.FuncSignature  ==  _AttributeName[intIndex])
{
return mstrFuncSignature;
}
else if (conCodeFunction.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conCodeFunction.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conCodeFunction.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conCodeFunction.CodeFuncId  ==  _AttributeName[intIndex])
{
mstrCodeFuncId = value.ToString();
 AddUpdatedFld(conCodeFunction.CodeFuncId);
}
else if (conCodeFunction.CodeFuncName  ==  _AttributeName[intIndex])
{
mstrCodeFuncName = value.ToString();
 AddUpdatedFld(conCodeFunction.CodeFuncName);
}
else if (conCodeFunction.FuncSignature  ==  _AttributeName[intIndex])
{
mstrFuncSignature = value.ToString();
 AddUpdatedFld(conCodeFunction.FuncSignature);
}
else if (conCodeFunction.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCodeFunction.UpdDate);
}
else if (conCodeFunction.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conCodeFunction.UpdUser);
}
else if (conCodeFunction.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCodeFunction.Memo);
}
}
}

/// <summary>
/// 代码函数Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeFuncId
{
get
{
return mstrCodeFuncId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeFuncId = value;
}
else
{
 mstrCodeFuncId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCodeFunction.CodeFuncId);
}
}
/// <summary>
/// 代码函数名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeFuncName
{
get
{
return mstrCodeFuncName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeFuncName = value;
}
else
{
 mstrCodeFuncName = value;
}
//记录修改过的字段
 AddUpdatedFld(conCodeFunction.CodeFuncName);
}
}
/// <summary>
/// 函数签名(说明:;字段类型:varchar;字段长度:300;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncSignature
{
get
{
return mstrFuncSignature;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncSignature = value;
}
else
{
 mstrFuncSignature = value;
}
//记录修改过的字段
 AddUpdatedFld(conCodeFunction.FuncSignature);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdDate
{
get
{
return mstrUpdDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdDate = value;
}
else
{
 mstrUpdDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conCodeFunction.UpdDate);
}
}
/// <summary>
/// 修改者(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUser
{
get
{
return mstrUpdUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUser = value;
}
else
{
 mstrUpdUser = value;
}
//记录修改过的字段
 AddUpdatedFld(conCodeFunction.UpdUser);
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
 AddUpdatedFld(conCodeFunction.Memo);
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
  return mstrCodeFuncId;
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
  return mstrCodeFuncName;
 }
 }
}
 /// <summary>
 /// 代码函数(CodeFunction)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCodeFunction
{
public const string _CurrTabName = "CodeFunction"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CodeFuncId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"CodeFuncId", "CodeFuncName", "FuncSignature", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"CodeFuncId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeFuncId = "CodeFuncId";    //代码函数Id

 /// <summary>
 /// 常量:"CodeFuncName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeFuncName = "CodeFuncName";    //代码函数名

 /// <summary>
 /// 常量:"FuncSignature"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncSignature = "FuncSignature";    //函数签名

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改者

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}