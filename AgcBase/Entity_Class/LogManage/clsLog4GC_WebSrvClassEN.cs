
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsLog4GC_WebSrvClassEN
 表名:Log4GC_WebSrvClass(00050370)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:09:50
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:日志管理(LogManage)
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
 /// 表Log4GC_WebSrvClass的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_Log4GC_WebSrvClass
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
public K_mId_Log4GC_WebSrvClass(long lngmId)
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
 /// <returns>返回:[K_mId_Log4GC_WebSrvClass]类型的对象</returns>
public static implicit operator K_mId_Log4GC_WebSrvClass(long value)
{
return new K_mId_Log4GC_WebSrvClass(value);
}
}
 /// <summary>
 /// 生成WebSrvClass代码日志(Log4GC_WebSrvClass)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsLog4GC_WebSrvClassEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "Log4GC_WebSrvClass"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 6;
public static string[] _AttributeName = new string[] {"mId", "UserId", "WebSrvClassId", "GeneCodeDate", "VersionGeneCode", "Memo"};

protected long mlngmId;    //mId
protected string mstrUserId;    //用户Id
protected string mstrWebSrvClassId;    //类Id
protected string mstrGeneCodeDate;    //生成代码日期
protected string mstrVersionGeneCode;    //生成代码版本
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsLog4GC_WebSrvClassEN()
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
public clsLog4GC_WebSrvClassEN(long lngmId)
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
if (strAttributeName  ==  conLog4GC_WebSrvClass.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conLog4GC_WebSrvClass.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conLog4GC_WebSrvClass.WebSrvClassId)
{
return mstrWebSrvClassId;
}
else if (strAttributeName  ==  conLog4GC_WebSrvClass.GeneCodeDate)
{
return mstrGeneCodeDate;
}
else if (strAttributeName  ==  conLog4GC_WebSrvClass.VersionGeneCode)
{
return mstrVersionGeneCode;
}
else if (strAttributeName  ==  conLog4GC_WebSrvClass.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conLog4GC_WebSrvClass.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conLog4GC_WebSrvClass.mId);
}
else if (strAttributeName  ==  conLog4GC_WebSrvClass.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conLog4GC_WebSrvClass.UserId);
}
else if (strAttributeName  ==  conLog4GC_WebSrvClass.WebSrvClassId)
{
mstrWebSrvClassId = value.ToString();
 AddUpdatedFld(conLog4GC_WebSrvClass.WebSrvClassId);
}
else if (strAttributeName  ==  conLog4GC_WebSrvClass.GeneCodeDate)
{
mstrGeneCodeDate = value.ToString();
 AddUpdatedFld(conLog4GC_WebSrvClass.GeneCodeDate);
}
else if (strAttributeName  ==  conLog4GC_WebSrvClass.VersionGeneCode)
{
mstrVersionGeneCode = value.ToString();
 AddUpdatedFld(conLog4GC_WebSrvClass.VersionGeneCode);
}
else if (strAttributeName  ==  conLog4GC_WebSrvClass.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conLog4GC_WebSrvClass.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conLog4GC_WebSrvClass.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (conLog4GC_WebSrvClass.UserId  ==  _AttributeName[intIndex])
{
return mstrUserId;
}
else if (conLog4GC_WebSrvClass.WebSrvClassId  ==  _AttributeName[intIndex])
{
return mstrWebSrvClassId;
}
else if (conLog4GC_WebSrvClass.GeneCodeDate  ==  _AttributeName[intIndex])
{
return mstrGeneCodeDate;
}
else if (conLog4GC_WebSrvClass.VersionGeneCode  ==  _AttributeName[intIndex])
{
return mstrVersionGeneCode;
}
else if (conLog4GC_WebSrvClass.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conLog4GC_WebSrvClass.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conLog4GC_WebSrvClass.mId);
}
else if (conLog4GC_WebSrvClass.UserId  ==  _AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conLog4GC_WebSrvClass.UserId);
}
else if (conLog4GC_WebSrvClass.WebSrvClassId  ==  _AttributeName[intIndex])
{
mstrWebSrvClassId = value.ToString();
 AddUpdatedFld(conLog4GC_WebSrvClass.WebSrvClassId);
}
else if (conLog4GC_WebSrvClass.GeneCodeDate  ==  _AttributeName[intIndex])
{
mstrGeneCodeDate = value.ToString();
 AddUpdatedFld(conLog4GC_WebSrvClass.GeneCodeDate);
}
else if (conLog4GC_WebSrvClass.VersionGeneCode  ==  _AttributeName[intIndex])
{
mstrVersionGeneCode = value.ToString();
 AddUpdatedFld(conLog4GC_WebSrvClass.VersionGeneCode);
}
else if (conLog4GC_WebSrvClass.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conLog4GC_WebSrvClass.Memo);
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
 AddUpdatedFld(conLog4GC_WebSrvClass.mId);
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
 AddUpdatedFld(conLog4GC_WebSrvClass.UserId);
}
}
/// <summary>
/// 类Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WebSrvClassId
{
get
{
return mstrWebSrvClassId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWebSrvClassId = value;
}
else
{
 mstrWebSrvClassId = value;
}
//记录修改过的字段
 AddUpdatedFld(conLog4GC_WebSrvClass.WebSrvClassId);
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
 AddUpdatedFld(conLog4GC_WebSrvClass.GeneCodeDate);
}
}
/// <summary>
/// 生成代码版本(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VersionGeneCode
{
get
{
return mstrVersionGeneCode;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVersionGeneCode = value;
}
else
{
 mstrVersionGeneCode = value;
}
//记录修改过的字段
 AddUpdatedFld(conLog4GC_WebSrvClass.VersionGeneCode);
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
 AddUpdatedFld(conLog4GC_WebSrvClass.Memo);
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
 /// 生成WebSrvClass代码日志(Log4GC_WebSrvClass)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conLog4GC_WebSrvClass
{
public const string _CurrTabName = "Log4GC_WebSrvClass"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "UserId", "WebSrvClassId", "GeneCodeDate", "VersionGeneCode", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户Id

 /// <summary>
 /// 常量:"WebSrvClassId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WebSrvClassId = "WebSrvClassId";    //类Id

 /// <summary>
 /// 常量:"GeneCodeDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GeneCodeDate = "GeneCodeDate";    //生成代码日期

 /// <summary>
 /// 常量:"VersionGeneCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VersionGeneCode = "VersionGeneCode";    //生成代码版本

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}