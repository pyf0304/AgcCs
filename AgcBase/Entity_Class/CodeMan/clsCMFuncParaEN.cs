
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCMFuncParaEN
 表名:CMFuncPara(00050503)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:08:46
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
 /// 表CMFuncPara的关键字(CmFuncParaId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CmFuncParaId_CMFuncPara
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strCmFuncParaId">表关键字</param>
public K_CmFuncParaId_CMFuncPara(string strCmFuncParaId)
{
if (IsValid(strCmFuncParaId)) Value = strCmFuncParaId;
else
{
Value = null;
}
}
private static bool IsValid(string strCmFuncParaId)
{
if (string.IsNullOrEmpty(strCmFuncParaId) == true) return false;
if (strCmFuncParaId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_CmFuncParaId_CMFuncPara]类型的对象</returns>
public static implicit operator K_CmFuncParaId_CMFuncPara(string value)
{
return new K_CmFuncParaId_CMFuncPara(value);
}
}
 /// <summary>
 /// CM函数参数(CMFuncPara)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCMFuncParaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CMFuncPara"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "CmFuncParaId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 13;
public static string[] _AttributeName = new string[] {"CmFuncParaId", "ParaName", "ParaComments", "ParameterType", "DataTypeId", "ParameterTypeFullName", "IsByRef", "ParaCnName", "IsKnownType", "PrjId", "UpdDate", "UpdUser", "Memo"};

