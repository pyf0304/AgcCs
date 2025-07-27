
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvLog4GeneTabCodeEN
 表名:vLog4GeneTabCode(00050282)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 16:45:09
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
 /// 表vLog4GeneTabCode的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vLog4GeneTabCode
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
public K_mId_vLog4GeneTabCode(long lngmId)
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
 /// <returns>返回:[K_mId_vLog4GeneTabCode]类型的对象</returns>
public static implicit operator K_mId_vLog4GeneTabCode(long value)
{
return new K_mId_vLog4GeneTabCode(value);
}
}
 /// <summary>
 /// v生成表代码日志(vLog4GeneTabCode)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvLog4GeneTabCodeEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接，如果为空就使用系统默认的连接
public new const string _CurrTabName = "vLog4GeneTabCode"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string WhereFormat = ""; //条件格式串
protected const int mintAttributeCount = 10;
public static string[] AttributeName = new string[] {"mId", "UserId", "UserName", "TabId", "GcPathId", "GeneCodeDate", "IsNeedGene", "VersionGeneCode", "ApplicationTypeId", "Memo"};

protected long mlngmId;    //mId
protected string mstrUserId;    //用户Id
protected string mstrUserName;    //用户名
protected string mstrTabId;    //表ID
protected string mstrGcPathId;    //GC路径Id
protected string mstrGeneCodeDate;    //生成代码日期
protected bool mbolIsNeedGene;    //是否需要生成
protected string mstrVersionGeneCode;    //生成代码版本
protected int? mintApplicationTypeId;    //应用程序类型ID
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvLog4GeneTabCodeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "vLog4GeneTabCode";
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:mId</param>
public clsvLog4GeneTabCodeEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "vLog4GeneTabCode";
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
if (strAttributeName  ==  convLog4GeneTabCode.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convLog4GeneTabCode.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convLog4GeneTabCode.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convLog4GeneTabCode.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  convLog4GeneTabCode.GcPathId)
{
return mstrGcPathId;
}
else if (strAttributeName  ==  convLog4GeneTabCode.GeneCodeDate)
{
return mstrGeneCodeDate;
}
else if (strAttributeName  ==  convLog4GeneTabCode.IsNeedGene)
{
return mbolIsNeedGene;
}
else if (strAttributeName  ==  convLog4GeneTabCode.VersionGeneCode)
{
return mstrVersionGeneCode;
}
else if (strAttributeName  ==  convLog4GeneTabCode.ApplicationTypeId)
{
return mintApplicationTypeId;
}
else if (strAttributeName  ==  convLog4GeneTabCode.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convLog4GeneTabCode.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convLog4GeneTabCode.mId);
}
else if (strAttributeName  ==  convLog4GeneTabCode.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convLog4GeneTabCode.UserId);
}
else if (strAttributeName  ==  convLog4GeneTabCode.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convLog4GeneTabCode.UserName);
}
else if (strAttributeName  ==  convLog4GeneTabCode.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(convLog4GeneTabCode.TabId);
}
else if (strAttributeName  ==  convLog4GeneTabCode.GcPathId)
{
mstrGcPathId = value.ToString();
 AddUpdatedFld(convLog4GeneTabCode.GcPathId);
}
else if (strAttributeName  ==  convLog4GeneTabCode.GeneCodeDate)
{
mstrGeneCodeDate = value.ToString();
 AddUpdatedFld(convLog4GeneTabCode.GeneCodeDate);
}
else if (strAttributeName  ==  convLog4GeneTabCode.IsNeedGene)
{
mbolIsNeedGene = TransNullToBool(value.ToString());
 AddUpdatedFld(convLog4GeneTabCode.IsNeedGene);
}
else if (strAttributeName  ==  convLog4GeneTabCode.VersionGeneCode)
{
mstrVersionGeneCode = value.ToString();
 AddUpdatedFld(convLog4GeneTabCode.VersionGeneCode);
}
else if (strAttributeName  ==  convLog4GeneTabCode.ApplicationTypeId)
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convLog4GeneTabCode.ApplicationTypeId);
}
else if (strAttributeName  ==  convLog4GeneTabCode.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convLog4GeneTabCode.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convLog4GeneTabCode.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convLog4GeneTabCode.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convLog4GeneTabCode.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convLog4GeneTabCode.TabId  ==  AttributeName[intIndex])
{
return mstrTabId;
}
else if (convLog4GeneTabCode.GcPathId  ==  AttributeName[intIndex])
{
return mstrGcPathId;
}
else if (convLog4GeneTabCode.GeneCodeDate  ==  AttributeName[intIndex])
{
return mstrGeneCodeDate;
}
else if (convLog4GeneTabCode.IsNeedGene  ==  AttributeName[intIndex])
{
return mbolIsNeedGene;
}
else if (convLog4GeneTabCode.VersionGeneCode  ==  AttributeName[intIndex])
{
return mstrVersionGeneCode;
}
else if (convLog4GeneTabCode.ApplicationTypeId  ==  AttributeName[intIndex])
{
return mintApplicationTypeId;
}
else if (convLog4GeneTabCode.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convLog4GeneTabCode.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convLog4GeneTabCode.mId);
}
else if (convLog4GeneTabCode.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convLog4GeneTabCode.UserId);
}
else if (convLog4GeneTabCode.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convLog4GeneTabCode.UserName);
}
else if (convLog4GeneTabCode.TabId  ==  AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(convLog4GeneTabCode.TabId);
}
else if (convLog4GeneTabCode.GcPathId  ==  AttributeName[intIndex])
{
mstrGcPathId = value.ToString();
 AddUpdatedFld(convLog4GeneTabCode.GcPathId);
}
else if (convLog4GeneTabCode.GeneCodeDate  ==  AttributeName[intIndex])
{
mstrGeneCodeDate = value.ToString();
 AddUpdatedFld(convLog4GeneTabCode.GeneCodeDate);
}
else if (convLog4GeneTabCode.IsNeedGene  ==  AttributeName[intIndex])
{
mbolIsNeedGene = TransNullToBool(value.ToString());
 AddUpdatedFld(convLog4GeneTabCode.IsNeedGene);
}
else if (convLog4GeneTabCode.VersionGeneCode  ==  AttributeName[intIndex])
{
mstrVersionGeneCode = value.ToString();
 AddUpdatedFld(convLog4GeneTabCode.VersionGeneCode);
}
else if (convLog4GeneTabCode.ApplicationTypeId  ==  AttributeName[intIndex])
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convLog4GeneTabCode.ApplicationTypeId);
}
else if (convLog4GeneTabCode.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convLog4GeneTabCode.Memo);
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
 AddUpdatedFld(convLog4GeneTabCode.mId);
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
 AddUpdatedFld(convLog4GeneTabCode.UserId);
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
 AddUpdatedFld(convLog4GeneTabCode.UserName);
}
}
/// <summary>
/// 表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabId
{
get
{
return mstrTabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabId = value;
}
else
{
 mstrTabId = value;
}
//记录修改过的字段
 AddUpdatedFld(convLog4GeneTabCode.TabId);
}
}
/// <summary>
/// GC路径Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GcPathId
{
get
{
return mstrGcPathId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGcPathId = value;
}
else
{
 mstrGcPathId = value;
}
//记录修改过的字段
 AddUpdatedFld(convLog4GeneTabCode.GcPathId);
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
 AddUpdatedFld(convLog4GeneTabCode.GeneCodeDate);
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
 AddUpdatedFld(convLog4GeneTabCode.IsNeedGene);
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
 AddUpdatedFld(convLog4GeneTabCode.VersionGeneCode);
}
}
/// <summary>
/// 应用程序类型ID(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? ApplicationTypeId
{
get
{
return mintApplicationTypeId;
}
set
{
 mintApplicationTypeId = value;
//记录修改过的字段
 AddUpdatedFld(convLog4GeneTabCode.ApplicationTypeId);
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
 AddUpdatedFld(convLog4GeneTabCode.Memo);
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
 /// v生成表代码日志(vLog4GeneTabCode)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convLog4GeneTabCode
{
public new const string _CurrTabName = "vLog4GeneTabCode"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "UserId", "UserName", "TabId", "GcPathId", "GeneCodeDate", "IsNeedGene", "VersionGeneCode", "ApplicationTypeId", "Memo"};
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
 /// 常量:"TabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabId = "TabId";    //表ID

 /// <summary>
 /// 常量:"GcPathId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GcPathId = "GcPathId";    //GC路径Id

 /// <summary>
 /// 常量:"GeneCodeDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GeneCodeDate = "GeneCodeDate";    //生成代码日期

 /// <summary>
 /// 常量:"IsNeedGene"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsNeedGene = "IsNeedGene";    //是否需要生成

 /// <summary>
 /// 常量:"VersionGeneCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VersionGeneCode = "VersionGeneCode";    //生成代码版本

 /// <summary>
 /// 常量:"ApplicationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeId = "ApplicationTypeId";    //应用程序类型ID

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}