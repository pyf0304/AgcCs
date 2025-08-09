
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsAssociationTabEN
 表名:AssociationTab(00050276)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:04:59
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统设置(SystemSet)
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
 /// 表AssociationTab的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_AssociationTab
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
public K_mId_AssociationTab(long lngmId)
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
 /// <returns>返回:[K_mId_AssociationTab]类型的对象</returns>
public static implicit operator K_mId_AssociationTab(long value)
{
return new K_mId_AssociationTab(value);
}
}
 /// <summary>
 /// 关联(AssociationTab)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsAssociationTabEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "AssociationTab"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 9;
public static string[] _AttributeName = new string[] {"mId", "PrjId", "TabId", "AssociationTabId", "AssociationPrjId", "AssociationTypeId", "UpdDate", "UpdUserId", "Memo"};

protected long mlngmId;    //mId
protected string mstrPrjId;    //工程Id
protected string mstrTabId;    //表ID
protected string mstrAssociationTabId;    //关联表Id
protected string mstrAssociationPrjId;    //关联项目Id
protected string mstrAssociationTypeId;    //关联类型Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsAssociationTabEN()
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
public clsAssociationTabEN(long lngmId)
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
if (strAttributeName  ==  conAssociationTab.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conAssociationTab.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conAssociationTab.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  conAssociationTab.AssociationTabId)
{
return mstrAssociationTabId;
}
else if (strAttributeName  ==  conAssociationTab.AssociationPrjId)
{
return mstrAssociationPrjId;
}
else if (strAttributeName  ==  conAssociationTab.AssociationTypeId)
{
return mstrAssociationTypeId;
}
else if (strAttributeName  ==  conAssociationTab.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conAssociationTab.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conAssociationTab.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conAssociationTab.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conAssociationTab.mId);
}
else if (strAttributeName  ==  conAssociationTab.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conAssociationTab.PrjId);
}
else if (strAttributeName  ==  conAssociationTab.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(conAssociationTab.TabId);
}
else if (strAttributeName  ==  conAssociationTab.AssociationTabId)
{
mstrAssociationTabId = value.ToString();
 AddUpdatedFld(conAssociationTab.AssociationTabId);
}
else if (strAttributeName  ==  conAssociationTab.AssociationPrjId)
{
mstrAssociationPrjId = value.ToString();
 AddUpdatedFld(conAssociationTab.AssociationPrjId);
}
else if (strAttributeName  ==  conAssociationTab.AssociationTypeId)
{
mstrAssociationTypeId = value.ToString();
 AddUpdatedFld(conAssociationTab.AssociationTypeId);
}
else if (strAttributeName  ==  conAssociationTab.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conAssociationTab.UpdDate);
}
else if (strAttributeName  ==  conAssociationTab.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conAssociationTab.UpdUserId);
}
else if (strAttributeName  ==  conAssociationTab.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conAssociationTab.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conAssociationTab.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (conAssociationTab.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conAssociationTab.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (conAssociationTab.AssociationTabId  ==  _AttributeName[intIndex])
{
return mstrAssociationTabId;
}
else if (conAssociationTab.AssociationPrjId  ==  _AttributeName[intIndex])
{
return mstrAssociationPrjId;
}
else if (conAssociationTab.AssociationTypeId  ==  _AttributeName[intIndex])
{
return mstrAssociationTypeId;
}
else if (conAssociationTab.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conAssociationTab.UpdUserId  ==  _AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conAssociationTab.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conAssociationTab.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conAssociationTab.mId);
}
else if (conAssociationTab.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conAssociationTab.PrjId);
}
else if (conAssociationTab.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(conAssociationTab.TabId);
}
else if (conAssociationTab.AssociationTabId  ==  _AttributeName[intIndex])
{
mstrAssociationTabId = value.ToString();
 AddUpdatedFld(conAssociationTab.AssociationTabId);
}
else if (conAssociationTab.AssociationPrjId  ==  _AttributeName[intIndex])
{
mstrAssociationPrjId = value.ToString();
 AddUpdatedFld(conAssociationTab.AssociationPrjId);
}
else if (conAssociationTab.AssociationTypeId  ==  _AttributeName[intIndex])
{
mstrAssociationTypeId = value.ToString();
 AddUpdatedFld(conAssociationTab.AssociationTypeId);
}
else if (conAssociationTab.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conAssociationTab.UpdDate);
}
else if (conAssociationTab.UpdUserId  ==  _AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conAssociationTab.UpdUserId);
}
else if (conAssociationTab.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conAssociationTab.Memo);
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
 AddUpdatedFld(conAssociationTab.mId);
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
 AddUpdatedFld(conAssociationTab.PrjId);
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
 AddUpdatedFld(conAssociationTab.TabId);
}
}
/// <summary>
/// 关联表Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AssociationTabId
{
get
{
return mstrAssociationTabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAssociationTabId = value;
}
else
{
 mstrAssociationTabId = value;
}
//记录修改过的字段
 AddUpdatedFld(conAssociationTab.AssociationTabId);
}
}
/// <summary>
/// 关联项目Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AssociationPrjId
{
get
{
return mstrAssociationPrjId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAssociationPrjId = value;
}
else
{
 mstrAssociationPrjId = value;
}
//记录修改过的字段
 AddUpdatedFld(conAssociationTab.AssociationPrjId);
}
}
/// <summary>
/// 关联类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AssociationTypeId
{
get
{
return mstrAssociationTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAssociationTypeId = value;
}
else
{
 mstrAssociationTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conAssociationTab.AssociationTypeId);
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
 AddUpdatedFld(conAssociationTab.UpdDate);
}
}
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUserId
{
get
{
return mstrUpdUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUserId = value;
}
else
{
 mstrUpdUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conAssociationTab.UpdUserId);
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
 AddUpdatedFld(conAssociationTab.Memo);
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
 /// 关联(AssociationTab)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conAssociationTab
{
public const string _CurrTabName = "AssociationTab"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "PrjId", "TabId", "AssociationTabId", "AssociationPrjId", "AssociationTypeId", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"TabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabId = "TabId";    //表ID

 /// <summary>
 /// 常量:"AssociationTabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AssociationTabId = "AssociationTabId";    //关联表Id

 /// <summary>
 /// 常量:"AssociationPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AssociationPrjId = "AssociationPrjId";    //关联项目Id

 /// <summary>
 /// 常量:"AssociationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AssociationTypeId = "AssociationTypeId";    //关联类型Id

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}