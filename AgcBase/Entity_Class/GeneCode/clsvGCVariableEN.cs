
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvGCVariableEN
 表名:vGCVariable(00050561)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:36:48
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
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
 /// 表vGCVariable的关键字(VarId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_VarId_vGCVariable
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strVarId">表关键字</param>
public K_VarId_vGCVariable(string strVarId)
{
if (IsValid(strVarId)) Value = strVarId;
else
{
Value = null;
}
}
private static bool IsValid(string strVarId)
{
if (string.IsNullOrEmpty(strVarId) == true) return false;
if (strVarId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_VarId_vGCVariable]类型的对象</returns>
public static implicit operator K_VarId_vGCVariable(string value)
{
return new K_VarId_vGCVariable(value);
}
}
 /// <summary>
 /// vGCVariable(vGCVariable)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvGCVariableEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vGCVariable"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "VarId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 10;
public static string[] _AttributeName = new string[] {"VarId", "VarName", "VarExpression", "InitValue", "VarTypeId", "VarTypeName", "PrjId", "UpdDate", "UpdUser", "Memo"};

protected string mstrVarId;    //变量Id
protected string mstrVarName;    //变量名
protected string mstrVarExpression;    //变量表达式
protected string mstrInitValue;    //初始值
protected string mstrVarTypeId;    //变量类型Id
protected string mstrVarTypeName;    //变量类型名
protected string mstrPrjId;    //工程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvGCVariableEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("VarId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strVarId">关键字:变量Id</param>
public clsvGCVariableEN(string strVarId)
 {
strVarId = strVarId.Replace("'", "''");
if (strVarId.Length > 8)
{
throw new Exception("在表:vGCVariable中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strVarId)  ==  true)
{
throw new Exception("在表:vGCVariable中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strVarId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrVarId = strVarId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("VarId");
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
if (strAttributeName  ==  convGCVariable.VarId)
{
return mstrVarId;
}
else if (strAttributeName  ==  convGCVariable.VarName)
{
return mstrVarName;
}
else if (strAttributeName  ==  convGCVariable.VarExpression)
{
return mstrVarExpression;
}
else if (strAttributeName  ==  convGCVariable.InitValue)
{
return mstrInitValue;
}
else if (strAttributeName  ==  convGCVariable.VarTypeId)
{
return mstrVarTypeId;
}
else if (strAttributeName  ==  convGCVariable.VarTypeName)
{
return mstrVarTypeName;
}
else if (strAttributeName  ==  convGCVariable.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convGCVariable.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convGCVariable.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convGCVariable.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convGCVariable.VarId)
{
mstrVarId = value.ToString();
 AddUpdatedFld(convGCVariable.VarId);
}
else if (strAttributeName  ==  convGCVariable.VarName)
{
mstrVarName = value.ToString();
 AddUpdatedFld(convGCVariable.VarName);
}
else if (strAttributeName  ==  convGCVariable.VarExpression)
{
mstrVarExpression = value.ToString();
 AddUpdatedFld(convGCVariable.VarExpression);
}
else if (strAttributeName  ==  convGCVariable.InitValue)
{
mstrInitValue = value.ToString();
 AddUpdatedFld(convGCVariable.InitValue);
}
else if (strAttributeName  ==  convGCVariable.VarTypeId)
{
mstrVarTypeId = value.ToString();
 AddUpdatedFld(convGCVariable.VarTypeId);
}
else if (strAttributeName  ==  convGCVariable.VarTypeName)
{
mstrVarTypeName = value.ToString();
 AddUpdatedFld(convGCVariable.VarTypeName);
}
else if (strAttributeName  ==  convGCVariable.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convGCVariable.PrjId);
}
else if (strAttributeName  ==  convGCVariable.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convGCVariable.UpdDate);
}
else if (strAttributeName  ==  convGCVariable.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convGCVariable.UpdUser);
}
else if (strAttributeName  ==  convGCVariable.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convGCVariable.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convGCVariable.VarId  ==  _AttributeName[intIndex])
{
return mstrVarId;
}
else if (convGCVariable.VarName  ==  _AttributeName[intIndex])
{
return mstrVarName;
}
else if (convGCVariable.VarExpression  ==  _AttributeName[intIndex])
{
return mstrVarExpression;
}
else if (convGCVariable.InitValue  ==  _AttributeName[intIndex])
{
return mstrInitValue;
}
else if (convGCVariable.VarTypeId  ==  _AttributeName[intIndex])
{
return mstrVarTypeId;
}
else if (convGCVariable.VarTypeName  ==  _AttributeName[intIndex])
{
return mstrVarTypeName;
}
else if (convGCVariable.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convGCVariable.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convGCVariable.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convGCVariable.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convGCVariable.VarId  ==  _AttributeName[intIndex])
{
mstrVarId = value.ToString();
 AddUpdatedFld(convGCVariable.VarId);
}
else if (convGCVariable.VarName  ==  _AttributeName[intIndex])
{
mstrVarName = value.ToString();
 AddUpdatedFld(convGCVariable.VarName);
}
else if (convGCVariable.VarExpression  ==  _AttributeName[intIndex])
{
mstrVarExpression = value.ToString();
 AddUpdatedFld(convGCVariable.VarExpression);
}
else if (convGCVariable.InitValue  ==  _AttributeName[intIndex])
{
mstrInitValue = value.ToString();
 AddUpdatedFld(convGCVariable.InitValue);
}
else if (convGCVariable.VarTypeId  ==  _AttributeName[intIndex])
{
mstrVarTypeId = value.ToString();
 AddUpdatedFld(convGCVariable.VarTypeId);
}
else if (convGCVariable.VarTypeName  ==  _AttributeName[intIndex])
{
mstrVarTypeName = value.ToString();
 AddUpdatedFld(convGCVariable.VarTypeName);
}
else if (convGCVariable.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convGCVariable.PrjId);
}
else if (convGCVariable.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convGCVariable.UpdDate);
}
else if (convGCVariable.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convGCVariable.UpdUser);
}
else if (convGCVariable.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convGCVariable.Memo);
}
}
}

