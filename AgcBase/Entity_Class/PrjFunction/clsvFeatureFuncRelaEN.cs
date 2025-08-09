
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFeatureFuncRelaEN
 表名:vFeatureFuncRela(00050398)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:14:01
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
 /// 表vFeatureFuncRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vFeatureFuncRela
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
public K_mId_vFeatureFuncRela(long lngmId)
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
 /// <returns>返回:[K_mId_vFeatureFuncRela]类型的对象</returns>
public static implicit operator K_mId_vFeatureFuncRela(long value)
{
return new K_mId_vFeatureFuncRela(value);
}
}
 /// <summary>
 /// v功能函数关系(vFeatureFuncRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvFeatureFuncRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vFeatureFuncRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 22;
public static string[] _AttributeName = new string[] {"mId", "ApplicationTypeId", "ApplicationTypeName", "ProgLangTypeName", "FeatureId", "FeatureName", "KeyWords", "FeatureTypeId", "FeatureTypeName", "FeatureName2", "FuncId4GC", "FuncName", "FuncId4Code", "FuncName4Code", "FunctionSignature", "OrderNum", "UpdDate", "UpdUser", "Memo", "FuncCodeTypeENName", "FuncCodeTypeId", "FuncCodeTypeName"};

protected long mlngmId;    //mId
protected int mintApplicationTypeId;    //应用程序类型ID
protected string mstrApplicationTypeName;    //应用程序类型名称
protected string mstrProgLangTypeName;    //编程语言类型名
protected string mstrFeatureId;    //功能Id
protected string mstrFeatureName;    //功能名称
protected string mstrKeyWords;    //关键字
protected string mstrFeatureTypeId;    //功能类型Id
protected string mstrFeatureTypeName;    //功能类型名称
protected string mstrFeatureName2;    //功能名-FuncCount
protected string mstrFuncId4GC;    //函数ID
protected string mstrFuncName;    //函数名
protected string mstrFuncId4Code;    //函数Id4Code
protected string mstrFuncName4Code;    //函数名4Code
protected string mstrFunctionSignature;    //函数签名
protected int? mintOrderNum;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明
protected string mstrFuncCodeTypeENName;    //FuncCodeTypeENName
protected string mstrFuncCodeTypeId;    //函数代码类型Id
protected string mstrFuncCodeTypeName;    //FuncCodeTypeName

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvFeatureFuncRelaEN()
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
public clsvFeatureFuncRelaEN(long lngmId)
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
if (strAttributeName  ==  convFeatureFuncRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convFeatureFuncRela.ApplicationTypeId)
{
return mintApplicationTypeId;
}
else if (strAttributeName  ==  convFeatureFuncRela.ApplicationTypeName)
{
return mstrApplicationTypeName;
}
else if (strAttributeName  ==  convFeatureFuncRela.ProgLangTypeName)
{
return mstrProgLangTypeName;
}
else if (strAttributeName  ==  convFeatureFuncRela.FeatureId)
{
return mstrFeatureId;
}
else if (strAttributeName  ==  convFeatureFuncRela.FeatureName)
{
return mstrFeatureName;
}
else if (strAttributeName  ==  convFeatureFuncRela.KeyWords)
{
return mstrKeyWords;
}
else if (strAttributeName  ==  convFeatureFuncRela.FeatureTypeId)
{
return mstrFeatureTypeId;
}
else if (strAttributeName  ==  convFeatureFuncRela.FeatureTypeName)
{
return mstrFeatureTypeName;
}
else if (strAttributeName  ==  convFeatureFuncRela.FeatureName2)
{
return mstrFeatureName2;
}
else if (strAttributeName  ==  convFeatureFuncRela.FuncId4GC)
{
return mstrFuncId4GC;
}
else if (strAttributeName  ==  convFeatureFuncRela.FuncName)
{
return mstrFuncName;
}
else if (strAttributeName  ==  convFeatureFuncRela.FuncId4Code)
{
return mstrFuncId4Code;
}
else if (strAttributeName  ==  convFeatureFuncRela.FuncName4Code)
{
return mstrFuncName4Code;
}
else if (strAttributeName  ==  convFeatureFuncRela.FunctionSignature)
{
return mstrFunctionSignature;
}
else if (strAttributeName  ==  convFeatureFuncRela.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convFeatureFuncRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convFeatureFuncRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convFeatureFuncRela.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convFeatureFuncRela.FuncCodeTypeENName)
{
return mstrFuncCodeTypeENName;
}
else if (strAttributeName  ==  convFeatureFuncRela.FuncCodeTypeId)
{
return mstrFuncCodeTypeId;
}
else if (strAttributeName  ==  convFeatureFuncRela.FuncCodeTypeName)
{
return mstrFuncCodeTypeName;
}
return null;
}
set
{
if (strAttributeName  ==  convFeatureFuncRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convFeatureFuncRela.mId);
}
else if (strAttributeName  ==  convFeatureFuncRela.ApplicationTypeId)
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convFeatureFuncRela.ApplicationTypeId);
}
else if (strAttributeName  ==  convFeatureFuncRela.ApplicationTypeName)
{
mstrApplicationTypeName = value.ToString();
 AddUpdatedFld(convFeatureFuncRela.ApplicationTypeName);
}
else if (strAttributeName  ==  convFeatureFuncRela.ProgLangTypeName)
{
mstrProgLangTypeName = value.ToString();
 AddUpdatedFld(convFeatureFuncRela.ProgLangTypeName);
}
else if (strAttributeName  ==  convFeatureFuncRela.FeatureId)
{
mstrFeatureId = value.ToString();
 AddUpdatedFld(convFeatureFuncRela.FeatureId);
}
else if (strAttributeName  ==  convFeatureFuncRela.FeatureName)
{
mstrFeatureName = value.ToString();
 AddUpdatedFld(convFeatureFuncRela.FeatureName);
}
else if (strAttributeName  ==  convFeatureFuncRela.KeyWords)
{
mstrKeyWords = value.ToString();
 AddUpdatedFld(convFeatureFuncRela.KeyWords);
}
else if (strAttributeName  ==  convFeatureFuncRela.FeatureTypeId)
{
mstrFeatureTypeId = value.ToString();
 AddUpdatedFld(convFeatureFuncRela.FeatureTypeId);
}
else if (strAttributeName  ==  convFeatureFuncRela.FeatureTypeName)
{
mstrFeatureTypeName = value.ToString();
 AddUpdatedFld(convFeatureFuncRela.FeatureTypeName);
}
else if (strAttributeName  ==  convFeatureFuncRela.FeatureName2)
{
mstrFeatureName2 = value.ToString();
 AddUpdatedFld(convFeatureFuncRela.FeatureName2);
}
else if (strAttributeName  ==  convFeatureFuncRela.FuncId4GC)
{
mstrFuncId4GC = value.ToString();
 AddUpdatedFld(convFeatureFuncRela.FuncId4GC);
}
else if (strAttributeName  ==  convFeatureFuncRela.FuncName)
{
mstrFuncName = value.ToString();
 AddUpdatedFld(convFeatureFuncRela.FuncName);
}
else if (strAttributeName  ==  convFeatureFuncRela.FuncId4Code)
{
mstrFuncId4Code = value.ToString();
 AddUpdatedFld(convFeatureFuncRela.FuncId4Code);
}
else if (strAttributeName  ==  convFeatureFuncRela.FuncName4Code)
{
mstrFuncName4Code = value.ToString();
 AddUpdatedFld(convFeatureFuncRela.FuncName4Code);
}
else if (strAttributeName  ==  convFeatureFuncRela.FunctionSignature)
{
mstrFunctionSignature = value.ToString();
 AddUpdatedFld(convFeatureFuncRela.FunctionSignature);
}
else if (strAttributeName  ==  convFeatureFuncRela.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFeatureFuncRela.OrderNum);
}
else if (strAttributeName  ==  convFeatureFuncRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFeatureFuncRela.UpdDate);
}
else if (strAttributeName  ==  convFeatureFuncRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFeatureFuncRela.UpdUser);
}
else if (strAttributeName  ==  convFeatureFuncRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFeatureFuncRela.Memo);
}
else if (strAttributeName  ==  convFeatureFuncRela.FuncCodeTypeENName)
{
mstrFuncCodeTypeENName = value.ToString();
 AddUpdatedFld(convFeatureFuncRela.FuncCodeTypeENName);
}
else if (strAttributeName  ==  convFeatureFuncRela.FuncCodeTypeId)
{
mstrFuncCodeTypeId = value.ToString();
 AddUpdatedFld(convFeatureFuncRela.FuncCodeTypeId);
}
else if (strAttributeName  ==  convFeatureFuncRela.FuncCodeTypeName)
{
mstrFuncCodeTypeName = value.ToString();
 AddUpdatedFld(convFeatureFuncRela.FuncCodeTypeName);
}
}
}
public object this[int intIndex]
{
get
{
if (convFeatureFuncRela.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (convFeatureFuncRela.ApplicationTypeId  ==  _AttributeName[intIndex])
{
return mintApplicationTypeId;
}
else if (convFeatureFuncRela.ApplicationTypeName  ==  _AttributeName[intIndex])
{
return mstrApplicationTypeName;
}
else if (convFeatureFuncRela.ProgLangTypeName  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeName;
}
else if (convFeatureFuncRela.FeatureId  ==  _AttributeName[intIndex])
{
return mstrFeatureId;
}
else if (convFeatureFuncRela.FeatureName  ==  _AttributeName[intIndex])
{
return mstrFeatureName;
}
else if (convFeatureFuncRela.KeyWords  ==  _AttributeName[intIndex])
{
return mstrKeyWords;
}
else if (convFeatureFuncRela.FeatureTypeId  ==  _AttributeName[intIndex])
{
return mstrFeatureTypeId;
}
else if (convFeatureFuncRela.FeatureTypeName  ==  _AttributeName[intIndex])
{
return mstrFeatureTypeName;
}
else if (convFeatureFuncRela.FeatureName2  ==  _AttributeName[intIndex])
{
return mstrFeatureName2;
}
else if (convFeatureFuncRela.FuncId4GC  ==  _AttributeName[intIndex])
{
return mstrFuncId4GC;
}
else if (convFeatureFuncRela.FuncName  ==  _AttributeName[intIndex])
{
return mstrFuncName;
}
else if (convFeatureFuncRela.FuncId4Code  ==  _AttributeName[intIndex])
{
return mstrFuncId4Code;
}
else if (convFeatureFuncRela.FuncName4Code  ==  _AttributeName[intIndex])
{
return mstrFuncName4Code;
}
else if (convFeatureFuncRela.FunctionSignature  ==  _AttributeName[intIndex])
{
return mstrFunctionSignature;
}
else if (convFeatureFuncRela.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convFeatureFuncRela.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convFeatureFuncRela.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convFeatureFuncRela.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (convFeatureFuncRela.FuncCodeTypeENName  ==  _AttributeName[intIndex])
{
return mstrFuncCodeTypeENName;
}
else if (convFeatureFuncRela.FuncCodeTypeId  ==  _AttributeName[intIndex])
{
return mstrFuncCodeTypeId;
}
else if (convFeatureFuncRela.FuncCodeTypeName  ==  _AttributeName[intIndex])
{
return mstrFuncCodeTypeName;
}
return null;
}
set
{
if (convFeatureFuncRela.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convFeatureFuncRela.mId);
}
else if (convFeatureFuncRela.ApplicationTypeId  ==  _AttributeName[intIndex])
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convFeatureFuncRela.ApplicationTypeId);
}
else if (convFeatureFuncRela.ApplicationTypeName  ==  _AttributeName[intIndex])
{
mstrApplicationTypeName = value.ToString();
 AddUpdatedFld(convFeatureFuncRela.ApplicationTypeName);
}
else if (convFeatureFuncRela.ProgLangTypeName  ==  _AttributeName[intIndex])
{
mstrProgLangTypeName = value.ToString();
 AddUpdatedFld(convFeatureFuncRela.ProgLangTypeName);
}
else if (convFeatureFuncRela.FeatureId  ==  _AttributeName[intIndex])
{
mstrFeatureId = value.ToString();
 AddUpdatedFld(convFeatureFuncRela.FeatureId);
}
else if (convFeatureFuncRela.FeatureName  ==  _AttributeName[intIndex])
{
mstrFeatureName = value.ToString();
 AddUpdatedFld(convFeatureFuncRela.FeatureName);
}
else if (convFeatureFuncRela.KeyWords  ==  _AttributeName[intIndex])
{
mstrKeyWords = value.ToString();
 AddUpdatedFld(convFeatureFuncRela.KeyWords);
}
else if (convFeatureFuncRela.FeatureTypeId  ==  _AttributeName[intIndex])
{
mstrFeatureTypeId = value.ToString();
 AddUpdatedFld(convFeatureFuncRela.FeatureTypeId);
}
else if (convFeatureFuncRela.FeatureTypeName  ==  _AttributeName[intIndex])
{
mstrFeatureTypeName = value.ToString();
 AddUpdatedFld(convFeatureFuncRela.FeatureTypeName);
}
else if (convFeatureFuncRela.FeatureName2  ==  _AttributeName[intIndex])
{
mstrFeatureName2 = value.ToString();
 AddUpdatedFld(convFeatureFuncRela.FeatureName2);
}
else if (convFeatureFuncRela.FuncId4GC  ==  _AttributeName[intIndex])
{
mstrFuncId4GC = value.ToString();
 AddUpdatedFld(convFeatureFuncRela.FuncId4GC);
}
else if (convFeatureFuncRela.FuncName  ==  _AttributeName[intIndex])
{
mstrFuncName = value.ToString();
 AddUpdatedFld(convFeatureFuncRela.FuncName);
}
else if (convFeatureFuncRela.FuncId4Code  ==  _AttributeName[intIndex])
{
mstrFuncId4Code = value.ToString();
 AddUpdatedFld(convFeatureFuncRela.FuncId4Code);
}
else if (convFeatureFuncRela.FuncName4Code  ==  _AttributeName[intIndex])
{
mstrFuncName4Code = value.ToString();
 AddUpdatedFld(convFeatureFuncRela.FuncName4Code);
}
else if (convFeatureFuncRela.FunctionSignature  ==  _AttributeName[intIndex])
{
mstrFunctionSignature = value.ToString();
 AddUpdatedFld(convFeatureFuncRela.FunctionSignature);
}
else if (convFeatureFuncRela.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFeatureFuncRela.OrderNum);
}
else if (convFeatureFuncRela.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFeatureFuncRela.UpdDate);
}
else if (convFeatureFuncRela.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFeatureFuncRela.UpdUser);
}
else if (convFeatureFuncRela.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFeatureFuncRela.Memo);
}
else if (convFeatureFuncRela.FuncCodeTypeENName  ==  _AttributeName[intIndex])
{
mstrFuncCodeTypeENName = value.ToString();
 AddUpdatedFld(convFeatureFuncRela.FuncCodeTypeENName);
}
else if (convFeatureFuncRela.FuncCodeTypeId  ==  _AttributeName[intIndex])
{
mstrFuncCodeTypeId = value.ToString();
 AddUpdatedFld(convFeatureFuncRela.FuncCodeTypeId);
}
else if (convFeatureFuncRela.FuncCodeTypeName  ==  _AttributeName[intIndex])
{
mstrFuncCodeTypeName = value.ToString();
 AddUpdatedFld(convFeatureFuncRela.FuncCodeTypeName);
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
 AddUpdatedFld(convFeatureFuncRela.mId);
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
 AddUpdatedFld(convFeatureFuncRela.ApplicationTypeId);
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
 AddUpdatedFld(convFeatureFuncRela.ApplicationTypeName);
}
}
/// <summary>
/// 编程语言类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLangTypeName
{
get
{
return mstrProgLangTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLangTypeName = value;
}
else
{
 mstrProgLangTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureFuncRela.ProgLangTypeName);
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
 AddUpdatedFld(convFeatureFuncRela.FeatureId);
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
 AddUpdatedFld(convFeatureFuncRela.FeatureName);
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
 AddUpdatedFld(convFeatureFuncRela.KeyWords);
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
 AddUpdatedFld(convFeatureFuncRela.FeatureTypeId);
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
 AddUpdatedFld(convFeatureFuncRela.FeatureTypeName);
}
}
/// <summary>
/// 功能名-FuncCount(说明:;字段类型:varchar;字段长度:112;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FeatureName2
{
get
{
return mstrFeatureName2;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFeatureName2 = value;
}
else
{
 mstrFeatureName2 = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureFuncRela.FeatureName2);
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
 AddUpdatedFld(convFeatureFuncRela.FuncId4GC);
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
 AddUpdatedFld(convFeatureFuncRela.FuncName);
}
}
/// <summary>
/// 函数Id4Code(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncId4Code
{
get
{
return mstrFuncId4Code;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncId4Code = value;
}
else
{
 mstrFuncId4Code = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureFuncRela.FuncId4Code);
}
}
/// <summary>
/// 函数名4Code(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncName4Code
{
get
{
return mstrFuncName4Code;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncName4Code = value;
}
else
{
 mstrFuncName4Code = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureFuncRela.FuncName4Code);
}
}
/// <summary>
/// 函数签名(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FunctionSignature
{
get
{
return mstrFunctionSignature;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFunctionSignature = value;
}
else
{
 mstrFunctionSignature = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureFuncRela.FunctionSignature);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(convFeatureFuncRela.OrderNum);
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
 AddUpdatedFld(convFeatureFuncRela.UpdDate);
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
 AddUpdatedFld(convFeatureFuncRela.UpdUser);
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
 AddUpdatedFld(convFeatureFuncRela.Memo);
}
}
/// <summary>
/// FuncCodeTypeENName(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncCodeTypeENName
{
get
{
return mstrFuncCodeTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncCodeTypeENName = value;
}
else
{
 mstrFuncCodeTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureFuncRela.FuncCodeTypeENName);
}
}
/// <summary>
/// 函数代码类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncCodeTypeId
{
get
{
return mstrFuncCodeTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncCodeTypeId = value;
}
else
{
 mstrFuncCodeTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureFuncRela.FuncCodeTypeId);
}
}
/// <summary>
/// FuncCodeTypeName(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncCodeTypeName
{
get
{
return mstrFuncCodeTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncCodeTypeName = value;
}
else
{
 mstrFuncCodeTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureFuncRela.FuncCodeTypeName);
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
 /// v功能函数关系(vFeatureFuncRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convFeatureFuncRela
{
public const string _CurrTabName = "vFeatureFuncRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "ApplicationTypeId", "ApplicationTypeName", "ProgLangTypeName", "FeatureId", "FeatureName", "KeyWords", "FeatureTypeId", "FeatureTypeName", "FeatureName2", "FuncId4GC", "FuncName", "FuncId4Code", "FuncName4Code", "FunctionSignature", "OrderNum", "UpdDate", "UpdUser", "Memo", "FuncCodeTypeENName", "FuncCodeTypeId", "FuncCodeTypeName"};
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
 /// 常量:"ProgLangTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeName = "ProgLangTypeName";    //编程语言类型名

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
 /// 常量:"FeatureName2"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeatureName2 = "FeatureName2";    //功能名-FuncCount

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
 /// 常量:"FuncId4Code"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncId4Code = "FuncId4Code";    //函数Id4Code

 /// <summary>
 /// 常量:"FuncName4Code"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncName4Code = "FuncName4Code";    //函数名4Code

 /// <summary>
 /// 常量:"FunctionSignature"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FunctionSignature = "FunctionSignature";    //函数签名

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

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
 /// 常量:"FuncCodeTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncCodeTypeENName = "FuncCodeTypeENName";    //FuncCodeTypeENName

 /// <summary>
 /// 常量:"FuncCodeTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncCodeTypeId = "FuncCodeTypeId";    //函数代码类型Id

 /// <summary>
 /// 常量:"FuncCodeTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncCodeTypeName = "FuncCodeTypeName";    //FuncCodeTypeName
}

}