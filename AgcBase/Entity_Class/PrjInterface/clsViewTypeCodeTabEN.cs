
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewTypeCodeTabEN
 表名:ViewTypeCodeTab(00050104)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:35:03
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
 /// 表ViewTypeCodeTab的关键字(ViewTypeCode)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ViewTypeCode_ViewTypeCodeTab
{
private int _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public int Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="intViewTypeCode">表关键字</param>
public K_ViewTypeCode_ViewTypeCodeTab(int intViewTypeCode)
{
if (IsValid(intViewTypeCode)) Value = intViewTypeCode;
else
{
Value = 0;
}
}
private static bool IsValid(int intViewTypeCode)
{
if (intViewTypeCode == 0) return false;
if (intViewTypeCode == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ViewTypeCode_ViewTypeCodeTab]类型的对象</returns>
public static implicit operator K_ViewTypeCode_ViewTypeCodeTab(int value)
{
return new K_ViewTypeCode_ViewTypeCodeTab(value);
}
}
 /// <summary>
 /// 界面类型码(ViewTypeCodeTab)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsViewTypeCodeTabEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ViewTypeCodeTab"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ViewTypeCode"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 23;
public static string[] _AttributeName = new string[] {"ViewTypeCode", "ViewTypeName", "ViewTypeENName", "IsWinApp", "IsMobileApp", "IsWebApp", "ViewFunction", "OptProcess", "ViewDetail", "ApplicationTypeId", "IsHaveAdd", "IsHaveUpdate", "IsHaveDel", "IsHaveQuery", "IsHaveExcelExport", "IsHaveSetExportExcel", "IsHaveDetail", "IsHaveExeAdd", "IsHaveExeUpdate", "IsHaveMainView", "IsHaveSubView", "OrderNum", "IsUsed"};

protected int mintViewTypeCode;    //界面类型码
protected string mstrViewTypeName;    //界面类型名称
protected string mstrViewTypeENName;    //ViewTypeENName
protected bool mbolIsWinApp;    //IsWinApp
protected bool mbolIsMobileApp;    //是否移动终端应用
protected bool mbolIsWebApp;    //IsWebApp
protected string mstrViewFunction;    //界面功能
protected string mstrOptProcess;    //操作流程
protected string mstrViewDetail;    //界面说明
protected int mintApplicationTypeId;    //应用程序类型ID
protected bool mbolIsHaveAdd;    //是否有添加
protected bool mbolIsHaveUpdate;    //是否有修改
protected bool mbolIsHaveDel;    //是否有删除
protected bool mbolIsHaveQuery;    //是否有查询
protected bool mbolIsHaveExcelExport;    //是否EXCEL导出
protected bool mbolIsHaveSetExportExcel;    //是否有设置EXCEL导出
protected bool mbolIsHaveDetail;    //是否有详细
protected bool mbolIsHaveExeAdd;    //是否有调用添加
protected bool mbolIsHaveExeUpdate;    //是否有调用修改
protected bool mbolIsHaveMainView;    //是否有主界面
protected bool mbolIsHaveSubView;    //是否有子界面
protected int? mintOrderNum;    //序号
protected bool mbolIsUsed;    //IsUsed

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsViewTypeCodeTabEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ViewTypeCode");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "intViewTypeCode">关键字:界面类型码</param>
public clsViewTypeCodeTabEN(int intViewTypeCode)
 {
 if (intViewTypeCode  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mintViewTypeCode = intViewTypeCode;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ViewTypeCode");
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
if (strAttributeName  ==  conViewTypeCodeTab.ViewTypeCode)
{
return mintViewTypeCode;
}
else if (strAttributeName  ==  conViewTypeCodeTab.ViewTypeName)
{
return mstrViewTypeName;
}
else if (strAttributeName  ==  conViewTypeCodeTab.ViewTypeENName)
{
return mstrViewTypeENName;
}
else if (strAttributeName  ==  conViewTypeCodeTab.IsWinApp)
{
return mbolIsWinApp;
}
else if (strAttributeName  ==  conViewTypeCodeTab.IsMobileApp)
{
return mbolIsMobileApp;
}
else if (strAttributeName  ==  conViewTypeCodeTab.IsWebApp)
{
return mbolIsWebApp;
}
else if (strAttributeName  ==  conViewTypeCodeTab.ViewFunction)
{
return mstrViewFunction;
}
else if (strAttributeName  ==  conViewTypeCodeTab.OptProcess)
{
return mstrOptProcess;
}
else if (strAttributeName  ==  conViewTypeCodeTab.ViewDetail)
{
return mstrViewDetail;
}
else if (strAttributeName  ==  conViewTypeCodeTab.ApplicationTypeId)
{
return mintApplicationTypeId;
}
else if (strAttributeName  ==  conViewTypeCodeTab.IsHaveAdd)
{
return mbolIsHaveAdd;
}
else if (strAttributeName  ==  conViewTypeCodeTab.IsHaveUpdate)
{
return mbolIsHaveUpdate;
}
else if (strAttributeName  ==  conViewTypeCodeTab.IsHaveDel)
{
return mbolIsHaveDel;
}
else if (strAttributeName  ==  conViewTypeCodeTab.IsHaveQuery)
{
return mbolIsHaveQuery;
}
else if (strAttributeName  ==  conViewTypeCodeTab.IsHaveExcelExport)
{
return mbolIsHaveExcelExport;
}
else if (strAttributeName  ==  conViewTypeCodeTab.IsHaveSetExportExcel)
{
return mbolIsHaveSetExportExcel;
}
else if (strAttributeName  ==  conViewTypeCodeTab.IsHaveDetail)
{
return mbolIsHaveDetail;
}
else if (strAttributeName  ==  conViewTypeCodeTab.IsHaveExeAdd)
{
return mbolIsHaveExeAdd;
}
else if (strAttributeName  ==  conViewTypeCodeTab.IsHaveExeUpdate)
{
return mbolIsHaveExeUpdate;
}
else if (strAttributeName  ==  conViewTypeCodeTab.IsHaveMainView)
{
return mbolIsHaveMainView;
}
else if (strAttributeName  ==  conViewTypeCodeTab.IsHaveSubView)
{
return mbolIsHaveSubView;
}
else if (strAttributeName  ==  conViewTypeCodeTab.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conViewTypeCodeTab.IsUsed)
{
return mbolIsUsed;
}
return null;
}
set
{
if (strAttributeName  ==  conViewTypeCodeTab.ViewTypeCode)
{
mintViewTypeCode = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewTypeCodeTab.ViewTypeCode);
}
else if (strAttributeName  ==  conViewTypeCodeTab.ViewTypeName)
{
mstrViewTypeName = value.ToString();
 AddUpdatedFld(conViewTypeCodeTab.ViewTypeName);
}
else if (strAttributeName  ==  conViewTypeCodeTab.ViewTypeENName)
{
mstrViewTypeENName = value.ToString();
 AddUpdatedFld(conViewTypeCodeTab.ViewTypeENName);
}
else if (strAttributeName  ==  conViewTypeCodeTab.IsWinApp)
{
mbolIsWinApp = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewTypeCodeTab.IsWinApp);
}
else if (strAttributeName  ==  conViewTypeCodeTab.IsMobileApp)
{
mbolIsMobileApp = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewTypeCodeTab.IsMobileApp);
}
else if (strAttributeName  ==  conViewTypeCodeTab.IsWebApp)
{
mbolIsWebApp = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewTypeCodeTab.IsWebApp);
}
else if (strAttributeName  ==  conViewTypeCodeTab.ViewFunction)
{
mstrViewFunction = value.ToString();
 AddUpdatedFld(conViewTypeCodeTab.ViewFunction);
}
else if (strAttributeName  ==  conViewTypeCodeTab.OptProcess)
{
mstrOptProcess = value.ToString();
 AddUpdatedFld(conViewTypeCodeTab.OptProcess);
}
else if (strAttributeName  ==  conViewTypeCodeTab.ViewDetail)
{
mstrViewDetail = value.ToString();
 AddUpdatedFld(conViewTypeCodeTab.ViewDetail);
}
else if (strAttributeName  ==  conViewTypeCodeTab.ApplicationTypeId)
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewTypeCodeTab.ApplicationTypeId);
}
else if (strAttributeName  ==  conViewTypeCodeTab.IsHaveAdd)
{
mbolIsHaveAdd = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewTypeCodeTab.IsHaveAdd);
}
else if (strAttributeName  ==  conViewTypeCodeTab.IsHaveUpdate)
{
mbolIsHaveUpdate = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewTypeCodeTab.IsHaveUpdate);
}
else if (strAttributeName  ==  conViewTypeCodeTab.IsHaveDel)
{
mbolIsHaveDel = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewTypeCodeTab.IsHaveDel);
}
else if (strAttributeName  ==  conViewTypeCodeTab.IsHaveQuery)
{
mbolIsHaveQuery = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewTypeCodeTab.IsHaveQuery);
}
else if (strAttributeName  ==  conViewTypeCodeTab.IsHaveExcelExport)
{
mbolIsHaveExcelExport = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewTypeCodeTab.IsHaveExcelExport);
}
else if (strAttributeName  ==  conViewTypeCodeTab.IsHaveSetExportExcel)
{
mbolIsHaveSetExportExcel = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewTypeCodeTab.IsHaveSetExportExcel);
}
else if (strAttributeName  ==  conViewTypeCodeTab.IsHaveDetail)
{
mbolIsHaveDetail = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewTypeCodeTab.IsHaveDetail);
}
else if (strAttributeName  ==  conViewTypeCodeTab.IsHaveExeAdd)
{
mbolIsHaveExeAdd = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewTypeCodeTab.IsHaveExeAdd);
}
else if (strAttributeName  ==  conViewTypeCodeTab.IsHaveExeUpdate)
{
mbolIsHaveExeUpdate = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewTypeCodeTab.IsHaveExeUpdate);
}
else if (strAttributeName  ==  conViewTypeCodeTab.IsHaveMainView)
{
mbolIsHaveMainView = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewTypeCodeTab.IsHaveMainView);
}
else if (strAttributeName  ==  conViewTypeCodeTab.IsHaveSubView)
{
mbolIsHaveSubView = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewTypeCodeTab.IsHaveSubView);
}
else if (strAttributeName  ==  conViewTypeCodeTab.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewTypeCodeTab.OrderNum);
}
else if (strAttributeName  ==  conViewTypeCodeTab.IsUsed)
{
mbolIsUsed = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewTypeCodeTab.IsUsed);
}
}
}
public object this[int intIndex]
{
get
{
if (conViewTypeCodeTab.ViewTypeCode  ==  _AttributeName[intIndex])
{
return mintViewTypeCode;
}
else if (conViewTypeCodeTab.ViewTypeName  ==  _AttributeName[intIndex])
{
return mstrViewTypeName;
}
else if (conViewTypeCodeTab.ViewTypeENName  ==  _AttributeName[intIndex])
{
return mstrViewTypeENName;
}
else if (conViewTypeCodeTab.IsWinApp  ==  _AttributeName[intIndex])
{
return mbolIsWinApp;
}
else if (conViewTypeCodeTab.IsMobileApp  ==  _AttributeName[intIndex])
{
return mbolIsMobileApp;
}
else if (conViewTypeCodeTab.IsWebApp  ==  _AttributeName[intIndex])
{
return mbolIsWebApp;
}
else if (conViewTypeCodeTab.ViewFunction  ==  _AttributeName[intIndex])
{
return mstrViewFunction;
}
else if (conViewTypeCodeTab.OptProcess  ==  _AttributeName[intIndex])
{
return mstrOptProcess;
}
else if (conViewTypeCodeTab.ViewDetail  ==  _AttributeName[intIndex])
{
return mstrViewDetail;
}
else if (conViewTypeCodeTab.ApplicationTypeId  ==  _AttributeName[intIndex])
{
return mintApplicationTypeId;
}
else if (conViewTypeCodeTab.IsHaveAdd  ==  _AttributeName[intIndex])
{
return mbolIsHaveAdd;
}
else if (conViewTypeCodeTab.IsHaveUpdate  ==  _AttributeName[intIndex])
{
return mbolIsHaveUpdate;
}
else if (conViewTypeCodeTab.IsHaveDel  ==  _AttributeName[intIndex])
{
return mbolIsHaveDel;
}
else if (conViewTypeCodeTab.IsHaveQuery  ==  _AttributeName[intIndex])
{
return mbolIsHaveQuery;
}
else if (conViewTypeCodeTab.IsHaveExcelExport  ==  _AttributeName[intIndex])
{
return mbolIsHaveExcelExport;
}
else if (conViewTypeCodeTab.IsHaveSetExportExcel  ==  _AttributeName[intIndex])
{
return mbolIsHaveSetExportExcel;
}
else if (conViewTypeCodeTab.IsHaveDetail  ==  _AttributeName[intIndex])
{
return mbolIsHaveDetail;
}
else if (conViewTypeCodeTab.IsHaveExeAdd  ==  _AttributeName[intIndex])
{
return mbolIsHaveExeAdd;
}
else if (conViewTypeCodeTab.IsHaveExeUpdate  ==  _AttributeName[intIndex])
{
return mbolIsHaveExeUpdate;
}
else if (conViewTypeCodeTab.IsHaveMainView  ==  _AttributeName[intIndex])
{
return mbolIsHaveMainView;
}
else if (conViewTypeCodeTab.IsHaveSubView  ==  _AttributeName[intIndex])
{
return mbolIsHaveSubView;
}
else if (conViewTypeCodeTab.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conViewTypeCodeTab.IsUsed  ==  _AttributeName[intIndex])
{
return mbolIsUsed;
}
return null;
}
set
{
if (conViewTypeCodeTab.ViewTypeCode  ==  _AttributeName[intIndex])
{
mintViewTypeCode = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewTypeCodeTab.ViewTypeCode);
}
else if (conViewTypeCodeTab.ViewTypeName  ==  _AttributeName[intIndex])
{
mstrViewTypeName = value.ToString();
 AddUpdatedFld(conViewTypeCodeTab.ViewTypeName);
}
else if (conViewTypeCodeTab.ViewTypeENName  ==  _AttributeName[intIndex])
{
mstrViewTypeENName = value.ToString();
 AddUpdatedFld(conViewTypeCodeTab.ViewTypeENName);
}
else if (conViewTypeCodeTab.IsWinApp  ==  _AttributeName[intIndex])
{
mbolIsWinApp = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewTypeCodeTab.IsWinApp);
}
else if (conViewTypeCodeTab.IsMobileApp  ==  _AttributeName[intIndex])
{
mbolIsMobileApp = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewTypeCodeTab.IsMobileApp);
}
else if (conViewTypeCodeTab.IsWebApp  ==  _AttributeName[intIndex])
{
mbolIsWebApp = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewTypeCodeTab.IsWebApp);
}
else if (conViewTypeCodeTab.ViewFunction  ==  _AttributeName[intIndex])
{
mstrViewFunction = value.ToString();
 AddUpdatedFld(conViewTypeCodeTab.ViewFunction);
}
else if (conViewTypeCodeTab.OptProcess  ==  _AttributeName[intIndex])
{
mstrOptProcess = value.ToString();
 AddUpdatedFld(conViewTypeCodeTab.OptProcess);
}
else if (conViewTypeCodeTab.ViewDetail  ==  _AttributeName[intIndex])
{
mstrViewDetail = value.ToString();
 AddUpdatedFld(conViewTypeCodeTab.ViewDetail);
}
else if (conViewTypeCodeTab.ApplicationTypeId  ==  _AttributeName[intIndex])
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewTypeCodeTab.ApplicationTypeId);
}
else if (conViewTypeCodeTab.IsHaveAdd  ==  _AttributeName[intIndex])
{
mbolIsHaveAdd = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewTypeCodeTab.IsHaveAdd);
}
else if (conViewTypeCodeTab.IsHaveUpdate  ==  _AttributeName[intIndex])
{
mbolIsHaveUpdate = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewTypeCodeTab.IsHaveUpdate);
}
else if (conViewTypeCodeTab.IsHaveDel  ==  _AttributeName[intIndex])
{
mbolIsHaveDel = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewTypeCodeTab.IsHaveDel);
}
else if (conViewTypeCodeTab.IsHaveQuery  ==  _AttributeName[intIndex])
{
mbolIsHaveQuery = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewTypeCodeTab.IsHaveQuery);
}
else if (conViewTypeCodeTab.IsHaveExcelExport  ==  _AttributeName[intIndex])
{
mbolIsHaveExcelExport = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewTypeCodeTab.IsHaveExcelExport);
}
else if (conViewTypeCodeTab.IsHaveSetExportExcel  ==  _AttributeName[intIndex])
{
mbolIsHaveSetExportExcel = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewTypeCodeTab.IsHaveSetExportExcel);
}
else if (conViewTypeCodeTab.IsHaveDetail  ==  _AttributeName[intIndex])
{
mbolIsHaveDetail = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewTypeCodeTab.IsHaveDetail);
}
else if (conViewTypeCodeTab.IsHaveExeAdd  ==  _AttributeName[intIndex])
{
mbolIsHaveExeAdd = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewTypeCodeTab.IsHaveExeAdd);
}
else if (conViewTypeCodeTab.IsHaveExeUpdate  ==  _AttributeName[intIndex])
{
mbolIsHaveExeUpdate = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewTypeCodeTab.IsHaveExeUpdate);
}
else if (conViewTypeCodeTab.IsHaveMainView  ==  _AttributeName[intIndex])
{
mbolIsHaveMainView = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewTypeCodeTab.IsHaveMainView);
}
else if (conViewTypeCodeTab.IsHaveSubView  ==  _AttributeName[intIndex])
{
mbolIsHaveSubView = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewTypeCodeTab.IsHaveSubView);
}
else if (conViewTypeCodeTab.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewTypeCodeTab.OrderNum);
}
else if (conViewTypeCodeTab.IsUsed  ==  _AttributeName[intIndex])
{
mbolIsUsed = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewTypeCodeTab.IsUsed);
}
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
 AddUpdatedFld(conViewTypeCodeTab.ViewTypeCode);
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
 AddUpdatedFld(conViewTypeCodeTab.ViewTypeName);
}
}
/// <summary>
/// ViewTypeENName(说明:;字段类型:varchar;字段长度:40;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewTypeENName
{
get
{
return mstrViewTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewTypeENName = value;
}
else
{
 mstrViewTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewTypeCodeTab.ViewTypeENName);
}
}
/// <summary>
/// IsWinApp(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsWinApp
{
get
{
return mbolIsWinApp;
}
set
{
 mbolIsWinApp = value;
//记录修改过的字段
 AddUpdatedFld(conViewTypeCodeTab.IsWinApp);
}
}
/// <summary>
/// 是否移动终端应用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsMobileApp
{
get
{
return mbolIsMobileApp;
}
set
{
 mbolIsMobileApp = value;
//记录修改过的字段
 AddUpdatedFld(conViewTypeCodeTab.IsMobileApp);
}
}
/// <summary>
/// IsWebApp(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsWebApp
{
get
{
return mbolIsWebApp;
}
set
{
 mbolIsWebApp = value;
//记录修改过的字段
 AddUpdatedFld(conViewTypeCodeTab.IsWebApp);
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
 AddUpdatedFld(conViewTypeCodeTab.ViewFunction);
}
}
/// <summary>
/// 操作流程(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OptProcess
{
get
{
return mstrOptProcess;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOptProcess = value;
}
else
{
 mstrOptProcess = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewTypeCodeTab.OptProcess);
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
 AddUpdatedFld(conViewTypeCodeTab.ViewDetail);
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
 AddUpdatedFld(conViewTypeCodeTab.ApplicationTypeId);
}
}
/// <summary>
/// 是否有添加(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsHaveAdd
{
get
{
return mbolIsHaveAdd;
}
set
{
 mbolIsHaveAdd = value;
//记录修改过的字段
 AddUpdatedFld(conViewTypeCodeTab.IsHaveAdd);
}
}
/// <summary>
/// 是否有修改(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsHaveUpdate
{
get
{
return mbolIsHaveUpdate;
}
set
{
 mbolIsHaveUpdate = value;
//记录修改过的字段
 AddUpdatedFld(conViewTypeCodeTab.IsHaveUpdate);
}
}
/// <summary>
/// 是否有删除(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsHaveDel
{
get
{
return mbolIsHaveDel;
}
set
{
 mbolIsHaveDel = value;
//记录修改过的字段
 AddUpdatedFld(conViewTypeCodeTab.IsHaveDel);
}
}
/// <summary>
/// 是否有查询(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsHaveQuery
{
get
{
return mbolIsHaveQuery;
}
set
{
 mbolIsHaveQuery = value;
//记录修改过的字段
 AddUpdatedFld(conViewTypeCodeTab.IsHaveQuery);
}
}
/// <summary>
/// 是否EXCEL导出(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsHaveExcelExport
{
get
{
return mbolIsHaveExcelExport;
}
set
{
 mbolIsHaveExcelExport = value;
//记录修改过的字段
 AddUpdatedFld(conViewTypeCodeTab.IsHaveExcelExport);
}
}
/// <summary>
/// 是否有设置EXCEL导出(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsHaveSetExportExcel
{
get
{
return mbolIsHaveSetExportExcel;
}
set
{
 mbolIsHaveSetExportExcel = value;
//记录修改过的字段
 AddUpdatedFld(conViewTypeCodeTab.IsHaveSetExportExcel);
}
}
/// <summary>
/// 是否有详细(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsHaveDetail
{
get
{
return mbolIsHaveDetail;
}
set
{
 mbolIsHaveDetail = value;
//记录修改过的字段
 AddUpdatedFld(conViewTypeCodeTab.IsHaveDetail);
}
}
/// <summary>
/// 是否有调用添加(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsHaveExeAdd
{
get
{
return mbolIsHaveExeAdd;
}
set
{
 mbolIsHaveExeAdd = value;
//记录修改过的字段
 AddUpdatedFld(conViewTypeCodeTab.IsHaveExeAdd);
}
}
/// <summary>
/// 是否有调用修改(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsHaveExeUpdate
{
get
{
return mbolIsHaveExeUpdate;
}
set
{
 mbolIsHaveExeUpdate = value;
//记录修改过的字段
 AddUpdatedFld(conViewTypeCodeTab.IsHaveExeUpdate);
}
}
/// <summary>
/// 是否有主界面(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsHaveMainView
{
get
{
return mbolIsHaveMainView;
}
set
{
 mbolIsHaveMainView = value;
//记录修改过的字段
 AddUpdatedFld(conViewTypeCodeTab.IsHaveMainView);
}
}
/// <summary>
/// 是否有子界面(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsHaveSubView
{
get
{
return mbolIsHaveSubView;
}
set
{
 mbolIsHaveSubView = value;
//记录修改过的字段
 AddUpdatedFld(conViewTypeCodeTab.IsHaveSubView);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(conViewTypeCodeTab.OrderNum);
}
}
/// <summary>
/// IsUsed(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsUsed
{
get
{
return mbolIsUsed;
}
set
{
 mbolIsUsed = value;
//记录修改过的字段
 AddUpdatedFld(conViewTypeCodeTab.IsUsed);
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
  return mintViewTypeCode.ToString();
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
  return mstrViewTypeName;
 }
 }
}
 /// <summary>
 /// 界面类型码(ViewTypeCodeTab)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conViewTypeCodeTab
{
public const string _CurrTabName = "ViewTypeCodeTab"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ViewTypeCode"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"ViewTypeCode", "ViewTypeName", "ViewTypeENName", "IsWinApp", "IsMobileApp", "IsWebApp", "ViewFunction", "OptProcess", "ViewDetail", "ApplicationTypeId", "IsHaveAdd", "IsHaveUpdate", "IsHaveDel", "IsHaveQuery", "IsHaveExcelExport", "IsHaveSetExportExcel", "IsHaveDetail", "IsHaveExeAdd", "IsHaveExeUpdate", "IsHaveMainView", "IsHaveSubView", "OrderNum", "IsUsed"};
//以下是属性变量


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
 /// 常量:"ViewTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewTypeENName = "ViewTypeENName";    //ViewTypeENName

 /// <summary>
 /// 常量:"IsWinApp"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsWinApp = "IsWinApp";    //IsWinApp

 /// <summary>
 /// 常量:"IsMobileApp"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsMobileApp = "IsMobileApp";    //是否移动终端应用

 /// <summary>
 /// 常量:"IsWebApp"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsWebApp = "IsWebApp";    //IsWebApp

 /// <summary>
 /// 常量:"ViewFunction"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewFunction = "ViewFunction";    //界面功能

 /// <summary>
 /// 常量:"OptProcess"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OptProcess = "OptProcess";    //操作流程

 /// <summary>
 /// 常量:"ViewDetail"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewDetail = "ViewDetail";    //界面说明

 /// <summary>
 /// 常量:"ApplicationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeId = "ApplicationTypeId";    //应用程序类型ID

 /// <summary>
 /// 常量:"IsHaveAdd"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsHaveAdd = "IsHaveAdd";    //是否有添加

 /// <summary>
 /// 常量:"IsHaveUpdate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsHaveUpdate = "IsHaveUpdate";    //是否有修改

 /// <summary>
 /// 常量:"IsHaveDel"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsHaveDel = "IsHaveDel";    //是否有删除

 /// <summary>
 /// 常量:"IsHaveQuery"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsHaveQuery = "IsHaveQuery";    //是否有查询

 /// <summary>
 /// 常量:"IsHaveExcelExport"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsHaveExcelExport = "IsHaveExcelExport";    //是否EXCEL导出

 /// <summary>
 /// 常量:"IsHaveSetExportExcel"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsHaveSetExportExcel = "IsHaveSetExportExcel";    //是否有设置EXCEL导出

 /// <summary>
 /// 常量:"IsHaveDetail"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsHaveDetail = "IsHaveDetail";    //是否有详细

 /// <summary>
 /// 常量:"IsHaveExeAdd"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsHaveExeAdd = "IsHaveExeAdd";    //是否有调用添加

 /// <summary>
 /// 常量:"IsHaveExeUpdate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsHaveExeUpdate = "IsHaveExeUpdate";    //是否有调用修改

 /// <summary>
 /// 常量:"IsHaveMainView"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsHaveMainView = "IsHaveMainView";    //是否有主界面

 /// <summary>
 /// 常量:"IsHaveSubView"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsHaveSubView = "IsHaveSubView";    //是否有子界面

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"IsUsed"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsUsed = "IsUsed";    //IsUsed
}

}