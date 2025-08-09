
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvDnFunctionEN
 表名:vDnFunction(00050553)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:03:20
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
 /// 表vDnFunction的关键字(DnFunctionId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_DnFunctionId_vDnFunction
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strDnFunctionId">表关键字</param>
public K_DnFunctionId_vDnFunction(string strDnFunctionId)
{
if (IsValid(strDnFunctionId)) Value = strDnFunctionId;
else
{
Value = null;
}
}
private static bool IsValid(string strDnFunctionId)
{
if (string.IsNullOrEmpty(strDnFunctionId) == true) return false;
if (strDnFunctionId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_DnFunctionId_vDnFunction]类型的对象</returns>
public static implicit operator K_DnFunctionId_vDnFunction(string value)
{
return new K_DnFunctionId_vDnFunction(value);
}
}
 /// <summary>
 /// vDnFunction(vDnFunction)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvDnFunctionEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vDnFunction"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "DnFunctionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 10;
public static string[] _AttributeName = new string[] {"DnFunctionId", "DnFunctionName", "AssociationMappingId", "AssociationMappingName", "ImportClass", "ImportPath", "PrjId", "UpdDate", "UpdUser", "Memo"};

protected string mstrDnFunctionId;    //DN函数Id
protected string mstrDnFunctionName;    //DN函数
protected string mstrAssociationMappingId;    //关联关系映射Id
protected string mstrAssociationMappingName;    //关联关系映射名
protected string mstrImportClass;    //导入类
protected string mstrImportPath;    //导入路径
protected string mstrPrjId;    //工程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvDnFunctionEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("DnFunctionId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strDnFunctionId">关键字:DN函数Id</param>
public clsvDnFunctionEN(string strDnFunctionId)
 {
strDnFunctionId = strDnFunctionId.Replace("'", "''");
if (strDnFunctionId.Length > 8)
{
throw new Exception("在表:vDnFunction中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strDnFunctionId)  ==  true)
{
throw new Exception("在表:vDnFunction中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strDnFunctionId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrDnFunctionId = strDnFunctionId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("DnFunctionId");
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
if (strAttributeName  ==  convDnFunction.DnFunctionId)
{
return mstrDnFunctionId;
}
else if (strAttributeName  ==  convDnFunction.DnFunctionName)
{
return mstrDnFunctionName;
}
else if (strAttributeName  ==  convDnFunction.AssociationMappingId)
{
return mstrAssociationMappingId;
}
else if (strAttributeName  ==  convDnFunction.AssociationMappingName)
{
return mstrAssociationMappingName;
}
else if (strAttributeName  ==  convDnFunction.ImportClass)
{
return mstrImportClass;
}
else if (strAttributeName  ==  convDnFunction.ImportPath)
{
return mstrImportPath;
}
else if (strAttributeName  ==  convDnFunction.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convDnFunction.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convDnFunction.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convDnFunction.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convDnFunction.DnFunctionId)
{
mstrDnFunctionId = value.ToString();
 AddUpdatedFld(convDnFunction.DnFunctionId);
}
else if (strAttributeName  ==  convDnFunction.DnFunctionName)
{
mstrDnFunctionName = value.ToString();
 AddUpdatedFld(convDnFunction.DnFunctionName);
}
else if (strAttributeName  ==  convDnFunction.AssociationMappingId)
{
mstrAssociationMappingId = value.ToString();
 AddUpdatedFld(convDnFunction.AssociationMappingId);
}
else if (strAttributeName  ==  convDnFunction.AssociationMappingName)
{
mstrAssociationMappingName = value.ToString();
 AddUpdatedFld(convDnFunction.AssociationMappingName);
}
else if (strAttributeName  ==  convDnFunction.ImportClass)
{
mstrImportClass = value.ToString();
 AddUpdatedFld(convDnFunction.ImportClass);
}
else if (strAttributeName  ==  convDnFunction.ImportPath)
{
mstrImportPath = value.ToString();
 AddUpdatedFld(convDnFunction.ImportPath);
}
else if (strAttributeName  ==  convDnFunction.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convDnFunction.PrjId);
}
else if (strAttributeName  ==  convDnFunction.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convDnFunction.UpdDate);
}
else if (strAttributeName  ==  convDnFunction.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convDnFunction.UpdUser);
}
else if (strAttributeName  ==  convDnFunction.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convDnFunction.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convDnFunction.DnFunctionId  ==  _AttributeName[intIndex])
{
return mstrDnFunctionId;
}
else if (convDnFunction.DnFunctionName  ==  _AttributeName[intIndex])
{
return mstrDnFunctionName;
}
else if (convDnFunction.AssociationMappingId  ==  _AttributeName[intIndex])
{
return mstrAssociationMappingId;
}
else if (convDnFunction.AssociationMappingName  ==  _AttributeName[intIndex])
{
return mstrAssociationMappingName;
}
else if (convDnFunction.ImportClass  ==  _AttributeName[intIndex])
{
return mstrImportClass;
}
else if (convDnFunction.ImportPath  ==  _AttributeName[intIndex])
{
return mstrImportPath;
}
else if (convDnFunction.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convDnFunction.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convDnFunction.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convDnFunction.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convDnFunction.DnFunctionId  ==  _AttributeName[intIndex])
{
mstrDnFunctionId = value.ToString();
 AddUpdatedFld(convDnFunction.DnFunctionId);
}
else if (convDnFunction.DnFunctionName  ==  _AttributeName[intIndex])
{
mstrDnFunctionName = value.ToString();
 AddUpdatedFld(convDnFunction.DnFunctionName);
}
else if (convDnFunction.AssociationMappingId  ==  _AttributeName[intIndex])
{
mstrAssociationMappingId = value.ToString();
 AddUpdatedFld(convDnFunction.AssociationMappingId);
}
else if (convDnFunction.AssociationMappingName  ==  _AttributeName[intIndex])
{
mstrAssociationMappingName = value.ToString();
 AddUpdatedFld(convDnFunction.AssociationMappingName);
}
else if (convDnFunction.ImportClass  ==  _AttributeName[intIndex])
{
mstrImportClass = value.ToString();
 AddUpdatedFld(convDnFunction.ImportClass);
}
else if (convDnFunction.ImportPath  ==  _AttributeName[intIndex])
{
mstrImportPath = value.ToString();
 AddUpdatedFld(convDnFunction.ImportPath);
}
else if (convDnFunction.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convDnFunction.PrjId);
}
else if (convDnFunction.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convDnFunction.UpdDate);
}
else if (convDnFunction.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convDnFunction.UpdUser);
}
else if (convDnFunction.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convDnFunction.Memo);
}
}
}

