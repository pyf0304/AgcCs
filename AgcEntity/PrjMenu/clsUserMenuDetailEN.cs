
//类名:clsUserMenuDetailEN
 ///----------------------
 ///生成代码版本:2016.10.07.1
 ///生成日期:2017/01/09
 ///生成者:潘以锋
 ///工程名称:AGC_CSV7
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

namespace AGC_CSV7.Entity
{
 /// <summary>
 /// UserMenuDetail(UserMenuDetail)
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_M:A_GenEntityLayerCode)
 /// </summary>
[Serializable]
public class clsUserMenuDetailEN : clsEntityBase2
{
public const string CurrTabName_S = "UserMenuDetail"; //当前表名,与该类相关的表名
public const string CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 12;
public static string[] AttributeName = new string[] {"mId", "MenuId", "MenuName", "IsDisp", "UpMenuId", "LinkFile", "IsCustomMenu", "UserId", "PrjId", "Memo", "ImgFile", "OrderNum"};
//以下是属性变量

protected long mlngmId;    //mId
protected string mstrMenuId;    //菜单ID
protected string mstrMenuName;    //菜单名
protected bool mbolIsDisp;    //是否显示
protected string mstrUpMenuId;    //上级菜单ID
protected string mstrLinkFile;    //链接文件名
protected bool mbolIsCustomMenu;    //是否定制菜单
protected string mstrUserId;    //用户ID
protected string mstrPrjId;    //工程ID
protected string mstrMemo;    //说明
protected string mstrImgFile;    //图像文件
protected int mintOrderNum;    //序号


 /// <summary>
 /// 常量:"mId"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_mId  =  "mId";    //mId

 /// <summary>
 /// 常量:"MenuId"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_MenuId  =  "MenuId";    //菜单ID

 /// <summary>
 /// 常量:"MenuName"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_MenuName  =  "MenuName";    //菜单名

 /// <summary>
 /// 常量:"IsDisp"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsDisp  =  "IsDisp";    //是否显示

 /// <summary>
 /// 常量:"UpMenuId"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpMenuId  =  "UpMenuId";    //上级菜单ID

 /// <summary>
 /// 常量:"LinkFile"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_LinkFile  =  "LinkFile";    //链接文件名

 /// <summary>
 /// 常量:"IsCustomMenu"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsCustomMenu  =  "IsCustomMenu";    //是否定制菜单

 /// <summary>
 /// 常量:"UserId"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UserId  =  "UserId";    //用户ID

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PrjId  =  "PrjId";    //工程ID

 /// <summary>
 /// 常量:"Memo"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo  =  "Memo";    //说明

