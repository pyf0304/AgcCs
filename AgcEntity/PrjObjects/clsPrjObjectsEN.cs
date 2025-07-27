
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjObjectsEN
 表名:PrjObjects
 生成代码版本:2017.06.27.1
 生成日期:2017/06/27 19:57:26
 生成者:
 生成服务器IP:180.153.158.158
 工程名称:AGC
 工程ID:0005
 模块中文名:工程对象
 模块英文名:PrjObjects
 框架-层名:实体层
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2017.06.19.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2016.12.13.01
 == == == == == == == == == == == == 
 */
using System;
using System.Text; 
using System.Collections; 
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;

namespace AGC.Entity
{
 /// <summary>
 /// 工程对象(PrjObjects)
 /// (AutoGCLib.AutoGC6Cs_M:A_GenEntityLayerCode)
 /// </summary>
[Serializable]
public class clsPrjObjectsEN : clsEntityBase2
{
public const string CurrTabName_S = "PrjObjects"; //当前表名,与该类相关的表名
public const string CurrTabKeyFldName_S = "ObjId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 11;
public static string[] AttributeName = new string[] {"ObjId", "ObjName", "PrjId", "ObjFunction", "ObjTypeId", "IsSynchWithTab", "FuncModuleAgcId", "UserId", "UpdDate", "UseStateId", "Memo"};
//以下是属性变量

protected string mstrObjId;    //所属对象
protected string mstrObjName;    //对象名称
protected string mstrPrjId;    //工程ID
protected string mstrObjFunction;    //对象功能
protected string mstrObjTypeId;    //对象分类ID
protected bool mbolIsSynchWithTab;    //是否表同步
protected string mstrFuncModuleAgcId;    //功能模块Id
protected string mstrUserId;    //用户ID
protected string mstrUpdDate;    //修改日期
protected string mstrUseStateId;    //使用状态Id
protected string mstrMemo;    //说明


 /// <summary>
 /// 常量:"ObjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ObjId = "ObjId";    //所属对象

 /// <summary>
 /// 常量:"ObjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ObjName = "ObjName";    //对象名称

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PrjId = "PrjId";    //工程ID

 /// <summary>
 /// 常量:"ObjFunction"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ObjFunction = "ObjFunction";    //对象功能

 /// <summary>
 /// 常量:"ObjTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ObjTypeId = "ObjTypeId";    //对象分类ID

 /// <summary>
 /// 常量:"IsSynchWithTab"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsSynchWithTab = "IsSynchWithTab";    //是否表同步

