
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFuncModule_AgcEN
 表名:vFuncModule_Agc(00050125)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:48:28
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:工程管理(PrjManage)
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
 /// 表vFuncModule_Agc的关键字(FuncModuleAgcId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_FuncModuleAgcId_vFuncModule_Agc
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strFuncModuleAgcId">表关键字</param>
public K_FuncModuleAgcId_vFuncModule_Agc(string strFuncModuleAgcId)
{
if (IsValid(strFuncModuleAgcId)) Value = strFuncModuleAgcId;
else
{
Value = null;
}
}
private static bool IsValid(string strFuncModuleAgcId)
{
if (string.IsNullOrEmpty(strFuncModuleAgcId) == true) return false;
if (strFuncModuleAgcId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_FuncModuleAgcId_vFuncModule_Agc]类型的对象</returns>
public static implicit operator K_FuncModuleAgcId_vFuncModule_Agc(string value)
{
return new K_FuncModuleAgcId_vFuncModule_Agc(value);
}
}
 /// <summary>
 /// v功能模块_Agc(vFuncModule_Agc)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvFuncModule_AgcEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vFuncModule_Agc"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "FuncModuleAgcId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 15;
public static string[] _AttributeName = new string[] {"FuncModuleAgcId", "TabNum", "ViewNum", "ObjNum", "PrjViewNum", "FuncModuleName", "FuncModuleEnName", "PrjId", "PrjName", "OrderNum", "UseStateId", "UseStateName", "UpdDate", "Memo", "UpdUser"};

