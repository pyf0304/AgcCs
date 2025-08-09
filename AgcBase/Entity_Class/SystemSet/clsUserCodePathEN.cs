
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUserCodePathEN
 表名:UserCodePath(00050204)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 19:59:47
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
 /// 表UserCodePath的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_UserCodePath
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
public K_mId_UserCodePath(long lngmId)
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
 /// <returns>返回:[K_mId_UserCodePath]类型的对象</returns>
public static implicit operator K_mId_UserCodePath(long value)
{
return new K_mId_UserCodePath(value);
}
}
 /// <summary>
 /// 用户生成路径(UserCodePath)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsUserCodePathEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "UserCodePath"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 19;
public static string[] _AttributeName = new string[] {"mId", "CMProjectAppRelaId", "CodeTypeId", "TabMainTypeId", "IsGeneCode", "ProjectFileName", "ProjectPath", "PrjFileStateId", "CodePath", "GcPathId", "CodePathBackup", "SuffixPath", "IsTemplate", "IsExistCodePath", "IsExistCodePathBackup", "PrjId", "UpdDate", "UpdUserId", "Memo"};

protected long mlngmId;    //mId
protected long mlngCMProjectAppRelaId;    //Cm工程应用关系Id
protected string mstrCodeTypeId;    //代码类型Id
protected string mstrTabMainTypeId;    //表主类型Id
protected bool mbolIsGeneCode;    //是否生成代码
protected string mstrProjectFileName;    //工程文件名
protected string mstrProjectPath;    //工程路径
protected string mstrPrjFileStateId;    //工程文件状态Id
protected string mstrCodePath;    //代码路径
protected string mstrGcPathId;    //GC路径Id
protected string mstrCodePathBackup;    //备份代码路径
protected string mstrSuffixPath;    //后缀路径
protected bool mbolIsTemplate;    //是否模板
protected bool mbolIsExistCodePath;    //是否存在代码路径
protected bool mbolIsExistCodePathBackup;    //是否存在备份路径
protected string mstrPrjId;    //工程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsUserCodePathEN()
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
public clsUserCodePathEN(long lngmId)
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
if (strAttributeName  ==  conUserCodePath.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conUserCodePath.CMProjectAppRelaId)
{
return mlngCMProjectAppRelaId;
}
else if (strAttributeName  ==  conUserCodePath.CodeTypeId)
{
return mstrCodeTypeId;
}
else if (strAttributeName  ==  conUserCodePath.TabMainTypeId)
{
return mstrTabMainTypeId;
}
else if (strAttributeName  ==  conUserCodePath.IsGeneCode)
{
return mbolIsGeneCode;
}
else if (strAttributeName  ==  conUserCodePath.ProjectFileName)
{
return mstrProjectFileName;
}
else if (strAttributeName  ==  conUserCodePath.ProjectPath)
{
return mstrProjectPath;
}
else if (strAttributeName  ==  conUserCodePath.PrjFileStateId)
{
return mstrPrjFileStateId;
}
else if (strAttributeName  ==  conUserCodePath.CodePath)
{
return mstrCodePath;
}
else if (strAttributeName  ==  conUserCodePath.GcPathId)
{
return mstrGcPathId;
}
else if (strAttributeName  ==  conUserCodePath.CodePathBackup)
{
return mstrCodePathBackup;
}
else if (strAttributeName  ==  conUserCodePath.SuffixPath)
{
return mstrSuffixPath;
}
else if (strAttributeName  ==  conUserCodePath.IsTemplate)
{
return mbolIsTemplate;
}
else if (strAttributeName  ==  conUserCodePath.IsExistCodePath)
{
return mbolIsExistCodePath;
}
else if (strAttributeName  ==  conUserCodePath.IsExistCodePathBackup)
{
return mbolIsExistCodePathBackup;
}
else if (strAttributeName  ==  conUserCodePath.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conUserCodePath.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conUserCodePath.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conUserCodePath.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conUserCodePath.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUserCodePath.mId);
}
else if (strAttributeName  ==  conUserCodePath.CMProjectAppRelaId)
{
mlngCMProjectAppRelaId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUserCodePath.CMProjectAppRelaId);
}
else if (strAttributeName  ==  conUserCodePath.CodeTypeId)
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(conUserCodePath.CodeTypeId);
}
else if (strAttributeName  ==  conUserCodePath.TabMainTypeId)
{
mstrTabMainTypeId = value.ToString();
 AddUpdatedFld(conUserCodePath.TabMainTypeId);
}
else if (strAttributeName  ==  conUserCodePath.IsGeneCode)
{
mbolIsGeneCode = TransNullToBool(value.ToString());
 AddUpdatedFld(conUserCodePath.IsGeneCode);
}
else if (strAttributeName  ==  conUserCodePath.ProjectFileName)
{
mstrProjectFileName = value.ToString();
 AddUpdatedFld(conUserCodePath.ProjectFileName);
}
else if (strAttributeName  ==  conUserCodePath.ProjectPath)
{
mstrProjectPath = value.ToString();
 AddUpdatedFld(conUserCodePath.ProjectPath);
}
else if (strAttributeName  ==  conUserCodePath.PrjFileStateId)
{
mstrPrjFileStateId = value.ToString();
 AddUpdatedFld(conUserCodePath.PrjFileStateId);
}
else if (strAttributeName  ==  conUserCodePath.CodePath)
{
mstrCodePath = value.ToString();
 AddUpdatedFld(conUserCodePath.CodePath);
}
else if (strAttributeName  ==  conUserCodePath.GcPathId)
{
mstrGcPathId = value.ToString();
 AddUpdatedFld(conUserCodePath.GcPathId);
}
else if (strAttributeName  ==  conUserCodePath.CodePathBackup)
{
mstrCodePathBackup = value.ToString();
 AddUpdatedFld(conUserCodePath.CodePathBackup);
}
else if (strAttributeName  ==  conUserCodePath.SuffixPath)
{
mstrSuffixPath = value.ToString();
 AddUpdatedFld(conUserCodePath.SuffixPath);
}
else if (strAttributeName  ==  conUserCodePath.IsTemplate)
{
mbolIsTemplate = TransNullToBool(value.ToString());
 AddUpdatedFld(conUserCodePath.IsTemplate);
}
else if (strAttributeName  ==  conUserCodePath.IsExistCodePath)
{
mbolIsExistCodePath = TransNullToBool(value.ToString());
 AddUpdatedFld(conUserCodePath.IsExistCodePath);
}
else if (strAttributeName  ==  conUserCodePath.IsExistCodePathBackup)
{
mbolIsExistCodePathBackup = TransNullToBool(value.ToString());
 AddUpdatedFld(conUserCodePath.IsExistCodePathBackup);
}
else if (strAttributeName  ==  conUserCodePath.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conUserCodePath.PrjId);
}
else if (strAttributeName  ==  conUserCodePath.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conUserCodePath.UpdDate);
}
else if (strAttributeName  ==  conUserCodePath.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conUserCodePath.UpdUserId);
}
else if (strAttributeName  ==  conUserCodePath.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conUserCodePath.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conUserCodePath.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (conUserCodePath.CMProjectAppRelaId  ==  _AttributeName[intIndex])
{
return mlngCMProjectAppRelaId;
}
else if (conUserCodePath.CodeTypeId  ==  _AttributeName[intIndex])
{
return mstrCodeTypeId;
}
else if (conUserCodePath.TabMainTypeId  ==  _AttributeName[intIndex])
{
return mstrTabMainTypeId;
}
else if (conUserCodePath.IsGeneCode  ==  _AttributeName[intIndex])
{
return mbolIsGeneCode;
}
else if (conUserCodePath.ProjectFileName  ==  _AttributeName[intIndex])
{
return mstrProjectFileName;
}
else if (conUserCodePath.ProjectPath  ==  _AttributeName[intIndex])
{
return mstrProjectPath;
}
else if (conUserCodePath.PrjFileStateId  ==  _AttributeName[intIndex])
{
return mstrPrjFileStateId;
}
else if (conUserCodePath.CodePath  ==  _AttributeName[intIndex])
{
return mstrCodePath;
}
else if (conUserCodePath.GcPathId  ==  _AttributeName[intIndex])
{
return mstrGcPathId;
}
else if (conUserCodePath.CodePathBackup  ==  _AttributeName[intIndex])
{
return mstrCodePathBackup;
}
else if (conUserCodePath.SuffixPath  ==  _AttributeName[intIndex])
{
return mstrSuffixPath;
}
else if (conUserCodePath.IsTemplate  ==  _AttributeName[intIndex])
{
return mbolIsTemplate;
}
else if (conUserCodePath.IsExistCodePath  ==  _AttributeName[intIndex])
{
return mbolIsExistCodePath;
}
else if (conUserCodePath.IsExistCodePathBackup  ==  _AttributeName[intIndex])
{
return mbolIsExistCodePathBackup;
}
else if (conUserCodePath.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conUserCodePath.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conUserCodePath.UpdUserId  ==  _AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conUserCodePath.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conUserCodePath.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUserCodePath.mId);
}
else if (conUserCodePath.CMProjectAppRelaId  ==  _AttributeName[intIndex])
{
mlngCMProjectAppRelaId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUserCodePath.CMProjectAppRelaId);
}
else if (conUserCodePath.CodeTypeId  ==  _AttributeName[intIndex])
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(conUserCodePath.CodeTypeId);
}
else if (conUserCodePath.TabMainTypeId  ==  _AttributeName[intIndex])
{
mstrTabMainTypeId = value.ToString();
 AddUpdatedFld(conUserCodePath.TabMainTypeId);
}
else if (conUserCodePath.IsGeneCode  ==  _AttributeName[intIndex])
{
mbolIsGeneCode = TransNullToBool(value.ToString());
 AddUpdatedFld(conUserCodePath.IsGeneCode);
}
else if (conUserCodePath.ProjectFileName  ==  _AttributeName[intIndex])
{
mstrProjectFileName = value.ToString();
 AddUpdatedFld(conUserCodePath.ProjectFileName);
}
else if (conUserCodePath.ProjectPath  ==  _AttributeName[intIndex])
{
mstrProjectPath = value.ToString();
 AddUpdatedFld(conUserCodePath.ProjectPath);
}
else if (conUserCodePath.PrjFileStateId  ==  _AttributeName[intIndex])
{
mstrPrjFileStateId = value.ToString();
 AddUpdatedFld(conUserCodePath.PrjFileStateId);
}
else if (conUserCodePath.CodePath  ==  _AttributeName[intIndex])
{
mstrCodePath = value.ToString();
 AddUpdatedFld(conUserCodePath.CodePath);
}
else if (conUserCodePath.GcPathId  ==  _AttributeName[intIndex])
{
mstrGcPathId = value.ToString();
 AddUpdatedFld(conUserCodePath.GcPathId);
}
else if (conUserCodePath.CodePathBackup  ==  _AttributeName[intIndex])
{
mstrCodePathBackup = value.ToString();
 AddUpdatedFld(conUserCodePath.CodePathBackup);
}
else if (conUserCodePath.SuffixPath  ==  _AttributeName[intIndex])
{
mstrSuffixPath = value.ToString();
 AddUpdatedFld(conUserCodePath.SuffixPath);
}
else if (conUserCodePath.IsTemplate  ==  _AttributeName[intIndex])
{
mbolIsTemplate = TransNullToBool(value.ToString());
 AddUpdatedFld(conUserCodePath.IsTemplate);
}
else if (conUserCodePath.IsExistCodePath  ==  _AttributeName[intIndex])
{
mbolIsExistCodePath = TransNullToBool(value.ToString());
 AddUpdatedFld(conUserCodePath.IsExistCodePath);
}
else if (conUserCodePath.IsExistCodePathBackup  ==  _AttributeName[intIndex])
{
mbolIsExistCodePathBackup = TransNullToBool(value.ToString());
 AddUpdatedFld(conUserCodePath.IsExistCodePathBackup);
}
else if (conUserCodePath.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conUserCodePath.PrjId);
}
else if (conUserCodePath.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conUserCodePath.UpdDate);
}
else if (conUserCodePath.UpdUserId  ==  _AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conUserCodePath.UpdUserId);
}
else if (conUserCodePath.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conUserCodePath.Memo);
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
 AddUpdatedFld(conUserCodePath.mId);
}
}
/// <summary>
/// Cm工程应用关系Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long CMProjectAppRelaId
{
get
{
return mlngCMProjectAppRelaId;
}
set
{
 mlngCMProjectAppRelaId = value;
//记录修改过的字段
 AddUpdatedFld(conUserCodePath.CMProjectAppRelaId);
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
 AddUpdatedFld(conUserCodePath.CodeTypeId);
}
}
/// <summary>
/// 表主类型Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabMainTypeId
{
get
{
return mstrTabMainTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabMainTypeId = value;
}
else
{
 mstrTabMainTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserCodePath.TabMainTypeId);
}
}
/// <summary>
/// 是否生成代码(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsGeneCode
{
get
{
return mbolIsGeneCode;
}
set
{
 mbolIsGeneCode = value;
//记录修改过的字段
 AddUpdatedFld(conUserCodePath.IsGeneCode);
}
}
/// <summary>
/// 工程文件名(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProjectFileName
{
get
{
return mstrProjectFileName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProjectFileName = value;
}
else
{
 mstrProjectFileName = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserCodePath.ProjectFileName);
}
}
/// <summary>
/// 工程路径(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProjectPath
{
get
{
return mstrProjectPath;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProjectPath = value;
}
else
{
 mstrProjectPath = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserCodePath.ProjectPath);
}
}
/// <summary>
/// 工程文件状态Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjFileStateId
{
get
{
return mstrPrjFileStateId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjFileStateId = value;
}
else
{
 mstrPrjFileStateId = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserCodePath.PrjFileStateId);
}
}
/// <summary>
/// 代码路径(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodePath
{
get
{
return mstrCodePath;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodePath = value;
}
else
{
 mstrCodePath = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserCodePath.CodePath);
}
}
/// <summary>
/// GC路径Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GcPathId
{
get
{
return mstrGcPathId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGcPathId = value;
}
else
{
 mstrGcPathId = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserCodePath.GcPathId);
}
}
/// <summary>
/// 备份代码路径(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodePathBackup
{
get
{
return mstrCodePathBackup;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodePathBackup = value;
}
else
{
 mstrCodePathBackup = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserCodePath.CodePathBackup);
}
}
/// <summary>
/// 后缀路径(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SuffixPath
{
get
{
return mstrSuffixPath;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSuffixPath = value;
}
else
{
 mstrSuffixPath = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserCodePath.SuffixPath);
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
 AddUpdatedFld(conUserCodePath.IsTemplate);
}
}
/// <summary>
/// 是否存在代码路径(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsExistCodePath
{
get
{
return mbolIsExistCodePath;
}
set
{
 mbolIsExistCodePath = value;
//记录修改过的字段
 AddUpdatedFld(conUserCodePath.IsExistCodePath);
}
}
/// <summary>
/// 是否存在备份路径(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsExistCodePathBackup
{
get
{
return mbolIsExistCodePathBackup;
}
set
{
 mbolIsExistCodePathBackup = value;
//记录修改过的字段
 AddUpdatedFld(conUserCodePath.IsExistCodePathBackup);
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
 AddUpdatedFld(conUserCodePath.PrjId);
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
 AddUpdatedFld(conUserCodePath.UpdDate);
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
 AddUpdatedFld(conUserCodePath.UpdUserId);
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
 AddUpdatedFld(conUserCodePath.Memo);
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
 /// 用户生成路径(UserCodePath)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conUserCodePath
{
public const string _CurrTabName = "UserCodePath"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "CMProjectAppRelaId", "CodeTypeId", "TabMainTypeId", "IsGeneCode", "ProjectFileName", "ProjectPath", "PrjFileStateId", "CodePath", "GcPathId", "CodePathBackup", "SuffixPath", "IsTemplate", "IsExistCodePath", "IsExistCodePathBackup", "PrjId", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"CMProjectAppRelaId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CMProjectAppRelaId = "CMProjectAppRelaId";    //Cm工程应用关系Id

 /// <summary>
 /// 常量:"CodeTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTypeId = "CodeTypeId";    //代码类型Id

 /// <summary>
 /// 常量:"TabMainTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabMainTypeId = "TabMainTypeId";    //表主类型Id

 /// <summary>
 /// 常量:"IsGeneCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsGeneCode = "IsGeneCode";    //是否生成代码

 /// <summary>
 /// 常量:"ProjectFileName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProjectFileName = "ProjectFileName";    //工程文件名

 /// <summary>
 /// 常量:"ProjectPath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProjectPath = "ProjectPath";    //工程路径

 /// <summary>
 /// 常量:"PrjFileStateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjFileStateId = "PrjFileStateId";    //工程文件状态Id

 /// <summary>
 /// 常量:"CodePath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodePath = "CodePath";    //代码路径

 /// <summary>
 /// 常量:"GcPathId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GcPathId = "GcPathId";    //GC路径Id

 /// <summary>
 /// 常量:"CodePathBackup"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodePathBackup = "CodePathBackup";    //备份代码路径

 /// <summary>
 /// 常量:"SuffixPath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SuffixPath = "SuffixPath";    //后缀路径

 /// <summary>
 /// 常量:"IsTemplate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsTemplate = "IsTemplate";    //是否模板

 /// <summary>
 /// 常量:"IsExistCodePath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsExistCodePath = "IsExistCodePath";    //是否存在代码路径

 /// <summary>
 /// 常量:"IsExistCodePathBackup"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsExistCodePathBackup = "IsExistCodePathBackup";    //是否存在备份路径

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