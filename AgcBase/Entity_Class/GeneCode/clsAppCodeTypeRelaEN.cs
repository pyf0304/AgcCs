
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsAppCodeTypeRelaEN
 表名:AppCodeTypeRela(00050418)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:31:24
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
 /// 表AppCodeTypeRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_AppCodeTypeRela
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngmId">表关键字</param>
public K_mId_AppCodeTypeRela(long lngmId)
{
if (IsValid(lngmId)) Value = lngmId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngmId)
{
if (lngmId == 0) return false;
if (lngmId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_mId_AppCodeTypeRela]类型的对象</returns>
public static implicit operator K_mId_AppCodeTypeRela(long value)
{
return new K_mId_AppCodeTypeRela(value);
}
}
 /// <summary>
 /// 应用程序代码类型关系(AppCodeTypeRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsAppCodeTypeRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "AppCodeTypeRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 11;
public static string[] _AttributeName = new string[] {"mId", "ApplicationTypeId", "CodeTypeId", "ViewTypeCode", "TabMainTypeId", "IsVisible", "IsInGroupGeneCode", "OrderNum", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected int mintApplicationTypeId;    //应用程序类型ID
protected string mstrCodeTypeId;    //代码类型Id
protected int? mintViewTypeCode;    //界面类型码
protected string mstrTabMainTypeId;    //表主类型Id
protected bool mbolIsVisible;    //是否显示
protected bool mbolIsInGroupGeneCode;    //是否参与组生成代码
protected int mintOrderNum;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsAppCodeTypeRelaEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:mId</param>
public clsAppCodeTypeRelaEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
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
if (strAttributeName  ==  conAppCodeTypeRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conAppCodeTypeRela.ApplicationTypeId)
{
return mintApplicationTypeId;
}
else if (strAttributeName  ==  conAppCodeTypeRela.CodeTypeId)
{
return mstrCodeTypeId;
}
else if (strAttributeName  ==  conAppCodeTypeRela.ViewTypeCode)
{
return mintViewTypeCode;
}
else if (strAttributeName  ==  conAppCodeTypeRela.TabMainTypeId)
{
return mstrTabMainTypeId;
}
else if (strAttributeName  ==  conAppCodeTypeRela.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  conAppCodeTypeRela.IsInGroupGeneCode)
{
return mbolIsInGroupGeneCode;
}
else if (strAttributeName  ==  conAppCodeTypeRela.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conAppCodeTypeRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conAppCodeTypeRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conAppCodeTypeRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conAppCodeTypeRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conAppCodeTypeRela.mId);
}
else if (strAttributeName  ==  conAppCodeTypeRela.ApplicationTypeId)
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conAppCodeTypeRela.ApplicationTypeId);
}
else if (strAttributeName  ==  conAppCodeTypeRela.CodeTypeId)
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(conAppCodeTypeRela.CodeTypeId);
}
else if (strAttributeName  ==  conAppCodeTypeRela.ViewTypeCode)
{
mintViewTypeCode = TransNullToInt(value.ToString());
 AddUpdatedFld(conAppCodeTypeRela.ViewTypeCode);
}
else if (strAttributeName  ==  conAppCodeTypeRela.TabMainTypeId)
{
mstrTabMainTypeId = value.ToString();
 AddUpdatedFld(conAppCodeTypeRela.TabMainTypeId);
}
else if (strAttributeName  ==  conAppCodeTypeRela.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conAppCodeTypeRela.IsVisible);
}
else if (strAttributeName  ==  conAppCodeTypeRela.IsInGroupGeneCode)
{
mbolIsInGroupGeneCode = TransNullToBool(value.ToString());
 AddUpdatedFld(conAppCodeTypeRela.IsInGroupGeneCode);
}
else if (strAttributeName  ==  conAppCodeTypeRela.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conAppCodeTypeRela.OrderNum);
}
else if (strAttributeName  ==  conAppCodeTypeRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conAppCodeTypeRela.UpdDate);
}
else if (strAttributeName  ==  conAppCodeTypeRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conAppCodeTypeRela.UpdUser);
}
else if (strAttributeName  ==  conAppCodeTypeRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conAppCodeTypeRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conAppCodeTypeRela.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (conAppCodeTypeRela.ApplicationTypeId  ==  _AttributeName[intIndex])
{
return mintApplicationTypeId;
}
else if (conAppCodeTypeRela.CodeTypeId  ==  _AttributeName[intIndex])
{
return mstrCodeTypeId;
}
else if (conAppCodeTypeRela.ViewTypeCode  ==  _AttributeName[intIndex])
{
return mintViewTypeCode;
}
else if (conAppCodeTypeRela.TabMainTypeId  ==  _AttributeName[intIndex])
{
return mstrTabMainTypeId;
}
else if (conAppCodeTypeRela.IsVisible  ==  _AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (conAppCodeTypeRela.IsInGroupGeneCode  ==  _AttributeName[intIndex])
{
return mbolIsInGroupGeneCode;
}
else if (conAppCodeTypeRela.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conAppCodeTypeRela.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conAppCodeTypeRela.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conAppCodeTypeRela.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conAppCodeTypeRela.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conAppCodeTypeRela.mId);
}
else if (conAppCodeTypeRela.ApplicationTypeId  ==  _AttributeName[intIndex])
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conAppCodeTypeRela.ApplicationTypeId);
}
else if (conAppCodeTypeRela.CodeTypeId  ==  _AttributeName[intIndex])
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(conAppCodeTypeRela.CodeTypeId);
}
else if (conAppCodeTypeRela.ViewTypeCode  ==  _AttributeName[intIndex])
{
mintViewTypeCode = TransNullToInt(value.ToString());
 AddUpdatedFld(conAppCodeTypeRela.ViewTypeCode);
}
else if (conAppCodeTypeRela.TabMainTypeId  ==  _AttributeName[intIndex])
{
mstrTabMainTypeId = value.ToString();
 AddUpdatedFld(conAppCodeTypeRela.TabMainTypeId);
}
else if (conAppCodeTypeRela.IsVisible  ==  _AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conAppCodeTypeRela.IsVisible);
}
else if (conAppCodeTypeRela.IsInGroupGeneCode  ==  _AttributeName[intIndex])
{
mbolIsInGroupGeneCode = TransNullToBool(value.ToString());
 AddUpdatedFld(conAppCodeTypeRela.IsInGroupGeneCode);
}
else if (conAppCodeTypeRela.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conAppCodeTypeRela.OrderNum);
}
else if (conAppCodeTypeRela.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conAppCodeTypeRela.UpdDate);
}
else if (conAppCodeTypeRela.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conAppCodeTypeRela.UpdUser);
}
else if (conAppCodeTypeRela.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conAppCodeTypeRela.Memo);
}
}
}

