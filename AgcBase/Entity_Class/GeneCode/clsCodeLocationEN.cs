
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCodeLocationEN
 表名:CodeLocation(00050438)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:05:07
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
 /// 表CodeLocation的关键字(CodeLocId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CodeLocId_CodeLocation
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strCodeLocId">表关键字</param>
public K_CodeLocId_CodeLocation(string strCodeLocId)
{
if (IsValid(strCodeLocId)) Value = strCodeLocId;
else
{
Value = null;
}
}
private static bool IsValid(string strCodeLocId)
{
if (string.IsNullOrEmpty(strCodeLocId) == true) return false;
if (strCodeLocId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_CodeLocId_CodeLocation]类型的对象</returns>
public static implicit operator K_CodeLocId_CodeLocation(string value)
{
return new K_CodeLocId_CodeLocation(value);
}
}
 /// <summary>
 /// 代码位置(CodeLocation)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCodeLocationEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CodeLocation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "CodeLocId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 5;
public static string[] _AttributeName = new string[] {"CodeLocId", "CodeLocName", "UpdDate", "UpdUser", "Memo"};

protected string mstrCodeLocId;    //代码位置Id
protected string mstrCodeLocName;    //代码位置名
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsCodeLocationEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CodeLocId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strCodeLocId">关键字:代码位置Id</param>
public clsCodeLocationEN(string strCodeLocId)
 {
strCodeLocId = strCodeLocId.Replace("'", "''");
if (strCodeLocId.Length > 4)
{
throw new Exception("在表:CodeLocation中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strCodeLocId)  ==  true)
{
throw new Exception("在表:CodeLocation中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCodeLocId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrCodeLocId = strCodeLocId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CodeLocId");
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
if (strAttributeName  ==  conCodeLocation.CodeLocId)
{
return mstrCodeLocId;
}
else if (strAttributeName  ==  conCodeLocation.CodeLocName)
{
return mstrCodeLocName;
}
else if (strAttributeName  ==  conCodeLocation.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conCodeLocation.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conCodeLocation.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conCodeLocation.CodeLocId)
{
mstrCodeLocId = value.ToString();
 AddUpdatedFld(conCodeLocation.CodeLocId);
}
else if (strAttributeName  ==  conCodeLocation.CodeLocName)
{
mstrCodeLocName = value.ToString();
 AddUpdatedFld(conCodeLocation.CodeLocName);
}
else if (strAttributeName  ==  conCodeLocation.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCodeLocation.UpdDate);
}
else if (strAttributeName  ==  conCodeLocation.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conCodeLocation.UpdUser);
}
else if (strAttributeName  ==  conCodeLocation.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCodeLocation.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conCodeLocation.CodeLocId  ==  _AttributeName[intIndex])
{
return mstrCodeLocId;
}
else if (conCodeLocation.CodeLocName  ==  _AttributeName[intIndex])
{
return mstrCodeLocName;
}
else if (conCodeLocation.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conCodeLocation.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conCodeLocation.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conCodeLocation.CodeLocId  ==  _AttributeName[intIndex])
{
mstrCodeLocId = value.ToString();
 AddUpdatedFld(conCodeLocation.CodeLocId);
}
else if (conCodeLocation.CodeLocName  ==  _AttributeName[intIndex])
{
mstrCodeLocName = value.ToString();
 AddUpdatedFld(conCodeLocation.CodeLocName);
}
else if (conCodeLocation.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCodeLocation.UpdDate);
}
else if (conCodeLocation.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conCodeLocation.UpdUser);
}
else if (conCodeLocation.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCodeLocation.Memo);
}
}
}

/// <summary>
/// 代码位置Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeLocId
{
get
{
return mstrCodeLocId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeLocId = value;
}
else
{
 mstrCodeLocId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCodeLocation.CodeLocId);
}
}
/// <summary>
/// 代码位置名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeLocName
{
get
{
return mstrCodeLocName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeLocName = value;
}
else
{
 mstrCodeLocName = value;
}
//记录修改过的字段
 AddUpdatedFld(conCodeLocation.CodeLocName);
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
 AddUpdatedFld(conCodeLocation.UpdDate);
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
 AddUpdatedFld(conCodeLocation.UpdUser);
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
 AddUpdatedFld(conCodeLocation.Memo);
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
  return mstrCodeLocId;
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
  return mstrCodeLocName;
 }
 }
}
 /// <summary>
 /// 代码位置(CodeLocation)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCodeLocation
{
public const string _CurrTabName = "CodeLocation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CodeLocId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"CodeLocId", "CodeLocName", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"CodeLocId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeLocId = "CodeLocId";    //代码位置Id

 /// <summary>
 /// 常量:"CodeLocName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeLocName = "CodeLocName";    //代码位置名

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