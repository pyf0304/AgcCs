
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFuncParaRela_SimEN
 表名:vFuncParaRela_Sim(00050630)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:48:44
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
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
 /// 表vFuncParaRela_Sim的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vFuncParaRela_Sim
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
public K_mId_vFuncParaRela_Sim(long lngmId)
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
 /// <returns>返回:[K_mId_vFuncParaRela_Sim]类型的对象</returns>
public static implicit operator K_mId_vFuncParaRela_Sim(long value)
{
return new K_mId_vFuncParaRela_Sim(value);
}
}
 /// <summary>
 /// vFuncParaRela_Sim(vFuncParaRela_Sim)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvFuncParaRela_SimEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vFuncParaRela_Sim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 4;
public static string[] _AttributeName = new string[] {"mId", "FuncParaId4Code", "FuncId4Code", "OrderNum"};

protected long mlngmId;    //mId
protected string mstrFuncParaId4Code;    //函数参数Id
protected string mstrFuncId4Code;    //函数Id4Code
protected int? mintOrderNum;    //序号

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvFuncParaRela_SimEN()
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
public clsvFuncParaRela_SimEN(long lngmId)
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
if (strAttributeName  ==  convFuncParaRela_Sim.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convFuncParaRela_Sim.FuncParaId4Code)
{
return mstrFuncParaId4Code;
}
else if (strAttributeName  ==  convFuncParaRela_Sim.FuncId4Code)
{
return mstrFuncId4Code;
}
else if (strAttributeName  ==  convFuncParaRela_Sim.OrderNum)
{
return mintOrderNum;
}
return null;
}
set
{
if (strAttributeName  ==  convFuncParaRela_Sim.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convFuncParaRela_Sim.mId);
}
else if (strAttributeName  ==  convFuncParaRela_Sim.FuncParaId4Code)
{
mstrFuncParaId4Code = value.ToString();
 AddUpdatedFld(convFuncParaRela_Sim.FuncParaId4Code);
}
else if (strAttributeName  ==  convFuncParaRela_Sim.FuncId4Code)
{
mstrFuncId4Code = value.ToString();
 AddUpdatedFld(convFuncParaRela_Sim.FuncId4Code);
}
else if (strAttributeName  ==  convFuncParaRela_Sim.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFuncParaRela_Sim.OrderNum);
}
}
}
public object this[int intIndex]
{
get
{
if (convFuncParaRela_Sim.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (convFuncParaRela_Sim.FuncParaId4Code  ==  _AttributeName[intIndex])
{
return mstrFuncParaId4Code;
}
else if (convFuncParaRela_Sim.FuncId4Code  ==  _AttributeName[intIndex])
{
return mstrFuncId4Code;
}
else if (convFuncParaRela_Sim.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
return null;
}
set
{
if (convFuncParaRela_Sim.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convFuncParaRela_Sim.mId);
}
else if (convFuncParaRela_Sim.FuncParaId4Code  ==  _AttributeName[intIndex])
{
mstrFuncParaId4Code = value.ToString();
 AddUpdatedFld(convFuncParaRela_Sim.FuncParaId4Code);
}
else if (convFuncParaRela_Sim.FuncId4Code  ==  _AttributeName[intIndex])
{
mstrFuncId4Code = value.ToString();
 AddUpdatedFld(convFuncParaRela_Sim.FuncId4Code);
}
else if (convFuncParaRela_Sim.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFuncParaRela_Sim.OrderNum);
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
 AddUpdatedFld(convFuncParaRela_Sim.mId);
}
}
/// <summary>
/// 函数参数Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncParaId4Code
{
get
{
return mstrFuncParaId4Code;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncParaId4Code = value;
}
else
{
 mstrFuncParaId4Code = value;
}
//记录修改过的字段
 AddUpdatedFld(convFuncParaRela_Sim.FuncParaId4Code);
}
}
/// <summary>
/// 函数Id4Code(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncId4Code
{
get
{
return mstrFuncId4Code;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncId4Code = value;
}
else
{
 mstrFuncId4Code = value;
}
//记录修改过的字段
 AddUpdatedFld(convFuncParaRela_Sim.FuncId4Code);
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
 AddUpdatedFld(convFuncParaRela_Sim.OrderNum);
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
 /// vFuncParaRela_Sim(vFuncParaRela_Sim)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convFuncParaRela_Sim
{
public const string _CurrTabName = "vFuncParaRela_Sim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "FuncParaId4Code", "FuncId4Code", "OrderNum"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"FuncParaId4Code"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncParaId4Code = "FuncParaId4Code";    //函数参数Id

 /// <summary>
 /// 常量:"FuncId4Code"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncId4Code = "FuncId4Code";    //函数Id4Code

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号
}

}