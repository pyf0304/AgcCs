
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewMasterEN
 表名:vViewMaster(00050558)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:37:08
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
 /// 表vViewMaster的关键字(ViewMasterId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ViewMasterId_vViewMaster
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strViewMasterId">表关键字</param>
public K_ViewMasterId_vViewMaster(string strViewMasterId)
{
if (IsValid(strViewMasterId)) Value = strViewMasterId;
else
{
Value = null;
}
}
private static bool IsValid(string strViewMasterId)
{
if (string.IsNullOrEmpty(strViewMasterId) == true) return false;
if (strViewMasterId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ViewMasterId_vViewMaster]类型的对象</returns>
public static implicit operator K_ViewMasterId_vViewMaster(string value)
{
return new K_ViewMasterId_vViewMaster(value);
}
}
 /// <summary>
 /// vViewMaster(vViewMaster)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvViewMasterEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vViewMaster"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ViewMasterId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 10;
public static string[] _AttributeName = new string[] {"ViewMasterId", "ViewMasterName", "ViewMasterPath", "ApplicationTypeId", "ApplicationTypeName", "ApplicationTypeSimName", "PrjId", "UpdDate", "UpdUser", "Memo"};

protected string mstrViewMasterId;    //界面母版Id
protected string mstrViewMasterName;    //界面母版名
protected string mstrViewMasterPath;    //界面母版路径
protected int mintApplicationTypeId;    //应用程序类型ID
protected string mstrApplicationTypeName;    //应用程序类型名称
protected string mstrApplicationTypeSimName;    //应用程序类型简称
protected string mstrPrjId;    //工程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvViewMasterEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ViewMasterId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strViewMasterId">关键字:界面母版Id</param>
public clsvViewMasterEN(string strViewMasterId)
 {
strViewMasterId = strViewMasterId.Replace("'", "''");
if (strViewMasterId.Length > 8)
{
throw new Exception("在表:vViewMaster中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strViewMasterId)  ==  true)
{
throw new Exception("在表:vViewMaster中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strViewMasterId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrViewMasterId = strViewMasterId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ViewMasterId");
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
if (strAttributeName  ==  convViewMaster.ViewMasterId)
{
return mstrViewMasterId;
}
else if (strAttributeName  ==  convViewMaster.ViewMasterName)
{
return mstrViewMasterName;
}
else if (strAttributeName  ==  convViewMaster.ViewMasterPath)
{
return mstrViewMasterPath;
}
else if (strAttributeName  ==  convViewMaster.ApplicationTypeId)
{
return mintApplicationTypeId;
}
else if (strAttributeName  ==  convViewMaster.ApplicationTypeName)
{
return mstrApplicationTypeName;
}
else if (strAttributeName  ==  convViewMaster.ApplicationTypeSimName)
{
return mstrApplicationTypeSimName;
}
else if (strAttributeName  ==  convViewMaster.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convViewMaster.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convViewMaster.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convViewMaster.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convViewMaster.ViewMasterId)
{
mstrViewMasterId = value.ToString();
 AddUpdatedFld(convViewMaster.ViewMasterId);
}
else if (strAttributeName  ==  convViewMaster.ViewMasterName)
{
mstrViewMasterName = value.ToString();
 AddUpdatedFld(convViewMaster.ViewMasterName);
}
else if (strAttributeName  ==  convViewMaster.ViewMasterPath)
{
mstrViewMasterPath = value.ToString();
 AddUpdatedFld(convViewMaster.ViewMasterPath);
}
else if (strAttributeName  ==  convViewMaster.ApplicationTypeId)
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewMaster.ApplicationTypeId);
}
else if (strAttributeName  ==  convViewMaster.ApplicationTypeName)
{
mstrApplicationTypeName = value.ToString();
 AddUpdatedFld(convViewMaster.ApplicationTypeName);
}
else if (strAttributeName  ==  convViewMaster.ApplicationTypeSimName)
{
mstrApplicationTypeSimName = value.ToString();
 AddUpdatedFld(convViewMaster.ApplicationTypeSimName);
}
else if (strAttributeName  ==  convViewMaster.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convViewMaster.PrjId);
}
else if (strAttributeName  ==  convViewMaster.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convViewMaster.UpdDate);
}
else if (strAttributeName  ==  convViewMaster.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convViewMaster.UpdUser);
}
else if (strAttributeName  ==  convViewMaster.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convViewMaster.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convViewMaster.ViewMasterId  ==  _AttributeName[intIndex])
{
return mstrViewMasterId;
}
else if (convViewMaster.ViewMasterName  ==  _AttributeName[intIndex])
{
return mstrViewMasterName;
}
else if (convViewMaster.ViewMasterPath  ==  _AttributeName[intIndex])
{
return mstrViewMasterPath;
}
else if (convViewMaster.ApplicationTypeId  ==  _AttributeName[intIndex])
{
return mintApplicationTypeId;
}
else if (convViewMaster.ApplicationTypeName  ==  _AttributeName[intIndex])
{
return mstrApplicationTypeName;
}
else if (convViewMaster.ApplicationTypeSimName  ==  _AttributeName[intIndex])
{
return mstrApplicationTypeSimName;
}
else if (convViewMaster.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convViewMaster.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convViewMaster.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convViewMaster.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convViewMaster.ViewMasterId  ==  _AttributeName[intIndex])
{
mstrViewMasterId = value.ToString();
 AddUpdatedFld(convViewMaster.ViewMasterId);
}
else if (convViewMaster.ViewMasterName  ==  _AttributeName[intIndex])
{
mstrViewMasterName = value.ToString();
 AddUpdatedFld(convViewMaster.ViewMasterName);
}
else if (convViewMaster.ViewMasterPath  ==  _AttributeName[intIndex])
{
mstrViewMasterPath = value.ToString();
 AddUpdatedFld(convViewMaster.ViewMasterPath);
}
else if (convViewMaster.ApplicationTypeId  ==  _AttributeName[intIndex])
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewMaster.ApplicationTypeId);
}
else if (convViewMaster.ApplicationTypeName  ==  _AttributeName[intIndex])
{
mstrApplicationTypeName = value.ToString();
 AddUpdatedFld(convViewMaster.ApplicationTypeName);
}
else if (convViewMaster.ApplicationTypeSimName  ==  _AttributeName[intIndex])
{
mstrApplicationTypeSimName = value.ToString();
 AddUpdatedFld(convViewMaster.ApplicationTypeSimName);
}
else if (convViewMaster.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convViewMaster.PrjId);
}
else if (convViewMaster.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convViewMaster.UpdDate);
}
else if (convViewMaster.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convViewMaster.UpdUser);
}
else if (convViewMaster.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convViewMaster.Memo);
}
}
}

