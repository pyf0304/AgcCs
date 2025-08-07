
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFuncParaRelaEN
 表名:FuncParaRela(00050498)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:32:09
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
 /// 表FuncParaRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_FuncParaRela
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
public K_mId_FuncParaRela(long lngmId)
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
 /// <returns>返回:[K_mId_FuncParaRela]类型的对象</returns>
public static implicit operator K_mId_FuncParaRela(long value)
{
return new K_mId_FuncParaRela(value);
}
}
 /// <summary>
 /// FuncParaRela(FuncParaRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsFuncParaRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "FuncParaRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 7;
public static string[] _AttributeName = new string[] {"mId", "FuncParaId4Code", "FuncId4Code", "OrderNum", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrFuncParaId4Code;    //函数参数Id
protected string mstrFuncId4Code;    //函数Id4Code
protected int? mintOrderNum;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsFuncParaRelaEN()
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
public clsFuncParaRelaEN(long lngmId)
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
if (strAttributeName  ==  conFuncParaRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conFuncParaRela.FuncParaId4Code)
{
return mstrFuncParaId4Code;
}
else if (strAttributeName  ==  conFuncParaRela.FuncId4Code)
{
return mstrFuncId4Code;
}
else if (strAttributeName  ==  conFuncParaRela.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conFuncParaRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conFuncParaRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conFuncParaRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conFuncParaRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conFuncParaRela.mId);
}
else if (strAttributeName  ==  conFuncParaRela.FuncParaId4Code)
{
mstrFuncParaId4Code = value.ToString();
 AddUpdatedFld(conFuncParaRela.FuncParaId4Code);
}
else if (strAttributeName  ==  conFuncParaRela.FuncId4Code)
{
mstrFuncId4Code = value.ToString();
 AddUpdatedFld(conFuncParaRela.FuncId4Code);
}
else if (strAttributeName  ==  conFuncParaRela.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conFuncParaRela.OrderNum);
}
else if (strAttributeName  ==  conFuncParaRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFuncParaRela.UpdDate);
}
else if (strAttributeName  ==  conFuncParaRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conFuncParaRela.UpdUser);
}
else if (strAttributeName  ==  conFuncParaRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFuncParaRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conFuncParaRela.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (conFuncParaRela.FuncParaId4Code  ==  _AttributeName[intIndex])
{
return mstrFuncParaId4Code;
}
else if (conFuncParaRela.FuncId4Code  ==  _AttributeName[intIndex])
{
return mstrFuncId4Code;
}
else if (conFuncParaRela.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conFuncParaRela.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conFuncParaRela.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conFuncParaRela.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conFuncParaRela.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conFuncParaRela.mId);
}
else if (conFuncParaRela.FuncParaId4Code  ==  _AttributeName[intIndex])
{
mstrFuncParaId4Code = value.ToString();
 AddUpdatedFld(conFuncParaRela.FuncParaId4Code);
}
else if (conFuncParaRela.FuncId4Code  ==  _AttributeName[intIndex])
{
mstrFuncId4Code = value.ToString();
 AddUpdatedFld(conFuncParaRela.FuncId4Code);
}
else if (conFuncParaRela.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conFuncParaRela.OrderNum);
}
else if (conFuncParaRela.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFuncParaRela.UpdDate);
}
else if (conFuncParaRela.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conFuncParaRela.UpdUser);
}
else if (conFuncParaRela.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFuncParaRela.Memo);
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
 AddUpdatedFld(conFuncParaRela.mId);
}
}
/// <summary>
/// 函数参数Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncParaId4Code
{
get
{
return mstrFuncParaId4Code;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncParaId4Code = value;
}
else
{
 mstrFuncParaId4Code = value;
}
//记录修改过的字段
 AddUpdatedFld(conFuncParaRela.FuncParaId4Code);
}
}
/// <summary>
/// 函数Id4Code(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncId4Code
{
get
{
return mstrFuncId4Code;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncId4Code = value;
}
else
{
 mstrFuncId4Code = value;
}
//记录修改过的字段
 AddUpdatedFld(conFuncParaRela.FuncId4Code);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(conFuncParaRela.OrderNum);
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
 AddUpdatedFld(conFuncParaRela.UpdDate);
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
 AddUpdatedFld(conFuncParaRela.UpdUser);
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
 AddUpdatedFld(conFuncParaRela.Memo);
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
 /// FuncParaRela(FuncParaRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conFuncParaRela
{
public const string _CurrTabName = "FuncParaRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "FuncParaId4Code", "FuncId4Code", "OrderNum", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"FuncParaId4Code"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncParaId4Code = "FuncParaId4Code";    //函数参数Id

 /// <summary>
 /// 常量:"FuncId4Code"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncId4Code = "FuncId4Code";    //函数Id4Code

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

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