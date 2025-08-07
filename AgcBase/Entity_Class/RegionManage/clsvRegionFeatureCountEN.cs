
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvRegionFeatureCountEN
 表名:vRegionFeatureCount(00050575)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:36:13
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:区域管理(RegionManage)
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
 /// 表vRegionFeatureCount的关键字(RegionId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_RegionId_vRegionFeatureCount
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
public K_RegionId_vRegionFeatureCount(string strRegionId)
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
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_RegionId_vRegionFeatureCount]类型的对象</returns>
public static implicit operator K_RegionId_vRegionFeatureCount(string value)
{
return new K_RegionId_vRegionFeatureCount(value);
}
}
 /// <summary>
 /// v区域功能数(vRegionFeatureCount)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvRegionFeatureCountEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vRegionFeatureCount"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "RegionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 3;
public static string[] _AttributeName = new string[] {"RegionId", "FeatureCount", "PrjId"};

protected string mstrRegionId;    //区域Id
protected int? mintFeatureCount;    //功能数
protected string mstrPrjId;    //工程Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvRegionFeatureCountEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("RegionId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strRegionId">关键字:区域Id</param>
public clsvRegionFeatureCountEN(string strRegionId)
 {
strRegionId = strRegionId.Replace("'", "''");
if (strRegionId.Length > 10)
{
throw new Exception("在表:vRegionFeatureCount中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strRegionId)  ==  true)
{
throw new Exception("在表:vRegionFeatureCount中,关键字不能为空 或 null!");
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
 lstKeyFldNames.Add("RegionId");
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
if (strAttributeName  ==  convRegionFeatureCount.RegionId)
{
return mstrRegionId;
}
else if (strAttributeName  ==  convRegionFeatureCount.FeatureCount)
{
return mintFeatureCount;
}
else if (strAttributeName  ==  convRegionFeatureCount.PrjId)
{
return mstrPrjId;
}
return null;
}
set
{
if (strAttributeName  ==  convRegionFeatureCount.RegionId)
{
mstrRegionId = value.ToString();
 AddUpdatedFld(convRegionFeatureCount.RegionId);
}
else if (strAttributeName  ==  convRegionFeatureCount.FeatureCount)
{
mintFeatureCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convRegionFeatureCount.FeatureCount);
}
else if (strAttributeName  ==  convRegionFeatureCount.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convRegionFeatureCount.PrjId);
}
}
}
public object this[int intIndex]
{
get
{
if (convRegionFeatureCount.RegionId  ==  _AttributeName[intIndex])
{
return mstrRegionId;
}
else if (convRegionFeatureCount.FeatureCount  ==  _AttributeName[intIndex])
{
return mintFeatureCount;
}
else if (convRegionFeatureCount.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
return null;
}
set
{
if (convRegionFeatureCount.RegionId  ==  _AttributeName[intIndex])
{
mstrRegionId = value.ToString();
 AddUpdatedFld(convRegionFeatureCount.RegionId);
}
else if (convRegionFeatureCount.FeatureCount  ==  _AttributeName[intIndex])
{
mintFeatureCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convRegionFeatureCount.FeatureCount);
}
else if (convRegionFeatureCount.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convRegionFeatureCount.PrjId);
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
 AddUpdatedFld(convRegionFeatureCount.RegionId);
}
}
/// <summary>
/// 功能数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? FeatureCount
{
get
{
return mintFeatureCount;
}
set
{
 mintFeatureCount = value;
//记录修改过的字段
 AddUpdatedFld(convRegionFeatureCount.FeatureCount);
}
}
/// <summary>
/// 工程Id(说明:;字段类型:char;字段长度:4;是否可空:False)
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
 AddUpdatedFld(convRegionFeatureCount.PrjId);
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
  return mstrRegionId;
 }
 }
}
 /// <summary>
 /// v区域功能数(vRegionFeatureCount)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convRegionFeatureCount
{
public const string _CurrTabName = "vRegionFeatureCount"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "RegionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"RegionId", "FeatureCount", "PrjId"};
//以下是属性变量


 /// <summary>
 /// 常量:"RegionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RegionId = "RegionId";    //区域Id

 /// <summary>
 /// 常量:"FeatureCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeatureCount = "FeatureCount";    //功能数

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id
}

}