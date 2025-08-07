
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvwf_PointEN
 表名:vwf_Point(00050496)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:18:18
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
 /// 表vwf_Point的关键字(PointId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PointId_vwf_Point
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strPointId">表关键字</param>
public K_PointId_vwf_Point(string strPointId)
{
if (IsValid(strPointId)) Value = strPointId;
else
{
Value = null;
}
}
private static bool IsValid(string strPointId)
{
if (string.IsNullOrEmpty(strPointId) == true) return false;
if (strPointId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PointId_vwf_Point]类型的对象</returns>
public static implicit operator K_PointId_vwf_Point(string value)
{
return new K_PointId_vwf_Point(value);
}
}
 /// <summary>
 /// v工作流结点(vwf_Point)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvwf_PointEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接，如果为空就使用系统默认的连接
public new const string _CurrTabName = "vwf_Point"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PointId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string WhereFormat = ""; //条件格式串
protected const int mintAttributeCount = 10;
public static string[] AttributeName = new string[] {"PointId", "PointName", "PrjId", "PrjName", "TabName", "TabKeyId", "InUse", "UpdDate", "UpdUser", "Memo"};

protected string mstrPointId;    //结点Id
protected string mstrPointName;    //结点名称
protected string mstrPrjId;    //工程ID
protected string mstrPrjName;    //工程名称
protected string mstrTabName;    //表名
protected string mstrTabKeyId;    //表关键字Id
protected bool mbolInUse;    //是否在用
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvwf_PointEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "vwf_Point";
 lstKeyFldNames.Add("PointId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strPointId">关键字:结点Id</param>
public clsvwf_PointEN(string strPointId)
 {
strPointId = strPointId.Replace("'", "''");
if (strPointId.Length > 8)
{
throw new Exception("在表:vwf_Point中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strPointId)  ==  true)
{
throw new Exception("在表:vwf_Point中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPointId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrPointId = strPointId;
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "vwf_Point";
 lstKeyFldNames.Add("PointId");
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
if (strAttributeName  ==  convwf_Point.PointId)
{
return mstrPointId;
}
else if (strAttributeName  ==  convwf_Point.PointName)
{
return mstrPointName;
}
else if (strAttributeName  ==  convwf_Point.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convwf_Point.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convwf_Point.TabName)
{
return mstrTabName;
}
else if (strAttributeName  ==  convwf_Point.TabKeyId)
{
return mstrTabKeyId;
}
else if (strAttributeName  ==  convwf_Point.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  convwf_Point.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convwf_Point.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convwf_Point.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convwf_Point.PointId)
{
mstrPointId = value.ToString();
 AddUpdatedFld(convwf_Point.PointId);
}
else if (strAttributeName  ==  convwf_Point.PointName)
{
mstrPointName = value.ToString();
 AddUpdatedFld(convwf_Point.PointName);
}
else if (strAttributeName  ==  convwf_Point.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convwf_Point.PrjId);
}
else if (strAttributeName  ==  convwf_Point.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convwf_Point.PrjName);
}
else if (strAttributeName  ==  convwf_Point.TabName)
{
mstrTabName = value.ToString();
 AddUpdatedFld(convwf_Point.TabName);
}
else if (strAttributeName  ==  convwf_Point.TabKeyId)
{
mstrTabKeyId = value.ToString();
 AddUpdatedFld(convwf_Point.TabKeyId);
}
else if (strAttributeName  ==  convwf_Point.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convwf_Point.InUse);
}
else if (strAttributeName  ==  convwf_Point.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convwf_Point.UpdDate);
}
else if (strAttributeName  ==  convwf_Point.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convwf_Point.UpdUser);
}
else if (strAttributeName  ==  convwf_Point.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convwf_Point.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convwf_Point.PointId  ==  AttributeName[intIndex])
{
return mstrPointId;
}
else if (convwf_Point.PointName  ==  AttributeName[intIndex])
{
return mstrPointName;
}
else if (convwf_Point.PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convwf_Point.PrjName  ==  AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convwf_Point.TabName  ==  AttributeName[intIndex])
{
return mstrTabName;
}
else if (convwf_Point.TabKeyId  ==  AttributeName[intIndex])
{
return mstrTabKeyId;
}
else if (convwf_Point.InUse  ==  AttributeName[intIndex])
{
return mbolInUse;
}
else if (convwf_Point.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convwf_Point.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convwf_Point.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convwf_Point.PointId  ==  AttributeName[intIndex])
{
mstrPointId = value.ToString();
 AddUpdatedFld(convwf_Point.PointId);
}
else if (convwf_Point.PointName  ==  AttributeName[intIndex])
{
mstrPointName = value.ToString();
 AddUpdatedFld(convwf_Point.PointName);
}
else if (convwf_Point.PrjId  ==  AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convwf_Point.PrjId);
}
else if (convwf_Point.PrjName  ==  AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convwf_Point.PrjName);
}
else if (convwf_Point.TabName  ==  AttributeName[intIndex])
{
mstrTabName = value.ToString();
 AddUpdatedFld(convwf_Point.TabName);
}
else if (convwf_Point.TabKeyId  ==  AttributeName[intIndex])
{
mstrTabKeyId = value.ToString();
 AddUpdatedFld(convwf_Point.TabKeyId);
}
else if (convwf_Point.InUse  ==  AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convwf_Point.InUse);
}
else if (convwf_Point.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convwf_Point.UpdDate);
}
else if (convwf_Point.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convwf_Point.UpdUser);
}
else if (convwf_Point.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convwf_Point.Memo);
}
}
}

