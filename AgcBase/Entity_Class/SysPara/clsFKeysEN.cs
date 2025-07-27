
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFKeysEN
 表名:FKeys(00050237)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:14:18
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统参数(SysPara)
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
 /// 表FKeys的关键字(Id)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_Id_FKeys
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngId">表关键字</param>
public K_Id_FKeys(long lngId)
{
if (IsValid(lngId)) Value = lngId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngId)
{
if (lngId == 0) return false;
if (lngId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_Id_FKeys]类型的对象</returns>
public static implicit operator K_Id_FKeys(long value)
{
return new K_Id_FKeys(value);
}
}
 /// <summary>
 /// 表外键(FKeys)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsFKeysEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接，如果为空就使用系统默认的连接
public new const string _CurrTabName = "FKeys"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "Id"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string WhereFormat = ""; //条件格式串
protected const int mintAttributeCount = 12;
public static string[] AttributeName = new string[] {"Id", "FKeyName", "FKeyColumnID", "FKeyColumnName", "FKeyTabID", "FKeyTabName", "PKeyColumnID", "PKeyColumnName", "PKeyTabId", "PKeyTabName", "Update_Action", "Delete_Action"};

protected long mlngId;    //对象Id
protected string mstrFKeyName;    //外键名称
protected string mstrFKeyColumnID;    //外键列Id
protected string mstrFKeyColumnName;    //外键列名
protected string mstrFKeyTabID;    //外键表ID
protected string mstrFKeyTabName;    //外键表名称
protected string mstrPKeyColumnID;    //主键列ID
protected string mstrPKeyColumnName;    //主键列名
protected string mstrPKeyTabId;    //主键表Id
protected string mstrPKeyTabName;    //主键表名
protected string mstrUpdate_Action;    //级联更新
protected int mintDelete_Action;    //级联删除

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsFKeysEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "FKeys";
 lstKeyFldNames.Add("Id");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngId">关键字:对象Id</param>
