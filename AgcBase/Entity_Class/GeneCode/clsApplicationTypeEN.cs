
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsApplicationTypeEN
 表名:ApplicationType(00050127)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:31:41
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
 /// 表ApplicationType的关键字(ApplicationTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ApplicationTypeId_ApplicationType
{
private int _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public int Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="intApplicationTypeId">表关键字</param>
public K_ApplicationTypeId_ApplicationType(int intApplicationTypeId)
{
if (IsValid(intApplicationTypeId)) Value = intApplicationTypeId;
else
{
Value = 0;
}
}
private static bool IsValid(int intApplicationTypeId)
{
if (intApplicationTypeId == 0) return false;
if (intApplicationTypeId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ApplicationTypeId_ApplicationType]类型的对象</returns>
public static implicit operator K_ApplicationTypeId_ApplicationType(int value)
{
return new K_ApplicationTypeId_ApplicationType(value);
}
}
 /// <summary>
 /// 应用程序类型(ApplicationType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsApplicationTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ApplicationType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ApplicationTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 13;
public static string[] _AttributeName = new string[] {"ApplicationTypeId", "ApplicationTypeName", "ApplicationTypeSimName", "ApplicationTypeENName", "ProgLangTypeId", "ProgLangTypeId2", "ProgLangTypeId3", "ProgLangTypeId4", "ProgLangTypeId5", "IsVisible", "VisitedNum", "OrderNum", "Memo"};

protected int mintApplicationTypeId;    //应用程序类型ID
protected string mstrApplicationTypeName;    //应用程序类型名称
protected string mstrApplicationTypeSimName;    //应用程序类型简称
protected string mstrApplicationTypeENName;    //应用类型英文名
protected string mstrProgLangTypeId;    //编程语言类型Id
protected string mstrProgLangTypeId2;    //编程语言类型Id2
protected string mstrProgLangTypeId3;    //编程语言类型Id3
protected string mstrProgLangTypeId4;    //编程语言类型Id4
protected string mstrProgLangTypeId5;    //编程语言类型Id5
protected bool mbolIsVisible;    //是否显示
protected int? mintVisitedNum;    //访问数
protected int mintOrderNum;    //序号
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsApplicationTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ApplicationTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "intApplicationTypeId">关键字:应用程序类型ID</param>
public clsApplicationTypeEN(int intApplicationTypeId)
 {
 if (intApplicationTypeId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mintApplicationTypeId = intApplicationTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ApplicationTypeId");
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
if (strAttributeName  ==  conApplicationType.ApplicationTypeId)
{
return mintApplicationTypeId;
}
else if (strAttributeName  ==  conApplicationType.ApplicationTypeName)
{
return mstrApplicationTypeName;
}
else if (strAttributeName  ==  conApplicationType.ApplicationTypeSimName)
{
return mstrApplicationTypeSimName;
}
else if (strAttributeName  ==  conApplicationType.ApplicationTypeENName)
{
return mstrApplicationTypeENName;
}
else if (strAttributeName  ==  conApplicationType.ProgLangTypeId)
{
return mstrProgLangTypeId;
}
else if (strAttributeName  ==  conApplicationType.ProgLangTypeId2)
{
return mstrProgLangTypeId2;
}
else if (strAttributeName  ==  conApplicationType.ProgLangTypeId3)
{
return mstrProgLangTypeId3;
}
else if (strAttributeName  ==  conApplicationType.ProgLangTypeId4)
{
return mstrProgLangTypeId4;
}
else if (strAttributeName  ==  conApplicationType.ProgLangTypeId5)
{
return mstrProgLangTypeId5;
}
else if (strAttributeName  ==  conApplicationType.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  conApplicationType.VisitedNum)
{
return mintVisitedNum;
}
else if (strAttributeName  ==  conApplicationType.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conApplicationType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conApplicationType.ApplicationTypeId)
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conApplicationType.ApplicationTypeId);
}
else if (strAttributeName  ==  conApplicationType.ApplicationTypeName)
{
mstrApplicationTypeName = value.ToString();
 AddUpdatedFld(conApplicationType.ApplicationTypeName);
}
else if (strAttributeName  ==  conApplicationType.ApplicationTypeSimName)
{
mstrApplicationTypeSimName = value.ToString();
 AddUpdatedFld(conApplicationType.ApplicationTypeSimName);
}
else if (strAttributeName  ==  conApplicationType.ApplicationTypeENName)
{
mstrApplicationTypeENName = value.ToString();
 AddUpdatedFld(conApplicationType.ApplicationTypeENName);
}
else if (strAttributeName  ==  conApplicationType.ProgLangTypeId)
{
mstrProgLangTypeId = value.ToString();
 AddUpdatedFld(conApplicationType.ProgLangTypeId);
}
else if (strAttributeName  ==  conApplicationType.ProgLangTypeId2)
{
mstrProgLangTypeId2 = value.ToString();
 AddUpdatedFld(conApplicationType.ProgLangTypeId2);
}
else if (strAttributeName  ==  conApplicationType.ProgLangTypeId3)
{
mstrProgLangTypeId3 = value.ToString();
 AddUpdatedFld(conApplicationType.ProgLangTypeId3);
}
else if (strAttributeName  ==  conApplicationType.ProgLangTypeId4)
{
mstrProgLangTypeId4 = value.ToString();
 AddUpdatedFld(conApplicationType.ProgLangTypeId4);
}
else if (strAttributeName  ==  conApplicationType.ProgLangTypeId5)
{
mstrProgLangTypeId5 = value.ToString();
 AddUpdatedFld(conApplicationType.ProgLangTypeId5);
}
else if (strAttributeName  ==  conApplicationType.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conApplicationType.IsVisible);
}
else if (strAttributeName  ==  conApplicationType.VisitedNum)
{
mintVisitedNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conApplicationType.VisitedNum);
}
else if (strAttributeName  ==  conApplicationType.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conApplicationType.OrderNum);
}
else if (strAttributeName  ==  conApplicationType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conApplicationType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conApplicationType.ApplicationTypeId  ==  _AttributeName[intIndex])
{
return mintApplicationTypeId;
}
else if (conApplicationType.ApplicationTypeName  ==  _AttributeName[intIndex])
{
return mstrApplicationTypeName;
}
else if (conApplicationType.ApplicationTypeSimName  ==  _AttributeName[intIndex])
{
return mstrApplicationTypeSimName;
}
else if (conApplicationType.ApplicationTypeENName  ==  _AttributeName[intIndex])
{
return mstrApplicationTypeENName;
}
else if (conApplicationType.ProgLangTypeId  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeId;
}
else if (conApplicationType.ProgLangTypeId2  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeId2;
}
else if (conApplicationType.ProgLangTypeId3  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeId3;
}
else if (conApplicationType.ProgLangTypeId4  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeId4;
}
else if (conApplicationType.ProgLangTypeId5  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeId5;
}
else if (conApplicationType.IsVisible  ==  _AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (conApplicationType.VisitedNum  ==  _AttributeName[intIndex])
{
return mintVisitedNum;
}
else if (conApplicationType.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conApplicationType.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conApplicationType.ApplicationTypeId  ==  _AttributeName[intIndex])
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conApplicationType.ApplicationTypeId);
}
else if (conApplicationType.ApplicationTypeName  ==  _AttributeName[intIndex])
{
mstrApplicationTypeName = value.ToString();
 AddUpdatedFld(conApplicationType.ApplicationTypeName);
}
else if (conApplicationType.ApplicationTypeSimName  ==  _AttributeName[intIndex])
{
mstrApplicationTypeSimName = value.ToString();
 AddUpdatedFld(conApplicationType.ApplicationTypeSimName);
}
else if (conApplicationType.ApplicationTypeENName  ==  _AttributeName[intIndex])
{
mstrApplicationTypeENName = value.ToString();
 AddUpdatedFld(conApplicationType.ApplicationTypeENName);
}
else if (conApplicationType.ProgLangTypeId  ==  _AttributeName[intIndex])
{
mstrProgLangTypeId = value.ToString();
 AddUpdatedFld(conApplicationType.ProgLangTypeId);
}
else if (conApplicationType.ProgLangTypeId2  ==  _AttributeName[intIndex])
{
mstrProgLangTypeId2 = value.ToString();
 AddUpdatedFld(conApplicationType.ProgLangTypeId2);
}
else if (conApplicationType.ProgLangTypeId3  ==  _AttributeName[intIndex])
{
mstrProgLangTypeId3 = value.ToString();
 AddUpdatedFld(conApplicationType.ProgLangTypeId3);
}
else if (conApplicationType.ProgLangTypeId4  ==  _AttributeName[intIndex])
{
mstrProgLangTypeId4 = value.ToString();
 AddUpdatedFld(conApplicationType.ProgLangTypeId4);
}
else if (conApplicationType.ProgLangTypeId5  ==  _AttributeName[intIndex])
{
mstrProgLangTypeId5 = value.ToString();
 AddUpdatedFld(conApplicationType.ProgLangTypeId5);
}
else if (conApplicationType.IsVisible  ==  _AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conApplicationType.IsVisible);
}
else if (conApplicationType.VisitedNum  ==  _AttributeName[intIndex])
{
mintVisitedNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conApplicationType.VisitedNum);
}
else if (conApplicationType.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conApplicationType.OrderNum);
}
else if (conApplicationType.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conApplicationType.Memo);
}
}
}

