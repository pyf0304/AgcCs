
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewFeatureFldsEN
 表名:ViewFeatureFlds(00050453)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:00:46
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:区域管理(RegionManage)
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
 /// 表ViewFeatureFlds的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_ViewFeatureFlds
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngmId">表关键字</param>
public K_mId_ViewFeatureFlds(long lngmId)
{
if (IsValid(lngmId)) Value = lngmId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngmId)
{
if (lngmId == 0) return false;
if (lngmId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_mId_ViewFeatureFlds]类型的对象</returns>
public static implicit operator K_mId_ViewFeatureFlds(long value)
{
return new K_mId_ViewFeatureFlds(value);
}
}
 /// <summary>
 /// 界面功能字段(ViewFeatureFlds)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsViewFeatureFldsEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ViewFeatureFlds"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 29;
public static string[] _AttributeName = new string[] {"mId", "ViewFeatureId", "FieldTypeId", "ReleFldId", "FuncName", "LabelCaption", "CtlTypeId", "VarId", "CtrlId", "DefaultValue", "OrderNum", "CssClass", "DdlItemsOptionId", "DsTabId", "FldIdCond2", "FldIdCond1", "VarIdCond2", "VarIdCond1", "TabFeatureId4Ddl", "ViewImplId", "Text", "DsCondStr", "DsSqlStr", "ItemsString", "PrjId", "UpdUser", "UpdDate", "InUse", "Memo"};

