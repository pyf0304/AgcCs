
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFunctionTemplateRelaEN
 表名:FunctionTemplateRela(00050313)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:01:11
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
 /// 表FunctionTemplateRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_FunctionTemplateRela
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
public K_mId_FunctionTemplateRela(long lngmId)
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
 /// <returns>返回:[K_mId_FunctionTemplateRela]类型的对象</returns>
public static implicit operator K_mId_FunctionTemplateRela(long value)
{
return new K_mId_FunctionTemplateRela(value);
}
}
 /// <summary>
 /// 函数与模板关系(FunctionTemplateRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsFunctionTemplateRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "FunctionTemplateRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 11;
public static string[] _AttributeName = new string[] {"mId", "FunctionTemplateId", "CodeTypeId", "RegionTypeId", "FuncCodeTypeId", "FuncId4GC", "IsGeneCode", "OrderNum", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrFunctionTemplateId;    //函数模板Id
protected string mstrCodeTypeId;    //代码类型Id
protected string mstrRegionTypeId;    //区域类型Id
protected string mstrFuncCodeTypeId;    //函数代码类型Id
protected string mstrFuncId4GC;    //函数ID
protected bool mbolIsGeneCode;    //是否生成代码
protected int mintOrderNum;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsFunctionTemplateRelaEN()
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
public clsFunctionTemplateRelaEN(long lngmId)
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
if (strAttributeName  ==  conFunctionTemplateRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conFunctionTemplateRela.FunctionTemplateId)
{
return mstrFunctionTemplateId;
}
else if (strAttributeName  ==  conFunctionTemplateRela.CodeTypeId)
{
return mstrCodeTypeId;
}
else if (strAttributeName  ==  conFunctionTemplateRela.RegionTypeId)
{
return mstrRegionTypeId;
}
else if (strAttributeName  ==  conFunctionTemplateRela.FuncCodeTypeId)
{
return mstrFuncCodeTypeId;
}
else if (strAttributeName  ==  conFunctionTemplateRela.FuncId4GC)
{
return mstrFuncId4GC;
}
else if (strAttributeName  ==  conFunctionTemplateRela.IsGeneCode)
{
return mbolIsGeneCode;
}
else if (strAttributeName  ==  conFunctionTemplateRela.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conFunctionTemplateRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conFunctionTemplateRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conFunctionTemplateRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conFunctionTemplateRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conFunctionTemplateRela.mId);
}
else if (strAttributeName  ==  conFunctionTemplateRela.FunctionTemplateId)
{
mstrFunctionTemplateId = value.ToString();
 AddUpdatedFld(conFunctionTemplateRela.FunctionTemplateId);
}
else if (strAttributeName  ==  conFunctionTemplateRela.CodeTypeId)
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(conFunctionTemplateRela.CodeTypeId);
}
else if (strAttributeName  ==  conFunctionTemplateRela.RegionTypeId)
{
mstrRegionTypeId = value.ToString();
 AddUpdatedFld(conFunctionTemplateRela.RegionTypeId);
}
else if (strAttributeName  ==  conFunctionTemplateRela.FuncCodeTypeId)
{
mstrFuncCodeTypeId = value.ToString();
 AddUpdatedFld(conFunctionTemplateRela.FuncCodeTypeId);
}
else if (strAttributeName  ==  conFunctionTemplateRela.FuncId4GC)
{
mstrFuncId4GC = value.ToString();
 AddUpdatedFld(conFunctionTemplateRela.FuncId4GC);
}
else if (strAttributeName  ==  conFunctionTemplateRela.IsGeneCode)
{
mbolIsGeneCode = TransNullToBool(value.ToString());
 AddUpdatedFld(conFunctionTemplateRela.IsGeneCode);
}
else if (strAttributeName  ==  conFunctionTemplateRela.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conFunctionTemplateRela.OrderNum);
}
else if (strAttributeName  ==  conFunctionTemplateRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFunctionTemplateRela.UpdDate);
}
else if (strAttributeName  ==  conFunctionTemplateRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conFunctionTemplateRela.UpdUser);
}
else if (strAttributeName  ==  conFunctionTemplateRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFunctionTemplateRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conFunctionTemplateRela.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (conFunctionTemplateRela.FunctionTemplateId  ==  _AttributeName[intIndex])
{
return mstrFunctionTemplateId;
}
else if (conFunctionTemplateRela.CodeTypeId  ==  _AttributeName[intIndex])
{
return mstrCodeTypeId;
}
else if (conFunctionTemplateRela.RegionTypeId  ==  _AttributeName[intIndex])
{
return mstrRegionTypeId;
}
else if (conFunctionTemplateRela.FuncCodeTypeId  ==  _AttributeName[intIndex])
{
return mstrFuncCodeTypeId;
}
else if (conFunctionTemplateRela.FuncId4GC  ==  _AttributeName[intIndex])
{
return mstrFuncId4GC;
}
else if (conFunctionTemplateRela.IsGeneCode  ==  _AttributeName[intIndex])
{
return mbolIsGeneCode;
}
else if (conFunctionTemplateRela.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conFunctionTemplateRela.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conFunctionTemplateRela.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conFunctionTemplateRela.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conFunctionTemplateRela.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conFunctionTemplateRela.mId);
}
else if (conFunctionTemplateRela.FunctionTemplateId  ==  _AttributeName[intIndex])
{
mstrFunctionTemplateId = value.ToString();
 AddUpdatedFld(conFunctionTemplateRela.FunctionTemplateId);
}
else if (conFunctionTemplateRela.CodeTypeId  ==  _AttributeName[intIndex])
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(conFunctionTemplateRela.CodeTypeId);
}
else if (conFunctionTemplateRela.RegionTypeId  ==  _AttributeName[intIndex])
{
mstrRegionTypeId = value.ToString();
 AddUpdatedFld(conFunctionTemplateRela.RegionTypeId);
}
else if (conFunctionTemplateRela.FuncCodeTypeId  ==  _AttributeName[intIndex])
{
mstrFuncCodeTypeId = value.ToString();
 AddUpdatedFld(conFunctionTemplateRela.FuncCodeTypeId);
}
else if (conFunctionTemplateRela.FuncId4GC  ==  _AttributeName[intIndex])
{
mstrFuncId4GC = value.ToString();
 AddUpdatedFld(conFunctionTemplateRela.FuncId4GC);
}
else if (conFunctionTemplateRela.IsGeneCode  ==  _AttributeName[intIndex])
{
mbolIsGeneCode = TransNullToBool(value.ToString());
 AddUpdatedFld(conFunctionTemplateRela.IsGeneCode);
}
else if (conFunctionTemplateRela.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conFunctionTemplateRela.OrderNum);
}
else if (conFunctionTemplateRela.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFunctionTemplateRela.UpdDate);
}
else if (conFunctionTemplateRela.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conFunctionTemplateRela.UpdUser);
}
else if (conFunctionTemplateRela.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFunctionTemplateRela.Memo);
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
 AddUpdatedFld(conFunctionTemplateRela.mId);
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
 AddUpdatedFld(conFunctionTemplateRela.FunctionTemplateId);
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
 AddUpdatedFld(conFunctionTemplateRela.CodeTypeId);
}
}
/// <summary>
/// 区域类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RegionTypeId
{
get
{
return mstrRegionTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRegionTypeId = value;
}
else
{
 mstrRegionTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunctionTemplateRela.RegionTypeId);
}
}
/// <summary>
/// 函数代码类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncCodeTypeId
{
get
{
return mstrFuncCodeTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncCodeTypeId = value;
}
else
{
 mstrFuncCodeTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunctionTemplateRela.FuncCodeTypeId);
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
 AddUpdatedFld(conFunctionTemplateRela.FuncId4GC);
}
}
/// <summary>
/// 是否生成代码(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsGeneCode
{
get
{
return mbolIsGeneCode;
}
set
{
 mbolIsGeneCode = value;
//记录修改过的字段
 AddUpdatedFld(conFunctionTemplateRela.IsGeneCode);
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
 AddUpdatedFld(conFunctionTemplateRela.OrderNum);
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
 AddUpdatedFld(conFunctionTemplateRela.UpdDate);
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
 AddUpdatedFld(conFunctionTemplateRela.UpdUser);
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
 AddUpdatedFld(conFunctionTemplateRela.Memo);
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
 /// 函数与模板关系(FunctionTemplateRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conFunctionTemplateRela
{
public const string _CurrTabName = "FunctionTemplateRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "FunctionTemplateId", "CodeTypeId", "RegionTypeId", "FuncCodeTypeId", "FuncId4GC", "IsGeneCode", "OrderNum", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

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
 /// 常量:"RegionTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RegionTypeId = "RegionTypeId";    //区域类型Id

 /// <summary>
 /// 常量:"FuncCodeTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncCodeTypeId = "FuncCodeTypeId";    //函数代码类型Id

 /// <summary>
 /// 常量:"FuncId4GC"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncId4GC = "FuncId4GC";    //函数ID

 /// <summary>
 /// 常量:"IsGeneCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsGeneCode = "IsGeneCode";    //是否生成代码

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

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