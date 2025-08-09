
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDataNodeCmPrjIdRelaEN
 表名:DataNodeCmPrjIdRela(00050618)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:03:10
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
 /// 表DataNodeCmPrjIdRela的关键字(CmPrjId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CmPrjId_DataNodeCmPrjIdRela
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
public K_CmPrjId_DataNodeCmPrjIdRela(string strCmPrjId)
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
 /// <returns>返回:[K_CmPrjId_DataNodeCmPrjIdRela]类型的对象</returns>
public static implicit operator K_CmPrjId_DataNodeCmPrjIdRela(string value)
{
return new K_CmPrjId_DataNodeCmPrjIdRela(value);
}
}
 /// <summary>
 /// 数据结点CmPrjId关系(DataNodeCmPrjIdRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsDataNodeCmPrjIdRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "DataNodeCmPrjIdRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "CmPrjId,DataNodeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 5;
public static string[] _AttributeName = new string[] {"CmPrjId", "DataNodeId", "UpdDate", "UpdUser", "Memo"};

protected string mstrCmPrjId;    //Cm工程Id
protected long mlngDataNodeId;    //数据结点Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsDataNodeCmPrjIdRelaEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CmPrjId");
 lstKeyFldNames.Add("DataNodeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strCmPrjId">关键字:Cm工程Id</param>
public clsDataNodeCmPrjIdRelaEN(string strCmPrjId , long lngDataNodeId)
 {
strCmPrjId = strCmPrjId.Replace("'", "''");
if (strCmPrjId.Length > 6)
{
throw new Exception("在表:DataNodeCmPrjIdRela中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strCmPrjId)  ==  true)
{
throw new Exception("在表:DataNodeCmPrjIdRela中,关键字不能为空 或 null!");
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
this.mlngDataNodeId = lngDataNodeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CmPrjId");
 lstKeyFldNames.Add("DataNodeId");
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
if (strAttributeName  ==  conDataNodeCmPrjIdRela.CmPrjId)
{
return mstrCmPrjId;
}
else if (strAttributeName  ==  conDataNodeCmPrjIdRela.DataNodeId)
{
return mlngDataNodeId;
}
else if (strAttributeName  ==  conDataNodeCmPrjIdRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conDataNodeCmPrjIdRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conDataNodeCmPrjIdRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conDataNodeCmPrjIdRela.CmPrjId)
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(conDataNodeCmPrjIdRela.CmPrjId);
}
else if (strAttributeName  ==  conDataNodeCmPrjIdRela.DataNodeId)
{
mlngDataNodeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conDataNodeCmPrjIdRela.DataNodeId);
}
else if (strAttributeName  ==  conDataNodeCmPrjIdRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conDataNodeCmPrjIdRela.UpdDate);
}
else if (strAttributeName  ==  conDataNodeCmPrjIdRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conDataNodeCmPrjIdRela.UpdUser);
}
else if (strAttributeName  ==  conDataNodeCmPrjIdRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDataNodeCmPrjIdRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conDataNodeCmPrjIdRela.CmPrjId  ==  _AttributeName[intIndex])
{
return mstrCmPrjId;
}
else if (conDataNodeCmPrjIdRela.DataNodeId  ==  _AttributeName[intIndex])
{
return mlngDataNodeId;
}
else if (conDataNodeCmPrjIdRela.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conDataNodeCmPrjIdRela.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conDataNodeCmPrjIdRela.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conDataNodeCmPrjIdRela.CmPrjId  ==  _AttributeName[intIndex])
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(conDataNodeCmPrjIdRela.CmPrjId);
}
else if (conDataNodeCmPrjIdRela.DataNodeId  ==  _AttributeName[intIndex])
{
mlngDataNodeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conDataNodeCmPrjIdRela.DataNodeId);
}
else if (conDataNodeCmPrjIdRela.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conDataNodeCmPrjIdRela.UpdDate);
}
else if (conDataNodeCmPrjIdRela.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conDataNodeCmPrjIdRela.UpdUser);
}
else if (conDataNodeCmPrjIdRela.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDataNodeCmPrjIdRela.Memo);
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
 AddUpdatedFld(conDataNodeCmPrjIdRela.CmPrjId);
}
}
/// <summary>
/// 数据结点Id(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long DataNodeId
{
get
{
return mlngDataNodeId;
}
set
{
 mlngDataNodeId = value;
//记录修改过的字段
 AddUpdatedFld(conDataNodeCmPrjIdRela.DataNodeId);
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
 AddUpdatedFld(conDataNodeCmPrjIdRela.UpdDate);
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
 AddUpdatedFld(conDataNodeCmPrjIdRela.UpdUser);
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
 AddUpdatedFld(conDataNodeCmPrjIdRela.Memo);
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
 /// 数据结点CmPrjId关系(DataNodeCmPrjIdRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conDataNodeCmPrjIdRela
{
public const string _CurrTabName = "DataNodeCmPrjIdRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CmPrjId,DataNodeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"CmPrjId", "DataNodeId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"CmPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CmPrjId = "CmPrjId";    //Cm工程Id

 /// <summary>
 /// 常量:"DataNodeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataNodeId = "DataNodeId";    //数据结点Id

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