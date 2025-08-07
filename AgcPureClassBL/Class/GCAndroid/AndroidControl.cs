
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:AndroidControl
 表名:AndroidControl(00050374)
 生成代码版本:2019.10.18.1
 生成日期:2019/10/18 10:46:18
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:AGC
 工程ID:0005
 模块中文名:生成Android
 模块英文名:GCAndroid
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
 /// Android控件(AndroidControl)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class AndroidControl 
{
protected const int mintAttributeCount = 26;
public static string[] AttributeName = new string[] {"AndroidControlId", "AndroidControlName", "CtrlId", "CtlTypeId", "ParentViewControllerID", "Style", "type", "mKey", "Height", "Width", "Runat", "IsHaveChildCtl", "OrderNum", "layout_width", "layout_height", "layout_margin", "layout_marginLeft", "layout_marginTop", "layout_constraintStart_toStartOf", "layout_constraintTop_toBottomOf", "layout_constraintTop_toTopOf", "minHeight", "mTextSize", "layout_constraintLeft_toRightOf", "layout_constraintLeft_toLeftOf", "Tag"};
//以下是属性变量

/// <summary>
/// AndroidControlId(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AndroidControlId
{
get
{
return mstrAndroidControlId;
}
set
{
if (value  ==  "")
{
 mstrAndroidControlId = value;
}
else
{
 mstrAndroidControlId = value;
}
}
}
/// <summary>
/// AndroidControlName(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AndroidControlName
{
get
{
return mstrAndroidControlName;
}
set
{
if (value  ==  "")
{
 mstrAndroidControlName = value;
}
else
{
 mstrAndroidControlName = value;
}
}
}
/// <summary>
/// 控件Id(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
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
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
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
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
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
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
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
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
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
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
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
/// 高度(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
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
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
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
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
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
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
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
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
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
/// <summary>
/// 宽(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string layout_width
{
get
{
return mstrlayout_width;
}
set
{
if (value  ==  "")
{
 mstrlayout_width = value;
}
else
{
 mstrlayout_width = value;
}
}
}
/// <summary>
/// 高度(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string layout_height
{
get
{
return mstrlayout_height;
}
set
{
if (value  ==  "")
{
 mstrlayout_height = value;
}
else
{
 mstrlayout_height = value;
}
}
}
/// <summary>
/// 页边距(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string layout_margin
{
get
{
return mstrlayout_margin;
}
set
{
if (value  ==  "")
{
 mstrlayout_margin = value;
}
else
{
 mstrlayout_margin = value;
}
}
}
/// <summary>
/// 左边空(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public int layout_marginLeft
{
get
{
return mintlayout_marginLeft;
}
set
{
 mintlayout_marginLeft = value;
}
}
/// <summary>
/// 顶空(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public int layout_marginTop
{
get
{
return mintlayout_marginTop;
}
set
{
 mintlayout_marginTop = value;
}
}
/// <summary>
/// 约束开始相对于开始(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string layout_constraintStart_toStartOf
{
get
{
return mstrlayout_constraintStart_toStartOf;
}
set
{
if (value  ==  "")
{
 mstrlayout_constraintStart_toStartOf = value;
}
else
{
 mstrlayout_constraintStart_toStartOf = value;
}
}
}
/// <summary>
/// 约束顶相对于底(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string layout_constraintTop_toBottomOf
{
get
{
return mstrlayout_constraintTop_toBottomOf;
}
set
{
if (value  ==  "")
{
 mstrlayout_constraintTop_toBottomOf = value;
}
else
{
 mstrlayout_constraintTop_toBottomOf = value;
}
}
}
/// <summary>
/// 约束顶相对于顶(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string layout_constraintTop_toTopOf
{
get
{
return mstrlayout_constraintTop_toTopOf;
}
set
{
if (value  ==  "")
{
 mstrlayout_constraintTop_toTopOf = value;
}
else
{
 mstrlayout_constraintTop_toTopOf = value;
}
}
}
/// <summary>
/// 最小高度(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string minHeight
{
get
{
return mstrminHeight;
}
set
{
if (value  ==  "")
{
 mstrminHeight = value;
}
else
{
 mstrminHeight = value;
}
}
}
/// <summary>
/// 文本尺寸(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string mTextSize
{
get
{
return mstrmTextSize;
}
set
{
if (value  ==  "")
{
 mstrmTextSize = value;
}
else
{
 mstrmTextSize = value;
}
}
}
/// <summary>
/// 约束左相对于右(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string layout_constraintLeft_toRightOf
{
get
{
return mstrlayout_constraintLeft_toRightOf;
}
set
{
if (value  ==  "")
{
 mstrlayout_constraintLeft_toRightOf = value;
}
else
{
 mstrlayout_constraintLeft_toRightOf = value;
}
}
}
/// <summary>
/// 约束左相对于左(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string layout_constraintLeft_toLeftOf
{
get
{
return mstrlayout_constraintLeft_toLeftOf;
}
set
{
if (value  ==  "")
{
 mstrlayout_constraintLeft_toLeftOf = value;
}
else
{
 mstrlayout_constraintLeft_toLeftOf = value;
}
}
}
/// <summary>
/// Tag(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string Tag
{
get
{
return mstrTag;
}
set
{
if (value  ==  "")
{
 mstrTag = value;
}
else
{
 mstrTag = value;
}
}
}

public static int AttributeCount
{
get
{
return mintAttributeCount;
}
}
/// <summary>
/// 类索引器(Indexer)函数,字符串参数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClsIndexer)
/// </summary>
public object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  con_AndroidControlId)
{
return mstrAndroidControlId;
}
else if (strAttributeName  ==  con_AndroidControlName)
{
return mstrAndroidControlName;
}
else if (strAttributeName  ==  con_CtrlId)
{
return mstrCtrlId;
}
else if (strAttributeName  ==  con_CtlTypeId)
{
return mstrCtlTypeId;
}
else if (strAttributeName  ==  con_ParentViewControllerID)
{
return mstrParentViewControllerID;
}
else if (strAttributeName  ==  con_Style)
{
return mstrStyle;
}
else if (strAttributeName  ==  con_type)
{
return mstrtype;
}
else if (strAttributeName  ==  con_mKey)
{
return mstrmKey;
}
else if (strAttributeName  ==  con_Height)
{
return mintHeight;
}
else if (strAttributeName  ==  con_Width)
{
return mintWidth;
}
else if (strAttributeName  ==  con_Runat)
{
return mstrRunat;
}
else if (strAttributeName  ==  con_IsHaveChildCtl)
{
return mbolIsHaveChildCtl;
}
else if (strAttributeName  ==  con_OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  con_layout_width)
{
return mstrlayout_width;
}
else if (strAttributeName  ==  con_layout_height)
{
return mstrlayout_height;
}
else if (strAttributeName  ==  con_layout_margin)
{
return mstrlayout_margin;
}
else if (strAttributeName  ==  con_layout_marginLeft)
{
return mintlayout_marginLeft;
}
else if (strAttributeName  ==  con_layout_marginTop)
{
return mintlayout_marginTop;
}
else if (strAttributeName  ==  con_layout_constraintStart_toStartOf)
{
return mstrlayout_constraintStart_toStartOf;
}
else if (strAttributeName  ==  con_layout_constraintTop_toBottomOf)
{
return mstrlayout_constraintTop_toBottomOf;
}
else if (strAttributeName  ==  con_layout_constraintTop_toTopOf)
{
return mstrlayout_constraintTop_toTopOf;
}
else if (strAttributeName  ==  con_minHeight)
{
return mstrminHeight;
}
else if (strAttributeName  ==  con_mTextSize)
{
return mstrmTextSize;
}
else if (strAttributeName  ==  con_layout_constraintLeft_toRightOf)
{
return mstrlayout_constraintLeft_toRightOf;
}
else if (strAttributeName  ==  con_layout_constraintLeft_toLeftOf)
{
return mstrlayout_constraintLeft_toLeftOf;
}
else if (strAttributeName  ==  con_Tag)
{
return mstrTag;
}
return null;
}
set
{
if (strAttributeName  ==  con_AndroidControlId)
{
mstrAndroidControlId = value.ToString();
}
else if (strAttributeName  ==  con_AndroidControlName)
{
mstrAndroidControlName = value.ToString();
}
else if (strAttributeName  ==  con_CtrlId)
{
mstrCtrlId = value.ToString();
}
else if (strAttributeName  ==  con_CtlTypeId)
{
mstrCtlTypeId = value.ToString();
}
else if (strAttributeName  ==  con_ParentViewControllerID)
{
mstrParentViewControllerID = value.ToString();
}
else if (strAttributeName  ==  con_Style)
{
mstrStyle = value.ToString();
}
else if (strAttributeName  ==  con_type)
{
mstrtype = value.ToString();
}
else if (strAttributeName  ==  con_mKey)
{
mstrmKey = value.ToString();
}
else if (strAttributeName  ==  con_Height)
{
mintHeight = clsEntityBase2.TransNullToInt_S(value.ToString());
}
else if (strAttributeName  ==  con_Width)
{
mintWidth = clsEntityBase2.TransNullToInt_S(value.ToString());
}
else if (strAttributeName  ==  con_Runat)
{
mstrRunat = value.ToString();
}
else if (strAttributeName  ==  con_IsHaveChildCtl)
{
mbolIsHaveChildCtl = clsEntityBase2.TransNullToBool_S(value.ToString());
}
else if (strAttributeName  ==  con_OrderNum)
{
mintOrderNum = clsEntityBase2.TransNullToInt_S(value.ToString());
}
else if (strAttributeName  ==  con_layout_width)
{
mstrlayout_width = value.ToString();
}
else if (strAttributeName  ==  con_layout_height)
{
mstrlayout_height = value.ToString();
}
else if (strAttributeName  ==  con_layout_margin)
{
mstrlayout_margin = value.ToString();
}
else if (strAttributeName  ==  con_layout_marginLeft)
{
mintlayout_marginLeft = clsEntityBase2.TransNullToInt_S(value.ToString());
}
else if (strAttributeName  ==  con_layout_marginTop)
{
mintlayout_marginTop = clsEntityBase2.TransNullToInt_S(value.ToString());
}
else if (strAttributeName  ==  con_layout_constraintStart_toStartOf)
{
mstrlayout_constraintStart_toStartOf = value.ToString();
}
else if (strAttributeName  ==  con_layout_constraintTop_toBottomOf)
{
mstrlayout_constraintTop_toBottomOf = value.ToString();
}
else if (strAttributeName  ==  con_layout_constraintTop_toTopOf)
{
mstrlayout_constraintTop_toTopOf = value.ToString();
}
else if (strAttributeName  ==  con_minHeight)
{
mstrminHeight = value.ToString();
}
else if (strAttributeName  ==  con_mTextSize)
{
mstrmTextSize = value.ToString();
}
else if (strAttributeName  ==  con_layout_constraintLeft_toRightOf)
{
mstrlayout_constraintLeft_toRightOf = value.ToString();
}
else if (strAttributeName  ==  con_layout_constraintLeft_toLeftOf)
{
mstrlayout_constraintLeft_toLeftOf = value.ToString();
}
else if (strAttributeName  ==  con_Tag)
{
mstrTag = value.ToString();
}
}
}
/// <summary>
/// 类索引器(Indexer)函数, 整型(INT)序号参数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClsIndexer)
/// </summary>
public object this[int intIndex]
{
get
{
if (con_AndroidControlId  ==  AttributeName[intIndex])
{
return mstrAndroidControlId;
}
else if (con_AndroidControlName  ==  AttributeName[intIndex])
{
return mstrAndroidControlName;
}
else if (con_CtrlId  ==  AttributeName[intIndex])
{
return mstrCtrlId;
}
else if (con_CtlTypeId  ==  AttributeName[intIndex])
{
return mstrCtlTypeId;
}
else if (con_ParentViewControllerID  ==  AttributeName[intIndex])
{
return mstrParentViewControllerID;
}
else if (con_Style  ==  AttributeName[intIndex])
{
return mstrStyle;
}
else if (con_type  ==  AttributeName[intIndex])
{
return mstrtype;
}
else if (con_mKey  ==  AttributeName[intIndex])
{
return mstrmKey;
}
else if (con_Height  ==  AttributeName[intIndex])
{
return mintHeight;
}
else if (con_Width  ==  AttributeName[intIndex])
{
return mintWidth;
}
else if (con_Runat  ==  AttributeName[intIndex])
{
return mstrRunat;
}
else if (con_IsHaveChildCtl  ==  AttributeName[intIndex])
{
return mbolIsHaveChildCtl;
}
else if (con_OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (con_layout_width  ==  AttributeName[intIndex])
{
return mstrlayout_width;
}
else if (con_layout_height  ==  AttributeName[intIndex])
{
return mstrlayout_height;
}
else if (con_layout_margin  ==  AttributeName[intIndex])
{
return mstrlayout_margin;
}
else if (con_layout_marginLeft  ==  AttributeName[intIndex])
{
return mintlayout_marginLeft;
}
else if (con_layout_marginTop  ==  AttributeName[intIndex])
{
return mintlayout_marginTop;
}
else if (con_layout_constraintStart_toStartOf  ==  AttributeName[intIndex])
{
return mstrlayout_constraintStart_toStartOf;
}
else if (con_layout_constraintTop_toBottomOf  ==  AttributeName[intIndex])
{
return mstrlayout_constraintTop_toBottomOf;
}
else if (con_layout_constraintTop_toTopOf  ==  AttributeName[intIndex])
{
return mstrlayout_constraintTop_toTopOf;
}
else if (con_minHeight  ==  AttributeName[intIndex])
{
return mstrminHeight;
}
else if (con_mTextSize  ==  AttributeName[intIndex])
{
return mstrmTextSize;
}
else if (con_layout_constraintLeft_toRightOf  ==  AttributeName[intIndex])
{
return mstrlayout_constraintLeft_toRightOf;
}
else if (con_layout_constraintLeft_toLeftOf  ==  AttributeName[intIndex])
{
return mstrlayout_constraintLeft_toLeftOf;
}
else if (con_Tag  ==  AttributeName[intIndex])
{
return mstrTag;
}
return null;
}
set
{
if (con_AndroidControlId  ==  AttributeName[intIndex])
{
mstrAndroidControlId = value.ToString();
}
else if (con_AndroidControlName  ==  AttributeName[intIndex])
{
mstrAndroidControlName = value.ToString();
}
else if (con_CtrlId  ==  AttributeName[intIndex])
{
mstrCtrlId = value.ToString();
}
else if (con_CtlTypeId  ==  AttributeName[intIndex])
{
mstrCtlTypeId = value.ToString();
}
else if (con_ParentViewControllerID  ==  AttributeName[intIndex])
{
mstrParentViewControllerID = value.ToString();
}
else if (con_Style  ==  AttributeName[intIndex])
{
mstrStyle = value.ToString();
}
else if (con_type  ==  AttributeName[intIndex])
{
mstrtype = value.ToString();
}
else if (con_mKey  ==  AttributeName[intIndex])
{
mstrmKey = value.ToString();
}
else if (con_Height  ==  AttributeName[intIndex])
{
mintHeight = clsEntityBase2.TransNullToInt_S(value.ToString());
}
else if (con_Width  ==  AttributeName[intIndex])
{
mintWidth = clsEntityBase2.TransNullToInt_S(value.ToString());
}
else if (con_Runat  ==  AttributeName[intIndex])
{
mstrRunat = value.ToString();
}
else if (con_IsHaveChildCtl  ==  AttributeName[intIndex])
{
mbolIsHaveChildCtl = clsEntityBase2.TransNullToBool_S(value.ToString());
}
else if (con_OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = clsEntityBase2.TransNullToInt_S(value.ToString());
}
else if (con_layout_width  ==  AttributeName[intIndex])
{
mstrlayout_width = value.ToString();
}
else if (con_layout_height  ==  AttributeName[intIndex])
{
mstrlayout_height = value.ToString();
}
else if (con_layout_margin  ==  AttributeName[intIndex])
{
mstrlayout_margin = value.ToString();
}
else if (con_layout_marginLeft  ==  AttributeName[intIndex])
{
mintlayout_marginLeft = clsEntityBase2.TransNullToInt_S(value.ToString());
}
else if (con_layout_marginTop  ==  AttributeName[intIndex])
{
mintlayout_marginTop = clsEntityBase2.TransNullToInt_S(value.ToString());
}
else if (con_layout_constraintStart_toStartOf  ==  AttributeName[intIndex])
{
mstrlayout_constraintStart_toStartOf = value.ToString();
}
else if (con_layout_constraintTop_toBottomOf  ==  AttributeName[intIndex])
{
mstrlayout_constraintTop_toBottomOf = value.ToString();
}
else if (con_layout_constraintTop_toTopOf  ==  AttributeName[intIndex])
{
mstrlayout_constraintTop_toTopOf = value.ToString();
}
else if (con_minHeight  ==  AttributeName[intIndex])
{
mstrminHeight = value.ToString();
}
else if (con_mTextSize  ==  AttributeName[intIndex])
{
mstrmTextSize = value.ToString();
}
else if (con_layout_constraintLeft_toRightOf  ==  AttributeName[intIndex])
{
mstrlayout_constraintLeft_toRightOf = value.ToString();
}
else if (con_layout_constraintLeft_toLeftOf  ==  AttributeName[intIndex])
{
mstrlayout_constraintLeft_toLeftOf = value.ToString();
}
else if (con_Tag  ==  AttributeName[intIndex])
{
mstrTag = value.ToString();
}
}
}

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public AndroidControl()
 {
 }


