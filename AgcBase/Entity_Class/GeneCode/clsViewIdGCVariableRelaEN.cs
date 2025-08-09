
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewIdGCVariableRelaEN
 表名:ViewIdGCVariableRela(00050631)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:02:13
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
 /// 表ViewIdGCVariableRela的关键字(VarId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_VarId_ViewIdGCVariableRela
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strVarId">表关键字</param>
public K_VarId_ViewIdGCVariableRela(string strVarId)
{
if (IsValid(strVarId)) Value = strVarId;
else
{
Value = null;
}
}
private static bool IsValid(string strVarId)
{
if (string.IsNullOrEmpty(strVarId) == true) return false;
if (strVarId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_VarId_ViewIdGCVariableRela]类型的对象</returns>
public static implicit operator K_VarId_ViewIdGCVariableRela(string value)
{
return new K_VarId_ViewIdGCVariableRela(value);
}
}
 /// <summary>
 /// 界面变量关系(ViewIdGCVariableRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsViewIdGCVariableRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ViewIdGCVariableRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "VarId,ViewId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 10;
public static string[] _AttributeName = new string[] {"IsUseInRegion", "VarId", "ViewId", "RetrievalMethodId", "RegionTypeNames", "ErrMsg", "PrjId", "UpdUser", "UpdDate", "Memo"};

protected bool mbolIsUseInRegion;    //是否在区域中使用
protected string mstrVarId;    //变量Id
protected string mstrViewId;    //界面Id
protected string mstrRetrievalMethodId;    //获取方式Id
protected string mstrRegionTypeNames;    //区域类型名s
protected string mstrErrMsg;    //错误信息
protected string mstrPrjId;    //工程Id
protected string mstrUpdUser;    //修改者
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsViewIdGCVariableRelaEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("VarId");
 lstKeyFldNames.Add("ViewId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strVarId">关键字:变量Id</param>
public clsViewIdGCVariableRelaEN(string strVarId , string strViewId)
 {
strVarId = strVarId.Replace("'", "''");
if (strVarId.Length > 8)
{
throw new Exception("在表:ViewIdGCVariableRela中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strVarId)  ==  true)
{
throw new Exception("在表:ViewIdGCVariableRela中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strVarId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrVarId = strVarId;
this.mstrViewId = strViewId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("VarId");
 lstKeyFldNames.Add("ViewId");
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
if (strAttributeName  ==  conViewIdGCVariableRela.IsUseInRegion)
{
return mbolIsUseInRegion;
}
else if (strAttributeName  ==  conViewIdGCVariableRela.VarId)
{
return mstrVarId;
}
else if (strAttributeName  ==  conViewIdGCVariableRela.ViewId)
{
return mstrViewId;
}
else if (strAttributeName  ==  conViewIdGCVariableRela.RetrievalMethodId)
{
return mstrRetrievalMethodId;
}
else if (strAttributeName  ==  conViewIdGCVariableRela.RegionTypeNames)
{
return mstrRegionTypeNames;
}
else if (strAttributeName  ==  conViewIdGCVariableRela.ErrMsg)
{
return mstrErrMsg;
}
else if (strAttributeName  ==  conViewIdGCVariableRela.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conViewIdGCVariableRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conViewIdGCVariableRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conViewIdGCVariableRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conViewIdGCVariableRela.IsUseInRegion)
{
mbolIsUseInRegion = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewIdGCVariableRela.IsUseInRegion);
}
else if (strAttributeName  ==  conViewIdGCVariableRela.VarId)
{
mstrVarId = value.ToString();
 AddUpdatedFld(conViewIdGCVariableRela.VarId);
}
else if (strAttributeName  ==  conViewIdGCVariableRela.ViewId)
{
mstrViewId = value.ToString();
 AddUpdatedFld(conViewIdGCVariableRela.ViewId);
}
else if (strAttributeName  ==  conViewIdGCVariableRela.RetrievalMethodId)
{
mstrRetrievalMethodId = value.ToString();
 AddUpdatedFld(conViewIdGCVariableRela.RetrievalMethodId);
}
else if (strAttributeName  ==  conViewIdGCVariableRela.RegionTypeNames)
{
mstrRegionTypeNames = value.ToString();
 AddUpdatedFld(conViewIdGCVariableRela.RegionTypeNames);
}
else if (strAttributeName  ==  conViewIdGCVariableRela.ErrMsg)
{
mstrErrMsg = value.ToString();
 AddUpdatedFld(conViewIdGCVariableRela.ErrMsg);
}
else if (strAttributeName  ==  conViewIdGCVariableRela.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conViewIdGCVariableRela.PrjId);
}
else if (strAttributeName  ==  conViewIdGCVariableRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conViewIdGCVariableRela.UpdUser);
}
else if (strAttributeName  ==  conViewIdGCVariableRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conViewIdGCVariableRela.UpdDate);
}
else if (strAttributeName  ==  conViewIdGCVariableRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conViewIdGCVariableRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conViewIdGCVariableRela.IsUseInRegion  ==  _AttributeName[intIndex])
{
return mbolIsUseInRegion;
}
else if (conViewIdGCVariableRela.VarId  ==  _AttributeName[intIndex])
{
return mstrVarId;
}
else if (conViewIdGCVariableRela.ViewId  ==  _AttributeName[intIndex])
{
return mstrViewId;
}
else if (conViewIdGCVariableRela.RetrievalMethodId  ==  _AttributeName[intIndex])
{
return mstrRetrievalMethodId;
}
else if (conViewIdGCVariableRela.RegionTypeNames  ==  _AttributeName[intIndex])
{
return mstrRegionTypeNames;
}
else if (conViewIdGCVariableRela.ErrMsg  ==  _AttributeName[intIndex])
{
return mstrErrMsg;
}
else if (conViewIdGCVariableRela.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conViewIdGCVariableRela.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conViewIdGCVariableRela.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conViewIdGCVariableRela.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conViewIdGCVariableRela.IsUseInRegion  ==  _AttributeName[intIndex])
{
mbolIsUseInRegion = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewIdGCVariableRela.IsUseInRegion);
}
else if (conViewIdGCVariableRela.VarId  ==  _AttributeName[intIndex])
{
mstrVarId = value.ToString();
 AddUpdatedFld(conViewIdGCVariableRela.VarId);
}
else if (conViewIdGCVariableRela.ViewId  ==  _AttributeName[intIndex])
{
mstrViewId = value.ToString();
 AddUpdatedFld(conViewIdGCVariableRela.ViewId);
}
else if (conViewIdGCVariableRela.RetrievalMethodId  ==  _AttributeName[intIndex])
{
mstrRetrievalMethodId = value.ToString();
 AddUpdatedFld(conViewIdGCVariableRela.RetrievalMethodId);
}
else if (conViewIdGCVariableRela.RegionTypeNames  ==  _AttributeName[intIndex])
{
mstrRegionTypeNames = value.ToString();
 AddUpdatedFld(conViewIdGCVariableRela.RegionTypeNames);
}
else if (conViewIdGCVariableRela.ErrMsg  ==  _AttributeName[intIndex])
{
mstrErrMsg = value.ToString();
 AddUpdatedFld(conViewIdGCVariableRela.ErrMsg);
}
else if (conViewIdGCVariableRela.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conViewIdGCVariableRela.PrjId);
}
else if (conViewIdGCVariableRela.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conViewIdGCVariableRela.UpdUser);
}
else if (conViewIdGCVariableRela.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conViewIdGCVariableRela.UpdDate);
}
else if (conViewIdGCVariableRela.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conViewIdGCVariableRela.Memo);
}
}
}

