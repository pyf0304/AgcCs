
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewRegionEN
 表名:ViewRegion(00050099)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:00:22
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
 /// 表ViewRegion的关键字(RegionId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_RegionId_ViewRegion
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
public K_RegionId_ViewRegion(string strRegionId)
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
 /// <returns>返回:[K_RegionId_ViewRegion]类型的对象</returns>
public static implicit operator K_RegionId_ViewRegion(string value)
{
return new K_RegionId_ViewRegion(value);
}
}
 /// <summary>
 /// 界面区域(ViewRegion)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsViewRegionEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ViewRegion"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "RegionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 18;
public static string[] _AttributeName = new string[] {"RegionId", "RegionName", "RegionTypeId", "FileName", "Height", "Width", "ColNum", "ContainerTypeId", "PageDispModeId", "InOutTypeId", "TabId", "KeyId4Test", "ErrMsg", "PrjId", "UpdUser", "UpdDate", "Memo", "ClsName"};

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
protected string mstrTabId;    //表ID
protected string mstrKeyId4Test;    //测试关键字Id
protected string mstrErrMsg;    //错误信息
protected string mstrPrjId;    //工程Id
protected string mstrUpdUser;    //修改者
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //说明
protected string mstrClsName;    //类名

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsViewRegionEN()
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
public clsViewRegionEN(string strRegionId)
 {
strRegionId = strRegionId.Replace("'", "''");
if (strRegionId.Length > 10)
{
throw new Exception("在表:ViewRegion中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strRegionId)  ==  true)
{
throw new Exception("在表:ViewRegion中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  conViewRegion.RegionId)
{
return mstrRegionId;
}
else if (strAttributeName  ==  conViewRegion.RegionName)
{
return mstrRegionName;
}
else if (strAttributeName  ==  conViewRegion.RegionTypeId)
{
return mstrRegionTypeId;
}
else if (strAttributeName  ==  conViewRegion.FileName)
{
return mstrFileName;
}
else if (strAttributeName  ==  conViewRegion.Height)
{
return mintHeight;
}
else if (strAttributeName  ==  conViewRegion.Width)
{
return mintWidth;
}
else if (strAttributeName  ==  conViewRegion.ColNum)
{
return mintColNum;
}
else if (strAttributeName  ==  conViewRegion.ContainerTypeId)
{
return mstrContainerTypeId;
}
else if (strAttributeName  ==  conViewRegion.PageDispModeId)
{
return mstrPageDispModeId;
}
else if (strAttributeName  ==  conViewRegion.InOutTypeId)
{
return mstrInOutTypeId;
}
else if (strAttributeName  ==  conViewRegion.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  conViewRegion.KeyId4Test)
{
return mstrKeyId4Test;
}
else if (strAttributeName  ==  conViewRegion.ErrMsg)
{
return mstrErrMsg;
}
else if (strAttributeName  ==  conViewRegion.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conViewRegion.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conViewRegion.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conViewRegion.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conViewRegion.ClsName)
{
return mstrClsName;
}
return null;
}
set
{
if (strAttributeName  ==  conViewRegion.RegionId)
{
mstrRegionId = value.ToString();
 AddUpdatedFld(conViewRegion.RegionId);
}
else if (strAttributeName  ==  conViewRegion.RegionName)
{
mstrRegionName = value.ToString();
 AddUpdatedFld(conViewRegion.RegionName);
}
else if (strAttributeName  ==  conViewRegion.RegionTypeId)
{
mstrRegionTypeId = value.ToString();
 AddUpdatedFld(conViewRegion.RegionTypeId);
}
else if (strAttributeName  ==  conViewRegion.FileName)
{
mstrFileName = value.ToString();
 AddUpdatedFld(conViewRegion.FileName);
}
else if (strAttributeName  ==  conViewRegion.Height)
{
mintHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewRegion.Height);
}
else if (strAttributeName  ==  conViewRegion.Width)
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewRegion.Width);
}
else if (strAttributeName  ==  conViewRegion.ColNum)
{
mintColNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewRegion.ColNum);
}
else if (strAttributeName  ==  conViewRegion.ContainerTypeId)
{
mstrContainerTypeId = value.ToString();
 AddUpdatedFld(conViewRegion.ContainerTypeId);
}
else if (strAttributeName  ==  conViewRegion.PageDispModeId)
{
mstrPageDispModeId = value.ToString();
 AddUpdatedFld(conViewRegion.PageDispModeId);
}
else if (strAttributeName  ==  conViewRegion.InOutTypeId)
{
mstrInOutTypeId = value.ToString();
 AddUpdatedFld(conViewRegion.InOutTypeId);
}
else if (strAttributeName  ==  conViewRegion.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(conViewRegion.TabId);
}
else if (strAttributeName  ==  conViewRegion.KeyId4Test)
{
mstrKeyId4Test = value.ToString();
 AddUpdatedFld(conViewRegion.KeyId4Test);
}
else if (strAttributeName  ==  conViewRegion.ErrMsg)
{
mstrErrMsg = value.ToString();
 AddUpdatedFld(conViewRegion.ErrMsg);
}
else if (strAttributeName  ==  conViewRegion.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conViewRegion.PrjId);
}
else if (strAttributeName  ==  conViewRegion.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conViewRegion.UpdUser);
}
else if (strAttributeName  ==  conViewRegion.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conViewRegion.UpdDate);
}
else if (strAttributeName  ==  conViewRegion.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conViewRegion.Memo);
}
else if (strAttributeName  ==  conViewRegion.ClsName)
{
mstrClsName = value.ToString();
 AddUpdatedFld(conViewRegion.ClsName);
}
}
}
public object this[int intIndex]
{
get
{
if (conViewRegion.RegionId  ==  _AttributeName[intIndex])
{
return mstrRegionId;
}
else if (conViewRegion.RegionName  ==  _AttributeName[intIndex])
{
return mstrRegionName;
}
else if (conViewRegion.RegionTypeId  ==  _AttributeName[intIndex])
{
return mstrRegionTypeId;
}
else if (conViewRegion.FileName  ==  _AttributeName[intIndex])
{
return mstrFileName;
}
else if (conViewRegion.Height  ==  _AttributeName[intIndex])
{
return mintHeight;
}
else if (conViewRegion.Width  ==  _AttributeName[intIndex])
{
return mintWidth;
}
else if (conViewRegion.ColNum  ==  _AttributeName[intIndex])
{
return mintColNum;
}
else if (conViewRegion.ContainerTypeId  ==  _AttributeName[intIndex])
{
return mstrContainerTypeId;
}
else if (conViewRegion.PageDispModeId  ==  _AttributeName[intIndex])
{
return mstrPageDispModeId;
}
else if (conViewRegion.InOutTypeId  ==  _AttributeName[intIndex])
{
return mstrInOutTypeId;
}
else if (conViewRegion.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (conViewRegion.KeyId4Test  ==  _AttributeName[intIndex])
{
return mstrKeyId4Test;
}
else if (conViewRegion.ErrMsg  ==  _AttributeName[intIndex])
{
return mstrErrMsg;
}
else if (conViewRegion.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conViewRegion.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conViewRegion.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conViewRegion.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (conViewRegion.ClsName  ==  _AttributeName[intIndex])
{
return mstrClsName;
}
return null;
}
set
{
if (conViewRegion.RegionId  ==  _AttributeName[intIndex])
{
mstrRegionId = value.ToString();
 AddUpdatedFld(conViewRegion.RegionId);
}
else if (conViewRegion.RegionName  ==  _AttributeName[intIndex])
{
mstrRegionName = value.ToString();
 AddUpdatedFld(conViewRegion.RegionName);
}
else if (conViewRegion.RegionTypeId  ==  _AttributeName[intIndex])
{
mstrRegionTypeId = value.ToString();
 AddUpdatedFld(conViewRegion.RegionTypeId);
}
else if (conViewRegion.FileName  ==  _AttributeName[intIndex])
{
mstrFileName = value.ToString();
 AddUpdatedFld(conViewRegion.FileName);
}
else if (conViewRegion.Height  ==  _AttributeName[intIndex])
{
mintHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewRegion.Height);
}
else if (conViewRegion.Width  ==  _AttributeName[intIndex])
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewRegion.Width);
}
else if (conViewRegion.ColNum  ==  _AttributeName[intIndex])
{
mintColNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewRegion.ColNum);
}
else if (conViewRegion.ContainerTypeId  ==  _AttributeName[intIndex])
{
mstrContainerTypeId = value.ToString();
 AddUpdatedFld(conViewRegion.ContainerTypeId);
}
else if (conViewRegion.PageDispModeId  ==  _AttributeName[intIndex])
{
mstrPageDispModeId = value.ToString();
 AddUpdatedFld(conViewRegion.PageDispModeId);
}
else if (conViewRegion.InOutTypeId  ==  _AttributeName[intIndex])
{
mstrInOutTypeId = value.ToString();
 AddUpdatedFld(conViewRegion.InOutTypeId);
}
else if (conViewRegion.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(conViewRegion.TabId);
}
else if (conViewRegion.KeyId4Test  ==  _AttributeName[intIndex])
{
mstrKeyId4Test = value.ToString();
 AddUpdatedFld(conViewRegion.KeyId4Test);
}
else if (conViewRegion.ErrMsg  ==  _AttributeName[intIndex])
{
mstrErrMsg = value.ToString();
 AddUpdatedFld(conViewRegion.ErrMsg);
}
else if (conViewRegion.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conViewRegion.PrjId);
}
else if (conViewRegion.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conViewRegion.UpdUser);
}
else if (conViewRegion.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conViewRegion.UpdDate);
}
else if (conViewRegion.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conViewRegion.Memo);
}
else if (conViewRegion.ClsName  ==  _AttributeName[intIndex])
{
mstrClsName = value.ToString();
 AddUpdatedFld(conViewRegion.ClsName);
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
 AddUpdatedFld(conViewRegion.RegionId);
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
 AddUpdatedFld(conViewRegion.RegionName);
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
 AddUpdatedFld(conViewRegion.RegionTypeId);
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
 AddUpdatedFld(conViewRegion.FileName);
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
 AddUpdatedFld(conViewRegion.Height);
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
 AddUpdatedFld(conViewRegion.Width);
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
 AddUpdatedFld(conViewRegion.ColNum);
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
 AddUpdatedFld(conViewRegion.ContainerTypeId);
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
 AddUpdatedFld(conViewRegion.PageDispModeId);
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
 AddUpdatedFld(conViewRegion.InOutTypeId);
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
 AddUpdatedFld(conViewRegion.TabId);
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
 AddUpdatedFld(conViewRegion.KeyId4Test);
}
}
/// <summary>
/// 错误信息(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ErrMsg
{
get
{
return mstrErrMsg;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrErrMsg = value;
}
else
{
 mstrErrMsg = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewRegion.ErrMsg);
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
 AddUpdatedFld(conViewRegion.PrjId);
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
 AddUpdatedFld(conViewRegion.UpdUser);
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
 AddUpdatedFld(conViewRegion.UpdDate);
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
 AddUpdatedFld(conViewRegion.Memo);
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
 AddUpdatedFld(conViewRegion.ClsName);
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

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrRegionName;
 }
 }
}
 /// <summary>
 /// 界面区域(ViewRegion)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conViewRegion
{
public const string _CurrTabName = "ViewRegion"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "RegionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"RegionId", "RegionName", "RegionTypeId", "FileName", "Height", "Width", "ColNum", "ContainerTypeId", "PageDispModeId", "InOutTypeId", "TabId", "KeyId4Test", "ErrMsg", "PrjId", "UpdUser", "UpdDate", "Memo", "ClsName"};
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
 /// 常量:"TabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabId = "TabId";    //表ID

 /// <summary>
 /// 常量:"KeyId4Test"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KeyId4Test = "KeyId4Test";    //测试关键字Id

 /// <summary>
 /// 常量:"ErrMsg"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ErrMsg = "ErrMsg";    //错误信息

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
 /// 常量:"ClsName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClsName = "ClsName";    //类名
}

}