/// <summary>
/// DN函数Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DnFunctionId
{
get
{
return mstrDnFunctionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDnFunctionId = value;
}
else
{
 mstrDnFunctionId = value;
}
//记录修改过的字段
 AddUpdatedFld(convDnFunction.DnFunctionId);
}
}
/// <summary>
/// DN函数(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DnFunctionName
{
get
{
return mstrDnFunctionName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDnFunctionName = value;
}
else
{
 mstrDnFunctionName = value;
}
//记录修改过的字段
 AddUpdatedFld(convDnFunction.DnFunctionName);
}
}
/// <summary>
/// 关联关系映射Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AssociationMappingId
{
get
{
return mstrAssociationMappingId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAssociationMappingId = value;
}
else
{
 mstrAssociationMappingId = value;
}
//记录修改过的字段
 AddUpdatedFld(convDnFunction.AssociationMappingId);
}
}
/// <summary>
/// 关联关系映射名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AssociationMappingName
{
get
{
return mstrAssociationMappingName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAssociationMappingName = value;
}
else
{
 mstrAssociationMappingName = value;
}
//记录修改过的字段
 AddUpdatedFld(convDnFunction.AssociationMappingName);
}
}
/// <summary>
/// 导入类(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ImportClass
{
get
{
return mstrImportClass;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrImportClass = value;
}
else
{
 mstrImportClass = value;
}
//记录修改过的字段
 AddUpdatedFld(convDnFunction.ImportClass);
}
}
/// <summary>
/// 导入路径(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ImportPath
{
get
{
return mstrImportPath;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrImportPath = value;
}
else
{
 mstrImportPath = value;
}
//记录修改过的字段
 AddUpdatedFld(convDnFunction.ImportPath);
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
 AddUpdatedFld(convDnFunction.PrjId);
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
 AddUpdatedFld(convDnFunction.UpdDate);
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
 AddUpdatedFld(convDnFunction.UpdUser);
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
 AddUpdatedFld(convDnFunction.Memo);
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
  return mstrDnFunctionId;
 }
 }
}
 /// <summary>
 /// vDnFunction(vDnFunction)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convDnFunction
{
public const string _CurrTabName = "vDnFunction"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "DnFunctionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"DnFunctionId", "DnFunctionName", "AssociationMappingId", "AssociationMappingName", "ImportClass", "ImportPath", "PrjId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"DnFunctionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DnFunctionId = "DnFunctionId";    //DN函数Id

 /// <summary>
 /// 常量:"DnFunctionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DnFunctionName = "DnFunctionName";    //DN函数

 /// <summary>
 /// 常量:"AssociationMappingId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AssociationMappingId = "AssociationMappingId";    //关联关系映射Id

 /// <summary>
 /// 常量:"AssociationMappingName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AssociationMappingName = "AssociationMappingName";    //关联关系映射名

 /// <summary>
 /// 常量:"ImportClass"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ImportClass = "ImportClass";    //导入类

 /// <summary>
 /// 常量:"ImportPath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ImportPath = "ImportPath";    //导入路径

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改者

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}