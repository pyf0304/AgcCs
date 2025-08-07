
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjObjTotalEN
 表名:vPrjObjTotal
 生成代码版本:2017.11.09.1
 生成日期:2017/11/10 16:42:08
 生成者:潘以锋
 生成服务器IP:101.251.68.133
 工程名称:AGC
 工程ID:0005
 模块中文名:工程管理
 模块英文名:PrjManage
 框架-层名:实体层
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2017.11.09.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.11.09.01
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
 /// vPrjObjTotal(vPrjObjTotal)
 /// (AutoGCLib.AutoGC6Cs_M:A_GenEntityLayerCode)
 /// </summary>
[Serializable]
public class clsvPrjObjTotalEN : clsEntityBase2
{
public const string CurrTabName_S = "vPrjObjTotal"; //当前表名,与该类相关的表名
public const string CurrTabKeyFldName_S = "ObjId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 18;
public static string[] AttributeName = new string[] {"ObjId", "TabId", "TabName", "FldNum", "TabCnName", "ObjName", "PrjId", "FuncModuleName", "ObjFunction", "ObjTypeId", "ObjectType", "IsSynchWithTab", "FuncModuleAgcId", "UserId", "UpdDate", "UseStateId", "UseStateName", "Memo"};
//以下是属性变量

protected string mstrObjId;    //所属对象
protected string mstrTabId;    //表ID
protected string mstrTabName;    //表名
protected int mintFldNum;    //FldNum
protected string mstrTabCnName;    //表中文名
protected string mstrObjName;    //对象名称
protected string mstrPrjId;    //工程ID
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrObjFunction;    //对象功能
protected string mstrObjTypeId;    //对象分类ID
protected string mstrObjectType;    //对象类型名
protected bool mbolIsSynchWithTab;    //是否表同步
protected string mstrFuncModuleAgcId;    //功能模块Id
protected string mstrUserId;    //用户ID
protected string mstrUpdDate;    //修改日期
protected string mstrUseStateId;    //使用状态Id
protected string mstrUseStateName;    //使用状态名称
protected string mstrMemo;    //说明


 /// <summary>
 /// 常量:"ObjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ObjId = "ObjId";    //所属对象

 /// <summary>
 /// 常量:"TabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_TabId = "TabId";    //表ID

 /// <summary>
 /// 常量:"TabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_TabName = "TabName";    //表名

 /// <summary>
 /// 常量:"FldNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_FldNum = "FldNum";    //FldNum

