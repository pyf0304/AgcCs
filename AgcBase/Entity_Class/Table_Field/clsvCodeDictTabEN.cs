
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCodeDictTabEN
 表名:vCodeDictTab(00050541)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:33:09
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
 /// 表vCodeDictTab的关键字(CodeTabCodeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CodeTabCodeId_vCodeDictTab
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
public K_CodeTabCodeId_vCodeDictTab(string strCodeTabCodeId)
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
 /// <returns>返回:[K_CodeTabCodeId_vCodeDictTab]类型的对象</returns>
public static implicit operator K_CodeTabCodeId_vCodeDictTab(string value)
{
return new K_CodeTabCodeId_vCodeDictTab(value);
}
}
 /// <summary>
 /// v代码字典表(vCodeDictTab)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvCodeDictTabEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vCodeDictTab"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "CodeTabCodeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 11;
public static string[] _AttributeName = new string[] {"CodeTabCodeId", "CodeTabCode", "CodeTabId", "CodeTab", "CodeTabNameId", "CodeTabName", "PrjId", "PrjName", "UpdDate", "UpdUser", "Memo"};

protected string mstrCodeTabCodeId;    //代码Id
protected string mstrCodeTabCode;    //代码表_代码
protected string mstrCodeTabId;    //代码表Id
protected string mstrCodeTab;    //代码表
protected string mstrCodeTabNameId;    //代码_名Id
protected string mstrCodeTabName;    //表名
protected string mstrPrjId;    //工程Id
protected string mstrPrjName;    //工程名称
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvCodeDictTabEN()
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
public clsvCodeDictTabEN(string strCodeTabCodeId)
 {
strCodeTabCodeId = strCodeTabCodeId.Replace("'", "''");
if (strCodeTabCodeId.Length > 8)
{
throw new Exception("在表:vCodeDictTab中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strCodeTabCodeId)  ==  true)
{
throw new Exception("在表:vCodeDictTab中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convCodeDictTab.CodeTabCodeId)
{
return mstrCodeTabCodeId;
}
else if (strAttributeName  ==  convCodeDictTab.CodeTabCode)
{
return mstrCodeTabCode;
}
else if (strAttributeName  ==  convCodeDictTab.CodeTabId)
{
return mstrCodeTabId;
}
else if (strAttributeName  ==  convCodeDictTab.CodeTab)
{
return mstrCodeTab;
}
else if (strAttributeName  ==  convCodeDictTab.CodeTabNameId)
{
return mstrCodeTabNameId;
}
else if (strAttributeName  ==  convCodeDictTab.CodeTabName)
{
return mstrCodeTabName;
}
else if (strAttributeName  ==  convCodeDictTab.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convCodeDictTab.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convCodeDictTab.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convCodeDictTab.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convCodeDictTab.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convCodeDictTab.CodeTabCodeId)
{
mstrCodeTabCodeId = value.ToString();
 AddUpdatedFld(convCodeDictTab.CodeTabCodeId);
}
else if (strAttributeName  ==  convCodeDictTab.CodeTabCode)
{
mstrCodeTabCode = value.ToString();
 AddUpdatedFld(convCodeDictTab.CodeTabCode);
}
else if (strAttributeName  ==  convCodeDictTab.CodeTabId)
{
mstrCodeTabId = value.ToString();
 AddUpdatedFld(convCodeDictTab.CodeTabId);
}
else if (strAttributeName  ==  convCodeDictTab.CodeTab)
{
mstrCodeTab = value.ToString();
 AddUpdatedFld(convCodeDictTab.CodeTab);
}
else if (strAttributeName  ==  convCodeDictTab.CodeTabNameId)
{
mstrCodeTabNameId = value.ToString();
 AddUpdatedFld(convCodeDictTab.CodeTabNameId);
}
else if (strAttributeName  ==  convCodeDictTab.CodeTabName)
{
mstrCodeTabName = value.ToString();
 AddUpdatedFld(convCodeDictTab.CodeTabName);
}
else if (strAttributeName  ==  convCodeDictTab.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convCodeDictTab.PrjId);
}
else if (strAttributeName  ==  convCodeDictTab.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convCodeDictTab.PrjName);
}
else if (strAttributeName  ==  convCodeDictTab.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convCodeDictTab.UpdDate);
}
else if (strAttributeName  ==  convCodeDictTab.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convCodeDictTab.UpdUser);
}
else if (strAttributeName  ==  convCodeDictTab.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCodeDictTab.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convCodeDictTab.CodeTabCodeId  ==  _AttributeName[intIndex])
{
return mstrCodeTabCodeId;
}
else if (convCodeDictTab.CodeTabCode  ==  _AttributeName[intIndex])
{
return mstrCodeTabCode;
}
else if (convCodeDictTab.CodeTabId  ==  _AttributeName[intIndex])
{
return mstrCodeTabId;
}
else if (convCodeDictTab.CodeTab  ==  _AttributeName[intIndex])
{
return mstrCodeTab;
}
else if (convCodeDictTab.CodeTabNameId  ==  _AttributeName[intIndex])
{
return mstrCodeTabNameId;
}
else if (convCodeDictTab.CodeTabName  ==  _AttributeName[intIndex])
{
return mstrCodeTabName;
}
else if (convCodeDictTab.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convCodeDictTab.PrjName  ==  _AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convCodeDictTab.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convCodeDictTab.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convCodeDictTab.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convCodeDictTab.CodeTabCodeId  ==  _AttributeName[intIndex])
{
mstrCodeTabCodeId = value.ToString();
 AddUpdatedFld(convCodeDictTab.CodeTabCodeId);
}
else if (convCodeDictTab.CodeTabCode  ==  _AttributeName[intIndex])
{
mstrCodeTabCode = value.ToString();
 AddUpdatedFld(convCodeDictTab.CodeTabCode);
}
else if (convCodeDictTab.CodeTabId  ==  _AttributeName[intIndex])
{
mstrCodeTabId = value.ToString();
 AddUpdatedFld(convCodeDictTab.CodeTabId);
}
else if (convCodeDictTab.CodeTab  ==  _AttributeName[intIndex])
{
mstrCodeTab = value.ToString();
 AddUpdatedFld(convCodeDictTab.CodeTab);
}
else if (convCodeDictTab.CodeTabNameId  ==  _AttributeName[intIndex])
{
mstrCodeTabNameId = value.ToString();
 AddUpdatedFld(convCodeDictTab.CodeTabNameId);
}
else if (convCodeDictTab.CodeTabName  ==  _AttributeName[intIndex])
{
mstrCodeTabName = value.ToString();
 AddUpdatedFld(convCodeDictTab.CodeTabName);
}
else if (convCodeDictTab.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convCodeDictTab.PrjId);
}
else if (convCodeDictTab.PrjName  ==  _AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convCodeDictTab.PrjName);
}
else if (convCodeDictTab.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convCodeDictTab.UpdDate);
}
else if (convCodeDictTab.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convCodeDictTab.UpdUser);
}
else if (convCodeDictTab.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCodeDictTab.Memo);
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
 AddUpdatedFld(convCodeDictTab.CodeTabCodeId);
}
}
/// <summary>
/// 代码表_代码(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTabCode
{
get
{
return mstrCodeTabCode;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTabCode = value;
}
else
{
 mstrCodeTabCode = value;
}
//记录修改过的字段
 AddUpdatedFld(convCodeDictTab.CodeTabCode);
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
 AddUpdatedFld(convCodeDictTab.CodeTabId);
}
}
/// <summary>
/// 代码表(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTab
{
get
{
return mstrCodeTab;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTab = value;
}
else
{
 mstrCodeTab = value;
}
//记录修改过的字段
 AddUpdatedFld(convCodeDictTab.CodeTab);
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
 AddUpdatedFld(convCodeDictTab.CodeTabNameId);
}
}
/// <summary>
/// 表名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTabName
{
get
{
return mstrCodeTabName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTabName = value;
}
else
{
 mstrCodeTabName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCodeDictTab.CodeTabName);
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
 AddUpdatedFld(convCodeDictTab.PrjId);
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
 AddUpdatedFld(convCodeDictTab.PrjName);
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
 AddUpdatedFld(convCodeDictTab.UpdDate);
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
 AddUpdatedFld(convCodeDictTab.UpdUser);
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
 AddUpdatedFld(convCodeDictTab.Memo);
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
 /// v代码字典表(vCodeDictTab)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convCodeDictTab
{
public const string _CurrTabName = "vCodeDictTab"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CodeTabCodeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"CodeTabCodeId", "CodeTabCode", "CodeTabId", "CodeTab", "CodeTabNameId", "CodeTabName", "PrjId", "PrjName", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"CodeTabCodeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTabCodeId = "CodeTabCodeId";    //代码Id

 /// <summary>
 /// 常量:"CodeTabCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTabCode = "CodeTabCode";    //代码表_代码

 /// <summary>
 /// 常量:"CodeTabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTabId = "CodeTabId";    //代码表Id

 /// <summary>
 /// 常量:"CodeTab"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTab = "CodeTab";    //代码表

 /// <summary>
 /// 常量:"CodeTabNameId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTabNameId = "CodeTabNameId";    //代码_名Id

 /// <summary>
 /// 常量:"CodeTabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTabName = "CodeTabName";    //表名

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