
//类名:clsUserGroupsEN
 ///----------------------
 ///生成代码版本:2016.10.07.1
 ///生成日期:2017/01/09
 ///生成者:潘以锋
 ///工程名称:AGC
 ///工程ID:0005
 ///模块中文名:用户管理
 ///模块英文名:UserManage
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
 /// UserGroups(UserGroups)
 /// (AGC.BusinessLogicEx.AutoGC6Cs_M:A_GenEntityLayerCode)
 /// </summary>
[Serializable]
public class clsUserGroupsEN : clsEntityBase2
{
public const string CurrTabName_S = "UserGroups"; //当前表名,与该类相关的表名
public const string CurrTabKeyFldName_S = "GroupId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"GroupId", "GroupName", "PrjId", "Memo"};
//以下是属性变量

protected string mstrGroupId;    //GroupId
protected string mstrGroupName;    //组名
protected string mstrPrjId;    //工程ID
protected string mstrMemo;    //说明


 /// <summary>
 /// 常量:"GroupId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_GroupId  =  "GroupId";    //GroupId

 /// <summary>
 /// 常量:"GroupName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_GroupName  =  "GroupName";    //组名

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PrjId  =  "PrjId";    //工程ID

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo  =  "Memo";    //说明

/// <summary>
/// 构造函数
 /// (AGC.BusinessLogicEx.AutoGCPubFuncV6:GenClassConstructor1)
/// </summary>
 public clsUserGroupsEN()
 {
 SetInit();
 mbolIsCheckProperty  =  false;
 _CurrTabName  =  "UserGroups";
 lstKeyFldNames.Add("GroupId");
 }

/// <summary>
/// 构造函数
 /// (AGC.BusinessLogicEx.AutoGCPubFuncV6:GenClassConstructor2)
/// </summary>
/// <param name = "mstrGroupId">关键字:GroupId</param>
public clsUserGroupsEN(string strGroupId)
 {
strGroupId  =  strGroupId.Replace("'", "''");
if (strGroupId.Length > 8)
{
throw new Exception("在表:UserGroups中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strGroupId)  ==  true)
{
throw new Exception("在表:UserGroups中,关键字不能为空 或 null!");
}
try
{
clsCommonRegular.CheckStrSQL_Weak(strGroupId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

mstrGroupId = strGroupId;
 SetInit();
 mbolIsCheckProperty  =  false;
 _CurrTabName  =  "UserGroups";
 lstKeyFldNames.Add("GroupId");
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
if (strAttributeName  ==  con_GroupId)
{
return mstrGroupId;
}
else if (strAttributeName  ==  con_GroupName)
{
return mstrGroupName;
}
else if (strAttributeName  ==  con_PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  con_Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  con_GroupId)
{
mstrGroupId  =  value.ToString();
 AddUpdatedFld(con_GroupId);
}
else if (strAttributeName  ==  con_GroupName)
{
mstrGroupName  =  value.ToString();
 AddUpdatedFld(con_GroupName);
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
}
}
public object this[int intIndex]
{
get
{
if (con_GroupId  ==  AttributeName[intIndex])
{
return mstrGroupId;
}
else if (con_GroupName  ==  AttributeName[intIndex])
{
return mstrGroupName;
}
else if (con_PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
else if (con_Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (con_GroupId  ==  AttributeName[intIndex])
{
mstrGroupId  =  value.ToString();
 AddUpdatedFld(con_GroupId);
}
else if (con_GroupName  ==  AttributeName[intIndex])
{
mstrGroupName  =  value.ToString();
 AddUpdatedFld(con_GroupName);
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
mintErrNo  =  1;
 mstrGroupId  =  value;
}
else
{
 mstrGroupId  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_GroupId);
}
}
/// <summary>
/// 组名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string GroupName
{
get
{
return mstrGroupName;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrGroupName  =  value;
}
else
{
 mstrGroupName  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_GroupName);
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