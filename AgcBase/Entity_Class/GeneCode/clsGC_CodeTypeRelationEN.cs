
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsGC_CodeTypeRelationEN
 表名:GC_CodeTypeRelation(00050646)
 * 版本:2026.05.30(服务器:PYF-AI)
 日期:2026/06/05 05:21:14
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
 /// 表GC_CodeTypeRelation的关键字(RelationId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_RelationId_GC_CodeTypeRelation
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngRelationId">表关键字</param>
public K_RelationId_GC_CodeTypeRelation(long lngRelationId)
{
if (IsValid(lngRelationId)) Value = lngRelationId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngRelationId)
{
if (lngRelationId == 0) return false;
if (lngRelationId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_RelationId_GC_CodeTypeRelation]类型的对象</returns>
public static implicit operator K_RelationId_GC_CodeTypeRelation(long value)
{
return new K_RelationId_GC_CodeTypeRelation(value);
}
}
 /// <summary>
 /// GC_代码类型关系(GC_CodeTypeRelation)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsGC_CodeTypeRelationEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "GC_CodeTypeRelation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "RelationId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 7;
public static string[] _AttributeName = new string[] {"RelationId", "ParentCodeTypeId", "ChildCodeTypeId", "CtRelationTypeId", "Description", "UpdDate", "UpdUser"};

protected long mlngRelationId;    //关系Id
protected string mstrParentCodeTypeId;    //父代码类型Id
protected string mstrChildCodeTypeId;    //子代码类型Id
protected string mstrCtRelationTypeId;    //Ct关系类型Id
protected string mstrDescription;    //描述
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsGC_CodeTypeRelationEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("RelationId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "lngRelationId">关键字:关系Id</param>
public clsGC_CodeTypeRelationEN(long lngRelationId)
 {
 if (lngRelationId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngRelationId = lngRelationId;
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
if (strAttributeName  ==  conGC_CodeTypeRelation.RelationId)
{
return mlngRelationId;
}
else if (strAttributeName  ==  conGC_CodeTypeRelation.ParentCodeTypeId)
{
return mstrParentCodeTypeId;
}
else if (strAttributeName  ==  conGC_CodeTypeRelation.ChildCodeTypeId)
{
return mstrChildCodeTypeId;
}
else if (strAttributeName  ==  conGC_CodeTypeRelation.CtRelationTypeId)
{
return mstrCtRelationTypeId;
}
else if (strAttributeName  ==  conGC_CodeTypeRelation.Description)
{
return mstrDescription;
}
else if (strAttributeName  ==  conGC_CodeTypeRelation.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conGC_CodeTypeRelation.UpdUser)
{
return mstrUpdUser;
}
return null;
}
set
{
if (strAttributeName  ==  conGC_CodeTypeRelation.RelationId)
{
mlngRelationId = TransNullToInt(value.ToString());
 AddUpdatedFld(conGC_CodeTypeRelation.RelationId);
}
else if (strAttributeName  ==  conGC_CodeTypeRelation.ParentCodeTypeId)
{
mstrParentCodeTypeId = value.ToString();
 AddUpdatedFld(conGC_CodeTypeRelation.ParentCodeTypeId);
}
else if (strAttributeName  ==  conGC_CodeTypeRelation.ChildCodeTypeId)
{
mstrChildCodeTypeId = value.ToString();
 AddUpdatedFld(conGC_CodeTypeRelation.ChildCodeTypeId);
}
else if (strAttributeName  ==  conGC_CodeTypeRelation.CtRelationTypeId)
{
mstrCtRelationTypeId = value.ToString();
 AddUpdatedFld(conGC_CodeTypeRelation.CtRelationTypeId);
}
else if (strAttributeName  ==  conGC_CodeTypeRelation.Description)
{
mstrDescription = value.ToString();
 AddUpdatedFld(conGC_CodeTypeRelation.Description);
}
else if (strAttributeName  ==  conGC_CodeTypeRelation.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conGC_CodeTypeRelation.UpdDate);
}
else if (strAttributeName  ==  conGC_CodeTypeRelation.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conGC_CodeTypeRelation.UpdUser);
}
}
}
public object this[int intIndex]
{
get
{
if (conGC_CodeTypeRelation.RelationId  ==  _AttributeName[intIndex])
{
return mlngRelationId;
}
else if (conGC_CodeTypeRelation.ParentCodeTypeId  ==  _AttributeName[intIndex])
{
return mstrParentCodeTypeId;
}
else if (conGC_CodeTypeRelation.ChildCodeTypeId  ==  _AttributeName[intIndex])
{
return mstrChildCodeTypeId;
}
else if (conGC_CodeTypeRelation.CtRelationTypeId  ==  _AttributeName[intIndex])
{
return mstrCtRelationTypeId;
}
else if (conGC_CodeTypeRelation.Description  ==  _AttributeName[intIndex])
{
return mstrDescription;
}
else if (conGC_CodeTypeRelation.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conGC_CodeTypeRelation.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
return null;
}
set
{
if (conGC_CodeTypeRelation.RelationId  ==  _AttributeName[intIndex])
{
mlngRelationId = TransNullToInt(value.ToString());
 AddUpdatedFld(conGC_CodeTypeRelation.RelationId);
}
else if (conGC_CodeTypeRelation.ParentCodeTypeId  ==  _AttributeName[intIndex])
{
mstrParentCodeTypeId = value.ToString();
 AddUpdatedFld(conGC_CodeTypeRelation.ParentCodeTypeId);
}
else if (conGC_CodeTypeRelation.ChildCodeTypeId  ==  _AttributeName[intIndex])
{
mstrChildCodeTypeId = value.ToString();
 AddUpdatedFld(conGC_CodeTypeRelation.ChildCodeTypeId);
}
else if (conGC_CodeTypeRelation.CtRelationTypeId  ==  _AttributeName[intIndex])
{
mstrCtRelationTypeId = value.ToString();
 AddUpdatedFld(conGC_CodeTypeRelation.CtRelationTypeId);
}
else if (conGC_CodeTypeRelation.Description  ==  _AttributeName[intIndex])
{
mstrDescription = value.ToString();
 AddUpdatedFld(conGC_CodeTypeRelation.Description);
}
else if (conGC_CodeTypeRelation.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conGC_CodeTypeRelation.UpdDate);
}
else if (conGC_CodeTypeRelation.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conGC_CodeTypeRelation.UpdUser);
}
}
}

