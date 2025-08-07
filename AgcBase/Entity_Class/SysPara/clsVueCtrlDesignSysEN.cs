
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsVueCtrlDesignSysEN
 表名:VueCtrlDesignSys(00050633)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:32:30
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
 /// 表VueCtrlDesignSys的关键字(VueDesignSysId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_VueDesignSysId_VueCtrlDesignSys
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strVueDesignSysId">表关键字</param>
public K_VueDesignSysId_VueCtrlDesignSys(string strVueDesignSysId)
{
if (IsValid(strVueDesignSysId)) Value = strVueDesignSysId;
else
{
Value = null;
}
}
private static bool IsValid(string strVueDesignSysId)
{
if (string.IsNullOrEmpty(strVueDesignSysId) == true) return false;
if (strVueDesignSysId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_VueDesignSysId_VueCtrlDesignSys]类型的对象</returns>
public static implicit operator K_VueDesignSysId_VueCtrlDesignSys(string value)
{
return new K_VueDesignSysId_VueCtrlDesignSys(value);
}
}
 /// <summary>
 /// Vue控件设计体系(VueCtrlDesignSys)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsVueCtrlDesignSysEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "VueCtrlDesignSys"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "VueDesignSysId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 6;
public static string[] _AttributeName = new string[] {"VueDesignSysId", "VueDesignSysName", "VueDesignSysEnName", "UpdDate", "UpdUser", "Memo"};

protected string mstrVueDesignSysId;    //Vue控件设计体系Id
protected string mstrVueDesignSysName;    //Vue控件设计体系名称
protected string mstrVueDesignSysEnName;    //Vue控件设计体系英文名
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsVueCtrlDesignSysEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("VueDesignSysId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strVueDesignSysId">关键字:Vue控件设计体系Id</param>
public clsVueCtrlDesignSysEN(string strVueDesignSysId)
 {
strVueDesignSysId = strVueDesignSysId.Replace("'", "''");
if (strVueDesignSysId.Length > 2)
{
throw new Exception("在表:VueCtrlDesignSys中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strVueDesignSysId)  ==  true)
{
throw new Exception("在表:VueCtrlDesignSys中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strVueDesignSysId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrVueDesignSysId = strVueDesignSysId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("VueDesignSysId");
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
if (strAttributeName  ==  conVueCtrlDesignSys.VueDesignSysId)
{
return mstrVueDesignSysId;
}
else if (strAttributeName  ==  conVueCtrlDesignSys.VueDesignSysName)
{
return mstrVueDesignSysName;
}
else if (strAttributeName  ==  conVueCtrlDesignSys.VueDesignSysEnName)
{
return mstrVueDesignSysEnName;
}
else if (strAttributeName  ==  conVueCtrlDesignSys.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conVueCtrlDesignSys.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conVueCtrlDesignSys.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conVueCtrlDesignSys.VueDesignSysId)
{
mstrVueDesignSysId = value.ToString();
 AddUpdatedFld(conVueCtrlDesignSys.VueDesignSysId);
}
else if (strAttributeName  ==  conVueCtrlDesignSys.VueDesignSysName)
{
mstrVueDesignSysName = value.ToString();
 AddUpdatedFld(conVueCtrlDesignSys.VueDesignSysName);
}
else if (strAttributeName  ==  conVueCtrlDesignSys.VueDesignSysEnName)
{
mstrVueDesignSysEnName = value.ToString();
 AddUpdatedFld(conVueCtrlDesignSys.VueDesignSysEnName);
}
else if (strAttributeName  ==  conVueCtrlDesignSys.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conVueCtrlDesignSys.UpdDate);
}
else if (strAttributeName  ==  conVueCtrlDesignSys.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conVueCtrlDesignSys.UpdUser);
}
else if (strAttributeName  ==  conVueCtrlDesignSys.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conVueCtrlDesignSys.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conVueCtrlDesignSys.VueDesignSysId  ==  _AttributeName[intIndex])
{
return mstrVueDesignSysId;
}
else if (conVueCtrlDesignSys.VueDesignSysName  ==  _AttributeName[intIndex])
{
return mstrVueDesignSysName;
}
else if (conVueCtrlDesignSys.VueDesignSysEnName  ==  _AttributeName[intIndex])
{
return mstrVueDesignSysEnName;
}
else if (conVueCtrlDesignSys.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conVueCtrlDesignSys.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conVueCtrlDesignSys.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conVueCtrlDesignSys.VueDesignSysId  ==  _AttributeName[intIndex])
{
mstrVueDesignSysId = value.ToString();
 AddUpdatedFld(conVueCtrlDesignSys.VueDesignSysId);
}
else if (conVueCtrlDesignSys.VueDesignSysName  ==  _AttributeName[intIndex])
{
mstrVueDesignSysName = value.ToString();
 AddUpdatedFld(conVueCtrlDesignSys.VueDesignSysName);
}
else if (conVueCtrlDesignSys.VueDesignSysEnName  ==  _AttributeName[intIndex])
{
mstrVueDesignSysEnName = value.ToString();
 AddUpdatedFld(conVueCtrlDesignSys.VueDesignSysEnName);
}
else if (conVueCtrlDesignSys.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conVueCtrlDesignSys.UpdDate);
}
else if (conVueCtrlDesignSys.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conVueCtrlDesignSys.UpdUser);
}
else if (conVueCtrlDesignSys.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conVueCtrlDesignSys.Memo);
}
}
}

/// <summary>
/// Vue控件设计体系Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VueDesignSysId
{
get
{
return mstrVueDesignSysId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVueDesignSysId = value;
}
else
{
 mstrVueDesignSysId = value;
}
//记录修改过的字段
 AddUpdatedFld(conVueCtrlDesignSys.VueDesignSysId);
}
}
/// <summary>
/// Vue控件设计体系名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VueDesignSysName
{
get
{
return mstrVueDesignSysName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVueDesignSysName = value;
}
else
{
 mstrVueDesignSysName = value;
}
//记录修改过的字段
 AddUpdatedFld(conVueCtrlDesignSys.VueDesignSysName);
}
}
/// <summary>
/// Vue控件设计体系英文名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VueDesignSysEnName
{
get
{
return mstrVueDesignSysEnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVueDesignSysEnName = value;
}
else
{
 mstrVueDesignSysEnName = value;
}
//记录修改过的字段
 AddUpdatedFld(conVueCtrlDesignSys.VueDesignSysEnName);
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
 AddUpdatedFld(conVueCtrlDesignSys.UpdDate);
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
 AddUpdatedFld(conVueCtrlDesignSys.UpdUser);
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
 AddUpdatedFld(conVueCtrlDesignSys.Memo);
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
  return mstrVueDesignSysId;
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
  return mstrVueDesignSysName;
 }
 }
}
 /// <summary>
 /// Vue控件设计体系(VueCtrlDesignSys)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conVueCtrlDesignSys
{
public const string _CurrTabName = "VueCtrlDesignSys"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "VueDesignSysId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"VueDesignSysId", "VueDesignSysName", "VueDesignSysEnName", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"VueDesignSysId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VueDesignSysId = "VueDesignSysId";    //Vue控件设计体系Id

 /// <summary>
 /// 常量:"VueDesignSysName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VueDesignSysName = "VueDesignSysName";    //Vue控件设计体系名称

 /// <summary>
 /// 常量:"VueDesignSysEnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VueDesignSysEnName = "VueDesignSysEnName";    //Vue控件设计体系英文名

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