
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewRegionRelaEN
 表名:vViewRegionRela(00050574)
 * 版本:2024.01.24.1(服务器:WIN-SRV103-116)
 日期:2024/01/26 16:18:08
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:区域管理(RegionManage)
 框架-层名:实体层(CS)(EntityLayer)
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

namespace AGC.Entity
{
 /// <summary>
 /// 表vViewRegionRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vViewRegionRela
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
public K_mId_vViewRegionRela(long lngmId)
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
 /// <returns>返回:[K_mId_vViewRegionRela]类型的对象</returns>
public static implicit operator K_mId_vViewRegionRela(long value)
{
return new K_mId_vViewRegionRela(value);
}
}
 /// <summary>
 /// v界面区域关系(vViewRegionRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvViewRegionRelaEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vViewRegionRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 26;
public static string[] AttributeName = new string[] {"mId", "RegionId", "RegionName", "RegionTypeId", "RegionTypeName", "RegionTypeSimName", "RegionTypeOrderNum", "Height", "Width", "ColNum", "ContainerTypeName", "PageDispModeName", "ViewId", "ViewName", "ApplicationTypeId", "ViewCnName", "FileName", "ContainerTypeId", "PageDispModeId", "InUse", "IsDisp", "PrjId", "UpdUser", "UpdDate", "Memo", "ClsName"};

