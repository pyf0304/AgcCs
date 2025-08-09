
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFeatureButtonRelaEN
 表名:FeatureButtonRela(00050426)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:01:01
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
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
 /// 表FeatureButtonRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_FeatureButtonRela
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
public K_mId_FeatureButtonRela(long lngmId)
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
 /// <returns>返回:[K_mId_FeatureButtonRela]类型的对象</returns>
public static implicit operator K_mId_FeatureButtonRela(long value)
{
return new K_mId_FeatureButtonRela(value);
}
}
 /// <summary>
 /// 功能按钮关系(FeatureButtonRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsFeatureButtonRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "FeatureButtonRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 8;
public static string[] _AttributeName = new string[] {"mId", "ApplicationTypeId", "FeatureId", "ButtonId", "EventFuncName", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected int mintApplicationTypeId;    //应用程序类型ID
protected string mstrFeatureId;    //功能Id
protected string mstrButtonId;    //按钮Id
protected string mstrEventFuncName;    //事件函数名
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsFeatureButtonRelaEN()
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
public clsFeatureButtonRelaEN(long lngmId)
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
if (strAttributeName  ==  conFeatureButtonRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conFeatureButtonRela.ApplicationTypeId)
{
return mintApplicationTypeId;
}
else if (strAttributeName  ==  conFeatureButtonRela.FeatureId)
{
return mstrFeatureId;
}
else if (strAttributeName  ==  conFeatureButtonRela.ButtonId)
{
return mstrButtonId;
}
else if (strAttributeName  ==  conFeatureButtonRela.EventFuncName)
{
return mstrEventFuncName;
}
else if (strAttributeName  ==  conFeatureButtonRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conFeatureButtonRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conFeatureButtonRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conFeatureButtonRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conFeatureButtonRela.mId);
}
else if (strAttributeName  ==  conFeatureButtonRela.ApplicationTypeId)
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conFeatureButtonRela.ApplicationTypeId);
}
else if (strAttributeName  ==  conFeatureButtonRela.FeatureId)
{
mstrFeatureId = value.ToString();
 AddUpdatedFld(conFeatureButtonRela.FeatureId);
}
else if (strAttributeName  ==  conFeatureButtonRela.ButtonId)
{
mstrButtonId = value.ToString();
 AddUpdatedFld(conFeatureButtonRela.ButtonId);
}
else if (strAttributeName  ==  conFeatureButtonRela.EventFuncName)
{
mstrEventFuncName = value.ToString();
 AddUpdatedFld(conFeatureButtonRela.EventFuncName);
}
else if (strAttributeName  ==  conFeatureButtonRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFeatureButtonRela.UpdDate);
}
else if (strAttributeName  ==  conFeatureButtonRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conFeatureButtonRela.UpdUser);
}
else if (strAttributeName  ==  conFeatureButtonRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFeatureButtonRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conFeatureButtonRela.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (conFeatureButtonRela.ApplicationTypeId  ==  _AttributeName[intIndex])
{
return mintApplicationTypeId;
}
else if (conFeatureButtonRela.FeatureId  ==  _AttributeName[intIndex])
{
return mstrFeatureId;
}
else if (conFeatureButtonRela.ButtonId  ==  _AttributeName[intIndex])
{
return mstrButtonId;
}
else if (conFeatureButtonRela.EventFuncName  ==  _AttributeName[intIndex])
{
return mstrEventFuncName;
}
else if (conFeatureButtonRela.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conFeatureButtonRela.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conFeatureButtonRela.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conFeatureButtonRela.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conFeatureButtonRela.mId);
}
else if (conFeatureButtonRela.ApplicationTypeId  ==  _AttributeName[intIndex])
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conFeatureButtonRela.ApplicationTypeId);
}
else if (conFeatureButtonRela.FeatureId  ==  _AttributeName[intIndex])
{
mstrFeatureId = value.ToString();
 AddUpdatedFld(conFeatureButtonRela.FeatureId);
}
else if (conFeatureButtonRela.ButtonId  ==  _AttributeName[intIndex])
{
mstrButtonId = value.ToString();
 AddUpdatedFld(conFeatureButtonRela.ButtonId);
}
else if (conFeatureButtonRela.EventFuncName  ==  _AttributeName[intIndex])
{
mstrEventFuncName = value.ToString();
 AddUpdatedFld(conFeatureButtonRela.EventFuncName);
}
else if (conFeatureButtonRela.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFeatureButtonRela.UpdDate);
}
else if (conFeatureButtonRela.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conFeatureButtonRela.UpdUser);
}
else if (conFeatureButtonRela.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFeatureButtonRela.Memo);
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
 AddUpdatedFld(conFeatureButtonRela.mId);
}
}
/// <summary>
/// 应用程序类型ID(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int ApplicationTypeId
{
get
{
return mintApplicationTypeId;
}
set
{
 mintApplicationTypeId = value;
//记录修改过的字段
 AddUpdatedFld(conFeatureButtonRela.ApplicationTypeId);
}
}
/// <summary>
/// 功能Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FeatureId
{
get
{
return mstrFeatureId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFeatureId = value;
}
else
{
 mstrFeatureId = value;
}
//记录修改过的字段
 AddUpdatedFld(conFeatureButtonRela.FeatureId);
}
}
/// <summary>
/// 按钮Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ButtonId
{
get
{
return mstrButtonId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrButtonId = value;
}
else
{
 mstrButtonId = value;
}
//记录修改过的字段
 AddUpdatedFld(conFeatureButtonRela.ButtonId);
}
}
/// <summary>
/// 事件函数名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EventFuncName
{
get
{
return mstrEventFuncName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEventFuncName = value;
}
else
{
 mstrEventFuncName = value;
}
//记录修改过的字段
 AddUpdatedFld(conFeatureButtonRela.EventFuncName);
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
 AddUpdatedFld(conFeatureButtonRela.UpdDate);
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
 AddUpdatedFld(conFeatureButtonRela.UpdUser);
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
 AddUpdatedFld(conFeatureButtonRela.Memo);
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
 /// 功能按钮关系(FeatureButtonRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conFeatureButtonRela
{
public const string _CurrTabName = "FeatureButtonRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "ApplicationTypeId", "FeatureId", "ButtonId", "EventFuncName", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"ApplicationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeId = "ApplicationTypeId";    //应用程序类型ID

 /// <summary>
 /// 常量:"FeatureId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeatureId = "FeatureId";    //功能Id

 /// <summary>
 /// 常量:"ButtonId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ButtonId = "ButtonId";    //按钮Id

 /// <summary>
 /// 常量:"EventFuncName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EventFuncName = "EventFuncName";    //事件函数名

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
}

}