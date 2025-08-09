
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTabFunctionPropEN
 表名:TabFunctionProp(00050522)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:01:40
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
 /// 表TabFunctionProp的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_TabFunctionProp
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
public K_mId_TabFunctionProp(long lngmId)
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
 /// <returns>返回:[K_mId_TabFunctionProp]类型的对象</returns>
public static implicit operator K_mId_TabFunctionProp(long value)
{
return new K_mId_TabFunctionProp(value);
}
}
 /// <summary>
 /// 表函数属性(TabFunctionProp)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsTabFunctionPropEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "TabFunctionProp"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 12;
public static string[] _AttributeName = new string[] {"mId", "TabId", "FunctionTemplateId", "CodeTypeId", "FuncId4GC", "MethodModifierId", "IsForAllTemplate", "OrderNum", "PrjId", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrTabId;    //表ID
protected string mstrFunctionTemplateId;    //函数模板Id
protected string mstrCodeTypeId;    //代码类型Id
protected string mstrFuncId4GC;    //函数ID
protected string mstrMethodModifierId;    //函数修饰语Id
protected bool mbolIsForAllTemplate;    //是否针对所有模板
protected int mintOrderNum;    //序号
protected string mstrPrjId;    //工程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsTabFunctionPropEN()
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
public clsTabFunctionPropEN(long lngmId)
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
if (strAttributeName  ==  conTabFunctionProp.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conTabFunctionProp.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  conTabFunctionProp.FunctionTemplateId)
{
return mstrFunctionTemplateId;
}
else if (strAttributeName  ==  conTabFunctionProp.CodeTypeId)
{
return mstrCodeTypeId;
}
else if (strAttributeName  ==  conTabFunctionProp.FuncId4GC)
{
return mstrFuncId4GC;
}
else if (strAttributeName  ==  conTabFunctionProp.MethodModifierId)
{
return mstrMethodModifierId;
}
else if (strAttributeName  ==  conTabFunctionProp.IsForAllTemplate)
{
return mbolIsForAllTemplate;
}
else if (strAttributeName  ==  conTabFunctionProp.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conTabFunctionProp.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conTabFunctionProp.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conTabFunctionProp.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conTabFunctionProp.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conTabFunctionProp.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conTabFunctionProp.mId);
}
else if (strAttributeName  ==  conTabFunctionProp.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(conTabFunctionProp.TabId);
}
else if (strAttributeName  ==  conTabFunctionProp.FunctionTemplateId)
{
mstrFunctionTemplateId = value.ToString();
 AddUpdatedFld(conTabFunctionProp.FunctionTemplateId);
}
else if (strAttributeName  ==  conTabFunctionProp.CodeTypeId)
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(conTabFunctionProp.CodeTypeId);
}
else if (strAttributeName  ==  conTabFunctionProp.FuncId4GC)
{
mstrFuncId4GC = value.ToString();
 AddUpdatedFld(conTabFunctionProp.FuncId4GC);
}
else if (strAttributeName  ==  conTabFunctionProp.MethodModifierId)
{
mstrMethodModifierId = value.ToString();
 AddUpdatedFld(conTabFunctionProp.MethodModifierId);
}
else if (strAttributeName  ==  conTabFunctionProp.IsForAllTemplate)
{
mbolIsForAllTemplate = TransNullToBool(value.ToString());
 AddUpdatedFld(conTabFunctionProp.IsForAllTemplate);
}
else if (strAttributeName  ==  conTabFunctionProp.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conTabFunctionProp.OrderNum);
}
else if (strAttributeName  ==  conTabFunctionProp.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conTabFunctionProp.PrjId);
}
else if (strAttributeName  ==  conTabFunctionProp.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conTabFunctionProp.UpdDate);
}
else if (strAttributeName  ==  conTabFunctionProp.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conTabFunctionProp.UpdUser);
}
else if (strAttributeName  ==  conTabFunctionProp.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTabFunctionProp.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conTabFunctionProp.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (conTabFunctionProp.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (conTabFunctionProp.FunctionTemplateId  ==  _AttributeName[intIndex])
{
return mstrFunctionTemplateId;
}
else if (conTabFunctionProp.CodeTypeId  ==  _AttributeName[intIndex])
{
return mstrCodeTypeId;
}
else if (conTabFunctionProp.FuncId4GC  ==  _AttributeName[intIndex])
{
return mstrFuncId4GC;
}
else if (conTabFunctionProp.MethodModifierId  ==  _AttributeName[intIndex])
{
return mstrMethodModifierId;
}
else if (conTabFunctionProp.IsForAllTemplate  ==  _AttributeName[intIndex])
{
return mbolIsForAllTemplate;
}
else if (conTabFunctionProp.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conTabFunctionProp.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conTabFunctionProp.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conTabFunctionProp.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conTabFunctionProp.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conTabFunctionProp.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conTabFunctionProp.mId);
}
else if (conTabFunctionProp.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(conTabFunctionProp.TabId);
}
else if (conTabFunctionProp.FunctionTemplateId  ==  _AttributeName[intIndex])
{
mstrFunctionTemplateId = value.ToString();
 AddUpdatedFld(conTabFunctionProp.FunctionTemplateId);
}
else if (conTabFunctionProp.CodeTypeId  ==  _AttributeName[intIndex])
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(conTabFunctionProp.CodeTypeId);
}
else if (conTabFunctionProp.FuncId4GC  ==  _AttributeName[intIndex])
{
mstrFuncId4GC = value.ToString();
 AddUpdatedFld(conTabFunctionProp.FuncId4GC);
}
else if (conTabFunctionProp.MethodModifierId  ==  _AttributeName[intIndex])
{
mstrMethodModifierId = value.ToString();
 AddUpdatedFld(conTabFunctionProp.MethodModifierId);
}
else if (conTabFunctionProp.IsForAllTemplate  ==  _AttributeName[intIndex])
{
mbolIsForAllTemplate = TransNullToBool(value.ToString());
 AddUpdatedFld(conTabFunctionProp.IsForAllTemplate);
}
else if (conTabFunctionProp.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conTabFunctionProp.OrderNum);
}
else if (conTabFunctionProp.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conTabFunctionProp.PrjId);
}
else if (conTabFunctionProp.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conTabFunctionProp.UpdDate);
}
else if (conTabFunctionProp.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conTabFunctionProp.UpdUser);
}
else if (conTabFunctionProp.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTabFunctionProp.Memo);
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
 AddUpdatedFld(conTabFunctionProp.mId);
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
 AddUpdatedFld(conTabFunctionProp.TabId);
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
 AddUpdatedFld(conTabFunctionProp.FunctionTemplateId);
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
 AddUpdatedFld(conTabFunctionProp.CodeTypeId);
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
 AddUpdatedFld(conTabFunctionProp.FuncId4GC);
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
 AddUpdatedFld(conTabFunctionProp.MethodModifierId);
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
 AddUpdatedFld(conTabFunctionProp.IsForAllTemplate);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(conTabFunctionProp.OrderNum);
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
 AddUpdatedFld(conTabFunctionProp.PrjId);
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
 AddUpdatedFld(conTabFunctionProp.UpdDate);
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
 AddUpdatedFld(conTabFunctionProp.UpdUser);
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
 AddUpdatedFld(conTabFunctionProp.Memo);
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
 /// 表函数属性(TabFunctionProp)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conTabFunctionProp
{
public const string _CurrTabName = "TabFunctionProp"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "TabId", "FunctionTemplateId", "CodeTypeId", "FuncId4GC", "MethodModifierId", "IsForAllTemplate", "OrderNum", "PrjId", "UpdDate", "UpdUser", "Memo"};
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
 /// 常量:"FunctionTemplateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FunctionTemplateId = "FunctionTemplateId";    //函数模板Id

 /// <summary>
 /// 常量:"CodeTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTypeId = "CodeTypeId";    //代码类型Id

 /// <summary>
 /// 常量:"FuncId4GC"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncId4GC = "FuncId4GC";    //函数ID

 /// <summary>
 /// 常量:"MethodModifierId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MethodModifierId = "MethodModifierId";    //函数修饰语Id

 /// <summary>
 /// 常量:"IsForAllTemplate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsForAllTemplate = "IsForAllTemplate";    //是否针对所有模板

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

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
}

}