/// <summary>
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long mId
{
get
{
return mlngmId;
}
set
{
 mlngmId = value;
//记录修改过的字段
 AddUpdatedFld(conAppCodeTypeRela.mId);
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
 AddUpdatedFld(conAppCodeTypeRela.ApplicationTypeId);
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
 AddUpdatedFld(conAppCodeTypeRela.CodeTypeId);
}
}
/// <summary>
/// 界面类型码(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? ViewTypeCode
{
get
{
return mintViewTypeCode;
}
set
{
 mintViewTypeCode = value;
//记录修改过的字段
 AddUpdatedFld(conAppCodeTypeRela.ViewTypeCode);
}
}
/// <summary>
/// 表主类型Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabMainTypeId
{
get
{
return mstrTabMainTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabMainTypeId = value;
}
else
{
 mstrTabMainTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conAppCodeTypeRela.TabMainTypeId);
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
 AddUpdatedFld(conAppCodeTypeRela.IsVisible);
}
}
/// <summary>
/// 是否参与组生成代码(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsInGroupGeneCode
{
get
{
return mbolIsInGroupGeneCode;
}
set
{
 mbolIsInGroupGeneCode = value;
//记录修改过的字段
 AddUpdatedFld(conAppCodeTypeRela.IsInGroupGeneCode);
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
 AddUpdatedFld(conAppCodeTypeRela.OrderNum);
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
 AddUpdatedFld(conAppCodeTypeRela.UpdDate);
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
 AddUpdatedFld(conAppCodeTypeRela.UpdUser);
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
 AddUpdatedFld(conAppCodeTypeRela.Memo);
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
  return mlngmId.ToString();
 }
 }
}
 /// <summary>
 /// 应用程序代码类型关系(AppCodeTypeRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conAppCodeTypeRela
{
public const string _CurrTabName = "AppCodeTypeRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "ApplicationTypeId", "CodeTypeId", "ViewTypeCode", "TabMainTypeId", "IsVisible", "IsInGroupGeneCode", "OrderNum", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"ApplicationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeId = "ApplicationTypeId";    //应用程序类型ID

 /// <summary>
 /// 常量:"CodeTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTypeId = "CodeTypeId";    //代码类型Id

 /// <summary>
 /// 常量:"ViewTypeCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewTypeCode = "ViewTypeCode";    //界面类型码

 /// <summary>
 /// 常量:"TabMainTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabMainTypeId = "TabMainTypeId";    //表主类型Id

 /// <summary>
 /// 常量:"IsVisible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVisible = "IsVisible";    //是否显示

 /// <summary>
 /// 常量:"IsInGroupGeneCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsInGroupGeneCode = "IsInGroupGeneCode";    //是否参与组生成代码

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