
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsExportExcelSetEN
 表名:ExportExcelSet(00050240)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:34:38
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
 /// 表ExportExcelSet的关键字(IdExportExcel4Users)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdExportExcel4Users_ExportExcelSet
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdExportExcel4Users">表关键字</param>
public K_IdExportExcel4Users_ExportExcelSet(string strIdExportExcel4Users)
{
if (IsValid(strIdExportExcel4Users)) Value = strIdExportExcel4Users;
else
{
Value = null;
}
}
private static bool IsValid(string strIdExportExcel4Users)
{
if (string.IsNullOrEmpty(strIdExportExcel4Users) == true) return false;
if (strIdExportExcel4Users.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdExportExcel4Users_ExportExcelSet]类型的对象</returns>
public static implicit operator K_IdExportExcel4Users_ExportExcelSet(string value)
{
return new K_IdExportExcel4Users_ExportExcelSet(value);
}
}
 /// <summary>
 /// 导出Excel设置(ExportExcelSet)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsExportExcelSetEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ExportExcelSet"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdExportExcel4Users"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 9;
public static string[] _AttributeName = new string[] {"IdExportExcel4Users", "ViewName", "TabName", "UserId", "IsDefaultUser", "ExportFileName", "UpdDate", "UpdUserId", "Memo"};

protected string mstrIdExportExcel4Users;    //导出Excel用户字段流水号
protected string mstrViewName;    //界面名称
protected string mstrTabName;    //表名
protected string mstrUserId;    //用户Id
protected bool mbolIsDefaultUser;    //是否缺省用户
protected string mstrExportFileName;    //导出文件名
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsExportExcelSetEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdExportExcel4Users");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strIdExportExcel4Users">关键字:导出Excel用户字段流水号</param>
public clsExportExcelSetEN(string strIdExportExcel4Users)
 {
strIdExportExcel4Users = strIdExportExcel4Users.Replace("'", "''");
if (strIdExportExcel4Users.Length > 8)
{
throw new Exception("在表:ExportExcelSet中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdExportExcel4Users)  ==  true)
{
throw new Exception("在表:ExportExcelSet中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdExportExcel4Users);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdExportExcel4Users = strIdExportExcel4Users;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdExportExcel4Users");
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
if (strAttributeName  ==  conExportExcelSet.IdExportExcel4Users)
{
return mstrIdExportExcel4Users;
}
else if (strAttributeName  ==  conExportExcelSet.ViewName)
{
return mstrViewName;
}
else if (strAttributeName  ==  conExportExcelSet.TabName)
{
return mstrTabName;
}
else if (strAttributeName  ==  conExportExcelSet.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conExportExcelSet.IsDefaultUser)
{
return mbolIsDefaultUser;
}
else if (strAttributeName  ==  conExportExcelSet.ExportFileName)
{
return mstrExportFileName;
}
else if (strAttributeName  ==  conExportExcelSet.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conExportExcelSet.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conExportExcelSet.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conExportExcelSet.IdExportExcel4Users)
{
mstrIdExportExcel4Users = value.ToString();
 AddUpdatedFld(conExportExcelSet.IdExportExcel4Users);
}
else if (strAttributeName  ==  conExportExcelSet.ViewName)
{
mstrViewName = value.ToString();
 AddUpdatedFld(conExportExcelSet.ViewName);
}
else if (strAttributeName  ==  conExportExcelSet.TabName)
{
mstrTabName = value.ToString();
 AddUpdatedFld(conExportExcelSet.TabName);
}
else if (strAttributeName  ==  conExportExcelSet.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conExportExcelSet.UserId);
}
else if (strAttributeName  ==  conExportExcelSet.IsDefaultUser)
{
mbolIsDefaultUser = TransNullToBool(value.ToString());
 AddUpdatedFld(conExportExcelSet.IsDefaultUser);
}
else if (strAttributeName  ==  conExportExcelSet.ExportFileName)
{
mstrExportFileName = value.ToString();
 AddUpdatedFld(conExportExcelSet.ExportFileName);
}
else if (strAttributeName  ==  conExportExcelSet.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conExportExcelSet.UpdDate);
}
else if (strAttributeName  ==  conExportExcelSet.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conExportExcelSet.UpdUserId);
}
else if (strAttributeName  ==  conExportExcelSet.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conExportExcelSet.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conExportExcelSet.IdExportExcel4Users  ==  _AttributeName[intIndex])
{
return mstrIdExportExcel4Users;
}
else if (conExportExcelSet.ViewName  ==  _AttributeName[intIndex])
{
return mstrViewName;
}
else if (conExportExcelSet.TabName  ==  _AttributeName[intIndex])
{
return mstrTabName;
}
else if (conExportExcelSet.UserId  ==  _AttributeName[intIndex])
{
return mstrUserId;
}
else if (conExportExcelSet.IsDefaultUser  ==  _AttributeName[intIndex])
{
return mbolIsDefaultUser;
}
else if (conExportExcelSet.ExportFileName  ==  _AttributeName[intIndex])
{
return mstrExportFileName;
}
else if (conExportExcelSet.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conExportExcelSet.UpdUserId  ==  _AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conExportExcelSet.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conExportExcelSet.IdExportExcel4Users  ==  _AttributeName[intIndex])
{
mstrIdExportExcel4Users = value.ToString();
 AddUpdatedFld(conExportExcelSet.IdExportExcel4Users);
}
else if (conExportExcelSet.ViewName  ==  _AttributeName[intIndex])
{
mstrViewName = value.ToString();
 AddUpdatedFld(conExportExcelSet.ViewName);
}
else if (conExportExcelSet.TabName  ==  _AttributeName[intIndex])
{
mstrTabName = value.ToString();
 AddUpdatedFld(conExportExcelSet.TabName);
}
else if (conExportExcelSet.UserId  ==  _AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conExportExcelSet.UserId);
}
else if (conExportExcelSet.IsDefaultUser  ==  _AttributeName[intIndex])
{
mbolIsDefaultUser = TransNullToBool(value.ToString());
 AddUpdatedFld(conExportExcelSet.IsDefaultUser);
}
else if (conExportExcelSet.ExportFileName  ==  _AttributeName[intIndex])
{
mstrExportFileName = value.ToString();
 AddUpdatedFld(conExportExcelSet.ExportFileName);
}
else if (conExportExcelSet.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conExportExcelSet.UpdDate);
}
else if (conExportExcelSet.UpdUserId  ==  _AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conExportExcelSet.UpdUserId);
}
else if (conExportExcelSet.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conExportExcelSet.Memo);
}
}
}

