
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPotenceFLEN
 表名:PotenceFL
 生成代码版本:2017.04.27.1
 生成日期:2017/04/27
 生成者:
 工程名称:AGC
 工程ID:0005
 模块中文名:权限管理
 模块英文名:AuthorityManage
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
 /// PotenceFL(PotenceFL)
 /// (AutoGCLib.AutoGC6Cs_M:A_GenEntityLayerCode)
 /// </summary>
[Serializable]
public class clsPotenceFLEN : clsEntityBase2
{
public const string CurrTabName_S = "PotenceFL"; //当前表名,与该类相关的表名
public const string CurrTabKeyFldName_S = "FLM"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"FLM", "FLMC", "PrjId"};
//以下是属性变量

protected string mstrFLM;    //FLM
protected string mstrFLMC;    //FLMC
protected string mstrPrjId;    //工程ID


 /// <summary>
 /// 常量:"FLM"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_FLM = "FLM";    //FLM

 /// <summary>
 /// 常量:"FLMC"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_FLMC = "FLMC";    //FLMC

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PrjId = "PrjId";    //工程ID

/// <summary>
/// 构造函数
 /// (AutoGCLib.AutoGCPubFuncV6:GenClassConstructor1)
/// </summary>
 public clsPotenceFLEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "PotenceFL";
 lstKeyFldNames.Add("FLM");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.AutoGCPubFuncV6:GenClassConstructor2)
/// </summary>
/// <param name = "mstrFLM">关键字:FLM</param>
public clsPotenceFLEN(string strFLM)
 {
strFLM = strFLM.Replace("'", "''");
if (strFLM.Length > 6)
{
throw new Exception("在表:PotenceFL中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strFLM)  ==  true)
{
throw new Exception("在表:PotenceFL中,关键字不能为空 或 null!");
}
try
{
clsCommonRegular.CheckStrSQL_Weak(strFLM);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

mstrFLM = strFLM;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "PotenceFL";
 lstKeyFldNames.Add("FLM");
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
if (strAttributeName  ==  con_FLM)
{
return mstrFLM;
}
else if (strAttributeName  ==  con_FLMC)
{
return mstrFLMC;
}
else if (strAttributeName  ==  con_PrjId)
{
return mstrPrjId;
}
return null;
}
set
{
if (strAttributeName  ==  con_FLM)
{
mstrFLM = value.ToString();
 AddUpdatedFld(con_FLM);
}
else if (strAttributeName  ==  con_FLMC)
{
mstrFLMC = value.ToString();
 AddUpdatedFld(con_FLMC);
}
else if (strAttributeName  ==  con_PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(con_PrjId);
}
}
}
public object this[int intIndex]
{
get
{
if (con_FLM  ==  AttributeName[intIndex])
{
return mstrFLM;
}
else if (con_FLMC  ==  AttributeName[intIndex])
{
return mstrFLMC;
}
else if (con_PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
return null;
}
set
{
if (con_FLM  ==  AttributeName[intIndex])
{
mstrFLM = value.ToString();
 AddUpdatedFld(con_FLM);
}
else if (con_FLMC  ==  AttributeName[intIndex])
{
mstrFLMC = value.ToString();
 AddUpdatedFld(con_FLMC);
}
else if (con_PrjId  ==  AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(con_PrjId);
}
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
mintErrNo = 1;
 mstrFLM = value;
}
else
{
 mstrFLM = value;
}
//记录修改过的字段
 AddUpdatedFld(con_FLM);
}
}
/// <summary>
/// FLMC(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string FLMC
{
get
{
return mstrFLMC;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFLMC = value;
}
else
{
 mstrFLMC = value;
}
//记录修改过的字段
 AddUpdatedFld(con_FLMC);
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
}
}