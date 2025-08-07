
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsProgLevelTypeEN
 表名:ProgLevelType(00050301)
 生成代码版本:2018.08.11.1
 生成日期:2018/08/12 00:05:34
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
 /// 程序分层类型(ProgLevelType)
 /// (AutoGCLib.AutoGC6Cs_M:A_GenEntityLayerCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsProgLevelTypeEN : clsEntityBase2
{
public const string CurrTabName_S = "ProgLevelType"; //当前表名,与该类相关的表名
public const string CurrTabKeyFldName_S = "ProgLevelTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"ProgLevelTypeId", "ProgLevelTypeName", "CodeTypeId", "ProgLevelTypeENName", "Prefix", "OrderNum", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量

protected string mstrProgLevelTypeId;    //程序分层类型Id
protected string mstrProgLevelTypeName;    //程序分层类型名称
protected string mstrCodeTypeId;    //代码类型Id
protected string mstrProgLevelTypeENName;    //程序分层类型英文名称
protected string mstrPrefix;    //前缀
protected int mintOrderNum;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //说明


 /// <summary>
 /// 常量:"ProgLevelTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ProgLevelTypeId = "ProgLevelTypeId";    //程序分层类型Id

 /// <summary>
 /// 常量:"ProgLevelTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ProgLevelTypeName = "ProgLevelTypeName";    //程序分层类型名称

 /// <summary>
 /// 常量:"CodeTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_CodeTypeId = "CodeTypeId";    //代码类型Id

 /// <summary>
 /// 常量:"ProgLevelTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ProgLevelTypeENName = "ProgLevelTypeENName";    //程序分层类型英文名称

 /// <summary>
 /// 常量:"Prefix"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Prefix = "Prefix";    //前缀

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo = "Memo";    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.AutoGCPubFuncV6:GenClassConstructor1)
/// </summary>
 public clsProgLevelTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 CurrTabName = "ProgLevelType";
 lstKeyFldNames.Add("ProgLevelTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.AutoGCPubFuncV6:GenClassConstructor2)
/// </summary>
/// <param name = "mstrProgLevelTypeId">关键字:程序分层类型Id</param>
public clsProgLevelTypeEN(string strProgLevelTypeId)
 {
strProgLevelTypeId = strProgLevelTypeId.Replace("'", "''");
if (strProgLevelTypeId.Length > 2)
{
throw new Exception("在表:ProgLevelType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strProgLevelTypeId)  ==  true)
{
throw new Exception("在表:ProgLevelType中,关键字不能为空 或 null!");
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
 CurrTabName = "ProgLevelType";
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
else if (strAttributeName  ==  con_ProgLevelTypeName)
{
return mstrProgLevelTypeName;
}
else if (strAttributeName  ==  con_CodeTypeId)
{
return mstrCodeTypeId;
}
else if (strAttributeName  ==  con_ProgLevelTypeENName)
{
return mstrProgLevelTypeENName;
}
else if (strAttributeName  ==  con_Prefix)
{
return mstrPrefix;
}
else if (strAttributeName  ==  con_OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  con_UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  con_UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  con_Memo)
{
return mstrMemo;
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
else if (strAttributeName  ==  con_ProgLevelTypeName)
{
mstrProgLevelTypeName = value.ToString();
 AddUpdatedFld(con_ProgLevelTypeName);
}
else if (strAttributeName  ==  con_CodeTypeId)
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(con_CodeTypeId);
}
else if (strAttributeName  ==  con_ProgLevelTypeENName)
{
mstrProgLevelTypeENName = value.ToString();
 AddUpdatedFld(con_ProgLevelTypeENName);
}
else if (strAttributeName  ==  con_Prefix)
{
mstrPrefix = value.ToString();
 AddUpdatedFld(con_Prefix);
}
else if (strAttributeName  ==  con_OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(con_OrderNum);
}
else if (strAttributeName  ==  con_UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(con_UpdDate);
}
else if (strAttributeName  ==  con_UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(con_UpdUserId);
}
else if (strAttributeName  ==  con_Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
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
else if (con_ProgLevelTypeName  ==  AttributeName[intIndex])
{
return mstrProgLevelTypeName;
}
else if (con_CodeTypeId  ==  AttributeName[intIndex])
{
return mstrCodeTypeId;
}
else if (con_ProgLevelTypeENName  ==  AttributeName[intIndex])
{
return mstrProgLevelTypeENName;
}
else if (con_Prefix  ==  AttributeName[intIndex])
{
return mstrPrefix;
}
else if (con_OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (con_UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (con_UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (con_Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
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
else if (con_ProgLevelTypeName  ==  AttributeName[intIndex])
{
mstrProgLevelTypeName = value.ToString();
 AddUpdatedFld(con_ProgLevelTypeName);
}
else if (con_CodeTypeId  ==  AttributeName[intIndex])
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(con_CodeTypeId);
}
else if (con_ProgLevelTypeENName  ==  AttributeName[intIndex])
{
mstrProgLevelTypeENName = value.ToString();
 AddUpdatedFld(con_ProgLevelTypeENName);
}
else if (con_Prefix  ==  AttributeName[intIndex])
{
mstrPrefix = value.ToString();
 AddUpdatedFld(con_Prefix);
}
else if (con_OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(con_OrderNum);
}
else if (con_UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(con_UpdDate);
}
else if (con_UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(con_UpdUserId);
}
else if (con_Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
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
/// 程序分层类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLevelTypeName
{
get
{
return mstrProgLevelTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLevelTypeName = value;
}
else
{
 mstrProgLevelTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_ProgLevelTypeName);
}
}
/// <summary>
/// 代码类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTypeId
{
get
{
return mstrCodeTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTypeId = value;
}
else
{
 mstrCodeTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_CodeTypeId);
}
}
/// <summary>
/// 程序分层类型英文名称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLevelTypeENName
{
get
{
return mstrProgLevelTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLevelTypeENName = value;
}
else
{
 mstrProgLevelTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_ProgLevelTypeENName);
}
}
/// <summary>
/// 前缀(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Prefix
{
get
{
return mstrPrefix;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrefix = value;
}
else
{
 mstrPrefix = value;
}
//记录修改过的字段
 AddUpdatedFld(con_Prefix);
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
/// 修改日期(说明:;字段类型:varchar;字段长度:14;是否可空:True)
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
 AddUpdatedFld(con_UpdDate);
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
 AddUpdatedFld(con_UpdUserId);
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
 AddUpdatedFld(con_Memo);
}
}

/// <summary>
/// 获取关键字Id(KeyId)
 /// (AutoGCLib.AutoGCPubFuncV6:GenGetKeyId)
/// </summary>
 public override string KeyId
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
 public override string NameValue
 {
 get
 {
  return mstrProgLevelTypeName;
 }
 }
}
}