
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvWebSrvClass4GeneCodeEN
 表名:vWebSrvClass4GeneCode(00050372)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:03:57
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
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
 /// 表vWebSrvClass4GeneCode的关键字(WebSrvClassId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_WebSrvClassId_vWebSrvClass4GeneCode
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strWebSrvClassId">表关键字</param>
public K_WebSrvClassId_vWebSrvClass4GeneCode(string strWebSrvClassId)
{
if (IsValid(strWebSrvClassId)) Value = strWebSrvClassId;
else
{
Value = null;
}
}
private static bool IsValid(string strWebSrvClassId)
{
if (string.IsNullOrEmpty(strWebSrvClassId) == true) return false;
if (strWebSrvClassId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_WebSrvClassId_vWebSrvClass4GeneCode]类型的对象</returns>
public static implicit operator K_WebSrvClassId_vWebSrvClass4GeneCode(string value)
{
return new K_WebSrvClassId_vWebSrvClass4GeneCode(value);
}
}
 /// <summary>
 /// vWebSrvClass4GeneCode(vWebSrvClass4GeneCode)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvWebSrvClass4GeneCodeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vWebSrvClass4GeneCode"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "WebSrvClassId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 18;
public static string[] _AttributeName = new string[] {"WebSrvClassId", "UserName", "FuncNum", "GeneCodeDate", "VersionGeneCode", "NameSpace", "WebSrvUrl", "PageName", "FuncModuleAgcId", "FuncModuleName", "FuncModuleEnName", "IsNeedGene", "PrjId", "PrjName", "UpdDate", "Memo", "UserId4GeneCode", "ClsName"};

