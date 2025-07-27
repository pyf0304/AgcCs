
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsRelationTypeEN
 表名:RelationType(00050532)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:15:46
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:工作流管理(WorkFlow)
 框架-层名:实体层(CS)(EntityLayer)
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

namespace AGC.Entity
{
 /// <summary>
 /// 表RelationType的关键字(RelationTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_RelationTypeId_RelationType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strRelationTypeId">表关键字</param>
public K_RelationTypeId_RelationType(string strRelationTypeId)
{
if (IsValid(strRelationTypeId)) Value = strRelationTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strRelationTypeId)
{
if (strRelationTypeId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_RelationTypeId_RelationType]类型的对象</returns>
public static implicit operator K_RelationTypeId_RelationType(string value)
{
return new K_RelationTypeId_RelationType(value);
}
}
 /// <summary>
 /// 关系类型(RelationType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsRelationTypeEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接，如果为空就使用系统默认的连接
public new const string _CurrTabName = "RelationType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "RelationTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string WhereFormat = ""; //条件格式串
protected const int mintAttributeCount = 8;
public static string[] AttributeName = new string[] {"RelationTypeId", "RelationTypeName", "RelationPropName1", "RelationPropName2", "PrjId", "UpdDate", "UpdUser", "Memo"};

protected string mstrRelationTypeId;    //关系类型Id
protected string mstrRelationTypeName;    //关系类型名
protected string mstrRelationPropName1;    //关系属性名1
protected string mstrRelationPropName2;    //关系属性名2
protected string mstrPrjId;    //工程ID
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsRelationTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "RelationType";
 lstKeyFldNames.Add("RelationTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strRelationTypeId">关键字:关系类型Id</param>
public clsRelationTypeEN(string strRelationTypeId)
 {
strRelationTypeId = strRelationTypeId.Replace("'", "''");
if (strRelationTypeId.Length > 8)
{
throw new Exception("在表:RelationType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strRelationTypeId)  ==  true)
{
throw new Exception("在表:RelationType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strRelationTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrRelationTypeId = strRelationTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "RelationType";
 lstKeyFldNames.Add("RelationTypeId");
 }

public static int AttributeCount
{
get
{
return mintAttributeCount;
}
}
public override object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  conRelationType.RelationTypeId)
{
return mstrRelationTypeId;
}
else if (strAttributeName  ==  conRelationType.RelationTypeName)
{
return mstrRelationTypeName;
}
else if (strAttributeName  ==  conRelationType.RelationPropName1)
{
return mstrRelationPropName1;
}
else if (strAttributeName  ==  conRelationType.RelationPropName2)
{
return mstrRelationPropName2;
}
else if (strAttributeName  ==  conRelationType.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conRelationType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conRelationType.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conRelationType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conRelationType.RelationTypeId)
{
mstrRelationTypeId = value.ToString();
 AddUpdatedFld(conRelationType.RelationTypeId);
}
else if (strAttributeName  ==  conRelationType.RelationTypeName)
{
mstrRelationTypeName = value.ToString();
 AddUpdatedFld(conRelationType.RelationTypeName);
}
else if (strAttributeName  ==  conRelationType.RelationPropName1)
{
mstrRelationPropName1 = value.ToString();
 AddUpdatedFld(conRelationType.RelationPropName1);
}
else if (strAttributeName  ==  conRelationType.RelationPropName2)
{
mstrRelationPropName2 = value.ToString();
 AddUpdatedFld(conRelationType.RelationPropName2);
}
else if (strAttributeName  ==  conRelationType.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conRelationType.PrjId);
}
else if (strAttributeName  ==  conRelationType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conRelationType.UpdDate);
}
else if (strAttributeName  ==  conRelationType.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conRelationType.UpdUser);
}
else if (strAttributeName  ==  conRelationType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conRelationType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conRelationType.RelationTypeId  ==  AttributeName[intIndex])
{
return mstrRelationTypeId;
}
else if (conRelationType.RelationTypeName  ==  AttributeName[intIndex])
{
return mstrRelationTypeName;
}
else if (conRelationType.RelationPropName1  ==  AttributeName[intIndex])
{
return mstrRelationPropName1;
}
else if (conRelationType.RelationPropName2  ==  AttributeName[intIndex])
{
return mstrRelationPropName2;
}
else if (conRelationType.PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conRelationType.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conRelationType.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conRelationType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conRelationType.RelationTypeId  ==  AttributeName[intIndex])
{
mstrRelationTypeId = value.ToString();
 AddUpdatedFld(conRelationType.RelationTypeId);
}
else if (conRelationType.RelationTypeName  ==  AttributeName[intIndex])
{
mstrRelationTypeName = value.ToString();
 AddUpdatedFld(conRelationType.RelationTypeName);
}
else if (conRelationType.RelationPropName1  ==  AttributeName[intIndex])
{
mstrRelationPropName1 = value.ToString();
 AddUpdatedFld(conRelationType.RelationPropName1);
}
else if (conRelationType.RelationPropName2  ==  AttributeName[intIndex])
{
mstrRelationPropName2 = value.ToString();
 AddUpdatedFld(conRelationType.RelationPropName2);
}
else if (conRelationType.PrjId  ==  AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conRelationType.PrjId);
}
else if (conRelationType.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conRelationType.UpdDate);
}
else if (conRelationType.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conRelationType.UpdUser);
}
else if (conRelationType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conRelationType.Memo);
}
}
}

