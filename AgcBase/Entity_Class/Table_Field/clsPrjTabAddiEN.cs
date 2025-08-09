
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjTabAddiEN
 表名:PrjTabAddi(00050635)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 19:59:41
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
 /// 表PrjTabAddi的关键字(TabId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TabId_PrjTabAddi
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strTabId">表关键字</param>
public K_TabId_PrjTabAddi(string strTabId)
{
if (IsValid(strTabId)) Value = strTabId;
else
{
Value = null;
}
}
private static bool IsValid(string strTabId)
{
if (string.IsNullOrEmpty(strTabId) == true) return false;
if (strTabId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_TabId_PrjTabAddi]类型的对象</returns>
public static implicit operator K_TabId_PrjTabAddi(string value)
{
return new K_TabId_PrjTabAddi(value);
}
}
 /// <summary>
 /// 工程表附加信息(PrjTabAddi)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsPrjTabAddiEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "PrjTabAddi"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TabId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 6;
public static string[] _AttributeName = new string[] {"TabId", "ColumnWidth", "NodeHeight", "UpdUser", "UpdDate", "Memo"};

protected string mstrTabId;    //表ID
protected int? mintColumnWidth;    //结点宽
protected int? mintNodeHeight;    //结点高
protected string mstrUpdUser;    //修改者
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsPrjTabAddiEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TabId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strTabId">关键字:表ID</param>
public clsPrjTabAddiEN(string strTabId)
 {
strTabId = strTabId.Replace("'", "''");
if (strTabId.Length > 8)
{
throw new Exception("在表:PrjTabAddi中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTabId)  ==  true)
{
throw new Exception("在表:PrjTabAddi中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTabId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrTabId = strTabId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TabId");
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
if (strAttributeName  ==  conPrjTabAddi.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  conPrjTabAddi.ColumnWidth)
{
return mintColumnWidth;
}
else if (strAttributeName  ==  conPrjTabAddi.NodeHeight)
{
return mintNodeHeight;
}
else if (strAttributeName  ==  conPrjTabAddi.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conPrjTabAddi.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conPrjTabAddi.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conPrjTabAddi.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(conPrjTabAddi.TabId);
}
else if (strAttributeName  ==  conPrjTabAddi.ColumnWidth)
{
mintColumnWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(conPrjTabAddi.ColumnWidth);
}
else if (strAttributeName  ==  conPrjTabAddi.NodeHeight)
{
mintNodeHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(conPrjTabAddi.NodeHeight);
}
else if (strAttributeName  ==  conPrjTabAddi.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conPrjTabAddi.UpdUser);
}
else if (strAttributeName  ==  conPrjTabAddi.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conPrjTabAddi.UpdDate);
}
else if (strAttributeName  ==  conPrjTabAddi.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPrjTabAddi.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conPrjTabAddi.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (conPrjTabAddi.ColumnWidth  ==  _AttributeName[intIndex])
{
return mintColumnWidth;
}
else if (conPrjTabAddi.NodeHeight  ==  _AttributeName[intIndex])
{
return mintNodeHeight;
}
else if (conPrjTabAddi.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conPrjTabAddi.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conPrjTabAddi.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conPrjTabAddi.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(conPrjTabAddi.TabId);
}
else if (conPrjTabAddi.ColumnWidth  ==  _AttributeName[intIndex])
{
mintColumnWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(conPrjTabAddi.ColumnWidth);
}
else if (conPrjTabAddi.NodeHeight  ==  _AttributeName[intIndex])
{
mintNodeHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(conPrjTabAddi.NodeHeight);
}
else if (conPrjTabAddi.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conPrjTabAddi.UpdUser);
}
else if (conPrjTabAddi.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conPrjTabAddi.UpdDate);
}
else if (conPrjTabAddi.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPrjTabAddi.Memo);
}
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
 AddUpdatedFld(conPrjTabAddi.TabId);
}
}
/// <summary>
/// 结点宽(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? ColumnWidth
{
get
{
return mintColumnWidth;
}
set
{
 mintColumnWidth = value;
//记录修改过的字段
 AddUpdatedFld(conPrjTabAddi.ColumnWidth);
}
}
/// <summary>
/// 结点高(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? NodeHeight
{
get
{
return mintNodeHeight;
}
set
{
 mintNodeHeight = value;
//记录修改过的字段
 AddUpdatedFld(conPrjTabAddi.NodeHeight);
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
 AddUpdatedFld(conPrjTabAddi.UpdUser);
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
 AddUpdatedFld(conPrjTabAddi.UpdDate);
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
 AddUpdatedFld(conPrjTabAddi.Memo);
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
  return mstrTabId;
 }
 }
}
 /// <summary>
 /// 工程表附加信息(PrjTabAddi)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conPrjTabAddi
{
public const string _CurrTabName = "PrjTabAddi"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TabId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"TabId", "ColumnWidth", "NodeHeight", "UpdUser", "UpdDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"TabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabId = "TabId";    //表ID

 /// <summary>
 /// 常量:"ColumnWidth"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ColumnWidth = "ColumnWidth";    //结点宽

 /// <summary>
 /// 常量:"NodeHeight"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string NodeHeight = "NodeHeight";    //结点高

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