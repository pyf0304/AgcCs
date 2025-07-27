
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsElecDictEN
 表名:ElecDict(00050016)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:14:04
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:电子字典(ElecDict)
 框架-层名:实体层(CS)(EntityLayer)
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

namespace AGC.Entity
{
 /// <summary>
 /// 表ElecDict的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_ElecDict
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
public K_mId_ElecDict(long lngmId)
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
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_mId_ElecDict]类型的对象</returns>
public static implicit operator K_mId_ElecDict(long value)
{
return new K_mId_ElecDict(value);
}
}
 /// <summary>
 /// 电子字典(ElecDict)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsElecDictEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接，如果为空就使用系统默认的连接
public new const string _CurrTabName = "ElecDict"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string WhereFormat = ""; //条件格式串
protected const int mintAttributeCount = 6;
public static string[] AttributeName = new string[] {"mId", "PrjId", "ChineseWord", "EnglishWord", "WordTypeId", "Memo"};

protected long mlngmId;    //mId
protected string mstrPrjId;    //工程ID
protected string mstrChineseWord;    //中文单词
protected string mstrEnglishWord;    //英文单词
protected string mstrWordTypeId;    //单词分类ID
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsElecDictEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "ElecDict";
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:mId</param>
public clsElecDictEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "ElecDict";
 lstKeyFldNames.Add("mId");
 }

public static int AttributeCount
{
get
{
return mintAttributeCount;
}
}
public override object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  conElecDict.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conElecDict.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conElecDict.ChineseWord)
{
return mstrChineseWord;
}
else if (strAttributeName  ==  conElecDict.EnglishWord)
{
return mstrEnglishWord;
}
else if (strAttributeName  ==  conElecDict.WordTypeId)
{
return mstrWordTypeId;
}
else if (strAttributeName  ==  conElecDict.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conElecDict.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conElecDict.mId);
}
else if (strAttributeName  ==  conElecDict.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conElecDict.PrjId);
}
else if (strAttributeName  ==  conElecDict.ChineseWord)
{
mstrChineseWord = value.ToString();
 AddUpdatedFld(conElecDict.ChineseWord);
}
else if (strAttributeName  ==  conElecDict.EnglishWord)
{
mstrEnglishWord = value.ToString();
 AddUpdatedFld(conElecDict.EnglishWord);
}
else if (strAttributeName  ==  conElecDict.WordTypeId)
{
mstrWordTypeId = value.ToString();
 AddUpdatedFld(conElecDict.WordTypeId);
}
else if (strAttributeName  ==  conElecDict.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conElecDict.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conElecDict.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conElecDict.PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conElecDict.ChineseWord  ==  AttributeName[intIndex])
{
return mstrChineseWord;
}
else if (conElecDict.EnglishWord  ==  AttributeName[intIndex])
{
return mstrEnglishWord;
}
else if (conElecDict.WordTypeId  ==  AttributeName[intIndex])
{
return mstrWordTypeId;
}
else if (conElecDict.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conElecDict.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conElecDict.mId);
}
else if (conElecDict.PrjId  ==  AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conElecDict.PrjId);
}
else if (conElecDict.ChineseWord  ==  AttributeName[intIndex])
{
mstrChineseWord = value.ToString();
 AddUpdatedFld(conElecDict.ChineseWord);
}
else if (conElecDict.EnglishWord  ==  AttributeName[intIndex])
{
mstrEnglishWord = value.ToString();
 AddUpdatedFld(conElecDict.EnglishWord);
}
else if (conElecDict.WordTypeId  ==  AttributeName[intIndex])
{
mstrWordTypeId = value.ToString();
 AddUpdatedFld(conElecDict.WordTypeId);
}
else if (conElecDict.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conElecDict.Memo);
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
 AddUpdatedFld(conElecDict.mId);
}
}
/// <summary>
/// 工程ID(说明:;字段类型:char;字段长度:4;是否可空:False)
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
 AddUpdatedFld(conElecDict.PrjId);
}
}
/// <summary>
/// 中文单词(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ChineseWord
{
get
{
return mstrChineseWord;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrChineseWord = value;
}
else
{
 mstrChineseWord = value;
}
//记录修改过的字段
 AddUpdatedFld(conElecDict.ChineseWord);
}
}
/// <summary>
/// 英文单词(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EnglishWord
{
get
{
return mstrEnglishWord;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEnglishWord = value;
}
else
{
 mstrEnglishWord = value;
}
//记录修改过的字段
 AddUpdatedFld(conElecDict.EnglishWord);
}
}
/// <summary>
/// 单词分类ID(说明:;字段类型:varchar;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WordTypeId
{
get
{
return mstrWordTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWordTypeId = value;
}
else
{
 mstrWordTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conElecDict.WordTypeId);
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
 AddUpdatedFld(conElecDict.Memo);
}
}

/// <summary>
/// 获取关键字Id(keyId)
 /// (AutoGCLib.clsGeneCodeBase:GenGetKeyId)
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
 /// 电子字典(ElecDict)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conElecDict
{
public new const string _CurrTabName = "ElecDict"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "PrjId", "ChineseWord", "EnglishWord", "WordTypeId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程ID

 /// <summary>
 /// 常量:"ChineseWord"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ChineseWord = "ChineseWord";    //中文单词

 /// <summary>
 /// 常量:"EnglishWord"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EnglishWord = "EnglishWord";    //英文单词

 /// <summary>
 /// 常量:"WordTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WordTypeId = "WordTypeId";    //单词分类ID

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}