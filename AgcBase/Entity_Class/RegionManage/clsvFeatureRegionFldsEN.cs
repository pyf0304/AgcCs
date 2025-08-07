
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFeatureRegionFldsEN
 表名:vFeatureRegionFlds(00050197)
 * 版本:2024.01.24.1(服务器:WIN-SRV103-116)
 日期:2024/01/26 14:38:48
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:区域管理(RegionManage)
 框架-层名:实体层(CS)(EntityLayer)
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

namespace AGC.Entity
{
 /// <summary>
 /// 表vFeatureRegionFlds的关键字(ViewFeatureId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ViewFeatureId_vFeatureRegionFlds
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strViewFeatureId">表关键字</param>
public K_ViewFeatureId_vFeatureRegionFlds(string strViewFeatureId)
{
if (IsValid(strViewFeatureId)) Value = strViewFeatureId;
else
{
Value = null;
}
}
private static bool IsValid(string strViewFeatureId)
{
if (string.IsNullOrEmpty(strViewFeatureId) == true) return false;
if (strViewFeatureId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ViewFeatureId_vFeatureRegionFlds]类型的对象</returns>
public static implicit operator K_ViewFeatureId_vFeatureRegionFlds(string value)
{
return new K_ViewFeatureId_vFeatureRegionFlds(value);
}
}
 /// <summary>
 /// v功能区域字段(vFeatureRegionFlds)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvFeatureRegionFldsEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vFeatureRegionFlds"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ViewFeatureId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 45;
public static string[] AttributeName = new string[] {"ViewFeatureId", "RegionId", "RegionName", "RegionTypeId", "RegionTypeName", "RegionTypeSimName", "FeatureId", "FeatureName", "KeyWords", "TabFeatureId", "TabFeatureName", "CheckTabFeature", "FeatureDescription", "ButtonName", "ButtonName4Mvc", "EventFuncName", "ValueGivingModeId", "ValueGivingModeName", "FuncName", "DefaultValue", "KeyIdGetModeId", "Text", "GroupName", "ReleTabId", "ReleFldId", "FieldTypeId", "FieldTypeName", "ViewImplId", "ViewImplName", "CtlTypeId", "CtlTypeName", "CtlCnName", "CtlTypeAbbr", "Height", "Width", "SeqNum", "CssClass", "ImageUrl", "InUse", "UpdUser", "UpdDate", "Memo", "RelaFldName", "RelaTabName", "PrjId"};

protected string mstrViewFeatureId;    //界面功能Id
protected string mstrRegionId;    //区域Id
protected string mstrRegionName;    //区域名称
protected string mstrRegionTypeId;    //区域类型Id
protected string mstrRegionTypeName;    //区域类型名称
protected string mstrRegionTypeSimName;    //区域类型简名
protected string mstrFeatureId;    //功能Id
protected string mstrFeatureName;    //功能名称
protected string mstrKeyWords;    //关键字
protected string mstrTabFeatureId;    //表功能Id
protected string mstrTabFeatureName;    //表功能名
protected string mstrCheckTabFeature;    //检查表功能
protected string mstrFeatureDescription;    //功能说明
protected string mstrButtonName;    //按钮名称
protected string mstrButtonName4Mvc;    //按钮名称4Mvc
protected string mstrEventFuncName;    //事件函数名
protected string mstrValueGivingModeId;    //给值方式Id
protected string mstrValueGivingModeName;    //给值方式名
protected string mstrFuncName;    //函数名
protected string mstrDefaultValue;    //缺省值
protected string mstrKeyIdGetModeId;    //GC关键字获取方式Id
protected string mstrText;    //文本
protected string mstrGroupName;    //组名
protected string mstrReleTabId;    //相关表Id
protected string mstrReleFldId;    //相关字段Id
protected string mstrFieldTypeId;    //字段类型Id
protected string mstrFieldTypeName;    //字段类型名
protected string mstrViewImplId;    //界面实现Id
protected string mstrViewImplName;    //界面实现名
protected string mstrCtlTypeId;    //控件类型号
protected string mstrCtlTypeName;    //控件类型名
protected string mstrCtlCnName;    //控件类型中文名
protected string mstrCtlTypeAbbr;    //控件类型缩写
protected int? mintHeight;    //高度
protected int? mintWidth;    //宽
protected int? mintSeqNum;    //字段序号
protected string mstrCssClass;    //样式表
protected string mstrImageUrl;    //图片资源
protected bool mbolInUse;    //是否在用
protected string mstrUpdUser;    //修改者
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //说明
protected string mstrRelaFldName;    //关系字段名
protected string mstrRelaTabName;    //相关表名
protected string mstrPrjId;    //工程ID

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvFeatureRegionFldsEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ViewFeatureId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strViewFeatureId">关键字:界面功能Id</param>
public clsvFeatureRegionFldsEN(string strViewFeatureId)
 {
strViewFeatureId = strViewFeatureId.Replace("'", "''");
if (strViewFeatureId.Length > 8)
{
throw new Exception("在表:vFeatureRegionFlds中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strViewFeatureId)  ==  true)
{
throw new Exception("在表:vFeatureRegionFlds中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strViewFeatureId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrViewFeatureId = strViewFeatureId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ViewFeatureId");
 }

public static int AttributeCount
{
get
{
return mintAttributeCount;
}
}
public override object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  convFeatureRegionFlds.ViewFeatureId)
{
return mstrViewFeatureId;
}
else if (strAttributeName  ==  convFeatureRegionFlds.RegionId)
{
return mstrRegionId;
}
else if (strAttributeName  ==  convFeatureRegionFlds.RegionName)
{
return mstrRegionName;
}
else if (strAttributeName  ==  convFeatureRegionFlds.RegionTypeId)
{
return mstrRegionTypeId;
}
else if (strAttributeName  ==  convFeatureRegionFlds.RegionTypeName)
{
return mstrRegionTypeName;
}
else if (strAttributeName  ==  convFeatureRegionFlds.RegionTypeSimName)
{
return mstrRegionTypeSimName;
}
else if (strAttributeName  ==  convFeatureRegionFlds.FeatureId)
{
return mstrFeatureId;
}
else if (strAttributeName  ==  convFeatureRegionFlds.FeatureName)
{
return mstrFeatureName;
}
else if (strAttributeName  ==  convFeatureRegionFlds.KeyWords)
{
return mstrKeyWords;
}
else if (strAttributeName  ==  convFeatureRegionFlds.TabFeatureId)
{
return mstrTabFeatureId;
}
else if (strAttributeName  ==  convFeatureRegionFlds.TabFeatureName)
{
return mstrTabFeatureName;
}
else if (strAttributeName  ==  convFeatureRegionFlds.CheckTabFeature)
{
return mstrCheckTabFeature;
}
else if (strAttributeName  ==  convFeatureRegionFlds.FeatureDescription)
{
return mstrFeatureDescription;
}
else if (strAttributeName  ==  convFeatureRegionFlds.ButtonName)
{
return mstrButtonName;
}
else if (strAttributeName  ==  convFeatureRegionFlds.ButtonName4Mvc)
{
return mstrButtonName4Mvc;
}
else if (strAttributeName  ==  convFeatureRegionFlds.EventFuncName)
{
return mstrEventFuncName;
}
else if (strAttributeName  ==  convFeatureRegionFlds.ValueGivingModeId)
{
return mstrValueGivingModeId;
}
else if (strAttributeName  ==  convFeatureRegionFlds.ValueGivingModeName)
{
return mstrValueGivingModeName;
}
else if (strAttributeName  ==  convFeatureRegionFlds.FuncName)
{
return mstrFuncName;
}
else if (strAttributeName  ==  convFeatureRegionFlds.DefaultValue)
{
return mstrDefaultValue;
}
else if (strAttributeName  ==  convFeatureRegionFlds.KeyIdGetModeId)
{
return mstrKeyIdGetModeId;
}
else if (strAttributeName  ==  convFeatureRegionFlds.Text)
{
return mstrText;
}
else if (strAttributeName  ==  convFeatureRegionFlds.GroupName)
{
return mstrGroupName;
}
else if (strAttributeName  ==  convFeatureRegionFlds.ReleTabId)
{
return mstrReleTabId;
}
else if (strAttributeName  ==  convFeatureRegionFlds.ReleFldId)
{
return mstrReleFldId;
}
else if (strAttributeName  ==  convFeatureRegionFlds.FieldTypeId)
{
return mstrFieldTypeId;
}
else if (strAttributeName  ==  convFeatureRegionFlds.FieldTypeName)
{
return mstrFieldTypeName;
}
else if (strAttributeName  ==  convFeatureRegionFlds.ViewImplId)
{
return mstrViewImplId;
}
else if (strAttributeName  ==  convFeatureRegionFlds.ViewImplName)
{
return mstrViewImplName;
}
else if (strAttributeName  ==  convFeatureRegionFlds.CtlTypeId)
{
return mstrCtlTypeId;
}
else if (strAttributeName  ==  convFeatureRegionFlds.CtlTypeName)
{
return mstrCtlTypeName;
}
else if (strAttributeName  ==  convFeatureRegionFlds.CtlCnName)
{
return mstrCtlCnName;
}
else if (strAttributeName  ==  convFeatureRegionFlds.CtlTypeAbbr)
{
return mstrCtlTypeAbbr;
}
else if (strAttributeName  ==  convFeatureRegionFlds.Height)
{
return mintHeight;
}
else if (strAttributeName  ==  convFeatureRegionFlds.Width)
{
return mintWidth;
}
else if (strAttributeName  ==  convFeatureRegionFlds.SeqNum)
{
return mintSeqNum;
}
else if (strAttributeName  ==  convFeatureRegionFlds.CssClass)
{
return mstrCssClass;
}
else if (strAttributeName  ==  convFeatureRegionFlds.ImageUrl)
{
return mstrImageUrl;
}
else if (strAttributeName  ==  convFeatureRegionFlds.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  convFeatureRegionFlds.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convFeatureRegionFlds.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convFeatureRegionFlds.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convFeatureRegionFlds.RelaFldName)
{
return mstrRelaFldName;
}
else if (strAttributeName  ==  convFeatureRegionFlds.RelaTabName)
{
return mstrRelaTabName;
}
else if (strAttributeName  ==  convFeatureRegionFlds.PrjId)
{
return mstrPrjId;
}
return null;
}
set
{
if (strAttributeName  ==  convFeatureRegionFlds.ViewFeatureId)
{
mstrViewFeatureId = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.ViewFeatureId);
}
else if (strAttributeName  ==  convFeatureRegionFlds.RegionId)
{
mstrRegionId = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.RegionId);
}
else if (strAttributeName  ==  convFeatureRegionFlds.RegionName)
{
mstrRegionName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.RegionName);
}
else if (strAttributeName  ==  convFeatureRegionFlds.RegionTypeId)
{
mstrRegionTypeId = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.RegionTypeId);
}
else if (strAttributeName  ==  convFeatureRegionFlds.RegionTypeName)
{
mstrRegionTypeName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.RegionTypeName);
}
else if (strAttributeName  ==  convFeatureRegionFlds.RegionTypeSimName)
{
mstrRegionTypeSimName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.RegionTypeSimName);
}
else if (strAttributeName  ==  convFeatureRegionFlds.FeatureId)
{
mstrFeatureId = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.FeatureId);
}
else if (strAttributeName  ==  convFeatureRegionFlds.FeatureName)
{
mstrFeatureName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.FeatureName);
}
else if (strAttributeName  ==  convFeatureRegionFlds.KeyWords)
{
mstrKeyWords = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.KeyWords);
}
else if (strAttributeName  ==  convFeatureRegionFlds.TabFeatureId)
{
mstrTabFeatureId = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.TabFeatureId);
}
else if (strAttributeName  ==  convFeatureRegionFlds.TabFeatureName)
{
mstrTabFeatureName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.TabFeatureName);
}
else if (strAttributeName  ==  convFeatureRegionFlds.CheckTabFeature)
{
mstrCheckTabFeature = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.CheckTabFeature);
}
else if (strAttributeName  ==  convFeatureRegionFlds.FeatureDescription)
{
mstrFeatureDescription = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.FeatureDescription);
}
else if (strAttributeName  ==  convFeatureRegionFlds.ButtonName)
{
mstrButtonName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.ButtonName);
}
else if (strAttributeName  ==  convFeatureRegionFlds.ButtonName4Mvc)
{
mstrButtonName4Mvc = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.ButtonName4Mvc);
}
else if (strAttributeName  ==  convFeatureRegionFlds.EventFuncName)
{
mstrEventFuncName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.EventFuncName);
}
else if (strAttributeName  ==  convFeatureRegionFlds.ValueGivingModeId)
{
mstrValueGivingModeId = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.ValueGivingModeId);
}
else if (strAttributeName  ==  convFeatureRegionFlds.ValueGivingModeName)
{
mstrValueGivingModeName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.ValueGivingModeName);
}
else if (strAttributeName  ==  convFeatureRegionFlds.FuncName)
{
mstrFuncName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.FuncName);
}
else if (strAttributeName  ==  convFeatureRegionFlds.DefaultValue)
{
mstrDefaultValue = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.DefaultValue);
}
else if (strAttributeName  ==  convFeatureRegionFlds.KeyIdGetModeId)
{
mstrKeyIdGetModeId = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.KeyIdGetModeId);
}
else if (strAttributeName  ==  convFeatureRegionFlds.Text)
{
mstrText = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.Text);
}
else if (strAttributeName  ==  convFeatureRegionFlds.GroupName)
{
mstrGroupName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.GroupName);
}
else if (strAttributeName  ==  convFeatureRegionFlds.ReleTabId)
{
mstrReleTabId = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.ReleTabId);
}
else if (strAttributeName  ==  convFeatureRegionFlds.ReleFldId)
{
mstrReleFldId = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.ReleFldId);
}
else if (strAttributeName  ==  convFeatureRegionFlds.FieldTypeId)
{
mstrFieldTypeId = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.FieldTypeId);
}
else if (strAttributeName  ==  convFeatureRegionFlds.FieldTypeName)
{
mstrFieldTypeName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.FieldTypeName);
}
else if (strAttributeName  ==  convFeatureRegionFlds.ViewImplId)
{
mstrViewImplId = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.ViewImplId);
}
else if (strAttributeName  ==  convFeatureRegionFlds.ViewImplName)
{
mstrViewImplName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.ViewImplName);
}
else if (strAttributeName  ==  convFeatureRegionFlds.CtlTypeId)
{
mstrCtlTypeId = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.CtlTypeId);
}
else if (strAttributeName  ==  convFeatureRegionFlds.CtlTypeName)
{
mstrCtlTypeName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.CtlTypeName);
}
else if (strAttributeName  ==  convFeatureRegionFlds.CtlCnName)
{
mstrCtlCnName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.CtlCnName);
}
else if (strAttributeName  ==  convFeatureRegionFlds.CtlTypeAbbr)
{
mstrCtlTypeAbbr = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.CtlTypeAbbr);
}
else if (strAttributeName  ==  convFeatureRegionFlds.Height)
{
mintHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(convFeatureRegionFlds.Height);
}
else if (strAttributeName  ==  convFeatureRegionFlds.Width)
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(convFeatureRegionFlds.Width);
}
else if (strAttributeName  ==  convFeatureRegionFlds.SeqNum)
{
mintSeqNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFeatureRegionFlds.SeqNum);
}
else if (strAttributeName  ==  convFeatureRegionFlds.CssClass)
{
mstrCssClass = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.CssClass);
}
else if (strAttributeName  ==  convFeatureRegionFlds.ImageUrl)
{
mstrImageUrl = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.ImageUrl);
}
else if (strAttributeName  ==  convFeatureRegionFlds.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convFeatureRegionFlds.InUse);
}
else if (strAttributeName  ==  convFeatureRegionFlds.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.UpdUser);
}
else if (strAttributeName  ==  convFeatureRegionFlds.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.UpdDate);
}
else if (strAttributeName  ==  convFeatureRegionFlds.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.Memo);
}
else if (strAttributeName  ==  convFeatureRegionFlds.RelaFldName)
{
mstrRelaFldName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.RelaFldName);
}
else if (strAttributeName  ==  convFeatureRegionFlds.RelaTabName)
{
mstrRelaTabName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.RelaTabName);
}
else if (strAttributeName  ==  convFeatureRegionFlds.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.PrjId);
}
}
}
public object this[int intIndex]
{
get
{
if (convFeatureRegionFlds.ViewFeatureId  ==  AttributeName[intIndex])
{
return mstrViewFeatureId;
}
else if (convFeatureRegionFlds.RegionId  ==  AttributeName[intIndex])
{
return mstrRegionId;
}
else if (convFeatureRegionFlds.RegionName  ==  AttributeName[intIndex])
{
return mstrRegionName;
}
else if (convFeatureRegionFlds.RegionTypeId  ==  AttributeName[intIndex])
{
return mstrRegionTypeId;
}
else if (convFeatureRegionFlds.RegionTypeName  ==  AttributeName[intIndex])
{
return mstrRegionTypeName;
}
else if (convFeatureRegionFlds.RegionTypeSimName  ==  AttributeName[intIndex])
{
return mstrRegionTypeSimName;
}
else if (convFeatureRegionFlds.FeatureId  ==  AttributeName[intIndex])
{
return mstrFeatureId;
}
else if (convFeatureRegionFlds.FeatureName  ==  AttributeName[intIndex])
{
return mstrFeatureName;
}
else if (convFeatureRegionFlds.KeyWords  ==  AttributeName[intIndex])
{
return mstrKeyWords;
}
else if (convFeatureRegionFlds.TabFeatureId  ==  AttributeName[intIndex])
{
return mstrTabFeatureId;
}
else if (convFeatureRegionFlds.TabFeatureName  ==  AttributeName[intIndex])
{
return mstrTabFeatureName;
}
else if (convFeatureRegionFlds.CheckTabFeature  ==  AttributeName[intIndex])
{
return mstrCheckTabFeature;
}
else if (convFeatureRegionFlds.FeatureDescription  ==  AttributeName[intIndex])
{
return mstrFeatureDescription;
}
else if (convFeatureRegionFlds.ButtonName  ==  AttributeName[intIndex])
{
return mstrButtonName;
}
else if (convFeatureRegionFlds.ButtonName4Mvc  ==  AttributeName[intIndex])
{
return mstrButtonName4Mvc;
}
else if (convFeatureRegionFlds.EventFuncName  ==  AttributeName[intIndex])
{
return mstrEventFuncName;
}
else if (convFeatureRegionFlds.ValueGivingModeId  ==  AttributeName[intIndex])
{
return mstrValueGivingModeId;
}
else if (convFeatureRegionFlds.ValueGivingModeName  ==  AttributeName[intIndex])
{
return mstrValueGivingModeName;
}
else if (convFeatureRegionFlds.FuncName  ==  AttributeName[intIndex])
{
return mstrFuncName;
}
else if (convFeatureRegionFlds.DefaultValue  ==  AttributeName[intIndex])
{
return mstrDefaultValue;
}
else if (convFeatureRegionFlds.KeyIdGetModeId  ==  AttributeName[intIndex])
{
return mstrKeyIdGetModeId;
}
else if (convFeatureRegionFlds.Text  ==  AttributeName[intIndex])
{
return mstrText;
}
else if (convFeatureRegionFlds.GroupName  ==  AttributeName[intIndex])
{
return mstrGroupName;
}
else if (convFeatureRegionFlds.ReleTabId  ==  AttributeName[intIndex])
{
return mstrReleTabId;
}
else if (convFeatureRegionFlds.ReleFldId  ==  AttributeName[intIndex])
{
return mstrReleFldId;
}
else if (convFeatureRegionFlds.FieldTypeId  ==  AttributeName[intIndex])
{
return mstrFieldTypeId;
}
else if (convFeatureRegionFlds.FieldTypeName  ==  AttributeName[intIndex])
{
return mstrFieldTypeName;
}
else if (convFeatureRegionFlds.ViewImplId  ==  AttributeName[intIndex])
{
return mstrViewImplId;
}
else if (convFeatureRegionFlds.ViewImplName  ==  AttributeName[intIndex])
{
return mstrViewImplName;
}
else if (convFeatureRegionFlds.CtlTypeId  ==  AttributeName[intIndex])
{
return mstrCtlTypeId;
}
else if (convFeatureRegionFlds.CtlTypeName  ==  AttributeName[intIndex])
{
return mstrCtlTypeName;
}
else if (convFeatureRegionFlds.CtlCnName  ==  AttributeName[intIndex])
{
return mstrCtlCnName;
}
else if (convFeatureRegionFlds.CtlTypeAbbr  ==  AttributeName[intIndex])
{
return mstrCtlTypeAbbr;
}
else if (convFeatureRegionFlds.Height  ==  AttributeName[intIndex])
{
return mintHeight;
}
else if (convFeatureRegionFlds.Width  ==  AttributeName[intIndex])
{
return mintWidth;
}
else if (convFeatureRegionFlds.SeqNum  ==  AttributeName[intIndex])
{
return mintSeqNum;
}
else if (convFeatureRegionFlds.CssClass  ==  AttributeName[intIndex])
{
return mstrCssClass;
}
else if (convFeatureRegionFlds.ImageUrl  ==  AttributeName[intIndex])
{
return mstrImageUrl;
}
else if (convFeatureRegionFlds.InUse  ==  AttributeName[intIndex])
{
return mbolInUse;
}
else if (convFeatureRegionFlds.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convFeatureRegionFlds.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convFeatureRegionFlds.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convFeatureRegionFlds.RelaFldName  ==  AttributeName[intIndex])
{
return mstrRelaFldName;
}
else if (convFeatureRegionFlds.RelaTabName  ==  AttributeName[intIndex])
{
return mstrRelaTabName;
}
else if (convFeatureRegionFlds.PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
return null;
}
set
{
if (convFeatureRegionFlds.ViewFeatureId  ==  AttributeName[intIndex])
{
mstrViewFeatureId = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.ViewFeatureId);
}
else if (convFeatureRegionFlds.RegionId  ==  AttributeName[intIndex])
{
mstrRegionId = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.RegionId);
}
else if (convFeatureRegionFlds.RegionName  ==  AttributeName[intIndex])
{
mstrRegionName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.RegionName);
}
else if (convFeatureRegionFlds.RegionTypeId  ==  AttributeName[intIndex])
{
mstrRegionTypeId = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.RegionTypeId);
}
else if (convFeatureRegionFlds.RegionTypeName  ==  AttributeName[intIndex])
{
mstrRegionTypeName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.RegionTypeName);
}
else if (convFeatureRegionFlds.RegionTypeSimName  ==  AttributeName[intIndex])
{
mstrRegionTypeSimName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.RegionTypeSimName);
}
else if (convFeatureRegionFlds.FeatureId  ==  AttributeName[intIndex])
{
mstrFeatureId = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.FeatureId);
}
else if (convFeatureRegionFlds.FeatureName  ==  AttributeName[intIndex])
{
mstrFeatureName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.FeatureName);
}
else if (convFeatureRegionFlds.KeyWords  ==  AttributeName[intIndex])
{
mstrKeyWords = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.KeyWords);
}
else if (convFeatureRegionFlds.TabFeatureId  ==  AttributeName[intIndex])
{
mstrTabFeatureId = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.TabFeatureId);
}
else if (convFeatureRegionFlds.TabFeatureName  ==  AttributeName[intIndex])
{
mstrTabFeatureName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.TabFeatureName);
}
else if (convFeatureRegionFlds.CheckTabFeature  ==  AttributeName[intIndex])
{
mstrCheckTabFeature = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.CheckTabFeature);
}
else if (convFeatureRegionFlds.FeatureDescription  ==  AttributeName[intIndex])
{
mstrFeatureDescription = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.FeatureDescription);
}
else if (convFeatureRegionFlds.ButtonName  ==  AttributeName[intIndex])
{
mstrButtonName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.ButtonName);
}
else if (convFeatureRegionFlds.ButtonName4Mvc  ==  AttributeName[intIndex])
{
mstrButtonName4Mvc = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.ButtonName4Mvc);
}
else if (convFeatureRegionFlds.EventFuncName  ==  AttributeName[intIndex])
{
mstrEventFuncName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.EventFuncName);
}
else if (convFeatureRegionFlds.ValueGivingModeId  ==  AttributeName[intIndex])
{
mstrValueGivingModeId = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.ValueGivingModeId);
}
else if (convFeatureRegionFlds.ValueGivingModeName  ==  AttributeName[intIndex])
{
mstrValueGivingModeName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.ValueGivingModeName);
}
else if (convFeatureRegionFlds.FuncName  ==  AttributeName[intIndex])
{
mstrFuncName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.FuncName);
}
else if (convFeatureRegionFlds.DefaultValue  ==  AttributeName[intIndex])
{
mstrDefaultValue = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.DefaultValue);
}
else if (convFeatureRegionFlds.KeyIdGetModeId  ==  AttributeName[intIndex])
{
mstrKeyIdGetModeId = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.KeyIdGetModeId);
}
else if (convFeatureRegionFlds.Text  ==  AttributeName[intIndex])
{
mstrText = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.Text);
}
else if (convFeatureRegionFlds.GroupName  ==  AttributeName[intIndex])
{
mstrGroupName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.GroupName);
}
else if (convFeatureRegionFlds.ReleTabId  ==  AttributeName[intIndex])
{
mstrReleTabId = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.ReleTabId);
}
else if (convFeatureRegionFlds.ReleFldId  ==  AttributeName[intIndex])
{
mstrReleFldId = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.ReleFldId);
}
else if (convFeatureRegionFlds.FieldTypeId  ==  AttributeName[intIndex])
{
mstrFieldTypeId = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.FieldTypeId);
}
else if (convFeatureRegionFlds.FieldTypeName  ==  AttributeName[intIndex])
{
mstrFieldTypeName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.FieldTypeName);
}
else if (convFeatureRegionFlds.ViewImplId  ==  AttributeName[intIndex])
{
mstrViewImplId = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.ViewImplId);
}
else if (convFeatureRegionFlds.ViewImplName  ==  AttributeName[intIndex])
{
mstrViewImplName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.ViewImplName);
}
else if (convFeatureRegionFlds.CtlTypeId  ==  AttributeName[intIndex])
{
mstrCtlTypeId = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.CtlTypeId);
}
else if (convFeatureRegionFlds.CtlTypeName  ==  AttributeName[intIndex])
{
mstrCtlTypeName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.CtlTypeName);
}
else if (convFeatureRegionFlds.CtlCnName  ==  AttributeName[intIndex])
{
mstrCtlCnName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.CtlCnName);
}
else if (convFeatureRegionFlds.CtlTypeAbbr  ==  AttributeName[intIndex])
{
mstrCtlTypeAbbr = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.CtlTypeAbbr);
}
else if (convFeatureRegionFlds.Height  ==  AttributeName[intIndex])
{
mintHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(convFeatureRegionFlds.Height);
}
else if (convFeatureRegionFlds.Width  ==  AttributeName[intIndex])
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(convFeatureRegionFlds.Width);
}
else if (convFeatureRegionFlds.SeqNum  ==  AttributeName[intIndex])
{
mintSeqNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFeatureRegionFlds.SeqNum);
}
else if (convFeatureRegionFlds.CssClass  ==  AttributeName[intIndex])
{
mstrCssClass = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.CssClass);
}
else if (convFeatureRegionFlds.ImageUrl  ==  AttributeName[intIndex])
{
mstrImageUrl = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.ImageUrl);
}
else if (convFeatureRegionFlds.InUse  ==  AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convFeatureRegionFlds.InUse);
}
else if (convFeatureRegionFlds.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.UpdUser);
}
else if (convFeatureRegionFlds.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.UpdDate);
}
else if (convFeatureRegionFlds.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.Memo);
}
else if (convFeatureRegionFlds.RelaFldName  ==  AttributeName[intIndex])
{
mstrRelaFldName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.RelaFldName);
}
else if (convFeatureRegionFlds.RelaTabName  ==  AttributeName[intIndex])
{
mstrRelaTabName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.RelaTabName);
}
else if (convFeatureRegionFlds.PrjId  ==  AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds.PrjId);
}
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
 AddUpdatedFld(convFeatureRegionFlds.ViewFeatureId);
}
}
/// <summary>
/// 区域Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RegionId
{
get
{
return mstrRegionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRegionId = value;
}
else
{
 mstrRegionId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureRegionFlds.RegionId);
}
}
/// <summary>
/// 区域名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RegionName
{
get
{
return mstrRegionName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRegionName = value;
}
else
{
 mstrRegionName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureRegionFlds.RegionName);
}
}
/// <summary>
/// 区域类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RegionTypeId
{
get
{
return mstrRegionTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRegionTypeId = value;
}
else
{
 mstrRegionTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureRegionFlds.RegionTypeId);
}
}
/// <summary>
/// 区域类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RegionTypeName
{
get
{
return mstrRegionTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRegionTypeName = value;
}
else
{
 mstrRegionTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureRegionFlds.RegionTypeName);
}
}
/// <summary>
/// 区域类型简名(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RegionTypeSimName
{
get
{
return mstrRegionTypeSimName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRegionTypeSimName = value;
}
else
{
 mstrRegionTypeSimName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureRegionFlds.RegionTypeSimName);
}
}
/// <summary>
/// 功能Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FeatureId
{
get
{
return mstrFeatureId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFeatureId = value;
}
else
{
 mstrFeatureId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureRegionFlds.FeatureId);
}
}
/// <summary>
/// 功能名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FeatureName
{
get
{
return mstrFeatureName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFeatureName = value;
}
else
{
 mstrFeatureName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureRegionFlds.FeatureName);
}
}
/// <summary>
/// 关键字(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KeyWords
{
get
{
return mstrKeyWords;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeyWords = value;
}
else
{
 mstrKeyWords = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureRegionFlds.KeyWords);
}
}
/// <summary>
/// 表功能Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabFeatureId
{
get
{
return mstrTabFeatureId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabFeatureId = value;
}
else
{
 mstrTabFeatureId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureRegionFlds.TabFeatureId);
}
}
/// <summary>
/// 表功能名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabFeatureName
{
get
{
return mstrTabFeatureName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabFeatureName = value;
}
else
{
 mstrTabFeatureName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureRegionFlds.TabFeatureName);
}
}
/// <summary>
/// 检查表功能(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CheckTabFeature
{
get
{
return mstrCheckTabFeature;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCheckTabFeature = value;
}
else
{
 mstrCheckTabFeature = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureRegionFlds.CheckTabFeature);
}
}
/// <summary>
/// 功能说明(说明:;字段类型:varchar;字段长度:4000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FeatureDescription
{
get
{
return mstrFeatureDescription;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFeatureDescription = value;
}
else
{
 mstrFeatureDescription = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureRegionFlds.FeatureDescription);
}
}
/// <summary>
/// 按钮名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ButtonName
{
get
{
return mstrButtonName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrButtonName = value;
}
else
{
 mstrButtonName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureRegionFlds.ButtonName);
}
}
/// <summary>
/// 按钮名称4Mvc(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ButtonName4Mvc
{
get
{
return mstrButtonName4Mvc;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrButtonName4Mvc = value;
}
else
{
 mstrButtonName4Mvc = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureRegionFlds.ButtonName4Mvc);
}
}
/// <summary>
/// 事件函数名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EventFuncName
{
get
{
return mstrEventFuncName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEventFuncName = value;
}
else
{
 mstrEventFuncName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureRegionFlds.EventFuncName);
}
}
/// <summary>
/// 给值方式Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ValueGivingModeId
{
get
{
return mstrValueGivingModeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrValueGivingModeId = value;
}
else
{
 mstrValueGivingModeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureRegionFlds.ValueGivingModeId);
}
}
/// <summary>
/// 给值方式名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ValueGivingModeName
{
get
{
return mstrValueGivingModeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrValueGivingModeName = value;
}
else
{
 mstrValueGivingModeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureRegionFlds.ValueGivingModeName);
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
 AddUpdatedFld(convFeatureRegionFlds.FuncName);
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
 AddUpdatedFld(convFeatureRegionFlds.DefaultValue);
}
}
/// <summary>
/// GC关键字获取方式Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KeyIdGetModeId
{
get
{
return mstrKeyIdGetModeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeyIdGetModeId = value;
}
else
{
 mstrKeyIdGetModeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureRegionFlds.KeyIdGetModeId);
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
 AddUpdatedFld(convFeatureRegionFlds.Text);
}
}
/// <summary>
/// 组名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
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
mintErrNo = 1;
 mstrGroupName = value;
}
else
{
 mstrGroupName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureRegionFlds.GroupName);
}
}
/// <summary>
/// 相关表Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ReleTabId
{
get
{
return mstrReleTabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrReleTabId = value;
}
else
{
 mstrReleTabId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureRegionFlds.ReleTabId);
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
 AddUpdatedFld(convFeatureRegionFlds.ReleFldId);
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
 AddUpdatedFld(convFeatureRegionFlds.FieldTypeId);
}
}
/// <summary>
/// 字段类型名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FieldTypeName
{
get
{
return mstrFieldTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFieldTypeName = value;
}
else
{
 mstrFieldTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureRegionFlds.FieldTypeName);
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
 AddUpdatedFld(convFeatureRegionFlds.ViewImplId);
}
}
/// <summary>
/// 界面实现名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewImplName
{
get
{
return mstrViewImplName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewImplName = value;
}
else
{
 mstrViewImplName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureRegionFlds.ViewImplName);
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
 AddUpdatedFld(convFeatureRegionFlds.CtlTypeId);
}
}
/// <summary>
/// 控件类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CtlTypeName
{
get
{
return mstrCtlTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCtlTypeName = value;
}
else
{
 mstrCtlTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureRegionFlds.CtlTypeName);
}
}
/// <summary>
/// 控件类型中文名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CtlCnName
{
get
{
return mstrCtlCnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCtlCnName = value;
}
else
{
 mstrCtlCnName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureRegionFlds.CtlCnName);
}
}
/// <summary>
/// 控件类型缩写(说明:;字段类型:varchar;字段长度:5;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CtlTypeAbbr
{
get
{
return mstrCtlTypeAbbr;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCtlTypeAbbr = value;
}
else
{
 mstrCtlTypeAbbr = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureRegionFlds.CtlTypeAbbr);
}
}
/// <summary>
/// 高度(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? Height
{
get
{
return mintHeight;
}
set
{
 mintHeight = value;
//记录修改过的字段
 AddUpdatedFld(convFeatureRegionFlds.Height);
}
}
/// <summary>
/// 宽(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? Width
{
get
{
return mintWidth;
}
set
{
 mintWidth = value;
//记录修改过的字段
 AddUpdatedFld(convFeatureRegionFlds.Width);
}
}
/// <summary>
/// 字段序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? SeqNum
{
get
{
return mintSeqNum;
}
set
{
 mintSeqNum = value;
//记录修改过的字段
 AddUpdatedFld(convFeatureRegionFlds.SeqNum);
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
 AddUpdatedFld(convFeatureRegionFlds.CssClass);
}
}
/// <summary>
/// 图片资源(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ImageUrl
{
get
{
return mstrImageUrl;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrImageUrl = value;
}
else
{
 mstrImageUrl = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureRegionFlds.ImageUrl);
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
 AddUpdatedFld(convFeatureRegionFlds.InUse);
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
 AddUpdatedFld(convFeatureRegionFlds.UpdUser);
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
 AddUpdatedFld(convFeatureRegionFlds.UpdDate);
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
 AddUpdatedFld(convFeatureRegionFlds.Memo);
}
}
/// <summary>
/// 关系字段名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RelaFldName
{
get
{
return mstrRelaFldName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRelaFldName = value;
}
else
{
 mstrRelaFldName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureRegionFlds.RelaFldName);
}
}
/// <summary>
/// 相关表名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RelaTabName
{
get
{
return mstrRelaTabName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRelaTabName = value;
}
else
{
 mstrRelaTabName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureRegionFlds.RelaTabName);
}
}
/// <summary>
/// 工程ID(说明:;字段类型:char;字段长度:4;是否可空:False)
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
 AddUpdatedFld(convFeatureRegionFlds.PrjId);
}
}

