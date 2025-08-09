
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTabRelationEN
 表名:TabRelation(00050086)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:13:57
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
 /// 表TabRelation的关键字(RelationId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_RelationId_TabRelation
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strRelationId">表关键字</param>
public K_RelationId_TabRelation(string strRelationId)
{
if (IsValid(strRelationId)) Value = strRelationId;
else
{
Value = null;
}
}
private static bool IsValid(string strRelationId)
{
if (string.IsNullOrEmpty(strRelationId) == true) return false;
if (strRelationId.Length > 8) return false;
if (strRelationId.IndexOf(' ') >= 0) return false;
if (strRelationId.IndexOf(')') >= 0) return false;
if (strRelationId.IndexOf('(') >= 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_RelationId_TabRelation]类型的对象</returns>
public static implicit operator K_RelationId_TabRelation(string value)
{
return new K_RelationId_TabRelation(value);
}
}
 /// <summary>
 /// TabRelation(TabRelation)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsTabRelationEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "TabRelation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "RelationId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 12;
public static string[] _AttributeName = new string[] {"RelationId", "RelationName", "TabRelationTypeId", "PrimaryKeyTabId", "PrimaryKeyFldId", "ForeignKeyTabId", "ForeignKeyFldId", "IsCheckCurrData", "IsCopyForceRela", "IsUpdRelateFld", "IsDelRelateRec", "Memo"};

