
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsGCDefaConstantsEN
 表名:GCDefaConstants(00050640)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 19:59:23
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
 /// 表GCDefaConstants的关键字(ConstId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ConstId_GCDefaConstants
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strConstId">表关键字</param>
public K_ConstId_GCDefaConstants(string strConstId)
{
if (IsValid(strConstId)) Value = strConstId;
else
{
Value = null;
}
}
private static bool IsValid(string strConstId)
{
if (string.IsNullOrEmpty(strConstId) == true) return false;
if (strConstId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ConstId_GCDefaConstants]类型的对象</returns>
public static implicit operator K_ConstId_GCDefaConstants(string value)
{
return new K_ConstId_GCDefaConstants(value);
}
}
 /// <summary>
 /// GC常量(GCDefaConstants)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsGCDefaConstantsEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "GCDefaConstants"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ConstId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 10;
public static string[] _AttributeName = new string[] {"ConstId", "ConstName", "ConstExpression", "FilePath", "InitValue", "DataTypeId", "ClsName", "UpdDate", "UpdUser", "Memo"};

protected string mstrConstId;    //常量Id
protected string mstrConstName;    //常量名
protected string mstrConstExpression;    //常量表达式
protected string mstrFilePath;    //文件路径
protected string mstrInitValue;    //初始值
protected string mstrDataTypeId;    //数据类型Id
protected string mstrClsName;    //类名
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsGCDefaConstantsEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ConstId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strConstId">关键字:常量Id</param>
public clsGCDefaConstantsEN(string strConstId)
 {
strConstId = strConstId.Replace("'", "''");
if (strConstId.Length > 8)
{
throw new Exception("在表:GCDefaConstants中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strConstId)  ==  true)
{
throw new Exception("在表:GCDefaConstants中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strConstId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrConstId = strConstId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ConstId");
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
if (strAttributeName  ==  conGCDefaConstants.ConstId)
{
return mstrConstId;
}
else if (strAttributeName  ==  conGCDefaConstants.ConstName)
{
return mstrConstName;
}
else if (strAttributeName  ==  conGCDefaConstants.ConstExpression)
{
return mstrConstExpression;
}
else if (strAttributeName  ==  conGCDefaConstants.FilePath)
{
return mstrFilePath;
}
else if (strAttributeName  ==  conGCDefaConstants.InitValue)
{
return mstrInitValue;
}
else if (strAttributeName  ==  conGCDefaConstants.DataTypeId)
{
return mstrDataTypeId;
}
else if (strAttributeName  ==  conGCDefaConstants.ClsName)
{
return mstrClsName;
}
else if (strAttributeName  ==  conGCDefaConstants.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conGCDefaConstants.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conGCDefaConstants.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conGCDefaConstants.ConstId)
{
mstrConstId = value.ToString();
 AddUpdatedFld(conGCDefaConstants.ConstId);
}
else if (strAttributeName  ==  conGCDefaConstants.ConstName)
{
mstrConstName = value.ToString();
 AddUpdatedFld(conGCDefaConstants.ConstName);
}
else if (strAttributeName  ==  conGCDefaConstants.ConstExpression)
{
mstrConstExpression = value.ToString();
 AddUpdatedFld(conGCDefaConstants.ConstExpression);
}
else if (strAttributeName  ==  conGCDefaConstants.FilePath)
{
mstrFilePath = value.ToString();
 AddUpdatedFld(conGCDefaConstants.FilePath);
}
else if (strAttributeName  ==  conGCDefaConstants.InitValue)
{
mstrInitValue = value.ToString();
 AddUpdatedFld(conGCDefaConstants.InitValue);
}
else if (strAttributeName  ==  conGCDefaConstants.DataTypeId)
{
mstrDataTypeId = value.ToString();
 AddUpdatedFld(conGCDefaConstants.DataTypeId);
}
else if (strAttributeName  ==  conGCDefaConstants.ClsName)
{
mstrClsName = value.ToString();
 AddUpdatedFld(conGCDefaConstants.ClsName);
}
else if (strAttributeName  ==  conGCDefaConstants.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conGCDefaConstants.UpdDate);
}
else if (strAttributeName  ==  conGCDefaConstants.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conGCDefaConstants.UpdUser);
}
else if (strAttributeName  ==  conGCDefaConstants.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conGCDefaConstants.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conGCDefaConstants.ConstId  ==  _AttributeName[intIndex])
{
return mstrConstId;
}
else if (conGCDefaConstants.ConstName  ==  _AttributeName[intIndex])
{
return mstrConstName;
}
else if (conGCDefaConstants.ConstExpression  ==  _AttributeName[intIndex])
{
return mstrConstExpression;
}
else if (conGCDefaConstants.FilePath  ==  _AttributeName[intIndex])
{
return mstrFilePath;
}
else if (conGCDefaConstants.InitValue  ==  _AttributeName[intIndex])
{
return mstrInitValue;
}
else if (conGCDefaConstants.DataTypeId  ==  _AttributeName[intIndex])
{
return mstrDataTypeId;
}
else if (conGCDefaConstants.ClsName  ==  _AttributeName[intIndex])
{
return mstrClsName;
}
else if (conGCDefaConstants.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conGCDefaConstants.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conGCDefaConstants.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conGCDefaConstants.ConstId  ==  _AttributeName[intIndex])
{
mstrConstId = value.ToString();
 AddUpdatedFld(conGCDefaConstants.ConstId);
}
else if (conGCDefaConstants.ConstName  ==  _AttributeName[intIndex])
{
mstrConstName = value.ToString();
 AddUpdatedFld(conGCDefaConstants.ConstName);
}
else if (conGCDefaConstants.ConstExpression  ==  _AttributeName[intIndex])
{
mstrConstExpression = value.ToString();
 AddUpdatedFld(conGCDefaConstants.ConstExpression);
}
else if (conGCDefaConstants.FilePath  ==  _AttributeName[intIndex])
{
mstrFilePath = value.ToString();
 AddUpdatedFld(conGCDefaConstants.FilePath);
}
else if (conGCDefaConstants.InitValue  ==  _AttributeName[intIndex])
{
mstrInitValue = value.ToString();
 AddUpdatedFld(conGCDefaConstants.InitValue);
}
else if (conGCDefaConstants.DataTypeId  ==  _AttributeName[intIndex])
{
mstrDataTypeId = value.ToString();
 AddUpdatedFld(conGCDefaConstants.DataTypeId);
}
else if (conGCDefaConstants.ClsName  ==  _AttributeName[intIndex])
{
mstrClsName = value.ToString();
 AddUpdatedFld(conGCDefaConstants.ClsName);
}
else if (conGCDefaConstants.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conGCDefaConstants.UpdDate);
}
else if (conGCDefaConstants.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conGCDefaConstants.UpdUser);
}
else if (conGCDefaConstants.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conGCDefaConstants.Memo);
}
}
}

