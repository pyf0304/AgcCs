
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvLog4GC_WebSrvClassEN
 表名:vLog4GC_WebSrvClass(00050371)
 * 版本:2024.01.24.1(服务器:WIN-SRV103-116)
 日期:2024/01/26 16:17:44
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:日志管理(LogManage)
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
 /// 表vLog4GC_WebSrvClass的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vLog4GC_WebSrvClass
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
public K_mId_vLog4GC_WebSrvClass(long lngmId)
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
 /// <returns>返回:[K_mId_vLog4GC_WebSrvClass]类型的对象</returns>
public static implicit operator K_mId_vLog4GC_WebSrvClass(long value)
{
return new K_mId_vLog4GC_WebSrvClass(value);
}
}
 /// <summary>
 /// v生成WebSrvClass代码日志(vLog4GC_WebSrvClass)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvLog4GC_WebSrvClassEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vLog4GC_WebSrvClass"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 17;
public static string[] AttributeName = new string[] {"mId", "UserId", "UserName", "WebSrvClassId", "NameSpace", "WebSrvUrl", "PageName", "FuncModuleAgcId", "FuncModuleName", "IsNeedGene", "PrjId", "PrjName", "FuncNum", "GeneCodeDate", "VersionGeneCode", "Memo", "ClsName"};

