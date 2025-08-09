
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDepartmentInfoEN
 表名:DepartmentInfo(00050029)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:10:01
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:用户管理(UserManage)
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
 /// 表DepartmentInfo的关键字(DepartmentId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_DepartmentId_DepartmentInfo
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strDepartmentId">表关键字</param>
public K_DepartmentId_DepartmentInfo(string strDepartmentId)
{
if (IsValid(strDepartmentId)) Value = strDepartmentId;
else
{
Value = null;
}
}
private static bool IsValid(string strDepartmentId)
{
if (string.IsNullOrEmpty(strDepartmentId) == true) return false;
if (strDepartmentId.Length > 6) return false;
if (strDepartmentId.IndexOf(' ') >= 0) return false;
if (strDepartmentId.IndexOf(')') >= 0) return false;
if (strDepartmentId.IndexOf('(') >= 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_DepartmentId_DepartmentInfo]类型的对象</returns>
public static implicit operator K_DepartmentId_DepartmentInfo(string value)
{
return new K_DepartmentId_DepartmentInfo(value);
}
}
 /// <summary>
 /// 部门(DepartmentInfo)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsDepartmentInfoEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "DepartmentInfo"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "DepartmentId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 8;
public static string[] _AttributeName = new string[] {"DepartmentId", "DepartmentName", "DepartmentAbbrName", "DepartmentTypeId", "UpDepartmentId", "InUse", "OrderNum", "Memo"};

protected string mstrDepartmentId;    //部门ID
protected string mstrDepartmentName;    //部门名称
protected string mstrDepartmentAbbrName;    //部门简称
protected string mstrDepartmentTypeId;    //部门类型Id
protected string mstrUpDepartmentId;    //上级部门Id
protected bool mbolInUse;    //是否在用
protected int? mintOrderNum;    //序号
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsDepartmentInfoEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("DepartmentId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strDepartmentId">关键字:部门ID</param>
public clsDepartmentInfoEN(string strDepartmentId)
 {
strDepartmentId = strDepartmentId.Replace("'", "''");
if (strDepartmentId.Length > 6)
{
throw new Exception("在表:DepartmentInfo中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strDepartmentId)  ==  true)
{
throw new Exception("在表:DepartmentInfo中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strDepartmentId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrDepartmentId = strDepartmentId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("DepartmentId");
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
if (strAttributeName  ==  conDepartmentInfo.DepartmentId)
{
return mstrDepartmentId;
}
else if (strAttributeName  ==  conDepartmentInfo.DepartmentName)
{
return mstrDepartmentName;
}
else if (strAttributeName  ==  conDepartmentInfo.DepartmentAbbrName)
{
return mstrDepartmentAbbrName;
}
else if (strAttributeName  ==  conDepartmentInfo.DepartmentTypeId)
{
return mstrDepartmentTypeId;
}
else if (strAttributeName  ==  conDepartmentInfo.UpDepartmentId)
{
return mstrUpDepartmentId;
}
else if (strAttributeName  ==  conDepartmentInfo.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  conDepartmentInfo.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conDepartmentInfo.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conDepartmentInfo.DepartmentId)
{
mstrDepartmentId = value.ToString();
 AddUpdatedFld(conDepartmentInfo.DepartmentId);
}
else if (strAttributeName  ==  conDepartmentInfo.DepartmentName)
{
mstrDepartmentName = value.ToString();
 AddUpdatedFld(conDepartmentInfo.DepartmentName);
}
else if (strAttributeName  ==  conDepartmentInfo.DepartmentAbbrName)
{
mstrDepartmentAbbrName = value.ToString();
 AddUpdatedFld(conDepartmentInfo.DepartmentAbbrName);
}
else if (strAttributeName  ==  conDepartmentInfo.DepartmentTypeId)
{
mstrDepartmentTypeId = value.ToString();
 AddUpdatedFld(conDepartmentInfo.DepartmentTypeId);
}
else if (strAttributeName  ==  conDepartmentInfo.UpDepartmentId)
{
mstrUpDepartmentId = value.ToString();
 AddUpdatedFld(conDepartmentInfo.UpDepartmentId);
}
else if (strAttributeName  ==  conDepartmentInfo.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conDepartmentInfo.InUse);
}
else if (strAttributeName  ==  conDepartmentInfo.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conDepartmentInfo.OrderNum);
}
else if (strAttributeName  ==  conDepartmentInfo.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDepartmentInfo.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conDepartmentInfo.DepartmentId  ==  _AttributeName[intIndex])
{
return mstrDepartmentId;
}
else if (conDepartmentInfo.DepartmentName  ==  _AttributeName[intIndex])
{
return mstrDepartmentName;
}
else if (conDepartmentInfo.DepartmentAbbrName  ==  _AttributeName[intIndex])
{
return mstrDepartmentAbbrName;
}
else if (conDepartmentInfo.DepartmentTypeId  ==  _AttributeName[intIndex])
{
return mstrDepartmentTypeId;
}
else if (conDepartmentInfo.UpDepartmentId  ==  _AttributeName[intIndex])
{
return mstrUpDepartmentId;
}
else if (conDepartmentInfo.InUse  ==  _AttributeName[intIndex])
{
return mbolInUse;
}
else if (conDepartmentInfo.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conDepartmentInfo.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conDepartmentInfo.DepartmentId  ==  _AttributeName[intIndex])
{
mstrDepartmentId = value.ToString();
 AddUpdatedFld(conDepartmentInfo.DepartmentId);
}
else if (conDepartmentInfo.DepartmentName  ==  _AttributeName[intIndex])
{
mstrDepartmentName = value.ToString();
 AddUpdatedFld(conDepartmentInfo.DepartmentName);
}
else if (conDepartmentInfo.DepartmentAbbrName  ==  _AttributeName[intIndex])
{
mstrDepartmentAbbrName = value.ToString();
 AddUpdatedFld(conDepartmentInfo.DepartmentAbbrName);
}
else if (conDepartmentInfo.DepartmentTypeId  ==  _AttributeName[intIndex])
{
mstrDepartmentTypeId = value.ToString();
 AddUpdatedFld(conDepartmentInfo.DepartmentTypeId);
}
else if (conDepartmentInfo.UpDepartmentId  ==  _AttributeName[intIndex])
{
mstrUpDepartmentId = value.ToString();
 AddUpdatedFld(conDepartmentInfo.UpDepartmentId);
}
else if (conDepartmentInfo.InUse  ==  _AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conDepartmentInfo.InUse);
}
else if (conDepartmentInfo.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conDepartmentInfo.OrderNum);
}
else if (conDepartmentInfo.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDepartmentInfo.Memo);
}
}
}

