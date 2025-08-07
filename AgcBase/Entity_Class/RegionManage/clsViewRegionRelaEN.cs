
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewRegionRelaEN
 表名:ViewRegionRela(00050573)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:27:06
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:区域管理(RegionManage)
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
 /// 表ViewRegionRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_ViewRegionRela
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
public K_mId_ViewRegionRela(long lngmId)
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
 /// <returns>返回:[K_mId_ViewRegionRela]类型的对象</returns>
public static implicit operator K_mId_ViewRegionRela(long value)
{
return new K_mId_ViewRegionRela(value);
}
}
 /// <summary>
 /// 界面区域关系(ViewRegionRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsViewRegionRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ViewRegionRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = "ViewId in (Select ViewId from ViewInfoCmPrjIdRela where CmPrjId='{0}')"; //前台条件格式串
protected const int _AttributeCount = 9;
public static string[] _AttributeName = new string[] {"mId", "RegionId", "ViewId", "InUse", "IsDisp", "PrjId", "UpdUser", "UpdDate", "Memo"};

protected long mlngmId;    //mId
protected string mstrRegionId;    //区域Id
protected string mstrViewId;    //界面Id
protected bool mbolInUse;    //是否在用
protected bool mbolIsDisp;    //是否显示
protected string mstrPrjId;    //工程Id
protected string mstrUpdUser;    //修改者
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsViewRegionRelaEN()
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
public clsViewRegionRelaEN(long lngmId)
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
if (strAttributeName  ==  conViewRegionRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conViewRegionRela.RegionId)
{
return mstrRegionId;
}
else if (strAttributeName  ==  conViewRegionRela.ViewId)
{
return mstrViewId;
}
else if (strAttributeName  ==  conViewRegionRela.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  conViewRegionRela.IsDisp)
{
return mbolIsDisp;
}
else if (strAttributeName  ==  conViewRegionRela.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conViewRegionRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conViewRegionRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conViewRegionRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conViewRegionRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewRegionRela.mId);
}
else if (strAttributeName  ==  conViewRegionRela.RegionId)
{
mstrRegionId = value.ToString();
 AddUpdatedFld(conViewRegionRela.RegionId);
}
else if (strAttributeName  ==  conViewRegionRela.ViewId)
{
mstrViewId = value.ToString();
 AddUpdatedFld(conViewRegionRela.ViewId);
}
else if (strAttributeName  ==  conViewRegionRela.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewRegionRela.InUse);
}
else if (strAttributeName  ==  conViewRegionRela.IsDisp)
{
mbolIsDisp = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewRegionRela.IsDisp);
}
else if (strAttributeName  ==  conViewRegionRela.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conViewRegionRela.PrjId);
}
else if (strAttributeName  ==  conViewRegionRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conViewRegionRela.UpdUser);
}
else if (strAttributeName  ==  conViewRegionRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conViewRegionRela.UpdDate);
}
else if (strAttributeName  ==  conViewRegionRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conViewRegionRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conViewRegionRela.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (conViewRegionRela.RegionId  ==  _AttributeName[intIndex])
{
return mstrRegionId;
}
else if (conViewRegionRela.ViewId  ==  _AttributeName[intIndex])
{
return mstrViewId;
}
else if (conViewRegionRela.InUse  ==  _AttributeName[intIndex])
{
return mbolInUse;
}
else if (conViewRegionRela.IsDisp  ==  _AttributeName[intIndex])
{
return mbolIsDisp;
}
else if (conViewRegionRela.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conViewRegionRela.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conViewRegionRela.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conViewRegionRela.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conViewRegionRela.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewRegionRela.mId);
}
else if (conViewRegionRela.RegionId  ==  _AttributeName[intIndex])
{
mstrRegionId = value.ToString();
 AddUpdatedFld(conViewRegionRela.RegionId);
}
else if (conViewRegionRela.ViewId  ==  _AttributeName[intIndex])
{
mstrViewId = value.ToString();
 AddUpdatedFld(conViewRegionRela.ViewId);
}
else if (conViewRegionRela.InUse  ==  _AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewRegionRela.InUse);
}
else if (conViewRegionRela.IsDisp  ==  _AttributeName[intIndex])
{
mbolIsDisp = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewRegionRela.IsDisp);
}
else if (conViewRegionRela.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conViewRegionRela.PrjId);
}
else if (conViewRegionRela.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conViewRegionRela.UpdUser);
}
else if (conViewRegionRela.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conViewRegionRela.UpdDate);
}
else if (conViewRegionRela.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conViewRegionRela.Memo);
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
 AddUpdatedFld(conViewRegionRela.mId);
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
 AddUpdatedFld(conViewRegionRela.RegionId);
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
 AddUpdatedFld(conViewRegionRela.ViewId);
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
 AddUpdatedFld(conViewRegionRela.InUse);
}
}
/// <summary>
/// 是否显示(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsDisp
{
get
{
return mbolIsDisp;
}
set
{
 mbolIsDisp = value;
//记录修改过的字段
 AddUpdatedFld(conViewRegionRela.IsDisp);
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
 AddUpdatedFld(conViewRegionRela.PrjId);
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
 AddUpdatedFld(conViewRegionRela.UpdUser);
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
 AddUpdatedFld(conViewRegionRela.UpdDate);
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
 AddUpdatedFld(conViewRegionRela.Memo);
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
 /// 界面区域关系(ViewRegionRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conViewRegionRela
{
public const string _CurrTabName = "ViewRegionRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "RegionId", "ViewId", "InUse", "IsDisp", "PrjId", "UpdUser", "UpdDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"RegionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RegionId = "RegionId";    //区域Id

 /// <summary>
 /// 常量:"ViewId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewId = "ViewId";    //界面Id

 /// <summary>
 /// 常量:"InUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InUse = "InUse";    //是否在用

 /// <summary>
 /// 常量:"IsDisp"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDisp = "IsDisp";    //是否显示

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改者

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}