
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFrontAndBack4AppTypeEN
 表名:vFrontAndBack4AppType(00050424)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:12:54
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
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
 /// 表vFrontAndBack4AppType的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vFrontAndBack4AppType
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
public K_mId_vFrontAndBack4AppType(long lngmId)
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
 /// <returns>返回:[K_mId_vFrontAndBack4AppType]类型的对象</returns>
public static implicit operator K_mId_vFrontAndBack4AppType(long value)
{
return new K_mId_vFrontAndBack4AppType(value);
}
}
 /// <summary>
 /// v应用类型的前后台关系(vFrontAndBack4AppType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvFrontAndBack4AppTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vFrontAndBack4AppType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 10;
public static string[] _AttributeName = new string[] {"mId", "OrderNum", "AppTypeId4Front", "ApplTypeName4Front", "IsVisible", "AppTypeId4Back", "ApplTypeName4Back", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected int mintOrderNum;    //序号
protected int? mintAppTypeId4Front;    //应用类型Id4Front
protected string mstrApplTypeName4Front;    //ApplTypeName4Front
protected bool mbolIsVisible;    //是否显示
protected int? mintAppTypeId4Back;    //应用类型Id4Back
protected string mstrApplTypeName4Back;    //ApplTypeName4Back
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvFrontAndBack4AppTypeEN()
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
public clsvFrontAndBack4AppTypeEN(long lngmId)
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
if (strAttributeName  ==  convFrontAndBack4AppType.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convFrontAndBack4AppType.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convFrontAndBack4AppType.AppTypeId4Front)
{
return mintAppTypeId4Front;
}
else if (strAttributeName  ==  convFrontAndBack4AppType.ApplTypeName4Front)
{
return mstrApplTypeName4Front;
}
else if (strAttributeName  ==  convFrontAndBack4AppType.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  convFrontAndBack4AppType.AppTypeId4Back)
{
return mintAppTypeId4Back;
}
else if (strAttributeName  ==  convFrontAndBack4AppType.ApplTypeName4Back)
{
return mstrApplTypeName4Back;
}
else if (strAttributeName  ==  convFrontAndBack4AppType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convFrontAndBack4AppType.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convFrontAndBack4AppType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convFrontAndBack4AppType.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convFrontAndBack4AppType.mId);
}
else if (strAttributeName  ==  convFrontAndBack4AppType.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFrontAndBack4AppType.OrderNum);
}
else if (strAttributeName  ==  convFrontAndBack4AppType.AppTypeId4Front)
{
mintAppTypeId4Front = TransNullToInt(value.ToString());
 AddUpdatedFld(convFrontAndBack4AppType.AppTypeId4Front);
}
else if (strAttributeName  ==  convFrontAndBack4AppType.ApplTypeName4Front)
{
mstrApplTypeName4Front = value.ToString();
 AddUpdatedFld(convFrontAndBack4AppType.ApplTypeName4Front);
}
else if (strAttributeName  ==  convFrontAndBack4AppType.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convFrontAndBack4AppType.IsVisible);
}
else if (strAttributeName  ==  convFrontAndBack4AppType.AppTypeId4Back)
{
mintAppTypeId4Back = TransNullToInt(value.ToString());
 AddUpdatedFld(convFrontAndBack4AppType.AppTypeId4Back);
}
else if (strAttributeName  ==  convFrontAndBack4AppType.ApplTypeName4Back)
{
mstrApplTypeName4Back = value.ToString();
 AddUpdatedFld(convFrontAndBack4AppType.ApplTypeName4Back);
}
else if (strAttributeName  ==  convFrontAndBack4AppType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFrontAndBack4AppType.UpdDate);
}
else if (strAttributeName  ==  convFrontAndBack4AppType.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFrontAndBack4AppType.UpdUser);
}
else if (strAttributeName  ==  convFrontAndBack4AppType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFrontAndBack4AppType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convFrontAndBack4AppType.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (convFrontAndBack4AppType.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convFrontAndBack4AppType.AppTypeId4Front  ==  _AttributeName[intIndex])
{
return mintAppTypeId4Front;
}
else if (convFrontAndBack4AppType.ApplTypeName4Front  ==  _AttributeName[intIndex])
{
return mstrApplTypeName4Front;
}
else if (convFrontAndBack4AppType.IsVisible  ==  _AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (convFrontAndBack4AppType.AppTypeId4Back  ==  _AttributeName[intIndex])
{
return mintAppTypeId4Back;
}
else if (convFrontAndBack4AppType.ApplTypeName4Back  ==  _AttributeName[intIndex])
{
return mstrApplTypeName4Back;
}
else if (convFrontAndBack4AppType.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convFrontAndBack4AppType.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convFrontAndBack4AppType.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convFrontAndBack4AppType.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convFrontAndBack4AppType.mId);
}
else if (convFrontAndBack4AppType.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFrontAndBack4AppType.OrderNum);
}
else if (convFrontAndBack4AppType.AppTypeId4Front  ==  _AttributeName[intIndex])
{
mintAppTypeId4Front = TransNullToInt(value.ToString());
 AddUpdatedFld(convFrontAndBack4AppType.AppTypeId4Front);
}
else if (convFrontAndBack4AppType.ApplTypeName4Front  ==  _AttributeName[intIndex])
{
mstrApplTypeName4Front = value.ToString();
 AddUpdatedFld(convFrontAndBack4AppType.ApplTypeName4Front);
}
else if (convFrontAndBack4AppType.IsVisible  ==  _AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convFrontAndBack4AppType.IsVisible);
}
else if (convFrontAndBack4AppType.AppTypeId4Back  ==  _AttributeName[intIndex])
{
mintAppTypeId4Back = TransNullToInt(value.ToString());
 AddUpdatedFld(convFrontAndBack4AppType.AppTypeId4Back);
}
else if (convFrontAndBack4AppType.ApplTypeName4Back  ==  _AttributeName[intIndex])
{
mstrApplTypeName4Back = value.ToString();
 AddUpdatedFld(convFrontAndBack4AppType.ApplTypeName4Back);
}
else if (convFrontAndBack4AppType.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFrontAndBack4AppType.UpdDate);
}
else if (convFrontAndBack4AppType.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFrontAndBack4AppType.UpdUser);
}
else if (convFrontAndBack4AppType.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFrontAndBack4AppType.Memo);
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
 AddUpdatedFld(convFrontAndBack4AppType.mId);
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
 AddUpdatedFld(convFrontAndBack4AppType.OrderNum);
}
}
/// <summary>
/// 应用类型Id4Front(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? AppTypeId4Front
{
get
{
return mintAppTypeId4Front;
}
set
{
 mintAppTypeId4Front = value;
//记录修改过的字段
 AddUpdatedFld(convFrontAndBack4AppType.AppTypeId4Front);
}
}
/// <summary>
/// ApplTypeName4Front(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ApplTypeName4Front
{
get
{
return mstrApplTypeName4Front;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrApplTypeName4Front = value;
}
else
{
 mstrApplTypeName4Front = value;
}
//记录修改过的字段
 AddUpdatedFld(convFrontAndBack4AppType.ApplTypeName4Front);
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
 AddUpdatedFld(convFrontAndBack4AppType.IsVisible);
}
}
/// <summary>
/// 应用类型Id4Back(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? AppTypeId4Back
{
get
{
return mintAppTypeId4Back;
}
set
{
 mintAppTypeId4Back = value;
//记录修改过的字段
 AddUpdatedFld(convFrontAndBack4AppType.AppTypeId4Back);
}
}
/// <summary>
/// ApplTypeName4Back(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ApplTypeName4Back
{
get
{
return mstrApplTypeName4Back;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrApplTypeName4Back = value;
}
else
{
 mstrApplTypeName4Back = value;
}
//记录修改过的字段
 AddUpdatedFld(convFrontAndBack4AppType.ApplTypeName4Back);
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
 AddUpdatedFld(convFrontAndBack4AppType.UpdDate);
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
 AddUpdatedFld(convFrontAndBack4AppType.UpdUser);
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
 AddUpdatedFld(convFrontAndBack4AppType.Memo);
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
 /// v应用类型的前后台关系(vFrontAndBack4AppType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convFrontAndBack4AppType
{
public const string _CurrTabName = "vFrontAndBack4AppType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "OrderNum", "AppTypeId4Front", "ApplTypeName4Front", "IsVisible", "AppTypeId4Back", "ApplTypeName4Back", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"AppTypeId4Front"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppTypeId4Front = "AppTypeId4Front";    //应用类型Id4Front

 /// <summary>
 /// 常量:"ApplTypeName4Front"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplTypeName4Front = "ApplTypeName4Front";    //ApplTypeName4Front

 /// <summary>
 /// 常量:"IsVisible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVisible = "IsVisible";    //是否显示

 /// <summary>
 /// 常量:"AppTypeId4Back"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppTypeId4Back = "AppTypeId4Back";    //应用类型Id4Back

 /// <summary>
 /// 常量:"ApplTypeName4Back"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplTypeName4Back = "ApplTypeName4Back";    //ApplTypeName4Back

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