 /// <summary>
 /// 常量:"TabCnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_TabCnName = "TabCnName";    //表中文名

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
 /// 常量:"FuncModuleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_FuncModuleName = "FuncModuleName";    //功能模块名称

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
 /// 常量:"ObjectType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ObjectType = "ObjectType";    //对象类型名

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
 /// 常量:"UseStateName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UseStateName = "UseStateName";    //使用状态名称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo = "Memo";    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.AutoGCPubFuncV6:GenClassConstructor1)
/// </summary>
 public clsvPrjObjTotalEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "vPrjObjTotal";
 lstKeyFldNames.Add("ObjId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.AutoGCPubFuncV6:GenClassConstructor2)
/// </summary>
/// <param name = "mstrObjId">关键字:所属对象</param>
public clsvPrjObjTotalEN(string strObjId)
 {
strObjId = strObjId.Replace("'", "''");
if (strObjId.Length > 8)
{
throw new Exception("在表:vPrjObjTotal中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strObjId)  ==  true)
{
throw new Exception("在表:vPrjObjTotal中,关键字不能为空 或 null!");
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
 _CurrTabName = "vPrjObjTotal";
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
else if (strAttributeName  ==  con_TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  con_TabName)
{
return mstrTabName;
}
else if (strAttributeName  ==  con_FldNum)
{
return mintFldNum;
}
else if (strAttributeName  ==  con_TabCnName)
{
return mstrTabCnName;
}
else if (strAttributeName  ==  con_ObjName)
{
return mstrObjName;
}
else if (strAttributeName  ==  con_PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  con_FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  con_ObjFunction)
{
return mstrObjFunction;
}
else if (strAttributeName  ==  con_ObjTypeId)
{
return mstrObjTypeId;
}
else if (strAttributeName  ==  con_ObjectType)
{
return mstrObjectType;
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
else if (strAttributeName  ==  con_UseStateName)
{
return mstrUseStateName;
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
else if (strAttributeName  ==  con_TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(con_TabId);
}
else if (strAttributeName  ==  con_TabName)
{
mstrTabName = value.ToString();
 AddUpdatedFld(con_TabName);
}
else if (strAttributeName  ==  con_FldNum)
{
mintFldNum = TransNullToInt(value.ToString());
 AddUpdatedFld(con_FldNum);
}
else if (strAttributeName  ==  con_TabCnName)
{
mstrTabCnName = value.ToString();
 AddUpdatedFld(con_TabCnName);
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
else if (strAttributeName  ==  con_FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(con_FuncModuleName);
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
else if (strAttributeName  ==  con_ObjectType)
{
mstrObjectType = value.ToString();
 AddUpdatedFld(con_ObjectType);
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
else if (strAttributeName  ==  con_UseStateName)
{
mstrUseStateName = value.ToString();
 AddUpdatedFld(con_UseStateName);
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
else if (con_TabId  ==  AttributeName[intIndex])
{
return mstrTabId;
}
else if (con_TabName  ==  AttributeName[intIndex])
{
return mstrTabName;
}
else if (con_FldNum  ==  AttributeName[intIndex])
{
return mintFldNum;
}
else if (con_TabCnName  ==  AttributeName[intIndex])
{
return mstrTabCnName;
}
else if (con_ObjName  ==  AttributeName[intIndex])
{
return mstrObjName;
}
else if (con_PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
else if (con_FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (con_ObjFunction  ==  AttributeName[intIndex])
{
return mstrObjFunction;
}
else if (con_ObjTypeId  ==  AttributeName[intIndex])
{
return mstrObjTypeId;
}
else if (con_ObjectType  ==  AttributeName[intIndex])
{
return mstrObjectType;
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
else if (con_UseStateName  ==  AttributeName[intIndex])
{
return mstrUseStateName;
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
else if (con_TabId  ==  AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(con_TabId);
}
else if (con_TabName  ==  AttributeName[intIndex])
{
mstrTabName = value.ToString();
 AddUpdatedFld(con_TabName);
}
else if (con_FldNum  ==  AttributeName[intIndex])
{
mintFldNum = TransNullToInt(value.ToString());
 AddUpdatedFld(con_FldNum);
}
else if (con_TabCnName  ==  AttributeName[intIndex])
{
mstrTabCnName = value.ToString();
 AddUpdatedFld(con_TabCnName);
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
else if (con_FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(con_FuncModuleName);
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
else if (con_ObjectType  ==  AttributeName[intIndex])
{
mstrObjectType = value.ToString();
 AddUpdatedFld(con_ObjectType);
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
else if (con_UseStateName  ==  AttributeName[intIndex])
{
mstrUseStateName = value.ToString();
 AddUpdatedFld(con_UseStateName);
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
/// 表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
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
 AddUpdatedFld(con_TabId);
}
}
/// <summary>
/// 表名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
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
 AddUpdatedFld(con_TabName);
}
}
/// <summary>
/// FldNum(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public int FldNum
{
get
{
return mintFldNum;
}
set
{
 mintFldNum = value;
//记录修改过的字段
 AddUpdatedFld(con_FldNum);
}
}
/// <summary>
/// 表中文名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
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
 AddUpdatedFld(con_TabCnName);
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
/// 功能模块名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
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
 AddUpdatedFld(con_FuncModuleName);
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
/// 对象类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string ObjectType
{
get
{
return mstrObjectType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrObjectType = value;
}
else
{
 mstrObjectType = value;
}
//记录修改过的字段
 AddUpdatedFld(con_ObjectType);
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
/// 使用状态名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
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
 AddUpdatedFld(con_UseStateName);
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