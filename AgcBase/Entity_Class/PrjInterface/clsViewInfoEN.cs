
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewInfoEN
 表名:ViewInfo(00050006)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:01:05
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:界面管理(PrjInterface)
 框架-层名:实体层(CS)(EntityLayer,0001)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Text; 
using System.Collections; 

using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace AGC.Entity
{
 /// <summary>
 /// 表ViewInfo的关键字(ViewId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ViewId_ViewInfo
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strViewId">表关键字</param>
public K_ViewId_ViewInfo(string strViewId)
{
if (IsValid(strViewId)) Value = strViewId;
else
{
Value = null;
}
}
private static bool IsValid(string strViewId)
{
if (string.IsNullOrEmpty(strViewId) == true) return false;
if (strViewId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ViewId_ViewInfo]类型的对象</returns>
public static implicit operator K_ViewId_ViewInfo(string value)
{
return new K_ViewId_ViewInfo(value);
}
}
 /// <summary>
 /// 界面(ViewInfo)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsViewInfoEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ViewInfo"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ViewId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 39;
public static string[] _AttributeName = new string[] {"ViewId", "ViewName", "ApplicationTypeId", "FuncModuleAgcId", "DataBaseName", "KeyForMainTab", "KeyForDetailTab", "IsNeedSort", "IsNeedTransCode", "IsNeedSetExportFld", "UserId", "PrjId", "ViewFunction", "ViewDetail", "DefaMenuName", "DetailTabId", "FileName", "FilePath", "MainTabId", "ViewCnName", "ViewGroupId", "InRelaTabId", "InSqlDsTypeId", "OutRelaTabId", "OutSqlDsTypeId", "DetailTabType", "DetailViewId", "MainTabType", "MainViewId", "GeneCodeDate", "TaskId", "KeyId4Test", "ViewMasterId", "IsShare", "ErrMsg", "UpdDate", "UpdUserId", "Memo", "RegionNum"};

protected string mstrViewId;    //界面Id
protected string mstrViewName;    //界面名称
protected int mintApplicationTypeId;    //应用程序类型ID
protected string mstrFuncModuleAgcId;    //功能模块Id
protected string mstrDataBaseName;    //数据库名
protected string mstrKeyForMainTab;    //主表关键字
protected string mstrKeyForDetailTab;    //明细表关键字
protected bool mbolIsNeedSort;    //是否需要排序
protected bool mbolIsNeedTransCode;    //是否需要转换代码
protected bool mbolIsNeedSetExportFld;    //是否需要设置导出字段
protected string mstrUserId;    //用户Id
protected string mstrPrjId;    //工程Id
protected string mstrViewFunction;    //界面功能
protected string mstrViewDetail;    //界面说明
protected string mstrDefaMenuName;    //缺省菜单名
protected string mstrDetailTabId;    //明细表ID
protected string mstrFileName;    //文件名
protected string mstrFilePath;    //文件路径
protected string mstrMainTabId;    //主表ID
protected string mstrViewCnName;    //视图中文名
protected string mstrViewGroupId;    //界面组ID
protected string mstrInRelaTabId;    //输入数据源表ID
protected string mstrInSqlDsTypeId;    //输入数据源类型
protected string mstrOutRelaTabId;    //输出数据源表ID
protected string mstrOutSqlDsTypeId;    //输出数据源类型
protected string mstrDetailTabType;    //DetailTabType
protected string mstrDetailViewId;    //DetailViewId
protected string mstrMainTabType;    //MainTabType
protected string mstrMainViewId;    //MainViewId
protected string mstrGeneCodeDate;    //生成代码日期
protected string mstrTaskId;    //任务Id
protected string mstrKeyId4Test;    //测试关键字Id
protected string mstrViewMasterId;    //界面母版Id
protected bool mbolIsShare;    //是否共享
protected string mstrErrMsg;    //错误信息
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //说明
protected int? mintRegionNum;    //区域数

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsViewInfoEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ViewId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strViewId">关键字:界面Id</param>
public clsViewInfoEN(string strViewId)
 {
strViewId = strViewId.Replace("'", "''");
if (strViewId.Length > 8)
{
throw new Exception("在表:ViewInfo中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strViewId)  ==  true)
{
throw new Exception("在表:ViewInfo中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strViewId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrViewId = strViewId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ViewId");
 }

public static int AttributeCount
{
get
{
return _AttributeCount;
}
}
public override object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  conViewInfo.ViewId)
{
return mstrViewId;
}
else if (strAttributeName  ==  conViewInfo.ViewName)
{
return mstrViewName;
}
else if (strAttributeName  ==  conViewInfo.ApplicationTypeId)
{
return mintApplicationTypeId;
}
else if (strAttributeName  ==  conViewInfo.FuncModuleAgcId)
{
return mstrFuncModuleAgcId;
}
else if (strAttributeName  ==  conViewInfo.DataBaseName)
{
return mstrDataBaseName;
}
else if (strAttributeName  ==  conViewInfo.KeyForMainTab)
{
return mstrKeyForMainTab;
}
else if (strAttributeName  ==  conViewInfo.KeyForDetailTab)
{
return mstrKeyForDetailTab;
}
else if (strAttributeName  ==  conViewInfo.IsNeedSort)
{
return mbolIsNeedSort;
}
else if (strAttributeName  ==  conViewInfo.IsNeedTransCode)
{
return mbolIsNeedTransCode;
}
else if (strAttributeName  ==  conViewInfo.IsNeedSetExportFld)
{
return mbolIsNeedSetExportFld;
}
else if (strAttributeName  ==  conViewInfo.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conViewInfo.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conViewInfo.ViewFunction)
{
return mstrViewFunction;
}
else if (strAttributeName  ==  conViewInfo.ViewDetail)
{
return mstrViewDetail;
}
else if (strAttributeName  ==  conViewInfo.DefaMenuName)
{
return mstrDefaMenuName;
}
else if (strAttributeName  ==  conViewInfo.DetailTabId)
{
return mstrDetailTabId;
}
else if (strAttributeName  ==  conViewInfo.FileName)
{
return mstrFileName;
}
else if (strAttributeName  ==  conViewInfo.FilePath)
{
return mstrFilePath;
}
else if (strAttributeName  ==  conViewInfo.MainTabId)
{
return mstrMainTabId;
}
else if (strAttributeName  ==  conViewInfo.ViewCnName)
{
return mstrViewCnName;
}
else if (strAttributeName  ==  conViewInfo.ViewGroupId)
{
return mstrViewGroupId;
}
else if (strAttributeName  ==  conViewInfo.InRelaTabId)
{
return mstrInRelaTabId;
}
else if (strAttributeName  ==  conViewInfo.InSqlDsTypeId)
{
return mstrInSqlDsTypeId;
}
else if (strAttributeName  ==  conViewInfo.OutRelaTabId)
{
return mstrOutRelaTabId;
}
else if (strAttributeName  ==  conViewInfo.OutSqlDsTypeId)
{
return mstrOutSqlDsTypeId;
}
else if (strAttributeName  ==  conViewInfo.DetailTabType)
{
return mstrDetailTabType;
}
else if (strAttributeName  ==  conViewInfo.DetailViewId)
{
return mstrDetailViewId;
}
else if (strAttributeName  ==  conViewInfo.MainTabType)
{
return mstrMainTabType;
}
else if (strAttributeName  ==  conViewInfo.MainViewId)
{
return mstrMainViewId;
}
else if (strAttributeName  ==  conViewInfo.GeneCodeDate)
{
return mstrGeneCodeDate;
}
else if (strAttributeName  ==  conViewInfo.TaskId)
{
return mstrTaskId;
}
else if (strAttributeName  ==  conViewInfo.KeyId4Test)
{
return mstrKeyId4Test;
}
else if (strAttributeName  ==  conViewInfo.ViewMasterId)
{
return mstrViewMasterId;
}
else if (strAttributeName  ==  conViewInfo.IsShare)
{
return mbolIsShare;
}
else if (strAttributeName  ==  conViewInfo.ErrMsg)
{
return mstrErrMsg;
}
else if (strAttributeName  ==  conViewInfo.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conViewInfo.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conViewInfo.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conViewInfo.RegionNum)
{
return mintRegionNum;
}
return null;
}
set
{
if (strAttributeName  ==  conViewInfo.ViewId)
{
mstrViewId = value.ToString();
 AddUpdatedFld(conViewInfo.ViewId);
}
else if (strAttributeName  ==  conViewInfo.ViewName)
{
mstrViewName = value.ToString();
 AddUpdatedFld(conViewInfo.ViewName);
}
else if (strAttributeName  ==  conViewInfo.ApplicationTypeId)
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewInfo.ApplicationTypeId);
}
else if (strAttributeName  ==  conViewInfo.FuncModuleAgcId)
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(conViewInfo.FuncModuleAgcId);
}
else if (strAttributeName  ==  conViewInfo.DataBaseName)
{
mstrDataBaseName = value.ToString();
 AddUpdatedFld(conViewInfo.DataBaseName);
}
else if (strAttributeName  ==  conViewInfo.KeyForMainTab)
{
mstrKeyForMainTab = value.ToString();
 AddUpdatedFld(conViewInfo.KeyForMainTab);
}
else if (strAttributeName  ==  conViewInfo.KeyForDetailTab)
{
mstrKeyForDetailTab = value.ToString();
 AddUpdatedFld(conViewInfo.KeyForDetailTab);
}
else if (strAttributeName  ==  conViewInfo.IsNeedSort)
{
mbolIsNeedSort = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewInfo.IsNeedSort);
}
else if (strAttributeName  ==  conViewInfo.IsNeedTransCode)
{
mbolIsNeedTransCode = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewInfo.IsNeedTransCode);
}
else if (strAttributeName  ==  conViewInfo.IsNeedSetExportFld)
{
mbolIsNeedSetExportFld = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewInfo.IsNeedSetExportFld);
}
else if (strAttributeName  ==  conViewInfo.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conViewInfo.UserId);
}
else if (strAttributeName  ==  conViewInfo.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conViewInfo.PrjId);
}
else if (strAttributeName  ==  conViewInfo.ViewFunction)
{
mstrViewFunction = value.ToString();
 AddUpdatedFld(conViewInfo.ViewFunction);
}
else if (strAttributeName  ==  conViewInfo.ViewDetail)
{
mstrViewDetail = value.ToString();
 AddUpdatedFld(conViewInfo.ViewDetail);
}
else if (strAttributeName  ==  conViewInfo.DefaMenuName)
{
mstrDefaMenuName = value.ToString();
 AddUpdatedFld(conViewInfo.DefaMenuName);
}
else if (strAttributeName  ==  conViewInfo.DetailTabId)
{
mstrDetailTabId = value.ToString();
 AddUpdatedFld(conViewInfo.DetailTabId);
}
else if (strAttributeName  ==  conViewInfo.FileName)
{
mstrFileName = value.ToString();
 AddUpdatedFld(conViewInfo.FileName);
}
else if (strAttributeName  ==  conViewInfo.FilePath)
{
mstrFilePath = value.ToString();
 AddUpdatedFld(conViewInfo.FilePath);
}
else if (strAttributeName  ==  conViewInfo.MainTabId)
{
mstrMainTabId = value.ToString();
 AddUpdatedFld(conViewInfo.MainTabId);
}
else if (strAttributeName  ==  conViewInfo.ViewCnName)
{
mstrViewCnName = value.ToString();
 AddUpdatedFld(conViewInfo.ViewCnName);
}
else if (strAttributeName  ==  conViewInfo.ViewGroupId)
{
mstrViewGroupId = value.ToString();
 AddUpdatedFld(conViewInfo.ViewGroupId);
}
else if (strAttributeName  ==  conViewInfo.InRelaTabId)
{
mstrInRelaTabId = value.ToString();
 AddUpdatedFld(conViewInfo.InRelaTabId);
}
else if (strAttributeName  ==  conViewInfo.InSqlDsTypeId)
{
mstrInSqlDsTypeId = value.ToString();
 AddUpdatedFld(conViewInfo.InSqlDsTypeId);
}
else if (strAttributeName  ==  conViewInfo.OutRelaTabId)
{
mstrOutRelaTabId = value.ToString();
 AddUpdatedFld(conViewInfo.OutRelaTabId);
}
else if (strAttributeName  ==  conViewInfo.OutSqlDsTypeId)
{
mstrOutSqlDsTypeId = value.ToString();
 AddUpdatedFld(conViewInfo.OutSqlDsTypeId);
}
else if (strAttributeName  ==  conViewInfo.DetailTabType)
{
mstrDetailTabType = value.ToString();
 AddUpdatedFld(conViewInfo.DetailTabType);
}
else if (strAttributeName  ==  conViewInfo.DetailViewId)
{
mstrDetailViewId = value.ToString();
 AddUpdatedFld(conViewInfo.DetailViewId);
}
else if (strAttributeName  ==  conViewInfo.MainTabType)
{
mstrMainTabType = value.ToString();
 AddUpdatedFld(conViewInfo.MainTabType);
}
else if (strAttributeName  ==  conViewInfo.MainViewId)
{
mstrMainViewId = value.ToString();
 AddUpdatedFld(conViewInfo.MainViewId);
}
else if (strAttributeName  ==  conViewInfo.GeneCodeDate)
{
mstrGeneCodeDate = value.ToString();
 AddUpdatedFld(conViewInfo.GeneCodeDate);
}
else if (strAttributeName  ==  conViewInfo.TaskId)
{
mstrTaskId = value.ToString();
 AddUpdatedFld(conViewInfo.TaskId);
}
else if (strAttributeName  ==  conViewInfo.KeyId4Test)
{
mstrKeyId4Test = value.ToString();
 AddUpdatedFld(conViewInfo.KeyId4Test);
}
else if (strAttributeName  ==  conViewInfo.ViewMasterId)
{
mstrViewMasterId = value.ToString();
 AddUpdatedFld(conViewInfo.ViewMasterId);
}
else if (strAttributeName  ==  conViewInfo.IsShare)
{
mbolIsShare = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewInfo.IsShare);
}
else if (strAttributeName  ==  conViewInfo.ErrMsg)
{
mstrErrMsg = value.ToString();
 AddUpdatedFld(conViewInfo.ErrMsg);
}
else if (strAttributeName  ==  conViewInfo.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conViewInfo.UpdDate);
}
else if (strAttributeName  ==  conViewInfo.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conViewInfo.UpdUserId);
}
else if (strAttributeName  ==  conViewInfo.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conViewInfo.Memo);
}
else if (strAttributeName  ==  conViewInfo.RegionNum)
{
mintRegionNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewInfo.RegionNum);
}
}
}
public object this[int intIndex]
{
get
{
if (conViewInfo.ViewId  ==  _AttributeName[intIndex])
{
return mstrViewId;
}
else if (conViewInfo.ViewName  ==  _AttributeName[intIndex])
{
return mstrViewName;
}
else if (conViewInfo.ApplicationTypeId  ==  _AttributeName[intIndex])
{
return mintApplicationTypeId;
}
else if (conViewInfo.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
return mstrFuncModuleAgcId;
}
else if (conViewInfo.DataBaseName  ==  _AttributeName[intIndex])
{
return mstrDataBaseName;
}
else if (conViewInfo.KeyForMainTab  ==  _AttributeName[intIndex])
{
return mstrKeyForMainTab;
}
else if (conViewInfo.KeyForDetailTab  ==  _AttributeName[intIndex])
{
return mstrKeyForDetailTab;
}
else if (conViewInfo.IsNeedSort  ==  _AttributeName[intIndex])
{
return mbolIsNeedSort;
}
else if (conViewInfo.IsNeedTransCode  ==  _AttributeName[intIndex])
{
return mbolIsNeedTransCode;
}
else if (conViewInfo.IsNeedSetExportFld  ==  _AttributeName[intIndex])
{
return mbolIsNeedSetExportFld;
}
else if (conViewInfo.UserId  ==  _AttributeName[intIndex])
{
return mstrUserId;
}
else if (conViewInfo.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conViewInfo.ViewFunction  ==  _AttributeName[intIndex])
{
return mstrViewFunction;
}
else if (conViewInfo.ViewDetail  ==  _AttributeName[intIndex])
{
return mstrViewDetail;
}
else if (conViewInfo.DefaMenuName  ==  _AttributeName[intIndex])
{
return mstrDefaMenuName;
}
else if (conViewInfo.DetailTabId  ==  _AttributeName[intIndex])
{
return mstrDetailTabId;
}
else if (conViewInfo.FileName  ==  _AttributeName[intIndex])
{
return mstrFileName;
}
else if (conViewInfo.FilePath  ==  _AttributeName[intIndex])
{
return mstrFilePath;
}
else if (conViewInfo.MainTabId  ==  _AttributeName[intIndex])
{
return mstrMainTabId;
}
else if (conViewInfo.ViewCnName  ==  _AttributeName[intIndex])
{
return mstrViewCnName;
}
else if (conViewInfo.ViewGroupId  ==  _AttributeName[intIndex])
{
return mstrViewGroupId;
}
else if (conViewInfo.InRelaTabId  ==  _AttributeName[intIndex])
{
return mstrInRelaTabId;
}
else if (conViewInfo.InSqlDsTypeId  ==  _AttributeName[intIndex])
{
return mstrInSqlDsTypeId;
}
else if (conViewInfo.OutRelaTabId  ==  _AttributeName[intIndex])
{
return mstrOutRelaTabId;
}
else if (conViewInfo.OutSqlDsTypeId  ==  _AttributeName[intIndex])
{
return mstrOutSqlDsTypeId;
}
else if (conViewInfo.DetailTabType  ==  _AttributeName[intIndex])
{
return mstrDetailTabType;
}
else if (conViewInfo.DetailViewId  ==  _AttributeName[intIndex])
{
return mstrDetailViewId;
}
else if (conViewInfo.MainTabType  ==  _AttributeName[intIndex])
{
return mstrMainTabType;
}
else if (conViewInfo.MainViewId  ==  _AttributeName[intIndex])
{
return mstrMainViewId;
}
else if (conViewInfo.GeneCodeDate  ==  _AttributeName[intIndex])
{
return mstrGeneCodeDate;
}
else if (conViewInfo.TaskId  ==  _AttributeName[intIndex])
{
return mstrTaskId;
}
else if (conViewInfo.KeyId4Test  ==  _AttributeName[intIndex])
{
return mstrKeyId4Test;
}
else if (conViewInfo.ViewMasterId  ==  _AttributeName[intIndex])
{
return mstrViewMasterId;
}
else if (conViewInfo.IsShare  ==  _AttributeName[intIndex])
{
return mbolIsShare;
}
else if (conViewInfo.ErrMsg  ==  _AttributeName[intIndex])
{
return mstrErrMsg;
}
else if (conViewInfo.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conViewInfo.UpdUserId  ==  _AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conViewInfo.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (conViewInfo.RegionNum  ==  _AttributeName[intIndex])
{
return mintRegionNum;
}
return null;
}
set
{
if (conViewInfo.ViewId  ==  _AttributeName[intIndex])
{
mstrViewId = value.ToString();
 AddUpdatedFld(conViewInfo.ViewId);
}
else if (conViewInfo.ViewName  ==  _AttributeName[intIndex])
{
mstrViewName = value.ToString();
 AddUpdatedFld(conViewInfo.ViewName);
}
else if (conViewInfo.ApplicationTypeId  ==  _AttributeName[intIndex])
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewInfo.ApplicationTypeId);
}
else if (conViewInfo.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(conViewInfo.FuncModuleAgcId);
}
else if (conViewInfo.DataBaseName  ==  _AttributeName[intIndex])
{
mstrDataBaseName = value.ToString();
 AddUpdatedFld(conViewInfo.DataBaseName);
}
else if (conViewInfo.KeyForMainTab  ==  _AttributeName[intIndex])
{
mstrKeyForMainTab = value.ToString();
 AddUpdatedFld(conViewInfo.KeyForMainTab);
}
else if (conViewInfo.KeyForDetailTab  ==  _AttributeName[intIndex])
{
mstrKeyForDetailTab = value.ToString();
 AddUpdatedFld(conViewInfo.KeyForDetailTab);
}
else if (conViewInfo.IsNeedSort  ==  _AttributeName[intIndex])
{
mbolIsNeedSort = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewInfo.IsNeedSort);
}
else if (conViewInfo.IsNeedTransCode  ==  _AttributeName[intIndex])
{
mbolIsNeedTransCode = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewInfo.IsNeedTransCode);
}
else if (conViewInfo.IsNeedSetExportFld  ==  _AttributeName[intIndex])
{
mbolIsNeedSetExportFld = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewInfo.IsNeedSetExportFld);
}
else if (conViewInfo.UserId  ==  _AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conViewInfo.UserId);
}
else if (conViewInfo.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conViewInfo.PrjId);
}
else if (conViewInfo.ViewFunction  ==  _AttributeName[intIndex])
{
mstrViewFunction = value.ToString();
 AddUpdatedFld(conViewInfo.ViewFunction);
}
else if (conViewInfo.ViewDetail  ==  _AttributeName[intIndex])
{
mstrViewDetail = value.ToString();
 AddUpdatedFld(conViewInfo.ViewDetail);
}
else if (conViewInfo.DefaMenuName  ==  _AttributeName[intIndex])
{
mstrDefaMenuName = value.ToString();
 AddUpdatedFld(conViewInfo.DefaMenuName);
}
else if (conViewInfo.DetailTabId  ==  _AttributeName[intIndex])
{
mstrDetailTabId = value.ToString();
 AddUpdatedFld(conViewInfo.DetailTabId);
}
else if (conViewInfo.FileName  ==  _AttributeName[intIndex])
{
mstrFileName = value.ToString();
 AddUpdatedFld(conViewInfo.FileName);
}
else if (conViewInfo.FilePath  ==  _AttributeName[intIndex])
{
mstrFilePath = value.ToString();
 AddUpdatedFld(conViewInfo.FilePath);
}
else if (conViewInfo.MainTabId  ==  _AttributeName[intIndex])
{
mstrMainTabId = value.ToString();
 AddUpdatedFld(conViewInfo.MainTabId);
}
else if (conViewInfo.ViewCnName  ==  _AttributeName[intIndex])
{
mstrViewCnName = value.ToString();
 AddUpdatedFld(conViewInfo.ViewCnName);
}
else if (conViewInfo.ViewGroupId  ==  _AttributeName[intIndex])
{
mstrViewGroupId = value.ToString();
 AddUpdatedFld(conViewInfo.ViewGroupId);
}
else if (conViewInfo.InRelaTabId  ==  _AttributeName[intIndex])
{
mstrInRelaTabId = value.ToString();
 AddUpdatedFld(conViewInfo.InRelaTabId);
}
else if (conViewInfo.InSqlDsTypeId  ==  _AttributeName[intIndex])
{
mstrInSqlDsTypeId = value.ToString();
 AddUpdatedFld(conViewInfo.InSqlDsTypeId);
}
else if (conViewInfo.OutRelaTabId  ==  _AttributeName[intIndex])
{
mstrOutRelaTabId = value.ToString();
 AddUpdatedFld(conViewInfo.OutRelaTabId);
}
else if (conViewInfo.OutSqlDsTypeId  ==  _AttributeName[intIndex])
{
mstrOutSqlDsTypeId = value.ToString();
 AddUpdatedFld(conViewInfo.OutSqlDsTypeId);
}
else if (conViewInfo.DetailTabType  ==  _AttributeName[intIndex])
{
mstrDetailTabType = value.ToString();
 AddUpdatedFld(conViewInfo.DetailTabType);
}
else if (conViewInfo.DetailViewId  ==  _AttributeName[intIndex])
{
mstrDetailViewId = value.ToString();
 AddUpdatedFld(conViewInfo.DetailViewId);
}
else if (conViewInfo.MainTabType  ==  _AttributeName[intIndex])
{
mstrMainTabType = value.ToString();
 AddUpdatedFld(conViewInfo.MainTabType);
}
else if (conViewInfo.MainViewId  ==  _AttributeName[intIndex])
{
mstrMainViewId = value.ToString();
 AddUpdatedFld(conViewInfo.MainViewId);
}
else if (conViewInfo.GeneCodeDate  ==  _AttributeName[intIndex])
{
mstrGeneCodeDate = value.ToString();
 AddUpdatedFld(conViewInfo.GeneCodeDate);
}
else if (conViewInfo.TaskId  ==  _AttributeName[intIndex])
{
mstrTaskId = value.ToString();
 AddUpdatedFld(conViewInfo.TaskId);
}
else if (conViewInfo.KeyId4Test  ==  _AttributeName[intIndex])
{
mstrKeyId4Test = value.ToString();
 AddUpdatedFld(conViewInfo.KeyId4Test);
}
else if (conViewInfo.ViewMasterId  ==  _AttributeName[intIndex])
{
mstrViewMasterId = value.ToString();
 AddUpdatedFld(conViewInfo.ViewMasterId);
}
else if (conViewInfo.IsShare  ==  _AttributeName[intIndex])
{
mbolIsShare = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewInfo.IsShare);
}
else if (conViewInfo.ErrMsg  ==  _AttributeName[intIndex])
{
mstrErrMsg = value.ToString();
 AddUpdatedFld(conViewInfo.ErrMsg);
}
else if (conViewInfo.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conViewInfo.UpdDate);
}
else if (conViewInfo.UpdUserId  ==  _AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conViewInfo.UpdUserId);
}
else if (conViewInfo.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conViewInfo.Memo);
}
else if (conViewInfo.RegionNum  ==  _AttributeName[intIndex])
{
mintRegionNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewInfo.RegionNum);
}
}
}