 /// <summary>
 /// 常量:"AndroidControlId"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AndroidControlId = "AndroidControlId";    //AndroidControlId

 /// <summary>
 /// 常量:"AndroidControlName"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AndroidControlName = "AndroidControlName";    //AndroidControlName

 /// <summary>
 /// 常量:"CtrlId"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_CtrlId = "CtrlId";    //控件Id

 /// <summary>
 /// 常量:"CtlTypeId"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_CtlTypeId = "CtlTypeId";    //控件类型号

 /// <summary>
 /// 常量:"ParentViewControllerID"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ParentViewControllerID = "ParentViewControllerID";    //父视图控制Id

 /// <summary>
 /// 常量:"Style"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Style = "Style";    //类型

 /// <summary>
 /// 常量:"type"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_type = "type";    //类型

 /// <summary>
 /// 常量:"mKey"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_mKey = "mKey";    //关键字

 /// <summary>
 /// 常量:"Height"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Height = "Height";    //高度

 /// <summary>
 /// 常量:"Width"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Width = "Width";    //宽

 /// <summary>
 /// 常量:"Runat"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Runat = "Runat";    //运行在

 /// <summary>
 /// 常量:"IsHaveChildCtl"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsHaveChildCtl = "IsHaveChildCtl";    //是否有子控件

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"layout_width"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_layout_width = "layout_width";    //宽