 /// <summary>
 /// 常量:"ImgFile"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ImgFile  =  "ImgFile";    //图像文件

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_OrderNum  =  "OrderNum";    //序号

/// <summary>
/// 构造函数
 /// (AGC_CSV7.BusinessLogicEx.AutoGCPubFuncV6:GenClassConstructor1)
/// </summary>
 public clsUserMenuDetailEN()
 {
 SetInit();
 mbolIsCheckProperty  =  false;
 CurrTabName  =  "UserMenuDetail";
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AGC_CSV7.BusinessLogicEx.AutoGCPubFuncV6:GenClassConstructor2)
/// </summary>
/// <param name = "mlngmId">关键字:mId</param>
public clsUserMenuDetailEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty  =  false;
 CurrTabName  =  "UserMenuDetail";
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
else if (strAttributeName  ==  con_MenuId)
{
return mstrMenuId;
}
else if (strAttributeName  ==  con_MenuName)
{
return mstrMenuName;
}
else if (strAttributeName  ==  con_IsDisp)
{
return mbolIsDisp;
}
else if (strAttributeName  ==  con_UpMenuId)
{
return mstrUpMenuId;
}
else if (strAttributeName  ==  con_LinkFile)
{
return mstrLinkFile;
}
else if (strAttributeName  ==  con_IsCustomMenu)
{
return mbolIsCustomMenu;
}
else if (strAttributeName  ==  con_UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  con_PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  con_Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  con_ImgFile)
{
return mstrImgFile;
}
else if (strAttributeName  ==  con_OrderNum)
{
return mintOrderNum;
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
else if (strAttributeName  ==  con_MenuId)
{
mstrMenuId  =  value.ToString();
 AddUpdatedFld(con_MenuId);
}
else if (strAttributeName  ==  con_MenuName)
{
mstrMenuName  =  value.ToString();
 AddUpdatedFld(con_MenuName);
}
else if (strAttributeName  ==  con_IsDisp)
{
mbolIsDisp  =  TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsDisp);
}
else if (strAttributeName  ==  con_UpMenuId)
{
mstrUpMenuId  =  value.ToString();
 AddUpdatedFld(con_UpMenuId);
}
else if (strAttributeName  ==  con_LinkFile)
{
mstrLinkFile  =  value.ToString();
 AddUpdatedFld(con_LinkFile);
}
else if (strAttributeName  ==  con_IsCustomMenu)
{
mbolIsCustomMenu  =  TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsCustomMenu);
}
else if (strAttributeName  ==  con_UserId)
{
mstrUserId  =  value.ToString();
 AddUpdatedFld(con_UserId);
}
else if (strAttributeName  ==  con_PrjId)
{
mstrPrjId  =  value.ToString();
 AddUpdatedFld(con_PrjId);
}
else if (strAttributeName  ==  con_Memo)
{
mstrMemo  =  value.ToString();
 AddUpdatedFld(con_Memo);
}
else if (strAttributeName  ==  con_ImgFile)
{
mstrImgFile  =  value.ToString();
 AddUpdatedFld(con_ImgFile);
}
else if (strAttributeName  ==  con_OrderNum)
{
mintOrderNum  =  TransNullToInt(value.ToString());
 AddUpdatedFld(con_OrderNum);
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
else if (con_MenuId  ==  AttributeName[intIndex])
{
return mstrMenuId;
}
else if (con_MenuName  ==  AttributeName[intIndex])
{
return mstrMenuName;
}
else if (con_IsDisp  ==  AttributeName[intIndex])
{
return mbolIsDisp;
}
else if (con_UpMenuId  ==  AttributeName[intIndex])
{
return mstrUpMenuId;
}
else if (con_LinkFile  ==  AttributeName[intIndex])
{
return mstrLinkFile;
}
else if (con_IsCustomMenu  ==  AttributeName[intIndex])
{
return mbolIsCustomMenu;
}
else if (con_UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (con_PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
else if (con_Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (con_ImgFile  ==  AttributeName[intIndex])
{
return mstrImgFile;
}
else if (con_OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
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
else if (con_MenuId  ==  AttributeName[intIndex])
{
mstrMenuId  =  value.ToString();
 AddUpdatedFld(con_MenuId);
}
else if (con_MenuName  ==  AttributeName[intIndex])
{
mstrMenuName  =  value.ToString();
 AddUpdatedFld(con_MenuName);
}
else if (con_IsDisp  ==  AttributeName[intIndex])
{
mbolIsDisp  =  TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsDisp);
}
else if (con_UpMenuId  ==  AttributeName[intIndex])
{
mstrUpMenuId  =  value.ToString();
 AddUpdatedFld(con_UpMenuId);
}
else if (con_LinkFile  ==  AttributeName[intIndex])
{
mstrLinkFile  =  value.ToString();
 AddUpdatedFld(con_LinkFile);
}
else if (con_IsCustomMenu  ==  AttributeName[intIndex])
{
mbolIsCustomMenu  =  TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsCustomMenu);
}
else if (con_UserId  ==  AttributeName[intIndex])
{
mstrUserId  =  value.ToString();
 AddUpdatedFld(con_UserId);
}
else if (con_PrjId  ==  AttributeName[intIndex])
{
mstrPrjId  =  value.ToString();
 AddUpdatedFld(con_PrjId);
}
else if (con_Memo  ==  AttributeName[intIndex])
{
mstrMemo  =  value.ToString();
 AddUpdatedFld(con_Memo);
}
else if (con_ImgFile  ==  AttributeName[intIndex])
{
mstrImgFile  =  value.ToString();
 AddUpdatedFld(con_ImgFile);
}
else if (con_OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum  =  TransNullToInt(value.ToString());
 AddUpdatedFld(con_OrderNum);
}
}
}

/// <summary>
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
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
/// 菜单ID(说明:;字段类型:varchar;字段长度:8;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
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
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
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
/// 是否显示(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
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
/// 上级菜单ID(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
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
/// 链接文件名(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
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
/// 是否定制菜单(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public bool IsCustomMenu
{
get
{
return mbolIsCustomMenu;
}
set
{
 mbolIsCustomMenu  =  value;
//记录修改过的字段
 AddUpdatedFld(con_IsCustomMenu);
}
}
/// <summary>
/// 用户ID(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
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
mintErrNo  =  1;
 mstrUserId  =  value;
}
else
{
 mstrUserId  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_UserId);
}
}
/// <summary>
/// 工程ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
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
/// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
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
/// <summary>
/// 图像文件(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
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
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
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
}
}