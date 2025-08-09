
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscss_StyleEN
 表名:css_Style(00050468)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:01:18
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:样式表管理(CssManage)
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
 /// 表css_Style的关键字(StyleId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_StyleId_css_Style
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strStyleId">表关键字</param>
public K_StyleId_css_Style(string strStyleId)
{
if (IsValid(strStyleId)) Value = strStyleId;
else
{
Value = null;
}
}
private static bool IsValid(string strStyleId)
{
if (string.IsNullOrEmpty(strStyleId) == true) return false;
if (strStyleId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_StyleId_css_Style]类型的对象</returns>
public static implicit operator K_StyleId_css_Style(string value)
{
return new K_StyleId_css_Style(value);
}
}
 /// <summary>
 /// css_Style(css_Style)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clscss_StyleEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "css_Style"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "StyleId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 10;
public static string[] _AttributeName = new string[] {"StyleId", "CtlTypeId", "StyleName", "StyleDesc", "StyleContent", "IsDeleted", "DeletedDate", "UpdDate", "UpdUser", "Memo"};

protected string mstrStyleId;    //样式ID
protected string mstrCtlTypeId;    //控件类型号
protected string mstrStyleName;    //样式名称
protected string mstrStyleDesc;    //样式描述
protected string mstrStyleContent;    //样式内容
protected bool mbolIsDeleted;    //是否删除
protected string mstrDeletedDate;    //删除日期
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clscss_StyleEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("StyleId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strStyleId">关键字:样式ID</param>
public clscss_StyleEN(string strStyleId)
 {
strStyleId = strStyleId.Replace("'", "''");
if (strStyleId.Length > 8)
{
throw new Exception("在表:css_Style中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strStyleId)  ==  true)
{
throw new Exception("在表:css_Style中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strStyleId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrStyleId = strStyleId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("StyleId");
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
if (strAttributeName  ==  concss_Style.StyleId)
{
return mstrStyleId;
}
else if (strAttributeName  ==  concss_Style.CtlTypeId)
{
return mstrCtlTypeId;
}
else if (strAttributeName  ==  concss_Style.StyleName)
{
return mstrStyleName;
}
else if (strAttributeName  ==  concss_Style.StyleDesc)
{
return mstrStyleDesc;
}
else if (strAttributeName  ==  concss_Style.StyleContent)
{
return mstrStyleContent;
}
else if (strAttributeName  ==  concss_Style.IsDeleted)
{
return mbolIsDeleted;
}
else if (strAttributeName  ==  concss_Style.DeletedDate)
{
return mstrDeletedDate;
}
else if (strAttributeName  ==  concss_Style.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  concss_Style.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  concss_Style.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  concss_Style.StyleId)
{
mstrStyleId = value.ToString();
 AddUpdatedFld(concss_Style.StyleId);
}
else if (strAttributeName  ==  concss_Style.CtlTypeId)
{
mstrCtlTypeId = value.ToString();
 AddUpdatedFld(concss_Style.CtlTypeId);
}
else if (strAttributeName  ==  concss_Style.StyleName)
{
mstrStyleName = value.ToString();
 AddUpdatedFld(concss_Style.StyleName);
}
else if (strAttributeName  ==  concss_Style.StyleDesc)
{
mstrStyleDesc = value.ToString();
 AddUpdatedFld(concss_Style.StyleDesc);
}
else if (strAttributeName  ==  concss_Style.StyleContent)
{
mstrStyleContent = value.ToString();
 AddUpdatedFld(concss_Style.StyleContent);
}
else if (strAttributeName  ==  concss_Style.IsDeleted)
{
mbolIsDeleted = TransNullToBool(value.ToString());
 AddUpdatedFld(concss_Style.IsDeleted);
}
else if (strAttributeName  ==  concss_Style.DeletedDate)
{
mstrDeletedDate = value.ToString();
 AddUpdatedFld(concss_Style.DeletedDate);
}
else if (strAttributeName  ==  concss_Style.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concss_Style.UpdDate);
}
else if (strAttributeName  ==  concss_Style.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(concss_Style.UpdUser);
}
else if (strAttributeName  ==  concss_Style.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(concss_Style.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (concss_Style.StyleId  ==  _AttributeName[intIndex])
{
return mstrStyleId;
}
else if (concss_Style.CtlTypeId  ==  _AttributeName[intIndex])
{
return mstrCtlTypeId;
}
else if (concss_Style.StyleName  ==  _AttributeName[intIndex])
{
return mstrStyleName;
}
else if (concss_Style.StyleDesc  ==  _AttributeName[intIndex])
{
return mstrStyleDesc;
}
else if (concss_Style.StyleContent  ==  _AttributeName[intIndex])
{
return mstrStyleContent;
}
else if (concss_Style.IsDeleted  ==  _AttributeName[intIndex])
{
return mbolIsDeleted;
}
else if (concss_Style.DeletedDate  ==  _AttributeName[intIndex])
{
return mstrDeletedDate;
}
else if (concss_Style.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (concss_Style.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (concss_Style.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (concss_Style.StyleId  ==  _AttributeName[intIndex])
{
mstrStyleId = value.ToString();
 AddUpdatedFld(concss_Style.StyleId);
}
else if (concss_Style.CtlTypeId  ==  _AttributeName[intIndex])
{
mstrCtlTypeId = value.ToString();
 AddUpdatedFld(concss_Style.CtlTypeId);
}
else if (concss_Style.StyleName  ==  _AttributeName[intIndex])
{
mstrStyleName = value.ToString();
 AddUpdatedFld(concss_Style.StyleName);
}
else if (concss_Style.StyleDesc  ==  _AttributeName[intIndex])
{
mstrStyleDesc = value.ToString();
 AddUpdatedFld(concss_Style.StyleDesc);
}
else if (concss_Style.StyleContent  ==  _AttributeName[intIndex])
{
mstrStyleContent = value.ToString();
 AddUpdatedFld(concss_Style.StyleContent);
}
else if (concss_Style.IsDeleted  ==  _AttributeName[intIndex])
{
mbolIsDeleted = TransNullToBool(value.ToString());
 AddUpdatedFld(concss_Style.IsDeleted);
}
else if (concss_Style.DeletedDate  ==  _AttributeName[intIndex])
{
mstrDeletedDate = value.ToString();
 AddUpdatedFld(concss_Style.DeletedDate);
}
else if (concss_Style.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concss_Style.UpdDate);
}
else if (concss_Style.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(concss_Style.UpdUser);
}
else if (concss_Style.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(concss_Style.Memo);
}
}
}

/// <summary>
/// 样式ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StyleId
{
get
{
return mstrStyleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStyleId = value;
}
else
{
 mstrStyleId = value;
}
//记录修改过的字段
 AddUpdatedFld(concss_Style.StyleId);
}
}
/// <summary>
/// 控件类型号(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CtlTypeId
{
get
{
return mstrCtlTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCtlTypeId = value;
}
else
{
 mstrCtlTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(concss_Style.CtlTypeId);
}
}
/// <summary>
/// 样式名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StyleName
{
get
{
return mstrStyleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStyleName = value;
}
else
{
 mstrStyleName = value;
}
//记录修改过的字段
 AddUpdatedFld(concss_Style.StyleName);
}
}
/// <summary>
/// 样式描述(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StyleDesc
{
get
{
return mstrStyleDesc;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStyleDesc = value;
}
else
{
 mstrStyleDesc = value;
}
//记录修改过的字段
 AddUpdatedFld(concss_Style.StyleDesc);
}
}
/// <summary>
/// 样式内容(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StyleContent
{
get
{
return mstrStyleContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStyleContent = value;
}
else
{
 mstrStyleContent = value;
}
//记录修改过的字段
 AddUpdatedFld(concss_Style.StyleContent);
}
}
/// <summary>
/// 是否删除(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsDeleted
{
get
{
return mbolIsDeleted;
}
set
{
 mbolIsDeleted = value;
//记录修改过的字段
 AddUpdatedFld(concss_Style.IsDeleted);
}
}
/// <summary>
/// 删除日期(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DeletedDate
{
get
{
return mstrDeletedDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDeletedDate = value;
}
else
{
 mstrDeletedDate = value;
}
//记录修改过的字段
 AddUpdatedFld(concss_Style.DeletedDate);
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
 AddUpdatedFld(concss_Style.UpdDate);
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
 AddUpdatedFld(concss_Style.UpdUser);
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
 AddUpdatedFld(concss_Style.Memo);
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
  return mstrStyleId;
 }
 }
}
 /// <summary>
 /// css_Style(css_Style)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class concss_Style
{
public const string _CurrTabName = "css_Style"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "StyleId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"StyleId", "CtlTypeId", "StyleName", "StyleDesc", "StyleContent", "IsDeleted", "DeletedDate", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"StyleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StyleId = "StyleId";    //样式ID

 /// <summary>
 /// 常量:"CtlTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CtlTypeId = "CtlTypeId";    //控件类型号

 /// <summary>
 /// 常量:"StyleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StyleName = "StyleName";    //样式名称

 /// <summary>
 /// 常量:"StyleDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StyleDesc = "StyleDesc";    //样式描述

 /// <summary>
 /// 常量:"StyleContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StyleContent = "StyleContent";    //样式内容

 /// <summary>
 /// 常量:"IsDeleted"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDeleted = "IsDeleted";    //是否删除

 /// <summary>
 /// 常量:"DeletedDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DeletedDate = "DeletedDate";    //删除日期

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