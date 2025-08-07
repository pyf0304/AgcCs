
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjFileStateEN
 表名:PrjFileState(00050525)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:34:35
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统参数(SysPara)
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
 /// 表PrjFileState的关键字(PrjFileStateId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PrjFileStateId_PrjFileState
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strPrjFileStateId">表关键字</param>
public K_PrjFileStateId_PrjFileState(string strPrjFileStateId)
{
if (IsValid(strPrjFileStateId)) Value = strPrjFileStateId;
else
{
Value = null;
}
}
private static bool IsValid(string strPrjFileStateId)
{
if (string.IsNullOrEmpty(strPrjFileStateId) == true) return false;
if (strPrjFileStateId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PrjFileStateId_PrjFileState]类型的对象</returns>
public static implicit operator K_PrjFileStateId_PrjFileState(string value)
{
return new K_PrjFileStateId_PrjFileState(value);
}
}
 /// <summary>
 /// 工程文件状态(PrjFileState)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsPrjFileStateEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "PrjFileState"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PrjFileStateId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 5;
public static string[] _AttributeName = new string[] {"PrjFileStateId", "PrjFileStateName", "PrjFileStateENName", "OrderNum", "Memo"};

protected string mstrPrjFileStateId;    //工程文件状态Id
protected string mstrPrjFileStateName;    //工程文件状态名
protected string mstrPrjFileStateENName;    //工程文件状态英文名
protected int mintOrderNum;    //序号
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsPrjFileStateEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PrjFileStateId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strPrjFileStateId">关键字:工程文件状态Id</param>
public clsPrjFileStateEN(string strPrjFileStateId)
 {
strPrjFileStateId = strPrjFileStateId.Replace("'", "''");
if (strPrjFileStateId.Length > 2)
{
throw new Exception("在表:PrjFileState中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strPrjFileStateId)  ==  true)
{
throw new Exception("在表:PrjFileState中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPrjFileStateId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrPrjFileStateId = strPrjFileStateId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PrjFileStateId");
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
if (strAttributeName  ==  conPrjFileState.PrjFileStateId)
{
return mstrPrjFileStateId;
}
else if (strAttributeName  ==  conPrjFileState.PrjFileStateName)
{
return mstrPrjFileStateName;
}
else if (strAttributeName  ==  conPrjFileState.PrjFileStateENName)
{
return mstrPrjFileStateENName;
}
else if (strAttributeName  ==  conPrjFileState.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conPrjFileState.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conPrjFileState.PrjFileStateId)
{
mstrPrjFileStateId = value.ToString();
 AddUpdatedFld(conPrjFileState.PrjFileStateId);
}
else if (strAttributeName  ==  conPrjFileState.PrjFileStateName)
{
mstrPrjFileStateName = value.ToString();
 AddUpdatedFld(conPrjFileState.PrjFileStateName);
}
else if (strAttributeName  ==  conPrjFileState.PrjFileStateENName)
{
mstrPrjFileStateENName = value.ToString();
 AddUpdatedFld(conPrjFileState.PrjFileStateENName);
}
else if (strAttributeName  ==  conPrjFileState.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conPrjFileState.OrderNum);
}
else if (strAttributeName  ==  conPrjFileState.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPrjFileState.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conPrjFileState.PrjFileStateId  ==  _AttributeName[intIndex])
{
return mstrPrjFileStateId;
}
else if (conPrjFileState.PrjFileStateName  ==  _AttributeName[intIndex])
{
return mstrPrjFileStateName;
}
else if (conPrjFileState.PrjFileStateENName  ==  _AttributeName[intIndex])
{
return mstrPrjFileStateENName;
}
else if (conPrjFileState.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conPrjFileState.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conPrjFileState.PrjFileStateId  ==  _AttributeName[intIndex])
{
mstrPrjFileStateId = value.ToString();
 AddUpdatedFld(conPrjFileState.PrjFileStateId);
}
else if (conPrjFileState.PrjFileStateName  ==  _AttributeName[intIndex])
{
mstrPrjFileStateName = value.ToString();
 AddUpdatedFld(conPrjFileState.PrjFileStateName);
}
else if (conPrjFileState.PrjFileStateENName  ==  _AttributeName[intIndex])
{
mstrPrjFileStateENName = value.ToString();
 AddUpdatedFld(conPrjFileState.PrjFileStateENName);
}
else if (conPrjFileState.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conPrjFileState.OrderNum);
}
else if (conPrjFileState.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPrjFileState.Memo);
}
}
}

/// <summary>
/// 工程文件状态Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjFileStateId
{
get
{
return mstrPrjFileStateId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjFileStateId = value;
}
else
{
 mstrPrjFileStateId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjFileState.PrjFileStateId);
}
}
/// <summary>
/// 工程文件状态名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjFileStateName
{
get
{
return mstrPrjFileStateName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjFileStateName = value;
}
else
{
 mstrPrjFileStateName = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjFileState.PrjFileStateName);
}
}
/// <summary>
/// 工程文件状态英文名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjFileStateENName
{
get
{
return mstrPrjFileStateENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjFileStateENName = value;
}
else
{
 mstrPrjFileStateENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjFileState.PrjFileStateENName);
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
 AddUpdatedFld(conPrjFileState.OrderNum);
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
 AddUpdatedFld(conPrjFileState.Memo);
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
  return mstrPrjFileStateId;
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
  return mstrPrjFileStateName;
 }
 }
}
 /// <summary>
 /// 工程文件状态(PrjFileState)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conPrjFileState
{
public const string _CurrTabName = "PrjFileState"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PrjFileStateId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"PrjFileStateId", "PrjFileStateName", "PrjFileStateENName", "OrderNum", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"PrjFileStateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjFileStateId = "PrjFileStateId";    //工程文件状态Id

 /// <summary>
 /// 常量:"PrjFileStateName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjFileStateName = "PrjFileStateName";    //工程文件状态名

 /// <summary>
 /// 常量:"PrjFileStateENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjFileStateENName = "PrjFileStateENName";    //工程文件状态英文名

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}