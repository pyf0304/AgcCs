
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFR_DependencyPathEN
 表名:FR_DependencyPath(00050656)
 * 版本:2026.07.20(服务器:WIN-SRV103-116)
 日期:2026/07/23 22:50:33
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:文件引用(FileReference)
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
 /// 表FR_DependencyPath的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_FR_DependencyPath
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
public K_mId_FR_DependencyPath(long lngmId)
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
 /// <returns>返回:[K_mId_FR_DependencyPath]类型的对象</returns>
public static implicit operator K_mId_FR_DependencyPath(long value)
{
return new K_mId_FR_DependencyPath(value);
}
}
 /// <summary>
 /// FR_DependencyPath(FR_DependencyPath)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsFR_DependencyPathEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "FR_DependencyPath"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 7;
public static string[] _AttributeName = new string[] {"mId", "SourceFileId", "TargetFileId", "PathLength", "PathString", "IsCircular", "CreatedAt"};

protected long mlngmId;    //mId
protected long mlngSourceFileId;    //源文件Id
protected long mlngTargetFileId;    //目标文件Id
protected int mintPathLength;    //路径长度
protected string mstrPathString;    //路径字符串
protected bool mbolIsCircular;    //是否循环依赖
protected DateTime mdteCreatedAt;    //建立时间

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsFR_DependencyPathEN()
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
public clsFR_DependencyPathEN(long lngmId)
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
if (strAttributeName  ==  conFR_DependencyPath.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conFR_DependencyPath.SourceFileId)
{
return mlngSourceFileId;
}
else if (strAttributeName  ==  conFR_DependencyPath.TargetFileId)
{
return mlngTargetFileId;
}
else if (strAttributeName  ==  conFR_DependencyPath.PathLength)
{
return mintPathLength;
}
else if (strAttributeName  ==  conFR_DependencyPath.PathString)
{
return mstrPathString;
}
else if (strAttributeName  ==  conFR_DependencyPath.IsCircular)
{
return mbolIsCircular;
}
else if (strAttributeName  ==  conFR_DependencyPath.CreatedAt)
{
return mdteCreatedAt;
}
return null;
}
set
{
if (strAttributeName  ==  conFR_DependencyPath.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conFR_DependencyPath.mId);
}
else if (strAttributeName  ==  conFR_DependencyPath.SourceFileId)
{
mlngSourceFileId = TransNullToInt(value.ToString());
 AddUpdatedFld(conFR_DependencyPath.SourceFileId);
}
else if (strAttributeName  ==  conFR_DependencyPath.TargetFileId)
{
mlngTargetFileId = TransNullToInt(value.ToString());
 AddUpdatedFld(conFR_DependencyPath.TargetFileId);
}
else if (strAttributeName  ==  conFR_DependencyPath.PathLength)
{
mintPathLength = TransNullToInt(value.ToString());
 AddUpdatedFld(conFR_DependencyPath.PathLength);
}
else if (strAttributeName  ==  conFR_DependencyPath.PathString)
{
mstrPathString = value.ToString();
 AddUpdatedFld(conFR_DependencyPath.PathString);
}
else if (strAttributeName  ==  conFR_DependencyPath.IsCircular)
{
mbolIsCircular = TransNullToBool(value.ToString());
 AddUpdatedFld(conFR_DependencyPath.IsCircular);
}
else if (strAttributeName  ==  conFR_DependencyPath.CreatedAt)
{
mdteCreatedAt = TransNullToDate(value.ToString());
 AddUpdatedFld(conFR_DependencyPath.CreatedAt);
}
}
}
public object this[int intIndex]
{
get
{
if (conFR_DependencyPath.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (conFR_DependencyPath.SourceFileId  ==  _AttributeName[intIndex])
{
return mlngSourceFileId;
}
else if (conFR_DependencyPath.TargetFileId  ==  _AttributeName[intIndex])
{
return mlngTargetFileId;
}
else if (conFR_DependencyPath.PathLength  ==  _AttributeName[intIndex])
{
return mintPathLength;
}
else if (conFR_DependencyPath.PathString  ==  _AttributeName[intIndex])
{
return mstrPathString;
}
else if (conFR_DependencyPath.IsCircular  ==  _AttributeName[intIndex])
{
return mbolIsCircular;
}
else if (conFR_DependencyPath.CreatedAt  ==  _AttributeName[intIndex])
{
return mdteCreatedAt;
}
return null;
}
set
{
if (conFR_DependencyPath.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conFR_DependencyPath.mId);
}
else if (conFR_DependencyPath.SourceFileId  ==  _AttributeName[intIndex])
{
mlngSourceFileId = TransNullToInt(value.ToString());
 AddUpdatedFld(conFR_DependencyPath.SourceFileId);
}
else if (conFR_DependencyPath.TargetFileId  ==  _AttributeName[intIndex])
{
mlngTargetFileId = TransNullToInt(value.ToString());
 AddUpdatedFld(conFR_DependencyPath.TargetFileId);
}
else if (conFR_DependencyPath.PathLength  ==  _AttributeName[intIndex])
{
mintPathLength = TransNullToInt(value.ToString());
 AddUpdatedFld(conFR_DependencyPath.PathLength);
}
else if (conFR_DependencyPath.PathString  ==  _AttributeName[intIndex])
{
mstrPathString = value.ToString();
 AddUpdatedFld(conFR_DependencyPath.PathString);
}
else if (conFR_DependencyPath.IsCircular  ==  _AttributeName[intIndex])
{
mbolIsCircular = TransNullToBool(value.ToString());
 AddUpdatedFld(conFR_DependencyPath.IsCircular);
}
else if (conFR_DependencyPath.CreatedAt  ==  _AttributeName[intIndex])
{
mdteCreatedAt = TransNullToDate(value.ToString());
 AddUpdatedFld(conFR_DependencyPath.CreatedAt);
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
 AddUpdatedFld(conFR_DependencyPath.mId);
}
}
/// <summary>
/// 源文件Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long SourceFileId
{
get
{
return mlngSourceFileId;
}
set
{
 mlngSourceFileId = value;
//记录修改过的字段
 AddUpdatedFld(conFR_DependencyPath.SourceFileId);
}
}
/// <summary>
/// 目标文件Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long TargetFileId
{
get
{
return mlngTargetFileId;
}
set
{
 mlngTargetFileId = value;
//记录修改过的字段
 AddUpdatedFld(conFR_DependencyPath.TargetFileId);
}
}
/// <summary>
/// 路径长度(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int PathLength
{
get
{
return mintPathLength;
}
set
{
 mintPathLength = value;
//记录修改过的字段
 AddUpdatedFld(conFR_DependencyPath.PathLength);
}
}
/// <summary>
/// 路径字符串(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PathString
{
get
{
return mstrPathString;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPathString = value;
}
else
{
 mstrPathString = value;
}
//记录修改过的字段
 AddUpdatedFld(conFR_DependencyPath.PathString);
}
}
/// <summary>
/// 是否循环依赖(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsCircular
{
get
{
return mbolIsCircular;
}
set
{
 mbolIsCircular = value;
//记录修改过的字段
 AddUpdatedFld(conFR_DependencyPath.IsCircular);
}
}
/// <summary>
/// 建立时间(说明:;字段类型:datetime;字段长度:16;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public DateTime CreatedAt
{
get
{
return mdteCreatedAt;
}
set
{
 mdteCreatedAt = value;
//记录修改过的字段
 AddUpdatedFld(conFR_DependencyPath.CreatedAt);
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
 /// FR_DependencyPath(FR_DependencyPath)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conFR_DependencyPath
{
public const string _CurrTabName = "FR_DependencyPath"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "SourceFileId", "TargetFileId", "PathLength", "PathString", "IsCircular", "CreatedAt"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"SourceFileId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SourceFileId = "SourceFileId";    //源文件Id

 /// <summary>
 /// 常量:"TargetFileId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TargetFileId = "TargetFileId";    //目标文件Id

 /// <summary>
 /// 常量:"PathLength"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PathLength = "PathLength";    //路径长度

 /// <summary>
 /// 常量:"PathString"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PathString = "PathString";    //路径字符串

 /// <summary>
 /// 常量:"IsCircular"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsCircular = "IsCircular";    //是否循环依赖

 /// <summary>
 /// 常量:"CreatedAt"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreatedAt = "CreatedAt";    //建立时间
}

}