
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFldObjTabEN
 表名:vFldObjTab
 生成代码版本:2017.06.27.1
 生成日期:2017/06/27 20:05:47
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
 /// vFldObjTab(vFldObjTab)
 /// (AutoGCLib.AutoGC6Cs_M:A_GenEntityLayerCode)
 /// </summary>
[Serializable]
public class clsvFldObjTabEN : clsEntityBase2
{
public const string CurrTabName_S = "vFldObjTab"; //当前表名,与该类相关的表名
public const string CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 13;
public static string[] AttributeName = new string[] {"mId", "FldID", "FldName", "DataTypeName", "FldLength", "Caption", "FldInfo", "IsNull", "IsPrimaryKey", "DataTypeId", "ObjId", "ObjName", "Memo"};
//以下是属性变量

protected long mlngmId;    //mId
protected string mstrFldID;    //字段ID
protected string mstrFldName;    //字段名
protected string mstrDataTypeName;    //数据类型名称
protected int mintFldLength;    //字段长度
protected string mstrCaption;    //标题
protected string mstrFldInfo;    //字段信息
protected bool mbolIsNull;    //是否可空
protected bool mbolIsPrimaryKey;    //是否主键
protected string mstrDataTypeId;    //数据类型Id
protected string mstrObjId;    //所属对象
protected string mstrObjName;    //对象名称
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
 /// 常量:"FldName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_FldName = "FldName";    //字段名

 /// <summary>
 /// 常量:"DataTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_DataTypeName = "DataTypeName";    //数据类型名称

 /// <summary>
 /// 常量:"FldLength"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_FldLength = "FldLength";    //字段长度

 /// <summary>
 /// 常量:"Caption"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Caption = "Caption";    //标题

 /// <summary>
 /// 常量:"FldInfo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_FldInfo = "FldInfo";    //字段信息

 /// <summary>
 /// 常量:"IsNull"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsNull = "IsNull";    //是否可空

 /// <summary>
 /// 常量:"IsPrimaryKey"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsPrimaryKey = "IsPrimaryKey";    //是否主键

