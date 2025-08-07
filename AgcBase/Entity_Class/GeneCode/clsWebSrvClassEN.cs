
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsWebSrvClassEN
 表名:WebSrvClass(00050344)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:32:44
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
 /// 表WebSrvClass的关键字(WebSrvClassId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_WebSrvClassId_WebSrvClass
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strWebSrvClassId">表关键字</param>
public K_WebSrvClassId_WebSrvClass(string strWebSrvClassId)
{
if (IsValid(strWebSrvClassId)) Value = strWebSrvClassId;
else
{
Value = null;
}
}
private static bool IsValid(string strWebSrvClassId)
{
if (string.IsNullOrEmpty(strWebSrvClassId) == true) return false;
if (strWebSrvClassId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_WebSrvClassId_WebSrvClass]类型的对象</returns>
public static implicit operator K_WebSrvClassId_WebSrvClass(string value)
{
return new K_WebSrvClassId_WebSrvClass(value);
}
}
 /// <summary>
 /// WebSrv类(WebSrvClass)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsWebSrvClassEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "WebSrvClass"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "WebSrvClassId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 12;
public static string[] _AttributeName = new string[] {"WebSrvClassId", "NameSpace", "WebSrvUrl", "PageName", "FuncModuleAgcId", "IsNeedGene", "PrjId", "UpdDate", "UpdUser", "Memo", "CodeTypeId", "ClsName"};

