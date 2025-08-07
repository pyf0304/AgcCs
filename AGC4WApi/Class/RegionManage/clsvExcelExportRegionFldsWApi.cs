
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvExcelExportRegionFldsWApi
 表名:vExcelExportRegionFlds(00050150)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:39:11
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
public static class  clsvExcelExportRegionFldsWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionId">区域Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvExcelExportRegionFldsEN SetRegionId(this clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN, string strRegionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionId, convExcelExportRegionFlds.RegionId);
clsCheckSql.CheckFieldLen(strRegionId, 10, convExcelExportRegionFlds.RegionId);
clsCheckSql.CheckFieldForeignKey(strRegionId, 10, convExcelExportRegionFlds.RegionId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionName">区域名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvExcelExportRegionFldsEN SetRegionName(this clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN, string strRegionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRegionName, 50, convExcelExportRegionFlds.RegionName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvExcelExportRegionFldsEN SetTabId(this clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabId, 8, convExcelExportRegionFlds.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convExcelExportRegionFlds.TabId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvExcelExportRegionFldsEN SetTabName(this clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, convExcelExportRegionFlds.TabName);
clsCheckSql.CheckFieldLen(strTabName, 100, convExcelExportRegionFlds.TabName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldId">字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvExcelExportRegionFldsEN SetFldId(this clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFldId, 8, convExcelExportRegionFlds.FldId);
clsCheckSql.CheckFieldForeignKey(strFldId, 8, convExcelExportRegionFlds.FldId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvExcelExportRegionFldsEN SetFldName(this clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN, string strFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldName, convExcelExportRegionFlds.FldName);
clsCheckSql.CheckFieldLen(strFldName, 50, convExcelExportRegionFlds.FldName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "intSeqNum">字段序号</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strColCaption">列标题</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvExcelExportRegionFldsEN SetColCaption(this clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN, string strColCaption, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strColCaption, 100, convExcelExportRegionFlds.ColCaption);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvExcelExportRegionFldsEN SetUpdDate(this clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convExcelExportRegionFlds.UpdDate);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvExcelExportRegionFldsEN SetUpdUser(this clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convExcelExportRegionFlds.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, convExcelExportRegionFlds.UpdUser);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvExcelExportRegionFldsEN SetMemo(this clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convExcelExportRegionFlds.Memo);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsDefaultSort">是否默认排序</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNeedSort">是否需要排序</param>
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
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvExcelExportRegionFldsEN SetPrjId(this clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjId, 4, convExcelExportRegionFlds.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convExcelExportRegionFlds.PrjId);
objvExcelExportRegionFldsEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExcelExportRegionFldsEN.dicFldComparisonOp.ContainsKey(convExcelExportRegionFlds.PrjId) == false)
{
objvExcelExportRegionFldsEN.dicFldComparisonOp.Add(convExcelExportRegionFlds.PrjId, strComparisonOp);
}
else
{
objvExcelExportRegionFldsEN.dicFldComparisonOp[convExcelExportRegionFlds.PrjId] = strComparisonOp;
}
}
return objvExcelExportRegionFldsEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
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
 /// vExcel导出区域字段(vExcelExportRegionFlds)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvExcelExportRegionFldsWApi
{
private static readonly string mstrApiControllerName = "vExcelExportRegionFldsApi";

 public clsvExcelExportRegionFldsWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvExcelExportRegionFldsEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN;
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
objvExcelExportRegionFldsEN = JsonConvert.DeserializeObject<clsvExcelExportRegionFldsEN>(strJson);
return objvExcelExportRegionFldsEN;
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
public static clsvExcelExportRegionFldsEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN;
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
objvExcelExportRegionFldsEN = JsonConvert.DeserializeObject<clsvExcelExportRegionFldsEN>(strJson);
return objvExcelExportRegionFldsEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvExcelExportRegionFldsEN GetObjBymIdCache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvExcelExportRegionFldsEN._CurrTabName);
List<clsvExcelExportRegionFldsEN> arrvExcelExportRegionFldsObjLstCache = GetObjLstCache();
IEnumerable <clsvExcelExportRegionFldsEN> arrvExcelExportRegionFldsObjLst_Sel =
from objvExcelExportRegionFldsEN in arrvExcelExportRegionFldsObjLstCache
where objvExcelExportRegionFldsEN.mId == lngmId 
select objvExcelExportRegionFldsEN;
if (arrvExcelExportRegionFldsObjLst_Sel.Count() == 0)
{
   clsvExcelExportRegionFldsEN obj = clsvExcelExportRegionFldsWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvExcelExportRegionFldsObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvExcelExportRegionFldsEN> GetObjLst(string strWhereCond)
{
 List<clsvExcelExportRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvExcelExportRegionFldsEN>>(strJson);
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
public static List<clsvExcelExportRegionFldsEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvExcelExportRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvExcelExportRegionFldsEN>>(strJson);
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
 /// <param name = "arrMId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsvExcelExportRegionFldsEN> GetObjLstByMIdLstCache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvExcelExportRegionFldsEN._CurrTabName);
List<clsvExcelExportRegionFldsEN> arrvExcelExportRegionFldsObjLstCache = GetObjLstCache();
IEnumerable <clsvExcelExportRegionFldsEN> arrvExcelExportRegionFldsObjLst_Sel =
from objvExcelExportRegionFldsEN in arrvExcelExportRegionFldsObjLstCache
where arrMId.Contains(objvExcelExportRegionFldsEN.mId)
select objvExcelExportRegionFldsEN;
return arrvExcelExportRegionFldsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvExcelExportRegionFldsEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvExcelExportRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvExcelExportRegionFldsEN>>(strJson);
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
public static List<clsvExcelExportRegionFldsEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvExcelExportRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvExcelExportRegionFldsEN>>(strJson);
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
public static List<clsvExcelExportRegionFldsEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvExcelExportRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvExcelExportRegionFldsEN>>(strJson);
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
public static List<clsvExcelExportRegionFldsEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvExcelExportRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvExcelExportRegionFldsEN>>(strJson);
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
public static DataTable ToDataTable(List<clsvExcelExportRegionFldsEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvExcelExportRegionFldsEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvExcelExportRegionFldsEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvExcelExportRegionFldsEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvExcelExportRegionFldsEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvExcelExportRegionFldsEN._AttributeName)
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
public static void ReFreshThisCache()
{

string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvExcelExportRegionFldsEN._CurrTabName);
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
public static List<clsvExcelExportRegionFldsEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsvExcelExportRegionFldsEN._CurrTabName;
List<clsvExcelExportRegionFldsEN> arrvExcelExportRegionFldsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvExcelExportRegionFldsObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvExcelExportRegionFldsEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convExcelExportRegionFlds.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convExcelExportRegionFlds.RegionId, Type.GetType("System.String"));
objDT.Columns.Add(convExcelExportRegionFlds.RegionName, Type.GetType("System.String"));
objDT.Columns.Add(convExcelExportRegionFlds.TabId, Type.GetType("System.String"));
objDT.Columns.Add(convExcelExportRegionFlds.TabName, Type.GetType("System.String"));
objDT.Columns.Add(convExcelExportRegionFlds.FldId, Type.GetType("System.String"));
objDT.Columns.Add(convExcelExportRegionFlds.FldName, Type.GetType("System.String"));
objDT.Columns.Add(convExcelExportRegionFlds.SeqNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convExcelExportRegionFlds.ColCaption, Type.GetType("System.String"));
objDT.Columns.Add(convExcelExportRegionFlds.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convExcelExportRegionFlds.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convExcelExportRegionFlds.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convExcelExportRegionFlds.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convExcelExportRegionFlds.IsDefaultSort, Type.GetType("System.Boolean"));
objDT.Columns.Add(convExcelExportRegionFlds.IsNeedSort, Type.GetType("System.Boolean"));
objDT.Columns.Add(convExcelExportRegionFlds.PrjId, Type.GetType("System.String"));
foreach (clsvExcelExportRegionFldsEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convExcelExportRegionFlds.mId] = objInFor[convExcelExportRegionFlds.mId];
objDR[convExcelExportRegionFlds.RegionId] = objInFor[convExcelExportRegionFlds.RegionId];
objDR[convExcelExportRegionFlds.RegionName] = objInFor[convExcelExportRegionFlds.RegionName];
objDR[convExcelExportRegionFlds.TabId] = objInFor[convExcelExportRegionFlds.TabId];
objDR[convExcelExportRegionFlds.TabName] = objInFor[convExcelExportRegionFlds.TabName];
objDR[convExcelExportRegionFlds.FldId] = objInFor[convExcelExportRegionFlds.FldId];
objDR[convExcelExportRegionFlds.FldName] = objInFor[convExcelExportRegionFlds.FldName];
objDR[convExcelExportRegionFlds.SeqNum] = objInFor[convExcelExportRegionFlds.SeqNum];
objDR[convExcelExportRegionFlds.ColCaption] = objInFor[convExcelExportRegionFlds.ColCaption];
objDR[convExcelExportRegionFlds.InUse] = objInFor[convExcelExportRegionFlds.InUse];
objDR[convExcelExportRegionFlds.UpdDate] = objInFor[convExcelExportRegionFlds.UpdDate];
objDR[convExcelExportRegionFlds.UpdUser] = objInFor[convExcelExportRegionFlds.UpdUser];
objDR[convExcelExportRegionFlds.Memo] = objInFor[convExcelExportRegionFlds.Memo];
objDR[convExcelExportRegionFlds.IsDefaultSort] = objInFor[convExcelExportRegionFlds.IsDefaultSort];
objDR[convExcelExportRegionFlds.IsNeedSort] = objInFor[convExcelExportRegionFlds.IsNeedSort];
objDR[convExcelExportRegionFlds.PrjId] = objInFor[convExcelExportRegionFlds.PrjId];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}