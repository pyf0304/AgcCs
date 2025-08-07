
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCommonDataNodeEN
 表名:CommonDataNode(00050572)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:25:53
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:AI模块(AIModule)
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
 /// 表CommonDataNode的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_CommonDataNode
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngmId">表关键字</param>
public K_mId_CommonDataNode(long lngmId)
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
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_mId_CommonDataNode]类型的对象</returns>
public static implicit operator K_mId_CommonDataNode(long value)
{
return new K_mId_CommonDataNode(value);
}
}
 /// <summary>
 /// 公共数据结点(CommonDataNode)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCommonDataNodeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CommonDataNode"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 5;
public static string[] _AttributeName = new string[] {"mId", "DateTimeSim", "Bool_True", "TabId_Main", "ViewId_Main"};

protected long mlngmId;    //mId
protected string mstrDateTimeSim;    //简化日期时间
protected bool mbolBool_True;    //布尔True
protected string mstrTabId_Main;    //表Id_Main
protected string mstrViewId_Main;    //界面Id_Main

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsCommonDataNodeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:mId</param>
public clsCommonDataNodeEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
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
if (strAttributeName  ==  conCommonDataNode.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conCommonDataNode.DateTimeSim)
{
return mstrDateTimeSim;
}
else if (strAttributeName  ==  conCommonDataNode.Bool_True)
{
return mbolBool_True;
}
else if (strAttributeName  ==  conCommonDataNode.TabId_Main)
{
return mstrTabId_Main;
}
else if (strAttributeName  ==  conCommonDataNode.ViewId_Main)
{
return mstrViewId_Main;
}
return null;
}
set
{
if (strAttributeName  ==  conCommonDataNode.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conCommonDataNode.mId);
}
else if (strAttributeName  ==  conCommonDataNode.DateTimeSim)
{
mstrDateTimeSim = value.ToString();
 AddUpdatedFld(conCommonDataNode.DateTimeSim);
}
else if (strAttributeName  ==  conCommonDataNode.Bool_True)
{
mbolBool_True = TransNullToBool(value.ToString());
 AddUpdatedFld(conCommonDataNode.Bool_True);
}
else if (strAttributeName  ==  conCommonDataNode.TabId_Main)
{
mstrTabId_Main = value.ToString();
 AddUpdatedFld(conCommonDataNode.TabId_Main);
}
else if (strAttributeName  ==  conCommonDataNode.ViewId_Main)
{
mstrViewId_Main = value.ToString();
 AddUpdatedFld(conCommonDataNode.ViewId_Main);
}
}
}
public object this[int intIndex]
{
get
{
if (conCommonDataNode.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (conCommonDataNode.DateTimeSim  ==  _AttributeName[intIndex])
{
return mstrDateTimeSim;
}
else if (conCommonDataNode.Bool_True  ==  _AttributeName[intIndex])
{
return mbolBool_True;
}
else if (conCommonDataNode.TabId_Main  ==  _AttributeName[intIndex])
{
return mstrTabId_Main;
}
else if (conCommonDataNode.ViewId_Main  ==  _AttributeName[intIndex])
{
return mstrViewId_Main;
}
return null;
}
set
{
if (conCommonDataNode.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conCommonDataNode.mId);
}
else if (conCommonDataNode.DateTimeSim  ==  _AttributeName[intIndex])
{
mstrDateTimeSim = value.ToString();
 AddUpdatedFld(conCommonDataNode.DateTimeSim);
}
else if (conCommonDataNode.Bool_True  ==  _AttributeName[intIndex])
{
mbolBool_True = TransNullToBool(value.ToString());
 AddUpdatedFld(conCommonDataNode.Bool_True);
}
else if (conCommonDataNode.TabId_Main  ==  _AttributeName[intIndex])
{
mstrTabId_Main = value.ToString();
 AddUpdatedFld(conCommonDataNode.TabId_Main);
}
else if (conCommonDataNode.ViewId_Main  ==  _AttributeName[intIndex])
{
mstrViewId_Main = value.ToString();
 AddUpdatedFld(conCommonDataNode.ViewId_Main);
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
 AddUpdatedFld(conCommonDataNode.mId);
}
}
/// <summary>
/// 简化日期时间(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DateTimeSim
{
get
{
return mstrDateTimeSim;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDateTimeSim = value;
}
else
{
 mstrDateTimeSim = value;
}
//记录修改过的字段
 AddUpdatedFld(conCommonDataNode.DateTimeSim);
}
}
/// <summary>
/// 布尔True(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool Bool_True
{
get
{
return mbolBool_True;
}
set
{
 mbolBool_True = value;
//记录修改过的字段
 AddUpdatedFld(conCommonDataNode.Bool_True);
}
}
/// <summary>
/// 表Id_Main(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabId_Main
{
get
{
return mstrTabId_Main;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabId_Main = value;
}
else
{
 mstrTabId_Main = value;
}
//记录修改过的字段
 AddUpdatedFld(conCommonDataNode.TabId_Main);
}
}
/// <summary>
/// 界面Id_Main(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewId_Main
{
get
{
return mstrViewId_Main;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewId_Main = value;
}
else
{
 mstrViewId_Main = value;
}
//记录修改过的字段
 AddUpdatedFld(conCommonDataNode.ViewId_Main);
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
  return mlngmId.ToString();
 }
 }
}
 /// <summary>
 /// 公共数据结点(CommonDataNode)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCommonDataNode
{
public const string _CurrTabName = "CommonDataNode"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "DateTimeSim", "Bool_True", "TabId_Main", "ViewId_Main"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"DateTimeSim"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DateTimeSim = "DateTimeSim";    //简化日期时间

 /// <summary>
 /// 常量:"Bool_True"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Bool_True = "Bool_True";    //布尔True

 /// <summary>
 /// 常量:"TabId_Main"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabId_Main = "TabId_Main";    //表Id_Main

 /// <summary>
 /// 常量:"ViewId_Main"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewId_Main = "ViewId_Main";    //界面Id_Main
}

}