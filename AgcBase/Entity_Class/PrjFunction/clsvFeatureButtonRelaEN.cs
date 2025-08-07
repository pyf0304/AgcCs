
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFeatureButtonRelaEN
 表名:vFeatureButtonRela(00050428)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:27:41
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
 /// 表vFeatureButtonRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vFeatureButtonRela
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
public K_mId_vFeatureButtonRela(long lngmId)
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
 /// <returns>返回:[K_mId_vFeatureButtonRela]类型的对象</returns>
public static implicit operator K_mId_vFeatureButtonRela(long value)
{
return new K_mId_vFeatureButtonRela(value);
}
}
 /// <summary>
 /// v功能按钮关系(vFeatureButtonRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvFeatureButtonRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vFeatureButtonRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 15;
public static string[] _AttributeName = new string[] {"mId", "ApplicationTypeId", "ApplicationTypeName", "ApplicationTypeENName", "FeatureId", "FeatureName", "FeatureTypeName", "ButtonId", "ButtonName", "Text", "OrderNum", "EventFuncName", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected int mintApplicationTypeId;    //应用程序类型ID
protected string mstrApplicationTypeName;    //应用程序类型名称
protected string mstrApplicationTypeENName;    //应用类型英文名
protected string mstrFeatureId;    //功能Id
protected string mstrFeatureName;    //功能名称
protected string mstrFeatureTypeName;    //功能类型名称
protected string mstrButtonId;    //按钮Id
protected string mstrButtonName;    //按钮名称
protected string mstrText;    //文本
protected int mintOrderNum;    //序号
protected string mstrEventFuncName;    //事件函数名
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvFeatureButtonRelaEN()
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
public clsvFeatureButtonRelaEN(long lngmId)
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
if (strAttributeName  ==  convFeatureButtonRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convFeatureButtonRela.ApplicationTypeId)
{
return mintApplicationTypeId;
}
else if (strAttributeName  ==  convFeatureButtonRela.ApplicationTypeName)
{
return mstrApplicationTypeName;
}
else if (strAttributeName  ==  convFeatureButtonRela.ApplicationTypeENName)
{
return mstrApplicationTypeENName;
}
else if (strAttributeName  ==  convFeatureButtonRela.FeatureId)
{
return mstrFeatureId;
}
else if (strAttributeName  ==  convFeatureButtonRela.FeatureName)
{
return mstrFeatureName;
}
else if (strAttributeName  ==  convFeatureButtonRela.FeatureTypeName)
{
return mstrFeatureTypeName;
}
else if (strAttributeName  ==  convFeatureButtonRela.ButtonId)
{
return mstrButtonId;
}
else if (strAttributeName  ==  convFeatureButtonRela.ButtonName)
{
return mstrButtonName;
}
else if (strAttributeName  ==  convFeatureButtonRela.Text)
{
return mstrText;
}
else if (strAttributeName  ==  convFeatureButtonRela.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convFeatureButtonRela.EventFuncName)
{
return mstrEventFuncName;
}
else if (strAttributeName  ==  convFeatureButtonRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convFeatureButtonRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convFeatureButtonRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convFeatureButtonRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convFeatureButtonRela.mId);
}
else if (strAttributeName  ==  convFeatureButtonRela.ApplicationTypeId)
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convFeatureButtonRela.ApplicationTypeId);
}
else if (strAttributeName  ==  convFeatureButtonRela.ApplicationTypeName)
{
mstrApplicationTypeName = value.ToString();
 AddUpdatedFld(convFeatureButtonRela.ApplicationTypeName);
}
else if (strAttributeName  ==  convFeatureButtonRela.ApplicationTypeENName)
{
mstrApplicationTypeENName = value.ToString();
 AddUpdatedFld(convFeatureButtonRela.ApplicationTypeENName);
}
else if (strAttributeName  ==  convFeatureButtonRela.FeatureId)
{
mstrFeatureId = value.ToString();
 AddUpdatedFld(convFeatureButtonRela.FeatureId);
}
else if (strAttributeName  ==  convFeatureButtonRela.FeatureName)
{
mstrFeatureName = value.ToString();
 AddUpdatedFld(convFeatureButtonRela.FeatureName);
}
else if (strAttributeName  ==  convFeatureButtonRela.FeatureTypeName)
{
mstrFeatureTypeName = value.ToString();
 AddUpdatedFld(convFeatureButtonRela.FeatureTypeName);
}
else if (strAttributeName  ==  convFeatureButtonRela.ButtonId)
{
mstrButtonId = value.ToString();
 AddUpdatedFld(convFeatureButtonRela.ButtonId);
}
else if (strAttributeName  ==  convFeatureButtonRela.ButtonName)
{
mstrButtonName = value.ToString();
 AddUpdatedFld(convFeatureButtonRela.ButtonName);
}
else if (strAttributeName  ==  convFeatureButtonRela.Text)
{
mstrText = value.ToString();
 AddUpdatedFld(convFeatureButtonRela.Text);
}
else if (strAttributeName  ==  convFeatureButtonRela.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFeatureButtonRela.OrderNum);
}
else if (strAttributeName  ==  convFeatureButtonRela.EventFuncName)
{
mstrEventFuncName = value.ToString();
 AddUpdatedFld(convFeatureButtonRela.EventFuncName);
}
else if (strAttributeName  ==  convFeatureButtonRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFeatureButtonRela.UpdDate);
}
else if (strAttributeName  ==  convFeatureButtonRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFeatureButtonRela.UpdUser);
}
else if (strAttributeName  ==  convFeatureButtonRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFeatureButtonRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convFeatureButtonRela.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (convFeatureButtonRela.ApplicationTypeId  ==  _AttributeName[intIndex])
{
return mintApplicationTypeId;
}
else if (convFeatureButtonRela.ApplicationTypeName  ==  _AttributeName[intIndex])
{
return mstrApplicationTypeName;
}
else if (convFeatureButtonRela.ApplicationTypeENName  ==  _AttributeName[intIndex])
{
return mstrApplicationTypeENName;
}
else if (convFeatureButtonRela.FeatureId  ==  _AttributeName[intIndex])
{
return mstrFeatureId;
}
else if (convFeatureButtonRela.FeatureName  ==  _AttributeName[intIndex])
{
return mstrFeatureName;
}
else if (convFeatureButtonRela.FeatureTypeName  ==  _AttributeName[intIndex])
{
return mstrFeatureTypeName;
}
else if (convFeatureButtonRela.ButtonId  ==  _AttributeName[intIndex])
{
return mstrButtonId;
}
else if (convFeatureButtonRela.ButtonName  ==  _AttributeName[intIndex])
{
return mstrButtonName;
}
else if (convFeatureButtonRela.Text  ==  _AttributeName[intIndex])
{
return mstrText;
}
else if (convFeatureButtonRela.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convFeatureButtonRela.EventFuncName  ==  _AttributeName[intIndex])
{
return mstrEventFuncName;
}
else if (convFeatureButtonRela.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convFeatureButtonRela.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convFeatureButtonRela.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convFeatureButtonRela.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convFeatureButtonRela.mId);
}
else if (convFeatureButtonRela.ApplicationTypeId  ==  _AttributeName[intIndex])
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convFeatureButtonRela.ApplicationTypeId);
}
else if (convFeatureButtonRela.ApplicationTypeName  ==  _AttributeName[intIndex])
{
mstrApplicationTypeName = value.ToString();
 AddUpdatedFld(convFeatureButtonRela.ApplicationTypeName);
}
else if (convFeatureButtonRela.ApplicationTypeENName  ==  _AttributeName[intIndex])
{
mstrApplicationTypeENName = value.ToString();
 AddUpdatedFld(convFeatureButtonRela.ApplicationTypeENName);
}
else if (convFeatureButtonRela.FeatureId  ==  _AttributeName[intIndex])
{
mstrFeatureId = value.ToString();
 AddUpdatedFld(convFeatureButtonRela.FeatureId);
}
else if (convFeatureButtonRela.FeatureName  ==  _AttributeName[intIndex])
{
mstrFeatureName = value.ToString();
 AddUpdatedFld(convFeatureButtonRela.FeatureName);
}
else if (convFeatureButtonRela.FeatureTypeName  ==  _AttributeName[intIndex])
{
mstrFeatureTypeName = value.ToString();
 AddUpdatedFld(convFeatureButtonRela.FeatureTypeName);
}
else if (convFeatureButtonRela.ButtonId  ==  _AttributeName[intIndex])
{
mstrButtonId = value.ToString();
 AddUpdatedFld(convFeatureButtonRela.ButtonId);
}
else if (convFeatureButtonRela.ButtonName  ==  _AttributeName[intIndex])
{
mstrButtonName = value.ToString();
 AddUpdatedFld(convFeatureButtonRela.ButtonName);
}
else if (convFeatureButtonRela.Text  ==  _AttributeName[intIndex])
{
mstrText = value.ToString();
 AddUpdatedFld(convFeatureButtonRela.Text);
}
else if (convFeatureButtonRela.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFeatureButtonRela.OrderNum);
}
else if (convFeatureButtonRela.EventFuncName  ==  _AttributeName[intIndex])
{
mstrEventFuncName = value.ToString();
 AddUpdatedFld(convFeatureButtonRela.EventFuncName);
}
else if (convFeatureButtonRela.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFeatureButtonRela.UpdDate);
}
else if (convFeatureButtonRela.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFeatureButtonRela.UpdUser);
}
else if (convFeatureButtonRela.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFeatureButtonRela.Memo);
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
 AddUpdatedFld(convFeatureButtonRela.mId);
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
 AddUpdatedFld(convFeatureButtonRela.ApplicationTypeId);
}
}
/// <summary>
/// 应用程序类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ApplicationTypeName
{
get
{
return mstrApplicationTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrApplicationTypeName = value;
}
else
{
 mstrApplicationTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureButtonRela.ApplicationTypeName);
}
}
/// <summary>
/// 应用类型英文名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ApplicationTypeENName
{
get
{
return mstrApplicationTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrApplicationTypeENName = value;
}
else
{
 mstrApplicationTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureButtonRela.ApplicationTypeENName);
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
 AddUpdatedFld(convFeatureButtonRela.FeatureId);
}
}
/// <summary>
/// 功能名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FeatureName
{
get
{
return mstrFeatureName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFeatureName = value;
}
else
{
 mstrFeatureName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureButtonRela.FeatureName);
}
}
/// <summary>
/// 功能类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FeatureTypeName
{
get
{
return mstrFeatureTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFeatureTypeName = value;
}
else
{
 mstrFeatureTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureButtonRela.FeatureTypeName);
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
 AddUpdatedFld(convFeatureButtonRela.ButtonId);
}
}
/// <summary>
/// 按钮名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ButtonName
{
get
{
return mstrButtonName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrButtonName = value;
}
else
{
 mstrButtonName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureButtonRela.ButtonName);
}
}
/// <summary>
/// 文本(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Text
{
get
{
return mstrText;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrText = value;
}
else
{
 mstrText = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureButtonRela.Text);
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
 AddUpdatedFld(convFeatureButtonRela.OrderNum);
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
 AddUpdatedFld(convFeatureButtonRela.EventFuncName);
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
 AddUpdatedFld(convFeatureButtonRela.UpdDate);
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
 AddUpdatedFld(convFeatureButtonRela.UpdUser);
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
 AddUpdatedFld(convFeatureButtonRela.Memo);
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
 /// v功能按钮关系(vFeatureButtonRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convFeatureButtonRela
{
public const string _CurrTabName = "vFeatureButtonRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "ApplicationTypeId", "ApplicationTypeName", "ApplicationTypeENName", "FeatureId", "FeatureName", "FeatureTypeName", "ButtonId", "ButtonName", "Text", "OrderNum", "EventFuncName", "UpdDate", "UpdUser", "Memo"};
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
 /// 常量:"ApplicationTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeName = "ApplicationTypeName";    //应用程序类型名称

 /// <summary>
 /// 常量:"ApplicationTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeENName = "ApplicationTypeENName";    //应用类型英文名

 /// <summary>
 /// 常量:"FeatureId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeatureId = "FeatureId";    //功能Id

 /// <summary>
 /// 常量:"FeatureName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeatureName = "FeatureName";    //功能名称

 /// <summary>
 /// 常量:"FeatureTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeatureTypeName = "FeatureTypeName";    //功能类型名称

 /// <summary>
 /// 常量:"ButtonId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ButtonId = "ButtonId";    //按钮Id

 /// <summary>
 /// 常量:"ButtonName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ButtonName = "ButtonName";    //按钮名称

 /// <summary>
 /// 常量:"Text"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Text = "Text";    //文本

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

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