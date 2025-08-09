
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFunctionRelaEN
 表名:vFunctionRela(00050321)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:12:22
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
 /// 表vFunctionRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vFunctionRela
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
public K_mId_vFunctionRela(long lngmId)
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
 /// <returns>返回:[K_mId_vFunctionRela]类型的对象</returns>
public static implicit operator K_mId_vFunctionRela(long value)
{
return new K_mId_vFunctionRela(value);
}
}
 /// <summary>
 /// v函数与函数关系(vFunctionRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvFunctionRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vFunctionRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 17;
public static string[] _AttributeName = new string[] {"mId", "FuncAId", "FeatureName", "OrderNum", "Order4FeatureNum", "FuncBId", "FunctionRelaTypeId", "FunctionRelaTypeName", "UpdDate", "UpdUser", "Memo", "FuncAName", "ProgLangTypeIdA", "ProgLangTypeNameA", "FuncBName", "ProgLangTypeIdB", "ProgLangTypeNameB"};

protected long mlngmId;    //mId
protected string mstrFuncAId;    //函数AId
protected string mstrFeatureName;    //功能名称
protected int? mintOrderNum;    //序号
protected int? mintOrder4FeatureNum;    //Order4FeatureNum
protected string mstrFuncBId;    //函数BId
protected string mstrFunctionRelaTypeId;    //函数关系类型Id
protected string mstrFunctionRelaTypeName;    //函数关系类型名称
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明
protected string mstrFuncAName;    //FuncAName
protected string mstrProgLangTypeIdA;    //ProgLangTypeIdA
protected string mstrProgLangTypeNameA;    //ProgLangTypeNameA
protected string mstrFuncBName;    //FuncBName
protected string mstrProgLangTypeIdB;    //ProgLangTypeIdB
protected string mstrProgLangTypeNameB;    //ProgLangTypeNameB

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvFunctionRelaEN()
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
public clsvFunctionRelaEN(long lngmId)
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
if (strAttributeName  ==  convFunctionRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convFunctionRela.FuncAId)
{
return mstrFuncAId;
}
else if (strAttributeName  ==  convFunctionRela.FeatureName)
{
return mstrFeatureName;
}
else if (strAttributeName  ==  convFunctionRela.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convFunctionRela.Order4FeatureNum)
{
return mintOrder4FeatureNum;
}
else if (strAttributeName  ==  convFunctionRela.FuncBId)
{
return mstrFuncBId;
}
else if (strAttributeName  ==  convFunctionRela.FunctionRelaTypeId)
{
return mstrFunctionRelaTypeId;
}
else if (strAttributeName  ==  convFunctionRela.FunctionRelaTypeName)
{
return mstrFunctionRelaTypeName;
}
else if (strAttributeName  ==  convFunctionRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convFunctionRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convFunctionRela.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convFunctionRela.FuncAName)
{
return mstrFuncAName;
}
else if (strAttributeName  ==  convFunctionRela.ProgLangTypeIdA)
{
return mstrProgLangTypeIdA;
}
else if (strAttributeName  ==  convFunctionRela.ProgLangTypeNameA)
{
return mstrProgLangTypeNameA;
}
else if (strAttributeName  ==  convFunctionRela.FuncBName)
{
return mstrFuncBName;
}
else if (strAttributeName  ==  convFunctionRela.ProgLangTypeIdB)
{
return mstrProgLangTypeIdB;
}
else if (strAttributeName  ==  convFunctionRela.ProgLangTypeNameB)
{
return mstrProgLangTypeNameB;
}
return null;
}
set
{
if (strAttributeName  ==  convFunctionRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convFunctionRela.mId);
}
else if (strAttributeName  ==  convFunctionRela.FuncAId)
{
mstrFuncAId = value.ToString();
 AddUpdatedFld(convFunctionRela.FuncAId);
}
else if (strAttributeName  ==  convFunctionRela.FeatureName)
{
mstrFeatureName = value.ToString();
 AddUpdatedFld(convFunctionRela.FeatureName);
}
else if (strAttributeName  ==  convFunctionRela.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFunctionRela.OrderNum);
}
else if (strAttributeName  ==  convFunctionRela.Order4FeatureNum)
{
mintOrder4FeatureNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFunctionRela.Order4FeatureNum);
}
else if (strAttributeName  ==  convFunctionRela.FuncBId)
{
mstrFuncBId = value.ToString();
 AddUpdatedFld(convFunctionRela.FuncBId);
}
else if (strAttributeName  ==  convFunctionRela.FunctionRelaTypeId)
{
mstrFunctionRelaTypeId = value.ToString();
 AddUpdatedFld(convFunctionRela.FunctionRelaTypeId);
}
else if (strAttributeName  ==  convFunctionRela.FunctionRelaTypeName)
{
mstrFunctionRelaTypeName = value.ToString();
 AddUpdatedFld(convFunctionRela.FunctionRelaTypeName);
}
else if (strAttributeName  ==  convFunctionRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFunctionRela.UpdDate);
}
else if (strAttributeName  ==  convFunctionRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFunctionRela.UpdUser);
}
else if (strAttributeName  ==  convFunctionRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFunctionRela.Memo);
}
else if (strAttributeName  ==  convFunctionRela.FuncAName)
{
mstrFuncAName = value.ToString();
 AddUpdatedFld(convFunctionRela.FuncAName);
}
else if (strAttributeName  ==  convFunctionRela.ProgLangTypeIdA)
{
mstrProgLangTypeIdA = value.ToString();
 AddUpdatedFld(convFunctionRela.ProgLangTypeIdA);
}
else if (strAttributeName  ==  convFunctionRela.ProgLangTypeNameA)
{
mstrProgLangTypeNameA = value.ToString();
 AddUpdatedFld(convFunctionRela.ProgLangTypeNameA);
}
else if (strAttributeName  ==  convFunctionRela.FuncBName)
{
mstrFuncBName = value.ToString();
 AddUpdatedFld(convFunctionRela.FuncBName);
}
else if (strAttributeName  ==  convFunctionRela.ProgLangTypeIdB)
{
mstrProgLangTypeIdB = value.ToString();
 AddUpdatedFld(convFunctionRela.ProgLangTypeIdB);
}
else if (strAttributeName  ==  convFunctionRela.ProgLangTypeNameB)
{
mstrProgLangTypeNameB = value.ToString();
 AddUpdatedFld(convFunctionRela.ProgLangTypeNameB);
}
}
}
public object this[int intIndex]
{
get
{
if (convFunctionRela.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (convFunctionRela.FuncAId  ==  _AttributeName[intIndex])
{
return mstrFuncAId;
}
else if (convFunctionRela.FeatureName  ==  _AttributeName[intIndex])
{
return mstrFeatureName;
}
else if (convFunctionRela.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convFunctionRela.Order4FeatureNum  ==  _AttributeName[intIndex])
{
return mintOrder4FeatureNum;
}
else if (convFunctionRela.FuncBId  ==  _AttributeName[intIndex])
{
return mstrFuncBId;
}
else if (convFunctionRela.FunctionRelaTypeId  ==  _AttributeName[intIndex])
{
return mstrFunctionRelaTypeId;
}
else if (convFunctionRela.FunctionRelaTypeName  ==  _AttributeName[intIndex])
{
return mstrFunctionRelaTypeName;
}
else if (convFunctionRela.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convFunctionRela.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convFunctionRela.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (convFunctionRela.FuncAName  ==  _AttributeName[intIndex])
{
return mstrFuncAName;
}
else if (convFunctionRela.ProgLangTypeIdA  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeIdA;
}
else if (convFunctionRela.ProgLangTypeNameA  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeNameA;
}
else if (convFunctionRela.FuncBName  ==  _AttributeName[intIndex])
{
return mstrFuncBName;
}
else if (convFunctionRela.ProgLangTypeIdB  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeIdB;
}
else if (convFunctionRela.ProgLangTypeNameB  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeNameB;
}
return null;
}
set
{
if (convFunctionRela.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convFunctionRela.mId);
}
else if (convFunctionRela.FuncAId  ==  _AttributeName[intIndex])
{
mstrFuncAId = value.ToString();
 AddUpdatedFld(convFunctionRela.FuncAId);
}
else if (convFunctionRela.FeatureName  ==  _AttributeName[intIndex])
{
mstrFeatureName = value.ToString();
 AddUpdatedFld(convFunctionRela.FeatureName);
}
else if (convFunctionRela.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFunctionRela.OrderNum);
}
else if (convFunctionRela.Order4FeatureNum  ==  _AttributeName[intIndex])
{
mintOrder4FeatureNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFunctionRela.Order4FeatureNum);
}
else if (convFunctionRela.FuncBId  ==  _AttributeName[intIndex])
{
mstrFuncBId = value.ToString();
 AddUpdatedFld(convFunctionRela.FuncBId);
}
else if (convFunctionRela.FunctionRelaTypeId  ==  _AttributeName[intIndex])
{
mstrFunctionRelaTypeId = value.ToString();
 AddUpdatedFld(convFunctionRela.FunctionRelaTypeId);
}
else if (convFunctionRela.FunctionRelaTypeName  ==  _AttributeName[intIndex])
{
mstrFunctionRelaTypeName = value.ToString();
 AddUpdatedFld(convFunctionRela.FunctionRelaTypeName);
}
else if (convFunctionRela.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFunctionRela.UpdDate);
}
else if (convFunctionRela.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFunctionRela.UpdUser);
}
else if (convFunctionRela.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFunctionRela.Memo);
}
else if (convFunctionRela.FuncAName  ==  _AttributeName[intIndex])
{
mstrFuncAName = value.ToString();
 AddUpdatedFld(convFunctionRela.FuncAName);
}
else if (convFunctionRela.ProgLangTypeIdA  ==  _AttributeName[intIndex])
{
mstrProgLangTypeIdA = value.ToString();
 AddUpdatedFld(convFunctionRela.ProgLangTypeIdA);
}
else if (convFunctionRela.ProgLangTypeNameA  ==  _AttributeName[intIndex])
{
mstrProgLangTypeNameA = value.ToString();
 AddUpdatedFld(convFunctionRela.ProgLangTypeNameA);
}
else if (convFunctionRela.FuncBName  ==  _AttributeName[intIndex])
{
mstrFuncBName = value.ToString();
 AddUpdatedFld(convFunctionRela.FuncBName);
}
else if (convFunctionRela.ProgLangTypeIdB  ==  _AttributeName[intIndex])
{
mstrProgLangTypeIdB = value.ToString();
 AddUpdatedFld(convFunctionRela.ProgLangTypeIdB);
}
else if (convFunctionRela.ProgLangTypeNameB  ==  _AttributeName[intIndex])
{
mstrProgLangTypeNameB = value.ToString();
 AddUpdatedFld(convFunctionRela.ProgLangTypeNameB);
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
 AddUpdatedFld(convFunctionRela.mId);
}
}
/// <summary>
/// 函数AId(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncAId
{
get
{
return mstrFuncAId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncAId = value;
}
else
{
 mstrFuncAId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunctionRela.FuncAId);
}
}
/// <summary>
/// 功能名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FeatureName
{
get
{
return mstrFeatureName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFeatureName = value;
}
else
{
 mstrFeatureName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunctionRela.FeatureName);
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
 AddUpdatedFld(convFunctionRela.OrderNum);
}
}
/// <summary>
/// Order4FeatureNum(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? Order4FeatureNum
{
get
{
return mintOrder4FeatureNum;
}
set
{
 mintOrder4FeatureNum = value;
//记录修改过的字段
 AddUpdatedFld(convFunctionRela.Order4FeatureNum);
}
}
/// <summary>
/// 函数BId(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncBId
{
get
{
return mstrFuncBId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncBId = value;
}
else
{
 mstrFuncBId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunctionRela.FuncBId);
}
}
/// <summary>
/// 函数关系类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FunctionRelaTypeId
{
get
{
return mstrFunctionRelaTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFunctionRelaTypeId = value;
}
else
{
 mstrFunctionRelaTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunctionRela.FunctionRelaTypeId);
}
}
/// <summary>
/// 函数关系类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FunctionRelaTypeName
{
get
{
return mstrFunctionRelaTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFunctionRelaTypeName = value;
}
else
{
 mstrFunctionRelaTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunctionRela.FunctionRelaTypeName);
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
 AddUpdatedFld(convFunctionRela.UpdDate);
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
 AddUpdatedFld(convFunctionRela.UpdUser);
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
 AddUpdatedFld(convFunctionRela.Memo);
}
}
/// <summary>
/// FuncAName(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncAName
{
get
{
return mstrFuncAName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncAName = value;
}
else
{
 mstrFuncAName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunctionRela.FuncAName);
}
}
/// <summary>
/// ProgLangTypeIdA(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLangTypeIdA
{
get
{
return mstrProgLangTypeIdA;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLangTypeIdA = value;
}
else
{
 mstrProgLangTypeIdA = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunctionRela.ProgLangTypeIdA);
}
}
/// <summary>
/// ProgLangTypeNameA(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLangTypeNameA
{
get
{
return mstrProgLangTypeNameA;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLangTypeNameA = value;
}
else
{
 mstrProgLangTypeNameA = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunctionRela.ProgLangTypeNameA);
}
}
/// <summary>
/// FuncBName(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncBName
{
get
{
return mstrFuncBName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncBName = value;
}
else
{
 mstrFuncBName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunctionRela.FuncBName);
}
}
/// <summary>
/// ProgLangTypeIdB(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLangTypeIdB
{
get
{
return mstrProgLangTypeIdB;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLangTypeIdB = value;
}
else
{
 mstrProgLangTypeIdB = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunctionRela.ProgLangTypeIdB);
}
}
/// <summary>
/// ProgLangTypeNameB(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLangTypeNameB
{
get
{
return mstrProgLangTypeNameB;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLangTypeNameB = value;
}
else
{
 mstrProgLangTypeNameB = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunctionRela.ProgLangTypeNameB);
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
 /// v函数与函数关系(vFunctionRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convFunctionRela
{
public const string _CurrTabName = "vFunctionRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "FuncAId", "FeatureName", "OrderNum", "Order4FeatureNum", "FuncBId", "FunctionRelaTypeId", "FunctionRelaTypeName", "UpdDate", "UpdUser", "Memo", "FuncAName", "ProgLangTypeIdA", "ProgLangTypeNameA", "FuncBName", "ProgLangTypeIdB", "ProgLangTypeNameB"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"FuncAId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncAId = "FuncAId";    //函数AId

 /// <summary>
 /// 常量:"FeatureName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeatureName = "FeatureName";    //功能名称

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"Order4FeatureNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Order4FeatureNum = "Order4FeatureNum";    //Order4FeatureNum

 /// <summary>
 /// 常量:"FuncBId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncBId = "FuncBId";    //函数BId

 /// <summary>
 /// 常量:"FunctionRelaTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FunctionRelaTypeId = "FunctionRelaTypeId";    //函数关系类型Id

 /// <summary>
 /// 常量:"FunctionRelaTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FunctionRelaTypeName = "FunctionRelaTypeName";    //函数关系类型名称

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

 /// <summary>
 /// 常量:"FuncAName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncAName = "FuncAName";    //FuncAName

 /// <summary>
 /// 常量:"ProgLangTypeIdA"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeIdA = "ProgLangTypeIdA";    //ProgLangTypeIdA

 /// <summary>
 /// 常量:"ProgLangTypeNameA"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeNameA = "ProgLangTypeNameA";    //ProgLangTypeNameA

 /// <summary>
 /// 常量:"FuncBName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncBName = "FuncBName";    //FuncBName

 /// <summary>
 /// 常量:"ProgLangTypeIdB"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeIdB = "ProgLangTypeIdB";    //ProgLangTypeIdB

 /// <summary>
 /// 常量:"ProgLangTypeNameB"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeNameB = "ProgLangTypeNameB";    //ProgLangTypeNameB
}

}