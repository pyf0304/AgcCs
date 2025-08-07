
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewInfo4GeneCodeEN
 表名:vViewInfo4GeneCode(00050283)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:46:46
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:日志管理(LogManage)
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
 /// 表vViewInfo4GeneCode的关键字(ViewId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ViewId_vViewInfo4GeneCode
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
public K_ViewId_vViewInfo4GeneCode(string strViewId)
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
 /// <returns>返回:[K_ViewId_vViewInfo4GeneCode]类型的对象</returns>
public static implicit operator K_ViewId_vViewInfo4GeneCode(string value)
{
return new K_ViewId_vViewInfo4GeneCode(value);
}
}
 /// <summary>
 /// vViewInfo4GeneCode(vViewInfo4GeneCode)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvViewInfo4GeneCodeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vViewInfo4GeneCode"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ViewId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 42;
public static string[] _AttributeName = new string[] {"ViewId", "TitleStyleId", "TitleStyleName", "DgStyleId", "DgStyleName", "VersionGeneCode", "ViewName", "ViewTypeCode", "ViewTypeName", "ApplicationTypeId", "ApplicationTypeName", "FuncModuleAgcId", "FuncModuleName", "FuncModuleEnName", "DataBaseName", "KeyForMainTab", "KeyForDetailTab", "IsNeedSort", "IsNeedTransCode", "UserId", "PrjId", "PrjName", "ViewFunction", "ViewDetail", "DefaMenuName", "DetailTabId", "FileName", "FilePath", "MainTabId", "ViewCnName", "ViewGroupId", "ViewGroupName", "InSqlDsTypeId", "OutSqlDsTypeId", "GeneCodeDate", "RegionNum", "UpdDate", "MainTabName", "DetailTabName", "MainTabKeyFld", "DetailTabKeyFld", "UserId4GeneCode"};

