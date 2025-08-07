
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvDepartmentInfoEN
 表名:vDepartmentInfo(00050305)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:17:27
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:用户管理(UserManage)
 框架-层名:实体层(CS)(EntityLayer)
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

namespace AGC.Entity
{
 /// <summary>
 /// 表vDepartmentInfo的关键字(DepartmentId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_DepartmentId_vDepartmentInfo
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
public K_DepartmentId_vDepartmentInfo(string strDepartmentId)
{
if (IsValid(strDepartmentId)) Value = strDepartmentId;
else
{
Value = null;
}
}
private static bool IsValid(string strDepartmentId)
{
if (strDepartmentId.Length > 6) return false;
if (strDepartmentId.IndexOf(' ') >= 0) return false;
if (strDepartmentId.IndexOf(')') >= 0) return false;
if (strDepartmentId.IndexOf('(') >= 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_DepartmentId_vDepartmentInfo]类型的对象</returns>
public static implicit operator K_DepartmentId_vDepartmentInfo(string value)
{
return new K_DepartmentId_vDepartmentInfo(value);
}
}
 /// <summary>
 /// v部门(vDepartmentInfo)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvDepartmentInfoEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接，如果为空就使用系统默认的连接
public new const string _CurrTabName = "vDepartmentInfo"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "DepartmentId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string WhereFormat = ""; //条件格式串
protected const int mintAttributeCount = 11;
public static string[] AttributeName = new string[] {"DepartmentId", "DepartmentName", "DepartmentAbbrName", "DepartmentTypeId", "UpDepartmentId", "DepartmentTypeName", "InUse", "OrderNum", "Memo", "UpDepartmentName", "UserNum"};

protected string mstrDepartmentId;    //部门ID
protected string mstrDepartmentName;    //部门名称
protected string mstrDepartmentAbbrName;    //部门简称
protected string mstrDepartmentTypeId;    //部门类型Id
protected string mstrUpDepartmentId;    //上级部门Id
protected string mstrDepartmentTypeName;    //部门类型
protected bool mbolInUse;    //是否在用
protected int mintOrderNum;    //序号
protected string mstrMemo;    //说明
protected string mstrUpDepartmentName;    //上级部门名
protected int? mintUserNum;    //UserNum

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvDepartmentInfoEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "vDepartmentInfo";
 lstKeyFldNames.Add("DepartmentId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strDepartmentId">关键字:部门ID</param>
public clsvDepartmentInfoEN(string strDepartmentId)
 {
strDepartmentId = strDepartmentId.Replace("'", "''");
if (strDepartmentId.Length > 6)
{
throw new Exception("在表:vDepartmentInfo中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strDepartmentId)  ==  true)
{
throw new Exception("在表:vDepartmentInfo中,关键字不能为空 或 null!");
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
 //_CurrTabName = "vDepartmentInfo";
 lstKeyFldNames.Add("DepartmentId");
 }

public static int AttributeCount
{
get
{
return mintAttributeCount;
}
}
public override object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  convDepartmentInfo.DepartmentId)
{
return mstrDepartmentId;
}
else if (strAttributeName  ==  convDepartmentInfo.DepartmentName)
{
return mstrDepartmentName;
}
else if (strAttributeName  ==  convDepartmentInfo.DepartmentAbbrName)
{
return mstrDepartmentAbbrName;
}
else if (strAttributeName  ==  convDepartmentInfo.DepartmentTypeId)
{
return mstrDepartmentTypeId;
}
else if (strAttributeName  ==  convDepartmentInfo.UpDepartmentId)
{
return mstrUpDepartmentId;
}
else if (strAttributeName  ==  convDepartmentInfo.DepartmentTypeName)
{
return mstrDepartmentTypeName;
}
else if (strAttributeName  ==  convDepartmentInfo.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  convDepartmentInfo.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convDepartmentInfo.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convDepartmentInfo.UpDepartmentName)
{
return mstrUpDepartmentName;
}
else if (strAttributeName  ==  convDepartmentInfo.UserNum)
{
return mintUserNum;
}
return null;
}
set
{
if (strAttributeName  ==  convDepartmentInfo.DepartmentId)
{
mstrDepartmentId = value.ToString();
 AddUpdatedFld(convDepartmentInfo.DepartmentId);
}
else if (strAttributeName  ==  convDepartmentInfo.DepartmentName)
{
mstrDepartmentName = value.ToString();
 AddUpdatedFld(convDepartmentInfo.DepartmentName);
}
else if (strAttributeName  ==  convDepartmentInfo.DepartmentAbbrName)
{
mstrDepartmentAbbrName = value.ToString();
 AddUpdatedFld(convDepartmentInfo.DepartmentAbbrName);
}
else if (strAttributeName  ==  convDepartmentInfo.DepartmentTypeId)
{
mstrDepartmentTypeId = value.ToString();
 AddUpdatedFld(convDepartmentInfo.DepartmentTypeId);
}
else if (strAttributeName  ==  convDepartmentInfo.UpDepartmentId)
{
mstrUpDepartmentId = value.ToString();
 AddUpdatedFld(convDepartmentInfo.UpDepartmentId);
}
else if (strAttributeName  ==  convDepartmentInfo.DepartmentTypeName)
{
mstrDepartmentTypeName = value.ToString();
 AddUpdatedFld(convDepartmentInfo.DepartmentTypeName);
}
else if (strAttributeName  ==  convDepartmentInfo.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convDepartmentInfo.InUse);
}
else if (strAttributeName  ==  convDepartmentInfo.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convDepartmentInfo.OrderNum);
}
else if (strAttributeName  ==  convDepartmentInfo.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convDepartmentInfo.Memo);
}
else if (strAttributeName  ==  convDepartmentInfo.UpDepartmentName)
{
mstrUpDepartmentName = value.ToString();
 AddUpdatedFld(convDepartmentInfo.UpDepartmentName);
}
else if (strAttributeName  ==  convDepartmentInfo.UserNum)
{
mintUserNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convDepartmentInfo.UserNum);
}
}
}
public object this[int intIndex]
{
get
{
if (convDepartmentInfo.DepartmentId  ==  AttributeName[intIndex])
{
return mstrDepartmentId;
}
else if (convDepartmentInfo.DepartmentName  ==  AttributeName[intIndex])
{
return mstrDepartmentName;
}
else if (convDepartmentInfo.DepartmentAbbrName  ==  AttributeName[intIndex])
{
return mstrDepartmentAbbrName;
}
else if (convDepartmentInfo.DepartmentTypeId  ==  AttributeName[intIndex])
{
return mstrDepartmentTypeId;
}
else if (convDepartmentInfo.UpDepartmentId  ==  AttributeName[intIndex])
{
return mstrUpDepartmentId;
}
else if (convDepartmentInfo.DepartmentTypeName  ==  AttributeName[intIndex])
{
return mstrDepartmentTypeName;
}
else if (convDepartmentInfo.InUse  ==  AttributeName[intIndex])
{
return mbolInUse;
}
else if (convDepartmentInfo.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convDepartmentInfo.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convDepartmentInfo.UpDepartmentName  ==  AttributeName[intIndex])
{
return mstrUpDepartmentName;
}
else if (convDepartmentInfo.UserNum  ==  AttributeName[intIndex])
{
return mintUserNum;
}
return null;
}
set
{
if (convDepartmentInfo.DepartmentId  ==  AttributeName[intIndex])
{
mstrDepartmentId = value.ToString();
 AddUpdatedFld(convDepartmentInfo.DepartmentId);
}
else if (convDepartmentInfo.DepartmentName  ==  AttributeName[intIndex])
{
mstrDepartmentName = value.ToString();
 AddUpdatedFld(convDepartmentInfo.DepartmentName);
}
else if (convDepartmentInfo.DepartmentAbbrName  ==  AttributeName[intIndex])
{
mstrDepartmentAbbrName = value.ToString();
 AddUpdatedFld(convDepartmentInfo.DepartmentAbbrName);
}
else if (convDepartmentInfo.DepartmentTypeId  ==  AttributeName[intIndex])
{
mstrDepartmentTypeId = value.ToString();
 AddUpdatedFld(convDepartmentInfo.DepartmentTypeId);
}
else if (convDepartmentInfo.UpDepartmentId  ==  AttributeName[intIndex])
{
mstrUpDepartmentId = value.ToString();
 AddUpdatedFld(convDepartmentInfo.UpDepartmentId);
}
else if (convDepartmentInfo.DepartmentTypeName  ==  AttributeName[intIndex])
{
mstrDepartmentTypeName = value.ToString();
 AddUpdatedFld(convDepartmentInfo.DepartmentTypeName);
}
else if (convDepartmentInfo.InUse  ==  AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convDepartmentInfo.InUse);
}
else if (convDepartmentInfo.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convDepartmentInfo.OrderNum);
}
else if (convDepartmentInfo.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convDepartmentInfo.Memo);
}
else if (convDepartmentInfo.UpDepartmentName  ==  AttributeName[intIndex])
{
mstrUpDepartmentName = value.ToString();
 AddUpdatedFld(convDepartmentInfo.UpDepartmentName);
}
else if (convDepartmentInfo.UserNum  ==  AttributeName[intIndex])
{
mintUserNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convDepartmentInfo.UserNum);
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
 AddUpdatedFld(convDepartmentInfo.DepartmentId);
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
 AddUpdatedFld(convDepartmentInfo.DepartmentName);
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
 AddUpdatedFld(convDepartmentInfo.DepartmentAbbrName);
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
 AddUpdatedFld(convDepartmentInfo.DepartmentTypeId);
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
 AddUpdatedFld(convDepartmentInfo.UpDepartmentId);
}
}
/// <summary>
/// 部门类型(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DepartmentTypeName
{
get
{
return mstrDepartmentTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDepartmentTypeName = value;
}
else
{
 mstrDepartmentTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convDepartmentInfo.DepartmentTypeName);
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
 AddUpdatedFld(convDepartmentInfo.InUse);
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
 AddUpdatedFld(convDepartmentInfo.OrderNum);
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
 AddUpdatedFld(convDepartmentInfo.Memo);
}
}
/// <summary>
/// 上级部门名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpDepartmentName
{
get
{
return mstrUpDepartmentName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpDepartmentName = value;
}
else
{
 mstrUpDepartmentName = value;
}
//记录修改过的字段
 AddUpdatedFld(convDepartmentInfo.UpDepartmentName);
}
}
/// <summary>
/// UserNum(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? UserNum
{
get
{
return mintUserNum;
}
set
{
 mintUserNum = value;
//记录修改过的字段
 AddUpdatedFld(convDepartmentInfo.UserNum);
}
}

/// <summary>
/// 获取关键字Id(keyId)
 /// (AutoGCLib.clsGeneCodeBase:GenGetKeyId)
/// </summary>
 public override string _KeyId
 {
 get
 {
  return mstrDepartmentId;
 }
 }
}
 /// <summary>
 /// v部门(vDepartmentInfo)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convDepartmentInfo
{
public new const string _CurrTabName = "vDepartmentInfo"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "DepartmentId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"DepartmentId", "DepartmentName", "DepartmentAbbrName", "DepartmentTypeId", "UpDepartmentId", "DepartmentTypeName", "InUse", "OrderNum", "Memo", "UpDepartmentName", "UserNum"};
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
 /// 常量:"DepartmentTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DepartmentTypeName = "DepartmentTypeName";    //部门类型

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

 /// <summary>
 /// 常量:"UpDepartmentName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpDepartmentName = "UpDepartmentName";    //上级部门名

 /// <summary>
 /// 常量:"UserNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserNum = "UserNum";    //UserNum
}

}