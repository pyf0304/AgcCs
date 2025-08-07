
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTabCheckStatus_SimEN
 表名:vTabCheckStatus_Sim(00050599)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:35:05
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:日志管理(LogManage)
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
 /// 表vTabCheckStatus_Sim的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vTabCheckStatus_Sim
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
public K_mId_vTabCheckStatus_Sim(long lngmId)
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
 /// <returns>返回:[K_mId_vTabCheckStatus_Sim]类型的对象</returns>
public static implicit operator K_mId_vTabCheckStatus_Sim(long value)
{
return new K_mId_vTabCheckStatus_Sim(value);
}
}
 /// <summary>
 /// v表检查状态_Sim(vTabCheckStatus_Sim)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvTabCheckStatus_SimEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vTabCheckStatus_Sim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 6;
public static string[] _AttributeName = new string[] {"mId", "PrjId", "TabId", "ErrorLevelId", "ErrorMsg", "PrjDataBaseId"};

protected long mlngmId;    //mId
protected string mstrPrjId;    //工程Id
protected string mstrTabId;    //表ID
protected int mintErrorLevelId;    //错误等级Id
protected string mstrErrorMsg;    //错误信息
protected string mstrPrjDataBaseId;    //项目数据库Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvTabCheckStatus_SimEN()
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
public clsvTabCheckStatus_SimEN(long lngmId)
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
if (strAttributeName  ==  convTabCheckStatus_Sim.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convTabCheckStatus_Sim.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convTabCheckStatus_Sim.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  convTabCheckStatus_Sim.ErrorLevelId)
{
return mintErrorLevelId;
}
else if (strAttributeName  ==  convTabCheckStatus_Sim.ErrorMsg)
{
return mstrErrorMsg;
}
else if (strAttributeName  ==  convTabCheckStatus_Sim.PrjDataBaseId)
{
return mstrPrjDataBaseId;
}
return null;
}
set
{
if (strAttributeName  ==  convTabCheckStatus_Sim.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convTabCheckStatus_Sim.mId);
}
else if (strAttributeName  ==  convTabCheckStatus_Sim.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convTabCheckStatus_Sim.PrjId);
}
else if (strAttributeName  ==  convTabCheckStatus_Sim.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(convTabCheckStatus_Sim.TabId);
}
else if (strAttributeName  ==  convTabCheckStatus_Sim.ErrorLevelId)
{
mintErrorLevelId = TransNullToInt(value.ToString());
 AddUpdatedFld(convTabCheckStatus_Sim.ErrorLevelId);
}
else if (strAttributeName  ==  convTabCheckStatus_Sim.ErrorMsg)
{
mstrErrorMsg = value.ToString();
 AddUpdatedFld(convTabCheckStatus_Sim.ErrorMsg);
}
else if (strAttributeName  ==  convTabCheckStatus_Sim.PrjDataBaseId)
{
mstrPrjDataBaseId = value.ToString();
 AddUpdatedFld(convTabCheckStatus_Sim.PrjDataBaseId);
}
}
}
public object this[int intIndex]
{
get
{
if (convTabCheckStatus_Sim.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (convTabCheckStatus_Sim.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convTabCheckStatus_Sim.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (convTabCheckStatus_Sim.ErrorLevelId  ==  _AttributeName[intIndex])
{
return mintErrorLevelId;
}
else if (convTabCheckStatus_Sim.ErrorMsg  ==  _AttributeName[intIndex])
{
return mstrErrorMsg;
}
else if (convTabCheckStatus_Sim.PrjDataBaseId  ==  _AttributeName[intIndex])
{
return mstrPrjDataBaseId;
}
return null;
}
set
{
if (convTabCheckStatus_Sim.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convTabCheckStatus_Sim.mId);
}
else if (convTabCheckStatus_Sim.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convTabCheckStatus_Sim.PrjId);
}
else if (convTabCheckStatus_Sim.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(convTabCheckStatus_Sim.TabId);
}
else if (convTabCheckStatus_Sim.ErrorLevelId  ==  _AttributeName[intIndex])
{
mintErrorLevelId = TransNullToInt(value.ToString());
 AddUpdatedFld(convTabCheckStatus_Sim.ErrorLevelId);
}
else if (convTabCheckStatus_Sim.ErrorMsg  ==  _AttributeName[intIndex])
{
mstrErrorMsg = value.ToString();
 AddUpdatedFld(convTabCheckStatus_Sim.ErrorMsg);
}
else if (convTabCheckStatus_Sim.PrjDataBaseId  ==  _AttributeName[intIndex])
{
mstrPrjDataBaseId = value.ToString();
 AddUpdatedFld(convTabCheckStatus_Sim.PrjDataBaseId);
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
 AddUpdatedFld(convTabCheckStatus_Sim.mId);
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
 AddUpdatedFld(convTabCheckStatus_Sim.PrjId);
}
}
/// <summary>
/// 表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabId
{
get
{
return mstrTabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabId = value;
}
else
{
 mstrTabId = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabCheckStatus_Sim.TabId);
}
}
/// <summary>
/// 错误等级Id(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int ErrorLevelId
{
get
{
return mintErrorLevelId;
}
set
{
 mintErrorLevelId = value;
//记录修改过的字段
 AddUpdatedFld(convTabCheckStatus_Sim.ErrorLevelId);
}
}
/// <summary>
/// 错误信息(说明:;字段类型:varchar;字段长度:5000;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ErrorMsg
{
get
{
return mstrErrorMsg;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrErrorMsg = value;
}
else
{
 mstrErrorMsg = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabCheckStatus_Sim.ErrorMsg);
}
}
/// <summary>
/// 项目数据库Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjDataBaseId
{
get
{
return mstrPrjDataBaseId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjDataBaseId = value;
}
else
{
 mstrPrjDataBaseId = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabCheckStatus_Sim.PrjDataBaseId);
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
 /// v表检查状态_Sim(vTabCheckStatus_Sim)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convTabCheckStatus_Sim
{
public const string _CurrTabName = "vTabCheckStatus_Sim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "PrjId", "TabId", "ErrorLevelId", "ErrorMsg", "PrjDataBaseId"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"TabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabId = "TabId";    //表ID

 /// <summary>
 /// 常量:"ErrorLevelId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ErrorLevelId = "ErrorLevelId";    //错误等级Id

 /// <summary>
 /// 常量:"ErrorMsg"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ErrorMsg = "ErrorMsg";    //错误信息

 /// <summary>
 /// 常量:"PrjDataBaseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjDataBaseId = "PrjDataBaseId";    //项目数据库Id
}

}