protected string mstrViewId;    //界面Id
protected string mstrTitleStyleId;    //标题类型Id
protected string mstrTitleStyleName;    //标题类型名
protected string mstrDgStyleId;    //DG模式ID
protected string mstrDgStyleName;    //DG模式名
protected string mstrVersionGeneCode;    //生成代码版本
protected string mstrViewName;    //界面名称
protected int mintViewTypeCode;    //界面类型码
protected string mstrViewTypeName;    //界面类型名称
protected int? mintApplicationTypeId;    //应用程序类型ID
protected string mstrApplicationTypeName;    //应用程序类型名称
protected string mstrFuncModuleAgcId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrFuncModuleEnName;    //功能模块英文名称
protected string mstrDataBaseName;    //数据库名
protected string mstrKeyForMainTab;    //主表关键字
protected string mstrKeyForDetailTab;    //明细表关键字
protected bool mbolIsNeedSort;    //是否需要排序
protected bool mbolIsNeedTransCode;    //是否需要转换代码
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
protected int? mintRegionNum;    //区域数
protected string mstrUpdDate;    //修改日期
protected string mstrMainTabName;    //主表
protected string mstrDetailTabName;    //详细表
protected string mstrMainTabKeyFld;    //主表关键字
protected string mstrDetailTabKeyFld;    //详细表关键字
protected string mstrUserId4GeneCode;    //UserId4GeneCode

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvViewInfo4GeneCodeEN()
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
public clsvViewInfo4GeneCodeEN(string strViewId)
 {
strViewId = strViewId.Replace("'", "''");
if (strViewId.Length > 8)
{
throw new Exception("在表:vViewInfo4GeneCode中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strViewId)  ==  true)
{
throw new Exception("在表:vViewInfo4GeneCode中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convViewInfo4GeneCode.ViewId)
{
return mstrViewId;
}
else if (strAttributeName  ==  convViewInfo4GeneCode.TitleStyleId)
{
return mstrTitleStyleId;
}
else if (strAttributeName  ==  convViewInfo4GeneCode.TitleStyleName)
{
return mstrTitleStyleName;
}
else if (strAttributeName  ==  convViewInfo4GeneCode.DgStyleId)
{
return mstrDgStyleId;
}
else if (strAttributeName  ==  convViewInfo4GeneCode.DgStyleName)
{
return mstrDgStyleName;
}
else if (strAttributeName  ==  convViewInfo4GeneCode.VersionGeneCode)
{
return mstrVersionGeneCode;
}
else if (strAttributeName  ==  convViewInfo4GeneCode.ViewName)
{
return mstrViewName;
}
else if (strAttributeName  ==  convViewInfo4GeneCode.ViewTypeCode)
{
return mintViewTypeCode;
}
else if (strAttributeName  ==  convViewInfo4GeneCode.ViewTypeName)
{
return mstrViewTypeName;
}
else if (strAttributeName  ==  convViewInfo4GeneCode.ApplicationTypeId)
{
return mintApplicationTypeId;
}
else if (strAttributeName  ==  convViewInfo4GeneCode.ApplicationTypeName)
{
return mstrApplicationTypeName;
}
else if (strAttributeName  ==  convViewInfo4GeneCode.FuncModuleAgcId)
{
return mstrFuncModuleAgcId;
}
else if (strAttributeName  ==  convViewInfo4GeneCode.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convViewInfo4GeneCode.FuncModuleEnName)
{
return mstrFuncModuleEnName;
}
else if (strAttributeName  ==  convViewInfo4GeneCode.DataBaseName)
{
return mstrDataBaseName;
}
else if (strAttributeName  ==  convViewInfo4GeneCode.KeyForMainTab)
{
return mstrKeyForMainTab;
}
else if (strAttributeName  ==  convViewInfo4GeneCode.KeyForDetailTab)
{
return mstrKeyForDetailTab;
}
else if (strAttributeName  ==  convViewInfo4GeneCode.IsNeedSort)
{
return mbolIsNeedSort;
}
else if (strAttributeName  ==  convViewInfo4GeneCode.IsNeedTransCode)
{
return mbolIsNeedTransCode;
}
else if (strAttributeName  ==  convViewInfo4GeneCode.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convViewInfo4GeneCode.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convViewInfo4GeneCode.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convViewInfo4GeneCode.ViewFunction)
{
return mstrViewFunction;
}
else if (strAttributeName  ==  convViewInfo4GeneCode.ViewDetail)
{
return mstrViewDetail;
}
else if (strAttributeName  ==  convViewInfo4GeneCode.DefaMenuName)
{
return mstrDefaMenuName;
}
else if (strAttributeName  ==  convViewInfo4GeneCode.DetailTabId)
{
return mstrDetailTabId;
}
else if (strAttributeName  ==  convViewInfo4GeneCode.FileName)
{
return mstrFileName;
}
else if (strAttributeName  ==  convViewInfo4GeneCode.FilePath)
{
return mstrFilePath;
}
else if (strAttributeName  ==  convViewInfo4GeneCode.MainTabId)
{
return mstrMainTabId;
}
else if (strAttributeName  ==  convViewInfo4GeneCode.ViewCnName)
{
return mstrViewCnName;
}
else if (strAttributeName  ==  convViewInfo4GeneCode.ViewGroupId)
{
return mstrViewGroupId;
}
else if (strAttributeName  ==  convViewInfo4GeneCode.ViewGroupName)
{
return mstrViewGroupName;
}
else if (strAttributeName  ==  convViewInfo4GeneCode.InSqlDsTypeId)
{
return mstrInSqlDsTypeId;
}
else if (strAttributeName  ==  convViewInfo4GeneCode.OutSqlDsTypeId)
{
return mstrOutSqlDsTypeId;
}
else if (strAttributeName  ==  convViewInfo4GeneCode.GeneCodeDate)
{
return mstrGeneCodeDate;
}
else if (strAttributeName  ==  convViewInfo4GeneCode.RegionNum)
{
return mintRegionNum;
}
else if (strAttributeName  ==  convViewInfo4GeneCode.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convViewInfo4GeneCode.MainTabName)
{
return mstrMainTabName;
}
else if (strAttributeName  ==  convViewInfo4GeneCode.DetailTabName)
{
return mstrDetailTabName;
}
else if (strAttributeName  ==  convViewInfo4GeneCode.MainTabKeyFld)
{
return mstrMainTabKeyFld;
}
else if (strAttributeName  ==  convViewInfo4GeneCode.DetailTabKeyFld)
{
return mstrDetailTabKeyFld;
}
else if (strAttributeName  ==  convViewInfo4GeneCode.UserId4GeneCode)
{
return mstrUserId4GeneCode;
}
return null;
}
set
{
if (strAttributeName  ==  convViewInfo4GeneCode.ViewId)
{
mstrViewId = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.ViewId);
}
else if (strAttributeName  ==  convViewInfo4GeneCode.TitleStyleId)
{
mstrTitleStyleId = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.TitleStyleId);
}
else if (strAttributeName  ==  convViewInfo4GeneCode.TitleStyleName)
{
mstrTitleStyleName = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.TitleStyleName);
}
else if (strAttributeName  ==  convViewInfo4GeneCode.DgStyleId)
{
mstrDgStyleId = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.DgStyleId);
}
else if (strAttributeName  ==  convViewInfo4GeneCode.DgStyleName)
{
mstrDgStyleName = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.DgStyleName);
}
else if (strAttributeName  ==  convViewInfo4GeneCode.VersionGeneCode)
{
mstrVersionGeneCode = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.VersionGeneCode);
}
else if (strAttributeName  ==  convViewInfo4GeneCode.ViewName)
{
mstrViewName = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.ViewName);
}
else if (strAttributeName  ==  convViewInfo4GeneCode.ViewTypeCode)
{
mintViewTypeCode = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewInfo4GeneCode.ViewTypeCode);
}
else if (strAttributeName  ==  convViewInfo4GeneCode.ViewTypeName)
{
mstrViewTypeName = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.ViewTypeName);
}
else if (strAttributeName  ==  convViewInfo4GeneCode.ApplicationTypeId)
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewInfo4GeneCode.ApplicationTypeId);
}
else if (strAttributeName  ==  convViewInfo4GeneCode.ApplicationTypeName)
{
mstrApplicationTypeName = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.ApplicationTypeName);
}
else if (strAttributeName  ==  convViewInfo4GeneCode.FuncModuleAgcId)
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.FuncModuleAgcId);
}
else if (strAttributeName  ==  convViewInfo4GeneCode.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.FuncModuleName);
}
else if (strAttributeName  ==  convViewInfo4GeneCode.FuncModuleEnName)
{
mstrFuncModuleEnName = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.FuncModuleEnName);
}
else if (strAttributeName  ==  convViewInfo4GeneCode.DataBaseName)
{
mstrDataBaseName = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.DataBaseName);
}
else if (strAttributeName  ==  convViewInfo4GeneCode.KeyForMainTab)
{
mstrKeyForMainTab = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.KeyForMainTab);
}
else if (strAttributeName  ==  convViewInfo4GeneCode.KeyForDetailTab)
{
mstrKeyForDetailTab = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.KeyForDetailTab);
}
else if (strAttributeName  ==  convViewInfo4GeneCode.IsNeedSort)
{
mbolIsNeedSort = TransNullToBool(value.ToString());
 AddUpdatedFld(convViewInfo4GeneCode.IsNeedSort);
}
else if (strAttributeName  ==  convViewInfo4GeneCode.IsNeedTransCode)
{
mbolIsNeedTransCode = TransNullToBool(value.ToString());
 AddUpdatedFld(convViewInfo4GeneCode.IsNeedTransCode);
}
else if (strAttributeName  ==  convViewInfo4GeneCode.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.UserId);
}
else if (strAttributeName  ==  convViewInfo4GeneCode.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.PrjId);
}
else if (strAttributeName  ==  convViewInfo4GeneCode.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.PrjName);
}
else if (strAttributeName  ==  convViewInfo4GeneCode.ViewFunction)
{
mstrViewFunction = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.ViewFunction);
}
else if (strAttributeName  ==  convViewInfo4GeneCode.ViewDetail)
{
mstrViewDetail = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.ViewDetail);
}
else if (strAttributeName  ==  convViewInfo4GeneCode.DefaMenuName)
{
mstrDefaMenuName = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.DefaMenuName);
}
else if (strAttributeName  ==  convViewInfo4GeneCode.DetailTabId)
{
mstrDetailTabId = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.DetailTabId);
}
else if (strAttributeName  ==  convViewInfo4GeneCode.FileName)
{
mstrFileName = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.FileName);
}
else if (strAttributeName  ==  convViewInfo4GeneCode.FilePath)
{
mstrFilePath = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.FilePath);
}
else if (strAttributeName  ==  convViewInfo4GeneCode.MainTabId)
{
mstrMainTabId = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.MainTabId);
}
else if (strAttributeName  ==  convViewInfo4GeneCode.ViewCnName)
{
mstrViewCnName = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.ViewCnName);
}
else if (strAttributeName  ==  convViewInfo4GeneCode.ViewGroupId)
{
mstrViewGroupId = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.ViewGroupId);
}
else if (strAttributeName  ==  convViewInfo4GeneCode.ViewGroupName)
{
mstrViewGroupName = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.ViewGroupName);
}
else if (strAttributeName  ==  convViewInfo4GeneCode.InSqlDsTypeId)
{
mstrInSqlDsTypeId = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.InSqlDsTypeId);
}
else if (strAttributeName  ==  convViewInfo4GeneCode.OutSqlDsTypeId)
{
mstrOutSqlDsTypeId = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.OutSqlDsTypeId);
}
else if (strAttributeName  ==  convViewInfo4GeneCode.GeneCodeDate)
{
mstrGeneCodeDate = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.GeneCodeDate);
}
else if (strAttributeName  ==  convViewInfo4GeneCode.RegionNum)
{
mintRegionNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewInfo4GeneCode.RegionNum);
}
else if (strAttributeName  ==  convViewInfo4GeneCode.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.UpdDate);
}
else if (strAttributeName  ==  convViewInfo4GeneCode.MainTabName)
{
mstrMainTabName = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.MainTabName);
}
else if (strAttributeName  ==  convViewInfo4GeneCode.DetailTabName)
{
mstrDetailTabName = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.DetailTabName);
}
else if (strAttributeName  ==  convViewInfo4GeneCode.MainTabKeyFld)
{
mstrMainTabKeyFld = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.MainTabKeyFld);
}
else if (strAttributeName  ==  convViewInfo4GeneCode.DetailTabKeyFld)
{
mstrDetailTabKeyFld = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.DetailTabKeyFld);
}
else if (strAttributeName  ==  convViewInfo4GeneCode.UserId4GeneCode)
{
mstrUserId4GeneCode = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.UserId4GeneCode);
}
}
}
public object this[int intIndex]
{
get
{
if (convViewInfo4GeneCode.ViewId  ==  _AttributeName[intIndex])
{
return mstrViewId;
}
else if (convViewInfo4GeneCode.TitleStyleId  ==  _AttributeName[intIndex])
{
return mstrTitleStyleId;
}
else if (convViewInfo4GeneCode.TitleStyleName  ==  _AttributeName[intIndex])
{
return mstrTitleStyleName;
}
else if (convViewInfo4GeneCode.DgStyleId  ==  _AttributeName[intIndex])
{
return mstrDgStyleId;
}
else if (convViewInfo4GeneCode.DgStyleName  ==  _AttributeName[intIndex])
{
return mstrDgStyleName;
}
else if (convViewInfo4GeneCode.VersionGeneCode  ==  _AttributeName[intIndex])
{
return mstrVersionGeneCode;
}
else if (convViewInfo4GeneCode.ViewName  ==  _AttributeName[intIndex])
{
return mstrViewName;
}
else if (convViewInfo4GeneCode.ViewTypeCode  ==  _AttributeName[intIndex])
{
return mintViewTypeCode;
}
else if (convViewInfo4GeneCode.ViewTypeName  ==  _AttributeName[intIndex])
{
return mstrViewTypeName;
}
else if (convViewInfo4GeneCode.ApplicationTypeId  ==  _AttributeName[intIndex])
{
return mintApplicationTypeId;
}
else if (convViewInfo4GeneCode.ApplicationTypeName  ==  _AttributeName[intIndex])
{
return mstrApplicationTypeName;
}
else if (convViewInfo4GeneCode.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
return mstrFuncModuleAgcId;
}
else if (convViewInfo4GeneCode.FuncModuleName  ==  _AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convViewInfo4GeneCode.FuncModuleEnName  ==  _AttributeName[intIndex])
{
return mstrFuncModuleEnName;
}
else if (convViewInfo4GeneCode.DataBaseName  ==  _AttributeName[intIndex])
{
return mstrDataBaseName;
}
else if (convViewInfo4GeneCode.KeyForMainTab  ==  _AttributeName[intIndex])
{
return mstrKeyForMainTab;
}
else if (convViewInfo4GeneCode.KeyForDetailTab  ==  _AttributeName[intIndex])
{
return mstrKeyForDetailTab;
}
else if (convViewInfo4GeneCode.IsNeedSort  ==  _AttributeName[intIndex])
{
return mbolIsNeedSort;
}
else if (convViewInfo4GeneCode.IsNeedTransCode  ==  _AttributeName[intIndex])
{
return mbolIsNeedTransCode;
}
else if (convViewInfo4GeneCode.UserId  ==  _AttributeName[intIndex])
{
return mstrUserId;
}
else if (convViewInfo4GeneCode.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convViewInfo4GeneCode.PrjName  ==  _AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convViewInfo4GeneCode.ViewFunction  ==  _AttributeName[intIndex])
{
return mstrViewFunction;
}
else if (convViewInfo4GeneCode.ViewDetail  ==  _AttributeName[intIndex])
{
return mstrViewDetail;
}
else if (convViewInfo4GeneCode.DefaMenuName  ==  _AttributeName[intIndex])
{
return mstrDefaMenuName;
}
else if (convViewInfo4GeneCode.DetailTabId  ==  _AttributeName[intIndex])
{
return mstrDetailTabId;
}
else if (convViewInfo4GeneCode.FileName  ==  _AttributeName[intIndex])
{
return mstrFileName;
}
else if (convViewInfo4GeneCode.FilePath  ==  _AttributeName[intIndex])
{
return mstrFilePath;
}
else if (convViewInfo4GeneCode.MainTabId  ==  _AttributeName[intIndex])
{
return mstrMainTabId;
}
else if (convViewInfo4GeneCode.ViewCnName  ==  _AttributeName[intIndex])
{
return mstrViewCnName;
}
else if (convViewInfo4GeneCode.ViewGroupId  ==  _AttributeName[intIndex])
{
return mstrViewGroupId;
}
else if (convViewInfo4GeneCode.ViewGroupName  ==  _AttributeName[intIndex])
{
return mstrViewGroupName;
}
else if (convViewInfo4GeneCode.InSqlDsTypeId  ==  _AttributeName[intIndex])
{
return mstrInSqlDsTypeId;
}
else if (convViewInfo4GeneCode.OutSqlDsTypeId  ==  _AttributeName[intIndex])
{
return mstrOutSqlDsTypeId;
}
else if (convViewInfo4GeneCode.GeneCodeDate  ==  _AttributeName[intIndex])
{
return mstrGeneCodeDate;
}
else if (convViewInfo4GeneCode.RegionNum  ==  _AttributeName[intIndex])
{
return mintRegionNum;
}
else if (convViewInfo4GeneCode.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convViewInfo4GeneCode.MainTabName  ==  _AttributeName[intIndex])
{
return mstrMainTabName;
}
else if (convViewInfo4GeneCode.DetailTabName  ==  _AttributeName[intIndex])
{
return mstrDetailTabName;
}
else if (convViewInfo4GeneCode.MainTabKeyFld  ==  _AttributeName[intIndex])
{
return mstrMainTabKeyFld;
}
else if (convViewInfo4GeneCode.DetailTabKeyFld  ==  _AttributeName[intIndex])
{
return mstrDetailTabKeyFld;
}
else if (convViewInfo4GeneCode.UserId4GeneCode  ==  _AttributeName[intIndex])
{
return mstrUserId4GeneCode;
}
return null;
}
set
{
if (convViewInfo4GeneCode.ViewId  ==  _AttributeName[intIndex])
{
mstrViewId = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.ViewId);
}
else if (convViewInfo4GeneCode.TitleStyleId  ==  _AttributeName[intIndex])
{
mstrTitleStyleId = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.TitleStyleId);
}
else if (convViewInfo4GeneCode.TitleStyleName  ==  _AttributeName[intIndex])
{
mstrTitleStyleName = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.TitleStyleName);
}
else if (convViewInfo4GeneCode.DgStyleId  ==  _AttributeName[intIndex])
{
mstrDgStyleId = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.DgStyleId);
}
else if (convViewInfo4GeneCode.DgStyleName  ==  _AttributeName[intIndex])
{
mstrDgStyleName = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.DgStyleName);
}
else if (convViewInfo4GeneCode.VersionGeneCode  ==  _AttributeName[intIndex])
{
mstrVersionGeneCode = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.VersionGeneCode);
}
else if (convViewInfo4GeneCode.ViewName  ==  _AttributeName[intIndex])
{
mstrViewName = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.ViewName);
}
else if (convViewInfo4GeneCode.ViewTypeCode  ==  _AttributeName[intIndex])
{
mintViewTypeCode = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewInfo4GeneCode.ViewTypeCode);
}
else if (convViewInfo4GeneCode.ViewTypeName  ==  _AttributeName[intIndex])
{
mstrViewTypeName = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.ViewTypeName);
}
else if (convViewInfo4GeneCode.ApplicationTypeId  ==  _AttributeName[intIndex])
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewInfo4GeneCode.ApplicationTypeId);
}
else if (convViewInfo4GeneCode.ApplicationTypeName  ==  _AttributeName[intIndex])
{
mstrApplicationTypeName = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.ApplicationTypeName);
}
else if (convViewInfo4GeneCode.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.FuncModuleAgcId);
}
else if (convViewInfo4GeneCode.FuncModuleName  ==  _AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.FuncModuleName);
}
else if (convViewInfo4GeneCode.FuncModuleEnName  ==  _AttributeName[intIndex])
{
mstrFuncModuleEnName = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.FuncModuleEnName);
}
else if (convViewInfo4GeneCode.DataBaseName  ==  _AttributeName[intIndex])
{
mstrDataBaseName = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.DataBaseName);
}
else if (convViewInfo4GeneCode.KeyForMainTab  ==  _AttributeName[intIndex])
{
mstrKeyForMainTab = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.KeyForMainTab);
}
else if (convViewInfo4GeneCode.KeyForDetailTab  ==  _AttributeName[intIndex])
{
mstrKeyForDetailTab = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.KeyForDetailTab);
}
else if (convViewInfo4GeneCode.IsNeedSort  ==  _AttributeName[intIndex])
{
mbolIsNeedSort = TransNullToBool(value.ToString());
 AddUpdatedFld(convViewInfo4GeneCode.IsNeedSort);
}
else if (convViewInfo4GeneCode.IsNeedTransCode  ==  _AttributeName[intIndex])
{
mbolIsNeedTransCode = TransNullToBool(value.ToString());
 AddUpdatedFld(convViewInfo4GeneCode.IsNeedTransCode);
}
else if (convViewInfo4GeneCode.UserId  ==  _AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.UserId);
}
else if (convViewInfo4GeneCode.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.PrjId);
}
else if (convViewInfo4GeneCode.PrjName  ==  _AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.PrjName);
}
else if (convViewInfo4GeneCode.ViewFunction  ==  _AttributeName[intIndex])
{
mstrViewFunction = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.ViewFunction);
}
else if (convViewInfo4GeneCode.ViewDetail  ==  _AttributeName[intIndex])
{
mstrViewDetail = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.ViewDetail);
}
else if (convViewInfo4GeneCode.DefaMenuName  ==  _AttributeName[intIndex])
{
mstrDefaMenuName = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.DefaMenuName);
}
else if (convViewInfo4GeneCode.DetailTabId  ==  _AttributeName[intIndex])
{
mstrDetailTabId = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.DetailTabId);
}
else if (convViewInfo4GeneCode.FileName  ==  _AttributeName[intIndex])
{
mstrFileName = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.FileName);
}
else if (convViewInfo4GeneCode.FilePath  ==  _AttributeName[intIndex])
{
mstrFilePath = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.FilePath);
}
else if (convViewInfo4GeneCode.MainTabId  ==  _AttributeName[intIndex])
{
mstrMainTabId = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.MainTabId);
}
else if (convViewInfo4GeneCode.ViewCnName  ==  _AttributeName[intIndex])
{
mstrViewCnName = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.ViewCnName);
}
else if (convViewInfo4GeneCode.ViewGroupId  ==  _AttributeName[intIndex])
{
mstrViewGroupId = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.ViewGroupId);
}
else if (convViewInfo4GeneCode.ViewGroupName  ==  _AttributeName[intIndex])
{
mstrViewGroupName = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.ViewGroupName);
}
else if (convViewInfo4GeneCode.InSqlDsTypeId  ==  _AttributeName[intIndex])
{
mstrInSqlDsTypeId = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.InSqlDsTypeId);
}
else if (convViewInfo4GeneCode.OutSqlDsTypeId  ==  _AttributeName[intIndex])
{
mstrOutSqlDsTypeId = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.OutSqlDsTypeId);
}
else if (convViewInfo4GeneCode.GeneCodeDate  ==  _AttributeName[intIndex])
{
mstrGeneCodeDate = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.GeneCodeDate);
}
else if (convViewInfo4GeneCode.RegionNum  ==  _AttributeName[intIndex])
{
mintRegionNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewInfo4GeneCode.RegionNum);
}
else if (convViewInfo4GeneCode.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.UpdDate);
}
else if (convViewInfo4GeneCode.MainTabName  ==  _AttributeName[intIndex])
{
mstrMainTabName = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.MainTabName);
}
else if (convViewInfo4GeneCode.DetailTabName  ==  _AttributeName[intIndex])
{
mstrDetailTabName = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.DetailTabName);
}
else if (convViewInfo4GeneCode.MainTabKeyFld  ==  _AttributeName[intIndex])
{
mstrMainTabKeyFld = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.MainTabKeyFld);
}
else if (convViewInfo4GeneCode.DetailTabKeyFld  ==  _AttributeName[intIndex])
{
mstrDetailTabKeyFld = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.DetailTabKeyFld);
}
else if (convViewInfo4GeneCode.UserId4GeneCode  ==  _AttributeName[intIndex])
{
mstrUserId4GeneCode = value.ToString();
 AddUpdatedFld(convViewInfo4GeneCode.UserId4GeneCode);
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
 AddUpdatedFld(convViewInfo4GeneCode.ViewId);
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
 AddUpdatedFld(convViewInfo4GeneCode.TitleStyleId);
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
 AddUpdatedFld(convViewInfo4GeneCode.TitleStyleName);
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
 AddUpdatedFld(convViewInfo4GeneCode.DgStyleId);
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
 AddUpdatedFld(convViewInfo4GeneCode.DgStyleName);
}
}
/// <summary>
/// 生成代码版本(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VersionGeneCode
{
get
{
return mstrVersionGeneCode;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVersionGeneCode = value;
}
else
{
 mstrVersionGeneCode = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewInfo4GeneCode.VersionGeneCode);
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
 AddUpdatedFld(convViewInfo4GeneCode.ViewName);
}
}
/// <summary>
/// 界面类型码(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int ViewTypeCode
{
get
{
return mintViewTypeCode;
}
set
{
 mintViewTypeCode = value;
//记录修改过的字段
 AddUpdatedFld(convViewInfo4GeneCode.ViewTypeCode);
}
}
/// <summary>
/// 界面类型名称(说明:;字段类型:varchar;字段长度:40;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewTypeName
{
get
{
return mstrViewTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewTypeName = value;
}
else
{
 mstrViewTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewInfo4GeneCode.ViewTypeName);
}
}
/// <summary>
/// 应用程序类型ID(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? ApplicationTypeId
{
get
{
return mintApplicationTypeId;
}
set
{
 mintApplicationTypeId = value;
//记录修改过的字段
 AddUpdatedFld(convViewInfo4GeneCode.ApplicationTypeId);
}
}
/// <summary>
/// 应用程序类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ApplicationTypeName
{
get
{
return mstrApplicationTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrApplicationTypeName = value;
}
else
{
 mstrApplicationTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewInfo4GeneCode.ApplicationTypeName);
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
 AddUpdatedFld(convViewInfo4GeneCode.FuncModuleAgcId);
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
 AddUpdatedFld(convViewInfo4GeneCode.FuncModuleName);
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
 AddUpdatedFld(convViewInfo4GeneCode.FuncModuleEnName);
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
 AddUpdatedFld(convViewInfo4GeneCode.DataBaseName);
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
 AddUpdatedFld(convViewInfo4GeneCode.KeyForMainTab);
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
 AddUpdatedFld(convViewInfo4GeneCode.KeyForDetailTab);
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
 AddUpdatedFld(convViewInfo4GeneCode.IsNeedSort);
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
 AddUpdatedFld(convViewInfo4GeneCode.IsNeedTransCode);
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
 AddUpdatedFld(convViewInfo4GeneCode.UserId);
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
 AddUpdatedFld(convViewInfo4GeneCode.PrjId);
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
 AddUpdatedFld(convViewInfo4GeneCode.PrjName);
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
 AddUpdatedFld(convViewInfo4GeneCode.ViewFunction);
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
 AddUpdatedFld(convViewInfo4GeneCode.ViewDetail);
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
 AddUpdatedFld(convViewInfo4GeneCode.DefaMenuName);
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
 AddUpdatedFld(convViewInfo4GeneCode.DetailTabId);
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
 AddUpdatedFld(convViewInfo4GeneCode.FileName);
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
 AddUpdatedFld(convViewInfo4GeneCode.FilePath);
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
 AddUpdatedFld(convViewInfo4GeneCode.MainTabId);
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
 AddUpdatedFld(convViewInfo4GeneCode.ViewCnName);
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
 AddUpdatedFld(convViewInfo4GeneCode.ViewGroupId);
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
 AddUpdatedFld(convViewInfo4GeneCode.ViewGroupName);
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
 AddUpdatedFld(convViewInfo4GeneCode.InSqlDsTypeId);
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
 AddUpdatedFld(convViewInfo4GeneCode.OutSqlDsTypeId);
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
 AddUpdatedFld(convViewInfo4GeneCode.GeneCodeDate);
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
 AddUpdatedFld(convViewInfo4GeneCode.RegionNum);
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
 AddUpdatedFld(convViewInfo4GeneCode.UpdDate);
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
 AddUpdatedFld(convViewInfo4GeneCode.MainTabName);
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
 AddUpdatedFld(convViewInfo4GeneCode.DetailTabName);
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
 AddUpdatedFld(convViewInfo4GeneCode.MainTabKeyFld);
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
 AddUpdatedFld(convViewInfo4GeneCode.DetailTabKeyFld);
}
}
/// <summary>
/// UserId4GeneCode(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserId4GeneCode
{
get
{
return mstrUserId4GeneCode;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserId4GeneCode = value;
}
else
{
 mstrUserId4GeneCode = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewInfo4GeneCode.UserId4GeneCode);
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
 /// vViewInfo4GeneCode(vViewInfo4GeneCode)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convViewInfo4GeneCode
{
public const string _CurrTabName = "vViewInfo4GeneCode"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ViewId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"ViewId", "TitleStyleId", "TitleStyleName", "DgStyleId", "DgStyleName", "VersionGeneCode", "ViewName", "ViewTypeCode", "ViewTypeName", "ApplicationTypeId", "ApplicationTypeName", "FuncModuleAgcId", "FuncModuleName", "FuncModuleEnName", "DataBaseName", "KeyForMainTab", "KeyForDetailTab", "IsNeedSort", "IsNeedTransCode", "UserId", "PrjId", "PrjName", "ViewFunction", "ViewDetail", "DefaMenuName", "DetailTabId", "FileName", "FilePath", "MainTabId", "ViewCnName", "ViewGroupId", "ViewGroupName", "InSqlDsTypeId", "OutSqlDsTypeId", "GeneCodeDate", "RegionNum", "UpdDate", "MainTabName", "DetailTabName", "MainTabKeyFld", "DetailTabKeyFld", "UserId4GeneCode"};
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
 /// 常量:"VersionGeneCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VersionGeneCode = "VersionGeneCode";    //生成代码版本

 /// <summary>
 /// 常量:"ViewName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewName = "ViewName";    //界面名称

 /// <summary>
 /// 常量:"ViewTypeCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewTypeCode = "ViewTypeCode";    //界面类型码

 /// <summary>
 /// 常量:"ViewTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewTypeName = "ViewTypeName";    //界面类型名称

 /// <summary>
 /// 常量:"ApplicationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeId = "ApplicationTypeId";    //应用程序类型ID

 /// <summary>
 /// 常量:"ApplicationTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeName = "ApplicationTypeName";    //应用程序类型名称

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
 /// 常量:"RegionNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RegionNum = "RegionNum";    //区域数

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

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
 /// 常量:"DetailTabKeyFld"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DetailTabKeyFld = "DetailTabKeyFld";    //详细表关键字

 /// <summary>
 /// 常量:"UserId4GeneCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId4GeneCode = "UserId4GeneCode";    //UserId4GeneCode
}

}