
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjTabFld_DnPathIdEN
 表名:vPrjTabFld_DnPathId(00050616)
 * 版本:2024.10.15.1(服务器:WIN-SRV103-116)
 日期:2024/10/15 12:06:18
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
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
 /// 表vPrjTabFld_DnPathId的关键字(TabId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TabId_vPrjTabFld_DnPathId
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
public K_TabId_vPrjTabFld_DnPathId(string strTabId)
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
 /// <returns>返回:[K_TabId_vPrjTabFld_DnPathId]类型的对象</returns>
public static implicit operator K_TabId_vPrjTabFld_DnPathId(string value)
{
return new K_TabId_vPrjTabFld_DnPathId(value);
}
}
 /// <summary>
 /// v表字段_DnPathId(vPrjTabFld_DnPathId)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvPrjTabFld_DnPathIdEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vPrjTabFld_DnPathId"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TabId,FldId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = "TabId in (Select TabId from CmProjectPrjTab where CmPrjId='{0}')"; //前台条件格式串
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"TabId", "FldId", "DnPathId", "CmPrjId"};

protected string mstrTabId;    //表ID
protected string mstrFldId;    //字段Id
protected string mstrDnPathId;    //DN路径Id
protected string mstrCmPrjId;    //CmPrjId

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvPrjTabFld_DnPathIdEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TabId");
 lstKeyFldNames.Add("FldId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strTabId">关键字:表ID</param>
public clsvPrjTabFld_DnPathIdEN(string strTabId , string strFldId)
 {
strTabId = strTabId.Replace("'", "''");
if (strTabId.Length > 8)
{
throw new Exception("在表:vPrjTabFld_DnPathId中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTabId)  ==  true)
{
throw new Exception("在表:vPrjTabFld_DnPathId中,关键字不能为空 或 null!");
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
this.mstrFldId = strFldId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TabId");
 lstKeyFldNames.Add("FldId");
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
if (strAttributeName  ==  convPrjTabFld_DnPathId.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  convPrjTabFld_DnPathId.FldId)
{
return mstrFldId;
}
else if (strAttributeName  ==  convPrjTabFld_DnPathId.DnPathId)
{
return mstrDnPathId;
}
else if (strAttributeName  ==  convPrjTabFld_DnPathId.CmPrjId)
{
return mstrCmPrjId;
}
return null;
}
set
{
if (strAttributeName  ==  convPrjTabFld_DnPathId.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(convPrjTabFld_DnPathId.TabId);
}
else if (strAttributeName  ==  convPrjTabFld_DnPathId.FldId)
{
mstrFldId = value.ToString();
 AddUpdatedFld(convPrjTabFld_DnPathId.FldId);
}
else if (strAttributeName  ==  convPrjTabFld_DnPathId.DnPathId)
{
mstrDnPathId = value.ToString();
 AddUpdatedFld(convPrjTabFld_DnPathId.DnPathId);
}
else if (strAttributeName  ==  convPrjTabFld_DnPathId.CmPrjId)
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(convPrjTabFld_DnPathId.CmPrjId);
}
}
}
public object this[int intIndex]
{
get
{
if (convPrjTabFld_DnPathId.TabId  ==  AttributeName[intIndex])
{
return mstrTabId;
}
else if (convPrjTabFld_DnPathId.FldId  ==  AttributeName[intIndex])
{
return mstrFldId;
}
else if (convPrjTabFld_DnPathId.DnPathId  ==  AttributeName[intIndex])
{
return mstrDnPathId;
}
else if (convPrjTabFld_DnPathId.CmPrjId  ==  AttributeName[intIndex])
{
return mstrCmPrjId;
}
return null;
}
set
{
if (convPrjTabFld_DnPathId.TabId  ==  AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(convPrjTabFld_DnPathId.TabId);
}
else if (convPrjTabFld_DnPathId.FldId  ==  AttributeName[intIndex])
{
mstrFldId = value.ToString();
 AddUpdatedFld(convPrjTabFld_DnPathId.FldId);
}
else if (convPrjTabFld_DnPathId.DnPathId  ==  AttributeName[intIndex])
{
mstrDnPathId = value.ToString();
 AddUpdatedFld(convPrjTabFld_DnPathId.DnPathId);
}
else if (convPrjTabFld_DnPathId.CmPrjId  ==  AttributeName[intIndex])
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(convPrjTabFld_DnPathId.CmPrjId);
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
 AddUpdatedFld(convPrjTabFld_DnPathId.TabId);
}
}
/// <summary>
/// 字段Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FldId
{
get
{
return mstrFldId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldId = value;
}
else
{
 mstrFldId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjTabFld_DnPathId.FldId);
}
}
/// <summary>
/// DN路径Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DnPathId
{
get
{
return mstrDnPathId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDnPathId = value;
}
else
{
 mstrDnPathId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjTabFld_DnPathId.DnPathId);
}
}
/// <summary>
/// CmPrjId(说明:;字段类型:varchar;字段长度:1;是否可空:False)
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
 AddUpdatedFld(convPrjTabFld_DnPathId.CmPrjId);
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
  return mstrTabId;
 }
 }
}
 /// <summary>
 /// v表字段_DnPathId(vPrjTabFld_DnPathId)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convPrjTabFld_DnPathId
{
public const string _CurrTabName = "vPrjTabFld_DnPathId"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TabId,FldId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"TabId", "FldId", "DnPathId", "CmPrjId"};
//以下是属性变量


 /// <summary>
 /// 常量:"TabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabId = "TabId";    //表ID

 /// <summary>
 /// 常量:"FldId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldId = "FldId";    //字段Id

 /// <summary>
 /// 常量:"DnPathId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DnPathId = "DnPathId";    //DN路径Id

 /// <summary>
 /// 常量:"CmPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CmPrjId = "CmPrjId";    //CmPrjId
}

}