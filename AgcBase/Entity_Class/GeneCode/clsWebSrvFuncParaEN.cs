
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsWebSrvFuncParaEN
 表名:WebSrvFuncPara(00050347)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:35:46
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
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
 /// 表WebSrvFuncPara的关键字(WebSrvFuncParaId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_WebSrvFuncParaId_WebSrvFuncPara
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strWebSrvFuncParaId">表关键字</param>
public K_WebSrvFuncParaId_WebSrvFuncPara(string strWebSrvFuncParaId)
{
if (IsValid(strWebSrvFuncParaId)) Value = strWebSrvFuncParaId;
else
{
Value = null;
}
}
private static bool IsValid(string strWebSrvFuncParaId)
{
if (string.IsNullOrEmpty(strWebSrvFuncParaId) == true) return false;
if (strWebSrvFuncParaId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_WebSrvFuncParaId_WebSrvFuncPara]类型的对象</returns>
public static implicit operator K_WebSrvFuncParaId_WebSrvFuncPara(string value)
{
return new K_WebSrvFuncParaId_WebSrvFuncPara(value);
}
}
 /// <summary>
 /// WebSrv函数参数(WebSrvFuncPara)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsWebSrvFuncParaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "WebSrvFuncPara"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "WebSrvFuncParaId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 12;
public static string[] _AttributeName = new string[] {"WebSrvFuncParaId", "WebSrvFunctionId", "DataTypeId", "ParameterType", "ParameterTypeFullName", "IsByRef", "ParaName", "ParaCnName", "IsKnownType", "UpdDate", "UpdUser", "Memo"};

