
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clswf_PointTypeEN
 表名:wf_PointType(00050483)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:18:46
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:工作流管理(WorkFlow)
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
 /// 表wf_PointType的关键字(PointTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PointTypeId_wf_PointType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strPointTypeId">表关键字</param>
public K_PointTypeId_wf_PointType(string strPointTypeId)
{
if (IsValid(strPointTypeId)) Value = strPointTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strPointTypeId)
{
if (string.IsNullOrEmpty(strPointTypeId) == true) return false;
if (strPointTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PointTypeId_wf_PointType]类型的对象</returns>
public static implicit operator K_PointTypeId_wf_PointType(string value)
{
return new K_PointTypeId_wf_PointType(value);
}
}
 /// <summary>
 /// 工作流结点类型(wf_PointType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clswf_PointTypeEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接，如果为空就使用系统默认的连接
public new const string _CurrTabName = "wf_PointType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PointTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string WhereFormat = ""; //条件格式串
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"PointTypeId", "PointTypeName", "PointTypeENName", "Memo"};

protected string mstrPointTypeId;    //工作流结点类型Id
protected string mstrPointTypeName;    //工作流结点类型名称
protected string mstrPointTypeENName;    //PointTypeENName
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clswf_PointTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "wf_PointType";
 lstKeyFldNames.Add("PointTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strPointTypeId">关键字:工作流结点类型Id</param>
public clswf_PointTypeEN(string strPointTypeId)
 {
strPointTypeId = strPointTypeId.Replace("'", "''");
if (strPointTypeId.Length > 2)
{
throw new Exception("在表:wf_PointType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strPointTypeId)  ==  true)
{
throw new Exception("在表:wf_PointType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPointTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrPointTypeId = strPointTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "wf_PointType";
 lstKeyFldNames.Add("PointTypeId");
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
if (strAttributeName  ==  conwf_PointType.PointTypeId)
{
return mstrPointTypeId;
}
else if (strAttributeName  ==  conwf_PointType.PointTypeName)
{
return mstrPointTypeName;
}
else if (strAttributeName  ==  conwf_PointType.PointTypeENName)
{
return mstrPointTypeENName;
}
else if (strAttributeName  ==  conwf_PointType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conwf_PointType.PointTypeId)
{
mstrPointTypeId = value.ToString();
 AddUpdatedFld(conwf_PointType.PointTypeId);
}
else if (strAttributeName  ==  conwf_PointType.PointTypeName)
{
mstrPointTypeName = value.ToString();
 AddUpdatedFld(conwf_PointType.PointTypeName);
}
else if (strAttributeName  ==  conwf_PointType.PointTypeENName)
{
mstrPointTypeENName = value.ToString();
 AddUpdatedFld(conwf_PointType.PointTypeENName);
}
else if (strAttributeName  ==  conwf_PointType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conwf_PointType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conwf_PointType.PointTypeId  ==  AttributeName[intIndex])
{
return mstrPointTypeId;
}
else if (conwf_PointType.PointTypeName  ==  AttributeName[intIndex])
{
return mstrPointTypeName;
}
else if (conwf_PointType.PointTypeENName  ==  AttributeName[intIndex])
{
return mstrPointTypeENName;
}
else if (conwf_PointType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conwf_PointType.PointTypeId  ==  AttributeName[intIndex])
{
mstrPointTypeId = value.ToString();
 AddUpdatedFld(conwf_PointType.PointTypeId);
}
else if (conwf_PointType.PointTypeName  ==  AttributeName[intIndex])
{
mstrPointTypeName = value.ToString();
 AddUpdatedFld(conwf_PointType.PointTypeName);
}
else if (conwf_PointType.PointTypeENName  ==  AttributeName[intIndex])
{
mstrPointTypeENName = value.ToString();
 AddUpdatedFld(conwf_PointType.PointTypeENName);
}
else if (conwf_PointType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conwf_PointType.Memo);
}
}
}

/// <summary>
/// 工作流结点类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PointTypeId
{
get
{
return mstrPointTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPointTypeId = value;
}
else
{
 mstrPointTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conwf_PointType.PointTypeId);
}
}
/// <summary>
/// 工作流结点类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PointTypeName
{
get
{
return mstrPointTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPointTypeName = value;
}
else
{
 mstrPointTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conwf_PointType.PointTypeName);
}
}
/// <summary>
/// PointTypeENName(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PointTypeENName
{
get
{
return mstrPointTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPointTypeENName = value;
}
else
{
 mstrPointTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conwf_PointType.PointTypeENName);
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
 AddUpdatedFld(conwf_PointType.Memo);
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
  return mstrPointTypeId;
 }
 }

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrPointTypeName;
 }
 }
}
 /// <summary>
 /// 工作流结点类型(wf_PointType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conwf_PointType
{
public new const string _CurrTabName = "wf_PointType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PointTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PointTypeId", "PointTypeName", "PointTypeENName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"PointTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PointTypeId = "PointTypeId";    //工作流结点类型Id

 /// <summary>
 /// 常量:"PointTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PointTypeName = "PointTypeName";    //工作流结点类型名称

 /// <summary>
 /// 常量:"PointTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PointTypeENName = "PointTypeENName";    //PointTypeENName

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}