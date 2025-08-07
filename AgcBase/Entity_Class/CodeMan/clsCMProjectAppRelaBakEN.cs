
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCMProjectAppRelaBakEN
 表名:CMProjectAppRelaBak(00050600)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:13:27
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:代码管理(CodeMan)
 框架-层名:实体层(CS)(EntityLayer)
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

namespace AGC.Entity
{
 /// <summary>
 /// 表CMProjectAppRelaBak的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_CMProjectAppRelaBak
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
public K_mId_CMProjectAppRelaBak(long lngmId)
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
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_mId_CMProjectAppRelaBak]类型的对象</returns>
public static implicit operator K_mId_CMProjectAppRelaBak(long value)
{
return new K_mId_CMProjectAppRelaBak(value);
}
}
 /// <summary>
 /// CM项目应用关系(CMProjectAppRelaBak)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCMProjectAppRelaBakEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接，如果为空就使用系统默认的连接
public new const string _CurrTabName = "CMProjectAppRelaBak"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string WhereFormat = ""; //条件格式串
protected const int mintAttributeCount = 8;
public static string[] AttributeName = new string[] {"mId", "CmPrjId", "ApplicationTypeId", "OrderNum", "PrjId", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrCmPrjId;    //CM工程Id
protected int mintApplicationTypeId;    //应用程序类型ID
protected int mintOrderNum;    //序号
protected string mstrPrjId;    //工程ID
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsCMProjectAppRelaBakEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "CMProjectAppRelaBak";
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:mId</param>
public clsCMProjectAppRelaBakEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "CMProjectAppRelaBak";
 lstKeyFldNames.Add("mId");
 }

public static int AttributeCount
{
get
{
return mintAttributeCount;
}
}
public override object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  conCMProjectAppRelaBak.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conCMProjectAppRelaBak.CmPrjId)
{
return mstrCmPrjId;
}
else if (strAttributeName  ==  conCMProjectAppRelaBak.ApplicationTypeId)
{
return mintApplicationTypeId;
}
else if (strAttributeName  ==  conCMProjectAppRelaBak.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conCMProjectAppRelaBak.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conCMProjectAppRelaBak.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conCMProjectAppRelaBak.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conCMProjectAppRelaBak.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conCMProjectAppRelaBak.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conCMProjectAppRelaBak.mId);
}
else if (strAttributeName  ==  conCMProjectAppRelaBak.CmPrjId)
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(conCMProjectAppRelaBak.CmPrjId);
}
else if (strAttributeName  ==  conCMProjectAppRelaBak.ApplicationTypeId)
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conCMProjectAppRelaBak.ApplicationTypeId);
}
else if (strAttributeName  ==  conCMProjectAppRelaBak.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conCMProjectAppRelaBak.OrderNum);
}
else if (strAttributeName  ==  conCMProjectAppRelaBak.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conCMProjectAppRelaBak.PrjId);
}
else if (strAttributeName  ==  conCMProjectAppRelaBak.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCMProjectAppRelaBak.UpdDate);
}
else if (strAttributeName  ==  conCMProjectAppRelaBak.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conCMProjectAppRelaBak.UpdUser);
}
else if (strAttributeName  ==  conCMProjectAppRelaBak.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCMProjectAppRelaBak.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conCMProjectAppRelaBak.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conCMProjectAppRelaBak.CmPrjId  ==  AttributeName[intIndex])
{
return mstrCmPrjId;
}
else if (conCMProjectAppRelaBak.ApplicationTypeId  ==  AttributeName[intIndex])
{
return mintApplicationTypeId;
}
else if (conCMProjectAppRelaBak.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conCMProjectAppRelaBak.PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conCMProjectAppRelaBak.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conCMProjectAppRelaBak.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conCMProjectAppRelaBak.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conCMProjectAppRelaBak.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conCMProjectAppRelaBak.mId);
}
else if (conCMProjectAppRelaBak.CmPrjId  ==  AttributeName[intIndex])
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(conCMProjectAppRelaBak.CmPrjId);
}
else if (conCMProjectAppRelaBak.ApplicationTypeId  ==  AttributeName[intIndex])
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conCMProjectAppRelaBak.ApplicationTypeId);
}
else if (conCMProjectAppRelaBak.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conCMProjectAppRelaBak.OrderNum);
}
else if (conCMProjectAppRelaBak.PrjId  ==  AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conCMProjectAppRelaBak.PrjId);
}
else if (conCMProjectAppRelaBak.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCMProjectAppRelaBak.UpdDate);
}
else if (conCMProjectAppRelaBak.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conCMProjectAppRelaBak.UpdUser);
}
else if (conCMProjectAppRelaBak.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCMProjectAppRelaBak.Memo);
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
 AddUpdatedFld(conCMProjectAppRelaBak.mId);
}
}
/// <summary>
/// CM工程Id(说明:;字段类型:char;字段长度:6;是否可空:False)
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
 AddUpdatedFld(conCMProjectAppRelaBak.CmPrjId);
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
 AddUpdatedFld(conCMProjectAppRelaBak.ApplicationTypeId);
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
 AddUpdatedFld(conCMProjectAppRelaBak.OrderNum);
}
}
/// <summary>
/// 工程ID(说明:;字段类型:char;字段长度:4;是否可空:False)
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
 AddUpdatedFld(conCMProjectAppRelaBak.PrjId);
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
 AddUpdatedFld(conCMProjectAppRelaBak.UpdDate);
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
 AddUpdatedFld(conCMProjectAppRelaBak.UpdUser);
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
 AddUpdatedFld(conCMProjectAppRelaBak.Memo);
}
}

/// <summary>
/// 获取关键字Id(keyId)
 /// (AutoGCLib.clsGeneCodeBase:GenGetKeyId)
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
 /// CM项目应用关系(CMProjectAppRelaBak)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCMProjectAppRelaBak
{
public new const string _CurrTabName = "CMProjectAppRelaBak"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "CmPrjId", "ApplicationTypeId", "OrderNum", "PrjId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"CmPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CmPrjId = "CmPrjId";    //CM工程Id

 /// <summary>
 /// 常量:"ApplicationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeId = "ApplicationTypeId";    //应用程序类型ID

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程ID

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