/// <summary>
/// 是否在区域中使用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsUseInRegion
{
get
{
return mbolIsUseInRegion;
}
set
{
 mbolIsUseInRegion = value;
//记录修改过的字段
 AddUpdatedFld(conViewIdGCVariableRela.IsUseInRegion);
}
}
/// <summary>
/// 变量Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VarId
{
get
{
return mstrVarId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVarId = value;
}
else
{
 mstrVarId = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewIdGCVariableRela.VarId);
}
}
/// <summary>
/// 界面Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewId
{
get
{
return mstrViewId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewId = value;
}
else
{
 mstrViewId = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewIdGCVariableRela.ViewId);
}
}
/// <summary>
/// 获取方式Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RetrievalMethodId
{
get
{
return mstrRetrievalMethodId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRetrievalMethodId = value;
}
else
{
 mstrRetrievalMethodId = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewIdGCVariableRela.RetrievalMethodId);
}
}
/// <summary>
/// 区域类型名s(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RegionTypeNames
{
get
{
return mstrRegionTypeNames;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRegionTypeNames = value;
}
else
{
 mstrRegionTypeNames = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewIdGCVariableRela.RegionTypeNames);
}
}
/// <summary>
/// 错误信息(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ErrMsg
{
get
{
return mstrErrMsg;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrErrMsg = value;
}
else
{
 mstrErrMsg = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewIdGCVariableRela.ErrMsg);
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
 AddUpdatedFld(conViewIdGCVariableRela.PrjId);
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
 AddUpdatedFld(conViewIdGCVariableRela.UpdUser);
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
 AddUpdatedFld(conViewIdGCVariableRela.UpdDate);
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
 AddUpdatedFld(conViewIdGCVariableRela.Memo);
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
  return mstrVarId;
 }
 }
}
 /// <summary>
 /// 界面变量关系(ViewIdGCVariableRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conViewIdGCVariableRela
{
public const string _CurrTabName = "ViewIdGCVariableRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "VarId,ViewId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"IsUseInRegion", "VarId", "ViewId", "RetrievalMethodId", "RegionTypeNames", "ErrMsg", "PrjId", "UpdUser", "UpdDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IsUseInRegion"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsUseInRegion = "IsUseInRegion";    //是否在区域中使用

 /// <summary>
 /// 常量:"VarId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VarId = "VarId";    //变量Id

 /// <summary>
 /// 常量:"ViewId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewId = "ViewId";    //界面Id

 /// <summary>
 /// 常量:"RetrievalMethodId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RetrievalMethodId = "RetrievalMethodId";    //获取方式Id

 /// <summary>
 /// 常量:"RegionTypeNames"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RegionTypeNames = "RegionTypeNames";    //区域类型名s

 /// <summary>
 /// 常量:"ErrMsg"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ErrMsg = "ErrMsg";    //错误信息

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改者

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