 /// <summary>
 /// 常量:"FuncModuleAgcId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_FuncModuleAgcId = "FuncModuleAgcId";    //功能模块Id

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UseStateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UseStateId = "UseStateId";    //使用状态Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo = "Memo";    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.AutoGCPubFuncV6:GenClassConstructor1)
/// </summary>
 public clsPrjObjectsEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "PrjObjects";
 lstKeyFldNames.Add("ObjId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.AutoGCPubFuncV6:GenClassConstructor2)
/// </summary>
/// <param name = "mstrObjId">关键字:所属对象</param>
public clsPrjObjectsEN(string strObjId)
 {
strObjId = strObjId.Replace("'", "''");
if (strObjId.Length > 8)
{
throw new Exception("在表:PrjObjects中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strObjId)  ==  true)
{
throw new Exception("在表:PrjObjects中,关键字不能为空 或 null!");
}
try
{
clsCommonRegular.CheckStrSQL_Weak(strObjId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

mstrObjId = strObjId;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "PrjObjects";
 lstKeyFldNames.Add("ObjId");
 }

public static int AttributeCount
{
get
{
return mintAttributeCount;
}
}
public object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  con_ObjId)
{
return mstrObjId;
}
else if (strAttributeName  ==  con_ObjName)
{
return mstrObjName;
}
else if (strAttributeName  ==  con_PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  con_ObjFunction)
{
return mstrObjFunction;
}
else if (strAttributeName  ==  con_ObjTypeId)
{
return mstrObjTypeId;
}
else if (strAttributeName  ==  con_IsSynchWithTab)
{
return mbolIsSynchWithTab;
}
else if (strAttributeName  ==  con_FuncModuleAgcId)
{
return mstrFuncModuleAgcId;
}
else if (strAttributeName  ==  con_UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  con_UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  con_UseStateId)
{
return mstrUseStateId;
}
else if (strAttributeName  ==  con_Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  con_ObjId)
{
mstrObjId = value.ToString();
 AddUpdatedFld(con_ObjId);
}
else if (strAttributeName  ==  con_ObjName)
{
mstrObjName = value.ToString();
 AddUpdatedFld(con_ObjName);
}
else if (strAttributeName  ==  con_PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(con_PrjId);
}
else if (strAttributeName  ==  con_ObjFunction)
{
mstrObjFunction = value.ToString();
 AddUpdatedFld(con_ObjFunction);
}
else if (strAttributeName  ==  con_ObjTypeId)
{
mstrObjTypeId = value.ToString();
 AddUpdatedFld(con_ObjTypeId);
}
else if (strAttributeName  ==  con_IsSynchWithTab)
{
mbolIsSynchWithTab = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsSynchWithTab);
}
else if (strAttributeName  ==  con_FuncModuleAgcId)
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(con_FuncModuleAgcId);
}
else if (strAttributeName  ==  con_UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(con_UserId);
}
else if (strAttributeName  ==  con_UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(con_UpdDate);
}
else if (strAttributeName  ==  con_UseStateId)
{
mstrUseStateId = value.ToString();
 AddUpdatedFld(con_UseStateId);
}
else if (strAttributeName  ==  con_Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (con_ObjId  ==  AttributeName[intIndex])
{
return mstrObjId;
}
else if (con_ObjName  ==  AttributeName[intIndex])
{
return mstrObjName;
}
else if (con_PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
else if (con_ObjFunction  ==  AttributeName[intIndex])
{
return mstrObjFunction;
}
else if (con_ObjTypeId  ==  AttributeName[intIndex])
{
return mstrObjTypeId;
}
else if (con_IsSynchWithTab  ==  AttributeName[intIndex])
{
return mbolIsSynchWithTab;
}
else if (con_FuncModuleAgcId  ==  AttributeName[intIndex])
{
return mstrFuncModuleAgcId;
}
else if (con_UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (con_UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (con_UseStateId  ==  AttributeName[intIndex])
{
return mstrUseStateId;
}
else if (con_Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (con_ObjId  ==  AttributeName[intIndex])
{
mstrObjId = value.ToString();
 AddUpdatedFld(con_ObjId);
}
else if (con_ObjName  ==  AttributeName[intIndex])
{
mstrObjName = value.ToString();
 AddUpdatedFld(con_ObjName);
}
else if (con_PrjId  ==  AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(con_PrjId);
}
else if (con_ObjFunction  ==  AttributeName[intIndex])
{
mstrObjFunction = value.ToString();
 AddUpdatedFld(con_ObjFunction);
}
else if (con_ObjTypeId  ==  AttributeName[intIndex])
{
mstrObjTypeId = value.ToString();
 AddUpdatedFld(con_ObjTypeId);
}
else if (con_IsSynchWithTab  ==  AttributeName[intIndex])
{
mbolIsSynchWithTab = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsSynchWithTab);
}
else if (con_FuncModuleAgcId  ==  AttributeName[intIndex])
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(con_FuncModuleAgcId);
}
else if (con_UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(con_UserId);
}
else if (con_UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(con_UpdDate);
}
else if (con_UseStateId  ==  AttributeName[intIndex])
{
mstrUseStateId = value.ToString();
 AddUpdatedFld(con_UseStateId);
}
else if (con_Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
}
}
}

/// <summary>
/// 所属对象(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string ObjId
{
get
{
return mstrObjId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrObjId = value;
}
else
{
 mstrObjId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_ObjId);
}
}
/// <summary>
/// 对象名称(说明:;字段类型:varchar;字段长度:60;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string ObjName
{
get
{
return mstrObjName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrObjName = value;
}
else
{
 mstrObjName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_ObjName);
}
}
/// <summary>
/// 工程ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
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
 AddUpdatedFld(con_PrjId);
}
}
/// <summary>
/// 对象功能(说明:;字段类型:varchar;字段长度:1000;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string ObjFunction
{
get
{
return mstrObjFunction;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrObjFunction = value;
}
else
{
 mstrObjFunction = value;
}
//记录修改过的字段
 AddUpdatedFld(con_ObjFunction);
}
}
/// <summary>
/// 对象分类ID(说明:;字段类型:varchar;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string ObjTypeId
{
get
{
return mstrObjTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrObjTypeId = value;
}
else
{
 mstrObjTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_ObjTypeId);
}
}
/// <summary>
/// 是否表同步(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public bool IsSynchWithTab
{
get
{
return mbolIsSynchWithTab;
}
set
{
 mbolIsSynchWithTab = value;
//记录修改过的字段
 AddUpdatedFld(con_IsSynchWithTab);
}
}
/// <summary>
/// 功能模块Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
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
 AddUpdatedFld(con_FuncModuleAgcId);
}
}
/// <summary>
/// 用户ID(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string UserId
{
get
{
return mstrUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserId = value;
}
else
{
 mstrUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_UserId);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
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
 AddUpdatedFld(con_UpdDate);
}
}
/// <summary>
/// 使用状态Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
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
 AddUpdatedFld(con_UseStateId);
}
}
/// <summary>
/// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
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
 AddUpdatedFld(con_Memo);
}
}
}
}