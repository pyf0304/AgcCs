
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsActionForwardEN
 表名:ActionForward(00050143)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:11:04
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:J2EE模块(J2EEModule)
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
 /// 表ActionForward的关键字(ActionForwardId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ActionForwardId_ActionForward
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngActionForwardId">表关键字</param>
public K_ActionForwardId_ActionForward(long lngActionForwardId)
{
if (IsValid(lngActionForwardId)) Value = lngActionForwardId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngActionForwardId)
{
if (lngActionForwardId == 0) return false;
if (lngActionForwardId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ActionForwardId_ActionForward]类型的对象</returns>
public static implicit operator K_ActionForwardId_ActionForward(long value)
{
return new K_ActionForwardId_ActionForward(value);
}
}
 /// <summary>
 /// ActionForward(ActionForward)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsActionForwardEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ActionForward"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ActionForwardId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 4;
public static string[] _AttributeName = new string[] {"ActionForwardId", "ActionId", "ForwardName", "ForwardPath"};

protected long mlngActionForwardId;    //ActionForwardId
protected string mstrActionId;    //ActionId
protected string mstrForwardName;    //Forward名称
protected string mstrForwardPath;    //Forward路径

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsActionForwardEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ActionForwardId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "lngActionForwardId">关键字:ActionForwardId</param>
public clsActionForwardEN(long lngActionForwardId)
 {
 if (lngActionForwardId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngActionForwardId = lngActionForwardId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ActionForwardId");
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
if (strAttributeName  ==  conActionForward.ActionForwardId)
{
return mlngActionForwardId;
}
else if (strAttributeName  ==  conActionForward.ActionId)
{
return mstrActionId;
}
else if (strAttributeName  ==  conActionForward.ForwardName)
{
return mstrForwardName;
}
else if (strAttributeName  ==  conActionForward.ForwardPath)
{
return mstrForwardPath;
}
return null;
}
set
{
if (strAttributeName  ==  conActionForward.ActionForwardId)
{
mlngActionForwardId = TransNullToInt(value.ToString());
 AddUpdatedFld(conActionForward.ActionForwardId);
}
else if (strAttributeName  ==  conActionForward.ActionId)
{
mstrActionId = value.ToString();
 AddUpdatedFld(conActionForward.ActionId);
}
else if (strAttributeName  ==  conActionForward.ForwardName)
{
mstrForwardName = value.ToString();
 AddUpdatedFld(conActionForward.ForwardName);
}
else if (strAttributeName  ==  conActionForward.ForwardPath)
{
mstrForwardPath = value.ToString();
 AddUpdatedFld(conActionForward.ForwardPath);
}
}
}
public object this[int intIndex]
{
get
{
if (conActionForward.ActionForwardId  ==  _AttributeName[intIndex])
{
return mlngActionForwardId;
}
else if (conActionForward.ActionId  ==  _AttributeName[intIndex])
{
return mstrActionId;
}
else if (conActionForward.ForwardName  ==  _AttributeName[intIndex])
{
return mstrForwardName;
}
else if (conActionForward.ForwardPath  ==  _AttributeName[intIndex])
{
return mstrForwardPath;
}
return null;
}
set
{
if (conActionForward.ActionForwardId  ==  _AttributeName[intIndex])
{
mlngActionForwardId = TransNullToInt(value.ToString());
 AddUpdatedFld(conActionForward.ActionForwardId);
}
else if (conActionForward.ActionId  ==  _AttributeName[intIndex])
{
mstrActionId = value.ToString();
 AddUpdatedFld(conActionForward.ActionId);
}
else if (conActionForward.ForwardName  ==  _AttributeName[intIndex])
{
mstrForwardName = value.ToString();
 AddUpdatedFld(conActionForward.ForwardName);
}
else if (conActionForward.ForwardPath  ==  _AttributeName[intIndex])
{
mstrForwardPath = value.ToString();
 AddUpdatedFld(conActionForward.ForwardPath);
}
}
}

/// <summary>
/// ActionForwardId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long ActionForwardId
{
get
{
return mlngActionForwardId;
}
set
{
 mlngActionForwardId = value;
//记录修改过的字段
 AddUpdatedFld(conActionForward.ActionForwardId);
}
}
/// <summary>
/// ActionId(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ActionId
{
get
{
return mstrActionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrActionId = value;
}
else
{
 mstrActionId = value;
}
//记录修改过的字段
 AddUpdatedFld(conActionForward.ActionId);
}
}
/// <summary>
/// Forward名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ForwardName
{
get
{
return mstrForwardName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrForwardName = value;
}
else
{
 mstrForwardName = value;
}
//记录修改过的字段
 AddUpdatedFld(conActionForward.ForwardName);
}
}
/// <summary>
/// Forward路径(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ForwardPath
{
get
{
return mstrForwardPath;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrForwardPath = value;
}
else
{
 mstrForwardPath = value;
}
//记录修改过的字段
 AddUpdatedFld(conActionForward.ForwardPath);
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
  return mlngActionForwardId.ToString();
 }
 }
}
 /// <summary>
 /// ActionForward(ActionForward)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conActionForward
{
public const string _CurrTabName = "ActionForward"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ActionForwardId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"ActionForwardId", "ActionId", "ForwardName", "ForwardPath"};
//以下是属性变量


 /// <summary>
 /// 常量:"ActionForwardId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ActionForwardId = "ActionForwardId";    //ActionForwardId

 /// <summary>
 /// 常量:"ActionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ActionId = "ActionId";    //ActionId

 /// <summary>
 /// 常量:"ForwardName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ForwardName = "ForwardName";    //Forward名称

 /// <summary>
 /// 常量:"ForwardPath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ForwardPath = "ForwardPath";    //Forward路径
}

}