
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscss_FldDispUnitStyleEN
 表名:css_FldDispUnitStyle(00050615)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:31:27
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
 /// 表css_FldDispUnitStyle的关键字(FldDispUnitStyleId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_FldDispUnitStyleId_css_FldDispUnitStyle
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strFldDispUnitStyleId">表关键字</param>
public K_FldDispUnitStyleId_css_FldDispUnitStyle(string strFldDispUnitStyleId)
{
if (IsValid(strFldDispUnitStyleId)) Value = strFldDispUnitStyleId;
else
{
Value = null;
}
}
private static bool IsValid(string strFldDispUnitStyleId)
{
if (string.IsNullOrEmpty(strFldDispUnitStyleId) == true) return false;
if (strFldDispUnitStyleId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_FldDispUnitStyleId_css_FldDispUnitStyle]类型的对象</returns>
public static implicit operator K_FldDispUnitStyleId_css_FldDispUnitStyle(string value)
{
return new K_FldDispUnitStyleId_css_FldDispUnitStyle(value);
}
}
 /// <summary>
 /// 字段显示单元样式(css_FldDispUnitStyle)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clscss_FldDispUnitStyleEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "css_FldDispUnitStyle"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "FldDispUnitStyleId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 14;
public static string[] _AttributeName = new string[] {"FldDispUnitStyleId", "FldDispUnitStyleName", "FldDispUnitStyleDesc", "StyleIdContent", "StyleIdTitle", "FldDispUnitStyleContent", "FldDispUnitFormat", "CtlTypeId", "OrderNum", "DeletedDate", "IsDeleted", "UpdDate", "UpdUser", "Memo"};

