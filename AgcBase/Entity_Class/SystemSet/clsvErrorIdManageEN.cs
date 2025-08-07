
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvErrorIdManageEN
 表名:vErrorIdManage(00050302)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:17:31
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统设置(SystemSet)
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
 /// 表vErrorIdManage的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vErrorIdManage
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
public K_mId_vErrorIdManage(long lngmId)
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
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_mId_vErrorIdManage]类型的对象</returns>
public static implicit operator K_mId_vErrorIdManage(long value)
{
return new K_mId_vErrorIdManage(value);
}
}
 /// <summary>
 /// v错误Id管理(vErrorIdManage)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvErrorIdManageEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接，如果为空就使用系统默认的连接
public new const string _CurrTabName = "vErrorIdManage"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string WhereFormat = ""; //条件格式串
protected const int mintAttributeCount = 14;
public static string[] AttributeName = new string[] {"mId", "ErrID", "ProgLevelTypeId", "ProgLevelTypeName", "ProgLevelTypeENName", "Prefix", "CodeTypeId", "CodeTypeName", "CodeTypeENName", "FunctionName", "Explanation", "UpdDate", "UpdUserId", "Memo"};

protected long mlngmId;    //mId
protected string mstrErrID;    //错误Id
protected string mstrProgLevelTypeId;    //程序分层类型Id
protected string mstrProgLevelTypeName;    //程序分层类型名称
protected string mstrProgLevelTypeENName;    //程序分层类型英文名称
protected string mstrPrefix;    //前缀
protected string mstrCodeTypeId;    //代码类型Id
protected string mstrCodeTypeName;    //代码类型名
protected string mstrCodeTypeENName;    //代码类型英文名
protected string mstrFunctionName;    //功能名称
protected string mstrExplanation;    //详细说明
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvErrorIdManageEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "vErrorIdManage";
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:mId</param>
public clsvErrorIdManageEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "vErrorIdManage";
 lstKeyFldNames.Add("mId");
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
if (strAttributeName  ==  convErrorIdManage.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convErrorIdManage.ErrID)
{
return mstrErrID;
}
else if (strAttributeName  ==  convErrorIdManage.ProgLevelTypeId)
{
return mstrProgLevelTypeId;
}
else if (strAttributeName  ==  convErrorIdManage.ProgLevelTypeName)
{
return mstrProgLevelTypeName;
}
else if (strAttributeName  ==  convErrorIdManage.ProgLevelTypeENName)
{
return mstrProgLevelTypeENName;
}
else if (strAttributeName  ==  convErrorIdManage.Prefix)
{
return mstrPrefix;
}
else if (strAttributeName  ==  convErrorIdManage.CodeTypeId)
{
return mstrCodeTypeId;
}
else if (strAttributeName  ==  convErrorIdManage.CodeTypeName)
{
return mstrCodeTypeName;
}
else if (strAttributeName  ==  convErrorIdManage.CodeTypeENName)
{
return mstrCodeTypeENName;
}
else if (strAttributeName  ==  convErrorIdManage.FunctionName)
{
return mstrFunctionName;
}
else if (strAttributeName  ==  convErrorIdManage.Explanation)
{
return mstrExplanation;
}
else if (strAttributeName  ==  convErrorIdManage.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convErrorIdManage.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convErrorIdManage.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convErrorIdManage.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convErrorIdManage.mId);
}
else if (strAttributeName  ==  convErrorIdManage.ErrID)
{
mstrErrID = value.ToString();
 AddUpdatedFld(convErrorIdManage.ErrID);
}
else if (strAttributeName  ==  convErrorIdManage.ProgLevelTypeId)
{
mstrProgLevelTypeId = value.ToString();
 AddUpdatedFld(convErrorIdManage.ProgLevelTypeId);
}
else if (strAttributeName  ==  convErrorIdManage.ProgLevelTypeName)
{
mstrProgLevelTypeName = value.ToString();
 AddUpdatedFld(convErrorIdManage.ProgLevelTypeName);
}
else if (strAttributeName  ==  convErrorIdManage.ProgLevelTypeENName)
{
mstrProgLevelTypeENName = value.ToString();
 AddUpdatedFld(convErrorIdManage.ProgLevelTypeENName);
}
else if (strAttributeName  ==  convErrorIdManage.Prefix)
{
mstrPrefix = value.ToString();
 AddUpdatedFld(convErrorIdManage.Prefix);
}
else if (strAttributeName  ==  convErrorIdManage.CodeTypeId)
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(convErrorIdManage.CodeTypeId);
}
else if (strAttributeName  ==  convErrorIdManage.CodeTypeName)
{
mstrCodeTypeName = value.ToString();
 AddUpdatedFld(convErrorIdManage.CodeTypeName);
}
else if (strAttributeName  ==  convErrorIdManage.CodeTypeENName)
{
mstrCodeTypeENName = value.ToString();
 AddUpdatedFld(convErrorIdManage.CodeTypeENName);
}
else if (strAttributeName  ==  convErrorIdManage.FunctionName)
{
mstrFunctionName = value.ToString();
 AddUpdatedFld(convErrorIdManage.FunctionName);
}
else if (strAttributeName  ==  convErrorIdManage.Explanation)
{
mstrExplanation = value.ToString();
 AddUpdatedFld(convErrorIdManage.Explanation);
}
else if (strAttributeName  ==  convErrorIdManage.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convErrorIdManage.UpdDate);
}
else if (strAttributeName  ==  convErrorIdManage.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convErrorIdManage.UpdUserId);
}
else if (strAttributeName  ==  convErrorIdManage.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convErrorIdManage.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convErrorIdManage.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convErrorIdManage.ErrID  ==  AttributeName[intIndex])
{
return mstrErrID;
}
else if (convErrorIdManage.ProgLevelTypeId  ==  AttributeName[intIndex])
{
return mstrProgLevelTypeId;
}
else if (convErrorIdManage.ProgLevelTypeName  ==  AttributeName[intIndex])
{
return mstrProgLevelTypeName;
}
else if (convErrorIdManage.ProgLevelTypeENName  ==  AttributeName[intIndex])
{
return mstrProgLevelTypeENName;
}
else if (convErrorIdManage.Prefix  ==  AttributeName[intIndex])
{
return mstrPrefix;
}
else if (convErrorIdManage.CodeTypeId  ==  AttributeName[intIndex])
{
return mstrCodeTypeId;
}
else if (convErrorIdManage.CodeTypeName  ==  AttributeName[intIndex])
{
return mstrCodeTypeName;
}
else if (convErrorIdManage.CodeTypeENName  ==  AttributeName[intIndex])
{
return mstrCodeTypeENName;
}
else if (convErrorIdManage.FunctionName  ==  AttributeName[intIndex])
{
return mstrFunctionName;
}
else if (convErrorIdManage.Explanation  ==  AttributeName[intIndex])
{
return mstrExplanation;
}
else if (convErrorIdManage.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convErrorIdManage.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convErrorIdManage.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convErrorIdManage.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convErrorIdManage.mId);
}
else if (convErrorIdManage.ErrID  ==  AttributeName[intIndex])
{
mstrErrID = value.ToString();
 AddUpdatedFld(convErrorIdManage.ErrID);
}
else if (convErrorIdManage.ProgLevelTypeId  ==  AttributeName[intIndex])
{
mstrProgLevelTypeId = value.ToString();
 AddUpdatedFld(convErrorIdManage.ProgLevelTypeId);
}
else if (convErrorIdManage.ProgLevelTypeName  ==  AttributeName[intIndex])
{
mstrProgLevelTypeName = value.ToString();
 AddUpdatedFld(convErrorIdManage.ProgLevelTypeName);
}
else if (convErrorIdManage.ProgLevelTypeENName  ==  AttributeName[intIndex])
{
mstrProgLevelTypeENName = value.ToString();
 AddUpdatedFld(convErrorIdManage.ProgLevelTypeENName);
}
else if (convErrorIdManage.Prefix  ==  AttributeName[intIndex])
{
mstrPrefix = value.ToString();
 AddUpdatedFld(convErrorIdManage.Prefix);
}
else if (convErrorIdManage.CodeTypeId  ==  AttributeName[intIndex])
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(convErrorIdManage.CodeTypeId);
}
else if (convErrorIdManage.CodeTypeName  ==  AttributeName[intIndex])
{
mstrCodeTypeName = value.ToString();
 AddUpdatedFld(convErrorIdManage.CodeTypeName);
}
else if (convErrorIdManage.CodeTypeENName  ==  AttributeName[intIndex])
{
mstrCodeTypeENName = value.ToString();
 AddUpdatedFld(convErrorIdManage.CodeTypeENName);
}
else if (convErrorIdManage.FunctionName  ==  AttributeName[intIndex])
{
mstrFunctionName = value.ToString();
 AddUpdatedFld(convErrorIdManage.FunctionName);
}
else if (convErrorIdManage.Explanation  ==  AttributeName[intIndex])
{
mstrExplanation = value.ToString();
 AddUpdatedFld(convErrorIdManage.Explanation);
}
else if (convErrorIdManage.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convErrorIdManage.UpdDate);
}
else if (convErrorIdManage.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convErrorIdManage.UpdUserId);
}
else if (convErrorIdManage.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convErrorIdManage.Memo);
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
 AddUpdatedFld(convErrorIdManage.mId);
}
}
/// <summary>
/// 错误Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ErrID
{
get
{
return mstrErrID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrErrID = value;
}
else
{
 mstrErrID = value;
}
//记录修改过的字段
 AddUpdatedFld(convErrorIdManage.ErrID);
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
 AddUpdatedFld(convErrorIdManage.ProgLevelTypeId);
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
 AddUpdatedFld(convErrorIdManage.ProgLevelTypeName);
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
 AddUpdatedFld(convErrorIdManage.ProgLevelTypeENName);
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
 AddUpdatedFld(convErrorIdManage.Prefix);
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
 AddUpdatedFld(convErrorIdManage.CodeTypeId);
}
}
/// <summary>
/// 代码类型名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTypeName
{
get
{
return mstrCodeTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTypeName = value;
}
else
{
 mstrCodeTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convErrorIdManage.CodeTypeName);
}
}
/// <summary>
/// 代码类型英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTypeENName
{
get
{
return mstrCodeTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTypeENName = value;
}
else
{
 mstrCodeTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(convErrorIdManage.CodeTypeENName);
}
}
/// <summary>
/// 功能名称(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FunctionName
{
get
{
return mstrFunctionName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFunctionName = value;
}
else
{
 mstrFunctionName = value;
}
//记录修改过的字段
 AddUpdatedFld(convErrorIdManage.FunctionName);
}
}
/// <summary>
/// 详细说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Explanation
{
get
{
return mstrExplanation;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExplanation = value;
}
else
{
 mstrExplanation = value;
}
//记录修改过的字段
 AddUpdatedFld(convErrorIdManage.Explanation);
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
 AddUpdatedFld(convErrorIdManage.UpdDate);
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
 AddUpdatedFld(convErrorIdManage.UpdUserId);
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
 AddUpdatedFld(convErrorIdManage.Memo);
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
  return mlngmId.ToString();
 }
 }
}
 /// <summary>
 /// v错误Id管理(vErrorIdManage)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convErrorIdManage
{
public new const string _CurrTabName = "vErrorIdManage"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "ErrID", "ProgLevelTypeId", "ProgLevelTypeName", "ProgLevelTypeENName", "Prefix", "CodeTypeId", "CodeTypeName", "CodeTypeENName", "FunctionName", "Explanation", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"ErrID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ErrID = "ErrID";    //错误Id

 /// <summary>
 /// 常量:"ProgLevelTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLevelTypeId = "ProgLevelTypeId";    //程序分层类型Id

 /// <summary>
 /// 常量:"ProgLevelTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLevelTypeName = "ProgLevelTypeName";    //程序分层类型名称

 /// <summary>
 /// 常量:"ProgLevelTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLevelTypeENName = "ProgLevelTypeENName";    //程序分层类型英文名称

 /// <summary>
 /// 常量:"Prefix"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Prefix = "Prefix";    //前缀

 /// <summary>
 /// 常量:"CodeTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTypeId = "CodeTypeId";    //代码类型Id

 /// <summary>
 /// 常量:"CodeTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTypeName = "CodeTypeName";    //代码类型名

 /// <summary>
 /// 常量:"CodeTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTypeENName = "CodeTypeENName";    //代码类型英文名

 /// <summary>
 /// 常量:"FunctionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FunctionName = "FunctionName";    //功能名称

 /// <summary>
 /// 常量:"Explanation"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Explanation = "Explanation";    //详细说明

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