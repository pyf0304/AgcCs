
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDetailRegionFldsWApi
 表名:DetailRegionFlds(00050544)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 21:38:14
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
public static class  clsDetailRegionFldsWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDetailRegionFldsEN SetmId(this clsDetailRegionFldsEN objDetailRegionFldsEN, long lngmId, string strComparisonOp="")
	{
objDetailRegionFldsEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(conDetailRegionFlds.mId) == false)
{
objDetailRegionFldsEN.dicFldComparisonOp.Add(conDetailRegionFlds.mId, strComparisonOp);
}
else
{
objDetailRegionFldsEN.dicFldComparisonOp[conDetailRegionFlds.mId] = strComparisonOp;
}
}
return objDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionId">区域Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDetailRegionFldsEN SetRegionId(this clsDetailRegionFldsEN objDetailRegionFldsEN, string strRegionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionId, conDetailRegionFlds.RegionId);
clsCheckSql.CheckFieldLen(strRegionId, 10, conDetailRegionFlds.RegionId);
clsCheckSql.CheckFieldForeignKey(strRegionId, 10, conDetailRegionFlds.RegionId);
objDetailRegionFldsEN.RegionId = strRegionId; //区域Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(conDetailRegionFlds.RegionId) == false)
{
objDetailRegionFldsEN.dicFldComparisonOp.Add(conDetailRegionFlds.RegionId, strComparisonOp);
}
else
{
objDetailRegionFldsEN.dicFldComparisonOp[conDetailRegionFlds.RegionId] = strComparisonOp;
}
}
return objDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldId">字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDetailRegionFldsEN SetFldId(this clsDetailRegionFldsEN objDetailRegionFldsEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFldId, 8, conDetailRegionFlds.FldId);
clsCheckSql.CheckFieldForeignKey(strFldId, 8, conDetailRegionFlds.FldId);
objDetailRegionFldsEN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(conDetailRegionFlds.FldId) == false)
{
objDetailRegionFldsEN.dicFldComparisonOp.Add(conDetailRegionFlds.FldId, strComparisonOp);
}
else
{
objDetailRegionFldsEN.dicFldComparisonOp[conDetailRegionFlds.FldId] = strComparisonOp;
}
}
return objDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strOutFldId">OutFldId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDetailRegionFldsEN SetOutFldId(this clsDetailRegionFldsEN objDetailRegionFldsEN, string strOutFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOutFldId, 8, conDetailRegionFlds.OutFldId);
clsCheckSql.CheckFieldForeignKey(strOutFldId, 8, conDetailRegionFlds.OutFldId);
objDetailRegionFldsEN.OutFldId = strOutFldId; //OutFldId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(conDetailRegionFlds.OutFldId) == false)
{
objDetailRegionFldsEN.dicFldComparisonOp.Add(conDetailRegionFlds.OutFldId, strComparisonOp);
}
else
{
objDetailRegionFldsEN.dicFldComparisonOp[conDetailRegionFlds.OutFldId] = strComparisonOp;
}
}
return objDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strLabelCaption">标签标题</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDetailRegionFldsEN SetLabelCaption(this clsDetailRegionFldsEN objDetailRegionFldsEN, string strLabelCaption, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLabelCaption, 150, conDetailRegionFlds.LabelCaption);
objDetailRegionFldsEN.LabelCaption = strLabelCaption; //标签标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(conDetailRegionFlds.LabelCaption) == false)
{
objDetailRegionFldsEN.dicFldComparisonOp.Add(conDetailRegionFlds.LabelCaption, strComparisonOp);
}
else
{
objDetailRegionFldsEN.dicFldComparisonOp[conDetailRegionFlds.LabelCaption] = strComparisonOp;
}
}
return objDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strCtlTypeId">控件类型号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDetailRegionFldsEN SetCtlTypeId(this clsDetailRegionFldsEN objDetailRegionFldsEN, string strCtlTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCtlTypeId, conDetailRegionFlds.CtlTypeId);
clsCheckSql.CheckFieldLen(strCtlTypeId, 2, conDetailRegionFlds.CtlTypeId);
clsCheckSql.CheckFieldForeignKey(strCtlTypeId, 2, conDetailRegionFlds.CtlTypeId);
objDetailRegionFldsEN.CtlTypeId = strCtlTypeId; //控件类型号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(conDetailRegionFlds.CtlTypeId) == false)
{
objDetailRegionFldsEN.dicFldComparisonOp.Add(conDetailRegionFlds.CtlTypeId, strComparisonOp);
}
else
{
objDetailRegionFldsEN.dicFldComparisonOp[conDetailRegionFlds.CtlTypeId] = strComparisonOp;
}
}
return objDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "intColSpan">跨列数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDetailRegionFldsEN SetColSpan(this clsDetailRegionFldsEN objDetailRegionFldsEN, int intColSpan, string strComparisonOp="")
	{
objDetailRegionFldsEN.ColSpan = intColSpan; //跨列数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(conDetailRegionFlds.ColSpan) == false)
{
objDetailRegionFldsEN.dicFldComparisonOp.Add(conDetailRegionFlds.ColSpan, strComparisonOp);
}
else
{
objDetailRegionFldsEN.dicFldComparisonOp[conDetailRegionFlds.ColSpan] = strComparisonOp;
}
}
return objDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "intColIndex">列序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDetailRegionFldsEN SetColIndex(this clsDetailRegionFldsEN objDetailRegionFldsEN, int intColIndex, string strComparisonOp="")
	{
objDetailRegionFldsEN.ColIndex = intColIndex; //列序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(conDetailRegionFlds.ColIndex) == false)
{
objDetailRegionFldsEN.dicFldComparisonOp.Add(conDetailRegionFlds.ColIndex, strComparisonOp);
}
else
{
objDetailRegionFldsEN.dicFldComparisonOp[conDetailRegionFlds.ColIndex] = strComparisonOp;
}
}
return objDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "intWidth">宽</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDetailRegionFldsEN SetWidth(this clsDetailRegionFldsEN objDetailRegionFldsEN, int intWidth, string strComparisonOp="")
	{
objDetailRegionFldsEN.Width = intWidth; //宽
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(conDetailRegionFlds.Width) == false)
{
objDetailRegionFldsEN.dicFldComparisonOp.Add(conDetailRegionFlds.Width, strComparisonOp);
}
else
{
objDetailRegionFldsEN.dicFldComparisonOp[conDetailRegionFlds.Width] = strComparisonOp;
}
}
return objDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsMultiRow">是否多行</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDetailRegionFldsEN SetIsMultiRow(this clsDetailRegionFldsEN objDetailRegionFldsEN, bool bolIsMultiRow, string strComparisonOp="")
	{
objDetailRegionFldsEN.IsMultiRow = bolIsMultiRow; //是否多行
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(conDetailRegionFlds.IsMultiRow) == false)
{
objDetailRegionFldsEN.dicFldComparisonOp.Add(conDetailRegionFlds.IsMultiRow, strComparisonOp);
}
else
{
objDetailRegionFldsEN.dicFldComparisonOp[conDetailRegionFlds.IsMultiRow] = strComparisonOp;
}
}
return objDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "intSeqNum">字段序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDetailRegionFldsEN SetSeqNum(this clsDetailRegionFldsEN objDetailRegionFldsEN, int intSeqNum, string strComparisonOp="")
	{
objDetailRegionFldsEN.SeqNum = intSeqNum; //字段序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(conDetailRegionFlds.SeqNum) == false)
{
objDetailRegionFldsEN.dicFldComparisonOp.Add(conDetailRegionFlds.SeqNum, strComparisonOp);
}
else
{
objDetailRegionFldsEN.dicFldComparisonOp[conDetailRegionFlds.SeqNum] = strComparisonOp;
}
}
return objDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strInOutTypeId">INOUT类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDetailRegionFldsEN SetInOutTypeId(this clsDetailRegionFldsEN objDetailRegionFldsEN, string strInOutTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strInOutTypeId, 2, conDetailRegionFlds.InOutTypeId);
clsCheckSql.CheckFieldForeignKey(strInOutTypeId, 2, conDetailRegionFlds.InOutTypeId);
objDetailRegionFldsEN.InOutTypeId = strInOutTypeId; //INOUT类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(conDetailRegionFlds.InOutTypeId) == false)
{
objDetailRegionFldsEN.dicFldComparisonOp.Add(conDetailRegionFlds.InOutTypeId, strComparisonOp);
}
else
{
objDetailRegionFldsEN.dicFldComparisonOp[conDetailRegionFlds.InOutTypeId] = strComparisonOp;
}
}
return objDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDetailRegionFldsEN SetInUse(this clsDetailRegionFldsEN objDetailRegionFldsEN, bool bolInUse, string strComparisonOp="")
	{
objDetailRegionFldsEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(conDetailRegionFlds.InUse) == false)
{
objDetailRegionFldsEN.dicFldComparisonOp.Add(conDetailRegionFlds.InUse, strComparisonOp);
}
else
{
objDetailRegionFldsEN.dicFldComparisonOp[conDetailRegionFlds.InUse] = strComparisonOp;
}
}
return objDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strChangeEvent">Change事件</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDetailRegionFldsEN SetChangeEvent(this clsDetailRegionFldsEN objDetailRegionFldsEN, string strChangeEvent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChangeEvent, 50, conDetailRegionFlds.ChangeEvent);
objDetailRegionFldsEN.ChangeEvent = strChangeEvent; //Change事件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(conDetailRegionFlds.ChangeEvent) == false)
{
objDetailRegionFldsEN.dicFldComparisonOp.Add(conDetailRegionFlds.ChangeEvent, strComparisonOp);
}
else
{
objDetailRegionFldsEN.dicFldComparisonOp[conDetailRegionFlds.ChangeEvent] = strComparisonOp;
}
}
return objDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strClickEvent">Click事件</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDetailRegionFldsEN SetClickEvent(this clsDetailRegionFldsEN objDetailRegionFldsEN, string strClickEvent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClickEvent, 50, conDetailRegionFlds.ClickEvent);
objDetailRegionFldsEN.ClickEvent = strClickEvent; //Click事件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(conDetailRegionFlds.ClickEvent) == false)
{
objDetailRegionFldsEN.dicFldComparisonOp.Add(conDetailRegionFlds.ClickEvent, strComparisonOp);
}
else
{
objDetailRegionFldsEN.dicFldComparisonOp[conDetailRegionFlds.ClickEvent] = strComparisonOp;
}
}
return objDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strVarId">变量Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDetailRegionFldsEN SetVarId(this clsDetailRegionFldsEN objDetailRegionFldsEN, string strVarId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVarId, 8, conDetailRegionFlds.VarId);
clsCheckSql.CheckFieldForeignKey(strVarId, 8, conDetailRegionFlds.VarId);
objDetailRegionFldsEN.VarId = strVarId; //变量Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(conDetailRegionFlds.VarId) == false)
{
objDetailRegionFldsEN.dicFldComparisonOp.Add(conDetailRegionFlds.VarId, strComparisonOp);
}
else
{
objDetailRegionFldsEN.dicFldComparisonOp[conDetailRegionFlds.VarId] = strComparisonOp;
}
}
return objDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strErrMsg">错误信息</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDetailRegionFldsEN SetErrMsg(this clsDetailRegionFldsEN objDetailRegionFldsEN, string strErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strErrMsg, 2000, conDetailRegionFlds.ErrMsg);
objDetailRegionFldsEN.ErrMsg = strErrMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(conDetailRegionFlds.ErrMsg) == false)
{
objDetailRegionFldsEN.dicFldComparisonOp.Add(conDetailRegionFlds.ErrMsg, strComparisonOp);
}
else
{
objDetailRegionFldsEN.dicFldComparisonOp[conDetailRegionFlds.ErrMsg] = strComparisonOp;
}
}
return objDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDetailRegionFldsEN SetPrjId(this clsDetailRegionFldsEN objDetailRegionFldsEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conDetailRegionFlds.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, conDetailRegionFlds.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conDetailRegionFlds.PrjId);
objDetailRegionFldsEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(conDetailRegionFlds.PrjId) == false)
{
objDetailRegionFldsEN.dicFldComparisonOp.Add(conDetailRegionFlds.PrjId, strComparisonOp);
}
else
{
objDetailRegionFldsEN.dicFldComparisonOp[conDetailRegionFlds.PrjId] = strComparisonOp;
}
}
return objDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDetailRegionFldsEN SetUpdUser(this clsDetailRegionFldsEN objDetailRegionFldsEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conDetailRegionFlds.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, conDetailRegionFlds.UpdUser);
objDetailRegionFldsEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(conDetailRegionFlds.UpdUser) == false)
{
objDetailRegionFldsEN.dicFldComparisonOp.Add(conDetailRegionFlds.UpdUser, strComparisonOp);
}
else
{
objDetailRegionFldsEN.dicFldComparisonOp[conDetailRegionFlds.UpdUser] = strComparisonOp;
}
}
return objDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDetailRegionFldsEN SetUpdDate(this clsDetailRegionFldsEN objDetailRegionFldsEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conDetailRegionFlds.UpdDate);
objDetailRegionFldsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(conDetailRegionFlds.UpdDate) == false)
{
objDetailRegionFldsEN.dicFldComparisonOp.Add(conDetailRegionFlds.UpdDate, strComparisonOp);
}
else
{
objDetailRegionFldsEN.dicFldComparisonOp[conDetailRegionFlds.UpdDate] = strComparisonOp;
}
}
return objDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDetailRegionFldsEN SetMemo(this clsDetailRegionFldsEN objDetailRegionFldsEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conDetailRegionFlds.Memo);
objDetailRegionFldsEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(conDetailRegionFlds.Memo) == false)
{
objDetailRegionFldsEN.dicFldComparisonOp.Add(conDetailRegionFlds.Memo, strComparisonOp);
}
else
{
objDetailRegionFldsEN.dicFldComparisonOp[conDetailRegionFlds.Memo] = strComparisonOp;
}
}
return objDetailRegionFldsEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsDetailRegionFldsEN objDetailRegionFldsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objDetailRegionFldsCond.IsUpdated(conDetailRegionFlds.mId) == true)
{
string strComparisonOpmId = objDetailRegionFldsCond.dicFldComparisonOp[conDetailRegionFlds.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conDetailRegionFlds.mId, objDetailRegionFldsCond.mId, strComparisonOpmId);
}
if (objDetailRegionFldsCond.IsUpdated(conDetailRegionFlds.RegionId) == true)
{
string strComparisonOpRegionId = objDetailRegionFldsCond.dicFldComparisonOp[conDetailRegionFlds.RegionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDetailRegionFlds.RegionId, objDetailRegionFldsCond.RegionId, strComparisonOpRegionId);
}
if (objDetailRegionFldsCond.IsUpdated(conDetailRegionFlds.FldId) == true)
{
string strComparisonOpFldId = objDetailRegionFldsCond.dicFldComparisonOp[conDetailRegionFlds.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDetailRegionFlds.FldId, objDetailRegionFldsCond.FldId, strComparisonOpFldId);
}
if (objDetailRegionFldsCond.IsUpdated(conDetailRegionFlds.OutFldId) == true)
{
string strComparisonOpOutFldId = objDetailRegionFldsCond.dicFldComparisonOp[conDetailRegionFlds.OutFldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDetailRegionFlds.OutFldId, objDetailRegionFldsCond.OutFldId, strComparisonOpOutFldId);
}
if (objDetailRegionFldsCond.IsUpdated(conDetailRegionFlds.LabelCaption) == true)
{
string strComparisonOpLabelCaption = objDetailRegionFldsCond.dicFldComparisonOp[conDetailRegionFlds.LabelCaption];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDetailRegionFlds.LabelCaption, objDetailRegionFldsCond.LabelCaption, strComparisonOpLabelCaption);
}
if (objDetailRegionFldsCond.IsUpdated(conDetailRegionFlds.CtlTypeId) == true)
{
string strComparisonOpCtlTypeId = objDetailRegionFldsCond.dicFldComparisonOp[conDetailRegionFlds.CtlTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDetailRegionFlds.CtlTypeId, objDetailRegionFldsCond.CtlTypeId, strComparisonOpCtlTypeId);
}
if (objDetailRegionFldsCond.IsUpdated(conDetailRegionFlds.ColSpan) == true)
{
string strComparisonOpColSpan = objDetailRegionFldsCond.dicFldComparisonOp[conDetailRegionFlds.ColSpan];
strWhereCond += string.Format(" And {0} {2} {1}", conDetailRegionFlds.ColSpan, objDetailRegionFldsCond.ColSpan, strComparisonOpColSpan);
}
if (objDetailRegionFldsCond.IsUpdated(conDetailRegionFlds.ColIndex) == true)
{
string strComparisonOpColIndex = objDetailRegionFldsCond.dicFldComparisonOp[conDetailRegionFlds.ColIndex];
strWhereCond += string.Format(" And {0} {2} {1}", conDetailRegionFlds.ColIndex, objDetailRegionFldsCond.ColIndex, strComparisonOpColIndex);
}
if (objDetailRegionFldsCond.IsUpdated(conDetailRegionFlds.Width) == true)
{
string strComparisonOpWidth = objDetailRegionFldsCond.dicFldComparisonOp[conDetailRegionFlds.Width];
strWhereCond += string.Format(" And {0} {2} {1}", conDetailRegionFlds.Width, objDetailRegionFldsCond.Width, strComparisonOpWidth);
}
if (objDetailRegionFldsCond.IsUpdated(conDetailRegionFlds.IsMultiRow) == true)
{
if (objDetailRegionFldsCond.IsMultiRow == true)
{
strWhereCond += string.Format(" And {0} = '1'", conDetailRegionFlds.IsMultiRow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conDetailRegionFlds.IsMultiRow);
}
}
if (objDetailRegionFldsCond.IsUpdated(conDetailRegionFlds.SeqNum) == true)
{
string strComparisonOpSeqNum = objDetailRegionFldsCond.dicFldComparisonOp[conDetailRegionFlds.SeqNum];
strWhereCond += string.Format(" And {0} {2} {1}", conDetailRegionFlds.SeqNum, objDetailRegionFldsCond.SeqNum, strComparisonOpSeqNum);
}
if (objDetailRegionFldsCond.IsUpdated(conDetailRegionFlds.InOutTypeId) == true)
{
string strComparisonOpInOutTypeId = objDetailRegionFldsCond.dicFldComparisonOp[conDetailRegionFlds.InOutTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDetailRegionFlds.InOutTypeId, objDetailRegionFldsCond.InOutTypeId, strComparisonOpInOutTypeId);
}
if (objDetailRegionFldsCond.IsUpdated(conDetailRegionFlds.InUse) == true)
{
if (objDetailRegionFldsCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conDetailRegionFlds.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conDetailRegionFlds.InUse);
}
}
if (objDetailRegionFldsCond.IsUpdated(conDetailRegionFlds.ChangeEvent) == true)
{
string strComparisonOpChangeEvent = objDetailRegionFldsCond.dicFldComparisonOp[conDetailRegionFlds.ChangeEvent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDetailRegionFlds.ChangeEvent, objDetailRegionFldsCond.ChangeEvent, strComparisonOpChangeEvent);
}
if (objDetailRegionFldsCond.IsUpdated(conDetailRegionFlds.ClickEvent) == true)
{
string strComparisonOpClickEvent = objDetailRegionFldsCond.dicFldComparisonOp[conDetailRegionFlds.ClickEvent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDetailRegionFlds.ClickEvent, objDetailRegionFldsCond.ClickEvent, strComparisonOpClickEvent);
}
if (objDetailRegionFldsCond.IsUpdated(conDetailRegionFlds.VarId) == true)
{
string strComparisonOpVarId = objDetailRegionFldsCond.dicFldComparisonOp[conDetailRegionFlds.VarId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDetailRegionFlds.VarId, objDetailRegionFldsCond.VarId, strComparisonOpVarId);
}
if (objDetailRegionFldsCond.IsUpdated(conDetailRegionFlds.ErrMsg) == true)
{
string strComparisonOpErrMsg = objDetailRegionFldsCond.dicFldComparisonOp[conDetailRegionFlds.ErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDetailRegionFlds.ErrMsg, objDetailRegionFldsCond.ErrMsg, strComparisonOpErrMsg);
}
if (objDetailRegionFldsCond.IsUpdated(conDetailRegionFlds.PrjId) == true)
{
string strComparisonOpPrjId = objDetailRegionFldsCond.dicFldComparisonOp[conDetailRegionFlds.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDetailRegionFlds.PrjId, objDetailRegionFldsCond.PrjId, strComparisonOpPrjId);
}
if (objDetailRegionFldsCond.IsUpdated(conDetailRegionFlds.UpdUser) == true)
{
string strComparisonOpUpdUser = objDetailRegionFldsCond.dicFldComparisonOp[conDetailRegionFlds.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDetailRegionFlds.UpdUser, objDetailRegionFldsCond.UpdUser, strComparisonOpUpdUser);
}
if (objDetailRegionFldsCond.IsUpdated(conDetailRegionFlds.UpdDate) == true)
{
string strComparisonOpUpdDate = objDetailRegionFldsCond.dicFldComparisonOp[conDetailRegionFlds.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDetailRegionFlds.UpdDate, objDetailRegionFldsCond.UpdDate, strComparisonOpUpdDate);
}
if (objDetailRegionFldsCond.IsUpdated(conDetailRegionFlds.Memo) == true)
{
string strComparisonOpMemo = objDetailRegionFldsCond.dicFldComparisonOp[conDetailRegionFlds.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDetailRegionFlds.Memo, objDetailRegionFldsCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDetailRegionFldsEN objDetailRegionFldsEN)
{
 if (objDetailRegionFldsEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objDetailRegionFldsEN.sfUpdFldSetStr = objDetailRegionFldsEN.getsfUpdFldSetStr();
clsDetailRegionFldsWApi.CheckPropertyNew(objDetailRegionFldsEN); 
bool bolResult = clsDetailRegionFldsWApi.UpdateRecord(objDetailRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDetailRegionFldsWApi.ReFreshCache(objDetailRegionFldsEN.PrjId);
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
 /// 获取唯一性条件串--DetailRegionFlds(详细区域字段), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:RegionId_FldId_OutFldId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsDetailRegionFldsEN objDetailRegionFldsEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objDetailRegionFldsEN == null) return "";
if (objDetailRegionFldsEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and RegionId = '{0}'", objDetailRegionFldsEN.RegionId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objDetailRegionFldsEN.FldId);
 sbCondition.AppendFormat(" and OutFldId = '{0}'", objDetailRegionFldsEN.OutFldId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objDetailRegionFldsEN.mId);
 sbCondition.AppendFormat(" and RegionId = '{0}'", objDetailRegionFldsEN.RegionId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objDetailRegionFldsEN.FldId);
 sbCondition.AppendFormat(" and OutFldId = '{0}'", objDetailRegionFldsEN.OutFldId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsDetailRegionFldsEN objDetailRegionFldsEN)
{
try
{
clsDetailRegionFldsWApi.CheckPropertyNew(objDetailRegionFldsEN); 
bool bolResult = clsDetailRegionFldsWApi.AddNewRecord(objDetailRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDetailRegionFldsWApi.ReFreshCache(objDetailRegionFldsEN.PrjId);
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
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDetailRegionFldsEN objDetailRegionFldsEN, string strWhereCond)
{
try
{
clsDetailRegionFldsWApi.CheckPropertyNew(objDetailRegionFldsEN); 
bool bolResult = clsDetailRegionFldsWApi.UpdateWithCondition(objDetailRegionFldsEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDetailRegionFldsWApi.ReFreshCache(objDetailRegionFldsEN.PrjId);
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
 /// 详细区域字段(DetailRegionFlds)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsDetailRegionFldsWApi
{
private static readonly string mstrApiControllerName = "DetailRegionFldsApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4WApi = null;

 public clsDetailRegionFldsWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsDetailRegionFldsEN objDetailRegionFldsEN)
{
if (!Object.Equals(null, objDetailRegionFldsEN.RegionId) && GetStrLen(objDetailRegionFldsEN.RegionId) > 10)
{
 throw new Exception("字段[区域Id]的长度不能超过10!");
}
if (!Object.Equals(null, objDetailRegionFldsEN.FldId) && GetStrLen(objDetailRegionFldsEN.FldId) > 8)
{
 throw new Exception("字段[字段Id]的长度不能超过8!");
}
if (!Object.Equals(null, objDetailRegionFldsEN.OutFldId) && GetStrLen(objDetailRegionFldsEN.OutFldId) > 8)
{
 throw new Exception("字段[OutFldId]的长度不能超过8!");
}
if (!Object.Equals(null, objDetailRegionFldsEN.LabelCaption) && GetStrLen(objDetailRegionFldsEN.LabelCaption) > 150)
{
 throw new Exception("字段[标签标题]的长度不能超过150!");
}
if (!Object.Equals(null, objDetailRegionFldsEN.CtlTypeId) && GetStrLen(objDetailRegionFldsEN.CtlTypeId) > 2)
{
 throw new Exception("字段[控件类型号]的长度不能超过2!");
}
if (!Object.Equals(null, objDetailRegionFldsEN.InOutTypeId) && GetStrLen(objDetailRegionFldsEN.InOutTypeId) > 2)
{
 throw new Exception("字段[INOUT类型ID]的长度不能超过2!");
}
if (!Object.Equals(null, objDetailRegionFldsEN.ChangeEvent) && GetStrLen(objDetailRegionFldsEN.ChangeEvent) > 50)
{
 throw new Exception("字段[Change事件]的长度不能超过50!");
}
if (!Object.Equals(null, objDetailRegionFldsEN.ClickEvent) && GetStrLen(objDetailRegionFldsEN.ClickEvent) > 50)
{
 throw new Exception("字段[Click事件]的长度不能超过50!");
}
if (!Object.Equals(null, objDetailRegionFldsEN.VarId) && GetStrLen(objDetailRegionFldsEN.VarId) > 8)
{
 throw new Exception("字段[变量Id]的长度不能超过8!");
}
if (!Object.Equals(null, objDetailRegionFldsEN.ErrMsg) && GetStrLen(objDetailRegionFldsEN.ErrMsg) > 2000)
{
 throw new Exception("字段[错误信息]的长度不能超过2000!");
}
if (!Object.Equals(null, objDetailRegionFldsEN.PrjId) && GetStrLen(objDetailRegionFldsEN.PrjId) > 4)
{
 throw new Exception("字段[工程Id]的长度不能超过4!");
}
if (!Object.Equals(null, objDetailRegionFldsEN.UpdUser) && GetStrLen(objDetailRegionFldsEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objDetailRegionFldsEN.UpdDate) && GetStrLen(objDetailRegionFldsEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objDetailRegionFldsEN.Memo) && GetStrLen(objDetailRegionFldsEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objDetailRegionFldsEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDetailRegionFldsEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsDetailRegionFldsEN objDetailRegionFldsEN;
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
objDetailRegionFldsEN = JsonConvert.DeserializeObject<clsDetailRegionFldsEN>(strJson);
return objDetailRegionFldsEN;
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
public static clsDetailRegionFldsEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsDetailRegionFldsEN objDetailRegionFldsEN;
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
objDetailRegionFldsEN = JsonConvert.DeserializeObject<clsDetailRegionFldsEN>(strJson);
return objDetailRegionFldsEN;
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
public static clsDetailRegionFldsEN GetObjBymIdCache(long lngmId,string strRegionId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsDetailRegionFldsEN._CurrTabName, strPrjId);
List<clsDetailRegionFldsEN> arrDetailRegionFldsObjLstCache = GetObjLstCache(strRegionId);
IEnumerable <clsDetailRegionFldsEN> arrDetailRegionFldsObjLst_Sel =
from objDetailRegionFldsEN in arrDetailRegionFldsObjLstCache
where objDetailRegionFldsEN.mId == lngmId 
select objDetailRegionFldsEN;
if (arrDetailRegionFldsObjLst_Sel.Count() == 0)
{
   clsDetailRegionFldsEN obj = clsDetailRegionFldsWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrDetailRegionFldsObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsDetailRegionFldsEN> GetObjLst(string strWhereCond)
{
 List<clsDetailRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDetailRegionFldsEN>>(strJson);
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
public static List<clsDetailRegionFldsEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsDetailRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDetailRegionFldsEN>>(strJson);
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
public static IEnumerable<clsDetailRegionFldsEN> GetObjLstByMIdLstCache(List<long> arrMId, string strRegionId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsDetailRegionFldsEN._CurrTabName, strPrjId);
List<clsDetailRegionFldsEN> arrDetailRegionFldsObjLstCache = GetObjLstCache(strRegionId);
IEnumerable <clsDetailRegionFldsEN> arrDetailRegionFldsObjLst_Sel =
from objDetailRegionFldsEN in arrDetailRegionFldsObjLstCache
where arrMId.Contains(objDetailRegionFldsEN.mId)
select objDetailRegionFldsEN;
return arrDetailRegionFldsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsDetailRegionFldsEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsDetailRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDetailRegionFldsEN>>(strJson);
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
public static List<clsDetailRegionFldsEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsDetailRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDetailRegionFldsEN>>(strJson);
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
public static List<clsDetailRegionFldsEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsDetailRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDetailRegionFldsEN>>(strJson);
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
public static List<clsDetailRegionFldsEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsDetailRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDetailRegionFldsEN>>(strJson);
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
public static int DelRecord(long lngmId)
{
string strAction = "DelRecord";
try
{
 clsDetailRegionFldsEN objDetailRegionFldsEN = clsDetailRegionFldsWApi.GetObjBymId(lngmId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngmId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsDetailRegionFldsWApi.ReFreshCache(objDetailRegionFldsEN.PrjId);
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
public static int DelDetailRegionFldss(List<string> arrmId)
{
string strAction = "DelDetailRegionFldss";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrmId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
 clsDetailRegionFldsEN objDetailRegionFldsEN = clsDetailRegionFldsWApi.GetObjBymId(long.Parse(arrmId[0]));
clsDetailRegionFldsWApi.ReFreshCache(objDetailRegionFldsEN.PrjId);
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
public static int DelDetailRegionFldssByCond(string strWhereCond)
{
string strAction = "DelDetailRegionFldssByCond";
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
public static bool AddNewRecord(clsDetailRegionFldsEN objDetailRegionFldsEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDetailRegionFldsEN>(objDetailRegionFldsEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDetailRegionFldsWApi.ReFreshCache(objDetailRegionFldsEN.PrjId);
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
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsDetailRegionFldsEN objDetailRegionFldsEN)
{
string strAction = "AddNewRecordWithReturnKey";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDetailRegionFldsEN>(objDetailRegionFldsEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDetailRegionFldsWApi.ReFreshCache(objDetailRegionFldsEN.PrjId);
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsDetailRegionFldsEN objDetailRegionFldsEN)
{
if (string.IsNullOrEmpty(objDetailRegionFldsEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objDetailRegionFldsEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDetailRegionFldsEN>(objDetailRegionFldsEN);
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
 /// <param name = "objDetailRegionFldsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsDetailRegionFldsEN objDetailRegionFldsEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objDetailRegionFldsEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objDetailRegionFldsEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objDetailRegionFldsEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDetailRegionFldsEN>(objDetailRegionFldsEN);
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
 /// <param name = "objDetailRegionFldsENS">源对象</param>
 /// <param name = "objDetailRegionFldsENT">目标对象</param>
 public static void CopyTo(clsDetailRegionFldsEN objDetailRegionFldsENS, clsDetailRegionFldsEN objDetailRegionFldsENT)
{
try
{
objDetailRegionFldsENT.mId = objDetailRegionFldsENS.mId; //mId
objDetailRegionFldsENT.RegionId = objDetailRegionFldsENS.RegionId; //区域Id
objDetailRegionFldsENT.FldId = objDetailRegionFldsENS.FldId; //字段Id
objDetailRegionFldsENT.OutFldId = objDetailRegionFldsENS.OutFldId; //OutFldId
objDetailRegionFldsENT.LabelCaption = objDetailRegionFldsENS.LabelCaption; //标签标题
objDetailRegionFldsENT.CtlTypeId = objDetailRegionFldsENS.CtlTypeId; //控件类型号
objDetailRegionFldsENT.ColSpan = objDetailRegionFldsENS.ColSpan; //跨列数
objDetailRegionFldsENT.ColIndex = objDetailRegionFldsENS.ColIndex; //列序号
objDetailRegionFldsENT.Width = objDetailRegionFldsENS.Width; //宽
objDetailRegionFldsENT.IsMultiRow = objDetailRegionFldsENS.IsMultiRow; //是否多行
objDetailRegionFldsENT.SeqNum = objDetailRegionFldsENS.SeqNum; //字段序号
objDetailRegionFldsENT.InOutTypeId = objDetailRegionFldsENS.InOutTypeId; //INOUT类型ID
objDetailRegionFldsENT.InUse = objDetailRegionFldsENS.InUse; //是否在用
objDetailRegionFldsENT.ChangeEvent = objDetailRegionFldsENS.ChangeEvent; //Change事件
objDetailRegionFldsENT.ClickEvent = objDetailRegionFldsENS.ClickEvent; //Click事件
objDetailRegionFldsENT.VarId = objDetailRegionFldsENS.VarId; //变量Id
objDetailRegionFldsENT.ErrMsg = objDetailRegionFldsENS.ErrMsg; //错误信息
objDetailRegionFldsENT.PrjId = objDetailRegionFldsENS.PrjId; //工程Id
objDetailRegionFldsENT.UpdUser = objDetailRegionFldsENS.UpdUser; //修改者
objDetailRegionFldsENT.UpdDate = objDetailRegionFldsENS.UpdDate; //修改日期
objDetailRegionFldsENT.Memo = objDetailRegionFldsENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsDetailRegionFldsEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsDetailRegionFldsEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsDetailRegionFldsEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsDetailRegionFldsEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsDetailRegionFldsEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsDetailRegionFldsEN._AttributeName)
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
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsDetailRegionFldsWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsDetailRegionFldsWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsDetailRegionFldsEN._CurrTabName, strPrjId);
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
if (clsDetailRegionFldsWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsDetailRegionFldsEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsDetailRegionFldsWApi.objCommFun4WApi.ReFreshCache(strPrjId.ToString());
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDetailRegionFldsEN> GetObjLstCache(string strRegionId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsDetailRegionFldsWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsDetailRegionFldsWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsDetailRegionFldsEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsDetailRegionFldsEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",conDetailRegionFlds.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsDetailRegionFldsEN._CurrTabName, strPrjId);
List<clsDetailRegionFldsEN> arrDetailRegionFldsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrDetailRegionFldsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDetailRegionFldsEN> GetObjLstCacheFromObjLst(string strRegionId,List<clsDetailRegionFldsEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsDetailRegionFldsWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsDetailRegionFldsWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsDetailRegionFldsEN._CurrTabName, strPrjId);
List<clsDetailRegionFldsEN> arrDetailRegionFldsObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrDetailRegionFldsObjLstCache = CacheHelper.Get<List<clsDetailRegionFldsEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrDetailRegionFldsObjLstCache = CacheHelper.Get<List<clsDetailRegionFldsEN>>(strKey);
}
return arrDetailRegionFldsObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsDetailRegionFldsEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conDetailRegionFlds.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(conDetailRegionFlds.RegionId, Type.GetType("System.String"));
objDT.Columns.Add(conDetailRegionFlds.FldId, Type.GetType("System.String"));
objDT.Columns.Add(conDetailRegionFlds.OutFldId, Type.GetType("System.String"));
objDT.Columns.Add(conDetailRegionFlds.LabelCaption, Type.GetType("System.String"));
objDT.Columns.Add(conDetailRegionFlds.CtlTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conDetailRegionFlds.ColSpan, Type.GetType("System.Int32"));
objDT.Columns.Add(conDetailRegionFlds.ColIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(conDetailRegionFlds.Width, Type.GetType("System.Int32"));
objDT.Columns.Add(conDetailRegionFlds.IsMultiRow, Type.GetType("System.Boolean"));
objDT.Columns.Add(conDetailRegionFlds.SeqNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conDetailRegionFlds.InOutTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conDetailRegionFlds.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(conDetailRegionFlds.ChangeEvent, Type.GetType("System.String"));
objDT.Columns.Add(conDetailRegionFlds.ClickEvent, Type.GetType("System.String"));
objDT.Columns.Add(conDetailRegionFlds.VarId, Type.GetType("System.String"));
objDT.Columns.Add(conDetailRegionFlds.ErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(conDetailRegionFlds.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conDetailRegionFlds.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conDetailRegionFlds.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conDetailRegionFlds.Memo, Type.GetType("System.String"));
foreach (clsDetailRegionFldsEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conDetailRegionFlds.mId] = objInFor[conDetailRegionFlds.mId];
objDR[conDetailRegionFlds.RegionId] = objInFor[conDetailRegionFlds.RegionId];
objDR[conDetailRegionFlds.FldId] = objInFor[conDetailRegionFlds.FldId];
objDR[conDetailRegionFlds.OutFldId] = objInFor[conDetailRegionFlds.OutFldId];
objDR[conDetailRegionFlds.LabelCaption] = objInFor[conDetailRegionFlds.LabelCaption];
objDR[conDetailRegionFlds.CtlTypeId] = objInFor[conDetailRegionFlds.CtlTypeId];
objDR[conDetailRegionFlds.ColSpan] = objInFor[conDetailRegionFlds.ColSpan];
objDR[conDetailRegionFlds.ColIndex] = objInFor[conDetailRegionFlds.ColIndex];
objDR[conDetailRegionFlds.Width] = objInFor[conDetailRegionFlds.Width];
objDR[conDetailRegionFlds.IsMultiRow] = objInFor[conDetailRegionFlds.IsMultiRow];
objDR[conDetailRegionFlds.SeqNum] = objInFor[conDetailRegionFlds.SeqNum];
objDR[conDetailRegionFlds.InOutTypeId] = objInFor[conDetailRegionFlds.InOutTypeId];
objDR[conDetailRegionFlds.InUse] = objInFor[conDetailRegionFlds.InUse];
objDR[conDetailRegionFlds.ChangeEvent] = objInFor[conDetailRegionFlds.ChangeEvent];
objDR[conDetailRegionFlds.ClickEvent] = objInFor[conDetailRegionFlds.ClickEvent];
objDR[conDetailRegionFlds.VarId] = objInFor[conDetailRegionFlds.VarId];
objDR[conDetailRegionFlds.ErrMsg] = objInFor[conDetailRegionFlds.ErrMsg];
objDR[conDetailRegionFlds.PrjId] = objInFor[conDetailRegionFlds.PrjId];
objDR[conDetailRegionFlds.UpdUser] = objInFor[conDetailRegionFlds.UpdUser];
objDR[conDetailRegionFlds.UpdDate] = objInFor[conDetailRegionFlds.UpdDate];
objDR[conDetailRegionFlds.Memo] = objInFor[conDetailRegionFlds.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 详细区域字段(DetailRegionFlds)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4DetailRegionFlds : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strRegionId)
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
clsDetailRegionFldsWApi.ReFreshThisCache(strRegionId);
}
}

}