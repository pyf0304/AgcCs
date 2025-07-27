
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvListViewRegionFldsEN
 表名:vListViewRegionFlds(00050200)
 生成代码版本:2018.08.11.1
 生成日期:2018/08/12 00:23:25
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
 /// vListView区域字段列表(vListViewRegionFlds)
 /// (AutoGCLib.AutoGC6Cs_M:A_GenEntityLayerCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvListViewRegionFldsEN : clsEntityBase2
{
public const string CurrTabName_S = "vListViewRegionFlds"; //当前表名,与该类相关的表名
public const string CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 34;
public static string[] AttributeName = new string[] {"mId", "TabName", "FldName", "Caption", "DataTypeName", "FldLength", "IsTabPrimary", "PrimaryTypeName", "IsParentObj", "ForeignTabName", "IsNull", "IsNeedTransCode", "MinValue", "MaxValue", "IsOnlyOne", "TabId", "PrjId", "FldID", "IsTabForeignKey", "PrimaryTypeId", "ForeignKeyTabId", "IsTabNullable", "SequenceNumber", "DataTypeId", "TabFldId", "ColCaption", "RegionId", "ColIndex", "IsNeedSort", "IsTransToChkBox", "IsVisible", "UserId", "Memo", "UpdDate"};
//以下是属性变量

protected long mlngmId;    //mId
protected string mstrTabName;    //表名
protected string mstrFldName;    //字段名
protected string mstrCaption;    //标题
protected string mstrDataTypeName;    //数据类型名称
protected int mintFldLength;    //字段长度
protected bool mbolIsTabPrimary;    //是否作为表中主键
protected string mstrPrimaryTypeName;    //主键类型名
protected bool mbolIsParentObj;    //是否父对象
protected string mstrForeignTabName;    //ForeignTabName
protected bool mbolIsNull;    //是否可空
protected bool mbolIsNeedTransCode;    //是否需要转换代码
protected string mstrMinValue;    //最小值
protected string mstrMaxValue;    //最大值
protected bool mbolIsOnlyOne;    //是否唯一
protected string mstrTabId;    //表ID
protected string mstrPrjId;    //工程ID
protected string mstrFldID;    //字段ID
protected bool mbolIsTabForeignKey;    //是否表外键
protected string mstrPrimaryTypeId;    //主键类型ID
protected string mstrForeignKeyTabId;    //外键表ID
protected bool mbolIsTabNullable;    //是否表中可空
protected int mintSequenceNumber;    //顺序号
protected string mstrDataTypeId;    //数据类型Id
protected long mlngTabFldId;    //表字段ID
protected string mstrColCaption;    //列标题
protected long mlngRegionId;    //区域Id
protected int mintColIndex;    //列序号
protected bool mbolIsNeedSort;    //是否需要排序
protected bool mbolIsTransToChkBox;    //是否转换成CheckBox
protected bool mbolIsVisible;    //是否显示
protected string mstrUserId;    //用户ID
protected string mstrMemo;    //说明
protected string mstrUpdDate;    //修改日期


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_mId = "mId";    //mId

 /// <summary>
 /// 常量:"TabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_TabName = "TabName";    //表名

 /// <summary>
 /// 常量:"FldName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_FldName = "FldName";    //字段名

 /// <summary>
 /// 常量:"Caption"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Caption = "Caption";    //标题

 /// <summary>
 /// 常量:"DataTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_DataTypeName = "DataTypeName";    //数据类型名称

 /// <summary>
 /// 常量:"FldLength"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_FldLength = "FldLength";    //字段长度

 /// <summary>
 /// 常量:"IsTabPrimary"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsTabPrimary = "IsTabPrimary";    //是否作为表中主键

 /// <summary>
 /// 常量:"PrimaryTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PrimaryTypeName = "PrimaryTypeName";    //主键类型名

 /// <summary>
 /// 常量:"IsParentObj"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsParentObj = "IsParentObj";    //是否父对象

 /// <summary>
 /// 常量:"ForeignTabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ForeignTabName = "ForeignTabName";    //ForeignTabName

 /// <summary>
 /// 常量:"IsNull"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsNull = "IsNull";    //是否可空

 /// <summary>
 /// 常量:"IsNeedTransCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsNeedTransCode = "IsNeedTransCode";    //是否需要转换代码

 /// <summary>
 /// 常量:"MinValue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_MinValue = "MinValue";    //最小值

 /// <summary>
 /// 常量:"MaxValue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_MaxValue = "MaxValue";    //最大值

 /// <summary>
 /// 常量:"IsOnlyOne"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsOnlyOne = "IsOnlyOne";    //是否唯一

 /// <summary>
 /// 常量:"TabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_TabId = "TabId";    //表ID

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PrjId = "PrjId";    //工程ID

 /// <summary>
 /// 常量:"FldID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_FldID = "FldID";    //字段ID

 /// <summary>
 /// 常量:"IsTabForeignKey"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsTabForeignKey = "IsTabForeignKey";    //是否表外键

 /// <summary>
 /// 常量:"PrimaryTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PrimaryTypeId = "PrimaryTypeId";    //主键类型ID

 /// <summary>
 /// 常量:"ForeignKeyTabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ForeignKeyTabId = "ForeignKeyTabId";    //外键表ID

 /// <summary>
 /// 常量:"IsTabNullable"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsTabNullable = "IsTabNullable";    //是否表中可空

 /// <summary>
 /// 常量:"SequenceNumber"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_SequenceNumber = "SequenceNumber";    //顺序号

 /// <summary>
 /// 常量:"DataTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_DataTypeId = "DataTypeId";    //数据类型Id

 /// <summary>
 /// 常量:"TabFldId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_TabFldId = "TabFldId";    //表字段ID

 /// <summary>
 /// 常量:"ColCaption"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ColCaption = "ColCaption";    //列标题

 /// <summary>
 /// 常量:"RegionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_RegionId = "RegionId";    //区域Id

 /// <summary>
 /// 常量:"ColIndex"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ColIndex = "ColIndex";    //列序号

 /// <summary>
 /// 常量:"IsNeedSort"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsNeedSort = "IsNeedSort";    //是否需要排序

 /// <summary>
 /// 常量:"IsTransToChkBox"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsTransToChkBox = "IsTransToChkBox";    //是否转换成CheckBox

 /// <summary>
 /// 常量:"IsVisible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsVisible = "IsVisible";    //是否显示

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo = "Memo";    //说明

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpdDate = "UpdDate";    //修改日期

/// <summary>
/// 构造函数
 /// (AutoGCLib.AutoGCPubFuncV6:GenClassConstructor1)
/// </summary>
 public clsvListViewRegionFldsEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "vListViewRegionFlds";
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.AutoGCPubFuncV6:GenClassConstructor2)
/// </summary>
/// <param name = "mlngmId">关键字:mId</param>
public clsvListViewRegionFldsEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "vListViewRegionFlds";
 lstKeyFldNames.Add("mId");
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
if (strAttributeName  ==  con_mId)
{
return mlngmId;
}
else if (strAttributeName  ==  con_TabName)
{
return mstrTabName;
}
else if (strAttributeName  ==  con_FldName)
{
return mstrFldName;
}
else if (strAttributeName  ==  con_Caption)
{
return mstrCaption;
}
else if (strAttributeName  ==  con_DataTypeName)
{
return mstrDataTypeName;
}
else if (strAttributeName  ==  con_FldLength)
{
return mintFldLength;
}
else if (strAttributeName  ==  con_IsTabPrimary)
{
return mbolIsTabPrimary;
}
else if (strAttributeName  ==  con_PrimaryTypeName)
{
return mstrPrimaryTypeName;
}
else if (strAttributeName  ==  con_IsParentObj)
{
return mbolIsParentObj;
}
else if (strAttributeName  ==  con_ForeignTabName)
{
return mstrForeignTabName;
}
else if (strAttributeName  ==  con_IsNull)
{
return mbolIsNull;
}
else if (strAttributeName  ==  con_IsNeedTransCode)
{
return mbolIsNeedTransCode;
}
else if (strAttributeName  ==  con_MinValue)
{
return mstrMinValue;
}
else if (strAttributeName  ==  con_MaxValue)
{
return mstrMaxValue;
}
else if (strAttributeName  ==  con_IsOnlyOne)
{
return mbolIsOnlyOne;
}
else if (strAttributeName  ==  con_TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  con_PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  con_FldID)
{
return mstrFldID;
}
else if (strAttributeName  ==  con_IsTabForeignKey)
{
return mbolIsTabForeignKey;
}
else if (strAttributeName  ==  con_PrimaryTypeId)
{
return mstrPrimaryTypeId;
}
else if (strAttributeName  ==  con_ForeignKeyTabId)
{
return mstrForeignKeyTabId;
}
else if (strAttributeName  ==  con_IsTabNullable)
{
return mbolIsTabNullable;
}
else if (strAttributeName  ==  con_SequenceNumber)
{
return mintSequenceNumber;
}
else if (strAttributeName  ==  con_DataTypeId)
{
return mstrDataTypeId;
}
else if (strAttributeName  ==  con_TabFldId)
{
return mlngTabFldId;
}
else if (strAttributeName  ==  con_ColCaption)
{
return mstrColCaption;
}
else if (strAttributeName  ==  con_RegionId)
{
return mlngRegionId;
}
else if (strAttributeName  ==  con_ColIndex)
{
return mintColIndex;
}
else if (strAttributeName  ==  con_IsNeedSort)
{
return mbolIsNeedSort;
}
else if (strAttributeName  ==  con_IsTransToChkBox)
{
return mbolIsTransToChkBox;
}
else if (strAttributeName  ==  con_IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  con_UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  con_Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  con_UpdDate)
{
return mstrUpdDate;
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
else if (strAttributeName  ==  con_TabName)
{
mstrTabName = value.ToString();
 AddUpdatedFld(con_TabName);
}
else if (strAttributeName  ==  con_FldName)
{
mstrFldName = value.ToString();
 AddUpdatedFld(con_FldName);
}
else if (strAttributeName  ==  con_Caption)
{
mstrCaption = value.ToString();
 AddUpdatedFld(con_Caption);
}
else if (strAttributeName  ==  con_DataTypeName)
{
mstrDataTypeName = value.ToString();
 AddUpdatedFld(con_DataTypeName);
}
else if (strAttributeName  ==  con_FldLength)
{
mintFldLength = TransNullToInt(value.ToString());
 AddUpdatedFld(con_FldLength);
}
else if (strAttributeName  ==  con_IsTabPrimary)
{
mbolIsTabPrimary = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsTabPrimary);
}
else if (strAttributeName  ==  con_PrimaryTypeName)
{
mstrPrimaryTypeName = value.ToString();
 AddUpdatedFld(con_PrimaryTypeName);
}
else if (strAttributeName  ==  con_IsParentObj)
{
mbolIsParentObj = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsParentObj);
}
else if (strAttributeName  ==  con_ForeignTabName)
{
mstrForeignTabName = value.ToString();
 AddUpdatedFld(con_ForeignTabName);
}
else if (strAttributeName  ==  con_IsNull)
{
mbolIsNull = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsNull);
}
else if (strAttributeName  ==  con_IsNeedTransCode)
{
mbolIsNeedTransCode = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsNeedTransCode);
}
else if (strAttributeName  ==  con_MinValue)
{
mstrMinValue = value.ToString();
 AddUpdatedFld(con_MinValue);
}
else if (strAttributeName  ==  con_MaxValue)
{
mstrMaxValue = value.ToString();
 AddUpdatedFld(con_MaxValue);
}
else if (strAttributeName  ==  con_IsOnlyOne)
{
mbolIsOnlyOne = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsOnlyOne);
}
else if (strAttributeName  ==  con_TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(con_TabId);
}
else if (strAttributeName  ==  con_PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(con_PrjId);
}
else if (strAttributeName  ==  con_FldID)
{
mstrFldID = value.ToString();
 AddUpdatedFld(con_FldID);
}
else if (strAttributeName  ==  con_IsTabForeignKey)
{
mbolIsTabForeignKey = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsTabForeignKey);
}
else if (strAttributeName  ==  con_PrimaryTypeId)
{
mstrPrimaryTypeId = value.ToString();
 AddUpdatedFld(con_PrimaryTypeId);
}
else if (strAttributeName  ==  con_ForeignKeyTabId)
{
mstrForeignKeyTabId = value.ToString();
 AddUpdatedFld(con_ForeignKeyTabId);
}
else if (strAttributeName  ==  con_IsTabNullable)
{
mbolIsTabNullable = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsTabNullable);
}
else if (strAttributeName  ==  con_SequenceNumber)
{
mintSequenceNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(con_SequenceNumber);
}
else if (strAttributeName  ==  con_DataTypeId)
{
mstrDataTypeId = value.ToString();
 AddUpdatedFld(con_DataTypeId);
}
else if (strAttributeName  ==  con_TabFldId)
{
mlngTabFldId = TransNullToInt(value.ToString());
 AddUpdatedFld(con_TabFldId);
}
else if (strAttributeName  ==  con_ColCaption)
{
mstrColCaption = value.ToString();
 AddUpdatedFld(con_ColCaption);
}
else if (strAttributeName  ==  con_RegionId)
{
mlngRegionId = TransNullToInt(value.ToString());
 AddUpdatedFld(con_RegionId);
}
else if (strAttributeName  ==  con_ColIndex)
{
mintColIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(con_ColIndex);
}
else if (strAttributeName  ==  con_IsNeedSort)
{
mbolIsNeedSort = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsNeedSort);
}
else if (strAttributeName  ==  con_IsTransToChkBox)
{
mbolIsTransToChkBox = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsTransToChkBox);
}
else if (strAttributeName  ==  con_IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsVisible);
}
else if (strAttributeName  ==  con_UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(con_UserId);
}
else if (strAttributeName  ==  con_Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
}
else if (strAttributeName  ==  con_UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(con_UpdDate);
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
else if (con_TabName  ==  AttributeName[intIndex])
{
return mstrTabName;
}
else if (con_FldName  ==  AttributeName[intIndex])
{
return mstrFldName;
}
else if (con_Caption  ==  AttributeName[intIndex])
{
return mstrCaption;
}
else if (con_DataTypeName  ==  AttributeName[intIndex])
{
return mstrDataTypeName;
}
else if (con_FldLength  ==  AttributeName[intIndex])
{
return mintFldLength;
}
else if (con_IsTabPrimary  ==  AttributeName[intIndex])
{
return mbolIsTabPrimary;
}
else if (con_PrimaryTypeName  ==  AttributeName[intIndex])
{
return mstrPrimaryTypeName;
}
else if (con_IsParentObj  ==  AttributeName[intIndex])
{
return mbolIsParentObj;
}
else if (con_ForeignTabName  ==  AttributeName[intIndex])
{
return mstrForeignTabName;
}
else if (con_IsNull  ==  AttributeName[intIndex])
{
return mbolIsNull;
}
else if (con_IsNeedTransCode  ==  AttributeName[intIndex])
{
return mbolIsNeedTransCode;
}
else if (con_MinValue  ==  AttributeName[intIndex])
{
return mstrMinValue;
}
else if (con_MaxValue  ==  AttributeName[intIndex])
{
return mstrMaxValue;
}
else if (con_IsOnlyOne  ==  AttributeName[intIndex])
{
return mbolIsOnlyOne;
}
else if (con_TabId  ==  AttributeName[intIndex])
{
return mstrTabId;
}
else if (con_PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
else if (con_FldID  ==  AttributeName[intIndex])
{
return mstrFldID;
}
else if (con_IsTabForeignKey  ==  AttributeName[intIndex])
{
return mbolIsTabForeignKey;
}
else if (con_PrimaryTypeId  ==  AttributeName[intIndex])
{
return mstrPrimaryTypeId;
}
else if (con_ForeignKeyTabId  ==  AttributeName[intIndex])
{
return mstrForeignKeyTabId;
}
else if (con_IsTabNullable  ==  AttributeName[intIndex])
{
return mbolIsTabNullable;
}
else if (con_SequenceNumber  ==  AttributeName[intIndex])
{
return mintSequenceNumber;
}
else if (con_DataTypeId  ==  AttributeName[intIndex])
{
return mstrDataTypeId;
}
else if (con_TabFldId  ==  AttributeName[intIndex])
{
return mlngTabFldId;
}
else if (con_ColCaption  ==  AttributeName[intIndex])
{
return mstrColCaption;
}
else if (con_RegionId  ==  AttributeName[intIndex])
{
return mlngRegionId;
}
else if (con_ColIndex  ==  AttributeName[intIndex])
{
return mintColIndex;
}
else if (con_IsNeedSort  ==  AttributeName[intIndex])
{
return mbolIsNeedSort;
}
else if (con_IsTransToChkBox  ==  AttributeName[intIndex])
{
return mbolIsTransToChkBox;
}
else if (con_IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (con_UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (con_Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (con_UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
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
else if (con_TabName  ==  AttributeName[intIndex])
{
mstrTabName = value.ToString();
 AddUpdatedFld(con_TabName);
}
else if (con_FldName  ==  AttributeName[intIndex])
{
mstrFldName = value.ToString();
 AddUpdatedFld(con_FldName);
}
else if (con_Caption  ==  AttributeName[intIndex])
{
mstrCaption = value.ToString();
 AddUpdatedFld(con_Caption);
}
else if (con_DataTypeName  ==  AttributeName[intIndex])
{
mstrDataTypeName = value.ToString();
 AddUpdatedFld(con_DataTypeName);
}
else if (con_FldLength  ==  AttributeName[intIndex])
{
mintFldLength = TransNullToInt(value.ToString());
 AddUpdatedFld(con_FldLength);
}
else if (con_IsTabPrimary  ==  AttributeName[intIndex])
{
mbolIsTabPrimary = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsTabPrimary);
}
else if (con_PrimaryTypeName  ==  AttributeName[intIndex])
{
mstrPrimaryTypeName = value.ToString();
 AddUpdatedFld(con_PrimaryTypeName);
}
else if (con_IsParentObj  ==  AttributeName[intIndex])
{
mbolIsParentObj = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsParentObj);
}
else if (con_ForeignTabName  ==  AttributeName[intIndex])
{
mstrForeignTabName = value.ToString();
 AddUpdatedFld(con_ForeignTabName);
}
else if (con_IsNull  ==  AttributeName[intIndex])
{
mbolIsNull = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsNull);
}
else if (con_IsNeedTransCode  ==  AttributeName[intIndex])
{
mbolIsNeedTransCode = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsNeedTransCode);
}
else if (con_MinValue  ==  AttributeName[intIndex])
{
mstrMinValue = value.ToString();
 AddUpdatedFld(con_MinValue);
}
else if (con_MaxValue  ==  AttributeName[intIndex])
{
mstrMaxValue = value.ToString();
 AddUpdatedFld(con_MaxValue);
}
else if (con_IsOnlyOne  ==  AttributeName[intIndex])
{
mbolIsOnlyOne = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsOnlyOne);
}
else if (con_TabId  ==  AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(con_TabId);
}
else if (con_PrjId  ==  AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(con_PrjId);
}
else if (con_FldID  ==  AttributeName[intIndex])
{
mstrFldID = value.ToString();
 AddUpdatedFld(con_FldID);
}
else if (con_IsTabForeignKey  ==  AttributeName[intIndex])
{
mbolIsTabForeignKey = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsTabForeignKey);
}
else if (con_PrimaryTypeId  ==  AttributeName[intIndex])
{
mstrPrimaryTypeId = value.ToString();
 AddUpdatedFld(con_PrimaryTypeId);
}
else if (con_ForeignKeyTabId  ==  AttributeName[intIndex])
{
mstrForeignKeyTabId = value.ToString();
 AddUpdatedFld(con_ForeignKeyTabId);
}
else if (con_IsTabNullable  ==  AttributeName[intIndex])
{
mbolIsTabNullable = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsTabNullable);
}
else if (con_SequenceNumber  ==  AttributeName[intIndex])
{
mintSequenceNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(con_SequenceNumber);
}
else if (con_DataTypeId  ==  AttributeName[intIndex])
{
mstrDataTypeId = value.ToString();
 AddUpdatedFld(con_DataTypeId);
}
else if (con_TabFldId  ==  AttributeName[intIndex])
{
mlngTabFldId = TransNullToInt(value.ToString());
 AddUpdatedFld(con_TabFldId);
}
else if (con_ColCaption  ==  AttributeName[intIndex])
{
mstrColCaption = value.ToString();
 AddUpdatedFld(con_ColCaption);
}
else if (con_RegionId  ==  AttributeName[intIndex])
{
mlngRegionId = TransNullToInt(value.ToString());
 AddUpdatedFld(con_RegionId);
}
else if (con_ColIndex  ==  AttributeName[intIndex])
{
mintColIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(con_ColIndex);
}
else if (con_IsNeedSort  ==  AttributeName[intIndex])
{
mbolIsNeedSort = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsNeedSort);
}
else if (con_IsTransToChkBox  ==  AttributeName[intIndex])
{
mbolIsTransToChkBox = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsTransToChkBox);
}
else if (con_IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsVisible);
}
else if (con_UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(con_UserId);
}
else if (con_Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
}
else if (con_UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(con_UpdDate);
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
 AddUpdatedFld(con_TabName);
}
}
/// <summary>
/// 字段名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FldName
{
get
{
return mstrFldName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldName = value;
}
else
{
 mstrFldName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_FldName);
}
}
/// <summary>
/// 标题(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Caption
{
get
{
return mstrCaption;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaption = value;
}
else
{
 mstrCaption = value;
}
//记录修改过的字段
 AddUpdatedFld(con_Caption);
}
}
/// <summary>
/// 数据类型名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataTypeName
{
get
{
return mstrDataTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataTypeName = value;
}
else
{
 mstrDataTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_DataTypeName);
}
}
/// <summary>
/// 字段长度(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int FldLength
{
get
{
return mintFldLength;
}
set
{
 mintFldLength = value;
//记录修改过的字段
 AddUpdatedFld(con_FldLength);
}
}
/// <summary>
/// 是否作为表中主键(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsTabPrimary
{
get
{
return mbolIsTabPrimary;
}
set
{
 mbolIsTabPrimary = value;
//记录修改过的字段
 AddUpdatedFld(con_IsTabPrimary);
}
}
/// <summary>
/// 主键类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrimaryTypeName
{
get
{
return mstrPrimaryTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrimaryTypeName = value;
}
else
{
 mstrPrimaryTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_PrimaryTypeName);
}
}
/// <summary>
/// 是否父对象(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsParentObj
{
get
{
return mbolIsParentObj;
}
set
{
 mbolIsParentObj = value;
//记录修改过的字段
 AddUpdatedFld(con_IsParentObj);
}
}
/// <summary>
/// ForeignTabName(说明:;字段类型:varchar;字段长度:40;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ForeignTabName
{
get
{
return mstrForeignTabName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrForeignTabName = value;
}
else
{
 mstrForeignTabName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_ForeignTabName);
}
}
/// <summary>
/// 是否可空(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsNull
{
get
{
return mbolIsNull;
}
set
{
 mbolIsNull = value;
//记录修改过的字段
 AddUpdatedFld(con_IsNull);
}
}
/// <summary>
/// 是否需要转换代码(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsNeedTransCode
{
get
{
return mbolIsNeedTransCode;
}
set
{
 mbolIsNeedTransCode = value;
//记录修改过的字段
 AddUpdatedFld(con_IsNeedTransCode);
}
}
/// <summary>
/// 最小值(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MinValue
{
get
{
return mstrMinValue;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMinValue = value;
}
else
{
 mstrMinValue = value;
}
//记录修改过的字段
 AddUpdatedFld(con_MinValue);
}
}
/// <summary>
/// 最大值(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MaxValue
{
get
{
return mstrMaxValue;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMaxValue = value;
}
else
{
 mstrMaxValue = value;
}
//记录修改过的字段
 AddUpdatedFld(con_MaxValue);
}
}
/// <summary>
/// 是否唯一(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsOnlyOne
{
get
{
return mbolIsOnlyOne;
}
set
{
 mbolIsOnlyOne = value;
//记录修改过的字段
 AddUpdatedFld(con_IsOnlyOne);
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
 AddUpdatedFld(con_TabId);
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
 AddUpdatedFld(con_PrjId);
}
}
/// <summary>
/// 字段ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FldID
{
get
{
return mstrFldID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldID = value;
}
else
{
 mstrFldID = value;
}
//记录修改过的字段
 AddUpdatedFld(con_FldID);
}
}
/// <summary>
/// 是否表外键(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsTabForeignKey
{
get
{
return mbolIsTabForeignKey;
}
set
{
 mbolIsTabForeignKey = value;
//记录修改过的字段
 AddUpdatedFld(con_IsTabForeignKey);
}
}
/// <summary>
/// 主键类型ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrimaryTypeId
{
get
{
return mstrPrimaryTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrimaryTypeId = value;
}
else
{
 mstrPrimaryTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_PrimaryTypeId);
}
}
/// <summary>
/// 外键表ID(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ForeignKeyTabId
{
get
{
return mstrForeignKeyTabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrForeignKeyTabId = value;
}
else
{
 mstrForeignKeyTabId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_ForeignKeyTabId);
}
}
/// <summary>
/// 是否表中可空(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsTabNullable
{
get
{
return mbolIsTabNullable;
}
set
{
 mbolIsTabNullable = value;
//记录修改过的字段
 AddUpdatedFld(con_IsTabNullable);
}
}
/// <summary>
/// 顺序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int SequenceNumber
{
get
{
return mintSequenceNumber;
}
set
{
 mintSequenceNumber = value;
//记录修改过的字段
 AddUpdatedFld(con_SequenceNumber);
}
}
/// <summary>
/// 数据类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataTypeId
{
get
{
return mstrDataTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataTypeId = value;
}
else
{
 mstrDataTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_DataTypeId);
}
}
/// <summary>
/// 表字段ID(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long TabFldId
{
get
{
return mlngTabFldId;
}
set
{
 mlngTabFldId = value;
//记录修改过的字段
 AddUpdatedFld(con_TabFldId);
}
}
/// <summary>
/// 列标题(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ColCaption
{
get
{
return mstrColCaption;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrColCaption = value;
}
else
{
 mstrColCaption = value;
}
//记录修改过的字段
 AddUpdatedFld(con_ColCaption);
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
/// 列序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int ColIndex
{
get
{
return mintColIndex;
}
set
{
 mintColIndex = value;
//记录修改过的字段
 AddUpdatedFld(con_ColIndex);
}
}
/// <summary>
/// 是否需要排序(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsNeedSort
{
get
{
return mbolIsNeedSort;
}
set
{
 mbolIsNeedSort = value;
//记录修改过的字段
 AddUpdatedFld(con_IsNeedSort);
}
}
/// <summary>
/// 是否转换成CheckBox(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsTransToChkBox
{
get
{
return mbolIsTransToChkBox;
}
set
{
 mbolIsTransToChkBox = value;
//记录修改过的字段
 AddUpdatedFld(con_IsTransToChkBox);
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
 AddUpdatedFld(con_IsVisible);
}
}
/// <summary>
/// 用户ID(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserId
{
get
{
return mstrUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserId = value;
}
else
{
 mstrUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_UserId);
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
/// 获取关键字Id(KeyId)
 /// (AutoGCLib.AutoGCPubFuncV6:GenGetKeyId)
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