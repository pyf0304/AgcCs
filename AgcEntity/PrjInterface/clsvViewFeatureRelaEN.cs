
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewFeatureRelaEN
 表名:vViewFeatureRela(00050395)
 生成代码版本:2019.04.19.1
 生成日期:2019/04/19 12:17:10
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:AGC
 工程ID:0005
 相关数据库:101.251.68.133,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:界面管理
 模块英文名:PrjInterface
 框架-层名:实体层(EntityLayer)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
using System;
using System.Text; 
using System.Collections; 
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System.Runtime.Serialization;

namespace AGC.Entity
{
 /// <summary>
 /// 表vViewFeatureRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public struct K_mId_vViewFeatureRela
{
public long Value { get; }
public K_mId_vViewFeatureRela(long lngmId)
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
}
 /// <summary>
 /// v界面功能关系(vViewFeatureRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvViewFeatureRelaEN : clsEntityBase2
{
public const string _CurrTabName_S = "vViewFeatureRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 21;
public static string[] AttributeName = new string[] {"mId", "ViewId", "ViewName", "FuncModuleAgcId", "FuncModuleName", "PrjId", "PrjName", "MainTabId", "ViewCnName", "MainTabName", "FeatureId", "FeatureName", "FeatureTypeId", "FeatureTypeName", "OrderNum", "FuncCount", "ViewImplId", "ViewImplName", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量

protected long mlngmId;    //mId
protected string mstrViewId;    //界面ID
protected string mstrViewName;    //界面名称
protected string mstrFuncModuleAgcId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrPrjId;    //工程ID
protected string mstrPrjName;    //工程名称
protected string mstrMainTabId;    //主表ID
protected string mstrViewCnName;    //视图中文名
protected string mstrMainTabName;    //主表
protected string mstrFeatureId;    //功能Id
protected string mstrFeatureName;    //功能名称
protected string mstrFeatureTypeId;    //功能类型Id
protected string mstrFeatureTypeName;    //功能类型名称
protected int mintOrderNum;    //序号
protected int mintFuncCount;    //函数数目
protected string mstrViewImplId;    //界面实现Id
protected string mstrViewImplName;    //界面实现名
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_mId = "mId";    //mId

 /// <summary>
 /// 常量:"ViewId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ViewId = "ViewId";    //界面ID

 /// <summary>
 /// 常量:"ViewName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ViewName = "ViewName";    //界面名称

 /// <summary>
 /// 常量:"FuncModuleAgcId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_FuncModuleAgcId = "FuncModuleAgcId";    //功能模块Id

 /// <summary>
 /// 常量:"FuncModuleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_FuncModuleName = "FuncModuleName";    //功能模块名称

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PrjId = "PrjId";    //工程ID

 /// <summary>
 /// 常量:"PrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PrjName = "PrjName";    //工程名称

 /// <summary>
 /// 常量:"MainTabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_MainTabId = "MainTabId";    //主表ID

 /// <summary>
 /// 常量:"ViewCnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ViewCnName = "ViewCnName";    //视图中文名

 /// <summary>
 /// 常量:"MainTabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_MainTabName = "MainTabName";    //主表

 /// <summary>
 /// 常量:"FeatureId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_FeatureId = "FeatureId";    //功能Id

 /// <summary>
 /// 常量:"FeatureName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_FeatureName = "FeatureName";    //功能名称

 /// <summary>
 /// 常量:"FeatureTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_FeatureTypeId = "FeatureTypeId";    //功能类型Id

 /// <summary>
 /// 常量:"FeatureTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_FeatureTypeName = "FeatureTypeName";    //功能类型名称

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"FuncCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_FuncCount = "FuncCount";    //函数数目

 /// <summary>
 /// 常量:"ViewImplId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ViewImplId = "ViewImplId";    //界面实现Id

 /// <summary>
 /// 常量:"ViewImplName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ViewImplName = "ViewImplName";    //界面实现名

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpdUser = "UpdUser";    //修改者

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo = "Memo";    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvViewFeatureRelaEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "vViewFeatureRela";
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "mlngmId">关键字:mId</param>
public clsvViewFeatureRelaEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "vViewFeatureRela";
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
if (strAttributeName  ==  con_mId)
{
return mlngmId;
}
else if (strAttributeName  ==  con_ViewId)
{
return mstrViewId;
}
else if (strAttributeName  ==  con_ViewName)
{
return mstrViewName;
}
else if (strAttributeName  ==  con_FuncModuleAgcId)
{
return mstrFuncModuleAgcId;
}
else if (strAttributeName  ==  con_FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  con_PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  con_PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  con_MainTabId)
{
return mstrMainTabId;
}
else if (strAttributeName  ==  con_ViewCnName)
{
return mstrViewCnName;
}
else if (strAttributeName  ==  con_MainTabName)
{
return mstrMainTabName;
}
else if (strAttributeName  ==  con_FeatureId)
{
return mstrFeatureId;
}
else if (strAttributeName  ==  con_FeatureName)
{
return mstrFeatureName;
}
else if (strAttributeName  ==  con_FeatureTypeId)
{
return mstrFeatureTypeId;
}
else if (strAttributeName  ==  con_FeatureTypeName)
{
return mstrFeatureTypeName;
}
else if (strAttributeName  ==  con_OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  con_FuncCount)
{
return mintFuncCount;
}
else if (strAttributeName  ==  con_ViewImplId)
{
return mstrViewImplId;
}
else if (strAttributeName  ==  con_ViewImplName)
{
return mstrViewImplName;
}
else if (strAttributeName  ==  con_UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  con_UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  con_Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  con_mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(con_mId);
}
else if (strAttributeName  ==  con_ViewId)
{
mstrViewId = value.ToString();
 AddUpdatedFld(con_ViewId);
}
else if (strAttributeName  ==  con_ViewName)
{
mstrViewName = value.ToString();
 AddUpdatedFld(con_ViewName);
}
else if (strAttributeName  ==  con_FuncModuleAgcId)
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(con_FuncModuleAgcId);
}
else if (strAttributeName  ==  con_FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(con_FuncModuleName);
}
else if (strAttributeName  ==  con_PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(con_PrjId);
}
else if (strAttributeName  ==  con_PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(con_PrjName);
}
else if (strAttributeName  ==  con_MainTabId)
{
mstrMainTabId = value.ToString();
 AddUpdatedFld(con_MainTabId);
}
else if (strAttributeName  ==  con_ViewCnName)
{
mstrViewCnName = value.ToString();
 AddUpdatedFld(con_ViewCnName);
}
else if (strAttributeName  ==  con_MainTabName)
{
mstrMainTabName = value.ToString();
 AddUpdatedFld(con_MainTabName);
}
else if (strAttributeName  ==  con_FeatureId)
{
mstrFeatureId = value.ToString();
 AddUpdatedFld(con_FeatureId);
}
else if (strAttributeName  ==  con_FeatureName)
{
mstrFeatureName = value.ToString();
 AddUpdatedFld(con_FeatureName);
}
else if (strAttributeName  ==  con_FeatureTypeId)
{
mstrFeatureTypeId = value.ToString();
 AddUpdatedFld(con_FeatureTypeId);
}
else if (strAttributeName  ==  con_FeatureTypeName)
{
mstrFeatureTypeName = value.ToString();
 AddUpdatedFld(con_FeatureTypeName);
}
else if (strAttributeName  ==  con_OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(con_OrderNum);
}
else if (strAttributeName  ==  con_FuncCount)
{
mintFuncCount = TransNullToInt(value.ToString());
 AddUpdatedFld(con_FuncCount);
}
else if (strAttributeName  ==  con_ViewImplId)
{
mstrViewImplId = value.ToString();
 AddUpdatedFld(con_ViewImplId);
}
else if (strAttributeName  ==  con_ViewImplName)
{
mstrViewImplName = value.ToString();
 AddUpdatedFld(con_ViewImplName);
}
else if (strAttributeName  ==  con_UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(con_UpdDate);
}
else if (strAttributeName  ==  con_UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(con_UpdUser);
}
else if (strAttributeName  ==  con_Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (con_mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (con_ViewId  ==  AttributeName[intIndex])
{
return mstrViewId;
}
else if (con_ViewName  ==  AttributeName[intIndex])
{
return mstrViewName;
}
else if (con_FuncModuleAgcId  ==  AttributeName[intIndex])
{
return mstrFuncModuleAgcId;
}
else if (con_FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (con_PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
else if (con_PrjName  ==  AttributeName[intIndex])
{
return mstrPrjName;
}
else if (con_MainTabId  ==  AttributeName[intIndex])
{
return mstrMainTabId;
}
else if (con_ViewCnName  ==  AttributeName[intIndex])
{
return mstrViewCnName;
}
else if (con_MainTabName  ==  AttributeName[intIndex])
{
return mstrMainTabName;
}
else if (con_FeatureId  ==  AttributeName[intIndex])
{
return mstrFeatureId;
}
else if (con_FeatureName  ==  AttributeName[intIndex])
{
return mstrFeatureName;
}
else if (con_FeatureTypeId  ==  AttributeName[intIndex])
{
return mstrFeatureTypeId;
}
else if (con_FeatureTypeName  ==  AttributeName[intIndex])
{
return mstrFeatureTypeName;
}
else if (con_OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (con_FuncCount  ==  AttributeName[intIndex])
{
return mintFuncCount;
}
else if (con_ViewImplId  ==  AttributeName[intIndex])
{
return mstrViewImplId;
}
else if (con_ViewImplName  ==  AttributeName[intIndex])
{
return mstrViewImplName;
}
else if (con_UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (con_UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (con_Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (con_mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(con_mId);
}
else if (con_ViewId  ==  AttributeName[intIndex])
{
mstrViewId = value.ToString();
 AddUpdatedFld(con_ViewId);
}
else if (con_ViewName  ==  AttributeName[intIndex])
{
mstrViewName = value.ToString();
 AddUpdatedFld(con_ViewName);
}
else if (con_FuncModuleAgcId  ==  AttributeName[intIndex])
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(con_FuncModuleAgcId);
}
else if (con_FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(con_FuncModuleName);
}
else if (con_PrjId  ==  AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(con_PrjId);
}
else if (con_PrjName  ==  AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(con_PrjName);
}
else if (con_MainTabId  ==  AttributeName[intIndex])
{
mstrMainTabId = value.ToString();
 AddUpdatedFld(con_MainTabId);
}
else if (con_ViewCnName  ==  AttributeName[intIndex])
{
mstrViewCnName = value.ToString();
 AddUpdatedFld(con_ViewCnName);
}
else if (con_MainTabName  ==  AttributeName[intIndex])
{
mstrMainTabName = value.ToString();
 AddUpdatedFld(con_MainTabName);
}
else if (con_FeatureId  ==  AttributeName[intIndex])
{
mstrFeatureId = value.ToString();
 AddUpdatedFld(con_FeatureId);
}
else if (con_FeatureName  ==  AttributeName[intIndex])
{
mstrFeatureName = value.ToString();
 AddUpdatedFld(con_FeatureName);
}
else if (con_FeatureTypeId  ==  AttributeName[intIndex])
{
mstrFeatureTypeId = value.ToString();
 AddUpdatedFld(con_FeatureTypeId);
}
else if (con_FeatureTypeName  ==  AttributeName[intIndex])
{
mstrFeatureTypeName = value.ToString();
 AddUpdatedFld(con_FeatureTypeName);
}
else if (con_OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(con_OrderNum);
}
else if (con_FuncCount  ==  AttributeName[intIndex])
{
mintFuncCount = TransNullToInt(value.ToString());
 AddUpdatedFld(con_FuncCount);
}
else if (con_ViewImplId  ==  AttributeName[intIndex])
{
mstrViewImplId = value.ToString();
 AddUpdatedFld(con_ViewImplId);
}
else if (con_ViewImplName  ==  AttributeName[intIndex])
{
mstrViewImplName = value.ToString();
 AddUpdatedFld(con_ViewImplName);
}
else if (con_UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(con_UpdDate);
}
else if (con_UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(con_UpdUser);
}
else if (con_Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
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
 AddUpdatedFld(con_mId);
}
}
/// <summary>
/// 界面ID(说明:;字段类型:varchar;字段长度:8;是否可空:True)
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
 AddUpdatedFld(con_ViewId);
}
}
/// <summary>
/// 界面名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewName
{
get
{
return mstrViewName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewName = value;
}
else
{
 mstrViewName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_ViewName);
}
}
/// <summary>
/// 功能模块Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleAgcId
{
get
{
return mstrFuncModuleAgcId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleAgcId = value;
}
else
{
 mstrFuncModuleAgcId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_FuncModuleAgcId);
}
}
/// <summary>
/// 功能模块名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleName
{
get
{
return mstrFuncModuleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleName = value;
}
else
{
 mstrFuncModuleName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_FuncModuleName);
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
 AddUpdatedFld(con_PrjId);
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
 AddUpdatedFld(con_PrjName);
}
}
/// <summary>
/// 主表ID(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MainTabId
{
get
{
return mstrMainTabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMainTabId = value;
}
else
{
 mstrMainTabId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_MainTabId);
}
}
/// <summary>
/// 视图中文名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewCnName
{
get
{
return mstrViewCnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewCnName = value;
}
else
{
 mstrViewCnName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_ViewCnName);
}
}
/// <summary>
/// 主表(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MainTabName
{
get
{
return mstrMainTabName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMainTabName = value;
}
else
{
 mstrMainTabName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_MainTabName);
}
}
/// <summary>
/// 功能Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FeatureId
{
get
{
return mstrFeatureId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFeatureId = value;
}
else
{
 mstrFeatureId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_FeatureId);
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
 AddUpdatedFld(con_FeatureName);
}
}
/// <summary>
/// 功能类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FeatureTypeId
{
get
{
return mstrFeatureTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFeatureTypeId = value;
}
else
{
 mstrFeatureTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_FeatureTypeId);
}
}
/// <summary>
/// 功能类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FeatureTypeName
{
get
{
return mstrFeatureTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFeatureTypeName = value;
}
else
{
 mstrFeatureTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_FeatureTypeName);
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
 AddUpdatedFld(con_OrderNum);
}
}
/// <summary>
/// 函数数目(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int FuncCount
{
get
{
return mintFuncCount;
}
set
{
 mintFuncCount = value;
//记录修改过的字段
 AddUpdatedFld(con_FuncCount);
}
}
/// <summary>
/// 界面实现Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewImplId
{
get
{
return mstrViewImplId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewImplId = value;
}
else
{
 mstrViewImplId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_ViewImplId);
}
}
/// <summary>
/// 界面实现名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewImplName
{
get
{
return mstrViewImplName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewImplName = value;
}
else
{
 mstrViewImplName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_ViewImplName);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:14;是否可空:True)
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
 AddUpdatedFld(con_UpdDate);
}
}
/// <summary>
/// 修改者(说明:;字段类型:varchar;字段长度:18;是否可空:True)
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
 AddUpdatedFld(con_UpdUser);
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
 AddUpdatedFld(con_Memo);
}
}

/// <summary>
/// 获取关键字Id(KeyId)
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
}