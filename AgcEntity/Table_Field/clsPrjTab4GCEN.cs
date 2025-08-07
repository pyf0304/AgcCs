
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjTab4GCEN
 表名:PrjTab4GC(00050345)
 生成代码版本:2019.07.25.1
 生成日期:2019/07/25 17:36:53
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:AGC
 工程ID:0005
 相关数据库:101.251.68.133,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护
 模块英文名:Table_Field
 框架-层名:实体层(EntityLayer)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
using System;
using System.Text; 
using System.Collections; 
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System.Runtime.Serialization;

namespace AGC.Entity
{
 /// <summary>
 /// 表PrjTab4GC的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public struct K_mId_PrjTab4GC
{
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get; }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngmId">表关键字</param>
public K_mId_PrjTab4GC(long lngmId)
{
if (IsValid(lngmId)) Value = lngmId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngmId)
{
if (lngmId == 0) return false;
if (lngmId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_mId_PrjTab4GC]类型的对象</returns>
public static implicit operator K_mId_PrjTab4GC(long value)
{
return new K_mId_PrjTab4GC(value);
}
}
 /// <summary>
 /// 工程表4GC(PrjTab4GC)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsPrjTab4GCEN : clsEntityBase2
{
public const string _CurrTabName_S = "PrjTab4GC"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"mId", "TabId4GC", "GeneCodeDate", "IsNeedGene", "ApplicationTypeId"};
//以下是属性变量

protected long mlngmId;    //mId
protected string mstrTabId4GC;    //表Id4GC
protected string mstrGeneCodeDate;    //生成代码日期
protected bool mbolIsNeedGene;    //是否需要生成
protected int mintApplicationTypeId;    //应用程序类型ID


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_mId = "mId";    //mId

 /// <summary>
 /// 常量:"TabId4GC"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_TabId4GC = "TabId4GC";    //表Id4GC

 /// <summary>
 /// 常量:"GeneCodeDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_GeneCodeDate = "GeneCodeDate";    //生成代码日期

 /// <summary>
 /// 常量:"IsNeedGene"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsNeedGene = "IsNeedGene";    //是否需要生成

 /// <summary>
 /// 常量:"ApplicationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ApplicationTypeId = "ApplicationTypeId";    //应用程序类型ID

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsPrjTab4GCEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "PrjTab4GC";
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:mId</param>
public clsPrjTab4GCEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "PrjTab4GC";
 lstKeyFldNames.Add("mId");
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
if (strAttributeName  ==  con_mId)
{
return mlngmId;
}
else if (strAttributeName  ==  con_TabId4GC)
{
return mstrTabId4GC;
}
else if (strAttributeName  ==  con_GeneCodeDate)
{
return mstrGeneCodeDate;
}
else if (strAttributeName  ==  con_IsNeedGene)
{
return mbolIsNeedGene;
}
else if (strAttributeName  ==  con_ApplicationTypeId)
{
return mintApplicationTypeId;
}
return null;
}
set
{
if (strAttributeName  ==  con_mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(con_mId);
}
else if (strAttributeName  ==  con_TabId4GC)
{
mstrTabId4GC = value.ToString();
 AddUpdatedFld(con_TabId4GC);
}
else if (strAttributeName  ==  con_GeneCodeDate)
{
mstrGeneCodeDate = value.ToString();
 AddUpdatedFld(con_GeneCodeDate);
}
else if (strAttributeName  ==  con_IsNeedGene)
{
mbolIsNeedGene = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsNeedGene);
}
else if (strAttributeName  ==  con_ApplicationTypeId)
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(con_ApplicationTypeId);
}
}
}
public object this[int intIndex]
{
get
{
if (con_mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (con_TabId4GC  ==  AttributeName[intIndex])
{
return mstrTabId4GC;
}
else if (con_GeneCodeDate  ==  AttributeName[intIndex])
{
return mstrGeneCodeDate;
}
else if (con_IsNeedGene  ==  AttributeName[intIndex])
{
return mbolIsNeedGene;
}
else if (con_ApplicationTypeId  ==  AttributeName[intIndex])
{
return mintApplicationTypeId;
}
return null;
}
set
{
if (con_mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(con_mId);
}
else if (con_TabId4GC  ==  AttributeName[intIndex])
{
mstrTabId4GC = value.ToString();
 AddUpdatedFld(con_TabId4GC);
}
else if (con_GeneCodeDate  ==  AttributeName[intIndex])
{
mstrGeneCodeDate = value.ToString();
 AddUpdatedFld(con_GeneCodeDate);
}
else if (con_IsNeedGene  ==  AttributeName[intIndex])
{
mbolIsNeedGene = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsNeedGene);
}
else if (con_ApplicationTypeId  ==  AttributeName[intIndex])
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(con_ApplicationTypeId);
}
}
}

/// <summary>
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long mId
{
get
{
return mlngmId;
}
set
{
 mlngmId = value;
//记录修改过的字段
 AddUpdatedFld(con_mId);
}
}
/// <summary>
/// 表Id4GC(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabId4GC
{
get
{
return mstrTabId4GC;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabId4GC = value;
}
else
{
 mstrTabId4GC = value;
}
//记录修改过的字段
 AddUpdatedFld(con_TabId4GC);
}
}
/// <summary>
/// 生成代码日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GeneCodeDate
{
get
{
return mstrGeneCodeDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGeneCodeDate = value;
}
else
{
 mstrGeneCodeDate = value;
}
//记录修改过的字段
 AddUpdatedFld(con_GeneCodeDate);
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
 AddUpdatedFld(con_IsNeedGene);
}
}
/// <summary>
/// 应用程序类型ID(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int ApplicationTypeId
{
get
{
return mintApplicationTypeId;
}
set
{
 mintApplicationTypeId = value;
//记录修改过的字段
 AddUpdatedFld(con_ApplicationTypeId);
}
}

/// <summary>
/// 获取关键字Id(KeyId)
 /// (AutoGCLib.clsGeneCodeBase:GenGetKeyId)
/// </summary>
 public override string _KeyId
 {
 get
 {
  return mlngmId.ToString();
 }
 }
}
}