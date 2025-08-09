
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFeatureFieldTypeRelaEN
 表名:vFeatureFieldTypeRela(00050458)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:13:18
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
 /// 表vFeatureFieldTypeRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vFeatureFieldTypeRela
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
public K_mId_vFeatureFieldTypeRela(long lngmId)
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
 /// <returns>返回:[K_mId_vFeatureFieldTypeRela]类型的对象</returns>
public static implicit operator K_mId_vFeatureFieldTypeRela(long value)
{
return new K_mId_vFeatureFieldTypeRela(value);
}
}
 /// <summary>
 /// v功能字段类型关系(vFeatureFieldTypeRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvFeatureFieldTypeRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vFeatureFieldTypeRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 12;
public static string[] _AttributeName = new string[] {"mId", "FeatureId", "FeatureName", "KeyWords", "FeatureTypeName", "FieldTypeId", "FieldTypeName", "FieldTypeENName", "OrderNum", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrFeatureId;    //功能Id
protected string mstrFeatureName;    //功能名称
protected string mstrKeyWords;    //关键字
protected string mstrFeatureTypeName;    //功能类型名称
protected string mstrFieldTypeId;    //字段类型Id
protected string mstrFieldTypeName;    //字段类型名
protected string mstrFieldTypeENName;    //字段类型英文名
protected int? mintOrderNum;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvFeatureFieldTypeRelaEN()
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
public clsvFeatureFieldTypeRelaEN(long lngmId)
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
if (strAttributeName  ==  convFeatureFieldTypeRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convFeatureFieldTypeRela.FeatureId)
{
return mstrFeatureId;
}
else if (strAttributeName  ==  convFeatureFieldTypeRela.FeatureName)
{
return mstrFeatureName;
}
else if (strAttributeName  ==  convFeatureFieldTypeRela.KeyWords)
{
return mstrKeyWords;
}
else if (strAttributeName  ==  convFeatureFieldTypeRela.FeatureTypeName)
{
return mstrFeatureTypeName;
}
else if (strAttributeName  ==  convFeatureFieldTypeRela.FieldTypeId)
{
return mstrFieldTypeId;
}
else if (strAttributeName  ==  convFeatureFieldTypeRela.FieldTypeName)
{
return mstrFieldTypeName;
}
else if (strAttributeName  ==  convFeatureFieldTypeRela.FieldTypeENName)
{
return mstrFieldTypeENName;
}
else if (strAttributeName  ==  convFeatureFieldTypeRela.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convFeatureFieldTypeRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convFeatureFieldTypeRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convFeatureFieldTypeRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convFeatureFieldTypeRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convFeatureFieldTypeRela.mId);
}
else if (strAttributeName  ==  convFeatureFieldTypeRela.FeatureId)
{
mstrFeatureId = value.ToString();
 AddUpdatedFld(convFeatureFieldTypeRela.FeatureId);
}
else if (strAttributeName  ==  convFeatureFieldTypeRela.FeatureName)
{
mstrFeatureName = value.ToString();
 AddUpdatedFld(convFeatureFieldTypeRela.FeatureName);
}
else if (strAttributeName  ==  convFeatureFieldTypeRela.KeyWords)
{
mstrKeyWords = value.ToString();
 AddUpdatedFld(convFeatureFieldTypeRela.KeyWords);
}
else if (strAttributeName  ==  convFeatureFieldTypeRela.FeatureTypeName)
{
mstrFeatureTypeName = value.ToString();
 AddUpdatedFld(convFeatureFieldTypeRela.FeatureTypeName);
}
else if (strAttributeName  ==  convFeatureFieldTypeRela.FieldTypeId)
{
mstrFieldTypeId = value.ToString();
 AddUpdatedFld(convFeatureFieldTypeRela.FieldTypeId);
}
else if (strAttributeName  ==  convFeatureFieldTypeRela.FieldTypeName)
{
mstrFieldTypeName = value.ToString();
 AddUpdatedFld(convFeatureFieldTypeRela.FieldTypeName);
}
else if (strAttributeName  ==  convFeatureFieldTypeRela.FieldTypeENName)
{
mstrFieldTypeENName = value.ToString();
 AddUpdatedFld(convFeatureFieldTypeRela.FieldTypeENName);
}
else if (strAttributeName  ==  convFeatureFieldTypeRela.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFeatureFieldTypeRela.OrderNum);
}
else if (strAttributeName  ==  convFeatureFieldTypeRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFeatureFieldTypeRela.UpdDate);
}
else if (strAttributeName  ==  convFeatureFieldTypeRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFeatureFieldTypeRela.UpdUser);
}
else if (strAttributeName  ==  convFeatureFieldTypeRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFeatureFieldTypeRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convFeatureFieldTypeRela.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (convFeatureFieldTypeRela.FeatureId  ==  _AttributeName[intIndex])
{
return mstrFeatureId;
}
else if (convFeatureFieldTypeRela.FeatureName  ==  _AttributeName[intIndex])
{
return mstrFeatureName;
}
else if (convFeatureFieldTypeRela.KeyWords  ==  _AttributeName[intIndex])
{
return mstrKeyWords;
}
else if (convFeatureFieldTypeRela.FeatureTypeName  ==  _AttributeName[intIndex])
{
return mstrFeatureTypeName;
}
else if (convFeatureFieldTypeRela.FieldTypeId  ==  _AttributeName[intIndex])
{
return mstrFieldTypeId;
}
else if (convFeatureFieldTypeRela.FieldTypeName  ==  _AttributeName[intIndex])
{
return mstrFieldTypeName;
}
else if (convFeatureFieldTypeRela.FieldTypeENName  ==  _AttributeName[intIndex])
{
return mstrFieldTypeENName;
}
else if (convFeatureFieldTypeRela.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convFeatureFieldTypeRela.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convFeatureFieldTypeRela.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convFeatureFieldTypeRela.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convFeatureFieldTypeRela.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convFeatureFieldTypeRela.mId);
}
else if (convFeatureFieldTypeRela.FeatureId  ==  _AttributeName[intIndex])
{
mstrFeatureId = value.ToString();
 AddUpdatedFld(convFeatureFieldTypeRela.FeatureId);
}
else if (convFeatureFieldTypeRela.FeatureName  ==  _AttributeName[intIndex])
{
mstrFeatureName = value.ToString();
 AddUpdatedFld(convFeatureFieldTypeRela.FeatureName);
}
else if (convFeatureFieldTypeRela.KeyWords  ==  _AttributeName[intIndex])
{
mstrKeyWords = value.ToString();
 AddUpdatedFld(convFeatureFieldTypeRela.KeyWords);
}
else if (convFeatureFieldTypeRela.FeatureTypeName  ==  _AttributeName[intIndex])
{
mstrFeatureTypeName = value.ToString();
 AddUpdatedFld(convFeatureFieldTypeRela.FeatureTypeName);
}
else if (convFeatureFieldTypeRela.FieldTypeId  ==  _AttributeName[intIndex])
{
mstrFieldTypeId = value.ToString();
 AddUpdatedFld(convFeatureFieldTypeRela.FieldTypeId);
}
else if (convFeatureFieldTypeRela.FieldTypeName  ==  _AttributeName[intIndex])
{
mstrFieldTypeName = value.ToString();
 AddUpdatedFld(convFeatureFieldTypeRela.FieldTypeName);
}
else if (convFeatureFieldTypeRela.FieldTypeENName  ==  _AttributeName[intIndex])
{
mstrFieldTypeENName = value.ToString();
 AddUpdatedFld(convFeatureFieldTypeRela.FieldTypeENName);
}
else if (convFeatureFieldTypeRela.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFeatureFieldTypeRela.OrderNum);
}
else if (convFeatureFieldTypeRela.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFeatureFieldTypeRela.UpdDate);
}
else if (convFeatureFieldTypeRela.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFeatureFieldTypeRela.UpdUser);
}
else if (convFeatureFieldTypeRela.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFeatureFieldTypeRela.Memo);
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
 AddUpdatedFld(convFeatureFieldTypeRela.mId);
}
}
/// <summary>
/// 功能Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FeatureId
{
get
{
return mstrFeatureId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFeatureId = value;
}
else
{
 mstrFeatureId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureFieldTypeRela.FeatureId);
}
}
/// <summary>
/// 功能名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FeatureName
{
get
{
return mstrFeatureName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFeatureName = value;
}
else
{
 mstrFeatureName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureFieldTypeRela.FeatureName);
}
}
/// <summary>
/// 关键字(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KeyWords
{
get
{
return mstrKeyWords;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeyWords = value;
}
else
{
 mstrKeyWords = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureFieldTypeRela.KeyWords);
}
}
/// <summary>
/// 功能类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FeatureTypeName
{
get
{
return mstrFeatureTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFeatureTypeName = value;
}
else
{
 mstrFeatureTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureFieldTypeRela.FeatureTypeName);
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
 AddUpdatedFld(convFeatureFieldTypeRela.FieldTypeId);
}
}
/// <summary>
/// 字段类型名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FieldTypeName
{
get
{
return mstrFieldTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFieldTypeName = value;
}
else
{
 mstrFieldTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureFieldTypeRela.FieldTypeName);
}
}
/// <summary>
/// 字段类型英文名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FieldTypeENName
{
get
{
return mstrFieldTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFieldTypeENName = value;
}
else
{
 mstrFieldTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureFieldTypeRela.FieldTypeENName);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(convFeatureFieldTypeRela.OrderNum);
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
 AddUpdatedFld(convFeatureFieldTypeRela.UpdDate);
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
 AddUpdatedFld(convFeatureFieldTypeRela.UpdUser);
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
 AddUpdatedFld(convFeatureFieldTypeRela.Memo);
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
 /// v功能字段类型关系(vFeatureFieldTypeRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convFeatureFieldTypeRela
{
public const string _CurrTabName = "vFeatureFieldTypeRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "FeatureId", "FeatureName", "KeyWords", "FeatureTypeName", "FieldTypeId", "FieldTypeName", "FieldTypeENName", "OrderNum", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"FeatureId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeatureId = "FeatureId";    //功能Id

 /// <summary>
 /// 常量:"FeatureName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeatureName = "FeatureName";    //功能名称

 /// <summary>
 /// 常量:"KeyWords"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KeyWords = "KeyWords";    //关键字

 /// <summary>
 /// 常量:"FeatureTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeatureTypeName = "FeatureTypeName";    //功能类型名称

 /// <summary>
 /// 常量:"FieldTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FieldTypeId = "FieldTypeId";    //字段类型Id

 /// <summary>
 /// 常量:"FieldTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FieldTypeName = "FieldTypeName";    //字段类型名

 /// <summary>
 /// 常量:"FieldTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FieldTypeENName = "FieldTypeENName";    //字段类型英文名

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

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