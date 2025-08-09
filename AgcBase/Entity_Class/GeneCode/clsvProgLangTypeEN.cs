
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvProgLangTypeEN
 表名:vProgLangType(00050405)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:12:56
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
 /// 表vProgLangType的关键字(ProgLangTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ProgLangTypeId_vProgLangType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strProgLangTypeId">表关键字</param>
public K_ProgLangTypeId_vProgLangType(string strProgLangTypeId)
{
if (IsValid(strProgLangTypeId)) Value = strProgLangTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strProgLangTypeId)
{
if (string.IsNullOrEmpty(strProgLangTypeId) == true) return false;
if (strProgLangTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ProgLangTypeId_vProgLangType]类型的对象</returns>
public static implicit operator K_ProgLangTypeId_vProgLangType(string value)
{
return new K_ProgLangTypeId_vProgLangType(value);
}
}
 /// <summary>
 /// v编程语言类型(vProgLangType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvProgLangTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vProgLangType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ProgLangTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 10;
public static string[] _AttributeName = new string[] {"ProgLangTypeId", "ProgLangTypeName", "ProgLangTypeENName", "CharEncodingId", "CharEncodingName", "IsVisible", "OrderNum", "UpdDate", "UpdUserId", "Memo"};

protected string mstrProgLangTypeId;    //编程语言类型Id
protected string mstrProgLangTypeName;    //编程语言类型名
protected string mstrProgLangTypeENName;    //编程语言类型英文名
protected string mstrCharEncodingId;    //字符编码
protected string mstrCharEncodingName;    //字符编码名称
protected bool mbolIsVisible;    //是否显示
protected int mintOrderNum;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvProgLangTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ProgLangTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strProgLangTypeId">关键字:编程语言类型Id</param>
public clsvProgLangTypeEN(string strProgLangTypeId)
 {
strProgLangTypeId = strProgLangTypeId.Replace("'", "''");
if (strProgLangTypeId.Length > 2)
{
throw new Exception("在表:vProgLangType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strProgLangTypeId)  ==  true)
{
throw new Exception("在表:vProgLangType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strProgLangTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrProgLangTypeId = strProgLangTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ProgLangTypeId");
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
if (strAttributeName  ==  convProgLangType.ProgLangTypeId)
{
return mstrProgLangTypeId;
}
else if (strAttributeName  ==  convProgLangType.ProgLangTypeName)
{
return mstrProgLangTypeName;
}
else if (strAttributeName  ==  convProgLangType.ProgLangTypeENName)
{
return mstrProgLangTypeENName;
}
else if (strAttributeName  ==  convProgLangType.CharEncodingId)
{
return mstrCharEncodingId;
}
else if (strAttributeName  ==  convProgLangType.CharEncodingName)
{
return mstrCharEncodingName;
}
else if (strAttributeName  ==  convProgLangType.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  convProgLangType.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convProgLangType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convProgLangType.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convProgLangType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convProgLangType.ProgLangTypeId)
{
mstrProgLangTypeId = value.ToString();
 AddUpdatedFld(convProgLangType.ProgLangTypeId);
}
else if (strAttributeName  ==  convProgLangType.ProgLangTypeName)
{
mstrProgLangTypeName = value.ToString();
 AddUpdatedFld(convProgLangType.ProgLangTypeName);
}
else if (strAttributeName  ==  convProgLangType.ProgLangTypeENName)
{
mstrProgLangTypeENName = value.ToString();
 AddUpdatedFld(convProgLangType.ProgLangTypeENName);
}
else if (strAttributeName  ==  convProgLangType.CharEncodingId)
{
mstrCharEncodingId = value.ToString();
 AddUpdatedFld(convProgLangType.CharEncodingId);
}
else if (strAttributeName  ==  convProgLangType.CharEncodingName)
{
mstrCharEncodingName = value.ToString();
 AddUpdatedFld(convProgLangType.CharEncodingName);
}
else if (strAttributeName  ==  convProgLangType.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convProgLangType.IsVisible);
}
else if (strAttributeName  ==  convProgLangType.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convProgLangType.OrderNum);
}
else if (strAttributeName  ==  convProgLangType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convProgLangType.UpdDate);
}
else if (strAttributeName  ==  convProgLangType.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convProgLangType.UpdUserId);
}
else if (strAttributeName  ==  convProgLangType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convProgLangType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convProgLangType.ProgLangTypeId  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeId;
}
else if (convProgLangType.ProgLangTypeName  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeName;
}
else if (convProgLangType.ProgLangTypeENName  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeENName;
}
else if (convProgLangType.CharEncodingId  ==  _AttributeName[intIndex])
{
return mstrCharEncodingId;
}
else if (convProgLangType.CharEncodingName  ==  _AttributeName[intIndex])
{
return mstrCharEncodingName;
}
else if (convProgLangType.IsVisible  ==  _AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (convProgLangType.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convProgLangType.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convProgLangType.UpdUserId  ==  _AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convProgLangType.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convProgLangType.ProgLangTypeId  ==  _AttributeName[intIndex])
{
mstrProgLangTypeId = value.ToString();
 AddUpdatedFld(convProgLangType.ProgLangTypeId);
}
else if (convProgLangType.ProgLangTypeName  ==  _AttributeName[intIndex])
{
mstrProgLangTypeName = value.ToString();
 AddUpdatedFld(convProgLangType.ProgLangTypeName);
}
else if (convProgLangType.ProgLangTypeENName  ==  _AttributeName[intIndex])
{
mstrProgLangTypeENName = value.ToString();
 AddUpdatedFld(convProgLangType.ProgLangTypeENName);
}
else if (convProgLangType.CharEncodingId  ==  _AttributeName[intIndex])
{
mstrCharEncodingId = value.ToString();
 AddUpdatedFld(convProgLangType.CharEncodingId);
}
else if (convProgLangType.CharEncodingName  ==  _AttributeName[intIndex])
{
mstrCharEncodingName = value.ToString();
 AddUpdatedFld(convProgLangType.CharEncodingName);
}
else if (convProgLangType.IsVisible  ==  _AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convProgLangType.IsVisible);
}
else if (convProgLangType.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convProgLangType.OrderNum);
}
else if (convProgLangType.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convProgLangType.UpdDate);
}
else if (convProgLangType.UpdUserId  ==  _AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convProgLangType.UpdUserId);
}
else if (convProgLangType.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convProgLangType.Memo);
}
}
}

