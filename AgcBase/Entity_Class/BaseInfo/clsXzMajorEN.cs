
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsXzMajorEN
 表名:XzMajor(00050536)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:37:22
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:基本信息(BaseInfo)
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
 /// 表XzMajor的关键字(IdMajor)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdMajor_XzMajor
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdMajor">表关键字</param>
public K_IdMajor_XzMajor(string strIdMajor)
{
if (IsValid(strIdMajor)) Value = strIdMajor;
else
{
Value = null;
}
}
private static bool IsValid(string strIdMajor)
{
if (string.IsNullOrEmpty(strIdMajor) == true) return false;
if (strIdMajor.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdMajor_XzMajor]类型的对象</returns>
public static implicit operator K_IdMajor_XzMajor(string value)
{
return new K_IdMajor_XzMajor(value);
}
}
 /// <summary>
 /// 专业(XzMajor)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsXzMajorEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "XzMajor"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdMajor"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 9;
public static string[] _AttributeName = new string[] {"IdMajor", "MajorID", "MajorName", "IsMainMajor", "CollegeId", "OrderNum", "InUse", "UpdDate", "UpdUser"};

protected string mstrIdMajor;    //专业流水号
protected string mstrMajorID;    //MajorID
protected string mstrMajorName;    //专业名称
protected bool mbolIsMainMajor;    //是否重要专业
protected string mstrCollegeId;    //学院Id
protected int? mintOrderNum;    //序号
protected bool mbolInUse;    //是否在用
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsXzMajorEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdMajor");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strIdMajor">关键字:专业流水号</param>
public clsXzMajorEN(string strIdMajor)
 {
strIdMajor = strIdMajor.Replace("'", "''");
if (strIdMajor.Length > 8)
{
throw new Exception("在表:XzMajor中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdMajor)  ==  true)
{
throw new Exception("在表:XzMajor中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdMajor);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdMajor = strIdMajor;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdMajor");
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
if (strAttributeName  ==  conXzMajor.IdMajor)
{
return mstrIdMajor;
}
else if (strAttributeName  ==  conXzMajor.MajorID)
{
return mstrMajorID;
}
else if (strAttributeName  ==  conXzMajor.MajorName)
{
return mstrMajorName;
}
else if (strAttributeName  ==  conXzMajor.IsMainMajor)
{
return mbolIsMainMajor;
}
else if (strAttributeName  ==  conXzMajor.CollegeId)
{
return mstrCollegeId;
}
else if (strAttributeName  ==  conXzMajor.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conXzMajor.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  conXzMajor.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conXzMajor.UpdUser)
{
return mstrUpdUser;
}
return null;
}
set
{
if (strAttributeName  ==  conXzMajor.IdMajor)
{
mstrIdMajor = value.ToString();
 AddUpdatedFld(conXzMajor.IdMajor);
}
else if (strAttributeName  ==  conXzMajor.MajorID)
{
mstrMajorID = value.ToString();
 AddUpdatedFld(conXzMajor.MajorID);
}
else if (strAttributeName  ==  conXzMajor.MajorName)
{
mstrMajorName = value.ToString();
 AddUpdatedFld(conXzMajor.MajorName);
}
else if (strAttributeName  ==  conXzMajor.IsMainMajor)
{
mbolIsMainMajor = TransNullToBool(value.ToString());
 AddUpdatedFld(conXzMajor.IsMainMajor);
}
else if (strAttributeName  ==  conXzMajor.CollegeId)
{
mstrCollegeId = value.ToString();
 AddUpdatedFld(conXzMajor.CollegeId);
}
else if (strAttributeName  ==  conXzMajor.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conXzMajor.OrderNum);
}
else if (strAttributeName  ==  conXzMajor.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conXzMajor.InUse);
}
else if (strAttributeName  ==  conXzMajor.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conXzMajor.UpdDate);
}
else if (strAttributeName  ==  conXzMajor.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conXzMajor.UpdUser);
}
}
}
public object this[int intIndex]
{
get
{
if (conXzMajor.IdMajor  ==  _AttributeName[intIndex])
{
return mstrIdMajor;
}
else if (conXzMajor.MajorID  ==  _AttributeName[intIndex])
{
return mstrMajorID;
}
else if (conXzMajor.MajorName  ==  _AttributeName[intIndex])
{
return mstrMajorName;
}
else if (conXzMajor.IsMainMajor  ==  _AttributeName[intIndex])
{
return mbolIsMainMajor;
}
else if (conXzMajor.CollegeId  ==  _AttributeName[intIndex])
{
return mstrCollegeId;
}
else if (conXzMajor.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conXzMajor.InUse  ==  _AttributeName[intIndex])
{
return mbolInUse;
}
else if (conXzMajor.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conXzMajor.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
return null;
}
set
{
if (conXzMajor.IdMajor  ==  _AttributeName[intIndex])
{
mstrIdMajor = value.ToString();
 AddUpdatedFld(conXzMajor.IdMajor);
}
else if (conXzMajor.MajorID  ==  _AttributeName[intIndex])
{
mstrMajorID = value.ToString();
 AddUpdatedFld(conXzMajor.MajorID);
}
else if (conXzMajor.MajorName  ==  _AttributeName[intIndex])
{
mstrMajorName = value.ToString();
 AddUpdatedFld(conXzMajor.MajorName);
}
else if (conXzMajor.IsMainMajor  ==  _AttributeName[intIndex])
{
mbolIsMainMajor = TransNullToBool(value.ToString());
 AddUpdatedFld(conXzMajor.IsMainMajor);
}
else if (conXzMajor.CollegeId  ==  _AttributeName[intIndex])
{
mstrCollegeId = value.ToString();
 AddUpdatedFld(conXzMajor.CollegeId);
}
else if (conXzMajor.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conXzMajor.OrderNum);
}
else if (conXzMajor.InUse  ==  _AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conXzMajor.InUse);
}
else if (conXzMajor.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conXzMajor.UpdDate);
}
else if (conXzMajor.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conXzMajor.UpdUser);
}
}
}

