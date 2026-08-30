
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFR_CodeSymbolEN
 表名:FR_CodeSymbol(00050657)
 * 版本:2026.07.24(服务器:WIN-SRV103-116)
 日期:2026/07/24 08:14:04
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
 /// 表FR_CodeSymbol的关键字(SymbolId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_SymbolId_FR_CodeSymbol
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngSymbolId">表关键字</param>
public K_SymbolId_FR_CodeSymbol(long lngSymbolId)
{
if (IsValid(lngSymbolId)) Value = lngSymbolId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngSymbolId)
{
if (lngSymbolId == 0) return false;
if (lngSymbolId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_SymbolId_FR_CodeSymbol]类型的对象</returns>
public static implicit operator K_SymbolId_FR_CodeSymbol(long value)
{
return new K_SymbolId_FR_CodeSymbol(value);
}
}
 /// <summary>
 /// FR_CodeSymbol(FR_CodeSymbol)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsFR_CodeSymbolEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "FR_CodeSymbol"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "SymbolId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 13;
public static string[] _AttributeName = new string[] {"SymbolId", "FileResourceId", "SymbolName", "SymbolType", "SymbolExportType", "IsExported", "LineStart", "LineEnd", "ColumnStart", "ColumnEnd", "Signature", "DocComment", "CreatedAt"};

