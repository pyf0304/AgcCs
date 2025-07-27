
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFldObjNumEN
 表名:vFldObjNum
 生成代码版本:2017.11.09.1
 生成日期:2017/11/10 16:39:13
 生成者:潘以锋
 生成服务器IP:101.251.68.133
 工程名称:AGC
 工程ID:0005
 模块中文名:字段、表维护
 模块英文名:Table_Field
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
 /// vFldObjNum(vFldObjNum)
 /// (AutoGCLib.AutoGC6Cs_M:A_GenEntityLayerCode)
 /// </summary>
[Serializable]
public class clsvFldObjNumEN : clsEntityBase2
{
public const string CurrTabName_S = "vFldObjNum"; //当前表名,与该类相关的表名
public const string CurrTabKeyFldName_S = "FldID"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 2;
public static string[] AttributeName = new string[] {"FldID", "ObjNum"};
//以下是属性变量

protected string mstrFldID;    //字段ID
protected int mintObjNum;    //ObjNum


 /// <summary>
 /// 常量:"FldID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_FldID = "FldID";    //字段ID

 /// <summary>
 /// 常量:"ObjNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ObjNum = "ObjNum";    //ObjNum

/// <summary>
/// 构造函数
 /// (AutoGCLib.AutoGCPubFuncV6:GenClassConstructor1)
/// </summary>
 public clsvFldObjNumEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "vFldObjNum";
 lstKeyFldNames.Add("FldID");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.AutoGCPubFuncV6:GenClassConstructor2)
/// </summary>
/// <param name = "mstrFldID">关键字:字段ID</param>
public clsvFldObjNumEN(string strFldID)
 {
strFldID = strFldID.Replace("'", "''");
if (strFldID.Length > 8)
{
throw new Exception("在表:vFldObjNum中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strFldID)  ==  true)
{
throw new Exception("在表:vFldObjNum中,关键字不能为空 或 null!");
}
try
{
clsCommonRegular.CheckStrSQL_Weak(strFldID);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

mstrFldID = strFldID;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "vFldObjNum";
 lstKeyFldNames.Add("FldID");
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
if (strAttributeName  ==  con_FldID)
{
return mstrFldID;
}
else if (strAttributeName  ==  con_ObjNum)
{
return mintObjNum;
}
return null;
}
set
{
if (strAttributeName  ==  con_FldID)
{
mstrFldID = value.ToString();
 AddUpdatedFld(con_FldID);
}
else if (strAttributeName  ==  con_ObjNum)
{
mintObjNum = TransNullToInt(value.ToString());
 AddUpdatedFld(con_ObjNum);
}
}
}
public object this[int intIndex]
{
get
{
if (con_FldID  ==  AttributeName[intIndex])
{
return mstrFldID;
}
else if (con_ObjNum  ==  AttributeName[intIndex])
{
return mintObjNum;
}
return null;
}
set
{
if (con_FldID  ==  AttributeName[intIndex])
{
mstrFldID = value.ToString();
 AddUpdatedFld(con_FldID);
}
else if (con_ObjNum  ==  AttributeName[intIndex])
{
mintObjNum = TransNullToInt(value.ToString());
 AddUpdatedFld(con_ObjNum);
}
}
}

/// <summary>
/// 字段ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string FldID
{
get
{
return mstrFldID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldID = value;
}
else
{
 mstrFldID = value;
}
//记录修改过的字段
 AddUpdatedFld(con_FldID);
}
}
/// <summary>
/// ObjNum(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public int ObjNum
{
get
{
return mintObjNum;
}
set
{
 mintObjNum = value;
//记录修改过的字段
 AddUpdatedFld(con_ObjNum);
}
}
}
}