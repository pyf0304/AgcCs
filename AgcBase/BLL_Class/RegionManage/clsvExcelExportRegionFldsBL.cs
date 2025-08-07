
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvExcelExportRegionFldsBL
 表名:vExcelExportRegionFlds(00050150)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:48:09
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
public static class  clsvExcelExportRegionFldsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvExcelExportRegionFldsEN GetObj(this K_mId_vExcelExportRegionFlds myKey)
{
clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN = clsvExcelExportRegionFldsBL.vExcelExportRegionFldsDA.GetObjBymId(myKey.Value);
return objvExcelExportRegionFldsEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvExcelExportRegionFldsEN SetmId(this clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN, long lngmId, string strComparisonOp="")
	{
objvExcelExportRegionFldsEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExcelExportRegionFldsEN.dicFldComparisonOp.ContainsKey(convExcelExportRegionFlds.mId) == false)
{
objvExcelExportRegionFldsEN.dicFldComparisonOp.Add(convExcelExportRegionFlds.mId, strComparisonOp);
}
else
{
objvExcelExportRegionFldsEN.dicFldComparisonOp[convExcelExportRegionFlds.mId] = strComparisonOp;
}
}
return objvExcelExportRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvExcelExportRegionFldsEN SetRegionId(this clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN, string strRegionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionId, convExcelExportRegionFlds.RegionId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionId, 10, convExcelExportRegionFlds.RegionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRegionId, 10, convExcelExportRegionFlds.RegionId);
}
objvExcelExportRegionFldsEN.RegionId = strRegionId; //区域Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExcelExportRegionFldsEN.dicFldComparisonOp.ContainsKey(convExcelExportRegionFlds.RegionId) == false)
{
objvExcelExportRegionFldsEN.dicFldComparisonOp.Add(convExcelExportRegionFlds.RegionId, strComparisonOp);
}
else
{
objvExcelExportRegionFldsEN.dicFldComparisonOp[convExcelExportRegionFlds.RegionId] = strComparisonOp;
}
}
return objvExcelExportRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvExcelExportRegionFldsEN SetRegionName(this clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN, string strRegionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionName, 50, convExcelExportRegionFlds.RegionName);
}
objvExcelExportRegionFldsEN.RegionName = strRegionName; //区域名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExcelExportRegionFldsEN.dicFldComparisonOp.ContainsKey(convExcelExportRegionFlds.RegionName) == false)
{
objvExcelExportRegionFldsEN.dicFldComparisonOp.Add(convExcelExportRegionFlds.RegionName, strComparisonOp);
}
else
{
objvExcelExportRegionFldsEN.dicFldComparisonOp[convExcelExportRegionFlds.RegionName] = strComparisonOp;
}
}
return objvExcelExportRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvExcelExportRegionFldsEN SetTabId(this clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN, string strTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, convExcelExportRegionFlds.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convExcelExportRegionFlds.TabId);
}
objvExcelExportRegionFldsEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExcelExportRegionFldsEN.dicFldComparisonOp.ContainsKey(convExcelExportRegionFlds.TabId) == false)
{
objvExcelExportRegionFldsEN.dicFldComparisonOp.Add(convExcelExportRegionFlds.TabId, strComparisonOp);
}
else
{
objvExcelExportRegionFldsEN.dicFldComparisonOp[convExcelExportRegionFlds.TabId] = strComparisonOp;
}
}
return objvExcelExportRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvExcelExportRegionFldsEN SetTabName(this clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, convExcelExportRegionFlds.TabName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabName, 100, convExcelExportRegionFlds.TabName);
}
objvExcelExportRegionFldsEN.TabName = strTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExcelExportRegionFldsEN.dicFldComparisonOp.ContainsKey(convExcelExportRegionFlds.TabName) == false)
{
objvExcelExportRegionFldsEN.dicFldComparisonOp.Add(convExcelExportRegionFlds.TabName, strComparisonOp);
}
else
{
objvExcelExportRegionFldsEN.dicFldComparisonOp[convExcelExportRegionFlds.TabName] = strComparisonOp;
}
}
return objvExcelExportRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvExcelExportRegionFldsEN SetFldId(this clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN, string strFldId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldId, 8, convExcelExportRegionFlds.FldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldId, 8, convExcelExportRegionFlds.FldId);
}
objvExcelExportRegionFldsEN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExcelExportRegionFldsEN.dicFldComparisonOp.ContainsKey(convExcelExportRegionFlds.FldId) == false)
{
objvExcelExportRegionFldsEN.dicFldComparisonOp.Add(convExcelExportRegionFlds.FldId, strComparisonOp);
}
else
{
objvExcelExportRegionFldsEN.dicFldComparisonOp[convExcelExportRegionFlds.FldId] = strComparisonOp;
}
}
return objvExcelExportRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvExcelExportRegionFldsEN SetFldName(this clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN, string strFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldName, convExcelExportRegionFlds.FldName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldName, 50, convExcelExportRegionFlds.FldName);
}
objvExcelExportRegionFldsEN.FldName = strFldName; //字段名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExcelExportRegionFldsEN.dicFldComparisonOp.ContainsKey(convExcelExportRegionFlds.FldName) == false)
{
objvExcelExportRegionFldsEN.dicFldComparisonOp.Add(convExcelExportRegionFlds.FldName, strComparisonOp);
}
else
{
objvExcelExportRegionFldsEN.dicFldComparisonOp[convExcelExportRegionFlds.FldName] = strComparisonOp;
}
}
return objvExcelExportRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvExcelExportRegionFldsEN SetSeqNum(this clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN, int intSeqNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intSeqNum, convExcelExportRegionFlds.SeqNum);
objvExcelExportRegionFldsEN.SeqNum = intSeqNum; //字段序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExcelExportRegionFldsEN.dicFldComparisonOp.ContainsKey(convExcelExportRegionFlds.SeqNum) == false)
{
objvExcelExportRegionFldsEN.dicFldComparisonOp.Add(convExcelExportRegionFlds.SeqNum, strComparisonOp);
}
else
{
objvExcelExportRegionFldsEN.dicFldComparisonOp[convExcelExportRegionFlds.SeqNum] = strComparisonOp;
}
}
return objvExcelExportRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvExcelExportRegionFldsEN SetColCaption(this clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN, string strColCaption, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strColCaption, 100, convExcelExportRegionFlds.ColCaption);
}
objvExcelExportRegionFldsEN.ColCaption = strColCaption; //列标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExcelExportRegionFldsEN.dicFldComparisonOp.ContainsKey(convExcelExportRegionFlds.ColCaption) == false)
{
objvExcelExportRegionFldsEN.dicFldComparisonOp.Add(convExcelExportRegionFlds.ColCaption, strComparisonOp);
}
else
{
objvExcelExportRegionFldsEN.dicFldComparisonOp[convExcelExportRegionFlds.ColCaption] = strComparisonOp;
}
}
return objvExcelExportRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvExcelExportRegionFldsEN SetInUse(this clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN, bool bolInUse, string strComparisonOp="")
	{
objvExcelExportRegionFldsEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExcelExportRegionFldsEN.dicFldComparisonOp.ContainsKey(convExcelExportRegionFlds.InUse) == false)
{
objvExcelExportRegionFldsEN.dicFldComparisonOp.Add(convExcelExportRegionFlds.InUse, strComparisonOp);
}
else
{
objvExcelExportRegionFldsEN.dicFldComparisonOp[convExcelExportRegionFlds.InUse] = strComparisonOp;
}
}
return objvExcelExportRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvExcelExportRegionFldsEN SetUpdDate(this clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convExcelExportRegionFlds.UpdDate);
}
objvExcelExportRegionFldsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExcelExportRegionFldsEN.dicFldComparisonOp.ContainsKey(convExcelExportRegionFlds.UpdDate) == false)
{
objvExcelExportRegionFldsEN.dicFldComparisonOp.Add(convExcelExportRegionFlds.UpdDate, strComparisonOp);
}
else
{
objvExcelExportRegionFldsEN.dicFldComparisonOp[convExcelExportRegionFlds.UpdDate] = strComparisonOp;
}
}
return objvExcelExportRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvExcelExportRegionFldsEN SetUpdUser(this clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convExcelExportRegionFlds.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convExcelExportRegionFlds.UpdUser);
}
objvExcelExportRegionFldsEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExcelExportRegionFldsEN.dicFldComparisonOp.ContainsKey(convExcelExportRegionFlds.UpdUser) == false)
{
objvExcelExportRegionFldsEN.dicFldComparisonOp.Add(convExcelExportRegionFlds.UpdUser, strComparisonOp);
}
else
{
objvExcelExportRegionFldsEN.dicFldComparisonOp[convExcelExportRegionFlds.UpdUser] = strComparisonOp;
}
}
return objvExcelExportRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvExcelExportRegionFldsEN SetMemo(this clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convExcelExportRegionFlds.Memo);
}
objvExcelExportRegionFldsEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExcelExportRegionFldsEN.dicFldComparisonOp.ContainsKey(convExcelExportRegionFlds.Memo) == false)
{
objvExcelExportRegionFldsEN.dicFldComparisonOp.Add(convExcelExportRegionFlds.Memo, strComparisonOp);
}
else
{
objvExcelExportRegionFldsEN.dicFldComparisonOp[convExcelExportRegionFlds.Memo] = strComparisonOp;
}
}
return objvExcelExportRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvExcelExportRegionFldsEN SetIsDefaultSort(this clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN, bool bolIsDefaultSort, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsDefaultSort, convExcelExportRegionFlds.IsDefaultSort);
objvExcelExportRegionFldsEN.IsDefaultSort = bolIsDefaultSort; //是否默认排序
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExcelExportRegionFldsEN.dicFldComparisonOp.ContainsKey(convExcelExportRegionFlds.IsDefaultSort) == false)
{
objvExcelExportRegionFldsEN.dicFldComparisonOp.Add(convExcelExportRegionFlds.IsDefaultSort, strComparisonOp);
}
else
{
objvExcelExportRegionFldsEN.dicFldComparisonOp[convExcelExportRegionFlds.IsDefaultSort] = strComparisonOp;
}
}
return objvExcelExportRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvExcelExportRegionFldsEN SetIsNeedSort(this clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN, bool bolIsNeedSort, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsNeedSort, convExcelExportRegionFlds.IsNeedSort);
objvExcelExportRegionFldsEN.IsNeedSort = bolIsNeedSort; //是否需要排序
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExcelExportRegionFldsEN.dicFldComparisonOp.ContainsKey(convExcelExportRegionFlds.IsNeedSort) == false)
{
objvExcelExportRegionFldsEN.dicFldComparisonOp.Add(convExcelExportRegionFlds.IsNeedSort, strComparisonOp);
}
else
{
objvExcelExportRegionFldsEN.dicFldComparisonOp[convExcelExportRegionFlds.IsNeedSort] = strComparisonOp;
}
}
return objvExcelExportRegionFldsEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvExcelExportRegionFldsENS">源对象</param>
 /// <param name = "objvExcelExportRegionFldsENT">目标对象</param>
 public static void CopyTo(this clsvExcelExportRegionFldsEN objvExcelExportRegionFldsENS, clsvExcelExportRegionFldsEN objvExcelExportRegionFldsENT)
{
try
{
objvExcelExportRegionFldsENT.mId = objvExcelExportRegionFldsENS.mId; //mId
objvExcelExportRegionFldsENT.RegionId = objvExcelExportRegionFldsENS.RegionId; //区域Id
objvExcelExportRegionFldsENT.RegionName = objvExcelExportRegionFldsENS.RegionName; //区域名称
objvExcelExportRegionFldsENT.TabId = objvExcelExportRegionFldsENS.TabId; //表ID
objvExcelExportRegionFldsENT.TabName = objvExcelExportRegionFldsENS.TabName; //表名
objvExcelExportRegionFldsENT.FldId = objvExcelExportRegionFldsENS.FldId; //字段Id
objvExcelExportRegionFldsENT.FldName = objvExcelExportRegionFldsENS.FldName; //字段名
objvExcelExportRegionFldsENT.SeqNum = objvExcelExportRegionFldsENS.SeqNum; //字段序号
objvExcelExportRegionFldsENT.ColCaption = objvExcelExportRegionFldsENS.ColCaption; //列标题
objvExcelExportRegionFldsENT.InUse = objvExcelExportRegionFldsENS.InUse; //是否在用
objvExcelExportRegionFldsENT.UpdDate = objvExcelExportRegionFldsENS.UpdDate; //修改日期
objvExcelExportRegionFldsENT.UpdUser = objvExcelExportRegionFldsENS.UpdUser; //修改者
objvExcelExportRegionFldsENT.Memo = objvExcelExportRegionFldsENS.Memo; //说明
objvExcelExportRegionFldsENT.IsDefaultSort = objvExcelExportRegionFldsENS.IsDefaultSort; //是否默认排序
objvExcelExportRegionFldsENT.IsNeedSort = objvExcelExportRegionFldsENS.IsNeedSort; //是否需要排序
objvExcelExportRegionFldsENT.PrjId = objvExcelExportRegionFldsENS.PrjId; //工程Id
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
 /// <param name = "objvExcelExportRegionFldsENS">源对象</param>
 /// <returns>目标对象=>clsvExcelExportRegionFldsEN:objvExcelExportRegionFldsENT</returns>
 public static clsvExcelExportRegionFldsEN CopyTo(this clsvExcelExportRegionFldsEN objvExcelExportRegionFldsENS)
{
try
{
 clsvExcelExportRegionFldsEN objvExcelExportRegionFldsENT = new clsvExcelExportRegionFldsEN()
{
mId = objvExcelExportRegionFldsENS.mId, //mId
RegionId = objvExcelExportRegionFldsENS.RegionId, //区域Id
RegionName = objvExcelExportRegionFldsENS.RegionName, //区域名称
TabId = objvExcelExportRegionFldsENS.TabId, //表ID
TabName = objvExcelExportRegionFldsENS.TabName, //表名
FldId = objvExcelExportRegionFldsENS.FldId, //字段Id
FldName = objvExcelExportRegionFldsENS.FldName, //字段名
SeqNum = objvExcelExportRegionFldsENS.SeqNum, //字段序号
ColCaption = objvExcelExportRegionFldsENS.ColCaption, //列标题
InUse = objvExcelExportRegionFldsENS.InUse, //是否在用
UpdDate = objvExcelExportRegionFldsENS.UpdDate, //修改日期
UpdUser = objvExcelExportRegionFldsENS.UpdUser, //修改者
Memo = objvExcelExportRegionFldsENS.Memo, //说明
IsDefaultSort = objvExcelExportRegionFldsENS.IsDefaultSort, //是否默认排序
IsNeedSort = objvExcelExportRegionFldsENS.IsNeedSort, //是否需要排序
PrjId = objvExcelExportRegionFldsENS.PrjId, //工程Id
};
 return objvExcelExportRegionFldsENT;
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
public static void CheckProperty4Condition(this clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN)
{
 clsvExcelExportRegionFldsBL.vExcelExportRegionFldsDA.CheckProperty4Condition(objvExcelExportRegionFldsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvExcelExportRegionFldsEN objvExcelExportRegionFldsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvExcelExportRegionFldsCond.IsUpdated(convExcelExportRegionFlds.mId) == true)
{
string strComparisonOpmId = objvExcelExportRegionFldsCond.dicFldComparisonOp[convExcelExportRegionFlds.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convExcelExportRegionFlds.mId, objvExcelExportRegionFldsCond.mId, strComparisonOpmId);
}
if (objvExcelExportRegionFldsCond.IsUpdated(convExcelExportRegionFlds.RegionId) == true)
{
string strComparisonOpRegionId = objvExcelExportRegionFldsCond.dicFldComparisonOp[convExcelExportRegionFlds.RegionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convExcelExportRegionFlds.RegionId, objvExcelExportRegionFldsCond.RegionId, strComparisonOpRegionId);
}
if (objvExcelExportRegionFldsCond.IsUpdated(convExcelExportRegionFlds.RegionName) == true)
{
string strComparisonOpRegionName = objvExcelExportRegionFldsCond.dicFldComparisonOp[convExcelExportRegionFlds.RegionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convExcelExportRegionFlds.RegionName, objvExcelExportRegionFldsCond.RegionName, strComparisonOpRegionName);
}
if (objvExcelExportRegionFldsCond.IsUpdated(convExcelExportRegionFlds.TabId) == true)
{
string strComparisonOpTabId = objvExcelExportRegionFldsCond.dicFldComparisonOp[convExcelExportRegionFlds.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convExcelExportRegionFlds.TabId, objvExcelExportRegionFldsCond.TabId, strComparisonOpTabId);
}
if (objvExcelExportRegionFldsCond.IsUpdated(convExcelExportRegionFlds.TabName) == true)
{
string strComparisonOpTabName = objvExcelExportRegionFldsCond.dicFldComparisonOp[convExcelExportRegionFlds.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convExcelExportRegionFlds.TabName, objvExcelExportRegionFldsCond.TabName, strComparisonOpTabName);
}
if (objvExcelExportRegionFldsCond.IsUpdated(convExcelExportRegionFlds.FldId) == true)
{
string strComparisonOpFldId = objvExcelExportRegionFldsCond.dicFldComparisonOp[convExcelExportRegionFlds.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convExcelExportRegionFlds.FldId, objvExcelExportRegionFldsCond.FldId, strComparisonOpFldId);
}
if (objvExcelExportRegionFldsCond.IsUpdated(convExcelExportRegionFlds.FldName) == true)
{
string strComparisonOpFldName = objvExcelExportRegionFldsCond.dicFldComparisonOp[convExcelExportRegionFlds.FldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convExcelExportRegionFlds.FldName, objvExcelExportRegionFldsCond.FldName, strComparisonOpFldName);
}
if (objvExcelExportRegionFldsCond.IsUpdated(convExcelExportRegionFlds.SeqNum) == true)
{
string strComparisonOpSeqNum = objvExcelExportRegionFldsCond.dicFldComparisonOp[convExcelExportRegionFlds.SeqNum];
strWhereCond += string.Format(" And {0} {2} {1}", convExcelExportRegionFlds.SeqNum, objvExcelExportRegionFldsCond.SeqNum, strComparisonOpSeqNum);
}
if (objvExcelExportRegionFldsCond.IsUpdated(convExcelExportRegionFlds.ColCaption) == true)
{
string strComparisonOpColCaption = objvExcelExportRegionFldsCond.dicFldComparisonOp[convExcelExportRegionFlds.ColCaption];
strWhereCond += string.Format(" And {0} {2} '{1}'", convExcelExportRegionFlds.ColCaption, objvExcelExportRegionFldsCond.ColCaption, strComparisonOpColCaption);
}
if (objvExcelExportRegionFldsCond.IsUpdated(convExcelExportRegionFlds.InUse) == true)
{
if (objvExcelExportRegionFldsCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convExcelExportRegionFlds.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convExcelExportRegionFlds.InUse);
}
}
if (objvExcelExportRegionFldsCond.IsUpdated(convExcelExportRegionFlds.UpdDate) == true)
{
string strComparisonOpUpdDate = objvExcelExportRegionFldsCond.dicFldComparisonOp[convExcelExportRegionFlds.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convExcelExportRegionFlds.UpdDate, objvExcelExportRegionFldsCond.UpdDate, strComparisonOpUpdDate);
}
if (objvExcelExportRegionFldsCond.IsUpdated(convExcelExportRegionFlds.UpdUser) == true)
{
string strComparisonOpUpdUser = objvExcelExportRegionFldsCond.dicFldComparisonOp[convExcelExportRegionFlds.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convExcelExportRegionFlds.UpdUser, objvExcelExportRegionFldsCond.UpdUser, strComparisonOpUpdUser);
}
if (objvExcelExportRegionFldsCond.IsUpdated(convExcelExportRegionFlds.Memo) == true)
{
string strComparisonOpMemo = objvExcelExportRegionFldsCond.dicFldComparisonOp[convExcelExportRegionFlds.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convExcelExportRegionFlds.Memo, objvExcelExportRegionFldsCond.Memo, strComparisonOpMemo);
}
if (objvExcelExportRegionFldsCond.IsUpdated(convExcelExportRegionFlds.IsDefaultSort) == true)
{
if (objvExcelExportRegionFldsCond.IsDefaultSort == true)
{
strWhereCond += string.Format(" And {0} = '1'", convExcelExportRegionFlds.IsDefaultSort);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convExcelExportRegionFlds.IsDefaultSort);
}
}
if (objvExcelExportRegionFldsCond.IsUpdated(convExcelExportRegionFlds.IsNeedSort) == true)
{
if (objvExcelExportRegionFldsCond.IsNeedSort == true)
{
strWhereCond += string.Format(" And {0} = '1'", convExcelExportRegionFlds.IsNeedSort);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convExcelExportRegionFlds.IsNeedSort);
}
}
if (objvExcelExportRegionFldsCond.IsUpdated(convExcelExportRegionFlds.PrjId) == true)
{
string strComparisonOpPrjId = objvExcelExportRegionFldsCond.dicFldComparisonOp[convExcelExportRegionFlds.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convExcelExportRegionFlds.PrjId, objvExcelExportRegionFldsCond.PrjId, strComparisonOpPrjId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vExcelExportRegionFlds
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vExcel导出区域字段(vExcelExportRegionFlds)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvExcelExportRegionFldsBL
{
public static RelatedActions_vExcelExportRegionFlds relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvExcelExportRegionFldsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvExcelExportRegionFldsDA vExcelExportRegionFldsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvExcelExportRegionFldsDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvExcelExportRegionFldsBL()
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
if (string.IsNullOrEmpty(clsvExcelExportRegionFldsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvExcelExportRegionFldsEN._ConnectString);
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
public static DataTable GetDataTable_vExcelExportRegionFlds(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vExcelExportRegionFldsDA.GetDataTable_vExcelExportRegionFlds(strWhereCond);
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
objDT = vExcelExportRegionFldsDA.GetDataTable(strWhereCond);
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
objDT = vExcelExportRegionFldsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vExcelExportRegionFldsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vExcelExportRegionFldsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vExcelExportRegionFldsDA.GetDataTable_Top(objTopPara);
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
objDT = vExcelExportRegionFldsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vExcelExportRegionFldsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vExcelExportRegionFldsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvExcelExportRegionFldsEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvExcelExportRegionFldsEN> arrObjLst = new List<clsvExcelExportRegionFldsEN>(); 
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
	clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN = new clsvExcelExportRegionFldsEN();
try
{
objvExcelExportRegionFldsEN.mId = Int32.Parse(objRow[convExcelExportRegionFlds.mId].ToString().Trim()); //mId
objvExcelExportRegionFldsEN.RegionId = objRow[convExcelExportRegionFlds.RegionId].ToString().Trim(); //区域Id
objvExcelExportRegionFldsEN.RegionName = objRow[convExcelExportRegionFlds.RegionName] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.RegionName].ToString().Trim(); //区域名称
objvExcelExportRegionFldsEN.TabId = objRow[convExcelExportRegionFlds.TabId] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.TabId].ToString().Trim(); //表ID
objvExcelExportRegionFldsEN.TabName = objRow[convExcelExportRegionFlds.TabName].ToString().Trim(); //表名
objvExcelExportRegionFldsEN.FldId = objRow[convExcelExportRegionFlds.FldId] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.FldId].ToString().Trim(); //字段Id
objvExcelExportRegionFldsEN.FldName = objRow[convExcelExportRegionFlds.FldName].ToString().Trim(); //字段名
objvExcelExportRegionFldsEN.SeqNum = Int32.Parse(objRow[convExcelExportRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvExcelExportRegionFldsEN.ColCaption = objRow[convExcelExportRegionFlds.ColCaption] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.ColCaption].ToString().Trim(); //列标题
objvExcelExportRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convExcelExportRegionFlds.InUse].ToString().Trim()); //是否在用
objvExcelExportRegionFldsEN.UpdDate = objRow[convExcelExportRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvExcelExportRegionFldsEN.UpdUser = objRow[convExcelExportRegionFlds.UpdUser].ToString().Trim(); //修改者
objvExcelExportRegionFldsEN.Memo = objRow[convExcelExportRegionFlds.Memo] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.Memo].ToString().Trim(); //说明
objvExcelExportRegionFldsEN.IsDefaultSort = clsEntityBase2.TransNullToBool_S(objRow[convExcelExportRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objvExcelExportRegionFldsEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[convExcelExportRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
objvExcelExportRegionFldsEN.PrjId = objRow[convExcelExportRegionFlds.PrjId] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.PrjId].ToString().Trim(); //工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvExcelExportRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvExcelExportRegionFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvExcelExportRegionFldsEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvExcelExportRegionFldsEN._CurrTabName, strPrjId);
List<clsvExcelExportRegionFldsEN> arrvExcelExportRegionFldsObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvExcelExportRegionFldsEN> arrvExcelExportRegionFldsObjLst_Sel =
arrvExcelExportRegionFldsObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvExcelExportRegionFldsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvExcelExportRegionFldsEN> GetObjLst(string strWhereCond)
{
List<clsvExcelExportRegionFldsEN> arrObjLst = new List<clsvExcelExportRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN = new clsvExcelExportRegionFldsEN();
try
{
objvExcelExportRegionFldsEN.mId = Int32.Parse(objRow[convExcelExportRegionFlds.mId].ToString().Trim()); //mId
objvExcelExportRegionFldsEN.RegionId = objRow[convExcelExportRegionFlds.RegionId].ToString().Trim(); //区域Id
objvExcelExportRegionFldsEN.RegionName = objRow[convExcelExportRegionFlds.RegionName] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.RegionName].ToString().Trim(); //区域名称
objvExcelExportRegionFldsEN.TabId = objRow[convExcelExportRegionFlds.TabId] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.TabId].ToString().Trim(); //表ID
objvExcelExportRegionFldsEN.TabName = objRow[convExcelExportRegionFlds.TabName].ToString().Trim(); //表名
objvExcelExportRegionFldsEN.FldId = objRow[convExcelExportRegionFlds.FldId] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.FldId].ToString().Trim(); //字段Id
objvExcelExportRegionFldsEN.FldName = objRow[convExcelExportRegionFlds.FldName].ToString().Trim(); //字段名
objvExcelExportRegionFldsEN.SeqNum = Int32.Parse(objRow[convExcelExportRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvExcelExportRegionFldsEN.ColCaption = objRow[convExcelExportRegionFlds.ColCaption] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.ColCaption].ToString().Trim(); //列标题
objvExcelExportRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convExcelExportRegionFlds.InUse].ToString().Trim()); //是否在用
objvExcelExportRegionFldsEN.UpdDate = objRow[convExcelExportRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvExcelExportRegionFldsEN.UpdUser = objRow[convExcelExportRegionFlds.UpdUser].ToString().Trim(); //修改者
objvExcelExportRegionFldsEN.Memo = objRow[convExcelExportRegionFlds.Memo] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.Memo].ToString().Trim(); //说明
objvExcelExportRegionFldsEN.IsDefaultSort = clsEntityBase2.TransNullToBool_S(objRow[convExcelExportRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objvExcelExportRegionFldsEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[convExcelExportRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
objvExcelExportRegionFldsEN.PrjId = objRow[convExcelExportRegionFlds.PrjId] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.PrjId].ToString().Trim(); //工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvExcelExportRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvExcelExportRegionFldsEN);
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
public static List<clsvExcelExportRegionFldsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvExcelExportRegionFldsEN> arrObjLst = new List<clsvExcelExportRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN = new clsvExcelExportRegionFldsEN();
try
{
objvExcelExportRegionFldsEN.mId = Int32.Parse(objRow[convExcelExportRegionFlds.mId].ToString().Trim()); //mId
objvExcelExportRegionFldsEN.RegionId = objRow[convExcelExportRegionFlds.RegionId].ToString().Trim(); //区域Id
objvExcelExportRegionFldsEN.RegionName = objRow[convExcelExportRegionFlds.RegionName] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.RegionName].ToString().Trim(); //区域名称
objvExcelExportRegionFldsEN.TabId = objRow[convExcelExportRegionFlds.TabId] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.TabId].ToString().Trim(); //表ID
objvExcelExportRegionFldsEN.TabName = objRow[convExcelExportRegionFlds.TabName].ToString().Trim(); //表名
objvExcelExportRegionFldsEN.FldId = objRow[convExcelExportRegionFlds.FldId] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.FldId].ToString().Trim(); //字段Id
objvExcelExportRegionFldsEN.FldName = objRow[convExcelExportRegionFlds.FldName].ToString().Trim(); //字段名
objvExcelExportRegionFldsEN.SeqNum = Int32.Parse(objRow[convExcelExportRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvExcelExportRegionFldsEN.ColCaption = objRow[convExcelExportRegionFlds.ColCaption] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.ColCaption].ToString().Trim(); //列标题
objvExcelExportRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convExcelExportRegionFlds.InUse].ToString().Trim()); //是否在用
objvExcelExportRegionFldsEN.UpdDate = objRow[convExcelExportRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvExcelExportRegionFldsEN.UpdUser = objRow[convExcelExportRegionFlds.UpdUser].ToString().Trim(); //修改者
objvExcelExportRegionFldsEN.Memo = objRow[convExcelExportRegionFlds.Memo] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.Memo].ToString().Trim(); //说明
objvExcelExportRegionFldsEN.IsDefaultSort = clsEntityBase2.TransNullToBool_S(objRow[convExcelExportRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objvExcelExportRegionFldsEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[convExcelExportRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
objvExcelExportRegionFldsEN.PrjId = objRow[convExcelExportRegionFlds.PrjId] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.PrjId].ToString().Trim(); //工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvExcelExportRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvExcelExportRegionFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvExcelExportRegionFldsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvExcelExportRegionFldsEN> GetSubObjLstCache(clsvExcelExportRegionFldsEN objvExcelExportRegionFldsCond)
{
 string strPrjId = objvExcelExportRegionFldsCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvExcelExportRegionFldsBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvExcelExportRegionFldsEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvExcelExportRegionFldsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convExcelExportRegionFlds._AttributeName)
{
if (objvExcelExportRegionFldsCond.IsUpdated(strFldName) == false) continue;
if (objvExcelExportRegionFldsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvExcelExportRegionFldsCond[strFldName].ToString());
}
else
{
if (objvExcelExportRegionFldsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvExcelExportRegionFldsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvExcelExportRegionFldsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvExcelExportRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvExcelExportRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvExcelExportRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvExcelExportRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvExcelExportRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvExcelExportRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvExcelExportRegionFldsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvExcelExportRegionFldsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvExcelExportRegionFldsCond[strFldName]));
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
public static List<clsvExcelExportRegionFldsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvExcelExportRegionFldsEN> arrObjLst = new List<clsvExcelExportRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN = new clsvExcelExportRegionFldsEN();
try
{
objvExcelExportRegionFldsEN.mId = Int32.Parse(objRow[convExcelExportRegionFlds.mId].ToString().Trim()); //mId
objvExcelExportRegionFldsEN.RegionId = objRow[convExcelExportRegionFlds.RegionId].ToString().Trim(); //区域Id
objvExcelExportRegionFldsEN.RegionName = objRow[convExcelExportRegionFlds.RegionName] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.RegionName].ToString().Trim(); //区域名称
objvExcelExportRegionFldsEN.TabId = objRow[convExcelExportRegionFlds.TabId] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.TabId].ToString().Trim(); //表ID
objvExcelExportRegionFldsEN.TabName = objRow[convExcelExportRegionFlds.TabName].ToString().Trim(); //表名
objvExcelExportRegionFldsEN.FldId = objRow[convExcelExportRegionFlds.FldId] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.FldId].ToString().Trim(); //字段Id
objvExcelExportRegionFldsEN.FldName = objRow[convExcelExportRegionFlds.FldName].ToString().Trim(); //字段名
objvExcelExportRegionFldsEN.SeqNum = Int32.Parse(objRow[convExcelExportRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvExcelExportRegionFldsEN.ColCaption = objRow[convExcelExportRegionFlds.ColCaption] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.ColCaption].ToString().Trim(); //列标题
objvExcelExportRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convExcelExportRegionFlds.InUse].ToString().Trim()); //是否在用
objvExcelExportRegionFldsEN.UpdDate = objRow[convExcelExportRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvExcelExportRegionFldsEN.UpdUser = objRow[convExcelExportRegionFlds.UpdUser].ToString().Trim(); //修改者
objvExcelExportRegionFldsEN.Memo = objRow[convExcelExportRegionFlds.Memo] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.Memo].ToString().Trim(); //说明
objvExcelExportRegionFldsEN.IsDefaultSort = clsEntityBase2.TransNullToBool_S(objRow[convExcelExportRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objvExcelExportRegionFldsEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[convExcelExportRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
objvExcelExportRegionFldsEN.PrjId = objRow[convExcelExportRegionFlds.PrjId] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.PrjId].ToString().Trim(); //工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvExcelExportRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvExcelExportRegionFldsEN);
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
public static List<clsvExcelExportRegionFldsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvExcelExportRegionFldsEN> arrObjLst = new List<clsvExcelExportRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN = new clsvExcelExportRegionFldsEN();
try
{
objvExcelExportRegionFldsEN.mId = Int32.Parse(objRow[convExcelExportRegionFlds.mId].ToString().Trim()); //mId
objvExcelExportRegionFldsEN.RegionId = objRow[convExcelExportRegionFlds.RegionId].ToString().Trim(); //区域Id
objvExcelExportRegionFldsEN.RegionName = objRow[convExcelExportRegionFlds.RegionName] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.RegionName].ToString().Trim(); //区域名称
objvExcelExportRegionFldsEN.TabId = objRow[convExcelExportRegionFlds.TabId] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.TabId].ToString().Trim(); //表ID
objvExcelExportRegionFldsEN.TabName = objRow[convExcelExportRegionFlds.TabName].ToString().Trim(); //表名
objvExcelExportRegionFldsEN.FldId = objRow[convExcelExportRegionFlds.FldId] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.FldId].ToString().Trim(); //字段Id
objvExcelExportRegionFldsEN.FldName = objRow[convExcelExportRegionFlds.FldName].ToString().Trim(); //字段名
objvExcelExportRegionFldsEN.SeqNum = Int32.Parse(objRow[convExcelExportRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvExcelExportRegionFldsEN.ColCaption = objRow[convExcelExportRegionFlds.ColCaption] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.ColCaption].ToString().Trim(); //列标题
objvExcelExportRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convExcelExportRegionFlds.InUse].ToString().Trim()); //是否在用
objvExcelExportRegionFldsEN.UpdDate = objRow[convExcelExportRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvExcelExportRegionFldsEN.UpdUser = objRow[convExcelExportRegionFlds.UpdUser].ToString().Trim(); //修改者
objvExcelExportRegionFldsEN.Memo = objRow[convExcelExportRegionFlds.Memo] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.Memo].ToString().Trim(); //说明
objvExcelExportRegionFldsEN.IsDefaultSort = clsEntityBase2.TransNullToBool_S(objRow[convExcelExportRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objvExcelExportRegionFldsEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[convExcelExportRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
objvExcelExportRegionFldsEN.PrjId = objRow[convExcelExportRegionFlds.PrjId] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.PrjId].ToString().Trim(); //工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvExcelExportRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvExcelExportRegionFldsEN);
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
List<clsvExcelExportRegionFldsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvExcelExportRegionFldsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvExcelExportRegionFldsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvExcelExportRegionFldsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvExcelExportRegionFldsEN> arrObjLst = new List<clsvExcelExportRegionFldsEN>(); 
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
	clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN = new clsvExcelExportRegionFldsEN();
try
{
objvExcelExportRegionFldsEN.mId = Int32.Parse(objRow[convExcelExportRegionFlds.mId].ToString().Trim()); //mId
objvExcelExportRegionFldsEN.RegionId = objRow[convExcelExportRegionFlds.RegionId].ToString().Trim(); //区域Id
objvExcelExportRegionFldsEN.RegionName = objRow[convExcelExportRegionFlds.RegionName] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.RegionName].ToString().Trim(); //区域名称
objvExcelExportRegionFldsEN.TabId = objRow[convExcelExportRegionFlds.TabId] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.TabId].ToString().Trim(); //表ID
objvExcelExportRegionFldsEN.TabName = objRow[convExcelExportRegionFlds.TabName].ToString().Trim(); //表名
objvExcelExportRegionFldsEN.FldId = objRow[convExcelExportRegionFlds.FldId] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.FldId].ToString().Trim(); //字段Id
objvExcelExportRegionFldsEN.FldName = objRow[convExcelExportRegionFlds.FldName].ToString().Trim(); //字段名
objvExcelExportRegionFldsEN.SeqNum = Int32.Parse(objRow[convExcelExportRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvExcelExportRegionFldsEN.ColCaption = objRow[convExcelExportRegionFlds.ColCaption] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.ColCaption].ToString().Trim(); //列标题
objvExcelExportRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convExcelExportRegionFlds.InUse].ToString().Trim()); //是否在用
objvExcelExportRegionFldsEN.UpdDate = objRow[convExcelExportRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvExcelExportRegionFldsEN.UpdUser = objRow[convExcelExportRegionFlds.UpdUser].ToString().Trim(); //修改者
objvExcelExportRegionFldsEN.Memo = objRow[convExcelExportRegionFlds.Memo] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.Memo].ToString().Trim(); //说明
objvExcelExportRegionFldsEN.IsDefaultSort = clsEntityBase2.TransNullToBool_S(objRow[convExcelExportRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objvExcelExportRegionFldsEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[convExcelExportRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
objvExcelExportRegionFldsEN.PrjId = objRow[convExcelExportRegionFlds.PrjId] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.PrjId].ToString().Trim(); //工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvExcelExportRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvExcelExportRegionFldsEN);
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
public static List<clsvExcelExportRegionFldsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvExcelExportRegionFldsEN> arrObjLst = new List<clsvExcelExportRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN = new clsvExcelExportRegionFldsEN();
try
{
objvExcelExportRegionFldsEN.mId = Int32.Parse(objRow[convExcelExportRegionFlds.mId].ToString().Trim()); //mId
objvExcelExportRegionFldsEN.RegionId = objRow[convExcelExportRegionFlds.RegionId].ToString().Trim(); //区域Id
objvExcelExportRegionFldsEN.RegionName = objRow[convExcelExportRegionFlds.RegionName] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.RegionName].ToString().Trim(); //区域名称
objvExcelExportRegionFldsEN.TabId = objRow[convExcelExportRegionFlds.TabId] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.TabId].ToString().Trim(); //表ID
objvExcelExportRegionFldsEN.TabName = objRow[convExcelExportRegionFlds.TabName].ToString().Trim(); //表名
objvExcelExportRegionFldsEN.FldId = objRow[convExcelExportRegionFlds.FldId] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.FldId].ToString().Trim(); //字段Id
objvExcelExportRegionFldsEN.FldName = objRow[convExcelExportRegionFlds.FldName].ToString().Trim(); //字段名
objvExcelExportRegionFldsEN.SeqNum = Int32.Parse(objRow[convExcelExportRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvExcelExportRegionFldsEN.ColCaption = objRow[convExcelExportRegionFlds.ColCaption] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.ColCaption].ToString().Trim(); //列标题
objvExcelExportRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convExcelExportRegionFlds.InUse].ToString().Trim()); //是否在用
objvExcelExportRegionFldsEN.UpdDate = objRow[convExcelExportRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvExcelExportRegionFldsEN.UpdUser = objRow[convExcelExportRegionFlds.UpdUser].ToString().Trim(); //修改者
objvExcelExportRegionFldsEN.Memo = objRow[convExcelExportRegionFlds.Memo] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.Memo].ToString().Trim(); //说明
objvExcelExportRegionFldsEN.IsDefaultSort = clsEntityBase2.TransNullToBool_S(objRow[convExcelExportRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objvExcelExportRegionFldsEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[convExcelExportRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
objvExcelExportRegionFldsEN.PrjId = objRow[convExcelExportRegionFlds.PrjId] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.PrjId].ToString().Trim(); //工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvExcelExportRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvExcelExportRegionFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvExcelExportRegionFldsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvExcelExportRegionFldsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvExcelExportRegionFldsEN> arrObjLst = new List<clsvExcelExportRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN = new clsvExcelExportRegionFldsEN();
try
{
objvExcelExportRegionFldsEN.mId = Int32.Parse(objRow[convExcelExportRegionFlds.mId].ToString().Trim()); //mId
objvExcelExportRegionFldsEN.RegionId = objRow[convExcelExportRegionFlds.RegionId].ToString().Trim(); //区域Id
objvExcelExportRegionFldsEN.RegionName = objRow[convExcelExportRegionFlds.RegionName] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.RegionName].ToString().Trim(); //区域名称
objvExcelExportRegionFldsEN.TabId = objRow[convExcelExportRegionFlds.TabId] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.TabId].ToString().Trim(); //表ID
objvExcelExportRegionFldsEN.TabName = objRow[convExcelExportRegionFlds.TabName].ToString().Trim(); //表名
objvExcelExportRegionFldsEN.FldId = objRow[convExcelExportRegionFlds.FldId] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.FldId].ToString().Trim(); //字段Id
objvExcelExportRegionFldsEN.FldName = objRow[convExcelExportRegionFlds.FldName].ToString().Trim(); //字段名
objvExcelExportRegionFldsEN.SeqNum = Int32.Parse(objRow[convExcelExportRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvExcelExportRegionFldsEN.ColCaption = objRow[convExcelExportRegionFlds.ColCaption] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.ColCaption].ToString().Trim(); //列标题
objvExcelExportRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convExcelExportRegionFlds.InUse].ToString().Trim()); //是否在用
objvExcelExportRegionFldsEN.UpdDate = objRow[convExcelExportRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvExcelExportRegionFldsEN.UpdUser = objRow[convExcelExportRegionFlds.UpdUser].ToString().Trim(); //修改者
objvExcelExportRegionFldsEN.Memo = objRow[convExcelExportRegionFlds.Memo] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.Memo].ToString().Trim(); //说明
objvExcelExportRegionFldsEN.IsDefaultSort = clsEntityBase2.TransNullToBool_S(objRow[convExcelExportRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objvExcelExportRegionFldsEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[convExcelExportRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
objvExcelExportRegionFldsEN.PrjId = objRow[convExcelExportRegionFlds.PrjId] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.PrjId].ToString().Trim(); //工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvExcelExportRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvExcelExportRegionFldsEN);
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
public static List<clsvExcelExportRegionFldsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvExcelExportRegionFldsEN> arrObjLst = new List<clsvExcelExportRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN = new clsvExcelExportRegionFldsEN();
try
{
objvExcelExportRegionFldsEN.mId = Int32.Parse(objRow[convExcelExportRegionFlds.mId].ToString().Trim()); //mId
objvExcelExportRegionFldsEN.RegionId = objRow[convExcelExportRegionFlds.RegionId].ToString().Trim(); //区域Id
objvExcelExportRegionFldsEN.RegionName = objRow[convExcelExportRegionFlds.RegionName] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.RegionName].ToString().Trim(); //区域名称
objvExcelExportRegionFldsEN.TabId = objRow[convExcelExportRegionFlds.TabId] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.TabId].ToString().Trim(); //表ID
objvExcelExportRegionFldsEN.TabName = objRow[convExcelExportRegionFlds.TabName].ToString().Trim(); //表名
objvExcelExportRegionFldsEN.FldId = objRow[convExcelExportRegionFlds.FldId] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.FldId].ToString().Trim(); //字段Id
objvExcelExportRegionFldsEN.FldName = objRow[convExcelExportRegionFlds.FldName].ToString().Trim(); //字段名
objvExcelExportRegionFldsEN.SeqNum = Int32.Parse(objRow[convExcelExportRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvExcelExportRegionFldsEN.ColCaption = objRow[convExcelExportRegionFlds.ColCaption] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.ColCaption].ToString().Trim(); //列标题
objvExcelExportRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convExcelExportRegionFlds.InUse].ToString().Trim()); //是否在用
objvExcelExportRegionFldsEN.UpdDate = objRow[convExcelExportRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvExcelExportRegionFldsEN.UpdUser = objRow[convExcelExportRegionFlds.UpdUser].ToString().Trim(); //修改者
objvExcelExportRegionFldsEN.Memo = objRow[convExcelExportRegionFlds.Memo] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.Memo].ToString().Trim(); //说明
objvExcelExportRegionFldsEN.IsDefaultSort = clsEntityBase2.TransNullToBool_S(objRow[convExcelExportRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objvExcelExportRegionFldsEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[convExcelExportRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
objvExcelExportRegionFldsEN.PrjId = objRow[convExcelExportRegionFlds.PrjId] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.PrjId].ToString().Trim(); //工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvExcelExportRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvExcelExportRegionFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvExcelExportRegionFldsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvExcelExportRegionFldsEN> arrObjLst = new List<clsvExcelExportRegionFldsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN = new clsvExcelExportRegionFldsEN();
try
{
objvExcelExportRegionFldsEN.mId = Int32.Parse(objRow[convExcelExportRegionFlds.mId].ToString().Trim()); //mId
objvExcelExportRegionFldsEN.RegionId = objRow[convExcelExportRegionFlds.RegionId].ToString().Trim(); //区域Id
objvExcelExportRegionFldsEN.RegionName = objRow[convExcelExportRegionFlds.RegionName] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.RegionName].ToString().Trim(); //区域名称
objvExcelExportRegionFldsEN.TabId = objRow[convExcelExportRegionFlds.TabId] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.TabId].ToString().Trim(); //表ID
objvExcelExportRegionFldsEN.TabName = objRow[convExcelExportRegionFlds.TabName].ToString().Trim(); //表名
objvExcelExportRegionFldsEN.FldId = objRow[convExcelExportRegionFlds.FldId] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.FldId].ToString().Trim(); //字段Id
objvExcelExportRegionFldsEN.FldName = objRow[convExcelExportRegionFlds.FldName].ToString().Trim(); //字段名
objvExcelExportRegionFldsEN.SeqNum = Int32.Parse(objRow[convExcelExportRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvExcelExportRegionFldsEN.ColCaption = objRow[convExcelExportRegionFlds.ColCaption] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.ColCaption].ToString().Trim(); //列标题
objvExcelExportRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convExcelExportRegionFlds.InUse].ToString().Trim()); //是否在用
objvExcelExportRegionFldsEN.UpdDate = objRow[convExcelExportRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvExcelExportRegionFldsEN.UpdUser = objRow[convExcelExportRegionFlds.UpdUser].ToString().Trim(); //修改者
objvExcelExportRegionFldsEN.Memo = objRow[convExcelExportRegionFlds.Memo] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.Memo].ToString().Trim(); //说明
objvExcelExportRegionFldsEN.IsDefaultSort = clsEntityBase2.TransNullToBool_S(objRow[convExcelExportRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objvExcelExportRegionFldsEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[convExcelExportRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
objvExcelExportRegionFldsEN.PrjId = objRow[convExcelExportRegionFlds.PrjId] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.PrjId].ToString().Trim(); //工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvExcelExportRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvExcelExportRegionFldsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvExcelExportRegionFldsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvExcelExportRegionFlds(ref clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN)
{
bool bolResult = vExcelExportRegionFldsDA.GetvExcelExportRegionFlds(ref objvExcelExportRegionFldsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvExcelExportRegionFldsEN GetObjBymId(long lngmId)
{
clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN = vExcelExportRegionFldsDA.GetObjBymId(lngmId);
return objvExcelExportRegionFldsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvExcelExportRegionFldsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN = vExcelExportRegionFldsDA.GetFirstObj(strWhereCond);
 return objvExcelExportRegionFldsEN;
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
public static clsvExcelExportRegionFldsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN = vExcelExportRegionFldsDA.GetObjByDataRow(objRow);
 return objvExcelExportRegionFldsEN;
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
public static clsvExcelExportRegionFldsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN = vExcelExportRegionFldsDA.GetObjByDataRow(objRow);
 return objvExcelExportRegionFldsEN;
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
 /// <param name = "lstvExcelExportRegionFldsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvExcelExportRegionFldsEN GetObjBymIdFromList(long lngmId, List<clsvExcelExportRegionFldsEN> lstvExcelExportRegionFldsObjLst)
{
foreach (clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN in lstvExcelExportRegionFldsObjLst)
{
if (objvExcelExportRegionFldsEN.mId == lngmId)
{
return objvExcelExportRegionFldsEN;
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
 lngmId = new clsvExcelExportRegionFldsDA().GetFirstID(strWhereCond);
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
 arrList = vExcelExportRegionFldsDA.GetID(strWhereCond);
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
bool bolIsExist = vExcelExportRegionFldsDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vExcelExportRegionFldsDA.IsExist(lngmId);
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
 bolIsExist = clsvExcelExportRegionFldsDA.IsExistTable();
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
 bolIsExist = vExcelExportRegionFldsDA.IsExistTable(strTabName);
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
 /// <param name = "objvExcelExportRegionFldsENS">源对象</param>
 /// <param name = "objvExcelExportRegionFldsENT">目标对象</param>
 public static void CopyTo(clsvExcelExportRegionFldsEN objvExcelExportRegionFldsENS, clsvExcelExportRegionFldsEN objvExcelExportRegionFldsENT)
{
try
{
objvExcelExportRegionFldsENT.mId = objvExcelExportRegionFldsENS.mId; //mId
objvExcelExportRegionFldsENT.RegionId = objvExcelExportRegionFldsENS.RegionId; //区域Id
objvExcelExportRegionFldsENT.RegionName = objvExcelExportRegionFldsENS.RegionName; //区域名称
objvExcelExportRegionFldsENT.TabId = objvExcelExportRegionFldsENS.TabId; //表ID
objvExcelExportRegionFldsENT.TabName = objvExcelExportRegionFldsENS.TabName; //表名
objvExcelExportRegionFldsENT.FldId = objvExcelExportRegionFldsENS.FldId; //字段Id
objvExcelExportRegionFldsENT.FldName = objvExcelExportRegionFldsENS.FldName; //字段名
objvExcelExportRegionFldsENT.SeqNum = objvExcelExportRegionFldsENS.SeqNum; //字段序号
objvExcelExportRegionFldsENT.ColCaption = objvExcelExportRegionFldsENS.ColCaption; //列标题
objvExcelExportRegionFldsENT.InUse = objvExcelExportRegionFldsENS.InUse; //是否在用
objvExcelExportRegionFldsENT.UpdDate = objvExcelExportRegionFldsENS.UpdDate; //修改日期
objvExcelExportRegionFldsENT.UpdUser = objvExcelExportRegionFldsENS.UpdUser; //修改者
objvExcelExportRegionFldsENT.Memo = objvExcelExportRegionFldsENS.Memo; //说明
objvExcelExportRegionFldsENT.IsDefaultSort = objvExcelExportRegionFldsENS.IsDefaultSort; //是否默认排序
objvExcelExportRegionFldsENT.IsNeedSort = objvExcelExportRegionFldsENS.IsNeedSort; //是否需要排序
objvExcelExportRegionFldsENT.PrjId = objvExcelExportRegionFldsENS.PrjId; //工程Id
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
 /// <param name = "objvExcelExportRegionFldsEN">源简化对象</param>
 public static void SetUpdFlag(clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN)
{
try
{
objvExcelExportRegionFldsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvExcelExportRegionFldsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convExcelExportRegionFlds.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvExcelExportRegionFldsEN.mId = objvExcelExportRegionFldsEN.mId; //mId
}
if (arrFldSet.Contains(convExcelExportRegionFlds.RegionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvExcelExportRegionFldsEN.RegionId = objvExcelExportRegionFldsEN.RegionId; //区域Id
}
if (arrFldSet.Contains(convExcelExportRegionFlds.RegionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvExcelExportRegionFldsEN.RegionName = objvExcelExportRegionFldsEN.RegionName == "[null]" ? null :  objvExcelExportRegionFldsEN.RegionName; //区域名称
}
if (arrFldSet.Contains(convExcelExportRegionFlds.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvExcelExportRegionFldsEN.TabId = objvExcelExportRegionFldsEN.TabId == "[null]" ? null :  objvExcelExportRegionFldsEN.TabId; //表ID
}
if (arrFldSet.Contains(convExcelExportRegionFlds.TabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvExcelExportRegionFldsEN.TabName = objvExcelExportRegionFldsEN.TabName; //表名
}
if (arrFldSet.Contains(convExcelExportRegionFlds.FldId, new clsStrCompareIgnoreCase())  ==  true)
{
objvExcelExportRegionFldsEN.FldId = objvExcelExportRegionFldsEN.FldId == "[null]" ? null :  objvExcelExportRegionFldsEN.FldId; //字段Id
}
if (arrFldSet.Contains(convExcelExportRegionFlds.FldName, new clsStrCompareIgnoreCase())  ==  true)
{
objvExcelExportRegionFldsEN.FldName = objvExcelExportRegionFldsEN.FldName; //字段名
}
if (arrFldSet.Contains(convExcelExportRegionFlds.SeqNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvExcelExportRegionFldsEN.SeqNum = objvExcelExportRegionFldsEN.SeqNum; //字段序号
}
if (arrFldSet.Contains(convExcelExportRegionFlds.ColCaption, new clsStrCompareIgnoreCase())  ==  true)
{
objvExcelExportRegionFldsEN.ColCaption = objvExcelExportRegionFldsEN.ColCaption == "[null]" ? null :  objvExcelExportRegionFldsEN.ColCaption; //列标题
}
if (arrFldSet.Contains(convExcelExportRegionFlds.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvExcelExportRegionFldsEN.InUse = objvExcelExportRegionFldsEN.InUse; //是否在用
}
if (arrFldSet.Contains(convExcelExportRegionFlds.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvExcelExportRegionFldsEN.UpdDate = objvExcelExportRegionFldsEN.UpdDate == "[null]" ? null :  objvExcelExportRegionFldsEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convExcelExportRegionFlds.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvExcelExportRegionFldsEN.UpdUser = objvExcelExportRegionFldsEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convExcelExportRegionFlds.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvExcelExportRegionFldsEN.Memo = objvExcelExportRegionFldsEN.Memo == "[null]" ? null :  objvExcelExportRegionFldsEN.Memo; //说明
}
if (arrFldSet.Contains(convExcelExportRegionFlds.IsDefaultSort, new clsStrCompareIgnoreCase())  ==  true)
{
objvExcelExportRegionFldsEN.IsDefaultSort = objvExcelExportRegionFldsEN.IsDefaultSort; //是否默认排序
}
if (arrFldSet.Contains(convExcelExportRegionFlds.IsNeedSort, new clsStrCompareIgnoreCase())  ==  true)
{
objvExcelExportRegionFldsEN.IsNeedSort = objvExcelExportRegionFldsEN.IsNeedSort; //是否需要排序
}
if (arrFldSet.Contains(convExcelExportRegionFlds.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvExcelExportRegionFldsEN.PrjId = objvExcelExportRegionFldsEN.PrjId == "[null]" ? null :  objvExcelExportRegionFldsEN.PrjId; //工程Id
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
 /// <param name = "objvExcelExportRegionFldsEN">源简化对象</param>
 public static void AccessFldValueNull(clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN)
{
try
{
if (objvExcelExportRegionFldsEN.RegionName == "[null]") objvExcelExportRegionFldsEN.RegionName = null; //区域名称
if (objvExcelExportRegionFldsEN.TabId == "[null]") objvExcelExportRegionFldsEN.TabId = null; //表ID
if (objvExcelExportRegionFldsEN.FldId == "[null]") objvExcelExportRegionFldsEN.FldId = null; //字段Id
if (objvExcelExportRegionFldsEN.ColCaption == "[null]") objvExcelExportRegionFldsEN.ColCaption = null; //列标题
if (objvExcelExportRegionFldsEN.UpdDate == "[null]") objvExcelExportRegionFldsEN.UpdDate = null; //修改日期
if (objvExcelExportRegionFldsEN.Memo == "[null]") objvExcelExportRegionFldsEN.Memo = null; //说明
if (objvExcelExportRegionFldsEN.PrjId == "[null]") objvExcelExportRegionFldsEN.PrjId = null; //工程Id
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
public static void CheckProperty4Condition(clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN)
{
 vExcelExportRegionFldsDA.CheckProperty4Condition(objvExcelExportRegionFldsEN);
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
if (clsFieldTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFieldTabBL没有刷新缓存机制(clsFieldTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsExcelExportRegionFldsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsExcelExportRegionFldsBL没有刷新缓存机制(clsExcelExportRegionFldsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//if (arrvExcelExportRegionFldsObjLstCache == null)
//{
//arrvExcelExportRegionFldsObjLstCache = vExcelExportRegionFldsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvExcelExportRegionFldsEN GetObjBymIdCache(long lngmId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvExcelExportRegionFldsEN._CurrTabName, strPrjId);
List<clsvExcelExportRegionFldsEN> arrvExcelExportRegionFldsObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvExcelExportRegionFldsEN> arrvExcelExportRegionFldsObjLst_Sel =
arrvExcelExportRegionFldsObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvExcelExportRegionFldsObjLst_Sel.Count() == 0)
{
   clsvExcelExportRegionFldsEN obj = clsvExcelExportRegionFldsBL.GetObjBymId(lngmId);
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
return arrvExcelExportRegionFldsObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvExcelExportRegionFldsEN> GetAllvExcelExportRegionFldsObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvExcelExportRegionFldsEN> arrvExcelExportRegionFldsObjLstCache = GetObjLstCache(strPrjId); 
return arrvExcelExportRegionFldsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvExcelExportRegionFldsEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvExcelExportRegionFldsEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsvExcelExportRegionFldsEN> arrvExcelExportRegionFldsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvExcelExportRegionFldsObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvExcelExportRegionFldsEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsvExcelExportRegionFldsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvExcelExportRegionFldsEN._RefreshTimeLst.Count == 0) return "";
return clsvExcelExportRegionFldsEN._RefreshTimeLst[clsvExcelExportRegionFldsEN._RefreshTimeLst.Count - 1];
}


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2025-07-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId, string strPrjId)
{
if (strInFldName != convExcelExportRegionFlds.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convExcelExportRegionFlds._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convExcelExportRegionFlds._AttributeName));
throw new Exception(strMsg);
}
var objvExcelExportRegionFlds = clsvExcelExportRegionFldsBL.GetObjBymIdCache(lngmId, strPrjId);
if (objvExcelExportRegionFlds == null) return "";
return objvExcelExportRegionFlds[strOutFldName].ToString();
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
int intRecCount = clsvExcelExportRegionFldsDA.GetRecCount(strTabName);
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
int intRecCount = clsvExcelExportRegionFldsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvExcelExportRegionFldsDA.GetRecCount();
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
int intRecCount = clsvExcelExportRegionFldsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvExcelExportRegionFldsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvExcelExportRegionFldsEN objvExcelExportRegionFldsCond)
{
 string strPrjId = objvExcelExportRegionFldsCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvExcelExportRegionFldsBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvExcelExportRegionFldsEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvExcelExportRegionFldsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convExcelExportRegionFlds._AttributeName)
{
if (objvExcelExportRegionFldsCond.IsUpdated(strFldName) == false) continue;
if (objvExcelExportRegionFldsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvExcelExportRegionFldsCond[strFldName].ToString());
}
else
{
if (objvExcelExportRegionFldsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvExcelExportRegionFldsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvExcelExportRegionFldsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvExcelExportRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvExcelExportRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvExcelExportRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvExcelExportRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvExcelExportRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvExcelExportRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvExcelExportRegionFldsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvExcelExportRegionFldsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvExcelExportRegionFldsCond[strFldName]));
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
 List<string> arrList = clsvExcelExportRegionFldsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vExcelExportRegionFldsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vExcelExportRegionFldsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}