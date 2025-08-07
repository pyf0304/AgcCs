
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewRelaTabEN
 表名:ViewRelaTab(00050100)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:26:54
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
 /// 表ViewRelaTab的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_ViewRelaTab
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
public K_mId_ViewRelaTab(long lngmId)
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
 /// <returns>返回:[K_mId_ViewRelaTab]类型的对象</returns>
public static implicit operator K_mId_ViewRelaTab(long value)
{
return new K_mId_ViewRelaTab(value);
}
}
 /// <summary>
 /// 界面相关表(ViewRelaTab)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsViewRelaTabEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ViewRelaTab"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 11;
public static string[] _AttributeName = new string[] {"mId", "ViewId", "RegionId", "InOutTypeId", "ViewTabTypeId", "TabId", "TabFunction", "PrjId", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrViewId;    //界面Id
protected string mstrRegionId;    //区域Id
protected string mstrInOutTypeId;    //INOUT类型ID
protected string mstrViewTabTypeId;    //界面表类型码
protected string mstrTabId;    //表ID
protected string mstrTabFunction;    //表功能说明
protected string mstrPrjId;    //工程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsViewRelaTabEN()
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
public clsViewRelaTabEN(long lngmId)
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
if (strAttributeName  ==  conViewRelaTab.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conViewRelaTab.ViewId)
{
return mstrViewId;
}
else if (strAttributeName  ==  conViewRelaTab.RegionId)
{
return mstrRegionId;
}
else if (strAttributeName  ==  conViewRelaTab.InOutTypeId)
{
return mstrInOutTypeId;
}
else if (strAttributeName  ==  conViewRelaTab.ViewTabTypeId)
{
return mstrViewTabTypeId;
}
else if (strAttributeName  ==  conViewRelaTab.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  conViewRelaTab.TabFunction)
{
return mstrTabFunction;
}
else if (strAttributeName  ==  conViewRelaTab.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conViewRelaTab.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conViewRelaTab.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conViewRelaTab.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conViewRelaTab.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewRelaTab.mId);
}
else if (strAttributeName  ==  conViewRelaTab.ViewId)
{
mstrViewId = value.ToString();
 AddUpdatedFld(conViewRelaTab.ViewId);
}
else if (strAttributeName  ==  conViewRelaTab.RegionId)
{
mstrRegionId = value.ToString();
 AddUpdatedFld(conViewRelaTab.RegionId);
}
else if (strAttributeName  ==  conViewRelaTab.InOutTypeId)
{
mstrInOutTypeId = value.ToString();
 AddUpdatedFld(conViewRelaTab.InOutTypeId);
}
else if (strAttributeName  ==  conViewRelaTab.ViewTabTypeId)
{
mstrViewTabTypeId = value.ToString();
 AddUpdatedFld(conViewRelaTab.ViewTabTypeId);
}
else if (strAttributeName  ==  conViewRelaTab.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(conViewRelaTab.TabId);
}
else if (strAttributeName  ==  conViewRelaTab.TabFunction)
{
mstrTabFunction = value.ToString();
 AddUpdatedFld(conViewRelaTab.TabFunction);
}
else if (strAttributeName  ==  conViewRelaTab.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conViewRelaTab.PrjId);
}
else if (strAttributeName  ==  conViewRelaTab.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conViewRelaTab.UpdDate);
}
else if (strAttributeName  ==  conViewRelaTab.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conViewRelaTab.UpdUser);
}
else if (strAttributeName  ==  conViewRelaTab.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conViewRelaTab.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conViewRelaTab.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (conViewRelaTab.ViewId  ==  _AttributeName[intIndex])
{
return mstrViewId;
}
else if (conViewRelaTab.RegionId  ==  _AttributeName[intIndex])
{
return mstrRegionId;
}
else if (conViewRelaTab.InOutTypeId  ==  _AttributeName[intIndex])
{
return mstrInOutTypeId;
}
else if (conViewRelaTab.ViewTabTypeId  ==  _AttributeName[intIndex])
{
return mstrViewTabTypeId;
}
else if (conViewRelaTab.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (conViewRelaTab.TabFunction  ==  _AttributeName[intIndex])
{
return mstrTabFunction;
}
else if (conViewRelaTab.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conViewRelaTab.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conViewRelaTab.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conViewRelaTab.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conViewRelaTab.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewRelaTab.mId);
}
else if (conViewRelaTab.ViewId  ==  _AttributeName[intIndex])
{
mstrViewId = value.ToString();
 AddUpdatedFld(conViewRelaTab.ViewId);
}
else if (conViewRelaTab.RegionId  ==  _AttributeName[intIndex])
{
mstrRegionId = value.ToString();
 AddUpdatedFld(conViewRelaTab.RegionId);
}
else if (conViewRelaTab.InOutTypeId  ==  _AttributeName[intIndex])
{
mstrInOutTypeId = value.ToString();
 AddUpdatedFld(conViewRelaTab.InOutTypeId);
}
else if (conViewRelaTab.ViewTabTypeId  ==  _AttributeName[intIndex])
{
mstrViewTabTypeId = value.ToString();
 AddUpdatedFld(conViewRelaTab.ViewTabTypeId);
}
else if (conViewRelaTab.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(conViewRelaTab.TabId);
}
else if (conViewRelaTab.TabFunction  ==  _AttributeName[intIndex])
{
mstrTabFunction = value.ToString();
 AddUpdatedFld(conViewRelaTab.TabFunction);
}
else if (conViewRelaTab.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conViewRelaTab.PrjId);
}
else if (conViewRelaTab.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conViewRelaTab.UpdDate);
}
else if (conViewRelaTab.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conViewRelaTab.UpdUser);
}
else if (conViewRelaTab.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conViewRelaTab.Memo);
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
 AddUpdatedFld(conViewRelaTab.mId);
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
 AddUpdatedFld(conViewRelaTab.ViewId);
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
 AddUpdatedFld(conViewRelaTab.RegionId);
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
 AddUpdatedFld(conViewRelaTab.InOutTypeId);
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
 AddUpdatedFld(conViewRelaTab.ViewTabTypeId);
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
 AddUpdatedFld(conViewRelaTab.TabId);
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
 AddUpdatedFld(conViewRelaTab.TabFunction);
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
 AddUpdatedFld(conViewRelaTab.PrjId);
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
 AddUpdatedFld(conViewRelaTab.UpdDate);
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
 AddUpdatedFld(conViewRelaTab.UpdUser);
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
 AddUpdatedFld(conViewRelaTab.Memo);
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
 /// 界面相关表(ViewRelaTab)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conViewRelaTab
{
public const string _CurrTabName = "ViewRelaTab"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "ViewId", "RegionId", "InOutTypeId", "ViewTabTypeId", "TabId", "TabFunction", "PrjId", "UpdDate", "UpdUser", "Memo"};
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
 /// 常量:"RegionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RegionId = "RegionId";    //区域Id

 /// <summary>
 /// 常量:"InOutTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InOutTypeId = "InOutTypeId";    //INOUT类型ID

 /// <summary>
 /// 常量:"ViewTabTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewTabTypeId = "ViewTabTypeId";    //界面表类型码

 /// <summary>
 /// 常量:"TabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabId = "TabId";    //表ID

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