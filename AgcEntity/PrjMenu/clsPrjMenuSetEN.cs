
//类名:clsPrjMenuSetEN
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
 /// 菜单集(PrjMenuSet)
 /// (AGC.BusinessLogicEx.AutoGC6Cs_M:A_GenEntityLayerCode)
 /// </summary>
[Serializable]
public class clsPrjMenuSetEN : clsEntityBase2
{
public const string CurrTabName_S = "PrjMenuSet"; //当前表名,与该类相关的表名
public const string CurrTabKeyFldName_S = "MenuSetId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"MenuSetId", "MenuSetName", "PrjId", "IsDefault", "Memo"};
//以下是属性变量

protected string mstrMenuSetId;    //菜单集Id
protected string mstrMenuSetName;    //菜单集名称
protected string mstrPrjId;    //工程ID
protected bool mbolIsDefault;    //是否默认
protected string mstrMemo;    //说明


 /// <summary>
 /// 常量:"MenuSetId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_MenuSetId  =  "MenuSetId";    //菜单集Id

 /// <summary>
 /// 常量:"MenuSetName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_MenuSetName  =  "MenuSetName";    //菜单集名称

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PrjId  =  "PrjId";    //工程ID

 /// <summary>
 /// 常量:"IsDefault"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsDefault  =  "IsDefault";    //是否默认

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo  =  "Memo";    //说明

/// <summary>
/// 构造函数
 /// (AGC.BusinessLogicEx.AutoGCPubFuncV6:GenClassConstructor1)
/// </summary>
 public clsPrjMenuSetEN()
 {
 SetInit();
 mbolIsCheckProperty  =  false;
 _CurrTabName  =  "PrjMenuSet";
 lstKeyFldNames.Add("MenuSetId");
 }

/// <summary>
/// 构造函数
 /// (AGC.BusinessLogicEx.AutoGCPubFuncV6:GenClassConstructor2)
/// </summary>
/// <param name = "mstrMenuSetId">关键字:菜单集Id</param>
public clsPrjMenuSetEN(string strMenuSetId)
 {
strMenuSetId  =  strMenuSetId.Replace("'", "''");
if (strMenuSetId.Length > 4)
{
throw new Exception("在表:PrjMenuSet中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strMenuSetId)  ==  true)
{
throw new Exception("在表:PrjMenuSet中,关键字不能为空 或 null!");
}
try
{
clsCommonRegular.CheckStrSQL_Weak(strMenuSetId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

mstrMenuSetId = strMenuSetId;
 SetInit();
 mbolIsCheckProperty  =  false;
 _CurrTabName  =  "PrjMenuSet";
 lstKeyFldNames.Add("MenuSetId");
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
if (strAttributeName  ==  con_MenuSetId)
{
return mstrMenuSetId;
}
else if (strAttributeName  ==  con_MenuSetName)
{
return mstrMenuSetName;
}
else if (strAttributeName  ==  con_PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  con_IsDefault)
{
return mbolIsDefault;
}
else if (strAttributeName  ==  con_Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  con_MenuSetId)
{
mstrMenuSetId  =  value.ToString();
 AddUpdatedFld(con_MenuSetId);
}
else if (strAttributeName  ==  con_MenuSetName)
{
mstrMenuSetName  =  value.ToString();
 AddUpdatedFld(con_MenuSetName);
}
else if (strAttributeName  ==  con_PrjId)
{
mstrPrjId  =  value.ToString();
 AddUpdatedFld(con_PrjId);
}
else if (strAttributeName  ==  con_IsDefault)
{
mbolIsDefault  =  TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsDefault);
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
if (con_MenuSetId  ==  AttributeName[intIndex])
{
return mstrMenuSetId;
}
else if (con_MenuSetName  ==  AttributeName[intIndex])
{
return mstrMenuSetName;
}
else if (con_PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
else if (con_IsDefault  ==  AttributeName[intIndex])
{
return mbolIsDefault;
}
else if (con_Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (con_MenuSetId  ==  AttributeName[intIndex])
{
mstrMenuSetId  =  value.ToString();
 AddUpdatedFld(con_MenuSetId);
}
else if (con_MenuSetName  ==  AttributeName[intIndex])
{
mstrMenuSetName  =  value.ToString();
 AddUpdatedFld(con_MenuSetName);
}
else if (con_PrjId  ==  AttributeName[intIndex])
{
mstrPrjId  =  value.ToString();
 AddUpdatedFld(con_PrjId);
}
else if (con_IsDefault  ==  AttributeName[intIndex])
{
mbolIsDefault  =  TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsDefault);
}
else if (con_Memo  ==  AttributeName[intIndex])
{
mstrMemo  =  value.ToString();
 AddUpdatedFld(con_Memo);
}
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
/// 是否默认(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public bool IsDefault
{
get
{
return mbolIsDefault;
}
set
{
 mbolIsDefault  =  value;
//记录修改过的字段
 AddUpdatedFld(con_IsDefault);
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