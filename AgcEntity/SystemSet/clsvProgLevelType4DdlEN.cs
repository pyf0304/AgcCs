
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvProgLevelType4DdlEN
 表名:vProgLevelType4Ddl(00050404)
 生成代码版本:2018.08.11.1
 生成日期:2018/08/12 00:24:45
 生成者:潘以锋
 生成服务器IP:101.251.68.133
 工程名称:AGC
 工程ID:0005
 相关数据库:101.251.68.133,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统设置
 模块英文名:SystemSet
 框架-层名:实体层(EntityLayer)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2018.07.27.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
using System;
using System.Text; 
using System.Collections; 
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System.Runtime.Serialization;

namespace AGC.Entity
{
 /// <summary>
 /// vProgLevelType4Ddl(vProgLevelType4Ddl)
 /// (AutoGCLib.AutoGC6Cs_M:A_GenEntityLayerCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvProgLevelType4DdlEN : clsEntityBase2
{
public const string CurrTabName_S = "vProgLevelType4Ddl"; //当前表名,与该类相关的表名
public const string CurrTabKeyFldName_S = "ProgLevelTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"ProgLevelTypeId", "ProgLevelTypeName4Ddl", "OrderNum"};
//以下是属性变量

protected string mstrProgLevelTypeId;    //程序分层类型Id
protected string mstrProgLevelTypeName4Ddl;    //ProgLevelTypeName4Ddl
protected int mintOrderNum;    //序号


 /// <summary>
 /// 常量:"ProgLevelTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ProgLevelTypeId = "ProgLevelTypeId";    //程序分层类型Id

 /// <summary>
 /// 常量:"ProgLevelTypeName4Ddl"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ProgLevelTypeName4Ddl = "ProgLevelTypeName4Ddl";    //ProgLevelTypeName4Ddl

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_OrderNum = "OrderNum";    //序号

/// <summary>
/// 构造函数
 /// (AutoGCLib.AutoGCPubFuncV6:GenClassConstructor1)
/// </summary>
 public clsvProgLevelType4DdlEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "vProgLevelType4Ddl";
 lstKeyFldNames.Add("ProgLevelTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.AutoGCPubFuncV6:GenClassConstructor2)
/// </summary>
/// <param name = "mstrProgLevelTypeId">关键字:程序分层类型Id</param>
public clsvProgLevelType4DdlEN(string strProgLevelTypeId)
 {
strProgLevelTypeId = strProgLevelTypeId.Replace("'", "''");
if (strProgLevelTypeId.Length > 2)
{
throw new Exception("在表:vProgLevelType4Ddl中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strProgLevelTypeId)  ==  true)
{
throw new Exception("在表:vProgLevelType4Ddl中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strProgLevelTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

mstrProgLevelTypeId = strProgLevelTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "vProgLevelType4Ddl";
 lstKeyFldNames.Add("ProgLevelTypeId");
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
if (strAttributeName  ==  con_ProgLevelTypeId)
{
return mstrProgLevelTypeId;
}
else if (strAttributeName  ==  con_ProgLevelTypeName4Ddl)
{
return mstrProgLevelTypeName4Ddl;
}
else if (strAttributeName  ==  con_OrderNum)
{
return mintOrderNum;
}
return null;
}
set
{
if (strAttributeName  ==  con_ProgLevelTypeId)
{
mstrProgLevelTypeId = value.ToString();
 AddUpdatedFld(con_ProgLevelTypeId);
}
else if (strAttributeName  ==  con_ProgLevelTypeName4Ddl)
{
mstrProgLevelTypeName4Ddl = value.ToString();
 AddUpdatedFld(con_ProgLevelTypeName4Ddl);
}
else if (strAttributeName  ==  con_OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(con_OrderNum);
}
}
}
public object this[int intIndex]
{
get
{
if (con_ProgLevelTypeId  ==  AttributeName[intIndex])
{
return mstrProgLevelTypeId;
}
else if (con_ProgLevelTypeName4Ddl  ==  AttributeName[intIndex])
{
return mstrProgLevelTypeName4Ddl;
}
else if (con_OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
return null;
}
set
{
if (con_ProgLevelTypeId  ==  AttributeName[intIndex])
{
mstrProgLevelTypeId = value.ToString();
 AddUpdatedFld(con_ProgLevelTypeId);
}
else if (con_ProgLevelTypeName4Ddl  ==  AttributeName[intIndex])
{
mstrProgLevelTypeName4Ddl = value.ToString();
 AddUpdatedFld(con_ProgLevelTypeName4Ddl);
}
else if (con_OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(con_OrderNum);
}
}
}

/// <summary>
/// 程序分层类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLevelTypeId
{
get
{
return mstrProgLevelTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLevelTypeId = value;
}
else
{
 mstrProgLevelTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_ProgLevelTypeId);
}
}
/// <summary>
/// ProgLevelTypeName4Ddl(说明:;字段类型:varchar;字段长度:32;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLevelTypeName4Ddl
{
get
{
return mstrProgLevelTypeName4Ddl;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLevelTypeName4Ddl = value;
}
else
{
 mstrProgLevelTypeName4Ddl = value;
}
//记录修改过的字段
 AddUpdatedFld(con_ProgLevelTypeName4Ddl);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(con_OrderNum);
}
}

/// <summary>
/// 获取关键字Id(KeyId)
 /// (AutoGCLib.AutoGCPubFuncV6:GenGetKeyId)
/// </summary>
 public override string _KeyId
 {
 get
 {
  return mstrProgLevelTypeId;
 }
 }

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.AutoGCPubFuncV6:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrProgLevelTypeName4Ddl;
 }
 }
}
}