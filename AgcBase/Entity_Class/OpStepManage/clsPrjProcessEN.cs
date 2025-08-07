
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjProcessEN
 表名:PrjProcess(00050027)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:36:27
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:操作步骤管理(OpStepManage)
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
 /// 表PrjProcess的关键字(PrjProcessId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PrjProcessId_PrjProcess
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strPrjProcessId">表关键字</param>
public K_PrjProcessId_PrjProcess(string strPrjProcessId)
{
if (IsValid(strPrjProcessId)) Value = strPrjProcessId;
else
{
Value = null;
}
}
private static bool IsValid(string strPrjProcessId)
{
if (string.IsNullOrEmpty(strPrjProcessId) == true) return false;
if (strPrjProcessId.Length > 4) return false;
if (strPrjProcessId.IndexOf(' ') >= 0) return false;
if (strPrjProcessId.IndexOf(')') >= 0) return false;
if (strPrjProcessId.IndexOf('(') >= 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PrjProcessId_PrjProcess]类型的对象</returns>
public static implicit operator K_PrjProcessId_PrjProcess(string value)
{
return new K_PrjProcessId_PrjProcess(value);
}
}
 /// <summary>
 /// 项目过程步骤(PrjProcess)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsPrjProcessEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "PrjProcess"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PrjProcessId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 5;
public static string[] _AttributeName = new string[] {"PrjProcessId", "PrjProcessName", "PrjProcessTypeId", "Memo", "IsViewRela"};

protected string mstrPrjProcessId;    //项目过程ID
protected string mstrPrjProcessName;    //项目过程名称
protected string mstrPrjProcessTypeId;    //项目过程分类ID
protected string mstrMemo;    //说明
protected bool mbolIsViewRela;    //是否界面相关

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsPrjProcessEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PrjProcessId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strPrjProcessId">关键字:项目过程ID</param>
public clsPrjProcessEN(string strPrjProcessId)
 {
strPrjProcessId = strPrjProcessId.Replace("'", "''");
if (strPrjProcessId.Length > 4)
{
throw new Exception("在表:PrjProcess中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strPrjProcessId)  ==  true)
{
throw new Exception("在表:PrjProcess中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPrjProcessId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrPrjProcessId = strPrjProcessId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PrjProcessId");
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
if (strAttributeName  ==  conPrjProcess.PrjProcessId)
{
return mstrPrjProcessId;
}
else if (strAttributeName  ==  conPrjProcess.PrjProcessName)
{
return mstrPrjProcessName;
}
else if (strAttributeName  ==  conPrjProcess.PrjProcessTypeId)
{
return mstrPrjProcessTypeId;
}
else if (strAttributeName  ==  conPrjProcess.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conPrjProcess.IsViewRela)
{
return mbolIsViewRela;
}
return null;
}
set
{
if (strAttributeName  ==  conPrjProcess.PrjProcessId)
{
mstrPrjProcessId = value.ToString();
 AddUpdatedFld(conPrjProcess.PrjProcessId);
}
else if (strAttributeName  ==  conPrjProcess.PrjProcessName)
{
mstrPrjProcessName = value.ToString();
 AddUpdatedFld(conPrjProcess.PrjProcessName);
}
else if (strAttributeName  ==  conPrjProcess.PrjProcessTypeId)
{
mstrPrjProcessTypeId = value.ToString();
 AddUpdatedFld(conPrjProcess.PrjProcessTypeId);
}
else if (strAttributeName  ==  conPrjProcess.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPrjProcess.Memo);
}
else if (strAttributeName  ==  conPrjProcess.IsViewRela)
{
mbolIsViewRela = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjProcess.IsViewRela);
}
}
}
public object this[int intIndex]
{
get
{
if (conPrjProcess.PrjProcessId  ==  _AttributeName[intIndex])
{
return mstrPrjProcessId;
}
else if (conPrjProcess.PrjProcessName  ==  _AttributeName[intIndex])
{
return mstrPrjProcessName;
}
else if (conPrjProcess.PrjProcessTypeId  ==  _AttributeName[intIndex])
{
return mstrPrjProcessTypeId;
}
else if (conPrjProcess.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (conPrjProcess.IsViewRela  ==  _AttributeName[intIndex])
{
return mbolIsViewRela;
}
return null;
}
set
{
if (conPrjProcess.PrjProcessId  ==  _AttributeName[intIndex])
{
mstrPrjProcessId = value.ToString();
 AddUpdatedFld(conPrjProcess.PrjProcessId);
}
else if (conPrjProcess.PrjProcessName  ==  _AttributeName[intIndex])
{
mstrPrjProcessName = value.ToString();
 AddUpdatedFld(conPrjProcess.PrjProcessName);
}
else if (conPrjProcess.PrjProcessTypeId  ==  _AttributeName[intIndex])
{
mstrPrjProcessTypeId = value.ToString();
 AddUpdatedFld(conPrjProcess.PrjProcessTypeId);
}
else if (conPrjProcess.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPrjProcess.Memo);
}
else if (conPrjProcess.IsViewRela  ==  _AttributeName[intIndex])
{
mbolIsViewRela = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjProcess.IsViewRela);
}
}
}

/// <summary>
/// 项目过程ID(说明:;字段类型:varchar;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjProcessId
{
get
{
return mstrPrjProcessId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjProcessId = value;
}
else
{
 mstrPrjProcessId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjProcess.PrjProcessId);
}
}
/// <summary>
/// 项目过程名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjProcessName
{
get
{
return mstrPrjProcessName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjProcessName = value;
}
else
{
 mstrPrjProcessName = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjProcess.PrjProcessName);
}
}
/// <summary>
/// 项目过程分类ID(说明:;字段类型:varchar;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjProcessTypeId
{
get
{
return mstrPrjProcessTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjProcessTypeId = value;
}
else
{
 mstrPrjProcessTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjProcess.PrjProcessTypeId);
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
 AddUpdatedFld(conPrjProcess.Memo);
}
}
/// <summary>
/// 是否界面相关(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsViewRela
{
get
{
return mbolIsViewRela;
}
set
{
 mbolIsViewRela = value;
//记录修改过的字段
 AddUpdatedFld(conPrjProcess.IsViewRela);
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
  return mstrPrjProcessId;
 }
 }
}
 /// <summary>
 /// 项目过程步骤(PrjProcess)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conPrjProcess
{
public const string _CurrTabName = "PrjProcess"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PrjProcessId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"PrjProcessId", "PrjProcessName", "PrjProcessTypeId", "Memo", "IsViewRela"};
//以下是属性变量


 /// <summary>
 /// 常量:"PrjProcessId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjProcessId = "PrjProcessId";    //项目过程ID

 /// <summary>
 /// 常量:"PrjProcessName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjProcessName = "PrjProcessName";    //项目过程名称

 /// <summary>
 /// 常量:"PrjProcessTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjProcessTypeId = "PrjProcessTypeId";    //项目过程分类ID

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明

 /// <summary>
 /// 常量:"IsViewRela"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsViewRela = "IsViewRela";    //是否界面相关
}

}