
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFieldTab4RootFldEN
 表名:FieldTab4RootFld(00050422)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:34:13
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
 /// 表FieldTab4RootFld的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_FieldTab4RootFld
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
public K_mId_FieldTab4RootFld(long lngmId)
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
 /// <returns>返回:[K_mId_FieldTab4RootFld]类型的对象</returns>
public static implicit operator K_mId_FieldTab4RootFld(long value)
{
return new K_mId_FieldTab4RootFld(value);
}
}
 /// <summary>
 /// 工程字段4RootFld(FieldTab4RootFld)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsFieldTab4RootFldEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "FieldTab4RootFld"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 12;
public static string[] _AttributeName = new string[] {"mId", "TabId", "FldId", "IsPrimaryKey", "IsRootFld", "Root4TabId", "RootFldId", "RootTabId", "PrjId", "UpdUser", "UpdDate", "Memo"};

protected long mlngmId;    //mId
protected string mstrTabId;    //表ID
protected string mstrFldId;    //字段Id
protected bool mbolIsPrimaryKey;    //是否主键
protected bool mbolIsRootFld;    //是否根字段
protected string mstrRoot4TabId;    //主根表Id
protected string mstrRootFldId;    //根字段Id
protected string mstrRootTabId;    //根表Id
protected string mstrPrjId;    //工程Id
protected string mstrUpdUser;    //修改者
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsFieldTab4RootFldEN()
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
public clsFieldTab4RootFldEN(long lngmId)
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
if (strAttributeName  ==  conFieldTab4RootFld.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conFieldTab4RootFld.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  conFieldTab4RootFld.FldId)
{
return mstrFldId;
}
else if (strAttributeName  ==  conFieldTab4RootFld.IsPrimaryKey)
{
return mbolIsPrimaryKey;
}
else if (strAttributeName  ==  conFieldTab4RootFld.IsRootFld)
{
return mbolIsRootFld;
}
else if (strAttributeName  ==  conFieldTab4RootFld.Root4TabId)
{
return mstrRoot4TabId;
}
else if (strAttributeName  ==  conFieldTab4RootFld.RootFldId)
{
return mstrRootFldId;
}
else if (strAttributeName  ==  conFieldTab4RootFld.RootTabId)
{
return mstrRootTabId;
}
else if (strAttributeName  ==  conFieldTab4RootFld.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conFieldTab4RootFld.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conFieldTab4RootFld.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conFieldTab4RootFld.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conFieldTab4RootFld.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conFieldTab4RootFld.mId);
}
else if (strAttributeName  ==  conFieldTab4RootFld.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(conFieldTab4RootFld.TabId);
}
else if (strAttributeName  ==  conFieldTab4RootFld.FldId)
{
mstrFldId = value.ToString();
 AddUpdatedFld(conFieldTab4RootFld.FldId);
}
else if (strAttributeName  ==  conFieldTab4RootFld.IsPrimaryKey)
{
mbolIsPrimaryKey = TransNullToBool(value.ToString());
 AddUpdatedFld(conFieldTab4RootFld.IsPrimaryKey);
}
else if (strAttributeName  ==  conFieldTab4RootFld.IsRootFld)
{
mbolIsRootFld = TransNullToBool(value.ToString());
 AddUpdatedFld(conFieldTab4RootFld.IsRootFld);
}
else if (strAttributeName  ==  conFieldTab4RootFld.Root4TabId)
{
mstrRoot4TabId = value.ToString();
 AddUpdatedFld(conFieldTab4RootFld.Root4TabId);
}
else if (strAttributeName  ==  conFieldTab4RootFld.RootFldId)
{
mstrRootFldId = value.ToString();
 AddUpdatedFld(conFieldTab4RootFld.RootFldId);
}
else if (strAttributeName  ==  conFieldTab4RootFld.RootTabId)
{
mstrRootTabId = value.ToString();
 AddUpdatedFld(conFieldTab4RootFld.RootTabId);
}
else if (strAttributeName  ==  conFieldTab4RootFld.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conFieldTab4RootFld.PrjId);
}
else if (strAttributeName  ==  conFieldTab4RootFld.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conFieldTab4RootFld.UpdUser);
}
else if (strAttributeName  ==  conFieldTab4RootFld.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFieldTab4RootFld.UpdDate);
}
else if (strAttributeName  ==  conFieldTab4RootFld.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFieldTab4RootFld.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conFieldTab4RootFld.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (conFieldTab4RootFld.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (conFieldTab4RootFld.FldId  ==  _AttributeName[intIndex])
{
return mstrFldId;
}
else if (conFieldTab4RootFld.IsPrimaryKey  ==  _AttributeName[intIndex])
{
return mbolIsPrimaryKey;
}
else if (conFieldTab4RootFld.IsRootFld  ==  _AttributeName[intIndex])
{
return mbolIsRootFld;
}
else if (conFieldTab4RootFld.Root4TabId  ==  _AttributeName[intIndex])
{
return mstrRoot4TabId;
}
else if (conFieldTab4RootFld.RootFldId  ==  _AttributeName[intIndex])
{
return mstrRootFldId;
}
else if (conFieldTab4RootFld.RootTabId  ==  _AttributeName[intIndex])
{
return mstrRootTabId;
}
else if (conFieldTab4RootFld.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conFieldTab4RootFld.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conFieldTab4RootFld.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conFieldTab4RootFld.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conFieldTab4RootFld.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conFieldTab4RootFld.mId);
}
else if (conFieldTab4RootFld.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(conFieldTab4RootFld.TabId);
}
else if (conFieldTab4RootFld.FldId  ==  _AttributeName[intIndex])
{
mstrFldId = value.ToString();
 AddUpdatedFld(conFieldTab4RootFld.FldId);
}
else if (conFieldTab4RootFld.IsPrimaryKey  ==  _AttributeName[intIndex])
{
mbolIsPrimaryKey = TransNullToBool(value.ToString());
 AddUpdatedFld(conFieldTab4RootFld.IsPrimaryKey);
}
else if (conFieldTab4RootFld.IsRootFld  ==  _AttributeName[intIndex])
{
mbolIsRootFld = TransNullToBool(value.ToString());
 AddUpdatedFld(conFieldTab4RootFld.IsRootFld);
}
else if (conFieldTab4RootFld.Root4TabId  ==  _AttributeName[intIndex])
{
mstrRoot4TabId = value.ToString();
 AddUpdatedFld(conFieldTab4RootFld.Root4TabId);
}
else if (conFieldTab4RootFld.RootFldId  ==  _AttributeName[intIndex])
{
mstrRootFldId = value.ToString();
 AddUpdatedFld(conFieldTab4RootFld.RootFldId);
}
else if (conFieldTab4RootFld.RootTabId  ==  _AttributeName[intIndex])
{
mstrRootTabId = value.ToString();
 AddUpdatedFld(conFieldTab4RootFld.RootTabId);
}
else if (conFieldTab4RootFld.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conFieldTab4RootFld.PrjId);
}
else if (conFieldTab4RootFld.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conFieldTab4RootFld.UpdUser);
}
else if (conFieldTab4RootFld.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFieldTab4RootFld.UpdDate);
}
else if (conFieldTab4RootFld.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFieldTab4RootFld.Memo);
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
 AddUpdatedFld(conFieldTab4RootFld.mId);
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
 AddUpdatedFld(conFieldTab4RootFld.TabId);
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
 AddUpdatedFld(conFieldTab4RootFld.FldId);
}
}
/// <summary>
/// 是否主键(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsPrimaryKey
{
get
{
return mbolIsPrimaryKey;
}
set
{
 mbolIsPrimaryKey = value;
//记录修改过的字段
 AddUpdatedFld(conFieldTab4RootFld.IsPrimaryKey);
}
}
/// <summary>
/// 是否根字段(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsRootFld
{
get
{
return mbolIsRootFld;
}
set
{
 mbolIsRootFld = value;
//记录修改过的字段
 AddUpdatedFld(conFieldTab4RootFld.IsRootFld);
}
}
/// <summary>
/// 主根表Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Root4TabId
{
get
{
return mstrRoot4TabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRoot4TabId = value;
}
else
{
 mstrRoot4TabId = value;
}
//记录修改过的字段
 AddUpdatedFld(conFieldTab4RootFld.Root4TabId);
}
}
/// <summary>
/// 根字段Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RootFldId
{
get
{
return mstrRootFldId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRootFldId = value;
}
else
{
 mstrRootFldId = value;
}
//记录修改过的字段
 AddUpdatedFld(conFieldTab4RootFld.RootFldId);
}
}
/// <summary>
/// 根表Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RootTabId
{
get
{
return mstrRootTabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRootTabId = value;
}
else
{
 mstrRootTabId = value;
}
//记录修改过的字段
 AddUpdatedFld(conFieldTab4RootFld.RootTabId);
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
 AddUpdatedFld(conFieldTab4RootFld.PrjId);
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
 AddUpdatedFld(conFieldTab4RootFld.UpdUser);
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
 AddUpdatedFld(conFieldTab4RootFld.UpdDate);
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
 AddUpdatedFld(conFieldTab4RootFld.Memo);
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
 /// 工程字段4RootFld(FieldTab4RootFld)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conFieldTab4RootFld
{
public const string _CurrTabName = "FieldTab4RootFld"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "TabId", "FldId", "IsPrimaryKey", "IsRootFld", "Root4TabId", "RootFldId", "RootTabId", "PrjId", "UpdUser", "UpdDate", "Memo"};
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
 /// 常量:"FldId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldId = "FldId";    //字段Id

 /// <summary>
 /// 常量:"IsPrimaryKey"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsPrimaryKey = "IsPrimaryKey";    //是否主键

 /// <summary>
 /// 常量:"IsRootFld"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsRootFld = "IsRootFld";    //是否根字段

 /// <summary>
 /// 常量:"Root4TabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Root4TabId = "Root4TabId";    //主根表Id

 /// <summary>
 /// 常量:"RootFldId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RootFldId = "RootFldId";    //根字段Id

 /// <summary>
 /// 常量:"RootTabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RootTabId = "RootTabId";    //根表Id

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