public clsFKeysEN(long lngId)
 {
 if (lngId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngId = lngId;
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "FKeys";
 lstKeyFldNames.Add("Id");
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
if (strAttributeName  ==  conFKeys.Id)
{
return mlngId;
}
else if (strAttributeName  ==  conFKeys.FKeyName)
{
return mstrFKeyName;
}
else if (strAttributeName  ==  conFKeys.FKeyColumnID)
{
return mstrFKeyColumnID;
}
else if (strAttributeName  ==  conFKeys.FKeyColumnName)
{
return mstrFKeyColumnName;
}
else if (strAttributeName  ==  conFKeys.FKeyTabID)
{
return mstrFKeyTabID;
}
else if (strAttributeName  ==  conFKeys.FKeyTabName)
{
return mstrFKeyTabName;
}
else if (strAttributeName  ==  conFKeys.PKeyColumnID)
{
return mstrPKeyColumnID;
}
else if (strAttributeName  ==  conFKeys.PKeyColumnName)
{
return mstrPKeyColumnName;
}
else if (strAttributeName  ==  conFKeys.PKeyTabId)
{
return mstrPKeyTabId;
}
else if (strAttributeName  ==  conFKeys.PKeyTabName)
{
return mstrPKeyTabName;
}
else if (strAttributeName  ==  conFKeys.Update_Action)
{
return mstrUpdate_Action;
}
else if (strAttributeName  ==  conFKeys.Delete_Action)
{
return mintDelete_Action;
}
return null;
}
set
{
if (strAttributeName  ==  conFKeys.Id)
{
mlngId = TransNullToInt(value.ToString());
 AddUpdatedFld(conFKeys.Id);
}
else if (strAttributeName  ==  conFKeys.FKeyName)
{
mstrFKeyName = value.ToString();
 AddUpdatedFld(conFKeys.FKeyName);
}
else if (strAttributeName  ==  conFKeys.FKeyColumnID)
{
mstrFKeyColumnID = value.ToString();
 AddUpdatedFld(conFKeys.FKeyColumnID);
}
else if (strAttributeName  ==  conFKeys.FKeyColumnName)
{
mstrFKeyColumnName = value.ToString();
 AddUpdatedFld(conFKeys.FKeyColumnName);
}
else if (strAttributeName  ==  conFKeys.FKeyTabID)
{
mstrFKeyTabID = value.ToString();
 AddUpdatedFld(conFKeys.FKeyTabID);
}
else if (strAttributeName  ==  conFKeys.FKeyTabName)
{
mstrFKeyTabName = value.ToString();
 AddUpdatedFld(conFKeys.FKeyTabName);
}
else if (strAttributeName  ==  conFKeys.PKeyColumnID)
{
mstrPKeyColumnID = value.ToString();
 AddUpdatedFld(conFKeys.PKeyColumnID);
}
else if (strAttributeName  ==  conFKeys.PKeyColumnName)
{
mstrPKeyColumnName = value.ToString();
 AddUpdatedFld(conFKeys.PKeyColumnName);
}
else if (strAttributeName  ==  conFKeys.PKeyTabId)
{
mstrPKeyTabId = value.ToString();
 AddUpdatedFld(conFKeys.PKeyTabId);
}
else if (strAttributeName  ==  conFKeys.PKeyTabName)
{
mstrPKeyTabName = value.ToString();
 AddUpdatedFld(conFKeys.PKeyTabName);
}
else if (strAttributeName  ==  conFKeys.Update_Action)
{
mstrUpdate_Action = value.ToString();
 AddUpdatedFld(conFKeys.Update_Action);
}
else if (strAttributeName  ==  conFKeys.Delete_Action)
{
mintDelete_Action = TransNullToInt(value.ToString());
 AddUpdatedFld(conFKeys.Delete_Action);
}
}
}
public object this[int intIndex]
{
get
{
if (conFKeys.Id  ==  AttributeName[intIndex])
{
return mlngId;
}
else if (conFKeys.FKeyName  ==  AttributeName[intIndex])
{
return mstrFKeyName;
}
else if (conFKeys.FKeyColumnID  ==  AttributeName[intIndex])
{
return mstrFKeyColumnID;
}
else if (conFKeys.FKeyColumnName  ==  AttributeName[intIndex])
{
return mstrFKeyColumnName;
}
else if (conFKeys.FKeyTabID  ==  AttributeName[intIndex])
{
return mstrFKeyTabID;
}
else if (conFKeys.FKeyTabName  ==  AttributeName[intIndex])
{
return mstrFKeyTabName;
}
else if (conFKeys.PKeyColumnID  ==  AttributeName[intIndex])
{
return mstrPKeyColumnID;
}
else if (conFKeys.PKeyColumnName  ==  AttributeName[intIndex])
{
return mstrPKeyColumnName;
}
else if (conFKeys.PKeyTabId  ==  AttributeName[intIndex])
{
return mstrPKeyTabId;
}
else if (conFKeys.PKeyTabName  ==  AttributeName[intIndex])
{
return mstrPKeyTabName;
}
else if (conFKeys.Update_Action  ==  AttributeName[intIndex])
{
return mstrUpdate_Action;
}
else if (conFKeys.Delete_Action  ==  AttributeName[intIndex])
{
return mintDelete_Action;
}
return null;
}
set
{
if (conFKeys.Id  ==  AttributeName[intIndex])
{
mlngId = TransNullToInt(value.ToString());
 AddUpdatedFld(conFKeys.Id);
}
else if (conFKeys.FKeyName  ==  AttributeName[intIndex])
{
mstrFKeyName = value.ToString();
 AddUpdatedFld(conFKeys.FKeyName);
}
else if (conFKeys.FKeyColumnID  ==  AttributeName[intIndex])
{
mstrFKeyColumnID = value.ToString();
 AddUpdatedFld(conFKeys.FKeyColumnID);
}
else if (conFKeys.FKeyColumnName  ==  AttributeName[intIndex])
{
mstrFKeyColumnName = value.ToString();
 AddUpdatedFld(conFKeys.FKeyColumnName);
}
else if (conFKeys.FKeyTabID  ==  AttributeName[intIndex])
{
mstrFKeyTabID = value.ToString();
 AddUpdatedFld(conFKeys.FKeyTabID);
}
else if (conFKeys.FKeyTabName  ==  AttributeName[intIndex])
{
mstrFKeyTabName = value.ToString();
 AddUpdatedFld(conFKeys.FKeyTabName);
}
else if (conFKeys.PKeyColumnID  ==  AttributeName[intIndex])
{
mstrPKeyColumnID = value.ToString();
 AddUpdatedFld(conFKeys.PKeyColumnID);
}
else if (conFKeys.PKeyColumnName  ==  AttributeName[intIndex])
{
mstrPKeyColumnName = value.ToString();
 AddUpdatedFld(conFKeys.PKeyColumnName);
}
else if (conFKeys.PKeyTabId  ==  AttributeName[intIndex])
{
mstrPKeyTabId = value.ToString();
 AddUpdatedFld(conFKeys.PKeyTabId);
}
else if (conFKeys.PKeyTabName  ==  AttributeName[intIndex])
{
mstrPKeyTabName = value.ToString();
 AddUpdatedFld(conFKeys.PKeyTabName);
}
else if (conFKeys.Update_Action  ==  AttributeName[intIndex])
{
mstrUpdate_Action = value.ToString();
 AddUpdatedFld(conFKeys.Update_Action);
}
else if (conFKeys.Delete_Action  ==  AttributeName[intIndex])
{
mintDelete_Action = TransNullToInt(value.ToString());
 AddUpdatedFld(conFKeys.Delete_Action);
}
}
}

