
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFunctionGroupRelaEN
 表名:vFunctionGroupRela(00050329)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:13:37
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
 /// 表vFunctionGroupRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vFunctionGroupRela
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
public K_mId_vFunctionGroupRela(long lngmId)
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
 /// <returns>返回:[K_mId_vFunctionGroupRela]类型的对象</returns>
public static implicit operator K_mId_vFunctionGroupRela(long value)
{
return new K_mId_vFunctionGroupRela(value);
}
}
 /// <summary>
 /// v函数与组关系(vFunctionGroupRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvFunctionGroupRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vFunctionGroupRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 12;
public static string[] _AttributeName = new string[] {"mId", "FunctionGroupId", "FunctionGroupName", "ProgLangTypeId", "ProgLangTypeName", "CreateUserId", "FuncId4GC", "FuncName", "IsTemplate", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrFunctionGroupId;    //函数组Id
protected string mstrFunctionGroupName;    //函数组名称
protected string mstrProgLangTypeId;    //编程语言类型Id
protected string mstrProgLangTypeName;    //编程语言类型名
protected string mstrCreateUserId;    //建立用户Id
protected string mstrFuncId4GC;    //函数ID
protected string mstrFuncName;    //函数名
protected bool mbolIsTemplate;    //是否模板
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvFunctionGroupRelaEN()
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
public clsvFunctionGroupRelaEN(long lngmId)
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
if (strAttributeName  ==  convFunctionGroupRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convFunctionGroupRela.FunctionGroupId)
{
return mstrFunctionGroupId;
}
else if (strAttributeName  ==  convFunctionGroupRela.FunctionGroupName)
{
return mstrFunctionGroupName;
}
else if (strAttributeName  ==  convFunctionGroupRela.ProgLangTypeId)
{
return mstrProgLangTypeId;
}
else if (strAttributeName  ==  convFunctionGroupRela.ProgLangTypeName)
{
return mstrProgLangTypeName;
}
else if (strAttributeName  ==  convFunctionGroupRela.CreateUserId)
{
return mstrCreateUserId;
}
else if (strAttributeName  ==  convFunctionGroupRela.FuncId4GC)
{
return mstrFuncId4GC;
}
else if (strAttributeName  ==  convFunctionGroupRela.FuncName)
{
return mstrFuncName;
}
else if (strAttributeName  ==  convFunctionGroupRela.IsTemplate)
{
return mbolIsTemplate;
}
else if (strAttributeName  ==  convFunctionGroupRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convFunctionGroupRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convFunctionGroupRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convFunctionGroupRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convFunctionGroupRela.mId);
}
else if (strAttributeName  ==  convFunctionGroupRela.FunctionGroupId)
{
mstrFunctionGroupId = value.ToString();
 AddUpdatedFld(convFunctionGroupRela.FunctionGroupId);
}
else if (strAttributeName  ==  convFunctionGroupRela.FunctionGroupName)
{
mstrFunctionGroupName = value.ToString();
 AddUpdatedFld(convFunctionGroupRela.FunctionGroupName);
}
else if (strAttributeName  ==  convFunctionGroupRela.ProgLangTypeId)
{
mstrProgLangTypeId = value.ToString();
 AddUpdatedFld(convFunctionGroupRela.ProgLangTypeId);
}
else if (strAttributeName  ==  convFunctionGroupRela.ProgLangTypeName)
{
mstrProgLangTypeName = value.ToString();
 AddUpdatedFld(convFunctionGroupRela.ProgLangTypeName);
}
else if (strAttributeName  ==  convFunctionGroupRela.CreateUserId)
{
mstrCreateUserId = value.ToString();
 AddUpdatedFld(convFunctionGroupRela.CreateUserId);
}
else if (strAttributeName  ==  convFunctionGroupRela.FuncId4GC)
{
mstrFuncId4GC = value.ToString();
 AddUpdatedFld(convFunctionGroupRela.FuncId4GC);
}
else if (strAttributeName  ==  convFunctionGroupRela.FuncName)
{
mstrFuncName = value.ToString();
 AddUpdatedFld(convFunctionGroupRela.FuncName);
}
else if (strAttributeName  ==  convFunctionGroupRela.IsTemplate)
{
mbolIsTemplate = TransNullToBool(value.ToString());
 AddUpdatedFld(convFunctionGroupRela.IsTemplate);
}
else if (strAttributeName  ==  convFunctionGroupRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFunctionGroupRela.UpdDate);
}
else if (strAttributeName  ==  convFunctionGroupRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFunctionGroupRela.UpdUser);
}
else if (strAttributeName  ==  convFunctionGroupRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFunctionGroupRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convFunctionGroupRela.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (convFunctionGroupRela.FunctionGroupId  ==  _AttributeName[intIndex])
{
return mstrFunctionGroupId;
}
else if (convFunctionGroupRela.FunctionGroupName  ==  _AttributeName[intIndex])
{
return mstrFunctionGroupName;
}
else if (convFunctionGroupRela.ProgLangTypeId  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeId;
}
else if (convFunctionGroupRela.ProgLangTypeName  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeName;
}
else if (convFunctionGroupRela.CreateUserId  ==  _AttributeName[intIndex])
{
return mstrCreateUserId;
}
else if (convFunctionGroupRela.FuncId4GC  ==  _AttributeName[intIndex])
{
return mstrFuncId4GC;
}
else if (convFunctionGroupRela.FuncName  ==  _AttributeName[intIndex])
{
return mstrFuncName;
}
else if (convFunctionGroupRela.IsTemplate  ==  _AttributeName[intIndex])
{
return mbolIsTemplate;
}
else if (convFunctionGroupRela.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convFunctionGroupRela.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convFunctionGroupRela.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convFunctionGroupRela.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convFunctionGroupRela.mId);
}
else if (convFunctionGroupRela.FunctionGroupId  ==  _AttributeName[intIndex])
{
mstrFunctionGroupId = value.ToString();
 AddUpdatedFld(convFunctionGroupRela.FunctionGroupId);
}
else if (convFunctionGroupRela.FunctionGroupName  ==  _AttributeName[intIndex])
{
mstrFunctionGroupName = value.ToString();
 AddUpdatedFld(convFunctionGroupRela.FunctionGroupName);
}
else if (convFunctionGroupRela.ProgLangTypeId  ==  _AttributeName[intIndex])
{
mstrProgLangTypeId = value.ToString();
 AddUpdatedFld(convFunctionGroupRela.ProgLangTypeId);
}
else if (convFunctionGroupRela.ProgLangTypeName  ==  _AttributeName[intIndex])
{
mstrProgLangTypeName = value.ToString();
 AddUpdatedFld(convFunctionGroupRela.ProgLangTypeName);
}
else if (convFunctionGroupRela.CreateUserId  ==  _AttributeName[intIndex])
{
mstrCreateUserId = value.ToString();
 AddUpdatedFld(convFunctionGroupRela.CreateUserId);
}
else if (convFunctionGroupRela.FuncId4GC  ==  _AttributeName[intIndex])
{
mstrFuncId4GC = value.ToString();
 AddUpdatedFld(convFunctionGroupRela.FuncId4GC);
}
else if (convFunctionGroupRela.FuncName  ==  _AttributeName[intIndex])
{
mstrFuncName = value.ToString();
 AddUpdatedFld(convFunctionGroupRela.FuncName);
}
else if (convFunctionGroupRela.IsTemplate  ==  _AttributeName[intIndex])
{
mbolIsTemplate = TransNullToBool(value.ToString());
 AddUpdatedFld(convFunctionGroupRela.IsTemplate);
}
else if (convFunctionGroupRela.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFunctionGroupRela.UpdDate);
}
else if (convFunctionGroupRela.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFunctionGroupRela.UpdUser);
}
else if (convFunctionGroupRela.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFunctionGroupRela.Memo);
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
 AddUpdatedFld(convFunctionGroupRela.mId);
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
 AddUpdatedFld(convFunctionGroupRela.FunctionGroupId);
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
 AddUpdatedFld(convFunctionGroupRela.FunctionGroupName);
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
 AddUpdatedFld(convFunctionGroupRela.ProgLangTypeId);
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
 AddUpdatedFld(convFunctionGroupRela.ProgLangTypeName);
}
}
/// <summary>
/// 建立用户Id(说明:;字段类型:varchar;字段长度:18;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CreateUserId
{
get
{
return mstrCreateUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCreateUserId = value;
}
else
{
 mstrCreateUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunctionGroupRela.CreateUserId);
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
 AddUpdatedFld(convFunctionGroupRela.FuncId4GC);
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
 AddUpdatedFld(convFunctionGroupRela.FuncName);
}
}
/// <summary>
/// 是否模板(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsTemplate
{
get
{
return mbolIsTemplate;
}
set
{
 mbolIsTemplate = value;
//记录修改过的字段
 AddUpdatedFld(convFunctionGroupRela.IsTemplate);
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
 AddUpdatedFld(convFunctionGroupRela.UpdDate);
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
 AddUpdatedFld(convFunctionGroupRela.UpdUser);
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
 AddUpdatedFld(convFunctionGroupRela.Memo);
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
 /// v函数与组关系(vFunctionGroupRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convFunctionGroupRela
{
public const string _CurrTabName = "vFunctionGroupRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "FunctionGroupId", "FunctionGroupName", "ProgLangTypeId", "ProgLangTypeName", "CreateUserId", "FuncId4GC", "FuncName", "IsTemplate", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

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
 /// 常量:"ProgLangTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeId = "ProgLangTypeId";    //编程语言类型Id

 /// <summary>
 /// 常量:"ProgLangTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeName = "ProgLangTypeName";    //编程语言类型名

 /// <summary>
 /// 常量:"CreateUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreateUserId = "CreateUserId";    //建立用户Id

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
 /// 常量:"IsTemplate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsTemplate = "IsTemplate";    //是否模板

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