protected long mlngmId;    //mId
protected string mstrViewFeatureId;    //界面功能Id
protected string mstrFieldTypeId;    //字段类型Id
protected string mstrReleFldId;    //相关字段Id
protected string mstrFuncName;    //函数名
protected string mstrLabelCaption;    //标签标题
protected string mstrCtlTypeId;    //控件类型号
protected string mstrVarId;    //变量Id
protected string mstrCtrlId;    //控件Id
protected string mstrDefaultValue;    //缺省值
protected int? mintOrderNum;    //序号
protected string mstrCssClass;    //样式表
protected string mstrDdlItemsOptionId;    //下拉框列表选项ID
protected string mstrDsTabId;    //数据源表ID
protected string mstrFldIdCond2;    //字段Id_条件2
protected string mstrFldIdCond1;    //字段Id_条件1
protected string mstrVarIdCond2;    //数据源字段_条件1
protected string mstrVarIdCond1;    //变量Id_条件1
protected string mstrTabFeatureId4Ddl;    //下拉框表功能Id
protected string mstrViewImplId;    //界面实现Id
protected string mstrText;    //文本
protected string mstrDsCondStr;    //数据源条件串
protected string mstrDsSqlStr;    //数据源SQL串
protected string mstrItemsString;    //列表项串
protected string mstrPrjId;    //工程Id
protected string mstrUpdUser;    //修改者
protected string mstrUpdDate;    //修改日期
protected bool mbolInUse;    //是否在用
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsViewFeatureFldsEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:mId</param>
public clsViewFeatureFldsEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
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
if (strAttributeName  ==  conViewFeatureFlds.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conViewFeatureFlds.ViewFeatureId)
{
return mstrViewFeatureId;
}
else if (strAttributeName  ==  conViewFeatureFlds.FieldTypeId)
{
return mstrFieldTypeId;
}
else if (strAttributeName  ==  conViewFeatureFlds.ReleFldId)
{
return mstrReleFldId;
}
else if (strAttributeName  ==  conViewFeatureFlds.FuncName)
{
return mstrFuncName;
}
else if (strAttributeName  ==  conViewFeatureFlds.LabelCaption)
{
return mstrLabelCaption;
}
else if (strAttributeName  ==  conViewFeatureFlds.CtlTypeId)
{
return mstrCtlTypeId;
}
else if (strAttributeName  ==  conViewFeatureFlds.VarId)
{
return mstrVarId;
}
else if (strAttributeName  ==  conViewFeatureFlds.CtrlId)
{
return mstrCtrlId;
}
else if (strAttributeName  ==  conViewFeatureFlds.DefaultValue)
{
return mstrDefaultValue;
}
else if (strAttributeName  ==  conViewFeatureFlds.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conViewFeatureFlds.CssClass)
{
return mstrCssClass;
}
else if (strAttributeName  ==  conViewFeatureFlds.DdlItemsOptionId)
{
return mstrDdlItemsOptionId;
}
else if (strAttributeName  ==  conViewFeatureFlds.DsTabId)
{
return mstrDsTabId;
}
else if (strAttributeName  ==  conViewFeatureFlds.FldIdCond2)
{
return mstrFldIdCond2;
}
else if (strAttributeName  ==  conViewFeatureFlds.FldIdCond1)
{
return mstrFldIdCond1;
}
else if (strAttributeName  ==  conViewFeatureFlds.VarIdCond2)
{
return mstrVarIdCond2;
}
else if (strAttributeName  ==  conViewFeatureFlds.VarIdCond1)
{
return mstrVarIdCond1;
}
else if (strAttributeName  ==  conViewFeatureFlds.TabFeatureId4Ddl)
{
return mstrTabFeatureId4Ddl;
}
else if (strAttributeName  ==  conViewFeatureFlds.ViewImplId)
{
return mstrViewImplId;
}
else if (strAttributeName  ==  conViewFeatureFlds.Text)
{
return mstrText;
}
else if (strAttributeName  ==  conViewFeatureFlds.DsCondStr)
{
return mstrDsCondStr;
}
else if (strAttributeName  ==  conViewFeatureFlds.DsSqlStr)
{
return mstrDsSqlStr;
}
else if (strAttributeName  ==  conViewFeatureFlds.ItemsString)
{
return mstrItemsString;
}
else if (strAttributeName  ==  conViewFeatureFlds.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conViewFeatureFlds.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conViewFeatureFlds.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conViewFeatureFlds.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  conViewFeatureFlds.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conViewFeatureFlds.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewFeatureFlds.mId);
}
else if (strAttributeName  ==  conViewFeatureFlds.ViewFeatureId)
{
mstrViewFeatureId = value.ToString();
 AddUpdatedFld(conViewFeatureFlds.ViewFeatureId);
}
else if (strAttributeName  ==  conViewFeatureFlds.FieldTypeId)
{
mstrFieldTypeId = value.ToString();
 AddUpdatedFld(conViewFeatureFlds.FieldTypeId);
}
else if (strAttributeName  ==  conViewFeatureFlds.ReleFldId)
{
mstrReleFldId = value.ToString();
 AddUpdatedFld(conViewFeatureFlds.ReleFldId);
}
else if (strAttributeName  ==  conViewFeatureFlds.FuncName)
{
mstrFuncName = value.ToString();
 AddUpdatedFld(conViewFeatureFlds.FuncName);
}
else if (strAttributeName  ==  conViewFeatureFlds.LabelCaption)
{
mstrLabelCaption = value.ToString();
 AddUpdatedFld(conViewFeatureFlds.LabelCaption);
}
else if (strAttributeName  ==  conViewFeatureFlds.CtlTypeId)
{
mstrCtlTypeId = value.ToString();
 AddUpdatedFld(conViewFeatureFlds.CtlTypeId);
}
else if (strAttributeName  ==  conViewFeatureFlds.VarId)
{
mstrVarId = value.ToString();
 AddUpdatedFld(conViewFeatureFlds.VarId);
}
else if (strAttributeName  ==  conViewFeatureFlds.CtrlId)
{
mstrCtrlId = value.ToString();
 AddUpdatedFld(conViewFeatureFlds.CtrlId);
}
else if (strAttributeName  ==  conViewFeatureFlds.DefaultValue)
{
mstrDefaultValue = value.ToString();
 AddUpdatedFld(conViewFeatureFlds.DefaultValue);
}
else if (strAttributeName  ==  conViewFeatureFlds.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewFeatureFlds.OrderNum);
}
else if (strAttributeName  ==  conViewFeatureFlds.CssClass)
{
mstrCssClass = value.ToString();
 AddUpdatedFld(conViewFeatureFlds.CssClass);
}
else if (strAttributeName  ==  conViewFeatureFlds.DdlItemsOptionId)
{
mstrDdlItemsOptionId = value.ToString();
 AddUpdatedFld(conViewFeatureFlds.DdlItemsOptionId);
}
else if (strAttributeName  ==  conViewFeatureFlds.DsTabId)
{
mstrDsTabId = value.ToString();
 AddUpdatedFld(conViewFeatureFlds.DsTabId);
}
else if (strAttributeName  ==  conViewFeatureFlds.FldIdCond2)
{
mstrFldIdCond2 = value.ToString();
 AddUpdatedFld(conViewFeatureFlds.FldIdCond2);
}
else if (strAttributeName  ==  conViewFeatureFlds.FldIdCond1)
{
mstrFldIdCond1 = value.ToString();
 AddUpdatedFld(conViewFeatureFlds.FldIdCond1);
}
else if (strAttributeName  ==  conViewFeatureFlds.VarIdCond2)
{
mstrVarIdCond2 = value.ToString();
 AddUpdatedFld(conViewFeatureFlds.VarIdCond2);
}
else if (strAttributeName  ==  conViewFeatureFlds.VarIdCond1)
{
mstrVarIdCond1 = value.ToString();
 AddUpdatedFld(conViewFeatureFlds.VarIdCond1);
}
else if (strAttributeName  ==  conViewFeatureFlds.TabFeatureId4Ddl)
{
mstrTabFeatureId4Ddl = value.ToString();
 AddUpdatedFld(conViewFeatureFlds.TabFeatureId4Ddl);
}
else if (strAttributeName  ==  conViewFeatureFlds.ViewImplId)
{
mstrViewImplId = value.ToString();
 AddUpdatedFld(conViewFeatureFlds.ViewImplId);
}
else if (strAttributeName  ==  conViewFeatureFlds.Text)
{
mstrText = value.ToString();
 AddUpdatedFld(conViewFeatureFlds.Text);
}
else if (strAttributeName  ==  conViewFeatureFlds.DsCondStr)
{
mstrDsCondStr = value.ToString();
 AddUpdatedFld(conViewFeatureFlds.DsCondStr);
}
else if (strAttributeName  ==  conViewFeatureFlds.DsSqlStr)
{
mstrDsSqlStr = value.ToString();
 AddUpdatedFld(conViewFeatureFlds.DsSqlStr);
}
else if (strAttributeName  ==  conViewFeatureFlds.ItemsString)
{
mstrItemsString = value.ToString();
 AddUpdatedFld(conViewFeatureFlds.ItemsString);
}
else if (strAttributeName  ==  conViewFeatureFlds.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conViewFeatureFlds.PrjId);
}
else if (strAttributeName  ==  conViewFeatureFlds.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conViewFeatureFlds.UpdUser);
}
else if (strAttributeName  ==  conViewFeatureFlds.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conViewFeatureFlds.UpdDate);
}
else if (strAttributeName  ==  conViewFeatureFlds.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewFeatureFlds.InUse);
}
else if (strAttributeName  ==  conViewFeatureFlds.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conViewFeatureFlds.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conViewFeatureFlds.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (conViewFeatureFlds.ViewFeatureId  ==  _AttributeName[intIndex])
{
return mstrViewFeatureId;
}
else if (conViewFeatureFlds.FieldTypeId  ==  _AttributeName[intIndex])
{
return mstrFieldTypeId;
}
else if (conViewFeatureFlds.ReleFldId  ==  _AttributeName[intIndex])
{
return mstrReleFldId;
}
else if (conViewFeatureFlds.FuncName  ==  _AttributeName[intIndex])
{
return mstrFuncName;
}
else if (conViewFeatureFlds.LabelCaption  ==  _AttributeName[intIndex])
{
return mstrLabelCaption;
}
else if (conViewFeatureFlds.CtlTypeId  ==  _AttributeName[intIndex])
{
return mstrCtlTypeId;
}
else if (conViewFeatureFlds.VarId  ==  _AttributeName[intIndex])
{
return mstrVarId;
}
else if (conViewFeatureFlds.CtrlId  ==  _AttributeName[intIndex])
{
return mstrCtrlId;
}
else if (conViewFeatureFlds.DefaultValue  ==  _AttributeName[intIndex])
{
return mstrDefaultValue;
}
else if (conViewFeatureFlds.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conViewFeatureFlds.CssClass  ==  _AttributeName[intIndex])
{
return mstrCssClass;
}
else if (conViewFeatureFlds.DdlItemsOptionId  ==  _AttributeName[intIndex])
{
return mstrDdlItemsOptionId;
}
else if (conViewFeatureFlds.DsTabId  ==  _AttributeName[intIndex])
{
return mstrDsTabId;
}
else if (conViewFeatureFlds.FldIdCond2  ==  _AttributeName[intIndex])
{
return mstrFldIdCond2;
}
else if (conViewFeatureFlds.FldIdCond1  ==  _AttributeName[intIndex])
{
return mstrFldIdCond1;
}
else if (conViewFeatureFlds.VarIdCond2  ==  _AttributeName[intIndex])
{
return mstrVarIdCond2;
}
else if (conViewFeatureFlds.VarIdCond1  ==  _AttributeName[intIndex])
{
return mstrVarIdCond1;
}
else if (conViewFeatureFlds.TabFeatureId4Ddl  ==  _AttributeName[intIndex])
{
return mstrTabFeatureId4Ddl;
}
else if (conViewFeatureFlds.ViewImplId  ==  _AttributeName[intIndex])
{
return mstrViewImplId;
}
else if (conViewFeatureFlds.Text  ==  _AttributeName[intIndex])
{
return mstrText;
}
else if (conViewFeatureFlds.DsCondStr  ==  _AttributeName[intIndex])
{
return mstrDsCondStr;
}
else if (conViewFeatureFlds.DsSqlStr  ==  _AttributeName[intIndex])
{
return mstrDsSqlStr;
}
else if (conViewFeatureFlds.ItemsString  ==  _AttributeName[intIndex])
{
return mstrItemsString;
}
else if (conViewFeatureFlds.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conViewFeatureFlds.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conViewFeatureFlds.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conViewFeatureFlds.InUse  ==  _AttributeName[intIndex])
{
return mbolInUse;
}
else if (conViewFeatureFlds.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conViewFeatureFlds.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewFeatureFlds.mId);
}
else if (conViewFeatureFlds.ViewFeatureId  ==  _AttributeName[intIndex])
{
mstrViewFeatureId = value.ToString();
 AddUpdatedFld(conViewFeatureFlds.ViewFeatureId);
}
else if (conViewFeatureFlds.FieldTypeId  ==  _AttributeName[intIndex])
{
mstrFieldTypeId = value.ToString();
 AddUpdatedFld(conViewFeatureFlds.FieldTypeId);
}
else if (conViewFeatureFlds.ReleFldId  ==  _AttributeName[intIndex])
{
mstrReleFldId = value.ToString();
 AddUpdatedFld(conViewFeatureFlds.ReleFldId);
}
else if (conViewFeatureFlds.FuncName  ==  _AttributeName[intIndex])
{
mstrFuncName = value.ToString();
 AddUpdatedFld(conViewFeatureFlds.FuncName);
}
else if (conViewFeatureFlds.LabelCaption  ==  _AttributeName[intIndex])
{
mstrLabelCaption = value.ToString();
 AddUpdatedFld(conViewFeatureFlds.LabelCaption);
}
else if (conViewFeatureFlds.CtlTypeId  ==  _AttributeName[intIndex])
{
mstrCtlTypeId = value.ToString();
 AddUpdatedFld(conViewFeatureFlds.CtlTypeId);
}
else if (conViewFeatureFlds.VarId  ==  _AttributeName[intIndex])
{
mstrVarId = value.ToString();
 AddUpdatedFld(conViewFeatureFlds.VarId);
}
else if (conViewFeatureFlds.CtrlId  ==  _AttributeName[intIndex])
{
mstrCtrlId = value.ToString();
 AddUpdatedFld(conViewFeatureFlds.CtrlId);
}
else if (conViewFeatureFlds.DefaultValue  ==  _AttributeName[intIndex])
{
mstrDefaultValue = value.ToString();
 AddUpdatedFld(conViewFeatureFlds.DefaultValue);
}
else if (conViewFeatureFlds.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewFeatureFlds.OrderNum);
}
else if (conViewFeatureFlds.CssClass  ==  _AttributeName[intIndex])
{
mstrCssClass = value.ToString();
 AddUpdatedFld(conViewFeatureFlds.CssClass);
}
else if (conViewFeatureFlds.DdlItemsOptionId  ==  _AttributeName[intIndex])
{
mstrDdlItemsOptionId = value.ToString();
 AddUpdatedFld(conViewFeatureFlds.DdlItemsOptionId);
}
else if (conViewFeatureFlds.DsTabId  ==  _AttributeName[intIndex])
{
mstrDsTabId = value.ToString();
 AddUpdatedFld(conViewFeatureFlds.DsTabId);
}
else if (conViewFeatureFlds.FldIdCond2  ==  _AttributeName[intIndex])
{
mstrFldIdCond2 = value.ToString();
 AddUpdatedFld(conViewFeatureFlds.FldIdCond2);
}
else if (conViewFeatureFlds.FldIdCond1  ==  _AttributeName[intIndex])
{
mstrFldIdCond1 = value.ToString();
 AddUpdatedFld(conViewFeatureFlds.FldIdCond1);
}
else if (conViewFeatureFlds.VarIdCond2  ==  _AttributeName[intIndex])
{
mstrVarIdCond2 = value.ToString();
 AddUpdatedFld(conViewFeatureFlds.VarIdCond2);
}
else if (conViewFeatureFlds.VarIdCond1  ==  _AttributeName[intIndex])
{
mstrVarIdCond1 = value.ToString();
 AddUpdatedFld(conViewFeatureFlds.VarIdCond1);
}
else if (conViewFeatureFlds.TabFeatureId4Ddl  ==  _AttributeName[intIndex])
{
mstrTabFeatureId4Ddl = value.ToString();
 AddUpdatedFld(conViewFeatureFlds.TabFeatureId4Ddl);
}
else if (conViewFeatureFlds.ViewImplId  ==  _AttributeName[intIndex])
{
mstrViewImplId = value.ToString();
 AddUpdatedFld(conViewFeatureFlds.ViewImplId);
}
else if (conViewFeatureFlds.Text  ==  _AttributeName[intIndex])
{
mstrText = value.ToString();
 AddUpdatedFld(conViewFeatureFlds.Text);
}
else if (conViewFeatureFlds.DsCondStr  ==  _AttributeName[intIndex])
{
mstrDsCondStr = value.ToString();
 AddUpdatedFld(conViewFeatureFlds.DsCondStr);
}
else if (conViewFeatureFlds.DsSqlStr  ==  _AttributeName[intIndex])
{
mstrDsSqlStr = value.ToString();
 AddUpdatedFld(conViewFeatureFlds.DsSqlStr);
}
else if (conViewFeatureFlds.ItemsString  ==  _AttributeName[intIndex])
{
mstrItemsString = value.ToString();
 AddUpdatedFld(conViewFeatureFlds.ItemsString);
}
else if (conViewFeatureFlds.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conViewFeatureFlds.PrjId);
}
else if (conViewFeatureFlds.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conViewFeatureFlds.UpdUser);
}
else if (conViewFeatureFlds.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conViewFeatureFlds.UpdDate);
}
else if (conViewFeatureFlds.InUse  ==  _AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewFeatureFlds.InUse);
}
else if (conViewFeatureFlds.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conViewFeatureFlds.Memo);
}
}
}