/// <summary>
/// 界面母版Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewMasterId
{
get
{
return mstrViewMasterId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewMasterId = value;
}
else
{
 mstrViewMasterId = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewMaster.ViewMasterId);
}
}
/// <summary>
/// 界面母版名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewMasterName
{
get
{
return mstrViewMasterName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewMasterName = value;
}
else
{
 mstrViewMasterName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewMaster.ViewMasterName);
}
}
/// <summary>
/// 界面母版路径(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewMasterPath
{
get
{
return mstrViewMasterPath;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewMasterPath = value;
}
else
{
 mstrViewMasterPath = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewMaster.ViewMasterPath);
}
}
/// <summary>
/// 应用程序类型ID(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int ApplicationTypeId
{
get
{
return mintApplicationTypeId;
}
set
{
 mintApplicationTypeId = value;
//记录修改过的字段
 AddUpdatedFld(convViewMaster.ApplicationTypeId);
}
}
/// <summary>
/// 应用程序类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ApplicationTypeName
{
get
{
return mstrApplicationTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrApplicationTypeName = value;
}
else
{
 mstrApplicationTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewMaster.ApplicationTypeName);
}
}
/// <summary>
/// 应用程序类型简称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ApplicationTypeSimName
{
get
{
return mstrApplicationTypeSimName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrApplicationTypeSimName = value;
}
else
{
 mstrApplicationTypeSimName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewMaster.ApplicationTypeSimName);
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
 AddUpdatedFld(convViewMaster.PrjId);
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
 AddUpdatedFld(convViewMaster.UpdDate);
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
 AddUpdatedFld(convViewMaster.UpdUser);
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
 AddUpdatedFld(convViewMaster.Memo);
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
  return mstrViewMasterId;
 }
 }
}
 /// <summary>
 /// vViewMaster(vViewMaster)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convViewMaster
{
public const string _CurrTabName = "vViewMaster"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ViewMasterId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"ViewMasterId", "ViewMasterName", "ViewMasterPath", "ApplicationTypeId", "ApplicationTypeName", "ApplicationTypeSimName", "PrjId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"ViewMasterId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewMasterId = "ViewMasterId";    //界面母版Id

 /// <summary>
 /// 常量:"ViewMasterName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewMasterName = "ViewMasterName";    //界面母版名

 /// <summary>
 /// 常量:"ViewMasterPath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewMasterPath = "ViewMasterPath";    //界面母版路径

 /// <summary>
 /// 常量:"ApplicationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeId = "ApplicationTypeId";    //应用程序类型ID

 /// <summary>
 /// 常量:"ApplicationTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeName = "ApplicationTypeName";    //应用程序类型名称

 /// <summary>
 /// 常量:"ApplicationTypeSimName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeSimName = "ApplicationTypeSimName";    //应用程序类型简称

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