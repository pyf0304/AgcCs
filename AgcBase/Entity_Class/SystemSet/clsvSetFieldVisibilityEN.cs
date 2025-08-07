
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSetFieldVisibilityEN
 表名:vSetFieldVisibility(00050243)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:37:15
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
 /// 表vSetFieldVisibility的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vSetFieldVisibility
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
public K_mId_vSetFieldVisibility(long lngmId)
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
 /// <returns>返回:[K_mId_vSetFieldVisibility]类型的对象</returns>
public static implicit operator K_mId_vSetFieldVisibility(long value)
{
return new K_mId_vSetFieldVisibility(value);
}
}
 /// <summary>
 /// v设置字段可视性(vSetFieldVisibility)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvSetFieldVisibilityEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vSetFieldVisibility"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 16;
public static string[] _AttributeName = new string[] {"FuncModuleEnName", "FuncModuleNameSim", "mId", "IdSchool", "SchoolId", "SchoolName", "ViewName", "FieldName", "Caption", "CtrlType", "IsVisible", "UpdDate", "UpdUserId", "Memo", "FuncModuleId", "FuncModuleName"};

protected string mstrFuncModuleEnName;    //功能模块英文名称
protected string mstrFuncModuleNameSim;    //功能模块简称
protected long mlngmId;    //mId
protected string mstrIdSchool;    //学校流水号
protected string mstrSchoolId;    //学校Id
protected string mstrSchoolName;    //学校名称
protected string mstrViewName;    //界面名称
protected string mstrFieldName;    //字段名
protected string mstrCaption;    //标题
protected string mstrCtrlType;    //控件类型
protected bool mbolIsVisible;    //是否显示
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //说明
protected string mstrFuncModuleId;    //FuncModuleId
protected string mstrFuncModuleName;    //功能模块名称

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvSetFieldVisibilityEN()
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
public clsvSetFieldVisibilityEN(long lngmId)
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
if (strAttributeName  ==  convSetFieldVisibility.FuncModuleEnName)
{
return mstrFuncModuleEnName;
}
else if (strAttributeName  ==  convSetFieldVisibility.FuncModuleNameSim)
{
return mstrFuncModuleNameSim;
}
else if (strAttributeName  ==  convSetFieldVisibility.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convSetFieldVisibility.IdSchool)
{
return mstrIdSchool;
}
else if (strAttributeName  ==  convSetFieldVisibility.SchoolId)
{
return mstrSchoolId;
}
else if (strAttributeName  ==  convSetFieldVisibility.SchoolName)
{
return mstrSchoolName;
}
else if (strAttributeName  ==  convSetFieldVisibility.ViewName)
{
return mstrViewName;
}
else if (strAttributeName  ==  convSetFieldVisibility.FieldName)
{
return mstrFieldName;
}
else if (strAttributeName  ==  convSetFieldVisibility.Caption)
{
return mstrCaption;
}
else if (strAttributeName  ==  convSetFieldVisibility.CtrlType)
{
return mstrCtrlType;
}
else if (strAttributeName  ==  convSetFieldVisibility.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  convSetFieldVisibility.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convSetFieldVisibility.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convSetFieldVisibility.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convSetFieldVisibility.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  convSetFieldVisibility.FuncModuleName)
{
return mstrFuncModuleName;
}
return null;
}
set
{
if (strAttributeName  ==  convSetFieldVisibility.FuncModuleEnName)
{
mstrFuncModuleEnName = value.ToString();
 AddUpdatedFld(convSetFieldVisibility.FuncModuleEnName);
}
else if (strAttributeName  ==  convSetFieldVisibility.FuncModuleNameSim)
{
mstrFuncModuleNameSim = value.ToString();
 AddUpdatedFld(convSetFieldVisibility.FuncModuleNameSim);
}
else if (strAttributeName  ==  convSetFieldVisibility.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convSetFieldVisibility.mId);
}
else if (strAttributeName  ==  convSetFieldVisibility.IdSchool)
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(convSetFieldVisibility.IdSchool);
}
else if (strAttributeName  ==  convSetFieldVisibility.SchoolId)
{
mstrSchoolId = value.ToString();
 AddUpdatedFld(convSetFieldVisibility.SchoolId);
}
else if (strAttributeName  ==  convSetFieldVisibility.SchoolName)
{
mstrSchoolName = value.ToString();
 AddUpdatedFld(convSetFieldVisibility.SchoolName);
}
else if (strAttributeName  ==  convSetFieldVisibility.ViewName)
{
mstrViewName = value.ToString();
 AddUpdatedFld(convSetFieldVisibility.ViewName);
}
else if (strAttributeName  ==  convSetFieldVisibility.FieldName)
{
mstrFieldName = value.ToString();
 AddUpdatedFld(convSetFieldVisibility.FieldName);
}
else if (strAttributeName  ==  convSetFieldVisibility.Caption)
{
mstrCaption = value.ToString();
 AddUpdatedFld(convSetFieldVisibility.Caption);
}
else if (strAttributeName  ==  convSetFieldVisibility.CtrlType)
{
mstrCtrlType = value.ToString();
 AddUpdatedFld(convSetFieldVisibility.CtrlType);
}
else if (strAttributeName  ==  convSetFieldVisibility.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convSetFieldVisibility.IsVisible);
}
else if (strAttributeName  ==  convSetFieldVisibility.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convSetFieldVisibility.UpdDate);
}
else if (strAttributeName  ==  convSetFieldVisibility.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convSetFieldVisibility.UpdUserId);
}
else if (strAttributeName  ==  convSetFieldVisibility.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convSetFieldVisibility.Memo);
}
else if (strAttributeName  ==  convSetFieldVisibility.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convSetFieldVisibility.FuncModuleId);
}
else if (strAttributeName  ==  convSetFieldVisibility.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convSetFieldVisibility.FuncModuleName);
}
}
}
public object this[int intIndex]
{
get
{
if (convSetFieldVisibility.FuncModuleEnName  ==  _AttributeName[intIndex])
{
return mstrFuncModuleEnName;
}
else if (convSetFieldVisibility.FuncModuleNameSim  ==  _AttributeName[intIndex])
{
return mstrFuncModuleNameSim;
}
else if (convSetFieldVisibility.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (convSetFieldVisibility.IdSchool  ==  _AttributeName[intIndex])
{
return mstrIdSchool;
}
else if (convSetFieldVisibility.SchoolId  ==  _AttributeName[intIndex])
{
return mstrSchoolId;
}
else if (convSetFieldVisibility.SchoolName  ==  _AttributeName[intIndex])
{
return mstrSchoolName;
}
else if (convSetFieldVisibility.ViewName  ==  _AttributeName[intIndex])
{
return mstrViewName;
}
else if (convSetFieldVisibility.FieldName  ==  _AttributeName[intIndex])
{
return mstrFieldName;
}
else if (convSetFieldVisibility.Caption  ==  _AttributeName[intIndex])
{
return mstrCaption;
}
else if (convSetFieldVisibility.CtrlType  ==  _AttributeName[intIndex])
{
return mstrCtrlType;
}
else if (convSetFieldVisibility.IsVisible  ==  _AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (convSetFieldVisibility.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convSetFieldVisibility.UpdUserId  ==  _AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convSetFieldVisibility.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (convSetFieldVisibility.FuncModuleId  ==  _AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (convSetFieldVisibility.FuncModuleName  ==  _AttributeName[intIndex])
{
return mstrFuncModuleName;
}
return null;
}
set
{
if (convSetFieldVisibility.FuncModuleEnName  ==  _AttributeName[intIndex])
{
mstrFuncModuleEnName = value.ToString();
 AddUpdatedFld(convSetFieldVisibility.FuncModuleEnName);
}
else if (convSetFieldVisibility.FuncModuleNameSim  ==  _AttributeName[intIndex])
{
mstrFuncModuleNameSim = value.ToString();
 AddUpdatedFld(convSetFieldVisibility.FuncModuleNameSim);
}
else if (convSetFieldVisibility.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convSetFieldVisibility.mId);
}
else if (convSetFieldVisibility.IdSchool  ==  _AttributeName[intIndex])
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(convSetFieldVisibility.IdSchool);
}
else if (convSetFieldVisibility.SchoolId  ==  _AttributeName[intIndex])
{
mstrSchoolId = value.ToString();
 AddUpdatedFld(convSetFieldVisibility.SchoolId);
}
else if (convSetFieldVisibility.SchoolName  ==  _AttributeName[intIndex])
{
mstrSchoolName = value.ToString();
 AddUpdatedFld(convSetFieldVisibility.SchoolName);
}
else if (convSetFieldVisibility.ViewName  ==  _AttributeName[intIndex])
{
mstrViewName = value.ToString();
 AddUpdatedFld(convSetFieldVisibility.ViewName);
}
else if (convSetFieldVisibility.FieldName  ==  _AttributeName[intIndex])
{
mstrFieldName = value.ToString();
 AddUpdatedFld(convSetFieldVisibility.FieldName);
}
else if (convSetFieldVisibility.Caption  ==  _AttributeName[intIndex])
{
mstrCaption = value.ToString();
 AddUpdatedFld(convSetFieldVisibility.Caption);
}
else if (convSetFieldVisibility.CtrlType  ==  _AttributeName[intIndex])
{
mstrCtrlType = value.ToString();
 AddUpdatedFld(convSetFieldVisibility.CtrlType);
}
else if (convSetFieldVisibility.IsVisible  ==  _AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convSetFieldVisibility.IsVisible);
}
else if (convSetFieldVisibility.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convSetFieldVisibility.UpdDate);
}
else if (convSetFieldVisibility.UpdUserId  ==  _AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convSetFieldVisibility.UpdUserId);
}
else if (convSetFieldVisibility.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convSetFieldVisibility.Memo);
}
else if (convSetFieldVisibility.FuncModuleId  ==  _AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convSetFieldVisibility.FuncModuleId);
}
else if (convSetFieldVisibility.FuncModuleName  ==  _AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convSetFieldVisibility.FuncModuleName);
}
}
}

