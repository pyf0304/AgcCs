
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSqlStoreProcedureEN
 表名:SqlStoreProcedure(00050182)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:13:26
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:SQL表字段管理(SQLTabField)
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
 /// 表SqlStoreProcedure的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_SqlStoreProcedure
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
public K_mId_SqlStoreProcedure(long lngmId)
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
 /// <returns>返回:[K_mId_SqlStoreProcedure]类型的对象</returns>
public static implicit operator K_mId_SqlStoreProcedure(long value)
{
return new K_mId_SqlStoreProcedure(value);
}
}
 /// <summary>
 /// Sql存储过程(SqlStoreProcedure)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsSqlStoreProcedureEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "SqlStoreProcedure"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 5;
public static string[] _AttributeName = new string[] {"mId", "SpId", "SpName", "uid", "ConnectStringdb"};

protected long mlngmId;    //mId
protected long mlngSpId;    //SP_ID
protected string mstrSpName;    //存储过程名称
protected int mintuid;    //uid
protected string mstrConnectStringdb;    //ConnectString_db

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsSqlStoreProcedureEN()
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
public clsSqlStoreProcedureEN(long lngmId)
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
if (strAttributeName  ==  conSqlStoreProcedure.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conSqlStoreProcedure.SpId)
{
return mlngSpId;
}
else if (strAttributeName  ==  conSqlStoreProcedure.SpName)
{
return mstrSpName;
}
else if (strAttributeName  ==  conSqlStoreProcedure.uid)
{
return mintuid;
}
else if (strAttributeName  ==  conSqlStoreProcedure.ConnectStringdb)
{
return mstrConnectStringdb;
}
return null;
}
set
{
if (strAttributeName  ==  conSqlStoreProcedure.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conSqlStoreProcedure.mId);
}
else if (strAttributeName  ==  conSqlStoreProcedure.SpId)
{
mlngSpId = TransNullToInt(value.ToString());
 AddUpdatedFld(conSqlStoreProcedure.SpId);
}
else if (strAttributeName  ==  conSqlStoreProcedure.SpName)
{
mstrSpName = value.ToString();
 AddUpdatedFld(conSqlStoreProcedure.SpName);
}
else if (strAttributeName  ==  conSqlStoreProcedure.uid)
{
mintuid = TransNullToInt(value.ToString());
 AddUpdatedFld(conSqlStoreProcedure.uid);
}
else if (strAttributeName  ==  conSqlStoreProcedure.ConnectStringdb)
{
mstrConnectStringdb = value.ToString();
 AddUpdatedFld(conSqlStoreProcedure.ConnectStringdb);
}
}
}
public object this[int intIndex]
{
get
{
if (conSqlStoreProcedure.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (conSqlStoreProcedure.SpId  ==  _AttributeName[intIndex])
{
return mlngSpId;
}
else if (conSqlStoreProcedure.SpName  ==  _AttributeName[intIndex])
{
return mstrSpName;
}
else if (conSqlStoreProcedure.uid  ==  _AttributeName[intIndex])
{
return mintuid;
}
else if (conSqlStoreProcedure.ConnectStringdb  ==  _AttributeName[intIndex])
{
return mstrConnectStringdb;
}
return null;
}
set
{
if (conSqlStoreProcedure.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conSqlStoreProcedure.mId);
}
else if (conSqlStoreProcedure.SpId  ==  _AttributeName[intIndex])
{
mlngSpId = TransNullToInt(value.ToString());
 AddUpdatedFld(conSqlStoreProcedure.SpId);
}
else if (conSqlStoreProcedure.SpName  ==  _AttributeName[intIndex])
{
mstrSpName = value.ToString();
 AddUpdatedFld(conSqlStoreProcedure.SpName);
}
else if (conSqlStoreProcedure.uid  ==  _AttributeName[intIndex])
{
mintuid = TransNullToInt(value.ToString());
 AddUpdatedFld(conSqlStoreProcedure.uid);
}
else if (conSqlStoreProcedure.ConnectStringdb  ==  _AttributeName[intIndex])
{
mstrConnectStringdb = value.ToString();
 AddUpdatedFld(conSqlStoreProcedure.ConnectStringdb);
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
 AddUpdatedFld(conSqlStoreProcedure.mId);
}
}
/// <summary>
/// SP_ID(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long SpId
{
get
{
return mlngSpId;
}
set
{
 mlngSpId = value;
//记录修改过的字段
 AddUpdatedFld(conSqlStoreProcedure.SpId);
}
}
/// <summary>
/// 存储过程名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SpName
{
get
{
return mstrSpName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSpName = value;
}
else
{
 mstrSpName = value;
}
//记录修改过的字段
 AddUpdatedFld(conSqlStoreProcedure.SpName);
}
}
/// <summary>
/// uid(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int uid
{
get
{
return mintuid;
}
set
{
 mintuid = value;
//记录修改过的字段
 AddUpdatedFld(conSqlStoreProcedure.uid);
}
}
/// <summary>
/// ConnectString_db(说明:;字段类型:varchar;字段长度:255;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ConnectStringdb
{
get
{
return mstrConnectStringdb;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrConnectStringdb = value;
}
else
{
 mstrConnectStringdb = value;
}
//记录修改过的字段
 AddUpdatedFld(conSqlStoreProcedure.ConnectStringdb);
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
 /// Sql存储过程(SqlStoreProcedure)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conSqlStoreProcedure
{
public const string _CurrTabName = "SqlStoreProcedure"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "SpId", "SpName", "uid", "ConnectStringdb"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"SpId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SpId = "SpId";    //SP_ID

 /// <summary>
 /// 常量:"SpName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SpName = "SpName";    //存储过程名称

 /// <summary>
 /// 常量:"uid"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string uid = "uid";    //uid

 /// <summary>
 /// 常量:"ConnectStringdb"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConnectStringdb = "ConnectStringdb";    //ConnectString_db
}

}