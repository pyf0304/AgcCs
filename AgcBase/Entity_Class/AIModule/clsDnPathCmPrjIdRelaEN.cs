
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDnPathCmPrjIdRelaEN
 表名:DnPathCmPrjIdRela(00050620)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:09:06
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:AI模块(AIModule)
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
 /// 表DnPathCmPrjIdRela的关键字(DnPathId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_DnPathId_DnPathCmPrjIdRela
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strDnPathId">表关键字</param>
public K_DnPathId_DnPathCmPrjIdRela(string strDnPathId)
{
if (IsValid(strDnPathId)) Value = strDnPathId;
else
{
Value = null;
}
}
private static bool IsValid(string strDnPathId)
{
if (string.IsNullOrEmpty(strDnPathId) == true) return false;
if (strDnPathId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_DnPathId_DnPathCmPrjIdRela]类型的对象</returns>
public static implicit operator K_DnPathId_DnPathCmPrjIdRela(string value)
{
return new K_DnPathId_DnPathCmPrjIdRela(value);
}
}
 /// <summary>
 /// 数据结点路径CmPrjId关系(DnPathCmPrjIdRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsDnPathCmPrjIdRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "DnPathCmPrjIdRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "DnPathId,CmPrjId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 5;
public static string[] _AttributeName = new string[] {"DnPathId", "CmPrjId", "UpdDate", "UpdUser", "Memo"};

protected string mstrDnPathId;    //DN路径Id
protected string mstrCmPrjId;    //Cm工程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsDnPathCmPrjIdRelaEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("DnPathId");
 lstKeyFldNames.Add("CmPrjId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strDnPathId">关键字:DN路径Id</param>
public clsDnPathCmPrjIdRelaEN(string strDnPathId , string strCmPrjId)
 {
strDnPathId = strDnPathId.Replace("'", "''");
if (strDnPathId.Length > 8)
{
throw new Exception("在表:DnPathCmPrjIdRela中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strDnPathId)  ==  true)
{
throw new Exception("在表:DnPathCmPrjIdRela中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strDnPathId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrDnPathId = strDnPathId;
this.mstrCmPrjId = strCmPrjId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("DnPathId");
 lstKeyFldNames.Add("CmPrjId");
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
if (strAttributeName  ==  conDnPathCmPrjIdRela.DnPathId)
{
return mstrDnPathId;
}
else if (strAttributeName  ==  conDnPathCmPrjIdRela.CmPrjId)
{
return mstrCmPrjId;
}
else if (strAttributeName  ==  conDnPathCmPrjIdRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conDnPathCmPrjIdRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conDnPathCmPrjIdRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conDnPathCmPrjIdRela.DnPathId)
{
mstrDnPathId = value.ToString();
 AddUpdatedFld(conDnPathCmPrjIdRela.DnPathId);
}
else if (strAttributeName  ==  conDnPathCmPrjIdRela.CmPrjId)
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(conDnPathCmPrjIdRela.CmPrjId);
}
else if (strAttributeName  ==  conDnPathCmPrjIdRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conDnPathCmPrjIdRela.UpdDate);
}
else if (strAttributeName  ==  conDnPathCmPrjIdRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conDnPathCmPrjIdRela.UpdUser);
}
else if (strAttributeName  ==  conDnPathCmPrjIdRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDnPathCmPrjIdRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conDnPathCmPrjIdRela.DnPathId  ==  _AttributeName[intIndex])
{
return mstrDnPathId;
}
else if (conDnPathCmPrjIdRela.CmPrjId  ==  _AttributeName[intIndex])
{
return mstrCmPrjId;
}
else if (conDnPathCmPrjIdRela.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conDnPathCmPrjIdRela.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conDnPathCmPrjIdRela.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conDnPathCmPrjIdRela.DnPathId  ==  _AttributeName[intIndex])
{
mstrDnPathId = value.ToString();
 AddUpdatedFld(conDnPathCmPrjIdRela.DnPathId);
}
else if (conDnPathCmPrjIdRela.CmPrjId  ==  _AttributeName[intIndex])
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(conDnPathCmPrjIdRela.CmPrjId);
}
else if (conDnPathCmPrjIdRela.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conDnPathCmPrjIdRela.UpdDate);
}
else if (conDnPathCmPrjIdRela.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conDnPathCmPrjIdRela.UpdUser);
}
else if (conDnPathCmPrjIdRela.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDnPathCmPrjIdRela.Memo);
}
}
}

/// <summary>
/// DN路径Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DnPathId
{
get
{
return mstrDnPathId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDnPathId = value;
}
else
{
 mstrDnPathId = value;
}
//记录修改过的字段
 AddUpdatedFld(conDnPathCmPrjIdRela.DnPathId);
}
}
/// <summary>
/// Cm工程Id(说明:;字段类型:char;字段长度:6;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CmPrjId
{
get
{
return mstrCmPrjId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCmPrjId = value;
}
else
{
 mstrCmPrjId = value;
}
//记录修改过的字段
 AddUpdatedFld(conDnPathCmPrjIdRela.CmPrjId);
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
 AddUpdatedFld(conDnPathCmPrjIdRela.UpdDate);
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
 AddUpdatedFld(conDnPathCmPrjIdRela.UpdUser);
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
 AddUpdatedFld(conDnPathCmPrjIdRela.Memo);
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
  return mstrDnPathId;
 }
 }
}
 /// <summary>
 /// 数据结点路径CmPrjId关系(DnPathCmPrjIdRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conDnPathCmPrjIdRela
{
public const string _CurrTabName = "DnPathCmPrjIdRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "DnPathId,CmPrjId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"DnPathId", "CmPrjId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"DnPathId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DnPathId = "DnPathId";    //DN路径Id

 /// <summary>
 /// 常量:"CmPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CmPrjId = "CmPrjId";    //Cm工程Id

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