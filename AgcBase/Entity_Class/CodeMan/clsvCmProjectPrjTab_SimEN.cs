
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCmProjectPrjTab_SimEN
 表名:vCmProjectPrjTab_Sim(00050639)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:26:36
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
 /// 表vCmProjectPrjTab_Sim的关键字(CmPrjId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CmPrjId_vCmProjectPrjTab_Sim
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strCmPrjId">表关键字</param>
public K_CmPrjId_vCmProjectPrjTab_Sim(string strCmPrjId)
{
if (IsValid(strCmPrjId)) Value = strCmPrjId;
else
{
Value = null;
}
}
private static bool IsValid(string strCmPrjId)
{
if (string.IsNullOrEmpty(strCmPrjId) == true) return false;
if (strCmPrjId.Length != 6) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_CmPrjId_vCmProjectPrjTab_Sim]类型的对象</returns>
public static implicit operator K_CmPrjId_vCmProjectPrjTab_Sim(string value)
{
return new K_CmPrjId_vCmProjectPrjTab_Sim(value);
}
}
 /// <summary>
 /// vCmProjectPrjTab_Sim(vCmProjectPrjTab_Sim)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvCmProjectPrjTab_SimEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vCmProjectPrjTab_Sim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "CmPrjId,TabId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = "CmPrjId in (select CmPrjId from CmProject where prjid='{0}')"; //前台条件格式串
protected const int _AttributeCount = 2;
public static string[] _AttributeName = new string[] {"CmPrjId", "TabId"};

protected string mstrCmPrjId;    //Cm工程Id
protected string mstrTabId;    //表ID

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvCmProjectPrjTab_SimEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CmPrjId");
 lstKeyFldNames.Add("TabId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strCmPrjId">关键字:Cm工程Id</param>
public clsvCmProjectPrjTab_SimEN(string strCmPrjId , string strTabId)
 {
strCmPrjId = strCmPrjId.Replace("'", "''");
if (strCmPrjId.Length > 6)
{
throw new Exception("在表:vCmProjectPrjTab_Sim中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strCmPrjId)  ==  true)
{
throw new Exception("在表:vCmProjectPrjTab_Sim中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCmPrjId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrCmPrjId = strCmPrjId;
this.mstrTabId = strTabId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CmPrjId");
 lstKeyFldNames.Add("TabId");
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
if (strAttributeName  ==  convCmProjectPrjTab_Sim.CmPrjId)
{
return mstrCmPrjId;
}
else if (strAttributeName  ==  convCmProjectPrjTab_Sim.TabId)
{
return mstrTabId;
}
return null;
}
set
{
if (strAttributeName  ==  convCmProjectPrjTab_Sim.CmPrjId)
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(convCmProjectPrjTab_Sim.CmPrjId);
}
else if (strAttributeName  ==  convCmProjectPrjTab_Sim.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(convCmProjectPrjTab_Sim.TabId);
}
}
}
public object this[int intIndex]
{
get
{
if (convCmProjectPrjTab_Sim.CmPrjId  ==  _AttributeName[intIndex])
{
return mstrCmPrjId;
}
else if (convCmProjectPrjTab_Sim.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
return null;
}
set
{
if (convCmProjectPrjTab_Sim.CmPrjId  ==  _AttributeName[intIndex])
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(convCmProjectPrjTab_Sim.CmPrjId);
}
else if (convCmProjectPrjTab_Sim.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(convCmProjectPrjTab_Sim.TabId);
}
}
}

/// <summary>
/// Cm工程Id(说明:;字段类型:char;字段长度:6;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CmPrjId
{
get
{
return mstrCmPrjId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCmPrjId = value;
}
else
{
 mstrCmPrjId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCmProjectPrjTab_Sim.CmPrjId);
}
}
/// <summary>
/// 表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabId
{
get
{
return mstrTabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabId = value;
}
else
{
 mstrTabId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCmProjectPrjTab_Sim.TabId);
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
  return mstrCmPrjId;
 }
 }
}
 /// <summary>
 /// vCmProjectPrjTab_Sim(vCmProjectPrjTab_Sim)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convCmProjectPrjTab_Sim
{
public const string _CurrTabName = "vCmProjectPrjTab_Sim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CmPrjId,TabId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"CmPrjId", "TabId"};
//以下是属性变量


 /// <summary>
 /// 常量:"CmPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CmPrjId = "CmPrjId";    //Cm工程Id

 /// <summary>
 /// 常量:"TabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabId = "TabId";    //表ID
}

}