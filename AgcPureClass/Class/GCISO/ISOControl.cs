
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ISOControl
 表名:ISOControl(00050354)
 生成代码版本:2021.07.29.1
 生成日期:2021/07/29 17:41:14
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:AGC
 工程ID:0005
 模块中文名:生成ISO代码
 模块英文名:GCISO
 框架-层名:纯粹类(PureClass)
 编程语言:CSharp
 注意:1、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
using System;
using System.Text; 
using System.Collections; 
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System.Runtime.Serialization;

namespace AGC.PureClass
{
 /// <summary>
 /// ISO控件(ISOControl)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ISOControl 
{
//protected const int mintAttributeCount = 15;
//public static string[] AttributeName = new string[] {"IsoControlId", "IsoControlName", "CtrlId", "CtlTypeId", "ParentViewControllerID", "Style", "type", "mKey", "x", "y", "Height", "Width", "Runat", "IsHaveChildCtl", "OrderNum"};
//以下是属性变量

protected string mstrIsoControlId;    //Iso控件Id
protected string mstrIsoControlName;    //Iso控件名
protected string mstrCtrlId;    //控件Id
protected string mstrCtlTypeId;    //控件类型号
protected string mstrParentViewControllerID;    //父视图控制Id
protected string mstrStyle;    //类型
protected string mstrtype;    //类型
protected string mstrmKey;    //关键字
protected int mintx;    //x
protected int minty;    //y
protected int mintHeight;    //高度
protected int mintWidth;    //宽
protected string mstrRunat;    //运行在
protected bool mbolIsHaveChildCtl;    //是否有子控件
protected int mintOrderNum;    //序号


 /// <summary>
 /// 常量:"IsoControlId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsoControlId = "IsoControlId";    //Iso控件Id

 /// <summary>
 /// 常量:"IsoControlName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsoControlName = "IsoControlName";    //Iso控件名

 /// <summary>
 /// 常量:"CtrlId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_CtrlId = "CtrlId";    //控件Id

 /// <summary>
 /// 常量:"CtlTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_CtlTypeId = "CtlTypeId";    //控件类型号

 /// <summary>
 /// 常量:"ParentViewControllerID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ParentViewControllerID = "ParentViewControllerID";    //父视图控制Id

 /// <summary>
 /// 常量:"Style"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Style = "Style";    //类型

 /// <summary>
 /// 常量:"type"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_type = "type";    //类型

 /// <summary>
 /// 常量:"mKey"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_mKey = "mKey";    //关键字

 /// <summary>
 /// 常量:"x"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_x = "x";    //x

 /// <summary>
 /// 常量:"y"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_y = "y";    //y

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
 /// 常量:"Runat"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Runat = "Runat";    //运行在

 /// <summary>
 /// 常量:"IsHaveChildCtl"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsHaveChildCtl = "IsHaveChildCtl";    //是否有子控件

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_OrderNum = "OrderNum";    //序号

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ISOControl()
 {
 }

//public static int AttributeCount
//{
//get
//{
//return mintAttributeCount;
//}
//}
///// <summary>
///// 类索引器(Indexer)函数,字符串参数
// /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClsIndexer)
///// </summary>
//public object this[string strAttributeName]
//{
//get
//{
//if (strAttributeName  ==  con_IsoControlId)
//{
//return mstrIsoControlId;
//}
//else if (strAttributeName  ==  con_IsoControlName)
//{
//return mstrIsoControlName;
//}
//else if (strAttributeName  ==  con_CtrlId)
//{
//return mstrCtrlId;
//}
//else if (strAttributeName  ==  con_CtlTypeId)
//{
//return mstrCtlTypeId;
//}
//else if (strAttributeName  ==  con_ParentViewControllerID)
//{
//return mstrParentViewControllerID;
//}
//else if (strAttributeName  ==  con_Style)
//{
//return mstrStyle;
//}
//else if (strAttributeName  ==  con_type)
//{
//return mstrtype;
//}
//else if (strAttributeName  ==  con_mKey)
//{
//return mstrmKey;
//}
//else if (strAttributeName  ==  con_x)
//{
//return mintx;
//}
//else if (strAttributeName  ==  con_y)
//{
//return minty;
//}
//else if (strAttributeName  ==  con_Height)
//{
//return mintHeight;
//}
//else if (strAttributeName  ==  con_Width)
//{
//return mintWidth;
//}
//else if (strAttributeName  ==  con_Runat)
//{
//return mstrRunat;
//}
//else if (strAttributeName  ==  con_IsHaveChildCtl)
//{
//return mbolIsHaveChildCtl;
//}
//else if (strAttributeName  ==  con_OrderNum)
//{
//return mintOrderNum;
//}
//return null;
//}
//set
//{
//if (strAttributeName  ==  con_IsoControlId)
//{
//mstrIsoControlId = value.ToString();
//}
//else if (strAttributeName  ==  con_IsoControlName)
//{
//mstrIsoControlName = value.ToString();
//}
//else if (strAttributeName  ==  con_CtrlId)
//{
//mstrCtrlId = value.ToString();
//}
//else if (strAttributeName  ==  con_CtlTypeId)
//{
//mstrCtlTypeId = value.ToString();
//}
//else if (strAttributeName  ==  con_ParentViewControllerID)
//{
//mstrParentViewControllerID = value.ToString();
//}
//else if (strAttributeName  ==  con_Style)
//{
//mstrStyle = value.ToString();
//}
//else if (strAttributeName  ==  con_type)
//{
//mstrtype = value.ToString();
//}
//else if (strAttributeName  ==  con_mKey)
//{
//mstrmKey = value.ToString();
//}
//else if (strAttributeName  ==  con_x)
//{
//mintx = clsEntityBase2.TransNullToInt_S(value.ToString());
//}
//else if (strAttributeName  ==  con_y)
//{
//minty = clsEntityBase2.TransNullToInt_S(value.ToString());
//}
//else if (strAttributeName  ==  con_Height)
//{
//mintHeight = clsEntityBase2.TransNullToInt_S(value.ToString());
//}
//else if (strAttributeName  ==  con_Width)
//{
//mintWidth = clsEntityBase2.TransNullToInt_S(value.ToString());
//}
//else if (strAttributeName  ==  con_Runat)
//{
//mstrRunat = value.ToString();
//}
//else if (strAttributeName  ==  con_IsHaveChildCtl)
//{
//mbolIsHaveChildCtl = clsEntityBase2.TransNullToBool_S(value.ToString());
//}
//else if (strAttributeName  ==  con_OrderNum)
//{
//mintOrderNum = clsEntityBase2.TransNullToInt_S(value.ToString());
//}
//}
//}
/// <summary>
/// 类索引器(Indexer)函数, 整型(INT)序号参数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClsIndexer)
/// </summary>
//public object this[int intIndex]
//{
//get
//{
//if (con_IsoControlId  ==  AttributeName[intIndex])
//{
//return mstrIsoControlId;
//}
//else if (con_IsoControlName  ==  AttributeName[intIndex])
//{
//return mstrIsoControlName;
//}
//else if (con_CtrlId  ==  AttributeName[intIndex])
//{
//return mstrCtrlId;
//}
//else if (con_CtlTypeId  ==  AttributeName[intIndex])
//{
//return mstrCtlTypeId;
//}
//else if (con_ParentViewControllerID  ==  AttributeName[intIndex])
//{
//return mstrParentViewControllerID;
//}
//else if (con_Style  ==  AttributeName[intIndex])
//{
//return mstrStyle;
//}
//else if (con_type  ==  AttributeName[intIndex])
//{
//return mstrtype;
//}
//else if (con_mKey  ==  AttributeName[intIndex])
//{
//return mstrmKey;
//}
//else if (con_x  ==  AttributeName[intIndex])
//{
//return mintx;
//}
//else if (con_y  ==  AttributeName[intIndex])
//{
//return minty;
//}
//else if (con_Height  ==  AttributeName[intIndex])
//{
//return mintHeight;
//}
//else if (con_Width  ==  AttributeName[intIndex])
//{
//return mintWidth;
//}
//else if (con_Runat  ==  AttributeName[intIndex])
//{
//return mstrRunat;
//}
//else if (con_IsHaveChildCtl  ==  AttributeName[intIndex])
//{
//return mbolIsHaveChildCtl;
//}
//else if (con_OrderNum  ==  AttributeName[intIndex])
//{
//return mintOrderNum;
//}
//return null;
//}
//set
//{
//if (con_IsoControlId  ==  AttributeName[intIndex])
//{
//mstrIsoControlId = value.ToString();
//}
//else if (con_IsoControlName  ==  AttributeName[intIndex])
//{
//mstrIsoControlName = value.ToString();
//}
//else if (con_CtrlId  ==  AttributeName[intIndex])
//{
//mstrCtrlId = value.ToString();
//}
//else if (con_CtlTypeId  ==  AttributeName[intIndex])
//{
//mstrCtlTypeId = value.ToString();
//}
//else if (con_ParentViewControllerID  ==  AttributeName[intIndex])
//{
//mstrParentViewControllerID = value.ToString();
//}
//else if (con_Style  ==  AttributeName[intIndex])
//{
//mstrStyle = value.ToString();
//}
//else if (con_type  ==  AttributeName[intIndex])
//{
//mstrtype = value.ToString();
//}
//else if (con_mKey  ==  AttributeName[intIndex])
//{
//mstrmKey = value.ToString();
//}
//else if (con_x  ==  AttributeName[intIndex])
//{
//mintx = clsEntityBase2.TransNullToInt_S(value.ToString());
//}
//else if (con_y  ==  AttributeName[intIndex])
//{
//minty = clsEntityBase2.TransNullToInt_S(value.ToString());
//}
//else if (con_Height  ==  AttributeName[intIndex])
//{
//mintHeight = clsEntityBase2.TransNullToInt_S(value.ToString());
//}
//else if (con_Width  ==  AttributeName[intIndex])
//{
//mintWidth = clsEntityBase2.TransNullToInt_S(value.ToString());
//}
//else if (con_Runat  ==  AttributeName[intIndex])
//{
//mstrRunat = value.ToString();
//}
//else if (con_IsHaveChildCtl  ==  AttributeName[intIndex])
//{
//mbolIsHaveChildCtl = clsEntityBase2.TransNullToBool_S(value.ToString());
//}
//else if (con_OrderNum  ==  AttributeName[intIndex])
//{
//mintOrderNum = clsEntityBase2.TransNullToInt_S(value.ToString());
//}
//}
//}

/// <summary>
/// Iso控件Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string IsoControlId
{
get
{
return mstrIsoControlId;
}
set
{
if (value  ==  "")
{
 mstrIsoControlId = value;
}
else
{
 mstrIsoControlId = value;
}
}
}
/// <summary>
/// Iso控件名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string IsoControlName
{
get
{
return mstrIsoControlName;
}
set
{
if (value  ==  "")
{
 mstrIsoControlName = value;
}
else
{
 mstrIsoControlName = value;
}
}
}
/// <summary>
/// 控件Id(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string CtrlId
{
get
{
return mstrCtrlId;
}
set
{
if (value  ==  "")
{
 mstrCtrlId = value;
}
else
{
 mstrCtrlId = value;
}
}
}
/// <summary>
/// 控件类型号(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
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
 mstrCtlTypeId = value;
}
else
{
 mstrCtlTypeId = value;
}
}
}
/// <summary>
/// 父视图控制Id(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string ParentViewControllerID
{
get
{
return mstrParentViewControllerID;
}
set
{
if (value  ==  "")
{
 mstrParentViewControllerID = value;
}
else
{
 mstrParentViewControllerID = value;
}
}
}
/// <summary>
/// 类型(说明:;字段类型:varchar;字段长度:800;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string Style
{
get
{
return mstrStyle;
}
set
{
if (value  ==  "")
{
 mstrStyle = value;
}
else
{
 mstrStyle = value;
}
}
}
/// <summary>
/// 类型(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string type
{
get
{
return mstrtype;
}
set
{
if (value  ==  "")
{
 mstrtype = value;
}
else
{
 mstrtype = value;
}
}
}
/// <summary>
/// 关键字(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string mKey
{
get
{
return mstrmKey;
}
set
{
if (value  ==  "")
{
 mstrmKey = value;
}
else
{
 mstrmKey = value;
}
}
}
/// <summary>
/// x(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public int x
{
get
{
return mintx;
}
set
{
 mintx = value;
}
}
/// <summary>
/// y(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public int y
{
get
{
return minty;
}
set
{
 minty = value;
}
}
/// <summary>
/// 高度(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
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
}
}
/// <summary>
/// 宽(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
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
}
}
/// <summary>
/// 运行在(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string Runat
{
get
{
return mstrRunat;
}
set
{
if (value  ==  "")
{
 mstrRunat = value;
}
else
{
 mstrRunat = value;
}
}
}
/// <summary>
/// 是否有子控件(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public bool IsHaveChildCtl
{
get
{
return mbolIsHaveChildCtl;
}
set
{
 mbolIsHaveChildCtl = value;
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
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
}
}
}
}