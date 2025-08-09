
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTabFunctionPropEN
 表名:vTabFunctionProp(00050524)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:12:16
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
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
 /// 表vTabFunctionProp的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vTabFunctionProp
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngmId">表关键字</param>
public K_mId_vTabFunctionProp(long lngmId)
{
if (IsValid(lngmId)) Value = lngmId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngmId)
{
if (lngmId == 0) return false;
if (lngmId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_mId_vTabFunctionProp]类型的对象</returns>
public static implicit operator K_mId_vTabFunctionProp(long value)
{
return new K_mId_vTabFunctionProp(value);
}
}
 /// <summary>
 /// vTabFunctionProp(vTabFunctionProp)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvTabFunctionPropEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vTabFunctionProp"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 24;
public static string[] _AttributeName = new string[] {"mId", "TabId", "TabName", "TabCnName", "FunctionTemplateId", "FunctionTemplateName", "CodeTypeId", "CodeTypeName", "CodeTypeENName", "FuncId4GC", "FuncName", "FuncId4Code", "FuncName4Code", "FuncCHName4Code", "ProgLangTypeId", "ProgLangTypeName", "MethodModifierId", "MethodModifierName", "IsForAllTemplate", "PrjId", "UpdDate", "UpdUser", "Memo", "Order4Func"};

