
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCMProjectFuncModuleEN
 表名:vCMProjectFuncModule(00050556)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:24:42
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
 /// 表vCMProjectFuncModule的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vCMProjectFuncModule
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
public K_mId_vCMProjectFuncModule(long lngmId)
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
 /// <returns>返回:[K_mId_vCMProjectFuncModule]类型的对象</returns>
public static implicit operator K_mId_vCMProjectFuncModule(long value)
{
return new K_mId_vCMProjectFuncModule(value);
}
}
 /// <summary>
 /// vCMProjectFuncModule(vCMProjectFuncModule)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvCMProjectFuncModuleEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vCMProjectFuncModule"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 13;
public static string[] _AttributeName = new string[] {"mId", "CmPrjId", "CmPrjName", "FuncModuleAgcId", "FuncModuleName", "TabNum", "ViewNum", "OrderNum", "OrderNumFuncModule", "PrjId", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrCmPrjId;    //Cm工程Id
protected string mstrCmPrjName;    //CM工程名
protected string mstrFuncModuleAgcId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
protected int? mintTabNum;    //表数
protected int? mintViewNum;    //界面数
protected int mintOrderNum;    //序号
protected int? mintOrderNumFuncModule;    //序号_模块
protected string mstrPrjId;    //工程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvCMProjectFuncModuleEN()
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
public clsvCMProjectFuncModuleEN(long lngmId)
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
if (strAttributeName  ==  convCMProjectFuncModule.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convCMProjectFuncModule.CmPrjId)
{
return mstrCmPrjId;
}
else if (strAttributeName  ==  convCMProjectFuncModule.CmPrjName)
{
return mstrCmPrjName;
}
else if (strAttributeName  ==  convCMProjectFuncModule.FuncModuleAgcId)
{
return mstrFuncModuleAgcId;
}
else if (strAttributeName  ==  convCMProjectFuncModule.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convCMProjectFuncModule.TabNum)
{
return mintTabNum;
}
else if (strAttributeName  ==  convCMProjectFuncModule.ViewNum)
{
return mintViewNum;
}
else if (strAttributeName  ==  convCMProjectFuncModule.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convCMProjectFuncModule.OrderNumFuncModule)
{
return mintOrderNumFuncModule;
}
else if (strAttributeName  ==  convCMProjectFuncModule.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convCMProjectFuncModule.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convCMProjectFuncModule.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convCMProjectFuncModule.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convCMProjectFuncModule.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMProjectFuncModule.mId);
}
else if (strAttributeName  ==  convCMProjectFuncModule.CmPrjId)
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(convCMProjectFuncModule.CmPrjId);
}
else if (strAttributeName  ==  convCMProjectFuncModule.CmPrjName)
{
mstrCmPrjName = value.ToString();
 AddUpdatedFld(convCMProjectFuncModule.CmPrjName);
}
else if (strAttributeName  ==  convCMProjectFuncModule.FuncModuleAgcId)
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convCMProjectFuncModule.FuncModuleAgcId);
}
else if (strAttributeName  ==  convCMProjectFuncModule.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convCMProjectFuncModule.FuncModuleName);
}
else if (strAttributeName  ==  convCMProjectFuncModule.TabNum)
{
mintTabNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMProjectFuncModule.TabNum);
}
else if (strAttributeName  ==  convCMProjectFuncModule.ViewNum)
{
mintViewNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMProjectFuncModule.ViewNum);
}
else if (strAttributeName  ==  convCMProjectFuncModule.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMProjectFuncModule.OrderNum);
}
else if (strAttributeName  ==  convCMProjectFuncModule.OrderNumFuncModule)
{
mintOrderNumFuncModule = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMProjectFuncModule.OrderNumFuncModule);
}
else if (strAttributeName  ==  convCMProjectFuncModule.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convCMProjectFuncModule.PrjId);
}
else if (strAttributeName  ==  convCMProjectFuncModule.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convCMProjectFuncModule.UpdDate);
}
else if (strAttributeName  ==  convCMProjectFuncModule.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convCMProjectFuncModule.UpdUser);
}
else if (strAttributeName  ==  convCMProjectFuncModule.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCMProjectFuncModule.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convCMProjectFuncModule.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (convCMProjectFuncModule.CmPrjId  ==  _AttributeName[intIndex])
{
return mstrCmPrjId;
}
else if (convCMProjectFuncModule.CmPrjName  ==  _AttributeName[intIndex])
{
return mstrCmPrjName;
}
else if (convCMProjectFuncModule.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
return mstrFuncModuleAgcId;
}
else if (convCMProjectFuncModule.FuncModuleName  ==  _AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convCMProjectFuncModule.TabNum  ==  _AttributeName[intIndex])
{
return mintTabNum;
}
else if (convCMProjectFuncModule.ViewNum  ==  _AttributeName[intIndex])
{
return mintViewNum;
}
else if (convCMProjectFuncModule.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convCMProjectFuncModule.OrderNumFuncModule  ==  _AttributeName[intIndex])
{
return mintOrderNumFuncModule;
}
else if (convCMProjectFuncModule.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convCMProjectFuncModule.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convCMProjectFuncModule.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convCMProjectFuncModule.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convCMProjectFuncModule.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMProjectFuncModule.mId);
}
else if (convCMProjectFuncModule.CmPrjId  ==  _AttributeName[intIndex])
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(convCMProjectFuncModule.CmPrjId);
}
else if (convCMProjectFuncModule.CmPrjName  ==  _AttributeName[intIndex])
{
mstrCmPrjName = value.ToString();
 AddUpdatedFld(convCMProjectFuncModule.CmPrjName);
}
else if (convCMProjectFuncModule.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convCMProjectFuncModule.FuncModuleAgcId);
}
else if (convCMProjectFuncModule.FuncModuleName  ==  _AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convCMProjectFuncModule.FuncModuleName);
}
else if (convCMProjectFuncModule.TabNum  ==  _AttributeName[intIndex])
{
mintTabNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMProjectFuncModule.TabNum);
}
else if (convCMProjectFuncModule.ViewNum  ==  _AttributeName[intIndex])
{
mintViewNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMProjectFuncModule.ViewNum);
}
else if (convCMProjectFuncModule.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMProjectFuncModule.OrderNum);
}
else if (convCMProjectFuncModule.OrderNumFuncModule  ==  _AttributeName[intIndex])
{
mintOrderNumFuncModule = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMProjectFuncModule.OrderNumFuncModule);
}
else if (convCMProjectFuncModule.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convCMProjectFuncModule.PrjId);
}
else if (convCMProjectFuncModule.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convCMProjectFuncModule.UpdDate);
}
else if (convCMProjectFuncModule.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convCMProjectFuncModule.UpdUser);
}
else if (convCMProjectFuncModule.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCMProjectFuncModule.Memo);
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
 AddUpdatedFld(convCMProjectFuncModule.mId);
}
}
/// <summary>
/// Cm工程Id(说明:;字段类型:char;字段长度:6;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CmPrjId
{
get
{
return mstrCmPrjId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCmPrjId = value;
}
else
{
 mstrCmPrjId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMProjectFuncModule.CmPrjId);
}
}
/// <summary>
/// CM工程名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CmPrjName
{
get
{
return mstrCmPrjName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCmPrjName = value;
}
else
{
 mstrCmPrjName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMProjectFuncModule.CmPrjName);
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
 AddUpdatedFld(convCMProjectFuncModule.FuncModuleAgcId);
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
 AddUpdatedFld(convCMProjectFuncModule.FuncModuleName);
}
}
/// <summary>
/// 表数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? TabNum
{
get
{
return mintTabNum;
}
set
{
 mintTabNum = value;
//记录修改过的字段
 AddUpdatedFld(convCMProjectFuncModule.TabNum);
}
}
/// <summary>
/// 界面数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? ViewNum
{
get
{
return mintViewNum;
}
set
{
 mintViewNum = value;
//记录修改过的字段
 AddUpdatedFld(convCMProjectFuncModule.ViewNum);
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
 AddUpdatedFld(convCMProjectFuncModule.OrderNum);
}
}
/// <summary>
/// 序号_模块(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OrderNumFuncModule
{
get
{
return mintOrderNumFuncModule;
}
set
{
 mintOrderNumFuncModule = value;
//记录修改过的字段
 AddUpdatedFld(convCMProjectFuncModule.OrderNumFuncModule);
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
 AddUpdatedFld(convCMProjectFuncModule.PrjId);
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
 AddUpdatedFld(convCMProjectFuncModule.UpdDate);
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
 AddUpdatedFld(convCMProjectFuncModule.UpdUser);
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
 AddUpdatedFld(convCMProjectFuncModule.Memo);
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
 /// vCMProjectFuncModule(vCMProjectFuncModule)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convCMProjectFuncModule
{
public const string _CurrTabName = "vCMProjectFuncModule"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "CmPrjId", "CmPrjName", "FuncModuleAgcId", "FuncModuleName", "TabNum", "ViewNum", "OrderNum", "OrderNumFuncModule", "PrjId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"CmPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CmPrjId = "CmPrjId";    //Cm工程Id

 /// <summary>
 /// 常量:"CmPrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CmPrjName = "CmPrjName";    //CM工程名

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
 /// 常量:"TabNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabNum = "TabNum";    //表数

 /// <summary>
 /// 常量:"ViewNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewNum = "ViewNum";    //界面数

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"OrderNumFuncModule"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNumFuncModule = "OrderNumFuncModule";    //序号_模块

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

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