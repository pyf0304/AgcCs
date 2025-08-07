
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsGCContainerTypeEN
 表名:GCContainerType(00050563)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:31:50
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
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
 /// 表GCContainerType的关键字(ContainerTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ContainerTypeId_GCContainerType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strContainerTypeId">表关键字</param>
public K_ContainerTypeId_GCContainerType(string strContainerTypeId)
{
if (IsValid(strContainerTypeId)) Value = strContainerTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strContainerTypeId)
{
if (string.IsNullOrEmpty(strContainerTypeId) == true) return false;
if (strContainerTypeId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ContainerTypeId_GCContainerType]类型的对象</returns>
public static implicit operator K_ContainerTypeId_GCContainerType(string value)
{
return new K_ContainerTypeId_GCContainerType(value);
}
}
 /// <summary>
 /// GC容器类型(GCContainerType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsGCContainerTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "GCContainerType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ContainerTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 6;
public static string[] _AttributeName = new string[] {"ContainerTypeId", "ContainerTypeName", "ContainerTypeENName", "UpdDate", "UpdUser", "Memo"};

protected string mstrContainerTypeId;    //容器类型Id
protected string mstrContainerTypeName;    //容器类型名
protected string mstrContainerTypeENName;    //容器类型英文名
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsGCContainerTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ContainerTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strContainerTypeId">关键字:容器类型Id</param>
public clsGCContainerTypeEN(string strContainerTypeId)
 {
strContainerTypeId = strContainerTypeId.Replace("'", "''");
if (strContainerTypeId.Length > 4)
{
throw new Exception("在表:GCContainerType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strContainerTypeId)  ==  true)
{
throw new Exception("在表:GCContainerType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strContainerTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrContainerTypeId = strContainerTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ContainerTypeId");
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
if (strAttributeName  ==  conGCContainerType.ContainerTypeId)
{
return mstrContainerTypeId;
}
else if (strAttributeName  ==  conGCContainerType.ContainerTypeName)
{
return mstrContainerTypeName;
}
else if (strAttributeName  ==  conGCContainerType.ContainerTypeENName)
{
return mstrContainerTypeENName;
}
else if (strAttributeName  ==  conGCContainerType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conGCContainerType.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conGCContainerType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conGCContainerType.ContainerTypeId)
{
mstrContainerTypeId = value.ToString();
 AddUpdatedFld(conGCContainerType.ContainerTypeId);
}
else if (strAttributeName  ==  conGCContainerType.ContainerTypeName)
{
mstrContainerTypeName = value.ToString();
 AddUpdatedFld(conGCContainerType.ContainerTypeName);
}
else if (strAttributeName  ==  conGCContainerType.ContainerTypeENName)
{
mstrContainerTypeENName = value.ToString();
 AddUpdatedFld(conGCContainerType.ContainerTypeENName);
}
else if (strAttributeName  ==  conGCContainerType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conGCContainerType.UpdDate);
}
else if (strAttributeName  ==  conGCContainerType.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conGCContainerType.UpdUser);
}
else if (strAttributeName  ==  conGCContainerType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conGCContainerType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conGCContainerType.ContainerTypeId  ==  _AttributeName[intIndex])
{
return mstrContainerTypeId;
}
else if (conGCContainerType.ContainerTypeName  ==  _AttributeName[intIndex])
{
return mstrContainerTypeName;
}
else if (conGCContainerType.ContainerTypeENName  ==  _AttributeName[intIndex])
{
return mstrContainerTypeENName;
}
else if (conGCContainerType.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conGCContainerType.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conGCContainerType.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conGCContainerType.ContainerTypeId  ==  _AttributeName[intIndex])
{
mstrContainerTypeId = value.ToString();
 AddUpdatedFld(conGCContainerType.ContainerTypeId);
}
else if (conGCContainerType.ContainerTypeName  ==  _AttributeName[intIndex])
{
mstrContainerTypeName = value.ToString();
 AddUpdatedFld(conGCContainerType.ContainerTypeName);
}
else if (conGCContainerType.ContainerTypeENName  ==  _AttributeName[intIndex])
{
mstrContainerTypeENName = value.ToString();
 AddUpdatedFld(conGCContainerType.ContainerTypeENName);
}
else if (conGCContainerType.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conGCContainerType.UpdDate);
}
else if (conGCContainerType.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conGCContainerType.UpdUser);
}
else if (conGCContainerType.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conGCContainerType.Memo);
}
}
}

/// <summary>
/// 容器类型Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ContainerTypeId
{
get
{
return mstrContainerTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrContainerTypeId = value;
}
else
{
 mstrContainerTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conGCContainerType.ContainerTypeId);
}
}
/// <summary>
/// 容器类型名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ContainerTypeName
{
get
{
return mstrContainerTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrContainerTypeName = value;
}
else
{
 mstrContainerTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conGCContainerType.ContainerTypeName);
}
}
/// <summary>
/// 容器类型英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ContainerTypeENName
{
get
{
return mstrContainerTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrContainerTypeENName = value;
}
else
{
 mstrContainerTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conGCContainerType.ContainerTypeENName);
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
 AddUpdatedFld(conGCContainerType.UpdDate);
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
 AddUpdatedFld(conGCContainerType.UpdUser);
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
 AddUpdatedFld(conGCContainerType.Memo);
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
  return mstrContainerTypeId;
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
  return mstrContainerTypeName;
 }
 }
}
 /// <summary>
 /// GC容器类型(GCContainerType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conGCContainerType
{
public const string _CurrTabName = "GCContainerType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ContainerTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"ContainerTypeId", "ContainerTypeName", "ContainerTypeENName", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"ContainerTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ContainerTypeId = "ContainerTypeId";    //容器类型Id

 /// <summary>
 /// 常量:"ContainerTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ContainerTypeName = "ContainerTypeName";    //容器类型名

 /// <summary>
 /// 常量:"ContainerTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ContainerTypeENName = "ContainerTypeENName";    //容器类型英文名

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