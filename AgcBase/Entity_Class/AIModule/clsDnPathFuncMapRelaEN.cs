
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDnPathFuncMapRelaEN
 表名:DnPathFuncMapRela(00050601)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:06:58
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:AI模块(AIModule)
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
 /// 表DnPathFuncMapRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_DnPathFuncMapRela
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
public K_mId_DnPathFuncMapRela(long lngmId)
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
 /// <returns>返回:[K_mId_DnPathFuncMapRela]类型的对象</returns>
public static implicit operator K_mId_DnPathFuncMapRela(long value)
{
return new K_mId_DnPathFuncMapRela(value);
}
}
 /// <summary>
 /// Dn路径函数映射关系(DnPathFuncMapRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsDnPathFuncMapRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "DnPathFuncMapRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 7;
public static string[] _AttributeName = new string[] {"mId", "DnPathId", "DnFuncMapId", "PrjId", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrDnPathId;    //DN路径Id
protected string mstrDnFuncMapId;    //函数映射Id
protected string mstrPrjId;    //工程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsDnPathFuncMapRelaEN()
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
public clsDnPathFuncMapRelaEN(long lngmId)
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
if (strAttributeName  ==  conDnPathFuncMapRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conDnPathFuncMapRela.DnPathId)
{
return mstrDnPathId;
}
else if (strAttributeName  ==  conDnPathFuncMapRela.DnFuncMapId)
{
return mstrDnFuncMapId;
}
else if (strAttributeName  ==  conDnPathFuncMapRela.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conDnPathFuncMapRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conDnPathFuncMapRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conDnPathFuncMapRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conDnPathFuncMapRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conDnPathFuncMapRela.mId);
}
else if (strAttributeName  ==  conDnPathFuncMapRela.DnPathId)
{
mstrDnPathId = value.ToString();
 AddUpdatedFld(conDnPathFuncMapRela.DnPathId);
}
else if (strAttributeName  ==  conDnPathFuncMapRela.DnFuncMapId)
{
mstrDnFuncMapId = value.ToString();
 AddUpdatedFld(conDnPathFuncMapRela.DnFuncMapId);
}
else if (strAttributeName  ==  conDnPathFuncMapRela.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conDnPathFuncMapRela.PrjId);
}
else if (strAttributeName  ==  conDnPathFuncMapRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conDnPathFuncMapRela.UpdDate);
}
else if (strAttributeName  ==  conDnPathFuncMapRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conDnPathFuncMapRela.UpdUser);
}
else if (strAttributeName  ==  conDnPathFuncMapRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDnPathFuncMapRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conDnPathFuncMapRela.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (conDnPathFuncMapRela.DnPathId  ==  _AttributeName[intIndex])
{
return mstrDnPathId;
}
else if (conDnPathFuncMapRela.DnFuncMapId  ==  _AttributeName[intIndex])
{
return mstrDnFuncMapId;
}
else if (conDnPathFuncMapRela.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conDnPathFuncMapRela.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conDnPathFuncMapRela.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conDnPathFuncMapRela.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conDnPathFuncMapRela.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conDnPathFuncMapRela.mId);
}
else if (conDnPathFuncMapRela.DnPathId  ==  _AttributeName[intIndex])
{
mstrDnPathId = value.ToString();
 AddUpdatedFld(conDnPathFuncMapRela.DnPathId);
}
else if (conDnPathFuncMapRela.DnFuncMapId  ==  _AttributeName[intIndex])
{
mstrDnFuncMapId = value.ToString();
 AddUpdatedFld(conDnPathFuncMapRela.DnFuncMapId);
}
else if (conDnPathFuncMapRela.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conDnPathFuncMapRela.PrjId);
}
else if (conDnPathFuncMapRela.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conDnPathFuncMapRela.UpdDate);
}
else if (conDnPathFuncMapRela.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conDnPathFuncMapRela.UpdUser);
}
else if (conDnPathFuncMapRela.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDnPathFuncMapRela.Memo);
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
 AddUpdatedFld(conDnPathFuncMapRela.mId);
}
}
/// <summary>
/// DN路径Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DnPathId
{
get
{
return mstrDnPathId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDnPathId = value;
}
else
{
 mstrDnPathId = value;
}
//记录修改过的字段
 AddUpdatedFld(conDnPathFuncMapRela.DnPathId);
}
}
/// <summary>
/// 函数映射Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DnFuncMapId
{
get
{
return mstrDnFuncMapId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDnFuncMapId = value;
}
else
{
 mstrDnFuncMapId = value;
}
//记录修改过的字段
 AddUpdatedFld(conDnPathFuncMapRela.DnFuncMapId);
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
 AddUpdatedFld(conDnPathFuncMapRela.PrjId);
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
 AddUpdatedFld(conDnPathFuncMapRela.UpdDate);
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
 AddUpdatedFld(conDnPathFuncMapRela.UpdUser);
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
 AddUpdatedFld(conDnPathFuncMapRela.Memo);
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
 /// Dn路径函数映射关系(DnPathFuncMapRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conDnPathFuncMapRela
{
public const string _CurrTabName = "DnPathFuncMapRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "DnPathId", "DnFuncMapId", "PrjId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"DnPathId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DnPathId = "DnPathId";    //DN路径Id

 /// <summary>
 /// 常量:"DnFuncMapId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DnFuncMapId = "DnFuncMapId";    //函数映射Id

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
}

}