
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewRegionRelaBL
 表名:vViewRegionRela(00050574)
 * 版本:2024.01.24.1(服务器:WIN-SRV103-116)
 日期:2024/01/26 16:18:10
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:区域管理(RegionManage)
 框架-层名:业务逻辑层(CS)(BusinessLogic)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Text; 
using System.Collections; 
using System.Collections.Generic; 
using System.Globalization;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Xml;
using Newtonsoft.Json;
using com.taishsoft.file;
using com.taishsoft.common;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.json;
using com.taishsoft.dynamiccompiler;
using com.taishsoft.datetime;
using AGC.Entity;
using System.Data; 
using System.Data.SqlClient; 
using AGC.DAL;

namespace AGC.BusinessLogic
{
public static class  clsvViewRegionRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvViewRegionRelaEN GetObj(this K_mId_vViewRegionRela myKey)
{
clsvViewRegionRelaEN objvViewRegionRelaEN = clsvViewRegionRelaBL.vViewRegionRelaDA.GetObjBymId(myKey.Value);
return objvViewRegionRelaEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionRelaEN SetmId(this clsvViewRegionRelaEN objvViewRegionRelaEN, long lngmId, string strComparisonOp="")
	{
objvViewRegionRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRegionRelaEN.dicFldComparisonOp.ContainsKey(convViewRegionRela.mId) == false)
{
objvViewRegionRelaEN.dicFldComparisonOp.Add(convViewRegionRela.mId, strComparisonOp);
}
else
{
objvViewRegionRelaEN.dicFldComparisonOp[convViewRegionRela.mId] = strComparisonOp;
}
}
return objvViewRegionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionRelaEN SetRegionId(this clsvViewRegionRelaEN objvViewRegionRelaEN, string strRegionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionId, convViewRegionRela.RegionId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionId, 10, convViewRegionRela.RegionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRegionId, 10, convViewRegionRela.RegionId);
}
objvViewRegionRelaEN.RegionId = strRegionId; //区域Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRegionRelaEN.dicFldComparisonOp.ContainsKey(convViewRegionRela.RegionId) == false)
{
objvViewRegionRelaEN.dicFldComparisonOp.Add(convViewRegionRela.RegionId, strComparisonOp);
}
else
{
objvViewRegionRelaEN.dicFldComparisonOp[convViewRegionRela.RegionId] = strComparisonOp;
}
}
return objvViewRegionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionRelaEN SetRegionName(this clsvViewRegionRelaEN objvViewRegionRelaEN, string strRegionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionName, convViewRegionRela.RegionName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionName, 50, convViewRegionRela.RegionName);
}
objvViewRegionRelaEN.RegionName = strRegionName; //区域名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRegionRelaEN.dicFldComparisonOp.ContainsKey(convViewRegionRela.RegionName) == false)
{
objvViewRegionRelaEN.dicFldComparisonOp.Add(convViewRegionRela.RegionName, strComparisonOp);
}
else
{
objvViewRegionRelaEN.dicFldComparisonOp[convViewRegionRela.RegionName] = strComparisonOp;
}
}
return objvViewRegionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionRelaEN SetRegionTypeId(this clsvViewRegionRelaEN objvViewRegionRelaEN, string strRegionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionTypeId, convViewRegionRela.RegionTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionTypeId, 4, convViewRegionRela.RegionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRegionTypeId, 4, convViewRegionRela.RegionTypeId);
}
objvViewRegionRelaEN.RegionTypeId = strRegionTypeId; //区域类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRegionRelaEN.dicFldComparisonOp.ContainsKey(convViewRegionRela.RegionTypeId) == false)
{
objvViewRegionRelaEN.dicFldComparisonOp.Add(convViewRegionRela.RegionTypeId, strComparisonOp);
}
else
{
objvViewRegionRelaEN.dicFldComparisonOp[convViewRegionRela.RegionTypeId] = strComparisonOp;
}
}
return objvViewRegionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionRelaEN SetRegionTypeName(this clsvViewRegionRelaEN objvViewRegionRelaEN, string strRegionTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionTypeName, convViewRegionRela.RegionTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionTypeName, 30, convViewRegionRela.RegionTypeName);
}
objvViewRegionRelaEN.RegionTypeName = strRegionTypeName; //区域类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRegionRelaEN.dicFldComparisonOp.ContainsKey(convViewRegionRela.RegionTypeName) == false)
{
objvViewRegionRelaEN.dicFldComparisonOp.Add(convViewRegionRela.RegionTypeName, strComparisonOp);
}
else
{
objvViewRegionRelaEN.dicFldComparisonOp[convViewRegionRela.RegionTypeName] = strComparisonOp;
}
}
return objvViewRegionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionRelaEN SetRegionTypeSimName(this clsvViewRegionRelaEN objvViewRegionRelaEN, string strRegionTypeSimName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionTypeSimName, 10, convViewRegionRela.RegionTypeSimName);
}
objvViewRegionRelaEN.RegionTypeSimName = strRegionTypeSimName; //区域类型简名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRegionRelaEN.dicFldComparisonOp.ContainsKey(convViewRegionRela.RegionTypeSimName) == false)
{
objvViewRegionRelaEN.dicFldComparisonOp.Add(convViewRegionRela.RegionTypeSimName, strComparisonOp);
}
else
{
objvViewRegionRelaEN.dicFldComparisonOp[convViewRegionRela.RegionTypeSimName] = strComparisonOp;
}
}
return objvViewRegionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionRelaEN SetRegionTypeOrderNum(this clsvViewRegionRelaEN objvViewRegionRelaEN, int? intRegionTypeOrderNum, string strComparisonOp="")
	{
objvViewRegionRelaEN.RegionTypeOrderNum = intRegionTypeOrderNum; //区域类型序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRegionRelaEN.dicFldComparisonOp.ContainsKey(convViewRegionRela.RegionTypeOrderNum) == false)
{
objvViewRegionRelaEN.dicFldComparisonOp.Add(convViewRegionRela.RegionTypeOrderNum, strComparisonOp);
}
else
{
objvViewRegionRelaEN.dicFldComparisonOp[convViewRegionRela.RegionTypeOrderNum] = strComparisonOp;
}
}
return objvViewRegionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionRelaEN SetHeight(this clsvViewRegionRelaEN objvViewRegionRelaEN, int? intHeight, string strComparisonOp="")
	{
objvViewRegionRelaEN.Height = intHeight; //高度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRegionRelaEN.dicFldComparisonOp.ContainsKey(convViewRegionRela.Height) == false)
{
objvViewRegionRelaEN.dicFldComparisonOp.Add(convViewRegionRela.Height, strComparisonOp);
}
else
{
objvViewRegionRelaEN.dicFldComparisonOp[convViewRegionRela.Height] = strComparisonOp;
}
}
return objvViewRegionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionRelaEN SetWidth(this clsvViewRegionRelaEN objvViewRegionRelaEN, int? intWidth, string strComparisonOp="")
	{
objvViewRegionRelaEN.Width = intWidth; //宽
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRegionRelaEN.dicFldComparisonOp.ContainsKey(convViewRegionRela.Width) == false)
{
objvViewRegionRelaEN.dicFldComparisonOp.Add(convViewRegionRela.Width, strComparisonOp);
}
else
{
objvViewRegionRelaEN.dicFldComparisonOp[convViewRegionRela.Width] = strComparisonOp;
}
}
return objvViewRegionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionRelaEN SetColNum(this clsvViewRegionRelaEN objvViewRegionRelaEN, int? intColNum, string strComparisonOp="")
	{
objvViewRegionRelaEN.ColNum = intColNum; //列数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRegionRelaEN.dicFldComparisonOp.ContainsKey(convViewRegionRela.ColNum) == false)
{
objvViewRegionRelaEN.dicFldComparisonOp.Add(convViewRegionRela.ColNum, strComparisonOp);
}
else
{
objvViewRegionRelaEN.dicFldComparisonOp[convViewRegionRela.ColNum] = strComparisonOp;
}
}
return objvViewRegionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionRelaEN SetContainerTypeName(this clsvViewRegionRelaEN objvViewRegionRelaEN, string strContainerTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strContainerTypeName, 50, convViewRegionRela.ContainerTypeName);
}
objvViewRegionRelaEN.ContainerTypeName = strContainerTypeName; //容器类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRegionRelaEN.dicFldComparisonOp.ContainsKey(convViewRegionRela.ContainerTypeName) == false)
{
objvViewRegionRelaEN.dicFldComparisonOp.Add(convViewRegionRela.ContainerTypeName, strComparisonOp);
}
else
{
objvViewRegionRelaEN.dicFldComparisonOp[convViewRegionRela.ContainerTypeName] = strComparisonOp;
}
}
return objvViewRegionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionRelaEN SetPageDispModeName(this clsvViewRegionRelaEN objvViewRegionRelaEN, string strPageDispModeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPageDispModeName, 50, convViewRegionRela.PageDispModeName);
}
objvViewRegionRelaEN.PageDispModeName = strPageDispModeName; //页面显示模式名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRegionRelaEN.dicFldComparisonOp.ContainsKey(convViewRegionRela.PageDispModeName) == false)
{
objvViewRegionRelaEN.dicFldComparisonOp.Add(convViewRegionRela.PageDispModeName, strComparisonOp);
}
else
{
objvViewRegionRelaEN.dicFldComparisonOp[convViewRegionRela.PageDispModeName] = strComparisonOp;
}
}
return objvViewRegionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionRelaEN SetViewId(this clsvViewRegionRelaEN objvViewRegionRelaEN, string strViewId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewId, 8, convViewRegionRela.ViewId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strViewId, 8, convViewRegionRela.ViewId);
}
objvViewRegionRelaEN.ViewId = strViewId; //界面Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRegionRelaEN.dicFldComparisonOp.ContainsKey(convViewRegionRela.ViewId) == false)
{
objvViewRegionRelaEN.dicFldComparisonOp.Add(convViewRegionRela.ViewId, strComparisonOp);
}
else
{
objvViewRegionRelaEN.dicFldComparisonOp[convViewRegionRela.ViewId] = strComparisonOp;
}
}
return objvViewRegionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionRelaEN SetViewName(this clsvViewRegionRelaEN objvViewRegionRelaEN, string strViewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewName, convViewRegionRela.ViewName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewName, 100, convViewRegionRela.ViewName);
}
objvViewRegionRelaEN.ViewName = strViewName; //界面名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRegionRelaEN.dicFldComparisonOp.ContainsKey(convViewRegionRela.ViewName) == false)
{
objvViewRegionRelaEN.dicFldComparisonOp.Add(convViewRegionRela.ViewName, strComparisonOp);
}
else
{
objvViewRegionRelaEN.dicFldComparisonOp[convViewRegionRela.ViewName] = strComparisonOp;
}
}
return objvViewRegionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionRelaEN SetApplicationTypeId(this clsvViewRegionRelaEN objvViewRegionRelaEN, int? intApplicationTypeId, string strComparisonOp="")
	{
objvViewRegionRelaEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRegionRelaEN.dicFldComparisonOp.ContainsKey(convViewRegionRela.ApplicationTypeId) == false)
{
objvViewRegionRelaEN.dicFldComparisonOp.Add(convViewRegionRela.ApplicationTypeId, strComparisonOp);
}
else
{
objvViewRegionRelaEN.dicFldComparisonOp[convViewRegionRela.ApplicationTypeId] = strComparisonOp;
}
}
return objvViewRegionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionRelaEN SetViewCnName(this clsvViewRegionRelaEN objvViewRegionRelaEN, string strViewCnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewCnName, 100, convViewRegionRela.ViewCnName);
}
objvViewRegionRelaEN.ViewCnName = strViewCnName; //视图中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRegionRelaEN.dicFldComparisonOp.ContainsKey(convViewRegionRela.ViewCnName) == false)
{
objvViewRegionRelaEN.dicFldComparisonOp.Add(convViewRegionRela.ViewCnName, strComparisonOp);
}
else
{
objvViewRegionRelaEN.dicFldComparisonOp[convViewRegionRela.ViewCnName] = strComparisonOp;
}
}
return objvViewRegionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionRelaEN SetFileName(this clsvViewRegionRelaEN objvViewRegionRelaEN, string strFileName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileName, 150, convViewRegionRela.FileName);
}
objvViewRegionRelaEN.FileName = strFileName; //文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRegionRelaEN.dicFldComparisonOp.ContainsKey(convViewRegionRela.FileName) == false)
{
objvViewRegionRelaEN.dicFldComparisonOp.Add(convViewRegionRela.FileName, strComparisonOp);
}
else
{
objvViewRegionRelaEN.dicFldComparisonOp[convViewRegionRela.FileName] = strComparisonOp;
}
}
return objvViewRegionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionRelaEN SetContainerTypeId(this clsvViewRegionRelaEN objvViewRegionRelaEN, string strContainerTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strContainerTypeId, 4, convViewRegionRela.ContainerTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strContainerTypeId, 4, convViewRegionRela.ContainerTypeId);
}
objvViewRegionRelaEN.ContainerTypeId = strContainerTypeId; //容器类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRegionRelaEN.dicFldComparisonOp.ContainsKey(convViewRegionRela.ContainerTypeId) == false)
{
objvViewRegionRelaEN.dicFldComparisonOp.Add(convViewRegionRela.ContainerTypeId, strComparisonOp);
}
else
{
objvViewRegionRelaEN.dicFldComparisonOp[convViewRegionRela.ContainerTypeId] = strComparisonOp;
}
}
return objvViewRegionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionRelaEN SetPageDispModeId(this clsvViewRegionRelaEN objvViewRegionRelaEN, string strPageDispModeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPageDispModeId, 2, convViewRegionRela.PageDispModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPageDispModeId, 2, convViewRegionRela.PageDispModeId);
}
objvViewRegionRelaEN.PageDispModeId = strPageDispModeId; //页面显示模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRegionRelaEN.dicFldComparisonOp.ContainsKey(convViewRegionRela.PageDispModeId) == false)
{
objvViewRegionRelaEN.dicFldComparisonOp.Add(convViewRegionRela.PageDispModeId, strComparisonOp);
}
else
{
objvViewRegionRelaEN.dicFldComparisonOp[convViewRegionRela.PageDispModeId] = strComparisonOp;
}
}
return objvViewRegionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionRelaEN SetInUse(this clsvViewRegionRelaEN objvViewRegionRelaEN, bool bolInUse, string strComparisonOp="")
	{
objvViewRegionRelaEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRegionRelaEN.dicFldComparisonOp.ContainsKey(convViewRegionRela.InUse) == false)
{
objvViewRegionRelaEN.dicFldComparisonOp.Add(convViewRegionRela.InUse, strComparisonOp);
}
else
{
objvViewRegionRelaEN.dicFldComparisonOp[convViewRegionRela.InUse] = strComparisonOp;
}
}
return objvViewRegionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionRelaEN SetIsDisp(this clsvViewRegionRelaEN objvViewRegionRelaEN, bool bolIsDisp, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsDisp, convViewRegionRela.IsDisp);
objvViewRegionRelaEN.IsDisp = bolIsDisp; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRegionRelaEN.dicFldComparisonOp.ContainsKey(convViewRegionRela.IsDisp) == false)
{
objvViewRegionRelaEN.dicFldComparisonOp.Add(convViewRegionRela.IsDisp, strComparisonOp);
}
else
{
objvViewRegionRelaEN.dicFldComparisonOp[convViewRegionRela.IsDisp] = strComparisonOp;
}
}
return objvViewRegionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionRelaEN SetPrjId(this clsvViewRegionRelaEN objvViewRegionRelaEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convViewRegionRela.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convViewRegionRela.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convViewRegionRela.PrjId);
}
objvViewRegionRelaEN.PrjId = strPrjId; //工程ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRegionRelaEN.dicFldComparisonOp.ContainsKey(convViewRegionRela.PrjId) == false)
{
objvViewRegionRelaEN.dicFldComparisonOp.Add(convViewRegionRela.PrjId, strComparisonOp);
}
else
{
objvViewRegionRelaEN.dicFldComparisonOp[convViewRegionRela.PrjId] = strComparisonOp;
}
}
return objvViewRegionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionRelaEN SetUpdUser(this clsvViewRegionRelaEN objvViewRegionRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convViewRegionRela.UpdUser);
}
objvViewRegionRelaEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRegionRelaEN.dicFldComparisonOp.ContainsKey(convViewRegionRela.UpdUser) == false)
{
objvViewRegionRelaEN.dicFldComparisonOp.Add(convViewRegionRela.UpdUser, strComparisonOp);
}
else
{
objvViewRegionRelaEN.dicFldComparisonOp[convViewRegionRela.UpdUser] = strComparisonOp;
}
}
return objvViewRegionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionRelaEN SetUpdDate(this clsvViewRegionRelaEN objvViewRegionRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convViewRegionRela.UpdDate);
}
objvViewRegionRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRegionRelaEN.dicFldComparisonOp.ContainsKey(convViewRegionRela.UpdDate) == false)
{
objvViewRegionRelaEN.dicFldComparisonOp.Add(convViewRegionRela.UpdDate, strComparisonOp);
}
else
{
objvViewRegionRelaEN.dicFldComparisonOp[convViewRegionRela.UpdDate] = strComparisonOp;
}
}
return objvViewRegionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionRelaEN SetMemo(this clsvViewRegionRelaEN objvViewRegionRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convViewRegionRela.Memo);
}
objvViewRegionRelaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRegionRelaEN.dicFldComparisonOp.ContainsKey(convViewRegionRela.Memo) == false)
{
objvViewRegionRelaEN.dicFldComparisonOp.Add(convViewRegionRela.Memo, strComparisonOp);
}
else
{
objvViewRegionRelaEN.dicFldComparisonOp[convViewRegionRela.Memo] = strComparisonOp;
}
}
return objvViewRegionRelaEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvViewRegionRelaENS">源对象</param>
 /// <param name = "objvViewRegionRelaENT">目标对象</param>
 public static void CopyTo(this clsvViewRegionRelaEN objvViewRegionRelaENS, clsvViewRegionRelaEN objvViewRegionRelaENT)
{
try
{
objvViewRegionRelaENT.mId = objvViewRegionRelaENS.mId; //mId
objvViewRegionRelaENT.RegionId = objvViewRegionRelaENS.RegionId; //区域Id
objvViewRegionRelaENT.RegionName = objvViewRegionRelaENS.RegionName; //区域名称
objvViewRegionRelaENT.RegionTypeId = objvViewRegionRelaENS.RegionTypeId; //区域类型Id
objvViewRegionRelaENT.RegionTypeName = objvViewRegionRelaENS.RegionTypeName; //区域类型名称
objvViewRegionRelaENT.RegionTypeSimName = objvViewRegionRelaENS.RegionTypeSimName; //区域类型简名
objvViewRegionRelaENT.RegionTypeOrderNum = objvViewRegionRelaENS.RegionTypeOrderNum; //区域类型序号
objvViewRegionRelaENT.Height = objvViewRegionRelaENS.Height; //高度
objvViewRegionRelaENT.Width = objvViewRegionRelaENS.Width; //宽
objvViewRegionRelaENT.ColNum = objvViewRegionRelaENS.ColNum; //列数
objvViewRegionRelaENT.ContainerTypeName = objvViewRegionRelaENS.ContainerTypeName; //容器类型名
objvViewRegionRelaENT.PageDispModeName = objvViewRegionRelaENS.PageDispModeName; //页面显示模式名称
objvViewRegionRelaENT.ViewId = objvViewRegionRelaENS.ViewId; //界面Id
objvViewRegionRelaENT.ViewName = objvViewRegionRelaENS.ViewName; //界面名称
objvViewRegionRelaENT.ApplicationTypeId = objvViewRegionRelaENS.ApplicationTypeId; //应用程序类型ID
objvViewRegionRelaENT.ViewCnName = objvViewRegionRelaENS.ViewCnName; //视图中文名
objvViewRegionRelaENT.FileName = objvViewRegionRelaENS.FileName; //文件名
objvViewRegionRelaENT.ContainerTypeId = objvViewRegionRelaENS.ContainerTypeId; //容器类型Id
objvViewRegionRelaENT.PageDispModeId = objvViewRegionRelaENS.PageDispModeId; //页面显示模式Id
objvViewRegionRelaENT.InUse = objvViewRegionRelaENS.InUse; //是否在用
objvViewRegionRelaENT.IsDisp = objvViewRegionRelaENS.IsDisp; //是否显示
objvViewRegionRelaENT.PrjId = objvViewRegionRelaENS.PrjId; //工程ID
objvViewRegionRelaENT.UpdUser = objvViewRegionRelaENS.UpdUser; //修改者
objvViewRegionRelaENT.UpdDate = objvViewRegionRelaENS.UpdDate; //修改日期
objvViewRegionRelaENT.Memo = objvViewRegionRelaENS.Memo; //说明
objvViewRegionRelaENT.ClsName = objvViewRegionRelaENS.ClsName; //类名
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000166)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyTo)
 /// </summary>
 /// <param name = "objvViewRegionRelaENS">源对象</param>
 /// <returns>目标对象=>clsvViewRegionRelaEN:objvViewRegionRelaENT</returns>
 public static clsvViewRegionRelaEN CopyTo(this clsvViewRegionRelaEN objvViewRegionRelaENS)
{
try
{
 clsvViewRegionRelaEN objvViewRegionRelaENT = new clsvViewRegionRelaEN()
{
mId = objvViewRegionRelaENS.mId, //mId
RegionId = objvViewRegionRelaENS.RegionId, //区域Id
RegionName = objvViewRegionRelaENS.RegionName, //区域名称
RegionTypeId = objvViewRegionRelaENS.RegionTypeId, //区域类型Id
RegionTypeName = objvViewRegionRelaENS.RegionTypeName, //区域类型名称
RegionTypeSimName = objvViewRegionRelaENS.RegionTypeSimName, //区域类型简名
RegionTypeOrderNum = objvViewRegionRelaENS.RegionTypeOrderNum, //区域类型序号
Height = objvViewRegionRelaENS.Height, //高度
Width = objvViewRegionRelaENS.Width, //宽
ColNum = objvViewRegionRelaENS.ColNum, //列数
ContainerTypeName = objvViewRegionRelaENS.ContainerTypeName, //容器类型名
PageDispModeName = objvViewRegionRelaENS.PageDispModeName, //页面显示模式名称
ViewId = objvViewRegionRelaENS.ViewId, //界面Id
ViewName = objvViewRegionRelaENS.ViewName, //界面名称
ApplicationTypeId = objvViewRegionRelaENS.ApplicationTypeId, //应用程序类型ID
ViewCnName = objvViewRegionRelaENS.ViewCnName, //视图中文名
FileName = objvViewRegionRelaENS.FileName, //文件名
ContainerTypeId = objvViewRegionRelaENS.ContainerTypeId, //容器类型Id
PageDispModeId = objvViewRegionRelaENS.PageDispModeId, //页面显示模式Id
InUse = objvViewRegionRelaENS.InUse, //是否在用
IsDisp = objvViewRegionRelaENS.IsDisp, //是否显示
PrjId = objvViewRegionRelaENS.PrjId, //工程ID
UpdUser = objvViewRegionRelaENS.UpdUser, //修改者
UpdDate = objvViewRegionRelaENS.UpdDate, //修改日期
Memo = objvViewRegionRelaENS.Memo, //说明
ClsName = objvViewRegionRelaENS.ClsName, //类名
};
 return objvViewRegionRelaENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000167)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsvViewRegionRelaEN objvViewRegionRelaEN)
{
 clsvViewRegionRelaBL.vViewRegionRelaDA.CheckProperty4Condition(objvViewRegionRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvViewRegionRelaEN objvViewRegionRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvViewRegionRelaCond.IsUpdated(convViewRegionRela.mId) == true)
{
string strComparisonOpmId = objvViewRegionRelaCond.dicFldComparisonOp[convViewRegionRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convViewRegionRela.mId, objvViewRegionRelaCond.mId, strComparisonOpmId);
}
if (objvViewRegionRelaCond.IsUpdated(convViewRegionRela.RegionId) == true)
{
string strComparisonOpRegionId = objvViewRegionRelaCond.dicFldComparisonOp[convViewRegionRela.RegionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRegionRela.RegionId, objvViewRegionRelaCond.RegionId, strComparisonOpRegionId);
}
if (objvViewRegionRelaCond.IsUpdated(convViewRegionRela.RegionName) == true)
{
string strComparisonOpRegionName = objvViewRegionRelaCond.dicFldComparisonOp[convViewRegionRela.RegionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRegionRela.RegionName, objvViewRegionRelaCond.RegionName, strComparisonOpRegionName);
}
if (objvViewRegionRelaCond.IsUpdated(convViewRegionRela.RegionTypeId) == true)
{
string strComparisonOpRegionTypeId = objvViewRegionRelaCond.dicFldComparisonOp[convViewRegionRela.RegionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRegionRela.RegionTypeId, objvViewRegionRelaCond.RegionTypeId, strComparisonOpRegionTypeId);
}
if (objvViewRegionRelaCond.IsUpdated(convViewRegionRela.RegionTypeName) == true)
{
string strComparisonOpRegionTypeName = objvViewRegionRelaCond.dicFldComparisonOp[convViewRegionRela.RegionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRegionRela.RegionTypeName, objvViewRegionRelaCond.RegionTypeName, strComparisonOpRegionTypeName);
}
if (objvViewRegionRelaCond.IsUpdated(convViewRegionRela.RegionTypeSimName) == true)
{
string strComparisonOpRegionTypeSimName = objvViewRegionRelaCond.dicFldComparisonOp[convViewRegionRela.RegionTypeSimName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRegionRela.RegionTypeSimName, objvViewRegionRelaCond.RegionTypeSimName, strComparisonOpRegionTypeSimName);
}
if (objvViewRegionRelaCond.IsUpdated(convViewRegionRela.RegionTypeOrderNum) == true)
{
string strComparisonOpRegionTypeOrderNum = objvViewRegionRelaCond.dicFldComparisonOp[convViewRegionRela.RegionTypeOrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convViewRegionRela.RegionTypeOrderNum, objvViewRegionRelaCond.RegionTypeOrderNum, strComparisonOpRegionTypeOrderNum);
}
if (objvViewRegionRelaCond.IsUpdated(convViewRegionRela.Height) == true)
{
string strComparisonOpHeight = objvViewRegionRelaCond.dicFldComparisonOp[convViewRegionRela.Height];
strWhereCond += string.Format(" And {0} {2} {1}", convViewRegionRela.Height, objvViewRegionRelaCond.Height, strComparisonOpHeight);
}
if (objvViewRegionRelaCond.IsUpdated(convViewRegionRela.Width) == true)
{
string strComparisonOpWidth = objvViewRegionRelaCond.dicFldComparisonOp[convViewRegionRela.Width];
strWhereCond += string.Format(" And {0} {2} {1}", convViewRegionRela.Width, objvViewRegionRelaCond.Width, strComparisonOpWidth);
}
if (objvViewRegionRelaCond.IsUpdated(convViewRegionRela.ColNum) == true)
{
string strComparisonOpColNum = objvViewRegionRelaCond.dicFldComparisonOp[convViewRegionRela.ColNum];
strWhereCond += string.Format(" And {0} {2} {1}", convViewRegionRela.ColNum, objvViewRegionRelaCond.ColNum, strComparisonOpColNum);
}
if (objvViewRegionRelaCond.IsUpdated(convViewRegionRela.ContainerTypeName) == true)
{
string strComparisonOpContainerTypeName = objvViewRegionRelaCond.dicFldComparisonOp[convViewRegionRela.ContainerTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRegionRela.ContainerTypeName, objvViewRegionRelaCond.ContainerTypeName, strComparisonOpContainerTypeName);
}
if (objvViewRegionRelaCond.IsUpdated(convViewRegionRela.PageDispModeName) == true)
{
string strComparisonOpPageDispModeName = objvViewRegionRelaCond.dicFldComparisonOp[convViewRegionRela.PageDispModeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRegionRela.PageDispModeName, objvViewRegionRelaCond.PageDispModeName, strComparisonOpPageDispModeName);
}
if (objvViewRegionRelaCond.IsUpdated(convViewRegionRela.ViewId) == true)
{
string strComparisonOpViewId = objvViewRegionRelaCond.dicFldComparisonOp[convViewRegionRela.ViewId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRegionRela.ViewId, objvViewRegionRelaCond.ViewId, strComparisonOpViewId);
}
if (objvViewRegionRelaCond.IsUpdated(convViewRegionRela.ViewName) == true)
{
string strComparisonOpViewName = objvViewRegionRelaCond.dicFldComparisonOp[convViewRegionRela.ViewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRegionRela.ViewName, objvViewRegionRelaCond.ViewName, strComparisonOpViewName);
}
if (objvViewRegionRelaCond.IsUpdated(convViewRegionRela.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objvViewRegionRelaCond.dicFldComparisonOp[convViewRegionRela.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", convViewRegionRela.ApplicationTypeId, objvViewRegionRelaCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objvViewRegionRelaCond.IsUpdated(convViewRegionRela.ViewCnName) == true)
{
string strComparisonOpViewCnName = objvViewRegionRelaCond.dicFldComparisonOp[convViewRegionRela.ViewCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRegionRela.ViewCnName, objvViewRegionRelaCond.ViewCnName, strComparisonOpViewCnName);
}
if (objvViewRegionRelaCond.IsUpdated(convViewRegionRela.FileName) == true)
{
string strComparisonOpFileName = objvViewRegionRelaCond.dicFldComparisonOp[convViewRegionRela.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRegionRela.FileName, objvViewRegionRelaCond.FileName, strComparisonOpFileName);
}
if (objvViewRegionRelaCond.IsUpdated(convViewRegionRela.ContainerTypeId) == true)
{
string strComparisonOpContainerTypeId = objvViewRegionRelaCond.dicFldComparisonOp[convViewRegionRela.ContainerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRegionRela.ContainerTypeId, objvViewRegionRelaCond.ContainerTypeId, strComparisonOpContainerTypeId);
}
if (objvViewRegionRelaCond.IsUpdated(convViewRegionRela.PageDispModeId) == true)
{
string strComparisonOpPageDispModeId = objvViewRegionRelaCond.dicFldComparisonOp[convViewRegionRela.PageDispModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRegionRela.PageDispModeId, objvViewRegionRelaCond.PageDispModeId, strComparisonOpPageDispModeId);
}
if (objvViewRegionRelaCond.IsUpdated(convViewRegionRela.InUse) == true)
{
if (objvViewRegionRelaCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convViewRegionRela.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convViewRegionRela.InUse);
}
}
if (objvViewRegionRelaCond.IsUpdated(convViewRegionRela.IsDisp) == true)
{
if (objvViewRegionRelaCond.IsDisp == true)
{
strWhereCond += string.Format(" And {0} = '1'", convViewRegionRela.IsDisp);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convViewRegionRela.IsDisp);
}
}
if (objvViewRegionRelaCond.IsUpdated(convViewRegionRela.PrjId) == true)
{
string strComparisonOpPrjId = objvViewRegionRelaCond.dicFldComparisonOp[convViewRegionRela.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRegionRela.PrjId, objvViewRegionRelaCond.PrjId, strComparisonOpPrjId);
}
if (objvViewRegionRelaCond.IsUpdated(convViewRegionRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objvViewRegionRelaCond.dicFldComparisonOp[convViewRegionRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRegionRela.UpdUser, objvViewRegionRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objvViewRegionRelaCond.IsUpdated(convViewRegionRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvViewRegionRelaCond.dicFldComparisonOp[convViewRegionRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRegionRela.UpdDate, objvViewRegionRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvViewRegionRelaCond.IsUpdated(convViewRegionRela.Memo) == true)
{
string strComparisonOpMemo = objvViewRegionRelaCond.dicFldComparisonOp[convViewRegionRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRegionRela.Memo, objvViewRegionRelaCond.Memo, strComparisonOpMemo);
}
if (objvViewRegionRelaCond.IsUpdated(convViewRegionRela.ClsName) == true)
{
string strComparisonOpClsName = objvViewRegionRelaCond.dicFldComparisonOp[convViewRegionRela.ClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRegionRela.ClsName, objvViewRegionRelaCond.ClsName, strComparisonOpClsName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vViewRegionRela
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v界面区域关系(vViewRegionRela)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvViewRegionRelaBL
{
public static RelatedActions_vViewRegionRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvViewRegionRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvViewRegionRelaDA vViewRegionRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvViewRegionRelaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvViewRegionRelaBL()
 {
 }

 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSpecSQLObj)
 /// </summary>
 /// <returns>SQL服务器连接对象</returns>
 public static clsSpecSQLforSql GetSpecSQLObj() 
{
if (clsSysParaEN.objLog == null)
{
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象!");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象!");
}
 clsSpecSQLforSql objSQL;
 //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
 if (clsSysParaEN.bolIsUseConnectStrName == true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
if (string.IsNullOrEmpty(clsvViewRegionRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvViewRegionRelaEN._ConnectString);
}
return objSQL;
}



 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_vViewRegionRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vViewRegionRelaDA.GetDataTable_vViewRegionRela(strWhereCond);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000005)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vViewRegionRelaDA.GetDataTable(strWhereCond);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000006)获取表数据出错!(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vViewRegionRelaDA.GetDataTable(strWhereCond, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000007)获取表数据出错!(排除的检查字符串列表)(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByTabName)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable(string strWhereCond, string strTabName)
{
DataTable objDT;
try
{
objDT = vViewRegionRelaDA.GetDataTable(strWhereCond, strTabName);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000061)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByTabName)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, string strTabName, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vViewRegionRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000062)获取表数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTable)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_Top(stuTopPara objTopPara)
{
DataTable objDT;
try
{
objDT = vViewRegionRelaDA.GetDataTable_Top(objTopPara);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000009)获取表顶数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
objTopPara.whereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTable)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable_Top(int intTopSize, string strWhereCond, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vViewRegionRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000010)获取表顶数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
DataTable objDT;
try
{
objDT = vViewRegionRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000012)获取分页表顶数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vViewRegionRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000013)获取分页表顶数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 获取数据表的DataTable


 #region 获取数据表的多个对象列表

 /// <summary>
 /// 根据关键字列表获取相关对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLst)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvViewRegionRelaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvViewRegionRelaEN> arrObjLst = new List<clsvViewRegionRelaEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMIdLst);
 string strWhereCond = string.Format("mId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewRegionRelaEN objvViewRegionRelaEN = new clsvViewRegionRelaEN();
try
{
objvViewRegionRelaEN.mId = Int32.Parse(objRow[convViewRegionRela.mId].ToString().Trim()); //mId
objvViewRegionRelaEN.RegionId = objRow[convViewRegionRela.RegionId].ToString().Trim(); //区域Id
objvViewRegionRelaEN.RegionName = objRow[convViewRegionRela.RegionName].ToString().Trim(); //区域名称
objvViewRegionRelaEN.RegionTypeId = objRow[convViewRegionRela.RegionTypeId].ToString().Trim(); //区域类型Id
objvViewRegionRelaEN.RegionTypeName = objRow[convViewRegionRela.RegionTypeName].ToString().Trim(); //区域类型名称
objvViewRegionRelaEN.RegionTypeSimName = objRow[convViewRegionRela.RegionTypeSimName] == DBNull.Value ? null : objRow[convViewRegionRela.RegionTypeSimName].ToString().Trim(); //区域类型简名
objvViewRegionRelaEN.RegionTypeOrderNum = objRow[convViewRegionRela.RegionTypeOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.RegionTypeOrderNum].ToString().Trim()); //区域类型序号
objvViewRegionRelaEN.Height = objRow[convViewRegionRela.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.Height].ToString().Trim()); //高度
objvViewRegionRelaEN.Width = objRow[convViewRegionRela.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.Width].ToString().Trim()); //宽
objvViewRegionRelaEN.ColNum = objRow[convViewRegionRela.ColNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.ColNum].ToString().Trim()); //列数
objvViewRegionRelaEN.ContainerTypeName = objRow[convViewRegionRela.ContainerTypeName] == DBNull.Value ? null : objRow[convViewRegionRela.ContainerTypeName].ToString().Trim(); //容器类型名
objvViewRegionRelaEN.PageDispModeName = objRow[convViewRegionRela.PageDispModeName] == DBNull.Value ? null : objRow[convViewRegionRela.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvViewRegionRelaEN.ViewId = objRow[convViewRegionRela.ViewId] == DBNull.Value ? null : objRow[convViewRegionRela.ViewId].ToString().Trim(); //界面Id
objvViewRegionRelaEN.ViewName = objRow[convViewRegionRela.ViewName].ToString().Trim(); //界面名称
objvViewRegionRelaEN.ApplicationTypeId = objRow[convViewRegionRela.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewRegionRelaEN.ViewCnName = objRow[convViewRegionRela.ViewCnName] == DBNull.Value ? null : objRow[convViewRegionRela.ViewCnName].ToString().Trim(); //视图中文名
objvViewRegionRelaEN.FileName = objRow[convViewRegionRela.FileName] == DBNull.Value ? null : objRow[convViewRegionRela.FileName].ToString().Trim(); //文件名
objvViewRegionRelaEN.ContainerTypeId = objRow[convViewRegionRela.ContainerTypeId] == DBNull.Value ? null : objRow[convViewRegionRela.ContainerTypeId].ToString().Trim(); //容器类型Id
objvViewRegionRelaEN.PageDispModeId = objRow[convViewRegionRela.PageDispModeId] == DBNull.Value ? null : objRow[convViewRegionRela.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvViewRegionRelaEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convViewRegionRela.InUse].ToString().Trim()); //是否在用
objvViewRegionRelaEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[convViewRegionRela.IsDisp].ToString().Trim()); //是否显示
objvViewRegionRelaEN.PrjId = objRow[convViewRegionRela.PrjId].ToString().Trim(); //工程ID
objvViewRegionRelaEN.UpdUser = objRow[convViewRegionRela.UpdUser] == DBNull.Value ? null : objRow[convViewRegionRela.UpdUser].ToString().Trim(); //修改者
objvViewRegionRelaEN.UpdDate = objRow[convViewRegionRela.UpdDate] == DBNull.Value ? null : objRow[convViewRegionRela.UpdDate].ToString().Trim(); //修改日期
objvViewRegionRelaEN.Memo = objRow[convViewRegionRela.Memo] == DBNull.Value ? null : objRow[convViewRegionRela.Memo].ToString().Trim(); //说明
objvViewRegionRelaEN.ClsName = objRow[convViewRegionRela.ClsName] == DBNull.Value ? null : objRow[convViewRegionRela.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewRegionRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewRegionRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvViewRegionRelaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvViewRegionRelaEN._CurrTabName, strPrjId);
List<clsvViewRegionRelaEN> arrvViewRegionRelaObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvViewRegionRelaEN> arrvViewRegionRelaObjLst_Sel =
arrvViewRegionRelaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvViewRegionRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewRegionRelaEN> GetObjLst(string strWhereCond)
{
List<clsvViewRegionRelaEN> arrObjLst = new List<clsvViewRegionRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewRegionRelaEN objvViewRegionRelaEN = new clsvViewRegionRelaEN();
try
{
objvViewRegionRelaEN.mId = Int32.Parse(objRow[convViewRegionRela.mId].ToString().Trim()); //mId
objvViewRegionRelaEN.RegionId = objRow[convViewRegionRela.RegionId].ToString().Trim(); //区域Id
objvViewRegionRelaEN.RegionName = objRow[convViewRegionRela.RegionName].ToString().Trim(); //区域名称
objvViewRegionRelaEN.RegionTypeId = objRow[convViewRegionRela.RegionTypeId].ToString().Trim(); //区域类型Id
objvViewRegionRelaEN.RegionTypeName = objRow[convViewRegionRela.RegionTypeName].ToString().Trim(); //区域类型名称
objvViewRegionRelaEN.RegionTypeSimName = objRow[convViewRegionRela.RegionTypeSimName] == DBNull.Value ? null : objRow[convViewRegionRela.RegionTypeSimName].ToString().Trim(); //区域类型简名
objvViewRegionRelaEN.RegionTypeOrderNum = objRow[convViewRegionRela.RegionTypeOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.RegionTypeOrderNum].ToString().Trim()); //区域类型序号
objvViewRegionRelaEN.Height = objRow[convViewRegionRela.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.Height].ToString().Trim()); //高度
objvViewRegionRelaEN.Width = objRow[convViewRegionRela.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.Width].ToString().Trim()); //宽
objvViewRegionRelaEN.ColNum = objRow[convViewRegionRela.ColNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.ColNum].ToString().Trim()); //列数
objvViewRegionRelaEN.ContainerTypeName = objRow[convViewRegionRela.ContainerTypeName] == DBNull.Value ? null : objRow[convViewRegionRela.ContainerTypeName].ToString().Trim(); //容器类型名
objvViewRegionRelaEN.PageDispModeName = objRow[convViewRegionRela.PageDispModeName] == DBNull.Value ? null : objRow[convViewRegionRela.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvViewRegionRelaEN.ViewId = objRow[convViewRegionRela.ViewId] == DBNull.Value ? null : objRow[convViewRegionRela.ViewId].ToString().Trim(); //界面Id
objvViewRegionRelaEN.ViewName = objRow[convViewRegionRela.ViewName].ToString().Trim(); //界面名称
objvViewRegionRelaEN.ApplicationTypeId = objRow[convViewRegionRela.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewRegionRelaEN.ViewCnName = objRow[convViewRegionRela.ViewCnName] == DBNull.Value ? null : objRow[convViewRegionRela.ViewCnName].ToString().Trim(); //视图中文名
objvViewRegionRelaEN.FileName = objRow[convViewRegionRela.FileName] == DBNull.Value ? null : objRow[convViewRegionRela.FileName].ToString().Trim(); //文件名
objvViewRegionRelaEN.ContainerTypeId = objRow[convViewRegionRela.ContainerTypeId] == DBNull.Value ? null : objRow[convViewRegionRela.ContainerTypeId].ToString().Trim(); //容器类型Id
objvViewRegionRelaEN.PageDispModeId = objRow[convViewRegionRela.PageDispModeId] == DBNull.Value ? null : objRow[convViewRegionRela.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvViewRegionRelaEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convViewRegionRela.InUse].ToString().Trim()); //是否在用
objvViewRegionRelaEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[convViewRegionRela.IsDisp].ToString().Trim()); //是否显示
objvViewRegionRelaEN.PrjId = objRow[convViewRegionRela.PrjId].ToString().Trim(); //工程ID
objvViewRegionRelaEN.UpdUser = objRow[convViewRegionRela.UpdUser] == DBNull.Value ? null : objRow[convViewRegionRela.UpdUser].ToString().Trim(); //修改者
objvViewRegionRelaEN.UpdDate = objRow[convViewRegionRela.UpdDate] == DBNull.Value ? null : objRow[convViewRegionRela.UpdDate].ToString().Trim(); //修改日期
objvViewRegionRelaEN.Memo = objRow[convViewRegionRela.Memo] == DBNull.Value ? null : objRow[convViewRegionRela.Memo].ToString().Trim(); //说明
objvViewRegionRelaEN.ClsName = objRow[convViewRegionRela.ClsName] == DBNull.Value ? null : objRow[convViewRegionRela.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewRegionRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewRegionRelaEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewRegionRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvViewRegionRelaEN> arrObjLst = new List<clsvViewRegionRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewRegionRelaEN objvViewRegionRelaEN = new clsvViewRegionRelaEN();
try
{
objvViewRegionRelaEN.mId = Int32.Parse(objRow[convViewRegionRela.mId].ToString().Trim()); //mId
objvViewRegionRelaEN.RegionId = objRow[convViewRegionRela.RegionId].ToString().Trim(); //区域Id
objvViewRegionRelaEN.RegionName = objRow[convViewRegionRela.RegionName].ToString().Trim(); //区域名称
objvViewRegionRelaEN.RegionTypeId = objRow[convViewRegionRela.RegionTypeId].ToString().Trim(); //区域类型Id
objvViewRegionRelaEN.RegionTypeName = objRow[convViewRegionRela.RegionTypeName].ToString().Trim(); //区域类型名称
objvViewRegionRelaEN.RegionTypeSimName = objRow[convViewRegionRela.RegionTypeSimName] == DBNull.Value ? null : objRow[convViewRegionRela.RegionTypeSimName].ToString().Trim(); //区域类型简名
objvViewRegionRelaEN.RegionTypeOrderNum = objRow[convViewRegionRela.RegionTypeOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.RegionTypeOrderNum].ToString().Trim()); //区域类型序号
objvViewRegionRelaEN.Height = objRow[convViewRegionRela.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.Height].ToString().Trim()); //高度
objvViewRegionRelaEN.Width = objRow[convViewRegionRela.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.Width].ToString().Trim()); //宽
objvViewRegionRelaEN.ColNum = objRow[convViewRegionRela.ColNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.ColNum].ToString().Trim()); //列数
objvViewRegionRelaEN.ContainerTypeName = objRow[convViewRegionRela.ContainerTypeName] == DBNull.Value ? null : objRow[convViewRegionRela.ContainerTypeName].ToString().Trim(); //容器类型名
objvViewRegionRelaEN.PageDispModeName = objRow[convViewRegionRela.PageDispModeName] == DBNull.Value ? null : objRow[convViewRegionRela.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvViewRegionRelaEN.ViewId = objRow[convViewRegionRela.ViewId] == DBNull.Value ? null : objRow[convViewRegionRela.ViewId].ToString().Trim(); //界面Id
objvViewRegionRelaEN.ViewName = objRow[convViewRegionRela.ViewName].ToString().Trim(); //界面名称
objvViewRegionRelaEN.ApplicationTypeId = objRow[convViewRegionRela.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewRegionRelaEN.ViewCnName = objRow[convViewRegionRela.ViewCnName] == DBNull.Value ? null : objRow[convViewRegionRela.ViewCnName].ToString().Trim(); //视图中文名
objvViewRegionRelaEN.FileName = objRow[convViewRegionRela.FileName] == DBNull.Value ? null : objRow[convViewRegionRela.FileName].ToString().Trim(); //文件名
objvViewRegionRelaEN.ContainerTypeId = objRow[convViewRegionRela.ContainerTypeId] == DBNull.Value ? null : objRow[convViewRegionRela.ContainerTypeId].ToString().Trim(); //容器类型Id
objvViewRegionRelaEN.PageDispModeId = objRow[convViewRegionRela.PageDispModeId] == DBNull.Value ? null : objRow[convViewRegionRela.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvViewRegionRelaEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convViewRegionRela.InUse].ToString().Trim()); //是否在用
objvViewRegionRelaEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[convViewRegionRela.IsDisp].ToString().Trim()); //是否显示
objvViewRegionRelaEN.PrjId = objRow[convViewRegionRela.PrjId].ToString().Trim(); //工程ID
objvViewRegionRelaEN.UpdUser = objRow[convViewRegionRela.UpdUser] == DBNull.Value ? null : objRow[convViewRegionRela.UpdUser].ToString().Trim(); //修改者
objvViewRegionRelaEN.UpdDate = objRow[convViewRegionRela.UpdDate] == DBNull.Value ? null : objRow[convViewRegionRela.UpdDate].ToString().Trim(); //修改日期
objvViewRegionRelaEN.Memo = objRow[convViewRegionRela.Memo] == DBNull.Value ? null : objRow[convViewRegionRela.Memo].ToString().Trim(); //说明
objvViewRegionRelaEN.ClsName = objRow[convViewRegionRela.ClsName] == DBNull.Value ? null : objRow[convViewRegionRela.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewRegionRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewRegionRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvViewRegionRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvViewRegionRelaEN> GetSubObjLstCache(clsvViewRegionRelaEN objvViewRegionRelaCond)
{
 string strPrjId = objvViewRegionRelaCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvViewRegionRelaBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvViewRegionRelaEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvViewRegionRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convViewRegionRela.AttributeName)
{
if (objvViewRegionRelaCond.IsUpdated(strFldName) == false) continue;
if (objvViewRegionRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewRegionRelaCond[strFldName].ToString());
}
else
{
if (objvViewRegionRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvViewRegionRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewRegionRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvViewRegionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvViewRegionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvViewRegionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvViewRegionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvViewRegionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvViewRegionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvViewRegionRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvViewRegionRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvViewRegionRelaCond[strFldName]));
}
}
}
return arrObjLstSel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewRegionRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvViewRegionRelaEN> arrObjLst = new List<clsvViewRegionRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewRegionRelaEN objvViewRegionRelaEN = new clsvViewRegionRelaEN();
try
{
objvViewRegionRelaEN.mId = Int32.Parse(objRow[convViewRegionRela.mId].ToString().Trim()); //mId
objvViewRegionRelaEN.RegionId = objRow[convViewRegionRela.RegionId].ToString().Trim(); //区域Id
objvViewRegionRelaEN.RegionName = objRow[convViewRegionRela.RegionName].ToString().Trim(); //区域名称
objvViewRegionRelaEN.RegionTypeId = objRow[convViewRegionRela.RegionTypeId].ToString().Trim(); //区域类型Id
objvViewRegionRelaEN.RegionTypeName = objRow[convViewRegionRela.RegionTypeName].ToString().Trim(); //区域类型名称
objvViewRegionRelaEN.RegionTypeSimName = objRow[convViewRegionRela.RegionTypeSimName] == DBNull.Value ? null : objRow[convViewRegionRela.RegionTypeSimName].ToString().Trim(); //区域类型简名
objvViewRegionRelaEN.RegionTypeOrderNum = objRow[convViewRegionRela.RegionTypeOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.RegionTypeOrderNum].ToString().Trim()); //区域类型序号
objvViewRegionRelaEN.Height = objRow[convViewRegionRela.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.Height].ToString().Trim()); //高度
objvViewRegionRelaEN.Width = objRow[convViewRegionRela.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.Width].ToString().Trim()); //宽
objvViewRegionRelaEN.ColNum = objRow[convViewRegionRela.ColNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.ColNum].ToString().Trim()); //列数
objvViewRegionRelaEN.ContainerTypeName = objRow[convViewRegionRela.ContainerTypeName] == DBNull.Value ? null : objRow[convViewRegionRela.ContainerTypeName].ToString().Trim(); //容器类型名
objvViewRegionRelaEN.PageDispModeName = objRow[convViewRegionRela.PageDispModeName] == DBNull.Value ? null : objRow[convViewRegionRela.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvViewRegionRelaEN.ViewId = objRow[convViewRegionRela.ViewId] == DBNull.Value ? null : objRow[convViewRegionRela.ViewId].ToString().Trim(); //界面Id
objvViewRegionRelaEN.ViewName = objRow[convViewRegionRela.ViewName].ToString().Trim(); //界面名称
objvViewRegionRelaEN.ApplicationTypeId = objRow[convViewRegionRela.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewRegionRelaEN.ViewCnName = objRow[convViewRegionRela.ViewCnName] == DBNull.Value ? null : objRow[convViewRegionRela.ViewCnName].ToString().Trim(); //视图中文名
objvViewRegionRelaEN.FileName = objRow[convViewRegionRela.FileName] == DBNull.Value ? null : objRow[convViewRegionRela.FileName].ToString().Trim(); //文件名
objvViewRegionRelaEN.ContainerTypeId = objRow[convViewRegionRela.ContainerTypeId] == DBNull.Value ? null : objRow[convViewRegionRela.ContainerTypeId].ToString().Trim(); //容器类型Id
objvViewRegionRelaEN.PageDispModeId = objRow[convViewRegionRela.PageDispModeId] == DBNull.Value ? null : objRow[convViewRegionRela.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvViewRegionRelaEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convViewRegionRela.InUse].ToString().Trim()); //是否在用
objvViewRegionRelaEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[convViewRegionRela.IsDisp].ToString().Trim()); //是否显示
objvViewRegionRelaEN.PrjId = objRow[convViewRegionRela.PrjId].ToString().Trim(); //工程ID
objvViewRegionRelaEN.UpdUser = objRow[convViewRegionRela.UpdUser] == DBNull.Value ? null : objRow[convViewRegionRela.UpdUser].ToString().Trim(); //修改者
objvViewRegionRelaEN.UpdDate = objRow[convViewRegionRela.UpdDate] == DBNull.Value ? null : objRow[convViewRegionRela.UpdDate].ToString().Trim(); //修改日期
objvViewRegionRelaEN.Memo = objRow[convViewRegionRela.Memo] == DBNull.Value ? null : objRow[convViewRegionRela.Memo].ToString().Trim(); //说明
objvViewRegionRelaEN.ClsName = objRow[convViewRegionRela.ClsName] == DBNull.Value ? null : objRow[convViewRegionRela.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewRegionRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewRegionRelaEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewRegionRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvViewRegionRelaEN> arrObjLst = new List<clsvViewRegionRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewRegionRelaEN objvViewRegionRelaEN = new clsvViewRegionRelaEN();
try
{
objvViewRegionRelaEN.mId = Int32.Parse(objRow[convViewRegionRela.mId].ToString().Trim()); //mId
objvViewRegionRelaEN.RegionId = objRow[convViewRegionRela.RegionId].ToString().Trim(); //区域Id
objvViewRegionRelaEN.RegionName = objRow[convViewRegionRela.RegionName].ToString().Trim(); //区域名称
objvViewRegionRelaEN.RegionTypeId = objRow[convViewRegionRela.RegionTypeId].ToString().Trim(); //区域类型Id
objvViewRegionRelaEN.RegionTypeName = objRow[convViewRegionRela.RegionTypeName].ToString().Trim(); //区域类型名称
objvViewRegionRelaEN.RegionTypeSimName = objRow[convViewRegionRela.RegionTypeSimName] == DBNull.Value ? null : objRow[convViewRegionRela.RegionTypeSimName].ToString().Trim(); //区域类型简名
objvViewRegionRelaEN.RegionTypeOrderNum = objRow[convViewRegionRela.RegionTypeOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.RegionTypeOrderNum].ToString().Trim()); //区域类型序号
objvViewRegionRelaEN.Height = objRow[convViewRegionRela.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.Height].ToString().Trim()); //高度
objvViewRegionRelaEN.Width = objRow[convViewRegionRela.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.Width].ToString().Trim()); //宽
objvViewRegionRelaEN.ColNum = objRow[convViewRegionRela.ColNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.ColNum].ToString().Trim()); //列数
objvViewRegionRelaEN.ContainerTypeName = objRow[convViewRegionRela.ContainerTypeName] == DBNull.Value ? null : objRow[convViewRegionRela.ContainerTypeName].ToString().Trim(); //容器类型名
objvViewRegionRelaEN.PageDispModeName = objRow[convViewRegionRela.PageDispModeName] == DBNull.Value ? null : objRow[convViewRegionRela.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvViewRegionRelaEN.ViewId = objRow[convViewRegionRela.ViewId] == DBNull.Value ? null : objRow[convViewRegionRela.ViewId].ToString().Trim(); //界面Id
objvViewRegionRelaEN.ViewName = objRow[convViewRegionRela.ViewName].ToString().Trim(); //界面名称
objvViewRegionRelaEN.ApplicationTypeId = objRow[convViewRegionRela.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewRegionRelaEN.ViewCnName = objRow[convViewRegionRela.ViewCnName] == DBNull.Value ? null : objRow[convViewRegionRela.ViewCnName].ToString().Trim(); //视图中文名
objvViewRegionRelaEN.FileName = objRow[convViewRegionRela.FileName] == DBNull.Value ? null : objRow[convViewRegionRela.FileName].ToString().Trim(); //文件名
objvViewRegionRelaEN.ContainerTypeId = objRow[convViewRegionRela.ContainerTypeId] == DBNull.Value ? null : objRow[convViewRegionRela.ContainerTypeId].ToString().Trim(); //容器类型Id
objvViewRegionRelaEN.PageDispModeId = objRow[convViewRegionRela.PageDispModeId] == DBNull.Value ? null : objRow[convViewRegionRela.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvViewRegionRelaEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convViewRegionRela.InUse].ToString().Trim()); //是否在用
objvViewRegionRelaEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[convViewRegionRela.IsDisp].ToString().Trim()); //是否显示
objvViewRegionRelaEN.PrjId = objRow[convViewRegionRela.PrjId].ToString().Trim(); //工程ID
objvViewRegionRelaEN.UpdUser = objRow[convViewRegionRela.UpdUser] == DBNull.Value ? null : objRow[convViewRegionRela.UpdUser].ToString().Trim(); //修改者
objvViewRegionRelaEN.UpdDate = objRow[convViewRegionRela.UpdDate] == DBNull.Value ? null : objRow[convViewRegionRela.UpdDate].ToString().Trim(); //修改日期
objvViewRegionRelaEN.Memo = objRow[convViewRegionRela.Memo] == DBNull.Value ? null : objRow[convViewRegionRela.Memo].ToString().Trim(); //说明
objvViewRegionRelaEN.ClsName = objRow[convViewRegionRela.ClsName] == DBNull.Value ? null : objRow[convViewRegionRela.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewRegionRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewRegionRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetJSONObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static string GetJSONObjLst(string strWhereCond)
{
List<clsvViewRegionRelaEN> arrObjLst = GetObjLst(strWhereCond);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}
 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetJSONObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static string GetJSONObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvViewRegionRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewRegionRelaEN> GetTopObjLst(stuTopPara objTopPara)
{
 return GetTopObjLst( objTopPara.topSize, objTopPara.whereCond, objTopPara.orderBy);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewRegionRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvViewRegionRelaEN> arrObjLst = new List<clsvViewRegionRelaEN>(); 
System.Data.DataTable objDT; 
 stuTopPara objTopPara = new stuTopPara()
 {
 topSize = intTopSize,
 whereCond = strWhereCond,
 orderBy = strOrderBy
 };
 objDT = GetDataTable_Top(objTopPara);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewRegionRelaEN objvViewRegionRelaEN = new clsvViewRegionRelaEN();
try
{
objvViewRegionRelaEN.mId = Int32.Parse(objRow[convViewRegionRela.mId].ToString().Trim()); //mId
objvViewRegionRelaEN.RegionId = objRow[convViewRegionRela.RegionId].ToString().Trim(); //区域Id
objvViewRegionRelaEN.RegionName = objRow[convViewRegionRela.RegionName].ToString().Trim(); //区域名称
objvViewRegionRelaEN.RegionTypeId = objRow[convViewRegionRela.RegionTypeId].ToString().Trim(); //区域类型Id
objvViewRegionRelaEN.RegionTypeName = objRow[convViewRegionRela.RegionTypeName].ToString().Trim(); //区域类型名称
objvViewRegionRelaEN.RegionTypeSimName = objRow[convViewRegionRela.RegionTypeSimName] == DBNull.Value ? null : objRow[convViewRegionRela.RegionTypeSimName].ToString().Trim(); //区域类型简名
objvViewRegionRelaEN.RegionTypeOrderNum = objRow[convViewRegionRela.RegionTypeOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.RegionTypeOrderNum].ToString().Trim()); //区域类型序号
objvViewRegionRelaEN.Height = objRow[convViewRegionRela.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.Height].ToString().Trim()); //高度
objvViewRegionRelaEN.Width = objRow[convViewRegionRela.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.Width].ToString().Trim()); //宽
objvViewRegionRelaEN.ColNum = objRow[convViewRegionRela.ColNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.ColNum].ToString().Trim()); //列数
objvViewRegionRelaEN.ContainerTypeName = objRow[convViewRegionRela.ContainerTypeName] == DBNull.Value ? null : objRow[convViewRegionRela.ContainerTypeName].ToString().Trim(); //容器类型名
objvViewRegionRelaEN.PageDispModeName = objRow[convViewRegionRela.PageDispModeName] == DBNull.Value ? null : objRow[convViewRegionRela.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvViewRegionRelaEN.ViewId = objRow[convViewRegionRela.ViewId] == DBNull.Value ? null : objRow[convViewRegionRela.ViewId].ToString().Trim(); //界面Id
objvViewRegionRelaEN.ViewName = objRow[convViewRegionRela.ViewName].ToString().Trim(); //界面名称
objvViewRegionRelaEN.ApplicationTypeId = objRow[convViewRegionRela.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewRegionRelaEN.ViewCnName = objRow[convViewRegionRela.ViewCnName] == DBNull.Value ? null : objRow[convViewRegionRela.ViewCnName].ToString().Trim(); //视图中文名
objvViewRegionRelaEN.FileName = objRow[convViewRegionRela.FileName] == DBNull.Value ? null : objRow[convViewRegionRela.FileName].ToString().Trim(); //文件名
objvViewRegionRelaEN.ContainerTypeId = objRow[convViewRegionRela.ContainerTypeId] == DBNull.Value ? null : objRow[convViewRegionRela.ContainerTypeId].ToString().Trim(); //容器类型Id
objvViewRegionRelaEN.PageDispModeId = objRow[convViewRegionRela.PageDispModeId] == DBNull.Value ? null : objRow[convViewRegionRela.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvViewRegionRelaEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convViewRegionRela.InUse].ToString().Trim()); //是否在用
objvViewRegionRelaEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[convViewRegionRela.IsDisp].ToString().Trim()); //是否显示
objvViewRegionRelaEN.PrjId = objRow[convViewRegionRela.PrjId].ToString().Trim(); //工程ID
objvViewRegionRelaEN.UpdUser = objRow[convViewRegionRela.UpdUser] == DBNull.Value ? null : objRow[convViewRegionRela.UpdUser].ToString().Trim(); //修改者
objvViewRegionRelaEN.UpdDate = objRow[convViewRegionRela.UpdDate] == DBNull.Value ? null : objRow[convViewRegionRela.UpdDate].ToString().Trim(); //修改日期
objvViewRegionRelaEN.Memo = objRow[convViewRegionRela.Memo] == DBNull.Value ? null : objRow[convViewRegionRela.Memo].ToString().Trim(); //说明
objvViewRegionRelaEN.ClsName = objRow[convViewRegionRela.ClsName] == DBNull.Value ? null : objRow[convViewRegionRela.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewRegionRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewRegionRelaEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewRegionRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvViewRegionRelaEN> arrObjLst = new List<clsvViewRegionRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewRegionRelaEN objvViewRegionRelaEN = new clsvViewRegionRelaEN();
try
{
objvViewRegionRelaEN.mId = Int32.Parse(objRow[convViewRegionRela.mId].ToString().Trim()); //mId
objvViewRegionRelaEN.RegionId = objRow[convViewRegionRela.RegionId].ToString().Trim(); //区域Id
objvViewRegionRelaEN.RegionName = objRow[convViewRegionRela.RegionName].ToString().Trim(); //区域名称
objvViewRegionRelaEN.RegionTypeId = objRow[convViewRegionRela.RegionTypeId].ToString().Trim(); //区域类型Id
objvViewRegionRelaEN.RegionTypeName = objRow[convViewRegionRela.RegionTypeName].ToString().Trim(); //区域类型名称
objvViewRegionRelaEN.RegionTypeSimName = objRow[convViewRegionRela.RegionTypeSimName] == DBNull.Value ? null : objRow[convViewRegionRela.RegionTypeSimName].ToString().Trim(); //区域类型简名
objvViewRegionRelaEN.RegionTypeOrderNum = objRow[convViewRegionRela.RegionTypeOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.RegionTypeOrderNum].ToString().Trim()); //区域类型序号
objvViewRegionRelaEN.Height = objRow[convViewRegionRela.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.Height].ToString().Trim()); //高度
objvViewRegionRelaEN.Width = objRow[convViewRegionRela.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.Width].ToString().Trim()); //宽
objvViewRegionRelaEN.ColNum = objRow[convViewRegionRela.ColNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.ColNum].ToString().Trim()); //列数
objvViewRegionRelaEN.ContainerTypeName = objRow[convViewRegionRela.ContainerTypeName] == DBNull.Value ? null : objRow[convViewRegionRela.ContainerTypeName].ToString().Trim(); //容器类型名
objvViewRegionRelaEN.PageDispModeName = objRow[convViewRegionRela.PageDispModeName] == DBNull.Value ? null : objRow[convViewRegionRela.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvViewRegionRelaEN.ViewId = objRow[convViewRegionRela.ViewId] == DBNull.Value ? null : objRow[convViewRegionRela.ViewId].ToString().Trim(); //界面Id
objvViewRegionRelaEN.ViewName = objRow[convViewRegionRela.ViewName].ToString().Trim(); //界面名称
objvViewRegionRelaEN.ApplicationTypeId = objRow[convViewRegionRela.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewRegionRelaEN.ViewCnName = objRow[convViewRegionRela.ViewCnName] == DBNull.Value ? null : objRow[convViewRegionRela.ViewCnName].ToString().Trim(); //视图中文名
objvViewRegionRelaEN.FileName = objRow[convViewRegionRela.FileName] == DBNull.Value ? null : objRow[convViewRegionRela.FileName].ToString().Trim(); //文件名
objvViewRegionRelaEN.ContainerTypeId = objRow[convViewRegionRela.ContainerTypeId] == DBNull.Value ? null : objRow[convViewRegionRela.ContainerTypeId].ToString().Trim(); //容器类型Id
objvViewRegionRelaEN.PageDispModeId = objRow[convViewRegionRela.PageDispModeId] == DBNull.Value ? null : objRow[convViewRegionRela.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvViewRegionRelaEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convViewRegionRela.InUse].ToString().Trim()); //是否在用
objvViewRegionRelaEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[convViewRegionRela.IsDisp].ToString().Trim()); //是否显示
objvViewRegionRelaEN.PrjId = objRow[convViewRegionRela.PrjId].ToString().Trim(); //工程ID
objvViewRegionRelaEN.UpdUser = objRow[convViewRegionRela.UpdUser] == DBNull.Value ? null : objRow[convViewRegionRela.UpdUser].ToString().Trim(); //修改者
objvViewRegionRelaEN.UpdDate = objRow[convViewRegionRela.UpdDate] == DBNull.Value ? null : objRow[convViewRegionRela.UpdDate].ToString().Trim(); //修改日期
objvViewRegionRelaEN.Memo = objRow[convViewRegionRela.Memo] == DBNull.Value ? null : objRow[convViewRegionRela.Memo].ToString().Trim(); //说明
objvViewRegionRelaEN.ClsName = objRow[convViewRegionRela.ClsName] == DBNull.Value ? null : objRow[convViewRegionRela.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewRegionRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewRegionRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvViewRegionRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 return GetObjLstByPager(objPagerPara.pageIndex, objPagerPara.pageSize, objPagerPara.whereCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvViewRegionRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvViewRegionRelaEN> arrObjLst = new List<clsvViewRegionRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewRegionRelaEN objvViewRegionRelaEN = new clsvViewRegionRelaEN();
try
{
objvViewRegionRelaEN.mId = Int32.Parse(objRow[convViewRegionRela.mId].ToString().Trim()); //mId
objvViewRegionRelaEN.RegionId = objRow[convViewRegionRela.RegionId].ToString().Trim(); //区域Id
objvViewRegionRelaEN.RegionName = objRow[convViewRegionRela.RegionName].ToString().Trim(); //区域名称
objvViewRegionRelaEN.RegionTypeId = objRow[convViewRegionRela.RegionTypeId].ToString().Trim(); //区域类型Id
objvViewRegionRelaEN.RegionTypeName = objRow[convViewRegionRela.RegionTypeName].ToString().Trim(); //区域类型名称
objvViewRegionRelaEN.RegionTypeSimName = objRow[convViewRegionRela.RegionTypeSimName] == DBNull.Value ? null : objRow[convViewRegionRela.RegionTypeSimName].ToString().Trim(); //区域类型简名
objvViewRegionRelaEN.RegionTypeOrderNum = objRow[convViewRegionRela.RegionTypeOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.RegionTypeOrderNum].ToString().Trim()); //区域类型序号
objvViewRegionRelaEN.Height = objRow[convViewRegionRela.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.Height].ToString().Trim()); //高度
objvViewRegionRelaEN.Width = objRow[convViewRegionRela.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.Width].ToString().Trim()); //宽
objvViewRegionRelaEN.ColNum = objRow[convViewRegionRela.ColNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.ColNum].ToString().Trim()); //列数
objvViewRegionRelaEN.ContainerTypeName = objRow[convViewRegionRela.ContainerTypeName] == DBNull.Value ? null : objRow[convViewRegionRela.ContainerTypeName].ToString().Trim(); //容器类型名
objvViewRegionRelaEN.PageDispModeName = objRow[convViewRegionRela.PageDispModeName] == DBNull.Value ? null : objRow[convViewRegionRela.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvViewRegionRelaEN.ViewId = objRow[convViewRegionRela.ViewId] == DBNull.Value ? null : objRow[convViewRegionRela.ViewId].ToString().Trim(); //界面Id
objvViewRegionRelaEN.ViewName = objRow[convViewRegionRela.ViewName].ToString().Trim(); //界面名称
objvViewRegionRelaEN.ApplicationTypeId = objRow[convViewRegionRela.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewRegionRelaEN.ViewCnName = objRow[convViewRegionRela.ViewCnName] == DBNull.Value ? null : objRow[convViewRegionRela.ViewCnName].ToString().Trim(); //视图中文名
objvViewRegionRelaEN.FileName = objRow[convViewRegionRela.FileName] == DBNull.Value ? null : objRow[convViewRegionRela.FileName].ToString().Trim(); //文件名
objvViewRegionRelaEN.ContainerTypeId = objRow[convViewRegionRela.ContainerTypeId] == DBNull.Value ? null : objRow[convViewRegionRela.ContainerTypeId].ToString().Trim(); //容器类型Id
objvViewRegionRelaEN.PageDispModeId = objRow[convViewRegionRela.PageDispModeId] == DBNull.Value ? null : objRow[convViewRegionRela.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvViewRegionRelaEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convViewRegionRela.InUse].ToString().Trim()); //是否在用
objvViewRegionRelaEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[convViewRegionRela.IsDisp].ToString().Trim()); //是否显示
objvViewRegionRelaEN.PrjId = objRow[convViewRegionRela.PrjId].ToString().Trim(); //工程ID
objvViewRegionRelaEN.UpdUser = objRow[convViewRegionRela.UpdUser] == DBNull.Value ? null : objRow[convViewRegionRela.UpdUser].ToString().Trim(); //修改者
objvViewRegionRelaEN.UpdDate = objRow[convViewRegionRela.UpdDate] == DBNull.Value ? null : objRow[convViewRegionRela.UpdDate].ToString().Trim(); //修改日期
objvViewRegionRelaEN.Memo = objRow[convViewRegionRela.Memo] == DBNull.Value ? null : objRow[convViewRegionRela.Memo].ToString().Trim(); //说明
objvViewRegionRelaEN.ClsName = objRow[convViewRegionRela.ClsName] == DBNull.Value ? null : objRow[convViewRegionRela.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewRegionRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewRegionRelaEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewRegionRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvViewRegionRelaEN> arrObjLst = new List<clsvViewRegionRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewRegionRelaEN objvViewRegionRelaEN = new clsvViewRegionRelaEN();
try
{
objvViewRegionRelaEN.mId = Int32.Parse(objRow[convViewRegionRela.mId].ToString().Trim()); //mId
objvViewRegionRelaEN.RegionId = objRow[convViewRegionRela.RegionId].ToString().Trim(); //区域Id
objvViewRegionRelaEN.RegionName = objRow[convViewRegionRela.RegionName].ToString().Trim(); //区域名称
objvViewRegionRelaEN.RegionTypeId = objRow[convViewRegionRela.RegionTypeId].ToString().Trim(); //区域类型Id
objvViewRegionRelaEN.RegionTypeName = objRow[convViewRegionRela.RegionTypeName].ToString().Trim(); //区域类型名称
objvViewRegionRelaEN.RegionTypeSimName = objRow[convViewRegionRela.RegionTypeSimName] == DBNull.Value ? null : objRow[convViewRegionRela.RegionTypeSimName].ToString().Trim(); //区域类型简名
objvViewRegionRelaEN.RegionTypeOrderNum = objRow[convViewRegionRela.RegionTypeOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.RegionTypeOrderNum].ToString().Trim()); //区域类型序号
objvViewRegionRelaEN.Height = objRow[convViewRegionRela.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.Height].ToString().Trim()); //高度
objvViewRegionRelaEN.Width = objRow[convViewRegionRela.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.Width].ToString().Trim()); //宽
objvViewRegionRelaEN.ColNum = objRow[convViewRegionRela.ColNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.ColNum].ToString().Trim()); //列数
objvViewRegionRelaEN.ContainerTypeName = objRow[convViewRegionRela.ContainerTypeName] == DBNull.Value ? null : objRow[convViewRegionRela.ContainerTypeName].ToString().Trim(); //容器类型名
objvViewRegionRelaEN.PageDispModeName = objRow[convViewRegionRela.PageDispModeName] == DBNull.Value ? null : objRow[convViewRegionRela.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvViewRegionRelaEN.ViewId = objRow[convViewRegionRela.ViewId] == DBNull.Value ? null : objRow[convViewRegionRela.ViewId].ToString().Trim(); //界面Id
objvViewRegionRelaEN.ViewName = objRow[convViewRegionRela.ViewName].ToString().Trim(); //界面名称
objvViewRegionRelaEN.ApplicationTypeId = objRow[convViewRegionRela.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewRegionRelaEN.ViewCnName = objRow[convViewRegionRela.ViewCnName] == DBNull.Value ? null : objRow[convViewRegionRela.ViewCnName].ToString().Trim(); //视图中文名
objvViewRegionRelaEN.FileName = objRow[convViewRegionRela.FileName] == DBNull.Value ? null : objRow[convViewRegionRela.FileName].ToString().Trim(); //文件名
objvViewRegionRelaEN.ContainerTypeId = objRow[convViewRegionRela.ContainerTypeId] == DBNull.Value ? null : objRow[convViewRegionRela.ContainerTypeId].ToString().Trim(); //容器类型Id
objvViewRegionRelaEN.PageDispModeId = objRow[convViewRegionRela.PageDispModeId] == DBNull.Value ? null : objRow[convViewRegionRela.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvViewRegionRelaEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convViewRegionRela.InUse].ToString().Trim()); //是否在用
objvViewRegionRelaEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[convViewRegionRela.IsDisp].ToString().Trim()); //是否显示
objvViewRegionRelaEN.PrjId = objRow[convViewRegionRela.PrjId].ToString().Trim(); //工程ID
objvViewRegionRelaEN.UpdUser = objRow[convViewRegionRela.UpdUser] == DBNull.Value ? null : objRow[convViewRegionRela.UpdUser].ToString().Trim(); //修改者
objvViewRegionRelaEN.UpdDate = objRow[convViewRegionRela.UpdDate] == DBNull.Value ? null : objRow[convViewRegionRela.UpdDate].ToString().Trim(); //修改日期
objvViewRegionRelaEN.Memo = objRow[convViewRegionRela.Memo] == DBNull.Value ? null : objRow[convViewRegionRela.Memo].ToString().Trim(); //说明
objvViewRegionRelaEN.ClsName = objRow[convViewRegionRela.ClsName] == DBNull.Value ? null : objRow[convViewRegionRela.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewRegionRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewRegionRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewRegionRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvViewRegionRelaEN> arrObjLst = new List<clsvViewRegionRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewRegionRelaEN objvViewRegionRelaEN = new clsvViewRegionRelaEN();
try
{
objvViewRegionRelaEN.mId = Int32.Parse(objRow[convViewRegionRela.mId].ToString().Trim()); //mId
objvViewRegionRelaEN.RegionId = objRow[convViewRegionRela.RegionId].ToString().Trim(); //区域Id
objvViewRegionRelaEN.RegionName = objRow[convViewRegionRela.RegionName].ToString().Trim(); //区域名称
objvViewRegionRelaEN.RegionTypeId = objRow[convViewRegionRela.RegionTypeId].ToString().Trim(); //区域类型Id
objvViewRegionRelaEN.RegionTypeName = objRow[convViewRegionRela.RegionTypeName].ToString().Trim(); //区域类型名称
objvViewRegionRelaEN.RegionTypeSimName = objRow[convViewRegionRela.RegionTypeSimName] == DBNull.Value ? null : objRow[convViewRegionRela.RegionTypeSimName].ToString().Trim(); //区域类型简名
objvViewRegionRelaEN.RegionTypeOrderNum = objRow[convViewRegionRela.RegionTypeOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.RegionTypeOrderNum].ToString().Trim()); //区域类型序号
objvViewRegionRelaEN.Height = objRow[convViewRegionRela.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.Height].ToString().Trim()); //高度
objvViewRegionRelaEN.Width = objRow[convViewRegionRela.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.Width].ToString().Trim()); //宽
objvViewRegionRelaEN.ColNum = objRow[convViewRegionRela.ColNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.ColNum].ToString().Trim()); //列数
objvViewRegionRelaEN.ContainerTypeName = objRow[convViewRegionRela.ContainerTypeName] == DBNull.Value ? null : objRow[convViewRegionRela.ContainerTypeName].ToString().Trim(); //容器类型名
objvViewRegionRelaEN.PageDispModeName = objRow[convViewRegionRela.PageDispModeName] == DBNull.Value ? null : objRow[convViewRegionRela.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvViewRegionRelaEN.ViewId = objRow[convViewRegionRela.ViewId] == DBNull.Value ? null : objRow[convViewRegionRela.ViewId].ToString().Trim(); //界面Id
objvViewRegionRelaEN.ViewName = objRow[convViewRegionRela.ViewName].ToString().Trim(); //界面名称
objvViewRegionRelaEN.ApplicationTypeId = objRow[convViewRegionRela.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewRegionRelaEN.ViewCnName = objRow[convViewRegionRela.ViewCnName] == DBNull.Value ? null : objRow[convViewRegionRela.ViewCnName].ToString().Trim(); //视图中文名
objvViewRegionRelaEN.FileName = objRow[convViewRegionRela.FileName] == DBNull.Value ? null : objRow[convViewRegionRela.FileName].ToString().Trim(); //文件名
objvViewRegionRelaEN.ContainerTypeId = objRow[convViewRegionRela.ContainerTypeId] == DBNull.Value ? null : objRow[convViewRegionRela.ContainerTypeId].ToString().Trim(); //容器类型Id
objvViewRegionRelaEN.PageDispModeId = objRow[convViewRegionRela.PageDispModeId] == DBNull.Value ? null : objRow[convViewRegionRela.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvViewRegionRelaEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convViewRegionRela.InUse].ToString().Trim()); //是否在用
objvViewRegionRelaEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[convViewRegionRela.IsDisp].ToString().Trim()); //是否显示
objvViewRegionRelaEN.PrjId = objRow[convViewRegionRela.PrjId].ToString().Trim(); //工程ID
objvViewRegionRelaEN.UpdUser = objRow[convViewRegionRela.UpdUser] == DBNull.Value ? null : objRow[convViewRegionRela.UpdUser].ToString().Trim(); //修改者
objvViewRegionRelaEN.UpdDate = objRow[convViewRegionRela.UpdDate] == DBNull.Value ? null : objRow[convViewRegionRela.UpdDate].ToString().Trim(); //修改日期
objvViewRegionRelaEN.Memo = objRow[convViewRegionRela.Memo] == DBNull.Value ? null : objRow[convViewRegionRela.Memo].ToString().Trim(); //说明
objvViewRegionRelaEN.ClsName = objRow[convViewRegionRela.ClsName] == DBNull.Value ? null : objRow[convViewRegionRela.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewRegionRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewRegionRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvViewRegionRela(ref clsvViewRegionRelaEN objvViewRegionRelaEN)
{
bool bolResult = vViewRegionRelaDA.GetvViewRegionRela(ref objvViewRegionRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvViewRegionRelaEN GetObjBymId(long lngmId)
{
clsvViewRegionRelaEN objvViewRegionRelaEN = vViewRegionRelaDA.GetObjBymId(lngmId);
return objvViewRegionRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvViewRegionRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvViewRegionRelaEN objvViewRegionRelaEN = vViewRegionRelaDA.GetFirstObj(strWhereCond);
 return objvViewRegionRelaEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000022)获取当前表满足条件的第一条记录数据出错!(strWhereCond = {1}),{2}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 把DataRow转换成相关实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecValueObjByDataRow_S)
 /// </summary>
 /// <param name = "objRow">给定的DataRow</param>
 /// <returns>返回相关的实体对象</returns>
public static clsvViewRegionRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvViewRegionRelaEN objvViewRegionRelaEN = vViewRegionRelaDA.GetObjByDataRow(objRow);
 return objvViewRegionRelaEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000051)根据DataRow记录获取对象出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}
 /// <summary>
 /// 把DataRowView转换成相关实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecValueObjByDataRow_S)
 /// </summary>
 /// <param name = "objRow">给定的DataRowView</param>
 /// <returns>返回相关的实体对象</returns>
