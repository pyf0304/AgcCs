
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCTCodeTypeGroupEN
 表名:CTCodeTypeGroup(00050648)
 * 版本:2026.05.30(服务器:PYF-AI)
 日期:2026/06/06 11:43:34
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
 /// 表CTCodeTypeGroup的关键字(CtGroupId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CtGroupId_CTCodeTypeGroup
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strCtGroupId">表关键字</param>
public K_CtGroupId_CTCodeTypeGroup(string strCtGroupId)
{
if (IsValid(strCtGroupId)) Value = strCtGroupId;
else
{
Value = null;
}
}
private static bool IsValid(string strCtGroupId)
{
if (string.IsNullOrEmpty(strCtGroupId) == true) return false;
if (strCtGroupId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_CtGroupId_CTCodeTypeGroup]类型的对象</returns>
public static implicit operator K_CtGroupId_CTCodeTypeGroup(string value)
{
return new K_CtGroupId_CTCodeTypeGroup(value);
}
}
 /// <summary>
 /// CTCodeTypeGroup(CTCodeTypeGroup)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCTCodeTypeGroupEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CTCodeTypeGroup"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "CtGroupId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 9;
public static string[] _AttributeName = new string[] {"CtGroupId", "ApplicationTypeId", "GroupName", "GroupENName", "Description", "OrderNum", "InUse", "UpdDate", "UpdUser"};

protected string mstrCtGroupId;    //Ct组Id
protected int mintApplicationTypeId;    //应用程序类型ID
protected string mstrGroupName;    //组名
protected string mstrGroupENName;    //组英文名
protected string mstrDescription;    //描述
protected int? mintOrderNum;    //序号
protected bool mbolInUse;    //是否在用
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsCTCodeTypeGroupEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CtGroupId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strCtGroupId">关键字:Ct组Id</param>
public clsCTCodeTypeGroupEN(string strCtGroupId)
 {
strCtGroupId = strCtGroupId.Replace("'", "''");
if (strCtGroupId.Length > 4)
{
throw new Exception("在表:CTCodeTypeGroup中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strCtGroupId)  ==  true)
{
throw new Exception("在表:CTCodeTypeGroup中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCtGroupId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrCtGroupId = strCtGroupId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CtGroupId");
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
if (strAttributeName  ==  conCTCodeTypeGroup.CtGroupId)
{
return mstrCtGroupId;
}
else if (strAttributeName  ==  conCTCodeTypeGroup.ApplicationTypeId)
{
return mintApplicationTypeId;
}
else if (strAttributeName  ==  conCTCodeTypeGroup.GroupName)
{
return mstrGroupName;
}
else if (strAttributeName  ==  conCTCodeTypeGroup.GroupENName)
{
return mstrGroupENName;
}
else if (strAttributeName  ==  conCTCodeTypeGroup.Description)
{
return mstrDescription;
}
else if (strAttributeName  ==  conCTCodeTypeGroup.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conCTCodeTypeGroup.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  conCTCodeTypeGroup.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conCTCodeTypeGroup.UpdUser)
{
return mstrUpdUser;
}
return null;
}
set
{
if (strAttributeName  ==  conCTCodeTypeGroup.CtGroupId)
{
mstrCtGroupId = value.ToString();
 AddUpdatedFld(conCTCodeTypeGroup.CtGroupId);
}
else if (strAttributeName  ==  conCTCodeTypeGroup.ApplicationTypeId)
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conCTCodeTypeGroup.ApplicationTypeId);
}
else if (strAttributeName  ==  conCTCodeTypeGroup.GroupName)
{
mstrGroupName = value.ToString();
 AddUpdatedFld(conCTCodeTypeGroup.GroupName);
}
else if (strAttributeName  ==  conCTCodeTypeGroup.GroupENName)
{
mstrGroupENName = value.ToString();
 AddUpdatedFld(conCTCodeTypeGroup.GroupENName);
}
else if (strAttributeName  ==  conCTCodeTypeGroup.Description)
{
mstrDescription = value.ToString();
 AddUpdatedFld(conCTCodeTypeGroup.Description);
}
else if (strAttributeName  ==  conCTCodeTypeGroup.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conCTCodeTypeGroup.OrderNum);
}
else if (strAttributeName  ==  conCTCodeTypeGroup.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conCTCodeTypeGroup.InUse);
}
else if (strAttributeName  ==  conCTCodeTypeGroup.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCTCodeTypeGroup.UpdDate);
}
else if (strAttributeName  ==  conCTCodeTypeGroup.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conCTCodeTypeGroup.UpdUser);
}
}
}
public object this[int intIndex]
{
get
{
if (conCTCodeTypeGroup.CtGroupId  ==  _AttributeName[intIndex])
{
return mstrCtGroupId;
}
else if (conCTCodeTypeGroup.ApplicationTypeId  ==  _AttributeName[intIndex])
{
return mintApplicationTypeId;
}
else if (conCTCodeTypeGroup.GroupName  ==  _AttributeName[intIndex])
{
return mstrGroupName;
}
else if (conCTCodeTypeGroup.GroupENName  ==  _AttributeName[intIndex])
{
return mstrGroupENName;
}
else if (conCTCodeTypeGroup.Description  ==  _AttributeName[intIndex])
{
return mstrDescription;
}
else if (conCTCodeTypeGroup.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conCTCodeTypeGroup.InUse  ==  _AttributeName[intIndex])
{
return mbolInUse;
}
else if (conCTCodeTypeGroup.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conCTCodeTypeGroup.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
return null;
}
set
{
if (conCTCodeTypeGroup.CtGroupId  ==  _AttributeName[intIndex])
{
mstrCtGroupId = value.ToString();
 AddUpdatedFld(conCTCodeTypeGroup.CtGroupId);
}
else if (conCTCodeTypeGroup.ApplicationTypeId  ==  _AttributeName[intIndex])
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conCTCodeTypeGroup.ApplicationTypeId);
}
else if (conCTCodeTypeGroup.GroupName  ==  _AttributeName[intIndex])
{
mstrGroupName = value.ToString();
 AddUpdatedFld(conCTCodeTypeGroup.GroupName);
}
else if (conCTCodeTypeGroup.GroupENName  ==  _AttributeName[intIndex])
{
mstrGroupENName = value.ToString();
 AddUpdatedFld(conCTCodeTypeGroup.GroupENName);
}
else if (conCTCodeTypeGroup.Description  ==  _AttributeName[intIndex])
{
mstrDescription = value.ToString();
 AddUpdatedFld(conCTCodeTypeGroup.Description);
}
else if (conCTCodeTypeGroup.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conCTCodeTypeGroup.OrderNum);
}
else if (conCTCodeTypeGroup.InUse  ==  _AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conCTCodeTypeGroup.InUse);
}
else if (conCTCodeTypeGroup.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCTCodeTypeGroup.UpdDate);
}
else if (conCTCodeTypeGroup.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conCTCodeTypeGroup.UpdUser);
}
}
}

