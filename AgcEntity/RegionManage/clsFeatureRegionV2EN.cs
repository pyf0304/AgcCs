
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFeatureRegionV2EN
 表名:FeatureRegionV2(00050451)
 生成代码版本:2019.04.19.1
 生成日期:2019/04/21 08:47:30
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:AGC
 工程ID:0005
 相关数据库:101.251.68.133,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:区域管理
 模块英文名:RegionManage
 框架-层名:实体层(EntityLayer)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
using System;
using System.Text; 
using System.Collections; 
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System.Runtime.Serialization;

namespace AGC.Entity
{
 /// <summary>
 /// 表FeatureRegionV2的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public struct K_mId_FeatureRegionV2
{
public long Value { get; }
public K_mId_FeatureRegionV2(long lngmId)
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
}
 /// <summary>
 /// 功能区域V2(FeatureRegionV2)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsFeatureRegionV2EN : clsEntityBase2
{
public const string _CurrTabName_S = "FeatureRegionV2"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 20;
public static string[] AttributeName = new string[] {"mId", "RegionId", "FeatureId", "FeatureDescription", "ButtonName", "Text", "ViewImplId", "CtlTypeId", "Height", "Width", "SeqNum", "CssClass", "ImageUrl", "InUse", "ReleTabId", "ReleFldId", "DefaValue", "UpdUser", "UpdDate", "Memo"};
//以下是属性变量

protected long mlngmId;    //mId
protected long mlngRegionId;    //区域Id
protected string mstrFeatureId;    //功能Id
protected string mstrFeatureDescription;    //功能说明
protected string mstrButtonName;    //按钮名称
protected string mstrText;    //文本
protected string mstrViewImplId;    //界面实现Id
protected string mstrCtlTypeId;    //控件类型号
protected int mintHeight;    //高度
protected int mintWidth;    //宽
protected int mintSeqNum;    //字段序号
protected string mstrCssClass;    //样式表
protected string mstrImageUrl;    //图片资源
protected bool mbolInUse;    //是否在用
protected string mstrReleTabId;    //相关表Id
protected string mstrReleFldId;    //相关字段Id
protected string mstrDefaValue;    //DefaValue
protected string mstrUpdUser;    //修改者
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //说明


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_mId = "mId";    //mId

 /// <summary>
 /// 常量:"RegionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_RegionId = "RegionId";    //区域Id

 /// <summary>
 /// 常量:"FeatureId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_FeatureId = "FeatureId";    //功能Id

 /// <summary>
 /// 常量:"FeatureDescription"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_FeatureDescription = "FeatureDescription";    //功能说明

 /// <summary>
 /// 常量:"ButtonName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ButtonName = "ButtonName";    //按钮名称

 /// <summary>
 /// 常量:"Text"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Text = "Text";    //文本

 /// <summary>
 /// 常量:"ViewImplId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ViewImplId = "ViewImplId";    //界面实现Id

 /// <summary>
 /// 常量:"CtlTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_CtlTypeId = "CtlTypeId";    //控件类型号

 /// <summary>
 /// 常量:"Height"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Height = "Height";    //高度

 /// <summary>
 /// 常量:"Width"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Width = "Width";    //宽

 /// <summary>
 /// 常量:"SeqNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_SeqNum = "SeqNum";    //字段序号

 /// <summary>
 /// 常量:"CssClass"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_CssClass = "CssClass";    //样式表

 /// <summary>
 /// 常量:"ImageUrl"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ImageUrl = "ImageUrl";    //图片资源

 /// <summary>
 /// 常量:"InUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_InUse = "InUse";    //是否在用

 /// <summary>
 /// 常量:"ReleTabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ReleTabId = "ReleTabId";    //相关表Id

 /// <summary>
 /// 常量:"ReleFldId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ReleFldId = "ReleFldId";    //相关字段Id

 /// <summary>
 /// 常量:"DefaValue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_DefaValue = "DefaValue";    //DefaValue

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpdUser = "UpdUser";    //修改者

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo = "Memo";    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsFeatureRegionV2EN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "FeatureRegionV2";
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "mlngmId">关键字:mId</param>
public clsFeatureRegionV2EN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "FeatureRegionV2";
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
if (strAttributeName  ==  con_mId)
{
return mlngmId;
}
else if (strAttributeName  ==  con_RegionId)
{
return mlngRegionId;
}
else if (strAttributeName  ==  con_FeatureId)
{
return mstrFeatureId;
}
else if (strAttributeName  ==  con_FeatureDescription)
{
return mstrFeatureDescription;
}
else if (strAttributeName  ==  con_ButtonName)
{
return mstrButtonName;
}
else if (strAttributeName  ==  con_Text)
{
return mstrText;
}
else if (strAttributeName  ==  con_ViewImplId)
{
return mstrViewImplId;
}
else if (strAttributeName  ==  con_CtlTypeId)
{
return mstrCtlTypeId;
}
else if (strAttributeName  ==  con_Height)
{
return mintHeight;
}
else if (strAttributeName  ==  con_Width)
{
return mintWidth;
}
else if (strAttributeName  ==  con_SeqNum)
{
return mintSeqNum;
}
else if (strAttributeName  ==  con_CssClass)
{
return mstrCssClass;
}
else if (strAttributeName  ==  con_ImageUrl)
{
return mstrImageUrl;
}
else if (strAttributeName  ==  con_InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  con_ReleTabId)
{
return mstrReleTabId;
}
else if (strAttributeName  ==  con_ReleFldId)
{
return mstrReleFldId;
}
else if (strAttributeName  ==  con_DefaValue)
{
return mstrDefaValue;
}
else if (strAttributeName  ==  con_UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  con_UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  con_Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  con_mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(con_mId);
}
else if (strAttributeName  ==  con_RegionId)
{
mlngRegionId = TransNullToInt(value.ToString());
 AddUpdatedFld(con_RegionId);
}
else if (strAttributeName  ==  con_FeatureId)
{
mstrFeatureId = value.ToString();
 AddUpdatedFld(con_FeatureId);
}
else if (strAttributeName  ==  con_FeatureDescription)
{
mstrFeatureDescription = value.ToString();
 AddUpdatedFld(con_FeatureDescription);
}
else if (strAttributeName  ==  con_ButtonName)
{
mstrButtonName = value.ToString();
 AddUpdatedFld(con_ButtonName);
}
else if (strAttributeName  ==  con_Text)
{
mstrText = value.ToString();
 AddUpdatedFld(con_Text);
}
else if (strAttributeName  ==  con_ViewImplId)
{
mstrViewImplId = value.ToString();
 AddUpdatedFld(con_ViewImplId);
}
else if (strAttributeName  ==  con_CtlTypeId)
{
mstrCtlTypeId = value.ToString();
 AddUpdatedFld(con_CtlTypeId);
}
else if (strAttributeName  ==  con_Height)
{
mintHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(con_Height);
}
else if (strAttributeName  ==  con_Width)
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(con_Width);
}
else if (strAttributeName  ==  con_SeqNum)
{
mintSeqNum = TransNullToInt(value.ToString());
 AddUpdatedFld(con_SeqNum);
}
else if (strAttributeName  ==  con_CssClass)
{
mstrCssClass = value.ToString();
 AddUpdatedFld(con_CssClass);
}
else if (strAttributeName  ==  con_ImageUrl)
{
mstrImageUrl = value.ToString();
 AddUpdatedFld(con_ImageUrl);
}
else if (strAttributeName  ==  con_InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(con_InUse);
}
else if (strAttributeName  ==  con_ReleTabId)
{
mstrReleTabId = value.ToString();
 AddUpdatedFld(con_ReleTabId);
}
else if (strAttributeName  ==  con_ReleFldId)
{
mstrReleFldId = value.ToString();
 AddUpdatedFld(con_ReleFldId);
}
else if (strAttributeName  ==  con_DefaValue)
{
mstrDefaValue = value.ToString();
 AddUpdatedFld(con_DefaValue);
}
else if (strAttributeName  ==  con_UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(con_UpdUser);
}
else if (strAttributeName  ==  con_UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(con_UpdDate);
}
else if (strAttributeName  ==  con_Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (con_mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (con_RegionId  ==  AttributeName[intIndex])
{
return mlngRegionId;
}
else if (con_FeatureId  ==  AttributeName[intIndex])
{
return mstrFeatureId;
}
else if (con_FeatureDescription  ==  AttributeName[intIndex])
{
return mstrFeatureDescription;
}
else if (con_ButtonName  ==  AttributeName[intIndex])
{
return mstrButtonName;
}
else if (con_Text  ==  AttributeName[intIndex])
{
return mstrText;
}
else if (con_ViewImplId  ==  AttributeName[intIndex])
{
return mstrViewImplId;
}
else if (con_CtlTypeId  ==  AttributeName[intIndex])
{
return mstrCtlTypeId;
}
else if (con_Height  ==  AttributeName[intIndex])
{
return mintHeight;
}
else if (con_Width  ==  AttributeName[intIndex])
{
return mintWidth;
}
else if (con_SeqNum  ==  AttributeName[intIndex])
{
return mintSeqNum;
}
else if (con_CssClass  ==  AttributeName[intIndex])
{
return mstrCssClass;
}
else if (con_ImageUrl  ==  AttributeName[intIndex])
{
return mstrImageUrl;
}
else if (con_InUse  ==  AttributeName[intIndex])
{
return mbolInUse;
}
else if (con_ReleTabId  ==  AttributeName[intIndex])
{
return mstrReleTabId;
}
else if (con_ReleFldId  ==  AttributeName[intIndex])
{
return mstrReleFldId;
}
else if (con_DefaValue  ==  AttributeName[intIndex])
{
return mstrDefaValue;
}
else if (con_UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (con_UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (con_Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (con_mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(con_mId);
}
else if (con_RegionId  ==  AttributeName[intIndex])
{
mlngRegionId = TransNullToInt(value.ToString());
 AddUpdatedFld(con_RegionId);
}
else if (con_FeatureId  ==  AttributeName[intIndex])
{
mstrFeatureId = value.ToString();
 AddUpdatedFld(con_FeatureId);
}
else if (con_FeatureDescription  ==  AttributeName[intIndex])
{
mstrFeatureDescription = value.ToString();
 AddUpdatedFld(con_FeatureDescription);
}
else if (con_ButtonName  ==  AttributeName[intIndex])
{
mstrButtonName = value.ToString();
 AddUpdatedFld(con_ButtonName);
}
else if (con_Text  ==  AttributeName[intIndex])
{
mstrText = value.ToString();
 AddUpdatedFld(con_Text);
}
else if (con_ViewImplId  ==  AttributeName[intIndex])
{
mstrViewImplId = value.ToString();
 AddUpdatedFld(con_ViewImplId);
}
else if (con_CtlTypeId  ==  AttributeName[intIndex])
{
mstrCtlTypeId = value.ToString();
 AddUpdatedFld(con_CtlTypeId);
}
else if (con_Height  ==  AttributeName[intIndex])
{
mintHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(con_Height);
}
else if (con_Width  ==  AttributeName[intIndex])
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(con_Width);
}
else if (con_SeqNum  ==  AttributeName[intIndex])
{
mintSeqNum = TransNullToInt(value.ToString());
 AddUpdatedFld(con_SeqNum);
}
else if (con_CssClass  ==  AttributeName[intIndex])
{
mstrCssClass = value.ToString();
 AddUpdatedFld(con_CssClass);
}
else if (con_ImageUrl  ==  AttributeName[intIndex])
{
mstrImageUrl = value.ToString();
 AddUpdatedFld(con_ImageUrl);
}
else if (con_InUse  ==  AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(con_InUse);
}
else if (con_ReleTabId  ==  AttributeName[intIndex])
{
mstrReleTabId = value.ToString();
 AddUpdatedFld(con_ReleTabId);
}
else if (con_ReleFldId  ==  AttributeName[intIndex])
{
mstrReleFldId = value.ToString();
 AddUpdatedFld(con_ReleFldId);
}
else if (con_DefaValue  ==  AttributeName[intIndex])
{
mstrDefaValue = value.ToString();
 AddUpdatedFld(con_DefaValue);
}
else if (con_UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(con_UpdUser);
}
else if (con_UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(con_UpdDate);
}
else if (con_Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
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
 AddUpdatedFld(con_mId);
}
}
/// <summary>
/// 区域Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long RegionId
{
get
{
return mlngRegionId;
}
set
{
 mlngRegionId = value;
//记录修改过的字段
 AddUpdatedFld(con_RegionId);
}
}
/// <summary>
/// 功能Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FeatureId
{
get
{
return mstrFeatureId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFeatureId = value;
}
else
{
 mstrFeatureId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_FeatureId);
}
}
/// <summary>
/// 功能说明(说明:;字段类型:varchar;字段长度:4000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FeatureDescription
{
get
{
return mstrFeatureDescription;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFeatureDescription = value;
}
else
{
 mstrFeatureDescription = value;
}
//记录修改过的字段
 AddUpdatedFld(con_FeatureDescription);
}
}
/// <summary>
/// 按钮名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ButtonName
{
get
{
return mstrButtonName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrButtonName = value;
}
else
{
 mstrButtonName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_ButtonName);
}
}
/// <summary>
/// 文本(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Text
{
get
{
return mstrText;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrText = value;
}
else
{
 mstrText = value;
}
//记录修改过的字段
 AddUpdatedFld(con_Text);
}
}
/// <summary>
/// 界面实现Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewImplId
{
get
{
return mstrViewImplId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewImplId = value;
}
else
{
 mstrViewImplId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_ViewImplId);
}
}
/// <summary>
/// 控件类型号(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CtlTypeId
{
get
{
return mstrCtlTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCtlTypeId = value;
}
else
{
 mstrCtlTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_CtlTypeId);
}
}
/// <summary>
/// 高度(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int Height
{
get
{
return mintHeight;
}
set
{
 mintHeight = value;
//记录修改过的字段
 AddUpdatedFld(con_Height);
}
}
/// <summary>
/// 宽(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int Width
{
get
{
return mintWidth;
}
set
{
 mintWidth = value;
//记录修改过的字段
 AddUpdatedFld(con_Width);
}
}
/// <summary>
/// 字段序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int SeqNum
{
get
{
return mintSeqNum;
}
set
{
 mintSeqNum = value;
//记录修改过的字段
 AddUpdatedFld(con_SeqNum);
}
}
/// <summary>
/// 样式表(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CssClass
{
get
{
return mstrCssClass;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCssClass = value;
}
else
{
 mstrCssClass = value;
}
//记录修改过的字段
 AddUpdatedFld(con_CssClass);
}
}
/// <summary>
/// 图片资源(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ImageUrl
{
get
{
return mstrImageUrl;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrImageUrl = value;
}
else
{
 mstrImageUrl = value;
}
//记录修改过的字段
 AddUpdatedFld(con_ImageUrl);
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
 AddUpdatedFld(con_InUse);
}
}
/// <summary>
/// 相关表Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ReleTabId
{
get
{
return mstrReleTabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrReleTabId = value;
}
else
{
 mstrReleTabId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_ReleTabId);
}
}
/// <summary>
/// 相关字段Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ReleFldId
{
get
{
return mstrReleFldId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrReleFldId = value;
}
else
{
 mstrReleFldId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_ReleFldId);
}
}
/// <summary>
/// DefaValue(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DefaValue
{
get
{
return mstrDefaValue;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDefaValue = value;
}
else
{
 mstrDefaValue = value;
}
//记录修改过的字段
 AddUpdatedFld(con_DefaValue);
}
}
/// <summary>
/// 修改者(说明:;字段类型:varchar;字段长度:18;是否可空:True)
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
 AddUpdatedFld(con_UpdUser);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:14;是否可空:True)
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
 AddUpdatedFld(con_UpdDate);
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
 AddUpdatedFld(con_Memo);
}
}

/// <summary>
/// 获取关键字Id(KeyId)
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
}