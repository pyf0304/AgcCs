
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFrontAndBack4AppTypeEN
 表名:FrontAndBack4AppType(00050423)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:08:25
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
 /// 表FrontAndBack4AppType的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_FrontAndBack4AppType
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
public K_mId_FrontAndBack4AppType(long lngmId)
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
 /// <returns>返回:[K_mId_FrontAndBack4AppType]类型的对象</returns>
public static implicit operator K_mId_FrontAndBack4AppType(long value)
{
return new K_mId_FrontAndBack4AppType(value);
}
}
 /// <summary>
 /// 应用类型的前后台关系(FrontAndBack4AppType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsFrontAndBack4AppTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "FrontAndBack4AppType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 6;
public static string[] _AttributeName = new string[] {"mId", "AppTypeId4Front", "AppTypeId4Back", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected int mintAppTypeId4Front;    //应用类型Id4Front
protected int mintAppTypeId4Back;    //应用类型Id4Back
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsFrontAndBack4AppTypeEN()
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
public clsFrontAndBack4AppTypeEN(long lngmId)
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
if (strAttributeName  ==  conFrontAndBack4AppType.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conFrontAndBack4AppType.AppTypeId4Front)
{
return mintAppTypeId4Front;
}
else if (strAttributeName  ==  conFrontAndBack4AppType.AppTypeId4Back)
{
return mintAppTypeId4Back;
}
else if (strAttributeName  ==  conFrontAndBack4AppType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conFrontAndBack4AppType.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conFrontAndBack4AppType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conFrontAndBack4AppType.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conFrontAndBack4AppType.mId);
}
else if (strAttributeName  ==  conFrontAndBack4AppType.AppTypeId4Front)
{
mintAppTypeId4Front = TransNullToInt(value.ToString());
 AddUpdatedFld(conFrontAndBack4AppType.AppTypeId4Front);
}
else if (strAttributeName  ==  conFrontAndBack4AppType.AppTypeId4Back)
{
mintAppTypeId4Back = TransNullToInt(value.ToString());
 AddUpdatedFld(conFrontAndBack4AppType.AppTypeId4Back);
}
else if (strAttributeName  ==  conFrontAndBack4AppType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFrontAndBack4AppType.UpdDate);
}
else if (strAttributeName  ==  conFrontAndBack4AppType.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conFrontAndBack4AppType.UpdUser);
}
else if (strAttributeName  ==  conFrontAndBack4AppType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFrontAndBack4AppType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conFrontAndBack4AppType.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (conFrontAndBack4AppType.AppTypeId4Front  ==  _AttributeName[intIndex])
{
return mintAppTypeId4Front;
}
else if (conFrontAndBack4AppType.AppTypeId4Back  ==  _AttributeName[intIndex])
{
return mintAppTypeId4Back;
}
else if (conFrontAndBack4AppType.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conFrontAndBack4AppType.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conFrontAndBack4AppType.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conFrontAndBack4AppType.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conFrontAndBack4AppType.mId);
}
else if (conFrontAndBack4AppType.AppTypeId4Front  ==  _AttributeName[intIndex])
{
mintAppTypeId4Front = TransNullToInt(value.ToString());
 AddUpdatedFld(conFrontAndBack4AppType.AppTypeId4Front);
}
else if (conFrontAndBack4AppType.AppTypeId4Back  ==  _AttributeName[intIndex])
{
mintAppTypeId4Back = TransNullToInt(value.ToString());
 AddUpdatedFld(conFrontAndBack4AppType.AppTypeId4Back);
}
else if (conFrontAndBack4AppType.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFrontAndBack4AppType.UpdDate);
}
else if (conFrontAndBack4AppType.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conFrontAndBack4AppType.UpdUser);
}
else if (conFrontAndBack4AppType.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFrontAndBack4AppType.Memo);
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
 AddUpdatedFld(conFrontAndBack4AppType.mId);
}
}
/// <summary>
/// 应用类型Id4Front(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int AppTypeId4Front
{
get
{
return mintAppTypeId4Front;
}
set
{
 mintAppTypeId4Front = value;
//记录修改过的字段
 AddUpdatedFld(conFrontAndBack4AppType.AppTypeId4Front);
}
}
/// <summary>
/// 应用类型Id4Back(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int AppTypeId4Back
{
get
{
return mintAppTypeId4Back;
}
set
{
 mintAppTypeId4Back = value;
//记录修改过的字段
 AddUpdatedFld(conFrontAndBack4AppType.AppTypeId4Back);
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
 AddUpdatedFld(conFrontAndBack4AppType.UpdDate);
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
 AddUpdatedFld(conFrontAndBack4AppType.UpdUser);
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
 AddUpdatedFld(conFrontAndBack4AppType.Memo);
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
 /// 应用类型的前后台关系(FrontAndBack4AppType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conFrontAndBack4AppType
{
public const string _CurrTabName = "FrontAndBack4AppType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "AppTypeId4Front", "AppTypeId4Back", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"AppTypeId4Front"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppTypeId4Front = "AppTypeId4Front";    //应用类型Id4Front

 /// <summary>
 /// 常量:"AppTypeId4Back"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppTypeId4Back = "AppTypeId4Back";    //应用类型Id4Back

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