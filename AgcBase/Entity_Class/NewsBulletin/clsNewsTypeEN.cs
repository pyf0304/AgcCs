
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsNewsTypeEN
 表名:NewsType(00050479)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:15:26
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:新闻公告(NewsBulletin)
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
 /// 表NewsType的关键字(NewsTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_NewsTypeId_NewsType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strNewsTypeId">表关键字</param>
public K_NewsTypeId_NewsType(string strNewsTypeId)
{
if (IsValid(strNewsTypeId)) Value = strNewsTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strNewsTypeId)
{
if (string.IsNullOrEmpty(strNewsTypeId) == true) return false;
if (strNewsTypeId.Length != 1) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_NewsTypeId_NewsType]类型的对象</returns>
public static implicit operator K_NewsTypeId_NewsType(string value)
{
return new K_NewsTypeId_NewsType(value);
}
}
 /// <summary>
 /// 资讯类型(NewsType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsNewsTypeEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接，如果为空就使用系统默认的连接
public new const string _CurrTabName = "NewsType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "NewsTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string WhereFormat = ""; //条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"NewsTypeId", "NewsTypeName", "IsDeleted", "DeletedDate", "Memo"};

protected string mstrNewsTypeId;    //信息类型Id
protected string mstrNewsTypeName;    //信息类型名称
protected bool mbolIsDeleted;    //是否删除
protected string mstrDeletedDate;    //删除日期
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsNewsTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "NewsType";
 lstKeyFldNames.Add("NewsTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strNewsTypeId">关键字:信息类型Id</param>
public clsNewsTypeEN(string strNewsTypeId)
 {
strNewsTypeId = strNewsTypeId.Replace("'", "''");
if (strNewsTypeId.Length > 1)
{
throw new Exception("在表:NewsType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strNewsTypeId)  ==  true)
{
throw new Exception("在表:NewsType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strNewsTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrNewsTypeId = strNewsTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "NewsType";
 lstKeyFldNames.Add("NewsTypeId");
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
if (strAttributeName  ==  conNewsType.NewsTypeId)
{
return mstrNewsTypeId;
}
else if (strAttributeName  ==  conNewsType.NewsTypeName)
{
return mstrNewsTypeName;
}
else if (strAttributeName  ==  conNewsType.IsDeleted)
{
return mbolIsDeleted;
}
else if (strAttributeName  ==  conNewsType.DeletedDate)
{
return mstrDeletedDate;
}
else if (strAttributeName  ==  conNewsType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conNewsType.NewsTypeId)
{
mstrNewsTypeId = value.ToString();
 AddUpdatedFld(conNewsType.NewsTypeId);
}
else if (strAttributeName  ==  conNewsType.NewsTypeName)
{
mstrNewsTypeName = value.ToString();
 AddUpdatedFld(conNewsType.NewsTypeName);
}
else if (strAttributeName  ==  conNewsType.IsDeleted)
{
mbolIsDeleted = TransNullToBool(value.ToString());
 AddUpdatedFld(conNewsType.IsDeleted);
}
else if (strAttributeName  ==  conNewsType.DeletedDate)
{
mstrDeletedDate = value.ToString();
 AddUpdatedFld(conNewsType.DeletedDate);
}
else if (strAttributeName  ==  conNewsType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conNewsType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conNewsType.NewsTypeId  ==  AttributeName[intIndex])
{
return mstrNewsTypeId;
}
else if (conNewsType.NewsTypeName  ==  AttributeName[intIndex])
{
return mstrNewsTypeName;
}
else if (conNewsType.IsDeleted  ==  AttributeName[intIndex])
{
return mbolIsDeleted;
}
else if (conNewsType.DeletedDate  ==  AttributeName[intIndex])
{
return mstrDeletedDate;
}
else if (conNewsType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conNewsType.NewsTypeId  ==  AttributeName[intIndex])
{
mstrNewsTypeId = value.ToString();
 AddUpdatedFld(conNewsType.NewsTypeId);
}
else if (conNewsType.NewsTypeName  ==  AttributeName[intIndex])
{
mstrNewsTypeName = value.ToString();
 AddUpdatedFld(conNewsType.NewsTypeName);
}
else if (conNewsType.IsDeleted  ==  AttributeName[intIndex])
{
mbolIsDeleted = TransNullToBool(value.ToString());
 AddUpdatedFld(conNewsType.IsDeleted);
}
else if (conNewsType.DeletedDate  ==  AttributeName[intIndex])
{
mstrDeletedDate = value.ToString();
 AddUpdatedFld(conNewsType.DeletedDate);
}
else if (conNewsType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conNewsType.Memo);
}
}
}

/// <summary>
/// 信息类型Id(说明:;字段类型:char;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string NewsTypeId
{
get
{
return mstrNewsTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrNewsTypeId = value;
}
else
{
 mstrNewsTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conNewsType.NewsTypeId);
}
}
/// <summary>
/// 信息类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string NewsTypeName
{
get
{
return mstrNewsTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrNewsTypeName = value;
}
else
{
 mstrNewsTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conNewsType.NewsTypeName);
}
}
/// <summary>
/// 是否删除(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsDeleted
{
get
{
return mbolIsDeleted;
}
set
{
 mbolIsDeleted = value;
//记录修改过的字段
 AddUpdatedFld(conNewsType.IsDeleted);
}
}
/// <summary>
/// 删除日期(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DeletedDate
{
get
{
return mstrDeletedDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDeletedDate = value;
}
else
{
 mstrDeletedDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conNewsType.DeletedDate);
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
 AddUpdatedFld(conNewsType.Memo);
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
  return mstrNewsTypeId;
 }
 }

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrNewsTypeName;
 }
 }
}
 /// <summary>
 /// 资讯类型(NewsType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conNewsType
{
public new const string _CurrTabName = "NewsType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "NewsTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"NewsTypeId", "NewsTypeName", "IsDeleted", "DeletedDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"NewsTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string NewsTypeId = "NewsTypeId";    //信息类型Id

 /// <summary>
 /// 常量:"NewsTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string NewsTypeName = "NewsTypeName";    //信息类型名称

 /// <summary>
 /// 常量:"IsDeleted"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDeleted = "IsDeleted";    //是否删除

 /// <summary>
 /// 常量:"DeletedDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DeletedDate = "DeletedDate";    //删除日期

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}