 /// <summary>
 /// 常量:"layout_height"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_layout_height = "layout_height";    //高度

 /// <summary>
 /// 常量:"layout_margin"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_layout_margin = "layout_margin";    //页边距

 /// <summary>
 /// 常量:"layout_marginLeft"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_layout_marginLeft = "layout_marginLeft";    //左边空

 /// <summary>
 /// 常量:"layout_marginTop"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_layout_marginTop = "layout_marginTop";    //顶空

 /// <summary>
 /// 常量:"layout_constraintStart_toStartOf"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_layout_constraintStart_toStartOf = "layout_constraintStart_toStartOf";    //约束开始相对于开始

 /// <summary>
 /// 常量:"layout_constraintTop_toBottomOf"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_layout_constraintTop_toBottomOf = "layout_constraintTop_toBottomOf";    //约束顶相对于底

 /// <summary>
 /// 常量:"layout_constraintTop_toTopOf"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_layout_constraintTop_toTopOf = "layout_constraintTop_toTopOf";    //约束顶相对于顶

 /// <summary>
 /// 常量:"minHeight"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_minHeight = "minHeight";    //最小高度

 /// <summary>
 /// 常量:"mTextSize"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_mTextSize = "mTextSize";    //文本尺寸

 /// <summary>
 /// 常量:"layout_constraintLeft_toRightOf"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_layout_constraintLeft_toRightOf = "layout_constraintLeft_toRightOf";    //约束左相对于右

