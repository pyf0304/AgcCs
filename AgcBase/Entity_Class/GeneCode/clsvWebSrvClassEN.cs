
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvWebSrvClassEN
 表名:vWebSrvClass(00050349)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:04:08
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
 /// 表vWebSrvClass的关键字(WebSrvClassId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_WebSrvClassId_vWebSrvClass
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
public K_WebSrvClassId_vWebSrvClass(string strWebSrvClassId)
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
 /// <returns>返回:[K_WebSrvClassId_vWebSrvClass]类型的对象</returns>
public static implicit operator K_WebSrvClassId_vWebSrvClass(string value)
{
return new K_WebSrvClassId_vWebSrvClass(value);
}
}
 /// <summary>
 /// vWebSrv类(vWebSrvClass)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvWebSrvClassEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vWebSrvClass"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "WebSrvClassId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 16;
public static string[] _AttributeName = new string[] {"WebSrvClassId", "NameSpace", "WebSrvUrl", "PageName", "FuncModuleAgcId", "FuncModuleName", "FuncModuleEnName", "FuncModuleNameSim", "IsNeedGene", "PrjId", "PrjName", "UpdDate", "UpdUser", "Memo", "FuncNum", "ClsName"};

protected string mstrWebSrvClassId;    //类Id
protected string mstrNameSpace;    //域名
protected string mstrWebSrvUrl;    //WebSrv地址
protected string mstrPageName;    //页面名称
protected string mstrFuncModuleAgcId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrFuncModuleEnName;    //功能模块英文名称
protected string mstrFuncModuleNameSim;    //功能模块简称
protected bool mbolIsNeedGene;    //是否需要生成
protected string mstrPrjId;    //工程Id
protected string mstrPrjName;    //工程名称
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明
protected int? mintFuncNum;    //函数个数
protected string mstrClsName;    //类名

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvWebSrvClassEN()
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
public clsvWebSrvClassEN(string strWebSrvClassId)
 {
strWebSrvClassId = strWebSrvClassId.Replace("'", "''");
if (strWebSrvClassId.Length > 8)
{
throw new Exception("在表:vWebSrvClass中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strWebSrvClassId)  ==  true)
{
throw new Exception("在表:vWebSrvClass中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convWebSrvClass.WebSrvClassId)
{
return mstrWebSrvClassId;
}
else if (strAttributeName  ==  convWebSrvClass.NameSpace)
{
return mstrNameSpace;
}
else if (strAttributeName  ==  convWebSrvClass.WebSrvUrl)
{
return mstrWebSrvUrl;
}
else if (strAttributeName  ==  convWebSrvClass.PageName)
{
return mstrPageName;
}
else if (strAttributeName  ==  convWebSrvClass.FuncModuleAgcId)
{
return mstrFuncModuleAgcId;
}
else if (strAttributeName  ==  convWebSrvClass.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convWebSrvClass.FuncModuleEnName)
{
return mstrFuncModuleEnName;
}
else if (strAttributeName  ==  convWebSrvClass.FuncModuleNameSim)
{
return mstrFuncModuleNameSim;
}
else if (strAttributeName  ==  convWebSrvClass.IsNeedGene)
{
return mbolIsNeedGene;
}
else if (strAttributeName  ==  convWebSrvClass.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convWebSrvClass.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convWebSrvClass.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convWebSrvClass.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convWebSrvClass.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convWebSrvClass.FuncNum)
{
return mintFuncNum;
}
else if (strAttributeName  ==  convWebSrvClass.ClsName)
{
return mstrClsName;
}
return null;
}
set
{
if (strAttributeName  ==  convWebSrvClass.WebSrvClassId)
{
mstrWebSrvClassId = value.ToString();
 AddUpdatedFld(convWebSrvClass.WebSrvClassId);
}
else if (strAttributeName  ==  convWebSrvClass.NameSpace)
{
mstrNameSpace = value.ToString();
 AddUpdatedFld(convWebSrvClass.NameSpace);
}
else if (strAttributeName  ==  convWebSrvClass.WebSrvUrl)
{
mstrWebSrvUrl = value.ToString();
 AddUpdatedFld(convWebSrvClass.WebSrvUrl);
}
else if (strAttributeName  ==  convWebSrvClass.PageName)
{
mstrPageName = value.ToString();
 AddUpdatedFld(convWebSrvClass.PageName);
}
else if (strAttributeName  ==  convWebSrvClass.FuncModuleAgcId)
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convWebSrvClass.FuncModuleAgcId);
}
else if (strAttributeName  ==  convWebSrvClass.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convWebSrvClass.FuncModuleName);
}
else if (strAttributeName  ==  convWebSrvClass.FuncModuleEnName)
{
mstrFuncModuleEnName = value.ToString();
 AddUpdatedFld(convWebSrvClass.FuncModuleEnName);
}
else if (strAttributeName  ==  convWebSrvClass.FuncModuleNameSim)
{
mstrFuncModuleNameSim = value.ToString();
 AddUpdatedFld(convWebSrvClass.FuncModuleNameSim);
}
else if (strAttributeName  ==  convWebSrvClass.IsNeedGene)
{
mbolIsNeedGene = TransNullToBool(value.ToString());
 AddUpdatedFld(convWebSrvClass.IsNeedGene);
}
else if (strAttributeName  ==  convWebSrvClass.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convWebSrvClass.PrjId);
}
else if (strAttributeName  ==  convWebSrvClass.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convWebSrvClass.PrjName);
}
else if (strAttributeName  ==  convWebSrvClass.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convWebSrvClass.UpdDate);
}
else if (strAttributeName  ==  convWebSrvClass.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convWebSrvClass.UpdUser);
}
else if (strAttributeName  ==  convWebSrvClass.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convWebSrvClass.Memo);
}
else if (strAttributeName  ==  convWebSrvClass.FuncNum)
{
mintFuncNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convWebSrvClass.FuncNum);
}
else if (strAttributeName  ==  convWebSrvClass.ClsName)
{
mstrClsName = value.ToString();
 AddUpdatedFld(convWebSrvClass.ClsName);
}
}
}
public object this[int intIndex]
{
get
{
if (convWebSrvClass.WebSrvClassId  ==  _AttributeName[intIndex])
{
return mstrWebSrvClassId;
}
else if (convWebSrvClass.NameSpace  ==  _AttributeName[intIndex])
{
return mstrNameSpace;
}
else if (convWebSrvClass.WebSrvUrl  ==  _AttributeName[intIndex])
{
return mstrWebSrvUrl;
}
else if (convWebSrvClass.PageName  ==  _AttributeName[intIndex])
{
return mstrPageName;
}
else if (convWebSrvClass.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
return mstrFuncModuleAgcId;
}
else if (convWebSrvClass.FuncModuleName  ==  _AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convWebSrvClass.FuncModuleEnName  ==  _AttributeName[intIndex])
{
return mstrFuncModuleEnName;
}
else if (convWebSrvClass.FuncModuleNameSim  ==  _AttributeName[intIndex])
{
return mstrFuncModuleNameSim;
}
else if (convWebSrvClass.IsNeedGene  ==  _AttributeName[intIndex])
{
return mbolIsNeedGene;
}
else if (convWebSrvClass.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convWebSrvClass.PrjName  ==  _AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convWebSrvClass.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convWebSrvClass.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convWebSrvClass.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (convWebSrvClass.FuncNum  ==  _AttributeName[intIndex])
{
return mintFuncNum;
}
else if (convWebSrvClass.ClsName  ==  _AttributeName[intIndex])
{
return mstrClsName;
}
return null;
}
set
{
if (convWebSrvClass.WebSrvClassId  ==  _AttributeName[intIndex])
{
mstrWebSrvClassId = value.ToString();
 AddUpdatedFld(convWebSrvClass.WebSrvClassId);
}
else if (convWebSrvClass.NameSpace  ==  _AttributeName[intIndex])
{
mstrNameSpace = value.ToString();
 AddUpdatedFld(convWebSrvClass.NameSpace);
}
else if (convWebSrvClass.WebSrvUrl  ==  _AttributeName[intIndex])
{
mstrWebSrvUrl = value.ToString();
 AddUpdatedFld(convWebSrvClass.WebSrvUrl);
}
else if (convWebSrvClass.PageName  ==  _AttributeName[intIndex])
{
mstrPageName = value.ToString();
 AddUpdatedFld(convWebSrvClass.PageName);
}
else if (convWebSrvClass.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convWebSrvClass.FuncModuleAgcId);
}
else if (convWebSrvClass.FuncModuleName  ==  _AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convWebSrvClass.FuncModuleName);
}
else if (convWebSrvClass.FuncModuleEnName  ==  _AttributeName[intIndex])
{
mstrFuncModuleEnName = value.ToString();
 AddUpdatedFld(convWebSrvClass.FuncModuleEnName);
}
else if (convWebSrvClass.FuncModuleNameSim  ==  _AttributeName[intIndex])
{
mstrFuncModuleNameSim = value.ToString();
 AddUpdatedFld(convWebSrvClass.FuncModuleNameSim);
}
else if (convWebSrvClass.IsNeedGene  ==  _AttributeName[intIndex])
{
mbolIsNeedGene = TransNullToBool(value.ToString());
 AddUpdatedFld(convWebSrvClass.IsNeedGene);
}
else if (convWebSrvClass.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convWebSrvClass.PrjId);
}
else if (convWebSrvClass.PrjName  ==  _AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convWebSrvClass.PrjName);
}
else if (convWebSrvClass.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convWebSrvClass.UpdDate);
}
else if (convWebSrvClass.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convWebSrvClass.UpdUser);
}
else if (convWebSrvClass.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convWebSrvClass.Memo);
}
else if (convWebSrvClass.FuncNum  ==  _AttributeName[intIndex])
{
mintFuncNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convWebSrvClass.FuncNum);
}
else if (convWebSrvClass.ClsName  ==  _AttributeName[intIndex])
{
mstrClsName = value.ToString();
 AddUpdatedFld(convWebSrvClass.ClsName);
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
 AddUpdatedFld(convWebSrvClass.WebSrvClassId);
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
 AddUpdatedFld(convWebSrvClass.NameSpace);
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
 AddUpdatedFld(convWebSrvClass.WebSrvUrl);
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
 AddUpdatedFld(convWebSrvClass.PageName);
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
 AddUpdatedFld(convWebSrvClass.FuncModuleAgcId);
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
 AddUpdatedFld(convWebSrvClass.FuncModuleName);
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
 AddUpdatedFld(convWebSrvClass.FuncModuleEnName);
}
}
/// <summary>
/// 功能模块简称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleNameSim
{
get
{
return mstrFuncModuleNameSim;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleNameSim = value;
}
else
{
 mstrFuncModuleNameSim = value;
}
//记录修改过的字段
 AddUpdatedFld(convWebSrvClass.FuncModuleNameSim);
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
 AddUpdatedFld(convWebSrvClass.IsNeedGene);
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
 AddUpdatedFld(convWebSrvClass.PrjId);
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
 AddUpdatedFld(convWebSrvClass.PrjName);
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
 AddUpdatedFld(convWebSrvClass.UpdDate);
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
 AddUpdatedFld(convWebSrvClass.UpdUser);
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
 AddUpdatedFld(convWebSrvClass.Memo);
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
 AddUpdatedFld(convWebSrvClass.FuncNum);
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
 AddUpdatedFld(convWebSrvClass.ClsName);
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
 /// vWebSrv类(vWebSrvClass)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convWebSrvClass
{
public const string _CurrTabName = "vWebSrvClass"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "WebSrvClassId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"WebSrvClassId", "NameSpace", "WebSrvUrl", "PageName", "FuncModuleAgcId", "FuncModuleName", "FuncModuleEnName", "FuncModuleNameSim", "IsNeedGene", "PrjId", "PrjName", "UpdDate", "UpdUser", "Memo", "FuncNum", "ClsName"};
//以下是属性变量


 /// <summary>
 /// 常量:"WebSrvClassId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WebSrvClassId = "WebSrvClassId";    //类Id

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
 /// 常量:"FuncModuleNameSim"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleNameSim = "FuncModuleNameSim";    //功能模块简称

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
 /// 常量:"FuncNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncNum = "FuncNum";    //函数个数

 /// <summary>
 /// 常量:"ClsName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClsName = "ClsName";    //类名
}

}