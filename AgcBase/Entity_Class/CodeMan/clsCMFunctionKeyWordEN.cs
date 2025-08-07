
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCMFunctionKeyWordEN
 表名:CMFunctionKeyWord(00050515)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:34:02
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:代码管理(CodeMan)
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
 /// 表CMFunctionKeyWord的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_CMFunctionKeyWord
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
public K_mId_CMFunctionKeyWord(long lngmId)
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
 /// <returns>返回:[K_mId_CMFunctionKeyWord]类型的对象</returns>
public static implicit operator K_mId_CMFunctionKeyWord(long value)
{
return new K_mId_CMFunctionKeyWord(value);
}
}
 /// <summary>
 /// CM函数关键字(CMFunctionKeyWord)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCMFunctionKeyWordEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CMFunctionKeyWord"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 13;
public static string[] _AttributeName = new string[] {"mId", "CmFunctionId", "Keyword", "UpdDate", "UpdUser", "Memo", "IsSynchToServer", "SynchToServerDate", "SynchToServerUser", "IsSynchToClient", "SynchToClientDate", "SynchToClientUser", "SynSource"};

protected long mlngmId;    //mId
protected string mstrCmFunctionId;    //函数Id
protected string mstrKeyword;    //关键字
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明
protected bool mbolIsSynchToServer;    //是否同步到Server
protected string mstrSynchToServerDate;    //同步到Server日期
protected string mstrSynchToServerUser;    //同步到Server用户
protected bool mbolIsSynchToClient;    //是否同步到Client
protected string mstrSynchToClientDate;    //同步到Client库日期
protected string mstrSynchToClientUser;    //同步到Client库用户
protected string mstrSynSource;    //同步来源

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsCMFunctionKeyWordEN()
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
public clsCMFunctionKeyWordEN(long lngmId)
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
if (strAttributeName  ==  conCMFunctionKeyWord.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conCMFunctionKeyWord.CmFunctionId)
{
return mstrCmFunctionId;
}
else if (strAttributeName  ==  conCMFunctionKeyWord.Keyword)
{
return mstrKeyword;
}
else if (strAttributeName  ==  conCMFunctionKeyWord.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conCMFunctionKeyWord.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conCMFunctionKeyWord.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conCMFunctionKeyWord.IsSynchToServer)
{
return mbolIsSynchToServer;
}
else if (strAttributeName  ==  conCMFunctionKeyWord.SynchToServerDate)
{
return mstrSynchToServerDate;
}
else if (strAttributeName  ==  conCMFunctionKeyWord.SynchToServerUser)
{
return mstrSynchToServerUser;
}
else if (strAttributeName  ==  conCMFunctionKeyWord.IsSynchToClient)
{
return mbolIsSynchToClient;
}
else if (strAttributeName  ==  conCMFunctionKeyWord.SynchToClientDate)
{
return mstrSynchToClientDate;
}
else if (strAttributeName  ==  conCMFunctionKeyWord.SynchToClientUser)
{
return mstrSynchToClientUser;
}
else if (strAttributeName  ==  conCMFunctionKeyWord.SynSource)
{
return mstrSynSource;
}
return null;
}
set
{
if (strAttributeName  ==  conCMFunctionKeyWord.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conCMFunctionKeyWord.mId);
}
else if (strAttributeName  ==  conCMFunctionKeyWord.CmFunctionId)
{
mstrCmFunctionId = value.ToString();
 AddUpdatedFld(conCMFunctionKeyWord.CmFunctionId);
}
else if (strAttributeName  ==  conCMFunctionKeyWord.Keyword)
{
mstrKeyword = value.ToString();
 AddUpdatedFld(conCMFunctionKeyWord.Keyword);
}
else if (strAttributeName  ==  conCMFunctionKeyWord.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCMFunctionKeyWord.UpdDate);
}
else if (strAttributeName  ==  conCMFunctionKeyWord.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conCMFunctionKeyWord.UpdUser);
}
else if (strAttributeName  ==  conCMFunctionKeyWord.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCMFunctionKeyWord.Memo);
}
else if (strAttributeName  ==  conCMFunctionKeyWord.IsSynchToServer)
{
mbolIsSynchToServer = TransNullToBool(value.ToString());
 AddUpdatedFld(conCMFunctionKeyWord.IsSynchToServer);
}
else if (strAttributeName  ==  conCMFunctionKeyWord.SynchToServerDate)
{
mstrSynchToServerDate = value.ToString();
 AddUpdatedFld(conCMFunctionKeyWord.SynchToServerDate);
}
else if (strAttributeName  ==  conCMFunctionKeyWord.SynchToServerUser)
{
mstrSynchToServerUser = value.ToString();
 AddUpdatedFld(conCMFunctionKeyWord.SynchToServerUser);
}
else if (strAttributeName  ==  conCMFunctionKeyWord.IsSynchToClient)
{
mbolIsSynchToClient = TransNullToBool(value.ToString());
 AddUpdatedFld(conCMFunctionKeyWord.IsSynchToClient);
}
else if (strAttributeName  ==  conCMFunctionKeyWord.SynchToClientDate)
{
mstrSynchToClientDate = value.ToString();
 AddUpdatedFld(conCMFunctionKeyWord.SynchToClientDate);
}
else if (strAttributeName  ==  conCMFunctionKeyWord.SynchToClientUser)
{
mstrSynchToClientUser = value.ToString();
 AddUpdatedFld(conCMFunctionKeyWord.SynchToClientUser);
}
else if (strAttributeName  ==  conCMFunctionKeyWord.SynSource)
{
mstrSynSource = value.ToString();
 AddUpdatedFld(conCMFunctionKeyWord.SynSource);
}
}
}
public object this[int intIndex]
{
get
{
if (conCMFunctionKeyWord.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (conCMFunctionKeyWord.CmFunctionId  ==  _AttributeName[intIndex])
{
return mstrCmFunctionId;
}
else if (conCMFunctionKeyWord.Keyword  ==  _AttributeName[intIndex])
{
return mstrKeyword;
}
else if (conCMFunctionKeyWord.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conCMFunctionKeyWord.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conCMFunctionKeyWord.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (conCMFunctionKeyWord.IsSynchToServer  ==  _AttributeName[intIndex])
{
return mbolIsSynchToServer;
}
else if (conCMFunctionKeyWord.SynchToServerDate  ==  _AttributeName[intIndex])
{
return mstrSynchToServerDate;
}
else if (conCMFunctionKeyWord.SynchToServerUser  ==  _AttributeName[intIndex])
{
return mstrSynchToServerUser;
}
else if (conCMFunctionKeyWord.IsSynchToClient  ==  _AttributeName[intIndex])
{
return mbolIsSynchToClient;
}
else if (conCMFunctionKeyWord.SynchToClientDate  ==  _AttributeName[intIndex])
{
return mstrSynchToClientDate;
}
else if (conCMFunctionKeyWord.SynchToClientUser  ==  _AttributeName[intIndex])
{
return mstrSynchToClientUser;
}
else if (conCMFunctionKeyWord.SynSource  ==  _AttributeName[intIndex])
{
return mstrSynSource;
}
return null;
}
set
{
if (conCMFunctionKeyWord.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conCMFunctionKeyWord.mId);
}
else if (conCMFunctionKeyWord.CmFunctionId  ==  _AttributeName[intIndex])
{
mstrCmFunctionId = value.ToString();
 AddUpdatedFld(conCMFunctionKeyWord.CmFunctionId);
}
else if (conCMFunctionKeyWord.Keyword  ==  _AttributeName[intIndex])
{
mstrKeyword = value.ToString();
 AddUpdatedFld(conCMFunctionKeyWord.Keyword);
}
else if (conCMFunctionKeyWord.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCMFunctionKeyWord.UpdDate);
}
else if (conCMFunctionKeyWord.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conCMFunctionKeyWord.UpdUser);
}
else if (conCMFunctionKeyWord.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCMFunctionKeyWord.Memo);
}
else if (conCMFunctionKeyWord.IsSynchToServer  ==  _AttributeName[intIndex])
{
mbolIsSynchToServer = TransNullToBool(value.ToString());
 AddUpdatedFld(conCMFunctionKeyWord.IsSynchToServer);
}
else if (conCMFunctionKeyWord.SynchToServerDate  ==  _AttributeName[intIndex])
{
mstrSynchToServerDate = value.ToString();
 AddUpdatedFld(conCMFunctionKeyWord.SynchToServerDate);
}
else if (conCMFunctionKeyWord.SynchToServerUser  ==  _AttributeName[intIndex])
{
mstrSynchToServerUser = value.ToString();
 AddUpdatedFld(conCMFunctionKeyWord.SynchToServerUser);
}
else if (conCMFunctionKeyWord.IsSynchToClient  ==  _AttributeName[intIndex])
{
mbolIsSynchToClient = TransNullToBool(value.ToString());
 AddUpdatedFld(conCMFunctionKeyWord.IsSynchToClient);
}
else if (conCMFunctionKeyWord.SynchToClientDate  ==  _AttributeName[intIndex])
{
mstrSynchToClientDate = value.ToString();
 AddUpdatedFld(conCMFunctionKeyWord.SynchToClientDate);
}
else if (conCMFunctionKeyWord.SynchToClientUser  ==  _AttributeName[intIndex])
{
mstrSynchToClientUser = value.ToString();
 AddUpdatedFld(conCMFunctionKeyWord.SynchToClientUser);
}
else if (conCMFunctionKeyWord.SynSource  ==  _AttributeName[intIndex])
{
mstrSynSource = value.ToString();
 AddUpdatedFld(conCMFunctionKeyWord.SynSource);
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
 AddUpdatedFld(conCMFunctionKeyWord.mId);
}
}
/// <summary>
/// 函数Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CmFunctionId
{
get
{
return mstrCmFunctionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCmFunctionId = value;
}
else
{
 mstrCmFunctionId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCMFunctionKeyWord.CmFunctionId);
}
}
/// <summary>
/// 关键字(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Keyword
{
get
{
return mstrKeyword;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeyword = value;
}
else
{
 mstrKeyword = value;
}
//记录修改过的字段
 AddUpdatedFld(conCMFunctionKeyWord.Keyword);
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
 AddUpdatedFld(conCMFunctionKeyWord.UpdDate);
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
 AddUpdatedFld(conCMFunctionKeyWord.UpdUser);
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
 AddUpdatedFld(conCMFunctionKeyWord.Memo);
}
}
/// <summary>
/// 是否同步到Server(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsSynchToServer
{
get
{
return mbolIsSynchToServer;
}
set
{
 mbolIsSynchToServer = value;
//记录修改过的字段
 AddUpdatedFld(conCMFunctionKeyWord.IsSynchToServer);
}
}
/// <summary>
/// 同步到Server日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SynchToServerDate
{
get
{
return mstrSynchToServerDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSynchToServerDate = value;
}
else
{
 mstrSynchToServerDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conCMFunctionKeyWord.SynchToServerDate);
}
}
/// <summary>
/// 同步到Server用户(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SynchToServerUser
{
get
{
return mstrSynchToServerUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSynchToServerUser = value;
}
else
{
 mstrSynchToServerUser = value;
}
//记录修改过的字段
 AddUpdatedFld(conCMFunctionKeyWord.SynchToServerUser);
}
}
/// <summary>
/// 是否同步到Client(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsSynchToClient
{
get
{
return mbolIsSynchToClient;
}
set
{
 mbolIsSynchToClient = value;
//记录修改过的字段
 AddUpdatedFld(conCMFunctionKeyWord.IsSynchToClient);
}
}
/// <summary>
/// 同步到Client库日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SynchToClientDate
{
get
{
return mstrSynchToClientDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSynchToClientDate = value;
}
else
{
 mstrSynchToClientDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conCMFunctionKeyWord.SynchToClientDate);
}
}
/// <summary>
/// 同步到Client库用户(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SynchToClientUser
{
get
{
return mstrSynchToClientUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSynchToClientUser = value;
}
else
{
 mstrSynchToClientUser = value;
}
//记录修改过的字段
 AddUpdatedFld(conCMFunctionKeyWord.SynchToClientUser);
}
}
/// <summary>
/// 同步来源(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SynSource
{
get
{
return mstrSynSource;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSynSource = value;
}
else
{
 mstrSynSource = value;
}
//记录修改过的字段
 AddUpdatedFld(conCMFunctionKeyWord.SynSource);
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
 /// CM函数关键字(CMFunctionKeyWord)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCMFunctionKeyWord
{
public const string _CurrTabName = "CMFunctionKeyWord"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "CmFunctionId", "Keyword", "UpdDate", "UpdUser", "Memo", "IsSynchToServer", "SynchToServerDate", "SynchToServerUser", "IsSynchToClient", "SynchToClientDate", "SynchToClientUser", "SynSource"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"CmFunctionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CmFunctionId = "CmFunctionId";    //函数Id

 /// <summary>
 /// 常量:"Keyword"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Keyword = "Keyword";    //关键字

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

 /// <summary>
 /// 常量:"IsSynchToServer"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSynchToServer = "IsSynchToServer";    //是否同步到Server

 /// <summary>
 /// 常量:"SynchToServerDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SynchToServerDate = "SynchToServerDate";    //同步到Server日期

 /// <summary>
 /// 常量:"SynchToServerUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SynchToServerUser = "SynchToServerUser";    //同步到Server用户

 /// <summary>
 /// 常量:"IsSynchToClient"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSynchToClient = "IsSynchToClient";    //是否同步到Client

 /// <summary>
 /// 常量:"SynchToClientDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SynchToClientDate = "SynchToClientDate";    //同步到Client库日期

 /// <summary>
 /// 常量:"SynchToClientUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SynchToClientUser = "SynchToClientUser";    //同步到Client库用户

 /// <summary>
 /// 常量:"SynSource"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SynSource = "SynSource";    //同步来源
}

}