/// <summary>
/// Ct组Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CtGroupId
{
get
{
return mstrCtGroupId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCtGroupId = value;
}
else
{
 mstrCtGroupId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCTCodeTypeGroup.CtGroupId);
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
 AddUpdatedFld(conCTCodeTypeGroup.ApplicationTypeId);
}
}
/// <summary>
/// 组名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GroupName
{
get
{
return mstrGroupName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGroupName = value;
}
else
{
 mstrGroupName = value;
}
//记录修改过的字段
 AddUpdatedFld(conCTCodeTypeGroup.GroupName);
}
}
/// <summary>
/// 组英文名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GroupENName
{
get
{
return mstrGroupENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGroupENName = value;
}
else
{
 mstrGroupENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conCTCodeTypeGroup.GroupENName);
}
}
/// <summary>
/// 描述(说明:;字段类型:varchar;字段长度:300;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Description
{
get
{
return mstrDescription;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDescription = value;
}
else
{
 mstrDescription = value;
}
//记录修改过的字段
 AddUpdatedFld(conCTCodeTypeGroup.Description);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(conCTCodeTypeGroup.OrderNum);
}
}
/// <summary>
/// 是否在用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool InUse
{
get
{
return mbolInUse;
}
set
{
 mbolInUse = value;
//记录修改过的字段
 AddUpdatedFld(conCTCodeTypeGroup.InUse);
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
 AddUpdatedFld(conCTCodeTypeGroup.UpdDate);
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
 AddUpdatedFld(conCTCodeTypeGroup.UpdUser);
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
  return mstrCtGroupId;
 }
 }

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrGroupName;
 }
 }
}
 /// <summary>
 /// CTCodeTypeGroup(CTCodeTypeGroup)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCTCodeTypeGroup
{
public const string _CurrTabName = "CTCodeTypeGroup"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CtGroupId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"CtGroupId", "ApplicationTypeId", "GroupName", "GroupENName", "Description", "OrderNum", "InUse", "UpdDate", "UpdUser"};
//以下是属性变量


 /// <summary>
 /// 常量:"CtGroupId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CtGroupId = "CtGroupId";    //Ct组Id

 /// <summary>
 /// 常量:"ApplicationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeId = "ApplicationTypeId";    //应用程序类型ID

 /// <summary>
 /// 常量:"GroupName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GroupName = "GroupName";    //组名

 /// <summary>
 /// 常量:"GroupENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GroupENName = "GroupENName";    //组英文名

 /// <summary>
 /// 常量:"Description"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Description = "Description";    //描述

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"InUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InUse = "InUse";    //是否在用

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
}

}