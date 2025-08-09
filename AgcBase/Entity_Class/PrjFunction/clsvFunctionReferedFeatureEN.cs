
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFunctionReferedFeatureEN
 表名:vFunctionReferedFeature(00050341)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:13:35
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
 /// 表vFunctionReferedFeature的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vFunctionReferedFeature
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
public K_mId_vFunctionReferedFeature(long lngmId)
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
 /// <returns>返回:[K_mId_vFunctionReferedFeature]类型的对象</returns>
public static implicit operator K_mId_vFunctionReferedFeature(long value)
{
return new K_mId_vFunctionReferedFeature(value);
}
}
 /// <summary>
 /// v功能相关函数(vFunctionReferedFeature)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvFunctionReferedFeatureEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vFunctionReferedFeature"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 15;
public static string[] _AttributeName = new string[] {"mId", "FeatureId", "FeatureName", "KeyWords", "FunctionGroupId", "FunctionGroupName", "FeatureTypeId", "FeatureTypeName", "FuncId4GC", "FuncName", "FuncId4Invoked", "UpdDate", "UpdUser", "Memo", "FuncName4Invoked"};

protected long mlngmId;    //mId
protected string mstrFeatureId;    //功能Id
protected string mstrFeatureName;    //功能名称
protected string mstrKeyWords;    //关键字
protected string mstrFunctionGroupId;    //函数组Id
protected string mstrFunctionGroupName;    //函数组名称
protected string mstrFeatureTypeId;    //功能类型Id
protected string mstrFeatureTypeName;    //功能类型名称
protected string mstrFuncId4GC;    //函数ID
protected string mstrFuncName;    //函数名
protected string mstrFuncId4Invoked;    //被调用函数
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明
protected string mstrFuncName4Invoked;    //FuncName4Invoked

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvFunctionReferedFeatureEN()
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
public clsvFunctionReferedFeatureEN(long lngmId)
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
if (strAttributeName  ==  convFunctionReferedFeature.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convFunctionReferedFeature.FeatureId)
{
return mstrFeatureId;
}
else if (strAttributeName  ==  convFunctionReferedFeature.FeatureName)
{
return mstrFeatureName;
}
else if (strAttributeName  ==  convFunctionReferedFeature.KeyWords)
{
return mstrKeyWords;
}
else if (strAttributeName  ==  convFunctionReferedFeature.FunctionGroupId)
{
return mstrFunctionGroupId;
}
else if (strAttributeName  ==  convFunctionReferedFeature.FunctionGroupName)
{
return mstrFunctionGroupName;
}
else if (strAttributeName  ==  convFunctionReferedFeature.FeatureTypeId)
{
return mstrFeatureTypeId;
}
else if (strAttributeName  ==  convFunctionReferedFeature.FeatureTypeName)
{
return mstrFeatureTypeName;
}
else if (strAttributeName  ==  convFunctionReferedFeature.FuncId4GC)
{
return mstrFuncId4GC;
}
else if (strAttributeName  ==  convFunctionReferedFeature.FuncName)
{
return mstrFuncName;
}
else if (strAttributeName  ==  convFunctionReferedFeature.FuncId4Invoked)
{
return mstrFuncId4Invoked;
}
else if (strAttributeName  ==  convFunctionReferedFeature.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convFunctionReferedFeature.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convFunctionReferedFeature.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convFunctionReferedFeature.FuncName4Invoked)
{
return mstrFuncName4Invoked;
}
return null;
}
set
{
if (strAttributeName  ==  convFunctionReferedFeature.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convFunctionReferedFeature.mId);
}
else if (strAttributeName  ==  convFunctionReferedFeature.FeatureId)
{
mstrFeatureId = value.ToString();
 AddUpdatedFld(convFunctionReferedFeature.FeatureId);
}
else if (strAttributeName  ==  convFunctionReferedFeature.FeatureName)
{
mstrFeatureName = value.ToString();
 AddUpdatedFld(convFunctionReferedFeature.FeatureName);
}
else if (strAttributeName  ==  convFunctionReferedFeature.KeyWords)
{
mstrKeyWords = value.ToString();
 AddUpdatedFld(convFunctionReferedFeature.KeyWords);
}
else if (strAttributeName  ==  convFunctionReferedFeature.FunctionGroupId)
{
mstrFunctionGroupId = value.ToString();
 AddUpdatedFld(convFunctionReferedFeature.FunctionGroupId);
}
else if (strAttributeName  ==  convFunctionReferedFeature.FunctionGroupName)
{
mstrFunctionGroupName = value.ToString();
 AddUpdatedFld(convFunctionReferedFeature.FunctionGroupName);
}
else if (strAttributeName  ==  convFunctionReferedFeature.FeatureTypeId)
{
mstrFeatureTypeId = value.ToString();
 AddUpdatedFld(convFunctionReferedFeature.FeatureTypeId);
}
else if (strAttributeName  ==  convFunctionReferedFeature.FeatureTypeName)
{
mstrFeatureTypeName = value.ToString();
 AddUpdatedFld(convFunctionReferedFeature.FeatureTypeName);
}
else if (strAttributeName  ==  convFunctionReferedFeature.FuncId4GC)
{
mstrFuncId4GC = value.ToString();
 AddUpdatedFld(convFunctionReferedFeature.FuncId4GC);
}
else if (strAttributeName  ==  convFunctionReferedFeature.FuncName)
{
mstrFuncName = value.ToString();
 AddUpdatedFld(convFunctionReferedFeature.FuncName);
}
else if (strAttributeName  ==  convFunctionReferedFeature.FuncId4Invoked)
{
mstrFuncId4Invoked = value.ToString();
 AddUpdatedFld(convFunctionReferedFeature.FuncId4Invoked);
}
else if (strAttributeName  ==  convFunctionReferedFeature.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFunctionReferedFeature.UpdDate);
}
else if (strAttributeName  ==  convFunctionReferedFeature.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFunctionReferedFeature.UpdUser);
}
else if (strAttributeName  ==  convFunctionReferedFeature.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFunctionReferedFeature.Memo);
}
else if (strAttributeName  ==  convFunctionReferedFeature.FuncName4Invoked)
{
mstrFuncName4Invoked = value.ToString();
 AddUpdatedFld(convFunctionReferedFeature.FuncName4Invoked);
}
}
}
public object this[int intIndex]
{
get
{
if (convFunctionReferedFeature.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (convFunctionReferedFeature.FeatureId  ==  _AttributeName[intIndex])
{
return mstrFeatureId;
}
else if (convFunctionReferedFeature.FeatureName  ==  _AttributeName[intIndex])
{
return mstrFeatureName;
}
else if (convFunctionReferedFeature.KeyWords  ==  _AttributeName[intIndex])
{
return mstrKeyWords;
}
else if (convFunctionReferedFeature.FunctionGroupId  ==  _AttributeName[intIndex])
{
return mstrFunctionGroupId;
}
else if (convFunctionReferedFeature.FunctionGroupName  ==  _AttributeName[intIndex])
{
return mstrFunctionGroupName;
}
else if (convFunctionReferedFeature.FeatureTypeId  ==  _AttributeName[intIndex])
{
return mstrFeatureTypeId;
}
else if (convFunctionReferedFeature.FeatureTypeName  ==  _AttributeName[intIndex])
{
return mstrFeatureTypeName;
}
else if (convFunctionReferedFeature.FuncId4GC  ==  _AttributeName[intIndex])
{
return mstrFuncId4GC;
}
else if (convFunctionReferedFeature.FuncName  ==  _AttributeName[intIndex])
{
return mstrFuncName;
}
else if (convFunctionReferedFeature.FuncId4Invoked  ==  _AttributeName[intIndex])
{
return mstrFuncId4Invoked;
}
else if (convFunctionReferedFeature.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convFunctionReferedFeature.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convFunctionReferedFeature.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (convFunctionReferedFeature.FuncName4Invoked  ==  _AttributeName[intIndex])
{
return mstrFuncName4Invoked;
}
return null;
}
set
{
if (convFunctionReferedFeature.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convFunctionReferedFeature.mId);
}
else if (convFunctionReferedFeature.FeatureId  ==  _AttributeName[intIndex])
{
mstrFeatureId = value.ToString();
 AddUpdatedFld(convFunctionReferedFeature.FeatureId);
}
else if (convFunctionReferedFeature.FeatureName  ==  _AttributeName[intIndex])
{
mstrFeatureName = value.ToString();
 AddUpdatedFld(convFunctionReferedFeature.FeatureName);
}
else if (convFunctionReferedFeature.KeyWords  ==  _AttributeName[intIndex])
{
mstrKeyWords = value.ToString();
 AddUpdatedFld(convFunctionReferedFeature.KeyWords);
}
else if (convFunctionReferedFeature.FunctionGroupId  ==  _AttributeName[intIndex])
{
mstrFunctionGroupId = value.ToString();
 AddUpdatedFld(convFunctionReferedFeature.FunctionGroupId);
}
else if (convFunctionReferedFeature.FunctionGroupName  ==  _AttributeName[intIndex])
{
mstrFunctionGroupName = value.ToString();
 AddUpdatedFld(convFunctionReferedFeature.FunctionGroupName);
}
else if (convFunctionReferedFeature.FeatureTypeId  ==  _AttributeName[intIndex])
{
mstrFeatureTypeId = value.ToString();
 AddUpdatedFld(convFunctionReferedFeature.FeatureTypeId);
}
else if (convFunctionReferedFeature.FeatureTypeName  ==  _AttributeName[intIndex])
{
mstrFeatureTypeName = value.ToString();
 AddUpdatedFld(convFunctionReferedFeature.FeatureTypeName);
}
else if (convFunctionReferedFeature.FuncId4GC  ==  _AttributeName[intIndex])
{
mstrFuncId4GC = value.ToString();
 AddUpdatedFld(convFunctionReferedFeature.FuncId4GC);
}
else if (convFunctionReferedFeature.FuncName  ==  _AttributeName[intIndex])
{
mstrFuncName = value.ToString();
 AddUpdatedFld(convFunctionReferedFeature.FuncName);
}
else if (convFunctionReferedFeature.FuncId4Invoked  ==  _AttributeName[intIndex])
{
mstrFuncId4Invoked = value.ToString();
 AddUpdatedFld(convFunctionReferedFeature.FuncId4Invoked);
}
else if (convFunctionReferedFeature.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFunctionReferedFeature.UpdDate);
}
else if (convFunctionReferedFeature.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFunctionReferedFeature.UpdUser);
}
else if (convFunctionReferedFeature.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFunctionReferedFeature.Memo);
}
else if (convFunctionReferedFeature.FuncName4Invoked  ==  _AttributeName[intIndex])
{
mstrFuncName4Invoked = value.ToString();
 AddUpdatedFld(convFunctionReferedFeature.FuncName4Invoked);
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
 AddUpdatedFld(convFunctionReferedFeature.mId);
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
 AddUpdatedFld(convFunctionReferedFeature.FeatureId);
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
 AddUpdatedFld(convFunctionReferedFeature.FeatureName);
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
 AddUpdatedFld(convFunctionReferedFeature.KeyWords);
}
}
/// <summary>
/// 函数组Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FunctionGroupId
{
get
{
return mstrFunctionGroupId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFunctionGroupId = value;
}
else
{
 mstrFunctionGroupId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunctionReferedFeature.FunctionGroupId);
}
}
/// <summary>
/// 函数组名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FunctionGroupName
{
get
{
return mstrFunctionGroupName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFunctionGroupName = value;
}
else
{
 mstrFunctionGroupName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunctionReferedFeature.FunctionGroupName);
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
 AddUpdatedFld(convFunctionReferedFeature.FeatureTypeId);
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
 AddUpdatedFld(convFunctionReferedFeature.FeatureTypeName);
}
}
/// <summary>
/// 函数ID(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncId4GC
{
get
{
return mstrFuncId4GC;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncId4GC = value;
}
else
{
 mstrFuncId4GC = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunctionReferedFeature.FuncId4GC);
}
}
/// <summary>
/// 函数名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncName
{
get
{
return mstrFuncName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncName = value;
}
else
{
 mstrFuncName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunctionReferedFeature.FuncName);
}
}
/// <summary>
/// 被调用函数(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncId4Invoked
{
get
{
return mstrFuncId4Invoked;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncId4Invoked = value;
}
else
{
 mstrFuncId4Invoked = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunctionReferedFeature.FuncId4Invoked);
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
 AddUpdatedFld(convFunctionReferedFeature.UpdDate);
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
 AddUpdatedFld(convFunctionReferedFeature.UpdUser);
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
 AddUpdatedFld(convFunctionReferedFeature.Memo);
}
}
/// <summary>
/// FuncName4Invoked(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncName4Invoked
{
get
{
return mstrFuncName4Invoked;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncName4Invoked = value;
}
else
{
 mstrFuncName4Invoked = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunctionReferedFeature.FuncName4Invoked);
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
 /// v功能相关函数(vFunctionReferedFeature)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convFunctionReferedFeature
{
public const string _CurrTabName = "vFunctionReferedFeature"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "FeatureId", "FeatureName", "KeyWords", "FunctionGroupId", "FunctionGroupName", "FeatureTypeId", "FeatureTypeName", "FuncId4GC", "FuncName", "FuncId4Invoked", "UpdDate", "UpdUser", "Memo", "FuncName4Invoked"};
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
 /// 常量:"FunctionGroupId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FunctionGroupId = "FunctionGroupId";    //函数组Id

 /// <summary>
 /// 常量:"FunctionGroupName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FunctionGroupName = "FunctionGroupName";    //函数组名称

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
 /// 常量:"FuncId4GC"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncId4GC = "FuncId4GC";    //函数ID

 /// <summary>
 /// 常量:"FuncName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncName = "FuncName";    //函数名

 /// <summary>
 /// 常量:"FuncId4Invoked"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncId4Invoked = "FuncId4Invoked";    //被调用函数

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
 /// 常量:"FuncName4Invoked"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncName4Invoked = "FuncName4Invoked";    //FuncName4Invoked
}

}