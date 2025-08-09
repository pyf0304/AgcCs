
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSqlSP_ParaEN
 表名:SqlSP_Para(00050183)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:13:49
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
 /// 表SqlSP_Para的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_SqlSP_Para
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
public K_mId_SqlSP_Para(long lngmId)
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
 /// <returns>返回:[K_mId_SqlSP_Para]类型的对象</returns>
public static implicit operator K_mId_SqlSP_Para(long value)
{
return new K_mId_SqlSP_Para(value);
}
}
 /// <summary>
 /// SQL存储过程参数(SqlSP_Para)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsSqlSP_ParaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "SqlSP_Para"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 8;
public static string[] _AttributeName = new string[] {"mId", "IdStoreProcedure", "ParaName", "ParaSize", "ParaDataType", "ParaDirection", "IsNullable", "SpId"};

protected long mlngmId;    //mId
protected long mlngIdStoreProcedure;    //存储过程流水号
protected string mstrParaName;    //参数名
protected short mshtParaSize;    //参数长度
protected string mstrParaDataType;    //参数数据类型
protected string mstrParaDirection;    //参数数据类型
protected bool mbolIsNullable;    //是否可空
protected long mlngSpId;    //SP_ID

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsSqlSP_ParaEN()
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
public clsSqlSP_ParaEN(long lngmId)
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
if (strAttributeName  ==  conSqlSP_Para.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conSqlSP_Para.IdStoreProcedure)
{
return mlngIdStoreProcedure;
}
else if (strAttributeName  ==  conSqlSP_Para.ParaName)
{
return mstrParaName;
}
else if (strAttributeName  ==  conSqlSP_Para.ParaSize)
{
return mshtParaSize;
}
else if (strAttributeName  ==  conSqlSP_Para.ParaDataType)
{
return mstrParaDataType;
}
else if (strAttributeName  ==  conSqlSP_Para.ParaDirection)
{
return mstrParaDirection;
}
else if (strAttributeName  ==  conSqlSP_Para.IsNullable)
{
return mbolIsNullable;
}
else if (strAttributeName  ==  conSqlSP_Para.SpId)
{
return mlngSpId;
}
return null;
}
set
{
if (strAttributeName  ==  conSqlSP_Para.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conSqlSP_Para.mId);
}
else if (strAttributeName  ==  conSqlSP_Para.IdStoreProcedure)
{
mlngIdStoreProcedure = TransNullToInt(value.ToString());
 AddUpdatedFld(conSqlSP_Para.IdStoreProcedure);
}
else if (strAttributeName  ==  conSqlSP_Para.ParaName)
{
mstrParaName = value.ToString();
 AddUpdatedFld(conSqlSP_Para.ParaName);
}
else if (strAttributeName  ==  conSqlSP_Para.ParaSize)
{
mshtParaSize = TransNullToShort(value.ToString());
 AddUpdatedFld(conSqlSP_Para.ParaSize);
}
else if (strAttributeName  ==  conSqlSP_Para.ParaDataType)
{
mstrParaDataType = value.ToString();
 AddUpdatedFld(conSqlSP_Para.ParaDataType);
}
else if (strAttributeName  ==  conSqlSP_Para.ParaDirection)
{
mstrParaDirection = value.ToString();
 AddUpdatedFld(conSqlSP_Para.ParaDirection);
}
else if (strAttributeName  ==  conSqlSP_Para.IsNullable)
{
mbolIsNullable = TransNullToBool(value.ToString());
 AddUpdatedFld(conSqlSP_Para.IsNullable);
}
else if (strAttributeName  ==  conSqlSP_Para.SpId)
{
mlngSpId = TransNullToInt(value.ToString());
 AddUpdatedFld(conSqlSP_Para.SpId);
}
}
}
public object this[int intIndex]
{
get
{
if (conSqlSP_Para.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (conSqlSP_Para.IdStoreProcedure  ==  _AttributeName[intIndex])
{
return mlngIdStoreProcedure;
}
else if (conSqlSP_Para.ParaName  ==  _AttributeName[intIndex])
{
return mstrParaName;
}
else if (conSqlSP_Para.ParaSize  ==  _AttributeName[intIndex])
{
return mshtParaSize;
}
else if (conSqlSP_Para.ParaDataType  ==  _AttributeName[intIndex])
{
return mstrParaDataType;
}
else if (conSqlSP_Para.ParaDirection  ==  _AttributeName[intIndex])
{
return mstrParaDirection;
}
else if (conSqlSP_Para.IsNullable  ==  _AttributeName[intIndex])
{
return mbolIsNullable;
}
else if (conSqlSP_Para.SpId  ==  _AttributeName[intIndex])
{
return mlngSpId;
}
return null;
}
set
{
if (conSqlSP_Para.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conSqlSP_Para.mId);
}
else if (conSqlSP_Para.IdStoreProcedure  ==  _AttributeName[intIndex])
{
mlngIdStoreProcedure = TransNullToInt(value.ToString());
 AddUpdatedFld(conSqlSP_Para.IdStoreProcedure);
}
else if (conSqlSP_Para.ParaName  ==  _AttributeName[intIndex])
{
mstrParaName = value.ToString();
 AddUpdatedFld(conSqlSP_Para.ParaName);
}
else if (conSqlSP_Para.ParaSize  ==  _AttributeName[intIndex])
{
mshtParaSize = TransNullToShort(value.ToString());
 AddUpdatedFld(conSqlSP_Para.ParaSize);
}
else if (conSqlSP_Para.ParaDataType  ==  _AttributeName[intIndex])
{
mstrParaDataType = value.ToString();
 AddUpdatedFld(conSqlSP_Para.ParaDataType);
}
else if (conSqlSP_Para.ParaDirection  ==  _AttributeName[intIndex])
{
mstrParaDirection = value.ToString();
 AddUpdatedFld(conSqlSP_Para.ParaDirection);
}
else if (conSqlSP_Para.IsNullable  ==  _AttributeName[intIndex])
{
mbolIsNullable = TransNullToBool(value.ToString());
 AddUpdatedFld(conSqlSP_Para.IsNullable);
}
else if (conSqlSP_Para.SpId  ==  _AttributeName[intIndex])
{
mlngSpId = TransNullToInt(value.ToString());
 AddUpdatedFld(conSqlSP_Para.SpId);
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
 AddUpdatedFld(conSqlSP_Para.mId);
}
}
/// <summary>
/// 存储过程流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdStoreProcedure
{
get
{
return mlngIdStoreProcedure;
}
set
{
 mlngIdStoreProcedure = value;
//记录修改过的字段
 AddUpdatedFld(conSqlSP_Para.IdStoreProcedure);
}
}
/// <summary>
/// 参数名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParaName
{
get
{
return mstrParaName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParaName = value;
}
else
{
 mstrParaName = value;
}
//记录修改过的字段
 AddUpdatedFld(conSqlSP_Para.ParaName);
}
}
/// <summary>
/// 参数长度(说明:;字段类型:tinyint;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public short ParaSize
{
get
{
return mshtParaSize;
}
set
{
 mshtParaSize = value;
//记录修改过的字段
 AddUpdatedFld(conSqlSP_Para.ParaSize);
}
}
/// <summary>
/// 参数数据类型(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParaDataType
{
get
{
return mstrParaDataType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParaDataType = value;
}
else
{
 mstrParaDataType = value;
}
//记录修改过的字段
 AddUpdatedFld(conSqlSP_Para.ParaDataType);
}
}
/// <summary>
/// 参数数据类型(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParaDirection
{
get
{
return mstrParaDirection;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParaDirection = value;
}
else
{
 mstrParaDirection = value;
}
//记录修改过的字段
 AddUpdatedFld(conSqlSP_Para.ParaDirection);
}
}
/// <summary>
/// 是否可空(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsNullable
{
get
{
return mbolIsNullable;
}
set
{
 mbolIsNullable = value;
//记录修改过的字段
 AddUpdatedFld(conSqlSP_Para.IsNullable);
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
 AddUpdatedFld(conSqlSP_Para.SpId);
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
 /// SQL存储过程参数(SqlSP_Para)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conSqlSP_Para
{
public const string _CurrTabName = "SqlSP_Para"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "IdStoreProcedure", "ParaName", "ParaSize", "ParaDataType", "ParaDirection", "IsNullable", "SpId"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"IdStoreProcedure"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdStoreProcedure = "IdStoreProcedure";    //存储过程流水号

 /// <summary>
 /// 常量:"ParaName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParaName = "ParaName";    //参数名

 /// <summary>
 /// 常量:"ParaSize"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParaSize = "ParaSize";    //参数长度

 /// <summary>
 /// 常量:"ParaDataType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParaDataType = "ParaDataType";    //参数数据类型

 /// <summary>
 /// 常量:"ParaDirection"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParaDirection = "ParaDirection";    //参数数据类型

 /// <summary>
 /// 常量:"IsNullable"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsNullable = "IsNullable";    //是否可空

 /// <summary>
 /// 常量:"SpId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SpId = "SpId";    //SP_ID
}

}