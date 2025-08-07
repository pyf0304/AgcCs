
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsExportExcel4UsersEN
 表名:ExportExcel4Users(00050241)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:36:19
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统设置(SystemSet)
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
 /// 表ExportExcel4Users的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_ExportExcel4Users
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngmId">表关键字</param>
public K_mId_ExportExcel4Users(long lngmId)
{
if (IsValid(lngmId)) Value = lngmId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngmId)
{
if (lngmId == 0) return false;
if (lngmId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_mId_ExportExcel4Users]类型的对象</returns>
public static implicit operator K_mId_ExportExcel4Users(long value)
{
return new K_mId_ExportExcel4Users(value);
}
}
 /// <summary>
 /// 导出Excel用户字段(ExportExcel4Users)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsExportExcel4UsersEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ExportExcel4Users"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 10;
public static string[] _AttributeName = new string[] {"mId", "IdExportExcel4Users", "FieldName", "FieldCnName", "IsExport", "OrderNum", "ViewName", "UpdDate", "UpdUserId", "Memo"};

protected long mlngmId;    //mId
protected string mstrIdExportExcel4Users;    //导出Excel用户字段流水号
protected string mstrFieldName;    //字段名
protected string mstrFieldCnName;    //字段中文名称
protected bool mbolIsExport;    //是否导出
protected int mintOrderNum;    //序号
protected string mstrViewName;    //界面名称
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsExportExcel4UsersEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:mId</param>
public clsExportExcel4UsersEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
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
if (strAttributeName  ==  conExportExcel4Users.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conExportExcel4Users.IdExportExcel4Users)
{
return mstrIdExportExcel4Users;
}
else if (strAttributeName  ==  conExportExcel4Users.FieldName)
{
return mstrFieldName;
}
else if (strAttributeName  ==  conExportExcel4Users.FieldCnName)
{
return mstrFieldCnName;
}
else if (strAttributeName  ==  conExportExcel4Users.IsExport)
{
return mbolIsExport;
}
else if (strAttributeName  ==  conExportExcel4Users.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conExportExcel4Users.ViewName)
{
return mstrViewName;
}
else if (strAttributeName  ==  conExportExcel4Users.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conExportExcel4Users.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conExportExcel4Users.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conExportExcel4Users.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conExportExcel4Users.mId);
}
else if (strAttributeName  ==  conExportExcel4Users.IdExportExcel4Users)
{
mstrIdExportExcel4Users = value.ToString();
 AddUpdatedFld(conExportExcel4Users.IdExportExcel4Users);
}
else if (strAttributeName  ==  conExportExcel4Users.FieldName)
{
mstrFieldName = value.ToString();
 AddUpdatedFld(conExportExcel4Users.FieldName);
}
else if (strAttributeName  ==  conExportExcel4Users.FieldCnName)
{
mstrFieldCnName = value.ToString();
 AddUpdatedFld(conExportExcel4Users.FieldCnName);
}
else if (strAttributeName  ==  conExportExcel4Users.IsExport)
{
mbolIsExport = TransNullToBool(value.ToString());
 AddUpdatedFld(conExportExcel4Users.IsExport);
}
else if (strAttributeName  ==  conExportExcel4Users.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conExportExcel4Users.OrderNum);
}
else if (strAttributeName  ==  conExportExcel4Users.ViewName)
{
mstrViewName = value.ToString();
 AddUpdatedFld(conExportExcel4Users.ViewName);
}
else if (strAttributeName  ==  conExportExcel4Users.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conExportExcel4Users.UpdDate);
}
else if (strAttributeName  ==  conExportExcel4Users.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conExportExcel4Users.UpdUserId);
}
else if (strAttributeName  ==  conExportExcel4Users.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conExportExcel4Users.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conExportExcel4Users.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (conExportExcel4Users.IdExportExcel4Users  ==  _AttributeName[intIndex])
{
return mstrIdExportExcel4Users;
}
else if (conExportExcel4Users.FieldName  ==  _AttributeName[intIndex])
{
return mstrFieldName;
}
else if (conExportExcel4Users.FieldCnName  ==  _AttributeName[intIndex])
{
return mstrFieldCnName;
}
else if (conExportExcel4Users.IsExport  ==  _AttributeName[intIndex])
{
return mbolIsExport;
}
else if (conExportExcel4Users.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conExportExcel4Users.ViewName  ==  _AttributeName[intIndex])
{
return mstrViewName;
}
else if (conExportExcel4Users.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conExportExcel4Users.UpdUserId  ==  _AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conExportExcel4Users.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conExportExcel4Users.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conExportExcel4Users.mId);
}
else if (conExportExcel4Users.IdExportExcel4Users  ==  _AttributeName[intIndex])
{
mstrIdExportExcel4Users = value.ToString();
 AddUpdatedFld(conExportExcel4Users.IdExportExcel4Users);
}
else if (conExportExcel4Users.FieldName  ==  _AttributeName[intIndex])
{
mstrFieldName = value.ToString();
 AddUpdatedFld(conExportExcel4Users.FieldName);
}
else if (conExportExcel4Users.FieldCnName  ==  _AttributeName[intIndex])
{
mstrFieldCnName = value.ToString();
 AddUpdatedFld(conExportExcel4Users.FieldCnName);
}
else if (conExportExcel4Users.IsExport  ==  _AttributeName[intIndex])
{
mbolIsExport = TransNullToBool(value.ToString());
 AddUpdatedFld(conExportExcel4Users.IsExport);
}
else if (conExportExcel4Users.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conExportExcel4Users.OrderNum);
}
else if (conExportExcel4Users.ViewName  ==  _AttributeName[intIndex])
{
mstrViewName = value.ToString();
 AddUpdatedFld(conExportExcel4Users.ViewName);
}
else if (conExportExcel4Users.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conExportExcel4Users.UpdDate);
}
else if (conExportExcel4Users.UpdUserId  ==  _AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conExportExcel4Users.UpdUserId);
}
else if (conExportExcel4Users.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conExportExcel4Users.Memo);
}
}
}