protected string mstrFuncModuleAgcId;    //功能模块Id
protected int? mintTabNum;    //表数
protected int? mintViewNum;    //界面数
protected int? mintObjNum;    //ObjNum
protected int? mintPrjViewNum;    //PrjViewNum
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrFuncModuleEnName;    //功能模块英文名称
protected string mstrPrjId;    //工程Id
protected string mstrPrjName;    //工程名称
protected int mintOrderNum;    //序号
protected string mstrUseStateId;    //使用状态Id
protected string mstrUseStateName;    //使用状态名称
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //说明
protected string mstrUpdUser;    //修改者

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvFuncModule_AgcEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FuncModuleAgcId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strFuncModuleAgcId">关键字:功能模块Id</param>
public clsvFuncModule_AgcEN(string strFuncModuleAgcId)
 {
strFuncModuleAgcId = strFuncModuleAgcId.Replace("'", "''");
if (strFuncModuleAgcId.Length > 8)
{
throw new Exception("在表:vFuncModule_Agc中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strFuncModuleAgcId)  ==  true)
{
throw new Exception("在表:vFuncModule_Agc中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFuncModuleAgcId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrFuncModuleAgcId = strFuncModuleAgcId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FuncModuleAgcId");
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
if (strAttributeName  ==  convFuncModule_Agc.FuncModuleAgcId)
{
return mstrFuncModuleAgcId;
}
else if (strAttributeName  ==  convFuncModule_Agc.TabNum)
{
return mintTabNum;
}
else if (strAttributeName  ==  convFuncModule_Agc.ViewNum)
{
return mintViewNum;
}
else if (strAttributeName  ==  convFuncModule_Agc.ObjNum)
{
return mintObjNum;
}
else if (strAttributeName  ==  convFuncModule_Agc.PrjViewNum)
{
return mintPrjViewNum;
}
else if (strAttributeName  ==  convFuncModule_Agc.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convFuncModule_Agc.FuncModuleEnName)
{
return mstrFuncModuleEnName;
}
else if (strAttributeName  ==  convFuncModule_Agc.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convFuncModule_Agc.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convFuncModule_Agc.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convFuncModule_Agc.UseStateId)
{
return mstrUseStateId;
}
else if (strAttributeName  ==  convFuncModule_Agc.UseStateName)
{
return mstrUseStateName;
}
else if (strAttributeName  ==  convFuncModule_Agc.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convFuncModule_Agc.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convFuncModule_Agc.UpdUser)
{
return mstrUpdUser;
}
return null;
}
set
{
if (strAttributeName  ==  convFuncModule_Agc.FuncModuleAgcId)
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convFuncModule_Agc.FuncModuleAgcId);
}
else if (strAttributeName  ==  convFuncModule_Agc.TabNum)
{
mintTabNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFuncModule_Agc.TabNum);
}
else if (strAttributeName  ==  convFuncModule_Agc.ViewNum)
{
mintViewNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFuncModule_Agc.ViewNum);
}
else if (strAttributeName  ==  convFuncModule_Agc.ObjNum)
{
mintObjNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFuncModule_Agc.ObjNum);
}
else if (strAttributeName  ==  convFuncModule_Agc.PrjViewNum)
{
mintPrjViewNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFuncModule_Agc.PrjViewNum);
}
else if (strAttributeName  ==  convFuncModule_Agc.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convFuncModule_Agc.FuncModuleName);
}
else if (strAttributeName  ==  convFuncModule_Agc.FuncModuleEnName)
{
mstrFuncModuleEnName = value.ToString();
 AddUpdatedFld(convFuncModule_Agc.FuncModuleEnName);
}
else if (strAttributeName  ==  convFuncModule_Agc.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convFuncModule_Agc.PrjId);
}
else if (strAttributeName  ==  convFuncModule_Agc.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convFuncModule_Agc.PrjName);
}
else if (strAttributeName  ==  convFuncModule_Agc.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFuncModule_Agc.OrderNum);
}
else if (strAttributeName  ==  convFuncModule_Agc.UseStateId)
{
mstrUseStateId = value.ToString();
 AddUpdatedFld(convFuncModule_Agc.UseStateId);
}
else if (strAttributeName  ==  convFuncModule_Agc.UseStateName)
{
mstrUseStateName = value.ToString();
 AddUpdatedFld(convFuncModule_Agc.UseStateName);
}
else if (strAttributeName  ==  convFuncModule_Agc.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFuncModule_Agc.UpdDate);
}
else if (strAttributeName  ==  convFuncModule_Agc.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFuncModule_Agc.Memo);
}
else if (strAttributeName  ==  convFuncModule_Agc.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFuncModule_Agc.UpdUser);
}
}
}
public object this[int intIndex]
{
get
{
if (convFuncModule_Agc.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
return mstrFuncModuleAgcId;
}
else if (convFuncModule_Agc.TabNum  ==  _AttributeName[intIndex])
{
return mintTabNum;
}
else if (convFuncModule_Agc.ViewNum  ==  _AttributeName[intIndex])
{
return mintViewNum;
}
else if (convFuncModule_Agc.ObjNum  ==  _AttributeName[intIndex])
{
return mintObjNum;
}
else if (convFuncModule_Agc.PrjViewNum  ==  _AttributeName[intIndex])
{
return mintPrjViewNum;
}
else if (convFuncModule_Agc.FuncModuleName  ==  _AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convFuncModule_Agc.FuncModuleEnName  ==  _AttributeName[intIndex])
{
return mstrFuncModuleEnName;
}
else if (convFuncModule_Agc.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convFuncModule_Agc.PrjName  ==  _AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convFuncModule_Agc.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convFuncModule_Agc.UseStateId  ==  _AttributeName[intIndex])
{
return mstrUseStateId;
}
else if (convFuncModule_Agc.UseStateName  ==  _AttributeName[intIndex])
{
return mstrUseStateName;
}
else if (convFuncModule_Agc.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convFuncModule_Agc.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (convFuncModule_Agc.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
return null;
}
set
{
if (convFuncModule_Agc.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convFuncModule_Agc.FuncModuleAgcId);
}
else if (convFuncModule_Agc.TabNum  ==  _AttributeName[intIndex])
{
mintTabNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFuncModule_Agc.TabNum);
}
else if (convFuncModule_Agc.ViewNum  ==  _AttributeName[intIndex])
{
mintViewNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFuncModule_Agc.ViewNum);
}
else if (convFuncModule_Agc.ObjNum  ==  _AttributeName[intIndex])
{
mintObjNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFuncModule_Agc.ObjNum);
}
else if (convFuncModule_Agc.PrjViewNum  ==  _AttributeName[intIndex])
{
mintPrjViewNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFuncModule_Agc.PrjViewNum);
}
else if (convFuncModule_Agc.FuncModuleName  ==  _AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convFuncModule_Agc.FuncModuleName);
}
else if (convFuncModule_Agc.FuncModuleEnName  ==  _AttributeName[intIndex])
{
mstrFuncModuleEnName = value.ToString();
 AddUpdatedFld(convFuncModule_Agc.FuncModuleEnName);
}
else if (convFuncModule_Agc.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convFuncModule_Agc.PrjId);
}
else if (convFuncModule_Agc.PrjName  ==  _AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convFuncModule_Agc.PrjName);
}
else if (convFuncModule_Agc.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFuncModule_Agc.OrderNum);
}
else if (convFuncModule_Agc.UseStateId  ==  _AttributeName[intIndex])
{
mstrUseStateId = value.ToString();
 AddUpdatedFld(convFuncModule_Agc.UseStateId);
}
else if (convFuncModule_Agc.UseStateName  ==  _AttributeName[intIndex])
{
mstrUseStateName = value.ToString();
 AddUpdatedFld(convFuncModule_Agc.UseStateName);
}
else if (convFuncModule_Agc.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFuncModule_Agc.UpdDate);
}
else if (convFuncModule_Agc.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFuncModule_Agc.Memo);
}
else if (convFuncModule_Agc.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFuncModule_Agc.UpdUser);
}
}
}

