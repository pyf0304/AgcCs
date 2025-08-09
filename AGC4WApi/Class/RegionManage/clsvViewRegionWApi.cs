
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewRegionWApi
 表名:vViewRegion(00050199)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:07:53
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:区域管理(RegionManage)
 框架-层名:WA_访问层(CS)(WA_Access,0045)
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
public static class  clsvViewRegionWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionId">区域Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionEN SetRegionId(this clsvViewRegionEN objvViewRegionEN, string strRegionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRegionId, 10, convViewRegion.RegionId);
clsCheckSql.CheckFieldForeignKey(strRegionId, 10, convViewRegion.RegionId);
objvViewRegionEN.RegionId = strRegionId; //区域Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRegionEN.dicFldComparisonOp.ContainsKey(convViewRegion.RegionId) == false)
{
objvViewRegionEN.dicFldComparisonOp.Add(convViewRegion.RegionId, strComparisonOp);
}
else
{
objvViewRegionEN.dicFldComparisonOp[convViewRegion.RegionId] = strComparisonOp;
}
}
return objvViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionName">区域名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionEN SetRegionName(this clsvViewRegionEN objvViewRegionEN, string strRegionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionName, convViewRegion.RegionName);
clsCheckSql.CheckFieldLen(strRegionName, 50, convViewRegion.RegionName);
objvViewRegionEN.RegionName = strRegionName; //区域名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRegionEN.dicFldComparisonOp.ContainsKey(convViewRegion.RegionName) == false)
{
objvViewRegionEN.dicFldComparisonOp.Add(convViewRegion.RegionName, strComparisonOp);
}
else
{
objvViewRegionEN.dicFldComparisonOp[convViewRegion.RegionName] = strComparisonOp;
}
}
return objvViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionTypeId">区域类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionEN SetRegionTypeId(this clsvViewRegionEN objvViewRegionEN, string strRegionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionTypeId, convViewRegion.RegionTypeId);
clsCheckSql.CheckFieldLen(strRegionTypeId, 4, convViewRegion.RegionTypeId);
clsCheckSql.CheckFieldForeignKey(strRegionTypeId, 4, convViewRegion.RegionTypeId);
objvViewRegionEN.RegionTypeId = strRegionTypeId; //区域类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRegionEN.dicFldComparisonOp.ContainsKey(convViewRegion.RegionTypeId) == false)
{
objvViewRegionEN.dicFldComparisonOp.Add(convViewRegion.RegionTypeId, strComparisonOp);
}
else
{
objvViewRegionEN.dicFldComparisonOp[convViewRegion.RegionTypeId] = strComparisonOp;
}
}
return objvViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strFileName">文件名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionEN SetFileName(this clsvViewRegionEN objvViewRegionEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileName, 150, convViewRegion.FileName);
objvViewRegionEN.FileName = strFileName; //文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRegionEN.dicFldComparisonOp.ContainsKey(convViewRegion.FileName) == false)
{
objvViewRegionEN.dicFldComparisonOp.Add(convViewRegion.FileName, strComparisonOp);
}
else
{
objvViewRegionEN.dicFldComparisonOp[convViewRegion.FileName] = strComparisonOp;
}
}
return objvViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "intHeight">高度</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionEN SetHeight(this clsvViewRegionEN objvViewRegionEN, int intHeight, string strComparisonOp="")
	{
objvViewRegionEN.Height = intHeight; //高度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRegionEN.dicFldComparisonOp.ContainsKey(convViewRegion.Height) == false)
{
objvViewRegionEN.dicFldComparisonOp.Add(convViewRegion.Height, strComparisonOp);
}
else
{
objvViewRegionEN.dicFldComparisonOp[convViewRegion.Height] = strComparisonOp;
}
}
return objvViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "intWidth">宽</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionEN SetWidth(this clsvViewRegionEN objvViewRegionEN, int intWidth, string strComparisonOp="")
	{
objvViewRegionEN.Width = intWidth; //宽
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRegionEN.dicFldComparisonOp.ContainsKey(convViewRegion.Width) == false)
{
objvViewRegionEN.dicFldComparisonOp.Add(convViewRegion.Width, strComparisonOp);
}
else
{
objvViewRegionEN.dicFldComparisonOp[convViewRegion.Width] = strComparisonOp;
}
}
return objvViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "intColNum">列数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionEN SetColNum(this clsvViewRegionEN objvViewRegionEN, int intColNum, string strComparisonOp="")
	{
objvViewRegionEN.ColNum = intColNum; //列数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRegionEN.dicFldComparisonOp.ContainsKey(convViewRegion.ColNum) == false)
{
objvViewRegionEN.dicFldComparisonOp.Add(convViewRegion.ColNum, strComparisonOp);
}
else
{
objvViewRegionEN.dicFldComparisonOp[convViewRegion.ColNum] = strComparisonOp;
}
}
return objvViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strContainerTypeId">容器类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionEN SetContainerTypeId(this clsvViewRegionEN objvViewRegionEN, string strContainerTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strContainerTypeId, 4, convViewRegion.ContainerTypeId);
clsCheckSql.CheckFieldForeignKey(strContainerTypeId, 4, convViewRegion.ContainerTypeId);
objvViewRegionEN.ContainerTypeId = strContainerTypeId; //容器类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRegionEN.dicFldComparisonOp.ContainsKey(convViewRegion.ContainerTypeId) == false)
{
objvViewRegionEN.dicFldComparisonOp.Add(convViewRegion.ContainerTypeId, strComparisonOp);
}
else
{
objvViewRegionEN.dicFldComparisonOp[convViewRegion.ContainerTypeId] = strComparisonOp;
}
}
return objvViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strPageDispModeId">页面显示模式Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionEN SetPageDispModeId(this clsvViewRegionEN objvViewRegionEN, string strPageDispModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPageDispModeId, 2, convViewRegion.PageDispModeId);
clsCheckSql.CheckFieldForeignKey(strPageDispModeId, 2, convViewRegion.PageDispModeId);
objvViewRegionEN.PageDispModeId = strPageDispModeId; //页面显示模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRegionEN.dicFldComparisonOp.ContainsKey(convViewRegion.PageDispModeId) == false)
{
objvViewRegionEN.dicFldComparisonOp.Add(convViewRegion.PageDispModeId, strComparisonOp);
}
else
{
objvViewRegionEN.dicFldComparisonOp[convViewRegion.PageDispModeId] = strComparisonOp;
}
}
return objvViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strInOutTypeId">INOUT类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionEN SetInOutTypeId(this clsvViewRegionEN objvViewRegionEN, string strInOutTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strInOutTypeId, convViewRegion.InOutTypeId);
clsCheckSql.CheckFieldLen(strInOutTypeId, 2, convViewRegion.InOutTypeId);
clsCheckSql.CheckFieldForeignKey(strInOutTypeId, 2, convViewRegion.InOutTypeId);
objvViewRegionEN.InOutTypeId = strInOutTypeId; //INOUT类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRegionEN.dicFldComparisonOp.ContainsKey(convViewRegion.InOutTypeId) == false)
{
objvViewRegionEN.dicFldComparisonOp.Add(convViewRegion.InOutTypeId, strComparisonOp);
}
else
{
objvViewRegionEN.dicFldComparisonOp[convViewRegion.InOutTypeId] = strComparisonOp;
}
}
return objvViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strInOutTypeENName">INOUT类型英文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionEN SetInOutTypeENName(this clsvViewRegionEN objvViewRegionEN, string strInOutTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strInOutTypeENName, 30, convViewRegion.InOutTypeENName);
objvViewRegionEN.InOutTypeENName = strInOutTypeENName; //INOUT类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRegionEN.dicFldComparisonOp.ContainsKey(convViewRegion.InOutTypeENName) == false)
{
objvViewRegionEN.dicFldComparisonOp.Add(convViewRegion.InOutTypeENName, strComparisonOp);
}
else
{
objvViewRegionEN.dicFldComparisonOp[convViewRegion.InOutTypeENName] = strComparisonOp;
}
}
return objvViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionEN SetTabId(this clsvViewRegionEN objvViewRegionEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, convViewRegion.TabId);
clsCheckSql.CheckFieldLen(strTabId, 8, convViewRegion.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convViewRegion.TabId);
objvViewRegionEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRegionEN.dicFldComparisonOp.ContainsKey(convViewRegion.TabId) == false)
{
objvViewRegionEN.dicFldComparisonOp.Add(convViewRegion.TabId, strComparisonOp);
}
else
{
objvViewRegionEN.dicFldComparisonOp[convViewRegion.TabId] = strComparisonOp;
}
}
return objvViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "intApplicationTypeId">应用程序类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionEN SetApplicationTypeId(this clsvViewRegionEN objvViewRegionEN, int intApplicationTypeId, string strComparisonOp="")
	{
objvViewRegionEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRegionEN.dicFldComparisonOp.ContainsKey(convViewRegion.ApplicationTypeId) == false)
{
objvViewRegionEN.dicFldComparisonOp.Add(convViewRegion.ApplicationTypeId, strComparisonOp);
}
else
{
objvViewRegionEN.dicFldComparisonOp[convViewRegion.ApplicationTypeId] = strComparisonOp;
}
}
return objvViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strKeyId4Test">测试关键字Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionEN SetKeyId4Test(this clsvViewRegionEN objvViewRegionEN, string strKeyId4Test, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKeyId4Test, 50, convViewRegion.KeyId4Test);
objvViewRegionEN.KeyId4Test = strKeyId4Test; //测试关键字Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRegionEN.dicFldComparisonOp.ContainsKey(convViewRegion.KeyId4Test) == false)
{
objvViewRegionEN.dicFldComparisonOp.Add(convViewRegion.KeyId4Test, strComparisonOp);
}
else
{
objvViewRegionEN.dicFldComparisonOp[convViewRegion.KeyId4Test] = strComparisonOp;
}
}
return objvViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionEN SetPrjId(this clsvViewRegionEN objvViewRegionEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convViewRegion.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convViewRegion.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convViewRegion.PrjId);
objvViewRegionEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRegionEN.dicFldComparisonOp.ContainsKey(convViewRegion.PrjId) == false)
{
objvViewRegionEN.dicFldComparisonOp.Add(convViewRegion.PrjId, strComparisonOp);
}
else
{
objvViewRegionEN.dicFldComparisonOp[convViewRegion.PrjId] = strComparisonOp;
}
}
return objvViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionEN SetUpdUser(this clsvViewRegionEN objvViewRegionEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convViewRegion.UpdUser);
objvViewRegionEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRegionEN.dicFldComparisonOp.ContainsKey(convViewRegion.UpdUser) == false)
{
objvViewRegionEN.dicFldComparisonOp.Add(convViewRegion.UpdUser, strComparisonOp);
}
else
{
objvViewRegionEN.dicFldComparisonOp[convViewRegion.UpdUser] = strComparisonOp;
}
}
return objvViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionEN SetUpdDate(this clsvViewRegionEN objvViewRegionEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convViewRegion.UpdDate);
objvViewRegionEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRegionEN.dicFldComparisonOp.ContainsKey(convViewRegion.UpdDate) == false)
{
objvViewRegionEN.dicFldComparisonOp.Add(convViewRegion.UpdDate, strComparisonOp);
}
else
{
objvViewRegionEN.dicFldComparisonOp[convViewRegion.UpdDate] = strComparisonOp;
}
}
return objvViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionEN SetMemo(this clsvViewRegionEN objvViewRegionEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convViewRegion.Memo);
objvViewRegionEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRegionEN.dicFldComparisonOp.ContainsKey(convViewRegion.Memo) == false)
{
objvViewRegionEN.dicFldComparisonOp.Add(convViewRegion.Memo, strComparisonOp);
}
else
{
objvViewRegionEN.dicFldComparisonOp[convViewRegion.Memo] = strComparisonOp;
}
}
return objvViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionTypeSimName">区域类型简名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionEN SetRegionTypeSimName(this clsvViewRegionEN objvViewRegionEN, string strRegionTypeSimName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRegionTypeSimName, 10, convViewRegion.RegionTypeSimName);
objvViewRegionEN.RegionTypeSimName = strRegionTypeSimName; //区域类型简名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRegionEN.dicFldComparisonOp.ContainsKey(convViewRegion.RegionTypeSimName) == false)
{
objvViewRegionEN.dicFldComparisonOp.Add(convViewRegion.RegionTypeSimName, strComparisonOp);
}
else
{
objvViewRegionEN.dicFldComparisonOp[convViewRegion.RegionTypeSimName] = strComparisonOp;
}
}
return objvViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strContainerTypeName">容器类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionEN SetContainerTypeName(this clsvViewRegionEN objvViewRegionEN, string strContainerTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strContainerTypeName, 50, convViewRegion.ContainerTypeName);
objvViewRegionEN.ContainerTypeName = strContainerTypeName; //容器类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRegionEN.dicFldComparisonOp.ContainsKey(convViewRegion.ContainerTypeName) == false)
{
objvViewRegionEN.dicFldComparisonOp.Add(convViewRegion.ContainerTypeName, strComparisonOp);
}
else
{
objvViewRegionEN.dicFldComparisonOp[convViewRegion.ContainerTypeName] = strComparisonOp;
}
}
return objvViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strPageDispModeName">页面显示模式名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionEN SetPageDispModeName(this clsvViewRegionEN objvViewRegionEN, string strPageDispModeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPageDispModeName, 50, convViewRegion.PageDispModeName);
objvViewRegionEN.PageDispModeName = strPageDispModeName; //页面显示模式名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRegionEN.dicFldComparisonOp.ContainsKey(convViewRegion.PageDispModeName) == false)
{
objvViewRegionEN.dicFldComparisonOp.Add(convViewRegion.PageDispModeName, strComparisonOp);
}
else
{
objvViewRegionEN.dicFldComparisonOp[convViewRegion.PageDispModeName] = strComparisonOp;
}
}
return objvViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strInOutTypeName">INOUT类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionEN SetInOutTypeName(this clsvViewRegionEN objvViewRegionEN, string strInOutTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strInOutTypeName, 30, convViewRegion.InOutTypeName);
objvViewRegionEN.InOutTypeName = strInOutTypeName; //INOUT类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRegionEN.dicFldComparisonOp.ContainsKey(convViewRegion.InOutTypeName) == false)
{
objvViewRegionEN.dicFldComparisonOp.Add(convViewRegion.InOutTypeName, strComparisonOp);
}
else
{
objvViewRegionEN.dicFldComparisonOp[convViewRegion.InOutTypeName] = strComparisonOp;
}
}
return objvViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionEN SetTabName(this clsvViewRegionEN objvViewRegionEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabName, 100, convViewRegion.TabName);
objvViewRegionEN.TabName = strTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRegionEN.dicFldComparisonOp.ContainsKey(convViewRegion.TabName) == false)
{
objvViewRegionEN.dicFldComparisonOp.Add(convViewRegion.TabName, strComparisonOp);
}
else
{
objvViewRegionEN.dicFldComparisonOp[convViewRegion.TabName] = strComparisonOp;
}
}
return objvViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strApplicationTypeSimName">应用程序类型简称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionEN SetApplicationTypeSimName(this clsvViewRegionEN objvViewRegionEN, string strApplicationTypeSimName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strApplicationTypeSimName, 30, convViewRegion.ApplicationTypeSimName);
objvViewRegionEN.ApplicationTypeSimName = strApplicationTypeSimName; //应用程序类型简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRegionEN.dicFldComparisonOp.ContainsKey(convViewRegion.ApplicationTypeSimName) == false)
{
objvViewRegionEN.dicFldComparisonOp.Add(convViewRegion.ApplicationTypeSimName, strComparisonOp);
}
else
{
objvViewRegionEN.dicFldComparisonOp[convViewRegion.ApplicationTypeSimName] = strComparisonOp;
}
}
return objvViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "intRegionTypeOrderNum">区域类型序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionEN SetRegionTypeOrderNum(this clsvViewRegionEN objvViewRegionEN, int intRegionTypeOrderNum, string strComparisonOp="")
	{
objvViewRegionEN.RegionTypeOrderNum = intRegionTypeOrderNum; //区域类型序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRegionEN.dicFldComparisonOp.ContainsKey(convViewRegion.RegionTypeOrderNum) == false)
{
objvViewRegionEN.dicFldComparisonOp.Add(convViewRegion.RegionTypeOrderNum, strComparisonOp);
}
else
{
objvViewRegionEN.dicFldComparisonOp[convViewRegion.RegionTypeOrderNum] = strComparisonOp;
}
}
return objvViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionTypeName">区域类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionEN SetRegionTypeName(this clsvViewRegionEN objvViewRegionEN, string strRegionTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionTypeName, convViewRegion.RegionTypeName);
clsCheckSql.CheckFieldLen(strRegionTypeName, 30, convViewRegion.RegionTypeName);
objvViewRegionEN.RegionTypeName = strRegionTypeName; //区域类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRegionEN.dicFldComparisonOp.ContainsKey(convViewRegion.RegionTypeName) == false)
{
objvViewRegionEN.dicFldComparisonOp.Add(convViewRegion.RegionTypeName, strComparisonOp);
}
else
{
objvViewRegionEN.dicFldComparisonOp[convViewRegion.RegionTypeName] = strComparisonOp;
}
}
return objvViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strClsName">类名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionEN SetClsName(this clsvViewRegionEN objvViewRegionEN, string strClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strClsName, convViewRegion.ClsName);
clsCheckSql.CheckFieldLen(strClsName, 100, convViewRegion.ClsName);
objvViewRegionEN.ClsName = strClsName; //类名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewRegionEN.dicFldComparisonOp.ContainsKey(convViewRegion.ClsName) == false)
{
objvViewRegionEN.dicFldComparisonOp.Add(convViewRegion.ClsName, strComparisonOp);
}
else
{
objvViewRegionEN.dicFldComparisonOp[convViewRegion.ClsName] = strComparisonOp;
}
}
return objvViewRegionEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvViewRegionEN objvViewRegionCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvViewRegionCond.IsUpdated(convViewRegion.RegionId) == true)
{
string strComparisonOpRegionId = objvViewRegionCond.dicFldComparisonOp[convViewRegion.RegionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRegion.RegionId, objvViewRegionCond.RegionId, strComparisonOpRegionId);
}
if (objvViewRegionCond.IsUpdated(convViewRegion.RegionName) == true)
{
string strComparisonOpRegionName = objvViewRegionCond.dicFldComparisonOp[convViewRegion.RegionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRegion.RegionName, objvViewRegionCond.RegionName, strComparisonOpRegionName);
}
if (objvViewRegionCond.IsUpdated(convViewRegion.RegionTypeId) == true)
{
string strComparisonOpRegionTypeId = objvViewRegionCond.dicFldComparisonOp[convViewRegion.RegionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRegion.RegionTypeId, objvViewRegionCond.RegionTypeId, strComparisonOpRegionTypeId);
}
if (objvViewRegionCond.IsUpdated(convViewRegion.FileName) == true)
{
string strComparisonOpFileName = objvViewRegionCond.dicFldComparisonOp[convViewRegion.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRegion.FileName, objvViewRegionCond.FileName, strComparisonOpFileName);
}
if (objvViewRegionCond.IsUpdated(convViewRegion.Height) == true)
{
string strComparisonOpHeight = objvViewRegionCond.dicFldComparisonOp[convViewRegion.Height];
strWhereCond += string.Format(" And {0} {2} {1}", convViewRegion.Height, objvViewRegionCond.Height, strComparisonOpHeight);
}
if (objvViewRegionCond.IsUpdated(convViewRegion.Width) == true)
{
string strComparisonOpWidth = objvViewRegionCond.dicFldComparisonOp[convViewRegion.Width];
strWhereCond += string.Format(" And {0} {2} {1}", convViewRegion.Width, objvViewRegionCond.Width, strComparisonOpWidth);
}
if (objvViewRegionCond.IsUpdated(convViewRegion.ColNum) == true)
{
string strComparisonOpColNum = objvViewRegionCond.dicFldComparisonOp[convViewRegion.ColNum];
strWhereCond += string.Format(" And {0} {2} {1}", convViewRegion.ColNum, objvViewRegionCond.ColNum, strComparisonOpColNum);
}
if (objvViewRegionCond.IsUpdated(convViewRegion.ContainerTypeId) == true)
{
string strComparisonOpContainerTypeId = objvViewRegionCond.dicFldComparisonOp[convViewRegion.ContainerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRegion.ContainerTypeId, objvViewRegionCond.ContainerTypeId, strComparisonOpContainerTypeId);
}
if (objvViewRegionCond.IsUpdated(convViewRegion.PageDispModeId) == true)
{
string strComparisonOpPageDispModeId = objvViewRegionCond.dicFldComparisonOp[convViewRegion.PageDispModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRegion.PageDispModeId, objvViewRegionCond.PageDispModeId, strComparisonOpPageDispModeId);
}
if (objvViewRegionCond.IsUpdated(convViewRegion.InOutTypeId) == true)
{
string strComparisonOpInOutTypeId = objvViewRegionCond.dicFldComparisonOp[convViewRegion.InOutTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRegion.InOutTypeId, objvViewRegionCond.InOutTypeId, strComparisonOpInOutTypeId);
}
if (objvViewRegionCond.IsUpdated(convViewRegion.InOutTypeENName) == true)
{
string strComparisonOpInOutTypeENName = objvViewRegionCond.dicFldComparisonOp[convViewRegion.InOutTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRegion.InOutTypeENName, objvViewRegionCond.InOutTypeENName, strComparisonOpInOutTypeENName);
}
if (objvViewRegionCond.IsUpdated(convViewRegion.TabId) == true)
{
string strComparisonOpTabId = objvViewRegionCond.dicFldComparisonOp[convViewRegion.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRegion.TabId, objvViewRegionCond.TabId, strComparisonOpTabId);
}
if (objvViewRegionCond.IsUpdated(convViewRegion.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objvViewRegionCond.dicFldComparisonOp[convViewRegion.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", convViewRegion.ApplicationTypeId, objvViewRegionCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objvViewRegionCond.IsUpdated(convViewRegion.KeyId4Test) == true)
{
string strComparisonOpKeyId4Test = objvViewRegionCond.dicFldComparisonOp[convViewRegion.KeyId4Test];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRegion.KeyId4Test, objvViewRegionCond.KeyId4Test, strComparisonOpKeyId4Test);
}
if (objvViewRegionCond.IsUpdated(convViewRegion.PrjId) == true)
{
string strComparisonOpPrjId = objvViewRegionCond.dicFldComparisonOp[convViewRegion.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRegion.PrjId, objvViewRegionCond.PrjId, strComparisonOpPrjId);
}
if (objvViewRegionCond.IsUpdated(convViewRegion.UpdUser) == true)
{
string strComparisonOpUpdUser = objvViewRegionCond.dicFldComparisonOp[convViewRegion.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRegion.UpdUser, objvViewRegionCond.UpdUser, strComparisonOpUpdUser);
}
if (objvViewRegionCond.IsUpdated(convViewRegion.UpdDate) == true)
{
string strComparisonOpUpdDate = objvViewRegionCond.dicFldComparisonOp[convViewRegion.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRegion.UpdDate, objvViewRegionCond.UpdDate, strComparisonOpUpdDate);
}
if (objvViewRegionCond.IsUpdated(convViewRegion.Memo) == true)
{
string strComparisonOpMemo = objvViewRegionCond.dicFldComparisonOp[convViewRegion.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRegion.Memo, objvViewRegionCond.Memo, strComparisonOpMemo);
}
if (objvViewRegionCond.IsUpdated(convViewRegion.RegionTypeSimName) == true)
{
string strComparisonOpRegionTypeSimName = objvViewRegionCond.dicFldComparisonOp[convViewRegion.RegionTypeSimName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRegion.RegionTypeSimName, objvViewRegionCond.RegionTypeSimName, strComparisonOpRegionTypeSimName);
}
if (objvViewRegionCond.IsUpdated(convViewRegion.ContainerTypeName) == true)
{
string strComparisonOpContainerTypeName = objvViewRegionCond.dicFldComparisonOp[convViewRegion.ContainerTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRegion.ContainerTypeName, objvViewRegionCond.ContainerTypeName, strComparisonOpContainerTypeName);
}
if (objvViewRegionCond.IsUpdated(convViewRegion.PageDispModeName) == true)
{
string strComparisonOpPageDispModeName = objvViewRegionCond.dicFldComparisonOp[convViewRegion.PageDispModeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRegion.PageDispModeName, objvViewRegionCond.PageDispModeName, strComparisonOpPageDispModeName);
}
if (objvViewRegionCond.IsUpdated(convViewRegion.InOutTypeName) == true)
{
string strComparisonOpInOutTypeName = objvViewRegionCond.dicFldComparisonOp[convViewRegion.InOutTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRegion.InOutTypeName, objvViewRegionCond.InOutTypeName, strComparisonOpInOutTypeName);
}
if (objvViewRegionCond.IsUpdated(convViewRegion.TabName) == true)
{
string strComparisonOpTabName = objvViewRegionCond.dicFldComparisonOp[convViewRegion.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRegion.TabName, objvViewRegionCond.TabName, strComparisonOpTabName);
}
if (objvViewRegionCond.IsUpdated(convViewRegion.ApplicationTypeSimName) == true)
{
string strComparisonOpApplicationTypeSimName = objvViewRegionCond.dicFldComparisonOp[convViewRegion.ApplicationTypeSimName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRegion.ApplicationTypeSimName, objvViewRegionCond.ApplicationTypeSimName, strComparisonOpApplicationTypeSimName);
}
if (objvViewRegionCond.IsUpdated(convViewRegion.RegionTypeOrderNum) == true)
{
string strComparisonOpRegionTypeOrderNum = objvViewRegionCond.dicFldComparisonOp[convViewRegion.RegionTypeOrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convViewRegion.RegionTypeOrderNum, objvViewRegionCond.RegionTypeOrderNum, strComparisonOpRegionTypeOrderNum);
}
if (objvViewRegionCond.IsUpdated(convViewRegion.RegionTypeName) == true)
{
string strComparisonOpRegionTypeName = objvViewRegionCond.dicFldComparisonOp[convViewRegion.RegionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRegion.RegionTypeName, objvViewRegionCond.RegionTypeName, strComparisonOpRegionTypeName);
}
if (objvViewRegionCond.IsUpdated(convViewRegion.ClsName) == true)
{
string strComparisonOpClsName = objvViewRegionCond.dicFldComparisonOp[convViewRegion.ClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewRegion.ClsName, objvViewRegionCond.ClsName, strComparisonOpClsName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v界面区域(vViewRegion)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvViewRegionWApi
{
private static readonly string mstrApiControllerName = "vViewRegionApi";

 public clsvViewRegionWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strRegionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvViewRegionEN GetObjByRegionId(string strRegionId)
{
if (strRegionId == "") return null;
string strAction = "GetObjByRegionId";
clsvViewRegionEN objvViewRegionEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strRegionId"] = strRegionId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvViewRegionEN = JsonConvert.DeserializeObject<clsvViewRegionEN>(strJson);
return objvViewRegionEN;
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
public static string GetFirstID(string strWhereCond)
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
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
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
public static clsvViewRegionEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvViewRegionEN objvViewRegionEN;
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
objvViewRegionEN = JsonConvert.DeserializeObject<clsvViewRegionEN>(strJson);
return objvViewRegionEN;
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
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strRegionId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvViewRegionEN GetObjByRegionIdCache(string strRegionId,string strCmPrjId)
{
if (string.IsNullOrEmpty(strRegionId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvViewRegionEN._CurrTabName, strPrjId);
List<clsvViewRegionEN> arrvViewRegionObjLstCache = GetObjLstCache(strCmPrjId);
IEnumerable <clsvViewRegionEN> arrvViewRegionObjLst_Sel =
from objvViewRegionEN in arrvViewRegionObjLstCache
where objvViewRegionEN.RegionId == strRegionId 
select objvViewRegionEN;
if (arrvViewRegionObjLst_Sel.Count() == 0)
{
   clsvViewRegionEN obj = clsvViewRegionWApi.GetObjByRegionId(strRegionId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvViewRegionObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewRegionEN> GetObjLst(string strWhereCond)
{
 List<clsvViewRegionEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewRegionEN>>(strJson);
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
 /// <param name = "arrRegionId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewRegionEN> GetObjLstByRegionIdLst(List<string> arrRegionId)
{
 List<clsvViewRegionEN> arrObjLst; 
string strAction = "GetObjLstByRegionIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrRegionId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewRegionEN>>(strJson);
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

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrRegionId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsvViewRegionEN> GetObjLstByRegionIdLstCache(List<string> arrRegionId, string strCmPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvViewRegionEN._CurrTabName, strPrjId);
List<clsvViewRegionEN> arrvViewRegionObjLstCache = GetObjLstCache(strCmPrjId);
IEnumerable <clsvViewRegionEN> arrvViewRegionObjLst_Sel =
from objvViewRegionEN in arrvViewRegionObjLstCache
where arrRegionId.Contains(objvViewRegionEN.RegionId)
select objvViewRegionEN;
return arrvViewRegionObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewRegionEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvViewRegionEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewRegionEN>>(strJson);
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
public static List<clsvViewRegionEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvViewRegionEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewRegionEN>>(strJson);
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
public static List<clsvViewRegionEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvViewRegionEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewRegionEN>>(strJson);
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
public static List<clsvViewRegionEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvViewRegionEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewRegionEN>>(strJson);
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
public static bool IsExist(string strRegionId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strRegionId"] = strRegionId
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
 /// <param name = "objvViewRegionENS">源对象</param>
 /// <param name = "objvViewRegionENT">目标对象</param>
 public static void CopyTo(clsvViewRegionEN objvViewRegionENS, clsvViewRegionEN objvViewRegionENT)
{
try
{
objvViewRegionENT.RegionId = objvViewRegionENS.RegionId; //区域Id
objvViewRegionENT.RegionName = objvViewRegionENS.RegionName; //区域名称
objvViewRegionENT.RegionTypeId = objvViewRegionENS.RegionTypeId; //区域类型Id
objvViewRegionENT.FileName = objvViewRegionENS.FileName; //文件名
objvViewRegionENT.Height = objvViewRegionENS.Height; //高度
objvViewRegionENT.Width = objvViewRegionENS.Width; //宽
objvViewRegionENT.ColNum = objvViewRegionENS.ColNum; //列数
objvViewRegionENT.ContainerTypeId = objvViewRegionENS.ContainerTypeId; //容器类型Id
objvViewRegionENT.PageDispModeId = objvViewRegionENS.PageDispModeId; //页面显示模式Id
objvViewRegionENT.InOutTypeId = objvViewRegionENS.InOutTypeId; //INOUT类型ID
objvViewRegionENT.InOutTypeENName = objvViewRegionENS.InOutTypeENName; //INOUT类型英文名
objvViewRegionENT.TabId = objvViewRegionENS.TabId; //表ID
objvViewRegionENT.ApplicationTypeId = objvViewRegionENS.ApplicationTypeId; //应用程序类型ID
objvViewRegionENT.KeyId4Test = objvViewRegionENS.KeyId4Test; //测试关键字Id
objvViewRegionENT.PrjId = objvViewRegionENS.PrjId; //工程Id
objvViewRegionENT.UpdUser = objvViewRegionENS.UpdUser; //修改者
objvViewRegionENT.UpdDate = objvViewRegionENS.UpdDate; //修改日期
objvViewRegionENT.Memo = objvViewRegionENS.Memo; //说明
objvViewRegionENT.RegionTypeSimName = objvViewRegionENS.RegionTypeSimName; //区域类型简名
objvViewRegionENT.ContainerTypeName = objvViewRegionENS.ContainerTypeName; //容器类型名
objvViewRegionENT.PageDispModeName = objvViewRegionENS.PageDispModeName; //页面显示模式名称
objvViewRegionENT.InOutTypeName = objvViewRegionENS.InOutTypeName; //INOUT类型名称
objvViewRegionENT.TabName = objvViewRegionENS.TabName; //表名
objvViewRegionENT.ApplicationTypeSimName = objvViewRegionENS.ApplicationTypeSimName; //应用程序类型简称
objvViewRegionENT.RegionTypeOrderNum = objvViewRegionENS.RegionTypeOrderNum; //区域类型序号
objvViewRegionENT.RegionTypeName = objvViewRegionENS.RegionTypeName; //区域类型名称
objvViewRegionENT.ClsName = objvViewRegionENS.ClsName; //类名
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
public static DataTable ToDataTable(List<clsvViewRegionEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvViewRegionEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvViewRegionEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvViewRegionEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvViewRegionEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvViewRegionEN._AttributeName)
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
public static void ReFreshThisCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvViewRegionWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvViewRegionWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvViewRegionEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
}
else
{
strMsg0 = string.Format("刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3));
clsSysParaEN.objLog.WriteDebugLog(strMsg0);
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvViewRegionEN> GetObjLstCache(string strCmPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvViewRegionWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvViewRegionWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsvViewRegionEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsvViewRegionEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",convViewRegion.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsvViewRegionEN._CurrTabName, strPrjId);
List<clsvViewRegionEN> arrvViewRegionObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvViewRegionObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvViewRegionEN> GetObjLstCacheFromObjLst(string strCmPrjId,List<clsvViewRegionEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvViewRegionWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvViewRegionWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsvViewRegionEN._CurrTabName, strPrjId);
List<clsvViewRegionEN> arrvViewRegionObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrvViewRegionObjLstCache = CacheHelper.Get<List<clsvViewRegionEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrvViewRegionObjLstCache = CacheHelper.Get<List<clsvViewRegionEN>>(strKey);
}
return arrvViewRegionObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvViewRegionEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convViewRegion.RegionId, Type.GetType("System.String"));
objDT.Columns.Add(convViewRegion.RegionName, Type.GetType("System.String"));
objDT.Columns.Add(convViewRegion.RegionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convViewRegion.FileName, Type.GetType("System.String"));
objDT.Columns.Add(convViewRegion.Height, Type.GetType("System.Int32"));
objDT.Columns.Add(convViewRegion.Width, Type.GetType("System.Int32"));
objDT.Columns.Add(convViewRegion.ColNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convViewRegion.ContainerTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convViewRegion.PageDispModeId, Type.GetType("System.String"));
objDT.Columns.Add(convViewRegion.InOutTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convViewRegion.InOutTypeENName, Type.GetType("System.String"));
objDT.Columns.Add(convViewRegion.TabId, Type.GetType("System.String"));
objDT.Columns.Add(convViewRegion.ApplicationTypeId, Type.GetType("System.Int32"));
objDT.Columns.Add(convViewRegion.KeyId4Test, Type.GetType("System.String"));
objDT.Columns.Add(convViewRegion.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convViewRegion.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convViewRegion.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convViewRegion.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convViewRegion.RegionTypeSimName, Type.GetType("System.String"));
objDT.Columns.Add(convViewRegion.ContainerTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convViewRegion.PageDispModeName, Type.GetType("System.String"));
objDT.Columns.Add(convViewRegion.InOutTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convViewRegion.TabName, Type.GetType("System.String"));
objDT.Columns.Add(convViewRegion.ApplicationTypeSimName, Type.GetType("System.String"));
objDT.Columns.Add(convViewRegion.RegionTypeOrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convViewRegion.RegionTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convViewRegion.ClsName, Type.GetType("System.String"));
foreach (clsvViewRegionEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convViewRegion.RegionId] = objInFor[convViewRegion.RegionId];
objDR[convViewRegion.RegionName] = objInFor[convViewRegion.RegionName];
objDR[convViewRegion.RegionTypeId] = objInFor[convViewRegion.RegionTypeId];
objDR[convViewRegion.FileName] = objInFor[convViewRegion.FileName];
objDR[convViewRegion.Height] = objInFor[convViewRegion.Height];
objDR[convViewRegion.Width] = objInFor[convViewRegion.Width];
objDR[convViewRegion.ColNum] = objInFor[convViewRegion.ColNum];
objDR[convViewRegion.ContainerTypeId] = objInFor[convViewRegion.ContainerTypeId];
objDR[convViewRegion.PageDispModeId] = objInFor[convViewRegion.PageDispModeId];
objDR[convViewRegion.InOutTypeId] = objInFor[convViewRegion.InOutTypeId];
objDR[convViewRegion.InOutTypeENName] = objInFor[convViewRegion.InOutTypeENName];
objDR[convViewRegion.TabId] = objInFor[convViewRegion.TabId];
objDR[convViewRegion.ApplicationTypeId] = objInFor[convViewRegion.ApplicationTypeId];
objDR[convViewRegion.KeyId4Test] = objInFor[convViewRegion.KeyId4Test];
objDR[convViewRegion.PrjId] = objInFor[convViewRegion.PrjId];
objDR[convViewRegion.UpdUser] = objInFor[convViewRegion.UpdUser];
objDR[convViewRegion.UpdDate] = objInFor[convViewRegion.UpdDate];
objDR[convViewRegion.Memo] = objInFor[convViewRegion.Memo];
objDR[convViewRegion.RegionTypeSimName] = objInFor[convViewRegion.RegionTypeSimName];
objDR[convViewRegion.ContainerTypeName] = objInFor[convViewRegion.ContainerTypeName];
objDR[convViewRegion.PageDispModeName] = objInFor[convViewRegion.PageDispModeName];
objDR[convViewRegion.InOutTypeName] = objInFor[convViewRegion.InOutTypeName];
objDR[convViewRegion.TabName] = objInFor[convViewRegion.TabName];
objDR[convViewRegion.ApplicationTypeSimName] = objInFor[convViewRegion.ApplicationTypeSimName];
objDR[convViewRegion.RegionTypeOrderNum] = objInFor[convViewRegion.RegionTypeOrderNum];
objDR[convViewRegion.RegionTypeName] = objInFor[convViewRegion.RegionTypeName];
objDR[convViewRegion.ClsName] = objInFor[convViewRegion.ClsName];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}