protected long mlngmId;    //mId
protected string mstrUserId;    //用户Id
protected string mstrUserName;    //用户名
protected string mstrWebSrvClassId;    //类Id
protected string mstrNameSpace;    //域名
protected string mstrWebSrvUrl;    //WebSrv地址
protected string mstrPageName;    //页面名称
protected string mstrFuncModuleAgcId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
protected bool mbolIsNeedGene;    //是否需要生成
protected string mstrPrjId;    //工程ID
protected string mstrPrjName;    //工程名称
protected int? mintFuncNum;    //函数个数
protected string mstrGeneCodeDate;    //生成代码日期
protected string mstrVersionGeneCode;    //生成代码版本
protected string mstrMemo;    //说明
protected string mstrClsName;    //类名

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvLog4GC_WebSrvClassEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:mId</param>
public clsvLog4GC_WebSrvClassEN(long lngmId)
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
return mintAttributeCount;
}
}
public override object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  convLog4GC_WebSrvClass.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convLog4GC_WebSrvClass.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convLog4GC_WebSrvClass.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convLog4GC_WebSrvClass.WebSrvClassId)
{
return mstrWebSrvClassId;
}
else if (strAttributeName  ==  convLog4GC_WebSrvClass.NameSpace)
{
return mstrNameSpace;
}
else if (strAttributeName  ==  convLog4GC_WebSrvClass.WebSrvUrl)
{
return mstrWebSrvUrl;
}
else if (strAttributeName  ==  convLog4GC_WebSrvClass.PageName)
{
return mstrPageName;
}
else if (strAttributeName  ==  convLog4GC_WebSrvClass.FuncModuleAgcId)
{
return mstrFuncModuleAgcId;
}
else if (strAttributeName  ==  convLog4GC_WebSrvClass.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convLog4GC_WebSrvClass.IsNeedGene)
{
return mbolIsNeedGene;
}
else if (strAttributeName  ==  convLog4GC_WebSrvClass.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convLog4GC_WebSrvClass.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convLog4GC_WebSrvClass.FuncNum)
{
return mintFuncNum;
}
else if (strAttributeName  ==  convLog4GC_WebSrvClass.GeneCodeDate)
{
return mstrGeneCodeDate;
}
else if (strAttributeName  ==  convLog4GC_WebSrvClass.VersionGeneCode)
{
return mstrVersionGeneCode;
}
else if (strAttributeName  ==  convLog4GC_WebSrvClass.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convLog4GC_WebSrvClass.ClsName)
{
return mstrClsName;
}
return null;
}
set
{
if (strAttributeName  ==  convLog4GC_WebSrvClass.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convLog4GC_WebSrvClass.mId);
}
else if (strAttributeName  ==  convLog4GC_WebSrvClass.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convLog4GC_WebSrvClass.UserId);
}
else if (strAttributeName  ==  convLog4GC_WebSrvClass.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convLog4GC_WebSrvClass.UserName);
}
else if (strAttributeName  ==  convLog4GC_WebSrvClass.WebSrvClassId)
{
mstrWebSrvClassId = value.ToString();
 AddUpdatedFld(convLog4GC_WebSrvClass.WebSrvClassId);
}
else if (strAttributeName  ==  convLog4GC_WebSrvClass.NameSpace)
{
mstrNameSpace = value.ToString();
 AddUpdatedFld(convLog4GC_WebSrvClass.NameSpace);
}
else if (strAttributeName  ==  convLog4GC_WebSrvClass.WebSrvUrl)
{
mstrWebSrvUrl = value.ToString();
 AddUpdatedFld(convLog4GC_WebSrvClass.WebSrvUrl);
}
else if (strAttributeName  ==  convLog4GC_WebSrvClass.PageName)
{
mstrPageName = value.ToString();
 AddUpdatedFld(convLog4GC_WebSrvClass.PageName);
}
else if (strAttributeName  ==  convLog4GC_WebSrvClass.FuncModuleAgcId)
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convLog4GC_WebSrvClass.FuncModuleAgcId);
}
else if (strAttributeName  ==  convLog4GC_WebSrvClass.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convLog4GC_WebSrvClass.FuncModuleName);
}
else if (strAttributeName  ==  convLog4GC_WebSrvClass.IsNeedGene)
{
mbolIsNeedGene = TransNullToBool(value.ToString());
 AddUpdatedFld(convLog4GC_WebSrvClass.IsNeedGene);
}
else if (strAttributeName  ==  convLog4GC_WebSrvClass.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convLog4GC_WebSrvClass.PrjId);
}
else if (strAttributeName  ==  convLog4GC_WebSrvClass.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convLog4GC_WebSrvClass.PrjName);
}
else if (strAttributeName  ==  convLog4GC_WebSrvClass.FuncNum)
{
mintFuncNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convLog4GC_WebSrvClass.FuncNum);
}
else if (strAttributeName  ==  convLog4GC_WebSrvClass.GeneCodeDate)
{
mstrGeneCodeDate = value.ToString();
 AddUpdatedFld(convLog4GC_WebSrvClass.GeneCodeDate);
}
else if (strAttributeName  ==  convLog4GC_WebSrvClass.VersionGeneCode)
{
mstrVersionGeneCode = value.ToString();
 AddUpdatedFld(convLog4GC_WebSrvClass.VersionGeneCode);
}
else if (strAttributeName  ==  convLog4GC_WebSrvClass.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convLog4GC_WebSrvClass.Memo);
}
else if (strAttributeName  ==  convLog4GC_WebSrvClass.ClsName)
{
mstrClsName = value.ToString();
 AddUpdatedFld(convLog4GC_WebSrvClass.ClsName);
}
}
}
public object this[int intIndex]
{
get
{
if (convLog4GC_WebSrvClass.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convLog4GC_WebSrvClass.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convLog4GC_WebSrvClass.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convLog4GC_WebSrvClass.WebSrvClassId  ==  AttributeName[intIndex])
{
return mstrWebSrvClassId;
}
else if (convLog4GC_WebSrvClass.NameSpace  ==  AttributeName[intIndex])
{
return mstrNameSpace;
}
else if (convLog4GC_WebSrvClass.WebSrvUrl  ==  AttributeName[intIndex])
{
return mstrWebSrvUrl;
}
else if (convLog4GC_WebSrvClass.PageName  ==  AttributeName[intIndex])
{
return mstrPageName;
}
else if (convLog4GC_WebSrvClass.FuncModuleAgcId  ==  AttributeName[intIndex])
{
return mstrFuncModuleAgcId;
}
else if (convLog4GC_WebSrvClass.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convLog4GC_WebSrvClass.IsNeedGene  ==  AttributeName[intIndex])
{
return mbolIsNeedGene;
}
else if (convLog4GC_WebSrvClass.PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convLog4GC_WebSrvClass.PrjName  ==  AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convLog4GC_WebSrvClass.FuncNum  ==  AttributeName[intIndex])
{
return mintFuncNum;
}
else if (convLog4GC_WebSrvClass.GeneCodeDate  ==  AttributeName[intIndex])
{
return mstrGeneCodeDate;
}
else if (convLog4GC_WebSrvClass.VersionGeneCode  ==  AttributeName[intIndex])
{
return mstrVersionGeneCode;
}
else if (convLog4GC_WebSrvClass.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convLog4GC_WebSrvClass.ClsName  ==  AttributeName[intIndex])
{
return mstrClsName;
}
return null;
}
set
{
if (convLog4GC_WebSrvClass.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convLog4GC_WebSrvClass.mId);
}
else if (convLog4GC_WebSrvClass.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convLog4GC_WebSrvClass.UserId);
}
else if (convLog4GC_WebSrvClass.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convLog4GC_WebSrvClass.UserName);
}
else if (convLog4GC_WebSrvClass.WebSrvClassId  ==  AttributeName[intIndex])
{
mstrWebSrvClassId = value.ToString();
 AddUpdatedFld(convLog4GC_WebSrvClass.WebSrvClassId);
}
else if (convLog4GC_WebSrvClass.NameSpace  ==  AttributeName[intIndex])
{
mstrNameSpace = value.ToString();
 AddUpdatedFld(convLog4GC_WebSrvClass.NameSpace);
}
else if (convLog4GC_WebSrvClass.WebSrvUrl  ==  AttributeName[intIndex])
{
mstrWebSrvUrl = value.ToString();
 AddUpdatedFld(convLog4GC_WebSrvClass.WebSrvUrl);
}
else if (convLog4GC_WebSrvClass.PageName  ==  AttributeName[intIndex])
{
mstrPageName = value.ToString();
 AddUpdatedFld(convLog4GC_WebSrvClass.PageName);
}
else if (convLog4GC_WebSrvClass.FuncModuleAgcId  ==  AttributeName[intIndex])
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convLog4GC_WebSrvClass.FuncModuleAgcId);
}
else if (convLog4GC_WebSrvClass.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convLog4GC_WebSrvClass.FuncModuleName);
}
else if (convLog4GC_WebSrvClass.IsNeedGene  ==  AttributeName[intIndex])
{
mbolIsNeedGene = TransNullToBool(value.ToString());
 AddUpdatedFld(convLog4GC_WebSrvClass.IsNeedGene);
}
else if (convLog4GC_WebSrvClass.PrjId  ==  AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convLog4GC_WebSrvClass.PrjId);
}
else if (convLog4GC_WebSrvClass.PrjName  ==  AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convLog4GC_WebSrvClass.PrjName);
}
else if (convLog4GC_WebSrvClass.FuncNum  ==  AttributeName[intIndex])
{
mintFuncNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convLog4GC_WebSrvClass.FuncNum);
}
else if (convLog4GC_WebSrvClass.GeneCodeDate  ==  AttributeName[intIndex])
{
mstrGeneCodeDate = value.ToString();
 AddUpdatedFld(convLog4GC_WebSrvClass.GeneCodeDate);
}
else if (convLog4GC_WebSrvClass.VersionGeneCode  ==  AttributeName[intIndex])
{
mstrVersionGeneCode = value.ToString();
 AddUpdatedFld(convLog4GC_WebSrvClass.VersionGeneCode);
}
else if (convLog4GC_WebSrvClass.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convLog4GC_WebSrvClass.Memo);
}
else if (convLog4GC_WebSrvClass.ClsName  ==  AttributeName[intIndex])
{
mstrClsName = value.ToString();
 AddUpdatedFld(convLog4GC_WebSrvClass.ClsName);
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
 AddUpdatedFld(convLog4GC_WebSrvClass.mId);
}
}
/// <summary>
/// 用户Id(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserId
{
get
{
return mstrUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserId = value;
}
else
{
 mstrUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(convLog4GC_WebSrvClass.UserId);
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
 AddUpdatedFld(convLog4GC_WebSrvClass.UserName);
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
 AddUpdatedFld(convLog4GC_WebSrvClass.WebSrvClassId);
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
 AddUpdatedFld(convLog4GC_WebSrvClass.NameSpace);
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
 AddUpdatedFld(convLog4GC_WebSrvClass.WebSrvUrl);
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
 AddUpdatedFld(convLog4GC_WebSrvClass.PageName);
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
 AddUpdatedFld(convLog4GC_WebSrvClass.FuncModuleAgcId);
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
 AddUpdatedFld(convLog4GC_WebSrvClass.FuncModuleName);
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
 AddUpdatedFld(convLog4GC_WebSrvClass.IsNeedGene);
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
 AddUpdatedFld(convLog4GC_WebSrvClass.PrjId);
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
 AddUpdatedFld(convLog4GC_WebSrvClass.PrjName);
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
 AddUpdatedFld(convLog4GC_WebSrvClass.FuncNum);
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
 AddUpdatedFld(convLog4GC_WebSrvClass.GeneCodeDate);
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
 AddUpdatedFld(convLog4GC_WebSrvClass.VersionGeneCode);
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
 AddUpdatedFld(convLog4GC_WebSrvClass.Memo);
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
 AddUpdatedFld(convLog4GC_WebSrvClass.ClsName);
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
 /// v生成WebSrvClass代码日志(vLog4GC_WebSrvClass)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convLog4GC_WebSrvClass
{
public const string _CurrTabName = "vLog4GC_WebSrvClass"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "UserId", "UserName", "WebSrvClassId", "NameSpace", "WebSrvUrl", "PageName", "FuncModuleAgcId", "FuncModuleName", "IsNeedGene", "PrjId", "PrjName", "FuncNum", "GeneCodeDate", "VersionGeneCode", "Memo", "ClsName"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户Id

 /// <summary>
 /// 常量:"UserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserName = "UserName";    //用户名

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
 /// 常量:"IsNeedGene"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsNeedGene = "IsNeedGene";    //是否需要生成

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程ID

 /// <summary>
 /// 常量:"PrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjName = "PrjName";    //工程名称

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
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明

 /// <summary>
 /// 常量:"ClsName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClsName = "ClsName";    //类名
}

}