
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFeatureRegionFldsEN
 表名:FeatureRegionFlds(00050452)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:00:04
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
 /// 表FeatureRegionFlds的关键字(ViewFeatureId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ViewFeatureId_FeatureRegionFlds
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
public K_ViewFeatureId_FeatureRegionFlds(string strViewFeatureId)
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
 /// <returns>返回:[K_ViewFeatureId_FeatureRegionFlds]类型的对象</returns>
public static implicit operator K_ViewFeatureId_FeatureRegionFlds(string value)
{
return new K_ViewFeatureId_FeatureRegionFlds(value);
}
}
 /// <summary>
 /// 功能区域字段(FeatureRegionFlds)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsFeatureRegionFldsEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "FeatureRegionFlds"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ViewFeatureId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 32;
public static string[] _AttributeName = new string[] {"ViewFeatureId", "RegionId", "FeatureId", "TabFeatureId", "CheckTabFeature", "FeatureDescription", "ButtonName", "ButtonName4Mvc", "CommandName", "ValueGivingModeId", "FuncName", "DefaultValue", "KeyIdGetModeId", "Text", "GroupName", "ReleTabId", "ReleFldId", "EventFuncName", "FieldTypeId", "ViewImplId", "CtlTypeId", "Height", "Width", "SeqNum", "CssClass", "ImageUrl", "InUse", "ErrMsg", "PrjId", "UpdUser", "UpdDate", "Memo"};

