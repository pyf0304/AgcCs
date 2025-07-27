
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewRegionRelaWApi
 表名:vViewRegionRela(00050574)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/23 23:10:23
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:区域管理(RegionManage)
 框架-层名:WA_访问层(CS)(WA_Access)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Data; 
using System.Data.SqlClient;
using System.Text; 
using System.Web;
using System.Collections; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq; 
using com.taishsoft.common;
using com.taishsoft.comm_db_obj;
using com.taishsoft.dynamiccompiler;
using com.taishsoft.json;
using AGC.Entity;

namespace AGC4WApi
{
/// <summary>
/// 静态类
/// </summary>
public static class  clsvViewRegionRelaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionId">区域Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionRelaEN SetRegionId(this clsvViewRegionRelaEN objvViewRegionRelaEN, string strRegionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionId, convViewRegionRela.RegionId);
clsCheckSql.CheckFieldLen(strRegionId, 10, convViewRegionRela.RegionId);
clsCheckSql.CheckFieldForeignKey(strRegionId, 10, convViewRegionRela.RegionId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionName">区域名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionRelaEN SetRegionName(this clsvViewRegionRelaEN objvViewRegionRelaEN, string strRegionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionName, convViewRegionRela.RegionName);
clsCheckSql.CheckFieldLen(strRegionName, 50, convViewRegionRela.RegionName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionTypeId">区域类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionRelaEN SetRegionTypeId(this clsvViewRegionRelaEN objvViewRegionRelaEN, string strRegionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionTypeId, convViewRegionRela.RegionTypeId);
clsCheckSql.CheckFieldLen(strRegionTypeId, 4, convViewRegionRela.RegionTypeId);
clsCheckSql.CheckFieldForeignKey(strRegionTypeId, 4, convViewRegionRela.RegionTypeId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionTypeName">区域类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionRelaEN SetRegionTypeName(this clsvViewRegionRelaEN objvViewRegionRelaEN, string strRegionTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionTypeName, convViewRegionRela.RegionTypeName);
clsCheckSql.CheckFieldLen(strRegionTypeName, 30, convViewRegionRela.RegionTypeName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionTypeSimName">区域类型简名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionRelaEN SetRegionTypeSimName(this clsvViewRegionRelaEN objvViewRegionRelaEN, string strRegionTypeSimName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRegionTypeSimName, 10, convViewRegionRela.RegionTypeSimName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "intRegionTypeOrderNum">区域类型序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionRelaEN SetRegionTypeOrderNum(this clsvViewRegionRelaEN objvViewRegionRelaEN, int intRegionTypeOrderNum, string strComparisonOp="")
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "intHeight">高度</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionRelaEN SetHeight(this clsvViewRegionRelaEN objvViewRegionRelaEN, int intHeight, string strComparisonOp="")
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "intWidth">宽</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionRelaEN SetWidth(this clsvViewRegionRelaEN objvViewRegionRelaEN, int intWidth, string strComparisonOp="")
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "intColNum">列数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionRelaEN SetColNum(this clsvViewRegionRelaEN objvViewRegionRelaEN, int intColNum, string strComparisonOp="")
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strContainerTypeName">容器类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionRelaEN SetContainerTypeName(this clsvViewRegionRelaEN objvViewRegionRelaEN, string strContainerTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strContainerTypeName, 50, convViewRegionRela.ContainerTypeName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strPageDispModeName">页面显示模式名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionRelaEN SetPageDispModeName(this clsvViewRegionRelaEN objvViewRegionRelaEN, string strPageDispModeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPageDispModeName, 50, convViewRegionRela.PageDispModeName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewId">界面Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionRelaEN SetViewId(this clsvViewRegionRelaEN objvViewRegionRelaEN, string strViewId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewId, 8, convViewRegionRela.ViewId);
clsCheckSql.CheckFieldForeignKey(strViewId, 8, convViewRegionRela.ViewId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewName">界面名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionRelaEN SetViewName(this clsvViewRegionRelaEN objvViewRegionRelaEN, string strViewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewName, convViewRegionRela.ViewName);
clsCheckSql.CheckFieldLen(strViewName, 100, convViewRegionRela.ViewName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "intApplicationTypeId">应用程序类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionRelaEN SetApplicationTypeId(this clsvViewRegionRelaEN objvViewRegionRelaEN, int intApplicationTypeId, string strComparisonOp="")
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewCnName">视图中文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionRelaEN SetViewCnName(this clsvViewRegionRelaEN objvViewRegionRelaEN, string strViewCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewCnName, 100, convViewRegionRela.ViewCnName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strClassName">类名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionRelaEN SetClassName(this clsvViewRegionRelaEN objvViewRegionRelaEN, string strClassName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClassName, 100, convViewRegionRela.ClsName);
objvViewRegionRelaEN.ClsName = strClassName; //类名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRegionRelaEN.dicFldComparisonOp.ContainsKey(convViewRegionRela.ClsName) == false)
{
objvViewRegionRelaEN.dicFldComparisonOp.Add(convViewRegionRela.ClsName, strComparisonOp);
}
else
{
objvViewRegionRelaEN.dicFldComparisonOp[convViewRegionRela.ClsName] = strComparisonOp;
}
}
return objvViewRegionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFileName">文件名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionRelaEN SetFileName(this clsvViewRegionRelaEN objvViewRegionRelaEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileName, 150, convViewRegionRela.FileName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strContainerTypeId">容器类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionRelaEN SetContainerTypeId(this clsvViewRegionRelaEN objvViewRegionRelaEN, string strContainerTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strContainerTypeId, 4, convViewRegionRela.ContainerTypeId);
clsCheckSql.CheckFieldForeignKey(strContainerTypeId, 4, convViewRegionRela.ContainerTypeId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strPageDispModeId">页面显示模式Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionRelaEN SetPageDispModeId(this clsvViewRegionRelaEN objvViewRegionRelaEN, string strPageDispModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPageDispModeId, 2, convViewRegionRela.PageDispModeId);
clsCheckSql.CheckFieldForeignKey(strPageDispModeId, 2, convViewRegionRela.PageDispModeId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsDisp">是否显示</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionRelaEN SetPrjId(this clsvViewRegionRelaEN objvViewRegionRelaEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convViewRegionRela.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convViewRegionRela.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convViewRegionRela.PrjId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionRelaEN SetUpdUser(this clsvViewRegionRelaEN objvViewRegionRelaEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convViewRegionRela.UpdUser);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionRelaEN SetUpdDate(this clsvViewRegionRelaEN objvViewRegionRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convViewRegionRela.UpdDate);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionRelaEN SetMemo(this clsvViewRegionRelaEN objvViewRegionRelaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convViewRegionRela.Memo);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
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
if (objvViewRegionRelaCond.IsUpdated(convViewRegionRela.ClsName) == true)
{
string strComparisonOpClassName = objvViewRegionRelaCond.dicFldComparisonOp[convViewRegionRela.ClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRegionRela.ClsName, objvViewRegionRelaCond.ClsName, strComparisonOpClassName);
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
 return strWhereCond;
}
}
 /// <summary>
 /// v界面区域关系(vViewRegionRela)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvViewRegionRelaWApi
{
private static readonly string mstrApiControllerName = "vViewRegionRelaApi";

 public clsvViewRegionRelaWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvViewRegionRelaEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
clsvViewRegionRelaEN objvViewRegionRelaEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngmId"] = lngmId.ToString(),
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvViewRegionRelaEN = JsonConvert.DeserializeObject<clsvViewRegionRelaEN>(strJson);
return objvViewRegionRelaEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstID)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static long GetFirstID(string strWhereCond)
{
string strAction = "GetFirstID";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var strReturnStr = (string)jobjReturn0["returnStr"];
return long.Parse(strReturnStr);
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsvViewRegionRelaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvViewRegionRelaEN objvViewRegionRelaEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvViewRegionRelaEN = JsonConvert.DeserializeObject<clsvViewRegionRelaEN>(strJson);
return objvViewRegionRelaEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}
//该表没有使用Cache,不需要生成[GetObjByKeyLstCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyCache)

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewRegionRelaEN> GetObjLst(string strWhereCond)
{
 List<clsvViewRegionRelaEN> arrObjLst; 
string strAction = "GetObjLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewRegionRelaEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件对象列表出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst)
 /// </summary>
 /// <param name = "arrMId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewRegionRelaEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvViewRegionRelaEN> arrObjLst; 
string strAction = "GetObjLstByMIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewRegionRelaEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("根据关键字列表获取对象列表出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}
//该表没有使用Cache,不需要生成[GetObjLstByKeyLstsCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLstCache)

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewRegionRelaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvViewRegionRelaEN> arrObjLst; 
string strAction = "GetTopObjLst";
Dictionary<string, string> dictParam = objTopPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuTopPara>(objTopPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewRegionRelaEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("根据条件获取顶部对象列表,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取范围内的对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewRegionRelaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvViewRegionRelaEN> arrObjLst; 
string strAction = "GetObjLstByRange";
Dictionary<string, string> dictParam =  objRangePara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuRangePara>(objRangePara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewRegionRelaEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件分页获取JSON对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
public static List<clsvViewRegionRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvViewRegionRelaEN> arrObjLst; 
string strAction = "GetObjLstByPager";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewRegionRelaEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件分页获取JSON对象列表, 使用缓存
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByPagerCache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
public static List<clsvViewRegionRelaEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvViewRegionRelaEN> arrObjLst; 
string strAction = "GetObjLstByPagerCache";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewRegionRelaEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件判断是否存在记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_IsExistRecord)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistRecord(string strWhereCond)
{
//检测记录是否存在
string strAction = "IsExistRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn0["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_IsExist)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExist(long lngmId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngmId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn0["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相关记录数
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecCountByCond)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int GetRecCountByCond(string strWhereCond)
{
string strAction = "GetRecCountByCond";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn0["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相关记录数
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFldValue)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static List<string> GetFldValue(string strFldName, string strWhereCond)
{
string strAction = "GetFldValue";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strReturnStrLst = (string)jobjReturn0["returnStrLst"];
var arrReturnStrLst = strReturnStrLst.Split(",".ToCharArray());
return arrReturnStrLst.Select(x => x).ToList();
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
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
objvViewRegionRelaENT.ClsName = objvViewRegionRelaENS.ClsName; //类名
objvViewRegionRelaENT.FileName = objvViewRegionRelaENS.FileName; //文件名
objvViewRegionRelaENT.ContainerTypeId = objvViewRegionRelaENS.ContainerTypeId; //容器类型Id
objvViewRegionRelaENT.PageDispModeId = objvViewRegionRelaENS.PageDispModeId; //页面显示模式Id
objvViewRegionRelaENT.InUse = objvViewRegionRelaENS.InUse; //是否在用
objvViewRegionRelaENT.IsDisp = objvViewRegionRelaENS.IsDisp; //是否显示
objvViewRegionRelaENT.PrjId = objvViewRegionRelaENS.PrjId; //工程ID
objvViewRegionRelaENT.UpdUser = objvViewRegionRelaENS.UpdUser; //修改者
objvViewRegionRelaENT.UpdDate = objvViewRegionRelaENS.UpdDate; //修改日期
objvViewRegionRelaENT.Memo = objvViewRegionRelaENS.Memo; //说明
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000001)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

/// <summary>
/// 对象列表 转换为 DataTable数据集合
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ToDataTable)
/// </summary>
/// <param name="arrObj">原对象列表</param>
/// <returns>返回的DataTable</returns>
public static DataTable ToDataTable(List<clsvViewRegionRelaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvViewRegionRelaEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvViewRegionRelaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvViewRegionRelaEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvViewRegionRelaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvViewRegionRelaEN.AttributeName)
{
dataRow[strAttrName] = objInFor[strAttrName];
}
dataTable.Rows.Add(dataRow); //循环添加行到DataTable中
}
}
catch (Exception objExceptoin)
{
throw objExceptoin;
}
result = dataTable;
return result;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strCmPrjId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvViewRegionRelaEN._CurrTabName, strCmPrjId);
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
//该表没有使用Cache,不需要生成[GetObjLstCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
//该表没有使用Cache,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvViewRegionRelaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convViewRegionRela.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convViewRegionRela.RegionId, Type.GetType("System.String"));
objDT.Columns.Add(convViewRegionRela.RegionName, Type.GetType("System.String"));
objDT.Columns.Add(convViewRegionRela.RegionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convViewRegionRela.RegionTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convViewRegionRela.RegionTypeSimName, Type.GetType("System.String"));
objDT.Columns.Add(convViewRegionRela.RegionTypeOrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convViewRegionRela.Height, Type.GetType("System.Int32"));
objDT.Columns.Add(convViewRegionRela.Width, Type.GetType("System.Int32"));
objDT.Columns.Add(convViewRegionRela.ColNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convViewRegionRela.ContainerTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convViewRegionRela.PageDispModeName, Type.GetType("System.String"));
objDT.Columns.Add(convViewRegionRela.ViewId, Type.GetType("System.String"));
objDT.Columns.Add(convViewRegionRela.ViewName, Type.GetType("System.String"));
objDT.Columns.Add(convViewRegionRela.ApplicationTypeId, Type.GetType("System.Int32"));
objDT.Columns.Add(convViewRegionRela.ViewCnName, Type.GetType("System.String"));
objDT.Columns.Add(convViewRegionRela.ClsName, Type.GetType("System.String"));
objDT.Columns.Add(convViewRegionRela.FileName, Type.GetType("System.String"));
objDT.Columns.Add(convViewRegionRela.ContainerTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convViewRegionRela.PageDispModeId, Type.GetType("System.String"));
objDT.Columns.Add(convViewRegionRela.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convViewRegionRela.IsDisp, Type.GetType("System.Boolean"));
objDT.Columns.Add(convViewRegionRela.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convViewRegionRela.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convViewRegionRela.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convViewRegionRela.Memo, Type.GetType("System.String"));
foreach (clsvViewRegionRelaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convViewRegionRela.mId] = objInFor[convViewRegionRela.mId];
objDR[convViewRegionRela.RegionId] = objInFor[convViewRegionRela.RegionId];
objDR[convViewRegionRela.RegionName] = objInFor[convViewRegionRela.RegionName];
objDR[convViewRegionRela.RegionTypeId] = objInFor[convViewRegionRela.RegionTypeId];
objDR[convViewRegionRela.RegionTypeName] = objInFor[convViewRegionRela.RegionTypeName];
objDR[convViewRegionRela.RegionTypeSimName] = objInFor[convViewRegionRela.RegionTypeSimName];
objDR[convViewRegionRela.RegionTypeOrderNum] = objInFor[convViewRegionRela.RegionTypeOrderNum];
objDR[convViewRegionRela.Height] = objInFor[convViewRegionRela.Height];
objDR[convViewRegionRela.Width] = objInFor[convViewRegionRela.Width];
objDR[convViewRegionRela.ColNum] = objInFor[convViewRegionRela.ColNum];
objDR[convViewRegionRela.ContainerTypeName] = objInFor[convViewRegionRela.ContainerTypeName];
objDR[convViewRegionRela.PageDispModeName] = objInFor[convViewRegionRela.PageDispModeName];
objDR[convViewRegionRela.ViewId] = objInFor[convViewRegionRela.ViewId];
objDR[convViewRegionRela.ViewName] = objInFor[convViewRegionRela.ViewName];
objDR[convViewRegionRela.ApplicationTypeId] = objInFor[convViewRegionRela.ApplicationTypeId];
objDR[convViewRegionRela.ViewCnName] = objInFor[convViewRegionRela.ViewCnName];
objDR[convViewRegionRela.ClsName] = objInFor[convViewRegionRela.ClsName];
objDR[convViewRegionRela.FileName] = objInFor[convViewRegionRela.FileName];
objDR[convViewRegionRela.ContainerTypeId] = objInFor[convViewRegionRela.ContainerTypeId];
objDR[convViewRegionRela.PageDispModeId] = objInFor[convViewRegionRela.PageDispModeId];
objDR[convViewRegionRela.InUse] = objInFor[convViewRegionRela.InUse];
objDR[convViewRegionRela.IsDisp] = objInFor[convViewRegionRela.IsDisp];
objDR[convViewRegionRela.PrjId] = objInFor[convViewRegionRela.PrjId];
objDR[convViewRegionRela.UpdUser] = objInFor[convViewRegionRela.UpdUser];
objDR[convViewRegionRela.UpdDate] = objInFor[convViewRegionRela.UpdDate];
objDR[convViewRegionRela.Memo] = objInFor[convViewRegionRela.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}