public static clsvViewRegionRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvViewRegionRelaEN objvViewRegionRelaEN = vViewRegionRelaDA.GetObjByDataRow(objRow);
 return objvViewRegionRelaEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000052)通过DataRowView记录对象出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 根据关键字获取相关对象, 从给定的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyFromList)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "lstvViewRegionRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvViewRegionRelaEN GetObjBymIdFromList(long lngmId, List<clsvViewRegionRelaEN> lstvViewRegionRelaObjLst)
{
foreach (clsvViewRegionRelaEN objvViewRegionRelaEN in lstvViewRegionRelaObjLst)
{
if (objvViewRegionRelaEN.mId == lngmId)
{
return objvViewRegionRelaEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static long GetFirstID_S(string strWhereCond) 
{
 long lngmId;
 try
 {
 lngmId = new clsvViewRegionRelaDA().GetFirstID(strWhereCond);
 return lngmId;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000023)获取First关键字出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 获取一个关键字值


 #region 获取多个关键字值列表

 /// <summary>
 /// 获取当前表满足条件的关键字值列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetPrimaryKeyID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件的关键字列表值</returns>
public static List<string> GetPrimaryKeyID_S(string strWhereCond) 
{
 List<string> arrList;
 try
 {
 arrList = vViewRegionRelaDA.GetID(strWhereCond);
 return arrList;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000026)获取关键字列表出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 获取多个关键字值列表


 #region 判断记录是否存在

 /// <summary>
 /// 功能:判断是否存在某一条件的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistRecord)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>
public static bool IsExistRecord(string strWhereCond)
{
//检测记录是否存在
bool bolIsExist = vViewRegionRelaDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngmId)
{
//检测记录是否存在
bool bolIsExist = vViewRegionRelaDA.IsExist(lngmId);
return bolIsExist;
}

 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistTable)
 /// </summary>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable() 
{
 bool bolIsExist;
 try
 {
 bolIsExist = clsvViewRegionRelaDA.IsExistTable();
 return bolIsExist;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000028)检查是否存在当前表(IsExistTable)出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}
 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistTable)
 /// </summary>
 /// <param name = "strTabName">给定表</param>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable(string strTabName) 
{
 bool bolIsExist;
 try
 {
 bolIsExist = vViewRegionRelaDA.IsExistTable(strTabName);
 return bolIsExist;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000029)检查是否存在指定表(IsExistTable)出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 判断记录是否存在


 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CopyObj_S)
 /// </summary>
 /// <param name = "objvViewRegionRelaENS">源对象</param>
 /// <param name = "objvViewRegionRelaENT">目标对象</param>
 public static void CopyTo(clsvViewRegionRelaEN objvViewRegionRelaENS, clsvViewRegionRelaEN objvViewRegionRelaENT)
{
try
{
objvViewRegionRelaENT.mId = objvViewRegionRelaENS.mId; //mId
objvViewRegionRelaENT.RegionId = objvViewRegionRelaENS.RegionId; //区域Id
objvViewRegionRelaENT.RegionName = objvViewRegionRelaENS.RegionName; //区域名称
objvViewRegionRelaENT.RegionTypeId = objvViewRegionRelaENS.RegionTypeId; //区域类型Id
objvViewRegionRelaENT.RegionTypeName = objvViewRegionRelaENS.RegionTypeName; //区域类型名称
objvViewRegionRelaENT.RegionTypeSimName = objvViewRegionRelaENS.RegionTypeSimName; //区域类型简名
objvViewRegionRelaENT.RegionTypeOrderNum = objvViewRegionRelaENS.RegionTypeOrderNum; //区域类型序号
objvViewRegionRelaENT.Height = objvViewRegionRelaENS.Height; //高度
objvViewRegionRelaENT.Width = objvViewRegionRelaENS.Width; //宽
objvViewRegionRelaENT.ColNum = objvViewRegionRelaENS.ColNum; //列数
objvViewRegionRelaENT.ContainerTypeName = objvViewRegionRelaENS.ContainerTypeName; //容器类型名
objvViewRegionRelaENT.PageDispModeName = objvViewRegionRelaENS.PageDispModeName; //页面显示模式名称
objvViewRegionRelaENT.ViewId = objvViewRegionRelaENS.ViewId; //界面Id
objvViewRegionRelaENT.ViewName = objvViewRegionRelaENS.ViewName; //界面名称
objvViewRegionRelaENT.ApplicationTypeId = objvViewRegionRelaENS.ApplicationTypeId; //应用程序类型ID
objvViewRegionRelaENT.ViewCnName = objvViewRegionRelaENS.ViewCnName; //视图中文名
objvViewRegionRelaENT.FileName = objvViewRegionRelaENS.FileName; //文件名
objvViewRegionRelaENT.ContainerTypeId = objvViewRegionRelaENS.ContainerTypeId; //容器类型Id
objvViewRegionRelaENT.PageDispModeId = objvViewRegionRelaENS.PageDispModeId; //页面显示模式Id
objvViewRegionRelaENT.InUse = objvViewRegionRelaENS.InUse; //是否在用
objvViewRegionRelaENT.IsDisp = objvViewRegionRelaENS.IsDisp; //是否显示
objvViewRegionRelaENT.PrjId = objvViewRegionRelaENS.PrjId; //工程ID
objvViewRegionRelaENT.UpdUser = objvViewRegionRelaENS.UpdUser; //修改者
objvViewRegionRelaENT.UpdDate = objvViewRegionRelaENS.UpdDate; //修改日期
objvViewRegionRelaENT.Memo = objvViewRegionRelaENS.Memo; //说明
objvViewRegionRelaENT.ClsName = objvViewRegionRelaENS.ClsName; //类名
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000045)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 设置修改标志,即根据字段修改标志字符串获取哪一个字段已经被修改
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SetUpdFlag_S)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsvViewRegionRelaEN objvViewRegionRelaEN)
{
try
{
objvViewRegionRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvViewRegionRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convViewRegionRela.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRegionRelaEN.mId = objvViewRegionRelaEN.mId; //mId
}
if (arrFldSet.Contains(convViewRegionRela.RegionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRegionRelaEN.RegionId = objvViewRegionRelaEN.RegionId; //区域Id
}
if (arrFldSet.Contains(convViewRegionRela.RegionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRegionRelaEN.RegionName = objvViewRegionRelaEN.RegionName; //区域名称
}
if (arrFldSet.Contains(convViewRegionRela.RegionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRegionRelaEN.RegionTypeId = objvViewRegionRelaEN.RegionTypeId; //区域类型Id
}
if (arrFldSet.Contains(convViewRegionRela.RegionTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRegionRelaEN.RegionTypeName = objvViewRegionRelaEN.RegionTypeName; //区域类型名称
}
if (arrFldSet.Contains(convViewRegionRela.RegionTypeSimName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRegionRelaEN.RegionTypeSimName = objvViewRegionRelaEN.RegionTypeSimName == "[null]" ? null :  objvViewRegionRelaEN.RegionTypeSimName; //区域类型简名
}
if (arrFldSet.Contains(convViewRegionRela.RegionTypeOrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRegionRelaEN.RegionTypeOrderNum = objvViewRegionRelaEN.RegionTypeOrderNum; //区域类型序号
}
if (arrFldSet.Contains(convViewRegionRela.Height, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRegionRelaEN.Height = objvViewRegionRelaEN.Height; //高度
}
if (arrFldSet.Contains(convViewRegionRela.Width, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRegionRelaEN.Width = objvViewRegionRelaEN.Width; //宽
}
if (arrFldSet.Contains(convViewRegionRela.ColNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRegionRelaEN.ColNum = objvViewRegionRelaEN.ColNum; //列数
}
if (arrFldSet.Contains(convViewRegionRela.ContainerTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRegionRelaEN.ContainerTypeName = objvViewRegionRelaEN.ContainerTypeName == "[null]" ? null :  objvViewRegionRelaEN.ContainerTypeName; //容器类型名
}
if (arrFldSet.Contains(convViewRegionRela.PageDispModeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRegionRelaEN.PageDispModeName = objvViewRegionRelaEN.PageDispModeName == "[null]" ? null :  objvViewRegionRelaEN.PageDispModeName; //页面显示模式名称
}
if (arrFldSet.Contains(convViewRegionRela.ViewId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRegionRelaEN.ViewId = objvViewRegionRelaEN.ViewId == "[null]" ? null :  objvViewRegionRelaEN.ViewId; //界面Id
}
if (arrFldSet.Contains(convViewRegionRela.ViewName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRegionRelaEN.ViewName = objvViewRegionRelaEN.ViewName; //界面名称
}
if (arrFldSet.Contains(convViewRegionRela.ApplicationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRegionRelaEN.ApplicationTypeId = objvViewRegionRelaEN.ApplicationTypeId; //应用程序类型ID
}
if (arrFldSet.Contains(convViewRegionRela.ViewCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRegionRelaEN.ViewCnName = objvViewRegionRelaEN.ViewCnName == "[null]" ? null :  objvViewRegionRelaEN.ViewCnName; //视图中文名
}
if (arrFldSet.Contains(convViewRegionRela.FileName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRegionRelaEN.FileName = objvViewRegionRelaEN.FileName == "[null]" ? null :  objvViewRegionRelaEN.FileName; //文件名
}
if (arrFldSet.Contains(convViewRegionRela.ContainerTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRegionRelaEN.ContainerTypeId = objvViewRegionRelaEN.ContainerTypeId == "[null]" ? null :  objvViewRegionRelaEN.ContainerTypeId; //容器类型Id
}
if (arrFldSet.Contains(convViewRegionRela.PageDispModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRegionRelaEN.PageDispModeId = objvViewRegionRelaEN.PageDispModeId == "[null]" ? null :  objvViewRegionRelaEN.PageDispModeId; //页面显示模式Id
}
if (arrFldSet.Contains(convViewRegionRela.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRegionRelaEN.InUse = objvViewRegionRelaEN.InUse; //是否在用
}
if (arrFldSet.Contains(convViewRegionRela.IsDisp, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRegionRelaEN.IsDisp = objvViewRegionRelaEN.IsDisp; //是否显示
}
if (arrFldSet.Contains(convViewRegionRela.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRegionRelaEN.PrjId = objvViewRegionRelaEN.PrjId; //工程ID
}
if (arrFldSet.Contains(convViewRegionRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRegionRelaEN.UpdUser = objvViewRegionRelaEN.UpdUser == "[null]" ? null :  objvViewRegionRelaEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convViewRegionRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRegionRelaEN.UpdDate = objvViewRegionRelaEN.UpdDate == "[null]" ? null :  objvViewRegionRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convViewRegionRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRegionRelaEN.Memo = objvViewRegionRelaEN.Memo == "[null]" ? null :  objvViewRegionRelaEN.Memo; //说明
}
if (arrFldSet.Contains(convViewRegionRela.ClsName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRegionRelaEN.ClsName = objvViewRegionRelaEN.ClsName == "[null]" ? null :  objvViewRegionRelaEN.ClsName; //类名
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:001)设置表的修改标志出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 处理从Web端传来的[null]的字段值,在WebApi端设置成null
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AccessFldValueNull)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvViewRegionRelaEN objvViewRegionRelaEN)
{
try
{
if (objvViewRegionRelaEN.RegionTypeSimName == "[null]") objvViewRegionRelaEN.RegionTypeSimName = null; //区域类型简名
if (objvViewRegionRelaEN.ContainerTypeName == "[null]") objvViewRegionRelaEN.ContainerTypeName = null; //容器类型名
if (objvViewRegionRelaEN.PageDispModeName == "[null]") objvViewRegionRelaEN.PageDispModeName = null; //页面显示模式名称
if (objvViewRegionRelaEN.ViewId == "[null]") objvViewRegionRelaEN.ViewId = null; //界面Id
if (objvViewRegionRelaEN.ViewCnName == "[null]") objvViewRegionRelaEN.ViewCnName = null; //视图中文名
if (objvViewRegionRelaEN.FileName == "[null]") objvViewRegionRelaEN.FileName = null; //文件名
if (objvViewRegionRelaEN.ContainerTypeId == "[null]") objvViewRegionRelaEN.ContainerTypeId = null; //容器类型Id
if (objvViewRegionRelaEN.PageDispModeId == "[null]") objvViewRegionRelaEN.PageDispModeId = null; //页面显示模式Id
if (objvViewRegionRelaEN.UpdUser == "[null]") objvViewRegionRelaEN.UpdUser = null; //修改者
if (objvViewRegionRelaEN.UpdDate == "[null]") objvViewRegionRelaEN.UpdDate = null; //修改日期
if (objvViewRegionRelaEN.Memo == "[null]") objvViewRegionRelaEN.Memo = null; //说明
if (objvViewRegionRelaEN.ClsName == "[null]") objvViewRegionRelaEN.ClsName = null; //类名
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:002)处理从Web端传来的[null]的字段值出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 克隆复制对象


 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsvViewRegionRelaEN objvViewRegionRelaEN)
{
 vViewRegionRelaDA.CheckProperty4Condition(objvViewRegionRelaEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框


 #endregion 绑定下拉框


 #region 缓存操作

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_InitListCache)
 /// </summary>
public static void InitListCache()
{
//检查缓存刷新机制
string strMsg;
if (clsViewInfoBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewInfoBL没有刷新缓存机制(clsViewInfoBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsViewRegionRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewRegionRelaBL没有刷新缓存机制(clsViewRegionRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPrjTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjTabBL没有刷新缓存机制(clsPrjTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRegionTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRegionTypeBL没有刷新缓存机制(clsRegionTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsViewRegionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewRegionBL没有刷新缓存机制(clsViewRegionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsApplicationTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsApplicationTypeBL没有刷新缓存机制(clsApplicationTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsInOutTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsInOutTypeBL没有刷新缓存机制(clsInOutTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPageDispModeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPageDispModeBL没有刷新缓存机制(clsPageDispModeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsGCContainerTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsGCContainerTypeBL没有刷新缓存机制(clsGCContainerTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvViewRegionRelaObjLstCache == null)
//{
//arrvViewRegionRelaObjLstCache = vViewRegionRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvViewRegionRelaEN GetObjBymIdCache(long lngmId, string strPrjId)
{

if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确!(In {1})", strPrjId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsvViewRegionRelaEN._CurrTabName, strPrjId);
List<clsvViewRegionRelaEN> arrvViewRegionRelaObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvViewRegionRelaEN> arrvViewRegionRelaObjLst_Sel =
arrvViewRegionRelaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvViewRegionRelaObjLst_Sel.Count() == 0)
{
   clsvViewRegionRelaEN obj = clsvViewRegionRelaBL.GetObjBymId(lngmId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngmId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvViewRegionRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvViewRegionRelaEN> GetAllvViewRegionRelaObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvViewRegionRelaEN> arrvViewRegionRelaObjLstCache = GetObjLstCache(strPrjId); 
return arrvViewRegionRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvViewRegionRelaEN> GetObjLstCache(string strPrjId)
{

if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确!(In {1})", strPrjId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvViewRegionRelaEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsvViewRegionRelaEN> arrvViewRegionRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvViewRegionRelaObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strPrjId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvViewRegionRelaEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
}
else
{
strMsg = string.Format("刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3));
clsSysParaEN.objLog.WriteDebugLog(strMsg);
}
}


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2024-01-26
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId, string strPrjId)
{
if (strInFldName != convViewRegionRela.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convViewRegionRela.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convViewRegionRela.AttributeName));
throw new Exception(strMsg);
}
var objvViewRegionRela = clsvViewRegionRelaBL.GetObjBymIdCache(lngmId, strPrjId);
if (objvViewRegionRela == null) return "";
return objvViewRegionRela[strOutFldName].ToString();
}


 #region 有关JSON操作


 #endregion 有关JSON操作


 #region 表操作常用函数

 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount(string strTabName)
{
int intRecCount = clsvViewRegionRelaDA.GetRecCount(strTabName);
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCond_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond(string strTabName, string strWhereCond)
{
int intRecCount = clsvViewRegionRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvViewRegionRelaDA.GetRecCount();
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCond)
 /// </summary>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond( string strWhereCond)
{
int intRecCount = clsvViewRegionRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvViewRegionRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvViewRegionRelaEN objvViewRegionRelaCond)
{
 string strPrjId = objvViewRegionRelaCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvViewRegionRelaBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvViewRegionRelaEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvViewRegionRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convViewRegionRela.AttributeName)
{
if (objvViewRegionRelaCond.IsUpdated(strFldName) == false) continue;
if (objvViewRegionRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewRegionRelaCond[strFldName].ToString());
}
else
{
if (objvViewRegionRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvViewRegionRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewRegionRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvViewRegionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvViewRegionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvViewRegionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvViewRegionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvViewRegionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvViewRegionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvViewRegionRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvViewRegionRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvViewRegionRelaCond[strFldName]));
}
}
}
return arrObjLstSel.Count();
}

 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValue_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValue(string strTabName, string strFldName, string strWhereCond)
{
 List<string> arrList = clsvViewRegionRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
return arrList;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValue(string strFldName, string strWhereCond)
{
 List<string> arrList = vViewRegionRelaDA.GetFldValue(strFldName, strWhereCond);
return arrList;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValueNoDistinct)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValueNoDistinct(string strFldName, string strWhereCond)
{
 List<string> arrList = vViewRegionRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数


 #region 排序相关函数


 #endregion 排序相关函数
}
}