protected string mstrWebSrvClassId;    //类Id
protected string mstrNameSpace;    //域名
protected string mstrWebSrvUrl;    //WebSrv地址
protected string mstrPageName;    //页面名称
protected string mstrFuncModuleAgcId;    //功能模块Id
protected bool mbolIsNeedGene;    //是否需要生成
protected string mstrPrjId;    //工程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明
protected string mstrCodeTypeId;    //代码类型Id
protected string mstrClsName;    //类名

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsWebSrvClassEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("WebSrvClassId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strWebSrvClassId">关键字:类Id</param>
public clsWebSrvClassEN(string strWebSrvClassId)
 {
strWebSrvClassId = strWebSrvClassId.Replace("'", "''");
if (strWebSrvClassId.Length > 8)
{
throw new Exception("在表:WebSrvClass中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strWebSrvClassId)  ==  true)
{
throw new Exception("在表:WebSrvClass中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strWebSrvClassId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrWebSrvClassId = strWebSrvClassId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("WebSrvClassId");
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
if (strAttributeName  ==  conWebSrvClass.WebSrvClassId)
{
return mstrWebSrvClassId;
}
else if (strAttributeName  ==  conWebSrvClass.NameSpace)
{
return mstrNameSpace;
}
else if (strAttributeName  ==  conWebSrvClass.WebSrvUrl)
{
return mstrWebSrvUrl;
}
else if (strAttributeName  ==  conWebSrvClass.PageName)
{
return mstrPageName;
}
else if (strAttributeName  ==  conWebSrvClass.FuncModuleAgcId)
{
return mstrFuncModuleAgcId;
}
else if (strAttributeName  ==  conWebSrvClass.IsNeedGene)
{
return mbolIsNeedGene;
}
else if (strAttributeName  ==  conWebSrvClass.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conWebSrvClass.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conWebSrvClass.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conWebSrvClass.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conWebSrvClass.CodeTypeId)
{
return mstrCodeTypeId;
}
else if (strAttributeName  ==  conWebSrvClass.ClsName)
{
return mstrClsName;
}
return null;
}
set
{
if (strAttributeName  ==  conWebSrvClass.WebSrvClassId)
{
mstrWebSrvClassId = value.ToString();
 AddUpdatedFld(conWebSrvClass.WebSrvClassId);
}
else if (strAttributeName  ==  conWebSrvClass.NameSpace)
{
mstrNameSpace = value.ToString();
 AddUpdatedFld(conWebSrvClass.NameSpace);
}
else if (strAttributeName  ==  conWebSrvClass.WebSrvUrl)
{
mstrWebSrvUrl = value.ToString();
 AddUpdatedFld(conWebSrvClass.WebSrvUrl);
}
else if (strAttributeName  ==  conWebSrvClass.PageName)
{
mstrPageName = value.ToString();
 AddUpdatedFld(conWebSrvClass.PageName);
}
else if (strAttributeName  ==  conWebSrvClass.FuncModuleAgcId)
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(conWebSrvClass.FuncModuleAgcId);
}
else if (strAttributeName  ==  conWebSrvClass.IsNeedGene)
{
mbolIsNeedGene = TransNullToBool(value.ToString());
 AddUpdatedFld(conWebSrvClass.IsNeedGene);
}
else if (strAttributeName  ==  conWebSrvClass.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conWebSrvClass.PrjId);
}
else if (strAttributeName  ==  conWebSrvClass.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conWebSrvClass.UpdDate);
}
else if (strAttributeName  ==  conWebSrvClass.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conWebSrvClass.UpdUser);
}
else if (strAttributeName  ==  conWebSrvClass.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conWebSrvClass.Memo);
}
else if (strAttributeName  ==  conWebSrvClass.CodeTypeId)
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(conWebSrvClass.CodeTypeId);
}
else if (strAttributeName  ==  conWebSrvClass.ClsName)
{
mstrClsName = value.ToString();
 AddUpdatedFld(conWebSrvClass.ClsName);
}
}
}
public object this[int intIndex]
{
get
{
if (conWebSrvClass.WebSrvClassId  ==  _AttributeName[intIndex])
{
return mstrWebSrvClassId;
}
else if (conWebSrvClass.NameSpace  ==  _AttributeName[intIndex])
{
return mstrNameSpace;
}
else if (conWebSrvClass.WebSrvUrl  ==  _AttributeName[intIndex])
{
return mstrWebSrvUrl;
}
else if (conWebSrvClass.PageName  ==  _AttributeName[intIndex])
{
return mstrPageName;
}
else if (conWebSrvClass.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
return mstrFuncModuleAgcId;
}
else if (conWebSrvClass.IsNeedGene  ==  _AttributeName[intIndex])
{
return mbolIsNeedGene;
}
else if (conWebSrvClass.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conWebSrvClass.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conWebSrvClass.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conWebSrvClass.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (conWebSrvClass.CodeTypeId  ==  _AttributeName[intIndex])
{
return mstrCodeTypeId;
}
else if (conWebSrvClass.ClsName  ==  _AttributeName[intIndex])
{
return mstrClsName;
}
return null;
}
set
{
if (conWebSrvClass.WebSrvClassId  ==  _AttributeName[intIndex])
{
mstrWebSrvClassId = value.ToString();
 AddUpdatedFld(conWebSrvClass.WebSrvClassId);
}
else if (conWebSrvClass.NameSpace  ==  _AttributeName[intIndex])
{
mstrNameSpace = value.ToString();
 AddUpdatedFld(conWebSrvClass.NameSpace);
}
else if (conWebSrvClass.WebSrvUrl  ==  _AttributeName[intIndex])
{
mstrWebSrvUrl = value.ToString();
 AddUpdatedFld(conWebSrvClass.WebSrvUrl);
}
else if (conWebSrvClass.PageName  ==  _AttributeName[intIndex])
{
mstrPageName = value.ToString();
 AddUpdatedFld(conWebSrvClass.PageName);
}
else if (conWebSrvClass.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(conWebSrvClass.FuncModuleAgcId);
}
else if (conWebSrvClass.IsNeedGene  ==  _AttributeName[intIndex])
{
mbolIsNeedGene = TransNullToBool(value.ToString());
 AddUpdatedFld(conWebSrvClass.IsNeedGene);
}
else if (conWebSrvClass.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conWebSrvClass.PrjId);
}
else if (conWebSrvClass.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conWebSrvClass.UpdDate);
}
else if (conWebSrvClass.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conWebSrvClass.UpdUser);
}
else if (conWebSrvClass.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conWebSrvClass.Memo);
}
else if (conWebSrvClass.CodeTypeId  ==  _AttributeName[intIndex])
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(conWebSrvClass.CodeTypeId);
}
else if (conWebSrvClass.ClsName  ==  _AttributeName[intIndex])
{
mstrClsName = value.ToString();
 AddUpdatedFld(conWebSrvClass.ClsName);
}
}
}

