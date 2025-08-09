
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewStyleEN
 表名:ViewStyle(00050007)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:09:29
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:界面管理(PrjInterface)
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
 /// 表ViewStyle的关键字(ViewId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ViewId_ViewStyle
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strViewId">表关键字</param>
public K_ViewId_ViewStyle(string strViewId)
{
if (IsValid(strViewId)) Value = strViewId;
else
{
Value = null;
}
}
private static bool IsValid(string strViewId)
{
if (string.IsNullOrEmpty(strViewId) == true) return false;
if (strViewId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ViewId_ViewStyle]类型的对象</returns>
public static implicit operator K_ViewId_ViewStyle(string value)
{
return new K_ViewId_ViewStyle(value);
}
}
 /// <summary>
 /// 界面模式(ViewStyle)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsViewStyleEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ViewStyle"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ViewId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 3;
public static string[] _AttributeName = new string[] {"ViewId", "TitleStyleId", "DgStyleId"};

protected string mstrViewId;    //界面Id
protected string mstrTitleStyleId;    //标题类型Id
protected string mstrDgStyleId;    //DG模式ID

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsViewStyleEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ViewId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strViewId">关键字:界面Id</param>
public clsViewStyleEN(string strViewId)
 {
strViewId = strViewId.Replace("'", "''");
if (strViewId.Length > 8)
{
throw new Exception("在表:ViewStyle中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strViewId)  ==  true)
{
throw new Exception("在表:ViewStyle中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strViewId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrViewId = strViewId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ViewId");
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
if (strAttributeName  ==  conViewStyle.ViewId)
{
return mstrViewId;
}
else if (strAttributeName  ==  conViewStyle.TitleStyleId)
{
return mstrTitleStyleId;
}
else if (strAttributeName  ==  conViewStyle.DgStyleId)
{
return mstrDgStyleId;
}
return null;
}
set
{
if (strAttributeName  ==  conViewStyle.ViewId)
{
mstrViewId = value.ToString();
 AddUpdatedFld(conViewStyle.ViewId);
}
else if (strAttributeName  ==  conViewStyle.TitleStyleId)
{
mstrTitleStyleId = value.ToString();
 AddUpdatedFld(conViewStyle.TitleStyleId);
}
else if (strAttributeName  ==  conViewStyle.DgStyleId)
{
mstrDgStyleId = value.ToString();
 AddUpdatedFld(conViewStyle.DgStyleId);
}
}
}
public object this[int intIndex]
{
get
{
if (conViewStyle.ViewId  ==  _AttributeName[intIndex])
{
return mstrViewId;
}
else if (conViewStyle.TitleStyleId  ==  _AttributeName[intIndex])
{
return mstrTitleStyleId;
}
else if (conViewStyle.DgStyleId  ==  _AttributeName[intIndex])
{
return mstrDgStyleId;
}
return null;
}
set
{
if (conViewStyle.ViewId  ==  _AttributeName[intIndex])
{
mstrViewId = value.ToString();
 AddUpdatedFld(conViewStyle.ViewId);
}
else if (conViewStyle.TitleStyleId  ==  _AttributeName[intIndex])
{
mstrTitleStyleId = value.ToString();
 AddUpdatedFld(conViewStyle.TitleStyleId);
}
else if (conViewStyle.DgStyleId  ==  _AttributeName[intIndex])
{
mstrDgStyleId = value.ToString();
 AddUpdatedFld(conViewStyle.DgStyleId);
}
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
 AddUpdatedFld(conViewStyle.ViewId);
}
}
/// <summary>
/// 标题类型Id(说明:;字段类型:varchar;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TitleStyleId
{
get
{
return mstrTitleStyleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTitleStyleId = value;
}
else
{
 mstrTitleStyleId = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewStyle.TitleStyleId);
}
}
/// <summary>
/// DG模式ID(说明:;字段类型:varchar;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DgStyleId
{
get
{
return mstrDgStyleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDgStyleId = value;
}
else
{
 mstrDgStyleId = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewStyle.DgStyleId);
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
  return mstrViewId;
 }
 }
}
 /// <summary>
 /// 界面模式(ViewStyle)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conViewStyle
{
public const string _CurrTabName = "ViewStyle"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ViewId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"ViewId", "TitleStyleId", "DgStyleId"};
//以下是属性变量


 /// <summary>
 /// 常量:"ViewId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewId = "ViewId";    //界面Id

 /// <summary>
 /// 常量:"TitleStyleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TitleStyleId = "TitleStyleId";    //标题类型Id

 /// <summary>
 /// 常量:"DgStyleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DgStyleId = "DgStyleId";    //DG模式ID
}

}