
 ///----------------------
 ///生成代码版本:2016.06.03.1
 ///生成日期:2016/06/03
 ///生成者:潘文韬
 ///工程名称:养老服务平台
 ///工程ID:0167
 ///模块中文名:用户管理
 ///模块英文名:UserManage
 ///注意:1、需要数据底层(PubDataBase.dll)的版本:2016.05.23.01
 ///       2、需要公共函数层(TzPubFunction.dll)的版本:2016.05.23.01
 ///========================
using System;
using System.Text; 
using System.Collections; 
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;

namespace PensionSrv.Entity
{
 /// <summary>
 /// vUserRoleRelation(vUserRoleRelation)
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_M:A_GenEntityLayerCode)
 /// </summary>
[Serializable]
public class clsvUserRoleRelationEN : clsEntityBase2
{
public const string CurrTabName_S = "vUserRoleRelation"; //当前表名,与该类相关的表名
public const string CurrTabKeyFldName_S = "UserRoleRelationID"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 19;
public static string[] AttributeName = new string[] {"UserRoleRelationID", "UserName", "id_User", "UserStateId", "UserRoleId", "DepartmentId", "UserId", "Password", "Memo", "AreaId", "id_Sex", "Telephone", "Phone", "Fax", "IdentityCard", "UserAddress", "UserRoleName", "UpdDate", "UpdUser"};
 //以下是属性变量

protected long mlngUserRoleRelationID;    //用户角色关系表ID
protected string mstrUserName;    //用户名
protected string mstrid_User;    //用户主键
protected string mstrUserStateId;    //用户状态Id
protected string mstrUserRoleId;    //用户角色ID
protected string mstrDepartmentId;    //单位Id
protected string mstrUserId;    //用户账号
protected string mstrPassword;    //口令
protected string mstrMemo;    //备注
protected string mstrAreaId;    //区域ID
protected string mstrid_Sex;    //性别流水号
protected string mstrTelephone;    //电话
protected string mstrPhone;    //手机号
protected string mstrFax;    //传真
protected string mstrIdentityCard;    //身份证
protected string mstrUserAddress;    //用户住址
protected string mstrUserRoleName;    //角色名称
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改用户
protected int mintIntTag;    //整型Tag
protected string mstrStrTag;    //字符型标签
protected bool mbolIsCheckProperty;    //是否检查属性


 /// <summary>
 /// 常量:"UserRoleRelationID"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UserRoleRelationID = "UserRoleRelationID";    //用户角色关系表ID

 /// <summary>
 /// 常量:"UserName"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UserName = "UserName";    //用户名

 /// <summary>
 /// 常量:"id_User"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_id_User = "id_User";    //用户主键

 /// <summary>
 /// 常量:"UserStateId"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UserStateId = "UserStateId";    //用户状态Id

 /// <summary>
 /// 常量:"UserRoleId"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UserRoleId = "UserRoleId";    //用户角色ID

 /// <summary>
 /// 常量:"DepartmentId"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_DepartmentId = "DepartmentId";    //单位Id

 /// <summary>
 /// 常量:"UserId"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UserId = "UserId";    //用户账号

 /// <summary>
 /// 常量:"Password"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Password = "Password";    //口令

 /// <summary>
 /// 常量:"Memo"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"AreaId"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AreaId = "AreaId";    //区域ID

 /// <summary>
 /// 常量:"id_Sex"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_id_Sex = "id_Sex";    //性别流水号

 /// <summary>
 /// 常量:"Telephone"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Telephone = "Telephone";    //电话

 /// <summary>
 /// 常量:"Phone"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Phone = "Phone";    //手机号

 /// <summary>
 /// 常量:"Fax"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Fax = "Fax";    //传真

 /// <summary>
 /// 常量:"IdentityCard"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IdentityCard = "IdentityCard";    //身份证

 /// <summary>
 /// 常量:"UserAddress"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UserAddress = "UserAddress";    //用户住址

 /// <summary>
 /// 常量:"UserRoleName"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UserRoleName = "UserRoleName";    //角色名称

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpdUser = "UpdUser";    //修改用户

 /// <summary>
 /// 常量:"IntTag"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IntTag = "IntTag";    //整型Tag

