
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFldFirstObjEN
 表名:vFldFirstObj
 生成代码版本:2017.11.09.1
 生成日期:2017/11/10 16:37:22
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
 /// vFldFirstObj(vFldFirstObj)
 /// (AutoGCLib.AutoGC6Cs_M:A_GenEntityLayerCode)
 /// </summary>
[Serializable]
public class clsvFldFirstObjEN : clsEntityBase2
{
public const string CurrTabName_S = "vFldFirstObj"; //当前表名,与该类相关的表名
public const string CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"mId", "FldID", "ObjId", "Memo"};
//以下是属性变量

protected long mlngmId;    //mId
protected string mstrFldID;    //字段ID
protected string mstrObjId;    //所属对象
protected string mstrMemo;    //说明


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_mId = "mId";    //mId

 /// <summary>
 /// 常量:"FldID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_FldID = "FldID";    //字段ID

 /// <summary>
 /// 常量:"ObjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ObjId = "ObjId";    //所属对象

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo = "Memo";    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.AutoGCPubFuncV6:GenClassConstructor1)
/// </summary>
 public clsvFldFirstObjEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "vFldFirstObj";
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.AutoGCPubFuncV6:GenClassConstructor2)
/// </summary>
/// <param name = "mlngmId">关键字:mId</param>
public clsvFldFirstObjEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "vFldFirstObj";
 lstKeyFldNames.Add("mId");
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
if (strAttributeName  ==  con_mId)
{
return mlngmId;
}
else if (strAttributeName  ==  con_FldID)
{
return mstrFldID;
}
else if (strAttributeName  ==  con_ObjId)
{
return mstrObjId;
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
else if (strAttributeName  ==  con_FldID)
{
mstrFldID = value.ToString();
 AddUpdatedFld(con_FldID);
}
else if (strAttributeName  ==  con_ObjId)
{
mstrObjId = value.ToString();
 AddUpdatedFld(con_ObjId);
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
else if (con_FldID  ==  AttributeName[intIndex])
{
return mstrFldID;
}
else if (con_ObjId  ==  AttributeName[intIndex])
{
return mstrObjId;
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
else if (con_FldID  ==  AttributeName[intIndex])
{
mstrFldID = value.ToString();
 AddUpdatedFld(con_FldID);
}
else if (con_ObjId  ==  AttributeName[intIndex])
{
mstrObjId = value.ToString();
 AddUpdatedFld(con_ObjId);
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
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
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
/// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
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
}
}