
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCodeSegmentEN
 表名:CodeSegment(00050436)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:12:24
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
 /// 表CodeSegment的关键字(CodeSegmentId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CodeSegmentId_CodeSegment
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strCodeSegmentId">表关键字</param>
public K_CodeSegmentId_CodeSegment(string strCodeSegmentId)
{
if (IsValid(strCodeSegmentId)) Value = strCodeSegmentId;
else
{
Value = null;
}
}
private static bool IsValid(string strCodeSegmentId)
{
if (string.IsNullOrEmpty(strCodeSegmentId) == true) return false;
if (strCodeSegmentId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_CodeSegmentId_CodeSegment]类型的对象</returns>
public static implicit operator K_CodeSegmentId_CodeSegment(string value)
{
return new K_CodeSegmentId_CodeSegment(value);
}
}
 /// <summary>
 /// 代码段(CodeSegment)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCodeSegmentEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CodeSegment"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "CodeSegmentId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 7;
public static string[] _AttributeName = new string[] {"CodeSegmentId", "CodeSegmentName", "CodeLines", "ParaName", "UpdDate", "UpdUser", "Memo"};

protected string mstrCodeSegmentId;    //代码段Id
protected string mstrCodeSegmentName;    //代码段名
protected string mstrCodeLines;    //代码行
protected string mstrParaName;    //参数名
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsCodeSegmentEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CodeSegmentId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strCodeSegmentId">关键字:代码段Id</param>
public clsCodeSegmentEN(string strCodeSegmentId)
 {
strCodeSegmentId = strCodeSegmentId.Replace("'", "''");
if (strCodeSegmentId.Length > 8)
{
throw new Exception("在表:CodeSegment中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strCodeSegmentId)  ==  true)
{
throw new Exception("在表:CodeSegment中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCodeSegmentId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrCodeSegmentId = strCodeSegmentId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CodeSegmentId");
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
if (strAttributeName  ==  conCodeSegment.CodeSegmentId)
{
return mstrCodeSegmentId;
}
else if (strAttributeName  ==  conCodeSegment.CodeSegmentName)
{
return mstrCodeSegmentName;
}
else if (strAttributeName  ==  conCodeSegment.CodeLines)
{
return mstrCodeLines;
}
else if (strAttributeName  ==  conCodeSegment.ParaName)
{
return mstrParaName;
}
else if (strAttributeName  ==  conCodeSegment.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conCodeSegment.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conCodeSegment.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conCodeSegment.CodeSegmentId)
{
mstrCodeSegmentId = value.ToString();
 AddUpdatedFld(conCodeSegment.CodeSegmentId);
}
else if (strAttributeName  ==  conCodeSegment.CodeSegmentName)
{
mstrCodeSegmentName = value.ToString();
 AddUpdatedFld(conCodeSegment.CodeSegmentName);
}
else if (strAttributeName  ==  conCodeSegment.CodeLines)
{
mstrCodeLines = value.ToString();
 AddUpdatedFld(conCodeSegment.CodeLines);
}
else if (strAttributeName  ==  conCodeSegment.ParaName)
{
mstrParaName = value.ToString();
 AddUpdatedFld(conCodeSegment.ParaName);
}
else if (strAttributeName  ==  conCodeSegment.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCodeSegment.UpdDate);
}
else if (strAttributeName  ==  conCodeSegment.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conCodeSegment.UpdUser);
}
else if (strAttributeName  ==  conCodeSegment.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCodeSegment.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conCodeSegment.CodeSegmentId  ==  _AttributeName[intIndex])
{
return mstrCodeSegmentId;
}
else if (conCodeSegment.CodeSegmentName  ==  _AttributeName[intIndex])
{
return mstrCodeSegmentName;
}
else if (conCodeSegment.CodeLines  ==  _AttributeName[intIndex])
{
return mstrCodeLines;
}
else if (conCodeSegment.ParaName  ==  _AttributeName[intIndex])
{
return mstrParaName;
}
else if (conCodeSegment.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conCodeSegment.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conCodeSegment.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conCodeSegment.CodeSegmentId  ==  _AttributeName[intIndex])
{
mstrCodeSegmentId = value.ToString();
 AddUpdatedFld(conCodeSegment.CodeSegmentId);
}
else if (conCodeSegment.CodeSegmentName  ==  _AttributeName[intIndex])
{
mstrCodeSegmentName = value.ToString();
 AddUpdatedFld(conCodeSegment.CodeSegmentName);
}
else if (conCodeSegment.CodeLines  ==  _AttributeName[intIndex])
{
mstrCodeLines = value.ToString();
 AddUpdatedFld(conCodeSegment.CodeLines);
}
else if (conCodeSegment.ParaName  ==  _AttributeName[intIndex])
{
mstrParaName = value.ToString();
 AddUpdatedFld(conCodeSegment.ParaName);
}
else if (conCodeSegment.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCodeSegment.UpdDate);
}
else if (conCodeSegment.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conCodeSegment.UpdUser);
}
else if (conCodeSegment.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCodeSegment.Memo);
}
}
}

/// <summary>
/// 代码段Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeSegmentId
{
get
{
return mstrCodeSegmentId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeSegmentId = value;
}
else
{
 mstrCodeSegmentId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCodeSegment.CodeSegmentId);
}
}
/// <summary>
/// 代码段名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeSegmentName
{
get
{
return mstrCodeSegmentName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeSegmentName = value;
}
else
{
 mstrCodeSegmentName = value;
}
//记录修改过的字段
 AddUpdatedFld(conCodeSegment.CodeSegmentName);
}
}
/// <summary>
/// 代码行(说明:;字段类型:varchar;字段长度:4000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeLines
{
get
{
return mstrCodeLines;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeLines = value;
}
else
{
 mstrCodeLines = value;
}
//记录修改过的字段
 AddUpdatedFld(conCodeSegment.CodeLines);
}
}
/// <summary>
/// 参数名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParaName
{
get
{
return mstrParaName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParaName = value;
}
else
{
 mstrParaName = value;
}
//记录修改过的字段
 AddUpdatedFld(conCodeSegment.ParaName);
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
 AddUpdatedFld(conCodeSegment.UpdDate);
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
 AddUpdatedFld(conCodeSegment.UpdUser);
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
 AddUpdatedFld(conCodeSegment.Memo);
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
  return mstrCodeSegmentId;
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
  return mstrCodeSegmentName;
 }
 }
}
 /// <summary>
 /// 代码段(CodeSegment)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCodeSegment
{
public const string _CurrTabName = "CodeSegment"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CodeSegmentId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"CodeSegmentId", "CodeSegmentName", "CodeLines", "ParaName", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"CodeSegmentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeSegmentId = "CodeSegmentId";    //代码段Id

 /// <summary>
 /// 常量:"CodeSegmentName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeSegmentName = "CodeSegmentName";    //代码段名

 /// <summary>
 /// 常量:"CodeLines"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeLines = "CodeLines";    //代码行

 /// <summary>
 /// 常量:"ParaName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParaName = "ParaName";    //参数名

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