/// <summary>
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long mId
{
get
{
return mlngmId;
}
set
{
 mlngmId = value;
//记录修改过的字段
 AddUpdatedFld(conViewFeatureFlds.mId);
}
}
/// <summary>
/// 界面功能Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewFeatureId
{
get
{
return mstrViewFeatureId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewFeatureId = value;
}
else
{
 mstrViewFeatureId = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewFeatureFlds.ViewFeatureId);
}
}
/// <summary>
/// 字段类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FieldTypeId
{
get
{
return mstrFieldTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFieldTypeId = value;
}
else
{
 mstrFieldTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewFeatureFlds.FieldTypeId);
}
}
/// <summary>
/// 相关字段Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ReleFldId
{
get
{
return mstrReleFldId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrReleFldId = value;
}
else
{
 mstrReleFldId = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewFeatureFlds.ReleFldId);
}
}
/// <summary>
/// 函数名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncName
{
get
{
return mstrFuncName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncName = value;
}
else
{
 mstrFuncName = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewFeatureFlds.FuncName);
}
}
/// <summary>
/// 标签标题(说明:;字段类型:varchar;字段长度:150;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LabelCaption
{
get
{
return mstrLabelCaption;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLabelCaption = value;
}
else
{
 mstrLabelCaption = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewFeatureFlds.LabelCaption);
}
}
/// <summary>
/// 控件类型号(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CtlTypeId
{
get
{
return mstrCtlTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCtlTypeId = value;
}
else
{
 mstrCtlTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewFeatureFlds.CtlTypeId);
}
}
/// <summary>
/// 变量Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VarId
{
get
{
return mstrVarId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVarId = value;
}
else
{
 mstrVarId = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewFeatureFlds.VarId);
}
}
/// <summary>
/// 控件Id(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CtrlId
{
get
{
return mstrCtrlId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCtrlId = value;
}
else
{
 mstrCtrlId = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewFeatureFlds.CtrlId);
}
}
/// <summary>
/// 缺省值(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DefaultValue
{
get
{
return mstrDefaultValue;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDefaultValue = value;
}
else
{
 mstrDefaultValue = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewFeatureFlds.DefaultValue);
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
 AddUpdatedFld(conViewFeatureFlds.OrderNum);
}
}
/// <summary>
/// 样式表(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CssClass
{
get
{
return mstrCssClass;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCssClass = value;
}
else
{
 mstrCssClass = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewFeatureFlds.CssClass);
}
}
/// <summary>
/// 下拉框列表选项ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DdlItemsOptionId
{
get
{
return mstrDdlItemsOptionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDdlItemsOptionId = value;
}
else
{
 mstrDdlItemsOptionId = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewFeatureFlds.DdlItemsOptionId);
}
}
/// <summary>
/// 数据源表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DsTabId
{
get
{
return mstrDsTabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDsTabId = value;
}
else
{
 mstrDsTabId = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewFeatureFlds.DsTabId);
}
}
/// <summary>
/// 字段Id_条件2(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FldIdCond2
{
get
{
return mstrFldIdCond2;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldIdCond2 = value;
}
else
{
 mstrFldIdCond2 = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewFeatureFlds.FldIdCond2);
}
}
/// <summary>
/// 字段Id_条件1(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FldIdCond1
{
get
{
return mstrFldIdCond1;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldIdCond1 = value;
}
else
{
 mstrFldIdCond1 = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewFeatureFlds.FldIdCond1);
}
}
/// <summary>
/// 数据源字段_条件1(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VarIdCond2
{
get
{
return mstrVarIdCond2;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVarIdCond2 = value;
}
else
{
 mstrVarIdCond2 = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewFeatureFlds.VarIdCond2);
}
}
/// <summary>
/// 变量Id_条件1(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VarIdCond1
{
get
{
return mstrVarIdCond1;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVarIdCond1 = value;
}
else
{
 mstrVarIdCond1 = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewFeatureFlds.VarIdCond1);
}
}
/// <summary>
/// 下拉框表功能Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabFeatureId4Ddl
{
get
{
return mstrTabFeatureId4Ddl;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabFeatureId4Ddl = value;
}
else
{
 mstrTabFeatureId4Ddl = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewFeatureFlds.TabFeatureId4Ddl);
}
}
/// <summary>
/// 界面实现Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewImplId
{
get
{
return mstrViewImplId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewImplId = value;
}
else
{
 mstrViewImplId = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewFeatureFlds.ViewImplId);
}
}
/// <summary>
/// 文本(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Text
{
get
{
return mstrText;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrText = value;
}
else
{
 mstrText = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewFeatureFlds.Text);
}
}
/// <summary>
/// 数据源条件串(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DsCondStr
{
get
{
return mstrDsCondStr;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDsCondStr = value;
}
else
{
 mstrDsCondStr = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewFeatureFlds.DsCondStr);
}
}
/// <summary>
/// 数据源SQL串(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DsSqlStr
{
get
{
return mstrDsSqlStr;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDsSqlStr = value;
}
else
{
 mstrDsSqlStr = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewFeatureFlds.DsSqlStr);
}
}
/// <summary>
/// 列表项串(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ItemsString
{
get
{
return mstrItemsString;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrItemsString = value;
}
else
{
 mstrItemsString = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewFeatureFlds.ItemsString);
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
 AddUpdatedFld(conViewFeatureFlds.PrjId);
}
}
/// <summary>
/// 修改者(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUser
{
get
{
return mstrUpdUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUser = value;
}
else
{
 mstrUpdUser = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewFeatureFlds.UpdUser);
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
 AddUpdatedFld(conViewFeatureFlds.UpdDate);
}
}
/// <summary>
/// 是否在用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool InUse
{
get
{
return mbolInUse;
}
set
{
 mbolInUse = value;
//记录修改过的字段
 AddUpdatedFld(conViewFeatureFlds.InUse);
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
 AddUpdatedFld(conViewFeatureFlds.Memo);
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
  return mlngmId.ToString();
 }
 }
}
 /// <summary>
 /// 界面功能字段(ViewFeatureFlds)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conViewFeatureFlds
{
public const string _CurrTabName = "ViewFeatureFlds"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "ViewFeatureId", "FieldTypeId", "ReleFldId", "FuncName", "LabelCaption", "CtlTypeId", "VarId", "CtrlId", "DefaultValue", "OrderNum", "CssClass", "DdlItemsOptionId", "DsTabId", "FldIdCond2", "FldIdCond1", "VarIdCond2", "VarIdCond1", "TabFeatureId4Ddl", "ViewImplId", "Text", "DsCondStr", "DsSqlStr", "ItemsString", "PrjId", "UpdUser", "UpdDate", "InUse", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"ViewFeatureId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewFeatureId = "ViewFeatureId";    //界面功能Id

 /// <summary>
 /// 常量:"FieldTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FieldTypeId = "FieldTypeId";    //字段类型Id

 /// <summary>
 /// 常量:"ReleFldId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReleFldId = "ReleFldId";    //相关字段Id

 /// <summary>
 /// 常量:"FuncName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncName = "FuncName";    //函数名

 /// <summary>
 /// 常量:"LabelCaption"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LabelCaption = "LabelCaption";    //标签标题

 /// <summary>
 /// 常量:"CtlTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CtlTypeId = "CtlTypeId";    //控件类型号

 /// <summary>
 /// 常量:"VarId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VarId = "VarId";    //变量Id

 /// <summary>
 /// 常量:"CtrlId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CtrlId = "CtrlId";    //控件Id

 /// <summary>
 /// 常量:"DefaultValue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DefaultValue = "DefaultValue";    //缺省值

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"CssClass"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CssClass = "CssClass";    //样式表

 /// <summary>
 /// 常量:"DdlItemsOptionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DdlItemsOptionId = "DdlItemsOptionId";    //下拉框列表选项ID

 /// <summary>
 /// 常量:"DsTabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DsTabId = "DsTabId";    //数据源表ID

 /// <summary>
 /// 常量:"FldIdCond2"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldIdCond2 = "FldIdCond2";    //字段Id_条件2

 /// <summary>
 /// 常量:"FldIdCond1"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldIdCond1 = "FldIdCond1";    //字段Id_条件1

 /// <summary>
 /// 常量:"VarIdCond2"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VarIdCond2 = "VarIdCond2";    //数据源字段_条件1

 /// <summary>
 /// 常量:"VarIdCond1"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VarIdCond1 = "VarIdCond1";    //变量Id_条件1

 /// <summary>
 /// 常量:"TabFeatureId4Ddl"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabFeatureId4Ddl = "TabFeatureId4Ddl";    //下拉框表功能Id

 /// <summary>
 /// 常量:"ViewImplId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewImplId = "ViewImplId";    //界面实现Id

 /// <summary>
 /// 常量:"Text"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Text = "Text";    //文本

 /// <summary>
 /// 常量:"DsCondStr"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DsCondStr = "DsCondStr";    //数据源条件串

 /// <summary>
 /// 常量:"DsSqlStr"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DsSqlStr = "DsSqlStr";    //数据源SQL串

 /// <summary>
 /// 常量:"ItemsString"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ItemsString = "ItemsString";    //列表项串

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改者

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"InUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InUse = "InUse";    //是否在用

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}