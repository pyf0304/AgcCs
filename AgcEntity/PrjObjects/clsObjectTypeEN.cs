
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsObjectTypeEN
 表名:ObjectType
 生成代码版本:2017.06.27.1
 生成日期:2017/06/27 19:58:21
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
 /// 对象类型(ObjectType)
 /// (AutoGCLib.AutoGC6Cs_M:A_GenEntityLayerCode)
 /// </summary>
[Serializable]
public class clsObjectTypeEN : clsEntityBase2
{
public const string CurrTabName_S = "ObjectType"; //当前表名,与该类相关的表名
public const string CurrTabKeyFldName_S = "ObjectTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"ObjectTypeId", "ObjectType", "Memo"};
//以下是属性变量

protected string mstrObjectTypeId;    //对象类型Id
protected string mstrObjectType;    //对象类型名
protected string mstrMemo;    //说明


 /// <summary>
 /// 常量:"ObjectTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ObjectTypeId = "ObjectTypeId";    //对象类型Id

 /// <summary>
 /// 常量:"ObjectType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ObjectType = "ObjectType";    //对象类型名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo = "Memo";    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.AutoGCPubFuncV6:GenClassConstructor1)
/// </summary>
 public clsObjectTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "ObjectType";
 lstKeyFldNames.Add("ObjectTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.AutoGCPubFuncV6:GenClassConstructor2)
/// </summary>
/// <param name = "mstrObjectTypeId">关键字:对象类型Id</param>
public clsObjectTypeEN(string strObjectTypeId)
 {
strObjectTypeId = strObjectTypeId.Replace("'", "''");
if (strObjectTypeId.Length > 4)
{
throw new Exception("在表:ObjectType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strObjectTypeId)  ==  true)
{
throw new Exception("在表:ObjectType中,关键字不能为空 或 null!");
}
try
{
clsCommonRegular.CheckStrSQL_Weak(strObjectTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

mstrObjectTypeId = strObjectTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "ObjectType";
 lstKeyFldNames.Add("ObjectTypeId");
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
if (strAttributeName  ==  con_ObjectTypeId)
{
return mstrObjectTypeId;
}
else if (strAttributeName  ==  con_ObjectType)
{
return mstrObjectType;
}
else if (strAttributeName  ==  con_Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  con_ObjectTypeId)
{
mstrObjectTypeId = value.ToString();
 AddUpdatedFld(con_ObjectTypeId);
}
else if (strAttributeName  ==  con_ObjectType)
{
mstrObjectType = value.ToString();
 AddUpdatedFld(con_ObjectType);
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
if (con_ObjectTypeId  ==  AttributeName[intIndex])
{
return mstrObjectTypeId;
}
else if (con_ObjectType  ==  AttributeName[intIndex])
{
return mstrObjectType;
}
else if (con_Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (con_ObjectTypeId  ==  AttributeName[intIndex])
{
mstrObjectTypeId = value.ToString();
 AddUpdatedFld(con_ObjectTypeId);
}
else if (con_ObjectType  ==  AttributeName[intIndex])
{
mstrObjectType = value.ToString();
 AddUpdatedFld(con_ObjectType);
}
else if (con_Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
}
}
}

/// <summary>
/// 对象类型Id(说明:;字段类型:varchar;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string ObjectTypeId
{
get
{
return mstrObjectTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrObjectTypeId = value;
}
else
{
 mstrObjectTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_ObjectTypeId);
}
}
/// <summary>
/// 对象类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string ObjectType
{
get
{
return mstrObjectType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrObjectType = value;
}
else
{
 mstrObjectType = value;
}
//记录修改过的字段
 AddUpdatedFld(con_ObjectType);
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