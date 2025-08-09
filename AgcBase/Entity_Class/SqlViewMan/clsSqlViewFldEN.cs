
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSqlViewFldEN
 表名:SqlViewFld(00050249)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:05:23
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:Sql视图管理(SqlViewMan)
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
 /// 表SqlViewFld的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_SqlViewFld
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
public K_mId_SqlViewFld(long lngmId)
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
 /// <returns>返回:[K_mId_SqlViewFld]类型的对象</returns>
public static implicit operator K_mId_SqlViewFld(long value)
{
return new K_mId_SqlViewFld(value);
}
}
 /// <summary>
 /// Sql视图字段(SqlViewFld)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsSqlViewFldEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "SqlViewFld"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 13;
public static string[] _AttributeName = new string[] {"mId", "SqlViewId", "RelaTabId", "FldId", "FldExpression", "FldExpressionType", "FieldAliases", "Filters", "OrderNum", "PrjId", "UpdDate", "UpdUserId", "Memo"};

protected long mlngmId;    //mId
protected string mstrSqlViewId;    //Sql视图Id
protected string mstrRelaTabId;    //相关表Id
protected string mstrFldId;    //字段Id
protected string mstrFldExpression;    //字段表达式
protected string mstrFldExpressionType;    //FldExpressionType
protected string mstrFieldAliases;    //字段别名
protected string mstrFilters;    //筛选器
protected int mintOrderNum;    //序号
protected string mstrPrjId;    //工程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsSqlViewFldEN()
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
public clsSqlViewFldEN(long lngmId)
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
if (strAttributeName  ==  conSqlViewFld.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conSqlViewFld.SqlViewId)
{
return mstrSqlViewId;
}
else if (strAttributeName  ==  conSqlViewFld.RelaTabId)
{
return mstrRelaTabId;
}
else if (strAttributeName  ==  conSqlViewFld.FldId)
{
return mstrFldId;
}
else if (strAttributeName  ==  conSqlViewFld.FldExpression)
{
return mstrFldExpression;
}
else if (strAttributeName  ==  conSqlViewFld.FldExpressionType)
{
return mstrFldExpressionType;
}
else if (strAttributeName  ==  conSqlViewFld.FieldAliases)
{
return mstrFieldAliases;
}
else if (strAttributeName  ==  conSqlViewFld.Filters)
{
return mstrFilters;
}
else if (strAttributeName  ==  conSqlViewFld.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conSqlViewFld.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conSqlViewFld.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conSqlViewFld.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conSqlViewFld.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conSqlViewFld.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conSqlViewFld.mId);
}
else if (strAttributeName  ==  conSqlViewFld.SqlViewId)
{
mstrSqlViewId = value.ToString();
 AddUpdatedFld(conSqlViewFld.SqlViewId);
}
else if (strAttributeName  ==  conSqlViewFld.RelaTabId)
{
mstrRelaTabId = value.ToString();
 AddUpdatedFld(conSqlViewFld.RelaTabId);
}
else if (strAttributeName  ==  conSqlViewFld.FldId)
{
mstrFldId = value.ToString();
 AddUpdatedFld(conSqlViewFld.FldId);
}
else if (strAttributeName  ==  conSqlViewFld.FldExpression)
{
mstrFldExpression = value.ToString();
 AddUpdatedFld(conSqlViewFld.FldExpression);
}
else if (strAttributeName  ==  conSqlViewFld.FldExpressionType)
{
mstrFldExpressionType = value.ToString();
 AddUpdatedFld(conSqlViewFld.FldExpressionType);
}
else if (strAttributeName  ==  conSqlViewFld.FieldAliases)
{
mstrFieldAliases = value.ToString();
 AddUpdatedFld(conSqlViewFld.FieldAliases);
}
else if (strAttributeName  ==  conSqlViewFld.Filters)
{
mstrFilters = value.ToString();
 AddUpdatedFld(conSqlViewFld.Filters);
}
else if (strAttributeName  ==  conSqlViewFld.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conSqlViewFld.OrderNum);
}
else if (strAttributeName  ==  conSqlViewFld.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conSqlViewFld.PrjId);
}
else if (strAttributeName  ==  conSqlViewFld.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conSqlViewFld.UpdDate);
}
else if (strAttributeName  ==  conSqlViewFld.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conSqlViewFld.UpdUserId);
}
else if (strAttributeName  ==  conSqlViewFld.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSqlViewFld.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conSqlViewFld.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (conSqlViewFld.SqlViewId  ==  _AttributeName[intIndex])
{
return mstrSqlViewId;
}
else if (conSqlViewFld.RelaTabId  ==  _AttributeName[intIndex])
{
return mstrRelaTabId;
}
else if (conSqlViewFld.FldId  ==  _AttributeName[intIndex])
{
return mstrFldId;
}
else if (conSqlViewFld.FldExpression  ==  _AttributeName[intIndex])
{
return mstrFldExpression;
}
else if (conSqlViewFld.FldExpressionType  ==  _AttributeName[intIndex])
{
return mstrFldExpressionType;
}
else if (conSqlViewFld.FieldAliases  ==  _AttributeName[intIndex])
{
return mstrFieldAliases;
}
else if (conSqlViewFld.Filters  ==  _AttributeName[intIndex])
{
return mstrFilters;
}
else if (conSqlViewFld.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conSqlViewFld.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conSqlViewFld.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conSqlViewFld.UpdUserId  ==  _AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conSqlViewFld.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conSqlViewFld.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conSqlViewFld.mId);
}
else if (conSqlViewFld.SqlViewId  ==  _AttributeName[intIndex])
{
mstrSqlViewId = value.ToString();
 AddUpdatedFld(conSqlViewFld.SqlViewId);
}
else if (conSqlViewFld.RelaTabId  ==  _AttributeName[intIndex])
{
mstrRelaTabId = value.ToString();
 AddUpdatedFld(conSqlViewFld.RelaTabId);
}
else if (conSqlViewFld.FldId  ==  _AttributeName[intIndex])
{
mstrFldId = value.ToString();
 AddUpdatedFld(conSqlViewFld.FldId);
}
else if (conSqlViewFld.FldExpression  ==  _AttributeName[intIndex])
{
mstrFldExpression = value.ToString();
 AddUpdatedFld(conSqlViewFld.FldExpression);
}
else if (conSqlViewFld.FldExpressionType  ==  _AttributeName[intIndex])
{
mstrFldExpressionType = value.ToString();
 AddUpdatedFld(conSqlViewFld.FldExpressionType);
}
else if (conSqlViewFld.FieldAliases  ==  _AttributeName[intIndex])
{
mstrFieldAliases = value.ToString();
 AddUpdatedFld(conSqlViewFld.FieldAliases);
}
else if (conSqlViewFld.Filters  ==  _AttributeName[intIndex])
{
mstrFilters = value.ToString();
 AddUpdatedFld(conSqlViewFld.Filters);
}
else if (conSqlViewFld.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conSqlViewFld.OrderNum);
}
else if (conSqlViewFld.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conSqlViewFld.PrjId);
}
else if (conSqlViewFld.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conSqlViewFld.UpdDate);
}
else if (conSqlViewFld.UpdUserId  ==  _AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conSqlViewFld.UpdUserId);
}
else if (conSqlViewFld.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSqlViewFld.Memo);
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
 AddUpdatedFld(conSqlViewFld.mId);
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
 AddUpdatedFld(conSqlViewFld.SqlViewId);
}
}
/// <summary>
/// 相关表Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RelaTabId
{
get
{
return mstrRelaTabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRelaTabId = value;
}
else
{
 mstrRelaTabId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSqlViewFld.RelaTabId);
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
 AddUpdatedFld(conSqlViewFld.FldId);
}
}
/// <summary>
/// 字段表达式(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FldExpression
{
get
{
return mstrFldExpression;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldExpression = value;
}
else
{
 mstrFldExpression = value;
}
//记录修改过的字段
 AddUpdatedFld(conSqlViewFld.FldExpression);
}
}
/// <summary>
/// FldExpressionType(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FldExpressionType
{
get
{
return mstrFldExpressionType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldExpressionType = value;
}
else
{
 mstrFldExpressionType = value;
}
//记录修改过的字段
 AddUpdatedFld(conSqlViewFld.FldExpressionType);
}
}
/// <summary>
/// 字段别名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FieldAliases
{
get
{
return mstrFieldAliases;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFieldAliases = value;
}
else
{
 mstrFieldAliases = value;
}
//记录修改过的字段
 AddUpdatedFld(conSqlViewFld.FieldAliases);
}
}
/// <summary>
/// 筛选器(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Filters
{
get
{
return mstrFilters;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFilters = value;
}
else
{
 mstrFilters = value;
}
//记录修改过的字段
 AddUpdatedFld(conSqlViewFld.Filters);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(conSqlViewFld.OrderNum);
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
 AddUpdatedFld(conSqlViewFld.PrjId);
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
 AddUpdatedFld(conSqlViewFld.UpdDate);
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
 AddUpdatedFld(conSqlViewFld.UpdUserId);
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
 AddUpdatedFld(conSqlViewFld.Memo);
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
 /// Sql视图字段(SqlViewFld)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conSqlViewFld
{
public const string _CurrTabName = "SqlViewFld"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "SqlViewId", "RelaTabId", "FldId", "FldExpression", "FldExpressionType", "FieldAliases", "Filters", "OrderNum", "PrjId", "UpdDate", "UpdUserId", "Memo"};
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
 /// 常量:"RelaTabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RelaTabId = "RelaTabId";    //相关表Id

 /// <summary>
 /// 常量:"FldId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldId = "FldId";    //字段Id

 /// <summary>
 /// 常量:"FldExpression"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldExpression = "FldExpression";    //字段表达式

 /// <summary>
 /// 常量:"FldExpressionType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldExpressionType = "FldExpressionType";    //FldExpressionType

 /// <summary>
 /// 常量:"FieldAliases"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FieldAliases = "FieldAliases";    //字段别名

 /// <summary>
 /// 常量:"Filters"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Filters = "Filters";    //筛选器

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

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