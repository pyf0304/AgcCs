
//类名:clsRoleMenusEN
 ///----------------------
 ///生成代码版本:2016.10.07.1
 ///生成日期:2017/01/09
 ///生成者:潘以锋
 ///工程名称:AGC
 ///工程ID:0005
 ///模块中文名:项目菜单管理
 ///模块英文名:PrjMenu
 ///注意:1、需要数据底层(PubDataBase.dll)的版本:2016.09.04.01
 ///       2、需要公共函数层(TzPubFunction.dll)的版本:2016.09.04.01
 /// ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == 
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
 /// 角色菜单(RoleMenus)
 /// (AGC.BusinessLogicEx.AutoGC6Cs_M:A_GenEntityLayerCode)
 /// </summary>
[Serializable]
public class clsRoleMenusEN : clsEntityBase2
{
public const string CurrTabName_S = "RoleMenus"; //当前表名,与该类相关的表名
public const string CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 8;
public static string[] AttributeName = new string[] {"mId", "RoleId", "PrjId", "MenuId", "IsDisp", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量

protected long mlngmId;    //mId
protected string mstrRoleId;    //角色ID
protected string mstrPrjId;    //工程ID
protected string mstrMenuId;    //菜单ID
protected bool mbolIsDisp;    //是否显示
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //说明


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_mId  =  "mId";    //mId

 /// <summary>
 /// 常量:"RoleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_RoleId  =  "RoleId";    //角色ID

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PrjId  =  "PrjId";    //工程ID

 /// <summary>
 /// 常量:"MenuId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_MenuId  =  "MenuId";    //菜单ID

 /// <summary>
 /// 常量:"IsDisp"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsDisp  =  "IsDisp";    //是否显示

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpdDate  =  "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpdUserId  =  "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo  =  "Memo";    //说明

/// <summary>
/// 构造函数
 /// (AGC.BusinessLogicEx.AutoGCPubFuncV6:GenClassConstructor1)
/// </summary>
 public clsRoleMenusEN()
 {
 SetInit();
 mbolIsCheckProperty  =  false;
 _CurrTabName  =  "RoleMenus";
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AGC.BusinessLogicEx.AutoGCPubFuncV6:GenClassConstructor2)
/// </summary>
/// <param name = "mlngmId">关键字:mId</param>
public clsRoleMenusEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty  =  false;
 _CurrTabName  =  "RoleMenus";
 lstKeyFldNames.Add("mId");
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
if (strAttributeName  ==  con_mId)
{
return mlngmId;
}
else if (strAttributeName  ==  con_RoleId)
{
return mstrRoleId;
}
else if (strAttributeName  ==  con_PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  con_MenuId)
{
return mstrMenuId;
}
else if (strAttributeName  ==  con_IsDisp)
{
return mbolIsDisp;
}
else if (strAttributeName  ==  con_UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  con_UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  con_Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  con_mId)
{
mlngmId  =  TransNullToInt(value.ToString());
 AddUpdatedFld(con_mId);
}
else if (strAttributeName  ==  con_RoleId)
{
mstrRoleId  =  value.ToString();
 AddUpdatedFld(con_RoleId);
}
else if (strAttributeName  ==  con_PrjId)
{
mstrPrjId  =  value.ToString();
 AddUpdatedFld(con_PrjId);
}
else if (strAttributeName  ==  con_MenuId)
{
mstrMenuId  =  value.ToString();
 AddUpdatedFld(con_MenuId);
}
else if (strAttributeName  ==  con_IsDisp)
{
mbolIsDisp  =  TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsDisp);
}
else if (strAttributeName  ==  con_UpdDate)
{
mstrUpdDate  =  value.ToString();
 AddUpdatedFld(con_UpdDate);
}
else if (strAttributeName  ==  con_UpdUserId)
{
mstrUpdUserId  =  value.ToString();
 AddUpdatedFld(con_UpdUserId);
}
else if (strAttributeName  ==  con_Memo)
{
mstrMemo  =  value.ToString();
 AddUpdatedFld(con_Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (con_mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (con_RoleId  ==  AttributeName[intIndex])
{
return mstrRoleId;
}
else if (con_PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
else if (con_MenuId  ==  AttributeName[intIndex])
{
return mstrMenuId;
}
else if (con_IsDisp  ==  AttributeName[intIndex])
{
return mbolIsDisp;
}
else if (con_UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (con_UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (con_Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (con_mId  ==  AttributeName[intIndex])
{
mlngmId  =  TransNullToInt(value.ToString());
 AddUpdatedFld(con_mId);
}
else if (con_RoleId  ==  AttributeName[intIndex])
{
mstrRoleId  =  value.ToString();
 AddUpdatedFld(con_RoleId);
}
else if (con_PrjId  ==  AttributeName[intIndex])
{
mstrPrjId  =  value.ToString();
 AddUpdatedFld(con_PrjId);
}
else if (con_MenuId  ==  AttributeName[intIndex])
{
mstrMenuId  =  value.ToString();
 AddUpdatedFld(con_MenuId);
}
else if (con_IsDisp  ==  AttributeName[intIndex])
{
mbolIsDisp  =  TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsDisp);
}
else if (con_UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate  =  value.ToString();
 AddUpdatedFld(con_UpdDate);
}
else if (con_UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId  =  value.ToString();
 AddUpdatedFld(con_UpdUserId);
}
else if (con_Memo  ==  AttributeName[intIndex])
{
mstrMemo  =  value.ToString();
 AddUpdatedFld(con_Memo);
}
}
}

/// <summary>
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public long mId
{
get
{
return mlngmId;
}
set
{
 mlngmId  =  value;
//记录修改过的字段
 AddUpdatedFld(con_mId);
}
}
/// <summary>
/// 角色ID(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string RoleId
{
get
{
return mstrRoleId;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrRoleId  =  value;
}
else
{
 mstrRoleId  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_RoleId);
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
mintErrNo  =  1;
 mstrPrjId  =  value;
}
else
{
 mstrPrjId  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_PrjId);
}
}
/// <summary>
/// 菜单ID(说明:;字段类型:varchar;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string MenuId
{
get
{
return mstrMenuId;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrMenuId  =  value;
}
else
{
 mstrMenuId  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_MenuId);
}
}
/// <summary>
/// 是否显示(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public bool IsDisp
{
get
{
return mbolIsDisp;
}
set
{
 mbolIsDisp  =  value;
//记录修改过的字段
 AddUpdatedFld(con_IsDisp);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
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
mintErrNo  =  1;
 mstrUpdDate  =  value;
}
else
{
 mstrUpdDate  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_UpdDate);
}
}
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string UpdUserId
{
get
{
return mstrUpdUserId;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrUpdUserId  =  value;
}
else
{
 mstrUpdUserId  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_UpdUserId);
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
mintErrNo  =  1;
 mstrMemo  =  value;
}
else
{
 mstrMemo  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_Memo);
}
}
}
}