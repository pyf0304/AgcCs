
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsXzSchoolEN
 表名:XzSchool(00050244)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:06:31
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统设置(SystemSet)
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
 /// 表XzSchool的关键字(IdSchool)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdSchool_XzSchool
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdSchool">表关键字</param>
public K_IdSchool_XzSchool(string strIdSchool)
{
if (IsValid(strIdSchool)) Value = strIdSchool;
else
{
Value = null;
}
}
private static bool IsValid(string strIdSchool)
{
if (string.IsNullOrEmpty(strIdSchool) == true) return false;
if (strIdSchool.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdSchool_XzSchool]类型的对象</returns>
public static implicit operator K_IdSchool_XzSchool(string value)
{
return new K_IdSchool_XzSchool(value);
}
}
 /// <summary>
 /// 学校(XzSchool)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsXzSchoolEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "XzSchool"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdSchool"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 10;
public static string[] _AttributeName = new string[] {"IdSchool", "SchoolId", "SchoolName", "IsCurrentUse", "SchoolENName", "SchoolNameA", "SchoolTypeId", "UpdDate", "UpdUserId", "Memo"};

protected string mstrIdSchool;    //学校流水号
protected string mstrSchoolId;    //学校Id
protected string mstrSchoolName;    //学校名称
protected bool mbolIsCurrentUse;    //是否当前使用
protected string mstrSchoolENName;    //学校英文名
protected string mstrSchoolNameA;    //学校简称
protected string mstrSchoolTypeId;    //学校类型Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsXzSchoolEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdSchool");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strIdSchool">关键字:学校流水号</param>
public clsXzSchoolEN(string strIdSchool)
 {
strIdSchool = strIdSchool.Replace("'", "''");
if (strIdSchool.Length > 4)
{
throw new Exception("在表:XzSchool中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdSchool)  ==  true)
{
throw new Exception("在表:XzSchool中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdSchool);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdSchool = strIdSchool;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdSchool");
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
if (strAttributeName  ==  conXzSchool.IdSchool)
{
return mstrIdSchool;
}
else if (strAttributeName  ==  conXzSchool.SchoolId)
{
return mstrSchoolId;
}
else if (strAttributeName  ==  conXzSchool.SchoolName)
{
return mstrSchoolName;
}
else if (strAttributeName  ==  conXzSchool.IsCurrentUse)
{
return mbolIsCurrentUse;
}
else if (strAttributeName  ==  conXzSchool.SchoolENName)
{
return mstrSchoolENName;
}
else if (strAttributeName  ==  conXzSchool.SchoolNameA)
{
return mstrSchoolNameA;
}
else if (strAttributeName  ==  conXzSchool.SchoolTypeId)
{
return mstrSchoolTypeId;
}
else if (strAttributeName  ==  conXzSchool.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conXzSchool.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conXzSchool.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conXzSchool.IdSchool)
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(conXzSchool.IdSchool);
}
else if (strAttributeName  ==  conXzSchool.SchoolId)
{
mstrSchoolId = value.ToString();
 AddUpdatedFld(conXzSchool.SchoolId);
}
else if (strAttributeName  ==  conXzSchool.SchoolName)
{
mstrSchoolName = value.ToString();
 AddUpdatedFld(conXzSchool.SchoolName);
}
else if (strAttributeName  ==  conXzSchool.IsCurrentUse)
{
mbolIsCurrentUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conXzSchool.IsCurrentUse);
}
else if (strAttributeName  ==  conXzSchool.SchoolENName)
{
mstrSchoolENName = value.ToString();
 AddUpdatedFld(conXzSchool.SchoolENName);
}
else if (strAttributeName  ==  conXzSchool.SchoolNameA)
{
mstrSchoolNameA = value.ToString();
 AddUpdatedFld(conXzSchool.SchoolNameA);
}
else if (strAttributeName  ==  conXzSchool.SchoolTypeId)
{
mstrSchoolTypeId = value.ToString();
 AddUpdatedFld(conXzSchool.SchoolTypeId);
}
else if (strAttributeName  ==  conXzSchool.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conXzSchool.UpdDate);
}
else if (strAttributeName  ==  conXzSchool.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conXzSchool.UpdUserId);
}
else if (strAttributeName  ==  conXzSchool.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conXzSchool.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conXzSchool.IdSchool  ==  _AttributeName[intIndex])
{
return mstrIdSchool;
}
else if (conXzSchool.SchoolId  ==  _AttributeName[intIndex])
{
return mstrSchoolId;
}
else if (conXzSchool.SchoolName  ==  _AttributeName[intIndex])
{
return mstrSchoolName;
}
else if (conXzSchool.IsCurrentUse  ==  _AttributeName[intIndex])
{
return mbolIsCurrentUse;
}
else if (conXzSchool.SchoolENName  ==  _AttributeName[intIndex])
{
return mstrSchoolENName;
}
else if (conXzSchool.SchoolNameA  ==  _AttributeName[intIndex])
{
return mstrSchoolNameA;
}
else if (conXzSchool.SchoolTypeId  ==  _AttributeName[intIndex])
{
return mstrSchoolTypeId;
}
else if (conXzSchool.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conXzSchool.UpdUserId  ==  _AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conXzSchool.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conXzSchool.IdSchool  ==  _AttributeName[intIndex])
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(conXzSchool.IdSchool);
}
else if (conXzSchool.SchoolId  ==  _AttributeName[intIndex])
{
mstrSchoolId = value.ToString();
 AddUpdatedFld(conXzSchool.SchoolId);
}
else if (conXzSchool.SchoolName  ==  _AttributeName[intIndex])
{
mstrSchoolName = value.ToString();
 AddUpdatedFld(conXzSchool.SchoolName);
}
else if (conXzSchool.IsCurrentUse  ==  _AttributeName[intIndex])
{
mbolIsCurrentUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conXzSchool.IsCurrentUse);
}
else if (conXzSchool.SchoolENName  ==  _AttributeName[intIndex])
{
mstrSchoolENName = value.ToString();
 AddUpdatedFld(conXzSchool.SchoolENName);
}
else if (conXzSchool.SchoolNameA  ==  _AttributeName[intIndex])
{
mstrSchoolNameA = value.ToString();
 AddUpdatedFld(conXzSchool.SchoolNameA);
}
else if (conXzSchool.SchoolTypeId  ==  _AttributeName[intIndex])
{
mstrSchoolTypeId = value.ToString();
 AddUpdatedFld(conXzSchool.SchoolTypeId);
}
else if (conXzSchool.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conXzSchool.UpdDate);
}
else if (conXzSchool.UpdUserId  ==  _AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conXzSchool.UpdUserId);
}
else if (conXzSchool.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conXzSchool.Memo);
}
}
}

