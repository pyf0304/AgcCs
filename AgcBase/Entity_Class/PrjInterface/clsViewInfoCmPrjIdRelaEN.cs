
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewInfoCmPrjIdRelaEN
 表名:ViewInfoCmPrjIdRela(00050621)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:00:35
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:界面管理(PrjInterface)
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
 /// 表ViewInfoCmPrjIdRela的关键字(ViewId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ViewId_ViewInfoCmPrjIdRela
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strViewId">表关键字</param>
public K_ViewId_ViewInfoCmPrjIdRela(string strViewId)
{
if (IsValid(strViewId)) Value = strViewId;
else
{
Value = null;
}
}
private static bool IsValid(string strViewId)
{
if (string.IsNullOrEmpty(strViewId) == true) return false;
if (strViewId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ViewId_ViewInfoCmPrjIdRela]类型的对象</returns>
public static implicit operator K_ViewId_ViewInfoCmPrjIdRela(string value)
{
return new K_ViewId_ViewInfoCmPrjIdRela(value);
}
}
 /// <summary>
 /// 界面CmPrjId关系(ViewInfoCmPrjIdRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsViewInfoCmPrjIdRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ViewInfoCmPrjIdRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ViewId,CmPrjId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 5;
public static string[] _AttributeName = new string[] {"ViewId", "CmPrjId", "UpdDate", "UpdUserId", "Memo"};

protected string mstrViewId;    //界面Id
protected string mstrCmPrjId;    //Cm工程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsViewInfoCmPrjIdRelaEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ViewId");
 lstKeyFldNames.Add("CmPrjId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strViewId">关键字:界面Id</param>
public clsViewInfoCmPrjIdRelaEN(string strViewId , string strCmPrjId)
 {
strViewId = strViewId.Replace("'", "''");
if (strViewId.Length > 8)
{
throw new Exception("在表:ViewInfoCmPrjIdRela中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strViewId)  ==  true)
{
throw new Exception("在表:ViewInfoCmPrjIdRela中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strViewId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrViewId = strViewId;
this.mstrCmPrjId = strCmPrjId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ViewId");
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
if (strAttributeName  ==  conViewInfoCmPrjIdRela.ViewId)
{
return mstrViewId;
}
else if (strAttributeName  ==  conViewInfoCmPrjIdRela.CmPrjId)
{
return mstrCmPrjId;
}
else if (strAttributeName  ==  conViewInfoCmPrjIdRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conViewInfoCmPrjIdRela.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conViewInfoCmPrjIdRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conViewInfoCmPrjIdRela.ViewId)
{
mstrViewId = value.ToString();
 AddUpdatedFld(conViewInfoCmPrjIdRela.ViewId);
}
else if (strAttributeName  ==  conViewInfoCmPrjIdRela.CmPrjId)
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(conViewInfoCmPrjIdRela.CmPrjId);
}
else if (strAttributeName  ==  conViewInfoCmPrjIdRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conViewInfoCmPrjIdRela.UpdDate);
}
else if (strAttributeName  ==  conViewInfoCmPrjIdRela.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conViewInfoCmPrjIdRela.UpdUserId);
}
else if (strAttributeName  ==  conViewInfoCmPrjIdRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conViewInfoCmPrjIdRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conViewInfoCmPrjIdRela.ViewId  ==  _AttributeName[intIndex])
{
return mstrViewId;
}
else if (conViewInfoCmPrjIdRela.CmPrjId  ==  _AttributeName[intIndex])
{
return mstrCmPrjId;
}
else if (conViewInfoCmPrjIdRela.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conViewInfoCmPrjIdRela.UpdUserId  ==  _AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conViewInfoCmPrjIdRela.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conViewInfoCmPrjIdRela.ViewId  ==  _AttributeName[intIndex])
{
mstrViewId = value.ToString();
 AddUpdatedFld(conViewInfoCmPrjIdRela.ViewId);
}
else if (conViewInfoCmPrjIdRela.CmPrjId  ==  _AttributeName[intIndex])
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(conViewInfoCmPrjIdRela.CmPrjId);
}
else if (conViewInfoCmPrjIdRela.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conViewInfoCmPrjIdRela.UpdDate);
}
else if (conViewInfoCmPrjIdRela.UpdUserId  ==  _AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conViewInfoCmPrjIdRela.UpdUserId);
}
else if (conViewInfoCmPrjIdRela.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conViewInfoCmPrjIdRela.Memo);
}
}
}

/// <summary>
/// 界面Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewId
{
get
{
return mstrViewId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewId = value;
}
else
{
 mstrViewId = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewInfoCmPrjIdRela.ViewId);
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
 AddUpdatedFld(conViewInfoCmPrjIdRela.CmPrjId);
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
 AddUpdatedFld(conViewInfoCmPrjIdRela.UpdDate);
}
}
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUserId
{
get
{
return mstrUpdUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUserId = value;
}
else
{
 mstrUpdUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewInfoCmPrjIdRela.UpdUserId);
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
 AddUpdatedFld(conViewInfoCmPrjIdRela.Memo);
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
  return mstrViewId;
 }
 }
}
 /// <summary>
 /// 界面CmPrjId关系(ViewInfoCmPrjIdRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conViewInfoCmPrjIdRela
{
public const string _CurrTabName = "ViewInfoCmPrjIdRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ViewId,CmPrjId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"ViewId", "CmPrjId", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"ViewId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewId = "ViewId";    //界面Id

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
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}