protected long mlngmId;    //mId
protected string mstrTabId;    //表ID
protected string mstrTabName;    //表名
protected string mstrTabCnName;    //表中文名
protected string mstrFunctionTemplateId;    //函数模板Id
protected string mstrFunctionTemplateName;    //函数模板名
protected string mstrCodeTypeId;    //代码类型Id
protected string mstrCodeTypeName;    //代码类型名
protected string mstrCodeTypeENName;    //代码类型英文名
protected string mstrFuncId4GC;    //函数ID
protected string mstrFuncName;    //函数名
protected string mstrFuncId4Code;    //函数Id4Code
protected string mstrFuncName4Code;    //函数名4Code
protected string mstrFuncCHName4Code;    //函数中文名4Code
protected string mstrProgLangTypeId;    //编程语言类型Id
protected string mstrProgLangTypeName;    //编程语言类型名
protected string mstrMethodModifierId;    //函数修饰语Id
protected string mstrMethodModifierName;    //函数修饰语名称
protected bool mbolIsForAllTemplate;    //是否针对所有模板
protected string mstrPrjId;    //工程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明
protected int? mintOrder4Func;    //Order4函数

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvTabFunctionPropEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:mId</param>
public clsvTabFunctionPropEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
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
if (strAttributeName  ==  convTabFunctionProp.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convTabFunctionProp.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  convTabFunctionProp.TabName)
{
return mstrTabName;
}
else if (strAttributeName  ==  convTabFunctionProp.TabCnName)
{
return mstrTabCnName;
}
else if (strAttributeName  ==  convTabFunctionProp.FunctionTemplateId)
{
return mstrFunctionTemplateId;
}
else if (strAttributeName  ==  convTabFunctionProp.FunctionTemplateName)
{
return mstrFunctionTemplateName;
}
else if (strAttributeName  ==  convTabFunctionProp.CodeTypeId)
{
return mstrCodeTypeId;
}
else if (strAttributeName  ==  convTabFunctionProp.CodeTypeName)
{
return mstrCodeTypeName;
}
else if (strAttributeName  ==  convTabFunctionProp.CodeTypeENName)
{
return mstrCodeTypeENName;
}
else if (strAttributeName  ==  convTabFunctionProp.FuncId4GC)
{
return mstrFuncId4GC;
}
else if (strAttributeName  ==  convTabFunctionProp.FuncName)
{
return mstrFuncName;
}
else if (strAttributeName  ==  convTabFunctionProp.FuncId4Code)
{
return mstrFuncId4Code;
}
else if (strAttributeName  ==  convTabFunctionProp.FuncName4Code)
{
return mstrFuncName4Code;
}
else if (strAttributeName  ==  convTabFunctionProp.FuncCHName4Code)
{
return mstrFuncCHName4Code;
}
else if (strAttributeName  ==  convTabFunctionProp.ProgLangTypeId)
{
return mstrProgLangTypeId;
}
else if (strAttributeName  ==  convTabFunctionProp.ProgLangTypeName)
{
return mstrProgLangTypeName;
}
else if (strAttributeName  ==  convTabFunctionProp.MethodModifierId)
{
return mstrMethodModifierId;
}
else if (strAttributeName  ==  convTabFunctionProp.MethodModifierName)
{
return mstrMethodModifierName;
}
else if (strAttributeName  ==  convTabFunctionProp.IsForAllTemplate)
{
return mbolIsForAllTemplate;
}
else if (strAttributeName  ==  convTabFunctionProp.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convTabFunctionProp.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convTabFunctionProp.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convTabFunctionProp.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convTabFunctionProp.Order4Func)
{
return mintOrder4Func;
}
return null;
}
set
{
if (strAttributeName  ==  convTabFunctionProp.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convTabFunctionProp.mId);
}
else if (strAttributeName  ==  convTabFunctionProp.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(convTabFunctionProp.TabId);
}
else if (strAttributeName  ==  convTabFunctionProp.TabName)
{
mstrTabName = value.ToString();
 AddUpdatedFld(convTabFunctionProp.TabName);
}
else if (strAttributeName  ==  convTabFunctionProp.TabCnName)
{
mstrTabCnName = value.ToString();
 AddUpdatedFld(convTabFunctionProp.TabCnName);
}
else if (strAttributeName  ==  convTabFunctionProp.FunctionTemplateId)
{
mstrFunctionTemplateId = value.ToString();
 AddUpdatedFld(convTabFunctionProp.FunctionTemplateId);
}
else if (strAttributeName  ==  convTabFunctionProp.FunctionTemplateName)
{
mstrFunctionTemplateName = value.ToString();
 AddUpdatedFld(convTabFunctionProp.FunctionTemplateName);
}
else if (strAttributeName  ==  convTabFunctionProp.CodeTypeId)
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(convTabFunctionProp.CodeTypeId);
}
else if (strAttributeName  ==  convTabFunctionProp.CodeTypeName)
{
mstrCodeTypeName = value.ToString();
 AddUpdatedFld(convTabFunctionProp.CodeTypeName);
}
else if (strAttributeName  ==  convTabFunctionProp.CodeTypeENName)
{
mstrCodeTypeENName = value.ToString();
 AddUpdatedFld(convTabFunctionProp.CodeTypeENName);
}
else if (strAttributeName  ==  convTabFunctionProp.FuncId4GC)
{
mstrFuncId4GC = value.ToString();
 AddUpdatedFld(convTabFunctionProp.FuncId4GC);
}
else if (strAttributeName  ==  convTabFunctionProp.FuncName)
{
mstrFuncName = value.ToString();
 AddUpdatedFld(convTabFunctionProp.FuncName);
}
else if (strAttributeName  ==  convTabFunctionProp.FuncId4Code)
{
mstrFuncId4Code = value.ToString();
 AddUpdatedFld(convTabFunctionProp.FuncId4Code);
}
else if (strAttributeName  ==  convTabFunctionProp.FuncName4Code)
{
mstrFuncName4Code = value.ToString();
 AddUpdatedFld(convTabFunctionProp.FuncName4Code);
}
else if (strAttributeName  ==  convTabFunctionProp.FuncCHName4Code)
{
mstrFuncCHName4Code = value.ToString();
 AddUpdatedFld(convTabFunctionProp.FuncCHName4Code);
}
else if (strAttributeName  ==  convTabFunctionProp.ProgLangTypeId)
{
mstrProgLangTypeId = value.ToString();
 AddUpdatedFld(convTabFunctionProp.ProgLangTypeId);
}
else if (strAttributeName  ==  convTabFunctionProp.ProgLangTypeName)
{
mstrProgLangTypeName = value.ToString();
 AddUpdatedFld(convTabFunctionProp.ProgLangTypeName);
}
else if (strAttributeName  ==  convTabFunctionProp.MethodModifierId)
{
mstrMethodModifierId = value.ToString();
 AddUpdatedFld(convTabFunctionProp.MethodModifierId);
}
else if (strAttributeName  ==  convTabFunctionProp.MethodModifierName)
{
mstrMethodModifierName = value.ToString();
 AddUpdatedFld(convTabFunctionProp.MethodModifierName);
}
else if (strAttributeName  ==  convTabFunctionProp.IsForAllTemplate)
{
mbolIsForAllTemplate = TransNullToBool(value.ToString());
 AddUpdatedFld(convTabFunctionProp.IsForAllTemplate);
}
else if (strAttributeName  ==  convTabFunctionProp.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convTabFunctionProp.PrjId);
}
else if (strAttributeName  ==  convTabFunctionProp.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convTabFunctionProp.UpdDate);
}
else if (strAttributeName  ==  convTabFunctionProp.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convTabFunctionProp.UpdUser);
}
else if (strAttributeName  ==  convTabFunctionProp.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convTabFunctionProp.Memo);
}
else if (strAttributeName  ==  convTabFunctionProp.Order4Func)
{
mintOrder4Func = TransNullToInt(value.ToString());
 AddUpdatedFld(convTabFunctionProp.Order4Func);
}
}
}
public object this[int intIndex]
{
get
{
if (convTabFunctionProp.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (convTabFunctionProp.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (convTabFunctionProp.TabName  ==  _AttributeName[intIndex])
{
return mstrTabName;
}
else if (convTabFunctionProp.TabCnName  ==  _AttributeName[intIndex])
{
return mstrTabCnName;
}
else if (convTabFunctionProp.FunctionTemplateId  ==  _AttributeName[intIndex])
{
return mstrFunctionTemplateId;
}
else if (convTabFunctionProp.FunctionTemplateName  ==  _AttributeName[intIndex])
{
return mstrFunctionTemplateName;
}
else if (convTabFunctionProp.CodeTypeId  ==  _AttributeName[intIndex])
{
return mstrCodeTypeId;
}
else if (convTabFunctionProp.CodeTypeName  ==  _AttributeName[intIndex])
{
return mstrCodeTypeName;
}
else if (convTabFunctionProp.CodeTypeENName  ==  _AttributeName[intIndex])
{
return mstrCodeTypeENName;
}
else if (convTabFunctionProp.FuncId4GC  ==  _AttributeName[intIndex])
{
return mstrFuncId4GC;
}
else if (convTabFunctionProp.FuncName  ==  _AttributeName[intIndex])
{
return mstrFuncName;
}
else if (convTabFunctionProp.FuncId4Code  ==  _AttributeName[intIndex])
{
return mstrFuncId4Code;
}
else if (convTabFunctionProp.FuncName4Code  ==  _AttributeName[intIndex])
{
return mstrFuncName4Code;
}
else if (convTabFunctionProp.FuncCHName4Code  ==  _AttributeName[intIndex])
{
return mstrFuncCHName4Code;
}
else if (convTabFunctionProp.ProgLangTypeId  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeId;
}
else if (convTabFunctionProp.ProgLangTypeName  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeName;
}
else if (convTabFunctionProp.MethodModifierId  ==  _AttributeName[intIndex])
{
return mstrMethodModifierId;
}
else if (convTabFunctionProp.MethodModifierName  ==  _AttributeName[intIndex])
{
return mstrMethodModifierName;
}
else if (convTabFunctionProp.IsForAllTemplate  ==  _AttributeName[intIndex])
{
return mbolIsForAllTemplate;
}
else if (convTabFunctionProp.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convTabFunctionProp.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convTabFunctionProp.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convTabFunctionProp.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (convTabFunctionProp.Order4Func  ==  _AttributeName[intIndex])
{
return mintOrder4Func;
}
return null;
}
set
{
if (convTabFunctionProp.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convTabFunctionProp.mId);
}
else if (convTabFunctionProp.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(convTabFunctionProp.TabId);
}
else if (convTabFunctionProp.TabName  ==  _AttributeName[intIndex])
{
mstrTabName = value.ToString();
 AddUpdatedFld(convTabFunctionProp.TabName);
}
else if (convTabFunctionProp.TabCnName  ==  _AttributeName[intIndex])
{
mstrTabCnName = value.ToString();
 AddUpdatedFld(convTabFunctionProp.TabCnName);
}
else if (convTabFunctionProp.FunctionTemplateId  ==  _AttributeName[intIndex])
{
mstrFunctionTemplateId = value.ToString();
 AddUpdatedFld(convTabFunctionProp.FunctionTemplateId);
}
else if (convTabFunctionProp.FunctionTemplateName  ==  _AttributeName[intIndex])
{
mstrFunctionTemplateName = value.ToString();
 AddUpdatedFld(convTabFunctionProp.FunctionTemplateName);
}
else if (convTabFunctionProp.CodeTypeId  ==  _AttributeName[intIndex])
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(convTabFunctionProp.CodeTypeId);
}
else if (convTabFunctionProp.CodeTypeName  ==  _AttributeName[intIndex])
{
mstrCodeTypeName = value.ToString();
 AddUpdatedFld(convTabFunctionProp.CodeTypeName);
}
else if (convTabFunctionProp.CodeTypeENName  ==  _AttributeName[intIndex])
{
mstrCodeTypeENName = value.ToString();
 AddUpdatedFld(convTabFunctionProp.CodeTypeENName);
}
else if (convTabFunctionProp.FuncId4GC  ==  _AttributeName[intIndex])
{
mstrFuncId4GC = value.ToString();
 AddUpdatedFld(convTabFunctionProp.FuncId4GC);
}
else if (convTabFunctionProp.FuncName  ==  _AttributeName[intIndex])
{
mstrFuncName = value.ToString();
 AddUpdatedFld(convTabFunctionProp.FuncName);
}
else if (convTabFunctionProp.FuncId4Code  ==  _AttributeName[intIndex])
{
mstrFuncId4Code = value.ToString();
 AddUpdatedFld(convTabFunctionProp.FuncId4Code);
}
else if (convTabFunctionProp.FuncName4Code  ==  _AttributeName[intIndex])
{
mstrFuncName4Code = value.ToString();
 AddUpdatedFld(convTabFunctionProp.FuncName4Code);
}
else if (convTabFunctionProp.FuncCHName4Code  ==  _AttributeName[intIndex])
{
mstrFuncCHName4Code = value.ToString();
 AddUpdatedFld(convTabFunctionProp.FuncCHName4Code);
}
else if (convTabFunctionProp.ProgLangTypeId  ==  _AttributeName[intIndex])
{
mstrProgLangTypeId = value.ToString();
 AddUpdatedFld(convTabFunctionProp.ProgLangTypeId);
}
else if (convTabFunctionProp.ProgLangTypeName  ==  _AttributeName[intIndex])
{
mstrProgLangTypeName = value.ToString();
 AddUpdatedFld(convTabFunctionProp.ProgLangTypeName);
}
else if (convTabFunctionProp.MethodModifierId  ==  _AttributeName[intIndex])
{
mstrMethodModifierId = value.ToString();
 AddUpdatedFld(convTabFunctionProp.MethodModifierId);
}
else if (convTabFunctionProp.MethodModifierName  ==  _AttributeName[intIndex])
{
mstrMethodModifierName = value.ToString();
 AddUpdatedFld(convTabFunctionProp.MethodModifierName);
}
else if (convTabFunctionProp.IsForAllTemplate  ==  _AttributeName[intIndex])
{
mbolIsForAllTemplate = TransNullToBool(value.ToString());
 AddUpdatedFld(convTabFunctionProp.IsForAllTemplate);
}
else if (convTabFunctionProp.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convTabFunctionProp.PrjId);
}
else if (convTabFunctionProp.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convTabFunctionProp.UpdDate);
}
else if (convTabFunctionProp.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convTabFunctionProp.UpdUser);
}
else if (convTabFunctionProp.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convTabFunctionProp.Memo);
}
else if (convTabFunctionProp.Order4Func  ==  _AttributeName[intIndex])
{
mintOrder4Func = TransNullToInt(value.ToString());
 AddUpdatedFld(convTabFunctionProp.Order4Func);
}
}
}