 /// <summary>
 /// 常量:"layout_constraintLeft_toLeftOf"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_layout_constraintLeft_toLeftOf = "layout_constraintLeft_toLeftOf";    //约束左相对于左

 /// <summary>
 /// 常量:"Tag"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Tag = "Tag";    //Tag

protected string mstrAndroidControlId;    //AndroidControlId
protected string mstrAndroidControlName;    //AndroidControlName
protected string mstrCtrlId;    //控件Id
protected string mstrCtlTypeId;    //控件类型号
protected string mstrParentViewControllerID;    //父视图控制Id
protected string mstrStyle;    //类型
protected string mstrtype;    //类型
protected string mstrmKey;    //关键字
protected int mintHeight;    //高度
protected int mintWidth;    //宽
protected string mstrRunat;    //运行在
protected bool mbolIsHaveChildCtl;    //是否有子控件
protected int mintOrderNum;    //序号
protected string mstrlayout_width;    //宽
protected string mstrlayout_height;    //高度
protected string mstrlayout_margin;    //页边距
protected int mintlayout_marginLeft;    //左边空
protected int mintlayout_marginTop;    //顶空
protected string mstrlayout_constraintStart_toStartOf;    //约束开始相对于开始
protected string mstrlayout_constraintTop_toBottomOf;    //约束顶相对于底
protected string mstrlayout_constraintTop_toTopOf;    //约束顶相对于顶
protected string mstrminHeight;    //最小高度
protected string mstrmTextSize;    //文本尺寸
protected string mstrlayout_constraintLeft_toRightOf;    //约束左相对于右
protected string mstrlayout_constraintLeft_toLeftOf;    //约束左相对于左
protected string mstrTag;    //Tag
}
}