/// <summary>
/// 应用程序类型ID(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int ApplicationTypeId
{
get
{
return mintApplicationTypeId;
}
set
{
 mintApplicationTypeId = value;
//记录修改过的字段
 AddUpdatedFld(conApplicationType.ApplicationTypeId);
}
}
/// <summary>
/// 应用程序类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ApplicationTypeName
{
get
{
return mstrApplicationTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrApplicationTypeName = value;
}
else
{
 mstrApplicationTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conApplicationType.ApplicationTypeName);
}
}
/// <summary>
/// 应用程序类型简称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ApplicationTypeSimName
{
get
{
return mstrApplicationTypeSimName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrApplicationTypeSimName = value;
}
else
{
 mstrApplicationTypeSimName = value;
}
//记录修改过的字段
 AddUpdatedFld(conApplicationType.ApplicationTypeSimName);
}
}
/// <summary>
/// 应用类型英文名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ApplicationTypeENName
{
get
{
return mstrApplicationTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrApplicationTypeENName = value;
}
else
{
 mstrApplicationTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conApplicationType.ApplicationTypeENName);
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
 AddUpdatedFld(conApplicationType.ProgLangTypeId);
}
}
/// <summary>
/// 编程语言类型Id2(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLangTypeId2
{
get
{
return mstrProgLangTypeId2;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLangTypeId2 = value;
}
else
{
 mstrProgLangTypeId2 = value;
}
//记录修改过的字段
 AddUpdatedFld(conApplicationType.ProgLangTypeId2);
}
}
/// <summary>
/// 编程语言类型Id3(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLangTypeId3
{
get
{
return mstrProgLangTypeId3;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLangTypeId3 = value;
}
else
{
 mstrProgLangTypeId3 = value;
}
//记录修改过的字段
 AddUpdatedFld(conApplicationType.ProgLangTypeId3);
}
}
/// <summary>
/// 编程语言类型Id4(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLangTypeId4
{
get
{
return mstrProgLangTypeId4;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLangTypeId4 = value;
}
else
{
 mstrProgLangTypeId4 = value;
}
//记录修改过的字段
 AddUpdatedFld(conApplicationType.ProgLangTypeId4);
}
}
/// <summary>
/// 编程语言类型Id5(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLangTypeId5
{
get
{
return mstrProgLangTypeId5;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLangTypeId5 = value;
}
else
{
 mstrProgLangTypeId5 = value;
}
//记录修改过的字段
 AddUpdatedFld(conApplicationType.ProgLangTypeId5);
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
 AddUpdatedFld(conApplicationType.IsVisible);
}
}
/// <summary>
/// 访问数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? VisitedNum
{
get
{
return mintVisitedNum;
}
set
{
 mintVisitedNum = value;
//记录修改过的字段
 AddUpdatedFld(conApplicationType.VisitedNum);
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
 AddUpdatedFld(conApplicationType.OrderNum);
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
 AddUpdatedFld(conApplicationType.Memo);
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
  return mintApplicationTypeId.ToString();
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
  return mstrApplicationTypeName;
 }
 }
}
 /// <summary>
 /// 应用程序类型(ApplicationType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conApplicationType
{
public const string _CurrTabName = "ApplicationType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ApplicationTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"ApplicationTypeId", "ApplicationTypeName", "ApplicationTypeSimName", "ApplicationTypeENName", "ProgLangTypeId", "ProgLangTypeId2", "ProgLangTypeId3", "ProgLangTypeId4", "ProgLangTypeId5", "IsVisible", "VisitedNum", "OrderNum", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"ApplicationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeId = "ApplicationTypeId";    //应用程序类型ID

 /// <summary>
 /// 常量:"ApplicationTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeName = "ApplicationTypeName";    //应用程序类型名称

 /// <summary>
 /// 常量:"ApplicationTypeSimName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeSimName = "ApplicationTypeSimName";    //应用程序类型简称

 /// <summary>
 /// 常量:"ApplicationTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeENName = "ApplicationTypeENName";    //应用类型英文名

 /// <summary>
 /// 常量:"ProgLangTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeId = "ProgLangTypeId";    //编程语言类型Id

 /// <summary>
 /// 常量:"ProgLangTypeId2"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeId2 = "ProgLangTypeId2";    //编程语言类型Id2

 /// <summary>
 /// 常量:"ProgLangTypeId3"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeId3 = "ProgLangTypeId3";    //编程语言类型Id3

 /// <summary>
 /// 常量:"ProgLangTypeId4"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeId4 = "ProgLangTypeId4";    //编程语言类型Id4

 /// <summary>
 /// 常量:"ProgLangTypeId5"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeId5 = "ProgLangTypeId5";    //编程语言类型Id5

 /// <summary>
 /// 常量:"IsVisible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVisible = "IsVisible";    //是否显示

 /// <summary>
 /// 常量:"VisitedNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VisitedNum = "VisitedNum";    //访问数

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}