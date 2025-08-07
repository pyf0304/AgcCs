
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsGCVariableTypeEN
 表名:GCVariableType(00050560)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:31:56
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
 /// 表GCVariableType的关键字(VarTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_VarTypeId_GCVariableType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strVarTypeId">表关键字</param>
public K_VarTypeId_GCVariableType(string strVarTypeId)
{
if (IsValid(strVarTypeId)) Value = strVarTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strVarTypeId)
{
if (string.IsNullOrEmpty(strVarTypeId) == true) return false;
if (strVarTypeId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_VarTypeId_GCVariableType]类型的对象</returns>
public static implicit operator K_VarTypeId_GCVariableType(string value)
{
return new K_VarTypeId_GCVariableType(value);
}
}
 /// <summary>
 /// GC变量类型(GCVariableType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsGCVariableTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "GCVariableType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "VarTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 7;
public static string[] _AttributeName = new string[] {"VarTypeId", "VarTypeName", "VarTypeENName", "VarTypeSimName", "UpdDate", "UpdUser", "Memo"};

protected string mstrVarTypeId;    //变量类型Id
protected string mstrVarTypeName;    //变量类型名
protected string mstrVarTypeENName;    //变量类型英文名
protected string mstrVarTypeSimName;    //变量类型简名
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsGCVariableTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("VarTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strVarTypeId">关键字:变量类型Id</param>
public clsGCVariableTypeEN(string strVarTypeId)
 {
strVarTypeId = strVarTypeId.Replace("'", "''");
if (strVarTypeId.Length > 4)
{
throw new Exception("在表:GCVariableType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strVarTypeId)  ==  true)
{
throw new Exception("在表:GCVariableType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strVarTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrVarTypeId = strVarTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("VarTypeId");
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
if (strAttributeName  ==  conGCVariableType.VarTypeId)
{
return mstrVarTypeId;
}
else if (strAttributeName  ==  conGCVariableType.VarTypeName)
{
return mstrVarTypeName;
}
else if (strAttributeName  ==  conGCVariableType.VarTypeENName)
{
return mstrVarTypeENName;
}
else if (strAttributeName  ==  conGCVariableType.VarTypeSimName)
{
return mstrVarTypeSimName;
}
else if (strAttributeName  ==  conGCVariableType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conGCVariableType.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conGCVariableType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conGCVariableType.VarTypeId)
{
mstrVarTypeId = value.ToString();
 AddUpdatedFld(conGCVariableType.VarTypeId);
}
else if (strAttributeName  ==  conGCVariableType.VarTypeName)
{
mstrVarTypeName = value.ToString();
 AddUpdatedFld(conGCVariableType.VarTypeName);
}
else if (strAttributeName  ==  conGCVariableType.VarTypeENName)
{
mstrVarTypeENName = value.ToString();
 AddUpdatedFld(conGCVariableType.VarTypeENName);
}
else if (strAttributeName  ==  conGCVariableType.VarTypeSimName)
{
mstrVarTypeSimName = value.ToString();
 AddUpdatedFld(conGCVariableType.VarTypeSimName);
}
else if (strAttributeName  ==  conGCVariableType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conGCVariableType.UpdDate);
}
else if (strAttributeName  ==  conGCVariableType.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conGCVariableType.UpdUser);
}
else if (strAttributeName  ==  conGCVariableType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conGCVariableType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conGCVariableType.VarTypeId  ==  _AttributeName[intIndex])
{
return mstrVarTypeId;
}
else if (conGCVariableType.VarTypeName  ==  _AttributeName[intIndex])
{
return mstrVarTypeName;
}
else if (conGCVariableType.VarTypeENName  ==  _AttributeName[intIndex])
{
return mstrVarTypeENName;
}
else if (conGCVariableType.VarTypeSimName  ==  _AttributeName[intIndex])
{
return mstrVarTypeSimName;
}
else if (conGCVariableType.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conGCVariableType.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conGCVariableType.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conGCVariableType.VarTypeId  ==  _AttributeName[intIndex])
{
mstrVarTypeId = value.ToString();
 AddUpdatedFld(conGCVariableType.VarTypeId);
}
else if (conGCVariableType.VarTypeName  ==  _AttributeName[intIndex])
{
mstrVarTypeName = value.ToString();
 AddUpdatedFld(conGCVariableType.VarTypeName);
}
else if (conGCVariableType.VarTypeENName  ==  _AttributeName[intIndex])
{
mstrVarTypeENName = value.ToString();
 AddUpdatedFld(conGCVariableType.VarTypeENName);
}
else if (conGCVariableType.VarTypeSimName  ==  _AttributeName[intIndex])
{
mstrVarTypeSimName = value.ToString();
 AddUpdatedFld(conGCVariableType.VarTypeSimName);
}
else if (conGCVariableType.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conGCVariableType.UpdDate);
}
else if (conGCVariableType.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conGCVariableType.UpdUser);
}
else if (conGCVariableType.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conGCVariableType.Memo);
}
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
 AddUpdatedFld(conGCVariableType.VarTypeId);
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
 AddUpdatedFld(conGCVariableType.VarTypeName);
}
}
/// <summary>
/// 变量类型英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VarTypeENName
{
get
{
return mstrVarTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVarTypeENName = value;
}
else
{
 mstrVarTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conGCVariableType.VarTypeENName);
}
}
/// <summary>
/// 变量类型简名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VarTypeSimName
{
get
{
return mstrVarTypeSimName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVarTypeSimName = value;
}
else
{
 mstrVarTypeSimName = value;
}
//记录修改过的字段
 AddUpdatedFld(conGCVariableType.VarTypeSimName);
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
 AddUpdatedFld(conGCVariableType.UpdDate);
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
 AddUpdatedFld(conGCVariableType.UpdUser);
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
 AddUpdatedFld(conGCVariableType.Memo);
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
  return mstrVarTypeId;
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
  return mstrVarTypeName;
 }
 }
}
 /// <summary>
 /// GC变量类型(GCVariableType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conGCVariableType
{
public const string _CurrTabName = "GCVariableType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "VarTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"VarTypeId", "VarTypeName", "VarTypeENName", "VarTypeSimName", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


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
 /// 常量:"VarTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VarTypeENName = "VarTypeENName";    //变量类型英文名

 /// <summary>
 /// 常量:"VarTypeSimName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VarTypeSimName = "VarTypeSimName";    //变量类型简名

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