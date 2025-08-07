
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCodeParaEN
 表名:CodePara(00050437)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:34:04
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
 /// 表CodePara的关键字(CodeParaId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CodeParaId_CodePara
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strCodeParaId">表关键字</param>
public K_CodeParaId_CodePara(string strCodeParaId)
{
if (IsValid(strCodeParaId)) Value = strCodeParaId;
else
{
Value = null;
}
}
private static bool IsValid(string strCodeParaId)
{
if (string.IsNullOrEmpty(strCodeParaId) == true) return false;
if (strCodeParaId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_CodeParaId_CodePara]类型的对象</returns>
public static implicit operator K_CodeParaId_CodePara(string value)
{
return new K_CodeParaId_CodePara(value);
}
}
 /// <summary>
 /// 代码参数(CodePara)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCodeParaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CodePara"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "CodeParaId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 10;
public static string[] _AttributeName = new string[] {"CodeParaId", "CodeParaName", "DataTypeId", "TabId", "FldId", "PrjId", "CodeParaContent", "UpdDate", "UpdUser", "Memo"};

protected string mstrCodeParaId;    //代码参数Id
protected string mstrCodeParaName;    //代码参数名
protected string mstrDataTypeId;    //数据类型Id
protected string mstrTabId;    //表ID
protected string mstrFldId;    //字段Id
protected string mstrPrjId;    //工程Id
protected string mstrCodeParaContent;    //代码参数内容
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsCodeParaEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CodeParaId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strCodeParaId">关键字:代码参数Id</param>
public clsCodeParaEN(string strCodeParaId)
 {
strCodeParaId = strCodeParaId.Replace("'", "''");
if (strCodeParaId.Length > 8)
{
throw new Exception("在表:CodePara中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strCodeParaId)  ==  true)
{
throw new Exception("在表:CodePara中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCodeParaId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrCodeParaId = strCodeParaId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CodeParaId");
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
if (strAttributeName  ==  conCodePara.CodeParaId)
{
return mstrCodeParaId;
}
else if (strAttributeName  ==  conCodePara.CodeParaName)
{
return mstrCodeParaName;
}
else if (strAttributeName  ==  conCodePara.DataTypeId)
{
return mstrDataTypeId;
}
else if (strAttributeName  ==  conCodePara.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  conCodePara.FldId)
{
return mstrFldId;
}
else if (strAttributeName  ==  conCodePara.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conCodePara.CodeParaContent)
{
return mstrCodeParaContent;
}
else if (strAttributeName  ==  conCodePara.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conCodePara.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conCodePara.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conCodePara.CodeParaId)
{
mstrCodeParaId = value.ToString();
 AddUpdatedFld(conCodePara.CodeParaId);
}
else if (strAttributeName  ==  conCodePara.CodeParaName)
{
mstrCodeParaName = value.ToString();
 AddUpdatedFld(conCodePara.CodeParaName);
}
else if (strAttributeName  ==  conCodePara.DataTypeId)
{
mstrDataTypeId = value.ToString();
 AddUpdatedFld(conCodePara.DataTypeId);
}
else if (strAttributeName  ==  conCodePara.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(conCodePara.TabId);
}
else if (strAttributeName  ==  conCodePara.FldId)
{
mstrFldId = value.ToString();
 AddUpdatedFld(conCodePara.FldId);
}
else if (strAttributeName  ==  conCodePara.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conCodePara.PrjId);
}
else if (strAttributeName  ==  conCodePara.CodeParaContent)
{
mstrCodeParaContent = value.ToString();
 AddUpdatedFld(conCodePara.CodeParaContent);
}
else if (strAttributeName  ==  conCodePara.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCodePara.UpdDate);
}
else if (strAttributeName  ==  conCodePara.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conCodePara.UpdUser);
}
else if (strAttributeName  ==  conCodePara.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCodePara.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conCodePara.CodeParaId  ==  _AttributeName[intIndex])
{
return mstrCodeParaId;
}
else if (conCodePara.CodeParaName  ==  _AttributeName[intIndex])
{
return mstrCodeParaName;
}
else if (conCodePara.DataTypeId  ==  _AttributeName[intIndex])
{
return mstrDataTypeId;
}
else if (conCodePara.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (conCodePara.FldId  ==  _AttributeName[intIndex])
{
return mstrFldId;
}
else if (conCodePara.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conCodePara.CodeParaContent  ==  _AttributeName[intIndex])
{
return mstrCodeParaContent;
}
else if (conCodePara.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conCodePara.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conCodePara.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conCodePara.CodeParaId  ==  _AttributeName[intIndex])
{
mstrCodeParaId = value.ToString();
 AddUpdatedFld(conCodePara.CodeParaId);
}
else if (conCodePara.CodeParaName  ==  _AttributeName[intIndex])
{
mstrCodeParaName = value.ToString();
 AddUpdatedFld(conCodePara.CodeParaName);
}
else if (conCodePara.DataTypeId  ==  _AttributeName[intIndex])
{
mstrDataTypeId = value.ToString();
 AddUpdatedFld(conCodePara.DataTypeId);
}
else if (conCodePara.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(conCodePara.TabId);
}
else if (conCodePara.FldId  ==  _AttributeName[intIndex])
{
mstrFldId = value.ToString();
 AddUpdatedFld(conCodePara.FldId);
}
else if (conCodePara.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conCodePara.PrjId);
}
else if (conCodePara.CodeParaContent  ==  _AttributeName[intIndex])
{
mstrCodeParaContent = value.ToString();
 AddUpdatedFld(conCodePara.CodeParaContent);
}
else if (conCodePara.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCodePara.UpdDate);
}
else if (conCodePara.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conCodePara.UpdUser);
}
else if (conCodePara.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCodePara.Memo);
}
}
}

