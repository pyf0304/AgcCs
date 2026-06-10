
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCTRelationTypeEN
 表名:CTRelationType(00050645)
 * 版本:2026.05.30(服务器:PYF-AI)
 日期:2026/06/05 05:20:41
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
 /// 表CTRelationType的关键字(CtRelationTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CtRelationTypeId_CTRelationType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strCtRelationTypeId">表关键字</param>
public K_CtRelationTypeId_CTRelationType(string strCtRelationTypeId)
{
if (IsValid(strCtRelationTypeId)) Value = strCtRelationTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strCtRelationTypeId)
{
if (string.IsNullOrEmpty(strCtRelationTypeId) == true) return false;
if (strCtRelationTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_CtRelationTypeId_CTRelationType]类型的对象</returns>
public static implicit operator K_CtRelationTypeId_CTRelationType(string value)
{
return new K_CtRelationTypeId_CTRelationType(value);
}
}
 /// <summary>
 /// CT关系类型(CTRelationType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCTRelationTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CTRelationType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "CtRelationTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 14;
public static string[] _AttributeName = new string[] {"CtRelationTypeId", "RelationTypeName", "RelationTypeEN", "Description", "OrderNum", "InUse", "LineColor", "LineStyle", "LineWidth", "ArrowType", "DisplayColor", "UpdDate", "UpdUser", "Memo"};

