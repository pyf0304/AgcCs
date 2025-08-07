
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvExportExcel4UsersEN
 表名:vExportExcel4Users(00050239)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:37:14
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
 /// 表vExportExcel4Users的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vExportExcel4Users
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
public K_mId_vExportExcel4Users(long lngmId)
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
 /// <returns>返回:[K_mId_vExportExcel4Users]类型的对象</returns>
public static implicit operator K_mId_vExportExcel4Users(long value)
{
return new K_mId_vExportExcel4Users(value);
}
}
 /// <summary>
 /// v导出Excel用户字段(vExportExcel4Users)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvExportExcel4UsersEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vExportExcel4Users"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 15;
public static string[] _AttributeName = new string[] {"mId", "IdExportExcel4Users", "ViewName", "TabName", "IsDefaultUser", "UserId", "UserName", "ExportFileName", "FieldName", "FieldCnName", "IsExport", "OrderNum", "UpdDate", "UpdUserId", "Memo"};

protected long mlngmId;    //mId
protected string mstrIdExportExcel4Users;    //导出Excel用户字段流水号
protected string mstrViewName;    //界面名称
protected string mstrTabName;    //表名
protected bool mbolIsDefaultUser;    //是否缺省用户
protected string mstrUserId;    //用户Id
protected string mstrUserName;    //用户名
protected string mstrExportFileName;    //导出文件名
protected string mstrFieldName;    //字段名
protected string mstrFieldCnName;    //字段中文名称
protected bool mbolIsExport;    //是否导出
protected int? mintOrderNum;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvExportExcel4UsersEN()
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
public clsvExportExcel4UsersEN(long lngmId)
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
if (strAttributeName  ==  convExportExcel4Users.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convExportExcel4Users.IdExportExcel4Users)
{
return mstrIdExportExcel4Users;
}
else if (strAttributeName  ==  convExportExcel4Users.ViewName)
{
return mstrViewName;
}
else if (strAttributeName  ==  convExportExcel4Users.TabName)
{
return mstrTabName;
}
else if (strAttributeName  ==  convExportExcel4Users.IsDefaultUser)
{
return mbolIsDefaultUser;
}
else if (strAttributeName  ==  convExportExcel4Users.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convExportExcel4Users.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convExportExcel4Users.ExportFileName)
{
return mstrExportFileName;
}
else if (strAttributeName  ==  convExportExcel4Users.FieldName)
{
return mstrFieldName;
}
else if (strAttributeName  ==  convExportExcel4Users.FieldCnName)
{
return mstrFieldCnName;
}
else if (strAttributeName  ==  convExportExcel4Users.IsExport)
{
return mbolIsExport;
}
else if (strAttributeName  ==  convExportExcel4Users.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convExportExcel4Users.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convExportExcel4Users.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convExportExcel4Users.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convExportExcel4Users.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convExportExcel4Users.mId);
}
else if (strAttributeName  ==  convExportExcel4Users.IdExportExcel4Users)
{
mstrIdExportExcel4Users = value.ToString();
 AddUpdatedFld(convExportExcel4Users.IdExportExcel4Users);
}
else if (strAttributeName  ==  convExportExcel4Users.ViewName)
{
mstrViewName = value.ToString();
 AddUpdatedFld(convExportExcel4Users.ViewName);
}
else if (strAttributeName  ==  convExportExcel4Users.TabName)
{
mstrTabName = value.ToString();
 AddUpdatedFld(convExportExcel4Users.TabName);
}
else if (strAttributeName  ==  convExportExcel4Users.IsDefaultUser)
{
mbolIsDefaultUser = TransNullToBool(value.ToString());
 AddUpdatedFld(convExportExcel4Users.IsDefaultUser);
}
else if (strAttributeName  ==  convExportExcel4Users.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convExportExcel4Users.UserId);
}
else if (strAttributeName  ==  convExportExcel4Users.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convExportExcel4Users.UserName);
}
else if (strAttributeName  ==  convExportExcel4Users.ExportFileName)
{
mstrExportFileName = value.ToString();
 AddUpdatedFld(convExportExcel4Users.ExportFileName);
}
else if (strAttributeName  ==  convExportExcel4Users.FieldName)
{
mstrFieldName = value.ToString();
 AddUpdatedFld(convExportExcel4Users.FieldName);
}
else if (strAttributeName  ==  convExportExcel4Users.FieldCnName)
{
mstrFieldCnName = value.ToString();
 AddUpdatedFld(convExportExcel4Users.FieldCnName);
}
else if (strAttributeName  ==  convExportExcel4Users.IsExport)
{
mbolIsExport = TransNullToBool(value.ToString());
 AddUpdatedFld(convExportExcel4Users.IsExport);
}
else if (strAttributeName  ==  convExportExcel4Users.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convExportExcel4Users.OrderNum);
}
else if (strAttributeName  ==  convExportExcel4Users.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convExportExcel4Users.UpdDate);
}
else if (strAttributeName  ==  convExportExcel4Users.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convExportExcel4Users.UpdUserId);
}
else if (strAttributeName  ==  convExportExcel4Users.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convExportExcel4Users.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convExportExcel4Users.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (convExportExcel4Users.IdExportExcel4Users  ==  _AttributeName[intIndex])
{
return mstrIdExportExcel4Users;
}
else if (convExportExcel4Users.ViewName  ==  _AttributeName[intIndex])
{
return mstrViewName;
}
else if (convExportExcel4Users.TabName  ==  _AttributeName[intIndex])
{
return mstrTabName;
}
else if (convExportExcel4Users.IsDefaultUser  ==  _AttributeName[intIndex])
{
return mbolIsDefaultUser;
}
else if (convExportExcel4Users.UserId  ==  _AttributeName[intIndex])
{
return mstrUserId;
}
else if (convExportExcel4Users.UserName  ==  _AttributeName[intIndex])
{
return mstrUserName;
}
else if (convExportExcel4Users.ExportFileName  ==  _AttributeName[intIndex])
{
return mstrExportFileName;
}
else if (convExportExcel4Users.FieldName  ==  _AttributeName[intIndex])
{
return mstrFieldName;
}
else if (convExportExcel4Users.FieldCnName  ==  _AttributeName[intIndex])
{
return mstrFieldCnName;
}
else if (convExportExcel4Users.IsExport  ==  _AttributeName[intIndex])
{
return mbolIsExport;
}
else if (convExportExcel4Users.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convExportExcel4Users.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convExportExcel4Users.UpdUserId  ==  _AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convExportExcel4Users.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convExportExcel4Users.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convExportExcel4Users.mId);
}
else if (convExportExcel4Users.IdExportExcel4Users  ==  _AttributeName[intIndex])
{
mstrIdExportExcel4Users = value.ToString();
 AddUpdatedFld(convExportExcel4Users.IdExportExcel4Users);
}
else if (convExportExcel4Users.ViewName  ==  _AttributeName[intIndex])
{
mstrViewName = value.ToString();
 AddUpdatedFld(convExportExcel4Users.ViewName);
}
else if (convExportExcel4Users.TabName  ==  _AttributeName[intIndex])
{
mstrTabName = value.ToString();
 AddUpdatedFld(convExportExcel4Users.TabName);
}
else if (convExportExcel4Users.IsDefaultUser  ==  _AttributeName[intIndex])
{
mbolIsDefaultUser = TransNullToBool(value.ToString());
 AddUpdatedFld(convExportExcel4Users.IsDefaultUser);
}
else if (convExportExcel4Users.UserId  ==  _AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convExportExcel4Users.UserId);
}
else if (convExportExcel4Users.UserName  ==  _AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convExportExcel4Users.UserName);
}
else if (convExportExcel4Users.ExportFileName  ==  _AttributeName[intIndex])
{
mstrExportFileName = value.ToString();
 AddUpdatedFld(convExportExcel4Users.ExportFileName);
}
else if (convExportExcel4Users.FieldName  ==  _AttributeName[intIndex])
{
mstrFieldName = value.ToString();
 AddUpdatedFld(convExportExcel4Users.FieldName);
}
else if (convExportExcel4Users.FieldCnName  ==  _AttributeName[intIndex])
{
mstrFieldCnName = value.ToString();
 AddUpdatedFld(convExportExcel4Users.FieldCnName);
}
else if (convExportExcel4Users.IsExport  ==  _AttributeName[intIndex])
{
mbolIsExport = TransNullToBool(value.ToString());
 AddUpdatedFld(convExportExcel4Users.IsExport);
}
else if (convExportExcel4Users.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convExportExcel4Users.OrderNum);
}
else if (convExportExcel4Users.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convExportExcel4Users.UpdDate);
}
else if (convExportExcel4Users.UpdUserId  ==  _AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convExportExcel4Users.UpdUserId);
}
else if (convExportExcel4Users.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convExportExcel4Users.Memo);
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
 AddUpdatedFld(convExportExcel4Users.mId);
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
 AddUpdatedFld(convExportExcel4Users.IdExportExcel4Users);
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
 AddUpdatedFld(convExportExcel4Users.ViewName);
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
 AddUpdatedFld(convExportExcel4Users.TabName);
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
 AddUpdatedFld(convExportExcel4Users.IsDefaultUser);
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
 AddUpdatedFld(convExportExcel4Users.UserId);
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
 AddUpdatedFld(convExportExcel4Users.UserName);
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
 AddUpdatedFld(convExportExcel4Users.ExportFileName);
}
}
/// <summary>
/// 字段名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FieldName
{
get
{
return mstrFieldName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFieldName = value;
}
else
{
 mstrFieldName = value;
}
//记录修改过的字段
 AddUpdatedFld(convExportExcel4Users.FieldName);
}
}
/// <summary>
/// 字段中文名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FieldCnName
{
get
{
return mstrFieldCnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFieldCnName = value;
}
else
{
 mstrFieldCnName = value;
}
//记录修改过的字段
 AddUpdatedFld(convExportExcel4Users.FieldCnName);
}
}
/// <summary>
/// 是否导出(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsExport
{
get
{
return mbolIsExport;
}
set
{
 mbolIsExport = value;
//记录修改过的字段
 AddUpdatedFld(convExportExcel4Users.IsExport);
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
 AddUpdatedFld(convExportExcel4Users.OrderNum);
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
 AddUpdatedFld(convExportExcel4Users.UpdDate);
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
 AddUpdatedFld(convExportExcel4Users.UpdUserId);
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
 AddUpdatedFld(convExportExcel4Users.Memo);
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
 /// v导出Excel用户字段(vExportExcel4Users)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convExportExcel4Users
{
public const string _CurrTabName = "vExportExcel4Users"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "IdExportExcel4Users", "ViewName", "TabName", "IsDefaultUser", "UserId", "UserName", "ExportFileName", "FieldName", "FieldCnName", "IsExport", "OrderNum", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

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
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户Id

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
 /// 常量:"FieldName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FieldName = "FieldName";    //字段名

 /// <summary>
 /// 常量:"FieldCnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FieldCnName = "FieldCnName";    //字段中文名称

 /// <summary>
 /// 常量:"IsExport"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsExport = "IsExport";    //是否导出

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

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