/// <summary>
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long mId
{
get
{
return mlngmId;
}
set
{
 mlngmId = value;
//记录修改过的字段
 AddUpdatedFld(convTabFunctionProp.mId);
}
}
/// <summary>
/// 表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabId
{
get
{
return mstrTabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabId = value;
}
else
{
 mstrTabId = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabFunctionProp.TabId);
}
}
/// <summary>
/// 表名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabName
{
get
{
return mstrTabName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabName = value;
}
else
{
 mstrTabName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabFunctionProp.TabName);
}
}
/// <summary>
/// 表中文名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabCnName
{
get
{
return mstrTabCnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabCnName = value;
}
else
{
 mstrTabCnName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabFunctionProp.TabCnName);
}
}
/// <summary>
/// 函数模板Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FunctionTemplateId
{
get
{
return mstrFunctionTemplateId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFunctionTemplateId = value;
}
else
{
 mstrFunctionTemplateId = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabFunctionProp.FunctionTemplateId);
}
}
/// <summary>
/// 函数模板名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FunctionTemplateName
{
get
{
return mstrFunctionTemplateName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFunctionTemplateName = value;
}
else
{
 mstrFunctionTemplateName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabFunctionProp.FunctionTemplateName);
}
}
/// <summary>
/// 代码类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTypeId
{
get
{
return mstrCodeTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTypeId = value;
}
else
{
 mstrCodeTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabFunctionProp.CodeTypeId);
}
}
/// <summary>
/// 代码类型名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTypeName
{
get
{
return mstrCodeTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTypeName = value;
}
else
{
 mstrCodeTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabFunctionProp.CodeTypeName);
}
}
/// <summary>
/// 代码类型英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTypeENName
{
get
{
return mstrCodeTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTypeENName = value;
}
else
{
 mstrCodeTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabFunctionProp.CodeTypeENName);
}
}
/// <summary>
/// 函数ID(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncId4GC
{
get
{
return mstrFuncId4GC;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncId4GC = value;
}
else
{
 mstrFuncId4GC = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabFunctionProp.FuncId4GC);
}
}
/// <summary>
/// 函数名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncName
{
get
{
return mstrFuncName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncName = value;
}
else
{
 mstrFuncName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabFunctionProp.FuncName);
}
}
/// <summary>
/// 函数Id4Code(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncId4Code
{
get
{
return mstrFuncId4Code;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncId4Code = value;
}
else
{
 mstrFuncId4Code = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabFunctionProp.FuncId4Code);
}
}
/// <summary>
/// 函数名4Code(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncName4Code
{
get
{
return mstrFuncName4Code;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncName4Code = value;
}
else
{
 mstrFuncName4Code = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabFunctionProp.FuncName4Code);
}
}
/// <summary>
/// 函数中文名4Code(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncCHName4Code
{
get
{
return mstrFuncCHName4Code;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncCHName4Code = value;
}
else
{
 mstrFuncCHName4Code = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabFunctionProp.FuncCHName4Code);
}
}
/// <summary>
/// 编程语言类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLangTypeId
{
get
{
return mstrProgLangTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLangTypeId = value;
}
else
{
 mstrProgLangTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabFunctionProp.ProgLangTypeId);
}
}
/// <summary>
/// 编程语言类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLangTypeName
{
get
{
return mstrProgLangTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLangTypeName = value;
}
else
{
 mstrProgLangTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabFunctionProp.ProgLangTypeName);
}
}
/// <summary>
/// 函数修饰语Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MethodModifierId
{
get
{
return mstrMethodModifierId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMethodModifierId = value;
}
else
{
 mstrMethodModifierId = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabFunctionProp.MethodModifierId);
}
}
/// <summary>
/// 函数修饰语名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MethodModifierName
{
get
{
return mstrMethodModifierName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMethodModifierName = value;
}
else
{
 mstrMethodModifierName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabFunctionProp.MethodModifierName);
}
}
/// <summary>
/// 是否针对所有模板(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsForAllTemplate
{
get
{
return mbolIsForAllTemplate;
}
set
{
 mbolIsForAllTemplate = value;
//记录修改过的字段
 AddUpdatedFld(convTabFunctionProp.IsForAllTemplate);
}
}
/// <summary>
/// 工程Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjId
{
get
{
return mstrPrjId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjId = value;
}
else
{
 mstrPrjId = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabFunctionProp.PrjId);
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
 AddUpdatedFld(convTabFunctionProp.UpdDate);
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
 AddUpdatedFld(convTabFunctionProp.UpdUser);
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
 AddUpdatedFld(convTabFunctionProp.Memo);
}
}
/// <summary>
/// Order4函数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? Order4Func
{
get
{
return mintOrder4Func;
}
set
{
 mintOrder4Func = value;
//记录修改过的字段
 AddUpdatedFld(convTabFunctionProp.Order4Func);
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
  return mlngmId.ToString();
 }
 }
}
 /// <summary>
 /// vTabFunctionProp(vTabFunctionProp)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convTabFunctionProp
{
public const string _CurrTabName = "vTabFunctionProp"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "TabId", "TabName", "TabCnName", "FunctionTemplateId", "FunctionTemplateName", "CodeTypeId", "CodeTypeName", "CodeTypeENName", "FuncId4GC", "FuncName", "FuncId4Code", "FuncName4Code", "FuncCHName4Code", "ProgLangTypeId", "ProgLangTypeName", "MethodModifierId", "MethodModifierName", "IsForAllTemplate", "PrjId", "UpdDate", "UpdUser", "Memo", "Order4Func"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"TabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabId = "TabId";    //表ID

 /// <summary>
 /// 常量:"TabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabName = "TabName";    //表名

 /// <summary>
 /// 常量:"TabCnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabCnName = "TabCnName";    //表中文名

 /// <summary>
 /// 常量:"FunctionTemplateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FunctionTemplateId = "FunctionTemplateId";    //函数模板Id

 /// <summary>
 /// 常量:"FunctionTemplateName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FunctionTemplateName = "FunctionTemplateName";    //函数模板名

 /// <summary>
 /// 常量:"CodeTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTypeId = "CodeTypeId";    //代码类型Id

 /// <summary>
 /// 常量:"CodeTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTypeName = "CodeTypeName";    //代码类型名

 /// <summary>
 /// 常量:"CodeTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTypeENName = "CodeTypeENName";    //代码类型英文名

 /// <summary>
 /// 常量:"FuncId4GC"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncId4GC = "FuncId4GC";    //函数ID

 /// <summary>
 /// 常量:"FuncName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncName = "FuncName";    //函数名

 /// <summary>
 /// 常量:"FuncId4Code"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncId4Code = "FuncId4Code";    //函数Id4Code

 /// <summary>
 /// 常量:"FuncName4Code"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncName4Code = "FuncName4Code";    //函数名4Code

 /// <summary>
 /// 常量:"FuncCHName4Code"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncCHName4Code = "FuncCHName4Code";    //函数中文名4Code

 /// <summary>
 /// 常量:"ProgLangTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeId = "ProgLangTypeId";    //编程语言类型Id

 /// <summary>
 /// 常量:"ProgLangTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeName = "ProgLangTypeName";    //编程语言类型名

 /// <summary>
 /// 常量:"MethodModifierId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MethodModifierId = "MethodModifierId";    //函数修饰语Id

 /// <summary>
 /// 常量:"MethodModifierName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MethodModifierName = "MethodModifierName";    //函数修饰语名称

 /// <summary>
 /// 常量:"IsForAllTemplate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsForAllTemplate = "IsForAllTemplate";    //是否针对所有模板

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

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

 /// <summary>
 /// 常量:"Order4Func"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Order4Func = "Order4Func";    //Order4函数
}

}