
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsOptMemoEN
 表名:OptMemo(00050070)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:15:36
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:操作步骤管理(OpStepManage)
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
 /// 表OptMemo的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_OptMemo
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
public K_mId_OptMemo(long lngmId)
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
 /// <returns>返回:[K_mId_OptMemo]类型的对象</returns>
public static implicit operator K_mId_OptMemo(long value)
{
return new K_mId_OptMemo(value);
}
}
 /// <summary>
 /// OptMemo(OptMemo)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsOptMemoEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接，如果为空就使用系统默认的连接
public new const string _CurrTabName = "OptMemo"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string WhereFormat = ""; //条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"mId", "Author", "LinkFile", "Memo", "UpdDate"};

protected long mlngmId;    //mId
protected string mstrAuthor;    //Author
protected string mstrLinkFile;    //链接文件名
protected string mstrMemo;    //说明
protected string mstrUpdDate;    //修改日期

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsOptMemoEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "OptMemo";
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:mId</param>
public clsOptMemoEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "OptMemo";
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
if (strAttributeName  ==  conOptMemo.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conOptMemo.Author)
{
return mstrAuthor;
}
else if (strAttributeName  ==  conOptMemo.LinkFile)
{
return mstrLinkFile;
}
else if (strAttributeName  ==  conOptMemo.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conOptMemo.UpdDate)
{
return mstrUpdDate;
}
return null;
}
set
{
if (strAttributeName  ==  conOptMemo.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conOptMemo.mId);
}
else if (strAttributeName  ==  conOptMemo.Author)
{
mstrAuthor = value.ToString();
 AddUpdatedFld(conOptMemo.Author);
}
else if (strAttributeName  ==  conOptMemo.LinkFile)
{
mstrLinkFile = value.ToString();
 AddUpdatedFld(conOptMemo.LinkFile);
}
else if (strAttributeName  ==  conOptMemo.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conOptMemo.Memo);
}
else if (strAttributeName  ==  conOptMemo.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conOptMemo.UpdDate);
}
}
}
public object this[int intIndex]
{
get
{
if (conOptMemo.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conOptMemo.Author  ==  AttributeName[intIndex])
{
return mstrAuthor;
}
else if (conOptMemo.LinkFile  ==  AttributeName[intIndex])
{
return mstrLinkFile;
}
else if (conOptMemo.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conOptMemo.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
return null;
}
set
{
if (conOptMemo.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conOptMemo.mId);
}
else if (conOptMemo.Author  ==  AttributeName[intIndex])
{
mstrAuthor = value.ToString();
 AddUpdatedFld(conOptMemo.Author);
}
else if (conOptMemo.LinkFile  ==  AttributeName[intIndex])
{
mstrLinkFile = value.ToString();
 AddUpdatedFld(conOptMemo.LinkFile);
}
else if (conOptMemo.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conOptMemo.Memo);
}
else if (conOptMemo.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conOptMemo.UpdDate);
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
 AddUpdatedFld(conOptMemo.mId);
}
}
/// <summary>
/// Author(说明:;字段类型:varchar;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Author
{
get
{
return mstrAuthor;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAuthor = value;
}
else
{
 mstrAuthor = value;
}
//记录修改过的字段
 AddUpdatedFld(conOptMemo.Author);
}
}
/// <summary>
/// 链接文件名(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LinkFile
{
get
{
return mstrLinkFile;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLinkFile = value;
}
else
{
 mstrLinkFile = value;
}
//记录修改过的字段
 AddUpdatedFld(conOptMemo.LinkFile);
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
 AddUpdatedFld(conOptMemo.Memo);
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
 AddUpdatedFld(conOptMemo.UpdDate);
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
 /// OptMemo(OptMemo)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conOptMemo
{
public new const string _CurrTabName = "OptMemo"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "Author", "LinkFile", "Memo", "UpdDate"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"Author"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Author = "Author";    //Author

 /// <summary>
 /// 常量:"LinkFile"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LinkFile = "LinkFile";    //链接文件名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期
}

}