protected string mstrCmFuncParaId;    //函数参数Id
protected string mstrParaName;    //参数名
protected string mstrParaComments;    //参数注释
protected string mstrParameterType;    //参数类型
protected string mstrDataTypeId;    //数据类型Id
protected string mstrParameterTypeFullName;    //参数类型全名
protected bool mbolIsByRef;    //是否引用型参数
protected string mstrParaCnName;    //参数中文名
protected bool mbolIsKnownType;    //是否已知类型
protected string mstrPrjId;    //工程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsCMFuncParaEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CmFuncParaId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strCmFuncParaId">关键字:函数参数Id</param>
public clsCMFuncParaEN(string strCmFuncParaId)
 {
strCmFuncParaId = strCmFuncParaId.Replace("'", "''");
if (strCmFuncParaId.Length > 8)
{
throw new Exception("在表:CMFuncPara中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strCmFuncParaId)  ==  true)
{
throw new Exception("在表:CMFuncPara中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCmFuncParaId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrCmFuncParaId = strCmFuncParaId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CmFuncParaId");
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
if (strAttributeName  ==  conCMFuncPara.CmFuncParaId)
{
return mstrCmFuncParaId;
}
else if (strAttributeName  ==  conCMFuncPara.ParaName)
{
return mstrParaName;
}
else if (strAttributeName  ==  conCMFuncPara.ParaComments)
{
return mstrParaComments;
}
else if (strAttributeName  ==  conCMFuncPara.ParameterType)
{
return mstrParameterType;
}
else if (strAttributeName  ==  conCMFuncPara.DataTypeId)
{
return mstrDataTypeId;
}
else if (strAttributeName  ==  conCMFuncPara.ParameterTypeFullName)
{
return mstrParameterTypeFullName;
}
else if (strAttributeName  ==  conCMFuncPara.IsByRef)
{
return mbolIsByRef;
}
else if (strAttributeName  ==  conCMFuncPara.ParaCnName)
{
return mstrParaCnName;
}
else if (strAttributeName  ==  conCMFuncPara.IsKnownType)
{
return mbolIsKnownType;
}
else if (strAttributeName  ==  conCMFuncPara.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conCMFuncPara.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conCMFuncPara.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conCMFuncPara.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conCMFuncPara.CmFuncParaId)
{
mstrCmFuncParaId = value.ToString();
 AddUpdatedFld(conCMFuncPara.CmFuncParaId);
}
else if (strAttributeName  ==  conCMFuncPara.ParaName)
{
mstrParaName = value.ToString();
 AddUpdatedFld(conCMFuncPara.ParaName);
}
else if (strAttributeName  ==  conCMFuncPara.ParaComments)
{
mstrParaComments = value.ToString();
 AddUpdatedFld(conCMFuncPara.ParaComments);
}
else if (strAttributeName  ==  conCMFuncPara.ParameterType)
{
mstrParameterType = value.ToString();
 AddUpdatedFld(conCMFuncPara.ParameterType);
}
else if (strAttributeName  ==  conCMFuncPara.DataTypeId)
{
mstrDataTypeId = value.ToString();
 AddUpdatedFld(conCMFuncPara.DataTypeId);
}
else if (strAttributeName  ==  conCMFuncPara.ParameterTypeFullName)
{
mstrParameterTypeFullName = value.ToString();
 AddUpdatedFld(conCMFuncPara.ParameterTypeFullName);
}
else if (strAttributeName  ==  conCMFuncPara.IsByRef)
{
mbolIsByRef = TransNullToBool(value.ToString());
 AddUpdatedFld(conCMFuncPara.IsByRef);
}
else if (strAttributeName  ==  conCMFuncPara.ParaCnName)
{
mstrParaCnName = value.ToString();
 AddUpdatedFld(conCMFuncPara.ParaCnName);
}
else if (strAttributeName  ==  conCMFuncPara.IsKnownType)
{
mbolIsKnownType = TransNullToBool(value.ToString());
 AddUpdatedFld(conCMFuncPara.IsKnownType);
}
else if (strAttributeName  ==  conCMFuncPara.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conCMFuncPara.PrjId);
}
else if (strAttributeName  ==  conCMFuncPara.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCMFuncPara.UpdDate);
}
else if (strAttributeName  ==  conCMFuncPara.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conCMFuncPara.UpdUser);
}
else if (strAttributeName  ==  conCMFuncPara.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCMFuncPara.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conCMFuncPara.CmFuncParaId  ==  _AttributeName[intIndex])
{
return mstrCmFuncParaId;
}
else if (conCMFuncPara.ParaName  ==  _AttributeName[intIndex])
{
return mstrParaName;
}
else if (conCMFuncPara.ParaComments  ==  _AttributeName[intIndex])
{
return mstrParaComments;
}
else if (conCMFuncPara.ParameterType  ==  _AttributeName[intIndex])
{
return mstrParameterType;
}
else if (conCMFuncPara.DataTypeId  ==  _AttributeName[intIndex])
{
return mstrDataTypeId;
}
else if (conCMFuncPara.ParameterTypeFullName  ==  _AttributeName[intIndex])
{
return mstrParameterTypeFullName;
}
else if (conCMFuncPara.IsByRef  ==  _AttributeName[intIndex])
{
return mbolIsByRef;
}
else if (conCMFuncPara.ParaCnName  ==  _AttributeName[intIndex])
{
return mstrParaCnName;
}
else if (conCMFuncPara.IsKnownType  ==  _AttributeName[intIndex])
{
return mbolIsKnownType;
}
else if (conCMFuncPara.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conCMFuncPara.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conCMFuncPara.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conCMFuncPara.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conCMFuncPara.CmFuncParaId  ==  _AttributeName[intIndex])
{
mstrCmFuncParaId = value.ToString();
 AddUpdatedFld(conCMFuncPara.CmFuncParaId);
}
else if (conCMFuncPara.ParaName  ==  _AttributeName[intIndex])
{
mstrParaName = value.ToString();
 AddUpdatedFld(conCMFuncPara.ParaName);
}
else if (conCMFuncPara.ParaComments  ==  _AttributeName[intIndex])
{
mstrParaComments = value.ToString();
 AddUpdatedFld(conCMFuncPara.ParaComments);
}
else if (conCMFuncPara.ParameterType  ==  _AttributeName[intIndex])
{
mstrParameterType = value.ToString();
 AddUpdatedFld(conCMFuncPara.ParameterType);
}
else if (conCMFuncPara.DataTypeId  ==  _AttributeName[intIndex])
{
mstrDataTypeId = value.ToString();
 AddUpdatedFld(conCMFuncPara.DataTypeId);
}
else if (conCMFuncPara.ParameterTypeFullName  ==  _AttributeName[intIndex])
{
mstrParameterTypeFullName = value.ToString();
 AddUpdatedFld(conCMFuncPara.ParameterTypeFullName);
}
else if (conCMFuncPara.IsByRef  ==  _AttributeName[intIndex])
{
mbolIsByRef = TransNullToBool(value.ToString());
 AddUpdatedFld(conCMFuncPara.IsByRef);
}
else if (conCMFuncPara.ParaCnName  ==  _AttributeName[intIndex])
{
mstrParaCnName = value.ToString();
 AddUpdatedFld(conCMFuncPara.ParaCnName);
}
else if (conCMFuncPara.IsKnownType  ==  _AttributeName[intIndex])
{
mbolIsKnownType = TransNullToBool(value.ToString());
 AddUpdatedFld(conCMFuncPara.IsKnownType);
}
else if (conCMFuncPara.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conCMFuncPara.PrjId);
}
else if (conCMFuncPara.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCMFuncPara.UpdDate);
}
else if (conCMFuncPara.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conCMFuncPara.UpdUser);
}
else if (conCMFuncPara.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCMFuncPara.Memo);
}
}
}

