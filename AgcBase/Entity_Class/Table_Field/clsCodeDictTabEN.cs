
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCodeDictTabEN
 表名:CodeDictTab(00050542)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:06:11
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
 /// 表CodeDictTab的关键字(CodeTabCodeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CodeTabCodeId_CodeDictTab
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strCodeTabCodeId">表关键字</param>
public K_CodeTabCodeId_CodeDictTab(string strCodeTabCodeId)
{
if (IsValid(strCodeTabCodeId)) Value = strCodeTabCodeId;
else
{
Value = null;
}
}
private static bool IsValid(string strCodeTabCodeId)
{
if (string.IsNullOrEmpty(strCodeTabCodeId) == true) return false;
if (strCodeTabCodeId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_CodeTabCodeId_CodeDictTab]类型的对象</returns>
public static implicit operator K_CodeTabCodeId_CodeDictTab(string value)
{
return new K_CodeTabCodeId_CodeDictTab(value);
}
}
 /// <summary>
 /// CodeDictTab(CodeDictTab)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCodeDictTabEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CodeDictTab"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "CodeTabCodeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 7;
public static string[] _AttributeName = new string[] {"CodeTabCodeId", "CodeTabId", "CodeTabNameId", "PrjId", "UpdUser", "UpdDate", "Memo"};

protected string mstrCodeTabCodeId;    //代码Id
protected string mstrCodeTabId;    //代码表Id
protected string mstrCodeTabNameId;    //代码_名Id
protected string mstrPrjId;    //工程Id
protected string mstrUpdUser;    //修改者
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsCodeDictTabEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CodeTabCodeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strCodeTabCodeId">关键字:代码Id</param>
public clsCodeDictTabEN(string strCodeTabCodeId)
 {
strCodeTabCodeId = strCodeTabCodeId.Replace("'", "''");
if (strCodeTabCodeId.Length > 8)
{
throw new Exception("在表:CodeDictTab中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strCodeTabCodeId)  ==  true)
{
throw new Exception("在表:CodeDictTab中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCodeTabCodeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrCodeTabCodeId = strCodeTabCodeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CodeTabCodeId");
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
if (strAttributeName  ==  conCodeDictTab.CodeTabCodeId)
{
return mstrCodeTabCodeId;
}
else if (strAttributeName  ==  conCodeDictTab.CodeTabId)
{
return mstrCodeTabId;
}
else if (strAttributeName  ==  conCodeDictTab.CodeTabNameId)
{
return mstrCodeTabNameId;
}
else if (strAttributeName  ==  conCodeDictTab.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conCodeDictTab.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conCodeDictTab.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conCodeDictTab.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conCodeDictTab.CodeTabCodeId)
{
mstrCodeTabCodeId = value.ToString();
 AddUpdatedFld(conCodeDictTab.CodeTabCodeId);
}
else if (strAttributeName  ==  conCodeDictTab.CodeTabId)
{
mstrCodeTabId = value.ToString();
 AddUpdatedFld(conCodeDictTab.CodeTabId);
}
else if (strAttributeName  ==  conCodeDictTab.CodeTabNameId)
{
mstrCodeTabNameId = value.ToString();
 AddUpdatedFld(conCodeDictTab.CodeTabNameId);
}
else if (strAttributeName  ==  conCodeDictTab.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conCodeDictTab.PrjId);
}
else if (strAttributeName  ==  conCodeDictTab.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conCodeDictTab.UpdUser);
}
else if (strAttributeName  ==  conCodeDictTab.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCodeDictTab.UpdDate);
}
else if (strAttributeName  ==  conCodeDictTab.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCodeDictTab.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conCodeDictTab.CodeTabCodeId  ==  _AttributeName[intIndex])
{
return mstrCodeTabCodeId;
}
else if (conCodeDictTab.CodeTabId  ==  _AttributeName[intIndex])
{
return mstrCodeTabId;
}
else if (conCodeDictTab.CodeTabNameId  ==  _AttributeName[intIndex])
{
return mstrCodeTabNameId;
}
else if (conCodeDictTab.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conCodeDictTab.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conCodeDictTab.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conCodeDictTab.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conCodeDictTab.CodeTabCodeId  ==  _AttributeName[intIndex])
{
mstrCodeTabCodeId = value.ToString();
 AddUpdatedFld(conCodeDictTab.CodeTabCodeId);
}
else if (conCodeDictTab.CodeTabId  ==  _AttributeName[intIndex])
{
mstrCodeTabId = value.ToString();
 AddUpdatedFld(conCodeDictTab.CodeTabId);
}
else if (conCodeDictTab.CodeTabNameId  ==  _AttributeName[intIndex])
{
mstrCodeTabNameId = value.ToString();
 AddUpdatedFld(conCodeDictTab.CodeTabNameId);
}
else if (conCodeDictTab.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conCodeDictTab.PrjId);
}
else if (conCodeDictTab.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conCodeDictTab.UpdUser);
}
else if (conCodeDictTab.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCodeDictTab.UpdDate);
}
else if (conCodeDictTab.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCodeDictTab.Memo);
}
}
}

/// <summary>
/// 代码Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTabCodeId
{
get
{
return mstrCodeTabCodeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTabCodeId = value;
}
else
{
 mstrCodeTabCodeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCodeDictTab.CodeTabCodeId);
}
}
/// <summary>
/// 代码表Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTabId
{
get
{
return mstrCodeTabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTabId = value;
}
else
{
 mstrCodeTabId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCodeDictTab.CodeTabId);
}
}
/// <summary>
/// 代码_名Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTabNameId
{
get
{
return mstrCodeTabNameId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTabNameId = value;
}
else
{
 mstrCodeTabNameId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCodeDictTab.CodeTabNameId);
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
 AddUpdatedFld(conCodeDictTab.PrjId);
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
 AddUpdatedFld(conCodeDictTab.UpdUser);
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
 AddUpdatedFld(conCodeDictTab.UpdDate);
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
 AddUpdatedFld(conCodeDictTab.Memo);
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
  return mstrCodeTabCodeId;
 }
 }
}
 /// <summary>
 /// CodeDictTab(CodeDictTab)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCodeDictTab
{
public const string _CurrTabName = "CodeDictTab"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CodeTabCodeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"CodeTabCodeId", "CodeTabId", "CodeTabNameId", "PrjId", "UpdUser", "UpdDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"CodeTabCodeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTabCodeId = "CodeTabCodeId";    //代码Id

 /// <summary>
 /// 常量:"CodeTabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTabId = "CodeTabId";    //代码表Id

 /// <summary>
 /// 常量:"CodeTabNameId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTabNameId = "CodeTabNameId";    //代码_名Id

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

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