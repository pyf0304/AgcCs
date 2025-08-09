
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewStyleEN
 表名:vViewStyle(00050292)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:13:59
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
 /// 表vViewStyle的关键字(ViewId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ViewId_vViewStyle
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
public K_ViewId_vViewStyle(string strViewId)
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
 /// <returns>返回:[K_ViewId_vViewStyle]类型的对象</returns>
public static implicit operator K_ViewId_vViewStyle(string value)
{
return new K_ViewId_vViewStyle(value);
}
}
 /// <summary>
 /// v界面模式(vViewStyle)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvViewStyleEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vViewStyle"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ViewId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 5;
public static string[] _AttributeName = new string[] {"ViewId", "TitleStyleId", "TitleStyleName", "DgStyleId", "DgStyleName"};

protected string mstrViewId;    //界面Id
protected string mstrTitleStyleId;    //标题类型Id
protected string mstrTitleStyleName;    //标题类型名
protected string mstrDgStyleId;    //DG模式ID
protected string mstrDgStyleName;    //DG模式名

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvViewStyleEN()
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
public clsvViewStyleEN(string strViewId)
 {
strViewId = strViewId.Replace("'", "''");
if (strViewId.Length > 8)
{
throw new Exception("在表:vViewStyle中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strViewId)  ==  true)
{
throw new Exception("在表:vViewStyle中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convViewStyle.ViewId)
{
return mstrViewId;
}
else if (strAttributeName  ==  convViewStyle.TitleStyleId)
{
return mstrTitleStyleId;
}
else if (strAttributeName  ==  convViewStyle.TitleStyleName)
{
return mstrTitleStyleName;
}
else if (strAttributeName  ==  convViewStyle.DgStyleId)
{
return mstrDgStyleId;
}
else if (strAttributeName  ==  convViewStyle.DgStyleName)
{
return mstrDgStyleName;
}
return null;
}
set
{
if (strAttributeName  ==  convViewStyle.ViewId)
{
mstrViewId = value.ToString();
 AddUpdatedFld(convViewStyle.ViewId);
}
else if (strAttributeName  ==  convViewStyle.TitleStyleId)
{
mstrTitleStyleId = value.ToString();
 AddUpdatedFld(convViewStyle.TitleStyleId);
}
else if (strAttributeName  ==  convViewStyle.TitleStyleName)
{
mstrTitleStyleName = value.ToString();
 AddUpdatedFld(convViewStyle.TitleStyleName);
}
else if (strAttributeName  ==  convViewStyle.DgStyleId)
{
mstrDgStyleId = value.ToString();
 AddUpdatedFld(convViewStyle.DgStyleId);
}
else if (strAttributeName  ==  convViewStyle.DgStyleName)
{
mstrDgStyleName = value.ToString();
 AddUpdatedFld(convViewStyle.DgStyleName);
}
}
}
public object this[int intIndex]
{
get
{
if (convViewStyle.ViewId  ==  _AttributeName[intIndex])
{
return mstrViewId;
}
else if (convViewStyle.TitleStyleId  ==  _AttributeName[intIndex])
{
return mstrTitleStyleId;
}
else if (convViewStyle.TitleStyleName  ==  _AttributeName[intIndex])
{
return mstrTitleStyleName;
}
else if (convViewStyle.DgStyleId  ==  _AttributeName[intIndex])
{
return mstrDgStyleId;
}
else if (convViewStyle.DgStyleName  ==  _AttributeName[intIndex])
{
return mstrDgStyleName;
}
return null;
}
set
{
if (convViewStyle.ViewId  ==  _AttributeName[intIndex])
{
mstrViewId = value.ToString();
 AddUpdatedFld(convViewStyle.ViewId);
}
else if (convViewStyle.TitleStyleId  ==  _AttributeName[intIndex])
{
mstrTitleStyleId = value.ToString();
 AddUpdatedFld(convViewStyle.TitleStyleId);
}
else if (convViewStyle.TitleStyleName  ==  _AttributeName[intIndex])
{
mstrTitleStyleName = value.ToString();
 AddUpdatedFld(convViewStyle.TitleStyleName);
}
else if (convViewStyle.DgStyleId  ==  _AttributeName[intIndex])
{
mstrDgStyleId = value.ToString();
 AddUpdatedFld(convViewStyle.DgStyleId);
}
else if (convViewStyle.DgStyleName  ==  _AttributeName[intIndex])
{
mstrDgStyleName = value.ToString();
 AddUpdatedFld(convViewStyle.DgStyleName);
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
 AddUpdatedFld(convViewStyle.ViewId);
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
 AddUpdatedFld(convViewStyle.TitleStyleId);
}
}
/// <summary>
/// 标题类型名(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TitleStyleName
{
get
{
return mstrTitleStyleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTitleStyleName = value;
}
else
{
 mstrTitleStyleName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewStyle.TitleStyleName);
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
 AddUpdatedFld(convViewStyle.DgStyleId);
}
}
/// <summary>
/// DG模式名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DgStyleName
{
get
{
return mstrDgStyleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDgStyleName = value;
}
else
{
 mstrDgStyleName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewStyle.DgStyleName);
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
 /// v界面模式(vViewStyle)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convViewStyle
{
public const string _CurrTabName = "vViewStyle"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ViewId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"ViewId", "TitleStyleId", "TitleStyleName", "DgStyleId", "DgStyleName"};
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
 /// 常量:"TitleStyleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TitleStyleName = "TitleStyleName";    //标题类型名

 /// <summary>
 /// 常量:"DgStyleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DgStyleId = "DgStyleId";    //DG模式ID

 /// <summary>
 /// 常量:"DgStyleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DgStyleName = "DgStyleName";    //DG模式名
}

}