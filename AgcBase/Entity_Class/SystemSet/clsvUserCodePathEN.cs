
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvUserCodePathEN
 表名:vUserCodePath(00050205)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:03:27
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
 /// 表vUserCodePath的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vUserCodePath
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
public K_mId_vUserCodePath(long lngmId)
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
 /// <returns>返回:[K_mId_vUserCodePath]类型的对象</returns>
public static implicit operator K_mId_vUserCodePath(long value)
{
return new K_mId_vUserCodePath(value);
}
}
 /// <summary>
 /// v用户生成路径(vUserCodePath)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvUserCodePathEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vUserCodePath"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 38;
public static string[] _AttributeName = new string[] {"mId", "CMProjectAppRelaId", "CodeTypeId", "ProgLangTypeId", "ProgLangTypeName", "CmPrjId", "ApplicationTypeName", "ApplicationTypeENName", "PrjFileStateName", "AppOrderNum", "NewCodePath", "NewCodePathBackup", "CodeTypeName", "CodeTypeENName", "OrderNum", "ApplicationTypeId", "TabMainTypeId", "IsGeneCode", "ProjectFileName", "ProjectPath", "PrjFileStateId", "CodePath", "CodePathBackup", "SuffixPath", "IsTemplate", "IsExistCodePath", "IsExistCodePathBackup", "PrjId", "UpdDate", "UpdUserId", "Memo", "ProgLangTypeSimName", "ApplicationTypeSimName", "CmPrjName", "TabMainTypeName", "CodeTypeSimName", "IsExistCodePathP", "IsExistCodePathBackupP"};

