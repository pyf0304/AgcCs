
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjUserMenusEN
 表名:PrjUserMenus
 生成代码版本:2017.04.27.1
 生成日期:2017/04/27
 生成者:
 工程名称:AGC
 工程ID:0005
 模块中文名:项目菜单管理
 模块英文名:PrjMenu
 框架-层名:实体层
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2017.04.26.01
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
 /// 工程用户菜单(PrjUserMenus)
 /// (AutoGCLib.AutoGC6Cs_M:A_GenEntityLayerCode)
 /// </summary>
[Serializable]
public class clsPrjUserMenusEN : clsEntityBase2
{
public const string CurrTabName_S = "PrjUserMenus"; //当前表名,与该类相关的表名
public const string CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 8;
public static string[] AttributeName = new string[] {"mId", "PrjUserObjId", "GroupId", "MenuId", "LinkFile", "IsHaveSubMenu", "PrjId", "RoleId"};
//以下是属性变量

protected long mlngmId;    //mId
protected string mstrPrjUserObjId;    //PrjUserObjId
protected string mstrGroupId;    //GroupId
protected string mstrMenuId;    //菜单ID
protected string mstrLinkFile;    //链接文件名
protected bool mbolIsHaveSubMenu;    //IsHaveSubMenu
protected string mstrPrjId;    //工程ID
protected string mstrRoleId;    //角色ID


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_mId = "mId";    //mId

 /// <summary>
 /// 常量:"PrjUserObjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PrjUserObjId = "PrjUserObjId";    //PrjUserObjId

 /// <summary>
 /// 常量:"GroupId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_GroupId = "GroupId";    //GroupId

 /// <summary>
 /// 常量:"MenuId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_MenuId = "MenuId";    //菜单ID

 /// <summary>
 /// 常量:"LinkFile"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_LinkFile = "LinkFile";    //链接文件名

 /// <summary>
 /// 常量:"IsHaveSubMenu"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsHaveSubMenu = "IsHaveSubMenu";    //IsHaveSubMenu

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PrjId = "PrjId";    //工程ID

 /// <summary>
 /// 常量:"RoleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_RoleId = "RoleId";    //角色ID

/// <summary>
/// 构造函数
 /// (AutoGCLib.AutoGCPubFuncV6:GenClassConstructor1)
/// </summary>
 public clsPrjUserMenusEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "PrjUserMenus";
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.AutoGCPubFuncV6:GenClassConstructor2)
/// </summary>
/// <param name = "mlngmId">关键字:mId</param>
public clsPrjUserMenusEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "PrjUserMenus";
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
else if (strAttributeName  ==  con_PrjUserObjId)
{
return mstrPrjUserObjId;
}
else if (strAttributeName  ==  con_GroupId)
{
return mstrGroupId;
}
else if (strAttributeName  ==  con_MenuId)
{
return mstrMenuId;
}
else if (strAttributeName  ==  con_LinkFile)
{
return mstrLinkFile;
}
else if (strAttributeName  ==  con_IsHaveSubMenu)
{
return mbolIsHaveSubMenu;
}
else if (strAttributeName  ==  con_PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  con_RoleId)
{
return mstrRoleId;
}
return null;
}
set
{
if (strAttributeName  ==  con_mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(con_mId);
}
else if (strAttributeName  ==  con_PrjUserObjId)
{
mstrPrjUserObjId = value.ToString();
 AddUpdatedFld(con_PrjUserObjId);
}
else if (strAttributeName  ==  con_GroupId)
{
mstrGroupId = value.ToString();
 AddUpdatedFld(con_GroupId);
}
else if (strAttributeName  ==  con_MenuId)
{
mstrMenuId = value.ToString();
 AddUpdatedFld(con_MenuId);
}
else if (strAttributeName  ==  con_LinkFile)
{
mstrLinkFile = value.ToString();
 AddUpdatedFld(con_LinkFile);
}
else if (strAttributeName  ==  con_IsHaveSubMenu)
{
mbolIsHaveSubMenu = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsHaveSubMenu);
}
else if (strAttributeName  ==  con_PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(con_PrjId);
}
else if (strAttributeName  ==  con_RoleId)
{
mstrRoleId = value.ToString();
 AddUpdatedFld(con_RoleId);
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
else if (con_PrjUserObjId  ==  AttributeName[intIndex])
{
return mstrPrjUserObjId;
}
else if (con_GroupId  ==  AttributeName[intIndex])
{
return mstrGroupId;
}
else if (con_MenuId  ==  AttributeName[intIndex])
{
return mstrMenuId;
}
else if (con_LinkFile  ==  AttributeName[intIndex])
{
return mstrLinkFile;
}
else if (con_IsHaveSubMenu  ==  AttributeName[intIndex])
{
return mbolIsHaveSubMenu;
}
else if (con_PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
else if (con_RoleId  ==  AttributeName[intIndex])
{
return mstrRoleId;
}
return null;
}
set
{
if (con_mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(con_mId);
}
else if (con_PrjUserObjId  ==  AttributeName[intIndex])
{
mstrPrjUserObjId = value.ToString();
 AddUpdatedFld(con_PrjUserObjId);
}
else if (con_GroupId  ==  AttributeName[intIndex])
{
mstrGroupId = value.ToString();
 AddUpdatedFld(con_GroupId);
}
else if (con_MenuId  ==  AttributeName[intIndex])
{
mstrMenuId = value.ToString();
 AddUpdatedFld(con_MenuId);
}
else if (con_LinkFile  ==  AttributeName[intIndex])
{
mstrLinkFile = value.ToString();
 AddUpdatedFld(con_LinkFile);
}
else if (con_IsHaveSubMenu  ==  AttributeName[intIndex])
{
mbolIsHaveSubMenu = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsHaveSubMenu);
}
else if (con_PrjId  ==  AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(con_PrjId);
}
else if (con_RoleId  ==  AttributeName[intIndex])
{
mstrRoleId = value.ToString();
 AddUpdatedFld(con_RoleId);
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
 mlngmId = value;
//记录修改过的字段
 AddUpdatedFld(con_mId);
}
}
/// <summary>
/// PrjUserObjId(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string PrjUserObjId
{
get
{
return mstrPrjUserObjId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjUserObjId = value;
}
else
{
 mstrPrjUserObjId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_PrjUserObjId);
}
}
/// <summary>
/// GroupId(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string GroupId
{
get
{
return mstrGroupId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGroupId = value;
}
else
{
 mstrGroupId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_GroupId);
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
mintErrNo = 1;
 mstrMenuId = value;
}
else
{
 mstrMenuId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_MenuId);
}
}
/// <summary>
/// 链接文件名(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string LinkFile
{
get
{
return mstrLinkFile;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLinkFile = value;
}
else
{
 mstrLinkFile = value;
}
//记录修改过的字段
 AddUpdatedFld(con_LinkFile);
}
}
/// <summary>
/// IsHaveSubMenu(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public bool IsHaveSubMenu
{
get
{
return mbolIsHaveSubMenu;
}
set
{
 mbolIsHaveSubMenu = value;
//记录修改过的字段
 AddUpdatedFld(con_IsHaveSubMenu);
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
mintErrNo = 1;
 mstrRoleId = value;
}
else
{
 mstrRoleId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_RoleId);
}
}
}
}