
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsButtonTabEN
 表名:ButtonTab(00050427)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:33:50
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
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
 /// 表ButtonTab的关键字(ButtonId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ButtonId_ButtonTab
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strButtonId">表关键字</param>
public K_ButtonId_ButtonTab(string strButtonId)
{
if (IsValid(strButtonId)) Value = strButtonId;
else
{
Value = null;
}
}
private static bool IsValid(string strButtonId)
{
if (string.IsNullOrEmpty(strButtonId) == true) return false;
if (strButtonId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ButtonId_ButtonTab]类型的对象</returns>
public static implicit operator K_ButtonId_ButtonTab(string value)
{
return new K_ButtonId_ButtonTab(value);
}
}
 /// <summary>
 /// 按钮(ButtonTab)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsButtonTabEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ButtonTab"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ButtonId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 13;
public static string[] _AttributeName = new string[] {"ButtonId", "ButtonName", "Text", "CommandName", "Height", "Width", "CssClass", "ImageUrl", "InUse", "OrderNum", "UpdUser", "UpdDate", "Memo"};

protected string mstrButtonId;    //按钮Id
protected string mstrButtonName;    //按钮名称
protected string mstrText;    //文本
protected string mstrCommandName;    //命令名
protected int? mintHeight;    //高度
protected int? mintWidth;    //宽
protected string mstrCssClass;    //样式表
protected string mstrImageUrl;    //图片资源
protected bool mbolInUse;    //是否在用
protected int? mintOrderNum;    //序号
protected string mstrUpdUser;    //修改者
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsButtonTabEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ButtonId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strButtonId">关键字:按钮Id</param>
public clsButtonTabEN(string strButtonId)
 {
strButtonId = strButtonId.Replace("'", "''");
if (strButtonId.Length > 2)
{
throw new Exception("在表:ButtonTab中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strButtonId)  ==  true)
{
throw new Exception("在表:ButtonTab中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strButtonId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrButtonId = strButtonId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ButtonId");
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
if (strAttributeName  ==  conButtonTab.ButtonId)
{
return mstrButtonId;
}
else if (strAttributeName  ==  conButtonTab.ButtonName)
{
return mstrButtonName;
}
else if (strAttributeName  ==  conButtonTab.Text)
{
return mstrText;
}
else if (strAttributeName  ==  conButtonTab.CommandName)
{
return mstrCommandName;
}
else if (strAttributeName  ==  conButtonTab.Height)
{
return mintHeight;
}
else if (strAttributeName  ==  conButtonTab.Width)
{
return mintWidth;
}
else if (strAttributeName  ==  conButtonTab.CssClass)
{
return mstrCssClass;
}
else if (strAttributeName  ==  conButtonTab.ImageUrl)
{
return mstrImageUrl;
}
else if (strAttributeName  ==  conButtonTab.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  conButtonTab.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conButtonTab.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conButtonTab.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conButtonTab.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conButtonTab.ButtonId)
{
mstrButtonId = value.ToString();
 AddUpdatedFld(conButtonTab.ButtonId);
}
else if (strAttributeName  ==  conButtonTab.ButtonName)
{
mstrButtonName = value.ToString();
 AddUpdatedFld(conButtonTab.ButtonName);
}
else if (strAttributeName  ==  conButtonTab.Text)
{
mstrText = value.ToString();
 AddUpdatedFld(conButtonTab.Text);
}
else if (strAttributeName  ==  conButtonTab.CommandName)
{
mstrCommandName = value.ToString();
 AddUpdatedFld(conButtonTab.CommandName);
}
else if (strAttributeName  ==  conButtonTab.Height)
{
mintHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(conButtonTab.Height);
}
else if (strAttributeName  ==  conButtonTab.Width)
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(conButtonTab.Width);
}
else if (strAttributeName  ==  conButtonTab.CssClass)
{
mstrCssClass = value.ToString();
 AddUpdatedFld(conButtonTab.CssClass);
}
else if (strAttributeName  ==  conButtonTab.ImageUrl)
{
mstrImageUrl = value.ToString();
 AddUpdatedFld(conButtonTab.ImageUrl);
}
else if (strAttributeName  ==  conButtonTab.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conButtonTab.InUse);
}
else if (strAttributeName  ==  conButtonTab.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conButtonTab.OrderNum);
}
else if (strAttributeName  ==  conButtonTab.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conButtonTab.UpdUser);
}
else if (strAttributeName  ==  conButtonTab.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conButtonTab.UpdDate);
}
else if (strAttributeName  ==  conButtonTab.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conButtonTab.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conButtonTab.ButtonId  ==  _AttributeName[intIndex])
{
return mstrButtonId;
}
else if (conButtonTab.ButtonName  ==  _AttributeName[intIndex])
{
return mstrButtonName;
}
else if (conButtonTab.Text  ==  _AttributeName[intIndex])
{
return mstrText;
}
else if (conButtonTab.CommandName  ==  _AttributeName[intIndex])
{
return mstrCommandName;
}
else if (conButtonTab.Height  ==  _AttributeName[intIndex])
{
return mintHeight;
}
else if (conButtonTab.Width  ==  _AttributeName[intIndex])
{
return mintWidth;
}
else if (conButtonTab.CssClass  ==  _AttributeName[intIndex])
{
return mstrCssClass;
}
else if (conButtonTab.ImageUrl  ==  _AttributeName[intIndex])
{
return mstrImageUrl;
}
else if (conButtonTab.InUse  ==  _AttributeName[intIndex])
{
return mbolInUse;
}
else if (conButtonTab.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conButtonTab.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conButtonTab.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conButtonTab.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conButtonTab.ButtonId  ==  _AttributeName[intIndex])
{
mstrButtonId = value.ToString();
 AddUpdatedFld(conButtonTab.ButtonId);
}
else if (conButtonTab.ButtonName  ==  _AttributeName[intIndex])
{
mstrButtonName = value.ToString();
 AddUpdatedFld(conButtonTab.ButtonName);
}
else if (conButtonTab.Text  ==  _AttributeName[intIndex])
{
mstrText = value.ToString();
 AddUpdatedFld(conButtonTab.Text);
}
else if (conButtonTab.CommandName  ==  _AttributeName[intIndex])
{
mstrCommandName = value.ToString();
 AddUpdatedFld(conButtonTab.CommandName);
}
else if (conButtonTab.Height  ==  _AttributeName[intIndex])
{
mintHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(conButtonTab.Height);
}
else if (conButtonTab.Width  ==  _AttributeName[intIndex])
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(conButtonTab.Width);
}
else if (conButtonTab.CssClass  ==  _AttributeName[intIndex])
{
mstrCssClass = value.ToString();
 AddUpdatedFld(conButtonTab.CssClass);
}
else if (conButtonTab.ImageUrl  ==  _AttributeName[intIndex])
{
mstrImageUrl = value.ToString();
 AddUpdatedFld(conButtonTab.ImageUrl);
}
else if (conButtonTab.InUse  ==  _AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conButtonTab.InUse);
}
else if (conButtonTab.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conButtonTab.OrderNum);
}
else if (conButtonTab.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conButtonTab.UpdUser);
}
else if (conButtonTab.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conButtonTab.UpdDate);
}
else if (conButtonTab.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conButtonTab.Memo);
}
}
}

