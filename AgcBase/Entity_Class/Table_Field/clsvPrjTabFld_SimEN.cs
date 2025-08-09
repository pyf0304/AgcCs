
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjTabFld_SimEN
 表名:vPrjTabFld_Sim(00050589)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:02:52
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
 /// 表vPrjTabFld_Sim的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vPrjTabFld_Sim
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngmId">表关键字</param>
public K_mId_vPrjTabFld_Sim(long lngmId)
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
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_mId_vPrjTabFld_Sim]类型的对象</returns>
public static implicit operator K_mId_vPrjTabFld_Sim(long value)
{
return new K_mId_vPrjTabFld_Sim(value);
}
}
 /// <summary>
 /// v工程表字段_Sim(vPrjTabFld_Sim)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvPrjTabFld_SimEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vPrjTabFld_Sim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 7;
public static string[] _AttributeName = new string[] {"mId", "TabId", "PrjId", "FldId", "SequenceNumber", "FieldTypeId", "IsForExtendClass"};

protected long mlngmId;    //mId
protected string mstrTabId;    //表ID
protected string mstrPrjId;    //工程Id
protected string mstrFldId;    //字段Id
protected int? mintSequenceNumber;    //顺序号
protected string mstrFieldTypeId;    //字段类型Id
protected bool mbolIsForExtendClass;    //用于扩展类

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvPrjTabFld_SimEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:mId</param>
public clsvPrjTabFld_SimEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
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
if (strAttributeName  ==  convPrjTabFld_Sim.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convPrjTabFld_Sim.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  convPrjTabFld_Sim.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convPrjTabFld_Sim.FldId)
{
return mstrFldId;
}
else if (strAttributeName  ==  convPrjTabFld_Sim.SequenceNumber)
{
return mintSequenceNumber;
}
else if (strAttributeName  ==  convPrjTabFld_Sim.FieldTypeId)
{
return mstrFieldTypeId;
}
else if (strAttributeName  ==  convPrjTabFld_Sim.IsForExtendClass)
{
return mbolIsForExtendClass;
}
return null;
}
set
{
if (strAttributeName  ==  convPrjTabFld_Sim.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convPrjTabFld_Sim.mId);
}
else if (strAttributeName  ==  convPrjTabFld_Sim.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(convPrjTabFld_Sim.TabId);
}
else if (strAttributeName  ==  convPrjTabFld_Sim.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convPrjTabFld_Sim.PrjId);
}
else if (strAttributeName  ==  convPrjTabFld_Sim.FldId)
{
mstrFldId = value.ToString();
 AddUpdatedFld(convPrjTabFld_Sim.FldId);
}
else if (strAttributeName  ==  convPrjTabFld_Sim.SequenceNumber)
{
mintSequenceNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convPrjTabFld_Sim.SequenceNumber);
}
else if (strAttributeName  ==  convPrjTabFld_Sim.FieldTypeId)
{
mstrFieldTypeId = value.ToString();
 AddUpdatedFld(convPrjTabFld_Sim.FieldTypeId);
}
else if (strAttributeName  ==  convPrjTabFld_Sim.IsForExtendClass)
{
mbolIsForExtendClass = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTabFld_Sim.IsForExtendClass);
}
}
}
public object this[int intIndex]
{
get
{
if (convPrjTabFld_Sim.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (convPrjTabFld_Sim.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (convPrjTabFld_Sim.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convPrjTabFld_Sim.FldId  ==  _AttributeName[intIndex])
{
return mstrFldId;
}
else if (convPrjTabFld_Sim.SequenceNumber  ==  _AttributeName[intIndex])
{
return mintSequenceNumber;
}
else if (convPrjTabFld_Sim.FieldTypeId  ==  _AttributeName[intIndex])
{
return mstrFieldTypeId;
}
else if (convPrjTabFld_Sim.IsForExtendClass  ==  _AttributeName[intIndex])
{
return mbolIsForExtendClass;
}
return null;
}
set
{
if (convPrjTabFld_Sim.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convPrjTabFld_Sim.mId);
}
else if (convPrjTabFld_Sim.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(convPrjTabFld_Sim.TabId);
}
else if (convPrjTabFld_Sim.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convPrjTabFld_Sim.PrjId);
}
else if (convPrjTabFld_Sim.FldId  ==  _AttributeName[intIndex])
{
mstrFldId = value.ToString();
 AddUpdatedFld(convPrjTabFld_Sim.FldId);
}
else if (convPrjTabFld_Sim.SequenceNumber  ==  _AttributeName[intIndex])
{
mintSequenceNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convPrjTabFld_Sim.SequenceNumber);
}
else if (convPrjTabFld_Sim.FieldTypeId  ==  _AttributeName[intIndex])
{
mstrFieldTypeId = value.ToString();
 AddUpdatedFld(convPrjTabFld_Sim.FieldTypeId);
}
else if (convPrjTabFld_Sim.IsForExtendClass  ==  _AttributeName[intIndex])
{
mbolIsForExtendClass = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTabFld_Sim.IsForExtendClass);
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
 AddUpdatedFld(convPrjTabFld_Sim.mId);
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
 AddUpdatedFld(convPrjTabFld_Sim.TabId);
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
 AddUpdatedFld(convPrjTabFld_Sim.PrjId);
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
 AddUpdatedFld(convPrjTabFld_Sim.FldId);
}
}
/// <summary>
/// 顺序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? SequenceNumber
{
get
{
return mintSequenceNumber;
}
set
{
 mintSequenceNumber = value;
//记录修改过的字段
 AddUpdatedFld(convPrjTabFld_Sim.SequenceNumber);
}
}
/// <summary>
/// 字段类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FieldTypeId
{
get
{
return mstrFieldTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFieldTypeId = value;
}
else
{
 mstrFieldTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjTabFld_Sim.FieldTypeId);
}
}
/// <summary>
/// 用于扩展类(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsForExtendClass
{
get
{
return mbolIsForExtendClass;
}
set
{
 mbolIsForExtendClass = value;
//记录修改过的字段
 AddUpdatedFld(convPrjTabFld_Sim.IsForExtendClass);
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
  return mlngmId.ToString();
 }
 }
}
 /// <summary>
 /// v工程表字段_Sim(vPrjTabFld_Sim)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convPrjTabFld_Sim
{
public const string _CurrTabName = "vPrjTabFld_Sim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "TabId", "PrjId", "FldId", "SequenceNumber", "FieldTypeId", "IsForExtendClass"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

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
 /// 常量:"FldId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldId = "FldId";    //字段Id

 /// <summary>
 /// 常量:"SequenceNumber"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SequenceNumber = "SequenceNumber";    //顺序号

 /// <summary>
 /// 常量:"FieldTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FieldTypeId = "FieldTypeId";    //字段类型Id

 /// <summary>
 /// 常量:"IsForExtendClass"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsForExtendClass = "IsForExtendClass";    //用于扩展类
}

}