
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsErrorInformationEN
 表名:ErrorInformation(00050185)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:34:07
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:日志管理(LogManage)
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
 /// 表ErrorInformation的关键字(ErrorID)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ErrorID_ErrorInformation
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngErrorID">表关键字</param>
public K_ErrorID_ErrorInformation(long lngErrorID)
{
if (IsValid(lngErrorID)) Value = lngErrorID;
else
{
Value = 0;
}
}
private static bool IsValid(long lngErrorID)
{
if (lngErrorID == 0) return false;
if (lngErrorID == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ErrorID_ErrorInformation]类型的对象</returns>
public static implicit operator K_ErrorID_ErrorInformation(long value)
{
return new K_ErrorID_ErrorInformation(value);
}
}
 /// <summary>
 /// 错误(ErrorInformation)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsErrorInformationEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ErrorInformation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ErrorID"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 6;
public static string[] _AttributeName = new string[] {"ErrorID", "PageName", "FunctionName", "ErrorInformation", "UserId", "CreateTime"};

protected long mlngErrorID;    //错误流水号
protected string mstrPageName;    //页面名称
protected string mstrFunctionName;    //功能名称
protected string mstrErrorInformation;    //错误信息
protected string mstrUserId;    //用户Id
protected DateTime mdteCreateTime;    //创建时间

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsErrorInformationEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ErrorID");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "lngErrorID">关键字:错误流水号</param>
public clsErrorInformationEN(long lngErrorID)
 {
 if (lngErrorID  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngErrorID = lngErrorID;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ErrorID");
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
if (strAttributeName  ==  conErrorInformation.ErrorID)
{
return mlngErrorID;
}
else if (strAttributeName  ==  conErrorInformation.PageName)
{
return mstrPageName;
}
else if (strAttributeName  ==  conErrorInformation.FunctionName)
{
return mstrFunctionName;
}
else if (strAttributeName  ==  conErrorInformation.ErrorInformation)
{
return mstrErrorInformation;
}
else if (strAttributeName  ==  conErrorInformation.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conErrorInformation.CreateTime)
{
return mdteCreateTime;
}
return null;
}
set
{
if (strAttributeName  ==  conErrorInformation.ErrorID)
{
mlngErrorID = TransNullToInt(value.ToString());
 AddUpdatedFld(conErrorInformation.ErrorID);
}
else if (strAttributeName  ==  conErrorInformation.PageName)
{
mstrPageName = value.ToString();
 AddUpdatedFld(conErrorInformation.PageName);
}
else if (strAttributeName  ==  conErrorInformation.FunctionName)
{
mstrFunctionName = value.ToString();
 AddUpdatedFld(conErrorInformation.FunctionName);
}
else if (strAttributeName  ==  conErrorInformation.ErrorInformation)
{
mstrErrorInformation = value.ToString();
 AddUpdatedFld(conErrorInformation.ErrorInformation);
}
else if (strAttributeName  ==  conErrorInformation.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conErrorInformation.UserId);
}
else if (strAttributeName  ==  conErrorInformation.CreateTime)
{
mdteCreateTime = TransNullToDate(value.ToString());
 AddUpdatedFld(conErrorInformation.CreateTime);
}
}
}
public object this[int intIndex]
{
get
{
if (conErrorInformation.ErrorID  ==  _AttributeName[intIndex])
{
return mlngErrorID;
}
else if (conErrorInformation.PageName  ==  _AttributeName[intIndex])
{
return mstrPageName;
}
else if (conErrorInformation.FunctionName  ==  _AttributeName[intIndex])
{
return mstrFunctionName;
}
else if (conErrorInformation.ErrorInformation  ==  _AttributeName[intIndex])
{
return mstrErrorInformation;
}
else if (conErrorInformation.UserId  ==  _AttributeName[intIndex])
{
return mstrUserId;
}
else if (conErrorInformation.CreateTime  ==  _AttributeName[intIndex])
{
return mdteCreateTime;
}
return null;
}
set
{
if (conErrorInformation.ErrorID  ==  _AttributeName[intIndex])
{
mlngErrorID = TransNullToInt(value.ToString());
 AddUpdatedFld(conErrorInformation.ErrorID);
}
else if (conErrorInformation.PageName  ==  _AttributeName[intIndex])
{
mstrPageName = value.ToString();
 AddUpdatedFld(conErrorInformation.PageName);
}
else if (conErrorInformation.FunctionName  ==  _AttributeName[intIndex])
{
mstrFunctionName = value.ToString();
 AddUpdatedFld(conErrorInformation.FunctionName);
}
else if (conErrorInformation.ErrorInformation  ==  _AttributeName[intIndex])
{
mstrErrorInformation = value.ToString();
 AddUpdatedFld(conErrorInformation.ErrorInformation);
}
else if (conErrorInformation.UserId  ==  _AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conErrorInformation.UserId);
}
else if (conErrorInformation.CreateTime  ==  _AttributeName[intIndex])
{
mdteCreateTime = TransNullToDate(value.ToString());
 AddUpdatedFld(conErrorInformation.CreateTime);
}
}
}

/// <summary>
/// 错误流水号(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long ErrorID
{
get
{
return mlngErrorID;
}
set
{
 mlngErrorID = value;
//记录修改过的字段
 AddUpdatedFld(conErrorInformation.ErrorID);
}
}
/// <summary>
/// 页面名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PageName
{
get
{
return mstrPageName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPageName = value;
}
else
{
 mstrPageName = value;
}
//记录修改过的字段
 AddUpdatedFld(conErrorInformation.PageName);
}
}
/// <summary>
/// 功能名称(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FunctionName
{
get
{
return mstrFunctionName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFunctionName = value;
}
else
{
 mstrFunctionName = value;
}
//记录修改过的字段
 AddUpdatedFld(conErrorInformation.FunctionName);
}
}
/// <summary>
/// 错误信息(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ErrorInformation
{
get
{
return mstrErrorInformation;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrErrorInformation = value;
}
else
{
 mstrErrorInformation = value;
}
//记录修改过的字段
 AddUpdatedFld(conErrorInformation.ErrorInformation);
}
}
/// <summary>
/// 用户Id(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserId
{
get
{
return mstrUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserId = value;
}
else
{
 mstrUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conErrorInformation.UserId);
}
}
/// <summary>
/// 创建时间(说明:;字段类型:datetime;字段长度:16;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public DateTime CreateTime
{
get
{
return mdteCreateTime;
}
set
{
 mdteCreateTime = value;
//记录修改过的字段
 AddUpdatedFld(conErrorInformation.CreateTime);
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
  return mlngErrorID.ToString();
 }
 }
}
 /// <summary>
 /// 错误(ErrorInformation)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conErrorInformation
{
public const string _CurrTabName = "ErrorInformation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ErrorID"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"ErrorID", "PageName", "FunctionName", "ErrorInformation", "UserId", "CreateTime"};
//以下是属性变量


 /// <summary>
 /// 常量:"ErrorID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ErrorID = "ErrorID";    //错误流水号

 /// <summary>
 /// 常量:"PageName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PageName = "PageName";    //页面名称

 /// <summary>
 /// 常量:"FunctionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FunctionName = "FunctionName";    //功能名称

 /// <summary>
 /// 常量:"ErrorInformation"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ErrorInformation = "ErrorInformation";    //错误信息

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户Id

 /// <summary>
 /// 常量:"CreateTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreateTime = "CreateTime";    //创建时间
}

}