/// <summary>
/// 按钮Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ButtonId
{
get
{
return mstrButtonId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrButtonId = value;
}
else
{
 mstrButtonId = value;
}
//记录修改过的字段
 AddUpdatedFld(conButtonTab.ButtonId);
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
 AddUpdatedFld(conButtonTab.ButtonName);
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
 AddUpdatedFld(conButtonTab.Text);
}
}
/// <summary>
/// 命令名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CommandName
{
get
{
return mstrCommandName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCommandName = value;
}
else
{
 mstrCommandName = value;
}
//记录修改过的字段
 AddUpdatedFld(conButtonTab.CommandName);
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
 AddUpdatedFld(conButtonTab.Height);
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
 AddUpdatedFld(conButtonTab.Width);
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
 AddUpdatedFld(conButtonTab.CssClass);
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
 AddUpdatedFld(conButtonTab.ImageUrl);
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
 AddUpdatedFld(conButtonTab.InUse);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(conButtonTab.OrderNum);
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
 AddUpdatedFld(conButtonTab.UpdUser);
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
 AddUpdatedFld(conButtonTab.UpdDate);
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
 AddUpdatedFld(conButtonTab.Memo);
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
  return mstrButtonId;
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
  return mstrButtonName;
 }
 }
}
 /// <summary>
 /// 按钮(ButtonTab)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conButtonTab
{
public const string _CurrTabName = "ButtonTab"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ButtonId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"ButtonId", "ButtonName", "Text", "CommandName", "Height", "Width", "CssClass", "ImageUrl", "InUse", "OrderNum", "UpdUser", "UpdDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"ButtonId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ButtonId = "ButtonId";    //按钮Id

 /// <summary>
 /// 常量:"ButtonName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ButtonName = "ButtonName";    //按钮名称

 /// <summary>
 /// 常量:"Text"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Text = "Text";    //文本

 /// <summary>
 /// 常量:"CommandName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CommandName = "CommandName";    //命令名

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
 /// 常量:"CssClass"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CssClass = "CssClass";    //样式表

 /// <summary>
 /// 常量:"ImageUrl"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ImageUrl = "ImageUrl";    //图片资源

 /// <summary>
 /// 常量:"InUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InUse = "InUse";    //是否在用

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

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