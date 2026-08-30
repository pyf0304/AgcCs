
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFR_FileReferenceEN
 表名:FR_FileReference(00050658)
 * 版本:2026.07.20(服务器:WIN-SRV103-116)
 日期:2026/07/23 22:47:45
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:文件引用(FileReference)
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
 /// 表FR_FileReference的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_FR_FileReference
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
public K_mId_FR_FileReference(long lngmId)
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
 /// <returns>返回:[K_mId_FR_FileReference]类型的对象</returns>
public static implicit operator K_mId_FR_FileReference(long value)
{
return new K_mId_FR_FileReference(value);
}
}
 /// <summary>
 /// FR_FileReference(FR_FileReference)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsFR_FileReferenceEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "FR_FileReference"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 14;
public static string[] _AttributeName = new string[] {"mId", "SourceFileId", "TargetFileId", "SourceSymbolId", "TargetSymbolId", "RefType", "RefName", "RefAlias", "LineStart", "LineEnd", "ColumnStart", "ColumnEnd", "RefStatement", "CreatedAt"};

protected long mlngmId;    //mId
protected long mlngSourceFileId;    //源文件Id
protected long mlngTargetFileId;    //目标文件Id
protected long? mlngSourceSymbolId;    //源符号Id
protected long? mlngTargetSymbolId;    //目标符号Id
protected string mstrRefType;    //引用类型
protected string mstrRefName;    //引用名
protected string mstrRefAlias;    //别名
protected int? mintLineStart;    //开始行
protected int? mintLineEnd;    //结束行
protected int? mintColumnStart;    //开始列
protected int? mintColumnEnd;    //结束列
protected string mstrRefStatement;    //原始引用语句
protected DateTime mdteCreatedAt;    //建立时间

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsFR_FileReferenceEN()
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
public clsFR_FileReferenceEN(long lngmId)
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
if (strAttributeName  ==  conFR_FileReference.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conFR_FileReference.SourceFileId)
{
return mlngSourceFileId;
}
else if (strAttributeName  ==  conFR_FileReference.TargetFileId)
{
return mlngTargetFileId;
}
else if (strAttributeName  ==  conFR_FileReference.SourceSymbolId)
{
return mlngSourceSymbolId;
}
else if (strAttributeName  ==  conFR_FileReference.TargetSymbolId)
{
return mlngTargetSymbolId;
}
else if (strAttributeName  ==  conFR_FileReference.RefType)
{
return mstrRefType;
}
else if (strAttributeName  ==  conFR_FileReference.RefName)
{
return mstrRefName;
}
else if (strAttributeName  ==  conFR_FileReference.RefAlias)
{
return mstrRefAlias;
}
else if (strAttributeName  ==  conFR_FileReference.LineStart)
{
return mintLineStart;
}
else if (strAttributeName  ==  conFR_FileReference.LineEnd)
{
return mintLineEnd;
}
else if (strAttributeName  ==  conFR_FileReference.ColumnStart)
{
return mintColumnStart;
}
else if (strAttributeName  ==  conFR_FileReference.ColumnEnd)
{
return mintColumnEnd;
}
else if (strAttributeName  ==  conFR_FileReference.RefStatement)
{
return mstrRefStatement;
}
else if (strAttributeName  ==  conFR_FileReference.CreatedAt)
{
return mdteCreatedAt;
}
return null;
}
set
{
if (strAttributeName  ==  conFR_FileReference.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conFR_FileReference.mId);
}
else if (strAttributeName  ==  conFR_FileReference.SourceFileId)
{
mlngSourceFileId = TransNullToInt(value.ToString());
 AddUpdatedFld(conFR_FileReference.SourceFileId);
}
else if (strAttributeName  ==  conFR_FileReference.TargetFileId)
{
mlngTargetFileId = TransNullToInt(value.ToString());
 AddUpdatedFld(conFR_FileReference.TargetFileId);
}
else if (strAttributeName  ==  conFR_FileReference.SourceSymbolId)
{
mlngSourceSymbolId = TransNullToInt(value.ToString());
 AddUpdatedFld(conFR_FileReference.SourceSymbolId);
}
else if (strAttributeName  ==  conFR_FileReference.TargetSymbolId)
{
mlngTargetSymbolId = TransNullToInt(value.ToString());
 AddUpdatedFld(conFR_FileReference.TargetSymbolId);
}
else if (strAttributeName  ==  conFR_FileReference.RefType)
{
mstrRefType = value.ToString();
 AddUpdatedFld(conFR_FileReference.RefType);
}
else if (strAttributeName  ==  conFR_FileReference.RefName)
{
mstrRefName = value.ToString();
 AddUpdatedFld(conFR_FileReference.RefName);
}
else if (strAttributeName  ==  conFR_FileReference.RefAlias)
{
mstrRefAlias = value.ToString();
 AddUpdatedFld(conFR_FileReference.RefAlias);
}
else if (strAttributeName  ==  conFR_FileReference.LineStart)
{
mintLineStart = TransNullToInt(value.ToString());
 AddUpdatedFld(conFR_FileReference.LineStart);
}
else if (strAttributeName  ==  conFR_FileReference.LineEnd)
{
mintLineEnd = TransNullToInt(value.ToString());
 AddUpdatedFld(conFR_FileReference.LineEnd);
}
else if (strAttributeName  ==  conFR_FileReference.ColumnStart)
{
mintColumnStart = TransNullToInt(value.ToString());
 AddUpdatedFld(conFR_FileReference.ColumnStart);
}
else if (strAttributeName  ==  conFR_FileReference.ColumnEnd)
{
mintColumnEnd = TransNullToInt(value.ToString());
 AddUpdatedFld(conFR_FileReference.ColumnEnd);
}
else if (strAttributeName  ==  conFR_FileReference.RefStatement)
{
mstrRefStatement = value.ToString();
 AddUpdatedFld(conFR_FileReference.RefStatement);
}
else if (strAttributeName  ==  conFR_FileReference.CreatedAt)
{
mdteCreatedAt = TransNullToDate(value.ToString());
 AddUpdatedFld(conFR_FileReference.CreatedAt);
}
}
}
public object this[int intIndex]
{
get
{
if (conFR_FileReference.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (conFR_FileReference.SourceFileId  ==  _AttributeName[intIndex])
{
return mlngSourceFileId;
}
else if (conFR_FileReference.TargetFileId  ==  _AttributeName[intIndex])
{
return mlngTargetFileId;
}
else if (conFR_FileReference.SourceSymbolId  ==  _AttributeName[intIndex])
{
return mlngSourceSymbolId;
}
else if (conFR_FileReference.TargetSymbolId  ==  _AttributeName[intIndex])
{
return mlngTargetSymbolId;
}
else if (conFR_FileReference.RefType  ==  _AttributeName[intIndex])
{
return mstrRefType;
}
else if (conFR_FileReference.RefName  ==  _AttributeName[intIndex])
{
return mstrRefName;
}
else if (conFR_FileReference.RefAlias  ==  _AttributeName[intIndex])
{
return mstrRefAlias;
}
else if (conFR_FileReference.LineStart  ==  _AttributeName[intIndex])
{
return mintLineStart;
}
else if (conFR_FileReference.LineEnd  ==  _AttributeName[intIndex])
{
return mintLineEnd;
}
else if (conFR_FileReference.ColumnStart  ==  _AttributeName[intIndex])
{
return mintColumnStart;
}
else if (conFR_FileReference.ColumnEnd  ==  _AttributeName[intIndex])
{
return mintColumnEnd;
}
else if (conFR_FileReference.RefStatement  ==  _AttributeName[intIndex])
{
return mstrRefStatement;
}
else if (conFR_FileReference.CreatedAt  ==  _AttributeName[intIndex])
{
return mdteCreatedAt;
}
return null;
}
set
{
if (conFR_FileReference.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conFR_FileReference.mId);
}
else if (conFR_FileReference.SourceFileId  ==  _AttributeName[intIndex])
{
mlngSourceFileId = TransNullToInt(value.ToString());
 AddUpdatedFld(conFR_FileReference.SourceFileId);
}
else if (conFR_FileReference.TargetFileId  ==  _AttributeName[intIndex])
{
mlngTargetFileId = TransNullToInt(value.ToString());
 AddUpdatedFld(conFR_FileReference.TargetFileId);
}
else if (conFR_FileReference.SourceSymbolId  ==  _AttributeName[intIndex])
{
mlngSourceSymbolId = TransNullToInt(value.ToString());
 AddUpdatedFld(conFR_FileReference.SourceSymbolId);
}
else if (conFR_FileReference.TargetSymbolId  ==  _AttributeName[intIndex])
{
mlngTargetSymbolId = TransNullToInt(value.ToString());
 AddUpdatedFld(conFR_FileReference.TargetSymbolId);
}
else if (conFR_FileReference.RefType  ==  _AttributeName[intIndex])
{
mstrRefType = value.ToString();
 AddUpdatedFld(conFR_FileReference.RefType);
}
else if (conFR_FileReference.RefName  ==  _AttributeName[intIndex])
{
mstrRefName = value.ToString();
 AddUpdatedFld(conFR_FileReference.RefName);
}
else if (conFR_FileReference.RefAlias  ==  _AttributeName[intIndex])
{
mstrRefAlias = value.ToString();
 AddUpdatedFld(conFR_FileReference.RefAlias);
}
else if (conFR_FileReference.LineStart  ==  _AttributeName[intIndex])
{
mintLineStart = TransNullToInt(value.ToString());
 AddUpdatedFld(conFR_FileReference.LineStart);
}
else if (conFR_FileReference.LineEnd  ==  _AttributeName[intIndex])
{
mintLineEnd = TransNullToInt(value.ToString());
 AddUpdatedFld(conFR_FileReference.LineEnd);
}
else if (conFR_FileReference.ColumnStart  ==  _AttributeName[intIndex])
{
mintColumnStart = TransNullToInt(value.ToString());
 AddUpdatedFld(conFR_FileReference.ColumnStart);
}
else if (conFR_FileReference.ColumnEnd  ==  _AttributeName[intIndex])
{
mintColumnEnd = TransNullToInt(value.ToString());
 AddUpdatedFld(conFR_FileReference.ColumnEnd);
}
else if (conFR_FileReference.RefStatement  ==  _AttributeName[intIndex])
{
mstrRefStatement = value.ToString();
 AddUpdatedFld(conFR_FileReference.RefStatement);
}
else if (conFR_FileReference.CreatedAt  ==  _AttributeName[intIndex])
{
mdteCreatedAt = TransNullToDate(value.ToString());
 AddUpdatedFld(conFR_FileReference.CreatedAt);
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
 AddUpdatedFld(conFR_FileReference.mId);
}
}
/// <summary>
/// 源文件Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long SourceFileId
{
get
{
return mlngSourceFileId;
}
set
{
 mlngSourceFileId = value;
//记录修改过的字段
 AddUpdatedFld(conFR_FileReference.SourceFileId);
}
}
/// <summary>
/// 目标文件Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long TargetFileId
{
get
{
return mlngTargetFileId;
}
set
{
 mlngTargetFileId = value;
//记录修改过的字段
 AddUpdatedFld(conFR_FileReference.TargetFileId);
}
}
/// <summary>
/// 源符号Id(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long? SourceSymbolId
{
get
{
return mlngSourceSymbolId;
}
set
{
 mlngSourceSymbolId = value;
//记录修改过的字段
 AddUpdatedFld(conFR_FileReference.SourceSymbolId);
}
}
/// <summary>
/// 目标符号Id(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long? TargetSymbolId
{
get
{
return mlngTargetSymbolId;
}
set
{
 mlngTargetSymbolId = value;
//记录修改过的字段
 AddUpdatedFld(conFR_FileReference.TargetSymbolId);
}
}
/// <summary>
/// 引用类型(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RefType
{
get
{
return mstrRefType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRefType = value;
}
else
{
 mstrRefType = value;
}
//记录修改过的字段
 AddUpdatedFld(conFR_FileReference.RefType);
}
}
/// <summary>
/// 引用名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RefName
{
get
{
return mstrRefName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRefName = value;
}
else
{
 mstrRefName = value;
}
//记录修改过的字段
 AddUpdatedFld(conFR_FileReference.RefName);
}
}
/// <summary>
/// 别名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RefAlias
{
get
{
return mstrRefAlias;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRefAlias = value;
}
else
{
 mstrRefAlias = value;
}
//记录修改过的字段
 AddUpdatedFld(conFR_FileReference.RefAlias);
}
}
/// <summary>
/// 开始行(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? LineStart
{
get
{
return mintLineStart;
}
set
{
 mintLineStart = value;
//记录修改过的字段
 AddUpdatedFld(conFR_FileReference.LineStart);
}
}
/// <summary>
/// 结束行(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? LineEnd
{
get
{
return mintLineEnd;
}
set
{
 mintLineEnd = value;
//记录修改过的字段
 AddUpdatedFld(conFR_FileReference.LineEnd);
}
}
/// <summary>
/// 开始列(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? ColumnStart
{
get
{
return mintColumnStart;
}
set
{
 mintColumnStart = value;
//记录修改过的字段
 AddUpdatedFld(conFR_FileReference.ColumnStart);
}
}
/// <summary>
/// 结束列(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? ColumnEnd
{
get
{
return mintColumnEnd;
}
set
{
 mintColumnEnd = value;
//记录修改过的字段
 AddUpdatedFld(conFR_FileReference.ColumnEnd);
}
}
/// <summary>
/// 原始引用语句(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RefStatement
{
get
{
return mstrRefStatement;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRefStatement = value;
}
else
{
 mstrRefStatement = value;
}
//记录修改过的字段
 AddUpdatedFld(conFR_FileReference.RefStatement);
}
}
/// <summary>
/// 建立时间(说明:;字段类型:datetime;字段长度:16;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public DateTime CreatedAt
{
get
{
return mdteCreatedAt;
}
set
{
 mdteCreatedAt = value;
//记录修改过的字段
 AddUpdatedFld(conFR_FileReference.CreatedAt);
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
 /// FR_FileReference(FR_FileReference)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conFR_FileReference
{
public const string _CurrTabName = "FR_FileReference"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "SourceFileId", "TargetFileId", "SourceSymbolId", "TargetSymbolId", "RefType", "RefName", "RefAlias", "LineStart", "LineEnd", "ColumnStart", "ColumnEnd", "RefStatement", "CreatedAt"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"SourceFileId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SourceFileId = "SourceFileId";    //源文件Id

 /// <summary>
 /// 常量:"TargetFileId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TargetFileId = "TargetFileId";    //目标文件Id

 /// <summary>
 /// 常量:"SourceSymbolId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SourceSymbolId = "SourceSymbolId";    //源符号Id

 /// <summary>
 /// 常量:"TargetSymbolId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TargetSymbolId = "TargetSymbolId";    //目标符号Id

 /// <summary>
 /// 常量:"RefType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RefType = "RefType";    //引用类型

 /// <summary>
 /// 常量:"RefName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RefName = "RefName";    //引用名

 /// <summary>
 /// 常量:"RefAlias"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RefAlias = "RefAlias";    //别名

 /// <summary>
 /// 常量:"LineStart"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LineStart = "LineStart";    //开始行

 /// <summary>
 /// 常量:"LineEnd"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LineEnd = "LineEnd";    //结束行

 /// <summary>
 /// 常量:"ColumnStart"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ColumnStart = "ColumnStart";    //开始列

 /// <summary>
 /// 常量:"ColumnEnd"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ColumnEnd = "ColumnEnd";    //结束列

 /// <summary>
 /// 常量:"RefStatement"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RefStatement = "RefStatement";    //原始引用语句

 /// <summary>
 /// 常量:"CreatedAt"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreatedAt = "CreatedAt";    //建立时间
}

}