/// <summary>
/// 类Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WebSrvClassId
{
get
{
return mstrWebSrvClassId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWebSrvClassId = value;
}
else
{
 mstrWebSrvClassId = value;
}
//记录修改过的字段
 AddUpdatedFld(conWebSrvClass.WebSrvClassId);
}
}
/// <summary>
/// 域名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string NameSpace
{
get
{
return mstrNameSpace;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrNameSpace = value;
}
else
{
 mstrNameSpace = value;
}
//记录修改过的字段
 AddUpdatedFld(conWebSrvClass.NameSpace);
}
}
/// <summary>
/// WebSrv地址(说明:;字段类型:varchar;字段长度:300;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WebSrvUrl
{
get
{
return mstrWebSrvUrl;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWebSrvUrl = value;
}
else
{
 mstrWebSrvUrl = value;
}
//记录修改过的字段
 AddUpdatedFld(conWebSrvClass.WebSrvUrl);
}
}
/// <summary>
/// 页面名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PageName
{
get
{
return mstrPageName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPageName = value;
}
else
{
 mstrPageName = value;
}
//记录修改过的字段
 AddUpdatedFld(conWebSrvClass.PageName);
}
}
/// <summary>
/// 功能模块Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleAgcId
{
get
{
return mstrFuncModuleAgcId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleAgcId = value;
}
else
{
 mstrFuncModuleAgcId = value;
}
//记录修改过的字段
 AddUpdatedFld(conWebSrvClass.FuncModuleAgcId);
}
}
/// <summary>
/// 是否需要生成(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsNeedGene
{
get
{
return mbolIsNeedGene;
}
set
{
 mbolIsNeedGene = value;
//记录修改过的字段
 AddUpdatedFld(conWebSrvClass.IsNeedGene);
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
 AddUpdatedFld(conWebSrvClass.PrjId);
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
 AddUpdatedFld(conWebSrvClass.UpdDate);
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
 AddUpdatedFld(conWebSrvClass.UpdUser);
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
 AddUpdatedFld(conWebSrvClass.Memo);
}
}
/// <summary>
/// 代码类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTypeId
{
get
{
return mstrCodeTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTypeId = value;
}
else
{
 mstrCodeTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conWebSrvClass.CodeTypeId);
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
 AddUpdatedFld(conWebSrvClass.ClsName);
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
  return mstrWebSrvClassId;
 }
 }
}
 /// <summary>
 /// WebSrv类(WebSrvClass)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conWebSrvClass
{
public const string _CurrTabName = "WebSrvClass"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "WebSrvClassId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"WebSrvClassId", "NameSpace", "WebSrvUrl", "PageName", "FuncModuleAgcId", "IsNeedGene", "PrjId", "UpdDate", "UpdUser", "Memo", "CodeTypeId", "ClsName"};
//以下是属性变量


 /// <summary>
 /// 常量:"WebSrvClassId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WebSrvClassId = "WebSrvClassId";    //类Id

 /// <summary>
 /// 常量:"NameSpace"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string NameSpace = "NameSpace";    //域名

 /// <summary>
 /// 常量:"WebSrvUrl"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WebSrvUrl = "WebSrvUrl";    //WebSrv地址

 /// <summary>
 /// 常量:"PageName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PageName = "PageName";    //页面名称

 /// <summary>
 /// 常量:"FuncModuleAgcId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleAgcId = "FuncModuleAgcId";    //功能模块Id

 /// <summary>
 /// 常量:"IsNeedGene"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsNeedGene = "IsNeedGene";    //是否需要生成

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

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

 /// <summary>
 /// 常量:"CodeTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTypeId = "CodeTypeId";    //代码类型Id

 /// <summary>
 /// 常量:"ClsName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClsName = "ClsName";    //类名
}

}