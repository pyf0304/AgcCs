
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjTab_CheckEN
 表名:PrjTab_Check(00050564)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:04:57
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
 /// 表PrjTab_Check的关键字(TabId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TabId_PrjTab_Check
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strTabId">表关键字</param>
public K_TabId_PrjTab_Check(string strTabId)
{
if (IsValid(strTabId)) Value = strTabId;
else
{
Value = null;
}
}
private static bool IsValid(string strTabId)
{
if (string.IsNullOrEmpty(strTabId) == true) return false;
if (strTabId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_TabId_PrjTab_Check]类型的对象</returns>
public static implicit operator K_TabId_PrjTab_Check(string value)
{
return new K_TabId_PrjTab_Check(value);
}
}
 /// <summary>
 /// 工程表_检查(PrjTab_Check)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsPrjTab_CheckEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "PrjTab_Check"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TabId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 7;
public static string[] _AttributeName = new string[] {"TabId", "PrjId", "UpdUserId", "UpdDate", "Memo", "ErrMsg", "IsNeedCheckTab"};

protected string mstrTabId;    //表ID
protected string mstrPrjId;    //工程Id
protected string mstrUpdUserId;    //修改用户Id
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //说明
protected string mstrErrMsg;    //错误信息
protected bool mbolIsNeedCheckTab;    //是否需要检查表字段

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsPrjTab_CheckEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TabId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strTabId">关键字:表ID</param>
public clsPrjTab_CheckEN(string strTabId)
 {
strTabId = strTabId.Replace("'", "''");
if (strTabId.Length > 8)
{
throw new Exception("在表:PrjTab_Check中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTabId)  ==  true)
{
throw new Exception("在表:PrjTab_Check中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTabId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrTabId = strTabId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TabId");
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
if (strAttributeName  ==  conPrjTab_Check.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  conPrjTab_Check.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conPrjTab_Check.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conPrjTab_Check.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conPrjTab_Check.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conPrjTab_Check.ErrMsg)
{
return mstrErrMsg;
}
else if (strAttributeName  ==  conPrjTab_Check.IsNeedCheckTab)
{
return mbolIsNeedCheckTab;
}
return null;
}
set
{
if (strAttributeName  ==  conPrjTab_Check.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(conPrjTab_Check.TabId);
}
else if (strAttributeName  ==  conPrjTab_Check.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conPrjTab_Check.PrjId);
}
else if (strAttributeName  ==  conPrjTab_Check.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conPrjTab_Check.UpdUserId);
}
else if (strAttributeName  ==  conPrjTab_Check.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conPrjTab_Check.UpdDate);
}
else if (strAttributeName  ==  conPrjTab_Check.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPrjTab_Check.Memo);
}
else if (strAttributeName  ==  conPrjTab_Check.ErrMsg)
{
mstrErrMsg = value.ToString();
 AddUpdatedFld(conPrjTab_Check.ErrMsg);
}
else if (strAttributeName  ==  conPrjTab_Check.IsNeedCheckTab)
{
mbolIsNeedCheckTab = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjTab_Check.IsNeedCheckTab);
}
}
}
public object this[int intIndex]
{
get
{
if (conPrjTab_Check.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (conPrjTab_Check.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conPrjTab_Check.UpdUserId  ==  _AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conPrjTab_Check.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conPrjTab_Check.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (conPrjTab_Check.ErrMsg  ==  _AttributeName[intIndex])
{
return mstrErrMsg;
}
else if (conPrjTab_Check.IsNeedCheckTab  ==  _AttributeName[intIndex])
{
return mbolIsNeedCheckTab;
}
return null;
}
set
{
if (conPrjTab_Check.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(conPrjTab_Check.TabId);
}
else if (conPrjTab_Check.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conPrjTab_Check.PrjId);
}
else if (conPrjTab_Check.UpdUserId  ==  _AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conPrjTab_Check.UpdUserId);
}
else if (conPrjTab_Check.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conPrjTab_Check.UpdDate);
}
else if (conPrjTab_Check.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPrjTab_Check.Memo);
}
else if (conPrjTab_Check.ErrMsg  ==  _AttributeName[intIndex])
{
mstrErrMsg = value.ToString();
 AddUpdatedFld(conPrjTab_Check.ErrMsg);
}
else if (conPrjTab_Check.IsNeedCheckTab  ==  _AttributeName[intIndex])
{
mbolIsNeedCheckTab = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjTab_Check.IsNeedCheckTab);
}
}
}

/// <summary>
/// 表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabId
{
get
{
return mstrTabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabId = value;
}
else
{
 mstrTabId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjTab_Check.TabId);
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
 AddUpdatedFld(conPrjTab_Check.PrjId);
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
 AddUpdatedFld(conPrjTab_Check.UpdUserId);
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
 AddUpdatedFld(conPrjTab_Check.UpdDate);
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
 AddUpdatedFld(conPrjTab_Check.Memo);
}
}
/// <summary>
/// 错误信息(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ErrMsg
{
get
{
return mstrErrMsg;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrErrMsg = value;
}
else
{
 mstrErrMsg = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjTab_Check.ErrMsg);
}
}
/// <summary>
/// 是否需要检查表字段(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsNeedCheckTab
{
get
{
return mbolIsNeedCheckTab;
}
set
{
 mbolIsNeedCheckTab = value;
//记录修改过的字段
 AddUpdatedFld(conPrjTab_Check.IsNeedCheckTab);
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
  return mstrTabId;
 }
 }
}
 /// <summary>
 /// 工程表_检查(PrjTab_Check)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conPrjTab_Check
{
public const string _CurrTabName = "PrjTab_Check"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TabId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"TabId", "PrjId", "UpdUserId", "UpdDate", "Memo", "ErrMsg", "IsNeedCheckTab"};
//以下是属性变量


 /// <summary>
 /// 常量:"TabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabId = "TabId";    //表ID

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

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

 /// <summary>
 /// 常量:"ErrMsg"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ErrMsg = "ErrMsg";    //错误信息

 /// <summary>
 /// 常量:"IsNeedCheckTab"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsNeedCheckTab = "IsNeedCheckTab";    //是否需要检查表字段
}

}