/// <summary>
/// 代码参数Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeParaId
{
get
{
return mstrCodeParaId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeParaId = value;
}
else
{
 mstrCodeParaId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCodePara.CodeParaId);
}
}
/// <summary>
/// 代码参数名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeParaName
{
get
{
return mstrCodeParaName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeParaName = value;
}
else
{
 mstrCodeParaName = value;
}
//记录修改过的字段
 AddUpdatedFld(conCodePara.CodeParaName);
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
 AddUpdatedFld(conCodePara.DataTypeId);
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
 AddUpdatedFld(conCodePara.TabId);
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
 AddUpdatedFld(conCodePara.FldId);
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
 AddUpdatedFld(conCodePara.PrjId);
}
}
/// <summary>
/// 代码参数内容(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeParaContent
{
get
{
return mstrCodeParaContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeParaContent = value;
}
else
{
 mstrCodeParaContent = value;
}
//记录修改过的字段
 AddUpdatedFld(conCodePara.CodeParaContent);
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
 AddUpdatedFld(conCodePara.UpdDate);
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
 AddUpdatedFld(conCodePara.UpdUser);
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
 AddUpdatedFld(conCodePara.Memo);
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
  return mstrCodeParaId;
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
  return mstrCodeParaName;
 }
 }
}
 /// <summary>
 /// 代码参数(CodePara)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCodePara
{
public const string _CurrTabName = "CodePara"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CodeParaId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"CodeParaId", "CodeParaName", "DataTypeId", "TabId", "FldId", "PrjId", "CodeParaContent", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"CodeParaId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeParaId = "CodeParaId";    //代码参数Id

 /// <summary>
 /// 常量:"CodeParaName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeParaName = "CodeParaName";    //代码参数名

 /// <summary>
 /// 常量:"DataTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataTypeId = "DataTypeId";    //数据类型Id

 /// <summary>
 /// 常量:"TabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabId = "TabId";    //表ID

 /// <summary>
 /// 常量:"FldId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldId = "FldId";    //字段Id

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"CodeParaContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeParaContent = "CodeParaContent";    //代码参数内容

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