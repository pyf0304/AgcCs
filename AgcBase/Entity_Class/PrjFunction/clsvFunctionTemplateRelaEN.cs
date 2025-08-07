
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFunctionTemplateRelaEN
 表名:vFunctionTemplateRela(00050317)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:45:43
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
 /// 表vFunctionTemplateRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vFunctionTemplateRela
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
public K_mId_vFunctionTemplateRela(long lngmId)
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
 /// <returns>返回:[K_mId_vFunctionTemplateRela]类型的对象</returns>
public static implicit operator K_mId_vFunctionTemplateRela(long value)
{
return new K_mId_vFunctionTemplateRela(value);
}
}
 /// <summary>
 /// v函数与模板关系(vFunctionTemplateRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvFunctionTemplateRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vFunctionTemplateRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 30;
public static string[] _AttributeName = new string[] {"mId", "FunctionTemplateId", "FunctionTemplateName", "CreateUserId", "CodeTypeId", "CodeTypeName", "CodeTypeENName", "RegionTypeId", "RegionTypeName", "FuncId4GC", "FuncName", "FuncId4Code", "FuncName4Code", "FuncCHName4Code", "ProgLangTypeId", "ProgLangTypeName", "SqlDsTypeId", "SqlDsTypeName", "ReturnTypeId", "FuncTypeId", "FuncTypeName", "IsTemplate", "FunctionSignature", "ReturnTypeName", "IsGeneCode", "OrderNum", "UpdDate", "UpdUser", "Memo", "Order4FuncNum"};

