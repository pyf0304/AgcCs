
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscss_TemplateEN
 表名:css_Template(00050469)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:35:12
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:样式表管理(CssManage)
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
 /// 表css_Template的关键字(TemplateId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TemplateId_css_Template
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strTemplateId">表关键字</param>
public K_TemplateId_css_Template(string strTemplateId)
{
if (IsValid(strTemplateId)) Value = strTemplateId;
else
{
Value = null;
}
}
private static bool IsValid(string strTemplateId)
{
if (string.IsNullOrEmpty(strTemplateId) == true) return false;
if (strTemplateId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_TemplateId_css_Template]类型的对象</returns>
public static implicit operator K_TemplateId_css_Template(string value)
{
return new K_TemplateId_css_Template(value);
}
}
 /// <summary>
 /// css_Template(css_Template)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clscss_TemplateEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "css_Template"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TemplateId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 11;
public static string[] _AttributeName = new string[] {"TemplateId", "TemplateName", "TemplateDesc", "OrderNum", "TemplatePic", "IsPublic", "IsDeleted", "DeletedDate", "UpdDate", "UpdUser", "Memo"};

protected string mstrTemplateId;    //模板ID
protected string mstrTemplateName;    //模板名称
protected string mstrTemplateDesc;    //模板描述
protected int? mintOrderNum;    //序号
protected string mstrTemplatePic;    //模板图片
protected bool mbolIsPublic;    //是否公开
protected bool mbolIsDeleted;    //是否删除
protected string mstrDeletedDate;    //删除日期
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clscss_TemplateEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TemplateId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strTemplateId">关键字:模板ID</param>
public clscss_TemplateEN(string strTemplateId)
 {
strTemplateId = strTemplateId.Replace("'", "''");
if (strTemplateId.Length > 8)
{
throw new Exception("在表:css_Template中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTemplateId)  ==  true)
{
throw new Exception("在表:css_Template中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTemplateId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrTemplateId = strTemplateId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TemplateId");
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
if (strAttributeName  ==  concss_Template.TemplateId)
{
return mstrTemplateId;
}
else if (strAttributeName  ==  concss_Template.TemplateName)
{
return mstrTemplateName;
}
else if (strAttributeName  ==  concss_Template.TemplateDesc)
{
return mstrTemplateDesc;
}
else if (strAttributeName  ==  concss_Template.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  concss_Template.TemplatePic)
{
return mstrTemplatePic;
}
else if (strAttributeName  ==  concss_Template.IsPublic)
{
return mbolIsPublic;
}
else if (strAttributeName  ==  concss_Template.IsDeleted)
{
return mbolIsDeleted;
}
else if (strAttributeName  ==  concss_Template.DeletedDate)
{
return mstrDeletedDate;
}
else if (strAttributeName  ==  concss_Template.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  concss_Template.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  concss_Template.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  concss_Template.TemplateId)
{
mstrTemplateId = value.ToString();
 AddUpdatedFld(concss_Template.TemplateId);
}
else if (strAttributeName  ==  concss_Template.TemplateName)
{
mstrTemplateName = value.ToString();
 AddUpdatedFld(concss_Template.TemplateName);
}
else if (strAttributeName  ==  concss_Template.TemplateDesc)
{
mstrTemplateDesc = value.ToString();
 AddUpdatedFld(concss_Template.TemplateDesc);
}
else if (strAttributeName  ==  concss_Template.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(concss_Template.OrderNum);
}
else if (strAttributeName  ==  concss_Template.TemplatePic)
{
mstrTemplatePic = value.ToString();
 AddUpdatedFld(concss_Template.TemplatePic);
}
else if (strAttributeName  ==  concss_Template.IsPublic)
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(concss_Template.IsPublic);
}
else if (strAttributeName  ==  concss_Template.IsDeleted)
{
mbolIsDeleted = TransNullToBool(value.ToString());
 AddUpdatedFld(concss_Template.IsDeleted);
}
else if (strAttributeName  ==  concss_Template.DeletedDate)
{
mstrDeletedDate = value.ToString();
 AddUpdatedFld(concss_Template.DeletedDate);
}
else if (strAttributeName  ==  concss_Template.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concss_Template.UpdDate);
}
else if (strAttributeName  ==  concss_Template.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(concss_Template.UpdUser);
}
else if (strAttributeName  ==  concss_Template.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(concss_Template.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (concss_Template.TemplateId  ==  _AttributeName[intIndex])
{
return mstrTemplateId;
}
else if (concss_Template.TemplateName  ==  _AttributeName[intIndex])
{
return mstrTemplateName;
}
else if (concss_Template.TemplateDesc  ==  _AttributeName[intIndex])
{
return mstrTemplateDesc;
}
else if (concss_Template.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (concss_Template.TemplatePic  ==  _AttributeName[intIndex])
{
return mstrTemplatePic;
}
else if (concss_Template.IsPublic  ==  _AttributeName[intIndex])
{
return mbolIsPublic;
}
else if (concss_Template.IsDeleted  ==  _AttributeName[intIndex])
{
return mbolIsDeleted;
}
else if (concss_Template.DeletedDate  ==  _AttributeName[intIndex])
{
return mstrDeletedDate;
}
else if (concss_Template.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (concss_Template.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (concss_Template.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (concss_Template.TemplateId  ==  _AttributeName[intIndex])
{
mstrTemplateId = value.ToString();
 AddUpdatedFld(concss_Template.TemplateId);
}
else if (concss_Template.TemplateName  ==  _AttributeName[intIndex])
{
mstrTemplateName = value.ToString();
 AddUpdatedFld(concss_Template.TemplateName);
}
else if (concss_Template.TemplateDesc  ==  _AttributeName[intIndex])
{
mstrTemplateDesc = value.ToString();
 AddUpdatedFld(concss_Template.TemplateDesc);
}
else if (concss_Template.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(concss_Template.OrderNum);
}
else if (concss_Template.TemplatePic  ==  _AttributeName[intIndex])
{
mstrTemplatePic = value.ToString();
 AddUpdatedFld(concss_Template.TemplatePic);
}
else if (concss_Template.IsPublic  ==  _AttributeName[intIndex])
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(concss_Template.IsPublic);
}
else if (concss_Template.IsDeleted  ==  _AttributeName[intIndex])
{
mbolIsDeleted = TransNullToBool(value.ToString());
 AddUpdatedFld(concss_Template.IsDeleted);
}
else if (concss_Template.DeletedDate  ==  _AttributeName[intIndex])
{
mstrDeletedDate = value.ToString();
 AddUpdatedFld(concss_Template.DeletedDate);
}
else if (concss_Template.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concss_Template.UpdDate);
}
else if (concss_Template.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(concss_Template.UpdUser);
}
else if (concss_Template.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(concss_Template.Memo);
}
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
 AddUpdatedFld(concss_Template.TemplateId);
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
 AddUpdatedFld(concss_Template.TemplateName);
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
 AddUpdatedFld(concss_Template.TemplateDesc);
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
 AddUpdatedFld(concss_Template.OrderNum);
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
 AddUpdatedFld(concss_Template.TemplatePic);
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
 AddUpdatedFld(concss_Template.IsPublic);
}
}
/// <summary>
/// 是否删除(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsDeleted
{
get
{
return mbolIsDeleted;
}
set
{
 mbolIsDeleted = value;
//记录修改过的字段
 AddUpdatedFld(concss_Template.IsDeleted);
}
}
/// <summary>
/// 删除日期(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DeletedDate
{
get
{
return mstrDeletedDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDeletedDate = value;
}
else
{
 mstrDeletedDate = value;
}
//记录修改过的字段
 AddUpdatedFld(concss_Template.DeletedDate);
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
 AddUpdatedFld(concss_Template.UpdDate);
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
 AddUpdatedFld(concss_Template.UpdUser);
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
 AddUpdatedFld(concss_Template.Memo);
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
  return mstrTemplateId;
 }
 }
}
 /// <summary>
 /// css_Template(css_Template)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class concss_Template
{
public const string _CurrTabName = "css_Template"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TemplateId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"TemplateId", "TemplateName", "TemplateDesc", "OrderNum", "TemplatePic", "IsPublic", "IsDeleted", "DeletedDate", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


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
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

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
 /// 常量:"IsDeleted"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDeleted = "IsDeleted";    //是否删除

 /// <summary>
 /// 常量:"DeletedDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DeletedDate = "DeletedDate";    //删除日期

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
}

}