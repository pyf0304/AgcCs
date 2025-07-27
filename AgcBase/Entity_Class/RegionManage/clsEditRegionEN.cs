
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsEditRegionEN
 表名:EditRegion(00050118)
 * 版本:2023.05.26.1(服务器:PYF-THINKPAD)
 日期:2023/05/27 06:46:08
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcMvc(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:区域管理(RegionManage)
 框架-层名:实体层(CS)(EntityLayer)
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

namespace AGC.Entity
{
 /// <summary>
 /// 表EditRegion的关键字(RegionId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_RegionId_EditRegion
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strRegionId">表关键字</param>
public K_RegionId_EditRegion(string strRegionId)
{
if (IsValid(strRegionId)) Value = strRegionId;
else
{
Value = null;
}
}
private static bool IsValid(string strRegionId)
{
if (string.IsNullOrEmpty(strRegionId) == true) return false;
if (strRegionId.Length != 10) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_RegionId_EditRegion]类型的对象</returns>
public static implicit operator K_RegionId_EditRegion(string value)
{
return new K_RegionId_EditRegion(value);
}
}
 /// <summary>
 /// 编辑区域(EditRegion)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsEditRegionEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接，如果为空就使用系统默认的连接
public const string _CurrTabName_S = "EditRegion"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "RegionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string WhereFormat = ""; //条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"RegionId", "IsUseCtrl", "PrjId", "UpdUser", "UpdDate"};

protected string mstrRegionId;    //区域Id
protected bool mbolIsUseCtrl;    //是否使用控件
protected string mstrPrjId;    //工程ID
protected string mstrUpdUser;    //修改者
protected string mstrUpdDate;    //修改日期

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsEditRegionEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "EditRegion";
 lstKeyFldNames.Add("RegionId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strRegionId">关键字:区域Id</param>
public clsEditRegionEN(string strRegionId)
 {
strRegionId = strRegionId.Replace("'", "''");
if (strRegionId.Length > 10)
{
throw new Exception("在表:EditRegion中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strRegionId)  ==  true)
{
throw new Exception("在表:EditRegion中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strRegionId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrRegionId = strRegionId;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "EditRegion";
 lstKeyFldNames.Add("RegionId");
 }

public static int AttributeCount
{
get
{
return mintAttributeCount;
}
}
public override object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  conEditRegion.RegionId)
{
return mstrRegionId;
}
else if (strAttributeName  ==  conEditRegion.IsUseCtrl)
{
return mbolIsUseCtrl;
}
else if (strAttributeName  ==  conEditRegion.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conEditRegion.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conEditRegion.UpdDate)
{
return mstrUpdDate;
}
return null;
}
set
{
if (strAttributeName  ==  conEditRegion.RegionId)
{
mstrRegionId = value.ToString();
 AddUpdatedFld(conEditRegion.RegionId);
}
else if (strAttributeName  ==  conEditRegion.IsUseCtrl)
{
mbolIsUseCtrl = TransNullToBool(value.ToString());
 AddUpdatedFld(conEditRegion.IsUseCtrl);
}
else if (strAttributeName  ==  conEditRegion.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conEditRegion.PrjId);
}
else if (strAttributeName  ==  conEditRegion.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conEditRegion.UpdUser);
}
else if (strAttributeName  ==  conEditRegion.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conEditRegion.UpdDate);
}
}
}
public object this[int intIndex]
{
get
{
if (conEditRegion.RegionId  ==  AttributeName[intIndex])
{
return mstrRegionId;
}
else if (conEditRegion.IsUseCtrl  ==  AttributeName[intIndex])
{
return mbolIsUseCtrl;
}
else if (conEditRegion.PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conEditRegion.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conEditRegion.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
return null;
}
set
{
if (conEditRegion.RegionId  ==  AttributeName[intIndex])
{
mstrRegionId = value.ToString();
 AddUpdatedFld(conEditRegion.RegionId);
}
else if (conEditRegion.IsUseCtrl  ==  AttributeName[intIndex])
{
mbolIsUseCtrl = TransNullToBool(value.ToString());
 AddUpdatedFld(conEditRegion.IsUseCtrl);
}
else if (conEditRegion.PrjId  ==  AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conEditRegion.PrjId);
}
else if (conEditRegion.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conEditRegion.UpdUser);
}
else if (conEditRegion.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conEditRegion.UpdDate);
}
}
}

/// <summary>
/// 区域Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RegionId
{
get
{
return mstrRegionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRegionId = value;
}
else
{
 mstrRegionId = value;
}
//记录修改过的字段
 AddUpdatedFld(conEditRegion.RegionId);
}
}
/// <summary>
/// 是否使用控件(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsUseCtrl
{
get
{
return mbolIsUseCtrl;
}
set
{
 mbolIsUseCtrl = value;
//记录修改过的字段
 AddUpdatedFld(conEditRegion.IsUseCtrl);
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
 AddUpdatedFld(conEditRegion.PrjId);
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
 AddUpdatedFld(conEditRegion.UpdUser);
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
 AddUpdatedFld(conEditRegion.UpdDate);
}
}

/// <summary>
/// 获取关键字Id(keyId)
 /// (AutoGCLib.clsGeneCodeBase:GenGetKeyId)
/// </summary>
 public override string _KeyId
 {
 get
 {
  return mstrRegionId;
 }
 }
}
 /// <summary>
 /// 编辑区域(EditRegion)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conEditRegion
{
public const string _CurrTabName_S = "EditRegion"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "RegionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"RegionId", "IsUseCtrl", "PrjId", "UpdUser", "UpdDate"};
//以下是属性变量


 /// <summary>
 /// 常量:"RegionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RegionId = "RegionId";    //区域Id

 /// <summary>
 /// 常量:"IsUseCtrl"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsUseCtrl = "IsUseCtrl";    //是否使用控件

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程ID

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
}

}