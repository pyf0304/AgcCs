
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFunctionRelaEN
 表名:FunctionRela(00050319)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:10:52
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
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
 /// 表FunctionRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_FunctionRela
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
public K_mId_FunctionRela(long lngmId)
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
 /// <returns>返回:[K_mId_FunctionRela]类型的对象</returns>
public static implicit operator K_mId_FunctionRela(long value)
{
return new K_mId_FunctionRela(value);
}
}
 /// <summary>
 /// 函数与函数关系(FunctionRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsFunctionRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "FunctionRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 7;
public static string[] _AttributeName = new string[] {"mId", "FuncAId", "FuncBId", "FunctionRelaTypeId", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrFuncAId;    //函数AId
protected string mstrFuncBId;    //函数BId
protected string mstrFunctionRelaTypeId;    //函数关系类型Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsFunctionRelaEN()
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
public clsFunctionRelaEN(long lngmId)
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
if (strAttributeName  ==  conFunctionRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conFunctionRela.FuncAId)
{
return mstrFuncAId;
}
else if (strAttributeName  ==  conFunctionRela.FuncBId)
{
return mstrFuncBId;
}
else if (strAttributeName  ==  conFunctionRela.FunctionRelaTypeId)
{
return mstrFunctionRelaTypeId;
}
else if (strAttributeName  ==  conFunctionRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conFunctionRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conFunctionRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conFunctionRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conFunctionRela.mId);
}
else if (strAttributeName  ==  conFunctionRela.FuncAId)
{
mstrFuncAId = value.ToString();
 AddUpdatedFld(conFunctionRela.FuncAId);
}
else if (strAttributeName  ==  conFunctionRela.FuncBId)
{
mstrFuncBId = value.ToString();
 AddUpdatedFld(conFunctionRela.FuncBId);
}
else if (strAttributeName  ==  conFunctionRela.FunctionRelaTypeId)
{
mstrFunctionRelaTypeId = value.ToString();
 AddUpdatedFld(conFunctionRela.FunctionRelaTypeId);
}
else if (strAttributeName  ==  conFunctionRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFunctionRela.UpdDate);
}
else if (strAttributeName  ==  conFunctionRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conFunctionRela.UpdUser);
}
else if (strAttributeName  ==  conFunctionRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFunctionRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conFunctionRela.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (conFunctionRela.FuncAId  ==  _AttributeName[intIndex])
{
return mstrFuncAId;
}
else if (conFunctionRela.FuncBId  ==  _AttributeName[intIndex])
{
return mstrFuncBId;
}
else if (conFunctionRela.FunctionRelaTypeId  ==  _AttributeName[intIndex])
{
return mstrFunctionRelaTypeId;
}
else if (conFunctionRela.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conFunctionRela.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conFunctionRela.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conFunctionRela.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conFunctionRela.mId);
}
else if (conFunctionRela.FuncAId  ==  _AttributeName[intIndex])
{
mstrFuncAId = value.ToString();
 AddUpdatedFld(conFunctionRela.FuncAId);
}
else if (conFunctionRela.FuncBId  ==  _AttributeName[intIndex])
{
mstrFuncBId = value.ToString();
 AddUpdatedFld(conFunctionRela.FuncBId);
}
else if (conFunctionRela.FunctionRelaTypeId  ==  _AttributeName[intIndex])
{
mstrFunctionRelaTypeId = value.ToString();
 AddUpdatedFld(conFunctionRela.FunctionRelaTypeId);
}
else if (conFunctionRela.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFunctionRela.UpdDate);
}
else if (conFunctionRela.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conFunctionRela.UpdUser);
}
else if (conFunctionRela.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFunctionRela.Memo);
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
 AddUpdatedFld(conFunctionRela.mId);
}
}
/// <summary>
/// 函数AId(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncAId
{
get
{
return mstrFuncAId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncAId = value;
}
else
{
 mstrFuncAId = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunctionRela.FuncAId);
}
}
/// <summary>
/// 函数BId(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncBId
{
get
{
return mstrFuncBId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncBId = value;
}
else
{
 mstrFuncBId = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunctionRela.FuncBId);
}
}
/// <summary>
/// 函数关系类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FunctionRelaTypeId
{
get
{
return mstrFunctionRelaTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFunctionRelaTypeId = value;
}
else
{
 mstrFunctionRelaTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunctionRela.FunctionRelaTypeId);
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
 AddUpdatedFld(conFunctionRela.UpdDate);
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
 AddUpdatedFld(conFunctionRela.UpdUser);
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
 AddUpdatedFld(conFunctionRela.Memo);
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
 /// 函数与函数关系(FunctionRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conFunctionRela
{
public const string _CurrTabName = "FunctionRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "FuncAId", "FuncBId", "FunctionRelaTypeId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"FuncAId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncAId = "FuncAId";    //函数AId

 /// <summary>
 /// 常量:"FuncBId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncBId = "FuncBId";    //函数BId

 /// <summary>
 /// 常量:"FunctionRelaTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FunctionRelaTypeId = "FunctionRelaTypeId";    //函数关系类型Id

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