protected string mstrRelationId;    //RelationId
protected string mstrRelationName;    //关系名
protected string mstrTabRelationTypeId;    //表关系类型Id
protected string mstrPrimaryKeyTabId;    //PrimaryKeyTabId
protected string mstrPrimaryKeyFldId;    //PrimaryKeyFldId
protected string mstrForeignKeyTabId;    //外键表ID
protected string mstrForeignKeyFldId;    //外键字段Id
protected bool mbolIsCheckCurrData;    //是否检查当前数据
protected bool mbolIsCopyForceRela;    //IsCopyForceRela
protected bool mbolIsUpdRelateFld;    //是否修改关系字段
protected bool mbolIsDelRelateRec;    //是否删除相关记录
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsTabRelationEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("RelationId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strRelationId">关键字:RelationId</param>
public clsTabRelationEN(string strRelationId)
 {
strRelationId = strRelationId.Replace("'", "''");
if (strRelationId.Length > 8)
{
throw new Exception("在表:TabRelation中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strRelationId)  ==  true)
{
throw new Exception("在表:TabRelation中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strRelationId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrRelationId = strRelationId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("RelationId");
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
if (strAttributeName  ==  conTabRelation.RelationId)
{
return mstrRelationId;
}
else if (strAttributeName  ==  conTabRelation.RelationName)
{
return mstrRelationName;
}
else if (strAttributeName  ==  conTabRelation.TabRelationTypeId)
{
return mstrTabRelationTypeId;
}
else if (strAttributeName  ==  conTabRelation.PrimaryKeyTabId)
{
return mstrPrimaryKeyTabId;
}
else if (strAttributeName  ==  conTabRelation.PrimaryKeyFldId)
{
return mstrPrimaryKeyFldId;
}
else if (strAttributeName  ==  conTabRelation.ForeignKeyTabId)
{
return mstrForeignKeyTabId;
}
else if (strAttributeName  ==  conTabRelation.ForeignKeyFldId)
{
return mstrForeignKeyFldId;
}
else if (strAttributeName  ==  conTabRelation.IsCheckCurrData)
{
return mbolIsCheckCurrData;
}
else if (strAttributeName  ==  conTabRelation.IsCopyForceRela)
{
return mbolIsCopyForceRela;
}
else if (strAttributeName  ==  conTabRelation.IsUpdRelateFld)
{
return mbolIsUpdRelateFld;
}
else if (strAttributeName  ==  conTabRelation.IsDelRelateRec)
{
return mbolIsDelRelateRec;
}
else if (strAttributeName  ==  conTabRelation.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conTabRelation.RelationId)
{
mstrRelationId = value.ToString();
 AddUpdatedFld(conTabRelation.RelationId);
}
else if (strAttributeName  ==  conTabRelation.RelationName)
{
mstrRelationName = value.ToString();
 AddUpdatedFld(conTabRelation.RelationName);
}
else if (strAttributeName  ==  conTabRelation.TabRelationTypeId)
{
mstrTabRelationTypeId = value.ToString();
 AddUpdatedFld(conTabRelation.TabRelationTypeId);
}
else if (strAttributeName  ==  conTabRelation.PrimaryKeyTabId)
{
mstrPrimaryKeyTabId = value.ToString();
 AddUpdatedFld(conTabRelation.PrimaryKeyTabId);
}
else if (strAttributeName  ==  conTabRelation.PrimaryKeyFldId)
{
mstrPrimaryKeyFldId = value.ToString();
 AddUpdatedFld(conTabRelation.PrimaryKeyFldId);
}
else if (strAttributeName  ==  conTabRelation.ForeignKeyTabId)
{
mstrForeignKeyTabId = value.ToString();
 AddUpdatedFld(conTabRelation.ForeignKeyTabId);
}
else if (strAttributeName  ==  conTabRelation.ForeignKeyFldId)
{
mstrForeignKeyFldId = value.ToString();
 AddUpdatedFld(conTabRelation.ForeignKeyFldId);
}
else if (strAttributeName  ==  conTabRelation.IsCheckCurrData)
{
mbolIsCheckCurrData = TransNullToBool(value.ToString());
 AddUpdatedFld(conTabRelation.IsCheckCurrData);
}
else if (strAttributeName  ==  conTabRelation.IsCopyForceRela)
{
mbolIsCopyForceRela = TransNullToBool(value.ToString());
 AddUpdatedFld(conTabRelation.IsCopyForceRela);
}
else if (strAttributeName  ==  conTabRelation.IsUpdRelateFld)
{
mbolIsUpdRelateFld = TransNullToBool(value.ToString());
 AddUpdatedFld(conTabRelation.IsUpdRelateFld);
}
else if (strAttributeName  ==  conTabRelation.IsDelRelateRec)
{
mbolIsDelRelateRec = TransNullToBool(value.ToString());
 AddUpdatedFld(conTabRelation.IsDelRelateRec);
}
else if (strAttributeName  ==  conTabRelation.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTabRelation.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conTabRelation.RelationId  ==  _AttributeName[intIndex])
{
return mstrRelationId;
}
else if (conTabRelation.RelationName  ==  _AttributeName[intIndex])
{
return mstrRelationName;
}
else if (conTabRelation.TabRelationTypeId  ==  _AttributeName[intIndex])
{
return mstrTabRelationTypeId;
}
else if (conTabRelation.PrimaryKeyTabId  ==  _AttributeName[intIndex])
{
return mstrPrimaryKeyTabId;
}
else if (conTabRelation.PrimaryKeyFldId  ==  _AttributeName[intIndex])
{
return mstrPrimaryKeyFldId;
}
else if (conTabRelation.ForeignKeyTabId  ==  _AttributeName[intIndex])
{
return mstrForeignKeyTabId;
}
else if (conTabRelation.ForeignKeyFldId  ==  _AttributeName[intIndex])
{
return mstrForeignKeyFldId;
}
else if (conTabRelation.IsCheckCurrData  ==  _AttributeName[intIndex])
{
return mbolIsCheckCurrData;
}
else if (conTabRelation.IsCopyForceRela  ==  _AttributeName[intIndex])
{
return mbolIsCopyForceRela;
}
else if (conTabRelation.IsUpdRelateFld  ==  _AttributeName[intIndex])
{
return mbolIsUpdRelateFld;
}
else if (conTabRelation.IsDelRelateRec  ==  _AttributeName[intIndex])
{
return mbolIsDelRelateRec;
}
else if (conTabRelation.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conTabRelation.RelationId  ==  _AttributeName[intIndex])
{
mstrRelationId = value.ToString();
 AddUpdatedFld(conTabRelation.RelationId);
}
else if (conTabRelation.RelationName  ==  _AttributeName[intIndex])
{
mstrRelationName = value.ToString();
 AddUpdatedFld(conTabRelation.RelationName);
}
else if (conTabRelation.TabRelationTypeId  ==  _AttributeName[intIndex])
{
mstrTabRelationTypeId = value.ToString();
 AddUpdatedFld(conTabRelation.TabRelationTypeId);
}
else if (conTabRelation.PrimaryKeyTabId  ==  _AttributeName[intIndex])
{
mstrPrimaryKeyTabId = value.ToString();
 AddUpdatedFld(conTabRelation.PrimaryKeyTabId);
}
else if (conTabRelation.PrimaryKeyFldId  ==  _AttributeName[intIndex])
{
mstrPrimaryKeyFldId = value.ToString();
 AddUpdatedFld(conTabRelation.PrimaryKeyFldId);
}
else if (conTabRelation.ForeignKeyTabId  ==  _AttributeName[intIndex])
{
mstrForeignKeyTabId = value.ToString();
 AddUpdatedFld(conTabRelation.ForeignKeyTabId);
}
else if (conTabRelation.ForeignKeyFldId  ==  _AttributeName[intIndex])
{
mstrForeignKeyFldId = value.ToString();
 AddUpdatedFld(conTabRelation.ForeignKeyFldId);
}
else if (conTabRelation.IsCheckCurrData  ==  _AttributeName[intIndex])
{
mbolIsCheckCurrData = TransNullToBool(value.ToString());
 AddUpdatedFld(conTabRelation.IsCheckCurrData);
}
else if (conTabRelation.IsCopyForceRela  ==  _AttributeName[intIndex])
{
mbolIsCopyForceRela = TransNullToBool(value.ToString());
 AddUpdatedFld(conTabRelation.IsCopyForceRela);
}
else if (conTabRelation.IsUpdRelateFld  ==  _AttributeName[intIndex])
{
mbolIsUpdRelateFld = TransNullToBool(value.ToString());
 AddUpdatedFld(conTabRelation.IsUpdRelateFld);
}
else if (conTabRelation.IsDelRelateRec  ==  _AttributeName[intIndex])
{
mbolIsDelRelateRec = TransNullToBool(value.ToString());
 AddUpdatedFld(conTabRelation.IsDelRelateRec);
}
else if (conTabRelation.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTabRelation.Memo);
}
}
}

/// <summary>
/// RelationId(说明:;字段类型:varchar;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RelationId
{
get
{
return mstrRelationId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRelationId = value;
}
else
{
 mstrRelationId = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabRelation.RelationId);
}
}
/// <summary>
/// 关系名(说明:;字段类型:varchar;字段长度:40;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RelationName
{
get
{
return mstrRelationName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRelationName = value;
}
else
{
 mstrRelationName = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabRelation.RelationName);
}
}
/// <summary>
/// 表关系类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabRelationTypeId
{
get
{
return mstrTabRelationTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabRelationTypeId = value;
}
else
{
 mstrTabRelationTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabRelation.TabRelationTypeId);
}
}
/// <summary>
/// PrimaryKeyTabId(说明:;字段类型:varchar;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrimaryKeyTabId
{
get
{
return mstrPrimaryKeyTabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrimaryKeyTabId = value;
}
else
{
 mstrPrimaryKeyTabId = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabRelation.PrimaryKeyTabId);
}
}
/// <summary>
/// PrimaryKeyFldId(说明:;字段类型:varchar;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrimaryKeyFldId
{
get
{
return mstrPrimaryKeyFldId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrimaryKeyFldId = value;
}
else
{
 mstrPrimaryKeyFldId = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabRelation.PrimaryKeyFldId);
}
}
/// <summary>
/// 外键表ID(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ForeignKeyTabId
{
get
{
return mstrForeignKeyTabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrForeignKeyTabId = value;
}
else
{
 mstrForeignKeyTabId = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabRelation.ForeignKeyTabId);
}
}
/// <summary>
/// 外键字段Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ForeignKeyFldId
{
get
{
return mstrForeignKeyFldId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrForeignKeyFldId = value;
}
else
{
 mstrForeignKeyFldId = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabRelation.ForeignKeyFldId);
}
}
/// <summary>
/// 是否检查当前数据(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsCheckCurrData
{
get
{
return mbolIsCheckCurrData;
}
set
{
 mbolIsCheckCurrData = value;
//记录修改过的字段
 AddUpdatedFld(conTabRelation.IsCheckCurrData);
}
}
/// <summary>
/// IsCopyForceRela(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsCopyForceRela
{
get
{
return mbolIsCopyForceRela;
}
set
{
 mbolIsCopyForceRela = value;
//记录修改过的字段
 AddUpdatedFld(conTabRelation.IsCopyForceRela);
}
}
/// <summary>
/// 是否修改关系字段(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsUpdRelateFld
{
get
{
return mbolIsUpdRelateFld;
}
set
{
 mbolIsUpdRelateFld = value;
//记录修改过的字段
 AddUpdatedFld(conTabRelation.IsUpdRelateFld);
}
}
/// <summary>
/// 是否删除相关记录(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsDelRelateRec
{
get
{
return mbolIsDelRelateRec;
}
set
{
 mbolIsDelRelateRec = value;
//记录修改过的字段
 AddUpdatedFld(conTabRelation.IsDelRelateRec);
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
 AddUpdatedFld(conTabRelation.Memo);
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
  return mstrRelationId;
 }
 }
}
 /// <summary>
 /// TabRelation(TabRelation)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conTabRelation
{
public const string _CurrTabName = "TabRelation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "RelationId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"RelationId", "RelationName", "TabRelationTypeId", "PrimaryKeyTabId", "PrimaryKeyFldId", "ForeignKeyTabId", "ForeignKeyFldId", "IsCheckCurrData", "IsCopyForceRela", "IsUpdRelateFld", "IsDelRelateRec", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"RelationId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RelationId = "RelationId";    //RelationId

 /// <summary>
 /// 常量:"RelationName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RelationName = "RelationName";    //关系名

 /// <summary>
 /// 常量:"TabRelationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabRelationTypeId = "TabRelationTypeId";    //表关系类型Id

 /// <summary>
 /// 常量:"PrimaryKeyTabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrimaryKeyTabId = "PrimaryKeyTabId";    //PrimaryKeyTabId

 /// <summary>
 /// 常量:"PrimaryKeyFldId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrimaryKeyFldId = "PrimaryKeyFldId";    //PrimaryKeyFldId

 /// <summary>
 /// 常量:"ForeignKeyTabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ForeignKeyTabId = "ForeignKeyTabId";    //外键表ID

 /// <summary>
 /// 常量:"ForeignKeyFldId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ForeignKeyFldId = "ForeignKeyFldId";    //外键字段Id

 /// <summary>
 /// 常量:"IsCheckCurrData"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsCheckCurrData = "IsCheckCurrData";    //是否检查当前数据

 /// <summary>
 /// 常量:"IsCopyForceRela"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsCopyForceRela = "IsCopyForceRela";    //IsCopyForceRela

 /// <summary>
 /// 常量:"IsUpdRelateFld"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsUpdRelateFld = "IsUpdRelateFld";    //是否修改关系字段

 /// <summary>
 /// 常量:"IsDelRelateRec"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDelRelateRec = "IsDelRelateRec";    //是否删除相关记录

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}