/// <summary>
/// 常量Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ConstId
{
get
{
return mstrConstId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrConstId = value;
}
else
{
 mstrConstId = value;
}
//记录修改过的字段
 AddUpdatedFld(conGCDefaConstants.ConstId);
}
}
/// <summary>
/// 常量名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ConstName
{
get
{
return mstrConstName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrConstName = value;
}
else
{
 mstrConstName = value;
}
//记录修改过的字段
 AddUpdatedFld(conGCDefaConstants.ConstName);
}
}
/// <summary>
/// 常量表达式(说明:;字段类型:varchar;字段长度:150;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ConstExpression
{
get
{
return mstrConstExpression;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrConstExpression = value;
}
else
{
 mstrConstExpression = value;
}
//记录修改过的字段
 AddUpdatedFld(conGCDefaConstants.ConstExpression);
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
 AddUpdatedFld(conGCDefaConstants.FilePath);
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
 AddUpdatedFld(conGCDefaConstants.InitValue);
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
 AddUpdatedFld(conGCDefaConstants.DataTypeId);
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
 AddUpdatedFld(conGCDefaConstants.ClsName);
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
 AddUpdatedFld(conGCDefaConstants.UpdDate);
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
 AddUpdatedFld(conGCDefaConstants.UpdUser);
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
 AddUpdatedFld(conGCDefaConstants.Memo);
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
  return mstrConstId;
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
  return mstrConstName;
 }
 }
}
 /// <summary>
 /// GC常量(GCDefaConstants)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conGCDefaConstants
{
public const string _CurrTabName = "GCDefaConstants"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ConstId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"ConstId", "ConstName", "ConstExpression", "FilePath", "InitValue", "DataTypeId", "ClsName", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"ConstId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConstId = "ConstId";    //常量Id

 /// <summary>
 /// 常量:"ConstName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConstName = "ConstName";    //常量名

 /// <summary>
 /// 常量:"ConstExpression"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConstExpression = "ConstExpression";    //常量表达式

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
 /// 常量:"DataTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataTypeId = "DataTypeId";    //数据类型Id

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