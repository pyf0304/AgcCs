
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewRegionBL
 表名:vViewRegion(00050199)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:04:01
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:区域管理(RegionManage)
 框架-层名:业务逻辑层(CS)(BusinessLogic,0003)
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
public static class  clsvViewRegionBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strRegionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvViewRegionEN GetObj(this K_RegionId_vViewRegion myKey)
{
clsvViewRegionEN objvViewRegionEN = clsvViewRegionBL.vViewRegionDA.GetObjByRegionId(myKey.Value);
return objvViewRegionEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionEN SetRegionId(this clsvViewRegionEN objvViewRegionEN, string strRegionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionId, 10, convViewRegion.RegionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRegionId, 10, convViewRegion.RegionId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionEN SetRegionName(this clsvViewRegionEN objvViewRegionEN, string strRegionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionName, convViewRegion.RegionName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionName, 50, convViewRegion.RegionName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionEN SetRegionTypeId(this clsvViewRegionEN objvViewRegionEN, string strRegionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionTypeId, convViewRegion.RegionTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionTypeId, 4, convViewRegion.RegionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRegionTypeId, 4, convViewRegion.RegionTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionEN SetFileName(this clsvViewRegionEN objvViewRegionEN, string strFileName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileName, 150, convViewRegion.FileName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionEN SetHeight(this clsvViewRegionEN objvViewRegionEN, int? intHeight, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionEN SetWidth(this clsvViewRegionEN objvViewRegionEN, int? intWidth, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionEN SetColNum(this clsvViewRegionEN objvViewRegionEN, int? intColNum, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionEN SetContainerTypeId(this clsvViewRegionEN objvViewRegionEN, string strContainerTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strContainerTypeId, 4, convViewRegion.ContainerTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strContainerTypeId, 4, convViewRegion.ContainerTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionEN SetPageDispModeId(this clsvViewRegionEN objvViewRegionEN, string strPageDispModeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPageDispModeId, 2, convViewRegion.PageDispModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPageDispModeId, 2, convViewRegion.PageDispModeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionEN SetInOutTypeId(this clsvViewRegionEN objvViewRegionEN, string strInOutTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strInOutTypeId, convViewRegion.InOutTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strInOutTypeId, 2, convViewRegion.InOutTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strInOutTypeId, 2, convViewRegion.InOutTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionEN SetInOutTypeENName(this clsvViewRegionEN objvViewRegionEN, string strInOutTypeENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strInOutTypeENName, 30, convViewRegion.InOutTypeENName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionEN SetTabId(this clsvViewRegionEN objvViewRegionEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, convViewRegion.TabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, convViewRegion.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convViewRegion.TabId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionEN SetApplicationTypeId(this clsvViewRegionEN objvViewRegionEN, int? intApplicationTypeId, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionEN SetKeyId4Test(this clsvViewRegionEN objvViewRegionEN, string strKeyId4Test, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyId4Test, 50, convViewRegion.KeyId4Test);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionEN SetPrjId(this clsvViewRegionEN objvViewRegionEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convViewRegion.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convViewRegion.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convViewRegion.PrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionEN SetUpdUser(this clsvViewRegionEN objvViewRegionEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convViewRegion.UpdUser);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionEN SetUpdDate(this clsvViewRegionEN objvViewRegionEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convViewRegion.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionEN SetMemo(this clsvViewRegionEN objvViewRegionEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convViewRegion.Memo);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionEN SetRegionTypeSimName(this clsvViewRegionEN objvViewRegionEN, string strRegionTypeSimName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionTypeSimName, 10, convViewRegion.RegionTypeSimName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionEN SetContainerTypeName(this clsvViewRegionEN objvViewRegionEN, string strContainerTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strContainerTypeName, 50, convViewRegion.ContainerTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionEN SetPageDispModeName(this clsvViewRegionEN objvViewRegionEN, string strPageDispModeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPageDispModeName, 50, convViewRegion.PageDispModeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionEN SetInOutTypeName(this clsvViewRegionEN objvViewRegionEN, string strInOutTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strInOutTypeName, 30, convViewRegion.InOutTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionEN SetTabName(this clsvViewRegionEN objvViewRegionEN, string strTabName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabName, 100, convViewRegion.TabName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionEN SetApplicationTypeSimName(this clsvViewRegionEN objvViewRegionEN, string strApplicationTypeSimName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strApplicationTypeSimName, 30, convViewRegion.ApplicationTypeSimName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionEN SetRegionTypeOrderNum(this clsvViewRegionEN objvViewRegionEN, int? intRegionTypeOrderNum, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionEN SetRegionTypeName(this clsvViewRegionEN objvViewRegionEN, string strRegionTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionTypeName, convViewRegion.RegionTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionTypeName, 30, convViewRegion.RegionTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewRegionEN SetClsName(this clsvViewRegionEN objvViewRegionEN, string strClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strClsName, convViewRegion.ClsName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClsName, 100, convViewRegion.ClsName);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvViewRegionENS">源对象</param>
 /// <param name = "objvViewRegionENT">目标对象</param>
 public static void CopyTo(this clsvViewRegionEN objvViewRegionENS, clsvViewRegionEN objvViewRegionENT)
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
 /// <param name = "objvViewRegionENS">源对象</param>
 /// <returns>目标对象=>clsvViewRegionEN:objvViewRegionENT</returns>
 public static clsvViewRegionEN CopyTo(this clsvViewRegionEN objvViewRegionENS)
{
try
{
 clsvViewRegionEN objvViewRegionENT = new clsvViewRegionEN()
{
RegionId = objvViewRegionENS.RegionId, //区域Id
RegionName = objvViewRegionENS.RegionName, //区域名称
RegionTypeId = objvViewRegionENS.RegionTypeId, //区域类型Id
FileName = objvViewRegionENS.FileName, //文件名
Height = objvViewRegionENS.Height, //高度
Width = objvViewRegionENS.Width, //宽
ColNum = objvViewRegionENS.ColNum, //列数
ContainerTypeId = objvViewRegionENS.ContainerTypeId, //容器类型Id
PageDispModeId = objvViewRegionENS.PageDispModeId, //页面显示模式Id
InOutTypeId = objvViewRegionENS.InOutTypeId, //INOUT类型ID
InOutTypeENName = objvViewRegionENS.InOutTypeENName, //INOUT类型英文名
TabId = objvViewRegionENS.TabId, //表ID
ApplicationTypeId = objvViewRegionENS.ApplicationTypeId, //应用程序类型ID
KeyId4Test = objvViewRegionENS.KeyId4Test, //测试关键字Id
PrjId = objvViewRegionENS.PrjId, //工程Id
UpdUser = objvViewRegionENS.UpdUser, //修改者
UpdDate = objvViewRegionENS.UpdDate, //修改日期
Memo = objvViewRegionENS.Memo, //说明
RegionTypeSimName = objvViewRegionENS.RegionTypeSimName, //区域类型简名
ContainerTypeName = objvViewRegionENS.ContainerTypeName, //容器类型名
PageDispModeName = objvViewRegionENS.PageDispModeName, //页面显示模式名称
InOutTypeName = objvViewRegionENS.InOutTypeName, //INOUT类型名称
TabName = objvViewRegionENS.TabName, //表名
ApplicationTypeSimName = objvViewRegionENS.ApplicationTypeSimName, //应用程序类型简称
RegionTypeOrderNum = objvViewRegionENS.RegionTypeOrderNum, //区域类型序号
RegionTypeName = objvViewRegionENS.RegionTypeName, //区域类型名称
ClsName = objvViewRegionENS.ClsName, //类名
};
 return objvViewRegionENT;
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
public static void CheckProperty4Condition(this clsvViewRegionEN objvViewRegionEN)
{
 clsvViewRegionBL.vViewRegionDA.CheckProperty4Condition(objvViewRegionEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vViewRegion
{
public virtual bool UpdRelaTabDate(string strRegionId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v界面区域(vViewRegion)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvViewRegionBL
{
public static RelatedActions_vViewRegion relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvViewRegionDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvViewRegionDA vViewRegionDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvViewRegionDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvViewRegionBL()
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
if (string.IsNullOrEmpty(clsvViewRegionEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvViewRegionEN._ConnectString);
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
public static DataTable GetDataTable_vViewRegion(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vViewRegionDA.GetDataTable_vViewRegion(strWhereCond);
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
objDT = vViewRegionDA.GetDataTable(strWhereCond);
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
objDT = vViewRegionDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vViewRegionDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vViewRegionDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vViewRegionDA.GetDataTable_Top(objTopPara);
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
objDT = vViewRegionDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vViewRegionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vViewRegionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrRegionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvViewRegionEN> GetObjLstByRegionIdLst(List<string> arrRegionIdLst)
{
List<clsvViewRegionEN> arrObjLst = new List<clsvViewRegionEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrRegionIdLst, true);
 string strWhereCond = string.Format("RegionId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewRegionEN objvViewRegionEN = new clsvViewRegionEN();
try
{
objvViewRegionEN.RegionId = objRow[convViewRegion.RegionId].ToString().Trim(); //区域Id
objvViewRegionEN.RegionName = objRow[convViewRegion.RegionName].ToString().Trim(); //区域名称
objvViewRegionEN.RegionTypeId = objRow[convViewRegion.RegionTypeId].ToString().Trim(); //区域类型Id
objvViewRegionEN.FileName = objRow[convViewRegion.FileName] == DBNull.Value ? null : objRow[convViewRegion.FileName].ToString().Trim(); //文件名
objvViewRegionEN.Height = objRow[convViewRegion.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.Height].ToString().Trim()); //高度
objvViewRegionEN.Width = objRow[convViewRegion.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.Width].ToString().Trim()); //宽
objvViewRegionEN.ColNum = objRow[convViewRegion.ColNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.ColNum].ToString().Trim()); //列数
objvViewRegionEN.ContainerTypeId = objRow[convViewRegion.ContainerTypeId] == DBNull.Value ? null : objRow[convViewRegion.ContainerTypeId].ToString().Trim(); //容器类型Id
objvViewRegionEN.PageDispModeId = objRow[convViewRegion.PageDispModeId] == DBNull.Value ? null : objRow[convViewRegion.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvViewRegionEN.InOutTypeId = objRow[convViewRegion.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvViewRegionEN.InOutTypeENName = objRow[convViewRegion.InOutTypeENName] == DBNull.Value ? null : objRow[convViewRegion.InOutTypeENName].ToString().Trim(); //INOUT类型英文名
objvViewRegionEN.TabId = objRow[convViewRegion.TabId].ToString().Trim(); //表ID
objvViewRegionEN.ApplicationTypeId = objRow[convViewRegion.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewRegionEN.KeyId4Test = objRow[convViewRegion.KeyId4Test] == DBNull.Value ? null : objRow[convViewRegion.KeyId4Test].ToString().Trim(); //测试关键字Id
objvViewRegionEN.PrjId = objRow[convViewRegion.PrjId].ToString().Trim(); //工程Id
objvViewRegionEN.UpdUser = objRow[convViewRegion.UpdUser] == DBNull.Value ? null : objRow[convViewRegion.UpdUser].ToString().Trim(); //修改者
objvViewRegionEN.UpdDate = objRow[convViewRegion.UpdDate] == DBNull.Value ? null : objRow[convViewRegion.UpdDate].ToString().Trim(); //修改日期
objvViewRegionEN.Memo = objRow[convViewRegion.Memo] == DBNull.Value ? null : objRow[convViewRegion.Memo].ToString().Trim(); //说明
objvViewRegionEN.RegionTypeSimName = objRow[convViewRegion.RegionTypeSimName] == DBNull.Value ? null : objRow[convViewRegion.RegionTypeSimName].ToString().Trim(); //区域类型简名
objvViewRegionEN.ContainerTypeName = objRow[convViewRegion.ContainerTypeName] == DBNull.Value ? null : objRow[convViewRegion.ContainerTypeName].ToString().Trim(); //容器类型名
objvViewRegionEN.PageDispModeName = objRow[convViewRegion.PageDispModeName] == DBNull.Value ? null : objRow[convViewRegion.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvViewRegionEN.InOutTypeName = objRow[convViewRegion.InOutTypeName] == DBNull.Value ? null : objRow[convViewRegion.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvViewRegionEN.TabName = objRow[convViewRegion.TabName] == DBNull.Value ? null : objRow[convViewRegion.TabName].ToString().Trim(); //表名
objvViewRegionEN.ApplicationTypeSimName = objRow[convViewRegion.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convViewRegion.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvViewRegionEN.RegionTypeOrderNum = objRow[convViewRegion.RegionTypeOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.RegionTypeOrderNum].ToString().Trim()); //区域类型序号
objvViewRegionEN.RegionTypeName = objRow[convViewRegion.RegionTypeName].ToString().Trim(); //区域类型名称
objvViewRegionEN.ClsName = objRow[convViewRegion.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewRegionEN.RegionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewRegionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrRegionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvViewRegionEN> GetObjLstByRegionIdLstCache(List<string> arrRegionIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvViewRegionEN._CurrTabName, strPrjId);
List<clsvViewRegionEN> arrvViewRegionObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvViewRegionEN> arrvViewRegionObjLst_Sel =
arrvViewRegionObjLstCache
.Where(x => arrRegionIdLst.Contains(x.RegionId));
return arrvViewRegionObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewRegionEN> GetObjLst(string strWhereCond)
{
List<clsvViewRegionEN> arrObjLst = new List<clsvViewRegionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewRegionEN objvViewRegionEN = new clsvViewRegionEN();
try
{
objvViewRegionEN.RegionId = objRow[convViewRegion.RegionId].ToString().Trim(); //区域Id
objvViewRegionEN.RegionName = objRow[convViewRegion.RegionName].ToString().Trim(); //区域名称
objvViewRegionEN.RegionTypeId = objRow[convViewRegion.RegionTypeId].ToString().Trim(); //区域类型Id
objvViewRegionEN.FileName = objRow[convViewRegion.FileName] == DBNull.Value ? null : objRow[convViewRegion.FileName].ToString().Trim(); //文件名
objvViewRegionEN.Height = objRow[convViewRegion.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.Height].ToString().Trim()); //高度
objvViewRegionEN.Width = objRow[convViewRegion.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.Width].ToString().Trim()); //宽
objvViewRegionEN.ColNum = objRow[convViewRegion.ColNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.ColNum].ToString().Trim()); //列数
objvViewRegionEN.ContainerTypeId = objRow[convViewRegion.ContainerTypeId] == DBNull.Value ? null : objRow[convViewRegion.ContainerTypeId].ToString().Trim(); //容器类型Id
objvViewRegionEN.PageDispModeId = objRow[convViewRegion.PageDispModeId] == DBNull.Value ? null : objRow[convViewRegion.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvViewRegionEN.InOutTypeId = objRow[convViewRegion.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvViewRegionEN.InOutTypeENName = objRow[convViewRegion.InOutTypeENName] == DBNull.Value ? null : objRow[convViewRegion.InOutTypeENName].ToString().Trim(); //INOUT类型英文名
objvViewRegionEN.TabId = objRow[convViewRegion.TabId].ToString().Trim(); //表ID
objvViewRegionEN.ApplicationTypeId = objRow[convViewRegion.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewRegionEN.KeyId4Test = objRow[convViewRegion.KeyId4Test] == DBNull.Value ? null : objRow[convViewRegion.KeyId4Test].ToString().Trim(); //测试关键字Id
objvViewRegionEN.PrjId = objRow[convViewRegion.PrjId].ToString().Trim(); //工程Id
objvViewRegionEN.UpdUser = objRow[convViewRegion.UpdUser] == DBNull.Value ? null : objRow[convViewRegion.UpdUser].ToString().Trim(); //修改者
objvViewRegionEN.UpdDate = objRow[convViewRegion.UpdDate] == DBNull.Value ? null : objRow[convViewRegion.UpdDate].ToString().Trim(); //修改日期
objvViewRegionEN.Memo = objRow[convViewRegion.Memo] == DBNull.Value ? null : objRow[convViewRegion.Memo].ToString().Trim(); //说明
objvViewRegionEN.RegionTypeSimName = objRow[convViewRegion.RegionTypeSimName] == DBNull.Value ? null : objRow[convViewRegion.RegionTypeSimName].ToString().Trim(); //区域类型简名
objvViewRegionEN.ContainerTypeName = objRow[convViewRegion.ContainerTypeName] == DBNull.Value ? null : objRow[convViewRegion.ContainerTypeName].ToString().Trim(); //容器类型名
objvViewRegionEN.PageDispModeName = objRow[convViewRegion.PageDispModeName] == DBNull.Value ? null : objRow[convViewRegion.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvViewRegionEN.InOutTypeName = objRow[convViewRegion.InOutTypeName] == DBNull.Value ? null : objRow[convViewRegion.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvViewRegionEN.TabName = objRow[convViewRegion.TabName] == DBNull.Value ? null : objRow[convViewRegion.TabName].ToString().Trim(); //表名
objvViewRegionEN.ApplicationTypeSimName = objRow[convViewRegion.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convViewRegion.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvViewRegionEN.RegionTypeOrderNum = objRow[convViewRegion.RegionTypeOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.RegionTypeOrderNum].ToString().Trim()); //区域类型序号
objvViewRegionEN.RegionTypeName = objRow[convViewRegion.RegionTypeName].ToString().Trim(); //区域类型名称
objvViewRegionEN.ClsName = objRow[convViewRegion.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewRegionEN.RegionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewRegionEN);
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
public static List<clsvViewRegionEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvViewRegionEN> arrObjLst = new List<clsvViewRegionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewRegionEN objvViewRegionEN = new clsvViewRegionEN();
try
{
objvViewRegionEN.RegionId = objRow[convViewRegion.RegionId].ToString().Trim(); //区域Id
objvViewRegionEN.RegionName = objRow[convViewRegion.RegionName].ToString().Trim(); //区域名称
objvViewRegionEN.RegionTypeId = objRow[convViewRegion.RegionTypeId].ToString().Trim(); //区域类型Id
objvViewRegionEN.FileName = objRow[convViewRegion.FileName] == DBNull.Value ? null : objRow[convViewRegion.FileName].ToString().Trim(); //文件名
objvViewRegionEN.Height = objRow[convViewRegion.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.Height].ToString().Trim()); //高度
objvViewRegionEN.Width = objRow[convViewRegion.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.Width].ToString().Trim()); //宽
objvViewRegionEN.ColNum = objRow[convViewRegion.ColNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.ColNum].ToString().Trim()); //列数
objvViewRegionEN.ContainerTypeId = objRow[convViewRegion.ContainerTypeId] == DBNull.Value ? null : objRow[convViewRegion.ContainerTypeId].ToString().Trim(); //容器类型Id
objvViewRegionEN.PageDispModeId = objRow[convViewRegion.PageDispModeId] == DBNull.Value ? null : objRow[convViewRegion.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvViewRegionEN.InOutTypeId = objRow[convViewRegion.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvViewRegionEN.InOutTypeENName = objRow[convViewRegion.InOutTypeENName] == DBNull.Value ? null : objRow[convViewRegion.InOutTypeENName].ToString().Trim(); //INOUT类型英文名
objvViewRegionEN.TabId = objRow[convViewRegion.TabId].ToString().Trim(); //表ID
objvViewRegionEN.ApplicationTypeId = objRow[convViewRegion.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewRegionEN.KeyId4Test = objRow[convViewRegion.KeyId4Test] == DBNull.Value ? null : objRow[convViewRegion.KeyId4Test].ToString().Trim(); //测试关键字Id
objvViewRegionEN.PrjId = objRow[convViewRegion.PrjId].ToString().Trim(); //工程Id
objvViewRegionEN.UpdUser = objRow[convViewRegion.UpdUser] == DBNull.Value ? null : objRow[convViewRegion.UpdUser].ToString().Trim(); //修改者
objvViewRegionEN.UpdDate = objRow[convViewRegion.UpdDate] == DBNull.Value ? null : objRow[convViewRegion.UpdDate].ToString().Trim(); //修改日期
objvViewRegionEN.Memo = objRow[convViewRegion.Memo] == DBNull.Value ? null : objRow[convViewRegion.Memo].ToString().Trim(); //说明
objvViewRegionEN.RegionTypeSimName = objRow[convViewRegion.RegionTypeSimName] == DBNull.Value ? null : objRow[convViewRegion.RegionTypeSimName].ToString().Trim(); //区域类型简名
objvViewRegionEN.ContainerTypeName = objRow[convViewRegion.ContainerTypeName] == DBNull.Value ? null : objRow[convViewRegion.ContainerTypeName].ToString().Trim(); //容器类型名
objvViewRegionEN.PageDispModeName = objRow[convViewRegion.PageDispModeName] == DBNull.Value ? null : objRow[convViewRegion.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvViewRegionEN.InOutTypeName = objRow[convViewRegion.InOutTypeName] == DBNull.Value ? null : objRow[convViewRegion.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvViewRegionEN.TabName = objRow[convViewRegion.TabName] == DBNull.Value ? null : objRow[convViewRegion.TabName].ToString().Trim(); //表名
objvViewRegionEN.ApplicationTypeSimName = objRow[convViewRegion.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convViewRegion.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvViewRegionEN.RegionTypeOrderNum = objRow[convViewRegion.RegionTypeOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.RegionTypeOrderNum].ToString().Trim()); //区域类型序号
objvViewRegionEN.RegionTypeName = objRow[convViewRegion.RegionTypeName].ToString().Trim(); //区域类型名称
objvViewRegionEN.ClsName = objRow[convViewRegion.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewRegionEN.RegionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewRegionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvViewRegionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvViewRegionEN> GetSubObjLstCache(clsvViewRegionEN objvViewRegionCond)
{
 string strPrjId = objvViewRegionCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvViewRegionBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvViewRegionEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvViewRegionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convViewRegion._AttributeName)
{
if (objvViewRegionCond.IsUpdated(strFldName) == false) continue;
if (objvViewRegionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewRegionCond[strFldName].ToString());
}
else
{
if (objvViewRegionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvViewRegionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewRegionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvViewRegionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvViewRegionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvViewRegionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvViewRegionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvViewRegionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvViewRegionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvViewRegionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvViewRegionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvViewRegionCond[strFldName]));
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
public static List<clsvViewRegionEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvViewRegionEN> arrObjLst = new List<clsvViewRegionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewRegionEN objvViewRegionEN = new clsvViewRegionEN();
try
{
objvViewRegionEN.RegionId = objRow[convViewRegion.RegionId].ToString().Trim(); //区域Id
objvViewRegionEN.RegionName = objRow[convViewRegion.RegionName].ToString().Trim(); //区域名称
objvViewRegionEN.RegionTypeId = objRow[convViewRegion.RegionTypeId].ToString().Trim(); //区域类型Id
objvViewRegionEN.FileName = objRow[convViewRegion.FileName] == DBNull.Value ? null : objRow[convViewRegion.FileName].ToString().Trim(); //文件名
objvViewRegionEN.Height = objRow[convViewRegion.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.Height].ToString().Trim()); //高度
objvViewRegionEN.Width = objRow[convViewRegion.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.Width].ToString().Trim()); //宽
objvViewRegionEN.ColNum = objRow[convViewRegion.ColNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.ColNum].ToString().Trim()); //列数
objvViewRegionEN.ContainerTypeId = objRow[convViewRegion.ContainerTypeId] == DBNull.Value ? null : objRow[convViewRegion.ContainerTypeId].ToString().Trim(); //容器类型Id
objvViewRegionEN.PageDispModeId = objRow[convViewRegion.PageDispModeId] == DBNull.Value ? null : objRow[convViewRegion.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvViewRegionEN.InOutTypeId = objRow[convViewRegion.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvViewRegionEN.InOutTypeENName = objRow[convViewRegion.InOutTypeENName] == DBNull.Value ? null : objRow[convViewRegion.InOutTypeENName].ToString().Trim(); //INOUT类型英文名
objvViewRegionEN.TabId = objRow[convViewRegion.TabId].ToString().Trim(); //表ID
objvViewRegionEN.ApplicationTypeId = objRow[convViewRegion.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewRegionEN.KeyId4Test = objRow[convViewRegion.KeyId4Test] == DBNull.Value ? null : objRow[convViewRegion.KeyId4Test].ToString().Trim(); //测试关键字Id
objvViewRegionEN.PrjId = objRow[convViewRegion.PrjId].ToString().Trim(); //工程Id
objvViewRegionEN.UpdUser = objRow[convViewRegion.UpdUser] == DBNull.Value ? null : objRow[convViewRegion.UpdUser].ToString().Trim(); //修改者
objvViewRegionEN.UpdDate = objRow[convViewRegion.UpdDate] == DBNull.Value ? null : objRow[convViewRegion.UpdDate].ToString().Trim(); //修改日期
objvViewRegionEN.Memo = objRow[convViewRegion.Memo] == DBNull.Value ? null : objRow[convViewRegion.Memo].ToString().Trim(); //说明
objvViewRegionEN.RegionTypeSimName = objRow[convViewRegion.RegionTypeSimName] == DBNull.Value ? null : objRow[convViewRegion.RegionTypeSimName].ToString().Trim(); //区域类型简名
objvViewRegionEN.ContainerTypeName = objRow[convViewRegion.ContainerTypeName] == DBNull.Value ? null : objRow[convViewRegion.ContainerTypeName].ToString().Trim(); //容器类型名
objvViewRegionEN.PageDispModeName = objRow[convViewRegion.PageDispModeName] == DBNull.Value ? null : objRow[convViewRegion.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvViewRegionEN.InOutTypeName = objRow[convViewRegion.InOutTypeName] == DBNull.Value ? null : objRow[convViewRegion.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvViewRegionEN.TabName = objRow[convViewRegion.TabName] == DBNull.Value ? null : objRow[convViewRegion.TabName].ToString().Trim(); //表名
objvViewRegionEN.ApplicationTypeSimName = objRow[convViewRegion.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convViewRegion.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvViewRegionEN.RegionTypeOrderNum = objRow[convViewRegion.RegionTypeOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.RegionTypeOrderNum].ToString().Trim()); //区域类型序号
objvViewRegionEN.RegionTypeName = objRow[convViewRegion.RegionTypeName].ToString().Trim(); //区域类型名称
objvViewRegionEN.ClsName = objRow[convViewRegion.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewRegionEN.RegionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewRegionEN);
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
public static List<clsvViewRegionEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvViewRegionEN> arrObjLst = new List<clsvViewRegionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewRegionEN objvViewRegionEN = new clsvViewRegionEN();
try
{
objvViewRegionEN.RegionId = objRow[convViewRegion.RegionId].ToString().Trim(); //区域Id
objvViewRegionEN.RegionName = objRow[convViewRegion.RegionName].ToString().Trim(); //区域名称
objvViewRegionEN.RegionTypeId = objRow[convViewRegion.RegionTypeId].ToString().Trim(); //区域类型Id
objvViewRegionEN.FileName = objRow[convViewRegion.FileName] == DBNull.Value ? null : objRow[convViewRegion.FileName].ToString().Trim(); //文件名
objvViewRegionEN.Height = objRow[convViewRegion.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.Height].ToString().Trim()); //高度
objvViewRegionEN.Width = objRow[convViewRegion.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.Width].ToString().Trim()); //宽
objvViewRegionEN.ColNum = objRow[convViewRegion.ColNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.ColNum].ToString().Trim()); //列数
objvViewRegionEN.ContainerTypeId = objRow[convViewRegion.ContainerTypeId] == DBNull.Value ? null : objRow[convViewRegion.ContainerTypeId].ToString().Trim(); //容器类型Id
objvViewRegionEN.PageDispModeId = objRow[convViewRegion.PageDispModeId] == DBNull.Value ? null : objRow[convViewRegion.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvViewRegionEN.InOutTypeId = objRow[convViewRegion.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvViewRegionEN.InOutTypeENName = objRow[convViewRegion.InOutTypeENName] == DBNull.Value ? null : objRow[convViewRegion.InOutTypeENName].ToString().Trim(); //INOUT类型英文名
objvViewRegionEN.TabId = objRow[convViewRegion.TabId].ToString().Trim(); //表ID
objvViewRegionEN.ApplicationTypeId = objRow[convViewRegion.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewRegionEN.KeyId4Test = objRow[convViewRegion.KeyId4Test] == DBNull.Value ? null : objRow[convViewRegion.KeyId4Test].ToString().Trim(); //测试关键字Id
objvViewRegionEN.PrjId = objRow[convViewRegion.PrjId].ToString().Trim(); //工程Id
objvViewRegionEN.UpdUser = objRow[convViewRegion.UpdUser] == DBNull.Value ? null : objRow[convViewRegion.UpdUser].ToString().Trim(); //修改者
objvViewRegionEN.UpdDate = objRow[convViewRegion.UpdDate] == DBNull.Value ? null : objRow[convViewRegion.UpdDate].ToString().Trim(); //修改日期
objvViewRegionEN.Memo = objRow[convViewRegion.Memo] == DBNull.Value ? null : objRow[convViewRegion.Memo].ToString().Trim(); //说明
objvViewRegionEN.RegionTypeSimName = objRow[convViewRegion.RegionTypeSimName] == DBNull.Value ? null : objRow[convViewRegion.RegionTypeSimName].ToString().Trim(); //区域类型简名
objvViewRegionEN.ContainerTypeName = objRow[convViewRegion.ContainerTypeName] == DBNull.Value ? null : objRow[convViewRegion.ContainerTypeName].ToString().Trim(); //容器类型名
objvViewRegionEN.PageDispModeName = objRow[convViewRegion.PageDispModeName] == DBNull.Value ? null : objRow[convViewRegion.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvViewRegionEN.InOutTypeName = objRow[convViewRegion.InOutTypeName] == DBNull.Value ? null : objRow[convViewRegion.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvViewRegionEN.TabName = objRow[convViewRegion.TabName] == DBNull.Value ? null : objRow[convViewRegion.TabName].ToString().Trim(); //表名
objvViewRegionEN.ApplicationTypeSimName = objRow[convViewRegion.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convViewRegion.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvViewRegionEN.RegionTypeOrderNum = objRow[convViewRegion.RegionTypeOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.RegionTypeOrderNum].ToString().Trim()); //区域类型序号
objvViewRegionEN.RegionTypeName = objRow[convViewRegion.RegionTypeName].ToString().Trim(); //区域类型名称
objvViewRegionEN.ClsName = objRow[convViewRegion.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewRegionEN.RegionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewRegionEN);
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
List<clsvViewRegionEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvViewRegionEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewRegionEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvViewRegionEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvViewRegionEN> arrObjLst = new List<clsvViewRegionEN>(); 
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
	clsvViewRegionEN objvViewRegionEN = new clsvViewRegionEN();
try
{
objvViewRegionEN.RegionId = objRow[convViewRegion.RegionId].ToString().Trim(); //区域Id
objvViewRegionEN.RegionName = objRow[convViewRegion.RegionName].ToString().Trim(); //区域名称
objvViewRegionEN.RegionTypeId = objRow[convViewRegion.RegionTypeId].ToString().Trim(); //区域类型Id
objvViewRegionEN.FileName = objRow[convViewRegion.FileName] == DBNull.Value ? null : objRow[convViewRegion.FileName].ToString().Trim(); //文件名
objvViewRegionEN.Height = objRow[convViewRegion.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.Height].ToString().Trim()); //高度
objvViewRegionEN.Width = objRow[convViewRegion.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.Width].ToString().Trim()); //宽
objvViewRegionEN.ColNum = objRow[convViewRegion.ColNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.ColNum].ToString().Trim()); //列数
objvViewRegionEN.ContainerTypeId = objRow[convViewRegion.ContainerTypeId] == DBNull.Value ? null : objRow[convViewRegion.ContainerTypeId].ToString().Trim(); //容器类型Id
objvViewRegionEN.PageDispModeId = objRow[convViewRegion.PageDispModeId] == DBNull.Value ? null : objRow[convViewRegion.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvViewRegionEN.InOutTypeId = objRow[convViewRegion.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvViewRegionEN.InOutTypeENName = objRow[convViewRegion.InOutTypeENName] == DBNull.Value ? null : objRow[convViewRegion.InOutTypeENName].ToString().Trim(); //INOUT类型英文名
objvViewRegionEN.TabId = objRow[convViewRegion.TabId].ToString().Trim(); //表ID
objvViewRegionEN.ApplicationTypeId = objRow[convViewRegion.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewRegionEN.KeyId4Test = objRow[convViewRegion.KeyId4Test] == DBNull.Value ? null : objRow[convViewRegion.KeyId4Test].ToString().Trim(); //测试关键字Id
objvViewRegionEN.PrjId = objRow[convViewRegion.PrjId].ToString().Trim(); //工程Id
objvViewRegionEN.UpdUser = objRow[convViewRegion.UpdUser] == DBNull.Value ? null : objRow[convViewRegion.UpdUser].ToString().Trim(); //修改者
objvViewRegionEN.UpdDate = objRow[convViewRegion.UpdDate] == DBNull.Value ? null : objRow[convViewRegion.UpdDate].ToString().Trim(); //修改日期
objvViewRegionEN.Memo = objRow[convViewRegion.Memo] == DBNull.Value ? null : objRow[convViewRegion.Memo].ToString().Trim(); //说明
objvViewRegionEN.RegionTypeSimName = objRow[convViewRegion.RegionTypeSimName] == DBNull.Value ? null : objRow[convViewRegion.RegionTypeSimName].ToString().Trim(); //区域类型简名
objvViewRegionEN.ContainerTypeName = objRow[convViewRegion.ContainerTypeName] == DBNull.Value ? null : objRow[convViewRegion.ContainerTypeName].ToString().Trim(); //容器类型名
objvViewRegionEN.PageDispModeName = objRow[convViewRegion.PageDispModeName] == DBNull.Value ? null : objRow[convViewRegion.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvViewRegionEN.InOutTypeName = objRow[convViewRegion.InOutTypeName] == DBNull.Value ? null : objRow[convViewRegion.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvViewRegionEN.TabName = objRow[convViewRegion.TabName] == DBNull.Value ? null : objRow[convViewRegion.TabName].ToString().Trim(); //表名
objvViewRegionEN.ApplicationTypeSimName = objRow[convViewRegion.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convViewRegion.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvViewRegionEN.RegionTypeOrderNum = objRow[convViewRegion.RegionTypeOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.RegionTypeOrderNum].ToString().Trim()); //区域类型序号
objvViewRegionEN.RegionTypeName = objRow[convViewRegion.RegionTypeName].ToString().Trim(); //区域类型名称
objvViewRegionEN.ClsName = objRow[convViewRegion.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewRegionEN.RegionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewRegionEN);
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
public static List<clsvViewRegionEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvViewRegionEN> arrObjLst = new List<clsvViewRegionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewRegionEN objvViewRegionEN = new clsvViewRegionEN();
try
{
objvViewRegionEN.RegionId = objRow[convViewRegion.RegionId].ToString().Trim(); //区域Id
objvViewRegionEN.RegionName = objRow[convViewRegion.RegionName].ToString().Trim(); //区域名称
objvViewRegionEN.RegionTypeId = objRow[convViewRegion.RegionTypeId].ToString().Trim(); //区域类型Id
objvViewRegionEN.FileName = objRow[convViewRegion.FileName] == DBNull.Value ? null : objRow[convViewRegion.FileName].ToString().Trim(); //文件名
objvViewRegionEN.Height = objRow[convViewRegion.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.Height].ToString().Trim()); //高度
objvViewRegionEN.Width = objRow[convViewRegion.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.Width].ToString().Trim()); //宽
objvViewRegionEN.ColNum = objRow[convViewRegion.ColNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.ColNum].ToString().Trim()); //列数
objvViewRegionEN.ContainerTypeId = objRow[convViewRegion.ContainerTypeId] == DBNull.Value ? null : objRow[convViewRegion.ContainerTypeId].ToString().Trim(); //容器类型Id
objvViewRegionEN.PageDispModeId = objRow[convViewRegion.PageDispModeId] == DBNull.Value ? null : objRow[convViewRegion.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvViewRegionEN.InOutTypeId = objRow[convViewRegion.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvViewRegionEN.InOutTypeENName = objRow[convViewRegion.InOutTypeENName] == DBNull.Value ? null : objRow[convViewRegion.InOutTypeENName].ToString().Trim(); //INOUT类型英文名
objvViewRegionEN.TabId = objRow[convViewRegion.TabId].ToString().Trim(); //表ID
objvViewRegionEN.ApplicationTypeId = objRow[convViewRegion.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewRegionEN.KeyId4Test = objRow[convViewRegion.KeyId4Test] == DBNull.Value ? null : objRow[convViewRegion.KeyId4Test].ToString().Trim(); //测试关键字Id
objvViewRegionEN.PrjId = objRow[convViewRegion.PrjId].ToString().Trim(); //工程Id
objvViewRegionEN.UpdUser = objRow[convViewRegion.UpdUser] == DBNull.Value ? null : objRow[convViewRegion.UpdUser].ToString().Trim(); //修改者
objvViewRegionEN.UpdDate = objRow[convViewRegion.UpdDate] == DBNull.Value ? null : objRow[convViewRegion.UpdDate].ToString().Trim(); //修改日期
objvViewRegionEN.Memo = objRow[convViewRegion.Memo] == DBNull.Value ? null : objRow[convViewRegion.Memo].ToString().Trim(); //说明
objvViewRegionEN.RegionTypeSimName = objRow[convViewRegion.RegionTypeSimName] == DBNull.Value ? null : objRow[convViewRegion.RegionTypeSimName].ToString().Trim(); //区域类型简名
objvViewRegionEN.ContainerTypeName = objRow[convViewRegion.ContainerTypeName] == DBNull.Value ? null : objRow[convViewRegion.ContainerTypeName].ToString().Trim(); //容器类型名
objvViewRegionEN.PageDispModeName = objRow[convViewRegion.PageDispModeName] == DBNull.Value ? null : objRow[convViewRegion.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvViewRegionEN.InOutTypeName = objRow[convViewRegion.InOutTypeName] == DBNull.Value ? null : objRow[convViewRegion.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvViewRegionEN.TabName = objRow[convViewRegion.TabName] == DBNull.Value ? null : objRow[convViewRegion.TabName].ToString().Trim(); //表名
objvViewRegionEN.ApplicationTypeSimName = objRow[convViewRegion.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convViewRegion.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvViewRegionEN.RegionTypeOrderNum = objRow[convViewRegion.RegionTypeOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.RegionTypeOrderNum].ToString().Trim()); //区域类型序号
objvViewRegionEN.RegionTypeName = objRow[convViewRegion.RegionTypeName].ToString().Trim(); //区域类型名称
objvViewRegionEN.ClsName = objRow[convViewRegion.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewRegionEN.RegionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewRegionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvViewRegionEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvViewRegionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvViewRegionEN> arrObjLst = new List<clsvViewRegionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewRegionEN objvViewRegionEN = new clsvViewRegionEN();
try
{
objvViewRegionEN.RegionId = objRow[convViewRegion.RegionId].ToString().Trim(); //区域Id
objvViewRegionEN.RegionName = objRow[convViewRegion.RegionName].ToString().Trim(); //区域名称
objvViewRegionEN.RegionTypeId = objRow[convViewRegion.RegionTypeId].ToString().Trim(); //区域类型Id
objvViewRegionEN.FileName = objRow[convViewRegion.FileName] == DBNull.Value ? null : objRow[convViewRegion.FileName].ToString().Trim(); //文件名
objvViewRegionEN.Height = objRow[convViewRegion.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.Height].ToString().Trim()); //高度
objvViewRegionEN.Width = objRow[convViewRegion.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.Width].ToString().Trim()); //宽
objvViewRegionEN.ColNum = objRow[convViewRegion.ColNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.ColNum].ToString().Trim()); //列数
objvViewRegionEN.ContainerTypeId = objRow[convViewRegion.ContainerTypeId] == DBNull.Value ? null : objRow[convViewRegion.ContainerTypeId].ToString().Trim(); //容器类型Id
objvViewRegionEN.PageDispModeId = objRow[convViewRegion.PageDispModeId] == DBNull.Value ? null : objRow[convViewRegion.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvViewRegionEN.InOutTypeId = objRow[convViewRegion.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvViewRegionEN.InOutTypeENName = objRow[convViewRegion.InOutTypeENName] == DBNull.Value ? null : objRow[convViewRegion.InOutTypeENName].ToString().Trim(); //INOUT类型英文名
objvViewRegionEN.TabId = objRow[convViewRegion.TabId].ToString().Trim(); //表ID
objvViewRegionEN.ApplicationTypeId = objRow[convViewRegion.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewRegionEN.KeyId4Test = objRow[convViewRegion.KeyId4Test] == DBNull.Value ? null : objRow[convViewRegion.KeyId4Test].ToString().Trim(); //测试关键字Id
objvViewRegionEN.PrjId = objRow[convViewRegion.PrjId].ToString().Trim(); //工程Id
objvViewRegionEN.UpdUser = objRow[convViewRegion.UpdUser] == DBNull.Value ? null : objRow[convViewRegion.UpdUser].ToString().Trim(); //修改者
objvViewRegionEN.UpdDate = objRow[convViewRegion.UpdDate] == DBNull.Value ? null : objRow[convViewRegion.UpdDate].ToString().Trim(); //修改日期
objvViewRegionEN.Memo = objRow[convViewRegion.Memo] == DBNull.Value ? null : objRow[convViewRegion.Memo].ToString().Trim(); //说明
objvViewRegionEN.RegionTypeSimName = objRow[convViewRegion.RegionTypeSimName] == DBNull.Value ? null : objRow[convViewRegion.RegionTypeSimName].ToString().Trim(); //区域类型简名
objvViewRegionEN.ContainerTypeName = objRow[convViewRegion.ContainerTypeName] == DBNull.Value ? null : objRow[convViewRegion.ContainerTypeName].ToString().Trim(); //容器类型名
objvViewRegionEN.PageDispModeName = objRow[convViewRegion.PageDispModeName] == DBNull.Value ? null : objRow[convViewRegion.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvViewRegionEN.InOutTypeName = objRow[convViewRegion.InOutTypeName] == DBNull.Value ? null : objRow[convViewRegion.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvViewRegionEN.TabName = objRow[convViewRegion.TabName] == DBNull.Value ? null : objRow[convViewRegion.TabName].ToString().Trim(); //表名
objvViewRegionEN.ApplicationTypeSimName = objRow[convViewRegion.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convViewRegion.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvViewRegionEN.RegionTypeOrderNum = objRow[convViewRegion.RegionTypeOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.RegionTypeOrderNum].ToString().Trim()); //区域类型序号
objvViewRegionEN.RegionTypeName = objRow[convViewRegion.RegionTypeName].ToString().Trim(); //区域类型名称
objvViewRegionEN.ClsName = objRow[convViewRegion.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewRegionEN.RegionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewRegionEN);
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
public static List<clsvViewRegionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvViewRegionEN> arrObjLst = new List<clsvViewRegionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewRegionEN objvViewRegionEN = new clsvViewRegionEN();
try
{
objvViewRegionEN.RegionId = objRow[convViewRegion.RegionId].ToString().Trim(); //区域Id
objvViewRegionEN.RegionName = objRow[convViewRegion.RegionName].ToString().Trim(); //区域名称
objvViewRegionEN.RegionTypeId = objRow[convViewRegion.RegionTypeId].ToString().Trim(); //区域类型Id
objvViewRegionEN.FileName = objRow[convViewRegion.FileName] == DBNull.Value ? null : objRow[convViewRegion.FileName].ToString().Trim(); //文件名
objvViewRegionEN.Height = objRow[convViewRegion.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.Height].ToString().Trim()); //高度
objvViewRegionEN.Width = objRow[convViewRegion.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.Width].ToString().Trim()); //宽
objvViewRegionEN.ColNum = objRow[convViewRegion.ColNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.ColNum].ToString().Trim()); //列数
objvViewRegionEN.ContainerTypeId = objRow[convViewRegion.ContainerTypeId] == DBNull.Value ? null : objRow[convViewRegion.ContainerTypeId].ToString().Trim(); //容器类型Id
objvViewRegionEN.PageDispModeId = objRow[convViewRegion.PageDispModeId] == DBNull.Value ? null : objRow[convViewRegion.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvViewRegionEN.InOutTypeId = objRow[convViewRegion.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvViewRegionEN.InOutTypeENName = objRow[convViewRegion.InOutTypeENName] == DBNull.Value ? null : objRow[convViewRegion.InOutTypeENName].ToString().Trim(); //INOUT类型英文名
objvViewRegionEN.TabId = objRow[convViewRegion.TabId].ToString().Trim(); //表ID
objvViewRegionEN.ApplicationTypeId = objRow[convViewRegion.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewRegionEN.KeyId4Test = objRow[convViewRegion.KeyId4Test] == DBNull.Value ? null : objRow[convViewRegion.KeyId4Test].ToString().Trim(); //测试关键字Id
objvViewRegionEN.PrjId = objRow[convViewRegion.PrjId].ToString().Trim(); //工程Id
objvViewRegionEN.UpdUser = objRow[convViewRegion.UpdUser] == DBNull.Value ? null : objRow[convViewRegion.UpdUser].ToString().Trim(); //修改者
objvViewRegionEN.UpdDate = objRow[convViewRegion.UpdDate] == DBNull.Value ? null : objRow[convViewRegion.UpdDate].ToString().Trim(); //修改日期
objvViewRegionEN.Memo = objRow[convViewRegion.Memo] == DBNull.Value ? null : objRow[convViewRegion.Memo].ToString().Trim(); //说明
objvViewRegionEN.RegionTypeSimName = objRow[convViewRegion.RegionTypeSimName] == DBNull.Value ? null : objRow[convViewRegion.RegionTypeSimName].ToString().Trim(); //区域类型简名
objvViewRegionEN.ContainerTypeName = objRow[convViewRegion.ContainerTypeName] == DBNull.Value ? null : objRow[convViewRegion.ContainerTypeName].ToString().Trim(); //容器类型名
objvViewRegionEN.PageDispModeName = objRow[convViewRegion.PageDispModeName] == DBNull.Value ? null : objRow[convViewRegion.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvViewRegionEN.InOutTypeName = objRow[convViewRegion.InOutTypeName] == DBNull.Value ? null : objRow[convViewRegion.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvViewRegionEN.TabName = objRow[convViewRegion.TabName] == DBNull.Value ? null : objRow[convViewRegion.TabName].ToString().Trim(); //表名
objvViewRegionEN.ApplicationTypeSimName = objRow[convViewRegion.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convViewRegion.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvViewRegionEN.RegionTypeOrderNum = objRow[convViewRegion.RegionTypeOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.RegionTypeOrderNum].ToString().Trim()); //区域类型序号
objvViewRegionEN.RegionTypeName = objRow[convViewRegion.RegionTypeName].ToString().Trim(); //区域类型名称
objvViewRegionEN.ClsName = objRow[convViewRegion.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewRegionEN.RegionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewRegionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewRegionEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvViewRegionEN> arrObjLst = new List<clsvViewRegionEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewRegionEN objvViewRegionEN = new clsvViewRegionEN();
try
{
objvViewRegionEN.RegionId = objRow[convViewRegion.RegionId].ToString().Trim(); //区域Id
objvViewRegionEN.RegionName = objRow[convViewRegion.RegionName].ToString().Trim(); //区域名称
objvViewRegionEN.RegionTypeId = objRow[convViewRegion.RegionTypeId].ToString().Trim(); //区域类型Id
objvViewRegionEN.FileName = objRow[convViewRegion.FileName] == DBNull.Value ? null : objRow[convViewRegion.FileName].ToString().Trim(); //文件名
objvViewRegionEN.Height = objRow[convViewRegion.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.Height].ToString().Trim()); //高度
objvViewRegionEN.Width = objRow[convViewRegion.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.Width].ToString().Trim()); //宽
objvViewRegionEN.ColNum = objRow[convViewRegion.ColNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.ColNum].ToString().Trim()); //列数
objvViewRegionEN.ContainerTypeId = objRow[convViewRegion.ContainerTypeId] == DBNull.Value ? null : objRow[convViewRegion.ContainerTypeId].ToString().Trim(); //容器类型Id
objvViewRegionEN.PageDispModeId = objRow[convViewRegion.PageDispModeId] == DBNull.Value ? null : objRow[convViewRegion.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvViewRegionEN.InOutTypeId = objRow[convViewRegion.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvViewRegionEN.InOutTypeENName = objRow[convViewRegion.InOutTypeENName] == DBNull.Value ? null : objRow[convViewRegion.InOutTypeENName].ToString().Trim(); //INOUT类型英文名
objvViewRegionEN.TabId = objRow[convViewRegion.TabId].ToString().Trim(); //表ID
objvViewRegionEN.ApplicationTypeId = objRow[convViewRegion.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewRegionEN.KeyId4Test = objRow[convViewRegion.KeyId4Test] == DBNull.Value ? null : objRow[convViewRegion.KeyId4Test].ToString().Trim(); //测试关键字Id
objvViewRegionEN.PrjId = objRow[convViewRegion.PrjId].ToString().Trim(); //工程Id
objvViewRegionEN.UpdUser = objRow[convViewRegion.UpdUser] == DBNull.Value ? null : objRow[convViewRegion.UpdUser].ToString().Trim(); //修改者
objvViewRegionEN.UpdDate = objRow[convViewRegion.UpdDate] == DBNull.Value ? null : objRow[convViewRegion.UpdDate].ToString().Trim(); //修改日期
objvViewRegionEN.Memo = objRow[convViewRegion.Memo] == DBNull.Value ? null : objRow[convViewRegion.Memo].ToString().Trim(); //说明
objvViewRegionEN.RegionTypeSimName = objRow[convViewRegion.RegionTypeSimName] == DBNull.Value ? null : objRow[convViewRegion.RegionTypeSimName].ToString().Trim(); //区域类型简名
objvViewRegionEN.ContainerTypeName = objRow[convViewRegion.ContainerTypeName] == DBNull.Value ? null : objRow[convViewRegion.ContainerTypeName].ToString().Trim(); //容器类型名
objvViewRegionEN.PageDispModeName = objRow[convViewRegion.PageDispModeName] == DBNull.Value ? null : objRow[convViewRegion.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvViewRegionEN.InOutTypeName = objRow[convViewRegion.InOutTypeName] == DBNull.Value ? null : objRow[convViewRegion.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvViewRegionEN.TabName = objRow[convViewRegion.TabName] == DBNull.Value ? null : objRow[convViewRegion.TabName].ToString().Trim(); //表名
objvViewRegionEN.ApplicationTypeSimName = objRow[convViewRegion.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convViewRegion.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvViewRegionEN.RegionTypeOrderNum = objRow[convViewRegion.RegionTypeOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.RegionTypeOrderNum].ToString().Trim()); //区域类型序号
objvViewRegionEN.RegionTypeName = objRow[convViewRegion.RegionTypeName].ToString().Trim(); //区域类型名称
objvViewRegionEN.ClsName = objRow[convViewRegion.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewRegionEN.RegionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewRegionEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvViewRegionEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvViewRegion(ref clsvViewRegionEN objvViewRegionEN)
{
bool bolResult = vViewRegionDA.GetvViewRegion(ref objvViewRegionEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strRegionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvViewRegionEN GetObjByRegionId(string strRegionId)
{
if (strRegionId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strRegionId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strRegionId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strRegionId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvViewRegionEN objvViewRegionEN = vViewRegionDA.GetObjByRegionId(strRegionId);
return objvViewRegionEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvViewRegionEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvViewRegionEN objvViewRegionEN = vViewRegionDA.GetFirstObj(strWhereCond);
 return objvViewRegionEN;
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
public static clsvViewRegionEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvViewRegionEN objvViewRegionEN = vViewRegionDA.GetObjByDataRow(objRow);
 return objvViewRegionEN;
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
public static clsvViewRegionEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvViewRegionEN objvViewRegionEN = vViewRegionDA.GetObjByDataRow(objRow);
 return objvViewRegionEN;
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
 /// <param name = "strRegionId">所给的关键字</param>
 /// <param name = "lstvViewRegionObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvViewRegionEN GetObjByRegionIdFromList(string strRegionId, List<clsvViewRegionEN> lstvViewRegionObjLst)
{
foreach (clsvViewRegionEN objvViewRegionEN in lstvViewRegionObjLst)
{
if (objvViewRegionEN.RegionId == strRegionId)
{
return objvViewRegionEN;
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
public static string GetFirstID_S(string strWhereCond) 
{
 string strRegionId;
 try
 {
 strRegionId = new clsvViewRegionDA().GetFirstID(strWhereCond);
 return strRegionId;
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
 arrList = vViewRegionDA.GetID(strWhereCond);
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
bool bolIsExist = vViewRegionDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strRegionId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strRegionId)
{
if (string.IsNullOrEmpty(strRegionId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strRegionId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vViewRegionDA.IsExist(strRegionId);
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
 bolIsExist = clsvViewRegionDA.IsExistTable();
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
 bolIsExist = vViewRegionDA.IsExistTable(strTabName);
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
 /// <param name = "objvViewRegionEN">源简化对象</param>
 public static void SetUpdFlag(clsvViewRegionEN objvViewRegionEN)
{
try
{
objvViewRegionEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvViewRegionEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convViewRegion.RegionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRegionEN.RegionId = objvViewRegionEN.RegionId; //区域Id
}
if (arrFldSet.Contains(convViewRegion.RegionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRegionEN.RegionName = objvViewRegionEN.RegionName; //区域名称
}
if (arrFldSet.Contains(convViewRegion.RegionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRegionEN.RegionTypeId = objvViewRegionEN.RegionTypeId; //区域类型Id
}
if (arrFldSet.Contains(convViewRegion.FileName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRegionEN.FileName = objvViewRegionEN.FileName == "[null]" ? null :  objvViewRegionEN.FileName; //文件名
}
if (arrFldSet.Contains(convViewRegion.Height, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRegionEN.Height = objvViewRegionEN.Height; //高度
}
if (arrFldSet.Contains(convViewRegion.Width, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRegionEN.Width = objvViewRegionEN.Width; //宽
}
if (arrFldSet.Contains(convViewRegion.ColNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRegionEN.ColNum = objvViewRegionEN.ColNum; //列数
}
if (arrFldSet.Contains(convViewRegion.ContainerTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRegionEN.ContainerTypeId = objvViewRegionEN.ContainerTypeId == "[null]" ? null :  objvViewRegionEN.ContainerTypeId; //容器类型Id
}
if (arrFldSet.Contains(convViewRegion.PageDispModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRegionEN.PageDispModeId = objvViewRegionEN.PageDispModeId == "[null]" ? null :  objvViewRegionEN.PageDispModeId; //页面显示模式Id
}
if (arrFldSet.Contains(convViewRegion.InOutTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRegionEN.InOutTypeId = objvViewRegionEN.InOutTypeId; //INOUT类型ID
}
if (arrFldSet.Contains(convViewRegion.InOutTypeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRegionEN.InOutTypeENName = objvViewRegionEN.InOutTypeENName == "[null]" ? null :  objvViewRegionEN.InOutTypeENName; //INOUT类型英文名
}
if (arrFldSet.Contains(convViewRegion.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRegionEN.TabId = objvViewRegionEN.TabId; //表ID
}
if (arrFldSet.Contains(convViewRegion.ApplicationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRegionEN.ApplicationTypeId = objvViewRegionEN.ApplicationTypeId; //应用程序类型ID
}
if (arrFldSet.Contains(convViewRegion.KeyId4Test, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRegionEN.KeyId4Test = objvViewRegionEN.KeyId4Test == "[null]" ? null :  objvViewRegionEN.KeyId4Test; //测试关键字Id
}
if (arrFldSet.Contains(convViewRegion.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRegionEN.PrjId = objvViewRegionEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convViewRegion.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRegionEN.UpdUser = objvViewRegionEN.UpdUser == "[null]" ? null :  objvViewRegionEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convViewRegion.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRegionEN.UpdDate = objvViewRegionEN.UpdDate == "[null]" ? null :  objvViewRegionEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convViewRegion.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRegionEN.Memo = objvViewRegionEN.Memo == "[null]" ? null :  objvViewRegionEN.Memo; //说明
}
if (arrFldSet.Contains(convViewRegion.RegionTypeSimName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRegionEN.RegionTypeSimName = objvViewRegionEN.RegionTypeSimName == "[null]" ? null :  objvViewRegionEN.RegionTypeSimName; //区域类型简名
}
if (arrFldSet.Contains(convViewRegion.ContainerTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRegionEN.ContainerTypeName = objvViewRegionEN.ContainerTypeName == "[null]" ? null :  objvViewRegionEN.ContainerTypeName; //容器类型名
}
if (arrFldSet.Contains(convViewRegion.PageDispModeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRegionEN.PageDispModeName = objvViewRegionEN.PageDispModeName == "[null]" ? null :  objvViewRegionEN.PageDispModeName; //页面显示模式名称
}
if (arrFldSet.Contains(convViewRegion.InOutTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRegionEN.InOutTypeName = objvViewRegionEN.InOutTypeName == "[null]" ? null :  objvViewRegionEN.InOutTypeName; //INOUT类型名称
}
if (arrFldSet.Contains(convViewRegion.TabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRegionEN.TabName = objvViewRegionEN.TabName == "[null]" ? null :  objvViewRegionEN.TabName; //表名
}
if (arrFldSet.Contains(convViewRegion.ApplicationTypeSimName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRegionEN.ApplicationTypeSimName = objvViewRegionEN.ApplicationTypeSimName == "[null]" ? null :  objvViewRegionEN.ApplicationTypeSimName; //应用程序类型简称
}
if (arrFldSet.Contains(convViewRegion.RegionTypeOrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRegionEN.RegionTypeOrderNum = objvViewRegionEN.RegionTypeOrderNum; //区域类型序号
}
if (arrFldSet.Contains(convViewRegion.RegionTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRegionEN.RegionTypeName = objvViewRegionEN.RegionTypeName; //区域类型名称
}
if (arrFldSet.Contains(convViewRegion.ClsName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewRegionEN.ClsName = objvViewRegionEN.ClsName; //类名
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
 /// <param name = "objvViewRegionEN">源简化对象</param>
 public static void AccessFldValueNull(clsvViewRegionEN objvViewRegionEN)
{
try
{
if (objvViewRegionEN.FileName == "[null]") objvViewRegionEN.FileName = null; //文件名
if (objvViewRegionEN.ContainerTypeId == "[null]") objvViewRegionEN.ContainerTypeId = null; //容器类型Id
if (objvViewRegionEN.PageDispModeId == "[null]") objvViewRegionEN.PageDispModeId = null; //页面显示模式Id
if (objvViewRegionEN.InOutTypeENName == "[null]") objvViewRegionEN.InOutTypeENName = null; //INOUT类型英文名
if (objvViewRegionEN.KeyId4Test == "[null]") objvViewRegionEN.KeyId4Test = null; //测试关键字Id
if (objvViewRegionEN.UpdUser == "[null]") objvViewRegionEN.UpdUser = null; //修改者
if (objvViewRegionEN.UpdDate == "[null]") objvViewRegionEN.UpdDate = null; //修改日期
if (objvViewRegionEN.Memo == "[null]") objvViewRegionEN.Memo = null; //说明
if (objvViewRegionEN.RegionTypeSimName == "[null]") objvViewRegionEN.RegionTypeSimName = null; //区域类型简名
if (objvViewRegionEN.ContainerTypeName == "[null]") objvViewRegionEN.ContainerTypeName = null; //容器类型名
if (objvViewRegionEN.PageDispModeName == "[null]") objvViewRegionEN.PageDispModeName = null; //页面显示模式名称
if (objvViewRegionEN.InOutTypeName == "[null]") objvViewRegionEN.InOutTypeName = null; //INOUT类型名称
if (objvViewRegionEN.TabName == "[null]") objvViewRegionEN.TabName = null; //表名
if (objvViewRegionEN.ApplicationTypeSimName == "[null]") objvViewRegionEN.ApplicationTypeSimName = null; //应用程序类型简称
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
public static void CheckProperty4Condition(clsvViewRegionEN objvViewRegionEN)
{
 vViewRegionDA.CheckProperty4Condition(objvViewRegionEN);
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
//string strWhereCond = string.Format("1 = 1 order by RegionId");
//if (arrvViewRegionObjLstCache == null)
//{
//arrvViewRegionObjLstCache = vViewRegionDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strRegionId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvViewRegionEN GetObjByRegionIdCache(string strRegionId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvViewRegionEN._CurrTabName, strPrjId);
List<clsvViewRegionEN> arrvViewRegionObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvViewRegionEN> arrvViewRegionObjLst_Sel =
arrvViewRegionObjLstCache
.Where(x=> x.RegionId == strRegionId 
);
if (arrvViewRegionObjLst_Sel.Count() == 0)
{
   clsvViewRegionEN obj = clsvViewRegionBL.GetObjByRegionId(strRegionId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strRegionId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvViewRegionObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvViewRegionEN> GetAllvViewRegionObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvViewRegionEN> arrvViewRegionObjLstCache = GetObjLstCache(strPrjId); 
return arrvViewRegionObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvViewRegionEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvViewRegionEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsvViewRegionEN> arrvViewRegionObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvViewRegionObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvViewRegionEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsvViewRegionEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
/// <summary>
/// 获取最新的缓存刷新时间
/// </summary>
/// <returns>最新的缓存刷新时间，字符串型</returns>
public static string GetLastRefreshTime()
{
if (clsvViewRegionEN._RefreshTimeLst.Count == 0) return "";
return clsvViewRegionEN._RefreshTimeLst[clsvViewRegionEN._RefreshTimeLst.Count - 1];
}


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2025-08-09
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strRegionId, string strPrjId)
{
if (strInFldName != convViewRegion.RegionId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convViewRegion._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convViewRegion._AttributeName));
throw new Exception(strMsg);
}
var objvViewRegion = clsvViewRegionBL.GetObjByRegionIdCache(strRegionId, strPrjId);
if (objvViewRegion == null) return "";
return objvViewRegion[strOutFldName].ToString();
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
int intRecCount = clsvViewRegionDA.GetRecCount(strTabName);
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
int intRecCount = clsvViewRegionDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvViewRegionDA.GetRecCount();
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
int intRecCount = clsvViewRegionDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvViewRegionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvViewRegionEN objvViewRegionCond)
{
 string strPrjId = objvViewRegionCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvViewRegionBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvViewRegionEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvViewRegionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convViewRegion._AttributeName)
{
if (objvViewRegionCond.IsUpdated(strFldName) == false) continue;
if (objvViewRegionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewRegionCond[strFldName].ToString());
}
else
{
if (objvViewRegionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvViewRegionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewRegionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvViewRegionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvViewRegionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvViewRegionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvViewRegionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvViewRegionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvViewRegionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvViewRegionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvViewRegionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvViewRegionCond[strFldName]));
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
 List<string> arrList = clsvViewRegionDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vViewRegionDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vViewRegionDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数


 #region 排序相关函数


 #endregion 排序相关函数
}
}