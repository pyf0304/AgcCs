
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCMUserProjectEN
 表名:vCMUserProject(00050514)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:36:40
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:代码管理(CodeMan)
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
 /// 表vCMUserProject的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vCMUserProject
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
public K_mId_vCMUserProject(long lngmId)
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
 /// <returns>返回:[K_mId_vCMUserProject]类型的对象</returns>
public static implicit operator K_mId_vCMUserProject(long value)
{
return new K_mId_vCMUserProject(value);
}
}
 /// <summary>
 /// vCM用户工程(vCMUserProject)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvCMUserProjectEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vCMUserProject"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 14;
public static string[] _AttributeName = new string[] {"mId", "UserId", "UserName", "CmPrjId", "CmPrjName", "PrjId", "PrjName", "ApplicationTypeId", "ApplicationTypeSimName", "ProjectFileName", "ProjectPath", "UpdDate", "UpdUserId", "Memo"};

protected long mlngmId;    //mId
protected string mstrUserId;    //用户Id
protected string mstrUserName;    //用户名
protected string mstrCmPrjId;    //Cm工程Id
protected string mstrCmPrjName;    //CM工程名
protected string mstrPrjId;    //工程Id
protected string mstrPrjName;    //工程名称
protected int mintApplicationTypeId;    //应用程序类型ID
protected string mstrApplicationTypeSimName;    //应用程序类型简称
protected string mstrProjectFileName;    //工程文件名
protected string mstrProjectPath;    //工程路径
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvCMUserProjectEN()
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
public clsvCMUserProjectEN(long lngmId)
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
if (strAttributeName  ==  convCMUserProject.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convCMUserProject.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convCMUserProject.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convCMUserProject.CmPrjId)
{
return mstrCmPrjId;
}
else if (strAttributeName  ==  convCMUserProject.CmPrjName)
{
return mstrCmPrjName;
}
else if (strAttributeName  ==  convCMUserProject.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convCMUserProject.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convCMUserProject.ApplicationTypeId)
{
return mintApplicationTypeId;
}
else if (strAttributeName  ==  convCMUserProject.ApplicationTypeSimName)
{
return mstrApplicationTypeSimName;
}
else if (strAttributeName  ==  convCMUserProject.ProjectFileName)
{
return mstrProjectFileName;
}
else if (strAttributeName  ==  convCMUserProject.ProjectPath)
{
return mstrProjectPath;
}
else if (strAttributeName  ==  convCMUserProject.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convCMUserProject.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convCMUserProject.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convCMUserProject.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMUserProject.mId);
}
else if (strAttributeName  ==  convCMUserProject.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convCMUserProject.UserId);
}
else if (strAttributeName  ==  convCMUserProject.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convCMUserProject.UserName);
}
else if (strAttributeName  ==  convCMUserProject.CmPrjId)
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(convCMUserProject.CmPrjId);
}
else if (strAttributeName  ==  convCMUserProject.CmPrjName)
{
mstrCmPrjName = value.ToString();
 AddUpdatedFld(convCMUserProject.CmPrjName);
}
else if (strAttributeName  ==  convCMUserProject.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convCMUserProject.PrjId);
}
else if (strAttributeName  ==  convCMUserProject.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convCMUserProject.PrjName);
}
else if (strAttributeName  ==  convCMUserProject.ApplicationTypeId)
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMUserProject.ApplicationTypeId);
}
else if (strAttributeName  ==  convCMUserProject.ApplicationTypeSimName)
{
mstrApplicationTypeSimName = value.ToString();
 AddUpdatedFld(convCMUserProject.ApplicationTypeSimName);
}
else if (strAttributeName  ==  convCMUserProject.ProjectFileName)
{
mstrProjectFileName = value.ToString();
 AddUpdatedFld(convCMUserProject.ProjectFileName);
}
else if (strAttributeName  ==  convCMUserProject.ProjectPath)
{
mstrProjectPath = value.ToString();
 AddUpdatedFld(convCMUserProject.ProjectPath);
}
else if (strAttributeName  ==  convCMUserProject.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convCMUserProject.UpdDate);
}
else if (strAttributeName  ==  convCMUserProject.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convCMUserProject.UpdUserId);
}
else if (strAttributeName  ==  convCMUserProject.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCMUserProject.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convCMUserProject.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (convCMUserProject.UserId  ==  _AttributeName[intIndex])
{
return mstrUserId;
}
else if (convCMUserProject.UserName  ==  _AttributeName[intIndex])
{
return mstrUserName;
}
else if (convCMUserProject.CmPrjId  ==  _AttributeName[intIndex])
{
return mstrCmPrjId;
}
else if (convCMUserProject.CmPrjName  ==  _AttributeName[intIndex])
{
return mstrCmPrjName;
}
else if (convCMUserProject.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convCMUserProject.PrjName  ==  _AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convCMUserProject.ApplicationTypeId  ==  _AttributeName[intIndex])
{
return mintApplicationTypeId;
}
else if (convCMUserProject.ApplicationTypeSimName  ==  _AttributeName[intIndex])
{
return mstrApplicationTypeSimName;
}
else if (convCMUserProject.ProjectFileName  ==  _AttributeName[intIndex])
{
return mstrProjectFileName;
}
else if (convCMUserProject.ProjectPath  ==  _AttributeName[intIndex])
{
return mstrProjectPath;
}
else if (convCMUserProject.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convCMUserProject.UpdUserId  ==  _AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convCMUserProject.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convCMUserProject.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMUserProject.mId);
}
else if (convCMUserProject.UserId  ==  _AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convCMUserProject.UserId);
}
else if (convCMUserProject.UserName  ==  _AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convCMUserProject.UserName);
}
else if (convCMUserProject.CmPrjId  ==  _AttributeName[intIndex])
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(convCMUserProject.CmPrjId);
}
else if (convCMUserProject.CmPrjName  ==  _AttributeName[intIndex])
{
mstrCmPrjName = value.ToString();
 AddUpdatedFld(convCMUserProject.CmPrjName);
}
else if (convCMUserProject.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convCMUserProject.PrjId);
}
else if (convCMUserProject.PrjName  ==  _AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convCMUserProject.PrjName);
}
else if (convCMUserProject.ApplicationTypeId  ==  _AttributeName[intIndex])
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMUserProject.ApplicationTypeId);
}
else if (convCMUserProject.ApplicationTypeSimName  ==  _AttributeName[intIndex])
{
mstrApplicationTypeSimName = value.ToString();
 AddUpdatedFld(convCMUserProject.ApplicationTypeSimName);
}
else if (convCMUserProject.ProjectFileName  ==  _AttributeName[intIndex])
{
mstrProjectFileName = value.ToString();
 AddUpdatedFld(convCMUserProject.ProjectFileName);
}
else if (convCMUserProject.ProjectPath  ==  _AttributeName[intIndex])
{
mstrProjectPath = value.ToString();
 AddUpdatedFld(convCMUserProject.ProjectPath);
}
else if (convCMUserProject.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convCMUserProject.UpdDate);
}
else if (convCMUserProject.UpdUserId  ==  _AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convCMUserProject.UpdUserId);
}
else if (convCMUserProject.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCMUserProject.Memo);
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
 AddUpdatedFld(convCMUserProject.mId);
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
 AddUpdatedFld(convCMUserProject.UserId);
}
}
/// <summary>
/// 用户名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserName
{
get
{
return mstrUserName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserName = value;
}
else
{
 mstrUserName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMUserProject.UserName);
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
 AddUpdatedFld(convCMUserProject.CmPrjId);
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
 AddUpdatedFld(convCMUserProject.CmPrjName);
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
 AddUpdatedFld(convCMUserProject.PrjId);
}
}
/// <summary>
/// 工程名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjName
{
get
{
return mstrPrjName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjName = value;
}
else
{
 mstrPrjName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMUserProject.PrjName);
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
 AddUpdatedFld(convCMUserProject.ApplicationTypeId);
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
 AddUpdatedFld(convCMUserProject.ApplicationTypeSimName);
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
 AddUpdatedFld(convCMUserProject.ProjectFileName);
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
 AddUpdatedFld(convCMUserProject.ProjectPath);
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
 AddUpdatedFld(convCMUserProject.UpdDate);
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
 AddUpdatedFld(convCMUserProject.UpdUserId);
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
 AddUpdatedFld(convCMUserProject.Memo);
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

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrUserId;
 }
 }
}
 /// <summary>
 /// vCM用户工程(vCMUserProject)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convCMUserProject
{
public const string _CurrTabName = "vCMUserProject"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "UserId", "UserName", "CmPrjId", "CmPrjName", "PrjId", "PrjName", "ApplicationTypeId", "ApplicationTypeSimName", "ProjectFileName", "ProjectPath", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户Id

 /// <summary>
 /// 常量:"UserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserName = "UserName";    //用户名

 /// <summary>
 /// 常量:"CmPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CmPrjId = "CmPrjId";    //Cm工程Id

 /// <summary>
 /// 常量:"CmPrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CmPrjName = "CmPrjName";    //CM工程名

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"PrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjName = "PrjName";    //工程名称

 /// <summary>
 /// 常量:"ApplicationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeId = "ApplicationTypeId";    //应用程序类型ID

 /// <summary>
 /// 常量:"ApplicationTypeSimName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeSimName = "ApplicationTypeSimName";    //应用程序类型简称

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