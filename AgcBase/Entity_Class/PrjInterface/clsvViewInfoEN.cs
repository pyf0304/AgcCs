
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewInfoEN
 表名:vViewInfo(00050157)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:03:03
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
 /// 表vViewInfo的关键字(ViewId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ViewId_vViewInfo
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
public K_ViewId_vViewInfo(string strViewId)
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
 /// <returns>返回:[K_ViewId_vViewInfo]类型的对象</returns>
public static implicit operator K_ViewId_vViewInfo(string value)
{
return new K_ViewId_vViewInfo(value);
}
}
 /// <summary>
 /// v界面(vViewInfo)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvViewInfoEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vViewInfo"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ViewId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 45;
public static string[] _AttributeName = new string[] {"ViewId", "TitleStyleId", "TitleStyleName", "DgStyleId", "DgStyleName", "ViewName", "ApplicationTypeId", "ApplicationTypeSimName", "FuncModuleAgcId", "FuncModuleName", "FuncModuleEnName", "DataBaseName", "KeyForMainTab", "KeyForDetailTab", "IsNeedSort", "IsNeedTransCode", "IsNeedSetExportFld", "UserId", "PrjId", "PrjName", "ViewFunction", "ViewDetail", "DefaMenuName", "DetailTabId", "FileName", "FilePath", "MainTabId", "ViewCnName", "ViewGroupId", "ViewGroupName", "InSqlDsTypeId", "OutSqlDsTypeId", "GeneCodeDate", "TaskId", "KeyId4Test", "ViewMasterId", "ViewMasterName", "UpdDate", "UpdUserId", "Memo", "MainTabName", "DetailTabName", "MainTabKeyFld", "RegionNum", "DetailTabKeyFld"};

