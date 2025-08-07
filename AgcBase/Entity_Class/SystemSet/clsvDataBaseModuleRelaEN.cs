
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvDataBaseModuleRelaEN
 表名:vDataBaseModuleRela(00050236)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:36:43
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
 /// 表vDataBaseModuleRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vDataBaseModuleRela
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
public K_mId_vDataBaseModuleRela(long lngmId)
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
 /// <returns>返回:[K_mId_vDataBaseModuleRela]类型的对象</returns>
public static implicit operator K_mId_vDataBaseModuleRela(long value)
{
return new K_mId_vDataBaseModuleRela(value);
}
}
 /// <summary>
 /// v数据库模块关系(vDataBaseModuleRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvDataBaseModuleRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vDataBaseModuleRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 13;
public static string[] _AttributeName = new string[] {"mId", "PrjId", "PrjName", "PrjDataBaseId", "PrjDataBaseName", "FuncModuleAgcId", "FuncModuleName", "FuncModuleEnName", "OrderNum", "IsVisible", "UpdUserId", "UpdDate", "Memo"};

protected long mlngmId;    //mId
protected string mstrPrjId;    //工程Id
protected string mstrPrjName;    //工程名称
protected string mstrPrjDataBaseId;    //项目数据库Id
protected string mstrPrjDataBaseName;    //项目数据库名
protected string mstrFuncModuleAgcId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrFuncModuleEnName;    //功能模块英文名称
protected int mintOrderNum;    //序号
protected bool mbolIsVisible;    //是否显示
protected string mstrUpdUserId;    //修改用户Id
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvDataBaseModuleRelaEN()
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
public clsvDataBaseModuleRelaEN(long lngmId)
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
if (strAttributeName  ==  convDataBaseModuleRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convDataBaseModuleRela.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convDataBaseModuleRela.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convDataBaseModuleRela.PrjDataBaseId)
{
return mstrPrjDataBaseId;
}
else if (strAttributeName  ==  convDataBaseModuleRela.PrjDataBaseName)
{
return mstrPrjDataBaseName;
}
else if (strAttributeName  ==  convDataBaseModuleRela.FuncModuleAgcId)
{
return mstrFuncModuleAgcId;
}
else if (strAttributeName  ==  convDataBaseModuleRela.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convDataBaseModuleRela.FuncModuleEnName)
{
return mstrFuncModuleEnName;
}
else if (strAttributeName  ==  convDataBaseModuleRela.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convDataBaseModuleRela.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  convDataBaseModuleRela.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convDataBaseModuleRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convDataBaseModuleRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convDataBaseModuleRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convDataBaseModuleRela.mId);
}
else if (strAttributeName  ==  convDataBaseModuleRela.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convDataBaseModuleRela.PrjId);
}
else if (strAttributeName  ==  convDataBaseModuleRela.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convDataBaseModuleRela.PrjName);
}
else if (strAttributeName  ==  convDataBaseModuleRela.PrjDataBaseId)
{
mstrPrjDataBaseId = value.ToString();
 AddUpdatedFld(convDataBaseModuleRela.PrjDataBaseId);
}
else if (strAttributeName  ==  convDataBaseModuleRela.PrjDataBaseName)
{
mstrPrjDataBaseName = value.ToString();
 AddUpdatedFld(convDataBaseModuleRela.PrjDataBaseName);
}
else if (strAttributeName  ==  convDataBaseModuleRela.FuncModuleAgcId)
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convDataBaseModuleRela.FuncModuleAgcId);
}
else if (strAttributeName  ==  convDataBaseModuleRela.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convDataBaseModuleRela.FuncModuleName);
}
else if (strAttributeName  ==  convDataBaseModuleRela.FuncModuleEnName)
{
mstrFuncModuleEnName = value.ToString();
 AddUpdatedFld(convDataBaseModuleRela.FuncModuleEnName);
}
else if (strAttributeName  ==  convDataBaseModuleRela.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convDataBaseModuleRela.OrderNum);
}
else if (strAttributeName  ==  convDataBaseModuleRela.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convDataBaseModuleRela.IsVisible);
}
else if (strAttributeName  ==  convDataBaseModuleRela.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convDataBaseModuleRela.UpdUserId);
}
else if (strAttributeName  ==  convDataBaseModuleRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convDataBaseModuleRela.UpdDate);
}
else if (strAttributeName  ==  convDataBaseModuleRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convDataBaseModuleRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convDataBaseModuleRela.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (convDataBaseModuleRela.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convDataBaseModuleRela.PrjName  ==  _AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convDataBaseModuleRela.PrjDataBaseId  ==  _AttributeName[intIndex])
{
return mstrPrjDataBaseId;
}
else if (convDataBaseModuleRela.PrjDataBaseName  ==  _AttributeName[intIndex])
{
return mstrPrjDataBaseName;
}
else if (convDataBaseModuleRela.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
return mstrFuncModuleAgcId;
}
else if (convDataBaseModuleRela.FuncModuleName  ==  _AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convDataBaseModuleRela.FuncModuleEnName  ==  _AttributeName[intIndex])
{
return mstrFuncModuleEnName;
}
else if (convDataBaseModuleRela.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convDataBaseModuleRela.IsVisible  ==  _AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (convDataBaseModuleRela.UpdUserId  ==  _AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convDataBaseModuleRela.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convDataBaseModuleRela.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convDataBaseModuleRela.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convDataBaseModuleRela.mId);
}
else if (convDataBaseModuleRela.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convDataBaseModuleRela.PrjId);
}
else if (convDataBaseModuleRela.PrjName  ==  _AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convDataBaseModuleRela.PrjName);
}
else if (convDataBaseModuleRela.PrjDataBaseId  ==  _AttributeName[intIndex])
{
mstrPrjDataBaseId = value.ToString();
 AddUpdatedFld(convDataBaseModuleRela.PrjDataBaseId);
}
else if (convDataBaseModuleRela.PrjDataBaseName  ==  _AttributeName[intIndex])
{
mstrPrjDataBaseName = value.ToString();
 AddUpdatedFld(convDataBaseModuleRela.PrjDataBaseName);
}
else if (convDataBaseModuleRela.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convDataBaseModuleRela.FuncModuleAgcId);
}
else if (convDataBaseModuleRela.FuncModuleName  ==  _AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convDataBaseModuleRela.FuncModuleName);
}
else if (convDataBaseModuleRela.FuncModuleEnName  ==  _AttributeName[intIndex])
{
mstrFuncModuleEnName = value.ToString();
 AddUpdatedFld(convDataBaseModuleRela.FuncModuleEnName);
}
else if (convDataBaseModuleRela.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convDataBaseModuleRela.OrderNum);
}
else if (convDataBaseModuleRela.IsVisible  ==  _AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convDataBaseModuleRela.IsVisible);
}
else if (convDataBaseModuleRela.UpdUserId  ==  _AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convDataBaseModuleRela.UpdUserId);
}
else if (convDataBaseModuleRela.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convDataBaseModuleRela.UpdDate);
}
else if (convDataBaseModuleRela.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convDataBaseModuleRela.Memo);
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
 AddUpdatedFld(convDataBaseModuleRela.mId);
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
 AddUpdatedFld(convDataBaseModuleRela.PrjId);
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
 AddUpdatedFld(convDataBaseModuleRela.PrjName);
}
}
/// <summary>
/// 项目数据库Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjDataBaseId
{
get
{
return mstrPrjDataBaseId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjDataBaseId = value;
}
else
{
 mstrPrjDataBaseId = value;
}
//记录修改过的字段
 AddUpdatedFld(convDataBaseModuleRela.PrjDataBaseId);
}
}
/// <summary>
/// 项目数据库名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjDataBaseName
{
get
{
return mstrPrjDataBaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjDataBaseName = value;
}
else
{
 mstrPrjDataBaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convDataBaseModuleRela.PrjDataBaseName);
}
}
/// <summary>
/// 功能模块Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleAgcId
{
get
{
return mstrFuncModuleAgcId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleAgcId = value;
}
else
{
 mstrFuncModuleAgcId = value;
}
//记录修改过的字段
 AddUpdatedFld(convDataBaseModuleRela.FuncModuleAgcId);
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
 AddUpdatedFld(convDataBaseModuleRela.FuncModuleName);
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
 AddUpdatedFld(convDataBaseModuleRela.FuncModuleEnName);
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
 AddUpdatedFld(convDataBaseModuleRela.OrderNum);
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
 AddUpdatedFld(convDataBaseModuleRela.IsVisible);
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
 AddUpdatedFld(convDataBaseModuleRela.UpdUserId);
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
 AddUpdatedFld(convDataBaseModuleRela.UpdDate);
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
 AddUpdatedFld(convDataBaseModuleRela.Memo);
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
 /// v数据库模块关系(vDataBaseModuleRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convDataBaseModuleRela
{
public const string _CurrTabName = "vDataBaseModuleRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "PrjId", "PrjName", "PrjDataBaseId", "PrjDataBaseName", "FuncModuleAgcId", "FuncModuleName", "FuncModuleEnName", "OrderNum", "IsVisible", "UpdUserId", "UpdDate", "Memo"};
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
 /// 常量:"PrjDataBaseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjDataBaseId = "PrjDataBaseId";    //项目数据库Id

 /// <summary>
 /// 常量:"PrjDataBaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjDataBaseName = "PrjDataBaseName";    //项目数据库名

 /// <summary>
 /// 常量:"FuncModuleAgcId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleAgcId = "FuncModuleAgcId";    //功能模块Id

 /// <summary>
 /// 常量:"FuncModuleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleName = "FuncModuleName";    //功能模块名称

 /// <summary>
 /// 常量:"FuncModuleEnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleEnName = "FuncModuleEnName";    //功能模块英文名称

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"IsVisible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVisible = "IsVisible";    //是否显示

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