protected long mlngmId;    //mId
protected string mstrRegionId;    //区域Id
protected string mstrRegionName;    //区域名称
protected string mstrRegionTypeId;    //区域类型Id
protected string mstrRegionTypeName;    //区域类型名称
protected string mstrRegionTypeSimName;    //区域类型简名
protected int? mintRegionTypeOrderNum;    //区域类型序号
protected int? mintHeight;    //高度
protected int? mintWidth;    //宽
protected int? mintColNum;    //列数
protected string mstrContainerTypeName;    //容器类型名
protected string mstrPageDispModeName;    //页面显示模式名称
protected string mstrViewId;    //界面Id
protected string mstrViewName;    //界面名称
protected int? mintApplicationTypeId;    //应用程序类型ID
protected string mstrViewCnName;    //视图中文名
protected string mstrFileName;    //文件名
protected string mstrContainerTypeId;    //容器类型Id
protected string mstrPageDispModeId;    //页面显示模式Id
protected bool mbolInUse;    //是否在用
protected bool mbolIsDisp;    //是否显示
protected string mstrPrjId;    //工程ID
protected string mstrUpdUser;    //修改者
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //说明
protected string mstrClsName;    //类名

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvViewRegionRelaEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:mId</param>
public clsvViewRegionRelaEN(long lngmId)
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
return mintAttributeCount;
}
}
public override object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  convViewRegionRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convViewRegionRela.RegionId)
{
return mstrRegionId;
}
else if (strAttributeName  ==  convViewRegionRela.RegionName)
{
return mstrRegionName;
}
else if (strAttributeName  ==  convViewRegionRela.RegionTypeId)
{
return mstrRegionTypeId;
}
else if (strAttributeName  ==  convViewRegionRela.RegionTypeName)
{
return mstrRegionTypeName;
}
else if (strAttributeName  ==  convViewRegionRela.RegionTypeSimName)
{
return mstrRegionTypeSimName;
}
else if (strAttributeName  ==  convViewRegionRela.RegionTypeOrderNum)
{
return mintRegionTypeOrderNum;
}
else if (strAttributeName  ==  convViewRegionRela.Height)
{
return mintHeight;
}
else if (strAttributeName  ==  convViewRegionRela.Width)
{
return mintWidth;
}
else if (strAttributeName  ==  convViewRegionRela.ColNum)
{
return mintColNum;
}
else if (strAttributeName  ==  convViewRegionRela.ContainerTypeName)
{
return mstrContainerTypeName;
}
else if (strAttributeName  ==  convViewRegionRela.PageDispModeName)
{
return mstrPageDispModeName;
}
else if (strAttributeName  ==  convViewRegionRela.ViewId)
{
return mstrViewId;
}
else if (strAttributeName  ==  convViewRegionRela.ViewName)
{
return mstrViewName;
}
else if (strAttributeName  ==  convViewRegionRela.ApplicationTypeId)
{
return mintApplicationTypeId;
}
else if (strAttributeName  ==  convViewRegionRela.ViewCnName)
{
return mstrViewCnName;
}
else if (strAttributeName  ==  convViewRegionRela.FileName)
{
return mstrFileName;
}
else if (strAttributeName  ==  convViewRegionRela.ContainerTypeId)
{
return mstrContainerTypeId;
}
else if (strAttributeName  ==  convViewRegionRela.PageDispModeId)
{
return mstrPageDispModeId;
}
else if (strAttributeName  ==  convViewRegionRela.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  convViewRegionRela.IsDisp)
{
return mbolIsDisp;
}
else if (strAttributeName  ==  convViewRegionRela.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convViewRegionRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convViewRegionRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convViewRegionRela.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convViewRegionRela.ClsName)
{
return mstrClsName;
}
return null;
}
set
{
if (strAttributeName  ==  convViewRegionRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewRegionRela.mId);
}
else if (strAttributeName  ==  convViewRegionRela.RegionId)
{
mstrRegionId = value.ToString();
 AddUpdatedFld(convViewRegionRela.RegionId);
}
else if (strAttributeName  ==  convViewRegionRela.RegionName)
{
mstrRegionName = value.ToString();
 AddUpdatedFld(convViewRegionRela.RegionName);
}
else if (strAttributeName  ==  convViewRegionRela.RegionTypeId)
{
mstrRegionTypeId = value.ToString();
 AddUpdatedFld(convViewRegionRela.RegionTypeId);
}
else if (strAttributeName  ==  convViewRegionRela.RegionTypeName)
{
mstrRegionTypeName = value.ToString();
 AddUpdatedFld(convViewRegionRela.RegionTypeName);
}
else if (strAttributeName  ==  convViewRegionRela.RegionTypeSimName)
{
mstrRegionTypeSimName = value.ToString();
 AddUpdatedFld(convViewRegionRela.RegionTypeSimName);
}
else if (strAttributeName  ==  convViewRegionRela.RegionTypeOrderNum)
{
mintRegionTypeOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewRegionRela.RegionTypeOrderNum);
}
else if (strAttributeName  ==  convViewRegionRela.Height)
{
mintHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewRegionRela.Height);
}
else if (strAttributeName  ==  convViewRegionRela.Width)
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewRegionRela.Width);
}
else if (strAttributeName  ==  convViewRegionRela.ColNum)
{
mintColNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewRegionRela.ColNum);
}
else if (strAttributeName  ==  convViewRegionRela.ContainerTypeName)
{
mstrContainerTypeName = value.ToString();
 AddUpdatedFld(convViewRegionRela.ContainerTypeName);
}
else if (strAttributeName  ==  convViewRegionRela.PageDispModeName)
{
mstrPageDispModeName = value.ToString();
 AddUpdatedFld(convViewRegionRela.PageDispModeName);
}
else if (strAttributeName  ==  convViewRegionRela.ViewId)
{
mstrViewId = value.ToString();
 AddUpdatedFld(convViewRegionRela.ViewId);
}
else if (strAttributeName  ==  convViewRegionRela.ViewName)
{
mstrViewName = value.ToString();
 AddUpdatedFld(convViewRegionRela.ViewName);
}
else if (strAttributeName  ==  convViewRegionRela.ApplicationTypeId)
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewRegionRela.ApplicationTypeId);
}
else if (strAttributeName  ==  convViewRegionRela.ViewCnName)
{
mstrViewCnName = value.ToString();
 AddUpdatedFld(convViewRegionRela.ViewCnName);
}
else if (strAttributeName  ==  convViewRegionRela.FileName)
{
mstrFileName = value.ToString();
 AddUpdatedFld(convViewRegionRela.FileName);
}
else if (strAttributeName  ==  convViewRegionRela.ContainerTypeId)
{
mstrContainerTypeId = value.ToString();
 AddUpdatedFld(convViewRegionRela.ContainerTypeId);
}
else if (strAttributeName  ==  convViewRegionRela.PageDispModeId)
{
mstrPageDispModeId = value.ToString();
 AddUpdatedFld(convViewRegionRela.PageDispModeId);
}
else if (strAttributeName  ==  convViewRegionRela.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convViewRegionRela.InUse);
}
else if (strAttributeName  ==  convViewRegionRela.IsDisp)
{
mbolIsDisp = TransNullToBool(value.ToString());
 AddUpdatedFld(convViewRegionRela.IsDisp);
}
else if (strAttributeName  ==  convViewRegionRela.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convViewRegionRela.PrjId);
}
else if (strAttributeName  ==  convViewRegionRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convViewRegionRela.UpdUser);
}
else if (strAttributeName  ==  convViewRegionRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convViewRegionRela.UpdDate);
}
else if (strAttributeName  ==  convViewRegionRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convViewRegionRela.Memo);
}
else if (strAttributeName  ==  convViewRegionRela.ClsName)
{
mstrClsName = value.ToString();
 AddUpdatedFld(convViewRegionRela.ClsName);
}
}
}
public object this[int intIndex]
{
get
{
if (convViewRegionRela.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convViewRegionRela.RegionId  ==  AttributeName[intIndex])
{
return mstrRegionId;
}
else if (convViewRegionRela.RegionName  ==  AttributeName[intIndex])
{
return mstrRegionName;
}
else if (convViewRegionRela.RegionTypeId  ==  AttributeName[intIndex])
{
return mstrRegionTypeId;
}
else if (convViewRegionRela.RegionTypeName  ==  AttributeName[intIndex])
{
return mstrRegionTypeName;
}
else if (convViewRegionRela.RegionTypeSimName  ==  AttributeName[intIndex])
{
return mstrRegionTypeSimName;
}
else if (convViewRegionRela.RegionTypeOrderNum  ==  AttributeName[intIndex])
{
return mintRegionTypeOrderNum;
}
else if (convViewRegionRela.Height  ==  AttributeName[intIndex])
{
return mintHeight;
}
else if (convViewRegionRela.Width  ==  AttributeName[intIndex])
{
return mintWidth;
}
else if (convViewRegionRela.ColNum  ==  AttributeName[intIndex])
{
return mintColNum;
}
else if (convViewRegionRela.ContainerTypeName  ==  AttributeName[intIndex])
{
return mstrContainerTypeName;
}
else if (convViewRegionRela.PageDispModeName  ==  AttributeName[intIndex])
{
return mstrPageDispModeName;
}
else if (convViewRegionRela.ViewId  ==  AttributeName[intIndex])
{
return mstrViewId;
}
else if (convViewRegionRela.ViewName  ==  AttributeName[intIndex])
{
return mstrViewName;
}
else if (convViewRegionRela.ApplicationTypeId  ==  AttributeName[intIndex])
{
return mintApplicationTypeId;
}
else if (convViewRegionRela.ViewCnName  ==  AttributeName[intIndex])
{
return mstrViewCnName;
}
else if (convViewRegionRela.FileName  ==  AttributeName[intIndex])
{
return mstrFileName;
}
else if (convViewRegionRela.ContainerTypeId  ==  AttributeName[intIndex])
{
return mstrContainerTypeId;
}
else if (convViewRegionRela.PageDispModeId  ==  AttributeName[intIndex])
{
return mstrPageDispModeId;
}
else if (convViewRegionRela.InUse  ==  AttributeName[intIndex])
{
return mbolInUse;
}
else if (convViewRegionRela.IsDisp  ==  AttributeName[intIndex])
{
return mbolIsDisp;
}
else if (convViewRegionRela.PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convViewRegionRela.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convViewRegionRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convViewRegionRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convViewRegionRela.ClsName  ==  AttributeName[intIndex])
{
return mstrClsName;
}
return null;
}
set
{
if (convViewRegionRela.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewRegionRela.mId);
}
else if (convViewRegionRela.RegionId  ==  AttributeName[intIndex])
{
mstrRegionId = value.ToString();
 AddUpdatedFld(convViewRegionRela.RegionId);
}
else if (convViewRegionRela.RegionName  ==  AttributeName[intIndex])
{
mstrRegionName = value.ToString();
 AddUpdatedFld(convViewRegionRela.RegionName);
}
else if (convViewRegionRela.RegionTypeId  ==  AttributeName[intIndex])
{
mstrRegionTypeId = value.ToString();
 AddUpdatedFld(convViewRegionRela.RegionTypeId);
}
else if (convViewRegionRela.RegionTypeName  ==  AttributeName[intIndex])
{
mstrRegionTypeName = value.ToString();
 AddUpdatedFld(convViewRegionRela.RegionTypeName);
}
else if (convViewRegionRela.RegionTypeSimName  ==  AttributeName[intIndex])
{
mstrRegionTypeSimName = value.ToString();
 AddUpdatedFld(convViewRegionRela.RegionTypeSimName);
}
else if (convViewRegionRela.RegionTypeOrderNum  ==  AttributeName[intIndex])
{
mintRegionTypeOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewRegionRela.RegionTypeOrderNum);
}
else if (convViewRegionRela.Height  ==  AttributeName[intIndex])
{
mintHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewRegionRela.Height);
}
else if (convViewRegionRela.Width  ==  AttributeName[intIndex])
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewRegionRela.Width);
}
else if (convViewRegionRela.ColNum  ==  AttributeName[intIndex])
{
mintColNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewRegionRela.ColNum);
}
else if (convViewRegionRela.ContainerTypeName  ==  AttributeName[intIndex])
{
mstrContainerTypeName = value.ToString();
 AddUpdatedFld(convViewRegionRela.ContainerTypeName);
}
else if (convViewRegionRela.PageDispModeName  ==  AttributeName[intIndex])
{
mstrPageDispModeName = value.ToString();
 AddUpdatedFld(convViewRegionRela.PageDispModeName);
}
else if (convViewRegionRela.ViewId  ==  AttributeName[intIndex])
{
mstrViewId = value.ToString();
 AddUpdatedFld(convViewRegionRela.ViewId);
}
else if (convViewRegionRela.ViewName  ==  AttributeName[intIndex])
{
mstrViewName = value.ToString();
 AddUpdatedFld(convViewRegionRela.ViewName);
}
else if (convViewRegionRela.ApplicationTypeId  ==  AttributeName[intIndex])
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewRegionRela.ApplicationTypeId);
}
else if (convViewRegionRela.ViewCnName  ==  AttributeName[intIndex])
{
mstrViewCnName = value.ToString();
 AddUpdatedFld(convViewRegionRela.ViewCnName);
}
else if (convViewRegionRela.FileName  ==  AttributeName[intIndex])
{
mstrFileName = value.ToString();
 AddUpdatedFld(convViewRegionRela.FileName);
}
else if (convViewRegionRela.ContainerTypeId  ==  AttributeName[intIndex])
{
mstrContainerTypeId = value.ToString();
 AddUpdatedFld(convViewRegionRela.ContainerTypeId);
}
else if (convViewRegionRela.PageDispModeId  ==  AttributeName[intIndex])
{
mstrPageDispModeId = value.ToString();
 AddUpdatedFld(convViewRegionRela.PageDispModeId);
}
else if (convViewRegionRela.InUse  ==  AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convViewRegionRela.InUse);
}
else if (convViewRegionRela.IsDisp  ==  AttributeName[intIndex])
{
mbolIsDisp = TransNullToBool(value.ToString());
 AddUpdatedFld(convViewRegionRela.IsDisp);
}
else if (convViewRegionRela.PrjId  ==  AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convViewRegionRela.PrjId);
}
else if (convViewRegionRela.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convViewRegionRela.UpdUser);
}
else if (convViewRegionRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convViewRegionRela.UpdDate);
}
else if (convViewRegionRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convViewRegionRela.Memo);
}
else if (convViewRegionRela.ClsName  ==  AttributeName[intIndex])
{
mstrClsName = value.ToString();
 AddUpdatedFld(convViewRegionRela.ClsName);
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
 AddUpdatedFld(convViewRegionRela.mId);
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
 AddUpdatedFld(convViewRegionRela.RegionId);
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
 AddUpdatedFld(convViewRegionRela.RegionName);
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
 AddUpdatedFld(convViewRegionRela.RegionTypeId);
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
 AddUpdatedFld(convViewRegionRela.RegionTypeName);
}
}
/// <summary>
/// 区域类型简名(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RegionTypeSimName
{
get
{
return mstrRegionTypeSimName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRegionTypeSimName = value;
}
else
{
 mstrRegionTypeSimName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewRegionRela.RegionTypeSimName);
}
}
/// <summary>
/// 区域类型序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? RegionTypeOrderNum
{
get
{
return mintRegionTypeOrderNum;
}
set
{
 mintRegionTypeOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(convViewRegionRela.RegionTypeOrderNum);
}
}
/// <summary>
/// 高度(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? Height
{
get
{
return mintHeight;
}
set
{
 mintHeight = value;
//记录修改过的字段
 AddUpdatedFld(convViewRegionRela.Height);
}
}
/// <summary>
/// 宽(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? Width
{
get
{
return mintWidth;
}
set
{
 mintWidth = value;
//记录修改过的字段
 AddUpdatedFld(convViewRegionRela.Width);
}
}
/// <summary>
/// 列数(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? ColNum
{
get
{
return mintColNum;
}
set
{
 mintColNum = value;
//记录修改过的字段
 AddUpdatedFld(convViewRegionRela.ColNum);
}
}
/// <summary>
/// 容器类型名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ContainerTypeName
{
get
{
return mstrContainerTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrContainerTypeName = value;
}
else
{
 mstrContainerTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewRegionRela.ContainerTypeName);
}
}
/// <summary>
/// 页面显示模式名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PageDispModeName
{
get
{
return mstrPageDispModeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPageDispModeName = value;
}
else
{
 mstrPageDispModeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewRegionRela.PageDispModeName);
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
 AddUpdatedFld(convViewRegionRela.ViewId);
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
 AddUpdatedFld(convViewRegionRela.ViewName);
}
}
/// <summary>
/// 应用程序类型ID(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? ApplicationTypeId
{
get
{
return mintApplicationTypeId;
}
set
{
 mintApplicationTypeId = value;
//记录修改过的字段
 AddUpdatedFld(convViewRegionRela.ApplicationTypeId);
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
 AddUpdatedFld(convViewRegionRela.ViewCnName);
}
}
/// <summary>
/// 文件名(说明:;字段类型:varchar;字段长度:150;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FileName
{
get
{
return mstrFileName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFileName = value;
}
else
{
 mstrFileName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewRegionRela.FileName);
}
}
/// <summary>
/// 容器类型Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ContainerTypeId
{
get
{
return mstrContainerTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrContainerTypeId = value;
}
else
{
 mstrContainerTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewRegionRela.ContainerTypeId);
}
}
/// <summary>
/// 页面显示模式Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PageDispModeId
{
get
{
return mstrPageDispModeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPageDispModeId = value;
}
else
{
 mstrPageDispModeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewRegionRela.PageDispModeId);
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
 AddUpdatedFld(convViewRegionRela.InUse);
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
 AddUpdatedFld(convViewRegionRela.IsDisp);
}
}
/// <summary>
/// 工程ID(说明:;字段类型:char;字段长度:4;是否可空:False)
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
 AddUpdatedFld(convViewRegionRela.PrjId);
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
 AddUpdatedFld(convViewRegionRela.UpdUser);
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
 AddUpdatedFld(convViewRegionRela.UpdDate);
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
 AddUpdatedFld(convViewRegionRela.Memo);
}
}
/// <summary>
/// 类名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClsName
{
get
{
return mstrClsName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClsName = value;
}
else
{
 mstrClsName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewRegionRela.ClsName);
}
}

