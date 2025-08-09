
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewTypeCodeTabEN
 表名:vViewTypeCodeTab(00050133)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:13:03
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
 /// 表vViewTypeCodeTab的关键字(ViewTypeCode)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ViewTypeCode_vViewTypeCodeTab
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
public K_ViewTypeCode_vViewTypeCodeTab(int intViewTypeCode)
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
 /// <returns>返回:[K_ViewTypeCode_vViewTypeCodeTab]类型的对象</returns>
public static implicit operator K_ViewTypeCode_vViewTypeCodeTab(int value)
{
return new K_ViewTypeCode_vViewTypeCodeTab(value);
}
}
 /// <summary>
 /// v界面类型码(vViewTypeCodeTab)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvViewTypeCodeTabEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vViewTypeCodeTab"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ViewTypeCode"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 24;
public static string[] _AttributeName = new string[] {"ViewTypeCode", "ViewTypeName", "ViewTypeENName", "IsWinApp", "IsMobileApp", "IsWebApp", "ViewFunction", "OptProcess", "ViewDetail", "ApplicationTypeId", "ApplicationTypeName", "IsHaveAdd", "IsHaveUpdate", "IsHaveDel", "IsHaveQuery", "IsHaveExcelExport", "IsHaveSetExportExcel", "IsHaveDetail", "IsHaveExeAdd", "IsHaveExeUpdate", "IsHaveMainView", "IsHaveSubView", "OrderNum", "IsUsed"};

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
protected string mstrApplicationTypeName;    //应用程序类型名称
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
 public clsvViewTypeCodeTabEN()
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
public clsvViewTypeCodeTabEN(int intViewTypeCode)
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
if (strAttributeName  ==  convViewTypeCodeTab.ViewTypeCode)
{
return mintViewTypeCode;
}
else if (strAttributeName  ==  convViewTypeCodeTab.ViewTypeName)
{
return mstrViewTypeName;
}
else if (strAttributeName  ==  convViewTypeCodeTab.ViewTypeENName)
{
return mstrViewTypeENName;
}
else if (strAttributeName  ==  convViewTypeCodeTab.IsWinApp)
{
return mbolIsWinApp;
}
else if (strAttributeName  ==  convViewTypeCodeTab.IsMobileApp)
{
return mbolIsMobileApp;
}
else if (strAttributeName  ==  convViewTypeCodeTab.IsWebApp)
{
return mbolIsWebApp;
}
else if (strAttributeName  ==  convViewTypeCodeTab.ViewFunction)
{
return mstrViewFunction;
}
else if (strAttributeName  ==  convViewTypeCodeTab.OptProcess)
{
return mstrOptProcess;
}
else if (strAttributeName  ==  convViewTypeCodeTab.ViewDetail)
{
return mstrViewDetail;
}
else if (strAttributeName  ==  convViewTypeCodeTab.ApplicationTypeId)
{
return mintApplicationTypeId;
}
else if (strAttributeName  ==  convViewTypeCodeTab.ApplicationTypeName)
{
return mstrApplicationTypeName;
}
else if (strAttributeName  ==  convViewTypeCodeTab.IsHaveAdd)
{
return mbolIsHaveAdd;
}
else if (strAttributeName  ==  convViewTypeCodeTab.IsHaveUpdate)
{
return mbolIsHaveUpdate;
}
else if (strAttributeName  ==  convViewTypeCodeTab.IsHaveDel)
{
return mbolIsHaveDel;
}
else if (strAttributeName  ==  convViewTypeCodeTab.IsHaveQuery)
{
return mbolIsHaveQuery;
}
else if (strAttributeName  ==  convViewTypeCodeTab.IsHaveExcelExport)
{
return mbolIsHaveExcelExport;
}
else if (strAttributeName  ==  convViewTypeCodeTab.IsHaveSetExportExcel)
{
return mbolIsHaveSetExportExcel;
}
else if (strAttributeName  ==  convViewTypeCodeTab.IsHaveDetail)
{
return mbolIsHaveDetail;
}
else if (strAttributeName  ==  convViewTypeCodeTab.IsHaveExeAdd)
{
return mbolIsHaveExeAdd;
}
else if (strAttributeName  ==  convViewTypeCodeTab.IsHaveExeUpdate)
{
return mbolIsHaveExeUpdate;
}
else if (strAttributeName  ==  convViewTypeCodeTab.IsHaveMainView)
{
return mbolIsHaveMainView;
}
else if (strAttributeName  ==  convViewTypeCodeTab.IsHaveSubView)
{
return mbolIsHaveSubView;
}
else if (strAttributeName  ==  convViewTypeCodeTab.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convViewTypeCodeTab.IsUsed)
{
return mbolIsUsed;
}
return null;
}
set
{
if (strAttributeName  ==  convViewTypeCodeTab.ViewTypeCode)
{
mintViewTypeCode = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewTypeCodeTab.ViewTypeCode);
}
else if (strAttributeName  ==  convViewTypeCodeTab.ViewTypeName)
{
mstrViewTypeName = value.ToString();
 AddUpdatedFld(convViewTypeCodeTab.ViewTypeName);
}
else if (strAttributeName  ==  convViewTypeCodeTab.ViewTypeENName)
{
mstrViewTypeENName = value.ToString();
 AddUpdatedFld(convViewTypeCodeTab.ViewTypeENName);
}
else if (strAttributeName  ==  convViewTypeCodeTab.IsWinApp)
{
mbolIsWinApp = TransNullToBool(value.ToString());
 AddUpdatedFld(convViewTypeCodeTab.IsWinApp);
}
else if (strAttributeName  ==  convViewTypeCodeTab.IsMobileApp)
{
mbolIsMobileApp = TransNullToBool(value.ToString());
 AddUpdatedFld(convViewTypeCodeTab.IsMobileApp);
}
else if (strAttributeName  ==  convViewTypeCodeTab.IsWebApp)
{
mbolIsWebApp = TransNullToBool(value.ToString());
 AddUpdatedFld(convViewTypeCodeTab.IsWebApp);
}
else if (strAttributeName  ==  convViewTypeCodeTab.ViewFunction)
{
mstrViewFunction = value.ToString();
 AddUpdatedFld(convViewTypeCodeTab.ViewFunction);
}
else if (strAttributeName  ==  convViewTypeCodeTab.OptProcess)
{
mstrOptProcess = value.ToString();
 AddUpdatedFld(convViewTypeCodeTab.OptProcess);
}
else if (strAttributeName  ==  convViewTypeCodeTab.ViewDetail)
{
mstrViewDetail = value.ToString();
 AddUpdatedFld(convViewTypeCodeTab.ViewDetail);
}
else if (strAttributeName  ==  convViewTypeCodeTab.ApplicationTypeId)
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewTypeCodeTab.ApplicationTypeId);
}
else if (strAttributeName  ==  convViewTypeCodeTab.ApplicationTypeName)
{
mstrApplicationTypeName = value.ToString();
 AddUpdatedFld(convViewTypeCodeTab.ApplicationTypeName);
}
else if (strAttributeName  ==  convViewTypeCodeTab.IsHaveAdd)
{
mbolIsHaveAdd = TransNullToBool(value.ToString());
 AddUpdatedFld(convViewTypeCodeTab.IsHaveAdd);
}
else if (strAttributeName  ==  convViewTypeCodeTab.IsHaveUpdate)
{
mbolIsHaveUpdate = TransNullToBool(value.ToString());
 AddUpdatedFld(convViewTypeCodeTab.IsHaveUpdate);
}
else if (strAttributeName  ==  convViewTypeCodeTab.IsHaveDel)
{
mbolIsHaveDel = TransNullToBool(value.ToString());
 AddUpdatedFld(convViewTypeCodeTab.IsHaveDel);
}
else if (strAttributeName  ==  convViewTypeCodeTab.IsHaveQuery)
{
mbolIsHaveQuery = TransNullToBool(value.ToString());
 AddUpdatedFld(convViewTypeCodeTab.IsHaveQuery);
}
else if (strAttributeName  ==  convViewTypeCodeTab.IsHaveExcelExport)
{
mbolIsHaveExcelExport = TransNullToBool(value.ToString());
 AddUpdatedFld(convViewTypeCodeTab.IsHaveExcelExport);
}
else if (strAttributeName  ==  convViewTypeCodeTab.IsHaveSetExportExcel)
{
mbolIsHaveSetExportExcel = TransNullToBool(value.ToString());
 AddUpdatedFld(convViewTypeCodeTab.IsHaveSetExportExcel);
}
else if (strAttributeName  ==  convViewTypeCodeTab.IsHaveDetail)
{
mbolIsHaveDetail = TransNullToBool(value.ToString());
 AddUpdatedFld(convViewTypeCodeTab.IsHaveDetail);
}
else if (strAttributeName  ==  convViewTypeCodeTab.IsHaveExeAdd)
{
mbolIsHaveExeAdd = TransNullToBool(value.ToString());
 AddUpdatedFld(convViewTypeCodeTab.IsHaveExeAdd);
}
else if (strAttributeName  ==  convViewTypeCodeTab.IsHaveExeUpdate)
{
mbolIsHaveExeUpdate = TransNullToBool(value.ToString());
 AddUpdatedFld(convViewTypeCodeTab.IsHaveExeUpdate);
}
else if (strAttributeName  ==  convViewTypeCodeTab.IsHaveMainView)
{
mbolIsHaveMainView = TransNullToBool(value.ToString());
 AddUpdatedFld(convViewTypeCodeTab.IsHaveMainView);
}
else if (strAttributeName  ==  convViewTypeCodeTab.IsHaveSubView)
{
mbolIsHaveSubView = TransNullToBool(value.ToString());
 AddUpdatedFld(convViewTypeCodeTab.IsHaveSubView);
}
else if (strAttributeName  ==  convViewTypeCodeTab.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewTypeCodeTab.OrderNum);
}
else if (strAttributeName  ==  convViewTypeCodeTab.IsUsed)
{
mbolIsUsed = TransNullToBool(value.ToString());
 AddUpdatedFld(convViewTypeCodeTab.IsUsed);
}
}
}
public object this[int intIndex]
{
get
{
if (convViewTypeCodeTab.ViewTypeCode  ==  _AttributeName[intIndex])
{
return mintViewTypeCode;
}
else if (convViewTypeCodeTab.ViewTypeName  ==  _AttributeName[intIndex])
{
return mstrViewTypeName;
}
else if (convViewTypeCodeTab.ViewTypeENName  ==  _AttributeName[intIndex])
{
return mstrViewTypeENName;
}
else if (convViewTypeCodeTab.IsWinApp  ==  _AttributeName[intIndex])
{
return mbolIsWinApp;
}
else if (convViewTypeCodeTab.IsMobileApp  ==  _AttributeName[intIndex])
{
return mbolIsMobileApp;
}
else if (convViewTypeCodeTab.IsWebApp  ==  _AttributeName[intIndex])
{
return mbolIsWebApp;
}
else if (convViewTypeCodeTab.ViewFunction  ==  _AttributeName[intIndex])
{
return mstrViewFunction;
}
else if (convViewTypeCodeTab.OptProcess  ==  _AttributeName[intIndex])
{
return mstrOptProcess;
}
else if (convViewTypeCodeTab.ViewDetail  ==  _AttributeName[intIndex])
{
return mstrViewDetail;
}
else if (convViewTypeCodeTab.ApplicationTypeId  ==  _AttributeName[intIndex])
{
return mintApplicationTypeId;
}
else if (convViewTypeCodeTab.ApplicationTypeName  ==  _AttributeName[intIndex])
{
return mstrApplicationTypeName;
}
else if (convViewTypeCodeTab.IsHaveAdd  ==  _AttributeName[intIndex])
{
return mbolIsHaveAdd;
}
else if (convViewTypeCodeTab.IsHaveUpdate  ==  _AttributeName[intIndex])
{
return mbolIsHaveUpdate;
}
else if (convViewTypeCodeTab.IsHaveDel  ==  _AttributeName[intIndex])
{
return mbolIsHaveDel;
}
else if (convViewTypeCodeTab.IsHaveQuery  ==  _AttributeName[intIndex])
{
return mbolIsHaveQuery;
}
else if (convViewTypeCodeTab.IsHaveExcelExport  ==  _AttributeName[intIndex])
{
return mbolIsHaveExcelExport;
}
else if (convViewTypeCodeTab.IsHaveSetExportExcel  ==  _AttributeName[intIndex])
{
return mbolIsHaveSetExportExcel;
}
else if (convViewTypeCodeTab.IsHaveDetail  ==  _AttributeName[intIndex])
{
return mbolIsHaveDetail;
}
else if (convViewTypeCodeTab.IsHaveExeAdd  ==  _AttributeName[intIndex])
{
return mbolIsHaveExeAdd;
}
else if (convViewTypeCodeTab.IsHaveExeUpdate  ==  _AttributeName[intIndex])
{
return mbolIsHaveExeUpdate;
}
else if (convViewTypeCodeTab.IsHaveMainView  ==  _AttributeName[intIndex])
{
return mbolIsHaveMainView;
}
else if (convViewTypeCodeTab.IsHaveSubView  ==  _AttributeName[intIndex])
{
return mbolIsHaveSubView;
}
else if (convViewTypeCodeTab.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convViewTypeCodeTab.IsUsed  ==  _AttributeName[intIndex])
{
return mbolIsUsed;
}
return null;
}
set
{
if (convViewTypeCodeTab.ViewTypeCode  ==  _AttributeName[intIndex])
{
mintViewTypeCode = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewTypeCodeTab.ViewTypeCode);
}
else if (convViewTypeCodeTab.ViewTypeName  ==  _AttributeName[intIndex])
{
mstrViewTypeName = value.ToString();
 AddUpdatedFld(convViewTypeCodeTab.ViewTypeName);
}
else if (convViewTypeCodeTab.ViewTypeENName  ==  _AttributeName[intIndex])
{
mstrViewTypeENName = value.ToString();
 AddUpdatedFld(convViewTypeCodeTab.ViewTypeENName);
}
else if (convViewTypeCodeTab.IsWinApp  ==  _AttributeName[intIndex])
{
mbolIsWinApp = TransNullToBool(value.ToString());
 AddUpdatedFld(convViewTypeCodeTab.IsWinApp);
}
else if (convViewTypeCodeTab.IsMobileApp  ==  _AttributeName[intIndex])
{
mbolIsMobileApp = TransNullToBool(value.ToString());
 AddUpdatedFld(convViewTypeCodeTab.IsMobileApp);
}
else if (convViewTypeCodeTab.IsWebApp  ==  _AttributeName[intIndex])
{
mbolIsWebApp = TransNullToBool(value.ToString());
 AddUpdatedFld(convViewTypeCodeTab.IsWebApp);
}
else if (convViewTypeCodeTab.ViewFunction  ==  _AttributeName[intIndex])
{
mstrViewFunction = value.ToString();
 AddUpdatedFld(convViewTypeCodeTab.ViewFunction);
}
else if (convViewTypeCodeTab.OptProcess  ==  _AttributeName[intIndex])
{
mstrOptProcess = value.ToString();
 AddUpdatedFld(convViewTypeCodeTab.OptProcess);
}
else if (convViewTypeCodeTab.ViewDetail  ==  _AttributeName[intIndex])
{
mstrViewDetail = value.ToString();
 AddUpdatedFld(convViewTypeCodeTab.ViewDetail);
}
else if (convViewTypeCodeTab.ApplicationTypeId  ==  _AttributeName[intIndex])
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewTypeCodeTab.ApplicationTypeId);
}
else if (convViewTypeCodeTab.ApplicationTypeName  ==  _AttributeName[intIndex])
{
mstrApplicationTypeName = value.ToString();
 AddUpdatedFld(convViewTypeCodeTab.ApplicationTypeName);
}
else if (convViewTypeCodeTab.IsHaveAdd  ==  _AttributeName[intIndex])
{
mbolIsHaveAdd = TransNullToBool(value.ToString());
 AddUpdatedFld(convViewTypeCodeTab.IsHaveAdd);
}
else if (convViewTypeCodeTab.IsHaveUpdate  ==  _AttributeName[intIndex])
{
mbolIsHaveUpdate = TransNullToBool(value.ToString());
 AddUpdatedFld(convViewTypeCodeTab.IsHaveUpdate);
}
else if (convViewTypeCodeTab.IsHaveDel  ==  _AttributeName[intIndex])
{
mbolIsHaveDel = TransNullToBool(value.ToString());
 AddUpdatedFld(convViewTypeCodeTab.IsHaveDel);
}
else if (convViewTypeCodeTab.IsHaveQuery  ==  _AttributeName[intIndex])
{
mbolIsHaveQuery = TransNullToBool(value.ToString());
 AddUpdatedFld(convViewTypeCodeTab.IsHaveQuery);
}
else if (convViewTypeCodeTab.IsHaveExcelExport  ==  _AttributeName[intIndex])
{
mbolIsHaveExcelExport = TransNullToBool(value.ToString());
 AddUpdatedFld(convViewTypeCodeTab.IsHaveExcelExport);
}
else if (convViewTypeCodeTab.IsHaveSetExportExcel  ==  _AttributeName[intIndex])
{
mbolIsHaveSetExportExcel = TransNullToBool(value.ToString());
 AddUpdatedFld(convViewTypeCodeTab.IsHaveSetExportExcel);
}
else if (convViewTypeCodeTab.IsHaveDetail  ==  _AttributeName[intIndex])
{
mbolIsHaveDetail = TransNullToBool(value.ToString());
 AddUpdatedFld(convViewTypeCodeTab.IsHaveDetail);
}
else if (convViewTypeCodeTab.IsHaveExeAdd  ==  _AttributeName[intIndex])
{
mbolIsHaveExeAdd = TransNullToBool(value.ToString());
 AddUpdatedFld(convViewTypeCodeTab.IsHaveExeAdd);
}
else if (convViewTypeCodeTab.IsHaveExeUpdate  ==  _AttributeName[intIndex])
{
mbolIsHaveExeUpdate = TransNullToBool(value.ToString());
 AddUpdatedFld(convViewTypeCodeTab.IsHaveExeUpdate);
}
else if (convViewTypeCodeTab.IsHaveMainView  ==  _AttributeName[intIndex])
{
mbolIsHaveMainView = TransNullToBool(value.ToString());
 AddUpdatedFld(convViewTypeCodeTab.IsHaveMainView);
}
else if (convViewTypeCodeTab.IsHaveSubView  ==  _AttributeName[intIndex])
{
mbolIsHaveSubView = TransNullToBool(value.ToString());
 AddUpdatedFld(convViewTypeCodeTab.IsHaveSubView);
}
else if (convViewTypeCodeTab.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewTypeCodeTab.OrderNum);
}
else if (convViewTypeCodeTab.IsUsed  ==  _AttributeName[intIndex])
{
mbolIsUsed = TransNullToBool(value.ToString());
 AddUpdatedFld(convViewTypeCodeTab.IsUsed);
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
 AddUpdatedFld(convViewTypeCodeTab.ViewTypeCode);
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
 AddUpdatedFld(convViewTypeCodeTab.ViewTypeName);
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
 AddUpdatedFld(convViewTypeCodeTab.ViewTypeENName);
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
 AddUpdatedFld(convViewTypeCodeTab.IsWinApp);
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
 AddUpdatedFld(convViewTypeCodeTab.IsMobileApp);
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
 AddUpdatedFld(convViewTypeCodeTab.IsWebApp);
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
 AddUpdatedFld(convViewTypeCodeTab.ViewFunction);
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
 AddUpdatedFld(convViewTypeCodeTab.OptProcess);
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
 AddUpdatedFld(convViewTypeCodeTab.ViewDetail);
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
 AddUpdatedFld(convViewTypeCodeTab.ApplicationTypeId);
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
 AddUpdatedFld(convViewTypeCodeTab.ApplicationTypeName);
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
 AddUpdatedFld(convViewTypeCodeTab.IsHaveAdd);
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
 AddUpdatedFld(convViewTypeCodeTab.IsHaveUpdate);
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
 AddUpdatedFld(convViewTypeCodeTab.IsHaveDel);
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
 AddUpdatedFld(convViewTypeCodeTab.IsHaveQuery);
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
 AddUpdatedFld(convViewTypeCodeTab.IsHaveExcelExport);
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
 AddUpdatedFld(convViewTypeCodeTab.IsHaveSetExportExcel);
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
 AddUpdatedFld(convViewTypeCodeTab.IsHaveDetail);
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
 AddUpdatedFld(convViewTypeCodeTab.IsHaveExeAdd);
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
 AddUpdatedFld(convViewTypeCodeTab.IsHaveExeUpdate);
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
 AddUpdatedFld(convViewTypeCodeTab.IsHaveMainView);
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
 AddUpdatedFld(convViewTypeCodeTab.IsHaveSubView);
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
 AddUpdatedFld(convViewTypeCodeTab.OrderNum);
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
 AddUpdatedFld(convViewTypeCodeTab.IsUsed);
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
}
 /// <summary>
 /// v界面类型码(vViewTypeCodeTab)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convViewTypeCodeTab
{
public const string _CurrTabName = "vViewTypeCodeTab"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ViewTypeCode"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"ViewTypeCode", "ViewTypeName", "ViewTypeENName", "IsWinApp", "IsMobileApp", "IsWebApp", "ViewFunction", "OptProcess", "ViewDetail", "ApplicationTypeId", "ApplicationTypeName", "IsHaveAdd", "IsHaveUpdate", "IsHaveDel", "IsHaveQuery", "IsHaveExcelExport", "IsHaveSetExportExcel", "IsHaveDetail", "IsHaveExeAdd", "IsHaveExeUpdate", "IsHaveMainView", "IsHaveSubView", "OrderNum", "IsUsed"};
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
 /// 常量:"ApplicationTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeName = "ApplicationTypeName";    //应用程序类型名称

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