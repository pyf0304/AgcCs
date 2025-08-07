
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsProductsEN
 表名:Products(00050180)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:34:45
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:产品(Products)
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
 /// 表Products的关键字(ProductsID)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ProductsID_Products
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strProductsID">表关键字</param>
public K_ProductsID_Products(string strProductsID)
{
if (IsValid(strProductsID)) Value = strProductsID;
else
{
Value = null;
}
}
private static bool IsValid(string strProductsID)
{
if (string.IsNullOrEmpty(strProductsID) == true) return false;
if (strProductsID.Length > 6) return false;
if (strProductsID.IndexOf(' ') >= 0) return false;
if (strProductsID.IndexOf(')') >= 0) return false;
if (strProductsID.IndexOf('(') >= 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ProductsID_Products]类型的对象</returns>
public static implicit operator K_ProductsID_Products(string value)
{
return new K_ProductsID_Products(value);
}
}
 /// <summary>
 /// 产品(Products)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsProductsEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "Products"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ProductsID"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 9;
public static string[] _AttributeName = new string[] {"ProductsID", "ProductsName", "ProductsType", "Brand", "Quantity", "Amount", "Salesid", "Memo", "CustomersName"};

protected string mstrProductsID;    //产品编号
protected string mstrProductsName;    //产品名称
protected string mstrProductsType;    //产品类型
protected string mstrBrand;    //品牌
protected string mstrQuantity;    //数量
protected string mstrAmount;    //金额
protected string mstrSalesid;    //销售单号
protected string mstrMemo;    //说明
protected string mstrCustomersName;    //购买客户人

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsProductsEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ProductsID");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strProductsID">关键字:产品编号</param>
public clsProductsEN(string strProductsID)
 {
strProductsID = strProductsID.Replace("'", "''");
if (strProductsID.Length > 6)
{
throw new Exception("在表:Products中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strProductsID)  ==  true)
{
throw new Exception("在表:Products中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strProductsID);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrProductsID = strProductsID;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ProductsID");
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
if (strAttributeName  ==  conProducts.ProductsID)
{
return mstrProductsID;
}
else if (strAttributeName  ==  conProducts.ProductsName)
{
return mstrProductsName;
}
else if (strAttributeName  ==  conProducts.ProductsType)
{
return mstrProductsType;
}
else if (strAttributeName  ==  conProducts.Brand)
{
return mstrBrand;
}
else if (strAttributeName  ==  conProducts.Quantity)
{
return mstrQuantity;
}
else if (strAttributeName  ==  conProducts.Amount)
{
return mstrAmount;
}
else if (strAttributeName  ==  conProducts.Salesid)
{
return mstrSalesid;
}
else if (strAttributeName  ==  conProducts.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conProducts.CustomersName)
{
return mstrCustomersName;
}
return null;
}
set
{
if (strAttributeName  ==  conProducts.ProductsID)
{
mstrProductsID = value.ToString();
 AddUpdatedFld(conProducts.ProductsID);
}
else if (strAttributeName  ==  conProducts.ProductsName)
{
mstrProductsName = value.ToString();
 AddUpdatedFld(conProducts.ProductsName);
}
else if (strAttributeName  ==  conProducts.ProductsType)
{
mstrProductsType = value.ToString();
 AddUpdatedFld(conProducts.ProductsType);
}
else if (strAttributeName  ==  conProducts.Brand)
{
mstrBrand = value.ToString();
 AddUpdatedFld(conProducts.Brand);
}
else if (strAttributeName  ==  conProducts.Quantity)
{
mstrQuantity = value.ToString();
 AddUpdatedFld(conProducts.Quantity);
}
else if (strAttributeName  ==  conProducts.Amount)
{
mstrAmount = value.ToString();
 AddUpdatedFld(conProducts.Amount);
}
else if (strAttributeName  ==  conProducts.Salesid)
{
mstrSalesid = value.ToString();
 AddUpdatedFld(conProducts.Salesid);
}
else if (strAttributeName  ==  conProducts.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conProducts.Memo);
}
else if (strAttributeName  ==  conProducts.CustomersName)
{
mstrCustomersName = value.ToString();
 AddUpdatedFld(conProducts.CustomersName);
}
}
}
public object this[int intIndex]
{
get
{
if (conProducts.ProductsID  ==  _AttributeName[intIndex])
{
return mstrProductsID;
}
else if (conProducts.ProductsName  ==  _AttributeName[intIndex])
{
return mstrProductsName;
}
else if (conProducts.ProductsType  ==  _AttributeName[intIndex])
{
return mstrProductsType;
}
else if (conProducts.Brand  ==  _AttributeName[intIndex])
{
return mstrBrand;
}
else if (conProducts.Quantity  ==  _AttributeName[intIndex])
{
return mstrQuantity;
}
else if (conProducts.Amount  ==  _AttributeName[intIndex])
{
return mstrAmount;
}
else if (conProducts.Salesid  ==  _AttributeName[intIndex])
{
return mstrSalesid;
}
else if (conProducts.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (conProducts.CustomersName  ==  _AttributeName[intIndex])
{
return mstrCustomersName;
}
return null;
}
set
{
if (conProducts.ProductsID  ==  _AttributeName[intIndex])
{
mstrProductsID = value.ToString();
 AddUpdatedFld(conProducts.ProductsID);
}
else if (conProducts.ProductsName  ==  _AttributeName[intIndex])
{
mstrProductsName = value.ToString();
 AddUpdatedFld(conProducts.ProductsName);
}
else if (conProducts.ProductsType  ==  _AttributeName[intIndex])
{
mstrProductsType = value.ToString();
 AddUpdatedFld(conProducts.ProductsType);
}
else if (conProducts.Brand  ==  _AttributeName[intIndex])
{
mstrBrand = value.ToString();
 AddUpdatedFld(conProducts.Brand);
}
else if (conProducts.Quantity  ==  _AttributeName[intIndex])
{
mstrQuantity = value.ToString();
 AddUpdatedFld(conProducts.Quantity);
}
else if (conProducts.Amount  ==  _AttributeName[intIndex])
{
mstrAmount = value.ToString();
 AddUpdatedFld(conProducts.Amount);
}
else if (conProducts.Salesid  ==  _AttributeName[intIndex])
{
mstrSalesid = value.ToString();
 AddUpdatedFld(conProducts.Salesid);
}
else if (conProducts.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conProducts.Memo);
}
else if (conProducts.CustomersName  ==  _AttributeName[intIndex])
{
mstrCustomersName = value.ToString();
 AddUpdatedFld(conProducts.CustomersName);
}
}
}

/// <summary>
/// 产品编号(说明:;字段类型:varchar;字段长度:6;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProductsID
{
get
{
return mstrProductsID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProductsID = value;
}
else
{
 mstrProductsID = value;
}
//记录修改过的字段
 AddUpdatedFld(conProducts.ProductsID);
}
}
/// <summary>
/// 产品名称(说明:;字段类型:varchar;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProductsName
{
get
{
return mstrProductsName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProductsName = value;
}
else
{
 mstrProductsName = value;
}
//记录修改过的字段
 AddUpdatedFld(conProducts.ProductsName);
}
}
/// <summary>
/// 产品类型(说明:;字段类型:varchar;字段长度:6;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProductsType
{
get
{
return mstrProductsType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProductsType = value;
}
else
{
 mstrProductsType = value;
}
//记录修改过的字段
 AddUpdatedFld(conProducts.ProductsType);
}
}
/// <summary>
/// 品牌(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Brand
{
get
{
return mstrBrand;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrBrand = value;
}
else
{
 mstrBrand = value;
}
//记录修改过的字段
 AddUpdatedFld(conProducts.Brand);
}
}
/// <summary>
/// 数量(说明:;字段类型:varchar;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Quantity
{
get
{
return mstrQuantity;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuantity = value;
}
else
{
 mstrQuantity = value;
}
//记录修改过的字段
 AddUpdatedFld(conProducts.Quantity);
}
}
/// <summary>
/// 金额(说明:;字段类型:varchar;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Amount
{
get
{
return mstrAmount;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAmount = value;
}
else
{
 mstrAmount = value;
}
//记录修改过的字段
 AddUpdatedFld(conProducts.Amount);
}
}
/// <summary>
/// 销售单号(说明:;字段类型:varchar;字段长度:6;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Salesid
{
get
{
return mstrSalesid;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSalesid = value;
}
else
{
 mstrSalesid = value;
}
//记录修改过的字段
 AddUpdatedFld(conProducts.Salesid);
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
 AddUpdatedFld(conProducts.Memo);
}
}
/// <summary>
/// 购买客户人(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CustomersName
{
get
{
return mstrCustomersName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCustomersName = value;
}
else
{
 mstrCustomersName = value;
}
//记录修改过的字段
 AddUpdatedFld(conProducts.CustomersName);
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
  return mstrProductsID;
 }
 }
}
 /// <summary>
 /// 产品(Products)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conProducts
{
public const string _CurrTabName = "Products"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ProductsID"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"ProductsID", "ProductsName", "ProductsType", "Brand", "Quantity", "Amount", "Salesid", "Memo", "CustomersName"};
//以下是属性变量


 /// <summary>
 /// 常量:"ProductsID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProductsID = "ProductsID";    //产品编号

 /// <summary>
 /// 常量:"ProductsName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProductsName = "ProductsName";    //产品名称

 /// <summary>
 /// 常量:"ProductsType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProductsType = "ProductsType";    //产品类型

 /// <summary>
 /// 常量:"Brand"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Brand = "Brand";    //品牌

 /// <summary>
 /// 常量:"Quantity"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Quantity = "Quantity";    //数量

 /// <summary>
 /// 常量:"Amount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Amount = "Amount";    //金额

 /// <summary>
 /// 常量:"Salesid"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Salesid = "Salesid";    //销售单号

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明

 /// <summary>
 /// 常量:"CustomersName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CustomersName = "CustomersName";    //购买客户人
}

}