/// <summary>
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long mId
{
get
{
return mlngmId;
}
set
{
 mlngmId = value;
//记录修改过的字段
 AddUpdatedFld(conExportExcel4Users.mId);
}
}
/// <summary>
/// 导出Excel用户字段流水号(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdExportExcel4Users
{
get
{
return mstrIdExportExcel4Users;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdExportExcel4Users = value;
}
else
{
 mstrIdExportExcel4Users = value;
}
//记录修改过的字段
 AddUpdatedFld(conExportExcel4Users.IdExportExcel4Users);
}
}
/// <summary>
/// 字段名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FieldName
{
get
{
return mstrFieldName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFieldName = value;
}
else
{
 mstrFieldName = value;
}
//记录修改过的字段
 AddUpdatedFld(conExportExcel4Users.FieldName);
}
}
/// <summary>
/// 字段中文名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FieldCnName
{
get
{
return mstrFieldCnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFieldCnName = value;
}
else
{
 mstrFieldCnName = value;
}
//记录修改过的字段
 AddUpdatedFld(conExportExcel4Users.FieldCnName);
}
}
/// <summary>
/// 是否导出(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsExport
{
get
{
return mbolIsExport;
}
set
{
 mbolIsExport = value;
//记录修改过的字段
 AddUpdatedFld(conExportExcel4Users.IsExport);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(conExportExcel4Users.OrderNum);
}
}
/// <summary>
/// 界面名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewName
{
get
{
return mstrViewName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewName = value;
}
else
{
 mstrViewName = value;
}
//记录修改过的字段
 AddUpdatedFld(conExportExcel4Users.ViewName);
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
 AddUpdatedFld(conExportExcel4Users.UpdDate);
}
}
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUserId
{
get
{
return mstrUpdUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUserId = value;
}
else
{
 mstrUpdUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conExportExcel4Users.UpdUserId);
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
 AddUpdatedFld(conExportExcel4Users.Memo);
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
  return mlngmId.ToString();
 }
 }
}
 /// <summary>
 /// 导出Excel用户字段(ExportExcel4Users)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conExportExcel4Users
{
public const string _CurrTabName = "ExportExcel4Users"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "IdExportExcel4Users", "FieldName", "FieldCnName", "IsExport", "OrderNum", "ViewName", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"IdExportExcel4Users"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdExportExcel4Users = "IdExportExcel4Users";    //导出Excel用户字段流水号

 /// <summary>
 /// 常量:"FieldName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FieldName = "FieldName";    //字段名

 /// <summary>
 /// 常量:"FieldCnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FieldCnName = "FieldCnName";    //字段中文名称

 /// <summary>
 /// 常量:"IsExport"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsExport = "IsExport";    //是否导出

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"ViewName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewName = "ViewName";    //界面名称

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}