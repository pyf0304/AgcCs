
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDataNodeTypeEN
 表名:DataNodeType(00050548)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:29:43
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:AI模块(AIModule)
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
 /// 表DataNodeType的关键字(DataNodeTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_DataNodeTypeId_DataNodeType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strDataNodeTypeId">表关键字</param>
public K_DataNodeTypeId_DataNodeType(string strDataNodeTypeId)
{
if (IsValid(strDataNodeTypeId)) Value = strDataNodeTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strDataNodeTypeId)
{
if (string.IsNullOrEmpty(strDataNodeTypeId) == true) return false;
if (strDataNodeTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_DataNodeTypeId_DataNodeType]类型的对象</returns>
public static implicit operator K_DataNodeTypeId_DataNodeType(string value)
{
return new K_DataNodeTypeId_DataNodeType(value);
}
}
 /// <summary>
 /// 数据结点类型(DataNodeType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsDataNodeTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "DataNodeType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "DataNodeTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 6;
public static string[] _AttributeName = new string[] {"DataNodeTypeId", "DataNodeTypeName", "DataNodeTypeENName", "UpdDate", "UpdUser", "Memo"};

protected string mstrDataNodeTypeId;    //数据结点类型Id
protected string mstrDataNodeTypeName;    //数据结点类型名
protected string mstrDataNodeTypeENName;    //数据结点类型英文名
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsDataNodeTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("DataNodeTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strDataNodeTypeId">关键字:数据结点类型Id</param>
public clsDataNodeTypeEN(string strDataNodeTypeId)
 {
strDataNodeTypeId = strDataNodeTypeId.Replace("'", "''");
if (strDataNodeTypeId.Length > 2)
{
throw new Exception("在表:DataNodeType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strDataNodeTypeId)  ==  true)
{
throw new Exception("在表:DataNodeType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strDataNodeTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrDataNodeTypeId = strDataNodeTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("DataNodeTypeId");
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
if (strAttributeName  ==  conDataNodeType.DataNodeTypeId)
{
return mstrDataNodeTypeId;
}
else if (strAttributeName  ==  conDataNodeType.DataNodeTypeName)
{
return mstrDataNodeTypeName;
}
else if (strAttributeName  ==  conDataNodeType.DataNodeTypeENName)
{
return mstrDataNodeTypeENName;
}
else if (strAttributeName  ==  conDataNodeType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conDataNodeType.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conDataNodeType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conDataNodeType.DataNodeTypeId)
{
mstrDataNodeTypeId = value.ToString();
 AddUpdatedFld(conDataNodeType.DataNodeTypeId);
}
else if (strAttributeName  ==  conDataNodeType.DataNodeTypeName)
{
mstrDataNodeTypeName = value.ToString();
 AddUpdatedFld(conDataNodeType.DataNodeTypeName);
}
else if (strAttributeName  ==  conDataNodeType.DataNodeTypeENName)
{
mstrDataNodeTypeENName = value.ToString();
 AddUpdatedFld(conDataNodeType.DataNodeTypeENName);
}
else if (strAttributeName  ==  conDataNodeType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conDataNodeType.UpdDate);
}
else if (strAttributeName  ==  conDataNodeType.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conDataNodeType.UpdUser);
}
else if (strAttributeName  ==  conDataNodeType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDataNodeType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conDataNodeType.DataNodeTypeId  ==  _AttributeName[intIndex])
{
return mstrDataNodeTypeId;
}
else if (conDataNodeType.DataNodeTypeName  ==  _AttributeName[intIndex])
{
return mstrDataNodeTypeName;
}
else if (conDataNodeType.DataNodeTypeENName  ==  _AttributeName[intIndex])
{
return mstrDataNodeTypeENName;
}
else if (conDataNodeType.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conDataNodeType.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conDataNodeType.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conDataNodeType.DataNodeTypeId  ==  _AttributeName[intIndex])
{
mstrDataNodeTypeId = value.ToString();
 AddUpdatedFld(conDataNodeType.DataNodeTypeId);
}
else if (conDataNodeType.DataNodeTypeName  ==  _AttributeName[intIndex])
{
mstrDataNodeTypeName = value.ToString();
 AddUpdatedFld(conDataNodeType.DataNodeTypeName);
}
else if (conDataNodeType.DataNodeTypeENName  ==  _AttributeName[intIndex])
{
mstrDataNodeTypeENName = value.ToString();
 AddUpdatedFld(conDataNodeType.DataNodeTypeENName);
}
else if (conDataNodeType.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conDataNodeType.UpdDate);
}
else if (conDataNodeType.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conDataNodeType.UpdUser);
}
else if (conDataNodeType.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDataNodeType.Memo);
}
}
}

/// <summary>
/// 数据结点类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataNodeTypeId
{
get
{
return mstrDataNodeTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataNodeTypeId = value;
}
else
{
 mstrDataNodeTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conDataNodeType.DataNodeTypeId);
}
}
/// <summary>
/// 数据结点类型名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataNodeTypeName
{
get
{
return mstrDataNodeTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataNodeTypeName = value;
}
else
{
 mstrDataNodeTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conDataNodeType.DataNodeTypeName);
}
}
/// <summary>
/// 数据结点类型英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataNodeTypeENName
{
get
{
return mstrDataNodeTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataNodeTypeENName = value;
}
else
{
 mstrDataNodeTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conDataNodeType.DataNodeTypeENName);
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
 AddUpdatedFld(conDataNodeType.UpdDate);
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
 AddUpdatedFld(conDataNodeType.UpdUser);
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
 AddUpdatedFld(conDataNodeType.Memo);
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
  return mstrDataNodeTypeId;
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
  return mstrDataNodeTypeName;
 }
 }
}
 /// <summary>
 /// 数据结点类型(DataNodeType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conDataNodeType
{
public const string _CurrTabName = "DataNodeType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "DataNodeTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"DataNodeTypeId", "DataNodeTypeName", "DataNodeTypeENName", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"DataNodeTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataNodeTypeId = "DataNodeTypeId";    //数据结点类型Id

 /// <summary>
 /// 常量:"DataNodeTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataNodeTypeName = "DataNodeTypeName";    //数据结点类型名

 /// <summary>
 /// 常量:"DataNodeTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataNodeTypeENName = "DataNodeTypeENName";    //数据结点类型英文名

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