 /// <summary>
 /// 常量:"StrTag"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_StrTag = "StrTag";    //字符型标签

 /// <summary>
 /// 常量:"IsCheckProperty"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsCheckProperty = "IsCheckProperty";    //是否检查属性

//用户指定的连接串,如果用户不指定该连接串,就用PUBDATABASE中所指定的连接串
private static string m_strConnectString;
 /// <summary>
 /// 当前所使用的连接串内容
 /// (AGC_CSV7.BusinessLogicEx.AutoGCPubFuncV6:GenConnectString)
 /// </summary>
public static string ConnectString
{
get { return m_strConnectString; }
set { m_strConnectString = value; }
}

/// <summary>
/// 构造函数
 /// (AGC_CSV7.BusinessLogicEx.AutoGCPubFuncV6:GenClassConstructor1)
/// </summary>
 public clsvUserRoleRelationEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 CurrTabName = "vUserRoleRelation";
 lstKeyFldNames.Add("UserRoleRelationID");
 }

/// <summary>
/// 构造函数
 /// (AGC_CSV7.BusinessLogicEx.AutoGCPubFuncV6:GenClassConstructor2)
/// </summary>
/// <param name="mlngUserRoleRelationID">关键字：用户角色关系表ID</param>
public clsvUserRoleRelationEN(long lngUserRoleRelationID)
 {
 if (lngUserRoleRelationID == 0)
 {
 throw new Exception("关键字不能为0!");
 }

mlngUserRoleRelationID=lngUserRoleRelationID;
 SetInit();
 mbolIsCheckProperty = false;
 CurrTabName = "vUserRoleRelation";
 lstKeyFldNames.Add("UserRoleRelationID");
 }

