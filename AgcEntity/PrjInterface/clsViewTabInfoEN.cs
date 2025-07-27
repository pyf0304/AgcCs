
///----------------------
///生成代码版本：2012.11.9.1
///生成日期：2012/11/20
///生成者：潘以锋
///工程名称：AGC
///工程ID：0005
///模块中文名：项目界面管理
///模块英文名：PrjInterface
///注意：1、需要数据底层（PubDataBase.dll）的版本：2012.10.20.1
///       2、需要公共函数层（TzPubFunction.dll）的版本：2012.10.23.1
///========================
using System;
using System.Text; 
using System.Collections; 
using com.taishsoft.comm_db_obj;

namespace AGC.Entity
{
/// <summary>
/// ViewTabInfo(ViewTabInfo)
/// </summary>
[Serializable]
public class clsViewTabInfoEN : clsEntityBase2
{
public const string CurrTabName_S = "ViewTabInfo"; //当前表名，与该类相关的表名
public const string CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称，与该类相关的表中关键字名
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"mId", "ViewId", "DataBaseName", "TabName"};
 //以下是属性变量


 /// <summary> 
 /// mId(字段类型:bigint,字段长度:8,是否可空:False)
 /// </summary>
 protected long mlngmId;

 /// <summary> 
 /// 界面ID(字段类型:varchar,字段长度:8,是否可空:True)
 /// </summary>
 protected string mstrViewId;

 /// <summary> 
 /// 数据库名(字段类型:varchar,字段长度:50,是否可空:False)
 /// </summary>
 protected string mstrDataBaseName;

 /// <summary> 
 /// 表名(字段类型:varchar,字段长度:60,是否可空:False)
 /// </summary>
 protected string mstrTabName;
        
 public clsViewTabInfoEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "ViewTabInfo";
 lstKeyFldNames.Add("mId");
 }

public clsViewTabInfoEN(long lngmId)
 {
  if (lngmId == 0)
  {
     throw new Exception("关键字不能为0！");
   }

mlngmId=lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "ViewTabInfo";
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
if (strAttributeName == "mId")
{
return mlngmId;
}
else if (strAttributeName == "ViewId")
{
return mstrViewId;
}
else if (strAttributeName == "DataBaseName")
{
return mstrDataBaseName;
}
else if (strAttributeName == "TabName")
{
return mstrTabName;
}
return null;
}
set
{
if (strAttributeName == "mId")
{
mlngmId = TransNullToInt(value.ToString());
}
else if (strAttributeName == "ViewId")
{
mstrViewId = value.ToString();
}
else if (strAttributeName == "DataBaseName")
{
mstrDataBaseName = value.ToString();
}
else if (strAttributeName == "TabName")
{
mstrTabName = value.ToString();
}
}
}
public object this[int intIndex]
{
get
{
if ("mId" == AttributeName[intIndex])
{
return mlngmId;
}
else if ("ViewId" == AttributeName[intIndex])
{
return mstrViewId;
}
else if ("DataBaseName" == AttributeName[intIndex])
{
return mstrDataBaseName;
}
else if ("TabName" == AttributeName[intIndex])
{
return mstrTabName;
}
return null;
}
set
{
if ("mId" == AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
}
else if ("ViewId" == AttributeName[intIndex])
{
mstrViewId = value.ToString();
}
else if ("DataBaseName" == AttributeName[intIndex])
{
mstrDataBaseName = value.ToString();
}
else if ("TabName" == AttributeName[intIndex])
{
mstrTabName = value.ToString();
}
}
}

/// <summary>
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
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
AddUpdatedFld("mId");
}
}
/// <summary>
/// 界面ID(说明:;字段类型:varchar;字段长度:8;是否可空:True)
/// </summary>
public string ViewId
{
get
{
return mstrViewId;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrViewId = value;
}
else
{
mstrViewId = value;
}
//记录修改过的字段
AddUpdatedFld("ViewId");
}
}
/// <summary>
/// 数据库名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
/// </summary>
public string DataBaseName
{
get
{
return mstrDataBaseName;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrDataBaseName = value;
}
else
{
mstrDataBaseName = value;
}
//记录修改过的字段
AddUpdatedFld("DataBaseName");
}
}
/// <summary>
/// 表名(说明:;字段类型:varchar;字段长度:60;是否可空:False)
/// </summary>
public string TabName
{
get
{
return mstrTabName;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrTabName = value;
}
else
{
mstrTabName = value;
}
//记录修改过的字段
AddUpdatedFld("TabName");
}
}
}
}