/// <summary>
/// 界面Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
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
mintErrNo = 1;
 mstrViewId = value;
}
else
{
 mstrViewId = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewInfo.ViewId);
}
}
/// <summary>
/// 界面名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewName
{
get
{
return mstrViewName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewName = value;
}
else
{
 mstrViewName = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewInfo.ViewName);
}
}
/// <summary>
/// 应用程序类型ID(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int ApplicationTypeId
{
get
{
return mintApplicationTypeId;
}
set
{
 mintApplicationTypeId = value;
//记录修改过的字段
 AddUpdatedFld(conViewInfo.ApplicationTypeId);
}
}
/// <summary>
/// 功能模块Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleAgcId
{
get
{
return mstrFuncModuleAgcId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleAgcId = value;
}
else
{
 mstrFuncModuleAgcId = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewInfo.FuncModuleAgcId);
}
}
/// <summary>
/// 数据库名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataBaseName
{
get
{
return mstrDataBaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataBaseName = value;
}
else
{
 mstrDataBaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewInfo.DataBaseName);
}
}
/// <summary>
/// 主表关键字(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KeyForMainTab
{
get
{
return mstrKeyForMainTab;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeyForMainTab = value;
}
else
{
 mstrKeyForMainTab = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewInfo.KeyForMainTab);
}
}
/// <summary>
/// 明细表关键字(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KeyForDetailTab
{
get
{
return mstrKeyForDetailTab;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeyForDetailTab = value;
}
else
{
 mstrKeyForDetailTab = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewInfo.KeyForDetailTab);
}
}
/// <summary>
/// 是否需要排序(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsNeedSort
{
get
{
return mbolIsNeedSort;
}
set
{
 mbolIsNeedSort = value;
//记录修改过的字段
 AddUpdatedFld(conViewInfo.IsNeedSort);
}
}
/// <summary>
/// 是否需要转换代码(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsNeedTransCode
{
get
{
return mbolIsNeedTransCode;
}
set
{
 mbolIsNeedTransCode = value;
//记录修改过的字段
 AddUpdatedFld(conViewInfo.IsNeedTransCode);
}
}
/// <summary>
/// 是否需要设置导出字段(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsNeedSetExportFld
{
get
{
return mbolIsNeedSetExportFld;
}
set
{
 mbolIsNeedSetExportFld = value;
//记录修改过的字段
 AddUpdatedFld(conViewInfo.IsNeedSetExportFld);
}
}
/// <summary>
/// 用户Id(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
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
mintErrNo = 1;
 mstrUserId = value;
}
else
{
 mstrUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewInfo.UserId);
}
}
/// <summary>
/// 工程Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
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
 AddUpdatedFld(conViewInfo.PrjId);
}
}
/// <summary>
/// 界面功能(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewFunction
{
get
{
return mstrViewFunction;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewFunction = value;
}
else
{
 mstrViewFunction = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewInfo.ViewFunction);
}
}
/// <summary>
/// 界面说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewDetail
{
get
{
return mstrViewDetail;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewDetail = value;
}
else
{
 mstrViewDetail = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewInfo.ViewDetail);
}
}
/// <summary>
/// 缺省菜单名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DefaMenuName
{
get
{
return mstrDefaMenuName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDefaMenuName = value;
}
else
{
 mstrDefaMenuName = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewInfo.DefaMenuName);
}
}
/// <summary>
/// 明细表ID(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DetailTabId
{
get
{
return mstrDetailTabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDetailTabId = value;
}
else
{
 mstrDetailTabId = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewInfo.DetailTabId);
}
}
/// <summary>
/// 文件名(说明:;字段类型:varchar;字段长度:150;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FileName
{
get
{
return mstrFileName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFileName = value;
}
else
{
 mstrFileName = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewInfo.FileName);
}
}
/// <summary>
/// 文件路径(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FilePath
{
get
{
return mstrFilePath;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFilePath = value;
}
else
{
 mstrFilePath = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewInfo.FilePath);
}
}
/// <summary>
/// 主表ID(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MainTabId
{
get
{
return mstrMainTabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMainTabId = value;
}
else
{
 mstrMainTabId = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewInfo.MainTabId);
}
}
/// <summary>
/// 视图中文名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewCnName
{
get
{
return mstrViewCnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewCnName = value;
}
else
{
 mstrViewCnName = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewInfo.ViewCnName);
}
}
/// <summary>
/// 界面组ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewGroupId
{
get
{
return mstrViewGroupId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewGroupId = value;
}
else
{
 mstrViewGroupId = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewInfo.ViewGroupId);
}
}
/// <summary>
/// 输入数据源表ID(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string InRelaTabId
{
get
{
return mstrInRelaTabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrInRelaTabId = value;
}
else
{
 mstrInRelaTabId = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewInfo.InRelaTabId);
}
}
/// <summary>
/// 输入数据源类型(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string InSqlDsTypeId
{
get
{
return mstrInSqlDsTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrInSqlDsTypeId = value;
}
else
{
 mstrInSqlDsTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewInfo.InSqlDsTypeId);
}
}
/// <summary>
/// 输出数据源表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OutRelaTabId
{
get
{
return mstrOutRelaTabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOutRelaTabId = value;
}
else
{
 mstrOutRelaTabId = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewInfo.OutRelaTabId);
}
}
/// <summary>
/// 输出数据源类型(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OutSqlDsTypeId
{
get
{
return mstrOutSqlDsTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOutSqlDsTypeId = value;
}
else
{
 mstrOutSqlDsTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewInfo.OutSqlDsTypeId);
}
}
/// <summary>
/// DetailTabType(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DetailTabType
{
get
{
return mstrDetailTabType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDetailTabType = value;
}
else
{
 mstrDetailTabType = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewInfo.DetailTabType);
}
}
/// <summary>
/// DetailViewId(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DetailViewId
{
get
{
return mstrDetailViewId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDetailViewId = value;
}
else
{
 mstrDetailViewId = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewInfo.DetailViewId);
}
}
/// <summary>
/// MainTabType(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MainTabType
{
get
{
return mstrMainTabType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMainTabType = value;
}
else
{
 mstrMainTabType = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewInfo.MainTabType);
}
}
/// <summary>
/// MainViewId(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MainViewId
{
get
{
return mstrMainViewId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMainViewId = value;
}
else
{
 mstrMainViewId = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewInfo.MainViewId);
}
}
/// <summary>
/// 生成代码日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GeneCodeDate
{
get
{
return mstrGeneCodeDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGeneCodeDate = value;
}
else
{
 mstrGeneCodeDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewInfo.GeneCodeDate);
}
}
/// <summary>
/// 任务Id(说明:;字段类型:char;字段长度:16;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TaskId
{
get
{
return mstrTaskId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTaskId = value;
}
else
{
 mstrTaskId = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewInfo.TaskId);
}
}
/// <summary>
/// 测试关键字Id(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KeyId4Test
{
get
{
return mstrKeyId4Test;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeyId4Test = value;
}
else
{
 mstrKeyId4Test = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewInfo.KeyId4Test);
}
}
/// <summary>
/// 界面母版Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewMasterId
{
get
{
return mstrViewMasterId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewMasterId = value;
}
else
{
 mstrViewMasterId = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewInfo.ViewMasterId);
}
}
/// <summary>
/// 是否共享(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsShare
{
get
{
return mbolIsShare;
}
set
{
 mbolIsShare = value;
//记录修改过的字段
 AddUpdatedFld(conViewInfo.IsShare);
}
}
/// <summary>
/// 错误信息(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ErrMsg
{
get
{
return mstrErrMsg;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrErrMsg = value;
}
else
{
 mstrErrMsg = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewInfo.ErrMsg);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
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
mintErrNo = 1;
 mstrUpdDate = value;
}
else
{
 mstrUpdDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewInfo.UpdDate);
}
}
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
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
mintErrNo = 1;
 mstrUpdUserId = value;
}
else
{
 mstrUpdUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewInfo.UpdUserId);
}
}
/// <summary>
/// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
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
mintErrNo = 1;
 mstrMemo = value;
}
else
{
 mstrMemo = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewInfo.Memo);
}
}
/// <summary>
/// 区域数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? RegionNum
{
get
{
return mintRegionNum;
}
set
{
 mintRegionNum = value;
//记录修改过的字段
 AddUpdatedFld(conViewInfo.RegionNum);
}
}

