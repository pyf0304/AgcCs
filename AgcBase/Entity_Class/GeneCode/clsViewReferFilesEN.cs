
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewReferFilesEN
 表名:ViewReferFiles(00050465)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:35:00
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
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
 /// 表ViewReferFiles的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_ViewReferFiles
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
public K_mId_ViewReferFiles(long lngmId)
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
 /// <returns>返回:[K_mId_ViewReferFiles]类型的对象</returns>
public static implicit operator K_mId_ViewReferFiles(long value)
{
return new K_mId_ViewReferFiles(value);
}
}
 /// <summary>
 /// 界面引用文件(ViewReferFiles)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsViewReferFilesEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ViewReferFiles"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 11;
public static string[] _AttributeName = new string[] {"mId", "ViewId", "CodeTypeId", "ReferFileId", "InUse", "OrderNum", "IsTemplate", "PrjId", "UpdDate", "UpdUserId", "Memo"};

protected long mlngmId;    //mId
protected string mstrViewId;    //界面Id
protected string mstrCodeTypeId;    //代码类型Id
protected string mstrReferFileId;    //引用文件Id
protected bool mbolInUse;    //是否在用
protected int mintOrderNum;    //序号
protected bool mbolIsTemplate;    //是否模板
protected string mstrPrjId;    //工程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsViewReferFilesEN()
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
public clsViewReferFilesEN(long lngmId)
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
if (strAttributeName  ==  conViewReferFiles.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conViewReferFiles.ViewId)
{
return mstrViewId;
}
else if (strAttributeName  ==  conViewReferFiles.CodeTypeId)
{
return mstrCodeTypeId;
}
else if (strAttributeName  ==  conViewReferFiles.ReferFileId)
{
return mstrReferFileId;
}
else if (strAttributeName  ==  conViewReferFiles.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  conViewReferFiles.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conViewReferFiles.IsTemplate)
{
return mbolIsTemplate;
}
else if (strAttributeName  ==  conViewReferFiles.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conViewReferFiles.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conViewReferFiles.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conViewReferFiles.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conViewReferFiles.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewReferFiles.mId);
}
else if (strAttributeName  ==  conViewReferFiles.ViewId)
{
mstrViewId = value.ToString();
 AddUpdatedFld(conViewReferFiles.ViewId);
}
else if (strAttributeName  ==  conViewReferFiles.CodeTypeId)
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(conViewReferFiles.CodeTypeId);
}
else if (strAttributeName  ==  conViewReferFiles.ReferFileId)
{
mstrReferFileId = value.ToString();
 AddUpdatedFld(conViewReferFiles.ReferFileId);
}
else if (strAttributeName  ==  conViewReferFiles.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewReferFiles.InUse);
}
else if (strAttributeName  ==  conViewReferFiles.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewReferFiles.OrderNum);
}
else if (strAttributeName  ==  conViewReferFiles.IsTemplate)
{
mbolIsTemplate = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewReferFiles.IsTemplate);
}
else if (strAttributeName  ==  conViewReferFiles.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conViewReferFiles.PrjId);
}
else if (strAttributeName  ==  conViewReferFiles.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conViewReferFiles.UpdDate);
}
else if (strAttributeName  ==  conViewReferFiles.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conViewReferFiles.UpdUserId);
}
else if (strAttributeName  ==  conViewReferFiles.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conViewReferFiles.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conViewReferFiles.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (conViewReferFiles.ViewId  ==  _AttributeName[intIndex])
{
return mstrViewId;
}
else if (conViewReferFiles.CodeTypeId  ==  _AttributeName[intIndex])
{
return mstrCodeTypeId;
}
else if (conViewReferFiles.ReferFileId  ==  _AttributeName[intIndex])
{
return mstrReferFileId;
}
else if (conViewReferFiles.InUse  ==  _AttributeName[intIndex])
{
return mbolInUse;
}
else if (conViewReferFiles.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conViewReferFiles.IsTemplate  ==  _AttributeName[intIndex])
{
return mbolIsTemplate;
}
else if (conViewReferFiles.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conViewReferFiles.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conViewReferFiles.UpdUserId  ==  _AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conViewReferFiles.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conViewReferFiles.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewReferFiles.mId);
}
else if (conViewReferFiles.ViewId  ==  _AttributeName[intIndex])
{
mstrViewId = value.ToString();
 AddUpdatedFld(conViewReferFiles.ViewId);
}
else if (conViewReferFiles.CodeTypeId  ==  _AttributeName[intIndex])
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(conViewReferFiles.CodeTypeId);
}
else if (conViewReferFiles.ReferFileId  ==  _AttributeName[intIndex])
{
mstrReferFileId = value.ToString();
 AddUpdatedFld(conViewReferFiles.ReferFileId);
}
else if (conViewReferFiles.InUse  ==  _AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewReferFiles.InUse);
}
else if (conViewReferFiles.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewReferFiles.OrderNum);
}
else if (conViewReferFiles.IsTemplate  ==  _AttributeName[intIndex])
{
mbolIsTemplate = TransNullToBool(value.ToString());
 AddUpdatedFld(conViewReferFiles.IsTemplate);
}
else if (conViewReferFiles.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conViewReferFiles.PrjId);
}
else if (conViewReferFiles.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conViewReferFiles.UpdDate);
}
else if (conViewReferFiles.UpdUserId  ==  _AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conViewReferFiles.UpdUserId);
}
else if (conViewReferFiles.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conViewReferFiles.Memo);
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
 AddUpdatedFld(conViewReferFiles.mId);
}
}
/// <summary>
/// 界面Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewId
{
get
{
return mstrViewId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewId = value;
}
else
{
 mstrViewId = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewReferFiles.ViewId);
}
}
/// <summary>
/// 代码类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTypeId
{
get
{
return mstrCodeTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTypeId = value;
}
else
{
 mstrCodeTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewReferFiles.CodeTypeId);
}
}
/// <summary>
/// 引用文件Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ReferFileId
{
get
{
return mstrReferFileId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrReferFileId = value;
}
else
{
 mstrReferFileId = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewReferFiles.ReferFileId);
}
}
/// <summary>
/// 是否在用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool InUse
{
get
{
return mbolInUse;
}
set
{
 mbolInUse = value;
//记录修改过的字段
 AddUpdatedFld(conViewReferFiles.InUse);
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
 AddUpdatedFld(conViewReferFiles.OrderNum);
}
}
/// <summary>
/// 是否模板(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsTemplate
{
get
{
return mbolIsTemplate;
}
set
{
 mbolIsTemplate = value;
//记录修改过的字段
 AddUpdatedFld(conViewReferFiles.IsTemplate);
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
 AddUpdatedFld(conViewReferFiles.PrjId);
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
 AddUpdatedFld(conViewReferFiles.UpdDate);
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
 AddUpdatedFld(conViewReferFiles.UpdUserId);
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
 AddUpdatedFld(conViewReferFiles.Memo);
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
 /// 界面引用文件(ViewReferFiles)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conViewReferFiles
{
public const string _CurrTabName = "ViewReferFiles"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "ViewId", "CodeTypeId", "ReferFileId", "InUse", "OrderNum", "IsTemplate", "PrjId", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"ViewId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewId = "ViewId";    //界面Id

 /// <summary>
 /// 常量:"CodeTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTypeId = "CodeTypeId";    //代码类型Id

 /// <summary>
 /// 常量:"ReferFileId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReferFileId = "ReferFileId";    //引用文件Id

 /// <summary>
 /// 常量:"InUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InUse = "InUse";    //是否在用

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"IsTemplate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsTemplate = "IsTemplate";    //是否模板

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