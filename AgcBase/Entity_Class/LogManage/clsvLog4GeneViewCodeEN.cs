
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvLog4GeneViewCodeEN
 表名:vLog4GeneViewCode(00050281)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:17:59
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
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
 /// 表vLog4GeneViewCode的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vLog4GeneViewCode
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
public K_mId_vLog4GeneViewCode(long lngmId)
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
 /// <returns>返回:[K_mId_vLog4GeneViewCode]类型的对象</returns>
public static implicit operator K_mId_vLog4GeneViewCode(long value)
{
return new K_mId_vLog4GeneViewCode(value);
}
}
 /// <summary>
 /// v生成界面代码日志(vLog4GeneViewCode)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvLog4GeneViewCodeEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接，如果为空就使用系统默认的连接
public new const string _CurrTabName = "vLog4GeneViewCode"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string WhereFormat = ""; //条件格式串
protected const int mintAttributeCount = 13;
public static string[] AttributeName = new string[] {"mId", "UserId", "UserName", "ViewId", "ViewName", "ViewCnName", "PrjId", "PrjName", "FuncModuleAgcId", "FuncModuleName", "GeneCodeDate", "VersionGeneCode", "Memo"};

protected long mlngmId;    //mId
protected string mstrUserId;    //用户Id
protected string mstrUserName;    //用户名
protected string mstrViewId;    //界面Id
protected string mstrViewName;    //界面名称
protected string mstrViewCnName;    //视图中文名
protected string mstrPrjId;    //工程ID
protected string mstrPrjName;    //工程名称
protected string mstrFuncModuleAgcId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrGeneCodeDate;    //生成代码日期
protected string mstrVersionGeneCode;    //生成代码版本
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvLog4GeneViewCodeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "vLog4GeneViewCode";
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:mId</param>
public clsvLog4GeneViewCodeEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "vLog4GeneViewCode";
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
if (strAttributeName  ==  convLog4GeneViewCode.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convLog4GeneViewCode.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convLog4GeneViewCode.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convLog4GeneViewCode.ViewId)
{
return mstrViewId;
}
else if (strAttributeName  ==  convLog4GeneViewCode.ViewName)
{
return mstrViewName;
}
else if (strAttributeName  ==  convLog4GeneViewCode.ViewCnName)
{
return mstrViewCnName;
}
else if (strAttributeName  ==  convLog4GeneViewCode.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convLog4GeneViewCode.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convLog4GeneViewCode.FuncModuleAgcId)
{
return mstrFuncModuleAgcId;
}
else if (strAttributeName  ==  convLog4GeneViewCode.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convLog4GeneViewCode.GeneCodeDate)
{
return mstrGeneCodeDate;
}
else if (strAttributeName  ==  convLog4GeneViewCode.VersionGeneCode)
{
return mstrVersionGeneCode;
}
else if (strAttributeName  ==  convLog4GeneViewCode.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convLog4GeneViewCode.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convLog4GeneViewCode.mId);
}
else if (strAttributeName  ==  convLog4GeneViewCode.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convLog4GeneViewCode.UserId);
}
else if (strAttributeName  ==  convLog4GeneViewCode.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convLog4GeneViewCode.UserName);
}
else if (strAttributeName  ==  convLog4GeneViewCode.ViewId)
{
mstrViewId = value.ToString();
 AddUpdatedFld(convLog4GeneViewCode.ViewId);
}
else if (strAttributeName  ==  convLog4GeneViewCode.ViewName)
{
mstrViewName = value.ToString();
 AddUpdatedFld(convLog4GeneViewCode.ViewName);
}
else if (strAttributeName  ==  convLog4GeneViewCode.ViewCnName)
{
mstrViewCnName = value.ToString();
 AddUpdatedFld(convLog4GeneViewCode.ViewCnName);
}
else if (strAttributeName  ==  convLog4GeneViewCode.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convLog4GeneViewCode.PrjId);
}
else if (strAttributeName  ==  convLog4GeneViewCode.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convLog4GeneViewCode.PrjName);
}
else if (strAttributeName  ==  convLog4GeneViewCode.FuncModuleAgcId)
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convLog4GeneViewCode.FuncModuleAgcId);
}
else if (strAttributeName  ==  convLog4GeneViewCode.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convLog4GeneViewCode.FuncModuleName);
}
else if (strAttributeName  ==  convLog4GeneViewCode.GeneCodeDate)
{
mstrGeneCodeDate = value.ToString();
 AddUpdatedFld(convLog4GeneViewCode.GeneCodeDate);
}
else if (strAttributeName  ==  convLog4GeneViewCode.VersionGeneCode)
{
mstrVersionGeneCode = value.ToString();
 AddUpdatedFld(convLog4GeneViewCode.VersionGeneCode);
}
else if (strAttributeName  ==  convLog4GeneViewCode.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convLog4GeneViewCode.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convLog4GeneViewCode.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convLog4GeneViewCode.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convLog4GeneViewCode.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convLog4GeneViewCode.ViewId  ==  AttributeName[intIndex])
{
return mstrViewId;
}
else if (convLog4GeneViewCode.ViewName  ==  AttributeName[intIndex])
{
return mstrViewName;
}
else if (convLog4GeneViewCode.ViewCnName  ==  AttributeName[intIndex])
{
return mstrViewCnName;
}
else if (convLog4GeneViewCode.PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convLog4GeneViewCode.PrjName  ==  AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convLog4GeneViewCode.FuncModuleAgcId  ==  AttributeName[intIndex])
{
return mstrFuncModuleAgcId;
}
else if (convLog4GeneViewCode.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convLog4GeneViewCode.GeneCodeDate  ==  AttributeName[intIndex])
{
return mstrGeneCodeDate;
}
else if (convLog4GeneViewCode.VersionGeneCode  ==  AttributeName[intIndex])
{
return mstrVersionGeneCode;
}
else if (convLog4GeneViewCode.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convLog4GeneViewCode.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convLog4GeneViewCode.mId);
}
else if (convLog4GeneViewCode.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convLog4GeneViewCode.UserId);
}
else if (convLog4GeneViewCode.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convLog4GeneViewCode.UserName);
}
else if (convLog4GeneViewCode.ViewId  ==  AttributeName[intIndex])
{
mstrViewId = value.ToString();
 AddUpdatedFld(convLog4GeneViewCode.ViewId);
}
else if (convLog4GeneViewCode.ViewName  ==  AttributeName[intIndex])
{
mstrViewName = value.ToString();
 AddUpdatedFld(convLog4GeneViewCode.ViewName);
}
else if (convLog4GeneViewCode.ViewCnName  ==  AttributeName[intIndex])
{
mstrViewCnName = value.ToString();
 AddUpdatedFld(convLog4GeneViewCode.ViewCnName);
}
else if (convLog4GeneViewCode.PrjId  ==  AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convLog4GeneViewCode.PrjId);
}
else if (convLog4GeneViewCode.PrjName  ==  AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convLog4GeneViewCode.PrjName);
}
else if (convLog4GeneViewCode.FuncModuleAgcId  ==  AttributeName[intIndex])
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convLog4GeneViewCode.FuncModuleAgcId);
}
else if (convLog4GeneViewCode.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convLog4GeneViewCode.FuncModuleName);
}
else if (convLog4GeneViewCode.GeneCodeDate  ==  AttributeName[intIndex])
{
mstrGeneCodeDate = value.ToString();
 AddUpdatedFld(convLog4GeneViewCode.GeneCodeDate);
}
else if (convLog4GeneViewCode.VersionGeneCode  ==  AttributeName[intIndex])
{
mstrVersionGeneCode = value.ToString();
 AddUpdatedFld(convLog4GeneViewCode.VersionGeneCode);
}
else if (convLog4GeneViewCode.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convLog4GeneViewCode.Memo);
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
 AddUpdatedFld(convLog4GeneViewCode.mId);
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
 AddUpdatedFld(convLog4GeneViewCode.UserId);
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
 AddUpdatedFld(convLog4GeneViewCode.UserName);
}
}
/// <summary>
/// 界面Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewId
{
get
{
return mstrViewId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewId = value;
}
else
{
 mstrViewId = value;
}
//记录修改过的字段
 AddUpdatedFld(convLog4GeneViewCode.ViewId);
}
}
/// <summary>
/// 界面名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewName
{
get
{
return mstrViewName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewName = value;
}
else
{
 mstrViewName = value;
}
//记录修改过的字段
 AddUpdatedFld(convLog4GeneViewCode.ViewName);
}
}
/// <summary>
/// 视图中文名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewCnName
{
get
{
return mstrViewCnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewCnName = value;
}
else
{
 mstrViewCnName = value;
}
//记录修改过的字段
 AddUpdatedFld(convLog4GeneViewCode.ViewCnName);
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
 AddUpdatedFld(convLog4GeneViewCode.PrjId);
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
 AddUpdatedFld(convLog4GeneViewCode.PrjName);
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
 AddUpdatedFld(convLog4GeneViewCode.FuncModuleAgcId);
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
 AddUpdatedFld(convLog4GeneViewCode.FuncModuleName);
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
 AddUpdatedFld(convLog4GeneViewCode.GeneCodeDate);
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
 AddUpdatedFld(convLog4GeneViewCode.VersionGeneCode);
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
 AddUpdatedFld(convLog4GeneViewCode.Memo);
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
 /// v生成界面代码日志(vLog4GeneViewCode)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convLog4GeneViewCode
{
public new const string _CurrTabName = "vLog4GeneViewCode"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "UserId", "UserName", "ViewId", "ViewName", "ViewCnName", "PrjId", "PrjName", "FuncModuleAgcId", "FuncModuleName", "GeneCodeDate", "VersionGeneCode", "Memo"};
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
 /// 常量:"ViewId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewId = "ViewId";    //界面Id

 /// <summary>
 /// 常量:"ViewName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewName = "ViewName";    //界面名称

 /// <summary>
 /// 常量:"ViewCnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewCnName = "ViewCnName";    //视图中文名

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
}

}