/// <summary>
/// 获取关键字Id(keyId)
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetKeyId)
/// </summary>
 public override string _KeyId
 {
 get
 {
  return mstrViewId;
 }
 }

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrViewName;
 }
 }
}
 /// <summary>
 /// 界面(ViewInfo)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conViewInfo
{
public const string _CurrTabName = "ViewInfo"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ViewId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"ViewId", "ViewName", "ApplicationTypeId", "FuncModuleAgcId", "DataBaseName", "KeyForMainTab", "KeyForDetailTab", "IsNeedSort", "IsNeedTransCode", "IsNeedSetExportFld", "UserId", "PrjId", "ViewFunction", "ViewDetail", "DefaMenuName", "DetailTabId", "FileName", "FilePath", "MainTabId", "ViewCnName", "ViewGroupId", "InRelaTabId", "InSqlDsTypeId", "OutRelaTabId", "OutSqlDsTypeId", "DetailTabType", "DetailViewId", "MainTabType", "MainViewId", "GeneCodeDate", "TaskId", "KeyId4Test", "ViewMasterId", "IsShare", "ErrMsg", "UpdDate", "UpdUserId", "Memo", "RegionNum"};
//以下是属性变量


 /// <summary>
 /// 常量:"ViewId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewId = "ViewId";    //界面Id

 /// <summary>
 /// 常量:"ViewName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewName = "ViewName";    //界面名称

 /// <summary>
 /// 常量:"ApplicationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeId = "ApplicationTypeId";    //应用程序类型ID

 /// <summary>
 /// 常量:"FuncModuleAgcId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleAgcId = "FuncModuleAgcId";    //功能模块Id

 /// <summary>
 /// 常量:"DataBaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataBaseName = "DataBaseName";    //数据库名

 /// <summary>
 /// 常量:"KeyForMainTab"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KeyForMainTab = "KeyForMainTab";    //主表关键字

 /// <summary>
 /// 常量:"KeyForDetailTab"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KeyForDetailTab = "KeyForDetailTab";    //明细表关键字

 /// <summary>
 /// 常量:"IsNeedSort"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsNeedSort = "IsNeedSort";    //是否需要排序

 /// <summary>
 /// 常量:"IsNeedTransCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsNeedTransCode = "IsNeedTransCode";    //是否需要转换代码

 /// <summary>
 /// 常量:"IsNeedSetExportFld"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsNeedSetExportFld = "IsNeedSetExportFld";    //是否需要设置导出字段

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户Id

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"ViewFunction"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewFunction = "ViewFunction";    //界面功能

 /// <summary>
 /// 常量:"ViewDetail"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewDetail = "ViewDetail";    //界面说明

 /// <summary>
 /// 常量:"DefaMenuName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DefaMenuName = "DefaMenuName";    //缺省菜单名

 /// <summary>
 /// 常量:"DetailTabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DetailTabId = "DetailTabId";    //明细表ID

 /// <summary>
 /// 常量:"FileName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileName = "FileName";    //文件名

 /// <summary>
 /// 常量:"FilePath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FilePath = "FilePath";    //文件路径

 /// <summary>
 /// 常量:"MainTabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MainTabId = "MainTabId";    //主表ID

 /// <summary>
 /// 常量:"ViewCnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewCnName = "ViewCnName";    //视图中文名

 /// <summary>
 /// 常量:"ViewGroupId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewGroupId = "ViewGroupId";    //界面组ID

 /// <summary>
 /// 常量:"InRelaTabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InRelaTabId = "InRelaTabId";    //输入数据源表ID

 /// <summary>
 /// 常量:"InSqlDsTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InSqlDsTypeId = "InSqlDsTypeId";    //输入数据源类型

 /// <summary>
 /// 常量:"OutRelaTabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OutRelaTabId = "OutRelaTabId";    //输出数据源表ID

 /// <summary>
 /// 常量:"OutSqlDsTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OutSqlDsTypeId = "OutSqlDsTypeId";    //输出数据源类型

 /// <summary>
 /// 常量:"DetailTabType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DetailTabType = "DetailTabType";    //DetailTabType

 /// <summary>
 /// 常量:"DetailViewId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DetailViewId = "DetailViewId";    //DetailViewId

 /// <summary>
 /// 常量:"MainTabType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MainTabType = "MainTabType";    //MainTabType

 /// <summary>
 /// 常量:"MainViewId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MainViewId = "MainViewId";    //MainViewId

 /// <summary>
 /// 常量:"GeneCodeDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GeneCodeDate = "GeneCodeDate";    //生成代码日期

 /// <summary>
 /// 常量:"TaskId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TaskId = "TaskId";    //任务Id

 /// <summary>
 /// 常量:"KeyId4Test"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KeyId4Test = "KeyId4Test";    //测试关键字Id

 /// <summary>
 /// 常量:"ViewMasterId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewMasterId = "ViewMasterId";    //界面母版Id

 /// <summary>
 /// 常量:"IsShare"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsShare = "IsShare";    //是否共享

 /// <summary>
 /// 常量:"ErrMsg"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ErrMsg = "ErrMsg";    //错误信息

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明

 /// <summary>
 /// 常量:"RegionNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RegionNum = "RegionNum";    //区域数
}

}