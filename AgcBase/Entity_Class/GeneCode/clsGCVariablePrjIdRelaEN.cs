
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsGCVariablePrjIdRelaEN
 表名:GCVariablePrjIdRela(00050617)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:24:19
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
 /// 表GCVariablePrjIdRela的关键字(VarId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_VarId_GCVariablePrjIdRela
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
public K_VarId_GCVariablePrjIdRela(string strVarId)
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
 /// <returns>返回:[K_VarId_GCVariablePrjIdRela]类型的对象</returns>
public static implicit operator K_VarId_GCVariablePrjIdRela(string value)
{
return new K_VarId_GCVariablePrjIdRela(value);
}
}
 /// <summary>
 /// GCVariablePrjIdRela(GCVariablePrjIdRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsGCVariablePrjIdRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "GCVariablePrjIdRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "VarId,PrjId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 6;
public static string[] _AttributeName = new string[] {"VarId", "PrjId", "FldId", "UpdUser", "UpdDate", "Memo"};

protected string mstrVarId;    //变量Id
protected string mstrPrjId;    //工程Id
protected string mstrFldId;    //字段Id
protected string mstrUpdUser;    //修改者
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsGCVariablePrjIdRelaEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("VarId");
 lstKeyFldNames.Add("PrjId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strVarId">关键字:变量Id</param>
public clsGCVariablePrjIdRelaEN(string strVarId , string strPrjId)
 {
strVarId = strVarId.Replace("'", "''");
if (strVarId.Length > 8)
{
throw new Exception("在表:GCVariablePrjIdRela中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strVarId)  ==  true)
{
throw new Exception("在表:GCVariablePrjIdRela中,关键字不能为空 或 null!");
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
this.mstrPrjId = strPrjId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("VarId");
 lstKeyFldNames.Add("PrjId");
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
if (strAttributeName  ==  conGCVariablePrjIdRela.VarId)
{
return mstrVarId;
}
else if (strAttributeName  ==  conGCVariablePrjIdRela.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conGCVariablePrjIdRela.FldId)
{
return mstrFldId;
}
else if (strAttributeName  ==  conGCVariablePrjIdRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conGCVariablePrjIdRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conGCVariablePrjIdRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conGCVariablePrjIdRela.VarId)
{
mstrVarId = value.ToString();
 AddUpdatedFld(conGCVariablePrjIdRela.VarId);
}
else if (strAttributeName  ==  conGCVariablePrjIdRela.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conGCVariablePrjIdRela.PrjId);
}
else if (strAttributeName  ==  conGCVariablePrjIdRela.FldId)
{
mstrFldId = value.ToString();
 AddUpdatedFld(conGCVariablePrjIdRela.FldId);
}
else if (strAttributeName  ==  conGCVariablePrjIdRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conGCVariablePrjIdRela.UpdUser);
}
else if (strAttributeName  ==  conGCVariablePrjIdRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conGCVariablePrjIdRela.UpdDate);
}
else if (strAttributeName  ==  conGCVariablePrjIdRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conGCVariablePrjIdRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conGCVariablePrjIdRela.VarId  ==  _AttributeName[intIndex])
{
return mstrVarId;
}
else if (conGCVariablePrjIdRela.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conGCVariablePrjIdRela.FldId  ==  _AttributeName[intIndex])
{
return mstrFldId;
}
else if (conGCVariablePrjIdRela.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conGCVariablePrjIdRela.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conGCVariablePrjIdRela.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conGCVariablePrjIdRela.VarId  ==  _AttributeName[intIndex])
{
mstrVarId = value.ToString();
 AddUpdatedFld(conGCVariablePrjIdRela.VarId);
}
else if (conGCVariablePrjIdRela.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conGCVariablePrjIdRela.PrjId);
}
else if (conGCVariablePrjIdRela.FldId  ==  _AttributeName[intIndex])
{
mstrFldId = value.ToString();
 AddUpdatedFld(conGCVariablePrjIdRela.FldId);
}
else if (conGCVariablePrjIdRela.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conGCVariablePrjIdRela.UpdUser);
}
else if (conGCVariablePrjIdRela.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conGCVariablePrjIdRela.UpdDate);
}
else if (conGCVariablePrjIdRela.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conGCVariablePrjIdRela.Memo);
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
 AddUpdatedFld(conGCVariablePrjIdRela.VarId);
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
 AddUpdatedFld(conGCVariablePrjIdRela.PrjId);
}
}
/// <summary>
/// 字段Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FldId
{
get
{
return mstrFldId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldId = value;
}
else
{
 mstrFldId = value;
}
//记录修改过的字段
 AddUpdatedFld(conGCVariablePrjIdRela.FldId);
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
 AddUpdatedFld(conGCVariablePrjIdRela.UpdUser);
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
 AddUpdatedFld(conGCVariablePrjIdRela.UpdDate);
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
 AddUpdatedFld(conGCVariablePrjIdRela.Memo);
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
 /// GCVariablePrjIdRela(GCVariablePrjIdRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conGCVariablePrjIdRela
{
public const string _CurrTabName = "GCVariablePrjIdRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "VarId,PrjId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"VarId", "PrjId", "FldId", "UpdUser", "UpdDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"VarId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VarId = "VarId";    //变量Id

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"FldId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldId = "FldId";    //字段Id

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改者

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}