/// <summary>
/// 结点Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PointId
{
get
{
return mstrPointId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPointId = value;
}
else
{
 mstrPointId = value;
}
//记录修改过的字段
 AddUpdatedFld(convwf_Point.PointId);
}
}
/// <summary>
/// 结点名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PointName
{
get
{
return mstrPointName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPointName = value;
}
else
{
 mstrPointName = value;
}
//记录修改过的字段
 AddUpdatedFld(convwf_Point.PointName);
}
}
/// <summary>
/// 工程ID(说明:;字段类型:char;字段长度:4;是否可空:False)
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
 AddUpdatedFld(convwf_Point.PrjId);
}
}
/// <summary>
/// 工程名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjName
{
get
{
return mstrPrjName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjName = value;
}
else
{
 mstrPrjName = value;
}
//记录修改过的字段
 AddUpdatedFld(convwf_Point.PrjName);
}
}
/// <summary>
/// 表名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabName
{
get
{
return mstrTabName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabName = value;
}
else
{
 mstrTabName = value;
}
//记录修改过的字段
 AddUpdatedFld(convwf_Point.TabName);
}
}
/// <summary>
/// 表关键字Id(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabKeyId
{
get
{
return mstrTabKeyId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabKeyId = value;
}
else
{
 mstrTabKeyId = value;
}
//记录修改过的字段
 AddUpdatedFld(convwf_Point.TabKeyId);
}
}
/// <summary>
/// 是否在用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool InUse
{
get
{
return mbolInUse;
}
set
{
 mbolInUse = value;
//记录修改过的字段
 AddUpdatedFld(convwf_Point.InUse);
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
 AddUpdatedFld(convwf_Point.UpdDate);
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
 AddUpdatedFld(convwf_Point.UpdUser);
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
 AddUpdatedFld(convwf_Point.Memo);
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
  return mstrPointId;
 }
 }
}
 /// <summary>
 /// v工作流结点(vwf_Point)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convwf_Point
{
public new const string _CurrTabName = "vwf_Point"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PointId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PointId", "PointName", "PrjId", "PrjName", "TabName", "TabKeyId", "InUse", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"PointId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PointId = "PointId";    //结点Id

 /// <summary>
 /// 常量:"PointName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PointName = "PointName";    //结点名称

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程ID

 /// <summary>
 /// 常量:"PrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjName = "PrjName";    //工程名称

 /// <summary>
 /// 常量:"TabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabName = "TabName";    //表名

 /// <summary>
 /// 常量:"TabKeyId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabKeyId = "TabKeyId";    //表关键字Id

 /// <summary>
 /// 常量:"InUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InUse = "InUse";    //是否在用

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