/// <summary>
/// 功能模块Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleAgcId
{
get
{
return mstrFuncModuleAgcId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleAgcId = value;
}
else
{
 mstrFuncModuleAgcId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFuncModule_Agc.FuncModuleAgcId);
}
}
/// <summary>
/// 表数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? TabNum
{
get
{
return mintTabNum;
}
set
{
 mintTabNum = value;
//记录修改过的字段
 AddUpdatedFld(convFuncModule_Agc.TabNum);
}
}
/// <summary>
/// 界面数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? ViewNum
{
get
{
return mintViewNum;
}
set
{
 mintViewNum = value;
//记录修改过的字段
 AddUpdatedFld(convFuncModule_Agc.ViewNum);
}
}
/// <summary>
/// ObjNum(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? ObjNum
{
get
{
return mintObjNum;
}
set
{
 mintObjNum = value;
//记录修改过的字段
 AddUpdatedFld(convFuncModule_Agc.ObjNum);
}
}
/// <summary>
/// PrjViewNum(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? PrjViewNum
{
get
{
return mintPrjViewNum;
}
set
{
 mintPrjViewNum = value;
//记录修改过的字段
 AddUpdatedFld(convFuncModule_Agc.PrjViewNum);
}
}
/// <summary>
/// 功能模块名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrFuncModuleName = value;
}
else
{
 mstrFuncModuleName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFuncModule_Agc.FuncModuleName);
}
}
/// <summary>
/// 功能模块英文名称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleEnName
{
get
{
return mstrFuncModuleEnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleEnName = value;
}
else
{
 mstrFuncModuleEnName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFuncModule_Agc.FuncModuleEnName);
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
 AddUpdatedFld(convFuncModule_Agc.PrjId);
}
}
/// <summary>
/// 工程名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjName
{
get
{
return mstrPrjName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjName = value;
}
else
{
 mstrPrjName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFuncModule_Agc.PrjName);
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
 AddUpdatedFld(convFuncModule_Agc.OrderNum);
}
}
/// <summary>
/// 使用状态Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UseStateId
{
get
{
return mstrUseStateId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUseStateId = value;
}
else
{
 mstrUseStateId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFuncModule_Agc.UseStateId);
}
}
/// <summary>
/// 使用状态名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UseStateName
{
get
{
return mstrUseStateName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUseStateName = value;
}
else
{
 mstrUseStateName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFuncModule_Agc.UseStateName);
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
 AddUpdatedFld(convFuncModule_Agc.UpdDate);
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
 AddUpdatedFld(convFuncModule_Agc.Memo);
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
 AddUpdatedFld(convFuncModule_Agc.UpdUser);
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
  return mstrFuncModuleAgcId;
 }
 }
}
 /// <summary>
 /// v功能模块_Agc(vFuncModule_Agc)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convFuncModule_Agc
{
public const string _CurrTabName = "vFuncModule_Agc"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FuncModuleAgcId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"FuncModuleAgcId", "TabNum", "ViewNum", "ObjNum", "PrjViewNum", "FuncModuleName", "FuncModuleEnName", "PrjId", "PrjName", "OrderNum", "UseStateId", "UseStateName", "UpdDate", "Memo", "UpdUser"};
//以下是属性变量


 /// <summary>
 /// 常量:"FuncModuleAgcId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleAgcId = "FuncModuleAgcId";    //功能模块Id

 /// <summary>
 /// 常量:"TabNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabNum = "TabNum";    //表数

 /// <summary>
 /// 常量:"ViewNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewNum = "ViewNum";    //界面数

 /// <summary>
 /// 常量:"ObjNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ObjNum = "ObjNum";    //ObjNum

 /// <summary>
 /// 常量:"PrjViewNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjViewNum = "PrjViewNum";    //PrjViewNum

 /// <summary>
 /// 常量:"FuncModuleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleName = "FuncModuleName";    //功能模块名称

 /// <summary>
 /// 常量:"FuncModuleEnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleEnName = "FuncModuleEnName";    //功能模块英文名称

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"PrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjName = "PrjName";    //工程名称

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"UseStateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UseStateId = "UseStateId";    //使用状态Id

 /// <summary>
 /// 常量:"UseStateName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UseStateName = "UseStateName";    //使用状态名称

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改者
}

}