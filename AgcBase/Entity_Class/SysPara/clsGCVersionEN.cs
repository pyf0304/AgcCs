
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsGCVersionEN
 表名:GCVersion(00050500)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:34:30
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统参数(SysPara)
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
 /// 表GCVersion的关键字(GcVersionId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_GcVersionId_GCVersion
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strGcVersionId">表关键字</param>
public K_GcVersionId_GCVersion(string strGcVersionId)
{
if (IsValid(strGcVersionId)) Value = strGcVersionId;
else
{
Value = null;
}
}
private static bool IsValid(string strGcVersionId)
{
if (string.IsNullOrEmpty(strGcVersionId) == true) return false;
if (strGcVersionId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_GcVersionId_GCVersion]类型的对象</returns>
public static implicit operator K_GcVersionId_GCVersion(string value)
{
return new K_GcVersionId_GCVersion(value);
}
}
 /// <summary>
 /// 生成代码版本(GCVersion)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsGCVersionEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "GCVersion"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "GcVersionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 11;
public static string[] _AttributeName = new string[] {"GcVersionId", "GcVersionDescription", "VersionNumber", "VersionCode", "PublishDate", "VersionState", "VersionUrl", "PrjId", "UpdDate", "UpdUser", "Memo"};

protected string mstrGcVersionId;    //生成代码版本Id
protected string mstrGcVersionDescription;    //版本说明
protected string mstrVersionNumber;    //版本号
protected string mstrVersionCode;    //版本代码
protected string mstrPublishDate;    //发布日期
protected bool mbolVersionState;    //版本状态
protected string mstrVersionUrl;    //版本文件
protected string mstrPrjId;    //工程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsGCVersionEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("GcVersionId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strGcVersionId">关键字:生成代码版本Id</param>
public clsGCVersionEN(string strGcVersionId)
 {
strGcVersionId = strGcVersionId.Replace("'", "''");
if (strGcVersionId.Length > 4)
{
throw new Exception("在表:GCVersion中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strGcVersionId)  ==  true)
{
throw new Exception("在表:GCVersion中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strGcVersionId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrGcVersionId = strGcVersionId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("GcVersionId");
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
if (strAttributeName  ==  conGCVersion.GcVersionId)
{
return mstrGcVersionId;
}
else if (strAttributeName  ==  conGCVersion.GcVersionDescription)
{
return mstrGcVersionDescription;
}
else if (strAttributeName  ==  conGCVersion.VersionNumber)
{
return mstrVersionNumber;
}
else if (strAttributeName  ==  conGCVersion.VersionCode)
{
return mstrVersionCode;
}
else if (strAttributeName  ==  conGCVersion.PublishDate)
{
return mstrPublishDate;
}
else if (strAttributeName  ==  conGCVersion.VersionState)
{
return mbolVersionState;
}
else if (strAttributeName  ==  conGCVersion.VersionUrl)
{
return mstrVersionUrl;
}
else if (strAttributeName  ==  conGCVersion.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conGCVersion.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conGCVersion.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conGCVersion.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conGCVersion.GcVersionId)
{
mstrGcVersionId = value.ToString();
 AddUpdatedFld(conGCVersion.GcVersionId);
}
else if (strAttributeName  ==  conGCVersion.GcVersionDescription)
{
mstrGcVersionDescription = value.ToString();
 AddUpdatedFld(conGCVersion.GcVersionDescription);
}
else if (strAttributeName  ==  conGCVersion.VersionNumber)
{
mstrVersionNumber = value.ToString();
 AddUpdatedFld(conGCVersion.VersionNumber);
}
else if (strAttributeName  ==  conGCVersion.VersionCode)
{
mstrVersionCode = value.ToString();
 AddUpdatedFld(conGCVersion.VersionCode);
}
else if (strAttributeName  ==  conGCVersion.PublishDate)
{
mstrPublishDate = value.ToString();
 AddUpdatedFld(conGCVersion.PublishDate);
}
else if (strAttributeName  ==  conGCVersion.VersionState)
{
mbolVersionState = TransNullToBool(value.ToString());
 AddUpdatedFld(conGCVersion.VersionState);
}
else if (strAttributeName  ==  conGCVersion.VersionUrl)
{
mstrVersionUrl = value.ToString();
 AddUpdatedFld(conGCVersion.VersionUrl);
}
else if (strAttributeName  ==  conGCVersion.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conGCVersion.PrjId);
}
else if (strAttributeName  ==  conGCVersion.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conGCVersion.UpdDate);
}
else if (strAttributeName  ==  conGCVersion.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conGCVersion.UpdUser);
}
else if (strAttributeName  ==  conGCVersion.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conGCVersion.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conGCVersion.GcVersionId  ==  _AttributeName[intIndex])
{
return mstrGcVersionId;
}
else if (conGCVersion.GcVersionDescription  ==  _AttributeName[intIndex])
{
return mstrGcVersionDescription;
}
else if (conGCVersion.VersionNumber  ==  _AttributeName[intIndex])
{
return mstrVersionNumber;
}
else if (conGCVersion.VersionCode  ==  _AttributeName[intIndex])
{
return mstrVersionCode;
}
else if (conGCVersion.PublishDate  ==  _AttributeName[intIndex])
{
return mstrPublishDate;
}
else if (conGCVersion.VersionState  ==  _AttributeName[intIndex])
{
return mbolVersionState;
}
else if (conGCVersion.VersionUrl  ==  _AttributeName[intIndex])
{
return mstrVersionUrl;
}
else if (conGCVersion.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conGCVersion.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conGCVersion.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conGCVersion.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conGCVersion.GcVersionId  ==  _AttributeName[intIndex])
{
mstrGcVersionId = value.ToString();
 AddUpdatedFld(conGCVersion.GcVersionId);
}
else if (conGCVersion.GcVersionDescription  ==  _AttributeName[intIndex])
{
mstrGcVersionDescription = value.ToString();
 AddUpdatedFld(conGCVersion.GcVersionDescription);
}
else if (conGCVersion.VersionNumber  ==  _AttributeName[intIndex])
{
mstrVersionNumber = value.ToString();
 AddUpdatedFld(conGCVersion.VersionNumber);
}
else if (conGCVersion.VersionCode  ==  _AttributeName[intIndex])
{
mstrVersionCode = value.ToString();
 AddUpdatedFld(conGCVersion.VersionCode);
}
else if (conGCVersion.PublishDate  ==  _AttributeName[intIndex])
{
mstrPublishDate = value.ToString();
 AddUpdatedFld(conGCVersion.PublishDate);
}
else if (conGCVersion.VersionState  ==  _AttributeName[intIndex])
{
mbolVersionState = TransNullToBool(value.ToString());
 AddUpdatedFld(conGCVersion.VersionState);
}
else if (conGCVersion.VersionUrl  ==  _AttributeName[intIndex])
{
mstrVersionUrl = value.ToString();
 AddUpdatedFld(conGCVersion.VersionUrl);
}
else if (conGCVersion.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conGCVersion.PrjId);
}
else if (conGCVersion.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conGCVersion.UpdDate);
}
else if (conGCVersion.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conGCVersion.UpdUser);
}
else if (conGCVersion.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conGCVersion.Memo);
}
}
}