/// <summary>
/// 部门ID(说明:;字段类型:varchar;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DepartmentId
{
get
{
return mstrDepartmentId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDepartmentId = value;
}
else
{
 mstrDepartmentId = value;
}
//记录修改过的字段
 AddUpdatedFld(conDepartmentInfo.DepartmentId);
}
}
/// <summary>
/// 部门名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DepartmentName
{
get
{
return mstrDepartmentName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDepartmentName = value;
}
else
{
 mstrDepartmentName = value;
}
//记录修改过的字段
 AddUpdatedFld(conDepartmentInfo.DepartmentName);
}
}
/// <summary>
/// 部门简称(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DepartmentAbbrName
{
get
{
return mstrDepartmentAbbrName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDepartmentAbbrName = value;
}
else
{
 mstrDepartmentAbbrName = value;
}
//记录修改过的字段
 AddUpdatedFld(conDepartmentInfo.DepartmentAbbrName);
}
}
/// <summary>
/// 部门类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DepartmentTypeId
{
get
{
return mstrDepartmentTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDepartmentTypeId = value;
}
else
{
 mstrDepartmentTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conDepartmentInfo.DepartmentTypeId);
}
}
/// <summary>
/// 上级部门Id(说明:;字段类型:varchar;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpDepartmentId
{
get
{
return mstrUpDepartmentId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpDepartmentId = value;
}
else
{
 mstrUpDepartmentId = value;
}
//记录修改过的字段
 AddUpdatedFld(conDepartmentInfo.UpDepartmentId);
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
 AddUpdatedFld(conDepartmentInfo.InUse);
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
 AddUpdatedFld(conDepartmentInfo.OrderNum);
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
 AddUpdatedFld(conDepartmentInfo.Memo);
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
  return mstrDepartmentId;
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
  return mstrDepartmentName;
 }
 }
}
 /// <summary>
 /// 部门(DepartmentInfo)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conDepartmentInfo
{
public const string _CurrTabName = "DepartmentInfo"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "DepartmentId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"DepartmentId", "DepartmentName", "DepartmentAbbrName", "DepartmentTypeId", "UpDepartmentId", "InUse", "OrderNum", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"DepartmentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DepartmentId = "DepartmentId";    //部门ID

 /// <summary>
 /// 常量:"DepartmentName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DepartmentName = "DepartmentName";    //部门名称

 /// <summary>
 /// 常量:"DepartmentAbbrName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DepartmentAbbrName = "DepartmentAbbrName";    //部门简称

 /// <summary>
 /// 常量:"DepartmentTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DepartmentTypeId = "DepartmentTypeId";    //部门类型Id

 /// <summary>
 /// 常量:"UpDepartmentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpDepartmentId = "UpDepartmentId";    //上级部门Id

 /// <summary>
 /// 常量:"InUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InUse = "InUse";    //是否在用

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