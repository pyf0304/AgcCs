
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcss_TemplateStyleEN
 表名:vcss_TemplateStyle(00050472)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:41:45
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:样式表管理(CssManage)
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
 /// 表vcss_TemplateStyle的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vcss_TemplateStyle
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
public K_mId_vcss_TemplateStyle(long lngmId)
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
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_mId_vcss_TemplateStyle]类型的对象</returns>
public static implicit operator K_mId_vcss_TemplateStyle(long value)
{
return new K_mId_vcss_TemplateStyle(value);
}
}
 /// <summary>
 /// vcss_TemplateStyle(vcss_TemplateStyle)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvcss_TemplateStyleEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接，如果为空就使用系统默认的连接
public new const string _CurrTabName = "vcss_TemplateStyle"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string WhereFormat = ""; //条件格式串
protected const int mintAttributeCount = 20;
public static string[] AttributeName = new string[] {"mId", "StyleId", "ControlId", "ControlName", "StyleName", "StyleDesc", "StyleContent", "TemplateId", "TemplateName", "TemplateDesc", "TemplatePic", "IsPublic", "TemplateStyleName", "UpdDate", "UpdUser", "Memo", "TemplateStyleNameEn", "cssModuleAreaId", "ModuleAreaName", "IsDelete"};

protected long mlngmId;    //mId
protected string mstrStyleId;    //样式ID
protected string mstrControlId;    //控件ID
protected string mstrControlName;    //控件名称
protected string mstrStyleName;    //样式名称
protected string mstrStyleDesc;    //样式描述
protected string mstrStyleContent;    //样式内容
protected string mstrTemplateId;    //模板ID
protected string mstrTemplateName;    //模板名称
protected string mstrTemplateDesc;    //模板描述
protected string mstrTemplatePic;    //模板图片
protected bool mbolIsPublic;    //是否公开
protected string mstrTemplateStyleName;    //模板样式名称
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明
protected string mstrTemplateStyleNameEn;    //模板样式英文
protected string mstrcssModuleAreaId;    //区域主键
protected string mstrModuleAreaName;    //区域名称
protected bool mbolIsDelete;    //IsDelete

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvcss_TemplateStyleEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "vcss_TemplateStyle";
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:mId</param>
public clsvcss_TemplateStyleEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "vcss_TemplateStyle";
 lstKeyFldNames.Add("mId");
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
if (strAttributeName  ==  convcss_TemplateStyle.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convcss_TemplateStyle.StyleId)
{
return mstrStyleId;
}
else if (strAttributeName  ==  convcss_TemplateStyle.ControlId)
{
return mstrControlId;
}
else if (strAttributeName  ==  convcss_TemplateStyle.ControlName)
{
return mstrControlName;
}
else if (strAttributeName  ==  convcss_TemplateStyle.StyleName)
{
return mstrStyleName;
}
else if (strAttributeName  ==  convcss_TemplateStyle.StyleDesc)
{
return mstrStyleDesc;
}
else if (strAttributeName  ==  convcss_TemplateStyle.StyleContent)
{
return mstrStyleContent;
}
else if (strAttributeName  ==  convcss_TemplateStyle.TemplateId)
{
return mstrTemplateId;
}
else if (strAttributeName  ==  convcss_TemplateStyle.TemplateName)
{
return mstrTemplateName;
}
else if (strAttributeName  ==  convcss_TemplateStyle.TemplateDesc)
{
return mstrTemplateDesc;
}
else if (strAttributeName  ==  convcss_TemplateStyle.TemplatePic)
{
return mstrTemplatePic;
}
else if (strAttributeName  ==  convcss_TemplateStyle.IsPublic)
{
return mbolIsPublic;
}
else if (strAttributeName  ==  convcss_TemplateStyle.TemplateStyleName)
{
return mstrTemplateStyleName;
}
else if (strAttributeName  ==  convcss_TemplateStyle.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convcss_TemplateStyle.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convcss_TemplateStyle.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convcss_TemplateStyle.TemplateStyleNameEn)
{
return mstrTemplateStyleNameEn;
}
else if (strAttributeName  ==  convcss_TemplateStyle.cssModuleAreaId)
{
return mstrcssModuleAreaId;
}
else if (strAttributeName  ==  convcss_TemplateStyle.ModuleAreaName)
{
return mstrModuleAreaName;
}
else if (strAttributeName  ==  convcss_TemplateStyle.IsDelete)
{
return mbolIsDelete;
}
return null;
}
set
{
if (strAttributeName  ==  convcss_TemplateStyle.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convcss_TemplateStyle.mId);
}
else if (strAttributeName  ==  convcss_TemplateStyle.StyleId)
{
mstrStyleId = value.ToString();
 AddUpdatedFld(convcss_TemplateStyle.StyleId);
}
else if (strAttributeName  ==  convcss_TemplateStyle.ControlId)
{
mstrControlId = value.ToString();
 AddUpdatedFld(convcss_TemplateStyle.ControlId);
}
else if (strAttributeName  ==  convcss_TemplateStyle.ControlName)
{
mstrControlName = value.ToString();
 AddUpdatedFld(convcss_TemplateStyle.ControlName);
}
else if (strAttributeName  ==  convcss_TemplateStyle.StyleName)
{
mstrStyleName = value.ToString();
 AddUpdatedFld(convcss_TemplateStyle.StyleName);
}
else if (strAttributeName  ==  convcss_TemplateStyle.StyleDesc)
{
mstrStyleDesc = value.ToString();
 AddUpdatedFld(convcss_TemplateStyle.StyleDesc);
}
else if (strAttributeName  ==  convcss_TemplateStyle.StyleContent)
{
mstrStyleContent = value.ToString();
 AddUpdatedFld(convcss_TemplateStyle.StyleContent);
}
else if (strAttributeName  ==  convcss_TemplateStyle.TemplateId)
{
mstrTemplateId = value.ToString();
 AddUpdatedFld(convcss_TemplateStyle.TemplateId);
}
else if (strAttributeName  ==  convcss_TemplateStyle.TemplateName)
{
mstrTemplateName = value.ToString();
 AddUpdatedFld(convcss_TemplateStyle.TemplateName);
}
else if (strAttributeName  ==  convcss_TemplateStyle.TemplateDesc)
{
mstrTemplateDesc = value.ToString();
 AddUpdatedFld(convcss_TemplateStyle.TemplateDesc);
}
else if (strAttributeName  ==  convcss_TemplateStyle.TemplatePic)
{
mstrTemplatePic = value.ToString();
 AddUpdatedFld(convcss_TemplateStyle.TemplatePic);
}
else if (strAttributeName  ==  convcss_TemplateStyle.IsPublic)
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(convcss_TemplateStyle.IsPublic);
}
else if (strAttributeName  ==  convcss_TemplateStyle.TemplateStyleName)
{
mstrTemplateStyleName = value.ToString();
 AddUpdatedFld(convcss_TemplateStyle.TemplateStyleName);
}
else if (strAttributeName  ==  convcss_TemplateStyle.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convcss_TemplateStyle.UpdDate);
}
else if (strAttributeName  ==  convcss_TemplateStyle.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convcss_TemplateStyle.UpdUser);
}
else if (strAttributeName  ==  convcss_TemplateStyle.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convcss_TemplateStyle.Memo);
}
else if (strAttributeName  ==  convcss_TemplateStyle.TemplateStyleNameEn)
{
mstrTemplateStyleNameEn = value.ToString();
 AddUpdatedFld(convcss_TemplateStyle.TemplateStyleNameEn);
}
else if (strAttributeName  ==  convcss_TemplateStyle.cssModuleAreaId)
{
mstrcssModuleAreaId = value.ToString();
 AddUpdatedFld(convcss_TemplateStyle.cssModuleAreaId);
}
else if (strAttributeName  ==  convcss_TemplateStyle.ModuleAreaName)
{
mstrModuleAreaName = value.ToString();
 AddUpdatedFld(convcss_TemplateStyle.ModuleAreaName);
}
else if (strAttributeName  ==  convcss_TemplateStyle.IsDelete)
{
mbolIsDelete = TransNullToBool(value.ToString());
 AddUpdatedFld(convcss_TemplateStyle.IsDelete);
}
}
}
public object this[int intIndex]
{
get
{
if (convcss_TemplateStyle.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convcss_TemplateStyle.StyleId  ==  AttributeName[intIndex])
{
return mstrStyleId;
}
else if (convcss_TemplateStyle.ControlId  ==  AttributeName[intIndex])
{
return mstrControlId;
}
else if (convcss_TemplateStyle.ControlName  ==  AttributeName[intIndex])
{
return mstrControlName;
}
else if (convcss_TemplateStyle.StyleName  ==  AttributeName[intIndex])
{
return mstrStyleName;
}
else if (convcss_TemplateStyle.StyleDesc  ==  AttributeName[intIndex])
{
return mstrStyleDesc;
}
else if (convcss_TemplateStyle.StyleContent  ==  AttributeName[intIndex])
{
return mstrStyleContent;
}
else if (convcss_TemplateStyle.TemplateId  ==  AttributeName[intIndex])
{
return mstrTemplateId;
}
else if (convcss_TemplateStyle.TemplateName  ==  AttributeName[intIndex])
{
return mstrTemplateName;
}
else if (convcss_TemplateStyle.TemplateDesc  ==  AttributeName[intIndex])
{
return mstrTemplateDesc;
}
else if (convcss_TemplateStyle.TemplatePic  ==  AttributeName[intIndex])
{
return mstrTemplatePic;
}
else if (convcss_TemplateStyle.IsPublic  ==  AttributeName[intIndex])
{
return mbolIsPublic;
}
else if (convcss_TemplateStyle.TemplateStyleName  ==  AttributeName[intIndex])
{
return mstrTemplateStyleName;
}
else if (convcss_TemplateStyle.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convcss_TemplateStyle.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convcss_TemplateStyle.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convcss_TemplateStyle.TemplateStyleNameEn  ==  AttributeName[intIndex])
{
return mstrTemplateStyleNameEn;
}
else if (convcss_TemplateStyle.cssModuleAreaId  ==  AttributeName[intIndex])
{
return mstrcssModuleAreaId;
}
else if (convcss_TemplateStyle.ModuleAreaName  ==  AttributeName[intIndex])
{
return mstrModuleAreaName;
}
else if (convcss_TemplateStyle.IsDelete  ==  AttributeName[intIndex])
{
return mbolIsDelete;
}
return null;
}
set
{
if (convcss_TemplateStyle.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convcss_TemplateStyle.mId);
}
else if (convcss_TemplateStyle.StyleId  ==  AttributeName[intIndex])
{
mstrStyleId = value.ToString();
 AddUpdatedFld(convcss_TemplateStyle.StyleId);
}
else if (convcss_TemplateStyle.ControlId  ==  AttributeName[intIndex])
{
mstrControlId = value.ToString();
 AddUpdatedFld(convcss_TemplateStyle.ControlId);
}
else if (convcss_TemplateStyle.ControlName  ==  AttributeName[intIndex])
{
mstrControlName = value.ToString();
 AddUpdatedFld(convcss_TemplateStyle.ControlName);
}
else if (convcss_TemplateStyle.StyleName  ==  AttributeName[intIndex])
{
mstrStyleName = value.ToString();
 AddUpdatedFld(convcss_TemplateStyle.StyleName);
}
else if (convcss_TemplateStyle.StyleDesc  ==  AttributeName[intIndex])
{
mstrStyleDesc = value.ToString();
 AddUpdatedFld(convcss_TemplateStyle.StyleDesc);
}
else if (convcss_TemplateStyle.StyleContent  ==  AttributeName[intIndex])
{
mstrStyleContent = value.ToString();
 AddUpdatedFld(convcss_TemplateStyle.StyleContent);
}
else if (convcss_TemplateStyle.TemplateId  ==  AttributeName[intIndex])
{
mstrTemplateId = value.ToString();
 AddUpdatedFld(convcss_TemplateStyle.TemplateId);
}
else if (convcss_TemplateStyle.TemplateName  ==  AttributeName[intIndex])
{
mstrTemplateName = value.ToString();
 AddUpdatedFld(convcss_TemplateStyle.TemplateName);
}
else if (convcss_TemplateStyle.TemplateDesc  ==  AttributeName[intIndex])
{
mstrTemplateDesc = value.ToString();
 AddUpdatedFld(convcss_TemplateStyle.TemplateDesc);
}
else if (convcss_TemplateStyle.TemplatePic  ==  AttributeName[intIndex])
{
mstrTemplatePic = value.ToString();
 AddUpdatedFld(convcss_TemplateStyle.TemplatePic);
}
else if (convcss_TemplateStyle.IsPublic  ==  AttributeName[intIndex])
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(convcss_TemplateStyle.IsPublic);
}
else if (convcss_TemplateStyle.TemplateStyleName  ==  AttributeName[intIndex])
{
mstrTemplateStyleName = value.ToString();
 AddUpdatedFld(convcss_TemplateStyle.TemplateStyleName);
}
else if (convcss_TemplateStyle.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convcss_TemplateStyle.UpdDate);
}
else if (convcss_TemplateStyle.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convcss_TemplateStyle.UpdUser);
}
else if (convcss_TemplateStyle.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convcss_TemplateStyle.Memo);
}
else if (convcss_TemplateStyle.TemplateStyleNameEn  ==  AttributeName[intIndex])
{
mstrTemplateStyleNameEn = value.ToString();
 AddUpdatedFld(convcss_TemplateStyle.TemplateStyleNameEn);
}
else if (convcss_TemplateStyle.cssModuleAreaId  ==  AttributeName[intIndex])
{
mstrcssModuleAreaId = value.ToString();
 AddUpdatedFld(convcss_TemplateStyle.cssModuleAreaId);
}
else if (convcss_TemplateStyle.ModuleAreaName  ==  AttributeName[intIndex])
{
mstrModuleAreaName = value.ToString();
 AddUpdatedFld(convcss_TemplateStyle.ModuleAreaName);
}
else if (convcss_TemplateStyle.IsDelete  ==  AttributeName[intIndex])
{
mbolIsDelete = TransNullToBool(value.ToString());
 AddUpdatedFld(convcss_TemplateStyle.IsDelete);
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
 AddUpdatedFld(convcss_TemplateStyle.mId);
}
}
/// <summary>
/// 样式ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StyleId
{
get
{
return mstrStyleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStyleId = value;
}
else
{
 mstrStyleId = value;
}
//记录修改过的字段
 AddUpdatedFld(convcss_TemplateStyle.StyleId);
}
}
/// <summary>
/// 控件ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ControlId
{
get
{
return mstrControlId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrControlId = value;
}
else
{
 mstrControlId = value;
}
//记录修改过的字段
 AddUpdatedFld(convcss_TemplateStyle.ControlId);
}
}
/// <summary>
/// 控件名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ControlName
{
get
{
return mstrControlName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrControlName = value;
}
else
{
 mstrControlName = value;
}
//记录修改过的字段
 AddUpdatedFld(convcss_TemplateStyle.ControlName);
}
}
/// <summary>
/// 样式名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StyleName
{
get
{
return mstrStyleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStyleName = value;
}
else
{
 mstrStyleName = value;
}
//记录修改过的字段
 AddUpdatedFld(convcss_TemplateStyle.StyleName);
}
}
/// <summary>
/// 样式描述(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StyleDesc
{
get
{
return mstrStyleDesc;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStyleDesc = value;
}
else
{
 mstrStyleDesc = value;
}
//记录修改过的字段
 AddUpdatedFld(convcss_TemplateStyle.StyleDesc);
}
}
/// <summary>
/// 样式内容(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StyleContent
{
get
{
return mstrStyleContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStyleContent = value;
}
else
{
 mstrStyleContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convcss_TemplateStyle.StyleContent);
}
}
/// <summary>
/// 模板ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TemplateId
{
get
{
return mstrTemplateId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTemplateId = value;
}
else
{
 mstrTemplateId = value;
}
//记录修改过的字段
 AddUpdatedFld(convcss_TemplateStyle.TemplateId);
}
}
/// <summary>
/// 模板名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TemplateName
{
get
{
return mstrTemplateName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTemplateName = value;
}
else
{
 mstrTemplateName = value;
}
//记录修改过的字段
 AddUpdatedFld(convcss_TemplateStyle.TemplateName);
}
}
/// <summary>
/// 模板描述(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TemplateDesc
{
get
{
return mstrTemplateDesc;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTemplateDesc = value;
}
else
{
 mstrTemplateDesc = value;
}
//记录修改过的字段
 AddUpdatedFld(convcss_TemplateStyle.TemplateDesc);
}
}
/// <summary>
/// 模板图片(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TemplatePic
{
get
{
return mstrTemplatePic;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTemplatePic = value;
}
else
{
 mstrTemplatePic = value;
}
//记录修改过的字段
 AddUpdatedFld(convcss_TemplateStyle.TemplatePic);
}
}
/// <summary>
/// 是否公开(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsPublic
{
get
{
return mbolIsPublic;
}
set
{
 mbolIsPublic = value;
//记录修改过的字段
 AddUpdatedFld(convcss_TemplateStyle.IsPublic);
}
}
/// <summary>
/// 模板样式名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TemplateStyleName
{
get
{
return mstrTemplateStyleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTemplateStyleName = value;
}
else
{
 mstrTemplateStyleName = value;
}
//记录修改过的字段
 AddUpdatedFld(convcss_TemplateStyle.TemplateStyleName);
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
 AddUpdatedFld(convcss_TemplateStyle.UpdDate);
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
 AddUpdatedFld(convcss_TemplateStyle.UpdUser);
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
 AddUpdatedFld(convcss_TemplateStyle.Memo);
}
}
/// <summary>
/// 模板样式英文(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TemplateStyleNameEn
{
get
{
return mstrTemplateStyleNameEn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTemplateStyleNameEn = value;
}
else
{
 mstrTemplateStyleNameEn = value;
}
//记录修改过的字段
 AddUpdatedFld(convcss_TemplateStyle.TemplateStyleNameEn);
}
}
/// <summary>
/// 区域主键(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string cssModuleAreaId
{
get
{
return mstrcssModuleAreaId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrcssModuleAreaId = value;
}
else
{
 mstrcssModuleAreaId = value;
}
//记录修改过的字段
 AddUpdatedFld(convcss_TemplateStyle.cssModuleAreaId);
}
}
/// <summary>
/// 区域名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ModuleAreaName
{
get
{
return mstrModuleAreaName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrModuleAreaName = value;
}
else
{
 mstrModuleAreaName = value;
}
//记录修改过的字段
 AddUpdatedFld(convcss_TemplateStyle.ModuleAreaName);
}
}
/// <summary>
/// IsDelete(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsDelete
{
get
{
return mbolIsDelete;
}
set
{
 mbolIsDelete = value;
//记录修改过的字段
 AddUpdatedFld(convcss_TemplateStyle.IsDelete);
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
  return mlngmId.ToString();
 }
 }
}
 /// <summary>
 /// vcss_TemplateStyle(vcss_TemplateStyle)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convcss_TemplateStyle
{
public new const string _CurrTabName = "vcss_TemplateStyle"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "StyleId", "ControlId", "ControlName", "StyleName", "StyleDesc", "StyleContent", "TemplateId", "TemplateName", "TemplateDesc", "TemplatePic", "IsPublic", "TemplateStyleName", "UpdDate", "UpdUser", "Memo", "TemplateStyleNameEn", "cssModuleAreaId", "ModuleAreaName", "IsDelete"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"StyleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StyleId = "StyleId";    //样式ID

 /// <summary>
 /// 常量:"ControlId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ControlId = "ControlId";    //控件ID

 /// <summary>
 /// 常量:"ControlName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ControlName = "ControlName";    //控件名称

 /// <summary>
 /// 常量:"StyleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StyleName = "StyleName";    //样式名称

 /// <summary>
 /// 常量:"StyleDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StyleDesc = "StyleDesc";    //样式描述

 /// <summary>
 /// 常量:"StyleContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StyleContent = "StyleContent";    //样式内容

 /// <summary>
 /// 常量:"TemplateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TemplateId = "TemplateId";    //模板ID

 /// <summary>
 /// 常量:"TemplateName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TemplateName = "TemplateName";    //模板名称

 /// <summary>
 /// 常量:"TemplateDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TemplateDesc = "TemplateDesc";    //模板描述

 /// <summary>
 /// 常量:"TemplatePic"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TemplatePic = "TemplatePic";    //模板图片

 /// <summary>
 /// 常量:"IsPublic"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsPublic = "IsPublic";    //是否公开

 /// <summary>
 /// 常量:"TemplateStyleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TemplateStyleName = "TemplateStyleName";    //模板样式名称

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改者

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明

 /// <summary>
 /// 常量:"TemplateStyleNameEn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TemplateStyleNameEn = "TemplateStyleNameEn";    //模板样式英文

 /// <summary>
 /// 常量:"cssModuleAreaId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string cssModuleAreaId = "cssModuleAreaId";    //区域主键

 /// <summary>
 /// 常量:"ModuleAreaName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ModuleAreaName = "ModuleAreaName";    //区域名称

 /// <summary>
 /// 常量:"IsDelete"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDelete = "IsDelete";    //IsDelete
}

}