protected string mstrFldDispUnitStyleId;    //字段显示单元样式Id
protected string mstrFldDispUnitStyleName;    //字段显示单元样式名称
protected string mstrFldDispUnitStyleDesc;    //样式描述
protected string mstrStyleIdContent;    //内容样式Id
protected string mstrStyleIdTitle;    //标题样式Id
protected string mstrFldDispUnitStyleContent;    //样式内容
protected string mstrFldDispUnitFormat;    //字段显示单元格式
protected string mstrCtlTypeId;    //控件类型号
protected int? mintOrderNum;    //序号
protected string mstrDeletedDate;    //删除日期
protected bool mbolIsDeleted;    //是否删除
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clscss_FldDispUnitStyleEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FldDispUnitStyleId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strFldDispUnitStyleId">关键字:字段显示单元样式Id</param>
public clscss_FldDispUnitStyleEN(string strFldDispUnitStyleId)
 {
strFldDispUnitStyleId = strFldDispUnitStyleId.Replace("'", "''");
if (strFldDispUnitStyleId.Length > 8)
{
throw new Exception("在表:css_FldDispUnitStyle中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strFldDispUnitStyleId)  ==  true)
{
throw new Exception("在表:css_FldDispUnitStyle中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFldDispUnitStyleId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrFldDispUnitStyleId = strFldDispUnitStyleId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FldDispUnitStyleId");
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
if (strAttributeName  ==  concss_FldDispUnitStyle.FldDispUnitStyleId)
{
return mstrFldDispUnitStyleId;
}
else if (strAttributeName  ==  concss_FldDispUnitStyle.FldDispUnitStyleName)
{
return mstrFldDispUnitStyleName;
}
else if (strAttributeName  ==  concss_FldDispUnitStyle.FldDispUnitStyleDesc)
{
return mstrFldDispUnitStyleDesc;
}
else if (strAttributeName  ==  concss_FldDispUnitStyle.StyleIdContent)
{
return mstrStyleIdContent;
}
else if (strAttributeName  ==  concss_FldDispUnitStyle.StyleIdTitle)
{
return mstrStyleIdTitle;
}
else if (strAttributeName  ==  concss_FldDispUnitStyle.FldDispUnitStyleContent)
{
return mstrFldDispUnitStyleContent;
}
else if (strAttributeName  ==  concss_FldDispUnitStyle.FldDispUnitFormat)
{
return mstrFldDispUnitFormat;
}
else if (strAttributeName  ==  concss_FldDispUnitStyle.CtlTypeId)
{
return mstrCtlTypeId;
}
else if (strAttributeName  ==  concss_FldDispUnitStyle.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  concss_FldDispUnitStyle.DeletedDate)
{
return mstrDeletedDate;
}
else if (strAttributeName  ==  concss_FldDispUnitStyle.IsDeleted)
{
return mbolIsDeleted;
}
else if (strAttributeName  ==  concss_FldDispUnitStyle.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  concss_FldDispUnitStyle.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  concss_FldDispUnitStyle.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  concss_FldDispUnitStyle.FldDispUnitStyleId)
{
mstrFldDispUnitStyleId = value.ToString();
 AddUpdatedFld(concss_FldDispUnitStyle.FldDispUnitStyleId);
}
else if (strAttributeName  ==  concss_FldDispUnitStyle.FldDispUnitStyleName)
{
mstrFldDispUnitStyleName = value.ToString();
 AddUpdatedFld(concss_FldDispUnitStyle.FldDispUnitStyleName);
}
else if (strAttributeName  ==  concss_FldDispUnitStyle.FldDispUnitStyleDesc)
{
mstrFldDispUnitStyleDesc = value.ToString();
 AddUpdatedFld(concss_FldDispUnitStyle.FldDispUnitStyleDesc);
}
else if (strAttributeName  ==  concss_FldDispUnitStyle.StyleIdContent)
{
mstrStyleIdContent = value.ToString();
 AddUpdatedFld(concss_FldDispUnitStyle.StyleIdContent);
}
else if (strAttributeName  ==  concss_FldDispUnitStyle.StyleIdTitle)
{
mstrStyleIdTitle = value.ToString();
 AddUpdatedFld(concss_FldDispUnitStyle.StyleIdTitle);
}
else if (strAttributeName  ==  concss_FldDispUnitStyle.FldDispUnitStyleContent)
{
mstrFldDispUnitStyleContent = value.ToString();
 AddUpdatedFld(concss_FldDispUnitStyle.FldDispUnitStyleContent);
}
else if (strAttributeName  ==  concss_FldDispUnitStyle.FldDispUnitFormat)
{
mstrFldDispUnitFormat = value.ToString();
 AddUpdatedFld(concss_FldDispUnitStyle.FldDispUnitFormat);
}
else if (strAttributeName  ==  concss_FldDispUnitStyle.CtlTypeId)
{
mstrCtlTypeId = value.ToString();
 AddUpdatedFld(concss_FldDispUnitStyle.CtlTypeId);
}
else if (strAttributeName  ==  concss_FldDispUnitStyle.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(concss_FldDispUnitStyle.OrderNum);
}
else if (strAttributeName  ==  concss_FldDispUnitStyle.DeletedDate)
{
mstrDeletedDate = value.ToString();
 AddUpdatedFld(concss_FldDispUnitStyle.DeletedDate);
}
else if (strAttributeName  ==  concss_FldDispUnitStyle.IsDeleted)
{
mbolIsDeleted = TransNullToBool(value.ToString());
 AddUpdatedFld(concss_FldDispUnitStyle.IsDeleted);
}
else if (strAttributeName  ==  concss_FldDispUnitStyle.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concss_FldDispUnitStyle.UpdDate);
}
else if (strAttributeName  ==  concss_FldDispUnitStyle.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(concss_FldDispUnitStyle.UpdUser);
}
else if (strAttributeName  ==  concss_FldDispUnitStyle.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(concss_FldDispUnitStyle.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (concss_FldDispUnitStyle.FldDispUnitStyleId  ==  _AttributeName[intIndex])
{
return mstrFldDispUnitStyleId;
}
else if (concss_FldDispUnitStyle.FldDispUnitStyleName  ==  _AttributeName[intIndex])
{
return mstrFldDispUnitStyleName;
}
else if (concss_FldDispUnitStyle.FldDispUnitStyleDesc  ==  _AttributeName[intIndex])
{
return mstrFldDispUnitStyleDesc;
}
else if (concss_FldDispUnitStyle.StyleIdContent  ==  _AttributeName[intIndex])
{
return mstrStyleIdContent;
}
else if (concss_FldDispUnitStyle.StyleIdTitle  ==  _AttributeName[intIndex])
{
return mstrStyleIdTitle;
}
else if (concss_FldDispUnitStyle.FldDispUnitStyleContent  ==  _AttributeName[intIndex])
{
return mstrFldDispUnitStyleContent;
}
else if (concss_FldDispUnitStyle.FldDispUnitFormat  ==  _AttributeName[intIndex])
{
return mstrFldDispUnitFormat;
}
else if (concss_FldDispUnitStyle.CtlTypeId  ==  _AttributeName[intIndex])
{
return mstrCtlTypeId;
}
else if (concss_FldDispUnitStyle.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (concss_FldDispUnitStyle.DeletedDate  ==  _AttributeName[intIndex])
{
return mstrDeletedDate;
}
else if (concss_FldDispUnitStyle.IsDeleted  ==  _AttributeName[intIndex])
{
return mbolIsDeleted;
}
else if (concss_FldDispUnitStyle.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (concss_FldDispUnitStyle.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (concss_FldDispUnitStyle.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (concss_FldDispUnitStyle.FldDispUnitStyleId  ==  _AttributeName[intIndex])
{
mstrFldDispUnitStyleId = value.ToString();
 AddUpdatedFld(concss_FldDispUnitStyle.FldDispUnitStyleId);
}
else if (concss_FldDispUnitStyle.FldDispUnitStyleName  ==  _AttributeName[intIndex])
{
mstrFldDispUnitStyleName = value.ToString();
 AddUpdatedFld(concss_FldDispUnitStyle.FldDispUnitStyleName);
}
else if (concss_FldDispUnitStyle.FldDispUnitStyleDesc  ==  _AttributeName[intIndex])
{
mstrFldDispUnitStyleDesc = value.ToString();
 AddUpdatedFld(concss_FldDispUnitStyle.FldDispUnitStyleDesc);
}
else if (concss_FldDispUnitStyle.StyleIdContent  ==  _AttributeName[intIndex])
{
mstrStyleIdContent = value.ToString();
 AddUpdatedFld(concss_FldDispUnitStyle.StyleIdContent);
}
else if (concss_FldDispUnitStyle.StyleIdTitle  ==  _AttributeName[intIndex])
{
mstrStyleIdTitle = value.ToString();
 AddUpdatedFld(concss_FldDispUnitStyle.StyleIdTitle);
}
else if (concss_FldDispUnitStyle.FldDispUnitStyleContent  ==  _AttributeName[intIndex])
{
mstrFldDispUnitStyleContent = value.ToString();
 AddUpdatedFld(concss_FldDispUnitStyle.FldDispUnitStyleContent);
}
else if (concss_FldDispUnitStyle.FldDispUnitFormat  ==  _AttributeName[intIndex])
{
mstrFldDispUnitFormat = value.ToString();
 AddUpdatedFld(concss_FldDispUnitStyle.FldDispUnitFormat);
}
else if (concss_FldDispUnitStyle.CtlTypeId  ==  _AttributeName[intIndex])
{
mstrCtlTypeId = value.ToString();
 AddUpdatedFld(concss_FldDispUnitStyle.CtlTypeId);
}
else if (concss_FldDispUnitStyle.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(concss_FldDispUnitStyle.OrderNum);
}
else if (concss_FldDispUnitStyle.DeletedDate  ==  _AttributeName[intIndex])
{
mstrDeletedDate = value.ToString();
 AddUpdatedFld(concss_FldDispUnitStyle.DeletedDate);
}
else if (concss_FldDispUnitStyle.IsDeleted  ==  _AttributeName[intIndex])
{
mbolIsDeleted = TransNullToBool(value.ToString());
 AddUpdatedFld(concss_FldDispUnitStyle.IsDeleted);
}
else if (concss_FldDispUnitStyle.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concss_FldDispUnitStyle.UpdDate);
}
else if (concss_FldDispUnitStyle.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(concss_FldDispUnitStyle.UpdUser);
}
else if (concss_FldDispUnitStyle.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(concss_FldDispUnitStyle.Memo);
}
}
}

/// <summary>
/// 字段显示单元样式Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FldDispUnitStyleId
{
get
{
return mstrFldDispUnitStyleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldDispUnitStyleId = value;
}
else
{
 mstrFldDispUnitStyleId = value;
}
//记录修改过的字段
 AddUpdatedFld(concss_FldDispUnitStyle.FldDispUnitStyleId);
}
}
/// <summary>
/// 字段显示单元样式名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FldDispUnitStyleName
{
get
{
return mstrFldDispUnitStyleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldDispUnitStyleName = value;
}
else
{
 mstrFldDispUnitStyleName = value;
}
//记录修改过的字段
 AddUpdatedFld(concss_FldDispUnitStyle.FldDispUnitStyleName);
}
}
/// <summary>
/// 样式描述(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FldDispUnitStyleDesc
{
get
{
return mstrFldDispUnitStyleDesc;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldDispUnitStyleDesc = value;
}
else
{
 mstrFldDispUnitStyleDesc = value;
}
//记录修改过的字段
 AddUpdatedFld(concss_FldDispUnitStyle.FldDispUnitStyleDesc);
}
}
/// <summary>
/// 内容样式Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StyleIdContent
{
get
{
return mstrStyleIdContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStyleIdContent = value;
}
else
{
 mstrStyleIdContent = value;
}
//记录修改过的字段
 AddUpdatedFld(concss_FldDispUnitStyle.StyleIdContent);
}
}
/// <summary>
/// 标题样式Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StyleIdTitle
{
get
{
return mstrStyleIdTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStyleIdTitle = value;
}
else
{
 mstrStyleIdTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(concss_FldDispUnitStyle.StyleIdTitle);
}
}
/// <summary>
/// 样式内容(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FldDispUnitStyleContent
{
get
{
return mstrFldDispUnitStyleContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldDispUnitStyleContent = value;
}
else
{
 mstrFldDispUnitStyleContent = value;
}
//记录修改过的字段
 AddUpdatedFld(concss_FldDispUnitStyle.FldDispUnitStyleContent);
}
}
/// <summary>
/// 字段显示单元格式(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FldDispUnitFormat
{
get
{
return mstrFldDispUnitFormat;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldDispUnitFormat = value;
}
else
{
 mstrFldDispUnitFormat = value;
}
//记录修改过的字段
 AddUpdatedFld(concss_FldDispUnitStyle.FldDispUnitFormat);
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
 AddUpdatedFld(concss_FldDispUnitStyle.CtlTypeId);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(concss_FldDispUnitStyle.OrderNum);
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
 AddUpdatedFld(concss_FldDispUnitStyle.DeletedDate);
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
 AddUpdatedFld(concss_FldDispUnitStyle.IsDeleted);
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
 AddUpdatedFld(concss_FldDispUnitStyle.UpdDate);
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
 AddUpdatedFld(concss_FldDispUnitStyle.UpdUser);
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
 AddUpdatedFld(concss_FldDispUnitStyle.Memo);
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
  return mstrFldDispUnitStyleId;
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
  return mstrFldDispUnitStyleName;
 }
 }
}
 /// <summary>
 /// 字段显示单元样式(css_FldDispUnitStyle)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class concss_FldDispUnitStyle
{
public const string _CurrTabName = "css_FldDispUnitStyle"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FldDispUnitStyleId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"FldDispUnitStyleId", "FldDispUnitStyleName", "FldDispUnitStyleDesc", "StyleIdContent", "StyleIdTitle", "FldDispUnitStyleContent", "FldDispUnitFormat", "CtlTypeId", "OrderNum", "DeletedDate", "IsDeleted", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"FldDispUnitStyleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldDispUnitStyleId = "FldDispUnitStyleId";    //字段显示单元样式Id

 /// <summary>
 /// 常量:"FldDispUnitStyleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldDispUnitStyleName = "FldDispUnitStyleName";    //字段显示单元样式名称

 /// <summary>
 /// 常量:"FldDispUnitStyleDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldDispUnitStyleDesc = "FldDispUnitStyleDesc";    //样式描述

 /// <summary>
 /// 常量:"StyleIdContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StyleIdContent = "StyleIdContent";    //内容样式Id

 /// <summary>
 /// 常量:"StyleIdTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StyleIdTitle = "StyleIdTitle";    //标题样式Id

 /// <summary>
 /// 常量:"FldDispUnitStyleContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldDispUnitStyleContent = "FldDispUnitStyleContent";    //样式内容

 /// <summary>
 /// 常量:"FldDispUnitFormat"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldDispUnitFormat = "FldDispUnitFormat";    //字段显示单元格式

 /// <summary>
 /// 常量:"CtlTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CtlTypeId = "CtlTypeId";    //控件类型号

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"DeletedDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DeletedDate = "DeletedDate";    //删除日期

 /// <summary>
 /// 常量:"IsDeleted"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDeleted = "IsDeleted";    //是否删除

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