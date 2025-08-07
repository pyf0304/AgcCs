
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewBtnOptStepsEN
 表名:ViewBtnOptSteps(00050094)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:17:43
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:操作步骤管理(OpStepManage)
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
 /// 表ViewBtnOptSteps的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_ViewBtnOptSteps
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
public K_mId_ViewBtnOptSteps(long lngmId)
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
 /// <returns>返回:[K_mId_ViewBtnOptSteps]类型的对象</returns>
public static implicit operator K_mId_ViewBtnOptSteps(long value)
{
return new K_mId_ViewBtnOptSteps(value);
}
}
 /// <summary>
 /// 界面按钮操作步骤(ViewBtnOptSteps)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsViewBtnOptStepsEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接，如果为空就使用系统默认的连接
public new const string _CurrTabName = "ViewBtnOptSteps"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string WhereFormat = ""; //条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"mId", "ViewId", "BtnName", "BtnOptFunction", "BtnStepDetail"};

protected long mlngmId;    //mId
protected string mstrViewId;    //界面Id
protected string mstrBtnName;    //BtnName
protected string mstrBtnOptFunction;    //BtnOptFunction
protected string mstrBtnStepDetail;    //BtnStepDetail

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsViewBtnOptStepsEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "ViewBtnOptSteps";
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:mId</param>
public clsViewBtnOptStepsEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "ViewBtnOptSteps";
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
if (strAttributeName  ==  conViewBtnOptSteps.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conViewBtnOptSteps.ViewId)
{
return mstrViewId;
}
else if (strAttributeName  ==  conViewBtnOptSteps.BtnName)
{
return mstrBtnName;
}
else if (strAttributeName  ==  conViewBtnOptSteps.BtnOptFunction)
{
return mstrBtnOptFunction;
}
else if (strAttributeName  ==  conViewBtnOptSteps.BtnStepDetail)
{
return mstrBtnStepDetail;
}
return null;
}
set
{
if (strAttributeName  ==  conViewBtnOptSteps.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewBtnOptSteps.mId);
}
else if (strAttributeName  ==  conViewBtnOptSteps.ViewId)
{
mstrViewId = value.ToString();
 AddUpdatedFld(conViewBtnOptSteps.ViewId);
}
else if (strAttributeName  ==  conViewBtnOptSteps.BtnName)
{
mstrBtnName = value.ToString();
 AddUpdatedFld(conViewBtnOptSteps.BtnName);
}
else if (strAttributeName  ==  conViewBtnOptSteps.BtnOptFunction)
{
mstrBtnOptFunction = value.ToString();
 AddUpdatedFld(conViewBtnOptSteps.BtnOptFunction);
}
else if (strAttributeName  ==  conViewBtnOptSteps.BtnStepDetail)
{
mstrBtnStepDetail = value.ToString();
 AddUpdatedFld(conViewBtnOptSteps.BtnStepDetail);
}
}
}
public object this[int intIndex]
{
get
{
if (conViewBtnOptSteps.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conViewBtnOptSteps.ViewId  ==  AttributeName[intIndex])
{
return mstrViewId;
}
else if (conViewBtnOptSteps.BtnName  ==  AttributeName[intIndex])
{
return mstrBtnName;
}
else if (conViewBtnOptSteps.BtnOptFunction  ==  AttributeName[intIndex])
{
return mstrBtnOptFunction;
}
else if (conViewBtnOptSteps.BtnStepDetail  ==  AttributeName[intIndex])
{
return mstrBtnStepDetail;
}
return null;
}
set
{
if (conViewBtnOptSteps.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewBtnOptSteps.mId);
}
else if (conViewBtnOptSteps.ViewId  ==  AttributeName[intIndex])
{
mstrViewId = value.ToString();
 AddUpdatedFld(conViewBtnOptSteps.ViewId);
}
else if (conViewBtnOptSteps.BtnName  ==  AttributeName[intIndex])
{
mstrBtnName = value.ToString();
 AddUpdatedFld(conViewBtnOptSteps.BtnName);
}
else if (conViewBtnOptSteps.BtnOptFunction  ==  AttributeName[intIndex])
{
mstrBtnOptFunction = value.ToString();
 AddUpdatedFld(conViewBtnOptSteps.BtnOptFunction);
}
else if (conViewBtnOptSteps.BtnStepDetail  ==  AttributeName[intIndex])
{
mstrBtnStepDetail = value.ToString();
 AddUpdatedFld(conViewBtnOptSteps.BtnStepDetail);
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
 AddUpdatedFld(conViewBtnOptSteps.mId);
}
}
/// <summary>
/// 界面Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewId
{
get
{
return mstrViewId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewId = value;
}
else
{
 mstrViewId = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewBtnOptSteps.ViewId);
}
}
/// <summary>
/// BtnName(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string BtnName
{
get
{
return mstrBtnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrBtnName = value;
}
else
{
 mstrBtnName = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewBtnOptSteps.BtnName);
}
}
/// <summary>
/// BtnOptFunction(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string BtnOptFunction
{
get
{
return mstrBtnOptFunction;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrBtnOptFunction = value;
}
else
{
 mstrBtnOptFunction = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewBtnOptSteps.BtnOptFunction);
}
}
/// <summary>
/// BtnStepDetail(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string BtnStepDetail
{
get
{
return mstrBtnStepDetail;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrBtnStepDetail = value;
}
else
{
 mstrBtnStepDetail = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewBtnOptSteps.BtnStepDetail);
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
 /// 界面按钮操作步骤(ViewBtnOptSteps)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conViewBtnOptSteps
{
public new const string _CurrTabName = "ViewBtnOptSteps"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "ViewId", "BtnName", "BtnOptFunction", "BtnStepDetail"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"ViewId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewId = "ViewId";    //界面Id

 /// <summary>
 /// 常量:"BtnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BtnName = "BtnName";    //BtnName

 /// <summary>
 /// 常量:"BtnOptFunction"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BtnOptFunction = "BtnOptFunction";    //BtnOptFunction

 /// <summary>
 /// 常量:"BtnStepDetail"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BtnStepDetail = "BtnStepDetail";    //BtnStepDetail
}

}