protected string mstrViewFeatureId;    //界面功能Id
protected string mstrRegionId;    //区域Id
protected string mstrFeatureId;    //功能Id
protected string mstrTabFeatureId;    //表功能Id
protected string mstrCheckTabFeature;    //检查表功能
protected string mstrFeatureDescription;    //功能说明
protected string mstrButtonName;    //按钮名称
protected string mstrButtonName4Mvc;    //按钮名称4Mvc
protected string mstrCommandName;    //命令名
protected string mstrValueGivingModeId;    //给值方式Id
protected string mstrFuncName;    //函数名
protected string mstrDefaultValue;    //缺省值
protected string mstrKeyIdGetModeId;    //GC关键字获取方式Id
protected string mstrText;    //文本
protected string mstrGroupName;    //组名
protected string mstrReleTabId;    //相关表Id
protected string mstrReleFldId;    //相关字段Id
protected string mstrEventFuncName;    //事件函数名
protected string mstrFieldTypeId;    //字段类型Id
protected string mstrViewImplId;    //界面实现Id
protected string mstrCtlTypeId;    //控件类型号
protected int? mintHeight;    //高度
protected int? mintWidth;    //宽
protected int? mintSeqNum;    //字段序号
protected string mstrCssClass;    //样式表
protected string mstrImageUrl;    //图片资源
protected bool mbolInUse;    //是否在用
protected string mstrErrMsg;    //错误信息
protected string mstrPrjId;    //工程Id
protected string mstrUpdUser;    //修改者
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsFeatureRegionFldsEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ViewFeatureId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strViewFeatureId">关键字:界面功能Id</param>
public clsFeatureRegionFldsEN(string strViewFeatureId)
 {
strViewFeatureId = strViewFeatureId.Replace("'", "''");
if (strViewFeatureId.Length > 8)
{
throw new Exception("在表:FeatureRegionFlds中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strViewFeatureId)  ==  true)
{
throw new Exception("在表:FeatureRegionFlds中,关键字不能为空 或 null!");
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
return _AttributeCount;
}
}
public override object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  conFeatureRegionFlds.ViewFeatureId)
{
return mstrViewFeatureId;
}
else if (strAttributeName  ==  conFeatureRegionFlds.RegionId)
{
return mstrRegionId;
}
else if (strAttributeName  ==  conFeatureRegionFlds.FeatureId)
{
return mstrFeatureId;
}
else if (strAttributeName  ==  conFeatureRegionFlds.TabFeatureId)
{
return mstrTabFeatureId;
}
else if (strAttributeName  ==  conFeatureRegionFlds.CheckTabFeature)
{
return mstrCheckTabFeature;
}
else if (strAttributeName  ==  conFeatureRegionFlds.FeatureDescription)
{
return mstrFeatureDescription;
}
else if (strAttributeName  ==  conFeatureRegionFlds.ButtonName)
{
return mstrButtonName;
}
else if (strAttributeName  ==  conFeatureRegionFlds.ButtonName4Mvc)
{
return mstrButtonName4Mvc;
}
else if (strAttributeName  ==  conFeatureRegionFlds.CommandName)
{
return mstrCommandName;
}
else if (strAttributeName  ==  conFeatureRegionFlds.ValueGivingModeId)
{
return mstrValueGivingModeId;
}
else if (strAttributeName  ==  conFeatureRegionFlds.FuncName)
{
return mstrFuncName;
}
else if (strAttributeName  ==  conFeatureRegionFlds.DefaultValue)
{
return mstrDefaultValue;
}
else if (strAttributeName  ==  conFeatureRegionFlds.KeyIdGetModeId)
{
return mstrKeyIdGetModeId;
}
else if (strAttributeName  ==  conFeatureRegionFlds.Text)
{
return mstrText;
}
else if (strAttributeName  ==  conFeatureRegionFlds.GroupName)
{
return mstrGroupName;
}
else if (strAttributeName  ==  conFeatureRegionFlds.ReleTabId)
{
return mstrReleTabId;
}
else if (strAttributeName  ==  conFeatureRegionFlds.ReleFldId)
{
return mstrReleFldId;
}
else if (strAttributeName  ==  conFeatureRegionFlds.EventFuncName)
{
return mstrEventFuncName;
}
else if (strAttributeName  ==  conFeatureRegionFlds.FieldTypeId)
{
return mstrFieldTypeId;
}
else if (strAttributeName  ==  conFeatureRegionFlds.ViewImplId)
{
return mstrViewImplId;
}
else if (strAttributeName  ==  conFeatureRegionFlds.CtlTypeId)
{
return mstrCtlTypeId;
}
else if (strAttributeName  ==  conFeatureRegionFlds.Height)
{
return mintHeight;
}
else if (strAttributeName  ==  conFeatureRegionFlds.Width)
{
return mintWidth;
}
else if (strAttributeName  ==  conFeatureRegionFlds.SeqNum)
{
return mintSeqNum;
}
else if (strAttributeName  ==  conFeatureRegionFlds.CssClass)
{
return mstrCssClass;
}
else if (strAttributeName  ==  conFeatureRegionFlds.ImageUrl)
{
return mstrImageUrl;
}
else if (strAttributeName  ==  conFeatureRegionFlds.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  conFeatureRegionFlds.ErrMsg)
{
return mstrErrMsg;
}
else if (strAttributeName  ==  conFeatureRegionFlds.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conFeatureRegionFlds.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conFeatureRegionFlds.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conFeatureRegionFlds.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conFeatureRegionFlds.ViewFeatureId)
{
mstrViewFeatureId = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.ViewFeatureId);
}
else if (strAttributeName  ==  conFeatureRegionFlds.RegionId)
{
mstrRegionId = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.RegionId);
}
else if (strAttributeName  ==  conFeatureRegionFlds.FeatureId)
{
mstrFeatureId = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.FeatureId);
}
else if (strAttributeName  ==  conFeatureRegionFlds.TabFeatureId)
{
mstrTabFeatureId = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.TabFeatureId);
}
else if (strAttributeName  ==  conFeatureRegionFlds.CheckTabFeature)
{
mstrCheckTabFeature = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.CheckTabFeature);
}
else if (strAttributeName  ==  conFeatureRegionFlds.FeatureDescription)
{
mstrFeatureDescription = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.FeatureDescription);
}
else if (strAttributeName  ==  conFeatureRegionFlds.ButtonName)
{
mstrButtonName = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.ButtonName);
}
else if (strAttributeName  ==  conFeatureRegionFlds.ButtonName4Mvc)
{
mstrButtonName4Mvc = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.ButtonName4Mvc);
}
else if (strAttributeName  ==  conFeatureRegionFlds.CommandName)
{
mstrCommandName = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.CommandName);
}
else if (strAttributeName  ==  conFeatureRegionFlds.ValueGivingModeId)
{
mstrValueGivingModeId = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.ValueGivingModeId);
}
else if (strAttributeName  ==  conFeatureRegionFlds.FuncName)
{
mstrFuncName = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.FuncName);
}
else if (strAttributeName  ==  conFeatureRegionFlds.DefaultValue)
{
mstrDefaultValue = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.DefaultValue);
}
else if (strAttributeName  ==  conFeatureRegionFlds.KeyIdGetModeId)
{
mstrKeyIdGetModeId = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.KeyIdGetModeId);
}
else if (strAttributeName  ==  conFeatureRegionFlds.Text)
{
mstrText = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.Text);
}
else if (strAttributeName  ==  conFeatureRegionFlds.GroupName)
{
mstrGroupName = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.GroupName);
}
else if (strAttributeName  ==  conFeatureRegionFlds.ReleTabId)
{
mstrReleTabId = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.ReleTabId);
}
else if (strAttributeName  ==  conFeatureRegionFlds.ReleFldId)
{
mstrReleFldId = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.ReleFldId);
}
else if (strAttributeName  ==  conFeatureRegionFlds.EventFuncName)
{
mstrEventFuncName = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.EventFuncName);
}
else if (strAttributeName  ==  conFeatureRegionFlds.FieldTypeId)
{
mstrFieldTypeId = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.FieldTypeId);
}
else if (strAttributeName  ==  conFeatureRegionFlds.ViewImplId)
{
mstrViewImplId = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.ViewImplId);
}
else if (strAttributeName  ==  conFeatureRegionFlds.CtlTypeId)
{
mstrCtlTypeId = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.CtlTypeId);
}
else if (strAttributeName  ==  conFeatureRegionFlds.Height)
{
mintHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(conFeatureRegionFlds.Height);
}
else if (strAttributeName  ==  conFeatureRegionFlds.Width)
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(conFeatureRegionFlds.Width);
}
else if (strAttributeName  ==  conFeatureRegionFlds.SeqNum)
{
mintSeqNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conFeatureRegionFlds.SeqNum);
}
else if (strAttributeName  ==  conFeatureRegionFlds.CssClass)
{
mstrCssClass = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.CssClass);
}
else if (strAttributeName  ==  conFeatureRegionFlds.ImageUrl)
{
mstrImageUrl = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.ImageUrl);
}
else if (strAttributeName  ==  conFeatureRegionFlds.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conFeatureRegionFlds.InUse);
}
else if (strAttributeName  ==  conFeatureRegionFlds.ErrMsg)
{
mstrErrMsg = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.ErrMsg);
}
else if (strAttributeName  ==  conFeatureRegionFlds.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.PrjId);
}
else if (strAttributeName  ==  conFeatureRegionFlds.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.UpdUser);
}
else if (strAttributeName  ==  conFeatureRegionFlds.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.UpdDate);
}
else if (strAttributeName  ==  conFeatureRegionFlds.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conFeatureRegionFlds.ViewFeatureId  ==  _AttributeName[intIndex])
{
return mstrViewFeatureId;
}
else if (conFeatureRegionFlds.RegionId  ==  _AttributeName[intIndex])
{
return mstrRegionId;
}
else if (conFeatureRegionFlds.FeatureId  ==  _AttributeName[intIndex])
{
return mstrFeatureId;
}
else if (conFeatureRegionFlds.TabFeatureId  ==  _AttributeName[intIndex])
{
return mstrTabFeatureId;
}
else if (conFeatureRegionFlds.CheckTabFeature  ==  _AttributeName[intIndex])
{
return mstrCheckTabFeature;
}
else if (conFeatureRegionFlds.FeatureDescription  ==  _AttributeName[intIndex])
{
return mstrFeatureDescription;
}
else if (conFeatureRegionFlds.ButtonName  ==  _AttributeName[intIndex])
{
return mstrButtonName;
}
else if (conFeatureRegionFlds.ButtonName4Mvc  ==  _AttributeName[intIndex])
{
return mstrButtonName4Mvc;
}
else if (conFeatureRegionFlds.CommandName  ==  _AttributeName[intIndex])
{
return mstrCommandName;
}
else if (conFeatureRegionFlds.ValueGivingModeId  ==  _AttributeName[intIndex])
{
return mstrValueGivingModeId;
}
else if (conFeatureRegionFlds.FuncName  ==  _AttributeName[intIndex])
{
return mstrFuncName;
}
else if (conFeatureRegionFlds.DefaultValue  ==  _AttributeName[intIndex])
{
return mstrDefaultValue;
}
else if (conFeatureRegionFlds.KeyIdGetModeId  ==  _AttributeName[intIndex])
{
return mstrKeyIdGetModeId;
}
else if (conFeatureRegionFlds.Text  ==  _AttributeName[intIndex])
{
return mstrText;
}
else if (conFeatureRegionFlds.GroupName  ==  _AttributeName[intIndex])
{
return mstrGroupName;
}
else if (conFeatureRegionFlds.ReleTabId  ==  _AttributeName[intIndex])
{
return mstrReleTabId;
}
else if (conFeatureRegionFlds.ReleFldId  ==  _AttributeName[intIndex])
{
return mstrReleFldId;
}
else if (conFeatureRegionFlds.EventFuncName  ==  _AttributeName[intIndex])
{
return mstrEventFuncName;
}
else if (conFeatureRegionFlds.FieldTypeId  ==  _AttributeName[intIndex])
{
return mstrFieldTypeId;
}
else if (conFeatureRegionFlds.ViewImplId  ==  _AttributeName[intIndex])
{
return mstrViewImplId;
}
else if (conFeatureRegionFlds.CtlTypeId  ==  _AttributeName[intIndex])
{
return mstrCtlTypeId;
}
else if (conFeatureRegionFlds.Height  ==  _AttributeName[intIndex])
{
return mintHeight;
}
else if (conFeatureRegionFlds.Width  ==  _AttributeName[intIndex])
{
return mintWidth;
}
else if (conFeatureRegionFlds.SeqNum  ==  _AttributeName[intIndex])
{
return mintSeqNum;
}
else if (conFeatureRegionFlds.CssClass  ==  _AttributeName[intIndex])
{
return mstrCssClass;
}
else if (conFeatureRegionFlds.ImageUrl  ==  _AttributeName[intIndex])
{
return mstrImageUrl;
}
else if (conFeatureRegionFlds.InUse  ==  _AttributeName[intIndex])
{
return mbolInUse;
}
else if (conFeatureRegionFlds.ErrMsg  ==  _AttributeName[intIndex])
{
return mstrErrMsg;
}
else if (conFeatureRegionFlds.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conFeatureRegionFlds.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conFeatureRegionFlds.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conFeatureRegionFlds.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conFeatureRegionFlds.ViewFeatureId  ==  _AttributeName[intIndex])
{
mstrViewFeatureId = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.ViewFeatureId);
}
else if (conFeatureRegionFlds.RegionId  ==  _AttributeName[intIndex])
{
mstrRegionId = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.RegionId);
}
else if (conFeatureRegionFlds.FeatureId  ==  _AttributeName[intIndex])
{
mstrFeatureId = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.FeatureId);
}
else if (conFeatureRegionFlds.TabFeatureId  ==  _AttributeName[intIndex])
{
mstrTabFeatureId = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.TabFeatureId);
}
else if (conFeatureRegionFlds.CheckTabFeature  ==  _AttributeName[intIndex])
{
mstrCheckTabFeature = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.CheckTabFeature);
}
else if (conFeatureRegionFlds.FeatureDescription  ==  _AttributeName[intIndex])
{
mstrFeatureDescription = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.FeatureDescription);
}
else if (conFeatureRegionFlds.ButtonName  ==  _AttributeName[intIndex])
{
mstrButtonName = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.ButtonName);
}
else if (conFeatureRegionFlds.ButtonName4Mvc  ==  _AttributeName[intIndex])
{
mstrButtonName4Mvc = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.ButtonName4Mvc);
}
else if (conFeatureRegionFlds.CommandName  ==  _AttributeName[intIndex])
{
mstrCommandName = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.CommandName);
}
else if (conFeatureRegionFlds.ValueGivingModeId  ==  _AttributeName[intIndex])
{
mstrValueGivingModeId = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.ValueGivingModeId);
}
else if (conFeatureRegionFlds.FuncName  ==  _AttributeName[intIndex])
{
mstrFuncName = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.FuncName);
}
else if (conFeatureRegionFlds.DefaultValue  ==  _AttributeName[intIndex])
{
mstrDefaultValue = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.DefaultValue);
}
else if (conFeatureRegionFlds.KeyIdGetModeId  ==  _AttributeName[intIndex])
{
mstrKeyIdGetModeId = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.KeyIdGetModeId);
}
else if (conFeatureRegionFlds.Text  ==  _AttributeName[intIndex])
{
mstrText = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.Text);
}
else if (conFeatureRegionFlds.GroupName  ==  _AttributeName[intIndex])
{
mstrGroupName = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.GroupName);
}
else if (conFeatureRegionFlds.ReleTabId  ==  _AttributeName[intIndex])
{
mstrReleTabId = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.ReleTabId);
}
else if (conFeatureRegionFlds.ReleFldId  ==  _AttributeName[intIndex])
{
mstrReleFldId = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.ReleFldId);
}
else if (conFeatureRegionFlds.EventFuncName  ==  _AttributeName[intIndex])
{
mstrEventFuncName = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.EventFuncName);
}
else if (conFeatureRegionFlds.FieldTypeId  ==  _AttributeName[intIndex])
{
mstrFieldTypeId = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.FieldTypeId);
}
else if (conFeatureRegionFlds.ViewImplId  ==  _AttributeName[intIndex])
{
mstrViewImplId = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.ViewImplId);
}
else if (conFeatureRegionFlds.CtlTypeId  ==  _AttributeName[intIndex])
{
mstrCtlTypeId = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.CtlTypeId);
}
else if (conFeatureRegionFlds.Height  ==  _AttributeName[intIndex])
{
mintHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(conFeatureRegionFlds.Height);
}
else if (conFeatureRegionFlds.Width  ==  _AttributeName[intIndex])
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(conFeatureRegionFlds.Width);
}
else if (conFeatureRegionFlds.SeqNum  ==  _AttributeName[intIndex])
{
mintSeqNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conFeatureRegionFlds.SeqNum);
}
else if (conFeatureRegionFlds.CssClass  ==  _AttributeName[intIndex])
{
mstrCssClass = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.CssClass);
}
else if (conFeatureRegionFlds.ImageUrl  ==  _AttributeName[intIndex])
{
mstrImageUrl = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.ImageUrl);
}
else if (conFeatureRegionFlds.InUse  ==  _AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conFeatureRegionFlds.InUse);
}
else if (conFeatureRegionFlds.ErrMsg  ==  _AttributeName[intIndex])
{
mstrErrMsg = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.ErrMsg);
}
else if (conFeatureRegionFlds.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.PrjId);
}
else if (conFeatureRegionFlds.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.UpdUser);
}
else if (conFeatureRegionFlds.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.UpdDate);
}
else if (conFeatureRegionFlds.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFeatureRegionFlds.Memo);
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
 AddUpdatedFld(conFeatureRegionFlds.ViewFeatureId);
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
 AddUpdatedFld(conFeatureRegionFlds.RegionId);
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
 AddUpdatedFld(conFeatureRegionFlds.FeatureId);
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
 AddUpdatedFld(conFeatureRegionFlds.TabFeatureId);
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
 AddUpdatedFld(conFeatureRegionFlds.CheckTabFeature);
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
 AddUpdatedFld(conFeatureRegionFlds.FeatureDescription);
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
 AddUpdatedFld(conFeatureRegionFlds.ButtonName);
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
 AddUpdatedFld(conFeatureRegionFlds.ButtonName4Mvc);
}
}
/// <summary>
/// 命令名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CommandName
{
get
{
return mstrCommandName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCommandName = value;
}
else
{
 mstrCommandName = value;
}
//记录修改过的字段
 AddUpdatedFld(conFeatureRegionFlds.CommandName);
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
 AddUpdatedFld(conFeatureRegionFlds.ValueGivingModeId);
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
 AddUpdatedFld(conFeatureRegionFlds.FuncName);
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
 AddUpdatedFld(conFeatureRegionFlds.DefaultValue);
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
 AddUpdatedFld(conFeatureRegionFlds.KeyIdGetModeId);
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
 AddUpdatedFld(conFeatureRegionFlds.Text);
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
 AddUpdatedFld(conFeatureRegionFlds.GroupName);
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
 AddUpdatedFld(conFeatureRegionFlds.ReleTabId);
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
 AddUpdatedFld(conFeatureRegionFlds.ReleFldId);
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
 AddUpdatedFld(conFeatureRegionFlds.EventFuncName);
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
 AddUpdatedFld(conFeatureRegionFlds.FieldTypeId);
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
 AddUpdatedFld(conFeatureRegionFlds.ViewImplId);
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
 AddUpdatedFld(conFeatureRegionFlds.CtlTypeId);
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
 AddUpdatedFld(conFeatureRegionFlds.Height);
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
 AddUpdatedFld(conFeatureRegionFlds.Width);
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
 AddUpdatedFld(conFeatureRegionFlds.SeqNum);
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
 AddUpdatedFld(conFeatureRegionFlds.CssClass);
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
 AddUpdatedFld(conFeatureRegionFlds.ImageUrl);
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
 AddUpdatedFld(conFeatureRegionFlds.InUse);
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
 AddUpdatedFld(conFeatureRegionFlds.ErrMsg);
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
 AddUpdatedFld(conFeatureRegionFlds.PrjId);
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
 AddUpdatedFld(conFeatureRegionFlds.UpdUser);
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
 AddUpdatedFld(conFeatureRegionFlds.UpdDate);
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
 AddUpdatedFld(conFeatureRegionFlds.Memo);
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
  return mstrViewFeatureId;
 }
 }
}
 /// <summary>
 /// 功能区域字段(FeatureRegionFlds)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conFeatureRegionFlds
{
public const string _CurrTabName = "FeatureRegionFlds"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ViewFeatureId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"ViewFeatureId", "RegionId", "FeatureId", "TabFeatureId", "CheckTabFeature", "FeatureDescription", "ButtonName", "ButtonName4Mvc", "CommandName", "ValueGivingModeId", "FuncName", "DefaultValue", "KeyIdGetModeId", "Text", "GroupName", "ReleTabId", "ReleFldId", "EventFuncName", "FieldTypeId", "ViewImplId", "CtlTypeId", "Height", "Width", "SeqNum", "CssClass", "ImageUrl", "InUse", "ErrMsg", "PrjId", "UpdUser", "UpdDate", "Memo"};
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
 /// 常量:"FeatureId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeatureId = "FeatureId";    //功能Id

 /// <summary>
 /// 常量:"TabFeatureId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabFeatureId = "TabFeatureId";    //表功能Id

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
 /// 常量:"CommandName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CommandName = "CommandName";    //命令名

 /// <summary>
 /// 常量:"ValueGivingModeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ValueGivingModeId = "ValueGivingModeId";    //给值方式Id

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
 /// 常量:"EventFuncName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EventFuncName = "EventFuncName";    //事件函数名

 /// <summary>
 /// 常量:"FieldTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FieldTypeId = "FieldTypeId";    //字段类型Id

 /// <summary>
 /// 常量:"ViewImplId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewImplId = "ViewImplId";    //界面实现Id

 /// <summary>
 /// 常量:"CtlTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CtlTypeId = "CtlTypeId";    //控件类型号

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
 /// 常量:"ErrMsg"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ErrMsg = "ErrMsg";    //错误信息

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
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}