protected long mlngSymbolId;    //符号Id
protected long mlngFileResourceId;    //文件资源Id
protected string mstrSymbolName;    //符号名称
protected string mstrSymbolType;    //符号类型
protected string mstrSymbolExportType;    //符号导出类型
protected bool mbolIsExported;    //是否导出
protected int? mintLineStart;    //开始行
protected int? mintLineEnd;    //结束行
protected int? mintColumnStart;    //开始列
protected int? mintColumnEnd;    //结束列
protected string mstrSignature;    //函数签名
protected string mstrDocComment;    //文档注释
protected DateTime mdteCreatedAt;    //建立时间

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsFR_CodeSymbolEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("SymbolId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "lngSymbolId">关键字:符号Id</param>
public clsFR_CodeSymbolEN(long lngSymbolId)
 {
 if (lngSymbolId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngSymbolId = lngSymbolId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("SymbolId");
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
if (strAttributeName  ==  conFR_CodeSymbol.SymbolId)
{
return mlngSymbolId;
}
else if (strAttributeName  ==  conFR_CodeSymbol.FileResourceId)
{
return mlngFileResourceId;
}
else if (strAttributeName  ==  conFR_CodeSymbol.SymbolName)
{
return mstrSymbolName;
}
else if (strAttributeName  ==  conFR_CodeSymbol.SymbolType)
{
return mstrSymbolType;
}
else if (strAttributeName  ==  conFR_CodeSymbol.SymbolExportType)
{
return mstrSymbolExportType;
}
else if (strAttributeName  ==  conFR_CodeSymbol.IsExported)
{
return mbolIsExported;
}
else if (strAttributeName  ==  conFR_CodeSymbol.LineStart)
{
return mintLineStart;
}
else if (strAttributeName  ==  conFR_CodeSymbol.LineEnd)
{
return mintLineEnd;
}
else if (strAttributeName  ==  conFR_CodeSymbol.ColumnStart)
{
return mintColumnStart;
}
else if (strAttributeName  ==  conFR_CodeSymbol.ColumnEnd)
{
return mintColumnEnd;
}
else if (strAttributeName  ==  conFR_CodeSymbol.Signature)
{
return mstrSignature;
}
else if (strAttributeName  ==  conFR_CodeSymbol.DocComment)
{
return mstrDocComment;
}
else if (strAttributeName  ==  conFR_CodeSymbol.CreatedAt)
{
return mdteCreatedAt;
}
return null;
}
set
{
if (strAttributeName  ==  conFR_CodeSymbol.SymbolId)
{
mlngSymbolId = TransNullToInt(value.ToString());
 AddUpdatedFld(conFR_CodeSymbol.SymbolId);
}
else if (strAttributeName  ==  conFR_CodeSymbol.FileResourceId)
{
mlngFileResourceId = TransNullToInt(value.ToString());
 AddUpdatedFld(conFR_CodeSymbol.FileResourceId);
}
else if (strAttributeName  ==  conFR_CodeSymbol.SymbolName)
{
mstrSymbolName = value.ToString();
 AddUpdatedFld(conFR_CodeSymbol.SymbolName);
}
else if (strAttributeName  ==  conFR_CodeSymbol.SymbolType)
{
mstrSymbolType = value.ToString();
 AddUpdatedFld(conFR_CodeSymbol.SymbolType);
}
else if (strAttributeName  ==  conFR_CodeSymbol.SymbolExportType)
{
mstrSymbolExportType = value.ToString();
 AddUpdatedFld(conFR_CodeSymbol.SymbolExportType);
}
else if (strAttributeName  ==  conFR_CodeSymbol.IsExported)
{
mbolIsExported = TransNullToBool(value.ToString());
 AddUpdatedFld(conFR_CodeSymbol.IsExported);
}
else if (strAttributeName  ==  conFR_CodeSymbol.LineStart)
{
mintLineStart = TransNullToInt(value.ToString());
 AddUpdatedFld(conFR_CodeSymbol.LineStart);
}
else if (strAttributeName  ==  conFR_CodeSymbol.LineEnd)
{
mintLineEnd = TransNullToInt(value.ToString());
 AddUpdatedFld(conFR_CodeSymbol.LineEnd);
}
else if (strAttributeName  ==  conFR_CodeSymbol.ColumnStart)
{
mintColumnStart = TransNullToInt(value.ToString());
 AddUpdatedFld(conFR_CodeSymbol.ColumnStart);
}
else if (strAttributeName  ==  conFR_CodeSymbol.ColumnEnd)
{
mintColumnEnd = TransNullToInt(value.ToString());
 AddUpdatedFld(conFR_CodeSymbol.ColumnEnd);
}
else if (strAttributeName  ==  conFR_CodeSymbol.Signature)
{
mstrSignature = value.ToString();
 AddUpdatedFld(conFR_CodeSymbol.Signature);
}
else if (strAttributeName  ==  conFR_CodeSymbol.DocComment)
{
mstrDocComment = value.ToString();
 AddUpdatedFld(conFR_CodeSymbol.DocComment);
}
else if (strAttributeName  ==  conFR_CodeSymbol.CreatedAt)
{
mdteCreatedAt = TransNullToDate(value.ToString());
 AddUpdatedFld(conFR_CodeSymbol.CreatedAt);
}
}
}
public object this[int intIndex]
{
get
{
if (conFR_CodeSymbol.SymbolId  ==  _AttributeName[intIndex])
{
return mlngSymbolId;
}
else if (conFR_CodeSymbol.FileResourceId  ==  _AttributeName[intIndex])
{
return mlngFileResourceId;
}
else if (conFR_CodeSymbol.SymbolName  ==  _AttributeName[intIndex])
{
return mstrSymbolName;
}
else if (conFR_CodeSymbol.SymbolType  ==  _AttributeName[intIndex])
{
return mstrSymbolType;
}
else if (conFR_CodeSymbol.SymbolExportType  ==  _AttributeName[intIndex])
{
return mstrSymbolExportType;
}
else if (conFR_CodeSymbol.IsExported  ==  _AttributeName[intIndex])
{
return mbolIsExported;
}
else if (conFR_CodeSymbol.LineStart  ==  _AttributeName[intIndex])
{
return mintLineStart;
}
else if (conFR_CodeSymbol.LineEnd  ==  _AttributeName[intIndex])
{
return mintLineEnd;
}
else if (conFR_CodeSymbol.ColumnStart  ==  _AttributeName[intIndex])
{
return mintColumnStart;
}
else if (conFR_CodeSymbol.ColumnEnd  ==  _AttributeName[intIndex])
{
return mintColumnEnd;
}
else if (conFR_CodeSymbol.Signature  ==  _AttributeName[intIndex])
{
return mstrSignature;
}
else if (conFR_CodeSymbol.DocComment  ==  _AttributeName[intIndex])
{
return mstrDocComment;
}
else if (conFR_CodeSymbol.CreatedAt  ==  _AttributeName[intIndex])
{
return mdteCreatedAt;
}
return null;
}
set
{
if (conFR_CodeSymbol.SymbolId  ==  _AttributeName[intIndex])
{
mlngSymbolId = TransNullToInt(value.ToString());
 AddUpdatedFld(conFR_CodeSymbol.SymbolId);
}
else if (conFR_CodeSymbol.FileResourceId  ==  _AttributeName[intIndex])
{
mlngFileResourceId = TransNullToInt(value.ToString());
 AddUpdatedFld(conFR_CodeSymbol.FileResourceId);
}
else if (conFR_CodeSymbol.SymbolName  ==  _AttributeName[intIndex])
{
mstrSymbolName = value.ToString();
 AddUpdatedFld(conFR_CodeSymbol.SymbolName);
}
else if (conFR_CodeSymbol.SymbolType  ==  _AttributeName[intIndex])
{
mstrSymbolType = value.ToString();
 AddUpdatedFld(conFR_CodeSymbol.SymbolType);
}
else if (conFR_CodeSymbol.SymbolExportType  ==  _AttributeName[intIndex])
{
mstrSymbolExportType = value.ToString();
 AddUpdatedFld(conFR_CodeSymbol.SymbolExportType);
}
else if (conFR_CodeSymbol.IsExported  ==  _AttributeName[intIndex])
{
mbolIsExported = TransNullToBool(value.ToString());
 AddUpdatedFld(conFR_CodeSymbol.IsExported);
}
else if (conFR_CodeSymbol.LineStart  ==  _AttributeName[intIndex])
{
mintLineStart = TransNullToInt(value.ToString());
 AddUpdatedFld(conFR_CodeSymbol.LineStart);
}
else if (conFR_CodeSymbol.LineEnd  ==  _AttributeName[intIndex])
{
mintLineEnd = TransNullToInt(value.ToString());
 AddUpdatedFld(conFR_CodeSymbol.LineEnd);
}
else if (conFR_CodeSymbol.ColumnStart  ==  _AttributeName[intIndex])
{
mintColumnStart = TransNullToInt(value.ToString());
 AddUpdatedFld(conFR_CodeSymbol.ColumnStart);
}
else if (conFR_CodeSymbol.ColumnEnd  ==  _AttributeName[intIndex])
{
mintColumnEnd = TransNullToInt(value.ToString());
 AddUpdatedFld(conFR_CodeSymbol.ColumnEnd);
}
else if (conFR_CodeSymbol.Signature  ==  _AttributeName[intIndex])
{
mstrSignature = value.ToString();
 AddUpdatedFld(conFR_CodeSymbol.Signature);
}
else if (conFR_CodeSymbol.DocComment  ==  _AttributeName[intIndex])
{
mstrDocComment = value.ToString();
 AddUpdatedFld(conFR_CodeSymbol.DocComment);
}
else if (conFR_CodeSymbol.CreatedAt  ==  _AttributeName[intIndex])
{
mdteCreatedAt = TransNullToDate(value.ToString());
 AddUpdatedFld(conFR_CodeSymbol.CreatedAt);
}
}
}

/// <summary>
/// 符号Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long SymbolId
{
get
{
return mlngSymbolId;
}
set
{
 mlngSymbolId = value;
//记录修改过的字段
 AddUpdatedFld(conFR_CodeSymbol.SymbolId);
}
}
/// <summary>
/// 文件资源Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long FileResourceId
{
get
{
return mlngFileResourceId;
}
set
{
 mlngFileResourceId = value;
//记录修改过的字段
 AddUpdatedFld(conFR_CodeSymbol.FileResourceId);
}
}
/// <summary>
/// 符号名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SymbolName
{
get
{
return mstrSymbolName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSymbolName = value;
}
else
{
 mstrSymbolName = value;
}
//记录修改过的字段
 AddUpdatedFld(conFR_CodeSymbol.SymbolName);
}
}
/// <summary>
/// 符号类型(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SymbolType
{
get
{
return mstrSymbolType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSymbolType = value;
}
else
{
 mstrSymbolType = value;
}
//记录修改过的字段
 AddUpdatedFld(conFR_CodeSymbol.SymbolType);
}
}
/// <summary>
/// 符号导出类型(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SymbolExportType
{
get
{
return mstrSymbolExportType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSymbolExportType = value;
}
else
{
 mstrSymbolExportType = value;
}
//记录修改过的字段
 AddUpdatedFld(conFR_CodeSymbol.SymbolExportType);
}
}
/// <summary>
/// 是否导出(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsExported
{
get
{
return mbolIsExported;
}
set
{
 mbolIsExported = value;
//记录修改过的字段
 AddUpdatedFld(conFR_CodeSymbol.IsExported);
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
 AddUpdatedFld(conFR_CodeSymbol.LineStart);
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
 AddUpdatedFld(conFR_CodeSymbol.LineEnd);
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
 AddUpdatedFld(conFR_CodeSymbol.ColumnStart);
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
 AddUpdatedFld(conFR_CodeSymbol.ColumnEnd);
}
}
/// <summary>
/// 函数签名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Signature
{
get
{
return mstrSignature;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSignature = value;
}
else
{
 mstrSignature = value;
}
//记录修改过的字段
 AddUpdatedFld(conFR_CodeSymbol.Signature);
}
}
/// <summary>
/// 文档注释(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DocComment
{
get
{
return mstrDocComment;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDocComment = value;
}
else
{
 mstrDocComment = value;
}
//记录修改过的字段
 AddUpdatedFld(conFR_CodeSymbol.DocComment);
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
 AddUpdatedFld(conFR_CodeSymbol.CreatedAt);
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
  return mlngSymbolId.ToString();
 }
 }
}
 /// <summary>
 /// FR_CodeSymbol(FR_CodeSymbol)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conFR_CodeSymbol
{
public const string _CurrTabName = "FR_CodeSymbol"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "SymbolId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"SymbolId", "FileResourceId", "SymbolName", "SymbolType", "SymbolExportType", "IsExported", "LineStart", "LineEnd", "ColumnStart", "ColumnEnd", "Signature", "DocComment", "CreatedAt"};
//以下是属性变量


 /// <summary>
 /// 常量:"SymbolId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SymbolId = "SymbolId";    //符号Id

 /// <summary>
 /// 常量:"FileResourceId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileResourceId = "FileResourceId";    //文件资源Id

 /// <summary>
 /// 常量:"SymbolName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SymbolName = "SymbolName";    //符号名称

 /// <summary>
 /// 常量:"SymbolType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SymbolType = "SymbolType";    //符号类型

 /// <summary>
 /// 常量:"SymbolExportType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SymbolExportType = "SymbolExportType";    //符号导出类型

 /// <summary>
 /// 常量:"IsExported"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsExported = "IsExported";    //是否导出

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
 /// 常量:"Signature"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Signature = "Signature";    //函数签名

 /// <summary>
 /// 常量:"DocComment"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DocComment = "DocComment";    //文档注释

 /// <summary>
 /// 常量:"CreatedAt"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreatedAt = "CreatedAt";    //建立时间
}

}