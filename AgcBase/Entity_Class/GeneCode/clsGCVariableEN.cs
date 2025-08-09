
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsGCVariableEN
 表名:GCVariable(00050559)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 19:59:31
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
 /// 表GCVariable的关键字(VarId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_VarId_GCVariable
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
public K_VarId_GCVariable(string strVarId)
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
 /// <returns>返回:[K_VarId_GCVariable]类型的对象</returns>
public static implicit operator K_VarId_GCVariable(string value)
{
return new K_VarId_GCVariable(value);
}
}
 /// <summary>
 /// GC变量(GCVariable)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsGCVariableEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "GCVariable"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "VarId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 13;
public static string[] _AttributeName = new string[] {"VarId", "VarName", "VarExpression", "FilePath", "InitValue", "VarTypeId", "DataTypeId", "VariableType", "VariableTypeFullName", "ClsName", "UpdDate", "UpdUser", "Memo"};

protected string mstrVarId;    //变量Id
protected string mstrVarName;    //变量名
protected string mstrVarExpression;    //变量表达式
protected string mstrFilePath;    //文件路径
protected string mstrInitValue;    //初始值
protected string mstrVarTypeId;    //变量类型Id
protected string mstrDataTypeId;    //数据类型Id
protected string mstrVariableType;    //变量类型
protected string mstrVariableTypeFullName;    //变量类型全名
protected string mstrClsName;    //类名
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsGCVariableEN()
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
public clsGCVariableEN(string strVarId)
 {
strVarId = strVarId.Replace("'", "''");
if (strVarId.Length > 8)
{
throw new Exception("在表:GCVariable中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strVarId)  ==  true)
{
throw new Exception("在表:GCVariable中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  conGCVariable.VarId)
{
return mstrVarId;
}
else if (strAttributeName  ==  conGCVariable.VarName)
{
return mstrVarName;
}
else if (strAttributeName  ==  conGCVariable.VarExpression)
{
return mstrVarExpression;
}
else if (strAttributeName  ==  conGCVariable.FilePath)
{
return mstrFilePath;
}
else if (strAttributeName  ==  conGCVariable.InitValue)
{
return mstrInitValue;
}
else if (strAttributeName  ==  conGCVariable.VarTypeId)
{
return mstrVarTypeId;
}
else if (strAttributeName  ==  conGCVariable.DataTypeId)
{
return mstrDataTypeId;
}
else if (strAttributeName  ==  conGCVariable.VariableType)
{
return mstrVariableType;
}
else if (strAttributeName  ==  conGCVariable.VariableTypeFullName)
{
return mstrVariableTypeFullName;
}
else if (strAttributeName  ==  conGCVariable.ClsName)
{
return mstrClsName;
}
else if (strAttributeName  ==  conGCVariable.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conGCVariable.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conGCVariable.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conGCVariable.VarId)
{
mstrVarId = value.ToString();
 AddUpdatedFld(conGCVariable.VarId);
}
else if (strAttributeName  ==  conGCVariable.VarName)
{
mstrVarName = value.ToString();
 AddUpdatedFld(conGCVariable.VarName);
}
else if (strAttributeName  ==  conGCVariable.VarExpression)
{
mstrVarExpression = value.ToString();
 AddUpdatedFld(conGCVariable.VarExpression);
}
else if (strAttributeName  ==  conGCVariable.FilePath)
{
mstrFilePath = value.ToString();
 AddUpdatedFld(conGCVariable.FilePath);
}
else if (strAttributeName  ==  conGCVariable.InitValue)
{
mstrInitValue = value.ToString();
 AddUpdatedFld(conGCVariable.InitValue);
}
else if (strAttributeName  ==  conGCVariable.VarTypeId)
{
mstrVarTypeId = value.ToString();
 AddUpdatedFld(conGCVariable.VarTypeId);
}
else if (strAttributeName  ==  conGCVariable.DataTypeId)
{
mstrDataTypeId = value.ToString();
 AddUpdatedFld(conGCVariable.DataTypeId);
}
else if (strAttributeName  ==  conGCVariable.VariableType)
{
mstrVariableType = value.ToString();
 AddUpdatedFld(conGCVariable.VariableType);
}
else if (strAttributeName  ==  conGCVariable.VariableTypeFullName)
{
mstrVariableTypeFullName = value.ToString();
 AddUpdatedFld(conGCVariable.VariableTypeFullName);
}
else if (strAttributeName  ==  conGCVariable.ClsName)
{
mstrClsName = value.ToString();
 AddUpdatedFld(conGCVariable.ClsName);
}
else if (strAttributeName  ==  conGCVariable.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conGCVariable.UpdDate);
}
else if (strAttributeName  ==  conGCVariable.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conGCVariable.UpdUser);
}
else if (strAttributeName  ==  conGCVariable.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conGCVariable.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conGCVariable.VarId  ==  _AttributeName[intIndex])
{
return mstrVarId;
}
else if (conGCVariable.VarName  ==  _AttributeName[intIndex])
{
return mstrVarName;
}
else if (conGCVariable.VarExpression  ==  _AttributeName[intIndex])
{
return mstrVarExpression;
}
else if (conGCVariable.FilePath  ==  _AttributeName[intIndex])
{
return mstrFilePath;
}
else if (conGCVariable.InitValue  ==  _AttributeName[intIndex])
{
return mstrInitValue;
}
else if (conGCVariable.VarTypeId  ==  _AttributeName[intIndex])
{
return mstrVarTypeId;
}
else if (conGCVariable.DataTypeId  ==  _AttributeName[intIndex])
{
return mstrDataTypeId;
}
else if (conGCVariable.VariableType  ==  _AttributeName[intIndex])
{
return mstrVariableType;
}
else if (conGCVariable.VariableTypeFullName  ==  _AttributeName[intIndex])
{
return mstrVariableTypeFullName;
}
else if (conGCVariable.ClsName  ==  _AttributeName[intIndex])
{
return mstrClsName;
}
else if (conGCVariable.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conGCVariable.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conGCVariable.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conGCVariable.VarId  ==  _AttributeName[intIndex])
{
mstrVarId = value.ToString();
 AddUpdatedFld(conGCVariable.VarId);
}
else if (conGCVariable.VarName  ==  _AttributeName[intIndex])
{
mstrVarName = value.ToString();
 AddUpdatedFld(conGCVariable.VarName);
}
else if (conGCVariable.VarExpression  ==  _AttributeName[intIndex])
{
mstrVarExpression = value.ToString();
 AddUpdatedFld(conGCVariable.VarExpression);
}
else if (conGCVariable.FilePath  ==  _AttributeName[intIndex])
{
mstrFilePath = value.ToString();
 AddUpdatedFld(conGCVariable.FilePath);
}
else if (conGCVariable.InitValue  ==  _AttributeName[intIndex])
{
mstrInitValue = value.ToString();
 AddUpdatedFld(conGCVariable.InitValue);
}
else if (conGCVariable.VarTypeId  ==  _AttributeName[intIndex])
{
mstrVarTypeId = value.ToString();
 AddUpdatedFld(conGCVariable.VarTypeId);
}
else if (conGCVariable.DataTypeId  ==  _AttributeName[intIndex])
{
mstrDataTypeId = value.ToString();
 AddUpdatedFld(conGCVariable.DataTypeId);
}
else if (conGCVariable.VariableType  ==  _AttributeName[intIndex])
{
mstrVariableType = value.ToString();
 AddUpdatedFld(conGCVariable.VariableType);
}
else if (conGCVariable.VariableTypeFullName  ==  _AttributeName[intIndex])
{
mstrVariableTypeFullName = value.ToString();
 AddUpdatedFld(conGCVariable.VariableTypeFullName);
}
else if (conGCVariable.ClsName  ==  _AttributeName[intIndex])
{
mstrClsName = value.ToString();
 AddUpdatedFld(conGCVariable.ClsName);
}
else if (conGCVariable.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conGCVariable.UpdDate);
}
else if (conGCVariable.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conGCVariable.UpdUser);
}
else if (conGCVariable.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conGCVariable.Memo);
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
 AddUpdatedFld(conGCVariable.VarId);
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
 AddUpdatedFld(conGCVariable.VarName);
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
 AddUpdatedFld(conGCVariable.VarExpression);
}
}
/// <summary>
/// 文件路径(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FilePath
{
get
{
return mstrFilePath;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFilePath = value;
}
else
{
 mstrFilePath = value;
}
//记录修改过的字段
 AddUpdatedFld(conGCVariable.FilePath);
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
 AddUpdatedFld(conGCVariable.InitValue);
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
 AddUpdatedFld(conGCVariable.VarTypeId);
}
}
/// <summary>
/// 数据类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataTypeId
{
get
{
return mstrDataTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataTypeId = value;
}
else
{
 mstrDataTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conGCVariable.DataTypeId);
}
}
/// <summary>
/// 变量类型(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VariableType
{
get
{
return mstrVariableType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVariableType = value;
}
else
{
 mstrVariableType = value;
}
//记录修改过的字段
 AddUpdatedFld(conGCVariable.VariableType);
}
}
/// <summary>
/// 变量类型全名(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VariableTypeFullName
{
get
{
return mstrVariableTypeFullName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVariableTypeFullName = value;
}
else
{
 mstrVariableTypeFullName = value;
}
//记录修改过的字段
 AddUpdatedFld(conGCVariable.VariableTypeFullName);
}
}
/// <summary>
/// 类名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClsName
{
get
{
return mstrClsName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClsName = value;
}
else
{
 mstrClsName = value;
}
//记录修改过的字段
 AddUpdatedFld(conGCVariable.ClsName);
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
 AddUpdatedFld(conGCVariable.UpdDate);
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
 AddUpdatedFld(conGCVariable.UpdUser);
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
 AddUpdatedFld(conGCVariable.Memo);
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

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrVarName;
 }
 }
}
 /// <summary>
 /// GC变量(GCVariable)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conGCVariable
{
public const string _CurrTabName = "GCVariable"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "VarId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"VarId", "VarName", "VarExpression", "FilePath", "InitValue", "VarTypeId", "DataTypeId", "VariableType", "VariableTypeFullName", "ClsName", "UpdDate", "UpdUser", "Memo"};
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
 /// 常量:"FilePath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FilePath = "FilePath";    //文件路径

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
 /// 常量:"DataTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataTypeId = "DataTypeId";    //数据类型Id

 /// <summary>
 /// 常量:"VariableType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VariableType = "VariableType";    //变量类型

 /// <summary>
 /// 常量:"VariableTypeFullName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VariableTypeFullName = "VariableTypeFullName";    //变量类型全名

 /// <summary>
 /// 常量:"ClsName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClsName = "ClsName";    //类名

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