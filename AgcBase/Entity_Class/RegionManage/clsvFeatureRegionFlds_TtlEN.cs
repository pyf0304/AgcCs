
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFeatureRegionFlds_TtlEN
 表名:vFeatureRegionFlds_Ttl(00050474)
 * 版本:2024.01.24.1(服务器:WIN-SRV103-116)
 日期:2024/01/26 14:38:43
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
 /// 表vFeatureRegionFlds_Ttl的关键字(ViewFeatureId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ViewFeatureId_vFeatureRegionFlds_Ttl
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
public K_ViewFeatureId_vFeatureRegionFlds_Ttl(string strViewFeatureId)
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
 /// <returns>返回:[K_ViewFeatureId_vFeatureRegionFlds_Ttl]类型的对象</returns>
public static implicit operator K_ViewFeatureId_vFeatureRegionFlds_Ttl(string value)
{
return new K_ViewFeatureId_vFeatureRegionFlds_Ttl(value);
}
}
 /// <summary>
 /// v功能区域字段_Ttl(vFeatureRegionFlds_Ttl)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvFeatureRegionFlds_TtlEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vFeatureRegionFlds_Ttl"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ViewFeatureId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 44;
public static string[] AttributeName = new string[] {"ViewFeatureId", "RegionId", "RegionName", "RegionTypeId", "RegionTypeName", "FeatureId", "FeatureName", "KeyWords", "TabFeatureId", "TabFeatureName", "CheckTabFeature", "FeatureDescription", "ButtonName", "ButtonName4Mvc", "EventFuncName", "ValueGivingModeId", "ValueGivingModeName", "FuncName", "DefaultValue", "Text", "GroupName", "ReleTabId", "ReleFldId", "FieldTypeId", "FieldTypeName", "ViewImplId", "ViewImplName", "CtlTypeId", "CtlTypeName", "CtlCnName", "CtlTypeAbbr", "Height", "Width", "SeqNum", "CssClass", "ImageUrl", "InUse", "UpdUser", "UpdDate", "Memo", "FldNum", "RelaFldName", "RelaTabName", "PrjId"};