protected string mstrWebSrvClassId;    //类Id
protected string mstrUserName;    //用户名
protected int? mintFuncNum;    //函数个数
protected string mstrGeneCodeDate;    //生成代码日期
protected string mstrVersionGeneCode;    //生成代码版本
protected string mstrNameSpace;    //域名
protected string mstrWebSrvUrl;    //WebSrv地址
protected string mstrPageName;    //页面名称
protected string mstrFuncModuleAgcId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrFuncModuleEnName;    //功能模块英文名称
protected bool mbolIsNeedGene;    //是否需要生成
protected string mstrPrjId;    //工程Id
protected string mstrPrjName;    //工程名称
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //说明
protected string mstrUserId4GeneCode;    //UserId4GeneCode
protected string mstrClsName;    //类名

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvWebSrvClass4GeneCodeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("WebSrvClassId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strWebSrvClassId">关键字:类Id</param>
public clsvWebSrvClass4GeneCodeEN(string strWebSrvClassId)
 {
strWebSrvClassId = strWebSrvClassId.Replace("'", "''");
if (strWebSrvClassId.Length > 8)
{
throw new Exception("在表:vWebSrvClass4GeneCode中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strWebSrvClassId)  ==  true)
{
throw new Exception("在表:vWebSrvClass4GeneCode中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strWebSrvClassId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrWebSrvClassId = strWebSrvClassId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("WebSrvClassId");
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
if (strAttributeName  ==  convWebSrvClass4GeneCode.WebSrvClassId)
{
return mstrWebSrvClassId;
}
else if (strAttributeName  ==  convWebSrvClass4GeneCode.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convWebSrvClass4GeneCode.FuncNum)
{
return mintFuncNum;
}
else if (strAttributeName  ==  convWebSrvClass4GeneCode.GeneCodeDate)
{
return mstrGeneCodeDate;
}
else if (strAttributeName  ==  convWebSrvClass4GeneCode.VersionGeneCode)
{
return mstrVersionGeneCode;
}
else if (strAttributeName  ==  convWebSrvClass4GeneCode.NameSpace)
{
return mstrNameSpace;
}
else if (strAttributeName  ==  convWebSrvClass4GeneCode.WebSrvUrl)
{
return mstrWebSrvUrl;
}
else if (strAttributeName  ==  convWebSrvClass4GeneCode.PageName)
{
return mstrPageName;
}
else if (strAttributeName  ==  convWebSrvClass4GeneCode.FuncModuleAgcId)
{
return mstrFuncModuleAgcId;
}
else if (strAttributeName  ==  convWebSrvClass4GeneCode.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convWebSrvClass4GeneCode.FuncModuleEnName)
{
return mstrFuncModuleEnName;
}
else if (strAttributeName  ==  convWebSrvClass4GeneCode.IsNeedGene)
{
return mbolIsNeedGene;
}
else if (strAttributeName  ==  convWebSrvClass4GeneCode.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convWebSrvClass4GeneCode.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convWebSrvClass4GeneCode.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convWebSrvClass4GeneCode.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convWebSrvClass4GeneCode.UserId4GeneCode)
{
return mstrUserId4GeneCode;
}
else if (strAttributeName  ==  convWebSrvClass4GeneCode.ClsName)
{
return mstrClsName;
}
return null;
}
set
{
if (strAttributeName  ==  convWebSrvClass4GeneCode.WebSrvClassId)
{
mstrWebSrvClassId = value.ToString();
 AddUpdatedFld(convWebSrvClass4GeneCode.WebSrvClassId);
}
else if (strAttributeName  ==  convWebSrvClass4GeneCode.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convWebSrvClass4GeneCode.UserName);
}
else if (strAttributeName  ==  convWebSrvClass4GeneCode.FuncNum)
{
mintFuncNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convWebSrvClass4GeneCode.FuncNum);
}
else if (strAttributeName  ==  convWebSrvClass4GeneCode.GeneCodeDate)
{
mstrGeneCodeDate = value.ToString();
 AddUpdatedFld(convWebSrvClass4GeneCode.GeneCodeDate);
}
else if (strAttributeName  ==  convWebSrvClass4GeneCode.VersionGeneCode)
{
mstrVersionGeneCode = value.ToString();
 AddUpdatedFld(convWebSrvClass4GeneCode.VersionGeneCode);
}
else if (strAttributeName  ==  convWebSrvClass4GeneCode.NameSpace)
{
mstrNameSpace = value.ToString();
 AddUpdatedFld(convWebSrvClass4GeneCode.NameSpace);
}
else if (strAttributeName  ==  convWebSrvClass4GeneCode.WebSrvUrl)
{
mstrWebSrvUrl = value.ToString();
 AddUpdatedFld(convWebSrvClass4GeneCode.WebSrvUrl);
}
else if (strAttributeName  ==  convWebSrvClass4GeneCode.PageName)
{
mstrPageName = value.ToString();
 AddUpdatedFld(convWebSrvClass4GeneCode.PageName);
}
else if (strAttributeName  ==  convWebSrvClass4GeneCode.FuncModuleAgcId)
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convWebSrvClass4GeneCode.FuncModuleAgcId);
}
else if (strAttributeName  ==  convWebSrvClass4GeneCode.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convWebSrvClass4GeneCode.FuncModuleName);
}
else if (strAttributeName  ==  convWebSrvClass4GeneCode.FuncModuleEnName)
{
mstrFuncModuleEnName = value.ToString();
 AddUpdatedFld(convWebSrvClass4GeneCode.FuncModuleEnName);
}
else if (strAttributeName  ==  convWebSrvClass4GeneCode.IsNeedGene)
{
mbolIsNeedGene = TransNullToBool(value.ToString());
 AddUpdatedFld(convWebSrvClass4GeneCode.IsNeedGene);
}
else if (strAttributeName  ==  convWebSrvClass4GeneCode.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convWebSrvClass4GeneCode.PrjId);
}
else if (strAttributeName  ==  convWebSrvClass4GeneCode.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convWebSrvClass4GeneCode.PrjName);
}
else if (strAttributeName  ==  convWebSrvClass4GeneCode.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convWebSrvClass4GeneCode.UpdDate);
}
else if (strAttributeName  ==  convWebSrvClass4GeneCode.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convWebSrvClass4GeneCode.Memo);
}
else if (strAttributeName  ==  convWebSrvClass4GeneCode.UserId4GeneCode)
{
mstrUserId4GeneCode = value.ToString();
 AddUpdatedFld(convWebSrvClass4GeneCode.UserId4GeneCode);
}
else if (strAttributeName  ==  convWebSrvClass4GeneCode.ClsName)
{
mstrClsName = value.ToString();
 AddUpdatedFld(convWebSrvClass4GeneCode.ClsName);
}
}
}
public object this[int intIndex]
{
get
{
if (convWebSrvClass4GeneCode.WebSrvClassId  ==  _AttributeName[intIndex])
{
return mstrWebSrvClassId;
}
else if (convWebSrvClass4GeneCode.UserName  ==  _AttributeName[intIndex])
{
return mstrUserName;
}
else if (convWebSrvClass4GeneCode.FuncNum  ==  _AttributeName[intIndex])
{
return mintFuncNum;
}
else if (convWebSrvClass4GeneCode.GeneCodeDate  ==  _AttributeName[intIndex])
{
return mstrGeneCodeDate;
}
else if (convWebSrvClass4GeneCode.VersionGeneCode  ==  _AttributeName[intIndex])
{
return mstrVersionGeneCode;
}
else if (convWebSrvClass4GeneCode.NameSpace  ==  _AttributeName[intIndex])
{
return mstrNameSpace;
}
else if (convWebSrvClass4GeneCode.WebSrvUrl  ==  _AttributeName[intIndex])
{
return mstrWebSrvUrl;
}
else if (convWebSrvClass4GeneCode.PageName  ==  _AttributeName[intIndex])
{
return mstrPageName;
}
else if (convWebSrvClass4GeneCode.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
return mstrFuncModuleAgcId;
}
else if (convWebSrvClass4GeneCode.FuncModuleName  ==  _AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convWebSrvClass4GeneCode.FuncModuleEnName  ==  _AttributeName[intIndex])
{
return mstrFuncModuleEnName;
}
else if (convWebSrvClass4GeneCode.IsNeedGene  ==  _AttributeName[intIndex])
{
return mbolIsNeedGene;
}
else if (convWebSrvClass4GeneCode.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convWebSrvClass4GeneCode.PrjName  ==  _AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convWebSrvClass4GeneCode.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convWebSrvClass4GeneCode.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (convWebSrvClass4GeneCode.UserId4GeneCode  ==  _AttributeName[intIndex])
{
return mstrUserId4GeneCode;
}
else if (convWebSrvClass4GeneCode.ClsName  ==  _AttributeName[intIndex])
{
return mstrClsName;
}
return null;
}
set
{
if (convWebSrvClass4GeneCode.WebSrvClassId  ==  _AttributeName[intIndex])
{
mstrWebSrvClassId = value.ToString();
 AddUpdatedFld(convWebSrvClass4GeneCode.WebSrvClassId);
}
else if (convWebSrvClass4GeneCode.UserName  ==  _AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convWebSrvClass4GeneCode.UserName);
}
else if (convWebSrvClass4GeneCode.FuncNum  ==  _AttributeName[intIndex])
{
mintFuncNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convWebSrvClass4GeneCode.FuncNum);
}
else if (convWebSrvClass4GeneCode.GeneCodeDate  ==  _AttributeName[intIndex])
{
mstrGeneCodeDate = value.ToString();
 AddUpdatedFld(convWebSrvClass4GeneCode.GeneCodeDate);
}
else if (convWebSrvClass4GeneCode.VersionGeneCode  ==  _AttributeName[intIndex])
{
mstrVersionGeneCode = value.ToString();
 AddUpdatedFld(convWebSrvClass4GeneCode.VersionGeneCode);
}
else if (convWebSrvClass4GeneCode.NameSpace  ==  _AttributeName[intIndex])
{
mstrNameSpace = value.ToString();
 AddUpdatedFld(convWebSrvClass4GeneCode.NameSpace);
}
else if (convWebSrvClass4GeneCode.WebSrvUrl  ==  _AttributeName[intIndex])
{
mstrWebSrvUrl = value.ToString();
 AddUpdatedFld(convWebSrvClass4GeneCode.WebSrvUrl);
}
else if (convWebSrvClass4GeneCode.PageName  ==  _AttributeName[intIndex])
{
mstrPageName = value.ToString();
 AddUpdatedFld(convWebSrvClass4GeneCode.PageName);
}
else if (convWebSrvClass4GeneCode.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convWebSrvClass4GeneCode.FuncModuleAgcId);
}
else if (convWebSrvClass4GeneCode.FuncModuleName  ==  _AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convWebSrvClass4GeneCode.FuncModuleName);
}
else if (convWebSrvClass4GeneCode.FuncModuleEnName  ==  _AttributeName[intIndex])
{
mstrFuncModuleEnName = value.ToString();
 AddUpdatedFld(convWebSrvClass4GeneCode.FuncModuleEnName);
}
else if (convWebSrvClass4GeneCode.IsNeedGene  ==  _AttributeName[intIndex])
{
mbolIsNeedGene = TransNullToBool(value.ToString());
 AddUpdatedFld(convWebSrvClass4GeneCode.IsNeedGene);
}
else if (convWebSrvClass4GeneCode.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convWebSrvClass4GeneCode.PrjId);
}
else if (convWebSrvClass4GeneCode.PrjName  ==  _AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convWebSrvClass4GeneCode.PrjName);
}
else if (convWebSrvClass4GeneCode.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convWebSrvClass4GeneCode.UpdDate);
}
else if (convWebSrvClass4GeneCode.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convWebSrvClass4GeneCode.Memo);
}
else if (convWebSrvClass4GeneCode.UserId4GeneCode  ==  _AttributeName[intIndex])
{
mstrUserId4GeneCode = value.ToString();
 AddUpdatedFld(convWebSrvClass4GeneCode.UserId4GeneCode);
}
else if (convWebSrvClass4GeneCode.ClsName  ==  _AttributeName[intIndex])
{
mstrClsName = value.ToString();
 AddUpdatedFld(convWebSrvClass4GeneCode.ClsName);
}
}
}

