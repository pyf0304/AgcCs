
//类名:clsViewPotenceEN
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
 /// 界面权限(ViewPotence)
 /// (AGC.BusinessLogicEx.AutoGC6Cs_M:A_GenEntityLayerCode)
 /// </summary>
[Serializable]
public class clsViewPotenceEN : clsEntityBase2
{
public const string CurrTabName_S = "ViewPotence"; //当前表名,与该类相关的表名
public const string CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 6;
public static string[] AttributeName = new string[] {"mId", "PrjId", "PotenceId", "Level", "Memo", "ViewId"};
//以下是属性变量

protected long mlngmId;    //mId
protected string mstrPrjId;    //工程ID
protected string mstrPotenceId;    //PotenceId
protected int mintLevel;    //Level
protected string mstrMemo;    //说明
protected string mstrViewId;    //界面ID


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_mId  =  "mId";    //mId

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PrjId  =  "PrjId";    //工程ID

 /// <summary>
 /// 常量:"PotenceId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PotenceId  =  "PotenceId";    //PotenceId

 /// <summary>
 /// 常量:"Level"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Level  =  "Level";    //Level

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo  =  "Memo";    //说明

 /// <summary>
 /// 常量:"ViewId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ViewId  =  "ViewId";    //界面ID

/// <summary>
/// 构造函数
 /// (AGC.BusinessLogicEx.AutoGCPubFuncV6:GenClassConstructor1)
/// </summary>
 public clsViewPotenceEN()
 {
 SetInit();
 mbolIsCheckProperty  =  false;
 _CurrTabName  =  "ViewPotence";
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AGC.BusinessLogicEx.AutoGCPubFuncV6:GenClassConstructor2)
/// </summary>
/// <param name = "mlngmId">关键字:mId</param>
public clsViewPotenceEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty  =  false;
 _CurrTabName  =  "ViewPotence";
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
else if (strAttributeName  ==  con_PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  con_PotenceId)
{
return mstrPotenceId;
}
else if (strAttributeName  ==  con_Level)
{
return mintLevel;
}
else if (strAttributeName  ==  con_Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  con_ViewId)
{
return mstrViewId;
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
else if (strAttributeName  ==  con_PrjId)
{
mstrPrjId  =  value.ToString();
 AddUpdatedFld(con_PrjId);
}
else if (strAttributeName  ==  con_PotenceId)
{
mstrPotenceId  =  value.ToString();
 AddUpdatedFld(con_PotenceId);
}
else if (strAttributeName  ==  con_Level)
{
mintLevel  =  TransNullToInt(value.ToString());
 AddUpdatedFld(con_Level);
}
else if (strAttributeName  ==  con_Memo)
{
mstrMemo  =  value.ToString();
 AddUpdatedFld(con_Memo);
}
else if (strAttributeName  ==  con_ViewId)
{
mstrViewId  =  value.ToString();
 AddUpdatedFld(con_ViewId);
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
else if (con_PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
else if (con_PotenceId  ==  AttributeName[intIndex])
{
return mstrPotenceId;
}
else if (con_Level  ==  AttributeName[intIndex])
{
return mintLevel;
}
else if (con_Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (con_ViewId  ==  AttributeName[intIndex])
{
return mstrViewId;
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
else if (con_PrjId  ==  AttributeName[intIndex])
{
mstrPrjId  =  value.ToString();
 AddUpdatedFld(con_PrjId);
}
else if (con_PotenceId  ==  AttributeName[intIndex])
{
mstrPotenceId  =  value.ToString();
 AddUpdatedFld(con_PotenceId);
}
else if (con_Level  ==  AttributeName[intIndex])
{
mintLevel  =  TransNullToInt(value.ToString());
 AddUpdatedFld(con_Level);
}
else if (con_Memo  ==  AttributeName[intIndex])
{
mstrMemo  =  value.ToString();
 AddUpdatedFld(con_Memo);
}
else if (con_ViewId  ==  AttributeName[intIndex])
{
mstrViewId  =  value.ToString();
 AddUpdatedFld(con_ViewId);
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
/// Level(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public int Level
{
get
{
return mintLevel;
}
set
{
 mintLevel  =  value;
//记录修改过的字段
 AddUpdatedFld(con_Level);
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
/// <summary>
/// 界面ID(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string ViewId
{
get
{
return mstrViewId;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrViewId  =  value;
}
else
{
 mstrViewId  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_ViewId);
}
}
}
}