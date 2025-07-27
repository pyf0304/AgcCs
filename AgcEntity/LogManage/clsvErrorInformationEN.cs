
 ///----------------------
 ///生成代码版本:2016.06.03.1
 ///生成日期:2016/06/03
 ///生成者:潘文韬
 ///工程名称:养老服务平台
 ///工程ID:0167
 ///模块中文名:日志管理
 ///模块英文名:LogManage
 ///注意:1、需要数据底层(PubDataBase.dll)的版本:2016.05.23.01
 ///       2、需要公共函数层(TzPubFunction.dll)的版本:2016.05.23.01
 ///========================
using System;
using System.Text; 
using System.Collections; 
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;

namespace PensionSrv.Entity
{
 /// <summary>
 /// vErrorInformation(vErrorInformation)
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_M:A_GenEntityLayerCode)
 /// </summary>
[Serializable]
public class clsvErrorInformationEN : clsEntityBase2
{
public const string CurrTabName_S = "vErrorInformation"; //当前表名,与该类相关的表名
public const string CurrTabKeyFldName_S = "ErrorID"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 6;
public static string[] AttributeName = new string[] {"ErrorID", "PageName", "FunctionName", "ErrorInformation", "UserId", "CreateTime"};
 //以下是属性变量

protected long mlngErrorID;    //错误流水号
protected string mstrPageName;    //页面名称
protected string mstrFunctionName;    //功能名称
protected string mstrErrorInformation;    //错误信息
protected string mstrUserId;    //用户账号
protected DateTime mdteCreateTime;    //创建时间
protected int mintIntTag;    //整型Tag
protected string mstrStrTag;    //字符型标签
protected bool mbolIsCheckProperty;    //是否检查属性


 /// <summary>
 /// 常量:"ErrorID"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ErrorID = "ErrorID";    //错误流水号

 /// <summary>
 /// 常量:"PageName"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PageName = "PageName";    //页面名称

 /// <summary>
 /// 常量:"FunctionName"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_FunctionName = "FunctionName";    //功能名称

 /// <summary>
 /// 常量:"ErrorInformation"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ErrorInformation = "ErrorInformation";    //错误信息

 /// <summary>
 /// 常量:"UserId"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UserId = "UserId";    //用户账号

 /// <summary>
 /// 常量:"CreateTime"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_CreateTime = "CreateTime";    //创建时间

 /// <summary>
 /// 常量:"IntTag"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IntTag = "IntTag";    //整型Tag

 /// <summary>
 /// 常量:"StrTag"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_StrTag = "StrTag";    //字符型标签

 /// <summary>
 /// 常量:"IsCheckProperty"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsCheckProperty = "IsCheckProperty";    //是否检查属性

//用户指定的连接串,如果用户不指定该连接串,就用PUBDATABASE中所指定的连接串
private static string m_strConnectString;
 /// <summary>
 /// 当前所使用的连接串内容
 /// (AGC_CSV7.BusinessLogicEx.AutoGCPubFuncV6:GenConnectString)
 /// </summary>
public static string ConnectString
{
get { return m_strConnectString; }
set { m_strConnectString = value; }
}

/// <summary>
/// 构造函数
 /// (AGC_CSV7.BusinessLogicEx.AutoGCPubFuncV6:GenClassConstructor1)
/// </summary>
 public clsvErrorInformationEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 CurrTabName = "vErrorInformation";
 lstKeyFldNames.Add("ErrorID");
 }

/// <summary>
/// 构造函数
 /// (AGC_CSV7.BusinessLogicEx.AutoGCPubFuncV6:GenClassConstructor2)
