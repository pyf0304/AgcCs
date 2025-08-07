
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjUserCharEncodingRelaEN
 表名:vPrjUserCharEncodingRela(00050265)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:36:54
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统设置(SystemSet)
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
 /// 表vPrjUserCharEncodingRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vPrjUserCharEncodingRela
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
public K_mId_vPrjUserCharEncodingRela(long lngmId)
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
 /// <returns>返回:[K_mId_vPrjUserCharEncodingRela]类型的对象</returns>
public static implicit operator K_mId_vPrjUserCharEncodingRela(long value)
{
return new K_mId_vPrjUserCharEncodingRela(value);
}
}
 /// <summary>
 /// v项目用户字符编码关系(vPrjUserCharEncodingRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvPrjUserCharEncodingRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vPrjUserCharEncodingRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 10;
public static string[] _AttributeName = new string[] {"mId", "PrjId", "PrjName", "UserId", "UserName", "CharEncodingId", "CharEncodingName", "UpdUserId", "UpdDate", "Memo"};

protected long mlngmId;    //mId
protected string mstrPrjId;    //工程Id
protected string mstrPrjName;    //工程名称
protected string mstrUserId;    //用户Id
protected string mstrUserName;    //用户名
protected string mstrCharEncodingId;    //字符编码
protected string mstrCharEncodingName;    //字符编码名称
protected string mstrUpdUserId;    //修改用户Id
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvPrjUserCharEncodingRelaEN()
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
public clsvPrjUserCharEncodingRelaEN(long lngmId)
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
if (strAttributeName  ==  convPrjUserCharEncodingRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convPrjUserCharEncodingRela.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convPrjUserCharEncodingRela.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convPrjUserCharEncodingRela.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convPrjUserCharEncodingRela.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convPrjUserCharEncodingRela.CharEncodingId)
{
return mstrCharEncodingId;
}
else if (strAttributeName  ==  convPrjUserCharEncodingRela.CharEncodingName)
{
return mstrCharEncodingName;
}
else if (strAttributeName  ==  convPrjUserCharEncodingRela.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convPrjUserCharEncodingRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convPrjUserCharEncodingRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convPrjUserCharEncodingRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convPrjUserCharEncodingRela.mId);
}
else if (strAttributeName  ==  convPrjUserCharEncodingRela.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convPrjUserCharEncodingRela.PrjId);
}
else if (strAttributeName  ==  convPrjUserCharEncodingRela.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convPrjUserCharEncodingRela.PrjName);
}
else if (strAttributeName  ==  convPrjUserCharEncodingRela.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convPrjUserCharEncodingRela.UserId);
}
else if (strAttributeName  ==  convPrjUserCharEncodingRela.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convPrjUserCharEncodingRela.UserName);
}
else if (strAttributeName  ==  convPrjUserCharEncodingRela.CharEncodingId)
{
mstrCharEncodingId = value.ToString();
 AddUpdatedFld(convPrjUserCharEncodingRela.CharEncodingId);
}
else if (strAttributeName  ==  convPrjUserCharEncodingRela.CharEncodingName)
{
mstrCharEncodingName = value.ToString();
 AddUpdatedFld(convPrjUserCharEncodingRela.CharEncodingName);
}
else if (strAttributeName  ==  convPrjUserCharEncodingRela.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convPrjUserCharEncodingRela.UpdUserId);
}
else if (strAttributeName  ==  convPrjUserCharEncodingRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convPrjUserCharEncodingRela.UpdDate);
}
else if (strAttributeName  ==  convPrjUserCharEncodingRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convPrjUserCharEncodingRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convPrjUserCharEncodingRela.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (convPrjUserCharEncodingRela.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convPrjUserCharEncodingRela.PrjName  ==  _AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convPrjUserCharEncodingRela.UserId  ==  _AttributeName[intIndex])
{
return mstrUserId;
}
else if (convPrjUserCharEncodingRela.UserName  ==  _AttributeName[intIndex])
{
return mstrUserName;
}
else if (convPrjUserCharEncodingRela.CharEncodingId  ==  _AttributeName[intIndex])
{
return mstrCharEncodingId;
}
else if (convPrjUserCharEncodingRela.CharEncodingName  ==  _AttributeName[intIndex])
{
return mstrCharEncodingName;
}
else if (convPrjUserCharEncodingRela.UpdUserId  ==  _AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convPrjUserCharEncodingRela.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convPrjUserCharEncodingRela.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convPrjUserCharEncodingRela.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convPrjUserCharEncodingRela.mId);
}
else if (convPrjUserCharEncodingRela.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convPrjUserCharEncodingRela.PrjId);
}
else if (convPrjUserCharEncodingRela.PrjName  ==  _AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convPrjUserCharEncodingRela.PrjName);
}
else if (convPrjUserCharEncodingRela.UserId  ==  _AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convPrjUserCharEncodingRela.UserId);
}
else if (convPrjUserCharEncodingRela.UserName  ==  _AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convPrjUserCharEncodingRela.UserName);
}
else if (convPrjUserCharEncodingRela.CharEncodingId  ==  _AttributeName[intIndex])
{
mstrCharEncodingId = value.ToString();
 AddUpdatedFld(convPrjUserCharEncodingRela.CharEncodingId);
}
else if (convPrjUserCharEncodingRela.CharEncodingName  ==  _AttributeName[intIndex])
{
mstrCharEncodingName = value.ToString();
 AddUpdatedFld(convPrjUserCharEncodingRela.CharEncodingName);
}
else if (convPrjUserCharEncodingRela.UpdUserId  ==  _AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convPrjUserCharEncodingRela.UpdUserId);
}
else if (convPrjUserCharEncodingRela.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convPrjUserCharEncodingRela.UpdDate);
}
else if (convPrjUserCharEncodingRela.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convPrjUserCharEncodingRela.Memo);
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
 AddUpdatedFld(convPrjUserCharEncodingRela.mId);
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
 AddUpdatedFld(convPrjUserCharEncodingRela.PrjId);
}
}
/// <summary>
/// 工程名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjName
{
get
{
return mstrPrjName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjName = value;
}
else
{
 mstrPrjName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjUserCharEncodingRela.PrjName);
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
 AddUpdatedFld(convPrjUserCharEncodingRela.UserId);
}
}
/// <summary>
/// 用户名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserName
{
get
{
return mstrUserName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserName = value;
}
else
{
 mstrUserName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjUserCharEncodingRela.UserName);
}
}
/// <summary>
/// 字符编码(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CharEncodingId
{
get
{
return mstrCharEncodingId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCharEncodingId = value;
}
else
{
 mstrCharEncodingId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjUserCharEncodingRela.CharEncodingId);
}
}
/// <summary>
/// 字符编码名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CharEncodingName
{
get
{
return mstrCharEncodingName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCharEncodingName = value;
}
else
{
 mstrCharEncodingName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjUserCharEncodingRela.CharEncodingName);
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
 AddUpdatedFld(convPrjUserCharEncodingRela.UpdUserId);
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
 AddUpdatedFld(convPrjUserCharEncodingRela.UpdDate);
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
 AddUpdatedFld(convPrjUserCharEncodingRela.Memo);
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
 /// v项目用户字符编码关系(vPrjUserCharEncodingRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convPrjUserCharEncodingRela
{
public const string _CurrTabName = "vPrjUserCharEncodingRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "PrjId", "PrjName", "UserId", "UserName", "CharEncodingId", "CharEncodingName", "UpdUserId", "UpdDate", "Memo"};
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
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"PrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjName = "PrjName";    //工程名称

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户Id

 /// <summary>
 /// 常量:"UserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserName = "UserName";    //用户名

 /// <summary>
 /// 常量:"CharEncodingId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CharEncodingId = "CharEncodingId";    //字符编码

 /// <summary>
 /// 常量:"CharEncodingName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CharEncodingName = "CharEncodingName";    //字符编码名称

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

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
}

}