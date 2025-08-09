
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsLog4CreateView4SqlEN
 表名:Log4CreateView4Sql(00050294)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:06:39
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
 /// 表Log4CreateView4Sql的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_Log4CreateView4Sql
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
public K_mId_Log4CreateView4Sql(long lngmId)
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
 /// <returns>返回:[K_mId_Log4CreateView4Sql]类型的对象</returns>
public static implicit operator K_mId_Log4CreateView4Sql(long value)
{
return new K_mId_Log4CreateView4Sql(value);
}
}
 /// <summary>
 /// 建立视图日志(Log4CreateView4Sql)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsLog4CreateView4SqlEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "Log4CreateView4Sql"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 7;
public static string[] _AttributeName = new string[] {"mId", "SqlViewId", "PrjDataBaseId", "CreateViewDate", "PrjId", "UserId", "Memo"};

protected long mlngmId;    //mId
protected string mstrSqlViewId;    //Sql视图Id
protected string mstrPrjDataBaseId;    //项目数据库Id
protected string mstrCreateViewDate;    //建立视图日期
protected string mstrPrjId;    //工程Id
protected string mstrUserId;    //用户Id
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsLog4CreateView4SqlEN()
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
public clsLog4CreateView4SqlEN(long lngmId)
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
if (strAttributeName  ==  conLog4CreateView4Sql.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conLog4CreateView4Sql.SqlViewId)
{
return mstrSqlViewId;
}
else if (strAttributeName  ==  conLog4CreateView4Sql.PrjDataBaseId)
{
return mstrPrjDataBaseId;
}
else if (strAttributeName  ==  conLog4CreateView4Sql.CreateViewDate)
{
return mstrCreateViewDate;
}
else if (strAttributeName  ==  conLog4CreateView4Sql.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conLog4CreateView4Sql.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conLog4CreateView4Sql.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conLog4CreateView4Sql.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conLog4CreateView4Sql.mId);
}
else if (strAttributeName  ==  conLog4CreateView4Sql.SqlViewId)
{
mstrSqlViewId = value.ToString();
 AddUpdatedFld(conLog4CreateView4Sql.SqlViewId);
}
else if (strAttributeName  ==  conLog4CreateView4Sql.PrjDataBaseId)
{
mstrPrjDataBaseId = value.ToString();
 AddUpdatedFld(conLog4CreateView4Sql.PrjDataBaseId);
}
else if (strAttributeName  ==  conLog4CreateView4Sql.CreateViewDate)
{
mstrCreateViewDate = value.ToString();
 AddUpdatedFld(conLog4CreateView4Sql.CreateViewDate);
}
else if (strAttributeName  ==  conLog4CreateView4Sql.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conLog4CreateView4Sql.PrjId);
}
else if (strAttributeName  ==  conLog4CreateView4Sql.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conLog4CreateView4Sql.UserId);
}
else if (strAttributeName  ==  conLog4CreateView4Sql.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conLog4CreateView4Sql.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conLog4CreateView4Sql.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (conLog4CreateView4Sql.SqlViewId  ==  _AttributeName[intIndex])
{
return mstrSqlViewId;
}
else if (conLog4CreateView4Sql.PrjDataBaseId  ==  _AttributeName[intIndex])
{
return mstrPrjDataBaseId;
}
else if (conLog4CreateView4Sql.CreateViewDate  ==  _AttributeName[intIndex])
{
return mstrCreateViewDate;
}
else if (conLog4CreateView4Sql.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conLog4CreateView4Sql.UserId  ==  _AttributeName[intIndex])
{
return mstrUserId;
}
else if (conLog4CreateView4Sql.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conLog4CreateView4Sql.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conLog4CreateView4Sql.mId);
}
else if (conLog4CreateView4Sql.SqlViewId  ==  _AttributeName[intIndex])
{
mstrSqlViewId = value.ToString();
 AddUpdatedFld(conLog4CreateView4Sql.SqlViewId);
}
else if (conLog4CreateView4Sql.PrjDataBaseId  ==  _AttributeName[intIndex])
{
mstrPrjDataBaseId = value.ToString();
 AddUpdatedFld(conLog4CreateView4Sql.PrjDataBaseId);
}
else if (conLog4CreateView4Sql.CreateViewDate  ==  _AttributeName[intIndex])
{
mstrCreateViewDate = value.ToString();
 AddUpdatedFld(conLog4CreateView4Sql.CreateViewDate);
}
else if (conLog4CreateView4Sql.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conLog4CreateView4Sql.PrjId);
}
else if (conLog4CreateView4Sql.UserId  ==  _AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conLog4CreateView4Sql.UserId);
}
else if (conLog4CreateView4Sql.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conLog4CreateView4Sql.Memo);
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
 AddUpdatedFld(conLog4CreateView4Sql.mId);
}
}
/// <summary>
/// Sql视图Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SqlViewId
{
get
{
return mstrSqlViewId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSqlViewId = value;
}
else
{
 mstrSqlViewId = value;
}
//记录修改过的字段
 AddUpdatedFld(conLog4CreateView4Sql.SqlViewId);
}
}
/// <summary>
/// 项目数据库Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjDataBaseId
{
get
{
return mstrPrjDataBaseId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjDataBaseId = value;
}
else
{
 mstrPrjDataBaseId = value;
}
//记录修改过的字段
 AddUpdatedFld(conLog4CreateView4Sql.PrjDataBaseId);
}
}
/// <summary>
/// 建立视图日期(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CreateViewDate
{
get
{
return mstrCreateViewDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCreateViewDate = value;
}
else
{
 mstrCreateViewDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conLog4CreateView4Sql.CreateViewDate);
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
 AddUpdatedFld(conLog4CreateView4Sql.PrjId);
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
 AddUpdatedFld(conLog4CreateView4Sql.UserId);
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
 AddUpdatedFld(conLog4CreateView4Sql.Memo);
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
 /// 建立视图日志(Log4CreateView4Sql)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conLog4CreateView4Sql
{
public const string _CurrTabName = "Log4CreateView4Sql"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "SqlViewId", "PrjDataBaseId", "CreateViewDate", "PrjId", "UserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"SqlViewId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SqlViewId = "SqlViewId";    //Sql视图Id

 /// <summary>
 /// 常量:"PrjDataBaseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjDataBaseId = "PrjDataBaseId";    //项目数据库Id

 /// <summary>
 /// 常量:"CreateViewDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreateViewDate = "CreateViewDate";    //建立视图日期

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}