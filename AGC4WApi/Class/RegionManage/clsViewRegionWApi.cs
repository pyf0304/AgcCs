
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewRegionWApi
 表名:ViewRegion(00050099)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 21:38:19
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
public static class  clsViewRegionWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionId">区域Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRegionEN SetRegionId(this clsViewRegionEN objViewRegionEN, string strRegionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRegionId, 10, conViewRegion.RegionId);
clsCheckSql.CheckFieldForeignKey(strRegionId, 10, conViewRegion.RegionId);
objViewRegionEN.RegionId = strRegionId; //区域Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRegionEN.dicFldComparisonOp.ContainsKey(conViewRegion.RegionId) == false)
{
objViewRegionEN.dicFldComparisonOp.Add(conViewRegion.RegionId, strComparisonOp);
}
else
{
objViewRegionEN.dicFldComparisonOp[conViewRegion.RegionId] = strComparisonOp;
}
}
return objViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionName">区域名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRegionEN SetRegionName(this clsViewRegionEN objViewRegionEN, string strRegionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionName, conViewRegion.RegionName);
clsCheckSql.CheckFieldLen(strRegionName, 50, conViewRegion.RegionName);
objViewRegionEN.RegionName = strRegionName; //区域名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRegionEN.dicFldComparisonOp.ContainsKey(conViewRegion.RegionName) == false)
{
objViewRegionEN.dicFldComparisonOp.Add(conViewRegion.RegionName, strComparisonOp);
}
else
{
objViewRegionEN.dicFldComparisonOp[conViewRegion.RegionName] = strComparisonOp;
}
}
return objViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionTypeId">区域类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRegionEN SetRegionTypeId(this clsViewRegionEN objViewRegionEN, string strRegionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionTypeId, conViewRegion.RegionTypeId);
clsCheckSql.CheckFieldLen(strRegionTypeId, 4, conViewRegion.RegionTypeId);
clsCheckSql.CheckFieldForeignKey(strRegionTypeId, 4, conViewRegion.RegionTypeId);
objViewRegionEN.RegionTypeId = strRegionTypeId; //区域类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRegionEN.dicFldComparisonOp.ContainsKey(conViewRegion.RegionTypeId) == false)
{
objViewRegionEN.dicFldComparisonOp.Add(conViewRegion.RegionTypeId, strComparisonOp);
}
else
{
objViewRegionEN.dicFldComparisonOp[conViewRegion.RegionTypeId] = strComparisonOp;
}
}
return objViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strFileName">文件名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRegionEN SetFileName(this clsViewRegionEN objViewRegionEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileName, 150, conViewRegion.FileName);
objViewRegionEN.FileName = strFileName; //文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRegionEN.dicFldComparisonOp.ContainsKey(conViewRegion.FileName) == false)
{
objViewRegionEN.dicFldComparisonOp.Add(conViewRegion.FileName, strComparisonOp);
}
else
{
objViewRegionEN.dicFldComparisonOp[conViewRegion.FileName] = strComparisonOp;
}
}
return objViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "intHeight">高度</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRegionEN SetHeight(this clsViewRegionEN objViewRegionEN, int intHeight, string strComparisonOp="")
	{
objViewRegionEN.Height = intHeight; //高度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRegionEN.dicFldComparisonOp.ContainsKey(conViewRegion.Height) == false)
{
objViewRegionEN.dicFldComparisonOp.Add(conViewRegion.Height, strComparisonOp);
}
else
{
objViewRegionEN.dicFldComparisonOp[conViewRegion.Height] = strComparisonOp;
}
}
return objViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "intWidth">宽</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRegionEN SetWidth(this clsViewRegionEN objViewRegionEN, int intWidth, string strComparisonOp="")
	{
objViewRegionEN.Width = intWidth; //宽
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRegionEN.dicFldComparisonOp.ContainsKey(conViewRegion.Width) == false)
{
objViewRegionEN.dicFldComparisonOp.Add(conViewRegion.Width, strComparisonOp);
}
else
{
objViewRegionEN.dicFldComparisonOp[conViewRegion.Width] = strComparisonOp;
}
}
return objViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "intColNum">列数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRegionEN SetColNum(this clsViewRegionEN objViewRegionEN, int intColNum, string strComparisonOp="")
	{
objViewRegionEN.ColNum = intColNum; //列数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRegionEN.dicFldComparisonOp.ContainsKey(conViewRegion.ColNum) == false)
{
objViewRegionEN.dicFldComparisonOp.Add(conViewRegion.ColNum, strComparisonOp);
}
else
{
objViewRegionEN.dicFldComparisonOp[conViewRegion.ColNum] = strComparisonOp;
}
}
return objViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strContainerTypeId">容器类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRegionEN SetContainerTypeId(this clsViewRegionEN objViewRegionEN, string strContainerTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strContainerTypeId, 4, conViewRegion.ContainerTypeId);
clsCheckSql.CheckFieldForeignKey(strContainerTypeId, 4, conViewRegion.ContainerTypeId);
objViewRegionEN.ContainerTypeId = strContainerTypeId; //容器类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRegionEN.dicFldComparisonOp.ContainsKey(conViewRegion.ContainerTypeId) == false)
{
objViewRegionEN.dicFldComparisonOp.Add(conViewRegion.ContainerTypeId, strComparisonOp);
}
else
{
objViewRegionEN.dicFldComparisonOp[conViewRegion.ContainerTypeId] = strComparisonOp;
}
}
return objViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strPageDispModeId">页面显示模式Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRegionEN SetPageDispModeId(this clsViewRegionEN objViewRegionEN, string strPageDispModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPageDispModeId, 2, conViewRegion.PageDispModeId);
clsCheckSql.CheckFieldForeignKey(strPageDispModeId, 2, conViewRegion.PageDispModeId);
objViewRegionEN.PageDispModeId = strPageDispModeId; //页面显示模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRegionEN.dicFldComparisonOp.ContainsKey(conViewRegion.PageDispModeId) == false)
{
objViewRegionEN.dicFldComparisonOp.Add(conViewRegion.PageDispModeId, strComparisonOp);
}
else
{
objViewRegionEN.dicFldComparisonOp[conViewRegion.PageDispModeId] = strComparisonOp;
}
}
return objViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strInOutTypeId">INOUT类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRegionEN SetInOutTypeId(this clsViewRegionEN objViewRegionEN, string strInOutTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strInOutTypeId, conViewRegion.InOutTypeId);
clsCheckSql.CheckFieldLen(strInOutTypeId, 2, conViewRegion.InOutTypeId);
clsCheckSql.CheckFieldForeignKey(strInOutTypeId, 2, conViewRegion.InOutTypeId);
objViewRegionEN.InOutTypeId = strInOutTypeId; //INOUT类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRegionEN.dicFldComparisonOp.ContainsKey(conViewRegion.InOutTypeId) == false)
{
objViewRegionEN.dicFldComparisonOp.Add(conViewRegion.InOutTypeId, strComparisonOp);
}
else
{
objViewRegionEN.dicFldComparisonOp[conViewRegion.InOutTypeId] = strComparisonOp;
}
}
return objViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRegionEN SetTabId(this clsViewRegionEN objViewRegionEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, conViewRegion.TabId);
clsCheckSql.CheckFieldLen(strTabId, 8, conViewRegion.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, conViewRegion.TabId);
objViewRegionEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRegionEN.dicFldComparisonOp.ContainsKey(conViewRegion.TabId) == false)
{
objViewRegionEN.dicFldComparisonOp.Add(conViewRegion.TabId, strComparisonOp);
}
else
{
objViewRegionEN.dicFldComparisonOp[conViewRegion.TabId] = strComparisonOp;
}
}
return objViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strKeyId4Test">测试关键字Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRegionEN SetKeyId4Test(this clsViewRegionEN objViewRegionEN, string strKeyId4Test, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKeyId4Test, 50, conViewRegion.KeyId4Test);
objViewRegionEN.KeyId4Test = strKeyId4Test; //测试关键字Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRegionEN.dicFldComparisonOp.ContainsKey(conViewRegion.KeyId4Test) == false)
{
objViewRegionEN.dicFldComparisonOp.Add(conViewRegion.KeyId4Test, strComparisonOp);
}
else
{
objViewRegionEN.dicFldComparisonOp[conViewRegion.KeyId4Test] = strComparisonOp;
}
}
return objViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strErrMsg">错误信息</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRegionEN SetErrMsg(this clsViewRegionEN objViewRegionEN, string strErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strErrMsg, 2000, conViewRegion.ErrMsg);
objViewRegionEN.ErrMsg = strErrMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRegionEN.dicFldComparisonOp.ContainsKey(conViewRegion.ErrMsg) == false)
{
objViewRegionEN.dicFldComparisonOp.Add(conViewRegion.ErrMsg, strComparisonOp);
}
else
{
objViewRegionEN.dicFldComparisonOp[conViewRegion.ErrMsg] = strComparisonOp;
}
}
return objViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRegionEN SetPrjId(this clsViewRegionEN objViewRegionEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conViewRegion.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, conViewRegion.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conViewRegion.PrjId);
objViewRegionEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRegionEN.dicFldComparisonOp.ContainsKey(conViewRegion.PrjId) == false)
{
objViewRegionEN.dicFldComparisonOp.Add(conViewRegion.PrjId, strComparisonOp);
}
else
{
objViewRegionEN.dicFldComparisonOp[conViewRegion.PrjId] = strComparisonOp;
}
}
return objViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRegionEN SetUpdUser(this clsViewRegionEN objViewRegionEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conViewRegion.UpdUser);
objViewRegionEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRegionEN.dicFldComparisonOp.ContainsKey(conViewRegion.UpdUser) == false)
{
objViewRegionEN.dicFldComparisonOp.Add(conViewRegion.UpdUser, strComparisonOp);
}
else
{
objViewRegionEN.dicFldComparisonOp[conViewRegion.UpdUser] = strComparisonOp;
}
}
return objViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRegionEN SetUpdDate(this clsViewRegionEN objViewRegionEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conViewRegion.UpdDate);
objViewRegionEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRegionEN.dicFldComparisonOp.ContainsKey(conViewRegion.UpdDate) == false)
{
objViewRegionEN.dicFldComparisonOp.Add(conViewRegion.UpdDate, strComparisonOp);
}
else
{
objViewRegionEN.dicFldComparisonOp[conViewRegion.UpdDate] = strComparisonOp;
}
}
return objViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRegionEN SetMemo(this clsViewRegionEN objViewRegionEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conViewRegion.Memo);
objViewRegionEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRegionEN.dicFldComparisonOp.ContainsKey(conViewRegion.Memo) == false)
{
objViewRegionEN.dicFldComparisonOp.Add(conViewRegion.Memo, strComparisonOp);
}
else
{
objViewRegionEN.dicFldComparisonOp[conViewRegion.Memo] = strComparisonOp;
}
}
return objViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strClsName">类名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRegionEN SetClsName(this clsViewRegionEN objViewRegionEN, string strClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strClsName, conViewRegion.ClsName);
clsCheckSql.CheckFieldLen(strClsName, 100, conViewRegion.ClsName);
objViewRegionEN.ClsName = strClsName; //类名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRegionEN.dicFldComparisonOp.ContainsKey(conViewRegion.ClsName) == false)
{
objViewRegionEN.dicFldComparisonOp.Add(conViewRegion.ClsName, strComparisonOp);
}
else
{
objViewRegionEN.dicFldComparisonOp[conViewRegion.ClsName] = strComparisonOp;
}
}
return objViewRegionEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsViewRegionEN objViewRegionCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objViewRegionCond.IsUpdated(conViewRegion.RegionId) == true)
{
string strComparisonOpRegionId = objViewRegionCond.dicFldComparisonOp[conViewRegion.RegionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewRegion.RegionId, objViewRegionCond.RegionId, strComparisonOpRegionId);
}
if (objViewRegionCond.IsUpdated(conViewRegion.RegionName) == true)
{
string strComparisonOpRegionName = objViewRegionCond.dicFldComparisonOp[conViewRegion.RegionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewRegion.RegionName, objViewRegionCond.RegionName, strComparisonOpRegionName);
}
if (objViewRegionCond.IsUpdated(conViewRegion.RegionTypeId) == true)
{
string strComparisonOpRegionTypeId = objViewRegionCond.dicFldComparisonOp[conViewRegion.RegionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewRegion.RegionTypeId, objViewRegionCond.RegionTypeId, strComparisonOpRegionTypeId);
}
if (objViewRegionCond.IsUpdated(conViewRegion.FileName) == true)
{
string strComparisonOpFileName = objViewRegionCond.dicFldComparisonOp[conViewRegion.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewRegion.FileName, objViewRegionCond.FileName, strComparisonOpFileName);
}
if (objViewRegionCond.IsUpdated(conViewRegion.Height) == true)
{
string strComparisonOpHeight = objViewRegionCond.dicFldComparisonOp[conViewRegion.Height];
strWhereCond += string.Format(" And {0} {2} {1}", conViewRegion.Height, objViewRegionCond.Height, strComparisonOpHeight);
}
if (objViewRegionCond.IsUpdated(conViewRegion.Width) == true)
{
string strComparisonOpWidth = objViewRegionCond.dicFldComparisonOp[conViewRegion.Width];
strWhereCond += string.Format(" And {0} {2} {1}", conViewRegion.Width, objViewRegionCond.Width, strComparisonOpWidth);
}
if (objViewRegionCond.IsUpdated(conViewRegion.ColNum) == true)
{
string strComparisonOpColNum = objViewRegionCond.dicFldComparisonOp[conViewRegion.ColNum];
strWhereCond += string.Format(" And {0} {2} {1}", conViewRegion.ColNum, objViewRegionCond.ColNum, strComparisonOpColNum);
}
if (objViewRegionCond.IsUpdated(conViewRegion.ContainerTypeId) == true)
{
string strComparisonOpContainerTypeId = objViewRegionCond.dicFldComparisonOp[conViewRegion.ContainerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewRegion.ContainerTypeId, objViewRegionCond.ContainerTypeId, strComparisonOpContainerTypeId);
}
if (objViewRegionCond.IsUpdated(conViewRegion.PageDispModeId) == true)
{
string strComparisonOpPageDispModeId = objViewRegionCond.dicFldComparisonOp[conViewRegion.PageDispModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewRegion.PageDispModeId, objViewRegionCond.PageDispModeId, strComparisonOpPageDispModeId);
}
if (objViewRegionCond.IsUpdated(conViewRegion.InOutTypeId) == true)
{
string strComparisonOpInOutTypeId = objViewRegionCond.dicFldComparisonOp[conViewRegion.InOutTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewRegion.InOutTypeId, objViewRegionCond.InOutTypeId, strComparisonOpInOutTypeId);
}
if (objViewRegionCond.IsUpdated(conViewRegion.TabId) == true)
{
string strComparisonOpTabId = objViewRegionCond.dicFldComparisonOp[conViewRegion.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewRegion.TabId, objViewRegionCond.TabId, strComparisonOpTabId);
}
if (objViewRegionCond.IsUpdated(conViewRegion.KeyId4Test) == true)
{
string strComparisonOpKeyId4Test = objViewRegionCond.dicFldComparisonOp[conViewRegion.KeyId4Test];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewRegion.KeyId4Test, objViewRegionCond.KeyId4Test, strComparisonOpKeyId4Test);
}
if (objViewRegionCond.IsUpdated(conViewRegion.ErrMsg) == true)
{
string strComparisonOpErrMsg = objViewRegionCond.dicFldComparisonOp[conViewRegion.ErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewRegion.ErrMsg, objViewRegionCond.ErrMsg, strComparisonOpErrMsg);
}
if (objViewRegionCond.IsUpdated(conViewRegion.PrjId) == true)
{
string strComparisonOpPrjId = objViewRegionCond.dicFldComparisonOp[conViewRegion.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewRegion.PrjId, objViewRegionCond.PrjId, strComparisonOpPrjId);
}
if (objViewRegionCond.IsUpdated(conViewRegion.UpdUser) == true)
{
string strComparisonOpUpdUser = objViewRegionCond.dicFldComparisonOp[conViewRegion.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewRegion.UpdUser, objViewRegionCond.UpdUser, strComparisonOpUpdUser);
}
if (objViewRegionCond.IsUpdated(conViewRegion.UpdDate) == true)
{
string strComparisonOpUpdDate = objViewRegionCond.dicFldComparisonOp[conViewRegion.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewRegion.UpdDate, objViewRegionCond.UpdDate, strComparisonOpUpdDate);
}
if (objViewRegionCond.IsUpdated(conViewRegion.Memo) == true)
{
string strComparisonOpMemo = objViewRegionCond.dicFldComparisonOp[conViewRegion.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewRegion.Memo, objViewRegionCond.Memo, strComparisonOpMemo);
}
if (objViewRegionCond.IsUpdated(conViewRegion.ClsName) == true)
{
string strComparisonOpClsName = objViewRegionCond.dicFldComparisonOp[conViewRegion.ClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewRegion.ClsName, objViewRegionCond.ClsName, strComparisonOpClsName);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objViewRegionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsViewRegionEN objViewRegionEN)
{
 if (string.IsNullOrEmpty(objViewRegionEN.RegionId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objViewRegionEN.sfUpdFldSetStr = objViewRegionEN.getsfUpdFldSetStr();
clsViewRegionWApi.CheckPropertyNew(objViewRegionEN); 
bool bolResult = clsViewRegionWApi.UpdateRecord(objViewRegionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewRegionWApi.ReFreshCache(objViewRegionEN.PrjId);
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000004)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 获取唯一性条件串--ViewRegion(界面区域), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PrjId_ClsName
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objViewRegionEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsViewRegionEN objViewRegionEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objViewRegionEN == null) return "";
if (objViewRegionEN.RegionId == null || objViewRegionEN.RegionId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjId = '{0}'", objViewRegionEN.PrjId);
 sbCondition.AppendFormat(" and ClsName = '{0}'", objViewRegionEN.ClsName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("RegionId !=  '{0}'", objViewRegionEN.RegionId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objViewRegionEN.PrjId);
 sbCondition.AppendFormat(" and ClsName = '{0}'", objViewRegionEN.ClsName);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objViewRegionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsViewRegionEN objViewRegionEN)
{
try
{
 if (string.IsNullOrEmpty(objViewRegionEN.RegionId) == true || clsViewRegionWApi.IsExist(objViewRegionEN.RegionId) == true)
 {
     objViewRegionEN.RegionId = clsViewRegionWApi.GetMaxStrId();
 }
clsViewRegionWApi.CheckPropertyNew(objViewRegionEN); 
bool bolResult = clsViewRegionWApi.AddNewRecord(objViewRegionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewRegionWApi.ReFreshCache(objViewRegionEN.PrjId);
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000008)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值. 该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objViewRegionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsViewRegionEN objViewRegionEN)
{
try
{
clsViewRegionWApi.CheckPropertyNew(objViewRegionEN); 
string strRegionId = clsViewRegionWApi.AddNewRecordWithMaxId(objViewRegionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewRegionWApi.ReFreshCache(objViewRegionEN.PrjId);
return strRegionId;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000009)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objViewRegionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsViewRegionEN objViewRegionEN, string strWhereCond)
{
try
{
clsViewRegionWApi.CheckPropertyNew(objViewRegionEN); 
bool bolResult = clsViewRegionWApi.UpdateWithCondition(objViewRegionEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewRegionWApi.ReFreshCache(objViewRegionEN.PrjId);
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000007)根据条件修改记录出错, {1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// 界面区域(ViewRegion)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsViewRegionWApi
{
private static readonly string mstrApiControllerName = "ViewRegionApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4WApi = null;

 public clsViewRegionWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_RegionId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[界面区域]...","0");
List<clsViewRegionEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="RegionId";
objDDL.DataTextField="RegionName";
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strPrjId"></param>
public static void BindCbo_RegionId(System.Windows.Forms.ComboBox objComboBox , string strPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conViewRegion.RegionId); 
List<clsViewRegionEN> arrObjLst = clsViewRegionWApi.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsViewRegionEN objViewRegionEN = new clsViewRegionEN()
{
RegionId = "0",
RegionName = "选[界面区域]..."
};
arrObjLstSel.Insert(0, objViewRegionEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conViewRegion.RegionId;
objComboBox.DisplayMember = conViewRegion.RegionName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsViewRegionEN objViewRegionEN)
{
if (!Object.Equals(null, objViewRegionEN.RegionId) && GetStrLen(objViewRegionEN.RegionId) > 10)
{
 throw new Exception("字段[区域Id]的长度不能超过10!");
}
if (!Object.Equals(null, objViewRegionEN.RegionName) && GetStrLen(objViewRegionEN.RegionName) > 50)
{
 throw new Exception("字段[区域名称]的长度不能超过50!");
}
if (!Object.Equals(null, objViewRegionEN.RegionTypeId) && GetStrLen(objViewRegionEN.RegionTypeId) > 4)
{
 throw new Exception("字段[区域类型Id]的长度不能超过4!");
}
if (!Object.Equals(null, objViewRegionEN.FileName) && GetStrLen(objViewRegionEN.FileName) > 150)
{
 throw new Exception("字段[文件名]的长度不能超过150!");
}
if (!Object.Equals(null, objViewRegionEN.ContainerTypeId) && GetStrLen(objViewRegionEN.ContainerTypeId) > 4)
{
 throw new Exception("字段[容器类型Id]的长度不能超过4!");
}
if (!Object.Equals(null, objViewRegionEN.PageDispModeId) && GetStrLen(objViewRegionEN.PageDispModeId) > 2)
{
 throw new Exception("字段[页面显示模式Id]的长度不能超过2!");
}
if (!Object.Equals(null, objViewRegionEN.InOutTypeId) && GetStrLen(objViewRegionEN.InOutTypeId) > 2)
{
 throw new Exception("字段[INOUT类型ID]的长度不能超过2!");
}
if (!Object.Equals(null, objViewRegionEN.TabId) && GetStrLen(objViewRegionEN.TabId) > 8)
{
 throw new Exception("字段[表ID]的长度不能超过8!");
}
if (!Object.Equals(null, objViewRegionEN.KeyId4Test) && GetStrLen(objViewRegionEN.KeyId4Test) > 50)
{
 throw new Exception("字段[测试关键字Id]的长度不能超过50!");
}
if (!Object.Equals(null, objViewRegionEN.ErrMsg) && GetStrLen(objViewRegionEN.ErrMsg) > 2000)
{
 throw new Exception("字段[错误信息]的长度不能超过2000!");
}
if (!Object.Equals(null, objViewRegionEN.PrjId) && GetStrLen(objViewRegionEN.PrjId) > 4)
{
 throw new Exception("字段[工程Id]的长度不能超过4!");
}
if (!Object.Equals(null, objViewRegionEN.UpdUser) && GetStrLen(objViewRegionEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objViewRegionEN.UpdDate) && GetStrLen(objViewRegionEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objViewRegionEN.Memo) && GetStrLen(objViewRegionEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
if (!Object.Equals(null, objViewRegionEN.ClsName) && GetStrLen(objViewRegionEN.ClsName) > 100)
{
 throw new Exception("字段[类名]的长度不能超过100!");
}
 objViewRegionEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strRegionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsViewRegionEN GetObjByRegionId(string strRegionId)
{
if (strRegionId == "") return null;
string strAction = "GetObjByRegionId";
clsViewRegionEN objViewRegionEN;
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
objViewRegionEN = JsonConvert.DeserializeObject<clsViewRegionEN>(strJson);
return objViewRegionEN;
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
public static clsViewRegionEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsViewRegionEN objViewRegionEN;
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
objViewRegionEN = JsonConvert.DeserializeObject<clsViewRegionEN>(strJson);
return objViewRegionEN;
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
public static clsViewRegionEN GetObjByRegionIdCache(string strRegionId,string strPrjId)
{
if (string.IsNullOrEmpty(strRegionId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsViewRegionEN._CurrTabName, strPrjId);
List<clsViewRegionEN> arrViewRegionObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsViewRegionEN> arrViewRegionObjLst_Sel =
from objViewRegionEN in arrViewRegionObjLstCache
where objViewRegionEN.RegionId == strRegionId 
select objViewRegionEN;
if (arrViewRegionObjLst_Sel.Count() == 0)
{
   clsViewRegionEN obj = clsViewRegionWApi.GetObjByRegionId(strRegionId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrViewRegionObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strRegionId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetRegionNameByRegionIdCache(string strRegionId,string strPrjId)
{
if (string.IsNullOrEmpty(strRegionId) == true) return "";
//初始化列表缓存
List<clsViewRegionEN> arrViewRegionObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsViewRegionEN> arrViewRegionObjLst_Sel1 =
from objViewRegionEN in arrViewRegionObjLstCache
where objViewRegionEN.RegionId == strRegionId 
select objViewRegionEN;
List <clsViewRegionEN> arrViewRegionObjLst_Sel = new List<clsViewRegionEN>();
foreach (clsViewRegionEN obj in arrViewRegionObjLst_Sel1)
{
arrViewRegionObjLst_Sel.Add(obj);
}
if (arrViewRegionObjLst_Sel.Count > 0)
{
return arrViewRegionObjLst_Sel[0].RegionName;
}
string strErrMsgForGetObjById = string.Format("在ViewRegion对象缓存列表中,找不到记录[RegionId = {0}](函数:{1})", strRegionId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsViewRegionBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strRegionId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByRegionIdCache(string strRegionId,string strPrjId)
{
if (string.IsNullOrEmpty(strRegionId) == true) return "";
//初始化列表缓存
List<clsViewRegionEN> arrViewRegionObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsViewRegionEN> arrViewRegionObjLst_Sel1 =
from objViewRegionEN in arrViewRegionObjLstCache
where objViewRegionEN.RegionId == strRegionId 
select objViewRegionEN;
List <clsViewRegionEN> arrViewRegionObjLst_Sel = new List<clsViewRegionEN>();
foreach (clsViewRegionEN obj in arrViewRegionObjLst_Sel1)
{
arrViewRegionObjLst_Sel.Add(obj);
}
if (arrViewRegionObjLst_Sel.Count > 0)
{
return arrViewRegionObjLst_Sel[0].RegionName;
}
string strErrMsgForGetObjById = string.Format("在ViewRegion对象缓存列表中,找不到记录的相关名称[RegionId = {0}](函数:{1})", strRegionId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsViewRegionBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewRegionEN> GetObjLst(string strWhereCond)
{
 List<clsViewRegionEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsViewRegionEN>>(strJson);
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
public static List<clsViewRegionEN> GetObjLstByRegionIdLst(List<string> arrRegionId)
{
 List<clsViewRegionEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsViewRegionEN>>(strJson);
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
public static IEnumerable<clsViewRegionEN> GetObjLstByRegionIdLstCache(List<string> arrRegionId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsViewRegionEN._CurrTabName, strPrjId);
List<clsViewRegionEN> arrViewRegionObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsViewRegionEN> arrViewRegionObjLst_Sel =
from objViewRegionEN in arrViewRegionObjLstCache
where arrRegionId.Contains(objViewRegionEN.RegionId)
select objViewRegionEN;
return arrViewRegionObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewRegionEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsViewRegionEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsViewRegionEN>>(strJson);
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
public static List<clsViewRegionEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsViewRegionEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsViewRegionEN>>(strJson);
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
public static List<clsViewRegionEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsViewRegionEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsViewRegionEN>>(strJson);
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
public static List<clsViewRegionEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsViewRegionEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsViewRegionEN>>(strJson);
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
 /// 根据关键字删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecord(string strRegionId)
{
string strAction = "DelRecord";
try
{
 clsViewRegionEN objViewRegionEN = clsViewRegionWApi.GetObjByRegionId(strRegionId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strRegionId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsViewRegionWApi.ReFreshCache(objViewRegionEN.PrjId);
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecords)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecords(string strKeyIdLst)
{
string strAction = "DelRecords";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strKeyIdLst, out string strResult, out string strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelViewRegions(List<string> arrRegionId)
{
string strAction = "DelViewRegions";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrRegionId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
 clsViewRegionEN objViewRegionEN = clsViewRegionWApi.GetObjByRegionId(arrRegionId[0]);
clsViewRegionWApi.ReFreshCache(objViewRegionEN.PrjId);
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelViewRegionsByCond(string strWhereCond)
{
string strAction = "DelViewRegionsByCond";
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool AddNewRecord(clsViewRegionEN objViewRegionEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsViewRegionEN>(objViewRegionEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewRegionWApi.ReFreshCache(objViewRegionEN.PrjId);
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithMaxId)
 /// </summary>
 /// <returns>新建记录的关键字</returns>
public static string AddNewRecordWithMaxId(clsViewRegionEN objViewRegionEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsViewRegionEN>(objViewRegionEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewRegionWApi.ReFreshCache(objViewRegionEN.PrjId);
var strRegionId = (string)jobjReturn0["returnStr"];
return strRegionId;
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsViewRegionEN objViewRegionEN)
{
if (string.IsNullOrEmpty(objViewRegionEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objViewRegionEN.RegionId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsViewRegionEN>(objViewRegionEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateWithCondition)
 /// </summary>
 /// <param name = "objViewRegionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsViewRegionEN objViewRegionEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objViewRegionEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objViewRegionEN.RegionId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objViewRegionEN.RegionId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsViewRegionEN>(objViewRegionEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
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
 /// 根据条件设置字段值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_funSetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int SetFldValue(string strFldName, string strValue, string strWhereCond)
{
string strAction = "SetFldValue";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strValue"] = strValue,
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
string strMsg = string.Format("根据条件设置字段值,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId()
{
string strAction = "GetMaxStrId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
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
string strMsg = string.Format("获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefix(string strPrefix)
{
//检测记录是否存在
string strAction = "GetMaxStrIdByPrefix";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
{"strPrefix", strPrefix}
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
string strMsg = string.Format("根据前缀获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取字符串长度,其中汉字为2个字节,英文为1个字节
 /// (AutoGCLib.clsGeneCodeBase4Tab:GengetStrLen)
 /// </summary>
 /// <param name = "strTemp">给定的原字符串</param>
 /// <returns>返回字符串长度</returns>
public static int GetStrLen(string strTemp)
{
int len ;
byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
len = sarr.Length;//will output as 3+3*2 = 9
return len;
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objViewRegionENS">源对象</param>
 /// <param name = "objViewRegionENT">目标对象</param>
 public static void CopyTo(clsViewRegionEN objViewRegionENS, clsViewRegionEN objViewRegionENT)
{
try
{
objViewRegionENT.RegionId = objViewRegionENS.RegionId; //区域Id
objViewRegionENT.RegionName = objViewRegionENS.RegionName; //区域名称
objViewRegionENT.RegionTypeId = objViewRegionENS.RegionTypeId; //区域类型Id
objViewRegionENT.FileName = objViewRegionENS.FileName; //文件名
objViewRegionENT.Height = objViewRegionENS.Height; //高度
objViewRegionENT.Width = objViewRegionENS.Width; //宽
objViewRegionENT.ColNum = objViewRegionENS.ColNum; //列数
objViewRegionENT.ContainerTypeId = objViewRegionENS.ContainerTypeId; //容器类型Id
objViewRegionENT.PageDispModeId = objViewRegionENS.PageDispModeId; //页面显示模式Id
objViewRegionENT.InOutTypeId = objViewRegionENS.InOutTypeId; //INOUT类型ID
objViewRegionENT.TabId = objViewRegionENS.TabId; //表ID
objViewRegionENT.KeyId4Test = objViewRegionENS.KeyId4Test; //测试关键字Id
objViewRegionENT.ErrMsg = objViewRegionENS.ErrMsg; //错误信息
objViewRegionENT.PrjId = objViewRegionENS.PrjId; //工程Id
objViewRegionENT.UpdUser = objViewRegionENS.UpdUser; //修改者
objViewRegionENT.UpdDate = objViewRegionENS.UpdDate; //修改日期
objViewRegionENT.Memo = objViewRegionENS.Memo; //说明
objViewRegionENT.ClsName = objViewRegionENS.ClsName; //类名
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
public static DataTable ToDataTable(List<clsViewRegionEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsViewRegionEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsViewRegionEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsViewRegionEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsViewRegionEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsViewRegionEN._AttributeName)
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
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsViewRegionWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsViewRegionWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsViewRegionEN._CurrTabName, strPrjId);
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
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strPrjId)
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsViewRegionWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsViewRegionEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsViewRegionWApi.objCommFun4WApi.ReFreshCache(strPrjId.ToString());
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsViewRegionEN> GetObjLstCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsViewRegionWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsViewRegionWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsViewRegionEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsViewRegionEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",conViewRegion.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsViewRegionEN._CurrTabName, strPrjId);
List<clsViewRegionEN> arrViewRegionObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrViewRegionObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsViewRegionEN> GetObjLstCacheFromObjLst(string strPrjId,List<clsViewRegionEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsViewRegionWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsViewRegionWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsViewRegionEN._CurrTabName, strPrjId);
List<clsViewRegionEN> arrViewRegionObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrViewRegionObjLstCache = CacheHelper.Get<List<clsViewRegionEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrViewRegionObjLstCache = CacheHelper.Get<List<clsViewRegionEN>>(strKey);
}
return arrViewRegionObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsViewRegionEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conViewRegion.RegionId, Type.GetType("System.String"));
objDT.Columns.Add(conViewRegion.RegionName, Type.GetType("System.String"));
objDT.Columns.Add(conViewRegion.RegionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conViewRegion.FileName, Type.GetType("System.String"));
objDT.Columns.Add(conViewRegion.Height, Type.GetType("System.Int32"));
objDT.Columns.Add(conViewRegion.Width, Type.GetType("System.Int32"));
objDT.Columns.Add(conViewRegion.ColNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conViewRegion.ContainerTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conViewRegion.PageDispModeId, Type.GetType("System.String"));
objDT.Columns.Add(conViewRegion.InOutTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conViewRegion.TabId, Type.GetType("System.String"));
objDT.Columns.Add(conViewRegion.KeyId4Test, Type.GetType("System.String"));
objDT.Columns.Add(conViewRegion.ErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(conViewRegion.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conViewRegion.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conViewRegion.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conViewRegion.Memo, Type.GetType("System.String"));
objDT.Columns.Add(conViewRegion.ClsName, Type.GetType("System.String"));
foreach (clsViewRegionEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conViewRegion.RegionId] = objInFor[conViewRegion.RegionId];
objDR[conViewRegion.RegionName] = objInFor[conViewRegion.RegionName];
objDR[conViewRegion.RegionTypeId] = objInFor[conViewRegion.RegionTypeId];
objDR[conViewRegion.FileName] = objInFor[conViewRegion.FileName];
objDR[conViewRegion.Height] = objInFor[conViewRegion.Height];
objDR[conViewRegion.Width] = objInFor[conViewRegion.Width];
objDR[conViewRegion.ColNum] = objInFor[conViewRegion.ColNum];
objDR[conViewRegion.ContainerTypeId] = objInFor[conViewRegion.ContainerTypeId];
objDR[conViewRegion.PageDispModeId] = objInFor[conViewRegion.PageDispModeId];
objDR[conViewRegion.InOutTypeId] = objInFor[conViewRegion.InOutTypeId];
objDR[conViewRegion.TabId] = objInFor[conViewRegion.TabId];
objDR[conViewRegion.KeyId4Test] = objInFor[conViewRegion.KeyId4Test];
objDR[conViewRegion.ErrMsg] = objInFor[conViewRegion.ErrMsg];
objDR[conViewRegion.PrjId] = objInFor[conViewRegion.PrjId];
objDR[conViewRegion.UpdUser] = objInFor[conViewRegion.UpdUser];
objDR[conViewRegion.UpdDate] = objInFor[conViewRegion.UpdDate];
objDR[conViewRegion.Memo] = objInFor[conViewRegion.Memo];
objDR[conViewRegion.ClsName] = objInFor[conViewRegion.ClsName];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 界面区域(ViewRegion)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4ViewRegion : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strPrjId)
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == false)
{
strMsg = string.Format("刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3));
clsSysParaEN.objLog.WriteDebugLog(strMsg);
return;
}
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewRegionWApi.ReFreshThisCache(strPrjId);
}
}

}