/// <summary>
/// 生成代码版本Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GcVersionId
{
get
{
return mstrGcVersionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGcVersionId = value;
}
else
{
 mstrGcVersionId = value;
}
//记录修改过的字段
 AddUpdatedFld(conGCVersion.GcVersionId);
}
}
/// <summary>
/// 版本说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GcVersionDescription
{
get
{
return mstrGcVersionDescription;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGcVersionDescription = value;
}
else
{
 mstrGcVersionDescription = value;
}
//记录修改过的字段
 AddUpdatedFld(conGCVersion.GcVersionDescription);
}
}
/// <summary>
/// 版本号(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VersionNumber
{
get
{
return mstrVersionNumber;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVersionNumber = value;
}
else
{
 mstrVersionNumber = value;
}
//记录修改过的字段
 AddUpdatedFld(conGCVersion.VersionNumber);
}
}
/// <summary>
/// 版本代码(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VersionCode
{
get
{
return mstrVersionCode;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVersionCode = value;
}
else
{
 mstrVersionCode = value;
}
//记录修改过的字段
 AddUpdatedFld(conGCVersion.VersionCode);
}
}
/// <summary>
/// 发布日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PublishDate
{
get
{
return mstrPublishDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPublishDate = value;
}
else
{
 mstrPublishDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conGCVersion.PublishDate);
}
}
/// <summary>
/// 版本状态(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool VersionState
{
get
{
return mbolVersionState;
}
set
{
 mbolVersionState = value;
//记录修改过的字段
 AddUpdatedFld(conGCVersion.VersionState);
}
}
/// <summary>
/// 版本文件(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VersionUrl
{
get
{
return mstrVersionUrl;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVersionUrl = value;
}
else
{
 mstrVersionUrl = value;
}
//记录修改过的字段
 AddUpdatedFld(conGCVersion.VersionUrl);
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
 AddUpdatedFld(conGCVersion.PrjId);
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
 AddUpdatedFld(conGCVersion.UpdDate);
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
 AddUpdatedFld(conGCVersion.UpdUser);
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
 AddUpdatedFld(conGCVersion.Memo);
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
  return mstrGcVersionId;
 }
 }
}
 /// <summary>
 /// 生成代码版本(GCVersion)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conGCVersion
{
public const string _CurrTabName = "GCVersion"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "GcVersionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"GcVersionId", "GcVersionDescription", "VersionNumber", "VersionCode", "PublishDate", "VersionState", "VersionUrl", "PrjId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"GcVersionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GcVersionId = "GcVersionId";    //生成代码版本Id

 /// <summary>
 /// 常量:"GcVersionDescription"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GcVersionDescription = "GcVersionDescription";    //版本说明

 /// <summary>
 /// 常量:"VersionNumber"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VersionNumber = "VersionNumber";    //版本号

 /// <summary>
 /// 常量:"VersionCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VersionCode = "VersionCode";    //版本代码

 /// <summary>
 /// 常量:"PublishDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PublishDate = "PublishDate";    //发布日期

 /// <summary>
 /// 常量:"VersionState"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VersionState = "VersionState";    //版本状态

 /// <summary>
 /// 常量:"VersionUrl"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VersionUrl = "VersionUrl";    //版本文件

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

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