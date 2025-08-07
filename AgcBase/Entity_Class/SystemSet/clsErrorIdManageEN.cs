
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsErrorIdManageEN
 表名:ErrorIdManage(00050300)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:33:59
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
 /// 表ErrorIdManage的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_ErrorIdManage
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
public K_mId_ErrorIdManage(long lngmId)
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
 /// <returns>返回:[K_mId_ErrorIdManage]类型的对象</returns>
public static implicit operator K_mId_ErrorIdManage(long value)
{
return new K_mId_ErrorIdManage(value);
}
}
 /// <summary>
 /// 错误Id管理(ErrorIdManage)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsErrorIdManageEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ErrorIdManage"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 9;
public static string[] _AttributeName = new string[] {"mId", "ErrID", "ProgLevelTypeId", "CodeTypeId", "FunctionName", "Explanation", "UpdDate", "UpdUserId", "Memo"};

protected long mlngmId;    //mId
protected string mstrErrID;    //错误Id
protected string mstrProgLevelTypeId;    //程序分层类型Id
protected string mstrCodeTypeId;    //代码类型Id
protected string mstrFunctionName;    //功能名称
protected string mstrExplanation;    //详细说明
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsErrorIdManageEN()
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
public clsErrorIdManageEN(long lngmId)
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
if (strAttributeName  ==  conErrorIdManage.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conErrorIdManage.ErrID)
{
return mstrErrID;
}
else if (strAttributeName  ==  conErrorIdManage.ProgLevelTypeId)
{
return mstrProgLevelTypeId;
}
else if (strAttributeName  ==  conErrorIdManage.CodeTypeId)
{
return mstrCodeTypeId;
}
else if (strAttributeName  ==  conErrorIdManage.FunctionName)
{
return mstrFunctionName;
}
else if (strAttributeName  ==  conErrorIdManage.Explanation)
{
return mstrExplanation;
}
else if (strAttributeName  ==  conErrorIdManage.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conErrorIdManage.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conErrorIdManage.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conErrorIdManage.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conErrorIdManage.mId);
}
else if (strAttributeName  ==  conErrorIdManage.ErrID)
{
mstrErrID = value.ToString();
 AddUpdatedFld(conErrorIdManage.ErrID);
}
else if (strAttributeName  ==  conErrorIdManage.ProgLevelTypeId)
{
mstrProgLevelTypeId = value.ToString();
 AddUpdatedFld(conErrorIdManage.ProgLevelTypeId);
}
else if (strAttributeName  ==  conErrorIdManage.CodeTypeId)
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(conErrorIdManage.CodeTypeId);
}
else if (strAttributeName  ==  conErrorIdManage.FunctionName)
{
mstrFunctionName = value.ToString();
 AddUpdatedFld(conErrorIdManage.FunctionName);
}
else if (strAttributeName  ==  conErrorIdManage.Explanation)
{
mstrExplanation = value.ToString();
 AddUpdatedFld(conErrorIdManage.Explanation);
}
else if (strAttributeName  ==  conErrorIdManage.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conErrorIdManage.UpdDate);
}
else if (strAttributeName  ==  conErrorIdManage.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conErrorIdManage.UpdUserId);
}
else if (strAttributeName  ==  conErrorIdManage.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conErrorIdManage.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conErrorIdManage.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (conErrorIdManage.ErrID  ==  _AttributeName[intIndex])
{
return mstrErrID;
}
else if (conErrorIdManage.ProgLevelTypeId  ==  _AttributeName[intIndex])
{
return mstrProgLevelTypeId;
}
else if (conErrorIdManage.CodeTypeId  ==  _AttributeName[intIndex])
{
return mstrCodeTypeId;
}
else if (conErrorIdManage.FunctionName  ==  _AttributeName[intIndex])
{
return mstrFunctionName;
}
else if (conErrorIdManage.Explanation  ==  _AttributeName[intIndex])
{
return mstrExplanation;
}
else if (conErrorIdManage.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conErrorIdManage.UpdUserId  ==  _AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conErrorIdManage.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conErrorIdManage.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conErrorIdManage.mId);
}
else if (conErrorIdManage.ErrID  ==  _AttributeName[intIndex])
{
mstrErrID = value.ToString();
 AddUpdatedFld(conErrorIdManage.ErrID);
}
else if (conErrorIdManage.ProgLevelTypeId  ==  _AttributeName[intIndex])
{
mstrProgLevelTypeId = value.ToString();
 AddUpdatedFld(conErrorIdManage.ProgLevelTypeId);
}
else if (conErrorIdManage.CodeTypeId  ==  _AttributeName[intIndex])
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(conErrorIdManage.CodeTypeId);
}
else if (conErrorIdManage.FunctionName  ==  _AttributeName[intIndex])
{
mstrFunctionName = value.ToString();
 AddUpdatedFld(conErrorIdManage.FunctionName);
}
else if (conErrorIdManage.Explanation  ==  _AttributeName[intIndex])
{
mstrExplanation = value.ToString();
 AddUpdatedFld(conErrorIdManage.Explanation);
}
else if (conErrorIdManage.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conErrorIdManage.UpdDate);
}
else if (conErrorIdManage.UpdUserId  ==  _AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conErrorIdManage.UpdUserId);
}
else if (conErrorIdManage.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conErrorIdManage.Memo);
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
 AddUpdatedFld(conErrorIdManage.mId);
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
 AddUpdatedFld(conErrorIdManage.ErrID);
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
 AddUpdatedFld(conErrorIdManage.ProgLevelTypeId);
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
 AddUpdatedFld(conErrorIdManage.CodeTypeId);
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
 AddUpdatedFld(conErrorIdManage.FunctionName);
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
 AddUpdatedFld(conErrorIdManage.Explanation);
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
 AddUpdatedFld(conErrorIdManage.UpdDate);
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
 AddUpdatedFld(conErrorIdManage.UpdUserId);
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
 AddUpdatedFld(conErrorIdManage.Memo);
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
 /// 错误Id管理(ErrorIdManage)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conErrorIdManage
{
public const string _CurrTabName = "ErrorIdManage"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "ErrID", "ProgLevelTypeId", "CodeTypeId", "FunctionName", "Explanation", "UpdDate", "UpdUserId", "Memo"};
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
 /// 常量:"CodeTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTypeId = "CodeTypeId";    //代码类型Id

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