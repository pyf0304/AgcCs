
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFeatureAppTypeRelaEN
 表名:vFeatureAppTypeRela(00050431)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:48:46
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
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
 /// 表vFeatureAppTypeRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vFeatureAppTypeRela
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
public K_mId_vFeatureAppTypeRela(long lngmId)
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
 /// <returns>返回:[K_mId_vFeatureAppTypeRela]类型的对象</returns>
public static implicit operator K_mId_vFeatureAppTypeRela(long value)
{
return new K_mId_vFeatureAppTypeRela(value);
}
}
 /// <summary>
 /// v功能应用关系(vFeatureAppTypeRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvFeatureAppTypeRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vFeatureAppTypeRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 12;
public static string[] _AttributeName = new string[] {"mId", "ApplicationTypeId", "ApplicationTypeName", "ApplicationTypeENName", "FeatureId", "FeatureName", "FeatureTypeName", "OrderNum", "InUse", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected int mintApplicationTypeId;    //应用程序类型ID
protected string mstrApplicationTypeName;    //应用程序类型名称
protected string mstrApplicationTypeENName;    //应用类型英文名
protected string mstrFeatureId;    //功能Id
protected string mstrFeatureName;    //功能名称
protected string mstrFeatureTypeName;    //功能类型名称
protected int mintOrderNum;    //序号
protected bool mbolInUse;    //是否在用
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvFeatureAppTypeRelaEN()
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
public clsvFeatureAppTypeRelaEN(long lngmId)
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
if (strAttributeName  ==  convFeatureAppTypeRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convFeatureAppTypeRela.ApplicationTypeId)
{
return mintApplicationTypeId;
}
else if (strAttributeName  ==  convFeatureAppTypeRela.ApplicationTypeName)
{
return mstrApplicationTypeName;
}
else if (strAttributeName  ==  convFeatureAppTypeRela.ApplicationTypeENName)
{
return mstrApplicationTypeENName;
}
else if (strAttributeName  ==  convFeatureAppTypeRela.FeatureId)
{
return mstrFeatureId;
}
else if (strAttributeName  ==  convFeatureAppTypeRela.FeatureName)
{
return mstrFeatureName;
}
else if (strAttributeName  ==  convFeatureAppTypeRela.FeatureTypeName)
{
return mstrFeatureTypeName;
}
else if (strAttributeName  ==  convFeatureAppTypeRela.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convFeatureAppTypeRela.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  convFeatureAppTypeRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convFeatureAppTypeRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convFeatureAppTypeRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convFeatureAppTypeRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convFeatureAppTypeRela.mId);
}
else if (strAttributeName  ==  convFeatureAppTypeRela.ApplicationTypeId)
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convFeatureAppTypeRela.ApplicationTypeId);
}
else if (strAttributeName  ==  convFeatureAppTypeRela.ApplicationTypeName)
{
mstrApplicationTypeName = value.ToString();
 AddUpdatedFld(convFeatureAppTypeRela.ApplicationTypeName);
}
else if (strAttributeName  ==  convFeatureAppTypeRela.ApplicationTypeENName)
{
mstrApplicationTypeENName = value.ToString();
 AddUpdatedFld(convFeatureAppTypeRela.ApplicationTypeENName);
}
else if (strAttributeName  ==  convFeatureAppTypeRela.FeatureId)
{
mstrFeatureId = value.ToString();
 AddUpdatedFld(convFeatureAppTypeRela.FeatureId);
}
else if (strAttributeName  ==  convFeatureAppTypeRela.FeatureName)
{
mstrFeatureName = value.ToString();
 AddUpdatedFld(convFeatureAppTypeRela.FeatureName);
}
else if (strAttributeName  ==  convFeatureAppTypeRela.FeatureTypeName)
{
mstrFeatureTypeName = value.ToString();
 AddUpdatedFld(convFeatureAppTypeRela.FeatureTypeName);
}
else if (strAttributeName  ==  convFeatureAppTypeRela.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFeatureAppTypeRela.OrderNum);
}
else if (strAttributeName  ==  convFeatureAppTypeRela.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convFeatureAppTypeRela.InUse);
}
else if (strAttributeName  ==  convFeatureAppTypeRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFeatureAppTypeRela.UpdDate);
}
else if (strAttributeName  ==  convFeatureAppTypeRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFeatureAppTypeRela.UpdUser);
}
else if (strAttributeName  ==  convFeatureAppTypeRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFeatureAppTypeRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convFeatureAppTypeRela.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (convFeatureAppTypeRela.ApplicationTypeId  ==  _AttributeName[intIndex])
{
return mintApplicationTypeId;
}
else if (convFeatureAppTypeRela.ApplicationTypeName  ==  _AttributeName[intIndex])
{
return mstrApplicationTypeName;
}
else if (convFeatureAppTypeRela.ApplicationTypeENName  ==  _AttributeName[intIndex])
{
return mstrApplicationTypeENName;
}
else if (convFeatureAppTypeRela.FeatureId  ==  _AttributeName[intIndex])
{
return mstrFeatureId;
}
else if (convFeatureAppTypeRela.FeatureName  ==  _AttributeName[intIndex])
{
return mstrFeatureName;
}
else if (convFeatureAppTypeRela.FeatureTypeName  ==  _AttributeName[intIndex])
{
return mstrFeatureTypeName;
}
else if (convFeatureAppTypeRela.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convFeatureAppTypeRela.InUse  ==  _AttributeName[intIndex])
{
return mbolInUse;
}
else if (convFeatureAppTypeRela.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convFeatureAppTypeRela.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convFeatureAppTypeRela.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convFeatureAppTypeRela.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convFeatureAppTypeRela.mId);
}
else if (convFeatureAppTypeRela.ApplicationTypeId  ==  _AttributeName[intIndex])
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convFeatureAppTypeRela.ApplicationTypeId);
}
else if (convFeatureAppTypeRela.ApplicationTypeName  ==  _AttributeName[intIndex])
{
mstrApplicationTypeName = value.ToString();
 AddUpdatedFld(convFeatureAppTypeRela.ApplicationTypeName);
}
else if (convFeatureAppTypeRela.ApplicationTypeENName  ==  _AttributeName[intIndex])
{
mstrApplicationTypeENName = value.ToString();
 AddUpdatedFld(convFeatureAppTypeRela.ApplicationTypeENName);
}
else if (convFeatureAppTypeRela.FeatureId  ==  _AttributeName[intIndex])
{
mstrFeatureId = value.ToString();
 AddUpdatedFld(convFeatureAppTypeRela.FeatureId);
}
else if (convFeatureAppTypeRela.FeatureName  ==  _AttributeName[intIndex])
{
mstrFeatureName = value.ToString();
 AddUpdatedFld(convFeatureAppTypeRela.FeatureName);
}
else if (convFeatureAppTypeRela.FeatureTypeName  ==  _AttributeName[intIndex])
{
mstrFeatureTypeName = value.ToString();
 AddUpdatedFld(convFeatureAppTypeRela.FeatureTypeName);
}
else if (convFeatureAppTypeRela.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFeatureAppTypeRela.OrderNum);
}
else if (convFeatureAppTypeRela.InUse  ==  _AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convFeatureAppTypeRela.InUse);
}
else if (convFeatureAppTypeRela.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFeatureAppTypeRela.UpdDate);
}
else if (convFeatureAppTypeRela.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFeatureAppTypeRela.UpdUser);
}
else if (convFeatureAppTypeRela.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFeatureAppTypeRela.Memo);
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
 AddUpdatedFld(convFeatureAppTypeRela.mId);
}
}
/// <summary>
/// 应用程序类型ID(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int ApplicationTypeId
{
get
{
return mintApplicationTypeId;
}
set
{
 mintApplicationTypeId = value;
//记录修改过的字段
 AddUpdatedFld(convFeatureAppTypeRela.ApplicationTypeId);
}
}
/// <summary>
/// 应用程序类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ApplicationTypeName
{
get
{
return mstrApplicationTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrApplicationTypeName = value;
}
else
{
 mstrApplicationTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureAppTypeRela.ApplicationTypeName);
}
}
/// <summary>
/// 应用类型英文名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ApplicationTypeENName
{
get
{
return mstrApplicationTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrApplicationTypeENName = value;
}
else
{
 mstrApplicationTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureAppTypeRela.ApplicationTypeENName);
}
}
/// <summary>
/// 功能Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FeatureId
{
get
{
return mstrFeatureId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFeatureId = value;
}
else
{
 mstrFeatureId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureAppTypeRela.FeatureId);
}
}
/// <summary>
/// 功能名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FeatureName
{
get
{
return mstrFeatureName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFeatureName = value;
}
else
{
 mstrFeatureName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureAppTypeRela.FeatureName);
}
}
/// <summary>
/// 功能类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FeatureTypeName
{
get
{
return mstrFeatureTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFeatureTypeName = value;
}
else
{
 mstrFeatureTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureAppTypeRela.FeatureTypeName);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(convFeatureAppTypeRela.OrderNum);
}
}
/// <summary>
/// 是否在用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool InUse
{
get
{
return mbolInUse;
}
set
{
 mbolInUse = value;
//记录修改过的字段
 AddUpdatedFld(convFeatureAppTypeRela.InUse);
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
 AddUpdatedFld(convFeatureAppTypeRela.UpdDate);
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
 AddUpdatedFld(convFeatureAppTypeRela.UpdUser);
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
 AddUpdatedFld(convFeatureAppTypeRela.Memo);
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
 /// v功能应用关系(vFeatureAppTypeRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convFeatureAppTypeRela
{
public const string _CurrTabName = "vFeatureAppTypeRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "ApplicationTypeId", "ApplicationTypeName", "ApplicationTypeENName", "FeatureId", "FeatureName", "FeatureTypeName", "OrderNum", "InUse", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"ApplicationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeId = "ApplicationTypeId";    //应用程序类型ID

 /// <summary>
 /// 常量:"ApplicationTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeName = "ApplicationTypeName";    //应用程序类型名称

 /// <summary>
 /// 常量:"ApplicationTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeENName = "ApplicationTypeENName";    //应用类型英文名

 /// <summary>
 /// 常量:"FeatureId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeatureId = "FeatureId";    //功能Id

 /// <summary>
 /// 常量:"FeatureName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeatureName = "FeatureName";    //功能名称

 /// <summary>
 /// 常量:"FeatureTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeatureTypeName = "FeatureTypeName";    //功能类型名称

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"InUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InUse = "InUse";    //是否在用

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