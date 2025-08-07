
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewRegionEN
 表名:vViewRegion(00050199)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:46:49
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
 /// 表vViewRegion的关键字(RegionId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_RegionId_vViewRegion
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strRegionId">表关键字</param>
public K_RegionId_vViewRegion(string strRegionId)
{
if (IsValid(strRegionId)) Value = strRegionId;
else
{
Value = null;
}
}
private static bool IsValid(string strRegionId)
{
if (string.IsNullOrEmpty(strRegionId) == true) return false;
if (strRegionId.Length != 10) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_RegionId_vViewRegion]类型的对象</returns>
public static implicit operator K_RegionId_vViewRegion(string value)
{
return new K_RegionId_vViewRegion(value);
}
}
 /// <summary>
 /// v界面区域(vViewRegion)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvViewRegionEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vViewRegion"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "RegionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 27;
public static string[] _AttributeName = new string[] {"RegionId", "RegionName", "RegionTypeId", "FileName", "Height", "Width", "ColNum", "ContainerTypeId", "PageDispModeId", "InOutTypeId", "InOutTypeENName", "TabId", "ApplicationTypeId", "KeyId4Test", "PrjId", "UpdUser", "UpdDate", "Memo", "RegionTypeSimName", "ContainerTypeName", "PageDispModeName", "InOutTypeName", "TabName", "ApplicationTypeSimName", "RegionTypeOrderNum", "RegionTypeName", "ClsName"};