protected long mlngmId;    //mId
protected string mstrFunctionTemplateId;    //函数模板Id
protected string mstrFunctionTemplateName;    //函数模板名
protected string mstrCreateUserId;    //建立用户Id
protected string mstrCodeTypeId;    //代码类型Id
protected string mstrCodeTypeName;    //代码类型名
protected string mstrCodeTypeENName;    //代码类型英文名
protected string mstrRegionTypeId;    //区域类型Id
protected string mstrRegionTypeName;    //区域类型名称
protected string mstrFuncId4GC;    //函数ID
protected string mstrFuncName;    //函数名
protected string mstrFuncId4Code;    //函数Id4Code
protected string mstrFuncName4Code;    //函数名4Code
protected string mstrFuncCHName4Code;    //函数中文名4Code
protected string mstrProgLangTypeId;    //编程语言类型Id
protected string mstrProgLangTypeName;    //编程语言类型名
protected string mstrSqlDsTypeId;    //数据源类型Id
protected string mstrSqlDsTypeName;    //Sql数据源名
protected string mstrReturnTypeId;    //返回类型ID
protected string mstrFuncTypeId;    //函数类型Id
protected string mstrFuncTypeName;    //函数类型名
protected bool mbolIsTemplate;    //是否模板
protected string mstrFunctionSignature;    //函数签名
protected string mstrReturnTypeName;    //返回类型名
protected bool mbolIsGeneCode;    //是否生成代码
protected int mintOrderNum;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明
protected int? mintOrder4FuncNum;    //Order4FuncNum

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvFunctionTemplateRelaEN()
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
public clsvFunctionTemplateRelaEN(long lngmId)
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
if (strAttributeName  ==  convFunctionTemplateRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convFunctionTemplateRela.FunctionTemplateId)
{
return mstrFunctionTemplateId;
}
else if (strAttributeName  ==  convFunctionTemplateRela.FunctionTemplateName)
{
return mstrFunctionTemplateName;
}
else if (strAttributeName  ==  convFunctionTemplateRela.CreateUserId)
{
return mstrCreateUserId;
}
else if (strAttributeName  ==  convFunctionTemplateRela.CodeTypeId)
{
return mstrCodeTypeId;
}
else if (strAttributeName  ==  convFunctionTemplateRela.CodeTypeName)
{
return mstrCodeTypeName;
}
else if (strAttributeName  ==  convFunctionTemplateRela.CodeTypeENName)
{
return mstrCodeTypeENName;
}
else if (strAttributeName  ==  convFunctionTemplateRela.RegionTypeId)
{
return mstrRegionTypeId;
}
else if (strAttributeName  ==  convFunctionTemplateRela.RegionTypeName)
{
return mstrRegionTypeName;
}
else if (strAttributeName  ==  convFunctionTemplateRela.FuncId4GC)
{
return mstrFuncId4GC;
}
else if (strAttributeName  ==  convFunctionTemplateRela.FuncName)
{
return mstrFuncName;
}
else if (strAttributeName  ==  convFunctionTemplateRela.FuncId4Code)
{
return mstrFuncId4Code;
}
else if (strAttributeName  ==  convFunctionTemplateRela.FuncName4Code)
{
return mstrFuncName4Code;
}
else if (strAttributeName  ==  convFunctionTemplateRela.FuncCHName4Code)
{
return mstrFuncCHName4Code;
}
else if (strAttributeName  ==  convFunctionTemplateRela.ProgLangTypeId)
{
return mstrProgLangTypeId;
}
else if (strAttributeName  ==  convFunctionTemplateRela.ProgLangTypeName)
{
return mstrProgLangTypeName;
}
else if (strAttributeName  ==  convFunctionTemplateRela.SqlDsTypeId)
{
return mstrSqlDsTypeId;
}
else if (strAttributeName  ==  convFunctionTemplateRela.SqlDsTypeName)
{
return mstrSqlDsTypeName;
}
else if (strAttributeName  ==  convFunctionTemplateRela.ReturnTypeId)
{
return mstrReturnTypeId;
}
else if (strAttributeName  ==  convFunctionTemplateRela.FuncTypeId)
{
return mstrFuncTypeId;
}
else if (strAttributeName  ==  convFunctionTemplateRela.FuncTypeName)
{
return mstrFuncTypeName;
}
else if (strAttributeName  ==  convFunctionTemplateRela.IsTemplate)
{
return mbolIsTemplate;
}
else if (strAttributeName  ==  convFunctionTemplateRela.FunctionSignature)
{
return mstrFunctionSignature;
}
else if (strAttributeName  ==  convFunctionTemplateRela.ReturnTypeName)
{
return mstrReturnTypeName;
}
else if (strAttributeName  ==  convFunctionTemplateRela.IsGeneCode)
{
return mbolIsGeneCode;
}
else if (strAttributeName  ==  convFunctionTemplateRela.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convFunctionTemplateRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convFunctionTemplateRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convFunctionTemplateRela.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convFunctionTemplateRela.Order4FuncNum)
{
return mintOrder4FuncNum;
}
return null;
}
set
{
if (strAttributeName  ==  convFunctionTemplateRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convFunctionTemplateRela.mId);
}
else if (strAttributeName  ==  convFunctionTemplateRela.FunctionTemplateId)
{
mstrFunctionTemplateId = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela.FunctionTemplateId);
}
else if (strAttributeName  ==  convFunctionTemplateRela.FunctionTemplateName)
{
mstrFunctionTemplateName = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela.FunctionTemplateName);
}
else if (strAttributeName  ==  convFunctionTemplateRela.CreateUserId)
{
mstrCreateUserId = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela.CreateUserId);
}
else if (strAttributeName  ==  convFunctionTemplateRela.CodeTypeId)
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela.CodeTypeId);
}
else if (strAttributeName  ==  convFunctionTemplateRela.CodeTypeName)
{
mstrCodeTypeName = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela.CodeTypeName);
}
else if (strAttributeName  ==  convFunctionTemplateRela.CodeTypeENName)
{
mstrCodeTypeENName = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela.CodeTypeENName);
}
else if (strAttributeName  ==  convFunctionTemplateRela.RegionTypeId)
{
mstrRegionTypeId = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela.RegionTypeId);
}
else if (strAttributeName  ==  convFunctionTemplateRela.RegionTypeName)
{
mstrRegionTypeName = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela.RegionTypeName);
}
else if (strAttributeName  ==  convFunctionTemplateRela.FuncId4GC)
{
mstrFuncId4GC = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela.FuncId4GC);
}
else if (strAttributeName  ==  convFunctionTemplateRela.FuncName)
{
mstrFuncName = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela.FuncName);
}
else if (strAttributeName  ==  convFunctionTemplateRela.FuncId4Code)
{
mstrFuncId4Code = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela.FuncId4Code);
}
else if (strAttributeName  ==  convFunctionTemplateRela.FuncName4Code)
{
mstrFuncName4Code = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela.FuncName4Code);
}
else if (strAttributeName  ==  convFunctionTemplateRela.FuncCHName4Code)
{
mstrFuncCHName4Code = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela.FuncCHName4Code);
}
else if (strAttributeName  ==  convFunctionTemplateRela.ProgLangTypeId)
{
mstrProgLangTypeId = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela.ProgLangTypeId);
}
else if (strAttributeName  ==  convFunctionTemplateRela.ProgLangTypeName)
{
mstrProgLangTypeName = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela.ProgLangTypeName);
}
else if (strAttributeName  ==  convFunctionTemplateRela.SqlDsTypeId)
{
mstrSqlDsTypeId = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela.SqlDsTypeId);
}
else if (strAttributeName  ==  convFunctionTemplateRela.SqlDsTypeName)
{
mstrSqlDsTypeName = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela.SqlDsTypeName);
}
else if (strAttributeName  ==  convFunctionTemplateRela.ReturnTypeId)
{
mstrReturnTypeId = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela.ReturnTypeId);
}
else if (strAttributeName  ==  convFunctionTemplateRela.FuncTypeId)
{
mstrFuncTypeId = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela.FuncTypeId);
}
else if (strAttributeName  ==  convFunctionTemplateRela.FuncTypeName)
{
mstrFuncTypeName = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela.FuncTypeName);
}
else if (strAttributeName  ==  convFunctionTemplateRela.IsTemplate)
{
mbolIsTemplate = TransNullToBool(value.ToString());
 AddUpdatedFld(convFunctionTemplateRela.IsTemplate);
}
else if (strAttributeName  ==  convFunctionTemplateRela.FunctionSignature)
{
mstrFunctionSignature = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela.FunctionSignature);
}
else if (strAttributeName  ==  convFunctionTemplateRela.ReturnTypeName)
{
mstrReturnTypeName = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela.ReturnTypeName);
}
else if (strAttributeName  ==  convFunctionTemplateRela.IsGeneCode)
{
mbolIsGeneCode = TransNullToBool(value.ToString());
 AddUpdatedFld(convFunctionTemplateRela.IsGeneCode);
}
else if (strAttributeName  ==  convFunctionTemplateRela.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFunctionTemplateRela.OrderNum);
}
else if (strAttributeName  ==  convFunctionTemplateRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela.UpdDate);
}
else if (strAttributeName  ==  convFunctionTemplateRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela.UpdUser);
}
else if (strAttributeName  ==  convFunctionTemplateRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela.Memo);
}
else if (strAttributeName  ==  convFunctionTemplateRela.Order4FuncNum)
{
mintOrder4FuncNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFunctionTemplateRela.Order4FuncNum);
}
}
}
public object this[int intIndex]
{
get
{
if (convFunctionTemplateRela.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (convFunctionTemplateRela.FunctionTemplateId  ==  _AttributeName[intIndex])
{
return mstrFunctionTemplateId;
}
else if (convFunctionTemplateRela.FunctionTemplateName  ==  _AttributeName[intIndex])
{
return mstrFunctionTemplateName;
}
else if (convFunctionTemplateRela.CreateUserId  ==  _AttributeName[intIndex])
{
return mstrCreateUserId;
}
else if (convFunctionTemplateRela.CodeTypeId  ==  _AttributeName[intIndex])
{
return mstrCodeTypeId;
}
else if (convFunctionTemplateRela.CodeTypeName  ==  _AttributeName[intIndex])
{
return mstrCodeTypeName;
}
else if (convFunctionTemplateRela.CodeTypeENName  ==  _AttributeName[intIndex])
{
return mstrCodeTypeENName;
}
else if (convFunctionTemplateRela.RegionTypeId  ==  _AttributeName[intIndex])
{
return mstrRegionTypeId;
}
else if (convFunctionTemplateRela.RegionTypeName  ==  _AttributeName[intIndex])
{
return mstrRegionTypeName;
}
else if (convFunctionTemplateRela.FuncId4GC  ==  _AttributeName[intIndex])
{
return mstrFuncId4GC;
}
else if (convFunctionTemplateRela.FuncName  ==  _AttributeName[intIndex])
{
return mstrFuncName;
}
else if (convFunctionTemplateRela.FuncId4Code  ==  _AttributeName[intIndex])
{
return mstrFuncId4Code;
}
else if (convFunctionTemplateRela.FuncName4Code  ==  _AttributeName[intIndex])
{
return mstrFuncName4Code;
}
else if (convFunctionTemplateRela.FuncCHName4Code  ==  _AttributeName[intIndex])
{
return mstrFuncCHName4Code;
}
else if (convFunctionTemplateRela.ProgLangTypeId  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeId;
}
else if (convFunctionTemplateRela.ProgLangTypeName  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeName;
}
else if (convFunctionTemplateRela.SqlDsTypeId  ==  _AttributeName[intIndex])
{
return mstrSqlDsTypeId;
}
else if (convFunctionTemplateRela.SqlDsTypeName  ==  _AttributeName[intIndex])
{
return mstrSqlDsTypeName;
}
else if (convFunctionTemplateRela.ReturnTypeId  ==  _AttributeName[intIndex])
{
return mstrReturnTypeId;
}
else if (convFunctionTemplateRela.FuncTypeId  ==  _AttributeName[intIndex])
{
return mstrFuncTypeId;
}
else if (convFunctionTemplateRela.FuncTypeName  ==  _AttributeName[intIndex])
{
return mstrFuncTypeName;
}
else if (convFunctionTemplateRela.IsTemplate  ==  _AttributeName[intIndex])
{
return mbolIsTemplate;
}
else if (convFunctionTemplateRela.FunctionSignature  ==  _AttributeName[intIndex])
{
return mstrFunctionSignature;
}
else if (convFunctionTemplateRela.ReturnTypeName  ==  _AttributeName[intIndex])
{
return mstrReturnTypeName;
}
else if (convFunctionTemplateRela.IsGeneCode  ==  _AttributeName[intIndex])
{
return mbolIsGeneCode;
}
else if (convFunctionTemplateRela.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convFunctionTemplateRela.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convFunctionTemplateRela.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convFunctionTemplateRela.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (convFunctionTemplateRela.Order4FuncNum  ==  _AttributeName[intIndex])
{
return mintOrder4FuncNum;
}
return null;
}
set
{
if (convFunctionTemplateRela.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convFunctionTemplateRela.mId);
}
else if (convFunctionTemplateRela.FunctionTemplateId  ==  _AttributeName[intIndex])
{
mstrFunctionTemplateId = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela.FunctionTemplateId);
}
else if (convFunctionTemplateRela.FunctionTemplateName  ==  _AttributeName[intIndex])
{
mstrFunctionTemplateName = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela.FunctionTemplateName);
}
else if (convFunctionTemplateRela.CreateUserId  ==  _AttributeName[intIndex])
{
mstrCreateUserId = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela.CreateUserId);
}
else if (convFunctionTemplateRela.CodeTypeId  ==  _AttributeName[intIndex])
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela.CodeTypeId);
}
else if (convFunctionTemplateRela.CodeTypeName  ==  _AttributeName[intIndex])
{
mstrCodeTypeName = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela.CodeTypeName);
}
else if (convFunctionTemplateRela.CodeTypeENName  ==  _AttributeName[intIndex])
{
mstrCodeTypeENName = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela.CodeTypeENName);
}
else if (convFunctionTemplateRela.RegionTypeId  ==  _AttributeName[intIndex])
{
mstrRegionTypeId = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela.RegionTypeId);
}
else if (convFunctionTemplateRela.RegionTypeName  ==  _AttributeName[intIndex])
{
mstrRegionTypeName = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela.RegionTypeName);
}
else if (convFunctionTemplateRela.FuncId4GC  ==  _AttributeName[intIndex])
{
mstrFuncId4GC = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela.FuncId4GC);
}
else if (convFunctionTemplateRela.FuncName  ==  _AttributeName[intIndex])
{
mstrFuncName = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela.FuncName);
}
else if (convFunctionTemplateRela.FuncId4Code  ==  _AttributeName[intIndex])
{
mstrFuncId4Code = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela.FuncId4Code);
}
else if (convFunctionTemplateRela.FuncName4Code  ==  _AttributeName[intIndex])
{
mstrFuncName4Code = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela.FuncName4Code);
}
else if (convFunctionTemplateRela.FuncCHName4Code  ==  _AttributeName[intIndex])
{
mstrFuncCHName4Code = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela.FuncCHName4Code);
}
else if (convFunctionTemplateRela.ProgLangTypeId  ==  _AttributeName[intIndex])
{
mstrProgLangTypeId = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela.ProgLangTypeId);
}
else if (convFunctionTemplateRela.ProgLangTypeName  ==  _AttributeName[intIndex])
{
mstrProgLangTypeName = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela.ProgLangTypeName);
}
else if (convFunctionTemplateRela.SqlDsTypeId  ==  _AttributeName[intIndex])
{
mstrSqlDsTypeId = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela.SqlDsTypeId);
}
else if (convFunctionTemplateRela.SqlDsTypeName  ==  _AttributeName[intIndex])
{
mstrSqlDsTypeName = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela.SqlDsTypeName);
}
else if (convFunctionTemplateRela.ReturnTypeId  ==  _AttributeName[intIndex])
{
mstrReturnTypeId = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela.ReturnTypeId);
}
else if (convFunctionTemplateRela.FuncTypeId  ==  _AttributeName[intIndex])
{
mstrFuncTypeId = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela.FuncTypeId);
}
else if (convFunctionTemplateRela.FuncTypeName  ==  _AttributeName[intIndex])
{
mstrFuncTypeName = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela.FuncTypeName);
}
else if (convFunctionTemplateRela.IsTemplate  ==  _AttributeName[intIndex])
{
mbolIsTemplate = TransNullToBool(value.ToString());
 AddUpdatedFld(convFunctionTemplateRela.IsTemplate);
}
else if (convFunctionTemplateRela.FunctionSignature  ==  _AttributeName[intIndex])
{
mstrFunctionSignature = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela.FunctionSignature);
}
else if (convFunctionTemplateRela.ReturnTypeName  ==  _AttributeName[intIndex])
{
mstrReturnTypeName = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela.ReturnTypeName);
}
else if (convFunctionTemplateRela.IsGeneCode  ==  _AttributeName[intIndex])
{
mbolIsGeneCode = TransNullToBool(value.ToString());
 AddUpdatedFld(convFunctionTemplateRela.IsGeneCode);
}
else if (convFunctionTemplateRela.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFunctionTemplateRela.OrderNum);
}
else if (convFunctionTemplateRela.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela.UpdDate);
}
else if (convFunctionTemplateRela.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela.UpdUser);
}
else if (convFunctionTemplateRela.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFunctionTemplateRela.Memo);
}
else if (convFunctionTemplateRela.Order4FuncNum  ==  _AttributeName[intIndex])
{
mintOrder4FuncNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFunctionTemplateRela.Order4FuncNum);
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
 AddUpdatedFld(convFunctionTemplateRela.mId);
}
}
/// <summary>
/// 函数模板Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FunctionTemplateId
{
get
{
return mstrFunctionTemplateId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFunctionTemplateId = value;
}
else
{
 mstrFunctionTemplateId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunctionTemplateRela.FunctionTemplateId);
}
}
/// <summary>
/// 函数模板名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FunctionTemplateName
{
get
{
return mstrFunctionTemplateName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFunctionTemplateName = value;
}
else
{
 mstrFunctionTemplateName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunctionTemplateRela.FunctionTemplateName);
}
}
/// <summary>
/// 建立用户Id(说明:;字段类型:varchar;字段长度:18;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CreateUserId
{
get
{
return mstrCreateUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCreateUserId = value;
}
else
{
 mstrCreateUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunctionTemplateRela.CreateUserId);
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
 AddUpdatedFld(convFunctionTemplateRela.CodeTypeId);
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
 AddUpdatedFld(convFunctionTemplateRela.CodeTypeName);
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
 AddUpdatedFld(convFunctionTemplateRela.CodeTypeENName);
}
}
/// <summary>
/// 区域类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RegionTypeId
{
get
{
return mstrRegionTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRegionTypeId = value;
}
else
{
 mstrRegionTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunctionTemplateRela.RegionTypeId);
}
}
/// <summary>
/// 区域类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RegionTypeName
{
get
{
return mstrRegionTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRegionTypeName = value;
}
else
{
 mstrRegionTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunctionTemplateRela.RegionTypeName);
}
}
/// <summary>
/// 函数ID(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncId4GC
{
get
{
return mstrFuncId4GC;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncId4GC = value;
}
else
{
 mstrFuncId4GC = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunctionTemplateRela.FuncId4GC);
}
}
/// <summary>
/// 函数名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncName
{
get
{
return mstrFuncName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncName = value;
}
else
{
 mstrFuncName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunctionTemplateRela.FuncName);
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
 AddUpdatedFld(convFunctionTemplateRela.FuncId4Code);
}
}
/// <summary>
/// 函数名4Code(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncName4Code
{
get
{
return mstrFuncName4Code;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncName4Code = value;
}
else
{
 mstrFuncName4Code = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunctionTemplateRela.FuncName4Code);
}
}
/// <summary>
/// 函数中文名4Code(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncCHName4Code
{
get
{
return mstrFuncCHName4Code;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncCHName4Code = value;
}
else
{
 mstrFuncCHName4Code = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunctionTemplateRela.FuncCHName4Code);
}
}
/// <summary>
/// 编程语言类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLangTypeId
{
get
{
return mstrProgLangTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLangTypeId = value;
}
else
{
 mstrProgLangTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunctionTemplateRela.ProgLangTypeId);
}
}
/// <summary>
/// 编程语言类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLangTypeName
{
get
{
return mstrProgLangTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLangTypeName = value;
}
else
{
 mstrProgLangTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunctionTemplateRela.ProgLangTypeName);
}
}
/// <summary>
/// 数据源类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SqlDsTypeId
{
get
{
return mstrSqlDsTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSqlDsTypeId = value;
}
else
{
 mstrSqlDsTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunctionTemplateRela.SqlDsTypeId);
}
}
/// <summary>
/// Sql数据源名(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SqlDsTypeName
{
get
{
return mstrSqlDsTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSqlDsTypeName = value;
}
else
{
 mstrSqlDsTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunctionTemplateRela.SqlDsTypeName);
}
}
/// <summary>
/// 返回类型ID(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ReturnTypeId
{
get
{
return mstrReturnTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrReturnTypeId = value;
}
else
{
 mstrReturnTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunctionTemplateRela.ReturnTypeId);
}
}
/// <summary>
/// 函数类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncTypeId
{
get
{
return mstrFuncTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncTypeId = value;
}
else
{
 mstrFuncTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunctionTemplateRela.FuncTypeId);
}
}
/// <summary>
/// 函数类型名(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncTypeName
{
get
{
return mstrFuncTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncTypeName = value;
}
else
{
 mstrFuncTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunctionTemplateRela.FuncTypeName);
}
}
/// <summary>
/// 是否模板(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsTemplate
{
get
{
return mbolIsTemplate;
}
set
{
 mbolIsTemplate = value;
//记录修改过的字段
 AddUpdatedFld(convFunctionTemplateRela.IsTemplate);
}
}
/// <summary>
/// 函数签名(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FunctionSignature
{
get
{
return mstrFunctionSignature;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFunctionSignature = value;
}
else
{
 mstrFunctionSignature = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunctionTemplateRela.FunctionSignature);
}
}
/// <summary>
/// 返回类型名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ReturnTypeName
{
get
{
return mstrReturnTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrReturnTypeName = value;
}
else
{
 mstrReturnTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunctionTemplateRela.ReturnTypeName);
}
}
/// <summary>
/// 是否生成代码(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsGeneCode
{
get
{
return mbolIsGeneCode;
}
set
{
 mbolIsGeneCode = value;
//记录修改过的字段
 AddUpdatedFld(convFunctionTemplateRela.IsGeneCode);
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
 AddUpdatedFld(convFunctionTemplateRela.OrderNum);
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
 AddUpdatedFld(convFunctionTemplateRela.UpdDate);
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
 AddUpdatedFld(convFunctionTemplateRela.UpdUser);
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
 AddUpdatedFld(convFunctionTemplateRela.Memo);
}
}
/// <summary>
/// Order4FuncNum(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? Order4FuncNum
{
get
{
return mintOrder4FuncNum;
}
set
{
 mintOrder4FuncNum = value;
//记录修改过的字段
 AddUpdatedFld(convFunctionTemplateRela.Order4FuncNum);
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
 /// v函数与模板关系(vFunctionTemplateRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convFunctionTemplateRela
{
public const string _CurrTabName = "vFunctionTemplateRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "FunctionTemplateId", "FunctionTemplateName", "CreateUserId", "CodeTypeId", "CodeTypeName", "CodeTypeENName", "RegionTypeId", "RegionTypeName", "FuncId4GC", "FuncName", "FuncId4Code", "FuncName4Code", "FuncCHName4Code", "ProgLangTypeId", "ProgLangTypeName", "SqlDsTypeId", "SqlDsTypeName", "ReturnTypeId", "FuncTypeId", "FuncTypeName", "IsTemplate", "FunctionSignature", "ReturnTypeName", "IsGeneCode", "OrderNum", "UpdDate", "UpdUser", "Memo", "Order4FuncNum"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"FunctionTemplateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FunctionTemplateId = "FunctionTemplateId";    //函数模板Id

 /// <summary>
 /// 常量:"FunctionTemplateName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FunctionTemplateName = "FunctionTemplateName";    //函数模板名

 /// <summary>
 /// 常量:"CreateUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreateUserId = "CreateUserId";    //建立用户Id

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
 /// 常量:"RegionTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RegionTypeId = "RegionTypeId";    //区域类型Id

 /// <summary>
 /// 常量:"RegionTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RegionTypeName = "RegionTypeName";    //区域类型名称

 /// <summary>
 /// 常量:"FuncId4GC"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncId4GC = "FuncId4GC";    //函数ID

 /// <summary>
 /// 常量:"FuncName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncName = "FuncName";    //函数名

 /// <summary>
 /// 常量:"FuncId4Code"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncId4Code = "FuncId4Code";    //函数Id4Code

 /// <summary>
 /// 常量:"FuncName4Code"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncName4Code = "FuncName4Code";    //函数名4Code

 /// <summary>
 /// 常量:"FuncCHName4Code"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncCHName4Code = "FuncCHName4Code";    //函数中文名4Code

 /// <summary>
 /// 常量:"ProgLangTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeId = "ProgLangTypeId";    //编程语言类型Id

 /// <summary>
 /// 常量:"ProgLangTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeName = "ProgLangTypeName";    //编程语言类型名

 /// <summary>
 /// 常量:"SqlDsTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SqlDsTypeId = "SqlDsTypeId";    //数据源类型Id

 /// <summary>
 /// 常量:"SqlDsTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SqlDsTypeName = "SqlDsTypeName";    //Sql数据源名

 /// <summary>
 /// 常量:"ReturnTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReturnTypeId = "ReturnTypeId";    //返回类型ID

 /// <summary>
 /// 常量:"FuncTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncTypeId = "FuncTypeId";    //函数类型Id

 /// <summary>
 /// 常量:"FuncTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncTypeName = "FuncTypeName";    //函数类型名

 /// <summary>
 /// 常量:"IsTemplate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsTemplate = "IsTemplate";    //是否模板

 /// <summary>
 /// 常量:"FunctionSignature"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FunctionSignature = "FunctionSignature";    //函数签名

 /// <summary>
 /// 常量:"ReturnTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReturnTypeName = "ReturnTypeName";    //返回类型名

 /// <summary>
 /// 常量:"IsGeneCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsGeneCode = "IsGeneCode";    //是否生成代码

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

 /// <summary>
 /// 常量:"Order4FuncNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Order4FuncNum = "Order4FuncNum";    //Order4FuncNum
}

}