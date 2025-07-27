
//类名:clsvPrjMenusEN
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
 /// vPrjMenus(vPrjMenus)
 /// (AGC.BusinessLogicEx.AutoGC6Cs_M:A_GenEntityLayerCode)
 /// </summary>
[Serializable]
public class clsvPrjMenusEN : clsEntityBase2
{
public const string CurrTabName_S = "vPrjMenus"; //当前表名,与该类相关的表名
public const string CurrTabKeyFldName_S = "MenuId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 21;
public static string[] AttributeName = new string[] {"MenuId", "MenuName", "OrderNum", "PrjId", "MenuSetName", "ImgFile", "LinkFile", "UpMenuName", "qsParameters", "PrjName", "RoleId", "UpMenuId", "RoleName", "IsLeafNode", "MenuSetId", "MenuTitle", "PageDispModeId", "PageDispModeName", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量

protected string mstrMenuId;    //菜单ID
protected string mstrMenuName;    //菜单名
protected int mintOrderNum;    //序号
protected string mstrPrjId;    //工程ID
protected string mstrMenuSetName;    //菜单集名称
protected string mstrImgFile;    //图像文件
protected string mstrLinkFile;    //链接文件名
protected string mstrUpMenuName;    //UpMenuName
protected string mstrqsParameters;    //qs参数
protected string mstrPrjName;    //工程名称
protected string mstrRoleId;    //角色ID
protected string mstrUpMenuId;    //上级菜单ID
protected string mstrRoleName;    //角色名称
protected bool mbolIsLeafNode;    //是否叶子
protected string mstrMenuSetId;    //菜单集Id
protected string mstrMenuTitle;    //菜单标题
protected string mstrPageDispModeId;    //页面显示模式Id
protected string mstrPageDispModeName;    //页面显示模式名称
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //说明


 /// <summary>
 /// 常量:"MenuId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_MenuId  =  "MenuId";    //菜单ID

 /// <summary>
 /// 常量:"MenuName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_MenuName  =  "MenuName";    //菜单名

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_OrderNum  =  "OrderNum";    //序号

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PrjId  =  "PrjId";    //工程ID

 /// <summary>
 /// 常量:"MenuSetName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_MenuSetName  =  "MenuSetName";    //菜单集名称

 /// <summary>
 /// 常量:"ImgFile"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ImgFile  =  "ImgFile";    //图像文件

 /// <summary>
 /// 常量:"LinkFile"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_LinkFile  =  "LinkFile";    //链接文件名

 /// <summary>
 /// 常量:"UpMenuName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpMenuName  =  "UpMenuName";    //UpMenuName

 /// <summary>
 /// 常量:"qsParameters"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_qsParameters  =  "qsParameters";    //qs参数

 /// <summary>
 /// 常量:"PrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PrjName  =  "PrjName";    //工程名称

 /// <summary>
 /// 常量:"RoleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_RoleId  =  "RoleId";    //角色ID

 /// <summary>
 /// 常量:"UpMenuId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpMenuId  =  "UpMenuId";    //上级菜单ID

 /// <summary>
 /// 常量:"RoleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_RoleName  =  "RoleName";    //角色名称

 /// <summary>
 /// 常量:"IsLeafNode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsLeafNode  =  "IsLeafNode";    //是否叶子

 /// <summary>
 /// 常量:"MenuSetId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_MenuSetId  =  "MenuSetId";    //菜单集Id

 /// <summary>
 /// 常量:"MenuTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_MenuTitle  =  "MenuTitle";    //菜单标题

 /// <summary>
 /// 常量:"PageDispModeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PageDispModeId  =  "PageDispModeId";    //页面显示模式Id

 /// <summary>
 /// 常量:"PageDispModeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PageDispModeName  =  "PageDispModeName";    //页面显示模式名称

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
 public clsvPrjMenusEN()
 {
 SetInit();
 mbolIsCheckProperty  =  false;
 _CurrTabName  =  "vPrjMenus";
 lstKeyFldNames.Add("MenuId");
 }

/// <summary>
/// 构造函数
 /// (AGC.BusinessLogicEx.AutoGCPubFuncV6:GenClassConstructor2)
/// </summary>
/// <param name = "mstrMenuId">关键字:菜单ID</param>
public clsvPrjMenusEN(string strMenuId)
 {
strMenuId  =  strMenuId.Replace("'", "''");
if (strMenuId.Length > 8)
{
throw new Exception("在表:vPrjMenus中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strMenuId)  ==  true)
{
throw new Exception("在表:vPrjMenus中,关键字不能为空 或 null!");
}
try
{
clsCommonRegular.CheckStrSQL_Weak(strMenuId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

mstrMenuId = strMenuId;
 SetInit();
 mbolIsCheckProperty  =  false;
 _CurrTabName  =  "vPrjMenus";
 lstKeyFldNames.Add("MenuId");
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
if (strAttributeName  ==  con_MenuId)
{
return mstrMenuId;
}
else if (strAttributeName  ==  con_MenuName)
{
return mstrMenuName;
}
else if (strAttributeName  ==  con_OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  con_PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  con_MenuSetName)
{
return mstrMenuSetName;
}
else if (strAttributeName  ==  con_ImgFile)
{
return mstrImgFile;
}
else if (strAttributeName  ==  con_LinkFile)
{
return mstrLinkFile;
}
else if (strAttributeName  ==  con_UpMenuName)
{
return mstrUpMenuName;
}
else if (strAttributeName  ==  con_qsParameters)
{
return mstrqsParameters;
}
else if (strAttributeName  ==  con_PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  con_RoleId)
{
return mstrRoleId;
}
else if (strAttributeName  ==  con_UpMenuId)
{
return mstrUpMenuId;
}
else if (strAttributeName  ==  con_RoleName)
{
return mstrRoleName;
}
else if (strAttributeName  ==  con_IsLeafNode)
{
return mbolIsLeafNode;
}
else if (strAttributeName  ==  con_MenuSetId)
{
return mstrMenuSetId;
}
else if (strAttributeName  ==  con_MenuTitle)
{
return mstrMenuTitle;
}
else if (strAttributeName  ==  con_PageDispModeId)
{
return mstrPageDispModeId;
}
else if (strAttributeName  ==  con_PageDispModeName)
{
return mstrPageDispModeName;
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
if (strAttributeName  ==  con_MenuId)
{
mstrMenuId  =  value.ToString();
 AddUpdatedFld(con_MenuId);
}
else if (strAttributeName  ==  con_MenuName)
{
mstrMenuName  =  value.ToString();
 AddUpdatedFld(con_MenuName);
}
else if (strAttributeName  ==  con_OrderNum)
{
mintOrderNum  =  TransNullToInt(value.ToString());
 AddUpdatedFld(con_OrderNum);
}
else if (strAttributeName  ==  con_PrjId)
{
mstrPrjId  =  value.ToString();
 AddUpdatedFld(con_PrjId);
}
else if (strAttributeName  ==  con_MenuSetName)
{
mstrMenuSetName  =  value.ToString();
 AddUpdatedFld(con_MenuSetName);
}
else if (strAttributeName  ==  con_ImgFile)
{
mstrImgFile  =  value.ToString();
 AddUpdatedFld(con_ImgFile);
}
else if (strAttributeName  ==  con_LinkFile)
{
mstrLinkFile  =  value.ToString();
 AddUpdatedFld(con_LinkFile);
}
else if (strAttributeName  ==  con_UpMenuName)
{
mstrUpMenuName  =  value.ToString();
 AddUpdatedFld(con_UpMenuName);
}
else if (strAttributeName  ==  con_qsParameters)
{
mstrqsParameters  =  value.ToString();
 AddUpdatedFld(con_qsParameters);
}
else if (strAttributeName  ==  con_PrjName)
{
mstrPrjName  =  value.ToString();
 AddUpdatedFld(con_PrjName);
}
else if (strAttributeName  ==  con_RoleId)
{
mstrRoleId  =  value.ToString();
 AddUpdatedFld(con_RoleId);
}
else if (strAttributeName  ==  con_UpMenuId)
{
mstrUpMenuId  =  value.ToString();
 AddUpdatedFld(con_UpMenuId);
}
else if (strAttributeName  ==  con_RoleName)
{
mstrRoleName  =  value.ToString();
 AddUpdatedFld(con_RoleName);
}
else if (strAttributeName  ==  con_IsLeafNode)
{
mbolIsLeafNode  =  TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsLeafNode);
}
else if (strAttributeName  ==  con_MenuSetId)
{
mstrMenuSetId  =  value.ToString();
 AddUpdatedFld(con_MenuSetId);
}
else if (strAttributeName  ==  con_MenuTitle)
{
mstrMenuTitle  =  value.ToString();
 AddUpdatedFld(con_MenuTitle);
}
else if (strAttributeName  ==  con_PageDispModeId)
{
mstrPageDispModeId  =  value.ToString();
 AddUpdatedFld(con_PageDispModeId);
}
else if (strAttributeName  ==  con_PageDispModeName)
{
mstrPageDispModeName  =  value.ToString();
 AddUpdatedFld(con_PageDispModeName);
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
if (con_MenuId  ==  AttributeName[intIndex])
{
return mstrMenuId;
}
else if (con_MenuName  ==  AttributeName[intIndex])
{
return mstrMenuName;
}
else if (con_OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (con_PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
else if (con_MenuSetName  ==  AttributeName[intIndex])
{
return mstrMenuSetName;
}
else if (con_ImgFile  ==  AttributeName[intIndex])
{
return mstrImgFile;
}
else if (con_LinkFile  ==  AttributeName[intIndex])
{
return mstrLinkFile;
}
else if (con_UpMenuName  ==  AttributeName[intIndex])
{
return mstrUpMenuName;
}
else if (con_qsParameters  ==  AttributeName[intIndex])
{
return mstrqsParameters;
}
else if (con_PrjName  ==  AttributeName[intIndex])
{
return mstrPrjName;
}
else if (con_RoleId  ==  AttributeName[intIndex])
{
return mstrRoleId;
}
else if (con_UpMenuId  ==  AttributeName[intIndex])
{
return mstrUpMenuId;
}
else if (con_RoleName  ==  AttributeName[intIndex])
{
return mstrRoleName;
}
else if (con_IsLeafNode  ==  AttributeName[intIndex])
{
return mbolIsLeafNode;
}
else if (con_MenuSetId  ==  AttributeName[intIndex])
{
return mstrMenuSetId;
}
else if (con_MenuTitle  ==  AttributeName[intIndex])
{
return mstrMenuTitle;
}
else if (con_PageDispModeId  ==  AttributeName[intIndex])
{
return mstrPageDispModeId;
}
else if (con_PageDispModeName  ==  AttributeName[intIndex])
{
return mstrPageDispModeName;
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
if (con_MenuId  ==  AttributeName[intIndex])
{
mstrMenuId  =  value.ToString();
 AddUpdatedFld(con_MenuId);
}
else if (con_MenuName  ==  AttributeName[intIndex])
{
mstrMenuName  =  value.ToString();
 AddUpdatedFld(con_MenuName);
}
else if (con_OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum  =  TransNullToInt(value.ToString());
 AddUpdatedFld(con_OrderNum);
}
else if (con_PrjId  ==  AttributeName[intIndex])
{
mstrPrjId  =  value.ToString();
 AddUpdatedFld(con_PrjId);
}
else if (con_MenuSetName  ==  AttributeName[intIndex])
{
mstrMenuSetName  =  value.ToString();
 AddUpdatedFld(con_MenuSetName);
}
else if (con_ImgFile  ==  AttributeName[intIndex])
{
mstrImgFile  =  value.ToString();
 AddUpdatedFld(con_ImgFile);
}
else if (con_LinkFile  ==  AttributeName[intIndex])
{
mstrLinkFile  =  value.ToString();
 AddUpdatedFld(con_LinkFile);
}
else if (con_UpMenuName  ==  AttributeName[intIndex])
{
mstrUpMenuName  =  value.ToString();
 AddUpdatedFld(con_UpMenuName);
}
else if (con_qsParameters  ==  AttributeName[intIndex])
{
mstrqsParameters  =  value.ToString();
 AddUpdatedFld(con_qsParameters);
}
else if (con_PrjName  ==  AttributeName[intIndex])
{
mstrPrjName  =  value.ToString();
 AddUpdatedFld(con_PrjName);
}
else if (con_RoleId  ==  AttributeName[intIndex])
{
mstrRoleId  =  value.ToString();
 AddUpdatedFld(con_RoleId);
}
else if (con_UpMenuId  ==  AttributeName[intIndex])
{
mstrUpMenuId  =  value.ToString();
 AddUpdatedFld(con_UpMenuId);
}
else if (con_RoleName  ==  AttributeName[intIndex])
{
mstrRoleName  =  value.ToString();
 AddUpdatedFld(con_RoleName);
}
else if (con_IsLeafNode  ==  AttributeName[intIndex])
{
mbolIsLeafNode  =  TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsLeafNode);
}
else if (con_MenuSetId  ==  AttributeName[intIndex])
{
mstrMenuSetId  =  value.ToString();
 AddUpdatedFld(con_MenuSetId);
}
else if (con_MenuTitle  ==  AttributeName[intIndex])
{
mstrMenuTitle  =  value.ToString();
 AddUpdatedFld(con_MenuTitle);
}
else if (con_PageDispModeId  ==  AttributeName[intIndex])
{
mstrPageDispModeId  =  value.ToString();
 AddUpdatedFld(con_PageDispModeId);
}
else if (con_PageDispModeName  ==  AttributeName[intIndex])
{
mstrPageDispModeName  =  value.ToString();
 AddUpdatedFld(con_PageDispModeName);
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
/// 菜单名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string MenuName
{
get
{
return mstrMenuName;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrMenuName  =  value;
}
else
{
 mstrMenuName  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_MenuName);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public int OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum  =  value;
//记录修改过的字段
 AddUpdatedFld(con_OrderNum);
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
/// 菜单集名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string MenuSetName
{
get
{
return mstrMenuSetName;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrMenuSetName  =  value;
}
else
{
 mstrMenuSetName  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_MenuSetName);
}
}
/// <summary>
/// 图像文件(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string ImgFile
{
get
{
return mstrImgFile;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrImgFile  =  value;
}
else
{
 mstrImgFile  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_ImgFile);
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
mintErrNo  =  1;
 mstrLinkFile  =  value;
}
else
{
 mstrLinkFile  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_LinkFile);
}
}
/// <summary>
/// UpMenuName(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string UpMenuName
{
get
{
return mstrUpMenuName;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrUpMenuName  =  value;
}
else
{
 mstrUpMenuName  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_UpMenuName);
}
}
/// <summary>
/// qs参数(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string qsParameters
{
get
{
return mstrqsParameters;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrqsParameters  =  value;
}
else
{
 mstrqsParameters  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_qsParameters);
}
}
/// <summary>
/// 工程名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
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
mintErrNo  =  1;
 mstrPrjName  =  value;
}
else
{
 mstrPrjName  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_PrjName);
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
/// 上级菜单ID(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string UpMenuId
{
get
{
return mstrUpMenuId;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrUpMenuId  =  value;
}
else
{
 mstrUpMenuId  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_UpMenuId);
}
}
/// <summary>
/// 角色名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string RoleName
{
get
{
return mstrRoleName;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrRoleName  =  value;
}
else
{
 mstrRoleName  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_RoleName);
}
}
/// <summary>
/// 是否叶子(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public bool IsLeafNode
{
get
{
return mbolIsLeafNode;
}
set
{
 mbolIsLeafNode  =  value;
//记录修改过的字段
 AddUpdatedFld(con_IsLeafNode);
}
}
/// <summary>
/// 菜单集Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string MenuSetId
{
get
{
return mstrMenuSetId;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrMenuSetId  =  value;
}
else
{
 mstrMenuSetId  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_MenuSetId);
}
}
/// <summary>
/// 菜单标题(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string MenuTitle
{
get
{
return mstrMenuTitle;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrMenuTitle  =  value;
}
else
{
 mstrMenuTitle  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_MenuTitle);
}
}
/// <summary>
/// 页面显示模式Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string PageDispModeId
{
get
{
return mstrPageDispModeId;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrPageDispModeId  =  value;
}
else
{
 mstrPageDispModeId  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_PageDispModeId);
}
}
/// <summary>
/// 页面显示模式名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string PageDispModeName
{
get
{
return mstrPageDispModeName;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrPageDispModeName  =  value;
}
else
{
 mstrPageDispModeName  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_PageDispModeName);
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