/// <summary>
/// 关系Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long RelationId
{
get
{
return mlngRelationId;
}
set
{
 mlngRelationId = value;
//记录修改过的字段
 AddUpdatedFld(conGC_CodeTypeRelation.RelationId);
}
}
/// <summary>
/// 父代码类型Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParentCodeTypeId
{
get
{
return mstrParentCodeTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParentCodeTypeId = value;
}
else
{
 mstrParentCodeTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conGC_CodeTypeRelation.ParentCodeTypeId);
}
}
/// <summary>
/// 子代码类型Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ChildCodeTypeId
{
get
{
return mstrChildCodeTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrChildCodeTypeId = value;
}
else
{
 mstrChildCodeTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conGC_CodeTypeRelation.ChildCodeTypeId);
}
}
/// <summary>
/// Ct关系类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CtRelationTypeId
{
get
{
return mstrCtRelationTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCtRelationTypeId = value;
}
else
{
 mstrCtRelationTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conGC_CodeTypeRelation.CtRelationTypeId);
}
}
/// <summary>
/// 描述(说明:;字段类型:varchar;字段长度:300;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Description
{
get
{
return mstrDescription;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDescription = value;
}
else
{
 mstrDescription = value;
}
//记录修改过的字段
 AddUpdatedFld(conGC_CodeTypeRelation.Description);
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
 AddUpdatedFld(conGC_CodeTypeRelation.UpdDate);
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
 AddUpdatedFld(conGC_CodeTypeRelation.UpdUser);
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
  return mlngRelationId.ToString();
 }
 }
}
 /// <summary>
 /// GC_代码类型关系(GC_CodeTypeRelation)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conGC_CodeTypeRelation
{
public const string _CurrTabName = "GC_CodeTypeRelation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "RelationId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"RelationId", "ParentCodeTypeId", "ChildCodeTypeId", "CtRelationTypeId", "Description", "UpdDate", "UpdUser"};
//以下是属性变量


 /// <summary>
 /// 常量:"RelationId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RelationId = "RelationId";    //关系Id

 /// <summary>
 /// 常量:"ParentCodeTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParentCodeTypeId = "ParentCodeTypeId";    //父代码类型Id

 /// <summary>
 /// 常量:"ChildCodeTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ChildCodeTypeId = "ChildCodeTypeId";    //子代码类型Id

 /// <summary>
 /// 常量:"CtRelationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CtRelationTypeId = "CtRelationTypeId";    //Ct关系类型Id

 /// <summary>
 /// 常量:"Description"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Description = "Description";    //描述

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
}

}