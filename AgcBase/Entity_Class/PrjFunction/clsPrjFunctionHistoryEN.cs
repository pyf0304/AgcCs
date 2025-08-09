
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjFunctionHistoryEN
 表名:PrjFunctionHistory(00050109)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:10:50
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
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
 /// 表PrjFunctionHistory的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_PrjFunctionHistory
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
public K_mId_PrjFunctionHistory(long lngmId)
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
 /// <returns>返回:[K_mId_PrjFunctionHistory]类型的对象</returns>
public static implicit operator K_mId_PrjFunctionHistory(long value)
{
return new K_mId_PrjFunctionHistory(value);
}
}
 /// <summary>
 /// 工程函数历史(PrjFunctionHistory)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsPrjFunctionHistoryEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "PrjFunctionHistory"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 9;
public static string[] _AttributeName = new string[] {"mId", "FuncId", "PrjId", "Updator", "UpdDate", "UpdTime", "UserId", "FuncCode", "Memo"};

protected long mlngmId;    //mId
protected string mstrFuncId;    //函数ID
protected string mstrPrjId;    //工程Id
protected string mstrUpdator;    //修改者
protected string mstrUpdDate;    //修改日期
protected string mstrUpdTime;    //修改时间
protected string mstrUserId;    //用户Id
protected string mstrFuncCode;    //函数代码
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsPrjFunctionHistoryEN()
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
public clsPrjFunctionHistoryEN(long lngmId)
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
if (strAttributeName  ==  conPrjFunctionHistory.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conPrjFunctionHistory.FuncId)
{
return mstrFuncId;
}
else if (strAttributeName  ==  conPrjFunctionHistory.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conPrjFunctionHistory.Updator)
{
return mstrUpdator;
}
else if (strAttributeName  ==  conPrjFunctionHistory.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conPrjFunctionHistory.UpdTime)
{
return mstrUpdTime;
}
else if (strAttributeName  ==  conPrjFunctionHistory.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conPrjFunctionHistory.FuncCode)
{
return mstrFuncCode;
}
else if (strAttributeName  ==  conPrjFunctionHistory.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conPrjFunctionHistory.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conPrjFunctionHistory.mId);
}
else if (strAttributeName  ==  conPrjFunctionHistory.FuncId)
{
mstrFuncId = value.ToString();
 AddUpdatedFld(conPrjFunctionHistory.FuncId);
}
else if (strAttributeName  ==  conPrjFunctionHistory.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conPrjFunctionHistory.PrjId);
}
else if (strAttributeName  ==  conPrjFunctionHistory.Updator)
{
mstrUpdator = value.ToString();
 AddUpdatedFld(conPrjFunctionHistory.Updator);
}
else if (strAttributeName  ==  conPrjFunctionHistory.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conPrjFunctionHistory.UpdDate);
}
else if (strAttributeName  ==  conPrjFunctionHistory.UpdTime)
{
mstrUpdTime = value.ToString();
 AddUpdatedFld(conPrjFunctionHistory.UpdTime);
}
else if (strAttributeName  ==  conPrjFunctionHistory.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conPrjFunctionHistory.UserId);
}
else if (strAttributeName  ==  conPrjFunctionHistory.FuncCode)
{
mstrFuncCode = value.ToString();
 AddUpdatedFld(conPrjFunctionHistory.FuncCode);
}
else if (strAttributeName  ==  conPrjFunctionHistory.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPrjFunctionHistory.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conPrjFunctionHistory.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (conPrjFunctionHistory.FuncId  ==  _AttributeName[intIndex])
{
return mstrFuncId;
}
else if (conPrjFunctionHistory.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conPrjFunctionHistory.Updator  ==  _AttributeName[intIndex])
{
return mstrUpdator;
}
else if (conPrjFunctionHistory.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conPrjFunctionHistory.UpdTime  ==  _AttributeName[intIndex])
{
return mstrUpdTime;
}
else if (conPrjFunctionHistory.UserId  ==  _AttributeName[intIndex])
{
return mstrUserId;
}
else if (conPrjFunctionHistory.FuncCode  ==  _AttributeName[intIndex])
{
return mstrFuncCode;
}
else if (conPrjFunctionHistory.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conPrjFunctionHistory.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conPrjFunctionHistory.mId);
}
else if (conPrjFunctionHistory.FuncId  ==  _AttributeName[intIndex])
{
mstrFuncId = value.ToString();
 AddUpdatedFld(conPrjFunctionHistory.FuncId);
}
else if (conPrjFunctionHistory.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conPrjFunctionHistory.PrjId);
}
else if (conPrjFunctionHistory.Updator  ==  _AttributeName[intIndex])
{
mstrUpdator = value.ToString();
 AddUpdatedFld(conPrjFunctionHistory.Updator);
}
else if (conPrjFunctionHistory.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conPrjFunctionHistory.UpdDate);
}
else if (conPrjFunctionHistory.UpdTime  ==  _AttributeName[intIndex])
{
mstrUpdTime = value.ToString();
 AddUpdatedFld(conPrjFunctionHistory.UpdTime);
}
else if (conPrjFunctionHistory.UserId  ==  _AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conPrjFunctionHistory.UserId);
}
else if (conPrjFunctionHistory.FuncCode  ==  _AttributeName[intIndex])
{
mstrFuncCode = value.ToString();
 AddUpdatedFld(conPrjFunctionHistory.FuncCode);
}
else if (conPrjFunctionHistory.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPrjFunctionHistory.Memo);
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
 AddUpdatedFld(conPrjFunctionHistory.mId);
}
}
/// <summary>
/// 函数ID(说明:;字段类型:varchar;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncId
{
get
{
return mstrFuncId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncId = value;
}
else
{
 mstrFuncId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjFunctionHistory.FuncId);
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
 AddUpdatedFld(conPrjFunctionHistory.PrjId);
}
}
/// <summary>
/// 修改者(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Updator
{
get
{
return mstrUpdator;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdator = value;
}
else
{
 mstrUpdator = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjFunctionHistory.Updator);
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
 AddUpdatedFld(conPrjFunctionHistory.UpdDate);
}
}
/// <summary>
/// 修改时间(说明:;字段类型:varchar;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdTime
{
get
{
return mstrUpdTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdTime = value;
}
else
{
 mstrUpdTime = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjFunctionHistory.UpdTime);
}
}
/// <summary>
/// 用户Id(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserId
{
get
{
return mstrUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserId = value;
}
else
{
 mstrUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjFunctionHistory.UserId);
}
}
/// <summary>
/// 函数代码(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncCode
{
get
{
return mstrFuncCode;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncCode = value;
}
else
{
 mstrFuncCode = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjFunctionHistory.FuncCode);
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
 AddUpdatedFld(conPrjFunctionHistory.Memo);
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
 /// 工程函数历史(PrjFunctionHistory)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conPrjFunctionHistory
{
public const string _CurrTabName = "PrjFunctionHistory"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "FuncId", "PrjId", "Updator", "UpdDate", "UpdTime", "UserId", "FuncCode", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"FuncId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncId = "FuncId";    //函数ID

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"Updator"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Updator = "Updator";    //修改者

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdTime = "UpdTime";    //修改时间

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户Id

 /// <summary>
 /// 常量:"FuncCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncCode = "FuncCode";    //函数代码

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}