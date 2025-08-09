
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFieldTab4RootFldEN
 表名:vFieldTab4RootFld(00050406)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:12:09
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
 /// 表vFieldTab4RootFld的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vFieldTab4RootFld
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
public K_mId_vFieldTab4RootFld(long lngmId)
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
 /// <returns>返回:[K_mId_vFieldTab4RootFld]类型的对象</returns>
public static implicit operator K_mId_vFieldTab4RootFld(long value)
{
return new K_mId_vFieldTab4RootFld(value);
}
}
 /// <summary>
 /// v工程字段4RootFld(vFieldTab4RootFld)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvFieldTab4RootFldEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vFieldTab4RootFld"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 32;
public static string[] _AttributeName = new string[] {"TabName", "TabNum", "FldName", "FldCnName", "Caption", "DataTypeId", "DataTypeName", "FldLength", "FldPrecision", "FldInfo", "IsNull", "IsIdentity", "IsOnlyOne", "MaxValue", "MinValue", "DefaultValue", "FldStateId", "mId", "TabId", "FldId", "IsPrimaryKey", "IsRootFld", "Root4TabId", "RootFldId", "RootTabId", "PrjId", "UpdUser", "UpdDate", "Memo", "RootFldName", "RootTabName", "Root4TabName"};

protected string mstrTabName;    //表名
protected int? mintTabNum;    //表数
protected string mstrFldName;    //字段名
protected string mstrFldCnName;    //字段中文详名
protected string mstrCaption;    //标题
protected string mstrDataTypeId;    //数据类型Id
protected string mstrDataTypeName;    //数据类型名称
protected int mintFldLength;    //字段长度
protected int? mintFldPrecision;    //精确度
protected string mstrFldInfo;    //字段信息
protected bool mbolIsNull;    //是否可空
protected bool mbolIsIdentity;    //是否Identity
protected bool mbolIsOnlyOne;    //是否唯一
protected string mstrMaxValue;    //最大值
protected string mstrMinValue;    //最小值
protected string mstrDefaultValue;    //缺省值
protected string mstrFldStateId;    //字段状态Id
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
protected string mstrRootFldName;    //RootFldName
protected string mstrRootTabName;    //根表
protected string mstrRoot4TabName;    //主根表

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvFieldTab4RootFldEN()
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
public clsvFieldTab4RootFldEN(long lngmId)
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
if (strAttributeName  ==  convFieldTab4RootFld.TabName)
{
return mstrTabName;
}
else if (strAttributeName  ==  convFieldTab4RootFld.TabNum)
{
return mintTabNum;
}
else if (strAttributeName  ==  convFieldTab4RootFld.FldName)
{
return mstrFldName;
}
else if (strAttributeName  ==  convFieldTab4RootFld.FldCnName)
{
return mstrFldCnName;
}
else if (strAttributeName  ==  convFieldTab4RootFld.Caption)
{
return mstrCaption;
}
else if (strAttributeName  ==  convFieldTab4RootFld.DataTypeId)
{
return mstrDataTypeId;
}
else if (strAttributeName  ==  convFieldTab4RootFld.DataTypeName)
{
return mstrDataTypeName;
}
else if (strAttributeName  ==  convFieldTab4RootFld.FldLength)
{
return mintFldLength;
}
else if (strAttributeName  ==  convFieldTab4RootFld.FldPrecision)
{
return mintFldPrecision;
}
else if (strAttributeName  ==  convFieldTab4RootFld.FldInfo)
{
return mstrFldInfo;
}
else if (strAttributeName  ==  convFieldTab4RootFld.IsNull)
{
return mbolIsNull;
}
else if (strAttributeName  ==  convFieldTab4RootFld.IsIdentity)
{
return mbolIsIdentity;
}
else if (strAttributeName  ==  convFieldTab4RootFld.IsOnlyOne)
{
return mbolIsOnlyOne;
}
else if (strAttributeName  ==  convFieldTab4RootFld.MaxValue)
{
return mstrMaxValue;
}
else if (strAttributeName  ==  convFieldTab4RootFld.MinValue)
{
return mstrMinValue;
}
else if (strAttributeName  ==  convFieldTab4RootFld.DefaultValue)
{
return mstrDefaultValue;
}
else if (strAttributeName  ==  convFieldTab4RootFld.FldStateId)
{
return mstrFldStateId;
}
else if (strAttributeName  ==  convFieldTab4RootFld.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convFieldTab4RootFld.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  convFieldTab4RootFld.FldId)
{
return mstrFldId;
}
else if (strAttributeName  ==  convFieldTab4RootFld.IsPrimaryKey)
{
return mbolIsPrimaryKey;
}
else if (strAttributeName  ==  convFieldTab4RootFld.IsRootFld)
{
return mbolIsRootFld;
}
else if (strAttributeName  ==  convFieldTab4RootFld.Root4TabId)
{
return mstrRoot4TabId;
}
else if (strAttributeName  ==  convFieldTab4RootFld.RootFldId)
{
return mstrRootFldId;
}
else if (strAttributeName  ==  convFieldTab4RootFld.RootTabId)
{
return mstrRootTabId;
}
else if (strAttributeName  ==  convFieldTab4RootFld.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convFieldTab4RootFld.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convFieldTab4RootFld.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convFieldTab4RootFld.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convFieldTab4RootFld.RootFldName)
{
return mstrRootFldName;
}
else if (strAttributeName  ==  convFieldTab4RootFld.RootTabName)
{
return mstrRootTabName;
}
else if (strAttributeName  ==  convFieldTab4RootFld.Root4TabName)
{
return mstrRoot4TabName;
}
return null;
}
set
{
if (strAttributeName  ==  convFieldTab4RootFld.TabName)
{
mstrTabName = value.ToString();
 AddUpdatedFld(convFieldTab4RootFld.TabName);
}
else if (strAttributeName  ==  convFieldTab4RootFld.TabNum)
{
mintTabNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFieldTab4RootFld.TabNum);
}
else if (strAttributeName  ==  convFieldTab4RootFld.FldName)
{
mstrFldName = value.ToString();
 AddUpdatedFld(convFieldTab4RootFld.FldName);
}
else if (strAttributeName  ==  convFieldTab4RootFld.FldCnName)
{
mstrFldCnName = value.ToString();
 AddUpdatedFld(convFieldTab4RootFld.FldCnName);
}
else if (strAttributeName  ==  convFieldTab4RootFld.Caption)
{
mstrCaption = value.ToString();
 AddUpdatedFld(convFieldTab4RootFld.Caption);
}
else if (strAttributeName  ==  convFieldTab4RootFld.DataTypeId)
{
mstrDataTypeId = value.ToString();
 AddUpdatedFld(convFieldTab4RootFld.DataTypeId);
}
else if (strAttributeName  ==  convFieldTab4RootFld.DataTypeName)
{
mstrDataTypeName = value.ToString();
 AddUpdatedFld(convFieldTab4RootFld.DataTypeName);
}
else if (strAttributeName  ==  convFieldTab4RootFld.FldLength)
{
mintFldLength = TransNullToInt(value.ToString());
 AddUpdatedFld(convFieldTab4RootFld.FldLength);
}
else if (strAttributeName  ==  convFieldTab4RootFld.FldPrecision)
{
mintFldPrecision = TransNullToInt(value.ToString());
 AddUpdatedFld(convFieldTab4RootFld.FldPrecision);
}
else if (strAttributeName  ==  convFieldTab4RootFld.FldInfo)
{
mstrFldInfo = value.ToString();
 AddUpdatedFld(convFieldTab4RootFld.FldInfo);
}
else if (strAttributeName  ==  convFieldTab4RootFld.IsNull)
{
mbolIsNull = TransNullToBool(value.ToString());
 AddUpdatedFld(convFieldTab4RootFld.IsNull);
}
else if (strAttributeName  ==  convFieldTab4RootFld.IsIdentity)
{
mbolIsIdentity = TransNullToBool(value.ToString());
 AddUpdatedFld(convFieldTab4RootFld.IsIdentity);
}
else if (strAttributeName  ==  convFieldTab4RootFld.IsOnlyOne)
{
mbolIsOnlyOne = TransNullToBool(value.ToString());
 AddUpdatedFld(convFieldTab4RootFld.IsOnlyOne);
}
else if (strAttributeName  ==  convFieldTab4RootFld.MaxValue)
{
mstrMaxValue = value.ToString();
 AddUpdatedFld(convFieldTab4RootFld.MaxValue);
}
else if (strAttributeName  ==  convFieldTab4RootFld.MinValue)
{
mstrMinValue = value.ToString();
 AddUpdatedFld(convFieldTab4RootFld.MinValue);
}
else if (strAttributeName  ==  convFieldTab4RootFld.DefaultValue)
{
mstrDefaultValue = value.ToString();
 AddUpdatedFld(convFieldTab4RootFld.DefaultValue);
}
else if (strAttributeName  ==  convFieldTab4RootFld.FldStateId)
{
mstrFldStateId = value.ToString();
 AddUpdatedFld(convFieldTab4RootFld.FldStateId);
}
else if (strAttributeName  ==  convFieldTab4RootFld.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convFieldTab4RootFld.mId);
}
else if (strAttributeName  ==  convFieldTab4RootFld.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(convFieldTab4RootFld.TabId);
}
else if (strAttributeName  ==  convFieldTab4RootFld.FldId)
{
mstrFldId = value.ToString();
 AddUpdatedFld(convFieldTab4RootFld.FldId);
}
else if (strAttributeName  ==  convFieldTab4RootFld.IsPrimaryKey)
{
mbolIsPrimaryKey = TransNullToBool(value.ToString());
 AddUpdatedFld(convFieldTab4RootFld.IsPrimaryKey);
}
else if (strAttributeName  ==  convFieldTab4RootFld.IsRootFld)
{
mbolIsRootFld = TransNullToBool(value.ToString());
 AddUpdatedFld(convFieldTab4RootFld.IsRootFld);
}
else if (strAttributeName  ==  convFieldTab4RootFld.Root4TabId)
{
mstrRoot4TabId = value.ToString();
 AddUpdatedFld(convFieldTab4RootFld.Root4TabId);
}
else if (strAttributeName  ==  convFieldTab4RootFld.RootFldId)
{
mstrRootFldId = value.ToString();
 AddUpdatedFld(convFieldTab4RootFld.RootFldId);
}
else if (strAttributeName  ==  convFieldTab4RootFld.RootTabId)
{
mstrRootTabId = value.ToString();
 AddUpdatedFld(convFieldTab4RootFld.RootTabId);
}
else if (strAttributeName  ==  convFieldTab4RootFld.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convFieldTab4RootFld.PrjId);
}
else if (strAttributeName  ==  convFieldTab4RootFld.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFieldTab4RootFld.UpdUser);
}
else if (strAttributeName  ==  convFieldTab4RootFld.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFieldTab4RootFld.UpdDate);
}
else if (strAttributeName  ==  convFieldTab4RootFld.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFieldTab4RootFld.Memo);
}
else if (strAttributeName  ==  convFieldTab4RootFld.RootFldName)
{
mstrRootFldName = value.ToString();
 AddUpdatedFld(convFieldTab4RootFld.RootFldName);
}
else if (strAttributeName  ==  convFieldTab4RootFld.RootTabName)
{
mstrRootTabName = value.ToString();
 AddUpdatedFld(convFieldTab4RootFld.RootTabName);
}
else if (strAttributeName  ==  convFieldTab4RootFld.Root4TabName)
{
mstrRoot4TabName = value.ToString();
 AddUpdatedFld(convFieldTab4RootFld.Root4TabName);
}
}
}
public object this[int intIndex]
{
get
{
if (convFieldTab4RootFld.TabName  ==  _AttributeName[intIndex])
{
return mstrTabName;
}
else if (convFieldTab4RootFld.TabNum  ==  _AttributeName[intIndex])
{
return mintTabNum;
}
else if (convFieldTab4RootFld.FldName  ==  _AttributeName[intIndex])
{
return mstrFldName;
}
else if (convFieldTab4RootFld.FldCnName  ==  _AttributeName[intIndex])
{
return mstrFldCnName;
}
else if (convFieldTab4RootFld.Caption  ==  _AttributeName[intIndex])
{
return mstrCaption;
}
else if (convFieldTab4RootFld.DataTypeId  ==  _AttributeName[intIndex])
{
return mstrDataTypeId;
}
else if (convFieldTab4RootFld.DataTypeName  ==  _AttributeName[intIndex])
{
return mstrDataTypeName;
}
else if (convFieldTab4RootFld.FldLength  ==  _AttributeName[intIndex])
{
return mintFldLength;
}
else if (convFieldTab4RootFld.FldPrecision  ==  _AttributeName[intIndex])
{
return mintFldPrecision;
}
else if (convFieldTab4RootFld.FldInfo  ==  _AttributeName[intIndex])
{
return mstrFldInfo;
}
else if (convFieldTab4RootFld.IsNull  ==  _AttributeName[intIndex])
{
return mbolIsNull;
}
else if (convFieldTab4RootFld.IsIdentity  ==  _AttributeName[intIndex])
{
return mbolIsIdentity;
}
else if (convFieldTab4RootFld.IsOnlyOne  ==  _AttributeName[intIndex])
{
return mbolIsOnlyOne;
}
else if (convFieldTab4RootFld.MaxValue  ==  _AttributeName[intIndex])
{
return mstrMaxValue;
}
else if (convFieldTab4RootFld.MinValue  ==  _AttributeName[intIndex])
{
return mstrMinValue;
}
else if (convFieldTab4RootFld.DefaultValue  ==  _AttributeName[intIndex])
{
return mstrDefaultValue;
}
else if (convFieldTab4RootFld.FldStateId  ==  _AttributeName[intIndex])
{
return mstrFldStateId;
}
else if (convFieldTab4RootFld.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (convFieldTab4RootFld.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (convFieldTab4RootFld.FldId  ==  _AttributeName[intIndex])
{
return mstrFldId;
}
else if (convFieldTab4RootFld.IsPrimaryKey  ==  _AttributeName[intIndex])
{
return mbolIsPrimaryKey;
}
else if (convFieldTab4RootFld.IsRootFld  ==  _AttributeName[intIndex])
{
return mbolIsRootFld;
}
else if (convFieldTab4RootFld.Root4TabId  ==  _AttributeName[intIndex])
{
return mstrRoot4TabId;
}
else if (convFieldTab4RootFld.RootFldId  ==  _AttributeName[intIndex])
{
return mstrRootFldId;
}
else if (convFieldTab4RootFld.RootTabId  ==  _AttributeName[intIndex])
{
return mstrRootTabId;
}
else if (convFieldTab4RootFld.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convFieldTab4RootFld.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convFieldTab4RootFld.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convFieldTab4RootFld.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (convFieldTab4RootFld.RootFldName  ==  _AttributeName[intIndex])
{
return mstrRootFldName;
}
else if (convFieldTab4RootFld.RootTabName  ==  _AttributeName[intIndex])
{
return mstrRootTabName;
}
else if (convFieldTab4RootFld.Root4TabName  ==  _AttributeName[intIndex])
{
return mstrRoot4TabName;
}
return null;
}
set
{
if (convFieldTab4RootFld.TabName  ==  _AttributeName[intIndex])
{
mstrTabName = value.ToString();
 AddUpdatedFld(convFieldTab4RootFld.TabName);
}
else if (convFieldTab4RootFld.TabNum  ==  _AttributeName[intIndex])
{
mintTabNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFieldTab4RootFld.TabNum);
}
else if (convFieldTab4RootFld.FldName  ==  _AttributeName[intIndex])
{
mstrFldName = value.ToString();
 AddUpdatedFld(convFieldTab4RootFld.FldName);
}
else if (convFieldTab4RootFld.FldCnName  ==  _AttributeName[intIndex])
{
mstrFldCnName = value.ToString();
 AddUpdatedFld(convFieldTab4RootFld.FldCnName);
}
else if (convFieldTab4RootFld.Caption  ==  _AttributeName[intIndex])
{
mstrCaption = value.ToString();
 AddUpdatedFld(convFieldTab4RootFld.Caption);
}
else if (convFieldTab4RootFld.DataTypeId  ==  _AttributeName[intIndex])
{
mstrDataTypeId = value.ToString();
 AddUpdatedFld(convFieldTab4RootFld.DataTypeId);
}
else if (convFieldTab4RootFld.DataTypeName  ==  _AttributeName[intIndex])
{
mstrDataTypeName = value.ToString();
 AddUpdatedFld(convFieldTab4RootFld.DataTypeName);
}
else if (convFieldTab4RootFld.FldLength  ==  _AttributeName[intIndex])
{
mintFldLength = TransNullToInt(value.ToString());
 AddUpdatedFld(convFieldTab4RootFld.FldLength);
}
else if (convFieldTab4RootFld.FldPrecision  ==  _AttributeName[intIndex])
{
mintFldPrecision = TransNullToInt(value.ToString());
 AddUpdatedFld(convFieldTab4RootFld.FldPrecision);
}
else if (convFieldTab4RootFld.FldInfo  ==  _AttributeName[intIndex])
{
mstrFldInfo = value.ToString();
 AddUpdatedFld(convFieldTab4RootFld.FldInfo);
}
else if (convFieldTab4RootFld.IsNull  ==  _AttributeName[intIndex])
{
mbolIsNull = TransNullToBool(value.ToString());
 AddUpdatedFld(convFieldTab4RootFld.IsNull);
}
else if (convFieldTab4RootFld.IsIdentity  ==  _AttributeName[intIndex])
{
mbolIsIdentity = TransNullToBool(value.ToString());
 AddUpdatedFld(convFieldTab4RootFld.IsIdentity);
}
else if (convFieldTab4RootFld.IsOnlyOne  ==  _AttributeName[intIndex])
{
mbolIsOnlyOne = TransNullToBool(value.ToString());
 AddUpdatedFld(convFieldTab4RootFld.IsOnlyOne);
}
else if (convFieldTab4RootFld.MaxValue  ==  _AttributeName[intIndex])
{
mstrMaxValue = value.ToString();
 AddUpdatedFld(convFieldTab4RootFld.MaxValue);
}
else if (convFieldTab4RootFld.MinValue  ==  _AttributeName[intIndex])
{
mstrMinValue = value.ToString();
 AddUpdatedFld(convFieldTab4RootFld.MinValue);
}
else if (convFieldTab4RootFld.DefaultValue  ==  _AttributeName[intIndex])
{
mstrDefaultValue = value.ToString();
 AddUpdatedFld(convFieldTab4RootFld.DefaultValue);
}
else if (convFieldTab4RootFld.FldStateId  ==  _AttributeName[intIndex])
{
mstrFldStateId = value.ToString();
 AddUpdatedFld(convFieldTab4RootFld.FldStateId);
}
else if (convFieldTab4RootFld.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convFieldTab4RootFld.mId);
}
else if (convFieldTab4RootFld.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(convFieldTab4RootFld.TabId);
}
else if (convFieldTab4RootFld.FldId  ==  _AttributeName[intIndex])
{
mstrFldId = value.ToString();
 AddUpdatedFld(convFieldTab4RootFld.FldId);
}
else if (convFieldTab4RootFld.IsPrimaryKey  ==  _AttributeName[intIndex])
{
mbolIsPrimaryKey = TransNullToBool(value.ToString());
 AddUpdatedFld(convFieldTab4RootFld.IsPrimaryKey);
}
else if (convFieldTab4RootFld.IsRootFld  ==  _AttributeName[intIndex])
{
mbolIsRootFld = TransNullToBool(value.ToString());
 AddUpdatedFld(convFieldTab4RootFld.IsRootFld);
}
else if (convFieldTab4RootFld.Root4TabId  ==  _AttributeName[intIndex])
{
mstrRoot4TabId = value.ToString();
 AddUpdatedFld(convFieldTab4RootFld.Root4TabId);
}
else if (convFieldTab4RootFld.RootFldId  ==  _AttributeName[intIndex])
{
mstrRootFldId = value.ToString();
 AddUpdatedFld(convFieldTab4RootFld.RootFldId);
}
else if (convFieldTab4RootFld.RootTabId  ==  _AttributeName[intIndex])
{
mstrRootTabId = value.ToString();
 AddUpdatedFld(convFieldTab4RootFld.RootTabId);
}
else if (convFieldTab4RootFld.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convFieldTab4RootFld.PrjId);
}
else if (convFieldTab4RootFld.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFieldTab4RootFld.UpdUser);
}
else if (convFieldTab4RootFld.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFieldTab4RootFld.UpdDate);
}
else if (convFieldTab4RootFld.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFieldTab4RootFld.Memo);
}
else if (convFieldTab4RootFld.RootFldName  ==  _AttributeName[intIndex])
{
mstrRootFldName = value.ToString();
 AddUpdatedFld(convFieldTab4RootFld.RootFldName);
}
else if (convFieldTab4RootFld.RootTabName  ==  _AttributeName[intIndex])
{
mstrRootTabName = value.ToString();
 AddUpdatedFld(convFieldTab4RootFld.RootTabName);
}
else if (convFieldTab4RootFld.Root4TabName  ==  _AttributeName[intIndex])
{
mstrRoot4TabName = value.ToString();
 AddUpdatedFld(convFieldTab4RootFld.Root4TabName);
}
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
 AddUpdatedFld(convFieldTab4RootFld.TabName);
}
}
/// <summary>
/// 表数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? TabNum
{
get
{
return mintTabNum;
}
set
{
 mintTabNum = value;
//记录修改过的字段
 AddUpdatedFld(convFieldTab4RootFld.TabNum);
}
}
/// <summary>
/// 字段名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FldName
{
get
{
return mstrFldName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldName = value;
}
else
{
 mstrFldName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFieldTab4RootFld.FldName);
}
}
/// <summary>
/// 字段中文详名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FldCnName
{
get
{
return mstrFldCnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldCnName = value;
}
else
{
 mstrFldCnName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFieldTab4RootFld.FldCnName);
}
}
/// <summary>
/// 标题(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Caption
{
get
{
return mstrCaption;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaption = value;
}
else
{
 mstrCaption = value;
}
//记录修改过的字段
 AddUpdatedFld(convFieldTab4RootFld.Caption);
}
}
/// <summary>
/// 数据类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataTypeId
{
get
{
return mstrDataTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataTypeId = value;
}
else
{
 mstrDataTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFieldTab4RootFld.DataTypeId);
}
}
/// <summary>
/// 数据类型名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataTypeName
{
get
{
return mstrDataTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataTypeName = value;
}
else
{
 mstrDataTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFieldTab4RootFld.DataTypeName);
}
}
/// <summary>
/// 字段长度(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int FldLength
{
get
{
return mintFldLength;
}
set
{
 mintFldLength = value;
//记录修改过的字段
 AddUpdatedFld(convFieldTab4RootFld.FldLength);
}
}
/// <summary>
/// 精确度(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? FldPrecision
{
get
{
return mintFldPrecision;
}
set
{
 mintFldPrecision = value;
//记录修改过的字段
 AddUpdatedFld(convFieldTab4RootFld.FldPrecision);
}
}
/// <summary>
/// 字段信息(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FldInfo
{
get
{
return mstrFldInfo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldInfo = value;
}
else
{
 mstrFldInfo = value;
}
//记录修改过的字段
 AddUpdatedFld(convFieldTab4RootFld.FldInfo);
}
}
/// <summary>
/// 是否可空(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsNull
{
get
{
return mbolIsNull;
}
set
{
 mbolIsNull = value;
//记录修改过的字段
 AddUpdatedFld(convFieldTab4RootFld.IsNull);
}
}
/// <summary>
/// 是否Identity(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsIdentity
{
get
{
return mbolIsIdentity;
}
set
{
 mbolIsIdentity = value;
//记录修改过的字段
 AddUpdatedFld(convFieldTab4RootFld.IsIdentity);
}
}
/// <summary>
/// 是否唯一(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsOnlyOne
{
get
{
return mbolIsOnlyOne;
}
set
{
 mbolIsOnlyOne = value;
//记录修改过的字段
 AddUpdatedFld(convFieldTab4RootFld.IsOnlyOne);
}
}
/// <summary>
/// 最大值(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MaxValue
{
get
{
return mstrMaxValue;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMaxValue = value;
}
else
{
 mstrMaxValue = value;
}
//记录修改过的字段
 AddUpdatedFld(convFieldTab4RootFld.MaxValue);
}
}
/// <summary>
/// 最小值(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MinValue
{
get
{
return mstrMinValue;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMinValue = value;
}
else
{
 mstrMinValue = value;
}
//记录修改过的字段
 AddUpdatedFld(convFieldTab4RootFld.MinValue);
}
}
/// <summary>
/// 缺省值(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DefaultValue
{
get
{
return mstrDefaultValue;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDefaultValue = value;
}
else
{
 mstrDefaultValue = value;
}
//记录修改过的字段
 AddUpdatedFld(convFieldTab4RootFld.DefaultValue);
}
}
/// <summary>
/// 字段状态Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FldStateId
{
get
{
return mstrFldStateId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldStateId = value;
}
else
{
 mstrFldStateId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFieldTab4RootFld.FldStateId);
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
 AddUpdatedFld(convFieldTab4RootFld.mId);
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
 AddUpdatedFld(convFieldTab4RootFld.TabId);
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
 AddUpdatedFld(convFieldTab4RootFld.FldId);
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
 AddUpdatedFld(convFieldTab4RootFld.IsPrimaryKey);
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
 AddUpdatedFld(convFieldTab4RootFld.IsRootFld);
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
 AddUpdatedFld(convFieldTab4RootFld.Root4TabId);
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
 AddUpdatedFld(convFieldTab4RootFld.RootFldId);
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
 AddUpdatedFld(convFieldTab4RootFld.RootTabId);
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
 AddUpdatedFld(convFieldTab4RootFld.PrjId);
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
 AddUpdatedFld(convFieldTab4RootFld.UpdUser);
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
 AddUpdatedFld(convFieldTab4RootFld.UpdDate);
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
 AddUpdatedFld(convFieldTab4RootFld.Memo);
}
}
/// <summary>
/// RootFldName(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RootFldName
{
get
{
return mstrRootFldName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRootFldName = value;
}
else
{
 mstrRootFldName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFieldTab4RootFld.RootFldName);
}
}
/// <summary>
/// 根表(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RootTabName
{
get
{
return mstrRootTabName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRootTabName = value;
}
else
{
 mstrRootTabName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFieldTab4RootFld.RootTabName);
}
}
/// <summary>
/// 主根表(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Root4TabName
{
get
{
return mstrRoot4TabName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRoot4TabName = value;
}
else
{
 mstrRoot4TabName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFieldTab4RootFld.Root4TabName);
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
 /// v工程字段4RootFld(vFieldTab4RootFld)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convFieldTab4RootFld
{
public const string _CurrTabName = "vFieldTab4RootFld"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"TabName", "TabNum", "FldName", "FldCnName", "Caption", "DataTypeId", "DataTypeName", "FldLength", "FldPrecision", "FldInfo", "IsNull", "IsIdentity", "IsOnlyOne", "MaxValue", "MinValue", "DefaultValue", "FldStateId", "mId", "TabId", "FldId", "IsPrimaryKey", "IsRootFld", "Root4TabId", "RootFldId", "RootTabId", "PrjId", "UpdUser", "UpdDate", "Memo", "RootFldName", "RootTabName", "Root4TabName"};
//以下是属性变量


 /// <summary>
 /// 常量:"TabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabName = "TabName";    //表名

 /// <summary>
 /// 常量:"TabNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabNum = "TabNum";    //表数

 /// <summary>
 /// 常量:"FldName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldName = "FldName";    //字段名

 /// <summary>
 /// 常量:"FldCnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldCnName = "FldCnName";    //字段中文详名

 /// <summary>
 /// 常量:"Caption"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Caption = "Caption";    //标题

 /// <summary>
 /// 常量:"DataTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataTypeId = "DataTypeId";    //数据类型Id

 /// <summary>
 /// 常量:"DataTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataTypeName = "DataTypeName";    //数据类型名称

 /// <summary>
 /// 常量:"FldLength"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldLength = "FldLength";    //字段长度

 /// <summary>
 /// 常量:"FldPrecision"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldPrecision = "FldPrecision";    //精确度

 /// <summary>
 /// 常量:"FldInfo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldInfo = "FldInfo";    //字段信息

 /// <summary>
 /// 常量:"IsNull"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsNull = "IsNull";    //是否可空

 /// <summary>
 /// 常量:"IsIdentity"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsIdentity = "IsIdentity";    //是否Identity

 /// <summary>
 /// 常量:"IsOnlyOne"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsOnlyOne = "IsOnlyOne";    //是否唯一

 /// <summary>
 /// 常量:"MaxValue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MaxValue = "MaxValue";    //最大值

 /// <summary>
 /// 常量:"MinValue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MinValue = "MinValue";    //最小值

 /// <summary>
 /// 常量:"DefaultValue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DefaultValue = "DefaultValue";    //缺省值

 /// <summary>
 /// 常量:"FldStateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldStateId = "FldStateId";    //字段状态Id

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

 /// <summary>
 /// 常量:"RootFldName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RootFldName = "RootFldName";    //RootFldName

 /// <summary>
 /// 常量:"RootTabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RootTabName = "RootTabName";    //根表

 /// <summary>
 /// 常量:"Root4TabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Root4TabName = "Root4TabName";    //主根表
}

}