protected string mstrRegionId;    //区域Id
protected string mstrRegionName;    //区域名称
protected string mstrRegionTypeId;    //区域类型Id
protected string mstrFileName;    //文件名
protected int? mintHeight;    //高度
protected int? mintWidth;    //宽
protected int? mintColNum;    //列数
protected string mstrContainerTypeId;    //容器类型Id
protected string mstrPageDispModeId;    //页面显示模式Id
protected string mstrInOutTypeId;    //INOUT类型ID
protected string mstrInOutTypeENName;    //INOUT类型英文名
protected string mstrTabId;    //表ID
protected int? mintApplicationTypeId;    //应用程序类型ID
protected string mstrKeyId4Test;    //测试关键字Id
protected string mstrPrjId;    //工程Id
protected string mstrUpdUser;    //修改者
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //说明
protected string mstrRegionTypeSimName;    //区域类型简名
protected string mstrContainerTypeName;    //容器类型名
protected string mstrPageDispModeName;    //页面显示模式名称
protected string mstrInOutTypeName;    //INOUT类型名称
protected string mstrTabName;    //表名
protected string mstrApplicationTypeSimName;    //应用程序类型简称
protected int? mintRegionTypeOrderNum;    //区域类型序号
protected string mstrRegionTypeName;    //区域类型名称
protected string mstrClsName;    //类名

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvViewRegionEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("RegionId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strRegionId">关键字:区域Id</param>
public clsvViewRegionEN(string strRegionId)
 {
strRegionId = strRegionId.Replace("'", "''");
if (strRegionId.Length > 10)
{
throw new Exception("在表:vViewRegion中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strRegionId)  ==  true)
{
throw new Exception("在表:vViewRegion中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strRegionId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrRegionId = strRegionId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("RegionId");
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
if (strAttributeName  ==  convViewRegion.RegionId)
{
return mstrRegionId;
}
else if (strAttributeName  ==  convViewRegion.RegionName)
{
return mstrRegionName;
}
else if (strAttributeName  ==  convViewRegion.RegionTypeId)
{
return mstrRegionTypeId;
}
else if (strAttributeName  ==  convViewRegion.FileName)
{
return mstrFileName;
}
else if (strAttributeName  ==  convViewRegion.Height)
{
return mintHeight;
}
else if (strAttributeName  ==  convViewRegion.Width)
{
return mintWidth;
}
else if (strAttributeName  ==  convViewRegion.ColNum)
{
return mintColNum;
}
else if (strAttributeName  ==  convViewRegion.ContainerTypeId)
{
return mstrContainerTypeId;
}
else if (strAttributeName  ==  convViewRegion.PageDispModeId)
{
return mstrPageDispModeId;
}
else if (strAttributeName  ==  convViewRegion.InOutTypeId)
{
return mstrInOutTypeId;
}
else if (strAttributeName  ==  convViewRegion.InOutTypeENName)
{
return mstrInOutTypeENName;
}
else if (strAttributeName  ==  convViewRegion.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  convViewRegion.ApplicationTypeId)
{
return mintApplicationTypeId;
}
else if (strAttributeName  ==  convViewRegion.KeyId4Test)
{
return mstrKeyId4Test;
}
else if (strAttributeName  ==  convViewRegion.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convViewRegion.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convViewRegion.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convViewRegion.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convViewRegion.RegionTypeSimName)
{
return mstrRegionTypeSimName;
}
else if (strAttributeName  ==  convViewRegion.ContainerTypeName)
{
return mstrContainerTypeName;
}
else if (strAttributeName  ==  convViewRegion.PageDispModeName)
{
return mstrPageDispModeName;
}
else if (strAttributeName  ==  convViewRegion.InOutTypeName)
{
return mstrInOutTypeName;
}
else if (strAttributeName  ==  convViewRegion.TabName)
{
return mstrTabName;
}
else if (strAttributeName  ==  convViewRegion.ApplicationTypeSimName)
{
return mstrApplicationTypeSimName;
}
else if (strAttributeName  ==  convViewRegion.RegionTypeOrderNum)
{
return mintRegionTypeOrderNum;
}
else if (strAttributeName  ==  convViewRegion.RegionTypeName)
{
return mstrRegionTypeName;
}
else if (strAttributeName  ==  convViewRegion.ClsName)
{
return mstrClsName;
}
return null;
}
set
{
if (strAttributeName  ==  convViewRegion.RegionId)
{
mstrRegionId = value.ToString();
 AddUpdatedFld(convViewRegion.RegionId);
}
else if (strAttributeName  ==  convViewRegion.RegionName)
{
mstrRegionName = value.ToString();
 AddUpdatedFld(convViewRegion.RegionName);
}
else if (strAttributeName  ==  convViewRegion.RegionTypeId)
{
mstrRegionTypeId = value.ToString();
 AddUpdatedFld(convViewRegion.RegionTypeId);
}
else if (strAttributeName  ==  convViewRegion.FileName)
{
mstrFileName = value.ToString();
 AddUpdatedFld(convViewRegion.FileName);
}
else if (strAttributeName  ==  convViewRegion.Height)
{
mintHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewRegion.Height);
}
else if (strAttributeName  ==  convViewRegion.Width)
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewRegion.Width);
}
else if (strAttributeName  ==  convViewRegion.ColNum)
{
mintColNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewRegion.ColNum);
}
else if (strAttributeName  ==  convViewRegion.ContainerTypeId)
{
mstrContainerTypeId = value.ToString();
 AddUpdatedFld(convViewRegion.ContainerTypeId);
}
else if (strAttributeName  ==  convViewRegion.PageDispModeId)
{
mstrPageDispModeId = value.ToString();
 AddUpdatedFld(convViewRegion.PageDispModeId);
}
else if (strAttributeName  ==  convViewRegion.InOutTypeId)
{
mstrInOutTypeId = value.ToString();
 AddUpdatedFld(convViewRegion.InOutTypeId);
}
else if (strAttributeName  ==  convViewRegion.InOutTypeENName)
{
mstrInOutTypeENName = value.ToString();
 AddUpdatedFld(convViewRegion.InOutTypeENName);
}
else if (strAttributeName  ==  convViewRegion.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(convViewRegion.TabId);
}
else if (strAttributeName  ==  convViewRegion.ApplicationTypeId)
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewRegion.ApplicationTypeId);
}
else if (strAttributeName  ==  convViewRegion.KeyId4Test)
{
mstrKeyId4Test = value.ToString();
 AddUpdatedFld(convViewRegion.KeyId4Test);
}
else if (strAttributeName  ==  convViewRegion.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convViewRegion.PrjId);
}
else if (strAttributeName  ==  convViewRegion.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convViewRegion.UpdUser);
}
else if (strAttributeName  ==  convViewRegion.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convViewRegion.UpdDate);
}
else if (strAttributeName  ==  convViewRegion.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convViewRegion.Memo);
}
else if (strAttributeName  ==  convViewRegion.RegionTypeSimName)
{
mstrRegionTypeSimName = value.ToString();
 AddUpdatedFld(convViewRegion.RegionTypeSimName);
}
else if (strAttributeName  ==  convViewRegion.ContainerTypeName)
{
mstrContainerTypeName = value.ToString();
 AddUpdatedFld(convViewRegion.ContainerTypeName);
}
else if (strAttributeName  ==  convViewRegion.PageDispModeName)
{
mstrPageDispModeName = value.ToString();
 AddUpdatedFld(convViewRegion.PageDispModeName);
}
else if (strAttributeName  ==  convViewRegion.InOutTypeName)
{
mstrInOutTypeName = value.ToString();
 AddUpdatedFld(convViewRegion.InOutTypeName);
}
else if (strAttributeName  ==  convViewRegion.TabName)
{
mstrTabName = value.ToString();
 AddUpdatedFld(convViewRegion.TabName);
}
else if (strAttributeName  ==  convViewRegion.ApplicationTypeSimName)
{
mstrApplicationTypeSimName = value.ToString();
 AddUpdatedFld(convViewRegion.ApplicationTypeSimName);
}
else if (strAttributeName  ==  convViewRegion.RegionTypeOrderNum)
{
mintRegionTypeOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewRegion.RegionTypeOrderNum);
}
else if (strAttributeName  ==  convViewRegion.RegionTypeName)
{
mstrRegionTypeName = value.ToString();
 AddUpdatedFld(convViewRegion.RegionTypeName);
}
else if (strAttributeName  ==  convViewRegion.ClsName)
{
mstrClsName = value.ToString();
 AddUpdatedFld(convViewRegion.ClsName);
}
}
}
public object this[int intIndex]
{
get
{
if (convViewRegion.RegionId  ==  _AttributeName[intIndex])
{
return mstrRegionId;
}
else if (convViewRegion.RegionName  ==  _AttributeName[intIndex])
{
return mstrRegionName;
}
else if (convViewRegion.RegionTypeId  ==  _AttributeName[intIndex])
{
return mstrRegionTypeId;
}
else if (convViewRegion.FileName  ==  _AttributeName[intIndex])
{
return mstrFileName;
}
else if (convViewRegion.Height  ==  _AttributeName[intIndex])
{
return mintHeight;
}
else if (convViewRegion.Width  ==  _AttributeName[intIndex])
{
return mintWidth;
}
else if (convViewRegion.ColNum  ==  _AttributeName[intIndex])
{
return mintColNum;
}
else if (convViewRegion.ContainerTypeId  ==  _AttributeName[intIndex])
{
return mstrContainerTypeId;
}
else if (convViewRegion.PageDispModeId  ==  _AttributeName[intIndex])
{
return mstrPageDispModeId;
}
else if (convViewRegion.InOutTypeId  ==  _AttributeName[intIndex])
{
return mstrInOutTypeId;
}
else if (convViewRegion.InOutTypeENName  ==  _AttributeName[intIndex])
{
return mstrInOutTypeENName;
}
else if (convViewRegion.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (convViewRegion.ApplicationTypeId  ==  _AttributeName[intIndex])
{
return mintApplicationTypeId;
}
else if (convViewRegion.KeyId4Test  ==  _AttributeName[intIndex])
{
return mstrKeyId4Test;
}
else if (convViewRegion.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convViewRegion.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convViewRegion.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convViewRegion.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (convViewRegion.RegionTypeSimName  ==  _AttributeName[intIndex])
{
return mstrRegionTypeSimName;
}
else if (convViewRegion.ContainerTypeName  ==  _AttributeName[intIndex])
{
return mstrContainerTypeName;
}
else if (convViewRegion.PageDispModeName  ==  _AttributeName[intIndex])
{
return mstrPageDispModeName;
}
else if (convViewRegion.InOutTypeName  ==  _AttributeName[intIndex])
{
return mstrInOutTypeName;
}
else if (convViewRegion.TabName  ==  _AttributeName[intIndex])
{
return mstrTabName;
}
else if (convViewRegion.ApplicationTypeSimName  ==  _AttributeName[intIndex])
{
return mstrApplicationTypeSimName;
}
else if (convViewRegion.RegionTypeOrderNum  ==  _AttributeName[intIndex])
{
return mintRegionTypeOrderNum;
}
else if (convViewRegion.RegionTypeName  ==  _AttributeName[intIndex])
{
return mstrRegionTypeName;
}
else if (convViewRegion.ClsName  ==  _AttributeName[intIndex])
{
return mstrClsName;
}
return null;
}
set
{
if (convViewRegion.RegionId  ==  _AttributeName[intIndex])
{
mstrRegionId = value.ToString();
 AddUpdatedFld(convViewRegion.RegionId);
}
else if (convViewRegion.RegionName  ==  _AttributeName[intIndex])
{
mstrRegionName = value.ToString();
 AddUpdatedFld(convViewRegion.RegionName);
}
else if (convViewRegion.RegionTypeId  ==  _AttributeName[intIndex])
{
mstrRegionTypeId = value.ToString();
 AddUpdatedFld(convViewRegion.RegionTypeId);
}
else if (convViewRegion.FileName  ==  _AttributeName[intIndex])
{
mstrFileName = value.ToString();
 AddUpdatedFld(convViewRegion.FileName);
}
else if (convViewRegion.Height  ==  _AttributeName[intIndex])
{
mintHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewRegion.Height);
}
else if (convViewRegion.Width  ==  _AttributeName[intIndex])
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewRegion.Width);
}
else if (convViewRegion.ColNum  ==  _AttributeName[intIndex])
{
mintColNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewRegion.ColNum);
}
else if (convViewRegion.ContainerTypeId  ==  _AttributeName[intIndex])
{
mstrContainerTypeId = value.ToString();
 AddUpdatedFld(convViewRegion.ContainerTypeId);
}
else if (convViewRegion.PageDispModeId  ==  _AttributeName[intIndex])
{
mstrPageDispModeId = value.ToString();
 AddUpdatedFld(convViewRegion.PageDispModeId);
}
else if (convViewRegion.InOutTypeId  ==  _AttributeName[intIndex])
{
mstrInOutTypeId = value.ToString();
 AddUpdatedFld(convViewRegion.InOutTypeId);
}
else if (convViewRegion.InOutTypeENName  ==  _AttributeName[intIndex])
{
mstrInOutTypeENName = value.ToString();
 AddUpdatedFld(convViewRegion.InOutTypeENName);
}
else if (convViewRegion.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(convViewRegion.TabId);
}
else if (convViewRegion.ApplicationTypeId  ==  _AttributeName[intIndex])
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewRegion.ApplicationTypeId);
}
else if (convViewRegion.KeyId4Test  ==  _AttributeName[intIndex])
{
mstrKeyId4Test = value.ToString();
 AddUpdatedFld(convViewRegion.KeyId4Test);
}
else if (convViewRegion.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convViewRegion.PrjId);
}
else if (convViewRegion.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convViewRegion.UpdUser);
}
else if (convViewRegion.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convViewRegion.UpdDate);
}
else if (convViewRegion.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convViewRegion.Memo);
}
else if (convViewRegion.RegionTypeSimName  ==  _AttributeName[intIndex])
{
mstrRegionTypeSimName = value.ToString();
 AddUpdatedFld(convViewRegion.RegionTypeSimName);
}
else if (convViewRegion.ContainerTypeName  ==  _AttributeName[intIndex])
{
mstrContainerTypeName = value.ToString();
 AddUpdatedFld(convViewRegion.ContainerTypeName);
}
else if (convViewRegion.PageDispModeName  ==  _AttributeName[intIndex])
{
mstrPageDispModeName = value.ToString();
 AddUpdatedFld(convViewRegion.PageDispModeName);
}
else if (convViewRegion.InOutTypeName  ==  _AttributeName[intIndex])
{
mstrInOutTypeName = value.ToString();
 AddUpdatedFld(convViewRegion.InOutTypeName);
}
else if (convViewRegion.TabName  ==  _AttributeName[intIndex])
{
mstrTabName = value.ToString();
 AddUpdatedFld(convViewRegion.TabName);
}
else if (convViewRegion.ApplicationTypeSimName  ==  _AttributeName[intIndex])
{
mstrApplicationTypeSimName = value.ToString();
 AddUpdatedFld(convViewRegion.ApplicationTypeSimName);
}
else if (convViewRegion.RegionTypeOrderNum  ==  _AttributeName[intIndex])
{
mintRegionTypeOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewRegion.RegionTypeOrderNum);
}
else if (convViewRegion.RegionTypeName  ==  _AttributeName[intIndex])
{
mstrRegionTypeName = value.ToString();
 AddUpdatedFld(convViewRegion.RegionTypeName);
}
else if (convViewRegion.ClsName  ==  _AttributeName[intIndex])
{
mstrClsName = value.ToString();
 AddUpdatedFld(convViewRegion.ClsName);
}
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
 AddUpdatedFld(convViewRegion.RegionId);
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
 AddUpdatedFld(convViewRegion.RegionName);
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
 AddUpdatedFld(convViewRegion.RegionTypeId);
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
 AddUpdatedFld(convViewRegion.FileName);
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
 AddUpdatedFld(convViewRegion.Height);
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
 AddUpdatedFld(convViewRegion.Width);
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
 AddUpdatedFld(convViewRegion.ColNum);
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
 AddUpdatedFld(convViewRegion.ContainerTypeId);
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
 AddUpdatedFld(convViewRegion.PageDispModeId);
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
 AddUpdatedFld(convViewRegion.InOutTypeId);
}
}
/// <summary>
/// INOUT类型英文名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string InOutTypeENName
{
get
{
return mstrInOutTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrInOutTypeENName = value;
}
else
{
 mstrInOutTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewRegion.InOutTypeENName);
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
 AddUpdatedFld(convViewRegion.TabId);
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
 AddUpdatedFld(convViewRegion.ApplicationTypeId);
}
}
/// <summary>
/// 测试关键字Id(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KeyId4Test
{
get
{
return mstrKeyId4Test;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeyId4Test = value;
}
else
{
 mstrKeyId4Test = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewRegion.KeyId4Test);
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
 AddUpdatedFld(convViewRegion.PrjId);
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
 AddUpdatedFld(convViewRegion.UpdUser);
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
 AddUpdatedFld(convViewRegion.UpdDate);
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
 AddUpdatedFld(convViewRegion.Memo);
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
 AddUpdatedFld(convViewRegion.RegionTypeSimName);
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
 AddUpdatedFld(convViewRegion.ContainerTypeName);
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
 AddUpdatedFld(convViewRegion.PageDispModeName);
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
 AddUpdatedFld(convViewRegion.InOutTypeName);
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
 AddUpdatedFld(convViewRegion.TabName);
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
 AddUpdatedFld(convViewRegion.ApplicationTypeSimName);
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
 AddUpdatedFld(convViewRegion.RegionTypeOrderNum);
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
 AddUpdatedFld(convViewRegion.RegionTypeName);
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
 AddUpdatedFld(convViewRegion.ClsName);
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
  return mstrRegionId;
 }
 }
}
 /// <summary>
 /// v界面区域(vViewRegion)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convViewRegion
{
public const string _CurrTabName = "vViewRegion"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "RegionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"RegionId", "RegionName", "RegionTypeId", "FileName", "Height", "Width", "ColNum", "ContainerTypeId", "PageDispModeId", "InOutTypeId", "InOutTypeENName", "TabId", "ApplicationTypeId", "KeyId4Test", "PrjId", "UpdUser", "UpdDate", "Memo", "RegionTypeSimName", "ContainerTypeName", "PageDispModeName", "InOutTypeName", "TabName", "ApplicationTypeSimName", "RegionTypeOrderNum", "RegionTypeName", "ClsName"};
//以下是属性变量


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
 /// 常量:"FileName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileName = "FileName";    //文件名

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
 /// 常量:"InOutTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InOutTypeId = "InOutTypeId";    //INOUT类型ID

 /// <summary>
 /// 常量:"InOutTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InOutTypeENName = "InOutTypeENName";    //INOUT类型英文名

 /// <summary>
 /// 常量:"TabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabId = "TabId";    //表ID

 /// <summary>
 /// 常量:"ApplicationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeId = "ApplicationTypeId";    //应用程序类型ID

 /// <summary>
 /// 常量:"KeyId4Test"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KeyId4Test = "KeyId4Test";    //测试关键字Id

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

 /// <summary>
 /// 常量:"RegionTypeSimName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RegionTypeSimName = "RegionTypeSimName";    //区域类型简名

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
 /// 常量:"InOutTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InOutTypeName = "InOutTypeName";    //INOUT类型名称

 /// <summary>
 /// 常量:"TabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabName = "TabName";    //表名

 /// <summary>
 /// 常量:"ApplicationTypeSimName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeSimName = "ApplicationTypeSimName";    //应用程序类型简称

 /// <summary>
 /// 常量:"RegionTypeOrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RegionTypeOrderNum = "RegionTypeOrderNum";    //区域类型序号

 /// <summary>
 /// 常量:"RegionTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RegionTypeName = "RegionTypeName";    //区域类型名称

 /// <summary>
 /// 常量:"ClsName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClsName = "ClsName";    //类名
}

}