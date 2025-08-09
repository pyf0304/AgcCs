
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscss_TemplateStyleEN
 表名:css_TemplateStyle(00050470)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:10:16
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
 /// 表css_TemplateStyle的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_css_TemplateStyle
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
public K_mId_css_TemplateStyle(long lngmId)
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
 /// <returns>返回:[K_mId_css_TemplateStyle]类型的对象</returns>
public static implicit operator K_mId_css_TemplateStyle(long value)
{
return new K_mId_css_TemplateStyle(value);
}
}
 /// <summary>
 /// css_TemplateStyle(css_TemplateStyle)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clscss_TemplateStyleEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "css_TemplateStyle"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 10;
public static string[] _AttributeName = new string[] {"mId", "StyleId", "TemplateId", "cssModuleAreaId", "TemplateStyleName", "UpdDate", "UpdUser", "Memo", "TemplateStyleNameEn", "IsDelete"};

protected long mlngmId;    //mId
protected string mstrStyleId;    //样式ID
protected string mstrTemplateId;    //模板ID
protected string mstrcssModuleAreaId;    //区域主键
protected string mstrTemplateStyleName;    //模板样式名称
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明
protected string mstrTemplateStyleNameEn;    //模板样式英文
protected bool mbolIsDelete;    //IsDelete

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clscss_TemplateStyleEN()
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
public clscss_TemplateStyleEN(long lngmId)
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
if (strAttributeName  ==  concss_TemplateStyle.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  concss_TemplateStyle.StyleId)
{
return mstrStyleId;
}
else if (strAttributeName  ==  concss_TemplateStyle.TemplateId)
{
return mstrTemplateId;
}
else if (strAttributeName  ==  concss_TemplateStyle.cssModuleAreaId)
{
return mstrcssModuleAreaId;
}
else if (strAttributeName  ==  concss_TemplateStyle.TemplateStyleName)
{
return mstrTemplateStyleName;
}
else if (strAttributeName  ==  concss_TemplateStyle.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  concss_TemplateStyle.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  concss_TemplateStyle.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  concss_TemplateStyle.TemplateStyleNameEn)
{
return mstrTemplateStyleNameEn;
}
else if (strAttributeName  ==  concss_TemplateStyle.IsDelete)
{
return mbolIsDelete;
}
return null;
}
set
{
if (strAttributeName  ==  concss_TemplateStyle.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(concss_TemplateStyle.mId);
}
else if (strAttributeName  ==  concss_TemplateStyle.StyleId)
{
mstrStyleId = value.ToString();
 AddUpdatedFld(concss_TemplateStyle.StyleId);
}
else if (strAttributeName  ==  concss_TemplateStyle.TemplateId)
{
mstrTemplateId = value.ToString();
 AddUpdatedFld(concss_TemplateStyle.TemplateId);
}
else if (strAttributeName  ==  concss_TemplateStyle.cssModuleAreaId)
{
mstrcssModuleAreaId = value.ToString();
 AddUpdatedFld(concss_TemplateStyle.cssModuleAreaId);
}
else if (strAttributeName  ==  concss_TemplateStyle.TemplateStyleName)
{
mstrTemplateStyleName = value.ToString();
 AddUpdatedFld(concss_TemplateStyle.TemplateStyleName);
}
else if (strAttributeName  ==  concss_TemplateStyle.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concss_TemplateStyle.UpdDate);
}
else if (strAttributeName  ==  concss_TemplateStyle.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(concss_TemplateStyle.UpdUser);
}
else if (strAttributeName  ==  concss_TemplateStyle.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(concss_TemplateStyle.Memo);
}
else if (strAttributeName  ==  concss_TemplateStyle.TemplateStyleNameEn)
{
mstrTemplateStyleNameEn = value.ToString();
 AddUpdatedFld(concss_TemplateStyle.TemplateStyleNameEn);
}
else if (strAttributeName  ==  concss_TemplateStyle.IsDelete)
{
mbolIsDelete = TransNullToBool(value.ToString());
 AddUpdatedFld(concss_TemplateStyle.IsDelete);
}
}
}
public object this[int intIndex]
{
get
{
if (concss_TemplateStyle.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (concss_TemplateStyle.StyleId  ==  _AttributeName[intIndex])
{
return mstrStyleId;
}
else if (concss_TemplateStyle.TemplateId  ==  _AttributeName[intIndex])
{
return mstrTemplateId;
}
else if (concss_TemplateStyle.cssModuleAreaId  ==  _AttributeName[intIndex])
{
return mstrcssModuleAreaId;
}
else if (concss_TemplateStyle.TemplateStyleName  ==  _AttributeName[intIndex])
{
return mstrTemplateStyleName;
}
else if (concss_TemplateStyle.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (concss_TemplateStyle.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (concss_TemplateStyle.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (concss_TemplateStyle.TemplateStyleNameEn  ==  _AttributeName[intIndex])
{
return mstrTemplateStyleNameEn;
}
else if (concss_TemplateStyle.IsDelete  ==  _AttributeName[intIndex])
{
return mbolIsDelete;
}
return null;
}
set
{
if (concss_TemplateStyle.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(concss_TemplateStyle.mId);
}
else if (concss_TemplateStyle.StyleId  ==  _AttributeName[intIndex])
{
mstrStyleId = value.ToString();
 AddUpdatedFld(concss_TemplateStyle.StyleId);
}
else if (concss_TemplateStyle.TemplateId  ==  _AttributeName[intIndex])
{
mstrTemplateId = value.ToString();
 AddUpdatedFld(concss_TemplateStyle.TemplateId);
}
else if (concss_TemplateStyle.cssModuleAreaId  ==  _AttributeName[intIndex])
{
mstrcssModuleAreaId = value.ToString();
 AddUpdatedFld(concss_TemplateStyle.cssModuleAreaId);
}
else if (concss_TemplateStyle.TemplateStyleName  ==  _AttributeName[intIndex])
{
mstrTemplateStyleName = value.ToString();
 AddUpdatedFld(concss_TemplateStyle.TemplateStyleName);
}
else if (concss_TemplateStyle.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concss_TemplateStyle.UpdDate);
}
else if (concss_TemplateStyle.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(concss_TemplateStyle.UpdUser);
}
else if (concss_TemplateStyle.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(concss_TemplateStyle.Memo);
}
else if (concss_TemplateStyle.TemplateStyleNameEn  ==  _AttributeName[intIndex])
{
mstrTemplateStyleNameEn = value.ToString();
 AddUpdatedFld(concss_TemplateStyle.TemplateStyleNameEn);
}
else if (concss_TemplateStyle.IsDelete  ==  _AttributeName[intIndex])
{
mbolIsDelete = TransNullToBool(value.ToString());
 AddUpdatedFld(concss_TemplateStyle.IsDelete);
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
 AddUpdatedFld(concss_TemplateStyle.mId);
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
 AddUpdatedFld(concss_TemplateStyle.StyleId);
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
 AddUpdatedFld(concss_TemplateStyle.TemplateId);
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
 AddUpdatedFld(concss_TemplateStyle.cssModuleAreaId);
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
 AddUpdatedFld(concss_TemplateStyle.TemplateStyleName);
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
 AddUpdatedFld(concss_TemplateStyle.UpdDate);
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
 AddUpdatedFld(concss_TemplateStyle.UpdUser);
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
 AddUpdatedFld(concss_TemplateStyle.Memo);
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
 AddUpdatedFld(concss_TemplateStyle.TemplateStyleNameEn);
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
 AddUpdatedFld(concss_TemplateStyle.IsDelete);
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
 /// css_TemplateStyle(css_TemplateStyle)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class concss_TemplateStyle
{
public const string _CurrTabName = "css_TemplateStyle"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "StyleId", "TemplateId", "cssModuleAreaId", "TemplateStyleName", "UpdDate", "UpdUser", "Memo", "TemplateStyleNameEn", "IsDelete"};
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
 /// 常量:"TemplateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TemplateId = "TemplateId";    //模板ID

 /// <summary>
 /// 常量:"cssModuleAreaId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string cssModuleAreaId = "cssModuleAreaId";    //区域主键

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
 /// 常量:"IsDelete"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDelete = "IsDelete";    //IsDelete
}

}