protected long mlngmId;    //mId
protected long mlngCMProjectAppRelaId;    //Cm工程应用关系Id
protected string mstrCodeTypeId;    //代码类型Id
protected string mstrProgLangTypeId;    //编程语言类型Id
protected string mstrProgLangTypeName;    //编程语言类型名
protected string mstrCmPrjId;    //Cm工程Id
protected string mstrApplicationTypeName;    //应用程序类型名称
protected string mstrApplicationTypeENName;    //应用类型英文名
protected string mstrPrjFileStateName;    //工程文件状态名
protected int? mintAppOrderNum;    //AppOrderNum
protected string mstrNewCodePath;    //NewCodePath
protected string mstrNewCodePathBackup;    //新备份目录
protected string mstrCodeTypeName;    //代码类型名
protected string mstrCodeTypeENName;    //代码类型英文名
protected int? mintOrderNum;    //序号
protected int mintApplicationTypeId;    //应用程序类型ID
protected string mstrTabMainTypeId;    //表主类型Id
protected bool mbolIsGeneCode;    //是否生成代码
protected string mstrProjectFileName;    //工程文件名
protected string mstrProjectPath;    //工程路径
protected string mstrPrjFileStateId;    //工程文件状态Id
protected string mstrCodePath;    //代码路径
protected string mstrCodePathBackup;    //备份代码路径
protected string mstrSuffixPath;    //后缀路径
protected bool mbolIsTemplate;    //是否模板
protected bool mbolIsExistCodePath;    //是否存在代码路径
protected bool mbolIsExistCodePathBackup;    //是否存在备份路径
protected string mstrPrjId;    //工程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //说明
protected string mstrProgLangTypeSimName;    //编程语言类型简称
protected string mstrApplicationTypeSimName;    //应用程序类型简称
protected string mstrCmPrjName;    //CM工程名
protected string mstrTabMainTypeName;    //表主类型名
protected string mstrCodeTypeSimName;    //简称
protected bool mbolIsExistCodePathP;    //是否存在代码目录P
protected bool mbolIsExistCodePathBackupP;    //是否存在备份目录P

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvUserCodePathEN()
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
public clsvUserCodePathEN(long lngmId)
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
if (strAttributeName  ==  convUserCodePath.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convUserCodePath.CMProjectAppRelaId)
{
return mlngCMProjectAppRelaId;
}
else if (strAttributeName  ==  convUserCodePath.CodeTypeId)
{
return mstrCodeTypeId;
}
else if (strAttributeName  ==  convUserCodePath.ProgLangTypeId)
{
return mstrProgLangTypeId;
}
else if (strAttributeName  ==  convUserCodePath.ProgLangTypeName)
{
return mstrProgLangTypeName;
}
else if (strAttributeName  ==  convUserCodePath.CmPrjId)
{
return mstrCmPrjId;
}
else if (strAttributeName  ==  convUserCodePath.ApplicationTypeName)
{
return mstrApplicationTypeName;
}
else if (strAttributeName  ==  convUserCodePath.ApplicationTypeENName)
{
return mstrApplicationTypeENName;
}
else if (strAttributeName  ==  convUserCodePath.PrjFileStateName)
{
return mstrPrjFileStateName;
}
else if (strAttributeName  ==  convUserCodePath.AppOrderNum)
{
return mintAppOrderNum;
}
else if (strAttributeName  ==  convUserCodePath.NewCodePath)
{
return mstrNewCodePath;
}
else if (strAttributeName  ==  convUserCodePath.NewCodePathBackup)
{
return mstrNewCodePathBackup;
}
else if (strAttributeName  ==  convUserCodePath.CodeTypeName)
{
return mstrCodeTypeName;
}
else if (strAttributeName  ==  convUserCodePath.CodeTypeENName)
{
return mstrCodeTypeENName;
}
else if (strAttributeName  ==  convUserCodePath.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convUserCodePath.ApplicationTypeId)
{
return mintApplicationTypeId;
}
else if (strAttributeName  ==  convUserCodePath.TabMainTypeId)
{
return mstrTabMainTypeId;
}
else if (strAttributeName  ==  convUserCodePath.IsGeneCode)
{
return mbolIsGeneCode;
}
else if (strAttributeName  ==  convUserCodePath.ProjectFileName)
{
return mstrProjectFileName;
}
else if (strAttributeName  ==  convUserCodePath.ProjectPath)
{
return mstrProjectPath;
}
else if (strAttributeName  ==  convUserCodePath.PrjFileStateId)
{
return mstrPrjFileStateId;
}
else if (strAttributeName  ==  convUserCodePath.CodePath)
{
return mstrCodePath;
}
else if (strAttributeName  ==  convUserCodePath.CodePathBackup)
{
return mstrCodePathBackup;
}
else if (strAttributeName  ==  convUserCodePath.SuffixPath)
{
return mstrSuffixPath;
}
else if (strAttributeName  ==  convUserCodePath.IsTemplate)
{
return mbolIsTemplate;
}
else if (strAttributeName  ==  convUserCodePath.IsExistCodePath)
{
return mbolIsExistCodePath;
}
else if (strAttributeName  ==  convUserCodePath.IsExistCodePathBackup)
{
return mbolIsExistCodePathBackup;
}
else if (strAttributeName  ==  convUserCodePath.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convUserCodePath.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convUserCodePath.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convUserCodePath.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convUserCodePath.ProgLangTypeSimName)
{
return mstrProgLangTypeSimName;
}
else if (strAttributeName  ==  convUserCodePath.ApplicationTypeSimName)
{
return mstrApplicationTypeSimName;
}
else if (strAttributeName  ==  convUserCodePath.CmPrjName)
{
return mstrCmPrjName;
}
else if (strAttributeName  ==  convUserCodePath.TabMainTypeName)
{
return mstrTabMainTypeName;
}
else if (strAttributeName  ==  convUserCodePath.CodeTypeSimName)
{
return mstrCodeTypeSimName;
}
else if (strAttributeName  ==  convUserCodePath.IsExistCodePathP)
{
return mbolIsExistCodePathP;
}
else if (strAttributeName  ==  convUserCodePath.IsExistCodePathBackupP)
{
return mbolIsExistCodePathBackupP;
}
return null;
}
set
{
if (strAttributeName  ==  convUserCodePath.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convUserCodePath.mId);
}
else if (strAttributeName  ==  convUserCodePath.CMProjectAppRelaId)
{
mlngCMProjectAppRelaId = TransNullToInt(value.ToString());
 AddUpdatedFld(convUserCodePath.CMProjectAppRelaId);
}
else if (strAttributeName  ==  convUserCodePath.CodeTypeId)
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(convUserCodePath.CodeTypeId);
}
else if (strAttributeName  ==  convUserCodePath.ProgLangTypeId)
{
mstrProgLangTypeId = value.ToString();
 AddUpdatedFld(convUserCodePath.ProgLangTypeId);
}
else if (strAttributeName  ==  convUserCodePath.ProgLangTypeName)
{
mstrProgLangTypeName = value.ToString();
 AddUpdatedFld(convUserCodePath.ProgLangTypeName);
}
else if (strAttributeName  ==  convUserCodePath.CmPrjId)
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(convUserCodePath.CmPrjId);
}
else if (strAttributeName  ==  convUserCodePath.ApplicationTypeName)
{
mstrApplicationTypeName = value.ToString();
 AddUpdatedFld(convUserCodePath.ApplicationTypeName);
}
else if (strAttributeName  ==  convUserCodePath.ApplicationTypeENName)
{
mstrApplicationTypeENName = value.ToString();
 AddUpdatedFld(convUserCodePath.ApplicationTypeENName);
}
else if (strAttributeName  ==  convUserCodePath.PrjFileStateName)
{
mstrPrjFileStateName = value.ToString();
 AddUpdatedFld(convUserCodePath.PrjFileStateName);
}
else if (strAttributeName  ==  convUserCodePath.AppOrderNum)
{
mintAppOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convUserCodePath.AppOrderNum);
}
else if (strAttributeName  ==  convUserCodePath.NewCodePath)
{
mstrNewCodePath = value.ToString();
 AddUpdatedFld(convUserCodePath.NewCodePath);
}
else if (strAttributeName  ==  convUserCodePath.NewCodePathBackup)
{
mstrNewCodePathBackup = value.ToString();
 AddUpdatedFld(convUserCodePath.NewCodePathBackup);
}
else if (strAttributeName  ==  convUserCodePath.CodeTypeName)
{
mstrCodeTypeName = value.ToString();
 AddUpdatedFld(convUserCodePath.CodeTypeName);
}
else if (strAttributeName  ==  convUserCodePath.CodeTypeENName)
{
mstrCodeTypeENName = value.ToString();
 AddUpdatedFld(convUserCodePath.CodeTypeENName);
}
else if (strAttributeName  ==  convUserCodePath.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convUserCodePath.OrderNum);
}
else if (strAttributeName  ==  convUserCodePath.ApplicationTypeId)
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convUserCodePath.ApplicationTypeId);
}
else if (strAttributeName  ==  convUserCodePath.TabMainTypeId)
{
mstrTabMainTypeId = value.ToString();
 AddUpdatedFld(convUserCodePath.TabMainTypeId);
}
else if (strAttributeName  ==  convUserCodePath.IsGeneCode)
{
mbolIsGeneCode = TransNullToBool(value.ToString());
 AddUpdatedFld(convUserCodePath.IsGeneCode);
}
else if (strAttributeName  ==  convUserCodePath.ProjectFileName)
{
mstrProjectFileName = value.ToString();
 AddUpdatedFld(convUserCodePath.ProjectFileName);
}
else if (strAttributeName  ==  convUserCodePath.ProjectPath)
{
mstrProjectPath = value.ToString();
 AddUpdatedFld(convUserCodePath.ProjectPath);
}
else if (strAttributeName  ==  convUserCodePath.PrjFileStateId)
{
mstrPrjFileStateId = value.ToString();
 AddUpdatedFld(convUserCodePath.PrjFileStateId);
}
else if (strAttributeName  ==  convUserCodePath.CodePath)
{
mstrCodePath = value.ToString();
 AddUpdatedFld(convUserCodePath.CodePath);
}
else if (strAttributeName  ==  convUserCodePath.CodePathBackup)
{
mstrCodePathBackup = value.ToString();
 AddUpdatedFld(convUserCodePath.CodePathBackup);
}
else if (strAttributeName  ==  convUserCodePath.SuffixPath)
{
mstrSuffixPath = value.ToString();
 AddUpdatedFld(convUserCodePath.SuffixPath);
}
else if (strAttributeName  ==  convUserCodePath.IsTemplate)
{
mbolIsTemplate = TransNullToBool(value.ToString());
 AddUpdatedFld(convUserCodePath.IsTemplate);
}
else if (strAttributeName  ==  convUserCodePath.IsExistCodePath)
{
mbolIsExistCodePath = TransNullToBool(value.ToString());
 AddUpdatedFld(convUserCodePath.IsExistCodePath);
}
else if (strAttributeName  ==  convUserCodePath.IsExistCodePathBackup)
{
mbolIsExistCodePathBackup = TransNullToBool(value.ToString());
 AddUpdatedFld(convUserCodePath.IsExistCodePathBackup);
}
else if (strAttributeName  ==  convUserCodePath.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convUserCodePath.PrjId);
}
else if (strAttributeName  ==  convUserCodePath.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convUserCodePath.UpdDate);
}
else if (strAttributeName  ==  convUserCodePath.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convUserCodePath.UpdUserId);
}
else if (strAttributeName  ==  convUserCodePath.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convUserCodePath.Memo);
}
else if (strAttributeName  ==  convUserCodePath.ProgLangTypeSimName)
{
mstrProgLangTypeSimName = value.ToString();
 AddUpdatedFld(convUserCodePath.ProgLangTypeSimName);
}
else if (strAttributeName  ==  convUserCodePath.ApplicationTypeSimName)
{
mstrApplicationTypeSimName = value.ToString();
 AddUpdatedFld(convUserCodePath.ApplicationTypeSimName);
}
else if (strAttributeName  ==  convUserCodePath.CmPrjName)
{
mstrCmPrjName = value.ToString();
 AddUpdatedFld(convUserCodePath.CmPrjName);
}
else if (strAttributeName  ==  convUserCodePath.TabMainTypeName)
{
mstrTabMainTypeName = value.ToString();
 AddUpdatedFld(convUserCodePath.TabMainTypeName);
}
else if (strAttributeName  ==  convUserCodePath.CodeTypeSimName)
{
mstrCodeTypeSimName = value.ToString();
 AddUpdatedFld(convUserCodePath.CodeTypeSimName);
}
else if (strAttributeName  ==  convUserCodePath.IsExistCodePathP)
{
mbolIsExistCodePathP = TransNullToBool(value.ToString());
 AddUpdatedFld(convUserCodePath.IsExistCodePathP);
}
else if (strAttributeName  ==  convUserCodePath.IsExistCodePathBackupP)
{
mbolIsExistCodePathBackupP = TransNullToBool(value.ToString());
 AddUpdatedFld(convUserCodePath.IsExistCodePathBackupP);
}
}
}
public object this[int intIndex]
{
get
{
if (convUserCodePath.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (convUserCodePath.CMProjectAppRelaId  ==  _AttributeName[intIndex])
{
return mlngCMProjectAppRelaId;
}
else if (convUserCodePath.CodeTypeId  ==  _AttributeName[intIndex])
{
return mstrCodeTypeId;
}
else if (convUserCodePath.ProgLangTypeId  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeId;
}
else if (convUserCodePath.ProgLangTypeName  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeName;
}
else if (convUserCodePath.CmPrjId  ==  _AttributeName[intIndex])
{
return mstrCmPrjId;
}
else if (convUserCodePath.ApplicationTypeName  ==  _AttributeName[intIndex])
{
return mstrApplicationTypeName;
}
else if (convUserCodePath.ApplicationTypeENName  ==  _AttributeName[intIndex])
{
return mstrApplicationTypeENName;
}
else if (convUserCodePath.PrjFileStateName  ==  _AttributeName[intIndex])
{
return mstrPrjFileStateName;
}
else if (convUserCodePath.AppOrderNum  ==  _AttributeName[intIndex])
{
return mintAppOrderNum;
}
else if (convUserCodePath.NewCodePath  ==  _AttributeName[intIndex])
{
return mstrNewCodePath;
}
else if (convUserCodePath.NewCodePathBackup  ==  _AttributeName[intIndex])
{
return mstrNewCodePathBackup;
}
else if (convUserCodePath.CodeTypeName  ==  _AttributeName[intIndex])
{
return mstrCodeTypeName;
}
else if (convUserCodePath.CodeTypeENName  ==  _AttributeName[intIndex])
{
return mstrCodeTypeENName;
}
else if (convUserCodePath.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convUserCodePath.ApplicationTypeId  ==  _AttributeName[intIndex])
{
return mintApplicationTypeId;
}
else if (convUserCodePath.TabMainTypeId  ==  _AttributeName[intIndex])
{
return mstrTabMainTypeId;
}
else if (convUserCodePath.IsGeneCode  ==  _AttributeName[intIndex])
{
return mbolIsGeneCode;
}
else if (convUserCodePath.ProjectFileName  ==  _AttributeName[intIndex])
{
return mstrProjectFileName;
}
else if (convUserCodePath.ProjectPath  ==  _AttributeName[intIndex])
{
return mstrProjectPath;
}
else if (convUserCodePath.PrjFileStateId  ==  _AttributeName[intIndex])
{
return mstrPrjFileStateId;
}
else if (convUserCodePath.CodePath  ==  _AttributeName[intIndex])
{
return mstrCodePath;
}
else if (convUserCodePath.CodePathBackup  ==  _AttributeName[intIndex])
{
return mstrCodePathBackup;
}
else if (convUserCodePath.SuffixPath  ==  _AttributeName[intIndex])
{
return mstrSuffixPath;
}
else if (convUserCodePath.IsTemplate  ==  _AttributeName[intIndex])
{
return mbolIsTemplate;
}
else if (convUserCodePath.IsExistCodePath  ==  _AttributeName[intIndex])
{
return mbolIsExistCodePath;
}
else if (convUserCodePath.IsExistCodePathBackup  ==  _AttributeName[intIndex])
{
return mbolIsExistCodePathBackup;
}
else if (convUserCodePath.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convUserCodePath.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convUserCodePath.UpdUserId  ==  _AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convUserCodePath.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (convUserCodePath.ProgLangTypeSimName  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeSimName;
}
else if (convUserCodePath.ApplicationTypeSimName  ==  _AttributeName[intIndex])
{
return mstrApplicationTypeSimName;
}
else if (convUserCodePath.CmPrjName  ==  _AttributeName[intIndex])
{
return mstrCmPrjName;
}
else if (convUserCodePath.TabMainTypeName  ==  _AttributeName[intIndex])
{
return mstrTabMainTypeName;
}
else if (convUserCodePath.CodeTypeSimName  ==  _AttributeName[intIndex])
{
return mstrCodeTypeSimName;
}
else if (convUserCodePath.IsExistCodePathP  ==  _AttributeName[intIndex])
{
return mbolIsExistCodePathP;
}
else if (convUserCodePath.IsExistCodePathBackupP  ==  _AttributeName[intIndex])
{
return mbolIsExistCodePathBackupP;
}
return null;
}
set
{
if (convUserCodePath.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convUserCodePath.mId);
}
else if (convUserCodePath.CMProjectAppRelaId  ==  _AttributeName[intIndex])
{
mlngCMProjectAppRelaId = TransNullToInt(value.ToString());
 AddUpdatedFld(convUserCodePath.CMProjectAppRelaId);
}
else if (convUserCodePath.CodeTypeId  ==  _AttributeName[intIndex])
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(convUserCodePath.CodeTypeId);
}
else if (convUserCodePath.ProgLangTypeId  ==  _AttributeName[intIndex])
{
mstrProgLangTypeId = value.ToString();
 AddUpdatedFld(convUserCodePath.ProgLangTypeId);
}
else if (convUserCodePath.ProgLangTypeName  ==  _AttributeName[intIndex])
{
mstrProgLangTypeName = value.ToString();
 AddUpdatedFld(convUserCodePath.ProgLangTypeName);
}
else if (convUserCodePath.CmPrjId  ==  _AttributeName[intIndex])
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(convUserCodePath.CmPrjId);
}
else if (convUserCodePath.ApplicationTypeName  ==  _AttributeName[intIndex])
{
mstrApplicationTypeName = value.ToString();
 AddUpdatedFld(convUserCodePath.ApplicationTypeName);
}
else if (convUserCodePath.ApplicationTypeENName  ==  _AttributeName[intIndex])
{
mstrApplicationTypeENName = value.ToString();
 AddUpdatedFld(convUserCodePath.ApplicationTypeENName);
}
else if (convUserCodePath.PrjFileStateName  ==  _AttributeName[intIndex])
{
mstrPrjFileStateName = value.ToString();
 AddUpdatedFld(convUserCodePath.PrjFileStateName);
}
else if (convUserCodePath.AppOrderNum  ==  _AttributeName[intIndex])
{
mintAppOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convUserCodePath.AppOrderNum);
}
else if (convUserCodePath.NewCodePath  ==  _AttributeName[intIndex])
{
mstrNewCodePath = value.ToString();
 AddUpdatedFld(convUserCodePath.NewCodePath);
}
else if (convUserCodePath.NewCodePathBackup  ==  _AttributeName[intIndex])
{
mstrNewCodePathBackup = value.ToString();
 AddUpdatedFld(convUserCodePath.NewCodePathBackup);
}
else if (convUserCodePath.CodeTypeName  ==  _AttributeName[intIndex])
{
mstrCodeTypeName = value.ToString();
 AddUpdatedFld(convUserCodePath.CodeTypeName);
}
else if (convUserCodePath.CodeTypeENName  ==  _AttributeName[intIndex])
{
mstrCodeTypeENName = value.ToString();
 AddUpdatedFld(convUserCodePath.CodeTypeENName);
}
else if (convUserCodePath.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convUserCodePath.OrderNum);
}
else if (convUserCodePath.ApplicationTypeId  ==  _AttributeName[intIndex])
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convUserCodePath.ApplicationTypeId);
}
else if (convUserCodePath.TabMainTypeId  ==  _AttributeName[intIndex])
{
mstrTabMainTypeId = value.ToString();
 AddUpdatedFld(convUserCodePath.TabMainTypeId);
}
else if (convUserCodePath.IsGeneCode  ==  _AttributeName[intIndex])
{
mbolIsGeneCode = TransNullToBool(value.ToString());
 AddUpdatedFld(convUserCodePath.IsGeneCode);
}
else if (convUserCodePath.ProjectFileName  ==  _AttributeName[intIndex])
{
mstrProjectFileName = value.ToString();
 AddUpdatedFld(convUserCodePath.ProjectFileName);
}
else if (convUserCodePath.ProjectPath  ==  _AttributeName[intIndex])
{
mstrProjectPath = value.ToString();
 AddUpdatedFld(convUserCodePath.ProjectPath);
}
else if (convUserCodePath.PrjFileStateId  ==  _AttributeName[intIndex])
{
mstrPrjFileStateId = value.ToString();
 AddUpdatedFld(convUserCodePath.PrjFileStateId);
}
else if (convUserCodePath.CodePath  ==  _AttributeName[intIndex])
{
mstrCodePath = value.ToString();
 AddUpdatedFld(convUserCodePath.CodePath);
}
else if (convUserCodePath.CodePathBackup  ==  _AttributeName[intIndex])
{
mstrCodePathBackup = value.ToString();
 AddUpdatedFld(convUserCodePath.CodePathBackup);
}
else if (convUserCodePath.SuffixPath  ==  _AttributeName[intIndex])
{
mstrSuffixPath = value.ToString();
 AddUpdatedFld(convUserCodePath.SuffixPath);
}
else if (convUserCodePath.IsTemplate  ==  _AttributeName[intIndex])
{
mbolIsTemplate = TransNullToBool(value.ToString());
 AddUpdatedFld(convUserCodePath.IsTemplate);
}
else if (convUserCodePath.IsExistCodePath  ==  _AttributeName[intIndex])
{
mbolIsExistCodePath = TransNullToBool(value.ToString());
 AddUpdatedFld(convUserCodePath.IsExistCodePath);
}
else if (convUserCodePath.IsExistCodePathBackup  ==  _AttributeName[intIndex])
{
mbolIsExistCodePathBackup = TransNullToBool(value.ToString());
 AddUpdatedFld(convUserCodePath.IsExistCodePathBackup);
}
else if (convUserCodePath.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convUserCodePath.PrjId);
}
else if (convUserCodePath.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convUserCodePath.UpdDate);
}
else if (convUserCodePath.UpdUserId  ==  _AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convUserCodePath.UpdUserId);
}
else if (convUserCodePath.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convUserCodePath.Memo);
}
else if (convUserCodePath.ProgLangTypeSimName  ==  _AttributeName[intIndex])
{
mstrProgLangTypeSimName = value.ToString();
 AddUpdatedFld(convUserCodePath.ProgLangTypeSimName);
}
else if (convUserCodePath.ApplicationTypeSimName  ==  _AttributeName[intIndex])
{
mstrApplicationTypeSimName = value.ToString();
 AddUpdatedFld(convUserCodePath.ApplicationTypeSimName);
}
else if (convUserCodePath.CmPrjName  ==  _AttributeName[intIndex])
{
mstrCmPrjName = value.ToString();
 AddUpdatedFld(convUserCodePath.CmPrjName);
}
else if (convUserCodePath.TabMainTypeName  ==  _AttributeName[intIndex])
{
mstrTabMainTypeName = value.ToString();
 AddUpdatedFld(convUserCodePath.TabMainTypeName);
}
else if (convUserCodePath.CodeTypeSimName  ==  _AttributeName[intIndex])
{
mstrCodeTypeSimName = value.ToString();
 AddUpdatedFld(convUserCodePath.CodeTypeSimName);
}
else if (convUserCodePath.IsExistCodePathP  ==  _AttributeName[intIndex])
{
mbolIsExistCodePathP = TransNullToBool(value.ToString());
 AddUpdatedFld(convUserCodePath.IsExistCodePathP);
}
else if (convUserCodePath.IsExistCodePathBackupP  ==  _AttributeName[intIndex])
{
mbolIsExistCodePathBackupP = TransNullToBool(value.ToString());
 AddUpdatedFld(convUserCodePath.IsExistCodePathBackupP);
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
 AddUpdatedFld(convUserCodePath.mId);
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
 AddUpdatedFld(convUserCodePath.CMProjectAppRelaId);
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
 AddUpdatedFld(convUserCodePath.CodeTypeId);
}
}
/// <summary>
/// 编程语言类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLangTypeId
{
get
{
return mstrProgLangTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLangTypeId = value;
}
else
{
 mstrProgLangTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convUserCodePath.ProgLangTypeId);
}
}
/// <summary>
/// 编程语言类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLangTypeName
{
get
{
return mstrProgLangTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLangTypeName = value;
}
else
{
 mstrProgLangTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convUserCodePath.ProgLangTypeName);
}
}
/// <summary>
/// Cm工程Id(说明:;字段类型:char;字段长度:6;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CmPrjId
{
get
{
return mstrCmPrjId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCmPrjId = value;
}
else
{
 mstrCmPrjId = value;
}
//记录修改过的字段
 AddUpdatedFld(convUserCodePath.CmPrjId);
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
 AddUpdatedFld(convUserCodePath.ApplicationTypeName);
}
}
/// <summary>
/// 应用类型英文名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ApplicationTypeENName
{
get
{
return mstrApplicationTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrApplicationTypeENName = value;
}
else
{
 mstrApplicationTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(convUserCodePath.ApplicationTypeENName);
}
}
/// <summary>
/// 工程文件状态名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjFileStateName
{
get
{
return mstrPrjFileStateName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjFileStateName = value;
}
else
{
 mstrPrjFileStateName = value;
}
//记录修改过的字段
 AddUpdatedFld(convUserCodePath.PrjFileStateName);
}
}
/// <summary>
/// AppOrderNum(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? AppOrderNum
{
get
{
return mintAppOrderNum;
}
set
{
 mintAppOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(convUserCodePath.AppOrderNum);
}
}
/// <summary>
/// NewCodePath(说明:;字段类型:varchar;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string NewCodePath
{
get
{
return mstrNewCodePath;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrNewCodePath = value;
}
else
{
 mstrNewCodePath = value;
}
//记录修改过的字段
 AddUpdatedFld(convUserCodePath.NewCodePath);
}
}
/// <summary>
/// 新备份目录(说明:;字段类型:varchar;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string NewCodePathBackup
{
get
{
return mstrNewCodePathBackup;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrNewCodePathBackup = value;
}
else
{
 mstrNewCodePathBackup = value;
}
//记录修改过的字段
 AddUpdatedFld(convUserCodePath.NewCodePathBackup);
}
}
/// <summary>
/// 代码类型名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTypeName
{
get
{
return mstrCodeTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTypeName = value;
}
else
{
 mstrCodeTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convUserCodePath.CodeTypeName);
}
}
/// <summary>
/// 代码类型英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTypeENName
{
get
{
return mstrCodeTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTypeENName = value;
}
else
{
 mstrCodeTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(convUserCodePath.CodeTypeENName);
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
 AddUpdatedFld(convUserCodePath.OrderNum);
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
 AddUpdatedFld(convUserCodePath.ApplicationTypeId);
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
 AddUpdatedFld(convUserCodePath.TabMainTypeId);
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
 AddUpdatedFld(convUserCodePath.IsGeneCode);
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
 AddUpdatedFld(convUserCodePath.ProjectFileName);
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
 AddUpdatedFld(convUserCodePath.ProjectPath);
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
 AddUpdatedFld(convUserCodePath.PrjFileStateId);
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
 AddUpdatedFld(convUserCodePath.CodePath);
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
 AddUpdatedFld(convUserCodePath.CodePathBackup);
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
 AddUpdatedFld(convUserCodePath.SuffixPath);
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
 AddUpdatedFld(convUserCodePath.IsTemplate);
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
 AddUpdatedFld(convUserCodePath.IsExistCodePath);
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
 AddUpdatedFld(convUserCodePath.IsExistCodePathBackup);
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
 AddUpdatedFld(convUserCodePath.PrjId);
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
 AddUpdatedFld(convUserCodePath.UpdDate);
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
 AddUpdatedFld(convUserCodePath.UpdUserId);
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
 AddUpdatedFld(convUserCodePath.Memo);
}
}
/// <summary>
/// 编程语言类型简称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLangTypeSimName
{
get
{
return mstrProgLangTypeSimName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLangTypeSimName = value;
}
else
{
 mstrProgLangTypeSimName = value;
}
//记录修改过的字段
 AddUpdatedFld(convUserCodePath.ProgLangTypeSimName);
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
 AddUpdatedFld(convUserCodePath.ApplicationTypeSimName);
}
}
/// <summary>
/// CM工程名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CmPrjName
{
get
{
return mstrCmPrjName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCmPrjName = value;
}
else
{
 mstrCmPrjName = value;
}
//记录修改过的字段
 AddUpdatedFld(convUserCodePath.CmPrjName);
}
}
/// <summary>
/// 表主类型名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabMainTypeName
{
get
{
return mstrTabMainTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabMainTypeName = value;
}
else
{
 mstrTabMainTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convUserCodePath.TabMainTypeName);
}
}
/// <summary>
/// 简称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTypeSimName
{
get
{
return mstrCodeTypeSimName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTypeSimName = value;
}
else
{
 mstrCodeTypeSimName = value;
}
//记录修改过的字段
 AddUpdatedFld(convUserCodePath.CodeTypeSimName);
}
}
/// <summary>
/// 是否存在代码目录P(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsExistCodePathP
{
get
{
return mbolIsExistCodePathP;
}
set
{
 mbolIsExistCodePathP = value;
//记录修改过的字段
 AddUpdatedFld(convUserCodePath.IsExistCodePathP);
}
}
/// <summary>
/// 是否存在备份目录P(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsExistCodePathBackupP
{
get
{
return mbolIsExistCodePathBackupP;
}
set
{
 mbolIsExistCodePathBackupP = value;
//记录修改过的字段
 AddUpdatedFld(convUserCodePath.IsExistCodePathBackupP);
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
 /// v用户生成路径(vUserCodePath)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convUserCodePath
{
public const string _CurrTabName = "vUserCodePath"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "CMProjectAppRelaId", "CodeTypeId", "ProgLangTypeId", "ProgLangTypeName", "CmPrjId", "ApplicationTypeName", "ApplicationTypeENName", "PrjFileStateName", "AppOrderNum", "NewCodePath", "NewCodePathBackup", "CodeTypeName", "CodeTypeENName", "OrderNum", "ApplicationTypeId", "TabMainTypeId", "IsGeneCode", "ProjectFileName", "ProjectPath", "PrjFileStateId", "CodePath", "CodePathBackup", "SuffixPath", "IsTemplate", "IsExistCodePath", "IsExistCodePathBackup", "PrjId", "UpdDate", "UpdUserId", "Memo", "ProgLangTypeSimName", "ApplicationTypeSimName", "CmPrjName", "TabMainTypeName", "CodeTypeSimName", "IsExistCodePathP", "IsExistCodePathBackupP"};
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
 /// 常量:"ProgLangTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeId = "ProgLangTypeId";    //编程语言类型Id

 /// <summary>
 /// 常量:"ProgLangTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeName = "ProgLangTypeName";    //编程语言类型名

 /// <summary>
 /// 常量:"CmPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CmPrjId = "CmPrjId";    //Cm工程Id

 /// <summary>
 /// 常量:"ApplicationTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeName = "ApplicationTypeName";    //应用程序类型名称

 /// <summary>
 /// 常量:"ApplicationTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeENName = "ApplicationTypeENName";    //应用类型英文名

 /// <summary>
 /// 常量:"PrjFileStateName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjFileStateName = "PrjFileStateName";    //工程文件状态名

 /// <summary>
 /// 常量:"AppOrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppOrderNum = "AppOrderNum";    //AppOrderNum

 /// <summary>
 /// 常量:"NewCodePath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string NewCodePath = "NewCodePath";    //NewCodePath

 /// <summary>
 /// 常量:"NewCodePathBackup"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string NewCodePathBackup = "NewCodePathBackup";    //新备份目录

 /// <summary>
 /// 常量:"CodeTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTypeName = "CodeTypeName";    //代码类型名

 /// <summary>
 /// 常量:"CodeTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTypeENName = "CodeTypeENName";    //代码类型英文名

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"ApplicationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeId = "ApplicationTypeId";    //应用程序类型ID

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

 /// <summary>
 /// 常量:"ProgLangTypeSimName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeSimName = "ProgLangTypeSimName";    //编程语言类型简称

 /// <summary>
 /// 常量:"ApplicationTypeSimName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeSimName = "ApplicationTypeSimName";    //应用程序类型简称

 /// <summary>
 /// 常量:"CmPrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CmPrjName = "CmPrjName";    //CM工程名

 /// <summary>
 /// 常量:"TabMainTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabMainTypeName = "TabMainTypeName";    //表主类型名

 /// <summary>
 /// 常量:"CodeTypeSimName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTypeSimName = "CodeTypeSimName";    //简称

 /// <summary>
 /// 常量:"IsExistCodePathP"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsExistCodePathP = "IsExistCodePathP";    //是否存在代码目录P

 /// <summary>
 /// 常量:"IsExistCodePathBackupP"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsExistCodePathBackupP = "IsExistCodePathBackupP";    //是否存在备份目录P
}

}