/// <summary>
/// 获取关键字Id(keyId)
 /// (AutoGCLib.clsGeneCodeBase:GenGetKeyId)
/// </summary>
 public override string _KeyId
 {
 get
 {
  return mstrViewFeatureId;
 }
 }
}
 /// <summary>
 /// v功能区域字段(vFeatureRegionFlds)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convFeatureRegionFlds
{
public const string _CurrTabName = "vFeatureRegionFlds"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ViewFeatureId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ViewFeatureId", "RegionId", "RegionName", "RegionTypeId", "RegionTypeName", "RegionTypeSimName", "FeatureId", "FeatureName", "KeyWords", "TabFeatureId", "TabFeatureName", "CheckTabFeature", "FeatureDescription", "ButtonName", "ButtonName4Mvc", "EventFuncName", "ValueGivingModeId", "ValueGivingModeName", "FuncName", "DefaultValue", "KeyIdGetModeId", "Text", "GroupName", "ReleTabId", "ReleFldId", "FieldTypeId", "FieldTypeName", "ViewImplId", "ViewImplName", "CtlTypeId", "CtlTypeName", "CtlCnName", "CtlTypeAbbr", "Height", "Width", "SeqNum", "CssClass", "ImageUrl", "InUse", "UpdUser", "UpdDate", "Memo", "RelaFldName", "RelaTabName", "PrjId"};
//以下是属性变量


 /// <summary>
 /// 常量:"ViewFeatureId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewFeatureId = "ViewFeatureId";    //界面功能Id

 /// <summary>
 /// 常量:"RegionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RegionId = "RegionId";    //区域Id

 /// <summary>
 /// 常量:"RegionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RegionName = "RegionName";    //区域名称

 /// <summary>
 /// 常量:"RegionTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RegionTypeId = "RegionTypeId";    //区域类型Id

 /// <summary>
 /// 常量:"RegionTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RegionTypeName = "RegionTypeName";    //区域类型名称

 /// <summary>
 /// 常量:"RegionTypeSimName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RegionTypeSimName = "RegionTypeSimName";    //区域类型简名

 /// <summary>
 /// 常量:"FeatureId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeatureId = "FeatureId";    //功能Id

 /// <summary>
 /// 常量:"FeatureName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeatureName = "FeatureName";    //功能名称

 /// <summary>
 /// 常量:"KeyWords"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KeyWords = "KeyWords";    //关键字

 /// <summary>
 /// 常量:"TabFeatureId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabFeatureId = "TabFeatureId";    //表功能Id

 /// <summary>
 /// 常量:"TabFeatureName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabFeatureName = "TabFeatureName";    //表功能名

 /// <summary>
 /// 常量:"CheckTabFeature"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CheckTabFeature = "CheckTabFeature";    //检查表功能

 /// <summary>
 /// 常量:"FeatureDescription"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeatureDescription = "FeatureDescription";    //功能说明

 /// <summary>
 /// 常量:"ButtonName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ButtonName = "ButtonName";    //按钮名称

 /// <summary>
 /// 常量:"ButtonName4Mvc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ButtonName4Mvc = "ButtonName4Mvc";    //按钮名称4Mvc

 /// <summary>
 /// 常量:"EventFuncName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EventFuncName = "EventFuncName";    //事件函数名

 /// <summary>
 /// 常量:"ValueGivingModeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ValueGivingModeId = "ValueGivingModeId";    //给值方式Id

 /// <summary>
 /// 常量:"ValueGivingModeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ValueGivingModeName = "ValueGivingModeName";    //给值方式名

 /// <summary>
 /// 常量:"FuncName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncName = "FuncName";    //函数名

 /// <summary>
 /// 常量:"DefaultValue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DefaultValue = "DefaultValue";    //缺省值

 /// <summary>
 /// 常量:"KeyIdGetModeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KeyIdGetModeId = "KeyIdGetModeId";    //GC关键字获取方式Id

 /// <summary>
 /// 常量:"Text"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Text = "Text";    //文本

 /// <summary>
 /// 常量:"GroupName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GroupName = "GroupName";    //组名

 /// <summary>
 /// 常量:"ReleTabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReleTabId = "ReleTabId";    //相关表Id

 /// <summary>
 /// 常量:"ReleFldId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReleFldId = "ReleFldId";    //相关字段Id

 /// <summary>
 /// 常量:"FieldTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FieldTypeId = "FieldTypeId";    //字段类型Id

 /// <summary>
 /// 常量:"FieldTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FieldTypeName = "FieldTypeName";    //字段类型名

 /// <summary>
 /// 常量:"ViewImplId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewImplId = "ViewImplId";    //界面实现Id

 /// <summary>
 /// 常量:"ViewImplName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewImplName = "ViewImplName";    //界面实现名

 /// <summary>
 /// 常量:"CtlTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CtlTypeId = "CtlTypeId";    //控件类型号

 /// <summary>
 /// 常量:"CtlTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CtlTypeName = "CtlTypeName";    //控件类型名

 /// <summary>
 /// 常量:"CtlCnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CtlCnName = "CtlCnName";    //控件类型中文名

 /// <summary>
 /// 常量:"CtlTypeAbbr"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CtlTypeAbbr = "CtlTypeAbbr";    //控件类型缩写

 /// <summary>
 /// 常量:"Height"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Height = "Height";    //高度

 /// <summary>
 /// 常量:"Width"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Width = "Width";    //宽

 /// <summary>
 /// 常量:"SeqNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SeqNum = "SeqNum";    //字段序号

 /// <summary>
 /// 常量:"CssClass"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CssClass = "CssClass";    //样式表

 /// <summary>
 /// 常量:"ImageUrl"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ImageUrl = "ImageUrl";    //图片资源

 /// <summary>
 /// 常量:"InUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InUse = "InUse";    //是否在用

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
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明

 /// <summary>
 /// 常量:"RelaFldName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RelaFldName = "RelaFldName";    //关系字段名

 /// <summary>
 /// 常量:"RelaTabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RelaTabName = "RelaTabName";    //相关表名

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程ID
}

}