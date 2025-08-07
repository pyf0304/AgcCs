
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjTabNumEN
 表名:vPrjTabNum(00050293)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:49:10
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
 /// 表vPrjTabNum的关键字(FldId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_FldId_vPrjTabNum
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strFldId">表关键字</param>
public K_FldId_vPrjTabNum(string strFldId)
{
if (IsValid(strFldId)) Value = strFldId;
else
{
Value = null;
}
}
private static bool IsValid(string strFldId)
{
if (string.IsNullOrEmpty(strFldId) == true) return false;
if (strFldId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_FldId_vPrjTabNum]类型的对象</returns>
public static implicit operator K_FldId_vPrjTabNum(string value)
{
return new K_FldId_vPrjTabNum(value);
}
}
 /// <summary>
 /// vPrjTabNum(vPrjTabNum)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvPrjTabNumEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vPrjTabNum"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "FldId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = "FldId in (Select FldId from PrjTabFld where TabId='{0}')"; //前台条件格式串
protected const int _AttributeCount = 3;
public static string[] _AttributeName = new string[] {"FldId", "TabNum", "PrjId"};

protected string mstrFldId;    //字段Id
protected int? mintTabNum;    //表数
protected string mstrPrjId;    //工程Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvPrjTabNumEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FldId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strFldId">关键字:字段Id</param>
public clsvPrjTabNumEN(string strFldId)
 {
strFldId = strFldId.Replace("'", "''");
if (strFldId.Length > 8)
{
throw new Exception("在表:vPrjTabNum中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strFldId)  ==  true)
{
throw new Exception("在表:vPrjTabNum中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFldId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrFldId = strFldId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FldId");
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
if (strAttributeName  ==  convPrjTabNum.FldId)
{
return mstrFldId;
}
else if (strAttributeName  ==  convPrjTabNum.TabNum)
{
return mintTabNum;
}
else if (strAttributeName  ==  convPrjTabNum.PrjId)
{
return mstrPrjId;
}
return null;
}
set
{
if (strAttributeName  ==  convPrjTabNum.FldId)
{
mstrFldId = value.ToString();
 AddUpdatedFld(convPrjTabNum.FldId);
}
else if (strAttributeName  ==  convPrjTabNum.TabNum)
{
mintTabNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convPrjTabNum.TabNum);
}
else if (strAttributeName  ==  convPrjTabNum.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convPrjTabNum.PrjId);
}
}
}
public object this[int intIndex]
{
get
{
if (convPrjTabNum.FldId  ==  _AttributeName[intIndex])
{
return mstrFldId;
}
else if (convPrjTabNum.TabNum  ==  _AttributeName[intIndex])
{
return mintTabNum;
}
else if (convPrjTabNum.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
return null;
}
set
{
if (convPrjTabNum.FldId  ==  _AttributeName[intIndex])
{
mstrFldId = value.ToString();
 AddUpdatedFld(convPrjTabNum.FldId);
}
else if (convPrjTabNum.TabNum  ==  _AttributeName[intIndex])
{
mintTabNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convPrjTabNum.TabNum);
}
else if (convPrjTabNum.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convPrjTabNum.PrjId);
}
}
}

/// <summary>
/// 字段Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FldId
{
get
{
return mstrFldId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldId = value;
}
else
{
 mstrFldId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjTabNum.FldId);
}
}
/// <summary>
/// 表数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? TabNum
{
get
{
return mintTabNum;
}
set
{
 mintTabNum = value;
//记录修改过的字段
 AddUpdatedFld(convPrjTabNum.TabNum);
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
 AddUpdatedFld(convPrjTabNum.PrjId);
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
  return mstrFldId;
 }
 }
}
 /// <summary>
 /// vPrjTabNum(vPrjTabNum)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convPrjTabNum
{
public const string _CurrTabName = "vPrjTabNum"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FldId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"FldId", "TabNum", "PrjId"};
//以下是属性变量


 /// <summary>
 /// 常量:"FldId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldId = "FldId";    //字段Id

 /// <summary>
 /// 常量:"TabNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabNum = "TabNum";    //表数

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id
}

}