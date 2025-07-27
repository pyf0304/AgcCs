
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvListViewRegionEN
 表名:vListViewRegion(00050155)
 生成代码版本:2018.08.11.1
 生成日期:2018/08/12 00:23:21
 生成者:潘以锋
 生成服务器IP:101.251.68.133
 工程名称:AGC
 工程ID:0005
 相关数据库:101.251.68.133,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:区域管理
 模块英文名:RegionManage
 框架-层名:实体层(EntityLayer)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2018.07.27.01
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
 /// vListView区域(vListViewRegion)
 /// (AutoGCLib.AutoGC6Cs_M:A_GenEntityLayerCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvListViewRegionEN : clsEntityBase2
{
public const string CurrTabName_S = "vListViewRegion"; //当前表名,与该类相关的表名
public const string CurrTabKeyFldName_S = "RegionId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 25;
public static string[] AttributeName = new string[] {"RegionId", "FontName", "FontSize", "Width", "IsCheck", "Height", "ViewId", "ColNum", "ViewName", "Memo", "ViewCnName", "RegionTypeId", "RegionTypeName", "RegionName", "RegionFunction", "OUTRelaTabId", "INSQLDSTypeId", "INRelaTabId", "OUTSQLDSTypeId", "OUTSqlDsTypeName", "OUTTabName", "OUTTabCnName", "INSqlDsTypeName", "INTabName", "INTabCnName"};
//以下是属性变量

protected long mlngRegionId;    //区域Id
protected string mstrFontName;    //字体
protected string mstrFontSize;    //字号
protected int mintWidth;    //宽
protected bool mbolIsCheck;    //是否复选框
protected int mintHeight;    //高度
protected string mstrViewId;    //界面ID
protected int mintColNum;    //列数
protected string mstrViewName;    //界面名称
protected string mstrMemo;    //说明
protected string mstrViewCnName;    //视图中文名
protected string mstrRegionTypeId;    //区域类型Id
protected string mstrRegionTypeName;    //区域类型名称
protected string mstrRegionName;    //区域名称
protected string mstrRegionFunction;    //区域功能
protected string mstrOUTRelaTabId;    //输出数据源表ID
protected string mstrINSQLDSTypeId;    //输入数据源类型
protected string mstrINRelaTabId;    //输入数据源表ID
protected string mstrOUTSQLDSTypeId;    //输出数据源类型
protected string mstrOUTSqlDsTypeName;    //OUTSqlDsTypeName
protected string mstrOUTTabName;    //OUTTabName
protected string mstrOUTTabCnName;    //OUTTabCnName
protected string mstrINSqlDsTypeName;    //INSqlDsTypeName
protected string mstrINTabName;    //INTabName
protected string mstrINTabCnName;    //INTabCnName


 /// <summary>
 /// 常量:"RegionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_RegionId = "RegionId";    //区域Id

 /// <summary>
 /// 常量:"FontName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_FontName = "FontName";    //字体

 /// <summary>
 /// 常量:"FontSize"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_FontSize = "FontSize";    //字号

 /// <summary>
 /// 常量:"Width"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Width = "Width";    //宽

 /// <summary>
 /// 常量:"IsCheck"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsCheck = "IsCheck";    //是否复选框

 /// <summary>
 /// 常量:"Height"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Height = "Height";    //高度

 /// <summary>
 /// 常量:"ViewId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ViewId = "ViewId";    //界面ID

 /// <summary>
 /// 常量:"ColNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ColNum = "ColNum";    //列数

 /// <summary>
 /// 常量:"ViewName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ViewName = "ViewName";    //界面名称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo = "Memo";    //说明

 /// <summary>
 /// 常量:"ViewCnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ViewCnName = "ViewCnName";    //视图中文名

 /// <summary>
 /// 常量:"RegionTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_RegionTypeId = "RegionTypeId";    //区域类型Id

 /// <summary>
 /// 常量:"RegionTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_RegionTypeName = "RegionTypeName";    //区域类型名称

 /// <summary>
 /// 常量:"RegionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_RegionName = "RegionName";    //区域名称

 /// <summary>
 /// 常量:"RegionFunction"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_RegionFunction = "RegionFunction";    //区域功能

 /// <summary>
 /// 常量:"OUTRelaTabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_OUTRelaTabId = "OUTRelaTabId";    //输出数据源表ID

 /// <summary>
 /// 常量:"INSQLDSTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_INSQLDSTypeId = "INSQLDSTypeId";    //输入数据源类型

 /// <summary>
 /// 常量:"INRelaTabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_INRelaTabId = "INRelaTabId";    //输入数据源表ID

 /// <summary>
 /// 常量:"OUTSQLDSTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_OUTSQLDSTypeId = "OUTSQLDSTypeId";    //输出数据源类型

 /// <summary>
 /// 常量:"OUTSqlDsTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_OUTSqlDsTypeName = "OUTSqlDsTypeName";    //OUTSqlDsTypeName

 /// <summary>
 /// 常量:"OUTTabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_OUTTabName = "OUTTabName";    //OUTTabName

 /// <summary>
 /// 常量:"OUTTabCnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_OUTTabCnName = "OUTTabCnName";    //OUTTabCnName

 /// <summary>
 /// 常量:"INSqlDsTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_INSqlDsTypeName = "INSqlDsTypeName";    //INSqlDsTypeName

 /// <summary>
 /// 常量:"INTabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_INTabName = "INTabName";    //INTabName

 /// <summary>
 /// 常量:"INTabCnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_INTabCnName = "INTabCnName";    //INTabCnName

/// <summary>
/// 构造函数
 /// (AutoGCLib.AutoGCPubFuncV6:GenClassConstructor1)
/// </summary>
 public clsvListViewRegionEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "vListViewRegion";
 lstKeyFldNames.Add("RegionId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.AutoGCPubFuncV6:GenClassConstructor2)
/// </summary>
/// <param name = "mlngRegionId">关键字:区域Id</param>
public clsvListViewRegionEN(long lngRegionId)
 {
 if (lngRegionId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

mlngRegionId = lngRegionId;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "vListViewRegion";
 lstKeyFldNames.Add("RegionId");
 }

public static int AttributeCount
{
get
{
return mintAttributeCount;
}
}
public object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  con_RegionId)
{
return mlngRegionId;
}
else if (strAttributeName  ==  con_FontName)
{
return mstrFontName;
}
else if (strAttributeName  ==  con_FontSize)
{
return mstrFontSize;
}
else if (strAttributeName  ==  con_Width)
{
return mintWidth;
}
else if (strAttributeName  ==  con_IsCheck)
{
return mbolIsCheck;
}
else if (strAttributeName  ==  con_Height)
{
return mintHeight;
}
else if (strAttributeName  ==  con_ViewId)
{
return mstrViewId;
}
else if (strAttributeName  ==  con_ColNum)
{
return mintColNum;
}
else if (strAttributeName  ==  con_ViewName)
{
return mstrViewName;
}
else if (strAttributeName  ==  con_Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  con_ViewCnName)
{
return mstrViewCnName;
}
else if (strAttributeName  ==  con_RegionTypeId)
{
return mstrRegionTypeId;
}
else if (strAttributeName  ==  con_RegionTypeName)
{
return mstrRegionTypeName;
}
else if (strAttributeName  ==  con_RegionName)
{
return mstrRegionName;
}
else if (strAttributeName  ==  con_RegionFunction)
{
return mstrRegionFunction;
}
else if (strAttributeName  ==  con_OUTRelaTabId)
{
return mstrOUTRelaTabId;
}
else if (strAttributeName  ==  con_INSQLDSTypeId)
{
return mstrINSQLDSTypeId;
}
else if (strAttributeName  ==  con_INRelaTabId)
{
return mstrINRelaTabId;
}
else if (strAttributeName  ==  con_OUTSQLDSTypeId)
{
return mstrOUTSQLDSTypeId;
}
else if (strAttributeName  ==  con_OUTSqlDsTypeName)
{
return mstrOUTSqlDsTypeName;
}
else if (strAttributeName  ==  con_OUTTabName)
{
return mstrOUTTabName;
}
else if (strAttributeName  ==  con_OUTTabCnName)
{
return mstrOUTTabCnName;
}
else if (strAttributeName  ==  con_INSqlDsTypeName)
{
return mstrINSqlDsTypeName;
}
else if (strAttributeName  ==  con_INTabName)
{
return mstrINTabName;
}
else if (strAttributeName  ==  con_INTabCnName)
{
return mstrINTabCnName;
}
return null;
}
set
{
if (strAttributeName  ==  con_RegionId)
{
mlngRegionId = TransNullToInt(value.ToString());
 AddUpdatedFld(con_RegionId);
}
else if (strAttributeName  ==  con_FontName)
{
mstrFontName = value.ToString();
 AddUpdatedFld(con_FontName);
}
else if (strAttributeName  ==  con_FontSize)
{
mstrFontSize = value.ToString();
 AddUpdatedFld(con_FontSize);
}
else if (strAttributeName  ==  con_Width)
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(con_Width);
}
else if (strAttributeName  ==  con_IsCheck)
{
mbolIsCheck = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsCheck);
}
else if (strAttributeName  ==  con_Height)
{
mintHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(con_Height);
}
else if (strAttributeName  ==  con_ViewId)
{
mstrViewId = value.ToString();
 AddUpdatedFld(con_ViewId);
}
else if (strAttributeName  ==  con_ColNum)
{
mintColNum = TransNullToInt(value.ToString());
 AddUpdatedFld(con_ColNum);
}
else if (strAttributeName  ==  con_ViewName)
{
mstrViewName = value.ToString();
 AddUpdatedFld(con_ViewName);
}
else if (strAttributeName  ==  con_Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
}
else if (strAttributeName  ==  con_ViewCnName)
{
mstrViewCnName = value.ToString();
 AddUpdatedFld(con_ViewCnName);
}
else if (strAttributeName  ==  con_RegionTypeId)
{
mstrRegionTypeId = value.ToString();
 AddUpdatedFld(con_RegionTypeId);
}
else if (strAttributeName  ==  con_RegionTypeName)
{
mstrRegionTypeName = value.ToString();
 AddUpdatedFld(con_RegionTypeName);
}
else if (strAttributeName  ==  con_RegionName)
{
mstrRegionName = value.ToString();
 AddUpdatedFld(con_RegionName);
}
else if (strAttributeName  ==  con_RegionFunction)
{
mstrRegionFunction = value.ToString();
 AddUpdatedFld(con_RegionFunction);
}
else if (strAttributeName  ==  con_OUTRelaTabId)
{
mstrOUTRelaTabId = value.ToString();
 AddUpdatedFld(con_OUTRelaTabId);
}
else if (strAttributeName  ==  con_INSQLDSTypeId)
{
mstrINSQLDSTypeId = value.ToString();
 AddUpdatedFld(con_INSQLDSTypeId);
}
else if (strAttributeName  ==  con_INRelaTabId)
{
mstrINRelaTabId = value.ToString();
 AddUpdatedFld(con_INRelaTabId);
}
else if (strAttributeName  ==  con_OUTSQLDSTypeId)
{
mstrOUTSQLDSTypeId = value.ToString();
 AddUpdatedFld(con_OUTSQLDSTypeId);
}
else if (strAttributeName  ==  con_OUTSqlDsTypeName)
{
mstrOUTSqlDsTypeName = value.ToString();
 AddUpdatedFld(con_OUTSqlDsTypeName);
}
else if (strAttributeName  ==  con_OUTTabName)
{
mstrOUTTabName = value.ToString();
 AddUpdatedFld(con_OUTTabName);
}
else if (strAttributeName  ==  con_OUTTabCnName)
{
mstrOUTTabCnName = value.ToString();
 AddUpdatedFld(con_OUTTabCnName);
}
else if (strAttributeName  ==  con_INSqlDsTypeName)
{
mstrINSqlDsTypeName = value.ToString();
 AddUpdatedFld(con_INSqlDsTypeName);
}
else if (strAttributeName  ==  con_INTabName)
{
mstrINTabName = value.ToString();
 AddUpdatedFld(con_INTabName);
}
else if (strAttributeName  ==  con_INTabCnName)
{
mstrINTabCnName = value.ToString();
 AddUpdatedFld(con_INTabCnName);
}
}
}
public object this[int intIndex]
{
get
{
if (con_RegionId  ==  AttributeName[intIndex])
{
return mlngRegionId;
}
else if (con_FontName  ==  AttributeName[intIndex])
{
return mstrFontName;
}
else if (con_FontSize  ==  AttributeName[intIndex])
{
return mstrFontSize;
}
else if (con_Width  ==  AttributeName[intIndex])
{
return mintWidth;
}
else if (con_IsCheck  ==  AttributeName[intIndex])
{
return mbolIsCheck;
}
else if (con_Height  ==  AttributeName[intIndex])
{
return mintHeight;
}
else if (con_ViewId  ==  AttributeName[intIndex])
{
return mstrViewId;
}
else if (con_ColNum  ==  AttributeName[intIndex])
{
return mintColNum;
}
else if (con_ViewName  ==  AttributeName[intIndex])
{
return mstrViewName;
}
else if (con_Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (con_ViewCnName  ==  AttributeName[intIndex])
{
return mstrViewCnName;
}
else if (con_RegionTypeId  ==  AttributeName[intIndex])
{
return mstrRegionTypeId;
}
else if (con_RegionTypeName  ==  AttributeName[intIndex])
{
return mstrRegionTypeName;
}
else if (con_RegionName  ==  AttributeName[intIndex])
{
return mstrRegionName;
}
else if (con_RegionFunction  ==  AttributeName[intIndex])
{
return mstrRegionFunction;
}
else if (con_OUTRelaTabId  ==  AttributeName[intIndex])
{
return mstrOUTRelaTabId;
}
else if (con_INSQLDSTypeId  ==  AttributeName[intIndex])
{
return mstrINSQLDSTypeId;
}
else if (con_INRelaTabId  ==  AttributeName[intIndex])
{
return mstrINRelaTabId;
}
else if (con_OUTSQLDSTypeId  ==  AttributeName[intIndex])
{
return mstrOUTSQLDSTypeId;
}
else if (con_OUTSqlDsTypeName  ==  AttributeName[intIndex])
{
return mstrOUTSqlDsTypeName;
}
else if (con_OUTTabName  ==  AttributeName[intIndex])
{
return mstrOUTTabName;
}
else if (con_OUTTabCnName  ==  AttributeName[intIndex])
{
return mstrOUTTabCnName;
}
else if (con_INSqlDsTypeName  ==  AttributeName[intIndex])
{
return mstrINSqlDsTypeName;
}
else if (con_INTabName  ==  AttributeName[intIndex])
{
return mstrINTabName;
}
else if (con_INTabCnName  ==  AttributeName[intIndex])
{
return mstrINTabCnName;
}
return null;
}
set
{
if (con_RegionId  ==  AttributeName[intIndex])
{
mlngRegionId = TransNullToInt(value.ToString());
 AddUpdatedFld(con_RegionId);
}
else if (con_FontName  ==  AttributeName[intIndex])
{
mstrFontName = value.ToString();
 AddUpdatedFld(con_FontName);
}
else if (con_FontSize  ==  AttributeName[intIndex])
{
mstrFontSize = value.ToString();
 AddUpdatedFld(con_FontSize);
}
else if (con_Width  ==  AttributeName[intIndex])
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(con_Width);
}
else if (con_IsCheck  ==  AttributeName[intIndex])
{
mbolIsCheck = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsCheck);
}
else if (con_Height  ==  AttributeName[intIndex])
{
mintHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(con_Height);
}
else if (con_ViewId  ==  AttributeName[intIndex])
{
mstrViewId = value.ToString();
 AddUpdatedFld(con_ViewId);
}
else if (con_ColNum  ==  AttributeName[intIndex])
{
mintColNum = TransNullToInt(value.ToString());
 AddUpdatedFld(con_ColNum);
}
else if (con_ViewName  ==  AttributeName[intIndex])
{
mstrViewName = value.ToString();
 AddUpdatedFld(con_ViewName);
}
else if (con_Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
}
else if (con_ViewCnName  ==  AttributeName[intIndex])
{
mstrViewCnName = value.ToString();
 AddUpdatedFld(con_ViewCnName);
}
else if (con_RegionTypeId  ==  AttributeName[intIndex])
{
mstrRegionTypeId = value.ToString();
 AddUpdatedFld(con_RegionTypeId);
}
else if (con_RegionTypeName  ==  AttributeName[intIndex])
{
mstrRegionTypeName = value.ToString();
 AddUpdatedFld(con_RegionTypeName);
}
else if (con_RegionName  ==  AttributeName[intIndex])
{
mstrRegionName = value.ToString();
 AddUpdatedFld(con_RegionName);
}
else if (con_RegionFunction  ==  AttributeName[intIndex])
{
mstrRegionFunction = value.ToString();
 AddUpdatedFld(con_RegionFunction);
}
else if (con_OUTRelaTabId  ==  AttributeName[intIndex])
{
mstrOUTRelaTabId = value.ToString();
 AddUpdatedFld(con_OUTRelaTabId);
}
else if (con_INSQLDSTypeId  ==  AttributeName[intIndex])
{
mstrINSQLDSTypeId = value.ToString();
 AddUpdatedFld(con_INSQLDSTypeId);
}
else if (con_INRelaTabId  ==  AttributeName[intIndex])
{
mstrINRelaTabId = value.ToString();
 AddUpdatedFld(con_INRelaTabId);
}
else if (con_OUTSQLDSTypeId  ==  AttributeName[intIndex])
{
mstrOUTSQLDSTypeId = value.ToString();
 AddUpdatedFld(con_OUTSQLDSTypeId);
}
else if (con_OUTSqlDsTypeName  ==  AttributeName[intIndex])
{
mstrOUTSqlDsTypeName = value.ToString();
 AddUpdatedFld(con_OUTSqlDsTypeName);
}
else if (con_OUTTabName  ==  AttributeName[intIndex])
{
mstrOUTTabName = value.ToString();
 AddUpdatedFld(con_OUTTabName);
}
else if (con_OUTTabCnName  ==  AttributeName[intIndex])
{
mstrOUTTabCnName = value.ToString();
 AddUpdatedFld(con_OUTTabCnName);
}
else if (con_INSqlDsTypeName  ==  AttributeName[intIndex])
{
mstrINSqlDsTypeName = value.ToString();
 AddUpdatedFld(con_INSqlDsTypeName);
}
else if (con_INTabName  ==  AttributeName[intIndex])
{
mstrINTabName = value.ToString();
 AddUpdatedFld(con_INTabName);
}
else if (con_INTabCnName  ==  AttributeName[intIndex])
{
mstrINTabCnName = value.ToString();
 AddUpdatedFld(con_INTabCnName);
}
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
/// 字体(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FontName
{
get
{
return mstrFontName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFontName = value;
}
else
{
 mstrFontName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_FontName);
}
}
/// <summary>
/// 字号(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FontSize
{
get
{
return mstrFontSize;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFontSize = value;
}
else
{
 mstrFontSize = value;
}
//记录修改过的字段
 AddUpdatedFld(con_FontSize);
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
/// 是否复选框(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsCheck
{
get
{
return mbolIsCheck;
}
set
{
 mbolIsCheck = value;
//记录修改过的字段
 AddUpdatedFld(con_IsCheck);
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
/// 界面ID(说明:;字段类型:varchar;字段长度:8;是否可空:True)
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
 AddUpdatedFld(con_ViewId);
}
}
/// <summary>
/// 列数(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int ColNum
{
get
{
return mintColNum;
}
set
{
 mintColNum = value;
//记录修改过的字段
 AddUpdatedFld(con_ColNum);
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
 AddUpdatedFld(con_ViewName);
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
 AddUpdatedFld(con_ViewCnName);
}
}
/// <summary>
/// 区域类型Id(说明:;字段类型:varchar;字段长度:4;是否可空:False)
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
 AddUpdatedFld(con_RegionTypeId);
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
 AddUpdatedFld(con_RegionTypeName);
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
 AddUpdatedFld(con_RegionName);
}
}
/// <summary>
/// 区域功能(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RegionFunction
{
get
{
return mstrRegionFunction;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRegionFunction = value;
}
else
{
 mstrRegionFunction = value;
}
//记录修改过的字段
 AddUpdatedFld(con_RegionFunction);
}
}
/// <summary>
/// 输出数据源表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OUTRelaTabId
{
get
{
return mstrOUTRelaTabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOUTRelaTabId = value;
}
else
{
 mstrOUTRelaTabId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_OUTRelaTabId);
}
}
/// <summary>
/// 输入数据源类型(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string INSQLDSTypeId
{
get
{
return mstrINSQLDSTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrINSQLDSTypeId = value;
}
else
{
 mstrINSQLDSTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_INSQLDSTypeId);
}
}
/// <summary>
/// 输入数据源表ID(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string INRelaTabId
{
get
{
return mstrINRelaTabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrINRelaTabId = value;
}
else
{
 mstrINRelaTabId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_INRelaTabId);
}
}
/// <summary>
/// 输出数据源类型(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OUTSQLDSTypeId
{
get
{
return mstrOUTSQLDSTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOUTSQLDSTypeId = value;
}
else
{
 mstrOUTSQLDSTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_OUTSQLDSTypeId);
}
}
/// <summary>
/// OUTSqlDsTypeName(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OUTSqlDsTypeName
{
get
{
return mstrOUTSqlDsTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOUTSqlDsTypeName = value;
}
else
{
 mstrOUTSqlDsTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_OUTSqlDsTypeName);
}
}
/// <summary>
/// OUTTabName(说明:;字段类型:varchar;字段长度:40;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OUTTabName
{
get
{
return mstrOUTTabName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOUTTabName = value;
}
else
{
 mstrOUTTabName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_OUTTabName);
}
}
/// <summary>
/// OUTTabCnName(说明:;字段类型:varchar;字段长度:40;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OUTTabCnName
{
get
{
return mstrOUTTabCnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOUTTabCnName = value;
}
else
{
 mstrOUTTabCnName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_OUTTabCnName);
}
}
/// <summary>
/// INSqlDsTypeName(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string INSqlDsTypeName
{
get
{
return mstrINSqlDsTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrINSqlDsTypeName = value;
}
else
{
 mstrINSqlDsTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_INSqlDsTypeName);
}
}
/// <summary>
/// INTabName(说明:;字段类型:varchar;字段长度:40;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string INTabName
{
get
{
return mstrINTabName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrINTabName = value;
}
else
{
 mstrINTabName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_INTabName);
}
}
/// <summary>
/// INTabCnName(说明:;字段类型:varchar;字段长度:40;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string INTabCnName
{
get
{
return mstrINTabCnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrINTabCnName = value;
}
else
{
 mstrINTabCnName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_INTabCnName);
}
}

/// <summary>
/// 获取关键字Id(KeyId)
 /// (AutoGCLib.AutoGCPubFuncV6:GenGetKeyId)
/// </summary>
 public override string _KeyId
 {
 get
 {
  return mlngRegionId.ToString();
 }
 }
}
}