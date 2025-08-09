
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscss_ModuleAreaEN
 表名:css_ModuleArea(00050477)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:07:01
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
 /// 表css_ModuleArea的关键字(cssModuleAreaId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_cssModuleAreaId_css_ModuleArea
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strcssModuleAreaId">表关键字</param>
public K_cssModuleAreaId_css_ModuleArea(string strcssModuleAreaId)
{
if (IsValid(strcssModuleAreaId)) Value = strcssModuleAreaId;
else
{
Value = null;
}
}
private static bool IsValid(string strcssModuleAreaId)
{
if (string.IsNullOrEmpty(strcssModuleAreaId) == true) return false;
if (strcssModuleAreaId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_cssModuleAreaId_css_ModuleArea]类型的对象</returns>
public static implicit operator K_cssModuleAreaId_css_ModuleArea(string value)
{
return new K_cssModuleAreaId_css_ModuleArea(value);
}
}
 /// <summary>
 /// 模块区域(css_ModuleArea)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clscss_ModuleAreaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "css_ModuleArea"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "cssModuleAreaId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 5;
public static string[] _AttributeName = new string[] {"cssModuleAreaId", "ModuleAreaName", "UpdUser", "UpdDate", "Memo"};

protected string mstrcssModuleAreaId;    //区域主键
protected string mstrModuleAreaName;    //区域名称
protected string mstrUpdUser;    //修改者
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clscss_ModuleAreaEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("cssModuleAreaId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strcssModuleAreaId">关键字:区域主键</param>
public clscss_ModuleAreaEN(string strcssModuleAreaId)
 {
strcssModuleAreaId = strcssModuleAreaId.Replace("'", "''");
if (strcssModuleAreaId.Length > 8)
{
throw new Exception("在表:css_ModuleArea中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strcssModuleAreaId)  ==  true)
{
throw new Exception("在表:css_ModuleArea中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strcssModuleAreaId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrcssModuleAreaId = strcssModuleAreaId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("cssModuleAreaId");
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
if (strAttributeName  ==  concss_ModuleArea.cssModuleAreaId)
{
return mstrcssModuleAreaId;
}
else if (strAttributeName  ==  concss_ModuleArea.ModuleAreaName)
{
return mstrModuleAreaName;
}
else if (strAttributeName  ==  concss_ModuleArea.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  concss_ModuleArea.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  concss_ModuleArea.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  concss_ModuleArea.cssModuleAreaId)
{
mstrcssModuleAreaId = value.ToString();
 AddUpdatedFld(concss_ModuleArea.cssModuleAreaId);
}
else if (strAttributeName  ==  concss_ModuleArea.ModuleAreaName)
{
mstrModuleAreaName = value.ToString();
 AddUpdatedFld(concss_ModuleArea.ModuleAreaName);
}
else if (strAttributeName  ==  concss_ModuleArea.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(concss_ModuleArea.UpdUser);
}
else if (strAttributeName  ==  concss_ModuleArea.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concss_ModuleArea.UpdDate);
}
else if (strAttributeName  ==  concss_ModuleArea.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(concss_ModuleArea.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (concss_ModuleArea.cssModuleAreaId  ==  _AttributeName[intIndex])
{
return mstrcssModuleAreaId;
}
else if (concss_ModuleArea.ModuleAreaName  ==  _AttributeName[intIndex])
{
return mstrModuleAreaName;
}
else if (concss_ModuleArea.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (concss_ModuleArea.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (concss_ModuleArea.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (concss_ModuleArea.cssModuleAreaId  ==  _AttributeName[intIndex])
{
mstrcssModuleAreaId = value.ToString();
 AddUpdatedFld(concss_ModuleArea.cssModuleAreaId);
}
else if (concss_ModuleArea.ModuleAreaName  ==  _AttributeName[intIndex])
{
mstrModuleAreaName = value.ToString();
 AddUpdatedFld(concss_ModuleArea.ModuleAreaName);
}
else if (concss_ModuleArea.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(concss_ModuleArea.UpdUser);
}
else if (concss_ModuleArea.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concss_ModuleArea.UpdDate);
}
else if (concss_ModuleArea.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(concss_ModuleArea.Memo);
}
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
 AddUpdatedFld(concss_ModuleArea.cssModuleAreaId);
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
 AddUpdatedFld(concss_ModuleArea.ModuleAreaName);
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
 AddUpdatedFld(concss_ModuleArea.UpdUser);
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
 AddUpdatedFld(concss_ModuleArea.UpdDate);
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
 AddUpdatedFld(concss_ModuleArea.Memo);
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
  return mstrcssModuleAreaId;
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
  return mstrModuleAreaName;
 }
 }
}
 /// <summary>
 /// 模块区域(css_ModuleArea)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class concss_ModuleArea
{
public const string _CurrTabName = "css_ModuleArea"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "cssModuleAreaId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"cssModuleAreaId", "ModuleAreaName", "UpdUser", "UpdDate", "Memo"};
//以下是属性变量


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