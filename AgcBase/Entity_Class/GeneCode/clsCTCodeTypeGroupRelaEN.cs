
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCTCodeTypeGroupRelaEN
 表名:CTCodeTypeGroupRela(00050647)
 * 版本:2026.05.30(服务器:PYF-AI)
 日期:2026/06/07 13:58:42
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
 /// 表CTCodeTypeGroupRela的关键字(CtGroupId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CtGroupId_CTCodeTypeGroupRela
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strCtGroupId">表关键字</param>
public K_CtGroupId_CTCodeTypeGroupRela(string strCtGroupId)
{
if (IsValid(strCtGroupId)) Value = strCtGroupId;
else
{
Value = null;
}
}
private static bool IsValid(string strCtGroupId)
{
if (string.IsNullOrEmpty(strCtGroupId) == true) return false;
if (strCtGroupId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_CtGroupId_CTCodeTypeGroupRela]类型的对象</returns>
public static implicit operator K_CtGroupId_CTCodeTypeGroupRela(string value)
{
return new K_CtGroupId_CTCodeTypeGroupRela(value);
}
}
 /// <summary>
 /// CTCodeTypeGroupRela(CTCodeTypeGroupRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCTCodeTypeGroupRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CTCodeTypeGroupRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "CtGroupId,CodeTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 17;
public static string[] _AttributeName = new string[] {"CtGroupId", "CodeTypeId", "IsMainGroup", "OrderNum", "LayerNo", "PosX", "PosY", "PosXSmall", "PosYSmall", "PosXLarge", "PosYLarge", "LayoutVersion", "IsPinned", "LayoutUpdatedBy", "LayoutUpdatedAt", "UpdDate", "UpdUser"};