/// <summary>
/// 对象Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long Id
{
get
{
return mlngId;
}
set
{
 mlngId = value;
//记录修改过的字段
 AddUpdatedFld(conFKeys.Id);
}
}
/// <summary>
/// 外键名称(说明:;字段类型:varchar;字段长度:128;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FKeyName
{
get
{
return mstrFKeyName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFKeyName = value;
}
else
{
 mstrFKeyName = value;
}
//记录修改过的字段
 AddUpdatedFld(conFKeys.FKeyName);
}
}
/// <summary>
/// 外键列Id(说明:;字段类型:varchar;字段长度:128;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FKeyColumnID
{
get
{
return mstrFKeyColumnID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFKeyColumnID = value;
}
else
{
 mstrFKeyColumnID = value;
}
//记录修改过的字段
 AddUpdatedFld(conFKeys.FKeyColumnID);
}
}
/// <summary>
/// 外键列名(说明:;字段类型:varchar;字段长度:128;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FKeyColumnName
{
get
{
return mstrFKeyColumnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFKeyColumnName = value;
}
else
{
 mstrFKeyColumnName = value;
}
//记录修改过的字段
 AddUpdatedFld(conFKeys.FKeyColumnName);
}
}
/// <summary>
/// 外键表ID(说明:;字段类型:varchar;字段长度:128;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FKeyTabID
{
get
{
return mstrFKeyTabID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFKeyTabID = value;
}
else
{
 mstrFKeyTabID = value;
}
//记录修改过的字段
 AddUpdatedFld(conFKeys.FKeyTabID);
}
}
/// <summary>
/// 外键表名称(说明:;字段类型:varchar;字段长度:128;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FKeyTabName
{
get
{
return mstrFKeyTabName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFKeyTabName = value;
}
else
{
 mstrFKeyTabName = value;
}
//记录修改过的字段
 AddUpdatedFld(conFKeys.FKeyTabName);
}
}
/// <summary>
/// 主键列ID(说明:;字段类型:varchar;字段长度:128;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PKeyColumnID
{
get
{
return mstrPKeyColumnID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPKeyColumnID = value;
}
else
{
 mstrPKeyColumnID = value;
}
//记录修改过的字段
 AddUpdatedFld(conFKeys.PKeyColumnID);
}
}
/// <summary>
/// 主键列名(说明:;字段类型:varchar;字段长度:128;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PKeyColumnName
{
get
{
return mstrPKeyColumnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPKeyColumnName = value;
}
else
{
 mstrPKeyColumnName = value;
}
//记录修改过的字段
 AddUpdatedFld(conFKeys.PKeyColumnName);
}
}
/// <summary>
/// 主键表Id(说明:;字段类型:varchar;字段长度:128;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PKeyTabId
{
get
{
return mstrPKeyTabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPKeyTabId = value;
}
else
{
 mstrPKeyTabId = value;
}
//记录修改过的字段
 AddUpdatedFld(conFKeys.PKeyTabId);
}
}
/// <summary>
/// 主键表名(说明:;字段类型:varchar;字段长度:128;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PKeyTabName
{
get
{
return mstrPKeyTabName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPKeyTabName = value;
}
else
{
 mstrPKeyTabName = value;
}
//记录修改过的字段
 AddUpdatedFld(conFKeys.PKeyTabName);
}
}
/// <summary>
/// 级联更新(说明:;字段类型:varchar;字段长度:128;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Update_Action
{
get
{
return mstrUpdate_Action;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdate_Action = value;
}
else
{
 mstrUpdate_Action = value;
}
//记录修改过的字段
 AddUpdatedFld(conFKeys.Update_Action);
}
}
/// <summary>
/// 级联删除(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int Delete_Action
{
get
{
return mintDelete_Action;
}
set
{
 mintDelete_Action = value;
//记录修改过的字段
 AddUpdatedFld(conFKeys.Delete_Action);
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
  return mlngId.ToString();
 }
 }
}
 /// <summary>
 /// 表外键(FKeys)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conFKeys
{
public new const string _CurrTabName = "FKeys"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "Id"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"Id", "FKeyName", "FKeyColumnID", "FKeyColumnName", "FKeyTabID", "FKeyTabName", "PKeyColumnID", "PKeyColumnName", "PKeyTabId", "PKeyTabName", "Update_Action", "Delete_Action"};
//以下是属性变量


 /// <summary>
 /// 常量:"Id"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Id = "Id";    //对象Id

 /// <summary>
 /// 常量:"FKeyName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FKeyName = "FKeyName";    //外键名称

 /// <summary>
 /// 常量:"FKeyColumnID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FKeyColumnID = "FKeyColumnID";    //外键列Id

 /// <summary>
 /// 常量:"FKeyColumnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FKeyColumnName = "FKeyColumnName";    //外键列名

 /// <summary>
 /// 常量:"FKeyTabID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FKeyTabID = "FKeyTabID";    //外键表ID

 /// <summary>
 /// 常量:"FKeyTabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FKeyTabName = "FKeyTabName";    //外键表名称

 /// <summary>
 /// 常量:"PKeyColumnID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PKeyColumnID = "PKeyColumnID";    //主键列ID

 /// <summary>
 /// 常量:"PKeyColumnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PKeyColumnName = "PKeyColumnName";    //主键列名

 /// <summary>
 /// 常量:"PKeyTabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PKeyTabId = "PKeyTabId";    //主键表Id

 /// <summary>
 /// 常量:"PKeyTabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PKeyTabName = "PKeyTabName";    //主键表名

 /// <summary>
 /// 常量:"Update_Action"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Update_Action = "Update_Action";    //级联更新

 /// <summary>
 /// 常量:"Delete_Action"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Delete_Action = "Delete_Action";    //级联删除
}

}