/// <summary>
/// 编程语言类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLangTypeId
{
get
{
return mstrProgLangTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLangTypeId = value;
}
else
{
 mstrProgLangTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convProgLangType.ProgLangTypeId);
}
}
/// <summary>
/// 编程语言类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLangTypeName
{
get
{
return mstrProgLangTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLangTypeName = value;
}
else
{
 mstrProgLangTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convProgLangType.ProgLangTypeName);
}
}
/// <summary>
/// 编程语言类型英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLangTypeENName
{
get
{
return mstrProgLangTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLangTypeENName = value;
}
else
{
 mstrProgLangTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(convProgLangType.ProgLangTypeENName);
}
}
/// <summary>
/// 字符编码(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CharEncodingId
{
get
{
return mstrCharEncodingId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCharEncodingId = value;
}
else
{
 mstrCharEncodingId = value;
}
//记录修改过的字段
 AddUpdatedFld(convProgLangType.CharEncodingId);
}
}
/// <summary>
/// 字符编码名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CharEncodingName
{
get
{
return mstrCharEncodingName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCharEncodingName = value;
}
else
{
 mstrCharEncodingName = value;
}
//记录修改过的字段
 AddUpdatedFld(convProgLangType.CharEncodingName);
}
}
/// <summary>
/// 是否显示(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsVisible
{
get
{
return mbolIsVisible;
}
set
{
 mbolIsVisible = value;
//记录修改过的字段
 AddUpdatedFld(convProgLangType.IsVisible);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(convProgLangType.OrderNum);
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
 AddUpdatedFld(convProgLangType.UpdDate);
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
 AddUpdatedFld(convProgLangType.UpdUserId);
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
 AddUpdatedFld(convProgLangType.Memo);
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
  return mstrProgLangTypeId;
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
  return mstrProgLangTypeName;
 }
 }
}
 /// <summary>
 /// v编程语言类型(vProgLangType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convProgLangType
{
public const string _CurrTabName = "vProgLangType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ProgLangTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"ProgLangTypeId", "ProgLangTypeName", "ProgLangTypeENName", "CharEncodingId", "CharEncodingName", "IsVisible", "OrderNum", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"ProgLangTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeId = "ProgLangTypeId";    //编程语言类型Id

 /// <summary>
 /// 常量:"ProgLangTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeName = "ProgLangTypeName";    //编程语言类型名

 /// <summary>
 /// 常量:"ProgLangTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeENName = "ProgLangTypeENName";    //编程语言类型英文名

 /// <summary>
 /// 常量:"CharEncodingId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CharEncodingId = "CharEncodingId";    //字符编码

 /// <summary>
 /// 常量:"CharEncodingName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CharEncodingName = "CharEncodingName";    //字符编码名称

 /// <summary>
 /// 常量:"IsVisible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVisible = "IsVisible";    //是否显示

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

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