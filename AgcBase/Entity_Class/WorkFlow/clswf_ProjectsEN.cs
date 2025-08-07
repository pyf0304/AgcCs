
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clswf_ProjectsEN
 表名:wf_Projects(00050495)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:33:41
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:工作流管理(WorkFlow)
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
 /// 表wf_Projects的关键字(PrjId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PrjId_wf_Projects
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strPrjId">表关键字</param>
public K_PrjId_wf_Projects(string strPrjId)
{
if (IsValid(strPrjId)) Value = strPrjId;
else
{
Value = null;
}
}
private static bool IsValid(string strPrjId)
{
if (string.IsNullOrEmpty(strPrjId) == true) return false;
if (strPrjId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PrjId_wf_Projects]类型的对象</returns>
public static implicit operator K_PrjId_wf_Projects(string value)
{
return new K_PrjId_wf_Projects(value);
}
}
 /// <summary>
 /// 工作流工程(wf_Projects)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clswf_ProjectsEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "wf_Projects"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PrjId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 6;
public static string[] _AttributeName = new string[] {"PrjId", "PrjName", "UseStateId", "UpdUser", "UpdDate", "Memo"};

protected string mstrPrjId;    //工程Id
protected string mstrPrjName;    //工程名称
protected string mstrUseStateId;    //使用状态Id
protected string mstrUpdUser;    //修改者
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clswf_ProjectsEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PrjId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strPrjId">关键字:工程Id</param>
public clswf_ProjectsEN(string strPrjId)
 {
strPrjId = strPrjId.Replace("'", "''");
if (strPrjId.Length > 4)
{
throw new Exception("在表:wf_Projects中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strPrjId)  ==  true)
{
throw new Exception("在表:wf_Projects中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPrjId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrPrjId = strPrjId;
 SetInit();
 mbolIsCheckProperty = false;
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
if (strAttributeName  ==  conwf_Projects.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conwf_Projects.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  conwf_Projects.UseStateId)
{
return mstrUseStateId;
}
else if (strAttributeName  ==  conwf_Projects.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conwf_Projects.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conwf_Projects.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conwf_Projects.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conwf_Projects.PrjId);
}
else if (strAttributeName  ==  conwf_Projects.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(conwf_Projects.PrjName);
}
else if (strAttributeName  ==  conwf_Projects.UseStateId)
{
mstrUseStateId = value.ToString();
 AddUpdatedFld(conwf_Projects.UseStateId);
}
else if (strAttributeName  ==  conwf_Projects.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conwf_Projects.UpdUser);
}
else if (strAttributeName  ==  conwf_Projects.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conwf_Projects.UpdDate);
}
else if (strAttributeName  ==  conwf_Projects.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conwf_Projects.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conwf_Projects.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conwf_Projects.PrjName  ==  _AttributeName[intIndex])
{
return mstrPrjName;
}
else if (conwf_Projects.UseStateId  ==  _AttributeName[intIndex])
{
return mstrUseStateId;
}
else if (conwf_Projects.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conwf_Projects.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conwf_Projects.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conwf_Projects.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conwf_Projects.PrjId);
}
else if (conwf_Projects.PrjName  ==  _AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(conwf_Projects.PrjName);
}
else if (conwf_Projects.UseStateId  ==  _AttributeName[intIndex])
{
mstrUseStateId = value.ToString();
 AddUpdatedFld(conwf_Projects.UseStateId);
}
else if (conwf_Projects.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conwf_Projects.UpdUser);
}
else if (conwf_Projects.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conwf_Projects.UpdDate);
}
else if (conwf_Projects.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conwf_Projects.Memo);
}
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
 AddUpdatedFld(conwf_Projects.PrjId);
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
 AddUpdatedFld(conwf_Projects.PrjName);
}
}
/// <summary>
/// 使用状态Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UseStateId
{
get
{
return mstrUseStateId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUseStateId = value;
}
else
{
 mstrUseStateId = value;
}
//记录修改过的字段
 AddUpdatedFld(conwf_Projects.UseStateId);
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
 AddUpdatedFld(conwf_Projects.UpdUser);
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
 AddUpdatedFld(conwf_Projects.UpdDate);
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
 AddUpdatedFld(conwf_Projects.Memo);
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
  return mstrPrjId;
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
  return mstrPrjName;
 }
 }
}
 /// <summary>
 /// 工作流工程(wf_Projects)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conwf_Projects
{
public const string _CurrTabName = "wf_Projects"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PrjId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"PrjId", "PrjName", "UseStateId", "UpdUser", "UpdDate", "Memo"};
//以下是属性变量


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
 /// 常量:"UseStateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UseStateId = "UseStateId";    //使用状态Id

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