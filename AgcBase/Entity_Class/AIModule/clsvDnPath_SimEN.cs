
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvDnPath_SimEN
 表名:vDnPath_Sim(00050603)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:02:56
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:AI模块(AIModule)
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
 /// 表vDnPath_Sim的关键字(DnPathId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_DnPathId_vDnPath_Sim
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strDnPathId">表关键字</param>
public K_DnPathId_vDnPath_Sim(string strDnPathId)
{
if (IsValid(strDnPathId)) Value = strDnPathId;
else
{
Value = null;
}
}
private static bool IsValid(string strDnPathId)
{
if (string.IsNullOrEmpty(strDnPathId) == true) return false;
if (strDnPathId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_DnPathId_vDnPath_Sim]类型的对象</returns>
public static implicit operator K_DnPathId_vDnPath_Sim(string value)
{
return new K_DnPathId_vDnPath_Sim(value);
}
}
 /// <summary>
 /// vDnPath_Sim(vDnPath_Sim)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvDnPath_SimEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vDnPath_Sim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "DnPathId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 6;
public static string[] _AttributeName = new string[] {"DnPathId", "DnPathName", "InDataNodeId", "OutDataNodeId", "DnPathNodeLst", "PrjId"};

protected string mstrDnPathId;    //DN路径Id
protected string mstrDnPathName;    //DN路径名
protected long mlngInDataNodeId;    //In数据结点Id
protected long mlngOutDataNodeId;    //Out数据结点Id
protected string mstrDnPathNodeLst;    //路径结点列表
protected string mstrPrjId;    //工程Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvDnPath_SimEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("DnPathId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strDnPathId">关键字:DN路径Id</param>
public clsvDnPath_SimEN(string strDnPathId)
 {
strDnPathId = strDnPathId.Replace("'", "''");
if (strDnPathId.Length > 8)
{
throw new Exception("在表:vDnPath_Sim中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strDnPathId)  ==  true)
{
throw new Exception("在表:vDnPath_Sim中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strDnPathId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrDnPathId = strDnPathId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("DnPathId");
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
if (strAttributeName  ==  convDnPath_Sim.DnPathId)
{
return mstrDnPathId;
}
else if (strAttributeName  ==  convDnPath_Sim.DnPathName)
{
return mstrDnPathName;
}
else if (strAttributeName  ==  convDnPath_Sim.InDataNodeId)
{
return mlngInDataNodeId;
}
else if (strAttributeName  ==  convDnPath_Sim.OutDataNodeId)
{
return mlngOutDataNodeId;
}
else if (strAttributeName  ==  convDnPath_Sim.DnPathNodeLst)
{
return mstrDnPathNodeLst;
}
else if (strAttributeName  ==  convDnPath_Sim.PrjId)
{
return mstrPrjId;
}
return null;
}
set
{
if (strAttributeName  ==  convDnPath_Sim.DnPathId)
{
mstrDnPathId = value.ToString();
 AddUpdatedFld(convDnPath_Sim.DnPathId);
}
else if (strAttributeName  ==  convDnPath_Sim.DnPathName)
{
mstrDnPathName = value.ToString();
 AddUpdatedFld(convDnPath_Sim.DnPathName);
}
else if (strAttributeName  ==  convDnPath_Sim.InDataNodeId)
{
mlngInDataNodeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convDnPath_Sim.InDataNodeId);
}
else if (strAttributeName  ==  convDnPath_Sim.OutDataNodeId)
{
mlngOutDataNodeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convDnPath_Sim.OutDataNodeId);
}
else if (strAttributeName  ==  convDnPath_Sim.DnPathNodeLst)
{
mstrDnPathNodeLst = value.ToString();
 AddUpdatedFld(convDnPath_Sim.DnPathNodeLst);
}
else if (strAttributeName  ==  convDnPath_Sim.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convDnPath_Sim.PrjId);
}
}
}
public object this[int intIndex]
{
get
{
if (convDnPath_Sim.DnPathId  ==  _AttributeName[intIndex])
{
return mstrDnPathId;
}
else if (convDnPath_Sim.DnPathName  ==  _AttributeName[intIndex])
{
return mstrDnPathName;
}
else if (convDnPath_Sim.InDataNodeId  ==  _AttributeName[intIndex])
{
return mlngInDataNodeId;
}
else if (convDnPath_Sim.OutDataNodeId  ==  _AttributeName[intIndex])
{
return mlngOutDataNodeId;
}
else if (convDnPath_Sim.DnPathNodeLst  ==  _AttributeName[intIndex])
{
return mstrDnPathNodeLst;
}
else if (convDnPath_Sim.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
return null;
}
set
{
if (convDnPath_Sim.DnPathId  ==  _AttributeName[intIndex])
{
mstrDnPathId = value.ToString();
 AddUpdatedFld(convDnPath_Sim.DnPathId);
}
else if (convDnPath_Sim.DnPathName  ==  _AttributeName[intIndex])
{
mstrDnPathName = value.ToString();
 AddUpdatedFld(convDnPath_Sim.DnPathName);
}
else if (convDnPath_Sim.InDataNodeId  ==  _AttributeName[intIndex])
{
mlngInDataNodeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convDnPath_Sim.InDataNodeId);
}
else if (convDnPath_Sim.OutDataNodeId  ==  _AttributeName[intIndex])
{
mlngOutDataNodeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convDnPath_Sim.OutDataNodeId);
}
else if (convDnPath_Sim.DnPathNodeLst  ==  _AttributeName[intIndex])
{
mstrDnPathNodeLst = value.ToString();
 AddUpdatedFld(convDnPath_Sim.DnPathNodeLst);
}
else if (convDnPath_Sim.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convDnPath_Sim.PrjId);
}
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
 AddUpdatedFld(convDnPath_Sim.DnPathId);
}
}
/// <summary>
/// DN路径名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DnPathName
{
get
{
return mstrDnPathName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDnPathName = value;
}
else
{
 mstrDnPathName = value;
}
//记录修改过的字段
 AddUpdatedFld(convDnPath_Sim.DnPathName);
}
}
/// <summary>
/// In数据结点Id(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long InDataNodeId
{
get
{
return mlngInDataNodeId;
}
set
{
 mlngInDataNodeId = value;
//记录修改过的字段
 AddUpdatedFld(convDnPath_Sim.InDataNodeId);
}
}
/// <summary>
/// Out数据结点Id(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long OutDataNodeId
{
get
{
return mlngOutDataNodeId;
}
set
{
 mlngOutDataNodeId = value;
//记录修改过的字段
 AddUpdatedFld(convDnPath_Sim.OutDataNodeId);
}
}
/// <summary>
/// 路径结点列表(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DnPathNodeLst
{
get
{
return mstrDnPathNodeLst;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDnPathNodeLst = value;
}
else
{
 mstrDnPathNodeLst = value;
}
//记录修改过的字段
 AddUpdatedFld(convDnPath_Sim.DnPathNodeLst);
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
 AddUpdatedFld(convDnPath_Sim.PrjId);
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
  return mstrDnPathId;
 }
 }

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrDnPathName;
 }
 }
}
 /// <summary>
 /// vDnPath_Sim(vDnPath_Sim)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convDnPath_Sim
{
public const string _CurrTabName = "vDnPath_Sim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "DnPathId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"DnPathId", "DnPathName", "InDataNodeId", "OutDataNodeId", "DnPathNodeLst", "PrjId"};
//以下是属性变量


 /// <summary>
 /// 常量:"DnPathId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DnPathId = "DnPathId";    //DN路径Id

 /// <summary>
 /// 常量:"DnPathName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DnPathName = "DnPathName";    //DN路径名

 /// <summary>
 /// 常量:"InDataNodeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InDataNodeId = "InDataNodeId";    //In数据结点Id

 /// <summary>
 /// 常量:"OutDataNodeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OutDataNodeId = "OutDataNodeId";    //Out数据结点Id

 /// <summary>
 /// 常量:"DnPathNodeLst"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DnPathNodeLst = "DnPathNodeLst";    //路径结点列表

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id
}

}