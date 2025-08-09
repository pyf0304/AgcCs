
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvAppCodeTypeRelaEN
 表名:vAppCodeTypeRela(00050419)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:04:40
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
 /// 表vAppCodeTypeRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vAppCodeTypeRela
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
public K_mId_vAppCodeTypeRela(long lngmId)
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
 /// <returns>返回:[K_mId_vAppCodeTypeRela]类型的对象</returns>
public static implicit operator K_mId_vAppCodeTypeRela(long value)
{
return new K_mId_vAppCodeTypeRela(value);
}
}
 /// <summary>
 /// v应用程序代码类型关系(vAppCodeTypeRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvAppCodeTypeRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vAppCodeTypeRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 27;
public static string[] _AttributeName = new string[] {"mId", "ApplicationTypeId", "ApplicationTypeName", "ApplicationTypeENName", "CodeTypeId", "CodeTypeName", "CodeTypeSimName", "CodeTypeENName", "GroupName", "ProgLangTypeId", "ProgLangTypeName", "ProgLangTypeSimName", "RegionTypeId", "RegionTypeName", "DependsOn", "FrontOrBack", "AppCount", "ViewTypeCode", "ViewTypeName", "TabMainTypeId", "TabMainTypeName", "IsVisible", "IsInGroupGeneCode", "OrderNum", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected int mintApplicationTypeId;    //应用程序类型ID
protected string mstrApplicationTypeName;    //应用程序类型名称
protected string mstrApplicationTypeENName;    //应用类型英文名
protected string mstrCodeTypeId;    //代码类型Id
protected string mstrCodeTypeName;    //代码类型名
protected string mstrCodeTypeSimName;    //简称
protected string mstrCodeTypeENName;    //代码类型英文名
protected string mstrGroupName;    //组名
protected string mstrProgLangTypeId;    //编程语言类型Id
protected string mstrProgLangTypeName;    //编程语言类型名
protected string mstrProgLangTypeSimName;    //编程语言类型简称
protected string mstrRegionTypeId;    //区域类型Id
protected string mstrRegionTypeName;    //区域类型名称
protected string mstrDependsOn;    //依赖于
protected string mstrFrontOrBack;    //前台Or后台
protected int? mintAppCount;    //应用数
protected int? mintViewTypeCode;    //界面类型码
protected string mstrViewTypeName;    //界面类型名称
protected string mstrTabMainTypeId;    //表主类型Id
protected string mstrTabMainTypeName;    //表主类型名
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
 public clsvAppCodeTypeRelaEN()
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
public clsvAppCodeTypeRelaEN(long lngmId)
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
if (strAttributeName  ==  convAppCodeTypeRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convAppCodeTypeRela.ApplicationTypeId)
{
return mintApplicationTypeId;
}
else if (strAttributeName  ==  convAppCodeTypeRela.ApplicationTypeName)
{
return mstrApplicationTypeName;
}
else if (strAttributeName  ==  convAppCodeTypeRela.ApplicationTypeENName)
{
return mstrApplicationTypeENName;
}
else if (strAttributeName  ==  convAppCodeTypeRela.CodeTypeId)
{
return mstrCodeTypeId;
}
else if (strAttributeName  ==  convAppCodeTypeRela.CodeTypeName)
{
return mstrCodeTypeName;
}
else if (strAttributeName  ==  convAppCodeTypeRela.CodeTypeSimName)
{
return mstrCodeTypeSimName;
}
else if (strAttributeName  ==  convAppCodeTypeRela.CodeTypeENName)
{
return mstrCodeTypeENName;
}
else if (strAttributeName  ==  convAppCodeTypeRela.GroupName)
{
return mstrGroupName;
}
else if (strAttributeName  ==  convAppCodeTypeRela.ProgLangTypeId)
{
return mstrProgLangTypeId;
}
else if (strAttributeName  ==  convAppCodeTypeRela.ProgLangTypeName)
{
return mstrProgLangTypeName;
}
else if (strAttributeName  ==  convAppCodeTypeRela.ProgLangTypeSimName)
{
return mstrProgLangTypeSimName;
}
else if (strAttributeName  ==  convAppCodeTypeRela.RegionTypeId)
{
return mstrRegionTypeId;
}
else if (strAttributeName  ==  convAppCodeTypeRela.RegionTypeName)
{
return mstrRegionTypeName;
}
else if (strAttributeName  ==  convAppCodeTypeRela.DependsOn)
{
return mstrDependsOn;
}
else if (strAttributeName  ==  convAppCodeTypeRela.FrontOrBack)
{
return mstrFrontOrBack;
}
else if (strAttributeName  ==  convAppCodeTypeRela.AppCount)
{
return mintAppCount;
}
else if (strAttributeName  ==  convAppCodeTypeRela.ViewTypeCode)
{
return mintViewTypeCode;
}
else if (strAttributeName  ==  convAppCodeTypeRela.ViewTypeName)
{
return mstrViewTypeName;
}
else if (strAttributeName  ==  convAppCodeTypeRela.TabMainTypeId)
{
return mstrTabMainTypeId;
}
else if (strAttributeName  ==  convAppCodeTypeRela.TabMainTypeName)
{
return mstrTabMainTypeName;
}
else if (strAttributeName  ==  convAppCodeTypeRela.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  convAppCodeTypeRela.IsInGroupGeneCode)
{
return mbolIsInGroupGeneCode;
}
else if (strAttributeName  ==  convAppCodeTypeRela.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convAppCodeTypeRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convAppCodeTypeRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convAppCodeTypeRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convAppCodeTypeRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convAppCodeTypeRela.mId);
}
else if (strAttributeName  ==  convAppCodeTypeRela.ApplicationTypeId)
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convAppCodeTypeRela.ApplicationTypeId);
}
else if (strAttributeName  ==  convAppCodeTypeRela.ApplicationTypeName)
{
mstrApplicationTypeName = value.ToString();
 AddUpdatedFld(convAppCodeTypeRela.ApplicationTypeName);
}
else if (strAttributeName  ==  convAppCodeTypeRela.ApplicationTypeENName)
{
mstrApplicationTypeENName = value.ToString();
 AddUpdatedFld(convAppCodeTypeRela.ApplicationTypeENName);
}
else if (strAttributeName  ==  convAppCodeTypeRela.CodeTypeId)
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(convAppCodeTypeRela.CodeTypeId);
}
else if (strAttributeName  ==  convAppCodeTypeRela.CodeTypeName)
{
mstrCodeTypeName = value.ToString();
 AddUpdatedFld(convAppCodeTypeRela.CodeTypeName);
}
else if (strAttributeName  ==  convAppCodeTypeRela.CodeTypeSimName)
{
mstrCodeTypeSimName = value.ToString();
 AddUpdatedFld(convAppCodeTypeRela.CodeTypeSimName);
}
else if (strAttributeName  ==  convAppCodeTypeRela.CodeTypeENName)
{
mstrCodeTypeENName = value.ToString();
 AddUpdatedFld(convAppCodeTypeRela.CodeTypeENName);
}
else if (strAttributeName  ==  convAppCodeTypeRela.GroupName)
{
mstrGroupName = value.ToString();
 AddUpdatedFld(convAppCodeTypeRela.GroupName);
}
else if (strAttributeName  ==  convAppCodeTypeRela.ProgLangTypeId)
{
mstrProgLangTypeId = value.ToString();
 AddUpdatedFld(convAppCodeTypeRela.ProgLangTypeId);
}
else if (strAttributeName  ==  convAppCodeTypeRela.ProgLangTypeName)
{
mstrProgLangTypeName = value.ToString();
 AddUpdatedFld(convAppCodeTypeRela.ProgLangTypeName);
}
else if (strAttributeName  ==  convAppCodeTypeRela.ProgLangTypeSimName)
{
mstrProgLangTypeSimName = value.ToString();
 AddUpdatedFld(convAppCodeTypeRela.ProgLangTypeSimName);
}
else if (strAttributeName  ==  convAppCodeTypeRela.RegionTypeId)
{
mstrRegionTypeId = value.ToString();
 AddUpdatedFld(convAppCodeTypeRela.RegionTypeId);
}
else if (strAttributeName  ==  convAppCodeTypeRela.RegionTypeName)
{
mstrRegionTypeName = value.ToString();
 AddUpdatedFld(convAppCodeTypeRela.RegionTypeName);
}
else if (strAttributeName  ==  convAppCodeTypeRela.DependsOn)
{
mstrDependsOn = value.ToString();
 AddUpdatedFld(convAppCodeTypeRela.DependsOn);
}
else if (strAttributeName  ==  convAppCodeTypeRela.FrontOrBack)
{
mstrFrontOrBack = value.ToString();
 AddUpdatedFld(convAppCodeTypeRela.FrontOrBack);
}
else if (strAttributeName  ==  convAppCodeTypeRela.AppCount)
{
mintAppCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convAppCodeTypeRela.AppCount);
}
else if (strAttributeName  ==  convAppCodeTypeRela.ViewTypeCode)
{
mintViewTypeCode = TransNullToInt(value.ToString());
 AddUpdatedFld(convAppCodeTypeRela.ViewTypeCode);
}
else if (strAttributeName  ==  convAppCodeTypeRela.ViewTypeName)
{
mstrViewTypeName = value.ToString();
 AddUpdatedFld(convAppCodeTypeRela.ViewTypeName);
}
else if (strAttributeName  ==  convAppCodeTypeRela.TabMainTypeId)
{
mstrTabMainTypeId = value.ToString();
 AddUpdatedFld(convAppCodeTypeRela.TabMainTypeId);
}
else if (strAttributeName  ==  convAppCodeTypeRela.TabMainTypeName)
{
mstrTabMainTypeName = value.ToString();
 AddUpdatedFld(convAppCodeTypeRela.TabMainTypeName);
}
else if (strAttributeName  ==  convAppCodeTypeRela.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convAppCodeTypeRela.IsVisible);
}
else if (strAttributeName  ==  convAppCodeTypeRela.IsInGroupGeneCode)
{
mbolIsInGroupGeneCode = TransNullToBool(value.ToString());
 AddUpdatedFld(convAppCodeTypeRela.IsInGroupGeneCode);
}
else if (strAttributeName  ==  convAppCodeTypeRela.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convAppCodeTypeRela.OrderNum);
}
else if (strAttributeName  ==  convAppCodeTypeRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convAppCodeTypeRela.UpdDate);
}
else if (strAttributeName  ==  convAppCodeTypeRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convAppCodeTypeRela.UpdUser);
}
else if (strAttributeName  ==  convAppCodeTypeRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convAppCodeTypeRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convAppCodeTypeRela.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (convAppCodeTypeRela.ApplicationTypeId  ==  _AttributeName[intIndex])
{
return mintApplicationTypeId;
}
else if (convAppCodeTypeRela.ApplicationTypeName  ==  _AttributeName[intIndex])
{
return mstrApplicationTypeName;
}
else if (convAppCodeTypeRela.ApplicationTypeENName  ==  _AttributeName[intIndex])
{
return mstrApplicationTypeENName;
}
else if (convAppCodeTypeRela.CodeTypeId  ==  _AttributeName[intIndex])
{
return mstrCodeTypeId;
}
else if (convAppCodeTypeRela.CodeTypeName  ==  _AttributeName[intIndex])
{
return mstrCodeTypeName;
}
else if (convAppCodeTypeRela.CodeTypeSimName  ==  _AttributeName[intIndex])
{
return mstrCodeTypeSimName;
}
else if (convAppCodeTypeRela.CodeTypeENName  ==  _AttributeName[intIndex])
{
return mstrCodeTypeENName;
}
else if (convAppCodeTypeRela.GroupName  ==  _AttributeName[intIndex])
{
return mstrGroupName;
}
else if (convAppCodeTypeRela.ProgLangTypeId  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeId;
}
else if (convAppCodeTypeRela.ProgLangTypeName  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeName;
}
else if (convAppCodeTypeRela.ProgLangTypeSimName  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeSimName;
}
else if (convAppCodeTypeRela.RegionTypeId  ==  _AttributeName[intIndex])
{
return mstrRegionTypeId;
}
else if (convAppCodeTypeRela.RegionTypeName  ==  _AttributeName[intIndex])
{
return mstrRegionTypeName;
}
else if (convAppCodeTypeRela.DependsOn  ==  _AttributeName[intIndex])
{
return mstrDependsOn;
}
else if (convAppCodeTypeRela.FrontOrBack  ==  _AttributeName[intIndex])
{
return mstrFrontOrBack;
}
else if (convAppCodeTypeRela.AppCount  ==  _AttributeName[intIndex])
{
return mintAppCount;
}
else if (convAppCodeTypeRela.ViewTypeCode  ==  _AttributeName[intIndex])
{
return mintViewTypeCode;
}
else if (convAppCodeTypeRela.ViewTypeName  ==  _AttributeName[intIndex])
{
return mstrViewTypeName;
}
else if (convAppCodeTypeRela.TabMainTypeId  ==  _AttributeName[intIndex])
{
return mstrTabMainTypeId;
}
else if (convAppCodeTypeRela.TabMainTypeName  ==  _AttributeName[intIndex])
{
return mstrTabMainTypeName;
}
else if (convAppCodeTypeRela.IsVisible  ==  _AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (convAppCodeTypeRela.IsInGroupGeneCode  ==  _AttributeName[intIndex])
{
return mbolIsInGroupGeneCode;
}
else if (convAppCodeTypeRela.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convAppCodeTypeRela.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convAppCodeTypeRela.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convAppCodeTypeRela.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convAppCodeTypeRela.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convAppCodeTypeRela.mId);
}
else if (convAppCodeTypeRela.ApplicationTypeId  ==  _AttributeName[intIndex])
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convAppCodeTypeRela.ApplicationTypeId);
}
else if (convAppCodeTypeRela.ApplicationTypeName  ==  _AttributeName[intIndex])
{
mstrApplicationTypeName = value.ToString();
 AddUpdatedFld(convAppCodeTypeRela.ApplicationTypeName);
}
else if (convAppCodeTypeRela.ApplicationTypeENName  ==  _AttributeName[intIndex])
{
mstrApplicationTypeENName = value.ToString();
 AddUpdatedFld(convAppCodeTypeRela.ApplicationTypeENName);
}
else if (convAppCodeTypeRela.CodeTypeId  ==  _AttributeName[intIndex])
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(convAppCodeTypeRela.CodeTypeId);
}
else if (convAppCodeTypeRela.CodeTypeName  ==  _AttributeName[intIndex])
{
mstrCodeTypeName = value.ToString();
 AddUpdatedFld(convAppCodeTypeRela.CodeTypeName);
}
else if (convAppCodeTypeRela.CodeTypeSimName  ==  _AttributeName[intIndex])
{
mstrCodeTypeSimName = value.ToString();
 AddUpdatedFld(convAppCodeTypeRela.CodeTypeSimName);
}
else if (convAppCodeTypeRela.CodeTypeENName  ==  _AttributeName[intIndex])
{
mstrCodeTypeENName = value.ToString();
 AddUpdatedFld(convAppCodeTypeRela.CodeTypeENName);
}
else if (convAppCodeTypeRela.GroupName  ==  _AttributeName[intIndex])
{
mstrGroupName = value.ToString();
 AddUpdatedFld(convAppCodeTypeRela.GroupName);
}
else if (convAppCodeTypeRela.ProgLangTypeId  ==  _AttributeName[intIndex])
{
mstrProgLangTypeId = value.ToString();
 AddUpdatedFld(convAppCodeTypeRela.ProgLangTypeId);
}
else if (convAppCodeTypeRela.ProgLangTypeName  ==  _AttributeName[intIndex])
{
mstrProgLangTypeName = value.ToString();
 AddUpdatedFld(convAppCodeTypeRela.ProgLangTypeName);
}
else if (convAppCodeTypeRela.ProgLangTypeSimName  ==  _AttributeName[intIndex])
{
mstrProgLangTypeSimName = value.ToString();
 AddUpdatedFld(convAppCodeTypeRela.ProgLangTypeSimName);
}
else if (convAppCodeTypeRela.RegionTypeId  ==  _AttributeName[intIndex])
{
mstrRegionTypeId = value.ToString();
 AddUpdatedFld(convAppCodeTypeRela.RegionTypeId);
}
else if (convAppCodeTypeRela.RegionTypeName  ==  _AttributeName[intIndex])
{
mstrRegionTypeName = value.ToString();
 AddUpdatedFld(convAppCodeTypeRela.RegionTypeName);
}
else if (convAppCodeTypeRela.DependsOn  ==  _AttributeName[intIndex])
{
mstrDependsOn = value.ToString();
 AddUpdatedFld(convAppCodeTypeRela.DependsOn);
}
else if (convAppCodeTypeRela.FrontOrBack  ==  _AttributeName[intIndex])
{
mstrFrontOrBack = value.ToString();
 AddUpdatedFld(convAppCodeTypeRela.FrontOrBack);
}
else if (convAppCodeTypeRela.AppCount  ==  _AttributeName[intIndex])
{
mintAppCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convAppCodeTypeRela.AppCount);
}
else if (convAppCodeTypeRela.ViewTypeCode  ==  _AttributeName[intIndex])
{
mintViewTypeCode = TransNullToInt(value.ToString());
 AddUpdatedFld(convAppCodeTypeRela.ViewTypeCode);
}
else if (convAppCodeTypeRela.ViewTypeName  ==  _AttributeName[intIndex])
{
mstrViewTypeName = value.ToString();
 AddUpdatedFld(convAppCodeTypeRela.ViewTypeName);
}
else if (convAppCodeTypeRela.TabMainTypeId  ==  _AttributeName[intIndex])
{
mstrTabMainTypeId = value.ToString();
 AddUpdatedFld(convAppCodeTypeRela.TabMainTypeId);
}
else if (convAppCodeTypeRela.TabMainTypeName  ==  _AttributeName[intIndex])
{
mstrTabMainTypeName = value.ToString();
 AddUpdatedFld(convAppCodeTypeRela.TabMainTypeName);
}
else if (convAppCodeTypeRela.IsVisible  ==  _AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convAppCodeTypeRela.IsVisible);
}
else if (convAppCodeTypeRela.IsInGroupGeneCode  ==  _AttributeName[intIndex])
{
mbolIsInGroupGeneCode = TransNullToBool(value.ToString());
 AddUpdatedFld(convAppCodeTypeRela.IsInGroupGeneCode);
}
else if (convAppCodeTypeRela.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convAppCodeTypeRela.OrderNum);
}
else if (convAppCodeTypeRela.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convAppCodeTypeRela.UpdDate);
}
else if (convAppCodeTypeRela.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convAppCodeTypeRela.UpdUser);
}
else if (convAppCodeTypeRela.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convAppCodeTypeRela.Memo);
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
 AddUpdatedFld(convAppCodeTypeRela.mId);
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
 AddUpdatedFld(convAppCodeTypeRela.ApplicationTypeId);
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
 AddUpdatedFld(convAppCodeTypeRela.ApplicationTypeName);
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
 AddUpdatedFld(convAppCodeTypeRela.ApplicationTypeENName);
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
 AddUpdatedFld(convAppCodeTypeRela.CodeTypeId);
}
}
/// <summary>
/// 代码类型名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTypeName
{
get
{
return mstrCodeTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTypeName = value;
}
else
{
 mstrCodeTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convAppCodeTypeRela.CodeTypeName);
}
}
/// <summary>
/// 简称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTypeSimName
{
get
{
return mstrCodeTypeSimName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTypeSimName = value;
}
else
{
 mstrCodeTypeSimName = value;
}
//记录修改过的字段
 AddUpdatedFld(convAppCodeTypeRela.CodeTypeSimName);
}
}
/// <summary>
/// 代码类型英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTypeENName
{
get
{
return mstrCodeTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTypeENName = value;
}
else
{
 mstrCodeTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(convAppCodeTypeRela.CodeTypeENName);
}
}
/// <summary>
/// 组名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GroupName
{
get
{
return mstrGroupName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGroupName = value;
}
else
{
 mstrGroupName = value;
}
//记录修改过的字段
 AddUpdatedFld(convAppCodeTypeRela.GroupName);
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
 AddUpdatedFld(convAppCodeTypeRela.ProgLangTypeId);
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
 AddUpdatedFld(convAppCodeTypeRela.ProgLangTypeName);
}
}
/// <summary>
/// 编程语言类型简称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLangTypeSimName
{
get
{
return mstrProgLangTypeSimName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLangTypeSimName = value;
}
else
{
 mstrProgLangTypeSimName = value;
}
//记录修改过的字段
 AddUpdatedFld(convAppCodeTypeRela.ProgLangTypeSimName);
}
}
/// <summary>
/// 区域类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RegionTypeId
{
get
{
return mstrRegionTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRegionTypeId = value;
}
else
{
 mstrRegionTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convAppCodeTypeRela.RegionTypeId);
}
}
/// <summary>
/// 区域类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RegionTypeName
{
get
{
return mstrRegionTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRegionTypeName = value;
}
else
{
 mstrRegionTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convAppCodeTypeRela.RegionTypeName);
}
}
/// <summary>
/// 依赖于(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DependsOn
{
get
{
return mstrDependsOn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDependsOn = value;
}
else
{
 mstrDependsOn = value;
}
//记录修改过的字段
 AddUpdatedFld(convAppCodeTypeRela.DependsOn);
}
}
/// <summary>
/// 前台Or后台(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FrontOrBack
{
get
{
return mstrFrontOrBack;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFrontOrBack = value;
}
else
{
 mstrFrontOrBack = value;
}
//记录修改过的字段
 AddUpdatedFld(convAppCodeTypeRela.FrontOrBack);
}
}
/// <summary>
/// 应用数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? AppCount
{
get
{
return mintAppCount;
}
set
{
 mintAppCount = value;
//记录修改过的字段
 AddUpdatedFld(convAppCodeTypeRela.AppCount);
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
 AddUpdatedFld(convAppCodeTypeRela.ViewTypeCode);
}
}
/// <summary>
/// 界面类型名称(说明:;字段类型:varchar;字段长度:40;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewTypeName
{
get
{
return mstrViewTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewTypeName = value;
}
else
{
 mstrViewTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convAppCodeTypeRela.ViewTypeName);
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
 AddUpdatedFld(convAppCodeTypeRela.TabMainTypeId);
}
}
/// <summary>
/// 表主类型名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabMainTypeName
{
get
{
return mstrTabMainTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabMainTypeName = value;
}
else
{
 mstrTabMainTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convAppCodeTypeRela.TabMainTypeName);
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
 AddUpdatedFld(convAppCodeTypeRela.IsVisible);
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
 AddUpdatedFld(convAppCodeTypeRela.IsInGroupGeneCode);
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
 AddUpdatedFld(convAppCodeTypeRela.OrderNum);
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
 AddUpdatedFld(convAppCodeTypeRela.UpdDate);
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
 AddUpdatedFld(convAppCodeTypeRela.UpdUser);
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
 AddUpdatedFld(convAppCodeTypeRela.Memo);
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
 /// v应用程序代码类型关系(vAppCodeTypeRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convAppCodeTypeRela
{
public const string _CurrTabName = "vAppCodeTypeRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "ApplicationTypeId", "ApplicationTypeName", "ApplicationTypeENName", "CodeTypeId", "CodeTypeName", "CodeTypeSimName", "CodeTypeENName", "GroupName", "ProgLangTypeId", "ProgLangTypeName", "ProgLangTypeSimName", "RegionTypeId", "RegionTypeName", "DependsOn", "FrontOrBack", "AppCount", "ViewTypeCode", "ViewTypeName", "TabMainTypeId", "TabMainTypeName", "IsVisible", "IsInGroupGeneCode", "OrderNum", "UpdDate", "UpdUser", "Memo"};
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
 /// 常量:"ApplicationTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeName = "ApplicationTypeName";    //应用程序类型名称

 /// <summary>
 /// 常量:"ApplicationTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeENName = "ApplicationTypeENName";    //应用类型英文名

 /// <summary>
 /// 常量:"CodeTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTypeId = "CodeTypeId";    //代码类型Id

 /// <summary>
 /// 常量:"CodeTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTypeName = "CodeTypeName";    //代码类型名

 /// <summary>
 /// 常量:"CodeTypeSimName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTypeSimName = "CodeTypeSimName";    //简称

 /// <summary>
 /// 常量:"CodeTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTypeENName = "CodeTypeENName";    //代码类型英文名

 /// <summary>
 /// 常量:"GroupName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GroupName = "GroupName";    //组名

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
 /// 常量:"ProgLangTypeSimName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeSimName = "ProgLangTypeSimName";    //编程语言类型简称

 /// <summary>
 /// 常量:"RegionTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RegionTypeId = "RegionTypeId";    //区域类型Id

 /// <summary>
 /// 常量:"RegionTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RegionTypeName = "RegionTypeName";    //区域类型名称

 /// <summary>
 /// 常量:"DependsOn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DependsOn = "DependsOn";    //依赖于

 /// <summary>
 /// 常量:"FrontOrBack"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FrontOrBack = "FrontOrBack";    //前台Or后台

 /// <summary>
 /// 常量:"AppCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppCount = "AppCount";    //应用数

 /// <summary>
 /// 常量:"ViewTypeCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewTypeCode = "ViewTypeCode";    //界面类型码

 /// <summary>
 /// 常量:"ViewTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewTypeName = "ViewTypeName";    //界面类型名称

 /// <summary>
 /// 常量:"TabMainTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabMainTypeId = "TabMainTypeId";    //表主类型Id

 /// <summary>
 /// 常量:"TabMainTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabMainTypeName = "TabMainTypeName";    //表主类型名

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