/// <summary>
/// 关系类型Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RelationTypeId
{
get
{
return mstrRelationTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRelationTypeId = value;
}
else
{
 mstrRelationTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conRelationType.RelationTypeId);
}
}
/// <summary>
/// 关系类型名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RelationTypeName
{
get
{
return mstrRelationTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRelationTypeName = value;
}
else
{
 mstrRelationTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conRelationType.RelationTypeName);
}
}
/// <summary>
/// 关系属性名1(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RelationPropName1
{
get
{
return mstrRelationPropName1;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRelationPropName1 = value;
}
else
{
 mstrRelationPropName1 = value;
}
//记录修改过的字段
 AddUpdatedFld(conRelationType.RelationPropName1);
}
}
/// <summary>
/// 关系属性名2(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RelationPropName2
{
get
{
return mstrRelationPropName2;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRelationPropName2 = value;
}
else
{
 mstrRelationPropName2 = value;
}
//记录修改过的字段
 AddUpdatedFld(conRelationType.RelationPropName2);
}
}
/// <summary>
/// 工程ID(说明:;字段类型:char;字段长度:4;是否可空:False)
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
 AddUpdatedFld(conRelationType.PrjId);
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
 AddUpdatedFld(conRelationType.UpdDate);
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
 AddUpdatedFld(conRelationType.UpdUser);
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
 AddUpdatedFld(conRelationType.Memo);
}
}

/// <summary>
/// 获取关键字Id(keyId)
 /// (AutoGCLib.clsGeneCodeBase:GenGetKeyId)
/// </summary>
 public override string _KeyId
 {
 get
 {
  return mstrRelationTypeId;
 }
 }

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrRelationTypeName;
 }
 }
}
 /// <summary>
 /// 关系类型(RelationType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conRelationType
{
public new const string _CurrTabName = "RelationType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "RelationTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"RelationTypeId", "RelationTypeName", "RelationPropName1", "RelationPropName2", "PrjId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"RelationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RelationTypeId = "RelationTypeId";    //关系类型Id

 /// <summary>
 /// 常量:"RelationTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RelationTypeName = "RelationTypeName";    //关系类型名

 /// <summary>
 /// 常量:"RelationPropName1"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RelationPropName1 = "RelationPropName1";    //关系属性名1

 /// <summary>
 /// 常量:"RelationPropName2"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RelationPropName2 = "RelationPropName2";    //关系属性名2

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程ID

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