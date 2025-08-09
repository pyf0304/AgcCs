
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCMProjectAppRelaEN
 表名:CMProjectAppRela(00050600)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 19:59:45
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
 /// 表CMProjectAppRela的关键字(CMProjectAppRelaId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CMProjectAppRelaId_CMProjectAppRela
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngCMProjectAppRelaId">表关键字</param>
public K_CMProjectAppRelaId_CMProjectAppRela(long lngCMProjectAppRelaId)
{
if (IsValid(lngCMProjectAppRelaId)) Value = lngCMProjectAppRelaId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngCMProjectAppRelaId)
{
if (lngCMProjectAppRelaId == 0) return false;
if (lngCMProjectAppRelaId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_CMProjectAppRelaId_CMProjectAppRela]类型的对象</returns>
public static implicit operator K_CMProjectAppRelaId_CMProjectAppRela(long value)
{
return new K_CMProjectAppRelaId_CMProjectAppRela(value);
}
}
 /// <summary>
 /// CM项目应用关系(CMProjectAppRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCMProjectAppRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CMProjectAppRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "CMProjectAppRelaId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 8;
public static string[] _AttributeName = new string[] {"CMProjectAppRelaId", "CmPrjId", "ApplicationTypeId", "OrderNum", "PrjId", "UpdDate", "UpdUser", "Memo"};

protected long mlngCMProjectAppRelaId;    //Cm工程应用关系Id
protected string mstrCmPrjId;    //Cm工程Id
protected int mintApplicationTypeId;    //应用程序类型ID
protected int mintOrderNum;    //序号
protected string mstrPrjId;    //工程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsCMProjectAppRelaEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CMProjectAppRelaId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "lngCMProjectAppRelaId">关键字:Cm工程应用关系Id</param>
public clsCMProjectAppRelaEN(long lngCMProjectAppRelaId)
 {
 if (lngCMProjectAppRelaId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngCMProjectAppRelaId = lngCMProjectAppRelaId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CMProjectAppRelaId");
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
if (strAttributeName  ==  conCMProjectAppRela.CMProjectAppRelaId)
{
return mlngCMProjectAppRelaId;
}
else if (strAttributeName  ==  conCMProjectAppRela.CmPrjId)
{
return mstrCmPrjId;
}
else if (strAttributeName  ==  conCMProjectAppRela.ApplicationTypeId)
{
return mintApplicationTypeId;
}
else if (strAttributeName  ==  conCMProjectAppRela.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conCMProjectAppRela.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conCMProjectAppRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conCMProjectAppRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conCMProjectAppRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conCMProjectAppRela.CMProjectAppRelaId)
{
mlngCMProjectAppRelaId = TransNullToInt(value.ToString());
 AddUpdatedFld(conCMProjectAppRela.CMProjectAppRelaId);
}
else if (strAttributeName  ==  conCMProjectAppRela.CmPrjId)
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(conCMProjectAppRela.CmPrjId);
}
else if (strAttributeName  ==  conCMProjectAppRela.ApplicationTypeId)
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conCMProjectAppRela.ApplicationTypeId);
}
else if (strAttributeName  ==  conCMProjectAppRela.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conCMProjectAppRela.OrderNum);
}
else if (strAttributeName  ==  conCMProjectAppRela.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conCMProjectAppRela.PrjId);
}
else if (strAttributeName  ==  conCMProjectAppRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCMProjectAppRela.UpdDate);
}
else if (strAttributeName  ==  conCMProjectAppRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conCMProjectAppRela.UpdUser);
}
else if (strAttributeName  ==  conCMProjectAppRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCMProjectAppRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conCMProjectAppRela.CMProjectAppRelaId  ==  _AttributeName[intIndex])
{
return mlngCMProjectAppRelaId;
}
else if (conCMProjectAppRela.CmPrjId  ==  _AttributeName[intIndex])
{
return mstrCmPrjId;
}
else if (conCMProjectAppRela.ApplicationTypeId  ==  _AttributeName[intIndex])
{
return mintApplicationTypeId;
}
else if (conCMProjectAppRela.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conCMProjectAppRela.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conCMProjectAppRela.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conCMProjectAppRela.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conCMProjectAppRela.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conCMProjectAppRela.CMProjectAppRelaId  ==  _AttributeName[intIndex])
{
mlngCMProjectAppRelaId = TransNullToInt(value.ToString());
 AddUpdatedFld(conCMProjectAppRela.CMProjectAppRelaId);
}
else if (conCMProjectAppRela.CmPrjId  ==  _AttributeName[intIndex])
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(conCMProjectAppRela.CmPrjId);
}
else if (conCMProjectAppRela.ApplicationTypeId  ==  _AttributeName[intIndex])
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conCMProjectAppRela.ApplicationTypeId);
}
else if (conCMProjectAppRela.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conCMProjectAppRela.OrderNum);
}
else if (conCMProjectAppRela.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conCMProjectAppRela.PrjId);
}
else if (conCMProjectAppRela.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCMProjectAppRela.UpdDate);
}
else if (conCMProjectAppRela.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conCMProjectAppRela.UpdUser);
}
else if (conCMProjectAppRela.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCMProjectAppRela.Memo);
}
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
 AddUpdatedFld(conCMProjectAppRela.CMProjectAppRelaId);
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
 AddUpdatedFld(conCMProjectAppRela.CmPrjId);
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
 AddUpdatedFld(conCMProjectAppRela.ApplicationTypeId);
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
 AddUpdatedFld(conCMProjectAppRela.OrderNum);
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
 AddUpdatedFld(conCMProjectAppRela.PrjId);
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
 AddUpdatedFld(conCMProjectAppRela.UpdDate);
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
 AddUpdatedFld(conCMProjectAppRela.UpdUser);
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
 AddUpdatedFld(conCMProjectAppRela.Memo);
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
  return mlngCMProjectAppRelaId.ToString();
 }
 }
}
 /// <summary>
 /// CM项目应用关系(CMProjectAppRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCMProjectAppRela
{
public const string _CurrTabName = "CMProjectAppRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CMProjectAppRelaId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"CMProjectAppRelaId", "CmPrjId", "ApplicationTypeId", "OrderNum", "PrjId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"CMProjectAppRelaId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CMProjectAppRelaId = "CMProjectAppRelaId";    //Cm工程应用关系Id

 /// <summary>
 /// 常量:"CmPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CmPrjId = "CmPrjId";    //Cm工程Id

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
 public const string PrjId = "PrjId";    //工程Id

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