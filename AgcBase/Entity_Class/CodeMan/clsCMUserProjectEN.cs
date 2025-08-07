
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCMUserProjectEN
 表名:CMUserProject(00050511)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:34:03
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
 /// 表CMUserProject的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_CMUserProject
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
public K_mId_CMUserProject(long lngmId)
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
 /// <returns>返回:[K_mId_CMUserProject]类型的对象</returns>
public static implicit operator K_mId_CMUserProject(long value)
{
return new K_mId_CMUserProject(value);
}
}
 /// <summary>
 /// CM用户工程(CMUserProject)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCMUserProjectEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CMUserProject"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 7;
public static string[] _AttributeName = new string[] {"mId", "UserId", "CmPrjId", "ProjectPath", "UpdDate", "UpdUserId", "Memo"};

protected long mlngmId;    //mId
protected string mstrUserId;    //用户Id
protected string mstrCmPrjId;    //Cm工程Id
protected string mstrProjectPath;    //工程路径
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsCMUserProjectEN()
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
public clsCMUserProjectEN(long lngmId)
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
if (strAttributeName  ==  conCMUserProject.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conCMUserProject.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conCMUserProject.CmPrjId)
{
return mstrCmPrjId;
}
else if (strAttributeName  ==  conCMUserProject.ProjectPath)
{
return mstrProjectPath;
}
else if (strAttributeName  ==  conCMUserProject.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conCMUserProject.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conCMUserProject.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conCMUserProject.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conCMUserProject.mId);
}
else if (strAttributeName  ==  conCMUserProject.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conCMUserProject.UserId);
}
else if (strAttributeName  ==  conCMUserProject.CmPrjId)
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(conCMUserProject.CmPrjId);
}
else if (strAttributeName  ==  conCMUserProject.ProjectPath)
{
mstrProjectPath = value.ToString();
 AddUpdatedFld(conCMUserProject.ProjectPath);
}
else if (strAttributeName  ==  conCMUserProject.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCMUserProject.UpdDate);
}
else if (strAttributeName  ==  conCMUserProject.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conCMUserProject.UpdUserId);
}
else if (strAttributeName  ==  conCMUserProject.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCMUserProject.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conCMUserProject.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (conCMUserProject.UserId  ==  _AttributeName[intIndex])
{
return mstrUserId;
}
else if (conCMUserProject.CmPrjId  ==  _AttributeName[intIndex])
{
return mstrCmPrjId;
}
else if (conCMUserProject.ProjectPath  ==  _AttributeName[intIndex])
{
return mstrProjectPath;
}
else if (conCMUserProject.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conCMUserProject.UpdUserId  ==  _AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conCMUserProject.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conCMUserProject.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conCMUserProject.mId);
}
else if (conCMUserProject.UserId  ==  _AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conCMUserProject.UserId);
}
else if (conCMUserProject.CmPrjId  ==  _AttributeName[intIndex])
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(conCMUserProject.CmPrjId);
}
else if (conCMUserProject.ProjectPath  ==  _AttributeName[intIndex])
{
mstrProjectPath = value.ToString();
 AddUpdatedFld(conCMUserProject.ProjectPath);
}
else if (conCMUserProject.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCMUserProject.UpdDate);
}
else if (conCMUserProject.UpdUserId  ==  _AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conCMUserProject.UpdUserId);
}
else if (conCMUserProject.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCMUserProject.Memo);
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
 AddUpdatedFld(conCMUserProject.mId);
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
 AddUpdatedFld(conCMUserProject.UserId);
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
 AddUpdatedFld(conCMUserProject.CmPrjId);
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
 AddUpdatedFld(conCMUserProject.ProjectPath);
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
 AddUpdatedFld(conCMUserProject.UpdDate);
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
 AddUpdatedFld(conCMUserProject.UpdUserId);
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
 AddUpdatedFld(conCMUserProject.Memo);
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
 /// CM用户工程(CMUserProject)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCMUserProject
{
public const string _CurrTabName = "CMUserProject"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "UserId", "CmPrjId", "ProjectPath", "UpdDate", "UpdUserId", "Memo"};
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
 /// 常量:"CmPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CmPrjId = "CmPrjId";    //Cm工程Id

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