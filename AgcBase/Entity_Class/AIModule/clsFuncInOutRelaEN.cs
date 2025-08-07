
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFuncInOutRelaEN
 表名:FuncInOutRela(00050407)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:34:56
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
 /// 表FuncInOutRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_FuncInOutRela
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
public K_mId_FuncInOutRela(long lngmId)
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
 /// <returns>返回:[K_mId_FuncInOutRela]类型的对象</returns>
public static implicit operator K_mId_FuncInOutRela(long value)
{
return new K_mId_FuncInOutRela(value);
}
}
 /// <summary>
 /// 函数输入输出关系(FuncInOutRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsFuncInOutRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "FuncInOutRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 10;
public static string[] _AttributeName = new string[] {"mId", "FuncTabId", "InFldIds", "InFldNames", "OutFldIds", "OutFldNames", "GcFuncName", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrFuncTabId;    //功能表Id
protected string mstrInFldIds;    //输入字段Ids
protected string mstrInFldNames;    //输入字段名s
protected string mstrOutFldIds;    //输出字段Ids
protected string mstrOutFldNames;    //输出字段名s
protected string mstrGcFuncName;    //GC函数名
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsFuncInOutRelaEN()
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
public clsFuncInOutRelaEN(long lngmId)
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
if (strAttributeName  ==  conFuncInOutRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conFuncInOutRela.FuncTabId)
{
return mstrFuncTabId;
}
else if (strAttributeName  ==  conFuncInOutRela.InFldIds)
{
return mstrInFldIds;
}
else if (strAttributeName  ==  conFuncInOutRela.InFldNames)
{
return mstrInFldNames;
}
else if (strAttributeName  ==  conFuncInOutRela.OutFldIds)
{
return mstrOutFldIds;
}
else if (strAttributeName  ==  conFuncInOutRela.OutFldNames)
{
return mstrOutFldNames;
}
else if (strAttributeName  ==  conFuncInOutRela.GcFuncName)
{
return mstrGcFuncName;
}
else if (strAttributeName  ==  conFuncInOutRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conFuncInOutRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conFuncInOutRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conFuncInOutRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conFuncInOutRela.mId);
}
else if (strAttributeName  ==  conFuncInOutRela.FuncTabId)
{
mstrFuncTabId = value.ToString();
 AddUpdatedFld(conFuncInOutRela.FuncTabId);
}
else if (strAttributeName  ==  conFuncInOutRela.InFldIds)
{
mstrInFldIds = value.ToString();
 AddUpdatedFld(conFuncInOutRela.InFldIds);
}
else if (strAttributeName  ==  conFuncInOutRela.InFldNames)
{
mstrInFldNames = value.ToString();
 AddUpdatedFld(conFuncInOutRela.InFldNames);
}
else if (strAttributeName  ==  conFuncInOutRela.OutFldIds)
{
mstrOutFldIds = value.ToString();
 AddUpdatedFld(conFuncInOutRela.OutFldIds);
}
else if (strAttributeName  ==  conFuncInOutRela.OutFldNames)
{
mstrOutFldNames = value.ToString();
 AddUpdatedFld(conFuncInOutRela.OutFldNames);
}
else if (strAttributeName  ==  conFuncInOutRela.GcFuncName)
{
mstrGcFuncName = value.ToString();
 AddUpdatedFld(conFuncInOutRela.GcFuncName);
}
else if (strAttributeName  ==  conFuncInOutRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFuncInOutRela.UpdDate);
}
else if (strAttributeName  ==  conFuncInOutRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conFuncInOutRela.UpdUser);
}
else if (strAttributeName  ==  conFuncInOutRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFuncInOutRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conFuncInOutRela.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (conFuncInOutRela.FuncTabId  ==  _AttributeName[intIndex])
{
return mstrFuncTabId;
}
else if (conFuncInOutRela.InFldIds  ==  _AttributeName[intIndex])
{
return mstrInFldIds;
}
else if (conFuncInOutRela.InFldNames  ==  _AttributeName[intIndex])
{
return mstrInFldNames;
}
else if (conFuncInOutRela.OutFldIds  ==  _AttributeName[intIndex])
{
return mstrOutFldIds;
}
else if (conFuncInOutRela.OutFldNames  ==  _AttributeName[intIndex])
{
return mstrOutFldNames;
}
else if (conFuncInOutRela.GcFuncName  ==  _AttributeName[intIndex])
{
return mstrGcFuncName;
}
else if (conFuncInOutRela.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conFuncInOutRela.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conFuncInOutRela.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conFuncInOutRela.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conFuncInOutRela.mId);
}
else if (conFuncInOutRela.FuncTabId  ==  _AttributeName[intIndex])
{
mstrFuncTabId = value.ToString();
 AddUpdatedFld(conFuncInOutRela.FuncTabId);
}
else if (conFuncInOutRela.InFldIds  ==  _AttributeName[intIndex])
{
mstrInFldIds = value.ToString();
 AddUpdatedFld(conFuncInOutRela.InFldIds);
}
else if (conFuncInOutRela.InFldNames  ==  _AttributeName[intIndex])
{
mstrInFldNames = value.ToString();
 AddUpdatedFld(conFuncInOutRela.InFldNames);
}
else if (conFuncInOutRela.OutFldIds  ==  _AttributeName[intIndex])
{
mstrOutFldIds = value.ToString();
 AddUpdatedFld(conFuncInOutRela.OutFldIds);
}
else if (conFuncInOutRela.OutFldNames  ==  _AttributeName[intIndex])
{
mstrOutFldNames = value.ToString();
 AddUpdatedFld(conFuncInOutRela.OutFldNames);
}
else if (conFuncInOutRela.GcFuncName  ==  _AttributeName[intIndex])
{
mstrGcFuncName = value.ToString();
 AddUpdatedFld(conFuncInOutRela.GcFuncName);
}
else if (conFuncInOutRela.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFuncInOutRela.UpdDate);
}
else if (conFuncInOutRela.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conFuncInOutRela.UpdUser);
}
else if (conFuncInOutRela.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFuncInOutRela.Memo);
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
 AddUpdatedFld(conFuncInOutRela.mId);
}
}
/// <summary>
/// 功能表Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncTabId
{
get
{
return mstrFuncTabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncTabId = value;
}
else
{
 mstrFuncTabId = value;
}
//记录修改过的字段
 AddUpdatedFld(conFuncInOutRela.FuncTabId);
}
}
/// <summary>
/// 输入字段Ids(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string InFldIds
{
get
{
return mstrInFldIds;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrInFldIds = value;
}
else
{
 mstrInFldIds = value;
}
//记录修改过的字段
 AddUpdatedFld(conFuncInOutRela.InFldIds);
}
}
/// <summary>
/// 输入字段名s(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string InFldNames
{
get
{
return mstrInFldNames;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrInFldNames = value;
}
else
{
 mstrInFldNames = value;
}
//记录修改过的字段
 AddUpdatedFld(conFuncInOutRela.InFldNames);
}
}
/// <summary>
/// 输出字段Ids(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OutFldIds
{
get
{
return mstrOutFldIds;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOutFldIds = value;
}
else
{
 mstrOutFldIds = value;
}
//记录修改过的字段
 AddUpdatedFld(conFuncInOutRela.OutFldIds);
}
}
/// <summary>
/// 输出字段名s(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OutFldNames
{
get
{
return mstrOutFldNames;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOutFldNames = value;
}
else
{
 mstrOutFldNames = value;
}
//记录修改过的字段
 AddUpdatedFld(conFuncInOutRela.OutFldNames);
}
}
/// <summary>
/// GC函数名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GcFuncName
{
get
{
return mstrGcFuncName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGcFuncName = value;
}
else
{
 mstrGcFuncName = value;
}
//记录修改过的字段
 AddUpdatedFld(conFuncInOutRela.GcFuncName);
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
 AddUpdatedFld(conFuncInOutRela.UpdDate);
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
 AddUpdatedFld(conFuncInOutRela.UpdUser);
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
 AddUpdatedFld(conFuncInOutRela.Memo);
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
 /// 函数输入输出关系(FuncInOutRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conFuncInOutRela
{
public const string _CurrTabName = "FuncInOutRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "FuncTabId", "InFldIds", "InFldNames", "OutFldIds", "OutFldNames", "GcFuncName", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"FuncTabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncTabId = "FuncTabId";    //功能表Id

 /// <summary>
 /// 常量:"InFldIds"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InFldIds = "InFldIds";    //输入字段Ids

 /// <summary>
 /// 常量:"InFldNames"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InFldNames = "InFldNames";    //输入字段名s

 /// <summary>
 /// 常量:"OutFldIds"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OutFldIds = "OutFldIds";    //输出字段Ids

 /// <summary>
 /// 常量:"OutFldNames"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OutFldNames = "OutFldNames";    //输出字段名s

 /// <summary>
 /// 常量:"GcFuncName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GcFuncName = "GcFuncName";    //GC函数名

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