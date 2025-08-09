
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFeatureImplementationEN
 表名:vFeatureImplementation(00050394)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:13:07
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:界面管理(PrjInterface)
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
 /// 表vFeatureImplementation的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vFeatureImplementation
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
public K_mId_vFeatureImplementation(long lngmId)
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
 /// <returns>返回:[K_mId_vFeatureImplementation]类型的对象</returns>
public static implicit operator K_mId_vFeatureImplementation(long value)
{
return new K_mId_vFeatureImplementation(value);
}
}
 /// <summary>
 /// v功能实现方式(vFeatureImplementation)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvFeatureImplementationEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vFeatureImplementation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 12;
public static string[] _AttributeName = new string[] {"mId", "FeatureId", "FeatureName", "KeyWords", "FeatureDescription", "FeatureTypeId", "FeatureTypeName", "ViewImplId", "ViewImplName", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrFeatureId;    //功能Id
protected string mstrFeatureName;    //功能名称
protected string mstrKeyWords;    //关键字
protected string mstrFeatureDescription;    //功能说明
protected string mstrFeatureTypeId;    //功能类型Id
protected string mstrFeatureTypeName;    //功能类型名称
protected string mstrViewImplId;    //界面实现Id
protected string mstrViewImplName;    //界面实现名
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvFeatureImplementationEN()
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
public clsvFeatureImplementationEN(long lngmId)
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
if (strAttributeName  ==  convFeatureImplementation.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convFeatureImplementation.FeatureId)
{
return mstrFeatureId;
}
else if (strAttributeName  ==  convFeatureImplementation.FeatureName)
{
return mstrFeatureName;
}
else if (strAttributeName  ==  convFeatureImplementation.KeyWords)
{
return mstrKeyWords;
}
else if (strAttributeName  ==  convFeatureImplementation.FeatureDescription)
{
return mstrFeatureDescription;
}
else if (strAttributeName  ==  convFeatureImplementation.FeatureTypeId)
{
return mstrFeatureTypeId;
}
else if (strAttributeName  ==  convFeatureImplementation.FeatureTypeName)
{
return mstrFeatureTypeName;
}
else if (strAttributeName  ==  convFeatureImplementation.ViewImplId)
{
return mstrViewImplId;
}
else if (strAttributeName  ==  convFeatureImplementation.ViewImplName)
{
return mstrViewImplName;
}
else if (strAttributeName  ==  convFeatureImplementation.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convFeatureImplementation.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convFeatureImplementation.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convFeatureImplementation.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convFeatureImplementation.mId);
}
else if (strAttributeName  ==  convFeatureImplementation.FeatureId)
{
mstrFeatureId = value.ToString();
 AddUpdatedFld(convFeatureImplementation.FeatureId);
}
else if (strAttributeName  ==  convFeatureImplementation.FeatureName)
{
mstrFeatureName = value.ToString();
 AddUpdatedFld(convFeatureImplementation.FeatureName);
}
else if (strAttributeName  ==  convFeatureImplementation.KeyWords)
{
mstrKeyWords = value.ToString();
 AddUpdatedFld(convFeatureImplementation.KeyWords);
}
else if (strAttributeName  ==  convFeatureImplementation.FeatureDescription)
{
mstrFeatureDescription = value.ToString();
 AddUpdatedFld(convFeatureImplementation.FeatureDescription);
}
else if (strAttributeName  ==  convFeatureImplementation.FeatureTypeId)
{
mstrFeatureTypeId = value.ToString();
 AddUpdatedFld(convFeatureImplementation.FeatureTypeId);
}
else if (strAttributeName  ==  convFeatureImplementation.FeatureTypeName)
{
mstrFeatureTypeName = value.ToString();
 AddUpdatedFld(convFeatureImplementation.FeatureTypeName);
}
else if (strAttributeName  ==  convFeatureImplementation.ViewImplId)
{
mstrViewImplId = value.ToString();
 AddUpdatedFld(convFeatureImplementation.ViewImplId);
}
else if (strAttributeName  ==  convFeatureImplementation.ViewImplName)
{
mstrViewImplName = value.ToString();
 AddUpdatedFld(convFeatureImplementation.ViewImplName);
}
else if (strAttributeName  ==  convFeatureImplementation.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFeatureImplementation.UpdDate);
}
else if (strAttributeName  ==  convFeatureImplementation.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFeatureImplementation.UpdUser);
}
else if (strAttributeName  ==  convFeatureImplementation.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFeatureImplementation.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convFeatureImplementation.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (convFeatureImplementation.FeatureId  ==  _AttributeName[intIndex])
{
return mstrFeatureId;
}
else if (convFeatureImplementation.FeatureName  ==  _AttributeName[intIndex])
{
return mstrFeatureName;
}
else if (convFeatureImplementation.KeyWords  ==  _AttributeName[intIndex])
{
return mstrKeyWords;
}
else if (convFeatureImplementation.FeatureDescription  ==  _AttributeName[intIndex])
{
return mstrFeatureDescription;
}
else if (convFeatureImplementation.FeatureTypeId  ==  _AttributeName[intIndex])
{
return mstrFeatureTypeId;
}
else if (convFeatureImplementation.FeatureTypeName  ==  _AttributeName[intIndex])
{
return mstrFeatureTypeName;
}
else if (convFeatureImplementation.ViewImplId  ==  _AttributeName[intIndex])
{
return mstrViewImplId;
}
else if (convFeatureImplementation.ViewImplName  ==  _AttributeName[intIndex])
{
return mstrViewImplName;
}
else if (convFeatureImplementation.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convFeatureImplementation.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convFeatureImplementation.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convFeatureImplementation.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convFeatureImplementation.mId);
}
else if (convFeatureImplementation.FeatureId  ==  _AttributeName[intIndex])
{
mstrFeatureId = value.ToString();
 AddUpdatedFld(convFeatureImplementation.FeatureId);
}
else if (convFeatureImplementation.FeatureName  ==  _AttributeName[intIndex])
{
mstrFeatureName = value.ToString();
 AddUpdatedFld(convFeatureImplementation.FeatureName);
}
else if (convFeatureImplementation.KeyWords  ==  _AttributeName[intIndex])
{
mstrKeyWords = value.ToString();
 AddUpdatedFld(convFeatureImplementation.KeyWords);
}
else if (convFeatureImplementation.FeatureDescription  ==  _AttributeName[intIndex])
{
mstrFeatureDescription = value.ToString();
 AddUpdatedFld(convFeatureImplementation.FeatureDescription);
}
else if (convFeatureImplementation.FeatureTypeId  ==  _AttributeName[intIndex])
{
mstrFeatureTypeId = value.ToString();
 AddUpdatedFld(convFeatureImplementation.FeatureTypeId);
}
else if (convFeatureImplementation.FeatureTypeName  ==  _AttributeName[intIndex])
{
mstrFeatureTypeName = value.ToString();
 AddUpdatedFld(convFeatureImplementation.FeatureTypeName);
}
else if (convFeatureImplementation.ViewImplId  ==  _AttributeName[intIndex])
{
mstrViewImplId = value.ToString();
 AddUpdatedFld(convFeatureImplementation.ViewImplId);
}
else if (convFeatureImplementation.ViewImplName  ==  _AttributeName[intIndex])
{
mstrViewImplName = value.ToString();
 AddUpdatedFld(convFeatureImplementation.ViewImplName);
}
else if (convFeatureImplementation.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFeatureImplementation.UpdDate);
}
else if (convFeatureImplementation.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFeatureImplementation.UpdUser);
}
else if (convFeatureImplementation.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFeatureImplementation.Memo);
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
 AddUpdatedFld(convFeatureImplementation.mId);
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
 AddUpdatedFld(convFeatureImplementation.FeatureId);
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
 AddUpdatedFld(convFeatureImplementation.FeatureName);
}
}
/// <summary>
/// 关键字(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KeyWords
{
get
{
return mstrKeyWords;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeyWords = value;
}
else
{
 mstrKeyWords = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureImplementation.KeyWords);
}
}
/// <summary>
/// 功能说明(说明:;字段类型:varchar;字段长度:4000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FeatureDescription
{
get
{
return mstrFeatureDescription;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFeatureDescription = value;
}
else
{
 mstrFeatureDescription = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureImplementation.FeatureDescription);
}
}
/// <summary>
/// 功能类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FeatureTypeId
{
get
{
return mstrFeatureTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFeatureTypeId = value;
}
else
{
 mstrFeatureTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureImplementation.FeatureTypeId);
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
 AddUpdatedFld(convFeatureImplementation.FeatureTypeName);
}
}
/// <summary>
/// 界面实现Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewImplId
{
get
{
return mstrViewImplId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewImplId = value;
}
else
{
 mstrViewImplId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureImplementation.ViewImplId);
}
}
/// <summary>
/// 界面实现名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewImplName
{
get
{
return mstrViewImplName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewImplName = value;
}
else
{
 mstrViewImplName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureImplementation.ViewImplName);
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
 AddUpdatedFld(convFeatureImplementation.UpdDate);
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
 AddUpdatedFld(convFeatureImplementation.UpdUser);
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
 AddUpdatedFld(convFeatureImplementation.Memo);
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
 /// v功能实现方式(vFeatureImplementation)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convFeatureImplementation
{
public const string _CurrTabName = "vFeatureImplementation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "FeatureId", "FeatureName", "KeyWords", "FeatureDescription", "FeatureTypeId", "FeatureTypeName", "ViewImplId", "ViewImplName", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

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
 /// 常量:"KeyWords"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KeyWords = "KeyWords";    //关键字

 /// <summary>
 /// 常量:"FeatureDescription"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeatureDescription = "FeatureDescription";    //功能说明

 /// <summary>
 /// 常量:"FeatureTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeatureTypeId = "FeatureTypeId";    //功能类型Id

 /// <summary>
 /// 常量:"FeatureTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeatureTypeName = "FeatureTypeName";    //功能类型名称

 /// <summary>
 /// 常量:"ViewImplId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewImplId = "ViewImplId";    //界面实现Id

 /// <summary>
 /// 常量:"ViewImplName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewImplName = "ViewImplName";    //界面实现名

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