/// <summary>
/// 类Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WebSrvClassId
{
get
{
return mstrWebSrvClassId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWebSrvClassId = value;
}
else
{
 mstrWebSrvClassId = value;
}
//记录修改过的字段
 AddUpdatedFld(convWebSrvClass4GeneCode.WebSrvClassId);
}
}
/// <summary>
/// 用户名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserName
{
get
{
return mstrUserName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserName = value;
}
else
{
 mstrUserName = value;
}
//记录修改过的字段
 AddUpdatedFld(convWebSrvClass4GeneCode.UserName);
}
}
/// <summary>
/// 函数个数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? FuncNum
{
get
{
return mintFuncNum;
}
set
{
 mintFuncNum = value;
//记录修改过的字段
 AddUpdatedFld(convWebSrvClass4GeneCode.FuncNum);
}
}
/// <summary>
/// 生成代码日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GeneCodeDate
{
get
{
return mstrGeneCodeDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGeneCodeDate = value;
}
else
{
 mstrGeneCodeDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convWebSrvClass4GeneCode.GeneCodeDate);
}
}
/// <summary>
/// 生成代码版本(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VersionGeneCode
{
get
{
return mstrVersionGeneCode;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVersionGeneCode = value;
}
else
{
 mstrVersionGeneCode = value;
}
//记录修改过的字段
 AddUpdatedFld(convWebSrvClass4GeneCode.VersionGeneCode);
}
}
/// <summary>
/// 域名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string NameSpace
{
get
{
return mstrNameSpace;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrNameSpace = value;
}
else
{
 mstrNameSpace = value;
}
//记录修改过的字段
 AddUpdatedFld(convWebSrvClass4GeneCode.NameSpace);
}
}
/// <summary>
/// WebSrv地址(说明:;字段类型:varchar;字段长度:300;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WebSrvUrl
{
get
{
return mstrWebSrvUrl;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWebSrvUrl = value;
}
else
{
 mstrWebSrvUrl = value;
}
//记录修改过的字段
 AddUpdatedFld(convWebSrvClass4GeneCode.WebSrvUrl);
}
}
/// <summary>
/// 页面名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PageName
{
get
{
return mstrPageName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPageName = value;
}
else
{
 mstrPageName = value;
}
//记录修改过的字段
 AddUpdatedFld(convWebSrvClass4GeneCode.PageName);
}
}
/// <summary>
/// 功能模块Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleAgcId
{
get
{
return mstrFuncModuleAgcId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleAgcId = value;
}
else
{
 mstrFuncModuleAgcId = value;
}
//记录修改过的字段
 AddUpdatedFld(convWebSrvClass4GeneCode.FuncModuleAgcId);
}
}
/// <summary>
/// 功能模块名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleName
{
get
{
return mstrFuncModuleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleName = value;
}
else
{
 mstrFuncModuleName = value;
}
//记录修改过的字段
 AddUpdatedFld(convWebSrvClass4GeneCode.FuncModuleName);
}
}
/// <summary>
/// 功能模块英文名称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleEnName
{
get
{
return mstrFuncModuleEnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleEnName = value;
}
else
{
 mstrFuncModuleEnName = value;
}
//记录修改过的字段
 AddUpdatedFld(convWebSrvClass4GeneCode.FuncModuleEnName);
}
}
/// <summary>
/// 是否需要生成(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsNeedGene
{
get
{
return mbolIsNeedGene;
}
set
{
 mbolIsNeedGene = value;
//记录修改过的字段
 AddUpdatedFld(convWebSrvClass4GeneCode.IsNeedGene);
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
 AddUpdatedFld(convWebSrvClass4GeneCode.PrjId);
}
}
/// <summary>
/// 工程名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjName
{
get
{
return mstrPrjName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjName = value;
}
else
{
 mstrPrjName = value;
}
//记录修改过的字段
 AddUpdatedFld(convWebSrvClass4GeneCode.PrjName);
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
 AddUpdatedFld(convWebSrvClass4GeneCode.UpdDate);
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
 AddUpdatedFld(convWebSrvClass4GeneCode.Memo);
}
}
/// <summary>
/// UserId4GeneCode(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserId4GeneCode
{
get
{
return mstrUserId4GeneCode;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserId4GeneCode = value;
}
else
{
 mstrUserId4GeneCode = value;
}
//记录修改过的字段
 AddUpdatedFld(convWebSrvClass4GeneCode.UserId4GeneCode);
}
}
/// <summary>
/// 类名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClsName
{
get
{
return mstrClsName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClsName = value;
}
else
{
 mstrClsName = value;
}
//记录修改过的字段
 AddUpdatedFld(convWebSrvClass4GeneCode.ClsName);
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
  return mstrWebSrvClassId;
 }
 }
}
 /// <summary>
 /// vWebSrvClass4GeneCode(vWebSrvClass4GeneCode)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convWebSrvClass4GeneCode
{
public const string _CurrTabName = "vWebSrvClass4GeneCode"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "WebSrvClassId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"WebSrvClassId", "UserName", "FuncNum", "GeneCodeDate", "VersionGeneCode", "NameSpace", "WebSrvUrl", "PageName", "FuncModuleAgcId", "FuncModuleName", "FuncModuleEnName", "IsNeedGene", "PrjId", "PrjName", "UpdDate", "Memo", "UserId4GeneCode", "ClsName"};
//以下是属性变量


 /// <summary>
 /// 常量:"WebSrvClassId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WebSrvClassId = "WebSrvClassId";    //类Id

 /// <summary>
 /// 常量:"UserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserName = "UserName";    //用户名

 /// <summary>
 /// 常量:"FuncNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncNum = "FuncNum";    //函数个数

 /// <summary>
 /// 常量:"GeneCodeDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GeneCodeDate = "GeneCodeDate";    //生成代码日期

 /// <summary>
 /// 常量:"VersionGeneCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VersionGeneCode = "VersionGeneCode";    //生成代码版本

 /// <summary>
 /// 常量:"NameSpace"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string NameSpace = "NameSpace";    //域名

 /// <summary>
 /// 常量:"WebSrvUrl"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WebSrvUrl = "WebSrvUrl";    //WebSrv地址

 /// <summary>
 /// 常量:"PageName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PageName = "PageName";    //页面名称

 /// <summary>
 /// 常量:"FuncModuleAgcId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleAgcId = "FuncModuleAgcId";    //功能模块Id

 /// <summary>
 /// 常量:"FuncModuleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleName = "FuncModuleName";    //功能模块名称

 /// <summary>
 /// 常量:"FuncModuleEnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleEnName = "FuncModuleEnName";    //功能模块英文名称

 /// <summary>
 /// 常量:"IsNeedGene"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsNeedGene = "IsNeedGene";    //是否需要生成

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"PrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjName = "PrjName";    //工程名称

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
 /// 常量:"UserId4GeneCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId4GeneCode = "UserId4GeneCode";    //UserId4GeneCode

 /// <summary>
 /// 常量:"ClsName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClsName = "ClsName";    //类名
}

}