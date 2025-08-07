
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCMClassFuncRelaEN
 表名:CMClassFuncRela(00050505)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:33:20
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:代码管理(CodeMan)
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
 /// 表CMClassFuncRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_CMClassFuncRela
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
public K_mId_CMClassFuncRela(long lngmId)
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
 /// <returns>返回:[K_mId_CMClassFuncRela]类型的对象</returns>
public static implicit operator K_mId_CMClassFuncRela(long value)
{
return new K_mId_CMClassFuncRela(value);
}
}
 /// <summary>
 /// CM类函数关系(CMClassFuncRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCMClassFuncRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CMClassFuncRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 7;
public static string[] _AttributeName = new string[] {"mId", "CmClassId", "CmFunctionId", "OrderNum", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrCmClassId;    //类Id
protected string mstrCmFunctionId;    //函数Id
protected int? mintOrderNum;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsCMClassFuncRelaEN()
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
public clsCMClassFuncRelaEN(long lngmId)
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
if (strAttributeName  ==  conCMClassFuncRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conCMClassFuncRela.CmClassId)
{
return mstrCmClassId;
}
else if (strAttributeName  ==  conCMClassFuncRela.CmFunctionId)
{
return mstrCmFunctionId;
}
else if (strAttributeName  ==  conCMClassFuncRela.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conCMClassFuncRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conCMClassFuncRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conCMClassFuncRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conCMClassFuncRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conCMClassFuncRela.mId);
}
else if (strAttributeName  ==  conCMClassFuncRela.CmClassId)
{
mstrCmClassId = value.ToString();
 AddUpdatedFld(conCMClassFuncRela.CmClassId);
}
else if (strAttributeName  ==  conCMClassFuncRela.CmFunctionId)
{
mstrCmFunctionId = value.ToString();
 AddUpdatedFld(conCMClassFuncRela.CmFunctionId);
}
else if (strAttributeName  ==  conCMClassFuncRela.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conCMClassFuncRela.OrderNum);
}
else if (strAttributeName  ==  conCMClassFuncRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCMClassFuncRela.UpdDate);
}
else if (strAttributeName  ==  conCMClassFuncRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conCMClassFuncRela.UpdUser);
}
else if (strAttributeName  ==  conCMClassFuncRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCMClassFuncRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conCMClassFuncRela.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (conCMClassFuncRela.CmClassId  ==  _AttributeName[intIndex])
{
return mstrCmClassId;
}
else if (conCMClassFuncRela.CmFunctionId  ==  _AttributeName[intIndex])
{
return mstrCmFunctionId;
}
else if (conCMClassFuncRela.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conCMClassFuncRela.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conCMClassFuncRela.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conCMClassFuncRela.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conCMClassFuncRela.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conCMClassFuncRela.mId);
}
else if (conCMClassFuncRela.CmClassId  ==  _AttributeName[intIndex])
{
mstrCmClassId = value.ToString();
 AddUpdatedFld(conCMClassFuncRela.CmClassId);
}
else if (conCMClassFuncRela.CmFunctionId  ==  _AttributeName[intIndex])
{
mstrCmFunctionId = value.ToString();
 AddUpdatedFld(conCMClassFuncRela.CmFunctionId);
}
else if (conCMClassFuncRela.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conCMClassFuncRela.OrderNum);
}
else if (conCMClassFuncRela.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCMClassFuncRela.UpdDate);
}
else if (conCMClassFuncRela.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conCMClassFuncRela.UpdUser);
}
else if (conCMClassFuncRela.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCMClassFuncRela.Memo);
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
 AddUpdatedFld(conCMClassFuncRela.mId);
}
}
/// <summary>
/// 类Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CmClassId
{
get
{
return mstrCmClassId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCmClassId = value;
}
else
{
 mstrCmClassId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCMClassFuncRela.CmClassId);
}
}
/// <summary>
/// 函数Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CmFunctionId
{
get
{
return mstrCmFunctionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCmFunctionId = value;
}
else
{
 mstrCmFunctionId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCMClassFuncRela.CmFunctionId);
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
 AddUpdatedFld(conCMClassFuncRela.OrderNum);
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
 AddUpdatedFld(conCMClassFuncRela.UpdDate);
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
 AddUpdatedFld(conCMClassFuncRela.UpdUser);
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
 AddUpdatedFld(conCMClassFuncRela.Memo);
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
 /// CM类函数关系(CMClassFuncRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCMClassFuncRela
{
public const string _CurrTabName = "CMClassFuncRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "CmClassId", "CmFunctionId", "OrderNum", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"CmClassId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CmClassId = "CmClassId";    //类Id

 /// <summary>
 /// 常量:"CmFunctionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CmFunctionId = "CmFunctionId";    //函数Id

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