protected string mstrCtRelationTypeId;    //Ct关系类型Id
protected string mstrRelationTypeName;    //关系类型名
protected string mstrRelationTypeEN;    //关系类型英文名
protected string mstrDescription;    //描述
protected int? mintOrderNum;    //序号
protected bool mbolInUse;    //是否在用
protected string mstrLineColor;    //LineColor
protected string mstrLineStyle;    //LineStyle
protected int? mintLineWidth;    //LineWidth
protected string mstrArrowType;    //箭头类型
protected string mstrDisplayColor;    //DisplayColor
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsCTRelationTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CtRelationTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strCtRelationTypeId">关键字:Ct关系类型Id</param>
public clsCTRelationTypeEN(string strCtRelationTypeId)
 {
strCtRelationTypeId = strCtRelationTypeId.Replace("'", "''");
if (strCtRelationTypeId.Length > 2)
{
throw new Exception("在表:CTRelationType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strCtRelationTypeId)  ==  true)
{
throw new Exception("在表:CTRelationType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCtRelationTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrCtRelationTypeId = strCtRelationTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CtRelationTypeId");
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
if (strAttributeName  ==  conCTRelationType.CtRelationTypeId)
{
return mstrCtRelationTypeId;
}
else if (strAttributeName  ==  conCTRelationType.RelationTypeName)
{
return mstrRelationTypeName;
}
else if (strAttributeName  ==  conCTRelationType.RelationTypeEN)
{
return mstrRelationTypeEN;
}
else if (strAttributeName  ==  conCTRelationType.Description)
{
return mstrDescription;
}
else if (strAttributeName  ==  conCTRelationType.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conCTRelationType.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  conCTRelationType.LineColor)
{
return mstrLineColor;
}
else if (strAttributeName  ==  conCTRelationType.LineStyle)
{
return mstrLineStyle;
}
else if (strAttributeName  ==  conCTRelationType.LineWidth)
{
return mintLineWidth;
}
else if (strAttributeName  ==  conCTRelationType.ArrowType)
{
return mstrArrowType;
}
else if (strAttributeName  ==  conCTRelationType.DisplayColor)
{
return mstrDisplayColor;
}
else if (strAttributeName  ==  conCTRelationType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conCTRelationType.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conCTRelationType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conCTRelationType.CtRelationTypeId)
{
mstrCtRelationTypeId = value.ToString();
 AddUpdatedFld(conCTRelationType.CtRelationTypeId);
}
else if (strAttributeName  ==  conCTRelationType.RelationTypeName)
{
mstrRelationTypeName = value.ToString();
 AddUpdatedFld(conCTRelationType.RelationTypeName);
}
else if (strAttributeName  ==  conCTRelationType.RelationTypeEN)
{
mstrRelationTypeEN = value.ToString();
 AddUpdatedFld(conCTRelationType.RelationTypeEN);
}
else if (strAttributeName  ==  conCTRelationType.Description)
{
mstrDescription = value.ToString();
 AddUpdatedFld(conCTRelationType.Description);
}
else if (strAttributeName  ==  conCTRelationType.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conCTRelationType.OrderNum);
}
else if (strAttributeName  ==  conCTRelationType.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conCTRelationType.InUse);
}
else if (strAttributeName  ==  conCTRelationType.LineColor)
{
mstrLineColor = value.ToString();
 AddUpdatedFld(conCTRelationType.LineColor);
}
else if (strAttributeName  ==  conCTRelationType.LineStyle)
{
mstrLineStyle = value.ToString();
 AddUpdatedFld(conCTRelationType.LineStyle);
}
else if (strAttributeName  ==  conCTRelationType.LineWidth)
{
mintLineWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(conCTRelationType.LineWidth);
}
else if (strAttributeName  ==  conCTRelationType.ArrowType)
{
mstrArrowType = value.ToString();
 AddUpdatedFld(conCTRelationType.ArrowType);
}
else if (strAttributeName  ==  conCTRelationType.DisplayColor)
{
mstrDisplayColor = value.ToString();
 AddUpdatedFld(conCTRelationType.DisplayColor);
}
else if (strAttributeName  ==  conCTRelationType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCTRelationType.UpdDate);
}
else if (strAttributeName  ==  conCTRelationType.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conCTRelationType.UpdUser);
}
else if (strAttributeName  ==  conCTRelationType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCTRelationType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conCTRelationType.CtRelationTypeId  ==  _AttributeName[intIndex])
{
return mstrCtRelationTypeId;
}
else if (conCTRelationType.RelationTypeName  ==  _AttributeName[intIndex])
{
return mstrRelationTypeName;
}
else if (conCTRelationType.RelationTypeEN  ==  _AttributeName[intIndex])
{
return mstrRelationTypeEN;
}
else if (conCTRelationType.Description  ==  _AttributeName[intIndex])
{
return mstrDescription;
}
else if (conCTRelationType.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conCTRelationType.InUse  ==  _AttributeName[intIndex])
{
return mbolInUse;
}
else if (conCTRelationType.LineColor  ==  _AttributeName[intIndex])
{
return mstrLineColor;
}
else if (conCTRelationType.LineStyle  ==  _AttributeName[intIndex])
{
return mstrLineStyle;
}
else if (conCTRelationType.LineWidth  ==  _AttributeName[intIndex])
{
return mintLineWidth;
}
else if (conCTRelationType.ArrowType  ==  _AttributeName[intIndex])
{
return mstrArrowType;
}
else if (conCTRelationType.DisplayColor  ==  _AttributeName[intIndex])
{
return mstrDisplayColor;
}
else if (conCTRelationType.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conCTRelationType.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conCTRelationType.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conCTRelationType.CtRelationTypeId  ==  _AttributeName[intIndex])
{
mstrCtRelationTypeId = value.ToString();
 AddUpdatedFld(conCTRelationType.CtRelationTypeId);
}
else if (conCTRelationType.RelationTypeName  ==  _AttributeName[intIndex])
{
mstrRelationTypeName = value.ToString();
 AddUpdatedFld(conCTRelationType.RelationTypeName);
}
else if (conCTRelationType.RelationTypeEN  ==  _AttributeName[intIndex])
{
mstrRelationTypeEN = value.ToString();
 AddUpdatedFld(conCTRelationType.RelationTypeEN);
}
else if (conCTRelationType.Description  ==  _AttributeName[intIndex])
{
mstrDescription = value.ToString();
 AddUpdatedFld(conCTRelationType.Description);
}
else if (conCTRelationType.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conCTRelationType.OrderNum);
}
else if (conCTRelationType.InUse  ==  _AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conCTRelationType.InUse);
}
else if (conCTRelationType.LineColor  ==  _AttributeName[intIndex])
{
mstrLineColor = value.ToString();
 AddUpdatedFld(conCTRelationType.LineColor);
}
else if (conCTRelationType.LineStyle  ==  _AttributeName[intIndex])
{
mstrLineStyle = value.ToString();
 AddUpdatedFld(conCTRelationType.LineStyle);
}
else if (conCTRelationType.LineWidth  ==  _AttributeName[intIndex])
{
mintLineWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(conCTRelationType.LineWidth);
}
else if (conCTRelationType.ArrowType  ==  _AttributeName[intIndex])
{
mstrArrowType = value.ToString();
 AddUpdatedFld(conCTRelationType.ArrowType);
}
else if (conCTRelationType.DisplayColor  ==  _AttributeName[intIndex])
{
mstrDisplayColor = value.ToString();
 AddUpdatedFld(conCTRelationType.DisplayColor);
}
else if (conCTRelationType.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCTRelationType.UpdDate);
}
else if (conCTRelationType.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conCTRelationType.UpdUser);
}
else if (conCTRelationType.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCTRelationType.Memo);
}
}
}

