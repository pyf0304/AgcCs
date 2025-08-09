
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewRelaTabEN
 表名:vViewRelaTab(00050476)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:05:53
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:界面管理(PrjInterface)
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
 /// 表vViewRelaTab的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vViewRelaTab
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
public K_mId_vViewRelaTab(long lngmId)
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
 /// <returns>返回:[K_mId_vViewRelaTab]类型的对象</returns>
public static implicit operator K_mId_vViewRelaTab(long value)
{
return new K_mId_vViewRelaTab(value);
}
}
 /// <summary>
 /// v界面相关表(vViewRelaTab)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvViewRelaTabEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vViewRelaTab"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 19;
public static string[] _AttributeName = new string[] {"mId", "ViewId", "ViewName", "ViewCnName", "RegionId", "RegionName", "RegionTypeId", "RegionTypeName", "InOutTypeId", "InOutTypeName", "ViewTabTypeId", "ViewTabTypeName", "TabId", "TabName", "TabFunction", "PrjId", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrViewId;    //界面Id
protected string mstrViewName;    //界面名称
protected string mstrViewCnName;    //视图中文名
protected string mstrRegionId;    //区域Id
protected string mstrRegionName;    //区域名称
protected string mstrRegionTypeId;    //区域类型Id
protected string mstrRegionTypeName;    //区域类型名称
protected string mstrInOutTypeId;    //INOUT类型ID
protected string mstrInOutTypeName;    //INOUT类型名称
protected string mstrViewTabTypeId;    //界面表类型码
protected string mstrViewTabTypeName;    //ViewTabTypeName
protected string mstrTabId;    //表ID
protected string mstrTabName;    //表名
protected string mstrTabFunction;    //表功能说明
protected string mstrPrjId;    //工程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvViewRelaTabEN()
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
public clsvViewRelaTabEN(long lngmId)
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
if (strAttributeName  ==  convViewRelaTab.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convViewRelaTab.ViewId)
{
return mstrViewId;
}
else if (strAttributeName  ==  convViewRelaTab.ViewName)
{
return mstrViewName;
}
else if (strAttributeName  ==  convViewRelaTab.ViewCnName)
{
return mstrViewCnName;
}
else if (strAttributeName  ==  convViewRelaTab.RegionId)
{
return mstrRegionId;
}
else if (strAttributeName  ==  convViewRelaTab.RegionName)
{
return mstrRegionName;
}
else if (strAttributeName  ==  convViewRelaTab.RegionTypeId)
{
return mstrRegionTypeId;
}
else if (strAttributeName  ==  convViewRelaTab.RegionTypeName)
{
return mstrRegionTypeName;
}
else if (strAttributeName  ==  convViewRelaTab.InOutTypeId)
{
return mstrInOutTypeId;
}
else if (strAttributeName  ==  convViewRelaTab.InOutTypeName)
{
return mstrInOutTypeName;
}
else if (strAttributeName  ==  convViewRelaTab.ViewTabTypeId)
{
return mstrViewTabTypeId;
}
else if (strAttributeName  ==  convViewRelaTab.ViewTabTypeName)
{
return mstrViewTabTypeName;
}
else if (strAttributeName  ==  convViewRelaTab.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  convViewRelaTab.TabName)
{
return mstrTabName;
}
else if (strAttributeName  ==  convViewRelaTab.TabFunction)
{
return mstrTabFunction;
}
else if (strAttributeName  ==  convViewRelaTab.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convViewRelaTab.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convViewRelaTab.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convViewRelaTab.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convViewRelaTab.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewRelaTab.mId);
}
else if (strAttributeName  ==  convViewRelaTab.ViewId)
{
mstrViewId = value.ToString();
 AddUpdatedFld(convViewRelaTab.ViewId);
}
else if (strAttributeName  ==  convViewRelaTab.ViewName)
{
mstrViewName = value.ToString();
 AddUpdatedFld(convViewRelaTab.ViewName);
}
else if (strAttributeName  ==  convViewRelaTab.ViewCnName)
{
mstrViewCnName = value.ToString();
 AddUpdatedFld(convViewRelaTab.ViewCnName);
}
else if (strAttributeName  ==  convViewRelaTab.RegionId)
{
mstrRegionId = value.ToString();
 AddUpdatedFld(convViewRelaTab.RegionId);
}
else if (strAttributeName  ==  convViewRelaTab.RegionName)
{
mstrRegionName = value.ToString();
 AddUpdatedFld(convViewRelaTab.RegionName);
}
else if (strAttributeName  ==  convViewRelaTab.RegionTypeId)
{
mstrRegionTypeId = value.ToString();
 AddUpdatedFld(convViewRelaTab.RegionTypeId);
}
else if (strAttributeName  ==  convViewRelaTab.RegionTypeName)
{
mstrRegionTypeName = value.ToString();
 AddUpdatedFld(convViewRelaTab.RegionTypeName);
}
else if (strAttributeName  ==  convViewRelaTab.InOutTypeId)
{
mstrInOutTypeId = value.ToString();
 AddUpdatedFld(convViewRelaTab.InOutTypeId);
}
else if (strAttributeName  ==  convViewRelaTab.InOutTypeName)
{
mstrInOutTypeName = value.ToString();
 AddUpdatedFld(convViewRelaTab.InOutTypeName);
}
else if (strAttributeName  ==  convViewRelaTab.ViewTabTypeId)
{
mstrViewTabTypeId = value.ToString();
 AddUpdatedFld(convViewRelaTab.ViewTabTypeId);
}
else if (strAttributeName  ==  convViewRelaTab.ViewTabTypeName)
{
mstrViewTabTypeName = value.ToString();
 AddUpdatedFld(convViewRelaTab.ViewTabTypeName);
}
else if (strAttributeName  ==  convViewRelaTab.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(convViewRelaTab.TabId);
}
else if (strAttributeName  ==  convViewRelaTab.TabName)
{
mstrTabName = value.ToString();
 AddUpdatedFld(convViewRelaTab.TabName);
}
else if (strAttributeName  ==  convViewRelaTab.TabFunction)
{
mstrTabFunction = value.ToString();
 AddUpdatedFld(convViewRelaTab.TabFunction);
}
else if (strAttributeName  ==  convViewRelaTab.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convViewRelaTab.PrjId);
}
else if (strAttributeName  ==  convViewRelaTab.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convViewRelaTab.UpdDate);
}
else if (strAttributeName  ==  convViewRelaTab.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convViewRelaTab.UpdUser);
}
else if (strAttributeName  ==  convViewRelaTab.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convViewRelaTab.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convViewRelaTab.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (convViewRelaTab.ViewId  ==  _AttributeName[intIndex])
{
return mstrViewId;
}
else if (convViewRelaTab.ViewName  ==  _AttributeName[intIndex])
{
return mstrViewName;
}
else if (convViewRelaTab.ViewCnName  ==  _AttributeName[intIndex])
{
return mstrViewCnName;
}
else if (convViewRelaTab.RegionId  ==  _AttributeName[intIndex])
{
return mstrRegionId;
}
else if (convViewRelaTab.RegionName  ==  _AttributeName[intIndex])
{
return mstrRegionName;
}
else if (convViewRelaTab.RegionTypeId  ==  _AttributeName[intIndex])
{
return mstrRegionTypeId;
}
else if (convViewRelaTab.RegionTypeName  ==  _AttributeName[intIndex])
{
return mstrRegionTypeName;
}
else if (convViewRelaTab.InOutTypeId  ==  _AttributeName[intIndex])
{
return mstrInOutTypeId;
}
else if (convViewRelaTab.InOutTypeName  ==  _AttributeName[intIndex])
{
return mstrInOutTypeName;
}
else if (convViewRelaTab.ViewTabTypeId  ==  _AttributeName[intIndex])
{
return mstrViewTabTypeId;
}
else if (convViewRelaTab.ViewTabTypeName  ==  _AttributeName[intIndex])
{
return mstrViewTabTypeName;
}
else if (convViewRelaTab.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (convViewRelaTab.TabName  ==  _AttributeName[intIndex])
{
return mstrTabName;
}
else if (convViewRelaTab.TabFunction  ==  _AttributeName[intIndex])
{
return mstrTabFunction;
}
else if (convViewRelaTab.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convViewRelaTab.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convViewRelaTab.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convViewRelaTab.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convViewRelaTab.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewRelaTab.mId);
}
else if (convViewRelaTab.ViewId  ==  _AttributeName[intIndex])
{
mstrViewId = value.ToString();
 AddUpdatedFld(convViewRelaTab.ViewId);
}
else if (convViewRelaTab.ViewName  ==  _AttributeName[intIndex])
{
mstrViewName = value.ToString();
 AddUpdatedFld(convViewRelaTab.ViewName);
}
else if (convViewRelaTab.ViewCnName  ==  _AttributeName[intIndex])
{
mstrViewCnName = value.ToString();
 AddUpdatedFld(convViewRelaTab.ViewCnName);
}
else if (convViewRelaTab.RegionId  ==  _AttributeName[intIndex])
{
mstrRegionId = value.ToString();
 AddUpdatedFld(convViewRelaTab.RegionId);
}
else if (convViewRelaTab.RegionName  ==  _AttributeName[intIndex])
{
mstrRegionName = value.ToString();
 AddUpdatedFld(convViewRelaTab.RegionName);
}
else if (convViewRelaTab.RegionTypeId  ==  _AttributeName[intIndex])
{
mstrRegionTypeId = value.ToString();
 AddUpdatedFld(convViewRelaTab.RegionTypeId);
}
else if (convViewRelaTab.RegionTypeName  ==  _AttributeName[intIndex])
{
mstrRegionTypeName = value.ToString();
 AddUpdatedFld(convViewRelaTab.RegionTypeName);
}
else if (convViewRelaTab.InOutTypeId  ==  _AttributeName[intIndex])
{
mstrInOutTypeId = value.ToString();
 AddUpdatedFld(convViewRelaTab.InOutTypeId);
}
else if (convViewRelaTab.InOutTypeName  ==  _AttributeName[intIndex])
{
mstrInOutTypeName = value.ToString();
 AddUpdatedFld(convViewRelaTab.InOutTypeName);
}
else if (convViewRelaTab.ViewTabTypeId  ==  _AttributeName[intIndex])
{
mstrViewTabTypeId = value.ToString();
 AddUpdatedFld(convViewRelaTab.ViewTabTypeId);
}
else if (convViewRelaTab.ViewTabTypeName  ==  _AttributeName[intIndex])
{
mstrViewTabTypeName = value.ToString();
 AddUpdatedFld(convViewRelaTab.ViewTabTypeName);
}
else if (convViewRelaTab.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(convViewRelaTab.TabId);
}
else if (convViewRelaTab.TabName  ==  _AttributeName[intIndex])
{
mstrTabName = value.ToString();
 AddUpdatedFld(convViewRelaTab.TabName);
}
else if (convViewRelaTab.TabFunction  ==  _AttributeName[intIndex])
{
mstrTabFunction = value.ToString();
 AddUpdatedFld(convViewRelaTab.TabFunction);
}
else if (convViewRelaTab.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convViewRelaTab.PrjId);
}
else if (convViewRelaTab.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convViewRelaTab.UpdDate);
}
else if (convViewRelaTab.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convViewRelaTab.UpdUser);
}
else if (convViewRelaTab.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convViewRelaTab.Memo);
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
 AddUpdatedFld(convViewRelaTab.mId);
}
}
/// <summary>
/// 界面Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewId
{
get
{
return mstrViewId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewId = value;
}
else
{
 mstrViewId = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewRelaTab.ViewId);
}
}
/// <summary>
/// 界面名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewName
{
get
{
return mstrViewName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewName = value;
}
else
{
 mstrViewName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewRelaTab.ViewName);
}
}
/// <summary>
/// 视图中文名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewCnName
{
get
{
return mstrViewCnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewCnName = value;
}
else
{
 mstrViewCnName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewRelaTab.ViewCnName);
}
}
/// <summary>
/// 区域Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RegionId
{
get
{
return mstrRegionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRegionId = value;
}
else
{
 mstrRegionId = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewRelaTab.RegionId);
}
}
/// <summary>
/// 区域名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RegionName
{
get
{
return mstrRegionName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRegionName = value;
}
else
{
 mstrRegionName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewRelaTab.RegionName);
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
 AddUpdatedFld(convViewRelaTab.RegionTypeId);
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
 AddUpdatedFld(convViewRelaTab.RegionTypeName);
}
}
/// <summary>
/// INOUT类型ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string InOutTypeId
{
get
{
return mstrInOutTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrInOutTypeId = value;
}
else
{
 mstrInOutTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewRelaTab.InOutTypeId);
}
}
/// <summary>
/// INOUT类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string InOutTypeName
{
get
{
return mstrInOutTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrInOutTypeName = value;
}
else
{
 mstrInOutTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewRelaTab.InOutTypeName);
}
}
/// <summary>
/// 界面表类型码(说明:;字段类型:varchar;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewTabTypeId
{
get
{
return mstrViewTabTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewTabTypeId = value;
}
else
{
 mstrViewTabTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewRelaTab.ViewTabTypeId);
}
}
/// <summary>
/// ViewTabTypeName(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewTabTypeName
{
get
{
return mstrViewTabTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewTabTypeName = value;
}
else
{
 mstrViewTabTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewRelaTab.ViewTabTypeName);
}
}
/// <summary>
/// 表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabId
{
get
{
return mstrTabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabId = value;
}
else
{
 mstrTabId = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewRelaTab.TabId);
}
}
/// <summary>
/// 表名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabName
{
get
{
return mstrTabName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabName = value;
}
else
{
 mstrTabName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewRelaTab.TabName);
}
}
/// <summary>
/// 表功能说明(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabFunction
{
get
{
return mstrTabFunction;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabFunction = value;
}
else
{
 mstrTabFunction = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewRelaTab.TabFunction);
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
 AddUpdatedFld(convViewRelaTab.PrjId);
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
 AddUpdatedFld(convViewRelaTab.UpdDate);
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
 AddUpdatedFld(convViewRelaTab.UpdUser);
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
 AddUpdatedFld(convViewRelaTab.Memo);
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
 /// v界面相关表(vViewRelaTab)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convViewRelaTab
{
public const string _CurrTabName = "vViewRelaTab"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "ViewId", "ViewName", "ViewCnName", "RegionId", "RegionName", "RegionTypeId", "RegionTypeName", "InOutTypeId", "InOutTypeName", "ViewTabTypeId", "ViewTabTypeName", "TabId", "TabName", "TabFunction", "PrjId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"ViewId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewId = "ViewId";    //界面Id

 /// <summary>
 /// 常量:"ViewName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewName = "ViewName";    //界面名称

 /// <summary>
 /// 常量:"ViewCnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewCnName = "ViewCnName";    //视图中文名

 /// <summary>
 /// 常量:"RegionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RegionId = "RegionId";    //区域Id

 /// <summary>
 /// 常量:"RegionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RegionName = "RegionName";    //区域名称

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
 /// 常量:"InOutTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InOutTypeId = "InOutTypeId";    //INOUT类型ID

 /// <summary>
 /// 常量:"InOutTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InOutTypeName = "InOutTypeName";    //INOUT类型名称

 /// <summary>
 /// 常量:"ViewTabTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewTabTypeId = "ViewTabTypeId";    //界面表类型码

 /// <summary>
 /// 常量:"ViewTabTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewTabTypeName = "ViewTabTypeName";    //ViewTabTypeName

 /// <summary>
 /// 常量:"TabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabId = "TabId";    //表ID

 /// <summary>
 /// 常量:"TabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabName = "TabName";    //表名

 /// <summary>
 /// 常量:"TabFunction"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabFunction = "TabFunction";    //表功能说明

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