
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsGCPathEN
 表名:GCPath(00050595)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:08:34
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
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
 /// 表GCPath的关键字(GcPathId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_GcPathId_GCPath
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strGcPathId">表关键字</param>
public K_GcPathId_GCPath(string strGcPathId)
{
if (IsValid(strGcPathId)) Value = strGcPathId;
else
{
Value = null;
}
}
private static bool IsValid(string strGcPathId)
{
if (string.IsNullOrEmpty(strGcPathId) == true) return false;
if (strGcPathId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_GcPathId_GCPath]类型的对象</returns>
public static implicit operator K_GcPathId_GCPath(string value)
{
return new K_GcPathId_GCPath(value);
}
}
 /// <summary>
 /// GC路径(GCPath)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsGCPathEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "GCPath"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "GcPathId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 8;
public static string[] _AttributeName = new string[] {"GcPathId", "GcPathName", "IsForMainPath", "UserId", "PrjId", "UpdDate", "UpdUser", "Memo"};

protected string mstrGcPathId;    //GC路径Id
protected string mstrGcPathName;    //GC路径名
protected bool mbolIsForMainPath;    //是否For主目录
protected string mstrUserId;    //用户Id
protected string mstrPrjId;    //工程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsGCPathEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("GcPathId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strGcPathId">关键字:GC路径Id</param>
public clsGCPathEN(string strGcPathId)
 {
strGcPathId = strGcPathId.Replace("'", "''");
if (strGcPathId.Length > 8)
{
throw new Exception("在表:GCPath中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strGcPathId)  ==  true)
{
throw new Exception("在表:GCPath中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strGcPathId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrGcPathId = strGcPathId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("GcPathId");
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
if (strAttributeName  ==  conGCPath.GcPathId)
{
return mstrGcPathId;
}
else if (strAttributeName  ==  conGCPath.GcPathName)
{
return mstrGcPathName;
}
else if (strAttributeName  ==  conGCPath.IsForMainPath)
{
return mbolIsForMainPath;
}
else if (strAttributeName  ==  conGCPath.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conGCPath.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conGCPath.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conGCPath.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conGCPath.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conGCPath.GcPathId)
{
mstrGcPathId = value.ToString();
 AddUpdatedFld(conGCPath.GcPathId);
}
else if (strAttributeName  ==  conGCPath.GcPathName)
{
mstrGcPathName = value.ToString();
 AddUpdatedFld(conGCPath.GcPathName);
}
else if (strAttributeName  ==  conGCPath.IsForMainPath)
{
mbolIsForMainPath = TransNullToBool(value.ToString());
 AddUpdatedFld(conGCPath.IsForMainPath);
}
else if (strAttributeName  ==  conGCPath.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conGCPath.UserId);
}
else if (strAttributeName  ==  conGCPath.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conGCPath.PrjId);
}
else if (strAttributeName  ==  conGCPath.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conGCPath.UpdDate);
}
else if (strAttributeName  ==  conGCPath.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conGCPath.UpdUser);
}
else if (strAttributeName  ==  conGCPath.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conGCPath.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conGCPath.GcPathId  ==  _AttributeName[intIndex])
{
return mstrGcPathId;
}
else if (conGCPath.GcPathName  ==  _AttributeName[intIndex])
{
return mstrGcPathName;
}
else if (conGCPath.IsForMainPath  ==  _AttributeName[intIndex])
{
return mbolIsForMainPath;
}
else if (conGCPath.UserId  ==  _AttributeName[intIndex])
{
return mstrUserId;
}
else if (conGCPath.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conGCPath.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conGCPath.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conGCPath.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conGCPath.GcPathId  ==  _AttributeName[intIndex])
{
mstrGcPathId = value.ToString();
 AddUpdatedFld(conGCPath.GcPathId);
}
else if (conGCPath.GcPathName  ==  _AttributeName[intIndex])
{
mstrGcPathName = value.ToString();
 AddUpdatedFld(conGCPath.GcPathName);
}
else if (conGCPath.IsForMainPath  ==  _AttributeName[intIndex])
{
mbolIsForMainPath = TransNullToBool(value.ToString());
 AddUpdatedFld(conGCPath.IsForMainPath);
}
else if (conGCPath.UserId  ==  _AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conGCPath.UserId);
}
else if (conGCPath.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conGCPath.PrjId);
}
else if (conGCPath.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conGCPath.UpdDate);
}
else if (conGCPath.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conGCPath.UpdUser);
}
else if (conGCPath.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conGCPath.Memo);
}
}
}

/// <summary>
/// GC路径Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GcPathId
{
get
{
return mstrGcPathId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGcPathId = value;
}
else
{
 mstrGcPathId = value;
}
//记录修改过的字段
 AddUpdatedFld(conGCPath.GcPathId);
}
}
/// <summary>
/// GC路径名(说明:;字段类型:varchar;字段长度:150;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GcPathName
{
get
{
return mstrGcPathName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGcPathName = value;
}
else
{
 mstrGcPathName = value;
}
//记录修改过的字段
 AddUpdatedFld(conGCPath.GcPathName);
}
}
/// <summary>
/// 是否For主目录(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsForMainPath
{
get
{
return mbolIsForMainPath;
}
set
{
 mbolIsForMainPath = value;
//记录修改过的字段
 AddUpdatedFld(conGCPath.IsForMainPath);
}
}
/// <summary>
/// 用户Id(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserId
{
get
{
return mstrUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserId = value;
}
else
{
 mstrUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conGCPath.UserId);
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
 AddUpdatedFld(conGCPath.PrjId);
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
 AddUpdatedFld(conGCPath.UpdDate);
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
 AddUpdatedFld(conGCPath.UpdUser);
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
 AddUpdatedFld(conGCPath.Memo);
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
  return mstrGcPathId;
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
  return mstrGcPathName;
 }
 }
}
 /// <summary>
 /// GC路径(GCPath)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conGCPath
{
public const string _CurrTabName = "GCPath"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "GcPathId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"GcPathId", "GcPathName", "IsForMainPath", "UserId", "PrjId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"GcPathId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GcPathId = "GcPathId";    //GC路径Id

 /// <summary>
 /// 常量:"GcPathName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GcPathName = "GcPathName";    //GC路径名

 /// <summary>
 /// 常量:"IsForMainPath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsForMainPath = "IsForMainPath";    //是否For主目录

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户Id

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

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