/// <summary>
/// 函数参数Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CmFuncParaId
{
get
{
return mstrCmFuncParaId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCmFuncParaId = value;
}
else
{
 mstrCmFuncParaId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCMFuncPara.CmFuncParaId);
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
 AddUpdatedFld(conCMFuncPara.ParaName);
}
}
/// <summary>
/// 参数注释(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParaComments
{
get
{
return mstrParaComments;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParaComments = value;
}
else
{
 mstrParaComments = value;
}
//记录修改过的字段
 AddUpdatedFld(conCMFuncPara.ParaComments);
}
}
/// <summary>
/// 参数类型(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParameterType
{
get
{
return mstrParameterType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParameterType = value;
}
else
{
 mstrParameterType = value;
}
//记录修改过的字段
 AddUpdatedFld(conCMFuncPara.ParameterType);
}
}
/// <summary>
/// 数据类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataTypeId
{
get
{
return mstrDataTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataTypeId = value;
}
else
{
 mstrDataTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCMFuncPara.DataTypeId);
}
}
/// <summary>
/// 参数类型全名(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParameterTypeFullName
{
get
{
return mstrParameterTypeFullName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParameterTypeFullName = value;
}
else
{
 mstrParameterTypeFullName = value;
}
//记录修改过的字段
 AddUpdatedFld(conCMFuncPara.ParameterTypeFullName);
}
}
/// <summary>
/// 是否引用型参数(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsByRef
{
get
{
return mbolIsByRef;
}
set
{
 mbolIsByRef = value;
//记录修改过的字段
 AddUpdatedFld(conCMFuncPara.IsByRef);
}
}
/// <summary>
/// 参数中文名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParaCnName
{
get
{
return mstrParaCnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParaCnName = value;
}
else
{
 mstrParaCnName = value;
}
//记录修改过的字段
 AddUpdatedFld(conCMFuncPara.ParaCnName);
}
}
/// <summary>
/// 是否已知类型(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsKnownType
{
get
{
return mbolIsKnownType;
}
set
{
 mbolIsKnownType = value;
//记录修改过的字段
 AddUpdatedFld(conCMFuncPara.IsKnownType);
}
}
/// <summary>
/// 工程Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjId
{
get
{
return mstrPrjId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjId = value;
}
else
{
 mstrPrjId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCMFuncPara.PrjId);
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
 AddUpdatedFld(conCMFuncPara.UpdDate);
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
 AddUpdatedFld(conCMFuncPara.UpdUser);
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
 AddUpdatedFld(conCMFuncPara.Memo);
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
  return mstrCmFuncParaId;
 }
 }
}
 /// <summary>
 /// CM函数参数(CMFuncPara)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCMFuncPara
{
public const string _CurrTabName = "CMFuncPara"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CmFuncParaId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"CmFuncParaId", "ParaName", "ParaComments", "ParameterType", "DataTypeId", "ParameterTypeFullName", "IsByRef", "ParaCnName", "IsKnownType", "PrjId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"CmFuncParaId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CmFuncParaId = "CmFuncParaId";    //函数参数Id

 /// <summary>
 /// 常量:"ParaName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParaName = "ParaName";    //参数名

 /// <summary>
 /// 常量:"ParaComments"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParaComments = "ParaComments";    //参数注释

 /// <summary>
 /// 常量:"ParameterType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParameterType = "ParameterType";    //参数类型

 /// <summary>
 /// 常量:"DataTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataTypeId = "DataTypeId";    //数据类型Id

 /// <summary>
 /// 常量:"ParameterTypeFullName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParameterTypeFullName = "ParameterTypeFullName";    //参数类型全名

 /// <summary>
 /// 常量:"IsByRef"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsByRef = "IsByRef";    //是否引用型参数

 /// <summary>
 /// 常量:"ParaCnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParaCnName = "ParaCnName";    //参数中文名

 /// <summary>
 /// 常量:"IsKnownType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsKnownType = "IsKnownType";    //是否已知类型

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

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