
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFileResExcludePathEN
 表名:FileResExcludePath(00050588)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:09:15
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:资源管理(ResourceMan)
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
 /// 表FileResExcludePath的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_FileResExcludePath
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
public K_mId_FileResExcludePath(long lngmId)
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
 /// <returns>返回:[K_mId_FileResExcludePath]类型的对象</returns>
public static implicit operator K_mId_FileResExcludePath(long value)
{
return new K_mId_FileResExcludePath(value);
}
}
 /// <summary>
 /// 文件资源导入排除目录(FileResExcludePath)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsFileResExcludePathEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "FileResExcludePath"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 7;
public static string[] _AttributeName = new string[] {"mId", "ExcludeDirName", "PrjId", "CmPrjId", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrExcludeDirName;    //文件目录名
protected string mstrPrjId;    //工程Id
protected string mstrCmPrjId;    //Cm工程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsFileResExcludePathEN()
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
public clsFileResExcludePathEN(long lngmId)
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
if (strAttributeName  ==  conFileResExcludePath.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conFileResExcludePath.ExcludeDirName)
{
return mstrExcludeDirName;
}
else if (strAttributeName  ==  conFileResExcludePath.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conFileResExcludePath.CmPrjId)
{
return mstrCmPrjId;
}
else if (strAttributeName  ==  conFileResExcludePath.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conFileResExcludePath.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conFileResExcludePath.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conFileResExcludePath.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conFileResExcludePath.mId);
}
else if (strAttributeName  ==  conFileResExcludePath.ExcludeDirName)
{
mstrExcludeDirName = value.ToString();
 AddUpdatedFld(conFileResExcludePath.ExcludeDirName);
}
else if (strAttributeName  ==  conFileResExcludePath.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conFileResExcludePath.PrjId);
}
else if (strAttributeName  ==  conFileResExcludePath.CmPrjId)
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(conFileResExcludePath.CmPrjId);
}
else if (strAttributeName  ==  conFileResExcludePath.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFileResExcludePath.UpdDate);
}
else if (strAttributeName  ==  conFileResExcludePath.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conFileResExcludePath.UpdUser);
}
else if (strAttributeName  ==  conFileResExcludePath.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFileResExcludePath.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conFileResExcludePath.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (conFileResExcludePath.ExcludeDirName  ==  _AttributeName[intIndex])
{
return mstrExcludeDirName;
}
else if (conFileResExcludePath.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conFileResExcludePath.CmPrjId  ==  _AttributeName[intIndex])
{
return mstrCmPrjId;
}
else if (conFileResExcludePath.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conFileResExcludePath.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conFileResExcludePath.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conFileResExcludePath.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conFileResExcludePath.mId);
}
else if (conFileResExcludePath.ExcludeDirName  ==  _AttributeName[intIndex])
{
mstrExcludeDirName = value.ToString();
 AddUpdatedFld(conFileResExcludePath.ExcludeDirName);
}
else if (conFileResExcludePath.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conFileResExcludePath.PrjId);
}
else if (conFileResExcludePath.CmPrjId  ==  _AttributeName[intIndex])
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(conFileResExcludePath.CmPrjId);
}
else if (conFileResExcludePath.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFileResExcludePath.UpdDate);
}
else if (conFileResExcludePath.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conFileResExcludePath.UpdUser);
}
else if (conFileResExcludePath.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFileResExcludePath.Memo);
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
 AddUpdatedFld(conFileResExcludePath.mId);
}
}
/// <summary>
/// 文件目录名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExcludeDirName
{
get
{
return mstrExcludeDirName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExcludeDirName = value;
}
else
{
 mstrExcludeDirName = value;
}
//记录修改过的字段
 AddUpdatedFld(conFileResExcludePath.ExcludeDirName);
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
 AddUpdatedFld(conFileResExcludePath.PrjId);
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
 AddUpdatedFld(conFileResExcludePath.CmPrjId);
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
 AddUpdatedFld(conFileResExcludePath.UpdDate);
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
 AddUpdatedFld(conFileResExcludePath.UpdUser);
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
 AddUpdatedFld(conFileResExcludePath.Memo);
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
 /// 文件资源导入排除目录(FileResExcludePath)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conFileResExcludePath
{
public const string _CurrTabName = "FileResExcludePath"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "ExcludeDirName", "PrjId", "CmPrjId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"ExcludeDirName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExcludeDirName = "ExcludeDirName";    //文件目录名

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"CmPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CmPrjId = "CmPrjId";    //Cm工程Id

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