protected string mstrViewFeatureId;    //界面功能Id
protected string mstrRegionId;    //区域Id
protected string mstrRegionName;    //区域名称
protected string mstrRegionTypeId;    //区域类型Id
protected string mstrRegionTypeName;    //区域类型名称
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
protected int? mintFldNum;    //字段数
protected string mstrRelaFldName;    //关系字段名
protected string mstrRelaTabName;    //相关表名
protected string mstrPrjId;    //工程ID

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvFeatureRegionFlds_TtlEN()
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
public clsvFeatureRegionFlds_TtlEN(string strViewFeatureId)
 {
strViewFeatureId = strViewFeatureId.Replace("'", "''");
if (strViewFeatureId.Length > 8)
{
throw new Exception("在表:vFeatureRegionFlds_Ttl中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strViewFeatureId)  ==  true)
{
throw new Exception("在表:vFeatureRegionFlds_Ttl中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convFeatureRegionFlds_Ttl.ViewFeatureId)
{
return mstrViewFeatureId;
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.RegionId)
{
return mstrRegionId;
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.RegionName)
{
return mstrRegionName;
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.RegionTypeId)
{
return mstrRegionTypeId;
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.RegionTypeName)
{
return mstrRegionTypeName;
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.FeatureId)
{
return mstrFeatureId;
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.FeatureName)
{
return mstrFeatureName;
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.KeyWords)
{
return mstrKeyWords;
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.TabFeatureId)
{
return mstrTabFeatureId;
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.TabFeatureName)
{
return mstrTabFeatureName;
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.CheckTabFeature)
{
return mstrCheckTabFeature;
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.FeatureDescription)
{
return mstrFeatureDescription;
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.ButtonName)
{
return mstrButtonName;
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.ButtonName4Mvc)
{
return mstrButtonName4Mvc;
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.EventFuncName)
{
return mstrEventFuncName;
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.ValueGivingModeId)
{
return mstrValueGivingModeId;
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.ValueGivingModeName)
{
return mstrValueGivingModeName;
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.FuncName)
{
return mstrFuncName;
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.DefaultValue)
{
return mstrDefaultValue;
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.Text)
{
return mstrText;
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.GroupName)
{
return mstrGroupName;
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.ReleTabId)
{
return mstrReleTabId;
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.ReleFldId)
{
return mstrReleFldId;
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.FieldTypeId)
{
return mstrFieldTypeId;
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.FieldTypeName)
{
return mstrFieldTypeName;
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.ViewImplId)
{
return mstrViewImplId;
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.ViewImplName)
{
return mstrViewImplName;
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.CtlTypeId)
{
return mstrCtlTypeId;
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.CtlTypeName)
{
return mstrCtlTypeName;
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.CtlCnName)
{
return mstrCtlCnName;
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.CtlTypeAbbr)
{
return mstrCtlTypeAbbr;
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.Height)
{
return mintHeight;
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.Width)
{
return mintWidth;
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.SeqNum)
{
return mintSeqNum;
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.CssClass)
{
return mstrCssClass;
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.ImageUrl)
{
return mstrImageUrl;
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.FldNum)
{
return mintFldNum;
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.RelaFldName)
{
return mstrRelaFldName;
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.RelaTabName)
{
return mstrRelaTabName;
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.PrjId)
{
return mstrPrjId;
}
return null;
}
set
{
if (strAttributeName  ==  convFeatureRegionFlds_Ttl.ViewFeatureId)
{
mstrViewFeatureId = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.ViewFeatureId);
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.RegionId)
{
mstrRegionId = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.RegionId);
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.RegionName)
{
mstrRegionName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.RegionName);
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.RegionTypeId)
{
mstrRegionTypeId = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.RegionTypeId);
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.RegionTypeName)
{
mstrRegionTypeName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.RegionTypeName);
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.FeatureId)
{
mstrFeatureId = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.FeatureId);
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.FeatureName)
{
mstrFeatureName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.FeatureName);
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.KeyWords)
{
mstrKeyWords = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.KeyWords);
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.TabFeatureId)
{
mstrTabFeatureId = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.TabFeatureId);
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.TabFeatureName)
{
mstrTabFeatureName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.TabFeatureName);
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.CheckTabFeature)
{
mstrCheckTabFeature = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.CheckTabFeature);
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.FeatureDescription)
{
mstrFeatureDescription = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.FeatureDescription);
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.ButtonName)
{
mstrButtonName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.ButtonName);
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.ButtonName4Mvc)
{
mstrButtonName4Mvc = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.ButtonName4Mvc);
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.EventFuncName)
{
mstrEventFuncName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.EventFuncName);
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.ValueGivingModeId)
{
mstrValueGivingModeId = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.ValueGivingModeId);
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.ValueGivingModeName)
{
mstrValueGivingModeName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.ValueGivingModeName);
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.FuncName)
{
mstrFuncName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.FuncName);
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.DefaultValue)
{
mstrDefaultValue = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.DefaultValue);
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.Text)
{
mstrText = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.Text);
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.GroupName)
{
mstrGroupName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.GroupName);
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.ReleTabId)
{
mstrReleTabId = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.ReleTabId);
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.ReleFldId)
{
mstrReleFldId = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.ReleFldId);
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.FieldTypeId)
{
mstrFieldTypeId = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.FieldTypeId);
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.FieldTypeName)
{
mstrFieldTypeName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.FieldTypeName);
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.ViewImplId)
{
mstrViewImplId = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.ViewImplId);
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.ViewImplName)
{
mstrViewImplName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.ViewImplName);
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.CtlTypeId)
{
mstrCtlTypeId = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.CtlTypeId);
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.CtlTypeName)
{
mstrCtlTypeName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.CtlTypeName);
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.CtlCnName)
{
mstrCtlCnName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.CtlCnName);
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.CtlTypeAbbr)
{
mstrCtlTypeAbbr = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.CtlTypeAbbr);
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.Height)
{
mintHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(convFeatureRegionFlds_Ttl.Height);
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.Width)
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(convFeatureRegionFlds_Ttl.Width);
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.SeqNum)
{
mintSeqNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFeatureRegionFlds_Ttl.SeqNum);
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.CssClass)
{
mstrCssClass = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.CssClass);
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.ImageUrl)
{
mstrImageUrl = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.ImageUrl);
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convFeatureRegionFlds_Ttl.InUse);
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.UpdUser);
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.UpdDate);
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.Memo);
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.FldNum)
{
mintFldNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFeatureRegionFlds_Ttl.FldNum);
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.RelaFldName)
{
mstrRelaFldName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.RelaFldName);
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.RelaTabName)
{
mstrRelaTabName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.RelaTabName);
}
else if (strAttributeName  ==  convFeatureRegionFlds_Ttl.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.PrjId);
}
}
}
public object this[int intIndex]
{
get
{
if (convFeatureRegionFlds_Ttl.ViewFeatureId  ==  AttributeName[intIndex])
{
return mstrViewFeatureId;
}
else if (convFeatureRegionFlds_Ttl.RegionId  ==  AttributeName[intIndex])
{
return mstrRegionId;
}
else if (convFeatureRegionFlds_Ttl.RegionName  ==  AttributeName[intIndex])
{
return mstrRegionName;
}
else if (convFeatureRegionFlds_Ttl.RegionTypeId  ==  AttributeName[intIndex])
{
return mstrRegionTypeId;
}
else if (convFeatureRegionFlds_Ttl.RegionTypeName  ==  AttributeName[intIndex])
{
return mstrRegionTypeName;
}
else if (convFeatureRegionFlds_Ttl.FeatureId  ==  AttributeName[intIndex])
{
return mstrFeatureId;
}
else if (convFeatureRegionFlds_Ttl.FeatureName  ==  AttributeName[intIndex])
{
return mstrFeatureName;
}
else if (convFeatureRegionFlds_Ttl.KeyWords  ==  AttributeName[intIndex])
{
return mstrKeyWords;
}
else if (convFeatureRegionFlds_Ttl.TabFeatureId  ==  AttributeName[intIndex])
{
return mstrTabFeatureId;
}
else if (convFeatureRegionFlds_Ttl.TabFeatureName  ==  AttributeName[intIndex])
{
return mstrTabFeatureName;
}
else if (convFeatureRegionFlds_Ttl.CheckTabFeature  ==  AttributeName[intIndex])
{
return mstrCheckTabFeature;
}
else if (convFeatureRegionFlds_Ttl.FeatureDescription  ==  AttributeName[intIndex])
{
return mstrFeatureDescription;
}
else if (convFeatureRegionFlds_Ttl.ButtonName  ==  AttributeName[intIndex])
{
return mstrButtonName;
}
else if (convFeatureRegionFlds_Ttl.ButtonName4Mvc  ==  AttributeName[intIndex])
{
return mstrButtonName4Mvc;
}
else if (convFeatureRegionFlds_Ttl.EventFuncName  ==  AttributeName[intIndex])
{
return mstrEventFuncName;
}
else if (convFeatureRegionFlds_Ttl.ValueGivingModeId  ==  AttributeName[intIndex])
{
return mstrValueGivingModeId;
}
else if (convFeatureRegionFlds_Ttl.ValueGivingModeName  ==  AttributeName[intIndex])
{
return mstrValueGivingModeName;
}
else if (convFeatureRegionFlds_Ttl.FuncName  ==  AttributeName[intIndex])
{
return mstrFuncName;
}
else if (convFeatureRegionFlds_Ttl.DefaultValue  ==  AttributeName[intIndex])
{
return mstrDefaultValue;
}
else if (convFeatureRegionFlds_Ttl.Text  ==  AttributeName[intIndex])
{
return mstrText;
}
else if (convFeatureRegionFlds_Ttl.GroupName  ==  AttributeName[intIndex])
{
return mstrGroupName;
}
else if (convFeatureRegionFlds_Ttl.ReleTabId  ==  AttributeName[intIndex])
{
return mstrReleTabId;
}
else if (convFeatureRegionFlds_Ttl.ReleFldId  ==  AttributeName[intIndex])
{
return mstrReleFldId;
}
else if (convFeatureRegionFlds_Ttl.FieldTypeId  ==  AttributeName[intIndex])
{
return mstrFieldTypeId;
}
else if (convFeatureRegionFlds_Ttl.FieldTypeName  ==  AttributeName[intIndex])
{
return mstrFieldTypeName;
}
else if (convFeatureRegionFlds_Ttl.ViewImplId  ==  AttributeName[intIndex])
{
return mstrViewImplId;
}
else if (convFeatureRegionFlds_Ttl.ViewImplName  ==  AttributeName[intIndex])
{
return mstrViewImplName;
}
else if (convFeatureRegionFlds_Ttl.CtlTypeId  ==  AttributeName[intIndex])
{
return mstrCtlTypeId;
}
else if (convFeatureRegionFlds_Ttl.CtlTypeName  ==  AttributeName[intIndex])
{
return mstrCtlTypeName;
}
else if (convFeatureRegionFlds_Ttl.CtlCnName  ==  AttributeName[intIndex])
{
return mstrCtlCnName;
}
else if (convFeatureRegionFlds_Ttl.CtlTypeAbbr  ==  AttributeName[intIndex])
{
return mstrCtlTypeAbbr;
}
else if (convFeatureRegionFlds_Ttl.Height  ==  AttributeName[intIndex])
{
return mintHeight;
}
else if (convFeatureRegionFlds_Ttl.Width  ==  AttributeName[intIndex])
{
return mintWidth;
}
else if (convFeatureRegionFlds_Ttl.SeqNum  ==  AttributeName[intIndex])
{
return mintSeqNum;
}
else if (convFeatureRegionFlds_Ttl.CssClass  ==  AttributeName[intIndex])
{
return mstrCssClass;
}
else if (convFeatureRegionFlds_Ttl.ImageUrl  ==  AttributeName[intIndex])
{
return mstrImageUrl;
}
else if (convFeatureRegionFlds_Ttl.InUse  ==  AttributeName[intIndex])
{
return mbolInUse;
}
else if (convFeatureRegionFlds_Ttl.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convFeatureRegionFlds_Ttl.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convFeatureRegionFlds_Ttl.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convFeatureRegionFlds_Ttl.FldNum  ==  AttributeName[intIndex])
{
return mintFldNum;
}
else if (convFeatureRegionFlds_Ttl.RelaFldName  ==  AttributeName[intIndex])
{
return mstrRelaFldName;
}
else if (convFeatureRegionFlds_Ttl.RelaTabName  ==  AttributeName[intIndex])
{
return mstrRelaTabName;
}
else if (convFeatureRegionFlds_Ttl.PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
return null;
}
set
{
if (convFeatureRegionFlds_Ttl.ViewFeatureId  ==  AttributeName[intIndex])
{
mstrViewFeatureId = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.ViewFeatureId);
}
else if (convFeatureRegionFlds_Ttl.RegionId  ==  AttributeName[intIndex])
{
mstrRegionId = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.RegionId);
}
else if (convFeatureRegionFlds_Ttl.RegionName  ==  AttributeName[intIndex])
{
mstrRegionName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.RegionName);
}
else if (convFeatureRegionFlds_Ttl.RegionTypeId  ==  AttributeName[intIndex])
{
mstrRegionTypeId = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.RegionTypeId);
}
else if (convFeatureRegionFlds_Ttl.RegionTypeName  ==  AttributeName[intIndex])
{
mstrRegionTypeName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.RegionTypeName);
}
else if (convFeatureRegionFlds_Ttl.FeatureId  ==  AttributeName[intIndex])
{
mstrFeatureId = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.FeatureId);
}
else if (convFeatureRegionFlds_Ttl.FeatureName  ==  AttributeName[intIndex])
{
mstrFeatureName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.FeatureName);
}
else if (convFeatureRegionFlds_Ttl.KeyWords  ==  AttributeName[intIndex])
{
mstrKeyWords = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.KeyWords);
}
else if (convFeatureRegionFlds_Ttl.TabFeatureId  ==  AttributeName[intIndex])
{
mstrTabFeatureId = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.TabFeatureId);
}
else if (convFeatureRegionFlds_Ttl.TabFeatureName  ==  AttributeName[intIndex])
{
mstrTabFeatureName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.TabFeatureName);
}
else if (convFeatureRegionFlds_Ttl.CheckTabFeature  ==  AttributeName[intIndex])
{
mstrCheckTabFeature = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.CheckTabFeature);
}
else if (convFeatureRegionFlds_Ttl.FeatureDescription  ==  AttributeName[intIndex])
{
mstrFeatureDescription = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.FeatureDescription);
}
else if (convFeatureRegionFlds_Ttl.ButtonName  ==  AttributeName[intIndex])
{
mstrButtonName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.ButtonName);
}
else if (convFeatureRegionFlds_Ttl.ButtonName4Mvc  ==  AttributeName[intIndex])
{
mstrButtonName4Mvc = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.ButtonName4Mvc);
}
else if (convFeatureRegionFlds_Ttl.EventFuncName  ==  AttributeName[intIndex])
{
mstrEventFuncName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.EventFuncName);
}
else if (convFeatureRegionFlds_Ttl.ValueGivingModeId  ==  AttributeName[intIndex])
{
mstrValueGivingModeId = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.ValueGivingModeId);
}
else if (convFeatureRegionFlds_Ttl.ValueGivingModeName  ==  AttributeName[intIndex])
{
mstrValueGivingModeName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.ValueGivingModeName);
}
else if (convFeatureRegionFlds_Ttl.FuncName  ==  AttributeName[intIndex])
{
mstrFuncName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.FuncName);
}
else if (convFeatureRegionFlds_Ttl.DefaultValue  ==  AttributeName[intIndex])
{
mstrDefaultValue = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.DefaultValue);
}
else if (convFeatureRegionFlds_Ttl.Text  ==  AttributeName[intIndex])
{
mstrText = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.Text);
}
else if (convFeatureRegionFlds_Ttl.GroupName  ==  AttributeName[intIndex])
{
mstrGroupName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.GroupName);
}
else if (convFeatureRegionFlds_Ttl.ReleTabId  ==  AttributeName[intIndex])
{
mstrReleTabId = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.ReleTabId);
}
else if (convFeatureRegionFlds_Ttl.ReleFldId  ==  AttributeName[intIndex])
{
mstrReleFldId = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.ReleFldId);
}
else if (convFeatureRegionFlds_Ttl.FieldTypeId  ==  AttributeName[intIndex])
{
mstrFieldTypeId = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.FieldTypeId);
}
else if (convFeatureRegionFlds_Ttl.FieldTypeName  ==  AttributeName[intIndex])
{
mstrFieldTypeName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.FieldTypeName);
}
else if (convFeatureRegionFlds_Ttl.ViewImplId  ==  AttributeName[intIndex])
{
mstrViewImplId = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.ViewImplId);
}
else if (convFeatureRegionFlds_Ttl.ViewImplName  ==  AttributeName[intIndex])
{
mstrViewImplName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.ViewImplName);
}
else if (convFeatureRegionFlds_Ttl.CtlTypeId  ==  AttributeName[intIndex])
{
mstrCtlTypeId = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.CtlTypeId);
}
else if (convFeatureRegionFlds_Ttl.CtlTypeName  ==  AttributeName[intIndex])
{
mstrCtlTypeName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.CtlTypeName);
}
else if (convFeatureRegionFlds_Ttl.CtlCnName  ==  AttributeName[intIndex])
{
mstrCtlCnName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.CtlCnName);
}
else if (convFeatureRegionFlds_Ttl.CtlTypeAbbr  ==  AttributeName[intIndex])
{
mstrCtlTypeAbbr = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.CtlTypeAbbr);
}
else if (convFeatureRegionFlds_Ttl.Height  ==  AttributeName[intIndex])
{
mintHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(convFeatureRegionFlds_Ttl.Height);
}
else if (convFeatureRegionFlds_Ttl.Width  ==  AttributeName[intIndex])
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(convFeatureRegionFlds_Ttl.Width);
}
else if (convFeatureRegionFlds_Ttl.SeqNum  ==  AttributeName[intIndex])
{
mintSeqNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFeatureRegionFlds_Ttl.SeqNum);
}
else if (convFeatureRegionFlds_Ttl.CssClass  ==  AttributeName[intIndex])
{
mstrCssClass = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.CssClass);
}
else if (convFeatureRegionFlds_Ttl.ImageUrl  ==  AttributeName[intIndex])
{
mstrImageUrl = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.ImageUrl);
}
else if (convFeatureRegionFlds_Ttl.InUse  ==  AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convFeatureRegionFlds_Ttl.InUse);
}
else if (convFeatureRegionFlds_Ttl.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.UpdUser);
}
else if (convFeatureRegionFlds_Ttl.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.UpdDate);
}
else if (convFeatureRegionFlds_Ttl.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.Memo);
}
else if (convFeatureRegionFlds_Ttl.FldNum  ==  AttributeName[intIndex])
{
mintFldNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFeatureRegionFlds_Ttl.FldNum);
}
else if (convFeatureRegionFlds_Ttl.RelaFldName  ==  AttributeName[intIndex])
{
mstrRelaFldName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.RelaFldName);
}
else if (convFeatureRegionFlds_Ttl.RelaTabName  ==  AttributeName[intIndex])
{
mstrRelaTabName = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.RelaTabName);
}
else if (convFeatureRegionFlds_Ttl.PrjId  ==  AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convFeatureRegionFlds_Ttl.PrjId);
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
 AddUpdatedFld(convFeatureRegionFlds_Ttl.ViewFeatureId);
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
 AddUpdatedFld(convFeatureRegionFlds_Ttl.RegionId);
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
 AddUpdatedFld(convFeatureRegionFlds_Ttl.RegionName);
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
 AddUpdatedFld(convFeatureRegionFlds_Ttl.RegionTypeId);
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
 AddUpdatedFld(convFeatureRegionFlds_Ttl.RegionTypeName);
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
 AddUpdatedFld(convFeatureRegionFlds_Ttl.FeatureId);
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
 AddUpdatedFld(convFeatureRegionFlds_Ttl.FeatureName);
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
 AddUpdatedFld(convFeatureRegionFlds_Ttl.KeyWords);
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
 AddUpdatedFld(convFeatureRegionFlds_Ttl.TabFeatureId);
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
 AddUpdatedFld(convFeatureRegionFlds_Ttl.TabFeatureName);
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
 AddUpdatedFld(convFeatureRegionFlds_Ttl.CheckTabFeature);
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
 AddUpdatedFld(convFeatureRegionFlds_Ttl.FeatureDescription);
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
 AddUpdatedFld(convFeatureRegionFlds_Ttl.ButtonName);
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
 AddUpdatedFld(convFeatureRegionFlds_Ttl.ButtonName4Mvc);
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
 AddUpdatedFld(convFeatureRegionFlds_Ttl.EventFuncName);
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
 AddUpdatedFld(convFeatureRegionFlds_Ttl.ValueGivingModeId);
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
 AddUpdatedFld(convFeatureRegionFlds_Ttl.ValueGivingModeName);
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
 AddUpdatedFld(convFeatureRegionFlds_Ttl.FuncName);
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
 AddUpdatedFld(convFeatureRegionFlds_Ttl.DefaultValue);
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
 AddUpdatedFld(convFeatureRegionFlds_Ttl.Text);
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
 AddUpdatedFld(convFeatureRegionFlds_Ttl.GroupName);
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
 AddUpdatedFld(convFeatureRegionFlds_Ttl.ReleTabId);
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
 AddUpdatedFld(convFeatureRegionFlds_Ttl.ReleFldId);
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
 AddUpdatedFld(convFeatureRegionFlds_Ttl.FieldTypeId);
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
 AddUpdatedFld(convFeatureRegionFlds_Ttl.FieldTypeName);
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
 AddUpdatedFld(convFeatureRegionFlds_Ttl.ViewImplId);
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
 AddUpdatedFld(convFeatureRegionFlds_Ttl.ViewImplName);
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
 AddUpdatedFld(convFeatureRegionFlds_Ttl.CtlTypeId);
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
 AddUpdatedFld(convFeatureRegionFlds_Ttl.CtlTypeName);
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
 AddUpdatedFld(convFeatureRegionFlds_Ttl.CtlCnName);
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
 AddUpdatedFld(convFeatureRegionFlds_Ttl.CtlTypeAbbr);
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
 AddUpdatedFld(convFeatureRegionFlds_Ttl.Height);
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
 AddUpdatedFld(convFeatureRegionFlds_Ttl.Width);
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
 AddUpdatedFld(convFeatureRegionFlds_Ttl.SeqNum);
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
 AddUpdatedFld(convFeatureRegionFlds_Ttl.CssClass);
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
 AddUpdatedFld(convFeatureRegionFlds_Ttl.ImageUrl);
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
 AddUpdatedFld(convFeatureRegionFlds_Ttl.InUse);
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
 AddUpdatedFld(convFeatureRegionFlds_Ttl.UpdUser);
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
 AddUpdatedFld(convFeatureRegionFlds_Ttl.UpdDate);
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
 AddUpdatedFld(convFeatureRegionFlds_Ttl.Memo);
}
}
/// <summary>
/// 字段数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? FldNum
{
get
{
return mintFldNum;
}
set
{
 mintFldNum = value;
//记录修改过的字段
 AddUpdatedFld(convFeatureRegionFlds_Ttl.FldNum);
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
 AddUpdatedFld(convFeatureRegionFlds_Ttl.RelaFldName);
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
 AddUpdatedFld(convFeatureRegionFlds_Ttl.RelaTabName);
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
 AddUpdatedFld(convFeatureRegionFlds_Ttl.PrjId);
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
 /// v功能区域字段_Ttl(vFeatureRegionFlds_Ttl)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convFeatureRegionFlds_Ttl
{
public const string _CurrTabName = "vFeatureRegionFlds_Ttl"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ViewFeatureId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ViewFeatureId", "RegionId", "RegionName", "RegionTypeId", "RegionTypeName", "FeatureId", "FeatureName", "KeyWords", "TabFeatureId", "TabFeatureName", "CheckTabFeature", "FeatureDescription", "ButtonName", "ButtonName4Mvc", "EventFuncName", "ValueGivingModeId", "ValueGivingModeName", "FuncName", "DefaultValue", "Text", "GroupName", "ReleTabId", "ReleFldId", "FieldTypeId", "FieldTypeName", "ViewImplId", "ViewImplName", "CtlTypeId", "CtlTypeName", "CtlCnName", "CtlTypeAbbr", "Height", "Width", "SeqNum", "CssClass", "ImageUrl", "InUse", "UpdUser", "UpdDate", "Memo", "FldNum", "RelaFldName", "RelaTabName", "PrjId"};
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
 /// 常量:"FldNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldNum = "FldNum";    //字段数

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