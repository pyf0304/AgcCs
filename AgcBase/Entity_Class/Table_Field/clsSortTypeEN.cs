
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSortTypeEN
 表名:SortType(00050335)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:09:18
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
 /// 表SortType的关键字(SortTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_SortTypeId_SortType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strSortTypeId">表关键字</param>
public K_SortTypeId_SortType(string strSortTypeId)
{
if (IsValid(strSortTypeId)) Value = strSortTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strSortTypeId)
{
if (string.IsNullOrEmpty(strSortTypeId) == true) return false;
if (strSortTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_SortTypeId_SortType]类型的对象</returns>
public static implicit operator K_SortTypeId_SortType(string value)
{
return new K_SortTypeId_SortType(value);
}
}
 /// <summary>
 /// 排序类型(SortType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsSortTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "SortType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "SortTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 6;
public static string[] _AttributeName = new string[] {"SortTypeId", "SortTypeName", "SortTypeENName", "UpdDate", "UpdUser", "Memo"};

protected string mstrSortTypeId;    //排序类型Id
protected string mstrSortTypeName;    //排序类型名称
protected string mstrSortTypeENName;    //排序类型英文名
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsSortTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("SortTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strSortTypeId">关键字:排序类型Id</param>
public clsSortTypeEN(string strSortTypeId)
 {
strSortTypeId = strSortTypeId.Replace("'", "''");
if (strSortTypeId.Length > 2)
{
throw new Exception("在表:SortType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strSortTypeId)  ==  true)
{
throw new Exception("在表:SortType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strSortTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrSortTypeId = strSortTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("SortTypeId");
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
if (strAttributeName  ==  conSortType.SortTypeId)
{
return mstrSortTypeId;
}
else if (strAttributeName  ==  conSortType.SortTypeName)
{
return mstrSortTypeName;
}
else if (strAttributeName  ==  conSortType.SortTypeENName)
{
return mstrSortTypeENName;
}
else if (strAttributeName  ==  conSortType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conSortType.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conSortType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conSortType.SortTypeId)
{
mstrSortTypeId = value.ToString();
 AddUpdatedFld(conSortType.SortTypeId);
}
else if (strAttributeName  ==  conSortType.SortTypeName)
{
mstrSortTypeName = value.ToString();
 AddUpdatedFld(conSortType.SortTypeName);
}
else if (strAttributeName  ==  conSortType.SortTypeENName)
{
mstrSortTypeENName = value.ToString();
 AddUpdatedFld(conSortType.SortTypeENName);
}
else if (strAttributeName  ==  conSortType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conSortType.UpdDate);
}
else if (strAttributeName  ==  conSortType.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conSortType.UpdUser);
}
else if (strAttributeName  ==  conSortType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSortType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conSortType.SortTypeId  ==  _AttributeName[intIndex])
{
return mstrSortTypeId;
}
else if (conSortType.SortTypeName  ==  _AttributeName[intIndex])
{
return mstrSortTypeName;
}
else if (conSortType.SortTypeENName  ==  _AttributeName[intIndex])
{
return mstrSortTypeENName;
}
else if (conSortType.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conSortType.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conSortType.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conSortType.SortTypeId  ==  _AttributeName[intIndex])
{
mstrSortTypeId = value.ToString();
 AddUpdatedFld(conSortType.SortTypeId);
}
else if (conSortType.SortTypeName  ==  _AttributeName[intIndex])
{
mstrSortTypeName = value.ToString();
 AddUpdatedFld(conSortType.SortTypeName);
}
else if (conSortType.SortTypeENName  ==  _AttributeName[intIndex])
{
mstrSortTypeENName = value.ToString();
 AddUpdatedFld(conSortType.SortTypeENName);
}
else if (conSortType.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conSortType.UpdDate);
}
else if (conSortType.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conSortType.UpdUser);
}
else if (conSortType.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSortType.Memo);
}
}
}

/// <summary>
/// 排序类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SortTypeId
{
get
{
return mstrSortTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSortTypeId = value;
}
else
{
 mstrSortTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSortType.SortTypeId);
}
}
/// <summary>
/// 排序类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SortTypeName
{
get
{
return mstrSortTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSortTypeName = value;
}
else
{
 mstrSortTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conSortType.SortTypeName);
}
}
/// <summary>
/// 排序类型英文名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SortTypeENName
{
get
{
return mstrSortTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSortTypeENName = value;
}
else
{
 mstrSortTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conSortType.SortTypeENName);
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
 AddUpdatedFld(conSortType.UpdDate);
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
 AddUpdatedFld(conSortType.UpdUser);
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
 AddUpdatedFld(conSortType.Memo);
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
  return mstrSortTypeId;
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
  return mstrSortTypeName;
 }
 }
}
 /// <summary>
 /// 排序类型(SortType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conSortType
{
public const string _CurrTabName = "SortType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "SortTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"SortTypeId", "SortTypeName", "SortTypeENName", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"SortTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SortTypeId = "SortTypeId";    //排序类型Id

 /// <summary>
 /// 常量:"SortTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SortTypeName = "SortTypeName";    //排序类型名称

 /// <summary>
 /// 常量:"SortTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SortTypeENName = "SortTypeENName";    //排序类型英文名

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