public static int AttributeCount
{
get
{
return mintAttributeCount;
}
}
public object this[string strAttributeName]
{
get
{
if (strAttributeName == con_UserRoleRelationID)
{
return mlngUserRoleRelationID;
}
else if (strAttributeName == con_UserName)
{
return mstrUserName;
}
else if (strAttributeName == con_id_User)
{
return mstrid_User;
}
else if (strAttributeName == con_UserStateId)
{
return mstrUserStateId;
}
else if (strAttributeName == con_UserRoleId)
{
return mstrUserRoleId;
}
else if (strAttributeName == con_DepartmentId)
{
return mstrDepartmentId;
}
else if (strAttributeName == con_UserId)
{
return mstrUserId;
}
else if (strAttributeName == con_Password)
{
return mstrPassword;
}
else if (strAttributeName == con_Memo)
{
return mstrMemo;
}
else if (strAttributeName == con_AreaId)
{
return mstrAreaId;
}
else if (strAttributeName == con_id_Sex)
{
return mstrid_Sex;
}
else if (strAttributeName == con_Telephone)
{
return mstrTelephone;
}
else if (strAttributeName == con_Phone)
{
return mstrPhone;
}
else if (strAttributeName == con_Fax)
{
return mstrFax;
}
else if (strAttributeName == con_IdentityCard)
{
return mstrIdentityCard;
}
else if (strAttributeName == con_UserAddress)
{
return mstrUserAddress;
}
else if (strAttributeName == con_UserRoleName)
{
return mstrUserRoleName;
}
else if (strAttributeName == con_UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName == con_UpdUser)
{
return mstrUpdUser;
}
return null;
}
set
{
if (strAttributeName == con_UserRoleRelationID)
{
mlngUserRoleRelationID = TransNullToInt(value.ToString());
 AddUpdatedFld(con_UserRoleRelationID);
}
else if (strAttributeName == con_UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(con_UserName);
}
else if (strAttributeName == con_id_User)
{
mstrid_User = value.ToString();
 AddUpdatedFld(con_id_User);
}
else if (strAttributeName == con_UserStateId)
{
mstrUserStateId = value.ToString();
 AddUpdatedFld(con_UserStateId);
}
else if (strAttributeName == con_UserRoleId)
{
mstrUserRoleId = value.ToString();
 AddUpdatedFld(con_UserRoleId);
}
else if (strAttributeName == con_DepartmentId)
{
mstrDepartmentId = value.ToString();
 AddUpdatedFld(con_DepartmentId);
}
else if (strAttributeName == con_UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(con_UserId);
}
else if (strAttributeName == con_Password)
{
mstrPassword = value.ToString();
 AddUpdatedFld(con_Password);
}
else if (strAttributeName == con_Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
}
else if (strAttributeName == con_AreaId)
{
mstrAreaId = value.ToString();
 AddUpdatedFld(con_AreaId);
}
else if (strAttributeName == con_id_Sex)
{
mstrid_Sex = value.ToString();
 AddUpdatedFld(con_id_Sex);
}
else if (strAttributeName == con_Telephone)
{
mstrTelephone = value.ToString();
 AddUpdatedFld(con_Telephone);
}
else if (strAttributeName == con_Phone)
{
mstrPhone = value.ToString();
 AddUpdatedFld(con_Phone);
}
else if (strAttributeName == con_Fax)
{
mstrFax = value.ToString();
 AddUpdatedFld(con_Fax);
}
else if (strAttributeName == con_IdentityCard)
{
mstrIdentityCard = value.ToString();
 AddUpdatedFld(con_IdentityCard);
}
else if (strAttributeName == con_UserAddress)
{
mstrUserAddress = value.ToString();
 AddUpdatedFld(con_UserAddress);
}
else if (strAttributeName == con_UserRoleName)
{
mstrUserRoleName = value.ToString();
 AddUpdatedFld(con_UserRoleName);
}
else if (strAttributeName == con_UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(con_UpdDate);
}
else if (strAttributeName == con_UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(con_UpdUser);
}
}
}
public object this[int intIndex]
{
get
{
if (con_UserRoleRelationID == AttributeName[intIndex])
{
return mlngUserRoleRelationID;
}
else if (con_UserName == AttributeName[intIndex])
{
return mstrUserName;
}
else if (con_id_User == AttributeName[intIndex])
{
return mstrid_User;
}
else if (con_UserStateId == AttributeName[intIndex])
{
return mstrUserStateId;
}
else if (con_UserRoleId == AttributeName[intIndex])
{
return mstrUserRoleId;
}
else if (con_DepartmentId == AttributeName[intIndex])
{
return mstrDepartmentId;
}
else if (con_UserId == AttributeName[intIndex])
{
return mstrUserId;
}
else if (con_Password == AttributeName[intIndex])
{
return mstrPassword;
}
else if (con_Memo == AttributeName[intIndex])
{
return mstrMemo;
}
else if (con_AreaId == AttributeName[intIndex])
{
return mstrAreaId;
}
else if (con_id_Sex == AttributeName[intIndex])
{
return mstrid_Sex;
}
else if (con_Telephone == AttributeName[intIndex])
{
return mstrTelephone;
}
else if (con_Phone == AttributeName[intIndex])
{
return mstrPhone;
}
else if (con_Fax == AttributeName[intIndex])
{
return mstrFax;
}
else if (con_IdentityCard == AttributeName[intIndex])
{
return mstrIdentityCard;
}
else if (con_UserAddress == AttributeName[intIndex])
{
return mstrUserAddress;
}
else if (con_UserRoleName == AttributeName[intIndex])
{
return mstrUserRoleName;
}
else if (con_UpdDate == AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (con_UpdUser == AttributeName[intIndex])
{
return mstrUpdUser;
}
return null;
}
set
{
if (con_UserRoleRelationID == AttributeName[intIndex])
{
mlngUserRoleRelationID = TransNullToInt(value.ToString());
 AddUpdatedFld(con_UserRoleRelationID);
}
else if (con_UserName == AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(con_UserName);
}
else if (con_id_User == AttributeName[intIndex])
{
mstrid_User = value.ToString();
 AddUpdatedFld(con_id_User);
}
else if (con_UserStateId == AttributeName[intIndex])
{
mstrUserStateId = value.ToString();
 AddUpdatedFld(con_UserStateId);
}
else if (con_UserRoleId == AttributeName[intIndex])
{
mstrUserRoleId = value.ToString();
 AddUpdatedFld(con_UserRoleId);
}
else if (con_DepartmentId == AttributeName[intIndex])
{
mstrDepartmentId = value.ToString();
 AddUpdatedFld(con_DepartmentId);
}
else if (con_UserId == AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(con_UserId);
}
else if (con_Password == AttributeName[intIndex])
{
mstrPassword = value.ToString();
 AddUpdatedFld(con_Password);
}
else if (con_Memo == AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
}
else if (con_AreaId == AttributeName[intIndex])
{
mstrAreaId = value.ToString();
 AddUpdatedFld(con_AreaId);
}
else if (con_id_Sex == AttributeName[intIndex])
{
mstrid_Sex = value.ToString();
 AddUpdatedFld(con_id_Sex);
}
else if (con_Telephone == AttributeName[intIndex])
{
mstrTelephone = value.ToString();
 AddUpdatedFld(con_Telephone);
}
else if (con_Phone == AttributeName[intIndex])
{
mstrPhone = value.ToString();
 AddUpdatedFld(con_Phone);
}
else if (con_Fax == AttributeName[intIndex])
{
mstrFax = value.ToString();
 AddUpdatedFld(con_Fax);
}
else if (con_IdentityCard == AttributeName[intIndex])
{
mstrIdentityCard = value.ToString();
 AddUpdatedFld(con_IdentityCard);
}
else if (con_UserAddress == AttributeName[intIndex])
{
mstrUserAddress = value.ToString();
 AddUpdatedFld(con_UserAddress);
}
else if (con_UserRoleName == AttributeName[intIndex])
{
mstrUserRoleName = value.ToString();
 AddUpdatedFld(con_UserRoleName);
}
else if (con_UpdDate == AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(con_UpdDate);
}
else if (con_UpdUser == AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(con_UpdUser);
}
}
}

/// <summary>
/// 用户角色关系表ID(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public long UserRoleRelationID
{
get
{
return mlngUserRoleRelationID;
}
set
{
 mlngUserRoleRelationID = value;
//记录修改过的字段
 AddUpdatedFld(con_UserRoleRelationID);
}
}
/// <summary>
/// 用户名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string UserName
{
get
{
return mstrUserName;
}
set
{
if (value == "")
{
mintErrNo = 1;
 mstrUserName = value;
}
else
{
 mstrUserName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_UserName);
}
}
/// <summary>
/// 用户主键(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string id_User
{
get
{
return mstrid_User;
}
set
{
if (value == "")
{
mintErrNo = 1;
 mstrid_User = value;
}
else
{
 mstrid_User = value;
}
//记录修改过的字段
 AddUpdatedFld(con_id_User);
}
}
/// <summary>
/// 用户状态Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string UserStateId
{
get
{
return mstrUserStateId;
}
set
{
if (value == "")
{
mintErrNo = 1;
 mstrUserStateId = value;
}
else
{
 mstrUserStateId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_UserStateId);
}
}
/// <summary>
/// 用户角色ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string UserRoleId
{
get
{
return mstrUserRoleId;
}
set
{
if (value == "")
{
mintErrNo = 1;
 mstrUserRoleId = value;
}
else
{
 mstrUserRoleId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_UserRoleId);
}
}
/// <summary>
/// 单位Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string DepartmentId
{
get
{
return mstrDepartmentId;
}
set
{
if (value == "")
{
mintErrNo = 1;
 mstrDepartmentId = value;
}
else
{
 mstrDepartmentId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_DepartmentId);
}
}
/// <summary>
/// 用户账号(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string UserId
{
get
{
return mstrUserId;
}
set
{
if (value == "")
{
mintErrNo = 1;
 mstrUserId = value;
}
else
{
 mstrUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_UserId);
}
}
/// <summary>
/// 口令(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string Password
{
get
{
return mstrPassword;
}
set
{
if (value == "")
{
mintErrNo = 1;
 mstrPassword = value;
}
else
{
 mstrPassword = value;
}
//记录修改过的字段
 AddUpdatedFld(con_Password);
}
}
/// <summary>
/// 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string Memo
{
get
{
return mstrMemo;
}
set
{
if (value == "")
{
mintErrNo = 1;
 mstrMemo = value;
}
else
{
 mstrMemo = value;
}
//记录修改过的字段
 AddUpdatedFld(con_Memo);
}
}
/// <summary>
/// 区域ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string AreaId
{
get
{
return mstrAreaId;
}
set
{
if (value == "")
{
mintErrNo = 1;
 mstrAreaId = value;
}
else
{
 mstrAreaId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_AreaId);
}
}
/// <summary>
/// 性别流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string id_Sex
{
get
{
return mstrid_Sex;
}
set
{
if (value == "")
{
mintErrNo = 1;
 mstrid_Sex = value;
}
else
{
 mstrid_Sex = value;
}
//记录修改过的字段
 AddUpdatedFld(con_id_Sex);
}
}
/// <summary>
/// 电话(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string Telephone
{
get
{
return mstrTelephone;
}
set
{
if (value == "")
{
mintErrNo = 1;
 mstrTelephone = value;
}
else
{
 mstrTelephone = value;
}
//记录修改过的字段
 AddUpdatedFld(con_Telephone);
}
}
/// <summary>
/// 手机号(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string Phone
{
get
{
return mstrPhone;
}
set
{
if (value == "")
{
mintErrNo = 1;
 mstrPhone = value;
}
else
{
 mstrPhone = value;
}
//记录修改过的字段
 AddUpdatedFld(con_Phone);
}
}
/// <summary>
/// 传真(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string Fax
{
get
{
return mstrFax;
}
set
{
if (value == "")
{
mintErrNo = 1;
 mstrFax = value;
}
else
{
 mstrFax = value;
}
//记录修改过的字段
 AddUpdatedFld(con_Fax);
}
}
/// <summary>
/// 身份证(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string IdentityCard
{
get
{
return mstrIdentityCard;
}
set
{
if (value == "")
{
mintErrNo = 1;
 mstrIdentityCard = value;
}
else
{
 mstrIdentityCard = value;
}
//记录修改过的字段
 AddUpdatedFld(con_IdentityCard);
}
}
/// <summary>
/// 用户住址(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string UserAddress
{
get
{
return mstrUserAddress;
}
set
{
if (value == "")
{
mintErrNo = 1;
 mstrUserAddress = value;
}
else
{
 mstrUserAddress = value;
}
//记录修改过的字段
 AddUpdatedFld(con_UserAddress);
}
}
/// <summary>
/// 角色名称(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string UserRoleName
{
get
{
return mstrUserRoleName;
}
set
{
if (value == "")
{
mintErrNo = 1;
 mstrUserRoleName = value;
}
else
{
 mstrUserRoleName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_UserRoleName);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string UpdDate
{
get
{
return mstrUpdDate;
}
set
{
if (value == "")
{
mintErrNo = 1;
 mstrUpdDate = value;
}
else
{
 mstrUpdDate = value;
}
//记录修改过的字段
 AddUpdatedFld(con_UpdDate);
}
}
/// <summary>
/// 修改用户(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string UpdUser
{
get
{
return mstrUpdUser;
}
set
{
if (value == "")
{
mintErrNo = 1;
 mstrUpdUser = value;
}
else
{
 mstrUpdUser = value;
}
//记录修改过的字段
 AddUpdatedFld(con_UpdUser);
}
}
/// <summary>
/// 整型Tag(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public int IntTag
{
get
{
return mintIntTag;
}
set
{
 mintIntTag = value;
//记录修改过的字段
 AddUpdatedFld(con_IntTag);
}
}
/// <summary>
/// 字符型标签(说明:;字段类型:string;字段长度:1000;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string StrTag
{
get
{
return mstrStrTag;
}
set
{
if (value == "")
{
mintErrNo = 1;
 mstrStrTag = value;
}
else
{
 mstrStrTag = value;
}
//记录修改过的字段
 AddUpdatedFld(con_StrTag);
}
}
/// <summary>
/// 是否检查属性(说明:;字段类型:bool;字段长度:1;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public bool IsCheckProperty
{
get
{
return mbolIsCheckProperty;
}
set
{
 mbolIsCheckProperty = value;
//记录修改过的字段
 AddUpdatedFld(con_IsCheckProperty);
}
}
}
}