protected string mstrViewId;    //界面Id
protected string mstrTitleStyleId;    //标题类型Id
protected string mstrTitleStyleName;    //标题类型名
protected string mstrDgStyleId;    //DG模式ID
protected string mstrDgStyleName;    //DG模式名
protected string mstrViewName;    //界面名称
protected int mintApplicationTypeId;    //应用程序类型ID
protected string mstrApplicationTypeSimName;    //应用程序类型简称
protected string mstrFuncModuleAgcId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrFuncModuleEnName;    //功能模块英文名称
protected string mstrDataBaseName;    //数据库名
protected string mstrKeyForMainTab;    //主表关键字
protected string mstrKeyForDetailTab;    //明细表关键字
protected bool mbolIsNeedSort;    //是否需要排序
protected bool mbolIsNeedTransCode;    //是否需要转换代码
protected bool mbolIsNeedSetExportFld;    //是否需要设置导出字段
protected string mstrUserId;    //用户Id
protected string mstrPrjId;    //工程Id
protected string mstrPrjName;    //工程名称
protected string mstrViewFunction;    //界面功能
protected string mstrViewDetail;    //界面说明
protected string mstrDefaMenuName;    //缺省菜单名
protected string mstrDetailTabId;    //明细表ID
protected string mstrFileName;    //文件名
protected string mstrFilePath;    //文件路径
protected string mstrMainTabId;    //主表ID
protected string mstrViewCnName;    //视图中文名
protected string mstrViewGroupId;    //界面组ID
protected string mstrViewGroupName;    //界面组名称
protected string mstrInSqlDsTypeId;    //输入数据源类型
protected string mstrOutSqlDsTypeId;    //输出数据源类型
protected string mstrGeneCodeDate;    //生成代码日期
protected string mstrTaskId;    //任务Id
protected string mstrKeyId4Test;    //测试关键字Id
protected string mstrViewMasterId;    //界面母版Id
protected string mstrViewMasterName;    //界面母版名
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //说明
protected string mstrMainTabName;    //主表
protected string mstrDetailTabName;    //详细表
protected string mstrMainTabKeyFld;    //主表关键字
protected int? mintRegionNum;    //区域数
protected string mstrDetailTabKeyFld;    //详细表关键字

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvViewInfoEN()
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
public clsvViewInfoEN(string strViewId)
 {
strViewId = strViewId.Replace("'", "''");
if (strViewId.Length > 8)
{
throw new Exception("在表:vViewInfo中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strViewId)  ==  true)
{
throw new Exception("在表:vViewInfo中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convViewInfo.ViewId)
{
return mstrViewId;
}
else if (strAttributeName  ==  convViewInfo.TitleStyleId)
{
return mstrTitleStyleId;
}
else if (strAttributeName  ==  convViewInfo.TitleStyleName)
{
return mstrTitleStyleName;
}
else if (strAttributeName  ==  convViewInfo.DgStyleId)
{
return mstrDgStyleId;
}
else if (strAttributeName  ==  convViewInfo.DgStyleName)
{
return mstrDgStyleName;
}
else if (strAttributeName  ==  convViewInfo.ViewName)
{
return mstrViewName;
}
else if (strAttributeName  ==  convViewInfo.ApplicationTypeId)
{
return mintApplicationTypeId;
}
else if (strAttributeName  ==  convViewInfo.ApplicationTypeSimName)
{
return mstrApplicationTypeSimName;
}
else if (strAttributeName  ==  convViewInfo.FuncModuleAgcId)
{
return mstrFuncModuleAgcId;
}
else if (strAttributeName  ==  convViewInfo.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convViewInfo.FuncModuleEnName)
{
return mstrFuncModuleEnName;
}
else if (strAttributeName  ==  convViewInfo.DataBaseName)
{
return mstrDataBaseName;
}
else if (strAttributeName  ==  convViewInfo.KeyForMainTab)
{
return mstrKeyForMainTab;
}
else if (strAttributeName  ==  convViewInfo.KeyForDetailTab)
{
return mstrKeyForDetailTab;
}
else if (strAttributeName  ==  convViewInfo.IsNeedSort)
{
return mbolIsNeedSort;
}
else if (strAttributeName  ==  convViewInfo.IsNeedTransCode)
{
return mbolIsNeedTransCode;
}
else if (strAttributeName  ==  convViewInfo.IsNeedSetExportFld)
{
return mbolIsNeedSetExportFld;
}
else if (strAttributeName  ==  convViewInfo.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convViewInfo.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convViewInfo.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convViewInfo.ViewFunction)
{
return mstrViewFunction;
}
else if (strAttributeName  ==  convViewInfo.ViewDetail)
{
return mstrViewDetail;
}
else if (strAttributeName  ==  convViewInfo.DefaMenuName)
{
return mstrDefaMenuName;
}
else if (strAttributeName  ==  convViewInfo.DetailTabId)
{
return mstrDetailTabId;
}
else if (strAttributeName  ==  convViewInfo.FileName)
{
return mstrFileName;
}
else if (strAttributeName  ==  convViewInfo.FilePath)
{
return mstrFilePath;
}
else if (strAttributeName  ==  convViewInfo.MainTabId)
{
return mstrMainTabId;
}
else if (strAttributeName  ==  convViewInfo.ViewCnName)
{
return mstrViewCnName;
}
else if (strAttributeName  ==  convViewInfo.ViewGroupId)
{
return mstrViewGroupId;
}
else if (strAttributeName  ==  convViewInfo.ViewGroupName)
{
return mstrViewGroupName;
}
else if (strAttributeName  ==  convViewInfo.InSqlDsTypeId)
{
return mstrInSqlDsTypeId;
}
else if (strAttributeName  ==  convViewInfo.OutSqlDsTypeId)
{
return mstrOutSqlDsTypeId;
}
else if (strAttributeName  ==  convViewInfo.GeneCodeDate)
{
return mstrGeneCodeDate;
}
else if (strAttributeName  ==  convViewInfo.TaskId)
{
return mstrTaskId;
}
else if (strAttributeName  ==  convViewInfo.KeyId4Test)
{
return mstrKeyId4Test;
}
else if (strAttributeName  ==  convViewInfo.ViewMasterId)
{
return mstrViewMasterId;
}
else if (strAttributeName  ==  convViewInfo.ViewMasterName)
{
return mstrViewMasterName;
}
else if (strAttributeName  ==  convViewInfo.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convViewInfo.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convViewInfo.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convViewInfo.MainTabName)
{
return mstrMainTabName;
}
else if (strAttributeName  ==  convViewInfo.DetailTabName)
{
return mstrDetailTabName;
}
else if (strAttributeName  ==  convViewInfo.MainTabKeyFld)
{
return mstrMainTabKeyFld;
}
else if (strAttributeName  ==  convViewInfo.RegionNum)
{
return mintRegionNum;
}
else if (strAttributeName  ==  convViewInfo.DetailTabKeyFld)
{
return mstrDetailTabKeyFld;
}
return null;
}
set
{
if (strAttributeName  ==  convViewInfo.ViewId)
{
mstrViewId = value.ToString();
 AddUpdatedFld(convViewInfo.ViewId);
}
else if (strAttributeName  ==  convViewInfo.TitleStyleId)
{
mstrTitleStyleId = value.ToString();
 AddUpdatedFld(convViewInfo.TitleStyleId);
}
else if (strAttributeName  ==  convViewInfo.TitleStyleName)
{
mstrTitleStyleName = value.ToString();
 AddUpdatedFld(convViewInfo.TitleStyleName);
}
else if (strAttributeName  ==  convViewInfo.DgStyleId)
{
mstrDgStyleId = value.ToString();
 AddUpdatedFld(convViewInfo.DgStyleId);
}
else if (strAttributeName  ==  convViewInfo.DgStyleName)
{
mstrDgStyleName = value.ToString();
 AddUpdatedFld(convViewInfo.DgStyleName);
}
else if (strAttributeName  ==  convViewInfo.ViewName)
{
mstrViewName = value.ToString();
 AddUpdatedFld(convViewInfo.ViewName);
}
else if (strAttributeName  ==  convViewInfo.ApplicationTypeId)
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewInfo.ApplicationTypeId);
}
else if (strAttributeName  ==  convViewInfo.ApplicationTypeSimName)
{
mstrApplicationTypeSimName = value.ToString();
 AddUpdatedFld(convViewInfo.ApplicationTypeSimName);
}
else if (strAttributeName  ==  convViewInfo.FuncModuleAgcId)
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convViewInfo.FuncModuleAgcId);
}
else if (strAttributeName  ==  convViewInfo.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convViewInfo.FuncModuleName);
}
else if (strAttributeName  ==  convViewInfo.FuncModuleEnName)
{
mstrFuncModuleEnName = value.ToString();
 AddUpdatedFld(convViewInfo.FuncModuleEnName);
}
else if (strAttributeName  ==  convViewInfo.DataBaseName)
{
mstrDataBaseName = value.ToString();
 AddUpdatedFld(convViewInfo.DataBaseName);
}
else if (strAttributeName  ==  convViewInfo.KeyForMainTab)
{
mstrKeyForMainTab = value.ToString();
 AddUpdatedFld(convViewInfo.KeyForMainTab);
}
else if (strAttributeName  ==  convViewInfo.KeyForDetailTab)
{
mstrKeyForDetailTab = value.ToString();
 AddUpdatedFld(convViewInfo.KeyForDetailTab);
}
else if (strAttributeName  ==  convViewInfo.IsNeedSort)
{
mbolIsNeedSort = TransNullToBool(value.ToString());
 AddUpdatedFld(convViewInfo.IsNeedSort);
}
else if (strAttributeName  ==  convViewInfo.IsNeedTransCode)
{
mbolIsNeedTransCode = TransNullToBool(value.ToString());
 AddUpdatedFld(convViewInfo.IsNeedTransCode);
}
else if (strAttributeName  ==  convViewInfo.IsNeedSetExportFld)
{
mbolIsNeedSetExportFld = TransNullToBool(value.ToString());
 AddUpdatedFld(convViewInfo.IsNeedSetExportFld);
}
else if (strAttributeName  ==  convViewInfo.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convViewInfo.UserId);
}
else if (strAttributeName  ==  convViewInfo.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convViewInfo.PrjId);
}
else if (strAttributeName  ==  convViewInfo.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convViewInfo.PrjName);
}
else if (strAttributeName  ==  convViewInfo.ViewFunction)
{
mstrViewFunction = value.ToString();
 AddUpdatedFld(convViewInfo.ViewFunction);
}
else if (strAttributeName  ==  convViewInfo.ViewDetail)
{
mstrViewDetail = value.ToString();
 AddUpdatedFld(convViewInfo.ViewDetail);
}
else if (strAttributeName  ==  convViewInfo.DefaMenuName)
{
mstrDefaMenuName = value.ToString();
 AddUpdatedFld(convViewInfo.DefaMenuName);
}
else if (strAttributeName  ==  convViewInfo.DetailTabId)
{
mstrDetailTabId = value.ToString();
 AddUpdatedFld(convViewInfo.DetailTabId);
}
else if (strAttributeName  ==  convViewInfo.FileName)
{
mstrFileName = value.ToString();
 AddUpdatedFld(convViewInfo.FileName);
}
else if (strAttributeName  ==  convViewInfo.FilePath)
{
mstrFilePath = value.ToString();
 AddUpdatedFld(convViewInfo.FilePath);
}
else if (strAttributeName  ==  convViewInfo.MainTabId)
{
mstrMainTabId = value.ToString();
 AddUpdatedFld(convViewInfo.MainTabId);
}
else if (strAttributeName  ==  convViewInfo.ViewCnName)
{
mstrViewCnName = value.ToString();
 AddUpdatedFld(convViewInfo.ViewCnName);
}
else if (strAttributeName  ==  convViewInfo.ViewGroupId)
{
mstrViewGroupId = value.ToString();
 AddUpdatedFld(convViewInfo.ViewGroupId);
}
else if (strAttributeName  ==  convViewInfo.ViewGroupName)
{
mstrViewGroupName = value.ToString();
 AddUpdatedFld(convViewInfo.ViewGroupName);
}
else if (strAttributeName  ==  convViewInfo.InSqlDsTypeId)
{
mstrInSqlDsTypeId = value.ToString();
 AddUpdatedFld(convViewInfo.InSqlDsTypeId);
}
else if (strAttributeName  ==  convViewInfo.OutSqlDsTypeId)
{
mstrOutSqlDsTypeId = value.ToString();
 AddUpdatedFld(convViewInfo.OutSqlDsTypeId);
}
else if (strAttributeName  ==  convViewInfo.GeneCodeDate)
{
mstrGeneCodeDate = value.ToString();
 AddUpdatedFld(convViewInfo.GeneCodeDate);
}
else if (strAttributeName  ==  convViewInfo.TaskId)
{
mstrTaskId = value.ToString();
 AddUpdatedFld(convViewInfo.TaskId);
}
else if (strAttributeName  ==  convViewInfo.KeyId4Test)
{
mstrKeyId4Test = value.ToString();
 AddUpdatedFld(convViewInfo.KeyId4Test);
}
else if (strAttributeName  ==  convViewInfo.ViewMasterId)
{
mstrViewMasterId = value.ToString();
 AddUpdatedFld(convViewInfo.ViewMasterId);
}
else if (strAttributeName  ==  convViewInfo.ViewMasterName)
{
mstrViewMasterName = value.ToString();
 AddUpdatedFld(convViewInfo.ViewMasterName);
}
else if (strAttributeName  ==  convViewInfo.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convViewInfo.UpdDate);
}
else if (strAttributeName  ==  convViewInfo.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convViewInfo.UpdUserId);
}
else if (strAttributeName  ==  convViewInfo.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convViewInfo.Memo);
}
else if (strAttributeName  ==  convViewInfo.MainTabName)
{
mstrMainTabName = value.ToString();
 AddUpdatedFld(convViewInfo.MainTabName);
}
else if (strAttributeName  ==  convViewInfo.DetailTabName)
{
mstrDetailTabName = value.ToString();
 AddUpdatedFld(convViewInfo.DetailTabName);
}
else if (strAttributeName  ==  convViewInfo.MainTabKeyFld)
{
mstrMainTabKeyFld = value.ToString();
 AddUpdatedFld(convViewInfo.MainTabKeyFld);
}
else if (strAttributeName  ==  convViewInfo.RegionNum)
{
mintRegionNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewInfo.RegionNum);
}
else if (strAttributeName  ==  convViewInfo.DetailTabKeyFld)
{
mstrDetailTabKeyFld = value.ToString();
 AddUpdatedFld(convViewInfo.DetailTabKeyFld);
}
}
}
public object this[int intIndex]
{
get
{
if (convViewInfo.ViewId  ==  _AttributeName[intIndex])
{
return mstrViewId;
}
else if (convViewInfo.TitleStyleId  ==  _AttributeName[intIndex])
{
return mstrTitleStyleId;
}
else if (convViewInfo.TitleStyleName  ==  _AttributeName[intIndex])
{
return mstrTitleStyleName;
}
else if (convViewInfo.DgStyleId  ==  _AttributeName[intIndex])
{
return mstrDgStyleId;
}
else if (convViewInfo.DgStyleName  ==  _AttributeName[intIndex])
{
return mstrDgStyleName;
}
else if (convViewInfo.ViewName  ==  _AttributeName[intIndex])
{
return mstrViewName;
}
else if (convViewInfo.ApplicationTypeId  ==  _AttributeName[intIndex])
{
return mintApplicationTypeId;
}
else if (convViewInfo.ApplicationTypeSimName  ==  _AttributeName[intIndex])
{
return mstrApplicationTypeSimName;
}
else if (convViewInfo.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
return mstrFuncModuleAgcId;
}
else if (convViewInfo.FuncModuleName  ==  _AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convViewInfo.FuncModuleEnName  ==  _AttributeName[intIndex])
{
return mstrFuncModuleEnName;
}
else if (convViewInfo.DataBaseName  ==  _AttributeName[intIndex])
{
return mstrDataBaseName;
}
else if (convViewInfo.KeyForMainTab  ==  _AttributeName[intIndex])
{
return mstrKeyForMainTab;
}
else if (convViewInfo.KeyForDetailTab  ==  _AttributeName[intIndex])
{
return mstrKeyForDetailTab;
}
else if (convViewInfo.IsNeedSort  ==  _AttributeName[intIndex])
{
return mbolIsNeedSort;
}
else if (convViewInfo.IsNeedTransCode  ==  _AttributeName[intIndex])
{
return mbolIsNeedTransCode;
}
else if (convViewInfo.IsNeedSetExportFld  ==  _AttributeName[intIndex])
{
return mbolIsNeedSetExportFld;
}
else if (convViewInfo.UserId  ==  _AttributeName[intIndex])
{
return mstrUserId;
}
else if (convViewInfo.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convViewInfo.PrjName  ==  _AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convViewInfo.ViewFunction  ==  _AttributeName[intIndex])
{
return mstrViewFunction;
}
else if (convViewInfo.ViewDetail  ==  _AttributeName[intIndex])
{
return mstrViewDetail;
}
else if (convViewInfo.DefaMenuName  ==  _AttributeName[intIndex])
{
return mstrDefaMenuName;
}
else if (convViewInfo.DetailTabId  ==  _AttributeName[intIndex])
{
return mstrDetailTabId;
}
else if (convViewInfo.FileName  ==  _AttributeName[intIndex])
{
return mstrFileName;
}
else if (convViewInfo.FilePath  ==  _AttributeName[intIndex])
{
return mstrFilePath;
}
else if (convViewInfo.MainTabId  ==  _AttributeName[intIndex])
{
return mstrMainTabId;
}
else if (convViewInfo.ViewCnName  ==  _AttributeName[intIndex])
{
return mstrViewCnName;
}
else if (convViewInfo.ViewGroupId  ==  _AttributeName[intIndex])
{
return mstrViewGroupId;
}
else if (convViewInfo.ViewGroupName  ==  _AttributeName[intIndex])
{
return mstrViewGroupName;
}
else if (convViewInfo.InSqlDsTypeId  ==  _AttributeName[intIndex])
{
return mstrInSqlDsTypeId;
}
else if (convViewInfo.OutSqlDsTypeId  ==  _AttributeName[intIndex])
{
return mstrOutSqlDsTypeId;
}
else if (convViewInfo.GeneCodeDate  ==  _AttributeName[intIndex])
{
return mstrGeneCodeDate;
}
else if (convViewInfo.TaskId  ==  _AttributeName[intIndex])
{
return mstrTaskId;
}
else if (convViewInfo.KeyId4Test  ==  _AttributeName[intIndex])
{
return mstrKeyId4Test;
}
else if (convViewInfo.ViewMasterId  ==  _AttributeName[intIndex])
{
return mstrViewMasterId;
}
else if (convViewInfo.ViewMasterName  ==  _AttributeName[intIndex])
{
return mstrViewMasterName;
}
else if (convViewInfo.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convViewInfo.UpdUserId  ==  _AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convViewInfo.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (convViewInfo.MainTabName  ==  _AttributeName[intIndex])
{
return mstrMainTabName;
}
else if (convViewInfo.DetailTabName  ==  _AttributeName[intIndex])
{
return mstrDetailTabName;
}
else if (convViewInfo.MainTabKeyFld  ==  _AttributeName[intIndex])
{
return mstrMainTabKeyFld;
}
else if (convViewInfo.RegionNum  ==  _AttributeName[intIndex])
{
return mintRegionNum;
}
else if (convViewInfo.DetailTabKeyFld  ==  _AttributeName[intIndex])
{
return mstrDetailTabKeyFld;
}
return null;
}
set
{
if (convViewInfo.ViewId  ==  _AttributeName[intIndex])
{
mstrViewId = value.ToString();
 AddUpdatedFld(convViewInfo.ViewId);
}
else if (convViewInfo.TitleStyleId  ==  _AttributeName[intIndex])
{
mstrTitleStyleId = value.ToString();
 AddUpdatedFld(convViewInfo.TitleStyleId);
}
else if (convViewInfo.TitleStyleName  ==  _AttributeName[intIndex])
{
mstrTitleStyleName = value.ToString();
 AddUpdatedFld(convViewInfo.TitleStyleName);
}
else if (convViewInfo.DgStyleId  ==  _AttributeName[intIndex])
{
mstrDgStyleId = value.ToString();
 AddUpdatedFld(convViewInfo.DgStyleId);
}
else if (convViewInfo.DgStyleName  ==  _AttributeName[intIndex])
{
mstrDgStyleName = value.ToString();
 AddUpdatedFld(convViewInfo.DgStyleName);
}
else if (convViewInfo.ViewName  ==  _AttributeName[intIndex])
{
mstrViewName = value.ToString();
 AddUpdatedFld(convViewInfo.ViewName);
}
else if (convViewInfo.ApplicationTypeId  ==  _AttributeName[intIndex])
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewInfo.ApplicationTypeId);
}
else if (convViewInfo.ApplicationTypeSimName  ==  _AttributeName[intIndex])
{
mstrApplicationTypeSimName = value.ToString();
 AddUpdatedFld(convViewInfo.ApplicationTypeSimName);
}
else if (convViewInfo.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convViewInfo.FuncModuleAgcId);
}
else if (convViewInfo.FuncModuleName  ==  _AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convViewInfo.FuncModuleName);
}
else if (convViewInfo.FuncModuleEnName  ==  _AttributeName[intIndex])
{
mstrFuncModuleEnName = value.ToString();
 AddUpdatedFld(convViewInfo.FuncModuleEnName);
}
else if (convViewInfo.DataBaseName  ==  _AttributeName[intIndex])
{
mstrDataBaseName = value.ToString();
 AddUpdatedFld(convViewInfo.DataBaseName);
}
else if (convViewInfo.KeyForMainTab  ==  _AttributeName[intIndex])
{
mstrKeyForMainTab = value.ToString();
 AddUpdatedFld(convViewInfo.KeyForMainTab);
}
else if (convViewInfo.KeyForDetailTab  ==  _AttributeName[intIndex])
{
mstrKeyForDetailTab = value.ToString();
 AddUpdatedFld(convViewInfo.KeyForDetailTab);
}
else if (convViewInfo.IsNeedSort  ==  _AttributeName[intIndex])
{
mbolIsNeedSort = TransNullToBool(value.ToString());
 AddUpdatedFld(convViewInfo.IsNeedSort);
}
else if (convViewInfo.IsNeedTransCode  ==  _AttributeName[intIndex])
{
mbolIsNeedTransCode = TransNullToBool(value.ToString());
 AddUpdatedFld(convViewInfo.IsNeedTransCode);
}
else if (convViewInfo.IsNeedSetExportFld  ==  _AttributeName[intIndex])
{
mbolIsNeedSetExportFld = TransNullToBool(value.ToString());
 AddUpdatedFld(convViewInfo.IsNeedSetExportFld);
}
else if (convViewInfo.UserId  ==  _AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convViewInfo.UserId);
}
else if (convViewInfo.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convViewInfo.PrjId);
}
else if (convViewInfo.PrjName  ==  _AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convViewInfo.PrjName);
}
else if (convViewInfo.ViewFunction  ==  _AttributeName[intIndex])
{
mstrViewFunction = value.ToString();
 AddUpdatedFld(convViewInfo.ViewFunction);
}
else if (convViewInfo.ViewDetail  ==  _AttributeName[intIndex])
{
mstrViewDetail = value.ToString();
 AddUpdatedFld(convViewInfo.ViewDetail);
}
else if (convViewInfo.DefaMenuName  ==  _AttributeName[intIndex])
{
mstrDefaMenuName = value.ToString();
 AddUpdatedFld(convViewInfo.DefaMenuName);
}
else if (convViewInfo.DetailTabId  ==  _AttributeName[intIndex])
{
mstrDetailTabId = value.ToString();
 AddUpdatedFld(convViewInfo.DetailTabId);
}
else if (convViewInfo.FileName  ==  _AttributeName[intIndex])
{
mstrFileName = value.ToString();
 AddUpdatedFld(convViewInfo.FileName);
}
else if (convViewInfo.FilePath  ==  _AttributeName[intIndex])
{
mstrFilePath = value.ToString();
 AddUpdatedFld(convViewInfo.FilePath);
}
else if (convViewInfo.MainTabId  ==  _AttributeName[intIndex])
{
mstrMainTabId = value.ToString();
 AddUpdatedFld(convViewInfo.MainTabId);
}
else if (convViewInfo.ViewCnName  ==  _AttributeName[intIndex])
{
mstrViewCnName = value.ToString();
 AddUpdatedFld(convViewInfo.ViewCnName);
}
else if (convViewInfo.ViewGroupId  ==  _AttributeName[intIndex])
{
mstrViewGroupId = value.ToString();
 AddUpdatedFld(convViewInfo.ViewGroupId);
}
else if (convViewInfo.ViewGroupName  ==  _AttributeName[intIndex])
{
mstrViewGroupName = value.ToString();
 AddUpdatedFld(convViewInfo.ViewGroupName);
}
else if (convViewInfo.InSqlDsTypeId  ==  _AttributeName[intIndex])
{
mstrInSqlDsTypeId = value.ToString();
 AddUpdatedFld(convViewInfo.InSqlDsTypeId);
}
else if (convViewInfo.OutSqlDsTypeId  ==  _AttributeName[intIndex])
{
mstrOutSqlDsTypeId = value.ToString();
 AddUpdatedFld(convViewInfo.OutSqlDsTypeId);
}
else if (convViewInfo.GeneCodeDate  ==  _AttributeName[intIndex])
{
mstrGeneCodeDate = value.ToString();
 AddUpdatedFld(convViewInfo.GeneCodeDate);
}
else if (convViewInfo.TaskId  ==  _AttributeName[intIndex])
{
mstrTaskId = value.ToString();
 AddUpdatedFld(convViewInfo.TaskId);
}
else if (convViewInfo.KeyId4Test  ==  _AttributeName[intIndex])
{
mstrKeyId4Test = value.ToString();
 AddUpdatedFld(convViewInfo.KeyId4Test);
}
else if (convViewInfo.ViewMasterId  ==  _AttributeName[intIndex])
{
mstrViewMasterId = value.ToString();
 AddUpdatedFld(convViewInfo.ViewMasterId);
}
else if (convViewInfo.ViewMasterName  ==  _AttributeName[intIndex])
{
mstrViewMasterName = value.ToString();
 AddUpdatedFld(convViewInfo.ViewMasterName);
}
else if (convViewInfo.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convViewInfo.UpdDate);
}
else if (convViewInfo.UpdUserId  ==  _AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convViewInfo.UpdUserId);
}
else if (convViewInfo.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convViewInfo.Memo);
}
else if (convViewInfo.MainTabName  ==  _AttributeName[intIndex])
{
mstrMainTabName = value.ToString();
 AddUpdatedFld(convViewInfo.MainTabName);
}
else if (convViewInfo.DetailTabName  ==  _AttributeName[intIndex])
{
mstrDetailTabName = value.ToString();
 AddUpdatedFld(convViewInfo.DetailTabName);
}
else if (convViewInfo.MainTabKeyFld  ==  _AttributeName[intIndex])
{
mstrMainTabKeyFld = value.ToString();
 AddUpdatedFld(convViewInfo.MainTabKeyFld);
}
else if (convViewInfo.RegionNum  ==  _AttributeName[intIndex])
{
mintRegionNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewInfo.RegionNum);
}
else if (convViewInfo.DetailTabKeyFld  ==  _AttributeName[intIndex])
{
mstrDetailTabKeyFld = value.ToString();
 AddUpdatedFld(convViewInfo.DetailTabKeyFld);
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
 AddUpdatedFld(convViewInfo.ViewId);
}
}
/// <summary>
/// 标题类型Id(说明:;字段类型:varchar;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TitleStyleId
{
get
{
return mstrTitleStyleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTitleStyleId = value;
}
else
{
 mstrTitleStyleId = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewInfo.TitleStyleId);
}
}
/// <summary>
/// 标题类型名(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TitleStyleName
{
get
{
return mstrTitleStyleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTitleStyleName = value;
}
else
{
 mstrTitleStyleName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewInfo.TitleStyleName);
}
}
/// <summary>
/// DG模式ID(说明:;字段类型:varchar;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DgStyleId
{
get
{
return mstrDgStyleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDgStyleId = value;
}
else
{
 mstrDgStyleId = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewInfo.DgStyleId);
}
}
/// <summary>
/// DG模式名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DgStyleName
{
get
{
return mstrDgStyleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDgStyleName = value;
}
else
{
 mstrDgStyleName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewInfo.DgStyleName);
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
 AddUpdatedFld(convViewInfo.ViewName);
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
 AddUpdatedFld(convViewInfo.ApplicationTypeId);
}
}
/// <summary>
/// 应用程序类型简称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ApplicationTypeSimName
{
get
{
return mstrApplicationTypeSimName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrApplicationTypeSimName = value;
}
else
{
 mstrApplicationTypeSimName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewInfo.ApplicationTypeSimName);
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
 AddUpdatedFld(convViewInfo.FuncModuleAgcId);
}
}
/// <summary>
/// 功能模块名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleName
{
get
{
return mstrFuncModuleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleName = value;
}
else
{
 mstrFuncModuleName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewInfo.FuncModuleName);
}
}
/// <summary>
/// 功能模块英文名称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleEnName
{
get
{
return mstrFuncModuleEnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleEnName = value;
}
else
{
 mstrFuncModuleEnName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewInfo.FuncModuleEnName);
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
 AddUpdatedFld(convViewInfo.DataBaseName);
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
 AddUpdatedFld(convViewInfo.KeyForMainTab);
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
 AddUpdatedFld(convViewInfo.KeyForDetailTab);
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
 AddUpdatedFld(convViewInfo.IsNeedSort);
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
 AddUpdatedFld(convViewInfo.IsNeedTransCode);
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
 AddUpdatedFld(convViewInfo.IsNeedSetExportFld);
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
 AddUpdatedFld(convViewInfo.UserId);
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
 AddUpdatedFld(convViewInfo.PrjId);
}
}
/// <summary>
/// 工程名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
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
mintErrNo = 1;
 mstrPrjName = value;
}
else
{
 mstrPrjName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewInfo.PrjName);
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
 AddUpdatedFld(convViewInfo.ViewFunction);
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
 AddUpdatedFld(convViewInfo.ViewDetail);
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
 AddUpdatedFld(convViewInfo.DefaMenuName);
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
 AddUpdatedFld(convViewInfo.DetailTabId);
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
 AddUpdatedFld(convViewInfo.FileName);
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
 AddUpdatedFld(convViewInfo.FilePath);
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
 AddUpdatedFld(convViewInfo.MainTabId);
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
 AddUpdatedFld(convViewInfo.ViewCnName);
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
 AddUpdatedFld(convViewInfo.ViewGroupId);
}
}
/// <summary>
/// 界面组名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewGroupName
{
get
{
return mstrViewGroupName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewGroupName = value;
}
else
{
 mstrViewGroupName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewInfo.ViewGroupName);
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
 AddUpdatedFld(convViewInfo.InSqlDsTypeId);
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
 AddUpdatedFld(convViewInfo.OutSqlDsTypeId);
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
 AddUpdatedFld(convViewInfo.GeneCodeDate);
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
 AddUpdatedFld(convViewInfo.TaskId);
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
 AddUpdatedFld(convViewInfo.KeyId4Test);
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
 AddUpdatedFld(convViewInfo.ViewMasterId);
}
}
/// <summary>
/// 界面母版名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewMasterName
{
get
{
return mstrViewMasterName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewMasterName = value;
}
else
{
 mstrViewMasterName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewInfo.ViewMasterName);
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
 AddUpdatedFld(convViewInfo.UpdDate);
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
 AddUpdatedFld(convViewInfo.UpdUserId);
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
 AddUpdatedFld(convViewInfo.Memo);
}
}
/// <summary>
/// 主表(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MainTabName
{
get
{
return mstrMainTabName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMainTabName = value;
}
else
{
 mstrMainTabName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewInfo.MainTabName);
}
}
/// <summary>
/// 详细表(说明:;字段类型:varchar;字段长度:40;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DetailTabName
{
get
{
return mstrDetailTabName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDetailTabName = value;
}
else
{
 mstrDetailTabName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewInfo.DetailTabName);
}
}
/// <summary>
/// 主表关键字(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MainTabKeyFld
{
get
{
return mstrMainTabKeyFld;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMainTabKeyFld = value;
}
else
{
 mstrMainTabKeyFld = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewInfo.MainTabKeyFld);
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
 AddUpdatedFld(convViewInfo.RegionNum);
}
}
/// <summary>
/// 详细表关键字(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DetailTabKeyFld
{
get
{
return mstrDetailTabKeyFld;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDetailTabKeyFld = value;
}
else
{
 mstrDetailTabKeyFld = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewInfo.DetailTabKeyFld);
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
 /// v界面(vViewInfo)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convViewInfo
{
public const string _CurrTabName = "vViewInfo"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ViewId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"ViewId", "TitleStyleId", "TitleStyleName", "DgStyleId", "DgStyleName", "ViewName", "ApplicationTypeId", "ApplicationTypeSimName", "FuncModuleAgcId", "FuncModuleName", "FuncModuleEnName", "DataBaseName", "KeyForMainTab", "KeyForDetailTab", "IsNeedSort", "IsNeedTransCode", "IsNeedSetExportFld", "UserId", "PrjId", "PrjName", "ViewFunction", "ViewDetail", "DefaMenuName", "DetailTabId", "FileName", "FilePath", "MainTabId", "ViewCnName", "ViewGroupId", "ViewGroupName", "InSqlDsTypeId", "OutSqlDsTypeId", "GeneCodeDate", "TaskId", "KeyId4Test", "ViewMasterId", "ViewMasterName", "UpdDate", "UpdUserId", "Memo", "MainTabName", "DetailTabName", "MainTabKeyFld", "RegionNum", "DetailTabKeyFld"};
//以下是属性变量


 /// <summary>
 /// 常量:"ViewId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewId = "ViewId";    //界面Id

 /// <summary>
 /// 常量:"TitleStyleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TitleStyleId = "TitleStyleId";    //标题类型Id

 /// <summary>
 /// 常量:"TitleStyleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TitleStyleName = "TitleStyleName";    //标题类型名

 /// <summary>
 /// 常量:"DgStyleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DgStyleId = "DgStyleId";    //DG模式ID

 /// <summary>
 /// 常量:"DgStyleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DgStyleName = "DgStyleName";    //DG模式名

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
 /// 常量:"ApplicationTypeSimName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeSimName = "ApplicationTypeSimName";    //应用程序类型简称

 /// <summary>
 /// 常量:"FuncModuleAgcId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleAgcId = "FuncModuleAgcId";    //功能模块Id

 /// <summary>
 /// 常量:"FuncModuleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleName = "FuncModuleName";    //功能模块名称

 /// <summary>
 /// 常量:"FuncModuleEnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleEnName = "FuncModuleEnName";    //功能模块英文名称

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
 /// 常量:"PrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjName = "PrjName";    //工程名称

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
 /// 常量:"ViewGroupName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewGroupName = "ViewGroupName";    //界面组名称

 /// <summary>
 /// 常量:"InSqlDsTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InSqlDsTypeId = "InSqlDsTypeId";    //输入数据源类型

 /// <summary>
 /// 常量:"OutSqlDsTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OutSqlDsTypeId = "OutSqlDsTypeId";    //输出数据源类型

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
 /// 常量:"ViewMasterName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewMasterName = "ViewMasterName";    //界面母版名

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
 /// 常量:"MainTabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MainTabName = "MainTabName";    //主表

 /// <summary>
 /// 常量:"DetailTabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DetailTabName = "DetailTabName";    //详细表

 /// <summary>
 /// 常量:"MainTabKeyFld"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MainTabKeyFld = "MainTabKeyFld";    //主表关键字

 /// <summary>
 /// 常量:"RegionNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RegionNum = "RegionNum";    //区域数

 /// <summary>
 /// 常量:"DetailTabKeyFld"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DetailTabKeyFld = "DetailTabKeyFld";    //详细表关键字
}

}