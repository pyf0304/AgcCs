
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjTabFldNumEN
 表名:vPrjTabFldNum(00050285)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:49:08
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
 /// 表vPrjTabFldNum的关键字(TabId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TabId_vPrjTabFldNum
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strTabId">表关键字</param>
public K_TabId_vPrjTabFldNum(string strTabId)
{
if (IsValid(strTabId)) Value = strTabId;
else
{
Value = null;
}
}
private static bool IsValid(string strTabId)
{
if (string.IsNullOrEmpty(strTabId) == true) return false;
if (strTabId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_TabId_vPrjTabFldNum]类型的对象</returns>
public static implicit operator K_TabId_vPrjTabFldNum(string value)
{
return new K_TabId_vPrjTabFldNum(value);
}
}
 /// <summary>
 /// vPrjTabFldNum(vPrjTabFldNum)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvPrjTabFldNumEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vPrjTabFldNum"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TabId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 3;
public static string[] _AttributeName = new string[] {"TabId", "FldNum", "PrjId"};

protected string mstrTabId;    //表ID
protected int? mintFldNum;    //字段数
protected string mstrPrjId;    //工程Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvPrjTabFldNumEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TabId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strTabId">关键字:表ID</param>
public clsvPrjTabFldNumEN(string strTabId)
 {
strTabId = strTabId.Replace("'", "''");
if (strTabId.Length > 8)
{
throw new Exception("在表:vPrjTabFldNum中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTabId)  ==  true)
{
throw new Exception("在表:vPrjTabFldNum中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTabId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrTabId = strTabId;
 SetInit();
 mbolIsCheckProperty = false;
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
if (strAttributeName  ==  convPrjTabFldNum.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  convPrjTabFldNum.FldNum)
{
return mintFldNum;
}
else if (strAttributeName  ==  convPrjTabFldNum.PrjId)
{
return mstrPrjId;
}
return null;
}
set
{
if (strAttributeName  ==  convPrjTabFldNum.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(convPrjTabFldNum.TabId);
}
else if (strAttributeName  ==  convPrjTabFldNum.FldNum)
{
mintFldNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convPrjTabFldNum.FldNum);
}
else if (strAttributeName  ==  convPrjTabFldNum.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convPrjTabFldNum.PrjId);
}
}
}
public object this[int intIndex]
{
get
{
if (convPrjTabFldNum.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (convPrjTabFldNum.FldNum  ==  _AttributeName[intIndex])
{
return mintFldNum;
}
else if (convPrjTabFldNum.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
return null;
}
set
{
if (convPrjTabFldNum.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(convPrjTabFldNum.TabId);
}
else if (convPrjTabFldNum.FldNum  ==  _AttributeName[intIndex])
{
mintFldNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convPrjTabFldNum.FldNum);
}
else if (convPrjTabFldNum.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convPrjTabFldNum.PrjId);
}
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
 AddUpdatedFld(convPrjTabFldNum.TabId);
}
}
/// <summary>
/// 字段数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? FldNum
{
get
{
return mintFldNum;
}
set
{
 mintFldNum = value;
//记录修改过的字段
 AddUpdatedFld(convPrjTabFldNum.FldNum);
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
 AddUpdatedFld(convPrjTabFldNum.PrjId);
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
  return mstrTabId;
 }
 }
}
 /// <summary>
 /// vPrjTabFldNum(vPrjTabFldNum)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convPrjTabFldNum
{
public const string _CurrTabName = "vPrjTabFldNum"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TabId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"TabId", "FldNum", "PrjId"};
//以下是属性变量


 /// <summary>
 /// 常量:"TabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabId = "TabId";    //表ID

 /// <summary>
 /// 常量:"FldNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldNum = "FldNum";    //字段数

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id
}

}