/// <summary>
/// 获取关键字Id(keyId)
 /// (AutoGCLib.clsGeneCodeBase:GenGetKeyId)
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
 /// v界面区域关系(vViewRegionRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convViewRegionRela
{
public const string _CurrTabName = "vViewRegionRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "RegionId", "RegionName", "RegionTypeId", "RegionTypeName", "RegionTypeSimName", "RegionTypeOrderNum", "Height", "Width", "ColNum", "ContainerTypeName", "PageDispModeName", "ViewId", "ViewName", "ApplicationTypeId", "ViewCnName", "FileName", "ContainerTypeId", "PageDispModeId", "InUse", "IsDisp", "PrjId", "UpdUser", "UpdDate", "Memo", "ClsName"};
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
 /// 常量:"RegionTypeSimName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RegionTypeSimName = "RegionTypeSimName";    //区域类型简名

 /// <summary>
 /// 常量:"RegionTypeOrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RegionTypeOrderNum = "RegionTypeOrderNum";    //区域类型序号

 /// <summary>
 /// 常量:"Height"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Height = "Height";    //高度

 /// <summary>
 /// 常量:"Width"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Width = "Width";    //宽

 /// <summary>
 /// 常量:"ColNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ColNum = "ColNum";    //列数

 /// <summary>
 /// 常量:"ContainerTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ContainerTypeName = "ContainerTypeName";    //容器类型名

 /// <summary>
 /// 常量:"PageDispModeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PageDispModeName = "PageDispModeName";    //页面显示模式名称

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
 /// 常量:"ApplicationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeId = "ApplicationTypeId";    //应用程序类型ID

 /// <summary>
 /// 常量:"ViewCnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewCnName = "ViewCnName";    //视图中文名

 /// <summary>
 /// 常量:"FileName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileName = "FileName";    //文件名

 /// <summary>
 /// 常量:"ContainerTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ContainerTypeId = "ContainerTypeId";    //容器类型Id

 /// <summary>
 /// 常量:"PageDispModeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PageDispModeId = "PageDispModeId";    //页面显示模式Id

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
 public const string PrjId = "PrjId";    //工程ID

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

 /// <summary>
 /// 常量:"ClsName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClsName = "ClsName";    //类名
}

}