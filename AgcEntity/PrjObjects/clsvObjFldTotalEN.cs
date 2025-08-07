
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvObjFldTotalEN
 表名:vObjFldTotal
 生成代码版本:2017.11.09.1
 生成日期:2017/11/10 16:41:16
 生成者:潘以锋
 生成服务器IP:101.251.68.133
 工程名称:AGC
 工程ID:0005
 模块中文名:工程对象
 模块英文名:PrjObjects
 框架-层名:实体层
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2017.11.09.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.11.09.01
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
 /// vObjFldTotal(vObjFldTotal)
 /// (AutoGCLib.AutoGC6Cs_M:A_GenEntityLayerCode)
 /// </summary>
[Serializable]
public class clsvObjFldTotalEN : clsEntityBase2
{
public const string CurrTabName_S = "vObjFldTotal"; //当前表名,与该类相关的表名
public const string CurrTabKeyFldName_S = "ObjId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 2;
public static string[] AttributeName = new string[] {"ObjId", "FldNum"};
//以下是属性变量

protected string mstrObjId;    //ObjId
protected int mintFldNum;    //FldNum


 /// <summary>
 /// 常量:"ObjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ObjId = "ObjId";    //ObjId

 /// <summary>
 /// 常量:"FldNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_FldNum = "FldNum";    //FldNum

/// <summary>
/// 构造函数
 /// (AutoGCLib.AutoGCPubFuncV6:GenClassConstructor1)
/// </summary>
 public clsvObjFldTotalEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "vObjFldTotal";
 lstKeyFldNames.Add("ObjId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.AutoGCPubFuncV6:GenClassConstructor2)
/// </summary>
/// <param name = "mstrObjId">关键字:ObjId</param>
public clsvObjFldTotalEN(string strObjId)
 {
strObjId = strObjId.Replace("'", "''");
if (strObjId.Length > 8)
{
throw new Exception("在表:vObjFldTotal中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strObjId)  ==  true)
{
throw new Exception("在表:vObjFldTotal中,关键字不能为空 或 null!");
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
 _CurrTabName = "vObjFldTotal";
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
else if (strAttributeName  ==  con_FldNum)
{
return mintFldNum;
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
else if (strAttributeName  ==  con_FldNum)
{
mintFldNum = TransNullToInt(value.ToString());
 AddUpdatedFld(con_FldNum);
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
else if (con_FldNum  ==  AttributeName[intIndex])
{
return mintFldNum;
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
else if (con_FldNum  ==  AttributeName[intIndex])
{
mintFldNum = TransNullToInt(value.ToString());
 AddUpdatedFld(con_FldNum);
}
}
}

/// <summary>
/// ObjId(说明:;字段类型:varchar;字段长度:8;是否可空:True)
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
/// FldNum(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public int FldNum
{
get
{
return mintFldNum;
}
set
{
 mintFldNum = value;
//记录修改过的字段
 AddUpdatedFld(con_FldNum);
}
}
}
}