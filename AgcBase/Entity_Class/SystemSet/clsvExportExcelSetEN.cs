
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvExportExcelSetEN
 表名:vExportExcelSet(00050238)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:13:14
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
 /// 表vExportExcelSet的关键字(IdExportExcel4Users)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdExportExcel4Users_vExportExcelSet
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
public K_IdExportExcel4Users_vExportExcelSet(string strIdExportExcel4Users)
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
 /// <returns>返回:[K_IdExportExcel4Users_vExportExcelSet]类型的对象</returns>
public static implicit operator K_IdExportExcel4Users_vExportExcelSet(string value)
{
return new K_IdExportExcel4Users_vExportExcelSet(value);
}
}
 /// <summary>
 /// v导出Excel设置(vExportExcelSet)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvExportExcelSetEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vExportExcelSet"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdExportExcel4Users"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 11;
public static string[] _AttributeName = new string[] {"IdExportExcel4Users", "ViewName", "TabName", "IsDefaultUser", "UserName", "ExportFileName", "UpdUserId", "UpdDate", "Memo", "UserId", "ViewTabName"};

protected string mstrIdExportExcel4Users;    //导出Excel用户字段流水号
protected string mstrViewName;    //界面名称
protected string mstrTabName;    //表名
protected bool mbolIsDefaultUser;    //是否缺省用户
protected string mstrUserName;    //用户名
protected string mstrExportFileName;    //导出文件名
protected string mstrUpdUserId;    //修改用户Id
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //说明
protected string mstrUserId;    //用户Id
protected string mstrViewTabName;    //ViewTabName

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvExportExcelSetEN()
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
public clsvExportExcelSetEN(string strIdExportExcel4Users)
 {
strIdExportExcel4Users = strIdExportExcel4Users.Replace("'", "''");
if (strIdExportExcel4Users.Length > 8)
{
throw new Exception("在表:vExportExcelSet中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdExportExcel4Users)  ==  true)
{
throw new Exception("在表:vExportExcelSet中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convExportExcelSet.IdExportExcel4Users)
{
return mstrIdExportExcel4Users;
}
else if (strAttributeName  ==  convExportExcelSet.ViewName)
{
return mstrViewName;
}
else if (strAttributeName  ==  convExportExcelSet.TabName)
{
return mstrTabName;
}
else if (strAttributeName  ==  convExportExcelSet.IsDefaultUser)
{
return mbolIsDefaultUser;
}
else if (strAttributeName  ==  convExportExcelSet.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convExportExcelSet.ExportFileName)
{
return mstrExportFileName;
}
else if (strAttributeName  ==  convExportExcelSet.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convExportExcelSet.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convExportExcelSet.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convExportExcelSet.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convExportExcelSet.ViewTabName)
{
return mstrViewTabName;
}
return null;
}
set
{
if (strAttributeName  ==  convExportExcelSet.IdExportExcel4Users)
{
mstrIdExportExcel4Users = value.ToString();
 AddUpdatedFld(convExportExcelSet.IdExportExcel4Users);
}
else if (strAttributeName  ==  convExportExcelSet.ViewName)
{
mstrViewName = value.ToString();
 AddUpdatedFld(convExportExcelSet.ViewName);
}
else if (strAttributeName  ==  convExportExcelSet.TabName)
{
mstrTabName = value.ToString();
 AddUpdatedFld(convExportExcelSet.TabName);
}
else if (strAttributeName  ==  convExportExcelSet.IsDefaultUser)
{
mbolIsDefaultUser = TransNullToBool(value.ToString());
 AddUpdatedFld(convExportExcelSet.IsDefaultUser);
}
else if (strAttributeName  ==  convExportExcelSet.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convExportExcelSet.UserName);
}
else if (strAttributeName  ==  convExportExcelSet.ExportFileName)
{
mstrExportFileName = value.ToString();
 AddUpdatedFld(convExportExcelSet.ExportFileName);
}
else if (strAttributeName  ==  convExportExcelSet.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convExportExcelSet.UpdUserId);
}
else if (strAttributeName  ==  convExportExcelSet.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convExportExcelSet.UpdDate);
}
else if (strAttributeName  ==  convExportExcelSet.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convExportExcelSet.Memo);
}
else if (strAttributeName  ==  convExportExcelSet.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convExportExcelSet.UserId);
}
else if (strAttributeName  ==  convExportExcelSet.ViewTabName)
{
mstrViewTabName = value.ToString();
 AddUpdatedFld(convExportExcelSet.ViewTabName);
}
}
}
public object this[int intIndex]
{
get
{
if (convExportExcelSet.IdExportExcel4Users  ==  _AttributeName[intIndex])
{
return mstrIdExportExcel4Users;
}
else if (convExportExcelSet.ViewName  ==  _AttributeName[intIndex])
{
return mstrViewName;
}
else if (convExportExcelSet.TabName  ==  _AttributeName[intIndex])
{
return mstrTabName;
}
else if (convExportExcelSet.IsDefaultUser  ==  _AttributeName[intIndex])
{
return mbolIsDefaultUser;
}
else if (convExportExcelSet.UserName  ==  _AttributeName[intIndex])
{
return mstrUserName;
}
else if (convExportExcelSet.ExportFileName  ==  _AttributeName[intIndex])
{
return mstrExportFileName;
}
else if (convExportExcelSet.UpdUserId  ==  _AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convExportExcelSet.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convExportExcelSet.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (convExportExcelSet.UserId  ==  _AttributeName[intIndex])
{
return mstrUserId;
}
else if (convExportExcelSet.ViewTabName  ==  _AttributeName[intIndex])
{
return mstrViewTabName;
}
return null;
}
set
{
if (convExportExcelSet.IdExportExcel4Users  ==  _AttributeName[intIndex])
{
mstrIdExportExcel4Users = value.ToString();
 AddUpdatedFld(convExportExcelSet.IdExportExcel4Users);
}
else if (convExportExcelSet.ViewName  ==  _AttributeName[intIndex])
{
mstrViewName = value.ToString();
 AddUpdatedFld(convExportExcelSet.ViewName);
}
else if (convExportExcelSet.TabName  ==  _AttributeName[intIndex])
{
mstrTabName = value.ToString();
 AddUpdatedFld(convExportExcelSet.TabName);
}
else if (convExportExcelSet.IsDefaultUser  ==  _AttributeName[intIndex])
{
mbolIsDefaultUser = TransNullToBool(value.ToString());
 AddUpdatedFld(convExportExcelSet.IsDefaultUser);
}
else if (convExportExcelSet.UserName  ==  _AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convExportExcelSet.UserName);
}
else if (convExportExcelSet.ExportFileName  ==  _AttributeName[intIndex])
{
mstrExportFileName = value.ToString();
 AddUpdatedFld(convExportExcelSet.ExportFileName);
}
else if (convExportExcelSet.UpdUserId  ==  _AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convExportExcelSet.UpdUserId);
}
else if (convExportExcelSet.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convExportExcelSet.UpdDate);
}
else if (convExportExcelSet.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convExportExcelSet.Memo);
}
else if (convExportExcelSet.UserId  ==  _AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convExportExcelSet.UserId);
}
else if (convExportExcelSet.ViewTabName  ==  _AttributeName[intIndex])
{
mstrViewTabName = value.ToString();
 AddUpdatedFld(convExportExcelSet.ViewTabName);
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
 AddUpdatedFld(convExportExcelSet.IdExportExcel4Users);
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
 AddUpdatedFld(convExportExcelSet.ViewName);
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
 AddUpdatedFld(convExportExcelSet.TabName);
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
 AddUpdatedFld(convExportExcelSet.IsDefaultUser);
}
}
/// <summary>
/// 用户名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserName
{
get
{
return mstrUserName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserName = value;
}
else
{
 mstrUserName = value;
}
//记录修改过的字段
 AddUpdatedFld(convExportExcelSet.UserName);
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
 AddUpdatedFld(convExportExcelSet.ExportFileName);
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
 AddUpdatedFld(convExportExcelSet.UpdUserId);
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
 AddUpdatedFld(convExportExcelSet.UpdDate);
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
 AddUpdatedFld(convExportExcelSet.Memo);
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
 AddUpdatedFld(convExportExcelSet.UserId);
}
}
/// <summary>
/// ViewTabName(说明:;字段类型:varchar;字段长度:101;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewTabName
{
get
{
return mstrViewTabName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewTabName = value;
}
else
{
 mstrViewTabName = value;
}
//记录修改过的字段
 AddUpdatedFld(convExportExcelSet.ViewTabName);
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

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrViewTabName;
 }
 }
}
 /// <summary>
 /// v导出Excel设置(vExportExcelSet)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convExportExcelSet
{
public const string _CurrTabName = "vExportExcelSet"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdExportExcel4Users"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"IdExportExcel4Users", "ViewName", "TabName", "IsDefaultUser", "UserName", "ExportFileName", "UpdUserId", "UpdDate", "Memo", "UserId", "ViewTabName"};
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
 /// 常量:"IsDefaultUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDefaultUser = "IsDefaultUser";    //是否缺省用户

 /// <summary>
 /// 常量:"UserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserName = "UserName";    //用户名

 /// <summary>
 /// 常量:"ExportFileName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExportFileName = "ExportFileName";    //导出文件名

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

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户Id

 /// <summary>
 /// 常量:"ViewTabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewTabName = "ViewTabName";    //ViewTabName
}

}