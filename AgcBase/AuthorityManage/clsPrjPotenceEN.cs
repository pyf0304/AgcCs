
//类名:clsPrjPotenceEN
 ///----------------------
 ///生成代码版本:2016.10.07.1
 ///生成日期:2017/01/09
 ///生成者:潘以锋
 ///工程名称:AGC
 ///工程ID:0005
 ///模块中文名:权限管理
 ///模块英文名:AuthorityManage
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
 /// 工程权限(PrjPotence)
 /// (AGC.BusinessLogicEx.AutoGC6Cs_M:A_GenEntityLayerCode)
 /// </summary>
[Serializable]
public class clsPrjPotenceEN : clsEntityBase2
{
public const string CurrTabName_S = "PrjPotence"; //当前表名,与该类相关的表名
public const string CurrTabKeyFldName_S = "PotenceId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"PotenceId", "PotenceName", "PrjId", "FLM", "Memo"};
//以下是属性变量

protected string mstrPotenceId;    //PotenceId
protected string mstrPotenceName;    //PotenceName
protected string mstrPrjId;    //工程ID
protected string mstrFLM;    //FLM
protected string mstrMemo;    //说明


 /// <summary>
 /// 常量:"PotenceId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PotenceId  =  "PotenceId";    //PotenceId

 /// <summary>
 /// 常量:"PotenceName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PotenceName  =  "PotenceName";    //PotenceName

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PrjId  =  "PrjId";    //工程ID

 /// <summary>
 /// 常量:"FLM"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_FLM  =  "FLM";    //FLM

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo  =  "Memo";    //说明

/// <summary>
/// 构造函数
 /// (AGC.BusinessLogicEx.AutoGCPubFuncV6:GenClassConstructor1)
/// </summary>
 public clsPrjPotenceEN()
 {
 SetInit();
 mbolIsCheckProperty  =  false;
 _CurrTabName  =  "PrjPotence";
 lstKeyFldNames.Add("PotenceId");
 }

/// <summary>
/// 构造函数
 /// (AGC.BusinessLogicEx.AutoGCPubFuncV6:GenClassConstructor2)
/// </summary>
/// <param name = "mstrPotenceId">关键字:PotenceId</param>
public clsPrjPotenceEN(string strPotenceId)
 {
strPotenceId  =  strPotenceId.Replace("'", "''");
if (strPotenceId.Length > 8)
{
throw new Exception("在表:PrjPotence中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strPotenceId)  ==  true)
{
throw new Exception("在表:PrjPotence中,关键字不能为空 或 null!");
}
try
{
clsCommonRegular.CheckStrSQL_Weak(strPotenceId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

mstrPotenceId = strPotenceId;
 SetInit();
 mbolIsCheckProperty  =  false;
 _CurrTabName  =  "PrjPotence";
 lstKeyFldNames.Add("PotenceId");
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
if (strAttributeName  ==  con_PotenceId)
{
return mstrPotenceId;
}
else if (strAttributeName  ==  con_PotenceName)
{
return mstrPotenceName;
}
else if (strAttributeName  ==  con_PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  con_FLM)
{
return mstrFLM;
}
else if (strAttributeName  ==  con_Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  con_PotenceId)
{
mstrPotenceId  =  value.ToString();
 AddUpdatedFld(con_PotenceId);
}
else if (strAttributeName  ==  con_PotenceName)
{
mstrPotenceName  =  value.ToString();
 AddUpdatedFld(con_PotenceName);
}
else if (strAttributeName  ==  con_PrjId)
{
mstrPrjId  =  value.ToString();
 AddUpdatedFld(con_PrjId);
}
else if (strAttributeName  ==  con_FLM)
{
mstrFLM  =  value.ToString();
 AddUpdatedFld(con_FLM);
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
if (con_PotenceId  ==  AttributeName[intIndex])
{
return mstrPotenceId;
}
else if (con_PotenceName  ==  AttributeName[intIndex])
{
return mstrPotenceName;
}
else if (con_PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
else if (con_FLM  ==  AttributeName[intIndex])
{
return mstrFLM;
}
else if (con_Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (con_PotenceId  ==  AttributeName[intIndex])
{
mstrPotenceId  =  value.ToString();
 AddUpdatedFld(con_PotenceId);
}
else if (con_PotenceName  ==  AttributeName[intIndex])
{
mstrPotenceName  =  value.ToString();
 AddUpdatedFld(con_PotenceName);
}
else if (con_PrjId  ==  AttributeName[intIndex])
{
mstrPrjId  =  value.ToString();
 AddUpdatedFld(con_PrjId);
}
else if (con_FLM  ==  AttributeName[intIndex])
{
mstrFLM  =  value.ToString();
 AddUpdatedFld(con_FLM);
}
else if (con_Memo  ==  AttributeName[intIndex])
{
mstrMemo  =  value.ToString();
 AddUpdatedFld(con_Memo);
}
}
}

/// <summary>
/// PotenceId(说明:;字段类型:varchar;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string PotenceId
{
get
{
return mstrPotenceId;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrPotenceId  =  value;
}
else
{
 mstrPotenceId  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_PotenceId);
}
}
/// <summary>
/// PotenceName(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string PotenceName
{
get
{
return mstrPotenceName;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrPotenceName  =  value;
}
else
{
 mstrPotenceName  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_PotenceName);
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
/// FLM(说明:;字段类型:varchar;字段长度:6;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string FLM
{
get
{
return mstrFLM;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrFLM  =  value;
}
else
{
 mstrFLM  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_FLM);
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