/// <summary>
/// Ct关系类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CtRelationTypeId
{
get
{
return mstrCtRelationTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCtRelationTypeId = value;
}
else
{
 mstrCtRelationTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCTRelationType.CtRelationTypeId);
}
}
/// <summary>
/// 关系类型名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RelationTypeName
{
get
{
return mstrRelationTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRelationTypeName = value;
}
else
{
 mstrRelationTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conCTRelationType.RelationTypeName);
}
}
/// <summary>
/// 关系类型英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RelationTypeEN
{
get
{
return mstrRelationTypeEN;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRelationTypeEN = value;
}
else
{
 mstrRelationTypeEN = value;
}
//记录修改过的字段
 AddUpdatedFld(conCTRelationType.RelationTypeEN);
}
}
/// <summary>
/// 描述(说明:;字段类型:varchar;字段长度:300;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Description
{
get
{
return mstrDescription;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDescription = value;
}
else
{
 mstrDescription = value;
}
//记录修改过的字段
 AddUpdatedFld(conCTRelationType.Description);
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
 AddUpdatedFld(conCTRelationType.OrderNum);
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
 AddUpdatedFld(conCTRelationType.InUse);
}
}
/// <summary>
/// LineColor(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LineColor
{
get
{
return mstrLineColor;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLineColor = value;
}
else
{
 mstrLineColor = value;
}
//记录修改过的字段
 AddUpdatedFld(conCTRelationType.LineColor);
}
}
/// <summary>
/// LineStyle(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LineStyle
{
get
{
return mstrLineStyle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLineStyle = value;
}
else
{
 mstrLineStyle = value;
}
//记录修改过的字段
 AddUpdatedFld(conCTRelationType.LineStyle);
}
}
/// <summary>
/// LineWidth(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? LineWidth
{
get
{
return mintLineWidth;
}
set
{
 mintLineWidth = value;
//记录修改过的字段
 AddUpdatedFld(conCTRelationType.LineWidth);
}
}
/// <summary>
/// 箭头类型(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ArrowType
{
get
{
return mstrArrowType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrArrowType = value;
}
else
{
 mstrArrowType = value;
}
//记录修改过的字段
 AddUpdatedFld(conCTRelationType.ArrowType);
}
}
/// <summary>
/// DisplayColor(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DisplayColor
{
get
{
return mstrDisplayColor;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDisplayColor = value;
}
else
{
 mstrDisplayColor = value;
}
//记录修改过的字段
 AddUpdatedFld(conCTRelationType.DisplayColor);
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
 AddUpdatedFld(conCTRelationType.UpdDate);
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
 AddUpdatedFld(conCTRelationType.UpdUser);
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
 AddUpdatedFld(conCTRelationType.Memo);
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
  return mstrCtRelationTypeId;
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
  return mstrRelationTypeName;
 }
 }
}
 /// <summary>
 /// CT关系类型(CTRelationType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCTRelationType
{
public const string _CurrTabName = "CTRelationType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CtRelationTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"CtRelationTypeId", "RelationTypeName", "RelationTypeEN", "Description", "OrderNum", "InUse", "LineColor", "LineStyle", "LineWidth", "ArrowType", "DisplayColor", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"CtRelationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CtRelationTypeId = "CtRelationTypeId";    //Ct关系类型Id

 /// <summary>
 /// 常量:"RelationTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RelationTypeName = "RelationTypeName";    //关系类型名

 /// <summary>
 /// 常量:"RelationTypeEN"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RelationTypeEN = "RelationTypeEN";    //关系类型英文名

 /// <summary>
 /// 常量:"Description"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Description = "Description";    //描述

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
 /// 常量:"LineColor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LineColor = "LineColor";    //LineColor

 /// <summary>
 /// 常量:"LineStyle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LineStyle = "LineStyle";    //LineStyle

 /// <summary>
 /// 常量:"LineWidth"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LineWidth = "LineWidth";    //LineWidth

 /// <summary>
 /// 常量:"ArrowType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ArrowType = "ArrowType";    //箭头类型

 /// <summary>
 /// 常量:"DisplayColor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DisplayColor = "DisplayColor";    //DisplayColor

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