/// </summary>
/// <param name="mlngErrorID">关键字：错误流水号</param>
public clsvErrorInformationEN(long lngErrorID)
 {
 if (lngErrorID == 0)
 {
 throw new Exception("关键字不能为0!");
 }

mlngErrorID=lngErrorID;
 SetInit();
 mbolIsCheckProperty = false;
 CurrTabName = "vErrorInformation";
 lstKeyFldNames.Add("ErrorID");
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
if (strAttributeName == con_ErrorID)
{
return mlngErrorID;
}
else if (strAttributeName == con_PageName)
{
return mstrPageName;
}
else if (strAttributeName == con_FunctionName)
{
return mstrFunctionName;
}
else if (strAttributeName == con_ErrorInformation)
{
return mstrErrorInformation;
}
else if (strAttributeName == con_UserId)
{
return mstrUserId;
}
else if (strAttributeName == con_CreateTime)
{
return mdteCreateTime;
}
return null;
}
set
{
if (strAttributeName == con_ErrorID)
{
mlngErrorID = TransNullToInt(value.ToString());
 AddUpdatedFld(con_ErrorID);
}
else if (strAttributeName == con_PageName)
{
mstrPageName = value.ToString();
 AddUpdatedFld(con_PageName);
}
else if (strAttributeName == con_FunctionName)
{
mstrFunctionName = value.ToString();
 AddUpdatedFld(con_FunctionName);
}
else if (strAttributeName == con_ErrorInformation)
{
mstrErrorInformation = value.ToString();
 AddUpdatedFld(con_ErrorInformation);
}
else if (strAttributeName == con_UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(con_UserId);
}
else if (strAttributeName == con_CreateTime)
{
mdteCreateTime = TransNullToDate(value.ToString());
 AddUpdatedFld(con_CreateTime);
}
}
}
public object this[int intIndex]
{
get
{
if (con_ErrorID == AttributeName[intIndex])
{
return mlngErrorID;
}
else if (con_PageName == AttributeName[intIndex])
{
return mstrPageName;
}
else if (con_FunctionName == AttributeName[intIndex])
{
return mstrFunctionName;
}
else if (con_ErrorInformation == AttributeName[intIndex])
{
return mstrErrorInformation;
}
else if (con_UserId == AttributeName[intIndex])
{
return mstrUserId;
}
else if (con_CreateTime == AttributeName[intIndex])
{
return mdteCreateTime;
}
return null;
}
set
{
if (con_ErrorID == AttributeName[intIndex])
{
mlngErrorID = TransNullToInt(value.ToString());
 AddUpdatedFld(con_ErrorID);
}
else if (con_PageName == AttributeName[intIndex])
{
mstrPageName = value.ToString();
 AddUpdatedFld(con_PageName);
}
else if (con_FunctionName == AttributeName[intIndex])
{
mstrFunctionName = value.ToString();
 AddUpdatedFld(con_FunctionName);
}
else if (con_ErrorInformation == AttributeName[intIndex])
{
mstrErrorInformation = value.ToString();
 AddUpdatedFld(con_ErrorInformation);
}
else if (con_UserId == AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(con_UserId);
}
else if (con_CreateTime == AttributeName[intIndex])
{
mdteCreateTime = TransNullToDate(value.ToString());
 AddUpdatedFld(con_CreateTime);
}
}
}

/// <summary>
/// 错误流水号(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public long ErrorID
{
get
{
return mlngErrorID;
}
set
{
 mlngErrorID = value;
//记录修改过的字段
 AddUpdatedFld(con_ErrorID);
}
}
/// <summary>
/// 页面名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string PageName
{
get
{
return mstrPageName;
}
set
{
if (value == "")
{
mintErrNo = 1;
 mstrPageName = value;
}
else
{
 mstrPageName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_PageName);
}
}
/// <summary>
/// 功能名称(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string FunctionName
{
get
{
return mstrFunctionName;
}
set
{
if (value == "")
{
mintErrNo = 1;
 mstrFunctionName = value;
}
else
{
 mstrFunctionName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_FunctionName);
}
}
/// <summary>
/// 错误信息(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string ErrorInformation
{
get
{
return mstrErrorInformation;
}
set
{
if (value == "")
{
mintErrNo = 1;
 mstrErrorInformation = value;
}
else
{
 mstrErrorInformation = value;
}
//记录修改过的字段
 AddUpdatedFld(con_ErrorInformation);
}
}
/// <summary>
/// 用户账号(说明:;字段类型:varchar;字段长度:20;是否可空:False)
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
if (value == "")
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
/// 创建时间(说明:;字段类型:datetime;字段长度:16;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public DateTime CreateTime
{
get
{
return mdteCreateTime;
}
set
{
 mdteCreateTime = value;
//记录修改过的字段
 AddUpdatedFld(con_CreateTime);
}
}
/// <summary>
/// 整型Tag(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public int IntTag
{
get
{
return mintIntTag;
}
set
{
 mintIntTag = value;
//记录修改过的字段
 AddUpdatedFld(con_IntTag);
}
}
/// <summary>
/// 字符型标签(说明:;字段类型:string;字段长度:1000;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string StrTag
{
get
{
return mstrStrTag;
}
set
{
if (value == "")
{
mintErrNo = 1;
 mstrStrTag = value;
}
else
{
 mstrStrTag = value;
}
//记录修改过的字段
 AddUpdatedFld(con_StrTag);
}
}
/// <summary>
/// 是否检查属性(说明:;字段类型:bool;字段长度:1;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public bool IsCheckProperty
{
get
{
return mbolIsCheckProperty;
}
set
{
 mbolIsCheckProperty = value;
//记录修改过的字段
 AddUpdatedFld(con_IsCheckProperty);
}
}
}
}