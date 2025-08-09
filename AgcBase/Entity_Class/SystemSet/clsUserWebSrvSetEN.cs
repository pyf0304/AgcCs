
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUserWebSrvSetEN
 表名:UserWebSrvSet(00050528)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:07:52
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
 /// 表UserWebSrvSet的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_UserWebSrvSet
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
public K_mId_UserWebSrvSet(long lngmId)
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
 /// <returns>返回:[K_mId_UserWebSrvSet]类型的对象</returns>
public static implicit operator K_mId_UserWebSrvSet(long value)
{
return new K_mId_UserWebSrvSet(value);
}
}
 /// <summary>
 /// 用户WebSrv设置(UserWebSrvSet)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsUserWebSrvSetEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "UserWebSrvSet"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 9;
public static string[] _AttributeName = new string[] {"mId", "UserId", "MachineName", "WebApiIPAndPort", "WebApiVirtualPath", "IsTemplate", "UpdDate", "UpdUserId", "Memo"};

protected long mlngmId;    //mId
protected string mstrUserId;    //用户Id
protected string mstrMachineName;    //机器名
protected string mstrWebApiIPAndPort;    //WebApiIPAndPort
protected string mstrWebApiVirtualPath;    //WebApi虚拟路径
protected bool mbolIsTemplate;    //是否模板
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsUserWebSrvSetEN()
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
public clsUserWebSrvSetEN(long lngmId)
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
if (strAttributeName  ==  conUserWebSrvSet.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conUserWebSrvSet.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conUserWebSrvSet.MachineName)
{
return mstrMachineName;
}
else if (strAttributeName  ==  conUserWebSrvSet.WebApiIPAndPort)
{
return mstrWebApiIPAndPort;
}
else if (strAttributeName  ==  conUserWebSrvSet.WebApiVirtualPath)
{
return mstrWebApiVirtualPath;
}
else if (strAttributeName  ==  conUserWebSrvSet.IsTemplate)
{
return mbolIsTemplate;
}
else if (strAttributeName  ==  conUserWebSrvSet.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conUserWebSrvSet.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conUserWebSrvSet.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conUserWebSrvSet.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUserWebSrvSet.mId);
}
else if (strAttributeName  ==  conUserWebSrvSet.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conUserWebSrvSet.UserId);
}
else if (strAttributeName  ==  conUserWebSrvSet.MachineName)
{
mstrMachineName = value.ToString();
 AddUpdatedFld(conUserWebSrvSet.MachineName);
}
else if (strAttributeName  ==  conUserWebSrvSet.WebApiIPAndPort)
{
mstrWebApiIPAndPort = value.ToString();
 AddUpdatedFld(conUserWebSrvSet.WebApiIPAndPort);
}
else if (strAttributeName  ==  conUserWebSrvSet.WebApiVirtualPath)
{
mstrWebApiVirtualPath = value.ToString();
 AddUpdatedFld(conUserWebSrvSet.WebApiVirtualPath);
}
else if (strAttributeName  ==  conUserWebSrvSet.IsTemplate)
{
mbolIsTemplate = TransNullToBool(value.ToString());
 AddUpdatedFld(conUserWebSrvSet.IsTemplate);
}
else if (strAttributeName  ==  conUserWebSrvSet.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conUserWebSrvSet.UpdDate);
}
else if (strAttributeName  ==  conUserWebSrvSet.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conUserWebSrvSet.UpdUserId);
}
else if (strAttributeName  ==  conUserWebSrvSet.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conUserWebSrvSet.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conUserWebSrvSet.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (conUserWebSrvSet.UserId  ==  _AttributeName[intIndex])
{
return mstrUserId;
}
else if (conUserWebSrvSet.MachineName  ==  _AttributeName[intIndex])
{
return mstrMachineName;
}
else if (conUserWebSrvSet.WebApiIPAndPort  ==  _AttributeName[intIndex])
{
return mstrWebApiIPAndPort;
}
else if (conUserWebSrvSet.WebApiVirtualPath  ==  _AttributeName[intIndex])
{
return mstrWebApiVirtualPath;
}
else if (conUserWebSrvSet.IsTemplate  ==  _AttributeName[intIndex])
{
return mbolIsTemplate;
}
else if (conUserWebSrvSet.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conUserWebSrvSet.UpdUserId  ==  _AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conUserWebSrvSet.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conUserWebSrvSet.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUserWebSrvSet.mId);
}
else if (conUserWebSrvSet.UserId  ==  _AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conUserWebSrvSet.UserId);
}
else if (conUserWebSrvSet.MachineName  ==  _AttributeName[intIndex])
{
mstrMachineName = value.ToString();
 AddUpdatedFld(conUserWebSrvSet.MachineName);
}
else if (conUserWebSrvSet.WebApiIPAndPort  ==  _AttributeName[intIndex])
{
mstrWebApiIPAndPort = value.ToString();
 AddUpdatedFld(conUserWebSrvSet.WebApiIPAndPort);
}
else if (conUserWebSrvSet.WebApiVirtualPath  ==  _AttributeName[intIndex])
{
mstrWebApiVirtualPath = value.ToString();
 AddUpdatedFld(conUserWebSrvSet.WebApiVirtualPath);
}
else if (conUserWebSrvSet.IsTemplate  ==  _AttributeName[intIndex])
{
mbolIsTemplate = TransNullToBool(value.ToString());
 AddUpdatedFld(conUserWebSrvSet.IsTemplate);
}
else if (conUserWebSrvSet.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conUserWebSrvSet.UpdDate);
}
else if (conUserWebSrvSet.UpdUserId  ==  _AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conUserWebSrvSet.UpdUserId);
}
else if (conUserWebSrvSet.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conUserWebSrvSet.Memo);
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
 AddUpdatedFld(conUserWebSrvSet.mId);
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
 AddUpdatedFld(conUserWebSrvSet.UserId);
}
}
/// <summary>
/// 机器名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MachineName
{
get
{
return mstrMachineName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMachineName = value;
}
else
{
 mstrMachineName = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserWebSrvSet.MachineName);
}
}
/// <summary>
/// WebApiIPAndPort(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WebApiIPAndPort
{
get
{
return mstrWebApiIPAndPort;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWebApiIPAndPort = value;
}
else
{
 mstrWebApiIPAndPort = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserWebSrvSet.WebApiIPAndPort);
}
}
/// <summary>
/// WebApi虚拟路径(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WebApiVirtualPath
{
get
{
return mstrWebApiVirtualPath;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWebApiVirtualPath = value;
}
else
{
 mstrWebApiVirtualPath = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserWebSrvSet.WebApiVirtualPath);
}
}
/// <summary>
/// 是否模板(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsTemplate
{
get
{
return mbolIsTemplate;
}
set
{
 mbolIsTemplate = value;
//记录修改过的字段
 AddUpdatedFld(conUserWebSrvSet.IsTemplate);
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
 AddUpdatedFld(conUserWebSrvSet.UpdDate);
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
 AddUpdatedFld(conUserWebSrvSet.UpdUserId);
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
 AddUpdatedFld(conUserWebSrvSet.Memo);
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
 /// 用户WebSrv设置(UserWebSrvSet)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conUserWebSrvSet
{
public const string _CurrTabName = "UserWebSrvSet"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "UserId", "MachineName", "WebApiIPAndPort", "WebApiVirtualPath", "IsTemplate", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户Id

 /// <summary>
 /// 常量:"MachineName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MachineName = "MachineName";    //机器名

 /// <summary>
 /// 常量:"WebApiIPAndPort"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WebApiIPAndPort = "WebApiIPAndPort";    //WebApiIPAndPort

 /// <summary>
 /// 常量:"WebApiVirtualPath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WebApiVirtualPath = "WebApiVirtualPath";    //WebApi虚拟路径

 /// <summary>
 /// 常量:"IsTemplate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsTemplate = "IsTemplate";    //是否模板

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