
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjObjects4DdlEN
 表名:vPrjObjects4Ddl
 生成代码版本:2017.06.27.1
 生成日期:2017/06/27 20:09:41
 生成者:
 生成服务器IP:180.153.158.158
 工程名称:AGC
 工程ID:0005
 模块中文名:工程对象
 模块英文名:PrjObjects
 框架-层名:实体层
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2017.06.19.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2016.12.13.01
 == == == == == == == == == == == == 
 */
using System;
using System.Text; 
using System.Collections; 
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;

namespace AGC.Entity
{
 /// <summary>
 /// v工程对象4Ddl(vPrjObjects4Ddl)
 /// (AutoGCLib.AutoGC6Cs_M:A_GenEntityLayerCode)
 /// </summary>
[Serializable]
public class clsvPrjObjects4DdlEN : clsEntityBase2
{
public const string CurrTabName_S = "vPrjObjects4Ddl"; //当前表名,与该类相关的表名
public const string CurrTabKeyFldName_S = "ObjId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"ObjId", "ObjName", "FuncModuleAgcId", "PrjId"};
//以下是属性变量

protected string mstrObjId;    //所属对象
protected string mstrObjName;    //对象名称
protected string mstrFuncModuleAgcId;    //功能模块Id
protected string mstrPrjId;    //工程ID


 /// <summary>
 /// 常量:"ObjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ObjId = "ObjId";    //所属对象

 /// <summary>
 /// 常量:"ObjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ObjName = "ObjName";    //对象名称

 /// <summary>
 /// 常量:"FuncModuleAgcId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_FuncModuleAgcId = "FuncModuleAgcId";    //功能模块Id

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PrjId = "PrjId";    //工程ID

/// <summary>
/// 构造函数
 /// (AutoGCLib.AutoGCPubFuncV6:GenClassConstructor1)
/// </summary>
 public clsvPrjObjects4DdlEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "vPrjObjects4Ddl";
 lstKeyFldNames.Add("ObjId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.AutoGCPubFuncV6:GenClassConstructor2)
/// </summary>
/// <param name = "mstrObjId">关键字:所属对象</param>
public clsvPrjObjects4DdlEN(string strObjId)
 {
strObjId = strObjId.Replace("'", "''");
if (strObjId.Length > 8)
{
throw new Exception("在表:vPrjObjects4Ddl中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strObjId)  ==  true)
{
throw new Exception("在表:vPrjObjects4Ddl中,关键字不能为空 或 null!");
}
try
{
clsCommonRegular.CheckStrSQL_Weak(strObjId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

mstrObjId = strObjId;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "vPrjObjects4Ddl";
 lstKeyFldNames.Add("ObjId");
 }

public static int AttributeCount
{
get
{
return mintAttributeCount;
}
}
public object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  con_ObjId)
{
return mstrObjId;
}
else if (strAttributeName  ==  con_ObjName)
{
return mstrObjName;
}
else if (strAttributeName  ==  con_FuncModuleAgcId)
{
return mstrFuncModuleAgcId;
}
else if (strAttributeName  ==  con_PrjId)
{
return mstrPrjId;
}
return null;
}
set
{
if (strAttributeName  ==  con_ObjId)
{
mstrObjId = value.ToString();
 AddUpdatedFld(con_ObjId);
}
else if (strAttributeName  ==  con_ObjName)
{
mstrObjName = value.ToString();
 AddUpdatedFld(con_ObjName);
}
else if (strAttributeName  ==  con_FuncModuleAgcId)
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(con_FuncModuleAgcId);
}
else if (strAttributeName  ==  con_PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(con_PrjId);
}
}
}
public object this[int intIndex]
{
get
{
if (con_ObjId  ==  AttributeName[intIndex])
{
return mstrObjId;
}
else if (con_ObjName  ==  AttributeName[intIndex])
{
return mstrObjName;
}
else if (con_FuncModuleAgcId  ==  AttributeName[intIndex])
{
return mstrFuncModuleAgcId;
}
else if (con_PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
return null;
}
set
{
if (con_ObjId  ==  AttributeName[intIndex])
{
mstrObjId = value.ToString();
 AddUpdatedFld(con_ObjId);
}
else if (con_ObjName  ==  AttributeName[intIndex])
{
mstrObjName = value.ToString();
 AddUpdatedFld(con_ObjName);
}
else if (con_FuncModuleAgcId  ==  AttributeName[intIndex])
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(con_FuncModuleAgcId);
}
else if (con_PrjId  ==  AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(con_PrjId);
}
}
}

/// <summary>
/// 所属对象(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string ObjId
{
get
{
return mstrObjId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrObjId = value;
}
else
{
 mstrObjId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_ObjId);
}
}
/// <summary>
/// 对象名称(说明:;字段类型:varchar;字段长度:60;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string ObjName
{
get
{
return mstrObjName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrObjName = value;
}
else
{
 mstrObjName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_ObjName);
}
}
/// <summary>
/// 功能模块Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
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
/// 工程ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
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
}
}