
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFuncInOutRelaEN
 表名:vFuncInOutRela(00050408)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:47:58
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
 /// 表vFuncInOutRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vFuncInOutRela
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
public K_mId_vFuncInOutRela(long lngmId)
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
 /// <returns>返回:[K_mId_vFuncInOutRela]类型的对象</returns>
public static implicit operator K_mId_vFuncInOutRela(long value)
{
return new K_mId_vFuncInOutRela(value);
}
}
 /// <summary>
 /// v函数输入输出关系(vFuncInOutRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvFuncInOutRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vFuncInOutRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 12;
public static string[] _AttributeName = new string[] {"mId", "FuncTabId", "TabName", "TabCnName", "InFldIds", "InFldNames", "OutFldIds", "OutFldNames", "GcFuncName", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrFuncTabId;    //功能表Id
protected string mstrTabName;    //表名
protected string mstrTabCnName;    //表中文名
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
 public clsvFuncInOutRelaEN()
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
public clsvFuncInOutRelaEN(long lngmId)
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
if (strAttributeName  ==  convFuncInOutRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convFuncInOutRela.FuncTabId)
{
return mstrFuncTabId;
}
else if (strAttributeName  ==  convFuncInOutRela.TabName)
{
return mstrTabName;
}
else if (strAttributeName  ==  convFuncInOutRela.TabCnName)
{
return mstrTabCnName;
}
else if (strAttributeName  ==  convFuncInOutRela.InFldIds)
{
return mstrInFldIds;
}
else if (strAttributeName  ==  convFuncInOutRela.InFldNames)
{
return mstrInFldNames;
}
else if (strAttributeName  ==  convFuncInOutRela.OutFldIds)
{
return mstrOutFldIds;
}
else if (strAttributeName  ==  convFuncInOutRela.OutFldNames)
{
return mstrOutFldNames;
}
else if (strAttributeName  ==  convFuncInOutRela.GcFuncName)
{
return mstrGcFuncName;
}
else if (strAttributeName  ==  convFuncInOutRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convFuncInOutRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convFuncInOutRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convFuncInOutRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convFuncInOutRela.mId);
}
else if (strAttributeName  ==  convFuncInOutRela.FuncTabId)
{
mstrFuncTabId = value.ToString();
 AddUpdatedFld(convFuncInOutRela.FuncTabId);
}
else if (strAttributeName  ==  convFuncInOutRela.TabName)
{
mstrTabName = value.ToString();
 AddUpdatedFld(convFuncInOutRela.TabName);
}
else if (strAttributeName  ==  convFuncInOutRela.TabCnName)
{
mstrTabCnName = value.ToString();
 AddUpdatedFld(convFuncInOutRela.TabCnName);
}
else if (strAttributeName  ==  convFuncInOutRela.InFldIds)
{
mstrInFldIds = value.ToString();
 AddUpdatedFld(convFuncInOutRela.InFldIds);
}
else if (strAttributeName  ==  convFuncInOutRela.InFldNames)
{
mstrInFldNames = value.ToString();
 AddUpdatedFld(convFuncInOutRela.InFldNames);
}
else if (strAttributeName  ==  convFuncInOutRela.OutFldIds)
{
mstrOutFldIds = value.ToString();
 AddUpdatedFld(convFuncInOutRela.OutFldIds);
}
else if (strAttributeName  ==  convFuncInOutRela.OutFldNames)
{
mstrOutFldNames = value.ToString();
 AddUpdatedFld(convFuncInOutRela.OutFldNames);
}
else if (strAttributeName  ==  convFuncInOutRela.GcFuncName)
{
mstrGcFuncName = value.ToString();
 AddUpdatedFld(convFuncInOutRela.GcFuncName);
}
else if (strAttributeName  ==  convFuncInOutRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFuncInOutRela.UpdDate);
}
else if (strAttributeName  ==  convFuncInOutRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFuncInOutRela.UpdUser);
}
else if (strAttributeName  ==  convFuncInOutRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFuncInOutRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convFuncInOutRela.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (convFuncInOutRela.FuncTabId  ==  _AttributeName[intIndex])
{
return mstrFuncTabId;
}
else if (convFuncInOutRela.TabName  ==  _AttributeName[intIndex])
{
return mstrTabName;
}
else if (convFuncInOutRela.TabCnName  ==  _AttributeName[intIndex])
{
return mstrTabCnName;
}
else if (convFuncInOutRela.InFldIds  ==  _AttributeName[intIndex])
{
return mstrInFldIds;
}
else if (convFuncInOutRela.InFldNames  ==  _AttributeName[intIndex])
{
return mstrInFldNames;
}
else if (convFuncInOutRela.OutFldIds  ==  _AttributeName[intIndex])
{
return mstrOutFldIds;
}
else if (convFuncInOutRela.OutFldNames  ==  _AttributeName[intIndex])
{
return mstrOutFldNames;
}
else if (convFuncInOutRela.GcFuncName  ==  _AttributeName[intIndex])
{
return mstrGcFuncName;
}
else if (convFuncInOutRela.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convFuncInOutRela.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convFuncInOutRela.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convFuncInOutRela.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convFuncInOutRela.mId);
}
else if (convFuncInOutRela.FuncTabId  ==  _AttributeName[intIndex])
{
mstrFuncTabId = value.ToString();
 AddUpdatedFld(convFuncInOutRela.FuncTabId);
}
else if (convFuncInOutRela.TabName  ==  _AttributeName[intIndex])
{
mstrTabName = value.ToString();
 AddUpdatedFld(convFuncInOutRela.TabName);
}
else if (convFuncInOutRela.TabCnName  ==  _AttributeName[intIndex])
{
mstrTabCnName = value.ToString();
 AddUpdatedFld(convFuncInOutRela.TabCnName);
}
else if (convFuncInOutRela.InFldIds  ==  _AttributeName[intIndex])
{
mstrInFldIds = value.ToString();
 AddUpdatedFld(convFuncInOutRela.InFldIds);
}
else if (convFuncInOutRela.InFldNames  ==  _AttributeName[intIndex])
{
mstrInFldNames = value.ToString();
 AddUpdatedFld(convFuncInOutRela.InFldNames);
}
else if (convFuncInOutRela.OutFldIds  ==  _AttributeName[intIndex])
{
mstrOutFldIds = value.ToString();
 AddUpdatedFld(convFuncInOutRela.OutFldIds);
}
else if (convFuncInOutRela.OutFldNames  ==  _AttributeName[intIndex])
{
mstrOutFldNames = value.ToString();
 AddUpdatedFld(convFuncInOutRela.OutFldNames);
}
else if (convFuncInOutRela.GcFuncName  ==  _AttributeName[intIndex])
{
mstrGcFuncName = value.ToString();
 AddUpdatedFld(convFuncInOutRela.GcFuncName);
}
else if (convFuncInOutRela.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFuncInOutRela.UpdDate);
}
else if (convFuncInOutRela.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFuncInOutRela.UpdUser);
}
else if (convFuncInOutRela.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFuncInOutRela.Memo);
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
 AddUpdatedFld(convFuncInOutRela.mId);
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
 AddUpdatedFld(convFuncInOutRela.FuncTabId);
}
}
/// <summary>
/// 表名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabName
{
get
{
return mstrTabName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabName = value;
}
else
{
 mstrTabName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFuncInOutRela.TabName);
}
}
/// <summary>
/// 表中文名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabCnName
{
get
{
return mstrTabCnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabCnName = value;
}
else
{
 mstrTabCnName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFuncInOutRela.TabCnName);
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
 AddUpdatedFld(convFuncInOutRela.InFldIds);
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
 AddUpdatedFld(convFuncInOutRela.InFldNames);
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
 AddUpdatedFld(convFuncInOutRela.OutFldIds);
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
 AddUpdatedFld(convFuncInOutRela.OutFldNames);
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
 AddUpdatedFld(convFuncInOutRela.GcFuncName);
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
 AddUpdatedFld(convFuncInOutRela.UpdDate);
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
 AddUpdatedFld(convFuncInOutRela.UpdUser);
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
 AddUpdatedFld(convFuncInOutRela.Memo);
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
 /// v函数输入输出关系(vFuncInOutRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convFuncInOutRela
{
public const string _CurrTabName = "vFuncInOutRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "FuncTabId", "TabName", "TabCnName", "InFldIds", "InFldNames", "OutFldIds", "OutFldNames", "GcFuncName", "UpdDate", "UpdUser", "Memo"};
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
 /// 常量:"TabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabName = "TabName";    //表名

 /// <summary>
 /// 常量:"TabCnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabCnName = "TabCnName";    //表中文名

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