protected string mstrWebSrvFuncParaId;    //函数参数Id
protected string mstrWebSrvFunctionId;    //函数Id
protected string mstrDataTypeId;    //数据类型Id
protected string mstrParameterType;    //参数类型
protected string mstrParameterTypeFullName;    //参数类型全名
protected bool mbolIsByRef;    //是否引用型参数
protected string mstrParaName;    //参数名
protected string mstrParaCnName;    //参数中文名
protected bool mbolIsKnownType;    //是否已知类型
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsWebSrvFuncParaEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("WebSrvFuncParaId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strWebSrvFuncParaId">关键字:函数参数Id</param>
public clsWebSrvFuncParaEN(string strWebSrvFuncParaId)
 {
strWebSrvFuncParaId = strWebSrvFuncParaId.Replace("'", "''");
if (strWebSrvFuncParaId.Length > 8)
{
throw new Exception("在表:WebSrvFuncPara中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strWebSrvFuncParaId)  ==  true)
{
throw new Exception("在表:WebSrvFuncPara中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strWebSrvFuncParaId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrWebSrvFuncParaId = strWebSrvFuncParaId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("WebSrvFuncParaId");
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
if (strAttributeName  ==  conWebSrvFuncPara.WebSrvFuncParaId)
{
return mstrWebSrvFuncParaId;
}
else if (strAttributeName  ==  conWebSrvFuncPara.WebSrvFunctionId)
{
return mstrWebSrvFunctionId;
}
else if (strAttributeName  ==  conWebSrvFuncPara.DataTypeId)
{
return mstrDataTypeId;
}
else if (strAttributeName  ==  conWebSrvFuncPara.ParameterType)
{
return mstrParameterType;
}
else if (strAttributeName  ==  conWebSrvFuncPara.ParameterTypeFullName)
{
return mstrParameterTypeFullName;
}
else if (strAttributeName  ==  conWebSrvFuncPara.IsByRef)
{
return mbolIsByRef;
}
else if (strAttributeName  ==  conWebSrvFuncPara.ParaName)
{
return mstrParaName;
}
else if (strAttributeName  ==  conWebSrvFuncPara.ParaCnName)
{
return mstrParaCnName;
}
else if (strAttributeName  ==  conWebSrvFuncPara.IsKnownType)
{
return mbolIsKnownType;
}
else if (strAttributeName  ==  conWebSrvFuncPara.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conWebSrvFuncPara.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conWebSrvFuncPara.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conWebSrvFuncPara.WebSrvFuncParaId)
{
mstrWebSrvFuncParaId = value.ToString();
 AddUpdatedFld(conWebSrvFuncPara.WebSrvFuncParaId);
}
else if (strAttributeName  ==  conWebSrvFuncPara.WebSrvFunctionId)
{
mstrWebSrvFunctionId = value.ToString();
 AddUpdatedFld(conWebSrvFuncPara.WebSrvFunctionId);
}
else if (strAttributeName  ==  conWebSrvFuncPara.DataTypeId)
{
mstrDataTypeId = value.ToString();
 AddUpdatedFld(conWebSrvFuncPara.DataTypeId);
}
else if (strAttributeName  ==  conWebSrvFuncPara.ParameterType)
{
mstrParameterType = value.ToString();
 AddUpdatedFld(conWebSrvFuncPara.ParameterType);
}
else if (strAttributeName  ==  conWebSrvFuncPara.ParameterTypeFullName)
{
mstrParameterTypeFullName = value.ToString();
 AddUpdatedFld(conWebSrvFuncPara.ParameterTypeFullName);
}
else if (strAttributeName  ==  conWebSrvFuncPara.IsByRef)
{
mbolIsByRef = TransNullToBool(value.ToString());
 AddUpdatedFld(conWebSrvFuncPara.IsByRef);
}
else if (strAttributeName  ==  conWebSrvFuncPara.ParaName)
{
mstrParaName = value.ToString();
 AddUpdatedFld(conWebSrvFuncPara.ParaName);
}
else if (strAttributeName  ==  conWebSrvFuncPara.ParaCnName)
{
mstrParaCnName = value.ToString();
 AddUpdatedFld(conWebSrvFuncPara.ParaCnName);
}
else if (strAttributeName  ==  conWebSrvFuncPara.IsKnownType)
{
mbolIsKnownType = TransNullToBool(value.ToString());
 AddUpdatedFld(conWebSrvFuncPara.IsKnownType);
}
else if (strAttributeName  ==  conWebSrvFuncPara.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conWebSrvFuncPara.UpdDate);
}
else if (strAttributeName  ==  conWebSrvFuncPara.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conWebSrvFuncPara.UpdUser);
}
else if (strAttributeName  ==  conWebSrvFuncPara.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conWebSrvFuncPara.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conWebSrvFuncPara.WebSrvFuncParaId  ==  _AttributeName[intIndex])
{
return mstrWebSrvFuncParaId;
}
else if (conWebSrvFuncPara.WebSrvFunctionId  ==  _AttributeName[intIndex])
{
return mstrWebSrvFunctionId;
}
else if (conWebSrvFuncPara.DataTypeId  ==  _AttributeName[intIndex])
{
return mstrDataTypeId;
}
else if (conWebSrvFuncPara.ParameterType  ==  _AttributeName[intIndex])
{
return mstrParameterType;
}
else if (conWebSrvFuncPara.ParameterTypeFullName  ==  _AttributeName[intIndex])
{
return mstrParameterTypeFullName;
}
else if (conWebSrvFuncPara.IsByRef  ==  _AttributeName[intIndex])
{
return mbolIsByRef;
}
else if (conWebSrvFuncPara.ParaName  ==  _AttributeName[intIndex])
{
return mstrParaName;
}
else if (conWebSrvFuncPara.ParaCnName  ==  _AttributeName[intIndex])
{
return mstrParaCnName;
}
else if (conWebSrvFuncPara.IsKnownType  ==  _AttributeName[intIndex])
{
return mbolIsKnownType;
}
else if (conWebSrvFuncPara.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conWebSrvFuncPara.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conWebSrvFuncPara.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conWebSrvFuncPara.WebSrvFuncParaId  ==  _AttributeName[intIndex])
{
mstrWebSrvFuncParaId = value.ToString();
 AddUpdatedFld(conWebSrvFuncPara.WebSrvFuncParaId);
}
else if (conWebSrvFuncPara.WebSrvFunctionId  ==  _AttributeName[intIndex])
{
mstrWebSrvFunctionId = value.ToString();
 AddUpdatedFld(conWebSrvFuncPara.WebSrvFunctionId);
}
else if (conWebSrvFuncPara.DataTypeId  ==  _AttributeName[intIndex])
{
mstrDataTypeId = value.ToString();
 AddUpdatedFld(conWebSrvFuncPara.DataTypeId);
}
else if (conWebSrvFuncPara.ParameterType  ==  _AttributeName[intIndex])
{
mstrParameterType = value.ToString();
 AddUpdatedFld(conWebSrvFuncPara.ParameterType);
}
else if (conWebSrvFuncPara.ParameterTypeFullName  ==  _AttributeName[intIndex])
{
mstrParameterTypeFullName = value.ToString();
 AddUpdatedFld(conWebSrvFuncPara.ParameterTypeFullName);
}
else if (conWebSrvFuncPara.IsByRef  ==  _AttributeName[intIndex])
{
mbolIsByRef = TransNullToBool(value.ToString());
 AddUpdatedFld(conWebSrvFuncPara.IsByRef);
}
else if (conWebSrvFuncPara.ParaName  ==  _AttributeName[intIndex])
{
mstrParaName = value.ToString();
 AddUpdatedFld(conWebSrvFuncPara.ParaName);
}
else if (conWebSrvFuncPara.ParaCnName  ==  _AttributeName[intIndex])
{
mstrParaCnName = value.ToString();
 AddUpdatedFld(conWebSrvFuncPara.ParaCnName);
}
else if (conWebSrvFuncPara.IsKnownType  ==  _AttributeName[intIndex])
{
mbolIsKnownType = TransNullToBool(value.ToString());
 AddUpdatedFld(conWebSrvFuncPara.IsKnownType);
}
else if (conWebSrvFuncPara.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conWebSrvFuncPara.UpdDate);
}
else if (conWebSrvFuncPara.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conWebSrvFuncPara.UpdUser);
}
else if (conWebSrvFuncPara.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conWebSrvFuncPara.Memo);
}
}
}