/// <summary>
/// 导出Excel用户字段流水号(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdExportExcel4Users
{
get
{
return mstrIdExportExcel4Users;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdExportExcel4Users = value;
}
else
{
 mstrIdExportExcel4Users = value;
}
//记录修改过的字段
 AddUpdatedFld(conExportExcelSet.IdExportExcel4Users);
}
}
/// <summary>
/// 界面名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewName
{
get
{
return mstrViewName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewName = value;
}
else
{
 mstrViewName = value;
}
//记录修改过的字段
 AddUpdatedFld(conExportExcelSet.ViewName);
}
}
/// <summary>
/// 表名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabName
{
get
{
return mstrTabName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabName = value;
}
else
{
 mstrTabName = value;
}
//记录修改过的字段
 AddUpdatedFld(conExportExcelSet.TabName);
}
}
/// <summary>
/// 用户Id(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserId
{
get
{
return mstrUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserId = value;
}
else
{
 mstrUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conExportExcelSet.UserId);
}
}
/// <summary>
/// 是否缺省用户(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsDefaultUser
{
get
{
return mbolIsDefaultUser;
}
set
{
 mbolIsDefaultUser = value;
//记录修改过的字段
 AddUpdatedFld(conExportExcelSet.IsDefaultUser);
}
}
/// <summary>
/// 导出文件名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExportFileName
{
get
{
return mstrExportFileName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExportFileName = value;
}
else
{
 mstrExportFileName = value;
}
//记录修改过的字段
 AddUpdatedFld(conExportExcelSet.ExportFileName);
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
 AddUpdatedFld(conExportExcelSet.UpdDate);
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
 AddUpdatedFld(conExportExcelSet.UpdUserId);
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
 AddUpdatedFld(conExportExcelSet.Memo);
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
  return mstrIdExportExcel4Users;
 }
 }
}
 /// <summary>
 /// 导出Excel设置(ExportExcelSet)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conExportExcelSet
{
public const string _CurrTabName = "ExportExcelSet"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdExportExcel4Users"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"IdExportExcel4Users", "ViewName", "TabName", "UserId", "IsDefaultUser", "ExportFileName", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdExportExcel4Users"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdExportExcel4Users = "IdExportExcel4Users";    //导出Excel用户字段流水号

 /// <summary>
 /// 常量:"ViewName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewName = "ViewName";    //界面名称

 /// <summary>
 /// 常量:"TabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabName = "TabName";    //表名

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户Id

 /// <summary>
 /// 常量:"IsDefaultUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDefaultUser = "IsDefaultUser";    //是否缺省用户

 /// <summary>
 /// 常量:"ExportFileName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExportFileName = "ExportFileName";    //导出文件名

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}