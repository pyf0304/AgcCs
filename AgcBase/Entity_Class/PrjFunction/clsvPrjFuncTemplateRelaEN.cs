
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjFuncTemplateRelaEN
 表名:vPrjFuncTemplateRela(00050318)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:11:55
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
 /// 表vPrjFuncTemplateRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vPrjFuncTemplateRela
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
public K_mId_vPrjFuncTemplateRela(long lngmId)
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
 /// <returns>返回:[K_mId_vPrjFuncTemplateRela]类型的对象</returns>
public static implicit operator K_mId_vPrjFuncTemplateRela(long value)
{
return new K_mId_vPrjFuncTemplateRela(value);
}
}
 /// <summary>
 /// v工程与函数模板关系(vPrjFuncTemplateRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvPrjFuncTemplateRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vPrjFuncTemplateRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 13;
public static string[] _AttributeName = new string[] {"ProgLangTypeName", "FunctionTemplateName", "CodeTypeENName", "CodeTypeName", "mId", "PrjId", "PrjName", "CodeTypeId", "ProgLangTypeId", "FunctionTemplateId", "UpdDate", "UpdUser", "Memo"};

protected string mstrProgLangTypeName;    //编程语言类型名
protected string mstrFunctionTemplateName;    //函数模板名
protected string mstrCodeTypeENName;    //代码类型英文名
protected string mstrCodeTypeName;    //代码类型名
protected long mlngmId;    //mId
protected string mstrPrjId;    //工程Id
protected string mstrPrjName;    //工程名称
protected string mstrCodeTypeId;    //代码类型Id
protected string mstrProgLangTypeId;    //编程语言类型Id
protected string mstrFunctionTemplateId;    //函数模板Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvPrjFuncTemplateRelaEN()
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
public clsvPrjFuncTemplateRelaEN(long lngmId)
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
if (strAttributeName  ==  convPrjFuncTemplateRela.ProgLangTypeName)
{
return mstrProgLangTypeName;
}
else if (strAttributeName  ==  convPrjFuncTemplateRela.FunctionTemplateName)
{
return mstrFunctionTemplateName;
}
else if (strAttributeName  ==  convPrjFuncTemplateRela.CodeTypeENName)
{
return mstrCodeTypeENName;
}
else if (strAttributeName  ==  convPrjFuncTemplateRela.CodeTypeName)
{
return mstrCodeTypeName;
}
else if (strAttributeName  ==  convPrjFuncTemplateRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convPrjFuncTemplateRela.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convPrjFuncTemplateRela.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convPrjFuncTemplateRela.CodeTypeId)
{
return mstrCodeTypeId;
}
else if (strAttributeName  ==  convPrjFuncTemplateRela.ProgLangTypeId)
{
return mstrProgLangTypeId;
}
else if (strAttributeName  ==  convPrjFuncTemplateRela.FunctionTemplateId)
{
return mstrFunctionTemplateId;
}
else if (strAttributeName  ==  convPrjFuncTemplateRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convPrjFuncTemplateRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convPrjFuncTemplateRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convPrjFuncTemplateRela.ProgLangTypeName)
{
mstrProgLangTypeName = value.ToString();
 AddUpdatedFld(convPrjFuncTemplateRela.ProgLangTypeName);
}
else if (strAttributeName  ==  convPrjFuncTemplateRela.FunctionTemplateName)
{
mstrFunctionTemplateName = value.ToString();
 AddUpdatedFld(convPrjFuncTemplateRela.FunctionTemplateName);
}
else if (strAttributeName  ==  convPrjFuncTemplateRela.CodeTypeENName)
{
mstrCodeTypeENName = value.ToString();
 AddUpdatedFld(convPrjFuncTemplateRela.CodeTypeENName);
}
else if (strAttributeName  ==  convPrjFuncTemplateRela.CodeTypeName)
{
mstrCodeTypeName = value.ToString();
 AddUpdatedFld(convPrjFuncTemplateRela.CodeTypeName);
}
else if (strAttributeName  ==  convPrjFuncTemplateRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convPrjFuncTemplateRela.mId);
}
else if (strAttributeName  ==  convPrjFuncTemplateRela.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convPrjFuncTemplateRela.PrjId);
}
else if (strAttributeName  ==  convPrjFuncTemplateRela.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convPrjFuncTemplateRela.PrjName);
}
else if (strAttributeName  ==  convPrjFuncTemplateRela.CodeTypeId)
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(convPrjFuncTemplateRela.CodeTypeId);
}
else if (strAttributeName  ==  convPrjFuncTemplateRela.ProgLangTypeId)
{
mstrProgLangTypeId = value.ToString();
 AddUpdatedFld(convPrjFuncTemplateRela.ProgLangTypeId);
}
else if (strAttributeName  ==  convPrjFuncTemplateRela.FunctionTemplateId)
{
mstrFunctionTemplateId = value.ToString();
 AddUpdatedFld(convPrjFuncTemplateRela.FunctionTemplateId);
}
else if (strAttributeName  ==  convPrjFuncTemplateRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convPrjFuncTemplateRela.UpdDate);
}
else if (strAttributeName  ==  convPrjFuncTemplateRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convPrjFuncTemplateRela.UpdUser);
}
else if (strAttributeName  ==  convPrjFuncTemplateRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convPrjFuncTemplateRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convPrjFuncTemplateRela.ProgLangTypeName  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeName;
}
else if (convPrjFuncTemplateRela.FunctionTemplateName  ==  _AttributeName[intIndex])
{
return mstrFunctionTemplateName;
}
else if (convPrjFuncTemplateRela.CodeTypeENName  ==  _AttributeName[intIndex])
{
return mstrCodeTypeENName;
}
else if (convPrjFuncTemplateRela.CodeTypeName  ==  _AttributeName[intIndex])
{
return mstrCodeTypeName;
}
else if (convPrjFuncTemplateRela.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (convPrjFuncTemplateRela.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convPrjFuncTemplateRela.PrjName  ==  _AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convPrjFuncTemplateRela.CodeTypeId  ==  _AttributeName[intIndex])
{
return mstrCodeTypeId;
}
else if (convPrjFuncTemplateRela.ProgLangTypeId  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeId;
}
else if (convPrjFuncTemplateRela.FunctionTemplateId  ==  _AttributeName[intIndex])
{
return mstrFunctionTemplateId;
}
else if (convPrjFuncTemplateRela.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convPrjFuncTemplateRela.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convPrjFuncTemplateRela.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convPrjFuncTemplateRela.ProgLangTypeName  ==  _AttributeName[intIndex])
{
mstrProgLangTypeName = value.ToString();
 AddUpdatedFld(convPrjFuncTemplateRela.ProgLangTypeName);
}
else if (convPrjFuncTemplateRela.FunctionTemplateName  ==  _AttributeName[intIndex])
{
mstrFunctionTemplateName = value.ToString();
 AddUpdatedFld(convPrjFuncTemplateRela.FunctionTemplateName);
}
else if (convPrjFuncTemplateRela.CodeTypeENName  ==  _AttributeName[intIndex])
{
mstrCodeTypeENName = value.ToString();
 AddUpdatedFld(convPrjFuncTemplateRela.CodeTypeENName);
}
else if (convPrjFuncTemplateRela.CodeTypeName  ==  _AttributeName[intIndex])
{
mstrCodeTypeName = value.ToString();
 AddUpdatedFld(convPrjFuncTemplateRela.CodeTypeName);
}
else if (convPrjFuncTemplateRela.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convPrjFuncTemplateRela.mId);
}
else if (convPrjFuncTemplateRela.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convPrjFuncTemplateRela.PrjId);
}
else if (convPrjFuncTemplateRela.PrjName  ==  _AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convPrjFuncTemplateRela.PrjName);
}
else if (convPrjFuncTemplateRela.CodeTypeId  ==  _AttributeName[intIndex])
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(convPrjFuncTemplateRela.CodeTypeId);
}
else if (convPrjFuncTemplateRela.ProgLangTypeId  ==  _AttributeName[intIndex])
{
mstrProgLangTypeId = value.ToString();
 AddUpdatedFld(convPrjFuncTemplateRela.ProgLangTypeId);
}
else if (convPrjFuncTemplateRela.FunctionTemplateId  ==  _AttributeName[intIndex])
{
mstrFunctionTemplateId = value.ToString();
 AddUpdatedFld(convPrjFuncTemplateRela.FunctionTemplateId);
}
else if (convPrjFuncTemplateRela.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convPrjFuncTemplateRela.UpdDate);
}
else if (convPrjFuncTemplateRela.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convPrjFuncTemplateRela.UpdUser);
}
else if (convPrjFuncTemplateRela.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convPrjFuncTemplateRela.Memo);
}
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
 AddUpdatedFld(convPrjFuncTemplateRela.ProgLangTypeName);
}
}
/// <summary>
/// 函数模板名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FunctionTemplateName
{
get
{
return mstrFunctionTemplateName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFunctionTemplateName = value;
}
else
{
 mstrFunctionTemplateName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjFuncTemplateRela.FunctionTemplateName);
}
}
/// <summary>
/// 代码类型英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTypeENName
{
get
{
return mstrCodeTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTypeENName = value;
}
else
{
 mstrCodeTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjFuncTemplateRela.CodeTypeENName);
}
}
/// <summary>
/// 代码类型名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTypeName
{
get
{
return mstrCodeTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTypeName = value;
}
else
{
 mstrCodeTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjFuncTemplateRela.CodeTypeName);
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
 AddUpdatedFld(convPrjFuncTemplateRela.mId);
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
 AddUpdatedFld(convPrjFuncTemplateRela.PrjId);
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
 AddUpdatedFld(convPrjFuncTemplateRela.PrjName);
}
}
/// <summary>
/// 代码类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTypeId
{
get
{
return mstrCodeTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTypeId = value;
}
else
{
 mstrCodeTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjFuncTemplateRela.CodeTypeId);
}
}
/// <summary>
/// 编程语言类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLangTypeId
{
get
{
return mstrProgLangTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLangTypeId = value;
}
else
{
 mstrProgLangTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjFuncTemplateRela.ProgLangTypeId);
}
}
/// <summary>
/// 函数模板Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FunctionTemplateId
{
get
{
return mstrFunctionTemplateId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFunctionTemplateId = value;
}
else
{
 mstrFunctionTemplateId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjFuncTemplateRela.FunctionTemplateId);
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
 AddUpdatedFld(convPrjFuncTemplateRela.UpdDate);
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
 AddUpdatedFld(convPrjFuncTemplateRela.UpdUser);
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
 AddUpdatedFld(convPrjFuncTemplateRela.Memo);
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
 /// v工程与函数模板关系(vPrjFuncTemplateRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convPrjFuncTemplateRela
{
public const string _CurrTabName = "vPrjFuncTemplateRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"ProgLangTypeName", "FunctionTemplateName", "CodeTypeENName", "CodeTypeName", "mId", "PrjId", "PrjName", "CodeTypeId", "ProgLangTypeId", "FunctionTemplateId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"ProgLangTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeName = "ProgLangTypeName";    //编程语言类型名

 /// <summary>
 /// 常量:"FunctionTemplateName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FunctionTemplateName = "FunctionTemplateName";    //函数模板名

 /// <summary>
 /// 常量:"CodeTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTypeENName = "CodeTypeENName";    //代码类型英文名

 /// <summary>
 /// 常量:"CodeTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTypeName = "CodeTypeName";    //代码类型名

 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

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
 /// 常量:"CodeTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTypeId = "CodeTypeId";    //代码类型Id

 /// <summary>
 /// 常量:"ProgLangTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeId = "ProgLangTypeId";    //编程语言类型Id

 /// <summary>
 /// 常量:"FunctionTemplateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FunctionTemplateId = "FunctionTemplateId";    //函数模板Id

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