/// <summary>
/// 专业流水号(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdMajor
{
get
{
return mstrIdMajor;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdMajor = value;
}
else
{
 mstrIdMajor = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzMajor.IdMajor);
}
}
/// <summary>
/// MajorID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MajorID
{
get
{
return mstrMajorID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajorID = value;
}
else
{
 mstrMajorID = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzMajor.MajorID);
}
}
/// <summary>
/// 专业名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MajorName
{
get
{
return mstrMajorName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajorName = value;
}
else
{
 mstrMajorName = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzMajor.MajorName);
}
}
/// <summary>
/// 是否重要专业(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsMainMajor
{
get
{
return mbolIsMainMajor;
}
set
{
 mbolIsMainMajor = value;
//记录修改过的字段
 AddUpdatedFld(conXzMajor.IsMainMajor);
}
}
/// <summary>
/// 学院Id(说明:;字段类型:varchar;字段长度:6;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CollegeId
{
get
{
return mstrCollegeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCollegeId = value;
}
else
{
 mstrCollegeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzMajor.CollegeId);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(conXzMajor.OrderNum);
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
 AddUpdatedFld(conXzMajor.InUse);
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
 AddUpdatedFld(conXzMajor.UpdDate);
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
 AddUpdatedFld(conXzMajor.UpdUser);
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
  return mstrIdMajor;
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
  return mstrMajorName;
 }
 }
}
 /// <summary>
 /// 专业(XzMajor)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conXzMajor
{
public const string _CurrTabName = "XzMajor"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdMajor"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"IdMajor", "MajorID", "MajorName", "IsMainMajor", "CollegeId", "OrderNum", "InUse", "UpdDate", "UpdUser"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdMajor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdMajor = "IdMajor";    //专业流水号

 /// <summary>
 /// 常量:"MajorID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorID = "MajorID";    //MajorID

 /// <summary>
 /// 常量:"MajorName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorName = "MajorName";    //专业名称

 /// <summary>
 /// 常量:"IsMainMajor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsMainMajor = "IsMainMajor";    //是否重要专业

 /// <summary>
 /// 常量:"CollegeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeId = "CollegeId";    //学院Id

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

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
}

}