protected string mstrCtGroupId;    //Ct组Id
protected string mstrCodeTypeId;    //代码类型Id
protected bool mbolIsMainGroup;    //IsMainGroup
protected int? mintOrderNum;    //序号
protected int? mintLayerNo;    //LayerNo
protected int? mintPosX;    //PosX
protected int? mintPosY;    //PosY
protected int? mintPosXSmall;    //PosXSmall
protected int? mintPosYSmall;    //PosYSmall
protected int? mintPosXLarge;    //PosXLarge
protected int? mintPosYLarge;    //PosYLarge
protected int mintLayoutVersion;    //LayoutVersion
protected bool mbolIsPinned;    //IsPinned
protected string mstrLayoutUpdatedBy;    //LayoutUpdatedBy
protected string mstrLayoutUpdatedAt;    //LayoutUpdatedAt
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsCTCodeTypeGroupRelaEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CtGroupId");
 lstKeyFldNames.Add("CodeTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strCtGroupId">关键字:Ct组Id</param>
public clsCTCodeTypeGroupRelaEN(string strCtGroupId , string strCodeTypeId)
 {
strCtGroupId = strCtGroupId.Replace("'", "''");
if (strCtGroupId.Length > 4)
{
throw new Exception("在表:CTCodeTypeGroupRela中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strCtGroupId)  ==  true)
{
throw new Exception("在表:CTCodeTypeGroupRela中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCtGroupId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrCtGroupId = strCtGroupId;
this.mstrCodeTypeId = strCodeTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CtGroupId");
 lstKeyFldNames.Add("CodeTypeId");
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
if (strAttributeName  ==  conCTCodeTypeGroupRela.CtGroupId)
{
return mstrCtGroupId;
}
else if (strAttributeName  ==  conCTCodeTypeGroupRela.CodeTypeId)
{
return mstrCodeTypeId;
}
else if (strAttributeName  ==  conCTCodeTypeGroupRela.IsMainGroup)
{
return mbolIsMainGroup;
}
else if (strAttributeName  ==  conCTCodeTypeGroupRela.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conCTCodeTypeGroupRela.LayerNo)
{
return mintLayerNo;
}
else if (strAttributeName  ==  conCTCodeTypeGroupRela.PosX)
{
return mintPosX;
}
else if (strAttributeName  ==  conCTCodeTypeGroupRela.PosY)
{
return mintPosY;
}
else if (strAttributeName  ==  conCTCodeTypeGroupRela.PosXSmall)
{
return mintPosXSmall;
}
else if (strAttributeName  ==  conCTCodeTypeGroupRela.PosYSmall)
{
return mintPosYSmall;
}
else if (strAttributeName  ==  conCTCodeTypeGroupRela.PosXLarge)
{
return mintPosXLarge;
}
else if (strAttributeName  ==  conCTCodeTypeGroupRela.PosYLarge)
{
return mintPosYLarge;
}
else if (strAttributeName  ==  conCTCodeTypeGroupRela.LayoutVersion)
{
return mintLayoutVersion;
}
else if (strAttributeName  ==  conCTCodeTypeGroupRela.IsPinned)
{
return mbolIsPinned;
}
else if (strAttributeName  ==  conCTCodeTypeGroupRela.LayoutUpdatedBy)
{
return mstrLayoutUpdatedBy;
}
else if (strAttributeName  ==  conCTCodeTypeGroupRela.LayoutUpdatedAt)
{
return mstrLayoutUpdatedAt;
}
else if (strAttributeName  ==  conCTCodeTypeGroupRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conCTCodeTypeGroupRela.UpdUser)
{
return mstrUpdUser;
}
return null;
}
set
{
if (strAttributeName  ==  conCTCodeTypeGroupRela.CtGroupId)
{
mstrCtGroupId = value.ToString();
 AddUpdatedFld(conCTCodeTypeGroupRela.CtGroupId);
}
else if (strAttributeName  ==  conCTCodeTypeGroupRela.CodeTypeId)
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(conCTCodeTypeGroupRela.CodeTypeId);
}
else if (strAttributeName  ==  conCTCodeTypeGroupRela.IsMainGroup)
{
mbolIsMainGroup = TransNullToBool(value.ToString());
 AddUpdatedFld(conCTCodeTypeGroupRela.IsMainGroup);
}
else if (strAttributeName  ==  conCTCodeTypeGroupRela.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conCTCodeTypeGroupRela.OrderNum);
}
else if (strAttributeName  ==  conCTCodeTypeGroupRela.LayerNo)
{
mintLayerNo = TransNullToInt(value.ToString());
 AddUpdatedFld(conCTCodeTypeGroupRela.LayerNo);
}
else if (strAttributeName  ==  conCTCodeTypeGroupRela.PosX)
{
mintPosX = TransNullToInt(value.ToString());
 AddUpdatedFld(conCTCodeTypeGroupRela.PosX);
}
else if (strAttributeName  ==  conCTCodeTypeGroupRela.PosY)
{
mintPosY = TransNullToInt(value.ToString());
 AddUpdatedFld(conCTCodeTypeGroupRela.PosY);
}
else if (strAttributeName  ==  conCTCodeTypeGroupRela.PosXSmall)
{
mintPosXSmall = TransNullToInt(value.ToString());
 AddUpdatedFld(conCTCodeTypeGroupRela.PosXSmall);
}
else if (strAttributeName  ==  conCTCodeTypeGroupRela.PosYSmall)
{
mintPosYSmall = TransNullToInt(value.ToString());
 AddUpdatedFld(conCTCodeTypeGroupRela.PosYSmall);
}
else if (strAttributeName  ==  conCTCodeTypeGroupRela.PosXLarge)
{
mintPosXLarge = TransNullToInt(value.ToString());
 AddUpdatedFld(conCTCodeTypeGroupRela.PosXLarge);
}
else if (strAttributeName  ==  conCTCodeTypeGroupRela.PosYLarge)
{
mintPosYLarge = TransNullToInt(value.ToString());
 AddUpdatedFld(conCTCodeTypeGroupRela.PosYLarge);
}
else if (strAttributeName  ==  conCTCodeTypeGroupRela.LayoutVersion)
{
mintLayoutVersion = TransNullToInt(value.ToString());
 AddUpdatedFld(conCTCodeTypeGroupRela.LayoutVersion);
}
else if (strAttributeName  ==  conCTCodeTypeGroupRela.IsPinned)
{
mbolIsPinned = TransNullToBool(value.ToString());
 AddUpdatedFld(conCTCodeTypeGroupRela.IsPinned);
}
else if (strAttributeName  ==  conCTCodeTypeGroupRela.LayoutUpdatedBy)
{
mstrLayoutUpdatedBy = value.ToString();
 AddUpdatedFld(conCTCodeTypeGroupRela.LayoutUpdatedBy);
}
else if (strAttributeName  ==  conCTCodeTypeGroupRela.LayoutUpdatedAt)
{
mstrLayoutUpdatedAt = value.ToString();
 AddUpdatedFld(conCTCodeTypeGroupRela.LayoutUpdatedAt);
}
else if (strAttributeName  ==  conCTCodeTypeGroupRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCTCodeTypeGroupRela.UpdDate);
}
else if (strAttributeName  ==  conCTCodeTypeGroupRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conCTCodeTypeGroupRela.UpdUser);
}
}
}
public object this[int intIndex]
{
get
{
if (conCTCodeTypeGroupRela.CtGroupId  ==  _AttributeName[intIndex])
{
return mstrCtGroupId;
}
else if (conCTCodeTypeGroupRela.CodeTypeId  ==  _AttributeName[intIndex])
{
return mstrCodeTypeId;
}
else if (conCTCodeTypeGroupRela.IsMainGroup  ==  _AttributeName[intIndex])
{
return mbolIsMainGroup;
}
else if (conCTCodeTypeGroupRela.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conCTCodeTypeGroupRela.LayerNo  ==  _AttributeName[intIndex])
{
return mintLayerNo;
}
else if (conCTCodeTypeGroupRela.PosX  ==  _AttributeName[intIndex])
{
return mintPosX;
}
else if (conCTCodeTypeGroupRela.PosY  ==  _AttributeName[intIndex])
{
return mintPosY;
}
else if (conCTCodeTypeGroupRela.PosXSmall  ==  _AttributeName[intIndex])
{
return mintPosXSmall;
}
else if (conCTCodeTypeGroupRela.PosYSmall  ==  _AttributeName[intIndex])
{
return mintPosYSmall;
}
else if (conCTCodeTypeGroupRela.PosXLarge  ==  _AttributeName[intIndex])
{
return mintPosXLarge;
}
else if (conCTCodeTypeGroupRela.PosYLarge  ==  _AttributeName[intIndex])
{
return mintPosYLarge;
}
else if (conCTCodeTypeGroupRela.LayoutVersion  ==  _AttributeName[intIndex])
{
return mintLayoutVersion;
}
else if (conCTCodeTypeGroupRela.IsPinned  ==  _AttributeName[intIndex])
{
return mbolIsPinned;
}
else if (conCTCodeTypeGroupRela.LayoutUpdatedBy  ==  _AttributeName[intIndex])
{
return mstrLayoutUpdatedBy;
}
else if (conCTCodeTypeGroupRela.LayoutUpdatedAt  ==  _AttributeName[intIndex])
{
return mstrLayoutUpdatedAt;
}
else if (conCTCodeTypeGroupRela.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conCTCodeTypeGroupRela.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
return null;
}
set
{
if (conCTCodeTypeGroupRela.CtGroupId  ==  _AttributeName[intIndex])
{
mstrCtGroupId = value.ToString();
 AddUpdatedFld(conCTCodeTypeGroupRela.CtGroupId);
}
else if (conCTCodeTypeGroupRela.CodeTypeId  ==  _AttributeName[intIndex])
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(conCTCodeTypeGroupRela.CodeTypeId);
}
else if (conCTCodeTypeGroupRela.IsMainGroup  ==  _AttributeName[intIndex])
{
mbolIsMainGroup = TransNullToBool(value.ToString());
 AddUpdatedFld(conCTCodeTypeGroupRela.IsMainGroup);
}
else if (conCTCodeTypeGroupRela.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conCTCodeTypeGroupRela.OrderNum);
}
else if (conCTCodeTypeGroupRela.LayerNo  ==  _AttributeName[intIndex])
{
mintLayerNo = TransNullToInt(value.ToString());
 AddUpdatedFld(conCTCodeTypeGroupRela.LayerNo);
}
else if (conCTCodeTypeGroupRela.PosX  ==  _AttributeName[intIndex])
{
mintPosX = TransNullToInt(value.ToString());
 AddUpdatedFld(conCTCodeTypeGroupRela.PosX);
}
else if (conCTCodeTypeGroupRela.PosY  ==  _AttributeName[intIndex])
{
mintPosY = TransNullToInt(value.ToString());
 AddUpdatedFld(conCTCodeTypeGroupRela.PosY);
}
else if (conCTCodeTypeGroupRela.PosXSmall  ==  _AttributeName[intIndex])
{
mintPosXSmall = TransNullToInt(value.ToString());
 AddUpdatedFld(conCTCodeTypeGroupRela.PosXSmall);
}
else if (conCTCodeTypeGroupRela.PosYSmall  ==  _AttributeName[intIndex])
{
mintPosYSmall = TransNullToInt(value.ToString());
 AddUpdatedFld(conCTCodeTypeGroupRela.PosYSmall);
}
else if (conCTCodeTypeGroupRela.PosXLarge  ==  _AttributeName[intIndex])
{
mintPosXLarge = TransNullToInt(value.ToString());
 AddUpdatedFld(conCTCodeTypeGroupRela.PosXLarge);
}
else if (conCTCodeTypeGroupRela.PosYLarge  ==  _AttributeName[intIndex])
{
mintPosYLarge = TransNullToInt(value.ToString());
 AddUpdatedFld(conCTCodeTypeGroupRela.PosYLarge);
}
else if (conCTCodeTypeGroupRela.LayoutVersion  ==  _AttributeName[intIndex])
{
mintLayoutVersion = TransNullToInt(value.ToString());
 AddUpdatedFld(conCTCodeTypeGroupRela.LayoutVersion);
}
else if (conCTCodeTypeGroupRela.IsPinned  ==  _AttributeName[intIndex])
{
mbolIsPinned = TransNullToBool(value.ToString());
 AddUpdatedFld(conCTCodeTypeGroupRela.IsPinned);
}
else if (conCTCodeTypeGroupRela.LayoutUpdatedBy  ==  _AttributeName[intIndex])
{
mstrLayoutUpdatedBy = value.ToString();
 AddUpdatedFld(conCTCodeTypeGroupRela.LayoutUpdatedBy);
}
else if (conCTCodeTypeGroupRela.LayoutUpdatedAt  ==  _AttributeName[intIndex])
{
mstrLayoutUpdatedAt = value.ToString();
 AddUpdatedFld(conCTCodeTypeGroupRela.LayoutUpdatedAt);
}
else if (conCTCodeTypeGroupRela.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCTCodeTypeGroupRela.UpdDate);
}
else if (conCTCodeTypeGroupRela.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conCTCodeTypeGroupRela.UpdUser);
}
}
}

