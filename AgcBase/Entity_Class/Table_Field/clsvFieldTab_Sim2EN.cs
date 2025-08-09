
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFieldTab_Sim2EN
 表名:vFieldTab_Sim2(00050608)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:00:18
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
 /// 表vFieldTab_Sim2的关键字(FldId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_FldId_vFieldTab_Sim2
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
public K_FldId_vFieldTab_Sim2(string strFldId)
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
 /// <returns>返回:[K_FldId_vFieldTab_Sim2]类型的对象</returns>
public static implicit operator K_FldId_vFieldTab_Sim2(string value)
{
return new K_FldId_vFieldTab_Sim2(value);
}
}
 /// <summary>
 /// vFieldTab_Sim2(vFieldTab_Sim2)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvFieldTab_Sim2EN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vFieldTab_Sim2"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "FldId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 9;
public static string[] _AttributeName = new string[] {"FldId", "DataTypeId", "FldName", "Caption", "FldLength", "FldPrecision", "PrjId", "FieldTypeId", "HomologousFldId"};

protected string mstrFldId;    //字段Id
protected string mstrDataTypeId;    //数据类型Id
protected string mstrFldName;    //字段名
protected string mstrCaption;    //标题
protected int mintFldLength;    //字段长度
protected int? mintFldPrecision;    //精确度
protected string mstrPrjId;    //工程Id
protected string mstrFieldTypeId;    //字段类型Id
protected string mstrHomologousFldId;    //同源字段Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvFieldTab_Sim2EN()
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
public clsvFieldTab_Sim2EN(string strFldId)
 {
strFldId = strFldId.Replace("'", "''");
if (strFldId.Length > 8)
{
throw new Exception("在表:vFieldTab_Sim2中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strFldId)  ==  true)
{
throw new Exception("在表:vFieldTab_Sim2中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convFieldTab_Sim2.FldId)
{
return mstrFldId;
}
else if (strAttributeName  ==  convFieldTab_Sim2.DataTypeId)
{
return mstrDataTypeId;
}
else if (strAttributeName  ==  convFieldTab_Sim2.FldName)
{
return mstrFldName;
}
else if (strAttributeName  ==  convFieldTab_Sim2.Caption)
{
return mstrCaption;
}
else if (strAttributeName  ==  convFieldTab_Sim2.FldLength)
{
return mintFldLength;
}
else if (strAttributeName  ==  convFieldTab_Sim2.FldPrecision)
{
return mintFldPrecision;
}
else if (strAttributeName  ==  convFieldTab_Sim2.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convFieldTab_Sim2.FieldTypeId)
{
return mstrFieldTypeId;
}
else if (strAttributeName  ==  convFieldTab_Sim2.HomologousFldId)
{
return mstrHomologousFldId;
}
return null;
}
set
{
if (strAttributeName  ==  convFieldTab_Sim2.FldId)
{
mstrFldId = value.ToString();
 AddUpdatedFld(convFieldTab_Sim2.FldId);
}
else if (strAttributeName  ==  convFieldTab_Sim2.DataTypeId)
{
mstrDataTypeId = value.ToString();
 AddUpdatedFld(convFieldTab_Sim2.DataTypeId);
}
else if (strAttributeName  ==  convFieldTab_Sim2.FldName)
{
mstrFldName = value.ToString();
 AddUpdatedFld(convFieldTab_Sim2.FldName);
}
else if (strAttributeName  ==  convFieldTab_Sim2.Caption)
{
mstrCaption = value.ToString();
 AddUpdatedFld(convFieldTab_Sim2.Caption);
}
else if (strAttributeName  ==  convFieldTab_Sim2.FldLength)
{
mintFldLength = TransNullToInt(value.ToString());
 AddUpdatedFld(convFieldTab_Sim2.FldLength);
}
else if (strAttributeName  ==  convFieldTab_Sim2.FldPrecision)
{
mintFldPrecision = TransNullToInt(value.ToString());
 AddUpdatedFld(convFieldTab_Sim2.FldPrecision);
}
else if (strAttributeName  ==  convFieldTab_Sim2.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convFieldTab_Sim2.PrjId);
}
else if (strAttributeName  ==  convFieldTab_Sim2.FieldTypeId)
{
mstrFieldTypeId = value.ToString();
 AddUpdatedFld(convFieldTab_Sim2.FieldTypeId);
}
else if (strAttributeName  ==  convFieldTab_Sim2.HomologousFldId)
{
mstrHomologousFldId = value.ToString();
 AddUpdatedFld(convFieldTab_Sim2.HomologousFldId);
}
}
}
public object this[int intIndex]
{
get
{
if (convFieldTab_Sim2.FldId  ==  _AttributeName[intIndex])
{
return mstrFldId;
}
else if (convFieldTab_Sim2.DataTypeId  ==  _AttributeName[intIndex])
{
return mstrDataTypeId;
}
else if (convFieldTab_Sim2.FldName  ==  _AttributeName[intIndex])
{
return mstrFldName;
}
else if (convFieldTab_Sim2.Caption  ==  _AttributeName[intIndex])
{
return mstrCaption;
}
else if (convFieldTab_Sim2.FldLength  ==  _AttributeName[intIndex])
{
return mintFldLength;
}
else if (convFieldTab_Sim2.FldPrecision  ==  _AttributeName[intIndex])
{
return mintFldPrecision;
}
else if (convFieldTab_Sim2.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convFieldTab_Sim2.FieldTypeId  ==  _AttributeName[intIndex])
{
return mstrFieldTypeId;
}
else if (convFieldTab_Sim2.HomologousFldId  ==  _AttributeName[intIndex])
{
return mstrHomologousFldId;
}
return null;
}
set
{
if (convFieldTab_Sim2.FldId  ==  _AttributeName[intIndex])
{
mstrFldId = value.ToString();
 AddUpdatedFld(convFieldTab_Sim2.FldId);
}
else if (convFieldTab_Sim2.DataTypeId  ==  _AttributeName[intIndex])
{
mstrDataTypeId = value.ToString();
 AddUpdatedFld(convFieldTab_Sim2.DataTypeId);
}
else if (convFieldTab_Sim2.FldName  ==  _AttributeName[intIndex])
{
mstrFldName = value.ToString();
 AddUpdatedFld(convFieldTab_Sim2.FldName);
}
else if (convFieldTab_Sim2.Caption  ==  _AttributeName[intIndex])
{
mstrCaption = value.ToString();
 AddUpdatedFld(convFieldTab_Sim2.Caption);
}
else if (convFieldTab_Sim2.FldLength  ==  _AttributeName[intIndex])
{
mintFldLength = TransNullToInt(value.ToString());
 AddUpdatedFld(convFieldTab_Sim2.FldLength);
}
else if (convFieldTab_Sim2.FldPrecision  ==  _AttributeName[intIndex])
{
mintFldPrecision = TransNullToInt(value.ToString());
 AddUpdatedFld(convFieldTab_Sim2.FldPrecision);
}
else if (convFieldTab_Sim2.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convFieldTab_Sim2.PrjId);
}
else if (convFieldTab_Sim2.FieldTypeId  ==  _AttributeName[intIndex])
{
mstrFieldTypeId = value.ToString();
 AddUpdatedFld(convFieldTab_Sim2.FieldTypeId);
}
else if (convFieldTab_Sim2.HomologousFldId  ==  _AttributeName[intIndex])
{
mstrHomologousFldId = value.ToString();
 AddUpdatedFld(convFieldTab_Sim2.HomologousFldId);
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
 AddUpdatedFld(convFieldTab_Sim2.FldId);
}
}
/// <summary>
/// 数据类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataTypeId
{
get
{
return mstrDataTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataTypeId = value;
}
else
{
 mstrDataTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFieldTab_Sim2.DataTypeId);
}
}
/// <summary>
/// 字段名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FldName
{
get
{
return mstrFldName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldName = value;
}
else
{
 mstrFldName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFieldTab_Sim2.FldName);
}
}
/// <summary>
/// 标题(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Caption
{
get
{
return mstrCaption;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaption = value;
}
else
{
 mstrCaption = value;
}
//记录修改过的字段
 AddUpdatedFld(convFieldTab_Sim2.Caption);
}
}
/// <summary>
/// 字段长度(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int FldLength
{
get
{
return mintFldLength;
}
set
{
 mintFldLength = value;
//记录修改过的字段
 AddUpdatedFld(convFieldTab_Sim2.FldLength);
}
}
/// <summary>
/// 精确度(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? FldPrecision
{
get
{
return mintFldPrecision;
}
set
{
 mintFldPrecision = value;
//记录修改过的字段
 AddUpdatedFld(convFieldTab_Sim2.FldPrecision);
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
 AddUpdatedFld(convFieldTab_Sim2.PrjId);
}
}
/// <summary>
/// 字段类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FieldTypeId
{
get
{
return mstrFieldTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFieldTypeId = value;
}
else
{
 mstrFieldTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFieldTab_Sim2.FieldTypeId);
}
}
/// <summary>
/// 同源字段Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string HomologousFldId
{
get
{
return mstrHomologousFldId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrHomologousFldId = value;
}
else
{
 mstrHomologousFldId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFieldTab_Sim2.HomologousFldId);
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
 /// vFieldTab_Sim2(vFieldTab_Sim2)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convFieldTab_Sim2
{
public const string _CurrTabName = "vFieldTab_Sim2"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FldId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"FldId", "DataTypeId", "FldName", "Caption", "FldLength", "FldPrecision", "PrjId", "FieldTypeId", "HomologousFldId"};
//以下是属性变量


 /// <summary>
 /// 常量:"FldId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldId = "FldId";    //字段Id

 /// <summary>
 /// 常量:"DataTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataTypeId = "DataTypeId";    //数据类型Id

 /// <summary>
 /// 常量:"FldName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldName = "FldName";    //字段名

 /// <summary>
 /// 常量:"Caption"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Caption = "Caption";    //标题

 /// <summary>
 /// 常量:"FldLength"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldLength = "FldLength";    //字段长度

 /// <summary>
 /// 常量:"FldPrecision"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldPrecision = "FldPrecision";    //精确度

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"FieldTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FieldTypeId = "FieldTypeId";    //字段类型Id

 /// <summary>
 /// 常量:"HomologousFldId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string HomologousFldId = "HomologousFldId";    //同源字段Id
}

}