/// <summary>
/// 函数参数Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WebSrvFuncParaId
{
get
{
return mstrWebSrvFuncParaId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWebSrvFuncParaId = value;
}
else
{
 mstrWebSrvFuncParaId = value;
}
//记录修改过的字段
 AddUpdatedFld(conWebSrvFuncPara.WebSrvFuncParaId);
}
}
/// <summary>
/// 函数Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WebSrvFunctionId
{
get
{
return mstrWebSrvFunctionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWebSrvFunctionId = value;
}
else
{
 mstrWebSrvFunctionId = value;
}
//记录修改过的字段
 AddUpdatedFld(conWebSrvFuncPara.WebSrvFunctionId);
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
 AddUpdatedFld(conWebSrvFuncPara.DataTypeId);
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
 AddUpdatedFld(conWebSrvFuncPara.ParameterType);
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
 AddUpdatedFld(conWebSrvFuncPara.ParameterTypeFullName);
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
 AddUpdatedFld(conWebSrvFuncPara.IsByRef);
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
 AddUpdatedFld(conWebSrvFuncPara.ParaName);
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
 AddUpdatedFld(conWebSrvFuncPara.ParaCnName);
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
 AddUpdatedFld(conWebSrvFuncPara.IsKnownType);
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
 AddUpdatedFld(conWebSrvFuncPara.UpdDate);
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
 AddUpdatedFld(conWebSrvFuncPara.UpdUser);
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
 AddUpdatedFld(conWebSrvFuncPara.Memo);
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
  return mstrWebSrvFuncParaId;
 }
 }
}
 /// <summary>
 /// WebSrv函数参数(WebSrvFuncPara)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conWebSrvFuncPara
{
public const string _CurrTabName = "WebSrvFuncPara"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "WebSrvFuncParaId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"WebSrvFuncParaId", "WebSrvFunctionId", "DataTypeId", "ParameterType", "ParameterTypeFullName", "IsByRef", "ParaName", "ParaCnName", "IsKnownType", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"WebSrvFuncParaId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WebSrvFuncParaId = "WebSrvFuncParaId";    //函数参数Id

 /// <summary>
 /// 常量:"WebSrvFunctionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WebSrvFunctionId = "WebSrvFunctionId";    //函数Id

 /// <summary>
 /// 常量:"DataTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataTypeId = "DataTypeId";    //数据类型Id

 /// <summary>
 /// 常量:"ParameterType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParameterType = "ParameterType";    //参数类型

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
 /// 常量:"ParaName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParaName = "ParaName";    //参数名

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