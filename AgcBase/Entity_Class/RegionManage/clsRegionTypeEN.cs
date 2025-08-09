
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsRegionTypeEN
 表名:RegionType(00050081)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:03:37
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
 /// 表RegionType的关键字(RegionTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_RegionTypeId_RegionType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strRegionTypeId">表关键字</param>
public K_RegionTypeId_RegionType(string strRegionTypeId)
{
if (IsValid(strRegionTypeId)) Value = strRegionTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strRegionTypeId)
{
if (string.IsNullOrEmpty(strRegionTypeId) == true) return false;
if (strRegionTypeId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_RegionTypeId_RegionType]类型的对象</returns>
public static implicit operator K_RegionTypeId_RegionType(string value)
{
return new K_RegionTypeId_RegionType(value);
}
}
 /// <summary>
 /// 区域类型(RegionType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsRegionTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "RegionType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "RegionTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 7;
public static string[] _AttributeName = new string[] {"RegionTypeId", "RegionTypeName", "RegionTypeENName", "RegionTypeSimName", "DefaWidth", "RegionTypeOrderNum", "Memo"};

protected string mstrRegionTypeId;    //区域类型Id
protected string mstrRegionTypeName;    //区域类型名称
protected string mstrRegionTypeENName;    //区域类型英文名
protected string mstrRegionTypeSimName;    //区域类型简名
protected int? mintDefaWidth;    //缺省宽度
protected int? mintRegionTypeOrderNum;    //区域类型序号
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsRegionTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("RegionTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strRegionTypeId">关键字:区域类型Id</param>
public clsRegionTypeEN(string strRegionTypeId)
 {
strRegionTypeId = strRegionTypeId.Replace("'", "''");
if (strRegionTypeId.Length > 4)
{
throw new Exception("在表:RegionType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strRegionTypeId)  ==  true)
{
throw new Exception("在表:RegionType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strRegionTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrRegionTypeId = strRegionTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("RegionTypeId");
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
if (strAttributeName  ==  conRegionType.RegionTypeId)
{
return mstrRegionTypeId;
}
else if (strAttributeName  ==  conRegionType.RegionTypeName)
{
return mstrRegionTypeName;
}
else if (strAttributeName  ==  conRegionType.RegionTypeENName)
{
return mstrRegionTypeENName;
}
else if (strAttributeName  ==  conRegionType.RegionTypeSimName)
{
return mstrRegionTypeSimName;
}
else if (strAttributeName  ==  conRegionType.DefaWidth)
{
return mintDefaWidth;
}
else if (strAttributeName  ==  conRegionType.RegionTypeOrderNum)
{
return mintRegionTypeOrderNum;
}
else if (strAttributeName  ==  conRegionType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conRegionType.RegionTypeId)
{
mstrRegionTypeId = value.ToString();
 AddUpdatedFld(conRegionType.RegionTypeId);
}
else if (strAttributeName  ==  conRegionType.RegionTypeName)
{
mstrRegionTypeName = value.ToString();
 AddUpdatedFld(conRegionType.RegionTypeName);
}
else if (strAttributeName  ==  conRegionType.RegionTypeENName)
{
mstrRegionTypeENName = value.ToString();
 AddUpdatedFld(conRegionType.RegionTypeENName);
}
else if (strAttributeName  ==  conRegionType.RegionTypeSimName)
{
mstrRegionTypeSimName = value.ToString();
 AddUpdatedFld(conRegionType.RegionTypeSimName);
}
else if (strAttributeName  ==  conRegionType.DefaWidth)
{
mintDefaWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(conRegionType.DefaWidth);
}
else if (strAttributeName  ==  conRegionType.RegionTypeOrderNum)
{
mintRegionTypeOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conRegionType.RegionTypeOrderNum);
}
else if (strAttributeName  ==  conRegionType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conRegionType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conRegionType.RegionTypeId  ==  _AttributeName[intIndex])
{
return mstrRegionTypeId;
}
else if (conRegionType.RegionTypeName  ==  _AttributeName[intIndex])
{
return mstrRegionTypeName;
}
else if (conRegionType.RegionTypeENName  ==  _AttributeName[intIndex])
{
return mstrRegionTypeENName;
}
else if (conRegionType.RegionTypeSimName  ==  _AttributeName[intIndex])
{
return mstrRegionTypeSimName;
}
else if (conRegionType.DefaWidth  ==  _AttributeName[intIndex])
{
return mintDefaWidth;
}
else if (conRegionType.RegionTypeOrderNum  ==  _AttributeName[intIndex])
{
return mintRegionTypeOrderNum;
}
else if (conRegionType.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conRegionType.RegionTypeId  ==  _AttributeName[intIndex])
{
mstrRegionTypeId = value.ToString();
 AddUpdatedFld(conRegionType.RegionTypeId);
}
else if (conRegionType.RegionTypeName  ==  _AttributeName[intIndex])
{
mstrRegionTypeName = value.ToString();
 AddUpdatedFld(conRegionType.RegionTypeName);
}
else if (conRegionType.RegionTypeENName  ==  _AttributeName[intIndex])
{
mstrRegionTypeENName = value.ToString();
 AddUpdatedFld(conRegionType.RegionTypeENName);
}
else if (conRegionType.RegionTypeSimName  ==  _AttributeName[intIndex])
{
mstrRegionTypeSimName = value.ToString();
 AddUpdatedFld(conRegionType.RegionTypeSimName);
}
else if (conRegionType.DefaWidth  ==  _AttributeName[intIndex])
{
mintDefaWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(conRegionType.DefaWidth);
}
else if (conRegionType.RegionTypeOrderNum  ==  _AttributeName[intIndex])
{
mintRegionTypeOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conRegionType.RegionTypeOrderNum);
}
else if (conRegionType.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conRegionType.Memo);
}
}
}

/// <summary>
/// 区域类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RegionTypeId
{
get
{
return mstrRegionTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRegionTypeId = value;
}
else
{
 mstrRegionTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conRegionType.RegionTypeId);
}
}
/// <summary>
/// 区域类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RegionTypeName
{
get
{
return mstrRegionTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRegionTypeName = value;
}
else
{
 mstrRegionTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conRegionType.RegionTypeName);
}
}
/// <summary>
/// 区域类型英文名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RegionTypeENName
{
get
{
return mstrRegionTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRegionTypeENName = value;
}
else
{
 mstrRegionTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conRegionType.RegionTypeENName);
}
}
/// <summary>
/// 区域类型简名(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RegionTypeSimName
{
get
{
return mstrRegionTypeSimName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRegionTypeSimName = value;
}
else
{
 mstrRegionTypeSimName = value;
}
//记录修改过的字段
 AddUpdatedFld(conRegionType.RegionTypeSimName);
}
}
/// <summary>
/// 缺省宽度(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? DefaWidth
{
get
{
return mintDefaWidth;
}
set
{
 mintDefaWidth = value;
//记录修改过的字段
 AddUpdatedFld(conRegionType.DefaWidth);
}
}
/// <summary>
/// 区域类型序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? RegionTypeOrderNum
{
get
{
return mintRegionTypeOrderNum;
}
set
{
 mintRegionTypeOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(conRegionType.RegionTypeOrderNum);
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
 AddUpdatedFld(conRegionType.Memo);
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
  return mstrRegionTypeId;
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
  return mstrRegionTypeName;
 }
 }
}
 /// <summary>
 /// 区域类型(RegionType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conRegionType
{
public const string _CurrTabName = "RegionType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "RegionTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"RegionTypeId", "RegionTypeName", "RegionTypeENName", "RegionTypeSimName", "DefaWidth", "RegionTypeOrderNum", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"RegionTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RegionTypeId = "RegionTypeId";    //区域类型Id

 /// <summary>
 /// 常量:"RegionTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RegionTypeName = "RegionTypeName";    //区域类型名称

 /// <summary>
 /// 常量:"RegionTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RegionTypeENName = "RegionTypeENName";    //区域类型英文名

 /// <summary>
 /// 常量:"RegionTypeSimName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RegionTypeSimName = "RegionTypeSimName";    //区域类型简名

 /// <summary>
 /// 常量:"DefaWidth"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DefaWidth = "DefaWidth";    //缺省宽度

 /// <summary>
 /// 常量:"RegionTypeOrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RegionTypeOrderNum = "RegionTypeOrderNum";    //区域类型序号

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}