/// <summary>
/// 功能模块英文名称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleEnName
{
get
{
return mstrFuncModuleEnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleEnName = value;
}
else
{
 mstrFuncModuleEnName = value;
}
//记录修改过的字段
 AddUpdatedFld(convSetFieldVisibility.FuncModuleEnName);
}
}
/// <summary>
/// 功能模块简称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleNameSim
{
get
{
return mstrFuncModuleNameSim;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleNameSim = value;
}
else
{
 mstrFuncModuleNameSim = value;
}
//记录修改过的字段
 AddUpdatedFld(convSetFieldVisibility.FuncModuleNameSim);
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
 AddUpdatedFld(convSetFieldVisibility.mId);
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
 AddUpdatedFld(convSetFieldVisibility.IdSchool);
}
}
/// <summary>
/// 学校Id(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchoolId
{
get
{
return mstrSchoolId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchoolId = value;
}
else
{
 mstrSchoolId = value;
}
//记录修改过的字段
 AddUpdatedFld(convSetFieldVisibility.SchoolId);
}
}
/// <summary>
/// 学校名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchoolName
{
get
{
return mstrSchoolName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchoolName = value;
}
else
{
 mstrSchoolName = value;
}
//记录修改过的字段
 AddUpdatedFld(convSetFieldVisibility.SchoolName);
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
 AddUpdatedFld(convSetFieldVisibility.ViewName);
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
 AddUpdatedFld(convSetFieldVisibility.FieldName);
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
 AddUpdatedFld(convSetFieldVisibility.Caption);
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
 AddUpdatedFld(convSetFieldVisibility.CtrlType);
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
 AddUpdatedFld(convSetFieldVisibility.IsVisible);
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
 AddUpdatedFld(convSetFieldVisibility.UpdDate);
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
 AddUpdatedFld(convSetFieldVisibility.UpdUserId);
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
 AddUpdatedFld(convSetFieldVisibility.Memo);
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
 AddUpdatedFld(convSetFieldVisibility.FuncModuleId);
}
}
/// <summary>
/// 功能模块名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleName
{
get
{
return mstrFuncModuleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleName = value;
}
else
{
 mstrFuncModuleName = value;
}
//记录修改过的字段
 AddUpdatedFld(convSetFieldVisibility.FuncModuleName);
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
 /// v设置字段可视性(vSetFieldVisibility)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convSetFieldVisibility
{
public const string _CurrTabName = "vSetFieldVisibility"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"FuncModuleEnName", "FuncModuleNameSim", "mId", "IdSchool", "SchoolId", "SchoolName", "ViewName", "FieldName", "Caption", "CtrlType", "IsVisible", "UpdDate", "UpdUserId", "Memo", "FuncModuleId", "FuncModuleName"};
//以下是属性变量


 /// <summary>
 /// 常量:"FuncModuleEnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleEnName = "FuncModuleEnName";    //功能模块英文名称

 /// <summary>
 /// 常量:"FuncModuleNameSim"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleNameSim = "FuncModuleNameSim";    //功能模块简称

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
 /// 常量:"SchoolId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolId = "SchoolId";    //学校Id

 /// <summary>
 /// 常量:"SchoolName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolName = "SchoolName";    //学校名称

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

 /// <summary>
 /// 常量:"FuncModuleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleName = "FuncModuleName";    //功能模块名称
}

}