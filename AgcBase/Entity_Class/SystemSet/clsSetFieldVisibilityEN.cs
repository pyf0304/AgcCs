
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSetFieldVisibilityEN
 表名:SetFieldVisibility(00050242)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:06:27
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
 /// 表SetFieldVisibility的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_SetFieldVisibility
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
public K_mId_SetFieldVisibility(long lngmId)
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
 /// <returns>返回:[K_mId_SetFieldVisibility]类型的对象</returns>
public static implicit operator K_mId_SetFieldVisibility(long value)
{
return new K_mId_SetFieldVisibility(value);
}
}
 /// <summary>
 /// 设置字段可视性(SetFieldVisibility)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsSetFieldVisibilityEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "SetFieldVisibility"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 12;
public static string[] _AttributeName = new string[] {"mId", "IdSchool", "UserId", "ViewName", "FieldName", "Caption", "CtrlType", "IsVisible", "UpdDate", "UpdUserId", "Memo", "FuncModuleId"};

protected long mlngmId;    //mId
protected string mstrIdSchool;    //学校流水号
protected string mstrUserId;    //用户Id
protected string mstrViewName;    //界面名称
protected string mstrFieldName;    //字段名
protected string mstrCaption;    //标题
protected string mstrCtrlType;    //控件类型
protected bool mbolIsVisible;    //是否显示
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //说明
protected string mstrFuncModuleId;    //FuncModuleId

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsSetFieldVisibilityEN()
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
public clsSetFieldVisibilityEN(long lngmId)
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
if (strAttributeName  ==  conSetFieldVisibility.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conSetFieldVisibility.IdSchool)
{
return mstrIdSchool;
}
else if (strAttributeName  ==  conSetFieldVisibility.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conSetFieldVisibility.ViewName)
{
return mstrViewName;
}
else if (strAttributeName  ==  conSetFieldVisibility.FieldName)
{
return mstrFieldName;
}
else if (strAttributeName  ==  conSetFieldVisibility.Caption)
{
return mstrCaption;
}
else if (strAttributeName  ==  conSetFieldVisibility.CtrlType)
{
return mstrCtrlType;
}
else if (strAttributeName  ==  conSetFieldVisibility.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  conSetFieldVisibility.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conSetFieldVisibility.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conSetFieldVisibility.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conSetFieldVisibility.FuncModuleId)
{
return mstrFuncModuleId;
}
return null;
}
set
{
if (strAttributeName  ==  conSetFieldVisibility.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conSetFieldVisibility.mId);
}
else if (strAttributeName  ==  conSetFieldVisibility.IdSchool)
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(conSetFieldVisibility.IdSchool);
}
else if (strAttributeName  ==  conSetFieldVisibility.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conSetFieldVisibility.UserId);
}
else if (strAttributeName  ==  conSetFieldVisibility.ViewName)
{
mstrViewName = value.ToString();
 AddUpdatedFld(conSetFieldVisibility.ViewName);
}
else if (strAttributeName  ==  conSetFieldVisibility.FieldName)
{
mstrFieldName = value.ToString();
 AddUpdatedFld(conSetFieldVisibility.FieldName);
}
else if (strAttributeName  ==  conSetFieldVisibility.Caption)
{
mstrCaption = value.ToString();
 AddUpdatedFld(conSetFieldVisibility.Caption);
}
else if (strAttributeName  ==  conSetFieldVisibility.CtrlType)
{
mstrCtrlType = value.ToString();
 AddUpdatedFld(conSetFieldVisibility.CtrlType);
}
else if (strAttributeName  ==  conSetFieldVisibility.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conSetFieldVisibility.IsVisible);
}
else if (strAttributeName  ==  conSetFieldVisibility.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conSetFieldVisibility.UpdDate);
}
else if (strAttributeName  ==  conSetFieldVisibility.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conSetFieldVisibility.UpdUserId);
}
else if (strAttributeName  ==  conSetFieldVisibility.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSetFieldVisibility.Memo);
}
else if (strAttributeName  ==  conSetFieldVisibility.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(conSetFieldVisibility.FuncModuleId);
}
}
}
public object this[int intIndex]
{
get
{
if (conSetFieldVisibility.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (conSetFieldVisibility.IdSchool  ==  _AttributeName[intIndex])
{
return mstrIdSchool;
}
else if (conSetFieldVisibility.UserId  ==  _AttributeName[intIndex])
{
return mstrUserId;
}
else if (conSetFieldVisibility.ViewName  ==  _AttributeName[intIndex])
{
return mstrViewName;
}
else if (conSetFieldVisibility.FieldName  ==  _AttributeName[intIndex])
{
return mstrFieldName;
}
else if (conSetFieldVisibility.Caption  ==  _AttributeName[intIndex])
{
return mstrCaption;
}
else if (conSetFieldVisibility.CtrlType  ==  _AttributeName[intIndex])
{
return mstrCtrlType;
}
else if (conSetFieldVisibility.IsVisible  ==  _AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (conSetFieldVisibility.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conSetFieldVisibility.UpdUserId  ==  _AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conSetFieldVisibility.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (conSetFieldVisibility.FuncModuleId  ==  _AttributeName[intIndex])
{
return mstrFuncModuleId;
}
return null;
}
set
{
if (conSetFieldVisibility.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conSetFieldVisibility.mId);
}
else if (conSetFieldVisibility.IdSchool  ==  _AttributeName[intIndex])
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(conSetFieldVisibility.IdSchool);
}
else if (conSetFieldVisibility.UserId  ==  _AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conSetFieldVisibility.UserId);
}
else if (conSetFieldVisibility.ViewName  ==  _AttributeName[intIndex])
{
mstrViewName = value.ToString();
 AddUpdatedFld(conSetFieldVisibility.ViewName);
}
else if (conSetFieldVisibility.FieldName  ==  _AttributeName[intIndex])
{
mstrFieldName = value.ToString();
 AddUpdatedFld(conSetFieldVisibility.FieldName);
}
else if (conSetFieldVisibility.Caption  ==  _AttributeName[intIndex])
{
mstrCaption = value.ToString();
 AddUpdatedFld(conSetFieldVisibility.Caption);
}
else if (conSetFieldVisibility.CtrlType  ==  _AttributeName[intIndex])
{
mstrCtrlType = value.ToString();
 AddUpdatedFld(conSetFieldVisibility.CtrlType);
}
else if (conSetFieldVisibility.IsVisible  ==  _AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conSetFieldVisibility.IsVisible);
}
else if (conSetFieldVisibility.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conSetFieldVisibility.UpdDate);
}
else if (conSetFieldVisibility.UpdUserId  ==  _AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conSetFieldVisibility.UpdUserId);
}
else if (conSetFieldVisibility.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSetFieldVisibility.Memo);
}
else if (conSetFieldVisibility.FuncModuleId  ==  _AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(conSetFieldVisibility.FuncModuleId);
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
 AddUpdatedFld(conSetFieldVisibility.mId);
}
}
/// <summary>
/// 学校流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdSchool
{
get
{
return mstrIdSchool;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdSchool = value;
}
else
{
 mstrIdSchool = value;
}
//记录修改过的字段
 AddUpdatedFld(conSetFieldVisibility.IdSchool);
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
 AddUpdatedFld(conSetFieldVisibility.UserId);
}
}
/// <summary>
/// 界面名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewName
{
get
{
return mstrViewName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewName = value;
}
else
{
 mstrViewName = value;
}
//记录修改过的字段
 AddUpdatedFld(conSetFieldVisibility.ViewName);
}
}
/// <summary>
/// 字段名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FieldName
{
get
{
return mstrFieldName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFieldName = value;
}
else
{
 mstrFieldName = value;
}
//记录修改过的字段
 AddUpdatedFld(conSetFieldVisibility.FieldName);
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
 AddUpdatedFld(conSetFieldVisibility.Caption);
}
}
/// <summary>
/// 控件类型(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CtrlType
{
get
{
return mstrCtrlType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCtrlType = value;
}
else
{
 mstrCtrlType = value;
}
//记录修改过的字段
 AddUpdatedFld(conSetFieldVisibility.CtrlType);
}
}
/// <summary>
/// 是否显示(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsVisible
{
get
{
return mbolIsVisible;
}
set
{
 mbolIsVisible = value;
//记录修改过的字段
 AddUpdatedFld(conSetFieldVisibility.IsVisible);
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
 AddUpdatedFld(conSetFieldVisibility.UpdDate);
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
 AddUpdatedFld(conSetFieldVisibility.UpdUserId);
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
 AddUpdatedFld(conSetFieldVisibility.Memo);
}
}
/// <summary>
/// FuncModuleId(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleId
{
get
{
return mstrFuncModuleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleId = value;
}
else
{
 mstrFuncModuleId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSetFieldVisibility.FuncModuleId);
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
 /// 设置字段可视性(SetFieldVisibility)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conSetFieldVisibility
{
public const string _CurrTabName = "SetFieldVisibility"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "IdSchool", "UserId", "ViewName", "FieldName", "Caption", "CtrlType", "IsVisible", "UpdDate", "UpdUserId", "Memo", "FuncModuleId"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"IdSchool"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSchool = "IdSchool";    //学校流水号

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户Id

 /// <summary>
 /// 常量:"ViewName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewName = "ViewName";    //界面名称

 /// <summary>
 /// 常量:"FieldName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FieldName = "FieldName";    //字段名

 /// <summary>
 /// 常量:"Caption"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Caption = "Caption";    //标题

 /// <summary>
 /// 常量:"CtrlType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CtrlType = "CtrlType";    //控件类型

 /// <summary>
 /// 常量:"IsVisible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVisible = "IsVisible";    //是否显示

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

 /// <summary>
 /// 常量:"FuncModuleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleId = "FuncModuleId";    //FuncModuleId
}

}