 /// <summary>
 /// 常量:"DataTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_DataTypeId = "DataTypeId";    //数据类型Id

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
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo = "Memo";    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.AutoGCPubFuncV6:GenClassConstructor1)
/// </summary>
 public clsvFldObjTabEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "vFldObjTab";
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.AutoGCPubFuncV6:GenClassConstructor2)
/// </summary>
/// <param name = "mlngmId">关键字:mId</param>
public clsvFldObjTabEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "vFldObjTab";
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
else if (strAttributeName  ==  con_FldName)
{
return mstrFldName;
}
else if (strAttributeName  ==  con_DataTypeName)
{
return mstrDataTypeName;
}
else if (strAttributeName  ==  con_FldLength)
{
return mintFldLength;
}
else if (strAttributeName  ==  con_Caption)
{
return mstrCaption;
}
else if (strAttributeName  ==  con_FldInfo)
{
return mstrFldInfo;
}
else if (strAttributeName  ==  con_IsNull)
{
return mbolIsNull;
}
else if (strAttributeName  ==  con_IsPrimaryKey)
{
return mbolIsPrimaryKey;
}
else if (strAttributeName  ==  con_DataTypeId)
{
return mstrDataTypeId;
}
else if (strAttributeName  ==  con_ObjId)
{
return mstrObjId;
}
else if (strAttributeName  ==  con_ObjName)
{
return mstrObjName;
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
else if (strAttributeName  ==  con_FldName)
{
mstrFldName = value.ToString();
 AddUpdatedFld(con_FldName);
}
else if (strAttributeName  ==  con_DataTypeName)
{
mstrDataTypeName = value.ToString();
 AddUpdatedFld(con_DataTypeName);
}
else if (strAttributeName  ==  con_FldLength)
{
mintFldLength = TransNullToInt(value.ToString());
 AddUpdatedFld(con_FldLength);
}
else if (strAttributeName  ==  con_Caption)
{
mstrCaption = value.ToString();
 AddUpdatedFld(con_Caption);
}
else if (strAttributeName  ==  con_FldInfo)
{
mstrFldInfo = value.ToString();
 AddUpdatedFld(con_FldInfo);
}
else if (strAttributeName  ==  con_IsNull)
{
mbolIsNull = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsNull);
}
else if (strAttributeName  ==  con_IsPrimaryKey)
{
mbolIsPrimaryKey = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsPrimaryKey);
}
else if (strAttributeName  ==  con_DataTypeId)
{
mstrDataTypeId = value.ToString();
 AddUpdatedFld(con_DataTypeId);
}
else if (strAttributeName  ==  con_ObjId)
{
mstrObjId = value.ToString();
 AddUpdatedFld(con_ObjId);
}
else if (strAttributeName  ==  con_ObjName)
{
mstrObjName = value.ToString();
 AddUpdatedFld(con_ObjName);
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
else if (con_FldName  ==  AttributeName[intIndex])
{
return mstrFldName;
}
else if (con_DataTypeName  ==  AttributeName[intIndex])
{
return mstrDataTypeName;
}
else if (con_FldLength  ==  AttributeName[intIndex])
{
return mintFldLength;
}
else if (con_Caption  ==  AttributeName[intIndex])
{
return mstrCaption;
}
else if (con_FldInfo  ==  AttributeName[intIndex])
{
return mstrFldInfo;
}
else if (con_IsNull  ==  AttributeName[intIndex])
{
return mbolIsNull;
}
else if (con_IsPrimaryKey  ==  AttributeName[intIndex])
{
return mbolIsPrimaryKey;
}
else if (con_DataTypeId  ==  AttributeName[intIndex])
{
return mstrDataTypeId;
}
else if (con_ObjId  ==  AttributeName[intIndex])
{
return mstrObjId;
}
else if (con_ObjName  ==  AttributeName[intIndex])
{
return mstrObjName;
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
else if (con_FldName  ==  AttributeName[intIndex])
{
mstrFldName = value.ToString();
 AddUpdatedFld(con_FldName);
}
else if (con_DataTypeName  ==  AttributeName[intIndex])
{
mstrDataTypeName = value.ToString();
 AddUpdatedFld(con_DataTypeName);
}
else if (con_FldLength  ==  AttributeName[intIndex])
{
mintFldLength = TransNullToInt(value.ToString());
 AddUpdatedFld(con_FldLength);
}
else if (con_Caption  ==  AttributeName[intIndex])
{
mstrCaption = value.ToString();
 AddUpdatedFld(con_Caption);
}
else if (con_FldInfo  ==  AttributeName[intIndex])
{
mstrFldInfo = value.ToString();
 AddUpdatedFld(con_FldInfo);
}
else if (con_IsNull  ==  AttributeName[intIndex])
{
mbolIsNull = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsNull);
}
else if (con_IsPrimaryKey  ==  AttributeName[intIndex])
{
mbolIsPrimaryKey = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsPrimaryKey);
}
else if (con_DataTypeId  ==  AttributeName[intIndex])
{
mstrDataTypeId = value.ToString();
 AddUpdatedFld(con_DataTypeId);
}
else if (con_ObjId  ==  AttributeName[intIndex])
{
mstrObjId = value.ToString();
 AddUpdatedFld(con_ObjId);
}
else if (con_ObjName  ==  AttributeName[intIndex])
{
mstrObjName = value.ToString();
 AddUpdatedFld(con_ObjName);
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
/// 字段名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string FldName
{
get
{
return mstrFldName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldName = value;
}
else
{
 mstrFldName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_FldName);
}
}
/// <summary>
/// 数据类型名称(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string DataTypeName
{
get
{
return mstrDataTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataTypeName = value;
}
else
{
 mstrDataTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_DataTypeName);
}
}
/// <summary>
/// 字段长度(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public int FldLength
{
get
{
return mintFldLength;
}
set
{
 mintFldLength = value;
//记录修改过的字段
 AddUpdatedFld(con_FldLength);
}
}
/// <summary>
/// 标题(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string Caption
{
get
{
return mstrCaption;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaption = value;
}
else
{
 mstrCaption = value;
}
//记录修改过的字段
 AddUpdatedFld(con_Caption);
}
}
/// <summary>
/// 字段信息(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string FldInfo
{
get
{
return mstrFldInfo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldInfo = value;
}
else
{
 mstrFldInfo = value;
}
//记录修改过的字段
 AddUpdatedFld(con_FldInfo);
}
}
/// <summary>
/// 是否可空(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public bool IsNull
{
get
{
return mbolIsNull;
}
set
{
 mbolIsNull = value;
//记录修改过的字段
 AddUpdatedFld(con_IsNull);
}
}
/// <summary>
/// 是否主键(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public bool IsPrimaryKey
{
get
{
return mbolIsPrimaryKey;
}
set
{
 mbolIsPrimaryKey = value;
//记录修改过的字段
 AddUpdatedFld(con_IsPrimaryKey);
}
}
/// <summary>
/// 数据类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string DataTypeId
{
get
{
return mstrDataTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataTypeId = value;
}
else
{
 mstrDataTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_DataTypeId);
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