/// <summary>
/// Ct组Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CtGroupId
{
get
{
return mstrCtGroupId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCtGroupId = value;
}
else
{
 mstrCtGroupId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCTCodeTypeGroupRela.CtGroupId);
}
}
/// <summary>
/// 代码类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTypeId
{
get
{
return mstrCodeTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTypeId = value;
}
else
{
 mstrCodeTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCTCodeTypeGroupRela.CodeTypeId);
}
}
/// <summary>
/// IsMainGroup(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsMainGroup
{
get
{
return mbolIsMainGroup;
}
set
{
 mbolIsMainGroup = value;
//记录修改过的字段
 AddUpdatedFld(conCTCodeTypeGroupRela.IsMainGroup);
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
 AddUpdatedFld(conCTCodeTypeGroupRela.OrderNum);
}
}
/// <summary>
/// LayerNo(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? LayerNo
{
get
{
return mintLayerNo;
}
set
{
 mintLayerNo = value;
//记录修改过的字段
 AddUpdatedFld(conCTCodeTypeGroupRela.LayerNo);
}
}
/// <summary>
/// PosX(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? PosX
{
get
{
return mintPosX;
}
set
{
 mintPosX = value;
//记录修改过的字段
 AddUpdatedFld(conCTCodeTypeGroupRela.PosX);
}
}
/// <summary>
/// PosY(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? PosY
{
get
{
return mintPosY;
}
set
{
 mintPosY = value;
//记录修改过的字段
 AddUpdatedFld(conCTCodeTypeGroupRela.PosY);
}
}
/// <summary>
/// PosXSmall(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? PosXSmall
{
get
{
return mintPosXSmall;
}
set
{
 mintPosXSmall = value;
//记录修改过的字段
 AddUpdatedFld(conCTCodeTypeGroupRela.PosXSmall);
}
}
/// <summary>
/// PosYSmall(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? PosYSmall
{
get
{
return mintPosYSmall;
}
set
{
 mintPosYSmall = value;
//记录修改过的字段
 AddUpdatedFld(conCTCodeTypeGroupRela.PosYSmall);
}
}
/// <summary>
/// PosXLarge(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? PosXLarge
{
get
{
return mintPosXLarge;
}
set
{
 mintPosXLarge = value;
//记录修改过的字段
 AddUpdatedFld(conCTCodeTypeGroupRela.PosXLarge);
}
}
/// <summary>
/// PosYLarge(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? PosYLarge
{
get
{
return mintPosYLarge;
}
set
{
 mintPosYLarge = value;
//记录修改过的字段
 AddUpdatedFld(conCTCodeTypeGroupRela.PosYLarge);
}
}
/// <summary>
/// LayoutVersion(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int LayoutVersion
{
get
{
return mintLayoutVersion;
}
set
{
 mintLayoutVersion = value;
//记录修改过的字段
 AddUpdatedFld(conCTCodeTypeGroupRela.LayoutVersion);
}
}
/// <summary>
/// IsPinned(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsPinned
{
get
{
return mbolIsPinned;
}
set
{
 mbolIsPinned = value;
//记录修改过的字段
 AddUpdatedFld(conCTCodeTypeGroupRela.IsPinned);
}
}
/// <summary>
/// LayoutUpdatedBy(说明:;字段类型:nvarchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LayoutUpdatedBy
{
get
{
return mstrLayoutUpdatedBy;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLayoutUpdatedBy = value;
}
else
{
 mstrLayoutUpdatedBy = value;
}
//记录修改过的字段
 AddUpdatedFld(conCTCodeTypeGroupRela.LayoutUpdatedBy);
}
}
/// <summary>
/// LayoutUpdatedAt(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LayoutUpdatedAt
{
get
{
return mstrLayoutUpdatedAt;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLayoutUpdatedAt = value;
}
else
{
 mstrLayoutUpdatedAt = value;
}
//记录修改过的字段
 AddUpdatedFld(conCTCodeTypeGroupRela.LayoutUpdatedAt);
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
 AddUpdatedFld(conCTCodeTypeGroupRela.UpdDate);
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
 AddUpdatedFld(conCTCodeTypeGroupRela.UpdUser);
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
  return mstrCtGroupId;
 }
 }
}
 /// <summary>
 /// CTCodeTypeGroupRela(CTCodeTypeGroupRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCTCodeTypeGroupRela
{
public const string _CurrTabName = "CTCodeTypeGroupRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CtGroupId,CodeTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"CtGroupId", "CodeTypeId", "IsMainGroup", "OrderNum", "LayerNo", "PosX", "PosY", "PosXSmall", "PosYSmall", "PosXLarge", "PosYLarge", "LayoutVersion", "IsPinned", "LayoutUpdatedBy", "LayoutUpdatedAt", "UpdDate", "UpdUser"};
//以下是属性变量


 /// <summary>
 /// 常量:"CtGroupId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CtGroupId = "CtGroupId";    //Ct组Id

 /// <summary>
 /// 常量:"CodeTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTypeId = "CodeTypeId";    //代码类型Id

 /// <summary>
 /// 常量:"IsMainGroup"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsMainGroup = "IsMainGroup";    //IsMainGroup

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"LayerNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LayerNo = "LayerNo";    //LayerNo

 /// <summary>
 /// 常量:"PosX"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PosX = "PosX";    //PosX

 /// <summary>
 /// 常量:"PosY"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PosY = "PosY";    //PosY

 /// <summary>
 /// 常量:"PosXSmall"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PosXSmall = "PosXSmall";    //PosXSmall

 /// <summary>
 /// 常量:"PosYSmall"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PosYSmall = "PosYSmall";    //PosYSmall

 /// <summary>
 /// 常量:"PosXLarge"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PosXLarge = "PosXLarge";    //PosXLarge

 /// <summary>
 /// 常量:"PosYLarge"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PosYLarge = "PosYLarge";    //PosYLarge

 /// <summary>
 /// 常量:"LayoutVersion"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LayoutVersion = "LayoutVersion";    //LayoutVersion

 /// <summary>
 /// 常量:"IsPinned"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsPinned = "IsPinned";    //IsPinned

 /// <summary>
 /// 常量:"LayoutUpdatedBy"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LayoutUpdatedBy = "LayoutUpdatedBy";    //LayoutUpdatedBy

 /// <summary>
 /// 常量:"LayoutUpdatedAt"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LayoutUpdatedAt = "LayoutUpdatedAt";    //LayoutUpdatedAt

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