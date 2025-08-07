
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjUserObjsEN
 表名:PrjUserObjs(00050078)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:33:30
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:用户管理(UserManage)
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
 /// 表PrjUserObjs的关键字(PrjUserObjId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PrjUserObjId_PrjUserObjs
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strPrjUserObjId">表关键字</param>
public K_PrjUserObjId_PrjUserObjs(string strPrjUserObjId)
{
if (IsValid(strPrjUserObjId)) Value = strPrjUserObjId;
else
{
Value = null;
}
}
private static bool IsValid(string strPrjUserObjId)
{
if (string.IsNullOrEmpty(strPrjUserObjId) == true) return false;
if (strPrjUserObjId.Length > 20) return false;
if (strPrjUserObjId.IndexOf(' ') >= 0) return false;
if (strPrjUserObjId.IndexOf(')') >= 0) return false;
if (strPrjUserObjId.IndexOf('(') >= 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PrjUserObjId_PrjUserObjs]类型的对象</returns>
public static implicit operator K_PrjUserObjId_PrjUserObjs(string value)
{
return new K_PrjUserObjId_PrjUserObjs(value);
}
}
 /// <summary>
 /// 工程用户对象(PrjUserObjs)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsPrjUserObjsEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "PrjUserObjs"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PrjUserObjId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 3;
public static string[] _AttributeName = new string[] {"PrjId", "PrjUserObjName", "PrjUserObjId"};

protected string mstrPrjId;    //工程Id
protected string mstrPrjUserObjName;    //PrjUserObjName
protected string mstrPrjUserObjId;    //PrjUserObjId

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsPrjUserObjsEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PrjUserObjId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strPrjUserObjId">关键字:PrjUserObjId</param>
public clsPrjUserObjsEN(string strPrjUserObjId)
 {
strPrjUserObjId = strPrjUserObjId.Replace("'", "''");
if (strPrjUserObjId.Length > 20)
{
throw new Exception("在表:PrjUserObjs中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strPrjUserObjId)  ==  true)
{
throw new Exception("在表:PrjUserObjs中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPrjUserObjId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrPrjUserObjId = strPrjUserObjId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PrjUserObjId");
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
if (strAttributeName  ==  conPrjUserObjs.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conPrjUserObjs.PrjUserObjName)
{
return mstrPrjUserObjName;
}
else if (strAttributeName  ==  conPrjUserObjs.PrjUserObjId)
{
return mstrPrjUserObjId;
}
return null;
}
set
{
if (strAttributeName  ==  conPrjUserObjs.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conPrjUserObjs.PrjId);
}
else if (strAttributeName  ==  conPrjUserObjs.PrjUserObjName)
{
mstrPrjUserObjName = value.ToString();
 AddUpdatedFld(conPrjUserObjs.PrjUserObjName);
}
else if (strAttributeName  ==  conPrjUserObjs.PrjUserObjId)
{
mstrPrjUserObjId = value.ToString();
 AddUpdatedFld(conPrjUserObjs.PrjUserObjId);
}
}
}
public object this[int intIndex]
{
get
{
if (conPrjUserObjs.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conPrjUserObjs.PrjUserObjName  ==  _AttributeName[intIndex])
{
return mstrPrjUserObjName;
}
else if (conPrjUserObjs.PrjUserObjId  ==  _AttributeName[intIndex])
{
return mstrPrjUserObjId;
}
return null;
}
set
{
if (conPrjUserObjs.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conPrjUserObjs.PrjId);
}
else if (conPrjUserObjs.PrjUserObjName  ==  _AttributeName[intIndex])
{
mstrPrjUserObjName = value.ToString();
 AddUpdatedFld(conPrjUserObjs.PrjUserObjName);
}
else if (conPrjUserObjs.PrjUserObjId  ==  _AttributeName[intIndex])
{
mstrPrjUserObjId = value.ToString();
 AddUpdatedFld(conPrjUserObjs.PrjUserObjId);
}
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
 AddUpdatedFld(conPrjUserObjs.PrjId);
}
}
/// <summary>
/// PrjUserObjName(说明:;字段类型:varchar;字段长度:40;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjUserObjName
{
get
{
return mstrPrjUserObjName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjUserObjName = value;
}
else
{
 mstrPrjUserObjName = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjUserObjs.PrjUserObjName);
}
}
/// <summary>
/// PrjUserObjId(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjUserObjId
{
get
{
return mstrPrjUserObjId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjUserObjId = value;
}
else
{
 mstrPrjUserObjId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjUserObjs.PrjUserObjId);
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
  return mstrPrjUserObjId;
 }
 }
}
 /// <summary>
 /// 工程用户对象(PrjUserObjs)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conPrjUserObjs
{
public const string _CurrTabName = "PrjUserObjs"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PrjUserObjId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"PrjId", "PrjUserObjName", "PrjUserObjId"};
//以下是属性变量


 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"PrjUserObjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjUserObjName = "PrjUserObjName";    //PrjUserObjName

 /// <summary>
 /// 常量:"PrjUserObjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjUserObjId = "PrjUserObjId";    //PrjUserObjId
}

}