/// <summary>
/// 学校流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdSchool
{
get
{
return mstrIdSchool;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdSchool = value;
}
else
{
 mstrIdSchool = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzSchool.IdSchool);
}
}
/// <summary>
/// 学校Id(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchoolId
{
get
{
return mstrSchoolId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchoolId = value;
}
else
{
 mstrSchoolId = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzSchool.SchoolId);
}
}
/// <summary>
/// 学校名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchoolName
{
get
{
return mstrSchoolName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchoolName = value;
}
else
{
 mstrSchoolName = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzSchool.SchoolName);
}
}
/// <summary>
/// 是否当前使用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsCurrentUse
{
get
{
return mbolIsCurrentUse;
}
set
{
 mbolIsCurrentUse = value;
//记录修改过的字段
 AddUpdatedFld(conXzSchool.IsCurrentUse);
}
}
/// <summary>
/// 学校英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchoolENName
{
get
{
return mstrSchoolENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchoolENName = value;
}
else
{
 mstrSchoolENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzSchool.SchoolENName);
}
}
/// <summary>
/// 学校简称(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchoolNameA
{
get
{
return mstrSchoolNameA;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchoolNameA = value;
}
else
{
 mstrSchoolNameA = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzSchool.SchoolNameA);
}
}
/// <summary>
/// 学校类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchoolTypeId
{
get
{
return mstrSchoolTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchoolTypeId = value;
}
else
{
 mstrSchoolTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzSchool.SchoolTypeId);
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
 AddUpdatedFld(conXzSchool.UpdDate);
}
}
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUserId
{
get
{
return mstrUpdUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUserId = value;
}
else
{
 mstrUpdUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzSchool.UpdUserId);
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
 AddUpdatedFld(conXzSchool.Memo);
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
  return mstrIdSchool;
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
  return mstrSchoolName;
 }
 }
}
 /// <summary>
 /// 学校(XzSchool)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conXzSchool
{
public const string _CurrTabName = "XzSchool"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdSchool"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"IdSchool", "SchoolId", "SchoolName", "IsCurrentUse", "SchoolENName", "SchoolNameA", "SchoolTypeId", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdSchool"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSchool = "IdSchool";    //学校流水号

 /// <summary>
 /// 常量:"SchoolId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolId = "SchoolId";    //学校Id

 /// <summary>
 /// 常量:"SchoolName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolName = "SchoolName";    //学校名称

 /// <summary>
 /// 常量:"IsCurrentUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsCurrentUse = "IsCurrentUse";    //是否当前使用

 /// <summary>
 /// 常量:"SchoolENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolENName = "SchoolENName";    //学校英文名

 /// <summary>
 /// 常量:"SchoolNameA"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolNameA = "SchoolNameA";    //学校简称

 /// <summary>
 /// 常量:"SchoolTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolTypeId = "SchoolTypeId";    //学校类型Id

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}