/// <summary>
/// 变量Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VarId
{
get
{
return mstrVarId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVarId = value;
}
else
{
 mstrVarId = value;
}
//记录修改过的字段
 AddUpdatedFld(convGCVariable.VarId);
}
}
/// <summary>
/// 变量名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VarName
{
get
{
return mstrVarName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVarName = value;
}
else
{
 mstrVarName = value;
}
//记录修改过的字段
 AddUpdatedFld(convGCVariable.VarName);
}
}
/// <summary>
/// 变量表达式(说明:;字段类型:varchar;字段长度:150;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VarExpression
{
get
{
return mstrVarExpression;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVarExpression = value;
}
else
{
 mstrVarExpression = value;
}
//记录修改过的字段
 AddUpdatedFld(convGCVariable.VarExpression);
}
}
/// <summary>
/// 初始值(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string InitValue
{
get
{
return mstrInitValue;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrInitValue = value;
}
else
{
 mstrInitValue = value;
}
//记录修改过的字段
 AddUpdatedFld(convGCVariable.InitValue);
}
}
/// <summary>
/// 变量类型Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VarTypeId
{
get
{
return mstrVarTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVarTypeId = value;
}
else
{
 mstrVarTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convGCVariable.VarTypeId);
}
}
/// <summary>
/// 变量类型名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VarTypeName
{
get
{
return mstrVarTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVarTypeName = value;
}
else
{
 mstrVarTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convGCVariable.VarTypeName);
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
 AddUpdatedFld(convGCVariable.PrjId);
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
 AddUpdatedFld(convGCVariable.UpdDate);
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
 AddUpdatedFld(convGCVariable.UpdUser);
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
 AddUpdatedFld(convGCVariable.Memo);
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
  return mstrVarId;
 }
 }
}
 /// <summary>
 /// vGCVariable(vGCVariable)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convGCVariable
{
public const string _CurrTabName = "vGCVariable"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "VarId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"VarId", "VarName", "VarExpression", "InitValue", "VarTypeId", "VarTypeName", "PrjId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"VarId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VarId = "VarId";    //变量Id

 /// <summary>
 /// 常量:"VarName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VarName = "VarName";    //变量名

 /// <summary>
 /// 常量:"VarExpression"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VarExpression = "VarExpression";    //变量表达式

 /// <summary>
 /// 常量:"InitValue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InitValue = "InitValue";    //初始值

 /// <summary>
 /// 常量:"VarTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VarTypeId = "VarTypeId";    //变量类型Id

 /// <summary>
 /// 常量:"VarTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VarTypeName = "VarTypeName";    //变量类型名

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